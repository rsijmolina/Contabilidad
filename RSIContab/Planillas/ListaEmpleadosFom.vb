Public Class ListaEmpleadosFom
    Private _EmpleadosRetirados As Boolean
    Private _ListarTodos As Boolean
    Private _OrdenarPorCodigo As Boolean

    Public Property EmpleadosRetirados() As Boolean
        Get
            EmpleadosRetirados = _EmpleadosRetirados
        End Get
        Set(ByVal value As Boolean)
            _EmpleadosRetirados = value
        End Set
    End Property
    Public Property OrdenarPorCodigo() As Boolean
        Get
            OrdenarPorCodigo = _OrdenarPorCodigo
        End Get
        Set(ByVal value As Boolean)
            _OrdenarPorCodigo = value
        End Set
    End Property
    Public Property ListarTodos() As Boolean
        Get
            ListarTodos = _ListarTodos
        End Get
        Set(ByVal value As Boolean)
            _ListarTodos = value
        End Set
    End Property

    Private Sub ListaEmpleadosFom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PLListaEmpleadosDataSet.PLEmpleados' Puede moverla o quitarla según sea necesario.
        toolstripcmbboxTipoEmpleado.Items.Clear()
        toolstripcmbboxTipoEmpleado.Items.Add("Activos")
        toolstripcmbboxTipoEmpleado.Items.Add("Retirados")
        toolstripcmbboxTipoEmpleado.Items.Add("Todos")
        toolstripcmbboxTipoEmpleado.SelectedItem = "Activos"
        Me.PLEmpleadosTableAdapter.Fill(Me.PLListaEmpleadosDataSet.PLEmpleados, False)
        If ListarTodos Then
            'Me.PLEmpleadosTableAdapter.FillByTodos(Me.PLListaEmpleadosDataSet.PLEmpleados)
        Else
            'Me.PLEmpleadosTableAdapter.Fill(Me.PLListaEmpleadosDataSet.PLEmpleados, _EmpleadosRetirados)
        End If
        If _OrdenarPorCodigo Then
            'PrincipalBindingSource.RemoveSort()
            PrincipalBindingSource.Sort = "CodigoEmpleado ASC"
        End If
    End Sub

    Private Sub c1dbgrdListaEmpleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1dbgrdListaEmpleados.Click

    End Sub

    Private Sub c1dbgrdListaEmpleados_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1dbgrdListaEmpleados.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar.PerformClick()
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

    End Sub

    Private Sub toolstripcmbboxTipoEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripcmbboxTipoEmpleado.Click

    End Sub

    Private Sub toolstripcmbboxTipoEmpleado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles toolstripcmbboxTipoEmpleado.SelectedIndexChanged
        If toolstripcmbboxTipoEmpleado.SelectedItem = "Activos" Then
            Me.PLEmpleadosTableAdapter.Fill(Me.PLListaEmpleadosDataSet.PLEmpleados, False)
        ElseIf toolstripcmbboxTipoEmpleado.SelectedItem = "Retirados" Then
            Me.PLEmpleadosTableAdapter.Fill(Me.PLListaEmpleadosDataSet.PLEmpleados, True)
        ElseIf toolstripcmbboxTipoEmpleado.SelectedItem = "Todos" Then    'Todos
            Me.PLEmpleadosTableAdapter.FillByTodos(Me.PLListaEmpleadosDataSet.PLEmpleados)
        End If
    End Sub
End Class