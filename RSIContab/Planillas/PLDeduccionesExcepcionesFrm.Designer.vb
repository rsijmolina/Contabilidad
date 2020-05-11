<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLDeduccionesExcepcionesFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PLDeduccionesExcepcionesFrm))
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLDeduccionesExcepcionesDataSet = New RSIContab.PLDeduccionesExcepcionesDataSet()
        Me.PLDeduccionesExcepcionesTableAdapter = New RSIContab.PLDeduccionesExcepcionesDataSetTableAdapters.PLDeduccionesExcepcionesTableAdapter()
        Me.toolstripPrincipal = New System.Windows.Forms.ToolStrip()
        Me.toolstripSalir = New System.Windows.Forms.ToolStripButton()
        Me.c1truedbgrdPrincipal = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLDeduccionesExcepcionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripPrincipal.SuspendLayout()
        CType(Me.c1truedbgrdPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLDeduccionesExcepciones"
        Me.PrincipalBindingSource.DataSource = Me.PLDeduccionesExcepcionesDataSet
        '
        'PLDeduccionesExcepcionesDataSet
        '
        Me.PLDeduccionesExcepcionesDataSet.DataSetName = "PLDeduccionesExcepcionesDataSet"
        Me.PLDeduccionesExcepcionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLDeduccionesExcepcionesTableAdapter
        '
        Me.PLDeduccionesExcepcionesTableAdapter.ClearBeforeFill = True
        '
        'toolstripPrincipal
        '
        Me.toolstripPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripSalir})
        Me.toolstripPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.toolstripPrincipal.Name = "toolstripPrincipal"
        Me.toolstripPrincipal.Size = New System.Drawing.Size(473, 25)
        Me.toolstripPrincipal.TabIndex = 4
        Me.toolstripPrincipal.Text = "ToolStrip1"
        '
        'toolstripSalir
        '
        Me.toolstripSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripSalir.Image = Global.RSIContab.My.Resources.Resources.CriticalError
        Me.toolstripSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripSalir.Name = "toolstripSalir"
        Me.toolstripSalir.Size = New System.Drawing.Size(23, 22)
        Me.toolstripSalir.Text = "Salir"
        '
        'c1truedbgrdPrincipal
        '
        Me.c1truedbgrdPrincipal.AllowAddNew = True
        Me.c1truedbgrdPrincipal.AllowDelete = True
        Me.c1truedbgrdPrincipal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.c1truedbgrdPrincipal.DataSource = Me.PrincipalBindingSource
        Me.c1truedbgrdPrincipal.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1truedbgrdPrincipal.Images.Add(CType(resources.GetObject("c1truedbgrdPrincipal.Images"), System.Drawing.Image))
        Me.c1truedbgrdPrincipal.Location = New System.Drawing.Point(12, 28)
        Me.c1truedbgrdPrincipal.Name = "c1truedbgrdPrincipal"
        Me.c1truedbgrdPrincipal.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1truedbgrdPrincipal.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1truedbgrdPrincipal.PreviewInfo.ZoomFactor = 75.0R
        Me.c1truedbgrdPrincipal.PrintInfo.PageSettings = CType(resources.GetObject("c1truedbgrdPrincipal.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1truedbgrdPrincipal.RowHeight = 17
        Me.c1truedbgrdPrincipal.Size = New System.Drawing.Size(451, 281)
        Me.c1truedbgrdPrincipal.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.c1truedbgrdPrincipal.TabIndex = 5
        Me.c1truedbgrdPrincipal.Text = "C1TrueDBGrid1"
        Me.c1truedbgrdPrincipal.PropBag = resources.GetString("c1truedbgrdPrincipal.PropBag")
        '
        'PLDeduccionesExcepcionesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 321)
        Me.Controls.Add(Me.c1truedbgrdPrincipal)
        Me.Controls.Add(Me.toolstripPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PLDeduccionesExcepcionesFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Excepciones de Deducciones"
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLDeduccionesExcepcionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripPrincipal.ResumeLayout(False)
        Me.toolstripPrincipal.PerformLayout()
        CType(Me.c1truedbgrdPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLDeduccionesExcepcionesDataSet As RSIContab.PLDeduccionesExcepcionesDataSet
    Friend WithEvents PLDeduccionesExcepcionesTableAdapter As RSIContab.PLDeduccionesExcepcionesDataSetTableAdapters.PLDeduccionesExcepcionesTableAdapter
    Friend WithEvents toolstripPrincipal As System.Windows.Forms.ToolStrip
    Friend WithEvents toolstripSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents c1truedbgrdPrincipal As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
