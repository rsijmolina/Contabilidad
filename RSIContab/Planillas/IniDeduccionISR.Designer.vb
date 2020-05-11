<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IniDeduccionISR
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblTotalDeducibles = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.c1numOtros = New C1.Win.C1Input.C1NumericEdit
        Me.c1numSeguroSocial = New C1.Win.C1Input.C1NumericEdit
        Me.c1numGastosMedicos = New C1.Win.C1Input.C1NumericEdit
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.c1numAño = New C1.Win.C1Input.C1NumericEdit
        Me.btnProcesar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        CType(Me.c1numOtros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numSeguroSocial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numGastosMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalDeducibles)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.c1numOtros)
        Me.GroupBox2.Controls.Add(Me.c1numSeguroSocial)
        Me.GroupBox2.Controls.Add(Me.c1numGastosMedicos)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(186, 122)
        Me.GroupBox2.TabIndex = 77
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Deducibles"
        '
        'lblTotalDeducibles
        '
        Me.lblTotalDeducibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDeducibles.Location = New System.Drawing.Point(96, 97)
        Me.lblTotalDeducibles.Name = "lblTotalDeducibles"
        Me.lblTotalDeducibles.Size = New System.Drawing.Size(79, 13)
        Me.lblTotalDeducibles.TabIndex = 76
        Me.lblTotalDeducibles.Text = "0.00"
        Me.lblTotalDeducibles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(9, 97)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(53, 13)
        Me.Label24.TabIndex = 75
        Me.Label24.Text = "Totales:"
        '
        'c1numOtros
        '
        Me.c1numOtros.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numOtros.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numOtros.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numOtros.Location = New System.Drawing.Point(99, 70)
        Me.c1numOtros.Name = "c1numOtros"
        Me.c1numOtros.Size = New System.Drawing.Size(76, 20)
        Me.c1numOtros.TabIndex = 30
        Me.c1numOtros.Tag = Nothing
        Me.c1numOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numOtros.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numSeguroSocial
        '
        Me.c1numSeguroSocial.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numSeguroSocial.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numSeguroSocial.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numSeguroSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numSeguroSocial.Location = New System.Drawing.Point(99, 44)
        Me.c1numSeguroSocial.Name = "c1numSeguroSocial"
        Me.c1numSeguroSocial.Size = New System.Drawing.Size(76, 20)
        Me.c1numSeguroSocial.TabIndex = 28
        Me.c1numSeguroSocial.Tag = Nothing
        Me.c1numSeguroSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numSeguroSocial.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numGastosMedicos
        '
        Me.c1numGastosMedicos.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numGastosMedicos.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numGastosMedicos.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numGastosMedicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numGastosMedicos.Location = New System.Drawing.Point(99, 17)
        Me.c1numGastosMedicos.Name = "c1numGastosMedicos"
        Me.c1numGastosMedicos.Size = New System.Drawing.Size(76, 20)
        Me.c1numGastosMedicos.TabIndex = 27
        Me.c1numGastosMedicos.Tag = Nothing
        Me.c1numGastosMedicos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numGastosMedicos.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(7, 73)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 13)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Otros:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Seguro Social:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Gastos Médicos:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 33)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Este proceso calculará la deducción del impuesto sobre la renta para el período q" & _
            "ue indique a continuación. "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Año:"
        '
        'c1numAño
        '
        Me.c1numAño.DataType = GetType(Byte)
        Me.c1numAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numAño.Location = New System.Drawing.Point(48, 46)
        Me.c1numAño.Name = "c1numAño"
        Me.c1numAño.Size = New System.Drawing.Size(49, 20)
        Me.c1numAño.TabIndex = 80
        Me.c1numAño.Tag = Nothing
        Me.c1numAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numAño.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(37, 221)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(95, 33)
        Me.btnProcesar.TabIndex = 81
        Me.btnProcesar.Text = "&Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(238, 221)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(95, 33)
        Me.btnCancelar.TabIndex = 82
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'IniDeduccionISR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 265)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.c1numAño)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IniDeduccionISR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicialización de deducción del ISR"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.c1numOtros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numSeguroSocial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numGastosMedicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalDeducibles As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents c1numOtros As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numSeguroSocial As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numGastosMedicos As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents c1numAño As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
