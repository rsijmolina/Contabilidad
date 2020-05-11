<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLListaDedEmpFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PLListaDedEmpFrm))
        Me.c1truedbgrdDedEmp = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLListaDedEmpDataSet = New RSIContab.PLListaDedEmpDataSet
        Me.PLDeduccionesTableAdapter = New RSIContab.PLListaDedEmpDataSetTableAdapters.PLDeduccionesTableAdapter
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        CType(Me.c1truedbgrdDedEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLListaDedEmpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1truedbgrdDedEmp
        '
        Me.c1truedbgrdDedEmp.AllowUpdate = False
        Me.c1truedbgrdDedEmp.DataSource = Me.PrincipalBindingSource
        Me.c1truedbgrdDedEmp.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1truedbgrdDedEmp.Images.Add(CType(resources.GetObject("c1truedbgrdDedEmp.Images"), System.Drawing.Image))
        Me.c1truedbgrdDedEmp.Location = New System.Drawing.Point(4, 3)
        Me.c1truedbgrdDedEmp.Name = "c1truedbgrdDedEmp"
        Me.c1truedbgrdDedEmp.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1truedbgrdDedEmp.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1truedbgrdDedEmp.PreviewInfo.ZoomFactor = 75
        Me.c1truedbgrdDedEmp.PrintInfo.PageSettings = CType(resources.GetObject("c1truedbgrdDedEmp.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1truedbgrdDedEmp.RowHeight = 17
        Me.c1truedbgrdDedEmp.Size = New System.Drawing.Size(806, 232)
        Me.c1truedbgrdDedEmp.TabIndex = 0
        Me.c1truedbgrdDedEmp.Text = "C1TrueDBGrid1"
        Me.c1truedbgrdDedEmp.PropBag = resources.GetString("c1truedbgrdDedEmp.PropBag")
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLDeducciones"
        Me.PrincipalBindingSource.DataSource = Me.PLListaDedEmpDataSet
        '
        'PLListaDedEmpDataSet
        '
        Me.PLListaDedEmpDataSet.DataSetName = "PLListaDedEmpDataSet"
        Me.PLListaDedEmpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLDeduccionesTableAdapter
        '
        Me.PLDeduccionesTableAdapter.ClearBeforeFill = True
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Location = New System.Drawing.Point(135, 245)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(98, 31)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(575, 245)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(98, 31)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'PLListaDedEmpFrm
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(814, 288)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.c1truedbgrdDedEmp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PLListaDedEmpFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deducciones Pendientes"
        CType(Me.c1truedbgrdDedEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLListaDedEmpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents c1truedbgrdDedEmp As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLListaDedEmpDataSet As RSIContab.PLListaDedEmpDataSet
    Friend WithEvents PLDeduccionesTableAdapter As RSIContab.PLListaDedEmpDataSetTableAdapters.PLDeduccionesTableAdapter
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
