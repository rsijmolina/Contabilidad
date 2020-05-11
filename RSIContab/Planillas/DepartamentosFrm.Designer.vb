<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepartamentosFrm
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
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DepartamentosFrm))
        Dim Style6 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Dim Style7 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Dim Style8 As C1.Win.C1List.Style = New C1.Win.C1List.Style
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLDepartamentosDataSet = New RSIContab.PLDepartamentosDataSet
        Me.PLDepartamentosTableAdapter = New RSIContab.PLDepartamentosDataSetTableAdapters.PLDepartamentosTableAdapter
        Me.statusstripPrincipal = New System.Windows.Forms.StatusStrip
        Me.statusCerrado = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusImpreso = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusContabilizado = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusAnulado = New System.Windows.Forms.ToolStripStatusLabel
        Me.statuslblAñoMes = New System.Windows.Forms.ToolStripStatusLabel
        Me.c1cmbSedes = New C1.Win.C1List.C1Combo
        Me.SedesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.c1txtCodigoDepto = New C1.Win.C1Input.C1TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.c1txtDescripcion = New C1.Win.C1Input.C1TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PLSedesDataSet = New RSIContab.PLSedesDataSet
        Me.PLSedesTableAdapter = New RSIContab.PLDepartamentosDataSetTableAdapters.PLSedesTableAdapter
        Me.DataNavBarPrincipal = New RSIContab.DataNavBar
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLDepartamentosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statusstripPrincipal.SuspendLayout()
        CType(Me.c1cmbSedes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SedesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtCodigoDepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLSedesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLDepartamentos"
        Me.PrincipalBindingSource.DataSource = Me.PLDepartamentosDataSet
        '
        'PLDepartamentosDataSet
        '
        Me.PLDepartamentosDataSet.DataSetName = "PLDepartamentosDataSet"
        Me.PLDepartamentosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLDepartamentosTableAdapter
        '
        Me.PLDepartamentosTableAdapter.ClearBeforeFill = True
        '
        'statusstripPrincipal
        '
        Me.statusstripPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusCerrado, Me.statusImpreso, Me.statusContabilizado, Me.statusAnulado, Me.statuslblAñoMes})
        Me.statusstripPrincipal.Location = New System.Drawing.Point(0, 140)
        Me.statusstripPrincipal.Name = "statusstripPrincipal"
        Me.statusstripPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.statusstripPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.statusstripPrincipal.Size = New System.Drawing.Size(514, 22)
        Me.statusstripPrincipal.TabIndex = 48
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
        'c1cmbSedes
        '
        Me.c1cmbSedes.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.c1cmbSedes.AlternatingRows = True
        Me.c1cmbSedes.Caption = ""
        Me.c1cmbSedes.CaptionHeight = 17
        Me.c1cmbSedes.CaptionStyle = Style1
        Me.c1cmbSedes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.c1cmbSedes.ColumnCaptionHeight = 17
        Me.c1cmbSedes.ColumnFooterHeight = 17
        Me.c1cmbSedes.ContentHeight = 15
        Me.c1cmbSedes.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PrincipalBindingSource, "CodigoSede", True))
        Me.c1cmbSedes.DataSource = Me.SedesBindingSource
        Me.c1cmbSedes.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.c1cmbSedes.DisplayMember = "DescripcionSede"
        Me.c1cmbSedes.EditorBackColor = System.Drawing.SystemColors.Window
        Me.c1cmbSedes.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1cmbSedes.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.c1cmbSedes.EditorHeight = 15
        Me.c1cmbSedes.EvenRowStyle = Style2
        Me.c1cmbSedes.FooterStyle = Style3
        Me.c1cmbSedes.HeadingStyle = Style4
        Me.c1cmbSedes.HighLightRowStyle = Style5
        Me.c1cmbSedes.Images.Add(CType(resources.GetObject("c1cmbSedes.Images"), System.Drawing.Image))
        Me.c1cmbSedes.ItemHeight = 15
        Me.c1cmbSedes.LimitToList = True
        Me.c1cmbSedes.Location = New System.Drawing.Point(132, 96)
        Me.c1cmbSedes.MatchEntryTimeout = CType(2000, Long)
        Me.c1cmbSedes.MaxDropDownItems = CType(5, Short)
        Me.c1cmbSedes.MaxLength = 32767
        Me.c1cmbSedes.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.c1cmbSedes.Name = "c1cmbSedes"
        Me.c1cmbSedes.OddRowStyle = Style6
        Me.c1cmbSedes.ReadOnly = True
        Me.c1cmbSedes.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.c1cmbSedes.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.c1cmbSedes.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.c1cmbSedes.SelectedStyle = Style7
        Me.c1cmbSedes.Size = New System.Drawing.Size(289, 21)
        Me.c1cmbSedes.Style = Style8
        Me.c1cmbSedes.TabIndex = 3
        Me.c1cmbSedes.Tag = "CM"
        Me.c1cmbSedes.ValueMember = "CodigoSede"
        Me.c1cmbSedes.PropBag = resources.GetString("c1cmbSedes.PropBag")
        '
        'SedesBindingSource
        '
        Me.SedesBindingSource.DataMember = "PLSedes"
        Me.SedesBindingSource.DataSource = Me.PLDepartamentosDataSet
        '
        'c1txtCodigoDepto
        '
        Me.c1txtCodigoDepto.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "CodigoDepartamento", True))
        Me.c1txtCodigoDepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtCodigoDepto.Location = New System.Drawing.Point(132, 41)
        Me.c1txtCodigoDepto.Name = "c1txtCodigoDepto"
        Me.c1txtCodigoDepto.ReadOnly = True
        Me.c1txtCodigoDepto.Size = New System.Drawing.Size(145, 20)
        Me.c1txtCodigoDepto.TabIndex = 1
        Me.c1txtCodigoDepto.Tag = "CO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Código de Depto.:"
        '
        'c1txtDescripcion
        '
        Me.c1txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DescripcionDepartamento", True))
        Me.c1txtDescripcion.Location = New System.Drawing.Point(132, 70)
        Me.c1txtDescripcion.Name = "c1txtDescripcion"
        Me.c1txtDescripcion.ReadOnly = True
        Me.c1txtDescripcion.Size = New System.Drawing.Size(289, 20)
        Me.c1txtDescripcion.TabIndex = 2
        Me.c1txtDescripcion.Tag = "CMO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Sede:"
        '
        'PLSedesDataSet
        '
        Me.PLSedesDataSet.DataSetName = "PLSedesDataSet"
        Me.PLSedesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLSedesTableAdapter
        '
        Me.PLSedesTableAdapter.ClearBeforeFill = True
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
        Me.DataNavBarPrincipal.Size = New System.Drawing.Size(513, 31)
        Me.DataNavBarPrincipal.TabIndex = 49
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
        'DepartamentosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 162)
        Me.Controls.Add(Me.c1cmbSedes)
        Me.Controls.Add(Me.c1txtCodigoDepto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.c1txtDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataNavBarPrincipal)
        Me.Controls.Add(Me.statusstripPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "DepartamentosFrm"
        Me.ShowInTaskbar = False
        Me.Text = "Departamentos"
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLDepartamentosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statusstripPrincipal.ResumeLayout(False)
        Me.statusstripPrincipal.PerformLayout()
        CType(Me.c1cmbSedes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SedesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtCodigoDepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLSedesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLDepartamentosDataSet As RSIContab.PLDepartamentosDataSet
    Friend WithEvents PLDepartamentosTableAdapter As RSIContab.PLDepartamentosDataSetTableAdapters.PLDepartamentosTableAdapter
    Friend WithEvents statusstripPrincipal As System.Windows.Forms.StatusStrip
    Friend WithEvents statusCerrado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusImpreso As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusContabilizado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusAnulado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statuslblAñoMes As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataNavBarPrincipal As RSIContab.DataNavBar
    Friend WithEvents c1cmbSedes As C1.Win.C1List.C1Combo
    Friend WithEvents c1txtCodigoDepto As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents c1txtDescripcion As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SedesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLSedesDataSet As RSIContab.PLSedesDataSet
    Friend WithEvents PLSedesTableAdapter As RSIContab.PLDepartamentosDataSetTableAdapters.PLSedesTableAdapter
End Class
