<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CargarDatosPlanillaFrm
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
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblAño = New System.Windows.Forms.Label
        Me.lblMes = New System.Windows.Forms.Label
        Me.lblNoPlanilla = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.PLCargarPlaniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLCargarDatosPlanillaDataSet = New RSIContab.PLCargarDatosPlanillaDataSet
        Me.PLPlanillasTableAdapter = New RSIContab.PLCargarDatosPlanillaDataSetTableAdapters.PLPlanillasTableAdapter
        CType(Me.PLCargarPlaniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLCargarDatosPlanillaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 119)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(90, 32)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "&Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(243, 119)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(90, 32)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Año:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mes:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(225, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No. Planilla:"
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.Location = New System.Drawing.Point(48, 13)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(10, 13)
        Me.lblAño.TabIndex = 5
        Me.lblAño.Text = "."
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(140, 13)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(10, 13)
        Me.lblMes.TabIndex = 6
        Me.lblMes.Text = "."
        '
        'lblNoPlanilla
        '
        Me.lblNoPlanilla.AutoSize = True
        Me.lblNoPlanilla.Location = New System.Drawing.Point(286, 12)
        Me.lblNoPlanilla.Name = "lblNoPlanilla"
        Me.lblNoPlanilla.Size = New System.Drawing.Size(10, 13)
        Me.lblNoPlanilla.TabIndex = 7
        Me.lblNoPlanilla.Text = "."
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(327, 45)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Este proceso agregará los datos de los empleados activos a la planilla correspond" & _
            "iente a este período. Indique si desea continuar."
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(12, 90)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(39, 13)
        Me.lblMensaje.TabIndex = 9
        Me.lblMensaje.Text = "Label5"
        Me.lblMensaje.Visible = False
        '
        'PLCargarPlaniBindingSource
        '
        Me.PLCargarPlaniBindingSource.DataMember = "PLPlanillas"
        Me.PLCargarPlaniBindingSource.DataSource = Me.PLCargarDatosPlanillaDataSet
        '
        'PLCargarDatosPlanillaDataSet
        '
        Me.PLCargarDatosPlanillaDataSet.DataSetName = "PLCargarDatosPlanillaDataSet"
        Me.PLCargarDatosPlanillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLPlanillasTableAdapter
        '
        Me.PLPlanillasTableAdapter.ClearBeforeFill = True
        '
        'CargarDatosPlanillaFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 161)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblNoPlanilla)
        Me.Controls.Add(Me.lblMes)
        Me.Controls.Add(Me.lblAño)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CargarDatosPlanillaFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar Datos de Empleados a la Planilla"
        CType(Me.PLCargarPlaniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLCargarDatosPlanillaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblAño As System.Windows.Forms.Label
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents lblNoPlanilla As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents PLCargarPlaniBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLCargarDatosPlanillaDataSet As RSIContab.PLCargarDatosPlanillaDataSet
    Friend WithEvents PLPlanillasTableAdapter As RSIContab.PLCargarDatosPlanillaDataSetTableAdapters.PLPlanillasTableAdapter
End Class
