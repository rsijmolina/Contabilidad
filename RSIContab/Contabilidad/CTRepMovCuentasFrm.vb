Public Class CTRepMovCuentasFrm
    Dim CTCls As New CTClassLib.CTClass
    Dim RSICadCls As New Rsierpgencl.Rsierpcl.Cadenas
    Dim CTListaCatFrm As New CtListaCatGenFrm
    Dim drCnf As SqlClient.SqlDataReader

    Private Sub CTRepMovCuentasFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        drCnf.Close()
        CTListaCatFrm.Close()
    End Sub
    Private Sub CTRepMovCuentasFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load        
        Me.CTSaldosIniTableAdapter.Connection.ConnectionString = strcnCAD
        CTCls.DBconStr = strcnCAD
        drCnf = CTCls.drConf
        c1numAñoIni.Value = drCnf("AñoEnProceso")
        c1numAñoFin.Value = drCnf("AñoEnProceso")
        For i As Int16 = 1 To 12
            cmbMesIni.Items.Add(RSICadCls.MesLetras(i))
            cmbMesFin.Items.Add(RSICadCls.MesLetras(i))
        Next
        cmbMesIni.SelectedIndex = drCnf("MesEnProceso") - 1
        cmbMesFin.SelectedIndex = drCnf("MesEnProceso") - 1
        c1dateFecha.Value = Now

    End Sub

    Private Sub butBuscarCtaIni_Click(sender As Object, e As EventArgs) Handles butBuscarCtaIni.Click
        CTListaCatFrm.ShowDialog()
        If CTListaCatFrm.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim reg As DataRowView = CTListaCatFrm.ListaCatBindingSource.Current
            txtCuentaIni.Text = reg("Cuenta")
            lblNombreCtaIni.Text = reg("Descripcion")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CTListaCatFrm.ShowDialog()
        If CTListaCatFrm.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim reg As DataRowView = CTListaCatFrm.ListaCatBindingSource.Current
            txtCuentaFin.Text = reg("Cuenta")
            lblNombreCtaFin.Text = reg("Descripcion")
        End If
    End Sub

    Private Sub butAceptar_Click(sender As Object, e As EventArgs) Handles butAceptar.Click
        Dim ctRptCls As New RSIRPTCLS.RptCls.CTRpt
        Dim RSISegClGen As New Rsierpgencl.Rsierpcl.EncripDesencrip

        If txtCuentaIni.Text > txtCuentaFin.Text Then
            MsgBox("La cuenta inicial no debe ser mayor que la cuenta final", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If c1numAñoIni.Value > c1numAñoFin.Value Then
            MsgBox("El año inicial no debe ser mayor que el año final", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If c1numAñoIni.Value = c1numAñoFin.Value Then
            If RSICadCls.NumMes(cmbMesIni.Text) > RSICadCls.NumMes(cmbMesFin.Text) Then
                MsgBox("El mes inicial no debe ser mayor que el mes final", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If
        CTCls.EliminarSaldosIni()
        AgregarSaldosIniciales()
        'ctRptCls.Filtro = "({CTTransaccionesDetalle.Año}>=" & c1numAñoIni.Value & " AND {CTTransaccionesDetalle.Mes}>=" & RSICadCls.NumMes(cmbMesIni.Text) & ") AND ({CTTransaccionesDetalle.Año}<=" & c1numAñoFin.Value _
        '    & " AND {CTTransaccionesDetalle.Mes}<=" & RSICadCls.NumMes(cmbMesFin.Text) & ") AND  ({CTTransaccionesDetalle.Cuenta}>='" & txtCuentaIni.Text & "' AND {CTTransaccionesDetalle.Cuenta}<='" & txtCuentaFin.Text & "')"
        ctRptCls.Filtro = "({CTTransaccionesEncabezado.Fecha}>=DATE(" & c1numAñoIni.Value & "," & RSICadCls.NumMes(cmbMesIni.Text) & ",1) AND {CTTransaccionesEncabezado.Fecha}<=DATE(" & c1numAñoFin.Value & "," & RSICadCls.NumMes(cmbMesFin.Text) _
            & "," & RSICadCls.UltimoDiaMes(RSICadCls.NumMes(cmbMesFin.Text), c1numAñoFin.Value) & ") AND  {CTTransaccionesDetalle.Cuenta}>='" & txtCuentaIni.Text & "' AND {CTTransaccionesDetalle.Cuenta}<='" & txtCuentaFin.Text & "')"
        ctRptCls.ServidorRpt = RSISegClGen.DecryptData(My.Settings.xhspz) & "\" & RSISegClGen.DecryptData(My.Settings.itfwa)
        ctRptCls.BaseDatosRpt = BaseDatosActual
        ctRptCls.strPar1 = RSISegClGen.DecryptData(My.Settings.xupiy)
        ctRptCls.strPar2 = RSISegClGen.DecryptData(My.Settings.acvse)
        ctRptCls.TituloEmpresa = My.Settings.RSIEmpresaActual
        ctRptCls.FechaReporte = c1dateFecha.Value
        ctRptCls.Titulo = "Periodo: " & cmbMesIni.Text & " de " & c1numAñoIni.Value & " a " & cmbMesFin.Text & " de " & c1numAñoFin.Value

        If chkboxImpBeneficiario.Checked Then
            ctRptCls.EjecutarMovCuentas("DET", chkboxImpConcepto.Checked)
        Else
            ctRptCls.EjecutarMovCuentas("GEN", chkboxImpConcepto.Checked)
        End If
    End Sub
    Private Sub AgregarSaldosIniciales()
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drSaldos As SqlClient.SqlDataReader

        Try
            cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = "SELECT * FROM CTSaldosMensuales WHERE Año=" & c1numAñoIni.Value & " AND Mes=" & RSICadCls.NumMes(cmbMesIni.Text) & " AND Cuenta>='" & txtCuentaIni.Text & "' AND Cuenta<='" & txtCuentaFin.Text & "'"
            drSaldos = cmdInComando.ExecuteReader
            While drSaldos.Read
                Me.CTSaldosIniBindingSource.AddNew()
                Dim reg As DataRowView = Me.CTSaldosIniBindingSource.Current
                reg("Cuenta") = drSaldos("Cuenta")
                reg("Saldo") = drSaldos("SaldoAnterior")
            End While
            cnSQLConexion.Close()
            Me.CTSaldosIniBindingSource.EndEdit()
            Me.CTSaldosIniTableAdapter.Update(Me.CTSaldosIniDataSet)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub butCancelar_Click(sender As Object, e As EventArgs) Handles butCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtCuentaIni_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCuentaIni.Validating
        lblNombreCtaIni.Text = CTCls.DescripcionCuenta(txtCuentaIni.Text)
        If lblNombreCtaIni.Text = "" Then
            MsgBox("Cuenta no existe", MsgBoxStyle.Information)
        Else
        End If
    End Sub

    Private Sub txtCuentaFin_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCuentaFin.Validating
        lblNombreCtaFin.Text = CTCls.DescripcionCuenta(txtCuentaFin.Text)
        If lblNombreCtaFin.Text = "" Then
            MsgBox("Cuenta no existe", MsgBoxStyle.Information)
        Else
        End If
    End Sub
End Class