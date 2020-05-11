Public Class PlCambioCodigoFrm
    Dim drDatosEmp As SqlClient.SqlDataReader
    Dim PlCls As New PLClassLib.PlClass
    Dim lstEmplsFrm As New ListaEmpleadosFom

    Private Sub PlCambioCodigoFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnBuscarEmpleado.Enabled = True
        PlCls.DBconStr = strcnCAD
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If PlCls.ExisteEmpleado(c1txtNuevoCodigo.Text) Then
            MsgBox("El código nuevo ya existe, no se puede realizar este proceso...", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If MsgBox("Realmente desea cambiar el código a este empleado ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            CambiarCodigo()
            MsgBox("Proceso terminado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        End If
    End Sub
    Private Sub CambiarCodigo()
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdNotasEmpl As SqlClient.SqlCommand, cmdPermisos As SqlClient.SqlCommand, cmdIncap As SqlClient.SqlCommand
        Dim cmdPlani As SqlClient.SqlCommand, cmdEmpl As SqlClient.SqlCommand, cmdPlaniOt As SqlClient.SqlCommand, cmdPrest As SqlClient.SqlCommand
        Dim cmdPrestDed As SqlClient.SqlCommand, cmdPrestPlani As SqlClient.SqlCommand, cmdVac As SqlClient.SqlCommand, cmdVacRes As SqlClient.SqlCommand
        Dim cmdConst As SqlClient.SqlCommand, cmdDedCol As SqlClient.SqlCommand, cmdDed As SqlClient.SqlCommand, cmdDedDet As SqlClient.SqlCommand
        Dim cmdDedImpVec As SqlClient.SqlCommand, cmdDedISR As SqlClient.SqlCommand, cmdDiasVacTomados As SqlClient.SqlCommand


        Dim sqlTrans As SqlClient.SqlTransaction

        cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
        cnSQLConexion.Open()
        sqlTrans = cnSQLConexion.BeginTransaction()

        Try
            '*** Constancias
            cmdConst = cnSQLConexion.CreateCommand
            cmdConst.CommandType = CommandType.Text
            cmdConst.CommandText = "UPDATE PLConstancias SET CodigoEmpleado='" & c1txtNuevoCodigo.Text & "'"
            cmdConst.Transaction = sqlTrans
            cmdConst.ExecuteNonQuery()
            '*** Deducción Colegios Profesionales
            cmdDedCol = cnSQLConexion.CreateCommand
            cmdDedCol.CommandType = CommandType.Text
            cmdDedCol.CommandText = "UPDATE PLDedColegiosPorEmpleados SET CodigoEmpleado='" & c1txtNuevoCodigo.Text & "' WHERE CodigoEmpleado='" & c1txtCodigoEmpleado.Text & "'"
            cmdDedCol.Transaction = sqlTrans
            cmdDedCol.ExecuteNonQuery()
            '*** Deducciones
            cmdDed = cnSQLConexion.CreateCommand
            cmdDed.CommandType = CommandType.Text
            cmdDed.CommandText = "UPDATE PLDeducciones SET CodigoEmpleado='" & c1txtNuevoCodigo.Text & "' WHERE CodigoEmpleado='" & c1txtCodigoEmpleado.Text & "'"
            cmdDed.Transaction = sqlTrans
            cmdDed.ExecuteNonQuery()
            '*** Deducciones Detalle
            cmdDedDet = cnSQLConexion.CreateCommand
            cmdDedDet.CommandType = CommandType.Text
            cmdDedDet.CommandText = "UPDATE PLDeduccionesDet SET CodigoEmpleado='" & c1txtNuevoCodigo.Text & "' WHERE CodigoEmpleado='" & c1txtCodigoEmpleado.Text & "'"
            cmdDedDet.Transaction = sqlTrans
            cmdDedDet.ExecuteNonQuery()
            '*** Deducción Imp. Vecinal
            cmdDedImpVec = cnSQLConexion.CreateCommand
            cmdDedImpVec.CommandType = CommandType.Text
            cmdDedImpVec.CommandText = "UPDATE PLDeduccionImpuestoVecinal SET CodigoEmpleado='" & c1txtNuevoCodigo.Text & "' WHERE CodigoEmpleado='" & c1txtCodigoEmpleado.Text & "'"
            cmdDedImpVec.Transaction = sqlTrans
            cmdDedImpVec.ExecuteNonQuery()
            '*** Deducción ISR
            cmdDedISR = cnSQLConexion.CreateCommand
            cmdDedISR.CommandType = CommandType.Text
            cmdDedISR.CommandText = "UPDATE PLDeduccionISR SET CodigoEmpleado='" & c1txtNuevoCodigo.Text & "' WHERE CodigoEmpleado='" & c1txtCodigoEmpleado.Text & "'"
            cmdDedISR.Transaction = sqlTrans
            cmdDedISR.ExecuteNonQuery()
            '*** Días Vacaciones Tomados
            cmdDiasVacTomados = cnSQLConexion.CreateCommand
            cmdDiasVacTomados.CommandType = CommandType.Text
            cmdDiasVacTomados.CommandText = "UPDATE PLDiasVacacionesTomados SET CodigoEmpleado='" & c1txtNuevoCodigo.Text & "' WHERE CodigoEmpleado='" & c1txtCodigoEmpleado.Text & "'"
            cmdDiasVacTomados.Transaction = sqlTrans
            cmdDiasVacTomados.ExecuteNonQuery()
            '*** Incapacidades
            cmdIncap = cnSQLConexion.CreateCommand
            cmdIncap.CommandType = CommandType.Text
            cmdIncap.CommandText = "UPDATE PLIncapacidades SET CodigoEmpleado='" & c1txtNuevoCodigo.Text & "' WHERE CodigoEmpleado='" & c1txtCodigoEmpleado.Text & "'"
            cmdIncap.Transaction = sqlTrans
            cmdIncap.ExecuteNonQuery()
            '*** Notas Empleados
            cmdNotasEmpl = cnSQLConexion.CreateCommand
            cmdNotasEmpl.CommandType = CommandType.Text
            cmdNotasEmpl.CommandText = "UPDATE PLNotasEmpleados SET CodigoEmpleado='" & c1txtNuevoCodigo.Text & "' WHERE CodigoEmpleado='" & c1txtCodigoEmpleado.Text & "'"
            cmdNotasEmpl.Transaction = sqlTrans
            cmdNotasEmpl.ExecuteNonQuery()
            '*** Permisos
            cmdPermisos = cnSQLConexion.CreateCommand
            cmdPermisos.CommandType = CommandType.Text
            cmdPermisos.CommandText = "UPDATE PLPermisos SET CodigoEmpleado='" & c1txtNuevoCodigo.Text & "' WHERE CodigoEmpleado='" & c1txtCodigoEmpleado.Text & "'"
            cmdPermisos.Transaction = sqlTrans
            cmdPermisos.ExecuteNonQuery()
            '*** Planillas
            cmdPlani = cnSQLConexion.CreateCommand
            cmdPlani.CommandType = CommandType.Text
            cmdPlani.CommandText = "UPDATE PLPlanillas SET CodigoEmpleado='" & c1txtNuevoCodigo.Text & "' WHERE CodigoEmpleado='" & c1txtCodigoEmpleado.Text & "'"
            cmdPlani.Transaction = sqlTrans
            cmdPlani.ExecuteNonQuery()
            '*** Planillas OT
            cmdPlaniOt = cnSQLConexion.CreateCommand
            cmdPlaniOt.CommandType = CommandType.Text
            cmdPlaniOt.CommandText = "UPDATE PLPlanillasOT SET CodigoEmpleado='" & c1txtNuevoCodigo.Text & "' WHERE CodigoEmpleado='" & c1txtCodigoEmpleado.Text & "'"
            cmdPlaniOt.Transaction = sqlTrans
            cmdPlaniOt.ExecuteNonQuery()
            '*** Prestaciones Deducciones
            cmdPrestDed = cnSQLConexion.CreateCommand
            cmdPrestDed.CommandType = CommandType.Text
            cmdPrestDed.CommandText = "UPDATE PLPrestacionesDeducciones SET CodigoEmpleado='" & c1txtNuevoCodigo.Text & "' WHERE CodigoEmpleado='" & c1txtCodigoEmpleado.Text & "'"
            cmdPrestDed.Transaction = sqlTrans
            cmdPrestDed.ExecuteNonQuery()
            '*** Prestaciones Planillas
            cmdPrestPlani = cnSQLConexion.CreateCommand
            cmdPrestPlani.CommandType = CommandType.Text
            cmdPrestPlani.CommandText = "UPDATE PLPrestacionesPlanillas SET CodigoEmpleado='" & c1txtNuevoCodigo.Text & "' WHERE CodigoEmpleado='" & c1txtCodigoEmpleado.Text & "'"
            cmdPrestPlani.Transaction = sqlTrans
            cmdPrestPlani.ExecuteNonQuery()
            '*** Prestaciones
            cmdPrest = cnSQLConexion.CreateCommand
            cmdPrest.CommandType = CommandType.Text
            cmdPrest.CommandText = "UPDATE PLPrestaciones SET CodigoEmpleado='" & c1txtNuevoCodigo.Text & "' WHERE CodigoEmpleado='" & c1txtCodigoEmpleado.Text & "'"
            cmdPrest.Transaction = sqlTrans
            cmdPrest.ExecuteNonQuery()
            '*** Vacaciones Resumen
            cmdVacRes = cnSQLConexion.CreateCommand
            cmdVacRes.CommandType = CommandType.Text
            cmdVacRes.CommandText = "UPDATE PLVacacionesResumen SET CodigoEmpleado='" & c1txtNuevoCodigo.Text & "' WHERE CodigoEmpleado='" & c1txtCodigoEmpleado.Text & "'"
            cmdVacRes.Transaction = sqlTrans
            cmdVacRes.ExecuteNonQuery()
            '*** Vacaciones
            cmdVac = cnSQLConexion.CreateCommand
            cmdVac.CommandType = CommandType.Text
            cmdVac.CommandText = "UPDATE PLVacaciones SET CodigoEmpleado='" & c1txtNuevoCodigo.Text & "' WHERE CodigoEmpleado='" & c1txtCodigoEmpleado.Text & "'"
            cmdVac.Transaction = sqlTrans
            cmdVac.ExecuteNonQuery()
            '*** Empleados
            cmdEmpl = cnSQLConexion.CreateCommand
            cmdEmpl.CommandType = CommandType.Text
            cmdEmpl.CommandText = "UPDATE PLEmpleados SET CodigoEmpleado='" & c1txtNuevoCodigo.Text & "' WHERE CodigoEmpleado='" & c1txtCodigoEmpleado.Text & "'"
            cmdEmpl.Transaction = sqlTrans
            cmdEmpl.ExecuteNonQuery()

            sqlTrans.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
            sqlTrans.Rollback()
        Finally
            cnSQLConexion.Close()
        End Try

    End Sub

    Private Sub c1txtCodigoEmpleado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1txtCodigoEmpleado.TextChanged

    End Sub

    Private Sub c1txtCodigoEmpleado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1txtCodigoEmpleado.Validating
        If c1txtCodigoEmpleado.Text <> "" Then
            drDatosEmp = PlCls.drDatosEmpleadoPlanilla(c1txtCodigoEmpleado.Text)
            If drDatosEmp.HasRows Then
                lblNombre.Text = drDatosEmp("Nombre1") & IIf(String.IsNullOrEmpty(drDatosEmp("Nombre2").ToString), "", " " & drDatosEmp("Nombre2")) & " " & drDatosEmp("Apellido1") & IIf(String.IsNullOrEmpty(drDatosEmp("Apellido2").ToString), "", " " & drDatosEmp("Apellido2"))
            Else
                drDatosEmp.Close()
                MsgBox("Empleado no Existe...", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnBuscarEmpleado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscarEmpleado.Click
        lstEmplsFrm.ShowDialog()
        If lstEmplsFrm.DialogResult = Windows.Forms.DialogResult.OK Then
            c1txtCodigoEmpleado.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Empleado").Value
        End If

    End Sub
End Class