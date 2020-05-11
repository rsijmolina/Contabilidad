Public Class MantenimientoEmpresasFrm
    Dim mBuscando As Boolean
    Private Sub MantenimientoEmpresasFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub MantenimientoEmpresasFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DBTableAdapter.Connection.ConnectionString = crfgXNN
        Me.DBTableAdapter.Fill(Me.BaseDatosDataSet.DB)
        Me.MdiParent = MDIPrincipal
        Me.Top = 10
        Me.Left = 10

        DataNavBarPrincipal.toolstriptextBuscar.ToolTipText = "Buscar por ID de Empresa"
        mBuscando = False
    End Sub
End Class