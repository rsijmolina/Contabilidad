<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListasFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListasFrm))
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.toolstripListas = New System.Windows.Forms.ToolStrip
        Me.toolstripbutRefrescar = New System.Windows.Forms.ToolStripButton
        Me.c1dbgrdListas = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.toolstripListas.SuspendLayout()
        CType(Me.c1dbgrdListas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(262, 307)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(81, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.Location = New System.Drawing.Point(49, 307)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(79, 23)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'toolstripListas
        '
        Me.toolstripListas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripbutRefrescar})
        Me.toolstripListas.Location = New System.Drawing.Point(0, 0)
        Me.toolstripListas.Name = "toolstripListas"
        Me.toolstripListas.Size = New System.Drawing.Size(391, 25)
        Me.toolstripListas.TabIndex = 8
        Me.toolstripListas.Text = "ToolStrip1"
        '
        'toolstripbutRefrescar
        '
        Me.toolstripbutRefrescar.Image = Global.RSIContab.My.Resources.Resources.RefreshDocViewHS
        Me.toolstripbutRefrescar.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutRefrescar.Name = "toolstripbutRefrescar"
        Me.toolstripbutRefrescar.Size = New System.Drawing.Size(99, 22)
        Me.toolstripbutRefrescar.Text = "Refrescar Lista"
        '
        'c1dbgrdListas
        '
        Me.c1dbgrdListas.AllowUpdate = False
        Me.c1dbgrdListas.AlternatingRows = True
        Me.c1dbgrdListas.BackColor = System.Drawing.SystemColors.Control
        Me.c1dbgrdListas.FilterBar = True
        Me.c1dbgrdListas.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbgrdListas.Images.Add(CType(resources.GetObject("c1dbgrdListas.Images"), System.Drawing.Image))
        Me.c1dbgrdListas.Location = New System.Drawing.Point(0, 28)
        Me.c1dbgrdListas.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.c1dbgrdListas.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None
        Me.c1dbgrdListas.Name = "c1dbgrdListas"
        Me.c1dbgrdListas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbgrdListas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbgrdListas.PreviewInfo.ZoomFactor = 75
        Me.c1dbgrdListas.PrintInfo.PageSettings = CType(resources.GetObject("c1dbgrdListas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1dbgrdListas.RowHeight = 16
        Me.c1dbgrdListas.Size = New System.Drawing.Size(393, 273)
        Me.c1dbgrdListas.TabIndex = 9
        Me.c1dbgrdListas.PropBag = resources.GetString("c1dbgrdListas.PropBag")
        '
        'ListasFrm
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(391, 335)
        Me.Controls.Add(Me.c1dbgrdListas)
        Me.Controls.Add(Me.toolstripListas)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ListasFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listas"
        Me.toolstripListas.ResumeLayout(False)
        Me.toolstripListas.PerformLayout()
        CType(Me.c1dbgrdListas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents toolstripListas As System.Windows.Forms.ToolStrip
    Friend WithEvents toolstripbutRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents c1dbgrdListas As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
