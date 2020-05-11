<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SedesFrm
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
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLSedesDataSet = New RSIContab.PLSedesDataSet
        Me.PLSedesTableAdapter = New RSIContab.PLSedesDataSetTableAdapters.PLSedesTableAdapter
        Me.statusstripPrincipal = New System.Windows.Forms.StatusStrip
        Me.statusCerrado = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusImpreso = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusContabilizado = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusAnulado = New System.Windows.Forms.ToolStripStatusLabel
        Me.statuslblAñoMes = New System.Windows.Forms.ToolStripStatusLabel
        Me.DataNavBarPrincipal = New RSIContab.DataNavBar
        Me.c1txtDescripcion = New C1.Win.C1Input.C1TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.c1txtCodigoSede = New C1.Win.C1Input.C1TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.chkDeducirSeguroSocial = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.C1NumericEdit1 = New C1.Win.C1Input.C1NumericEdit
        Me.c1numPorcDescuento = New C1.Win.C1Input.C1NumericEdit
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.C1NumericEdit3 = New C1.Win.C1Input.C1NumericEdit
        Me.C1NumericEdit2 = New C1.Win.C1Input.C1NumericEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLSedesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statusstripPrincipal.SuspendLayout()
        CType(Me.c1txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtCodigoSede, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1NumericEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numPorcDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.C1NumericEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLSedes"
        Me.PrincipalBindingSource.DataSource = Me.PLSedesDataSet
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
        'statusstripPrincipal
        '
        Me.statusstripPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusCerrado, Me.statusImpreso, Me.statusContabilizado, Me.statusAnulado, Me.statuslblAñoMes})
        Me.statusstripPrincipal.Location = New System.Drawing.Point(0, 239)
        Me.statusstripPrincipal.Name = "statusstripPrincipal"
        Me.statusstripPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.statusstripPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.statusstripPrincipal.Size = New System.Drawing.Size(510, 22)
        Me.statusstripPrincipal.TabIndex = 47
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
        Me.DataNavBarPrincipal.Size = New System.Drawing.Size(509, 31)
        Me.DataNavBarPrincipal.TabIndex = 48
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
        'c1txtDescripcion
        '
        Me.c1txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DescripcionSede", True))
        Me.c1txtDescripcion.Location = New System.Drawing.Point(85, 69)
        Me.c1txtDescripcion.Name = "c1txtDescripcion"
        Me.c1txtDescripcion.ReadOnly = True
        Me.c1txtDescripcion.Size = New System.Drawing.Size(289, 20)
        Me.c1txtDescripcion.TabIndex = 2
        Me.c1txtDescripcion.Tag = "CMO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Descripción:"
        '
        'c1txtCodigoSede
        '
        Me.c1txtCodigoSede.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "CodigoSede", True))
        Me.c1txtCodigoSede.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtCodigoSede.Location = New System.Drawing.Point(84, 37)
        Me.c1txtCodigoSede.Name = "c1txtCodigoSede"
        Me.c1txtCodigoSede.ReadOnly = True
        Me.c1txtCodigoSede.Size = New System.Drawing.Size(145, 20)
        Me.c1txtCodigoSede.TabIndex = 1
        Me.c1txtCodigoSede.Tag = "CO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Código:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Porcentaje:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Máximo a Deducir:"
        '
        'chkDeducirSeguroSocial
        '
        Me.chkDeducirSeguroSocial.AutoSize = True
        Me.chkDeducirSeguroSocial.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PrincipalBindingSource, "DeducirSS", True))
        Me.chkDeducirSeguroSocial.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PrincipalBindingSource, "DeducirSS", True))
        Me.chkDeducirSeguroSocial.Enabled = False
        Me.chkDeducirSeguroSocial.Location = New System.Drawing.Point(6, 19)
        Me.chkDeducirSeguroSocial.Name = "chkDeducirSeguroSocial"
        Me.chkDeducirSeguroSocial.Size = New System.Drawing.Size(132, 17)
        Me.chkDeducirSeguroSocial.TabIndex = 3
        Me.chkDeducirSeguroSocial.Text = "Deducir Seguro Social"
        Me.chkDeducirSeguroSocial.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.C1NumericEdit1)
        Me.GroupBox1.Controls.Add(Me.c1numPorcDescuento)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 73)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deducción General"
        '
        'C1NumericEdit1
        '
        Me.C1NumericEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionMaxSS", True))
        Me.C1NumericEdit1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.C1NumericEdit1.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.C1NumericEdit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NumericEdit1.Location = New System.Drawing.Point(110, 40)
        Me.C1NumericEdit1.Name = "C1NumericEdit1"
        Me.C1NumericEdit1.ReadOnly = True
        Me.C1NumericEdit1.Size = New System.Drawing.Size(59, 20)
        Me.C1NumericEdit1.TabIndex = 5
        Me.C1NumericEdit1.Tag = "CM"
        Me.C1NumericEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.C1NumericEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numPorcDescuento
        '
        Me.c1numPorcDescuento.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "PorcentajeSS", True))
        Me.c1numPorcDescuento.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.c1numPorcDescuento.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numPorcDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numPorcDescuento.Location = New System.Drawing.Point(110, 16)
        Me.c1numPorcDescuento.Name = "c1numPorcDescuento"
        Me.c1numPorcDescuento.ReadOnly = True
        Me.c1numPorcDescuento.Size = New System.Drawing.Size(59, 20)
        Me.c1numPorcDescuento.TabIndex = 4
        Me.c1numPorcDescuento.Tag = "CM"
        Me.c1numPorcDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numPorcDescuento.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.C1NumericEdit3)
        Me.GroupBox2.Controls.Add(Me.C1NumericEdit2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(205, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(187, 73)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Deducción Docente"
        '
        'C1NumericEdit3
        '
        Me.C1NumericEdit3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DeduccionMaxDocenteSS", True))
        Me.C1NumericEdit3.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.C1NumericEdit3.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.C1NumericEdit3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NumericEdit3.Location = New System.Drawing.Point(113, 40)
        Me.C1NumericEdit3.Name = "C1NumericEdit3"
        Me.C1NumericEdit3.ReadOnly = True
        Me.C1NumericEdit3.Size = New System.Drawing.Size(59, 20)
        Me.C1NumericEdit3.TabIndex = 7
        Me.C1NumericEdit3.Tag = "CM"
        Me.C1NumericEdit3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.C1NumericEdit3.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1NumericEdit2
        '
        Me.C1NumericEdit2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "PorcentajeDocenteSS", True))
        Me.C1NumericEdit2.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.C1NumericEdit2.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.C1NumericEdit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NumericEdit2.Location = New System.Drawing.Point(113, 13)
        Me.C1NumericEdit2.Name = "C1NumericEdit2"
        Me.C1NumericEdit2.ReadOnly = True
        Me.C1NumericEdit2.Size = New System.Drawing.Size(59, 20)
        Me.C1NumericEdit2.TabIndex = 6
        Me.C1NumericEdit2.Tag = "CM"
        Me.C1NumericEdit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.C1NumericEdit2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Porcentaje:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Máximo a Deducir:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkDeducirSeguroSocial)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 100)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(479, 126)
        Me.GroupBox3.TabIndex = 57
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Deducción del Seguro Social"
        '
        'SedesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 261)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.c1txtDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.c1txtCodigoSede)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataNavBarPrincipal)
        Me.Controls.Add(Me.statusstripPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "SedesFrm"
        Me.Text = "Sedes"
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLSedesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statusstripPrincipal.ResumeLayout(False)
        Me.statusstripPrincipal.PerformLayout()
        CType(Me.c1txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtCodigoSede, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.C1NumericEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numPorcDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.C1NumericEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLSedesDataSet As RSIContab.PLSedesDataSet
    Friend WithEvents PLSedesTableAdapter As RSIContab.PLSedesDataSetTableAdapters.PLSedesTableAdapter
    Friend WithEvents statusstripPrincipal As System.Windows.Forms.StatusStrip
    Friend WithEvents statusCerrado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusImpreso As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusContabilizado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusAnulado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statuslblAñoMes As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataNavBarPrincipal As RSIContab.DataNavBar
    Friend WithEvents c1txtDescripcion As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents c1txtCodigoSede As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkDeducirSeguroSocial As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents C1NumericEdit1 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numPorcDescuento As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit3 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit2 As C1.Win.C1Input.C1NumericEdit
End Class
