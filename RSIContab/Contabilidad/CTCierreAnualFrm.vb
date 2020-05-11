Public Class CTCierreAnualFrm
    Dim CTCls As New CTClassLib.CTClass
    Dim RSICadCls As New Rsierpgencl.Rsierpcl.Cadenas
    Dim CTListaCatFrm As New CtListaCatGenFrm
    Dim drCnf As SqlClient.SqlDataReader
    Private Sub CTCierreAnualFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load        
        CTCls.DBconStr = strcnCAD
        drCnf = CTCls.drConf
        lblAñoIni.Text = drCnf("AñoEnProceso")
        lblMesIni.Text = RSICadCls.MesLetras(drCnf("MesEnProceso"))
        If drCnf("MesDeCierre") = 12 Then
            lblAñoFin.Text = drCnf("AñoEnProceso") + 1
            lblMesFin.Text = "Enero"
        Else
            lblAñoFin.Text = drCnf("AñoEnProceso")
            lblMesFin.Text = RSICadCls.MesLetras(drCnf("MesEnProceso") + 1)
        End If
    End Sub
    Private Sub butBuscarCtaIni_Click(sender As Object, e As EventArgs) Handles butBuscarCtaIni.Click
        CTListaCatFrm.ShowDialog()
        If CTListaCatFrm.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim reg As DataRowView = CTListaCatFrm.ListaCatBindingSource.Current
            txtCuentaIni.Text = reg("Cuenta")
            lblNombreCtaIni.Text = reg("Descripcion")
        End If
    End Sub

    Private Sub butCancelar_Click(sender As Object, e As EventArgs) Handles butCancelar.Click
        Me.Close()
    End Sub
    Private Sub txtCuentaIni_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCuentaIni.Validating
        If txtCuentaIni.Text = "" Then
            Exit Sub
        End If
        lblNombreCtaIni.Text = CTCls.DescripcionCuenta(txtCuentaIni.Text)
        If lblNombreCtaIni.Text = "" Then
            MsgBox("Cuenta no existe", MsgBoxStyle.Information)
        Else
        End If
    End Sub

    Private Sub butAceptar_Click(sender As Object, e As EventArgs) Handles butAceptar.Click
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim strSQL As String
        Dim drCat As SqlClient.SqlDataReader
        Dim intLinea As Int16
        Dim decUtilPerdida As Decimal

        Me.CTSaldosMensualesTableAdapter.Connection.ConnectionString = strcnCAD
        Me.CTPartidasCierreAnualTableAdapter.Connection.ConnectionString = strcnCAD
        strSQL = "SELECT CTCatalogoCuentas.Cuenta,CTCatalogoCuentas.Descripcion,CTCatalogoCuentas.Nivel,CTCatalogoCuentas.Posteable,CTCatalogoCuentas.CuentaSuperior,CTCatalogoCuentas.Naturaleza,CTCatalogoCuentas.Tipo," _
            & "CTSaldosMensuales.SaldoAnterior,CTSaldosMensuales.DebitosMes,CTSaldosMensuales.CreditosMes FROM CTCatalogoCuentas INNER JOIN CTSaldosMensuales ON CTCatalogoCuentas.Cuenta=CTSaldosMensuales.Cuenta " _
            & "WHERE CTSaldosMensuales.Año=" & drCnf("AñoEnProceso") & " AND CTSaldosMensuales.Mes=" & drCnf("MesEnProceso")
        Try
            cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = strSQL
            drCat = cmdInComando.ExecuteReader
            If Not drCat.HasRows Then
                MsgBox("No hay saldos en este año y mes, realice el proceso de mayorización hasta el mes de cierre", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                cnSQLConexion.Close()
                Exit Sub
            End If
            EliminarPartidaCierre(drCnf("AñoEnProceso"))
            'Actualizar la tabla de saldos del año y del mes correspondiente a siguiente despues del cierre
            If drCnf("MesDeCierre") = 12 Then
                InicializarSaldoAnterior(drCnf("AñoEnProceso") + 1, 1)
                CTCls.ActualizarTablaSaldosDeCatalogo(drCnf("AñoEnProceso") + 1, 1)
            Else
                InicializarSaldoAnterior(drCnf("AñoEnProceso"), drCnf("MesEnProceso") + 1)
                CTCls.ActualizarTablaSaldosDeCatalogo(drCnf("AñoEnProceso"), drCnf("MesEnProceso") + 1)
            End If

            If drCnf("MesDeCierre") = 12 Then
                Me.CTSaldosMensualesTableAdapter.FillByAñoMes(Me.CTSaldosMensualesDataSet.CTSaldosMensuales, drCnf("AñoEnProceso") + 1, 1)
            Else
                Me.CTSaldosMensualesTableAdapter.FillByAñoMes(Me.CTSaldosMensualesDataSet.CTSaldosMensuales, drCnf("AñoEnProceso"), drCnf("MesEnProceso") + 1)
            End If

            intLinea = 0
            decUtilPerdida = 0

            Do While drCat.Read
                CTSaldosMensualesBindingSource.Filter = "Cuenta='" & drCat("Cuenta") & "'"
                Dim drSaldosSig As DataRowView = CTSaldosMensualesBindingSource.Current
                If drCat("Cuenta") = drCnf("IndiceIngresos") Then
                    decUtilPerdida = (drCat("SaldoAnterior") - drCat("DebitosMes") + drCat("CreditosMes"))
                End If
                If drCat("Cuenta") = drCnf("IndiceGastos") Then
                    decUtilPerdida = decUtilPerdida - (drCat("SaldoAnterior") + drCat("DebitosMes") - drCat("CreditosMes"))
                End If
                If drCat("Cuenta") = drCnf("IndiceCostos") Then
                    decUtilPerdida = decUtilPerdida - (drCat("SaldoAnterior") + drCat("DebitosMes") - drCat("CreditosMes"))
                End If
                If Strings.Left(drCat("Cuenta"), 1) < drCnf("IndiceIngresos") Then
                    If drCat("Naturaleza") = "D" Then
                        drSaldosSig("SaldoAnterior") = drCat("SaldoAnterior") + drCat("DebitosMes") - drCat("CreditosMes")
                    Else
                        drSaldosSig("SaldoAnterior") = drCat("SaldoAnterior") - drCat("DebitosMes") + drCat("CreditosMes")
                    End If
                Else
                    If drCat("Tipo") <> "O" Then    'Cuentas de orden
                        CTPartidaCierreAnualBindingSource.AddNew()
                        Dim drPart As DataRowView = CTPartidaCierreAnualBindingSource.Current
                        drPart("Año") = drCnf("AñoEnProceso")
                        drPart("Linea") = intLinea
                        drPart("Fecha") = Now.Date
                        drPart("Cuenta") = drCat("Cuenta")
                        drPart("Descripcion") = "Contabilizando Cuentas de Resultado"
                        If drCat("Tipo") = "I" And drCat("Posteable") Then
                            drPart("Debe") = drCat("SaldoAnterior") - drCat("DebitosMes") + drCat("CreditosMes")
                        End If
                        If (drCat("Tipo") = "T" Or drCat("Tipo") = "G") And drCat("Posteable") Then
                            drPart("Haber") = drCat("SaldoAnterior") + drCat("DebitosMes") - drCat("CreditosMes")
                        End If
                        intLinea = intLinea + 1
                        drSaldosSig("SaldoAnterior") = 0
                        CTPartidaCierreAnualBindingSource.EndEdit()
                    End If
                End If
                drSaldosSig("DebitosMes") = 0
                drSaldosSig("CreditosMes") = 0
                CTSaldosMensualesBindingSource.EndEdit()
                CTSaldosMensualesBindingSource.RemoveFilter()
            Loop
            CTPartidaCierreAnualBindingSource.AddNew()
            Dim drPartCap As DataRowView = CTPartidaCierreAnualBindingSource.Current
            drPartCap("Año") = drCnf("AñoEnProceso")
            drPartCap("Linea") = intLinea
            drPartCap("Fecha") = Now.Date
            drPartCap("Cuenta") = Me.txtCuentaIni.Text
            drPartCap("Descripcion") = "Contabilizando Cuentas de Resultado"
            drPartCap("Haber") = decUtilPerdida
            CTPartidaCierreAnualBindingSource.EndEdit()
            Me.CTPartidasCierreAnualTableAdapter.Update(Me.CTPartidasCierresDataSet.CTPartidasCierreAnual)
            Me.CTSaldosMensualesTableAdapter.Update(Me.CTSaldosMensualesDataSet.CTSaldosMensuales)
            cnSQLConexion.Close()
            Repote(drCnf("AñoEnProceso"))
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub EliminarPartidaCierre(intAño As Int16)
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "DELETE FROM CTPartidasCierreAnual WHERE Año=" & intAño
        cmdInComando.ExecuteNonQuery()
        cnSQLConexion.Close()
    End Sub
    Private Sub InicializarSaldoAnterior(intAño As Int16, intMes As Int16)
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "UPDATE CTSaldosMensuales SET SaldoAnterior=0 WHERE Año=" & intAño & " AND Mes=" & intMes
        cmdInComando.ExecuteNonQuery()
        cnSQLConexion.Close()

    End Sub
    Private Sub Repote(intAño As Int16)
        Dim ctRptCls As New RSIRPTCLS.RptCls.CTRpt
        Dim RSISegClGen As New Rsierpgencl.Rsierpcl.EncripDesencrip

        ctRptCls.ServidorRpt = RSISegClGen.DecryptData(My.Settings.xhspz) & "\" & RSISegClGen.DecryptData(My.Settings.itfwa)
        ctRptCls.BaseDatosRpt = BaseDatosActual
        ctRptCls.strPar1 = RSISegClGen.DecryptData(My.Settings.xupiy)
        ctRptCls.strPar2 = RSISegClGen.DecryptData(My.Settings.acvse)
        ctRptCls.TituloEmpresa = My.Settings.RSIEmpresaActual

        ctRptCls.EjecutarPartidaCierre(intAño)
    End Sub
End Class