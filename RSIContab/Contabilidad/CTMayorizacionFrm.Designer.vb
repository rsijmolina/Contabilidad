<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTMayorizacionFrm
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radiobutRangoTiempo = New System.Windows.Forms.RadioButton()
        Me.radiobutAñoMesActual = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.numupdnMesFin = New System.Windows.Forms.NumericUpDown()
        Me.numupdnAñoFin = New System.Windows.Forms.NumericUpDown()
        Me.numupdnMesIni = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numupdnAñoIni = New System.Windows.Forms.NumericUpDown()
        Me.chkboxIniTablaSaldos = New System.Windows.Forms.CheckBox()
        Me.chkboxActMesProceso = New System.Windows.Forms.CheckBox()
        Me.butAceptar = New System.Windows.Forms.Button()
        Me.butCancelar = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTMayorizacionDataSet = New RSIContab.CTMayorizacionDataSet()
        Me.CTSaldosMensualesTableAdapter = New RSIContab.CTMayorizacionDataSetTableAdapters.CTSaldosMensualesTableAdapter()
        Me.SaldosMensualesClonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTSaldosMensualesClonTableAdapter = New RSIContab.CTMayorizacionDataSetTableAdapters.CTSaldosMensualesClonTableAdapter()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numupdnMesFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numupdnAñoFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numupdnMesIni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numupdnAñoIni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTMayorizacionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaldosMensualesClonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RSIContab.My.Resources.Resources.mayori
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 324)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(126, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Tag = ""
        Me.Label1.Text = "Este proceso actualizará los saldos de las cuentas en el libro mayor. Puede escog" & _
    "er cualquiera de las siguientes opciones para ejecutarlo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radiobutRangoTiempo)
        Me.GroupBox1.Controls.Add(Me.radiobutAñoMesActual)
        Me.GroupBox1.Location = New System.Drawing.Point(129, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 75)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mayorizar"
        '
        'radiobutRangoTiempo
        '
        Me.radiobutRangoTiempo.AutoSize = True
        Me.radiobutRangoTiempo.Location = New System.Drawing.Point(7, 44)
        Me.radiobutRangoTiempo.Name = "radiobutRangoTiempo"
        Me.radiobutRangoTiempo.Size = New System.Drawing.Size(129, 17)
        Me.radiobutRangoTiempo.TabIndex = 1
        Me.radiobutRangoTiempo.Text = "Por Rango de Tiempo"
        Me.radiobutRangoTiempo.UseVisualStyleBackColor = True
        '
        'radiobutAñoMesActual
        '
        Me.radiobutAñoMesActual.AutoSize = True
        Me.radiobutAñoMesActual.Checked = True
        Me.radiobutAñoMesActual.Location = New System.Drawing.Point(7, 20)
        Me.radiobutAñoMesActual.Name = "radiobutAñoMesActual"
        Me.radiobutAñoMesActual.Size = New System.Drawing.Size(165, 17)
        Me.radiobutAñoMesActual.TabIndex = 0
        Me.radiobutAñoMesActual.TabStop = True
        Me.radiobutAñoMesActual.Text = "Año y Mes en Proceso Actual"
        Me.radiobutAñoMesActual.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.numupdnMesFin)
        Me.GroupBox2.Controls.Add(Me.numupdnAñoFin)
        Me.GroupBox2.Controls.Add(Me.numupdnMesIni)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.numupdnAñoIni)
        Me.GroupBox2.Location = New System.Drawing.Point(129, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 79)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rango de Tiempo"
        '
        'numupdnMesFin
        '
        Me.numupdnMesFin.Location = New System.Drawing.Point(213, 45)
        Me.numupdnMesFin.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.numupdnMesFin.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numupdnMesFin.Name = "numupdnMesFin"
        Me.numupdnMesFin.Size = New System.Drawing.Size(31, 20)
        Me.numupdnMesFin.TabIndex = 7
        Me.numupdnMesFin.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numupdnAñoFin
        '
        Me.numupdnAñoFin.Location = New System.Drawing.Point(192, 19)
        Me.numupdnAñoFin.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numupdnAñoFin.Name = "numupdnAñoFin"
        Me.numupdnAñoFin.Size = New System.Drawing.Size(52, 20)
        Me.numupdnAñoFin.TabIndex = 6
        '
        'numupdnMesIni
        '
        Me.numupdnMesIni.Location = New System.Drawing.Point(88, 45)
        Me.numupdnMesIni.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.numupdnMesIni.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numupdnMesIni.Name = "numupdnMesIni"
        Me.numupdnMesIni.Size = New System.Drawing.Size(36, 20)
        Me.numupdnMesIni.TabIndex = 5
        Me.numupdnMesIni.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(139, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mes Final:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mes Inicial:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Año Final:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Año Inicial:"
        '
        'numupdnAñoIni
        '
        Me.numupdnAñoIni.Location = New System.Drawing.Point(72, 19)
        Me.numupdnAñoIni.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numupdnAñoIni.Name = "numupdnAñoIni"
        Me.numupdnAñoIni.Size = New System.Drawing.Size(52, 20)
        Me.numupdnAñoIni.TabIndex = 0
        '
        'chkboxIniTablaSaldos
        '
        Me.chkboxIniTablaSaldos.AutoSize = True
        Me.chkboxIniTablaSaldos.Location = New System.Drawing.Point(129, 222)
        Me.chkboxIniTablaSaldos.Name = "chkboxIniTablaSaldos"
        Me.chkboxIniTablaSaldos.Size = New System.Drawing.Size(149, 17)
        Me.chkboxIniTablaSaldos.TabIndex = 4
        Me.chkboxIniTablaSaldos.Text = "Inicializar Tabla de Saldos"
        Me.chkboxIniTablaSaldos.UseVisualStyleBackColor = True
        '
        'chkboxActMesProceso
        '
        Me.chkboxActMesProceso.AutoSize = True
        Me.chkboxActMesProceso.Location = New System.Drawing.Point(129, 246)
        Me.chkboxActMesProceso.Name = "chkboxActMesProceso"
        Me.chkboxActMesProceso.Size = New System.Drawing.Size(152, 17)
        Me.chkboxActMesProceso.TabIndex = 5
        Me.chkboxActMesProceso.Text = "Actualizar Mes en Proceso"
        Me.chkboxActMesProceso.UseVisualStyleBackColor = True
        '
        'butAceptar
        '
        Me.butAceptar.Location = New System.Drawing.Point(139, 293)
        Me.butAceptar.Name = "butAceptar"
        Me.butAceptar.Size = New System.Drawing.Size(100, 34)
        Me.butAceptar.TabIndex = 6
        Me.butAceptar.Text = "&Aceptar"
        Me.butAceptar.UseVisualStyleBackColor = True
        '
        'butCancelar
        '
        Me.butCancelar.Location = New System.Drawing.Point(281, 293)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(100, 31)
        Me.butCancelar.TabIndex = 7
        Me.butCancelar.Text = "&Cancelar"
        Me.butCancelar.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(129, 270)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(262, 20)
        Me.lblMensaje.TabIndex = 8
        Me.lblMensaje.Text = "."
        Me.lblMensaje.Visible = False
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "CTSaldosMensuales"
        Me.PrincipalBindingSource.DataSource = Me.CTMayorizacionDataSet
        '
        'CTMayorizacionDataSet
        '
        Me.CTMayorizacionDataSet.DataSetName = "CTMayorizacionDataSet"
        Me.CTMayorizacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CTSaldosMensualesTableAdapter
        '
        Me.CTSaldosMensualesTableAdapter.ClearBeforeFill = True
        '
        'SaldosMensualesClonBindingSource
        '
        Me.SaldosMensualesClonBindingSource.DataMember = "CTSaldosMensualesClon"
        Me.SaldosMensualesClonBindingSource.DataSource = Me.CTMayorizacionDataSet
        '
        'CTSaldosMensualesClonTableAdapter
        '
        Me.CTSaldosMensualesClonTableAdapter.ClearBeforeFill = True
        '
        'CTMayorizacionFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 334)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.butCancelar)
        Me.Controls.Add(Me.butAceptar)
        Me.Controls.Add(Me.chkboxActMesProceso)
        Me.Controls.Add(Me.chkboxIniTablaSaldos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CTMayorizacionFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proceso de Mayorización"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numupdnMesFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numupdnAñoFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numupdnMesIni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numupdnAñoIni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTMayorizacionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaldosMensualesClonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radiobutRangoTiempo As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutAñoMesActual As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents numupdnMesFin As System.Windows.Forms.NumericUpDown
    Friend WithEvents numupdnAñoFin As System.Windows.Forms.NumericUpDown
    Friend WithEvents numupdnMesIni As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents numupdnAñoIni As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkboxIniTablaSaldos As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxActMesProceso As System.Windows.Forms.CheckBox
    Friend WithEvents butAceptar As System.Windows.Forms.Button
    Friend WithEvents butCancelar As System.Windows.Forms.Button
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTMayorizacionDataSet As RSIContab.CTMayorizacionDataSet
    Friend WithEvents CTSaldosMensualesTableAdapter As RSIContab.CTMayorizacionDataSetTableAdapters.CTSaldosMensualesTableAdapter
    Friend WithEvents SaldosMensualesClonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTSaldosMensualesClonTableAdapter As RSIContab.CTMayorizacionDataSetTableAdapters.CTSaldosMensualesClonTableAdapter
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
