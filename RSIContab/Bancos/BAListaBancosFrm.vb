Public Class BAListaBancosFrm

    Private Sub BAListaBancosFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescar()
    End Sub


    Private Sub butCancelar_Click(sender As Object, e As EventArgs) Handles butCancelar.Click
        Me.Close()
    End Sub

    Private Sub toolstripbutRefrescar_Click(sender As Object, e As EventArgs) Handles toolstripbutRefrescar.Click
        refrescar()
    End Sub

    Private Sub refrescar()
        Try
            Me.BABancosTableAdapter.Connection.ConnectionString = strcnCAD
            Me.BABancosTableAdapter.Fill(Me.BABancosListaDataSet.BABancos)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class