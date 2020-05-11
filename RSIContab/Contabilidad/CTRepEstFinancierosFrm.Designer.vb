<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTRepEstFinancierosFrm
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
        Me.c1dateFecha = New C1.Win.C1Input.C1DateEdit()
        Me.c1numFactorCambio = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numCompararAnio = New C1.Win.C1Input.C1NumericEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.chkboxFechasIniFin = New System.Windows.Forms.CheckBox()
        Me.chkboxMostrarTituloMoneda = New System.Windows.Forms.CheckBox()
        Me.chkboxSuprimirSaldosCeros = New System.Windows.Forms.CheckBox()
        Me.chkboxCompAñoAnt = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radiobutMensuales = New System.Windows.Forms.RadioButton()
        Me.radiobutSaldosAnuales = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.numupdnNivelCta3 = New System.Windows.Forms.NumericUpDown()
        Me.numupdnNivelCta2 = New System.Windows.Forms.NumericUpDown()
        Me.numupdnNivelCta1 = New System.Windows.Forms.NumericUpDown()
        Me.lblNivelCta3 = New System.Windows.Forms.Label()
        Me.lblNivelCta2 = New System.Windows.Forms.Label()
        Me.lblNivelCta1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbMeses = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.c1numAñoUsuario = New C1.Win.C1Input.C1NumericEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkboxUtilizarPeriodoUsuario = New System.Windows.Forms.CheckBox()
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numFactorCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numCompararAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numupdnNivelCta3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numupdnNivelCta2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numupdnNivelCta1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.c1numAñoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.c1dateFecha.Location = New System.Drawing.Point(102, 89)
        Me.c1dateFecha.Name = "c1dateFecha"
        Me.c1dateFecha.Size = New System.Drawing.Size(105, 20)
        Me.c1dateFecha.TabIndex = 19
        Me.c1dateFecha.Tag = Nothing
        Me.c1dateFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'c1numFactorCambio
        '
        Me.c1numFactorCambio.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numFactorCambio.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numFactorCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numFactorCambio.Location = New System.Drawing.Point(128, 294)
        Me.c1numFactorCambio.Name = "c1numFactorCambio"
        Me.c1numFactorCambio.Size = New System.Drawing.Size(79, 20)
        Me.c1numFactorCambio.TabIndex = 27
        Me.c1numFactorCambio.Tag = Nothing
        Me.c1numFactorCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numFactorCambio.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1numFactorCambio.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numCompararAnio
        '
        Me.c1numCompararAnio.DataType = GetType(Short)
        Me.c1numCompararAnio.Location = New System.Drawing.Point(131, 228)
        Me.c1numCompararAnio.Name = "c1numCompararAnio"
        Me.c1numCompararAnio.Size = New System.Drawing.Size(50, 20)
        Me.c1numCompararAnio.TabIndex = 24
        Me.c1numCompararAnio.Tag = Nothing
        Me.c1numCompararAnio.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Factor de Cambio:"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(158, 349)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(89, 33)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(9, 349)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(89, 33)
        Me.btnAceptar.TabIndex = 16
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'chkboxFechasIniFin
        '
        Me.chkboxFechasIniFin.AutoSize = True
        Me.chkboxFechasIniFin.Location = New System.Drawing.Point(9, 320)
        Me.chkboxFechasIniFin.Name = "chkboxFechasIniFin"
        Me.chkboxFechasIniFin.Size = New System.Drawing.Size(241, 17)
        Me.chkboxFechasIniFin.TabIndex = 28
        Me.chkboxFechasIniFin.Text = "Mostrar Fechas Iniciales y Finales en el Título"
        Me.chkboxFechasIniFin.UseVisualStyleBackColor = True
        '
        'chkboxMostrarTituloMoneda
        '
        Me.chkboxMostrarTituloMoneda.AutoSize = True
        Me.chkboxMostrarTituloMoneda.Location = New System.Drawing.Point(9, 274)
        Me.chkboxMostrarTituloMoneda.Name = "chkboxMostrarTituloMoneda"
        Me.chkboxMostrarTituloMoneda.Size = New System.Drawing.Size(149, 17)
        Me.chkboxMostrarTituloMoneda.TabIndex = 26
        Me.chkboxMostrarTituloMoneda.Text = "Mostrar Título de Moneda"
        Me.chkboxMostrarTituloMoneda.UseVisualStyleBackColor = True
        '
        'chkboxSuprimirSaldosCeros
        '
        Me.chkboxSuprimirSaldosCeros.AutoSize = True
        Me.chkboxSuprimirSaldosCeros.Location = New System.Drawing.Point(9, 251)
        Me.chkboxSuprimirSaldosCeros.Name = "chkboxSuprimirSaldosCeros"
        Me.chkboxSuprimirSaldosCeros.Size = New System.Drawing.Size(138, 17)
        Me.chkboxSuprimirSaldosCeros.TabIndex = 25
        Me.chkboxSuprimirSaldosCeros.Text = "Suprimir Saldos en Cero"
        Me.chkboxSuprimirSaldosCeros.UseVisualStyleBackColor = True
        '
        'chkboxCompAñoAnt
        '
        Me.chkboxCompAñoAnt.AutoSize = True
        Me.chkboxCompAñoAnt.Location = New System.Drawing.Point(9, 228)
        Me.chkboxCompAñoAnt.Name = "chkboxCompAñoAnt"
        Me.chkboxCompAñoAnt.Size = New System.Drawing.Size(117, 17)
        Me.chkboxCompAñoAnt.TabIndex = 23
        Me.chkboxCompAñoAnt.Text = "Comparar con Año:"
        Me.chkboxCompAñoAnt.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radiobutMensuales)
        Me.GroupBox2.Controls.Add(Me.radiobutSaldosAnuales)
        Me.GroupBox2.Location = New System.Drawing.Point(131, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(116, 99)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Saldos a Listar"
        '
        'radiobutMensuales
        '
        Me.radiobutMensuales.AutoSize = True
        Me.radiobutMensuales.Location = New System.Drawing.Point(13, 42)
        Me.radiobutMensuales.Name = "radiobutMensuales"
        Me.radiobutMensuales.Size = New System.Drawing.Size(76, 17)
        Me.radiobutMensuales.TabIndex = 9
        Me.radiobutMensuales.Text = "Mensuales"
        Me.radiobutMensuales.UseVisualStyleBackColor = True
        '
        'radiobutSaldosAnuales
        '
        Me.radiobutSaldosAnuales.AutoSize = True
        Me.radiobutSaldosAnuales.Checked = True
        Me.radiobutSaldosAnuales.Location = New System.Drawing.Point(13, 19)
        Me.radiobutSaldosAnuales.Name = "radiobutSaldosAnuales"
        Me.radiobutSaldosAnuales.Size = New System.Drawing.Size(63, 17)
        Me.radiobutSaldosAnuales.TabIndex = 8
        Me.radiobutSaldosAnuales.TabStop = True
        Me.radiobutSaldosAnuales.Text = "Anuales"
        Me.radiobutSaldosAnuales.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.numupdnNivelCta3)
        Me.GroupBox1.Controls.Add(Me.numupdnNivelCta2)
        Me.GroupBox1.Controls.Add(Me.numupdnNivelCta1)
        Me.GroupBox1.Controls.Add(Me.lblNivelCta3)
        Me.GroupBox1.Controls.Add(Me.lblNivelCta2)
        Me.GroupBox1.Controls.Add(Me.lblNivelCta1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(116, 99)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Niveles a Listar"
        '
        'numupdnNivelCta3
        '
        Me.numupdnNivelCta3.Location = New System.Drawing.Point(53, 71)
        Me.numupdnNivelCta3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numupdnNivelCta3.Name = "numupdnNivelCta3"
        Me.numupdnNivelCta3.Size = New System.Drawing.Size(35, 20)
        Me.numupdnNivelCta3.TabIndex = 6
        Me.numupdnNivelCta3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numupdnNivelCta2
        '
        Me.numupdnNivelCta2.Location = New System.Drawing.Point(54, 45)
        Me.numupdnNivelCta2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numupdnNivelCta2.Name = "numupdnNivelCta2"
        Me.numupdnNivelCta2.Size = New System.Drawing.Size(35, 20)
        Me.numupdnNivelCta2.TabIndex = 5
        Me.numupdnNivelCta2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numupdnNivelCta1
        '
        Me.numupdnNivelCta1.Location = New System.Drawing.Point(53, 19)
        Me.numupdnNivelCta1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numupdnNivelCta1.Name = "numupdnNivelCta1"
        Me.numupdnNivelCta1.Size = New System.Drawing.Size(35, 20)
        Me.numupdnNivelCta1.TabIndex = 4
        Me.numupdnNivelCta1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblNivelCta3
        '
        Me.lblNivelCta3.AutoSize = True
        Me.lblNivelCta3.Location = New System.Drawing.Point(6, 70)
        Me.lblNivelCta3.Name = "lblNivelCta3"
        Me.lblNivelCta3.Size = New System.Drawing.Size(42, 13)
        Me.lblNivelCta3.TabIndex = 3
        Me.lblNivelCta3.Text = "Capital:"
        '
        'lblNivelCta2
        '
        Me.lblNivelCta2.AutoSize = True
        Me.lblNivelCta2.Location = New System.Drawing.Point(6, 47)
        Me.lblNivelCta2.Name = "lblNivelCta2"
        Me.lblNivelCta2.Size = New System.Drawing.Size(42, 13)
        Me.lblNivelCta2.TabIndex = 2
        Me.lblNivelCta2.Text = "Pasivo:"
        '
        'lblNivelCta1
        '
        Me.lblNivelCta1.AutoSize = True
        Me.lblNivelCta1.Location = New System.Drawing.Point(6, 25)
        Me.lblNivelCta1.Name = "lblNivelCta1"
        Me.lblNivelCta1.Size = New System.Drawing.Size(40, 13)
        Me.lblNivelCta1.TabIndex = 1
        Me.lblNivelCta1.Text = "Activo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Fecha:"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPeriodo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodo.ForeColor = System.Drawing.Color.White
        Me.lblPeriodo.Location = New System.Drawing.Point(0, 0)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(260, 20)
        Me.lblPeriodo.TabIndex = 29
        Me.lblPeriodo.Text = "Periodo Actual"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbMeses)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.c1numAñoUsuario)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.chkboxUtilizarPeriodoUsuario)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(238, 52)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        '
        'cmbMeses
        '
        Me.cmbMeses.FormattingEnabled = True
        Me.cmbMeses.Location = New System.Drawing.Point(131, 19)
        Me.cmbMeses.Name = "cmbMeses"
        Me.cmbMeses.Size = New System.Drawing.Size(101, 21)
        Me.cmbMeses.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Mes:"
        '
        'c1numAñoUsuario
        '
        Me.c1numAñoUsuario.DataType = GetType(Short)
        Me.c1numAñoUsuario.Location = New System.Drawing.Point(41, 23)
        Me.c1numAñoUsuario.Name = "c1numAñoUsuario"
        Me.c1numAñoUsuario.Size = New System.Drawing.Size(50, 20)
        Me.c1numAñoUsuario.TabIndex = 25
        Me.c1numAñoUsuario.Tag = Nothing
        Me.c1numAñoUsuario.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Año:"
        '
        'chkboxUtilizarPeriodoUsuario
        '
        Me.chkboxUtilizarPeriodoUsuario.AutoSize = True
        Me.chkboxUtilizarPeriodoUsuario.Location = New System.Drawing.Point(9, 0)
        Me.chkboxUtilizarPeriodoUsuario.Name = "chkboxUtilizarPeriodoUsuario"
        Me.chkboxUtilizarPeriodoUsuario.Size = New System.Drawing.Size(122, 17)
        Me.chkboxUtilizarPeriodoUsuario.TabIndex = 0
        Me.chkboxUtilizarPeriodoUsuario.Text = "Utilizar Este Período"
        Me.chkboxUtilizarPeriodoUsuario.UseVisualStyleBackColor = True
        '
        'CTRepEstFinancierosFrm
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(260, 394)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblPeriodo)
        Me.Controls.Add(Me.c1dateFecha)
        Me.Controls.Add(Me.c1numFactorCambio)
        Me.Controls.Add(Me.c1numCompararAnio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.chkboxFechasIniFin)
        Me.Controls.Add(Me.chkboxMostrarTituloMoneda)
        Me.Controls.Add(Me.chkboxSuprimirSaldosCeros)
        Me.Controls.Add(Me.chkboxCompAñoAnt)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CTRepEstFinancierosFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado Financieros"
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numFactorCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numCompararAnio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numupdnNivelCta3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numupdnNivelCta2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numupdnNivelCta1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.c1numAñoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents c1dateFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents c1numFactorCambio As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numCompararAnio As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents chkboxFechasIniFin As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxMostrarTituloMoneda As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxSuprimirSaldosCeros As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxCompAñoAnt As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radiobutMensuales As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutSaldosAnuales As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents numupdnNivelCta3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents numupdnNivelCta2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents numupdnNivelCta1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblNivelCta3 As System.Windows.Forms.Label
    Friend WithEvents lblNivelCta2 As System.Windows.Forms.Label
    Friend WithEvents lblNivelCta1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents c1numAñoUsuario As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkboxUtilizarPeriodoUsuario As System.Windows.Forms.CheckBox
    Friend WithEvents cmbMeses As System.Windows.Forms.ComboBox
End Class
