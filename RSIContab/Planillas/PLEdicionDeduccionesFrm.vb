Public Class PLEdicionDeduccionesFrm
    Dim PlCls As New PLClassLib.PlClass
    Dim drCnf As SqlClient.SqlDataReader
    Dim drDatosEmp As SqlClient.SqlDataReader
    Dim decDedPl1 As Decimal, decDedPl2 As Decimal, decDeducPorPlanilla As Decimal
    Dim lstEmplsFrm As New ListaEmpleadosFom, EditTextoFrm As New EditarTextoFrm

    Private Sub PLEdicionDeduccionesFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIPrincipal
        Me.Top = 10
        Me.Left = 10

        PlCls.DBconStr = strcnCAD
        drCnf = PlCls.drConf
        toolstripAño.Text = "Año: " & drCnf("AñoEnProceso")
        toolstripMes.Text = "Mes: " & drCnf("MesEnProceso")
        toolstripPlani.Text = "Planilla No.: " & drCnf("NoPlanilla")
        Me.PLDefinicionDeduccionesTableAdapter.Fill(Me.PLEdicionDeduccionesDataSet.PLDefinicionDeducciones)
    End Sub
    Private Sub c1cmbDeducciones_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1cmbDeducciones.SelectedValueChanged
        Me.PLDeduccionesTableAdapter.Fill(Me.PLEdicionDeduccionesDataSet.PLDeducciones, c1cmbDeducciones.SelectedValue)
        Totalizar()
    End Sub

    Private Sub toolstripSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripSalir.Click
        Me.Close()
    End Sub
    Private Sub Totalizar()
        Dim i As Int16

        decDedPl1 = 0
        decDedPl2 = 0
        lblDedPl1.Text = "0.00"
        lblDedPl2.Text = "0.00"
        For i = 0 To c1truedbgrdPrincipal.RowCount - 1
            decDedPl1 = decDedPl1 + c1truedbgrdPrincipal(i, "Ded PL1")
            decDedPl2 = decDedPl2 + c1truedbgrdPrincipal(i, "Ded PL2")
        Next
        lblDedPl1.Text = Format(decDedPl1, "#,##0.00")
        lblDedPl2.Text = Format(decDedPl2, "#,##0.00")
    End Sub

    Private Sub c1truedbgrdPrincipal_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles c1truedbgrdPrincipal.AfterColUpdate
        If e.Column.Name = "No Meses" And c1truedbgrdPrincipal.Columns("Ded Fija").Value = False Then
            c1truedbgrdPrincipal.Columns("Ded Men").Value = Math.Round(c1truedbgrdPrincipal.Columns("Valor").Value / c1truedbgrdPrincipal.Columns("No Meses").Value, 2)
            decDeducPorPlanilla = Math.Round(c1truedbgrdPrincipal.Columns("Ded Men").Value / drCnf("PlanillasPorMes"), 2)
            DistribuirDedEnPlanillas()
        End If
        If e.Column.Name = "Ded Men" Then
            decDeducPorPlanilla = Math.Round(c1truedbgrdPrincipal.Columns("Ded Men").Value / drCnf("PlanillasPorMes"), 2)
            DistribuirDedEnPlanillas()
        End If

    End Sub
    Private Sub DistribuirDedEnPlanillas()
        Select Case drCnf("PlanillasPorMes")
            Case 1
                c1truedbgrdPrincipal.Columns("Ded PL1").Value = decDeducPorPlanilla
            Case 2
                c1truedbgrdPrincipal.Columns("Ded PL1").Value = decDeducPorPlanilla
                c1truedbgrdPrincipal.Columns("Ded PL2").Value = decDeducPorPlanilla
            Case 3
                c1truedbgrdPrincipal.Columns("Ded PL1").Value = decDeducPorPlanilla
                c1truedbgrdPrincipal.Columns("Ded PL2").Value = decDeducPorPlanilla
                c1truedbgrdPrincipal.Columns("Ded PL3").Value = decDeducPorPlanilla
            Case 4
                c1truedbgrdPrincipal.Columns("Ded PL1").Value = decDeducPorPlanilla
                c1truedbgrdPrincipal.Columns("Ded PL2").Value = decDeducPorPlanilla
                c1truedbgrdPrincipal.Columns("Ded PL3").Value = decDeducPorPlanilla
                c1truedbgrdPrincipal.Columns("Ded PL4").Value = decDeducPorPlanilla
        End Select
    End Sub
    Private Sub c1truedbgrdPrincipal_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdPrincipal.AfterDelete
        Actualizar()
        Totalizar()
    End Sub

    Private Sub c1truedbgrdPrincipal_AfterInsert(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdPrincipal.AfterInsert
        Actualizar()
        Totalizar()
    End Sub

    Private Sub c1truedbgrdPrincipal_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdPrincipal.AfterUpdate
        Actualizar()
        Me.PLDeduccionesTableAdapter.Fill(Me.PLEdicionDeduccionesDataSet.PLDeducciones, c1cmbDeducciones.SelectedValue)
        Totalizar()
    End Sub

    Private Sub c1truedbgrdPrincipal_BeforeColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles c1truedbgrdPrincipal.BeforeColUpdate
        If e.Column.Name = "Empleado" Then
            '*** Verificar si existe empleado
            drDatosEmp = PlCls.drDatosEmpleado(c1truedbgrdPrincipal.Columns("Empleado").Text)
            If Not drDatosEmp.HasRows Then
                MsgBox("Empleado no existe, verifique...", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                e.Cancel = True
            Else
                c1truedbgrdPrincipal.Columns("Nombre").Value = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre1").Value & IIf(String.IsNullOrEmpty(lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre2").Value), "", " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre2").Value) _
                & " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido1").Value & IIf(String.IsNullOrEmpty(lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido2").Value), "", " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido2").Value)
            End If
            drDatosEmp.Close()
        End If
    End Sub

    Private Sub c1truedbgrdPrincipal_BeforeDelete(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1truedbgrdPrincipal.BeforeDelete
        If MsgBox("Desea Eliminar Este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub c1truedbgrdPrincipal_BeforeInsert(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1truedbgrdPrincipal.BeforeInsert
    End Sub

    Private Sub c1truedbgrdPrincipal_BeforeUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1truedbgrdPrincipal.BeforeUpdate
        c1truedbgrdPrincipal.Columns("CodigoDeduccion").Value = c1cmbDeducciones.SelectedValue
        c1truedbgrdPrincipal.Columns("Año").Value = drCnf("AñoEnProceso")
        c1truedbgrdPrincipal.Columns("Mes").Value = drCnf("MesEnProceso")
        c1truedbgrdPrincipal.Columns("PlanillaNo").Value = drCnf("NoPlanilla")
        c1truedbgrdPrincipal.Columns("Fecha").Value = drCnf("FechaProceso")
    End Sub

    Private Sub c1truedbgrdPrincipal_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles c1truedbgrdPrincipal.ButtonClick
        If e.Column.Name = "Empleado" Then
            lstEmplsFrm.EmpleadosRetirados = False
            lstEmplsFrm.ShowDialog()
            If lstEmplsFrm.DialogResult = Windows.Forms.DialogResult.OK Then
                c1truedbgrdPrincipal.Columns("Empleado").Value = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Empleado").Value
                c1truedbgrdPrincipal.Columns("Nombre").Value = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre1").Value & IIf(String.IsNullOrEmpty(lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre2").Value), "", " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre2").Value) _
                & " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido1").Value & IIf(String.IsNullOrEmpty(lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido2").Value), "", " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido2").Value)
            End If
        End If
        If e.Column.Name = "Referencia" Then
            EditTextoFrm.txtTexto.Text = c1truedbgrdPrincipal.Columns("Referencia").Text
            EditTextoFrm.ShowDialog()
            If EditTextoFrm.DialogResult = Windows.Forms.DialogResult.OK Then
                c1truedbgrdPrincipal.Columns("Referencia").Value = EditTextoFrm.txtTexto.Text
            End If
        End If
    End Sub
    Private Sub Actualizar()
        Try
            Me.Validate()
            Me.PrincipalBindingSource.EndEdit()
            Me.PLDeduccionesTableAdapter.Update(PLEdicionDeduccionesDataSet.PLDeducciones)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub toolstripbutRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutRefrescar.Click
        Me.PLDeduccionesTableAdapter.Fill(Me.PLEdicionDeduccionesDataSet.PLDeducciones, c1cmbDeducciones.SelectedValue)
        Totalizar()
    End Sub
End Class