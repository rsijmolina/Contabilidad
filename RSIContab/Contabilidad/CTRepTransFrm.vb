Public Class CTRepTransFrm
    Dim CTCls As New CTClassLib.CTClass
    Dim RSICadenas As New Rsierpgencl.Rsierpcl.Cadenas
    Dim drCnf As SqlClient.SqlDataReader
    Dim drTiposPart As SqlClient.SqlDataReader
    Dim bUsarPeriodoUsuario As Boolean
    Dim intAñoUsuario As Int16
    Dim intMesUsuario As Int16

    Private Sub CTRepTransFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CTCls.DBconStr = strcnCAD
        drCnf = CTCls.drConf
        drTiposPart = CTCls.drTiposPartidas
        c1dateFecha.Value = Date.Now

        Try
            lblPeriodo.Text = "Período Actual Año: " & drCnf("AñoEnProceso") & " Mes: " & RSICadenas.MesLetras(drCnf("MesEnProceso"))
            For i As Int16 = 1 To 12
                cmbMeses.Items.Add(RSICadenas.MesLetras(i))
            Next
            cmbMeses.SelectedIndex = drCnf("MesEnProceso") - 1
            c1numAñoUsuario.Value = drCnf("AñoEnProceso")
            Do While drTiposPart.Read
                cmbTipoPartida.Items.Add(drTiposPart("TipoPartida"))
            Loop
            drTiposPart.Close()
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
            If radiobutEstaFecha.Checked Then
                Dim dFecha As Date = c1dateFecha.Value
                strSQL = "{CTTransaccionesEncabezado.Fecha}=DATE(" & dFecha.Year & "," & dFecha.Month & "," & dFecha.Day & ")"
            ElseIf radiobutTodasPartidas.Checked Then
                strSQL = "{CTTransaccionesEncabezado.Año}=" & intPeriodoAño & " AND {CTTransaccionesEncabezado.Mes}=" & intPeriodoMes
            ElseIf radiobutRangoPartidas.Checked Then
                strSQL = "{CTTransaccionesEncabezado.Año}=" & intPeriodoAño & " AND {CTTransaccionesEncabezado.Mes}=" & intPeriodoMes & " AND {CTTransaccionesEncabezado.NoTransaccion}>='" _
                    & txtPartidaInicial.Text & "' AND {CTTransaccionesEncabezado.NoTransaccion}<='" & txtPartidaFinal.Text & "'"
            ElseIf radiobutTipoPartidas.Checked Then
                strSQL = "{CTTransaccionesEncabezado.Año}=" & intPeriodoAño & " AND {CTTransaccionesEncabezado.Mes}=" & intPeriodoMes & " AND {CTTransaccionesEncabezado.TipoPartida}='" & cmbTipoPartida.Text & "'"
            End If

            ctRptCls.Filtro = strSQL
            ctRptCls.ServidorRpt = RSISegClGen.DecryptData(My.Settings.xhspz) & "\" & RSISegClGen.DecryptData(My.Settings.itfwa)
            ctRptCls.BaseDatosRpt = BaseDatosActual
            ctRptCls.strPar1 = RSISegClGen.DecryptData(My.Settings.xupiy)
            ctRptCls.strPar2 = RSISegClGen.DecryptData(My.Settings.acvse)
            ctRptCls.TituloEmpresa = My.Settings.RSIEmpresaActual
            ctRptCls.FechaReporte = c1dateFecha.Text
            ctRptCls.EjecutarListados("TRANSACCIONES")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub CTRepTransFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        drCnf.Close()
    End Sub

End Class