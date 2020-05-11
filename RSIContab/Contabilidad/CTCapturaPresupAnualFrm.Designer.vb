<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTCapturaPresupAnualFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CTCapturaPresupAnualFrm))
        Me.c1dbgrdDetalle = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabelTitulo = New System.Windows.Forms.ToolStripLabel()
        Me.butSalir = New System.Windows.Forms.Button()
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTPresupMensualDataSet = New RSIContab.CTPresupMensualDataSet()
        Me.CTPresupuestoAnualTableAdapter = New RSIContab.CTPresupMensualDataSetTableAdapters.CTPresupuestoAnualTableAdapter()
        CType(Me.c1dbgrdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTPresupMensualDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1dbgrdDetalle
        '
        Me.c1dbgrdDetalle.AllowAddNew = True
        Me.c1dbgrdDetalle.AllowDelete = True
        Me.c1dbgrdDetalle.AllowSort = False
        Me.c1dbgrdDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.c1dbgrdDetalle.BackColor = System.Drawing.SystemColors.Control
        Me.c1dbgrdDetalle.DataSource = Me.PrincipalBindingSource
        Me.c1dbgrdDetalle.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbgrdDetalle.Images.Add(CType(resources.GetObject("c1dbgrdDetalle.Images"), System.Drawing.Image))
        Me.c1dbgrdDetalle.Location = New System.Drawing.Point(6, 28)
        Me.c1dbgrdDetalle.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.SolidCellBorder
        Me.c1dbgrdDetalle.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None
        Me.c1dbgrdDetalle.Name = "c1dbgrdDetalle"
        Me.c1dbgrdDetalle.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbgrdDetalle.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbgrdDetalle.PreviewInfo.ZoomFactor = 75.0R
        Me.c1dbgrdDetalle.PrintInfo.PageSettings = CType(resources.GetObject("c1dbgrdDetalle.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1dbgrdDetalle.RowHeight = 17
        Me.c1dbgrdDetalle.Size = New System.Drawing.Size(595, 450)
        Me.c1dbgrdDetalle.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.c1dbgrdDetalle.TabIndex = 54
        Me.c1dbgrdDetalle.Text = "C1TrueDBGrid1"
        Me.c1dbgrdDetalle.PropBag = resources.GetString("c1dbgrdDetalle.PropBag")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelTitulo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(607, 25)
        Me.ToolStrip1.TabIndex = 75
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabelTitulo
        '
        Me.ToolStripLabelTitulo.Name = "ToolStripLabelTitulo"
        Me.ToolStripLabelTitulo.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripLabelTitulo.Text = "ToolStripLabel1"
        '
        'butSalir
        '
        Me.butSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.butSalir.Image = Global.RSIContab.My.Resources.Resources._1393662113_cancel
        Me.butSalir.Location = New System.Drawing.Point(271, 484)
        Me.butSalir.Name = "butSalir"
        Me.butSalir.Size = New System.Drawing.Size(107, 36)
        Me.butSalir.TabIndex = 76
        Me.butSalir.Text = "&Salir"
        Me.butSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butSalir.UseVisualStyleBackColor = True
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "CTPresupuestoAnual"
        Me.PrincipalBindingSource.DataSource = Me.CTPresupMensualDataSet
        '
        'CTPresupMensualDataSet
        '
        Me.CTPresupMensualDataSet.DataSetName = "CTPresupMensualDataSet"
        Me.CTPresupMensualDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CTPresupuestoAnualTableAdapter
        '
        Me.CTPresupuestoAnualTableAdapter.ClearBeforeFill = True
        '
        'CTCapturaPresupAnualFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 523)
        Me.Controls.Add(Me.butSalir)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.c1dbgrdDetalle)
        Me.Name = "CTCapturaPresupAnualFrm"
        Me.Text = "Presupuesto Anual"
        CType(Me.c1dbgrdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTPresupMensualDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents c1dbgrdDetalle As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabelTitulo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTPresupMensualDataSet As RSIContab.CTPresupMensualDataSet
    Friend WithEvents butSalir As System.Windows.Forms.Button
    Friend WithEvents CTPresupuestoAnualTableAdapter As RSIContab.CTPresupMensualDataSetTableAdapters.CTPresupuestoAnualTableAdapter
End Class
