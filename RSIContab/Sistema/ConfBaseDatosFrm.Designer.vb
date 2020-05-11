<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfBaseDatosFrm
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
        Me.components = New System.ComponentModel.Container
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseDatosDataSet = New RSIContab.BaseDatosDataSet
        Me.DBTableAdapter = New RSIContab.BaseDatosDataSetTableAdapters.DBTableAdapter
        Me.c1txtBaseDatos = New C1.Win.C1Input.C1TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.c1txtNombreEmpresa = New C1.Win.C1Input.C1TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.c1txtClave = New C1.Win.C1Input.C1TextBox
        Me.c1txtUsuario = New C1.Win.C1Input.C1TextBox
        Me.c1txtInstancia = New C1.Win.C1Input.C1TextBox
        Me.c1txtServidor = New C1.Win.C1Input.C1TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.chkAutWindows = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtBaseDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtNombreEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtClave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtInstancia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtServidor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "DB"
        Me.PrincipalBindingSource.DataSource = Me.BaseDatosDataSet
        '
        'BaseDatosDataSet
        '
        Me.BaseDatosDataSet.DataSetName = "BaseDatosDataSet"
        Me.BaseDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DBTableAdapter
        '
        Me.DBTableAdapter.ClearBeforeFill = True
        '
        'c1txtBaseDatos
        '
        Me.c1txtBaseDatos.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "BaseDatos", True))
        Me.c1txtBaseDatos.Location = New System.Drawing.Point(85, 81)
        Me.c1txtBaseDatos.Name = "c1txtBaseDatos"
        Me.c1txtBaseDatos.Size = New System.Drawing.Size(97, 20)
        Me.c1txtBaseDatos.TabIndex = 41
        Me.c1txtBaseDatos.Tag = "CM"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Base de Datos:"
        '
        'c1txtNombreEmpresa
        '
        Me.c1txtNombreEmpresa.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "NombreEmpresa", True))
        Me.c1txtNombreEmpresa.Location = New System.Drawing.Point(60, 8)
        Me.c1txtNombreEmpresa.Name = "c1txtNombreEmpresa"
        Me.c1txtNombreEmpresa.Size = New System.Drawing.Size(251, 20)
        Me.c1txtNombreEmpresa.TabIndex = 27
        Me.c1txtNombreEmpresa.Tag = "CM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Empresa:"
        '
        'c1txtClave
        '
        Me.c1txtClave.Location = New System.Drawing.Point(85, 129)
        Me.c1txtClave.Name = "c1txtClave"
        Me.c1txtClave.Size = New System.Drawing.Size(97, 20)
        Me.c1txtClave.TabIndex = 32
        Me.c1txtClave.Tag = "CM"
        '
        'c1txtUsuario
        '
        Me.c1txtUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "Usuario", True))
        Me.c1txtUsuario.Location = New System.Drawing.Point(85, 105)
        Me.c1txtUsuario.Name = "c1txtUsuario"
        Me.c1txtUsuario.Size = New System.Drawing.Size(97, 20)
        Me.c1txtUsuario.TabIndex = 31
        Me.c1txtUsuario.Tag = "CM"
        '
        'c1txtInstancia
        '
        Me.c1txtInstancia.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "Instancia", True))
        Me.c1txtInstancia.Location = New System.Drawing.Point(85, 59)
        Me.c1txtInstancia.Name = "c1txtInstancia"
        Me.c1txtInstancia.Size = New System.Drawing.Size(97, 20)
        Me.c1txtInstancia.TabIndex = 30
        Me.c1txtInstancia.Tag = "CM"
        '
        'c1txtServidor
        '
        Me.c1txtServidor.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrincipalBindingSource, "Servidor", True))
        Me.c1txtServidor.Location = New System.Drawing.Point(85, 36)
        Me.c1txtServidor.Name = "c1txtServidor"
        Me.c1txtServidor.Size = New System.Drawing.Size(97, 20)
        Me.c1txtServidor.TabIndex = 28
        Me.c1txtServidor.Tag = "CM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Clave:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Usuario:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(215, 164)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(91, 39)
        Me.btnCancelar.TabIndex = 34
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(11, 164)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(93, 39)
        Me.btnAceptar.TabIndex = 33
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'chkAutWindows
        '
        Me.chkAutWindows.AutoSize = True
        Me.chkAutWindows.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PrincipalBindingSource, "WindowsAut", True))
        Me.chkAutWindows.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PrincipalBindingSource, "WindowsAut", True))
        Me.chkAutWindows.Location = New System.Drawing.Point(202, 36)
        Me.chkAutWindows.Name = "chkAutWindows"
        Me.chkAutWindows.Size = New System.Drawing.Size(104, 17)
        Me.chkAutWindows.TabIndex = 29
        Me.chkAutWindows.Text = "Auten. Windows"
        Me.chkAutWindows.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Instancia:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Servidor:"
        '
        'ConfBaseDatosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 213)
        Me.Controls.Add(Me.c1txtBaseDatos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.c1txtNombreEmpresa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.c1txtClave)
        Me.Controls.Add(Me.c1txtUsuario)
        Me.Controls.Add(Me.c1txtInstancia)
        Me.Controls.Add(Me.c1txtServidor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.chkAutWindows)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConfBaseDatosFrm"
        Me.Text = "ConfBaseDatosFrm"
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtBaseDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtNombreEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtClave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtInstancia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtServidor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BaseDatosDataSet As RSIContab.BaseDatosDataSet
    Friend WithEvents DBTableAdapter As RSIContab.BaseDatosDataSetTableAdapters.DBTableAdapter
    Friend WithEvents c1txtBaseDatos As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents c1txtNombreEmpresa As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents c1txtClave As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtUsuario As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtInstancia As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtServidor As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents chkAutWindows As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
