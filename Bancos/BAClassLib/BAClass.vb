Public Class BAClass
    Private _RgsrlCl As Int32
    Private _DBeng As String
    Private _DBconStr As String
    Private _DBcon As SqlClient.SqlConnection
    Private _DBTrans As SqlClient.SqlTransaction
    Private _mTransInicializada = False
    Private _AñoActual As Int16
    Private _MesActual As Int16
    Private _ErrorMsg As String
    Private _PeriodoActual As String

    Public Property RgsrlCl() As Int32
        Get
            RgsrlCl = _RgsrlCl
        End Get
        Set(ByVal value As Int32)
            _RgsrlCl = value
        End Set
    End Property
    Public Property DBeng() As String
        Get
            DBeng = _DBeng
        End Get
        Set(ByVal value As String)
            _DBeng = value
        End Set
    End Property
    Public Property DBconStr() As String
        Get
            DBconStr = _DBconStr
        End Get
        Set(ByVal value As String)
            _DBconStr = value
        End Set
    End Property

    ReadOnly Property DBCon() As SqlClient.SqlConnection
        Get
            DBCon = _DBcon
        End Get
    End Property
    Public Property AñoActual() As Int16
        Get
            AñoActual = _AñoActual
        End Get
        Set(ByVal value As Int16)
            _AñoActual = value
        End Set
    End Property
    Public Property MesActual() As Int16
        Get
            MesActual = _MesActual
        End Get
        Set(ByVal value As Int16)
            _MesActual = value
        End Set
    End Property
    ReadOnly Property ErrorMsg() As String
        Get
            ErrorMsg = _ErrorMsg
        End Get
    End Property
    Public Property PeriodoActual() As String
        Get
            PeriodoActual = _PeriodoActual
        End Get
        Set(ByVal value As String)
            _PeriodoActual = value
        End Set
    End Property
    Public Function ExisteBanco(ByVal intBanco As Int16) As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drBan As SqlClient.SqlDataReader

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT CodigoBanco FROM BABancos WHERE CodigoBanco=" & intBanco
        drBan = cmdInComando.ExecuteReader
        drBan.Read()
        If drBan.HasRows Then
            ExisteBanco = True
        Else
            ExisteBanco = False
        End If
        drBan.Close()
        cnSQLConexion.Close()
    End Function
    Public Function UltimoNoDoc(ByVal intBanco As Int16, intTipoDoc As Int32) As Int32
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drBan As SqlClient.SqlDataReader

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT UltimoCheque,UltimoDeposito,UltimaNotaDebito,UltimaNotaCredito,UltimaTransferencia FROM BABancos WHERE CodigoBanco=" & intBanco
        drBan = cmdInComando.ExecuteReader
        drBan.Read()
        If drBan.HasRows Then
            Select Case intTipoDoc
                Case 1
                    UltimoNoDoc = drBan("UltimoDeposito")
                Case 2
                    UltimoNoDoc = drBan("UltimocHEQUE")
                Case 3
                    UltimoNoDoc = drBan("UltimaNotaCredito")
                Case 4
                    UltimoNoDoc = drBan("UltimaNotaDebito")
                Case 6
                    UltimoNoDoc = drBan("UltimaTransferencia")
            End Select
        Else
            UltimoNoDoc = 0
        End If
        drBan.Close()
        cnSQLConexion.Close()
    End Function

    Public Sub ActualizarUltimoDoc(ByVal intBanco As Int16, intTipoDoc As Int32)
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        Select Case intTipoDoc
            Case 1
                cmdInComando.CommandText = "UPDATE BABancos SET UltimoDeposito=UltimoDeposito+1 WHERE CodigoBanco=" & intBanco
            Case 3
                cmdInComando.CommandText = "UPDATE BABancos SET UltimaNotaCredito=UltimaNotaCredito+1 WHERE CodigoBanco=" & intBanco
            Case 4
                cmdInComando.CommandText = "UPDATE BABancos SET UltimaNotaDebito=UltimaNotaDebito+1 WHERE CodigoBanco=" & intBanco
            Case 6
                cmdInComando.CommandText = "UPDATE BABancos SET UltimaTransferencia=UltimaTransferencia+1 WHERE CodigoBanco=" & intBanco
        End Select
        cmdInComando.ExecuteNonQuery()
        cnSQLConexion.Close()

    End Sub

    Public Function drConf() As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT * FROM BAConf"
        drConf = cmdInComando.ExecuteReader
        drConf.Read()
    End Function

End Class
