<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLImportarDatosDeAccessFrm
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
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.cmbTablas = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBaseDatosAccess = New System.Windows.Forms.TextBox
        Me.txtAño = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtMes = New System.Windows.Forms.TextBox
        Me.chkProcesarAño = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(28, 156)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(101, 36)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(241, 156)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(101, 36)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'cmbTablas
        '
        Me.cmbTablas.FormattingEnabled = True
        Me.cmbTablas.Location = New System.Drawing.Point(106, 19)
        Me.cmbTablas.Name = "cmbTablas"
        Me.cmbTablas.Size = New System.Drawing.Size(168, 21)
        Me.cmbTablas.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tabla a Importar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ubicación de la Base de Datos de Access"
        '
        'txtBaseDatosAccess
        '
        Me.txtBaseDatosAccess.Location = New System.Drawing.Point(15, 69)
        Me.txtBaseDatosAccess.Name = "txtBaseDatosAccess"
        Me.txtBaseDatosAccess.Size = New System.Drawing.Size(259, 20)
        Me.txtBaseDatosAccess.TabIndex = 5
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(50, 99)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(37, 20)
        Me.txtAño.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Año:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(103, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Mes:"
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(139, 99)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(37, 20)
        Me.txtMes.TabIndex = 8
        '
        'chkProcesarAño
        '
        Me.chkProcesarAño.AutoSize = True
        Me.chkProcesarAño.Location = New System.Drawing.Point(193, 101)
        Me.chkProcesarAño.Name = "chkProcesarAño"
        Me.chkProcesarAño.Size = New System.Drawing.Size(125, 17)
        Me.chkProcesarAño.TabIndex = 10
        Me.chkProcesarAño.Text = "Procesar todo el Año"
        Me.chkProcesarAño.UseVisualStyleBackColor = True
        '
        'PLImportarDatosDeAccessFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 209)
        Me.Controls.Add(Me.chkProcesarAño)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.txtBaseDatosAccess)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbTablas)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PLImportarDatosDeAccessFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar Datos de Planillas de Access"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents cmbTablas As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBaseDatosAccess As System.Windows.Forms.TextBox
    Friend WithEvents txtAño As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents chkProcesarAño As System.Windows.Forms.CheckBox
End Class
