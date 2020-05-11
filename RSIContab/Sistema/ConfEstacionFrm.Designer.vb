<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfEstacionFrm
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.c1txConfirmarClave = New C1.Win.C1Input.C1TextBox()
        Me.c1txtClaveCarpetaEmpleados = New C1.Win.C1Input.C1TextBox()
        Me.c1txtUsuarioCarpetaEmpleados = New C1.Win.C1Input.C1TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkboxNecesitaClaveCarpetaEmpleados = New System.Windows.Forms.CheckBox()
        Me.btnCarpetaEmpleados = New System.Windows.Forms.Button()
        Me.btnBuscarExcel = New System.Windows.Forms.Button()
        Me.btnBuscarWord = New System.Windows.Forms.Button()
        Me.c1txtDirEmpleados = New C1.Win.C1Input.C1TextBox()
        Me.c1txtExcel = New C1.Win.C1Input.C1TextBox()
        Me.c1txtWord = New C1.Win.C1Input.C1TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.dlgArch = New System.Windows.Forms.OpenFileDialog()
        Me.dlgFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkboxFormatoArbolListaCat = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.c1txConfirmarClave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtClaveCarpetaEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtUsuarioCarpetaEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtDirEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtWord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnCarpetaEmpleados)
        Me.GroupBox1.Controls.Add(Me.btnBuscarExcel)
        Me.GroupBox1.Controls.Add(Me.btnBuscarWord)
        Me.GroupBox1.Controls.Add(Me.c1txtDirEmpleados)
        Me.GroupBox1.Controls.Add(Me.c1txtExcel)
        Me.GroupBox1.Controls.Add(Me.c1txtWord)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 165)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.c1txConfirmarClave)
        Me.GroupBox2.Controls.Add(Me.c1txtClaveCarpetaEmpleados)
        Me.GroupBox2.Controls.Add(Me.c1txtUsuarioCarpetaEmpleados)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.chkboxNecesitaClaveCarpetaEmpleados)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(451, 52)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(309, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Conf."
        '
        'c1txConfirmarClave
        '
        Me.c1txConfirmarClave.Location = New System.Drawing.Point(347, 23)
        Me.c1txConfirmarClave.Name = "c1txConfirmarClave"
        Me.c1txConfirmarClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.c1txConfirmarClave.Size = New System.Drawing.Size(98, 20)
        Me.c1txConfirmarClave.TabIndex = 15
        Me.c1txConfirmarClave.Tag = Nothing
        '
        'c1txtClaveCarpetaEmpleados
        '
        Me.c1txtClaveCarpetaEmpleados.Location = New System.Drawing.Point(204, 23)
        Me.c1txtClaveCarpetaEmpleados.Name = "c1txtClaveCarpetaEmpleados"
        Me.c1txtClaveCarpetaEmpleados.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.c1txtClaveCarpetaEmpleados.Size = New System.Drawing.Size(98, 20)
        Me.c1txtClaveCarpetaEmpleados.TabIndex = 14
        Me.c1txtClaveCarpetaEmpleados.Tag = Nothing
        '
        'c1txtUsuarioCarpetaEmpleados
        '
        Me.c1txtUsuarioCarpetaEmpleados.Location = New System.Drawing.Point(60, 24)
        Me.c1txtUsuarioCarpetaEmpleados.Name = "c1txtUsuarioCarpetaEmpleados"
        Me.c1txtUsuarioCarpetaEmpleados.Size = New System.Drawing.Size(95, 20)
        Me.c1txtUsuarioCarpetaEmpleados.TabIndex = 13
        Me.c1txtUsuarioCarpetaEmpleados.Tag = Nothing
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(161, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Clave:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Usuario:"
        '
        'chkboxNecesitaClaveCarpetaEmpleados
        '
        Me.chkboxNecesitaClaveCarpetaEmpleados.AutoSize = True
        Me.chkboxNecesitaClaveCarpetaEmpleados.Location = New System.Drawing.Point(6, 0)
        Me.chkboxNecesitaClaveCarpetaEmpleados.Name = "chkboxNecesitaClaveCarpetaEmpleados"
        Me.chkboxNecesitaClaveCarpetaEmpleados.Size = New System.Drawing.Size(296, 17)
        Me.chkboxNecesitaClaveCarpetaEmpleados.TabIndex = 10
        Me.chkboxNecesitaClaveCarpetaEmpleados.Text = "Es Necesario Clave Para Accesar Carpeta de Empleados"
        Me.chkboxNecesitaClaveCarpetaEmpleados.UseVisualStyleBackColor = True
        '
        'btnCarpetaEmpleados
        '
        Me.btnCarpetaEmpleados.Location = New System.Drawing.Point(428, 74)
        Me.btnCarpetaEmpleados.Name = "btnCarpetaEmpleados"
        Me.btnCarpetaEmpleados.Size = New System.Drawing.Size(28, 23)
        Me.btnCarpetaEmpleados.TabIndex = 9
        Me.btnCarpetaEmpleados.Text = "..."
        Me.btnCarpetaEmpleados.UseVisualStyleBackColor = True
        '
        'btnBuscarExcel
        '
        Me.btnBuscarExcel.Location = New System.Drawing.Point(428, 46)
        Me.btnBuscarExcel.Name = "btnBuscarExcel"
        Me.btnBuscarExcel.Size = New System.Drawing.Size(28, 23)
        Me.btnBuscarExcel.TabIndex = 9
        Me.btnBuscarExcel.Text = "..."
        Me.btnBuscarExcel.UseVisualStyleBackColor = True
        '
        'btnBuscarWord
        '
        Me.btnBuscarWord.Location = New System.Drawing.Point(428, 19)
        Me.btnBuscarWord.Name = "btnBuscarWord"
        Me.btnBuscarWord.Size = New System.Drawing.Size(28, 23)
        Me.btnBuscarWord.TabIndex = 8
        Me.btnBuscarWord.Text = "..."
        Me.btnBuscarWord.UseVisualStyleBackColor = True
        '
        'c1txtDirEmpleados
        '
        Me.c1txtDirEmpleados.Location = New System.Drawing.Point(136, 75)
        Me.c1txtDirEmpleados.Name = "c1txtDirEmpleados"
        Me.c1txtDirEmpleados.Size = New System.Drawing.Size(294, 20)
        Me.c1txtDirEmpleados.TabIndex = 7
        Me.c1txtDirEmpleados.Tag = Nothing
        '
        'c1txtExcel
        '
        Me.c1txtExcel.Location = New System.Drawing.Point(136, 48)
        Me.c1txtExcel.Name = "c1txtExcel"
        Me.c1txtExcel.Size = New System.Drawing.Size(294, 20)
        Me.c1txtExcel.TabIndex = 5
        Me.c1txtExcel.Tag = Nothing
        '
        'c1txtWord
        '
        Me.c1txtWord.Location = New System.Drawing.Point(136, 20)
        Me.c1txtWord.Name = "c1txtWord"
        Me.c1txtWord.Size = New System.Drawing.Size(294, 20)
        Me.c1txtWord.TabIndex = 4
        Me.c1txtWord.Tag = Nothing
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Carpeta de Empleados:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MS Excel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MS Word:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(22, 252)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(86, 31)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(382, 252)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(86, 31)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkboxFormatoArbolListaCat)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 184)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(467, 48)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contabilidad"
        '
        'chkboxFormatoArbolListaCat
        '
        Me.chkboxFormatoArbolListaCat.AutoSize = True
        Me.chkboxFormatoArbolListaCat.Location = New System.Drawing.Point(9, 20)
        Me.chkboxFormatoArbolListaCat.Name = "chkboxFormatoArbolListaCat"
        Me.chkboxFormatoArbolListaCat.Size = New System.Drawing.Size(376, 17)
        Me.chkboxFormatoArbolListaCat.TabIndex = 0
        Me.chkboxFormatoArbolListaCat.Text = "Usar Formato de Arbol Para la Lista de Selección del Catálogo de Cuentas"
        Me.chkboxFormatoArbolListaCat.UseVisualStyleBackColor = True
        '
        'ConfEstacionFrm
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 295)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConfEstacionFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración de Esta Estación"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.c1txConfirmarClave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtClaveCarpetaEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtUsuarioCarpetaEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtDirEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtWord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dlgArch As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents c1txtDirEmpleados As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtExcel As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtWord As C1.Win.C1Input.C1TextBox
    Friend WithEvents btnCarpetaEmpleados As System.Windows.Forms.Button
    Friend WithEvents btnBuscarExcel As System.Windows.Forms.Button
    Friend WithEvents btnBuscarWord As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkboxNecesitaClaveCarpetaEmpleados As System.Windows.Forms.CheckBox
    Friend WithEvents c1txtClaveCarpetaEmpleados As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtUsuarioCarpetaEmpleados As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents c1txConfirmarClave As C1.Win.C1Input.C1TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkboxFormatoArbolListaCat As System.Windows.Forms.CheckBox
End Class
