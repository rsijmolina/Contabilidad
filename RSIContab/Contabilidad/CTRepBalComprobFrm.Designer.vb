<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTRepBalComprobFrm
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
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbMeses = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.c1numAñoUsuario = New C1.Win.C1Input.C1NumericEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkboxUtilizarPeriodoUsuario = New System.Windows.Forms.CheckBox()
        Me.c1dateFecha = New C1.Win.C1Input.C1DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.c1numFactorCambio = New C1.Win.C1Input.C1NumericEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.chkboxFechasIniFin = New System.Windows.Forms.CheckBox()
        Me.chkboxMostrarTituloMoneda = New System.Windows.Forms.CheckBox()
        Me.chkboxSuprimirSaldosCeros = New System.Windows.Forms.CheckBox()
        Me.chkboxListarTodoCatalogo = New System.Windows.Forms.CheckBox()
        Me.chkboxImprimirPresupuesto = New System.Windows.Forms.CheckBox()
        Me.GroupBox3.SuspendLayout()
        CType(Me.c1numAñoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numFactorCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPeriodo
        '
        Me.lblPeriodo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPeriodo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodo.ForeColor = System.Drawing.Color.White
        Me.lblPeriodo.Location = New System.Drawing.Point(0, 0)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(260, 20)
        Me.lblPeriodo.TabIndex = 30
        Me.lblPeriodo.Text = "Periodo Actual"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbMeses)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.c1numAñoUsuario)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.chkboxUtilizarPeriodoUsuario)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(238, 52)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        '
        'cmbMeses
        '
        Me.cmbMeses.FormattingEnabled = True
        Me.cmbMeses.Location = New System.Drawing.Point(131, 19)
        Me.cmbMeses.Name = "cmbMeses"
        Me.cmbMeses.Size = New System.Drawing.Size(101, 21)
        Me.cmbMeses.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Mes:"
        '
        'c1numAñoUsuario
        '
        Me.c1numAñoUsuario.DataType = GetType(Short)
        Me.c1numAñoUsuario.Location = New System.Drawing.Point(41, 23)
        Me.c1numAñoUsuario.Name = "c1numAñoUsuario"
        Me.c1numAñoUsuario.Size = New System.Drawing.Size(50, 20)
        Me.c1numAñoUsuario.TabIndex = 25
        Me.c1numAñoUsuario.Tag = Nothing
        Me.c1numAñoUsuario.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Año:"
        '
        'chkboxUtilizarPeriodoUsuario
        '
        Me.chkboxUtilizarPeriodoUsuario.AutoSize = True
        Me.chkboxUtilizarPeriodoUsuario.Location = New System.Drawing.Point(9, 0)
        Me.chkboxUtilizarPeriodoUsuario.Name = "chkboxUtilizarPeriodoUsuario"
        Me.chkboxUtilizarPeriodoUsuario.Size = New System.Drawing.Size(122, 17)
        Me.chkboxUtilizarPeriodoUsuario.TabIndex = 0
        Me.chkboxUtilizarPeriodoUsuario.Text = "Utilizar Este Período"
        Me.chkboxUtilizarPeriodoUsuario.UseVisualStyleBackColor = True
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
        Me.c1dateFecha.Location = New System.Drawing.Point(102, 81)
        Me.c1dateFecha.Name = "c1dateFecha"
        Me.c1dateFecha.Size = New System.Drawing.Size(105, 20)
        Me.c1dateFecha.TabIndex = 33
        Me.c1dateFecha.Tag = Nothing
        Me.c1dateFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Fecha:"
        '
        'c1numFactorCambio
        '
        Me.c1numFactorCambio.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numFactorCambio.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numFactorCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numFactorCambio.Location = New System.Drawing.Point(129, 208)
        Me.c1numFactorCambio.Name = "c1numFactorCambio"
        Me.c1numFactorCambio.Size = New System.Drawing.Size(79, 20)
        Me.c1numFactorCambio.TabIndex = 39
        Me.c1numFactorCambio.Tag = Nothing
        Me.c1numFactorCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numFactorCambio.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1numFactorCambio.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Factor de Cambio:"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(159, 263)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(89, 33)
        Me.btnCancelar.TabIndex = 35
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(10, 263)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(89, 33)
        Me.btnAceptar.TabIndex = 34
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'chkboxFechasIniFin
        '
        Me.chkboxFechasIniFin.AutoSize = True
        Me.chkboxFechasIniFin.Location = New System.Drawing.Point(10, 234)
        Me.chkboxFechasIniFin.Name = "chkboxFechasIniFin"
        Me.chkboxFechasIniFin.Size = New System.Drawing.Size(241, 17)
        Me.chkboxFechasIniFin.TabIndex = 40
        Me.chkboxFechasIniFin.Text = "Mostrar Fechas Iniciales y Finales en el Título"
        Me.chkboxFechasIniFin.UseVisualStyleBackColor = True
        '
        'chkboxMostrarTituloMoneda
        '
        Me.chkboxMostrarTituloMoneda.AutoSize = True
        Me.chkboxMostrarTituloMoneda.Location = New System.Drawing.Point(10, 188)
        Me.chkboxMostrarTituloMoneda.Name = "chkboxMostrarTituloMoneda"
        Me.chkboxMostrarTituloMoneda.Size = New System.Drawing.Size(149, 17)
        Me.chkboxMostrarTituloMoneda.TabIndex = 38
        Me.chkboxMostrarTituloMoneda.Text = "Mostrar Título de Moneda"
        Me.chkboxMostrarTituloMoneda.UseVisualStyleBackColor = True
        '
        'chkboxSuprimirSaldosCeros
        '
        Me.chkboxSuprimirSaldosCeros.AutoSize = True
        Me.chkboxSuprimirSaldosCeros.Location = New System.Drawing.Point(10, 165)
        Me.chkboxSuprimirSaldosCeros.Name = "chkboxSuprimirSaldosCeros"
        Me.chkboxSuprimirSaldosCeros.Size = New System.Drawing.Size(138, 17)
        Me.chkboxSuprimirSaldosCeros.TabIndex = 37
        Me.chkboxSuprimirSaldosCeros.Text = "Suprimir Saldos en Cero"
        Me.chkboxSuprimirSaldosCeros.UseVisualStyleBackColor = True
        '
        'chkboxListarTodoCatalogo
        '
        Me.chkboxListarTodoCatalogo.AutoSize = True
        Me.chkboxListarTodoCatalogo.Location = New System.Drawing.Point(10, 116)
        Me.chkboxListarTodoCatalogo.Name = "chkboxListarTodoCatalogo"
        Me.chkboxListarTodoCatalogo.Size = New System.Drawing.Size(135, 17)
        Me.chkboxListarTodoCatalogo.TabIndex = 41
        Me.chkboxListarTodoCatalogo.Text = "Listar Todo el Catálogo"
        Me.chkboxListarTodoCatalogo.UseVisualStyleBackColor = True
        '
        'chkboxImprimirPresupuesto
        '
        Me.chkboxImprimirPresupuesto.AutoSize = True
        Me.chkboxImprimirPresupuesto.Location = New System.Drawing.Point(10, 139)
        Me.chkboxImprimirPresupuesto.Name = "chkboxImprimirPresupuesto"
        Me.chkboxImprimirPresupuesto.Size = New System.Drawing.Size(123, 17)
        Me.chkboxImprimirPresupuesto.TabIndex = 42
        Me.chkboxImprimirPresupuesto.Text = "Imprimir Presupuesto"
        Me.chkboxImprimirPresupuesto.UseVisualStyleBackColor = True
        '
        'CTRepBalComprobFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 304)
        Me.Controls.Add(Me.chkboxImprimirPresupuesto)
        Me.Controls.Add(Me.chkboxListarTodoCatalogo)
        Me.Controls.Add(Me.c1numFactorCambio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.chkboxFechasIniFin)
        Me.Controls.Add(Me.chkboxMostrarTituloMoneda)
        Me.Controls.Add(Me.chkboxSuprimirSaldosCeros)
        Me.Controls.Add(Me.c1dateFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblPeriodo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CTRepBalComprobFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance de Comprobación"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.c1numAñoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numFactorCambio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbMeses As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents c1numAñoUsuario As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkboxUtilizarPeriodoUsuario As System.Windows.Forms.CheckBox
    Friend WithEvents c1dateFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents c1numFactorCambio As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents chkboxFechasIniFin As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxMostrarTituloMoneda As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxSuprimirSaldosCeros As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxListarTodoCatalogo As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxImprimirPresupuesto As System.Windows.Forms.CheckBox
End Class
