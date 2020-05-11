Public Class PLPrestacionesFrm
    Dim PlCls As New PLClassLib.PlClass
    Dim drConfPlani As SqlClient.SqlDataReader
    Dim drDefDed As SqlClient.SqlDataReader
    Dim drDatosEmp As SqlClient.SqlDataReader
    Dim drDatosPlani As SqlClient.SqlDataReader
    Dim drDedsPendientes As SqlClient.SqlDataReader
    Dim drDatosSedes As SqlClient.SqlDataReader
    Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
    Dim RSICls As New Rsierpgencl.Rsierpcl.Cadenas
    Dim lstEmplsFrm As New ListaEmpleadosFom
    Dim lstDefDedFrm As New ListasFrm
    Dim decTotHorasExtras As Decimal, decTotBonificaciones As Decimal, decTotSueldoNormal As Decimal, decTotDeducciones As Decimal, decTotEgresos As Decimal
    'Dim intDiasProp13_14vo As Int16, intMesesProp13_14vo As Int16, intAñosProp13_14vo As Int16
    Dim intDiasAntiguedad As Int16, intMesesAntiguedad As Int16, intAñosAntiguedad As Int16


    Private Sub PLPrestacionesFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIPrincipal
        Me.Top = 10
        Me.Left = 10

        PlCls.DBconStr = strcnCAD
        drConfPlani = PlCls.drConf
        rptClass.BaseDatosRpt = BaseDatosActual
        lstEmplsFrm.ListarTodos = True
        lstEmplsFrm.OrdenarPorCodigo = False
        btnBuscarEmpleado.Enabled = True
        lblNombreEmpleado.Text = ""
        lstDefDedFrm.NombreLista = "Deducciones"
        lstDefDedFrm.Condicion = "Desactivada=0"
        InicializarDatos()
        'lblFechaIngreso.Text = ""

    End Sub
    Private Sub btnBuscarEmpleado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscarEmpleado.Click
        lstEmplsFrm.ShowDialog()
        If lstEmplsFrm.DialogResult = Windows.Forms.DialogResult.OK Then
            c1txtCodigoEmpleado.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("CodigoEmpleado").Value
            lblNombreEmpleado.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre1").Value & IIf(String.IsNullOrEmpty(lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre2").Value), "", " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre2").Value) _
                & " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido1").Value & IIf(String.IsNullOrEmpty(lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido2").Value), "", " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido2").Value)
        End If
    End Sub

    Private Sub c1txtCodigoEmpleado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1txtCodigoEmpleado.Validating
        If Not String.IsNullOrEmpty(c1txtCodigoEmpleado.Text) Then
            drDatosEmp = PlCls.drDatosEmpleadoPlanilla(c1txtCodigoEmpleado.Text)
            If drDatosEmp.HasRows Then
                lblNombreEmpleado.Text = drDatosEmp("Nombre1") & IIf(String.IsNullOrEmpty(drDatosEmp("Nombre2")), "", " " & drDatosEmp("Nombre2")) _
                    & " " & drDatosEmp("Apellido1") & IIf(String.IsNullOrEmpty(drDatosEmp("Apellido2")), "", " " & drDatosEmp("Apellido2"))
                c1dateFechaIngreso.Value = drDatosEmp("FechaIngreso")
                If PlCls.ExisteCalculoPrestaciones(c1txtCodigoEmpleado.Text) Then
                    EditarDatos()
                Else
                    AgregarDatos()
                End If
            Else
                MsgBox("Empleado No Exsite", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            End If
        End If
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub toolstripbutNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutNuevo.Click
        InicializarDatos()
    End Sub
    Private Sub InicializarDatos()
        c1txtCodigoEmpleado.ReadOnly = False
        c1txtCodigoEmpleado.Text = ""
        c1dateFechaIngreso.Text = Date.Now
        lblNombreEmpleado.Text = ""
        c1dateFechaRetiro.Value = Date.Now
        c1txtObservaciones.Text = ""
        lblTotal.Text = "0.00"
        lblTotalBonificaciones.Text = "0.00"
        lblTotalHorasExtras.Text = "0.00"
        lblTotalPrestaciones.Text = "0.00"
        lblTotalSueldoNormal.Text = "0.00"
        c1num13voProporcional.Value = 0
        c1num14voProporcional.Value = 0
        c1numCesantia.Value = 0
        c1numCesantiaProporcional.Value = 0
        c1numDiasPendientes.Value = 0
        c1numDiasProp13vo.Value = 0
        c1numDiasProp14vo.Value = 0
        c1numDiasPropVacaciones.Value = 0
        c1numHorasExtras.Value = 0
        c1numImpuestoVecinal.Value = 0
        c1numPreaviso.Value = 0
        c1numRAP.Value = 0
        c1numSalarioPromedio.Value = 0
        c1numSalarioPromedioDiario.Value = 0
        c1numSeguroSocial.Value = 0
        c1numSueldoBaseDiario.Value = 0
        c1numSueldoBaseMensual.Value = 0
        c1numSueldoBaseOrdinario.Value = 0
        c1numSueldoOrdinarioDiario.Value = 0
        c1numVacacionesAñosAnteriores.Value = 0
        c1numVacacionesProporcionales.Value = 0
        c1txtDescVacAñosAnt.Text = ""
        c1txtElaboradoPor.Text = ""
        radiobutDerechos.Checked = True
        PLPrestacionesPlanillasTableAdapter.Fill(Me.PLPrestacionesDataSet.PLPrestacionesPlanillas, 0)
        PLPrestacionesDeduccionesTableAdapter.Fill(Me.PLPrestacionesDataSet.PLPrestacionesDeducciones, 0)
        c1truedbgrdPlanillas.Enabled = False
        c1truedbgrdDedPendientes.Enabled = False
    End Sub
    Private Sub AgregarDatos()
        Dim mDatos As DataRowView, mDatosPrestPlani As DataRowView, mDatosDedPlani As DataRowView

        Try
            '*** Agregar Datos Iniciales
            PrincipalBindingSource.AddNew()
            mDatos = PrincipalBindingSource.Current
            mDatos("CodigoEmpleado") = c1txtCodigoEmpleado.Text
            mDatos("FechaIngreso") = drDatosEmp("FechaIngreso")
            mDatos("Fecha") = Date.Now
            If radiobutDerechos.Checked Then
                mDatos("TipoPrestaciones") = 1
            ElseIf radiobutDerechosCesantia.Checked Then
                mDatos("TipoPrestaciones") = 2
            ElseIf radiobutTodo.Checked Then
                mDatos("TipoPrestaciones") = 3
            End If
            PrincipalBindingSource.EndEdit()
            PLPrestacionesTableAdapter.Update(Me.PLPrestacionesDataSet.PLPrestaciones)
            mDatos = PrincipalBindingSource.Current
            drDatosPlani = PlCls.drObtenerUltimasPlanillas(c1txtCodigoEmpleado.Text, drConfPlani("PlanillasPorMes") * 6)
            While drDatosPlani.Read
                PLPrestacionesPlanillaBindingSource.AddNew()
                mDatosPrestPlani = PLPrestacionesPlanillaBindingSource.Current
                mDatosPrestPlani("NoCalculoPrestaciones") = mDatos("NoCalculoPrestaciones")
                mDatosPrestPlani("CodigoEmpleado") = drDatosPlani("CodigoEmpleado")
                mDatosPrestPlani("Año") = drDatosPlani("Año")
                mDatosPrestPlani("Mes") = drDatosPlani("Mes")
                mDatosPrestPlani("NoPlanilla") = drDatosPlani("NoPlanilla")
                mDatosPrestPlani("SueldoNormal") = drDatosPlani("SueldoNormal")
                mDatosPrestPlani("ValorHorasExtras") = drDatosPlani("HorasExtras")
                mDatosPrestPlani("Bonificaciones") = drDatosPlani("Bonificaciones")
            End While
            PLPrestacionesPlanillaBindingSource.EndEdit()
            PLPrestacionesPlanillasTableAdapter.Update(Me.PLPrestacionesDataSet.PLPrestacionesPlanillas)

            If PlCls.EmpleadoConSaldoPendiente(c1txtCodigoEmpleado.Text) Then
                If MsgBox("Este empleado tiene deducciones pendientes, desea incluirlas ahora ?" & vbCrLf & "(No se incuirán las deducciones permanentes)", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    drDedsPendientes = PlCls.drObtenerDeduccionesPendientes(c1txtCodigoEmpleado.Text)
                    While drDedsPendientes.Read
                        PLPrestacionesDeduccionesBindingSource.AddNew()
                        mDatosDedPlani = PLPrestacionesDeduccionesBindingSource.Current
                        mDatosDedPlani("NoCalculoPrestaciones") = mDatos("NoCalculoPrestaciones")
                        mDatosDedPlani("CodigoEmpleado") = c1txtCodigoEmpleado.Text
                        mDatosDedPlani("CodigoDeduccion") = drDedsPendientes("CodigoDeduccion")
                        mDatosDedPlani("NoDocumento") = drDedsPendientes("NoDocumento")
                        mDatosDedPlani("ValorSaldo") = drDedsPendientes("Saldo")
                    End While
                    PLPrestacionesDeduccionesBindingSource.EndEdit()
                    PLPrestacionesDeduccionesTableAdapter.Update(Me.PLPrestacionesDataSet.PLPrestacionesDeducciones)
                End If
            End If
            c1txtCodigoEmpleado.ReadOnly = True
            TotalizarUltimasPlanillas()
            TotalizarDedPen()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If Not drDedsPendientes.IsClosed Then
                drDedsPendientes.Close()
            End If
            drDatosPlani.Close()
            toolstripbutEliminar.Enabled = True
            toolstripbutGuardar.Enabled = True
            toolstripbutNuevo.Enabled = True
            toolstripbutImprimir.Enabled = True
            toolstripbutCalcular.Enabled = True
            c1truedbgrdPlanillas.Enabled = True
            c1truedbgrdDedPendientes.Enabled = True
        End Try
    End Sub
    Private Sub EditarDatos()
        Dim mDatos As DataRowView
        Dim decTotEgresos As Decimal

        Try
            PLPrestacionesTableAdapter.Fill(PLPrestacionesDataSet.PLPrestaciones, c1txtCodigoEmpleado.Text)
            mDatos = PrincipalBindingSource.Current
            PLPrestacionesDeduccionesTableAdapter.Fill(PLPrestacionesDataSet.PLPrestacionesDeducciones, mDatos("NoCalculoPrestaciones"))
            PLPrestacionesPlanillasTableAdapter.Fill(PLPrestacionesDataSet.PLPrestacionesPlanillas, mDatos("NoCalculoPrestaciones"))
            c1dateFechaRetiro.Value = mDatos("FechaRetiro")
            Select Case mDatos("TipoPrestaciones")
                Case 1
                    radiobutDerechos.Checked = True
                Case 2
                    radiobutDerechosCesantia.Checked = True
                Case 3
                    radiobutTodo.Checked = True
            End Select
            c1numAñosLaborados.Value = mDatos("AñosTrabajados")
            c1numMesesLaborados.Value = mDatos("MesesTrabajados")
            c1numDiasLaborados.Value = mDatos("DiasTrabajados")
            c1num13voProporcional.Value = mDatos("Proporcional13vo")
            c1num14voProporcional.Value = mDatos("Proporcional14vo")
            c1numCesantia.Value = mDatos("Cesantia")
            c1numCesantiaProporcional.Value = mDatos("CesantiaProporcional")
            c1numDiasPendientes.Value = mDatos("DiasPendientes")
            c1numDiasProp13vo.Value = mDatos("DiasProporcion13vo")
            c1numDiasProp14vo.Value = mDatos("DiasProporcion14vo")
            c1numDiasPropVacaciones.Value = mDatos("DiasProporcionVacaciones")
            c1numHorasExtras.Value = mDatos("HorasExtras")
            c1numImpuestoVecinal.Value = mDatos("ImpuestoVecinal")
            c1numPreaviso.Value = mDatos("Preaviso")
            c1numRAP.Value = mDatos("RAP")
            c1numSalarioPromedio.Value = mDatos("SalarioPromedio")
            c1numSalarioPromedioDiario.Value = mDatos("SalarioPromedioDiario")
            c1numSeguroSocial.Value = mDatos("SeguroSocial")
            c1numSueldoBaseDiario.Value = mDatos("SueldoBaseDiario")
            c1numSueldoBaseMensual.Value = mDatos("SueldoBaseMensual")
            c1numSueldoBaseOrdinario.Value = mDatos("SueldoBaseOrdinario")
            c1numSueldoOrdinarioDiario.Value = mDatos("SueldoBaseOrdinarioDiario")
            c1numVacacionesProporcionales.Value = mDatos("VacacionesProporcionales")
            c1numVacacionesAñosAnteriores.Value = mDatos("VacacionesAñosAnteriores")
            c1txtDescVacAñosAnt.Text = mDatos("VacacionesAñosAnterioresDesc").ToString
            c1txtObservaciones.Text = mDatos("Descripcion").ToString
            c1txtElaboradoPor.Text = mDatos("ElaboradoPor").ToString
            TotalizarUltimasPlanillas()
            TotalizarDedPen()
            '*** Total General
            lblTotalPrestaciones.Text = Format(c1numPreaviso.Value + c1numCesantia.Value + c1numCesantiaProporcional.Value + c1num13voProporcional.Value + c1num14voProporcional.Value + c1numVacacionesProporcionales.Value, "#,##0.00")
            decTotEgresos = c1numSeguroSocial.Value + c1numRAP.Value + c1numImpuestoVecinal.Value + decTotDeducciones
            lblTotal.Text = Format(c1numPreaviso.Value + c1numCesantia.Value + c1numCesantiaProporcional.Value + c1num13voProporcional.Value + c1num14voProporcional.Value + c1numVacacionesProporcionales.Value + c1numVacacionesAñosAnteriores.Value + c1numDiasPendientes.Value - decTotEgresos, "#,##0.00")
            toolstripbutEliminar.Enabled = True
            toolstripbutGuardar.Enabled = True
            toolstripbutNuevo.Enabled = True
            toolstripbutImprimir.Enabled = True
            toolstripbutCalcular.Enabled = True
            c1truedbgrdPlanillas.Enabled = True
            c1truedbgrdDedPendientes.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GuardarDatos(ByVal bMostrarMensaje As Boolean)
        Dim mDatos As DataRowView

        Try
            mDatos = PrincipalBindingSource.Current
            mDatos("FechaRetiro") = c1dateFechaRetiro.Value
            mDatos("FechaIngreso") = c1dateFechaIngreso.Value
            If radiobutDerechos.Checked Then
                mDatos("TipoPrestaciones") = 1
            ElseIf radiobutDerechosCesantia.Checked Then
                mDatos("TipoPrestaciones") = 2
            ElseIf radiobutTodo.Checked Then
                mDatos("TipoPrestaciones") = 3
            End If
            mDatos("AñosTrabajados") = c1numAñosLaborados.Value
            mDatos("MesesTrabajados") = c1numMesesLaborados.Value
            mDatos("DiasTrabajados") = c1numDiasLaborados.Value
            mDatos("Descripcion") = c1txtObservaciones.Text
            mDatos("Proporcional13vo") = c1num13voProporcional.Value
            mDatos("Proporcional14vo") = c1num14voProporcional.Value
            mDatos("Cesantia") = c1numCesantia.Value
            mDatos("CesantiaProporcional") = c1numCesantiaProporcional.Value
            mDatos("DiasPendientes") = c1numDiasPendientes.Value
            mDatos("DiasProporcion13vo") = c1numDiasProp13vo.Value
            mDatos("DiasProporcion14vo") = c1numDiasProp14vo.Value
            mDatos("DiasProporcionVacaciones") = c1numDiasPropVacaciones.Value
            mDatos("HorasExtras") = c1numHorasExtras.Value
            mDatos("ImpuestoVecinal") = c1numImpuestoVecinal.Value
            mDatos("Preaviso") = c1numPreaviso.Value
            mDatos("RAP") = c1numRAP.Value
            mDatos("SalarioPromedio") = c1numSalarioPromedio.Value
            mDatos("SalarioPromedioDiario") = c1numSalarioPromedioDiario.Value
            mDatos("SeguroSocial") = c1numSeguroSocial.Value
            mDatos("SueldoBaseDiario") = c1numSueldoBaseDiario.Value
            mDatos("SueldoBaseMensual") = c1numSueldoBaseMensual.Value
            mDatos("SueldoBaseOrdinario") = c1numSueldoBaseOrdinario.Value
            mDatos("SueldoBaseOrdinarioDiario") = c1numSueldoOrdinarioDiario.Value
            mDatos("VacacionesProporcionales") = c1numVacacionesProporcionales.Value
            mDatos("VacacionesAñosAnteriores") = c1numVacacionesAñosAnteriores.Value
            mDatos("VacacionesAñosAnterioresDesc") = c1txtDescVacAñosAnt.Text
            mDatos("ElaboradoPor") = c1txtElaboradoPor.Text
            PrincipalBindingSource.EndEdit()
            PLPrestacionesTableAdapter.Update(Me.PLPrestacionesDataSet.PLPrestaciones)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If bMostrarMensaje Then
                MsgBox("Datos Guardados...", MsgBoxStyle.OkOnly)
            End If
        End Try

    End Sub
    Private Sub Calcular()
        Dim intDiasTrab As Int16, intDiasPreaviso As Int16, intDiasCensantia As Int16, intDiasVacProp As Int16
        Dim decBonificacionesProm As Decimal

        TotalizarUltimasPlanillas()
        TotalizarDedPen()
        '*** Calcular Tiempo laborado
        CalcularTiempo(Microsoft.VisualBasic.Day(c1dateFechaIngreso.Value), Microsoft.VisualBasic.Month(c1dateFechaIngreso.Value), Microsoft.VisualBasic.Year(c1dateFechaIngreso.Value), _
                       Microsoft.VisualBasic.Day(c1dateFechaRetiro.Value), Microsoft.VisualBasic.Month(c1dateFechaRetiro.Value), Microsoft.VisualBasic.Year(c1dateFechaRetiro.Value))
        c1numAñosLaborados.Value = intAñosAntiguedad
        c1numMesesLaborados.Value = intMesesAntiguedad
        c1numDiasLaborados.Value = intDiasAntiguedad
        intDiasTrab = DateDiff(DateInterval.Day, c1dateFechaIngreso.Value, c1dateFechaRetiro.Value)

        c1numSueldoBaseMensual.Value = Math.Round(decTotSueldoNormal / 6, 2)
        c1numSueldoBaseDiario.Value = Math.Round(c1numSueldoBaseMensual.Value / 30, 2)
        c1numSueldoBaseOrdinario.Value = Math.Round((c1numSueldoBaseMensual.Value * 14) / 12, 2)
        c1numSueldoOrdinarioDiario.Value = Math.Round(c1numSueldoBaseOrdinario.Value / 30, 2)
        c1numHorasExtras.Value = Math.Round(decTotHorasExtras / 6, 2)
        decBonificacionesProm = Math.Round(decTotBonificaciones / 6, 2)
        c1numSalarioPromedio.Value = Math.Round(c1numSueldoBaseOrdinario.Value + c1numHorasExtras.Value + decBonificacionesProm, 2)
        c1numSalarioPromedioDiario.Value = Math.Round(c1numSalarioPromedio.Value / 30, 2)
        '*** Calcular preaviso
        intDiasPreaviso = PlCls.ObtenerDiasTablasPrestaciones(Math.Round(intDiasTrab / 30, 2), "PREAVISO")
        If radiobutTodo.Checked Then
            c1numPreaviso.Value = Math.Round(c1numSalarioPromedioDiario.Value * intDiasPreaviso, 2)
        End If
        '*** Calcular cesantía
        intDiasCensantia = PlCls.ObtenerDiasTablasPrestaciones(Math.Round(intDiasTrab / 30, 2), "CESANTIA")
        If radiobutTodo.Checked Or radiobutDerechosCesantia.Checked Then
            c1numCesantia.Value = Math.Round(c1numSalarioPromedio.Value * c1numAñosLaborados.Value, 2)
        End If
        '*** Calcular cesantía proporcional
        c1numCesantiaProporcional.Value = Math.Round((c1numSueldoBaseOrdinario.Value / 360) * (c1numMesesLaborados.Value * 30 + c1numDiasLaborados.Value), 2)
        '*** Calcular 13vo proporcional
        CalcularTiempo(1, 1, Microsoft.VisualBasic.Year(Date.Now), _
                       Microsoft.VisualBasic.Day(c1dateFechaRetiro.Value), Microsoft.VisualBasic.Month(c1dateFechaRetiro.Value), Microsoft.VisualBasic.Year(c1dateFechaRetiro.Value))
        c1numDiasProp13vo.Value = (intMesesAntiguedad * 30) + intDiasAntiguedad
        c1num13voProporcional.Value = Math.Round((c1numDiasProp13vo.Value * 30) / 360 * c1numSueldoBaseDiario.Value, 2)
        '*** Calcular 14vo Proporcional
        CalcularTiempo(1, 7, Microsoft.VisualBasic.Year(Date.Now), _
                       Microsoft.VisualBasic.Day(c1dateFechaRetiro.Value), Microsoft.VisualBasic.Month(c1dateFechaRetiro.Value), Microsoft.VisualBasic.Year(c1dateFechaRetiro.Value))
        c1numDiasProp14vo.Value = (intMesesAntiguedad * 30) + intDiasAntiguedad
        c1num14voProporcional.Value = Math.Round((c1numDiasProp14vo.Value * 30) / 360 * c1numSueldoBaseDiario.Value, 2)
        '*** Calcular Vacaciones Proporcionales
        c1numDiasPropVacaciones.Value = (c1numMesesLaborados.Value * 30) + c1numDiasLaborados.Value
        intDiasVacProp = PlCls.ObtenerDiasTablasPrestaciones(Math.Round(intDiasTrab / 365, 2), "VACPROPOR")
        c1numVacacionesProporcionales.Value = Math.Round((((c1numMesesLaborados.Value * 30) + c1numDiasLaborados.Value) / intDiasVacProp) * c1numSueldoOrdinarioDiario.Value, 2)
        '*** Vacaciones de Años Anteriores
        VerificarVacacionesAnteriores()

        '*** Total General
        TotalizarGeneral()
    End Sub
    Private Sub TotalizarUltimasPlanillas()
        Dim i As Int16
        decTotHorasExtras = 0
        decTotBonificaciones = 0
        decTotSueldoNormal = 0

        For i = 0 To c1truedbgrdPlanillas.RowCount - 1
            decTotHorasExtras = decTotHorasExtras + c1truedbgrdPlanillas(i, "Hrs. Ext.")
            decTotBonificaciones = decTotBonificaciones + c1truedbgrdPlanillas(i, "Bonificaciones")
            decTotSueldoNormal = decTotSueldoNormal + c1truedbgrdPlanillas(i, "Sldo. Normal")
        Next
        lblTotalHorasExtras.Text = Format(decTotHorasExtras, "#,##0.00")
        lblTotalBonificaciones.Text = Format(decTotBonificaciones, "#,##0.00")
        lblTotalSueldoNormal.Text = Format(decTotSueldoNormal, "#,##0.00")
    End Sub
    Private Sub TotalizarDedPen()
        Dim i As Int16
        decTotDeducciones = 0
        For i = 0 To c1truedbgrdDedPendientes.RowCount - 1
            decTotDeducciones = decTotDeducciones + c1truedbgrdDedPendientes(i, "Valor")
        Next

    End Sub
    Private Sub VerificarVacacionesAnteriores()
        Dim drVacPendientes As SqlClient.SqlDataReader
        Dim intDiasPendientes As Int16
        Dim strDesc As String

        drVacPendientes = PlCls.drObtenerVacacionesPendientes(c1txtCodigoEmpleado.Text)
        intDiasPendientes = 0
        strDesc = ""
        While drVacPendientes.Read
            intDiasPendientes = intDiasPendientes + (drVacPendientes("DiasVacaciones") - drVacPendientes("DiasCuentaVacaciones") - drVacPendientes("DiasGozadosVacaciones"))
            If String.IsNullOrEmpty(strDesc) Then
                strDesc = drVacPendientes("AñoInicial") & "-" & drVacPendientes("AñoFinal")
            Else
                strDesc = strDesc & ", " & drVacPendientes("AñoInicial") & "-" & drVacPendientes("AñoFinal")
            End If
        End While
        If intDiasPendientes > 0 Then
            c1numVacacionesAñosAnteriores.Value = intDiasPendientes * (drDatosEmp("SalarioMensual") / 30)
        End If
    End Sub
    Private Sub TotalizarGeneral()
        lblTotalPrestaciones.Text = Format(c1numPreaviso.Value + c1numCesantia.Value + c1numCesantiaProporcional.Value + c1num13voProporcional.Value + c1num14voProporcional.Value + c1numVacacionesProporcionales.Value, "#,##0.00")
        decTotEgresos = c1numSeguroSocial.Value + c1numRAP.Value + c1numImpuestoVecinal.Value + decTotDeducciones
        lblTotal.Text = Format(c1numPreaviso.Value + c1numCesantia.Value + c1numCesantiaProporcional.Value + c1num13voProporcional.Value + c1num14voProporcional.Value + c1numVacacionesProporcionales.Value + c1numVacacionesAñosAnteriores.Value + c1numDiasPendientes.Value - decTotEgresos, "#,##0.00")
    End Sub

    Private Sub toolstripbutSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutSalir.Click
        Me.Close()
    End Sub

    Private Sub c1txtCodigoEmpleado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1txtCodigoEmpleado.TextChanged

    End Sub
    Private Sub CalcularTiempo(ByVal day As Int16, ByVal month As Int16, ByVal year As Int16, ByVal thisDay As Int16, ByVal thisMonth As Int16, ByVal thisYear As Int16)
        Dim yearsold As Int16, monthsold As Int16, daysold As Int16

        yearsold = thisYear - year
        If thisMonth >= month Then
            monthsold = thisMonth - month
        Else
            yearsold = yearsold - 1
            monthsold = thisMonth + 12 - month
        End If

        If thisDay >= day Then
            daysold = thisDay - day
            daysold = daysold + 1
        Else
            If monthsold > 0 Then
                monthsold = monthsold - 1
            Else
                yearsold = yearsold - 1
                monthsold += 11
            End If
            daysold = thisDay + 31 - day
            daysold = daysold + 1
        End If

        If yearsold > 0 Then
            'c1numAñosLaborados.Value = yearsold
            intAñosAntiguedad = yearsold
        End If

        If monthsold > 0 Then
            'c1numMesesLaborados.Value = monthsold
            intMesesAntiguedad = monthsold
        End If

        If daysold > 0 Then
            'c1numDiasLaborados.Value = daysold
            intDiasAntiguedad = daysold
        End If

    End Sub

    Private Sub toolstripbutCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutCalcular.Click
        Calcular()
    End Sub

    Private Sub toolstripbutGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutGuardar.Click
        GuardarDatos(True)

    End Sub

    Private Sub toolstripbutEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutEliminar.Click
        PrincipalBindingSource.RemoveCurrent()
        PrincipalBindingSource.EndEdit()
        PLPrestacionesTableAdapter.Update(Me.PLPrestacionesDataSet.PLPrestaciones)
        InicializarDatos()
    End Sub

    Private Sub toolstripbutImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutImprimir.Click
        Dim strSQl As String

        strSQl = "{PLPrestaciones.CodigoEmpleado}='" & c1txtCodigoEmpleado.Text & "'"
        rptClass.EjecutarReportePrestaciones(strcnCAD, My.Settings.RSIEmpresaActual, lblNombreEmpleado.Text, strSQl)
    End Sub

    Private Sub c1numVacacionesAñosAnteriores_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1numVacacionesAñosAnteriores.TextChanged

    End Sub

    Private Sub c1numVacacionesAñosAnteriores_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numVacacionesAñosAnteriores.Validating
        TotalizarGeneral()
    End Sub

    Private Sub c1numDiasPendientes_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numDiasPendientes.Validating
        TotalizarGeneral()
    End Sub

    Private Sub c1numSeguroSocial_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numSeguroSocial.Validating
        TotalizarGeneral()
    End Sub

    Private Sub c1numRAP_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numRAP.Validating
        TotalizarGeneral()
    End Sub

    Private Sub c1numImpuestoVecinal_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numImpuestoVecinal.Validating
        TotalizarGeneral()
    End Sub

    Private Sub c1numPreaviso_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numPreaviso.Validating
        TotalizarGeneral()
    End Sub

    Private Sub c1numCesantia_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numCesantia.Validating
        TotalizarGeneral()
    End Sub

    Private Sub c1numCesantiaProporcional_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numCesantiaProporcional.Validating
        TotalizarGeneral()
    End Sub

    Private Sub c1num14voProporcional_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1num14voProporcional.Validating
        TotalizarGeneral()
    End Sub

    Private Sub c1num13voProporcional_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1num13voProporcional.Validating
        TotalizarGeneral()
    End Sub

    Private Sub c1numVacacionesProporcionales_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1numVacacionesProporcionales.TextChanged
        TotalizarGeneral()
    End Sub

    Private Sub c1truedbgrdPlanillas_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdPlanillas.AfterDelete
        PLPrestacionesPlanillaBindingSource.EndEdit()
        PLPrestacionesPlanillasTableAdapter.Update(Me.PLPrestacionesDataSet.PLPrestacionesPlanillas)
        TotalizarUltimasPlanillas()
    End Sub

    Private Sub c1truedbgrdPlanillas_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdPlanillas.AfterUpdate
        PLPrestacionesPlanillaBindingSource.EndEdit()
        PLPrestacionesPlanillasTableAdapter.Update(Me.PLPrestacionesDataSet.PLPrestacionesPlanillas)
        TotalizarUltimasPlanillas()
    End Sub

    Private Sub c1truedbgrdPlanillas_BeforeDelete(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1truedbgrdPlanillas.BeforeDelete
        If MsgBox("Desea eliminar esta línea ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub c1truedbgrdPlanillas_BeforeUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1truedbgrdPlanillas.BeforeUpdate
        Dim mDatos As DataRowView

        mDatos = PrincipalBindingSource.Current
        c1truedbgrdPlanillas.Columns("NoCalculoPrestaciones").Value = mDatos("NoCalculoPrestaciones")
        c1truedbgrdPlanillas.Columns("CodigoEmpleado").Value = c1txtCodigoEmpleado.Text
    End Sub

    Private Sub c1truedbgrdDedPendientes_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdDedPendientes.AfterDelete
        PLPrestacionesDeduccionesBindingSource.EndEdit()
        PLPrestacionesDeduccionesTableAdapter.Update(Me.PLPrestacionesDataSet.PLPrestacionesDeducciones)
        TotalizarDedPen()
        TotalizarGeneral()
    End Sub

    Private Sub c1truedbgrdDedPendientes_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdDedPendientes.AfterUpdate
        PLPrestacionesDeduccionesBindingSource.EndEdit()
        PLPrestacionesDeduccionesTableAdapter.Update(Me.PLPrestacionesDataSet.PLPrestacionesDeducciones)
        TotalizarDedPen()
        TotalizarGeneral()
    End Sub

    Private Sub c1truedbgrdDedPendientes_BeforeDelete(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1truedbgrdDedPendientes.BeforeDelete
        If MsgBox("Desea eliminar esta línea ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub c1truedbgrdDedPendientes_BeforeUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1truedbgrdDedPendientes.BeforeUpdate
        Dim mDatos As DataRowView

        If Not PlCls.ExisteDeduccion(c1truedbgrdDedPendientes.Columns("Deducción").Value) Then
            MsgBox("Deducción no existe ...", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            'e.Cancel = True
        Else
            mDatos = PrincipalBindingSource.Current
            c1truedbgrdDedPendientes.Columns("NoCalculoPrestaciones").Value = mDatos("NoCalculoPrestaciones")
            c1truedbgrdDedPendientes.Columns("CodigoEmpleado").Value = c1txtCodigoEmpleado.Text
        End If

    End Sub

    Private Sub c1truedbgrdDedPendientes_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles c1truedbgrdDedPendientes.ButtonClick
        If e.Column.Name = "Deducción" Then
            lstDefDedFrm.ShowDialog()
            If lstDefDedFrm.DialogResult = Windows.Forms.DialogResult.OK Then
                c1truedbgrdDedPendientes.Columns("Deducción").Value = lstDefDedFrm.c1dbgrdListas.Columns("Código").Value
            End If
        End If
    End Sub
    Private Sub CalcularSeguroRAP()
        Dim intUltAnio As Int16, intUltMes As Int16, intUltNoPlani As Int16
        Dim decRAP As Decimal, decIHSS As Decimal, decPorcSeguro As Decimal, decDedMaxSeguro As Decimal

        Try
            drDatosSedes = PlCls.drDatosSedesPlanilla(drDatosEmp("CodigoSede"))
            If drDatosSedes("DeducirSS") Then   'Deducir el seguro por sede
                If drDatosEmp("EsDocente") Then
                    decPorcSeguro = drDatosSedes("PorcentajeDocenteSS")
                    decDedMaxSeguro = drDatosSedes("DeduccionMaxDocenteSS")
                Else
                    decPorcSeguro = drDatosSedes("PorcentajeSS")
                    decDedMaxSeguro = drDatosSedes("DeduccionMaxSS")
                End If
            Else
                If drDatosEmp("EsDocente") Then
                    decPorcSeguro = drConfPlani("PorcentajeDocenteSS")
                    decDedMaxSeguro = drConfPlani("DeduccionMaxDocenteSS")
                Else
                    decPorcSeguro = drConfPlani("PorcentajeSS")
                    decDedMaxSeguro = drConfPlani("DeduccionMaxSS")
                End If
            End If
            decIHSS = Math.Round(drDatosEmp("SalarioMensual") * (decPorcSeguro / 100), 2)
            If decIHSS > decDedMaxSeguro Then
                decIHSS = decDedMaxSeguro
            End If

            If drDatosEmp("NoDeducirRAP") Then
                decRAP = 0
            Else
                decRAP = Math.Round(drDatosEmp("SalarioMensual") * (drConfPlani("PorcentajeRAP") / 100), 2)
                If decRAP > drConfPlani("DeduccionMaxRAP") Then
                    decRAP = drConfPlani("DeduccionMaxRAP")
                End If
            End If
            If Not PlCls.ObtenerUltimaPlanillaCerrada(intUltAnio, intUltMes, intUltNoPlani) Then
                intUltAnio = drConfPlani("AñoEnProceso")
                intUltMes = drConfPlani("MesEnProceso")
                intUltNoPlani = drConfPlani("NoPlanilla")
            End If
            If drConfPlani("CalcularSeguroSocial") <> "No Calcular" Then
                If drConfPlani("CalcularSeguroSocial") = "Cada Planilla" Then
                    If drConfPlani("PlanillasPorMes") = 1 Then
                        c1numSeguroSocial.Value = decIHSS
                    ElseIf drConfPlani("PlanillasPorMes") = 2 Then
                        If Date.Now.Month <> intUltMes Then 'No se ha hecho ninguna planilla este mes
                            c1numSeguroSocial.Value = decIHSS
                        Else    'Ya se hizo la 1ra Planilla del mes
                            c1numSeguroSocial.Value = Math.Round(decIHSS / 2, 2)
                        End If
                    ElseIf drConfPlani("PlanillasPorMes") = 4 Then
                        If Date.Now.Month <> intUltMes Then 'No se ha hecho ninguna planilla este mes
                            c1numSeguroSocial.Value = decIHSS
                        Else    'Ya se hizo la 1ra Planilla del mes
                            c1numSeguroSocial.Value = Math.Round(decIHSS / (4 - intUltNoPlani), 2)
                        End If
                    End If
                End If
                If drConfPlani("CalcularSeguroSocial") = "Planilla Específica" Then
                    If drConfPlani("PlanillasPorMes") = 1 Then
                        c1numSeguroSocial.Value = decIHSS
                    ElseIf drConfPlani("PlanillasPorMes") = 2 Then
                        If Date.Now.Month <> intUltMes Then 'No se ha hecho ninguna planilla este mes
                            c1numSeguroSocial.Value = decIHSS
                        Else    'Ya se hizo la 1ra Planilla del mes
                            If intUltNoPlani <> drConfPlani("NoPlanillaSeguro") Then
                                c1numSeguroSocial.Value = decIHSS
                            End If
                        End If
                    ElseIf drConfPlani("PlanillasPorMes") = 4 Then
                        If Date.Now.Month <> intUltMes Then 'No se ha hecho ninguna planilla este mes
                            c1numSeguroSocial.Value = decIHSS
                        Else    'Ya se hizo la 1ra Planilla del mes
                            If intUltNoPlani <> drConfPlani("NoPlanillaSeguro") Then
                                c1numSeguroSocial.Value = decIHSS
                            End If
                        End If
                    End If
                End If
            End If

            If drConfPlani("CalcularRAP") <> "No Calcular" Then
                If drConfPlani("CalcularRAP") = "Cada Planilla" Then
                    If drConfPlani("PlanillasPorMes") = 1 Then
                        c1numRAP.Value = decRAP
                    ElseIf drConfPlani("PlanillasPorMes") = 2 Then
                        If Date.Now.Month <> intUltMes Then 'No se ha hecho ninguna planilla este mes
                            c1numRAP.Value = decRAP
                        Else    'Ya se hizo la 1ra Planilla del mes
                            c1numRAP.Value = Math.Round(decRAP / 2, 2)
                        End If
                    ElseIf drConfPlani("PlanillasPorMes") = 4 Then
                        If Date.Now.Month <> intUltMes Then 'No se ha hecho ninguna planilla este mes
                            c1numRAP.Value = decRAP
                        Else    'Ya se hizo la 1ra Planilla del mes
                            c1numRAP.Value = Math.Round(decRAP / (4 - intUltNoPlani), 2)
                        End If
                    End If
                End If
                If drConfPlani("CalcularRAP") = "Planilla Específica" Then
                    If drConfPlani("PlanillasPorMes") = 1 Then
                        c1numRAP.Value = decRAP
                    ElseIf drConfPlani("PlanillasPorMes") = 2 Then
                        If Date.Now.Month <> intUltMes Then 'No se ha hecho ninguna planilla este mes
                            c1numRAP.Value = decRAP
                        Else    'Ya se hizo la 1ra Planilla del mes
                            If intUltNoPlani <> drConfPlani("NoPlanillaRAP") Then
                                c1numRAP.Value = decRAP
                            End If
                        End If
                    ElseIf drConfPlani("PlanillasPorMes") = 4 Then
                        If Date.Now.Month <> intUltMes Then 'No se ha hecho ninguna planilla este mes
                            c1numRAP.Value = decRAP
                        Else    'Ya se hizo la 1ra Planilla del mes
                            If intUltNoPlani <> drConfPlani("NoPlanillaRAP") Then
                                c1numRAP.Value = decRAP
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            drDatosSedes.Close()
        End Try

    End Sub

    Private Sub c1truedbgrdDedPendientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1truedbgrdDedPendientes.Click

    End Sub

    Private Sub btnBuscarEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarEmpleado.Load

    End Sub
End Class