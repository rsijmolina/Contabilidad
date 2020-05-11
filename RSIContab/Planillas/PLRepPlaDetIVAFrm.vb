Public Class PLRepPlaDetIVAFrm
    Dim PlCls As New PLClassLib.PlClass
    Dim drConfPlani As SqlClient.SqlDataReader
    Dim drDefDed As SqlClient.SqlDataReader
    Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
    Dim RSICls As New Rsierpgencl.Rsierpcl.Cadenas

    Private Sub PLRepPlaDetIVAFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        c1dateFecha.Value = Date.Now
        PlCls.DBconStr = strcnCAD
        drConfPlani = PlCls.drConf
        c1numNoPlanilla.Value = drConfPlani("NoPlanilla")
        lblDescPlanilla.Text = PlCls.DescripcionPlanilla(drConfPlani("NoPlanilla"))
        rptClass.BaseDatosRpt = BaseDatosActual
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub c1numNoPlanilla_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numNoPlanilla.Validating
        lblDescPlanilla.Text = PlCls.DescripcionPlanilla(c1numNoPlanilla.Value)
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim strSel As String, strTit1 As String, strTit2 As String, strTit3 As String, strTit4 As String, strTit5 As String, strTit6 As String, strTit7 As String, strRep As String
        Dim PLProcDedFrm As New PLProcDeduccionesFrm

        PLProcDedFrm.Año = drConfPlani("AñoEnProceso")
        PLProcDedFrm.Mes = drConfPlani("MesEnProceso")
        PLProcDedFrm.NoPlanilla = drConfPlani("NoPlanilla")
        PLProcDedFrm.Procesar("PLANILLA")

        drDefDed = PlCls.drDefDeducciones("")
        strSel = "{PLPLanillas.Año}=" & drConfPlani("AñoEnProceso") & " AND {PLPLanillas.Mes}=" & drConfPlani("MesEnProceso") & " AND {PLPLanillas.NoPlanilla}=" & c1numNoPlanilla.Value

        strTit1 = "" : strTit2 = "" : strTit3 = "" : strTit4 = "" : strTit5 = "" : strTit6 = "" : strTit7 = ""

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
            End Select
        End While

        If chkboxImprimirResumen.Checked Then
            strRep = "PLResumenRpt"
        Else
            strRep = "PLPlanilla1Rpt"
        End If
        rptClass.EjecutarReportePlanilla(strcnCAD, My.Settings.RSIEmpresaActual, strRep, strSel, lblDescPlanilla.Text, c1dateFecha.Value, _
                                                strTit1, strTit2, strTit3, strTit4, strTit5, strTit6, strTit7)
    End Sub
End Class