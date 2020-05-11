<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLEdicionDeduccionesFrm
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
        Me.components = New System.ComponentModel.Container
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PLEdicionDeduccionesFrm))
        Dim Style6 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Dim Style7 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Dim Style8 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Me.toolstripPrincipal = New System.Windows.Forms.ToolStrip
        Me.toolstripAño = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.toolstripMes = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.toolstripPlani = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.toolstripbutRefrescar = New System.Windows.Forms.ToolStripButton
        Me.toolstripSalir = New System.Windows.Forms.ToolStripButton
        Me.StatusStripPrincipal = New System.Windows.Forms.StatusStrip
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.c1cmbDeducciones = New C1.Win.C1List.C1Combo
        Me.DefDeduccionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLEdicionDeduccionesDataSet = New RSIContab.PLEdicionDeduccionesDataSet
        Me.Label1 = New System.Windows.Forms.Label
        Me.c1truedbgrdPrincipal = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblDedPl1 = New System.Windows.Forms.Label
        Me.lblDedPl2 = New System.Windows.Forms.Label
        Me.PLDeduccionesTableAdapter = New RSIContab.PLEdicionDeduccionesDataSetTableAdapters.PLDeduccionesTableAdapter
        Me.PLDefinicionDeduccionesTableAdapter = New RSIContab.PLEdicionDeduccionesDataSetTableAdapters.PLDefinicionDeduccionesTableAdapter
        Me.toolstripPrincipal.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1cmbDeducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefDeduccionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLEdicionDeduccionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1truedbgrdPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolstripPrincipal
        '
        Me.toolstripPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripAño, Me.ToolStripSeparator1, Me.toolstripMes, Me.ToolStripSeparator2, Me.toolstripPlani, Me.ToolStripSeparator3, Me.toolstripbutRefrescar, Me.toolstripSalir})
        Me.toolstripPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.toolstripPrincipal.Name = "toolstripPrincipal"
        Me.toolstripPrincipal.Size = New System.Drawing.Size(990, 25)
        Me.toolstripPrincipal.TabIndex = 4
        Me.toolstripPrincipal.Text = "ToolStrip1"
        '
        'toolstripAño
        '
        Me.toolstripAño.Name = "toolstripAño"
        Me.toolstripAño.Size = New System.Drawing.Size(30, 22)
        Me.toolstripAño.Text = "Año:"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'toolstripMes
        '
        Me.toolstripMes.Name = "toolstripMes"
        Me.toolstripMes.Size = New System.Drawing.Size(30, 22)
        Me.toolstripMes.Text = "Mes:"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'toolstripPlani
        '
        Me.toolstripPlani.Name = "toolstripPlani"
        Me.toolstripPlani.Size = New System.Drawing.Size(59, 22)
        Me.toolstripPlani.Text = "Planilla No."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'toolstripbutRefrescar
        '
        Me.toolstripbutRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutRefrescar.Image = Global.RSIContab.My.Resources.Resources.RefreshDocViewHS
        Me.toolstripbutRefrescar.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutRefrescar.Name = "toolstripbutRefrescar"
        Me.toolstripbutRefrescar.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutRefrescar.Text = "Refrescar"
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
        'StatusStripPrincipal
        '
        Me.StatusStripPrincipal.Location = New System.Drawing.Point(0, 428)
        Me.StatusStripPrincipal.Name = "StatusStripPrincipal"
        Me.StatusStripPrincipal.Size = New System.Drawing.Size(990, 22)
        Me.StatusStripPrincipal.TabIndex = 5
        Me.StatusStripPrincipal.Text = "StatusStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.c1cmbDeducciones)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(477, 39)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'c1cmbDeducciones
        '
        Me.c1cmbDeducciones.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.c1cmbDeducciones.Caption = ""
        Me.c1cmbDeducciones.CaptionHeight = 17
        Me.c1cmbDeducciones.CaptionStyle = Style1
        Me.c1cmbDeducciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.c1cmbDeducciones.ColumnCaptionHeight = 17
        Me.c1cmbDeducciones.ColumnFooterHeight = 17
        Me.c1cmbDeducciones.ContentHeight = 15
        Me.c1cmbDeducciones.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DefDeduccionesBindingSource, "CodigoDeduccion", True))
        Me.c1cmbDeducciones.DataSource = Me.DefDeduccionesBindingSource
        Me.c1cmbDeducciones.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.c1cmbDeducciones.DisplayMember = "DescripcionDeduccion"
        Me.c1cmbDeducciones.EditorBackColor = System.Drawing.SystemColors.Window
        Me.c1cmbDeducciones.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1cmbDeducciones.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.c1cmbDeducciones.EditorHeight = 15
        Me.c1cmbDeducciones.EvenRowStyle = Style2
        Me.c1cmbDeducciones.FooterStyle = Style3
        Me.c1cmbDeducciones.HeadingStyle = Style4
        Me.c1cmbDeducciones.HighLightRowStyle = Style5
        Me.c1cmbDeducciones.Images.Add(CType(resources.GetObject("c1cmbDeducciones.Images"), System.Drawing.Image))
        Me.c1cmbDeducciones.ItemHeight = 15
        Me.c1cmbDeducciones.Location = New System.Drawing.Point(75, 14)
        Me.c1cmbDeducciones.MatchEntryTimeout = CType(2000, Long)
        Me.c1cmbDeducciones.MaxDropDownItems = CType(20, Short)
        Me.c1cmbDeducciones.MaxLength = 32767
        Me.c1cmbDeducciones.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.c1cmbDeducciones.Name = "c1cmbDeducciones"
        Me.c1cmbDeducciones.OddRowStyle = Style6
        Me.c1cmbDeducciones.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.c1cmbDeducciones.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.c1cmbDeducciones.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.c1cmbDeducciones.SelectedStyle = Style7
        Me.c1cmbDeducciones.Size = New System.Drawing.Size(379, 21)
        Me.c1cmbDeducciones.Style = Style8
        Me.c1cmbDeducciones.TabIndex = 1
        Me.c1cmbDeducciones.ValueMember = "CodigoDeduccion"
        Me.c1cmbDeducciones.PropBag = resources.GetString("c1cmbDeducciones.PropBag")
        '
        'DefDeduccionesBindingSource
        '
        Me.DefDeduccionesBindingSource.DataMember = "PLDefinicionDeducciones"
        Me.DefDeduccionesBindingSource.DataSource = Me.PLEdicionDeduccionesDataSet
        '
        'PLEdicionDeduccionesDataSet
        '
        Me.PLEdicionDeduccionesDataSet.DataSetName = "PLEdicionDeduccionesDataSet"
        Me.PLEdicionDeduccionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Deducción:"
        '
        'c1truedbgrdPrincipal
        '
        Me.c1truedbgrdPrincipal.AllowAddNew = True
        Me.c1truedbgrdPrincipal.AllowDelete = True
        Me.c1truedbgrdPrincipal.DataSource = Me.PrincipalBindingSource
        Me.c1truedbgrdPrincipal.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1truedbgrdPrincipal.Images.Add(CType(resources.GetObject("c1truedbgrdPrincipal.Images"), System.Drawing.Image))
        Me.c1truedbgrdPrincipal.Location = New System.Drawing.Point(5, 73)
        Me.c1truedbgrdPrincipal.Name = "c1truedbgrdPrincipal"
        Me.c1truedbgrdPrincipal.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1truedbgrdPrincipal.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1truedbgrdPrincipal.PreviewInfo.ZoomFactor = 75
        Me.c1truedbgrdPrincipal.PrintInfo.PageSettings = CType(resources.GetObject("c1truedbgrdPrincipal.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1truedbgrdPrincipal.Size = New System.Drawing.Size(973, 323)
        Me.c1truedbgrdPrincipal.TabIndex = 7
        Me.c1truedbgrdPrincipal.Text = "C1TrueDBGrid1"
        Me.c1truedbgrdPrincipal.PropBag = resources.GetString("c1truedbgrdPrincipal.PropBag")
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLDeducciones"
        Me.PrincipalBindingSource.DataSource = Me.PLEdicionDeduccionesDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(512, 403)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Totales:"
        '
        'lblDedPl1
        '
        Me.lblDedPl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDedPl1.Location = New System.Drawing.Point(586, 403)
        Me.lblDedPl1.Name = "lblDedPl1"
        Me.lblDedPl1.Size = New System.Drawing.Size(64, 13)
        Me.lblDedPl1.TabIndex = 9
        Me.lblDedPl1.Text = "0.00"
        Me.lblDedPl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDedPl2
        '
        Me.lblDedPl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDedPl2.Location = New System.Drawing.Point(656, 403)
        Me.lblDedPl2.Name = "lblDedPl2"
        Me.lblDedPl2.Size = New System.Drawing.Size(62, 13)
        Me.lblDedPl2.TabIndex = 10
        Me.lblDedPl2.Text = "0.00"
        Me.lblDedPl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PLDeduccionesTableAdapter
        '
        Me.PLDeduccionesTableAdapter.ClearBeforeFill = True
        '
        'PLDefinicionDeduccionesTableAdapter
        '
        Me.PLDefinicionDeduccionesTableAdapter.ClearBeforeFill = True
        '
        'PLEdicionDeduccionesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 450)
        Me.Controls.Add(Me.lblDedPl2)
        Me.Controls.Add(Me.lblDedPl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.c1truedbgrdPrincipal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStripPrincipal)
        Me.Controls.Add(Me.toolstripPrincipal)
        Me.Name = "PLEdicionDeduccionesFrm"
        Me.Text = "Edición de Deducciones"
        Me.toolstripPrincipal.ResumeLayout(False)
        Me.toolstripPrincipal.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1cmbDeducciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefDeduccionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLEdicionDeduccionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1truedbgrdPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolstripPrincipal As System.Windows.Forms.ToolStrip
    Friend WithEvents toolstripAño As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolstripMes As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolstripPlani As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolstripSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStripPrincipal As System.Windows.Forms.StatusStrip
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLEdicionDeduccionesDataSet As RSIContab.PLEdicionDeduccionesDataSet
    Friend WithEvents PLDeduccionesTableAdapter As RSIContab.PLEdicionDeduccionesDataSetTableAdapters.PLDeduccionesTableAdapter
    Friend WithEvents DefDeduccionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents c1cmbDeducciones As C1.Win.C1List.C1Combo
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents c1truedbgrdPrincipal As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents PLDefinicionDeduccionesTableAdapter As RSIContab.PLEdicionDeduccionesDataSetTableAdapters.PLDefinicionDeduccionesTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDedPl1 As System.Windows.Forms.Label
    Friend WithEvents lblDedPl2 As System.Windows.Forms.Label
    Friend WithEvents toolstripbutRefrescar As System.Windows.Forms.ToolStripButton
End Class
