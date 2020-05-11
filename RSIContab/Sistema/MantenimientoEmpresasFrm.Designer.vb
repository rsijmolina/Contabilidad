<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MantenimientoEmpresasFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MantenimientoEmpresasFrm))
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseDatosDataSet = New RSIContab.BaseDatosDataSet()
        Me.DBTableAdapter = New RSIContab.BaseDatosDataSetTableAdapters.DBTableAdapter()
        Me.statusstripPrincipal = New System.Windows.Forms.StatusStrip()
        Me.statusCerrado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusImpreso = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusContabilizado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusAnulado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statuslblAñoMes = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DataNavBarPrincipal = New RSIContab.DataNavBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkboxEmpresaConsolidacion = New System.Windows.Forms.CheckBox()
        Me.c1txtNombre1 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox1 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox2 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox3 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox4 = New C1.Win.C1Input.C1TextBox()
        Me.chkboxDesactivada = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkboxAutWindows = New System.Windows.Forms.CheckBox()
        Me.btnConfClave = New System.Windows.Forms.Button()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statusstripPrincipal.SuspendLayout()
        CType(Me.c1txtNombre1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "DB"
        Me.PrincipalBindingSource.DataSource = Me.BaseDatosDataSet
        '
        'BaseDatosDataSet
        '
        Me.BaseDatosDataSet.DataSetName = "BaseDatosDataSet"
        Me.BaseDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DBTableAdapter
        '
        Me.DBTableAdapter.ClearBeforeFill = True
        '
        'statusstripPrincipal
        '
        Me.statusstripPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusCerrado, Me.statusImpreso, Me.statusContabilizado, Me.statusAnulado, Me.statuslblAñoMes})
        Me.statusstripPrincipal.Location = New System.Drawing.Point(0, 307)
        Me.statusstripPrincipal.Name = "statusstripPrincipal"
        Me.statusstripPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.statusstripPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.statusstripPrincipal.Size = New System.Drawing.Size(496, 22)
        Me.statusstripPrincipal.TabIndex = 51
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
        'DataNavBarPrincipal
        '
        Me.DataNavBarPrincipal.BarraDeEstado = Me.statusstripPrincipal
        Me.DataNavBarPrincipal.BindingSourcePrincipal = Me.PrincipalBindingSource
        Me.DataNavBarPrincipal.dbgrdDetalle = Nothing
        Me.DataNavBarPrincipal.Editando = False
        Me.DataNavBarPrincipal.EjecutarAntesCancelar = False
        Me.DataNavBarPrincipal.EjecutarAntesEliminar = False
        Me.DataNavBarPrincipal.EjecutarAntesGrabar = True
        Me.DataNavBarPrincipal.EjecutarAntesModificar = True
        Me.DataNavBarPrincipal.EjecutarAntesNuevo = False
        Me.DataNavBarPrincipal.EjecutarAntesSalir = False
        Me.DataNavBarPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.DataNavBarPrincipal.ModalidadDeshabilitadoTotal = False
        Me.DataNavBarPrincipal.ModalidadSoloLectura = False
        Me.DataNavBarPrincipal.ModificarRegistro = False
        Me.DataNavBarPrincipal.MostrarListaInvPermanente = False
        Me.DataNavBarPrincipal.Name = "DataNavBarPrincipal"
        Me.DataNavBarPrincipal.NuevoRegistro = False
        Me.DataNavBarPrincipal.ResultadoValidacion = Nothing
        Me.DataNavBarPrincipal.Size = New System.Drawing.Size(505, 31)
        Me.DataNavBarPrincipal.TabIndex = 52
        Me.DataNavBarPrincipal.TieneDetalle = True
        Me.DataNavBarPrincipal.UltimaLinDet = CType(0, Short)
        Me.DataNavBarPrincipal.UsarBotonAnularRegistro = False
        Me.DataNavBarPrincipal.UsarBotonCancelar = True
        Me.DataNavBarPrincipal.UsarBotonCerrarDocumento = False
        Me.DataNavBarPrincipal.UsarBotonComentarios = False
        Me.DataNavBarPrincipal.UsarBotonContabilizar = False
        Me.DataNavBarPrincipal.UsarBotonDocumentacion = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "ID:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrincipalBindingSource, "ID", True))
        Me.lblID.Location = New System.Drawing.Point(40, 34)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(39, 13)
        Me.lblID.TabIndex = 54
        Me.lblID.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Nombre de la Empresa:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Base de Datos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Nombre del Servidor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Instancia:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Registro Tributario:"
        '
        'chkboxEmpresaConsolidacion
        '
        Me.chkboxEmpresaConsolidacion.AutoSize = True
        Me.chkboxEmpresaConsolidacion.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PrincipalBindingSource, "EmpresaConsolidación", True))
        Me.chkboxEmpresaConsolidacion.Location = New System.Drawing.Point(135, 194)
        Me.chkboxEmpresaConsolidacion.Name = "chkboxEmpresaConsolidacion"
        Me.chkboxEmpresaConsolidacion.Size = New System.Drawing.Size(137, 17)
        Me.chkboxEmpresaConsolidacion.TabIndex = 61
        Me.chkboxEmpresaConsolidacion.Text = "Empresa Consolidadora"
        Me.chkboxEmpresaConsolidacion.UseVisualStyleBackColor = True
        '
        'c1txtNombre1
        '
        Me.c1txtNombre1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "NombreEmpresa", True))
        Me.c1txtNombre1.Location = New System.Drawing.Point(135, 60)
        Me.c1txtNombre1.Name = "c1txtNombre1"
        Me.c1txtNombre1.ReadOnly = True
        Me.c1txtNombre1.Size = New System.Drawing.Size(342, 20)
        Me.c1txtNombre1.TabIndex = 62
        Me.c1txtNombre1.Tag = "CMO"
        '
        'C1TextBox1
        '
        Me.C1TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "RegistroTributario", True))
        Me.C1TextBox1.Location = New System.Drawing.Point(135, 87)
        Me.C1TextBox1.Name = "C1TextBox1"
        Me.C1TextBox1.ReadOnly = True
        Me.C1TextBox1.Size = New System.Drawing.Size(265, 20)
        Me.C1TextBox1.TabIndex = 63
        Me.C1TextBox1.Tag = "CMO"
        '
        'C1TextBox2
        '
        Me.C1TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "Servidor", True))
        Me.C1TextBox2.Location = New System.Drawing.Point(135, 113)
        Me.C1TextBox2.Name = "C1TextBox2"
        Me.C1TextBox2.ReadOnly = True
        Me.C1TextBox2.Size = New System.Drawing.Size(265, 20)
        Me.C1TextBox2.TabIndex = 64
        Me.C1TextBox2.Tag = "CMO"
        '
        'C1TextBox3
        '
        Me.C1TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "Instancia", True))
        Me.C1TextBox3.Location = New System.Drawing.Point(135, 142)
        Me.C1TextBox3.Name = "C1TextBox3"
        Me.C1TextBox3.ReadOnly = True
        Me.C1TextBox3.Size = New System.Drawing.Size(182, 20)
        Me.C1TextBox3.TabIndex = 65
        Me.C1TextBox3.Tag = "CMO"
        '
        'C1TextBox4
        '
        Me.C1TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "BaseDatos", True))
        Me.C1TextBox4.Location = New System.Drawing.Point(135, 168)
        Me.C1TextBox4.Name = "C1TextBox4"
        Me.C1TextBox4.ReadOnly = True
        Me.C1TextBox4.Size = New System.Drawing.Size(182, 20)
        Me.C1TextBox4.TabIndex = 66
        Me.C1TextBox4.Tag = "CMO"
        '
        'chkboxDesactivada
        '
        Me.chkboxDesactivada.AutoSize = True
        Me.chkboxDesactivada.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PrincipalBindingSource, "Desactivada", True))
        Me.chkboxDesactivada.Location = New System.Drawing.Point(316, 194)
        Me.chkboxDesactivada.Name = "chkboxDesactivada"
        Me.chkboxDesactivada.Size = New System.Drawing.Size(130, 17)
        Me.chkboxDesactivada.TabIndex = 67
        Me.chkboxDesactivada.Text = "Empresa Desactivada"
        Me.chkboxDesactivada.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnConfClave)
        Me.GroupBox1.Controls.Add(Me.chkboxAutWindows)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 227)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 60)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seguridad"
        '
        'chkboxAutWindows
        '
        Me.chkboxAutWindows.AutoSize = True
        Me.chkboxAutWindows.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PrincipalBindingSource, "WindowsAut", True))
        Me.chkboxAutWindows.Location = New System.Drawing.Point(6, 25)
        Me.chkboxAutWindows.Name = "chkboxAutWindows"
        Me.chkboxAutWindows.Size = New System.Drawing.Size(153, 17)
        Me.chkboxAutWindows.TabIndex = 60
        Me.chkboxAutWindows.Text = "Autenticación de Windows"
        Me.chkboxAutWindows.UseVisualStyleBackColor = True
        '
        'btnConfClave
        '
        Me.btnConfClave.Enabled = False
        Me.btnConfClave.Location = New System.Drawing.Point(273, 15)
        Me.btnConfClave.Name = "btnConfClave"
        Me.btnConfClave.Size = New System.Drawing.Size(177, 34)
        Me.btnConfClave.TabIndex = 61
        Me.btnConfClave.Tag = "HABILITARNOEDIT"
        Me.btnConfClave.Text = "Configurar Usuario y Clave"
        Me.btnConfClave.UseVisualStyleBackColor = True
        '
        'MantenimientoEmpresasFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 329)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkboxDesactivada)
        Me.Controls.Add(Me.C1TextBox4)
        Me.Controls.Add(Me.C1TextBox3)
        Me.Controls.Add(Me.C1TextBox2)
        Me.Controls.Add(Me.C1TextBox1)
        Me.Controls.Add(Me.c1txtNombre1)
        Me.Controls.Add(Me.chkboxEmpresaConsolidacion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataNavBarPrincipal)
        Me.Controls.Add(Me.statusstripPrincipal)
        Me.Name = "MantenimientoEmpresasFrm"
        Me.Text = "Mantenimientode de Empresas"
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statusstripPrincipal.ResumeLayout(False)
        Me.statusstripPrincipal.PerformLayout()
        CType(Me.c1txtNombre1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BaseDatosDataSet As RSIContab.BaseDatosDataSet
    Friend WithEvents DBTableAdapter As RSIContab.BaseDatosDataSetTableAdapters.DBTableAdapter
    Friend WithEvents statusstripPrincipal As System.Windows.Forms.StatusStrip
    Friend WithEvents statusCerrado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusImpreso As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusContabilizado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusAnulado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statuslblAñoMes As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataNavBarPrincipal As RSIContab.DataNavBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkboxEmpresaConsolidacion As System.Windows.Forms.CheckBox
    Friend WithEvents c1txtNombre1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox4 As C1.Win.C1Input.C1TextBox
    Friend WithEvents chkboxDesactivada As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkboxAutWindows As System.Windows.Forms.CheckBox
    Friend WithEvents btnConfClave As System.Windows.Forms.Button
End Class
