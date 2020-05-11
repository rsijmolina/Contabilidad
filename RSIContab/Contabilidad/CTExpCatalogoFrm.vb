Imports System
Imports System.IO
Public Class CTExpCatalogoFrm

    Private Sub butCancelar_Click(sender As Object, e As EventArgs) Handles butCancelar.Click
        Me.Close()
    End Sub

    Private Sub butBuscarCtaIni_Click(sender As Object, e As EventArgs) Handles butBuscarCtaIni.Click
        If SaveFileDlgArchivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtNombreArchivo.Text = SaveFileDlgArchivo.FileName & ".txt"
        End If
    End Sub

    Private Sub butAceptar_Click(sender As Object, e As EventArgs) Handles butAceptar.Click
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdComando As SqlClient.SqlCommand
        Dim drCat As SqlClient.SqlDataReader
        Dim strCadena As String
        Dim RSIcadcl As New Rsierpgencl.Rsierpcl.Cadenas

        Try
            cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
            cnSQLConexion.Open()
            cmdComando = cnSQLConexion.CreateCommand
            cmdComando.CommandType = CommandType.Text
            cmdComando.CommandText = "SELECT * FROM CTCatalogoCuentas"
            drCat = cmdComando.ExecuteReader
            Dim sw As StreamWriter = New StreamWriter(txtNombreArchivo.Text)
            Do While drCat.Read
                strCadena = ""
                strCadena = strCadena & RSIcadcl.RellenarDer(drCat("Cuenta"), 30, " ")
                strCadena = strCadena & RSIcadcl.RellenarDer(drCat("Descripcion"), 100, " ")
                strCadena = strCadena & Trim(Str(drCat("Nivel")))
                strCadena = strCadena & IIf(drCat("Posteable"), "S", "N")
                If IsDBNull(drCat("CuentaSuperior")) Then
                    strCadena = strCadena & RSIcadcl.Replicar(" ", 30)
                Else
                    strCadena = strCadena & RSIcadcl.RellenarDer(drCat("CuentaSuperior"), 30, " ")
                End If
                strCadena = strCadena & drCat("Naturaleza")
                strCadena = strCadena & drCat("Tipo")
                If IsDBNull(drCat("Ambito")) Then
                    strCadena = strCadena & " "
                Else
                    strCadena = strCadena & drCat("Ambito")
                End If
                If IsDBNull(drCat("CentroCosto")) Then
                    strCadena = strCadena & RSIcadcl.Replicar(" ", 30)
                Else
                    strCadena = strCadena & RSIcadcl.RellenarDer(drCat("CentroCosto"), 30, " ")
                End If
                sw.WriteLine(strCadena)
            Loop
            sw.Close()
            cnSQLConexion.Close()
            MsgBox("Proceso terminado...", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class