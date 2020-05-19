Public Class BADepNotasTransEdicionFrm
    Private _FormularioPrincipal As BADepNotasTransfFrm
    Dim dbCls As New CTClassLib.CTClass
    Dim drConf As SqlClient.SqlDataReader

    Private _Año As Int16
    Public Property Año() As Int16
        Get
            Return _Año
        End Get
        Set(ByVal value As Int16)
            _Año = value
        End Set
    End Property

    Private _Mes As Int16
    Public Property Mes() As Int16
        Get
            Return _Mes
        End Get
        Set(ByVal value As Int16)
            _Mes = value
        End Set
    End Property

    Public Property FormularioPrincipal() As BADepNotasTransfFrm
        Get
            Return _FormularioPrincipal
        End Get
        Set(ByVal value As BADepNotasTransfFrm)
            _FormularioPrincipal = value
        End Set
    End Property

    Private _Modalidad As String
    Public Property Modalidad() As String
        Get
            Return _Modalidad
        End Get
        Set(ByVal value As String)
            _Modalidad = value
        End Set
    End Property

    Private _drvBanco As DataRowView
    Public Property drvBanco() As DataRowView
        Get
            Return _drvBanco
        End Get
        Set(ByVal value As DataRowView)
            _drvBanco = value
        End Set
    End Property

    Private _intBanco As Int16
    Public Property intBanco() As Int16
        Get
            Return _intBanco
        End Get
        Set(ByVal value As Int16)
            _intBanco = value
        End Set
    End Property

    Private _TipoDocumento As String
    Public Property TipoDocumento() As String
        Get
            Return _TipoDocumento
        End Get
        Set(ByVal value As String)
            _TipoDocumento = value
        End Set
    End Property

    Private _CodigoBanco As Int16
    Public Property CodigoBanco() As Int16
        Get
            Return _CodigoBanco
        End Get
        Set(ByVal value As Int16)
            _CodigoBanco = value
        End Set
    End Property

    Private _Saldo As Int16
    Public Property Saldo() As Int16
        Get
            Return _Saldo
        End Get
        Set(ByVal value As Int16)
            _Saldo = value
        End Set
    End Property

    Private _Cuenta As Int16
    Public Property Cuenta() As Int16
        Get
            Return _Cuenta
        End Get
        Set(ByVal value As Int16)
            _Cuenta = value
        End Set
    End Property

    Dim drvTransEnc As DataRowView


    Private Sub BADepNotasTransEdicionFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BATransaccionesDetalleTableAdapter.Connection.ConnectionString = strcnCAD
        Me.BATransaccionesDocumentacionTableAdapter.Connection.ConnectionString = strcnCAD
        Me.BATransaccionesEncabezadoTableAdapter.Connection.ConnectionString = strcnCAD
        dbCls.DBconStr = strcnCAD
        drConf = dbCls.drConf
        If Modalidad = "NUEVO" Then
            PrincipalBindingSource.AddNew()
            drvTransEnc = PrincipalBindingSource.Current()
            drvTransEnc("CodigoBanco") = intBanco
        End If
        If Modalidad <> "NUEVO" Then
            CargarDatos()
        End If
        Me.EditDataNavBar1.HabilitarBotones(Me)
    End Sub


    Public Sub CargarDatos()
        Try
            Me.BATransaccionesDetalleTableAdapter.Fill(Me.BATransaccionesEdicionDataSet.BATransaccionesDetalle, intBanco, TipoDocumento, Año, Mes)
            Me.BATransaccionesEncabezadoTableAdapter.Fill(Me.BATransaccionesEdicionDataSet.BATransaccionesEncabezado, intBanco, TipoDocumento, Año, Mes)
            Me.BATransaccionesDocumentacionTableAdapter.Fill(Me.BATransaccionesEdicionDataSet.BATransaccionesDocumentacion, intBanco)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub



    Private Sub EditDataNavBar1_GuardarClick(sender As Object, e As EventArgs) Handles EditDataNavBar1.GuardarClick
        Try
            Me.Validate()
            PrincipalBindingSource.EndEdit()
            Me.BATransaccionesEncabezadoTableAdapter.Update(Me.BATransaccionesEdicionDataSet.BATransaccionesEncabezado)
            BADetalleTransBindingSource.EndEdit()
            Me.BATransaccionesDetalleTableAdapter.Update(Me.BATransaccionesEdicionDataSet.BATransaccionesDetalle)
            BATransDocBindingSource.EndEdit()
            Me.BATransaccionesDocumentacionTableAdapter.Update(Me.BATransaccionesEdicionDataSet.BATransaccionesDocumentacion)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub EditDataNavBar1_SalirClick(sender As Object, e As EventArgs) Handles EditDataNavBar1.SalirClick
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim lista As New BAListaBancosFrm
        lista.ShowDialog()
    End Sub
End Class