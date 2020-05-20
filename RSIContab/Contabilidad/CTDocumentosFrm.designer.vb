<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTDocumentosFrm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.C1ButtonSeleccionarArchivo = New C1.Win.C1Input.C1Button()
        Me.TextBoxComentario = New System.Windows.Forms.TextBox()
        Me.TextBoxArchivo = New System.Windows.Forms.TextBox()
        Me.OpenFileDialogArchivo = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblTipoArchivo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.butCancelar = New System.Windows.Forms.Button()
        Me.butAceptar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1ButtonSeleccionarArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Archivo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Comentario:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.C1ButtonSeleccionarArchivo)
        Me.GroupBox1.Controls.Add(Me.TextBoxComentario)
        Me.GroupBox1.Controls.Add(Me.TextBoxArchivo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 152)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'C1ButtonSeleccionarArchivo
        '
        Me.C1ButtonSeleccionarArchivo.Image = Global.RSIContab.My.Resources.Resources._1425432924_Magnifier2
        Me.C1ButtonSeleccionarArchivo.Location = New System.Drawing.Point(322, 25)
        Me.C1ButtonSeleccionarArchivo.Name = "C1ButtonSeleccionarArchivo"
        Me.C1ButtonSeleccionarArchivo.Size = New System.Drawing.Size(33, 23)
        Me.C1ButtonSeleccionarArchivo.TabIndex = 4
        Me.C1ButtonSeleccionarArchivo.UseVisualStyleBackColor = True
        '
        'TextBoxComentario
        '
        Me.TextBoxComentario.Location = New System.Drawing.Point(69, 54)
        Me.TextBoxComentario.Multiline = True
        Me.TextBoxComentario.Name = "TextBoxComentario"
        Me.TextBoxComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxComentario.Size = New System.Drawing.Size(286, 79)
        Me.TextBoxComentario.TabIndex = 3
        '
        'TextBoxArchivo
        '
        Me.TextBoxArchivo.Location = New System.Drawing.Point(69, 25)
        Me.TextBoxArchivo.Name = "TextBoxArchivo"
        Me.TextBoxArchivo.Size = New System.Drawing.Size(246, 20)
        Me.TextBoxArchivo.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblFecha)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.LblTipoArchivo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.LblUsuario)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 89)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Usuario:"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Location = New System.Drawing.Point(127, 16)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(10, 13)
        Me.LblUsuario.TabIndex = 6
        Me.LblUsuario.Text = "."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tipo de Documento:"
        '
        'LblTipoArchivo
        '
        Me.LblTipoArchivo.AutoSize = True
        Me.LblTipoArchivo.Location = New System.Drawing.Point(127, 38)
        Me.LblTipoArchivo.Name = "LblTipoArchivo"
        Me.LblTipoArchivo.Size = New System.Drawing.Size(10, 13)
        Me.LblTipoArchivo.TabIndex = 8
        Me.LblTipoArchivo.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fecha:"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Location = New System.Drawing.Point(127, 59)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(10, 13)
        Me.LblFecha.TabIndex = 10
        Me.LblFecha.Text = "."
        '
        'butCancelar
        '
        Me.butCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butCancelar.Image = Global.RSIContab.My.Resources.Resources._1393662113_cancel
        Me.butCancelar.Location = New System.Drawing.Point(266, 263)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(107, 33)
        Me.butCancelar.TabIndex = 61
        Me.butCancelar.Text = "&Cancelar"
        Me.butCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butCancelar.UseVisualStyleBackColor = True
        '
        'butAceptar
        '
        Me.butAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.butAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.butAceptar.Image = Global.RSIContab.My.Resources.Resources._1393538844_tick_16
        Me.butAceptar.Location = New System.Drawing.Point(13, 263)
        Me.butAceptar.Name = "butAceptar"
        Me.butAceptar.Size = New System.Drawing.Size(107, 33)
        Me.butAceptar.TabIndex = 60
        Me.butAceptar.Text = "&Aceptar"
        Me.butAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butAceptar.UseVisualStyleBackColor = True
        '
        'CTDocumentosFrm
        '
        Me.AcceptButton = Me.butAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.butCancelar
        Me.ClientSize = New System.Drawing.Size(385, 302)
        Me.Controls.Add(Me.butCancelar)
        Me.Controls.Add(Me.butAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CTDocumentosFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.C1ButtonSeleccionarArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents C1ButtonSeleccionarArchivo As C1.Win.C1Input.C1Button
    Friend WithEvents TextBoxComentario As TextBox
    Friend WithEvents TextBoxArchivo As TextBox
    Friend WithEvents OpenFileDialogArchivo As OpenFileDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LblFecha As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblTipoArchivo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblUsuario As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents butCancelar As Button
    Friend WithEvents butAceptar As Button
End Class
