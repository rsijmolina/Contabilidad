<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTTransaccionesComentariosFrm
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
        Me.ComentariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTComentariosDataSet = New RSIContab.CTComentariosDataSet()
        Me.CTTransaccionesComentariosTableAdapter = New RSIContab.CTComentariosDataSetTableAdapters.CTTransaccionesComentariosTableAdapter()
        Me.toolstripPrincipal = New System.Windows.Forms.ToolStrip()
        Me.toolstripbutNuevo = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbutCerrar = New System.Windows.Forms.ToolStripButton()
        Me.flowlayoutComentarios = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.ComentariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTComentariosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComentariosBindingSource
        '
        Me.ComentariosBindingSource.DataMember = "CTTransaccionesComentarios"
        Me.ComentariosBindingSource.DataSource = Me.CTComentariosDataSet
        '
        'CTComentariosDataSet
        '
        Me.CTComentariosDataSet.DataSetName = "CTComentariosDataSet"
        Me.CTComentariosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CTTransaccionesComentariosTableAdapter
        '
        Me.CTTransaccionesComentariosTableAdapter.ClearBeforeFill = True
        '
        'toolstripPrincipal
        '
        Me.toolstripPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripbutNuevo, Me.toolstripbutCerrar})
        Me.toolstripPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.toolstripPrincipal.Name = "toolstripPrincipal"
        Me.toolstripPrincipal.Size = New System.Drawing.Size(251, 25)
        Me.toolstripPrincipal.TabIndex = 1
        Me.toolstripPrincipal.Text = "ToolStrip1"
        '
        'toolstripbutNuevo
        '
        Me.toolstripbutNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutNuevo.Image = Global.RSIContab.My.Resources.Resources.DataContainer_NewRecordHS
        Me.toolstripbutNuevo.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutNuevo.Name = "toolstripbutNuevo"
        Me.toolstripbutNuevo.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutNuevo.Text = "Nuevo Comentario"
        '
        'toolstripbutCerrar
        '
        Me.toolstripbutCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutCerrar.Image = Global.RSIContab.My.Resources.Resources.CriticalError
        Me.toolstripbutCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripbutCerrar.Name = "toolstripbutCerrar"
        Me.toolstripbutCerrar.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutCerrar.Text = "Cerrar"
        '
        'flowlayoutComentarios
        '
        Me.flowlayoutComentarios.AutoScroll = True
        Me.flowlayoutComentarios.Location = New System.Drawing.Point(0, 28)
        Me.flowlayoutComentarios.Name = "flowlayoutComentarios"
        Me.flowlayoutComentarios.Size = New System.Drawing.Size(248, 33)
        Me.flowlayoutComentarios.TabIndex = 2
        '
        'CTTransaccionesComentariosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(251, 65)
        Me.ControlBox = False
        Me.Controls.Add(Me.flowlayoutComentarios)
        Me.Controls.Add(Me.toolstripPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CTTransaccionesComentariosFrm"
        Me.Text = "Comentarios"
        Me.TopMost = True
        CType(Me.ComentariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTComentariosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripPrincipal.ResumeLayout(False)
        Me.toolstripPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComentariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTComentariosDataSet As RSIContab.CTComentariosDataSet
    Friend WithEvents CTTransaccionesComentariosTableAdapter As RSIContab.CTComentariosDataSetTableAdapters.CTTransaccionesComentariosTableAdapter
    Friend WithEvents toolstripPrincipal As System.Windows.Forms.ToolStrip
    Friend WithEvents flowlayoutComentarios As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents toolstripbutNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbutCerrar As System.Windows.Forms.ToolStripButton
End Class
