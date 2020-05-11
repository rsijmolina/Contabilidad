Public Class UtilRespaldoBD
    Private _TipoOperacion As String

    Public Property TipoOperacion() As String
        Get
            TipoOperacion = _TipoOperacion
        End Get
        Set(ByVal value As String)
            _TipoOperacion = value
        End Set
    End Property

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnCarpeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarpeta.Click
        If _TipoOperacion = "RESPALDO" Then
            dlgCarpetaRespaldo.ShowDialog()
            txtCarpetaRespaldo.Text = dlgCarpetaRespaldo.SelectedPath
        Else
            dlgArchivoRespaldoBD.ShowDialog()
            txtCarpetaRespaldo.Text = dlgArchivoRespaldoBD.FileName
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        lblProcesando.Visible = True
        lblProcesando.Refresh()
        If _TipoOperacion = "RESPALDO" Then
            RespaldarBD()
        Else
            If MsgBox("Si restaura la base de datos, puede perder los datos ingresados después del último respaldo, ¿desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                RestaurarDB()
            End If
        End If
    End Sub
    Private Sub RespaldarBD()
        Dim cnSQLCon As Data.SqlClient.SqlConnection
        Dim cmdSQL As Data.SqlClient.SqlCommand

        Try
            cnSQLCon = New SqlClient.SqlConnection(strcnCAD)
            cnSQLCon.Open()
            cmdSQL = cnSQLCon.CreateCommand
            cmdSQL.CommandType = CommandType.Text
            cmdSQL.CommandText = "BACKUP DATABASE " & BaseDatosActual & " TO DISK = '" & txtCarpetaRespaldo.Text & "\" & BaseDatosActual & ".bak' WITH FORMAT;"
            cmdSQL.ExecuteNonQuery()
            MsgBox("Proceso terminado...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnSQLCon.Close()
            Me.Close()
        End Try
    End Sub
    Private Sub RestaurarDB()
        Dim cnSQLCon As Data.SqlClient.SqlConnection
        Dim cmdSQL As Data.SqlClient.SqlCommand
        Dim strCon As String

        Try
            strCon = "Data Source=LOCALHOST\RSIERP;Initial Catalog=master;User ID=sa;Password=rsierp94128"
            cnSQLCon = New SqlClient.SqlConnection(strcnCAD)
            cnSQLCon.Open()
            cmdSQL = cnSQLCon.CreateCommand
            cmdSQL.CommandType = CommandType.Text
            cmdSQL.CommandText = "RESTORE DATABASE RSISistema FROM DISK = '" & txtCarpetaRespaldo.Text & "\RSISistema.bak'"
            cmdSQL.ExecuteNonQuery()
            MsgBox("Proceso terminado...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnSQLCon.Close()
            Me.Close()
        End Try

    End Sub
    Private Sub UtilRespaldoBD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _TipoOperacion = "RESTAURAR" Then
            Me.Text = "Restaurar respaldo de Base de Datos"
            lblCarpetaRespaldoRest.Text = "Archivo de respaldo de la Base de Datos:"
        Else
            lblMensaje.Text = "Este proceso hará un respaldo de la base de datos " & BaseDatosActual & " en la carpeta que usted elija. Se creará un archivo con el nombre " & BaseDatosActual & ".bak"
        End If
    End Sub
End Class