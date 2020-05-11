<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLRepDeducciones
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
        Me.c1dateFecha = New C1.Win.C1Input.C1DateEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.grpDatosListar = New System.Windows.Forms.GroupBox
        Me.radiobutAmbos = New System.Windows.Forms.RadioButton
        Me.radiobutCargosPendientes = New System.Windows.Forms.RadioButton
        Me.radiobutCargosMes = New System.Windows.Forms.RadioButton
        Me.grpRangos = New System.Windows.Forms.GroupBox
        Me.chkListarTodo = New System.Windows.Forms.CheckBox
        Me.lblNombreRangoFinal = New System.Windows.Forms.Label
        Me.lblNombreRangoIni = New System.Windows.Forms.Label
        Me.c1txtRangoFinal = New C1.Win.C1Input.C1TextBox
        Me.c1txtRangoIni = New C1.Win.C1Input.C1TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.grpNoPlanilla = New System.Windows.Forms.GroupBox
        Me.lblDescPlanilla = New System.Windows.Forms.Label
        Me.c1numNoPlanilla = New C1.Win.C1Input.C1NumericEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnBuscarRangoFinal = New RSIContab.BotonBuscar
        Me.btnBuscarRangoIni = New RSIContab.BotonBuscar
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosListar.SuspendLayout()
        Me.grpRangos.SuspendLayout()
        CType(Me.c1txtRangoFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtRangoIni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNoPlanilla.SuspendLayout()
        CType(Me.c1numNoPlanilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.c1dateFecha.Location = New System.Drawing.Point(142, 12)
        Me.c1dateFecha.Name = "c1dateFecha"
        Me.c1dateFecha.Size = New System.Drawing.Size(105, 20)
        Me.c1dateFecha.TabIndex = 11
        Me.c1dateFecha.Tag = "CM"
        Me.c1dateFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Fecha del Reporte:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(11, 292)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(101, 32)
        Me.btnAceptar.TabIndex = 13
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(184, 292)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(101, 32)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'grpDatosListar
        '
        Me.grpDatosListar.Controls.Add(Me.radiobutAmbos)
        Me.grpDatosListar.Controls.Add(Me.radiobutCargosPendientes)
        Me.grpDatosListar.Controls.Add(Me.radiobutCargosMes)
        Me.grpDatosListar.Location = New System.Drawing.Point(12, 195)
        Me.grpDatosListar.Name = "grpDatosListar"
        Me.grpDatosListar.Size = New System.Drawing.Size(273, 74)
        Me.grpDatosListar.TabIndex = 31
        Me.grpDatosListar.TabStop = False
        Me.grpDatosListar.Text = "Datos a Listar"
        '
        'radiobutAmbos
        '
        Me.radiobutAmbos.AutoSize = True
        Me.radiobutAmbos.Location = New System.Drawing.Point(7, 65)
        Me.radiobutAmbos.Name = "radiobutAmbos"
        Me.radiobutAmbos.Size = New System.Drawing.Size(57, 17)
        Me.radiobutAmbos.TabIndex = 2
        Me.radiobutAmbos.Text = "Ambos"
        Me.radiobutAmbos.UseVisualStyleBackColor = True
        Me.radiobutAmbos.Visible = False
        '
        'radiobutCargosPendientes
        '
        Me.radiobutCargosPendientes.AutoSize = True
        Me.radiobutCargosPendientes.Location = New System.Drawing.Point(7, 44)
        Me.radiobutCargosPendientes.Name = "radiobutCargosPendientes"
        Me.radiobutCargosPendientes.Size = New System.Drawing.Size(138, 17)
        Me.radiobutCargosPendientes.TabIndex = 1
        Me.radiobutCargosPendientes.TabStop = True
        Me.radiobutCargosPendientes.Text = "Solo Cargos Pendientes"
        Me.radiobutCargosPendientes.UseVisualStyleBackColor = True
        '
        'radiobutCargosMes
        '
        Me.radiobutCargosMes.AutoSize = True
        Me.radiobutCargosMes.Checked = True
        Me.radiobutCargosMes.Location = New System.Drawing.Point(7, 20)
        Me.radiobutCargosMes.Name = "radiobutCargosMes"
        Me.radiobutCargosMes.Size = New System.Drawing.Size(144, 17)
        Me.radiobutCargosMes.TabIndex = 0
        Me.radiobutCargosMes.TabStop = True
        Me.radiobutCargosMes.Text = "Solo Cargos de Este Mes"
        Me.radiobutCargosMes.UseVisualStyleBackColor = True
        '
        'grpRangos
        '
        Me.grpRangos.Controls.Add(Me.chkListarTodo)
        Me.grpRangos.Controls.Add(Me.lblNombreRangoFinal)
        Me.grpRangos.Controls.Add(Me.lblNombreRangoIni)
        Me.grpRangos.Controls.Add(Me.btnBuscarRangoFinal)
        Me.grpRangos.Controls.Add(Me.c1txtRangoFinal)
        Me.grpRangos.Controls.Add(Me.btnBuscarRangoIni)
        Me.grpRangos.Controls.Add(Me.c1txtRangoIni)
        Me.grpRangos.Controls.Add(Me.Label3)
        Me.grpRangos.Controls.Add(Me.Label2)
        Me.grpRangos.Location = New System.Drawing.Point(13, 38)
        Me.grpRangos.Name = "grpRangos"
        Me.grpRangos.Size = New System.Drawing.Size(272, 151)
        Me.grpRangos.TabIndex = 32
        Me.grpRangos.TabStop = False
        Me.grpRangos.Text = "Rangos"
        '
        'chkListarTodo
        '
        Me.chkListarTodo.AutoSize = True
        Me.chkListarTodo.Location = New System.Drawing.Point(15, 128)
        Me.chkListarTodo.Name = "chkListarTodo"
        Me.chkListarTodo.Size = New System.Drawing.Size(79, 17)
        Me.chkListarTodo.TabIndex = 39
        Me.chkListarTodo.Text = "Listar Todo"
        Me.chkListarTodo.UseVisualStyleBackColor = True
        '
        'lblNombreRangoFinal
        '
        Me.lblNombreRangoFinal.AutoSize = True
        Me.lblNombreRangoFinal.Location = New System.Drawing.Point(90, 100)
        Me.lblNombreRangoFinal.Name = "lblNombreRangoFinal"
        Me.lblNombreRangoFinal.Size = New System.Drawing.Size(0, 13)
        Me.lblNombreRangoFinal.TabIndex = 38
        '
        'lblNombreRangoIni
        '
        Me.lblNombreRangoIni.AutoSize = True
        Me.lblNombreRangoIni.Location = New System.Drawing.Point(90, 46)
        Me.lblNombreRangoIni.Name = "lblNombreRangoIni"
        Me.lblNombreRangoIni.Size = New System.Drawing.Size(0, 13)
        Me.lblNombreRangoIni.TabIndex = 37
        '
        'c1txtRangoFinal
        '
        Me.c1txtRangoFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtRangoFinal.Location = New System.Drawing.Point(90, 73)
        Me.c1txtRangoFinal.Name = "c1txtRangoFinal"
        Me.c1txtRangoFinal.Size = New System.Drawing.Size(122, 20)
        Me.c1txtRangoFinal.TabIndex = 35
        Me.c1txtRangoFinal.Tag = Nothing
        '
        'c1txtRangoIni
        '
        Me.c1txtRangoIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtRangoIni.Location = New System.Drawing.Point(90, 19)
        Me.c1txtRangoIni.Name = "c1txtRangoIni"
        Me.c1txtRangoIni.Size = New System.Drawing.Size(122, 20)
        Me.c1txtRangoIni.TabIndex = 33
        Me.c1txtRangoIni.Tag = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Rango Final:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Rango Inicial:"
        '
        'grpNoPlanilla
        '
        Me.grpNoPlanilla.Controls.Add(Me.lblDescPlanilla)
        Me.grpNoPlanilla.Controls.Add(Me.c1numNoPlanilla)
        Me.grpNoPlanilla.Controls.Add(Me.Label4)
        Me.grpNoPlanilla.Location = New System.Drawing.Point(12, 154)
        Me.grpNoPlanilla.Name = "grpNoPlanilla"
        Me.grpNoPlanilla.Size = New System.Drawing.Size(273, 66)
        Me.grpNoPlanilla.TabIndex = 34
        Me.grpNoPlanilla.TabStop = False
        Me.grpNoPlanilla.Text = "Planilla"
        Me.grpNoPlanilla.Visible = False
        '
        'lblDescPlanilla
        '
        Me.lblDescPlanilla.AutoSize = True
        Me.lblDescPlanilla.Location = New System.Drawing.Point(12, 45)
        Me.lblDescPlanilla.Name = "lblDescPlanilla"
        Me.lblDescPlanilla.Size = New System.Drawing.Size(0, 13)
        Me.lblDescPlanilla.TabIndex = 9
        '
        'c1numNoPlanilla
        '
        Me.c1numNoPlanilla.AutoSize = False
        Me.c1numNoPlanilla.DataType = GetType(Short)
        Me.c1numNoPlanilla.Location = New System.Drawing.Point(90, 17)
        Me.c1numNoPlanilla.Name = "c1numNoPlanilla"
        Me.c1numNoPlanilla.Size = New System.Drawing.Size(23, 20)
        Me.c1numNoPlanilla.TabIndex = 8
        Me.c1numNoPlanilla.Tag = Nothing
        Me.c1numNoPlanilla.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "No. de Planilla:"
        '
        'btnBuscarRangoFinal
        '
        Me.btnBuscarRangoFinal.ControlEnlazado = Nothing
        Me.btnBuscarRangoFinal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarRangoFinal.Enabled = False
        Me.btnBuscarRangoFinal.Location = New System.Drawing.Point(212, 73)
        Me.btnBuscarRangoFinal.Name = "btnBuscarRangoFinal"
        Me.btnBuscarRangoFinal.Size = New System.Drawing.Size(23, 23)
        Me.btnBuscarRangoFinal.TabIndex = 36
        '
        'btnBuscarRangoIni
        '
        Me.btnBuscarRangoIni.ControlEnlazado = Nothing
        Me.btnBuscarRangoIni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarRangoIni.Enabled = False
        Me.btnBuscarRangoIni.Location = New System.Drawing.Point(212, 17)
        Me.btnBuscarRangoIni.Name = "btnBuscarRangoIni"
        Me.btnBuscarRangoIni.Size = New System.Drawing.Size(23, 23)
        Me.btnBuscarRangoIni.TabIndex = 34
        '
        'PLRepDeducciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 330)
        Me.Controls.Add(Me.grpNoPlanilla)
        Me.Controls.Add(Me.grpRangos)
        Me.Controls.Add(Me.grpDatosListar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.c1dateFecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PLRepDeducciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Cargos"
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosListar.ResumeLayout(False)
        Me.grpDatosListar.PerformLayout()
        Me.grpRangos.ResumeLayout(False)
        Me.grpRangos.PerformLayout()
        CType(Me.c1txtRangoFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtRangoIni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpNoPlanilla.ResumeLayout(False)
        Me.grpNoPlanilla.PerformLayout()
        CType(Me.c1numNoPlanilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents c1dateFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents grpDatosListar As System.Windows.Forms.GroupBox
    Friend WithEvents radiobutAmbos As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutCargosPendientes As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutCargosMes As System.Windows.Forms.RadioButton
    Friend WithEvents grpRangos As System.Windows.Forms.GroupBox
    Friend WithEvents chkListarTodo As System.Windows.Forms.CheckBox
    Friend WithEvents lblNombreRangoFinal As System.Windows.Forms.Label
    Friend WithEvents lblNombreRangoIni As System.Windows.Forms.Label
    Friend WithEvents btnBuscarRangoFinal As RSIContab.BotonBuscar
    Friend WithEvents c1txtRangoFinal As C1.Win.C1Input.C1TextBox
    Friend WithEvents btnBuscarRangoIni As RSIContab.BotonBuscar
    Friend WithEvents c1txtRangoIni As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpNoPlanilla As System.Windows.Forms.GroupBox
    Friend WithEvents lblDescPlanilla As System.Windows.Forms.Label
    Friend WithEvents c1numNoPlanilla As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
