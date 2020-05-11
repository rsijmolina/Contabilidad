<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTRepMovCuentasFrm
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
        Me.c1dateFecha = New C1.Win.C1Input.C1DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.butBuscarCtaIni = New System.Windows.Forms.Button()
        Me.lblNombreCtaFin = New System.Windows.Forms.Label()
        Me.lblNombreCtaIni = New System.Windows.Forms.Label()
        Me.txtCuentaFin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCuentaIni = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbMesFin = New System.Windows.Forms.ComboBox()
        Me.cmbMesIni = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.c1numAñoFin = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numAñoIni = New C1.Win.C1Input.C1NumericEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkboxImpBeneficiario = New System.Windows.Forms.CheckBox()
        Me.chkboxImpConcepto = New System.Windows.Forms.CheckBox()
        Me.chkboxImpCtasSaldoCero = New System.Windows.Forms.CheckBox()
        Me.butCancelar = New System.Windows.Forms.Button()
        Me.butAceptar = New System.Windows.Forms.Button()
        Me.CTSaldosIniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTSaldosIniDataSet = New RSIContab.CTSaldosIniDataSet()
        Me.CTSaldosIniTableAdapter = New RSIContab.CTSaldosIniDataSetTableAdapters.CTSaldosIniTableAdapter()
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.c1numAñoFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numAñoIni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.CTSaldosIniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTSaldosIniDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.c1dateFecha.Location = New System.Drawing.Point(185, 12)
        Me.c1dateFecha.Name = "c1dateFecha"
        Me.c1dateFecha.Size = New System.Drawing.Size(105, 20)
        Me.c1dateFecha.TabIndex = 21
        Me.c1dateFecha.Tag = Nothing
        Me.c1dateFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(141, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Fecha:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.butBuscarCtaIni)
        Me.GroupBox1.Controls.Add(Me.lblNombreCtaFin)
        Me.GroupBox1.Controls.Add(Me.lblNombreCtaIni)
        Me.GroupBox1.Controls.Add(Me.txtCuentaFin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCuentaIni)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 80)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuentas"
        '
        'Button1
        '
        Me.Button1.Image = Global.RSIContab.My.Resources.Resources._1425432924_Magnifier2
        Me.Button1.Location = New System.Drawing.Point(160, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = True
        '
        'butBuscarCtaIni
        '
        Me.butBuscarCtaIni.Image = Global.RSIContab.My.Resources.Resources._1425432924_Magnifier2
        Me.butBuscarCtaIni.Location = New System.Drawing.Point(160, 17)
        Me.butBuscarCtaIni.Name = "butBuscarCtaIni"
        Me.butBuscarCtaIni.Size = New System.Drawing.Size(22, 23)
        Me.butBuscarCtaIni.TabIndex = 6
        Me.butBuscarCtaIni.UseVisualStyleBackColor = True
        '
        'lblNombreCtaFin
        '
        Me.lblNombreCtaFin.BackColor = System.Drawing.Color.White
        Me.lblNombreCtaFin.Location = New System.Drawing.Point(188, 48)
        Me.lblNombreCtaFin.Name = "lblNombreCtaFin"
        Me.lblNombreCtaFin.Size = New System.Drawing.Size(281, 20)
        Me.lblNombreCtaFin.TabIndex = 5
        '
        'lblNombreCtaIni
        '
        Me.lblNombreCtaIni.BackColor = System.Drawing.Color.White
        Me.lblNombreCtaIni.Location = New System.Drawing.Point(191, 20)
        Me.lblNombreCtaIni.Name = "lblNombreCtaIni"
        Me.lblNombreCtaIni.Size = New System.Drawing.Size(278, 20)
        Me.lblNombreCtaIni.TabIndex = 4
        '
        'txtCuentaFin
        '
        Me.txtCuentaFin.Location = New System.Drawing.Point(45, 48)
        Me.txtCuentaFin.Name = "txtCuentaFin"
        Me.txtCuentaFin.Size = New System.Drawing.Size(115, 20)
        Me.txtCuentaFin.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Final:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Inicial:"
        '
        'txtCuentaIni
        '
        Me.txtCuentaIni.Location = New System.Drawing.Point(45, 20)
        Me.txtCuentaIni.Name = "txtCuentaIni"
        Me.txtCuentaIni.Size = New System.Drawing.Size(115, 20)
        Me.txtCuentaIni.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbMesFin)
        Me.GroupBox2.Controls.Add(Me.cmbMesIni)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.c1numAñoFin)
        Me.GroupBox2.Controls.Add(Me.c1numAñoIni)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(475, 76)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tiempo"
        '
        'cmbMesFin
        '
        Me.cmbMesFin.FormattingEnabled = True
        Me.cmbMesFin.Location = New System.Drawing.Point(211, 47)
        Me.cmbMesFin.Name = "cmbMesFin"
        Me.cmbMesFin.Size = New System.Drawing.Size(125, 21)
        Me.cmbMesFin.TabIndex = 15
        '
        'cmbMesIni
        '
        Me.cmbMesIni.FormattingEnabled = True
        Me.cmbMesIni.Location = New System.Drawing.Point(211, 20)
        Me.cmbMesIni.Name = "cmbMesIni"
        Me.cmbMesIni.Size = New System.Drawing.Size(125, 21)
        Me.cmbMesIni.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(144, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Mes Final:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(144, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Mes Inicial:"
        '
        'c1numAñoFin
        '
        Me.c1numAñoFin.DataType = GetType(Short)
        Me.c1numAñoFin.Location = New System.Drawing.Point(72, 46)
        Me.c1numAñoFin.Name = "c1numAñoFin"
        Me.c1numAñoFin.Size = New System.Drawing.Size(56, 20)
        Me.c1numAñoFin.TabIndex = 11
        Me.c1numAñoFin.Tag = Nothing
        Me.c1numAñoFin.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown
        '
        'c1numAñoIni
        '
        Me.c1numAñoIni.DataType = GetType(Short)
        Me.c1numAñoIni.Location = New System.Drawing.Point(72, 20)
        Me.c1numAñoIni.Name = "c1numAñoIni"
        Me.c1numAñoIni.Size = New System.Drawing.Size(56, 20)
        Me.c1numAñoIni.TabIndex = 10
        Me.c1numAñoIni.Tag = Nothing
        Me.c1numAñoIni.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Año Final:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Año Inicial:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkboxImpBeneficiario)
        Me.GroupBox3.Controls.Add(Me.chkboxImpConcepto)
        Me.GroupBox3.Controls.Add(Me.chkboxImpCtasSaldoCero)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 206)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(475, 75)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        '
        'chkboxImpBeneficiario
        '
        Me.chkboxImpBeneficiario.AutoSize = True
        Me.chkboxImpBeneficiario.Location = New System.Drawing.Point(6, 42)
        Me.chkboxImpBeneficiario.Name = "chkboxImpBeneficiario"
        Me.chkboxImpBeneficiario.Size = New System.Drawing.Size(219, 17)
        Me.chkboxImpBeneficiario.TabIndex = 2
        Me.chkboxImpBeneficiario.Text = "Imprimir Beneficiario Cuando sea Cheque"
        Me.chkboxImpBeneficiario.UseVisualStyleBackColor = True
        '
        'chkboxImpConcepto
        '
        Me.chkboxImpConcepto.AutoSize = True
        Me.chkboxImpConcepto.Location = New System.Drawing.Point(6, 19)
        Me.chkboxImpConcepto.Name = "chkboxImpConcepto"
        Me.chkboxImpConcepto.Size = New System.Drawing.Size(270, 17)
        Me.chkboxImpConcepto.TabIndex = 1
        Me.chkboxImpConcepto.Text = "Imprimir Concepto de la Partida en Lugar del Detalle"
        Me.chkboxImpConcepto.UseVisualStyleBackColor = True
        '
        'chkboxImpCtasSaldoCero
        '
        Me.chkboxImpCtasSaldoCero.AutoSize = True
        Me.chkboxImpCtasSaldoCero.Location = New System.Drawing.Point(296, 19)
        Me.chkboxImpCtasSaldoCero.Name = "chkboxImpCtasSaldoCero"
        Me.chkboxImpCtasSaldoCero.Size = New System.Drawing.Size(179, 17)
        Me.chkboxImpCtasSaldoCero.TabIndex = 0
        Me.chkboxImpCtasSaldoCero.Text = "Imprimir Cuentas con Saldo Cero"
        Me.chkboxImpCtasSaldoCero.UseVisualStyleBackColor = True
        Me.chkboxImpCtasSaldoCero.Visible = False
        '
        'butCancelar
        '
        Me.butCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butCancelar.Image = Global.RSIContab.My.Resources.Resources._1393662113_cancel
        Me.butCancelar.Location = New System.Drawing.Point(366, 291)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(107, 33)
        Me.butCancelar.TabIndex = 59
        Me.butCancelar.Text = "&Cancelar"
        Me.butCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butCancelar.UseVisualStyleBackColor = True
        '
        'butAceptar
        '
        Me.butAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.butAceptar.Image = Global.RSIContab.My.Resources.Resources._1393538844_tick_16
        Me.butAceptar.Location = New System.Drawing.Point(30, 291)
        Me.butAceptar.Name = "butAceptar"
        Me.butAceptar.Size = New System.Drawing.Size(107, 33)
        Me.butAceptar.TabIndex = 58
        Me.butAceptar.Text = "&Aceptar"
        Me.butAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butAceptar.UseVisualStyleBackColor = True
        '
        'CTSaldosIniBindingSource
        '
        Me.CTSaldosIniBindingSource.DataMember = "CTSaldosIni"
        Me.CTSaldosIniBindingSource.DataSource = Me.CTSaldosIniDataSet
        '
        'CTSaldosIniDataSet
        '
        Me.CTSaldosIniDataSet.DataSetName = "CTSaldosIniDataSet"
        Me.CTSaldosIniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CTSaldosIniTableAdapter
        '
        Me.CTSaldosIniTableAdapter.ClearBeforeFill = True
        '
        'CTRepMovCuentasFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 336)
        Me.Controls.Add(Me.butCancelar)
        Me.Controls.Add(Me.butAceptar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.c1dateFecha)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CTRepMovCuentasFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reporte de Movimiento de Cuentas"
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.c1numAñoFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numAñoIni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.CTSaldosIniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTSaldosIniDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents c1dateFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNombreCtaFin As System.Windows.Forms.Label
    Friend WithEvents lblNombreCtaIni As System.Windows.Forms.Label
    Friend WithEvents txtCuentaFin As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaIni As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents c1numAñoFin As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numAñoIni As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents cmbMesFin As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMesIni As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkboxImpBeneficiario As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxImpConcepto As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxImpCtasSaldoCero As System.Windows.Forms.CheckBox
    Friend WithEvents butCancelar As System.Windows.Forms.Button
    Friend WithEvents butAceptar As System.Windows.Forms.Button
    Friend WithEvents butBuscarCtaIni As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CTSaldosIniBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTSaldosIniDataSet As RSIContab.CTSaldosIniDataSet
    Friend WithEvents CTSaldosIniTableAdapter As RSIContab.CTSaldosIniDataSetTableAdapters.CTSaldosIniTableAdapter
End Class
