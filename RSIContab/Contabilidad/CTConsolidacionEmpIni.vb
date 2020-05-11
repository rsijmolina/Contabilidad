Public Class CTConsolidacionEmpIni

    Private Sub butAceptar_Click(sender As Object, e As EventArgs) Handles butAceptar.Click
        If radiobutConsolidacionComun.Checked Then
            Dim CTConsEmp As New CTConsolidacionEmpComunFrm
            CTConsEmp.ShowDialog()
        ElseIf radiobutConsolidacionExp.Checked Then
            Dim CTConsoExpFrm As New CTConsolidacionExpImpFrm
            CTConsoExpFrm.Tipo = "EXP"
            CTConsoExpFrm.Text = "Exportación de Datos Para Consolidación"
            CTConsoExpFrm.lblNombreArchivo.Text = "Nombre del Archivo a Exportar:"
            CTConsoExpFrm.ShowDialog()
        ElseIf radiobutConsolidacionImp.Checked Then
            Dim CTConsoImppFrm As New CTConsolidacionExpImpFrm
            CTConsoImppFrm.Tipo = "IMP"
            CTConsoImppFrm.Text = "Importación de Datos Para Consolidación"
            CTConsoImppFrm.lblNombreArchivo.Text = "Nombre del Archivo a Importar:"
            CTConsoImppFrm.chkBoxIniTablas.Visible = True
            CTConsoImppFrm.ShowDialog()
        End If

    End Sub

    Private Sub butCancelar_Click(sender As Object, e As EventArgs) Handles butCancelar.Click
        Me.Close()
    End Sub
End Class