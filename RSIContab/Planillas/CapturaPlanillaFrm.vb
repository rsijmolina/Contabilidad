Public Class CapturaPlanillaFrm
    Private _TipoPlanilla As String
    Dim PlCls As New PLClassLib.PlClass
    Dim lstEmplsFrm As New ListaEmpleadosFom
    Dim lstDedEmpFrm As New PLListaDedEmpFrm
    Dim drCnf As SqlClient.SqlDataReader
    Dim drDatosEmp As SqlClient.SqlDataReader
    Dim decNormalDevengado As Decimal, decTotalHorasExtras As Decimal, decTotalValHorasExtras As Decimal, decTotalOtrosIng As Decimal, decTotalDeducciones As Decimal, decTotalOtrasDeducciones As Decimal
    Dim mPlanillaEspecial As Boolean, mPlanillaCerrada As Boolean, AgregandoOtraDed As Boolean, mEsMedico As Boolean
    Public Property TipoPlanilla() As String
        Get
            TipoPlanilla = _TipoPlanilla
        End Get
        Set(ByVal value As String)
            _TipoPlanilla = value
        End Set
    End Property
    Private Sub CapturaPlanillaFrm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub CapturaPlanillaFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CapturaPlanillaDataSet.PLDepartamentos' Puede moverla o quitarla según sea necesario.
        Me.PLDepartamentosTableAdapter.Fill(Me.CapturaPlanillaDataSet.PLDepartamentos)
        PlCls.DBconStr = strcnCAD
        drCnf = PlCls.drConf
        mPlanillaCerrada = PlCls.PlanillaCerrada(drCnf("AñoEnProceso"), drCnf("MesEnProceso"), drCnf("NoPlanilla"))

        Me.PLBancosTableAdapter.Fill(Me.CapturaPlanillaDataSet.PLBancos)
        Me.PLSeccionesTableAdapter.Fill(Me.CapturaPlanillaDataSet.PLSecciones)
        Me.PLDepartamentosTableAdapter.Fill(Me.CapturaPlanillaDataSet.PLDepartamentos)
        Me.PLSedesTableAdapter.Fill(Me.CapturaPlanillaDataSet.PLSedes)

        Me.MdiParent = MDIPrincipal
        Me.Top = 10
        Me.Left = 10

        DataNavBarPrincipal.toolstriptextBuscar.ToolTipText = "Buscar por Código de Empleado"
        If mPlanillaCerrada Then
            statusstripPrincipal.Items("statusCerrado").Visible = True
            DataNavBarPrincipal.UsarBotonModificarRegistro = False
            DataNavBarPrincipal.UsarBotonEliminarRegistro = False
        End If
        btnBuscarEmpleado.Enabled = True

        '*** Configurar Otros Ingresos y Otras Deducciones ***
        If Not String.IsNullOrEmpty(drCnf("NombreIngreso1").ToString) Then
            lblIngreso1.Text = drCnf("NombreIngreso1")
            lblIngreso1.Visible = True
            c1numIngreso1.Visible = True
        End If
        If Not String.IsNullOrEmpty(drCnf("NombreIngreso2").ToString) Then
            lblIngreso2.Text = drCnf("NombreIngreso2")
            lblIngreso2.Visible = True
            c1numIngreso2.Visible = True
        End If
        If Not String.IsNullOrEmpty(drCnf("NombreIngreso3").ToString) Then
            lblIngreso3.Text = drCnf("NombreIngreso3")
            lblIngreso3.Visible = True
            c1numIngreso3.Visible = True
        End If
        If Not String.IsNullOrEmpty(drCnf("NombreIngreso4").ToString) Then
            lblIngreso4.Text = drCnf("NombreIngreso4")
            lblIngreso4.Visible = True
            c1numIngreso4.Visible = True
        End If
        If Not String.IsNullOrEmpty(drCnf("NombreIngreso5").ToString) Then
            lblIngreso5.Text = drCnf("NombreIngreso5")
            lblIngreso5.Visible = True
            c1numIngreso5.Visible = True
        End If
        If Not String.IsNullOrEmpty(drCnf("NombreDeduccion1").ToString) Then
            lblDeduccion1.Text = drCnf("NombreDeduccion1")
            lblDeduccion1.Visible = True
            c1numDeduccion1.Visible = True
        End If
        If Not String.IsNullOrEmpty(drCnf("NombreDeduccion2").ToString) Then
            lblDeduccion2.Text = drCnf("NombreDeduccion2")
            lblDeduccion2.Visible = True
            c1numDeduccion2.Visible = True
        End If
        If Not String.IsNullOrEmpty(drCnf("NombreDeduccion3").ToString) Then
            lblDeduccion3.Text = drCnf("NombreDeduccion3")
            lblDeduccion3.Visible = True
            c1numDeduccion3.Visible = True
        End If
        If Not String.IsNullOrEmpty(drCnf("NombreDeduccion4").ToString) Then
            lblDeduccion4.Text = drCnf("NombreDeduccion4")
            lblDeduccion4.Visible = True
            c1numDeduccion4.Visible = True
        End If
        If Not String.IsNullOrEmpty(drCnf("NombreDeduccion5").ToString) Then
            lblDeduccion5.Text = drCnf("NombreDeduccion5")
            lblDeduccion5.Visible = True
            c1numDeduccion5.Visible = True
        End If

        If drCnf("NoPlanilla") = drCnf("NoPlanillaVacaciones") Then
            _TipoPlanilla = "VAC"
            DataNavBarPrincipal.toolstripMensaje.Text = "Planilla de Vacaciones Año: " & drCnf("AñoEnProceso") & " Mes: " & drCnf("MesEnProceso")
            mPlanillaEspecial = True
        ElseIf drCnf("NoPlanilla") = drCnf("NoPlanillaComplementaria") Then
            _TipoPlanilla = "COMP"
            DataNavBarPrincipal.toolstripMensaje.Text = "Planilla Complementaria Año: " & drCnf("AñoEnProceso") & " Mes: " & drCnf("MesEnProceso")
            mPlanillaEspecial = True
        ElseIf drCnf("NoPlanilla") = drCnf("NoPlanilla13vo") Then
            _TipoPlanilla = "13VO"
            DataNavBarPrincipal.toolstripMensaje.Text = "Planilla 13VO Año: " & drCnf("AñoEnProceso") & " Mes: " & drCnf("MesEnProceso")
            mPlanillaEspecial = True
        ElseIf drCnf("NoPlanilla") = drCnf("NoPlanilla14vo") Then
            _TipoPlanilla = "14VO"
            DataNavBarPrincipal.toolstripMensaje.Text = "Planilla 14VO Año: " & drCnf("AñoEnProceso") & " Mes: " & drCnf("MesEnProceso")
            mPlanillaEspecial = True
        Else
            _TipoPlanilla = "ORD"
            DataNavBarPrincipal.toolstripMensaje.Text = "Planilla No. " & drCnf("NoPlanilla") & "/" & drCnf("PlanillasPorMes") & " Año: " & drCnf("AñoEnProceso") & " Mes: " & drCnf("MesEnProceso")
            mPlanillaEspecial = False
        End If
        If drCnf("NoPlanilla") = drCnf("NoPlanilla13vo") Or drCnf("NoPlanilla") = drCnf("NoPlanilla14vo") Then
            'c1numValDiasTrab.Enabled = True
            'c1numValDiasTrab.ReadOnly = False
            c1numValDiasTrab.Tag = "CM"
        End If

        CargarDatosPlanilla()

    End Sub
    Public Sub CargarDatosPlanilla()
        Me.PLPlanillasTableAdapter.Fill(Me.CapturaPlanillaDataSet.PLPlanillas, drCnf("AñoEnProceso"), drCnf("MesEnProceso"), drCnf("NoPlanilla"))
        DataNavBarPrincipal.Reinicializar()
    End Sub
    Private Sub CargarDetalleOtrasDed()

        Me.PLPlanillasOTTableAdapter.Fill(Me.CapturaPlanillaDataSet.PLPlanillasOT, drCnf("AñoEnProceso"), drCnf("MesEnProceso"), drCnf("NoPlanilla"), c1txtCodigoEmpleado.Text)
    End Sub

    Private Sub DataNavBarPrincipal_BuscarRegistroClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.BuscarRegistroClick
        Me.PLPlanillasTableAdapter.FillByCodigoEmpleado(Me.CapturaPlanillaDataSet.PLPlanillas, drCnf("AñoEnProceso"), drCnf("MesEnProceso"), drCnf("NoPlanilla"), DataNavBarPrincipal.toolstriptextBuscar.Text)
    End Sub

    Private Sub DataNavBarPrincipal_SalirClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.SalirClick
        Me.Close()
    End Sub

    Private Sub PrincipalBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrincipalBindingSource.PositionChanged
        Dim mDatos As DataRowView

        mDatos = PrincipalBindingSource.Current
        If Not IsNothing(mDatos) Then
            If Not DataNavBarPrincipal.NuevoRegistro Then
                drDatosEmp = PlCls.drDatosEmpleadoPlanilla(mDatos("CodigoEmpleado"))
                If drDatosEmp.HasRows Then
                    lblNombre.Text = drDatosEmp("Nombre1") & IIf(String.IsNullOrEmpty(drDatosEmp("Nombre2").ToString), "", " " & drDatosEmp("Nombre2")) & " " & drDatosEmp("Apellido1") & IIf(String.IsNullOrEmpty(drDatosEmp("Apellido2").ToString), "", " " & drDatosEmp("Apellido2"))
                    Me.PLPlanillasOTTableAdapter.Fill(Me.CapturaPlanillaDataSet.PLPlanillasOT, drCnf("AñoEnProceso"), drCnf("MesEnProceso"), drCnf("NoPlanilla"), mDatos("CodigoEmpleado"))
                    decNormalDevengado = mDatos("SueldoNormal") + mDatos("SueldoAdicionalFeriados") - mDatos("ValorHorasTarde")
                    decTotalHorasExtras = mDatos("HorasExtras25") + mDatos("HorasExtras50") + mDatos("HorasExtras75") + mDatos("HorasExtrasDobles")
                    decTotalValHorasExtras = mDatos("ValorHorasExtras25") + mDatos("ValorHorasExtras50") + mDatos("ValorHorasExtras75") + mDatos("ValorHorasExtrasDobles")
                    decTotalOtrosIng = mDatos("Comisiones") + mDatos("Bonificaciones") + mDatos("Transporte") + mDatos("Combustible") + mDatos("DepreciacionVehiculo") + mDatos("Vacaciones")
                    decTotalOtrosIng = decTotalOtrosIng + IIf(c1numIngreso1.Visible, mDatos("IngresosAdicionales1"), 0) + IIf(c1numIngreso2.Visible, mDatos("IngresosAdicionales2"), 0) + IIf(c1numIngreso3.Visible, mDatos("IngresosAdicionales3"), 0) + IIf(c1numIngreso4.Visible, mDatos("IngresosAdicionales4"), 0) + IIf(c1numIngreso5.Visible, mDatos("IngresosAdicionales5"), 0)
                    decTotalDeducciones = mDatos("SeguroSocial") + mDatos("RAP") + mDatos("ImpuestoVecinal") + mDatos("ImpuestoSobreRenta") + mDatos("INJUPEMP") + mDatos("INPREMA")
                    decTotalDeducciones = decTotalDeducciones + IIf(c1numDeduccion1.Visible, mDatos("DeduccionFija1"), 0) + IIf(c1numDeduccion2.Visible, mDatos("DeduccionFija2"), 0) + IIf(c1numDeduccion3.Visible, mDatos("DeduccionFija3"), 0) + IIf(c1numDeduccion4.Visible, mDatos("DeduccionFija4"), 0) + IIf(c1numDeduccion5.Visible, mDatos("DeduccionFija5"), 0)
                    mEsMedico = drDatosEmp("EsMedico")
                    If Not DataNavBarPrincipal.NuevoRegistro Then
                        TotalizarOtrasDed()
                    End If
                    lblNormalDevengado.Text = Format(decNormalDevengado, "#,##0.00")
                    lblTotHoras.Text = Format(decTotalHorasExtras, "#,##0.00")
                    lblTotHorasVal.Text = Format(decTotalValHorasExtras, "#,##0.00")
                    lblTotIngBruto.Text = Format(decNormalDevengado + decTotalValHorasExtras, "#,##0.00")
                    lblTotOtrosIng.Text = Format(decTotalOtrosIng, "#,##0.00")
                    lblTotDeducciones.Text = Format(decTotalDeducciones, "#,##0.00")
                    lblTotOtrasDed.Text = Format(decTotalOtrasDeducciones, "#,##0.00")
                    lblSueldoNeto.Text = Format(decNormalDevengado + decTotalValHorasExtras + decTotalOtrosIng - decTotalDeducciones - decTotalOtrasDeducciones, "#,##0.00")
                    If mDatos("Cerrado") Then
                        statusCerrado.Visible = True
                        c1truedbgrdOtrasDed.AllowAddNew = False
                        c1truedbgrdOtrasDed.AllowUpdate = False
                        c1truedbgrdOtrasDed.AllowDelete = False
                    Else
                        statusCerrado.Visible = False
                        c1truedbgrdOtrasDed.AllowAddNew = True
                        c1truedbgrdOtrasDed.AllowUpdate = True
                        c1truedbgrdOtrasDed.AllowDelete = True
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub c1txtCodigoEmpleado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1txtCodigoEmpleado.Validating
        Dim mDatos As DataRowView

        mDatos = PrincipalBindingSource.Current
        If DataNavBarPrincipal.NuevoRegistro Then
            drDatosEmp = PlCls.drDatosEmpleadoPlanilla(c1txtCodigoEmpleado.Text)
            If drDatosEmp.HasRows Then
                lblNombre.Text = drDatosEmp("Nombre1") & IIf(String.IsNullOrEmpty(drDatosEmp("Nombre2").ToString), "", " " & drDatosEmp("Nombre2")) & " " & drDatosEmp("Apellido1") & IIf(String.IsNullOrEmpty(drDatosEmp("Apellido2").ToString), "", " " & drDatosEmp("Apellido2"))
                mDatos("CodigoSede") = drDatosEmp("CodigoSede")
                mDatos("CodigoDepartamento") = drDatosEmp("CodigoDepartamento")
                mDatos("CodigoSeccion") = drDatosEmp("CodigoSeccion")
                mDatos("Banco") = drDatosEmp("Banco")
                mEsMedico = drDatosEmp("EsMedico")
                c1cmbSedes.SelectedValue = drDatosEmp("CodigoSede")
                c1cmbDepartamentos.SelectedValue = drDatosEmp("CodigoDepartamento")
                c1cmbSecciones.SelectedValue = drDatosEmp("CodigoSeccion")
                c1cmbBanco.SelectedValue = drDatosEmp("Banco")
                If _TipoPlanilla = "ORD" Or _TipoPlanilla = "VAC" Then
                    c1numDiasTrabajados.Value = 30 / drCnf("PlanillasPorMes")
                    c1numValDiasTrab.Value = Math.Round(drDatosEmp("SalarioMensual") / 30 * c1numDiasTrabajados.Value, 2)
                    CalcularNeto()
                End If
            Else
                drDatosEmp.Close()
                MsgBox("Empleado no Existe...", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub c1numDiasTrabajados_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numDiasTrabajados.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            If _TipoPlanilla = "ORD" Or _TipoPlanilla = "VAC" Then
                c1numValDiasTrab.Value = Math.Round(drDatosEmp("SalarioMensual") / 30 * c1numDiasTrabajados.Value, 2)
                CalcularNeto()
            End If
        End If
    End Sub
    Private Sub c1numDiasFeriados_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numDiasFeriados.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            c1numValDiasFeriados.Value = Math.Round(drDatosEmp("SalarioMensual") / 30 * c1numDiasFeriados.Value, 2)
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numHorasTarde_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numHorasTarde.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            If mEsMedico Then 'Para ZOE
                c1numValHorasTarde.Value = Math.Round(drDatosEmp("SalarioMensual") / 30 / 6 * c1numHorasTarde.Value, 2)
            Else
                c1numValHorasTarde.Value = Math.Round(drDatosEmp("SalarioMensual") / 30 / 8 * c1numHorasTarde.Value, 2)
            End If
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numExtras25_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numExtras25.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            If mEsMedico Then 'Para ZOE
                c1numValExtras25.Value = Math.Round(drDatosEmp("SalarioMensual") / 30 / 6 * c1numExtras25.Value * 1.25, 2)
            Else
                c1numValExtras25.Value = Math.Round(drDatosEmp("SalarioMensual") / 30 / 8 * c1numExtras25.Value * 1.25, 2)
            End If
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numExtras50_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numExtras50.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            If mEsMedico Then  'Para ZOE
                c1numValExtras50.Value = Math.Round(drDatosEmp("SalarioMensual") / 30 / 6 * c1numExtras50.Value * 1.5, 2)
            Else
                c1numValExtras50.Value = Math.Round(drDatosEmp("SalarioMensual") / 30 / 8 * c1numExtras50.Value * 1.5, 2)
            End If
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numExtras75_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numExtras75.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            If mEsMedico Then  'Para ZOE
                c1numValExtras75.Value = Math.Round(drDatosEmp("SalarioMensual") / 30 / 6 * c1numExtras75.Value * 1.75, 2)
            Else
                c1numValExtras75.Value = Math.Round(drDatosEmp("SalarioMensual") / 30 / 8 * c1numExtras75.Value * 1.75, 2)
            End If
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numExtrasDobles_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numExtrasDobles.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            If mEsMedico Then  'Para ZOE
                c1numValExtrasDobles.Value = Math.Round(drDatosEmp("SalarioMensual") / 30 / 6 * c1numExtrasDobles.Value * 2, 2)
            Else
                c1numValExtrasDobles.Value = Math.Round(drDatosEmp("SalarioMensual") / 30 / 8 * c1numExtrasDobles.Value * 2, 2)
            End If
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numComisiones_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numComisiones.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numBonificaciones_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numBonificaciones.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numTransporte_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numTransporte.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numCombustible_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numCombustible.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numDepreciacion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numDepreciacion.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numVacaciones_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numVacaciones.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numIngreso1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numIngreso1.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numIngreso2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numIngreso2.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numIngreso3_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numIngreso3.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numIngreso4_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numIngreso4.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numIngreso5_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numIngreso5.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numSeguroSocial_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numSeguroSocial.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numRAP_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRAP.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numImpVecinal_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numImpVecinal.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numImpRenta_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numImpRenta.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numINJUPEMP_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numINJUPEMP.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numINPREMA_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numINPREMA.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numDeduccion1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numDeduccion1.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numDeduccion2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numDeduccion2.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numDeduccion3_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numDeduccion3.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numDeduccion4_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numDeduccion4.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            CalcularNeto()
        End If
    End Sub
    Private Sub c1numDeduccion5_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numDeduccion5.Validating
        If DataNavBarPrincipal.NuevoRegistro Or DataNavBarPrincipal.ModificarRegistro Then
            CalcularNeto()
        End If
    End Sub
    Private Sub CalcularNeto()
        decNormalDevengado = CDec(c1numValDiasTrab.Text) + CDec(c1numValDiasFeriados.Text) - CDec(c1numValHorasTarde.Text)
        decTotalHorasExtras = CDec(c1numExtras25.Text) + CDec(c1numExtras50.Text) + CDec(c1numExtras75.Text) + CDec(c1numExtrasDobles.Text)
        decTotalValHorasExtras = CDec(c1numValExtras25.Text) + CDec(c1numValExtras50.Text) + CDec(c1numValExtras75.Text) + CDec(c1numValExtrasDobles.Text)
        decTotalOtrosIng = CDec(c1numComisiones.Text) + CDec(c1numBonificaciones.Text) + CDec(c1numTransporte.Text) + CDec(c1numCombustible.Text) + CDec(c1numDepreciacion.Text) + CDec(c1numVacaciones.Text)
        If c1numIngreso1.Visible Then
            decTotalOtrosIng = decTotalOtrosIng + CDec(c1numIngreso1.Text)
        End If
        If c1numIngreso2.Visible Then
            decTotalOtrosIng = decTotalOtrosIng + CDec(c1numIngreso2.Text)
        End If
        If c1numIngreso3.Visible Then
            decTotalOtrosIng = decTotalOtrosIng + CDec(c1numIngreso3.Text)
        End If
        If c1numIngreso4.Visible Then
            decTotalOtrosIng = decTotalOtrosIng + CDec(c1numIngreso4.Text)
        End If
        If c1numIngreso5.Visible Then
            decTotalOtrosIng = decTotalOtrosIng + CDec(c1numIngreso5.Text)
        End If

        decTotalDeducciones = CDec(c1numSeguroSocial.Text) + CDec(c1numRAP.Text) + CDec(c1numImpVecinal.Text) + CDec(c1numImpRenta.Text) + CDec(c1numINJUPEMP.Text) + CDec(c1numINPREMA.Text)
        If c1numDeduccion1.Visible Then
            decTotalDeducciones = decTotalDeducciones + CDec(c1numDeduccion1.Text)
        End If
        If c1numDeduccion2.Visible Then
            decTotalDeducciones = decTotalDeducciones + CDec(c1numDeduccion2.Text)
        End If
        If c1numDeduccion3.Visible Then
            decTotalDeducciones = decTotalDeducciones + CDec(c1numDeduccion3.Text)
        End If
        If c1numDeduccion4.Visible Then
            decTotalDeducciones = decTotalDeducciones + CDec(c1numDeduccion4.Text)
        End If
        If c1numDeduccion5.Visible Then
            decTotalDeducciones = decTotalDeducciones + CDec(c1numDeduccion5.Text)
        End If

        If Not DataNavBarPrincipal.NuevoRegistro Then
            TotalizarOtrasDed()
        End If
        lblNormalDevengado.Text = Format(decNormalDevengado, "#,##0.00")
        lblTotHoras.Text = Format(decTotalHorasExtras, "#,##0.00")
        lblTotHorasVal.Text = Format(decTotalValHorasExtras, "#,##0.00")
        lblTotIngBruto.Text = Format(decNormalDevengado + decTotalValHorasExtras, "#,##0.00")
        lblTotOtrosIng.Text = Format(decTotalOtrosIng, "#,##0.00")
        lblTotDeducciones.Text = Format(decTotalDeducciones, "#,##0.00")
        lblTotOtrasDed.Text = Format(decTotalOtrasDeducciones, "#,##0.00")
        lblSueldoNeto.Text = Format(decNormalDevengado + decTotalValHorasExtras + decTotalOtrosIng - decTotalDeducciones - decTotalOtrasDeducciones, "#,##0.00")
    End Sub
    Private Sub TotalizarOtrasDed()
        Dim i As Int16        

        decTotalOtrasDeducciones = 0
        For i = 0 To c1truedbgrdOtrasDed.RowCount - 1
            decTotalOtrasDeducciones = decTotalOtrasDeducciones + c1truedbgrdOtrasDed(i, "Valor")
        Next
    End Sub

    Private Sub btnBuscarEmpleado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscarEmpleado.Click
        If Not DataNavBarPrincipal.ModificarRegistro Then
            lstEmplsFrm.ShowDialog()
            If lstEmplsFrm.DialogResult = Windows.Forms.DialogResult.OK Then
                If Not DataNavBarPrincipal.NuevoRegistro Then
                    DataNavBarPrincipal.toolstriptextBuscar.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Empleado").Value
                    DataNavBarPrincipal_BuscarRegistroClick(Me, e)
                    DataNavBarPrincipal.toolstriptextPosicionReg.Text = PrincipalBindingSource.Position + 1 & "/" & PrincipalBindingSource.Count
                    Dim mDatos As DataRowView
                    mDatos = PrincipalBindingSource.Current
                    mEsMedico = drDatosEmp("EsMedico")
                Else
                    c1txtCodigoEmpleado.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Empleado").Value
                End If
            End If
        End If
    End Sub

    Private Sub btnCalcularDeducciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcularDeducciones.Click        
        Dim drLstDed As SqlClient.SqlDataReader
        Dim OpcCalcDedFrm As New OpcionesCalculoDedFrm

        drLstDed = PlCls.drListaDeducciones
        If Not String.IsNullOrEmpty(drCnf("NombreDeduccion1").ToString) Then
            OpcCalcDedFrm.chkboxDeduccion1.Visible = True
            OpcCalcDedFrm.chkboxDeduccion1.Text = drCnf("NombreDeduccion1")
        End If
        If Not String.IsNullOrEmpty(drCnf("NombreDeduccion2").ToString) Then
            OpcCalcDedFrm.chkboxDeduccion2.Visible = True
            OpcCalcDedFrm.chkboxDeduccion2.Text = drCnf("NombreDeduccion2")
        End If
        If Not String.IsNullOrEmpty(drCnf("NombreDeduccion3").ToString) Then
            OpcCalcDedFrm.chkboxDeduccion3.Visible = True
            OpcCalcDedFrm.chkboxDeduccion3.Text = drCnf("NombreDeduccion3")
        End If
        If Not String.IsNullOrEmpty(drCnf("NombreDeduccion4").ToString) Then
            OpcCalcDedFrm.chkboxDeduccion4.Visible = True
            OpcCalcDedFrm.chkboxDeduccion4.Text = drCnf("NombreDeduccion4")
        End If
        If Not String.IsNullOrEmpty(drCnf("NombreDeduccion5").ToString) Then
            OpcCalcDedFrm.chkboxDeduccion5.Visible = True
            OpcCalcDedFrm.chkboxDeduccion5.Text = drCnf("NombreDeduccion5")
        End If
        While drLstDed.Read
            OpcCalcDedFrm.CodigosDeducciones.Add(drLstDed("CodigoDeduccion"))
            OpcCalcDedFrm.chklstboxOtrasDed.Items.Add(drLstDed("DescripcionDeduccion"))
        End While
        OpcCalcDedFrm.EmpleadoActual = c1txtCodigoEmpleado.Value
        OpcCalcDedFrm.PlanillaEspecial = mPlanillaEspecial
        OpcCalcDedFrm.ShowDialog()
        CargarDatosPlanilla()
    End Sub
    Private Sub DataNavBarPrincipal_GuardarRegistroClick(ByVal sender As Object, ByVal e As System.EventArgs, ByRef Cancelar As Boolean) Handles DataNavBarPrincipal.GuardarRegistroClick
        Dim mDatos As DataRowView

        mDatos = PrincipalBindingSource.Current
        mDatos("Año") = drCnf("AñoEnProceso")
        mDatos("Mes") = drCnf("MesEnProceso")
        mDatos("NoPlanilla") = drCnf("NoPlanilla")
        DataNavBarPrincipal.ResultadoValidacion = ""
        DataNavBarPrincipal.ValidacionCorrecta = True
        DataNavBarPrincipal.ValidarInfo(Me)
        If DataNavBarPrincipal.ValidacionCorrecta = True Then
            Try
                Me.Validate()
                Me.PrincipalBindingSource.EndEdit()
                Me.PLPlanillasTableAdapter.Update(Me.CapturaPlanillaDataSet.PLPlanillas)
            Catch ex As Exception
                Cancelar = True
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Verifique los siguientes datos:" & vbCrLf & DataNavBarPrincipal.ResultadoValidacion)
        End If
    End Sub
    Private Sub DataNavBarPrincipal_EliminarRegistroClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.EliminarRegistroClick
        If mPlanillaCerrada Then
            MsgBox("Esta Planilla Ya Está Cerrada, No Pude Eliminar Este Registro", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If
        If MsgBox("Desea eliminar este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            PrincipalBindingSource.RemoveCurrent()
            Try
                Me.Validate()
                Me.PrincipalBindingSource.EndEdit()
                Me.PLPlanillasTableAdapter.Update(Me.CapturaPlanillaDataSet.PLPlanillas)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub c1truedbgrdOtrasDed_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdOtrasDed.AfterDelete
        Try
            Me.Validate()
            Me.OtrasDedBindingSource.EndEdit()
            Me.PLPlanillasOTTableAdapter.Update(Me.CapturaPlanillaDataSet.PLPlanillasOT)
            CalcularNeto()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PrincipalBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles PrincipalBindingSource.CurrentChanged

    End Sub

    Private Sub c1truedbgrdOtrasDed_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdOtrasDed.AfterUpdate
        Try
            Me.Validate()
            Me.OtrasDedBindingSource.EndEdit()
            Me.PLPlanillasOTTableAdapter.Update(Me.CapturaPlanillaDataSet.PLPlanillasOT)
            If AgregandoOtraDed Then
                Me.PLPlanillasOTTableAdapter.Fill(Me.CapturaPlanillaDataSet.PLPlanillasOT, drCnf("AñoEnProceso"), drCnf("MesEnProceso"), drCnf("NoPlanilla"), c1txtCodigoEmpleado.Value)
            End If
            CalcularNeto()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub c1truedbgrdOtrasDed_BeforeDelete(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1truedbgrdOtrasDed.BeforeDelete
        If MsgBox("Desea eliminar este dato ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub DataNavBarPrincipal_ModificarRegistroClick(ByVal sender As Object, ByVal e As System.EventArgs, ByRef Cancelar As Boolean) Handles DataNavBarPrincipal.ModificarRegistroClick
        If mPlanillaCerrada Then
            MsgBox("Esta Planilla ya está cerrada, no puede modificar los datos", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Cancelar = True
        End If
    End Sub

    Private Sub DataNavBarPrincipal_NuevoRegistroClick(ByVal sender As Object, ByVal e As System.EventArgs, ByRef Cancelar As Boolean) Handles DataNavBarPrincipal.NuevoRegistroClick
        If mPlanillaCerrada Then
            MsgBox("Esta Planilla ya está cerrada, no puede agregar datos", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Cancelar = True
        End If
    End Sub

    Private Sub c1truedbgrdOtrasDed_BeforeUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1truedbgrdOtrasDed.BeforeUpdate
        Dim mDatos As DataRowView

        mDatos = PrincipalBindingSource.Current

        c1truedbgrdOtrasDed.Columns("Año").Value = drCnf("AñoEnProceso")
        c1truedbgrdOtrasDed.Columns("Mes").Value = drCnf("MesEnProceso")
        c1truedbgrdOtrasDed.Columns("NoPlanilla").Value = drCnf("NoPlanilla")
        c1truedbgrdOtrasDed.Columns("CodigoSede").Value = mDatos("CodigoSede")
        c1truedbgrdOtrasDed.Columns("CodigoDepartamento").Value = mDatos("CodigoDepartamento")
        c1truedbgrdOtrasDed.Columns("CodigoSeccion").Value = mDatos("CodigoSeccion")
        c1truedbgrdOtrasDed.Columns("CodigoEmpleado").Value = mDatos("CodigoEmpleado")        
        If c1truedbgrdOtrasDed.AddNewMode = C1.Win.C1TrueDBGrid.AddNewModeEnum.AddNewPending Then
            c1truedbgrdOtrasDed.Columns("Fecha").Value = drCnf("FechaProceso")
            AgregandoOtraDed = True
        Else
            AgregandoOtraDed = False
        End If
        'If ExisteDed(c1truedbgrdOtrasDed.Columns("Deducción").Text, CInt(c1truedbgrdOtrasDed.Columns("No.").Text)) Then
        'e.Cancel = True
        'MsgBox("Esta deducción ya está ingresada...", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        'End If
    End Sub

    Private Sub c1truedbgrdOtrasDed_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles c1truedbgrdOtrasDed.ButtonClick
        lstDedEmpFrm.CodEmpleado = c1txtCodigoEmpleado.Text
        lstDedEmpFrm.CargarDatos()
        lstDedEmpFrm.ShowDialog()
        If lstDedEmpFrm.DialogResult = Windows.Forms.DialogResult.OK Then
            c1truedbgrdOtrasDed.Columns("Deducción").Value = lstDedEmpFrm.c1truedbgrdDedEmp.Columns("Deducción").Value
            c1truedbgrdOtrasDed.Columns("Fecha").Value = lstDedEmpFrm.c1truedbgrdDedEmp.Columns("Fecha").Value
            c1truedbgrdOtrasDed.Columns("No.").Value = lstDedEmpFrm.c1truedbgrdDedEmp.Columns("No").Value
            If drCnf("NoPlanilla") = 1 Then
                c1truedbgrdOtrasDed.Columns("Valor").Value = lstDedEmpFrm.c1truedbgrdDedEmp.Columns("Ded. PL. 1").Value
            Else
                c1truedbgrdOtrasDed.Columns("Valor").Value = lstDedEmpFrm.c1truedbgrdDedEmp.Columns("Ded. PL. 2").Value
            End If
            c1truedbgrdOtrasDed.Columns("Referencia").Value = lstDedEmpFrm.c1truedbgrdDedEmp.Columns("Referencia").Value
        End If
    End Sub
    Private Function ExisteDed(ByVal strCodDed As String, ByVal intNoDoc As Int32) As Boolean
        ExisteDed = False
        For Each mOtrasDed As DataRowView In OtrasDedBindingSource.List
            If mOtrasDed("CodigoDeduccion") = strCodDed And mOtrasDed("NoDocumento") = intNoDoc Then
                ExisteDed = True
            End If
        Next
    End Function

    Private Sub DataNavBarPrincipal_ReiniciarDatosClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.ReiniciarDatosClick
        DataNavBarPrincipal.toolstriptextBuscar.Text = ""
        CargarDatosPlanilla()
    End Sub
End Class