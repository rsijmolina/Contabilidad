<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BAConfFrm
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
        Me.C1NumericEdit1 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1TextBox1 = New C1.Win.C1Input.C1TextBox()
        CType(Me.C1NumericEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1NumericEdit1
        '
        Me.C1NumericEdit1.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NumericEdit1.Location = New System.Drawing.Point(70, 35)
        Me.C1NumericEdit1.Name = "C1NumericEdit1"
        Me.C1NumericEdit1.Size = New System.Drawing.Size(200, 18)
        Me.C1NumericEdit1.TabIndex = 0
        Me.C1NumericEdit1.Tag = Nothing
        '
        'C1TextBox1
        '
        Me.C1TextBox1.Location = New System.Drawing.Point(95, 111)
        Me.C1TextBox1.Name = "C1TextBox1"
        Me.C1TextBox1.Size = New System.Drawing.Size(100, 18)
        Me.C1TextBox1.TabIndex = 1
        Me.C1TextBox1.Tag = Nothing
        '
        'BAConfFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.C1TextBox1)
        Me.Controls.Add(Me.C1NumericEdit1)
        Me.Name = "BAConfFrm"
        Me.Text = "BAConfFrm"
        CType(Me.C1NumericEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1NumericEdit1 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1TextBox1 As C1.Win.C1Input.C1TextBox
End Class
