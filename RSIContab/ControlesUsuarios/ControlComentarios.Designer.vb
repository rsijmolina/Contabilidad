<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlComentarios
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
        Me.txtComentarios = New System.Windows.Forms.TextBox()
        Me.toolstripComentarios = New System.Windows.Forms.ToolStrip()
        Me.toolstripbutGuardar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripButModificar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbutDeshacer = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbutEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstriplabelUsuario = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstriplabelFecha = New System.Windows.Forms.ToolStripLabel()
        Me.toolstripComentarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtComentarios
        '
        Me.txtComentarios.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtComentarios.Location = New System.Drawing.Point(0, 28)
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentarios.Size = New System.Drawing.Size(219, 122)
        Me.txtComentarios.TabIndex = 5
        '
        'toolstripComentarios
        '
        Me.toolstripComentarios.BackColor = System.Drawing.Color.LightSlateGray
        Me.toolstripComentarios.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripbutGuardar, Me.toolstripButModificar, Me.toolstripbutDeshacer, Me.toolstripbutEliminar, Me.ToolStripSeparator1, Me.toolstriplabelUsuario, Me.ToolStripSeparator2, Me.toolstriplabelFecha})
        Me.toolstripComentarios.Location = New System.Drawing.Point(0, 0)
        Me.toolstripComentarios.Name = "toolstripComentarios"
        Me.toolstripComentarios.Size = New System.Drawing.Size(220, 25)
        Me.toolstripComentarios.TabIndex = 6
        '
        'toolstripbutGuardar
        '
        Me.toolstripbutGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutGuardar.Image = Global.RSIContab.My.Resources.Resources.saveHS
        Me.toolstripbutGuardar.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutGuardar.Name = "toolstripbutGuardar"
        Me.toolstripbutGuardar.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutGuardar.Tag = ""
        Me.toolstripbutGuardar.Text = "Guardar"
        Me.toolstripbutGuardar.ToolTipText = "Guardar Comentario"
        '
        'toolstripButModificar
        '
        Me.toolstripButModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripButModificar.Image = Global.RSIContab.My.Resources.Resources.EditInformationHS
        Me.toolstripButModificar.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripButModificar.Name = "toolstripButModificar"
        Me.toolstripButModificar.Size = New System.Drawing.Size(23, 22)
        Me.toolstripButModificar.Text = "Modificar"
        Me.toolstripButModificar.ToolTipText = "Modificar Comentario"
        '
        'toolstripbutDeshacer
        '
        Me.toolstripbutDeshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutDeshacer.Image = Global.RSIContab.My.Resources.Resources.Edit_UndoHS
        Me.toolstripbutDeshacer.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutDeshacer.Name = "toolstripbutDeshacer"
        Me.toolstripbutDeshacer.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutDeshacer.Text = "ToolStripButton1"
        Me.toolstripbutDeshacer.ToolTipText = "Cancelar"
        '
        'toolstripbutEliminar
        '
        Me.toolstripbutEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutEliminar.Image = Global.RSIContab.My.Resources.Resources.DeleteHS
        Me.toolstripbutEliminar.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutEliminar.Name = "toolstripbutEliminar"
        Me.toolstripbutEliminar.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutEliminar.Text = "Eliminar"
        Me.toolstripbutEliminar.ToolTipText = "Eliminar Comentario"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'toolstriplabelUsuario
        '
        Me.toolstriplabelUsuario.ForeColor = System.Drawing.Color.White
        Me.toolstriplabelUsuario.Name = "toolstriplabelUsuario"
        Me.toolstriplabelUsuario.Size = New System.Drawing.Size(47, 22)
        Me.toolstriplabelUsuario.Text = "Usuario"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'toolstriplabelFecha
        '
        Me.toolstriplabelFecha.ForeColor = System.Drawing.Color.White
        Me.toolstriplabelFecha.Name = "toolstriplabelFecha"
        Me.toolstriplabelFecha.Size = New System.Drawing.Size(38, 22)
        Me.toolstriplabelFecha.Text = "Fecha"
        '
        'ControlComentarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.toolstripComentarios)
        Me.Controls.Add(Me.txtComentarios)
        Me.Name = "ControlComentarios"
        Me.Size = New System.Drawing.Size(220, 154)
        Me.toolstripComentarios.ResumeLayout(False)
        Me.toolstripComentarios.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtComentarios As System.Windows.Forms.TextBox
    Friend WithEvents toolstripComentarios As System.Windows.Forms.ToolStrip
    Friend WithEvents toolstripbutGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripButModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolstriplabelUsuario As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolstriplabelFecha As System.Windows.Forms.ToolStripLabel
    Friend WithEvents toolstripbutDeshacer As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbutEliminar As System.Windows.Forms.ToolStripButton

End Class
