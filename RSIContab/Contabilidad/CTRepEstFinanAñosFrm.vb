Public Class CTRepEstFinanAñosFrm
    Private _strTipoEstado As String
    Public Property strTipoEstado() As String
        Get
            Return _strTipoEstado
        End Get
        Set(ByVal value As String)
            _strTipoEstado = value
        End Set
    End Property
    Dim CTEstFinCls As New CTClassLib.CTClass.CTEstadosFinancieros
    Dim RSICadenas As New Rsierpgencl.Rsierpcl.Cadenas
    Dim drCnf As SqlClient.SqlDataReader
    Dim EstFinancierosDataSet As New CTEstFinanDataSet
    Private Sub CTRepEstFinanAñosFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CTEstFinCls.DBconStr = strcnCAD
        drCnf = CTEstFinCls.drConf

        Try
            If strTipoEstado = "BG" Then
                Me.Text = "Reporte del Balance General por Años"
                lblNivelCta1.Text = "Activo:"
                lblNivelCta2.Text = "Pasivo:"
                lblNivelCta3.Text = "Capital:"
                numupdnNivelCta1.Value = drCnf("NivelActivoRepBalGen")
                numupdnNivelCta2.Value = drCnf("NivelPasivoRepBalGen")
                numupdnNivelCta3.Value = drCnf("NivelCapitalRepBalGen")
            Else
                Me.Text = "Reporte del Estado de Resultados por Años"
                lblNivelCta1.Text = "Ingresos:"
                lblNivelCta2.Text = "Costos:"
                lblNivelCta3.Text = "Gastos:"
                numupdnNivelCta1.Value = drCnf("NivelIngresosRepEstResul")
                numupdnNivelCta2.Value = drCnf("NivelCostosRepEstResul")
                numupdnNivelCta3.Value = drCnf("NivelGastosRepEstResul")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Try
            CTEstFinCls.strTipoEstado = strTipoEstado
            CTEstFinCls.boEstFinanAños = True
            If radiobutSaldosAnuales.Checked Then   'Solo para las opciones de todos los meses de año y comparativo de 2 años
                CTEstFinCls.strAnualMensual = "A"
            Else
                CTEstFinCls.strAnualMensual = "M"
            End If
            If RadioButRangoAños.Checked Then
                If c1numAñoIni.Value > c1numAñoFin.Value Then
                    MsgBox("El Año Inicial Debe ser Menor que el Año Final", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                    Exit Sub
                End If
                CTEstFinCls.intTipoEstFinanAños = 1
                CTEstFinCls.intAñoIni = c1numAñoIni.Value
                CTEstFinCls.intAñoFin = c1numAñoFin.Value
            ElseIf RadioButTodosMesesAño.Checked Then
                If String.IsNullOrEmpty(c1numMesesAño.Text) Then
                    MsgBox("Debe Ingresar el Año Correspondiente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                    Exit Sub
                End If
                CTEstFinCls.intTipoEstFinanAños = 2
                CTEstFinCls.intAñoIni = c1numMesesAño.Value
            ElseIf RadioButComparativoDosAños.Checked Then
                CTEstFinCls.intTipoEstFinanAños = 3
                CTEstFinCls.intAñoIni = c1numAñoIni.Value
                CTEstFinCls.intAñoFin = c1numAñoFin.Value
            End If
            CTEstFinCls.boSuprimirCeros = chkboxSuprimirSaldosCero.Checked
            CTEstFinCls.CTEstFDataSet = EstFinancierosDataSet
            CTEstFinCls.intNivelMax1 = numupdnNivelCta1.Value
            CTEstFinCls.intNivelMax2 = numupdnNivelCta2.Value
            CTEstFinCls.intNivelMax3 = numupdnNivelCta3.Value
            CTEstFinCls.drCTCnf = drCnf
            CTEstFinCls.GenerarEstadosFinancieros()
            If EstFinancierosDataSet.Tables("CTEstFinanDataTable").Rows.Count = 0 Then
                MsgBox("No hay datos a listar en este período...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                Exit Sub
            End If
            ExportarExcel()
            'CTTmpFrm.DataGridView1.DataSource = EstFinancierosDataSet.Tables("CTEstFinanDataTable")
            'CTTmpFrm.ShowDialog()
            'CTTmpFrm.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub ExportarExcel()
        Dim strTitEstFinancieros As String = ""
        Dim excel As Microsoft.Office.Interop.Excel.Application
        Dim wb As Microsoft.Office.Interop.Excel.Workbook
        Dim ws As Microsoft.Office.Interop.Excel.Worksheet
        Dim i As Int16 = 0, intLin As Int16 = 5, intCol As Int16, intColValor As Int16

        Try
            If strTipoEstado = "BG" Then
                strTitEstFinancieros = "Estado de Resultados "
            Else
                strTitEstFinancieros = "Balance General "
            End If
            excel = New Microsoft.Office.Interop.Excel.Application
            wb = excel.Workbooks.Add
            ws = wb.Worksheets(1)
            ws.Cells(1, 1) = My.Settings.RSIEmpresaActual

            If RadioButRangoAños.Checked Then
                ws.Cells(2, 1) = strTitEstFinancieros & "del Año " & c1numAñoIni.Value & " al Año " & c1numAñoFin.Value
                intCol = 2
                For i = c1numAñoIni.Value To c1numAñoFin.Value
                    ws.Cells(4, intCol) = i
                    intCol = intCol + 1
                Next
            ElseIf RadioButTodosMesesAño.Checked Then
                ws.Cells(2, 1) = strTitEstFinancieros & "del Año " & c1numMesesAño.Value
                intCol = 2
                For i = 1 To 12
                    ws.Cells(4, intCol) = RSICadenas.MesLetras(i)
                    intCol = intCol + 1
                Next
            ElseIf RadioButComparativoDosAños.Checked Then
                ws.Cells(2, 1) = strTitEstFinancieros & "de los Años " & c1numAñoIni.Value & " y " & c1numAñoFin.Value
                intCol = 2
                For i = 1 To 12
                    ws.Cells(4, intCol) = RSICadenas.MesLetras(i)
                    intCol = intCol + 2
                Next
                intCol = 2
                For i = 1 To 12
                    ws.Cells(5, intCol) = c1numAñoIni.Value
                    ws.Cells(5, intCol + 1) = c1numAñoFin.Value
                    intCol = intCol + 2
                Next
                intLin = 6
            End If

            For Each EstFinanReg As DataRow In EstFinancierosDataSet.Tables("CTEstFinanDataTable").Rows
                ws.Cells(intLin, 1) = EstFinanReg("Descripcion")
                intCol = 2
                If EstFinanReg("Tipo") <> "E" Then
                    If RadioButRangoAños.Checked Then
                        intColValor = 1
                        For i = c1numAñoIni.Value To c1numAñoFin.Value
                            ws.Cells(intLin, intCol) = EstFinanReg("ValorA" & Trim(Str(intColValor)))
                            intCol = intCol + 1
                            intColValor = intColValor + 1
                        Next
                    ElseIf RadioButTodosMesesAño.Checked Then
                        For i = 1 To 12
                            ws.Cells(intLin, intCol) = EstFinanReg("ValorA" & Trim(Str(i)))
                            intCol = intCol + 1
                        Next
                    ElseIf RadioButComparativoDosAños.Checked Then
                        intColValor = 1
                        For i = 1 To 12
                            ws.Cells(intLin, intCol) = EstFinanReg("ValorA" & Trim(Str(i)))
                            ws.Cells(intLin, intCol + 1) = EstFinanReg("ValorA" & Trim(Str(i + 12)))
                            intCol = intCol + 2
                        Next
                    End If
                End If
                If EstFinanReg("Tipo") = "T" Then
                    intLin = intLin + 2
                Else
                    intLin = intLin + 1
                End If
            Next
            excel.Visible = True
            wb.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub RadioButComparativoDosAños_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButComparativoDosAños.CheckedChanged
        If RadioButComparativoDosAños.Checked Then
            lblDesde.Text = "Año 1:"
            lblHasta.Text = "Año 2:"
            grpboxSaldosListar.Enabled = True
        Else
            lblDesde.Text = "Desde:"
            lblHasta.Text = "Hasta:"
        End If
    End Sub

    Private Sub RadioButRangoAños_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButRangoAños.CheckedChanged
        If RadioButRangoAños.Checked Then
            grpboxSaldosListar.Enabled = False
        End If
    End Sub

    Private Sub RadioButTodosMesesAño_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButTodosMesesAño.CheckedChanged
        If RadioButTodosMesesAño.Checked Then
            grpboxSaldosListar.Enabled = True
        End If
    End Sub
End Class