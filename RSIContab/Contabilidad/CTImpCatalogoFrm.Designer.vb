<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTImpCatalogoFrm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButImpPlantilla = New System.Windows.Forms.RadioButton()
        Me.RadioButImpArchTexto = New System.Windows.Forms.RadioButton()
        Me.RadioButImpEntidad = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbEntidades = New System.Windows.Forms.ComboBox()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTEmpresasDataSet = New RSIContab.CTEmpresasDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombreArchivo = New System.Windows.Forms.TextBox()
        Me.butBuscarCtaIni = New System.Windows.Forms.Button()
        Me.butCancelar = New System.Windows.Forms.Button()
        Me.butAceptar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbPlantillas = New System.Windows.Forms.ComboBox()
        Me.CTPlantillasCatDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTPlantillasCatDataSet = New RSIContab.CTPlantillasCatDataSet()
        Me.OpenFileDlgArchivo = New System.Windows.Forms.OpenFileDialog()
        Me.DBTableAdapter = New RSIContab.CTEmpresasDataSetTableAdapters.DBTableAdapter()
        Me.PlantillasCatalogoEncTableAdapter = New RSIContab.CTPlantillasCatDataSetTableAdapters.PlantillasCatalogoEncTableAdapter()
        Me.CTCatalogoCuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTCatalogoCuentasDataSet = New RSIContab.CTCatalogoCuentasDataSet()
        Me.CTCatalogoCuentasTableAdapter = New RSIContab.CTCatalogoCuentasDataSetTableAdapters.CTCatalogoCuentasTableAdapter()
        Me.CTConfBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTConfDataSet = New RSIContab.CTConfDataSet()
        Me.CTConfTableAdapter = New RSIContab.CTConfDataSetTableAdapters.CTConfTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTEmpresasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTPlantillasCatDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTPlantillasCatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTCatalogoCuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTCatalogoCuentasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTConfBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTConfDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Esta utilidad le crea un nuevo Catálogo de Cuentas en la entidad actual a partir " & _
    "de uno existente. Si ya tiene cuentas el catálogo, serán eliminadas y reemplazad" & _
    "as."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButImpPlantilla)
        Me.GroupBox1.Controls.Add(Me.RadioButImpArchTexto)
        Me.GroupBox1.Controls.Add(Me.RadioButImpEntidad)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 93)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fuente"
        '
        'RadioButImpPlantilla
        '
        Me.RadioButImpPlantilla.AutoSize = True
        Me.RadioButImpPlantilla.Location = New System.Drawing.Point(7, 66)
        Me.RadioButImpPlantilla.Name = "RadioButImpPlantilla"
        Me.RadioButImpPlantilla.Size = New System.Drawing.Size(117, 17)
        Me.RadioButImpPlantilla.TabIndex = 2
        Me.RadioButImpPlantilla.Text = "Importar de Plantilla"
        Me.RadioButImpPlantilla.UseVisualStyleBackColor = True
        '
        'RadioButImpArchTexto
        '
        Me.RadioButImpArchTexto.AutoSize = True
        Me.RadioButImpArchTexto.Location = New System.Drawing.Point(7, 43)
        Me.RadioButImpArchTexto.Name = "RadioButImpArchTexto"
        Me.RadioButImpArchTexto.Size = New System.Drawing.Size(162, 17)
        Me.RadioButImpArchTexto.TabIndex = 1
        Me.RadioButImpArchTexto.Text = "Importar de Archivo de Texto"
        Me.RadioButImpArchTexto.UseVisualStyleBackColor = True
        '
        'RadioButImpEntidad
        '
        Me.RadioButImpEntidad.AutoSize = True
        Me.RadioButImpEntidad.Checked = True
        Me.RadioButImpEntidad.Location = New System.Drawing.Point(7, 20)
        Me.RadioButImpEntidad.Name = "RadioButImpEntidad"
        Me.RadioButImpEntidad.Size = New System.Drawing.Size(140, 17)
        Me.RadioButImpEntidad.TabIndex = 0
        Me.RadioButImpEntidad.TabStop = True
        Me.RadioButImpEntidad.Text = "Importar de Otra Entidad"
        Me.RadioButImpEntidad.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(256, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Entidad de Donde Importará el Catálogo de Cuentas:"
        '
        'cmbEntidades
        '
        Me.cmbEntidades.DataSource = Me.EmpresasBindingSource
        Me.cmbEntidades.DisplayMember = "NombreEmpresa"
        Me.cmbEntidades.FormattingEnabled = True
        Me.cmbEntidades.Location = New System.Drawing.Point(16, 184)
        Me.cmbEntidades.Name = "cmbEntidades"
        Me.cmbEntidades.Size = New System.Drawing.Size(357, 21)
        Me.cmbEntidades.TabIndex = 4
        Me.cmbEntidades.ValueMember = "ID"
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "DB"
        Me.EmpresasBindingSource.DataSource = Me.CTEmpresasDataSet
        '
        'CTEmpresasDataSet
        '
        Me.CTEmpresasDataSet.DataSetName = "CTEmpresasDataSet"
        Me.CTEmpresasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Importar de Este Archivo de Texto:"
        '
        'txtNombreArchivo
        '
        Me.txtNombreArchivo.Location = New System.Drawing.Point(16, 233)
        Me.txtNombreArchivo.Name = "txtNombreArchivo"
        Me.txtNombreArchivo.Size = New System.Drawing.Size(335, 20)
        Me.txtNombreArchivo.TabIndex = 6
        '
        'butBuscarCtaIni
        '
        Me.butBuscarCtaIni.Image = Global.RSIContab.My.Resources.Resources._1425432924_Magnifier2
        Me.butBuscarCtaIni.Location = New System.Drawing.Point(351, 231)
        Me.butBuscarCtaIni.Name = "butBuscarCtaIni"
        Me.butBuscarCtaIni.Size = New System.Drawing.Size(22, 23)
        Me.butBuscarCtaIni.TabIndex = 7
        Me.butBuscarCtaIni.UseVisualStyleBackColor = True
        '
        'butCancelar
        '
        Me.butCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butCancelar.Image = Global.RSIContab.My.Resources.Resources._1393662113_cancel
        Me.butCancelar.Location = New System.Drawing.Point(280, 316)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(107, 33)
        Me.butCancelar.TabIndex = 61
        Me.butCancelar.Text = "&Cancelar"
        Me.butCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butCancelar.UseVisualStyleBackColor = True
        '
        'butAceptar
        '
        Me.butAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.butAceptar.Image = Global.RSIContab.My.Resources.Resources._1393538844_tick_16
        Me.butAceptar.Location = New System.Drawing.Point(16, 316)
        Me.butAceptar.Name = "butAceptar"
        Me.butAceptar.Size = New System.Drawing.Size(107, 33)
        Me.butAceptar.TabIndex = 60
        Me.butAceptar.Text = "&Aceptar"
        Me.butAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butAceptar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Importar de Esta Plantilla:"
        '
        'cmbPlantillas
        '
        Me.cmbPlantillas.DataSource = Me.CTPlantillasCatDataSetBindingSource
        Me.cmbPlantillas.DisplayMember = "Descripcion"
        Me.cmbPlantillas.FormattingEnabled = True
        Me.cmbPlantillas.Location = New System.Drawing.Point(17, 284)
        Me.cmbPlantillas.Name = "cmbPlantillas"
        Me.cmbPlantillas.Size = New System.Drawing.Size(357, 21)
        Me.cmbPlantillas.TabIndex = 63
        Me.cmbPlantillas.ValueMember = "ID"
        '
        'CTPlantillasCatDataSetBindingSource
        '
        Me.CTPlantillasCatDataSetBindingSource.DataMember = "PlantillasCatalogoEnc"
        Me.CTPlantillasCatDataSetBindingSource.DataSource = Me.CTPlantillasCatDataSet
        '
        'CTPlantillasCatDataSet
        '
        Me.CTPlantillasCatDataSet.DataSetName = "CTPlantillasCatDataSet"
        Me.CTPlantillasCatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DBTableAdapter
        '
        Me.DBTableAdapter.ClearBeforeFill = True
        '
        'PlantillasCatalogoEncTableAdapter
        '
        Me.PlantillasCatalogoEncTableAdapter.ClearBeforeFill = True
        '
        'CTCatalogoCuentasBindingSource
        '
        Me.CTCatalogoCuentasBindingSource.DataMember = "CTCatalogoCuentas"
        Me.CTCatalogoCuentasBindingSource.DataSource = Me.CTCatalogoCuentasDataSet
        '
        'CTCatalogoCuentasDataSet
        '
        Me.CTCatalogoCuentasDataSet.DataSetName = "CTCatalogoCuentasDataSet"
        Me.CTCatalogoCuentasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CTCatalogoCuentasTableAdapter
        '
        Me.CTCatalogoCuentasTableAdapter.ClearBeforeFill = True
        '
        'CTConfBindingSource
        '
        Me.CTConfBindingSource.DataMember = "CTConf"
        Me.CTConfBindingSource.DataSource = Me.CTConfDataSet
        '
        'CTConfDataSet
        '
        Me.CTConfDataSet.DataSetName = "CTConfDataSet"
        Me.CTConfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CTConfTableAdapter
        '
        Me.CTConfTableAdapter.ClearBeforeFill = True
        '
        'CTImpCatalogoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 361)
        Me.Controls.Add(Me.cmbPlantillas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.butCancelar)
        Me.Controls.Add(Me.butAceptar)
        Me.Controls.Add(Me.butBuscarCtaIni)
        Me.Controls.Add(Me.txtNombreArchivo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbEntidades)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CTImpCatalogoFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Importar Catálogo de Cuentas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTEmpresasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTPlantillasCatDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTPlantillasCatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTCatalogoCuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTCatalogoCuentasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTConfBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTConfDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButImpPlantilla As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButImpArchTexto As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButImpEntidad As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbEntidades As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNombreArchivo As System.Windows.Forms.TextBox
    Friend WithEvents butBuscarCtaIni As System.Windows.Forms.Button
    Friend WithEvents butCancelar As System.Windows.Forms.Button
    Friend WithEvents butAceptar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbPlantillas As System.Windows.Forms.ComboBox
    Friend WithEvents OpenFileDlgArchivo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents EmpresasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTEmpresasDataSet As RSIContab.CTEmpresasDataSet
    Friend WithEvents DBTableAdapter As RSIContab.CTEmpresasDataSetTableAdapters.DBTableAdapter
    Friend WithEvents CTPlantillasCatDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTPlantillasCatDataSet As RSIContab.CTPlantillasCatDataSet
    Friend WithEvents PlantillasCatalogoEncTableAdapter As RSIContab.CTPlantillasCatDataSetTableAdapters.PlantillasCatalogoEncTableAdapter
    Friend WithEvents CTCatalogoCuentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTCatalogoCuentasDataSet As RSIContab.CTCatalogoCuentasDataSet
    Friend WithEvents CTCatalogoCuentasTableAdapter As RSIContab.CTCatalogoCuentasDataSetTableAdapters.CTCatalogoCuentasTableAdapter
    Friend WithEvents CTConfBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTConfDataSet As RSIContab.CTConfDataSet
    Friend WithEvents CTConfTableAdapter As RSIContab.CTConfDataSetTableAdapters.CTConfTableAdapter
End Class
