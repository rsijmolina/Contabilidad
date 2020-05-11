<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTTransaccionesContFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CTTransaccionesContFrm))
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style6 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style7 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style8 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Me.statusstripPrincipal = New System.Windows.Forms.StatusStrip()
        Me.statusCerrado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusImpreso = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusContabilizado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusAnulado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statuslblAñoMes = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.c1cmbTipo = New C1.Win.C1List.C1Combo()
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTTransaccionesDataSet = New RSIContab.CTTransaccionesDataSet()
        Me.TiposPartidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.c1txtSinopsis = New C1.Win.C1Input.C1TextBox()
        Me.c1dateFecha = New C1.Win.C1Input.C1DateEdit()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.c1txtNoTransaccion = New C1.Win.C1Input.C1TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.c1dbgrdDetalle = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.DetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblNombreCuenta = New System.Windows.Forms.Label()
        Me.lblTotalHaber = New System.Windows.Forms.Label()
        Me.lblTotalDebe = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CTTransaccionesEncabezadoTableAdapter = New RSIContab.CTTransaccionesDataSetTableAdapters.CTTransaccionesEncabezadoTableAdapter()
        Me.CTTiposPartidasTableAdapter = New RSIContab.CTTransaccionesDataSetTableAdapters.CTTiposPartidasTableAdapter()
        Me.CTTransaccionesDetalleTableAdapter = New RSIContab.CTTransaccionesDataSetTableAdapters.CTTransaccionesDetalleTableAdapter()
        Me.CatalogoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTCatalogoCuentasTableAdapter = New RSIContab.CTTransaccionesDataSetTableAdapters.CTCatalogoCuentasTableAdapter()
        Me.btnBuscarTransaccion = New RSIContab.BotonBuscar()
        Me.DataNavBarPrincipal = New RSIContab.DataNavBar()
        Me.statusstripPrincipal.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1cmbTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTTransaccionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposPartidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtSinopsis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtNoTransaccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1dbgrdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CatalogoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'statusstripPrincipal
        '
        Me.statusstripPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusCerrado, Me.statusImpreso, Me.statusContabilizado, Me.statusAnulado, Me.statuslblAñoMes})
        Me.statusstripPrincipal.Location = New System.Drawing.Point(0, 375)
        Me.statusstripPrincipal.Name = "statusstripPrincipal"
        Me.statusstripPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.statusstripPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.statusstripPrincipal.Size = New System.Drawing.Size(773, 22)
        Me.statusstripPrincipal.TabIndex = 50
        '
        'statusCerrado
        '
        Me.statusCerrado.ForeColor = System.Drawing.Color.DarkBlue
        Me.statusCerrado.Image = CType(resources.GetObject("statusCerrado.Image"), System.Drawing.Image)
        Me.statusCerrado.ImageTransparentColor = System.Drawing.Color.Black
        Me.statusCerrado.Margin = New System.Windows.Forms.Padding(5, 3, 0, 2)
        Me.statusCerrado.Name = "statusCerrado"
        Me.statusCerrado.Size = New System.Drawing.Size(65, 17)
        Me.statusCerrado.Text = "Cerrado"
        Me.statusCerrado.Visible = False
        '
        'statusImpreso
        '
        Me.statusImpreso.ForeColor = System.Drawing.Color.DarkBlue
        Me.statusImpreso.Image = CType(resources.GetObject("statusImpreso.Image"), System.Drawing.Image)
        Me.statusImpreso.ImageTransparentColor = System.Drawing.Color.Black
        Me.statusImpreso.Margin = New System.Windows.Forms.Padding(5, 3, 0, 2)
        Me.statusImpreso.Name = "statusImpreso"
        Me.statusImpreso.Size = New System.Drawing.Size(66, 17)
        Me.statusImpreso.Text = "Impreso"
        Me.statusImpreso.Visible = False
        '
        'statusContabilizado
        '
        Me.statusContabilizado.ForeColor = System.Drawing.Color.DarkBlue
        Me.statusContabilizado.Image = CType(resources.GetObject("statusContabilizado.Image"), System.Drawing.Image)
        Me.statusContabilizado.ImageTransparentColor = System.Drawing.Color.Black
        Me.statusContabilizado.Margin = New System.Windows.Forms.Padding(5, 3, 0, 2)
        Me.statusContabilizado.Name = "statusContabilizado"
        Me.statusContabilizado.Size = New System.Drawing.Size(96, 17)
        Me.statusContabilizado.Text = "Contabilizado"
        Me.statusContabilizado.Visible = False
        '
        'statusAnulado
        '
        Me.statusAnulado.ForeColor = System.Drawing.Color.DarkBlue
        Me.statusAnulado.Image = CType(resources.GetObject("statusAnulado.Image"), System.Drawing.Image)
        Me.statusAnulado.ImageTransparentColor = System.Drawing.Color.Black
        Me.statusAnulado.Margin = New System.Windows.Forms.Padding(5, 3, 0, 2)
        Me.statusAnulado.Name = "statusAnulado"
        Me.statusAnulado.Size = New System.Drawing.Size(68, 17)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.c1cmbTipo)
        Me.GroupBox1.Controls.Add(Me.lblUsuario)
        Me.GroupBox1.Controls.Add(Me.c1txtSinopsis)
        Me.GroupBox1.Controls.Add(Me.c1dateFecha)
        Me.GroupBox1.Controls.Add(Me.btnBuscarTransaccion)
        Me.GroupBox1.Controls.Add(Me.lblBuscar)
        Me.GroupBox1.Controls.Add(Me.c1txtNoTransaccion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(753, 110)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        '
        'c1cmbTipo
        '
        Me.c1cmbTipo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.c1cmbTipo.Caption = ""
        Me.c1cmbTipo.CaptionHeight = 17
        Me.c1cmbTipo.CaptionStyle = Style1
        Me.c1cmbTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.c1cmbTipo.ColumnCaptionHeight = 17
        Me.c1cmbTipo.ColumnFooterHeight = 17
        Me.c1cmbTipo.ColumnWidth = 100
        Me.c1cmbTipo.ContentHeight = 15
        Me.c1cmbTipo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PrincipalBindingSource, "TipoPartida", True))
        Me.c1cmbTipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrincipalBindingSource, "TipoPartida", True))
        Me.c1cmbTipo.DataSource = Me.TiposPartidasBindingSource
        Me.c1cmbTipo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.c1cmbTipo.DisplayMember = "TipoPartida"
        Me.c1cmbTipo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.c1cmbTipo.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1cmbTipo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.c1cmbTipo.EditorHeight = 15
        Me.c1cmbTipo.EvenRowStyle = Style2
        Me.c1cmbTipo.FooterStyle = Style3
        Me.c1cmbTipo.HeadingStyle = Style4
        Me.c1cmbTipo.HighLightRowStyle = Style5
        Me.c1cmbTipo.Images.Add(CType(resources.GetObject("c1cmbTipo.Images"), System.Drawing.Image))
        Me.c1cmbTipo.ItemHeight = 15
        Me.c1cmbTipo.Location = New System.Drawing.Point(601, 19)
        Me.c1cmbTipo.MatchEntryTimeout = CType(2000, Long)
        Me.c1cmbTipo.MaxDropDownItems = CType(5, Short)
        Me.c1cmbTipo.MaxLength = 32767
        Me.c1cmbTipo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.c1cmbTipo.Name = "c1cmbTipo"
        Me.c1cmbTipo.OddRowStyle = Style6
        Me.c1cmbTipo.ReadOnly = True
        Me.c1cmbTipo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.c1cmbTipo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.c1cmbTipo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.c1cmbTipo.SelectedStyle = Style7
        Me.c1cmbTipo.Size = New System.Drawing.Size(128, 21)
        Me.c1cmbTipo.Style = Style8
        Me.c1cmbTipo.TabIndex = 65
        Me.c1cmbTipo.Tag = "C"
        Me.c1cmbTipo.ValueMember = "TipoPartida"
        Me.c1cmbTipo.PropBag = resources.GetString("c1cmbTipo.PropBag")
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "CTTransaccionesEncabezado"
        Me.PrincipalBindingSource.DataSource = Me.CTTransaccionesDataSet
        '
        'CTTransaccionesDataSet
        '
        Me.CTTransaccionesDataSet.DataSetName = "CTTransaccionesDataSet"
        Me.CTTransaccionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TiposPartidasBindingSource
        '
        Me.TiposPartidasBindingSource.DataMember = "CTTiposPartidas"
        Me.TiposPartidasBindingSource.DataSource = Me.CTTransaccionesDataSet
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrincipalBindingSource, "Usuario", True))
        Me.lblUsuario.Location = New System.Drawing.Point(607, 48)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(10, 13)
        Me.lblUsuario.TabIndex = 64
        Me.lblUsuario.Text = "."
        '
        'c1txtSinopsis
        '
        Me.c1txtSinopsis.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "Sinopsis", True))
        Me.c1txtSinopsis.Location = New System.Drawing.Point(76, 51)
        Me.c1txtSinopsis.Multiline = True
        Me.c1txtSinopsis.Name = "c1txtSinopsis"
        Me.c1txtSinopsis.ReadOnly = True
        Me.c1txtSinopsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.c1txtSinopsis.Size = New System.Drawing.Size(473, 53)
        Me.c1txtSinopsis.TabIndex = 63
        Me.c1txtSinopsis.Tag = "CM"
        '
        'c1dateFecha
        '
        Me.c1dateFecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "Fecha", True))
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
        Me.c1dateFecha.Location = New System.Drawing.Point(399, 17)
        Me.c1dateFecha.Name = "c1dateFecha"
        Me.c1dateFecha.ReadOnly = True
        Me.c1dateFecha.Size = New System.Drawing.Size(112, 20)
        Me.c1dateFecha.TabIndex = 62
        Me.c1dateFecha.Tag = "CM"
        Me.c1dateFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(227, 19)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 61
        Me.lblBuscar.Text = "Buscar"
        Me.lblBuscar.Visible = False
        '
        'c1txtNoTransaccion
        '
        Me.c1txtNoTransaccion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "NoTransaccion", True))
        Me.c1txtNoTransaccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtNoTransaccion.Location = New System.Drawing.Point(76, 19)
        Me.c1txtNoTransaccion.Name = "c1txtNoTransaccion"
        Me.c1txtNoTransaccion.ReadOnly = True
        Me.c1txtNoTransaccion.Size = New System.Drawing.Size(122, 20)
        Me.c1txtNoTransaccion.TabIndex = 59
        Me.c1txtNoTransaccion.Tag = "C"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(555, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sinopsis:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(555, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(353, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Partida No.:"
        '
        'c1dbgrdDetalle
        '
        Me.c1dbgrdDetalle.AllowAddNew = True
        Me.c1dbgrdDetalle.AllowDelete = True
        Me.c1dbgrdDetalle.AllowSort = False
        Me.c1dbgrdDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.c1dbgrdDetalle.BackColor = System.Drawing.SystemColors.Control
        Me.c1dbgrdDetalle.DataSource = Me.DetalleBindingSource
        Me.c1dbgrdDetalle.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbgrdDetalle.Images.Add(CType(resources.GetObject("c1dbgrdDetalle.Images"), System.Drawing.Image))
        Me.c1dbgrdDetalle.Location = New System.Drawing.Point(9, 144)
        Me.c1dbgrdDetalle.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.SolidCellBorder
        Me.c1dbgrdDetalle.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None
        Me.c1dbgrdDetalle.Name = "c1dbgrdDetalle"
        Me.c1dbgrdDetalle.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbgrdDetalle.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbgrdDetalle.PreviewInfo.ZoomFactor = 75.0R
        Me.c1dbgrdDetalle.PrintInfo.PageSettings = CType(resources.GetObject("c1dbgrdDetalle.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1dbgrdDetalle.RowHeight = 17
        Me.c1dbgrdDetalle.Size = New System.Drawing.Size(756, 178)
        Me.c1dbgrdDetalle.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.c1dbgrdDetalle.TabIndex = 53
        Me.c1dbgrdDetalle.Text = "C1TrueDBGrid1"
        Me.c1dbgrdDetalle.PropBag = resources.GetString("c1dbgrdDetalle.PropBag")
        '
        'DetalleBindingSource
        '
        Me.DetalleBindingSource.DataMember = "CTTransaccionesDetalle"
        Me.DetalleBindingSource.DataSource = Me.CTTransaccionesDataSet
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lblNombreCuenta)
        Me.GroupBox2.Controls.Add(Me.lblTotalHaber)
        Me.GroupBox2.Controls.Add(Me.lblTotalDebe)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 322)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(756, 42)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        '
        'lblNombreCuenta
        '
        Me.lblNombreCuenta.AutoSize = True
        Me.lblNombreCuenta.Location = New System.Drawing.Point(13, 16)
        Me.lblNombreCuenta.Name = "lblNombreCuenta"
        Me.lblNombreCuenta.Size = New System.Drawing.Size(10, 13)
        Me.lblNombreCuenta.TabIndex = 3
        Me.lblNombreCuenta.Text = "."
        '
        'lblTotalHaber
        '
        Me.lblTotalHaber.BackColor = System.Drawing.Color.White
        Me.lblTotalHaber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalHaber.Location = New System.Drawing.Point(637, 16)
        Me.lblTotalHaber.Name = "lblTotalHaber"
        Me.lblTotalHaber.Size = New System.Drawing.Size(105, 19)
        Me.lblTotalHaber.TabIndex = 2
        Me.lblTotalHaber.Text = "0.00"
        Me.lblTotalHaber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalDebe
        '
        Me.lblTotalDebe.BackColor = System.Drawing.Color.White
        Me.lblTotalDebe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDebe.Location = New System.Drawing.Point(531, 16)
        Me.lblTotalDebe.Name = "lblTotalDebe"
        Me.lblTotalDebe.Size = New System.Drawing.Size(100, 19)
        Me.lblTotalDebe.TabIndex = 1
        Me.lblTotalDebe.Text = "0.00"
        Me.lblTotalDebe.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(480, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Totales:"
        '
        'CTTransaccionesEncabezadoTableAdapter
        '
        Me.CTTransaccionesEncabezadoTableAdapter.ClearBeforeFill = True
        '
        'CTTiposPartidasTableAdapter
        '
        Me.CTTiposPartidasTableAdapter.ClearBeforeFill = True
        '
        'CTTransaccionesDetalleTableAdapter
        '
        Me.CTTransaccionesDetalleTableAdapter.ClearBeforeFill = True
        '
        'CatalogoBindingSource
        '
        Me.CatalogoBindingSource.DataMember = "CTCatalogoCuentas"
        Me.CatalogoBindingSource.DataSource = Me.CTTransaccionesDataSet
        '
        'CTCatalogoCuentasTableAdapter
        '
        Me.CTCatalogoCuentasTableAdapter.ClearBeforeFill = True
        '
        'btnBuscarTransaccion
        '
        Me.btnBuscarTransaccion.ControlEnlazado = Nothing
        Me.btnBuscarTransaccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarTransaccion.Enabled = False
        Me.btnBuscarTransaccion.Location = New System.Drawing.Point(198, 17)
        Me.btnBuscarTransaccion.Name = "btnBuscarTransaccion"
        Me.btnBuscarTransaccion.Size = New System.Drawing.Size(23, 23)
        Me.btnBuscarTransaccion.TabIndex = 60
        Me.btnBuscarTransaccion.Tag = "HABILITARNOEDIT"
        '
        'DataNavBarPrincipal
        '
        Me.DataNavBarPrincipal.BarraDeEstado = Me.statusstripPrincipal
        Me.DataNavBarPrincipal.BindingSourcePrincipal = Me.PrincipalBindingSource
        Me.DataNavBarPrincipal.dbgrdDetalle = Me.c1dbgrdDetalle
        Me.DataNavBarPrincipal.Editando = False
        Me.DataNavBarPrincipal.EjecutarAntesCancelar = False
        Me.DataNavBarPrincipal.EjecutarAntesEliminar = False
        Me.DataNavBarPrincipal.EjecutarAntesGrabar = True
        Me.DataNavBarPrincipal.EjecutarAntesModificar = True
        Me.DataNavBarPrincipal.EjecutarAntesNuevo = False
        Me.DataNavBarPrincipal.EjecutarAntesSalir = False
        Me.DataNavBarPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.DataNavBarPrincipal.ModalidadSoloLectura = False
        Me.DataNavBarPrincipal.ModificarRegistro = False
        Me.DataNavBarPrincipal.MostrarListaInvPermanente = False
        Me.DataNavBarPrincipal.Name = "DataNavBarPrincipal"
        Me.DataNavBarPrincipal.NuevoRegistro = False
        Me.DataNavBarPrincipal.ResultadoValidacion = Nothing
        Me.DataNavBarPrincipal.Size = New System.Drawing.Size(782, 31)
        Me.DataNavBarPrincipal.TabIndex = 51
        Me.DataNavBarPrincipal.TieneDetalle = True
        Me.DataNavBarPrincipal.UltimaLinDet = CType(0, Short)
        Me.DataNavBarPrincipal.UsarBotonAnularRegistro = True
        Me.DataNavBarPrincipal.UsarBotonCancelar = True
        Me.DataNavBarPrincipal.UsarBotonCerrarDocumento = True
        Me.DataNavBarPrincipal.UsarBotonComentarios = True
        Me.DataNavBarPrincipal.UsarBotonContabilizar = False
        Me.DataNavBarPrincipal.UsarBotonDocumentacion = False
        Me.DataNavBarPrincipal.UsarBotonEliminarRegistro = True
        Me.DataNavBarPrincipal.UsarBotonGuardarRegistro = True
        Me.DataNavBarPrincipal.UsarBotonImprimir = True
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
        'CTTransaccionesContFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 397)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.c1dbgrdDetalle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataNavBarPrincipal)
        Me.Controls.Add(Me.statusstripPrincipal)
        Me.Name = "CTTransaccionesContFrm"
        Me.Text = "Transacciones Contables"
        Me.statusstripPrincipal.ResumeLayout(False)
        Me.statusstripPrincipal.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1cmbTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTTransaccionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposPartidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtSinopsis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtNoTransaccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1dbgrdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CatalogoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTTransaccionesDataSet As RSIContab.CTTransaccionesDataSet
    Friend WithEvents CTTransaccionesEncabezadoTableAdapter As RSIContab.CTTransaccionesDataSetTableAdapters.CTTransaccionesEncabezadoTableAdapter
    Friend WithEvents statusstripPrincipal As System.Windows.Forms.StatusStrip
    Friend WithEvents statusCerrado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusImpreso As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusContabilizado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusAnulado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statuslblAñoMes As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataNavBarPrincipal As RSIContab.DataNavBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarTransaccion As RSIContab.BotonBuscar
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents c1txtNoTransaccion As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1dateFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents c1txtSinopsis As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents c1cmbTipo As C1.Win.C1List.C1Combo
    Friend WithEvents TiposPartidasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTTiposPartidasTableAdapter As RSIContab.CTTransaccionesDataSetTableAdapters.CTTiposPartidasTableAdapter
    Friend WithEvents c1dbgrdDetalle As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents DetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTTransaccionesDetalleTableAdapter As RSIContab.CTTransaccionesDataSetTableAdapters.CTTransaccionesDetalleTableAdapter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTotalDebe As System.Windows.Forms.Label
    Friend WithEvents lblTotalHaber As System.Windows.Forms.Label
    Friend WithEvents lblNombreCuenta As System.Windows.Forms.Label
    Friend WithEvents CatalogoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTCatalogoCuentasTableAdapter As RSIContab.CTTransaccionesDataSetTableAdapters.CTCatalogoCuentasTableAdapter
End Class
