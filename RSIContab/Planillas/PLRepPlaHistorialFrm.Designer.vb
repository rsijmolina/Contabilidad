<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLRepPlaHistorialFrm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.c1dateFecha = New C1.Win.C1Input.C1DateEdit()
        Me.c1txtEmpleadoIni = New C1.Win.C1Input.C1TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.c1txtEmpleadoFin = New C1.Win.C1Input.C1TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNombreIni = New System.Windows.Forms.Label()
        Me.lblNombreFin = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.c1numAñoIni = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numAñoFin = New C1.Win.C1Input.C1NumericEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radiobutHorasExtras = New System.Windows.Forms.RadioButton()
        Me.radiobutBonos = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.radiobutTotalizarSueldoNeto = New System.Windows.Forms.RadioButton()
        Me.radiobutTotSueldoNormal = New System.Windows.Forms.RadioButton()
        Me.chkExportarHistorial = New System.Windows.Forms.CheckBox()
        Me.c1numAñoExportar = New C1.Win.C1Input.C1NumericEdit()
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLExportarHistorialDataSet = New RSIContab.PLExportarHistorialDataSet()
        Me.PLPlanillasTableAdapter = New RSIContab.PLExportarHistorialDataSetTableAdapters.PLPlanillasTableAdapter()
        Me.PlanillasOTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLPlanillasOTTableAdapter = New RSIContab.PLExportarHistorialDataSetTableAdapters.PLPlanillasOTTableAdapter()
        Me.PLActHistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLActualizarOtrasDedDataSet = New RSIContab.PLActualizarOtrasDedDataSet()
        Me.PLPlanillasTableAdapter1 = New RSIContab.PLActualizarOtrasDedDataSetTableAdapters.PLPlanillasTableAdapter()
        Me.PLActHistOtrasDedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLPlanillasOTTableAdapter1 = New RSIContab.PLActualizarOtrasDedDataSetTableAdapters.PLPlanillasOTTableAdapter()
        Me.btnBuscarEmpleadoFin = New RSIContab.BotonBuscar()
        Me.btnBuscarEmpleadoIni = New RSIContab.BotonBuscar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radiobutSalidaAbrirExcel = New System.Windows.Forms.RadioButton()
        Me.radiobutSalidaGuardarExcel = New System.Windows.Forms.RadioButton()
        Me.SaveFileDialogExcel = New System.Windows.Forms.SaveFileDialog()
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtEmpleadoIni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtEmpleadoFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numAñoIni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numAñoFin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1numAñoExportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLExportarHistorialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillasOTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLActHistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLActualizarOtrasDedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLActHistOtrasDedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Fecha del Reporte:"
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
        Me.c1dateFecha.Location = New System.Drawing.Point(159, 12)
        Me.c1dateFecha.Name = "c1dateFecha"
        Me.c1dateFecha.Size = New System.Drawing.Size(105, 20)
        Me.c1dateFecha.TabIndex = 0
        Me.c1dateFecha.Tag = "CM"
        Me.c1dateFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'c1txtEmpleadoIni
        '
        Me.c1txtEmpleadoIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtEmpleadoIni.Location = New System.Drawing.Point(52, 62)
        Me.c1txtEmpleadoIni.Name = "c1txtEmpleadoIni"
        Me.c1txtEmpleadoIni.Size = New System.Drawing.Size(107, 20)
        Me.c1txtEmpleadoIni.TabIndex = 1
        Me.c1txtEmpleadoIni.Tag = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Empleado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Año Inicial:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Inicial:"
        '
        'c1txtEmpleadoFin
        '
        Me.c1txtEmpleadoFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtEmpleadoFin.Location = New System.Drawing.Point(52, 88)
        Me.c1txtEmpleadoFin.Name = "c1txtEmpleadoFin"
        Me.c1txtEmpleadoFin.Size = New System.Drawing.Size(107, 20)
        Me.c1txtEmpleadoFin.TabIndex = 3
        Me.c1txtEmpleadoFin.Tag = Nothing
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Final:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(129, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Año Final:"
        '
        'lblNombreIni
        '
        Me.lblNombreIni.Location = New System.Drawing.Point(188, 65)
        Me.lblNombreIni.Name = "lblNombreIni"
        Me.lblNombreIni.Size = New System.Drawing.Size(166, 23)
        Me.lblNombreIni.TabIndex = 44
        '
        'lblNombreFin
        '
        Me.lblNombreFin.Location = New System.Drawing.Point(188, 91)
        Me.lblNombreFin.Name = "lblNombreFin"
        Me.lblNombreFin.Size = New System.Drawing.Size(166, 23)
        Me.lblNombreFin.TabIndex = 45
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(253, 326)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(101, 32)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(12, 326)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(101, 32)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'c1numAñoIni
        '
        Me.c1numAñoIni.AutoSize = False
        Me.c1numAñoIni.DataType = GetType(Short)
        Me.c1numAñoIni.Location = New System.Drawing.Point(74, 121)
        Me.c1numAñoIni.Name = "c1numAñoIni"
        Me.c1numAñoIni.Size = New System.Drawing.Size(44, 20)
        Me.c1numAñoIni.TabIndex = 5
        Me.c1numAñoIni.Tag = Nothing
        Me.c1numAñoIni.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numAñoFin
        '
        Me.c1numAñoFin.AutoSize = False
        Me.c1numAñoFin.DataType = GetType(Short)
        Me.c1numAñoFin.Location = New System.Drawing.Point(183, 121)
        Me.c1numAñoFin.Name = "c1numAñoFin"
        Me.c1numAñoFin.Size = New System.Drawing.Size(44, 20)
        Me.c1numAñoFin.TabIndex = 6
        Me.c1numAñoFin.Tag = Nothing
        Me.c1numAñoFin.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.c1numAñoExportar)
        Me.GroupBox1.Controls.Add(Me.radiobutHorasExtras)
        Me.GroupBox1.Controls.Add(Me.radiobutBonos)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.radiobutTotalizarSueldoNeto)
        Me.GroupBox1.Controls.Add(Me.radiobutTotSueldoNormal)
        Me.GroupBox1.Controls.Add(Me.chkExportarHistorial)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 164)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exportar"
        '
        'radiobutHorasExtras
        '
        Me.radiobutHorasExtras.AutoSize = True
        Me.radiobutHorasExtras.Location = New System.Drawing.Point(164, 89)
        Me.radiobutHorasExtras.Name = "radiobutHorasExtras"
        Me.radiobutHorasExtras.Size = New System.Drawing.Size(85, 17)
        Me.radiobutHorasExtras.TabIndex = 12
        Me.radiobutHorasExtras.TabStop = True
        Me.radiobutHorasExtras.Text = "Horas Extras"
        Me.radiobutHorasExtras.UseVisualStyleBackColor = True
        '
        'radiobutBonos
        '
        Me.radiobutBonos.AutoSize = True
        Me.radiobutBonos.Location = New System.Drawing.Point(164, 66)
        Me.radiobutBonos.Name = "radiobutBonos"
        Me.radiobutBonos.Size = New System.Drawing.Size(94, 17)
        Me.radiobutBonos.TabIndex = 11
        Me.radiobutBonos.TabStop = True
        Me.radiobutBonos.Text = "Bonificaciones"
        Me.radiobutBonos.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Año a Exportar:"
        '
        'radiobutTotalizarSueldoNeto
        '
        Me.radiobutTotalizarSueldoNeto.AutoSize = True
        Me.radiobutTotalizarSueldoNeto.Location = New System.Drawing.Point(13, 89)
        Me.radiobutTotalizarSueldoNeto.Name = "radiobutTotalizarSueldoNeto"
        Me.radiobutTotalizarSueldoNeto.Size = New System.Drawing.Size(145, 17)
        Me.radiobutTotalizarSueldoNeto.TabIndex = 10
        Me.radiobutTotalizarSueldoNeto.Text = "Totalizar por Sueldo Neto"
        Me.radiobutTotalizarSueldoNeto.UseVisualStyleBackColor = True
        '
        'radiobutTotSueldoNormal
        '
        Me.radiobutTotSueldoNormal.AutoSize = True
        Me.radiobutTotSueldoNormal.Checked = True
        Me.radiobutTotSueldoNormal.Location = New System.Drawing.Point(12, 66)
        Me.radiobutTotSueldoNormal.Name = "radiobutTotSueldoNormal"
        Me.radiobutTotSueldoNormal.Size = New System.Drawing.Size(137, 17)
        Me.radiobutTotSueldoNormal.TabIndex = 9
        Me.radiobutTotSueldoNormal.TabStop = True
        Me.radiobutTotSueldoNormal.Text = "Totalizar Sueldo Normal"
        Me.radiobutTotSueldoNormal.UseVisualStyleBackColor = True
        '
        'chkExportarHistorial
        '
        Me.chkExportarHistorial.AutoSize = True
        Me.chkExportarHistorial.Location = New System.Drawing.Point(13, 19)
        Me.chkExportarHistorial.Name = "chkExportarHistorial"
        Me.chkExportarHistorial.Size = New System.Drawing.Size(273, 17)
        Me.chkExportarHistorial.TabIndex = 7
        Me.chkExportarHistorial.Text = "Exportar Historial a Excel en forma columnar por mes"
        Me.chkExportarHistorial.UseVisualStyleBackColor = True
        '
        'c1numAñoExportar
        '
        Me.c1numAñoExportar.AutoSize = False
        Me.c1numAñoExportar.DataType = GetType(Short)
        Me.c1numAñoExportar.Location = New System.Drawing.Point(88, 40)
        Me.c1numAñoExportar.Name = "c1numAñoExportar"
        Me.c1numAñoExportar.Size = New System.Drawing.Size(44, 20)
        Me.c1numAñoExportar.TabIndex = 8
        Me.c1numAñoExportar.Tag = Nothing
        Me.c1numAñoExportar.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLPlanillas"
        Me.PrincipalBindingSource.DataSource = Me.PLExportarHistorialDataSet
        '
        'PLExportarHistorialDataSet
        '
        Me.PLExportarHistorialDataSet.DataSetName = "PLExportarHistorialDataSet"
        Me.PLExportarHistorialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLPlanillasTableAdapter
        '
        Me.PLPlanillasTableAdapter.ClearBeforeFill = True
        '
        'PlanillasOTBindingSource
        '
        Me.PlanillasOTBindingSource.DataMember = "PLPlanillasOT"
        Me.PlanillasOTBindingSource.DataSource = Me.PLExportarHistorialDataSet
        '
        'PLPlanillasOTTableAdapter
        '
        Me.PLPlanillasOTTableAdapter.ClearBeforeFill = True
        '
        'PLActHistBindingSource
        '
        Me.PLActHistBindingSource.DataMember = "PLPlanillas"
        Me.PLActHistBindingSource.DataSource = Me.PLActualizarOtrasDedDataSet
        '
        'PLActualizarOtrasDedDataSet
        '
        Me.PLActualizarOtrasDedDataSet.DataSetName = "PLActualizarOtrasDedDataSet"
        Me.PLActualizarOtrasDedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLPlanillasTableAdapter1
        '
        Me.PLPlanillasTableAdapter1.ClearBeforeFill = True
        '
        'PLActHistOtrasDedBindingSource
        '
        Me.PLActHistOtrasDedBindingSource.DataMember = "PLPlanillasOT"
        Me.PLActHistOtrasDedBindingSource.DataSource = Me.PLActualizarOtrasDedDataSet
        '
        'PLPlanillasOTTableAdapter1
        '
        Me.PLPlanillasOTTableAdapter1.ClearBeforeFill = True
        '
        'btnBuscarEmpleadoFin
        '
        Me.btnBuscarEmpleadoFin.ControlEnlazado = Nothing
        Me.btnBuscarEmpleadoFin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarEmpleadoFin.Enabled = False
        Me.btnBuscarEmpleadoFin.Location = New System.Drawing.Point(159, 86)
        Me.btnBuscarEmpleadoFin.Name = "btnBuscarEmpleadoFin"
        Me.btnBuscarEmpleadoFin.Size = New System.Drawing.Size(23, 23)
        Me.btnBuscarEmpleadoFin.TabIndex = 4
        '
        'btnBuscarEmpleadoIni
        '
        Me.btnBuscarEmpleadoIni.ControlEnlazado = Nothing
        Me.btnBuscarEmpleadoIni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarEmpleadoIni.Enabled = False
        Me.btnBuscarEmpleadoIni.Location = New System.Drawing.Point(159, 60)
        Me.btnBuscarEmpleadoIni.Name = "btnBuscarEmpleadoIni"
        Me.btnBuscarEmpleadoIni.Size = New System.Drawing.Size(23, 23)
        Me.btnBuscarEmpleadoIni.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radiobutSalidaGuardarExcel)
        Me.GroupBox2.Controls.Add(Me.radiobutSalidaAbrirExcel)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(212, 39)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Salida"
        '
        'radiobutSalidaAbrirExcel
        '
        Me.radiobutSalidaAbrirExcel.AutoSize = True
        Me.radiobutSalidaAbrirExcel.Checked = True
        Me.radiobutSalidaAbrirExcel.Location = New System.Drawing.Point(7, 16)
        Me.radiobutSalidaAbrirExcel.Name = "radiobutSalidaAbrirExcel"
        Me.radiobutSalidaAbrirExcel.Size = New System.Drawing.Size(75, 17)
        Me.radiobutSalidaAbrirExcel.TabIndex = 0
        Me.radiobutSalidaAbrirExcel.TabStop = True
        Me.radiobutSalidaAbrirExcel.Text = "Abrir Excel"
        Me.radiobutSalidaAbrirExcel.UseVisualStyleBackColor = True
        '
        'radiobutSalidaGuardarExcel
        '
        Me.radiobutSalidaGuardarExcel.AutoSize = True
        Me.radiobutSalidaGuardarExcel.Location = New System.Drawing.Point(88, 16)
        Me.radiobutSalidaGuardarExcel.Name = "radiobutSalidaGuardarExcel"
        Me.radiobutSalidaGuardarExcel.Size = New System.Drawing.Size(117, 17)
        Me.radiobutSalidaGuardarExcel.TabIndex = 1
        Me.radiobutSalidaGuardarExcel.TabStop = True
        Me.radiobutSalidaGuardarExcel.Text = "Guardar en Archivo"
        Me.radiobutSalidaGuardarExcel.UseVisualStyleBackColor = True
        '
        'SaveFileDialogExcel
        '
        Me.SaveFileDialogExcel.Title = "Guardar Reporte"
        '
        'PLRepPlaHistorialFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 367)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.c1numAñoFin)
        Me.Controls.Add(Me.c1numAñoIni)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblNombreFin)
        Me.Controls.Add(Me.lblNombreIni)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnBuscarEmpleadoFin)
        Me.Controls.Add(Me.c1txtEmpleadoFin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBuscarEmpleadoIni)
        Me.Controls.Add(Me.c1txtEmpleadoIni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.c1dateFecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PLRepPlaHistorialFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Historial de Planillas"
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtEmpleadoIni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtEmpleadoFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numAñoIni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numAñoFin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1numAñoExportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLExportarHistorialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillasOTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLActHistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLActualizarOtrasDedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLActHistOtrasDedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents c1dateFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents btnBuscarEmpleadoIni As RSIContab.BotonBuscar
    Friend WithEvents c1txtEmpleadoIni As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarEmpleadoFin As RSIContab.BotonBuscar
    Friend WithEvents c1txtEmpleadoFin As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblNombreIni As System.Windows.Forms.Label
    Friend WithEvents lblNombreFin As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents c1numAñoIni As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numAñoFin As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radiobutTotalizarSueldoNeto As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutTotSueldoNormal As System.Windows.Forms.RadioButton
    Friend WithEvents chkExportarHistorial As System.Windows.Forms.CheckBox
    Friend WithEvents c1numAñoExportar As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLExportarHistorialDataSet As RSIContab.PLExportarHistorialDataSet
    Friend WithEvents PLPlanillasTableAdapter As RSIContab.PLExportarHistorialDataSetTableAdapters.PLPlanillasTableAdapter
    Friend WithEvents PlanillasOTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLPlanillasOTTableAdapter As RSIContab.PLExportarHistorialDataSetTableAdapters.PLPlanillasOTTableAdapter
    Friend WithEvents PLActHistBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLActualizarOtrasDedDataSet As RSIContab.PLActualizarOtrasDedDataSet
    Friend WithEvents PLPlanillasTableAdapter1 As RSIContab.PLActualizarOtrasDedDataSetTableAdapters.PLPlanillasTableAdapter
    Friend WithEvents PLActHistOtrasDedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLPlanillasOTTableAdapter1 As RSIContab.PLActualizarOtrasDedDataSetTableAdapters.PLPlanillasOTTableAdapter
    Friend WithEvents radiobutBonos As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutHorasExtras As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radiobutSalidaGuardarExcel As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutSalidaAbrirExcel As System.Windows.Forms.RadioButton
    Friend WithEvents SaveFileDialogExcel As System.Windows.Forms.SaveFileDialog
End Class
