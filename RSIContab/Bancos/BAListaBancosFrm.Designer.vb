<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BAListaBancosFrm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BAListaBancosFrm))
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.toolstripListas = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabelTipo = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBoxTipo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstripbutRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.butAceptar = New System.Windows.Forms.Button()
        Me.BAListaBancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.butCancelar = New System.Windows.Forms.Button()
        Me.BABancosListaDataSet = New RSIContab.BABancosListaDataSet()
        Me.BABancosTableAdapter = New RSIContab.BABancosListaDataSetTableAdapters.BABancosTableAdapter()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripListas.SuspendLayout()
        CType(Me.BAListaBancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BABancosListaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.C1TrueDBGrid1.DataSource = Me.BAListaBancosBindingSource
        Me.C1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(43, 36)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(342, 296)
        Me.C1TrueDBGrid1.TabIndex = 2
        Me.C1TrueDBGrid1.UseCompatibleTextRendering = False
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        '
        'toolstripListas
        '
        Me.toolstripListas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.toolstripListas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelTipo, Me.ToolStripComboBoxTipo, Me.ToolStripSeparator1, Me.toolstripbutRefrescar})
        Me.toolstripListas.Location = New System.Drawing.Point(0, 0)
        Me.toolstripListas.Name = "toolstripListas"
        Me.toolstripListas.Size = New System.Drawing.Size(424, 25)
        Me.toolstripListas.TabIndex = 15
        Me.toolstripListas.Text = "ToolStrip1"
        '
        'ToolStripLabelTipo
        '
        Me.ToolStripLabelTipo.Name = "ToolStripLabelTipo"
        Me.ToolStripLabelTipo.Size = New System.Drawing.Size(33, 22)
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
        'butAceptar
        '
        Me.butAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.butAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.butAceptar.Image = Global.RSIContab.My.Resources.Resources._1393538844_tick_16
        Me.butAceptar.Location = New System.Drawing.Point(43, 338)
        Me.butAceptar.Name = "butAceptar"
        Me.butAceptar.Size = New System.Drawing.Size(107, 33)
        Me.butAceptar.TabIndex = 58
        Me.butAceptar.Text = "&Aceptar"
        Me.butAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butAceptar.UseVisualStyleBackColor = True
        '
        'BAListaBancosBindingSource
        '
        Me.BAListaBancosBindingSource.DataMember = "BABancos"
        Me.BAListaBancosBindingSource.DataSource = Me.BABancosListaDataSet
        '
        'butCancelar
        '
        Me.butCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butCancelar.Image = Global.RSIContab.My.Resources.Resources._1393662113_cancel
        Me.butCancelar.Location = New System.Drawing.Point(278, 338)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(107, 33)
        Me.butCancelar.TabIndex = 59
        Me.butCancelar.Text = "&Cancelar"
        Me.butCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butCancelar.UseVisualStyleBackColor = True
        '
        'BABancosListaDataSet
        '
        Me.BABancosListaDataSet.DataSetName = "BABancosListaDataSet"
        Me.BABancosListaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BABancosTableAdapter
        '
        Me.BABancosTableAdapter.ClearBeforeFill = True
        '
        'BAListaBancosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 394)
        Me.Controls.Add(Me.butCancelar)
        Me.Controls.Add(Me.butAceptar)
        Me.Controls.Add(Me.toolstripListas)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.Name = "BAListaBancosFrm"
        Me.Text = "  "
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripListas.ResumeLayout(False)
        Me.toolstripListas.PerformLayout()
        CType(Me.BAListaBancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BABancosListaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents toolstripListas As ToolStrip
    Friend WithEvents ToolStripLabelTipo As ToolStripLabel
    Friend WithEvents ToolStripComboBoxTipo As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolstripbutRefrescar As ToolStripButton
    Friend WithEvents butAceptar As Button
    Friend WithEvents BAListaBancosBindingSource As BindingSource
    Friend WithEvents BABancosListaDataSet As BABancosListaDataSet
    Friend WithEvents butCancelar As Button
    Friend WithEvents BABancosTableAdapter As BABancosListaDataSetTableAdapters.BABancosTableAdapter
End Class
