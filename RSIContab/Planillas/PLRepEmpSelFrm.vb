Public Class PLRepEmpSelFrm
    Dim PlCls As New PLClassLib.PlClass
    Dim drConfPlani As SqlClient.SqlDataReader
    Dim drDefDed As SqlClient.SqlDataReader
    Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
    Dim RSICls As New Rsierpgencl.Rsierpcl.Cadenas

    Private Sub PLRepEmpSelFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        c1dateFecha.Value = Date.Now
        PlCls.DBconStr = strcnCAD
        drConfPlani = PlCls.drConf
        cmbMeses.Text = RSICls.MesLetras(drConfPlani("MesEnProceso"))
        rptClass.BaseDatosRpt = BaseDatosActual
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub radiobutCargo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radiobutCargo.CheckedChanged

    End Sub

    Private Sub radiobutCargo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radiobutCargo.Click
        grpRangos.Visible = True
        grpGenero.Enabled = True
        lblSueldo.Visible = False
        cmbSignos.Visible = True
        c1numSueldoMensual.Visible = False
    End Sub
End Class