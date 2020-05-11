<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TiposEmpleadosFrm
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
        Me.PLTiposEmpleadosDataSet = New RSIContab.PLTiposEmpleadosDataSet
        Me.PLTiposEmpleadosTableAdapter = New RSIContab.PLTiposEmpleadosDataSetTableAdapters.PLTiposEmpleadosTableAdapter
        Me.statusstripPrincipal = New System.Windows.Forms.StatusStrip
        Me.statusCerrado = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusImpreso = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusContabilizado = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusAnulado = New System.Windows.Forms.ToolStripStatusLabel
        Me.statuslblAñoMes = New System.Windows.Forms.ToolStripStatusLabel
        Me.DataNavBarPrincipal = New RSIContab.DataNavBar
        Me.c1txtDescripcion = New C1.Win.C1Input.C1TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.c1txtTiposEmpleados = New C1.Win.C1Input.C1TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLTiposEmpleadosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statusstripPrincipal.SuspendLayout()
        CType(Me.c1txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtTiposEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLTiposEmpleados"
        Me.PrincipalBindingSource.DataSource = Me.PLTiposEmpleadosDataSet
        '
        'PLTiposEmpleadosDataSet
        '
        Me.PLTiposEmpleadosDataSet.DataSetName = "PLTiposEmpleadosDataSet"
        Me.PLTiposEmpleadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLTiposEmpleadosTableAdapter
        '
        Me.PLTiposEmpleadosTableAdapter.ClearBeforeFill = True
        '
        'statusstripPrincipal
        '
        Me.statusstripPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusCerrado, Me.statusImpreso, Me.statusContabilizado, Me.statusAnulado, Me.statuslblAñoMes})
        Me.statusstripPrincipal.Location = New System.Drawing.Point(0, 108)
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
        'c1txtDescripcion
        '
        Me.c1txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "DescripcionTipoEmpleado", True))
        Me.c1txtDescripcion.Location = New System.Drawing.Point(88, 72)
        Me.c1txtDescripcion.Name = "c1txtDescripcion"
        Me.c1txtDescripcion.ReadOnly = True
        Me.c1txtDescripcion.Size = New System.Drawing.Size(289, 20)
        Me.c1txtDescripcion.TabIndex = 54
        Me.c1txtDescripcion.Tag = "CMO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Descripción:"
        '
        'c1txtTiposEmpleados
        '
        Me.c1txtTiposEmpleados.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "CodigoTipoEmpleado", True))
        Me.c1txtTiposEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtTiposEmpleados.Location = New System.Drawing.Point(87, 40)
        Me.c1txtTiposEmpleados.Name = "c1txtTiposEmpleados"
        Me.c1txtTiposEmpleados.ReadOnly = True
        Me.c1txtTiposEmpleados.Size = New System.Drawing.Size(145, 20)
        Me.c1txtTiposEmpleados.TabIndex = 53
        Me.c1txtTiposEmpleados.Tag = "CO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Código:"
        '
        'TiposEmpleadosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 130)
        Me.Controls.Add(Me.c1txtDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.c1txtTiposEmpleados)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataNavBarPrincipal)
        Me.Controls.Add(Me.statusstripPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "TiposEmpleadosFrm"
        Me.Text = "Tipos de Empleados"
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLTiposEmpleadosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statusstripPrincipal.ResumeLayout(False)
        Me.statusstripPrincipal.PerformLayout()
        CType(Me.c1txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtTiposEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLTiposEmpleadosDataSet As RSIContab.PLTiposEmpleadosDataSet
    Friend WithEvents PLTiposEmpleadosTableAdapter As RSIContab.PLTiposEmpleadosDataSetTableAdapters.PLTiposEmpleadosTableAdapter
    Friend WithEvents statusstripPrincipal As System.Windows.Forms.StatusStrip
    Friend WithEvents statusCerrado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusImpreso As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusContabilizado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusAnulado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statuslblAñoMes As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataNavBarPrincipal As RSIContab.DataNavBar
    Friend WithEvents c1txtDescripcion As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents c1txtTiposEmpleados As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
