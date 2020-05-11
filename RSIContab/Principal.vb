Module Principal
    Public EmpresaInstalada As String
    Public CadenaConexion As String
    Public FormatoFecha As String
    Public FormatoTiempo As String
    Public FormatoNumerico As String
    Public FormatoSeparadorDecimal As String
    Public FormatoSeparadorMiles As String
    Public FormatoSimboloMoneda As String
    Public FormatoNegativo As String
    Public FechaDelSistema As Date
    Public idUsuarioActual As Int16
    Public NombreUsuarioActual As String
    Public NivelUsuarioActual As Int16
    Public DescripcionNivelUsuarioActual As String
    'Configuracion de estación
    'Inventarios
    Public MostrarListaInvPermanenteTrans As Boolean    'Muestra la lista del inventario en la captura de transacciones

    Public MDIPrincipal As MDIPrincipal
    'Public EmpresaInstalada As String
    Public AmbienteModalidad As String  'LAN para conexión de area local y WAN para conexión amplia
    Public FormatoIntFecha As Int16
    Public BaseDatosActual As String
    Public strcnCAD As String
    Public crfgXNN As String
    Private Declare Function SQLConfigDataSource Lib "ODBCCP32.DLL" (ByVal hwndParent As Integer, ByVal ByValfRequest As Integer, ByVal lpszDriver As String, ByVal lpszAttributes As String) As Integer
    Private Declare Function SQLInstallerError Lib "ODBCCP32.DLL" (ByVal iError As Integer, ByRef pfErrorCode As Integer, ByVal lpszErrorMsg As System.Text.StringBuilder, ByVal cbErrorMsgMax As Integer, ByRef pcbErrorMsg As Integer) As Integer
    Private Const ODBC_ADD_DSN As Short = 1 ' Add data source
    Private Const ODBC_ADD_SYS_DSN As Short = 4
    Private Const vbAPINull As Integer = 0 ' NULL Pointer

    Public Function ValidarUsuario(ByVal strUsr As String, ByVal strClave As String) As Boolean
        Dim RSICl As New Rsierpgencl.Rsierpcl.Encripcion
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdUsrComando As SqlClient.SqlCommand
        Dim drUsuarios As SqlClient.SqlDataReader
        Dim hashedDataBytes As Byte()

        Try
            cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
            cnSQLConexion.Open()
            cmdUsrComando = cnSQLConexion.CreateCommand
            cmdUsrComando.CommandType = CommandType.Text
            cmdUsrComando.CommandText = "SELECT Usuario,Nombre,Nivel,EsAdministrador FROM Usuarios WHERE Usuario=@Usuario AND Clave=@Clave"

            Dim paramUsername As SqlClient.SqlParameter
            paramUsername = New SqlClient.SqlParameter("@Usuario", SqlDbType.NVarChar, 10)
            paramUsername.Value = strUsr
            cmdUsrComando.Parameters.Add(paramUsername)

            hashedDataBytes = RSICl.Encriptar(strClave)
            Dim paramPwd As SqlClient.SqlParameter
            paramPwd = New SqlClient.SqlParameter("@Clave", SqlDbType.Binary, 16)
            paramPwd.Value = hashedDataBytes
            cmdUsrComando.Parameters.Add(paramPwd)

            'intResultado = cmdUsrComando.ExecuteScalar
            drUsuarios = cmdUsrComando.ExecuteReader
            drUsuarios.Read()
            If drUsuarios.HasRows Then
                ValidarUsuario = True
                My.Settings.RSIUsuarioActual = drUsuarios("Usuario")
                My.Settings.RSINombreUsuario = drUsuarios("Nombre")
                My.Settings.RSINivelUsuario = drUsuarios("Nivel")
                My.Settings.RSIEsAdministrador = drUsuarios("EsAdministrador")
            Else
                My.Settings.RSIUsuarioActual = ""
                My.Settings.RSINombreUsuario = ""
                My.Settings.RSINivelUsuario = 0
                My.Settings.RSIEsAdministrador = False
                MsgBox("Usuario y/o clave incorrecta", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                ValidarUsuario = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        Finally
            cnSQLConexion.Close()
        End Try
    End Function
    Public Sub DatosEmpresa(frmMdiPrin As Windows.Forms.Form)
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdUsrComando As SqlClient.SqlCommand
        Dim drDatosEmp As SqlClient.SqlDataReader
        Dim strCon As String

        Try
            cnSQLConexion = New SqlClient.SqlConnection(crfgXNN)
            cnSQLConexion.Open()
            cmdUsrComando = cnSQLConexion.CreateCommand
            cmdUsrComando.CommandType = CommandType.Text
            cmdUsrComando.CommandText = "SELECT * FROM DB ORDER BY ID"
            drDatosEmp = cmdUsrComando.ExecuteReader
            drDatosEmp.Read()

            If drDatosEmp.HasRows Then
                My.Settings.RSIEmpresaActual = drDatosEmp("NombreEmpresa")
                frmMdiPrin.Text = "RSI Contabilidad - " & drDatosEmp("NombreEmpresa")
                strCon = "Data Source=" & drDatosEmp("Servidor") & "\" _
                        & drDatosEmp("Instancia") & ";Initial Catalog=" & drDatosEmp("BaseDatos") & ";User ID=sa;Password=rsierp94128"
                BaseDatosActual = drDatosEmp("BaseDatos")
            End If
            cnSQLConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Public Sub CrearDSNUsuario(strSvr As String)
        Dim intRet As Integer
        Dim Driver As String
        Dim Attributes As String

        'Set the driver to SQL Server because it is most common.
        Driver = "SQL Server"
        'Set the attributes delimited by null.
        'See driver documentation for a complete
        'list of supported attributes.
        'Attributes = "SERVER=" & txtServidor.Text & "\" & txtInstancia.Text & Chr(0)
        Attributes = "SERVER=" & strSvr & Chr(0)
        Attributes = Attributes & "DESCRIPTION=Conexion RSI" & Chr(0)
        Attributes = Attributes & "DSN=RSISis" & Chr(0)
        Attributes = Attributes & "DATABASE=" & Chr(0)
        'Unsupported by SQL Server
        'Attributes = Attributes & "Uid=" & Chr(0) & "pwd=" & Chr(0)
        'To show dialog, use Form1.Hwnd instead of vbAPINull.
        intRet = SQLConfigDataSource(vbAPINull, ODBC_ADD_DSN, Driver, Attributes)
        If intRet <> 0 Then
            'MsgBox("DSN Created")
            'My.Settings.ConexionODBCCreada = True
        Else
            Dim nErrorCode As Integer
            Dim strError As New System.Text.StringBuilder(255)
            Dim nErrorLen As Integer
            intRet = SQLInstallerError(1, nErrorCode, strError, 255, nErrorLen)
            MsgBox("Create Failed - " & Strings.Left(strError.ToString, nErrorLen))
        End If
    End Sub

End Module
