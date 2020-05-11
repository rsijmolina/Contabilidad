Imports System.IO
Public Class PLGenerarBancosFrm
    Dim PlCls As New PLClassLib.PlClass
    Dim drConfPlani As SqlClient.SqlDataReader
    Dim RSICls As New Rsierpgencl.Rsierpcl.Cadenas

    Private Sub PLGenerarBancosFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        c1dateFecha.Value = Date.Now
        'c1txtHora.Text = TimeOfDay.Hour & ":" & TimeOfDay.Minute & ":" & TimeOfDay.Second
        lblHora.Text = Now.ToShortTimeString
        PlCls.DBconStr = strcnCAD
        drConfPlani = PlCls.drConf
        c1numNoPlanilla.Value = drConfPlani("NoPlanilla")
        lblDescPlanilla.Text = PlCls.DescripcionPlanilla(drConfPlani("NoPlanilla"))
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        PLProcDeduccionesFrm.Año = drConfPlani("AñoEnProceso")
        PLProcDeduccionesFrm.Mes = drConfPlani("MesEnProceso")
        PLProcDeduccionesFrm.NoPlanilla = drConfPlani("NoPlanilla")
        PLProcDeduccionesFrm.Procesar("PLANILLA")
        If radiobutFicohsa.Checked Then
            GenerarFicohsa()
        ElseIf radiobutHSBC.Checked Then
            GenerarHSBC()
        ElseIf radiobutAtlantida.Checked Then
            If c1txtCodigoEmpresaBA.Text = "" Then
                MsgBox("Debe ingresar el código de empresa...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            Else
                GenerarAtlantida()
            End If
        End If
    End Sub
    Private Sub GenerarFicohsa()
        Dim dblSNeto As Decimal, dblOtrasDed As Decimal, dblTotSueldos As Decimal, dblTotIng As Decimal, dblTotEg As Decimal
        Dim strCtaCred As String, strCta1 As String, strCta2 As String, strCta3 As String
        Dim i As Integer, intLinea As Integer, intCol As Integer, j As Integer, intSubCta As Int16
        Dim excel As Microsoft.Office.Interop.Excel.Application
        Dim wb As Microsoft.Office.Interop.Excel.Workbook
        Dim ws As Microsoft.Office.Interop.Excel.Worksheet

        Try
            excel = New Microsoft.Office.Interop.Excel.Application

            wb = excel.Workbooks.Open(System.AppDomain.CurrentDomain.BaseDirectory() & "Planillatmp.xls")
            ws = wb.Worksheets(1)
            Me.PLPlanillasTableAdapter.Fill(Me.PLPlanillaBancosDataSet.PLPlanillas, drConfPlani("AñoEnProceso"), drConfPlani("MesEnProceso"), c1numNoPlanilla.Value, "FICOHSA")


            ws.Cells(3, 1) = Strings.Left(c1dateFecha.Value.ToString, 19)
            'ws.Cells(5, 1) = c1dateFecha.Value.ToString
            ws.Cells(6, 1) = c1txtCorrelativoFicohsa.Text

            i = 0
            intLinea = 8
            intCol = 1
            dblTotSueldos = 0
            For Each mDataPlani As DataRowView In PLGenerarBancosBindingSource.List
                dblOtrasDed = 0
                If c1numNoPlanilla.Value = 2 Then
                    dblOtrasDed = Math.Round(mDataPlani("Deduccion1") + mDataPlani("Deduccion2") + mDataPlani("Deduccion3") + mDataPlani("Deduccion4") + mDataPlani("Deduccion5") + mDataPlani("Deduccion6") + mDataPlani("Deduccion7") + mDataPlani("Deduccion8") + mDataPlani("Deduccion9") + mDataPlani("Deduccion10") + mDataPlani("Deduccion30"), 2)
                Else
                    dblOtrasDed = Math.Round(mDataPlani("Deduccion1") + mDataPlani("Deduccion2") + mDataPlani("Deduccion3") + mDataPlani("Deduccion4") + mDataPlani("Deduccion5") + mDataPlani("Deduccion6") + mDataPlani("Deduccion7") + mDataPlani("Deduccion8") + mDataPlani("Deduccion9") + mDataPlani("Deduccion10") + +mDataPlani("Deduccion11") + mDataPlani("Deduccion12") + mDataPlani("Deduccion30"), 2)
                End If
                ws.Cells(intLinea, 1) = RSICls.RellenarIzq(Trim(Str(i + 1)), 6, "0")
                ws.Cells(intLinea, 2) = "002"
                ws.Cells(intLinea, 3) = "1"
                ws.Cells(intLinea, 4) = "AAAAAAAA"
                ws.Cells(intLinea, 5) = "028"
                ws.Cells(intLinea, 6) = "01"
                ws.Cells(intLinea, 7) = c1txtCtaDeb1.Text
                ws.Cells(intLinea, 8) = c1txtCtaDeb2.Text
                ws.Cells(intLinea, 9) = RSICls.RellenarIzq(c1txtCtaDeb3.Text, 12, "0")
                ws.Cells(intLinea, 10) = "028"
                ws.Cells(intLinea, 11) = "01"
                strCtaCred = ""
                strCta1 = ""
                strCta2 = ""
                strCta3 = ""
                intSubCta = 1
                For j = 1 To Strings.Len(mDataPlani("NoCuentaBancaria"))
                    If Strings.Mid(mDataPlani("NoCuentaBancaria"), j, 1) <> "-" Then
                        If intSubCta = 1 Then
                            strCta1 = strCta1 & Strings.Mid(mDataPlani("NoCuentaBancaria"), j, 1)
                        ElseIf intSubCta = 2 Then
                            strCta2 = strCta2 & Strings.Mid(mDataPlani("NoCuentaBancaria"), j, 1)
                        ElseIf intSubCta = 3 Then
                            strCta3 = strCta3 & Strings.Mid(mDataPlani("NoCuentaBancaria"), j, 1)
                        End If
                        'strCtaCred = strCtaCred & Strings.Mid(mDataPlani("NoCuentaBancaria"), j, 1)
                    Else
                        If intSubCta = 1 Then
                            strCta1 = RSICls.RellenarIzq(strCta1, 3, "0")
                            intSubCta = 2
                        ElseIf intSubCta = 2 Then
                            intSubCta = 3
                        End If
                    End If
                Next
                strCta3 = RSICls.RellenarIzq(strCta3, 12, "0")

                ws.Cells(intLinea, 12) = strCta1 'RSICls.RellenarIzq(Strings.Left(strCtaCred, 2), 3, "0")
                ws.Cells(intLinea, 13) = strCta2 'Strings.Mid(strCtaCred, 3, 3)
                ws.Cells(intLinea, 14) = strCta3 'RSICls.RellenarIzq(Strings.Mid(strCtaCred, 6, Strings.Len(strCtaCred) - 5), 12, "0")
                ws.Cells(intLinea, 15) = "CA"
                ws.Cells(intLinea, 17) = mDataPlani("Nombre1") & " " & IIf(String.IsNullOrEmpty(mDataPlani("Nombre2").ToString), "", mDataPlani("Nombre2") & " ") & mDataPlani("Apellido1") & IIf(String.IsNullOrEmpty(mDataPlani("Apellido2").ToString), "", " " & mDataPlani("Apellido2"))
                ws.Cells(intLinea, 18) = IIf(mDataPlani("NoPlanilla") = 1, "PRIMERA", "SEGUNDA") & " QUINCENA DE " & RSICls.MesLetras(drConfPlani("MesEnProceso"))
                dblTotIng = Math.Round(mDataPlani("SueldoNormal") + mDataPlani("ValorHorasExtras25") + mDataPlani("ValorHorasExtras50") + mDataPlani("ValorHorasExtras75") + mDataPlani("ValorHorasExtrasDobles") + mDataPlani("Comisiones") + mDataPlani("Bonificaciones") + mDataPlani("Transporte") + mDataPlani("Combustible") + mDataPlani("DepreciacionVehiculo") + mDataPlani("Vacaciones") + mDataPlani("IngresosAdicionales1") + mDataPlani("IngresosAdicionales2") + mDataPlani("IngresosAdicionales3") + mDataPlani("IngresosAdicionales4") + mDataPlani("IngresosAdicionales5"), 2)
                dblTotEg = Math.Round(mDataPlani("ValorHorasTarde") + mDataPlani("SeguroSocial") + mDataPlani("RAP") + mDataPlani("ImpuestoVecinal") + mDataPlani("ImpuestoSobreRenta") + mDataPlani("INJUPEMP") + mDataPlani("INPREMA") + mDataPlani("DeduccionFija1") + mDataPlani("DeduccionFija2") + mDataPlani("DeduccionFija3") + mDataPlani("DeduccionFija4") + mDataPlani("DeduccionFija5") + dblOtrasDed, 2)
                dblSNeto = Math.Round(dblTotIng - dblTotEg, 2)
                ws.Cells(intLinea, 20) = RSICls.RellenarIzq(Format(dblSNeto, "###0.00"), 14, "0")
                ws.Cells(intLinea, 21) = "000"
                dblTotSueldos = dblTotSueldos + dblSNeto
                intLinea = intLinea + 1
                i = i + 1
            Next
            ws.Cells(5, 1) = Strings.Trim(Str(i)) & ":" & Format(dblTotSueldos, "###0.00")
            excel.Visible = True
            'wb.Activate()
            wb.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GenerarHSBC()
        Dim dblSNeto As Decimal, dblOtrasDed As Decimal, dblTotSueldos As Decimal, dblTotIng As Decimal, dblTotEg As Decimal
        Dim strCtaCred As String
        Dim i As Integer, intLinea As Integer, intCol As Integer, j As Integer
        Dim excel As Microsoft.Office.Interop.Excel.Application
        Dim wb As Microsoft.Office.Interop.Excel.Workbook
        Dim ws As Microsoft.Office.Interop.Excel.Worksheet

        Try
            excel = New Microsoft.Office.Interop.Excel.Application

            wb = excel.Workbooks.Add
            ws = wb.Worksheets(1)
            Me.PLPlanillasTableAdapter.Fill(Me.PLPlanillaBancosDataSet.PLPlanillas, drConfPlani("AñoEnProceso"), drConfPlani("MesEnProceso"), c1numNoPlanilla.Value, "DAVIVIENDA")

            i = 0
            intLinea = 1
            intCol = 1
            dblTotSueldos = 0
            For Each mDataPlani As DataRowView In PLGenerarBancosBindingSource.List
                dblOtrasDed = 0
                If c1numNoPlanilla.Value = 2 Then
                    dblOtrasDed = Math.Round(mDataPlani("Deduccion1") + mDataPlani("Deduccion2") + mDataPlani("Deduccion3") + mDataPlani("Deduccion4") + mDataPlani("Deduccion5") + mDataPlani("Deduccion6") + mDataPlani("Deduccion7") + mDataPlani("Deduccion8") + mDataPlani("Deduccion9") + mDataPlani("Deduccion10") + mDataPlani("Deduccion30"), 2)
                Else
                    dblOtrasDed = Math.Round(mDataPlani("Deduccion1") + mDataPlani("Deduccion2") + mDataPlani("Deduccion3") + mDataPlani("Deduccion4") + mDataPlani("Deduccion5") + mDataPlani("Deduccion6") + mDataPlani("Deduccion7") + mDataPlani("Deduccion8") + mDataPlani("Deduccion9") + mDataPlani("Deduccion10") + +mDataPlani("Deduccion11") + mDataPlani("Deduccion12") + mDataPlani("Deduccion30"), 2)
                End If

                ws.Cells(intLinea, 1) = "A"
                ws.Range("B" & Trim(Str(intLinea))).Cells.NumberFormat = "@"
                strCtaCred = ""
                For j = 1 To Strings.Len(mDataPlani("NoCuentaBancaria"))
                    If Strings.Mid(mDataPlani("NoCuentaBancaria"), j, 1) <> "-" Then
                        strCtaCred = strCtaCred & Strings.Mid(mDataPlani("NoCuentaBancaria"), j, 1)
                    End If
                Next
                ws.Cells(intLinea, 2) = strCtaCred

                dblTotIng = Math.Round(mDataPlani("SueldoNormal") + mDataPlani("ValorHorasExtras25") + mDataPlani("ValorHorasExtras50") + mDataPlani("ValorHorasExtras75") + mDataPlani("ValorHorasExtrasDobles") + mDataPlani("Comisiones") + mDataPlani("Bonificaciones") + mDataPlani("Transporte") + mDataPlani("Combustible") + mDataPlani("DepreciacionVehiculo") + mDataPlani("Vacaciones") + mDataPlani("IngresosAdicionales1") + mDataPlani("IngresosAdicionales2") + mDataPlani("IngresosAdicionales3") + mDataPlani("IngresosAdicionales4") + mDataPlani("IngresosAdicionales5"), 2)
                dblTotEg = Math.Round(mDataPlani("ValorHorasTarde") + mDataPlani("SeguroSocial") + mDataPlani("RAP") + mDataPlani("ImpuestoVecinal") + mDataPlani("ImpuestoSobreRenta") + mDataPlani("INJUPEMP") + mDataPlani("INPREMA") + mDataPlani("DeduccionFija1") + mDataPlani("DeduccionFija2") + mDataPlani("DeduccionFija3") + mDataPlani("DeduccionFija4") + mDataPlani("DeduccionFija5") + dblOtrasDed, 2)
                dblSNeto = Math.Round(dblTotIng - dblTotEg, 2)
                ws.Cells(intLinea, 3) = RSICls.RellenarIzq(Format(dblSNeto, "###0.00"), 14, "0")
                dblTotSueldos = dblTotSueldos + dblSNeto
                intLinea = intLinea + 1
                i = i + 1
            Next
            excel.Visible = True
            'wb.Activate()
            wb.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GenerarAtlantida()
        Dim dblSNeto As Decimal, dblOtrasDed As Decimal, dblTotSueldos As Decimal, dblTotIng As Decimal, dblTotEg As Decimal
        Dim strCadena As String, strSldoNeto As String, strArch As String
        Dim sw As StreamWriter  'Archivos de texto
        Dim clRSICad As New Rsierpgencl.Rsierpcl.Cadenas

        dlgGuardarArchivo.FileName = "Planilla" & c1numNoPlanilla.Text & "_" & clRSICad.RellenarIzq(drConfPlani("MesEnProceso"), 2, "0") & drConfPlani("AñoEnProceso") & ".txt"
        dlgGuardarArchivo.ShowDialog()
        strArch = dlgGuardarArchivo.FileName
        Try
            Me.PLPlanillasTableAdapter.Fill(Me.PLPlanillaBancosDataSet.PLPlanillas, drConfPlani("AñoEnProceso"), drConfPlani("MesEnProceso"), c1numNoPlanilla.Value, "ATLANTIDA")
            dblTotSueldos = 0
            strCadena = ""
            For Each mDataPlani As DataRowView In PLGenerarBancosBindingSource.List
                dblOtrasDed = 0
                If c1numNoPlanilla.Value = 2 Then
                    dblOtrasDed = Math.Round(mDataPlani("Deduccion1") + mDataPlani("Deduccion2") + mDataPlani("Deduccion3") + mDataPlani("Deduccion4") + mDataPlani("Deduccion5") + mDataPlani("Deduccion6") + mDataPlani("Deduccion7") + mDataPlani("Deduccion8") + mDataPlani("Deduccion9") + mDataPlani("Deduccion10") + mDataPlani("Deduccion30"), 2)
                Else
                    dblOtrasDed = Math.Round(mDataPlani("Deduccion1") + mDataPlani("Deduccion2") + mDataPlani("Deduccion3") + mDataPlani("Deduccion4") + mDataPlani("Deduccion5") + mDataPlani("Deduccion6") + mDataPlani("Deduccion7") + mDataPlani("Deduccion8") + mDataPlani("Deduccion9") + mDataPlani("Deduccion10") + +mDataPlani("Deduccion11") + mDataPlani("Deduccion12") + mDataPlani("Deduccion30"), 2)
                End If
                dblTotIng = Math.Round(mDataPlani("SueldoNormal") + mDataPlani("ValorHorasExtras25") + mDataPlani("ValorHorasExtras50") + mDataPlani("ValorHorasExtras75") + mDataPlani("ValorHorasExtrasDobles") + mDataPlani("Comisiones") + mDataPlani("Bonificaciones") + mDataPlani("Transporte") + mDataPlani("Combustible") + mDataPlani("DepreciacionVehiculo") + mDataPlani("Vacaciones") + mDataPlani("IngresosAdicionales1") + mDataPlani("IngresosAdicionales2") + mDataPlani("IngresosAdicionales3") + mDataPlani("IngresosAdicionales4") + mDataPlani("IngresosAdicionales5"), 2)
                dblTotEg = Math.Round(mDataPlani("ValorHorasTarde") + mDataPlani("SeguroSocial") + mDataPlani("RAP") + mDataPlani("ImpuestoVecinal") + mDataPlani("ImpuestoSobreRenta") + mDataPlani("INJUPEMP") + mDataPlani("INPREMA") + mDataPlani("DeduccionFija1") + mDataPlani("DeduccionFija2") + mDataPlani("DeduccionFija3") + mDataPlani("DeduccionFija4") + mDataPlani("DeduccionFija5") + dblOtrasDed, 2)
                dblSNeto = Math.Round(dblTotIng - dblTotEg, 2)
                strSldoNeto = Trim(Str(dblSNeto))
                strSldoNeto = Strings.Left(strSldoNeto, Strings.InStr(strSldoNeto, ".") - 1) & Strings.Right(strSldoNeto, 2)
                strCadena = strCadena & clRSICad.RellenarDer(mDataPlani("CodigoEmpleado"), 16, " ") & "01" & c1txtCodigoEmpresaBA.Text & "001"
                strCadena = strCadena & clRSICad.RellenarIzq(strSldoNeto, 16, " ")
                strCadena = strCadena & clRSICad.RellenarDer("Planilla No. " & mDataPlani("NoPlanilla") & " de " & clRSICad.MesLetras(mDataPlani("Mes")) & " de " & mDataPlani("Año"), 40, " ") & vbCrLf
                dblTotSueldos = dblTotSueldos + dblSNeto
            Next
            sw = New StreamWriter(strArch)
            sw.Write(strCadena)
            MsgBox("Archivo generado...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            sw.Close()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub c1numNoPlanilla_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numNoPlanilla.Validating
        lblDescPlanilla.Text = PlCls.DescripcionPlanilla(c1numNoPlanilla.Value)
    End Sub
End Class