<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditDataNavBar
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
        Me.ToolStripBotones = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButCerrarDocumento = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripBotones
        '
        Me.ToolStripBotones.AutoSize = False
        Me.ToolStripBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonGuardar, Me.ToolStripButCerrarDocumento, Me.ToolStripButtonSalir})
        Me.ToolStripBotones.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripBotones.Name = "ToolStripBotones"
        Me.ToolStripBotones.Size = New System.Drawing.Size(401, 58)
        Me.ToolStripBotones.TabIndex = 1
        Me.ToolStripBotones.Text = "ToolStrip1"
        '
        'ToolStripButtonGuardar
        '
        Me.ToolStripButtonGuardar.Image = Global.RSIContab.My.Resources.Resources._1393539679_04_Save_32x32
        Me.ToolStripButtonGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonGuardar.Name = "ToolStripButtonGuardar"
        Me.ToolStripButtonGuardar.Size = New System.Drawing.Size(53, 55)
        Me.ToolStripButtonGuardar.Text = "Guardar"
        Me.ToolStripButtonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButtonGuardar.ToolTipText = "Recargar Datos"
        '
        'ToolStripButtonSalir
        '
        Me.ToolStripButtonSalir.Image = Global.RSIContab.My.Resources.Resources._1393551019_Log_Out
        Me.ToolStripButtonSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonSalir.Name = "ToolStripButtonSalir"
        Me.ToolStripButtonSalir.Size = New System.Drawing.Size(36, 55)
        Me.ToolStripButtonSalir.Text = "Salir"
        Me.ToolStripButtonSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButCerrarDocumento
        '
        Me.ToolStripButCerrarDocumento.Image = Global.RSIContab.My.Resources.Resources.checklist_icon3
        Me.ToolStripButCerrarDocumento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButCerrarDocumento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButCerrarDocumento.Name = "ToolStripButCerrarDocumento"
        Me.ToolStripButCerrarDocumento.Size = New System.Drawing.Size(70, 55)
        Me.ToolStripButCerrarDocumento.Text = "Cerrar Doc."
        Me.ToolStripButCerrarDocumento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButCerrarDocumento.ToolTipText = "Cerrar Documento"
        '
        'EditDataNavBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripBotones)
        Me.Name = "EditDataNavBar"
        Me.Size = New System.Drawing.Size(401, 66)
        Me.ToolStripBotones.ResumeLayout(False)
        Me.ToolStripBotones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripBotones As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonGuardar As System.Windows.Forms.ToolStripButton
    ' Friend WithEvents ToolStripButtonEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButCerrarDocumento As ToolStripButton
End Class
