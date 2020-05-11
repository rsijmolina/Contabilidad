Public Class ConfBaseDatosFrm

    Private Sub ConfBaseDatosFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseDatosDataSet.DB' Puede moverla o quitarla según sea necesario.
        Me.DBTableAdapter.Fill(Me.BaseDatosDataSet.DB)
        Me.MdiParent = MDIPrincipal
        Me.Top = 10
        Me.Left = 10

        If Me.PrincipalBindingSource.Count = 0 Then
            Me.PrincipalBindingSource.AddNew()
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.PrincipalBindingSource.CancelEdit()
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Me.Validate()
            Me.PrincipalBindingSource.EndEdit()
            Me.DBTableAdapter.Update(Me.BaseDatosDataSet.DB)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Close()
    End Sub
End Class