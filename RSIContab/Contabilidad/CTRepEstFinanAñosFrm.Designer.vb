<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTRepEstFinanAñosFrm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.numupdnNivelCta3 = New System.Windows.Forms.NumericUpDown()
        Me.numupdnNivelCta2 = New System.Windows.Forms.NumericUpDown()
        Me.numupdnNivelCta1 = New System.Windows.Forms.NumericUpDown()
        Me.lblNivelCta3 = New System.Windows.Forms.Label()
        Me.lblNivelCta2 = New System.Windows.Forms.Label()
        Me.lblNivelCta1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButComparativoDosAños = New System.Windows.Forms.RadioButton()
        Me.RadioButTodosMesesAño = New System.Windows.Forms.RadioButton()
        Me.RadioButRangoAños = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.c1numAñoFin = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numAñoIni = New C1.Win.C1Input.C1NumericEdit()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.c1numMesesAño = New C1.Win.C1Input.C1NumericEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkboxSuprimirSaldosCero = New System.Windows.Forms.CheckBox()
        Me.grpboxSaldosListar = New System.Windows.Forms.GroupBox()
        Me.radiobutMensuales = New System.Windows.Forms.RadioButton()
        Me.radiobutSaldosAnuales = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numupdnNivelCta3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numupdnNivelCta2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numupdnNivelCta1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.c1numAñoFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numAñoIni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.c1numMesesAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpboxSaldosListar.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.numupdnNivelCta3)
        Me.GroupBox1.Controls.Add(Me.numupdnNivelCta2)
        Me.GroupBox1.Controls.Add(Me.numupdnNivelCta1)
        Me.GroupBox1.Controls.Add(Me.lblNivelCta3)
        Me.GroupBox1.Controls.Add(Me.lblNivelCta2)
        Me.GroupBox1.Controls.Add(Me.lblNivelCta1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 99)
        Me.GroupBox1.TabIndex = 21
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
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(238, 239)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(89, 33)
        Me.btnCancelar.TabIndex = 23
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(26, 239)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(89, 33)
        Me.btnAceptar.TabIndex = 22
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButComparativoDosAños)
        Me.GroupBox2.Controls.Add(Me.RadioButTodosMesesAño)
        Me.GroupBox2.Controls.Add(Me.RadioButRangoAños)
        Me.GroupBox2.Location = New System.Drawing.Point(151, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 100)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo"
        '
        'RadioButComparativoDosAños
        '
        Me.RadioButComparativoDosAños.AutoSize = True
        Me.RadioButComparativoDosAños.Location = New System.Drawing.Point(6, 65)
        Me.RadioButComparativoDosAños.Name = "RadioButComparativoDosAños"
        Me.RadioButComparativoDosAños.Size = New System.Drawing.Size(176, 17)
        Me.RadioButComparativoDosAños.TabIndex = 2
        Me.RadioButComparativoDosAños.Text = "Comparativo por Mes de 2 Años"
        Me.RadioButComparativoDosAños.UseVisualStyleBackColor = True
        '
        'RadioButTodosMesesAño
        '
        Me.RadioButTodosMesesAño.AutoSize = True
        Me.RadioButTodosMesesAño.Location = New System.Drawing.Point(6, 42)
        Me.RadioButTodosMesesAño.Name = "RadioButTodosMesesAño"
        Me.RadioButTodosMesesAño.Size = New System.Drawing.Size(144, 17)
        Me.RadioButTodosMesesAño.TabIndex = 1
        Me.RadioButTodosMesesAño.Text = "Todos los Meses del Año"
        Me.RadioButTodosMesesAño.UseVisualStyleBackColor = True
        '
        'RadioButRangoAños
        '
        Me.RadioButRangoAños.AutoSize = True
        Me.RadioButRangoAños.Checked = True
        Me.RadioButRangoAños.Location = New System.Drawing.Point(6, 19)
        Me.RadioButRangoAños.Name = "RadioButRangoAños"
        Me.RadioButRangoAños.Size = New System.Drawing.Size(118, 17)
        Me.RadioButRangoAños.TabIndex = 0
        Me.RadioButRangoAños.TabStop = True
        Me.RadioButRangoAños.Text = "Por Rango de Años"
        Me.RadioButRangoAños.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblHasta)
        Me.GroupBox3.Controls.Add(Me.lblDesde)
        Me.GroupBox3.Controls.Add(Me.c1numAñoFin)
        Me.GroupBox3.Controls.Add(Me.c1numAñoIni)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 119)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(127, 63)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rango de Años"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(65, 16)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(38, 13)
        Me.lblHasta.TabIndex = 28
        Me.lblHasta.Text = "Hasta:"
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(9, 16)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(41, 13)
        Me.lblDesde.TabIndex = 27
        Me.lblDesde.Text = "Desde:"
        '
        'c1numAñoFin
        '
        Me.c1numAñoFin.DataType = GetType(Short)
        Me.c1numAñoFin.Location = New System.Drawing.Point(66, 30)
        Me.c1numAñoFin.Name = "c1numAñoFin"
        Me.c1numAñoFin.Size = New System.Drawing.Size(50, 20)
        Me.c1numAñoFin.TabIndex = 26
        Me.c1numAñoFin.Tag = Nothing
        Me.c1numAñoFin.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numAñoIni
        '
        Me.c1numAñoIni.DataType = GetType(Short)
        Me.c1numAñoIni.Location = New System.Drawing.Point(9, 30)
        Me.c1numAñoIni.Name = "c1numAñoIni"
        Me.c1numAñoIni.Size = New System.Drawing.Size(50, 20)
        Me.c1numAñoIni.TabIndex = 25
        Me.c1numAñoIni.Tag = Nothing
        Me.c1numAñoIni.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.c1numMesesAño)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(151, 119)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(192, 63)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Todos los Meses"
        '
        'c1numMesesAño
        '
        Me.c1numMesesAño.DataType = GetType(Short)
        Me.c1numMesesAño.Location = New System.Drawing.Point(60, 23)
        Me.c1numMesesAño.Name = "c1numMesesAño"
        Me.c1numMesesAño.Size = New System.Drawing.Size(50, 20)
        Me.c1numMesesAño.TabIndex = 30
        Me.c1numMesesAño.Tag = Nothing
        Me.c1numMesesAño.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Del Año:"
        '
        'chkboxSuprimirSaldosCero
        '
        Me.chkboxSuprimirSaldosCero.AutoSize = True
        Me.chkboxSuprimirSaldosCero.Location = New System.Drawing.Point(12, 189)
        Me.chkboxSuprimirSaldosCero.Name = "chkboxSuprimirSaldosCero"
        Me.chkboxSuprimirSaldosCero.Size = New System.Drawing.Size(138, 17)
        Me.chkboxSuprimirSaldosCero.TabIndex = 27
        Me.chkboxSuprimirSaldosCero.Text = "Suprimir Saldos en Cero"
        Me.chkboxSuprimirSaldosCero.UseVisualStyleBackColor = True
        '
        'grpboxSaldosListar
        '
        Me.grpboxSaldosListar.Controls.Add(Me.radiobutMensuales)
        Me.grpboxSaldosListar.Controls.Add(Me.radiobutSaldosAnuales)
        Me.grpboxSaldosListar.Location = New System.Drawing.Point(151, 189)
        Me.grpboxSaldosListar.Name = "grpboxSaldosListar"
        Me.grpboxSaldosListar.Size = New System.Drawing.Size(192, 41)
        Me.grpboxSaldosListar.TabIndex = 28
        Me.grpboxSaldosListar.TabStop = False
        Me.grpboxSaldosListar.Text = "Saldos a Listar"
        '
        'radiobutMensuales
        '
        Me.radiobutMensuales.AutoSize = True
        Me.radiobutMensuales.Location = New System.Drawing.Point(87, 19)
        Me.radiobutMensuales.Name = "radiobutMensuales"
        Me.radiobutMensuales.Size = New System.Drawing.Size(76, 17)
        Me.radiobutMensuales.TabIndex = 11
        Me.radiobutMensuales.Text = "Mensuales"
        Me.radiobutMensuales.UseVisualStyleBackColor = True
        '
        'radiobutSaldosAnuales
        '
        Me.radiobutSaldosAnuales.AutoSize = True
        Me.radiobutSaldosAnuales.Checked = True
        Me.radiobutSaldosAnuales.Location = New System.Drawing.Point(9, 19)
        Me.radiobutSaldosAnuales.Name = "radiobutSaldosAnuales"
        Me.radiobutSaldosAnuales.Size = New System.Drawing.Size(63, 17)
        Me.radiobutSaldosAnuales.TabIndex = 10
        Me.radiobutSaldosAnuales.TabStop = True
        Me.radiobutSaldosAnuales.Text = "Anuales"
        Me.radiobutSaldosAnuales.UseVisualStyleBackColor = True
        '
        'CTRepEstFinanAñosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 280)
        Me.Controls.Add(Me.grpboxSaldosListar)
        Me.Controls.Add(Me.chkboxSuprimirSaldosCero)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CTRepEstFinanAñosFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estados Financieros por Años (Exportardo a Excel)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numupdnNivelCta3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numupdnNivelCta2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numupdnNivelCta1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.c1numAñoFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numAñoIni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.c1numMesesAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpboxSaldosListar.ResumeLayout(False)
        Me.grpboxSaldosListar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents numupdnNivelCta3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents numupdnNivelCta2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents numupdnNivelCta1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblNivelCta3 As System.Windows.Forms.Label
    Friend WithEvents lblNivelCta2 As System.Windows.Forms.Label
    Friend WithEvents lblNivelCta1 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButComparativoDosAños As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButTodosMesesAño As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButRangoAños As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents c1numAñoFin As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numAñoIni As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents c1numMesesAño As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkboxSuprimirSaldosCero As System.Windows.Forms.CheckBox
    Friend WithEvents grpboxSaldosListar As System.Windows.Forms.GroupBox
    Friend WithEvents radiobutMensuales As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutSaldosAnuales As System.Windows.Forms.RadioButton
End Class
