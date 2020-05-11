Public Class DeduccionISRFrm
    Dim PlCls As New PLClassLib.PlClass
    Dim lstEmplsFrm As New ListaEmpleadosFom
    Dim drCnf As SqlClient.SqlDataReader    
    Dim decTotSueldos As Decimal, decTotOtrosIng As Decimal, decTotRetenidosPL1 As Decimal, decTotRetenidosPL2 As Decimal, decTotalDeducible As Decimal, decTotalRetencion As Decimal
    Private Sub DeduccionISRFrm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.PageDown
                DataNavBarPrincipal.toolstripbutSiguienteRegistro.PerformClick()
            Case Keys.PageUp
                DataNavBarPrincipal.toolstripbutRegistroAnterior.PerformClick()
            Case Keys.Home
                DataNavBarPrincipal.toolstripbutPrimerRegistro.PerformClick()
            Case Keys.End
                DataNavBarPrincipal.toolstripbutUltimoRegistro.PerformClick()
        End Select

        If e.Control = True Then
            Select Case e.KeyCode
                Case Keys.N
                    DataNavBarPrincipal.toolstripbutNuevoRegistro.PerformClick()
                Case Keys.G
                    DataNavBarPrincipal.toolstripbutGuardarRegistro.PerformClick()
                Case Keys.Z
                    DataNavBarPrincipal.toolstripbutCancelarGuardar.PerformClick()
                Case Keys.M
                    DataNavBarPrincipal.toolstripbutModificarRegistro.PerformClick()
                Case Keys.E
                    DataNavBarPrincipal.toolstripbutEliminarRegistro.PerformClick()
                Case Keys.A
                    DataNavBarPrincipal.toolstripbutAnularDocumento.PerformClick()
                Case Keys.F
                    DataNavBarPrincipal.toolstripbutCerrarDocumento.PerformClick()
                Case Keys.T
                    DataNavBarPrincipal.toolstripbutContabilizar.PerformClick()
                Case Keys.B
                    DataNavBarPrincipal.toolstripbutBuscar.PerformClick()
                Case Keys.R
                    DataNavBarPrincipal.toolstripbutReiniciarDatos.PerformClick()
                Case Keys.S
                    DataNavBarPrincipal.toolstripbutSalir.PerformClick()
            End Select
        End If
    End Sub

    Private Sub DeduccionISRFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PlCls.DBconStr = strcnCAD
        drCnf = PlCls.drConf

        Me.PLDeduccionISRTableAdapter.Fill(Me.PLDeduccionISRDataSet.PLDeduccionISR, drCnf("AñoEnProceso"))
        Me.PLTablaISRTableAdapter.Fill(Me.PLDeduccionISRDataSet.PLTablaISR)

        Me.MdiParent = MDIPrincipal
        Me.Top = 10
        Me.Left = 10
        DataNavBarPrincipal.toolstripMensaje.Text = "Año: " & drCnf("AñoEnProceso")
        DataNavBarPrincipal.toolstriptextBuscar.ToolTipText = "Buscar por Código de Empleado"
        btnBuscarEmpleado.Enabled = True
        If PrincipalBindingSource.Count > 0 Then
            Totalizar()
        End If
    End Sub
    Private Sub c1txtCodigoEmpleado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1txtCodigoEmpleado.Validating
        Dim mDatos As DataRowView
        Dim drDatosEmp As SqlClient.SqlDataReader

        mDatos = PrincipalBindingSource.Current
        If DataNavBarPrincipal.NuevoRegistro Then
            drDatosEmp = PlCls.drDatosEmpleadoPlanilla(c1txtCodigoEmpleado.Text)
            If drDatosEmp.HasRows Then
                lblNombre.Text = drDatosEmp("Nombre1") & IIf(String.IsNullOrEmpty(drDatosEmp("Nombre2").ToString), "", " " & drDatosEmp("Nombre2")) & " " & drDatosEmp("Apellido1") & IIf(String.IsNullOrEmpty(drDatosEmp("Apellido2").ToString), "", " " & drDatosEmp("Apellido2"))
                If DataNavBarPrincipal.NuevoRegistro Then
                    c1numSueldoMes1.Value = drDatosEmp("SalarioMensual")
                    c1numSueldoMes2.Value = drDatosEmp("SalarioMensual")
                    c1numSueldoMes3.Value = drDatosEmp("SalarioMensual")
                    c1numSueldoMes4.Value = drDatosEmp("SalarioMensual")
                    c1numSueldoMes5.Value = drDatosEmp("SalarioMensual")
                    c1numSueldoMes6.Value = drDatosEmp("SalarioMensual")
                    c1numSueldoMes7.Value = drDatosEmp("SalarioMensual")
                    c1numSueldoMes8.Value = drDatosEmp("SalarioMensual")
                    c1numSueldoMes9.Value = drDatosEmp("SalarioMensual")
                    c1numSueldoMes10.Value = drDatosEmp("SalarioMensual")
                    c1numSueldoMes11.Value = drDatosEmp("SalarioMensual")
                    c1numSueldoMes12.Value = drDatosEmp("SalarioMensual")
                    c1numNoMesesRetener.Value = 12
                End If
            Else
                drDatosEmp.Close()
                MsgBox("Empleado no Existe...", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub btnBuscarEmpleado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscarEmpleado.Click
        If Not DataNavBarPrincipal.ModificarRegistro Then
            lstEmplsFrm.ShowDialog()
            If lstEmplsFrm.DialogResult = Windows.Forms.DialogResult.OK Then
                If Not DataNavBarPrincipal.NuevoRegistro Then
                    DataNavBarPrincipal.toolstriptextBuscar.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Empleado").Value
                    Me.PLDeduccionISRTableAdapter.FillByCodigoEmpleado(Me.PLDeduccionISRDataSet.PLDeduccionISR, drCnf("AñoEnProceso"), DataNavBarPrincipal.toolstriptextBuscar.Text)
                    'DataNavBarPrincipal_BuscarRegistroClick(Me, e)
                    DataNavBarPrincipal.toolstriptextPosicionReg.Text = PrincipalBindingSource.Position + 1 & "/" & PrincipalBindingSource.Count
                    Totalizar()
                Else
                    c1txtCodigoEmpleado.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Empleado").Value
                End If
            End If
        End If
    End Sub
    Private Sub DataNavBarPrincipal_BuscarRegistroClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.BuscarRegistroClick
        Me.PLDeduccionISRTableAdapter.FillByCodigoEmpleado(Me.PLDeduccionISRDataSet.PLDeduccionISR, drCnf("AñoEnProceso"), DataNavBarPrincipal.toolstriptextBuscar.Text)
    End Sub
    Private Sub PrincipalBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrincipalBindingSource.PositionChanged
        Dim mDatos As DataRowView
        Dim drDatosEmp As SqlClient.SqlDataReader

        mDatos = PrincipalBindingSource.Current
        If Not IsNothing(mDatos) Then
            If Not DataNavBarPrincipal.NuevoRegistro Then
                drDatosEmp = PlCls.drDatosEmpleadoPlanilla(mDatos("CodigoEmpleado"))
                If drDatosEmp.HasRows Then
                    lblNombre.Text = drDatosEmp("Nombre1") & IIf(String.IsNullOrEmpty(drDatosEmp("Nombre2").ToString), "", " " & drDatosEmp("Nombre2")) & " " & drDatosEmp("Apellido1") & IIf(String.IsNullOrEmpty(drDatosEmp("Apellido2").ToString), "", " " & drDatosEmp("Apellido2"))
                End If
                Totalizar()
            End If
        End If
    End Sub
    Private Sub DataNavBarPrincipal_GuardarRegistroClick(ByVal sender As Object, ByVal e As System.EventArgs, ByRef Cancelar As Boolean) Handles DataNavBarPrincipal.GuardarRegistroClick
        Dim mDatos As DataRowView

        mDatos = PrincipalBindingSource.Current
        mDatos("Año") = drCnf("AñoEnProceso")
        DataNavBarPrincipal.ResultadoValidacion = ""
        DataNavBarPrincipal.ValidacionCorrecta = True
        DataNavBarPrincipal.ValidarInfo(Me)
        If DataNavBarPrincipal.ValidacionCorrecta = True Then
            Try
                Me.Validate()
                Me.PrincipalBindingSource.EndEdit()
                Me.PLDeduccionISRTableAdapter.Update(Me.PLDeduccionISRDataSet.PLDeduccionISR)
            Catch ex As Exception
                Cancelar = True
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Verifique los siguientes datos:" & vbCrLf & DataNavBarPrincipal.ResultadoValidacion)
        End If
    End Sub
    Private Sub DataNavBarPrincipal_EliminarRegistroClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.EliminarRegistroClick
        If MsgBox("Desea eliminar este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            PrincipalBindingSource.RemoveCurrent()
            Try
                Me.Validate()
                Me.PrincipalBindingSource.EndEdit()
                Me.PLDeduccionISRTableAdapter.Update(Me.PLDeduccionISRDataSet.PLDeduccionISR)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub c1truedbgrdTablaISR_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdTablaISR.AfterDelete
        Try
            Me.Validate()
            Me.PrincipalBindingSource.EndEdit()
            Me.PLTablaISRTableAdapter.Update(Me.PLDeduccionISRDataSet.PLTablaISR)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub c1truedbgrdTablaISR_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdTablaISR.AfterUpdate
        Try
            Me.Validate()
            Me.PrincipalBindingSource.EndEdit()
            Me.PLTablaISRTableAdapter.Update(Me.PLDeduccionISRDataSet.PLTablaISR)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub c1truedbgrdTablaISR_BeforeDelete(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1truedbgrdTablaISR.BeforeDelete
        If MsgBox("Desea Eliminar de la Tabla Este Dato?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub
    Private Sub DataNavBarPrincipal_SalirClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.SalirClick
        Me.Close()
    End Sub
    Private Sub Totalizar()
        Dim i As Int16
        Dim mDatos As DataRowView

        mDatos = PrincipalBindingSource.Current
        decTotSueldos = 0
        decTotOtrosIng = 0
        decTotRetenidosPL1 = 0
        decTotRetenidosPL2 = 0
        For i = 1 To 12
            decTotSueldos = decTotSueldos + mDatos("SueldoMes" & Trim(Str(i)))
            decTotOtrosIng = decTotOtrosIng + mDatos("OtrosIngresosMes" & Trim(Str(i)))
            decTotRetenidosPL1 = decTotRetenidosPL1 + mDatos("DeduccionPlanilla1_" & Trim(Str(i)))
            decTotRetenidosPL2 = decTotRetenidosPL2 + mDatos("DeduccionPlanilla2_" & Trim(Str(i)))
        Next
        decTotSueldos = decTotSueldos + mDatos("Ingreso13vo")
        decTotSueldos = decTotSueldos + mDatos("Ingreso14vo")
        decTotalDeducible = mDatos("GastosMedicos") + mDatos("SeguroSocial") + mDatos("Donaciones") + mDatos("OtrosDescuentos")
        decTotalRetencion = mDatos("Porcentaje1") + mDatos("Porcentaje2") + mDatos("Porcentaje3")

        lblTotalSueldos.Text = Format(decTotSueldos, "#,##0.00")
        lblTotIngAdicionales.Text = Format(decTotOtrosIng, "#,##0.00")
        lblTotalRetenidoPL1.Text = Format(decTotRetenidosPL1, "#,##0.00")
        lblTotalDeducibles.Text = Format(decTotalDeducible, "#,##0.00")
        lblTotalRetencion.Text = Format(decTotalRetencion, "#,##0.00")
        lblTotalRetenidoPL2.Text = Format(decTotRetenidosPL2, "#,##0.00")
        lblTotalPorRetener.Text = Format(decTotalRetencion - decTotRetenidosPL1 - decTotRetenidosPL2, "#,##0.00")
    End Sub

    Private Sub PrincipalBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrincipalBindingSource.CurrentChanged

    End Sub

    Private Sub btnCalcularISR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcularISR.Click
        Dim decIngAnualEstimado As Decimal, decMontoResidual As Decimal, decValorAcum As Decimal, decTramo As Decimal
        Dim decPorc(5) As Decimal
        Dim i As Int16

        decIngAnualEstimado = c1numSueldoMes1.Value + c1numSueldoMes2.Value + c1numSueldoMes3.Value + c1numSueldoMes4.Value + c1numSueldoMes5.Value + c1numSueldoMes6.Value
        decIngAnualEstimado = decIngAnualEstimado + c1numSueldoMes7.Value + c1numSueldoMes8.Value + c1numSueldoMes9.Value + c1numSueldoMes10.Value + c1numSueldoMes11.Value + c1numSueldoMes12.Value + c1num13vo.Value + c1num14vo.Value
        decIngAnualEstimado = decIngAnualEstimado + c1numIngAdicMes1.Value + c1numIngAdicMes2.Value + c1numIngAdicMes3.Value + c1numIngAdicMes4.Value + c1numIngAdicMes5.Value + c1numIngAdicMes6.Value
        decIngAnualEstimado = decIngAnualEstimado + c1numIngAdicMes7.Value + c1numIngAdicMes8.Value + c1numIngAdicMes9.Value + c1numIngAdicMes10.Value + c1numIngAdicMes11.Value + c1numIngAdicMes12.Value
        decIngAnualEstimado = decIngAnualEstimado - c1numGastosMedicos.Value - c1numSeguroSocial.Value - c1numDonaciones.Value - c1numOtros.Value
        decMontoResidual = decIngAnualEstimado

        For i = 0 To 4
            decPorc(i) = 0
        Next
        For i = 0 To c1truedbgrdTablaISR.RowCount - 1
            c1truedbgrdTablaISR.Row = i
            If decMontoResidual <= 0 Then 'c1truedbgrdTablaISR.Columns("Valor Inicial").Value Then
                Exit For
            End If
            decTramo = c1truedbgrdTablaISR.Columns("Valor Final").Value - Math.Round(c1truedbgrdTablaISR.Columns("Valor Inicial").Value, 2)
            If decTramo <= decMontoResidual Then
                decValorAcum = decValorAcum + (Math.Round(decTramo * (c1truedbgrdTablaISR.Columns("%").Value / 100), 2))
                decPorc(i) = Math.Round(decTramo * (c1truedbgrdTablaISR.Columns("%").Value / 100), 2)
            End If
            If decTramo > decMontoResidual Then
                decValorAcum = decValorAcum + (Math.Round(decMontoResidual * (c1truedbgrdTablaISR.Columns("%").Value / 100), 2))
                decPorc(i) = Math.Round(decMontoResidual * (c1truedbgrdTablaISR.Columns("%").Value / 100), 2)
            End If
            decMontoResidual = decMontoResidual - decTramo
            'decMontoResidual = decMontoResidual - c1truedbgrdTablaISR.Columns("Valor Final").Value
        Next
        c1numRango1.Value = decPorc(1)
        c1numRango2.Value = decPorc(2)
        c1numRango3.Value = decPorc(3)

    End Sub

    Private Sub butTotalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butTotalizar.Click
        TotalizarEdicion()
    End Sub

    Private Sub c1numSueldoMes1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numSueldoMes1.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numSueldoMes2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numSueldoMes2.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numSueldoMes3_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numSueldoMes3.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numSueldoMes4_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numSueldoMes4.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numSueldoMes5_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numSueldoMes5.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numSueldoMes6_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numSueldoMes6.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numSueldoMes7_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numSueldoMes7.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numSueldoMes8_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numSueldoMes8.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numSueldoMes9_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numSueldoMes9.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numSueldoMes10_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numSueldoMes10.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numSueldoMes11_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numSueldoMes11.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numSueldoMes12_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numSueldoMes12.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1num13vo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1num13vo.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1num14vo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1num14vo.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numIngAdicMes1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numIngAdicMes1.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numIngAdicMes2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numIngAdicMes2.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numIngAdicMes3_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numIngAdicMes3.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numIngAdicMes4_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numIngAdicMes4.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numIngAdicMes5_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numIngAdicMes5.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numIngAdicMes6_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numIngAdicMes6.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numIngAdicMes7_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numIngAdicMes7.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numIngAdicMes8_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numIngAdicMes8.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numIngAdicMes9_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numIngAdicMes9.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numIngAdicMes10_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numIngAdicMes10.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numIngAdicMes11_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numIngAdicMes11.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numIngAdicMes12_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numIngAdicMes12.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub

    Private Sub c1numRetenidoMes1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL1_1.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoMes2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL1_2.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoMes3_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL1_3.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoMes4_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL1_4.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoMes5_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL1_5.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoMes6_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL1_6.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoMes7_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL1_7.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoMes8_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL1_8.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoMes9_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL1_9.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoMes10_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL1_10.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoMes11_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL1_11.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoMes12_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL1_12.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoPL2_1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL2_1.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoPL2_2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL2_2.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoPL2_3_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL2_3.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoPL2_4_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL2_4.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoPL2_5_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL2_5.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoPL2_6_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL2_6.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoPL2_7_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL2_7.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoPL2_8_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL2_8.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoPL2_9_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL2_9.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoPL2_10_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL2_10.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoPL2_11_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL2_11.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRetenidoPL2_12_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRetenidoPL2_12.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numGastosMedicos_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numGastosMedicos.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numSeguroSocial_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numSeguroSocial.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numDonaciones_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numDonaciones.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numOtros_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numOtros.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRango1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRango1.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRango2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRango2.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub c1numRango3_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRango3.Validating
        If DataNavBarPrincipal.ModificarRegistro Or DataNavBarPrincipal.NuevoRegistro Then
            TotalizarEdicion()
        End If
    End Sub
    Private Sub TotalizarEdicion()
        decTotSueldos = c1numSueldoMes1.Value + c1numSueldoMes2.Value + c1numSueldoMes3.Value + c1numSueldoMes4.Value + c1numSueldoMes5.Value + c1numSueldoMes6.Value + c1numSueldoMes7.Value
        decTotSueldos = decTotSueldos + c1numSueldoMes8.Value + c1numSueldoMes9.Value + c1numSueldoMes10.Value + c1numSueldoMes11.Value + c1numSueldoMes12.Value + c1num13vo.Value + c1num14vo.Value

        decTotOtrosIng = c1numIngAdicMes1.Value + c1numIngAdicMes2.Value + c1numIngAdicMes3.Value + c1numIngAdicMes4.Value + c1numIngAdicMes5.Value + c1numIngAdicMes6.Value + c1numIngAdicMes7.Value
        decTotOtrosIng = decTotOtrosIng + c1numIngAdicMes8.Value + c1numIngAdicMes9.Value + c1numIngAdicMes10.Value + c1numIngAdicMes11.Value + c1numIngAdicMes12.Value

        decTotRetenidosPL1 = c1numRetenidoPL1_1.Value + c1numRetenidoPL1_2.Value + c1numRetenidoPL1_3.Value + c1numRetenidoPL1_4.Value + c1numRetenidoPL1_5.Value + c1numRetenidoPL1_6.Value + c1numRetenidoPL1_7.Value
        decTotRetenidosPL1 = decTotRetenidosPL1 + c1numRetenidoPL1_8.Value + c1numRetenidoPL1_9.Value + c1numRetenidoPL1_10.Value + c1numRetenidoPL1_11.Value + c1numRetenidoPL1_12.Value
        decTotRetenidosPL2 = c1numRetenidoPL2_1.Value + c1numRetenidoPL2_2.Value + c1numRetenidoPL2_3.Value + c1numRetenidoPL2_4.Value + c1numRetenidoPL2_5.Value + c1numRetenidoPL2_6.Value + c1numRetenidoPL2_7.Value
        decTotRetenidosPL2 = decTotRetenidosPL2 + c1numRetenidoPL2_8.Value + c1numRetenidoPL2_9.Value + c1numRetenidoPL2_10.Value + c1numRetenidoPL2_11.Value + c1numRetenidoPL2_12.Value

        decTotalDeducible = c1numGastosMedicos.Value + c1numSeguroSocial.Value + c1numDonaciones.Value + c1numOtros.Value
        decTotalRetencion = c1numRango1.Value + c1numRango2.Value + c1numRango3.Value

        lblTotalSueldos.Text = Format(decTotSueldos, "#,##0.00")
        lblTotIngAdicionales.Text = Format(decTotOtrosIng, "#,##0.00")
        lblTotalRetenidoPL1.Text = Format(decTotRetenidosPL1, "#,##0.00")
        lblTotalDeducibles.Text = Format(decTotalDeducible, "#,##0.00")
        lblTotalRetenidoPL2.Text = Format(decTotRetenidosPL2, "#,##0.00")
        lblTotalRetencion.Text = Format(decTotalRetencion, "#,##0.00")
        lblTotalPorRetener.Text = Format(decTotalRetencion - decTotRetenidosPL1 - decTotRetenidosPL2, "#,##0.00")
    End Sub

    Private Sub DataNavBarPrincipal_ReiniciarDatosClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.ReiniciarDatosClick
        DataNavBarPrincipal.toolstriptextBuscar.Text = ""
        Me.PLDeduccionISRTableAdapter.Fill(Me.PLDeduccionISRDataSet.PLDeduccionISR, drCnf("AñoEnProceso"))
    End Sub

    Private Sub DataNavBarPrincipal_NuevoRegistroClick(ByVal sender As Object, ByVal e As System.EventArgs, ByRef Cancelar As Boolean) Handles DataNavBarPrincipal.NuevoRegistroClick
        lblNombre.Text = ""
    End Sub

    Private Sub btnBuscarEmpleado_Load(sender As System.Object, e As System.EventArgs) Handles btnBuscarEmpleado.Load

    End Sub
End Class