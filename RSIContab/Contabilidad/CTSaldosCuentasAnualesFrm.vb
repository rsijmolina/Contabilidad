Public Class CTSaldosCuentasAnualesFrm
    Dim ctCls As New CTClassLib.CTClass
    Dim RSICls As New Rsierpgencl.Rsierpcl.Cadenas
    Dim drCnf As SqlClient.SqlDataReader
    Private _TipoInforme As String
    Public Property TipoInforme() As String
        Get
            Return _TipoInforme
        End Get
        Set(ByVal value As String)
            _TipoInforme = value
        End Set
    End Property

    Private Sub CTSaldosCuentasAnualesFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctCls.DBconStr = strcnCAD
        drCnf = ctCls.drConf
        c1numAño.Value = drCnf("AñoEnProceso")
        If TipoInforme = "SALDOS" Then
            Me.Text = "Saldos Mensuales"
            lblMesTrim.Visible = False
            cmbMesesTrim.Visible = False
        Else

            grpboxPeriodo.Top = grpboxSaldos.Top
            grpboxSaldos.Visible = False
            lblMensaje.Top = 72
            butAceptar.Top = 150
            butCancelar.Top = 150
            Me.Height = 170
            Me.Text = "Ejecución del Presupuesto"
            If drCnf("TipoPresupuesto") = "A" Then
                For i As Int16 = 1 To 12
                    cmbMesesTrim.Items.Add(RSICls.MesLetras(i))
                Next
                cmbMesesTrim.Text = "Enero"
            ElseIf drCnf("TipoPresupuesto") = "M" Then
                lblMesTrim.Visible = False
                cmbMesesTrim.Visible = False
            ElseIf drCnf("TipoPresupuesto") = "T" Then
                lblMesTrim.Text = "Trim.:"
                For i As Int16 = 1 To 4
                    cmbMesesTrim.Items.Add("Trimestre " & Trim(Str(i)))
                Next
                cmbMesesTrim.Text = "Trimestre 1"
            End If
        End If
    End Sub
    Private Sub SaldosMensuales()
        Dim strTitEstFinancieros As String = ""
        Dim excel As Microsoft.Office.Interop.Excel.Application
        Dim wb As Microsoft.Office.Interop.Excel.Workbook
        Dim ws As Microsoft.Office.Interop.Excel.Worksheet
        Dim i As Int16 = 0, intLin As Int16 = 5, intCol As Int16
        Dim strSQL As String
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drSaldos As SqlClient.SqlDataReader

        strSQL = "SELECT CTCatalogoCuentas.Cuenta, CTCatalogoCuentas.Descripcion, CTCatalogoCuentas.Nivel, CTCatalogoCuentas.CuentaSuperior, CTCatalogoCuentas.Naturaleza, CTCatalogoCuentas.Tipo,CTCatalogoCuentas.Posteable," _
            & "SaldoMes1, SaldoMes2, SaldoMes3, SaldoMes4, SaldoMes5, SaldoMes6, SaldoMes7, SaldoMes8, SaldoMes9, SaldoMes10, SaldoMes11, SaldoMes12 FROM CTCatalogoCuentas "

        For i = 1 To 12
            strSQL = strSQL & "LEFT JOIN (SELECT CTSaldosMensuales.Cuenta, CASE WHEN CTSaldosMensuales.Naturaleza='D' THEN CTSaldosMensuales.DebitosMes-CTSaldosMensuales.CreditosMes ELSE CTSaldosMensuales.DebitosMes+CTSaldosMensuales.CreditosMes END AS SaldoMes" & Trim(Str(i)) _
                & " FROM CTSaldosMensuales WHERE CTSaldosMensuales.Año=" & c1numAño.Value & " AND CTSaldosMensuales.Mes=" & i & ") AS Saldos" & Trim(Str(i)) & " ON CTCatalogoCuentas.Cuenta=Saldos" & Trim(Str(i)) & ".Cuenta "
        Next
        If radiobutCtasIngresos.Checked Then
            strSQL = strSQL & " WHERE CTCatalogoCuentas.Tipo='I' AND CTCatalogoCuentas.Posteable=1 "
        End If
        If radiobutCtasGastos.Checked = True Then
            strSQL = strSQL & " WHERE CTCatalogoCuentas.Tipo='G' AND CTCatalogoCuentas.Posteable=1 "
        End If
        If radiobutTodas.Checked = True Then
            strSQL = strSQL & " WHERE (CTCatalogoCuentas.Tipo='I' OR CTCatalogoCuentas.Tipo='G') AND CTCatalogoCuentas.Posteable=1 "
        End If
        strSQL = strSQL & " ORDER BY CTCatalogoCuentas.Cuenta"
        Try
            cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = strSQL
            drSaldos = cmdInComando.ExecuteReader
            excel = New Microsoft.Office.Interop.Excel.Application
            wb = excel.Workbooks.Add
            ws = wb.Worksheets(1)
            ws.Cells(1, 1) = My.Settings.RSIEmpresaActual
            ws.Cells(1, 1) = My.Settings.RSIEmpresaActual
            ws.Cells(2, 1) = "Saldos de Cuentas del Año " & c1numAño.Value
            ws.Cells(3, 1) = "Cuenta"
            ws.Cells(3, 2) = "Descripción"
            intCol = 3
            For i = 1 To 12
                ws.Cells(3, intCol) = RSICls.MesLetras(i)
                intCol = intCol + 1
            Next
            intLin = 4
            While drSaldos.Read
                ws.Cells(intLin, 1).NumberFormat = "@"
                ws.Cells(intLin, 1) = drSaldos("Cuenta")
                ws.Cells(intLin, 2) = drSaldos("Descripcion")
                intCol = 3
                For i = 1 To 12
                    If IsDBNull(drSaldos("SaldoMes" & Trim(Str(i)))) Then
                        ws.Cells(intLin, intCol) = 0
                    Else
                        ws.Cells(intLin, intCol) = drSaldos("SaldoMes" & Trim(Str(i)))
                    End If
                    intCol = intCol + 1
                Next
                intLin = intLin + 1
            End While
            cnSQLConexion.Close()
            excel.Visible = True
            wb.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub Ejecucion()
        Dim strTitEstFinancieros As String = ""
        Dim excel As Microsoft.Office.Interop.Excel.Application
        Dim wb As Microsoft.Office.Interop.Excel.Workbook
        Dim ws As Microsoft.Office.Interop.Excel.Worksheet
        Dim i As Int16 = 0, intLin As Int16 = 5, intCol As Int16
        Dim strSQL As String
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drSaldos As SqlClient.SqlDataReader

        strSQL = "SELECT CTCatalogoCuentas.Cuenta, CTCatalogoCuentas.Descripcion, CTCatalogoCuentas.Nivel, CTCatalogoCuentas.CuentaSuperior, CTCatalogoCuentas.Naturaleza, CTCatalogoCuentas.Tipo,CTCatalogoCuentas.Posteable," _
            & "SaldoMes1, SaldoMes2, SaldoMes3, SaldoMes4, SaldoMes5, SaldoMes6, SaldoMes7, SaldoMes8, SaldoMes9, SaldoMes10, SaldoMes11, SaldoMes12,"
        For i = 1 To 12
            strSQL = strSQL & "CTPresupuesto.Mes" & Trim(Str(i)) & IIf(i = 12, " ", ",")
        Next
        strSQL = strSQL & "FROM CTCatalogoCuentas "
        For i = 1 To 12
            strSQL = strSQL & "LEFT JOIN (SELECT CTSaldosMensuales.Cuenta, CASE WHEN CTSaldosMensuales.Naturaleza='D' THEN CTSaldosMensuales.DebitosMes-CTSaldosMensuales.CreditosMes ELSE CTSaldosMensuales.DebitosMes+CTSaldosMensuales.CreditosMes END AS SaldoMes" & Trim(Str(i)) _
                & " FROM CTSaldosMensuales WHERE CTSaldosMensuales.Año=" & c1numAño.Value & " AND CTSaldosMensuales.Mes=" & i & ") AS Saldos" & Trim(Str(i)) & " ON CTCatalogoCuentas.Cuenta=Saldos" & Trim(Str(i)) & ".Cuenta "
        Next
        strSQL = strSQL & "INNER JOIN CTPresupuesto ON CTCatalogoCuentas.Cuenta=CTPresupuesto.Cuenta WHERE CTPresupuesto.Año=" & c1numAño.Value & " ORDER BY CTCatalogoCuentas.Cuenta"
        Try
            cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = strSQL
            drSaldos = cmdInComando.ExecuteReader
            excel = New Microsoft.Office.Interop.Excel.Application
            wb = excel.Workbooks.Add
            ws = wb.Worksheets(1)
            ws.Cells(1, 1) = My.Settings.RSIEmpresaActual
            ws.Cells(1, 1) = My.Settings.RSIEmpresaActual
            ws.Cells(2, 1) = "Saldos de Cuentas del Año " & c1numAño.Value
            ws.Cells(3, 1) = "Cuenta"
            ws.Cells(3, 2) = "Descripción"
            intCol = 3
            For i = 1 To 12
                ws.Cells(3, intCol) = RSICls.MesLetras(i)
                intCol = intCol + 2
            Next
            intCol = 3
            For i = 1 To 12
                ws.Cells(4, intCol) = "Presupuestado"
                ws.Cells(4, intCol + 1) = "Ejecutado"
                intCol = intCol + 2
            Next
            intLin = 5
            While drSaldos.Read
                ws.Cells(intLin, 1).NumberFormat = "@"
                ws.Cells(intLin, 1) = drSaldos("Cuenta")
                ws.Cells(intLin, 2) = drSaldos("Descripcion")
                intCol = 3
                For i = 1 To 12
                    ws.Cells(intLin, intCol) = drSaldos("Mes" & Trim(Str(i)))
                    If IsDBNull(drSaldos("SaldoMes" & Trim(Str(i)))) Then
                        ws.Cells(intLin, intCol + 1) = 0
                    Else
                        ws.Cells(intLin, intCol + 1) = drSaldos("SaldoMes" & Trim(Str(i)))
                    End If
                    intCol = intCol + 2
                Next
                intLin = intLin + 1
            End While
            cnSQLConexion.Close()
            excel.Visible = True
            wb.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try

    End Sub
    Private Sub butCancelar_Click(sender As Object, e As EventArgs) Handles butCancelar.Click
        Me.Close()
    End Sub

    Private Sub butAceptar_Click(sender As Object, e As EventArgs) Handles butAceptar.Click
        lblMensaje.Visible = True
        lblMensaje.Refresh()
        If TipoInforme = "SALDOS" Then
            SaldosMensuales()
        Else
            If drCnf("TipoPresupuesto") = "A" Then
                EjecAnual()
            ElseIf drCnf("TipoPresupuesto") = "M" Then
                Ejecucion()
            ElseIf drCnf("TipoPresupuesto") = "T" Then
            End If
        End If
        lblMensaje.Visible = False
    End Sub
    Private Sub EjecAnual()
        Dim ctRptCls As New RSIRPTCLS.RptCls.CTRpt
        Dim RSISegClGen As New Rsierpgencl.Rsierpcl.EncripDesencrip

        ctRptCls.Filtro = "{CTPresupuesto.Año}=" & c1numAño.Value & " AND {CTSaldosMensuales.Año}=" & c1numAño.Value & " AND {CTSaldosMensuales.Mes}=" & RSICls.NumMes(cmbMesesTrim.Text) & " AND {CTCatalogoCuentas.Posteable}"
        ctRptCls.ServidorRpt = RSISegClGen.DecryptData(My.Settings.xhspz) & "\" & RSISegClGen.DecryptData(My.Settings.itfwa)
        ctRptCls.BaseDatosRpt = BaseDatosActual
        ctRptCls.strPar1 = RSISegClGen.DecryptData(My.Settings.xupiy)
        ctRptCls.strPar2 = RSISegClGen.DecryptData(My.Settings.acvse)
        ctRptCls.TituloEmpresa = My.Settings.RSIEmpresaActual
        ctRptCls.Titulo = "Del mes de " & cmbMesesTrim.Text & " de " & c1numAño.Text
        ctRptCls.EjecutarReportesPresup("CTPresupEjecucionAnualRpt")

    End Sub
End Class