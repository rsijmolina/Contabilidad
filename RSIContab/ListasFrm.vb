Public Class ListasFrm
    Private _NombreLista As String
    Private _Condicion As String
    Private _Filtro As String
    Private _ControlDestino As Control
    Private _ControlDescripcion As Control
    Private _CamposAdicionales As String
    Private _ViewListas As Data.DataView
    Private _mAceptar As Boolean
    Private _CampoOrdenar As String
    '* Datos
    Dim cnSQLConexion As Data.SqlClient.SqlConnection
    Dim daListas As Data.SqlClient.SqlDataAdapter
    Dim dtListas As Data.DataTable
    'Dim dsListas As Data.DataSet
    Dim strTabla As String
    Dim strCampos As String
    Dim strCampo1 As String
    Dim strCampo2 As String
    Dim strSQL As String
    Dim strConn As String

    Public Property NombreLista() As String
        Get
            NombreLista = _NombreLista
        End Get
        Set(ByVal value As String)
            _NombreLista = value
        End Set
    End Property
    Public Property Condicion() As String
        Get
            Condicion = _Condicion
        End Get
        Set(ByVal value As String)
            _Condicion = value
        End Set
    End Property
    Public Property Filtro() As String
        Get
            Filtro = _Filtro
        End Get
        Set(ByVal value As String)
            _Filtro = value
        End Set
    End Property

    Public Property ControlDestino() As Control
        Get
            ControlDestino = _ControlDestino
        End Get
        Set(ByVal value As Control)
            _ControlDestino = value
        End Set
    End Property
    Public Property ControlDescripcion() As Control
        Get
            ControlDescripcion = _ControlDescripcion
        End Get
        Set(ByVal value As Control)
            _ControlDescripcion = value
        End Set
    End Property
    Public Property CamposAdicionales() As String
        Get
            CamposAdicionales = _CamposAdicionales
        End Get
        Set(ByVal value As String)
            _CamposAdicionales = value
        End Set
    End Property
    Public Property ViewListas() As Data.DataView
        Get
            ViewListas = _ViewListas
        End Get
        Set(ByVal value As Data.DataView)
            _ViewListas = value
        End Set
    End Property
    Public Property mAceptar() As Boolean
        Get
            mAceptar = _mAceptar
        End Get
        Set(ByVal value As Boolean)
            _mAceptar = value
        End Set
    End Property
    Public Property CampoOrdenar() As String
        Get
            CampoOrdenar = _CampoOrdenar
        End Get
        Set(ByVal value As String)
            _CampoOrdenar = value
        End Set
    End Property
    Private Sub ListasFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ConectarDatos()
            CargarDatos()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        'For i = 0 To dsListas.Tables(0).Rows.Count - 1
        'Debug.Print(dsListas.Tables(0).Rows(i).Item(0).ToString)
        'Next
    End Sub
    Private Sub ConectarDatos()
        strConn = strcnCAD.ToString
        SeleccionarDatos()
        daListas = New SqlClient.SqlDataAdapter(strSQL, strConn)
    End Sub
    Private Sub SeleccionarDatos()
        Select Case _NombreLista
            Case "Deducciones"
                Me.Text = "Lista de Deducciones"
                strTabla = "PLDefinicionDeducciones"
                strCampo1 = "CodigoDeduccion"
                strCampo2 = "DescripcionDeduccion"
                strCampos = strCampo1 & "," & strCampo2 & IIf(String.IsNullOrEmpty(CamposAdicionales), "", "," & CamposAdicionales)
        End Select
        If String.IsNullOrEmpty(_Condicion) Then
            If String.IsNullOrEmpty(_CampoOrdenar) Then
                strSQL = "SELECT " & strCampos & " FROM dbo." & strTabla & " ORDER BY " & strCampo2
            Else
                strSQL = "SELECT " & strCampos & " FROM dbo." & strTabla & " ORDER BY " & _CampoOrdenar
            End If
        Else
            If String.IsNullOrEmpty(_CampoOrdenar) Then
                strSQL = "SELECT " & strCampos & " FROM dbo." & strTabla & " WHERE " & _Condicion & " ORDER BY " & strCampo2
            Else
                strSQL = "SELECT " & strCampos & " FROM dbo." & strTabla & " WHERE " & _Condicion & " ORDER BY " & _CampoOrdenar
            End If
        End If
    End Sub
    Public Sub CargarDatos()
        Dim i As Int16

        Try
            'dsListas = New Data.DataSet
            dtListas = New Data.DataTable
            If IsNothing(daListas) Then
                ConectarDatos()
            End If
            daListas.Fill(dtListas)
            ViewListas = New Data.DataView(dtListas)
            If Filtro <> "" Then
                ViewListas.RowFilter = Filtro
            End If
            c1dbgrdListas.DataSource = ViewListas
            c1dbgrdListas.Columns(0).DataField = strCampo1
            c1dbgrdListas.Columns(1).DataField = strCampo2
            c1dbgrdListas.Splits(0).DisplayColumns(0).Width = 100
            c1dbgrdListas.Columns(0).Caption = "Código"
            c1dbgrdListas.Splits(0).DisplayColumns(1).Width = 250
            c1dbgrdListas.Columns(1).Caption = "Descripcion"
            For i = 0 To c1dbgrdListas.Columns.Count - 1
                If i <> 0 And i <> 1 Then
                    c1dbgrdListas.Splits(0).DisplayColumns(i).Visible = False
                End If
            Next
            'c1dbgrdLis = 100
            'c1dbgrdListas.Refresh()

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        'ControlDestino.Text = dtListas.Rows(c1dbgrdListas.RowBookmark(c1dbgrdListas.Row)).Item(0).ToString
        If Not IsNothing(ControlDestino) Then
            ControlDestino.Text = c1dbgrdListas.Item(c1dbgrdListas.Row, 0).ToString
        End If
        If Not IsNothing(ControlDescripcion) Then
            ControlDescripcion.Text = c1dbgrdListas.Item(c1dbgrdListas.Row, 1).ToString
        End If
        'ControlDescripcion.Text = dtListas.Rows(c1dbgrdListas.Row).Item(1).ToString
        mAceptar = True
        'Me.Hide()
    End Sub

    Private Sub toolstripbutRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutRefrescar.Click
        CargarDatos()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        mAceptar = False
        'Me.Hide()
    End Sub
End Class