Public Class CTCapturaPresupMensualFrm
    Dim ctCls As New CTClassLib.CTClass
    'Dim rsiCadCls As New Rsierpgencl.Rsierpcl.Cadenas
    Dim drCnf As SqlClient.SqlDataReader
    Private Sub CTCapturaPresupMensualFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 10
        ctCls.DBconStr = strcnCAD
        drCnf = ctCls.drConf
        Me.CTPresupuestoTableAdapter.Connection.ConnectionString = strcnCAD
        Me.CTPresupuestoTableAdapter.Fill(Me.CTPresupMensualDataSet.CTPresupuesto, drCnf("AñoEnProceso"))
        ToolStripLabelTitulo.Text = "Presupuesto del Año: " & drCnf("AñoEnProceso") & "  -  Saldos del Año: " & drCnf("AñoEnProceso") - 1
    End Sub

    
    Private Sub butSalir_Click(sender As Object, e As EventArgs) Handles butSalir.Click
        Me.Close()
    End Sub

    Private Sub c1dbgrdPresupuesto_AfterUpdate(sender As Object, e As EventArgs) Handles c1dbgrdPresupuesto.AfterUpdate
        Dim decTotal As Decimal = 0

        Try
            With c1dbgrdPresupuesto
                .Columns("Total").Value = .Columns("Pres. Enero").Value + .Columns("Pres. Febrero").Value + .Columns("Pres. Marzo").Value + .Columns("Pres. Abril").Value + .Columns("Pres. Mayo").Value + .Columns("Pres. Junio").Value _
                    + .Columns("Pres. Julio").Value + .Columns("Pres. Agosto").Value + .Columns("Pres. Sept.").Value + +.Columns("Pres. Octubre").Value + .Columns("Pres. Nov.").Value + .Columns("Pres. Dic.").Value
            End With
            Me.PrincipalBindingSource.EndEdit()
            Me.CTPresupuestoTableAdapter.Update(Me.CTPresupMensualDataSet.CTPresupuesto)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub

End Class