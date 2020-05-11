<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLCierrePlanillaFrm
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
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.lblCierrePlanilla = New System.Windows.Forms.Label
        Me.PLDeduccionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLCierrePlanillaDataSet = New RSIContab.PLCierrePlanillaDataSet
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLPlanillasTableAdapter = New RSIContab.PLCierrePlanillaDataSetTableAdapters.PLPlanillasTableAdapter
        Me.PLPLanillasOTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLPlanillasOTTableAdapter = New RSIContab.PLCierrePlanillaDataSetTableAdapters.PLPlanillasOTTableAdapter
        Me.PLDeduccionesISRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLDeduccionISRTableAdapter = New RSIContab.PLCierrePlanillaDataSetTableAdapters.PLDeduccionISRTableAdapter
        Me.PLPlanillasCerradasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLPlanillasCerradasTableAdapter = New RSIContab.PLCierrePlanillaDataSetTableAdapters.PLPlanillasCerradasTableAdapter
        Me.PLDeduccionesTableAdapter = New RSIContab.PLCierrePlanillaDataSetTableAdapters.PLDeduccionesTableAdapter
        CType(Me.PLDeduccionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLCierrePlanillaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLPLanillasOTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLDeduccionesISRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLPlanillasCerradasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(22, 109)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(94, 34)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(173, 109)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 34)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblCierrePlanilla
        '
        Me.lblCierrePlanilla.Location = New System.Drawing.Point(13, 13)
        Me.lblCierrePlanilla.Name = "lblCierrePlanilla"
        Me.lblCierrePlanilla.Size = New System.Drawing.Size(267, 73)
        Me.lblCierrePlanilla.TabIndex = 2
        Me.lblCierrePlanilla.Text = "Label1"
        '
        'PLDeduccionesBindingSource
        '
        Me.PLDeduccionesBindingSource.DataMember = "PLDeducciones"
        Me.PLDeduccionesBindingSource.DataSource = Me.PLCierrePlanillaDataSet
        '
        'PLCierrePlanillaDataSet
        '
        Me.PLCierrePlanillaDataSet.DataSetName = "PLCierrePlanillaDataSet"
        Me.PLCierrePlanillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLPlanillas"
        Me.PrincipalBindingSource.DataSource = Me.PLCierrePlanillaDataSet
        '
        'PLPlanillasTableAdapter
        '
        Me.PLPlanillasTableAdapter.ClearBeforeFill = True
        '
        'PLPLanillasOTBindingSource
        '
        Me.PLPLanillasOTBindingSource.DataMember = "PLPlanillasOT"
        Me.PLPLanillasOTBindingSource.DataSource = Me.PLCierrePlanillaDataSet
        '
        'PLPlanillasOTTableAdapter
        '
        Me.PLPlanillasOTTableAdapter.ClearBeforeFill = True
        '
        'PLDeduccionesISRBindingSource
        '
        Me.PLDeduccionesISRBindingSource.DataMember = "PLDeduccionISR"
        Me.PLDeduccionesISRBindingSource.DataSource = Me.PLCierrePlanillaDataSet
        '
        'PLDeduccionISRTableAdapter
        '
        Me.PLDeduccionISRTableAdapter.ClearBeforeFill = True
        '
        'PLPlanillasCerradasBindingSource
        '
        Me.PLPlanillasCerradasBindingSource.DataMember = "PLPlanillasCerradas"
        Me.PLPlanillasCerradasBindingSource.DataSource = Me.PLCierrePlanillaDataSet
        '
        'PLPlanillasCerradasTableAdapter
        '
        Me.PLPlanillasCerradasTableAdapter.ClearBeforeFill = True
        '
        'PLDeduccionesTableAdapter
        '
        Me.PLDeduccionesTableAdapter.ClearBeforeFill = True
        '
        'PLCierrePlanillaFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 155)
        Me.Controls.Add(Me.lblCierrePlanilla)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PLCierrePlanillaFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cierre de Planilla"
        CType(Me.PLDeduccionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLCierrePlanillaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLPLanillasOTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLDeduccionesISRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLPlanillasCerradasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblCierrePlanilla As System.Windows.Forms.Label
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLCierrePlanillaDataSet As RSIContab.PLCierrePlanillaDataSet
    Friend WithEvents PLPlanillasTableAdapter As RSIContab.PLCierrePlanillaDataSetTableAdapters.PLPlanillasTableAdapter
    Friend WithEvents PLPLanillasOTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLPlanillasOTTableAdapter As RSIContab.PLCierrePlanillaDataSetTableAdapters.PLPlanillasOTTableAdapter
    Friend WithEvents PLDeduccionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLDeduccionesISRBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLDeduccionISRTableAdapter As RSIContab.PLCierrePlanillaDataSetTableAdapters.PLDeduccionISRTableAdapter
    Friend WithEvents PLPlanillasCerradasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLPlanillasCerradasTableAdapter As RSIContab.PLCierrePlanillaDataSetTableAdapters.PLPlanillasCerradasTableAdapter
    Friend WithEvents PLDeduccionesTableAdapter As RSIContab.PLCierrePlanillaDataSetTableAdapters.PLDeduccionesTableAdapter
End Class
