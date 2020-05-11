<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTBalGenFrm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numupdnActivo = New System.Windows.Forms.NumericUpDown()
        Me.numupdnPasivo = New System.Windows.Forms.NumericUpDown()
        Me.numupdnCapital = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radiobutSaldosAnuales = New System.Windows.Forms.RadioButton()
        Me.radiobutMensuales = New System.Windows.Forms.RadioButton()
        Me.chkboxCompAñoAnt = New System.Windows.Forms.CheckBox()
        Me.chkboxSuprimirSaldosCeros = New System.Windows.Forms.CheckBox()
        Me.chkboxMostrarTituloMoneda = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.c1numCompararAnio = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numFactorCambio = New C1.Win.C1Input.C1NumericEdit()
        Me.c1dateFecha = New C1.Win.C1Input.C1DateEdit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numupdnActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numupdnPasivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numupdnCapital, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.c1numCompararAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numFactorCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.numupdnCapital)
        Me.GroupBox1.Controls.Add(Me.numupdnPasivo)
        Me.GroupBox1.Controls.Add(Me.numupdnActivo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(116, 99)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Niveles a Listar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Activo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pasivo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Capital:"
        '
        'numupdnActivo
        '
        Me.numupdnActivo.Location = New System.Drawing.Point(53, 19)
        Me.numupdnActivo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numupdnActivo.Name = "numupdnActivo"
        Me.numupdnActivo.Size = New System.Drawing.Size(35, 20)
        Me.numupdnActivo.TabIndex = 4
        Me.numupdnActivo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numupdnPasivo
        '
        Me.numupdnPasivo.Location = New System.Drawing.Point(54, 45)
        Me.numupdnPasivo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numupdnPasivo.Name = "numupdnPasivo"
        Me.numupdnPasivo.Size = New System.Drawing.Size(35, 20)
        Me.numupdnPasivo.TabIndex = 5
        Me.numupdnPasivo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numupdnCapital
        '
        Me.numupdnCapital.Location = New System.Drawing.Point(53, 71)
        Me.numupdnCapital.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numupdnCapital.Name = "numupdnCapital"
        Me.numupdnCapital.Size = New System.Drawing.Size(35, 20)
        Me.numupdnCapital.TabIndex = 6
        Me.numupdnCapital.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radiobutMensuales)
        Me.GroupBox2.Controls.Add(Me.radiobutSaldosAnuales)
        Me.GroupBox2.Location = New System.Drawing.Point(134, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(116, 99)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Saldos a Listar"
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
        'chkboxCompAñoAnt
        '
        Me.chkboxCompAñoAnt.AutoSize = True
        Me.chkboxCompAñoAnt.Location = New System.Drawing.Point(12, 151)
        Me.chkboxCompAñoAnt.Name = "chkboxCompAñoAnt"
        Me.chkboxCompAñoAnt.Size = New System.Drawing.Size(156, 17)
        Me.chkboxCompAñoAnt.TabIndex = 10
        Me.chkboxCompAñoAnt.Text = "Comparar con Año Anterior:"
        Me.chkboxCompAñoAnt.UseVisualStyleBackColor = True
        '
        'chkboxSuprimirSaldosCeros
        '
        Me.chkboxSuprimirSaldosCeros.AutoSize = True
        Me.chkboxSuprimirSaldosCeros.Location = New System.Drawing.Point(12, 174)
        Me.chkboxSuprimirSaldosCeros.Name = "chkboxSuprimirSaldosCeros"
        Me.chkboxSuprimirSaldosCeros.Size = New System.Drawing.Size(138, 17)
        Me.chkboxSuprimirSaldosCeros.TabIndex = 12
        Me.chkboxSuprimirSaldosCeros.Text = "Suprimir Saldos en Cero"
        Me.chkboxSuprimirSaldosCeros.UseVisualStyleBackColor = True
        '
        'chkboxMostrarTituloMoneda
        '
        Me.chkboxMostrarTituloMoneda.AutoSize = True
        Me.chkboxMostrarTituloMoneda.Location = New System.Drawing.Point(12, 197)
        Me.chkboxMostrarTituloMoneda.Name = "chkboxMostrarTituloMoneda"
        Me.chkboxMostrarTituloMoneda.Size = New System.Drawing.Size(149, 17)
        Me.chkboxMostrarTituloMoneda.TabIndex = 13
        Me.chkboxMostrarTituloMoneda.Text = "Mostrar Título de Moneda"
        Me.chkboxMostrarTituloMoneda.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 243)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(241, 17)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Mostrar Fechas Iniciales y Finales en el Título"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(12, 272)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(89, 33)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(161, 272)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(89, 33)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Factor de Cambio:"
        '
        'c1numCompararAnio
        '
        Me.c1numCompararAnio.DataType = GetType(Short)
        Me.c1numCompararAnio.Location = New System.Drawing.Point(173, 147)
        Me.c1numCompararAnio.Name = "c1numCompararAnio"
        Me.c1numCompararAnio.Size = New System.Drawing.Size(50, 20)
        Me.c1numCompararAnio.TabIndex = 11
        Me.c1numCompararAnio.Tag = Nothing
        Me.c1numCompararAnio.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numFactorCambio
        '
        Me.c1numFactorCambio.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numFactorCambio.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numFactorCambio.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numFactorCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numFactorCambio.Location = New System.Drawing.Point(131, 217)
        Me.c1numFactorCambio.Name = "c1numFactorCambio"
        Me.c1numFactorCambio.Size = New System.Drawing.Size(79, 20)
        Me.c1numFactorCambio.TabIndex = 14
        Me.c1numFactorCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numFactorCambio.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1numFactorCambio.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
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
        Me.c1dateFecha.Location = New System.Drawing.Point(105, 12)
        Me.c1dateFecha.Name = "c1dateFecha"
        Me.c1dateFecha.Size = New System.Drawing.Size(105, 20)
        Me.c1dateFecha.TabIndex = 2
        Me.c1dateFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'CTBalGenFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 313)
        Me.Controls.Add(Me.c1dateFecha)
        Me.Controls.Add(Me.c1numFactorCambio)
        Me.Controls.Add(Me.c1numCompararAnio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.chkboxMostrarTituloMoneda)
        Me.Controls.Add(Me.chkboxSuprimirSaldosCeros)
        Me.Controls.Add(Me.chkboxCompAñoAnt)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CTBalGenFrm"
        Me.Text = "Balance General"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numupdnActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numupdnPasivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numupdnCapital, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.c1numCompararAnio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numFactorCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents numupdnCapital As System.Windows.Forms.NumericUpDown
    Friend WithEvents numupdnPasivo As System.Windows.Forms.NumericUpDown
    Friend WithEvents numupdnActivo As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radiobutMensuales As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutSaldosAnuales As System.Windows.Forms.RadioButton
    Friend WithEvents chkboxCompAñoAnt As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxSuprimirSaldosCeros As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxMostrarTituloMoneda As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents c1numCompararAnio As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numFactorCambio As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1dateFecha As C1.Win.C1Input.C1DateEdit
End Class
