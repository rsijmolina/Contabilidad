Imports System.IO
Public Class CTConsolidacionExpImpFrm
    Dim RSIcadcl As New Rsierpgencl.Rsierpcl.Cadenas
    Private _Tipo As String
    Public Property Tipo() As String
        Get
            Return _Tipo
        End Get
        Set(ByVal value As String)
            _Tipo = value
        End Set
    End Property
    Private Sub CTConsolidacionExpImpFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Int16 = 1 To 12
            cmbMesConsolidar.Items.Add(RSIcadcl.MesLetras(i))
        Next
        cmbMesConsolidar.Text = RSIcadcl.MesLetras(Now.Month)
        c1numAñoConsolidar.Value = Now.Year
    End Sub

    Private Sub butBuscarArch_Click(sender As Object, e As EventArgs) Handles butBuscarArch.Click
        If Tipo = "EXP" Then
            If SaveFileDlgArchivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtNombreArchivo.Text = SaveFileDlgArchivo.FileName & ".txt"
            End If
        Else
            If OpenFileDlgArchivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtNombreArchivo.Text = OpenFileDlgArchivo.FileName
            End If
        End If
    End Sub

    Private Sub butCancelar_Click(sender As Object, e As EventArgs) Handles butCancelar.Click
        Me.Close()
    End Sub

    Private Sub butAceptar_Click(sender As Object, e As EventArgs) Handles butAceptar.Click
        lblMensaje.Visible = True
        lblMensaje.Refresh()
        If Tipo = "EXP" Then
            Exportar()
        Else
            Importar()
        End If
        lblMensaje.Visible = False
        lblMensaje.Refresh()
    End Sub
    Private Sub Exportar()
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdComando As SqlClient.SqlCommand
        Dim drCat As SqlClient.SqlDataReader, drSaldos As SqlClient.SqlDataReader
        Dim strCadena As String


        Try
            cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
            cnSQLConexion.Open()
            cmdComando = cnSQLConexion.CreateCommand
            cmdComando.CommandType = CommandType.Text
            cmdComando.CommandText = "SELECT * FROM CTCatalogoCuentas ORDER BY Cuenta"
            drCat = cmdComando.ExecuteReader
            Dim sw As StreamWriter = New StreamWriter(txtNombreArchivo.Text)
            strCadena = My.Settings.RSIIdEmpresaActual & vbCrLf
            strCadena = strCadena & My.Settings.RSIEmpresaActual & vbCrLf
            strCadena = strCadena & c1numAñoConsolidar.Text & vbCrLf
            strCadena = strCadena & RSIcadcl.NumMes(cmbMesConsolidar.Text) & vbCrLf
            strCadena = strCadena & "INICATALOGO" & vbCrLf
            Do While drCat.Read
                strCadena = strCadena & RSIcadcl.RellenarDer(drCat("Cuenta"), 30, " ")
                strCadena = strCadena & RSIcadcl.RellenarDer(drCat("Descripcion"), 100, " ")
                strCadena = strCadena & RSIcadcl.RellenarDer(Trim(Str(drCat("Nivel"))), 2, " ")
                strCadena = strCadena & IIf(drCat("Posteable"), "S", "N")
                If IsDBNull(drCat("CuentaSuperior")) Then
                    strCadena = strCadena & RSIcadcl.Replicar(" ", 30)
                Else
                    strCadena = strCadena & RSIcadcl.RellenarDer(drCat("CuentaSuperior"), 30, " ")
                End If
                strCadena = strCadena & drCat("Naturaleza")
                strCadena = strCadena & drCat("Tipo")
                If IsDBNull(drCat("Ambito")) Then
                    strCadena = strCadena & " "
                Else
                    strCadena = strCadena & drCat("Ambito")
                End If
                If IsDBNull(drCat("CentroCosto")) Then
                    strCadena = strCadena & RSIcadcl.Replicar(" ", 30)
                Else
                    strCadena = strCadena & RSIcadcl.RellenarDer(drCat("CentroCosto"), 30, " ")
                End If
                strCadena = strCadena & vbCrLf
            Loop
            strCadena = strCadena & "FINCATALOGO" & vbCrLf
            cnSQLConexion.Close()
            cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
            cnSQLConexion.Open()
            cmdComando = cnSQLConexion.CreateCommand
            cmdComando.CommandType = CommandType.Text
            cmdComando.CommandText = "SELECT * FROM CTSaldosMensuales WHERE Año=" & c1numAñoConsolidar.Value & " AND Mes=" & RSIcadcl.NumMes(cmbMesConsolidar.Text) & " ORDER BY Cuenta"
            drSaldos = cmdComando.ExecuteReader
            strCadena = strCadena & "INISALDOS" & vbCrLf
            Do While drSaldos.Read
                strCadena = strCadena & RSIcadcl.RellenarDer(drSaldos("Cuenta"), 30, " ")
                strCadena = strCadena & Trim(Str(drSaldos("Año")))
                strCadena = strCadena & RSIcadcl.RellenarDer(Trim(Str(drSaldos("Mes"))), 2, " ")
                If IsDBNull(drSaldos("CuentaSuperior")) Then
                    strCadena = strCadena & RSIcadcl.Replicar(" ", 30)
                Else
                    strCadena = strCadena & RSIcadcl.RellenarDer(drSaldos("CuentaSuperior"), 30, " ")
                End If
                strCadena = strCadena & RSIcadcl.RellenarDer(Trim(Str(drSaldos("Nivel"))), 2, " ")
                strCadena = strCadena & RSIcadcl.RellenarDer(Trim(Str(drSaldos("SaldoAnterior"))), 20, " ")
                strCadena = strCadena & RSIcadcl.RellenarDer(Trim(Str(drSaldos("DebitosMes"))), 20, " ")
                strCadena = strCadena & RSIcadcl.RellenarDer(Trim(Str(drSaldos("CreditosMes"))), 20, " ")
                strCadena = strCadena & vbCrLf
            Loop
            strCadena = strCadena & "FINSALDOS" & vbCrLf
            sw.WriteLine(strCadena)
            sw.Close()
            cnSQLConexion.Close()
            MsgBox("Proceso terminado...", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
        End Try

    End Sub
    Private Sub Importar()
        Dim sr As StreamReader
        Dim RSIcadcl As New Rsierpgencl.Rsierpcl.Cadenas
        Me.CTCatalogoCuentasTableAdapter.Connection.ConnectionString = strcnCAD
        Me.CTSaldosMensualesTableAdapter.Connection.ConnectionString = strcnCAD
        Dim strCadena As String
        Dim drCat As DataRowView, drSaldos As DataRowView

        Try
            sr = New StreamReader(txtNombreArchivo.Text)
            Dim strEmpID As Int16 = sr.ReadLine
            Dim strEmp As String = sr.ReadLine
            Dim intAño As Int16 = CInt(sr.ReadLine)
            Dim intMes As Int16 = CInt(sr.ReadLine)
            If intAño <> c1numAñoConsolidar.Value Or intMes <> RSIcadcl.NumMes(cmbMesConsolidar.Text) Then
                MsgBox("Los Datos del Archivo no Coinciden con el Año o Mes Seleccionado, en el Archivo el Año es: " & intAño & ", Mes: " & intMes, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                sr.Close()
                Exit Sub
            End If
            If MsgBox("Desea Importar los Datos de la Empresa " & strEmpID & " " & strEmp & ", Año: " & intAño & ", Mes: " & intMes, MsgBoxStyle.YesNo + MsgBoxStyle.Question) = vbNo Then
                sr.Close()
                Exit Sub
            End If
            If chkBoxIniTablas.Checked Then
                EliminarDatos()
            End If
            strCadena = sr.ReadLine 'INICATALOGO
            Do While sr.Peek() >= 0
                strCadena = sr.ReadLine()
                If strCadena <> "FINCATALOGO" Then
                    CTCatalogoCuentasBindingSource.Filter = "Cuenta='" & Trim(Strings.Left(strCadena, 30)) & "'"
                    drCat = CTCatalogoCuentasBindingSource.Current
                    If drCat Is Nothing Then
                        CTCatalogoCuentasBindingSource.AddNew()
                        drCat = CTCatalogoCuentasBindingSource.Current
                    End If
                    drCat("Cuenta") = Trim(Strings.Left(strCadena, 30))
                    drCat("Descripcion") = Trim(Strings.Mid(strCadena, 31, 100))
                    drCat("Nivel") = CInt(Strings.Mid(strCadena, 131, 2))
                    If Strings.Mid(strCadena, 133, 1) = "S" Then
                        drCat("Posteable") = 1
                    Else
                        drCat("Posteable") = 0
                    End If
                    If Trim(Strings.Mid(strCadena, 134, 30)) <> "" Then
                        drCat("CuentaSuperior") = Trim(Strings.Mid(strCadena, 134, 30))
                    End If
                    drCat("Naturaleza") = Strings.Mid(strCadena, 164, 1)
                    drCat("Tipo") = Strings.Mid(strCadena, 165, 1)
                    If Trim(Strings.Mid(strCadena, 166, 1)) <> "" Then
                        drCat("Ambito") = Strings.Mid(strCadena, 166, 1)
                    End If
                    If Trim(Strings.Mid(strCadena, 167, 30)) <> "" Then
                        drCat("CentroCosto") = Trim(Strings.Mid(strCadena, 167, 30))
                    End If
                    CTCatalogoCuentasBindingSource.EndEdit()
                    CTCatalogoCuentasBindingSource.RemoveFilter()
                Else
                    Exit Do
                End If
            Loop
            strCadena = sr.ReadLine()   'INISALDOS
            Do While sr.Peek() >= 0
                strCadena = sr.ReadLine()
                If strCadena <> "FINSALDOS" Then
                    CTSaldosMensualesBindingSource.Filter = "Cuenta='" & Trim(Strings.Left(strCadena, 30)) & "'"
                    drSaldos = CTSaldosMensualesBindingSource.Current
                    If drSaldos Is Nothing Then
                        CTSaldosMensualesBindingSource.AddNew()
                        drSaldos = CTSaldosMensualesBindingSource.Current
                    End If
                    drSaldos("Cuenta") = Trim(Strings.Left(strCadena, 30))
                    drSaldos("Año") = CInt(Trim(Strings.Mid(strCadena, 31, 4)))
                    drSaldos("Mes") = CInt(Trim(Strings.Mid(strCadena, 35, 2)))
                    If Trim(Strings.Mid(strCadena, 37, 30)) <> "" Then
                        drSaldos("CuentaSuperior") = Trim(Strings.Mid(strCadena, 37, 30))
                    End If
                    drSaldos("Nivel") = CInt(Trim(Strings.Mid(strCadena, 67, 2)))
                    drSaldos("SaldoAnterior") = drSaldos("SaldoAnterior") + CDec(Trim(Strings.Mid(strCadena, 69, 20)))
                    drSaldos("DebitosMes") = drSaldos("DebitosMes") + CDec(Trim(Strings.Mid(strCadena, 89, 20)))
                    drSaldos("CreditosMes") = drSaldos("CreditosMes") + CDec(Trim(Strings.Mid(strCadena, 109, 20)))
                    CTSaldosMensualesBindingSource.EndEdit()
                    CTSaldosMensualesBindingSource.RemoveFilter()
                Else
                    Exit Do
                End If
            Loop
            sr.Close()
            Me.CTCatalogoCuentasTableAdapter.Update(Me.CTCatalogoCuentasDataSet.CTCatalogoCuentas)
            Me.CTSaldosMensualesTableAdapter.Update(Me.CTSaldosMensualesDataSet.CTSaldosMensuales)
            MsgBox("Proceso terminado...", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try

    End Sub
    Private Sub EliminarDatos()
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
        cnSQLConexion.Open()
        cmdComando = cnSQLConexion.CreateCommand
        cmdComando.CommandType = CommandType.Text
        cmdComando.CommandText = "DELETE FROM CTTransaccionesDetalle"
        cmdComando.ExecuteNonQuery()
        cnSQLConexion.Close()

        cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
        cnSQLConexion.Open()
        cmdComando = cnSQLConexion.CreateCommand
        cmdComando.CommandType = CommandType.Text
        cmdComando.CommandText = "DELETE FROM CTTransaccionesEncabezado"
        cmdComando.ExecuteNonQuery()
        cnSQLConexion.Close()

        cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
        cnSQLConexion.Open()
        cmdComando = cnSQLConexion.CreateCommand
        cmdComando.CommandType = CommandType.Text
        cmdComando.CommandText = "DELETE FROM CTSaldosMensuales"
        cmdComando.ExecuteNonQuery()
        cnSQLConexion.Close()

        cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
        cnSQLConexion.Open()
        cmdComando = cnSQLConexion.CreateCommand
        cmdComando.CommandType = CommandType.Text
        cmdComando.CommandText = "DELETE FROM CTCatalogoCuentas"
        cmdComando.ExecuteNonQuery()
        cnSQLConexion.Close()
    End Sub
End Class