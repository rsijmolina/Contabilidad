<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlCambioCodigoFrm
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
        Me.lblBuscar = New System.Windows.Forms.Label
        Me.c1txtCodigoEmpleado = New C1.Win.C1Input.C1TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.c1txtNuevoCodigo = New C1.Win.C1Input.C1TextBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnBuscarEmpleado = New RSIContab.BotonBuscar
        CType(Me.c1txtCodigoEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtNuevoCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(274, 15)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 62
        Me.lblBuscar.Text = "Buscar"
        Me.lblBuscar.Visible = False
        '
        'c1txtCodigoEmpleado
        '
        Me.c1txtCodigoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtCodigoEmpleado.Location = New System.Drawing.Point(66, 12)
        Me.c1txtCodigoEmpleado.Name = "c1txtCodigoEmpleado"
        Me.c1txtCodigoEmpleado.Size = New System.Drawing.Size(122, 20)
        Me.c1txtCodigoEmpleado.TabIndex = 59
        Me.c1txtCodigoEmpleado.Tag = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Código:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(63, 46)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(10, 13)
        Me.lblNombre.TabIndex = 64
        Me.lblNombre.Text = "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Nuevo Código:"
        '
        'c1txtNuevoCodigo
        '
        Me.c1txtNuevoCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtNuevoCodigo.Location = New System.Drawing.Point(93, 77)
        Me.c1txtNuevoCodigo.Name = "c1txtNuevoCodigo"
        Me.c1txtNuevoCodigo.Size = New System.Drawing.Size(122, 20)
        Me.c1txtNuevoCodigo.TabIndex = 67
        Me.c1txtNuevoCodigo.Tag = Nothing
        Me.c1txtNuevoCodigo.TrimStart = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(37, 121)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(96, 31)
        Me.btnAceptar.TabIndex = 68
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(218, 121)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(96, 31)
        Me.btnCancelar.TabIndex = 69
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnBuscarEmpleado
        '
        Me.btnBuscarEmpleado.ControlEnlazado = Nothing
        Me.btnBuscarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarEmpleado.Enabled = False
        Me.btnBuscarEmpleado.Location = New System.Drawing.Point(188, 10)
        Me.btnBuscarEmpleado.Name = "btnBuscarEmpleado"
        Me.btnBuscarEmpleado.Size = New System.Drawing.Size(23, 23)
        Me.btnBuscarEmpleado.TabIndex = 60
        Me.btnBuscarEmpleado.Tag = "HABILITARNOEDIT"
        '
        'PlCambioCodigoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 164)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.c1txtNuevoCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnBuscarEmpleado)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.c1txtCodigoEmpleado)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PlCambioCodigoFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Código de Empleado"
        CType(Me.c1txtCodigoEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtNuevoCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscarEmpleado As RSIContab.BotonBuscar
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents c1txtCodigoEmpleado As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents c1txtNuevoCodigo As C1.Win.C1Input.C1TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
