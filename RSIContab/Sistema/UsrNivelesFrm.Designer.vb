<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsrNivelesFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsrNivelesFrm))
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.c1dbgrdNiveles = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.UsrNivelesDataSet = New RSIContab.UsrNivelesDataSet
        Me.NivelesContTableAdapter = New RSIContab.UsrNivelesDataSetTableAdapters.NivelesContTableAdapter
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1dbgrdNiveles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsrNivelesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "NivelesCont"
        Me.PrincipalBindingSource.DataSource = Me.UsrNivelesDataSet
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(525, 427)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(96, 34)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(62, 427)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(96, 34)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'c1dbgrdNiveles
        '
        Me.c1dbgrdNiveles.DataSource = Me.PrincipalBindingSource
        Me.c1dbgrdNiveles.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbgrdNiveles.Images.Add(CType(resources.GetObject("c1dbgrdNiveles.Images"), System.Drawing.Image))
        Me.c1dbgrdNiveles.Location = New System.Drawing.Point(2, 4)
        Me.c1dbgrdNiveles.Name = "c1dbgrdNiveles"
        Me.c1dbgrdNiveles.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbgrdNiveles.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbgrdNiveles.PreviewInfo.ZoomFactor = 75
        Me.c1dbgrdNiveles.PrintInfo.PageSettings = CType(resources.GetObject("c1dbgrdNiveles.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1dbgrdNiveles.RowHeight = 18
        Me.c1dbgrdNiveles.Size = New System.Drawing.Size(678, 415)
        Me.c1dbgrdNiveles.TabIndex = 3
        Me.c1dbgrdNiveles.Text = "C1TrueDBGrid1"
        Me.c1dbgrdNiveles.PropBag = resources.GetString("c1dbgrdNiveles.PropBag")
        '
        'UsrNivelesDataSet
        '
        Me.UsrNivelesDataSet.DataSetName = "UsrNivelesDataSet"
        Me.UsrNivelesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NivelesContTableAdapter
        '
        Me.NivelesContTableAdapter.ClearBeforeFill = True
        '
        'UsrNivelesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 473)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.c1dbgrdNiveles)
        Me.Name = "UsrNivelesFrm"
        Me.Text = "Niveles de Usuarios"
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1dbgrdNiveles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsrNivelesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents c1dbgrdNiveles As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents UsrNivelesDataSet As RSIContab.UsrNivelesDataSet
    Friend WithEvents NivelesContTableAdapter As RSIContab.UsrNivelesDataSetTableAdapters.NivelesContTableAdapter
End Class
