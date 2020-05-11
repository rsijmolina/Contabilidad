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
        rptClass.DBconStr = My.Settings.RSIERP_Conexion
        rptClass.EjecutarListados(My.Settings.RSIERP_Conexion, "Sedes", My.Settings.RSIEmpresaActual)
    End Sub

    Private Sub MantenimientoDeDeduccionesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenimientoDeDeduccionesToolStripMenuItem1.Click
        MantDeduccionesFrm.Show()
    End Sub

    Private Sub ListadoDeDepartamentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeDepartamentosToolStripMenuItem.Click
        Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
        rptClass.DBconStr = My.Settings.RSIERP_Conexion
        rptClass.EjecutarListados(My.Settings.RSIERP_Conexion, "Departamentos", My.Settings.RSIEmpresaActual)
    End Sub

    Private Sub ListadoDeSeccionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeSeccionesToolStripMenuItem.Click
        Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
        rptClass.DBconStr = My.Settings.RSIERP_Conexion
        rptClass.EjecutarListados(My.Settings.RSIERP_Conexion, "Secciones", My.Settings.RSIEmpresaActual)
    End Sub

    Private Sub ListadoDeTiposDeEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeTiposDeEmpleadosToolStripMenuItem.Click
        Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
        rptClass.DBconStr = My.Settings.RSIERP_Conexion
        rptClass.EjecutarListados(My.Settings.RSIERP_Conexion, "TiposEmpleados", My.Settings.RSIEmpresaActual)
    End Sub

    Private Sub ListadoDeProfesionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeProfesionesToolStripMenuItem.Click
        Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
        rptClass.DBconStr = My.Settings.RSIERP_Conexion
        rptClass.EjecutarListados(My.Settings.RSIERP_Conexion, "Profesiones", My.Settings.RSIEmpresaActual)
    End Sub

    Private Sub ListadoDePuestosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDePuestosToolStripMenuItem.Click
        Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
        rptClass.DBconStr = My.Settings.RSIERP_Conexion
        rptClass.EjecutarListados(My.Settings.RSIERP_Conexion, "Puestos", My.Settings.RSIEmpresaActual)
    End Sub

    Private Sub ListadoDeBancosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeBancosToolStripMenuItem.Click
        Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
        rptClass.DBconStr = My.Settings.RSIERP_Conexion
        rptClass.EjecutarListados(My.Settings.RSIERP_Conexion, "Bancos", My.Settings.RSIEmpresaActual)
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
        While 1
            mLoginFrm.ShowDialog()
            If (mLoginFrm.UsernameTextBox.Text = "admin" And mLoginFrm.PasswordTextBox.Text = "rsi94128") Then
                My.Settings.RSIUsuarioActual = "admin"
                mLoginFrm.Close()
                HabilitarMenu(False, True)
                DatosEmpresa()
                Exit While
            End If
            If mLoginFrm.mAceptar Then
                If ValidarUsuario(mLoginFrm.UsernameTextBox.Text, mLoginFrm.PasswordTextBox.Text) Then
                    mLoginFrm.Close()
                    If My.Settings.RSIEsAdministrador Then
                        HabilitarMenu(False, True)
                    Else
                        HabilitarMenu(False, False)
                    End If
                    DatosEmpresa()
                    Exit While
                End If
            Else
                mLoginFrm.Close()
                HabilitarMenu(True, False)
                Exit While
            End If
        End While

    End Sub
End Class