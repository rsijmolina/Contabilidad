Imports System.Globalization
Namespace My

    ' Los siguientes eventos están disponibles para MyApplication:
    ' 
    ' Inicio: se desencadena cuando se inicia la aplicación, antes de que se cree el formulario de inicio.
    ' Apagado: generado después de cerrar todos los formularios de la aplicación. Este evento no se genera si la aplicación termina de forma anómala.
    ' UnhandledException: generado si la aplicación detecta una excepción no controlada.
    ' StartupNextInstance: se desencadena cuando se inicia una aplicación de instancia única y la aplicación ya está activa. 
    ' NetworkAvailabilityChanged: se desencadena cuando la conexión de red está conectada o desconectada.

    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            Dim RSISegClGen As New Rsierpgencl.Rsierpcl.EncripDesencrip
            Dim RSISegCl As New Rsierpgencl.Rsierpcl.Encripcion

            '** Configurar Formatos
            FormatoFecha = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern
            FormatoTiempo = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern
            FormatoSeparadorDecimal = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
            FormatoSeparadorMiles = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator
            FormatoSimboloMoneda = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol
            FormatoNumerico = "#" & FormatoSeparadorMiles & "##0" & FormatoSeparadorDecimal & "00"
            FormatoNegativo = "-"
            'Dim mLoginFrm As New LoginForm

            Try
                '*** Revisar si ya existen los datos en el registro del sistema
                If Not IO.File.Exists(Environment.GetEnvironmentVariable("SystemRoot") & "\System32\mmdrv1.dll") Then
                    MsgBox("Error de aplicación -1")
                    Application.Exit()
                Else
                    If String.IsNullOrEmpty(My.Settings.xhspz) Then
                        UtilConexionDBFrm.ShowDialog()
                        If UtilConexionDBFrm.DialogResult = DialogResult.OK Then
                            If Not UtilConexionDBFrm.ConexionCorrecta Then
                                UtilConexionDBFrm.Close()
                                Application.Exit()
                            End If
                        Else
                            UtilConexionDBFrm.Close()
                            Application.Exit()
                        End If
                    End If
                    strcnCAD = "Data Source=" & RSISegClGen.DecryptData(My.Settings.xhspz) & "\" _
                                & RSISegClGen.DecryptData(My.Settings.itfwa) & ";Initial Catalog=RSISistema;User ID=" & RSISegClGen.DecryptData(My.Settings.xupiy) & ";Password=" & RSISegClGen.DecryptData(My.Settings.acvse)
                    If PruebaConexion() = False Then
                        If MsgBox("No se ha podido establece conexión con la base de datos, ¿desea configurarla ahora mismo?") = MsgBoxResult.Yes Then
                            UtilConexionDBFrm.ShowDialog()
                            If UtilConexionDBFrm.DialogResult = DialogResult.OK Then
                                If Not UtilConexionDBFrm.ConexionCorrecta Then
                                    UtilConexionDBFrm.Close()
                                    Application.Exit()
                                End If
                            Else
                                UtilConexionDBFrm.Close()
                                Application.Exit()
                            End If
                        End If
                    End If
                    strcnCAD = "Data Source=" & RSISegClGen.DecryptData(My.Settings.xhspz) & "\" _
                                & RSISegClGen.DecryptData(My.Settings.itfwa) & ";Initial Catalog=tacsosa;User ID=" & RSISegClGen.DecryptData(My.Settings.xupiy) & ";Password=" & RSISegClGen.DecryptData(My.Settings.acvse)
                    crfgXNN = "Data Source=" & RSISegClGen.DecryptData(My.Settings.xhspz) & "\" _
                                & RSISegClGen.DecryptData(My.Settings.itfwa) & ";Initial Catalog=RSICNF;User ID=" & RSISegClGen.DecryptData(My.Settings.xupiy) & ";Password=" & RSISegClGen.DecryptData(My.Settings.acvse)
                    FormatoIntFecha = 103    'dd/mm/aaaa
                    'FormatoIntFecha = 102  ANSI

                    'fFormaPrin.statuslblUsuario.Text = "Usuario: " & My.Settings.RSIUsuarioActual
                    'Application.Run(fFormaPrin)
                    'Procedimientos principales
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            End Try

            '*** Fecha del sistema
            'FechaDelSistema = ServiPosDBLib.ObtenerFechaSistema
            '*** Empresa instalada
            EmpresaInstalada = "RESTAURANTE EL MEJOR"
        End Sub
        Public Function PruebaConexion() As Boolean
            Dim cnSQLConexion As Data.SqlClient.SqlConnection

            PruebaConexion = False
            Try
                cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
                cnSQLConexion.Open()
                If ConnectionState.Open Then
                    PruebaConexion = True
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Finally
                cnSQLConexion.Close()
            End Try
        End Function

        Private Sub [Exit]()
            Throw New NotImplementedException
        End Sub

    End Class


End Namespace

