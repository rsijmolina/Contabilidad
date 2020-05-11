Public Class PLListadoEmpleadosFrm
    Dim lstEmplsFrm As New ListaEmpleadosFom
    Dim PlCls As New PLClassLib.PlClass
    Dim drCnf As SqlClient.SqlDataReader
    Dim arrCampos(23) As String
    Private Sub PLListadoEmpleadosFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PlCls.DBconStr = strcnCAD
        drCnf = PlCls.drConf        

        c1dateFecha.Value = Date.Now
        lstEmplsFrm.EmpleadosRetirados = False
        lstEmplsFrm.OrdenarPorCodigo = True
        btnBuscarEmpleadoIni.Enabled = True
        btnBuscarEmpleadoFinal.Enabled = True
        CargarCampos()
    End Sub

    Private Sub btnBuscarEmpleadoIni_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscarEmpleadoIni.Click
        lstEmplsFrm.ShowDialog()
        If lstEmplsFrm.DialogResult = Windows.Forms.DialogResult.OK Then
            c1txtEmpleadoIni.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("CodigoEmpleado").Value
            lblNombre1Ini.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre1").Value
            lblNombre2Ini.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre2").Value
            lblApellido1Ini.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido1").Value
            lblApellido2Ini.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido2").Value
        End If
    End Sub

    Private Sub btnBuscarEmpleadoFinal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscarEmpleadoFinal.Click
        lstEmplsFrm.ShowDialog()
        If lstEmplsFrm.DialogResult = Windows.Forms.DialogResult.OK Then
            c1txtEmpleadoFinal.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("CodigoEmpleado").Value
            lblNombre1Final.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre1").Value
            lblNombre2Final.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre2").Value
            lblApellido1Final.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido1").Value
            lblApellido2Final.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido2").Value
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim strSelCadena As String
        Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
        'rptClass.EjecutarListados(strcnCAD, "Sedes", My.Settings.RSIEmpresaActual)
        'strSQL = "SELECT OfCodigo_Ofrendante, OfTelefono_Casa, OfDireccion, Tipo_Ofrendantes_Tipo_Ofrendante, " _
        '    & "OfPrimer_Nombre + ' ' + ISNULL(OfSegundo_Nombre,'') + ' ' + ISNULL(OfPrimer_Apellido,'') + ' ' + ISNULL(OfSegundo_Apellido,'') AS Nombre From dbo.Ofrendantes ORDER BY Nombre"

        strSelCadena = ""
        If Not chkListarTodo.Checked Then
            If chkboxExcluirEmpRetirados.Checked Then
                strSelCadena = "{PLEmpleados.CodigoEmpleado}>='" & c1txtEmpleadoIni.Text & "' AND {PLEmpleados.CodigoEmpleado}<='" & c1txtEmpleadoFinal.Text & "' AND NOT {Empleados.RetiradoDeEmpresa}"
            Else
                strSelCadena = "{PLEmpleados.CodigoEmpleado}>='" & c1txtEmpleadoIni.Text & "' AND {PLEmpleados.CodigoEmpleado}<='" & c1txtEmpleadoFinal.Text & "'"
            End If
        Else
            If chkboxExcluirEmpRetirados.Checked Then
                strSelCadena = "NOT {Empleados.RetiradoDeEmpresa}"
            End If
        End If
        If chkboxExportarExcel.Checked Then
            ExportarExcel()
        Else
            rptClass.BaseDatosRpt = BaseDatosActual
            rptClass.EjecutarListadoEmpleados(strcnCAD, My.Settings.RSIEmpresaActual, chkListarTodo.Checked, strSelCadena, "", drCnf("UsarSedes"), drCnf("UsarDepartamentos"), drCnf("UsarSecciones"), c1dateFecha.Value)
        End If
    End Sub

    Private Sub btnBuscarEmpleadoIni_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarEmpleadoIni.Load

    End Sub
    Private Sub CargarCampos()
        chklstCampos.Items.Add("Sexo")
        arrCampos(0) = "Sexo"
        chklstCampos.Items.Add("Nacionalidad")
        arrCampos(1) = "Nacionalidad"
        chklstCampos.Items.Add("Lugar de Nacimiento")
        arrCampos(2) = "LugarNacimiento"
        chklstCampos.Items.Add("Fecha de Nacimiento")
        arrCampos(3) = "FechaNacimiento"
        chklstCampos.Items.Add("Direccion Actual")
        arrCampos(4) = "DireccionActual"
        chklstCampos.Items.Add("Telefono")
        arrCampos(5) = "Telefono"
        chklstCampos.Items.Add("Correo")
        arrCampos(6) = "Correo"
        chklstCampos.Items.Add("Nivel Académico")
        arrCampos(7) = "NivelAcademico"
        chklstCampos.Items.Add("Profesión")
        arrCampos(8) = "CodigoProfesion"
        chklstCampos.Items.Add("Estado Civil")
        arrCampos(9) = "EstadoCivil"
        chklstCampos.Items.Add("No de Dependientes")
        arrCampos(10) = "Dependientes"
        chklstCampos.Items.Add("Tipo de Sangre")
        arrCampos(11) = "TipoSangre"
        chklstCampos.Items.Add("No de Seguro Social")
        arrCampos(12) = "NoSeguroSocial"
        chklstCampos.Items.Add("No de RTN")
        arrCampos(13) = "NoRTN"
        chklstCampos.Items.Add("Puesto")
        arrCampos(14) = "CodigoPuesto"
        chklstCampos.Items.Add("Sede")
        arrCampos(15) = "CodigoSede"
        chklstCampos.Items.Add("Departamento")
        arrCampos(16) = "CodigoDepartamento"
        chklstCampos.Items.Add("Sección")
        arrCampos(17) = "CodigoSeccion"
        chklstCampos.Items.Add("Tipo de Empleado")
        arrCampos(18) = "TipoEmpleado"
        chklstCampos.Items.Add("Ingreso por Comisión")
        arrCampos(19) = "IngresoPorComision"
        chklstCampos.Items.Add("Salario Mensual")
        arrCampos(20) = "SalarioMensual"
        chklstCampos.Items.Add("Banco")
        arrCampos(21) = "Banco"
        chklstCampos.Items.Add("Cuenta del Banco")
        arrCampos(22) = "NoCuentaBancaria"
    End Sub
    Private Sub ExportarExcel()
        Dim i As Integer, intLinea As Integer, intCol As Integer, j As Integer
        Dim excel As Microsoft.Office.Interop.Excel.Application
        Dim wb As Microsoft.Office.Interop.Excel.Workbook
        Dim ws As Microsoft.Office.Interop.Excel.Worksheet

        Try
            Me.PLTiposEmpleadosTableAdapter.Fill(Me.PLEmpleadosExcelDataSet.PLTiposEmpleados)
            Me.PLProfesionesTableAdapter.Fill(Me.PLEmpleadosExcelDataSet.PLProfesiones)
            Me.PLPuestosTableAdapter.Fill(Me.PLEmpleadosExcelDataSet.PLPuestos)
            Me.PLSeccionesTableAdapter.Fill(Me.PLEmpleadosExcelDataSet.PLSecciones)
            Me.PLDepartamentosTableAdapter.Fill(Me.PLEmpleadosExcelDataSet.PLDepartamentos)
            Me.PLSedesTableAdapter.Fill(Me.PLEmpleadosExcelDataSet.PLSedes)
            If chkListarTodo.Checked Then   'Listar todos los empleados
                If chkboxExcluirEmpRetirados.Checked Then
                    Me.PLEmpleadosTableAdapter.FillByRetirados(Me.PLEmpleadosExcelDataSet.PLEmpleados, False)
                Else
                    Me.PLEmpleadosTableAdapter.Fill(Me.PLEmpleadosExcelDataSet.PLEmpleados)
                End If
            Else    'Listar por medio del rango inicial y final
                If chkboxExcluirEmpRetirados.Checked Then
                    Me.PLEmpleadosTableAdapter.FillByRangoEmpleadosRetirados(Me.PLEmpleadosExcelDataSet.PLEmpleados, c1txtEmpleadoIni.Text, c1txtEmpleadoFinal.Text, False)
                Else
                    Me.PLEmpleadosTableAdapter.FillByRangoEmpleados(Me.PLEmpleadosExcelDataSet.PLEmpleados, c1txtEmpleadoIni.Text, c1txtEmpleadoFinal.Text)
                End If
            End If

            excel = New Microsoft.Office.Interop.Excel.Application
            wb = excel.Workbooks.Add
            ws = wb.Worksheets(1)

            ws.Cells(1, 1) = My.Settings.RSIEmpresaInstalada
            ws.Cells(2, 1) = "Listado de Empleados"
            ws.Cells(3, 1) = "Nombre"
            ws.Cells(3, 2) = "Identidad"
            ws.Cells(3, 3) = "Fecha de Ingreso"
            intCol = 4
            For i = 0 To chklstCampos.Items.Count - 1
                If chklstCampos.GetItemCheckState(i) = CheckState.Checked Then
                    ws.Cells(3, intCol) = chklstCampos.Items(i)
                    intCol = intCol + 1
                End If
            Next

            intLinea = 4
            For Each mDataEmpleados As DataRowView In EmpleadosBindingSource.List
                ws.Cells(intLinea, 1) = mDataEmpleados("Nombre1") & " " & IIf(String.IsNullOrEmpty(mDataEmpleados("Nombre2").ToString), "", mDataEmpleados("Nombre2") & " ") & mDataEmpleados("Apellido1") & IIf(String.IsNullOrEmpty(mDataEmpleados("Apellido2").ToString), "", " " & mDataEmpleados("Apellido2"))
                ws.Cells(intLinea, 2) = mDataEmpleados("Identificacion1")
                ws.Cells(intLinea, 3) = mDataEmpleados("FechaIngreso")
                'Campos Adicionales
                intCol = 4
                For i = 0 To chklstCampos.Items.Count - 1
                    If chklstCampos.GetItemCheckState(i) = CheckState.Checked Then
                        Select Case chklstCampos.Items(i)
                            Case "Sede"
                                SedesBindingSource.Filter = "CodigoSede='" & mDataEmpleados("CodigoSede") & "'"
                                For Each mDato As DataRowView In SedesBindingSource.List
                                    ws.Cells(intLinea, intCol) = mDato("DescripcionSede")
                                Next
                            Case "Departamento"
                                DepartamentosBindingSource.Filter = "CodigoSede='" & mDataEmpleados("CodigoSede") & "' AND CodigoDepartamento='" & mDataEmpleados("CodigoDepartamento") & "'"
                                For Each mDato As DataRowView In DepartamentosBindingSource.List
                                    ws.Cells(intLinea, intCol) = mDato("DescripcionDepartamento")
                                Next
                            Case "Sección"
                                SeccionesBindingSource.Filter = "CodigoSede='" & mDataEmpleados("CodigoSede") & "' AND CodigoDepartamento='" & mDataEmpleados("CodigoDepartamento") & "' AND CodigoSeccion='" & mDataEmpleados("CodigoSeccion") & "'"
                                For Each mDato As DataRowView In SeccionesBindingSource.List
                                    ws.Cells(intLinea, intCol) = mDato("DescripcionSeccion")
                                Next
                            Case "Profesión"
                                ProfesionesBindingSource.Filter = "CodigoProfesion='" & mDataEmpleados("CodigoProfesion") & "'"
                                For Each mDato As DataRowView In ProfesionesBindingSource.List
                                    ws.Cells(intLinea, intCol) = mDato("DescripcionProfesion")
                                Next
                            Case "Puesto"
                                PuestosBindingSource.Filter = "CodigoPuesto='" & mDataEmpleados("CodigoPuesto") & "'"
                                For Each mDato As DataRowView In PuestosBindingSource.List
                                    ws.Cells(intLinea, intCol) = mDato("DescripcionPuesto")
                                Next
                            Case "Tipo de Empleado"
                                TiposEmpleadosBindingSource.Filter = "CodigoTipoEmpleado='" & mDataEmpleados("CodigoTipoEmpleado") & "'"
                                For Each mDato As DataRowView In TiposEmpleadosBindingSource.List
                                    ws.Cells(intLinea, intCol) = mDato("DescripcionTipoEmpleado")
                                Next
                            Case "Nivel Académico"
                                If mDataEmpleados("NivelAcademico") = 1 Then
                                    ws.Cells(intLinea, intCol) = "Primaria"
                                ElseIf mDataEmpleados("NivelAcademico") = 2 Then
                                    ws.Cells(intLinea, intCol) = "Media"
                                ElseIf mDataEmpleados("NivelAcademico") = 3 Then
                                    ws.Cells(intLinea, intCol) = "Técnico"
                                ElseIf mDataEmpleados("NivelAcademico") = 4 Then
                                    ws.Cells(intLinea, intCol) = "Superior"
                                End If
                            Case Else
                                ws.Cells(intLinea, intCol) = mDataEmpleados(arrCampos(i))
                        End Select
                        intCol = intCol + 1
                    End If
                Next
                intLinea = intLinea + 1
            Next
            excel.Visible = True
            wb.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class