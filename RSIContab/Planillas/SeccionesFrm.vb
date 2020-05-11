Public Class SeccionesFrm

    Private Sub SeccionesFrm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If Not c1dbgrdGrupos.Focused Then
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
        End If

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

    Private Sub SeccionesFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PLSeccionesDataSet.PLDepartamentos' Puede moverla o quitarla según sea necesario.
        Me.PLDepartamentosTableAdapter.Fill(Me.PLSeccionesDataSet.PLDepartamentos)
        'TODO: esta línea de código carga datos en la tabla 'PLSeccionesDataSet.PLSedes' Puede moverla o quitarla según sea necesario.
        Me.PLSedesTableAdapter.Fill(Me.PLSeccionesDataSet.PLSedes)
        'TODO: esta línea de código carga datos en la tabla 'PLSeccionesDataSet.PLSecciones' Puede moverla o quitarla según sea necesario.

        Me.MdiParent = MDIPrincipal
        Me.Top = 10
        Me.Left = 10

        DataNavBarPrincipal.toolstriptextBuscar.ToolTipText = "Buscar por Código de Sección"
        DataNavBarPrincipal.UsarBotonNuevoRegistro = False
        DataNavBarPrincipal.UsarBotonModificarRegistro = False
        DataNavBarPrincipal.UsarBotonGuardarRegistro = False
    End Sub

    Private Sub DataNavBarPrincipal_BuscarRegistroClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.BuscarRegistroClick
        Try            
            Me.PLDepartamentosTableAdapter.FillByCodigoSede(Me.PLSeccionesDataSet.PLDepartamentos, DataNavBarPrincipal.toolstriptextBuscar.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PrincipalBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrincipalBindingSource.PositionChanged
        Dim mData As DataRowView

        If Not IsNothing(PrincipalBindingSource.Current) Then
            mData = PrincipalBindingSource.Current
            'SedesBindingSource.Filter = "CodigoSede='" & lblCodigoSede.Text & "'"
            'DepartamentosBindingSource.Filter = "CodigoSede='" & lblCodigoSede.Text & "' AND CodigoDepartamento='" & lblCodigoDepartamento.Text & "'"
            Me.PLSeccionesTableAdapter.Fill(Me.PLSeccionesDataSet.PLSecciones, mData("CodigoSede"), mData("CodigoDepartamento"))
        End If
    End Sub

    Private Sub DataNavBarPrincipal_ReiniciarDatosClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.ReiniciarDatosClick
        PrincipalBindingSource_PositionChanged(Me, e)
    End Sub

    Private Sub c1dbgrdGrupos_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1dbgrdGrupos.AfterUpdate
        Try
            Me.Validate()
            Me.PrincipalBindingSource.EndEdit()
            Me.PLSeccionesTableAdapter.Update(Me.PLSeccionesDataSet.PLSecciones)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub c1dbgrdGrupos_BeforeUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1dbgrdGrupos.BeforeUpdate
        c1dbgrdGrupos.Columns("CodigoSede").Value = lblCodigoSede.Text
        c1dbgrdGrupos.Columns("CodigoDepartamento").Value = lblCodigoDepartamento.Text
    End Sub

    Private Sub DataNavBarPrincipal_SalirClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.SalirClick
        Me.Close()
    End Sub

    Private Sub DataNavBarPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.Load

    End Sub

    Private Sub PrincipalBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrincipalBindingSource.CurrentChanged

    End Sub
End Class