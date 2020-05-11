Public Class PLRepOtrasDedFrm
    Dim PlCls As New PLClassLib.PlClass
    Dim drConfPlani As SqlClient.SqlDataReader
    Dim drDefDed As SqlClient.SqlDataReader
    Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
    Dim RSICls As New Rsierpgencl.Rsierpcl.Cadenas
    Dim colDedFuentes As New Collection, colDedDestinos As New Collection

    Private Sub PLRepOtrasDedFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        c1dateFecha.Value = Date.Now
        PlCls.DBconStr = strcnCAD
        drConfPlani = PlCls.drConf
        drDefDed = PlCls.drDefDeducciones("")
        rptClass.BaseDatosRpt = BaseDatosActual

        lstboxFuente.Items.Clear()
        lstboxDestino.Items.Clear()
        While drDefDed.Read
            lstboxFuente.Items.Add(drDefDed("DescripcionDeduccion"))
            colDedFuentes.Add(drDefDed("CodigoDeduccion"))
        End While
        drDefDed.Close()
    End Sub

    Private Sub butAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAgregar.Click
        lstboxDestino.Items.Add(lstboxFuente.SelectedItem)
        colDedDestinos.Add(colDedFuentes.Item(lstboxFuente.SelectedIndex + 1))

        colDedFuentes.Remove(lstboxFuente.SelectedIndex + 1)
        lstboxFuente.Items.Remove(lstboxFuente.SelectedItem)
        If lstboxFuente.Items.Count > 0 Then
            lstboxFuente.SelectedIndex = 0
        End If
    End Sub

    Private Sub radiobutQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radiobutQuitar.Click
        colDedFuentes.Add(lstboxDestino.SelectedItem)
        lstboxFuente.Items.Add(colDedDestinos.Item(lstboxDestino.SelectedIndex + 1))

        colDedDestinos.Remove(lstboxDestino.SelectedIndex + 1)
        lstboxDestino.Items.Remove(lstboxDestino.SelectedItem)
    End Sub

    Private Sub c1numNoPlanilla_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numNoPlanilla.Validating
        lblDescPlanilla.Text = PlCls.DescripcionPlanilla(c1numNoPlanilla.Value)
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        PLProcDeduccionesFrm.Año = drConfPlani("AñoEnProceso")
        PLProcDeduccionesFrm.Mes = drConfPlani("MesEnProceso")
        PLProcDeduccionesFrm.NoPlanilla = drConfPlani("NoPlanilla")
        PLProcDeduccionesFrm.colDefDeds = colDedDestinos
        PLProcDeduccionesFrm.Procesar("OTRASDED")
        If radiobutReporteGen.Checked Then
            ReporteEgresos()
        ElseIf radiobutExportarExcel.Checked Then
            ExportarExcel()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub ReporteEgresos()
        Dim strSel As String, strTit1 As String, strTit2 As String, strTit3 As String, strTit4 As String, strTit5 As String, strTit6 As String, strTit7 As String
        Dim strTit8 As String, strTit9 As String, strTit10 As String, strTit11 As String, strTit12 As String, strTit13 As String, strTit14 As String, strTit15 As String
        Dim i As Int16

        drDefDed = PlCls.drDefDeducciones("")
        strSel = "{PLPLanillas.Año}=" & drConfPlani("AñoEnProceso") & " AND {PLPLanillas.Mes}=" & drConfPlani("MesEnProceso") & " AND {PLPLanillas.NoPlanilla}=" & c1numNoPlanilla.Value

        strTit1 = "" : strTit2 = "" : strTit3 = "" : strTit4 = "" : strTit5 = "" : strTit6 = "" : strTit7 = "" : strTit8 = "" : strTit9 = "" : strTit10 = "" : strTit11 = "" : strTit12 = "" : strTit13 = "" : strTit14 = "" : strTit15 = ""


        While drDefDed.Read
            For i = 1 To colDedDestinos.Count
                If drDefDed("CodigoDeduccion") = colDedDestinos(i) Then
                    Select Case i
                        Case 1
                            strTit1 = drDefDed("RepTituloColumna")
                        Case 2
                            strTit2 = drDefDed("RepTituloColumna")
                        Case 3
                            strTit3 = drDefDed("RepTituloColumna")
                        Case 4
                            strTit4 = drDefDed("RepTituloColumna")
                        Case 5
                            strTit5 = drDefDed("RepTituloColumna")
                        Case 6
                            strTit6 = drDefDed("RepTituloColumna")
                        Case 7
                            strTit7 = drDefDed("RepTituloColumna")
                        Case 8
                            strTit8 = drDefDed("RepTituloColumna")
                        Case 9
                            strTit9 = drDefDed("RepTituloColumna")
                        Case 10
                            strTit10 = drDefDed("RepTituloColumna")
                        Case 11
                            strTit11 = drDefDed("RepTituloColumna")
                        Case 12
                            strTit12 = drDefDed("RepTituloColumna")
                        Case 13
                            strTit13 = drDefDed("RepTituloColumna")
                        Case 14
                            strTit14 = drDefDed("RepTituloColumna")
                        Case 15
                            strTit15 = drDefDed("RepTituloColumna")
                    End Select
                End If
            Next
        End While
        drDefDed.Close()

        rptClass.EjecutarReportePlanillaEgresos(strcnCAD, My.Settings.RSIEmpresaActual, "PLDeducciones3Rpt", strSel, lblDescPlanilla.Text, c1dateFecha.Value, _
                                                strTit1, strTit2, strTit3, strTit4, strTit5, strTit6, strTit7, strTit8, strTit9, strTit10, strTit11, strTit12, strTit13, strTit14, strTit15, colDedDestinos.Count)
    End Sub

    Private Sub ExportarExcel()
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drOtrasDed As SqlClient.SqlDataReader
        Dim i As Integer, intLinea As Integer, intCol As Integer, intTotEmpleados As Integer, intTotDeduc As Int16
        Dim strSQL As String
        Dim excel As Microsoft.Office.Interop.Excel.Application
        Dim wb As Microsoft.Office.Interop.Excel.Workbook
        Dim ws As Microsoft.Office.Interop.Excel.Worksheet

        Try
            excel = New Microsoft.Office.Interop.Excel.Application
            wb = excel.Workbooks.Add
            ws = wb.Worksheets(1)

            intTotDeduc = 0
            drDefDed = PlCls.drDefDeducciones("")
            ws.Cells(1, 1) = My.Settings.RSIEmpresaActual
            ws.Cells(2, 1) = lblDescPlanilla.Text
            ws.Cells(3, 1) = "No"
            ws.Cells(3, 2) = "Código"
            ws.Cells(3, 3) = "Nombre"
            While drDefDed.Read
                intTotDeduc = intTotDeduc + 1
                For i = 1 To colDedDestinos.Count
                    If drDefDed("CodigoDeduccion") = colDedDestinos(i) Then
                        Select Case i
                            Case 1
                                ws.Cells(3, 4) = drDefDed("RepTituloColumna")
                            Case 2
                                ws.Cells(3, 5) = drDefDed("RepTituloColumna")
                            Case 3
                                ws.Cells(3, 6) = drDefDed("RepTituloColumna")
                            Case 4
                                ws.Cells(3, 7) = drDefDed("RepTituloColumna")
                            Case 5
                                ws.Cells(3, 8) = drDefDed("RepTituloColumna")
                            Case 6
                                ws.Cells(3, 9) = drDefDed("RepTituloColumna")
                            Case 7
                                ws.Cells(3, 10) = drDefDed("RepTituloColumna")
                            Case 8
                                ws.Cells(3, 11) = drDefDed("RepTituloColumna")
                            Case 9
                                ws.Cells(3, 12) = drDefDed("RepTituloColumna")
                            Case 10
                                ws.Cells(3, 13) = drDefDed("RepTituloColumna")
                            Case 11
                                ws.Cells(3, 14) = drDefDed("RepTituloColumna")
                            Case 12
                                ws.Cells(3, 15) = drDefDed("RepTituloColumna")
                            Case 13
                                ws.Cells(3, 16) = drDefDed("RepTituloColumna")
                            Case 14
                                ws.Cells(3, 17) = drDefDed("RepTituloColumna")
                            Case 15
                                ws.Cells(3, 18) = drDefDed("RepTituloColumna")
                            Case 16
                                ws.Cells(3, 19) = drDefDed("RepTituloColumna")
                            Case 17
                                ws.Cells(3, 20) = drDefDed("RepTituloColumna")
                            Case 18
                                ws.Cells(3, 21) = drDefDed("RepTituloColumna")
                            Case 19
                                ws.Cells(3, 22) = drDefDed("RepTituloColumna")
                            Case 20
                                ws.Cells(3, 23) = drDefDed("RepTituloColumna")
                            Case 21
                                ws.Cells(3, 24) = drDefDed("RepTituloColumna")
                            Case 22
                                ws.Cells(3, 25) = drDefDed("RepTituloColumna")
                            Case 23
                                ws.Cells(3, 26) = drDefDed("RepTituloColumna")
                            Case 24
                                ws.Cells(3, 27) = drDefDed("RepTituloColumna")
                            Case 25
                                ws.Cells(3, 28) = drDefDed("RepTituloColumna")
                            Case 26
                                ws.Cells(3, 29) = drDefDed("RepTituloColumna")
                            Case 27
                                ws.Cells(3, 30) = drDefDed("RepTituloColumna")
                            Case 28
                                ws.Cells(3, 31) = drDefDed("RepTituloColumna")
                            Case 29
                                ws.Cells(3, 32) = drDefDed("RepTituloColumna")
                            Case 30
                                ws.Cells(3, 33) = drDefDed("RepTituloColumna")
                        End Select
                    End If
                Next
            End While
            drDefDed.Close()

            strSQL = "SELECT TOP (100) PERCENT PLDeduccionesDet.*, PLEmpleados.Nombre1, PLEmpleados.Nombre2, PLEmpleados.Apellido1, " _
                & "PLEmpleados.Apellido2, PLEmpleados.Identificacion1 FROM PLDeduccionesDet INNER JOIN " _
                & "PLEmpleados ON PLDeduccionesDet.CodigoEmpleado = PLEmpleados.CodigoEmpleado " _
                & "ORDER BY PLEmpleados.Nombre1, PLEmpleados.Nombre2, PLEmpleados.Apellido1, PLEmpleados.Apellido2"
            cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = strSQL
            drOtrasDed = cmdInComando.ExecuteReader

            intLinea = 4
            intCol = 1
            intTotEmpleados = 1
            While drOtrasDed.Read
                ws.Cells(intLinea, 1) = intTotEmpleados
                ws.Cells(intLinea, 2) = drOtrasDed("CodigoEmpleado")
                ws.Cells(intLinea, 3) = drOtrasDed("Nombre1") & " " & IIf(String.IsNullOrEmpty(drOtrasDed("Nombre2").ToString), "", drOtrasDed("Nombre2") & " ") & drOtrasDed("Apellido1") & IIf(String.IsNullOrEmpty(drOtrasDed("Apellido2").ToString), "", " " & drOtrasDed("Apellido2"))
                For i = 1 To colDedDestinos.Count
                    ws.Cells(intLinea, 3 + i) = drOtrasDed("Deduccion" & Strings.Trim(Str(i)))
                Next
                intLinea = intLinea + 1
                intTotEmpleados = intTotEmpleados + 1
            End While
            cnSQLConexion.Close()
            excel.Visible = True
            'wb.Activate()
            wb.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class