<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTSaldosCuentasAnualesFrm
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
        Me.grpboxSaldos = New System.Windows.Forms.GroupBox()
        Me.radiobutTodas = New System.Windows.Forms.RadioButton()
        Me.radiobutCtasGastos = New System.Windows.Forms.RadioButton()
        Me.radiobutCtasIngresos = New System.Windows.Forms.RadioButton()
        Me.butCancelar = New System.Windows.Forms.Button()
        Me.butAceptar = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.grpboxPeriodo = New System.Windows.Forms.GroupBox()
        Me.c1numAño = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMesTrim = New System.Windows.Forms.Label()
        Me.cmbMesesTrim = New System.Windows.Forms.ComboBox()
        Me.grpboxSaldos.SuspendLayout()
        Me.grpboxPeriodo.SuspendLayout()
        CType(Me.c1numAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpboxSaldos
        '
        Me.grpboxSaldos.Controls.Add(Me.radiobutTodas)
        Me.grpboxSaldos.Controls.Add(Me.radiobutCtasGastos)
        Me.grpboxSaldos.Controls.Add(Me.radiobutCtasIngresos)
        Me.grpboxSaldos.Location = New System.Drawing.Point(13, 13)
        Me.grpboxSaldos.Name = "grpboxSaldos"
        Me.grpboxSaldos.Size = New System.Drawing.Size(263, 94)
        Me.grpboxSaldos.TabIndex = 0
        Me.grpboxSaldos.TabStop = False
        Me.grpboxSaldos.Text = "Seleccionar"
        '
        'radiobutTodas
        '
        Me.radiobutTodas.AutoSize = True
        Me.radiobutTodas.Checked = True
        Me.radiobutTodas.Location = New System.Drawing.Point(6, 66)
        Me.radiobutTodas.Name = "radiobutTodas"
        Me.radiobutTodas.Size = New System.Drawing.Size(55, 17)
        Me.radiobutTodas.TabIndex = 2
        Me.radiobutTodas.TabStop = True
        Me.radiobutTodas.Text = "Todas"
        Me.radiobutTodas.UseVisualStyleBackColor = True
        '
        'radiobutCtasGastos
        '
        Me.radiobutCtasGastos.AutoSize = True
        Me.radiobutCtasGastos.Location = New System.Drawing.Point(7, 43)
        Me.radiobutCtasGastos.Name = "radiobutCtasGastos"
        Me.radiobutCtasGastos.Size = New System.Drawing.Size(115, 17)
        Me.radiobutCtasGastos.TabIndex = 1
        Me.radiobutCtasGastos.Text = "Cuentas de Gastos"
        Me.radiobutCtasGastos.UseVisualStyleBackColor = True
        '
        'radiobutCtasIngresos
        '
        Me.radiobutCtasIngresos.AutoSize = True
        Me.radiobutCtasIngresos.Location = New System.Drawing.Point(7, 20)
        Me.radiobutCtasIngresos.Name = "radiobutCtasIngresos"
        Me.radiobutCtasIngresos.Size = New System.Drawing.Size(122, 17)
        Me.radiobutCtasIngresos.TabIndex = 0
        Me.radiobutCtasIngresos.Text = "Cuentas de Ingresos"
        Me.radiobutCtasIngresos.UseVisualStyleBackColor = True
        '
        'butCancelar
        '
        Me.butCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.butCancelar.Image = Global.RSIContab.My.Resources.Resources._1393662113_cancel
        Me.butCancelar.Location = New System.Drawing.Point(168, 207)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(107, 33)
        Me.butCancelar.TabIndex = 61
        Me.butCancelar.Text = "&Cancelar"
        Me.butCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butCancelar.UseVisualStyleBackColor = True
        '
        'butAceptar
        '
        Me.butAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.butAceptar.Image = Global.RSIContab.My.Resources.Resources._1393538844_tick_16
        Me.butAceptar.Location = New System.Drawing.Point(13, 207)
        Me.butAceptar.Name = "butAceptar"
        Me.butAceptar.Size = New System.Drawing.Size(107, 33)
        Me.butAceptar.TabIndex = 60
        Me.butAceptar.Text = "&Aceptar"
        Me.butAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butAceptar.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(109, 175)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(86, 13)
        Me.lblMensaje.TabIndex = 64
        Me.lblMensaje.Text = "Procesando..."
        Me.lblMensaje.Visible = False
        '
        'grpboxPeriodo
        '
        Me.grpboxPeriodo.Controls.Add(Me.cmbMesesTrim)
        Me.grpboxPeriodo.Controls.Add(Me.lblMesTrim)
        Me.grpboxPeriodo.Controls.Add(Me.c1numAño)
        Me.grpboxPeriodo.Controls.Add(Me.Label1)
        Me.grpboxPeriodo.Location = New System.Drawing.Point(13, 113)
        Me.grpboxPeriodo.Name = "grpboxPeriodo"
        Me.grpboxPeriodo.Size = New System.Drawing.Size(263, 47)
        Me.grpboxPeriodo.TabIndex = 65
        Me.grpboxPeriodo.TabStop = False
        Me.grpboxPeriodo.Text = "Período"
        '
        'c1numAño
        '
        Me.c1numAño.DataType = GetType(Short)
        Me.c1numAño.Location = New System.Drawing.Point(72, 16)
        Me.c1numAño.Name = "c1numAño"
        Me.c1numAño.Size = New System.Drawing.Size(50, 20)
        Me.c1numAño.TabIndex = 65
        Me.c1numAño.Tag = Nothing
        Me.c1numAño.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Elija el Año:"
        '
        'lblMesTrim
        '
        Me.lblMesTrim.AutoSize = True
        Me.lblMesTrim.Location = New System.Drawing.Point(128, 16)
        Me.lblMesTrim.Name = "lblMesTrim"
        Me.lblMesTrim.Size = New System.Drawing.Size(30, 13)
        Me.lblMesTrim.TabIndex = 66
        Me.lblMesTrim.Text = "Mes:"
        '
        'cmbMesesTrim
        '
        Me.cmbMesesTrim.FormattingEnabled = True
        Me.cmbMesesTrim.Location = New System.Drawing.Point(164, 13)
        Me.cmbMesesTrim.Name = "cmbMesesTrim"
        Me.cmbMesesTrim.Size = New System.Drawing.Size(93, 21)
        Me.cmbMesesTrim.TabIndex = 67
        '
        'CTSaldosCuentasAnualesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 254)
        Me.Controls.Add(Me.grpboxPeriodo)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.butCancelar)
        Me.Controls.Add(Me.butAceptar)
        Me.Controls.Add(Me.grpboxSaldos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CTSaldosCuentasAnualesFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saldos Anuales de Cuentas"
        Me.grpboxSaldos.ResumeLayout(False)
        Me.grpboxSaldos.PerformLayout()
        Me.grpboxPeriodo.ResumeLayout(False)
        Me.grpboxPeriodo.PerformLayout()
        CType(Me.c1numAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpboxSaldos As System.Windows.Forms.GroupBox
    Friend WithEvents radiobutTodas As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutCtasGastos As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutCtasIngresos As System.Windows.Forms.RadioButton
    Friend WithEvents butCancelar As System.Windows.Forms.Button
    Friend WithEvents butAceptar As System.Windows.Forms.Button
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents grpboxPeriodo As System.Windows.Forms.GroupBox
    Friend WithEvents cmbMesesTrim As System.Windows.Forms.ComboBox
    Friend WithEvents lblMesTrim As System.Windows.Forms.Label
    Friend WithEvents c1numAño As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
