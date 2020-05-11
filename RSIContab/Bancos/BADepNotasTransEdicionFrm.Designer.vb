<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BADepNotasTransEdicionFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BADepNotasTransEdicionFrm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.C1NumericEditFactorCambio = New C1.Win.C1Input.C1NumericEdit()
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BATransaccionesEdicionDataSet = New RSIContab.BATransaccionesEdicionDataSet()
        Me.C1NumericEditValor = New C1.Win.C1Input.C1NumericEdit()
        Me.CheckBoxTransCuenta = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.C1TextBoxDescripcion = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBoxCodigo = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBoxNoTransaccion = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBoxConcepto = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBoxBeneficiario = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBoxNoPartida = New C1.Win.C1Input.C1TextBox()
        Me.C1DateEditFecha = New C1.Win.C1Input.C1DateEdit()
        Me.C1ButtonContabilizadoAnulado = New C1.Win.C1Input.C1Button()
        Me.LabelSaldo = New System.Windows.Forms.Label()
        Me.LabelCodigoBanco = New System.Windows.Forms.Label()
        Me.LabelCodigoDescripcion = New System.Windows.Forms.Label()
        Me.LabelCuenta = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.C1TrueDBGrid2 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.BATransDocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.BADetalleTransBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EditDataNavBar1 = New RSIContab.EditDataNavBar()
        Me.BATransaccionesDetalleTableAdapter = New RSIContab.BATransaccionesEdicionDataSetTableAdapters.BATransaccionesDetalleTableAdapter()
        Me.BATransaccionesEncabezadoTableAdapter = New RSIContab.BATransaccionesEdicionDataSetTableAdapters.BATransaccionesEncabezadoTableAdapter()
        Me.BATransaccionesDocumentacionTableAdapter = New RSIContab.BATransaccionesEdicionDataSetTableAdapters.BATransaccionesDocumentacionTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.C1NumericEditFactorCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BATransaccionesEdicionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEditValor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1TextBoxDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBoxCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBoxNoTransaccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBoxConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBoxBeneficiario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBoxNoPartida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DateEditFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ButtonContabilizadoAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.C1TrueDBGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BATransDocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BADetalleTransBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Banco"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(404, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Saldo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cuenta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Al Banco"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(173, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(371, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Valor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Concepto"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Beneficiario"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 245)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Partida No."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(172, 243)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Factor de Cambio"
        '
        'C1NumericEditFactorCambio
        '
        Me.C1NumericEditFactorCambio.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "FactorCambio", True))
        Me.C1NumericEditFactorCambio.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEditFactorCambio.Location = New System.Drawing.Point(268, 240)
        Me.C1NumericEditFactorCambio.Name = "C1NumericEditFactorCambio"
        Me.C1NumericEditFactorCambio.Size = New System.Drawing.Size(95, 18)
        Me.C1NumericEditFactorCambio.TabIndex = 11
        Me.C1NumericEditFactorCambio.Tag = Nothing
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "BATransaccionesEncabezado"
        Me.PrincipalBindingSource.DataSource = Me.BATransaccionesEdicionDataSet
        '
        'BATransaccionesEdicionDataSet
        '
        Me.BATransaccionesEdicionDataSet.DataSetName = "BATransaccionesEdicionDataSet"
        Me.BATransaccionesEdicionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'C1NumericEditValor
        '
        Me.C1NumericEditValor.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "Monto", True))
        Me.C1NumericEditValor.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEditValor.Location = New System.Drawing.Point(401, 135)
        Me.C1NumericEditValor.Name = "C1NumericEditValor"
        Me.C1NumericEditValor.Size = New System.Drawing.Size(95, 18)
        Me.C1NumericEditValor.TabIndex = 12
        Me.C1NumericEditValor.Tag = Nothing
        '
        'CheckBoxTransCuenta
        '
        Me.CheckBoxTransCuenta.AutoSize = True
        Me.CheckBoxTransCuenta.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PrincipalBindingSource, "EsTransferencia", True))
        Me.CheckBoxTransCuenta.Location = New System.Drawing.Point(9, 23)
        Me.CheckBoxTransCuenta.Name = "CheckBoxTransCuenta"
        Me.CheckBoxTransCuenta.Size = New System.Drawing.Size(161, 17)
        Me.CheckBoxTransCuenta.TabIndex = 13
        Me.CheckBoxTransCuenta.Text = "Transferencia Entre Cuentas"
        Me.CheckBoxTransCuenta.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.C1TextBoxDescripcion)
        Me.GroupBox1.Controls.Add(Me.C1TextBoxCodigo)
        Me.GroupBox1.Controls.Add(Me.CheckBoxTransCuenta)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 70)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Documento"
        '
        'C1TextBoxDescripcion
        '
        Me.C1TextBoxDescripcion.Location = New System.Drawing.Point(169, 43)
        Me.C1TextBoxDescripcion.Name = "C1TextBoxDescripcion"
        Me.C1TextBoxDescripcion.Size = New System.Drawing.Size(263, 18)
        Me.C1TextBoxDescripcion.TabIndex = 15
        Me.C1TextBoxDescripcion.Tag = Nothing
        '
        'C1TextBoxCodigo
        '
        Me.C1TextBoxCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "BancoDestino", True))
        Me.C1TextBoxCodigo.DataType = GetType(Short)
        Me.C1TextBoxCodigo.Location = New System.Drawing.Point(105, 43)
        Me.C1TextBoxCodigo.Name = "C1TextBoxCodigo"
        Me.C1TextBoxCodigo.Size = New System.Drawing.Size(54, 18)
        Me.C1TextBoxCodigo.TabIndex = 14
        Me.C1TextBoxCodigo.Tag = Nothing
        '
        'C1TextBoxNoTransaccion
        '
        Me.C1TextBoxNoTransaccion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "NoDocumento", True))
        Me.C1TextBoxNoTransaccion.DataType = GetType(Integer)
        Me.C1TextBoxNoTransaccion.Location = New System.Drawing.Point(65, 135)
        Me.C1TextBoxNoTransaccion.Name = "C1TextBoxNoTransaccion"
        Me.C1TextBoxNoTransaccion.Size = New System.Drawing.Size(100, 18)
        Me.C1TextBoxNoTransaccion.TabIndex = 16
        Me.C1TextBoxNoTransaccion.Tag = Nothing
        '
        'C1TextBoxConcepto
        '
        Me.C1TextBoxConcepto.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "Concepto", True))
        Me.C1TextBoxConcepto.Location = New System.Drawing.Point(65, 162)
        Me.C1TextBoxConcepto.Multiline = True
        Me.C1TextBoxConcepto.Name = "C1TextBoxConcepto"
        Me.C1TextBoxConcepto.Size = New System.Drawing.Size(431, 48)
        Me.C1TextBoxConcepto.TabIndex = 17
        Me.C1TextBoxConcepto.Tag = Nothing
        '
        'C1TextBoxBeneficiario
        '
        Me.C1TextBoxBeneficiario.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "Beneficiario", True))
        Me.C1TextBoxBeneficiario.Location = New System.Drawing.Point(65, 216)
        Me.C1TextBoxBeneficiario.Name = "C1TextBoxBeneficiario"
        Me.C1TextBoxBeneficiario.Size = New System.Drawing.Size(431, 18)
        Me.C1TextBoxBeneficiario.TabIndex = 18
        Me.C1TextBoxBeneficiario.Tag = Nothing
        '
        'C1TextBoxNoPartida
        '
        Me.C1TextBoxNoPartida.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "NoPartida", True))
        Me.C1TextBoxNoPartida.Location = New System.Drawing.Point(65, 240)
        Me.C1TextBoxNoPartida.Name = "C1TextBoxNoPartida"
        Me.C1TextBoxNoPartida.Size = New System.Drawing.Size(88, 18)
        Me.C1TextBoxNoPartida.TabIndex = 19
        Me.C1TextBoxNoPartida.Tag = Nothing
        '
        'C1DateEditFecha
        '
        Me.C1DateEditFecha.AllowSpinLoop = False
        '
        '
        '
        Me.C1DateEditFecha.Calendar.DayNameLength = 1
        Me.C1DateEditFecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "Fecha", True))
        Me.C1DateEditFecha.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1DateEditFecha.Location = New System.Drawing.Point(216, 135)
        Me.C1DateEditFecha.Name = "C1DateEditFecha"
        Me.C1DateEditFecha.Size = New System.Drawing.Size(135, 18)
        Me.C1DateEditFecha.TabIndex = 20
        Me.C1DateEditFecha.Tag = Nothing
        '
        'C1ButtonContabilizadoAnulado
        '
        Me.C1ButtonContabilizadoAnulado.ForeColor = System.Drawing.Color.Red
        Me.C1ButtonContabilizadoAnulado.Location = New System.Drawing.Point(374, 238)
        Me.C1ButtonContabilizadoAnulado.Name = "C1ButtonContabilizadoAnulado"
        Me.C1ButtonContabilizadoAnulado.Size = New System.Drawing.Size(122, 23)
        Me.C1ButtonContabilizadoAnulado.TabIndex = 22
        Me.C1ButtonContabilizadoAnulado.Text = "Contabilizado Anulado"
        Me.C1ButtonContabilizadoAnulado.UseVisualStyleBackColor = True
        Me.C1ButtonContabilizadoAnulado.Visible = False
        '
        'LabelSaldo
        '
        Me.LabelSaldo.AutoSize = True
        Me.LabelSaldo.Location = New System.Drawing.Point(445, 16)
        Me.LabelSaldo.Name = "LabelSaldo"
        Me.LabelSaldo.Size = New System.Drawing.Size(45, 13)
        Me.LabelSaldo.TabIndex = 23
        Me.LabelSaldo.Text = "Label12"
        '
        'LabelCodigoBanco
        '
        Me.LabelCodigoBanco.AutoSize = True
        Me.LabelCodigoBanco.Location = New System.Drawing.Point(80, 16)
        Me.LabelCodigoBanco.Name = "LabelCodigoBanco"
        Me.LabelCodigoBanco.Size = New System.Drawing.Size(45, 13)
        Me.LabelCodigoBanco.TabIndex = 24
        Me.LabelCodigoBanco.Text = "Label13"
        '
        'LabelCodigoDescripcion
        '
        Me.LabelCodigoDescripcion.AutoSize = True
        Me.LabelCodigoDescripcion.Location = New System.Drawing.Point(131, 16)
        Me.LabelCodigoDescripcion.Name = "LabelCodigoDescripcion"
        Me.LabelCodigoDescripcion.Size = New System.Drawing.Size(45, 13)
        Me.LabelCodigoDescripcion.TabIndex = 25
        Me.LabelCodigoDescripcion.Text = "Label14"
        '
        'LabelCuenta
        '
        Me.LabelCuenta.AutoSize = True
        Me.LabelCuenta.Location = New System.Drawing.Point(80, 39)
        Me.LabelCuenta.Name = "LabelCuenta"
        Me.LabelCuenta.Size = New System.Drawing.Size(45, 13)
        Me.LabelCuenta.TabIndex = 26
        Me.LabelCuenta.Text = "Label15"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.C1TrueDBGrid2)
        Me.GroupBox2.Controls.Add(Me.LabelCuenta)
        Me.GroupBox2.Controls.Add(Me.C1ButtonContabilizadoAnulado)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.C1TextBoxNoPartida)
        Me.GroupBox2.Controls.Add(Me.C1TextBoxBeneficiario)
        Me.GroupBox2.Controls.Add(Me.LabelCodigoDescripcion)
        Me.GroupBox2.Controls.Add(Me.C1NumericEditFactorCambio)
        Me.GroupBox2.Controls.Add(Me.C1DateEditFecha)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.LabelCodigoBanco)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.C1TextBoxConcepto)
        Me.GroupBox2.Controls.Add(Me.LabelSaldo)
        Me.GroupBox2.Controls.Add(Me.C1TextBoxNoTransaccion)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.C1NumericEditValor)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(742, 269)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.Image = Global.RSIContab.My.Resources.Resources._1425432924_Magnifier2
        Me.Button2.Location = New System.Drawing.Point(542, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 23)
        Me.Button2.TabIndex = 29
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(503, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'C1TrueDBGrid2
        '
        Me.C1TrueDBGrid2.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.C1TrueDBGrid2.DataSource = Me.BATransDocBindingSource
        Me.C1TrueDBGrid2.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TrueDBGrid2.Images.Add(CType(resources.GetObject("C1TrueDBGrid2.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid2.Location = New System.Drawing.Point(502, 96)
        Me.C1TrueDBGrid2.Name = "C1TrueDBGrid2"
        Me.C1TrueDBGrid2.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid2.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid2.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid2.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid2.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid2.Size = New System.Drawing.Size(234, 165)
        Me.C1TrueDBGrid2.TabIndex = 27
        Me.C1TrueDBGrid2.UseCompatibleTextRendering = False
        Me.C1TrueDBGrid2.PropBag = resources.GetString("C1TrueDBGrid2.PropBag")
        '
        'BATransDocBindingSource
        '
        Me.BATransDocBindingSource.DataMember = "BATransaccionesDocumentacion"
        Me.BATransDocBindingSource.DataSource = Me.BATransaccionesEdicionDataSet
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.C1TrueDBGrid1.DataSource = Me.BADetalleTransBindingSource
        Me.C1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(12, 337)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(742, 122)
        Me.C1TrueDBGrid1.TabIndex = 28
        Me.C1TrueDBGrid1.UseCompatibleTextRendering = False
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        '
        'BADetalleTransBindingSource
        '
        Me.BADetalleTransBindingSource.DataMember = "BATransaccionesDetalle"
        Me.BADetalleTransBindingSource.DataSource = Me.BATransaccionesEdicionDataSet
        '
        'EditDataNavBar1
        '
        Me.EditDataNavBar1.BindingSourcePrincipal = Nothing
        Me.EditDataNavBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.EditDataNavBar1.Location = New System.Drawing.Point(0, 0)
        Me.EditDataNavBar1.Modalidad = Nothing
        Me.EditDataNavBar1.ModificarRegistro = False
        Me.EditDataNavBar1.Name = "EditDataNavBar1"
        Me.EditDataNavBar1.NuevoRegistro = False
        Me.EditDataNavBar1.ResultadoValidacion = Nothing
        Me.EditDataNavBar1.Size = New System.Drawing.Size(766, 66)
        Me.EditDataNavBar1.TabIndex = 29
        Me.EditDataNavBar1.ValidacionCorrecta = False
        '
        'BATransaccionesDetalleTableAdapter
        '
        Me.BATransaccionesDetalleTableAdapter.ClearBeforeFill = True
        '
        'BATransaccionesEncabezadoTableAdapter
        '
        Me.BATransaccionesEncabezadoTableAdapter.ClearBeforeFill = True
        '
        'BATransaccionesDocumentacionTableAdapter
        '
        Me.BATransaccionesDocumentacionTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Image = Global.RSIContab.My.Resources.Resources._1425432924_Magnifier2
        Me.Button3.Location = New System.Drawing.Point(67, 37)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 23)
        Me.Button3.TabIndex = 30
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BADepNotasTransEdicionFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 489)
        Me.Controls.Add(Me.EditDataNavBar1)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "BADepNotasTransEdicionFrm"
        Me.Text = "BADepNotasTransEdicionFrm"
        CType(Me.C1NumericEditFactorCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BATransaccionesEdicionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEditValor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.C1TextBoxDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBoxCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBoxNoTransaccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBoxConcepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBoxBeneficiario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBoxNoPartida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DateEditFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ButtonContabilizadoAnulado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.C1TrueDBGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BATransDocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BADetalleTransBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents C1NumericEditFactorCambio As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEditValor As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents CheckBoxTransCuenta As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents C1TextBoxDescripcion As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBoxCodigo As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBoxNoTransaccion As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBoxConcepto As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBoxBeneficiario As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBoxNoPartida As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelCuenta As Label
    Friend WithEvents C1ButtonContabilizadoAnulado As C1.Win.C1Input.C1Button
    Friend WithEvents LabelCodigoDescripcion As Label
    Friend WithEvents C1DateEditFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents LabelCodigoBanco As Label
    Friend WithEvents LabelSaldo As Label
    Friend WithEvents EditDataNavBar1 As EditDataNavBar
    Friend WithEvents BADetalleTransBindingSource As BindingSource
    Friend WithEvents BATransaccionesEdicionDataSet As BATransaccionesEdicionDataSet
    Friend WithEvents PrincipalBindingSource As BindingSource
    Friend WithEvents BATransaccionesDetalleTableAdapter As BATransaccionesEdicionDataSetTableAdapters.BATransaccionesDetalleTableAdapter
    Friend WithEvents BATransaccionesEncabezadoTableAdapter As BATransaccionesEdicionDataSetTableAdapters.BATransaccionesEncabezadoTableAdapter
    Friend WithEvents C1TrueDBGrid2 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents BATransDocBindingSource As BindingSource
    Friend WithEvents BATransaccionesDocumentacionTableAdapter As BATransaccionesEdicionDataSetTableAdapters.BATransaccionesDocumentacionTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
