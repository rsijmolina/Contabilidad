<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTListaCatalogoFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CTListaCatalogoFrm))
        Me.treeviewCatalogo = New System.Windows.Forms.TreeView()
        Me.imglstCat = New System.Windows.Forms.ImageList(Me.components)
        Me.toolstripListas = New System.Windows.Forms.ToolStrip()
        Me.toolstripbutRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.butAceptar = New System.Windows.Forms.Button()
        Me.butCancelar = New System.Windows.Forms.Button()
        Me.toolstripListas.SuspendLayout()
        Me.SuspendLayout()
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
        Me.treeviewCatalogo.Location = New System.Drawing.Point(3, 30)
        Me.treeviewCatalogo.Name = "treeviewCatalogo"
        Me.treeviewCatalogo.SelectedImageIndex = 0
        Me.treeviewCatalogo.ShowNodeToolTips = True
        Me.treeviewCatalogo.Size = New System.Drawing.Size(435, 408)
        Me.treeviewCatalogo.TabIndex = 2
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
        'toolstripListas
        '
        Me.toolstripListas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.toolstripListas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripbutRefrescar})
        Me.toolstripListas.Location = New System.Drawing.Point(0, 0)
        Me.toolstripListas.Name = "toolstripListas"
        Me.toolstripListas.Size = New System.Drawing.Size(441, 25)
        Me.toolstripListas.TabIndex = 13
        Me.toolstripListas.Text = "ToolStrip1"
        '
        'toolstripbutRefrescar
        '
        Me.toolstripbutRefrescar.Image = Global.RSIContab.My.Resources.Resources.RefreshDocViewHS
        Me.toolstripbutRefrescar.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutRefrescar.Name = "toolstripbutRefrescar"
        Me.toolstripbutRefrescar.Size = New System.Drawing.Size(102, 22)
        Me.toolstripbutRefrescar.Text = "Refrescar Lista"
        '
        'butAceptar
        '
        Me.butAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.butAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.butAceptar.Location = New System.Drawing.Point(41, 445)
        Me.butAceptar.Name = "butAceptar"
        Me.butAceptar.Size = New System.Drawing.Size(107, 33)
        Me.butAceptar.TabIndex = 14
        Me.butAceptar.Text = "&Aceptar"
        Me.butAceptar.UseVisualStyleBackColor = True
        '
        'butCancelar
        '
        Me.butCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butCancelar.Location = New System.Drawing.Point(293, 445)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(107, 33)
        Me.butCancelar.TabIndex = 15
        Me.butCancelar.Text = "&Cancelar"
        Me.butCancelar.UseVisualStyleBackColor = True
        '
        'CTListaCatalogoFrm
        '
        Me.AcceptButton = Me.butAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.butCancelar
        Me.ClientSize = New System.Drawing.Size(441, 490)
        Me.Controls.Add(Me.butCancelar)
        Me.Controls.Add(Me.butAceptar)
        Me.Controls.Add(Me.toolstripListas)
        Me.Controls.Add(Me.treeviewCatalogo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CTListaCatalogoFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista del Catálogo de Cuentas"
        Me.toolstripListas.ResumeLayout(False)
        Me.toolstripListas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents treeviewCatalogo As System.Windows.Forms.TreeView
    Friend WithEvents toolstripListas As System.Windows.Forms.ToolStrip
    Friend WithEvents toolstripbutRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents butAceptar As System.Windows.Forms.Button
    Friend WithEvents butCancelar As System.Windows.Forms.Button
    Friend WithEvents imglstCat As System.Windows.Forms.ImageList
End Class
