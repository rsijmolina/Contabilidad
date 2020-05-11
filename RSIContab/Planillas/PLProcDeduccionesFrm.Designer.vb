<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLProcDeduccionesFrm
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLProcDeducDataSet = New RSIContab.PLProcDeducDataSet
        Me.PLPlanillasTableAdapter = New RSIContab.PLProcDeducDataSetTableAdapters.PLPlanillasTableAdapter
        Me.PlaniOtrasDedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLPlanillasOTTableAdapter = New RSIContab.PLProcDeducDataSetTableAdapters.PLPlanillasOTTableAdapter
        Me.DeduccionesDetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLDeduccionesDetTableAdapter = New RSIContab.PLProcDeducDataSetTableAdapters.PLDeduccionesDetTableAdapter
        Me.DefDeduccionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLDefinicionDeduccionesTableAdapter = New RSIContab.PLProcDeducDataSetTableAdapters.PLDefinicionDeduccionesTableAdapter
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLProcDeducDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlaniOtrasDedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeduccionesDetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefDeduccionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Procesando Deducciones..."
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLPlanillas"
        Me.PrincipalBindingSource.DataSource = Me.PLProcDeducDataSet
        '
        'PLProcDeducDataSet
        '
        Me.PLProcDeducDataSet.DataSetName = "PLProcDeducDataSet"
        Me.PLProcDeducDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLPlanillasTableAdapter
        '
        Me.PLPlanillasTableAdapter.ClearBeforeFill = True
        '
        'PlaniOtrasDedBindingSource
        '
        Me.PlaniOtrasDedBindingSource.DataMember = "PLPlanillasOT"
        Me.PlaniOtrasDedBindingSource.DataSource = Me.PLProcDeducDataSet
        '
        'PLPlanillasOTTableAdapter
        '
        Me.PLPlanillasOTTableAdapter.ClearBeforeFill = True
        '
        'DeduccionesDetBindingSource
        '
        Me.DeduccionesDetBindingSource.DataMember = "PLDeduccionesDet"
        Me.DeduccionesDetBindingSource.DataSource = Me.PLProcDeducDataSet
        '
        'PLDeduccionesDetTableAdapter
        '
        Me.PLDeduccionesDetTableAdapter.ClearBeforeFill = True
        '
        'DefDeduccionesBindingSource
        '
        Me.DefDeduccionesBindingSource.DataMember = "PLDefinicionDeducciones"
        Me.DefDeduccionesBindingSource.DataSource = Me.PLProcDeducDataSet
        '
        'PLDefinicionDeduccionesTableAdapter
        '
        Me.PLDefinicionDeduccionesTableAdapter.ClearBeforeFill = True
        '
        'PLProcDeduccionesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 72)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PLProcDeduccionesFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PLanillas"
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLProcDeducDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlaniOtrasDedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeduccionesDetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefDeduccionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLProcDeducDataSet As RSIContab.PLProcDeducDataSet
    Friend WithEvents PLPlanillasTableAdapter As RSIContab.PLProcDeducDataSetTableAdapters.PLPlanillasTableAdapter
    Friend WithEvents PlaniOtrasDedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLPlanillasOTTableAdapter As RSIContab.PLProcDeducDataSetTableAdapters.PLPlanillasOTTableAdapter
    Friend WithEvents DeduccionesDetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLDeduccionesDetTableAdapter As RSIContab.PLProcDeducDataSetTableAdapters.PLDeduccionesDetTableAdapter
    Friend WithEvents DefDeduccionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLDefinicionDeduccionesTableAdapter As RSIContab.PLProcDeducDataSetTableAdapters.PLDefinicionDeduccionesTableAdapter
End Class
