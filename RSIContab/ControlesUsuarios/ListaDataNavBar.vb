Public Class ListaDataNavBar
    Private _BindingSourcePrincipal As BindingSource
    Property BindingSourcePrincipal() As BindingSource
        Get
            BindingSourcePrincipal = _BindingSourcePrincipal
        End Get
        Set(ByVal value As BindingSource)
            _BindingSourcePrincipal = value
        End Set
    End Property
    Public Event NuevoRegistroClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event EditarRegistroClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event ConsultarRegistroClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event RecargarDatosClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event EliminarRegistroClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event SalirClick(ByVal sender As Object, ByVal e As EventArgs)
    Private Sub ListaDataNavBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsNothing(BindingSourcePrincipal) Then
            If BindingSourcePrincipal.Count > 0 Then
                HabilitarTodosBotones()
            Else
                HabilitarSoloBotonNuevo()
            End If
        End If
    End Sub


    Public Sub HabilitarSoloBotonNuevo()
        ToolStripButtonNuevo.Enabled = True
        ToolStripButtonEditar.Enabled = False
        ToolStripButtonConsultar.Enabled = False
        ToolStripButtonRecargar.Enabled = False
        'ToolStripButtonEliminar.Enabled = False
    End Sub
    Public Sub HabilitarTodosBotones()
        ToolStripButtonNuevo.Enabled = True
        ToolStripButtonEditar.Enabled = True
        ToolStripButtonConsultar.Enabled = True
        ToolStripButtonRecargar.Enabled = True
        'ToolStripButtonEliminar.Enabled = True
    End Sub

    Private Sub ToolStripButtonNuevo_Click(sender As Object, e As EventArgs) Handles ToolStripButtonNuevo.Click
        RaiseEvent NuevoRegistroClick(Me, e)
    End Sub

    Private Sub ToolStripButtonEditar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonEditar.Click
        RaiseEvent EditarRegistroClick(Me, e)
    End Sub

    Private Sub ToolStripButtonConsultar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonConsultar.Click
        RaiseEvent ConsultarRegistroClick(Me, e)
    End Sub

    'Private Sub ToolStripButtonEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonEliminar.Click
    '    RaiseEvent EliminarRegistroClick(Me, e)
    'End Sub

    Private Sub ToolStripButtonRecargar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonRecargar.Click
        RaiseEvent RecargarDatosClick(Me, e)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSalir.Click, ToolStripButtonSalir.Click
        RaiseEvent SalirClick(Me, e)
    End Sub


End Class
