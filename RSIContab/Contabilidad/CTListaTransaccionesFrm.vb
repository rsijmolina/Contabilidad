Public Class CTListaTransaccionesFrm
    Dim CTCls As New CTClassLib.CTClass
    Dim drCTConf As SqlClient.SqlDataReader
    Private Sub butCancelar_Click(sender As System.Object, e As System.EventArgs) Handles butCancelar.Click
        Me.Close()
    End Sub

    Private Sub CTListaTransaccionesFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CTCls.DBconStr = strcnCAD
        drCTConf = CTCls.drConf

        Me.CTTransaccionesEncabezadoTableAdapter.Connection.ConnectionString = strcnCAD
        Me.CTTransaccionesEncabezadoTableAdapter.Fill(CTListaTransaccionesDataSet.CTTransaccionesEncabezado, drCTConf("AñoEnProceso"), drCTConf("MesEnProceso"))
    End Sub

    Private Sub toolstripbutRefrescarLista_Click(sender As System.Object, e As System.EventArgs) Handles toolstripbutRefrescarLista.Click
        Me.CTTransaccionesEncabezadoTableAdapter.Fill(CTListaTransaccionesDataSet.CTTransaccionesEncabezado, drCTConf("AñoEnProceso"), drCTConf("MesEnProceso"))
    End Sub
End Class