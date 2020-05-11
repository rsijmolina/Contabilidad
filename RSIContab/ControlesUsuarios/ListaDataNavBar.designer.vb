<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaDataNavBar
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.ToolStripButtonNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonRecargar = New System.Windows.Forms.ToolStripButton()
        '  Me.ToolStripButtonEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabelBuscar = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBoxBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripBotones = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabelRegs = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabelNoRegistros = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripButtonNuevo
        '
        Me.ToolStripButtonNuevo.Image = Global.RSIContab.My.Resources.Resources._1393539332_Document_32x32
        Me.ToolStripButtonNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonNuevo.Name = "ToolStripButtonNuevo"
        Me.ToolStripButtonNuevo.Size = New System.Drawing.Size(46, 56)
        Me.ToolStripButtonNuevo.Text = "Nuevo"
        Me.ToolStripButtonNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButtonEditar
        '
        Me.ToolStripButtonEditar.Image = Global.RSIContab.My.Resources.Resources._1393539203_edit
        Me.ToolStripButtonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonEditar.Name = "ToolStripButtonEditar"
        Me.ToolStripButtonEditar.Size = New System.Drawing.Size(41, 56)
        Me.ToolStripButtonEditar.Text = "Editar"
        Me.ToolStripButtonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButtonConsultar
        '
        Me.ToolStripButtonConsultar.Image = Global.RSIContab.My.Resources.Resources.search_icon
        Me.ToolStripButtonConsultar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonConsultar.Name = "ToolStripButtonConsultar"
        Me.ToolStripButtonConsultar.Size = New System.Drawing.Size(62, 56)
        Me.ToolStripButtonConsultar.Text = "Consultar"
        Me.ToolStripButtonConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButtonRecargar
        '
        Me.ToolStripButtonRecargar.Image = Global.RSIContab.My.Resources.Resources._1393539549_gtk_refresh
        Me.ToolStripButtonRecargar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonRecargar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRecargar.Name = "ToolStripButtonRecargar"
        Me.ToolStripButtonRecargar.Size = New System.Drawing.Size(57, 56)
        Me.ToolStripButtonRecargar.Text = "Recargar"
        Me.ToolStripButtonRecargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButtonRecargar.ToolTipText = "Recargar Datos"
        '
        'ToolStripButtonEliminar
        '
        'Me.ToolStripButtonEliminar.Image = Global.RSIContab.My.Resources.Resources._1393551525_DeleteRed
        'Me.ToolStripButtonEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        'Me.ToolStripButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        'Me.ToolStripButtonEliminar.Name = "ToolStripButtonEliminar"
        'Me.ToolStripButtonEliminar.Size = New System.Drawing.Size(54, 56)
        'Me.ToolStripButtonEliminar.Text = "Eliminar"
        'Me.ToolStripButtonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        ''
        'ToolStripButtonSalir
        '
        Me.ToolStripButtonSalir.Image = Global.RSIContab.My.Resources.Resources._1393551019_Log_Out
        Me.ToolStripButtonSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonSalir.Name = "ToolStripButtonSalir"
        Me.ToolStripButtonSalir.Size = New System.Drawing.Size(36, 56)
        Me.ToolStripButtonSalir.Text = "Salir"
        Me.ToolStripButtonSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripLabelBuscar
        '
        Me.ToolStripLabelBuscar.Name = "ToolStripLabelBuscar"
        Me.ToolStripLabelBuscar.Size = New System.Drawing.Size(140, 56)
        Me.ToolStripLabelBuscar.Text = "Buscar Directamente Por:"
        '
        'ToolStripTextBoxBuscar
        '
        Me.ToolStripTextBoxBuscar.Name = "ToolStripTextBoxBuscar"
        Me.ToolStripTextBoxBuscar.Size = New System.Drawing.Size(100, 59)
        '
        'ToolStripBotones
        '
        Me.ToolStripBotones.AutoSize = False
        Me.ToolStripBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonNuevo, Me.ToolStripButtonEditar, Me.ToolStripButtonConsultar, Me.ToolStripButtonRecargar, Me.ToolStripButtonSalir, Me.ToolStripSeparator1, Me.ToolStripLabelBuscar, Me.ToolStripTextBoxBuscar, Me.ToolStripSeparator2, Me.ToolStripLabelRegs, Me.ToolStripLabelNoRegistros})
        'Me.ToolStripBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonNuevo, Me.ToolStripButtonEditar, Me.ToolStripButtonConsultar, Me.ToolStripButtonRecargar, Me.ToolStripButtonEliminar, Me.ToolStripButtonSalir, Me.ToolStripSeparator1, Me.ToolStripLabelBuscar, Me.ToolStripTextBoxBuscar, Me.ToolStripSeparator2, Me.ToolStripLabelRegs, Me.ToolStripLabelNoRegistros})
        Me.ToolStripBotones.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripBotones.Name = "ToolStripBotones"
        Me.ToolStripBotones.Size = New System.Drawing.Size(674, 59)
        Me.ToolStripBotones.TabIndex = 0
        Me.ToolStripBotones.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 59)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 59)
        '
        'ToolStripLabelRegs
        '
        Me.ToolStripLabelRegs.Name = "ToolStripLabelRegs"
        Me.ToolStripLabelRegs.Size = New System.Drawing.Size(80, 56)
        Me.ToolStripLabelRegs.Text = "No. Registros:"
        '
        'ToolStripLabelNoRegistros
        '
        Me.ToolStripLabelNoRegistros.Name = "ToolStripLabelNoRegistros"
        Me.ToolStripLabelNoRegistros.Size = New System.Drawing.Size(13, 56)
        Me.ToolStripLabelNoRegistros.Text = "0"
        '
        'ListaDataNavBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripBotones)
        Me.Name = "ListaDataNavBar"
        Me.Size = New System.Drawing.Size(674, 69)
        Me.ToolStripBotones.ResumeLayout(False)
        Me.ToolStripBotones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripButtonNuevo As ToolStripButton
    Friend WithEvents ToolStripButtonEditar As ToolStripButton
    Friend WithEvents ToolStripButtonConsultar As ToolStripButton
    Friend WithEvents ToolStripButtonRecargar As ToolStripButton
    ' Friend WithEvents ToolStripButtonEliminar As ToolStripButton
    Friend WithEvents ToolStripButtonSalir As ToolStripButton
    Friend WithEvents ToolStripLabelBuscar As ToolStripLabel
    Friend WithEvents ToolStripTextBoxBuscar As ToolStripTextBox
    Friend WithEvents ToolStripBotones As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabelRegs As ToolStripLabel
    Friend WithEvents ToolStripLabelNoRegistros As ToolStripLabel
End Class
