<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTTipoPartidasFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CTTipoPartidasFrm))
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CTTipoPartidasDataSet = New RSIContab.CTTipoPartidasDataSet()
        Me.CTTiposPartidasTableAdapter = New RSIContab.CTTipoPartidasDataSetTableAdapters.CTTiposPartidasTableAdapter()
        Me.c1dbgrdTipos = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTTipoPartidasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1dbgrdTipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "CTTiposPartidas"
        Me.PrincipalBindingSource.DataSource = Me.CTTipoPartidasDataSet
        '
        'CTTipoPartidasDataSet
        '
        Me.CTTipoPartidasDataSet.DataSetName = "CTTipoPartidasDataSet"
        Me.CTTipoPartidasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CTTiposPartidasTableAdapter
        '
        Me.CTTiposPartidasTableAdapter.ClearBeforeFill = True
        '
        'c1dbgrdTipos
        '
        Me.c1dbgrdTipos.AllowAddNew = True
        Me.c1dbgrdTipos.AllowDelete = True
        Me.c1dbgrdTipos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c1dbgrdTipos.DataSource = Me.PrincipalBindingSource
        Me.c1dbgrdTipos.FilterBar = True
        Me.c1dbgrdTipos.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbgrdTipos.Images.Add(CType(resources.GetObject("c1dbgrdTipos.Images"), System.Drawing.Image))
        Me.c1dbgrdTipos.Location = New System.Drawing.Point(12, 12)
        Me.c1dbgrdTipos.Name = "c1dbgrdTipos"
        Me.c1dbgrdTipos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbgrdTipos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbgrdTipos.PreviewInfo.ZoomFactor = 75.0R
        Me.c1dbgrdTipos.PrintInfo.PageSettings = CType(resources.GetObject("c1dbgrdTipos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1dbgrdTipos.RowHeight = 18
        Me.c1dbgrdTipos.Size = New System.Drawing.Size(194, 191)
        Me.c1dbgrdTipos.TabIndex = 40
        Me.c1dbgrdTipos.PropBag = resources.GetString("c1dbgrdTipos.PropBag")
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.RSIContab.My.Resources.Resources._1393551019_Log_Out
        Me.btnSalir.Location = New System.Drawing.Point(64, 210)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(88, 37)
        Me.btnSalir.TabIndex = 41
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'CTTipoPartidasFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(218, 251)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.c1dbgrdTipos)
        Me.Name = "CTTipoPartidasFrm"
        Me.Text = "Tipos de Partidas"
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTTipoPartidasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1dbgrdTipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CTTipoPartidasDataSet As RSIContab.CTTipoPartidasDataSet
    Friend WithEvents CTTiposPartidasTableAdapter As RSIContab.CTTipoPartidasDataSetTableAdapters.CTTiposPartidasTableAdapter
    Friend WithEvents c1dbgrdTipos As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
