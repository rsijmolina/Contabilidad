<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeduccionISRFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeduccionISRFrm))
        Me.statusstripPrincipal = New System.Windows.Forms.StatusStrip()
        Me.statusCerrado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusImpreso = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusContabilizado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusAnulado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statuslblAñoMes = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotIngAdicionales = New System.Windows.Forms.Label()
        Me.lblTotalRetenidoPL2 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.c1num14vo = New C1.Win.C1Input.C1NumericEdit()
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLDeduccionISRDataSet = New RSIContab.PLDeduccionISRDataSet()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.c1numIngAdicMes12 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numIngAdicMes11 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numIngAdicMes10 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numIngAdicMes9 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numIngAdicMes8 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numIngAdicMes7 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numIngAdicMes6 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numIngAdicMes5 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numIngAdicMes4 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numIngAdicMes3 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numIngAdicMes2 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numIngAdicMes1 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRetenidoPL2_12 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRetenidoPL2_11 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRetenidoPL2_10 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRetenidoPL2_9 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRetenidoPL2_8 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRetenidoPL2_7 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRetenidoPL2_6 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRetenidoPL2_5 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRetenidoPL2_4 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRetenidoPL2_3 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRetenidoPL2_2 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRetenidoPL2_1 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1num13vo = New C1.Win.C1Input.C1NumericEdit()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblTotalSueldos = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.c1numRetenidoPL1_12 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numSueldoMes12 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRetenidoPL1_11 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numSueldoMes11 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRetenidoPL1_10 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numSueldoMes10 = New C1.Win.C1Input.C1NumericEdit()
        Me.lblTotalRetenidoPL1 = New System.Windows.Forms.Label()
        Me.c1numRetenidoPL1_9 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numSueldoMes9 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRetenidoPL1_8 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numSueldoMes8 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRetenidoPL1_7 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numSueldoMes7 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRetenidoPL1_6 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numSueldoMes6 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRetenidoPL1_5 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numSueldoMes5 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRetenidoPL1_4 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numSueldoMes4 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRetenidoPL1_3 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numSueldoMes3 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRetenidoPL1_2 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numSueldoMes2 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRetenidoPL1_1 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numSueldoMes1 = New C1.Win.C1Input.C1NumericEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotalDeducibles = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.c1numOtros = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numDonaciones = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numSeguroSocial = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numGastosMedicos = New C1.Win.C1Input.C1NumericEdit()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTotalPorRetener = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblTotalRetencion = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.c1numRango3 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRango2 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numRango1 = New C1.Win.C1Input.C1NumericEdit()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.c1truedbgrdTablaISR = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.TablaISRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.c1numNoMesesRetener = New C1.Win.C1Input.C1NumericEdit()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.c1txtCodigoEmpleado = New C1.Win.C1Input.C1TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.btnCalcularISR = New System.Windows.Forms.Button()
        Me.butTotalizar = New System.Windows.Forms.Button()
        Me.PLDeduccionISRTableAdapter = New RSIContab.PLDeduccionISRDataSetTableAdapters.PLDeduccionISRTableAdapter()
        Me.PLTablaISRTableAdapter = New RSIContab.PLDeduccionISRDataSetTableAdapters.PLTablaISRTableAdapter()
        Me.chkboxNoDeducir = New System.Windows.Forms.CheckBox()
        Me.btnBuscarEmpleado = New RSIContab.BotonBuscar()
        Me.DataNavBarPrincipal = New RSIContab.DataNavBar()
        Me.statusstripPrincipal.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1num14vo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLDeduccionISRDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numIngAdicMes12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numIngAdicMes11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numIngAdicMes10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numIngAdicMes9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numIngAdicMes8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numIngAdicMes7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numIngAdicMes6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numIngAdicMes5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numIngAdicMes4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numIngAdicMes3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numIngAdicMes2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numIngAdicMes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL2_12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL2_11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL2_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL2_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL2_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL2_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL2_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL2_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL2_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL2_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL2_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL2_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1num13vo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL1_12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSueldoMes12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL1_11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSueldoMes11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL1_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSueldoMes10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL1_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSueldoMes9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL1_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSueldoMes8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL1_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSueldoMes7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL1_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSueldoMes6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL1_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSueldoMes5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL1_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSueldoMes4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL1_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSueldoMes3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL1_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSueldoMes2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRetenidoPL1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSueldoMes1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.c1numOtros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numDonaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSeguroSocial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numGastosMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.c1numRango3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRango2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numRango1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1truedbgrdTablaISR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaISRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.c1numNoMesesRetener, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtCodigoEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'statusstripPrincipal
        '
        Me.statusstripPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusCerrado, Me.statusImpreso, Me.statusContabilizado, Me.statusAnulado, Me.statuslblAñoMes})
        Me.statusstripPrincipal.Location = New System.Drawing.Point(0, 475)
        Me.statusstripPrincipal.Name = "statusstripPrincipal"
        Me.statusstripPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.statusstripPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.statusstripPrincipal.Size = New System.Drawing.Size(796, 22)
        Me.statusstripPrincipal.TabIndex = 49
        '
        'statusCerrado
        '
        Me.statusCerrado.ForeColor = System.Drawing.Color.DarkBlue
        Me.statusCerrado.Image = Global.RSIContab.My.Resources.Resources.TaskHS
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
        Me.statusImpreso.Image = Global.RSIContab.My.Resources.Resources.PrintHS
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
        Me.statusContabilizado.Image = Global.RSIContab.My.Resources.Resources.book_reportHS
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
        Me.statusAnulado.Image = Global.RSIContab.My.Resources.Resources.RightsRestrictedHS
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
        Me.GroupBox1.Controls.Add(Me.lblTotIngAdicionales)
        Me.GroupBox1.Controls.Add(Me.lblTotalRetenidoPL2)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.c1num14vo)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.c1numIngAdicMes12)
        Me.GroupBox1.Controls.Add(Me.c1numIngAdicMes11)
        Me.GroupBox1.Controls.Add(Me.c1numIngAdicMes10)
        Me.GroupBox1.Controls.Add(Me.c1numIngAdicMes9)
        Me.GroupBox1.Controls.Add(Me.c1numIngAdicMes8)
        Me.GroupBox1.Controls.Add(Me.c1numIngAdicMes7)
        Me.GroupBox1.Controls.Add(Me.c1numIngAdicMes6)
        Me.GroupBox1.Controls.Add(Me.c1numIngAdicMes5)
        Me.GroupBox1.Controls.Add(Me.c1numIngAdicMes4)
        Me.GroupBox1.Controls.Add(Me.c1numIngAdicMes3)
        Me.GroupBox1.Controls.Add(Me.c1numIngAdicMes2)
        Me.GroupBox1.Controls.Add(Me.c1numIngAdicMes1)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL2_12)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL2_11)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL2_10)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL2_9)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL2_8)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL2_7)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL2_6)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL2_5)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL2_4)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL2_3)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL2_2)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL2_1)
        Me.GroupBox1.Controls.Add(Me.c1num13vo)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.lblTotalSueldos)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL1_12)
        Me.GroupBox1.Controls.Add(Me.c1numSueldoMes12)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL1_11)
        Me.GroupBox1.Controls.Add(Me.c1numSueldoMes11)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL1_10)
        Me.GroupBox1.Controls.Add(Me.c1numSueldoMes10)
        Me.GroupBox1.Controls.Add(Me.lblTotalRetenidoPL1)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL1_9)
        Me.GroupBox1.Controls.Add(Me.c1numSueldoMes9)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL1_8)
        Me.GroupBox1.Controls.Add(Me.c1numSueldoMes8)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL1_7)
        Me.GroupBox1.Controls.Add(Me.c1numSueldoMes7)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL1_6)
        Me.GroupBox1.Controls.Add(Me.c1numSueldoMes6)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL1_5)
        Me.GroupBox1.Controls.Add(Me.c1numSueldoMes5)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL1_4)
        Me.GroupBox1.Controls.Add(Me.c1numSueldoMes4)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL1_3)
        Me.GroupBox1.Controls.Add(Me.c1numSueldoMes3)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL1_2)
        Me.GroupBox1.Controls.Add(Me.c1numSueldoMes2)
        Me.GroupBox1.Controls.Add(Me.c1numRetenidoPL1_1)
        Me.GroupBox1.Controls.Add(Me.c1numSueldoMes1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 411)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        '
        'lblTotIngAdicionales
        '
        Me.lblTotIngAdicionales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotIngAdicionales.Location = New System.Drawing.Point(145, 389)
        Me.lblTotIngAdicionales.Name = "lblTotIngAdicionales"
        Me.lblTotIngAdicionales.Size = New System.Drawing.Size(69, 13)
        Me.lblTotIngAdicionales.TabIndex = 106
        Me.lblTotIngAdicionales.Text = "0.00"
        Me.lblTotIngAdicionales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalRetenidoPL2
        '
        Me.lblTotalRetenidoPL2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRetenidoPL2.Location = New System.Drawing.Point(292, 389)
        Me.lblTotalRetenidoPL2.Name = "lblTotalRetenidoPL2"
        Me.lblTotalRetenidoPL2.Size = New System.Drawing.Size(68, 13)
        Me.lblTotalRetenidoPL2.TabIndex = 105
        Me.lblTotalRetenidoPL2.Text = "0.00"
        Me.lblTotalRetenidoPL2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(10, 368)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(34, 13)
        Me.Label31.TabIndex = 104
        Me.Label31.Text = "14vo:"
        '
        'c1num14vo
        '
        Me.c1num14vo.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "Ingreso14vo", True))
        Me.c1num14vo.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1num14vo.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1num14vo.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1num14vo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1num14vo.Location = New System.Drawing.Point(71, 365)
        Me.c1num14vo.Name = "c1num14vo"
        Me.c1num14vo.ReadOnly = True
        Me.c1num14vo.Size = New System.Drawing.Size(68, 20)
        Me.c1num14vo.TabIndex = 103
        Me.c1num14vo.Tag = "CM"
        Me.c1num14vo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1num14vo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLDeduccionISR"
        Me.PrincipalBindingSource.DataSource = Me.PLDeduccionISRDataSet
        '
        'PLDeduccionISRDataSet
        '
        Me.PLDeduccionISRDataSet.DataSetName = "PLDeduccionISRDataSet"
        Me.PLDeduccionISRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(289, 11)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 13)
        Me.Label30.TabIndex = 102
        Me.Label30.Text = "Retenido PL2"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(153, 11)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(52, 13)
        Me.Label23.TabIndex = 101
        Me.Label23.Text = "Ing. Adic."
        '
        'c1numIngAdicMes12
        '
        Me.c1numIngAdicMes12.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "OtrosIngresosMes12", True))
        Me.c1numIngAdicMes12.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numIngAdicMes12.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numIngAdicMes12.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numIngAdicMes12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numIngAdicMes12.Location = New System.Drawing.Point(145, 313)
        Me.c1numIngAdicMes12.Name = "c1numIngAdicMes12"
        Me.c1numIngAdicMes12.ReadOnly = True
        Me.c1numIngAdicMes12.Size = New System.Drawing.Size(68, 20)
        Me.c1numIngAdicMes12.TabIndex = 100
        Me.c1numIngAdicMes12.Tag = "CM"
        Me.c1numIngAdicMes12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numIngAdicMes12.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numIngAdicMes11
        '
        Me.c1numIngAdicMes11.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "OtrosIngresosMes11", True))
        Me.c1numIngAdicMes11.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numIngAdicMes11.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numIngAdicMes11.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numIngAdicMes11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numIngAdicMes11.Location = New System.Drawing.Point(145, 287)
        Me.c1numIngAdicMes11.Name = "c1numIngAdicMes11"
        Me.c1numIngAdicMes11.ReadOnly = True
        Me.c1numIngAdicMes11.Size = New System.Drawing.Size(68, 20)
        Me.c1numIngAdicMes11.TabIndex = 99
        Me.c1numIngAdicMes11.Tag = "CM"
        Me.c1numIngAdicMes11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numIngAdicMes11.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numIngAdicMes10
        '
        Me.c1numIngAdicMes10.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "OtrosIngresosMes10", True))
        Me.c1numIngAdicMes10.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numIngAdicMes10.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numIngAdicMes10.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numIngAdicMes10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numIngAdicMes10.Location = New System.Drawing.Point(145, 261)
        Me.c1numIngAdicMes10.Name = "c1numIngAdicMes10"
        Me.c1numIngAdicMes10.ReadOnly = True
        Me.c1numIngAdicMes10.Size = New System.Drawing.Size(68, 20)
        Me.c1numIngAdicMes10.TabIndex = 98
        Me.c1numIngAdicMes10.Tag = "CM"
        Me.c1numIngAdicMes10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numIngAdicMes10.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numIngAdicMes9
        '
        Me.c1numIngAdicMes9.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "OtrosIngresosMes9", True))
        Me.c1numIngAdicMes9.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numIngAdicMes9.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numIngAdicMes9.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numIngAdicMes9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numIngAdicMes9.Location = New System.Drawing.Point(145, 235)
        Me.c1numIngAdicMes9.Name = "c1numIngAdicMes9"
        Me.c1numIngAdicMes9.ReadOnly = True
        Me.c1numIngAdicMes9.Size = New System.Drawing.Size(68, 20)
        Me.c1numIngAdicMes9.TabIndex = 97
        Me.c1numIngAdicMes9.Tag = "CM"
        Me.c1numIngAdicMes9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numIngAdicMes9.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numIngAdicMes8
        '
        Me.c1numIngAdicMes8.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "OtrosIngresosMes8", True))
        Me.c1numIngAdicMes8.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numIngAdicMes8.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numIngAdicMes8.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numIngAdicMes8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numIngAdicMes8.Location = New System.Drawing.Point(145, 209)
        Me.c1numIngAdicMes8.Name = "c1numIngAdicMes8"
        Me.c1numIngAdicMes8.ReadOnly = True
        Me.c1numIngAdicMes8.Size = New System.Drawing.Size(68, 20)
        Me.c1numIngAdicMes8.TabIndex = 96
        Me.c1numIngAdicMes8.Tag = "CM"
        Me.c1numIngAdicMes8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numIngAdicMes8.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numIngAdicMes7
        '
        Me.c1numIngAdicMes7.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "OtrosIngresosMes7", True))
        Me.c1numIngAdicMes7.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numIngAdicMes7.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numIngAdicMes7.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numIngAdicMes7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numIngAdicMes7.Location = New System.Drawing.Point(145, 184)
        Me.c1numIngAdicMes7.Name = "c1numIngAdicMes7"
        Me.c1numIngAdicMes7.ReadOnly = True
        Me.c1numIngAdicMes7.Size = New System.Drawing.Size(68, 20)
        Me.c1numIngAdicMes7.TabIndex = 95
        Me.c1numIngAdicMes7.Tag = "CM"
        Me.c1numIngAdicMes7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numIngAdicMes7.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numIngAdicMes6
        '
        Me.c1numIngAdicMes6.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "OtrosIngresosMes6", True))
        Me.c1numIngAdicMes6.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numIngAdicMes6.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numIngAdicMes6.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numIngAdicMes6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numIngAdicMes6.Location = New System.Drawing.Point(145, 158)
        Me.c1numIngAdicMes6.Name = "c1numIngAdicMes6"
        Me.c1numIngAdicMes6.ReadOnly = True
        Me.c1numIngAdicMes6.Size = New System.Drawing.Size(68, 20)
        Me.c1numIngAdicMes6.TabIndex = 94
        Me.c1numIngAdicMes6.Tag = "CM"
        Me.c1numIngAdicMes6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numIngAdicMes6.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numIngAdicMes5
        '
        Me.c1numIngAdicMes5.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "OtrosIngresosMes5", True))
        Me.c1numIngAdicMes5.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numIngAdicMes5.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numIngAdicMes5.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numIngAdicMes5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numIngAdicMes5.Location = New System.Drawing.Point(145, 132)
        Me.c1numIngAdicMes5.Name = "c1numIngAdicMes5"
        Me.c1numIngAdicMes5.ReadOnly = True
        Me.c1numIngAdicMes5.Size = New System.Drawing.Size(68, 20)
        Me.c1numIngAdicMes5.TabIndex = 93
        Me.c1numIngAdicMes5.Tag = "CM"
        Me.c1numIngAdicMes5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numIngAdicMes5.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numIngAdicMes4
        '
        Me.c1numIngAdicMes4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "OtrosIngresosMes4", True))
        Me.c1numIngAdicMes4.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numIngAdicMes4.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numIngAdicMes4.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numIngAdicMes4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numIngAdicMes4.Location = New System.Drawing.Point(145, 106)
        Me.c1numIngAdicMes4.Name = "c1numIngAdicMes4"
        Me.c1numIngAdicMes4.ReadOnly = True
        Me.c1numIngAdicMes4.Size = New System.Drawing.Size(68, 20)
        Me.c1numIngAdicMes4.TabIndex = 92
        Me.c1numIngAdicMes4.Tag = "CM"
        Me.c1numIngAdicMes4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numIngAdicMes4.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numIngAdicMes3
        '
        Me.c1numIngAdicMes3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "OtrosIngresosMes3", True))
        Me.c1numIngAdicMes3.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numIngAdicMes3.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numIngAdicMes3.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numIngAdicMes3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numIngAdicMes3.Location = New System.Drawing.Point(145, 80)
        Me.c1numIngAdicMes3.Name = "c1numIngAdicMes3"
        Me.c1numIngAdicMes3.ReadOnly = True
        Me.c1numIngAdicMes3.Size = New System.Drawing.Size(68, 20)
        Me.c1numIngAdicMes3.TabIndex = 91
        Me.c1numIngAdicMes3.Tag = "CM"
        Me.c1numIngAdicMes3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numIngAdicMes3.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numIngAdicMes2
        '
        Me.c1numIngAdicMes2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "OtrosIngresosMes2", True))
        Me.c1numIngAdicMes2.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numIngAdicMes2.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numIngAdicMes2.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numIngAdicMes2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numIngAdicMes2.Location = New System.Drawing.Point(145, 54)
        Me.c1numIngAdicMes2.Name = "c1numIngAdicMes2"
        Me.c1numIngAdicMes2.ReadOnly = True
        Me.c1numIngAdicMes2.Size = New System.Drawing.Size(68, 20)
        Me.c1numIngAdicMes2.TabIndex = 90
        Me.c1numIngAdicMes2.Tag = "CM"
        Me.c1numIngAdicMes2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numIngAdicMes2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numIngAdicMes1
        '
        Me.c1numIngAdicMes1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "OtrosIngresosMes1", True))
        Me.c1numIngAdicMes1.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numIngAdicMes1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numIngAdicMes1.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numIngAdicMes1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numIngAdicMes1.Location = New System.Drawing.Point(145, 31)
        Me.c1numIngAdicMes1.Name = "c1numIngAdicMes1"
        Me.c1numIngAdicMes1.ReadOnly = True
        Me.c1numIngAdicMes1.Size = New System.Drawing.Size(68, 20)
        Me.c1numIngAdicMes1.TabIndex = 89
        Me.c1numIngAdicMes1.Tag = "CM"
        Me.c1numIngAdicMes1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numIngAdicMes1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRetenidoPL2_12
        '
        Me.c1numRetenidoPL2_12.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla2_12", True))
        Me.c1numRetenidoPL2_12.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL2_12.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL2_12.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL2_12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL2_12.Location = New System.Drawing.Point(291, 313)
        Me.c1numRetenidoPL2_12.Name = "c1numRetenidoPL2_12"
        Me.c1numRetenidoPL2_12.ReadOnly = True
        Me.c1numRetenidoPL2_12.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL2_12.TabIndex = 88
        Me.c1numRetenidoPL2_12.Tag = "CM"
        Me.c1numRetenidoPL2_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL2_12.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRetenidoPL2_11
        '
        Me.c1numRetenidoPL2_11.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla2_11", True))
        Me.c1numRetenidoPL2_11.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL2_11.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL2_11.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL2_11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL2_11.Location = New System.Drawing.Point(291, 287)
        Me.c1numRetenidoPL2_11.Name = "c1numRetenidoPL2_11"
        Me.c1numRetenidoPL2_11.ReadOnly = True
        Me.c1numRetenidoPL2_11.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL2_11.TabIndex = 87
        Me.c1numRetenidoPL2_11.Tag = "CM"
        Me.c1numRetenidoPL2_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL2_11.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRetenidoPL2_10
        '
        Me.c1numRetenidoPL2_10.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla2_10", True))
        Me.c1numRetenidoPL2_10.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL2_10.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL2_10.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL2_10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL2_10.Location = New System.Drawing.Point(291, 261)
        Me.c1numRetenidoPL2_10.Name = "c1numRetenidoPL2_10"
        Me.c1numRetenidoPL2_10.ReadOnly = True
        Me.c1numRetenidoPL2_10.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL2_10.TabIndex = 86
        Me.c1numRetenidoPL2_10.Tag = "CM"
        Me.c1numRetenidoPL2_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL2_10.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRetenidoPL2_9
        '
        Me.c1numRetenidoPL2_9.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla2_9", True))
        Me.c1numRetenidoPL2_9.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL2_9.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL2_9.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL2_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL2_9.Location = New System.Drawing.Point(291, 235)
        Me.c1numRetenidoPL2_9.Name = "c1numRetenidoPL2_9"
        Me.c1numRetenidoPL2_9.ReadOnly = True
        Me.c1numRetenidoPL2_9.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL2_9.TabIndex = 85
        Me.c1numRetenidoPL2_9.Tag = "CM"
        Me.c1numRetenidoPL2_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL2_9.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRetenidoPL2_8
        '
        Me.c1numRetenidoPL2_8.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla2_8", True))
        Me.c1numRetenidoPL2_8.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL2_8.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL2_8.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL2_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL2_8.Location = New System.Drawing.Point(291, 209)
        Me.c1numRetenidoPL2_8.Name = "c1numRetenidoPL2_8"
        Me.c1numRetenidoPL2_8.ReadOnly = True
        Me.c1numRetenidoPL2_8.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL2_8.TabIndex = 84
        Me.c1numRetenidoPL2_8.Tag = "CM"
        Me.c1numRetenidoPL2_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL2_8.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRetenidoPL2_7
        '
        Me.c1numRetenidoPL2_7.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla2_7", True))
        Me.c1numRetenidoPL2_7.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL2_7.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL2_7.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL2_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL2_7.Location = New System.Drawing.Point(291, 184)
        Me.c1numRetenidoPL2_7.Name = "c1numRetenidoPL2_7"
        Me.c1numRetenidoPL2_7.ReadOnly = True
        Me.c1numRetenidoPL2_7.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL2_7.TabIndex = 83
        Me.c1numRetenidoPL2_7.Tag = "CM"
        Me.c1numRetenidoPL2_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL2_7.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRetenidoPL2_6
        '
        Me.c1numRetenidoPL2_6.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla2_6", True))
        Me.c1numRetenidoPL2_6.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL2_6.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL2_6.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL2_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL2_6.Location = New System.Drawing.Point(291, 158)
        Me.c1numRetenidoPL2_6.Name = "c1numRetenidoPL2_6"
        Me.c1numRetenidoPL2_6.ReadOnly = True
        Me.c1numRetenidoPL2_6.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL2_6.TabIndex = 82
        Me.c1numRetenidoPL2_6.Tag = "CM"
        Me.c1numRetenidoPL2_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL2_6.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRetenidoPL2_5
        '
        Me.c1numRetenidoPL2_5.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla2_5", True))
        Me.c1numRetenidoPL2_5.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL2_5.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL2_5.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL2_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL2_5.Location = New System.Drawing.Point(291, 132)
        Me.c1numRetenidoPL2_5.Name = "c1numRetenidoPL2_5"
        Me.c1numRetenidoPL2_5.ReadOnly = True
        Me.c1numRetenidoPL2_5.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL2_5.TabIndex = 81
        Me.c1numRetenidoPL2_5.Tag = "CM"
        Me.c1numRetenidoPL2_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL2_5.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRetenidoPL2_4
        '
        Me.c1numRetenidoPL2_4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla2_4", True))
        Me.c1numRetenidoPL2_4.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL2_4.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL2_4.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL2_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL2_4.Location = New System.Drawing.Point(292, 106)
        Me.c1numRetenidoPL2_4.Name = "c1numRetenidoPL2_4"
        Me.c1numRetenidoPL2_4.ReadOnly = True
        Me.c1numRetenidoPL2_4.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL2_4.TabIndex = 80
        Me.c1numRetenidoPL2_4.Tag = "CM"
        Me.c1numRetenidoPL2_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL2_4.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRetenidoPL2_3
        '
        Me.c1numRetenidoPL2_3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla2_3", True))
        Me.c1numRetenidoPL2_3.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL2_3.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL2_3.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL2_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL2_3.Location = New System.Drawing.Point(292, 80)
        Me.c1numRetenidoPL2_3.Name = "c1numRetenidoPL2_3"
        Me.c1numRetenidoPL2_3.ReadOnly = True
        Me.c1numRetenidoPL2_3.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL2_3.TabIndex = 79
        Me.c1numRetenidoPL2_3.Tag = "CM"
        Me.c1numRetenidoPL2_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL2_3.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRetenidoPL2_2
        '
        Me.c1numRetenidoPL2_2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla2_2", True))
        Me.c1numRetenidoPL2_2.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL2_2.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL2_2.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL2_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL2_2.Location = New System.Drawing.Point(292, 54)
        Me.c1numRetenidoPL2_2.Name = "c1numRetenidoPL2_2"
        Me.c1numRetenidoPL2_2.ReadOnly = True
        Me.c1numRetenidoPL2_2.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL2_2.TabIndex = 78
        Me.c1numRetenidoPL2_2.Tag = "CM"
        Me.c1numRetenidoPL2_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL2_2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRetenidoPL2_1
        '
        Me.c1numRetenidoPL2_1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla2_1", True))
        Me.c1numRetenidoPL2_1.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL2_1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL2_1.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL2_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL2_1.Location = New System.Drawing.Point(292, 31)
        Me.c1numRetenidoPL2_1.Name = "c1numRetenidoPL2_1"
        Me.c1numRetenidoPL2_1.ReadOnly = True
        Me.c1numRetenidoPL2_1.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL2_1.TabIndex = 77
        Me.c1numRetenidoPL2_1.Tag = "CM"
        Me.c1numRetenidoPL2_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL2_1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1num13vo
        '
        Me.c1num13vo.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "Ingreso13vo", True))
        Me.c1num13vo.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1num13vo.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1num13vo.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1num13vo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1num13vo.Location = New System.Drawing.Point(71, 339)
        Me.c1num13vo.Name = "c1num13vo"
        Me.c1num13vo.ReadOnly = True
        Me.c1num13vo.Size = New System.Drawing.Size(68, 20)
        Me.c1num13vo.TabIndex = 14
        Me.c1num13vo.Tag = "CM"
        Me.c1num13vo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1num13vo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(9, 342)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(34, 13)
        Me.Label29.TabIndex = 76
        Me.Label29.Text = "13vo:"
        '
        'lblTotalSueldos
        '
        Me.lblTotalSueldos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSueldos.Location = New System.Drawing.Point(70, 389)
        Me.lblTotalSueldos.Name = "lblTotalSueldos"
        Me.lblTotalSueldos.Size = New System.Drawing.Size(69, 13)
        Me.lblTotalSueldos.TabIndex = 74
        Me.lblTotalSueldos.Text = "0.00"
        Me.lblTotalSueldos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(7, 389)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "Totales:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(215, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "Retenido PL1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(83, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Sueldos"
        '
        'c1numRetenidoPL1_12
        '
        Me.c1numRetenidoPL1_12.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla1_12", True))
        Me.c1numRetenidoPL1_12.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL1_12.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL1_12.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL1_12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL1_12.Location = New System.Drawing.Point(218, 313)
        Me.c1numRetenidoPL1_12.Name = "c1numRetenidoPL1_12"
        Me.c1numRetenidoPL1_12.ReadOnly = True
        Me.c1numRetenidoPL1_12.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL1_12.TabIndex = 26
        Me.c1numRetenidoPL1_12.Tag = "CM"
        Me.c1numRetenidoPL1_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL1_12.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numSueldoMes12
        '
        Me.c1numSueldoMes12.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "SueldoMes12", True))
        Me.c1numSueldoMes12.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numSueldoMes12.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numSueldoMes12.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numSueldoMes12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numSueldoMes12.Location = New System.Drawing.Point(71, 313)
        Me.c1numSueldoMes12.Name = "c1numSueldoMes12"
        Me.c1numSueldoMes12.ReadOnly = True
        Me.c1numSueldoMes12.Size = New System.Drawing.Size(68, 20)
        Me.c1numSueldoMes12.TabIndex = 13
        Me.c1numSueldoMes12.Tag = "CM"
        Me.c1numSueldoMes12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSueldoMes12.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRetenidoPL1_11
        '
        Me.c1numRetenidoPL1_11.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla1_11", True))
        Me.c1numRetenidoPL1_11.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL1_11.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL1_11.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL1_11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL1_11.Location = New System.Drawing.Point(218, 287)
        Me.c1numRetenidoPL1_11.Name = "c1numRetenidoPL1_11"
        Me.c1numRetenidoPL1_11.ReadOnly = True
        Me.c1numRetenidoPL1_11.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL1_11.TabIndex = 25
        Me.c1numRetenidoPL1_11.Tag = "CM"
        Me.c1numRetenidoPL1_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL1_11.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numSueldoMes11
        '
        Me.c1numSueldoMes11.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "SueldoMes11", True))
        Me.c1numSueldoMes11.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numSueldoMes11.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numSueldoMes11.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numSueldoMes11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numSueldoMes11.Location = New System.Drawing.Point(71, 287)
        Me.c1numSueldoMes11.Name = "c1numSueldoMes11"
        Me.c1numSueldoMes11.ReadOnly = True
        Me.c1numSueldoMes11.Size = New System.Drawing.Size(68, 20)
        Me.c1numSueldoMes11.TabIndex = 12
        Me.c1numSueldoMes11.Tag = "CM"
        Me.c1numSueldoMes11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSueldoMes11.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRetenidoPL1_10
        '
        Me.c1numRetenidoPL1_10.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla1_10", True))
        Me.c1numRetenidoPL1_10.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL1_10.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL1_10.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL1_10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL1_10.Location = New System.Drawing.Point(218, 261)
        Me.c1numRetenidoPL1_10.Name = "c1numRetenidoPL1_10"
        Me.c1numRetenidoPL1_10.ReadOnly = True
        Me.c1numRetenidoPL1_10.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL1_10.TabIndex = 24
        Me.c1numRetenidoPL1_10.Tag = "CM"
        Me.c1numRetenidoPL1_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL1_10.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numSueldoMes10
        '
        Me.c1numSueldoMes10.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "SueldoMes10", True))
        Me.c1numSueldoMes10.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numSueldoMes10.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numSueldoMes10.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numSueldoMes10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numSueldoMes10.Location = New System.Drawing.Point(71, 261)
        Me.c1numSueldoMes10.Name = "c1numSueldoMes10"
        Me.c1numSueldoMes10.ReadOnly = True
        Me.c1numSueldoMes10.Size = New System.Drawing.Size(68, 20)
        Me.c1numSueldoMes10.TabIndex = 11
        Me.c1numSueldoMes10.Tag = "CM"
        Me.c1numSueldoMes10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSueldoMes10.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblTotalRetenidoPL1
        '
        Me.lblTotalRetenidoPL1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRetenidoPL1.Location = New System.Drawing.Point(219, 389)
        Me.lblTotalRetenidoPL1.Name = "lblTotalRetenidoPL1"
        Me.lblTotalRetenidoPL1.Size = New System.Drawing.Size(68, 13)
        Me.lblTotalRetenidoPL1.TabIndex = 75
        Me.lblTotalRetenidoPL1.Text = "0.00"
        Me.lblTotalRetenidoPL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'c1numRetenidoPL1_9
        '
        Me.c1numRetenidoPL1_9.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla1_9", True))
        Me.c1numRetenidoPL1_9.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL1_9.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL1_9.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL1_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL1_9.Location = New System.Drawing.Point(218, 235)
        Me.c1numRetenidoPL1_9.Name = "c1numRetenidoPL1_9"
        Me.c1numRetenidoPL1_9.ReadOnly = True
        Me.c1numRetenidoPL1_9.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL1_9.TabIndex = 23
        Me.c1numRetenidoPL1_9.Tag = "CM"
        Me.c1numRetenidoPL1_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL1_9.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numSueldoMes9
        '
        Me.c1numSueldoMes9.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "SueldoMes9", True))
        Me.c1numSueldoMes9.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numSueldoMes9.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numSueldoMes9.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numSueldoMes9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numSueldoMes9.Location = New System.Drawing.Point(71, 235)
        Me.c1numSueldoMes9.Name = "c1numSueldoMes9"
        Me.c1numSueldoMes9.ReadOnly = True
        Me.c1numSueldoMes9.Size = New System.Drawing.Size(68, 20)
        Me.c1numSueldoMes9.TabIndex = 10
        Me.c1numSueldoMes9.Tag = "CM"
        Me.c1numSueldoMes9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSueldoMes9.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRetenidoPL1_8
        '
        Me.c1numRetenidoPL1_8.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla1_8", True))
        Me.c1numRetenidoPL1_8.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL1_8.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL1_8.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL1_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL1_8.Location = New System.Drawing.Point(218, 209)
        Me.c1numRetenidoPL1_8.Name = "c1numRetenidoPL1_8"
        Me.c1numRetenidoPL1_8.ReadOnly = True
        Me.c1numRetenidoPL1_8.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL1_8.TabIndex = 22
        Me.c1numRetenidoPL1_8.Tag = "CM"
        Me.c1numRetenidoPL1_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL1_8.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numSueldoMes8
        '
        Me.c1numSueldoMes8.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "SueldoMes8", True))
        Me.c1numSueldoMes8.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numSueldoMes8.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numSueldoMes8.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numSueldoMes8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numSueldoMes8.Location = New System.Drawing.Point(71, 209)
        Me.c1numSueldoMes8.Name = "c1numSueldoMes8"
        Me.c1numSueldoMes8.ReadOnly = True
        Me.c1numSueldoMes8.Size = New System.Drawing.Size(68, 20)
        Me.c1numSueldoMes8.TabIndex = 9
        Me.c1numSueldoMes8.Tag = "CM"
        Me.c1numSueldoMes8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSueldoMes8.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRetenidoPL1_7
        '
        Me.c1numRetenidoPL1_7.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla1_7", True))
        Me.c1numRetenidoPL1_7.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL1_7.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL1_7.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL1_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL1_7.Location = New System.Drawing.Point(218, 184)
        Me.c1numRetenidoPL1_7.Name = "c1numRetenidoPL1_7"
        Me.c1numRetenidoPL1_7.ReadOnly = True
        Me.c1numRetenidoPL1_7.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL1_7.TabIndex = 21
        Me.c1numRetenidoPL1_7.Tag = "CM"
        Me.c1numRetenidoPL1_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL1_7.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numSueldoMes7
        '
        Me.c1numSueldoMes7.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "SueldoMes7", True))
        Me.c1numSueldoMes7.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numSueldoMes7.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numSueldoMes7.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numSueldoMes7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numSueldoMes7.Location = New System.Drawing.Point(71, 184)
        Me.c1numSueldoMes7.Name = "c1numSueldoMes7"
        Me.c1numSueldoMes7.ReadOnly = True
        Me.c1numSueldoMes7.Size = New System.Drawing.Size(68, 20)
        Me.c1numSueldoMes7.TabIndex = 8
        Me.c1numSueldoMes7.Tag = "CM"
        Me.c1numSueldoMes7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSueldoMes7.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRetenidoPL1_6
        '
        Me.c1numRetenidoPL1_6.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla1_6", True))
        Me.c1numRetenidoPL1_6.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL1_6.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL1_6.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL1_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL1_6.Location = New System.Drawing.Point(218, 158)
        Me.c1numRetenidoPL1_6.Name = "c1numRetenidoPL1_6"
        Me.c1numRetenidoPL1_6.ReadOnly = True
        Me.c1numRetenidoPL1_6.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL1_6.TabIndex = 20
        Me.c1numRetenidoPL1_6.Tag = "CM"
        Me.c1numRetenidoPL1_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL1_6.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numSueldoMes6
        '
        Me.c1numSueldoMes6.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "SueldoMes6", True))
        Me.c1numSueldoMes6.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numSueldoMes6.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numSueldoMes6.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numSueldoMes6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numSueldoMes6.Location = New System.Drawing.Point(71, 158)
        Me.c1numSueldoMes6.Name = "c1numSueldoMes6"
        Me.c1numSueldoMes6.ReadOnly = True
        Me.c1numSueldoMes6.Size = New System.Drawing.Size(68, 20)
        Me.c1numSueldoMes6.TabIndex = 7
        Me.c1numSueldoMes6.Tag = "CM"
        Me.c1numSueldoMes6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSueldoMes6.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRetenidoPL1_5
        '
        Me.c1numRetenidoPL1_5.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla1_5", True))
        Me.c1numRetenidoPL1_5.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL1_5.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL1_5.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL1_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL1_5.Location = New System.Drawing.Point(218, 132)
        Me.c1numRetenidoPL1_5.Name = "c1numRetenidoPL1_5"
        Me.c1numRetenidoPL1_5.ReadOnly = True
        Me.c1numRetenidoPL1_5.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL1_5.TabIndex = 19
        Me.c1numRetenidoPL1_5.Tag = "CM"
        Me.c1numRetenidoPL1_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL1_5.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numSueldoMes5
        '
        Me.c1numSueldoMes5.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "SueldoMes5", True))
        Me.c1numSueldoMes5.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numSueldoMes5.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numSueldoMes5.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numSueldoMes5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numSueldoMes5.Location = New System.Drawing.Point(71, 132)
        Me.c1numSueldoMes5.Name = "c1numSueldoMes5"
        Me.c1numSueldoMes5.ReadOnly = True
        Me.c1numSueldoMes5.Size = New System.Drawing.Size(68, 20)
        Me.c1numSueldoMes5.TabIndex = 6
        Me.c1numSueldoMes5.Tag = "CM"
        Me.c1numSueldoMes5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSueldoMes5.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRetenidoPL1_4
        '
        Me.c1numRetenidoPL1_4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla1_4", True))
        Me.c1numRetenidoPL1_4.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL1_4.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL1_4.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL1_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL1_4.Location = New System.Drawing.Point(218, 106)
        Me.c1numRetenidoPL1_4.Name = "c1numRetenidoPL1_4"
        Me.c1numRetenidoPL1_4.ReadOnly = True
        Me.c1numRetenidoPL1_4.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL1_4.TabIndex = 18
        Me.c1numRetenidoPL1_4.Tag = "CM"
        Me.c1numRetenidoPL1_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL1_4.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numSueldoMes4
        '
        Me.c1numSueldoMes4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "SueldoMes4", True))
        Me.c1numSueldoMes4.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numSueldoMes4.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numSueldoMes4.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numSueldoMes4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numSueldoMes4.Location = New System.Drawing.Point(71, 106)
        Me.c1numSueldoMes4.Name = "c1numSueldoMes4"
        Me.c1numSueldoMes4.ReadOnly = True
        Me.c1numSueldoMes4.Size = New System.Drawing.Size(68, 20)
        Me.c1numSueldoMes4.TabIndex = 5
        Me.c1numSueldoMes4.Tag = "CM"
        Me.c1numSueldoMes4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSueldoMes4.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRetenidoPL1_3
        '
        Me.c1numRetenidoPL1_3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla1_3", True))
        Me.c1numRetenidoPL1_3.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL1_3.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL1_3.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL1_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL1_3.Location = New System.Drawing.Point(218, 80)
        Me.c1numRetenidoPL1_3.Name = "c1numRetenidoPL1_3"
        Me.c1numRetenidoPL1_3.ReadOnly = True
        Me.c1numRetenidoPL1_3.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL1_3.TabIndex = 17
        Me.c1numRetenidoPL1_3.Tag = "CM"
        Me.c1numRetenidoPL1_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL1_3.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numSueldoMes3
        '
        Me.c1numSueldoMes3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "SueldoMes3", True))
        Me.c1numSueldoMes3.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numSueldoMes3.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numSueldoMes3.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numSueldoMes3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numSueldoMes3.Location = New System.Drawing.Point(71, 80)
        Me.c1numSueldoMes3.Name = "c1numSueldoMes3"
        Me.c1numSueldoMes3.ReadOnly = True
        Me.c1numSueldoMes3.Size = New System.Drawing.Size(68, 20)
        Me.c1numSueldoMes3.TabIndex = 4
        Me.c1numSueldoMes3.Tag = "CM"
        Me.c1numSueldoMes3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSueldoMes3.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRetenidoPL1_2
        '
        Me.c1numRetenidoPL1_2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla1_2", True))
        Me.c1numRetenidoPL1_2.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL1_2.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL1_2.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL1_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL1_2.Location = New System.Drawing.Point(218, 54)
        Me.c1numRetenidoPL1_2.Name = "c1numRetenidoPL1_2"
        Me.c1numRetenidoPL1_2.ReadOnly = True
        Me.c1numRetenidoPL1_2.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL1_2.TabIndex = 16
        Me.c1numRetenidoPL1_2.Tag = "CM"
        Me.c1numRetenidoPL1_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL1_2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numSueldoMes2
        '
        Me.c1numSueldoMes2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "SueldoMes2", True))
        Me.c1numSueldoMes2.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numSueldoMes2.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numSueldoMes2.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numSueldoMes2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numSueldoMes2.Location = New System.Drawing.Point(71, 54)
        Me.c1numSueldoMes2.Name = "c1numSueldoMes2"
        Me.c1numSueldoMes2.ReadOnly = True
        Me.c1numSueldoMes2.Size = New System.Drawing.Size(68, 20)
        Me.c1numSueldoMes2.TabIndex = 3
        Me.c1numSueldoMes2.Tag = "CM"
        Me.c1numSueldoMes2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSueldoMes2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRetenidoPL1_1
        '
        Me.c1numRetenidoPL1_1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionPlanilla1_1", True))
        Me.c1numRetenidoPL1_1.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRetenidoPL1_1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRetenidoPL1_1.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRetenidoPL1_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRetenidoPL1_1.Location = New System.Drawing.Point(218, 31)
        Me.c1numRetenidoPL1_1.Name = "c1numRetenidoPL1_1"
        Me.c1numRetenidoPL1_1.ReadOnly = True
        Me.c1numRetenidoPL1_1.Size = New System.Drawing.Size(68, 20)
        Me.c1numRetenidoPL1_1.TabIndex = 15
        Me.c1numRetenidoPL1_1.Tag = "CM"
        Me.c1numRetenidoPL1_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRetenidoPL1_1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numSueldoMes1
        '
        Me.c1numSueldoMes1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "SueldoMes1", True))
        Me.c1numSueldoMes1.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numSueldoMes1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numSueldoMes1.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numSueldoMes1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numSueldoMes1.Location = New System.Drawing.Point(71, 31)
        Me.c1numSueldoMes1.Name = "c1numSueldoMes1"
        Me.c1numSueldoMes1.ReadOnly = True
        Me.c1numSueldoMes1.Size = New System.Drawing.Size(68, 20)
        Me.c1numSueldoMes1.TabIndex = 2
        Me.c1numSueldoMes1.Tag = "CM"
        Me.c1numSueldoMes1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSueldoMes1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 316)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Diciembre:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 290)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Noviembre:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 264)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Octubre:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Septiembre:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Agosto:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Julio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Junio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mayo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Abril:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Marzo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Febrero:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enero:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalDeducibles)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.c1numOtros)
        Me.GroupBox2.Controls.Add(Me.c1numDonaciones)
        Me.GroupBox2.Controls.Add(Me.c1numSeguroSocial)
        Me.GroupBox2.Controls.Add(Me.c1numGastosMedicos)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(377, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(186, 148)
        Me.GroupBox2.TabIndex = 76
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Deducibles"
        '
        'lblTotalDeducibles
        '
        Me.lblTotalDeducibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDeducibles.Location = New System.Drawing.Point(96, 123)
        Me.lblTotalDeducibles.Name = "lblTotalDeducibles"
        Me.lblTotalDeducibles.Size = New System.Drawing.Size(79, 13)
        Me.lblTotalDeducibles.TabIndex = 76
        Me.lblTotalDeducibles.Text = "0.00"
        Me.lblTotalDeducibles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(9, 123)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(53, 13)
        Me.Label24.TabIndex = 75
        Me.Label24.Text = "Totales:"
        '
        'c1numOtros
        '
        Me.c1numOtros.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "OtrosDescuentos", True))
        Me.c1numOtros.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numOtros.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numOtros.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numOtros.Location = New System.Drawing.Point(99, 96)
        Me.c1numOtros.Name = "c1numOtros"
        Me.c1numOtros.ReadOnly = True
        Me.c1numOtros.Size = New System.Drawing.Size(76, 20)
        Me.c1numOtros.TabIndex = 30
        Me.c1numOtros.Tag = "CM"
        Me.c1numOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numOtros.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numDonaciones
        '
        Me.c1numDonaciones.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "Donaciones", True))
        Me.c1numDonaciones.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numDonaciones.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numDonaciones.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numDonaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numDonaciones.Location = New System.Drawing.Point(99, 70)
        Me.c1numDonaciones.Name = "c1numDonaciones"
        Me.c1numDonaciones.ReadOnly = True
        Me.c1numDonaciones.Size = New System.Drawing.Size(76, 20)
        Me.c1numDonaciones.TabIndex = 29
        Me.c1numDonaciones.Tag = "CM"
        Me.c1numDonaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numDonaciones.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
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
        Me.c1numSeguroSocial.Location = New System.Drawing.Point(99, 44)
        Me.c1numSeguroSocial.Name = "c1numSeguroSocial"
        Me.c1numSeguroSocial.ReadOnly = True
        Me.c1numSeguroSocial.Size = New System.Drawing.Size(76, 20)
        Me.c1numSeguroSocial.TabIndex = 28
        Me.c1numSeguroSocial.Tag = "CM"
        Me.c1numSeguroSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSeguroSocial.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numGastosMedicos
        '
        Me.c1numGastosMedicos.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "GastosMedicos", True))
        Me.c1numGastosMedicos.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numGastosMedicos.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numGastosMedicos.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numGastosMedicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numGastosMedicos.Location = New System.Drawing.Point(99, 17)
        Me.c1numGastosMedicos.Name = "c1numGastosMedicos"
        Me.c1numGastosMedicos.ReadOnly = True
        Me.c1numGastosMedicos.Size = New System.Drawing.Size(76, 20)
        Me.c1numGastosMedicos.TabIndex = 27
        Me.c1numGastosMedicos.Tag = "CM"
        Me.c1numGastosMedicos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numGastosMedicos.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(7, 99)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 13)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Otros:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 73)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Donaciones:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Seguro Social:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Gastos Médicos:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotalPorRetener)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.lblTotalRetencion)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.c1numRango3)
        Me.GroupBox3.Controls.Add(Me.c1numRango2)
        Me.GroupBox3.Controls.Add(Me.c1numRango1)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Location = New System.Drawing.Point(377, 219)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(186, 146)
        Me.GroupBox3.TabIndex = 77
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Aplicación"
        '
        'lblTotalPorRetener
        '
        Me.lblTotalPorRetener.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPorRetener.Location = New System.Drawing.Point(112, 126)
        Me.lblTotalPorRetener.Name = "lblTotalPorRetener"
        Me.lblTotalPorRetener.Size = New System.Drawing.Size(63, 16)
        Me.lblTotalPorRetener.TabIndex = 80
        Me.lblTotalPorRetener.Text = "0.00"
        Me.lblTotalPorRetener.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(6, 126)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(106, 13)
        Me.Label27.TabIndex = 79
        Me.Label27.Text = "Total por retener:"
        '
        'lblTotalRetencion
        '
        Me.lblTotalRetencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRetencion.Location = New System.Drawing.Point(109, 100)
        Me.lblTotalRetencion.Name = "lblTotalRetencion"
        Me.lblTotalRetencion.Size = New System.Drawing.Size(66, 13)
        Me.lblTotalRetencion.TabIndex = 78
        Me.lblTotalRetencion.Text = "0.00"
        Me.lblTotalRetencion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(6, 100)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(97, 13)
        Me.Label25.TabIndex = 77
        Me.Label25.Text = "Total retención:"
        '
        'c1numRango3
        '
        Me.c1numRango3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "Porcentaje3", True))
        Me.c1numRango3.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRango3.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRango3.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRango3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRango3.Location = New System.Drawing.Point(99, 70)
        Me.c1numRango3.Name = "c1numRango3"
        Me.c1numRango3.ReadOnly = True
        Me.c1numRango3.Size = New System.Drawing.Size(76, 20)
        Me.c1numRango3.TabIndex = 33
        Me.c1numRango3.Tag = "CM"
        Me.c1numRango3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRango3.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRango2
        '
        Me.c1numRango2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "Porcentaje2", True))
        Me.c1numRango2.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRango2.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRango2.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRango2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRango2.Location = New System.Drawing.Point(99, 45)
        Me.c1numRango2.Name = "c1numRango2"
        Me.c1numRango2.ReadOnly = True
        Me.c1numRango2.Size = New System.Drawing.Size(76, 20)
        Me.c1numRango2.TabIndex = 32
        Me.c1numRango2.Tag = "CM"
        Me.c1numRango2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRango2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numRango1
        '
        Me.c1numRango1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "Porcentaje1", True))
        Me.c1numRango1.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numRango1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numRango1.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numRango1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numRango1.Location = New System.Drawing.Point(99, 19)
        Me.c1numRango1.Name = "c1numRango1"
        Me.c1numRango1.ReadOnly = True
        Me.c1numRango1.Size = New System.Drawing.Size(76, 20)
        Me.c1numRango1.TabIndex = 31
        Me.c1numRango1.Tag = "CM"
        Me.c1numRango1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numRango1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(9, 73)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 13)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Rango 25%:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(9, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 13)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Rango 20%:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(7, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 13)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Rango 15%:"
        '
        'c1truedbgrdTablaISR
        '
        Me.c1truedbgrdTablaISR.AllowAddNew = True
        Me.c1truedbgrdTablaISR.AllowDelete = True
        Me.c1truedbgrdTablaISR.Caption = "Tabla del ISR"
        Me.c1truedbgrdTablaISR.DataSource = Me.TablaISRBindingSource
        Me.c1truedbgrdTablaISR.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1truedbgrdTablaISR.Images.Add(CType(resources.GetObject("c1truedbgrdTablaISR.Images"), System.Drawing.Image))
        Me.c1truedbgrdTablaISR.Location = New System.Drawing.Point(569, 62)
        Me.c1truedbgrdTablaISR.Name = "c1truedbgrdTablaISR"
        Me.c1truedbgrdTablaISR.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1truedbgrdTablaISR.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1truedbgrdTablaISR.PreviewInfo.ZoomFactor = 75.0R
        Me.c1truedbgrdTablaISR.PrintInfo.PageSettings = CType(resources.GetObject("c1truedbgrdTablaISR.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1truedbgrdTablaISR.Size = New System.Drawing.Size(221, 147)
        Me.c1truedbgrdTablaISR.TabIndex = 35
        Me.c1truedbgrdTablaISR.Text = "Tabla del ISR"
        Me.c1truedbgrdTablaISR.PropBag = resources.GetString("c1truedbgrdTablaISR.PropBag")
        '
        'TablaISRBindingSource
        '
        Me.TablaISRBindingSource.DataMember = "PLTablaISR"
        Me.TablaISRBindingSource.DataSource = Me.PLDeduccionISRDataSet
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.c1numNoMesesRetener)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Location = New System.Drawing.Point(377, 374)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(186, 54)
        Me.GroupBox4.TabIndex = 79
        Me.GroupBox4.TabStop = False
        '
        'c1numNoMesesRetener
        '
        Me.c1numNoMesesRetener.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "NoMesesDeducir", True))
        Me.c1numNoMesesRetener.DataType = GetType(Byte)
        Me.c1numNoMesesRetener.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numNoMesesRetener.Location = New System.Drawing.Point(138, 26)
        Me.c1numNoMesesRetener.Name = "c1numNoMesesRetener"
        Me.c1numNoMesesRetener.ReadOnly = True
        Me.c1numNoMesesRetener.Size = New System.Drawing.Size(28, 20)
        Me.c1numNoMesesRetener.TabIndex = 34
        Me.c1numNoMesesRetener.Tag = "CM"
        Me.c1numNoMesesRetener.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numNoMesesRetener.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 29)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(126, 13)
        Me.Label26.TabIndex = 7
        Me.Label26.Text = "No. de Meses a Retener:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(216, 38)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(10, 13)
        Me.lblNombre.TabIndex = 83
        Me.lblNombre.Text = "."
        '
        'c1txtCodigoEmpleado
        '
        Me.c1txtCodigoEmpleado.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "CodigoEmpleado", True))
        Me.c1txtCodigoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtCodigoEmpleado.Location = New System.Drawing.Point(65, 35)
        Me.c1txtCodigoEmpleado.Name = "c1txtCodigoEmpleado"
        Me.c1txtCodigoEmpleado.ReadOnly = True
        Me.c1txtCodigoEmpleado.Size = New System.Drawing.Size(122, 20)
        Me.c1txtCodigoEmpleado.TabIndex = 0
        Me.c1txtCodigoEmpleado.Tag = "CO"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(2, 38)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(57, 13)
        Me.Label28.TabIndex = 82
        Me.Label28.Text = "Empleado:"
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(515, 34)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 84
        Me.lblBuscar.Text = "Buscar"
        Me.lblBuscar.Visible = False
        '
        'btnCalcularISR
        '
        Me.btnCalcularISR.Location = New System.Drawing.Point(569, 267)
        Me.btnCalcularISR.Name = "btnCalcularISR"
        Me.btnCalcularISR.Size = New System.Drawing.Size(221, 39)
        Me.btnCalcularISR.TabIndex = 37
        Me.btnCalcularISR.Tag = "CM"
        Me.btnCalcularISR.Text = "Calcular ISR"
        Me.btnCalcularISR.UseVisualStyleBackColor = True
        '
        'butTotalizar
        '
        Me.butTotalizar.Location = New System.Drawing.Point(569, 222)
        Me.butTotalizar.Name = "butTotalizar"
        Me.butTotalizar.Size = New System.Drawing.Size(221, 39)
        Me.butTotalizar.TabIndex = 36
        Me.butTotalizar.Tag = ""
        Me.butTotalizar.Text = "Totalizar"
        Me.butTotalizar.UseVisualStyleBackColor = True
        '
        'PLDeduccionISRTableAdapter
        '
        Me.PLDeduccionISRTableAdapter.ClearBeforeFill = True
        '
        'PLTablaISRTableAdapter
        '
        Me.PLTablaISRTableAdapter.ClearBeforeFill = True
        '
        'chkboxNoDeducir
        '
        Me.chkboxNoDeducir.AutoSize = True
        Me.chkboxNoDeducir.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PrincipalBindingSource, "NoDeducir", True))
        Me.chkboxNoDeducir.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PrincipalBindingSource, "NoDeducir", True))
        Me.chkboxNoDeducir.Enabled = False
        Me.chkboxNoDeducir.Location = New System.Drawing.Point(569, 38)
        Me.chkboxNoDeducir.Name = "chkboxNoDeducir"
        Me.chkboxNoDeducir.Size = New System.Drawing.Size(179, 17)
        Me.chkboxNoDeducir.TabIndex = 85
        Me.chkboxNoDeducir.Tag = "CM"
        Me.chkboxNoDeducir.Text = "No Deducir Para Este Empleado"
        Me.chkboxNoDeducir.UseVisualStyleBackColor = True
        '
        'btnBuscarEmpleado
        '
        Me.btnBuscarEmpleado.ControlEnlazado = Nothing
        Me.btnBuscarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarEmpleado.Enabled = False
        Me.btnBuscarEmpleado.Location = New System.Drawing.Point(187, 33)
        Me.btnBuscarEmpleado.Name = "btnBuscarEmpleado"
        Me.btnBuscarEmpleado.Size = New System.Drawing.Size(23, 23)
        Me.btnBuscarEmpleado.TabIndex = 1
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
        Me.DataNavBarPrincipal.EjecutarAntesModificar = False
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
        Me.DataNavBarPrincipal.Size = New System.Drawing.Size(805, 31)
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
        'DeduccionISRFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 497)
        Me.Controls.Add(Me.chkboxNoDeducir)
        Me.Controls.Add(Me.butTotalizar)
        Me.Controls.Add(Me.btnCalcularISR)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnBuscarEmpleado)
        Me.Controls.Add(Me.c1txtCodigoEmpleado)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.c1truedbgrdTablaISR)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataNavBarPrincipal)
        Me.Controls.Add(Me.statusstripPrincipal)
        Me.KeyPreview = True
        Me.Name = "DeduccionISRFrm"
        Me.Text = "Deduccion del ISR"
        Me.statusstripPrincipal.ResumeLayout(False)
        Me.statusstripPrincipal.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1num14vo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLDeduccionISRDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numIngAdicMes12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numIngAdicMes11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numIngAdicMes10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numIngAdicMes9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numIngAdicMes8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numIngAdicMes7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numIngAdicMes6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numIngAdicMes5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numIngAdicMes4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numIngAdicMes3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numIngAdicMes2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numIngAdicMes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL2_12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL2_11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL2_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL2_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL2_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL2_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL2_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL2_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL2_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL2_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL2_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL2_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1num13vo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL1_12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSueldoMes12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL1_11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSueldoMes11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL1_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSueldoMes10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL1_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSueldoMes9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL1_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSueldoMes8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL1_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSueldoMes7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL1_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSueldoMes6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL1_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSueldoMes5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL1_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSueldoMes4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL1_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSueldoMes3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL1_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSueldoMes2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRetenidoPL1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSueldoMes1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.c1numOtros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numDonaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSeguroSocial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numGastosMedicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.c1numRango3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRango2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numRango1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1truedbgrdTablaISR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaISRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.c1numNoMesesRetener, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtCodigoEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLDeduccionISRDataSet As RSIContab.PLDeduccionISRDataSet
    Friend WithEvents PLDeduccionISRTableAdapter As RSIContab.PLDeduccionISRDataSetTableAdapters.PLDeduccionISRTableAdapter
    Friend WithEvents statusstripPrincipal As System.Windows.Forms.StatusStrip
    Friend WithEvents statusCerrado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusImpreso As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusContabilizado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusAnulado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statuslblAñoMes As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataNavBarPrincipal As RSIContab.DataNavBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents c1numRetenidoPL1_11 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numSueldoMes11 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRetenidoPL1_10 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numSueldoMes10 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRetenidoPL1_9 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numSueldoMes9 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRetenidoPL1_8 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numSueldoMes8 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRetenidoPL1_7 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numSueldoMes7 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRetenidoPL1_6 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numSueldoMes6 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRetenidoPL1_5 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numSueldoMes5 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRetenidoPL1_4 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numSueldoMes4 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRetenidoPL1_3 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numSueldoMes3 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRetenidoPL1_2 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numSueldoMes2 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRetenidoPL1_1 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numSueldoMes1 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRetenidoPL1_12 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numSueldoMes12 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblTotalRetenidoPL1 As System.Windows.Forms.Label
    Friend WithEvents lblTotalSueldos As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents c1numOtros As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numDonaciones As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numSeguroSocial As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numGastosMedicos As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents c1numRango3 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRango2 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRango1 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TablaISRBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLTablaISRTableAdapter As RSIContab.PLDeduccionISRDataSetTableAdapters.PLTablaISRTableAdapter
    Friend WithEvents c1truedbgrdTablaISR As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents lblTotalDeducibles As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPorRetener As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lblTotalRetencion As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents c1numNoMesesRetener As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnBuscarEmpleado As RSIContab.BotonBuscar
    Friend WithEvents c1txtCodigoEmpleado As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents btnCalcularISR As System.Windows.Forms.Button
    Friend WithEvents butTotalizar As System.Windows.Forms.Button
    Friend WithEvents c1num13vo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents c1numRetenidoPL2_12 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRetenidoPL2_11 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRetenidoPL2_10 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRetenidoPL2_9 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRetenidoPL2_8 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRetenidoPL2_7 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRetenidoPL2_6 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRetenidoPL2_5 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRetenidoPL2_4 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRetenidoPL2_3 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRetenidoPL2_2 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numRetenidoPL2_1 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numIngAdicMes12 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numIngAdicMes11 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numIngAdicMes10 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numIngAdicMes9 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numIngAdicMes8 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numIngAdicMes7 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numIngAdicMes6 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numIngAdicMes5 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numIngAdicMes4 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numIngAdicMes3 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numIngAdicMes2 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numIngAdicMes1 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents c1num14vo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblTotalRetenidoPL2 As System.Windows.Forms.Label
    Friend WithEvents lblTotIngAdicionales As System.Windows.Forms.Label
    Friend WithEvents chkboxNoDeducir As System.Windows.Forms.CheckBox
End Class
