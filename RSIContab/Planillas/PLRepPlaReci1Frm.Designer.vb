<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLRepPlaReci1Frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PLRepPlaReci1Frm))
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.lblDescPlanilla = New System.Windows.Forms.Label
        Me.c1numNoPlanilla = New C1.Win.C1Input.C1NumericEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.c1dateFecha = New C1.Win.C1Input.C1DateEdit
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLRepRecibosDataSet = New RSIContab.PLRepRecibosDataSet
        Me.PLDefinicionDeduccionesTableAdapter = New RSIContab.PLRepRecibosDataSetTableAdapters.PLDefinicionDeduccionesTableAdapter
        Me.c1truedbgrdDefDeducciones = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.chkListarEmpleado = New System.Windows.Forms.CheckBox
        Me.btnBuscarEmpleado = New RSIContab.BotonBuscar
        Me.c1txtCodigoEmpleado = New C1.Win.C1Input.C1TextBox
        Me.lblNombreEmpleado = New System.Windows.Forms.Label
        CType(Me.c1numNoPlanilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLRepRecibosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1truedbgrdDefDeducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtCodigoEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(378, 338)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(101, 32)
        Me.btnCancelar.TabIndex = 26
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(18, 338)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(101, 32)
        Me.btnAceptar.TabIndex = 25
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblDescPlanilla
        '
        Me.lblDescPlanilla.AutoSize = True
        Me.lblDescPlanilla.Location = New System.Drawing.Point(125, 264)
        Me.lblDescPlanilla.Name = "lblDescPlanilla"
        Me.lblDescPlanilla.Size = New System.Drawing.Size(10, 13)
        Me.lblDescPlanilla.TabIndex = 24
        Me.lblDescPlanilla.Text = "."
        '
        'c1numNoPlanilla
        '
        Me.c1numNoPlanilla.AutoSize = False
        Me.c1numNoPlanilla.DataType = GetType(Short)
        Me.c1numNoPlanilla.Location = New System.Drawing.Point(96, 261)
        Me.c1numNoPlanilla.Name = "c1numNoPlanilla"
        Me.c1numNoPlanilla.Size = New System.Drawing.Size(23, 20)
        Me.c1numNoPlanilla.TabIndex = 23
        Me.c1numNoPlanilla.Tag = Nothing
        Me.c1numNoPlanilla.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "No. de Planilla:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(141, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 21
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
        Me.c1dateFecha.Location = New System.Drawing.Point(245, 12)
        Me.c1dateFecha.Name = "c1dateFecha"
        Me.c1dateFecha.Size = New System.Drawing.Size(105, 20)
        Me.c1dateFecha.TabIndex = 20
        Me.c1dateFecha.Tag = "CM"
        Me.c1dateFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "PLDefinicionDeducciones"
        Me.PrincipalBindingSource.DataSource = Me.PLRepRecibosDataSet
        '
        'PLRepRecibosDataSet
        '
        Me.PLRepRecibosDataSet.DataSetName = "PLRepRecibosDataSet"
        Me.PLRepRecibosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLDefinicionDeduccionesTableAdapter
        '
        Me.PLDefinicionDeduccionesTableAdapter.ClearBeforeFill = True
        '
        'c1truedbgrdDefDeducciones
        '
        Me.c1truedbgrdDefDeducciones.DataSource = Me.PrincipalBindingSource
        Me.c1truedbgrdDefDeducciones.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1truedbgrdDefDeducciones.Images.Add(CType(resources.GetObject("c1truedbgrdDefDeducciones.Images"), System.Drawing.Image))
        Me.c1truedbgrdDefDeducciones.Location = New System.Drawing.Point(13, 42)
        Me.c1truedbgrdDefDeducciones.Name = "c1truedbgrdDefDeducciones"
        Me.c1truedbgrdDefDeducciones.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1truedbgrdDefDeducciones.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1truedbgrdDefDeducciones.PreviewInfo.ZoomFactor = 75
        Me.c1truedbgrdDefDeducciones.PrintInfo.PageSettings = CType(resources.GetObject("c1truedbgrdDefDeducciones.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1truedbgrdDefDeducciones.Size = New System.Drawing.Size(476, 213)
        Me.c1truedbgrdDefDeducciones.TabIndex = 27
        Me.c1truedbgrdDefDeducciones.Text = "C1TrueDBGrid1"
        Me.c1truedbgrdDefDeducciones.PropBag = resources.GetString("c1truedbgrdDefDeducciones.PropBag")
        '
        'chkListarEmpleado
        '
        Me.chkListarEmpleado.AutoSize = True
        Me.chkListarEmpleado.Location = New System.Drawing.Point(13, 289)
        Me.chkListarEmpleado.Name = "chkListarEmpleado"
        Me.chkListarEmpleado.Size = New System.Drawing.Size(187, 17)
        Me.chkListarEmpleado.TabIndex = 28
        Me.chkListarEmpleado.Text = "Imprimir Recibo de Este Empleado"
        Me.chkListarEmpleado.UseVisualStyleBackColor = True
        '
        'btnBuscarEmpleado
        '
        Me.btnBuscarEmpleado.ControlEnlazado = Nothing
        Me.btnBuscarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarEmpleado.Enabled = False
        Me.btnBuscarEmpleado.Location = New System.Drawing.Point(327, 283)
        Me.btnBuscarEmpleado.Name = "btnBuscarEmpleado"
        Me.btnBuscarEmpleado.Size = New System.Drawing.Size(23, 23)
        Me.btnBuscarEmpleado.TabIndex = 30
        '
        'c1txtCodigoEmpleado
        '
        Me.c1txtCodigoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtCodigoEmpleado.Location = New System.Drawing.Point(205, 285)
        Me.c1txtCodigoEmpleado.Name = "c1txtCodigoEmpleado"
        Me.c1txtCodigoEmpleado.Size = New System.Drawing.Size(122, 20)
        Me.c1txtCodigoEmpleado.TabIndex = 29
        Me.c1txtCodigoEmpleado.Tag = Nothing
        '
        'lblNombreEmpleado
        '
        Me.lblNombreEmpleado.AutoSize = True
        Me.lblNombreEmpleado.Location = New System.Drawing.Point(205, 313)
        Me.lblNombreEmpleado.Name = "lblNombreEmpleado"
        Me.lblNombreEmpleado.Size = New System.Drawing.Size(0, 13)
        Me.lblNombreEmpleado.TabIndex = 31
        '
        'PLRepPlaReci1Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 376)
        Me.Controls.Add(Me.lblNombreEmpleado)
        Me.Controls.Add(Me.btnBuscarEmpleado)
        Me.Controls.Add(Me.c1txtCodigoEmpleado)
        Me.Controls.Add(Me.chkListarEmpleado)
        Me.Controls.Add(Me.c1truedbgrdDefDeducciones)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblDescPlanilla)
        Me.Controls.Add(Me.c1numNoPlanilla)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.c1dateFecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PLRepPlaReci1Frm"
        Me.Text = "Reporte de Recibos"
        CType(Me.c1numNoPlanilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLRepRecibosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1truedbgrdDefDeducciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtCodigoEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblDescPlanilla As System.Windows.Forms.Label
    Friend WithEvents c1numNoPlanilla As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents c1dateFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLRepRecibosDataSet As RSIContab.PLRepRecibosDataSet
    Friend WithEvents PLDefinicionDeduccionesTableAdapter As RSIContab.PLRepRecibosDataSetTableAdapters.PLDefinicionDeduccionesTableAdapter
    Friend WithEvents c1truedbgrdDefDeducciones As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents chkListarEmpleado As System.Windows.Forms.CheckBox
    Friend WithEvents btnBuscarEmpleado As RSIContab.BotonBuscar
    Friend WithEvents c1txtCodigoEmpleado As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblNombreEmpleado As System.Windows.Forms.Label
End Class
