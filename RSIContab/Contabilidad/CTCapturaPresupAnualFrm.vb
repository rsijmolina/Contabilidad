Public Class CTCapturaPresupAnualFrm
    Dim ctCls As New CTClassLib.CTClass
    Dim drCnf As SqlClient.SqlDataReader
    Private Sub CTCapturaPresupAnualFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 10
        ctCls.DBconStr = strcnCAD
        drCnf = ctCls.drConf
        Me.CTPresupuestoAnualTableAdapter.Connection.ConnectionString = strcnCAD
        Me.CTPresupuestoAnualTableAdapter.Fill(Me.CTPresupMensualDataSet.CTPresupuestoAnual, drCnf("AñoEnProceso"))
        ToolStripLabelTitulo.Text = "Presupuesto del Año: " & drCnf("AñoEnProceso")
    End Sub

    Private Sub butSalir_Click(sender As Object, e As EventArgs) Handles butSalir.Click
        Me.Close()
    End Sub
End Class