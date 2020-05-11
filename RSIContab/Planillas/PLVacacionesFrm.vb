Public Class PLVacacionesFrm
    Dim PlCls As New PLClassLib.PlClass
    Dim lstEmplsFrm As New ListaEmpleadosFom
    Dim drDatosEmp As SqlClient.SqlDataReader
    Dim mActualizandoDiasVac As Boolean, mCargandoDatos As Boolean
    Dim intTotDiasVacaciones As Int16, decTotDiasCuentaVac As Decimal, decTotDiasGozados As Decimal, decTotDiasPagados As Decimal, decTotDiasTomados As Decimal
    Dim decTotalValorDiasTomados As Decimal
    Dim IDVacActual As Int32
    Dim mFechaIngreso As Date
    Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
    Private Sub PLVacacionesFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIPrincipal
        Me.Top = 10
        Me.Left = 10

        PlCls.DBconStr = strcnCAD
        PLVacacionesTableAdapter.Connection.ConnectionString = strcnCAD
        Me.PLTablaDiasVacacionesTableAdapter.Connection.ConnectionString = strcnCAD
        Me.PLTablaDiasVacacionesTableAdapter.Fill(Me.PLVacacionesDataSet.PLTablaDiasVacaciones)
        btnBuscarEmpleado.Enabled = True
        mActualizandoDiasVac = False
        mCargandoDatos = False

    End Sub
    Private Sub c1txtCodigoEmpleado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1txtCodigoEmpleado.Validating
        Dim mDatos As DataRowView

        If Not String.IsNullOrEmpty(c1txtCodigoEmpleado.Text) Then
            mDatos = PrincipalBindingSource.Current
            drDatosEmp = PlCls.drDatosEmpleado(c1txtCodigoEmpleado.Text)
            If drDatosEmp.HasRows Then
                mCargandoDatos = True
                lblNombre.Text = drDatosEmp("Nombre1") & IIf(String.IsNullOrEmpty(drDatosEmp("Nombre2").ToString), "", " " & drDatosEmp("Nombre2")) & " " & drDatosEmp("Apellido1") & IIf(String.IsNullOrEmpty(drDatosEmp("Apellido2").ToString), "", " " & drDatosEmp("Apellido2"))
                c1dateFecha.Value = drDatosEmp("FechaIngreso")
                lblAñosDeLabores.Text = "Años de labores: " & Math.Floor(DateDiff(DateInterval.Month, drDatosEmp("FechaIngreso"), Date.Now) / 12)
                mFechaIngreso = drDatosEmp("FechaIngreso")                
                Me.PLVacacionesTableAdapter.Fill(PLVacacionesDataSet.PLVacaciones, c1txtCodigoEmpleado.Text)
                Me.PLDiasVacacionesTomadosTableAdapter.Fill(PLVacacionesDataSet.PLDiasVacacionesTomados, 0)
                c1truedbgrdVacaciones.Enabled = True
                c1truedbgrdDiasTomados.Enabled = True
                TotalizarVacaciones()
                mCargandoDatos = False
            Else
                Me.PLVacacionesTableAdapter.Fill(PLVacacionesDataSet.PLVacaciones, "")
                Me.PLDiasVacacionesTomadosTableAdapter.Fill(PLVacacionesDataSet.PLDiasVacacionesTomados, 0)
                c1dateFecha.Value = ""
                lblAñosDeLabores.Text = ""
                drDatosEmp.Close()
                MsgBox("Empleado no Existe...", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                lblTotalDiasVac.Text = "0"
                'lblTotalDiasCuenta.Text = "0"
                lblTotalDiasGozados.Text = "0"
                lblTotDiasTomados.Text = "0"
                lblSaldo.Text = "0"
                c1truedbgrdVacaciones.Enabled = False
                c1truedbgrdDiasTomados.Enabled = False
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnBuscarEmpleado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscarEmpleado.Click
        lstEmplsFrm.ShowDialog()
        If lstEmplsFrm.DialogResult = Windows.Forms.DialogResult.OK Then
            c1txtCodigoEmpleado.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("CodigoEmpleado").Value
        End If
    End Sub
    Private Sub PrincipalBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrincipalBindingSource.PositionChanged
        'Dim mDatos As DataRowView

        'If Not mCargandoDatos Then
        ' mDatos = PrincipalBindingSource.Current
        'Me.PLDiasVacacionesTomadosTableAdapter.Fill(PLVacacionesDataSet.PLDiasVacacionesTomados, mDatos("IDVacacion"))
        'TotalizarDiasTomados()
        ''TotalizarVacaciones()
        'End If
    End Sub

    Private Sub ActualizarTablaVacaciones()
        Try
            Me.Validate()
            Me.TablaVacacionesBindingSource.EndEdit()
            Me.PLTablaDiasVacacionesTableAdapter.Update(Me.PLVacacionesDataSet.PLTablaDiasVacaciones)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ActualizarVacaciones()
        Try
            Me.Validate()
            Me.PrincipalBindingSource.EndEdit()
            Me.PLVacacionesTableAdapter.Update(Me.PLVacacionesDataSet.PLVacaciones)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ActualizarTablaDiasVacaciones()
        Try
            Me.Validate()
            Me.VacacionesTomadasBindingSource.EndEdit()
            Me.PLDiasVacacionesTomadosTableAdapter.Update(Me.PLVacacionesDataSet.PLDiasVacacionesTomados)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub c1truedbgrdTablaVacaciones_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdTablaVacaciones.AfterDelete
        ActualizarTablaVacaciones()
    End Sub

    Private Sub c1truedbgrdTablaVacaciones_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdTablaVacaciones.AfterUpdate
        ActualizarTablaVacaciones()
    End Sub

    Private Sub c1truedbgrdVacaciones_AfterColUpdate(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles c1truedbgrdVacaciones.AfterColUpdate
        If e.Column.Name = "Año Final" Then
            Dim mFecha As Date

            mFecha = c1dateFecha.Value
            c1truedbgrdVacaciones.Columns("Días").Value = PlCls.ObtenerDiasVacaciones(c1truedbgrdVacaciones.Columns("Año Final").Value - mFecha.Year)
        End If
    End Sub

    Private Sub c1truedbgrdVacaciones_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdVacaciones.AfterDelete
        ActualizarVacaciones()
    End Sub

    Private Sub c1truedbgrdVacaciones_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdVacaciones.AfterUpdate
        ActualizarVacaciones()
        TotalizarVacaciones()
    End Sub

    Private Sub c1truedbgrdDiasTomados_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdDiasTomados.AfterDelete
        ActualizarTablaDiasVacaciones()
        'TotalizarDiasTomados()
        'TotalizarVacaciones()
    End Sub

    Private Sub c1truedbgrdDiasTomados_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdDiasTomados.AfterUpdate
        'Dim intLinActual As Int32

        If c1truedbgrdDiasTomados.AddNewMode = C1.Win.C1TrueDBGrid.AddNewModeEnum.AddNewPending Then
            PlCls.ActualizarDiasTomadosVacaciones(c1truedbgrdDiasTomados.Columns("Días Tomados").Value, c1truedbgrdDiasTomados.Columns("Valor").Value, "+", IDVacActual)
            'ActualizarDiasVacaciones(c1truedbgrdDiasTomados.Columns("Tipo").Value, c1truedbgrdDiasTomados.Columns("Días Tomados").Value, "+")
        End If
        'intLinActual = c1truedbgrdDiasTomados.Row
        'TotalizarVacaciones()
        'TotalizarDiasTomados()
        'c1truedbgrdDiasTomados.Row = intLinActual
    End Sub

    Private Sub toolstripbutSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutSalir.Click
        Me.Close()
    End Sub

    Private Sub c1truedbgrdVacaciones_BeforeUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1truedbgrdVacaciones.BeforeUpdate
        c1truedbgrdVacaciones.Columns("CodigoEmpleado").Value = c1txtCodigoEmpleado.Text
        c1truedbgrdVacaciones.Columns("Fecha").Value = Date.Now
    End Sub

    Private Sub c1truedbgrdDiasTomados_BeforeDelete(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1truedbgrdDiasTomados.BeforeDelete
        If MsgBox("Desea eliminar este dato?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            PlCls.ActualizarDiasTomadosVacaciones(c1truedbgrdDiasTomados.Columns("Días Tomados").Value, c1truedbgrdDiasTomados.Columns("Valor").Value, "-", IDVacActual)
            'PlCls.ActualizarDiasTomadosVacaciones(c1truedbgrdDiasTomados.Columns("Días Tomados").Value, "-", c1truedbgrdDiasTomados.Columns("IDVacacion").Value)
            'ActualizarDiasVacaciones(c1truedbgrdDiasTomados.Columns("Tipo").Value, c1truedbgrdDiasTomados.Columns("Días Tomados").Value, "-")
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub c1truedbgrdDiasTomados_BeforeUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1truedbgrdDiasTomados.BeforeUpdate
        If mActualizandoDiasVac = False Then
            If c1truedbgrdDiasTomados.Columns("Fecha Inicial").Value > c1truedbgrdDiasTomados.Columns("Fecha Final").Value Then
                MsgBox("La Fecha Inicial no puede ser mayor que la Fecha Final", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
                e.Cancel = True
                Exit Sub
            End If
            If c1truedbgrdDiasTomados.AddNewMode = C1.Win.C1TrueDBGrid.AddNewModeEnum.AddNewPending Then
                c1truedbgrdDiasTomados.Columns("IDVacacion").Value = IDVacActual
                c1truedbgrdDiasTomados.Columns("CodigoEmpleado").Value = c1txtCodigoEmpleado.Text
                'mActualizandoDiasVac = True
                ActualizarTablaDiasVacaciones()
                'ActualizarDiasVacaciones(c1truedbgrdDiasTomados.Columns("Tipo").Value, c1truedbgrdDiasTomados.Columns("Días Tomados").Value, "+")
            Else
                e.Cancel = True
                MsgBox("No puede hacer cambios a este dato, solamente puede eliminarlo", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            End If
        End If
    End Sub
    Private Sub ActualizarDiasVacaciones(ByVal intTipo As Int16, ByVal intDias As Int16, ByVal strSigno As String, ByVal intIDVac As Int32)
        Dim mDatos As DataRowView

        mActualizandoDiasVac = True
        mDatos = PrincipalBindingSource.Current
        If intTipo = 1 Then
            If strSigno = "+" Then
                mDatos("DiasGozadosVacaciones") = mDatos("DiasGozadosVacaciones") + intDias
            Else
                mDatos("DiasGozadosVacaciones") = mDatos("DiasGozadosVacaciones") - intDias
            End If
        Else
            If strSigno = "+" Then
                mDatos("DiasCuentaVacaciones") = mDatos("DiasCuentaVacaciones") + intDias
            Else
                mDatos("DiasCuentaVacaciones") = mDatos("DiasCuentaVacaciones") - intDias
            End If
        End If
        ActualizarVacaciones()
        mActualizandoDiasVac = False
        ''If intTipo = 1 Then
        ''PlCls.ActualizarDiasTomadosVacaciones(intDias, "DiasGozadosVacaciones", strSigno)
        ''Else
        ''PlCls.ActualizarDiasTomadosVacaciones(intDias, "DiasCuentaVacaciones", strSigno)
        ''End If
        ''c1truedbgrdVacaciones.Rebind(True)

        PlCls.ActualizarDiasTomadosVacaciones(intDias, 0, strSigno, intIDVac)
    End Sub
    Private Sub TotalizarVacaciones()
        Dim i As Int16

        intTotDiasVacaciones = 0
        decTotDiasCuentaVac = 0
        decTotDiasGozados = 0
        decTotDiasPagados = 0
        For i = 0 To c1truedbgrdVacaciones.RowCount - 1
            c1truedbgrdVacaciones.Row = i
            intTotDiasVacaciones = intTotDiasVacaciones + c1truedbgrdVacaciones.Columns("Días").Value
            decTotDiasCuentaVac = decTotDiasCuentaVac + c1truedbgrdVacaciones.Columns("Días a Cuenta de Vac.").Value
            decTotDiasGozados = decTotDiasGozados + c1truedbgrdVacaciones.Columns("Días Gozados").Value
            decTotDiasPagados = decTotDiasPagados + c1truedbgrdVacaciones.Columns("Días Pagados").Value
        Next
        lblTotalDiasVac.Text = intTotDiasVacaciones
        'lblTotalDiasCuenta.Text = decTotDiasCuentaVac
        lblTotalDiasGozados.Text = Format(decTotDiasGozados, "#,##0.00")
        lblTotalDiasPagados.Text = Format(decTotDiasPagados, "#,##0.00")
        lblSaldo.Text = Format(intTotDiasVacaciones - decTotDiasCuentaVac - decTotDiasGozados - decTotDiasPagados, "#,##0.00")
    End Sub
    Private Sub TotalizarDiasTomados()
        Dim i As Int16

        decTotDiasTomados = 0
        decTotalValorDiasTomados = 0
        For i = 0 To c1truedbgrdDiasTomados.RowCount - 1
            c1truedbgrdDiasTomados.Row = i
            decTotDiasTomados = decTotDiasTomados + c1truedbgrdDiasTomados.Columns("Días Tomados").Value
            decTotalValorDiasTomados = decTotalValorDiasTomados + c1truedbgrdDiasTomados.Columns("Valor").Value
        Next
        lblTotDiasTomados.Text = Format(decTotDiasTomados, "#,##0.00")
        lblTotalValorDiasTomados.Text = Format(decTotalValorDiasTomados, "#,##0.00")
    End Sub

    Private Sub c1truedbgrdVacaciones_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles c1truedbgrdVacaciones.ButtonClick
        Dim mDatos As DataRowView


        mDatos = PrincipalBindingSource.Current
        IDVacActual = mDatos("IDVacacion")
        c1truedbgrdDiasTomados.Caption = "Días Tomados en el Período " & mDatos("AñoInicial") & "-" & mDatos("AñoFinal")
        Me.PLDiasVacacionesTomadosTableAdapter.Fill(PLVacacionesDataSet.PLDiasVacacionesTomados, mDatos("IDVacacion"))
        TotalizarDiasTomados()
    End Sub

    Private Sub c1truedbgrdDiasTomados_OnAddNew(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdDiasTomados.OnAddNew
        mActualizandoDiasVac = False
    End Sub

    Private Sub toolstripbutRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutRefrescar.Click
        mCargandoDatos = True
        Me.PLVacacionesTableAdapter.Fill(PLVacacionesDataSet.PLVacaciones, c1txtCodigoEmpleado.Text)
        Me.PLDiasVacacionesTomadosTableAdapter.Fill(PLVacacionesDataSet.PLDiasVacacionesTomados, 0)
        mCargandoDatos = False
    End Sub

    Private Sub toolstripbutImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutImprimir.Click
        Dim strSQL As String

        rptClass.DBconStr = strcnCAD
        strSQL = "{PLVacaciones.CodigoEmpleado}='" & c1txtCodigoEmpleado.Text & "'"
        rptClass.EjecutarReporteVacaciones(strcnCAD, My.Settings.RSIEmpresaActual, Date.Now, "D", 0, 0, 0, strSQL)
    End Sub

    Private Sub c1truedbgrdVacaciones_Click(sender As System.Object, e As System.EventArgs) Handles c1truedbgrdVacaciones.Click

    End Sub
End Class