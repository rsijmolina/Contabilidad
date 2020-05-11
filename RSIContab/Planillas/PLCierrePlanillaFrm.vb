Public Class PLCierrePlanillaFrm
    Dim PlCls As New PLClassLib.PlClass
    Dim RSICls As New Rsierpgencl.Rsierpcl.Cadenas
    Dim drConfPlani As SqlClient.SqlDataReader
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub PLCierrePlanillaFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PLCierrePlanillaDataSet.PLDeducciones' Puede moverla o quitarla según sea necesario.
        Me.PLDeduccionesTableAdapter.Fill(Me.PLCierrePlanillaDataSet.PLDeducciones)
        PlCls.DBconStr = strcnCAD
        drConfPlani = PlCls.drConf
        If PlCls.PlanillaCerrada(drConfPlani("AñoEnProceso"), drConfPlani("MesEnProceso"), drConfPlani("NoPlanilla")) Then
            lblCierrePlanilla.Text = ""
            MsgBox("La Planilla No. " & drConfPlani("NoPlanilla") & " de " & RSICls.MesLetras(drConfPlani("MesEnProceso")) & " de " & drConfPlani("AñoEnProceso") & " Ya Está Cerrada")
        Else
            lblCierrePlanilla.Text = "Este proceso cerrará la planilla No. " & drConfPlani("NoPlanilla") & " de " & RSICls.MesLetras(drConfPlani("MesEnProceso")) & " de " & drConfPlani("AñoEnProceso")
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim mDataPlaniCerradas As DataRowView
        Dim colecEmpIngAdic As New Collection   'Para hacer un recalculo del ISR

        Try
            Me.PLPlanillasTableAdapter.Fill(Me.PLCierrePlanillaDataSet.PLPlanillas, drConfPlani("AñoEnProceso"), drConfPlani("MesEnProceso"), drConfPlani("NoPlanilla"))
            Me.PLPlanillasOTTableAdapter.Fill(Me.PLCierrePlanillaDataSet.PLPlanillasOT, drConfPlani("AñoEnProceso"), drConfPlani("MesEnProceso"), drConfPlani("NoPlanilla"))
            Me.PLDeduccionISRTableAdapter.Fill(Me.PLCierrePlanillaDataSet.PLDeduccionISR, drConfPlani("AñoEnProceso"))
            Me.PLDeduccionesTableAdapter.Fill(Me.PLCierrePlanillaDataSet.PLDeducciones)
            Me.PLPlanillasCerradasTableAdapter.Fill(Me.PLCierrePlanillaDataSet.PLPlanillasCerradas, drConfPlani("AñoEnProceso"), drConfPlani("MesEnProceso"))
            For Each mDataPlani As DataRowView In PrincipalBindingSource.List
                '*** Procesar deducción del impuesto sobre la renta
                PLDeduccionesISRBindingSource.Filter = "CodigoEmpleado='" & mDataPlani("CodigoEmpleado") & "'"
                For Each mDataDedIRS As DataRowView In PLDeduccionesISRBindingSource.List                
                    If drConfPlani("PlanillasPorMes") = 1 Then
                        mDataDedIRS("DeduccionPlanilla1_") = mDataPlani("ImpuestoSobreRenta")
                    ElseIf drConfPlani("PlanillasPorMes") = 2 Then
                        If drConfPlani("NoPlanilla") = 1 Then
                            mDataDedIRS("DeduccionPlanilla1_" & Strings.Trim(Str(drConfPlani("MesEnProceso")))) = mDataPlani("ImpuestoSobreRenta")
                        Else
                            mDataDedIRS("DeduccionPlanilla2_" & Strings.Trim(Str(drConfPlani("MesEnProceso")))) = mDataPlani("ImpuestoSobreRenta")
                        End If
                    End If                    
                    mDataDedIRS("OtrosIngresosMes" & Trim(Str(drConfPlani("MesEnProceso")))) = mDataDedIRS("OtrosINgresosMes" & Trim(Str(drConfPlani("MesEnProceso")))) + (mDataPlani("ValorHorasExtras25") + mDataPlani("ValorHorasExtras50") + mDataPlani("ValorHorasExtras75") + mDataPlani("ValorHorasExtrasDobles") + mDataPlani("Comisiones") + mDataPlani("Bonificaciones"))
                    If (mDataPlani("ValorHorasExtras25") + mDataPlani("ValorHorasExtras50") + mDataPlani("ValorHorasExtras75") + mDataPlani("ValorHorasExtrasDobles") + mDataPlani("Comisiones") + mDataPlani("Bonificaciones")) > 0 Then
                        colecEmpIngAdic.Add(mDataPlani("CodigoEmpleado"))
                    End If
                Next
                If PLDeduccionesISRBindingSource.List.Count > 0 Then
                    PLDeduccionesISRBindingSource.EndEdit()
                    Me.PLDeduccionISRTableAdapter.Update(Me.PLCierrePlanillaDataSet.PLDeduccionISR)
                End If

                '*** Procesar Otras Deducciones ***
                PLPLanillasOTBindingSource.Filter = "CodigoEmpleado='" & mDataPlani("CodigoEmpleado") & "'"
                For Each mDataOtrasDed As DataRowView In PLPLanillasOTBindingSource.List
                    '*** Actualizar Deducciones ***
                    PLDeduccionesBindingSource.Filter = "NoDocumento=" & mDataOtrasDed("NoDocumento")
                    For Each mDataPlaniDed As DataRowView In PLDeduccionesBindingSource.List
                        mDataPlaniDed("MontoDeducidoAnterior") = mDataPlaniDed("MontoDeducido")
                        mDataPlaniDed("MontoDeducido") = mDataPlaniDed("MontoDeducido") + mDataOtrasDed("Valor")
                        mDataPlaniDed("NoPlanillasDeducidas") = mDataPlaniDed("NoPlanillasDeducidas") + 1
                        mDataPlaniDed("UltimaDeduccion") = mDataOtrasDed("Correlativo")
                    Next
                    If PLDeduccionesBindingSource.List.Count > 0 Then
                        PLDeduccionesBindingSource.EndEdit()
                        Me.PLDeduccionesTableAdapter.Update(Me.PLCierrePlanillaDataSet.PLDeducciones)
                    End If
                Next
                mDataPlani("Cerrado") = 1
            Next
            PLPlanillasCerradasBindingSource.AddNew()
            mDataPlaniCerradas = PLPlanillasCerradasBindingSource.Current
            mDataPlaniCerradas("Año") = drConfPlani("AñoEnProceso")
            mDataPlaniCerradas("Mes") = drConfPlani("MesEnProceso")
            mDataPlaniCerradas("NoPlanilla") = drConfPlani("NoPlanilla")
            PLPlanillasCerradasBindingSource.EndEdit()
            Me.PLPlanillasCerradasTableAdapter.Update(Me.PLCierrePlanillaDataSet.PLPlanillasCerradas)

            'PLDeduccionesISRBindingSource.EndEdit()
            'Me.PLDeduccionISRTableAdapter.Update(Me.PLCierrePlanillaDataSet.PLDeduccionISR)
            PrincipalBindingSource.EndEdit()
            Me.PLPlanillasTableAdapter.Update(Me.PLCierrePlanillaDataSet.PLPlanillas)
            'Recalcular ISR
            For Each strEmp As String In colecEmpIngAdic
                PlCls.ClacularISRConCuadro(strEmp, drConfPlani("AñoEnProceso"))
            Next
            MsgBox("Proceso Terminado ...", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
        Finally
            drConfPlani.Close()
        End Try
        Me.Close()
    End Sub
End Class