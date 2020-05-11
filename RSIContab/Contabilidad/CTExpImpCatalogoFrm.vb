Public Class CTExpImpCatalogoFrm

    Private Sub butAceptar_Click(sender As Object, e As EventArgs) Handles butAceptar.Click
        If RadioButImportar.Checked Then
            Dim ImpCatFrm As New CTImpCatalogoFrm
            ImpCatFrm.ShowDialog()
        Else
            Dim ExpCatFrm As New CTExpCatalogoFrm
            ExpCatFrm.ShowDialog()
        End If
    End Sub

    Private Sub butCancelar_Click(sender As Object, e As EventArgs) Handles butCancelar.Click
        Me.Close()
    End Sub
End Class