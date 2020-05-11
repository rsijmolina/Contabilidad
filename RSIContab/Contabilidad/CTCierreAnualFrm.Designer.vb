<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTCierreAnualFrm
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
        Me.lblMesFin = New System.Windows.Forms.Label()
        Me.lblMesIni = New System.Windows.Forms.Label()
        Me.lblAñoFin = New System.Windows.Forms.Label()
        Me.lblAñoIni = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.butBuscarCtaIni = New System.Windows.Forms.Button()
        Me.lblNombreCtaIni = New System.Windows.Forms.Label()
        Me.txtCuentaIni = New System.Windows.Forms.TextBox()
        Me.butCancelar = New System.Windows.Forms.Button()
        Me.butAceptar = New System.Windows.Forms.Button()
        Me.CTSaldosMensualesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTSaldosMensualesDataSet = New RSIContab.CTSaldosMensualesDataSet()
        Me.CTSaldosMensualesTableAdapter = New RSIContab.CTSaldosMensualesDataSetTableAdapters.CTSaldosMensualesTableAdapter()
        Me.CTPartidaCierreAnualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTPartidasCierresDataSet = New RSIContab.CTPartidasCierresDataSet()
        Me.CTPartidasCierreAnualTableAdapter = New RSIContab.CTPartidasCierresDataSetTableAdapters.CTPartidasCierreAnualTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CTSaldosMensualesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTSaldosMensualesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTPartidaCierreAnualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTPartidasCierresDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(397, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Este proceso ejecutará el cierre contable del período actual, por favor ingrese a" & _
    "l información que a continuación se le pide:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblMesFin)
        Me.GroupBox1.Controls.Add(Me.lblMesIni)
        Me.GroupBox1.Controls.Add(Me.lblAñoFin)
        Me.GroupBox1.Controls.Add(Me.lblAñoIni)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 78)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Cierre"
        '
        'lblMesFin
        '
        Me.lblMesFin.AutoSize = True
        Me.lblMesFin.Location = New System.Drawing.Point(232, 51)
        Me.lblMesFin.Name = "lblMesFin"
        Me.lblMesFin.Size = New System.Drawing.Size(39, 13)
        Me.lblMesFin.TabIndex = 7
        Me.lblMesFin.Text = "Label6"
        '
        'lblMesIni
        '
        Me.lblMesIni.AutoSize = True
        Me.lblMesIni.Location = New System.Drawing.Point(72, 51)
        Me.lblMesIni.Name = "lblMesIni"
        Me.lblMesIni.Size = New System.Drawing.Size(39, 13)
        Me.lblMesIni.TabIndex = 6
        Me.lblMesIni.Text = "Label6"
        '
        'lblAñoFin
        '
        Me.lblAñoFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAñoFin.Location = New System.Drawing.Point(232, 16)
        Me.lblAñoFin.Name = "lblAñoFin"
        Me.lblAñoFin.Size = New System.Drawing.Size(67, 23)
        Me.lblAñoFin.TabIndex = 5
        '
        'lblAñoIni
        '
        Me.lblAñoIni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAñoIni.Location = New System.Drawing.Point(75, 16)
        Me.lblAñoIni.Name = "lblAñoIni"
        Me.lblAñoIni.Size = New System.Drawing.Size(67, 23)
        Me.lblAñoIni.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(177, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Al Cierre;"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(177, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Al Cierre;"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Mes Actual:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Año Actual:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.butBuscarCtaIni)
        Me.GroupBox2.Controls.Add(Me.lblNombreCtaIni)
        Me.GroupBox2.Controls.Add(Me.txtCuentaIni)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 59)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cuenta de Patrimonio Para Guardar la Utilidad o Pérdida del Período"
        '
        'butBuscarCtaIni
        '
        Me.butBuscarCtaIni.Image = Global.RSIContab.My.Resources.Resources._1425432924_Magnifier2
        Me.butBuscarCtaIni.Location = New System.Drawing.Point(122, 22)
        Me.butBuscarCtaIni.Name = "butBuscarCtaIni"
        Me.butBuscarCtaIni.Size = New System.Drawing.Size(22, 23)
        Me.butBuscarCtaIni.TabIndex = 9
        Me.butBuscarCtaIni.UseVisualStyleBackColor = True
        '
        'lblNombreCtaIni
        '
        Me.lblNombreCtaIni.BackColor = System.Drawing.Color.White
        Me.lblNombreCtaIni.Location = New System.Drawing.Point(153, 25)
        Me.lblNombreCtaIni.Name = "lblNombreCtaIni"
        Me.lblNombreCtaIni.Size = New System.Drawing.Size(241, 20)
        Me.lblNombreCtaIni.TabIndex = 8
        '
        'txtCuentaIni
        '
        Me.txtCuentaIni.Location = New System.Drawing.Point(7, 25)
        Me.txtCuentaIni.Name = "txtCuentaIni"
        Me.txtCuentaIni.Size = New System.Drawing.Size(115, 20)
        Me.txtCuentaIni.TabIndex = 7
        '
        'butCancelar
        '
        Me.butCancelar.Image = Global.RSIContab.My.Resources.Resources._1393662113_cancel
        Me.butCancelar.Location = New System.Drawing.Point(291, 220)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(107, 36)
        Me.butCancelar.TabIndex = 72
        Me.butCancelar.Text = "&Cancelar"
        Me.butCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butCancelar.UseVisualStyleBackColor = True
        '
        'butAceptar
        '
        Me.butAceptar.Image = Global.RSIContab.My.Resources.Resources._1393538844_tick_16
        Me.butAceptar.Location = New System.Drawing.Point(28, 220)
        Me.butAceptar.Name = "butAceptar"
        Me.butAceptar.Size = New System.Drawing.Size(107, 36)
        Me.butAceptar.TabIndex = 71
        Me.butAceptar.Text = "&Aceptar"
        Me.butAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butAceptar.UseVisualStyleBackColor = True
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
        'CTPartidaCierreAnualBindingSource
        '
        Me.CTPartidaCierreAnualBindingSource.DataMember = "CTPartidasCierreAnual"
        Me.CTPartidaCierreAnualBindingSource.DataSource = Me.CTPartidasCierresDataSet
        '
        'CTPartidasCierresDataSet
        '
        Me.CTPartidasCierresDataSet.DataSetName = "CTPartidasCierresDataSet"
        Me.CTPartidasCierresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CTPartidasCierreAnualTableAdapter
        '
        Me.CTPartidasCierreAnualTableAdapter.ClearBeforeFill = True
        '
        'CTCierreAnualFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 263)
        Me.Controls.Add(Me.butCancelar)
        Me.Controls.Add(Me.butAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CTCierreAnualFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cierre de Período"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CTSaldosMensualesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTSaldosMensualesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTPartidaCierreAnualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTPartidasCierresDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMesFin As System.Windows.Forms.Label
    Friend WithEvents lblMesIni As System.Windows.Forms.Label
    Friend WithEvents lblAñoFin As System.Windows.Forms.Label
    Friend WithEvents lblAñoIni As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents butBuscarCtaIni As System.Windows.Forms.Button
    Friend WithEvents lblNombreCtaIni As System.Windows.Forms.Label
    Friend WithEvents txtCuentaIni As System.Windows.Forms.TextBox
    Friend WithEvents butCancelar As System.Windows.Forms.Button
    Friend WithEvents butAceptar As System.Windows.Forms.Button
    Friend WithEvents CTSaldosMensualesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTSaldosMensualesDataSet As RSIContab.CTSaldosMensualesDataSet
    Friend WithEvents CTSaldosMensualesTableAdapter As RSIContab.CTSaldosMensualesDataSetTableAdapters.CTSaldosMensualesTableAdapter
    Friend WithEvents CTPartidaCierreAnualBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTPartidasCierresDataSet As RSIContab.CTPartidasCierresDataSet
    Friend WithEvents CTPartidasCierreAnualTableAdapter As RSIContab.CTPartidasCierresDataSetTableAdapters.CTPartidasCierreAnualTableAdapter
End Class
