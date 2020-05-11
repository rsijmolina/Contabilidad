Public Class PLDeduccionesExcepcionesFrm
    Dim PlCls As New PLClassLib.PlClass
    Dim drDatosEmp As SqlClient.SqlDataReader
    Dim drCnf As SqlClient.SqlDataReader

    Private Sub PLDeduccionesExcepcionesFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        PlCls.DBconStr = strcnCAD
        drCnf = PlCls.drConf

        'TODO: esta línea de código carga datos en la tabla 'PLDeduccionesExcepcionesDataSet.PLDeduccionesExcepciones' Puede moverla o quitarla según sea necesario.
        Me.PLDeduccionesExcepcionesTableAdapter.Fill(Me.PLDeduccionesExcepcionesDataSet.PLDeduccionesExcepciones)

    End Sub

    Private Sub c1truedbgrdPrincipal_BeforeColUpdate(sender As Object, e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles c1truedbgrdPrincipal.BeforeColUpdate
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

    Private Sub c1truedbgrdPrincipal_BeforeDelete(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1truedbgrdPrincipal.BeforeDelete
        If MsgBox("Desea Eliminar Este Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub c1truedbgrdPrincipal_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles c1truedbgrdPrincipal.ButtonClick
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

    End Sub
    Private Sub c1truedbgrdPrincipal_AfterInsert(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdPrincipal.AfterInsert
        Actualizar()
    End Sub

    Private Sub c1truedbgrdPrincipal_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdPrincipal.AfterDelete
        Actualizar()
    End Sub

    Private Sub c1truedbgrdPrincipal_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdPrincipal.AfterUpdate
        Actualizar()
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
End Class