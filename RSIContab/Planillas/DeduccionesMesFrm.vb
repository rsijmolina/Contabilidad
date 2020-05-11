Public Class DeduccionesMesFrm
    Dim PlCls As New PLClassLib.PlClass
    Dim drDatosEmp As SqlClient.SqlDataReader
    Dim drCnf As SqlClient.SqlDataReader
    Dim decDeducPorPlanilla As Decimal
    Private Sub DeduccionesMesFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIPrincipal
        Me.Top = 10
        Me.Left = 10

        PlCls.DBconStr = strcnCAD
        drCnf = PlCls.drConf
        toolstripAño.Text = "Año: " & drCnf("AñoEnProceso")
        toolstripMes.Text = "Mes: " & drCnf("MesEnProceso")
        toolstripPlani.Text = "Planilla No.: " & drCnf("NoPlanilla")
        Me.PLDefinicionDeduccionesTableAdapter.Fill(Me.PLDeduccionesMesDataSet.PLDefinicionDeducciones)
        If PlCls.PlanillaCerrada(drCnf("AñoEnProceso"), drCnf("MesEnProceso"), drCnf("NoPlanilla")) Then
            c1truedbgrdPrincipal.AllowAddNew = False
            c1truedbgrdPrincipal.AllowDelete = False
            c1truedbgrdPrincipal.AllowUpdate = False
            MsgBox("Esta Planilla ya Está Cerrada...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub c1truedbgrdPrincipal_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles c1truedbgrdPrincipal.AfterColUpdate

        If e.Column.Name = "No Meses" And c1truedbgrdPrincipal.Columns("Ded Fija").Value = False Then
            c1truedbgrdPrincipal.Columns("Ded. Mensual").Value = Math.Round(c1truedbgrdPrincipal.Columns("Valor").Value / c1truedbgrdPrincipal.Columns("No Meses").Value, 2)
            decDeducPorPlanilla = Math.Round(c1truedbgrdPrincipal.Columns("Ded. Mensual").Value / drCnf("PlanillasPorMes"), 2)
            DistribuirDedEnPlanillas()
        End If
        If e.Column.Name = "Ded. Mensual" Then
            decDeducPorPlanilla = Math.Round(c1truedbgrdPrincipal.Columns("Ded. Mensual").Value / drCnf("PlanillasPorMes"), 2)
            DistribuirDedEnPlanillas()
        End If

    End Sub
    Private Sub DistribuirDedEnPlanillas()
        Select Case drCnf("PlanillasPorMes")
            Case 1
                c1truedbgrdPrincipal.Columns("Ded Pl 1").Value = decDeducPorPlanilla
            Case 2
                c1truedbgrdPrincipal.Columns("Ded Pl 1").Value = decDeducPorPlanilla
                c1truedbgrdPrincipal.Columns("Ded Pl 2").Value = decDeducPorPlanilla
            Case 3
                c1truedbgrdPrincipal.Columns("Ded Pl 1").Value = decDeducPorPlanilla
                c1truedbgrdPrincipal.Columns("Ded Pl 2").Value = decDeducPorPlanilla
                c1truedbgrdPrincipal.Columns("Ded Pl 3").Value = decDeducPorPlanilla
            Case 4
                c1truedbgrdPrincipal.Columns("Ded Pl 1").Value = decDeducPorPlanilla
                c1truedbgrdPrincipal.Columns("Ded Pl 2").Value = decDeducPorPlanilla
                c1truedbgrdPrincipal.Columns("Ded Pl 3").Value = decDeducPorPlanilla
                c1truedbgrdPrincipal.Columns("Ded Pl 4").Value = decDeducPorPlanilla
        End Select
    End Sub

    Private Sub c1truedbgrdPrincipal_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdPrincipal.AfterDelete
        Actualizar()
    End Sub

    Private Sub c1truedbgrdPrincipal_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdPrincipal.AfterUpdate
        Actualizar()
    End Sub


    Private Sub c1truedbgrdPrincipal_BeforeColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles c1truedbgrdPrincipal.BeforeColUpdate
        If e.Column.Name = "Empleado" Then
            '*** Verificar si existe empleado
            drDatosEmp = PlCls.drDatosEmpleado(c1truedbgrdPrincipal.Columns("Empleado").Text)
            If Not drDatosEmp.HasRows Then
                MsgBox("Empleado no existe, verifique...", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                e.Cancel = True
            Else
                c1truedbgrdPrincipal.Columns("Nombre 1").Value = drDatosEmp("Nombre1")
                c1truedbgrdPrincipal.Columns("Nombre 2").Value = drDatosEmp("Nombre2")
                c1truedbgrdPrincipal.Columns("Apellido 1").Value = drDatosEmp("Apellido1")
                c1truedbgrdPrincipal.Columns("Apellido 2").Value = drDatosEmp("Apellido2")
            End If
            drDatosEmp.Close()
        End If
    End Sub

    Private Sub c1truedbgrdPrincipal_BeforeDelete(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1truedbgrdPrincipal.BeforeDelete
        If MsgBox("Desea Eliminar Este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
        End If
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
            ListaEmpleadosFom.EmpleadosRetirados = False
            ListaEmpleadosFom.ShowDialog()
            If ListaEmpleadosFom.DialogResult = Windows.Forms.DialogResult.OK Then
                c1truedbgrdPrincipal.Columns("Empleado").Value = ListaEmpleadosFom.c1dbgrdListaEmpleados.Columns("Empleado").Value
                c1truedbgrdPrincipal.Columns("Nombre 1").Value = ListaEmpleadosFom.c1dbgrdListaEmpleados.Columns("Nombre1").Value
                c1truedbgrdPrincipal.Columns("Nombre 2").Value = ListaEmpleadosFom.c1dbgrdListaEmpleados.Columns("Nombre2").Value
                c1truedbgrdPrincipal.Columns("Apellido 1").Value = ListaEmpleadosFom.c1dbgrdListaEmpleados.Columns("Apellido1").Value
                c1truedbgrdPrincipal.Columns("Apellido 2").Value = ListaEmpleadosFom.c1dbgrdListaEmpleados.Columns("Apellido2").Value
            End If
        End If
        If e.Column.Name = "Referencia" Then
            EditarTextoFrm.txtTexto.Text = c1truedbgrdPrincipal.Columns("Referencia").Text
            EditarTextoFrm.ShowDialog()
            If EditarTextoFrm.DialogResult = Windows.Forms.DialogResult.OK Then
                c1truedbgrdPrincipal.Columns("Referencia").Value = EditarTextoFrm.txtTexto.Text
            End If
        End If
    End Sub

    Private Sub c1cmbDeducciones_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1cmbDeducciones.SelectedValueChanged
        Me.PLDeduccionesTableAdapter.Fill(Me.PLDeduccionesMesDataSet.PLDeducciones, drCnf("AñoEnProceso"), drCnf("MesEnProceso"), c1cmbDeducciones.SelectedValue, drCnf("NoPlanilla"))
    End Sub

    Private Sub toolstripSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripSalir.Click
        Me.Close()
    End Sub
    Private Sub Actualizar()
        Try
            Me.Validate()
            Me.PrincipalBindingSource.EndEdit()
            'Me.PLDeduccionesTableAdapter.Update(Me.PLDeduccionesMesDataSet.PLDeducciones)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub c1truedbgrdPrincipal_Click(sender As System.Object, e As System.EventArgs) Handles c1truedbgrdPrincipal.Click

    End Sub
End Class