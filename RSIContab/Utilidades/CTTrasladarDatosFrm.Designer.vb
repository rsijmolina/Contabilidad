<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTTrasladarDatosFrm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radiobutBancos = New System.Windows.Forms.RadioButton()
        Me.radiobutContab = New System.Windows.Forms.RadioButton()
        Me.txtBaseDatos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageContab = New System.Windows.Forms.TabPage()
        Me.c1numMesFin = New C1.Win.C1Input.C1NumericEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.c1numMesIni = New C1.Win.C1Input.C1NumericEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButTransaccionesDet = New System.Windows.Forms.RadioButton()
        Me.c1numAñoCont = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButMesesCerrados = New System.Windows.Forms.RadioButton()
        Me.RadioButPresupuesto = New System.Windows.Forms.RadioButton()
        Me.RadioButSaldos = New System.Windows.Forms.RadioButton()
        Me.RadioButTransaccionesEnc = New System.Windows.Forms.RadioButton()
        Me.RadioButCatalogo = New System.Windows.Forms.RadioButton()
        Me.RadioButTiposPartidas = New System.Windows.Forms.RadioButton()
        Me.RadioButConfCont = New System.Windows.Forms.RadioButton()
        Me.TabPageBancos = New System.Windows.Forms.TabPage()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.OpenFileDlgBaseDatos = New System.Windows.Forms.OpenFileDialog()
        Me.CtTrasDatosDataSet = New RSIContab.CTTrasladoDatosDataSet()
        Me.RadioButTransEncDet = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageContab.SuspendLayout()
        CType(Me.c1numMesFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numMesIni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1numAñoCont, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtTrasDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radiobutBancos)
        Me.GroupBox1.Controls.Add(Me.radiobutContab)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 50)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Trasladar"
        '
        'radiobutBancos
        '
        Me.radiobutBancos.AutoSize = True
        Me.radiobutBancos.Location = New System.Drawing.Point(160, 19)
        Me.radiobutBancos.Name = "radiobutBancos"
        Me.radiobutBancos.Size = New System.Drawing.Size(107, 17)
        Me.radiobutBancos.TabIndex = 1
        Me.radiobutBancos.TabStop = True
        Me.radiobutBancos.Text = "Datos de Bancos"
        Me.radiobutBancos.UseVisualStyleBackColor = True
        '
        'radiobutContab
        '
        Me.radiobutContab.AutoSize = True
        Me.radiobutContab.Location = New System.Drawing.Point(16, 20)
        Me.radiobutContab.Name = "radiobutContab"
        Me.radiobutContab.Size = New System.Drawing.Size(129, 17)
        Me.radiobutContab.TabIndex = 0
        Me.radiobutContab.TabStop = True
        Me.radiobutContab.Text = "Datos de Contabilidad"
        Me.radiobutContab.UseVisualStyleBackColor = True
        '
        'txtBaseDatos
        '
        Me.txtBaseDatos.Location = New System.Drawing.Point(103, 247)
        Me.txtBaseDatos.Name = "txtBaseDatos"
        Me.txtBaseDatos.Size = New System.Drawing.Size(268, 20)
        Me.txtBaseDatos.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 247)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Base de Datos:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageContab)
        Me.TabControl1.Controls.Add(Me.TabPageBancos)
        Me.TabControl1.Location = New System.Drawing.Point(13, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(401, 180)
        Me.TabControl1.TabIndex = 12
        '
        'TabPageContab
        '
        Me.TabPageContab.Controls.Add(Me.RadioButTransEncDet)
        Me.TabPageContab.Controls.Add(Me.c1numMesFin)
        Me.TabPageContab.Controls.Add(Me.Label4)
        Me.TabPageContab.Controls.Add(Me.c1numMesIni)
        Me.TabPageContab.Controls.Add(Me.Label3)
        Me.TabPageContab.Controls.Add(Me.RadioButTransaccionesDet)
        Me.TabPageContab.Controls.Add(Me.c1numAñoCont)
        Me.TabPageContab.Controls.Add(Me.Label1)
        Me.TabPageContab.Controls.Add(Me.RadioButMesesCerrados)
        Me.TabPageContab.Controls.Add(Me.RadioButPresupuesto)
        Me.TabPageContab.Controls.Add(Me.RadioButSaldos)
        Me.TabPageContab.Controls.Add(Me.RadioButTransaccionesEnc)
        Me.TabPageContab.Controls.Add(Me.RadioButCatalogo)
        Me.TabPageContab.Controls.Add(Me.RadioButTiposPartidas)
        Me.TabPageContab.Controls.Add(Me.RadioButConfCont)
        Me.TabPageContab.Location = New System.Drawing.Point(4, 22)
        Me.TabPageContab.Name = "TabPageContab"
        Me.TabPageContab.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageContab.Size = New System.Drawing.Size(393, 154)
        Me.TabPageContab.TabIndex = 0
        Me.TabPageContab.Text = "Datos de Contabilidad"
        Me.TabPageContab.UseVisualStyleBackColor = True
        '
        'c1numMesFin
        '
        Me.c1numMesFin.DataType = GetType(Short)
        Me.c1numMesFin.Location = New System.Drawing.Point(306, 98)
        Me.c1numMesFin.Name = "c1numMesFin"
        Me.c1numMesFin.Size = New System.Drawing.Size(21, 20)
        Me.c1numMesFin.TabIndex = 18
        Me.c1numMesFin.Tag = Nothing
        Me.c1numMesFin.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(245, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Mes Final:"
        '
        'c1numMesIni
        '
        Me.c1numMesIni.DataType = GetType(Short)
        Me.c1numMesIni.Location = New System.Drawing.Point(220, 98)
        Me.c1numMesIni.Name = "c1numMesIni"
        Me.c1numMesIni.Size = New System.Drawing.Size(19, 20)
        Me.c1numMesIni.TabIndex = 16
        Me.c1numMesIni.Tag = Nothing
        Me.c1numMesIni.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(154, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Mes Inicial:"
        '
        'RadioButTransaccionesDet
        '
        Me.RadioButTransaccionesDet.AutoSize = True
        Me.RadioButTransaccionesDet.Location = New System.Drawing.Point(11, 101)
        Me.RadioButTransaccionesDet.Name = "RadioButTransaccionesDet"
        Me.RadioButTransaccionesDet.Size = New System.Drawing.Size(115, 17)
        Me.RadioButTransaccionesDet.TabIndex = 14
        Me.RadioButTransaccionesDet.TabStop = True
        Me.RadioButTransaccionesDet.Text = "Transacciones Det"
        Me.RadioButTransaccionesDet.UseVisualStyleBackColor = True
        '
        'c1numAñoCont
        '
        Me.c1numAñoCont.DataType = GetType(Short)
        Me.c1numAñoCont.Location = New System.Drawing.Point(244, 76)
        Me.c1numAñoCont.Name = "c1numAñoCont"
        Me.c1numAñoCont.Size = New System.Drawing.Size(53, 20)
        Me.c1numAñoCont.TabIndex = 13
        Me.c1numAñoCont.Tag = Nothing
        Me.c1numAñoCont.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Año a Trasladar:"
        '
        'RadioButMesesCerrados
        '
        Me.RadioButMesesCerrados.AutoSize = True
        Me.RadioButMesesCerrados.Location = New System.Drawing.Point(155, 53)
        Me.RadioButMesesCerrados.Name = "RadioButMesesCerrados"
        Me.RadioButMesesCerrados.Size = New System.Drawing.Size(101, 17)
        Me.RadioButMesesCerrados.TabIndex = 6
        Me.RadioButMesesCerrados.TabStop = True
        Me.RadioButMesesCerrados.Text = "Meses Cerrados"
        Me.RadioButMesesCerrados.UseVisualStyleBackColor = True
        '
        'RadioButPresupuesto
        '
        Me.RadioButPresupuesto.AutoSize = True
        Me.RadioButPresupuesto.Location = New System.Drawing.Point(155, 30)
        Me.RadioButPresupuesto.Name = "RadioButPresupuesto"
        Me.RadioButPresupuesto.Size = New System.Drawing.Size(84, 17)
        Me.RadioButPresupuesto.TabIndex = 5
        Me.RadioButPresupuesto.TabStop = True
        Me.RadioButPresupuesto.Text = "Presupuesto"
        Me.RadioButPresupuesto.UseVisualStyleBackColor = True
        '
        'RadioButSaldos
        '
        Me.RadioButSaldos.AutoSize = True
        Me.RadioButSaldos.Location = New System.Drawing.Point(155, 7)
        Me.RadioButSaldos.Name = "RadioButSaldos"
        Me.RadioButSaldos.Size = New System.Drawing.Size(57, 17)
        Me.RadioButSaldos.TabIndex = 4
        Me.RadioButSaldos.TabStop = True
        Me.RadioButSaldos.Text = "Saldos"
        Me.RadioButSaldos.UseVisualStyleBackColor = True
        '
        'RadioButTransaccionesEnc
        '
        Me.RadioButTransaccionesEnc.AutoSize = True
        Me.RadioButTransaccionesEnc.Location = New System.Drawing.Point(11, 76)
        Me.RadioButTransaccionesEnc.Name = "RadioButTransaccionesEnc"
        Me.RadioButTransaccionesEnc.Size = New System.Drawing.Size(117, 17)
        Me.RadioButTransaccionesEnc.TabIndex = 3
        Me.RadioButTransaccionesEnc.TabStop = True
        Me.RadioButTransaccionesEnc.Text = "Transacciones Enc"
        Me.RadioButTransaccionesEnc.UseVisualStyleBackColor = True
        '
        'RadioButCatalogo
        '
        Me.RadioButCatalogo.AutoSize = True
        Me.RadioButCatalogo.Location = New System.Drawing.Point(11, 53)
        Me.RadioButCatalogo.Name = "RadioButCatalogo"
        Me.RadioButCatalogo.Size = New System.Drawing.Size(124, 17)
        Me.RadioButCatalogo.TabIndex = 2
        Me.RadioButCatalogo.TabStop = True
        Me.RadioButCatalogo.Text = "Catálogo de Cuentas"
        Me.RadioButCatalogo.UseVisualStyleBackColor = True
        '
        'RadioButTiposPartidas
        '
        Me.RadioButTiposPartidas.AutoSize = True
        Me.RadioButTiposPartidas.Location = New System.Drawing.Point(11, 30)
        Me.RadioButTiposPartidas.Name = "RadioButTiposPartidas"
        Me.RadioButTiposPartidas.Size = New System.Drawing.Size(107, 17)
        Me.RadioButTiposPartidas.TabIndex = 1
        Me.RadioButTiposPartidas.TabStop = True
        Me.RadioButTiposPartidas.Text = "Tipos de Partidas"
        Me.RadioButTiposPartidas.UseVisualStyleBackColor = True
        '
        'RadioButConfCont
        '
        Me.RadioButConfCont.AutoSize = True
        Me.RadioButConfCont.Location = New System.Drawing.Point(11, 7)
        Me.RadioButConfCont.Name = "RadioButConfCont"
        Me.RadioButConfCont.Size = New System.Drawing.Size(90, 17)
        Me.RadioButConfCont.TabIndex = 0
        Me.RadioButConfCont.TabStop = True
        Me.RadioButConfCont.Text = "Configuración"
        Me.RadioButConfCont.UseVisualStyleBackColor = True
        '
        'TabPageBancos
        '
        Me.TabPageBancos.Location = New System.Drawing.Point(4, 22)
        Me.TabPageBancos.Name = "TabPageBancos"
        Me.TabPageBancos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageBancos.Size = New System.Drawing.Size(393, 121)
        Me.TabPageBancos.TabIndex = 1
        Me.TabPageBancos.Text = "Datos de Bancos"
        Me.TabPageBancos.UseVisualStyleBackColor = True
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(39, 282)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(111, 29)
        Me.btnProcesar.TabIndex = 13
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(280, 282)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(111, 29)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(377, 245)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(35, 23)
        Me.btnBuscar.TabIndex = 15
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'CtTrasDatosDataSet
        '
        Me.CtTrasDatosDataSet.DataSetName = "CTTrasladoDatosDataSet"
        Me.CtTrasDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RadioButTransEncDet
        '
        Me.RadioButTransEncDet.AutoSize = True
        Me.RadioButTransEncDet.Location = New System.Drawing.Point(11, 124)
        Me.RadioButTransEncDet.Name = "RadioButTransEncDet"
        Me.RadioButTransEncDet.Size = New System.Drawing.Size(256, 17)
        Me.RadioButTransEncDet.TabIndex = 19
        Me.RadioButTransEncDet.TabStop = True
        Me.RadioButTransEncDet.Text = "Transacciones Enc y Det Para Evitar Duplicados"
        Me.RadioButTransEncDet.UseVisualStyleBackColor = True
        '
        'CTTrasladarDatosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 323)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBaseDatos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CTTrasladarDatosFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trasladar Datos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageContab.ResumeLayout(False)
        Me.TabPageContab.PerformLayout()
        CType(Me.c1numMesFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numMesIni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1numAñoCont, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtTrasDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radiobutBancos As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutContab As System.Windows.Forms.RadioButton
    Friend WithEvents txtBaseDatos As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageContab As System.Windows.Forms.TabPage
    Friend WithEvents RadioButSaldos As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButTransaccionesEnc As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButCatalogo As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButTiposPartidas As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButConfCont As System.Windows.Forms.RadioButton
    Friend WithEvents TabPageBancos As System.Windows.Forms.TabPage
    Friend WithEvents c1numAñoCont As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButMesesCerrados As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButPresupuesto As System.Windows.Forms.RadioButton
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDlgBaseDatos As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CtTrasDatosDataSet As RSIContab.CTTrasladoDatosDataSet
    Friend WithEvents c1numMesFin As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents c1numMesIni As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RadioButTransaccionesDet As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButTransEncDet As System.Windows.Forms.RadioButton
End Class
