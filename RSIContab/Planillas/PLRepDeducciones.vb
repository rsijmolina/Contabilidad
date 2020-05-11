Public Class PLRepDeducciones
    Private _TipoReporte As String
    Dim lstDedFrm As New ListasFrm
    Dim PlCls As New PLClassLib.PlClass
    Dim drDefDed As SqlClient.SqlDataReader
    Dim drConfPlani As SqlClient.SqlDataReader
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

    Private Sub PLRepDeducciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _TipoReporte = "GENERAL" Then
            grpDatosListar.Visible = False
            grpNoPlanilla.Top = 38
            grpNoPlanilla.Visible = True
            grpRangos.Top = 110
        End If
        c1dateFecha.Value = Date.Now
        PlCls.DBconStr = strcnCAD
        drConfPlani = PlCls.drConf
        rptClass.BaseDatosRpt = BaseDatosActual
        lstDedFrm.NombreLista = "Deducciones"
        lstDedFrm.CampoOrdenar = "CodigoDeduccion"
        btnBuscarRangoIni.Enabled = True
        btnBuscarRangoFinal.Enabled = True
    End Sub

    Private Sub c1txtRangoIni_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1txtRangoIni.Validating
        If Not String.IsNullOrEmpty(c1txtRangoIni.Text) Then
            drDefDed = PlCls.drDefDeducciones(c1txtRangoIni.Text)
            If Not drDefDed.HasRows Then
                lblNombreRangoIni.Text = ""
                MsgBox("Codigo de Deduccion no Existe...", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
            Else
                lblNombreRangoIni.Text = drDefDed("DescripcionDeduccion")
            End If
        End If
    End Sub

    Private Sub c1txtRangoFinal_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1txtRangoFinal.Validating
        If Not String.IsNullOrEmpty(c1txtRangoFinal.Text) Then
            drDefDed = PlCls.drDefDeducciones(c1txtRangoFinal.Text)
            If Not drDefDed.HasRows Then
                lblNombreRangoFinal.Text = ""
                MsgBox("Codigo de Deduccion no Existe...", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
            Else
                lblNombreRangoFinal.Text = drDefDed("DescripcionDeduccion")
            End If
        End If
    End Sub

    Private Sub btnBuscarRangoIni_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscarRangoIni.Click
        lstDedFrm.ControlDestino = c1txtRangoIni
        lstDedFrm.ControlDescripcion = lblNombreRangoIni
        lstDedFrm.ShowDialog()
    End Sub

    Private Sub btnBuscarRangoFinal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscarRangoFinal.Click
        lstDedFrm.ControlDestino = c1txtRangoFinal
        lstDedFrm.ControlDescripcion = lblNombreRangoFinal
        lstDedFrm.ShowDialog()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim strSQL As String, strTit1 As String, strTit2 As String

        strSQL = ""
        strTit1 = ""

        strTit2 = "de " & RSICls.MesLetras(drConfPlani("MesEnProceso")) & " de " & drConfPlani("AñoEnProceso")
        If _TipoReporte = "GENERAL" Then
            strTit1 = "Reporte de Deducciones"
            If Not chkListarTodo.Checked Then
                strSQL = "{PLPlanillasOT.CodigoDeduccion}>='" & c1txtRangoIni.Text & "' AND {PLPlanillasOT.CodigoDeduccion}<='" & c1txtRangoFinal.Text & "' AND {PLPlanillasOT.Año}=" & drConfPlani("AñoEnProceso") & " AND {PLPlanillasOT.Mes}=" & drConfPlani("MesEnProceso") & " AND {PLPlanillasOT.NoPlanilla}=" & c1numNoPlanilla.Value
            End If
            rptClass.EjecutarReporteDeducciones(strcnCAD, My.Settings.RSIEmpresaActual, "DeduccionDelMes", strSQL, strTit1, strTit2, c1dateFecha.Value)
        Else
            If Not chkListarTodo.Checked Then
                strSQL = "{PLDeducciones.CodigoDeduccion}>='" & c1txtRangoIni.Text & "' AND {PLDeducciones.CodigoDeduccion}<='" & c1txtRangoFinal.Text & "'"
            End If
            If radiobutCargosMes.Checked Then 'Reporte de deducciones programadas del Mes
                strSQL = strSQL & " AND {PLDeducciones.Año}=" & drConfPlani("AñoEnProceso") & " AND {PLDeducciones.Mes}=" & drConfPlani("MesEnProceso")
                strTit1 = "Reporte de Cargos del Mes" '& RSICls.MesLetras(drConfPlani("MesEnProceso")) & " de " & drConfPlani("AñoEnProceso")
            ElseIf radiobutCargosPendientes.Checked Then
                strSQL = strSQL & " AND ({PLDeducciones.MontoDeducido}>{PLDeducciones.Valor} OR {PLDeducciones.DeduccionPermanente})"
                strTit1 = "Reporte de Cargos Pendientes al Mes de " & RSICls.MesLetras(drConfPlani("MesEnProceso")) & " de " & drConfPlani("AñoEnProceso")
                strTit2 = ""
            ElseIf radiobutAmbos.Checked Then
                strTit1 = "Reporte de Cargos"
                strTit2 = ""
            End If
            rptClass.EjecutarReporteDeducciones(strcnCAD, My.Settings.RSIEmpresaActual, "DeduccionMensual", strSQL, strTit1, strTit2, c1dateFecha.Value)
        End If
    End Sub
    Private Sub c1numNoPlanilla_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numNoPlanilla.Validating
        lblDescPlanilla.Text = PlCls.DescripcionPlanilla(c1numNoPlanilla.Value)
    End Sub
End Class