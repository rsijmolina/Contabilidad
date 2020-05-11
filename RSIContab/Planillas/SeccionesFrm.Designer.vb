<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeccionesFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeccionesFrm))
        Me.statusstripPrincipal = New System.Windows.Forms.StatusStrip
        Me.statusCerrado = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusImpreso = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusContabilizado = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusAnulado = New System.Windows.Forms.ToolStripStatusLabel
        Me.statuslblAñoMes = New System.Windows.Forms.ToolStripStatusLabel
        Me.c1dbgrdGrupos = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.SeccionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLSeccionesDataSet = New RSIContab.PLSeccionesDataSet
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblDepartamento = New System.Windows.Forms.Label
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblSede = New System.Windows.Forms.Label
        Me.SedesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblCodigoDepartamento = New System.Windows.Forms.Label
        Me.lblCodigoSede = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PLSeccionesTableAdapter = New RSIContab.PLSeccionesDataSetTableAdapters.PLSeccionesTableAdapter
        Me.PLSedesTableAdapter = New RSIContab.PLSeccionesDataSetTableAdapters.PLSedesTableAdapter
        Me.PLDepartamentosTableAdapter = New RSIContab.PLSeccionesDataSetTableAdapters.PLDepartamentosTableAdapter
        Me.DataNavBarPrincipal = New RSIContab.DataNavBar
        Me.statusstripPrincipal.SuspendLayout()
        CType(Me.c1dbgrdGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeccionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLSeccionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SedesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'statusstripPrincipal
        '
        Me.statusstripPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusCerrado, Me.statusImpreso, Me.statusContabilizado, Me.statusAnulado, Me.statuslblAñoMes})
        Me.statusstripPrincipal.Location = New System.Drawing.Point(0, 327)
        Me.statusstripPrincipal.Name = "statusstripPrincipal"
        Me.statusstripPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.statusstripPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.statusstripPrincipal.Size = New System.Drawing.Size(509, 22)
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
        'c1dbgrdGrupos
        '
        Me.c1dbgrdGrupos.AllowAddNew = True
        Me.c1dbgrdGrupos.AllowDelete = True
        Me.c1dbgrdGrupos.DataSource = Me.SeccionesBindingSource
        Me.c1dbgrdGrupos.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbgrdGrupos.Images.Add(CType(resources.GetObject("c1dbgrdGrupos.Images"), System.Drawing.Image))
        Me.c1dbgrdGrupos.Location = New System.Drawing.Point(57, 106)
        Me.c1dbgrdGrupos.Name = "c1dbgrdGrupos"
        Me.c1dbgrdGrupos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbgrdGrupos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbgrdGrupos.PreviewInfo.ZoomFactor = 75
        Me.c1dbgrdGrupos.PrintInfo.PageSettings = CType(resources.GetObject("c1dbgrdGrupos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1dbgrdGrupos.RowHeight = 17
        Me.c1dbgrdGrupos.Size = New System.Drawing.Size(390, 206)
        Me.c1dbgrdGrupos.TabIndex = 51
        Me.c1dbgrdGrupos.Text = "C1TrueDBGrid1"
        Me.c1dbgrdGrupos.PropBag = resources.GetString("c1dbgrdGrupos.PropBag")
        '
        'SeccionesBindingSource
        '
        Me.SeccionesBindingSource.DataMember = "PLSecciones"
        Me.SeccionesBindingSource.DataSource = Me.PLSeccionesDataSet
        '
        'PLSeccionesDataSet
        '
        Me.PLSeccionesDataSet.DataSetName = "PLSeccionesDataSet"
        Me.PLSeccionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDepartamento)
        Me.GroupBox1.Controls.Add(Me.lblSede)
        Me.GroupBox1.Controls.Add(Me.lblCodigoDepartamento)
        Me.GroupBox1.Controls.Add(Me.lblCodigoSede)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(482, 63)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        '
        'lblDepartamento
        '
        Me.lblDepartamento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrincipalBindingSource, "DescripcionDepartamento", True))
        Me.lblDepartamento.Location = New System.Drawing.Point(149, 38)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(261, 13)
        Me.lblDepartamento.TabIndex = 20
        Me.lblDepartamento.Text = "Label4"
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLDepartamentos"
        Me.PrincipalBindingSource.DataSource = Me.PLSeccionesDataSet
        '
        'lblSede
        '
        Me.lblSede.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SedesBindingSource, "DescripcionSede", True))
        Me.lblSede.Location = New System.Drawing.Point(149, 16)
        Me.lblSede.Name = "lblSede"
        Me.lblSede.Size = New System.Drawing.Size(261, 13)
        Me.lblSede.TabIndex = 19
        Me.lblSede.Text = "Label3"
        '
        'SedesBindingSource
        '
        Me.SedesBindingSource.DataMember = "PLSedes"
        Me.SedesBindingSource.DataSource = Me.PLSeccionesDataSet
        '
        'lblCodigoDepartamento
        '
        Me.lblCodigoDepartamento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrincipalBindingSource, "CodigoDepartamento", True))
        Me.lblCodigoDepartamento.Location = New System.Drawing.Point(54, 38)
        Me.lblCodigoDepartamento.Name = "lblCodigoDepartamento"
        Me.lblCodigoDepartamento.Size = New System.Drawing.Size(89, 13)
        Me.lblCodigoDepartamento.TabIndex = 18
        Me.lblCodigoDepartamento.Text = "Label4"
        '
        'lblCodigoSede
        '
        Me.lblCodigoSede.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrincipalBindingSource, "CodigoSede", True))
        Me.lblCodigoSede.Location = New System.Drawing.Point(54, 16)
        Me.lblCodigoSede.Name = "lblCodigoSede"
        Me.lblCodigoSede.Size = New System.Drawing.Size(89, 13)
        Me.lblCodigoSede.TabIndex = 17
        Me.lblCodigoSede.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Depto.:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Sede:"
        '
        'PLSeccionesTableAdapter
        '
        Me.PLSeccionesTableAdapter.ClearBeforeFill = True
        '
        'PLSedesTableAdapter
        '
        Me.PLSedesTableAdapter.ClearBeforeFill = True
        '
        'PLDepartamentosTableAdapter
        '
        Me.PLDepartamentosTableAdapter.ClearBeforeFill = True
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
        Me.DataNavBarPrincipal.Size = New System.Drawing.Size(508, 31)
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
        'SeccionesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 349)
        Me.Controls.Add(Me.c1dbgrdGrupos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataNavBarPrincipal)
        Me.Controls.Add(Me.statusstripPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "SeccionesFrm"
        Me.Text = "Secciones"
        Me.statusstripPrincipal.ResumeLayout(False)
        Me.statusstripPrincipal.PerformLayout()
        CType(Me.c1dbgrdGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeccionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLSeccionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SedesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLSeccionesDataSet As RSIContab.PLSeccionesDataSet
    Friend WithEvents PLSeccionesTableAdapter As RSIContab.PLSeccionesDataSetTableAdapters.PLSeccionesTableAdapter
    Friend WithEvents SedesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLSedesTableAdapter As RSIContab.PLSeccionesDataSetTableAdapters.PLSedesTableAdapter
    Friend WithEvents PLDepartamentosTableAdapter As RSIContab.PLSeccionesDataSetTableAdapters.PLDepartamentosTableAdapter
    Friend WithEvents statusstripPrincipal As System.Windows.Forms.StatusStrip
    Friend WithEvents statusCerrado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusImpreso As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusContabilizado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusAnulado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statuslblAñoMes As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataNavBarPrincipal As RSIContab.DataNavBar
    Friend WithEvents c1dbgrdGrupos As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents lblSede As System.Windows.Forms.Label
    Friend WithEvents lblCodigoDepartamento As System.Windows.Forms.Label
    Friend WithEvents lblCodigoSede As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SeccionesBindingSource As System.Windows.Forms.BindingSource
End Class
