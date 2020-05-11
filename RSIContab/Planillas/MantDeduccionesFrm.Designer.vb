<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MantDeduccionesFrm
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
        Me.components = New System.ComponentModel.Container
        Me.statusstripPrincipal = New System.Windows.Forms.StatusStrip
        Me.statusCerrado = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusImpreso = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusContabilizado = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusAnulado = New System.Windows.Forms.ToolStripStatusLabel
        Me.statuslblAñoMes = New System.Windows.Forms.ToolStripStatusLabel
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLDefDeduccionesDataSet = New RSIContab.PLDefDeduccionesDataSet
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PLDefinicionDeduccionesTableAdapter = New RSIContab.PLDefDeduccionesDataSetTableAdapters.PLDefinicionDeduccionesTableAdapter
        Me.c1txtCodigoDeducción = New C1.Win.C1Input.C1TextBox
        Me.c1txtDescripcion = New C1.Win.C1Input.C1TextBox
        Me.chkboxDedPermanente = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkboxTotRepOtrasDed = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.c1numNoColReporte = New C1.Win.C1Input.C1NumericEdit
        Me.c1txtTitColReporte = New C1.Win.C1Input.C1TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.c1txtReciTitCol = New C1.Win.C1Input.C1TextBox
        Me.chkboxTotReciOtrasDed = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.c1numNoColRecibo = New C1.Win.C1Input.C1NumericEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkboxAplicarPlani14 = New System.Windows.Forms.CheckBox
        Me.chkboxAplicarPlani13 = New System.Windows.Forms.CheckBox
        Me.chkboxAplicarPlaniVacaciones = New System.Windows.Forms.CheckBox
        Me.chkboxDesactivarDeduccion = New System.Windows.Forms.CheckBox
        Me.DataNavBarPrincipal = New RSIContab.DataNavBar
        Me.statusstripPrincipal.SuspendLayout()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLDefDeduccionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtCodigoDeducción, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1numNoColReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtTitColReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.c1txtReciTitCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numNoColRecibo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusstripPrincipal
        '
        Me.statusstripPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusCerrado, Me.statusImpreso, Me.statusContabilizado, Me.statusAnulado, Me.statuslblAñoMes})
        Me.statusstripPrincipal.Location = New System.Drawing.Point(0, 270)
        Me.statusstripPrincipal.Name = "statusstripPrincipal"
        Me.statusstripPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.statusstripPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.statusstripPrincipal.Size = New System.Drawing.Size(520, 22)
        Me.statusstripPrincipal.TabIndex = 51
        '
        'statusCerrado
        '
        Me.statusCerrado.ForeColor = System.Drawing.Color.DarkBlue
        Me.statusCerrado.Image = Global.RSIContab.My.Resources.Resources.TaskHS
        Me.statusCerrado.ImageTransparentColor = System.Drawing.Color.Black
        Me.statusCerrado.Margin = New System.Windows.Forms.Padding(5, 3, 0, 2)
        Me.statusCerrado.Name = "statusCerrado"
        Me.statusCerrado.Size = New System.Drawing.Size(62, 17)
        Me.statusCerrado.Text = "Cerrado"
        Me.statusCerrado.Visible = False
        '
        'statusImpreso
        '
        Me.statusImpreso.ForeColor = System.Drawing.Color.DarkBlue
        Me.statusImpreso.Image = Global.RSIContab.My.Resources.Resources.PrintHS
        Me.statusImpreso.ImageTransparentColor = System.Drawing.Color.Black
        Me.statusImpreso.Margin = New System.Windows.Forms.Padding(5, 3, 0, 2)
        Me.statusImpreso.Name = "statusImpreso"
        Me.statusImpreso.Size = New System.Drawing.Size(62, 17)
        Me.statusImpreso.Text = "Impreso"
        Me.statusImpreso.Visible = False
        '
        'statusContabilizado
        '
        Me.statusContabilizado.ForeColor = System.Drawing.Color.DarkBlue
        Me.statusContabilizado.Image = Global.RSIContab.My.Resources.Resources.book_reportHS
        Me.statusContabilizado.ImageTransparentColor = System.Drawing.Color.Black
        Me.statusContabilizado.Margin = New System.Windows.Forms.Padding(5, 3, 0, 2)
        Me.statusContabilizado.Name = "statusContabilizado"
        Me.statusContabilizado.Size = New System.Drawing.Size(87, 17)
        Me.statusContabilizado.Text = "Contabilizado"
        Me.statusContabilizado.Visible = False
        '
        'statusAnulado
        '
        Me.statusAnulado.ForeColor = System.Drawing.Color.DarkBlue
        Me.statusAnulado.Image = Global.RSIContab.My.Resources.Resources.RightsRestrictedHS
        Me.statusAnulado.ImageTransparentColor = System.Drawing.Color.Black
        Me.statusAnulado.Margin = New System.Windows.Forms.Padding(5, 3, 0, 2)
        Me.statusAnulado.Name = "statusAnulado"
        Me.statusAnulado.Size = New System.Drawing.Size(62, 17)
        Me.statusAnulado.Text = "Anulado"
        Me.statusAnulado.Visible = False
        '
        'statuslblAñoMes
        '
        Me.statuslblAñoMes.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.statuslblAñoMes.ForeColor = System.Drawing.Color.DarkBlue
        Me.statuslblAñoMes.Margin = New System.Windows.Forms.Padding(5, 3, 0, 2)
        Me.statuslblAñoMes.Name = "statuslblAñoMes"
        Me.statuslblAñoMes.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.statuslblAñoMes.Size = New System.Drawing.Size(14, 17)
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLDefinicionDeducciones"
        Me.PrincipalBindingSource.DataSource = Me.PLDefDeduccionesDataSet
        '
        'PLDefDeduccionesDataSet
        '
        Me.PLDefDeduccionesDataSet.DataSetName = "PLDefDeduccionesDataSet"
        Me.PLDefDeduccionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Deducción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Descripción:"
        '
        'PLDefinicionDeduccionesTableAdapter
        '
        Me.PLDefinicionDeduccionesTableAdapter.ClearBeforeFill = True
        '
        'c1txtCodigoDeducción
        '
        Me.c1txtCodigoDeducción.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "CodigoDeduccion", True))
        Me.c1txtCodigoDeducción.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtCodigoDeducción.Location = New System.Drawing.Point(108, 40)
        Me.c1txtCodigoDeducción.Name = "c1txtCodigoDeducción"
        Me.c1txtCodigoDeducción.ReadOnly = True
        Me.c1txtCodigoDeducción.Size = New System.Drawing.Size(109, 20)
        Me.c1txtCodigoDeducción.TabIndex = 62
        Me.c1txtCodigoDeducción.Tag = "CO"
        '
        'c1txtDescripcion
        '
        Me.c1txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DescripcionDeduccion", True))
        Me.c1txtDescripcion.Location = New System.Drawing.Point(108, 66)
        Me.c1txtDescripcion.Name = "c1txtDescripcion"
        Me.c1txtDescripcion.ReadOnly = True
        Me.c1txtDescripcion.Size = New System.Drawing.Size(289, 20)
        Me.c1txtDescripcion.TabIndex = 63
        Me.c1txtDescripcion.Tag = "CMO"
        '
        'chkboxDedPermanente
        '
        Me.chkboxDedPermanente.AutoSize = True
        Me.chkboxDedPermanente.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PrincipalBindingSource, "DeduccionPermanente", True))
        Me.chkboxDedPermanente.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PrincipalBindingSource, "DeduccionPermanente", True))
        Me.chkboxDedPermanente.Enabled = False
        Me.chkboxDedPermanente.Location = New System.Drawing.Point(224, 42)
        Me.chkboxDedPermanente.Name = "chkboxDedPermanente"
        Me.chkboxDedPermanente.Size = New System.Drawing.Size(138, 17)
        Me.chkboxDedPermanente.TabIndex = 64
        Me.chkboxDedPermanente.Text = "Deducción Permanente"
        Me.chkboxDedPermanente.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkboxTotRepOtrasDed)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.c1numNoColReporte)
        Me.GroupBox1.Controls.Add(Me.c1txtTitColReporte)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 100)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Columna en Reporte"
        '
        'chkboxTotRepOtrasDed
        '
        Me.chkboxTotRepOtrasDed.AutoSize = True
        Me.chkboxTotRepOtrasDed.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PrincipalBindingSource, "RepTotEnOtrasDeducciones", True))
        Me.chkboxTotRepOtrasDed.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PrincipalBindingSource, "RepTotEnOtrasDeducciones", True))
        Me.chkboxTotRepOtrasDed.Enabled = False
        Me.chkboxTotRepOtrasDed.Location = New System.Drawing.Point(9, 77)
        Me.chkboxTotRepOtrasDed.Name = "chkboxTotRepOtrasDed"
        Me.chkboxTotRepOtrasDed.Size = New System.Drawing.Size(175, 17)
        Me.chkboxTotRepOtrasDed.TabIndex = 67
        Me.chkboxTotRepOtrasDed.Text = "Totalizar en Otras Deducciones"
        Me.chkboxTotRepOtrasDed.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "No. de Columna:"
        '
        'c1numNoColReporte
        '
        Me.c1numNoColReporte.AutoSize = False
        Me.c1numNoColReporte.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "RepNoColumna", True))
        Me.c1numNoColReporte.DataType = GetType(Short)
        Me.c1numNoColReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numNoColReporte.Location = New System.Drawing.Point(104, 51)
        Me.c1numNoColReporte.Name = "c1numNoColReporte"
        Me.c1numNoColReporte.ReadOnly = True
        Me.c1numNoColReporte.Size = New System.Drawing.Size(23, 20)
        Me.c1numNoColReporte.TabIndex = 65
        Me.c1numNoColReporte.Tag = "CM"
        Me.c1numNoColReporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numNoColReporte.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1txtTitColReporte
        '
        Me.c1txtTitColReporte.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "RepTituloColumna", True))
        Me.c1txtTitColReporte.Location = New System.Drawing.Point(104, 25)
        Me.c1txtTitColReporte.Name = "c1txtTitColReporte"
        Me.c1txtTitColReporte.ReadOnly = True
        Me.c1txtTitColReporte.Size = New System.Drawing.Size(110, 20)
        Me.c1txtTitColReporte.TabIndex = 64
        Me.c1txtTitColReporte.Tag = "CM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Título de Columna:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.c1txtReciTitCol)
        Me.GroupBox2.Controls.Add(Me.chkboxTotReciOtrasDed)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.c1numNoColRecibo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(259, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(220, 100)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Columna en Recibo"
        '
        'c1txtReciTitCol
        '
        Me.c1txtReciTitCol.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "ReciTituloColumna", True))
        Me.c1txtReciTitCol.Location = New System.Drawing.Point(104, 25)
        Me.c1txtReciTitCol.Name = "c1txtReciTitCol"
        Me.c1txtReciTitCol.ReadOnly = True
        Me.c1txtReciTitCol.Size = New System.Drawing.Size(110, 20)
        Me.c1txtReciTitCol.TabIndex = 73
        Me.c1txtReciTitCol.Tag = "CM"
        '
        'chkboxTotReciOtrasDed
        '
        Me.chkboxTotReciOtrasDed.AutoSize = True
        Me.chkboxTotReciOtrasDed.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PrincipalBindingSource, "ReciTotEnOtrasDeducciones", True))
        Me.chkboxTotReciOtrasDed.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PrincipalBindingSource, "ReciTotEnOtrasDeducciones", True))
        Me.chkboxTotReciOtrasDed.Enabled = False
        Me.chkboxTotReciOtrasDed.Location = New System.Drawing.Point(9, 77)
        Me.chkboxTotReciOtrasDed.Name = "chkboxTotReciOtrasDed"
        Me.chkboxTotReciOtrasDed.Size = New System.Drawing.Size(175, 17)
        Me.chkboxTotReciOtrasDed.TabIndex = 72
        Me.chkboxTotReciOtrasDed.Text = "Totalizar en Otras Deducciones"
        Me.chkboxTotReciOtrasDed.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "No. de Columna:"
        '
        'c1numNoColRecibo
        '
        Me.c1numNoColRecibo.AutoSize = False
        Me.c1numNoColRecibo.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "ReciNoPosicion", True))
        Me.c1numNoColRecibo.DataType = GetType(Short)
        Me.c1numNoColRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numNoColRecibo.Location = New System.Drawing.Point(104, 51)
        Me.c1numNoColRecibo.Name = "c1numNoColRecibo"
        Me.c1numNoColRecibo.ReadOnly = True
        Me.c1numNoColRecibo.Size = New System.Drawing.Size(23, 20)
        Me.c1numNoColRecibo.TabIndex = 70
        Me.c1numNoColRecibo.Tag = "CM"
        Me.c1numNoColRecibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numNoColRecibo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Título de Columna:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkboxAplicarPlani14)
        Me.GroupBox3.Controls.Add(Me.chkboxAplicarPlani13)
        Me.GroupBox3.Controls.Add(Me.chkboxAplicarPlaniVacaciones)
        Me.GroupBox3.Location = New System.Drawing.Point(30, 208)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(449, 46)
        Me.GroupBox3.TabIndex = 67
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Aplicar esta deducción en"
        '
        'chkboxAplicarPlani14
        '
        Me.chkboxAplicarPlani14.AutoSize = True
        Me.chkboxAplicarPlani14.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PrincipalBindingSource, "AplicarEnPlanilla14VO", True))
        Me.chkboxAplicarPlani14.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PrincipalBindingSource, "AplicarEnPlanilla14VO", True))
        Me.chkboxAplicarPlani14.Enabled = False
        Me.chkboxAplicarPlani14.Location = New System.Drawing.Point(333, 19)
        Me.chkboxAplicarPlani14.Name = "chkboxAplicarPlani14"
        Me.chkboxAplicarPlani14.Size = New System.Drawing.Size(106, 17)
        Me.chkboxAplicarPlani14.TabIndex = 67
        Me.chkboxAplicarPlani14.Text = "Planilla del 14vo."
        Me.chkboxAplicarPlani14.UseVisualStyleBackColor = True
        '
        'chkboxAplicarPlani13
        '
        Me.chkboxAplicarPlani13.AutoSize = True
        Me.chkboxAplicarPlani13.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PrincipalBindingSource, "AplicarEnPlanilla13VO", True))
        Me.chkboxAplicarPlani13.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PrincipalBindingSource, "AplicarEnPlanilla13VO", True))
        Me.chkboxAplicarPlani13.Enabled = False
        Me.chkboxAplicarPlani13.Location = New System.Drawing.Point(180, 19)
        Me.chkboxAplicarPlani13.Name = "chkboxAplicarPlani13"
        Me.chkboxAplicarPlani13.Size = New System.Drawing.Size(106, 17)
        Me.chkboxAplicarPlani13.TabIndex = 66
        Me.chkboxAplicarPlani13.Text = "Planilla del 13vo."
        Me.chkboxAplicarPlani13.UseVisualStyleBackColor = True
        '
        'chkboxAplicarPlaniVacaciones
        '
        Me.chkboxAplicarPlaniVacaciones.AutoSize = True
        Me.chkboxAplicarPlaniVacaciones.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PrincipalBindingSource, "AplicarEnPlanillaVacaciones", True))
        Me.chkboxAplicarPlaniVacaciones.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PrincipalBindingSource, "AplicarEnPlanillaVacaciones", True))
        Me.chkboxAplicarPlaniVacaciones.Enabled = False
        Me.chkboxAplicarPlaniVacaciones.Location = New System.Drawing.Point(12, 19)
        Me.chkboxAplicarPlaniVacaciones.Name = "chkboxAplicarPlaniVacaciones"
        Me.chkboxAplicarPlaniVacaciones.Size = New System.Drawing.Size(133, 17)
        Me.chkboxAplicarPlaniVacaciones.TabIndex = 65
        Me.chkboxAplicarPlaniVacaciones.Text = "Planilla de Vacaciones"
        Me.chkboxAplicarPlaniVacaciones.UseVisualStyleBackColor = True
        '
        'chkboxDesactivarDeduccion
        '
        Me.chkboxDesactivarDeduccion.AutoSize = True
        Me.chkboxDesactivarDeduccion.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PrincipalBindingSource, "Desactivada", True))
        Me.chkboxDesactivarDeduccion.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PrincipalBindingSource, "Desactivada", True))
        Me.chkboxDesactivarDeduccion.Enabled = False
        Me.chkboxDesactivarDeduccion.Location = New System.Drawing.Point(368, 43)
        Me.chkboxDesactivarDeduccion.Name = "chkboxDesactivarDeduccion"
        Me.chkboxDesactivarDeduccion.Size = New System.Drawing.Size(132, 17)
        Me.chkboxDesactivarDeduccion.TabIndex = 68
        Me.chkboxDesactivarDeduccion.Tag = "CM"
        Me.chkboxDesactivarDeduccion.Text = "Desactivar Deducción"
        Me.chkboxDesactivarDeduccion.UseVisualStyleBackColor = True
        '
        'DataNavBarPrincipal
        '
        Me.DataNavBarPrincipal.BarraDeEstado = Me.statusstripPrincipal
        Me.DataNavBarPrincipal.BindingSourcePrincipal = Me.PrincipalBindingSource
        Me.DataNavBarPrincipal.dbgrdDetalle = Nothing
        Me.DataNavBarPrincipal.Editando = False
        Me.DataNavBarPrincipal.EjecutarAntesCancelar = False
        Me.DataNavBarPrincipal.EjecutarAntesEliminar = False
        Me.DataNavBarPrincipal.EjecutarAntesGrabar = True
        Me.DataNavBarPrincipal.EjecutarAntesModificar = False
        Me.DataNavBarPrincipal.EjecutarAntesNuevo = False
        Me.DataNavBarPrincipal.EjecutarAntesSalir = False
        Me.DataNavBarPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.DataNavBarPrincipal.ModificarRegistro = False
        Me.DataNavBarPrincipal.MostrarListaInvPermanente = False
        Me.DataNavBarPrincipal.Name = "DataNavBarPrincipal"
        Me.DataNavBarPrincipal.NuevoRegistro = False
        Me.DataNavBarPrincipal.ResultadoValidacion = Nothing
        Me.DataNavBarPrincipal.Size = New System.Drawing.Size(521, 31)
        Me.DataNavBarPrincipal.TabIndex = 52
        Me.DataNavBarPrincipal.TieneDetalle = False
        Me.DataNavBarPrincipal.UltimaLinDet = CType(0, Short)
        Me.DataNavBarPrincipal.UsarBotonAnularRegistro = False
        Me.DataNavBarPrincipal.UsarBotonCancelar = True
        Me.DataNavBarPrincipal.UsarBotonCerrarDocumento = False
        Me.DataNavBarPrincipal.UsarBotonContabilizar = False
        Me.DataNavBarPrincipal.UsarBotonEliminarRegistro = True
        Me.DataNavBarPrincipal.UsarBotonGuardarRegistro = True
        Me.DataNavBarPrincipal.UsarBotonImprimir = False
        Me.DataNavBarPrincipal.UsarBotonMasOpciones = False
        Me.DataNavBarPrincipal.UsarBotonModificarRegistro = True
        Me.DataNavBarPrincipal.UsarBotonNuevoRegistro = True
        Me.DataNavBarPrincipal.UsarBotonPrimerRegistro = True
        Me.DataNavBarPrincipal.UsarBotonRegistroAnterior = True
        Me.DataNavBarPrincipal.UsarBotonSalir = True
        Me.DataNavBarPrincipal.UsarBotonSiguienteRegistro = True
        Me.DataNavBarPrincipal.UsarBotonUltimoRegistro = True
        Me.DataNavBarPrincipal.UsarBuscar = True
        Me.DataNavBarPrincipal.UsarTextoPosicionRegistro = True
        Me.DataNavBarPrincipal.ValidacionCorrecta = False
        '
        'MantDeduccionesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 292)
        Me.Controls.Add(Me.chkboxDesactivarDeduccion)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkboxDedPermanente)
        Me.Controls.Add(Me.c1txtDescripcion)
        Me.Controls.Add(Me.c1txtCodigoDeducción)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataNavBarPrincipal)
        Me.Controls.Add(Me.statusstripPrincipal)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "MantDeduccionesFrm"
        Me.Text = "Mantenimiento de  Deducciones"
        Me.statusstripPrincipal.ResumeLayout(False)
        Me.statusstripPrincipal.PerformLayout()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLDefDeduccionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtCodigoDeducción, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1numNoColReporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtTitColReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.c1txtReciTitCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numNoColRecibo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLDefDeduccionesDataSet As RSIContab.PLDefDeduccionesDataSet
    Friend WithEvents PLDefinicionDeduccionesTableAdapter As RSIContab.PLDefDeduccionesDataSetTableAdapters.PLDefinicionDeduccionesTableAdapter
    Friend WithEvents statusstripPrincipal As System.Windows.Forms.StatusStrip
    Friend WithEvents statusCerrado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusImpreso As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusContabilizado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusAnulado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statuslblAñoMes As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataNavBarPrincipal As RSIContab.DataNavBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents c1txtCodigoDeducción As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtDescripcion As C1.Win.C1Input.C1TextBox
    Friend WithEvents chkboxDedPermanente As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents c1txtTitColReporte As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents c1numNoColReporte As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkboxTotRepOtrasDed As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxTotReciOtrasDed As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents c1numNoColRecibo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkboxAplicarPlani14 As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxAplicarPlani13 As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxAplicarPlaniVacaciones As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxDesactivarDeduccion As System.Windows.Forms.CheckBox
    Friend WithEvents c1txtReciTitCol As C1.Win.C1Input.C1TextBox
End Class
