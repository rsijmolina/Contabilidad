<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtListaCatGenFrm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtListaCatGenFrm))
        Me.toolstripListas = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabelTipo = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBoxTipo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstripbutRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.c1dbgrdCatalogo = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.ListaCatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTListaCatalogoDataSet = New RSIContab.CTListaCatalogoDataSet()
        Me.butAceptar = New System.Windows.Forms.Button()
        Me.butCancelar = New System.Windows.Forms.Button()
        Me.CTCatalogoCuentasTableAdapter = New RSIContab.CTListaCatalogoDataSetTableAdapters.CTCatalogoCuentasTableAdapter()
        Me.treeviewCatalogo = New System.Windows.Forms.TreeView()
        Me.imglstCat = New System.Windows.Forms.ImageList(Me.components)
        Me.toolstripListas.SuspendLayout()
        CType(Me.c1dbgrdCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaCatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTListaCatalogoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolstripListas
        '
        Me.toolstripListas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.toolstripListas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelTipo, Me.ToolStripComboBoxTipo, Me.ToolStripSeparator1, Me.toolstripbutRefrescar})
        Me.toolstripListas.Location = New System.Drawing.Point(0, 0)
        Me.toolstripListas.Name = "toolstripListas"
        Me.toolstripListas.Size = New System.Drawing.Size(490, 25)
        Me.toolstripListas.TabIndex = 14
        Me.toolstripListas.Text = "ToolStrip1"
        '
        'ToolStripLabelTipo
        '
        Me.ToolStripLabelTipo.Name = "ToolStripLabelTipo"
        Me.ToolStripLabelTipo.Size = New System.Drawing.Size(34, 22)
        Me.ToolStripLabelTipo.Text = "Tipo:"
        '
        'ToolStripComboBoxTipo
        '
        Me.ToolStripComboBoxTipo.Name = "ToolStripComboBoxTipo"
        Me.ToolStripComboBoxTipo.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'toolstripbutRefrescar
        '
        Me.toolstripbutRefrescar.Image = Global.RSIContab.My.Resources.Resources.RefreshDocViewHS
        Me.toolstripbutRefrescar.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutRefrescar.Name = "toolstripbutRefrescar"
        Me.toolstripbutRefrescar.Size = New System.Drawing.Size(102, 22)
        Me.toolstripbutRefrescar.Text = "Refrescar Lista"
        '
        'c1dbgrdCatalogo
        '
        Me.c1dbgrdCatalogo.AllowUpdate = False
        Me.c1dbgrdCatalogo.AlternatingRows = True
        Me.c1dbgrdCatalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c1dbgrdCatalogo.BackColor = System.Drawing.SystemColors.Control
        Me.c1dbgrdCatalogo.DataSource = Me.ListaCatBindingSource
        Me.c1dbgrdCatalogo.FilterBar = True
        Me.c1dbgrdCatalogo.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbgrdCatalogo.Images.Add(CType(resources.GetObject("c1dbgrdCatalogo.Images"), System.Drawing.Image))
        Me.c1dbgrdCatalogo.Location = New System.Drawing.Point(12, 28)
        Me.c1dbgrdCatalogo.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.c1dbgrdCatalogo.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None
        Me.c1dbgrdCatalogo.Name = "c1dbgrdCatalogo"
        Me.c1dbgrdCatalogo.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbgrdCatalogo.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbgrdCatalogo.PreviewInfo.ZoomFactor = 75.0R
        Me.c1dbgrdCatalogo.PrintInfo.PageSettings = CType(resources.GetObject("c1dbgrdCatalogo.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1dbgrdCatalogo.RowHeight = 17
        Me.c1dbgrdCatalogo.Size = New System.Drawing.Size(466, 358)
        Me.c1dbgrdCatalogo.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.c1dbgrdCatalogo.TabIndex = 55
        Me.c1dbgrdCatalogo.Text = "C1TrueDBGrid1"
        Me.c1dbgrdCatalogo.PropBag = resources.GetString("c1dbgrdCatalogo.PropBag")
        '
        'ListaCatBindingSource
        '
        Me.ListaCatBindingSource.DataMember = "CTCatalogoCuentas"
        Me.ListaCatBindingSource.DataSource = Me.CTListaCatalogoDataSet
        '
        'CTListaCatalogoDataSet
        '
        Me.CTListaCatalogoDataSet.DataSetName = "CTListaCatalogoDataSet"
        Me.CTListaCatalogoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'butAceptar
        '
        Me.butAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.butAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.butAceptar.Image = Global.RSIContab.My.Resources.Resources._1393538844_tick_16
        Me.butAceptar.Location = New System.Drawing.Point(42, 392)
        Me.butAceptar.Name = "butAceptar"
        Me.butAceptar.Size = New System.Drawing.Size(107, 33)
        Me.butAceptar.TabIndex = 56
        Me.butAceptar.Text = "&Aceptar"
        Me.butAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butAceptar.UseVisualStyleBackColor = True
        '
        'butCancelar
        '
        Me.butCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butCancelar.Image = Global.RSIContab.My.Resources.Resources._1393662113_cancel
        Me.butCancelar.Location = New System.Drawing.Point(349, 392)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(107, 33)
        Me.butCancelar.TabIndex = 57
        Me.butCancelar.Text = "&Cancelar"
        Me.butCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butCancelar.UseVisualStyleBackColor = True
        '
        'CTCatalogoCuentasTableAdapter
        '
        Me.CTCatalogoCuentasTableAdapter.ClearBeforeFill = True
        '
        'treeviewCatalogo
        '
        Me.treeviewCatalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.treeviewCatalogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.treeviewCatalogo.HotTracking = True
        Me.treeviewCatalogo.ImageIndex = 0
        Me.treeviewCatalogo.ImageList = Me.imglstCat
        Me.treeviewCatalogo.Location = New System.Drawing.Point(24, 38)
        Me.treeviewCatalogo.Name = "treeviewCatalogo"
        Me.treeviewCatalogo.SelectedImageIndex = 0
        Me.treeviewCatalogo.ShowNodeToolTips = True
        Me.treeviewCatalogo.Size = New System.Drawing.Size(466, 358)
        Me.treeviewCatalogo.TabIndex = 58
        Me.treeviewCatalogo.Visible = False
        '
        'imglstCat
        '
        Me.imglstCat.ImageStream = CType(resources.GetObject("imglstCat.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglstCat.TransparentColor = System.Drawing.Color.Transparent
        Me.imglstCat.Images.SetKeyName(0, "LibroAbierto")
        Me.imglstCat.Images.SetKeyName(1, "LibroCerrado")
        Me.imglstCat.Images.SetKeyName(2, "SubCtaCerrada")
        Me.imglstCat.Images.SetKeyName(3, "Hoja")
        Me.imglstCat.Images.SetKeyName(4, "Seleccionado")
        '
        'CtListaCatGenFrm
        '
        Me.AcceptButton = Me.butAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.butCancelar
        Me.ClientSize = New System.Drawing.Size(490, 429)
        Me.Controls.Add(Me.butCancelar)
        Me.Controls.Add(Me.butAceptar)
        Me.Controls.Add(Me.c1dbgrdCatalogo)
        Me.Controls.Add(Me.toolstripListas)
        Me.Controls.Add(Me.treeviewCatalogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CtListaCatGenFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lista del Catálogo de Cuentas"
        Me.toolstripListas.ResumeLayout(False)
        Me.toolstripListas.PerformLayout()
        CType(Me.c1dbgrdCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaCatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTListaCatalogoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolstripListas As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabelTipo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripComboBoxTipo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolstripbutRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents c1dbgrdCatalogo As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents ListaCatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTListaCatalogoDataSet As RSIContab.CTListaCatalogoDataSet
    Friend WithEvents CTCatalogoCuentasTableAdapter As RSIContab.CTListaCatalogoDataSetTableAdapters.CTCatalogoCuentasTableAdapter
    Friend WithEvents butAceptar As System.Windows.Forms.Button
    Friend WithEvents butCancelar As System.Windows.Forms.Button
    Friend WithEvents treeviewCatalogo As System.Windows.Forms.TreeView
    Friend WithEvents imglstCat As System.Windows.Forms.ImageList
End Class
