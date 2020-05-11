Public Class OpcionesCalculoDedFrm
    Private _EmpleadoActual As String
    Private _CodigosDeducciones As New Collection
    Private _PlanillaEspecial As Boolean
    Dim PlCl As New PLClassLib.PlClass
    Dim drConf As SqlClient.SqlDataReader
    Dim drCalcDed As SqlClient.SqlDataReader
    Dim drDatosPlani As SqlClient.SqlDataReader
    Dim drDatosSedePl As SqlClient.SqlDataReader
    Dim cnSQLConexion As Data.SqlClient.SqlConnection
    'Dim cnSQLCon As Data.SqlClient.SqlConnection
    Dim cmdInComando As SqlClient.SqlCommand
    Dim decSeguroSocial As Decimal, decRAP As Decimal, decISR As Decimal, decImpVecinal As Decimal, decINJUPEMP As Decimal, decINPREMA As Decimal, decValorCalc As Decimal

    Public Property EmpleadoActual() As String
        Get
            EmpleadoActual = _EmpleadoActual
        End Get
        Set(ByVal value As String)
            _EmpleadoActual = value
        End Set
    End Property
    Public Property CodigosDeducciones() As Collection
        Get
            CodigosDeducciones = _CodigosDeducciones
        End Get
        Set(ByVal value As Collection)
            _CodigosDeducciones = value
        End Set
    End Property
    Public Property PlanillaEspecial() As Boolean
        Get
            PlanillaEspecial = _PlanillaEspecial
        End Get
        Set(ByVal value As Boolean)
            _PlanillaEspecial = value
        End Set
    End Property
    Private Sub OpcionesCalculoDedFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PlCl.DBconStr = strcnCAD
        drConf = PlCl.drConf

        Me.PLPlanillasTableAdapter.Fill(Me.PLPlaniActDatosDataSet.PLPlanillas, drConf("AñoEnProceso"), drConf("MesEnProceso"), drConf("NoPlanilla"))
    End Sub

    Private Sub chkboxMarcarTodasOtrasDed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkboxMarcarTodasOtrasDed.CheckedChanged
        Dim i As Int16

        If chkboxMarcarTodasOtrasDed.Checked Then
            For i = 0 To chklstboxOtrasDed.Items.Count - 1
                chklstboxOtrasDed.SetItemCheckState(i, CheckState.Checked)
            Next
        Else
            For i = 0 To chklstboxOtrasDed.Items.Count - 1
                chklstboxOtrasDed.SetItemCheckState(i, CheckState.Unchecked)
            Next
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim cnSQLCon As Data.SqlClient.SqlConnection
        Dim DatosActuales As DataRowView
        Dim strSQL As String
        Dim OtrasDedMarcadas As Boolean

        If chklstboxOtrasDed.CheckedItems.Count > 0 Then
            OtrasDedMarcadas = True
        Else
            OtrasDedMarcadas = False
        End If
        cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
        cnSQLConexion.Open()

        strSQL = "SELECT PLPlanillas.Año,PLPlanillas.Mes,PLPlanillas.NoPlanilla,PLPlanillas.CodigoSede,PLPlanillas.CodigoDepartamento,PLPlanillas.CodigoSeccion,PLPlanillas.CodigoEmpleado, PLPlanillas.DiasTrabajados, PLPlanillas.SueldoNormal, PLPlanillas.DiasFeriados, PLPlanillas.SueldoAdicionalFeriados, " _
            & "PLPlanillas.HorasTarde, PLPlanillas.ValorHorastarde, PLPlanillas.HorasExtras25,PLPlanillas.ValorHorasExtras25, PLPlanillas.HorasExtras50, PLPlanillas.ValorHorasExtras50, PLPlanillas.HorasExtras75, PLPlanillas.ValorHorasExtras75, PLPlanillas.HorasExtrasDobles, PLPlanillas.ValorHorasExtrasDobles, " _
            & "PLPlanillas.Comisiones, PLPlanillas.Bonificaciones, PLPlanillas.Transporte, PLPlanillas.Combustible, PLPlanillas.DepreciacionVehiculo, PLPlanillas.Vacaciones, PLPlanillas.IngresosAdicionales1, PLPlanillas.IngresosAdicionales2, " _
            & "PLPlanillas.IngresosAdicionales3, PLPlanillas.IngresosAdicionales4, PLPlanillas.IngresosAdicionales5,PLEmpleados.SalarioMensual,PLEmpleados.EsDocente,PLEmpleados.EsMedico,PLEmpleados.IngresoPorComision,PLEmpleados.NoDeducirRAP,PLEmpleados.NoDeducirSeguroSocial ,PLSedes.DeducirSS, PLSedes.PorcentajeSS, PLSedes.DeduccionMaxSS," _
            & "PLSedes.PorcentajeDocenteSS, PLSedes.DeduccionMaxDocenteSS FROM PLPlanillas " _
            & "INNER JOIN PLEmpleados ON PLPlanillas.CodigoEmpleado = PLEmpleados.CodigoEmpleado INNER JOIN PLSedes ON PLPlanillas.CodigoSede = PLSedes.CodigoSede "

        If radiobutCalcEmpleadoActual.Checked Then
            strSQL = strSQL & "WHERE PLPlanillas.Año=" & drConf("AñoEnProceso") & " AND PLPlanillas.Mes=" & drConf("MesEnProceso") & " AND PLPlanillas.NoPlanilla=" & drConf("NoPlanilla") & " AND PLPlanillas.CodigoEmpleado='" & _EmpleadoActual & "' ORDER BY PLPlanillas.CodigoEmpleado"
        Else
            strSQL = strSQL & "WHERE PLPlanillas.Año=" & drConf("AñoEnProceso") & " AND PLPlanillas.Mes=" & drConf("MesEnProceso") & " AND PLPlanillas.NoPlanilla=" & drConf("NoPlanilla") & " AND PLEmpleados.RetiradoDeEmpresa=0 ORDER BY PLPlanillas.CodigoEmpleado"
        End If
        cnSQLCon = New SqlClient.SqlConnection(strcnCAD)
        cnSQLCon.Open()
        cmdInComando = cnSQLCon.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = strSQL
        drDatosPlani = cmdInComando.ExecuteReader
        lblMensaje.Visible = True
        While drDatosPlani.Read
            lblMensaje.Text = "Procesando " & drDatosPlani("CodigoEmpleado")
            lblMensaje.Refresh()
            decSeguroSocial = 0
            decRAP = 0
            decISR = 0
            decImpVecinal = 0
            decINJUPEMP = 0
            decINPREMA = 0
            PlanillaBindingSource.Filter = "CodigoEmpleado='" & drDatosPlani("CodigoEmpleado") & "'"
            DatosActuales = PlanillaBindingSource.Current

            If drDatosPlani("NoDeducirSeguroSocial") = False Then
                If chkboxCalcularTodasDeducciones.Checked Or chkboxSeguroSocial.Checked Then
                    If drConf("CalcularSeguroSocial") <> "No Calcular" Then
                        If drConf("CalcularSeguroSocial") = "Cada Planilla" Or (drConf("CalcularSeguroSocial") = "Planilla Específica" _
                            And drConf("NoPlanilla") = drConf("NoPlanillaSeguro")) Then
                            If My.Settings.RSIEmpresaInstalada <> "ENLACE" Then
                                CalcularSeguroSocial() 'Cambio hecho a ENLACE 03/01/2012
                                DatosActuales("SeguroSocial") = decSeguroSocial
                            Else
                                DatosActuales("SeguroSocial") = PlCl.ObtenerValorDeduccion("IHSS", drDatosPlani("CodigoEmpleado"), drDatosPlani("NoPlanilla"))
                            End If
                        End If
                    End If
                End If
            Else
                DatosActuales("SeguroSocial") = 0
            End If
            If drDatosPlani("NoDeducirRAP") = False Then
                If chkboxCalcularTodasDeducciones.Checked Or chkboxRAP.Checked Then
                    If drConf("CalcularRAP") <> "No Calcular" Then
                        If drConf("CalcularRAP") = "Cada Planilla" Or (drConf("CalcularRAP") = "Planilla Específica" _
                            And drConf("NoPlanilla") = drConf("NoPlanillaRAP")) Then
                            CalcularRAP()
                            DatosActuales("RAP") = decRAP
                        End If
                    End If
                End If
            Else
                DatosActuales("RAP") = 0
            End If

            If chkboxCalcularTodasDeducciones.Checked Or chkboxImpRenta.Checked Then
                If drConf("CalcularISR") <> "No Calcular" Then
                    If drConf("CalcularISR") = "Cada Planilla" Or (drConf("CalcularISR") = "Planilla Específica" _
                        And drConf("NoPlanilla") = drConf("NoPlanillaISR")) Then
                        If My.Settings.RSIEmpresaInstalada <> "ENLACE" Then
                            CalCularISR()
                            DatosActuales("ImpuestoSobreRenta") = decISR
                        Else
                            'CalCularISR()  ZOE entra aqui
                            'DatosActuales("ImpuestoSobreRenta") = decISR
                            DatosActuales("ImpuestoSobreRenta") = PlCl.ObtenerValorDeduccion("ISR", drDatosPlani("CodigoEmpleado"), drDatosPlani("NoPlanilla"))
                        End If
                    End If
                End If
            End If

            If chkboxCalcularTodasDeducciones.Checked Or chkboxImpVecinal.Checked Then
                If drConf("CalcularImpuestoVecinal") <> "No Calcular" Then
                    If drConf("CalcularImpuestoVecinal") = "Cada Planilla" Or (drConf("CalcularImpuestoVecinal") = "Planilla Específica" _
                        And drConf("NoPlanilla") = drConf("NoPlanillaVecinal")) Then
                        decImpVecinal = PlCl.ObtenerImpVecinal(drDatosPlani("Año"), drDatosPlani("CodigoEmpleado"))
                    End If
                End If
            End If

            If chkboxCalcularTodasDeducciones.Checked Or chkboxINJUPEMP.Checked Then
                If drConf("CalcularINJUPEMP") <> "No Calcular" Then
                    If drConf("CalcularINJUPEMP") = "Cada Planilla" Or (drConf("CalcularINJUPEMP") = "Planilla Específica" _
                        And drConf("NoPlanilla") = drConf("NoPlanillaINJUPEMP")) Then
                        CalcularINJUPEMP()
                        DatosActuales("INJUPEMP") = decINJUPEMP
                    End If
                End If
            End If

            If chkboxCalcularTodasDeducciones.Checked Or chkboxINPREMA.Checked Then
                If drConf("CalcularINPREMA") <> "No Calcular" Then
                    If drConf("CalcularINPREMA") = "Cada Planilla" Or (drConf("CalcularINPREMA") = "Planilla Específica" _
                        And drConf("NoPlanilla") = drConf("NoPlanillaINPREMA")) Then
                        CalcularINPREMA()
                    End If
                End If
            End If
            If chkboxCalcularTodasDeducciones.Checked Or OtrasDedMarcadas Or chkboxBorrarDetalleOtrasDed.Checked Then
                CalcularOtrasDeducciones()
            End If
            PlanillaBindingSource.EndEdit()
            Me.PLPlanillasTableAdapter.Update(Me.PLPlaniActDatosDataSet.PLPlanillas)
        End While
        cnSQLCon.Close()
        cnSQLConexion.Close()
        MsgBox("Proceso Terminado...")
        Me.Close()
    End Sub
    Private Sub CalcularSeguroSocial()
        Dim decPorcSeguro As Decimal, decDedMaxSeguro As Decimal, decSeguroSocialAnual As Decimal, decValorAcum As Decimal
        Dim i As Int16

        Try
            decValorCalc = ObtenerValorCalc("SeguroSocial")
            If decValorCalc = 0 Then
                decValorCalc = drDatosPlani("SalarioMensual")
            End If
            If drDatosPlani("DeducirSS") Then  'Deducción del seguro por la Sede
                If drDatosPlani("EsDocente") Then
                    decPorcSeguro = drDatosPlani("PorcentajeDocenteSS")
                    decDedMaxSeguro = drDatosPlani("DeduccionMaxDocenteSS")
                Else
                    decPorcSeguro = drDatosPlani("PorcentajeSS")
                    decDedMaxSeguro = drDatosPlani("DeduccionMaxSS")
                End If
            Else    'Deducción General del Seguro
                If drDatosPlani("EsDocente") Then
                    decPorcSeguro = drDatosPlani("PorcentajeDocenteSS")
                    decDedMaxSeguro = drDatosPlani("DeduccionMaxDocenteSS")
                Else
                    decPorcSeguro = drDatosPlani("PorcentajeSS")
                    decDedMaxSeguro = drDatosPlani("DeduccionMaxSS")
                End If
            End If

            If My.Settings.RSIEmpresaInstalada = "IVA" Then
                If drDatosPlani("NoPlanilla") = 2 Then
                    If drDatosPlani("IngresoPorComision") Then
                        decValorCalc = decValorCalc + drDatosPlani("Comisiones") + PlCl.ObtenerComisionAnterior(drDatosPlani("CodigoEmpleado"), drDatosPlani("Año"), drDatosPlani("Mes"), drDatosPlani("NoPlanilla"))
                    End If
                    decSeguroSocial = Math.Round(decValorCalc * (decPorcSeguro / 100), 2)
                    If decSeguroSocial > decDedMaxSeguro Then
                        decSeguroSocial = decDedMaxSeguro
                    End If
                End If
            Else
                decSeguroSocial = Math.Round(decValorCalc * (decPorcSeguro / 100), 2)
                If decSeguroSocial > decDedMaxSeguro Then
                    decSeguroSocial = decDedMaxSeguro
                End If
                If drConf("PlanillasPorMes") > 1 And drConf("CalcularSeguroSocial") = "Cada Planilla" Then
                    decSeguroSocial = Math.Round(decSeguroSocial / drConf("PlanillasPorMes"), 2)
                End If

                decSeguroSocialAnual = decSeguroSocial * 12

                If drDatosPlani("NoPlanilla") > 1 And drConf("CalcularSeguroSocial") = "Cada Planilla" Then
                    decValorAcum = 0
                    For i = drConf("NoPlanilla") - 1 To 1 Step -1
                        decValorAcum = decValorAcum + PlCl.ObtenerDeduccionesAnteriores("SeguroSocial", drDatosPlani("CodigoEmpleado"), drDatosPlani("Año"), drDatosPlani("Mes"), i)
                    Next
                    If decSeguroSocial + decValorAcum > decDedMaxSeguro Then
                        decSeguroSocial = decDedMaxSeguro - decValorAcum
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CalcularRAP()
        Dim decValorAcum As Decimal
        Dim i As Int16

        Try
            decValorCalc = ObtenerValorCalc("RAP")
            If decValorCalc = 0 Then
                decValorCalc = drDatosPlani("SalarioMensual")
            End If

            If My.Settings.RSIEmpresaInstalada = "IVA" Then
                If drConf("NoPlanilla") = 2 Then
                    'decValorCalc = decValorCalc * 2
                    If drDatosPlani("IngresoPorComision") Then
                        decValorCalc = decValorCalc + drDatosPlani("Comisiones") + PlCl.ObtenerComisionAnterior(drDatosPlani("CodigoEmpleado"), drDatosPlani("Año"), drDatosPlani("Mes"), drDatosPlani("NoPlanilla"))
                    End If
                    decRAP = Math.Round(decValorCalc * (drConf("PorcentajeRAP") / 100), 2)
                    If drConf("DeduccionMaxRAP") > 0 Then
                        If decRAP > drConf("DeduccionMaxRAP") Then
                            decRAP = drConf("DeduccionMaxRAP")
                        End If
                    End If
                End If
            Else
                decRAP = Math.Round(decValorCalc * (drConf("PorcentajeRAP") / 100), 2)
                If drConf("DeduccionMaxRAP") > 0 Then
                    If decRAP > drConf("DeduccionMaxRAP") Then
                        decRAP = drConf("DeduccionMaxRAP")
                    End If
                End If
                If drConf("PlanillasPorMes") > 1 And drConf("CalcularRAP") = "Cada Planilla" Then
                    decRAP = Math.Round(decRAP / drConf("PlanillasPorMes"), 2)
                End If

                If drConf("NoPlanilla") > 1 And drConf("CalcularRAP") = "Cada Planilla" Then
                    decValorAcum = 0
                    For i = drConf("NoPlanilla") - 1 To 1 Step -1
                        decValorAcum = decValorAcum + PlCl.ObtenerDeduccionesAnteriores("RAP", drDatosPlani("CodigoEmpleado"), drDatosPlani("Año"), drDatosPlani("Mes"), i)
                    Next
                    If drConf("DeduccionMaxRAP") > 0 Then
                        If decRAP + decValorAcum > drConf("DeduccionMaxRAP") Then
                            decRAP = drConf("DeduccionMaxRAP") - decValorAcum
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CalCularISR()
        Dim decISRTotMensualDed As Decimal, decISRTotDed As Decimal
        Dim i As Int16
        Dim drDedISR As SqlClient.SqlDataReader

        Try
            drDedISR = PlCl.drDeduccionISR(drDatosPlani("Año"), drDatosPlani("CodigoEmpleado"))
            If drDedISR.HasRows Then
                If Not drDedISR("NoDeducir") Then
                    decISRTotMensualDed = 0
                    decISRTotDed = drDedISR("Porcentaje1") + drDedISR("Porcentaje2") + drDedISR("Porcentaje3") + drDedISR("Porcentaje4") + drDedISR("Porcentaje5")
                    For i = 1 To 12
                        decISRTotMensualDed = decISRTotMensualDed + drDedISR("DeduccionPlanilla1_" & Trim(Str(i))) + drDedISR("DeduccionPlanilla2_" & Trim(Str(i)))
                    Next
                    If drConf("MesEnProceso") < 12 Then
                        If drConf("PlanillasPorMes") = 1 Then
                            decISR = Math.Round((decISRTotDed - decISRTotMensualDed) / (13 - drConf("MesEnProceso")) / drConf("PlanillasPorMes"), 2)
                        ElseIf drConf("PlanillasPorMes") = 2 Then
                            If drConf("NoPlanilla") = 1 Then
                                decISR = Math.Round((decISRTotDed - decISRTotMensualDed) / (26 - (drConf("MesEnProceso") * 2)), 2)
                            Else
                                '***decISR = Math.Round((decISRTotDed - decISRTotMensualDed) / 12, 2)
                                decISR = Math.Round((decISRTotDed - decISRTotMensualDed) / (26 - (drConf("MesEnProceso") * 2) - 1), 2)
                            End If
                        End If
                    Else
                        If drConf("PlanillasPorMes") = 1 Then
                            decISR = Math.Round((decISRTotDed - decISRTotMensualDed) / drConf("PlanillasPorMes"), 2)
                        ElseIf drConf("PlanillasPorMes") = 2 Then
                            If drConf("NoPlanilla") = 1 Then
                                decISR = Math.Round((decISRTotDed - decISRTotMensualDed) / 2, 2)
                            Else
                                decISR = Math.Round(decISRTotDed - decISRTotMensualDed, 2)
                            End If
                        End If
                    End If
                End If
            Else
                decISR = 0
                drDedISR.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            drDedISR.Close()
        End Try
    End Sub
    Private Sub CalcularINJUPEMP()
        Dim decINJUPEMPAnual As Decimal, decValorAcum As Decimal
        Dim i As Int16

        Try
            decValorCalc = drDatosPlani("SueldoNormal") + drDatosPlani("Comisiones")
            decINJUPEMP = Math.Round(decValorCalc * (drConf("PorcentajeINJUPEMP") / 100), 2)
            decINJUPEMPAnual = Math.Round((drDatosPlani("SalarioMensual") * 12) * (drConf("PorcentajeInjupemp") / 100), 2)

            If drConf("NoPlanilla") > 1 And drConf("CalcularINJUPEMP") = "Cada Planilla" Then
                decValorAcum = 0
                For i = drConf("NoPlanilla") - 1 To 1 Step -1
                    decValorAcum = decValorAcum + PlCl.ObtenerDeduccionesAnteriores("INJUPEMP", drDatosPlani("CodigoEmpleado"), drDatosPlani("Año"), drDatosPlani("Mes"), i)
                Next
            End If
            If drConf("NoPlanilla") = 1 And drConf("CalcularINJUPEMP") = "Cada Planilla" Then
                decINJUPEMP = Math.Round(decINJUPEMP / drConf("PlanillasPorMes"), 2)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CalcularINPREMA()

    End Sub

    Private Sub CalcularOtrasDeducciones()
        Dim cmdDed As SqlClient.SqlCommand
        Dim drDed As SqlClient.SqlDataReader
        Dim cnSQLCon As SqlClient.SqlConnection
        Dim strSQL As String
        Dim mAplicarDedPlEsp As Boolean

        Try
            If chkboxBorrarDetalleOtrasDed.Checked Then
                If radiobutCalcEmpleadoActual.Checked = True Then
                    PlCl.BorrarOtrasDeducciones(drDatosPlani("CodigoEmpleado"), drDatosPlani("Año"), drDatosPlani("Mes"), drDatosPlani("NoPlanilla"), False)
                Else
                    PlCl.BorrarOtrasDeducciones("", drDatosPlani("Año"), drDatosPlani("Mes"), drDatosPlani("NoPlanilla"), True)
                End If
            End If

            cnSQLCon = New SqlClient.SqlConnection(strcnCAD)
            cnSQLCon.Open()
            strSQL = "SELECT PLDeducciones.NoDocumento, PLDeducciones.Fecha, PLDeducciones.CodigoDeduccion, PLDeducciones.CodigoEmpleado, " _
                & "PLDeducciones.PlanillaNo, PLDeducciones.Valor, PLDeducciones.NoMesesDeducir, PLDeducciones.DeduccionMensual, " _
                & "PLDeducciones.DeduccionPermanente, PLDeducciones.MontoDeducido, PLDeducciones.NoPlanillasDeducidas, " _
                & "PLDeducciones.UltimaDeduccion, PLDeducciones.Referencia, PLDeducciones.OtrosCreditos, PLDeducciones.DeduccionPlanilla1, " _
                & "PLDeducciones.DeduccionPlanilla2, PLDeducciones.DeduccionPlanilla3, PLDeducciones.DeduccionPlanilla4, PLDeducciones.Año, " _
                & "PLDeducciones.Mes, PLDefinicionDeducciones.AplicarEnPlanillaVacaciones, PLDefinicionDeducciones.AplicarEnPlanilla13VO, " _
                & "PLDefinicionDeducciones.AplicarEnPlanilla14VO FROM PLDeducciones INNER JOIN PLDefinicionDeducciones ON PLDeducciones.CodigoDeduccion = PLDefinicionDeducciones.CodigoDeduccion " _
                & "WHERE (PLDeducciones.CodigoEmpleado='" & drDatosPlani("CodigoEmpleado") & "') AND (PLDeducciones.Anulada=0) AND (PLDeducciones.Valor > PLDeducciones.MontoDeducido OR PLDeducciones.DeduccionPermanente=1) " _
                & "ORDER BY PLDeducciones.CodigoDeduccion"
            cmdDed = cnSQLCon.CreateCommand
            cmdDed.CommandType = CommandType.Text
            cmdDed.CommandText = strSQL
            drDed = cmdDed.ExecuteReader
            While drDed.Read
                mAplicarDedPlEsp = False
                If _PlanillaEspecial Then
                    If drDatosPlani("NoPlanilla") = drConf("NoPlanillaVacaciones") And drDed("AplicarEnPlanillaVacaciones") Then
                        mAplicarDedPlEsp = True
                    End If
                    If drDatosPlani("NoPlanilla") = drConf("NoPlanilla13vo") And drDed("AplicarEnPlanilla13VO") Then
                        mAplicarDedPlEsp = True
                    End If
                    If drDatosPlani("NoPlanilla") = drConf("NoPlanilla14vo") And drDed("AplicarEnPlanilla14VO") Then
                        mAplicarDedPlEsp = True
                    End If
                End If
                If chkboxCalcularTodasDeducciones.Checked Or CalcularEstaDeduccion(drDed("CodigoDeduccion")) Then
                    If My.Settings.RSIEmpresaInstalada = "ZOE" Then
                        If drDed("CodigoDeduccion") <> "IHSS" Then 'Para Zoe
                            If Not _PlanillaEspecial Or (_PlanillaEspecial And mAplicarDedPlEsp) Then
                                If drDed("DeduccionPlanilla" & drDatosPlani("NoPlanilla")) > 0 Then
                                    If drDed("DeduccionPermanente") Then
                                        decValorCalc = drDed("DeduccionPlanilla" & drDatosPlani("NoPlanilla"))
                                    Else
                                        If My.Settings.RSIEmpresaInstalada = "IVA" Then
                                            decValorCalc = drDed("DeduccionPlanilla" & drDatosPlani("NoPlanilla"))
                                        Else
                                            If drDed("DeduccionPlanilla" & drDatosPlani("NoPlanilla")) + drDed("MontoDeducido") + drDed("OtrosCreditos") <= drDed("Valor") Then
                                                decValorCalc = drDed("DeduccionPlanilla" & drDatosPlani("NoPlanilla"))
                                            Else
                                                decValorCalc = drDed("Valor") - drDed("MontoDeducido") - drDed("OtrosCreditos")
                                            End If
                                        End If
                                    End If
                                    GuardarDetalleOtrasDed(drDed("CodigoDeduccion"), drDed("Fecha"), IIf(drDed("DeduccionPermanente"), 2, 1), drDed("NoDocumento"), decValorCalc, drDed("Referencia"))
                                End If
                            End If
                        End If
                    Else
                        If (drDed("CodigoDeduccion") <> "ISR" And drDed("CodigoDeduccion") <> "IHSS") Then
                            If Not _PlanillaEspecial Or (_PlanillaEspecial And mAplicarDedPlEsp) Then
                                If drDed("DeduccionPlanilla" & drDatosPlani("NoPlanilla")) > 0 Then
                                    If drDed("DeduccionPermanente") Then
                                        decValorCalc = drDed("DeduccionPlanilla" & drDatosPlani("NoPlanilla"))
                                    Else
                                        If My.Settings.RSIEmpresaInstalada = "IVA" Then
                                            decValorCalc = drDed("DeduccionPlanilla" & drDatosPlani("NoPlanilla"))
                                        Else
                                            If drDed("DeduccionPlanilla" & drDatosPlani("NoPlanilla")) + drDed("MontoDeducido") + drDed("OtrosCreditos") <= drDed("Valor") Then
                                                decValorCalc = drDed("DeduccionPlanilla" & drDatosPlani("NoPlanilla"))
                                            Else
                                                decValorCalc = drDed("Valor") - drDed("MontoDeducido") - drDed("OtrosCreditos")
                                            End If
                                        End If
                                    End If
                                    GuardarDetalleOtrasDed(drDed("CodigoDeduccion"), drDed("Fecha"), IIf(drDed("DeduccionPermanente"), 2, 1), drDed("NoDocumento"), decValorCalc, drDed("Referencia"))
                                End If
                            End If
                        End If
                    End If
                End If
            End While
            cnSQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnSQLCon.Close()
        End Try
    End Sub
    Private Function CalcularEstaDeduccion(ByVal strCodigoDeduccion As String) As Boolean
        Dim i As Int16

        CalcularEstaDeduccion = False
        For i = 0 To _CodigosDeducciones.Count - 1
            If _CodigosDeducciones.Item(i + 1).ToString = strCodigoDeduccion And chklstboxOtrasDed.GetItemCheckState(i) = CheckState.Checked Then
                CalcularEstaDeduccion = True
                Exit For
            End If
        Next
    End Function
    Private Sub GuardarDetalleOtrasDed(ByVal strCodDed As String, ByVal mFecha As DateTime, ByVal intTipoDed As Int16, ByVal intNoDoc As Int32, ByVal decValor As Decimal, ByVal strRef As Object)
        Dim cmdGrabarDet As SqlClient.SqlCommand
        Dim strSQL As String

        Try
            strSQL = "INSERT INTO PLPlanillasOT (Año,Mes,NoPlanilla,CodigoSede,CodigoDepartamento,CodigoSeccion,CodigoEmpleado, " _
                & "CodigoDeduccion,Fecha,TipoDeduccion,NoDocumento,Valor,Referencia) VALUES (@Año,@Mes,@NoPlanilla,@CodigoSede,@CodigoDepartamento," _
                & "@CodigoSeccion,@CodigoEmpleado,@CodigoDeduccion,@Fecha,@TipoDeduccion,@NoDocumento,@Valor,@Referencia)"
            cmdGrabarDet = cnSQLConexion.CreateCommand
            cmdGrabarDet.CommandType = CommandType.Text
            cmdGrabarDet.CommandText = strSQL

            AgregarParametro(cmdGrabarDet, "@Año", ParameterDirection.Input, SqlDbType.SmallInt, drDatosPlani("Año"))
            AgregarParametro(cmdGrabarDet, "@Mes", ParameterDirection.Input, SqlDbType.SmallInt, drDatosPlani("Mes"))
            AgregarParametro(cmdGrabarDet, "@NoPlanilla", ParameterDirection.Input, SqlDbType.SmallInt, drDatosPlani("NoPlanilla"))
            AgregarParametro(cmdGrabarDet, "@CodigoSede", ParameterDirection.Input, SqlDbType.NVarChar, drDatosPlani("CodigoSede"))
            AgregarParametro(cmdGrabarDet, "@CodigoDepartamento", ParameterDirection.Input, SqlDbType.NVarChar, drDatosPlani("CodigoDepartamento"))
            AgregarParametro(cmdGrabarDet, "@CodigoSeccion", ParameterDirection.Input, SqlDbType.NVarChar, drDatosPlani("CodigoSeccion"))
            AgregarParametro(cmdGrabarDet, "@CodigoEmpleado", ParameterDirection.Input, SqlDbType.NVarChar, drDatosPlani("CodigoEmpleado"))
            AgregarParametro(cmdGrabarDet, "@CodigoDeduccion", ParameterDirection.Input, SqlDbType.NVarChar, strCodDed)
            AgregarParametro(cmdGrabarDet, "@Fecha", ParameterDirection.Input, SqlDbType.DateTime, mFecha)
            AgregarParametro(cmdGrabarDet, "@TipoDeduccion", ParameterDirection.Input, SqlDbType.TinyInt, intTipoDed)
            AgregarParametro(cmdGrabarDet, "@NoDocumento", ParameterDirection.Input, SqlDbType.BigInt, intNoDoc)
            AgregarParametro(cmdGrabarDet, "@Valor", ParameterDirection.Input, SqlDbType.Decimal, decValor)
            AgregarParametro(cmdGrabarDet, "@Referencia", ParameterDirection.Input, SqlDbType.NVarChar, strRef)
            cmdGrabarDet.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function ObtenerValorCalc(ByVal strDed As String) As Decimal
        drCalcDed = PlCl.drCalcDeducciones(strDed)
        ObtenerValorCalc = 0
        If drCalcDed("Incluir") Then
            If drCalcDed("NormalDevengado") Then
                ObtenerValorCalc = drDatosPlani("SueldoNormal") + drDatosPlani("SueldoAdicionalFeriados") - drDatosPlani("ValorHorasTarde")
            ElseIf drCalcDed("TiempoExtra") Then
                ObtenerValorCalc = ObtenerValorCalc + drDatosPlani("ValorHorasExtras25") + drDatosPlani("ValorHorasExtras50") + drDatosPlani("ValorHorasExtras75") + drDatosPlani("ValorHorasExtrasDobles")
            ElseIf drCalcDed("Comisiones") Then
                ObtenerValorCalc = ObtenerValorCalc + drDatosPlani("Comisiones")
            ElseIf drCalcDed("Bonificaciones") Then
                ObtenerValorCalc = ObtenerValorCalc + drDatosPlani("Bonificaciones")
            ElseIf drCalcDed("Transporte") Then
                ObtenerValorCalc = ObtenerValorCalc + drDatosPlani("Transporte")
            ElseIf drCalcDed("Combustible") Then
                ObtenerValorCalc = ObtenerValorCalc + drDatosPlani("Combustible")
            ElseIf drCalcDed("Depreciacion") Then
                ObtenerValorCalc = ObtenerValorCalc + drDatosPlani("Depreciacion")
            ElseIf drCalcDed("Vacaciones") Then
                ObtenerValorCalc = ObtenerValorCalc + drDatosPlani("Vacaciones")
            ElseIf drCalcDed("Ingreso1") Then
                ObtenerValorCalc = ObtenerValorCalc + drDatosPlani("IngresosAdicionales1")
            ElseIf drCalcDed("Ingreso2") Then
                ObtenerValorCalc = ObtenerValorCalc + drDatosPlani("IngresosAdicionales2")
            ElseIf drCalcDed("Ingreso3") Then
                ObtenerValorCalc = ObtenerValorCalc + drDatosPlani("IngresosAdicionales3")
            ElseIf drCalcDed("Ingreso4") Then
                ObtenerValorCalc = ObtenerValorCalc + drDatosPlani("IngresosAdicionales4")
            ElseIf drCalcDed("Ingreso5") Then
                ObtenerValorCalc = ObtenerValorCalc + drDatosPlani("IngresosAdicionales5")
            End If
        End If
        drCalcDed.Close()
    End Function
    Private Sub AgregarParametro(ByVal cmdComando As SqlClient.SqlCommand, ByVal strNombre As String, ByVal ParDir As ParameterDirection, ByVal ParTipo As SqlDbType, ByVal Valor As Object)
        Dim Par As SqlClient.SqlParameter

        Par = New SqlClient.SqlParameter
        Par.ParameterName = strNombre
        Par.Direction = ParDir
        Par.SqlDbType = ParTipo
        If ParDir <> ParameterDirection.Output Then
            Par.Value = Valor
        End If
        cmdComando.Parameters.Add(Par)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        drConf.Close()
        Me.Close()
    End Sub

    Private Sub chkboxCalcularTodasDeducciones_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkboxCalcularTodasDeducciones.CheckedChanged
        Dim i As Int16

        If chkboxCalcularTodasDeducciones.Checked Then
            chkboxMarcarTodasOtrasDed.Checked = True
            For i = 0 To chklstboxOtrasDed.Items.Count - 1
                chklstboxOtrasDed.SetItemCheckState(i, CheckState.Checked)
            Next
            chkboxSeguroSocial.Checked = True
            chkboxRAP.Checked = True
            chkboxImpRenta.Checked = True
            chkboxImpVecinal.Checked = True
            chkboxINJUPEMP.Checked = True
            chkboxINPREMA.Checked = True
            If chkboxDeduccion1.Visible Then
                chkboxDeduccion1.Checked = True
            End If
            If chkboxDeduccion2.Visible Then
                chkboxDeduccion2.Checked = True
            End If
            If chkboxDeduccion3.Visible = True Then
                chkboxDeduccion3.Checked = True
            End If
            If chkboxDeduccion4.Visible = True Then
                chkboxDeduccion4.Checked = True
            End If
            If chkboxDeduccion5.Visible = True Then
                chkboxDeduccion5.Checked = True
            End If
        Else
            chkboxMarcarTodasOtrasDed.Checked = False
            For i = 0 To chklstboxOtrasDed.Items.Count - 1
                chklstboxOtrasDed.SetItemCheckState(i, CheckState.Unchecked)
            Next
            chkboxSeguroSocial.Checked = False
            chkboxRAP.Checked = False
            chkboxImpRenta.Checked = False
            chkboxImpVecinal.Checked = False
            chkboxINJUPEMP.Checked = False
            chkboxINPREMA.Checked = False
            If chkboxDeduccion1.Visible Then
                chkboxDeduccion1.Checked = False
            End If
            If chkboxDeduccion2.Visible Then
                chkboxDeduccion2.Checked = False
            End If
            If chkboxDeduccion3.Visible = True Then
                chkboxDeduccion3.Checked = False
            End If
            If chkboxDeduccion4.Visible = True Then
                chkboxDeduccion4.Checked = False
            End If
            If chkboxDeduccion5.Visible = True Then
                chkboxDeduccion5.Checked = False
            End If
        End If
    End Sub

End Class
