<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTInicializacionPresupuestoFrm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radiobutEgresos = New System.Windows.Forms.RadioButton()
        Me.radiobutIngresos = New System.Windows.Forms.RadioButton()
        Me.radiobutAmbos = New System.Windows.Forms.RadioButton()
        Me.chkboxAgregarCtasNuevas = New System.Windows.Forms.CheckBox()
        Me.chkboxInicializarTabla = New System.Windows.Forms.CheckBox()
        Me.butCancelar = New System.Windows.Forms.Button()
        Me.butAceptar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAño = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(27, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Este proceso inicializará la tabla de presupuesto de Ingresos y Egresos."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radiobutEgresos)
        Me.GroupBox1.Controls.Add(Me.radiobutIngresos)
        Me.GroupBox1.Controls.Add(Me.radiobutAmbos)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 101)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inicializar"
        '
        'radiobutEgresos
        '
        Me.radiobutEgresos.AutoSize = True
        Me.radiobutEgresos.Location = New System.Drawing.Point(7, 66)
        Me.radiobutEgresos.Name = "radiobutEgresos"
        Me.radiobutEgresos.Size = New System.Drawing.Size(140, 17)
        Me.radiobutEgresos.TabIndex = 2
        Me.radiobutEgresos.Text = "Presupuesto de Egresos"
        Me.radiobutEgresos.UseVisualStyleBackColor = True
        '
        'radiobutIngresos
        '
        Me.radiobutIngresos.AutoSize = True
        Me.radiobutIngresos.Location = New System.Drawing.Point(7, 43)
        Me.radiobutIngresos.Name = "radiobutIngresos"
        Me.radiobutIngresos.Size = New System.Drawing.Size(142, 17)
        Me.radiobutIngresos.TabIndex = 1
        Me.radiobutIngresos.Text = "Presupuesto de Ingresos"
        Me.radiobutIngresos.UseVisualStyleBackColor = True
        '
        'radiobutAmbos
        '
        Me.radiobutAmbos.AutoSize = True
        Me.radiobutAmbos.Checked = True
        Me.radiobutAmbos.Location = New System.Drawing.Point(7, 20)
        Me.radiobutAmbos.Name = "radiobutAmbos"
        Me.radiobutAmbos.Size = New System.Drawing.Size(57, 17)
        Me.radiobutAmbos.TabIndex = 0
        Me.radiobutAmbos.TabStop = True
        Me.radiobutAmbos.Text = "Ambos"
        Me.radiobutAmbos.UseVisualStyleBackColor = True
        '
        'chkboxAgregarCtasNuevas
        '
        Me.chkboxAgregarCtasNuevas.Location = New System.Drawing.Point(30, 182)
        Me.chkboxAgregarCtasNuevas.Name = "chkboxAgregarCtasNuevas"
        Me.chkboxAgregarCtasNuevas.Size = New System.Drawing.Size(264, 38)
        Me.chkboxAgregarCtasNuevas.TabIndex = 2
        Me.chkboxAgregarCtasNuevas.Text = "Solamente Agrega Cuentas Nuevas del Tipo de Presupuesto Seleccionado"
        Me.chkboxAgregarCtasNuevas.UseVisualStyleBackColor = True
        Me.chkboxAgregarCtasNuevas.Visible = False
        '
        'chkboxInicializarTabla
        '
        Me.chkboxInicializarTabla.Location = New System.Drawing.Point(30, 215)
        Me.chkboxInicializarTabla.Name = "chkboxInicializarTabla"
        Me.chkboxInicializarTabla.Size = New System.Drawing.Size(264, 38)
        Me.chkboxInicializarTabla.TabIndex = 3
        Me.chkboxInicializarTabla.Text = "Inicializar Tabla de Presupuesto"
        Me.chkboxInicializarTabla.UseVisualStyleBackColor = True
        '
        'butCancelar
        '
        Me.butCancelar.Image = Global.RSIContab.My.Resources.Resources._1393662113_cancel
        Me.butCancelar.Location = New System.Drawing.Point(187, 270)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(107, 33)
        Me.butCancelar.TabIndex = 68
        Me.butCancelar.Text = "&Cancelar"
        Me.butCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butCancelar.UseVisualStyleBackColor = True
        '
        'butAceptar
        '
        Me.butAceptar.Image = Global.RSIContab.My.Resources.Resources._1393538844_tick_16
        Me.butAceptar.Location = New System.Drawing.Point(15, 270)
        Me.butAceptar.Name = "butAceptar"
        Me.butAceptar.Size = New System.Drawing.Size(107, 33)
        Me.butAceptar.TabIndex = 67
        Me.butAceptar.Text = "&Aceptar"
        Me.butAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butAceptar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Año:"
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.Location = New System.Drawing.Point(66, 43)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(39, 13)
        Me.lblAño.TabIndex = 70
        Me.lblAño.Text = "Label3"
        '
        'CTInicializacionPresupuestoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 315)
        Me.Controls.Add(Me.lblAño)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.butCancelar)
        Me.Controls.Add(Me.butAceptar)
        Me.Controls.Add(Me.chkboxInicializarTabla)
        Me.Controls.Add(Me.chkboxAgregarCtasNuevas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CTInicializacionPresupuestoFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicialización de Presupuesto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radiobutEgresos As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutIngresos As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutAmbos As System.Windows.Forms.RadioButton
    Friend WithEvents chkboxAgregarCtasNuevas As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxInicializarTabla As System.Windows.Forms.CheckBox
    Friend WithEvents butCancelar As System.Windows.Forms.Button
    Friend WithEvents butAceptar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAño As System.Windows.Forms.Label
End Class
