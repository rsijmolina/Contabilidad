Public Class CtListaCatGenFrm
    Dim CTCls As New CTClassLib.CTClass
    Dim drCat As SqlClient.SqlDataReader
    Private Sub CtListaCatGenFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CTCls.DBconStr = strcnCAD
            Me.CTCatalogoCuentasTableAdapter.Connection.ConnectionString = strcnCAD
            Me.CTCatalogoCuentasTableAdapter.Fill(Me.CTListaCatalogoDataSet.CTCatalogoCuentas)
            If My.Settings.CTFormatoListaCatalogo = "G" Then
                ToolStripComboBoxTipo.Items.Add("Todas")
                ToolStripComboBoxTipo.Items.Add("Activo")
                ToolStripComboBoxTipo.Items.Add("Pasivo")
                ToolStripComboBoxTipo.Items.Add("Capital")
                ToolStripComboBoxTipo.Items.Add("Ingresos")
                ToolStripComboBoxTipo.Items.Add("Costos")
                ToolStripComboBoxTipo.Items.Add("Gastos")
            Else
                ToolStripComboBoxTipo.Visible = False
                ToolStripLabelTipo.Visible = False
                treeviewCatalogo.Top = 28
                treeviewCatalogo.Left = 12
                treeviewCatalogo.Visible = True
                c1dbgrdCatalogo.Visible = False
                CargarNodos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripComboBoxTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBoxTipo.SelectedIndexChanged
        If ToolStripComboBoxTipo.SelectedItem = "Todas" Then
            ListaCatBindingSource.RemoveFilter()
        ElseIf ToolStripComboBoxTipo.SelectedItem = "Todas" Then
            ListaCatBindingSource.Filter = "Tipo='A'"
        ElseIf ToolStripComboBoxTipo.SelectedItem = "Activo" Then
            ListaCatBindingSource.Filter = "Tipo='A'"
        ElseIf ToolStripComboBoxTipo.SelectedItem = "Pasivo" Then
            ListaCatBindingSource.Filter = "Tipo='P'"
        ElseIf ToolStripComboBoxTipo.SelectedItem = "Capital" Then
            ListaCatBindingSource.Filter = "Tipo='C'"
        ElseIf ToolStripComboBoxTipo.SelectedItem = "Ingresos" Then
            ListaCatBindingSource.Filter = "Tipo='I'"
        ElseIf ToolStripComboBoxTipo.SelectedItem = "Costos" Then
            ListaCatBindingSource.Filter = "Tipo='T'"
        ElseIf ToolStripComboBoxTipo.SelectedItem = "Gastos" Then
            ListaCatBindingSource.Filter = "Tipo='G'"
        End If
    End Sub

    Private Sub toolstripbutRefrescar_Click(sender As Object, e As EventArgs) Handles toolstripbutRefrescar.Click
        Try
            If My.Settings.CTFormatoListaCatalogo = "G" Then
                Me.CTCatalogoCuentasTableAdapter.Fill(Me.CTListaCatalogoDataSet.CTCatalogoCuentas)
                ToolStripComboBoxTipo_SelectedIndexChanged(Me, e)
            Else
                treeviewCatalogo.Nodes.Clear()
                CargarNodos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CargarNodos()
        Dim treeNodox As TreeNode

        Try
            treeNodox = treeviewCatalogo.Nodes.Add("Cuentas", "Cuentas", "LibroCerrado", "LibroAbierto")
            drCat = CTCls.drCatalogo
            While drCat.Read
                If String.IsNullOrEmpty(drCat("CuentaSuperior").ToString) Then
                    treeviewCatalogo.Nodes("Cuentas").Nodes.Add(drCat("Cuenta"), drCat("Cuenta") & " - " & drCat("Descripcion"), "SubCtaCerrada", "Seleccionado")
                Else
                    Dim treeSubNodox As TreeNode() = treeviewCatalogo.Nodes.Find(drCat("CuentaSuperior"), True)
                    If drCat("Posteable") Then
                        treeSubNodox(0).Nodes.Add(drCat("Cuenta"), drCat("Cuenta") & " - " & drCat("Descripcion"), "Hoja", "Seleccionado")
                    Else
                        treeSubNodox(0).Nodes.Add(drCat("Cuenta"), drCat("Cuenta") & " - " & drCat("Descripcion"), "SubCtaCerrada", "Seleccionado")
                    End If

                End If
            End While
            treeviewCatalogo.Refresh()
            drCat.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub butAceptar_Click(sender As Object, e As EventArgs) Handles butAceptar.Click
        If My.Settings.CTFormatoListaCatalogo = "A" Then
            If treeviewCatalogo.SelectedNode.Name <> "Cuentas" Then
                If Not CTCls.EsCuentaPosteable(treeviewCatalogo.SelectedNode.Name) Then
                    MsgBox("Esta cuenta no es posteable, elija otra cuenta", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                    Me.DialogResult = Windows.Forms.DialogResult.None
                Else
                    Dim intPos As Int32 = ListaCatBindingSource.Find("Cuenta", treeviewCatalogo.SelectedNode.Name)
                    If intPos > 0 Then
                        ListaCatBindingSource.Position = intPos
                    End If
                End If
            End If
        End If
    End Sub
End Class