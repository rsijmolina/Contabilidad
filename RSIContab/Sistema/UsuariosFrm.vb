Public Class UsuariosFrm
    Private Sub UsuariosFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UsuariosTableAdapter.Connection.ConnectionString = crfgXNN
        Me.UsuariosTableAdapter.Fill(Me.UsuariosDataSet.Usuarios)

        Me.MdiParent = MDIPrincipal
        Me.Top = 10
        Me.Left = 10

        DataNavBarPrincipal.toolstriptextBuscar.ToolTipText = "Buscar por Usuario"

    End Sub
    Private Sub DataNavBarPrincipal_BuscarRegistroClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.BuscarRegistroClick

        Try            
            Me.UsuariosTableAdapter.FillByUsuario(Me.UsuariosDataSet.Usuarios, DataNavBarPrincipal.toolstriptextBuscar.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DataNavBarPrincipal_GuardarRegistroClick(ByVal sender As Object, ByVal e As System.EventArgs, ByRef Cancelar As Boolean) Handles DataNavBarPrincipal.GuardarRegistroClick
        Dim NuevoRegRow As DataRowView
        Dim RSICl As New Rsierpgencl.Rsierpcl.Encripcion

        DataNavBarPrincipal.ResultadoValidacion = ""
        DataNavBarPrincipal.ValidacionCorrecta = True
        DataNavBarPrincipal.ValidarInfo(Me)
        NuevoRegRow = PrincipalBindingSource.Current
        NuevoRegRow.Item("Clave") = RSICl.Encriptar(c1txtClave.Text)

        If DataNavBarPrincipal.ValidacionCorrecta = True Then
            Try
                Me.Validate()
                Me.PrincipalBindingSource.EndEdit()

                Me.UsuariosTableAdapter.Update(Me.UsuariosDataSet.Usuarios)
            Catch ex As Exception
                Cancelar = True
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Verifique los siguientes datos:" & vbCrLf & DataNavBarPrincipal.ResultadoValidacion)
        End If

    End Sub

    Private Sub DataNavBarPrincipal_SalirClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.SalirClick
        Me.Close()
    End Sub

    Private Sub DataNavBarPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.Load

    End Sub
End Class