<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLGenerarBancosFrm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.c1dateFecha = New C1.Win.C1Input.C1DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblDescPlanilla = New System.Windows.Forms.Label()
        Me.c1numNoPlanilla = New C1.Win.C1Input.C1NumericEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radiobutAtlantida = New System.Windows.Forms.RadioButton()
        Me.radiobutHSBC = New System.Windows.Forms.RadioButton()
        Me.radiobutFicohsa = New System.Windows.Forms.RadioButton()
        Me.PLGenerarBancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLPlanillaBancosDataSet = New RSIContab.PLPlanillaBancosDataSet()
        Me.PLPlanillasTableAdapter = New RSIContab.PLPlanillaBancosDataSetTableAdapters.PLPlanillasTableAdapter()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.c1txtCtaDeb3 = New C1.Win.C1Input.C1TextBox()
        Me.c1txtCtaDeb2 = New C1.Win.C1Input.C1TextBox()
        Me.c1txtCtaDeb1 = New C1.Win.C1Input.C1TextBox()
        Me.c1txtCorrelativoFicohsa = New C1.Win.C1Input.C1TextBox()
        Me.c1txtCodigoInstitucion = New C1.Win.C1Input.C1TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.c1txtCodigoEmpresaBA = New C1.Win.C1Input.C1TextBox()
        Me.dlgGuardarArchivo = New System.Windows.Forms.SaveFileDialog()
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numNoPlanilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PLGenerarBancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLPlanillaBancosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.c1txtCtaDeb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtCtaDeb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtCtaDeb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtCorrelativoFicohsa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtCodigoInstitucion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtCodigoEmpresaBA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Fecha de Elaboración:"
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
        Me.c1dateFecha.Location = New System.Drawing.Point(130, 12)
        Me.c1dateFecha.Name = "c1dateFecha"
        Me.c1dateFecha.Size = New System.Drawing.Size(105, 20)
        Me.c1dateFecha.TabIndex = 1
        Me.c1dateFecha.Tag = Nothing
        Me.c1dateFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Hora:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(259, 275)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(101, 32)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(12, 275)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(101, 32)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblDescPlanilla
        '
        Me.lblDescPlanilla.AutoSize = True
        Me.lblDescPlanilla.Location = New System.Drawing.Point(15, 248)
        Me.lblDescPlanilla.Name = "lblDescPlanilla"
        Me.lblDescPlanilla.Size = New System.Drawing.Size(10, 13)
        Me.lblDescPlanilla.TabIndex = 22
        Me.lblDescPlanilla.Text = "."
        '
        'c1numNoPlanilla
        '
        Me.c1numNoPlanilla.DataType = GetType(Short)
        Me.c1numNoPlanilla.Location = New System.Drawing.Point(99, 218)
        Me.c1numNoPlanilla.Name = "c1numNoPlanilla"
        Me.c1numNoPlanilla.Size = New System.Drawing.Size(30, 20)
        Me.c1numNoPlanilla.TabIndex = 10
        Me.c1numNoPlanilla.Tag = Nothing
        Me.c1numNoPlanilla.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "No. de Planilla:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radiobutAtlantida)
        Me.GroupBox1.Controls.Add(Me.radiobutHSBC)
        Me.GroupBox1.Controls.Add(Me.radiobutFicohsa)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 40)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Banco"
        '
        'radiobutAtlantida
        '
        Me.radiobutAtlantida.AutoSize = True
        Me.radiobutAtlantida.Location = New System.Drawing.Point(165, 17)
        Me.radiobutAtlantida.Name = "radiobutAtlantida"
        Me.radiobutAtlantida.Size = New System.Drawing.Size(66, 17)
        Me.radiobutAtlantida.TabIndex = 4
        Me.radiobutAtlantida.TabStop = True
        Me.radiobutAtlantida.Text = "Atlántida"
        Me.radiobutAtlantida.UseVisualStyleBackColor = True
        '
        'radiobutHSBC
        '
        Me.radiobutHSBC.AutoSize = True
        Me.radiobutHSBC.Location = New System.Drawing.Point(93, 17)
        Me.radiobutHSBC.Name = "radiobutHSBC"
        Me.radiobutHSBC.Size = New System.Drawing.Size(54, 17)
        Me.radiobutHSBC.TabIndex = 3
        Me.radiobutHSBC.TabStop = True
        Me.radiobutHSBC.Text = "HSBC"
        Me.radiobutHSBC.UseVisualStyleBackColor = True
        '
        'radiobutFicohsa
        '
        Me.radiobutFicohsa.AutoSize = True
        Me.radiobutFicohsa.Checked = True
        Me.radiobutFicohsa.Location = New System.Drawing.Point(7, 17)
        Me.radiobutFicohsa.Name = "radiobutFicohsa"
        Me.radiobutFicohsa.Size = New System.Drawing.Size(71, 17)
        Me.radiobutFicohsa.TabIndex = 2
        Me.radiobutFicohsa.TabStop = True
        Me.radiobutFicohsa.Text = "FICOHSA"
        Me.radiobutFicohsa.UseVisualStyleBackColor = True
        '
        'PLGenerarBancosBindingSource
        '
        Me.PLGenerarBancosBindingSource.DataMember = "PLPlanillas"
        Me.PLGenerarBancosBindingSource.DataSource = Me.PLPlanillaBancosDataSet
        '
        'PLPlanillaBancosDataSet
        '
        Me.PLPlanillaBancosDataSet.DataSetName = "PLPlanillaBancosDataSet"
        Me.PLPlanillaBancosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLPlanillasTableAdapter
        '
        Me.PLPlanillasTableAdapter.ClearBeforeFill = True
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(270, 15)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(39, 13)
        Me.lblHora.TabIndex = 27
        Me.lblHora.Text = "Label7"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(14, 90)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(350, 122)
        Me.TabControl1.TabIndex = 28
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.c1txtCtaDeb3)
        Me.TabPage1.Controls.Add(Me.c1txtCtaDeb2)
        Me.TabPage1.Controls.Add(Me.c1txtCtaDeb1)
        Me.TabPage1.Controls.Add(Me.c1txtCorrelativoFicohsa)
        Me.TabPage1.Controls.Add(Me.c1txtCodigoInstitucion)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(342, 96)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos de Ficohsa"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.c1txtCodigoEmpresaBA)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(342, 96)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos de Atlántida"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'c1txtCtaDeb3
        '
        Me.c1txtCtaDeb3.Location = New System.Drawing.Point(238, 65)
        Me.c1txtCtaDeb3.Name = "c1txtCtaDeb3"
        Me.c1txtCtaDeb3.Size = New System.Drawing.Size(90, 20)
        Me.c1txtCtaDeb3.TabIndex = 17
        Me.c1txtCtaDeb3.Tag = Nothing
        '
        'c1txtCtaDeb2
        '
        Me.c1txtCtaDeb2.Location = New System.Drawing.Point(188, 65)
        Me.c1txtCtaDeb2.Name = "c1txtCtaDeb2"
        Me.c1txtCtaDeb2.Size = New System.Drawing.Size(44, 20)
        Me.c1txtCtaDeb2.TabIndex = 16
        Me.c1txtCtaDeb2.Tag = Nothing
        '
        'c1txtCtaDeb1
        '
        Me.c1txtCtaDeb1.Location = New System.Drawing.Point(141, 65)
        Me.c1txtCtaDeb1.Name = "c1txtCtaDeb1"
        Me.c1txtCtaDeb1.Size = New System.Drawing.Size(41, 20)
        Me.c1txtCtaDeb1.TabIndex = 15
        Me.c1txtCtaDeb1.Tag = Nothing
        '
        'c1txtCorrelativoFicohsa
        '
        Me.c1txtCorrelativoFicohsa.Location = New System.Drawing.Point(141, 38)
        Me.c1txtCorrelativoFicohsa.Name = "c1txtCorrelativoFicohsa"
        Me.c1txtCorrelativoFicohsa.Size = New System.Drawing.Size(120, 20)
        Me.c1txtCorrelativoFicohsa.TabIndex = 14
        Me.c1txtCorrelativoFicohsa.Tag = Nothing
        '
        'c1txtCodigoInstitucion
        '
        Me.c1txtCodigoInstitucion.Location = New System.Drawing.Point(141, 12)
        Me.c1txtCodigoInstitucion.Name = "c1txtCodigoInstitucion"
        Me.c1txtCodigoInstitucion.Size = New System.Drawing.Size(120, 20)
        Me.c1txtCodigoInstitucion.TabIndex = 13
        Me.c1txtCodigoInstitucion.Tag = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cuenta a Debitar:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "No. Correlativo de Planilla:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Código de Institución:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Código de la Empresa:"
        '
        'c1txtCodigoEmpresaBA
        '
        Me.c1txtCodigoEmpresaBA.Location = New System.Drawing.Point(125, 16)
        Me.c1txtCodigoEmpresaBA.Name = "c1txtCodigoEmpresaBA"
        Me.c1txtCodigoEmpresaBA.Size = New System.Drawing.Size(81, 20)
        Me.c1txtCodigoEmpresaBA.TabIndex = 14
        Me.c1txtCodigoEmpresaBA.Tag = Nothing
        '
        'PLGenerarBancosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 314)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblDescPlanilla)
        Me.Controls.Add(Me.c1numNoPlanilla)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.c1dateFecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PLGenerarBancosFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Planilla Para Bancos"
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numNoPlanilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PLGenerarBancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLPlanillaBancosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.c1txtCtaDeb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtCtaDeb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtCtaDeb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtCorrelativoFicohsa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtCodigoInstitucion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtCodigoEmpresaBA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents c1dateFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblDescPlanilla As System.Windows.Forms.Label
    Friend WithEvents c1numNoPlanilla As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radiobutAtlantida As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutHSBC As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutFicohsa As System.Windows.Forms.RadioButton
    Friend WithEvents PLGenerarBancosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLPlanillaBancosDataSet As RSIContab.PLPlanillaBancosDataSet
    Friend WithEvents PLPlanillasTableAdapter As RSIContab.PLPlanillaBancosDataSetTableAdapters.PLPlanillasTableAdapter
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents c1txtCtaDeb3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtCtaDeb2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtCtaDeb1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtCorrelativoFicohsa As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtCodigoInstitucion As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents c1txtCodigoEmpresaBA As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dlgGuardarArchivo As System.Windows.Forms.SaveFileDialog
End Class
