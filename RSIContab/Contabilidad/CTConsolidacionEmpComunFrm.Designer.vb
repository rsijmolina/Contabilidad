<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTConsolidacionEmpComunFrm
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
        Dim Style1 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style2 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style3 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style4 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style5 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CTConsolidacionEmpComunFrm))
        Dim Style6 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style7 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Dim Style8 As C1.Win.C1List.Style = New C1.Win.C1List.Style()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbMesConsolidar = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.c1numAñoConsolidar = New C1.Win.C1Input.C1NumericEdit()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.butCancelar = New System.Windows.Forms.Button()
        Me.butAceptar = New System.Windows.Forms.Button()
        Me.chklstboxEmpConsolidar = New System.Windows.Forms.CheckedListBox()
        Me.c1cmbEmpresaConsolidadora = New C1.Win.C1List.C1Combo()
        Me.BindingSourceEmpesasConsolidacion = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTEmpresasDataSet = New RSIContab.CTEmpresasDataSet()
        Me.BindingSourceEmpresasAConsolidar = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBConsTableAdapter = New RSIContab.CTEmpresasDataSetTableAdapters.DBConsTableAdapter()
        Me.DBEmpAConsolidarTableAdapter = New RSIContab.CTEmpresasDataSetTableAdapters.DBEmpAConsolidarTableAdapter()
        Me.BindingSourceTransEnc = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTConsolidacionDataSet = New RSIContab.CTConsolidacionDataSet()
        Me.CTTransaccionesEncabezadoTableAdapter = New RSIContab.CTConsolidacionDataSetTableAdapters.CTTransaccionesEncabezadoTableAdapter()
        Me.BindingSourceTransDet = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTTransaccionesDetalleTableAdapter = New RSIContab.CTConsolidacionDataSetTableAdapters.CTTransaccionesDetalleTableAdapter()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1numAñoConsolidar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1cmbEmpresaConsolidadora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceEmpesasConsolidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTEmpresasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceEmpresasAConsolidar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceTransEnc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTConsolidacionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceTransDet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Empresas a Consolidar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Empresa de Consolidación:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbMesConsolidar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.c1numAñoConsolidar)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 51)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Período"
        '
        'cmbMesConsolidar
        '
        Me.cmbMesConsolidar.FormattingEnabled = True
        Me.cmbMesConsolidar.Location = New System.Drawing.Point(226, 20)
        Me.cmbMesConsolidar.Name = "cmbMesConsolidar"
        Me.cmbMesConsolidar.Size = New System.Drawing.Size(121, 21)
        Me.cmbMesConsolidar.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(190, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Mes:"
        '
        'c1numAñoConsolidar
        '
        Me.c1numAñoConsolidar.DataType = GetType(Short)
        Me.c1numAñoConsolidar.Location = New System.Drawing.Point(47, 19)
        Me.c1numAñoConsolidar.Name = "c1numAñoConsolidar"
        Me.c1numAñoConsolidar.Size = New System.Drawing.Size(56, 20)
        Me.c1numAñoConsolidar.TabIndex = 13
        Me.c1numAñoConsolidar.Tag = Nothing
        Me.c1numAñoConsolidar.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(12, 19)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(29, 13)
        Me.Label23.TabIndex = 12
        Me.Label23.Text = "Año:"
        '
        'butCancelar
        '
        Me.butCancelar.Location = New System.Drawing.Point(277, 314)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(103, 36)
        Me.butCancelar.TabIndex = 25
        Me.butCancelar.Text = "&Cancelar"
        Me.butCancelar.UseVisualStyleBackColor = True
        '
        'butAceptar
        '
        Me.butAceptar.Location = New System.Drawing.Point(15, 314)
        Me.butAceptar.Name = "butAceptar"
        Me.butAceptar.Size = New System.Drawing.Size(103, 36)
        Me.butAceptar.TabIndex = 24
        Me.butAceptar.Text = "&Aceptar"
        Me.butAceptar.UseVisualStyleBackColor = True
        '
        'chklstboxEmpConsolidar
        '
        Me.chklstboxEmpConsolidar.FormattingEnabled = True
        Me.chklstboxEmpConsolidar.Location = New System.Drawing.Point(15, 149)
        Me.chklstboxEmpConsolidar.Name = "chklstboxEmpConsolidar"
        Me.chklstboxEmpConsolidar.Size = New System.Drawing.Size(365, 154)
        Me.chklstboxEmpConsolidar.TabIndex = 26
        '
        'c1cmbEmpresaConsolidadora
        '
        Me.c1cmbEmpresaConsolidadora.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.c1cmbEmpresaConsolidadora.AlternatingRows = True
        Me.c1cmbEmpresaConsolidadora.Caption = ""
        Me.c1cmbEmpresaConsolidadora.CaptionHeight = 17
        Me.c1cmbEmpresaConsolidadora.CaptionStyle = Style1
        Me.c1cmbEmpresaConsolidadora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.c1cmbEmpresaConsolidadora.ColumnCaptionHeight = 17
        Me.c1cmbEmpresaConsolidadora.ColumnFooterHeight = 17
        Me.c1cmbEmpresaConsolidadora.ContentHeight = 15
        Me.c1cmbEmpresaConsolidadora.DataSource = Me.BindingSourceEmpesasConsolidacion
        Me.c1cmbEmpresaConsolidadora.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.c1cmbEmpresaConsolidadora.DisplayMember = "NombreEmpresa"
        Me.c1cmbEmpresaConsolidadora.EditorBackColor = System.Drawing.SystemColors.Window
        Me.c1cmbEmpresaConsolidadora.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1cmbEmpresaConsolidadora.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.c1cmbEmpresaConsolidadora.EditorHeight = 15
        Me.c1cmbEmpresaConsolidadora.EvenRowStyle = Style2
        Me.c1cmbEmpresaConsolidadora.FooterStyle = Style3
        Me.c1cmbEmpresaConsolidadora.HeadingStyle = Style4
        Me.c1cmbEmpresaConsolidadora.HighLightRowStyle = Style5
        Me.c1cmbEmpresaConsolidadora.Images.Add(CType(resources.GetObject("c1cmbEmpresaConsolidadora.Images"), System.Drawing.Image))
        Me.c1cmbEmpresaConsolidadora.ItemHeight = 15
        Me.c1cmbEmpresaConsolidadora.LimitToList = True
        Me.c1cmbEmpresaConsolidadora.Location = New System.Drawing.Point(15, 95)
        Me.c1cmbEmpresaConsolidadora.MatchEntryTimeout = CType(2000, Long)
        Me.c1cmbEmpresaConsolidadora.MaxDropDownItems = CType(5, Short)
        Me.c1cmbEmpresaConsolidadora.MaxLength = 32767
        Me.c1cmbEmpresaConsolidadora.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.c1cmbEmpresaConsolidadora.Name = "c1cmbEmpresaConsolidadora"
        Me.c1cmbEmpresaConsolidadora.OddRowStyle = Style6
        Me.c1cmbEmpresaConsolidadora.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.c1cmbEmpresaConsolidadora.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.c1cmbEmpresaConsolidadora.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.c1cmbEmpresaConsolidadora.SelectedStyle = Style7
        Me.c1cmbEmpresaConsolidadora.Size = New System.Drawing.Size(365, 21)
        Me.c1cmbEmpresaConsolidadora.Style = Style8
        Me.c1cmbEmpresaConsolidadora.TabIndex = 37
        Me.c1cmbEmpresaConsolidadora.Tag = "CM"
        Me.c1cmbEmpresaConsolidadora.ValueMember = "ID"
        Me.c1cmbEmpresaConsolidadora.PropBag = resources.GetString("c1cmbEmpresaConsolidadora.PropBag")
        '
        'BindingSourceEmpesasConsolidacion
        '
        Me.BindingSourceEmpesasConsolidacion.DataMember = "DBCons"
        Me.BindingSourceEmpesasConsolidacion.DataSource = Me.CTEmpresasDataSet
        '
        'CTEmpresasDataSet
        '
        Me.CTEmpresasDataSet.DataSetName = "CTEmpresasDataSet"
        Me.CTEmpresasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSourceEmpresasAConsolidar
        '
        Me.BindingSourceEmpresasAConsolidar.DataMember = "DBEmpAConsolidar"
        Me.BindingSourceEmpresasAConsolidar.DataSource = Me.CTEmpresasDataSet
        '
        'DBConsTableAdapter
        '
        Me.DBConsTableAdapter.ClearBeforeFill = True
        '
        'DBEmpAConsolidarTableAdapter
        '
        Me.DBEmpAConsolidarTableAdapter.ClearBeforeFill = True
        '
        'BindingSourceTransEnc
        '
        Me.BindingSourceTransEnc.DataMember = "CTTransaccionesEncabezado"
        Me.BindingSourceTransEnc.DataSource = Me.CTConsolidacionDataSet
        '
        'CTConsolidacionDataSet
        '
        Me.CTConsolidacionDataSet.DataSetName = "CTConsolidacionDataSet"
        Me.CTConsolidacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CTTransaccionesEncabezadoTableAdapter
        '
        Me.CTTransaccionesEncabezadoTableAdapter.ClearBeforeFill = True
        '
        'BindingSourceTransDet
        '
        Me.BindingSourceTransDet.DataMember = "CTTransaccionesDetalle"
        Me.BindingSourceTransDet.DataSource = Me.CTConsolidacionDataSet
        '
        'CTTransaccionesDetalleTableAdapter
        '
        Me.CTTransaccionesDetalleTableAdapter.ClearBeforeFill = True
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(156, 326)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(86, 13)
        Me.lblMensaje.TabIndex = 38
        Me.lblMensaje.Text = "Procesando..."
        Me.lblMensaje.Visible = False
        '
        'CTConsolidacionEmpComunFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 362)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.c1cmbEmpresaConsolidadora)
        Me.Controls.Add(Me.chklstboxEmpConsolidar)
        Me.Controls.Add(Me.butCancelar)
        Me.Controls.Add(Me.butAceptar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CTConsolidacionEmpComunFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consolidación de Empresas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1numAñoConsolidar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1cmbEmpresaConsolidadora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceEmpesasConsolidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTEmpresasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceEmpresasAConsolidar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceTransEnc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTConsolidacionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceTransDet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbMesConsolidar As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents c1numAñoConsolidar As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents butCancelar As System.Windows.Forms.Button
    Friend WithEvents butAceptar As System.Windows.Forms.Button
    Friend WithEvents chklstboxEmpConsolidar As System.Windows.Forms.CheckedListBox
    Friend WithEvents BindingSourceEmpesasConsolidacion As System.Windows.Forms.BindingSource
    Friend WithEvents CTEmpresasDataSet As RSIContab.CTEmpresasDataSet
    Friend WithEvents DBConsTableAdapter As RSIContab.CTEmpresasDataSetTableAdapters.DBConsTableAdapter
    Friend WithEvents BindingSourceEmpresasAConsolidar As System.Windows.Forms.BindingSource
    Friend WithEvents DBEmpAConsolidarTableAdapter As RSIContab.CTEmpresasDataSetTableAdapters.DBEmpAConsolidarTableAdapter
    Friend WithEvents c1cmbEmpresaConsolidadora As C1.Win.C1List.C1Combo
    Friend WithEvents BindingSourceTransEnc As System.Windows.Forms.BindingSource
    Friend WithEvents CTConsolidacionDataSet As RSIContab.CTConsolidacionDataSet
    Friend WithEvents CTTransaccionesEncabezadoTableAdapter As RSIContab.CTConsolidacionDataSetTableAdapters.CTTransaccionesEncabezadoTableAdapter
    Friend WithEvents BindingSourceTransDet As System.Windows.Forms.BindingSource
    Friend WithEvents CTTransaccionesDetalleTableAdapter As RSIContab.CTConsolidacionDataSetTableAdapters.CTTransaccionesDetalleTableAdapter
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
End Class
