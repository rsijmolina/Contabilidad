<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLRepEmpSelFrm
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
        Me.radiobutFechaIngreso = New System.Windows.Forms.RadioButton
        Me.RadioButton7 = New System.Windows.Forms.RadioButton
        Me.radiobutEmpCancelados = New System.Windows.Forms.RadioButton
        Me.radiobutEmpVacaciones = New System.Windows.Forms.RadioButton
        Me.radiobutTipoPlaza = New System.Windows.Forms.RadioButton
        Me.radiobutCargoSalario = New System.Windows.Forms.RadioButton
        Me.radiobutOficina = New System.Windows.Forms.RadioButton
        Me.radiobutCargo = New System.Windows.Forms.RadioButton
        Me.grpGenero = New System.Windows.Forms.GroupBox
        Me.radiobutFemenino = New System.Windows.Forms.RadioButton
        Me.radiobutMasculino = New System.Windows.Forms.RadioButton
        Me.radiobutAmbosGeneros = New System.Windows.Forms.RadioButton
        Me.grpID = New System.Windows.Forms.GroupBox
        Me.radiobutIdentidad = New System.Windows.Forms.RadioButton
        Me.radiobutCodigo = New System.Windows.Forms.RadioButton
        Me.grpVacaciones = New System.Windows.Forms.GroupBox
        Me.grpRangos = New System.Windows.Forms.GroupBox
        Me.cmbSignos = New System.Windows.Forms.ComboBox
        Me.c1numSueldoMensual = New C1.Win.C1Input.C1NumericEdit
        Me.chkboxListarTodos = New System.Windows.Forms.CheckBox
        Me.lblSueldo = New System.Windows.Forms.Label
        Me.lblNombreFin = New System.Windows.Forms.Label
        Me.lblNombreIni = New System.Windows.Forms.Label
        Me.btnBuscarRangoFin = New RSIContab.BotonBuscar
        Me.c1txtRangoFin = New C1.Win.C1Input.C1TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnBuscarRangoIni = New RSIContab.BotonBuscar
        Me.c1txtRangoIni = New C1.Win.C1Input.C1TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbMeses = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grpGenero.SuspendLayout()
        Me.grpID.SuspendLayout()
        Me.grpVacaciones.SuspendLayout()
        Me.grpRangos.SuspendLayout()
        CType(Me.c1numSueldoMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtRangoFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtRangoIni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 15)
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
        Me.c1dateFecha.Location = New System.Drawing.Point(132, 12)
        Me.c1dateFecha.Name = "c1dateFecha"
        Me.c1dateFecha.Size = New System.Drawing.Size(105, 20)
        Me.c1dateFecha.TabIndex = 15
        Me.c1dateFecha.Tag = "CM"
        Me.c1dateFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radiobutFechaIngreso)
        Me.GroupBox1.Controls.Add(Me.RadioButton7)
        Me.GroupBox1.Controls.Add(Me.radiobutEmpCancelados)
        Me.GroupBox1.Controls.Add(Me.radiobutEmpVacaciones)
        Me.GroupBox1.Controls.Add(Me.radiobutTipoPlaza)
        Me.GroupBox1.Controls.Add(Me.radiobutCargoSalario)
        Me.GroupBox1.Controls.Add(Me.radiobutOficina)
        Me.GroupBox1.Controls.Add(Me.radiobutCargo)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(159, 204)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listar por"
        '
        'radiobutFechaIngreso
        '
        Me.radiobutFechaIngreso.AutoSize = True
        Me.radiobutFechaIngreso.Location = New System.Drawing.Point(7, 181)
        Me.radiobutFechaIngreso.Name = "radiobutFechaIngreso"
        Me.radiobutFechaIngreso.Size = New System.Drawing.Size(108, 17)
        Me.radiobutFechaIngreso.TabIndex = 7
        Me.radiobutFechaIngreso.Text = "Fecha de Ingreso"
        Me.radiobutFechaIngreso.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(7, 158)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(114, 17)
        Me.RadioButton7.TabIndex = 6
        Me.RadioButton7.Text = "Emp. Con Licencia"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'radiobutEmpCancelados
        '
        Me.radiobutEmpCancelados.AutoSize = True
        Me.radiobutEmpCancelados.Location = New System.Drawing.Point(7, 135)
        Me.radiobutEmpCancelados.Name = "radiobutEmpCancelados"
        Me.radiobutEmpCancelados.Size = New System.Drawing.Size(108, 17)
        Me.radiobutEmpCancelados.TabIndex = 5
        Me.radiobutEmpCancelados.Text = "Emp. Cancelados"
        Me.radiobutEmpCancelados.UseVisualStyleBackColor = True
        '
        'radiobutEmpVacaciones
        '
        Me.radiobutEmpVacaciones.AutoSize = True
        Me.radiobutEmpVacaciones.Location = New System.Drawing.Point(7, 112)
        Me.radiobutEmpVacaciones.Name = "radiobutEmpVacaciones"
        Me.radiobutEmpVacaciones.Size = New System.Drawing.Size(133, 17)
        Me.radiobutEmpVacaciones.TabIndex = 4
        Me.radiobutEmpVacaciones.Text = "Emp. Para Vacaciones"
        Me.radiobutEmpVacaciones.UseVisualStyleBackColor = True
        '
        'radiobutTipoPlaza
        '
        Me.radiobutTipoPlaza.AutoSize = True
        Me.radiobutTipoPlaza.Location = New System.Drawing.Point(6, 89)
        Me.radiobutTipoPlaza.Name = "radiobutTipoPlaza"
        Me.radiobutTipoPlaza.Size = New System.Drawing.Size(90, 17)
        Me.radiobutTipoPlaza.TabIndex = 3
        Me.radiobutTipoPlaza.Text = "Tipo de Plaza"
        Me.radiobutTipoPlaza.UseVisualStyleBackColor = True
        '
        'radiobutCargoSalario
        '
        Me.radiobutCargoSalario.AutoSize = True
        Me.radiobutCargoSalario.Location = New System.Drawing.Point(7, 66)
        Me.radiobutCargoSalario.Name = "radiobutCargoSalario"
        Me.radiobutCargoSalario.Size = New System.Drawing.Size(96, 17)
        Me.radiobutCargoSalario.TabIndex = 2
        Me.radiobutCargoSalario.Text = "Cargo y Salario"
        Me.radiobutCargoSalario.UseVisualStyleBackColor = True
        '
        'radiobutOficina
        '
        Me.radiobutOficina.AutoSize = True
        Me.radiobutOficina.Location = New System.Drawing.Point(6, 43)
        Me.radiobutOficina.Name = "radiobutOficina"
        Me.radiobutOficina.Size = New System.Drawing.Size(58, 17)
        Me.radiobutOficina.TabIndex = 1
        Me.radiobutOficina.Text = "Oficina"
        Me.radiobutOficina.UseVisualStyleBackColor = True
        '
        'radiobutCargo
        '
        Me.radiobutCargo.AutoSize = True
        Me.radiobutCargo.Checked = True
        Me.radiobutCargo.Location = New System.Drawing.Point(7, 20)
        Me.radiobutCargo.Name = "radiobutCargo"
        Me.radiobutCargo.Size = New System.Drawing.Size(53, 17)
        Me.radiobutCargo.TabIndex = 0
        Me.radiobutCargo.TabStop = True
        Me.radiobutCargo.Text = "Cargo"
        Me.radiobutCargo.UseVisualStyleBackColor = True
        '
        'grpGenero
        '
        Me.grpGenero.Controls.Add(Me.radiobutFemenino)
        Me.grpGenero.Controls.Add(Me.radiobutMasculino)
        Me.grpGenero.Controls.Add(Me.radiobutAmbosGeneros)
        Me.grpGenero.Location = New System.Drawing.Point(174, 41)
        Me.grpGenero.Name = "grpGenero"
        Me.grpGenero.Size = New System.Drawing.Size(103, 98)
        Me.grpGenero.TabIndex = 18
        Me.grpGenero.TabStop = False
        Me.grpGenero.Text = "Género"
        '
        'radiobutFemenino
        '
        Me.radiobutFemenino.AutoSize = True
        Me.radiobutFemenino.Location = New System.Drawing.Point(6, 66)
        Me.radiobutFemenino.Name = "radiobutFemenino"
        Me.radiobutFemenino.Size = New System.Drawing.Size(71, 17)
        Me.radiobutFemenino.TabIndex = 3
        Me.radiobutFemenino.Text = "Femenino"
        Me.radiobutFemenino.UseVisualStyleBackColor = True
        '
        'radiobutMasculino
        '
        Me.radiobutMasculino.AutoSize = True
        Me.radiobutMasculino.Location = New System.Drawing.Point(6, 43)
        Me.radiobutMasculino.Name = "radiobutMasculino"
        Me.radiobutMasculino.Size = New System.Drawing.Size(73, 17)
        Me.radiobutMasculino.TabIndex = 2
        Me.radiobutMasculino.Text = "Masculino"
        Me.radiobutMasculino.UseVisualStyleBackColor = True
        '
        'radiobutAmbosGeneros
        '
        Me.radiobutAmbosGeneros.AutoSize = True
        Me.radiobutAmbosGeneros.Checked = True
        Me.radiobutAmbosGeneros.Location = New System.Drawing.Point(6, 20)
        Me.radiobutAmbosGeneros.Name = "radiobutAmbosGeneros"
        Me.radiobutAmbosGeneros.Size = New System.Drawing.Size(57, 17)
        Me.radiobutAmbosGeneros.TabIndex = 1
        Me.radiobutAmbosGeneros.TabStop = True
        Me.radiobutAmbosGeneros.Text = "Ambos"
        Me.radiobutAmbosGeneros.UseVisualStyleBackColor = True
        '
        'grpID
        '
        Me.grpID.Controls.Add(Me.radiobutIdentidad)
        Me.grpID.Controls.Add(Me.radiobutCodigo)
        Me.grpID.Location = New System.Drawing.Point(174, 145)
        Me.grpID.Name = "grpID"
        Me.grpID.Size = New System.Drawing.Size(103, 100)
        Me.grpID.TabIndex = 19
        Me.grpID.TabStop = False
        Me.grpID.Text = "Imprimir"
        '
        'radiobutIdentidad
        '
        Me.radiobutIdentidad.AutoSize = True
        Me.radiobutIdentidad.Location = New System.Drawing.Point(6, 42)
        Me.radiobutIdentidad.Name = "radiobutIdentidad"
        Me.radiobutIdentidad.Size = New System.Drawing.Size(69, 17)
        Me.radiobutIdentidad.TabIndex = 2
        Me.radiobutIdentidad.Text = "Identidad"
        Me.radiobutIdentidad.UseVisualStyleBackColor = True
        '
        'radiobutCodigo
        '
        Me.radiobutCodigo.AutoSize = True
        Me.radiobutCodigo.Checked = True
        Me.radiobutCodigo.Location = New System.Drawing.Point(7, 19)
        Me.radiobutCodigo.Name = "radiobutCodigo"
        Me.radiobutCodigo.Size = New System.Drawing.Size(58, 17)
        Me.radiobutCodigo.TabIndex = 1
        Me.radiobutCodigo.TabStop = True
        Me.radiobutCodigo.Text = "Código"
        Me.radiobutCodigo.UseVisualStyleBackColor = True
        '
        'grpVacaciones
        '
        Me.grpVacaciones.Controls.Add(Me.cmbMeses)
        Me.grpVacaciones.Controls.Add(Me.Label2)
        Me.grpVacaciones.Location = New System.Drawing.Point(283, 43)
        Me.grpVacaciones.Name = "grpVacaciones"
        Me.grpVacaciones.Size = New System.Drawing.Size(231, 96)
        Me.grpVacaciones.TabIndex = 20
        Me.grpVacaciones.TabStop = False
        Me.grpVacaciones.Visible = False
        '
        'grpRangos
        '
        Me.grpRangos.Controls.Add(Me.cmbSignos)
        Me.grpRangos.Controls.Add(Me.c1numSueldoMensual)
        Me.grpRangos.Controls.Add(Me.chkboxListarTodos)
        Me.grpRangos.Controls.Add(Me.lblSueldo)
        Me.grpRangos.Controls.Add(Me.lblNombreFin)
        Me.grpRangos.Controls.Add(Me.lblNombreIni)
        Me.grpRangos.Controls.Add(Me.btnBuscarRangoFin)
        Me.grpRangos.Controls.Add(Me.c1txtRangoFin)
        Me.grpRangos.Controls.Add(Me.Label4)
        Me.grpRangos.Controls.Add(Me.btnBuscarRangoIni)
        Me.grpRangos.Controls.Add(Me.c1txtRangoIni)
        Me.grpRangos.Controls.Add(Me.Label3)
        Me.grpRangos.Location = New System.Drawing.Point(283, 41)
        Me.grpRangos.Name = "grpRangos"
        Me.grpRangos.Size = New System.Drawing.Size(231, 167)
        Me.grpRangos.TabIndex = 23
        Me.grpRangos.TabStop = False
        Me.grpRangos.Text = "Rangos"
        Me.grpRangos.Visible = False
        '
        'cmbSignos
        '
        Me.cmbSignos.FormattingEnabled = True
        Me.cmbSignos.Items.AddRange(New Object() {"=", ">", "<", ">=", "<="})
        Me.cmbSignos.Location = New System.Drawing.Point(74, 111)
        Me.cmbSignos.Name = "cmbSignos"
        Me.cmbSignos.Size = New System.Drawing.Size(39, 21)
        Me.cmbSignos.TabIndex = 46
        Me.cmbSignos.Text = "="
        Me.cmbSignos.Visible = False
        '
        'c1numSueldoMensual
        '
        Me.c1numSueldoMensual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numSueldoMensual.Location = New System.Drawing.Point(128, 111)
        Me.c1numSueldoMensual.Name = "c1numSueldoMensual"
        Me.c1numSueldoMensual.Size = New System.Drawing.Size(88, 20)
        Me.c1numSueldoMensual.TabIndex = 45
        Me.c1numSueldoMensual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSueldoMensual.Visible = False
        Me.c1numSueldoMensual.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'chkboxListarTodos
        '
        Me.chkboxListarTodos.AutoSize = True
        Me.chkboxListarTodos.Location = New System.Drawing.Point(12, 144)
        Me.chkboxListarTodos.Name = "chkboxListarTodos"
        Me.chkboxListarTodos.Size = New System.Drawing.Size(84, 17)
        Me.chkboxListarTodos.TabIndex = 44
        Me.chkboxListarTodos.Text = "Listar Todos"
        Me.chkboxListarTodos.UseVisualStyleBackColor = True
        '
        'lblSueldo
        '
        Me.lblSueldo.AutoSize = True
        Me.lblSueldo.Location = New System.Drawing.Point(7, 114)
        Me.lblSueldo.Name = "lblSueldo"
        Me.lblSueldo.Size = New System.Drawing.Size(43, 13)
        Me.lblSueldo.TabIndex = 43
        Me.lblSueldo.Text = "Sueldo:"
        Me.lblSueldo.Visible = False
        '
        'lblNombreFin
        '
        Me.lblNombreFin.AutoSize = True
        Me.lblNombreFin.Location = New System.Drawing.Point(9, 97)
        Me.lblNombreFin.Name = "lblNombreFin"
        Me.lblNombreFin.Size = New System.Drawing.Size(0, 13)
        Me.lblNombreFin.TabIndex = 42
        '
        'lblNombreIni
        '
        Me.lblNombreIni.AutoSize = True
        Me.lblNombreIni.Location = New System.Drawing.Point(7, 44)
        Me.lblNombreIni.Name = "lblNombreIni"
        Me.lblNombreIni.Size = New System.Drawing.Size(0, 13)
        Me.lblNombreIni.TabIndex = 41
        '
        'btnBuscarRangoFin
        '
        Me.btnBuscarRangoFin.ControlEnlazado = Nothing
        Me.btnBuscarRangoFin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarRangoFin.Enabled = False
        Me.btnBuscarRangoFin.Location = New System.Drawing.Point(196, 65)
        Me.btnBuscarRangoFin.Name = "btnBuscarRangoFin"
        Me.btnBuscarRangoFin.Size = New System.Drawing.Size(23, 23)
        Me.btnBuscarRangoFin.TabIndex = 40
        '
        'c1txtRangoFin
        '
        Me.c1txtRangoFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtRangoFin.Location = New System.Drawing.Point(74, 67)
        Me.c1txtRangoFin.Name = "c1txtRangoFin"
        Me.c1txtRangoFin.Size = New System.Drawing.Size(122, 20)
        Me.c1txtRangoFin.TabIndex = 39
        Me.c1txtRangoFin.Tag = Nothing
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Rango Final:"
        '
        'btnBuscarRangoIni
        '
        Me.btnBuscarRangoIni.ControlEnlazado = Nothing
        Me.btnBuscarRangoIni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarRangoIni.Enabled = False
        Me.btnBuscarRangoIni.Location = New System.Drawing.Point(196, 17)
        Me.btnBuscarRangoIni.Name = "btnBuscarRangoIni"
        Me.btnBuscarRangoIni.Size = New System.Drawing.Size(23, 23)
        Me.btnBuscarRangoIni.TabIndex = 37
        '
        'c1txtRangoIni
        '
        Me.c1txtRangoIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtRangoIni.Location = New System.Drawing.Point(74, 19)
        Me.c1txtRangoIni.Name = "c1txtRangoIni"
        Me.c1txtRangoIni.Size = New System.Drawing.Size(122, 20)
        Me.c1txtRangoIni.TabIndex = 36
        Me.c1txtRangoIni.Tag = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Rango Inicial:"
        '
        'cmbMeses
        '
        Me.cmbMeses.FormattingEnabled = True
        Me.cmbMeses.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbMeses.Location = New System.Drawing.Point(9, 42)
        Me.cmbMeses.Name = "cmbMeses"
        Me.cmbMeses.Size = New System.Drawing.Size(121, 21)
        Me.cmbMeses.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Vacaciones en el mes de:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(398, 263)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(101, 32)
        Me.btnCancelar.TabIndex = 22
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(29, 263)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(101, 32)
        Me.btnAceptar.TabIndex = 21
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'PLRepEmpSelFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 304)
        Me.Controls.Add(Me.grpRangos)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.grpID)
        Me.Controls.Add(Me.grpGenero)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.c1dateFecha)
        Me.Controls.Add(Me.grpVacaciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PLRepEmpSelFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Empleados por Selección"
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpGenero.ResumeLayout(False)
        Me.grpGenero.PerformLayout()
        Me.grpID.ResumeLayout(False)
        Me.grpID.PerformLayout()
        Me.grpVacaciones.ResumeLayout(False)
        Me.grpVacaciones.PerformLayout()
        Me.grpRangos.ResumeLayout(False)
        Me.grpRangos.PerformLayout()
        CType(Me.c1numSueldoMensual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtRangoFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtRangoIni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents c1dateFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpGenero As System.Windows.Forms.GroupBox
    Friend WithEvents grpID As System.Windows.Forms.GroupBox
    Friend WithEvents grpVacaciones As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutEmpCancelados As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutEmpVacaciones As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutTipoPlaza As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutCargoSalario As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutOficina As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutCargo As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutFechaIngreso As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutFemenino As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutAmbosGeneros As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutIdentidad As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents cmbMeses As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpRangos As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscarRangoIni As RSIContab.BotonBuscar
    Friend WithEvents c1txtRangoIni As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkboxListarTodos As System.Windows.Forms.CheckBox
    Friend WithEvents lblSueldo As System.Windows.Forms.Label
    Friend WithEvents lblNombreFin As System.Windows.Forms.Label
    Friend WithEvents lblNombreIni As System.Windows.Forms.Label
    Friend WithEvents btnBuscarRangoFin As RSIContab.BotonBuscar
    Friend WithEvents c1txtRangoFin As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents c1numSueldoMensual As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents cmbSignos As System.Windows.Forms.ComboBox
End Class
