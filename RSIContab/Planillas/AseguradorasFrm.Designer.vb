<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AseguradorasFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AseguradorasFrm))
        Me.c1dbgrdGrupos = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLAseguradorasDataSet = New RSIContab.PLAseguradorasDataSet
        Me.PLAseguradorasTableAdapter = New RSIContab.PLAseguradorasDataSetTableAdapters.PLAseguradorasTableAdapter
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        CType(Me.c1dbgrdGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLAseguradorasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1dbgrdGrupos
        '
        Me.c1dbgrdGrupos.AllowAddNew = True
        Me.c1dbgrdGrupos.AllowDelete = True
        Me.c1dbgrdGrupos.DataSource = Me.PrincipalBindingSource
        Me.c1dbgrdGrupos.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbgrdGrupos.Images.Add(CType(resources.GetObject("c1dbgrdGrupos.Images"), System.Drawing.Image))
        Me.c1dbgrdGrupos.Location = New System.Drawing.Point(12, 12)
        Me.c1dbgrdGrupos.Name = "c1dbgrdGrupos"
        Me.c1dbgrdGrupos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbgrdGrupos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbgrdGrupos.PreviewInfo.ZoomFactor = 75
        Me.c1dbgrdGrupos.PrintInfo.PageSettings = CType(resources.GetObject("c1dbgrdGrupos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1dbgrdGrupos.RowHeight = 17
        Me.c1dbgrdGrupos.Size = New System.Drawing.Size(212, 206)
        Me.c1dbgrdGrupos.TabIndex = 52
        Me.c1dbgrdGrupos.Text = "C1TrueDBGrid1"
        Me.c1dbgrdGrupos.PropBag = resources.GetString("c1dbgrdGrupos.PropBag")
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLAseguradoras"
        Me.PrincipalBindingSource.DataSource = Me.PLAseguradorasDataSet
        '
        'PLAseguradorasDataSet
        '
        Me.PLAseguradorasDataSet.DataSetName = "PLAseguradorasDataSet"
        Me.PLAseguradorasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLAseguradorasTableAdapter
        '
        Me.PLAseguradorasTableAdapter.ClearBeforeFill = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(13, 231)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(73, 29)
        Me.btnGuardar.TabIndex = 53
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(149, 231)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 29)
        Me.btnCancelar.TabIndex = 54
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'AseguradorasFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 271)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.c1dbgrdGrupos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AseguradorasFrm"
        Me.Text = "Aseguradoras"
        CType(Me.c1dbgrdGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLAseguradorasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents c1dbgrdGrupos As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLAseguradorasDataSet As RSIContab.PLAseguradorasDataSet
    Friend WithEvents PLAseguradorasTableAdapter As RSIContab.PLAseguradorasDataSetTableAdapters.PLAseguradorasTableAdapter
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
