Public Class CTRepEstFinancierosFrm
    Private _strTipoEstado As String
    Public Property strTipoEstado() As String
        Get
            Return _strTipoEstado
        End Get
        Set(ByVal value As String)
            _strTipoEstado = value
        End Set
    End Property
    Dim CTEstFinCls As New CTClassLib.CTClass.CTEstadosFinancieros
    Dim RSICadenas As New Rsierpgencl.Rsierpcl.Cadenas
    Dim drCnf As SqlClient.SqlDataReader
    Dim EstFinancierosDataSet As New CTEstFinanDataSet
    Dim bUsarPeriodoUsuario As Boolean
    Dim intAñoUsuario As Int16
    Dim intMesUsuario As Int16

    Private Sub CTRepEstFinancierosFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CTEstFinCls.DBconStr = strcnCAD
        drCnf = CTEstFinCls.drConf
        c1dateFecha.Value = Date.Now

        Try
            lblPeriodo.Text = "Período Actual Año: " & drCnf("AñoEnProceso") & " Mes: " & RSICadenas.MesLetras(drCnf("MesEnProceso"))
            If strTipoEstado = "BG" Then
                Me.Text = "Reporte del Balance General"
                lblNivelCta1.Text = "Activo:"
                lblNivelCta2.Text = "Pasivo:"
                lblNivelCta3.Text = "Capital:"
                numupdnNivelCta1.Value = drCnf("NivelActivoRepBalGen")
                numupdnNivelCta2.Value = drCnf("NivelPasivoRepBalGen")
                numupdnNivelCta3.Value = drCnf("NivelCapitalRepBalGen")
            Else
                Me.Text = "Reporte del Estado de Resultados"
                lblNivelCta1.Text = "Ingresos:"
                lblNivelCta2.Text = "Costos:"
                lblNivelCta3.Text = "Gastos:"
                numupdnNivelCta1.Value = drCnf("NivelIngresosRepEstResul")
                numupdnNivelCta2.Value = drCnf("NivelCostosRepEstResul")
                numupdnNivelCta3.Value = drCnf("NivelGastosRepEstResul")
            End If
            For i As Int16 = 1 To 12
                cmbMeses.Items.Add(RSICadenas.MesLetras(i))
            Next
            cmbMeses.SelectedIndex = drCnf("MesEnProceso") - 1
            c1numAñoUsuario.Value = drCnf("AñoEnProceso")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim ctRptCls As New RSIRPTCLS.RptCls.CTRpt
        Dim intPeriodoAño As Int16, intPeriodoMes As Int16
        Dim strEstadoFinanciero As String = ""

        Try
            CTEstFinCls.strTipoEstado = strTipoEstado
            CTEstFinCls.boEstFinanAños = False
            If radiobutSaldosAnuales.Checked Then
                CTEstFinCls.strAnualMensual = "A"
            Else
                CTEstFinCls.strAnualMensual = "M"
            End If
            If chkboxCompAñoAnt.Checked Then
                CTEstFinCls.intAñoComp = c1numCompararAnio.Value
            Else
                CTEstFinCls.intAñoComp = 0
            End If
            If chkboxUtilizarPeriodoUsuario.Checked Then
                intPeriodoAño = c1numAñoUsuario.Value
                intPeriodoMes = cmbMeses.SelectedIndex + 1
            Else
                intPeriodoAño = drCnf("AñoEnProceso")
                intPeriodoMes = drCnf("MesEnProceso")
            End If

            CTEstFinCls.AñoEstFinan = intPeriodoAño
            CTEstFinCls.MesEstFinan = intPeriodoMes
            CTEstFinCls.boSuprimirCeros = chkboxSuprimirSaldosCeros.Checked
            CTEstFinCls.CTEstFDataSet = EstFinancierosDataSet
            CTEstFinCls.intNivelMax1 = numupdnNivelCta1.Value
            CTEstFinCls.intNivelMax2 = numupdnNivelCta2.Value
            CTEstFinCls.intNivelMax3 = numupdnNivelCta3.Value
            CTEstFinCls.drCTCnf = drCnf
            CTEstFinCls.GenerarEstadosFinancieros()
            If EstFinancierosDataSet.Tables("CTEstFinanDataTable").Rows.Count = 0 Then
                MsgBox("No hay datos a listar en este período...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                Exit Sub
            End If

            '*** Datos para el reporte
            ctRptCls.TipoEstadoFinan = strTipoEstado
            ctRptCls.EstFinanEmpresa = My.Settings.RSIEmpresaActual
            If chkboxCompAñoAnt.Checked Then
                ctRptCls.EstFinanComparativo = True
                ctRptCls.EstFinanTituloAño1 = Str(c1numCompararAnio.Value)
                ctRptCls.EstFinanTituloAño2 = Str(drCnf("AñoEnProceso"))
            Else
                ctRptCls.EstFinanComparativo = False
                ctRptCls.EstFinanTituloAño1 = ""
                ctRptCls.EstFinanTituloAño2 = ""
            End If
            ctRptCls.EstFinanFecha = c1dateFecha.Text
            ctRptCls.EstFinanEjecutivo1 = IIf(IsDBNull(drCnf("Ejecutivo1")), "", drCnf("Ejecutivo1"))
            ctRptCls.EstFinanEjecutivo2 = IIf(IsDBNull(drCnf("Ejecutivo2")), "", drCnf("Ejecutivo2"))
            ctRptCls.EstFinanEjecutivo3 = IIf(IsDBNull(drCnf("Ejecutivo3")), "", drCnf("Ejecutivo3"))
            ctRptCls.EstFinanCargo1 = IIf(IsDBNull(drCnf("Cargo1")), "", drCnf("Cargo1"))
            ctRptCls.EstFinanCargo2 = IIf(IsDBNull(drCnf("Cargo2")), "", drCnf("Cargo2"))
            ctRptCls.EstFinanCargo3 = IIf(IsDBNull(drCnf("Cargo3")), "", drCnf("Cargo3"))
            If strTipoEstado = "BG" Then
                strEstadoFinanciero = "Balance General "
            Else
                strEstadoFinanciero = "Estado de Resultados "
            End If
            If chkboxFechasIniFin.Checked Then
                If radiobutSaldosAnuales.Checked Then
                    ctRptCls.EstFinanTitulo1 = strEstadoFinanciero & " al " & RSICadenas.RellenarIzq(RSICadenas.UltimoDiaMes(intPeriodoMes, intPeriodoAño), 2, "0") & " de " & RSICadenas.MesLetras(intPeriodoMes) & " de " & Trim(Str(intPeriodoAño))
                Else
                    ctRptCls.EstFinanTitulo1 = strEstadoFinanciero & " del " & RSICadenas.RellenarIzq(Str(intPeriodoMes), 2, "0") & "/" & Trim(Str(intPeriodoAño)) & " al " & RSICadenas.RellenarIzq(RSICadenas.UltimoDiaMes(intPeriodoMes, intPeriodoAño), 2, "0") & "/" & RSICadenas.RellenarIzq(Str(intPeriodoMes), 2, "0") & "/" & Trim(Str(intPeriodoAño))
                End If
            Else
                If radiobutSaldosAnuales.Checked Then
                    ctRptCls.EstFinanTitulo1 = strEstadoFinanciero & " a " & RSICadenas.MesLetras(intPeriodoMes) & " de " & Trim(Str(intPeriodoAño))
                Else
                    ctRptCls.EstFinanTitulo1 = strEstadoFinanciero & " de " & RSICadenas.RellenarIzq(Str(intPeriodoMes), 2, "0") & " de " & Trim(Str(intPeriodoAño))
                End If
            End If
            If chkboxMostrarTituloMoneda.Checked Then
                ctRptCls.EstFinanTitulo2 = IIf(IsDBNull(drCnf("TituloMoneda")), "", drCnf("TituloMoneda"))
                ctRptCls.EstFinanTitulo3 = IIf(IsDBNull(drCnf("TituloCambioMoneda")), "", drCnf("TituloCambioMoneda")) & " " & c1numFactorCambio.Text
            Else
                ctRptCls.EstFinanTitulo2 = ""
                ctRptCls.EstFinanTitulo3 = ""
            End If
            ctRptCls.CTEstadosFinanDataSet = EstFinancierosDataSet
            ctRptCls.EjecutarRepEstadosFinancieros()
            'CTTmpFrm.DataGridView1.DataSource = EstFinancierosDataSet.Tables("CTEstFinanDataTable")
            'CTTmpFrm.ShowDialog()
            'CTTmpFrm.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class