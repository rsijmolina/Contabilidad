<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTCatalogoFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CTCatalogoFrm))
        Me.toostripCatalogo = New System.Windows.Forms.ToolStrip()
        Me.toolstripbutNuevo = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbutGrabar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbutCancelar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbutModificar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbutEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstripbutCambiarCuenta = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbuttonSaldos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstripbutSalir = New System.Windows.Forms.ToolStripButton()
        Me.treeviewCatalogo = New System.Windows.Forms.TreeView()
        Me.imglstCat = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblNaturaleza = New System.Windows.Forms.Label()
        Me.c1txtDescripcion = New C1.Win.C1Input.C1TextBox()
        Me.c1txtCuentaSuperior = New C1.Win.C1Input.C1TextBox()
        Me.c1txtCuenta = New C1.Win.C1Input.C1TextBox()
        Me.c1numNivel = New C1.Win.C1Input.C1NumericEdit()
        Me.chkboxPosteable = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.statusstripPrincipal = New System.Windows.Forms.StatusStrip()
        Me.statusCerrado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusImpreso = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusContabilizado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusAnulado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statuslblAñoMes = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTCatalogoCuentasDataSet = New RSIContab.CTCatalogoCuentasDataSet()
        Me.CTCatalogoCuentasTableAdapter = New RSIContab.CTCatalogoCuentasDataSetTableAdapters.CTCatalogoCuentasTableAdapter()
        Me.toostripCatalogo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtCuentaSuperior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numNivel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statusstripPrincipal.SuspendLayout()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTCatalogoCuentasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toostripCatalogo
        '
        Me.toostripCatalogo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.toostripCatalogo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripbutNuevo, Me.toolstripbutGrabar, Me.toolstripbutCancelar, Me.toolstripbutModificar, Me.toolstripbutEliminar, Me.ToolStripSeparator1, Me.toolstripbutCambiarCuenta, Me.toolstripbuttonSaldos, Me.ToolStripSeparator2, Me.toolstripbutSalir})
        Me.toostripCatalogo.Location = New System.Drawing.Point(0, 0)
        Me.toostripCatalogo.Name = "toostripCatalogo"
        Me.toostripCatalogo.Size = New System.Drawing.Size(601, 25)
        Me.toostripCatalogo.TabIndex = 0
        '
        'toolstripbutNuevo
        '
        Me.toolstripbutNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutNuevo.Enabled = False
        Me.toolstripbutNuevo.Image = Global.RSIContab.My.Resources.Resources.DataContainer_NewRecordHS
        Me.toolstripbutNuevo.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutNuevo.Name = "toolstripbutNuevo"
        Me.toolstripbutNuevo.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutNuevo.Text = "Nueva Cuenta"
        '
        'toolstripbutGrabar
        '
        Me.toolstripbutGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutGrabar.Enabled = False
        Me.toolstripbutGrabar.Image = Global.RSIContab.My.Resources.Resources.saveHS
        Me.toolstripbutGrabar.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutGrabar.Name = "toolstripbutGrabar"
        Me.toolstripbutGrabar.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutGrabar.Text = "Grabar Datos"
        '
        'toolstripbutCancelar
        '
        Me.toolstripbutCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutCancelar.Enabled = False
        Me.toolstripbutCancelar.Image = Global.RSIContab.My.Resources.Resources.Edit_UndoHS
        Me.toolstripbutCancelar.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutCancelar.Name = "toolstripbutCancelar"
        Me.toolstripbutCancelar.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutCancelar.Text = "Cancelar"
        '
        'toolstripbutModificar
        '
        Me.toolstripbutModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutModificar.Enabled = False
        Me.toolstripbutModificar.Image = Global.RSIContab.My.Resources.Resources.EditInformationHS
        Me.toolstripbutModificar.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutModificar.Name = "toolstripbutModificar"
        Me.toolstripbutModificar.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutModificar.Text = "Modificar Cuenta"
        Me.toolstripbutModificar.ToolTipText = "Modificar Cuenta"
        '
        'toolstripbutEliminar
        '
        Me.toolstripbutEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutEliminar.Enabled = False
        Me.toolstripbutEliminar.Image = Global.RSIContab.My.Resources.Resources.DeleteHS
        Me.toolstripbutEliminar.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutEliminar.Name = "toolstripbutEliminar"
        Me.toolstripbutEliminar.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutEliminar.Text = "Eliminar Cuenta"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'toolstripbutCambiarCuenta
        '
        Me.toolstripbutCambiarCuenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutCambiarCuenta.Enabled = False
        Me.toolstripbutCambiarCuenta.Image = Global.RSIContab.My.Resources.Resources.EntityDataModel_association_32x32
        Me.toolstripbutCambiarCuenta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripbutCambiarCuenta.Name = "toolstripbutCambiarCuenta"
        Me.toolstripbutCambiarCuenta.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutCambiarCuenta.Text = "Cambiar Cuenta"
        Me.toolstripbutCambiarCuenta.Visible = False
        '
        'toolstripbuttonSaldos
        '
        Me.toolstripbuttonSaldos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbuttonSaldos.Enabled = False
        Me.toolstripbuttonSaldos.Image = Global.RSIContab.My.Resources.Resources.Webcontrol_Catalogzone
        Me.toolstripbuttonSaldos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripbuttonSaldos.Name = "toolstripbuttonSaldos"
        Me.toolstripbuttonSaldos.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbuttonSaldos.Text = "Saldos de la Cuenta"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'treeviewCatalogo
        '
        Me.treeviewCatalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.treeviewCatalogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.treeviewCatalogo.HotTracking = True
        Me.treeviewCatalogo.ImageIndex = 0
        Me.treeviewCatalogo.ImageList = Me.imglstCat
        Me.treeviewCatalogo.Location = New System.Drawing.Point(10, 137)
        Me.treeviewCatalogo.Name = "treeviewCatalogo"
        Me.treeviewCatalogo.SelectedImageIndex = 0
        Me.treeviewCatalogo.ShowNodeToolTips = True
        Me.treeviewCatalogo.Size = New System.Drawing.Size(579, 408)
        Me.treeviewCatalogo.TabIndex = 1
        '
        'imglstCat
        '
        Me.imglstCat.ImageStream = CType(resources.GetObject("imglstCat.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglstCat.TransparentColor = System.Drawing.Color.Transparent
        Me.imglstCat.Images.SetKeyName(0, "LibroAbierto")
        Me.imglstCat.Images.SetKeyName(1, "LibroCerrado")
        Me.imglstCat.Images.SetKeyName(2, "SubCtaCerrada")
        Me.imglstCat.Images.SetKeyName(3, "Hoja")
        Me.imglstCat.Images.SetKeyName(4, "Seleccionado")
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblTipo)
        Me.GroupBox1.Controls.Add(Me.lblNaturaleza)
        Me.GroupBox1.Controls.Add(Me.c1txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.c1txtCuentaSuperior)
        Me.GroupBox1.Controls.Add(Me.c1txtCuenta)
        Me.GroupBox1.Controls.Add(Me.c1numNivel)
        Me.GroupBox1.Controls.Add(Me.chkboxPosteable)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(579, 102)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(301, 78)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(14, 13)
        Me.lblTipo.TabIndex = 64
        Me.lblTipo.Text = "T"
        Me.lblTipo.Visible = False
        '
        'lblNaturaleza
        '
        Me.lblNaturaleza.AutoSize = True
        Me.lblNaturaleza.Location = New System.Drawing.Point(270, 78)
        Me.lblNaturaleza.Name = "lblNaturaleza"
        Me.lblNaturaleza.Size = New System.Drawing.Size(15, 13)
        Me.lblNaturaleza.TabIndex = 63
        Me.lblNaturaleza.Text = "N"
        Me.lblNaturaleza.Visible = False
        '
        'c1txtDescripcion
        '
        Me.c1txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtDescripcion.Location = New System.Drawing.Point(83, 43)
        Me.c1txtDescripcion.Name = "c1txtDescripcion"
        Me.c1txtDescripcion.ReadOnly = True
        Me.c1txtDescripcion.Size = New System.Drawing.Size(427, 20)
        Me.c1txtDescripcion.TabIndex = 62
        Me.c1txtDescripcion.Tag = Nothing
        '
        'c1txtCuentaSuperior
        '
        Me.c1txtCuentaSuperior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtCuentaSuperior.Location = New System.Drawing.Point(345, 17)
        Me.c1txtCuentaSuperior.Name = "c1txtCuentaSuperior"
        Me.c1txtCuentaSuperior.ReadOnly = True
        Me.c1txtCuentaSuperior.Size = New System.Drawing.Size(165, 20)
        Me.c1txtCuentaSuperior.TabIndex = 61
        Me.c1txtCuentaSuperior.Tag = Nothing
        '
        'c1txtCuenta
        '
        Me.c1txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtCuenta.Location = New System.Drawing.Point(82, 15)
        Me.c1txtCuenta.Name = "c1txtCuenta"
        Me.c1txtCuenta.ReadOnly = True
        Me.c1txtCuenta.Size = New System.Drawing.Size(165, 20)
        Me.c1txtCuenta.TabIndex = 60
        Me.c1txtCuenta.Tag = Nothing
        '
        'c1numNivel
        '
        Me.c1numNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numNivel.Location = New System.Drawing.Point(82, 72)
        Me.c1numNivel.Name = "c1numNivel"
        Me.c1numNivel.ReadOnly = True
        Me.c1numNivel.Size = New System.Drawing.Size(22, 20)
        Me.c1numNivel.TabIndex = 47
        Me.c1numNivel.Tag = Nothing
        Me.c1numNivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numNivel.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'chkboxPosteable
        '
        Me.chkboxPosteable.AutoSize = True
        Me.chkboxPosteable.Enabled = False
        Me.chkboxPosteable.Location = New System.Drawing.Point(138, 74)
        Me.chkboxPosteable.Name = "chkboxPosteable"
        Me.chkboxPosteable.Size = New System.Drawing.Size(110, 17)
        Me.chkboxPosteable.TabIndex = 28
        Me.chkboxPosteable.Text = "Cuenta Posteable"
        Me.chkboxPosteable.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nivel:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Descripción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(253, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cuenta Superior:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cuenta:"
        '
        'statusstripPrincipal
        '
        Me.statusstripPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusCerrado, Me.statusImpreso, Me.statusContabilizado, Me.statusAnulado, Me.statuslblAñoMes})
        Me.statusstripPrincipal.Location = New System.Drawing.Point(0, 557)
        Me.statusstripPrincipal.Name = "statusstripPrincipal"
        Me.statusstripPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.statusstripPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.statusstripPrincipal.Size = New System.Drawing.Size(601, 22)
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
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "CTCatalogoCuentas"
        Me.PrincipalBindingSource.DataSource = Me.CTCatalogoCuentasDataSet
        '
        'CTCatalogoCuentasDataSet
        '
        Me.CTCatalogoCuentasDataSet.DataSetName = "CTCatalogoCuentasDataSet"
        Me.CTCatalogoCuentasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CTCatalogoCuentasTableAdapter
        '
        Me.CTCatalogoCuentasTableAdapter.ClearBeforeFill = True
        '
        'CTCatalogoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 579)
        Me.Controls.Add(Me.statusstripPrincipal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.treeviewCatalogo)
        Me.Controls.Add(Me.toostripCatalogo)
        Me.MaximizeBox = False
        Me.Name = "CTCatalogoFrm"
        Me.Text = "Catálogo de Cuentas"
        Me.toostripCatalogo.ResumeLayout(False)
        Me.toostripCatalogo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtCuentaSuperior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numNivel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statusstripPrincipal.ResumeLayout(False)
        Me.statusstripPrincipal.PerformLayout()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTCatalogoCuentasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toostripCatalogo As System.Windows.Forms.ToolStrip
    Friend WithEvents toolstripbutNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents treeviewCatalogo As System.Windows.Forms.TreeView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkboxPosteable As System.Windows.Forms.CheckBox
    Friend WithEvents statusstripPrincipal As System.Windows.Forms.StatusStrip
    Friend WithEvents statusCerrado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusImpreso As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusContabilizado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusAnulado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statuslblAñoMes As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTCatalogoCuentasDataSet As RSIContab.CTCatalogoCuentasDataSet
    Friend WithEvents CTCatalogoCuentasTableAdapter As RSIContab.CTCatalogoCuentasDataSetTableAdapters.CTCatalogoCuentasTableAdapter
    Friend WithEvents imglstCat As System.Windows.Forms.ImageList
    Friend WithEvents toolstripbutModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbutEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolstripbutCambiarCuenta As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbuttonSaldos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolstripbutSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents c1numNivel As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1txtCuenta As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtDescripcion As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtCuentaSuperior As C1.Win.C1Input.C1TextBox
    Friend WithEvents toolstripbutGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbutCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblNaturaleza As System.Windows.Forms.Label
End Class
