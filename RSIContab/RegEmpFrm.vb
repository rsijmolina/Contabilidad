Public Class RegEmpFrm

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        My.Settings.RSIEmpresaInstalada = txtEmpresaInstalada.Text
        My.Settings.Save()
        Me.Close()
    End Sub
End Class