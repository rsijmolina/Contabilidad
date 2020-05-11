Imports System.ComponentModel

Public Class BADepNotasTransfFrm
    Dim dbCls As New BAClassLib.BAClass
    Dim ListaRegistrosAbiertos As New Collection
    Dim drConf As SqlClient.SqlDataReader
    Dim drvBaConf As DataRowView
    Dim IntAño As Int16, intMes As Int16
    Dim intTipoTrans As Int16


    Private Sub BADepNotasTransfFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIPrincipal
        Me.Top = 10
        Me.Left = 10

        dbCls.DBconStr = strcnCAD
        Me.BABancosTableAdapter.Connection.ConnectionString = strcnCAD
        Me.BATransaccionesEncabezadoTableAdapter.Connection.ConnectionString = strcnCAD
        Me.BAConfTableAdapter.Connection.ConnectionString = strcnCAD
        Me.BABancosTableAdapter.Fill(Me.BATransaccionesListaDataSet.BABancos)
        Me.BAConfTableAdapter.Fill(Me.BATransaccionesListaDataSet.BAConf)
        drvBaConf = BAConfBindingSource.Current
        IntAño = drvBaConf("AñoEnProceso")
        intMes = drvBaConf("MesEnProceso")

        ListaDataNavBarPrin.ToolStripLabelBuscar.Text = "Buscar Directamente por Banco:"
        ListaDataNavBarPrin.ToolStripLabelBuscar.Text = ""
        ListaDataNavBarPrin.ToolStripLabelNoRegistros.Text = PrincipalBindingSource.Count
        ListaDataNavBarPrin.ToolStripButtonNuevo.Enabled = False
        Me.ListaDataNavBarPrin.ToolStripButtonEditar.Visible = True

    End Sub

    Private Sub BADepNotasTransfFrm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If ListaRegistrosAbiertos.Count > 0 Then
            MsgBox("Cierre Todos los Formularios Abiertos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            e.Cancel = True
        End If
    End Sub

    Private Sub butFiltrar_Click(sender As Object, e As EventArgs) Handles butFiltrar.Click


        If Me.BATransaccionesListaDataSet.BABancos.Rows.Count = 0 Then
            Me.ListaDataNavBarPrin.HabilitarSoloBotonNuevo()
        Else
            Me.ListaDataNavBarPrin.HabilitarTodosBotones()
        End If
        If c1cmbTipoTrans.SelectedItem = "Depósitos" Then
            intTipoTrans = 1
        ElseIf c1cmbTipoTrans.SelectedItem = "Notas de Crédito" Then
            intTipoTrans = 3
        ElseIf c1cmbTipoTrans.SelectedItem = "Notas de Débito" Then
            intTipoTrans = 4
        ElseIf c1cmbTipoTrans.SelectedItem = "Transferencias" Then
            intTipoTrans = 5
        End If
        Me.BATransaccionesEncabezadoTableAdapter.Fill(Me.BATransaccionesListaDataSet.BATransaccionesEncabezado, c1cmbBanco.SelectedValue, intTipoTrans, IntAño, intMes)
    End Sub
    Private Sub ListaDataNavBarPrin_ConsultarRegistroClick(sender As Object, e As EventArgs) Handles ListaDataNavBarPrin.ConsultarRegistroClick
        CargarForma("CONSULTAR")
    End Sub

    Private Sub ListaDataNavBarPrin_EditarRegistroClick(sender As Object, e As EventArgs) Handles ListaDataNavBarPrin.EditarRegistroClick
        CargarForma("EDITAR")
    End Sub

    Private Sub ListaDataNavBarPrin_EliminarRegistroClick(sender As Object, e As EventArgs) Handles ListaDataNavBarPrin.EliminarRegistroClick
        CargarForma("ELIMINAR")
    End Sub

    Private Sub ListaDataNavBarPrin_NuevoRegistroClick(sender As Object, e As EventArgs) Handles ListaDataNavBarPrin.NuevoRegistroClick
        CargarForma("NUEVO")
    End Sub

    Private Sub ListaDataNavBarPrin_RecargarDatosClick(sender As Object, e As EventArgs) Handles ListaDataNavBarPrin.RecargarDatosClick
        RecargarDatos()
    End Sub

    Private Sub ListaDataNavBarPrin_SalirClick(sender As Object, e As EventArgs) Handles ListaDataNavBarPrin.SalirClick
        Me.Close()
    End Sub

    Private Sub CargarForma(strModalidad As String)
        If strModalidad = "NUEVO" Then
            MsgBox("Entro en NUEVO")
            Dim EditFormaFrm As New BADepNotasTransEdicionFrm
            EditFormaFrm.FormularioPrincipal = Me
            EditFormaFrm.MdiParent = Me.MdiParent
            EditFormaFrm.Modalidad = strModalidad
            '   EditFormaFrm.intBanco = ListaDataNavBarPrin.ToolStripTextBoxBuscar.Text
            EditFormaFrm.Show()
        Else
            If ListaDataNavBarPrin.ToolStripTextBoxBuscar.Text.Length > 0 Then
                If dbCls.ExisteBanco(ListaDataNavBarPrin.ToolStripTextBoxBuscar.Text) Then
                    If Not ListaRegistrosAbiertos.Contains(ListaDataNavBarPrin.ToolStripTextBoxBuscar.Text) Then
                        Dim EditFormaFrm As New BADepNotasTransEdicionFrm
                        EditFormaFrm.TipoDocumento = c1cmbTipoTrans.Text
                        EditFormaFrm.intBanco = ListaDataNavBarPrin.ToolStripTextBoxBuscar.Text
                        EditFormaFrm.FormularioPrincipal = Me
                        EditFormaFrm.MdiParent = Me.MdiParent
                        EditFormaFrm.Modalidad = strModalidad
                        EditFormaFrm.drvBanco = Me.BABancosBindingSource.Current
                        ListaRegistrosAbiertos.Add(ListaDataNavBarPrin.ToolStripTextBoxBuscar.Text, ListaDataNavBarPrin.ToolStripTextBoxBuscar.Text)
                        ListaDataNavBarPrin.ToolStripTextBoxBuscar.Text = ""
                        EditFormaFrm.Show()
                    End If
                Else
                    MsgBox("Cuenta no existe...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                End If
            Else
                Dim reg As DataRowView = PrincipalBindingSource.Current
                If Not ListaRegistrosAbiertos.Contains(reg("NoDocumento")) Then
                    Dim EditFormaFrm As New BADepNotasTransEdicionFrm
                    EditFormaFrm.FormularioPrincipal = Me
                    EditFormaFrm.MdiParent = Me.MdiParent
                    EditFormaFrm.Modalidad = strModalidad
                    EditFormaFrm.drvBanco = reg("NoDocumento")
                    ListaRegistrosAbiertos.Add(reg("NoDocumento"), reg("NoDocumento"))
                    EditFormaFrm.Show()
                End If
            End If
        End If
    End Sub

    Public Sub EliminarRegistroAbierto(strNoDocumento As String)
        ListaRegistrosAbiertos.Remove(strNoDocumento)
    End Sub

    Private Sub RecargarDatos()
        Me.BATransaccionesEncabezadoTableAdapter.Fill(Me.BATransaccionesListaDataSet.BATransaccionesEncabezado, c1cmbBanco.SelectedValue, intTipoTrans, IntAño, intMes)
        If Me.BATransaccionesListaDataSet.BATransaccionesEncabezado.Rows.Count = 0 Then
            Me.ListaDataNavBarPrin.HabilitarSoloBotonNuevo()
        Else
            Me.ListaDataNavBarPrin.HabilitarTodosBotones()
        End If
    End Sub

End Class