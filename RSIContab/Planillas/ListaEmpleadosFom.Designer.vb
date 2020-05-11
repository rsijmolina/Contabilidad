<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaEmpleadosFom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaEmpleadosFom))
        Me.c1dbgrdListaEmpleados = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLListaEmpleadosDataSet = New RSIContab.PLListaEmpleadosDataSet()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.PLEmpleadosTableAdapter = New RSIContab.PLListaEmpleadosDataSetTableAdapters.PLEmpleadosTableAdapter()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.toolstripcmbboxTipoEmpleado = New System.Windows.Forms.ToolStripComboBox()
        CType(Me.c1dbgrdListaEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLListaEmpleadosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'c1dbgrdListaEmpleados
        '
        Me.c1dbgrdListaEmpleados.DataSource = Me.PrincipalBindingSource
        Me.c1dbgrdListaEmpleados.FilterBar = True
        Me.c1dbgrdListaEmpleados.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbgrdListaEmpleados.Images.Add(CType(resources.GetObject("c1dbgrdListaEmpleados.Images"), System.Drawing.Image))
        Me.c1dbgrdListaEmpleados.Location = New System.Drawing.Point(5, 29)
        Me.c1dbgrdListaEmpleados.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.c1dbgrdListaEmpleados.Name = "c1dbgrdListaEmpleados"
        Me.c1dbgrdListaEmpleados.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbgrdListaEmpleados.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbgrdListaEmpleados.PreviewInfo.ZoomFactor = 75.0R
        Me.c1dbgrdListaEmpleados.PrintInfo.PageSettings = CType(resources.GetObject("c1dbgrdListaEmpleados.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1dbgrdListaEmpleados.Size = New System.Drawing.Size(444, 418)
        Me.c1dbgrdListaEmpleados.TabIndex = 0
        Me.c1dbgrdListaEmpleados.Text = "C1TrueDBGrid1"
        Me.c1dbgrdListaEmpleados.PropBag = resources.GetString("c1dbgrdListaEmpleados.PropBag")
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLEmpleados"
        Me.PrincipalBindingSource.DataSource = Me.PLListaEmpleadosDataSet
        '
        'PLListaEmpleadosDataSet
        '
        Me.PLListaEmpleadosDataSet.DataSetName = "PLListaEmpleadosDataSet"
        Me.PLListaEmpleadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Location = New System.Drawing.Point(45, 453)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(98, 31)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(302, 453)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(98, 31)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'PLEmpleadosTableAdapter
        '
        Me.PLEmpleadosTableAdapter.ClearBeforeFill = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.toolstripcmbboxTipoEmpleado})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(453, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(99, 22)
        Me.ToolStripLabel1.Text = "Listar Empleados:"
        '
        'toolstripcmbboxTipoEmpleado
        '
        Me.toolstripcmbboxTipoEmpleado.Name = "toolstripcmbboxTipoEmpleado"
        Me.toolstripcmbboxTipoEmpleado.Size = New System.Drawing.Size(90, 25)
        '
        'ListaEmpleadosFom
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(453, 496)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.c1dbgrdListaEmpleados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ListaEmpleadosFom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Empleados"
        CType(Me.c1dbgrdListaEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLListaEmpleadosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLListaEmpleadosDataSet As RSIContab.PLListaEmpleadosDataSet
    Friend WithEvents PLEmpleadosTableAdapter As RSIContab.PLListaEmpleadosDataSetTableAdapters.PLEmpleadosTableAdapter
    Friend WithEvents c1dbgrdListaEmpleados As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents toolstripcmbboxTipoEmpleado As System.Windows.Forms.ToolStripComboBox
End Class
