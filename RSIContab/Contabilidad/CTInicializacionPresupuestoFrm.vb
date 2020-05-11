Public Class CTInicializacionPresupuestoFrm
    Dim CTCls As New CTClassLib.CTClass
    Dim RSICadCls As New Rsierpgencl.Rsierpcl.Cadenas
    Dim drCnf As SqlClient.SqlDataReader
    Private Sub butCancelar_Click(sender As Object, e As EventArgs) Handles butCancelar.Click
        Me.Close()
    End Sub

    Private Sub CTInicializacionPresupuestoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CTCls.DBconStr = strcnCAD
        drCnf = CTCls.drConf
        lblAño.Text = drCnf("AñoEnProceso")
    End Sub

    Private Sub butAceptar_Click(sender As Object, e As EventArgs) Handles butAceptar.Click
        Dim strSQL As String
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        If chkboxInicializarTabla.Checked And Not chkboxAgregarCtasNuevas.Checked Then
            EliminarPresupuesto()
        End If

        If radiobutAmbos.Checked Then
            strSQL = "INSERT INTO CTPresupuesto (Año,Cuenta,Tipo) SELECT " & drCnf("AñoEnProceso") & ", Cuenta,Tipo " _
                & "FROM CTCatalogoCuentas WHERE NOT EXISTS (SELECT 1 FROM CTPresupuesto WHERE CTPresupuesto.Cuenta = CTCatalogoCuentas.Cuenta AND CTPresupuesto.Año=" & drCnf("AñoEnProceso") & ") AND " _
                & "(Tipo='I' OR Tipo='G' OR Tipo='T')"
        ElseIf radiobutIngresos.Checked Then
            strSQL = "INSERT INTO CTPresupuesto (Año,Cuenta,Tipo) SELECT " & drCnf("AñoEnProceso") & ", Cuenta,Tipo " _
                & "FROM CTCatalogoCuentas WHERE NOT EXISTS (SELECT 1 FROM CTPresupuesto WHERE CTPresupuesto.Cuenta = CTCatalogoCuentas.Cuenta AND CTPresupuesto.Año=" & drCnf("AñoEnProceso") & ") AND Tipo='I'"
        ElseIf radiobutEgresos.Checked Then
            strSQL = "INSERT INTO CTPresupuesto (Año,Cuenta,Tipo) SELECT " & drCnf("AñoEnProceso") & ", Cuenta,Tipo " _
                & "FROM CTCatalogoCuentas WHERE NOT EXISTS (SELECT 1 FROM CTPresupuesto WHERE CTPresupuesto.Cuenta = CTCatalogoCuentas.Cuenta AND CTPresupuesto.Año=" & drCnf("AñoEnProceso") & ") AND (Tipo='G' OR Tipo='T')"
        End If

        Try
            cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = strSQL
            cmdInComando.ExecuteNonQuery()
            cnSQLConexion.Close()
            MsgBox("Proceso Terminado...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub EliminarPresupuesto()
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "DELETE FROM CTPresupuesto WHERE Año=" & drCnf("AñoEnProceso")
        cmdInComando.ExecuteNonQuery()
        cnSQLConexion.Close()
    End Sub
End Class