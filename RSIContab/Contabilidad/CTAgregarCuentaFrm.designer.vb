<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTAgregarCuentaFrm
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
        Me.lblNivel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDescripcionCtaSuperior = New System.Windows.Forms.Label()
        Me.lblCuentaSuperior = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.picCuenta = New System.Windows.Forms.PictureBox()
        Me.c1txtFormato = New C1.Win.C1Input.C1TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.c1numSubCuenta = New C1.Win.C1Input.C1NumericEdit()
        Me.lblNuevaCuenta = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkboxPosteable = New System.Windows.Forms.CheckBox()
        Me.c1txtDescripcion = New C1.Win.C1Input.C1TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.butAceptar = New System.Windows.Forms.Button()
        Me.butCancelar = New System.Windows.Forms.Button()
        Me.lblNaturaleza = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtFormato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSubCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTipo)
        Me.GroupBox1.Controls.Add(Me.lblNaturaleza)
        Me.GroupBox1.Controls.Add(Me.lblNivel)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblDescripcionCtaSuperior)
        Me.GroupBox1.Controls.Add(Me.lblCuentaSuperior)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 76)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuenta Superior"
        '
        'lblNivel
        '
        Me.lblNivel.AutoSize = True
        Me.lblNivel.Location = New System.Drawing.Point(279, 19)
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(10, 13)
        Me.lblNivel.TabIndex = 5
        Me.lblNivel.Text = "."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(239, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Nivel:"
        '
        'lblDescripcionCtaSuperior
        '
        Me.lblDescripcionCtaSuperior.AutoSize = True
        Me.lblDescripcionCtaSuperior.Location = New System.Drawing.Point(74, 48)
        Me.lblDescripcionCtaSuperior.Name = "lblDescripcionCtaSuperior"
        Me.lblDescripcionCtaSuperior.Size = New System.Drawing.Size(10, 13)
        Me.lblDescripcionCtaSuperior.TabIndex = 3
        Me.lblDescripcionCtaSuperior.Text = "."
        '
        'lblCuentaSuperior
        '
        Me.lblCuentaSuperior.AutoSize = True
        Me.lblCuentaSuperior.Location = New System.Drawing.Point(74, 19)
        Me.lblCuentaSuperior.Name = "lblCuentaSuperior"
        Me.lblCuentaSuperior.Size = New System.Drawing.Size(10, 13)
        Me.lblCuentaSuperior.TabIndex = 2
        Me.lblCuentaSuperior.Text = "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cuenta:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.picCuenta)
        Me.GroupBox2.Controls.Add(Me.c1txtFormato)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.c1numSubCuenta)
        Me.GroupBox2.Controls.Add(Me.lblNuevaCuenta)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.chkboxPosteable)
        Me.GroupBox2.Controls.Add(Me.c1txtDescripcion)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(476, 105)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Subcuenta"
        '
        'picCuenta
        '
        Me.picCuenta.Location = New System.Drawing.Point(444, 10)
        Me.picCuenta.Name = "picCuenta"
        Me.picCuenta.Size = New System.Drawing.Size(26, 28)
        Me.picCuenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCuenta.TabIndex = 72
        Me.picCuenta.TabStop = False
        '
        'c1txtFormato
        '
        Me.c1txtFormato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtFormato.Location = New System.Drawing.Point(198, 25)
        Me.c1txtFormato.Name = "c1txtFormato"
        Me.c1txtFormato.ReadOnly = True
        Me.c1txtFormato.Size = New System.Drawing.Size(75, 20)
        Me.c1txtFormato.TabIndex = 71
        Me.c1txtFormato.Tag = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(144, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Formato:"
        '
        'c1numSubCuenta
        '
        Me.c1numSubCuenta.DataType = GetType(Short)
        Me.c1numSubCuenta.Location = New System.Drawing.Point(77, 25)
        Me.c1numSubCuenta.Name = "c1numSubCuenta"
        Me.c1numSubCuenta.Size = New System.Drawing.Size(61, 20)
        Me.c1numSubCuenta.TabIndex = 25
        Me.c1numSubCuenta.Tag = Nothing
        Me.c1numSubCuenta.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown
        '
        'lblNuevaCuenta
        '
        Me.lblNuevaCuenta.AutoSize = True
        Me.lblNuevaCuenta.Location = New System.Drawing.Point(329, 25)
        Me.lblNuevaCuenta.Name = "lblNuevaCuenta"
        Me.lblNuevaCuenta.Size = New System.Drawing.Size(10, 13)
        Me.lblNuevaCuenta.TabIndex = 69
        Me.lblNuevaCuenta.Text = "."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(279, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Cuenta:"
        '
        'chkboxPosteable
        '
        Me.chkboxPosteable.AutoSize = True
        Me.chkboxPosteable.Location = New System.Drawing.Point(77, 78)
        Me.chkboxPosteable.Name = "chkboxPosteable"
        Me.chkboxPosteable.Size = New System.Drawing.Size(73, 17)
        Me.chkboxPosteable.TabIndex = 65
        Me.chkboxPosteable.Text = "Posteable"
        Me.chkboxPosteable.UseVisualStyleBackColor = True
        '
        'c1txtDescripcion
        '
        Me.c1txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtDescripcion.Location = New System.Drawing.Point(77, 51)
        Me.c1txtDescripcion.Name = "c1txtDescripcion"
        Me.c1txtDescripcion.Size = New System.Drawing.Size(393, 20)
        Me.c1txtDescripcion.TabIndex = 63
        Me.c1txtDescripcion.Tag = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Descripción:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Subcuenta:"
        '
        'butAceptar
        '
        Me.butAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.butAceptar.Location = New System.Drawing.Point(39, 217)
        Me.butAceptar.Name = "butAceptar"
        Me.butAceptar.Size = New System.Drawing.Size(101, 32)
        Me.butAceptar.TabIndex = 2
        Me.butAceptar.Text = "&Aceptar"
        Me.butAceptar.UseVisualStyleBackColor = True
        '
        'butCancelar
        '
        Me.butCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butCancelar.Location = New System.Drawing.Point(354, 217)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(101, 32)
        Me.butCancelar.TabIndex = 3
        Me.butCancelar.Text = "&Cancelar"
        Me.butCancelar.UseVisualStyleBackColor = True
        '
        'lblNaturaleza
        '
        Me.lblNaturaleza.AutoSize = True
        Me.lblNaturaleza.Location = New System.Drawing.Point(332, 19)
        Me.lblNaturaleza.Name = "lblNaturaleza"
        Me.lblNaturaleza.Size = New System.Drawing.Size(15, 13)
        Me.lblNaturaleza.TabIndex = 6
        Me.lblNaturaleza.Text = "N"
        Me.lblNaturaleza.Visible = False
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(378, 20)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(14, 13)
        Me.lblTipo.TabIndex = 7
        Me.lblTipo.Text = "T"
        Me.lblTipo.Visible = False
        '
        'CTAgregarCuentaFrm
        '
        Me.AcceptButton = Me.butAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.butCancelar
        Me.ClientSize = New System.Drawing.Size(501, 259)
        Me.Controls.Add(Me.butCancelar)
        Me.Controls.Add(Me.butAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CTAgregarCuentaFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregando Cuenta al Catálogo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtFormato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSubCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents butAceptar As System.Windows.Forms.Button
    Friend WithEvents butCancelar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionCtaSuperior As System.Windows.Forms.Label
    Friend WithEvents lblCuentaSuperior As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkboxPosteable As System.Windows.Forms.CheckBox
    Friend WithEvents c1txtDescripcion As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblNuevaCuenta As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents c1numSubCuenta As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1txtFormato As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblNivel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents picCuenta As System.Windows.Forms.PictureBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblNaturaleza As System.Windows.Forms.Label
End Class
