<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLPrestacionesFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PLPrestacionesFrm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.c1dateFechaIngreso = New C1.Win.C1Input.C1DateEdit
        Me.c1dateFechaRetiro = New C1.Win.C1Input.C1DateEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblNombreEmpleado = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnBuscarEmpleado = New RSIContab.BotonBuscar
        Me.c1txtCodigoEmpleado = New C1.Win.C1Input.C1TextBox
        Me.toolstripPrestaciones = New System.Windows.Forms.ToolStrip
        Me.toolstripbutNuevo = New System.Windows.Forms.ToolStripButton
        Me.toolstripbutEliminar = New System.Windows.Forms.ToolStripButton
        Me.toolstripbutGuardar = New System.Windows.Forms.ToolStripButton
        Me.toolstripbutCalcular = New System.Windows.Forms.ToolStripButton
        Me.toolstripbutImprimir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.toolstripbutSalir = New System.Windows.Forms.ToolStripButton
        Me.Label29 = New System.Windows.Forms.Label
        Me.c1txtObservaciones = New C1.Win.C1Input.C1TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.lblTotalSueldoNormal = New System.Windows.Forms.Label
        Me.lblTotalBonificaciones = New System.Windows.Forms.Label
        Me.lblTotalHorasExtras = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.c1truedbgrdPlanillas = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.PLPrestacionesPlanillaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLPrestacionesDataSet = New RSIContab.PLPrestacionesDataSet
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.c1numDiasLaborados = New C1.Win.C1Input.C1NumericEdit
        Me.c1numMesesLaborados = New C1.Win.C1Input.C1NumericEdit
        Me.c1numAñosLaborados = New C1.Win.C1Input.C1NumericEdit
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.c1numDiasPropVacaciones = New C1.Win.C1Input.C1NumericEdit
        Me.c1numDiasProp13vo = New C1.Win.C1Input.C1NumericEdit
        Me.c1numDiasProp14vo = New C1.Win.C1Input.C1NumericEdit
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.c1numSalarioPromedioDiario = New C1.Win.C1Input.C1NumericEdit
        Me.c1numSalarioPromedio = New C1.Win.C1Input.C1NumericEdit
        Me.c1numHorasExtras = New C1.Win.C1Input.C1NumericEdit
        Me.c1numSueldoOrdinarioDiario = New C1.Win.C1Input.C1NumericEdit
        Me.c1numSueldoBaseOrdinario = New C1.Win.C1Input.C1NumericEdit
        Me.c1numSueldoBaseDiario = New C1.Win.C1Input.C1NumericEdit
        Me.c1numSueldoBaseMensual = New C1.Win.C1Input.C1NumericEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.lblTotalPrestaciones = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.c1truedbgrdDedPendientes = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.PLPrestacionesDeduccionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.c1txtDescVacAñosAnt = New C1.Win.C1Input.C1TextBox
        Me.c1numImpuestoVecinal = New C1.Win.C1Input.C1NumericEdit
        Me.c1numRAP = New C1.Win.C1Input.C1NumericEdit
        Me.c1numSeguroSocial = New C1.Win.C1Input.C1NumericEdit
        Me.c1numDiasPendientes = New C1.Win.C1Input.C1NumericEdit
        Me.c1numVacacionesAñosAnteriores = New C1.Win.C1Input.C1NumericEdit
        Me.c1numVacacionesProporcionales = New C1.Win.C1Input.C1NumericEdit
        Me.c1num13voProporcional = New C1.Win.C1Input.C1NumericEdit
        Me.c1num14voProporcional = New C1.Win.C1Input.C1NumericEdit
        Me.c1numCesantiaProporcional = New C1.Win.C1Input.C1NumericEdit
        Me.c1numCesantia = New C1.Win.C1Input.C1NumericEdit
        Me.c1numPreaviso = New C1.Win.C1Input.C1NumericEdit
        Me.Label34 = New System.Windows.Forms.Label
        Me.c1txtElaboradoPor = New C1.Win.C1Input.C1TextBox
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLPrestacionesTableAdapter = New RSIContab.PLPrestacionesDataSetTableAdapters.PLPrestacionesTableAdapter
        Me.PLPrestacionesDeduccionesTableAdapter = New RSIContab.PLPrestacionesDataSetTableAdapters.PLPrestacionesDeduccionesTableAdapter
        Me.PLPrestacionesPlanillasTableAdapter = New RSIContab.PLPrestacionesDataSetTableAdapters.PLPrestacionesPlanillasTableAdapter
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.radiobutTodo = New System.Windows.Forms.RadioButton
        Me.radiobutDerechosCesantia = New System.Windows.Forms.RadioButton
        Me.radiobutDerechos = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1dateFechaIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1dateFechaRetiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtCodigoEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripPrestaciones.SuspendLayout()
        CType(Me.c1txtObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.c1truedbgrdPlanillas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLPrestacionesPlanillaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLPrestacionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.c1numDiasLaborados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numMesesLaborados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numAñosLaborados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numDiasPropVacaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numDiasProp13vo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numDiasProp14vo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.c1numSalarioPromedioDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSalarioPromedio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numHorasExtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSueldoOrdinarioDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSueldoBaseOrdinario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSueldoBaseDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSueldoBaseMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.c1truedbgrdDedPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLPrestacionesDeduccionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtDescVacAñosAnt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numImpuestoVecinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSeguroSocial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numDiasPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numVacacionesAñosAnteriores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numVacacionesProporcionales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1num13voProporcional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1num14voProporcional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numCesantiaProporcional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numCesantia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numPreaviso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtElaboradoPor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.c1dateFechaIngreso)
        Me.GroupBox1.Controls.Add(Me.c1dateFechaRetiro)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblNombreEmpleado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnBuscarEmpleado)
        Me.GroupBox1.Controls.Add(Me.c1txtCodigoEmpleado)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 36)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'c1dateFechaIngreso
        '
        Me.c1dateFechaIngreso.DateTimeInput = False
        Me.c1dateFechaIngreso.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.c1dateFechaIngreso.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1dateFechaIngreso.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.c1dateFechaIngreso.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1dateFechaIngreso.Location = New System.Drawing.Point(513, 10)
        Me.c1dateFechaIngreso.Name = "c1dateFechaIngreso"
        Me.c1dateFechaIngreso.Size = New System.Drawing.Size(91, 20)
        Me.c1dateFechaIngreso.TabIndex = 2
        Me.c1dateFechaIngreso.Tag = "CM"
        Me.c1dateFechaIngreso.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'c1dateFechaRetiro
        '
        Me.c1dateFechaRetiro.DateTimeInput = False
        Me.c1dateFechaRetiro.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.c1dateFechaRetiro.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1dateFechaRetiro.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.c1dateFechaRetiro.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1dateFechaRetiro.Location = New System.Drawing.Point(702, 9)
        Me.c1dateFechaRetiro.Name = "c1dateFechaRetiro"
        Me.c1dateFechaRetiro.Size = New System.Drawing.Size(94, 20)
        Me.c1dateFechaRetiro.TabIndex = 3
        Me.c1dateFechaRetiro.Tag = "CM"
        Me.c1dateFechaRetiro.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(610, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Fecha de Retiro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(422, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Fecha de Ingreso:"
        '
        'lblNombreEmpleado
        '
        Me.lblNombreEmpleado.AutoSize = True
        Me.lblNombreEmpleado.Location = New System.Drawing.Point(201, 13)
        Me.lblNombreEmpleado.Name = "lblNombreEmpleado"
        Me.lblNombreEmpleado.Size = New System.Drawing.Size(39, 13)
        Me.lblNombreEmpleado.TabIndex = 34
        Me.lblNombreEmpleado.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Empleado:"
        '
        'btnBuscarEmpleado
        '
        Me.btnBuscarEmpleado.ControlEnlazado = Nothing
        Me.btnBuscarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarEmpleado.Enabled = False
        Me.btnBuscarEmpleado.Location = New System.Drawing.Point(172, 8)
        Me.btnBuscarEmpleado.Name = "btnBuscarEmpleado"
        Me.btnBuscarEmpleado.Size = New System.Drawing.Size(23, 23)
        Me.btnBuscarEmpleado.TabIndex = 32
        '
        'c1txtCodigoEmpleado
        '
        Me.c1txtCodigoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtCodigoEmpleado.Location = New System.Drawing.Point(70, 10)
        Me.c1txtCodigoEmpleado.Name = "c1txtCodigoEmpleado"
        Me.c1txtCodigoEmpleado.Size = New System.Drawing.Size(102, 20)
        Me.c1txtCodigoEmpleado.TabIndex = 1
        Me.c1txtCodigoEmpleado.Tag = Nothing
        '
        'toolstripPrestaciones
        '
        Me.toolstripPrestaciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripbutNuevo, Me.toolstripbutEliminar, Me.toolstripbutGuardar, Me.toolstripbutCalcular, Me.toolstripbutImprimir, Me.ToolStripSeparator1, Me.toolstripbutSalir})
        Me.toolstripPrestaciones.Location = New System.Drawing.Point(0, 0)
        Me.toolstripPrestaciones.Name = "toolstripPrestaciones"
        Me.toolstripPrestaciones.Size = New System.Drawing.Size(816, 25)
        Me.toolstripPrestaciones.TabIndex = 3
        Me.toolstripPrestaciones.Text = "ToolStrip1"
        '
        'toolstripbutNuevo
        '
        Me.toolstripbutNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutNuevo.Enabled = False
        Me.toolstripbutNuevo.Image = Global.RSIContab.My.Resources.Resources.DocumentHS
        Me.toolstripbutNuevo.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutNuevo.Name = "toolstripbutNuevo"
        Me.toolstripbutNuevo.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutNuevo.Text = "Nuevo Cálculo"
        '
        'toolstripbutEliminar
        '
        Me.toolstripbutEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutEliminar.Enabled = False
        Me.toolstripbutEliminar.Image = Global.RSIContab.My.Resources.Resources.DeleteHS
        Me.toolstripbutEliminar.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutEliminar.Name = "toolstripbutEliminar"
        Me.toolstripbutEliminar.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutEliminar.Text = "Eliminar Cálculo"
        '
        'toolstripbutGuardar
        '
        Me.toolstripbutGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutGuardar.Enabled = False
        Me.toolstripbutGuardar.Image = Global.RSIContab.My.Resources.Resources.saveHS
        Me.toolstripbutGuardar.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutGuardar.Name = "toolstripbutGuardar"
        Me.toolstripbutGuardar.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutGuardar.Text = "Guardar Cálculo"
        '
        'toolstripbutCalcular
        '
        Me.toolstripbutCalcular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutCalcular.Enabled = False
        Me.toolstripbutCalcular.Image = Global.RSIContab.My.Resources.Resources.gear_32
        Me.toolstripbutCalcular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripbutCalcular.Name = "toolstripbutCalcular"
        Me.toolstripbutCalcular.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutCalcular.Text = "Calcular"
        '
        'toolstripbutImprimir
        '
        Me.toolstripbutImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutImprimir.Enabled = False
        Me.toolstripbutImprimir.Image = Global.RSIContab.My.Resources.Resources.PrintHS
        Me.toolstripbutImprimir.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutImprimir.Name = "toolstripbutImprimir"
        Me.toolstripbutImprimir.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutImprimir.Text = "Imprimir Datos de Prestaciones"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'toolstripbutSalir
        '
        Me.toolstripbutSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutSalir.Image = Global.RSIContab.My.Resources.Resources.CriticalError
        Me.toolstripbutSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripbutSalir.Name = "toolstripbutSalir"
        Me.toolstripbutSalir.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutSalir.Text = "Salir"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(442, 495)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(81, 13)
        Me.Label29.TabIndex = 36
        Me.Label29.Text = "Observaciones:"
        '
        'c1txtObservaciones
        '
        Me.c1txtObservaciones.Location = New System.Drawing.Point(443, 511)
        Me.c1txtObservaciones.MaxLength = 200
        Me.c1txtObservaciones.Multiline = True
        Me.c1txtObservaciones.Name = "c1txtObservaciones"
        Me.c1txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.c1txtObservaciones.Size = New System.Drawing.Size(361, 52)
        Me.c1txtObservaciones.TabIndex = 31
        Me.c1txtObservaciones.Tag = Nothing
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblTotalSueldoNormal)
        Me.GroupBox6.Controls.Add(Me.lblTotalBonificaciones)
        Me.GroupBox6.Controls.Add(Me.lblTotalHorasExtras)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Location = New System.Drawing.Point(443, 457)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(365, 35)
        Me.GroupBox6.TabIndex = 34
        Me.GroupBox6.TabStop = False
        '
        'lblTotalSueldoNormal
        '
        Me.lblTotalSueldoNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSueldoNormal.Location = New System.Drawing.Point(265, 16)
        Me.lblTotalSueldoNormal.Name = "lblTotalSueldoNormal"
        Me.lblTotalSueldoNormal.Size = New System.Drawing.Size(69, 11)
        Me.lblTotalSueldoNormal.TabIndex = 4
        Me.lblTotalSueldoNormal.Text = "0.00"
        Me.lblTotalSueldoNormal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalBonificaciones
        '
        Me.lblTotalBonificaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBonificaciones.Location = New System.Drawing.Point(196, 16)
        Me.lblTotalBonificaciones.Name = "lblTotalBonificaciones"
        Me.lblTotalBonificaciones.Size = New System.Drawing.Size(60, 12)
        Me.lblTotalBonificaciones.TabIndex = 2
        Me.lblTotalBonificaciones.Text = "0.00"
        Me.lblTotalBonificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalHorasExtras
        '
        Me.lblTotalHorasExtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalHorasExtras.Location = New System.Drawing.Point(134, 16)
        Me.lblTotalHorasExtras.Name = "lblTotalHorasExtras"
        Me.lblTotalHorasExtras.Size = New System.Drawing.Size(54, 13)
        Me.lblTotalHorasExtras.TabIndex = 1
        Me.lblTotalHorasExtras.Text = "0.00"
        Me.lblTotalHorasExtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Totales:"
        '
        'c1truedbgrdPlanillas
        '
        Me.c1truedbgrdPlanillas.AllowAddNew = True
        Me.c1truedbgrdPlanillas.AllowDelete = True
        Me.c1truedbgrdPlanillas.Caption = "Ultimos Sueldos"
        Me.c1truedbgrdPlanillas.DataSource = Me.PLPrestacionesPlanillaBindingSource
        Me.c1truedbgrdPlanillas.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1truedbgrdPlanillas.Images.Add(CType(resources.GetObject("c1truedbgrdPlanillas.Images"), System.Drawing.Image))
        Me.c1truedbgrdPlanillas.Location = New System.Drawing.Point(443, 216)
        Me.c1truedbgrdPlanillas.Name = "c1truedbgrdPlanillas"
        Me.c1truedbgrdPlanillas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1truedbgrdPlanillas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1truedbgrdPlanillas.PreviewInfo.ZoomFactor = 75
        Me.c1truedbgrdPlanillas.PrintInfo.PageSettings = CType(resources.GetObject("c1truedbgrdPlanillas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1truedbgrdPlanillas.Size = New System.Drawing.Size(365, 240)
        Me.c1truedbgrdPlanillas.TabIndex = 30
        Me.c1truedbgrdPlanillas.Text = "C1TrueDBGrid1"
        Me.c1truedbgrdPlanillas.PropBag = resources.GetString("c1truedbgrdPlanillas.PropBag")
        '
        'PLPrestacionesPlanillaBindingSource
        '
        Me.PLPrestacionesPlanillaBindingSource.DataMember = "PLPrestacionesPlanillas"
        Me.PLPrestacionesPlanillaBindingSource.DataSource = Me.PLPrestacionesDataSet
        '
        'PLPrestacionesDataSet
        '
        Me.PLPrestacionesDataSet.DataSetName = "PLPrestacionesDataSet"
        Me.PLPrestacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.c1numDiasLaborados)
        Me.GroupBox4.Controls.Add(Me.c1numMesesLaborados)
        Me.GroupBox4.Controls.Add(Me.c1numAñosLaborados)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.c1numDiasPropVacaciones)
        Me.GroupBox4.Controls.Add(Me.c1numDiasProp13vo)
        Me.GroupBox4.Controls.Add(Me.c1numDiasProp14vo)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(443, 110)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(365, 100)
        Me.GroupBox4.TabIndex = 32
        Me.GroupBox4.TabStop = False
        '
        'c1numDiasLaborados
        '
        Me.c1numDiasLaborados.DisplayFormat.CustomFormat = "##0"
        Me.c1numDiasLaborados.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numDiasLaborados.Location = New System.Drawing.Point(287, 77)
        Me.c1numDiasLaborados.Name = "c1numDiasLaborados"
        Me.c1numDiasLaborados.Size = New System.Drawing.Size(36, 20)
        Me.c1numDiasLaborados.TabIndex = 29
        Me.c1numDiasLaborados.Tag = Nothing
        Me.c1numDiasLaborados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numDiasLaborados.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numMesesLaborados
        '
        Me.c1numMesesLaborados.DisplayFormat.CustomFormat = "##0"
        Me.c1numMesesLaborados.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numMesesLaborados.Location = New System.Drawing.Point(287, 54)
        Me.c1numMesesLaborados.Name = "c1numMesesLaborados"
        Me.c1numMesesLaborados.Size = New System.Drawing.Size(36, 20)
        Me.c1numMesesLaborados.TabIndex = 28
        Me.c1numMesesLaborados.Tag = Nothing
        Me.c1numMesesLaborados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numMesesLaborados.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numAñosLaborados
        '
        Me.c1numAñosLaborados.DisplayFormat.CustomFormat = "##0"
        Me.c1numAñosLaborados.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numAñosLaborados.Location = New System.Drawing.Point(287, 31)
        Me.c1numAñosLaborados.Name = "c1numAñosLaborados"
        Me.c1numAñosLaborados.Size = New System.Drawing.Size(36, 20)
        Me.c1numAñosLaborados.TabIndex = 27
        Me.c1numAñosLaborados.Tag = Nothing
        Me.c1numAñosLaborados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numAñosLaborados.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(248, 80)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(33, 13)
        Me.Label33.TabIndex = 28
        Me.Label33.Text = "Días:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(247, 57)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(41, 13)
        Me.Label32.TabIndex = 27
        Me.Label32.Text = "Meses:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(247, 36)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(34, 13)
        Me.Label31.TabIndex = 26
        Me.Label31.Text = "Años:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(247, 13)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(90, 13)
        Me.Label30.TabIndex = 25
        Me.Label30.Text = "Tiempo Laborado"
        '
        'c1numDiasPropVacaciones
        '
        Me.c1numDiasPropVacaciones.DisplayFormat.CustomFormat = "##0"
        Me.c1numDiasPropVacaciones.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numDiasPropVacaciones.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numDiasPropVacaciones.Location = New System.Drawing.Point(152, 77)
        Me.c1numDiasPropVacaciones.Name = "c1numDiasPropVacaciones"
        Me.c1numDiasPropVacaciones.Size = New System.Drawing.Size(34, 20)
        Me.c1numDiasPropVacaciones.TabIndex = 26
        Me.c1numDiasPropVacaciones.Tag = Nothing
        Me.c1numDiasPropVacaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numDiasPropVacaciones.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numDiasProp13vo
        '
        Me.c1numDiasProp13vo.DisplayFormat.CustomFormat = "##0"
        Me.c1numDiasProp13vo.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numDiasProp13vo.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numDiasProp13vo.Location = New System.Drawing.Point(152, 54)
        Me.c1numDiasProp13vo.Name = "c1numDiasProp13vo"
        Me.c1numDiasProp13vo.Size = New System.Drawing.Size(34, 20)
        Me.c1numDiasProp13vo.TabIndex = 25
        Me.c1numDiasProp13vo.Tag = Nothing
        Me.c1numDiasProp13vo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numDiasProp13vo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numDiasProp14vo
        '
        Me.c1numDiasProp14vo.DisplayFormat.CustomFormat = "##0"
        Me.c1numDiasProp14vo.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numDiasProp14vo.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numDiasProp14vo.Location = New System.Drawing.Point(152, 32)
        Me.c1numDiasProp14vo.Name = "c1numDiasProp14vo"
        Me.c1numDiasProp14vo.Size = New System.Drawing.Size(34, 20)
        Me.c1numDiasProp14vo.TabIndex = 24
        Me.c1numDiasProp14vo.Tag = Nothing
        Me.c1numDiasProp14vo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numDiasProp14vo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(156, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(30, 13)
        Me.Label28.TabIndex = 3
        Me.Label28.Text = "Días"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(135, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Proporción de Vacaciones:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Proporción 13vo:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Proporción 14vo:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.c1numSalarioPromedioDiario)
        Me.GroupBox5.Controls.Add(Me.c1numSalarioPromedio)
        Me.GroupBox5.Controls.Add(Me.c1numHorasExtras)
        Me.GroupBox5.Controls.Add(Me.c1numSueldoOrdinarioDiario)
        Me.GroupBox5.Controls.Add(Me.c1numSueldoBaseOrdinario)
        Me.GroupBox5.Controls.Add(Me.c1numSueldoBaseDiario)
        Me.GroupBox5.Controls.Add(Me.c1numSueldoBaseMensual)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 69)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(425, 107)
        Me.GroupBox5.TabIndex = 31
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Cálculo de Salarios"
        '
        'c1numSalarioPromedioDiario
        '
        Me.c1numSalarioPromedioDiario.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numSalarioPromedioDiario.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numSalarioPromedioDiario.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numSalarioPromedioDiario.Location = New System.Drawing.Point(342, 57)
        Me.c1numSalarioPromedioDiario.Name = "c1numSalarioPromedioDiario"
        Me.c1numSalarioPromedioDiario.Size = New System.Drawing.Size(77, 20)
        Me.c1numSalarioPromedioDiario.TabIndex = 10
        Me.c1numSalarioPromedioDiario.Tag = Nothing
        Me.c1numSalarioPromedioDiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSalarioPromedioDiario.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numSalarioPromedio
        '
        Me.c1numSalarioPromedio.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numSalarioPromedio.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numSalarioPromedio.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numSalarioPromedio.Location = New System.Drawing.Point(342, 35)
        Me.c1numSalarioPromedio.Name = "c1numSalarioPromedio"
        Me.c1numSalarioPromedio.Size = New System.Drawing.Size(77, 20)
        Me.c1numSalarioPromedio.TabIndex = 9
        Me.c1numSalarioPromedio.Tag = Nothing
        Me.c1numSalarioPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSalarioPromedio.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numHorasExtras
        '
        Me.c1numHorasExtras.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numHorasExtras.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numHorasExtras.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numHorasExtras.Location = New System.Drawing.Point(342, 13)
        Me.c1numHorasExtras.Name = "c1numHorasExtras"
        Me.c1numHorasExtras.Size = New System.Drawing.Size(77, 20)
        Me.c1numHorasExtras.TabIndex = 8
        Me.c1numHorasExtras.Tag = Nothing
        Me.c1numHorasExtras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numHorasExtras.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numSueldoOrdinarioDiario
        '
        Me.c1numSueldoOrdinarioDiario.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numSueldoOrdinarioDiario.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numSueldoOrdinarioDiario.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numSueldoOrdinarioDiario.Location = New System.Drawing.Point(126, 80)
        Me.c1numSueldoOrdinarioDiario.Name = "c1numSueldoOrdinarioDiario"
        Me.c1numSueldoOrdinarioDiario.Size = New System.Drawing.Size(77, 20)
        Me.c1numSueldoOrdinarioDiario.TabIndex = 7
        Me.c1numSueldoOrdinarioDiario.Tag = Nothing
        Me.c1numSueldoOrdinarioDiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSueldoOrdinarioDiario.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numSueldoBaseOrdinario
        '
        Me.c1numSueldoBaseOrdinario.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numSueldoBaseOrdinario.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numSueldoBaseOrdinario.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numSueldoBaseOrdinario.Location = New System.Drawing.Point(126, 57)
        Me.c1numSueldoBaseOrdinario.Name = "c1numSueldoBaseOrdinario"
        Me.c1numSueldoBaseOrdinario.Size = New System.Drawing.Size(77, 20)
        Me.c1numSueldoBaseOrdinario.TabIndex = 6
        Me.c1numSueldoBaseOrdinario.Tag = Nothing
        Me.c1numSueldoBaseOrdinario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSueldoBaseOrdinario.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numSueldoBaseDiario
        '
        Me.c1numSueldoBaseDiario.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numSueldoBaseDiario.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numSueldoBaseDiario.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numSueldoBaseDiario.Location = New System.Drawing.Point(126, 35)
        Me.c1numSueldoBaseDiario.Name = "c1numSueldoBaseDiario"
        Me.c1numSueldoBaseDiario.Size = New System.Drawing.Size(77, 20)
        Me.c1numSueldoBaseDiario.TabIndex = 5
        Me.c1numSueldoBaseDiario.Tag = Nothing
        Me.c1numSueldoBaseDiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSueldoBaseDiario.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numSueldoBaseMensual
        '
        Me.c1numSueldoBaseMensual.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numSueldoBaseMensual.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numSueldoBaseMensual.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numSueldoBaseMensual.Location = New System.Drawing.Point(126, 13)
        Me.c1numSueldoBaseMensual.Name = "c1numSueldoBaseMensual"
        Me.c1numSueldoBaseMensual.Size = New System.Drawing.Size(77, 20)
        Me.c1numSueldoBaseMensual.TabIndex = 4
        Me.c1numSueldoBaseMensual.Tag = Nothing
        Me.c1numSueldoBaseMensual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSueldoBaseMensual.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(220, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Salario Promedio Diario:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(220, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Salario Promedio:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(220, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Horas Extras:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Sueldo Ordinario Diario:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Sueldo Base Ordinario:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Sueldo Base Diario:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sueldo Base Mensual:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Preaviso:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(5, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(101, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Auxilio de Cesantía:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(5, 57)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(163, 13)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Auxilio de Cesantía Proporcional:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(5, 79)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(122, 13)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "14vo. Mes Proporcional:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 101)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(122, 13)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "13vo. Mes Proporcional:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(5, 123)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(139, 13)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Vacaciones Proporcionales:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(5, 146)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(199, 13)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "Total de Prestaciones y Derechos"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(7, 165)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(143, 13)
        Me.Label23.TabIndex = 11
        Me.Label23.Text = "Vacaciones Años Anteriores:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(7, 185)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(89, 13)
        Me.Label24.TabIndex = 12
        Me.Label24.Text = "Días Pendientes:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(7, 208)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(76, 13)
        Me.Label25.TabIndex = 13
        Me.Label25.Text = "Seguro Social:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(7, 231)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(32, 13)
        Me.Label26.TabIndex = 14
        Me.Label26.Text = "RAP:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(7, 254)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(91, 13)
        Me.Label27.TabIndex = 15
        Me.Label27.Text = "Impuesto Vecinal:"
        '
        'lblTotalPrestaciones
        '
        Me.lblTotalPrestaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrestaciones.Location = New System.Drawing.Point(313, 146)
        Me.lblTotalPrestaciones.Name = "lblTotalPrestaciones"
        Me.lblTotalPrestaciones.Size = New System.Drawing.Size(77, 16)
        Me.lblTotalPrestaciones.TabIndex = 30
        Me.lblTotalPrestaciones.Text = "0.00"
        Me.lblTotalPrestaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(205, 387)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Total a Cancelar:"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(316, 388)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(77, 16)
        Me.lblTotal.TabIndex = 32
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.c1truedbgrdDedPendientes)
        Me.GroupBox3.Controls.Add(Me.c1txtDescVacAñosAnt)
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.lblTotalPrestaciones)
        Me.GroupBox3.Controls.Add(Me.c1numImpuestoVecinal)
        Me.GroupBox3.Controls.Add(Me.c1numRAP)
        Me.GroupBox3.Controls.Add(Me.c1numSeguroSocial)
        Me.GroupBox3.Controls.Add(Me.c1numDiasPendientes)
        Me.GroupBox3.Controls.Add(Me.c1numVacacionesAñosAnteriores)
        Me.GroupBox3.Controls.Add(Me.c1numVacacionesProporcionales)
        Me.GroupBox3.Controls.Add(Me.c1num13voProporcional)
        Me.GroupBox3.Controls.Add(Me.c1num14voProporcional)
        Me.GroupBox3.Controls.Add(Me.c1numCesantiaProporcional)
        Me.GroupBox3.Controls.Add(Me.c1numCesantia)
        Me.GroupBox3.Controls.Add(Me.c1numPreaviso)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 182)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(421, 406)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Prestaciones y Deducciones"
        '
        'c1truedbgrdDedPendientes
        '
        Me.c1truedbgrdDedPendientes.AllowAddNew = True
        Me.c1truedbgrdDedPendientes.AllowDelete = True
        Me.c1truedbgrdDedPendientes.DataSource = Me.PLPrestacionesDeduccionesBindingSource
        Me.c1truedbgrdDedPendientes.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1truedbgrdDedPendientes.Images.Add(CType(resources.GetObject("c1truedbgrdDedPendientes.Images"), System.Drawing.Image))
        Me.c1truedbgrdDedPendientes.Location = New System.Drawing.Point(10, 280)
        Me.c1truedbgrdDedPendientes.Name = "c1truedbgrdDedPendientes"
        Me.c1truedbgrdDedPendientes.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1truedbgrdDedPendientes.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1truedbgrdDedPendientes.PreviewInfo.ZoomFactor = 75
        Me.c1truedbgrdDedPendientes.PrintInfo.PageSettings = CType(resources.GetObject("c1truedbgrdDedPendientes.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1truedbgrdDedPendientes.Size = New System.Drawing.Size(405, 92)
        Me.c1truedbgrdDedPendientes.TabIndex = 23
        Me.c1truedbgrdDedPendientes.Text = "C1TrueDBGrid1"
        Me.c1truedbgrdDedPendientes.PropBag = resources.GetString("c1truedbgrdDedPendientes.PropBag")
        '
        'PLPrestacionesDeduccionesBindingSource
        '
        Me.PLPrestacionesDeduccionesBindingSource.DataMember = "PLPrestacionesDeducciones"
        Me.PLPrestacionesDeduccionesBindingSource.DataSource = Me.PLPrestacionesDataSet
        '
        'c1txtDescVacAñosAnt
        '
        Me.c1txtDescVacAñosAnt.Location = New System.Drawing.Point(146, 162)
        Me.c1txtDescVacAñosAnt.MaxLength = 50
        Me.c1txtDescVacAñosAnt.Name = "c1txtDescVacAñosAnt"
        Me.c1txtDescVacAñosAnt.Size = New System.Drawing.Size(164, 20)
        Me.c1txtDescVacAñosAnt.TabIndex = 17
        Me.c1txtDescVacAñosAnt.Tag = Nothing
        '
        'c1numImpuestoVecinal
        '
        Me.c1numImpuestoVecinal.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numImpuestoVecinal.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numImpuestoVecinal.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numImpuestoVecinal.Location = New System.Drawing.Point(316, 254)
        Me.c1numImpuestoVecinal.Name = "c1numImpuestoVecinal"
        Me.c1numImpuestoVecinal.Size = New System.Drawing.Size(77, 20)
        Me.c1numImpuestoVecinal.TabIndex = 22
        Me.c1numImpuestoVecinal.Tag = Nothing
        Me.c1numImpuestoVecinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numImpuestoVecinal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRAP
        '
        Me.c1numRAP.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRAP.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRAP.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRAP.Location = New System.Drawing.Point(316, 231)
        Me.c1numRAP.Name = "c1numRAP"
        Me.c1numRAP.Size = New System.Drawing.Size(77, 20)
        Me.c1numRAP.TabIndex = 21
        Me.c1numRAP.Tag = Nothing
        Me.c1numRAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRAP.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numSeguroSocial
        '
        Me.c1numSeguroSocial.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numSeguroSocial.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numSeguroSocial.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numSeguroSocial.Location = New System.Drawing.Point(316, 208)
        Me.c1numSeguroSocial.Name = "c1numSeguroSocial"
        Me.c1numSeguroSocial.Size = New System.Drawing.Size(77, 20)
        Me.c1numSeguroSocial.TabIndex = 20
        Me.c1numSeguroSocial.Tag = Nothing
        Me.c1numSeguroSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSeguroSocial.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numDiasPendientes
        '
        Me.c1numDiasPendientes.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numDiasPendientes.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numDiasPendientes.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numDiasPendientes.Location = New System.Drawing.Point(316, 185)
        Me.c1numDiasPendientes.Name = "c1numDiasPendientes"
        Me.c1numDiasPendientes.Size = New System.Drawing.Size(77, 20)
        Me.c1numDiasPendientes.TabIndex = 19
        Me.c1numDiasPendientes.Tag = Nothing
        Me.c1numDiasPendientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numDiasPendientes.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numVacacionesAñosAnteriores
        '
        Me.c1numVacacionesAñosAnteriores.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numVacacionesAñosAnteriores.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numVacacionesAñosAnteriores.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numVacacionesAñosAnteriores.Location = New System.Drawing.Point(316, 162)
        Me.c1numVacacionesAñosAnteriores.Name = "c1numVacacionesAñosAnteriores"
        Me.c1numVacacionesAñosAnteriores.Size = New System.Drawing.Size(77, 20)
        Me.c1numVacacionesAñosAnteriores.TabIndex = 18
        Me.c1numVacacionesAñosAnteriores.Tag = Nothing
        Me.c1numVacacionesAñosAnteriores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numVacacionesAñosAnteriores.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numVacacionesProporcionales
        '
        Me.c1numVacacionesProporcionales.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numVacacionesProporcionales.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numVacacionesProporcionales.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numVacacionesProporcionales.Location = New System.Drawing.Point(316, 123)
        Me.c1numVacacionesProporcionales.Name = "c1numVacacionesProporcionales"
        Me.c1numVacacionesProporcionales.Size = New System.Drawing.Size(77, 20)
        Me.c1numVacacionesProporcionales.TabIndex = 16
        Me.c1numVacacionesProporcionales.Tag = Nothing
        Me.c1numVacacionesProporcionales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numVacacionesProporcionales.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1num13voProporcional
        '
        Me.c1num13voProporcional.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1num13voProporcional.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1num13voProporcional.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1num13voProporcional.Location = New System.Drawing.Point(316, 101)
        Me.c1num13voProporcional.Name = "c1num13voProporcional"
        Me.c1num13voProporcional.Size = New System.Drawing.Size(77, 20)
        Me.c1num13voProporcional.TabIndex = 15
        Me.c1num13voProporcional.Tag = Nothing
        Me.c1num13voProporcional.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1num13voProporcional.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1num14voProporcional
        '
        Me.c1num14voProporcional.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1num14voProporcional.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1num14voProporcional.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1num14voProporcional.Location = New System.Drawing.Point(316, 79)
        Me.c1num14voProporcional.Name = "c1num14voProporcional"
        Me.c1num14voProporcional.Size = New System.Drawing.Size(77, 20)
        Me.c1num14voProporcional.TabIndex = 14
        Me.c1num14voProporcional.Tag = Nothing
        Me.c1num14voProporcional.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1num14voProporcional.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numCesantiaProporcional
        '
        Me.c1numCesantiaProporcional.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numCesantiaProporcional.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numCesantiaProporcional.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numCesantiaProporcional.Location = New System.Drawing.Point(316, 57)
        Me.c1numCesantiaProporcional.Name = "c1numCesantiaProporcional"
        Me.c1numCesantiaProporcional.Size = New System.Drawing.Size(77, 20)
        Me.c1numCesantiaProporcional.TabIndex = 13
        Me.c1numCesantiaProporcional.Tag = Nothing
        Me.c1numCesantiaProporcional.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numCesantiaProporcional.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numCesantia
        '
        Me.c1numCesantia.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numCesantia.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numCesantia.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numCesantia.Location = New System.Drawing.Point(316, 35)
        Me.c1numCesantia.Name = "c1numCesantia"
        Me.c1numCesantia.Size = New System.Drawing.Size(77, 20)
        Me.c1numCesantia.TabIndex = 12
        Me.c1numCesantia.Tag = Nothing
        Me.c1numCesantia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numCesantia.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numPreaviso
        '
        Me.c1numPreaviso.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numPreaviso.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numPreaviso.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numPreaviso.Location = New System.Drawing.Point(316, 13)
        Me.c1numPreaviso.Name = "c1numPreaviso"
        Me.c1numPreaviso.Size = New System.Drawing.Size(77, 20)
        Me.c1numPreaviso.TabIndex = 11
        Me.c1numPreaviso.Tag = Nothing
        Me.c1numPreaviso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numPreaviso.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(442, 572)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(77, 13)
        Me.Label34.TabIndex = 37
        Me.Label34.Text = "Elaborado Por:"
        '
        'c1txtElaboradoPor
        '
        Me.c1txtElaboradoPor.Location = New System.Drawing.Point(525, 569)
        Me.c1txtElaboradoPor.MaxLength = 50
        Me.c1txtElaboradoPor.Name = "c1txtElaboradoPor"
        Me.c1txtElaboradoPor.Size = New System.Drawing.Size(279, 20)
        Me.c1txtElaboradoPor.TabIndex = 32
        Me.c1txtElaboradoPor.Tag = Nothing
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLPrestaciones"
        Me.PrincipalBindingSource.DataSource = Me.PLPrestacionesDataSet
        '
        'PLPrestacionesTableAdapter
        '
        Me.PLPrestacionesTableAdapter.ClearBeforeFill = True
        '
        'PLPrestacionesDeduccionesTableAdapter
        '
        Me.PLPrestacionesDeduccionesTableAdapter.ClearBeforeFill = True
        '
        'PLPrestacionesPlanillasTableAdapter
        '
        Me.PLPrestacionesPlanillasTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radiobutTodo)
        Me.GroupBox2.Controls.Add(Me.radiobutDerechosCesantia)
        Me.GroupBox2.Controls.Add(Me.radiobutDerechos)
        Me.GroupBox2.Location = New System.Drawing.Point(445, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(363, 35)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Calcular"
        '
        'radiobutTodo
        '
        Me.radiobutTodo.AutoSize = True
        Me.radiobutTodo.Location = New System.Drawing.Point(224, 12)
        Me.radiobutTodo.Name = "radiobutTodo"
        Me.radiobutTodo.Size = New System.Drawing.Size(125, 17)
        Me.radiobutTodo.TabIndex = 2
        Me.radiobutTodo.Text = "Anteriores + Preaviso"
        Me.radiobutTodo.UseVisualStyleBackColor = True
        '
        'radiobutDerechosCesantia
        '
        Me.radiobutDerechosCesantia.AutoSize = True
        Me.radiobutDerechosCesantia.Location = New System.Drawing.Point(84, 12)
        Me.radiobutDerechosCesantia.Name = "radiobutDerechosCesantia"
        Me.radiobutDerechosCesantia.Size = New System.Drawing.Size(125, 17)
        Me.radiobutDerechosCesantia.TabIndex = 1
        Me.radiobutDerechosCesantia.Text = "Derechos y Cesantía"
        Me.radiobutDerechosCesantia.UseVisualStyleBackColor = True
        '
        'radiobutDerechos
        '
        Me.radiobutDerechos.AutoSize = True
        Me.radiobutDerechos.Checked = True
        Me.radiobutDerechos.Location = New System.Drawing.Point(7, 12)
        Me.radiobutDerechos.Name = "radiobutDerechos"
        Me.radiobutDerechos.Size = New System.Drawing.Size(71, 17)
        Me.radiobutDerechos.TabIndex = 0
        Me.radiobutDerechos.TabStop = True
        Me.radiobutDerechos.Text = "Derechos"
        Me.radiobutDerechos.UseVisualStyleBackColor = True
        '
        'PLPrestacionesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 594)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.c1txtElaboradoPor)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.c1txtObservaciones)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.toolstripPrestaciones)
        Me.Controls.Add(Me.c1truedbgrdPlanillas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "PLPrestacionesFrm"
        Me.Text = "Calculo de Prestaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1dateFechaIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1dateFechaRetiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtCodigoEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripPrestaciones.ResumeLayout(False)
        Me.toolstripPrestaciones.PerformLayout()
        CType(Me.c1txtObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.c1truedbgrdPlanillas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLPrestacionesPlanillaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLPrestacionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.c1numDiasLaborados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numMesesLaborados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numAñosLaborados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numDiasPropVacaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numDiasProp13vo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numDiasProp14vo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.c1numSalarioPromedioDiario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSalarioPromedio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numHorasExtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSueldoOrdinarioDiario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSueldoBaseOrdinario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSueldoBaseDiario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSueldoBaseMensual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.c1truedbgrdDedPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLPrestacionesDeduccionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtDescVacAñosAnt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numImpuestoVecinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSeguroSocial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numDiasPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numVacacionesAñosAnteriores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numVacacionesProporcionales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1num13voProporcional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1num14voProporcional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numCesantiaProporcional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numCesantia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numPreaviso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtElaboradoPor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarEmpleado As RSIContab.BotonBuscar
    Friend WithEvents c1txtCodigoEmpleado As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblNombreEmpleado As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLPrestacionesDataSet As RSIContab.PLPrestacionesDataSet
    Friend WithEvents PLPrestacionesTableAdapter As RSIContab.PLPrestacionesDataSetTableAdapters.PLPrestacionesTableAdapter
    Friend WithEvents PLPrestacionesDeduccionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLPrestacionesDeduccionesTableAdapter As RSIContab.PLPrestacionesDataSetTableAdapters.PLPrestacionesDeduccionesTableAdapter
    Friend WithEvents PLPrestacionesPlanillaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLPrestacionesPlanillasTableAdapter As RSIContab.PLPrestacionesDataSetTableAdapters.PLPrestacionesPlanillasTableAdapter
    Friend WithEvents toolstripPrestaciones As System.Windows.Forms.ToolStrip
    Friend WithEvents c1truedbgrdPlanillas As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents c1numDiasPropVacaciones As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numDiasProp13vo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numDiasProp14vo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents c1dateFechaRetiro As C1.Win.C1Input.C1DateEdit
    Friend WithEvents toolstripbutNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbutEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbutGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbutSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbutCalcular As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotalBonificaciones As System.Windows.Forms.Label
    Friend WithEvents lblTotalHorasExtras As System.Windows.Forms.Label
    Friend WithEvents lblTotalSueldoNormal As System.Windows.Forms.Label
    Friend WithEvents toolstripbutImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents c1txtObservaciones As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1numDiasLaborados As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numMesesLaborados As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numAñosLaborados As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents c1dateFechaIngreso As C1.Win.C1Input.C1DateEdit
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents c1numSalarioPromedioDiario As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numSalarioPromedio As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numHorasExtras As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numSueldoOrdinarioDiario As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numSueldoBaseOrdinario As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numSueldoBaseDiario As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numSueldoBaseMensual As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPrestaciones As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents c1txtDescVacAñosAnt As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1numImpuestoVecinal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRAP As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numSeguroSocial As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numDiasPendientes As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numVacacionesAñosAnteriores As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numVacacionesProporcionales As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1num13voProporcional As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1num14voProporcional As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numCesantiaProporcional As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numCesantia As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numPreaviso As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1truedbgrdDedPendientes As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents c1txtElaboradoPor As C1.Win.C1Input.C1TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radiobutTodo As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutDerechosCesantia As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutDerechos As System.Windows.Forms.RadioButton
End Class
