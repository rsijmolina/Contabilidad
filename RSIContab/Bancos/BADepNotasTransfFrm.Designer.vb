<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BADepNotasTransfFrm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BADepNotasTransfFrm))
        Me.ListaDataNavBarPrin = New RSIContab.ListaDataNavBar()
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BATransaccionesListaDataSet = New RSIContab.BATransaccionesListaDataSet()
        Me.c1dbgrdNiveles = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.c1cmbTipoTrans = New C1.Win.C1Input.C1ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.butFiltrar = New System.Windows.Forms.Button()
        Me.butCambiarPeriodo = New System.Windows.Forms.Button()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.lblAño = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.c1cmbBanco = New C1.Win.C1List.C1Combo()
        Me.BABancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BATransaccionesEncabezadoTableAdapter = New RSIContab.BATransaccionesListaDataSetTableAdapters.BATransaccionesEncabezadoTableAdapter()
        Me.BABancosTableAdapter = New RSIContab.BATransaccionesListaDataSetTableAdapters.BABancosTableAdapter()
        Me.BAConfBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BAConfTableAdapter = New RSIContab.BATransaccionesListaDataSetTableAdapters.BAConfTableAdapter()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BATransaccionesListaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1dbgrdNiveles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1cmbTipoTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1cmbBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BABancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAConfBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaDataNavBarPrin
        '
        Me.ListaDataNavBarPrin.BindingSourcePrincipal = Me.PrincipalBindingSource
        Me.ListaDataNavBarPrin.Location = New System.Drawing.Point(0, 66)
        Me.ListaDataNavBarPrin.Name = "ListaDataNavBarPrin"
        Me.ListaDataNavBarPrin.Size = New System.Drawing.Size(1106, 69)
        Me.ListaDataNavBarPrin.TabIndex = 6
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "BATransaccionesEncabezado"
        Me.PrincipalBindingSource.DataSource = Me.BATransaccionesListaDataSet
        '
        'BATransaccionesListaDataSet
        '
        Me.BATransaccionesListaDataSet.DataSetName = "BATransaccionesListaDataSet"
        Me.BATransaccionesListaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'c1dbgrdNiveles
        '
        Me.c1dbgrdNiveles.AllowUpdate = False
        Me.c1dbgrdNiveles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c1dbgrdNiveles.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.c1dbgrdNiveles.DataSource = Me.PrincipalBindingSource
        Me.c1dbgrdNiveles.FilterBar = True
        Me.c1dbgrdNiveles.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbgrdNiveles.Images.Add(CType(resources.GetObject("c1dbgrdNiveles.Images"), System.Drawing.Image))
        Me.c1dbgrdNiveles.Location = New System.Drawing.Point(0, 144)
        Me.c1dbgrdNiveles.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.c1dbgrdNiveles.Name = "c1dbgrdNiveles"
        Me.c1dbgrdNiveles.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbgrdNiveles.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbgrdNiveles.PreviewInfo.ZoomFactor = 75.0R
        Me.c1dbgrdNiveles.PrintInfo.PageSettings = CType(resources.GetObject("c1dbgrdNiveles.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1dbgrdNiveles.RowHeight = 18
        Me.c1dbgrdNiveles.Size = New System.Drawing.Size(1096, 413)
        Me.c1dbgrdNiveles.TabIndex = 7
        Me.c1dbgrdNiveles.Text = "C1TrueDBGrid1"
        Me.c1dbgrdNiveles.UseCompatibleTextRendering = False
        Me.c1dbgrdNiveles.PropBag = resources.GetString("c1dbgrdNiveles.PropBag")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.c1cmbTipoTrans)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.butFiltrar)
        Me.GroupBox1.Controls.Add(Me.butCambiarPeriodo)
        Me.GroupBox1.Controls.Add(Me.lblMes)
        Me.GroupBox1.Controls.Add(Me.lblAño)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.c1cmbBanco)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1106, 63)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'c1cmbTipoTrans
        '
        Me.c1cmbTipoTrans.AllowSpinLoop = False
        Me.c1cmbTipoTrans.GapHeight = 0
        Me.c1cmbTipoTrans.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1cmbTipoTrans.Items.Add("Depósitos")
        Me.c1cmbTipoTrans.Items.Add("Notas de Crédito")
        Me.c1cmbTipoTrans.Items.Add("Notas de Débito")
        Me.c1cmbTipoTrans.Items.Add("Transferencias")
        Me.c1cmbTipoTrans.ItemsDisplayMember = ""
        Me.c1cmbTipoTrans.ItemsValueMember = ""
        Me.c1cmbTipoTrans.Location = New System.Drawing.Point(54, 37)
        Me.c1cmbTipoTrans.Name = "c1cmbTipoTrans"
        Me.c1cmbTipoTrans.Size = New System.Drawing.Size(150, 18)
        Me.c1cmbTipoTrans.TabIndex = 10
        Me.c1cmbTipoTrans.Tag = Nothing
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tipo:"
        '
        'butFiltrar
        '
        Me.butFiltrar.Image = Global.RSIContab.My.Resources.Resources._1421885802_filter
        Me.butFiltrar.Location = New System.Drawing.Point(675, 9)
        Me.butFiltrar.Name = "butFiltrar"
        Me.butFiltrar.Size = New System.Drawing.Size(53, 54)
        Me.butFiltrar.TabIndex = 7
        Me.butFiltrar.Text = "Filtrar"
        Me.butFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.butFiltrar.UseVisualStyleBackColor = True
        '
        'butCambiarPeriodo
        '
        Me.butCambiarPeriodo.Image = Global.RSIContab.My.Resources.Resources._1421198824_gear_32
        Me.butCambiarPeriodo.Location = New System.Drawing.Point(602, 9)
        Me.butCambiarPeriodo.Name = "butCambiarPeriodo"
        Me.butCambiarPeriodo.Size = New System.Drawing.Size(53, 54)
        Me.butCambiarPeriodo.TabIndex = 6
        Me.butCambiarPeriodo.Text = "Cambiar"
        Me.butCambiarPeriodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.butCambiarPeriodo.UseVisualStyleBackColor = True
        '
        'lblMes
        '
        Me.lblMes.Location = New System.Drawing.Point(491, 23)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(105, 16)
        Me.lblMes.TabIndex = 5
        Me.lblMes.Text = "Enero"
        '
        'lblAño
        '
        Me.lblAño.Location = New System.Drawing.Point(400, 23)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(49, 16)
        Me.lblAño.TabIndex = 4
        Me.lblAño.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(455, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mes:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(374, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Año:"
        '
        'c1cmbBanco
        '
        Me.c1cmbBanco.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.c1cmbBanco.AllowColSelect = True
        Me.c1cmbBanco.Caption = ""
        Me.c1cmbBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.c1cmbBanco.DataSource = Me.BABancosBindingSource
        Me.c1cmbBanco.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.c1cmbBanco.DisplayMember = "DescripcionBanco"
        Me.c1cmbBanco.EditorBackColor = System.Drawing.SystemColors.Window
        Me.c1cmbBanco.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1cmbBanco.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.c1cmbBanco.Images.Add(CType(resources.GetObject("c1cmbBanco.Images"), System.Drawing.Image))
        Me.c1cmbBanco.Location = New System.Drawing.Point(54, 10)
        Me.c1cmbBanco.MatchEntryTimeout = CType(2000, Long)
        Me.c1cmbBanco.MaxDropDownItems = CType(5, Short)
        Me.c1cmbBanco.MaxLength = 32767
        Me.c1cmbBanco.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.c1cmbBanco.Name = "c1cmbBanco"
        Me.c1cmbBanco.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.c1cmbBanco.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.c1cmbBanco.Size = New System.Drawing.Size(314, 21)
        Me.c1cmbBanco.TabIndex = 1
        Me.c1cmbBanco.ValueMember = "CodigoBanco"
        Me.c1cmbBanco.PropBag = resources.GetString("c1cmbBanco.PropBag")
        '
        'BABancosBindingSource
        '
        Me.BABancosBindingSource.DataMember = "BABancos"
        Me.BABancosBindingSource.DataSource = Me.BATransaccionesListaDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Banco:"
        '
        'BATransaccionesEncabezadoTableAdapter
        '
        Me.BATransaccionesEncabezadoTableAdapter.ClearBeforeFill = True
        '
        'BABancosTableAdapter
        '
        Me.BABancosTableAdapter.ClearBeforeFill = True
        '
        'BAConfBindingSource
        '
        Me.BAConfBindingSource.DataMember = "BAConf"
        Me.BAConfBindingSource.DataSource = Me.BATransaccionesListaDataSet
        '
        'BAConfTableAdapter
        '
        Me.BAConfTableAdapter.ClearBeforeFill = True
        '
        'BADepNotasTransfFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 569)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.c1dbgrdNiveles)
        Me.Controls.Add(Me.ListaDataNavBarPrin)
        Me.Name = "BADepNotasTransfFrm"
        Me.Text = "Depósitos, Notas, Transferencias"
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BATransaccionesListaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1dbgrdNiveles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1cmbTipoTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1cmbBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BABancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAConfBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrincipalBindingSource As BindingSource
    Friend WithEvents BATransaccionesListaDataSet As BATransaccionesListaDataSet
    Friend WithEvents BATransaccionesEncabezadoTableAdapter As BATransaccionesListaDataSetTableAdapters.BATransaccionesEncabezadoTableAdapter
    Friend WithEvents ListaDataNavBarPrin As ListaDataNavBar
    Friend WithEvents c1dbgrdNiveles As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents c1cmbBanco As C1.Win.C1List.C1Combo
    Friend WithEvents Label1 As Label
    Friend WithEvents butCambiarPeriodo As Button
    Friend WithEvents lblMes As Label
    Friend WithEvents lblAño As Label
    Friend WithEvents butFiltrar As Button
    Friend WithEvents BABancosBindingSource As BindingSource
    Friend WithEvents BABancosTableAdapter As BATransaccionesListaDataSetTableAdapters.BABancosTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents c1cmbTipoTrans As C1.Win.C1Input.C1ComboBox
    Friend WithEvents BAConfBindingSource As BindingSource
    Friend WithEvents BAConfTableAdapter As BATransaccionesListaDataSetTableAdapters.BAConfTableAdapter
End Class
