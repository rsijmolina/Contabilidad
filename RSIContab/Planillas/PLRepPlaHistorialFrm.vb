Public Class PLRepPlaHistorialFrm
    Dim excel As Microsoft.Office.Interop.Excel.Application
    Dim wb As Microsoft.Office.Interop.Excel.Workbook
    Dim ws As Microsoft.Office.Interop.Excel.Worksheet
    Dim PlCls As New PLClassLib.PlClass
    Dim drConfPlani As SqlClient.SqlDataReader
    Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
    Dim lstEmplsFrm As New ListaEmpleadosFom
    Dim drDatosEmp As SqlClient.SqlDataReader
    Dim strCodigoEmp As String, strNombre As String
    Dim intLin As Int32
    Dim decMesesVal(13) As Decimal

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If chkExportarHistorial.Checked Then
            ExportarHistorial()
        Else
            ImprimirHistorial()
        End If
    End Sub
    Private Sub ImprimirHistorial()
        Dim strSQL As String
        Dim decTotalDed As Decimal

        strSQL = "{PLPlanillas.CodigoEmpleado}>='" & c1txtEmpleadoIni.Text & "' AND {PLPlanillas.CodigoEmpleado}<='" & c1txtEmpleadoFin.Text _
        & "' AND {PLPlanillas.Año}>=" & c1numAñoIni.Value & " AND {PLPlanillas.Año}<=" & c1numAñoFin.Value

        Try
            'Proceso para actualizar OtrasDeducciones
            Me.PLPlanillasTableAdapter1.Fill(PLActualizarOtrasDedDataSet.PLPlanillas, c1numAñoIni.Value, c1numAñoFin.Value, c1txtEmpleadoIni.Text, c1txtEmpleadoFin.Text)
            Me.PLPlanillasOTTableAdapter1.Fill(PLActualizarOtrasDedDataSet.PLPlanillasOT, c1numAñoIni.Value, c1numAñoFin.Value, c1txtEmpleadoIni.Text, c1txtEmpleadoFin.Text)

            For Each mDataPlani As DataRowView In PLActHistBindingSource.List
                decTotalDed = 0
                PLActHistOtrasDedBindingSource.Filter = "Año=" & mDataPlani("Año") & " AND Mes=" & mDataPlani("Mes") & " AND NoPlanilla=" & mDataPlani("NoPlanilla") & " AND CodigoEmpleado='" & mDataPlani("CodigoEmpleado") & "'"
                For Each mDataPlaniOT As DataRowView In PLActHistOtrasDedBindingSource.List
                    decTotalDed = decTotalDed + mDataPlaniOT("Valor")
                Next
                mDataPlani("OtrasDeducciones") = decTotalDed
            Next

            Me.Validate()
            Me.PrincipalBindingSource.EndEdit()
            Me.PLPlanillasTableAdapter1.Update(Me.PLActualizarOtrasDedDataSet.PLPlanillas)
            rptClass.EjecutarReportesVarios(strcnCAD, My.Settings.RSIEmpresaActual, "PLHistorialRpt", strSQL, "", c1dateFecha.Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ExportarHistorial()
        Dim i As Int16
        Dim decOtrasDed As Decimal, decTotIng As Decimal, decTotEg As Decimal
        Dim mDatoActual As DataRowView

        Try
            Me.PLPlanillasTableAdapter.Fill(PLExportarHistorialDataSet.PLPlanillas, c1numAñoExportar.Value, c1txtEmpleadoIni.Text, c1txtEmpleadoFin.Text)
            If PrincipalBindingSource.Count = 0 Then
                MsgBox("No hay registros en este rango", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                Exit Sub
            End If
            Me.PLPlanillasOTTableAdapter.Fill(PLExportarHistorialDataSet.PLPlanillasOT, c1numAñoExportar.Value, c1txtEmpleadoIni.Text, c1txtEmpleadoFin.Text)
            mDatoActual = PrincipalBindingSource.Current
            strCodigoEmp = mDatoActual("CodigoEmpleado")

            excel = New Microsoft.Office.Interop.Excel.Application
            wb = excel.Workbooks.Add
            ws = wb.Worksheets(1)

            If radiobutBonos.Checked Then
                ws.Cells(1, 1) = "Historial de Bonificaciones del Año " & c1numAñoExportar.Value
            ElseIf radiobutHorasExtras.Checked Then
                ws.Cells(1, 1) = "Historial de Horas Extras del Año " & c1numAñoExportar.Value
            Else
                ws.Cells(1, 1) = "Historial de Sueldos del Año " & c1numAñoExportar.Value
            End If

            intLin = 3
            ws.Cells(intLin, 1) = "Código"
            ws.Cells(intLin, 2) = "Nombre"
            ws.Cells(intLin, 3) = "Enero"
            ws.Cells(intLin, 4) = "Febrero"
            ws.Cells(intLin, 5) = "Marzo"
            ws.Cells(intLin, 6) = "Abril"
            ws.Cells(intLin, 7) = "Mayo"
            ws.Cells(intLin, 8) = "Junio"
            ws.Cells(intLin, 9) = "Julio"
            ws.Cells(intLin, 10) = "Agosto"
            ws.Cells(intLin, 11) = "Septiembre"
            ws.Cells(intLin, 12) = "Octubre"
            ws.Cells(intLin, 13) = "Noviembre"
            ws.Cells(intLin, 14) = "Diciembre"
            intLin = 4
            For i = 0 To 12
                decMesesVal(i) = 0
            Next
            For Each mDataPlani As DataRowView In PrincipalBindingSource.List
                If mDataPlani("CodigoEmpleado") = strCodigoEmp Then
                    PlanillasOTBindingSource.Filter = "Mes=" & mDataPlani("Mes") & " AND NoPlanilla=" & mDataPlani("NoPlanilla") & " AND CodigoEmpleado='" & mDataPlani("CodigoEmpleado") & "'"
                    decOtrasDed = 0
                    For Each mDataPlaniOT As DataRowView In PlanillasOTBindingSource.List
                        decOtrasDed = decOtrasDed + mDataPlaniOT("Valor")
                    Next
                    strNombre = mDataPlani("Nombre1") & IIf(String.IsNullOrEmpty(mDataPlani("Nombre2")), "", " " & mDataPlani("Nombre2")) _
                        & " " & mDataPlani("Apellido1") & IIf(String.IsNullOrEmpty(mDataPlani("Apellido2")), "", " " & mDataPlani("Apellido2"))
                    If radiobutTotSueldoNormal.Checked Then
                        decMesesVal(mDataPlani("Mes")) = decMesesVal(mDataPlani("Mes")) + mDataPlani("SueldoNormal")
                    ElseIf radiobutTotalizarSueldoNeto.Checked Then
                        decTotIng = Math.Round(mDataPlani("SueldoNormal") + mDataPlani("ValorHorasExtras25") + mDataPlani("ValorHorasExtras50") + mDataPlani("ValorHorasExtras75") + mDataPlani("ValorHorasExtrasDobles") + mDataPlani("Comisiones") + mDataPlani("Bonificaciones") + mDataPlani("Transporte") + mDataPlani("Combustible") + mDataPlani("DepreciacionVehiculo") + mDataPlani("Vacaciones") + mDataPlani("IngresosAdicionales1") + mDataPlani("IngresosAdicionales2") + mDataPlani("IngresosAdicionales3") + mDataPlani("IngresosAdicionales4") + mDataPlani("IngresosAdicionales5"), 2)
                        decTotEg = Math.Round(mDataPlani("ValorHorasTarde") + mDataPlani("SeguroSocial") + mDataPlani("RAP") + mDataPlani("ImpuestoVecinal") + mDataPlani("ImpuestoSobreRenta") + mDataPlani("INJUPEMP") + mDataPlani("INPREMA") + mDataPlani("DeduccionFija1") + mDataPlani("DeduccionFija2") + mDataPlani("DeduccionFija3") + mDataPlani("DeduccionFija4") + mDataPlani("DeduccionFija5"), 2)
                        decMesesVal(mDataPlani("Mes")) = decMesesVal(mDataPlani("Mes")) + (decTotIng - decTotEg)
                    ElseIf radiobutBonos.Checked Then
                        decMesesVal(mDataPlani("Mes")) = decMesesVal(mDataPlani("Mes")) + mDataPlani("Bonificaciones")
                    ElseIf radiobutHorasExtras.Checked Then
                        decMesesVal(mDataPlani("Mes")) = decMesesVal(mDataPlani("Mes")) + Math.Round(mDataPlani("ValorHorasExtras25") + mDataPlani("ValorHorasExtras50") + mDataPlani("ValorHorasExtras75") + mDataPlani("ValorHorasExtrasDobles"), 2)
                    End If
                Else
                    ActualizarHoja()
                    intLin = intLin + 1
                    For i = 0 To 12
                        decMesesVal(i) = 0
                    Next
                    strNombre = mDataPlani("Nombre1") & IIf(String.IsNullOrEmpty(mDataPlani("Nombre2")), "", " " & mDataPlani("Nombre2")) _
                        & " " & mDataPlani("Apellido1") & IIf(String.IsNullOrEmpty(mDataPlani("Apellido2")), "", " " & mDataPlani("Apellido2"))
                    strCodigoEmp = mDataPlani("CodigoEmpleado")
                    If radiobutTotSueldoNormal.Checked Then
                        decMesesVal(mDataPlani("Mes")) = decMesesVal(mDataPlani("Mes")) + mDataPlani("SueldoNormal")
                    ElseIf radiobutTotalizarSueldoNeto.Checked Then
                        decTotIng = Math.Round(mDataPlani("SueldoNormal") + mDataPlani("ValorHorasExtras25") + mDataPlani("ValorHorasExtras50") + mDataPlani("ValorHorasExtras75") + mDataPlani("ValorHorasExtrasDobles") + mDataPlani("Comisiones") + mDataPlani("Bonificaciones") + mDataPlani("Transporte") + mDataPlani("Combustible") + mDataPlani("DepreciacionVehiculo") + mDataPlani("Vacaciones") + mDataPlani("IngresosAdicionales1") + mDataPlani("IngresosAdicionales2") + mDataPlani("IngresosAdicionales3") + mDataPlani("IngresosAdicionales4") + mDataPlani("IngresosAdicionales5"), 2)
                        decTotEg = Math.Round(mDataPlani("ValorHorasTarde") + mDataPlani("SeguroSocial") + mDataPlani("RAP") + mDataPlani("ImpuestoVecinal") + mDataPlani("ImpuestoSobreRenta") + mDataPlani("INJUPEMP") + mDataPlani("INPREMA") + mDataPlani("DeduccionFija1") + mDataPlani("DeduccionFija2") + mDataPlani("DeduccionFija3") + mDataPlani("DeduccionFija4") + mDataPlani("DeduccionFija5"), 2)
                        decMesesVal(mDataPlani("Mes")) = decMesesVal(mDataPlani("Mes")) + (decTotIng - decTotEg)
                    ElseIf radiobutBonos.Checked Then
                        decMesesVal(mDataPlani("Mes")) = decMesesVal(mDataPlani("Mes")) + mDataPlani("Bonificaciones")
                    ElseIf radiobutHorasExtras.Checked Then
                        decMesesVal(mDataPlani("Mes")) = decMesesVal(mDataPlani("Mes")) + Math.Round(mDataPlani("ValorHorasExtras25") + mDataPlani("ValorHorasExtras50") + mDataPlani("ValorHorasExtras75") + mDataPlani("ValorHorasExtrasDobles"), 2)
                    End If
                End If
            Next
            ActualizarHoja()
            If radiobutSalidaAbrirExcel.Checked Then
                excel.Visible = True
                wb.Close()
            Else
                SaveFileDialogExcel.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                SaveFileDialogExcel.ShowDialog()
                ws.SaveAs(SaveFileDialogExcel.FileName)
                wb.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ActualizarHoja()
        ws.Cells(intLin, 1) = strCodigoEmp
        ws.Cells(intLin, 2) = strNombre
        ws.Cells(intLin, 3) = decMesesVal(1)
        ws.Cells(intLin, 4) = decMesesVal(2)
        ws.Cells(intLin, 5) = decMesesVal(3)
        ws.Cells(intLin, 6) = decMesesVal(4)
        ws.Cells(intLin, 7) = decMesesVal(5)
        ws.Cells(intLin, 8) = decMesesVal(6)
        ws.Cells(intLin, 9) = decMesesVal(7)
        ws.Cells(intLin, 10) = decMesesVal(8)
        ws.Cells(intLin, 11) = decMesesVal(9)
        ws.Cells(intLin, 12) = decMesesVal(10)
        ws.Cells(intLin, 13) = decMesesVal(11)
        ws.Cells(intLin, 14) = decMesesVal(12)
    End Sub

    Private Sub PLRepPlaHistorialFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        c1dateFecha.Value = Date.Now
        PlCls.DBconStr = strcnCAD
        drConfPlani = PlCls.drConf
        rptClass.BaseDatosRpt = BaseDatosActual

        lstEmplsFrm.OrdenarPorCodigo = True
        lstEmplsFrm.EmpleadosRetirados = True
        btnBuscarEmpleadoIni.Enabled = True
        btnBuscarEmpleadoFin.Enabled = True
    End Sub

    Private Sub c1txtEmpleadoIni_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1txtEmpleadoIni.Validating
        If Not String.IsNullOrEmpty(c1txtEmpleadoIni.Text) Then
            drDatosEmp = PlCls.drDatosEmpleado(c1txtEmpleadoIni.Text)
            If drDatosEmp.HasRows Then
                lblNombreIni.Text = drDatosEmp("Nombre1") & IIf(String.IsNullOrEmpty(drDatosEmp("Nombre2")), "", " " & drDatosEmp("Nombre2")) _
                    & " " & drDatosEmp("Apellido1") & IIf(String.IsNullOrEmpty(drDatosEmp("Apellido2")), "", " " & drDatosEmp("Apellido2"))
            Else
                MsgBox("Empleado No Exsite", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            End If
        End If
    End Sub

    Private Sub c1txtEmpleadoFin_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1txtEmpleadoFin.Validating
        If Not String.IsNullOrEmpty(c1txtEmpleadoFin.Text) Then
            drDatosEmp = PlCls.drDatosEmpleado(c1txtEmpleadoFin.Text)
            If drDatosEmp.HasRows Then
                lblNombreFin.Text = drDatosEmp("Nombre1") & IIf(String.IsNullOrEmpty(drDatosEmp("Nombre2")), "", " " & drDatosEmp("Nombre2")) _
                    & " " & drDatosEmp("Apellido1") & IIf(String.IsNullOrEmpty(drDatosEmp("Apellido2")), "", " " & drDatosEmp("Apellido2"))
            Else
                MsgBox("Empleado No Exsite", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            End If
        End If
    End Sub

    Private Sub btnBuscarEmpleadoIni_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscarEmpleadoIni.Click
        lstEmplsFrm.ShowDialog()
        If lstEmplsFrm.DialogResult = Windows.Forms.DialogResult.OK Then
            c1txtEmpleadoIni.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("CodigoEmpleado").Value
            lblNombreIni.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre1").Value & IIf(String.IsNullOrEmpty(lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre2").Value), "", " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre2").Value) _
                & " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido1").Value & IIf(String.IsNullOrEmpty(lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido2").Value), "", " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido2").Value)
        End If
    End Sub

    Private Sub btnBuscarEmpleadoFin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscarEmpleadoFin.Click
        lstEmplsFrm.ShowDialog()
        If lstEmplsFrm.DialogResult = Windows.Forms.DialogResult.OK Then
            c1txtEmpleadoFin.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("CodigoEmpleado").Value
            lblNombreFin.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre1").Value & IIf(String.IsNullOrEmpty(lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre2").Value), "", " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre2").Value) _
                & " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido1").Value & IIf(String.IsNullOrEmpty(lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido2").Value), "", " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido2").Value)
        End If
    End Sub

    Private Sub btnBuscarEmpleadoIni_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarEmpleadoIni.Load

    End Sub

    Private Sub radiobutSalidaAbrirExcel_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radiobutSalidaAbrirExcel.CheckedChanged

    End Sub
End Class