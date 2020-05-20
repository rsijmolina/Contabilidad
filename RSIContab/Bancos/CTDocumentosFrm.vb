Public Class CTDocumentosFrm
    Private Sub C1ButtonSeleccionarArchivo_Click(sender As Object, e As EventArgs) Handles C1ButtonSeleccionarArchivo.Click
        OpenFileDialogArchivo.ShowDialog()
        If OpenFileDialogArchivo.FileName.Length > 0 Then
            TextBoxArchivo.Text = OpenFileDialogArchivo.FileName

        End If
    End Sub

End Class