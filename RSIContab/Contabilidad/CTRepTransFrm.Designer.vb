<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTRepTransFrm
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
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbMeses = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.c1numAñoUsuario = New C1.Win.C1Input.C1NumericEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkboxUtilizarPeriodoUsuario = New System.Windows.Forms.CheckBox()
        Me.c1dateFecha = New C1.Win.C1Input.C1DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radiobutTodasPartidas = New System.Windows.Forms.RadioButton()
        Me.radiobutTipoPartidas = New System.Windows.Forms.RadioButton()
        Me.radiobutRangoPartidas = New System.Windows.Forms.RadioButton()
        Me.radiobutEstaFecha = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPartidaFinal = New System.Windows.Forms.TextBox()
        Me.txtPartidaInicial = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbTipoPartida = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnPartidaCierre = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.c1numAñoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPeriodo
        '
        Me.lblPeriodo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPeriodo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodo.ForeColor = System.Drawing.Color.White
        Me.lblPeriodo.Location = New System.Drawing.Point(0, 0)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(343, 20)
        Me.lblPeriodo.TabIndex = 31
        Me.lblPeriodo.Text = "Periodo Actual"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbMeses)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.c1numAñoUsuario)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.chkboxUtilizarPeriodoUsuario)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(318, 52)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        '
        'cmbMeses
        '
        Me.cmbMeses.FormattingEnabled = True
        Me.cmbMeses.Location = New System.Drawing.Point(131, 19)
        Me.cmbMeses.Name = "cmbMeses"
        Me.cmbMeses.Size = New System.Drawing.Size(101, 21)
        Me.cmbMeses.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Mes:"
        '
        'c1numAñoUsuario
        '
        Me.c1numAñoUsuario.DataType = GetType(Short)
        Me.c1numAñoUsuario.Location = New System.Drawing.Point(41, 19)
        Me.c1numAñoUsuario.Name = "c1numAñoUsuario"
        Me.c1numAñoUsuario.Size = New System.Drawing.Size(50, 20)
        Me.c1numAñoUsuario.TabIndex = 25
        Me.c1numAñoUsuario.Tag = Nothing
        Me.c1numAñoUsuario.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Año:"
        '
        'chkboxUtilizarPeriodoUsuario
        '
        Me.chkboxUtilizarPeriodoUsuario.AutoSize = True
        Me.chkboxUtilizarPeriodoUsuario.Location = New System.Drawing.Point(9, 0)
        Me.chkboxUtilizarPeriodoUsuario.Name = "chkboxUtilizarPeriodoUsuario"
        Me.chkboxUtilizarPeriodoUsuario.Size = New System.Drawing.Size(122, 17)
        Me.chkboxUtilizarPeriodoUsuario.TabIndex = 0
        Me.chkboxUtilizarPeriodoUsuario.Text = "Utilizar Este Período"
        Me.chkboxUtilizarPeriodoUsuario.UseVisualStyleBackColor = True
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
        Me.c1dateFecha.Location = New System.Drawing.Point(139, 83)
        Me.c1dateFecha.Name = "c1dateFecha"
        Me.c1dateFecha.Size = New System.Drawing.Size(105, 20)
        Me.c1dateFecha.TabIndex = 34
        Me.c1dateFecha.Tag = Nothing
        Me.c1dateFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Fecha:"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(241, 279)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(89, 33)
        Me.btnCancelar.TabIndex = 36
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(21, 279)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(89, 33)
        Me.btnAceptar.TabIndex = 35
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radiobutTodasPartidas)
        Me.GroupBox1.Controls.Add(Me.radiobutTipoPartidas)
        Me.GroupBox1.Controls.Add(Me.radiobutRangoPartidas)
        Me.GroupBox1.Controls.Add(Me.radiobutEstaFecha)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 116)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listar por"
        '
        'radiobutTodasPartidas
        '
        Me.radiobutTodasPartidas.AutoSize = True
        Me.radiobutTodasPartidas.Location = New System.Drawing.Point(10, 42)
        Me.radiobutTodasPartidas.Name = "radiobutTodasPartidas"
        Me.radiobutTodasPartidas.Size = New System.Drawing.Size(112, 17)
        Me.radiobutTodasPartidas.TabIndex = 3
        Me.radiobutTodasPartidas.Text = "Todas las Partidas"
        Me.radiobutTodasPartidas.UseVisualStyleBackColor = True
        '
        'radiobutTipoPartidas
        '
        Me.radiobutTipoPartidas.AutoSize = True
        Me.radiobutTipoPartidas.Location = New System.Drawing.Point(10, 88)
        Me.radiobutTipoPartidas.Name = "radiobutTipoPartidas"
        Me.radiobutTipoPartidas.Size = New System.Drawing.Size(97, 17)
        Me.radiobutTipoPartidas.TabIndex = 2
        Me.radiobutTipoPartidas.Text = "Tipo de Partida"
        Me.radiobutTipoPartidas.UseVisualStyleBackColor = True
        '
        'radiobutRangoPartidas
        '
        Me.radiobutRangoPartidas.AutoSize = True
        Me.radiobutRangoPartidas.Location = New System.Drawing.Point(10, 65)
        Me.radiobutRangoPartidas.Name = "radiobutRangoPartidas"
        Me.radiobutRangoPartidas.Size = New System.Drawing.Size(113, 17)
        Me.radiobutRangoPartidas.TabIndex = 1
        Me.radiobutRangoPartidas.Text = "Rango de Partidas"
        Me.radiobutRangoPartidas.UseVisualStyleBackColor = True
        '
        'radiobutEstaFecha
        '
        Me.radiobutEstaFecha.AutoSize = True
        Me.radiobutEstaFecha.Checked = True
        Me.radiobutEstaFecha.Location = New System.Drawing.Point(10, 19)
        Me.radiobutEstaFecha.Name = "radiobutEstaFecha"
        Me.radiobutEstaFecha.Size = New System.Drawing.Size(79, 17)
        Me.radiobutEstaFecha.TabIndex = 0
        Me.radiobutEstaFecha.TabStop = True
        Me.radiobutEstaFecha.Text = "Esta Fecha"
        Me.radiobutEstaFecha.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPartidaFinal)
        Me.GroupBox2.Controls.Add(Me.txtPartidaInicial)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(162, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(173, 116)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rango de Partida"
        '
        'txtPartidaFinal
        '
        Me.txtPartidaFinal.Location = New System.Drawing.Point(49, 45)
        Me.txtPartidaFinal.Name = "txtPartidaFinal"
        Me.txtPartidaFinal.Size = New System.Drawing.Size(113, 20)
        Me.txtPartidaFinal.TabIndex = 3
        '
        'txtPartidaInicial
        '
        Me.txtPartidaInicial.Location = New System.Drawing.Point(49, 18)
        Me.txtPartidaInicial.Name = "txtPartidaInicial"
        Me.txtPartidaInicial.Size = New System.Drawing.Size(113, 20)
        Me.txtPartidaInicial.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Final:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Inicial:"
        '
        'cmbTipoPartida
        '
        Me.cmbTipoPartida.FormattingEnabled = True
        Me.cmbTipoPartida.Location = New System.Drawing.Point(96, 240)
        Me.cmbTipoPartida.Name = "cmbTipoPartida"
        Me.cmbTipoPartida.Size = New System.Drawing.Size(101, 21)
        Me.cmbTipoPartida.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Tipo de Partida:"
        '
        'btnPartidaCierre
        '
        Me.btnPartidaCierre.Location = New System.Drawing.Point(211, 240)
        Me.btnPartidaCierre.Name = "btnPartidaCierre"
        Me.btnPartidaCierre.Size = New System.Drawing.Size(119, 21)
        Me.btnPartidaCierre.TabIndex = 41
        Me.btnPartidaCierre.Text = "Ver Partida de Cierre"
        Me.btnPartidaCierre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPartidaCierre.UseVisualStyleBackColor = True
        '
        'CTRepTransFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 322)
        Me.Controls.Add(Me.btnPartidaCierre)
        Me.Controls.Add(Me.cmbTipoPartida)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.c1dateFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblPeriodo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CTRepTransFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Transacciones"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.c1numAñoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbMeses As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents c1numAñoUsuario As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkboxUtilizarPeriodoUsuario As System.Windows.Forms.CheckBox
    Friend WithEvents c1dateFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radiobutTipoPartidas As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutRangoPartidas As System.Windows.Forms.RadioButton
    Friend WithEvents radiobutEstaFecha As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPartidaFinal As System.Windows.Forms.TextBox
    Friend WithEvents txtPartidaInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoPartida As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnPartidaCierre As System.Windows.Forms.Button
    Friend WithEvents radiobutTodasPartidas As System.Windows.Forms.RadioButton
End Class
