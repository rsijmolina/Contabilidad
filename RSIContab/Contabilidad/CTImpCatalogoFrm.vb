Imports System
Imports System.IO
Public Class CTImpCatalogoFrm

    Private Sub CTImpCatalogoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CTConfTableAdapter.Connection.ConnectionString = strcnCAD
        Me.CTCatalogoCuentasTableAdapter.Connection.ConnectionString = strcnCAD
        Me.PlantillasCatalogoEncTableAdapter.Connection.ConnectionString = crfgXNN
        Me.DBTableAdapter.Connection.ConnectionString = crfgXNN
        Me.PlantillasCatalogoEncTableAdapter.Fill(Me.CTPlantillasCatDataSet.PlantillasCatalogoEnc)
        Me.DBTableAdapter.Fill(Me.CTEmpresasDataSet.DB, 0)
    End Sub

    Private Sub butAceptar_Click(sender As Object, e As EventArgs) Handles butAceptar.Click
        If MsgBox("¿Está seguro que desea importar el catálogo de cuentas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If RadioButImpEntidad.Checked Then
                If ExistenDatosCatDest() Then
                    If MsgBox("El catálogo de cuentas ya contiene datos, desea reemplazarlo", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                        EliminarDatosCatalogo()
                        EliminarDatosConf()
                    End If
                End If
                ImpDeEntidad()
                ImpCtConf()
                MsgBox("Proceso Terminado...", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            ElseIf RadioButImpArchTexto.Checked Then

            ElseIf RadioButImpPlantilla.Checked Then
            End If
        End If
    End Sub

    Private Sub butCancelar_Click(sender As Object, e As EventArgs) Handles butCancelar.Click
        Me.Close()
    End Sub

    Private Sub butBuscarCtaIni_Click(sender As Object, e As EventArgs) Handles butBuscarCtaIni.Click
        'OpenFileDlgArchivo.InitialDirectory = Application.StartupPath & "\Recibidos\"
        If OpenFileDlgArchivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtNombreArchivo.Text = OpenFileDlgArchivo.FileName
        End If
    End Sub
    Private Sub ImpDeEntidad()
        Dim RSISegClGen As New Rsierpgencl.Rsierpcl.EncripDesencrip
        Dim RSIClData As New Rsierpgencl.Rsierpcl.Data
        Dim drDatosEmp As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drCatFuente As SqlClient.SqlDataReader
        Dim strCon As String

        Try
            drDatosEmp = RSIClData.drDatosEmp(crfgXNN, cmbEntidades.SelectedValue)
            strCon = "Data Source=" & drDatosEmp("Servidor") & "\" & drDatosEmp("Instancia") & ";Initial Catalog=" & drDatosEmp("BaseDatos") & ";User ID=" & RSISegClGen.DecryptData(My.Settings.xupiy) & ";Password=" & RSISegClGen.DecryptData(My.Settings.acvse)
            cnSQLConexion = New SqlClient.SqlConnection(strCon)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = "SELECT * FROM CTCatalogoCuentas ORDER BY Cuenta"
            drCatFuente = cmdInComando.ExecuteReader
            Do While drCatFuente.Read
                CTCatalogoCuentasBindingSource.AddNew()
                Dim drCatDest As DataRowView = CTCatalogoCuentasBindingSource.Current
                drCatDest("Cuenta") = drCatFuente("Cuenta")
                drCatDest("Descripcion") = drCatFuente("Descripcion")
                drCatDest("Nivel") = drCatFuente("Nivel")
                drCatDest("Posteable") = drCatFuente("Posteable")
                drCatDest("CuentaSuperior") = drCatFuente("CuentaSuperior")
                drCatDest("Naturaleza") = drCatFuente("Naturaleza")
                drCatDest("Tipo") = drCatFuente("Tipo")
                drCatDest("Ambito") = drCatFuente("Ambito")
                drCatDest("CentroCosto") = drCatFuente("CentroCosto")
            Loop
            CTCatalogoCuentasBindingSource.EndEdit()
            Me.CTCatalogoCuentasTableAdapter.Update(Me.CTCatalogoCuentasDataSet.CTCatalogoCuentas)
            drCatFuente.Close()
            cnSQLConexion.Close()            
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub ImpCtConf()
        Dim RSISegClGen As New Rsierpgencl.Rsierpcl.EncripDesencrip
        Dim RSIClData As New Rsierpgencl.Rsierpcl.Data
        Dim drDatosEmp As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drConfFuente As SqlClient.SqlDataReader
        Dim strCon As String

        Try
            drDatosEmp = RSIClData.drDatosEmp(crfgXNN, cmbEntidades.SelectedValue)
            strCon = "Data Source=" & drDatosEmp("Servidor") & "\" & drDatosEmp("Instancia") & ";Initial Catalog=" & drDatosEmp("BaseDatos") & ";User ID=" & RSISegClGen.DecryptData(My.Settings.xupiy) & ";Password=" & RSISegClGen.DecryptData(My.Settings.acvse)
            cnSQLConexion = New SqlClient.SqlConnection(strCon)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = "SELECT * FROM CTConf"
            drConfFuente = cmdInComando.ExecuteReader
            Do While drConfFuente.Read
                CTConfBindingSource.AddNew()
                Dim drConfDest As DataRowView = CTConfBindingSource.Current
                drConfDest("AñoEnProceso") = drConfFuente("AñoEnProceso")
                drConfDest("MesEnProceso") = drConfFuente("MesEnProceso")
                drConfDest("MesDeCierre") = drConfFuente("MesDeCierre")
                drConfDest("FechaProceso") = drConfFuente("FechaProceso")
                drConfDest("AñoComparacion1") = drConfFuente("AñoComparacion1")
                drConfDest("AñoComparacion2") = drConfFuente("AñoComparacion2")
                drConfDest("IndiceActivos") = drConfFuente("IndiceActivos")
                drConfDest("IndicePasivos") = drConfFuente("IndicePasivos")
                drConfDest("IndiceCapital") = drConfFuente("IndiceCapital")
                drConfDest("IndiceIngresos") = drConfFuente("IndiceIngresos")
                drConfDest("IndiceCostos") = drConfFuente("IndiceCostos")
                drConfDest("IndiceGastos") = drConfFuente("IndiceGastos")
                drConfDest("IndiceOrden") = drConfFuente("IndiceOrden")
                drConfDest("Niveles") = drConfFuente("Niveles")
                drConfDest("DigitosNivel1") = drConfFuente("DigitosNivel1")
                drConfDest("DigitosNivel2") = drConfFuente("DigitosNivel2")
                drConfDest("DigitosNivel3") = drConfFuente("DigitosNivel3")
                drConfDest("DigitosNivel4") = drConfFuente("DigitosNivel4")
                drConfDest("DigitosNivel5") = drConfFuente("DigitosNivel5")
                drConfDest("DigitosNivel6") = drConfFuente("DigitosNivel6")
                drConfDest("DigitosNivel7") = drConfFuente("DigitosNivel7")
                drConfDest("DigitosNivel8") = drConfFuente("DigitosNivel8")
                drConfDest("DigitosNivel9") = drConfFuente("DigitosNivel9")
                drConfDest("DigitosNivel10") = drConfFuente("DigitosNivel10")
                drConfDest("FormatoLibre") = drConfFuente("FormatoLibre")
                drConfDest("NivelActivoRepBalGen") = drConfFuente("NivelActivoRepBalGen")
                drConfDest("NivelPasivoRepBalGen") = drConfFuente("NivelPasivoRepBalGen")
                drConfDest("NivelCapitalRepBalGen") = drConfFuente("NivelCapitalRepBalGen")
                drConfDest("NivelIngresosRepEstResul") = drConfFuente("NivelIngresosRepEstResul")
                drConfDest("NivelCostosRepEstResul") = drConfFuente("NivelCostosRepEstResul")
                drConfDest("NivelGastosRepEstResul") = drConfFuente("NivelGastosRepEstResul")
                drConfDest("NumeracionAutoPartidas") = drConfFuente("NumeracionAutoPartidas")
                drConfDest("UltimaPartida") = drConfFuente("UltimaPartida")
                drConfDest("PermisoDescuadre") = drConfFuente("PermisoDescuadre")
                drConfDest("Ejecutivo1") = drConfFuente("Ejecutivo1")
                drConfDest("Cargo1") = drConfFuente("Cargo1")
                drConfDest("Ejecutivo2") = drConfFuente("Ejecutivo2")
                drConfDest("Cargo2") = drConfFuente("Cargo2")
                drConfDest("Ejecutivo3") = drConfFuente("Ejecutivo3")
                drConfDest("Cargo3") = drConfFuente("Cargo3")
                drConfDest("MostrarEjecutivos") = drConfFuente("MostrarEjecutivos")
                drConfDest("RellenoCerosNiveles") = drConfFuente("RellenoCerosNiveles")
                drConfDest("CatalogoCreado") = drConfFuente("CatalogoCreado")
                drConfDest("TipoPresupuesto") = drConfFuente("TipoPresupuesto")
                drConfDest("PresupuestoPorGenero") = drConfFuente("PresupuestoPorGenero")
                drConfDest("TituloMoneda") = drConfFuente("TituloMoneda")
                drConfDest("TituloCambioMoneda") = drConfFuente("TituloCambioMoneda")
            Loop
            CTConfBindingSource.EndEdit()
            Me.CTConfTableAdapter.Update(Me.CTConfDataSet.CTConf)
            drConfFuente.Close()
            cnSQLConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub EliminarDatosCatalogo()
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        Try
            cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = "DELETE FROM CTCatalogoCuentas"
            cmdInComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub EliminarDatosConf()
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        Try
            cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = "DELETE FROM CTConf"
            cmdInComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Function ExistenDatosCatDest() As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drCant As SqlClient.SqlDataReader

        Try
            ExistenDatosCatDest = False
            cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = "SELECT TOP (1) Cuenta FROM CTCatalogoCuentas"
            drCant = cmdInComando.ExecuteReader
            If drCant.HasRows Then
                'If drCant(0) > 0 Then
                ExistenDatosCatDest = True
                'End If
            End If
            cnSQLConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Function
    Private Sub ImportDeArchivo()
        Dim sr As StreamReader
        Dim i As Int16
        Dim drConfDest As DataRowView
        Dim mSeccionConf As Boolean

        Try
            mSeccionConf = False
            sr = New StreamReader(txtNombreArchivo.Text)
            i = 0
            CTConfBindingSource.AddNew()
            drConfDest = CTConfBindingSource.Current
            Do While sr.Peek() >= 0
                Dim strCadena As String = sr.ReadLine()
                If strCadena = "***CONF***" Then    'Verificar si es la seccion de configuracion
                    mSeccionConf = True
                    Continue Do
                End If
                If mSeccionConf Then
                    If i <= 22 Then
                        drConfDest(i) = CInt(Strings.Trim(strCadena))
                    End If
                    i = i + 1
                Else
                    CTCatalogoCuentasBindingSource.AddNew()
                    Dim drCatDest As DataRowView = CTCatalogoCuentasBindingSource.Current
                    drCatDest("Cuenta") = Strings.Trim(Strings.Left(strCadena, 15))
                    drCatDest("Descripcion") = Strings.Trim(Mid(strCadena, 16, 50))
                    drCatDest("Nivel") = CInt(Strings.Mid(strCadena, 66, 1))
                    drCatDest("Posteable") = IIf(Strings.Mid(strCadena, 67, 1) = "S", 1, 0)
                    If Strings.Trim(Strings.Mid(strCadena, 68, 15)) <> "" Then
                        drCatDest("CuentaSuperior") = Strings.Trim(Strings.Mid(strCadena, 68, 15))
                    End If
                    drCatDest("Naturaleza") = Strings.Mid(strCadena, 83, 1)
                    drCatDest("Tipo") = Strings.Mid(strCadena, 84, 1)
                    If Strings.Trim(Strings.Mid(strCadena, 85, 1)) <> "" Then
                        drCatDest("Ambito") = Strings.Mid(strCadena, 85, 1)
                    End If
                    If Strings.Trim(Strings.Mid(strCadena, 86, 30)) <> "" Then
                        drCatDest("CentroCosto") = Strings.Mid(strCadena, 86, 30)
                    End If
                End If
            Loop
            sr.Close()
            CTCatalogoCuentasBindingSource.EndEdit()
            Me.CTCatalogoCuentasTableAdapter.Update(Me.CTCatalogoCuentasDataSet.CTCatalogoCuentas)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class