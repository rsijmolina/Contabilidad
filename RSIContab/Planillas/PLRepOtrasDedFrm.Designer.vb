<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLRepOtrasDedFrm
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
        Me.c1numNoPlanilla = New C1.Win.C1Input.C1NumericEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.c1dateFecha = New C1.Win.C1Input.C1DateEdit
        Me.lstboxFuente = New System.Windows.Forms.ListBox
        Me.lblDescPlanilla = New System.Windows.Forms.Label
        Me.lstboxDestino = New System.Windows.Forms.ListBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.radiobutExportarExcel = New System.Windows.Forms.RadioButton
        Me.radiobutReporteGen = New System.Windows.Forms.RadioButton
        Me.butAgregar = New System.Windows.Forms.Button
        Me.radiobutQuitar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.c1numNoPlanilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'c1numNoPlanilla
        '
        Me.c1numNoPlanilla.AutoSize = False
        Me.c1numNoPlanilla.DataType = GetType(Short)
        Me.c1numNoPlanilla.Location = New System.Drawing.Point(87, 42)
        Me.c1numNoPlanilla.Name = "c1numNoPlanilla"
        Me.c1numNoPlanilla.Size = New System.Drawing.Size(23, 20)
        Me.c1numNoPlanilla.TabIndex = 20
        Me.c1numNoPlanilla.Tag = Nothing
        Me.c1numNoPlanilla.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "No. de Planilla:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 18
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
        Me.c1dateFecha.Location = New System.Drawing.Point(200, 12)
        Me.c1dateFecha.Name = "c1dateFecha"
        Me.c1dateFecha.Size = New System.Drawing.Size(105, 20)
        Me.c1dateFecha.TabIndex = 17
        Me.c1dateFecha.Tag = "CM"
        Me.c1dateFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'lstboxFuente
        '
        Me.lstboxFuente.FormattingEnabled = True
        Me.lstboxFuente.Location = New System.Drawing.Point(6, 152)
        Me.lstboxFuente.Name = "lstboxFuente"
        Me.lstboxFuente.Size = New System.Drawing.Size(170, 199)
        Me.lstboxFuente.TabIndex = 21
        '
        'lblDescPlanilla
        '
        Me.lblDescPlanilla.AutoSize = True
        Me.lblDescPlanilla.Location = New System.Drawing.Point(117, 48)
        Me.lblDescPlanilla.Name = "lblDescPlanilla"
        Me.lblDescPlanilla.Size = New System.Drawing.Size(0, 13)
        Me.lblDescPlanilla.TabIndex = 22
        '
        'lstboxDestino
        '
        Me.lstboxDestino.FormattingEnabled = True
        Me.lstboxDestino.Location = New System.Drawing.Point(226, 152)
        Me.lstboxDestino.Name = "lstboxDestino"
        Me.lstboxDestino.Size = New System.Drawing.Size(172, 199)
        Me.lstboxDestino.TabIndex = 23
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(297, 369)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(101, 32)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(12, 369)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(101, 32)
        Me.btnAceptar.TabIndex = 24
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radiobutExportarExcel)
        Me.GroupBox1.Controls.Add(Me.radiobutReporteGen)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 65)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Reporte"
        '
        'radiobutExportarExcel
        '
        Me.radiobutExportarExcel.AutoSize = True
        Me.radiobutExportarExcel.Location = New System.Drawing.Point(7, 42)
        Me.radiobutExportarExcel.Name = "radiobutExportarExcel"
        Me.radiobutExportarExcel.Size = New System.Drawing.Size(309, 17)
        Me.radiobutExportarExcel.TabIndex = 1
        Me.radiobutExportarExcel.TabStop = True
        Me.radiobutExportarExcel.Text = "Exportar a Excel con máximo de 30 seleccionadas de la lista"
        Me.radiobutExportarExcel.UseVisualStyleBackColor = True
        '
        'radiobutReporteGen
        '
        Me.radiobutReporteGen.AutoSize = True
        Me.radiobutReporteGen.Checked = True
        Me.radiobutReporteGen.Location = New System.Drawing.Point(7, 20)
        Me.radiobutReporteGen.Name = "radiobutReporteGen"
        Me.radiobutReporteGen.Size = New System.Drawing.Size(334, 17)
        Me.radiobutReporteGen.TabIndex = 0
        Me.radiobutReporteGen.TabStop = True
        Me.radiobutReporteGen.Text = "Reporte con máximo de 15 deducciones seleccionadas de la lista"
        Me.radiobutReporteGen.UseVisualStyleBackColor = True
        '
        'butAgregar
        '
        Me.butAgregar.Location = New System.Drawing.Point(183, 208)
        Me.butAgregar.Name = "butAgregar"
        Me.butAgregar.Size = New System.Drawing.Size(37, 23)
        Me.butAgregar.TabIndex = 27
        Me.butAgregar.Text = ">"
        Me.butAgregar.UseVisualStyleBackColor = True
        '
        'radiobutQuitar
        '
        Me.radiobutQuitar.Location = New System.Drawing.Point(183, 249)
        Me.radiobutQuitar.Name = "radiobutQuitar"
        Me.radiobutQuitar.Size = New System.Drawing.Size(37, 23)
        Me.radiobutQuitar.TabIndex = 28
        Me.radiobutQuitar.Text = "<"
        Me.radiobutQuitar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(226, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Deducciones Seleccionadas"
        '
        'PLRepOtrasDedFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 413)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.radiobutQuitar)
        Me.Controls.Add(Me.butAgregar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lstboxDestino)
        Me.Controls.Add(Me.lblDescPlanilla)
        Me.Controls.Add(Me.lstboxFuente)
        Me.Controls.Add(Me.c1numNoPlanilla)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.c1dateFecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PLRepOtrasDedFrm"
        Me.Text = "Reporte de Otras Deducciones"
        CType(Me.c1numNoPlanilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents c1numNoPlanilla As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents c1dateFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lstboxFuente As System.Windows.Forms.ListBox
    Friend WithEvents lblDescPlanilla As System.Windows.Forms.Label
    Friend WithEvents lstboxDestino As System.Windows.Forms.ListBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radiobutReporteGen As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutExportarExcel As System.Windows.Forms.RadioButton
    Friend WithEvents butAgregar As System.Windows.Forms.Button
    Friend WithEvents radiobutQuitar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
