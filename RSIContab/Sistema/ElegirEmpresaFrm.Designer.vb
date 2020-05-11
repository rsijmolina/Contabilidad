<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ElegirEmpresaFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ElegirEmpresaFrm))
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElegirEmpresaDataSet = New RSIContab.ElegirEmpresaDataSet
        Me.DBTableAdapter = New RSIContab.ElegirEmpresaDataSetTableAdapters.DBTableAdapter
        Me.c1truedbgrdPrincipal = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.butAceptar = New System.Windows.Forms.Button
        Me.butCancelar = New System.Windows.Forms.Button
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElegirEmpresaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1truedbgrdPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "DB"
        Me.PrincipalBindingSource.DataSource = Me.ElegirEmpresaDataSet
        '
        'ElegirEmpresaDataSet
        '
        Me.ElegirEmpresaDataSet.DataSetName = "ElegirEmpresaDataSet"
        Me.ElegirEmpresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DBTableAdapter
        '
        Me.DBTableAdapter.ClearBeforeFill = True
        '
        'c1truedbgrdPrincipal
        '
        Me.c1truedbgrdPrincipal.DataSource = Me.PrincipalBindingSource
        Me.c1truedbgrdPrincipal.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1truedbgrdPrincipal.Images.Add(CType(resources.GetObject("c1truedbgrdPrincipal.Images"), System.Drawing.Image))
        Me.c1truedbgrdPrincipal.Location = New System.Drawing.Point(5, 5)
        Me.c1truedbgrdPrincipal.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.c1truedbgrdPrincipal.Name = "c1truedbgrdPrincipal"
        Me.c1truedbgrdPrincipal.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1truedbgrdPrincipal.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1truedbgrdPrincipal.PreviewInfo.ZoomFactor = 75
        Me.c1truedbgrdPrincipal.PrintInfo.PageSettings = CType(resources.GetObject("c1truedbgrdPrincipal.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1truedbgrdPrincipal.RowHeight = 17
        Me.c1truedbgrdPrincipal.Size = New System.Drawing.Size(302, 261)
        Me.c1truedbgrdPrincipal.TabIndex = 0
        Me.c1truedbgrdPrincipal.Text = "C1TrueDBGrid1"
        Me.c1truedbgrdPrincipal.PropBag = resources.GetString("c1truedbgrdPrincipal.PropBag")
        '
        'butAceptar
        '
        Me.butAceptar.Location = New System.Drawing.Point(28, 273)
        Me.butAceptar.Name = "butAceptar"
        Me.butAceptar.Size = New System.Drawing.Size(91, 29)
        Me.butAceptar.TabIndex = 1
        Me.butAceptar.Text = "&Aceptar"
        Me.butAceptar.UseVisualStyleBackColor = True
        '
        'butCancelar
        '
        Me.butCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butCancelar.Location = New System.Drawing.Point(190, 273)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(91, 29)
        Me.butCancelar.TabIndex = 2
        Me.butCancelar.Text = "&Cancelar"
        Me.butCancelar.UseVisualStyleBackColor = True
        '
        'ElegirEmpresaFrm
        '
        Me.AcceptButton = Me.butAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.butCancelar
        Me.ClientSize = New System.Drawing.Size(314, 314)
        Me.Controls.Add(Me.butCancelar)
        Me.Controls.Add(Me.butAceptar)
        Me.Controls.Add(Me.c1truedbgrdPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ElegirEmpresaFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elegir Empresa"
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElegirEmpresaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1truedbgrdPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ElegirEmpresaDataSet As RSIContab.ElegirEmpresaDataSet
    Friend WithEvents DBTableAdapter As RSIContab.ElegirEmpresaDataSetTableAdapters.DBTableAdapter
    Friend WithEvents c1truedbgrdPrincipal As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents butAceptar As System.Windows.Forms.Button
    Friend WithEvents butCancelar As System.Windows.Forms.Button
End Class
