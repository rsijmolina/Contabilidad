<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTConsolidacionEmpIni
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CTConsolidacionEmpIni))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radiobutConsolidacionImp = New System.Windows.Forms.RadioButton()
        Me.radiobutConsolidacionExp = New System.Windows.Forms.RadioButton()
        Me.radiobutConsolidacionComun = New System.Windows.Forms.RadioButton()
        Me.butCancelar = New System.Windows.Forms.Button()
        Me.butAceptar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 111)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(282, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Elija el tipo de proceso que realizará para la consolidación:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radiobutConsolidacionImp)
        Me.GroupBox1.Controls.Add(Me.radiobutConsolidacionExp)
        Me.GroupBox1.Controls.Add(Me.radiobutConsolidacionComun)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 132)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'radiobutConsolidacionImp
        '
        Me.radiobutConsolidacionImp.Location = New System.Drawing.Point(7, 86)
        Me.radiobutConsolidacionImp.Name = "radiobutConsolidacionImp"
        Me.radiobutConsolidacionImp.Size = New System.Drawing.Size(370, 40)
        Me.radiobutConsolidacionImp.TabIndex = 2
        Me.radiobutConsolidacionImp.Text = "Importar la información (La consolidación se realizará en este equipo procesando " & _
    "el archivo de texto previamente exportado  en otro equipo)"
        Me.radiobutConsolidacionImp.UseVisualStyleBackColor = True
        '
        'radiobutConsolidacionExp
        '
        Me.radiobutConsolidacionExp.Location = New System.Drawing.Point(7, 43)
        Me.radiobutConsolidacionExp.Name = "radiobutConsolidacionExp"
        Me.radiobutConsolidacionExp.Size = New System.Drawing.Size(370, 37)
        Me.radiobutConsolidacionExp.TabIndex = 1
        Me.radiobutConsolidacionExp.Text = "Exportar la información (La información será procesada en otro equipo donde se ef" & _
    "ectuará la consolidación)"
        Me.radiobutConsolidacionExp.UseVisualStyleBackColor = True
        '
        'radiobutConsolidacionComun
        '
        Me.radiobutConsolidacionComun.AutoSize = True
        Me.radiobutConsolidacionComun.Checked = True
        Me.radiobutConsolidacionComun.Location = New System.Drawing.Point(6, 19)
        Me.radiobutConsolidacionComun.Name = "radiobutConsolidacionComun"
        Me.radiobutConsolidacionComun.Size = New System.Drawing.Size(326, 17)
        Me.radiobutConsolidacionComun.TabIndex = 0
        Me.radiobutConsolidacionComun.TabStop = True
        Me.radiobutConsolidacionComun.Text = "Consolidación común (Toda las empresas están en este equipo)"
        Me.radiobutConsolidacionComun.UseVisualStyleBackColor = True
        '
        'butCancelar
        '
        Me.butCancelar.Location = New System.Drawing.Point(312, 285)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(103, 36)
        Me.butCancelar.TabIndex = 5
        Me.butCancelar.Text = "&Cancelar"
        Me.butCancelar.UseVisualStyleBackColor = True
        '
        'butAceptar
        '
        Me.butAceptar.Location = New System.Drawing.Point(16, 285)
        Me.butAceptar.Name = "butAceptar"
        Me.butAceptar.Size = New System.Drawing.Size(103, 36)
        Me.butAceptar.TabIndex = 4
        Me.butAceptar.Text = "&Aceptar"
        Me.butAceptar.UseVisualStyleBackColor = True
        '
        'CTConsolidacionEmpIni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 333)
        Me.Controls.Add(Me.butCancelar)
        Me.Controls.Add(Me.butAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CTConsolidacionEmpIni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consolidación de Empresas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radiobutConsolidacionImp As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutConsolidacionExp As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutConsolidacionComun As System.Windows.Forms.RadioButton
    Friend WithEvents butCancelar As System.Windows.Forms.Button
    Friend WithEvents butAceptar As System.Windows.Forms.Button
End Class
