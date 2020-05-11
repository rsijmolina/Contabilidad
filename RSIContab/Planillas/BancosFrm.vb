Public Class BancosFrm

    Private Sub BancosFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PLBancosDataSet.PLBancos' Puede moverla o quitarla según sea necesario.
        Me.PLBancosTableAdapter.Fill(Me.PLBancosDataSet.PLBancos)
        Me.MdiParent = MDIPrincipal
        Me.Top = 10
        Me.Left = 10

    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        PrincipalBindingSource.CancelEdit()
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Me.Validate()
            Me.PrincipalBindingSource.EndEdit()
            Me.PLBancosTableAdapter.Update(Me.PLBancosDataSet.PLBancos)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.Close()
        End Try
    End Sub
End Class