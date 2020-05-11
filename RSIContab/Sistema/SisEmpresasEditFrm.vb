Public Class SisEmpresasEditFrm
    Private _Modalidad As String
    Private _FormularioPrincipal As SisEmpresasFrm
    Private _intID As Int32
    Public Property intID() As Int32
        Get
            Return _intID
        End Get
        Set(ByVal value As Int32)
            _intID = value
        End Set
    End Property
    Public Property FormularioPrincipal() As SisEmpresasFrm
        Get
            Return _FormularioPrincipal
        End Get
        Set(ByVal value As SisEmpresasFrm)
            _FormularioPrincipal = value
        End Set
    End Property
    Public Property Modalidad() As String
        Get
            Return _Modalidad
        End Get
        Set(ByVal value As String)
            _Modalidad = value
        End Set
    End Property
    Private Sub SisEmpresasEditFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class