<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLVacacionesFrm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PLVacacionesFrm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblAñosDeLabores = New System.Windows.Forms.Label()
        Me.c1dateFecha = New C1.Win.C1Input.C1DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.c1txtCodigoEmpleado = New C1.Win.C1Input.C1TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotalValorDiasTomados = New System.Windows.Forms.Label()
        Me.lblTotalDiasPagados = New System.Windows.Forms.Label()
        Me.lblTotDiasTomados = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalDiasGozados = New System.Windows.Forms.Label()
        Me.lblTotalDiasVac = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.c1truedbgrdTablaVacaciones = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.c1truedbgrdDiasTomados = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.c1truedbgrdVacaciones = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.StatusStripPrincipal = New System.Windows.Forms.StatusStrip()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolstripbutRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbutImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstripbutSalir = New System.Windows.Forms.ToolStripButton()
        Me.TablaVacacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLVacacionesDataSet = New RSIContab.PLVacacionesDataSet()
        Me.VacacionesTomadasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLVacacionesTableAdapter = New RSIContab.PLVacacionesDataSetTableAdapters.PLVacacionesTableAdapter()
        Me.PLDiasVacacionesTomadosTableAdapter = New RSIContab.PLVacacionesDataSetTableAdapters.PLDiasVacacionesTomadosTableAdapter()
        Me.PLTablaDiasVacacionesTableAdapter = New RSIContab.PLVacacionesDataSetTableAdapters.PLTablaDiasVacacionesTableAdapter()
        Me.btnBuscarEmpleado = New RSIContab.BotonBuscar()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtCodigoEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.c1truedbgrdTablaVacaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1truedbgrdDiasTomados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1truedbgrdVacaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.TablaVacacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLVacacionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VacacionesTomadasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblAñosDeLabores)
        Me.GroupBox1.Controls.Add(Me.c1dateFecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.btnBuscarEmpleado)
        Me.GroupBox1.Controls.Add(Me.lblBuscar)
        Me.GroupBox1.Controls.Add(Me.c1txtCodigoEmpleado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(692, 76)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblAñosDeLabores
        '
        Me.lblAñosDeLabores.AutoSize = True
        Me.lblAñosDeLabores.Location = New System.Drawing.Point(222, 53)
        Me.lblAñosDeLabores.Name = "lblAñosDeLabores"
        Me.lblAñosDeLabores.Size = New System.Drawing.Size(0, 13)
        Me.lblAñosDeLabores.TabIndex = 71
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
        Me.c1dateFecha.Location = New System.Drawing.Point(108, 47)
        Me.c1dateFecha.Name = "c1dateFecha"
        Me.c1dateFecha.Size = New System.Drawing.Size(105, 20)
        Me.c1dateFecha.TabIndex = 70
        Me.c1dateFecha.Tag = Nothing
        Me.c1dateFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Fecha de Ingreso:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(219, 22)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(10, 13)
        Me.lblNombre.TabIndex = 68
        Me.lblNombre.Text = "."
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(462, 50)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 67
        Me.lblBuscar.Text = "Buscar"
        Me.lblBuscar.Visible = False
        '
        'c1txtCodigoEmpleado
        '
        Me.c1txtCodigoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtCodigoEmpleado.Location = New System.Drawing.Point(68, 19)
        Me.c1txtCodigoEmpleado.Name = "c1txtCodigoEmpleado"
        Me.c1txtCodigoEmpleado.Size = New System.Drawing.Size(122, 20)
        Me.c1txtCodigoEmpleado.TabIndex = 64
        Me.c1txtCodigoEmpleado.Tag = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Empleado:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalValorDiasTomados)
        Me.GroupBox2.Controls.Add(Me.lblTotalDiasPagados)
        Me.GroupBox2.Controls.Add(Me.lblTotDiasTomados)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblSaldo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblTotalDiasGozados)
        Me.GroupBox2.Controls.Add(Me.lblTotalDiasVac)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.c1truedbgrdTablaVacaciones)
        Me.GroupBox2.Controls.Add(Me.c1truedbgrdDiasTomados)
        Me.GroupBox2.Controls.Add(Me.c1truedbgrdVacaciones)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(692, 377)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Programación de Vacaciones"
        '
        'lblTotalValorDiasTomados
        '
        Me.lblTotalValorDiasTomados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalValorDiasTomados.Location = New System.Drawing.Point(275, 361)
        Me.lblTotalValorDiasTomados.Name = "lblTotalValorDiasTomados"
        Me.lblTotalValorDiasTomados.Size = New System.Drawing.Size(61, 13)
        Me.lblTotalValorDiasTomados.TabIndex = 13
        Me.lblTotalValorDiasTomados.Text = "0"
        Me.lblTotalValorDiasTomados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalDiasPagados
        '
        Me.lblTotalDiasPagados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDiasPagados.Location = New System.Drawing.Point(285, 148)
        Me.lblTotalDiasPagados.Name = "lblTotalDiasPagados"
        Me.lblTotalDiasPagados.Size = New System.Drawing.Size(60, 13)
        Me.lblTotalDiasPagados.TabIndex = 12
        Me.lblTotalDiasPagados.Text = "0"
        Me.lblTotalDiasPagados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotDiasTomados
        '
        Me.lblTotDiasTomados.AutoSize = True
        Me.lblTotDiasTomados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotDiasTomados.Location = New System.Drawing.Point(238, 361)
        Me.lblTotDiasTomados.Name = "lblTotDiasTomados"
        Me.lblTotDiasTomados.Size = New System.Drawing.Size(14, 13)
        Me.lblTotDiasTomados.TabIndex = 11
        Me.lblTotDiasTomados.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(161, 361)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total:"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.Location = New System.Drawing.Point(51, 148)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(14, 13)
        Me.lblSaldo.TabIndex = 9
        Me.lblSaldo.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Saldo:"
        '
        'lblTotalDiasGozados
        '
        Me.lblTotalDiasGozados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDiasGozados.Location = New System.Drawing.Point(222, 148)
        Me.lblTotalDiasGozados.Name = "lblTotalDiasGozados"
        Me.lblTotalDiasGozados.Size = New System.Drawing.Size(41, 13)
        Me.lblTotalDiasGozados.TabIndex = 7
        Me.lblTotalDiasGozados.Text = "0"
        Me.lblTotalDiasGozados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalDiasVac
        '
        Me.lblTotalDiasVac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDiasVac.Location = New System.Drawing.Point(147, 148)
        Me.lblTotalDiasVac.Name = "lblTotalDiasVac"
        Me.lblTotalDiasVac.Size = New System.Drawing.Size(43, 13)
        Me.lblTotalDiasVac.TabIndex = 5
        Me.lblTotalDiasVac.Text = "0"
        Me.lblTotalDiasVac.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Totales:"
        '
        'c1truedbgrdTablaVacaciones
        '
        Me.c1truedbgrdTablaVacaciones.AllowAddNew = True
        Me.c1truedbgrdTablaVacaciones.AllowDelete = True
        Me.c1truedbgrdTablaVacaciones.Caption = "Tabla de Vacaciones"
        Me.c1truedbgrdTablaVacaciones.DataSource = Me.TablaVacacionesBindingSource
        Me.c1truedbgrdTablaVacaciones.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1truedbgrdTablaVacaciones.Images.Add(CType(resources.GetObject("c1truedbgrdTablaVacaciones.Images"), System.Drawing.Image))
        Me.c1truedbgrdTablaVacaciones.Location = New System.Drawing.Point(520, 19)
        Me.c1truedbgrdTablaVacaciones.Name = "c1truedbgrdTablaVacaciones"
        Me.c1truedbgrdTablaVacaciones.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1truedbgrdTablaVacaciones.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1truedbgrdTablaVacaciones.PreviewInfo.ZoomFactor = 75.0R
        Me.c1truedbgrdTablaVacaciones.PrintInfo.PageSettings = CType(resources.GetObject("c1truedbgrdTablaVacaciones.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1truedbgrdTablaVacaciones.RowHeight = 17
        Me.c1truedbgrdTablaVacaciones.Size = New System.Drawing.Size(166, 125)
        Me.c1truedbgrdTablaVacaciones.TabIndex = 3
        Me.c1truedbgrdTablaVacaciones.Text = "C1TrueDBGrid3"
        Me.c1truedbgrdTablaVacaciones.PropBag = resources.GetString("c1truedbgrdTablaVacaciones.PropBag")
        '
        'c1truedbgrdDiasTomados
        '
        Me.c1truedbgrdDiasTomados.AllowAddNew = True
        Me.c1truedbgrdDiasTomados.AllowDelete = True
        Me.c1truedbgrdDiasTomados.AlternatingRows = True
        Me.c1truedbgrdDiasTomados.Caption = "Días Tomados"
        Me.c1truedbgrdDiasTomados.DataSource = Me.VacacionesTomadasBindingSource
        Me.c1truedbgrdDiasTomados.Enabled = False
        Me.c1truedbgrdDiasTomados.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1truedbgrdDiasTomados.Images.Add(CType(resources.GetObject("c1truedbgrdDiasTomados.Images"), System.Drawing.Image))
        Me.c1truedbgrdDiasTomados.Location = New System.Drawing.Point(10, 176)
        Me.c1truedbgrdDiasTomados.Name = "c1truedbgrdDiasTomados"
        Me.c1truedbgrdDiasTomados.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1truedbgrdDiasTomados.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1truedbgrdDiasTomados.PreviewInfo.ZoomFactor = 75.0R
        Me.c1truedbgrdDiasTomados.PrintInfo.PageSettings = CType(resources.GetObject("c1truedbgrdDiasTomados.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1truedbgrdDiasTomados.RowHeight = 17
        Me.c1truedbgrdDiasTomados.Size = New System.Drawing.Size(584, 182)
        Me.c1truedbgrdDiasTomados.TabIndex = 1
        Me.c1truedbgrdDiasTomados.Text = "C1TrueDBGrid2"
        Me.c1truedbgrdDiasTomados.PropBag = resources.GetString("c1truedbgrdDiasTomados.PropBag")
        '
        'c1truedbgrdVacaciones
        '
        Me.c1truedbgrdVacaciones.AllowAddNew = True
        Me.c1truedbgrdVacaciones.AllowDelete = True
        Me.c1truedbgrdVacaciones.AlternatingRows = True
        Me.c1truedbgrdVacaciones.Caption = "Vacaciones"
        Me.c1truedbgrdVacaciones.DataSource = Me.PrincipalBindingSource
        Me.c1truedbgrdVacaciones.Enabled = False
        Me.c1truedbgrdVacaciones.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1truedbgrdVacaciones.Images.Add(CType(resources.GetObject("c1truedbgrdVacaciones.Images"), System.Drawing.Image))
        Me.c1truedbgrdVacaciones.Location = New System.Drawing.Point(10, 19)
        Me.c1truedbgrdVacaciones.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightCell
        Me.c1truedbgrdVacaciones.Name = "c1truedbgrdVacaciones"
        Me.c1truedbgrdVacaciones.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1truedbgrdVacaciones.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1truedbgrdVacaciones.PreviewInfo.ZoomFactor = 75.0R
        Me.c1truedbgrdVacaciones.PrintInfo.PageSettings = CType(resources.GetObject("c1truedbgrdVacaciones.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1truedbgrdVacaciones.RowHeight = 17
        Me.c1truedbgrdVacaciones.Size = New System.Drawing.Size(504, 126)
        Me.c1truedbgrdVacaciones.TabIndex = 0
        Me.c1truedbgrdVacaciones.Text = "C1TrueDBGrid1"
        Me.c1truedbgrdVacaciones.PropBag = resources.GetString("c1truedbgrdVacaciones.PropBag")
        '
        'StatusStripPrincipal
        '
        Me.StatusStripPrincipal.Location = New System.Drawing.Point(0, 500)
        Me.StatusStripPrincipal.Name = "StatusStripPrincipal"
        Me.StatusStripPrincipal.Size = New System.Drawing.Size(707, 22)
        Me.StatusStripPrincipal.TabIndex = 2
        Me.StatusStripPrincipal.Text = "StatusStrip1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripbutRefrescar, Me.toolstripbutImprimir, Me.ToolStripSeparator1, Me.toolstripbutSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(707, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolstripbutRefrescar
        '
        Me.toolstripbutRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutRefrescar.Image = Global.RSIContab.My.Resources.Resources.RefreshDocViewHS
        Me.toolstripbutRefrescar.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutRefrescar.Name = "toolstripbutRefrescar"
        Me.toolstripbutRefrescar.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutRefrescar.Text = "Refrescar Datos"
        '
        'toolstripbutImprimir
        '
        Me.toolstripbutImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutImprimir.Image = Global.RSIContab.My.Resources.Resources.PrintHS
        Me.toolstripbutImprimir.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutImprimir.Name = "toolstripbutImprimir"
        Me.toolstripbutImprimir.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutImprimir.Text = "ToolStripButton1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'toolstripbutSalir
        '
        Me.toolstripbutSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutSalir.Image = Global.RSIContab.My.Resources.Resources.CriticalError
        Me.toolstripbutSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripbutSalir.Name = "toolstripbutSalir"
        Me.toolstripbutSalir.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutSalir.Text = "Salir"
        '
        'TablaVacacionesBindingSource
        '
        Me.TablaVacacionesBindingSource.DataMember = "PLTablaDiasVacaciones"
        Me.TablaVacacionesBindingSource.DataSource = Me.PLVacacionesDataSet
        '
        'PLVacacionesDataSet
        '
        Me.PLVacacionesDataSet.DataSetName = "PLVacacionesDataSet"
        Me.PLVacacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VacacionesTomadasBindingSource
        '
        Me.VacacionesTomadasBindingSource.DataMember = "PLDiasVacacionesTomados"
        Me.VacacionesTomadasBindingSource.DataSource = Me.PLVacacionesDataSet
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLVacaciones"
        Me.PrincipalBindingSource.DataSource = Me.PLVacacionesDataSet
        '
        'PLVacacionesTableAdapter
        '
        Me.PLVacacionesTableAdapter.ClearBeforeFill = True
        '
        'PLDiasVacacionesTomadosTableAdapter
        '
        Me.PLDiasVacacionesTomadosTableAdapter.ClearBeforeFill = True
        '
        'PLTablaDiasVacacionesTableAdapter
        '
        Me.PLTablaDiasVacacionesTableAdapter.ClearBeforeFill = True
        '
        'btnBuscarEmpleado
        '
        Me.btnBuscarEmpleado.ControlEnlazado = Nothing
        Me.btnBuscarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarEmpleado.Enabled = False
        Me.btnBuscarEmpleado.Location = New System.Drawing.Point(190, 17)
        Me.btnBuscarEmpleado.Name = "btnBuscarEmpleado"
        Me.btnBuscarEmpleado.Size = New System.Drawing.Size(23, 23)
        Me.btnBuscarEmpleado.TabIndex = 65
        '
        'PLVacacionesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 522)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStripPrincipal)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PLVacacionesFrm"
        Me.Text = "Mantenimiento de Vacaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtCodigoEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.c1truedbgrdTablaVacaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1truedbgrdDiasTomados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1truedbgrdVacaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.TablaVacacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLVacacionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VacacionesTomadasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnBuscarEmpleado As RSIContab.BotonBuscar
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents c1txtCodigoEmpleado As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLVacacionesDataSet As RSIContab.PLVacacionesDataSet
    Friend WithEvents PLVacacionesTableAdapter As RSIContab.PLVacacionesDataSetTableAdapters.PLVacacionesTableAdapter
    Friend WithEvents c1truedbgrdVacaciones As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StatusStripPrincipal As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents c1dateFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents c1truedbgrdDiasTomados As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents VacacionesTomadasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLDiasVacacionesTomadosTableAdapter As RSIContab.PLVacacionesDataSetTableAdapters.PLDiasVacacionesTomadosTableAdapter
    Friend WithEvents toolstripbutSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents c1truedbgrdTablaVacaciones As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents TablaVacacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLTablaDiasVacacionesTableAdapter As RSIContab.PLVacacionesDataSetTableAdapters.PLTablaDiasVacacionesTableAdapter
    Friend WithEvents lblAñosDeLabores As System.Windows.Forms.Label
    Friend WithEvents lblTotalDiasVac As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotalDiasGozados As System.Windows.Forms.Label
    Friend WithEvents lblTotDiasTomados As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents toolstripbutRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblTotalDiasPagados As System.Windows.Forms.Label
    Friend WithEvents lblTotalValorDiasTomados As System.Windows.Forms.Label
    Friend WithEvents toolstripbutImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
