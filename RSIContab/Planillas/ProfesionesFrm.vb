Public Class ProfesionesFrm

    Private Sub ProfesionesFrm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.PageDown
                DataNavBarPrincipal.toolstripbutSiguienteRegistro.PerformClick()
            Case Keys.PageUp
                DataNavBarPrincipal.toolstripbutRegistroAnterior.PerformClick()
            Case Keys.Home
                DataNavBarPrincipal.toolstripbutPrimerRegistro.PerformClick()
            Case Keys.End
                DataNavBarPrincipal.toolstripbutUltimoRegistro.PerformClick()
        End Select

        If e.Control = True Then
            Select Case e.KeyCode
                Case Keys.N
                    DataNavBarPrincipal.toolstripbutNuevoRegistro.PerformClick()
                Case Keys.G
                    DataNavBarPrincipal.toolstripbutGuardarRegistro.PerformClick()
                Case Keys.Z
                    DataNavBarPrincipal.toolstripbutCancelarGuardar.PerformClick()
                Case Keys.M
                    DataNavBarPrincipal.toolstripbutModificarRegistro.PerformClick()
                Case Keys.E
                    DataNavBarPrincipal.toolstripbutEliminarRegistro.PerformClick()
                Case Keys.A
                    DataNavBarPrincipal.toolstripbutAnularDocumento.PerformClick()
                Case Keys.F
                    DataNavBarPrincipal.toolstripbutCerrarDocumento.PerformClick()
                Case Keys.T
                    DataNavBarPrincipal.toolstripbutContabilizar.PerformClick()
                Case Keys.B
                    DataNavBarPrincipal.toolstripbutBuscar.PerformClick()
                Case Keys.R
                    DataNavBarPrincipal.toolstripbutReiniciarDatos.PerformClick()
                Case Keys.S
                    DataNavBarPrincipal.toolstripbutSalir.PerformClick()
            End Select
        End If

    End Sub

    Private Sub ProfesionesFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIPrincipal
        Me.Top = 10
        Me.Left = 10

        DataNavBarPrincipal.toolstriptextBuscar.ToolTipText = "Buscar por Código de Profesión"
        Me.PLProfesionesTableAdapter.Connection.ConnectionString = strcnCAD
        Me.PLProfesionesTableAdapter.Fill(Me.PLProfesionesDataSet.PLProfesiones)

    End Sub

    Private Sub DataNavBarPrincipal_BuscarRegistroClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.BuscarRegistroClick
        Try
            Me.PLProfesionesTableAdapter.FillByCodigoProfesion(Me.PLProfesionesDataSet.PLProfesiones, DataNavBarPrincipal.toolstriptextBuscar.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DataNavBarPrincipal_GuardarRegistroClick(ByVal sender As Object, ByVal e As System.EventArgs, ByRef Cancelar As Boolean) Handles DataNavBarPrincipal.GuardarRegistroClick
        DataNavBarPrincipal.ResultadoValidacion = ""
        DataNavBarPrincipal.ValidacionCorrecta = True
        DataNavBarPrincipal.ValidarInfo(Me)
        If DataNavBarPrincipal.ValidacionCorrecta = True Then
            Try
                Me.Validate()
                Me.PrincipalBindingSource.EndEdit()

                Me.PLProfesionesTableAdapter.Update(Me.PLProfesionesDataSet.PLProfesiones)
            Catch ex As Exception
                Cancelar = True
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Verifique los siguientes datos:" & vbCrLf & DataNavBarPrincipal.ResultadoValidacion)
        End If

    End Sub

    Private Sub DataNavBarPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.Load

    End Sub

    Private Sub DataNavBarPrincipal_SalirClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.SalirClick
        Me.Close()
    End Sub
End Class