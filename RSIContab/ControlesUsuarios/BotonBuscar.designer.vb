<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BotonBuscar
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BotonBuscar))
        Me.imglstBuscar = New System.Windows.Forms.ImageList(Me.components)
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'imglstBuscar
        '
        Me.imglstBuscar.ImageStream = CType(resources.GetObject("imglstBuscar.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglstBuscar.TransparentColor = System.Drawing.Color.Transparent
        Me.imglstBuscar.Images.SetKeyName(0, "zoom2.bmp")
        Me.imglstBuscar.Images.SetKeyName(1, "zoom.bmp")
        '
        'btnBuscar
        '
        Me.btnBuscar.AutoSize = True
        Me.btnBuscar.ImageIndex = 1
        Me.btnBuscar.ImageList = Me.imglstBuscar
        Me.btnBuscar.Location = New System.Drawing.Point(0, 0)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(23, 22)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'BotonBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnBuscar)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "BotonBuscar"
        Me.Size = New System.Drawing.Size(27, 23)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imglstBuscar As System.Windows.Forms.ImageList
    Friend WithEvents btnBuscar As System.Windows.Forms.Button

End Class
