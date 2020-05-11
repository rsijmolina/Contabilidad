<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLRepSaldosEmpleadosFrm
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.c1dateFecha = New C1.Win.C1Input.C1DateEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.radiobutDeduccion = New System.Windows.Forms.RadioButton
        Me.radiobutEmpleado = New System.Windows.Forms.RadioButton
        Me.chkListarTodo = New System.Windows.Forms.CheckBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.c1txtRangoIni = New C1.Win.C1Input.C1TextBox
        Me.c1txtRangoFin = New C1.Win.C1Input.C1TextBox
        Me.lblNombreIni = New System.Windows.Forms.Label
        Me.lblNombreFin = New System.Windows.Forms.Label
        Me.chkListarDedPermanentes = New System.Windows.Forms.CheckBox
        Me.btnBuscarRangoFin = New RSIContab.BotonBuscar
        Me.btnBuscarRangoIni = New RSIContab.BotonBuscar
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1txtRangoIni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtRangoFin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Fecha del Reporte:"
        '
        'c1dateFecha
        '
        Me.c1dateFecha.DateTimeInput = False
        Me.c1dateFecha.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.c1dateFecha.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1dateFecha.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.c1dateFecha.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1dateFecha.Location = New System.Drawing.Point(147, 12)
        Me.c1dateFecha.Name = "c1dateFecha"
        Me.c1dateFecha.Size = New System.Drawing.Size(105, 20)
        Me.c1dateFecha.TabIndex = 15
        Me.c1dateFecha.Tag = "CM"
        Me.c1dateFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radiobutDeduccion)
        Me.GroupBox1.Controls.Add(Me.radiobutEmpleado)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 41)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listar por"
        '
        'radiobutDeduccion
        '
        Me.radiobutDeduccion.AutoSize = True
        Me.radiobutDeduccion.Location = New System.Drawing.Point(95, 18)
        Me.radiobutDeduccion.Name = "radiobutDeduccion"
        Me.radiobutDeduccion.Size = New System.Drawing.Size(77, 17)
        Me.radiobutDeduccion.TabIndex = 1
        Me.radiobutDeduccion.Text = "Deducción"
        Me.radiobutDeduccion.UseVisualStyleBackColor = True
        '
        'radiobutEmpleado
        '
        Me.radiobutEmpleado.AutoSize = True
        Me.radiobutEmpleado.Checked = True
        Me.radiobutEmpleado.Location = New System.Drawing.Point(7, 18)
        Me.radiobutEmpleado.Name = "radiobutEmpleado"
        Me.radiobutEmpleado.Size = New System.Drawing.Size(72, 17)
        Me.radiobutEmpleado.TabIndex = 0
        Me.radiobutEmpleado.TabStop = True
        Me.radiobutEmpleado.Text = "Empleado"
        Me.radiobutEmpleado.UseVisualStyleBackColor = True
        '
        'chkListarTodo
        '
        Me.chkListarTodo.AutoSize = True
        Me.chkListarTodo.Location = New System.Drawing.Point(13, 193)
        Me.chkListarTodo.Name = "chkListarTodo"
        Me.chkListarTodo.Size = New System.Drawing.Size(79, 17)
        Me.chkListarTodo.TabIndex = 30
        Me.chkListarTodo.Text = "Listar Todo"
        Me.chkListarTodo.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(185, 216)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(101, 32)
        Me.btnCancelar.TabIndex = 29
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(13, 216)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(101, 32)
        Me.btnAceptar.TabIndex = 28
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Rango Inicial:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Rango Final:"
        '
        'c1txtRangoIni
        '
        Me.c1txtRangoIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtRangoIni.Location = New System.Drawing.Point(81, 107)
        Me.c1txtRangoIni.Name = "c1txtRangoIni"
        Me.c1txtRangoIni.Size = New System.Drawing.Size(122, 20)
        Me.c1txtRangoIni.TabIndex = 33
        Me.c1txtRangoIni.Tag = Nothing
        '
        'c1txtRangoFin
        '
        Me.c1txtRangoFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtRangoFin.Location = New System.Drawing.Point(81, 150)
        Me.c1txtRangoFin.Name = "c1txtRangoFin"
        Me.c1txtRangoFin.Size = New System.Drawing.Size(122, 20)
        Me.c1txtRangoFin.TabIndex = 35
        Me.c1txtRangoFin.Tag = Nothing
        '
        'lblNombreIni
        '
        Me.lblNombreIni.AutoSize = True
        Me.lblNombreIni.Location = New System.Drawing.Point(81, 134)
        Me.lblNombreIni.Name = "lblNombreIni"
        Me.lblNombreIni.Size = New System.Drawing.Size(0, 13)
        Me.lblNombreIni.TabIndex = 37
        '
        'lblNombreFin
        '
        Me.lblNombreFin.AutoSize = True
        Me.lblNombreFin.Location = New System.Drawing.Point(81, 177)
        Me.lblNombreFin.Name = "lblNombreFin"
        Me.lblNombreFin.Size = New System.Drawing.Size(0, 13)
        Me.lblNombreFin.TabIndex = 38
        '
        'chkListarDedPermanentes
        '
        Me.chkListarDedPermanentes.AutoSize = True
        Me.chkListarDedPermanentes.Location = New System.Drawing.Point(98, 193)
        Me.chkListarDedPermanentes.Name = "chkListarDedPermanentes"
        Me.chkListarDedPermanentes.Size = New System.Drawing.Size(182, 17)
        Me.chkListarDedPermanentes.TabIndex = 39
        Me.chkListarDedPermanentes.Text = "Listar Deducciones Permanentes"
        Me.chkListarDedPermanentes.UseVisualStyleBackColor = True
        '
        'btnBuscarRangoFin
        '
        Me.btnBuscarRangoFin.ControlEnlazado = Nothing
        Me.btnBuscarRangoFin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarRangoFin.Enabled = False
        Me.btnBuscarRangoFin.Location = New System.Drawing.Point(203, 148)
        Me.btnBuscarRangoFin.Name = "btnBuscarRangoFin"
        Me.btnBuscarRangoFin.Size = New System.Drawing.Size(23, 23)
        Me.btnBuscarRangoFin.TabIndex = 36
        '
        'btnBuscarRangoIni
        '
        Me.btnBuscarRangoIni.ControlEnlazado = Nothing
        Me.btnBuscarRangoIni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarRangoIni.Enabled = False
        Me.btnBuscarRangoIni.Location = New System.Drawing.Point(203, 105)
        Me.btnBuscarRangoIni.Name = "btnBuscarRangoIni"
        Me.btnBuscarRangoIni.Size = New System.Drawing.Size(23, 23)
        Me.btnBuscarRangoIni.TabIndex = 34
        '
        'PLRepSaldosEmpleadosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 255)
        Me.Controls.Add(Me.chkListarDedPermanentes)
        Me.Controls.Add(Me.lblNombreFin)
        Me.Controls.Add(Me.lblNombreIni)
        Me.Controls.Add(Me.btnBuscarRangoFin)
        Me.Controls.Add(Me.c1txtRangoFin)
        Me.Controls.Add(Me.btnBuscarRangoIni)
        Me.Controls.Add(Me.c1txtRangoIni)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkListarTodo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.c1dateFecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PLRepSaldosEmpleadosFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Saldos de Empleados"
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1txtRangoIni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtRangoFin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents c1dateFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radiobutDeduccion As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutEmpleado As System.Windows.Forms.RadioButton
    Friend WithEvents chkListarTodo As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarRangoIni As RSIContab.BotonBuscar
    Friend WithEvents c1txtRangoIni As C1.Win.C1Input.C1TextBox
    Friend WithEvents btnBuscarRangoFin As RSIContab.BotonBuscar
    Friend WithEvents c1txtRangoFin As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblNombreIni As System.Windows.Forms.Label
    Friend WithEvents lblNombreFin As System.Windows.Forms.Label
    Friend WithEvents chkListarDedPermanentes As System.Windows.Forms.CheckBox
End Class
