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

    Public fFormaPrin As MDIPrincipal
    'Public EmpresaInstalada As String
    Public AmbienteModalidad As String  'LAN para conexión de area local y WAN para conexión amplia
    Public FormatoIntFecha As Int16
    Public BaseDatosActual As String
    Dim RSICl As New Rsierpgencl.Rsierpcl.Encripcion
    Public strcnCAD As String
    Public crfgXNN As String

    Sub Main()
        Dim mLoginFrm As New LoginForm

        Try
            '*** Revisar si ya existen los datos en el registro del sistema
            If Not IO.File.Exists(Environment.GetEnvironmentVariable("SystemRoot") & "\System32\mmdrv1.dll") Then
                MsgBox("Error de aplicación -1")
                Application.Exit()
            Else
                ConfConexion()
                'VerificarRegistro()
                'MostrarListaInvPermanenteTrans = True
                'My.Settings.RSIEmpresaActual = "Asociación TAC"
                'My.Settings.RunTimeRSIConnectionString = "Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=RSISistema1;Integrated Security=True"
                fFormaPrin = New MDIPrincipal
                fFormaPrin.statuslblEstacion.Text = "Estación: " & My.Computer.Name
                FormatoIntFecha = 103    'dd/mm/aaaa
                'FormatoIntFecha = 102  ANSI
                While 1
                    mLoginFrm.ShowDialog()
                    If (mLoginFrm.UsernameTextBox.Text = "admin" And mLoginFrm.PasswordTextBox.Text = "rsi94128") Then
                        My.Settings.RSIUsuarioActual = "admin"
                        mLoginFrm.Close()
                        HabilitarMenu(False, True)
                        DatosEmpresa()
                        Exit While
                    End If
                    If mLoginFrm.mAceptar Then
                        If ValidarUsuario(mLoginFrm.UsernameTextBox.Text, mLoginFrm.PasswordTextBox.Text) Then
                            mLoginFrm.Close()
                            If My.Settings.RSIEsAdministrador Then
                                HabilitarMenu(False, True)
                            Else
                                HabilitarMenu(False, False)
                            End If
                            DatosEmpresa()
                            Exit While
                        End If
                    Else
                        mLoginFrm.Close()
                        HabilitarMenu(True, False)
                        Exit While
                    End If
                End While
                fFormaPrin.statuslblUsuario.Text = "Usuario: " & My.Settings.RSIUsuarioActual
                Application.Run(fFormaPrin)
                'My.Computer.FileSystem.SpecialDirectories.Temp
                'Procedimientos principales
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Public Sub ConfLstItemsInv(ByVal dbgrdDet As C1.Win.C1TrueDBGrid.C1TrueDBGrid)
        dbgrdDet.Splits(0).DisplayColumns(0).Width = 84
        dbgrdDet.Splits(0).DisplayColumns(0).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        dbgrdDet.Columns(0).Caption = "Sucursal"

        dbgrdDet.Splits(0).DisplayColumns(1).Width = 120
        dbgrdDet.Splits(0).DisplayColumns(1).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        dbgrdDet.Columns(1).Caption = "Item"

        dbgrdDet.Splits(0).DisplayColumns(2).Width = 284
        dbgrdDet.Splits(0).DisplayColumns(2).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        dbgrdDet.Columns(2).Caption = "Descripción"

        dbgrdDet.Splits(0).DisplayColumns(3).Width = 83
        dbgrdDet.Splits(0).DisplayColumns(3).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        dbgrdDet.Columns(3).Caption = "Disponible"

        dbgrdDet.Splits(0).DisplayColumns(4).Width = 75
        dbgrdDet.Splits(0).DisplayColumns(4).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        dbgrdDet.Columns(4).Caption = "U. Medida"
    End Sub
    Private Sub VerificarRegistro()
        Try
            If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\RSIERP", "SetIni", Nothing) Is Nothing Then
                My.Computer.Registry.LocalMachine.CreateSubKey("Software\RSIERP")
                My.Computer.Registry.LocalMachine.CreateSubKey("Software\RSIERP\SetIni")
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\RSIERP", "SetIni", "01275-1430")
                My.Computer.Registry.LocalMachine.CreateSubKey("Software\RSIERP\Svr\Nsvr")
                My.Computer.Registry.LocalMachine.CreateSubKey("Software\RSIERP\Svr\Usr")
                My.Computer.Registry.LocalMachine.CreateSubKey("Software\RSIERP\Svr\Clv")
                'My.Computer.Registry.LocalMachine.CreateSubKey("Software\RSIERP\Contab")
                'My.Computer.Registry.LocalMachine.CreateSubKey("Software\RSIERP\Bancos")
                'My.Computer.Registry.LocalMachine.CreateSubKey("Software\RSIERP\Activos")
                'My.Computer.Registry.LocalMachine.CreateSubKey("Software\RSIERP\Compras")
                'My.Computer.Registry.LocalMachine.CreateSubKey("Software\RSIERP\Inv")
                'My.Computer.Registry.LocalMachine.CreateSubKey("Software\RSIERP\Ventas")
                'My.Computer.Registry.LocalMachine.CreateSubKey("Software\RSIERP\Plani")
                'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\RSIERP\Inv", "SucPredCod", "")
                'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\RSIERP\Inv", "SucPredDesc", "")
                'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\RSIERP\Inv", "ListaInvAjuste", "")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ConfConexion()
        Dim strCon As String

        strCon = ""
        Try
            strCon = "Data Source=" & My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\XMLWT\Stvx\Nvs", "Nvs1", Nothing) & "\" _
                & My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\XMLWT\IzVer\Ipta", "Ipta1", Nothing) & ";Initial Catalog=RSICNF;User ID=sa;Password=rsierp94128"

            'My.Settings.RunTimeRSICONFConnectionString = strCon
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Public Function ValidarUsuario(ByVal strUsr As String, ByVal strClave As String) As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdUsrComando As SqlClient.SqlCommand
        Dim drUsuarios As SqlClient.SqlDataReader
        Dim hashedDataBytes As Byte()

        Try
            cnSQLConexion = New SqlClient.SqlConnection(My.Settings.RSICNFConnectionString)
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
    Public Sub HabilitarMenu(ByVal mDeshabilitarTodo As Boolean, ByVal EsAdminis As Boolean)
        Dim itm As ToolStripMenuItem

        For Each itm In fFormaPrin.mnuPrincipal.Items
            HabilitarSubMenu(itm, mDeshabilitarTodo, EsAdminis)
        Next
    End Sub
    Private Sub HabilitarSubMenu(ByVal mItem As ToolStripMenuItem, ByVal mDeshabilTodo As Boolean, ByVal EsAdministrador As Boolean)
        Dim itm As New ToolStripMenuItem
        Dim i As Int16

        If Not mDeshabilTodo Then
            If EsAdministrador Then
                mItem.Enabled = True
            Else
                mItem.Enabled = HabilitarEsteMenuItem(mItem.Name)
            End If
        Else
            If mItem.Name = "ArchivoToolStripMenuItem" Then
                mItem.Enabled = True
            Else
                mItem.Enabled = False
            End If
        End If
        For i = 0 To mItem.DropDownItems.Count - 1
            If Not mDeshabilTodo Then
                If EsAdministrador Then
                    mItem.DropDownItems(i).Enabled = True
                Else
                    mItem.DropDownItems(i).Enabled = HabilitarEsteMenuItem(mItem.DropDownItems(i).Name)
                End If
            Else
                If mItem.DropDownItems(i).Name = "IniciarSesionToolStripMenuItem" Then
                    mItem.DropDownItems(i).Enabled = True
                ElseIf mItem.DropDownItems(i).Name = "SalirToolStripMenuItem" Then
                    mItem.DropDownItems(i).Enabled = True
                Else
                    mItem.DropDownItems(i).Enabled = False
                End If
            End If
            If mItem.DropDownItems(i).GetType Is GetType(ToolStripMenuItem) Then
                itm = CType(mItem.DropDownItems(i), ToolStripMenuItem)
                If itm.DropDownItems.Count > 0 Then
                    HabilitarSubMenu(itm, mDeshabilTodo, EsAdministrador)
                End If
            End If
        Next
    End Sub
    Public Function HabilitarEsteMenuItem(ByVal strNombreMenu As String) As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdUsrComando As SqlClient.SqlCommand
        Dim drNiveles As SqlClient.SqlDataReader

        cnSQLConexion = New SqlClient.SqlConnection(My.Settings.RSICNFConnectionString)
        cnSQLConexion.Open()
        cmdUsrComando = cnSQLConexion.CreateCommand
        cmdUsrComando.CommandType = CommandType.Text
        cmdUsrComando.CommandText = "SELECT NombreMenu,Nivel" & Strings.Trim(Str(My.Settings.RSINivelUsuario)) & " FROM Niveles WHERE NombreMenu='" & strNombreMenu & "' ORDER BY NombreMenu"
        drNiveles = cmdUsrComando.ExecuteReader
        drNiveles.Read()

        If drNiveles.HasRows Then
            HabilitarEsteMenuItem = drNiveles("Nivel" & Strings.Trim(Str(My.Settings.RSINivelUsuario)))
        Else
            HabilitarEsteMenuItem = False
        End If
        cnSQLConexion.Close()
    End Function
    Public Sub DatosEmpresa()
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdUsrComando As SqlClient.SqlCommand
        Dim drDatosEmp As SqlClient.SqlDataReader
        Dim strCon As String

        Try
            cnSQLConexion = New SqlClient.SqlConnection(My.Settings.RSICNFConnectionString)
            cnSQLConexion.Open()
            cmdUsrComando = cnSQLConexion.CreateCommand
            cmdUsrComando.CommandType = CommandType.Text
            cmdUsrComando.CommandText = "SELECT * FROM DB ORDER BY ID"
            drDatosEmp = cmdUsrComando.ExecuteReader
            drDatosEmp.Read()

            If drDatosEmp.HasRows Then
                My.Settings.RSIEmpresaActual = drDatosEmp("NombreEmpresa")
                fFormaPrin.Text = "RSI Contabilidad - " & drDatosEmp("NombreEmpresa")
                'strCon = "Data Source=" & drDatosEmp("Servidor") & "\" _
                '    & drDatosEmp("Instancia") & ";Initial Catalog=" & drDatosEmp("BaseDatos") & ";Integrated Security=True"
                strCon = "Data Source=" & drDatosEmp("Servidor") & "\" _
                        & drDatosEmp("Instancia") & ";Initial Catalog=" & drDatosEmp("BaseDatos") & ";User ID=sa;Password=rsierp94128"
                'My.Settings.RunTimeRSIConnectionString = strCon
                BaseDatosActual = drDatosEmp("BaseDatos")
            End If
            cnSQLConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Module
