Public Class PLRepVacacionesFrm
    Dim PlCls As New PLClassLib.PlClass
    Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
    Dim mDatos As DataRowView
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub PLRepVacacionesFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PlCls.DBconStr = strcnCAD
        c1dateFecha.Value = Date.Now
        c1numAnioFinal.Value = Date.Now.Year - 1
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click        
        Dim drEmpVacRes As SqlClient.SqlDataReader
        Dim strSQL As String

        rptClass.DBconStr = strcnCAD
        If radiobutEmpleadosActivos.Checked Then
            strSQL = "NOT {PLEmpleados.RetiradoDeEmpresa}"
        Else
            strSQL = "{PLEmpleados.RetiradoDeEmpresa}"
        End If
        If radiobutDesglosado.Checked Then
            rptClass.EjecutarReporteVacaciones(strcnCAD, My.Settings.RSIEmpresaActual, c1dateFecha.Value, "D", 0, 0, 0, strSQL)
        Else
            PlCls.BorrarVacacionesResumen()
            drEmpVacRes = PlCls.drEmpVacacionesRep(c1numAnioFinal.Value)
            While drEmpVacRes.Read
                PrincipalBindingSource.AddNew()
                mDatos = PrincipalBindingSource.Current
                mDatos("CodigoEmpleado") = drEmpVacRes("CodigoEmpleado")
                ActualizarResumen(drEmpVacRes("CodigoEmpleado"))
            End While
            Try
                Me.Validate()
                Me.PrincipalBindingSource.EndEdit()
                Me.PLVacacionesResumenTableAdapter.Update(Me.PLVacResumenDataSet.PLVacacionesResumen)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            drEmpVacRes.Close()
            rptClass.EjecutarReporteVacaciones(strcnCAD, My.Settings.RSIEmpresaActual, c1dateFecha.Value, "R", c1numAnioFinal.Value - 1, c1numAnioFinal.Value, c1numAnioFinal.Value, strSQL)
            Me.Close()
        End If

    End Sub
    Private Sub ActualizarResumen(strEmp As String)
        Dim drVacRes As SqlClient.SqlDataReader
        Dim i As Int16

        drVacRes = PlCls.drVacacionesRep(strEmp, c1numAnioFinal.Value)
        i = 1
        While drVacRes.Read
            If i = 1 Then
                mDatos("DiasVacacionesAño1") = drVacRes("DiasVacaciones")
                mDatos("DiasTomadosAño1") = drVacRes("DiasGozadosVacaciones")
                mDatos("DiasPagadosAño1") = drVacRes("DiasPagados")
                mDatos("ValorDiasPagadosAño1") = drVacRes("ValorPagado")
            ElseIf i = 2 Then
                mDatos("DiasVacacionesAño2") = drVacRes("DiasVacaciones")
                mDatos("DiasTomadosAño2") = drVacRes("DiasGozadosVacaciones") + drVacRes("DiasPagados")
                mDatos("DiasPagadosAño2") = drVacRes("DiasPagados")
                mDatos("ValorDiasPagadosAño2") = drVacRes("ValorPagado")
                Exit While
                'Else
                'mDatos("DiasVacacionesAño3") = drVacRes("DiasVacaciones")
                'mDatos("DiasTomadosAño3") = drVacRes("DiasGozadosVacaciones") + drVacRes("DiasPagados")
                'Exit While
            End If
            i = i + 1
        End While
        drVacRes.Close()
    End Sub
End Class