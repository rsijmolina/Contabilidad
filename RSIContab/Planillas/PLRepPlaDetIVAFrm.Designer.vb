﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLRepPlaDetIVAFrm
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
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.lblDescPlanilla = New System.Windows.Forms.Label
        Me.c1numNoPlanilla = New C1.Win.C1Input.C1NumericEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.c1dateFecha = New C1.Win.C1Input.C1DateEdit
        Me.chkboxImprimirResumen = New System.Windows.Forms.CheckBox
        CType(Me.c1numNoPlanilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(168, 140)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(101, 32)
        Me.btnCancelar.TabIndex = 26
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(12, 140)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(101, 32)
        Me.btnAceptar.TabIndex = 25
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblDescPlanilla
        '
        Me.lblDescPlanilla.AutoSize = True
        Me.lblDescPlanilla.Location = New System.Drawing.Point(9, 80)
        Me.lblDescPlanilla.Name = "lblDescPlanilla"
        Me.lblDescPlanilla.Size = New System.Drawing.Size(0, 13)
        Me.lblDescPlanilla.TabIndex = 24
        '
        'c1numNoPlanilla
        '
        Me.c1numNoPlanilla.AutoSize = False
        Me.c1numNoPlanilla.DataType = GetType(Short)
        Me.c1numNoPlanilla.Location = New System.Drawing.Point(92, 54)
        Me.c1numNoPlanilla.Name = "c1numNoPlanilla"
        Me.c1numNoPlanilla.Size = New System.Drawing.Size(26, 20)
        Me.c1numNoPlanilla.TabIndex = 23
        Me.c1numNoPlanilla.Tag = Nothing
        Me.c1numNoPlanilla.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "No. de Planilla:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Fecha del Reporte:"
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
        Me.c1dateFecha.Location = New System.Drawing.Point(140, 12)
        Me.c1dateFecha.Name = "c1dateFecha"
        Me.c1dateFecha.Size = New System.Drawing.Size(105, 20)
        Me.c1dateFecha.TabIndex = 20
        Me.c1dateFecha.Tag = "CM"
        Me.c1dateFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'chkboxImprimirResumen
        '
        Me.chkboxImprimirResumen.AutoSize = True
        Me.chkboxImprimirResumen.Location = New System.Drawing.Point(13, 107)
        Me.chkboxImprimirResumen.Name = "chkboxImprimirResumen"
        Me.chkboxImprimirResumen.Size = New System.Drawing.Size(109, 17)
        Me.chkboxImprimirResumen.TabIndex = 27
        Me.chkboxImprimirResumen.Text = "Imprimir Resumen"
        Me.chkboxImprimirResumen.UseVisualStyleBackColor = True
        '
        'PLRepPlaDetIVAFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 179)
        Me.Controls.Add(Me.chkboxImprimirResumen)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblDescPlanilla)
        Me.Controls.Add(Me.c1numNoPlanilla)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.c1dateFecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PLRepPlaDetIVAFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Planilla"
        CType(Me.c1numNoPlanilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1dateFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblDescPlanilla As System.Windows.Forms.Label
    Friend WithEvents c1numNoPlanilla As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents c1dateFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents chkboxImprimirResumen As System.Windows.Forms.CheckBox
End Class
