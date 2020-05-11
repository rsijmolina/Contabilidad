<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTExpImpCatalogoFrm
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
        Me.RadioButImportar = New System.Windows.Forms.RadioButton()
        Me.RadioButExportar = New System.Windows.Forms.RadioButton()
        Me.butCancelar = New System.Windows.Forms.Button()
        Me.butAceptar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButImportar)
        Me.GroupBox1.Controls.Add(Me.RadioButExportar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 93)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'RadioButImportar
        '
        Me.RadioButImportar.AutoSize = True
        Me.RadioButImportar.Location = New System.Drawing.Point(18, 53)
        Me.RadioButImportar.Name = "RadioButImportar"
        Me.RadioButImportar.Size = New System.Drawing.Size(165, 17)
        Me.RadioButImportar.TabIndex = 1
        Me.RadioButImportar.TabStop = True
        Me.RadioButImportar.Text = "Importar Catálogo de Cuentas"
        Me.RadioButImportar.UseVisualStyleBackColor = True
        '
        'RadioButExportar
        '
        Me.RadioButExportar.AutoSize = True
        Me.RadioButExportar.Checked = True
        Me.RadioButExportar.Location = New System.Drawing.Point(18, 20)
        Me.RadioButExportar.Name = "RadioButExportar"
        Me.RadioButExportar.Size = New System.Drawing.Size(166, 17)
        Me.RadioButExportar.TabIndex = 0
        Me.RadioButExportar.TabStop = True
        Me.RadioButExportar.Text = "Exportar Catálogo de Cuentas"
        Me.RadioButExportar.UseVisualStyleBackColor = True
        '
        'butCancelar
        '
        Me.butCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butCancelar.Image = Global.RSIContab.My.Resources.Resources._1393662113_cancel
        Me.butCancelar.Location = New System.Drawing.Point(306, 112)
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
        Me.butAceptar.Location = New System.Drawing.Point(12, 112)
        Me.butAceptar.Name = "butAceptar"
        Me.butAceptar.Size = New System.Drawing.Size(107, 33)
        Me.butAceptar.TabIndex = 58
        Me.butAceptar.Text = "&Aceptar"
        Me.butAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butAceptar.UseVisualStyleBackColor = True
        '
        'CTExpImpCatalogoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 157)
        Me.Controls.Add(Me.butCancelar)
        Me.Controls.Add(Me.butAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CTExpImpCatalogoFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Exportar-Importar Catálogo de Cuentas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButImportar As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButExportar As System.Windows.Forms.RadioButton
    Friend WithEvents butCancelar As System.Windows.Forms.Button
    Friend WithEvents butAceptar As System.Windows.Forms.Button
End Class
