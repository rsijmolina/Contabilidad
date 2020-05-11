Public Class BAListaBancosFrm
    Private Sub BAListaBancosFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BABancosListaDataSet.BABancos' Puede moverla o quitarla según sea necesario.
        Me.BABancosTableAdapter.Fill(Me.BABancosListaDataSet.BABancos)
        'TODO: esta línea de código carga datos en la tabla 'BaBancosListaDataSet1.BABancos' Puede moverla o quitarla según sea necesario.
        'Me.BABancosTableAdapter.Fill(Me.BaBancosListaDataSet1.BABancos)
    End Sub

    Private Sub butAceptar_Click(sender As Object, e As EventArgs) Handles butAceptar.Click
        'Dim drvBanco As DataRowView = BaBancosListaDataSet1BindingSource.Current

    End Sub

    Private Sub butCancelar_Click(sender As Object, e As EventArgs) Handles butCancelar.Click
        Me.Close()
    End Sub
End Class