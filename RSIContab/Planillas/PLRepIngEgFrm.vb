Public Class PLRepIngEgFrm
    Private _TipoReporte As String
    Dim PlCls As New PLClassLib.PlClass
    Dim drConfPlani As SqlClient.SqlDataReader
    Dim drDefDed As SqlClient.SqlDataReader
    Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
    Dim RSICls As New Rsierpgencl.Rsierpcl.Cadenas
    Public Property TipoReporte() As String
        Get
            TipoReporte = _TipoReporte
        End Get
        Set(ByVal value As String)
            _TipoReporte = value
        End Set
    End Property

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub c1numNoPlanilla_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numNoPlanilla.Validating
        lblDescPlanilla.Text = PlCls.DescripcionPlanilla(c1numNoPlanilla.Value)
    End Sub

    Private Sub PLRepIngEgFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case _TipoReporte
            Case "INGRESOS"
                Me.Text = "Planilla de Ingresos"
            Case "EGRESOS"
                Me.Text = "Planilla de Egresos"
            Case "SEGUROSOCIAL"
                Me.Text = "Planilla del Seguro Social"
            Case "RAP"
                Me.Text = "Planilla del RAP"
            Case "INJUPEMP"
                Me.Text = "Planilla del Injupemp"
            Case "INPREMA"
                Me.Text = "Planilla del Inprema"
            Case "ISR"
                Me.Text = "Planilla del ISR"
            Case "IMPVECINAL"
                Me.Text = "Planilla del Impuesto Vecinal"
        End Select
        c1dateFecha.Value = Date.Now
        PlCls.DBconStr = strcnCAD
        drConfPlani = PlCls.drConf
        c1numNoPlanilla.Value = drConfPlani("NoPlanilla")
        lblDescPlanilla.Text = PlCls.DescripcionPlanilla(drConfPlani("NoPlanilla"))
        rptClass.BaseDatosRpt = BaseDatosActual
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Select Case _TipoReporte
            Case "INGRESOS"
                ReporteIngresos()
            Case "EGRESOS"
                ReporteEgresos()
            Case "SEGUROSOCIAL"
                ReporteSeguroSocial()
            Case "RAP"
                ReporteRAP()
            Case "INJUPEMP"
            Case "INPREMA"
            Case "ISR"
                ReporteISR()
            Case "IMPVECINAL"
                ReporteVecinal()
        End Select
    End Sub
    Private Sub ReporteIngresos()
        Dim strSel As String

        strSel = "{PLPLanillas.Año}=" & drConfPlani("AñoEnProceso") & " AND {PLPLanillas.Mes}=" & drConfPlani("MesEnProceso") & " AND {PLPLanillas.NoPlanilla}=" & c1numNoPlanilla.Value
        rptClass.EjecutarReportesVarios(strcnCAD, My.Settings.RSIEmpresaActual, "PLRepIngresosRpt", strSel, lblDescPlanilla.Text, c1dateFecha.Value)
    End Sub
    Private Sub ReporteEgresos()
        Dim strSel As String, strTit1 As String, strTit2 As String, strTit3 As String, strTit4 As String, strTit5 As String, strTit6 As String, strTit7 As String
        Dim strTit8 As String, strTit9 As String, strTit10 As String, strTit11 As String, strRep As String
        Dim PLProcDedsFrm As New PLProcDeduccionesFrm

        PLProcDedsFrm.Año = drConfPlani("AñoEnProceso")
        PLProcDedsFrm.Mes = drConfPlani("MesEnProceso")
        PLProcDedsFrm.NoPlanilla = drConfPlani("NoPlanilla")
        PLProcDedsFrm.Procesar("PLANILLA")

        drDefDed = PlCls.drDefDeducciones("")
        strSel = "{PLPLanillas.Año}=" & drConfPlani("AñoEnProceso") & " AND {PLPLanillas.Mes}=" & drConfPlani("MesEnProceso") & " AND {PLPLanillas.NoPlanilla}=" & c1numNoPlanilla.Value

        strTit1 = "" : strTit2 = "" : strTit3 = "" : strTit4 = "" : strTit5 = "" : strTit6 = "" : strTit7 = "" : strTit8 = "" : strTit9 = "" : strTit10 = "" : strTit11 = ""
        While drDefDed.Read
            Select Case drDefDed("RepNoColumna")
                Case 1
                    strTit1 = drDefDed("RepTituloColumna")
                Case 2
                    strTit2 = drDefDed("RepTituloColumna")
                Case 3
                    strTit3 = drDefDed("RepTituloColumna")
                Case 4
                    strTit4 = drDefDed("RepTituloColumna")
                Case 5
                    strTit5 = drDefDed("RepTituloColumna")
                Case 6
                    strTit6 = drDefDed("RepTituloColumna")
                Case 7
                    strTit7 = drDefDed("RepTituloColumna")
                Case 8
                    strTit8 = drDefDed("RepTituloColumna")
                Case 9
                    strTit9 = drDefDed("RepTituloColumna")
                Case 10
                    strTit10 = drDefDed("RepTituloColumna")
                Case 11
                    strTit11 = drDefDed("RepTituloColumna")
            End Select
        End While

        If drConfPlani("NoPlanilla") = 1 Then
            strRep = "PLDeducciones1Rpt"
        Else
            strRep = "PLDeducciones2Rpt"
        End If
        rptClass.EjecutarReportePlanillaEgresos(strcnCAD, My.Settings.RSIEmpresaActual, strRep, strSel, lblDescPlanilla.Text, c1dateFecha.Value, _
                                                strTit1, strTit2, strTit3, strTit4, strTit5, strTit6, strTit7, strTit8, strTit9, strTit10, strTit11, "", "", "", "", 11)
    End Sub
    Private Sub ReporteSeguroSocial()
        Dim strSel As String

        strSel = "{PLPLanillas.Año}=" & drConfPlani("AñoEnProceso") & " AND {PLPLanillas.Mes}=" & drConfPlani("MesEnProceso") & " AND {PLPLanillas.NoPlanilla}=" & c1numNoPlanilla.Value
        rptClass.EjecutarReportesVarios(strcnCAD, My.Settings.RSIEmpresaActual, "PLSeguroSocialRpt", strSel, lblDescPlanilla.Text, c1dateFecha.Value)
    End Sub
    Private Sub ReporteRAP()
        Dim strSel As String

        strSel = "{PLPLanillas.Año}=" & drConfPlani("AñoEnProceso") & " AND {PLPLanillas.Mes}=" & drConfPlani("MesEnProceso") & " AND {PLPLanillas.NoPlanilla}=" & c1numNoPlanilla.Value
        rptClass.EjecutarReportesVarios(strcnCAD, My.Settings.RSIEmpresaActual, "PLRAPRpt", strSel, lblDescPlanilla.Text, c1dateFecha.Value)
    End Sub
    Private Sub ReporteISR()
        Dim strSel As String

        strSel = "{PLPLanillas.Año}=" & drConfPlani("AñoEnProceso") & " AND {PLPLanillas.Mes}=" & drConfPlani("MesEnProceso") & " AND {PLPLanillas.NoPlanilla}=" & c1numNoPlanilla.Value
        rptClass.EjecutarReportesVarios(strcnCAD, My.Settings.RSIEmpresaActual, "PLISRRpt", strSel, lblDescPlanilla.Text, c1dateFecha.Value)
    End Sub
    Private Sub ReporteVecinal()
        Dim strSel As String

        strSel = "{PLPLanillas.Año}=" & drConfPlani("AñoEnProceso") & " AND {PLPLanillas.Mes}=" & drConfPlani("MesEnProceso") & " AND {PLPLanillas.NoPlanilla}=" & c1numNoPlanilla.Value
        rptClass.EjecutarReportesVarios(strcnCAD, My.Settings.RSIEmpresaActual, "PLImpVecinalRpt", strSel, lblDescPlanilla.Text, c1dateFecha.Value)
    End Sub
End Class