Public Class PLConstanciasFrm
    Dim lstEmplsFrm As New ListaEmpleadosFom
    Dim drDatosEmp As SqlClient.SqlDataReader
    Dim drDatosSedes As SqlClient.SqlDataReader
    Dim drCnf As SqlClient.SqlDataReader
    Dim drDedEmpl As SqlClient.SqlDataReader
    Dim PlCls As New PLClassLib.PlClass
    Dim RSICls As New Rsierpgencl.Rsierpcl.Cadenas
    Dim CodigosDeducciones As New Collection
    Dim ValorDeducciones As New Collection
    Dim EncripDecrip As New Rsierpgencl.Rsierpcl.RijndaelSimple 'Encriptar y desencriptar cadenas de caracteres
    Dim strCarpetaEmpClave As String
    Dim bExisteCarpeta As Boolean
    Dim plainText As String
    Dim cipherText As String
    Dim passPhrase As String
    Dim saltValue As String
    Dim hashAlgorithm As String
    Dim passwordIterations As Integer
    Dim initVector As String
    Dim keySize As Integer
    Dim strSexoEmpleado As String

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnBuscarEmpleado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscarEmpleado.Click
        lstEmplsFrm.ShowDialog()
        If lstEmplsFrm.DialogResult = Windows.Forms.DialogResult.OK Then
            c1txtCodigoEmpleado.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("CodigoEmpleado").Value
            lblNombreEmpleado.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre1").Value & IIf(String.IsNullOrEmpty(lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre2").Value), "", " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre2").Value) _
                & " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido1").Value & IIf(String.IsNullOrEmpty(lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido2").Value), "", " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido2").Value)
            CargarConstancias()
        End If
    End Sub

    Private Sub c1txtCodigoEmpleado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1txtCodigoEmpleado.Validating
        If Not String.IsNullOrEmpty(c1txtCodigoEmpleado.Text) Then
            drDatosEmp = PlCls.drDatosEmpleado(c1txtCodigoEmpleado.Text)
            If drDatosEmp.HasRows Then
                lblNombreEmpleado.Text = drDatosEmp("Nombre1") & IIf(String.IsNullOrEmpty(drDatosEmp("Nombre2")), "", " " & drDatosEmp("Nombre2")) _
                    & " " & drDatosEmp("Apellido1") & IIf(String.IsNullOrEmpty(drDatosEmp("Apellido2")), "", " " & drDatosEmp("Apellido2"))
                strSexoEmpleado = drDatosEmp("Sexo")
                CargarConstancias()
                CargarDeducciones()
            Else
                MsgBox("Empleado No Exsite", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            End If
            drDatosEmp.Close()
        End If
    End Sub

    Private Sub PLConstanciasFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.CarpetaEmpleados.Length = 0 Then
            MsgBox("Debe de configurar la carpeta de empleados en la opción: Archivo, Configuración de Esta Estación", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            btnGenerar.Enabled = False
        End If

        PlCls.DBconStr = strcnCAD
        drCnf = PlCls.drConf
        lstEmplsFrm.EmpleadosRetirados = False
        lstEmplsFrm.OrdenarPorCodigo = False
        btnBuscarEmpleado.Enabled = True
        bExisteCarpeta = True
        passPhrase = "elshadai"       ' Cualquier cadena de caracteres
        saltValue = "israel"        ' Cualquier cadena de caracteres
        hashAlgorithm = "SHA1"         ' Puede ser "MD5"
        passwordIterations = 2         ' Cualquier número
        initVector = "@1B2c3D4e5F6g7H8" ' must be 16 bytes
        keySize = 256                   ' puede ser 192 or 128
        Try
            If My.Settings.NecesitaClaveCarpetaEmpleados Then
                strCarpetaEmpClave = EncripDecrip.Decrypt(My.Settings.ClaveCarpetaEmpleados, passPhrase, saltValue, hashAlgorithm, passwordIterations, initVector, keySize)
                My.Computer.Network.UploadFile(System.AppDomain.CurrentDomain.BaseDirectory() & "\" & "ConstanciaSueldo.doc", My.Settings.CarpetaEmpleados, My.Settings.UsuarioCarpetaEmpleados, strCarpetaEmpClave)
            End If
            If Not My.Computer.FileSystem.DirectoryExists(My.Settings.CarpetaEmpleados) Then
                If MsgBox("La Carpeta Especificada Para Empleados No Existe o No Está Disponible, Desea Continuar de Todas Formas?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
                    btnGenerar.Enabled = False
                    bExisteCarpeta = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            btnGenerar.Enabled = False
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        drCnf.Close()
        Me.Close()
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Dim mDatos As DataRowView
        Dim intLineaAnterior As Int16, c As Int16
        Dim strNombreDoc As String
        Dim MyWord As Microsoft.Office.Interop.Word.Application
        Dim drDatosEmpPlani As SqlClient.SqlDataReader
        Dim decRAP As Decimal, decIHSS As Decimal, decPorcSeguro As Decimal, decDedMaxSeguro As Decimal, decSubTotDed As Decimal, decOtrasDed As Decimal

        Try
            PrincipalBindingSource.AddNew()
            mDatos = PrincipalBindingSource.Current
            mDatos("CodigoEmpleado") = c1txtCodigoEmpleado.Text
            mDatos("Fecha") = Date.Now
            mDatos("Descripcion") = c1txtDescripcion.Text
            PrincipalBindingSource.EndEdit()
            PLConstanciasTableAdapter.Update(Me.PLConstanciasDataSet.PLConstancias)
            mDatos = PrincipalBindingSource.Current
            strNombreDoc = "CONST_" & Trim(Str(mDatos("No"))) & "_" & c1txtCodigoEmpleado.Text
            mDatos("NombreDocumento") = strNombreDoc & ".Doc"
            PrincipalBindingSource.EndEdit()
            PLConstanciasTableAdapter.Update(Me.PLConstanciasDataSet.PLConstancias)

            drDatosEmpPlani = PlCls.drDatosEmpleadoPlanilla(c1txtCodigoEmpleado.Text)
            drDatosSedes = PlCls.drDatosSedesPlanilla(drDatosEmpPlani("CodigoSede"))
            If drDatosSedes("DeducirSS") Then   'Deducir el seguro por sede
                If drDatosEmpPlani("EsDocente") Then
                    decPorcSeguro = drDatosSedes("PorcentajeDocenteSS")
                    decDedMaxSeguro = drDatosSedes("DeduccionMaxDocenteSS")
                Else
                    decPorcSeguro = drDatosSedes("PorcentajeSS")
                    decDedMaxSeguro = drDatosSedes("DeduccionMaxSS")
                End If
            Else
                If drDatosEmpPlani("EsDocente") Then
                    decPorcSeguro = drCnf("PorcentajeDocenteSS")
                    decDedMaxSeguro = drCnf("DeduccionMaxDocenteSS")
                Else
                    decPorcSeguro = drCnf("PorcentajeSS")
                    decDedMaxSeguro = drCnf("DeduccionMaxSS")
                End If
            End If
            decIHSS = Math.Round(drDatosEmpPlani("SalarioMensual") * (decPorcSeguro / 100), 2)
            If decIHSS > decDedMaxSeguro Then
                decIHSS = decDedMaxSeguro
            End If

            If drDatosEmpPlani("NoDeducirRAP") Then
                decRAP = 0
            Else
                decRAP = Math.Round(drDatosEmpPlani("SalarioMensual") * (drCnf("PorcentajeRAP") / 100), 2)
                If decRAP > drCnf("DeduccionMaxRAP") Then
                    decRAP = drCnf("DeduccionMaxRAP")
                End If
            End If

            MyWord = New Microsoft.Office.Interop.Word.Application
            With MyWord
                If My.Settings.RSIEmpresaInstalada = "ENLACE" Then
                    .Documents.Open(System.AppDomain.CurrentDomain.BaseDirectory() & "\" & "ConstanciaSueldo.doc")
                Else
                    .Documents.Open(System.AppDomain.CurrentDomain.BaseDirectory() & "\" & "ConstanciaSueldo2.doc")
                End If
                '.ActiveDocument.Bookmarks("Empresa").Range.Text = My.Settings.RSIEmpresaActual
                If radiobutMasculino.Checked Then
                    .ActiveDocument.Bookmarks("ElSuscrito").Range.Text = "El suscrito"
                Else
                    .ActiveDocument.Bookmarks("ElSuscrito").Range.Text = "La suscrita"
                End If
                .ActiveDocument.Bookmarks("PuestoFirmante").Range.Text = c1txtPuesto.Text
                .ActiveDocument.Bookmarks("Empresa").Range.Text = My.Settings.RSIEmpresaActual

                If strSexoEmpleado = "M" Then
                    .ActiveDocument.Bookmarks("Referencia").Range.Text = "el empleado"
                Else
                    .ActiveDocument.Bookmarks("Referencia").Range.Text = "la empleada"
                End If
                .ActiveDocument.Bookmarks("Empleado").Range.Text = lblNombreEmpleado.Text
                If Not String.IsNullOrEmpty(drDatosEmpPlani("FechaIngreso").ToString) Then
                    .ActiveDocument.Bookmarks("FechaInicio").Range.Text = Microsoft.VisualBasic.DateAndTime.Day(drDatosEmpPlani("FechaIngreso")) & " de " & RSICls.MesLetras(Microsoft.VisualBasic.DateAndTime.Month(drDatosEmpPlani("FechaIngreso"))) & " de " & Microsoft.VisualBasic.DateAndTime.Year(drDatosEmpPlani("FechaIngreso"))
                Else
                    .ActiveDocument.Bookmarks("FechaInicio").Range.Text = "_____"
                End If
                .ActiveDocument.Bookmarks("Puesto").Range.Text = DescripcionPuesto(drDatosEmpPlani("CodigoPuesto"))
                .ActiveDocument.Bookmarks("Sueldo").Range.Text = Format(drDatosEmpPlani("SalarioMensual"), "#,##0.00") & " (" & RSICls.NumLetra(drDatosEmpPlani("SalarioMensual")) & ")"
                .ActiveDocument.Bookmarks("SueldoBruto").Range.Text = Format(drDatosEmpPlani("SalarioMensual"), "#,##0.00")

                If chklstboxConstancias.CheckedItems.Count > 0 Then
                    intLineaAnterior = 3
                    'Insertar las líneas necesarias
                    For c = 0 To chklstboxConstancias.Items.Count - 1
                        If chklstboxConstancias.GetItemCheckState(c) = CheckState.Checked Then
                            .ActiveDocument.Tables(1).Rows.Add(.ActiveDocument.Tables(1).Rows(intLineaAnterior))
                            intLineaAnterior = intLineaAnterior + 1
                        End If
                    Next
                    'Agregar las deducciones
                    intLineaAnterior = 3
                    decSubTotDed = 0
                    decOtrasDed = 0
                    For c = 0 To chklstboxConstancias.Items.Count - 1
                        If chklstboxConstancias.GetItemCheckState(c) = CheckState.Checked Then
                            .ActiveDocument.Tables(1).Cell(intLineaAnterior, 1).Range.Text = chklstboxConstancias.Items.Item(c)
                            .ActiveDocument.Tables(1).Cell(intLineaAnterior, 2).Range.Text = Format(CDec(ValorDeducciones.Item(c + 1)), "#,##0.00")
                            decSubTotDed = decSubTotDed + ValorDeducciones.Item(c + 1)
                            intLineaAnterior = intLineaAnterior + 1
                        End If
                    Next
                End If

                .ActiveDocument.Bookmarks("RAP").Range.Text = Format(decRAP, "#,##0.00")
                If My.Settings.RSIEmpresaInstalada <> "ENLACE" Then
                    .ActiveDocument.Bookmarks("IHSS").Range.Text = Format(decIHSS, "#,##0.00")
                    .ActiveDocument.Bookmarks("TotalDeducciones").Range.Text = Format(decSubTotDed + decRAP + decIHSS, "#,##0.00")
                Else
                    .ActiveDocument.Bookmarks("TotalDeducciones").Range.Text = Format(decSubTotDed + decRAP, "#,##0.00")
                End If
                If My.Settings.RSIEmpresaInstalada <> "ENLACE" Then
                    .ActiveDocument.Bookmarks("SueldoNeto").Range.Text = Format(drDatosEmpPlani("SalarioMensual") - decRAP - decSubTotDed - decIHSS, "#,##0.00")
                Else
                    .ActiveDocument.Bookmarks("SueldoNeto").Range.Text = Format(drDatosEmpPlani("SalarioMensual") - decRAP - decSubTotDed, "#,##0.00")
                End If
                .ActiveDocument.Bookmarks("FechaHoy").Range.Text = " a los " & Date.Now.Day & " días del mes de " & RSICls.MesLetras(Date.Now.Month) & " de " & Date.Now.Year
                .ActiveDocument.Bookmarks("Firmante").Range.Text = c1txtFirma.Text
                .ActiveDocument.Bookmarks("PuestoFirmante2").Range.Text = c1txtPuesto.Text
                If bExisteCarpeta Then
                    .ActiveDocument.SaveAs(My.Settings.CarpetaEmpleados & "\" & strNombreDoc)
                Else
                    .ActiveDocument.SaveAs(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & strNombreDoc)
                End If
                '.ActiveDocument.Close()
                .Visible = True
            End With
            MyWord = Nothing
            'ProcID = Shell(My.Settings.CarpetaWord & " " & strNombreDoc, AppWinStyle.NormalFocus)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        Finally
            drDatosEmpPlani.Close()
            drDatosSedes.Close()
        End Try

    End Sub
    Private Sub CargarConstancias()
        Me.PLConstanciasTableAdapter.Fill(Me.PLConstanciasDataSet.PLConstancias, c1txtCodigoEmpleado.Text)
    End Sub
    Private Sub CargarDeducciones()
        chklstboxConstancias.Items.Clear()
        CodigosDeducciones.Clear()
        ValorDeducciones.Clear()
        drDedEmpl = PlCls.drDeduccionesPend(c1txtCodigoEmpleado.Text)
        While drDedEmpl.Read
            chklstboxConstancias.Items.Add(drDedEmpl("DescripcionDeduccion"))
            CodigosDeducciones.Add(drDedEmpl("CodigoDeduccion"))
            ValorDeducciones.Add(drDedEmpl("Valor"))
        End While
    End Sub
    Private Function DescripcionPuesto(ByVal strCodPuesto) As String
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drDatPuestos As SqlClient.SqlDataReader

        cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT * FROM PLPuestos WHERE CodigoPuesto='" & strCodPuesto & "'"
        drDatPuestos = cmdInComando.ExecuteReader
        drDatPuestos.Read()
        If drDatPuestos.HasRows Then
            DescripcionPuesto = drDatPuestos("DescripcionPuesto")
        Else
            DescripcionPuesto = ""
        End If
        cnSQLConexion.Close()
        Return DescripcionPuesto
    End Function

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub lblNombreEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNombreEmpleado.Click

    End Sub
End Class