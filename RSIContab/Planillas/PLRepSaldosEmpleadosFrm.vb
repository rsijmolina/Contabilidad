Public Class PLRepSaldosEmpleadosFrm
    Dim PlCls As New PLClassLib.PlClass
    Dim drConfPlani As SqlClient.SqlDataReader
    Dim drDefDed As SqlClient.SqlDataReader
    Dim drDatosEmp As SqlClient.SqlDataReader
    Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
    Dim lstEmplsFrm As New ListaEmpleadosFom
    Dim lstDedFrm As New ListasFrm

    Private Sub PLRepSaldosEmpleadosFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        c1dateFecha.Value = Date.Now
        PlCls.DBconStr = strcnCAD
        drConfPlani = PlCls.drConf
        rptClass.BaseDatosRpt = BaseDatosActual

        lstEmplsFrm.OrdenarPorCodigo = True
        lstEmplsFrm.EmpleadosRetirados = False
        btnBuscarRangoIni.Enabled = True
        btnBuscarRangoFin.Enabled = True
        lstDedFrm.NombreLista = "Deducciones"
        lstDedFrm.CampoOrdenar = "CodigoDeduccion"
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub radiobutEmpleado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radiobutEmpleado.Click
        c1txtRangoIni.Text = ""
        c1txtRangoFin.Text = ""
        lblNombreIni.Text = ""
        lblNombreFin.Text = ""
    End Sub

    Private Sub radiobutDeduccion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radiobutDeduccion.Click
        c1txtRangoIni.Text = ""
        c1txtRangoFin.Text = ""
        lblNombreIni.Text = ""
        lblNombreFin.Text = ""
    End Sub

    Private Sub btnBuscarRangoIni_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscarRangoIni.Click
        If radiobutEmpleado.Checked Then
            lstEmplsFrm.ShowDialog()
            If lstEmplsFrm.DialogResult = Windows.Forms.DialogResult.OK Then
                c1txtRangoIni.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("CodigoEmpleado").Value
                lblNombreIni.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre1").Value & IIf(String.IsNullOrEmpty(lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre2").Value), "", " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre2").Value) _
                    & " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido1").Value & IIf(String.IsNullOrEmpty(lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido2").Value), "", " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido2").Value)
            End If
        ElseIf radiobutDeduccion.Checked Then
            lstDedFrm.ControlDestino = c1txtRangoIni
            lstDedFrm.ControlDescripcion = lblNombreIni
            lstDedFrm.ShowDialog()
            If lstDedFrm.DialogResult = Windows.Forms.DialogResult.OK Then
                lblNombreIni.Text = lstDedFrm.c1dbgrdListas.Columns("DescripcionDeduccion").Value
            End If
        End If
    End Sub

    Private Sub btnBuscarRangoFin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscarRangoFin.Click
        If radiobutEmpleado.Checked Then
            lstEmplsFrm.ShowDialog()
            If lstEmplsFrm.DialogResult = Windows.Forms.DialogResult.OK Then
                c1txtRangoFin.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("CodigoEmpleado").Value
                lblNombreFin.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre1").Value & IIf(String.IsNullOrEmpty(lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre2").Value), "", " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Nombre2").Value) _
                    & " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido1").Value & IIf(String.IsNullOrEmpty(lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido2").Value), "", " " & lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Apellido2").Value)
            End If
        ElseIf radiobutDeduccion.Checked Then
            lstDedFrm.ControlDestino = c1txtRangoFin
            lstDedFrm.ControlDescripcion = lblNombreFin
            lstDedFrm.ShowDialog()
            If lstDedFrm.DialogResult = Windows.Forms.DialogResult.OK Then
                lblNombreFin.Text = lstDedFrm.c1dbgrdListas.Columns("DescripcionDeduccion").Value
            End If
        End If
    End Sub

    Private Sub c1txtRangoIni_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1txtRangoIni.Validating
        If Not String.IsNullOrEmpty(c1txtRangoIni.Text) Then
            If radiobutEmpleado.Checked Then
                drDatosEmp = PlCls.drDatosEmpleado(c1txtRangoIni.Text)
                If drDatosEmp.HasRows Then
                    lblNombreIni.Text = drDatosEmp("Nombre1") & IIf(String.IsNullOrEmpty(drDatosEmp("Nombre2")), "", " " & drDatosEmp("Nombre2")) _
                        & " " & drDatosEmp("Apellido1") & IIf(String.IsNullOrEmpty(drDatosEmp("Apellido2")), "", " " & drDatosEmp("Apellido2"))
                Else
                    MsgBox("Empleado No Exsite", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                End If
            ElseIf radiobutDeduccion.Checked Then
                drDefDed = PlCls.drDefDeducciones(c1txtRangoIni.Text)
                If Not drDefDed.HasRows Then
                    lblNombreIni.Text = ""
                    MsgBox("Codigo de Deduccion no Existe...", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
                Else
                    lblNombreIni.Text = drDefDed("DescripcionDeduccion")
                End If
            End If
        End If
    End Sub

    Private Sub c1txtRangoFin_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1txtRangoFin.Validating
        If Not String.IsNullOrEmpty(c1txtRangoFin.Text) Then
            If radiobutEmpleado.Checked Then
                drDatosEmp = PlCls.drDatosEmpleado(c1txtRangoFin.Text)
                If drDatosEmp.HasRows Then
                    lblNombreFin.Text = drDatosEmp("Nombre1") & IIf(String.IsNullOrEmpty(drDatosEmp("Nombre2")), "", " " & drDatosEmp("Nombre2")) _
                        & " " & drDatosEmp("Apellido1") & IIf(String.IsNullOrEmpty(drDatosEmp("Apellido2")), "", " " & drDatosEmp("Apellido2"))
                Else
                    MsgBox("Empleado No Exsite", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                End If
            ElseIf radiobutDeduccion.Checked Then
                drDefDed = PlCls.drDefDeducciones(c1txtRangoFin.Text)
                If Not drDefDed.HasRows Then
                    lblNombreFin.Text = ""
                    MsgBox("Codigo de Deduccion no Existe...", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
                Else
                    lblNombreFin.Text = drDefDed("DescripcionDeduccion")
                End If
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim strSel As String

        If radiobutEmpleado.Checked Then
            If chkListarTodo.Checked Then
                If chkListarDedPermanentes.Checked Then
                    strSel = "{PLDeducciones.Valor}>{PLDeducciones.MontoDeducido} OR {PLDeducciones.DeduccionPermanente} AND NOT {PLDeducciones.Anulada}"
                Else
                    strSel = "{PLDeducciones.Valor}>{PLDeducciones.MontoDeducido} AND NOT {PLDeducciones.DeduccionPermanente} AND NOT {PLDeducciones.Anulada}"
                End If
            Else
                If chkListarDedPermanentes.Checked Then
                    strSel = "{PLDeducciones.CodigoEmpleado}>='" & c1txtRangoIni.Text & "' AND {PLDeducciones.CodigoEmpleado}<='" & c1txtRangoFin.Text & "' AND ({PLDeducciones.Valor}>{PLDeducciones.MontoDeducido} OR {PLDeducciones.DeduccionPermanente}) AND NOT {PLDeducciones.Anulada}"
                Else
                    strSel = "{PLDeducciones.CodigoEmpleado}>='" & c1txtRangoIni.Text & "' AND {PLDeducciones.CodigoEmpleado}<='" & c1txtRangoFin.Text & "' AND {PLDeducciones.Valor}>{PLDeducciones.MontoDeducido} AND NOT {PLDeducciones.DeduccionPermanente} AND NOT {PLDeducciones.Anulada}"
                End If
            End If

            rptClass.EjecutarReportesVarios(strcnCAD, My.Settings.RSIEmpresaActual, "PLSalPendEmp1Rpt", strSel, "", c1dateFecha.Value)
        Else
            If chkListarTodo.Checked Then
                If chkListarDedPermanentes.Checked Then
                    strSel = "{PLDeducciones.Valor}>{PLDeducciones.MontoDeducido} OR {PLDeducciones.DeduccionPermanente} AND NOT {PLDeducciones.Anulada}"
                Else
                    strSel = "{PLDeducciones.Valor}>{PLDeducciones.MontoDeducido} AND NOT {PLDeducciones.DeduccionPermanente} AND NOT {PLDeducciones.Anulada}"
                End If
            Else
                If chkListarDedPermanentes.Checked Then
                    strSel = "{PLDeducciones.CodigoDeduccion}>='" & c1txtRangoIni.Text & "' AND {PLDeducciones.CodigoDeduccion}<='" & c1txtRangoFin.Text & "' AND ({PLDeducciones.Valor}>{PLDeducciones.MontoDeducido} OR {PLDeducciones.DeduccionPermanente}) AND NOT {PLDeducciones.Anulada}"
                Else
                    strSel = "{PLDeducciones.CodigoDeduccion}>='" & c1txtRangoIni.Text & "' AND {PLDeducciones.CodigoDeduccion}<='" & c1txtRangoFin.Text & "' AND {PLDeducciones.Valor}>{PLDeducciones.MontoDeducido} AND NOT {PLDeducciones.DeduccionPermanente} AND NOT {PLDeducciones.Anulada}"
                End If
            End If

            rptClass.EjecutarReportesVarios(strcnCAD, My.Settings.RSIEmpresaActual, "PLSalPendEmp2Rpt", strSel, "", c1dateFecha.Value)
        End If
    End Sub
End Class