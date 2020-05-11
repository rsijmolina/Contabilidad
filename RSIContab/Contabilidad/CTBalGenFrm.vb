Public Class CTBalGenFrm
    'Dim CTCls As New CTClassLib.CTClass
    Dim CTEstFinCls As New CTClassLib.CTClass.CTEstadosFinancieros
    Dim RSICadenas As New Rsierpgencl.Rsierpcl.Cadenas
    Dim drCnf As SqlClient.SqlDataReader
    Dim BalGenDataSet As New CTEstFinanDataSet
    Private Sub CTBalGenFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CTEstFinCls.DBconStr = strcnCAD
        drCnf = CTEstFinCls.drConf
        c1dateFecha.Value = Date.Now
        numupdnActivo.Value = drCnf("NivelActivoRepBalGen")
        numupdnPasivo.Value = drCnf("NivelPasivoRepBalGen")
        numupdnCapital.Value = drCnf("NivelCapitalRepBalGen")
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        BalGenDataSet.Clear()   'Borrar cualquier dato
        CTEstFinCls.strTipoEstado = "BG"    'Balance General
        CTEstFinCls.boEstFinanAños = False
        If radiobutSaldosAnuales.Checked Then
            CTEstFinCls.strAnualMensual = "A"
        Else
            CTEstFinCls.strAnualMensual = "M"
        End If
        If chkboxCompAñoAnt.Checked Then
            CTEstFinCls.intAñoComp = c1numCompararAnio.Value
        Else
            CTEstFinCls.intAñoComp = 0
        End If
        CTEstFinCls.boSuprimirCeros = chkboxSuprimirSaldosCeros.Checked
        CTEstFinCls.CTEstFDataSet = BalGenDataSet
        CTEstFinCls.intNivelMax1 = numupdnActivo.Value
        CTEstFinCls.intNivelMax2 = numupdnPasivo.Value
        CTEstFinCls.intNivelMax3 = numupdnCapital.Value
        CTEstFinCls.drCTCnf = drCnf
        CTEstFinCls.GenerarEstadosFinancieros()
        CTTmpFrm.DataGridView1.DataSource = BalGenDataSet.Tables("CTEstFinanDataTable")
        CTTmpFrm.ShowDialog()
        CTTmpFrm.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class