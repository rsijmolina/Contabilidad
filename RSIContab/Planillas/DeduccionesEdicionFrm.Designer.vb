<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeduccionesEdicionFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeduccionesEdicionFrm))
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Dim Style6 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Dim Style7 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Dim Style8 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Me.c1truedbgrdPrincipal = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLEdicionDeduccionesDataSet = New RSIContab.PLEdicionDeduccionesDataSet
        Me.StatusStripPrincipal = New System.Windows.Forms.StatusStrip
        Me.Label1 = New System.Windows.Forms.Label
        Me.c1cmbDeducciones = New C1.Win.C1List.C1Combo
        Me.DefDeduccionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataNavBarPrincipal = New RSIContab.DataNavBar
        Me.PLDeduccionesTableAdapter = New RSIContab.PLEdicionDeduccionesDataSetTableAdapters.PLDeduccionesTableAdapter
        Me.PLDefinicionDeduccionesTableAdapter = New RSIContab.PLEdicionDeduccionesDataSetTableAdapters.PLDefinicionDeduccionesTableAdapter
        CType(Me.c1truedbgrdPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLEdicionDeduccionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1cmbDeducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefDeduccionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1truedbgrdPrincipal
        '
        Me.c1truedbgrdPrincipal.AllowAddNew = True
        Me.c1truedbgrdPrincipal.AllowDelete = True
        Me.c1truedbgrdPrincipal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.c1truedbgrdPrincipal.DataSource = Me.PrincipalBindingSource
        Me.c1truedbgrdPrincipal.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1truedbgrdPrincipal.Images.Add(CType(resources.GetObject("c1truedbgrdPrincipal.Images"), System.Drawing.Image))
        Me.c1truedbgrdPrincipal.Location = New System.Drawing.Point(5, 67)
        Me.c1truedbgrdPrincipal.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.c1truedbgrdPrincipal.Name = "c1truedbgrdPrincipal"
        Me.c1truedbgrdPrincipal.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1truedbgrdPrincipal.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1truedbgrdPrincipal.PreviewInfo.ZoomFactor = 75
        Me.c1truedbgrdPrincipal.PrintInfo.PageSettings = CType(resources.GetObject("c1truedbgrdPrincipal.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1truedbgrdPrincipal.Size = New System.Drawing.Size(973, 344)
        Me.c1truedbgrdPrincipal.TabIndex = 0
        Me.c1truedbgrdPrincipal.Text = "C1TrueDBGrid1"
        Me.c1truedbgrdPrincipal.PropBag = resources.GetString("c1truedbgrdPrincipal.PropBag")
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLDeducciones"
        Me.PrincipalBindingSource.DataSource = Me.PLEdicionDeduccionesDataSet
        '
        'PLEdicionDeduccionesDataSet
        '
        Me.PLEdicionDeduccionesDataSet.DataSetName = "PLEdicionDeduccionesDataSet"
        Me.PLEdicionDeduccionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatusStripPrincipal
        '
        Me.StatusStripPrincipal.Location = New System.Drawing.Point(0, 428)
        Me.StatusStripPrincipal.Name = "StatusStripPrincipal"
        Me.StatusStripPrincipal.Size = New System.Drawing.Size(990, 22)
        Me.StatusStripPrincipal.TabIndex = 1
        Me.StatusStripPrincipal.Text = "StatusStrip1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Deducción:"
        '
        'c1cmbDeducciones
        '
        Me.c1cmbDeducciones.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.c1cmbDeducciones.Caption = ""
        Me.c1cmbDeducciones.CaptionHeight = 17
        Me.c1cmbDeducciones.CaptionStyle = Style1
        Me.c1cmbDeducciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.c1cmbDeducciones.ColumnCaptionHeight = 17
        Me.c1cmbDeducciones.ColumnFooterHeight = 17
        Me.c1cmbDeducciones.ContentHeight = 15
        Me.c1cmbDeducciones.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DefDeduccionesBindingSource, "CodigoDeduccion", True))
        Me.c1cmbDeducciones.DataSource = Me.DefDeduccionesBindingSource
        Me.c1cmbDeducciones.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.c1cmbDeducciones.DisplayMember = "DescripcionDeduccion"
        Me.c1cmbDeducciones.EditorBackColor = System.Drawing.SystemColors.Window
        Me.c1cmbDeducciones.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1cmbDeducciones.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.c1cmbDeducciones.EditorHeight = 15
        Me.c1cmbDeducciones.EvenRowStyle = Style2
        Me.c1cmbDeducciones.FooterStyle = Style3
        Me.c1cmbDeducciones.HeadingStyle = Style4
        Me.c1cmbDeducciones.HighLightRowStyle = Style5
        Me.c1cmbDeducciones.Images.Add(CType(resources.GetObject("c1cmbDeducciones.Images"), System.Drawing.Image))
        Me.c1cmbDeducciones.ItemHeight = 15
        Me.c1cmbDeducciones.Location = New System.Drawing.Point(75, 37)
        Me.c1cmbDeducciones.MatchEntryTimeout = CType(2000, Long)
        Me.c1cmbDeducciones.MaxDropDownItems = CType(5, Short)
        Me.c1cmbDeducciones.MaxLength = 32767
        Me.c1cmbDeducciones.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.c1cmbDeducciones.Name = "c1cmbDeducciones"
        Me.c1cmbDeducciones.OddRowStyle = Style6
        Me.c1cmbDeducciones.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.c1cmbDeducciones.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.c1cmbDeducciones.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.c1cmbDeducciones.SelectedStyle = Style7
        Me.c1cmbDeducciones.Size = New System.Drawing.Size(379, 21)
        Me.c1cmbDeducciones.Style = Style8
        Me.c1cmbDeducciones.TabIndex = 6
        Me.c1cmbDeducciones.ValueMember = "CodigoDeduccion"
        Me.c1cmbDeducciones.PropBag = resources.GetString("c1cmbDeducciones.PropBag")
        '
        'DefDeduccionesBindingSource
        '
        Me.DefDeduccionesBindingSource.DataMember = "PLDefinicionDeducciones"
        Me.DefDeduccionesBindingSource.DataSource = Me.PLEdicionDeduccionesDataSet
        '
        'DataNavBarPrincipal
        '
        Me.DataNavBarPrincipal.BarraDeEstado = Me.StatusStripPrincipal
        Me.DataNavBarPrincipal.BindingSourcePrincipal = Me.PrincipalBindingSource
        Me.DataNavBarPrincipal.dbgrdDetalle = Nothing
        Me.DataNavBarPrincipal.Editando = False
        Me.DataNavBarPrincipal.EjecutarAntesCancelar = False
        Me.DataNavBarPrincipal.EjecutarAntesEliminar = False
        Me.DataNavBarPrincipal.EjecutarAntesGrabar = False
        Me.DataNavBarPrincipal.EjecutarAntesModificar = False
        Me.DataNavBarPrincipal.EjecutarAntesNuevo = False
        Me.DataNavBarPrincipal.EjecutarAntesSalir = False
        Me.DataNavBarPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.DataNavBarPrincipal.ModificarRegistro = False
        Me.DataNavBarPrincipal.MostrarListaInvPermanente = False
        Me.DataNavBarPrincipal.Name = "DataNavBarPrincipal"
        Me.DataNavBarPrincipal.NuevoRegistro = False
        Me.DataNavBarPrincipal.ResultadoValidacion = Nothing
        Me.DataNavBarPrincipal.Size = New System.Drawing.Size(991, 31)
        Me.DataNavBarPrincipal.TabIndex = 2
        Me.DataNavBarPrincipal.TieneDetalle = False
        Me.DataNavBarPrincipal.UltimaLinDet = CType(0, Short)
        Me.DataNavBarPrincipal.UsarBotonAnularRegistro = True
        Me.DataNavBarPrincipal.UsarBotonCancelar = True
        Me.DataNavBarPrincipal.UsarBotonCerrarDocumento = False
        Me.DataNavBarPrincipal.UsarBotonContabilizar = False
        Me.DataNavBarPrincipal.UsarBotonEliminarRegistro = True
        Me.DataNavBarPrincipal.UsarBotonGuardarRegistro = True
        Me.DataNavBarPrincipal.UsarBotonImprimir = False
        Me.DataNavBarPrincipal.UsarBotonMasOpciones = False
        Me.DataNavBarPrincipal.UsarBotonModificarRegistro = True
        Me.DataNavBarPrincipal.UsarBotonNuevoRegistro = False
        Me.DataNavBarPrincipal.UsarBotonPrimerRegistro = False
        Me.DataNavBarPrincipal.UsarBotonRegistroAnterior = False
        Me.DataNavBarPrincipal.UsarBotonSalir = True
        Me.DataNavBarPrincipal.UsarBotonSiguienteRegistro = False
        Me.DataNavBarPrincipal.UsarBotonUltimoRegistro = False
        Me.DataNavBarPrincipal.UsarBuscar = False
        Me.DataNavBarPrincipal.UsarTextoPosicionRegistro = False
        Me.DataNavBarPrincipal.ValidacionCorrecta = False
        '
        'PLDeduccionesTableAdapter
        '
        Me.PLDeduccionesTableAdapter.ClearBeforeFill = True
        '
        'PLDefinicionDeduccionesTableAdapter
        '
        Me.PLDefinicionDeduccionesTableAdapter.ClearBeforeFill = True
        '
        'DeduccionesEdicionFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 450)
        Me.Controls.Add(Me.c1cmbDeducciones)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataNavBarPrincipal)
        Me.Controls.Add(Me.StatusStripPrincipal)
        Me.Controls.Add(Me.c1truedbgrdPrincipal)
        Me.MaximizeBox = False
        Me.Name = "DeduccionesEdicionFrm"
        Me.Text = "Edición de Deducciones"
        CType(Me.c1truedbgrdPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLEdicionDeduccionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1cmbDeducciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefDeduccionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents c1truedbgrdPrincipal As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLEdicionDeduccionesDataSet As RSIContab.PLEdicionDeduccionesDataSet
    Friend WithEvents PLDeduccionesTableAdapter As RSIContab.PLEdicionDeduccionesDataSetTableAdapters.PLDeduccionesTableAdapter
    Friend WithEvents StatusStripPrincipal As System.Windows.Forms.StatusStrip
    Friend WithEvents DataNavBarPrincipal As RSIContab.DataNavBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DefDeduccionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLDefinicionDeduccionesTableAdapter As RSIContab.PLEdicionDeduccionesDataSetTableAdapters.PLDefinicionDeduccionesTableAdapter
    Friend WithEvents c1cmbDeducciones As C1.Win.C1List.C1Combo
End Class
