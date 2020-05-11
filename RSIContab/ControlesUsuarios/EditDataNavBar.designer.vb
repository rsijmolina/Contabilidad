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
        ' Me.ToolStripButtonEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripBotones
        '
        Me.ToolStripBotones.AutoSize = False
        ' Me.ToolStripBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonGuardar, Me.ToolStripButtonEliminar, Me.ToolStripButtonSalir})
        Me.ToolStripBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonGuardar, Me.ToolStripButtonSalir})
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
        'ToolStripButtonEliminar
        '
        ' Me.ToolStripButtonEliminar.Image = Global.RSIContab.My.Resources.Resources._1393551525_DeleteRed
        'Me.ToolStripButtonEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        'Me.ToolStripButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        'Me.ToolStripButtonEliminar.Name = "ToolStripButtonEliminar"
        'Me.ToolStripButtonEliminar.Size = New System.Drawing.Size(54, 55)
        'Me.ToolStripButtonEliminar.Text = "Eliminar"
        'Me.ToolStripButtonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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

End Class
