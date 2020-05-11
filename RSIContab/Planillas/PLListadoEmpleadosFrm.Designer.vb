<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLListadoEmpleadosFrm
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.c1dateFecha = New C1.Win.C1Input.C1DateEdit
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.c1txtEmpleadoIni = New C1.Win.C1Input.C1TextBox
        Me.c1txtEmpleadoFinal = New C1.Win.C1Input.C1TextBox
        Me.lblNombre1Ini = New System.Windows.Forms.Label
        Me.lblNombre1Final = New System.Windows.Forms.Label
        Me.lblNombre2Ini = New System.Windows.Forms.Label
        Me.lblApellido1Ini = New System.Windows.Forms.Label
        Me.lblApellido2Ini = New System.Windows.Forms.Label
        Me.lblNombre2Final = New System.Windows.Forms.Label
        Me.lblApellido1Final = New System.Windows.Forms.Label
        Me.lblApellido2Final = New System.Windows.Forms.Label
        Me.chkListarTodo = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.chklstCampos = New System.Windows.Forms.CheckedListBox
        Me.chkboxExportarExcel = New System.Windows.Forms.CheckBox
        Me.chkboxExcluirEmpRetirados = New System.Windows.Forms.CheckBox
        Me.btnBuscarEmpleadoFinal = New RSIContab.BotonBuscar
        Me.btnBuscarEmpleadoIni = New RSIContab.BotonBuscar
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLEmpleadosExcelDataSet = New RSIContab.PLEmpleadosExcelDataSet
        Me.PLEmpleadosTableAdapter = New RSIContab.PLEmpleadosExcelDataSetTableAdapters.PLEmpleadosTableAdapter
        Me.SedesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLSedesTableAdapter = New RSIContab.PLEmpleadosExcelDataSetTableAdapters.PLSedesTableAdapter
        Me.DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLDepartamentosTableAdapter = New RSIContab.PLEmpleadosExcelDataSetTableAdapters.PLDepartamentosTableAdapter
        Me.SeccionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLSeccionesTableAdapter = New RSIContab.PLEmpleadosExcelDataSetTableAdapters.PLSeccionesTableAdapter
        Me.PuestosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLPuestosTableAdapter = New RSIContab.PLEmpleadosExcelDataSetTableAdapters.PLPuestosTableAdapter
        Me.ProfesionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLProfesionesTableAdapter = New RSIContab.PLEmpleadosExcelDataSetTableAdapters.PLProfesionesTableAdapter
        Me.TiposEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLTiposEmpleadosTableAdapter = New RSIContab.PLEmpleadosExcelDataSetTableAdapters.PLTiposEmpleadosTableAdapter
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtEmpleadoIni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtEmpleadoFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLEmpleadosExcelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SedesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeccionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuestosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfesionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha del Reporte:"
        '
        'c1dateFecha
        '
        Me.c1dateFecha.DateTimeInput = False
        Me.c1dateFecha.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.c1dateFecha.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1dateFecha.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.c1dateFecha.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1dateFecha.Location = New System.Drawing.Point(237, 5)
        Me.c1dateFecha.Name = "c1dateFecha"
        Me.c1dateFecha.Size = New System.Drawing.Size(105, 20)
        Me.c1dateFecha.TabIndex = 10
        Me.c1dateFecha.Tag = "CM"
        Me.c1dateFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(27, 284)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(101, 32)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(334, 284)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(101, 32)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Empleado Inicial:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Empleado Final:"
        '
        'c1txtEmpleadoIni
        '
        Me.c1txtEmpleadoIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtEmpleadoIni.Location = New System.Drawing.Point(93, 37)
        Me.c1txtEmpleadoIni.Name = "c1txtEmpleadoIni"
        Me.c1txtEmpleadoIni.Size = New System.Drawing.Size(122, 20)
        Me.c1txtEmpleadoIni.TabIndex = 15
        Me.c1txtEmpleadoIni.Tag = Nothing
        '
        'c1txtEmpleadoFinal
        '
        Me.c1txtEmpleadoFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtEmpleadoFinal.Location = New System.Drawing.Point(93, 82)
        Me.c1txtEmpleadoFinal.Name = "c1txtEmpleadoFinal"
        Me.c1txtEmpleadoFinal.Size = New System.Drawing.Size(122, 20)
        Me.c1txtEmpleadoFinal.TabIndex = 17
        Me.c1txtEmpleadoFinal.Tag = Nothing
        '
        'lblNombre1Ini
        '
        Me.lblNombre1Ini.BackColor = System.Drawing.Color.White
        Me.lblNombre1Ini.Location = New System.Drawing.Point(90, 60)
        Me.lblNombre1Ini.Name = "lblNombre1Ini"
        Me.lblNombre1Ini.Size = New System.Drawing.Size(88, 14)
        Me.lblNombre1Ini.TabIndex = 19
        '
        'lblNombre1Final
        '
        Me.lblNombre1Final.BackColor = System.Drawing.Color.White
        Me.lblNombre1Final.Location = New System.Drawing.Point(90, 106)
        Me.lblNombre1Final.Name = "lblNombre1Final"
        Me.lblNombre1Final.Size = New System.Drawing.Size(88, 14)
        Me.lblNombre1Final.TabIndex = 20
        '
        'lblNombre2Ini
        '
        Me.lblNombre2Ini.BackColor = System.Drawing.Color.White
        Me.lblNombre2Ini.Location = New System.Drawing.Point(184, 61)
        Me.lblNombre2Ini.Name = "lblNombre2Ini"
        Me.lblNombre2Ini.Size = New System.Drawing.Size(88, 14)
        Me.lblNombre2Ini.TabIndex = 21
        '
        'lblApellido1Ini
        '
        Me.lblApellido1Ini.BackColor = System.Drawing.Color.White
        Me.lblApellido1Ini.Location = New System.Drawing.Point(278, 60)
        Me.lblApellido1Ini.Name = "lblApellido1Ini"
        Me.lblApellido1Ini.Size = New System.Drawing.Size(88, 14)
        Me.lblApellido1Ini.TabIndex = 22
        '
        'lblApellido2Ini
        '
        Me.lblApellido2Ini.BackColor = System.Drawing.Color.White
        Me.lblApellido2Ini.Location = New System.Drawing.Point(372, 60)
        Me.lblApellido2Ini.Name = "lblApellido2Ini"
        Me.lblApellido2Ini.Size = New System.Drawing.Size(88, 14)
        Me.lblApellido2Ini.TabIndex = 23
        '
        'lblNombre2Final
        '
        Me.lblNombre2Final.BackColor = System.Drawing.Color.White
        Me.lblNombre2Final.Location = New System.Drawing.Point(184, 105)
        Me.lblNombre2Final.Name = "lblNombre2Final"
        Me.lblNombre2Final.Size = New System.Drawing.Size(88, 14)
        Me.lblNombre2Final.TabIndex = 24
        '
        'lblApellido1Final
        '
        Me.lblApellido1Final.BackColor = System.Drawing.Color.White
        Me.lblApellido1Final.Location = New System.Drawing.Point(278, 105)
        Me.lblApellido1Final.Name = "lblApellido1Final"
        Me.lblApellido1Final.Size = New System.Drawing.Size(88, 14)
        Me.lblApellido1Final.TabIndex = 25
        '
        'lblApellido2Final
        '
        Me.lblApellido2Final.BackColor = System.Drawing.Color.White
        Me.lblApellido2Final.Location = New System.Drawing.Point(370, 106)
        Me.lblApellido2Final.Name = "lblApellido2Final"
        Me.lblApellido2Final.Size = New System.Drawing.Size(88, 14)
        Me.lblApellido2Final.TabIndex = 26
        '
        'chkListarTodo
        '
        Me.chkListarTodo.AutoSize = True
        Me.chkListarTodo.Location = New System.Drawing.Point(12, 124)
        Me.chkListarTodo.Name = "chkListarTodo"
        Me.chkListarTodo.Size = New System.Drawing.Size(84, 17)
        Me.chkListarTodo.TabIndex = 27
        Me.chkListarTodo.Text = "Listar Todos"
        Me.chkListarTodo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.chklstCampos)
        Me.GroupBox1.Controls.Add(Me.chkboxExportarExcel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 131)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exportar Contenido a Excel"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Elija los datos de la lista ->"
        '
        'chklstCampos
        '
        Me.chklstCampos.FormattingEnabled = True
        Me.chklstCampos.Location = New System.Drawing.Point(151, 16)
        Me.chklstCampos.Name = "chklstCampos"
        Me.chklstCampos.Size = New System.Drawing.Size(153, 109)
        Me.chklstCampos.TabIndex = 1
        '
        'chkboxExportarExcel
        '
        Me.chkboxExportarExcel.AutoSize = True
        Me.chkboxExportarExcel.Location = New System.Drawing.Point(7, 20)
        Me.chkboxExportarExcel.Name = "chkboxExportarExcel"
        Me.chkboxExportarExcel.Size = New System.Drawing.Size(103, 17)
        Me.chkboxExportarExcel.TabIndex = 0
        Me.chkboxExportarExcel.Text = "Exportar a Excel"
        Me.chkboxExportarExcel.UseVisualStyleBackColor = True
        '
        'chkboxExcluirEmpRetirados
        '
        Me.chkboxExcluirEmpRetirados.AutoSize = True
        Me.chkboxExcluirEmpRetirados.Location = New System.Drawing.Point(102, 124)
        Me.chkboxExcluirEmpRetirados.Name = "chkboxExcluirEmpRetirados"
        Me.chkboxExcluirEmpRetirados.Size = New System.Drawing.Size(160, 17)
        Me.chkboxExcluirEmpRetirados.TabIndex = 3
        Me.chkboxExcluirEmpRetirados.Text = "Exlcuir Empleados Retirados"
        Me.chkboxExcluirEmpRetirados.UseVisualStyleBackColor = True
        '
        'btnBuscarEmpleadoFinal
        '
        Me.btnBuscarEmpleadoFinal.ControlEnlazado = Nothing
        Me.btnBuscarEmpleadoFinal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarEmpleadoFinal.Enabled = False
        Me.btnBuscarEmpleadoFinal.Location = New System.Drawing.Point(215, 80)
        Me.btnBuscarEmpleadoFinal.Name = "btnBuscarEmpleadoFinal"
        Me.btnBuscarEmpleadoFinal.Size = New System.Drawing.Size(23, 23)
        Me.btnBuscarEmpleadoFinal.TabIndex = 18
        '
        'btnBuscarEmpleadoIni
        '
        Me.btnBuscarEmpleadoIni.ControlEnlazado = Nothing
        Me.btnBuscarEmpleadoIni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarEmpleadoIni.Enabled = False
        Me.btnBuscarEmpleadoIni.Location = New System.Drawing.Point(215, 35)
        Me.btnBuscarEmpleadoIni.Name = "btnBuscarEmpleadoIni"
        Me.btnBuscarEmpleadoIni.Size = New System.Drawing.Size(23, 23)
        Me.btnBuscarEmpleadoIni.TabIndex = 16
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "PLEmpleados"
        Me.EmpleadosBindingSource.DataSource = Me.PLEmpleadosExcelDataSet
        '
        'PLEmpleadosExcelDataSet
        '
        Me.PLEmpleadosExcelDataSet.DataSetName = "PLEmpleadosExcelDataSet"
        Me.PLEmpleadosExcelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLEmpleadosTableAdapter
        '
        Me.PLEmpleadosTableAdapter.ClearBeforeFill = True
        '
        'SedesBindingSource
        '
        Me.SedesBindingSource.DataMember = "PLSedes"
        Me.SedesBindingSource.DataSource = Me.PLEmpleadosExcelDataSet
        '
        'PLSedesTableAdapter
        '
        Me.PLSedesTableAdapter.ClearBeforeFill = True
        '
        'DepartamentosBindingSource
        '
        Me.DepartamentosBindingSource.DataMember = "PLDepartamentos"
        Me.DepartamentosBindingSource.DataSource = Me.PLEmpleadosExcelDataSet
        '
        'PLDepartamentosTableAdapter
        '
        Me.PLDepartamentosTableAdapter.ClearBeforeFill = True
        '
        'SeccionesBindingSource
        '
        Me.SeccionesBindingSource.DataMember = "PLSecciones"
        Me.SeccionesBindingSource.DataSource = Me.PLEmpleadosExcelDataSet
        '
        'PLSeccionesTableAdapter
        '
        Me.PLSeccionesTableAdapter.ClearBeforeFill = True
        '
        'PuestosBindingSource
        '
        Me.PuestosBindingSource.DataMember = "PLPuestos"
        Me.PuestosBindingSource.DataSource = Me.PLEmpleadosExcelDataSet
        '
        'PLPuestosTableAdapter
        '
        Me.PLPuestosTableAdapter.ClearBeforeFill = True
        '
        'ProfesionesBindingSource
        '
        Me.ProfesionesBindingSource.DataMember = "PLProfesiones"
        Me.ProfesionesBindingSource.DataSource = Me.PLEmpleadosExcelDataSet
        '
        'PLProfesionesTableAdapter
        '
        Me.PLProfesionesTableAdapter.ClearBeforeFill = True
        '
        'TiposEmpleadosBindingSource
        '
        Me.TiposEmpleadosBindingSource.DataMember = "PLTiposEmpleados"
        Me.TiposEmpleadosBindingSource.DataSource = Me.PLEmpleadosExcelDataSet
        '
        'PLTiposEmpleadosTableAdapter
        '
        Me.PLTiposEmpleadosTableAdapter.ClearBeforeFill = True
        '
        'PLListadoEmpleadosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 328)
        Me.Controls.Add(Me.chkboxExcluirEmpRetirados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkListarTodo)
        Me.Controls.Add(Me.lblApellido2Final)
        Me.Controls.Add(Me.lblApellido1Final)
        Me.Controls.Add(Me.lblNombre2Final)
        Me.Controls.Add(Me.lblApellido2Ini)
        Me.Controls.Add(Me.lblApellido1Ini)
        Me.Controls.Add(Me.lblNombre2Ini)
        Me.Controls.Add(Me.lblNombre1Final)
        Me.Controls.Add(Me.lblNombre1Ini)
        Me.Controls.Add(Me.btnBuscarEmpleadoFinal)
        Me.Controls.Add(Me.c1txtEmpleadoFinal)
        Me.Controls.Add(Me.btnBuscarEmpleadoIni)
        Me.Controls.Add(Me.c1txtEmpleadoIni)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.c1dateFecha)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PLListadoEmpleadosFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Empleados"
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtEmpleadoIni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtEmpleadoFinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLEmpleadosExcelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SedesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeccionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuestosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfesionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents c1dateFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarEmpleadoIni As RSIContab.BotonBuscar
    Friend WithEvents c1txtEmpleadoIni As C1.Win.C1Input.C1TextBox
    Friend WithEvents btnBuscarEmpleadoFinal As RSIContab.BotonBuscar
    Friend WithEvents c1txtEmpleadoFinal As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblNombre1Ini As System.Windows.Forms.Label
    Friend WithEvents lblNombre1Final As System.Windows.Forms.Label
    Friend WithEvents lblNombre2Ini As System.Windows.Forms.Label
    Friend WithEvents lblApellido1Ini As System.Windows.Forms.Label
    Friend WithEvents lblApellido2Ini As System.Windows.Forms.Label
    Friend WithEvents lblNombre2Final As System.Windows.Forms.Label
    Friend WithEvents lblApellido1Final As System.Windows.Forms.Label
    Friend WithEvents lblApellido2Final As System.Windows.Forms.Label
    Friend WithEvents chkListarTodo As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chklstCampos As System.Windows.Forms.CheckedListBox
    Friend WithEvents chkboxExportarExcel As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxExcluirEmpRetirados As System.Windows.Forms.CheckBox
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLEmpleadosExcelDataSet As RSIContab.PLEmpleadosExcelDataSet
    Friend WithEvents PLEmpleadosTableAdapter As RSIContab.PLEmpleadosExcelDataSetTableAdapters.PLEmpleadosTableAdapter
    Friend WithEvents SedesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLSedesTableAdapter As RSIContab.PLEmpleadosExcelDataSetTableAdapters.PLSedesTableAdapter
    Friend WithEvents DepartamentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLDepartamentosTableAdapter As RSIContab.PLEmpleadosExcelDataSetTableAdapters.PLDepartamentosTableAdapter
    Friend WithEvents SeccionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLSeccionesTableAdapter As RSIContab.PLEmpleadosExcelDataSetTableAdapters.PLSeccionesTableAdapter
    Friend WithEvents PuestosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLPuestosTableAdapter As RSIContab.PLEmpleadosExcelDataSetTableAdapters.PLPuestosTableAdapter
    Friend WithEvents ProfesionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLProfesionesTableAdapter As RSIContab.PLEmpleadosExcelDataSetTableAdapters.PLProfesionesTableAdapter
    Friend WithEvents TiposEmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLTiposEmpleadosTableAdapter As RSIContab.PLEmpleadosExcelDataSetTableAdapters.PLTiposEmpleadosTableAdapter
End Class
