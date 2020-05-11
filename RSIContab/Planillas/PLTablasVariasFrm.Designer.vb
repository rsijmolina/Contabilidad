<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLTablasVariasFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PLTablasVariasFrm))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.c1numDonaciones = New C1.Win.C1Input.C1NumericEdit
        Me.ConfPlaniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLTablasDedDataSet = New RSIContab.PLTablasDedDataSet
        Me.c1numPensiones = New C1.Win.C1Input.C1NumericEdit
        Me.c1numSeguroSocial = New C1.Win.C1Input.C1NumericEdit
        Me.c1numGastosEducMedicos = New C1.Win.C1Input.C1NumericEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkboxINJUPEMP = New System.Windows.Forms.CheckBox
        Me.chkboxDonaciones = New System.Windows.Forms.CheckBox
        Me.chkboxPensiones = New System.Windows.Forms.CheckBox
        Me.chkboxSeguroSocial = New System.Windows.Forms.CheckBox
        Me.c1truedbgrdISR = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TablaISRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.c1truedbgrdImpVecinal = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TablaImpVecinalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.c1truedbgrdDiasVac = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TablaDiasVacacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.c1truedbgrdTablaVacProporcionales = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.PLTablaVacPropBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLTablasPrestacionesDataSet = New RSIContab.PLTablasPrestacionesDataSet
        Me.c1truedbgrdTablaCesantia = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.PLTablaCesantiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.c1truedbgrdTablaPreaviso = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.PLTablaPreavisoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button
        Me.PLTablaISRTableAdapter = New RSIContab.PLTablasDedDataSetTableAdapters.PLTablaISRTableAdapter
        Me.PLTablaImpuestoVecinalTableAdapter = New RSIContab.PLTablasDedDataSetTableAdapters.PLTablaImpuestoVecinalTableAdapter
        Me.PLTablaDiasVacacionesTableAdapter = New RSIContab.PLTablasDedDataSetTableAdapters.PLTablaDiasVacacionesTableAdapter
        Me.PLConfTableAdapter = New RSIContab.PLTablasDedDataSetTableAdapters.PLConfTableAdapter
        Me.PLTablaPreavisoTableAdapter = New RSIContab.PLTablasPrestacionesDataSetTableAdapters.PLTablaPreavisoTableAdapter
        Me.PLTablaCesantiaTableAdapter = New RSIContab.PLTablasPrestacionesDataSetTableAdapters.PLTablaCesantiaTableAdapter
        Me.PLTablaVacacionesProporcionalesTableAdapter = New RSIContab.PLTablasPrestacionesDataSetTableAdapters.PLTablaVacacionesProporcionalesTableAdapter
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.c1numDonaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfPlaniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLTablasDedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numPensiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSeguroSocial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numGastosEducMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1truedbgrdISR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaISRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.c1truedbgrdImpVecinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaImpVecinalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.c1truedbgrdDiasVac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaDiasVacacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.c1truedbgrdTablaVacProporcionales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLTablaVacPropBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLTablasPrestacionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1truedbgrdTablaCesantia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLTablaCesantiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1truedbgrdTablaPreaviso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLTablaPreavisoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(5, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(482, 271)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.c1truedbgrdISR)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(474, 245)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ISR"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.c1numDonaciones)
        Me.GroupBox2.Controls.Add(Me.c1numPensiones)
        Me.GroupBox2.Controls.Add(Me.c1numSeguroSocial)
        Me.GroupBox2.Controls.Add(Me.c1numGastosEducMedicos)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(263, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(205, 142)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Deducciones Máximas"
        '
        'c1numDonaciones
        '
        Me.c1numDonaciones.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ConfPlaniBindingSource, "MaxDeducibleDonaciones", True))
        Me.c1numDonaciones.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numDonaciones.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numDonaciones.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numDonaciones.Location = New System.Drawing.Point(129, 96)
        Me.c1numDonaciones.Name = "c1numDonaciones"
        Me.c1numDonaciones.Size = New System.Drawing.Size(68, 20)
        Me.c1numDonaciones.TabIndex = 8
        Me.c1numDonaciones.Tag = Nothing
        Me.c1numDonaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numDonaciones.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'ConfPlaniBindingSource
        '
        Me.ConfPlaniBindingSource.DataMember = "PLConf"
        Me.ConfPlaniBindingSource.DataSource = Me.PLTablasDedDataSet
        '
        'PLTablasDedDataSet
        '
        Me.PLTablasDedDataSet.DataSetName = "PLTablasDedDataSet"
        Me.PLTablasDedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'c1numPensiones
        '
        Me.c1numPensiones.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ConfPlaniBindingSource, "MaxDeduciblePensiones", True))
        Me.c1numPensiones.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numPensiones.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numPensiones.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numPensiones.Location = New System.Drawing.Point(129, 70)
        Me.c1numPensiones.Name = "c1numPensiones"
        Me.c1numPensiones.Size = New System.Drawing.Size(68, 20)
        Me.c1numPensiones.TabIndex = 7
        Me.c1numPensiones.Tag = Nothing
        Me.c1numPensiones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numPensiones.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numSeguroSocial
        '
        Me.c1numSeguroSocial.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ConfPlaniBindingSource, "MaxDeducibleSeguro", True))
        Me.c1numSeguroSocial.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numSeguroSocial.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numSeguroSocial.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numSeguroSocial.Location = New System.Drawing.Point(129, 44)
        Me.c1numSeguroSocial.Name = "c1numSeguroSocial"
        Me.c1numSeguroSocial.Size = New System.Drawing.Size(68, 20)
        Me.c1numSeguroSocial.TabIndex = 6
        Me.c1numSeguroSocial.Tag = Nothing
        Me.c1numSeguroSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSeguroSocial.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numGastosEducMedicos
        '
        Me.c1numGastosEducMedicos.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ConfPlaniBindingSource, "DescuentoISRMedicina", True))
        Me.c1numGastosEducMedicos.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numGastosEducMedicos.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numGastosEducMedicos.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numGastosEducMedicos.Location = New System.Drawing.Point(129, 19)
        Me.c1numGastosEducMedicos.Name = "c1numGastosEducMedicos"
        Me.c1numGastosEducMedicos.Size = New System.Drawing.Size(68, 20)
        Me.c1numGastosEducMedicos.TabIndex = 5
        Me.c1numGastosEducMedicos.Tag = Nothing
        Me.c1numGastosEducMedicos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numGastosEducMedicos.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Donaciones:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pensiones:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Seguro Social:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gastos Educ./Médicos:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkboxINJUPEMP)
        Me.GroupBox1.Controls.Add(Me.chkboxDonaciones)
        Me.GroupBox1.Controls.Add(Me.chkboxPensiones)
        Me.GroupBox1.Controls.Add(Me.chkboxSeguroSocial)
        Me.GroupBox1.Location = New System.Drawing.Point(263, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(205, 77)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Aplicar Deducibles A"
        '
        'chkboxINJUPEMP
        '
        Me.chkboxINJUPEMP.AutoSize = True
        Me.chkboxINJUPEMP.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ConfPlaniBindingSource, "DescontarISRINJUPEMP", True))
        Me.chkboxINJUPEMP.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ConfPlaniBindingSource, "DescontarISRINJUPEMP", True))
        Me.chkboxINJUPEMP.Location = New System.Drawing.Point(113, 43)
        Me.chkboxINJUPEMP.Name = "chkboxINJUPEMP"
        Me.chkboxINJUPEMP.Size = New System.Drawing.Size(80, 17)
        Me.chkboxINJUPEMP.TabIndex = 3
        Me.chkboxINJUPEMP.Text = "INJUPEMP"
        Me.chkboxINJUPEMP.UseVisualStyleBackColor = True
        '
        'chkboxDonaciones
        '
        Me.chkboxDonaciones.AutoSize = True
        Me.chkboxDonaciones.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ConfPlaniBindingSource, "DescontarISRDonaciones", True))
        Me.chkboxDonaciones.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ConfPlaniBindingSource, "DescontarISRDonaciones", True))
        Me.chkboxDonaciones.Location = New System.Drawing.Point(6, 43)
        Me.chkboxDonaciones.Name = "chkboxDonaciones"
        Me.chkboxDonaciones.Size = New System.Drawing.Size(83, 17)
        Me.chkboxDonaciones.TabIndex = 2
        Me.chkboxDonaciones.Text = "Donaciones"
        Me.chkboxDonaciones.UseVisualStyleBackColor = True
        '
        'chkboxPensiones
        '
        Me.chkboxPensiones.AutoSize = True
        Me.chkboxPensiones.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ConfPlaniBindingSource, "DescontarISRPensiones", True))
        Me.chkboxPensiones.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ConfPlaniBindingSource, "DescontarISRPensiones", True))
        Me.chkboxPensiones.Location = New System.Drawing.Point(113, 20)
        Me.chkboxPensiones.Name = "chkboxPensiones"
        Me.chkboxPensiones.Size = New System.Drawing.Size(75, 17)
        Me.chkboxPensiones.TabIndex = 1
        Me.chkboxPensiones.Text = "Pensiones"
        Me.chkboxPensiones.UseVisualStyleBackColor = True
        '
        'chkboxSeguroSocial
        '
        Me.chkboxSeguroSocial.AutoSize = True
        Me.chkboxSeguroSocial.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ConfPlaniBindingSource, "DescuentoISRSeguro", True))
        Me.chkboxSeguroSocial.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ConfPlaniBindingSource, "DescuentoISRSeguro", True))
        Me.chkboxSeguroSocial.Location = New System.Drawing.Point(6, 20)
        Me.chkboxSeguroSocial.Name = "chkboxSeguroSocial"
        Me.chkboxSeguroSocial.Size = New System.Drawing.Size(92, 17)
        Me.chkboxSeguroSocial.TabIndex = 0
        Me.chkboxSeguroSocial.Text = "Seguro Social"
        Me.chkboxSeguroSocial.UseVisualStyleBackColor = True
        '
        'c1truedbgrdISR
        '
        Me.c1truedbgrdISR.AllowAddNew = True
        Me.c1truedbgrdISR.AllowDelete = True
        Me.c1truedbgrdISR.DataSource = Me.TablaISRBindingSource
        Me.c1truedbgrdISR.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1truedbgrdISR.Images.Add(CType(resources.GetObject("c1truedbgrdISR.Images"), System.Drawing.Image))
        Me.c1truedbgrdISR.Location = New System.Drawing.Point(7, 7)
        Me.c1truedbgrdISR.Name = "c1truedbgrdISR"
        Me.c1truedbgrdISR.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1truedbgrdISR.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1truedbgrdISR.PreviewInfo.ZoomFactor = 75
        Me.c1truedbgrdISR.PrintInfo.PageSettings = CType(resources.GetObject("c1truedbgrdISR.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1truedbgrdISR.RowHeight = 17
        Me.c1truedbgrdISR.Size = New System.Drawing.Size(250, 225)
        Me.c1truedbgrdISR.TabIndex = 0
        Me.c1truedbgrdISR.Text = "C1TrueDBGrid1"
        Me.c1truedbgrdISR.PropBag = resources.GetString("c1truedbgrdISR.PropBag")
        '
        'TablaISRBindingSource
        '
        Me.TablaISRBindingSource.DataMember = "PLTablaISR"
        Me.TablaISRBindingSource.DataSource = Me.PLTablasDedDataSet
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.c1truedbgrdImpVecinal)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(474, 245)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Impto. Vecinal"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'c1truedbgrdImpVecinal
        '
        Me.c1truedbgrdImpVecinal.AllowAddNew = True
        Me.c1truedbgrdImpVecinal.AllowDelete = True
        Me.c1truedbgrdImpVecinal.DataSource = Me.TablaImpVecinalBindingSource
        Me.c1truedbgrdImpVecinal.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1truedbgrdImpVecinal.Images.Add(CType(resources.GetObject("c1truedbgrdImpVecinal.Images"), System.Drawing.Image))
        Me.c1truedbgrdImpVecinal.Location = New System.Drawing.Point(7, 7)
        Me.c1truedbgrdImpVecinal.Name = "c1truedbgrdImpVecinal"
        Me.c1truedbgrdImpVecinal.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1truedbgrdImpVecinal.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1truedbgrdImpVecinal.PreviewInfo.ZoomFactor = 75
        Me.c1truedbgrdImpVecinal.PrintInfo.PageSettings = CType(resources.GetObject("c1truedbgrdImpVecinal.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1truedbgrdImpVecinal.RowHeight = 17
        Me.c1truedbgrdImpVecinal.Size = New System.Drawing.Size(443, 225)
        Me.c1truedbgrdImpVecinal.TabIndex = 0
        Me.c1truedbgrdImpVecinal.Text = "C1TrueDBGrid2"
        Me.c1truedbgrdImpVecinal.PropBag = resources.GetString("c1truedbgrdImpVecinal.PropBag")
        '
        'TablaImpVecinalBindingSource
        '
        Me.TablaImpVecinalBindingSource.DataMember = "PLTablaImpuestoVecinal"
        Me.TablaImpVecinalBindingSource.DataSource = Me.PLTablasDedDataSet
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.c1truedbgrdDiasVac)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(474, 245)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Días de Vacaciones"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'c1truedbgrdDiasVac
        '
        Me.c1truedbgrdDiasVac.AllowAddNew = True
        Me.c1truedbgrdDiasVac.AllowDelete = True
        Me.c1truedbgrdDiasVac.DataSource = Me.TablaDiasVacacionesBindingSource
        Me.c1truedbgrdDiasVac.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1truedbgrdDiasVac.Images.Add(CType(resources.GetObject("c1truedbgrdDiasVac.Images"), System.Drawing.Image))
        Me.c1truedbgrdDiasVac.Location = New System.Drawing.Point(7, 7)
        Me.c1truedbgrdDiasVac.Name = "c1truedbgrdDiasVac"
        Me.c1truedbgrdDiasVac.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1truedbgrdDiasVac.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1truedbgrdDiasVac.PreviewInfo.ZoomFactor = 75
        Me.c1truedbgrdDiasVac.PrintInfo.PageSettings = CType(resources.GetObject("c1truedbgrdDiasVac.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1truedbgrdDiasVac.RowHeight = 17
        Me.c1truedbgrdDiasVac.Size = New System.Drawing.Size(237, 225)
        Me.c1truedbgrdDiasVac.TabIndex = 0
        Me.c1truedbgrdDiasVac.Text = "C1TrueDBGrid3"
        Me.c1truedbgrdDiasVac.PropBag = resources.GetString("c1truedbgrdDiasVac.PropBag")
        '
        'TablaDiasVacacionesBindingSource
        '
        Me.TablaDiasVacacionesBindingSource.DataMember = "PLTablaDiasVacaciones"
        Me.TablaDiasVacacionesBindingSource.DataSource = Me.PLTablasDedDataSet
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.c1truedbgrdTablaVacProporcionales)
        Me.TabPage4.Controls.Add(Me.c1truedbgrdTablaCesantia)
        Me.TabPage4.Controls.Add(Me.c1truedbgrdTablaPreaviso)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(474, 245)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Prestaciones"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'c1truedbgrdTablaVacProporcionales
        '
        Me.c1truedbgrdTablaVacProporcionales.AllowAddNew = True
        Me.c1truedbgrdTablaVacProporcionales.AllowDelete = True
        Me.c1truedbgrdTablaVacProporcionales.Caption = "Tabla de Vacaciones Propor."
        Me.c1truedbgrdTablaVacProporcionales.DataSource = Me.PLTablaVacPropBindingSource
        Me.c1truedbgrdTablaVacProporcionales.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1truedbgrdTablaVacProporcionales.Images.Add(CType(resources.GetObject("c1truedbgrdTablaVacProporcionales.Images"), System.Drawing.Image))
        Me.c1truedbgrdTablaVacProporcionales.Location = New System.Drawing.Point(214, 6)
        Me.c1truedbgrdTablaVacProporcionales.Name = "c1truedbgrdTablaVacProporcionales"
        Me.c1truedbgrdTablaVacProporcionales.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1truedbgrdTablaVacProporcionales.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1truedbgrdTablaVacProporcionales.PreviewInfo.ZoomFactor = 75
        Me.c1truedbgrdTablaVacProporcionales.PrintInfo.PageSettings = CType(resources.GetObject("c1truedbgrdTablaVacProporcionales.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1truedbgrdTablaVacProporcionales.Size = New System.Drawing.Size(190, 121)
        Me.c1truedbgrdTablaVacProporcionales.TabIndex = 2
        Me.c1truedbgrdTablaVacProporcionales.Text = "C1TrueDBGrid3"
        Me.c1truedbgrdTablaVacProporcionales.PropBag = resources.GetString("c1truedbgrdTablaVacProporcionales.PropBag")
        '
        'PLTablaVacPropBindingSource
        '
        Me.PLTablaVacPropBindingSource.DataMember = "PLTablaVacacionesProporcionales"
        Me.PLTablaVacPropBindingSource.DataSource = Me.PLTablasPrestacionesDataSet
        '
        'PLTablasPrestacionesDataSet
        '
        Me.PLTablasPrestacionesDataSet.DataSetName = "PLTablasPrestacionesDataSet"
        Me.PLTablasPrestacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'c1truedbgrdTablaCesantia
        '
        Me.c1truedbgrdTablaCesantia.AllowAddNew = True
        Me.c1truedbgrdTablaCesantia.AllowDelete = True
        Me.c1truedbgrdTablaCesantia.Caption = "Tabla de Cesantía"
        Me.c1truedbgrdTablaCesantia.DataSource = Me.PLTablaCesantiaBindingSource
        Me.c1truedbgrdTablaCesantia.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1truedbgrdTablaCesantia.Images.Add(CType(resources.GetObject("c1truedbgrdTablaCesantia.Images"), System.Drawing.Image))
        Me.c1truedbgrdTablaCesantia.Location = New System.Drawing.Point(8, 133)
        Me.c1truedbgrdTablaCesantia.Name = "c1truedbgrdTablaCesantia"
        Me.c1truedbgrdTablaCesantia.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1truedbgrdTablaCesantia.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1truedbgrdTablaCesantia.PreviewInfo.ZoomFactor = 75
        Me.c1truedbgrdTablaCesantia.PrintInfo.PageSettings = CType(resources.GetObject("c1truedbgrdTablaCesantia.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1truedbgrdTablaCesantia.Size = New System.Drawing.Size(190, 106)
        Me.c1truedbgrdTablaCesantia.TabIndex = 1
        Me.c1truedbgrdTablaCesantia.Text = "C1TrueDBGrid2"
        Me.c1truedbgrdTablaCesantia.PropBag = resources.GetString("c1truedbgrdTablaCesantia.PropBag")
        '
        'PLTablaCesantiaBindingSource
        '
        Me.PLTablaCesantiaBindingSource.DataMember = "PLTablaCesantia"
        Me.PLTablaCesantiaBindingSource.DataSource = Me.PLTablasPrestacionesDataSet
        '
        'c1truedbgrdTablaPreaviso
        '
        Me.c1truedbgrdTablaPreaviso.AllowAddNew = True
        Me.c1truedbgrdTablaPreaviso.AllowDelete = True
        Me.c1truedbgrdTablaPreaviso.Caption = "Tabla de Preaviso"
        Me.c1truedbgrdTablaPreaviso.DataSource = Me.PLTablaPreavisoBindingSource
        Me.c1truedbgrdTablaPreaviso.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1truedbgrdTablaPreaviso.Images.Add(CType(resources.GetObject("c1truedbgrdTablaPreaviso.Images"), System.Drawing.Image))
        Me.c1truedbgrdTablaPreaviso.Location = New System.Drawing.Point(7, 6)
        Me.c1truedbgrdTablaPreaviso.Name = "c1truedbgrdTablaPreaviso"
        Me.c1truedbgrdTablaPreaviso.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1truedbgrdTablaPreaviso.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1truedbgrdTablaPreaviso.PreviewInfo.ZoomFactor = 75
        Me.c1truedbgrdTablaPreaviso.PrintInfo.PageSettings = CType(resources.GetObject("c1truedbgrdTablaPreaviso.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1truedbgrdTablaPreaviso.Size = New System.Drawing.Size(191, 121)
        Me.c1truedbgrdTablaPreaviso.TabIndex = 0
        Me.c1truedbgrdTablaPreaviso.Text = "C1TrueDBGrid1"
        Me.c1truedbgrdTablaPreaviso.PropBag = resources.GetString("c1truedbgrdTablaPreaviso.PropBag")
        '
        'PLTablaPreavisoBindingSource
        '
        Me.PLTablaPreavisoBindingSource.DataMember = "PLTablaPreaviso"
        Me.PLTablaPreavisoBindingSource.DataSource = Me.PLTablasPrestacionesDataSet
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(208, 282)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 30)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PLTablaISRTableAdapter
        '
        Me.PLTablaISRTableAdapter.ClearBeforeFill = True
        '
        'PLTablaImpuestoVecinalTableAdapter
        '
        Me.PLTablaImpuestoVecinalTableAdapter.ClearBeforeFill = True
        '
        'PLTablaDiasVacacionesTableAdapter
        '
        Me.PLTablaDiasVacacionesTableAdapter.ClearBeforeFill = True
        '
        'PLConfTableAdapter
        '
        Me.PLConfTableAdapter.ClearBeforeFill = True
        '
        'PLTablaPreavisoTableAdapter
        '
        Me.PLTablaPreavisoTableAdapter.ClearBeforeFill = True
        '
        'PLTablaCesantiaTableAdapter
        '
        Me.PLTablaCesantiaTableAdapter.ClearBeforeFill = True
        '
        'PLTablaVacacionesProporcionalesTableAdapter
        '
        Me.PLTablaVacacionesProporcionalesTableAdapter.ClearBeforeFill = True
        '
        'PLTablasVariasFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 322)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "PLTablasVariasFrm"
        Me.Text = "Tablas Varias"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.c1numDonaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfPlaniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLTablasDedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numPensiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSeguroSocial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numGastosEducMedicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1truedbgrdISR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaISRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.c1truedbgrdImpVecinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaImpVecinalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.c1truedbgrdDiasVac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaDiasVacacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.c1truedbgrdTablaVacProporcionales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLTablaVacPropBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLTablasPrestacionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1truedbgrdTablaCesantia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLTablaCesantiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1truedbgrdTablaPreaviso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLTablaPreavisoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TablaISRBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLTablasDedDataSet As RSIContab.PLTablasDedDataSet
    Friend WithEvents PLTablaISRTableAdapter As RSIContab.PLTablasDedDataSetTableAdapters.PLTablaISRTableAdapter
    Friend WithEvents TablaImpVecinalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLTablaImpuestoVecinalTableAdapter As RSIContab.PLTablasDedDataSetTableAdapters.PLTablaImpuestoVecinalTableAdapter
    Friend WithEvents TablaDiasVacacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLTablaDiasVacacionesTableAdapter As RSIContab.PLTablasDedDataSetTableAdapters.PLTablaDiasVacacionesTableAdapter
    Friend WithEvents ConfPlaniBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLConfTableAdapter As RSIContab.PLTablasDedDataSetTableAdapters.PLConfTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents c1truedbgrdISR As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents c1truedbgrdImpVecinal As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents c1truedbgrdDiasVac As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkboxINJUPEMP As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxDonaciones As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxPensiones As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxSeguroSocial As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents c1numGastosEducMedicos As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numDonaciones As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numPensiones As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numSeguroSocial As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents c1truedbgrdTablaPreaviso As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents PLTablaPreavisoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLTablasPrestacionesDataSet As RSIContab.PLTablasPrestacionesDataSet
    Friend WithEvents PLTablaPreavisoTableAdapter As RSIContab.PLTablasPrestacionesDataSetTableAdapters.PLTablaPreavisoTableAdapter
    Friend WithEvents PLTablaCesantiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLTablaCesantiaTableAdapter As RSIContab.PLTablasPrestacionesDataSetTableAdapters.PLTablaCesantiaTableAdapter
    Friend WithEvents PLTablaVacPropBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLTablaVacacionesProporcionalesTableAdapter As RSIContab.PLTablasPrestacionesDataSetTableAdapters.PLTablaVacacionesProporcionalesTableAdapter
    Friend WithEvents c1truedbgrdTablaCesantia As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents c1truedbgrdTablaVacProporcionales As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
