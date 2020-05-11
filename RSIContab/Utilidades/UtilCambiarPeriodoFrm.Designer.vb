<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UtilCambiarPeriodoFrm
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.chkboxUsarPeriodoUsuario = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.c1numAñoUsuario = New C1.Win.C1Input.C1NumericEdit()
        Me.cmbMeses = New System.Windows.Forms.ComboBox()
        CType(Me.c1numAñoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Location = New System.Drawing.Point(25, 75)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(97, 31)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(170, 75)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(97, 31)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'chkboxUsarPeriodoUsuario
        '
        Me.chkboxUsarPeriodoUsuario.AutoSize = True
        Me.chkboxUsarPeriodoUsuario.Location = New System.Drawing.Point(25, 12)
        Me.chkboxUsarPeriodoUsuario.Name = "chkboxUsarPeriodoUsuario"
        Me.chkboxUsarPeriodoUsuario.Size = New System.Drawing.Size(113, 17)
        Me.chkboxUsarPeriodoUsuario.TabIndex = 2
        Me.chkboxUsarPeriodoUsuario.Text = "Usar Este Período"
        Me.chkboxUsarPeriodoUsuario.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Año:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mes:"
        '
        'c1numAñoUsuario
        '
        Me.c1numAñoUsuario.DataType = GetType(Short)
        Me.c1numAñoUsuario.Location = New System.Drawing.Point(60, 37)
        Me.c1numAñoUsuario.Name = "c1numAñoUsuario"
        Me.c1numAñoUsuario.Size = New System.Drawing.Size(50, 20)
        Me.c1numAñoUsuario.TabIndex = 31
        Me.c1numAñoUsuario.Tag = Nothing
        Me.c1numAñoUsuario.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cmbMeses
        '
        Me.cmbMeses.FormattingEnabled = True
        Me.cmbMeses.Location = New System.Drawing.Point(166, 37)
        Me.cmbMeses.Name = "cmbMeses"
        Me.cmbMeses.Size = New System.Drawing.Size(101, 21)
        Me.cmbMeses.TabIndex = 32
        '
        'UtilCambiarPeriodoFrm
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(289, 116)
        Me.Controls.Add(Me.cmbMeses)
        Me.Controls.Add(Me.c1numAñoUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkboxUsarPeriodoUsuario)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UtilCambiarPeriodoFrm"
        Me.Text = "Cambiar Período"
        CType(Me.c1numAñoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents chkboxUsarPeriodoUsuario As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents c1numAñoUsuario As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents cmbMeses As System.Windows.Forms.ComboBox
End Class
