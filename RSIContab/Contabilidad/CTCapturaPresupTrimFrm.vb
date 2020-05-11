Public Class CTCapturaPresupTrimFrm
    Dim ctCls As New CTClassLib.CTClass
    Dim drCnf As SqlClient.SqlDataReader
    Private Sub CTCapturaPresupTrimFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 10
        ctCls.DBconStr = strcnCAD
        drCnf = ctCls.drConf
        Me.CTPresupuestoTrimTableAdapter.Connection.ConnectionString = strcnCAD
        Me.CTPresupuestoTrimTableAdapter.Fill(Me.CTPresupMensualDataSet.CTPresupuestoTrim, drCnf("AñoEnProceso"))
        ToolStripLabelTitulo.Text = "Presupuesto del Año: " & drCnf("AñoEnProceso")
    End Sub

    Private Sub butSalir_Click(sender As Object, e As EventArgs) Handles butSalir.Click
        Me.Close()
    End Sub

    Private Sub c1dbgrdDetalle_AfterUpdate(sender As Object, e As EventArgs) Handles c1dbgrdDetalle.AfterUpdate
        c1dbgrdDetalle.Columns("Total").Value = c1dbgrdDetalle.Columns("Trimestre 1").Value + c1dbgrdDetalle.Columns("Trimestre 2").Value + c1dbgrdDetalle.Columns("Trimestre 3").Value + c1dbgrdDetalle.Columns("Trimestre 4").Value
        Me.PrincipalBindingSource.EndEdit()
        Me.CTPresupuestoTrimTableAdapter.Update(Me.CTPresupMensualDataSet.CTPresupuestoTrim)
    End Sub
End Class