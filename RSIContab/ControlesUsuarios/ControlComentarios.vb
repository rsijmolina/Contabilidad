Public Class ControlComentarios
    Private _Habilitado As Boolean
    Private _DBUsuario As String
    Private _DBFecha As Date
    Private _Modulo As String
    Private _DBID As Int64
    Private _DBNoTransaccion As String
    Private _DBComentario As String
    Private _BindingSourceComentarios As BindingSource
    Property DBUsuario() As String
        Get
            DBUsuario = _DBUsuario
        End Get
        Set(ByVal value As String)
            _DBUsuario = value
        End Set
    End Property
    Property DBFecha() As Date
        Get
            DBFecha = _DBFecha
        End Get
        Set(ByVal value As Date)
            _DBFecha = value
        End Set
    End Property
    Property DBNoTransaccion() As String
        Get
            DBNoTransaccion = _DBNoTransaccion
        End Get
        Set(ByVal value As String)
            _DBNoTransaccion = value
        End Set
    End Property
    Property DBComentario() As String
        Get
            DBComentario = _DBComentario
        End Get
        Set(ByVal value As String)
            _DBComentario = value
        End Set
    End Property
    Property Modulo() As String
        Get
            Modulo = _Modulo
        End Get
        Set(ByVal value As String)
            _Modulo = value
        End Set
    End Property
    Property DBID() As Long
        Get
            DBID = _DBID
        End Get
        Set(ByVal value As Long)
            _DBID = value
        End Set
    End Property
    Property BindingSourceComentarios() As BindingSource
        Get
            BindingSourceComentarios = _BindingSourceComentarios
        End Get
        Set(ByVal value As BindingSource)
            _BindingSourceComentarios = value
        End Set
    End Property

    Public Event GuardarRegistroClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event ModificarRegistroClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event DeshacerCambiosClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event EliminarRegistroClick(ByVal sender As Object, ByVal e As EventArgs)

    Private Sub ControlComentarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnModificarGuardar_Click(sender As System.Object, e As System.EventArgs)
        Dim mCancelar As Boolean
        mCancelar = False
        VerificarControles(False)
        RaiseEvent GuardarRegistroClick(Me, e)
    End Sub

    Private Sub ControlComentarios_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

    End Sub
    Public Sub VerificarControles(mHabilitar As Boolean)
        txtComentarios.ReadOnly = Not mHabilitar
        toolstripbutGuardar.Enabled = mHabilitar
        toolstripButModificar.Enabled = Not mHabilitar
        toolstripbutDeshacer.Enabled = mHabilitar
        toolstripbutEliminar.Enabled = Not mHabilitar
    End Sub

    Private Sub toolstripButModificar_Click(sender As System.Object, e As System.EventArgs) Handles toolstripButModificar.Click
        VerificarControles(True)
        RaiseEvent ModificarRegistroClick(Me, e)
    End Sub

    Private Sub toolstripbutDeshacer_Click(sender As System.Object, e As System.EventArgs) Handles toolstripbutDeshacer.Click
        VerificarControles(False)
        txtComentarios.Text = DBComentario
        RaiseEvent DeshacerCambiosClick(Me, e)
    End Sub

    Private Sub toolstripbutEliminar_Click(sender As System.Object, e As System.EventArgs) Handles toolstripbutEliminar.Click
        Dim mCancelar As Boolean
        mCancelar = False

        RaiseEvent EliminarRegistroClick(Me, e)
    End Sub

    Private Sub toolstripbutGuardar_Click(sender As System.Object, e As System.EventArgs) Handles toolstripbutGuardar.Click
        VerificarControles(False)
        DBComentario = txtComentarios.Text
        RaiseEvent GuardarRegistroClick(Me, e)
    End Sub
End Class
