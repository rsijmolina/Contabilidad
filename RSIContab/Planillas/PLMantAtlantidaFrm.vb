Imports System.IO
Public Class PLMantAtlantidaFrm
    Dim tbTabla As DataTable
    Dim dsDatos As DataSet
    Dim lstEmplsFrm As New ListaEmpleadosFom
    Dim PlCls As New PLClassLib.PlClass
    Private Sub PLMantAtlantidaFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIPrincipal
        Me.Top = 10
        Me.Left = 10

        PlCls.DBconStr = strcnCAD
        tbTabla = New DataTable("Empleados")
        tbTabla.Columns.Add("Codigo")
        tbTabla.Columns.Add("Nombre")
        tbTabla.Columns.Add("Cuenta")
        tbTabla.Columns.Add("Identidad")
        tbTabla.Columns.Add("Tipo")
        dsDatos = New DataSet("EmpleadosAtlantida")
        dsDatos.Tables.Add(tbTabla)
        dbgrdEmps.DataSource = dsDatos.Tables("Empleados")
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Dim sw As StreamWriter  'Archivos de texto
        Dim clRSICad As New Rsierpgencl.Rsierpcl.Cadenas
        Dim strId As String, strArch As String, strCadena As String
        If txtCodigoEmpresa.Text = "" Then
            MsgBox("Debe ingresar el código de la empresa", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        dlgGuardarArchivo.FileName = "MantEmp" & clRSICad.RellenarIzq(Now.Day, 2, "0") & clRSICad.RellenarIzq(Now.Month, 2, "0") & Now.Year & ".txt"
        dlgGuardarArchivo.ShowDialog()
        strArch = dlgGuardarArchivo.FileName

        Try
            strCadena = ""
            For Each reg As DataRow In dsDatos.Tables("Empleados").Rows
                strId = ""
                For i As Int16 = 1 To Strings.Len(reg("Identidad"))
                    If Strings.Mid(reg("Identidad"), i, 1) <> "-" Then
                        strId = strId & Strings.Mid(reg("Identidad"), i, 1)
                    End If
                Next
                strCadena = strCadena & reg("Tipo") & clRSICad.RellenarDer(reg("Codigo"), 16, " ") & txtCodigoEmpresa.Text & "001" & clRSICad.RellenarDer(reg("Cuenta"), 12, " ") & clRSICad.RellenarDer(strId, 13, " ") & clRSICad.RellenarDer(reg("Nombre"), 40, " ") & Space(91) & vbCrLf
            Next
            sw = New StreamWriter(strArch)
            sw.Write(strCadena)
            MsgBox("Archivo generado...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            sw.Close()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btnAgregarTodosEmpleados_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarTodosEmpleados.Click
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drEmps As SqlClient.SqlDataReader
        Dim drReg As DataRow

        Try
            cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = "SELECT CodigoEmpleado, Nombre1 + ' ' + ISNULL(Nombre2,'' ) + ' ' + Apellido1 + ' ' + ISNULL(Apellido2, '') AS Nombre, Identificacion1,NoCuentaBancaria FROM PLEmpleados WHERE Banco='ATLANTIDA' AND RetiradoDeEmpresa=0"
            drEmps = cmdInComando.ExecuteReader
            Do While drEmps.Read()
                drReg = tbTabla.NewRow
                drReg("Codigo") = drEmps("CodigoEmpleado")
                drReg("Nombre") = drEmps("Nombre")
                drReg("Cuenta") = drEmps("NoCuentaBancaria")
                drReg("Identidad") = drEmps("Identificacion1")
                drReg("Tipo") = "A" 'A=Adicionar, M=Modificar, E=Inactivar
                tbTabla.Rows.Add(drReg)
            Loop
            cnSQLConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btnAgregarEmpleado_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarEmpleado.Click
        Try
            lstEmplsFrm.ShowDialog()
            If lstEmplsFrm.DialogResult = Windows.Forms.DialogResult.OK Then
                Dim drEmpl As SqlClient.SqlDataReader = PlCls.drDatosEmpleado(lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Empleado").Value)
                If drEmpl("Banco") = "ATLANTIDA" Then
                    Dim drReg As DataRow = tbTabla.NewRow
                    drReg("Codigo") = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Empleado").Value
                    drReg("Nombre") = drEmpl("Nombre1") & IIf(IsDBNull(drEmpl("Nombre2")), " ", " " & drEmpl("Nombre2") & " ") & drEmpl("Apellido1") & IIf(IsDBNull(drEmpl("Apellido2")), " ", " " & drEmpl("Apellido2") & " ")
                    drReg("Cuenta") = drEmpl("NoCuentaBancaria")
                    drReg("Identidad") = drEmpl("Identificacion1")
                    drReg("Tipo") = "A" 'A=Adicionar, M=Modificar, E=Inactivar
                    tbTabla.Rows.Add(drReg)
                Else
                    MsgBox("Este empleado no está configurado con Banco Atlántida", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class