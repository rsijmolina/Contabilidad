<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTConsolidacionExpImpFrm
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
        Me.butBuscarArch = New System.Windows.Forms.Button()
        Me.txtNombreArchivo = New System.Windows.Forms.TextBox()
        Me.lblNombreArchivo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbMesConsolidar = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.c1numAñoConsolidar = New C1.Win.C1Input.C1NumericEdit()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.butCancelar = New System.Windows.Forms.Button()
        Me.butAceptar = New System.Windows.Forms.Button()
        Me.OpenFileDlgArchivo = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDlgArchivo = New System.Windows.Forms.SaveFileDialog()
        Me.CTCatalogoCuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTCatalogoCuentasDataSet = New RSIContab.CTCatalogoCuentasDataSet()
        Me.CTCatalogoCuentasTableAdapter = New RSIContab.CTCatalogoCuentasDataSetTableAdapters.CTCatalogoCuentasTableAdapter()
        Me.CTSaldosMensualesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTSaldosMensualesDataSet = New RSIContab.CTSaldosMensualesDataSet()
        Me.CTSaldosMensualesTableAdapter = New RSIContab.CTSaldosMensualesDataSetTableAdapters.CTSaldosMensualesTableAdapter()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.chkBoxIniTablas = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1numAñoConsolidar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTCatalogoCuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTCatalogoCuentasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTSaldosMensualesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTSaldosMensualesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'butBuscarArch
        '
        Me.butBuscarArch.Image = Global.RSIContab.My.Resources.Resources._1425432924_Magnifier2
        Me.butBuscarArch.Location = New System.Drawing.Point(389, 25)
        Me.butBuscarArch.Name = "butBuscarArch"
        Me.butBuscarArch.Size = New System.Drawing.Size(22, 23)
        Me.butBuscarArch.TabIndex = 67
        Me.butBuscarArch.UseVisualStyleBackColor = True
        '
        'txtNombreArchivo
        '
        Me.txtNombreArchivo.Location = New System.Drawing.Point(12, 28)
        Me.txtNombreArchivo.Name = "txtNombreArchivo"
        Me.txtNombreArchivo.Size = New System.Drawing.Size(376, 20)
        Me.txtNombreArchivo.TabIndex = 66
        '
        'lblNombreArchivo
        '
        Me.lblNombreArchivo.AutoSize = True
        Me.lblNombreArchivo.Location = New System.Drawing.Point(10, 12)
        Me.lblNombreArchivo.Name = "lblNombreArchivo"
        Me.lblNombreArchivo.Size = New System.Drawing.Size(154, 13)
        Me.lblNombreArchivo.TabIndex = 65
        Me.lblNombreArchivo.Text = "Nombre del Archivo Exportado:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbMesConsolidar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.c1numAñoConsolidar)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 51)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Período"
        '
        'cmbMesConsolidar
        '
        Me.cmbMesConsolidar.FormattingEnabled = True
        Me.cmbMesConsolidar.Location = New System.Drawing.Point(213, 19)
        Me.cmbMesConsolidar.Name = "cmbMesConsolidar"
        Me.cmbMesConsolidar.Size = New System.Drawing.Size(121, 21)
        Me.cmbMesConsolidar.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(177, 18)
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
        Me.butCancelar.Image = Global.RSIContab.My.Resources.Resources._1393662113_cancel
        Me.butCancelar.Location = New System.Drawing.Point(291, 181)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(107, 36)
        Me.butCancelar.TabIndex = 70
        Me.butCancelar.Text = "&Cancelar"
        Me.butCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butCancelar.UseVisualStyleBackColor = True
        '
        'butAceptar
        '
        Me.butAceptar.Image = Global.RSIContab.My.Resources.Resources._1393538844_tick_16
        Me.butAceptar.Location = New System.Drawing.Point(28, 181)
        Me.butAceptar.Name = "butAceptar"
        Me.butAceptar.Size = New System.Drawing.Size(107, 36)
        Me.butAceptar.TabIndex = 69
        Me.butAceptar.Text = "&Aceptar"
        Me.butAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butAceptar.UseVisualStyleBackColor = True
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
        'CTSaldosMensualesBindingSource
        '
        Me.CTSaldosMensualesBindingSource.DataMember = "CTSaldosMensuales"
        Me.CTSaldosMensualesBindingSource.DataSource = Me.CTSaldosMensualesDataSet
        '
        'CTSaldosMensualesDataSet
        '
        Me.CTSaldosMensualesDataSet.DataSetName = "CTSaldosMensualesDataSet"
        Me.CTSaldosMensualesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CTSaldosMensualesTableAdapter
        '
        Me.CTSaldosMensualesTableAdapter.ClearBeforeFill = True
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(144, 165)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(132, 13)
        Me.lblMensaje.TabIndex = 71
        Me.lblMensaje.Text = "Procesando, espere..."
        Me.lblMensaje.Visible = False
        '
        'chkBoxIniTablas
        '
        Me.chkBoxIniTablas.Location = New System.Drawing.Point(13, 122)
        Me.chkBoxIniTablas.Name = "chkBoxIniTablas"
        Me.chkBoxIniTablas.Size = New System.Drawing.Size(398, 40)
        Me.chkBoxIniTablas.TabIndex = 72
        Me.chkBoxIniTablas.Text = "Inicializar Valores en Tablas.  Marque si es la Primera Empresa a Consolidar, con" & _
    " las Restantes Desmarque la Casilla."
        Me.chkBoxIniTablas.UseVisualStyleBackColor = True
        Me.chkBoxIniTablas.Visible = False
        '
        'CTConsolidacionExpImpFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 229)
        Me.Controls.Add(Me.chkBoxIniTablas)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.butCancelar)
        Me.Controls.Add(Me.butAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.butBuscarArch)
        Me.Controls.Add(Me.txtNombreArchivo)
        Me.Controls.Add(Me.lblNombreArchivo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CTConsolidacionExpImpFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consolidación"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1numAñoConsolidar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTCatalogoCuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTCatalogoCuentasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTSaldosMensualesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTSaldosMensualesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents butBuscarArch As System.Windows.Forms.Button
    Friend WithEvents txtNombreArchivo As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreArchivo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbMesConsolidar As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents c1numAñoConsolidar As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents butCancelar As System.Windows.Forms.Button
    Friend WithEvents butAceptar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDlgArchivo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDlgArchivo As System.Windows.Forms.SaveFileDialog
    Friend WithEvents CTCatalogoCuentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTCatalogoCuentasDataSet As RSIContab.CTCatalogoCuentasDataSet
    Friend WithEvents CTCatalogoCuentasTableAdapter As RSIContab.CTCatalogoCuentasDataSetTableAdapters.CTCatalogoCuentasTableAdapter
    Friend WithEvents CTSaldosMensualesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTSaldosMensualesDataSet As RSIContab.CTSaldosMensualesDataSet
    Friend WithEvents CTSaldosMensualesTableAdapter As RSIContab.CTSaldosMensualesDataSetTableAdapters.CTSaldosMensualesTableAdapter
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents chkBoxIniTablas As System.Windows.Forms.CheckBox
End Class
