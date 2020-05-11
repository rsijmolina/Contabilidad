Public Class CTTransaccionesContFrm
    Dim CTCls As New CTClassLib.CTClass
    Dim RSICadenas As New Rsierpgencl.Rsierpcl.Cadenas
    Dim drCnf As SqlClient.SqlDataReader
    Dim CTListaCatFrm As New CTListaCatalogoFrm    
    Dim CTListaTransFrm As New CTListaTransaccionesFrm    
    Dim boBuscando As Boolean
    Dim decTotalDebe As Decimal
    Dim decTotalHaber As Decimal
    Dim mBuscando As Boolean

    Private Sub CTTransaccionesContFrm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If DataNavBarPrincipal.ModalidadDeshabilitadoTotal Then
            MsgBox("Cierre las ventanas asociadas", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            e.Cancel = True
        End If
        'CTTransComFrm.Close()
        CTListaCatFrm.Close()
        CTListaTransFrm.Close()
    End Sub

    Private Sub CTTransaccionesContFrm_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If DataNavBarPrincipal.ModalidadDeshabilitadoTotal Then
            Exit Sub
        End If
        If Not c1dbgrdDetalle.Focused Then
            Select Case e.KeyCode
                Case Keys.PageDown
                    DataNavBarPrincipal.toolstripbutSiguienteRegistro.PerformClick()
                Case Keys.PageUp
                    DataNavBarPrincipal.toolstripbutRegistroAnterior.PerformClick()
                Case Keys.Home
                    DataNavBarPrincipal.toolstripbutPrimerRegistro.PerformClick()
                Case Keys.End
                    DataNavBarPrincipal.toolstripbutUltimoRegistro.PerformClick()
            End Select
        Else
            'My.Computer.Keyboard.SendKeys(e.KeyCode)
        End If
        If e.Control = True Then
            Select Case e.KeyCode
                Case Keys.N
                    DataNavBarPrincipal.toolstripbutNuevoRegistro.PerformClick()
                Case Keys.G
                    DataNavBarPrincipal.toolstripbutGuardarRegistro.PerformClick()
                Case Keys.Z
                    DataNavBarPrincipal.toolstripbutCancelarGuardar.PerformClick()
                Case Keys.M
                    DataNavBarPrincipal.toolstripbutModificarRegistro.PerformClick()
                Case Keys.E
                    DataNavBarPrincipal.toolstripbutEliminarRegistro.PerformClick()
                Case Keys.A
                    DataNavBarPrincipal.toolstripbutAnularDocumento.PerformClick()
                Case Keys.F
                    DataNavBarPrincipal.toolstripbutCerrarDocumento.PerformClick()
                Case Keys.T
                    DataNavBarPrincipal.toolstripbutContabilizar.PerformClick()
                Case Keys.B
                    DataNavBarPrincipal.toolstripbutBuscar.PerformClick()
                Case Keys.R
                    DataNavBarPrincipal.toolstripbutReiniciarDatos.PerformClick()
                Case Keys.S
                    DataNavBarPrincipal.toolstripbutSalir.PerformClick()
            End Select
        End If

    End Sub
    Private Sub CTTransaccionesContFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIPrincipal
        Me.Top = 10
        Me.Left = 10

        CTCls.DBconStr = strcnCAD
        drCnf = CTCls.drConf
        Me.CTCatalogoCuentasTableAdapter.Connection.ConnectionString = strcnCAD
        Me.CTTiposPartidasTableAdapter.Connection.ConnectionString = strcnCAD
        Me.CTTransaccionesEncabezadoTableAdapter.Connection.ConnectionString = strcnCAD
        Me.CTTransaccionesDetalleTableAdapter.Connection.ConnectionString = strcnCAD
        Me.CTCatalogoCuentasTableAdapter.Fill(Me.CTTransaccionesDataSet.CTCatalogoCuentas)
        Me.CTTiposPartidasTableAdapter.Fill(Me.CTTransaccionesDataSet.CTTiposPartidas)
        Me.CTTransaccionesEncabezadoTableAdapter.Fill(Me.CTTransaccionesDataSet.CTTransaccionesEncabezado, drCnf("AñoEnProceso"), drCnf("MesEnProceso"))
        DataNavBarPrincipal.toolstripMensaje.Text = "Año: " & drCnf("AñoEnProceso") & "   Mes: " & RSICadenas.MesLetras(drCnf("MesEnProceso"))
        DataNavBarPrincipal.toolstriptextBuscar.ToolTipText = "Buscar por Número de Transacción"
        If PrincipalBindingSource.Count > 0 Then
            DataNavBarPrincipal.toolstriptextPosicionReg.Text = PrincipalBindingSource.Position + 1 & "/" & PrincipalBindingSource.Count
        End If
        If drCnf("NumeracionAutoPartidas") Then
            c1txtNoTransaccion.Tag = "N"
        End If
        btnBuscarTransaccion.Enabled = True
        mBuscando = False
        DataNavBarPrincipal.RefrescarInfo()

    End Sub

    Private Sub RefrescarDetalle()
        Dim LineaDatosRow As DataRowView

        If Not boBuscando Then
            If DataNavBarPrincipal.NuevoRegistro = False Then
                LineaDatosRow = PrincipalBindingSource.Current
                If IsNothing(LineaDatosRow) Then
                    Me.CTTransaccionesDetalleTableAdapter.Fill(Me.CTTransaccionesDataSet.CTTransaccionesDetalle, 0, 0, 0)
                    Totalizar()
                    Exit Sub
                Else
                    Me.CTTransaccionesDetalleTableAdapter.Fill(Me.CTTransaccionesDataSet.CTTransaccionesDetalle, drCnf("AñoEnProceso"), drCnf("MesEnProceso"), LineaDatosRow("NoTransaccion"))
                    DataNavBarPrincipal.UltimaLinDet = CTCls.ObtenerUltimaLinea(LineaDatosRow("NoTransaccion"))
                End If
            Else
                Me.CTTransaccionesDetalleTableAdapter.Fill(Me.CTTransaccionesDataSet.CTTransaccionesDetalle, 0, 0, 0)
            End If
            Totalizar()
        End If
    End Sub
    Private Sub Totalizar()
        Dim i As Int16

        decTotalDebe = 0
        decTotalHaber = 0
        For i = 0 To c1dbgrdDetalle.RowCount - 1
            decTotalDebe = decTotalDebe + c1dbgrdDetalle(i, "Debe")
            decTotalHaber = decTotalHaber + c1dbgrdDetalle(i, "Haber")
        Next
        lblTotalDebe.Text = Format(decTotalDebe, "#,##0.00")
        lblTotalHaber.Text = Format(decTotalHaber, "#,##0.00")
    End Sub

    Private Sub DataNavBarPrincipal_AnularRegistroClick(sender As Object, e As System.EventArgs) Handles DataNavBarPrincipal.AnularRegistroClick
        Dim LineaDatosRow As DataRowView

        If MsgBox("Desea Anular Este Documento", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Anular Documento") = MsgBoxResult.No Then
            Exit Sub
        End If
        LineaDatosRow = PrincipalBindingSource.Current
        '** Actualizar el encabezado ***
        LineaDatosRow("Cerrado") = True
        LineaDatosRow("Anulado") = True
        ActualizarDatosEncabezado()
        DataNavBarPrincipal.RefrescarInfo()
    End Sub

    Private Sub DataNavBarPrincipal_EliminarRegistroClick(sender As Object, e As System.EventArgs) Handles DataNavBarPrincipal.EliminarRegistroClick
        Dim LineaDatosRow As DataRowView

        If MsgBox("Desea Eliminar Esta Transacción", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar Transacción") = MsgBoxResult.No Then
            Exit Sub
        End If

        LineaDatosRow = PrincipalBindingSource.Current
        LineaDatosRow.Delete()
        ActualizarDatosEncabezado()
        Me.PrincipalBindingSource.MoveFirst()
        If PrincipalBindingSource.Count > 0 Then
            DataNavBarPrincipal.toolstriptextPosicionReg.Text = PrincipalBindingSource.Position + 1 & "/" & PrincipalBindingSource.Count
        Else
            DataNavBarPrincipal.toolstriptextPosicionReg.Text = ""
        End If

    End Sub

    Private Sub DataNavBarPrincipal_GuardarRegistroClick(sender As Object, e As System.EventArgs, ByRef Cancelar As Boolean) Handles DataNavBarPrincipal.GuardarRegistroClick
        Dim EncDatosRow As DataRowView
        Dim mFecha As Date

        mFecha = c1dateFecha.Text
        If mFecha.Month <> drCnf("MesEnProceso") Or mFecha.Year <> drCnf("AñoEnProceso") Then
            MsgBox("Los datos de la fecha no coinciden con el mes y año en proceso...", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        Try
            If drCnf("NumeracionAutoPartidas") Then
                c1txtNoTransaccion.Text = CTCls.ObtenerNoTransaccion()
            End If
            EncDatosRow = Me.PrincipalBindingSource.Current
            EncDatosRow("Año") = drCnf("AñoEnProceso")
            EncDatosRow("Mes") = drCnf("MesEnProceso")
            EncDatosRow("Usuario") = My.Settings.RSIUsuarioActual

            DataNavBarPrincipal.ResultadoValidacion = ""
            DataNavBarPrincipal.ValidacionCorrecta = True
            DataNavBarPrincipal.ValidarInfo(Me)
            If DataNavBarPrincipal.ValidacionCorrecta = True Then
                ActualizarDatosEncabezado()
                If drCnf("NumeracionAutoPartidas") Then
                    EncDatosRow = Me.PrincipalBindingSource.Current
                    CTCls.ActualizarUltimaTransaccion(EncDatosRow("NoDocumento"))
                End If
            Else
                MsgBox("Verifique los siguientes datos:" & vbCrLf & DataNavBarPrincipal.ResultadoValidacion)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub DataNavBarPrincipal_NuevoRegistroClick(sender As Object, e As System.EventArgs, ByRef Cancelar As Boolean) Handles DataNavBarPrincipal.NuevoRegistroClick
        c1dateFecha.Value = drCnf("FechaProceso")
    End Sub
    Private Sub DataNavBarPrincipal_BuscarRegistroClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.BuscarRegistroClick
        boBuscando = False
        Try
            boBuscando = True
            Me.CTTransaccionesEncabezadoTableAdapter.FillByAñoMesNoTransaccion(Me.CTTransaccionesDataSet.CTTransaccionesEncabezado, drCnf("AñoEnProceso"), drCnf("MesEnProceso"), DataNavBarPrincipal.toolstriptextBuscar.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        boBuscando = False

        If Me.CTTransaccionesDataSet.CTTransaccionesEncabezado.Rows.Count > 0 Then
            RefrescarDetalle()
        Else
            MsgBox("Registro no existe", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            DataNavBarPrincipal_ReiniciarDatosClick(Me, e)
        End If
        DataNavBarPrincipal.RefrescarInfo()

    End Sub

    Private Sub ActualizarDatosEncabezado()
        Try
            Me.Validate()
            Me.PrincipalBindingSource.EndEdit()
            Me.CTTransaccionesEncabezadoTableAdapter.Update(Me.CTTransaccionesDataSet.CTTransaccionesEncabezado)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub c1dbgrdDetalle_AfterColUpdate(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles c1dbgrdDetalle.AfterColUpdate
        If e.Column.Name = "Debe" Then
            If c1dbgrdDetalle.Columns("Haber").Value > 0 Then
                c1dbgrdDetalle.Columns("Haber").Value = 0
            End If
        Else
            If c1dbgrdDetalle.Columns("Debe").Value > 0 Then
                c1dbgrdDetalle.Columns("Debe").Value = 0
            End If
        End If
    End Sub

    Private Sub c1dbgrdDetalle_AfterDelete(sender As Object, e As System.EventArgs) Handles c1dbgrdDetalle.AfterDelete
        Try
            Me.Validate()
            Me.DetalleBindingSource.EndEdit()
            Me.CTTransaccionesDetalleTableAdapter.Update(Me.CTTransaccionesDataSet.CTTransaccionesDetalle)
            Totalizar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub c1dbgrdDetalle_AfterUpdate(sender As Object, e As System.EventArgs) Handles c1dbgrdDetalle.AfterUpdate

        Try
            'Me.Validate( )
            Me.DetalleBindingSource.EndEdit()
            Me.CTTransaccionesDetalleTableAdapter.Update(Me.CTTransaccionesDataSet.CTTransaccionesDetalle)
            Totalizar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub c1dbgrdDetalle_BeforeDelete(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1dbgrdDetalle.BeforeDelete
        If MsgBox("Desea eliminar este dato", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub c1dbgrdDetalle_BeforeUpdate(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1dbgrdDetalle.BeforeUpdate
        Dim EncDatosRow As DataRowView

        If c1dbgrdDetalle.AddNewMode = C1.Win.C1TrueDBGrid.AddNewModeEnum.AddNewPending Then  'Si está agregando un nuevo registro
            EncDatosRow = Me.PrincipalBindingSource.Current
            DataNavBarPrincipal.UltimaLinDet = DataNavBarPrincipal.UltimaLinDet + 1
            c1dbgrdDetalle.Columns("NoTransaccion").Value = EncDatosRow("NoTransaccion")
            c1dbgrdDetalle.Columns("Año").Value = EncDatosRow("Año")
            c1dbgrdDetalle.Columns("Mes").Value = EncDatosRow("Mes")
            c1dbgrdDetalle.Columns("Fecha").Value = EncDatosRow("Fecha")
            c1dbgrdDetalle.Columns("Linea").Value = DataNavBarPrincipal.UltimaLinDet
        End If
    End Sub

    Private Sub c1dbgrdDetalle_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles c1dbgrdDetalle.ButtonClick
        If Not DataNavBarPrincipal.ModalidadSoloLectura Then
            If e.Column.Name = "Cuenta" Then
                CTListaCatFrm.ShowDialog()
                If CTListaCatFrm.mAceptar Then
                    c1dbgrdDetalle.Columns("Cuenta").Value = CTListaCatFrm.treeviewCatalogo.SelectedNode.Name
                    c1dbgrdDetalle.Columns("Descripción").Value = CTListaCatFrm.treeviewCatalogo.SelectedNode.Text
                End If
            End If
        End If
    End Sub
    Private Sub PrincipalBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrincipalBindingSource.PositionChanged
        RefrescarDetalle()
    End Sub

    Private Sub c1dbgrdDetalle_Click(sender As System.Object, e As System.EventArgs) Handles c1dbgrdDetalle.Click

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub DataNavBarPrincipal_SalirClick(sender As Object, e As System.EventArgs) Handles DataNavBarPrincipal.SalirClick
        Me.Close()
    End Sub
    Private Sub DataNavBarPrincipal_ReiniciarDatosClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.ReiniciarDatosClick
        boBuscando = True
        DataNavBarPrincipal.toolstriptextBuscar.Text = ""
        Me.CTTransaccionesEncabezadoTableAdapter.Fill(Me.CTTransaccionesDataSet.CTTransaccionesEncabezado, drCnf("AñoEnProceso"), drCnf("MesEnProceso"))
        boBuscando = False
        RefrescarDetalle()
        DataNavBarPrincipal.RefrescarInfo()
    End Sub


    Private Sub DataNavBarPrincipal_CerrarDocumentoClick(sender As Object, e As System.EventArgs) Handles DataNavBarPrincipal.CerrarDocumentoClick
        Dim LineaDatosRow As DataRowView

        If MsgBox("Desea Cerrar Esta Transacción, al Cerrarla ya no Podrá Hacer Cambios", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Cerrar Transacción") = MsgBoxResult.No Then
            Exit Sub
        End If
        LineaDatosRow = PrincipalBindingSource.Current
        '** Actualizar el encabezado ***
        LineaDatosRow("Cerrado") = True
        ActualizarDatosEncabezado()
        DataNavBarPrincipal.RefrescarInfo()
    End Sub

    Private Sub btnBuscarTransaccion_Click(sender As Object, e As System.EventArgs) Handles btnBuscarTransaccion.Click
        CTListaTransFrm.ShowDialog()
        If CTListaTransFrm.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim LineaDatosRow As DataRowView
            LineaDatosRow = CTListaTransFrm.ListaTransaccionesBindingSource.Current
            DataNavBarPrincipal.toolstriptextBuscar.Text = LineaDatosRow("NoTransaccion")
            DataNavBarPrincipal_BuscarRegistroClick(Me, e)
        End If
    End Sub

    Private Sub DataNavBarPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles DataNavBarPrincipal.Load

    End Sub

    Private Sub DataNavBarPrincipal_ComentariosClick(sender As Object, e As System.EventArgs) Handles DataNavBarPrincipal.ComentariosClick        
        Dim CTTransComFrm As New CTTransaccionesComentariosFrm

        CTTransComFrm.NoTransaccion = c1txtNoTransaccion.Text
        CTTransComFrm.Top = Me.Top
        CTTransComFrm.Left = Me.Left
        CTTransComFrm.BarraPrin = Me.DataNavBarPrincipal
        'CTTransComFrm.Activate()
        CTTransComFrm.Show()
    End Sub

    Private Sub DataNavBarPrincipal_FontChanged(sender As Object, e As System.EventArgs) Handles DataNavBarPrincipal.FontChanged

    End Sub
End Class