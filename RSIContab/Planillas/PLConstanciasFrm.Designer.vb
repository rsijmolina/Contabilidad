<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLConstanciasFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PLConstanciasFrm))
        Me.c1txtCodigoEmpleado = New C1.Win.C1Input.C1TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombreEmpleado = New System.Windows.Forms.Label()
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLConstanciasDataSet = New RSIContab.PLConstanciasDataSet()
        Me.PLConstanciasTableAdapter = New RSIContab.PLConstanciasDataSetTableAdapters.PLConstanciasTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.c1txtDescripcion = New C1.Win.C1Input.C1TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.c1truedbgrdConstancias = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.chklstboxConstancias = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.c1txtFirma = New C1.Win.C1Input.C1TextBox()
        Me.c1txtPuesto = New C1.Win.C1Input.C1TextBox()
        Me.radiobutMasculino = New System.Windows.Forms.RadioButton()
        Me.radiobutFemenino = New System.Windows.Forms.RadioButton()
        Me.btnBuscarEmpleado = New RSIContab.BotonBuscar()
        CType(Me.c1txtCodigoEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLConstanciasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1truedbgrdConstancias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtFirma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtPuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1txtCodigoEmpleado
        '
        Me.c1txtCodigoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtCodigoEmpleado.Location = New System.Drawing.Point(66, 12)
        Me.c1txtCodigoEmpleado.Name = "c1txtCodigoEmpleado"
        Me.c1txtCodigoEmpleado.Size = New System.Drawing.Size(122, 20)
        Me.c1txtCodigoEmpleado.TabIndex = 55
        Me.c1txtCodigoEmpleado.Tag = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Código:"
        '
        'lblNombreEmpleado
        '
        Me.lblNombreEmpleado.AutoSize = True
        Me.lblNombreEmpleado.Location = New System.Drawing.Point(12, 39)
        Me.lblNombreEmpleado.Name = "lblNombreEmpleado"
        Me.lblNombreEmpleado.Size = New System.Drawing.Size(10, 13)
        Me.lblNombreEmpleado.TabIndex = 58
        Me.lblNombreEmpleado.Text = "."
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLConstancias"
        Me.PrincipalBindingSource.DataSource = Me.PLConstanciasDataSet
        '
        'PLConstanciasDataSet
        '
        Me.PLConstanciasDataSet.DataSetName = "PLConstanciasDataSet"
        Me.PLConstanciasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLConstanciasTableAdapter
        '
        Me.PLConstanciasTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Descripción:"
        '
        'c1txtDescripcion
        '
        Me.c1txtDescripcion.Location = New System.Drawing.Point(88, 145)
        Me.c1txtDescripcion.Name = "c1txtDescripcion"
        Me.c1txtDescripcion.Size = New System.Drawing.Size(287, 20)
        Me.c1txtDescripcion.TabIndex = 63
        Me.c1txtDescripcion.Tag = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.c1truedbgrdConstancias)
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 313)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 171)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Constancias Extendidas"
        '
        'c1truedbgrdConstancias
        '
        Me.c1truedbgrdConstancias.AllowUpdate = False
        Me.c1truedbgrdConstancias.DataSource = Me.PrincipalBindingSource
        Me.c1truedbgrdConstancias.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1truedbgrdConstancias.Images.Add(CType(resources.GetObject("c1truedbgrdConstancias.Images"), System.Drawing.Image))
        Me.c1truedbgrdConstancias.Location = New System.Drawing.Point(6, 19)
        Me.c1truedbgrdConstancias.Name = "c1truedbgrdConstancias"
        Me.c1truedbgrdConstancias.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1truedbgrdConstancias.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1truedbgrdConstancias.PreviewInfo.ZoomFactor = 75.0R
        Me.c1truedbgrdConstancias.PrintInfo.PageSettings = CType(resources.GetObject("c1truedbgrdConstancias.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1truedbgrdConstancias.Size = New System.Drawing.Size(360, 134)
        Me.c1truedbgrdConstancias.TabIndex = 62
        Me.c1truedbgrdConstancias.Text = "C1TrueDBGrid1"
        Me.c1truedbgrdConstancias.PropBag = resources.GetString("c1truedbgrdConstancias.PropBag")
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(131, 284)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(124, 23)
        Me.btnGenerar.TabIndex = 65
        Me.btnGenerar.Text = "Generar Constancia"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(142, 490)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 34)
        Me.btnSalir.TabIndex = 66
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'chklstboxConstancias
        '
        Me.chklstboxConstancias.FormattingEnabled = True
        Me.chklstboxConstancias.Location = New System.Drawing.Point(12, 184)
        Me.chklstboxConstancias.Name = "chklstboxConstancias"
        Me.chklstboxConstancias.Size = New System.Drawing.Size(253, 94)
        Me.chklstboxConstancias.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 13)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Deducciones en la constancia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Firmante:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Puesto:"
        '
        'c1txtFirma
        '
        Me.c1txtFirma.Location = New System.Drawing.Point(88, 64)
        Me.c1txtFirma.Name = "c1txtFirma"
        Me.c1txtFirma.Size = New System.Drawing.Size(287, 20)
        Me.c1txtFirma.TabIndex = 71
        Me.c1txtFirma.Tag = Nothing
        '
        'c1txtPuesto
        '
        Me.c1txtPuesto.Location = New System.Drawing.Point(88, 119)
        Me.c1txtPuesto.Name = "c1txtPuesto"
        Me.c1txtPuesto.Size = New System.Drawing.Size(287, 20)
        Me.c1txtPuesto.TabIndex = 72
        Me.c1txtPuesto.Tag = Nothing
        '
        'radiobutMasculino
        '
        Me.radiobutMasculino.AutoSize = True
        Me.radiobutMasculino.Checked = True
        Me.radiobutMasculino.Location = New System.Drawing.Point(88, 91)
        Me.radiobutMasculino.Name = "radiobutMasculino"
        Me.radiobutMasculino.Size = New System.Drawing.Size(73, 17)
        Me.radiobutMasculino.TabIndex = 73
        Me.radiobutMasculino.Text = "Masculino"
        Me.radiobutMasculino.UseVisualStyleBackColor = True
        '
        'radiobutFemenino
        '
        Me.radiobutFemenino.AutoSize = True
        Me.radiobutFemenino.Location = New System.Drawing.Point(167, 91)
        Me.radiobutFemenino.Name = "radiobutFemenino"
        Me.radiobutFemenino.Size = New System.Drawing.Size(71, 17)
        Me.radiobutFemenino.TabIndex = 74
        Me.radiobutFemenino.Text = "Femenino"
        Me.radiobutFemenino.UseVisualStyleBackColor = True
        '
        'btnBuscarEmpleado
        '
        Me.btnBuscarEmpleado.ControlEnlazado = Nothing
        Me.btnBuscarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarEmpleado.Enabled = False
        Me.btnBuscarEmpleado.Location = New System.Drawing.Point(188, 10)
        Me.btnBuscarEmpleado.Name = "btnBuscarEmpleado"
        Me.btnBuscarEmpleado.Size = New System.Drawing.Size(23, 23)
        Me.btnBuscarEmpleado.TabIndex = 56
        Me.btnBuscarEmpleado.Tag = "HABILITARNOEDIT"
        '
        'PLConstanciasFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 527)
        Me.Controls.Add(Me.radiobutFemenino)
        Me.Controls.Add(Me.radiobutMasculino)
        Me.Controls.Add(Me.c1txtPuesto)
        Me.Controls.Add(Me.c1txtFirma)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chklstboxConstancias)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.c1txtDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNombreEmpleado)
        Me.Controls.Add(Me.btnBuscarEmpleado)
        Me.Controls.Add(Me.c1txtCodigoEmpleado)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PLConstanciasFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Constancias de Empleados"
        CType(Me.c1txtCodigoEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLConstanciasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.c1truedbgrdConstancias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtFirma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtPuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscarEmpleado As RSIContab.BotonBuscar
    Friend WithEvents c1txtCodigoEmpleado As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNombreEmpleado As System.Windows.Forms.Label
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLConstanciasDataSet As RSIContab.PLConstanciasDataSet
    Friend WithEvents PLConstanciasTableAdapter As RSIContab.PLConstanciasDataSetTableAdapters.PLConstanciasTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents c1txtDescripcion As C1.Win.C1Input.C1TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents c1truedbgrdConstancias As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents chklstboxConstancias As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents c1txtFirma As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtPuesto As C1.Win.C1Input.C1TextBox
    Friend WithEvents radiobutMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutFemenino As System.Windows.Forms.RadioButton
End Class
