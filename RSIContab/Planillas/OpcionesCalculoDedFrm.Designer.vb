<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpcionesCalculoDedFrm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.radiobutCalcTodosEmpleados = New System.Windows.Forms.RadioButton
        Me.radiobutCalcEmpleadoActual = New System.Windows.Forms.RadioButton
        Me.chkboxCalcularTodasDeducciones = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkboxDeduccion5 = New System.Windows.Forms.CheckBox
        Me.chkboxDeduccion4 = New System.Windows.Forms.CheckBox
        Me.chkboxDeduccion3 = New System.Windows.Forms.CheckBox
        Me.chkboxDeduccion2 = New System.Windows.Forms.CheckBox
        Me.chkboxDeduccion1 = New System.Windows.Forms.CheckBox
        Me.chkboxINPREMA = New System.Windows.Forms.CheckBox
        Me.chkboxINJUPEMP = New System.Windows.Forms.CheckBox
        Me.chkboxImpRenta = New System.Windows.Forms.CheckBox
        Me.chkboxImpVecinal = New System.Windows.Forms.CheckBox
        Me.chkboxRAP = New System.Windows.Forms.CheckBox
        Me.chkboxSeguroSocial = New System.Windows.Forms.CheckBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chklstboxOtrasDed = New System.Windows.Forms.CheckedListBox
        Me.chkboxMarcarTodasOtrasDed = New System.Windows.Forms.CheckBox
        Me.chkboxBorrarDetalleOtrasDed = New System.Windows.Forms.CheckBox
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.PlanillaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLPlaniActDatosDataSet = New RSIContab.PLPlaniActDatosDataSet
        Me.PLPlanillasTableAdapter = New RSIContab.PLPlaniActDatosDataSetTableAdapters.PLPlanillasTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PlanillaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLPlaniActDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radiobutCalcTodosEmpleados)
        Me.GroupBox1.Controls.Add(Me.radiobutCalcEmpleadoActual)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 42)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calcular Deducciones"
        '
        'radiobutCalcTodosEmpleados
        '
        Me.radiobutCalcTodosEmpleados.AutoSize = True
        Me.radiobutCalcTodosEmpleados.Location = New System.Drawing.Point(154, 19)
        Me.radiobutCalcTodosEmpleados.Name = "radiobutCalcTodosEmpleados"
        Me.radiobutCalcTodosEmpleados.Size = New System.Drawing.Size(151, 17)
        Me.radiobutCalcTodosEmpleados.TabIndex = 1
        Me.radiobutCalcTodosEmpleados.Text = "Para Todos los Empleados"
        Me.radiobutCalcTodosEmpleados.UseVisualStyleBackColor = True
        '
        'radiobutCalcEmpleadoActual
        '
        Me.radiobutCalcEmpleadoActual.AutoSize = True
        Me.radiobutCalcEmpleadoActual.Checked = True
        Me.radiobutCalcEmpleadoActual.Location = New System.Drawing.Point(8, 19)
        Me.radiobutCalcEmpleadoActual.Name = "radiobutCalcEmpleadoActual"
        Me.radiobutCalcEmpleadoActual.Size = New System.Drawing.Size(130, 17)
        Me.radiobutCalcEmpleadoActual.TabIndex = 0
        Me.radiobutCalcEmpleadoActual.TabStop = True
        Me.radiobutCalcEmpleadoActual.Text = "Para Empleado Actual"
        Me.radiobutCalcEmpleadoActual.UseVisualStyleBackColor = True
        '
        'chkboxCalcularTodasDeducciones
        '
        Me.chkboxCalcularTodasDeducciones.AutoSize = True
        Me.chkboxCalcularTodasDeducciones.Location = New System.Drawing.Point(4, 51)
        Me.chkboxCalcularTodasDeducciones.Name = "chkboxCalcularTodasDeducciones"
        Me.chkboxCalcularTodasDeducciones.Size = New System.Drawing.Size(179, 17)
        Me.chkboxCalcularTodasDeducciones.TabIndex = 1
        Me.chkboxCalcularTodasDeducciones.Text = "Calcular Todas las Deducciones"
        Me.chkboxCalcularTodasDeducciones.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkboxDeduccion5)
        Me.GroupBox2.Controls.Add(Me.chkboxDeduccion4)
        Me.GroupBox2.Controls.Add(Me.chkboxDeduccion3)
        Me.GroupBox2.Controls.Add(Me.chkboxDeduccion2)
        Me.GroupBox2.Controls.Add(Me.chkboxDeduccion1)
        Me.GroupBox2.Controls.Add(Me.chkboxINPREMA)
        Me.GroupBox2.Controls.Add(Me.chkboxINJUPEMP)
        Me.GroupBox2.Controls.Add(Me.chkboxImpRenta)
        Me.GroupBox2.Controls.Add(Me.chkboxImpVecinal)
        Me.GroupBox2.Controls.Add(Me.chkboxRAP)
        Me.GroupBox2.Controls.Add(Me.chkboxSeguroSocial)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(341, 113)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Calcular en Deducciones Fijas"
        '
        'chkboxDeduccion5
        '
        Me.chkboxDeduccion5.AutoSize = True
        Me.chkboxDeduccion5.Location = New System.Drawing.Point(230, 66)
        Me.chkboxDeduccion5.Name = "chkboxDeduccion5"
        Me.chkboxDeduccion5.Size = New System.Drawing.Size(87, 17)
        Me.chkboxDeduccion5.TabIndex = 10
        Me.chkboxDeduccion5.Text = "Deduccion 5"
        Me.chkboxDeduccion5.UseVisualStyleBackColor = True
        Me.chkboxDeduccion5.Visible = False
        '
        'chkboxDeduccion4
        '
        Me.chkboxDeduccion4.AutoSize = True
        Me.chkboxDeduccion4.Location = New System.Drawing.Point(111, 89)
        Me.chkboxDeduccion4.Name = "chkboxDeduccion4"
        Me.chkboxDeduccion4.Size = New System.Drawing.Size(87, 17)
        Me.chkboxDeduccion4.TabIndex = 9
        Me.chkboxDeduccion4.Text = "Deduccion 4"
        Me.chkboxDeduccion4.UseVisualStyleBackColor = True
        Me.chkboxDeduccion4.Visible = False
        '
        'chkboxDeduccion3
        '
        Me.chkboxDeduccion3.AutoSize = True
        Me.chkboxDeduccion3.Location = New System.Drawing.Point(111, 66)
        Me.chkboxDeduccion3.Name = "chkboxDeduccion3"
        Me.chkboxDeduccion3.Size = New System.Drawing.Size(87, 17)
        Me.chkboxDeduccion3.TabIndex = 8
        Me.chkboxDeduccion3.Text = "Deduccion 3"
        Me.chkboxDeduccion3.UseVisualStyleBackColor = True
        Me.chkboxDeduccion3.Visible = False
        '
        'chkboxDeduccion2
        '
        Me.chkboxDeduccion2.AutoSize = True
        Me.chkboxDeduccion2.Location = New System.Drawing.Point(7, 90)
        Me.chkboxDeduccion2.Name = "chkboxDeduccion2"
        Me.chkboxDeduccion2.Size = New System.Drawing.Size(87, 17)
        Me.chkboxDeduccion2.TabIndex = 7
        Me.chkboxDeduccion2.Text = "Deduccion 2"
        Me.chkboxDeduccion2.UseVisualStyleBackColor = True
        Me.chkboxDeduccion2.Visible = False
        '
        'chkboxDeduccion1
        '
        Me.chkboxDeduccion1.AutoSize = True
        Me.chkboxDeduccion1.Location = New System.Drawing.Point(8, 66)
        Me.chkboxDeduccion1.Name = "chkboxDeduccion1"
        Me.chkboxDeduccion1.Size = New System.Drawing.Size(87, 17)
        Me.chkboxDeduccion1.TabIndex = 6
        Me.chkboxDeduccion1.Text = "Deduccion 1"
        Me.chkboxDeduccion1.UseVisualStyleBackColor = True
        Me.chkboxDeduccion1.Visible = False
        '
        'chkboxINPREMA
        '
        Me.chkboxINPREMA.AutoSize = True
        Me.chkboxINPREMA.Location = New System.Drawing.Point(230, 43)
        Me.chkboxINPREMA.Name = "chkboxINPREMA"
        Me.chkboxINPREMA.Size = New System.Drawing.Size(75, 17)
        Me.chkboxINPREMA.TabIndex = 5
        Me.chkboxINPREMA.Text = "INPREMA"
        Me.chkboxINPREMA.UseVisualStyleBackColor = True
        '
        'chkboxINJUPEMP
        '
        Me.chkboxINJUPEMP.AutoSize = True
        Me.chkboxINJUPEMP.Location = New System.Drawing.Point(231, 19)
        Me.chkboxINJUPEMP.Name = "chkboxINJUPEMP"
        Me.chkboxINJUPEMP.Size = New System.Drawing.Size(80, 17)
        Me.chkboxINJUPEMP.TabIndex = 4
        Me.chkboxINJUPEMP.Text = "INJUPEMP"
        Me.chkboxINJUPEMP.UseVisualStyleBackColor = True
        '
        'chkboxImpRenta
        '
        Me.chkboxImpRenta.AutoSize = True
        Me.chkboxImpRenta.Location = New System.Drawing.Point(111, 43)
        Me.chkboxImpRenta.Name = "chkboxImpRenta"
        Me.chkboxImpRenta.Size = New System.Drawing.Size(113, 17)
        Me.chkboxImpRenta.TabIndex = 3
        Me.chkboxImpRenta.Text = "Impuesto S/Renta"
        Me.chkboxImpRenta.UseVisualStyleBackColor = True
        '
        'chkboxImpVecinal
        '
        Me.chkboxImpVecinal.AutoSize = True
        Me.chkboxImpVecinal.Location = New System.Drawing.Point(111, 20)
        Me.chkboxImpVecinal.Name = "chkboxImpVecinal"
        Me.chkboxImpVecinal.Size = New System.Drawing.Size(107, 17)
        Me.chkboxImpVecinal.TabIndex = 2
        Me.chkboxImpVecinal.Text = "Impuesto Vecinal"
        Me.chkboxImpVecinal.UseVisualStyleBackColor = True
        '
        'chkboxRAP
        '
        Me.chkboxRAP.AutoSize = True
        Me.chkboxRAP.Location = New System.Drawing.Point(7, 43)
        Me.chkboxRAP.Name = "chkboxRAP"
        Me.chkboxRAP.Size = New System.Drawing.Size(48, 17)
        Me.chkboxRAP.TabIndex = 1
        Me.chkboxRAP.Text = "RAP"
        Me.chkboxRAP.UseVisualStyleBackColor = True
        '
        'chkboxSeguroSocial
        '
        Me.chkboxSeguroSocial.AutoSize = True
        Me.chkboxSeguroSocial.Location = New System.Drawing.Point(7, 20)
        Me.chkboxSeguroSocial.Name = "chkboxSeguroSocial"
        Me.chkboxSeguroSocial.Size = New System.Drawing.Size(92, 17)
        Me.chkboxSeguroSocial.TabIndex = 0
        Me.chkboxSeguroSocial.Text = "Seguro Social"
        Me.chkboxSeguroSocial.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Location = New System.Drawing.Point(34, 407)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(96, 26)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(219, 407)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(96, 26)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chklstboxOtrasDed)
        Me.GroupBox3.Controls.Add(Me.chkboxMarcarTodasOtrasDed)
        Me.GroupBox3.Controls.Add(Me.chkboxBorrarDetalleOtrasDed)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 193)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(341, 190)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Otras Deducciones"
        '
        'chklstboxOtrasDed
        '
        Me.chklstboxOtrasDed.FormattingEnabled = True
        Me.chklstboxOtrasDed.Location = New System.Drawing.Point(9, 66)
        Me.chklstboxOtrasDed.Name = "chklstboxOtrasDed"
        Me.chklstboxOtrasDed.Size = New System.Drawing.Size(323, 109)
        Me.chklstboxOtrasDed.TabIndex = 4
        '
        'chkboxMarcarTodasOtrasDed
        '
        Me.chkboxMarcarTodasOtrasDed.AutoSize = True
        Me.chkboxMarcarTodasOtrasDed.Location = New System.Drawing.Point(7, 42)
        Me.chkboxMarcarTodasOtrasDed.Name = "chkboxMarcarTodasOtrasDed"
        Me.chkboxMarcarTodasOtrasDed.Size = New System.Drawing.Size(202, 17)
        Me.chkboxMarcarTodasOtrasDed.TabIndex = 3
        Me.chkboxMarcarTodasOtrasDed.Text = "Marcar Todas las Otras Deducciones"
        Me.chkboxMarcarTodasOtrasDed.UseVisualStyleBackColor = True
        '
        'chkboxBorrarDetalleOtrasDed
        '
        Me.chkboxBorrarDetalleOtrasDed.AutoSize = True
        Me.chkboxBorrarDetalleOtrasDed.Location = New System.Drawing.Point(8, 19)
        Me.chkboxBorrarDetalleOtrasDed.Name = "chkboxBorrarDetalleOtrasDed"
        Me.chkboxBorrarDetalleOtrasDed.Size = New System.Drawing.Size(238, 17)
        Me.chkboxBorrarDetalleOtrasDed.TabIndex = 2
        Me.chkboxBorrarDetalleOtrasDed.Text = "Borrar Todo el Detalle de Otras Deducciones"
        Me.chkboxBorrarDetalleOtrasDed.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(4, 390)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(10, 13)
        Me.lblMensaje.TabIndex = 6
        Me.lblMensaje.Text = "."
        Me.lblMensaje.Visible = False
        '
        'PlanillaBindingSource
        '
        Me.PlanillaBindingSource.DataMember = "PLPlanillas"
        Me.PlanillaBindingSource.DataSource = Me.PLPlaniActDatosDataSet
        '
        'PLPlaniActDatosDataSet
        '
        Me.PLPlaniActDatosDataSet.DataSetName = "PLPlaniActDatosDataSet"
        Me.PLPlaniActDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLPlanillasTableAdapter
        '
        Me.PLPlanillasTableAdapter.ClearBeforeFill = True
        '
        'OpcionesCalculoDedFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 445)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.chkboxCalcularTodasDeducciones)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OpcionesCalculoDedFrm"
        Me.Text = "Opciones de Cálculo de Deducciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PlanillaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLPlaniActDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radiobutCalcTodosEmpleados As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutCalcEmpleadoActual As System.Windows.Forms.RadioButton
    Friend WithEvents chkboxCalcularTodasDeducciones As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkboxINJUPEMP As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxImpRenta As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxImpVecinal As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxRAP As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxSeguroSocial As System.Windows.Forms.CheckBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkboxMarcarTodasOtrasDed As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxBorrarDetalleOtrasDed As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxINPREMA As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxDeduccion5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxDeduccion4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxDeduccion3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxDeduccion2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxDeduccion1 As System.Windows.Forms.CheckBox
    Friend WithEvents chklstboxOtrasDed As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents PlanillaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLPlaniActDatosDataSet As RSIContab.PLPlaniActDatosDataSet
    Friend WithEvents PLPlanillasTableAdapter As RSIContab.PLPlaniActDatosDataSetTableAdapters.PLPlanillasTableAdapter
End Class
