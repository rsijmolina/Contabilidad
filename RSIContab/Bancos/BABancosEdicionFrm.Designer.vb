



<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BABancosEdicionFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BABancosEdicionFrm))
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.C1NumericEditUltimoDeposito = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEditUltimoCheque = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEditUltimaNotaDebito = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEditUltimaNotaCredito = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEditUltimaTransferencia = New C1.Win.C1Input.C1NumericEdit()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.C1TextBoxCuentaAjuste = New C1.Win.C1Input.C1TextBox()
        Me.LabelCuentaAjuste = New System.Windows.Forms.Label()
        Me.C1ButtonCuentaAjuste = New C1.Win.C1Input.C1Button()
        Me.C1NumericEditFactorCambio = New C1.Win.C1Input.C1NumericEdit()
        Me.C1CheckBoxCuentaExtranjera = New C1.Win.C1Input.C1CheckBox()
        Me.C1ComboBoxMoneda = New C1.Win.C1Input.C1ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.C1ButtonRecalcularSaldos = New C1.Win.C1Input.C1Button()
        Me.LabelCuentaContable = New System.Windows.Forms.Label()
        Me.C1NumericEditCodigo = New C1.Win.C1Input.C1NumericEdit()
        Me.C1TextBoxCuentaBancaria = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBoxFormatoCheque = New C1.Win.C1Input.C1TextBox()
        Me.C1ButtonCuentaContable = New C1.Win.C1Input.C1Button()
        Me.C1ComboBoxImpresora = New C1.Win.C1Input.C1ComboBox()
        Me.C1TextBoxCuentaContable = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBoxDescripcion = New C1.Win.C1Input.C1TextBox()
        Me.C1NumericEditMontoSobregiro = New C1.Win.C1Input.C1NumericEdit()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.C1NumericEditSaldoActual = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEditCreditos = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEditDebitos = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEditDepositos = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEditCheques = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEditSaldoAnterior = New C1.Win.C1Input.C1NumericEdit()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.C1NumericEditSaldoActualEquiv = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEditCreditosValEquiv = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEditDebitosValEquiv = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEditDepositosValEquiv = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEditChequesValEquiv = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEditSaldoAnteriorValEquiv = New C1.Win.C1Input.C1NumericEdit()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.EditDataNavBarPrin = New RSIContab.EditDataNavBar()
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BABancosEdicionDataSet = New RSIContab.BABancosEdicionDataSet()
        Me.BATransEncBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSourceSaldos = New System.Windows.Forms.BindingSource(Me.components)
        Me.BABancosTableAdapter = New RSIContab.BABancosEdicionDataSetTableAdapters.BABancosTableAdapter()
        Me.BATransaccionesEncabezadoTableAdapter = New RSIContab.BABancosEdicionDataSetTableAdapters.BATransaccionesEncabezadoTableAdapter()
        Me.CTCatalogoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BASaldosMensualesTableAdapter = New RSIContab.BABancosEdicionDataSetTableAdapters.BASaldosMensualesTableAdapter()
        Me.CTCatalogoCuentasTableAdapter = New RSIContab.BABancosEdicionDataSetTableAdapters.CTCatalogoCuentasTableAdapter()
        Me.BATransaccionesDetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BATransaccionesDetalleTableAdapter = New RSIContab.BABancosEdicionDataSetTableAdapters.BATransaccionesDetalleTableAdapter()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.C1NumericEditUltimoDeposito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEditUltimoCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEditUltimaNotaDebito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEditUltimaNotaCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEditUltimaTransferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.C1TextBoxCuentaAjuste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ButtonCuentaAjuste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEditFactorCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CheckBoxCuentaExtranjera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ComboBoxMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.C1ButtonRecalcularSaldos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEditCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBoxCuentaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBoxFormatoCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ButtonCuentaContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ComboBoxImpresora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBoxCuentaContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBoxDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEditMontoSobregiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.C1NumericEditSaldoActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEditCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEditDebitos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEditDepositos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEditCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEditSaldoAnterior, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.C1NumericEditSaldoActualEquiv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEditCreditosValEquiv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEditDebitosValEquiv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEditDepositosValEquiv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEditChequesValEquiv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEditSaldoAnteriorValEquiv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BABancosEdicionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BATransEncBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceSaldos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTCatalogoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BATransaccionesDetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(12, 72)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(634, 445)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(626, 419)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Bancos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.C1NumericEditUltimoDeposito)
        Me.GroupBox6.Controls.Add(Me.C1NumericEditUltimoCheque)
        Me.GroupBox6.Controls.Add(Me.C1NumericEditUltimaNotaDebito)
        Me.GroupBox6.Controls.Add(Me.C1NumericEditUltimaNotaCredito)
        Me.GroupBox6.Controls.Add(Me.C1NumericEditUltimaTransferencia)
        Me.GroupBox6.Controls.Add(Me.Label31)
        Me.GroupBox6.Controls.Add(Me.Label30)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Controls.Add(Me.Label26)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Location = New System.Drawing.Point(7, 296)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(613, 101)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Documentos"
        '
        'C1NumericEditUltimoDeposito
        '
        Me.C1NumericEditUltimoDeposito.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "UltimoDeposito", True))
        Me.C1NumericEditUltimoDeposito.DataType = GetType(Integer)
        Me.C1NumericEditUltimoDeposito.Enabled = False
        Me.C1NumericEditUltimoDeposito.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEditUltimoDeposito.Location = New System.Drawing.Point(92, 56)
        Me.C1NumericEditUltimoDeposito.Name = "C1NumericEditUltimoDeposito"
        Me.C1NumericEditUltimoDeposito.Size = New System.Drawing.Size(86, 18)
        Me.C1NumericEditUltimoDeposito.TabIndex = 23
        Me.C1NumericEditUltimoDeposito.Tag = "CM"
        Me.C1NumericEditUltimoDeposito.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1NumericEditUltimoCheque
        '
        Me.C1NumericEditUltimoCheque.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "UltimoCheque", True))
        Me.C1NumericEditUltimoCheque.DataType = GetType(Integer)
        Me.C1NumericEditUltimoCheque.Enabled = False
        Me.C1NumericEditUltimoCheque.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEditUltimoCheque.Location = New System.Drawing.Point(92, 27)
        Me.C1NumericEditUltimoCheque.Name = "C1NumericEditUltimoCheque"
        Me.C1NumericEditUltimoCheque.Size = New System.Drawing.Size(86, 18)
        Me.C1NumericEditUltimoCheque.TabIndex = 22
        Me.C1NumericEditUltimoCheque.Tag = "CM"
        Me.C1NumericEditUltimoCheque.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1NumericEditUltimaNotaDebito
        '
        Me.C1NumericEditUltimaNotaDebito.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "UltimaNotaDebito", True))
        Me.C1NumericEditUltimaNotaDebito.DataType = GetType(Integer)
        Me.C1NumericEditUltimaNotaDebito.Enabled = False
        Me.C1NumericEditUltimaNotaDebito.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEditUltimaNotaDebito.Location = New System.Drawing.Point(310, 59)
        Me.C1NumericEditUltimaNotaDebito.Name = "C1NumericEditUltimaNotaDebito"
        Me.C1NumericEditUltimaNotaDebito.Size = New System.Drawing.Size(86, 18)
        Me.C1NumericEditUltimaNotaDebito.TabIndex = 21
        Me.C1NumericEditUltimaNotaDebito.Tag = "CM"
        Me.C1NumericEditUltimaNotaDebito.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1NumericEditUltimaNotaCredito
        '
        Me.C1NumericEditUltimaNotaCredito.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "UltimaNotaCredito", True))
        Me.C1NumericEditUltimaNotaCredito.DataType = GetType(Integer)
        Me.C1NumericEditUltimaNotaCredito.Enabled = False
        Me.C1NumericEditUltimaNotaCredito.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEditUltimaNotaCredito.Location = New System.Drawing.Point(310, 27)
        Me.C1NumericEditUltimaNotaCredito.Name = "C1NumericEditUltimaNotaCredito"
        Me.C1NumericEditUltimaNotaCredito.Size = New System.Drawing.Size(86, 18)
        Me.C1NumericEditUltimaNotaCredito.TabIndex = 20
        Me.C1NumericEditUltimaNotaCredito.Tag = "CM"
        Me.C1NumericEditUltimaNotaCredito.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1NumericEditUltimaTransferencia
        '
        Me.C1NumericEditUltimaTransferencia.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "UltimaTransferencia", True))
        Me.C1NumericEditUltimaTransferencia.DataType = GetType(Integer)
        Me.C1NumericEditUltimaTransferencia.Enabled = False
        Me.C1NumericEditUltimaTransferencia.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEditUltimaTransferencia.Location = New System.Drawing.Point(521, 30)
        Me.C1NumericEditUltimaTransferencia.Name = "C1NumericEditUltimaTransferencia"
        Me.C1NumericEditUltimaTransferencia.Size = New System.Drawing.Size(86, 18)
        Me.C1NumericEditUltimaTransferencia.TabIndex = 19
        Me.C1NumericEditUltimaTransferencia.Tag = "CM"
        Me.C1NumericEditUltimaTransferencia.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(413, 33)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(107, 13)
        Me.Label31.TabIndex = 5
        Me.Label31.Text = "Ultima Transferencia:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(193, 59)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(114, 13)
        Me.Label30.TabIndex = 4
        Me.Label30.Text = "Ultima Nota de Débito:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(193, 30)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(116, 13)
        Me.Label25.TabIndex = 3
        Me.Label25.Text = "Ultima Nota de Crédito:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(7, 59)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(84, 13)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Ultimo Depósito:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(7, 30)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(79, 13)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Ultimo Cheque:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.C1TextBoxCuentaAjuste)
        Me.GroupBox5.Controls.Add(Me.LabelCuentaAjuste)
        Me.GroupBox5.Controls.Add(Me.C1ButtonCuentaAjuste)
        Me.GroupBox5.Controls.Add(Me.C1NumericEditFactorCambio)
        Me.GroupBox5.Controls.Add(Me.C1CheckBoxCuentaExtranjera)
        Me.GroupBox5.Controls.Add(Me.C1ComboBoxMoneda)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label28)
        Me.GroupBox5.Controls.Add(Me.Label29)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 171)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(613, 101)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Moneda Extranjera"
        '
        'C1TextBoxCuentaAjuste
        '
        Me.C1TextBoxCuentaAjuste.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "CuentaAjuste", True))
        Me.C1TextBoxCuentaAjuste.Enabled = False
        Me.C1TextBoxCuentaAjuste.Location = New System.Drawing.Point(102, 68)
        Me.C1TextBoxCuentaAjuste.Name = "C1TextBoxCuentaAjuste"
        Me.C1TextBoxCuentaAjuste.Size = New System.Drawing.Size(171, 18)
        Me.C1TextBoxCuentaAjuste.TabIndex = 34
        Me.C1TextBoxCuentaAjuste.Tag = "CM"
        '
        'LabelCuentaAjuste
        '
        Me.LabelCuentaAjuste.AutoSize = True
        Me.LabelCuentaAjuste.Location = New System.Drawing.Point(311, 73)
        Me.LabelCuentaAjuste.Name = "LabelCuentaAjuste"
        Me.LabelCuentaAjuste.Size = New System.Drawing.Size(16, 13)
        Me.LabelCuentaAjuste.TabIndex = 33
        Me.LabelCuentaAjuste.Text = "..."
        '
        'C1ButtonCuentaAjuste
        '
        Me.C1ButtonCuentaAjuste.Enabled = False
        Me.C1ButtonCuentaAjuste.Image = Global.RSIContab.My.Resources.Resources._1425432924_Magnifier2
        Me.C1ButtonCuentaAjuste.Location = New System.Drawing.Point(279, 65)
        Me.C1ButtonCuentaAjuste.Name = "C1ButtonCuentaAjuste"
        Me.C1ButtonCuentaAjuste.Size = New System.Drawing.Size(26, 23)
        Me.C1ButtonCuentaAjuste.TabIndex = 33
        Me.C1ButtonCuentaAjuste.Tag = "CM"
        Me.C1ButtonCuentaAjuste.UseVisualStyleBackColor = True
        '
        'C1NumericEditFactorCambio
        '
        Me.C1NumericEditFactorCambio.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "FactorCambio", True))
        Me.C1NumericEditFactorCambio.Enabled = False
        Me.C1NumericEditFactorCambio.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEditFactorCambio.Location = New System.Drawing.Point(102, 43)
        Me.C1NumericEditFactorCambio.Name = "C1NumericEditFactorCambio"
        Me.C1NumericEditFactorCambio.Size = New System.Drawing.Size(171, 18)
        Me.C1NumericEditFactorCambio.TabIndex = 27
        Me.C1NumericEditFactorCambio.Tag = "CM"
        Me.C1NumericEditFactorCambio.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1CheckBoxCuentaExtranjera
        '
        Me.C1CheckBoxCuentaExtranjera.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1CheckBoxCuentaExtranjera.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "CuentaMonedaExtranjera", True))
        Me.C1CheckBoxCuentaExtranjera.Enabled = False
        Me.C1CheckBoxCuentaExtranjera.Location = New System.Drawing.Point(10, 19)
        Me.C1CheckBoxCuentaExtranjera.Name = "C1CheckBoxCuentaExtranjera"
        Me.C1CheckBoxCuentaExtranjera.Size = New System.Drawing.Size(179, 24)
        Me.C1CheckBoxCuentaExtranjera.TabIndex = 14
        Me.C1CheckBoxCuentaExtranjera.Text = "Cuenta en Moneda Extranjera"
        Me.C1CheckBoxCuentaExtranjera.UseVisualStyleBackColor = False
        Me.C1CheckBoxCuentaExtranjera.Value = Nothing
        '
        'C1ComboBoxMoneda
        '
        Me.C1ComboBoxMoneda.AllowSpinLoop = False
        Me.C1ComboBoxMoneda.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "CodigoMoneda", True))
        Me.C1ComboBoxMoneda.DataType = GetType(Short)
        Me.C1ComboBoxMoneda.Enabled = False
        Me.C1ComboBoxMoneda.GapHeight = 0
        Me.C1ComboBoxMoneda.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1ComboBoxMoneda.ItemsDisplayMember = ""
        Me.C1ComboBoxMoneda.ItemsValueMember = ""
        Me.C1ComboBoxMoneda.Location = New System.Drawing.Point(370, 20)
        Me.C1ComboBoxMoneda.Name = "C1ComboBoxMoneda"
        Me.C1ComboBoxMoneda.Size = New System.Drawing.Size(214, 18)
        Me.C1ComboBoxMoneda.TabIndex = 13
        Me.C1ComboBoxMoneda.Tag = "CM"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(307, 19)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 13)
        Me.Label24.TabIndex = 12
        Me.Label24.Text = "Moneda:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(7, 70)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(91, 13)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Cuenta de Ajuste:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(7, 46)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(93, 13)
        Me.Label29.TabIndex = 1
        Me.Label29.Text = "Factor de Cambio:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.C1ButtonRecalcularSaldos)
        Me.GroupBox4.Controls.Add(Me.LabelCuentaContable)
        Me.GroupBox4.Controls.Add(Me.C1NumericEditCodigo)
        Me.GroupBox4.Controls.Add(Me.C1TextBoxCuentaBancaria)
        Me.GroupBox4.Controls.Add(Me.C1TextBoxFormatoCheque)
        Me.GroupBox4.Controls.Add(Me.C1ButtonCuentaContable)
        Me.GroupBox4.Controls.Add(Me.C1ComboBoxImpresora)
        Me.GroupBox4.Controls.Add(Me.C1TextBoxCuentaContable)
        Me.GroupBox4.Controls.Add(Me.C1TextBoxDescripcion)
        Me.GroupBox4.Controls.Add(Me.C1NumericEditMontoSobregiro)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(613, 147)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'C1ButtonRecalcularSaldos
        '
        Me.C1ButtonRecalcularSaldos.Location = New System.Drawing.Point(451, 9)
        Me.C1ButtonRecalcularSaldos.Name = "C1ButtonRecalcularSaldos"
        Me.C1ButtonRecalcularSaldos.Size = New System.Drawing.Size(132, 23)
        Me.C1ButtonRecalcularSaldos.TabIndex = 32
        Me.C1ButtonRecalcularSaldos.Text = "Recalcular Saldos"
        Me.C1ButtonRecalcularSaldos.UseVisualStyleBackColor = True
        '
        'LabelCuentaContable
        '
        Me.LabelCuentaContable.AutoSize = True
        Me.LabelCuentaContable.Location = New System.Drawing.Point(280, 71)
        Me.LabelCuentaContable.Name = "LabelCuentaContable"
        Me.LabelCuentaContable.Size = New System.Drawing.Size(16, 13)
        Me.LabelCuentaContable.TabIndex = 31
        Me.LabelCuentaContable.Text = "..."
        '
        'C1NumericEditCodigo
        '
        Me.C1NumericEditCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "CodigoBanco", True))
        Me.C1NumericEditCodigo.DataType = GetType(Short)
        Me.C1NumericEditCodigo.Enabled = False
        Me.C1NumericEditCodigo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEditCodigo.Location = New System.Drawing.Point(101, 22)
        Me.C1NumericEditCodigo.Name = "C1NumericEditCodigo"
        Me.C1NumericEditCodigo.Size = New System.Drawing.Size(77, 18)
        Me.C1NumericEditCodigo.TabIndex = 29
        Me.C1NumericEditCodigo.Tag = "CO"
        Me.C1NumericEditCodigo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1TextBoxCuentaBancaria
        '
        Me.C1TextBoxCuentaBancaria.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "CuentaBancaria", True))
        Me.C1TextBoxCuentaBancaria.Enabled = False
        Me.C1TextBoxCuentaBancaria.Location = New System.Drawing.Point(101, 94)
        Me.C1TextBoxCuentaBancaria.Name = "C1TextBoxCuentaBancaria"
        Me.C1TextBoxCuentaBancaria.Size = New System.Drawing.Size(174, 18)
        Me.C1TextBoxCuentaBancaria.TabIndex = 26
        Me.C1TextBoxCuentaBancaria.Tag = "CMO"
        '
        'C1TextBoxFormatoCheque
        '
        Me.C1TextBoxFormatoCheque.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "FormatoCheque", True))
        Me.C1TextBoxFormatoCheque.Enabled = False
        Me.C1TextBoxFormatoCheque.Location = New System.Drawing.Point(101, 118)
        Me.C1TextBoxFormatoCheque.Name = "C1TextBoxFormatoCheque"
        Me.C1TextBoxFormatoCheque.Size = New System.Drawing.Size(174, 18)
        Me.C1TextBoxFormatoCheque.TabIndex = 25
        Me.C1TextBoxFormatoCheque.Tag = "CM"
        '
        'C1ButtonCuentaContable
        '
        Me.C1ButtonCuentaContable.Enabled = False
        Me.C1ButtonCuentaContable.Image = Global.RSIContab.My.Resources.Resources._1425432924_Magnifier2
        Me.C1ButtonCuentaContable.Location = New System.Drawing.Point(247, 68)
        Me.C1ButtonCuentaContable.Name = "C1ButtonCuentaContable"
        Me.C1ButtonCuentaContable.Size = New System.Drawing.Size(26, 23)
        Me.C1ButtonCuentaContable.TabIndex = 14
        Me.C1ButtonCuentaContable.Tag = "CM"
        Me.C1ButtonCuentaContable.UseVisualStyleBackColor = True
        '
        'C1ComboBoxImpresora
        '
        Me.C1ComboBoxImpresora.AllowSpinLoop = False
        Me.C1ComboBoxImpresora.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "ImpresoraCheques", True))
        Me.C1ComboBoxImpresora.Enabled = False
        Me.C1ComboBoxImpresora.GapHeight = 0
        Me.C1ComboBoxImpresora.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1ComboBoxImpresora.ItemsDisplayMember = ""
        Me.C1ComboBoxImpresora.ItemsValueMember = ""
        Me.C1ComboBoxImpresora.Location = New System.Drawing.Point(370, 116)
        Me.C1ComboBoxImpresora.Name = "C1ComboBoxImpresora"
        Me.C1ComboBoxImpresora.Size = New System.Drawing.Size(214, 18)
        Me.C1ComboBoxImpresora.TabIndex = 13
        Me.C1ComboBoxImpresora.Tag = "CM"
        '
        'C1TextBoxCuentaContable
        '
        Me.C1TextBoxCuentaContable.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "CuentaContable", True))
        Me.C1TextBoxCuentaContable.Enabled = False
        Me.C1TextBoxCuentaContable.Location = New System.Drawing.Point(102, 70)
        Me.C1TextBoxCuentaContable.Name = "C1TextBoxCuentaContable"
        Me.C1TextBoxCuentaContable.Size = New System.Drawing.Size(139, 18)
        Me.C1TextBoxCuentaContable.TabIndex = 12
        Me.C1TextBoxCuentaContable.Tag = "CO"
        '
        'C1TextBoxDescripcion
        '
        Me.C1TextBoxDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DescripcionBanco", True))
        Me.C1TextBoxDescripcion.Enabled = False
        Me.C1TextBoxDescripcion.Location = New System.Drawing.Point(101, 46)
        Me.C1TextBoxDescripcion.Name = "C1TextBoxDescripcion"
        Me.C1TextBoxDescripcion.Size = New System.Drawing.Size(483, 18)
        Me.C1TextBoxDescripcion.TabIndex = 11
        Me.C1TextBoxDescripcion.Tag = "CMO"
        '
        'C1NumericEditMontoSobregiro
        '
        Me.C1NumericEditMontoSobregiro.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "MontoSobregiro", True))
        Me.C1NumericEditMontoSobregiro.Enabled = False
        Me.C1NumericEditMontoSobregiro.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEditMontoSobregiro.Location = New System.Drawing.Point(417, 87)
        Me.C1NumericEditMontoSobregiro.Name = "C1NumericEditMontoSobregiro"
        Me.C1NumericEditMontoSobregiro.Size = New System.Drawing.Size(167, 18)
        Me.C1NumericEditMontoSobregiro.TabIndex = 10
        Me.C1NumericEditMontoSobregiro.Tag = "CM"
        Me.C1NumericEditMontoSobregiro.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(307, 116)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 13)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "Impresora:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(307, 87)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(103, 13)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Monto de Sobregiro:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 94)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(89, 13)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Cuenta Bancaria:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(7, 116)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 13)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Formato Cheque:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(7, 68)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Cuenta Contable:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 13)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Descripción:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Código:"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.C1TrueDBGrid1)
        Me.TabPage4.Controls.Add(Me.GroupBox7)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(626, 419)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Estadisticas"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.C1TrueDBGrid1.DataSource = Me.BATransEncBindingSource
        Me.C1TrueDBGrid1.Enabled = False
        Me.C1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(16, 172)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(603, 241)
        Me.C1TrueDBGrid1.TabIndex = 1
        Me.C1TrueDBGrid1.UseCompatibleTextRendering = False
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.C1NumericEditSaldoActual)
        Me.GroupBox7.Controls.Add(Me.C1NumericEditCreditos)
        Me.GroupBox7.Controls.Add(Me.C1NumericEditDebitos)
        Me.GroupBox7.Controls.Add(Me.C1NumericEditDepositos)
        Me.GroupBox7.Controls.Add(Me.C1NumericEditCheques)
        Me.GroupBox7.Controls.Add(Me.C1NumericEditSaldoAnterior)
        Me.GroupBox7.Controls.Add(Me.GroupBox8)
        Me.GroupBox7.Controls.Add(Me.Label37)
        Me.GroupBox7.Controls.Add(Me.Label36)
        Me.GroupBox7.Controls.Add(Me.Label35)
        Me.GroupBox7.Controls.Add(Me.Label34)
        Me.GroupBox7.Controls.Add(Me.Label33)
        Me.GroupBox7.Controls.Add(Me.Label32)
        Me.GroupBox7.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(603, 149)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Saldos"
        '
        'C1NumericEditSaldoActual
        '
        Me.C1NumericEditSaldoActual.Enabled = False
        Me.C1NumericEditSaldoActual.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEditSaldoActual.Location = New System.Drawing.Point(490, 45)
        Me.C1NumericEditSaldoActual.Name = "C1NumericEditSaldoActual"
        Me.C1NumericEditSaldoActual.Size = New System.Drawing.Size(89, 18)
        Me.C1NumericEditSaldoActual.TabIndex = 18
        Me.C1NumericEditSaldoActual.Tag = Nothing
        Me.C1NumericEditSaldoActual.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1NumericEditCreditos
        '
        Me.C1NumericEditCreditos.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSourceSaldos, "NotasCredito", True))
        Me.C1NumericEditCreditos.Enabled = False
        Me.C1NumericEditCreditos.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEditCreditos.Location = New System.Drawing.Point(395, 45)
        Me.C1NumericEditCreditos.Name = "C1NumericEditCreditos"
        Me.C1NumericEditCreditos.Size = New System.Drawing.Size(89, 18)
        Me.C1NumericEditCreditos.TabIndex = 17
        Me.C1NumericEditCreditos.Tag = Nothing
        Me.C1NumericEditCreditos.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1NumericEditDebitos
        '
        Me.C1NumericEditDebitos.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSourceSaldos, "NotasDebito", True))
        Me.C1NumericEditDebitos.Enabled = False
        Me.C1NumericEditDebitos.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEditDebitos.Location = New System.Drawing.Point(300, 45)
        Me.C1NumericEditDebitos.Name = "C1NumericEditDebitos"
        Me.C1NumericEditDebitos.Size = New System.Drawing.Size(89, 18)
        Me.C1NumericEditDebitos.TabIndex = 16
        Me.C1NumericEditDebitos.Tag = Nothing
        Me.C1NumericEditDebitos.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1NumericEditDepositos
        '
        Me.C1NumericEditDepositos.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSourceSaldos, "Depositos", True))
        Me.C1NumericEditDepositos.Enabled = False
        Me.C1NumericEditDepositos.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEditDepositos.Location = New System.Drawing.Point(205, 45)
        Me.C1NumericEditDepositos.Name = "C1NumericEditDepositos"
        Me.C1NumericEditDepositos.Size = New System.Drawing.Size(89, 18)
        Me.C1NumericEditDepositos.TabIndex = 15
        Me.C1NumericEditDepositos.Tag = Nothing
        Me.C1NumericEditDepositos.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1NumericEditCheques
        '
        Me.C1NumericEditCheques.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSourceSaldos, "Cheques", True))
        Me.C1NumericEditCheques.Enabled = False
        Me.C1NumericEditCheques.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEditCheques.Location = New System.Drawing.Point(110, 45)
        Me.C1NumericEditCheques.Name = "C1NumericEditCheques"
        Me.C1NumericEditCheques.Size = New System.Drawing.Size(89, 18)
        Me.C1NumericEditCheques.TabIndex = 14
        Me.C1NumericEditCheques.Tag = Nothing
        Me.C1NumericEditCheques.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1NumericEditSaldoAnterior
        '
        Me.C1NumericEditSaldoAnterior.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSourceSaldos, "SaldoAnterior", True))
        Me.C1NumericEditSaldoAnterior.Enabled = False
        Me.C1NumericEditSaldoAnterior.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEditSaldoAnterior.Location = New System.Drawing.Point(15, 45)
        Me.C1NumericEditSaldoAnterior.Name = "C1NumericEditSaldoAnterior"
        Me.C1NumericEditSaldoAnterior.Size = New System.Drawing.Size(89, 18)
        Me.C1NumericEditSaldoAnterior.TabIndex = 13
        Me.C1NumericEditSaldoAnterior.Tag = "CM"
        Me.C1NumericEditSaldoAnterior.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.C1NumericEditSaldoActualEquiv)
        Me.GroupBox8.Controls.Add(Me.C1NumericEditCreditosValEquiv)
        Me.GroupBox8.Controls.Add(Me.C1NumericEditDebitosValEquiv)
        Me.GroupBox8.Controls.Add(Me.C1NumericEditDepositosValEquiv)
        Me.GroupBox8.Controls.Add(Me.C1NumericEditChequesValEquiv)
        Me.GroupBox8.Controls.Add(Me.C1NumericEditSaldoAnteriorValEquiv)
        Me.GroupBox8.Location = New System.Drawing.Point(0, 79)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(603, 70)
        Me.GroupBox8.TabIndex = 12
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Valores Equivalentes"
        '
        'C1NumericEditSaldoActualEquiv
        '
        Me.C1NumericEditSaldoActualEquiv.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "MontoSobregiro", True))
        Me.C1NumericEditSaldoActualEquiv.Enabled = False
        Me.C1NumericEditSaldoActualEquiv.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEditSaldoActualEquiv.Location = New System.Drawing.Point(490, 35)
        Me.C1NumericEditSaldoActualEquiv.Name = "C1NumericEditSaldoActualEquiv"
        Me.C1NumericEditSaldoActualEquiv.Size = New System.Drawing.Size(89, 18)
        Me.C1NumericEditSaldoActualEquiv.TabIndex = 24
        Me.C1NumericEditSaldoActualEquiv.Tag = Nothing
        Me.C1NumericEditSaldoActualEquiv.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1NumericEditCreditosValEquiv
        '
        Me.C1NumericEditCreditosValEquiv.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSourceSaldos, "NotasCreditoEquivalente", True))
        Me.C1NumericEditCreditosValEquiv.Enabled = False
        Me.C1NumericEditCreditosValEquiv.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEditCreditosValEquiv.Location = New System.Drawing.Point(395, 35)
        Me.C1NumericEditCreditosValEquiv.Name = "C1NumericEditCreditosValEquiv"
        Me.C1NumericEditCreditosValEquiv.Size = New System.Drawing.Size(89, 18)
        Me.C1NumericEditCreditosValEquiv.TabIndex = 23
        Me.C1NumericEditCreditosValEquiv.Tag = Nothing
        Me.C1NumericEditCreditosValEquiv.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1NumericEditDebitosValEquiv
        '
        Me.C1NumericEditDebitosValEquiv.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSourceSaldos, "NotasDebitoEquivalente", True))
        Me.C1NumericEditDebitosValEquiv.Enabled = False
        Me.C1NumericEditDebitosValEquiv.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEditDebitosValEquiv.Location = New System.Drawing.Point(300, 35)
        Me.C1NumericEditDebitosValEquiv.Name = "C1NumericEditDebitosValEquiv"
        Me.C1NumericEditDebitosValEquiv.Size = New System.Drawing.Size(89, 18)
        Me.C1NumericEditDebitosValEquiv.TabIndex = 22
        Me.C1NumericEditDebitosValEquiv.Tag = Nothing
        Me.C1NumericEditDebitosValEquiv.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1NumericEditDepositosValEquiv
        '
        Me.C1NumericEditDepositosValEquiv.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSourceSaldos, "DepositosEquivalente", True))
        Me.C1NumericEditDepositosValEquiv.Enabled = False
        Me.C1NumericEditDepositosValEquiv.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEditDepositosValEquiv.Location = New System.Drawing.Point(205, 35)
        Me.C1NumericEditDepositosValEquiv.Name = "C1NumericEditDepositosValEquiv"
        Me.C1NumericEditDepositosValEquiv.Size = New System.Drawing.Size(89, 18)
        Me.C1NumericEditDepositosValEquiv.TabIndex = 21
        Me.C1NumericEditDepositosValEquiv.Tag = Nothing
        Me.C1NumericEditDepositosValEquiv.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1NumericEditChequesValEquiv
        '
        Me.C1NumericEditChequesValEquiv.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSourceSaldos, "ChequesEquivalente", True))
        Me.C1NumericEditChequesValEquiv.Enabled = False
        Me.C1NumericEditChequesValEquiv.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEditChequesValEquiv.Location = New System.Drawing.Point(110, 35)
        Me.C1NumericEditChequesValEquiv.Name = "C1NumericEditChequesValEquiv"
        Me.C1NumericEditChequesValEquiv.Size = New System.Drawing.Size(89, 18)
        Me.C1NumericEditChequesValEquiv.TabIndex = 20
        Me.C1NumericEditChequesValEquiv.Tag = Nothing
        Me.C1NumericEditChequesValEquiv.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1NumericEditSaldoAnteriorValEquiv
        '
        Me.C1NumericEditSaldoAnteriorValEquiv.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSourceSaldos, "SaldoAnteriorEquivalente", True))
        Me.C1NumericEditSaldoAnteriorValEquiv.Enabled = False
        Me.C1NumericEditSaldoAnteriorValEquiv.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEditSaldoAnteriorValEquiv.Location = New System.Drawing.Point(15, 35)
        Me.C1NumericEditSaldoAnteriorValEquiv.Name = "C1NumericEditSaldoAnteriorValEquiv"
        Me.C1NumericEditSaldoAnteriorValEquiv.Size = New System.Drawing.Size(89, 18)
        Me.C1NumericEditSaldoAnteriorValEquiv.TabIndex = 19
        Me.C1NumericEditSaldoAnteriorValEquiv.Tag = "CM"
        Me.C1NumericEditSaldoAnteriorValEquiv.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(128, 29)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(49, 13)
        Me.Label37.TabIndex = 5
        Me.Label37.Text = "Cheques"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(219, 29)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(54, 13)
        Me.Label36.TabIndex = 4
        Me.Label36.Text = "Dépositos"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(320, 29)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(43, 13)
        Me.Label35.TabIndex = 3
        Me.Label35.Text = "Débitos"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(420, 29)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(45, 13)
        Me.Label34.TabIndex = 2
        Me.Label34.Text = "Créditos"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(516, 29)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(37, 13)
        Me.Label33.TabIndex = 1
        Me.Label33.Text = "Actual"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(35, 29)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(43, 13)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Anterior"
        '
        'EditDataNavBarPrin
        '
        Me.EditDataNavBarPrin.BindingSourcePrincipal = Nothing
        Me.EditDataNavBarPrin.Dock = System.Windows.Forms.DockStyle.Top
        Me.EditDataNavBarPrin.Location = New System.Drawing.Point(0, 0)
        Me.EditDataNavBarPrin.Modalidad = Nothing
        Me.EditDataNavBarPrin.ModificarRegistro = False
        Me.EditDataNavBarPrin.Name = "EditDataNavBarPrin"
        Me.EditDataNavBarPrin.NuevoRegistro = False
        Me.EditDataNavBarPrin.ResultadoValidacion = Nothing
        Me.EditDataNavBarPrin.Size = New System.Drawing.Size(658, 66)
        Me.EditDataNavBarPrin.TabIndex = 1
        Me.EditDataNavBarPrin.ValidacionCorrecta = False
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "BABancos"
        Me.PrincipalBindingSource.DataSource = Me.BABancosEdicionDataSet
        '
        'BABancosEdicionDataSet
        '
        Me.BABancosEdicionDataSet.DataSetName = "BABancosEdicionDataSet"
        Me.BABancosEdicionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BATransEncBindingSource
        '
        Me.BATransEncBindingSource.DataMember = "BATransaccionesEncabezado"
        Me.BATransEncBindingSource.DataSource = Me.BABancosEdicionDataSet
        '
        'BindingSourceSaldos
        '
        Me.BindingSourceSaldos.DataMember = "BASaldosMensuales"
        Me.BindingSourceSaldos.DataSource = Me.BABancosEdicionDataSet
        '
        'BABancosTableAdapter
        '
        Me.BABancosTableAdapter.ClearBeforeFill = True
        '
        'BATransaccionesEncabezadoTableAdapter
        '
        Me.BATransaccionesEncabezadoTableAdapter.ClearBeforeFill = True
        '
        'CTCatalogoBindingSource
        '
        Me.CTCatalogoBindingSource.DataMember = "CTCatalogoCuentas"
        Me.CTCatalogoBindingSource.DataSource = Me.BABancosEdicionDataSet
        '
        'BASaldosMensualesTableAdapter
        '
        Me.BASaldosMensualesTableAdapter.ClearBeforeFill = True
        '
        'CTCatalogoCuentasTableAdapter
        '
        Me.CTCatalogoCuentasTableAdapter.ClearBeforeFill = True
        '
        'BATransaccionesDetBindingSource
        '
        Me.BATransaccionesDetBindingSource.DataMember = "BATransaccionesDetalle"
        Me.BATransaccionesDetBindingSource.DataSource = Me.BABancosEdicionDataSet
        '
        'BATransaccionesDetalleTableAdapter
        '
        Me.BATransaccionesDetalleTableAdapter.ClearBeforeFill = True
        '
        'BABancosEdicionFrm
        '
        Me.ClientSize = New System.Drawing.Size(658, 523)
        Me.Controls.Add(Me.EditDataNavBarPrin)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "BABancosEdicionFrm"
        Me.Text = "Edición de Bancos"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.C1NumericEditUltimoDeposito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEditUltimoCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEditUltimaNotaDebito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEditUltimaNotaCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEditUltimaTransferencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.C1TextBoxCuentaAjuste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ButtonCuentaAjuste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEditFactorCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CheckBoxCuentaExtranjera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ComboBoxMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.C1ButtonRecalcularSaldos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEditCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBoxCuentaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBoxFormatoCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ButtonCuentaContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ComboBoxImpresora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBoxCuentaContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBoxDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEditMontoSobregiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.C1NumericEditSaldoActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEditCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEditDebitos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEditDepositos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEditCheques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEditSaldoAnterior, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.C1NumericEditSaldoActualEquiv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEditCreditosValEquiv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEditDebitosValEquiv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEditDepositosValEquiv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEditChequesValEquiv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEditSaldoAnteriorValEquiv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BABancosEdicionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BATransEncBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceSaldos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTCatalogoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BATransaccionesDetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCuentaAjuste As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents C1CheckBoxMonedaExtranjera As C1.Win.C1Input.C1CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents C1ButtonBuscarCtaContable As C1.Win.C1Input.C1Button
    Friend WithEvents txtCodigo As MaskedTextBox
    Friend WithEvents txtCuentaContable As MaskedTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents C1Button1 As C1.Win.C1Input.C1Button
    'Friend WithEvents EditDataNavBar1 As EditDataNavBar
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents PrincipalBindingSource As BindingSource
    Friend WithEvents BABancosEdicionDataSet As BABancosEdicionDataSet
    Friend WithEvents BABancosTableAdapter As BABancosEdicionDataSetTableAdapters.BABancosTableAdapter
    Friend WithEvents EditDataNavBarPrin As EditDataNavBar
    Friend WithEvents C1TextBoxCuentaContable As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBoxDescripcion As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1ComboBoxMoneda As C1.Win.C1Input.C1ComboBox
    Friend WithEvents C1ButtonCuentaContable As C1.Win.C1Input.C1Button
    Friend WithEvents C1ComboBoxImpresora As C1.Win.C1Input.C1ComboBox
    Friend WithEvents C1NumericEditMontoSobregiro As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEditUltimoDeposito As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEditUltimoCheque As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEditUltimaNotaDebito As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEditUltimaNotaCredito As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEditUltimaTransferencia As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1CheckBoxCuentaExtranjera As C1.Win.C1Input.C1CheckBox
    Friend WithEvents C1TextBoxFormatoCheque As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1NumericEditFactorCambio As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1ButtonRecalcularSaldos As C1.Win.C1Input.C1Button
    Friend WithEvents LabelCuentaContable As Label
    Friend WithEvents C1NumericEditCodigo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1TextBoxCuentaBancaria As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1NumericEditDepositos As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEditCheques As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEditCreditos As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEditDebitos As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEditSaldoActual As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEditChequesValEquiv As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEditSaldoAnteriorValEquiv As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEditDepositosValEquiv As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEditSaldoAnterior As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1NumericEditSaldoActualEquiv As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEditCreditosValEquiv As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEditDebitosValEquiv As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents BATransEncBindingSource As BindingSource
    Friend WithEvents BATransaccionesEncabezadoTableAdapter As BABancosEdicionDataSetTableAdapters.BATransaccionesEncabezadoTableAdapter
    Friend WithEvents BindingSourceSaldos As BindingSource
    Friend WithEvents LabelCuentaAjuste As Label
    Friend WithEvents C1ButtonCuentaAjuste As C1.Win.C1Input.C1Button
    Friend WithEvents C1TextBoxCuentaAjuste As C1.Win.C1Input.C1TextBox
    Friend WithEvents CTCatalogoBindingSource As BindingSource
    Friend WithEvents BASaldosMensualesTableAdapter As BABancosEdicionDataSetTableAdapters.BASaldosMensualesTableAdapter
    Friend WithEvents CTCatalogoCuentasTableAdapter As BABancosEdicionDataSetTableAdapters.CTCatalogoCuentasTableAdapter
    Friend WithEvents BATransaccionesDetBindingSource As BindingSource
    Friend WithEvents BATransaccionesDetalleTableAdapter As BABancosEdicionDataSetTableAdapters.BATransaccionesDetalleTableAdapter
End Class
