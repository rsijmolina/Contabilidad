<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BancosFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BancosFrm))
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLBancosDataSet = New RSIContab.PLBancosDataSet
        Me.PLBancosTableAdapter = New RSIContab.PLBancosDataSetTableAdapters.PLBancosTableAdapter
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.c1dbgrdGrupos = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLBancosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1dbgrdGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLBancos"
        Me.PrincipalBindingSource.DataSource = Me.PLBancosDataSet
        '
        'PLBancosDataSet
        '
        Me.PLBancosDataSet.DataSetName = "PLBancosDataSet"
        Me.PLBancosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLBancosTableAdapter
        '
        Me.PLBancosTableAdapter.ClearBeforeFill = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(147, 229)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 29)
        Me.btnCancelar.TabIndex = 57
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(11, 229)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(73, 29)
        Me.btnGuardar.TabIndex = 56
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'c1dbgrdGrupos
        '
        Me.c1dbgrdGrupos.AllowAddNew = True
        Me.c1dbgrdGrupos.AllowDelete = True
        Me.c1dbgrdGrupos.DataSource = Me.PrincipalBindingSource
        Me.c1dbgrdGrupos.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbgrdGrupos.Images.Add(CType(resources.GetObject("c1dbgrdGrupos.Images"), System.Drawing.Image))
        Me.c1dbgrdGrupos.Location = New System.Drawing.Point(10, 10)
        Me.c1dbgrdGrupos.Name = "c1dbgrdGrupos"
        Me.c1dbgrdGrupos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbgrdGrupos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbgrdGrupos.PreviewInfo.ZoomFactor = 75
        Me.c1dbgrdGrupos.PrintInfo.PageSettings = CType(resources.GetObject("c1dbgrdGrupos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1dbgrdGrupos.RowHeight = 17
        Me.c1dbgrdGrupos.Size = New System.Drawing.Size(212, 206)
        Me.c1dbgrdGrupos.TabIndex = 55
        Me.c1dbgrdGrupos.Text = "C1TrueDBGrid1"
        Me.c1dbgrdGrupos.PropBag = resources.GetString("c1dbgrdGrupos.PropBag")
        '
        'BancosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 269)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.c1dbgrdGrupos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "BancosFrm"
        Me.Text = "Bancos"
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLBancosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1dbgrdGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLBancosDataSet As RSIContab.PLBancosDataSet
    Friend WithEvents PLBancosTableAdapter As RSIContab.PLBancosDataSetTableAdapters.PLBancosTableAdapter
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents c1dbgrdGrupos As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
