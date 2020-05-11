Public Class CTTipoPartidasFrm

    Private Sub CTTipoPartidasFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 10
        Me.Left = 10
        Try
            Me.CTTiposPartidasTableAdapter.Connection.ConnectionString = strcnCAD
            Me.CTTiposPartidasTableAdapter.Fill(Me.CTTipoPartidasDataSet.CTTiposPartidas)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub c1dbgrdTipos_AfterUpdate(sender As Object, e As EventArgs) Handles c1dbgrdTipos.AfterUpdate
        Try
            Me.Validate()
            Me.PrincipalBindingSource.EndEdit()
            Me.CTTiposPartidasTableAdapter.Update(Me.CTTipoPartidasDataSet.CTTiposPartidas)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class