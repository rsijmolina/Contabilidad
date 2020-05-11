<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLMantAtlantidaFrm
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
        Me.dbgrdEmps = New System.Windows.Forms.DataGridView()
        Me.CodigoEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAgregarEmpleado = New System.Windows.Forms.Button()
        Me.btnAgregarTodosEmpleados = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigoEmpresa = New System.Windows.Forms.TextBox()
        Me.dlgGuardarArchivo = New System.Windows.Forms.SaveFileDialog()
        CType(Me.dbgrdEmps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dbgrdEmps
        '
        Me.dbgrdEmps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbgrdEmps.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoEmpleado, Me.Nombre, Me.Cuenta, Me.Identidad, Me.Tipo})
        Me.dbgrdEmps.Location = New System.Drawing.Point(12, 50)
        Me.dbgrdEmps.Name = "dbgrdEmps"
        Me.dbgrdEmps.Size = New System.Drawing.Size(652, 385)
        Me.dbgrdEmps.TabIndex = 0
        '
        'CodigoEmpleado
        '
        Me.CodigoEmpleado.DataPropertyName = "Codigo"
        Me.CodigoEmpleado.HeaderText = "Código"
        Me.CodigoEmpleado.Name = "CodigoEmpleado"
        Me.CodigoEmpleado.ReadOnly = True
        Me.CodigoEmpleado.Width = 90
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 230
        '
        'Cuenta
        '
        Me.Cuenta.DataPropertyName = "Cuenta"
        Me.Cuenta.HeaderText = "Cuenta"
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.ReadOnly = True
        '
        'Identidad
        '
        Me.Identidad.DataPropertyName = "Identidad"
        Me.Identidad.HeaderText = "Identidad"
        Me.Identidad.Name = "Identidad"
        Me.Identidad.ReadOnly = True
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Items.AddRange(New Object() {"A", "M", "E"})
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Width = 60
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(51, 441)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(111, 30)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(509, 441)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(111, 30)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAgregarEmpleado
        '
        Me.btnAgregarEmpleado.Location = New System.Drawing.Point(12, 12)
        Me.btnAgregarEmpleado.Name = "btnAgregarEmpleado"
        Me.btnAgregarEmpleado.Size = New System.Drawing.Size(164, 30)
        Me.btnAgregarEmpleado.TabIndex = 3
        Me.btnAgregarEmpleado.Text = "Agregar Empleado"
        Me.btnAgregarEmpleado.UseVisualStyleBackColor = True
        '
        'btnAgregarTodosEmpleados
        '
        Me.btnAgregarTodosEmpleados.Location = New System.Drawing.Point(191, 12)
        Me.btnAgregarTodosEmpleados.Name = "btnAgregarTodosEmpleados"
        Me.btnAgregarTodosEmpleados.Size = New System.Drawing.Size(164, 30)
        Me.btnAgregarTodosEmpleados.TabIndex = 4
        Me.btnAgregarTodosEmpleados.Text = "Agregar Todos los Empleados"
        Me.btnAgregarTodosEmpleados.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(443, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tipo-> A=Adicionar, M=Modificar, E=Inactivar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(443, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Código de Empresa:"
        '
        'txtCodigoEmpresa
        '
        Me.txtCodigoEmpresa.Location = New System.Drawing.Point(551, 6)
        Me.txtCodigoEmpresa.Name = "txtCodigoEmpresa"
        Me.txtCodigoEmpresa.Size = New System.Drawing.Size(80, 20)
        Me.txtCodigoEmpresa.TabIndex = 7
        '
        'PLMantAtlantidaFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 476)
        Me.Controls.Add(Me.txtCodigoEmpresa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAgregarTodosEmpleados)
        Me.Controls.Add(Me.btnAgregarEmpleado)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dbgrdEmps)
        Me.Name = "PLMantAtlantidaFrm"
        Me.Text = "Mantenimiento de datos de Banco Atlántida"
        CType(Me.dbgrdEmps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dbgrdEmps As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAgregarEmpleado As System.Windows.Forms.Button
    Friend WithEvents btnAgregarTodosEmpleados As System.Windows.Forms.Button
    Friend WithEvents CodigoEmpleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Identidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents dlgGuardarArchivo As System.Windows.Forms.SaveFileDialog
End Class
