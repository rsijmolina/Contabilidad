<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UtilRespaldoBD
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
        Me.lblCarpetaRespaldoRest = New System.Windows.Forms.Label
        Me.txtCarpetaRespaldo = New System.Windows.Forms.TextBox
        Me.btnCarpeta = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.dlgCarpetaRespaldo = New System.Windows.Forms.FolderBrowserDialog
        Me.dlgArchivoRespaldoBD = New System.Windows.Forms.OpenFileDialog
        Me.lblProcesando = New System.Windows.Forms.Label
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblCarpetaRespaldoRest
        '
        Me.lblCarpetaRespaldoRest.AutoSize = True
        Me.lblCarpetaRespaldoRest.Location = New System.Drawing.Point(9, 52)
        Me.lblCarpetaRespaldoRest.Name = "lblCarpetaRespaldoRest"
        Me.lblCarpetaRespaldoRest.Size = New System.Drawing.Size(223, 13)
        Me.lblCarpetaRespaldoRest.TabIndex = 0
        Me.lblCarpetaRespaldoRest.Text = "Carpeta donde guardará la copia de respaldo:"
        '
        'txtCarpetaRespaldo
        '
        Me.txtCarpetaRespaldo.Location = New System.Drawing.Point(12, 68)
        Me.txtCarpetaRespaldo.Name = "txtCarpetaRespaldo"
        Me.txtCarpetaRespaldo.Size = New System.Drawing.Size(321, 20)
        Me.txtCarpetaRespaldo.TabIndex = 1
        '
        'btnCarpeta
        '
        Me.btnCarpeta.Location = New System.Drawing.Point(330, 65)
        Me.btnCarpeta.Name = "btnCarpeta"
        Me.btnCarpeta.Size = New System.Drawing.Size(24, 23)
        Me.btnCarpeta.TabIndex = 2
        Me.btnCarpeta.Text = "..."
        Me.btnCarpeta.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(12, 103)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(88, 32)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(266, 103)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(88, 32)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'dlgCarpetaRespaldo
        '
        Me.dlgCarpetaRespaldo.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'dlgArchivoRespaldoBD
        '
        Me.dlgArchivoRespaldoBD.DefaultExt = "bak"
        '
        'lblProcesando
        '
        Me.lblProcesando.AutoSize = True
        Me.lblProcesando.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcesando.Location = New System.Drawing.Point(146, 122)
        Me.lblProcesando.Name = "lblProcesando"
        Me.lblProcesando.Size = New System.Drawing.Size(86, 13)
        Me.lblProcesando.TabIndex = 5
        Me.lblProcesando.Text = "Procesando..."
        Me.lblProcesando.Visible = False
        '
        'lblMensaje
        '
        Me.lblMensaje.Location = New System.Drawing.Point(13, 5)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(341, 47)
        Me.lblMensaje.TabIndex = 6
        Me.lblMensaje.Text = "."
        '
        'UtilRespaldoBD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 147)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.lblProcesando)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCarpeta)
        Me.Controls.Add(Me.txtCarpetaRespaldo)
        Me.Controls.Add(Me.lblCarpetaRespaldoRest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UtilRespaldoBD"
        Me.Text = "Copia de Respaldo de Base de Datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCarpetaRespaldoRest As System.Windows.Forms.Label
    Friend WithEvents txtCarpetaRespaldo As System.Windows.Forms.TextBox
    Friend WithEvents btnCarpeta As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents dlgCarpetaRespaldo As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents dlgArchivoRespaldoBD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblProcesando As System.Windows.Forms.Label
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
End Class
