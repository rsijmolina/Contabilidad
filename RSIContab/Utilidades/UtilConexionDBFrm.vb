Public Class UtilConexionDBFrm
    Private _ConexionCorrecta As Boolean
    Dim RSISegClGen As New Rsierpgencl.Rsierpcl.EncripDesencrip
    Public Property ConexionCorrecta() As Boolean
        Get
            ConexionCorrecta = _ConexionCorrecta
        End Get
        Set(value As Boolean)
            _ConexionCorrecta = value
        End Set
    End Property
    Dim RSIGenCl As New Rsierpgencl.Rsierpcl.EncripDesencrip
    Private Sub butCancelar_Click(sender As Object, e As EventArgs) Handles butCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnPruebaConexion_Click(sender As Object, e As EventArgs) Handles btnPruebaConexion.Click
        Dim cnSQLConexion As Data.SqlClient.SqlConnection


        Dim strCon As String = "Data Source=" & txtServidor.Text & "\" _
        & txtInstancia.Text & ";Initial Catalog=master;User ID=" & txtUsuario.Text & ";Password=" & txtClave.Text

        Try
            cnSQLConexion = New SqlClient.SqlConnection(strCon)
            cnSQLConexion.Open()
            If ConnectionState.Open Then
                MsgBox("Conexión realizada satisfactoriamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                ConexionCorrecta = True
            Else
                MsgBox("No se pudo lograr la conexión", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        Finally
            cnSQLConexion.Close()
        End Try
    End Sub

    Private Sub butAceptar_Click(sender As Object, e As EventArgs) Handles butAceptar.Click

        If ConexionCorrecta Then
            My.Settings.xhspz = RSIGenCl.EncryptData(txtServidor.Text) 'Servidor
            My.Settings.itfwa = RSIGenCl.EncryptData(txtInstancia.Text)   'Instancia
            My.Settings.xupiy = RSIGenCl.EncryptData(txtUsuario.Text)  'Usuario
            My.Settings.acvse = RSIGenCl.EncryptData(txtClave.Text)    'Clave
            My.Settings.Save()
            Me.Close()
        Else
            MsgBox("Debe probar la conexión antes de guardar la información", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub UtilConexionDBFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConexionCorrecta = False
        If My.Settings.xhspz = "" Then
            txtInstancia.Text = "SQLEXPRESS"
            txtUsuario.Text = "sa"
            txtClave.Text = "rsierp94128"
        Else
            txtServidor.Text = RSIGenCl.DecryptData(My.Settings.xhspz)
            txtInstancia.Text = RSIGenCl.DecryptData(My.Settings.itfwa)
            txtUsuario.Text = RSIGenCl.DecryptData(My.Settings.xupiy)
            txtClave.Text = RSIGenCl.DecryptData(My.Settings.acvse)
        End If
    End Sub
    Public Sub CrearDbConf()

    End Sub

End Class