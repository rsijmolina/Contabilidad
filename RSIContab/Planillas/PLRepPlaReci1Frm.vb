Public Class PLRepPlaReci1Frm
    Dim PlCls As New PLClassLib.PlClass
    Dim drConfPlani As SqlClient.SqlDataReader
    Dim drDefDed As SqlClient.SqlDataReader
    Dim drDatosEmp As SqlClient.SqlDataReader
    Dim rptClass As New RSIRPTCLS.RptCls.PLRpt
    Dim RSICls As New Rsierpgencl.Rsierpcl.Cadenas
    Dim lstEmplsFrm As New ListaEmpleadosFom

    Private Sub PLRepPlaReci1Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PLRepRecibosDataSet.PLDefinicionDeducciones' Puede moverla o quitarla según sea necesario.
        Me.PLDefinicionDeduccionesTableAdapter.Fill(Me.PLRepRecibosDataSet.PLDefinicionDeducciones)
        c1dateFecha.Value = Date.Now
        PlCls.DBconStr = strcnCAD
        drConfPlani = PlCls.drConf
        rptClass.BaseDatosRpt = BaseDatosActual
        c1numNoPlanilla.Value = drConfPlani("NoPlanilla")
        lblDescPlanilla.Text = PlCls.DescripcionPlanilla(drConfPlani("NoPlanilla"))
        lstEmplsFrm.EmpleadosRetirados = False
        lstEmplsFrm.OrdenarPorCodigo = False
        btnBuscarEmpleado.Enabled = True        
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
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
        drDatosEmp = PlCls.drDatosEmpleado(c1txtCodigoEmpleado.Text)
        If drDatosEmp.HasRows Then
            lblNombreEmpleado.Text = drDatosEmp("Nombre1") & IIf(String.IsNullOrEmpty(drDatosEmp("Nombre2")), "", " " & drDatosEmp("Nombre2")) _
                & " " & drDatosEmp("Apellido1") & IIf(String.IsNullOrEmpty(drDatosEmp("Apellido2")), "", " " & drDatosEmp("Apellido2"))
        Else
            MsgBox("Empleado No Exsite", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub c1truedbgrdDefDeducciones_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdDefDeducciones.AfterUpdate
        Try
            Me.Validate()
            Me.PrincipalBindingSource.EndEdit()
            Me.PLDefinicionDeduccionesTableAdapter.Update(Me.PLRepRecibosDataSet.PLDefinicionDeducciones)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub c1numNoPlanilla_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles c1numNoPlanilla.Validating
        lblDescPlanilla.Text = PlCls.DescripcionPlanilla(c1numNoPlanilla.Value)
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim strSel As String, strDedTit1 As String, strDedTit2 As String, strDedTit3 As String, strDedTit4 As String, strDedTit5 As String, strDedTit6 As String, strDedTit7 As String
        Dim strDedTit8 As String, strDedTit9 As String, strDedTit10 As String, strDedTit11 As String, strDedTit12 As String, strRep As String
        Dim strIngTit1 As String, strIngTit2 As String, strIngTit3 As String, strIngTit4 As String, strIngTit5 As String

        '*******************************************************
        '*Para ENLACE los ingresos serán así:
        '*1. Comisiones, 2. Bonificaciones, 3. Anticipos --> IngresosAdicionales1, 4. Movilizaciones --> IngresosAdicionales2
        '*5. Vigilias/Dom --> IngresosAdicionales3, 6. Vacaciones, 7. Reembolsos --> IngresosAdicionales4, 8. OtrosIng --> IngresosAdicionales5
        '*******************************************************

        strIngTit1 = IIf(String.IsNullOrEmpty(drConfPlani("NombreIngreso1").ToString), "", drConfPlani("NombreIngreso1"))
        strIngTit2 = IIf(String.IsNullOrEmpty(drConfPlani("NombreIngreso2").ToString), "", drConfPlani("NombreIngreso2"))
        strIngTit3 = IIf(String.IsNullOrEmpty(drConfPlani("NombreIngreso3").ToString), "", drConfPlani("NombreIngreso3"))
        strIngTit4 = IIf(String.IsNullOrEmpty(drConfPlani("NombreIngreso4").ToString), "", drConfPlani("NombreIngreso4"))
        strIngTit5 = IIf(String.IsNullOrEmpty(drConfPlani("NombreIngreso5").ToString), "", drConfPlani("NombreIngreso5"))

        PLProcDeduccionesFrm.Año = drConfPlani("AñoEnProceso")
        PLProcDeduccionesFrm.Mes = drConfPlani("MesEnProceso")
        PLProcDeduccionesFrm.NoPlanilla = drConfPlani("NoPlanilla")
        PLProcDeduccionesFrm.Procesar("RECIBOS")

        drDefDed = PlCls.drDefDeducciones("")
        If chkListarEmpleado.Checked Then
            strSel = "{PLPLanillas.Año}=" & drConfPlani("AñoEnProceso") & " AND {PLPLanillas.Mes}=" & drConfPlani("MesEnProceso") & " AND {PLPLanillas.NoPlanilla}=" & c1numNoPlanilla.Value & " AND {PLPlanillas.CodigoEmpleado}='" & c1txtCodigoEmpleado.Text & "'"
        Else
            strSel = "{PLPLanillas.Año}=" & drConfPlani("AñoEnProceso") & " AND {PLPLanillas.Mes}=" & drConfPlani("MesEnProceso") & " AND {PLPLanillas.NoPlanilla}=" & c1numNoPlanilla.Value
        End If

        strDedTit1 = "" : strDedTit2 = "" : strDedTit3 = "" : strDedTit4 = "" : strDedTit5 = "" : strDedTit6 = "" : strDedTit7 = "" : strDedTit8 = "" : strDedTit9 = "" : strDedTit10 = "" : strDedTit11 = "" : strDedTit12 = ""
        While drDefDed.Read
            Select Case drDefDed("ReciNoPosicion")
                Case 1
                    strDedTit1 = drDefDed("ReciTituloColumna")
                Case 2
                    strDedTit2 = drDefDed("ReciTituloColumna")
                Case 3
                    strDedTit3 = drDefDed("ReciTituloColumna")
                Case 4
                    strDedTit4 = drDefDed("ReciTituloColumna")
                Case 5
                    strDedTit5 = drDefDed("ReciTituloColumna")
                Case 6
                    strDedTit6 = drDefDed("ReciTituloColumna")
                Case 7
                    strDedTit7 = drDefDed("ReciTituloColumna")
                Case 8
                    strDedTit8 = drDefDed("ReciTituloColumna")
                Case 9
                    strDedTit9 = drDefDed("ReciTituloColumna")
                Case 10
                    strDedTit10 = drDefDed("ReciTituloColumna")
                Case 11
                    strDedTit11 = drDefDed("ReciTituloColumna")
                Case 12
                    strDedTit12 = drDefDed("ReciTituloColumna")
            End Select
        End While

        strRep = "PLRecibos2Rpt"
        rptClass.EjecutarRecibosPlanilla(strcnCAD, My.Settings.RSIEmpresaActual, strRep, strSel, lblDescPlanilla.Text, c1dateFecha.Value, strIngTit1, strIngTit2, strIngTit3, strIngTit4, strIngTit5, _
            strDedTit1, strDedTit2, strDedTit3, strDedTit4, strDedTit5, strDedTit6, strDedTit7, strDedTit8, strDedTit9, strDedTit10, strDedTit11, strDedTit12)
    End Sub

    Private Sub btnBuscarEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarEmpleado.Load

    End Sub

    Private Sub c1txtCodigoEmpleado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1txtCodigoEmpleado.TextChanged

    End Sub
End Class