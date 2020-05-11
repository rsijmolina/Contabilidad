Public Class CTRepCatalogoFrm
    Dim ctCLS As New CTClassLib.CTClass
    Private Sub CTRepCatalogoFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ctCLS.DBconStr = strcnCAD        
        txtCuentaIni.Text = ctCLS.ObtenerPrimeraUltimaCuenta(True)
        txtCuentaFin.Text = ctCLS.ObtenerPrimeraUltimaCuenta(False)
        c1dateFecha.Value = Date.Now
    End Sub
    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Dim ctRptCls As New RSIRPTCLS.RptCls.CTRpt
        Dim RSISegClGen As New Rsierpgencl.Rsierpcl.EncripDesencrip

        ctRptCls.Filtro = "{CTCatalogoCuentas.Cuenta}>='" & txtCuentaIni.Text & "' AND {CTCatalogoCuentas.Cuenta}<='" & txtCuentaFin.Text & "'"
        ctRptCls.ServidorRpt = RSISegClGen.DecryptData(My.Settings.xhspz) & "\" & RSISegClGen.DecryptData(My.Settings.itfwa)
        ctRptCls.BaseDatosRpt = BaseDatosActual
        ctRptCls.strPar1 = RSISegClGen.DecryptData(My.Settings.xupiy)
        ctRptCls.strPar2 = RSISegClGen.DecryptData(My.Settings.acvse)
        ctRptCls.TituloEmpresa = My.Settings.RSIEmpresaActual
        ctRptCls.FechaReporte = c1dateFecha.Text

        ctRptCls.EjecutarListados("CATALOGO")
    End Sub
End Class