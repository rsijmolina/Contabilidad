<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTSaldosMensualesFrm
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolstriplblAño = New System.Windows.Forms.ToolStripLabel()
        Me.butSalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.c1numMes12 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numMes11 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numMes10 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numMes9 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numMes8 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numMes7 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numMes6 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numMes5 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numMes4 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numMes3 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numMes2 = New C1.Win.C1Input.C1NumericEdit()
        Me.c1numMes1 = New C1.Win.C1Input.C1NumericEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1numMes12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numMes11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numMes10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numMes9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numMes8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numMes7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numMes6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numMes5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numMes4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numMes3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numMes2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numMes1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstriplblAño})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(223, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolstriplblAño
        '
        Me.toolstriplblAño.Name = "toolstriplblAño"
        Me.toolstriplblAño.Size = New System.Drawing.Size(32, 22)
        Me.toolstriplblAño.Text = "Año:"
        '
        'butSalir
        '
        Me.butSalir.Location = New System.Drawing.Point(65, 369)
        Me.butSalir.Name = "butSalir"
        Me.butSalir.Size = New System.Drawing.Size(88, 32)
        Me.butSalir.TabIndex = 58
        Me.butSalir.Text = "&Salir"
        Me.butSalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.c1numMes12)
        Me.GroupBox1.Controls.Add(Me.c1numMes11)
        Me.GroupBox1.Controls.Add(Me.c1numMes10)
        Me.GroupBox1.Controls.Add(Me.c1numMes9)
        Me.GroupBox1.Controls.Add(Me.c1numMes8)
        Me.GroupBox1.Controls.Add(Me.c1numMes7)
        Me.GroupBox1.Controls.Add(Me.c1numMes6)
        Me.GroupBox1.Controls.Add(Me.c1numMes5)
        Me.GroupBox1.Controls.Add(Me.c1numMes4)
        Me.GroupBox1.Controls.Add(Me.c1numMes3)
        Me.GroupBox1.Controls.Add(Me.c1numMes2)
        Me.GroupBox1.Controls.Add(Me.c1numMes1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(203, 335)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        '
        'c1numMes12
        '
        Me.c1numMes12.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numMes12.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numMes12.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numMes12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numMes12.Location = New System.Drawing.Point(87, 305)
        Me.c1numMes12.Name = "c1numMes12"
        Me.c1numMes12.Size = New System.Drawing.Size(93, 20)
        Me.c1numMes12.TabIndex = 81
        Me.c1numMes12.Tag = Nothing
        Me.c1numMes12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numMes12.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1numMes12.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numMes11
        '
        Me.c1numMes11.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numMes11.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numMes11.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numMes11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numMes11.Location = New System.Drawing.Point(87, 279)
        Me.c1numMes11.Name = "c1numMes11"
        Me.c1numMes11.Size = New System.Drawing.Size(93, 20)
        Me.c1numMes11.TabIndex = 80
        Me.c1numMes11.Tag = Nothing
        Me.c1numMes11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numMes11.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1numMes11.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numMes10
        '
        Me.c1numMes10.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numMes10.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numMes10.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numMes10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numMes10.Location = New System.Drawing.Point(87, 253)
        Me.c1numMes10.Name = "c1numMes10"
        Me.c1numMes10.Size = New System.Drawing.Size(93, 20)
        Me.c1numMes10.TabIndex = 79
        Me.c1numMes10.Tag = Nothing
        Me.c1numMes10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numMes10.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1numMes10.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numMes9
        '
        Me.c1numMes9.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numMes9.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numMes9.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numMes9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numMes9.Location = New System.Drawing.Point(87, 227)
        Me.c1numMes9.Name = "c1numMes9"
        Me.c1numMes9.Size = New System.Drawing.Size(93, 20)
        Me.c1numMes9.TabIndex = 78
        Me.c1numMes9.Tag = Nothing
        Me.c1numMes9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numMes9.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1numMes9.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numMes8
        '
        Me.c1numMes8.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numMes8.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numMes8.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numMes8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numMes8.Location = New System.Drawing.Point(87, 201)
        Me.c1numMes8.Name = "c1numMes8"
        Me.c1numMes8.Size = New System.Drawing.Size(93, 20)
        Me.c1numMes8.TabIndex = 77
        Me.c1numMes8.Tag = Nothing
        Me.c1numMes8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numMes8.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1numMes8.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numMes7
        '
        Me.c1numMes7.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numMes7.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numMes7.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numMes7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numMes7.Location = New System.Drawing.Point(87, 175)
        Me.c1numMes7.Name = "c1numMes7"
        Me.c1numMes7.Size = New System.Drawing.Size(93, 20)
        Me.c1numMes7.TabIndex = 76
        Me.c1numMes7.Tag = Nothing
        Me.c1numMes7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numMes7.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1numMes7.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numMes6
        '
        Me.c1numMes6.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numMes6.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numMes6.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numMes6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numMes6.Location = New System.Drawing.Point(87, 149)
        Me.c1numMes6.Name = "c1numMes6"
        Me.c1numMes6.Size = New System.Drawing.Size(93, 20)
        Me.c1numMes6.TabIndex = 75
        Me.c1numMes6.Tag = Nothing
        Me.c1numMes6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numMes6.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1numMes6.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numMes5
        '
        Me.c1numMes5.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numMes5.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numMes5.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numMes5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numMes5.Location = New System.Drawing.Point(87, 123)
        Me.c1numMes5.Name = "c1numMes5"
        Me.c1numMes5.Size = New System.Drawing.Size(93, 20)
        Me.c1numMes5.TabIndex = 74
        Me.c1numMes5.Tag = Nothing
        Me.c1numMes5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numMes5.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1numMes5.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numMes4
        '
        Me.c1numMes4.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numMes4.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numMes4.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numMes4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numMes4.Location = New System.Drawing.Point(87, 97)
        Me.c1numMes4.Name = "c1numMes4"
        Me.c1numMes4.Size = New System.Drawing.Size(93, 20)
        Me.c1numMes4.TabIndex = 73
        Me.c1numMes4.Tag = Nothing
        Me.c1numMes4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numMes4.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1numMes4.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numMes3
        '
        Me.c1numMes3.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numMes3.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numMes3.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numMes3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numMes3.Location = New System.Drawing.Point(87, 71)
        Me.c1numMes3.Name = "c1numMes3"
        Me.c1numMes3.Size = New System.Drawing.Size(93, 20)
        Me.c1numMes3.TabIndex = 72
        Me.c1numMes3.Tag = Nothing
        Me.c1numMes3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numMes3.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1numMes3.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numMes2
        '
        Me.c1numMes2.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numMes2.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numMes2.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numMes2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numMes2.Location = New System.Drawing.Point(87, 45)
        Me.c1numMes2.Name = "c1numMes2"
        Me.c1numMes2.Size = New System.Drawing.Size(93, 20)
        Me.c1numMes2.TabIndex = 71
        Me.c1numMes2.Tag = Nothing
        Me.c1numMes2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numMes2.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1numMes2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1numMes1
        '
        Me.c1numMes1.DisplayFormat.CustomFormat = "#,##0.00"
        Me.c1numMes1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1numMes1.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.c1numMes1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1numMes1.Location = New System.Drawing.Point(87, 19)
        Me.c1numMes1.Name = "c1numMes1"
        Me.c1numMes1.Size = New System.Drawing.Size(93, 20)
        Me.c1numMes1.TabIndex = 70
        Me.c1numMes1.Tag = Nothing
        Me.c1numMes1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1numMes1.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1numMes1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 312)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "Diciembre:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 286)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "Noviembre:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 260)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Octubre:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Septiembre:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Agosto:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Julio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Junio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Mayo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Abril:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Marzo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Febrero:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Enero:"
        '
        'CTSaldosMensualesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 410)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.butSalir)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CTSaldosMensualesFrm"
        Me.Text = "Saldos Mensuales"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1numMes12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numMes11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numMes10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numMes9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numMes8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numMes7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numMes6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numMes5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numMes4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numMes3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numMes2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numMes1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents toolstriplblAño As System.Windows.Forms.ToolStripLabel
    Friend WithEvents butSalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents c1numMes12 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numMes11 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numMes10 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numMes9 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numMes8 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numMes7 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numMes6 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numMes5 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numMes4 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numMes3 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numMes2 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1numMes1 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
