Public Class CTRepBalComprobFrm
    Dim CTEstFinCls As New CTClassLib.CTClass.CTEstadosFinancieros
    Dim RSICadenas As New Rsierpgencl.Rsierpcl.Cadenas
    Dim drCnf As SqlClient.SqlDataReader
    Dim bUsarPeriodoUsuario As Boolean
    Dim intAñoUsuario As Int16
    Dim intMesUsuario As Int16
    Private Sub CTRepBalComprobFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CTEstFinCls.DBconStr = strcnCAD
        drCnf = CTEstFinCls.drConf
        c1dateFecha.Value = Date.Now

        Try
            lblPeriodo.Text = "Período Actual Año: " & drCnf("AñoEnProceso") & " Mes: " & RSICadenas.MesLetras(drCnf("MesEnProceso"))
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
        Dim RSISegClGen As New Rsierpgencl.Rsierpcl.EncripDesencrip
        Dim intPeriodoAño As Int16, intPeriodoMes As Int16
        Dim strSQL As String = ""

        Try
            If chkboxUtilizarPeriodoUsuario.Checked Then
                intPeriodoAño = c1numAñoUsuario.Value
                intPeriodoMes = cmbMeses.SelectedIndex + 1
            Else
                intPeriodoAño = drCnf("AñoEnProceso")
                intPeriodoMes = drCnf("MesEnProceso")
            End If

            CTEstFinCls.AñoEstFinan = intPeriodoAño
            CTEstFinCls.MesEstFinan = intPeriodoMes

            '*** Datos para el reporte
            If Not chkboxListarTodoCatalogo.Checked Then   '*Listar todo el catalogo
                If chkboxSuprimirSaldosCeros.Checked Then  '* Suprimir los CTSaldosMensuales en cero
                    If chkboxImprimirPresupuesto.Checked Then  '* Si se elije imprimir el presupesto
                        strSQL = "({CTCatalogoCuentas.Posteable}) AND ({CTPresupuesto.PresupuestoAnual}+{CTSaldosMensuales.SaldoAnterior}+{CTSaldosMensuales.DebitosMes}+{CTSaldosMensuales.CreditosMes}<>0) AND ({CTSaldosMensuales.Año}=" & intPeriodoAño & ") AND ({CTSaldosMensuales.Mes}=" & intPeriodoMes & ")"
                    Else
                        strSQL = "( ({CTCatalogoCuentas.Posteable}) AND ({CTSaldosMensuales.SaldoAnterior}<>0 OR {CTSaldosMensuales.DebitosMes}>0 OR {CTSaldosMensuales.CreditosMes}>0)) AND ({CTSaldosMensuales.Año}=" & intPeriodoAño & ") AND ({CTSaldosMensuales.Mes}=" & intPeriodoMes & ")"
                    End If
                Else
                    strSQL = "({CTCatalogoCuentas.Posteable}) AND ({CTSaldosMensuales.Año}=" & intPeriodoAño & ") AND ({CTSaldosMensuales.Mes}=" & intPeriodoMes & ")"
                End If
            Else
                If chkboxSuprimirSaldosCeros.Checked Then  '* Suprimir los CTSaldosMensuales en cero
                    If chkboxImprimirPresupuesto.Checked Then  '* Si se elije imprimir el presupesto
                        strSQL = "({CTPresupuesto.PresupuestoAnual}+{CTSaldosMensuales.SaldoAnterior}+{CTSaldosMensuales.DebitosMes}+{CTSaldosMensuales.CreditosMes}<>0) AND ({CTSaldosMensuales.Año}=" & intPeriodoAño & ") AND ({CTSaldosMensuales.Mes}=" & intPeriodoMes & ")"
                    Else
                        strSQL = "({CTSaldosMensuales.SaldoAnterior}<>0 OR {CTSaldosMensuales.DebitosMes}>0 OR {CTSaldosMensuales.CreditosMes}>0) AND ({CTSaldosMensuales.Año}=" & intPeriodoAño & ") AND ({CTSaldosMensuales.Mes}=" & intPeriodoMes & ")"
                    End If
                End If
            End If

            ctRptCls.Filtro = strSQL
            ctRptCls.ServidorRpt = RSISegClGen.DecryptData(My.Settings.xhspz) & "\" & RSISegClGen.DecryptData(My.Settings.itfwa)
            ctRptCls.BaseDatosRpt = BaseDatosActual
            ctRptCls.strPar1 = RSISegClGen.DecryptData(My.Settings.xupiy)
            ctRptCls.strPar2 = RSISegClGen.DecryptData(My.Settings.acvse)
            ctRptCls.TituloEmpresa = My.Settings.RSIEmpresaActual
            ctRptCls.FechaReporte = c1dateFecha.Text
            If chkboxFechasIniFin.Checked Then
                ctRptCls.EstFinanTitulo1 = "Del 01 de Enero al " & RSICadenas.RellenarIzq(RSICadenas.UltimoDiaMes(intPeriodoMes, intPeriodoAño), 2, "0") & " de " & RSICadenas.MesLetras(intPeriodoMes) & " de " & Trim(Str(intPeriodoAño))
            Else
                ctRptCls.EstFinanTitulo1 = "A " & RSICadenas.MesLetras(intPeriodoMes) & " de " & Trim(Str(intPeriodoAño))
            End If
            If chkboxMostrarTituloMoneda.Checked Then
                ctRptCls.EstFinanTitulo2 = IIf(IsDBNull(drCnf("TituloMoneda")), "", drCnf("TituloMoneda"))
                ctRptCls.EstFinanTitulo3 = IIf(IsDBNull(drCnf("TituloCambioMoneda")), "", drCnf("TituloCambioMoneda")) & " " & c1numFactorCambio.Text
            Else
                ctRptCls.EstFinanTitulo2 = ""
                ctRptCls.EstFinanTitulo3 = ""
            End If
            If chkboxImprimirPresupuesto.Checked Then
                ctRptCls.EjecutarBalanceComprobacion("BALCOMPROBPRES")
            Else
                ctRptCls.EjecutarBalanceComprobacion("BALCOMPROB")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try

    End Sub
End Class