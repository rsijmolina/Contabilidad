Public Class PLRepAnualDedSocExcelFrm
    Dim RSIcl As New Rsierpgencl.Rsierpcl.Cadenas
    Dim PlCls As New PLClassLib.PlClass
    Dim drCnf As SqlClient.SqlDataReader
    Dim cnSQLConexion As Data.SqlClient.SqlConnection
    Dim cmdInComando As SqlClient.SqlCommand
    Dim drDatos As SqlClient.SqlDataReader
    Dim decTotDedEmp As Decimal, decTotDedMes(13) As Decimal, decTotDedQuincenal(26) As Decimal
    Dim intSigElemento As Int16
    Dim strDeduccion As String

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim strTitulo As String, strSQL As String, strCodEmpleado As String, strNombre As String
        Dim i As Int16, intLinea As Int16, intCol As Int16, j As Int16, k As Int16
        Dim excel As Microsoft.Office.Interop.Excel.Application
        Dim wb As Microsoft.Office.Interop.Excel.Workbook
        Dim ws As Microsoft.Office.Interop.Excel.Worksheet

        PlCls.DBconStr = strcnCAD
        drCnf = PlCls.drConf

        If radiobutISR.Checked Then
            strDeduccion = "ImpuestoSobreRenta"
            strTitulo = "Reporte del ISR del Año " & c1numAño.Text
            strSQL = "SELECT PLPlanillas.Año,PLPlanillas.Mes,PLPlanillas.NoPlanilla,PLPlanillas.CodigoEmpleado,PLPlanillas.ImpuestoSobreRenta," _
            & "PLEmpleados.Nombre1,PLEmpleados.Nombre2,PLEmpleados.Apellido1,PLEmpleados.Apellido2 FROM PLPlanillas INNER JOIN PLEmpleados " _
            & "ON PLPlanillas.CodigoEmpleado=PLEmpleados.CodigoEmpleado WHERE PLPlanillas.Año=" & c1numAño.Value _
            & " ORDER BY PLEmpleados.Nombre1,PLEmpleados.Nombre2,PLEmpleados.Apellido1,PLEmpleados.Apellido2,PLPlanillas.Año,PLPlanillas.Mes,PLPlanillas.NoPlanilla"
        ElseIf radiobutRAP.Checked Then
            strDeduccion = "RAP"
            strTitulo = "Reporte del RAP del Año " & c1numAño.Text
            strSQL = "SELECT PLPlanillas.Año,PLPlanillas.Mes,PLPlanillas.NoPlanilla,PLPlanillas.CodigoEmpleado,PLPlanillas.RAP," _
            & "PLEmpleados.Nombre1,PLEmpleados.Nombre2,PLEmpleados.Apellido1,PLEmpleados.Apellido2 FROM PLPlanillas INNER JOIN PLEmpleados " _
            & "ON PLPlanillas.CodigoEmpleado=PLEmpleados.CodigoEmpleado WHERE PLPlanillas.Año=" & c1numAño.Value _
            & " ORDER BY PLEmpleados.Nombre1,PLEmpleados.Nombre2,PLEmpleados.Apellido1,PLEmpleados.Apellido2,PLPlanillas.Año,PLPlanillas.Mes,PLPlanillas.NoPlanilla"
        ElseIf radiobutSeguroSoc.Checked Then
            strDeduccion = "SeguroSocial"
            strTitulo = "Reporte del Seguro Social del Año " & c1numAño.Text
            strSQL = "SELECT PLPlanillas.Año,PLPlanillas.Mes,PLPlanillas.NoPlanilla,PLPlanillas.CodigoEmpleado,PLPlanillas.SeguroSocial," _
            & "PLEmpleados.Nombre1,PLEmpleados.Nombre2,PLEmpleados.Apellido1,PLEmpleados.Apellido2 FROM PLPlanillas INNER JOIN PLEmpleados " _
            & "ON PLPlanillas.CodigoEmpleado=PLEmpleados.CodigoEmpleado WHERE PLPlanillas.Año=" & c1numAño.Value _
            & " ORDER BY PLEmpleados.Nombre1,PLEmpleados.Nombre2,PLEmpleados.Apellido1,PLEmpleados.Apellido2,PLPlanillas.Año,PLPlanillas.Mes,PLPlanillas.NoPlanilla"
        ElseIf radiobutSeguroMedico.Checked Then
            strDeduccion = "Valor"
            strTitulo = "Reporte del Seguro Médico del Año " & c1numAño.Text
            strSQL = "SELECT PLPlanillasOT.Año,PLPlanillasOT.Mes,PLPlanillasOT.NoPlanilla,PLPlanillasOT.CodigoEmpleado,PLPlanillasOT.Valor," _
            & "PLEmpleados.Nombre1,PLEmpleados.Nombre2,PLEmpleados.Apellido1,PLEmpleados.Apellido2 FROM PLPlanillasOT INNER JOIN PLEmpleados " _
            & "ON PLPlanillasOT.CodigoEmpleado=PLEmpleados.CodigoEmpleado WHERE PLPlanillasOT.CodigoDeduccion='SEGURO MÉDICO' AND PLPlanillasOT.Año=" & c1numAño.Value _
            & " ORDER BY PLEmpleados.Nombre1,PLEmpleados.Nombre2,PLEmpleados.Apellido1,PLEmpleados.Apellido2,PLPlanillasOT.Año,PLPlanillasOT.Mes,PLPlanillasOT.NoPlanilla"
        End If

        cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = strSQL
        drDatos = cmdInComando.ExecuteReader

        excel = New Microsoft.Office.Interop.Excel.Application

        wb = excel.Workbooks.Add
        ws = wb.Worksheets(1)
        ws.Cells(1, 1) = My.Settings.RSIEmpresaActual
        ws.Cells(2, 1) = strTitulo
        ws.Cells(4, 1) = "Empleado"
        ws.Cells(4, 2) = "Nombre"

        j = 0
        For i = 1 To 12
            If drCnf("PlanillasPorMes") = 1 Then
                ws.Cells(3, i + 2) = RSIcl.MesLetras(i)
            ElseIf drCnf("PlanillasPorMes") = 2 Then
                ws.Cells(3, i + 2 + j) = RSIcl.MesLetras(i)
                ws.Cells(4, i + 2 + j) = "PL 1"
                ws.Cells(4, i + 2 + j + 1) = "PL 2"
                j = j + 1
            End If
        Next
        If drCnf("PlanillasPorMes") = 1 Then
            'ws.Cells(3, 15) = "Total"
        ElseIf drCnf("PlanillasPorMes") = 2 Then
            'ws.Cells(3, 27) = "Total"
        End If

        intLinea = 5
        intCol = 1
        strCodEmpleado = ""
        For k = 1 To 12
            decTotDedMes(i) = 0
        Next
        For k = 1 To 24
            decTotDedQuincenal(i) = 0
        Next

        While drDatos.Read
            If drDatos("CodigoEmpleado") = strCodEmpleado Then
                SumarDatos()
                'intSigElemento = intSigElemento + 1
            Else
                If strCodEmpleado <> "" Then                    
                    ws.Cells(intLinea, 1) = strCodEmpleado
                    ws.Cells(intLinea, 2) = strNombre
                    If drCnf("PlanillasPorMes") = 1 Then
                        For i = 1 To 12
                            ws.Cells(intLinea, i + 2) = decTotDedMes(i)
                            'ws.Cells(intLinea, 15) = decTotDedEmp
                        Next
                    Else    'Planilas por mes 2
                        'j = 2
                        For i = 1 To 24
                            ws.Cells(intLinea, i + 2) = decTotDedQuincenal(i)
                            'ws.Cells(intLinea, i + 2 + j) = decTotDedQuincenal(i + 1)
                            'ws.Cells(intLinea, 27) = decTotDedEmp
                            'j = j + 1
                        Next
                    End If
                    'For i = 1 To 12
                    'If drCnf("PlanillasPorMes") = 1 Then
                    'ws.Cells(intLinea, i + 2) = decTotDedMes(i)
                    'ws.Cells(intLinea, 15) = decTotDedEmp
                    'ElseIf drCnf("PlanillasPorMes") = 2 Then
                    'ws.Cells(intLinea, i + 2 + j) = decTotDedQuincenal(i)
                    'ws.Cells(intLinea, i + 2 + j) = decTotDedQuincenal(i + 1)
                    'ws.Cells(intLinea, 27) = decTotDedEmp
                    'j = j + 1
                    'End If
                    'Next
                    intLinea = intLinea + 1
                    For k = 1 To 12
                        decTotDedMes(k) = 0
                    Next
                    For k = 1 To 25
                        decTotDedQuincenal(k) = 0
                    Next
                    SumarDatos()
                    strCodEmpleado = drDatos("CodigoEmpleado")
                    strNombre = drDatos("Nombre1") & IIf(String.IsNullOrEmpty(drDatos("Nombre2")), "", " " & drDatos("Nombre2")) _
                        & " " & drDatos("Apellido1") & IIf(String.IsNullOrEmpty(drDatos("Apellido2")), "", " " & drDatos("Apellido2"))
                Else
                    SumarDatos()
                    strCodEmpleado = drDatos("CodigoEmpleado")
                    strNombre = drDatos("Nombre1") & IIf(String.IsNullOrEmpty(drDatos("Nombre2")), "", " " & drDatos("Nombre2")) _
                        & " " & drDatos("Apellido1") & IIf(String.IsNullOrEmpty(drDatos("Apellido2")), "", " " & drDatos("Apellido2"))
                    'intSigElemento = intSigElemento + 1
                End If
            End If

            'ws.Range("B" & Trim(Str(intLinea))).Cells.NumberFormat = "@"
        End While
        cnSQLConexion.Close()
        excel.Visible = True
        wb.Close()
    End Sub
    Private Sub SumarDatos()
        If drCnf("PlanillasPorMes") = 1 Then
            decTotDedMes(drDatos("Mes")) = drDatos(strDeduccion)
        ElseIf drCnf("PlanillasPorMes") = 2 Then
            decTotDedQuincenal(CalcElemento()) = drDatos(strDeduccion)
        End If
    End Sub
    Private Function CalcElemento() As Int16
        If drDatos("Mes") = 1 Then
            If drDatos("NoPlanilla") = 1 Then
                CalcElemento = 1
            Else
                CalcElemento = 2
            End If
        ElseIf drDatos("Mes") = 2 Then
            If drDatos("NoPlanilla") = 1 Then
                CalcElemento = 3
            Else
                CalcElemento = 4
            End If
        ElseIf drDatos("Mes") = 3 Then
            If drDatos("NoPlanilla") = 1 Then
                CalcElemento = 5
            Else
                CalcElemento = 6
            End If
        ElseIf drDatos("Mes") = 4 Then
            If drDatos("NoPlanilla") = 1 Then
                CalcElemento = 7
            Else
                CalcElemento = 8
            End If
        ElseIf drDatos("Mes") = 5 Then
            If drDatos("NoPlanilla") = 1 Then
                CalcElemento = 9
            Else
                CalcElemento = 10
            End If
        ElseIf drDatos("Mes") = 6 Then
            If drDatos("NoPlanilla") = 1 Then
                CalcElemento = 11
            Else
                CalcElemento = 12
            End If
        ElseIf drDatos("Mes") = 7 Then
            If drDatos("NoPlanilla") = 1 Then
                CalcElemento = 13
            Else
                CalcElemento = 14
            End If
        ElseIf drDatos("Mes") = 8 Then
            If drDatos("NoPlanilla") = 1 Then
                CalcElemento = 15
            Else
                CalcElemento = 16
            End If
        ElseIf drDatos("Mes") = 9 Then
            If drDatos("NoPlanilla") = 1 Then
                CalcElemento = 17
            Else
                CalcElemento = 18
            End If
        ElseIf drDatos("Mes") = 10 Then
            If drDatos("NoPlanilla") = 1 Then
                CalcElemento = 19
            Else
                CalcElemento = 20
            End If
        ElseIf drDatos("Mes") = 11 Then
            If drDatos("NoPlanilla") = 1 Then
                CalcElemento = 21
            Else
                CalcElemento = 22
            End If
        ElseIf drDatos("Mes") = 12 Then
            If drDatos("NoPlanilla") = 1 Then
                CalcElemento = 23
            Else
                CalcElemento = 24
            End If
        End If
    End Function
End Class