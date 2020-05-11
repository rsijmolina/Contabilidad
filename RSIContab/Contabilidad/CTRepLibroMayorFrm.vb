Public Class CTRepLibroMayorFrm
    Dim CTEstFinCls As New CTClassLib.CTClass.CTEstadosFinancieros
    Dim RSICadenas As New Rsierpgencl.Rsierpcl.Cadenas
    Dim drCnf As SqlClient.SqlDataReader
    Dim LibroMayorDataSet As New CTLibMayDataSet
    Dim bUsarPeriodoUsuario As Boolean
    Dim intAñoUsuario As Int16
    Dim intMesUsuario As Int16
    Private Sub CTRepLibroMayorFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim intPeriodoAño As Int16, intPeriodoMes As Int16
        Dim strEstadoFinanciero As String = ""

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
            CTEstFinCls.CTLibroMayorDataSet = LibroMayorDataSet
            CTEstFinCls.LibroMayor()
            If LibroMayorDataSet.Tables("CTLibroMayorDataTable").Rows.Count = 0 Then
                MsgBox("No hay datos a listar en este período...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                Exit Sub
            End If

            '*** Datos para el reporte
            ctRptCls.EstFinanEmpresa = My.Settings.RSIEmpresaActual
            ctRptCls.EstFinanFecha = c1dateFecha.Text
            ctRptCls.EstFinanTitulo1 = "Reporte del Libro Mayor de " & RSICadenas.MesLetras(intPeriodoMes) & " de " & intPeriodoAño
            ctRptCls.CTLibroMayorDataSet = LibroMayorDataSet
            ctRptCls.EjecutarLibroMayor()

            'CTTmpFrm.DataGridView1.DataSource = LibroMayorDataSet.Tables("CTLibroMayorDataTable")
            'CTTmpFrm.ShowDialog()
            'CTTmpFrm.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try

    End Sub
End Class