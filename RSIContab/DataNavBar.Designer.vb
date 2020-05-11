<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataNavBar
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.toolstripNavBar = New System.Windows.Forms.ToolStrip()
        Me.toolstripbutPrimerRegistro = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbutRegistroAnterior = New System.Windows.Forms.ToolStripButton()
        Me.toolstriptextPosicionReg = New System.Windows.Forms.ToolStripTextBox()
        Me.toolstripbutSiguienteRegistro = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbutUltimoRegistro = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstripbutNuevoRegistro = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbutGuardarRegistro = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbutCancelarGuardar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbutModificarRegistro = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbutEliminarRegistro = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbutAnularDocumento = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbutCerrarDocumento = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbutImprimir = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbutContabilizar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbutComentarios = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbutDocumentacion = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbutMasOpciones = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstripllabelBuscar = New System.Windows.Forms.ToolStripLabel()
        Me.toolstriptextBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.toolstripbutBuscar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbutReiniciarDatos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstripbutSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstripMensaje = New System.Windows.Forms.ToolStripLabel()
        Me.toolstripNavBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolstripNavBar
        '
        Me.toolstripNavBar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.toolstripNavBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripbutPrimerRegistro, Me.toolstripbutRegistroAnterior, Me.toolstriptextPosicionReg, Me.toolstripbutSiguienteRegistro, Me.toolstripbutUltimoRegistro, Me.ToolStripSeparator1, Me.toolstripbutNuevoRegistro, Me.toolstripbutGuardarRegistro, Me.toolstripbutCancelarGuardar, Me.toolstripbutModificarRegistro, Me.toolstripbutEliminarRegistro, Me.toolstripbutAnularDocumento, Me.toolstripbutCerrarDocumento, Me.toolstripbutImprimir, Me.toolstripbutContabilizar, Me.toolstripbutComentarios, Me.toolstripbutDocumentacion, Me.toolstripbutMasOpciones, Me.ToolStripSeparator2, Me.toolstripllabelBuscar, Me.toolstriptextBuscar, Me.toolstripbutBuscar, Me.toolstripbutReiniciarDatos, Me.ToolStripSeparator3, Me.toolstripbutSalir, Me.ToolStripSeparator4, Me.toolstripMensaje})
        Me.toolstripNavBar.Location = New System.Drawing.Point(0, 0)
        Me.toolstripNavBar.Name = "toolstripNavBar"
        Me.toolstripNavBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.toolstripNavBar.Size = New System.Drawing.Size(680, 25)
        Me.toolstripNavBar.TabIndex = 0
        Me.toolstripNavBar.Text = "ToolStrip1"
        '
        'toolstripbutPrimerRegistro
        '
        Me.toolstripbutPrimerRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutPrimerRegistro.Image = Global.RSIContab.My.Resources.Resources.DataContainer_MoveFirstHS
        Me.toolstripbutPrimerRegistro.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutPrimerRegistro.Name = "toolstripbutPrimerRegistro"
        Me.toolstripbutPrimerRegistro.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutPrimerRegistro.Text = "Primer Registro"
        Me.toolstripbutPrimerRegistro.ToolTipText = "Primer Registro Inicio"
        '
        'toolstripbutRegistroAnterior
        '
        Me.toolstripbutRegistroAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutRegistroAnterior.Image = Global.RSIContab.My.Resources.Resources.DataContainer_MovePreviousHS
        Me.toolstripbutRegistroAnterior.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutRegistroAnterior.Name = "toolstripbutRegistroAnterior"
        Me.toolstripbutRegistroAnterior.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutRegistroAnterior.Text = "Registro Anterior"
        Me.toolstripbutRegistroAnterior.ToolTipText = "Registro Anterior RePág"
        '
        'toolstriptextPosicionReg
        '
        Me.toolstriptextPosicionReg.BackColor = System.Drawing.SystemColors.Window
        Me.toolstriptextPosicionReg.Name = "toolstriptextPosicionReg"
        Me.toolstriptextPosicionReg.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.toolstriptextPosicionReg.ReadOnly = True
        Me.toolstriptextPosicionReg.Size = New System.Drawing.Size(50, 25)
        '
        'toolstripbutSiguienteRegistro
        '
        Me.toolstripbutSiguienteRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutSiguienteRegistro.Image = Global.RSIContab.My.Resources.Resources.DataContainer_MoveNextHS
        Me.toolstripbutSiguienteRegistro.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutSiguienteRegistro.Name = "toolstripbutSiguienteRegistro"
        Me.toolstripbutSiguienteRegistro.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutSiguienteRegistro.Text = "Siguiente Registro"
        Me.toolstripbutSiguienteRegistro.ToolTipText = "Siguiente Registro AvPág"
        '
        'toolstripbutUltimoRegistro
        '
        Me.toolstripbutUltimoRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutUltimoRegistro.Image = Global.RSIContab.My.Resources.Resources.DataContainer_MoveLastHS
        Me.toolstripbutUltimoRegistro.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutUltimoRegistro.Name = "toolstripbutUltimoRegistro"
        Me.toolstripbutUltimoRegistro.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutUltimoRegistro.Text = "Ultimo Registro"
        Me.toolstripbutUltimoRegistro.ToolTipText = "Ultimo Registro Fin"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'toolstripbutNuevoRegistro
        '
        Me.toolstripbutNuevoRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutNuevoRegistro.Image = Global.RSIContab.My.Resources.Resources.DataContainer_NewRecordHS
        Me.toolstripbutNuevoRegistro.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutNuevoRegistro.Name = "toolstripbutNuevoRegistro"
        Me.toolstripbutNuevoRegistro.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutNuevoRegistro.Text = "Nuevo Registro"
        Me.toolstripbutNuevoRegistro.ToolTipText = "Nuevo Registro Ctrl + N"
        '
        'toolstripbutGuardarRegistro
        '
        Me.toolstripbutGuardarRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutGuardarRegistro.Image = Global.RSIContab.My.Resources.Resources.saveHS
        Me.toolstripbutGuardarRegistro.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutGuardarRegistro.Name = "toolstripbutGuardarRegistro"
        Me.toolstripbutGuardarRegistro.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutGuardarRegistro.Text = "Guardar Registro"
        Me.toolstripbutGuardarRegistro.ToolTipText = "Guardar Registro Ctrl + G"
        '
        'toolstripbutCancelarGuardar
        '
        Me.toolstripbutCancelarGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutCancelarGuardar.Image = Global.RSIContab.My.Resources.Resources.Edit_UndoHS
        Me.toolstripbutCancelarGuardar.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutCancelarGuardar.Name = "toolstripbutCancelarGuardar"
        Me.toolstripbutCancelarGuardar.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutCancelarGuardar.Text = "Cancelar"
        Me.toolstripbutCancelarGuardar.ToolTipText = "Cancelar Ctrl + Z"
        '
        'toolstripbutModificarRegistro
        '
        Me.toolstripbutModificarRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutModificarRegistro.Image = Global.RSIContab.My.Resources.Resources.EditInformationHS
        Me.toolstripbutModificarRegistro.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutModificarRegistro.Name = "toolstripbutModificarRegistro"
        Me.toolstripbutModificarRegistro.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutModificarRegistro.Text = "Modificar Registro"
        Me.toolstripbutModificarRegistro.ToolTipText = "Modificar Registro Ctrl + M"
        '
        'toolstripbutEliminarRegistro
        '
        Me.toolstripbutEliminarRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutEliminarRegistro.Image = Global.RSIContab.My.Resources.Resources.DeleteHS
        Me.toolstripbutEliminarRegistro.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutEliminarRegistro.Name = "toolstripbutEliminarRegistro"
        Me.toolstripbutEliminarRegistro.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutEliminarRegistro.Text = "Eliminar Registro"
        Me.toolstripbutEliminarRegistro.ToolTipText = "Eliminar Registro Ctrl + E"
        '
        'toolstripbutAnularDocumento
        '
        Me.toolstripbutAnularDocumento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutAnularDocumento.Image = Global.RSIContab.My.Resources.Resources.RightsRestrictedHS
        Me.toolstripbutAnularDocumento.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutAnularDocumento.Name = "toolstripbutAnularDocumento"
        Me.toolstripbutAnularDocumento.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutAnularDocumento.Text = "Anular Documento"
        Me.toolstripbutAnularDocumento.ToolTipText = "Anular Documento Ctrl + A"
        '
        'toolstripbutCerrarDocumento
        '
        Me.toolstripbutCerrarDocumento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutCerrarDocumento.Image = Global.RSIContab.My.Resources.Resources.TaskHS
        Me.toolstripbutCerrarDocumento.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutCerrarDocumento.Name = "toolstripbutCerrarDocumento"
        Me.toolstripbutCerrarDocumento.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutCerrarDocumento.Text = "Cerrar Documento"
        Me.toolstripbutCerrarDocumento.ToolTipText = "Cerrar Documento Ctrl + F"
        '
        'toolstripbutImprimir
        '
        Me.toolstripbutImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutImprimir.Image = Global.RSIContab.My.Resources.Resources.PrintHS
        Me.toolstripbutImprimir.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutImprimir.Name = "toolstripbutImprimir"
        Me.toolstripbutImprimir.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutImprimir.Text = "Imprimir"
        Me.toolstripbutImprimir.ToolTipText = "Imprimir Ctrl + I"
        '
        'toolstripbutContabilizar
        '
        Me.toolstripbutContabilizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutContabilizar.Image = Global.RSIContab.My.Resources.Resources.book_reportHS
        Me.toolstripbutContabilizar.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutContabilizar.Name = "toolstripbutContabilizar"
        Me.toolstripbutContabilizar.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutContabilizar.Text = "Contabilizar"
        Me.toolstripbutContabilizar.ToolTipText = "Contabilizar Ctrl + T"
        '
        'toolstripbutComentarios
        '
        Me.toolstripbutComentarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutComentarios.Image = Global.RSIContab.My.Resources.Resources.TextboxHS
        Me.toolstripbutComentarios.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutComentarios.Name = "toolstripbutComentarios"
        Me.toolstripbutComentarios.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutComentarios.Text = "ToolStripButton1"
        Me.toolstripbutComentarios.ToolTipText = "Comentarios"
        '
        'toolstripbutDocumentacion
        '
        Me.toolstripbutDocumentacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutDocumentacion.Image = Global.RSIContab.My.Resources.Resources.ShowAllCommentsHS
        Me.toolstripbutDocumentacion.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutDocumentacion.Name = "toolstripbutDocumentacion"
        Me.toolstripbutDocumentacion.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutDocumentacion.Text = "toolstripbutDocumentacion"
        Me.toolstripbutDocumentacion.ToolTipText = "Documentación"
        '
        'toolstripbutMasOpciones
        '
        Me.toolstripbutMasOpciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutMasOpciones.Image = Global.RSIContab.My.Resources.Resources.Control_MenuStrip
        Me.toolstripbutMasOpciones.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripbutMasOpciones.Name = "toolstripbutMasOpciones"
        Me.toolstripbutMasOpciones.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutMasOpciones.Text = "ToolStripButton1"
        Me.toolstripbutMasOpciones.ToolTipText = "Más Opciones"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'toolstripllabelBuscar
        '
        Me.toolstripllabelBuscar.Name = "toolstripllabelBuscar"
        Me.toolstripllabelBuscar.Size = New System.Drawing.Size(45, 22)
        Me.toolstripllabelBuscar.Text = "Buscar:"
        '
        'toolstriptextBuscar
        '
        Me.toolstriptextBuscar.Name = "toolstriptextBuscar"
        Me.toolstriptextBuscar.Size = New System.Drawing.Size(100, 25)
        '
        'toolstripbutBuscar
        '
        Me.toolstripbutBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutBuscar.Image = Global.RSIContab.My.Resources.Resources.GoLtrHS
        Me.toolstripbutBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripbutBuscar.Name = "toolstripbutBuscar"
        Me.toolstripbutBuscar.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutBuscar.Text = "ToolStripButton1"
        Me.toolstripbutBuscar.ToolTipText = "Buscar Registro Ctrl + B"
        '
        'toolstripbutReiniciarDatos
        '
        Me.toolstripbutReiniciarDatos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutReiniciarDatos.Image = Global.RSIContab.My.Resources.Resources.RestartHS
        Me.toolstripbutReiniciarDatos.ImageTransparentColor = System.Drawing.Color.Black
        Me.toolstripbutReiniciarDatos.Name = "toolstripbutReiniciarDatos"
        Me.toolstripbutReiniciarDatos.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutReiniciarDatos.Text = "ToolStripButton2"
        Me.toolstripbutReiniciarDatos.ToolTipText = "Reiniciar Datos Ctrl + R"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'toolstripbutSalir
        '
        Me.toolstripbutSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolstripbutSalir.Image = Global.RSIContab.My.Resources.Resources.CriticalError
        Me.toolstripbutSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripbutSalir.Name = "toolstripbutSalir"
        Me.toolstripbutSalir.Size = New System.Drawing.Size(23, 22)
        Me.toolstripbutSalir.Text = "Salir"
        Me.toolstripbutSalir.ToolTipText = "Salir Ctrl + S"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'toolstripMensaje
        '
        Me.toolstripMensaje.Name = "toolstripMensaje"
        Me.toolstripMensaje.Size = New System.Drawing.Size(0, 22)
        '
        'DataNavBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.toolstripNavBar)
        Me.Name = "DataNavBar"
        Me.Size = New System.Drawing.Size(680, 31)
        Me.toolstripNavBar.ResumeLayout(False)
        Me.toolstripNavBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolstripNavBar As System.Windows.Forms.ToolStrip
    Friend WithEvents toolstripbutPrimerRegistro As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbutRegistroAnterior As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstriptextPosicionReg As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents toolstripbutSiguienteRegistro As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbutUltimoRegistro As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolstripbutNuevoRegistro As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbutGuardarRegistro As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbutCancelarGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbutModificarRegistro As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbutEliminarRegistro As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbutAnularDocumento As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbutCerrarDocumento As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbutImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbutSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbutContabilizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolstripllabelBuscar As System.Windows.Forms.ToolStripLabel
    Friend WithEvents toolstriptextBuscar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolstripbutBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbutReiniciarDatos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolstripMensaje As System.Windows.Forms.ToolStripLabel
    Friend WithEvents toolstripbutMasOpciones As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbutComentarios As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripbutDocumentacion As System.Windows.Forms.ToolStripButton

End Class
