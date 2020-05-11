<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CapturaPlanillaFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CapturaPlanillaFrm))
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style6 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style7 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style8 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style9 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style10 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style11 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style12 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style13 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style14 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style15 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style16 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style17 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style18 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style19 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style20 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style21 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style22 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style23 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style24 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style25 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style26 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style27 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style28 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style29 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style30 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style31 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style32 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Me.statusstripPrincipal = New System.Windows.Forms.StatusStrip()
        Me.statusCerrado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusImpreso = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusContabilizado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusAnulado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statuslblAñoMes = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkboxRevisado = New System.Windows.Forms.CheckBox()
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CapturaPlanillaDataSet = New RSIContab.CapturaPlanillaDataSet()
        Me.btnCalcularDeducciones = New System.Windows.Forms.Button()
        Me.c1cmbBanco = New C1.Win.C1List.C1Combo()
        Me.BancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.c1cmbSecciones = New C1.Win.C1List.C1Combo()
        Me.SeccionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.c1cmbDepartamentos = New C1.Win.C1List.C1Combo()
        Me.DeptosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.c1cmbSedes = New C1.Win.C1List.C1Combo()
        Me.SedesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnBuscarEmpleado = New RSIContab.BotonBuscar()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.c1txtCodigoEmpleado = New C1.Win.C1Input.C1TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.c1numDeduccion5 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numDeduccion4 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numDeduccion3 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numDeduccion2 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numDeduccion1 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numINPREMA = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numINJUPEMP = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numImpRenta = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numImpVecinal = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRAP = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numSeguroSocial = New C1.Win.C1Input.C1NumericEdit()
        Me.lblDeduccion5 = New System.Windows.Forms.Label()
        Me.lblDeduccion4 = New System.Windows.Forms.Label()
        Me.lblDeduccion3 = New System.Windows.Forms.Label()
        Me.lblDeduccion2 = New System.Windows.Forms.Label()
        Me.lblDeduccion1 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.c1numIngreso5 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numIngreso4 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numIngreso3 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numIngreso2 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numIngreso1 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numVacaciones = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numDepreciacion = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numCombustible = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numTransporte = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numBonificaciones = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numComisiones = New C1.Win.C1Input.C1NumericEdit()
        Me.lblIngreso5 = New System.Windows.Forms.Label()
        Me.lblIngreso4 = New System.Windows.Forms.Label()
        Me.lblIngreso3 = New System.Windows.Forms.Label()
        Me.lblIngreso2 = New System.Windows.Forms.Label()
        Me.lblIngreso1 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTotHorasVal = New System.Windows.Forms.Label()
        Me.lblTotHoras = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.c1numValExtrasDobles = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numValExtras75 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numValExtras50 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numValExtras25 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numExtrasDobles = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numExtras75 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numExtras50 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numExtras25 = New C1.Win.C1Input.C1NumericEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblNormalDevengado = New System.Windows.Forms.Label()
        Me.c1numValHorasTarde = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numValDiasFeriados = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numHorasTarde = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numDiasFeriados = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numDiasTrabajados = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numValDiasTrab = New C1.Win.C1Input.C1NumericEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.c1truedbgrdOtrasDed = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.OtrasDedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblSueldoNeto = New System.Windows.Forms.Label()
        Me.lblTotOtrasDed = New System.Windows.Forms.Label()
        Me.lblTotDeducciones = New System.Windows.Forms.Label()
        Me.lblTotOtrosIng = New System.Windows.Forms.Label()
        Me.lblTotIngBruto = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.PLPlanillasTableAdapter = New RSIContab.CapturaPlanillaDataSetTableAdapters.PLPlanillasTableAdapter()
        Me.PLSedesTableAdapter = New RSIContab.CapturaPlanillaDataSetTableAdapters.PLSedesTableAdapter()
        Me.PLSeccionesTableAdapter = New RSIContab.CapturaPlanillaDataSetTableAdapters.PLSeccionesTableAdapter()
        Me.PLBancosTableAdapter = New RSIContab.CapturaPlanillaDataSetTableAdapters.PLBancosTableAdapter()
        Me.PLPlanillasOTTableAdapter = New RSIContab.CapturaPlanillaDataSetTableAdapters.PLPlanillasOTTableAdapter()
        Me.PLDepartamentosTableAdapter = New RSIContab.CapturaPlanillaDataSetTableAdapters.PLDepartamentosTableAdapter()
        Me.DataNavBarPrincipal = New RSIContab.DataNavBar()
        Me.statusstripPrincipal.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CapturaPlanillaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1cmbBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1cmbSecciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeccionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1cmbDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeptosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1cmbSedes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SedesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtCodigoEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.c1numDeduccion5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numDeduccion4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numDeduccion3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numDeduccion2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numDeduccion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numINPREMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numINJUPEMP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numImpRenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numImpVecinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSeguroSocial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.c1numIngreso5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numIngreso4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numIngreso3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numIngreso2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numIngreso1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numVacaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numDepreciacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numTransporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numBonificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numComisiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.c1numValExtrasDobles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numValExtras75, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numValExtras50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numValExtras25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numExtrasDobles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numExtras75, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numExtras50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numExtras25, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.c1numValHorasTarde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numValDiasFeriados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numHorasTarde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numDiasFeriados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numDiasTrabajados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numValDiasTrab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.c1truedbgrdOtrasDed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtrasDedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusstripPrincipal
        '
        Me.statusstripPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusCerrado, Me.statusImpreso, Me.statusContabilizado, Me.statusAnulado, Me.statuslblAñoMes})
        Me.statusstripPrincipal.Location = New System.Drawing.Point(0, 512)
        Me.statusstripPrincipal.Name = "statusstripPrincipal"
        Me.statusstripPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.statusstripPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.statusstripPrincipal.Size = New System.Drawing.Size(695, 22)
        Me.statusstripPrincipal.TabIndex = 49
        '
        'statusCerrado
        '
        Me.statusCerrado.ForeColor = System.Drawing.Color.DarkBlue
        Me.statusCerrado.Image = CType(resources.GetObject("statusCerrado.Image"), System.Drawing.Image)
        Me.statusCerrado.ImageTransparentColor = System.Drawing.Color.Black
        Me.statusCerrado.Margin = New System.Windows.Forms.Padding(5, 3, 0, 2)
        Me.statusCerrado.Name = "statusCerrado"
        Me.statusCerrado.Size = New System.Drawing.Size(65, 17)
        Me.statusCerrado.Text = "Cerrado"
        Me.statusCerrado.Visible = False
        '
        'statusImpreso
        '
        Me.statusImpreso.ForeColor = System.Drawing.Color.DarkBlue
        Me.statusImpreso.Image = CType(resources.GetObject("statusImpreso.Image"), System.Drawing.Image)
        Me.statusImpreso.ImageTransparentColor = System.Drawing.Color.Black
        Me.statusImpreso.Margin = New System.Windows.Forms.Padding(5, 3, 0, 2)
        Me.statusImpreso.Name = "statusImpreso"
        Me.statusImpreso.Size = New System.Drawing.Size(66, 17)
        Me.statusImpreso.Text = "Impreso"
        Me.statusImpreso.Visible = False
        '
        'statusContabilizado
        '
        Me.statusContabilizado.ForeColor = System.Drawing.Color.DarkBlue
        Me.statusContabilizado.Image = CType(resources.GetObject("statusContabilizado.Image"), System.Drawing.Image)
        Me.statusContabilizado.ImageTransparentColor = System.Drawing.Color.Black
        Me.statusContabilizado.Margin = New System.Windows.Forms.Padding(5, 3, 0, 2)
        Me.statusContabilizado.Name = "statusContabilizado"
        Me.statusContabilizado.Size = New System.Drawing.Size(96, 17)
        Me.statusContabilizado.Text = "Contabilizado"
        Me.statusContabilizado.Visible = False
        '
        'statusAnulado
        '
        Me.statusAnulado.ForeColor = System.Drawing.Color.DarkBlue
        Me.statusAnulado.Image = CType(resources.GetObject("statusAnulado.Image"), System.Drawing.Image)
        Me.statusAnulado.ImageTransparentColor = System.Drawing.Color.Black
        Me.statusAnulado.Margin = New System.Windows.Forms.Padding(5, 3, 0, 2)
        Me.statusAnulado.Name = "statusAnulado"
        Me.statusAnulado.Size = New System.Drawing.Size(68, 17)
        Me.statusAnulado.Text = "Anulado"
        Me.statusAnulado.Visible = False
        '
        'statuslblAñoMes
        '
        Me.statuslblAñoMes.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.statuslblAñoMes.ForeColor = System.Drawing.Color.DarkBlue
        Me.statuslblAñoMes.Margin = New System.Windows.Forms.Padding(5, 3, 0, 2)
        Me.statuslblAñoMes.Name = "statuslblAñoMes"
        Me.statuslblAñoMes.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.statuslblAñoMes.Size = New System.Drawing.Size(14, 17)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkboxRevisado)
        Me.GroupBox1.Controls.Add(Me.btnCalcularDeducciones)
        Me.GroupBox1.Controls.Add(Me.c1cmbBanco)
        Me.GroupBox1.Controls.Add(Me.c1cmbSecciones)
        Me.GroupBox1.Controls.Add(Me.c1cmbDepartamentos)
        Me.GroupBox1.Controls.Add(Me.c1cmbSedes)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.btnBuscarEmpleado)
        Me.GroupBox1.Controls.Add(Me.lblBuscar)
        Me.GroupBox1.Controls.Add(Me.c1txtCodigoEmpleado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(685, 96)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        '
        'chkboxRevisado
        '
        Me.chkboxRevisado.AutoSize = True
        Me.chkboxRevisado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PrincipalBindingSource, "DatosRevisados", True))
        Me.chkboxRevisado.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PrincipalBindingSource, "DatosRevisados", True))
        Me.chkboxRevisado.Enabled = False
        Me.chkboxRevisado.Location = New System.Drawing.Point(454, 16)
        Me.chkboxRevisado.Name = "chkboxRevisado"
        Me.chkboxRevisado.Size = New System.Drawing.Size(71, 17)
        Me.chkboxRevisado.TabIndex = 73
        Me.chkboxRevisado.Tag = "CM"
        Me.chkboxRevisado.Text = "Revisado"
        Me.chkboxRevisado.UseVisualStyleBackColor = True
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLPlanillas"
        Me.PrincipalBindingSource.DataSource = Me.CapturaPlanillaDataSet
        '
        'CapturaPlanillaDataSet
        '
        Me.CapturaPlanillaDataSet.DataSetName = "CapturaPlanillaDataSet"
        Me.CapturaPlanillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnCalcularDeducciones
        '
        Me.btnCalcularDeducciones.Location = New System.Drawing.Point(530, 13)
        Me.btnCalcularDeducciones.Name = "btnCalcularDeducciones"
        Me.btnCalcularDeducciones.Size = New System.Drawing.Size(123, 23)
        Me.btnCalcularDeducciones.TabIndex = 72
        Me.btnCalcularDeducciones.Tag = "HABILITARNOEDIT"
        Me.btnCalcularDeducciones.Text = "&Calcular Deducciones"
        Me.btnCalcularDeducciones.UseVisualStyleBackColor = True
        '
        'c1cmbBanco
        '
        Me.c1cmbBanco.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.c1cmbBanco.Caption = ""
        Me.c1cmbBanco.CaptionHeight = 17
        Me.c1cmbBanco.CaptionStyle = Style1
        Me.c1cmbBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.c1cmbBanco.ColumnCaptionHeight = 17
        Me.c1cmbBanco.ColumnFooterHeight = 17
        Me.c1cmbBanco.ColumnWidth = 150
        Me.c1cmbBanco.ContentHeight = 15
        Me.c1cmbBanco.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PrincipalBindingSource, "Banco", True))
        Me.c1cmbBanco.DataSource = Me.BancosBindingSource
        Me.c1cmbBanco.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.c1cmbBanco.DisplayMember = "Banco"
        Me.c1cmbBanco.EditorBackColor = System.Drawing.SystemColors.Window
        Me.c1cmbBanco.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1cmbBanco.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.c1cmbBanco.EditorHeight = 15
        Me.c1cmbBanco.EvenRowStyle = Style2
        Me.c1cmbBanco.FooterStyle = Style3
        Me.c1cmbBanco.HeadingStyle = Style4
        Me.c1cmbBanco.HighLightRowStyle = Style5
        Me.c1cmbBanco.Images.Add(CType(resources.GetObject("c1cmbBanco.Images"), System.Drawing.Image))
        Me.c1cmbBanco.ItemHeight = 15
        Me.c1cmbBanco.Location = New System.Drawing.Point(381, 67)
        Me.c1cmbBanco.MatchEntryTimeout = CType(2000, Long)
        Me.c1cmbBanco.MaxDropDownItems = CType(5, Short)
        Me.c1cmbBanco.MaxLength = 32767
        Me.c1cmbBanco.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.c1cmbBanco.Name = "c1cmbBanco"
        Me.c1cmbBanco.OddRowStyle = Style6
        Me.c1cmbBanco.ReadOnly = True
        Me.c1cmbBanco.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.c1cmbBanco.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.c1cmbBanco.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.c1cmbBanco.SelectedStyle = Style7
        Me.c1cmbBanco.Size = New System.Drawing.Size(172, 21)
        Me.c1cmbBanco.Style = Style8
        Me.c1cmbBanco.TabIndex = 71
        Me.c1cmbBanco.Tag = "CM"
        Me.c1cmbBanco.ValueMember = "Banco"
        Me.c1cmbBanco.PropBag = resources.GetString("c1cmbBanco.PropBag")
        '
        'BancosBindingSource
        '
        Me.BancosBindingSource.DataMember = "PLBancos"
        Me.BancosBindingSource.DataSource = Me.CapturaPlanillaDataSet
        '
        'c1cmbSecciones
        '
        Me.c1cmbSecciones.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.c1cmbSecciones.Caption = ""
        Me.c1cmbSecciones.CaptionHeight = 17
        Me.c1cmbSecciones.CaptionStyle = Style9
        Me.c1cmbSecciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.c1cmbSecciones.ColumnCaptionHeight = 17
        Me.c1cmbSecciones.ColumnFooterHeight = 17
        Me.c1cmbSecciones.ContentHeight = 15
        Me.c1cmbSecciones.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PrincipalBindingSource, "CodigoSeccion", True))
        Me.c1cmbSecciones.DataSource = Me.SeccionesBindingSource
        Me.c1cmbSecciones.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.c1cmbSecciones.DisplayMember = "DescripcionSeccion"
        Me.c1cmbSecciones.EditorBackColor = System.Drawing.SystemColors.Window
        Me.c1cmbSecciones.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1cmbSecciones.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.c1cmbSecciones.EditorHeight = 15
        Me.c1cmbSecciones.EvenRowStyle = Style10
        Me.c1cmbSecciones.FooterStyle = Style11
        Me.c1cmbSecciones.HeadingStyle = Style12
        Me.c1cmbSecciones.HighLightRowStyle = Style13
        Me.c1cmbSecciones.Images.Add(CType(resources.GetObject("c1cmbSecciones.Images"), System.Drawing.Image))
        Me.c1cmbSecciones.ItemHeight = 15
        Me.c1cmbSecciones.Location = New System.Drawing.Point(381, 40)
        Me.c1cmbSecciones.MatchEntryTimeout = CType(2000, Long)
        Me.c1cmbSecciones.MaxDropDownItems = CType(5, Short)
        Me.c1cmbSecciones.MaxLength = 32767
        Me.c1cmbSecciones.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.c1cmbSecciones.Name = "c1cmbSecciones"
        Me.c1cmbSecciones.OddRowStyle = Style14
        Me.c1cmbSecciones.ReadOnly = True
        Me.c1cmbSecciones.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.c1cmbSecciones.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.c1cmbSecciones.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.c1cmbSecciones.SelectedStyle = Style15
        Me.c1cmbSecciones.Size = New System.Drawing.Size(272, 21)
        Me.c1cmbSecciones.Style = Style16
        Me.c1cmbSecciones.TabIndex = 70
        Me.c1cmbSecciones.Tag = "CM"
        Me.c1cmbSecciones.ValueMember = "CodigoSeccion"
        Me.c1cmbSecciones.PropBag = resources.GetString("c1cmbSecciones.PropBag")
        '
        'SeccionesBindingSource
        '
        Me.SeccionesBindingSource.DataMember = "PLSecciones"
        Me.SeccionesBindingSource.DataSource = Me.CapturaPlanillaDataSet
        '
        'c1cmbDepartamentos
        '
        Me.c1cmbDepartamentos.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.c1cmbDepartamentos.Caption = ""
        Me.c1cmbDepartamentos.CaptionHeight = 17
        Me.c1cmbDepartamentos.CaptionStyle = Style17
        Me.c1cmbDepartamentos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.c1cmbDepartamentos.ColumnCaptionHeight = 17
        Me.c1cmbDepartamentos.ColumnFooterHeight = 17
        Me.c1cmbDepartamentos.ContentHeight = 15
        Me.c1cmbDepartamentos.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PrincipalBindingSource, "CodigoDepartamento", True))
        Me.c1cmbDepartamentos.DataSource = Me.DeptosBindingSource
        Me.c1cmbDepartamentos.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.c1cmbDepartamentos.DisplayMember = "DescripcionDepartamento"
        Me.c1cmbDepartamentos.EditorBackColor = System.Drawing.SystemColors.Window
        Me.c1cmbDepartamentos.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1cmbDepartamentos.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.c1cmbDepartamentos.EditorHeight = 15
        Me.c1cmbDepartamentos.EvenRowStyle = Style18
        Me.c1cmbDepartamentos.FooterStyle = Style19
        Me.c1cmbDepartamentos.HeadingStyle = Style20
        Me.c1cmbDepartamentos.HighLightRowStyle = Style21
        Me.c1cmbDepartamentos.Images.Add(CType(resources.GetObject("c1cmbDepartamentos.Images"), System.Drawing.Image))
        Me.c1cmbDepartamentos.ItemHeight = 15
        Me.c1cmbDepartamentos.Location = New System.Drawing.Point(51, 68)
        Me.c1cmbDepartamentos.MatchEntryTimeout = CType(2000, Long)
        Me.c1cmbDepartamentos.MaxDropDownItems = CType(5, Short)
        Me.c1cmbDepartamentos.MaxLength = 32767
        Me.c1cmbDepartamentos.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.c1cmbDepartamentos.Name = "c1cmbDepartamentos"
        Me.c1cmbDepartamentos.OddRowStyle = Style22
        Me.c1cmbDepartamentos.ReadOnly = True
        Me.c1cmbDepartamentos.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.c1cmbDepartamentos.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.c1cmbDepartamentos.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.c1cmbDepartamentos.SelectedStyle = Style23
        Me.c1cmbDepartamentos.Size = New System.Drawing.Size(277, 21)
        Me.c1cmbDepartamentos.Style = Style24
        Me.c1cmbDepartamentos.TabIndex = 69
        Me.c1cmbDepartamentos.Tag = "CM"
        Me.c1cmbDepartamentos.ValueMember = "CodigoDepartamento"
        Me.c1cmbDepartamentos.PropBag = resources.GetString("c1cmbDepartamentos.PropBag")
        '
        'DeptosBindingSource
        '
        Me.DeptosBindingSource.DataMember = "PLDepartamentos"
        Me.DeptosBindingSource.DataSource = Me.CapturaPlanillaDataSet
        '
        'c1cmbSedes
        '
        Me.c1cmbSedes.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.c1cmbSedes.Caption = ""
        Me.c1cmbSedes.CaptionHeight = 17
        Me.c1cmbSedes.CaptionStyle = Style25
        Me.c1cmbSedes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.c1cmbSedes.ColumnCaptionHeight = 17
        Me.c1cmbSedes.ColumnFooterHeight = 17
        Me.c1cmbSedes.ContentHeight = 15
        Me.c1cmbSedes.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PrincipalBindingSource, "CodigoSede", True))
        Me.c1cmbSedes.DataSource = Me.SedesBindingSource
        Me.c1cmbSedes.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.c1cmbSedes.DisplayMember = "DescripcionSede"
        Me.c1cmbSedes.EditorBackColor = System.Drawing.SystemColors.Window
        Me.c1cmbSedes.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1cmbSedes.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.c1cmbSedes.EditorHeight = 15
        Me.c1cmbSedes.EvenRowStyle = Style26
        Me.c1cmbSedes.FooterStyle = Style27
        Me.c1cmbSedes.HeadingStyle = Style28
        Me.c1cmbSedes.HighLightRowStyle = Style29
        Me.c1cmbSedes.Images.Add(CType(resources.GetObject("c1cmbSedes.Images"), System.Drawing.Image))
        Me.c1cmbSedes.ItemHeight = 15
        Me.c1cmbSedes.Location = New System.Drawing.Point(51, 40)
        Me.c1cmbSedes.MatchEntryTimeout = CType(2000, Long)
        Me.c1cmbSedes.MaxDropDownItems = CType(5, Short)
        Me.c1cmbSedes.MaxLength = 32767
        Me.c1cmbSedes.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.c1cmbSedes.Name = "c1cmbSedes"
        Me.c1cmbSedes.OddRowStyle = Style30
        Me.c1cmbSedes.ReadOnly = True
        Me.c1cmbSedes.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.c1cmbSedes.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.c1cmbSedes.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.c1cmbSedes.SelectedStyle = Style31
        Me.c1cmbSedes.Size = New System.Drawing.Size(277, 21)
        Me.c1cmbSedes.Style = Style32
        Me.c1cmbSedes.TabIndex = 68
        Me.c1cmbSedes.Tag = "CM"
        Me.c1cmbSedes.ValueMember = "CodigoSede"
        Me.c1cmbSedes.PropBag = resources.GetString("c1cmbSedes.PropBag")
        '
        'SedesBindingSource
        '
        Me.SedesBindingSource.DataMember = "PLSedes"
        Me.SedesBindingSource.DataSource = Me.CapturaPlanillaDataSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(334, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Banco:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(330, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Sección:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Depto.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Sede:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(219, 16)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(10, 13)
        Me.lblNombre.TabIndex = 63
        Me.lblNombre.Text = "."
        '
        'btnBuscarEmpleado
        '
        Me.btnBuscarEmpleado.ControlEnlazado = Nothing
        Me.btnBuscarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarEmpleado.Enabled = False
        Me.btnBuscarEmpleado.Location = New System.Drawing.Point(190, 11)
        Me.btnBuscarEmpleado.Name = "btnBuscarEmpleado"
        Me.btnBuscarEmpleado.Size = New System.Drawing.Size(23, 23)
        Me.btnBuscarEmpleado.TabIndex = 60
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(280, 16)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 62
        Me.lblBuscar.Text = "Buscar"
        Me.lblBuscar.Visible = False
        '
        'c1txtCodigoEmpleado
        '
        Me.c1txtCodigoEmpleado.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "CodigoEmpleado", True))
        Me.c1txtCodigoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtCodigoEmpleado.Location = New System.Drawing.Point(68, 13)
        Me.c1txtCodigoEmpleado.Name = "c1txtCodigoEmpleado"
        Me.c1txtCodigoEmpleado.ReadOnly = True
        Me.c1txtCodigoEmpleado.Size = New System.Drawing.Size(122, 20)
        Me.c1txtCodigoEmpleado.TabIndex = 59
        Me.c1txtCodigoEmpleado.Tag = "CO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Empleado:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(5, 127)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(685, 335)
        Me.TabControl1.TabIndex = 52
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(677, 309)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Generales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.c1numDeduccion5)
        Me.GroupBox5.Controls.Add(Me.c1numDeduccion4)
        Me.GroupBox5.Controls.Add(Me.c1numDeduccion3)
        Me.GroupBox5.Controls.Add(Me.c1numDeduccion2)
        Me.GroupBox5.Controls.Add(Me.c1numDeduccion1)
        Me.GroupBox5.Controls.Add(Me.c1numINPREMA)
        Me.GroupBox5.Controls.Add(Me.c1numINJUPEMP)
        Me.GroupBox5.Controls.Add(Me.c1numImpRenta)
        Me.GroupBox5.Controls.Add(Me.c1numImpVecinal)
        Me.GroupBox5.Controls.Add(Me.c1numRAP)
        Me.GroupBox5.Controls.Add(Me.c1numSeguroSocial)
        Me.GroupBox5.Controls.Add(Me.lblDeduccion5)
        Me.GroupBox5.Controls.Add(Me.lblDeduccion4)
        Me.GroupBox5.Controls.Add(Me.lblDeduccion3)
        Me.GroupBox5.Controls.Add(Me.lblDeduccion2)
        Me.GroupBox5.Controls.Add(Me.lblDeduccion1)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Location = New System.Drawing.Point(465, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(206, 300)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Deducciones"
        '
        'c1numDeduccion5
        '
        Me.c1numDeduccion5.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionFija5", True))
        Me.c1numDeduccion5.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numDeduccion5.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numDeduccion5.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numDeduccion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numDeduccion5.Location = New System.Drawing.Point(124, 276)
        Me.c1numDeduccion5.Name = "c1numDeduccion5"
        Me.c1numDeduccion5.ReadOnly = True
        Me.c1numDeduccion5.Size = New System.Drawing.Size(76, 20)
        Me.c1numDeduccion5.TabIndex = 57
        Me.c1numDeduccion5.Tag = "CM"
        Me.c1numDeduccion5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numDeduccion5.Visible = False
        Me.c1numDeduccion5.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numDeduccion4
        '
        Me.c1numDeduccion4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionFija4", True))
        Me.c1numDeduccion4.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numDeduccion4.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numDeduccion4.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numDeduccion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numDeduccion4.Location = New System.Drawing.Point(124, 249)
        Me.c1numDeduccion4.Name = "c1numDeduccion4"
        Me.c1numDeduccion4.ReadOnly = True
        Me.c1numDeduccion4.Size = New System.Drawing.Size(76, 20)
        Me.c1numDeduccion4.TabIndex = 56
        Me.c1numDeduccion4.Tag = "CM"
        Me.c1numDeduccion4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numDeduccion4.Visible = False
        Me.c1numDeduccion4.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numDeduccion3
        '
        Me.c1numDeduccion3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionFija3", True))
        Me.c1numDeduccion3.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numDeduccion3.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numDeduccion3.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numDeduccion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numDeduccion3.Location = New System.Drawing.Point(124, 224)
        Me.c1numDeduccion3.Name = "c1numDeduccion3"
        Me.c1numDeduccion3.ReadOnly = True
        Me.c1numDeduccion3.Size = New System.Drawing.Size(76, 20)
        Me.c1numDeduccion3.TabIndex = 55
        Me.c1numDeduccion3.Tag = "CM"
        Me.c1numDeduccion3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numDeduccion3.Visible = False
        Me.c1numDeduccion3.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numDeduccion2
        '
        Me.c1numDeduccion2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionFija2", True))
        Me.c1numDeduccion2.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numDeduccion2.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numDeduccion2.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numDeduccion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numDeduccion2.Location = New System.Drawing.Point(124, 196)
        Me.c1numDeduccion2.Name = "c1numDeduccion2"
        Me.c1numDeduccion2.ReadOnly = True
        Me.c1numDeduccion2.Size = New System.Drawing.Size(76, 20)
        Me.c1numDeduccion2.TabIndex = 54
        Me.c1numDeduccion2.Tag = "CM"
        Me.c1numDeduccion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numDeduccion2.Visible = False
        Me.c1numDeduccion2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numDeduccion1
        '
        Me.c1numDeduccion1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionFija1", True))
        Me.c1numDeduccion1.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numDeduccion1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numDeduccion1.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numDeduccion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numDeduccion1.Location = New System.Drawing.Point(124, 170)
        Me.c1numDeduccion1.Name = "c1numDeduccion1"
        Me.c1numDeduccion1.ReadOnly = True
        Me.c1numDeduccion1.Size = New System.Drawing.Size(76, 20)
        Me.c1numDeduccion1.TabIndex = 53
        Me.c1numDeduccion1.Tag = "CM"
        Me.c1numDeduccion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numDeduccion1.Visible = False
        Me.c1numDeduccion1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numINPREMA
        '
        Me.c1numINPREMA.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "INPREMA", True))
        Me.c1numINPREMA.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numINPREMA.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numINPREMA.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numINPREMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numINPREMA.Location = New System.Drawing.Point(124, 144)
        Me.c1numINPREMA.Name = "c1numINPREMA"
        Me.c1numINPREMA.ReadOnly = True
        Me.c1numINPREMA.Size = New System.Drawing.Size(76, 20)
        Me.c1numINPREMA.TabIndex = 52
        Me.c1numINPREMA.Tag = "CM"
        Me.c1numINPREMA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numINPREMA.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numINJUPEMP
        '
        Me.c1numINJUPEMP.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "INJUPEMP", True))
        Me.c1numINJUPEMP.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numINJUPEMP.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numINJUPEMP.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numINJUPEMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numINJUPEMP.Location = New System.Drawing.Point(124, 118)
        Me.c1numINJUPEMP.Name = "c1numINJUPEMP"
        Me.c1numINJUPEMP.ReadOnly = True
        Me.c1numINJUPEMP.Size = New System.Drawing.Size(76, 20)
        Me.c1numINJUPEMP.TabIndex = 51
        Me.c1numINJUPEMP.Tag = "CM"
        Me.c1numINJUPEMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numINJUPEMP.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numImpRenta
        '
        Me.c1numImpRenta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "ImpuestoSobreRenta", True))
        Me.c1numImpRenta.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numImpRenta.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numImpRenta.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numImpRenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numImpRenta.Location = New System.Drawing.Point(124, 92)
        Me.c1numImpRenta.Name = "c1numImpRenta"
        Me.c1numImpRenta.ReadOnly = True
        Me.c1numImpRenta.Size = New System.Drawing.Size(76, 20)
        Me.c1numImpRenta.TabIndex = 50
        Me.c1numImpRenta.Tag = "CM"
        Me.c1numImpRenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numImpRenta.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numImpVecinal
        '
        Me.c1numImpVecinal.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "ImpuestoVecinal", True))
        Me.c1numImpVecinal.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numImpVecinal.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numImpVecinal.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numImpVecinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numImpVecinal.Location = New System.Drawing.Point(124, 66)
        Me.c1numImpVecinal.Name = "c1numImpVecinal"
        Me.c1numImpVecinal.ReadOnly = True
        Me.c1numImpVecinal.Size = New System.Drawing.Size(76, 20)
        Me.c1numImpVecinal.TabIndex = 49
        Me.c1numImpVecinal.Tag = "CM"
        Me.c1numImpVecinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numImpVecinal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRAP
        '
        Me.c1numRAP.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "RAP", True))
        Me.c1numRAP.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRAP.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRAP.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRAP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRAP.Location = New System.Drawing.Point(124, 42)
        Me.c1numRAP.Name = "c1numRAP"
        Me.c1numRAP.ReadOnly = True
        Me.c1numRAP.Size = New System.Drawing.Size(76, 20)
        Me.c1numRAP.TabIndex = 48
        Me.c1numRAP.Tag = "CM"
        Me.c1numRAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRAP.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numSeguroSocial
        '
        Me.c1numSeguroSocial.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "SeguroSocial", True))
        Me.c1numSeguroSocial.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numSeguroSocial.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numSeguroSocial.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numSeguroSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numSeguroSocial.Location = New System.Drawing.Point(124, 16)
        Me.c1numSeguroSocial.Name = "c1numSeguroSocial"
        Me.c1numSeguroSocial.ReadOnly = True
        Me.c1numSeguroSocial.Size = New System.Drawing.Size(76, 20)
        Me.c1numSeguroSocial.TabIndex = 47
        Me.c1numSeguroSocial.Tag = "CM"
        Me.c1numSeguroSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSeguroSocial.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblDeduccion5
        '
        Me.lblDeduccion5.AutoSize = True
        Me.lblDeduccion5.Location = New System.Drawing.Point(6, 279)
        Me.lblDeduccion5.Name = "lblDeduccion5"
        Me.lblDeduccion5.Size = New System.Drawing.Size(71, 13)
        Me.lblDeduccion5.TabIndex = 12
        Me.lblDeduccion5.Text = "Deducción 5:"
        Me.lblDeduccion5.Visible = False
        '
        'lblDeduccion4
        '
        Me.lblDeduccion4.AutoSize = True
        Me.lblDeduccion4.Location = New System.Drawing.Point(7, 252)
        Me.lblDeduccion4.Name = "lblDeduccion4"
        Me.lblDeduccion4.Size = New System.Drawing.Size(71, 13)
        Me.lblDeduccion4.TabIndex = 11
        Me.lblDeduccion4.Text = "Deducción 4:"
        Me.lblDeduccion4.Visible = False
        '
        'lblDeduccion3
        '
        Me.lblDeduccion3.AutoSize = True
        Me.lblDeduccion3.Location = New System.Drawing.Point(7, 227)
        Me.lblDeduccion3.Name = "lblDeduccion3"
        Me.lblDeduccion3.Size = New System.Drawing.Size(71, 13)
        Me.lblDeduccion3.TabIndex = 10
        Me.lblDeduccion3.Text = "Deducción 3:"
        Me.lblDeduccion3.Visible = False
        '
        'lblDeduccion2
        '
        Me.lblDeduccion2.AutoSize = True
        Me.lblDeduccion2.Location = New System.Drawing.Point(7, 201)
        Me.lblDeduccion2.Name = "lblDeduccion2"
        Me.lblDeduccion2.Size = New System.Drawing.Size(71, 13)
        Me.lblDeduccion2.TabIndex = 9
        Me.lblDeduccion2.Text = "Deducción 2:"
        Me.lblDeduccion2.Visible = False
        '
        'lblDeduccion1
        '
        Me.lblDeduccion1.AutoSize = True
        Me.lblDeduccion1.Location = New System.Drawing.Point(7, 173)
        Me.lblDeduccion1.Name = "lblDeduccion1"
        Me.lblDeduccion1.Size = New System.Drawing.Size(71, 13)
        Me.lblDeduccion1.TabIndex = 8
        Me.lblDeduccion1.Text = "Deducción 1:"
        Me.lblDeduccion1.Visible = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(7, 147)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(59, 13)
        Me.Label26.TabIndex = 7
        Me.Label26.Text = "INPREMA:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(7, 121)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(64, 13)
        Me.Label25.TabIndex = 6
        Me.Label25.Text = "INJUPEMP:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 96)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 13)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Imtpo. S/Renta:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 69)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(77, 13)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Impto. Vecinal:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 45)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(32, 13)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "RAP:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 20)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(76, 13)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Seguro Social:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.c1numIngreso5)
        Me.GroupBox4.Controls.Add(Me.c1numIngreso4)
        Me.GroupBox4.Controls.Add(Me.c1numIngreso3)
        Me.GroupBox4.Controls.Add(Me.c1numIngreso2)
        Me.GroupBox4.Controls.Add(Me.c1numIngreso1)
        Me.GroupBox4.Controls.Add(Me.c1numVacaciones)
        Me.GroupBox4.Controls.Add(Me.c1numDepreciacion)
        Me.GroupBox4.Controls.Add(Me.c1numCombustible)
        Me.GroupBox4.Controls.Add(Me.c1numTransporte)
        Me.GroupBox4.Controls.Add(Me.c1numBonificaciones)
        Me.GroupBox4.Controls.Add(Me.c1numComisiones)
        Me.GroupBox4.Controls.Add(Me.lblIngreso5)
        Me.GroupBox4.Controls.Add(Me.lblIngreso4)
        Me.GroupBox4.Controls.Add(Me.lblIngreso3)
        Me.GroupBox4.Controls.Add(Me.lblIngreso2)
        Me.GroupBox4.Controls.Add(Me.lblIngreso1)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Location = New System.Drawing.Point(238, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(206, 300)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ingresos Adicionales"
        '
        'c1numIngreso5
        '
        Me.c1numIngreso5.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "IngresosAdicionales5", True))
        Me.c1numIngreso5.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numIngreso5.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numIngreso5.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numIngreso5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numIngreso5.Location = New System.Drawing.Point(124, 274)
        Me.c1numIngreso5.Name = "c1numIngreso5"
        Me.c1numIngreso5.ReadOnly = True
        Me.c1numIngreso5.Size = New System.Drawing.Size(76, 20)
        Me.c1numIngreso5.TabIndex = 56
        Me.c1numIngreso5.Tag = "CM"
        Me.c1numIngreso5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numIngreso5.Visible = False
        Me.c1numIngreso5.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numIngreso4
        '
        Me.c1numIngreso4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "IngresosAdicionales4", True))
        Me.c1numIngreso4.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numIngreso4.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numIngreso4.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numIngreso4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numIngreso4.Location = New System.Drawing.Point(124, 248)
        Me.c1numIngreso4.Name = "c1numIngreso4"
        Me.c1numIngreso4.ReadOnly = True
        Me.c1numIngreso4.Size = New System.Drawing.Size(76, 20)
        Me.c1numIngreso4.TabIndex = 55
        Me.c1numIngreso4.Tag = "CM"
        Me.c1numIngreso4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numIngreso4.Visible = False
        Me.c1numIngreso4.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numIngreso3
        '
        Me.c1numIngreso3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "IngresosAdicionales3", True))
        Me.c1numIngreso3.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numIngreso3.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numIngreso3.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numIngreso3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numIngreso3.Location = New System.Drawing.Point(124, 222)
        Me.c1numIngreso3.Name = "c1numIngreso3"
        Me.c1numIngreso3.ReadOnly = True
        Me.c1numIngreso3.Size = New System.Drawing.Size(76, 20)
        Me.c1numIngreso3.TabIndex = 54
        Me.c1numIngreso3.Tag = "CM"
        Me.c1numIngreso3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numIngreso3.Visible = False
        Me.c1numIngreso3.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numIngreso2
        '
        Me.c1numIngreso2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "IngresosAdicionales2", True))
        Me.c1numIngreso2.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numIngreso2.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numIngreso2.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numIngreso2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numIngreso2.Location = New System.Drawing.Point(124, 196)
        Me.c1numIngreso2.Name = "c1numIngreso2"
        Me.c1numIngreso2.ReadOnly = True
        Me.c1numIngreso2.Size = New System.Drawing.Size(76, 20)
        Me.c1numIngreso2.TabIndex = 53
        Me.c1numIngreso2.Tag = "CM"
        Me.c1numIngreso2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numIngreso2.Visible = False
        Me.c1numIngreso2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numIngreso1
        '
        Me.c1numIngreso1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "IngresosAdicionales1", True))
        Me.c1numIngreso1.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numIngreso1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numIngreso1.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numIngreso1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numIngreso1.Location = New System.Drawing.Point(124, 170)
        Me.c1numIngreso1.Name = "c1numIngreso1"
        Me.c1numIngreso1.ReadOnly = True
        Me.c1numIngreso1.Size = New System.Drawing.Size(76, 20)
        Me.c1numIngreso1.TabIndex = 52
        Me.c1numIngreso1.Tag = "CM"
        Me.c1numIngreso1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numIngreso1.Visible = False
        Me.c1numIngreso1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numVacaciones
        '
        Me.c1numVacaciones.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "Vacaciones", True))
        Me.c1numVacaciones.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numVacaciones.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numVacaciones.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numVacaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numVacaciones.Location = New System.Drawing.Point(124, 144)
        Me.c1numVacaciones.Name = "c1numVacaciones"
        Me.c1numVacaciones.ReadOnly = True
        Me.c1numVacaciones.Size = New System.Drawing.Size(76, 20)
        Me.c1numVacaciones.TabIndex = 51
        Me.c1numVacaciones.Tag = "CM"
        Me.c1numVacaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numVacaciones.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numDepreciacion
        '
        Me.c1numDepreciacion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DepreciacionVehiculo", True))
        Me.c1numDepreciacion.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numDepreciacion.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numDepreciacion.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numDepreciacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numDepreciacion.Location = New System.Drawing.Point(124, 118)
        Me.c1numDepreciacion.Name = "c1numDepreciacion"
        Me.c1numDepreciacion.ReadOnly = True
        Me.c1numDepreciacion.Size = New System.Drawing.Size(76, 20)
        Me.c1numDepreciacion.TabIndex = 50
        Me.c1numDepreciacion.Tag = "CM"
        Me.c1numDepreciacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numDepreciacion.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numCombustible
        '
        Me.c1numCombustible.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "Combustible", True))
        Me.c1numCombustible.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numCombustible.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numCombustible.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numCombustible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numCombustible.Location = New System.Drawing.Point(124, 92)
        Me.c1numCombustible.Name = "c1numCombustible"
        Me.c1numCombustible.ReadOnly = True
        Me.c1numCombustible.Size = New System.Drawing.Size(76, 20)
        Me.c1numCombustible.TabIndex = 49
        Me.c1numCombustible.Tag = "CM"
        Me.c1numCombustible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numCombustible.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numTransporte
        '
        Me.c1numTransporte.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "Transporte", True))
        Me.c1numTransporte.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numTransporte.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numTransporte.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numTransporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numTransporte.Location = New System.Drawing.Point(124, 66)
        Me.c1numTransporte.Name = "c1numTransporte"
        Me.c1numTransporte.ReadOnly = True
        Me.c1numTransporte.Size = New System.Drawing.Size(76, 20)
        Me.c1numTransporte.TabIndex = 48
        Me.c1numTransporte.Tag = "CM"
        Me.c1numTransporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numTransporte.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numBonificaciones
        '
        Me.c1numBonificaciones.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "Bonificaciones", True))
        Me.c1numBonificaciones.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numBonificaciones.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numBonificaciones.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numBonificaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numBonificaciones.Location = New System.Drawing.Point(124, 40)
        Me.c1numBonificaciones.Name = "c1numBonificaciones"
        Me.c1numBonificaciones.ReadOnly = True
        Me.c1numBonificaciones.Size = New System.Drawing.Size(76, 20)
        Me.c1numBonificaciones.TabIndex = 47
        Me.c1numBonificaciones.Tag = "CM"
        Me.c1numBonificaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numBonificaciones.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numComisiones
        '
        Me.c1numComisiones.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "Comisiones", True))
        Me.c1numComisiones.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numComisiones.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numComisiones.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numComisiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numComisiones.Location = New System.Drawing.Point(124, 16)
        Me.c1numComisiones.Name = "c1numComisiones"
        Me.c1numComisiones.ReadOnly = True
        Me.c1numComisiones.Size = New System.Drawing.Size(76, 20)
        Me.c1numComisiones.TabIndex = 46
        Me.c1numComisiones.Tag = "CM"
        Me.c1numComisiones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numComisiones.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblIngreso5
        '
        Me.lblIngreso5.AutoSize = True
        Me.lblIngreso5.Location = New System.Drawing.Point(6, 277)
        Me.lblIngreso5.Name = "lblIngreso5"
        Me.lblIngreso5.Size = New System.Drawing.Size(54, 13)
        Me.lblIngreso5.TabIndex = 11
        Me.lblIngreso5.Text = "Ingreso 5:"
        Me.lblIngreso5.Visible = False
        '
        'lblIngreso4
        '
        Me.lblIngreso4.AutoSize = True
        Me.lblIngreso4.Location = New System.Drawing.Point(6, 251)
        Me.lblIngreso4.Name = "lblIngreso4"
        Me.lblIngreso4.Size = New System.Drawing.Size(54, 13)
        Me.lblIngreso4.TabIndex = 10
        Me.lblIngreso4.Text = "Ingreso 4:"
        Me.lblIngreso4.Visible = False
        '
        'lblIngreso3
        '
        Me.lblIngreso3.AutoSize = True
        Me.lblIngreso3.Location = New System.Drawing.Point(6, 225)
        Me.lblIngreso3.Name = "lblIngreso3"
        Me.lblIngreso3.Size = New System.Drawing.Size(54, 13)
        Me.lblIngreso3.TabIndex = 9
        Me.lblIngreso3.Text = "Ingreso 3:"
        Me.lblIngreso3.Visible = False
        '
        'lblIngreso2
        '
        Me.lblIngreso2.AutoSize = True
        Me.lblIngreso2.Location = New System.Drawing.Point(6, 199)
        Me.lblIngreso2.Name = "lblIngreso2"
        Me.lblIngreso2.Size = New System.Drawing.Size(54, 13)
        Me.lblIngreso2.TabIndex = 8
        Me.lblIngreso2.Text = "Ingreso 2:"
        Me.lblIngreso2.Visible = False
        '
        'lblIngreso1
        '
        Me.lblIngreso1.AutoSize = True
        Me.lblIngreso1.Location = New System.Drawing.Point(6, 173)
        Me.lblIngreso1.Name = "lblIngreso1"
        Me.lblIngreso1.Size = New System.Drawing.Size(54, 13)
        Me.lblIngreso1.TabIndex = 7
        Me.lblIngreso1.Text = "Ingreso 1:"
        Me.lblIngreso1.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 147)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 13)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Vacaciones:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 125)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(119, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Vehículo Depreciación:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 99)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(113, 13)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Vehículo Combustible:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 73)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 13)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Transporte:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 47)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Bonificaciones:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Comisiones:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotHorasVal)
        Me.GroupBox3.Controls.Add(Me.lblTotHoras)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.c1numValExtrasDobles)
        Me.GroupBox3.Controls.Add(Me.c1numValExtras75)
        Me.GroupBox3.Controls.Add(Me.c1numValExtras50)
        Me.GroupBox3.Controls.Add(Me.c1numValExtras25)
        Me.GroupBox3.Controls.Add(Me.c1numExtrasDobles)
        Me.GroupBox3.Controls.Add(Me.c1numExtras75)
        Me.GroupBox3.Controls.Add(Me.c1numExtras50)
        Me.GroupBox3.Controls.Add(Me.c1numExtras25)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 143)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(221, 160)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Horas Extras"
        '
        'lblTotHorasVal
        '
        Me.lblTotHorasVal.Location = New System.Drawing.Point(139, 126)
        Me.lblTotHorasVal.Name = "lblTotHorasVal"
        Me.lblTotHorasVal.Size = New System.Drawing.Size(76, 24)
        Me.lblTotHorasVal.TabIndex = 56
        Me.lblTotHorasVal.Text = "0.00"
        Me.lblTotHorasVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotHoras
        '
        Me.lblTotHoras.Location = New System.Drawing.Point(77, 126)
        Me.lblTotHoras.Name = "lblTotHoras"
        Me.lblTotHoras.Size = New System.Drawing.Size(56, 24)
        Me.lblTotHoras.TabIndex = 55
        Me.lblTotHoras.Text = "0.00"
        Me.lblTotHoras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 127)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Total:"
        '
        'c1numValExtrasDobles
        '
        Me.c1numValExtrasDobles.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "ValorHorasExtrasDobles", True))
        Me.c1numValExtrasDobles.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numValExtrasDobles.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numValExtrasDobles.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numValExtrasDobles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numValExtrasDobles.Location = New System.Drawing.Point(139, 101)
        Me.c1numValExtrasDobles.Name = "c1numValExtrasDobles"
        Me.c1numValExtrasDobles.ReadOnly = True
        Me.c1numValExtrasDobles.Size = New System.Drawing.Size(76, 20)
        Me.c1numValExtrasDobles.TabIndex = 53
        Me.c1numValExtrasDobles.Tag = Nothing
        Me.c1numValExtrasDobles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numValExtrasDobles.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numValExtras75
        '
        Me.c1numValExtras75.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "ValorHorasExtras75", True))
        Me.c1numValExtras75.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numValExtras75.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numValExtras75.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numValExtras75.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numValExtras75.Location = New System.Drawing.Point(139, 75)
        Me.c1numValExtras75.Name = "c1numValExtras75"
        Me.c1numValExtras75.ReadOnly = True
        Me.c1numValExtras75.Size = New System.Drawing.Size(76, 20)
        Me.c1numValExtras75.TabIndex = 52
        Me.c1numValExtras75.Tag = Nothing
        Me.c1numValExtras75.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numValExtras75.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numValExtras50
        '
        Me.c1numValExtras50.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "ValorHorasExtras50", True))
        Me.c1numValExtras50.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numValExtras50.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numValExtras50.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numValExtras50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numValExtras50.Location = New System.Drawing.Point(139, 49)
        Me.c1numValExtras50.Name = "c1numValExtras50"
        Me.c1numValExtras50.ReadOnly = True
        Me.c1numValExtras50.Size = New System.Drawing.Size(76, 20)
        Me.c1numValExtras50.TabIndex = 51
        Me.c1numValExtras50.Tag = Nothing
        Me.c1numValExtras50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numValExtras50.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numValExtras25
        '
        Me.c1numValExtras25.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "ValorHorasExtras25", True))
        Me.c1numValExtras25.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numValExtras25.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numValExtras25.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numValExtras25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numValExtras25.Location = New System.Drawing.Point(139, 23)
        Me.c1numValExtras25.Name = "c1numValExtras25"
        Me.c1numValExtras25.ReadOnly = True
        Me.c1numValExtras25.Size = New System.Drawing.Size(76, 20)
        Me.c1numValExtras25.TabIndex = 50
        Me.c1numValExtras25.Tag = Nothing
        Me.c1numValExtras25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numValExtras25.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numExtrasDobles
        '
        Me.c1numExtrasDobles.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "HorasExtrasDobles", True))
        Me.c1numExtrasDobles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numExtrasDobles.Location = New System.Drawing.Point(95, 100)
        Me.c1numExtrasDobles.Name = "c1numExtrasDobles"
        Me.c1numExtrasDobles.ReadOnly = True
        Me.c1numExtrasDobles.Size = New System.Drawing.Size(38, 20)
        Me.c1numExtrasDobles.TabIndex = 49
        Me.c1numExtrasDobles.Tag = "CM"
        Me.c1numExtrasDobles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numExtrasDobles.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numExtras75
        '
        Me.c1numExtras75.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "HorasExtras75", True))
        Me.c1numExtras75.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numExtras75.Location = New System.Drawing.Point(95, 74)
        Me.c1numExtras75.Name = "c1numExtras75"
        Me.c1numExtras75.ReadOnly = True
        Me.c1numExtras75.Size = New System.Drawing.Size(38, 20)
        Me.c1numExtras75.TabIndex = 48
        Me.c1numExtras75.Tag = "CM"
        Me.c1numExtras75.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numExtras75.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numExtras50
        '
        Me.c1numExtras50.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "HorasExtras50", True))
        Me.c1numExtras50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numExtras50.Location = New System.Drawing.Point(95, 48)
        Me.c1numExtras50.Name = "c1numExtras50"
        Me.c1numExtras50.ReadOnly = True
        Me.c1numExtras50.Size = New System.Drawing.Size(38, 20)
        Me.c1numExtras50.TabIndex = 47
        Me.c1numExtras50.Tag = "CM"
        Me.c1numExtras50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numExtras50.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numExtras25
        '
        Me.c1numExtras25.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "HorasExtras25", True))
        Me.c1numExtras25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numExtras25.Location = New System.Drawing.Point(95, 23)
        Me.c1numExtras25.Name = "c1numExtras25"
        Me.c1numExtras25.ReadOnly = True
        Me.c1numExtras25.Size = New System.Drawing.Size(38, 20)
        Me.c1numExtras25.TabIndex = 46
        Me.c1numExtras25.Tag = "CM"
        Me.c1numExtras25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numExtras25.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Dobles:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "75%:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "50%:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "25%:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblNormalDevengado)
        Me.GroupBox2.Controls.Add(Me.c1numValHorasTarde)
        Me.GroupBox2.Controls.Add(Me.c1numValDiasFeriados)
        Me.GroupBox2.Controls.Add(Me.c1numHorasTarde)
        Me.GroupBox2.Controls.Add(Me.c1numDiasFeriados)
        Me.GroupBox2.Controls.Add(Me.c1numDiasTrabajados)
        Me.GroupBox2.Controls.Add(Me.c1numValDiasTrab)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(220, 134)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Normal Devengado"
        '
        'lblNormalDevengado
        '
        Me.lblNormalDevengado.Location = New System.Drawing.Point(138, 105)
        Me.lblNormalDevengado.Name = "lblNormalDevengado"
        Me.lblNormalDevengado.Size = New System.Drawing.Size(76, 24)
        Me.lblNormalDevengado.TabIndex = 51
        Me.lblNormalDevengado.Text = "0.00"
        Me.lblNormalDevengado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'c1numValHorasTarde
        '
        Me.c1numValHorasTarde.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "ValorHorastarde", True))
        Me.c1numValHorasTarde.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numValHorasTarde.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numValHorasTarde.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numValHorasTarde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numValHorasTarde.Location = New System.Drawing.Point(138, 73)
        Me.c1numValHorasTarde.Name = "c1numValHorasTarde"
        Me.c1numValHorasTarde.ReadOnly = True
        Me.c1numValHorasTarde.Size = New System.Drawing.Size(76, 20)
        Me.c1numValHorasTarde.TabIndex = 50
        Me.c1numValHorasTarde.Tag = Nothing
        Me.c1numValHorasTarde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numValHorasTarde.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numValDiasFeriados
        '
        Me.c1numValDiasFeriados.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "SueldoAdicionalFeriados", True))
        Me.c1numValDiasFeriados.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numValDiasFeriados.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numValDiasFeriados.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numValDiasFeriados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numValDiasFeriados.Location = New System.Drawing.Point(138, 47)
        Me.c1numValDiasFeriados.Name = "c1numValDiasFeriados"
        Me.c1numValDiasFeriados.ReadOnly = True
        Me.c1numValDiasFeriados.Size = New System.Drawing.Size(76, 20)
        Me.c1numValDiasFeriados.TabIndex = 49
        Me.c1numValDiasFeriados.Tag = Nothing
        Me.c1numValDiasFeriados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numValDiasFeriados.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numHorasTarde
        '
        Me.c1numHorasTarde.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "HorasTarde", True))
        Me.c1numHorasTarde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numHorasTarde.Location = New System.Drawing.Point(102, 73)
        Me.c1numHorasTarde.Name = "c1numHorasTarde"
        Me.c1numHorasTarde.ReadOnly = True
        Me.c1numHorasTarde.Size = New System.Drawing.Size(30, 20)
        Me.c1numHorasTarde.TabIndex = 48
        Me.c1numHorasTarde.Tag = "CM"
        Me.c1numHorasTarde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numHorasTarde.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numDiasFeriados
        '
        Me.c1numDiasFeriados.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DiasFeriados", True))
        Me.c1numDiasFeriados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numDiasFeriados.Location = New System.Drawing.Point(102, 47)
        Me.c1numDiasFeriados.Name = "c1numDiasFeriados"
        Me.c1numDiasFeriados.ReadOnly = True
        Me.c1numDiasFeriados.Size = New System.Drawing.Size(30, 20)
        Me.c1numDiasFeriados.TabIndex = 47
        Me.c1numDiasFeriados.Tag = "CM"
        Me.c1numDiasFeriados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numDiasFeriados.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numDiasTrabajados
        '
        Me.c1numDiasTrabajados.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DiasTrabajados", True))
        Me.c1numDiasTrabajados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numDiasTrabajados.Location = New System.Drawing.Point(102, 20)
        Me.c1numDiasTrabajados.Name = "c1numDiasTrabajados"
        Me.c1numDiasTrabajados.ReadOnly = True
        Me.c1numDiasTrabajados.Size = New System.Drawing.Size(30, 20)
        Me.c1numDiasTrabajados.TabIndex = 46
        Me.c1numDiasTrabajados.Tag = "CM"
        Me.c1numDiasTrabajados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numDiasTrabajados.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numValDiasTrab
        '
        Me.c1numValDiasTrab.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "SueldoNormal", True))
        Me.c1numValDiasTrab.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numValDiasTrab.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numValDiasTrab.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numValDiasTrab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numValDiasTrab.Location = New System.Drawing.Point(138, 20)
        Me.c1numValDiasTrab.Name = "c1numValDiasTrab"
        Me.c1numValDiasTrab.ReadOnly = True
        Me.c1numValDiasTrab.Size = New System.Drawing.Size(76, 20)
        Me.c1numValDiasTrab.TabIndex = 45
        Me.c1numValDiasTrab.Tag = Nothing
        Me.c1numValDiasTrab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numValDiasTrab.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Normal Devengado:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "-Horas Tarde:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Días Feriados:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Días Trabajados:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.c1truedbgrdOtrasDed)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(677, 309)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalle de Otras Deducciones"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'c1truedbgrdOtrasDed
        '
        Me.c1truedbgrdOtrasDed.AllowAddNew = True
        Me.c1truedbgrdOtrasDed.AllowDelete = True
        Me.c1truedbgrdOtrasDed.DataSource = Me.OtrasDedBindingSource
        Me.c1truedbgrdOtrasDed.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1truedbgrdOtrasDed.Images.Add(CType(resources.GetObject("c1truedbgrdOtrasDed.Images"), System.Drawing.Image))
        Me.c1truedbgrdOtrasDed.Location = New System.Drawing.Point(10, 6)
        Me.c1truedbgrdOtrasDed.Name = "c1truedbgrdOtrasDed"
        Me.c1truedbgrdOtrasDed.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1truedbgrdOtrasDed.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1truedbgrdOtrasDed.PreviewInfo.ZoomFactor = 75.0R
        Me.c1truedbgrdOtrasDed.PrintInfo.PageSettings = CType(resources.GetObject("c1truedbgrdOtrasDed.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1truedbgrdOtrasDed.RowHeight = 17
        Me.c1truedbgrdOtrasDed.Size = New System.Drawing.Size(665, 301)
        Me.c1truedbgrdOtrasDed.TabIndex = 0
        Me.c1truedbgrdOtrasDed.Text = "C1TrueDBGrid1"
        Me.c1truedbgrdOtrasDed.PropBag = resources.GetString("c1truedbgrdOtrasDed.PropBag")
        '
        'OtrasDedBindingSource
        '
        Me.OtrasDedBindingSource.DataMember = "PLPlanillasOT"
        Me.OtrasDedBindingSource.DataSource = Me.CapturaPlanillaDataSet
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblSueldoNeto)
        Me.GroupBox6.Controls.Add(Me.lblTotOtrasDed)
        Me.GroupBox6.Controls.Add(Me.lblTotDeducciones)
        Me.GroupBox6.Controls.Add(Me.lblTotOtrosIng)
        Me.GroupBox6.Controls.Add(Me.lblTotIngBruto)
        Me.GroupBox6.Controls.Add(Me.Label31)
        Me.GroupBox6.Controls.Add(Me.Label30)
        Me.GroupBox6.Controls.Add(Me.Label29)
        Me.GroupBox6.Controls.Add(Me.Label28)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Location = New System.Drawing.Point(5, 463)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(681, 41)
        Me.GroupBox6.TabIndex = 53
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Totales"
        '
        'lblSueldoNeto
        '
        Me.lblSueldoNeto.ForeColor = System.Drawing.Color.Navy
        Me.lblSueldoNeto.Location = New System.Drawing.Point(599, 16)
        Me.lblSueldoNeto.Name = "lblSueldoNeto"
        Me.lblSueldoNeto.Size = New System.Drawing.Size(76, 19)
        Me.lblSueldoNeto.TabIndex = 61
        Me.lblSueldoNeto.Text = "0.00"
        Me.lblSueldoNeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotOtrasDed
        '
        Me.lblTotOtrasDed.ForeColor = System.Drawing.Color.Navy
        Me.lblTotOtrasDed.Location = New System.Drawing.Point(478, 16)
        Me.lblTotOtrasDed.Name = "lblTotOtrasDed"
        Me.lblTotOtrasDed.Size = New System.Drawing.Size(66, 19)
        Me.lblTotOtrasDed.TabIndex = 60
        Me.lblTotOtrasDed.Text = "  "
        Me.lblTotOtrasDed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotDeducciones
        '
        Me.lblTotDeducciones.ForeColor = System.Drawing.Color.Navy
        Me.lblTotDeducciones.Location = New System.Drawing.Point(330, 16)
        Me.lblTotDeducciones.Name = "lblTotDeducciones"
        Me.lblTotDeducciones.Size = New System.Drawing.Size(66, 19)
        Me.lblTotDeducciones.TabIndex = 59
        Me.lblTotDeducciones.Text = "0.00"
        Me.lblTotDeducciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotOtrosIng
        '
        Me.lblTotOtrosIng.ForeColor = System.Drawing.Color.Navy
        Me.lblTotOtrosIng.Location = New System.Drawing.Point(195, 16)
        Me.lblTotOtrosIng.Name = "lblTotOtrosIng"
        Me.lblTotOtrosIng.Size = New System.Drawing.Size(68, 19)
        Me.lblTotOtrosIng.TabIndex = 58
        Me.lblTotOtrosIng.Text = "0.00"
        Me.lblTotOtrosIng.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotIngBruto
        '
        Me.lblTotIngBruto.ForeColor = System.Drawing.Color.Navy
        Me.lblTotIngBruto.Location = New System.Drawing.Point(58, 16)
        Me.lblTotIngBruto.Name = "lblTotIngBruto"
        Me.lblTotIngBruto.Size = New System.Drawing.Size(73, 19)
        Me.lblTotIngBruto.TabIndex = 57
        Me.lblTotIngBruto.Text = "0.00"
        Me.lblTotIngBruto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.Navy
        Me.Label31.Location = New System.Drawing.Point(560, 19)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(33, 13)
        Me.Label31.TabIndex = 4
        Me.Label31.Text = "Neto:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.Navy
        Me.Label30.Location = New System.Drawing.Point(411, 19)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(61, 13)
        Me.Label30.TabIndex = 3
        Me.Label30.Text = "Otras Ded.:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.Navy
        Me.Label29.Location = New System.Drawing.Point(283, 19)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(45, 13)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "Deduc.:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.Navy
        Me.Label28.Location = New System.Drawing.Point(137, 19)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(55, 13)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "Ing. Adic.:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(5, 19)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(56, 13)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Ing. Bruto:"
        '
        'PLPlanillasTableAdapter
        '
        Me.PLPlanillasTableAdapter.ClearBeforeFill = True
        '
        'PLSedesTableAdapter
        '
        Me.PLSedesTableAdapter.ClearBeforeFill = True
        '
        'PLSeccionesTableAdapter
        '
        Me.PLSeccionesTableAdapter.ClearBeforeFill = True
        '
        'PLBancosTableAdapter
        '
        Me.PLBancosTableAdapter.ClearBeforeFill = True
        '
        'PLPlanillasOTTableAdapter
        '
        Me.PLPlanillasOTTableAdapter.ClearBeforeFill = True
        '
        'PLDepartamentosTableAdapter
        '
        Me.PLDepartamentosTableAdapter.ClearBeforeFill = True
        '
        'DataNavBarPrincipal
        '
        Me.DataNavBarPrincipal.BarraDeEstado = Me.statusstripPrincipal
        Me.DataNavBarPrincipal.BindingSourcePrincipal = Me.PrincipalBindingSource
        Me.DataNavBarPrincipal.dbgrdDetalle = Nothing
        Me.DataNavBarPrincipal.Editando = False
        Me.DataNavBarPrincipal.EjecutarAntesCancelar = False
        Me.DataNavBarPrincipal.EjecutarAntesEliminar = False
        Me.DataNavBarPrincipal.EjecutarAntesGrabar = True
        Me.DataNavBarPrincipal.EjecutarAntesModificar = True
        Me.DataNavBarPrincipal.EjecutarAntesNuevo = False
        Me.DataNavBarPrincipal.EjecutarAntesSalir = False
        Me.DataNavBarPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.DataNavBarPrincipal.ModalidadDeshabilitadoTotal = False
        Me.DataNavBarPrincipal.ModalidadSoloLectura = False
        Me.DataNavBarPrincipal.ModificarRegistro = False
        Me.DataNavBarPrincipal.MostrarListaInvPermanente = False
        Me.DataNavBarPrincipal.Name = "DataNavBarPrincipal"
        Me.DataNavBarPrincipal.NuevoRegistro = False
        Me.DataNavBarPrincipal.ResultadoValidacion = Nothing
        Me.DataNavBarPrincipal.Size = New System.Drawing.Size(704, 31)
        Me.DataNavBarPrincipal.TabIndex = 50
        Me.DataNavBarPrincipal.TieneDetalle = False
        Me.DataNavBarPrincipal.UltimaLinDet = CType(0, Short)
        Me.DataNavBarPrincipal.UsarBotonAnularRegistro = False
        Me.DataNavBarPrincipal.UsarBotonCancelar = True
        Me.DataNavBarPrincipal.UsarBotonCerrarDocumento = False
        Me.DataNavBarPrincipal.UsarBotonComentarios = False
        Me.DataNavBarPrincipal.UsarBotonContabilizar = False
        Me.DataNavBarPrincipal.UsarBotonDocumentacion = False
        Me.DataNavBarPrincipal.UsarBotonEliminarRegistro = True
        Me.DataNavBarPrincipal.UsarBotonGuardarRegistro = True
        Me.DataNavBarPrincipal.UsarBotonImprimir = False
        Me.DataNavBarPrincipal.UsarBotonMasOpciones = False
        Me.DataNavBarPrincipal.UsarBotonModificarRegistro = True
        Me.DataNavBarPrincipal.UsarBotonNuevoRegistro = True
        Me.DataNavBarPrincipal.UsarBotonPrimerRegistro = True
        Me.DataNavBarPrincipal.UsarBotonRegistroAnterior = True
        Me.DataNavBarPrincipal.UsarBotonSalir = True
        Me.DataNavBarPrincipal.UsarBotonSiguienteRegistro = True
        Me.DataNavBarPrincipal.UsarBotonUltimoRegistro = True
        Me.DataNavBarPrincipal.UsarBuscar = True
        Me.DataNavBarPrincipal.UsarTextoPosicionRegistro = True
        Me.DataNavBarPrincipal.ValidacionCorrecta = False
        '
        'CapturaPlanillaFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 534)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataNavBarPrincipal)
        Me.Controls.Add(Me.statusstripPrincipal)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "CapturaPlanillaFrm"
        Me.Text = "Edición de Planilla"
        Me.statusstripPrincipal.ResumeLayout(False)
        Me.statusstripPrincipal.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CapturaPlanillaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1cmbBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1cmbSecciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeccionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1cmbDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeptosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1cmbSedes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SedesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtCodigoEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.c1numDeduccion5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numDeduccion4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numDeduccion3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numDeduccion2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numDeduccion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numINPREMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numINJUPEMP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numImpRenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numImpVecinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSeguroSocial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.c1numIngreso5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numIngreso4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numIngreso3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numIngreso2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numIngreso1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numVacaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numDepreciacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numCombustible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numTransporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numBonificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numComisiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.c1numValExtrasDobles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numValExtras75, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numValExtras50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numValExtras25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numExtrasDobles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numExtras75, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numExtras50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numExtras25, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.c1numValHorasTarde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numValDiasFeriados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numHorasTarde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numDiasFeriados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numDiasTrabajados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numValDiasTrab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.c1truedbgrdOtrasDed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtrasDedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CapturaPlanillaDataSet As RSIContab.CapturaPlanillaDataSet
    Friend WithEvents PLPlanillasTableAdapter As RSIContab.CapturaPlanillaDataSetTableAdapters.PLPlanillasTableAdapter
    Friend WithEvents statusstripPrincipal As System.Windows.Forms.StatusStrip
    Friend WithEvents statusCerrado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusImpreso As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusContabilizado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusAnulado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statuslblAñoMes As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataNavBarPrincipal As RSIContab.DataNavBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnBuscarEmpleado As RSIContab.BotonBuscar
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents c1txtCodigoEmpleado As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SedesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLSedesTableAdapter As RSIContab.CapturaPlanillaDataSetTableAdapters.PLSedesTableAdapter
    Friend WithEvents DeptosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SeccionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLSeccionesTableAdapter As RSIContab.CapturaPlanillaDataSetTableAdapters.PLSeccionesTableAdapter
    Friend WithEvents BancosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLBancosTableAdapter As RSIContab.CapturaPlanillaDataSetTableAdapters.PLBancosTableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents c1cmbSedes As C1.Win.C1List.C1Combo
    Friend WithEvents c1cmbDepartamentos As C1.Win.C1List.C1Combo
    Friend WithEvents c1cmbSecciones As C1.Win.C1List.C1Combo
    Friend WithEvents c1cmbBanco As C1.Win.C1List.C1Combo
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents c1numDiasTrabajados As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numValDiasTrab As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblNormalDevengado As System.Windows.Forms.Label
    Friend WithEvents c1numValHorasTarde As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numValDiasFeriados As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numHorasTarde As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numDiasFeriados As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numExtras25 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblTotHorasVal As System.Windows.Forms.Label
    Friend WithEvents lblTotHoras As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents c1numValExtrasDobles As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numValExtras75 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numValExtras50 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numValExtras25 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numExtrasDobles As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numExtras75 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numExtras50 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblIngreso5 As System.Windows.Forms.Label
    Friend WithEvents lblIngreso4 As System.Windows.Forms.Label
    Friend WithEvents lblIngreso3 As System.Windows.Forms.Label
    Friend WithEvents lblIngreso2 As System.Windows.Forms.Label
    Friend WithEvents lblIngreso1 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents c1numIngreso5 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numIngreso4 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numIngreso3 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numIngreso2 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numIngreso1 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numVacaciones As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numDepreciacion As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numCombustible As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numTransporte As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numBonificaciones As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numComisiones As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents c1numDeduccion5 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numDeduccion4 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numDeduccion3 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numDeduccion2 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numDeduccion1 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numINPREMA As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numINJUPEMP As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numImpRenta As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numImpVecinal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRAP As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numSeguroSocial As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblDeduccion5 As System.Windows.Forms.Label
    Friend WithEvents lblDeduccion4 As System.Windows.Forms.Label
    Friend WithEvents lblDeduccion3 As System.Windows.Forms.Label
    Friend WithEvents lblDeduccion2 As System.Windows.Forms.Label
    Friend WithEvents lblDeduccion1 As System.Windows.Forms.Label
    Friend WithEvents OtrasDedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLPlanillasOTTableAdapter As RSIContab.CapturaPlanillaDataSetTableAdapters.PLPlanillasOTTableAdapter
    Friend WithEvents c1truedbgrdOtrasDed As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents PLDepartamentosTableAdapter As RSIContab.CapturaPlanillaDataSetTableAdapters.PLDepartamentosTableAdapter
    Friend WithEvents btnCalcularDeducciones As System.Windows.Forms.Button
    Friend WithEvents chkboxRevisado As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSueldoNeto As System.Windows.Forms.Label
    Friend WithEvents lblTotOtrasDed As System.Windows.Forms.Label
    Friend WithEvents lblTotDeducciones As System.Windows.Forms.Label
    Friend WithEvents lblTotOtrosIng As System.Windows.Forms.Label
    Friend WithEvents lblTotIngBruto As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
End Class
