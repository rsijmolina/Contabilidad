<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLConfFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PLConfFrm))
        Me.tabConfPlanillas = New System.Windows.Forms.TabControl()
        Me.tabGenerales = New System.Windows.Forms.TabPage()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.c1numSalariosMinimos13vo14vo = New C1.Win.C1Input.C1NumericEdit()
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLConfDataSet = New RSIContab.PLConfDataSet()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.c1numSalarioMinimo = New C1.Win.C1Input.C1NumericEdit()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.c1numPorcPatronalINFOP = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numPorcPatronalRAP = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numPorcPatronalSeguroSocial = New C1.Win.C1Input.C1NumericEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chkUsarSecciones = New System.Windows.Forms.CheckBox()
        Me.chkUsarDepartamentos = New System.Windows.Forms.CheckBox()
        Me.chkUsarSedes = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.c1numPlanilla14vo = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numPlanilla13vo = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numPlaniVacaciones = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numPlaniComplementaria = New C1.Win.C1Input.C1NumericEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.c1numPlanillaActual = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numPlaniOrdinariasPorMes = New C1.Win.C1Input.C1NumericEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkBoxEnlazadoContabilidad = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.c1dateFechaProceso = New C1.Win.C1Input.C1DateEdit()
        Me.c1numMesProceso = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numAñoProceso = New C1.Win.C1Input.C1NumericEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabCalculos = New System.Windows.Forms.TabPage()
        Me.butExcepciones = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.radiobutValorCoopOpcional = New System.Windows.Forms.RadioButton()
        Me.radiobutCalcCoopPorcSueldo = New System.Windows.Forms.RadioButton()
        Me.c1numPorcCooperativa = New C1.Win.C1Input.C1NumericEdit()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.c1numNoPlaniCooperativa = New C1.Win.C1Input.C1NumericEdit()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.cmbCooperativa = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.c1numPorcINJUPEMP = New C1.Win.C1Input.C1NumericEdit()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.c1numNoPlaniINJUPEMP = New C1.Win.C1Input.C1NumericEdit()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cmbINJUPEMP = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.c1numPorcINPREMA = New C1.Win.C1Input.C1NumericEdit()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.c1numNoPlaniINPREMA = New C1.Win.C1Input.C1NumericEdit()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cmbINPREMA = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.c1numAplicarImpVecinalHasta = New C1.Win.C1Input.C1NumericEdit()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.chkCalcularImpVecinal = New System.Windows.Forms.CheckBox()
        Me.c1numNoPlaniImpVecinal = New C1.Win.C1Input.C1NumericEdit()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cmbImpVecinal = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.c1numNoPlaniISR = New C1.Win.C1Input.C1NumericEdit()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmbImpRenta = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.c1numPorcMaxRAP = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numPorcRAP = New C1.Win.C1Input.C1NumericEdit()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.c1numNoPlaniRAP = New C1.Win.C1Input.C1NumericEdit()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbRAP = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.c1numPorcMaxDocenteSeguroSocial = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numPorcMaxSeguroSocial = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numPorcDocenteSeguroSocial = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numPorcSeguroSocial = New C1.Win.C1Input.C1NumericEdit()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.c1numNoPlaniSeguroSocial = New C1.Win.C1Input.C1NumericEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbSeguro = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.c1truedbgrdCalcDed = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.CalculoDeduccionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabTitulos = New System.Windows.Forms.TabPage()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.txtNombreDeduccion5 = New System.Windows.Forms.TextBox()
        Me.txtNombreDeduccion4 = New System.Windows.Forms.TextBox()
        Me.txtNombreDeduccion3 = New System.Windows.Forms.TextBox()
        Me.txtNombreDeduccion2 = New System.Windows.Forms.TextBox()
        Me.txtNombreDeduccion1 = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.txtNombreIngreso5 = New System.Windows.Forms.TextBox()
        Me.txtNombreIngreso4 = New System.Windows.Forms.TextBox()
        Me.txtNombreIngreso3 = New System.Windows.Forms.TextBox()
        Me.txtNombreIngreso2 = New System.Windows.Forms.TextBox()
        Me.txtNombreIngreso1 = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.butAceptar = New System.Windows.Forms.Button()
        Me.butCancelar = New System.Windows.Forms.Button()
        Me.PLConfTableAdapter = New RSIContab.PLConfDataSetTableAdapters.PLConfTableAdapter()
        Me.PLCalculoDeduccionesTableAdapter = New RSIContab.PLConfDataSetTableAdapters.PLCalculoDeduccionesTableAdapter()
        Me.tabConfPlanillas.SuspendLayout()
        Me.tabGenerales.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.c1numSalariosMinimos13vo14vo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLConfDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSalarioMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numPorcPatronalINFOP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numPorcPatronalRAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numPorcPatronalSeguroSocial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1numPlanilla14vo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numPlanilla13vo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numPlaniVacaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numPlaniComplementaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numPlanillaActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numPlaniOrdinariasPorMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1dateFechaProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numMesProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numAñoProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCalculos.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.c1numPorcCooperativa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numNoPlaniCooperativa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.c1numPorcINJUPEMP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numNoPlaniINJUPEMP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.c1numPorcINPREMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numNoPlaniINPREMA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.c1numAplicarImpVecinalHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numNoPlaniImpVecinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.c1numNoPlaniISR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.c1numPorcMaxRAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numPorcRAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numNoPlaniRAP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.c1numPorcMaxDocenteSeguroSocial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numPorcMaxSeguroSocial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numPorcDocenteSeguroSocial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numPorcSeguroSocial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numNoPlaniSeguroSocial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.c1truedbgrdCalcDed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalculoDeduccionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTitulos.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabConfPlanillas
        '
        Me.tabConfPlanillas.Controls.Add(Me.tabGenerales)
        Me.tabConfPlanillas.Controls.Add(Me.tabCalculos)
        Me.tabConfPlanillas.Controls.Add(Me.TabPage1)
        Me.tabConfPlanillas.Controls.Add(Me.tabTitulos)
        Me.tabConfPlanillas.Location = New System.Drawing.Point(1, 2)
        Me.tabConfPlanillas.Name = "tabConfPlanillas"
        Me.tabConfPlanillas.SelectedIndex = 0
        Me.tabConfPlanillas.Size = New System.Drawing.Size(558, 398)
        Me.tabConfPlanillas.TabIndex = 49
        '
        'tabGenerales
        '
        Me.tabGenerales.Controls.Add(Me.GroupBox12)
        Me.tabGenerales.Controls.Add(Me.GroupBox2)
        Me.tabGenerales.Controls.Add(Me.GroupBox1)
        Me.tabGenerales.Location = New System.Drawing.Point(4, 22)
        Me.tabGenerales.Name = "tabGenerales"
        Me.tabGenerales.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGenerales.Size = New System.Drawing.Size(550, 372)
        Me.tabGenerales.TabIndex = 0
        Me.tabGenerales.Text = "Generales"
        Me.tabGenerales.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.Button4)
        Me.GroupBox12.Location = New System.Drawing.Point(8, 234)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(530, 92)
        Me.GroupBox12.TabIndex = 4
        Me.GroupBox12.TabStop = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(10, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(154, 33)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Cálculo del Impuesto Vecinal"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.c1numSalariosMinimos13vo14vo)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.c1numSalarioMinimo)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.c1numPorcPatronalINFOP)
        Me.GroupBox2.Controls.Add(Me.c1numPorcPatronalRAP)
        Me.GroupBox2.Controls.Add(Me.c1numPorcPatronalSeguroSocial)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.chkUsarSecciones)
        Me.GroupBox2.Controls.Add(Me.chkUsarDepartamentos)
        Me.GroupBox2.Controls.Add(Me.chkUsarSedes)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(530, 94)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'c1numSalariosMinimos13vo14vo
        '
        Me.c1numSalariosMinimos13vo14vo.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "NoSalariosMin13vo14voISR", True))
        Me.c1numSalariosMinimos13vo14vo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numSalariosMinimos13vo14vo.Location = New System.Drawing.Point(475, 42)
        Me.c1numSalariosMinimos13vo14vo.Name = "c1numSalariosMinimos13vo14vo"
        Me.c1numSalariosMinimos13vo14vo.Size = New System.Drawing.Size(45, 20)
        Me.c1numSalariosMinimos13vo14vo.TabIndex = 20
        Me.c1numSalariosMinimos13vo14vo.Tag = "CM"
        Me.c1numSalariosMinimos13vo14vo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSalariosMinimos13vo14vo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLConf"
        Me.PrincipalBindingSource.DataSource = Me.PLConfDataSet
        '
        'PLConfDataSet
        '
        Me.PLConfDataSet.DataSetName = "PLConfDataSet"
        Me.PLConfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(371, 39)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 30)
        Me.Label20.TabIndex = 75
        Me.Label20.Text = "Salarios Mínimos Para 13vo. y 14vo.:"
        '
        'c1numSalarioMinimo
        '
        Me.c1numSalarioMinimo.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "SalarioMinimo", True))
        Me.c1numSalarioMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numSalarioMinimo.Location = New System.Drawing.Point(475, 15)
        Me.c1numSalarioMinimo.Name = "c1numSalarioMinimo"
        Me.c1numSalarioMinimo.Size = New System.Drawing.Size(45, 20)
        Me.c1numSalarioMinimo.TabIndex = 19
        Me.c1numSalarioMinimo.Tag = "CM"
        Me.c1numSalarioMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSalarioMinimo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(371, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 13)
        Me.Label19.TabIndex = 73
        Me.Label19.Text = "Salario Mínimo:"
        '
        'c1numPorcPatronalINFOP
        '
        Me.c1numPorcPatronalINFOP.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "PorcPatronalINFOP", True))
        Me.c1numPorcPatronalINFOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numPorcPatronalINFOP.Location = New System.Drawing.Point(307, 64)
        Me.c1numPorcPatronalINFOP.Name = "c1numPorcPatronalINFOP"
        Me.c1numPorcPatronalINFOP.Size = New System.Drawing.Size(45, 20)
        Me.c1numPorcPatronalINFOP.TabIndex = 18
        Me.c1numPorcPatronalINFOP.Tag = "CM"
        Me.c1numPorcPatronalINFOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numPorcPatronalINFOP.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numPorcPatronalRAP
        '
        Me.c1numPorcPatronalRAP.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "PorcPatronalRAP", True))
        Me.c1numPorcPatronalRAP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numPorcPatronalRAP.Location = New System.Drawing.Point(307, 38)
        Me.c1numPorcPatronalRAP.Name = "c1numPorcPatronalRAP"
        Me.c1numPorcPatronalRAP.Size = New System.Drawing.Size(45, 20)
        Me.c1numPorcPatronalRAP.TabIndex = 17
        Me.c1numPorcPatronalRAP.Tag = "CM"
        Me.c1numPorcPatronalRAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numPorcPatronalRAP.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numPorcPatronalSeguroSocial
        '
        Me.c1numPorcPatronalSeguroSocial.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "PorcPatronalSeguro", True))
        Me.c1numPorcPatronalSeguroSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numPorcPatronalSeguroSocial.Location = New System.Drawing.Point(307, 12)
        Me.c1numPorcPatronalSeguroSocial.Name = "c1numPorcPatronalSeguroSocial"
        Me.c1numPorcPatronalSeguroSocial.Size = New System.Drawing.Size(45, 20)
        Me.c1numPorcPatronalSeguroSocial.TabIndex = 16
        Me.c1numPorcPatronalSeguroSocial.Tag = "CM"
        Me.c1numPorcPatronalSeguroSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numPorcPatronalSeguroSocial.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(162, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 13)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "% Patronal del INFOP:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(162, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 13)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "% Patronal del RAP:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(162, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 13)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "% Patronal del Seguro Social:"
        '
        'chkUsarSecciones
        '
        Me.chkUsarSecciones.AutoSize = True
        Me.chkUsarSecciones.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PrincipalBindingSource, "UsarSecciones", True))
        Me.chkUsarSecciones.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PrincipalBindingSource, "UsarSecciones", True))
        Me.chkUsarSecciones.Location = New System.Drawing.Point(8, 64)
        Me.chkUsarSecciones.Name = "chkUsarSecciones"
        Me.chkUsarSecciones.Size = New System.Drawing.Size(101, 17)
        Me.chkUsarSecciones.TabIndex = 15
        Me.chkUsarSecciones.Text = "Usar Secciones"
        Me.chkUsarSecciones.UseVisualStyleBackColor = True
        '
        'chkUsarDepartamentos
        '
        Me.chkUsarDepartamentos.AutoSize = True
        Me.chkUsarDepartamentos.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PrincipalBindingSource, "UsarDepartamentos", True))
        Me.chkUsarDepartamentos.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PrincipalBindingSource, "UsarDepartamentos", True))
        Me.chkUsarDepartamentos.Location = New System.Drawing.Point(8, 38)
        Me.chkUsarDepartamentos.Name = "chkUsarDepartamentos"
        Me.chkUsarDepartamentos.Size = New System.Drawing.Size(123, 17)
        Me.chkUsarDepartamentos.TabIndex = 14
        Me.chkUsarDepartamentos.Text = "Usar Departamentos"
        Me.chkUsarDepartamentos.UseVisualStyleBackColor = True
        '
        'chkUsarSedes
        '
        Me.chkUsarSedes.AutoSize = True
        Me.chkUsarSedes.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PrincipalBindingSource, "UsarSedes", True))
        Me.chkUsarSedes.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PrincipalBindingSource, "UsarSedes", True))
        Me.chkUsarSedes.Location = New System.Drawing.Point(8, 15)
        Me.chkUsarSedes.Name = "chkUsarSedes"
        Me.chkUsarSedes.Size = New System.Drawing.Size(81, 17)
        Me.chkUsarSedes.TabIndex = 13
        Me.chkUsarSedes.Text = "Usar Sedes"
        Me.chkUsarSedes.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.c1numPlanilla14vo)
        Me.GroupBox1.Controls.Add(Me.c1numPlanilla13vo)
        Me.GroupBox1.Controls.Add(Me.c1numPlaniVacaciones)
        Me.GroupBox1.Controls.Add(Me.c1numPlaniComplementaria)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.c1numPlanillaActual)
        Me.GroupBox1.Controls.Add(Me.c1numPlaniOrdinariasPorMes)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.chkBoxEnlazadoContabilidad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.c1dateFechaProceso)
        Me.GroupBox1.Controls.Add(Me.c1numMesProceso)
        Me.GroupBox1.Controls.Add(Me.c1numAñoProceso)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(531, 121)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'c1numPlanilla14vo
        '
        Me.c1numPlanilla14vo.AutoSize = False
        Me.c1numPlanilla14vo.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "NoPlanilla14vo", True))
        Me.c1numPlanilla14vo.DataType = GetType(Short)
        Me.c1numPlanilla14vo.Location = New System.Drawing.Point(493, 95)
        Me.c1numPlanilla14vo.Name = "c1numPlanilla14vo"
        Me.c1numPlanilla14vo.Size = New System.Drawing.Size(28, 20)
        Me.c1numPlanilla14vo.TabIndex = 12
        Me.c1numPlanilla14vo.Tag = "CM"
        Me.c1numPlanilla14vo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numPlanilla13vo
        '
        Me.c1numPlanilla13vo.AutoSize = False
        Me.c1numPlanilla13vo.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "NoPlanilla13vo", True))
        Me.c1numPlanilla13vo.DataType = GetType(Short)
        Me.c1numPlanilla13vo.Location = New System.Drawing.Point(493, 68)
        Me.c1numPlanilla13vo.Name = "c1numPlanilla13vo"
        Me.c1numPlanilla13vo.Size = New System.Drawing.Size(28, 20)
        Me.c1numPlanilla13vo.TabIndex = 11
        Me.c1numPlanilla13vo.Tag = "CM"
        Me.c1numPlanilla13vo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numPlaniVacaciones
        '
        Me.c1numPlaniVacaciones.AutoSize = False
        Me.c1numPlaniVacaciones.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "NoPlanillaVacaciones", True))
        Me.c1numPlaniVacaciones.DataType = GetType(Short)
        Me.c1numPlaniVacaciones.Location = New System.Drawing.Point(493, 42)
        Me.c1numPlaniVacaciones.Name = "c1numPlaniVacaciones"
        Me.c1numPlaniVacaciones.Size = New System.Drawing.Size(28, 20)
        Me.c1numPlaniVacaciones.TabIndex = 10
        Me.c1numPlaniVacaciones.Tag = "CM"
        Me.c1numPlaniVacaciones.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numPlaniComplementaria
        '
        Me.c1numPlaniComplementaria.AutoSize = False
        Me.c1numPlaniComplementaria.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "NoPlanillaComplementaria", True))
        Me.c1numPlaniComplementaria.DataType = GetType(Short)
        Me.c1numPlaniComplementaria.Location = New System.Drawing.Point(493, 13)
        Me.c1numPlaniComplementaria.Name = "c1numPlaniComplementaria"
        Me.c1numPlaniComplementaria.Size = New System.Drawing.Size(28, 20)
        Me.c1numPlaniComplementaria.TabIndex = 9
        Me.c1numPlaniComplementaria.Tag = "CM"
        Me.c1numPlaniComplementaria.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(356, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Planilla 14vo. Mes:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(356, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Planilla 13vo. Mes:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(356, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Planilla de Vacaciones:"
        '
        'c1numPlanillaActual
        '
        Me.c1numPlanillaActual.AutoSize = False
        Me.c1numPlanillaActual.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "NoPlanilla", True))
        Me.c1numPlanillaActual.DataType = GetType(Short)
        Me.c1numPlanillaActual.Location = New System.Drawing.Point(308, 46)
        Me.c1numPlanillaActual.Name = "c1numPlanillaActual"
        Me.c1numPlanillaActual.Size = New System.Drawing.Size(28, 20)
        Me.c1numPlanillaActual.TabIndex = 7
        Me.c1numPlanillaActual.Tag = "CM"
        Me.c1numPlanillaActual.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numPlaniOrdinariasPorMes
        '
        Me.c1numPlaniOrdinariasPorMes.AutoSize = False
        Me.c1numPlaniOrdinariasPorMes.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "PlanillasPorMes", True))
        Me.c1numPlaniOrdinariasPorMes.DataType = GetType(Short)
        Me.c1numPlaniOrdinariasPorMes.Location = New System.Drawing.Point(308, 13)
        Me.c1numPlaniOrdinariasPorMes.Name = "c1numPlaniOrdinariasPorMes"
        Me.c1numPlaniOrdinariasPorMes.Size = New System.Drawing.Size(28, 20)
        Me.c1numPlaniOrdinariasPorMes.TabIndex = 6
        Me.c1numPlaniOrdinariasPorMes.Tag = "CM"
        Me.c1numPlaniOrdinariasPorMes.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(356, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Planilla Complementarias:"
        '
        'chkBoxEnlazadoContabilidad
        '
        Me.chkBoxEnlazadoContabilidad.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PrincipalBindingSource, "EnlazarContabilidad", True))
        Me.chkBoxEnlazadoContabilidad.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PrincipalBindingSource, "EnlazarContabilidad", True))
        Me.chkBoxEnlazadoContabilidad.Location = New System.Drawing.Point(214, 67)
        Me.chkBoxEnlazadoContabilidad.Name = "chkBoxEnlazadoContabilidad"
        Me.chkBoxEnlazadoContabilidad.Size = New System.Drawing.Size(97, 30)
        Me.chkBoxEnlazadoContabilidad.TabIndex = 8
        Me.chkBoxEnlazadoContabilidad.Text = "Enlazado a Contabilidad"
        Me.chkBoxEnlazadoContabilidad.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Planilla Actual:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(211, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 36)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Planillas Ordinarias por Mes:"
        '
        'c1dateFechaProceso
        '
        Me.c1dateFechaProceso.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "FechaProceso", True))
        Me.c1dateFechaProceso.DateTimeInput = False
        Me.c1dateFechaProceso.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.c1dateFechaProceso.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1dateFechaProceso.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.c1dateFechaProceso.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1dateFechaProceso.Location = New System.Drawing.Point(109, 65)
        Me.c1dateFechaProceso.Name = "c1dateFechaProceso"
        Me.c1dateFechaProceso.Size = New System.Drawing.Size(92, 20)
        Me.c1dateFechaProceso.TabIndex = 5
        Me.c1dateFechaProceso.Tag = "CM"
        Me.c1dateFechaProceso.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'c1numMesProceso
        '
        Me.c1numMesProceso.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "MesEnProceso", True))
        Me.c1numMesProceso.DataType = GetType(Short)
        Me.c1numMesProceso.Location = New System.Drawing.Point(109, 39)
        Me.c1numMesProceso.Name = "c1numMesProceso"
        Me.c1numMesProceso.Size = New System.Drawing.Size(43, 20)
        Me.c1numMesProceso.TabIndex = 4
        Me.c1numMesProceso.Tag = Nothing
        Me.c1numMesProceso.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown
        '
        'c1numAñoProceso
        '
        Me.c1numAñoProceso.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "AñoEnProceso", True))
        Me.c1numAñoProceso.DataType = GetType(Short)
        Me.c1numAñoProceso.Location = New System.Drawing.Point(109, 13)
        Me.c1numAñoProceso.Name = "c1numAñoProceso"
        Me.c1numAñoProceso.Size = New System.Drawing.Size(56, 20)
        Me.c1numAñoProceso.TabIndex = 3
        Me.c1numAñoProceso.Tag = Nothing
        Me.c1numAñoProceso.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha de Proceso:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mes en Proceso:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Año en Proceso:"
        '
        'tabCalculos
        '
        Me.tabCalculos.Controls.Add(Me.butExcepciones)
        Me.tabCalculos.Controls.Add(Me.GroupBox9)
        Me.tabCalculos.Controls.Add(Me.GroupBox8)
        Me.tabCalculos.Controls.Add(Me.GroupBox7)
        Me.tabCalculos.Controls.Add(Me.GroupBox6)
        Me.tabCalculos.Controls.Add(Me.GroupBox5)
        Me.tabCalculos.Controls.Add(Me.GroupBox4)
        Me.tabCalculos.Controls.Add(Me.GroupBox3)
        Me.tabCalculos.Location = New System.Drawing.Point(4, 22)
        Me.tabCalculos.Name = "tabCalculos"
        Me.tabCalculos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCalculos.Size = New System.Drawing.Size(550, 372)
        Me.tabCalculos.TabIndex = 1
        Me.tabCalculos.Text = "Cálculos"
        Me.tabCalculos.UseVisualStyleBackColor = True
        '
        'butExcepciones
        '
        Me.butExcepciones.Location = New System.Drawing.Point(7, 334)
        Me.butExcepciones.Name = "butExcepciones"
        Me.butExcepciones.Size = New System.Drawing.Size(126, 32)
        Me.butExcepciones.TabIndex = 7
        Me.butExcepciones.Text = "Excepciones"
        Me.butExcepciones.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.radiobutValorCoopOpcional)
        Me.GroupBox9.Controls.Add(Me.radiobutCalcCoopPorcSueldo)
        Me.GroupBox9.Controls.Add(Me.c1numPorcCooperativa)
        Me.GroupBox9.Controls.Add(Me.Label37)
        Me.GroupBox9.Controls.Add(Me.c1numNoPlaniCooperativa)
        Me.GroupBox9.Controls.Add(Me.Label38)
        Me.GroupBox9.Controls.Add(Me.cmbCooperativa)
        Me.GroupBox9.Controls.Add(Me.Label39)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 118)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(242, 126)
        Me.GroupBox9.TabIndex = 6
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Cooperativa"
        '
        'radiobutValorCoopOpcional
        '
        Me.radiobutValorCoopOpcional.AutoSize = True
        Me.radiobutValorCoopOpcional.Location = New System.Drawing.Point(10, 44)
        Me.radiobutValorCoopOpcional.Name = "radiobutValorCoopOpcional"
        Me.radiobutValorCoopOpcional.Size = New System.Drawing.Size(162, 17)
        Me.radiobutValorCoopOpcional.TabIndex = 29
        Me.radiobutValorCoopOpcional.Text = "Valor Opcional por Empleado"
        Me.radiobutValorCoopOpcional.UseVisualStyleBackColor = True
        '
        'radiobutCalcCoopPorcSueldo
        '
        Me.radiobutCalcCoopPorcSueldo.AutoSize = True
        Me.radiobutCalcCoopPorcSueldo.Checked = True
        Me.radiobutCalcCoopPorcSueldo.Location = New System.Drawing.Point(10, 20)
        Me.radiobutCalcCoopPorcSueldo.Name = "radiobutCalcCoopPorcSueldo"
        Me.radiobutCalcCoopPorcSueldo.Size = New System.Drawing.Size(224, 17)
        Me.radiobutCalcCoopPorcSueldo.TabIndex = 28
        Me.radiobutCalcCoopPorcSueldo.TabStop = True
        Me.radiobutCalcCoopPorcSueldo.Text = "Calcular por Porcentaje en Base al Sueldo"
        Me.radiobutCalcCoopPorcSueldo.UseVisualStyleBackColor = True
        '
        'c1numPorcCooperativa
        '
        Me.c1numPorcCooperativa.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "PorcentajeCooperativa", True))
        Me.c1numPorcCooperativa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numPorcCooperativa.Location = New System.Drawing.Point(74, 94)
        Me.c1numPorcCooperativa.Name = "c1numPorcCooperativa"
        Me.c1numPorcCooperativa.Size = New System.Drawing.Size(45, 20)
        Me.c1numPorcCooperativa.TabIndex = 32
        Me.c1numPorcCooperativa.Tag = "CM"
        Me.c1numPorcCooperativa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numPorcCooperativa.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(7, 97)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(61, 13)
        Me.Label37.TabIndex = 51
        Me.Label37.Text = "Porcentaje:"
        '
        'c1numNoPlaniCooperativa
        '
        Me.c1numNoPlaniCooperativa.AutoSize = False
        Me.c1numNoPlaniCooperativa.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "NoPlanillaCooperativa", True))
        Me.c1numNoPlaniCooperativa.DataType = GetType(Short)
        Me.c1numNoPlaniCooperativa.Location = New System.Drawing.Point(214, 67)
        Me.c1numNoPlaniCooperativa.Name = "c1numNoPlaniCooperativa"
        Me.c1numNoPlaniCooperativa.Size = New System.Drawing.Size(22, 20)
        Me.c1numNoPlaniCooperativa.TabIndex = 31
        Me.c1numNoPlaniCooperativa.Tag = "CM"
        Me.c1numNoPlaniCooperativa.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(187, 68)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(24, 13)
        Me.Label38.TabIndex = 2
        Me.Label38.Text = "No."
        '
        'cmbCooperativa
        '
        Me.cmbCooperativa.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.PrincipalBindingSource, "CalcularCooperativa", True))
        Me.cmbCooperativa.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PrincipalBindingSource, "CalcularCooperativa", True))
        Me.cmbCooperativa.FormattingEnabled = True
        Me.cmbCooperativa.Location = New System.Drawing.Point(70, 67)
        Me.cmbCooperativa.Name = "cmbCooperativa"
        Me.cmbCooperativa.Size = New System.Drawing.Size(111, 21)
        Me.cmbCooperativa.TabIndex = 30
        Me.cmbCooperativa.Text = "Cada Planilla"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(7, 68)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(63, 13)
        Me.Label39.TabIndex = 0
        Me.Label39.Text = "Calcular en:"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.c1numPorcINJUPEMP)
        Me.GroupBox8.Controls.Add(Me.Label28)
        Me.GroupBox8.Controls.Add(Me.c1numNoPlaniINJUPEMP)
        Me.GroupBox8.Controls.Add(Me.Label34)
        Me.GroupBox8.Controls.Add(Me.cmbINJUPEMP)
        Me.GroupBox8.Controls.Add(Me.Label35)
        Me.GroupBox8.Location = New System.Drawing.Point(255, 164)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(242, 78)
        Me.GroupBox8.TabIndex = 5
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "INJUPEMP"
        '
        'c1numPorcINJUPEMP
        '
        Me.c1numPorcINJUPEMP.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "PorcentajeINJUPEMP", True))
        Me.c1numPorcINJUPEMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numPorcINJUPEMP.Location = New System.Drawing.Point(74, 46)
        Me.c1numPorcINJUPEMP.Name = "c1numPorcINJUPEMP"
        Me.c1numPorcINJUPEMP.Size = New System.Drawing.Size(45, 20)
        Me.c1numPorcINJUPEMP.TabIndex = 45
        Me.c1numPorcINJUPEMP.Tag = "CM"
        Me.c1numPorcINJUPEMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numPorcINJUPEMP.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(7, 49)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(61, 13)
        Me.Label28.TabIndex = 51
        Me.Label28.Text = "Porcentaje:"
        '
        'c1numNoPlaniINJUPEMP
        '
        Me.c1numNoPlaniINJUPEMP.AutoSize = False
        Me.c1numNoPlaniINJUPEMP.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "NoPlanillaINJUPEMP", True))
        Me.c1numNoPlaniINJUPEMP.DataType = GetType(Short)
        Me.c1numNoPlaniINJUPEMP.Location = New System.Drawing.Point(214, 19)
        Me.c1numNoPlaniINJUPEMP.Name = "c1numNoPlaniINJUPEMP"
        Me.c1numNoPlaniINJUPEMP.Size = New System.Drawing.Size(22, 20)
        Me.c1numNoPlaniINJUPEMP.TabIndex = 44
        Me.c1numNoPlaniINJUPEMP.Tag = "CM"
        Me.c1numNoPlaniINJUPEMP.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(187, 20)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(24, 13)
        Me.Label34.TabIndex = 2
        Me.Label34.Text = "No."
        '
        'cmbINJUPEMP
        '
        Me.cmbINJUPEMP.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.PrincipalBindingSource, "CalcularINJUPEMP", True))
        Me.cmbINJUPEMP.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PrincipalBindingSource, "CalcularINJUPEMP", True))
        Me.cmbINJUPEMP.FormattingEnabled = True
        Me.cmbINJUPEMP.Location = New System.Drawing.Point(70, 19)
        Me.cmbINJUPEMP.Name = "cmbINJUPEMP"
        Me.cmbINJUPEMP.Size = New System.Drawing.Size(111, 21)
        Me.cmbINJUPEMP.TabIndex = 43
        Me.cmbINJUPEMP.Text = "Cada Planilla"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(7, 20)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(63, 13)
        Me.Label35.TabIndex = 0
        Me.Label35.Text = "Calcular en:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.c1numPorcINPREMA)
        Me.GroupBox7.Controls.Add(Me.Label31)
        Me.GroupBox7.Controls.Add(Me.c1numNoPlaniINPREMA)
        Me.GroupBox7.Controls.Add(Me.Label32)
        Me.GroupBox7.Controls.Add(Me.cmbINPREMA)
        Me.GroupBox7.Controls.Add(Me.Label33)
        Me.GroupBox7.Location = New System.Drawing.Point(255, 249)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(242, 78)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "INPREMA"
        '
        'c1numPorcINPREMA
        '
        Me.c1numPorcINPREMA.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "PorcentajeINPREMA", True))
        Me.c1numPorcINPREMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numPorcINPREMA.Location = New System.Drawing.Point(74, 46)
        Me.c1numPorcINPREMA.Name = "c1numPorcINPREMA"
        Me.c1numPorcINPREMA.Size = New System.Drawing.Size(45, 20)
        Me.c1numPorcINPREMA.TabIndex = 48
        Me.c1numPorcINPREMA.Tag = "CM"
        Me.c1numPorcINPREMA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numPorcINPREMA.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(7, 49)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(61, 13)
        Me.Label31.TabIndex = 51
        Me.Label31.Text = "Porcentaje:"
        '
        'c1numNoPlaniINPREMA
        '
        Me.c1numNoPlaniINPREMA.AutoSize = False
        Me.c1numNoPlaniINPREMA.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "NoPlanillaINPREMA", True))
        Me.c1numNoPlaniINPREMA.DataType = GetType(Short)
        Me.c1numNoPlaniINPREMA.Location = New System.Drawing.Point(214, 19)
        Me.c1numNoPlaniINPREMA.Name = "c1numNoPlaniINPREMA"
        Me.c1numNoPlaniINPREMA.Size = New System.Drawing.Size(22, 20)
        Me.c1numNoPlaniINPREMA.TabIndex = 47
        Me.c1numNoPlaniINPREMA.Tag = "CM"
        Me.c1numNoPlaniINPREMA.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(187, 20)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(24, 13)
        Me.Label32.TabIndex = 2
        Me.Label32.Text = "No."
        '
        'cmbINPREMA
        '
        Me.cmbINPREMA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.PrincipalBindingSource, "CalcularINPREMA", True))
        Me.cmbINPREMA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PrincipalBindingSource, "CalcularINPREMA", True))
        Me.cmbINPREMA.FormattingEnabled = True
        Me.cmbINPREMA.Location = New System.Drawing.Point(70, 19)
        Me.cmbINPREMA.Name = "cmbINPREMA"
        Me.cmbINPREMA.Size = New System.Drawing.Size(111, 21)
        Me.cmbINPREMA.TabIndex = 46
        Me.cmbINPREMA.Text = "Cada Planilla"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(7, 20)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(63, 13)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "Calcular en:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.c1numAplicarImpVecinalHasta)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Controls.Add(Me.chkCalcularImpVecinal)
        Me.GroupBox6.Controls.Add(Me.c1numNoPlaniImpVecinal)
        Me.GroupBox6.Controls.Add(Me.Label29)
        Me.GroupBox6.Controls.Add(Me.cmbImpVecinal)
        Me.GroupBox6.Controls.Add(Me.Label30)
        Me.GroupBox6.Location = New System.Drawing.Point(255, 82)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(242, 75)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Impuesto Vecinal"
        '
        'c1numAplicarImpVecinalHasta
        '
        Me.c1numAplicarImpVecinalHasta.AutoSize = False
        Me.c1numAplicarImpVecinalHasta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "MesLimiteAplicarImpVecinal", True))
        Me.c1numAplicarImpVecinalHasta.DataType = GetType(Short)
        Me.c1numAplicarImpVecinalHasta.Location = New System.Drawing.Point(212, 16)
        Me.c1numAplicarImpVecinalHasta.Name = "c1numAplicarImpVecinalHasta"
        Me.c1numAplicarImpVecinalHasta.Size = New System.Drawing.Size(24, 20)
        Me.c1numAplicarImpVecinalHasta.TabIndex = 40
        Me.c1numAplicarImpVecinalHasta.Tag = "CM"
        Me.c1numAplicarImpVecinalHasta.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(95, 18)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(107, 13)
        Me.Label27.TabIndex = 52
        Me.Label27.Text = "Aplicar Hasta el Mes:"
        '
        'chkCalcularImpVecinal
        '
        Me.chkCalcularImpVecinal.AutoSize = True
        Me.chkCalcularImpVecinal.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PrincipalBindingSource, "CalcularImpuestoVecinal", True))
        Me.chkCalcularImpVecinal.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PrincipalBindingSource, "CalcularImpuestoVecinal", True))
        Me.chkCalcularImpVecinal.Location = New System.Drawing.Point(8, 18)
        Me.chkCalcularImpVecinal.Name = "chkCalcularImpVecinal"
        Me.chkCalcularImpVecinal.Size = New System.Drawing.Size(64, 17)
        Me.chkCalcularImpVecinal.TabIndex = 39
        Me.chkCalcularImpVecinal.Text = "Calcular"
        Me.chkCalcularImpVecinal.UseVisualStyleBackColor = True
        '
        'c1numNoPlaniImpVecinal
        '
        Me.c1numNoPlaniImpVecinal.AutoSize = False
        Me.c1numNoPlaniImpVecinal.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "NoPlanillaVecinal", True))
        Me.c1numNoPlaniImpVecinal.DataType = GetType(Short)
        Me.c1numNoPlaniImpVecinal.Location = New System.Drawing.Point(214, 41)
        Me.c1numNoPlaniImpVecinal.Name = "c1numNoPlaniImpVecinal"
        Me.c1numNoPlaniImpVecinal.Size = New System.Drawing.Size(22, 20)
        Me.c1numNoPlaniImpVecinal.TabIndex = 42
        Me.c1numNoPlaniImpVecinal.Tag = "CM"
        Me.c1numNoPlaniImpVecinal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(187, 44)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(24, 13)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "No."
        '
        'cmbImpVecinal
        '
        Me.cmbImpVecinal.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.PrincipalBindingSource, "CalcularImpuestoVecinal", True))
        Me.cmbImpVecinal.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PrincipalBindingSource, "CalcularImpuestoVecinal", True))
        Me.cmbImpVecinal.FormattingEnabled = True
        Me.cmbImpVecinal.Location = New System.Drawing.Point(71, 41)
        Me.cmbImpVecinal.Name = "cmbImpVecinal"
        Me.cmbImpVecinal.Size = New System.Drawing.Size(111, 21)
        Me.cmbImpVecinal.TabIndex = 41
        Me.cmbImpVecinal.Text = "Cada Planilla"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(5, 44)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(63, 13)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Calcular en:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.c1numNoPlaniISR)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.cmbImpRenta)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Location = New System.Drawing.Point(254, 13)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(242, 59)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Impuesto S/Renta"
        '
        'c1numNoPlaniISR
        '
        Me.c1numNoPlaniISR.AutoSize = False
        Me.c1numNoPlaniISR.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "NoPlanillaISR", True))
        Me.c1numNoPlaniISR.DataType = GetType(Short)
        Me.c1numNoPlaniISR.Location = New System.Drawing.Point(214, 19)
        Me.c1numNoPlaniISR.Name = "c1numNoPlaniISR"
        Me.c1numNoPlaniISR.Size = New System.Drawing.Size(22, 20)
        Me.c1numNoPlaniISR.TabIndex = 38
        Me.c1numNoPlaniISR.Tag = "CM"
        Me.c1numNoPlaniISR.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(187, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(24, 13)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "No."
        '
        'cmbImpRenta
        '
        Me.cmbImpRenta.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.PrincipalBindingSource, "CalcularISR", True))
        Me.cmbImpRenta.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PrincipalBindingSource, "CalcularISR", True))
        Me.cmbImpRenta.FormattingEnabled = True
        Me.cmbImpRenta.Location = New System.Drawing.Point(70, 19)
        Me.cmbImpRenta.Name = "cmbImpRenta"
        Me.cmbImpRenta.Size = New System.Drawing.Size(111, 21)
        Me.cmbImpRenta.TabIndex = 37
        Me.cmbImpRenta.Text = "Cada Planilla"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(7, 20)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(63, 13)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Calcular en:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.c1numPorcMaxRAP)
        Me.GroupBox4.Controls.Add(Me.c1numPorcRAP)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.c1numNoPlaniRAP)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.cmbRAP)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 250)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(242, 77)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "RAP"
        '
        'c1numPorcMaxRAP
        '
        Me.c1numPorcMaxRAP.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionMaxRAP", True))
        Me.c1numPorcMaxRAP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numPorcMaxRAP.Location = New System.Drawing.Point(176, 49)
        Me.c1numPorcMaxRAP.Name = "c1numPorcMaxRAP"
        Me.c1numPorcMaxRAP.Size = New System.Drawing.Size(58, 20)
        Me.c1numPorcMaxRAP.TabIndex = 36
        Me.c1numPorcMaxRAP.Tag = "CM"
        Me.c1numPorcMaxRAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numPorcMaxRAP.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numPorcRAP
        '
        Me.c1numPorcRAP.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "PorcentajeRAP", True))
        Me.c1numPorcRAP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numPorcRAP.Location = New System.Drawing.Point(74, 46)
        Me.c1numPorcRAP.Name = "c1numPorcRAP"
        Me.c1numPorcRAP.Size = New System.Drawing.Size(45, 20)
        Me.c1numPorcRAP.TabIndex = 35
        Me.c1numPorcRAP.Tag = "CM"
        Me.c1numPorcRAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numPorcRAP.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(124, 49)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 13)
        Me.Label21.TabIndex = 52
        Me.Label21.Text = "Máximo:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(7, 49)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(61, 13)
        Me.Label22.TabIndex = 51
        Me.Label22.Text = "Porcentaje:"
        '
        'c1numNoPlaniRAP
        '
        Me.c1numNoPlaniRAP.AutoSize = False
        Me.c1numNoPlaniRAP.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "NoPlanillaRAP", True))
        Me.c1numNoPlaniRAP.DataType = GetType(Short)
        Me.c1numNoPlaniRAP.Location = New System.Drawing.Point(214, 19)
        Me.c1numNoPlaniRAP.Name = "c1numNoPlaniRAP"
        Me.c1numNoPlaniRAP.Size = New System.Drawing.Size(22, 20)
        Me.c1numNoPlaniRAP.TabIndex = 34
        Me.c1numNoPlaniRAP.Tag = "CM"
        Me.c1numNoPlaniRAP.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(187, 20)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(24, 13)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "No."
        '
        'cmbRAP
        '
        Me.cmbRAP.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.PrincipalBindingSource, "CalcularRAP", True))
        Me.cmbRAP.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PrincipalBindingSource, "CalcularRAP", True))
        Me.cmbRAP.FormattingEnabled = True
        Me.cmbRAP.Location = New System.Drawing.Point(70, 19)
        Me.cmbRAP.Name = "cmbRAP"
        Me.cmbRAP.Size = New System.Drawing.Size(111, 21)
        Me.cmbRAP.TabIndex = 33
        Me.cmbRAP.Text = "Cada Planilla"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(7, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(63, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Calcular en:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.c1numPorcMaxDocenteSeguroSocial)
        Me.GroupBox3.Controls.Add(Me.c1numPorcMaxSeguroSocial)
        Me.GroupBox3.Controls.Add(Me.c1numPorcDocenteSeguroSocial)
        Me.GroupBox3.Controls.Add(Me.c1numPorcSeguroSocial)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.c1numNoPlaniSeguroSocial)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.cmbSeguro)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(242, 106)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seguro Social"
        '
        'c1numPorcMaxDocenteSeguroSocial
        '
        Me.c1numPorcMaxDocenteSeguroSocial.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionMaxDocenteSS", True))
        Me.c1numPorcMaxDocenteSeguroSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numPorcMaxDocenteSeguroSocial.Location = New System.Drawing.Point(176, 75)
        Me.c1numPorcMaxDocenteSeguroSocial.Name = "c1numPorcMaxDocenteSeguroSocial"
        Me.c1numPorcMaxDocenteSeguroSocial.Size = New System.Drawing.Size(45, 20)
        Me.c1numPorcMaxDocenteSeguroSocial.TabIndex = 27
        Me.c1numPorcMaxDocenteSeguroSocial.Tag = "CM"
        Me.c1numPorcMaxDocenteSeguroSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numPorcMaxDocenteSeguroSocial.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numPorcMaxSeguroSocial
        '
        Me.c1numPorcMaxSeguroSocial.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionMaxSS", True))
        Me.c1numPorcMaxSeguroSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numPorcMaxSeguroSocial.Location = New System.Drawing.Point(176, 49)
        Me.c1numPorcMaxSeguroSocial.Name = "c1numPorcMaxSeguroSocial"
        Me.c1numPorcMaxSeguroSocial.Size = New System.Drawing.Size(45, 20)
        Me.c1numPorcMaxSeguroSocial.TabIndex = 25
        Me.c1numPorcMaxSeguroSocial.Tag = "CM"
        Me.c1numPorcMaxSeguroSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numPorcMaxSeguroSocial.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numPorcDocenteSeguroSocial
        '
        Me.c1numPorcDocenteSeguroSocial.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "PorcentajeDocenteSS", True))
        Me.c1numPorcDocenteSeguroSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numPorcDocenteSeguroSocial.Location = New System.Drawing.Point(73, 73)
        Me.c1numPorcDocenteSeguroSocial.Name = "c1numPorcDocenteSeguroSocial"
        Me.c1numPorcDocenteSeguroSocial.Size = New System.Drawing.Size(45, 20)
        Me.c1numPorcDocenteSeguroSocial.TabIndex = 26
        Me.c1numPorcDocenteSeguroSocial.Tag = "CM"
        Me.c1numPorcDocenteSeguroSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numPorcDocenteSeguroSocial.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numPorcSeguroSocial
        '
        Me.c1numPorcSeguroSocial.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "PorcentajeSS", True))
        Me.c1numPorcSeguroSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numPorcSeguroSocial.Location = New System.Drawing.Point(74, 46)
        Me.c1numPorcSeguroSocial.Name = "c1numPorcSeguroSocial"
        Me.c1numPorcSeguroSocial.Size = New System.Drawing.Size(45, 20)
        Me.c1numPorcSeguroSocial.TabIndex = 24
        Me.c1numPorcSeguroSocial.Tag = "CM"
        Me.c1numPorcSeguroSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numPorcSeguroSocial.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(124, 76)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 13)
        Me.Label18.TabIndex = 54
        Me.Label18.Text = "Máximo:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 76)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 13)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "% Docente:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(124, 49)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 13)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "Máximo:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 13)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Porcentaje:"
        '
        'c1numNoPlaniSeguroSocial
        '
        Me.c1numNoPlaniSeguroSocial.AutoSize = False
        Me.c1numNoPlaniSeguroSocial.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "NoPlanillaSeguro", True))
        Me.c1numNoPlaniSeguroSocial.DataType = GetType(Short)
        Me.c1numNoPlaniSeguroSocial.Location = New System.Drawing.Point(214, 19)
        Me.c1numNoPlaniSeguroSocial.Name = "c1numNoPlaniSeguroSocial"
        Me.c1numNoPlaniSeguroSocial.Size = New System.Drawing.Size(22, 20)
        Me.c1numNoPlaniSeguroSocial.TabIndex = 23
        Me.c1numNoPlaniSeguroSocial.Tag = "CM"
        Me.c1numNoPlaniSeguroSocial.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(187, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "No."
        '
        'cmbSeguro
        '
        Me.cmbSeguro.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.PrincipalBindingSource, "CalcularSeguroSocial", True))
        Me.cmbSeguro.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PrincipalBindingSource, "CalcularSeguroSocial", True))
        Me.cmbSeguro.FormattingEnabled = True
        Me.cmbSeguro.Location = New System.Drawing.Point(70, 19)
        Me.cmbSeguro.Name = "cmbSeguro"
        Me.cmbSeguro.Size = New System.Drawing.Size(111, 21)
        Me.cmbSeguro.TabIndex = 22
        Me.cmbSeguro.Text = "Cada Planilla"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Calcular en:"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.c1truedbgrdCalcDed)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(550, 372)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Incluir En Cálculos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'c1truedbgrdCalcDed
        '
        Me.c1truedbgrdCalcDed.DataSource = Me.CalculoDeduccionesBindingSource
        Me.c1truedbgrdCalcDed.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1truedbgrdCalcDed.Images.Add(CType(resources.GetObject("c1truedbgrdCalcDed.Images"), System.Drawing.Image))
        Me.c1truedbgrdCalcDed.Location = New System.Drawing.Point(5, 7)
        Me.c1truedbgrdCalcDed.Name = "c1truedbgrdCalcDed"
        Me.c1truedbgrdCalcDed.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1truedbgrdCalcDed.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1truedbgrdCalcDed.PreviewInfo.ZoomFactor = 75.0R
        Me.c1truedbgrdCalcDed.PrintInfo.PageSettings = CType(resources.GetObject("c1truedbgrdCalcDed.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1truedbgrdCalcDed.RowHeight = 17
        Me.c1truedbgrdCalcDed.Size = New System.Drawing.Size(539, 259)
        Me.c1truedbgrdCalcDed.TabIndex = 0
        Me.c1truedbgrdCalcDed.Text = "C1TrueDBGrid1"
        Me.c1truedbgrdCalcDed.PropBag = resources.GetString("c1truedbgrdCalcDed.PropBag")
        '
        'CalculoDeduccionesBindingSource
        '
        Me.CalculoDeduccionesBindingSource.DataMember = "PLCalculoDeducciones"
        Me.CalculoDeduccionesBindingSource.DataSource = Me.PLConfDataSet
        '
        'tabTitulos
        '
        Me.tabTitulos.Controls.Add(Me.GroupBox11)
        Me.tabTitulos.Controls.Add(Me.GroupBox10)
        Me.tabTitulos.Location = New System.Drawing.Point(4, 22)
        Me.tabTitulos.Name = "tabTitulos"
        Me.tabTitulos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTitulos.Size = New System.Drawing.Size(550, 372)
        Me.tabTitulos.TabIndex = 2
        Me.tabTitulos.Text = "Títulos"
        Me.tabTitulos.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.txtNombreDeduccion5)
        Me.GroupBox11.Controls.Add(Me.txtNombreDeduccion4)
        Me.GroupBox11.Controls.Add(Me.txtNombreDeduccion3)
        Me.GroupBox11.Controls.Add(Me.txtNombreDeduccion2)
        Me.GroupBox11.Controls.Add(Me.txtNombreDeduccion1)
        Me.GroupBox11.Controls.Add(Me.Label44)
        Me.GroupBox11.Controls.Add(Me.Label45)
        Me.GroupBox11.Controls.Add(Me.Label46)
        Me.GroupBox11.Controls.Add(Me.Label47)
        Me.GroupBox11.Controls.Add(Me.Label48)
        Me.GroupBox11.Location = New System.Drawing.Point(240, 6)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(241, 161)
        Me.GroupBox11.TabIndex = 1
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Títulos de Deducciones"
        '
        'txtNombreDeduccion5
        '
        Me.txtNombreDeduccion5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrincipalBindingSource, "NombreDeduccion5", True))
        Me.txtNombreDeduccion5.Location = New System.Drawing.Point(88, 124)
        Me.txtNombreDeduccion5.MaxLength = 15
        Me.txtNombreDeduccion5.Name = "txtNombreDeduccion5"
        Me.txtNombreDeduccion5.Size = New System.Drawing.Size(144, 20)
        Me.txtNombreDeduccion5.TabIndex = 59
        Me.txtNombreDeduccion5.Tag = "CM"
        '
        'txtNombreDeduccion4
        '
        Me.txtNombreDeduccion4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrincipalBindingSource, "NombreDeduccion4", True))
        Me.txtNombreDeduccion4.Location = New System.Drawing.Point(88, 98)
        Me.txtNombreDeduccion4.MaxLength = 15
        Me.txtNombreDeduccion4.Name = "txtNombreDeduccion4"
        Me.txtNombreDeduccion4.Size = New System.Drawing.Size(144, 20)
        Me.txtNombreDeduccion4.TabIndex = 58
        Me.txtNombreDeduccion4.Tag = "CM"
        '
        'txtNombreDeduccion3
        '
        Me.txtNombreDeduccion3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrincipalBindingSource, "NombreDeduccion3", True))
        Me.txtNombreDeduccion3.Location = New System.Drawing.Point(88, 71)
        Me.txtNombreDeduccion3.MaxLength = 15
        Me.txtNombreDeduccion3.Name = "txtNombreDeduccion3"
        Me.txtNombreDeduccion3.Size = New System.Drawing.Size(144, 20)
        Me.txtNombreDeduccion3.TabIndex = 57
        Me.txtNombreDeduccion3.Tag = "CM"
        '
        'txtNombreDeduccion2
        '
        Me.txtNombreDeduccion2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrincipalBindingSource, "NombreDeduccion2", True))
        Me.txtNombreDeduccion2.Location = New System.Drawing.Point(88, 45)
        Me.txtNombreDeduccion2.MaxLength = 15
        Me.txtNombreDeduccion2.Name = "txtNombreDeduccion2"
        Me.txtNombreDeduccion2.Size = New System.Drawing.Size(144, 20)
        Me.txtNombreDeduccion2.TabIndex = 56
        Me.txtNombreDeduccion2.Tag = "CM"
        '
        'txtNombreDeduccion1
        '
        Me.txtNombreDeduccion1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrincipalBindingSource, "NombreDeduccion1", True))
        Me.txtNombreDeduccion1.Location = New System.Drawing.Point(89, 17)
        Me.txtNombreDeduccion1.MaxLength = 15
        Me.txtNombreDeduccion1.Name = "txtNombreDeduccion1"
        Me.txtNombreDeduccion1.Size = New System.Drawing.Size(144, 20)
        Me.txtNombreDeduccion1.TabIndex = 55
        Me.txtNombreDeduccion1.Tag = "CM"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(6, 127)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(71, 13)
        Me.Label44.TabIndex = 4
        Me.Label44.Text = "Deducción 5:"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(6, 101)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(71, 13)
        Me.Label45.TabIndex = 3
        Me.Label45.Text = "Deducción 4:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(6, 74)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(71, 13)
        Me.Label46.TabIndex = 2
        Me.Label46.Text = "Deducción 3:"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(7, 48)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(71, 13)
        Me.Label47.TabIndex = 1
        Me.Label47.Text = "Deducción 2:"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(7, 20)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(71, 13)
        Me.Label48.TabIndex = 0
        Me.Label48.Text = "Deducción 1:"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.txtNombreIngreso5)
        Me.GroupBox10.Controls.Add(Me.txtNombreIngreso4)
        Me.GroupBox10.Controls.Add(Me.txtNombreIngreso3)
        Me.GroupBox10.Controls.Add(Me.txtNombreIngreso2)
        Me.GroupBox10.Controls.Add(Me.txtNombreIngreso1)
        Me.GroupBox10.Controls.Add(Me.Label43)
        Me.GroupBox10.Controls.Add(Me.Label42)
        Me.GroupBox10.Controls.Add(Me.Label41)
        Me.GroupBox10.Controls.Add(Me.Label40)
        Me.GroupBox10.Controls.Add(Me.Label36)
        Me.GroupBox10.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(218, 161)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Títulos de Ingresos"
        '
        'txtNombreIngreso5
        '
        Me.txtNombreIngreso5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrincipalBindingSource, "NombreIngreso5", True))
        Me.txtNombreIngreso5.Location = New System.Drawing.Point(67, 124)
        Me.txtNombreIngreso5.MaxLength = 15
        Me.txtNombreIngreso5.Name = "txtNombreIngreso5"
        Me.txtNombreIngreso5.Size = New System.Drawing.Size(144, 20)
        Me.txtNombreIngreso5.TabIndex = 54
        Me.txtNombreIngreso5.Tag = "CM"
        '
        'txtNombreIngreso4
        '
        Me.txtNombreIngreso4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrincipalBindingSource, "NombreIngreso4", True))
        Me.txtNombreIngreso4.Location = New System.Drawing.Point(67, 98)
        Me.txtNombreIngreso4.MaxLength = 15
        Me.txtNombreIngreso4.Name = "txtNombreIngreso4"
        Me.txtNombreIngreso4.Size = New System.Drawing.Size(144, 20)
        Me.txtNombreIngreso4.TabIndex = 53
        Me.txtNombreIngreso4.Tag = "CM"
        '
        'txtNombreIngreso3
        '
        Me.txtNombreIngreso3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrincipalBindingSource, "NombreIngreso3", True))
        Me.txtNombreIngreso3.Location = New System.Drawing.Point(67, 71)
        Me.txtNombreIngreso3.MaxLength = 15
        Me.txtNombreIngreso3.Name = "txtNombreIngreso3"
        Me.txtNombreIngreso3.Size = New System.Drawing.Size(144, 20)
        Me.txtNombreIngreso3.TabIndex = 52
        Me.txtNombreIngreso3.Tag = "CM"
        '
        'txtNombreIngreso2
        '
        Me.txtNombreIngreso2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrincipalBindingSource, "NombreIngreso2", True))
        Me.txtNombreIngreso2.Location = New System.Drawing.Point(67, 45)
        Me.txtNombreIngreso2.MaxLength = 15
        Me.txtNombreIngreso2.Name = "txtNombreIngreso2"
        Me.txtNombreIngreso2.Size = New System.Drawing.Size(144, 20)
        Me.txtNombreIngreso2.TabIndex = 51
        Me.txtNombreIngreso2.Tag = "CM"
        '
        'txtNombreIngreso1
        '
        Me.txtNombreIngreso1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrincipalBindingSource, "NombreIngreso1", True))
        Me.txtNombreIngreso1.Location = New System.Drawing.Point(68, 17)
        Me.txtNombreIngreso1.MaxLength = 15
        Me.txtNombreIngreso1.Name = "txtNombreIngreso1"
        Me.txtNombreIngreso1.Size = New System.Drawing.Size(144, 20)
        Me.txtNombreIngreso1.TabIndex = 50
        Me.txtNombreIngreso1.Tag = "CM"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(6, 127)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(54, 13)
        Me.Label43.TabIndex = 4
        Me.Label43.Text = "Ingreso 5:"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(6, 101)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(54, 13)
        Me.Label42.TabIndex = 3
        Me.Label42.Text = "Ingreso 4:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(6, 74)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(54, 13)
        Me.Label41.TabIndex = 2
        Me.Label41.Text = "Ingreso 3:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(7, 48)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(54, 13)
        Me.Label40.TabIndex = 1
        Me.Label40.Text = "Ingreso 2:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(7, 20)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(54, 13)
        Me.Label36.TabIndex = 0
        Me.Label36.Text = "Ingreso 1:"
        '
        'butAceptar
        '
        Me.butAceptar.Location = New System.Drawing.Point(61, 406)
        Me.butAceptar.Name = "butAceptar"
        Me.butAceptar.Size = New System.Drawing.Size(103, 36)
        Me.butAceptar.TabIndex = 0
        Me.butAceptar.Text = "&Aceptar"
        Me.butAceptar.UseVisualStyleBackColor = True
        '
        'butCancelar
        '
        Me.butCancelar.Location = New System.Drawing.Point(391, 406)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(103, 36)
        Me.butCancelar.TabIndex = 1
        Me.butCancelar.Text = "&Cancelar"
        Me.butCancelar.UseVisualStyleBackColor = True
        '
        'PLConfTableAdapter
        '
        Me.PLConfTableAdapter.ClearBeforeFill = True
        '
        'PLCalculoDeduccionesTableAdapter
        '
        Me.PLCalculoDeduccionesTableAdapter.ClearBeforeFill = True
        '
        'PLConfFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 449)
        Me.Controls.Add(Me.butCancelar)
        Me.Controls.Add(Me.butAceptar)
        Me.Controls.Add(Me.tabConfPlanillas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PLConfFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración de Planillas"
        Me.tabConfPlanillas.ResumeLayout(False)
        Me.tabGenerales.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.c1numSalariosMinimos13vo14vo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLConfDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSalarioMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numPorcPatronalINFOP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numPorcPatronalRAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numPorcPatronalSeguroSocial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1numPlanilla14vo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numPlanilla13vo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numPlaniVacaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numPlaniComplementaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numPlanillaActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numPlaniOrdinariasPorMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1dateFechaProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numMesProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numAñoProceso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCalculos.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.c1numPorcCooperativa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numNoPlaniCooperativa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.c1numPorcINJUPEMP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numNoPlaniINJUPEMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.c1numPorcINPREMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numNoPlaniINPREMA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.c1numAplicarImpVecinalHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numNoPlaniImpVecinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.c1numNoPlaniISR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.c1numPorcMaxRAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numPorcRAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numNoPlaniRAP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.c1numPorcMaxDocenteSeguroSocial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numPorcMaxSeguroSocial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numPorcDocenteSeguroSocial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numPorcSeguroSocial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numNoPlaniSeguroSocial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.c1truedbgrdCalcDed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalculoDeduccionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTitulos.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLConfDataSet As RSIContab.PLConfDataSet
    Friend WithEvents PLConfTableAdapter As RSIContab.PLConfDataSetTableAdapters.PLConfTableAdapter
    Friend WithEvents tabConfPlanillas As System.Windows.Forms.TabControl
    Friend WithEvents tabGenerales As System.Windows.Forms.TabPage
    Friend WithEvents tabCalculos As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents c1dateFechaProceso As C1.Win.C1Input.C1DateEdit
    Friend WithEvents c1numMesProceso As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numAñoProceso As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabTitulos As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents c1numPlanillaActual As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numPlaniOrdinariasPorMes As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkBoxEnlazadoContabilidad As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkUsarSecciones As System.Windows.Forms.CheckBox
    Friend WithEvents chkUsarDepartamentos As System.Windows.Forms.CheckBox
    Friend WithEvents chkUsarSedes As System.Windows.Forms.CheckBox
    Friend WithEvents c1numPlanilla14vo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numPlanilla13vo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numPlaniVacaciones As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numPlaniComplementaria As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents c1numPorcPatronalINFOP As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numPorcPatronalRAP As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numPorcPatronalSeguroSocial As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents c1numNoPlaniSeguroSocial As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbSeguro As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents c1numPorcMaxDocenteSeguroSocial As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numPorcMaxSeguroSocial As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numPorcDocenteSeguroSocial As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numPorcSeguroSocial As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents c1numNoPlaniISR As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmbImpRenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents c1numPorcMaxRAP As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numPorcRAP As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents c1numNoPlaniRAP As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbRAP As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCalcularImpVecinal As System.Windows.Forms.CheckBox
    Friend WithEvents c1numNoPlaniImpVecinal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cmbImpVecinal As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents c1numAplicarImpVecinalHasta As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents c1numPorcINJUPEMP As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents c1numNoPlaniINJUPEMP As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents cmbINJUPEMP As System.Windows.Forms.ComboBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents c1numPorcINPREMA As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents c1numNoPlaniINPREMA As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents cmbINPREMA As System.Windows.Forms.ComboBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents c1numSalariosMinimos13vo14vo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents c1numSalarioMinimo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents c1numPorcCooperativa As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents c1numNoPlaniCooperativa As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents cmbCooperativa As System.Windows.Forms.ComboBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents radiobutValorCoopOpcional As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutCalcCoopPorcSueldo As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombreDeduccion5 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreDeduccion4 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreDeduccion3 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreDeduccion2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreDeduccion1 As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txtNombreIngreso5 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreIngreso4 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreIngreso3 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreIngreso2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreIngreso1 As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents butAceptar As System.Windows.Forms.Button
    Friend WithEvents butCancelar As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents c1truedbgrdCalcDed As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents CalculoDeduccionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLCalculoDeduccionesTableAdapter As RSIContab.PLConfDataSetTableAdapters.PLCalculoDeduccionesTableAdapter
    Friend WithEvents butExcepciones As System.Windows.Forms.Button
End Class
