<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLRepAnualDedSocExcelFrm
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
        Me.radiobutSeguroSoc = New System.Windows.Forms.RadioButton()
        Me.radiobutRAP = New System.Windows.Forms.RadioButton()
        Me.radiobutISR = New System.Windows.Forms.RadioButton()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.c1numAño = New C1.Win.C1Input.C1NumericEdit()
        Me.radiobutSeguroMedico = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1numAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radiobutSeguroMedico)
        Me.GroupBox1.Controls.Add(Me.radiobutSeguroSoc)
        Me.GroupBox1.Controls.Add(Me.radiobutRAP)
        Me.GroupBox1.Controls.Add(Me.radiobutISR)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 44)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deducción"
        '
        'radiobutSeguroSoc
        '
        Me.radiobutSeguroSoc.AutoSize = True
        Me.radiobutSeguroSoc.Location = New System.Drawing.Point(109, 19)
        Me.radiobutSeguroSoc.Name = "radiobutSeguroSoc"
        Me.radiobutSeguroSoc.Size = New System.Drawing.Size(91, 17)
        Me.radiobutSeguroSoc.TabIndex = 2
        Me.radiobutSeguroSoc.Text = "Seguro Social"
        Me.radiobutSeguroSoc.UseVisualStyleBackColor = True
        '
        'radiobutRAP
        '
        Me.radiobutRAP.AutoSize = True
        Me.radiobutRAP.Location = New System.Drawing.Point(56, 20)
        Me.radiobutRAP.Name = "radiobutRAP"
        Me.radiobutRAP.Size = New System.Drawing.Size(47, 17)
        Me.radiobutRAP.TabIndex = 1
        Me.radiobutRAP.Text = "RAP"
        Me.radiobutRAP.UseVisualStyleBackColor = True
        '
        'radiobutISR
        '
        Me.radiobutISR.AutoSize = True
        Me.radiobutISR.Checked = True
        Me.radiobutISR.Location = New System.Drawing.Point(7, 20)
        Me.radiobutISR.Name = "radiobutISR"
        Me.radiobutISR.Size = New System.Drawing.Size(43, 17)
        Me.radiobutISR.TabIndex = 0
        Me.radiobutISR.TabStop = True
        Me.radiobutISR.Text = "ISR"
        Me.radiobutISR.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(19, 110)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(99, 33)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(218, 110)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(99, 33)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Año a Listar:"
        '
        'c1numAño
        '
        Me.c1numAño.DataType = GetType(Short)
        Me.c1numAño.Location = New System.Drawing.Point(84, 73)
        Me.c1numAño.Name = "c1numAño"
        Me.c1numAño.Size = New System.Drawing.Size(47, 20)
        Me.c1numAño.TabIndex = 11
        Me.c1numAño.Tag = Nothing
        Me.c1numAño.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'radiobutSeguroMedico
        '
        Me.radiobutSeguroMedico.AutoSize = True
        Me.radiobutSeguroMedico.Location = New System.Drawing.Point(206, 19)
        Me.radiobutSeguroMedico.Name = "radiobutSeguroMedico"
        Me.radiobutSeguroMedico.Size = New System.Drawing.Size(97, 17)
        Me.radiobutSeguroMedico.TabIndex = 3
        Me.radiobutSeguroMedico.Text = "Seguro Médico"
        Me.radiobutSeguroMedico.UseVisualStyleBackColor = True
        '
        'PLRepAnualDedSocExcelFrm
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(344, 148)
        Me.Controls.Add(Me.c1numAño)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PLRepAnualDedSocExcelFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Anual de Deducciones a Excel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1numAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radiobutSeguroSoc As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutRAP As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutISR As System.Windows.Forms.RadioButton
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents c1numAño As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents radiobutSeguroMedico As System.Windows.Forms.RadioButton
End Class
