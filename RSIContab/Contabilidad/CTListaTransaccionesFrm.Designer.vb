<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTListaTransaccionesFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CTListaTransaccionesFrm))
        Me.butCancelar = New System.Windows.Forms.Button()
        Me.butAceptar = New System.Windows.Forms.Button()
        Me.ListaTransaccionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTListaTransaccionesDataSet = New RSIContab.CTListaTransaccionesDataSet()
        Me.CTTransaccionesEncabezadoTableAdapter = New RSIContab.CTListaTransaccionesDataSetTableAdapters.CTTransaccionesEncabezadoTableAdapter()
        Me.c1dbgrdDetalle = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.toolstripListas = New System.Windows.Forms.ToolStrip()
        Me.toolstripbutRefrescarLista = New System.Windows.Forms.ToolStripButton()
        CType(Me.ListaTransaccionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTListaTransaccionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1dbgrdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripListas.SuspendLayout()
        Me.SuspendLayout()
        '
        'butCancelar
        '
        Me.butCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butCancelar.Location = New System.Drawing.Point(510, 350)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(107, 33)
        Me.butCancelar.TabIndex = 17
        Me.butCancelar.Text = "&Cancelar"
        Me.butCancelar.UseVisualStyleBackColor = True
        '
        'butAceptar
        '
        Me.butAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.butAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.butAceptar.Location = New System.Drawing.Point(22, 350)
        Me.butAceptar.Name = "butAceptar"
        Me.butAceptar.Size = New System.Drawing.Size(107, 33)
        Me.butAceptar.TabIndex = 16
        Me.butAceptar.Text = "&Aceptar"
        Me.butAceptar.UseVisualStyleBackColor = True
        '
        'ListaTransaccionesBindingSource
        '
        Me.ListaTransaccionesBindingSource.DataMember = "CTTransaccionesEncabezado"
        Me.ListaTransaccionesBindingSource.DataSource = Me.CTListaTransaccionesDataSet
        '
        'CTListaTransaccionesDataSet
        '
        Me.CTListaTransaccionesDataSet.DataSetName = "CTListaTransaccionesDataSet"
        Me.CTListaTransaccionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CTTransaccionesEncabezadoTableAdapter
        '
        Me.CTTransaccionesEncabezadoTableAdapter.ClearBeforeFill = True
        '
        'c1dbgrdDetalle
        '
        Me.c1dbgrdDetalle.AllowSort = False
        Me.c1dbgrdDetalle.AllowUpdate = False
        Me.c1dbgrdDetalle.AlternatingRows = True
        Me.c1dbgrdDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c1dbgrdDetalle.BackColor = System.Drawing.SystemColors.Control
        Me.c1dbgrdDetalle.DataSource = Me.ListaTransaccionesBindingSource
        Me.c1dbgrdDetalle.FilterBar = True
        Me.c1dbgrdDetalle.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbgrdDetalle.Images.Add(CType(resources.GetObject("c1dbgrdDetalle.Images"), System.Drawing.Image))
        Me.c1dbgrdDetalle.Location = New System.Drawing.Point(3, 28)
        Me.c1dbgrdDetalle.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.c1dbgrdDetalle.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None
        Me.c1dbgrdDetalle.Name = "c1dbgrdDetalle"
        Me.c1dbgrdDetalle.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbgrdDetalle.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbgrdDetalle.PreviewInfo.ZoomFactor = 75.0R
        Me.c1dbgrdDetalle.PrintInfo.PageSettings = CType(resources.GetObject("c1dbgrdDetalle.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1dbgrdDetalle.RowHeight = 17
        Me.c1dbgrdDetalle.Size = New System.Drawing.Size(642, 316)
        Me.c1dbgrdDetalle.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.c1dbgrdDetalle.TabIndex = 54
        Me.c1dbgrdDetalle.Text = "C1TrueDBGrid1"
        Me.c1dbgrdDetalle.PropBag = resources.GetString("c1dbgrdDetalle.PropBag")
        '
        'toolstripListas
        '
        Me.toolstripListas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.toolstripListas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripbutRefrescarLista})
        Me.toolstripListas.Location = New System.Drawing.Point(0, 0)
        Me.toolstripListas.Name = "toolstripListas"
        Me.toolstripListas.Size = New System.Drawing.Size(647, 25)
        Me.toolstripListas.TabIndex = 56
        Me.toolstripListas.Text = "ToolStrip1"
        '
        'toolstripbutRefrescarLista
        '
        Me.toolstripbutRefrescarLista.Image = Global.RSIContab.My.Resources.Resources.RefreshDocViewHS
        Me.toolstripbutRefrescarLista.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutRefrescarLista.Name = "toolstripbutRefrescarLista"
        Me.toolstripbutRefrescarLista.Size = New System.Drawing.Size(102, 22)
        Me.toolstripbutRefrescarLista.Text = "Refrescar Lista"
        '
        'CTListaTransaccionesFrm
        '
        Me.AcceptButton = Me.butAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.butCancelar
        Me.ClientSize = New System.Drawing.Size(647, 395)
        Me.Controls.Add(Me.toolstripListas)
        Me.Controls.Add(Me.c1dbgrdDetalle)
        Me.Controls.Add(Me.butCancelar)
        Me.Controls.Add(Me.butAceptar)
        Me.MaximizeBox = False
        Me.Name = "CTListaTransaccionesFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Transacciones"
        CType(Me.ListaTransaccionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTListaTransaccionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1dbgrdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripListas.ResumeLayout(False)
        Me.toolstripListas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents butCancelar As System.Windows.Forms.Button
    Friend WithEvents butAceptar As System.Windows.Forms.Button
    Friend WithEvents ListaTransaccionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTListaTransaccionesDataSet As RSIContab.CTListaTransaccionesDataSet
    Friend WithEvents CTTransaccionesEncabezadoTableAdapter As RSIContab.CTListaTransaccionesDataSetTableAdapters.CTTransaccionesEncabezadoTableAdapter
    Friend WithEvents c1dbgrdDetalle As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents toolstripListas As System.Windows.Forms.ToolStrip
    Friend WithEvents toolstripbutRefrescarLista As System.Windows.Forms.ToolStripButton
End Class
