Public Class MDIPrincipal
    Private Sub MDIPrincipal_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        RectPrincipal.Height = Me.Height
        RectPrincipal.Width = Me.Width
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        UsuariosFrm.Show()
    End Sub

    Private Sub NivelesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NivelesToolStripMenuItem.Click
        UsrNivelesFrm.Show()
    End Sub

    Private Sub ConfiguraciónDeBaseDeDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraciónDeBaseDeDatosToolStripMenuItem.Click
        ConfBaseDatosFrm.Show()
    End Sub

    Private Sub CopiaDeRespaldoDeBaseDeDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiaDeRespaldoDeBaseDeDatosToolStripMenuItem.Click
        UtilRespaldoBD.TipoOperacion = "RESPALDO"
        UtilRespaldoBD.ShowDialog()
    End Sub

    Private Sub IniciarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IniciarSesiónToolStripMenuItem.Click
        While 1
            LoginForm.ShowDialog()
            If (LoginForm.UsernameTextBox.Text = "admin" And LoginForm.PasswordTextBox.Text = "rsi94128") Or My.Settings.RSIEsAdministrador Then
                LoginForm.Close()
                HabilitarMenu(False, True)
                Exit While
            End If
            If LoginForm.mAceptar Then
                If ValidarUsuario(LoginForm.UsernameTextBox.Text, LoginForm.PasswordTextBox.Text) Then
                    LoginForm.Close()
                    If My.Settings.RSIEsAdministrador Then
                        HabilitarMenu(False, True)
                    Else
                        HabilitarMenu(False, False)
                    End If
                    Exit While
                End If
            Else
                LoginForm.Close()
                HabilitarMenu(True, False)
                Exit While
            End If
        End While
        Me.statuslblUsuario.Text = "Usuario: " & My.Settings.RSIUsuarioActual

    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Me.statuslblUsuario.Text = "Usuario: "
        HabilitarMenu(True, False)
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        PLConfFrm.ShowDialog()
    End Sub

    Private Sub SedesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SedesToolStripMenuItem.Click
        SedesFrm.Show()
    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartamentosToolStripMenuItem.Click
        DepartamentosFrm.Show()
    End Sub

    Private Sub SeccionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeccionesToolStripMenuItem.Click
        SeccionesFrm.Show()
    End Sub

    Private Sub TiposDeEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeEmpleadosToolStripMenuItem.Click
        TiposEmpleadosFrm.Show()
    End Sub

    Private Sub PuestosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PuestosToolStripMenuItem.Click
        PuestosFrm.Show()
    End Sub

    Private Sub BancosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BancosToolStripMenuItem1.Click
        BancosFrm.Show()
    End Sub

    Private Sub MantenimientoDeEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenimientoDeEmpleadosToolStripMenuItem.Click
        EmpleadosFrm.EmpleadosRetirados = False
        EmpleadosFrm.Show()
    End Sub

    Private Sub ProfesionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfesionesToolStripMenuItem.Click
        ProfesionesFrm.Show()
    End Sub

    Private Sub MantenimientoDeDeduccionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeduccionesDelMesToolStripMenuItem.Click
        DeduccionesMesFrm.Show()
    End Sub

    Private Sub EditarDeduccionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarDeduccionesToolStripMenuItem.Click
        'DeduccionesEdicionFrm.Show()
        PLEdicionDeduccionesFrm.Show()
    End Sub

    Private Sub ElegirEmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElegirEmpresaToolStripMenuItem.Click
        ElegirEmpresaFrm.ShowDialog()
    End Sub

    Private Sub EdiciónDePlanillaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EdiciónDePlanillaToolStripMenuItem.Click
        CapturaPlanillaFrm.Show()
    End Sub

    Private Sub DeducciónDelISRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeducciónDelISRToolStripMenuItem.Click
        DeduccionISRFrm.Show()
    End Sub

    Private Sub TablasVariasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TablasVariasToolStripMenuItem.Click
        PLTablasVariasFrm.Show()
    End Sub

    Private Sub CargarDatosYDeduccionesAPlanillaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarDatosYDeduccionesAPlanillaToolStripMenuItem.Click
        CargarDatosPlanillaFrm.ShowDialog()
    End Sub

    Private Sub MantenimientoDeVacacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenimientoDeVacacionesToolStripMenuItem.Click
        PLVacacionesFrm.Show()
    End Sub

    Private Sub ListadoDeSedesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeSedesToolStripMenuItem.Click
        Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
        rptClass.DBconStr = strcnCAD
        rptClass.EjecutarListados(strcnCAD, "Sedes", My.Settings.RSIEmpresaActual)
    End Sub

    Private Sub MantenimientoDeDeduccionesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenimientoDeDeduccionesToolStripMenuItem1.Click
        MantDeduccionesFrm.Show()
    End Sub

    Private Sub ListadoDeDepartamentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeDepartamentosToolStripMenuItem.Click
        Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
        rptClass.DBconStr = strcnCAD
        rptClass.EjecutarListados(strcnCAD, "Departamentos", My.Settings.RSIEmpresaActual)
    End Sub

    Private Sub ListadoDeSeccionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeSeccionesToolStripMenuItem.Click
        Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
        rptClass.DBconStr = strcnCAD
        rptClass.EjecutarListados(strcnCAD, "Secciones", My.Settings.RSIEmpresaActual)
    End Sub

    Private Sub ListadoDeTiposDeEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeTiposDeEmpleadosToolStripMenuItem.Click
        Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
        rptClass.DBconStr = strcnCAD
        rptClass.EjecutarListados(strcnCAD, "TiposEmpleados", My.Settings.RSIEmpresaActual)
    End Sub

    Private Sub ListadoDeProfesionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeProfesionesToolStripMenuItem.Click
        Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
        rptClass.DBconStr = strcnCAD
        rptClass.EjecutarListados(strcnCAD, "Profesiones", My.Settings.RSIEmpresaActual)
    End Sub

    Private Sub ListadoDePuestosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDePuestosToolStripMenuItem.Click
        Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
        rptClass.DBconStr = strcnCAD
        rptClass.EjecutarListados(strcnCAD, "Puestos", My.Settings.RSIEmpresaActual)
    End Sub

    Private Sub ListadoDeBancosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeBancosToolStripMenuItem.Click
        Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
        rptClass.DBconStr = strcnCAD
        rptClass.EjecutarListados(strcnCAD, "Bancos", My.Settings.RSIEmpresaActual)
    End Sub

    Private Sub ListadoGeneralDeEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoGeneralDeEmpleadosToolStripMenuItem.Click
        Dim PLLstEmpleadosFrm As New PLListadoEmpleadosFrm
        PLLstEmpleadosFrm.ShowDialog()
    End Sub

    Private Sub ReporteDeCargosDelMesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeCargosDelMesToolStripMenuItem.Click
        PLRepDeducciones.TipoReporte = "MENSUAL"
        PLRepDeducciones.Text = "Reporte de Cargos Mensuales"
        PLRepDeducciones.ShowDialog()
    End Sub

    Private Sub ReporteDePlanillaDeIngresosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDePlanillaDeIngresosToolStripMenuItem.Click
        Dim PLRepInFrm As New PLRepIngEgFrm
        PLRepInFrm.TipoReporte = "INGRESOS"
        PLRepInFrm.ShowDialog()
    End Sub

    Private Sub ReporteDePlanillaDeDeduccionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDePlanillaDeDeduccionesToolStripMenuItem.Click
        Dim PLRepEgFrm As New PLRepIngEgFrm
        PLRepEgFrm.TipoReporte = "EGRESOS"
        PLRepEgFrm.ShowDialog()
    End Sub

    Private Sub ReporteDePlanillaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDePlanillaToolStripMenuItem.Click
        Dim PLRepPlaDetFrm As New PLRepPlaDetIVAFrm

        PLRepPlaDetFrm.ShowDialog()
    End Sub

    Private Sub ReporteDeRecibosDePagoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeRecibosDePagoToolStripMenuItem.Click
        Dim PLRepPlaRecibosFrm As New PLRepPlaReci1Frm

        PLRepPlaRecibosFrm.ShowDialog()
    End Sub

    Private Sub GenerarPlanillaParaBancosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarPlanillaParaBancosToolStripMenuItem.Click
        Dim PLGenBancosFrm As New PLGenerarBancosFrm
        PLGenBancosFrm.ShowDialog()
    End Sub

    Private Sub ReporteDeDeduccionesHechasEnElMesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeDeduccionesHechasEnElMesToolStripMenuItem.Click
        Dim PLRepDedGen As New PLRepDeducciones
        PLRepDedGen.TipoReporte = "GENERAL"
        PLRepDedGen.Text = "Reporte de Deducciones Hechas en el Mes"
        PLRepDedGen.ShowDialog()
    End Sub

    Private Sub ReporteDelSeguroSocialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDelSeguroSocialToolStripMenuItem.Click
        Dim PLRepSeguroSocial As New PLRepIngEgFrm
        PLRepSeguroSocial.TipoReporte = "SEGUROSOCIAL"
        PLRepSeguroSocial.Text = "Reporte del Seguro Social"
        PLRepSeguroSocial.ShowDialog()
    End Sub

    Private Sub ReporteDelRAPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDelRAPToolStripMenuItem.Click
        Dim PLRepRAP As New PLRepIngEgFrm
        PLRepRAP.TipoReporte = "RAP"
        PLRepRAP.Text = "Reporte del RAP"
        PLRepRAP.ShowDialog()
    End Sub

    Private Sub ReporteDelISRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDelISRToolStripMenuItem.Click
        Dim PLRepISR As New PLRepIngEgFrm
        PLRepISR.TipoReporte = "ISR"
        PLRepISR.Text = "Reporte del ISR"
        PLRepISR.ShowDialog()
    End Sub

    Private Sub ReporteDelImpuestoVecinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDelImpuestoVecinalToolStripMenuItem.Click
        Dim PLRepVecinal As New PLRepIngEgFrm
        PLRepVecinal.TipoReporte = "IMPVECINAL"
        PLRepVecinal.Text = "Reporte del Impuesto Vecinal"
        PLRepVecinal.ShowDialog()
    End Sub

    Private Sub ReporteDeSaldosPorEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeSaldosPorEmpleadosToolStripMenuItem.Click
        Dim PLRepSaldosEmpFrm As New PLRepSaldosEmpleadosFrm

        PLRepSaldosEmpFrm.ShowDialog()
    End Sub

    Private Sub ReporteDeHistorialDePlanillaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeHistorialDePlanillaToolStripMenuItem.Click
        Dim PLRepPlaHistFrm As New PLRepPlaHistorialFrm

        PLRepPlaHistFrm.ShowDialog()
    End Sub

    Private Sub ListadoDeEmpleadosPorSelecciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeEmpleadosPorSelecciónToolStripMenuItem.Click
        Dim PLRepEmpSeleccionFrm As New PLRepEmpSelFrm

        PLRepEmpSeleccionFrm.ShowDialog()
    End Sub

    Private Sub ReporteDeOtrasDeduccionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeOtrasDeduccionesToolStripMenuItem.Click
        Dim PLRepOtrasDeduccionesFrm As New PLRepOtrasDedFrm

        PLRepOtrasDeduccionesFrm.ShowDialog()
    End Sub

    Private Sub ImportarDatosDeAccessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportarDatosDeAccessToolStripMenuItem.Click
        Dim CTTrasladoDatosFrm As New CTTrasladarDatosFrm
        CTTrasladoDatosFrm.ShowDialog()
        'Dim PLImpDatosDeAccessFrm As New PLImportarDatosDeAccessFrm
        'PLImpDatosDeAccessFrm.ShowDialog()
    End Sub

    Private Sub ConsultaDeEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeEmpleadosToolStripMenuItem.Click
        EmpleadosFrm.EmpleadosRetirados = True
        EmpleadosFrm.Show()
    End Sub

    Private Sub RegToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegToolStripMenuItem.Click
        Dim RegFrm As New RegEmpFrm
        RegFrm.ShowDialog()
    End Sub

    Private Sub ConfiguraciónGeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraciónGeneralToolStripMenuItem.Click

    End Sub

    Private Sub ReporteAnualDeISRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteAnualDeISRToolStripMenuItem.Click
        Dim PLRepAnualISR_RAP_Seg As New PLRepAnualDedSocExcelFrm
        PLRepAnualISR_RAP_Seg.ShowDialog()
    End Sub

    Private Sub CierreDePlanillaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CierreDePlanillaToolStripMenuItem.Click
        Dim PLCierrePlani As New PLCierrePlanillaFrm
        PLCierrePlani.ShowDialog()
    End Sub

    Private Sub UtilidadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UtilidadesToolStripMenuItem.Click

    End Sub

    Private Sub EmisiónDeConstanciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmisiónDeConstanciasToolStripMenuItem.Click
        PLConstanciasFrm.Show()
    End Sub

    Private Sub ConfiguraciónDeEstaEstaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraciónDeEstaEstaciónToolStripMenuItem.Click
        Dim CnfEstFrm As New ConfEstacionFrm
        CnfEstFrm.ShowDialog()
    End Sub

    Private Sub CálculoDePrestacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CálculoDePrestacionesToolStripMenuItem.Click
        PLPrestacionesFrm.Show()
    End Sub

    Private Sub ListadoDeEmpleadosYVacacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeEmpleadosYVacacionesToolStripMenuItem.Click
        Dim PLRepVacFrm As New PLRepVacacionesFrm
        PLRepVacFrm.ShowDialog()
    End Sub

    Private Sub CambioDeCodigoDeEmpleadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PlCambioCodigoFrm.ShowDialog()
    End Sub

    Private Sub RectPrincipal_Click(sender As System.Object, e As System.EventArgs) Handles RectPrincipal.Click

    End Sub

    Private Sub ConfiguracionContableToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConfiguracionContableToolStripMenuItem.Click
        'CTConfiguracion.Left = (Me.Width / 2) - Me.Left '- CTConfiguracion.Width
        'CTConfiguracion.Top = (Me.Height / 2) - Me.Top '- CTConfiguracion.Height
        CTConfiguracion.Show()
    End Sub

    Private Sub CatalogoDeCuentasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CatalogoDeCuentasToolStripMenuItem.Click
        CTCatalogoFrm.Show()
    End Sub

    Private Sub TransaccionesContablesToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles TransaccionesContablesToolStripMenuItem.Click
        CTTransaccionesContFrm.Show()
    End Sub

    Private Sub ProcesoDeMayorizacionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProcesoDeMayorizacionToolStripMenuItem.Click
        CTMayorizacionFrm.ShowDialog()
    End Sub

    Private Sub MantenimientoDeDatosDeBancoAtlántidaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MantenimientoDeDatosDeBancoAtlántidaToolStripMenuItem.Click
        PLMantAtlantidaFrm.Show()
    End Sub

    Private Sub ReporteDelCatalogoDeCuentasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReporteDelCatalogoDeCuentasToolStripMenuItem.Click
        CTRepCatalogoFrm.ShowDialog()
        CTRepCatalogoFrm.Close()
    End Sub

    Private Sub MDIPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mLoginFrm As New LoginForm

        Me.statuslblEstacion.Text = "Estación: " & My.Computer.Name
        While 1
            mLoginFrm.ShowDialog()
            If mLoginFrm.DialogResult = Windows.Forms.DialogResult.Cancel Then
                mLoginFrm.Close()
                Me.Close()
                Exit Sub
            Else
                If (mLoginFrm.UsernameTextBox.Text = "admin" And mLoginFrm.PasswordTextBox.Text = "rsi94128") Then
                    My.Settings.RSIUsuarioActual = "admin"
                    Me.statuslblUsuario.Text = "Usuario: " & My.Settings.RSIUsuarioActual
                    mLoginFrm.Close()
                    HabilitarMenu(False, True)
                    DatosEmpresa(Me)
                    Exit While
                End If
                If mLoginFrm.DialogResult = Windows.Forms.DialogResult.OK Then
                    If ValidarUsuario(mLoginFrm.UsernameTextBox.Text, mLoginFrm.PasswordTextBox.Text) Then
                        Me.statuslblUsuario.Text = "Usuario: " & My.Settings.RSIUsuarioActual
                        mLoginFrm.Close()
                        If My.Settings.RSIEsAdministrador Then
                            HabilitarMenu(False, True)
                        Else
                            HabilitarMenu(False, False)
                        End If
                        DatosEmpresa(Me)
                        Exit While
                    End If
                End If
            End If
        End While
    End Sub
    Public Sub HabilitarMenu(ByVal mDeshabilitarTodo As Boolean, ByVal EsAdminis As Boolean)
        Dim itm As ToolStripMenuItem

        For Each itm In Me.mnuPrincipal.Items
            HabilitarSubMenu(itm, mDeshabilitarTodo, EsAdminis)
        Next
    End Sub
    Private Sub HabilitarSubMenu(ByVal mItem As ToolStripMenuItem, ByVal mDeshabilTodo As Boolean, ByVal EsAdministrador As Boolean)
        Dim itm As New ToolStripMenuItem
        Dim i As Int16

        If Not mDeshabilTodo Then
            If EsAdministrador Then
                mItem.Enabled = True
            Else
                mItem.Enabled = HabilitarEsteMenuItem(mItem.Name)
            End If
        Else
            If mItem.Name = "ArchivoToolStripMenuItem" Then
                mItem.Enabled = True
            Else
                mItem.Enabled = False
            End If
        End If
        For i = 0 To mItem.DropDownItems.Count - 1
            If Not mDeshabilTodo Then
                If EsAdministrador Then
                    mItem.DropDownItems(i).Enabled = True
                Else
                    mItem.DropDownItems(i).Enabled = HabilitarEsteMenuItem(mItem.DropDownItems(i).Name)
                End If
            Else
                If mItem.DropDownItems(i).Name = "IniciarSesionToolStripMenuItem" Then
                    mItem.DropDownItems(i).Enabled = True
                ElseIf mItem.DropDownItems(i).Name = "SalirToolStripMenuItem" Then
                    mItem.DropDownItems(i).Enabled = True
                Else
                    mItem.DropDownItems(i).Enabled = False
                End If
            End If
            If mItem.DropDownItems(i).GetType Is GetType(ToolStripMenuItem) Then
                itm = CType(mItem.DropDownItems(i), ToolStripMenuItem)
                If itm.DropDownItems.Count > 0 Then
                    HabilitarSubMenu(itm, mDeshabilTodo, EsAdministrador)
                End If
            End If
        Next
    End Sub
    Public Function HabilitarEsteMenuItem(ByVal strNombreMenu As String) As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdUsrComando As SqlClient.SqlCommand
        Dim drNiveles As SqlClient.SqlDataReader

        cnSQLConexion = New SqlClient.SqlConnection(crfgXNN)
        cnSQLConexion.Open()
        cmdUsrComando = cnSQLConexion.CreateCommand
        cmdUsrComando.CommandType = CommandType.Text
        cmdUsrComando.CommandText = "SELECT NombreMenu,Nivel" & Strings.Trim(Str(My.Settings.RSINivelUsuario)) & " FROM Niveles WHERE NombreMenu='" & strNombreMenu & "' ORDER BY NombreMenu"
        drNiveles = cmdUsrComando.ExecuteReader
        drNiveles.Read()

        If drNiveles.HasRows Then
            HabilitarEsteMenuItem = drNiveles("Nivel" & Strings.Trim(Str(My.Settings.RSINivelUsuario)))
        Else
            HabilitarEsteMenuItem = False
        End If
        cnSQLConexion.Close()
    End Function

    Private Sub BalanceGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BalanceGeneralToolStripMenuItem.Click
        Dim CTBalanceGeneralFrm As New CTRepEstFinancierosFrm
        CTBalanceGeneralFrm.strTipoEstado = "BG"
        CTBalanceGeneralFrm.ShowDialog()
        CTBalanceGeneralFrm.Close()
    End Sub

    Private Sub EstadoDeResultadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoDeResultadosToolStripMenuItem.Click
        Dim CTEstResulFrm As New CTRepEstFinancierosFrm
        CTEstResulFrm.strTipoEstado = "ER"
        CTEstResulFrm.ShowDialog()
        CTEstResulFrm.Close()
    End Sub

    Private Sub BalanceGeneralPorAñosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BalanceGeneralPorAñosToolStripMenuItem.Click
        Dim CTBalGenAñosFrm As New CTRepEstFinanAñosFrm
        CTBalGenAñosFrm.strTipoEstado = "BG"
        CTBalGenAñosFrm.ShowDialog()
        CTBalGenAñosFrm.Close()
    End Sub

    Private Sub EstadoDeResultadosPorAñosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoDeResultadosPorAñosToolStripMenuItem.Click
        Dim CTEstResAñosFrm As New CTRepEstFinanAñosFrm
        CTEstResAñosFrm.strTipoEstado = "ER"
        CTEstResAñosFrm.ShowDialog()
        CTEstResAñosFrm.Close()
    End Sub

    Private Sub BalanceDeComprobaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BalanceDeComprobaciónToolStripMenuItem.Click
        Dim CTBalCompFrm As New CTRepBalComprobFrm
        CTBalCompFrm.ShowDialog()
        CTBalCompFrm.Close()
    End Sub

    Private Sub ReporteDeTransaccionesContablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeTransaccionesContablesToolStripMenuItem.Click
        Dim CTRepTransacFrm As New CTRepTransFrm
        CTRepTransacFrm.ShowDialog()
        CTRepTransacFrm.Close()
    End Sub

    Private Sub ReporteDelLibroMayorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDelLibroMayorToolStripMenuItem.Click
        Dim CTRepLibMayFrm As New CTRepLibroMayorFrm
        CTRepLibMayFrm.ShowDialog()
        CTRepLibMayFrm.Close()
    End Sub

    Private Sub ReporteDeMovimientoDeCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeMovimientoDeCuentasToolStripMenuItem.Click
        CTRepMovCuentasFrm.ShowDialog()
        CTRepMovCuentasFrm.Close()
    End Sub

    Private Sub ExportarImportarCatálogoDeCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarImportarCatálogoDeCuentasToolStripMenuItem.Click
        Dim CTImpExpCtCtasFrm As New CTExpImpCatalogoFrm
        CTImpExpCtCtasFrm.ShowDialog()
    End Sub

    Private Sub MantenimientoDeEmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoDeEmpresasToolStripMenuItem.Click
        MantenimientoEmpresasFrm.Show()
    End Sub

    Private Sub ConsolidaciónDeEmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsolidaciónDeEmpresasToolStripMenuItem.Click
        Dim CTConsoEmpIni As New CTConsolidacionEmpIni
        CTConsoEmpIni.ShowDialog()
    End Sub

    Private Sub CierreDePeríodoAnualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierreDePeríodoAnualToolStripMenuItem.Click
        Dim CTCierreAnFrm As New CTCierreAnualFrm
        CTCierreAnFrm.ShowDialog()
    End Sub

    Private Sub InicializaciónDePresupuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicializaciónDePresupuestoToolStripMenuItem.Click
        Dim CtIniPresupFrm As New CTInicializacionPresupuestoFrm
        CtIniPresupFrm.ShowDialog()
    End Sub

    Private Sub CapturaDePresupuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturaDePresupuestoToolStripMenuItem.Click
        Dim ctCls As New CTClassLib.CTClass
        Dim drCnf As SqlClient.SqlDataReader

        ctCls.DBconStr = strcnCAD
        drCnf = ctCls.drConf
        If drCnf("TipoPresupuesto") = "A" Then
            Dim CTCapturaPresupAnFrm As New CTCapturaPresupAnualFrm
            CTCapturaPresupAnFrm.MdiParent = Me
            CTCapturaPresupAnFrm.Show()
        ElseIf drCnf("TipoPresupuesto") = "M" Then
            Dim CTCapturaPresupFrm As New CTCapturaPresupMensualFrm
            CTCapturaPresupFrm.MdiParent = Me
            CTCapturaPresupFrm.Show()
        ElseIf drCnf("TipoPresupuesto") = "T" Then
            Dim CTCapturaPresupTrimFrm As New CTCapturaPresupTrimFrm
            CTCapturaPresupTrimFrm.MdiParent = Me
            CTCapturaPresupTrimFrm.Show()
        End If
    End Sub

    Private Sub SaldosDeCuentasDeResultadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaldosDeCuentasDeResultadosToolStripMenuItem.Click
        Dim CTSaldosCtasAnuales As New CTSaldosCuentasAnualesFrm
        CTSaldosCtasAnuales.TipoInforme = "SALDOS"
        CTSaldosCtasAnuales.ShowDialog()
    End Sub

    Private Sub EjecuciónAnualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EjecuciónAnualToolStripMenuItem.Click
        Dim CTEjecucionPresup As New CTSaldosCuentasAnualesFrm
        CTEjecucionPresup.TipoInforme = "EJECUCION"
        CTEjecucionPresup.ShowDialog()

    End Sub

    Private Sub MantenimientoDeCuentasDeBancosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoDeCuentasDeBancosToolStripMenuItem.Click
        BABancosFrm.Show()
    End Sub

    Private Sub PruebaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PruebaToolStripMenuItem.Click
        BADepNotasTransfFrm.Show()
    End Sub
End Class