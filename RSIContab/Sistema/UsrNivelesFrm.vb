Public Class UsrNivelesFrm

    Private Sub UsrNivelesFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.NivelesContTableAdapter.Connection.ConnectionString = crfgXNN
        Me.NivelesContTableAdapter.Fill(Me.UsrNivelesDataSet.NivelesCont)
        'TODO: esta línea de código carga datos en la tabla 'UsrNivelesDataSet.Niveles' Puede moverla o quitarla según sea necesario.
        'Me.NivelesTableAdapter.Fill(Me.UsrNivelesDataSet.Niveles)
        Me.MdiParent = MDIPrincipal
        Me.Top = 10
        Me.Left = 10

    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Me.Validate()
            Me.PrincipalBindingSource.EndEdit()

            Me.NivelesContTableAdapter.Update(Me.UsrNivelesDataSet.NivelesCont)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class