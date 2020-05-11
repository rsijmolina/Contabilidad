<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLRepVacacionesFrm
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
        Me.c1dateFecha = New C1.Win.C1Input.C1DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radiobutResumen = New System.Windows.Forms.RadioButton()
        Me.radiobutDesglosado = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.c1numAnioFinal = New C1.Win.C1Input.C1NumericEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLVacResumenDataSet = New RSIContab.PLVacResumenDataSet()
        Me.PLVacacionesResumenTableAdapter = New RSIContab.PLVacResumenDataSetTableAdapters.PLVacacionesResumenTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radiobutEmpleadosRetirados = New System.Windows.Forms.RadioButton()
        Me.radiobutEmpleadosActivos = New System.Windows.Forms.RadioButton()
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.c1numAnioFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLVacResumenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'c1dateFecha
        '
        Me.c1dateFecha.DateTimeInput = False
        Me.c1dateFecha.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.c1dateFecha.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1dateFecha.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.c1dateFecha.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1dateFecha.Location = New System.Drawing.Point(125, 12)
        Me.c1dateFecha.Name = "c1dateFecha"
        Me.c1dateFecha.Size = New System.Drawing.Size(93, 20)
        Me.c1dateFecha.TabIndex = 12
        Me.c1dateFecha.Tag = "CM"
        Me.c1dateFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Fecha:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(25, 202)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(93, 35)
        Me.btnAceptar.TabIndex = 13
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(179, 202)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(93, 35)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radiobutResumen)
        Me.GroupBox1.Controls.Add(Me.radiobutDesglosado)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 49)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Reporte"
        '
        'radiobutResumen
        '
        Me.radiobutResumen.AutoSize = True
        Me.radiobutResumen.Location = New System.Drawing.Point(124, 20)
        Me.radiobutResumen.Name = "radiobutResumen"
        Me.radiobutResumen.Size = New System.Drawing.Size(70, 17)
        Me.radiobutResumen.TabIndex = 1
        Me.radiobutResumen.Text = "Resumen"
        Me.radiobutResumen.UseVisualStyleBackColor = True
        '
        'radiobutDesglosado
        '
        Me.radiobutDesglosado.AutoSize = True
        Me.radiobutDesglosado.Checked = True
        Me.radiobutDesglosado.Location = New System.Drawing.Point(12, 20)
        Me.radiobutDesglosado.Name = "radiobutDesglosado"
        Me.radiobutDesglosado.Size = New System.Drawing.Size(81, 17)
        Me.radiobutDesglosado.TabIndex = 0
        Me.radiobutDesglosado.TabStop = True
        Me.radiobutDesglosado.Text = "Desglosado"
        Me.radiobutDesglosado.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.c1numAnioFinal)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(267, 44)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resumen"
        '
        'c1numAnioFinal
        '
        Me.c1numAnioFinal.AutoSize = False
        Me.c1numAnioFinal.DataType = GetType(Short)
        Me.c1numAnioFinal.Location = New System.Drawing.Point(47, 18)
        Me.c1numAnioFinal.Name = "c1numAnioFinal"
        Me.c1numAnioFinal.Size = New System.Drawing.Size(44, 20)
        Me.c1numAnioFinal.TabIndex = 7
        Me.c1numAnioFinal.Tag = Nothing
        Me.c1numAnioFinal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Año:"
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLVacacionesResumen"
        Me.PrincipalBindingSource.DataSource = Me.PLVacResumenDataSet
        '
        'PLVacResumenDataSet
        '
        Me.PLVacResumenDataSet.DataSetName = "PLVacResumenDataSet"
        Me.PLVacResumenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLVacacionesResumenTableAdapter
        '
        Me.PLVacacionesResumenTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radiobutEmpleadosRetirados)
        Me.GroupBox3.Controls.Add(Me.radiobutEmpleadosActivos)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 95)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(267, 51)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listar"
        '
        'radiobutEmpleadosRetirados
        '
        Me.radiobutEmpleadosRetirados.AutoSize = True
        Me.radiobutEmpleadosRetirados.Location = New System.Drawing.Point(134, 20)
        Me.radiobutEmpleadosRetirados.Name = "radiobutEmpleadosRetirados"
        Me.radiobutEmpleadosRetirados.Size = New System.Drawing.Size(125, 17)
        Me.radiobutEmpleadosRetirados.TabIndex = 1
        Me.radiobutEmpleadosRetirados.TabStop = True
        Me.radiobutEmpleadosRetirados.Text = "Empleados Retirados"
        Me.radiobutEmpleadosRetirados.UseVisualStyleBackColor = True
        '
        'radiobutEmpleadosActivos
        '
        Me.radiobutEmpleadosActivos.AutoSize = True
        Me.radiobutEmpleadosActivos.Checked = True
        Me.radiobutEmpleadosActivos.Location = New System.Drawing.Point(12, 20)
        Me.radiobutEmpleadosActivos.Name = "radiobutEmpleadosActivos"
        Me.radiobutEmpleadosActivos.Size = New System.Drawing.Size(115, 17)
        Me.radiobutEmpleadosActivos.TabIndex = 0
        Me.radiobutEmpleadosActivos.TabStop = True
        Me.radiobutEmpleadosActivos.Text = "Empleados Activos"
        Me.radiobutEmpleadosActivos.UseVisualStyleBackColor = True
        '
        'PLRepVacacionesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 249)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.c1dateFecha)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PLRepVacacionesFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Vacaciones"
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.c1numAnioFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLVacResumenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents c1dateFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radiobutResumen As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutDesglosado As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents c1numAnioFinal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLVacResumenDataSet As RSIContab.PLVacResumenDataSet
    Friend WithEvents PLVacacionesResumenTableAdapter As RSIContab.PLVacResumenDataSetTableAdapters.PLVacacionesResumenTableAdapter
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radiobutEmpleadosRetirados As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutEmpleadosActivos As System.Windows.Forms.RadioButton
End Class
