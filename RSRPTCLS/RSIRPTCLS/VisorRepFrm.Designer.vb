<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisorRepFrm
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
        Me.RepVisor = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'RepVisor
        '
        Me.RepVisor.ActiveViewIndex = -1
        Me.RepVisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RepVisor.Cursor = System.Windows.Forms.Cursors.Default
        Me.RepVisor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RepVisor.Location = New System.Drawing.Point(0, 0)
        Me.RepVisor.Name = "RepVisor"
        'Me.RepVisor.SelectionFormula = ""
        Me.RepVisor.Size = New System.Drawing.Size(701, 481)
        Me.RepVisor.TabIndex = 0
        Me.RepVisor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        'Me.RepVisor.ViewTimeSelectionFormula = ""
        '
        'VisorRepFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 481)
        Me.Controls.Add(Me.RepVisor)
        Me.Name = "VisorRepFrm"
        Me.Text = "Reporte"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RepVisor As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
