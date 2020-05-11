<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTCapturaPresupMensualFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CTCapturaPresupMensualFrm))
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTPresupMensualDataSet = New RSIContab.CTPresupMensualDataSet()
        Me.CTPresupuestoTableAdapter = New RSIContab.CTPresupMensualDataSetTableAdapters.CTPresupuestoTableAdapter()
        Me.c1dbgrdPresupuesto = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.butSalir = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabelTitulo = New System.Windows.Forms.ToolStripLabel()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTPresupMensualDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1dbgrdPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "CTPresupuesto"
        Me.PrincipalBindingSource.DataSource = Me.CTPresupMensualDataSet
        '
        'CTPresupMensualDataSet
        '
        Me.CTPresupMensualDataSet.DataSetName = "CTPresupMensualDataSet"
        Me.CTPresupMensualDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CTPresupuestoTableAdapter
        '
        Me.CTPresupuestoTableAdapter.ClearBeforeFill = True
        '
        'c1dbgrdPresupuesto
        '
        Me.c1dbgrdPresupuesto.AllowAddNew = True
        Me.c1dbgrdPresupuesto.AllowSort = False
        Me.c1dbgrdPresupuesto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c1dbgrdPresupuesto.BackColor = System.Drawing.SystemColors.Control
        Me.c1dbgrdPresupuesto.DataSource = Me.PrincipalBindingSource
        Me.c1dbgrdPresupuesto.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbgrdPresupuesto.Images.Add(CType(resources.GetObject("c1dbgrdPresupuesto.Images"), System.Drawing.Image))
        Me.c1dbgrdPresupuesto.Location = New System.Drawing.Point(12, 28)
        Me.c1dbgrdPresupuesto.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.SolidCellBorder
        Me.c1dbgrdPresupuesto.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None
        Me.c1dbgrdPresupuesto.Name = "c1dbgrdPresupuesto"
        Me.c1dbgrdPresupuesto.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbgrdPresupuesto.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbgrdPresupuesto.PreviewInfo.ZoomFactor = 75.0R
        Me.c1dbgrdPresupuesto.PrintInfo.PageSettings = CType(resources.GetObject("c1dbgrdPresupuesto.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1dbgrdPresupuesto.RecordSelectors = False
        Me.c1dbgrdPresupuesto.RowHeight = 17
        Me.c1dbgrdPresupuesto.Size = New System.Drawing.Size(1339, 452)
        Me.c1dbgrdPresupuesto.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.c1dbgrdPresupuesto.TabIndex = 54
        Me.c1dbgrdPresupuesto.Text = "C1TrueDBGrid1"
        Me.c1dbgrdPresupuesto.PropBag = resources.GetString("c1dbgrdPresupuesto.PropBag")
        '
        'butSalir
        '
        Me.butSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.butSalir.Image = Global.RSIContab.My.Resources.Resources._1393662113_cancel
        Me.butSalir.Location = New System.Drawing.Point(670, 486)
        Me.butSalir.Name = "butSalir"
        Me.butSalir.Size = New System.Drawing.Size(107, 36)
        Me.butSalir.TabIndex = 73
        Me.butSalir.Text = "&Salir"
        Me.butSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butSalir.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelTitulo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1363, 25)
        Me.ToolStrip1.TabIndex = 74
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabelTitulo
        '
        Me.ToolStripLabelTitulo.Name = "ToolStripLabelTitulo"
        Me.ToolStripLabelTitulo.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripLabelTitulo.Text = "ToolStripLabel1"
        '
        'CTCapturaPresupMensualFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1363, 532)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.butSalir)
        Me.Controls.Add(Me.c1dbgrdPresupuesto)
        Me.Name = "CTCapturaPresupMensualFrm"
        Me.Text = "Presupuesto Mensual"
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTPresupMensualDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1dbgrdPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTPresupMensualDataSet As RSIContab.CTPresupMensualDataSet
    Friend WithEvents CTPresupuestoTableAdapter As RSIContab.CTPresupMensualDataSetTableAdapters.CTPresupuestoTableAdapter
    Friend WithEvents c1dbgrdPresupuesto As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents butSalir As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabelTitulo As System.Windows.Forms.ToolStripLabel
End Class
