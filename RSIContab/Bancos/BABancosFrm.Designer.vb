<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BABancosFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BABancosFrm))
        Me.c1dbgrdNiveles = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.ListaDataNavBarPrin = New RSIContab.ListaDataNavBar()
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BABancosListaDataSet = New RSIContab.BABancosListaDataSet()
        Me.BABancosTableAdapter = New RSIContab.BABancosListaDataSetTableAdapters.BABancosTableAdapter()
        Me.BindingSourceConfiguracion = New System.Windows.Forms.BindingSource(Me.components)
        Me.BAConfTableAdapter = New RSIContab.BABancosListaDataSetTableAdapters.BAConfTableAdapter()
        CType(Me.c1dbgrdNiveles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BABancosListaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceConfiguracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.c1dbgrdNiveles.Location = New System.Drawing.Point(12, 75)
        Me.c1dbgrdNiveles.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.c1dbgrdNiveles.Name = "c1dbgrdNiveles"
        Me.c1dbgrdNiveles.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbgrdNiveles.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbgrdNiveles.PreviewInfo.ZoomFactor = 75.0R
        Me.c1dbgrdNiveles.PrintInfo.PageSettings = CType(resources.GetObject("c1dbgrdNiveles.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1dbgrdNiveles.RowHeight = 18
        Me.c1dbgrdNiveles.Size = New System.Drawing.Size(924, 320)
        Me.c1dbgrdNiveles.TabIndex = 4
        Me.c1dbgrdNiveles.Text = "C1TrueDBGrid1"
        Me.c1dbgrdNiveles.UseCompatibleTextRendering = False
        Me.c1dbgrdNiveles.PropBag = resources.GetString("c1dbgrdNiveles.PropBag")
        '
        'ListaDataNavBarPrin
        '
        Me.ListaDataNavBarPrin.BindingSourcePrincipal = Me.PrincipalBindingSource
        Me.ListaDataNavBarPrin.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListaDataNavBarPrin.Location = New System.Drawing.Point(0, 0)
        Me.ListaDataNavBarPrin.Name = "ListaDataNavBarPrin"
        Me.ListaDataNavBarPrin.Size = New System.Drawing.Size(948, 69)
        Me.ListaDataNavBarPrin.TabIndex = 5
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "BABancos"
        Me.PrincipalBindingSource.DataSource = Me.BABancosListaDataSet
        '
        'BABancosListaDataSet
        '
        Me.BABancosListaDataSet.DataSetName = "BABancosListaDataSet"
        Me.BABancosListaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BABancosTableAdapter
        '
        Me.BABancosTableAdapter.ClearBeforeFill = True
        '
        'BindingSourceConfiguracion
        '
        Me.BindingSourceConfiguracion.DataMember = "BAConf"
        Me.BindingSourceConfiguracion.DataSource = Me.BABancosListaDataSet
        '
        'BAConfTableAdapter
        '
        Me.BAConfTableAdapter.ClearBeforeFill = True
        '
        'BABancosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 407)
        Me.Controls.Add(Me.ListaDataNavBarPrin)
        Me.Controls.Add(Me.c1dbgrdNiveles)
        Me.Name = "BABancosFrm"
        Me.Text = "BABancosFrm"
        CType(Me.c1dbgrdNiveles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BABancosListaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceConfiguracion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrincipalBindingSource As BindingSource
    Friend WithEvents BABancosListaDataSet As BABancosListaDataSet
    Friend WithEvents c1dbgrdNiveles As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents BABancosTableAdapter As BABancosListaDataSetTableAdapters.BABancosTableAdapter
    Friend WithEvents ListaDataNavBarPrin As ListaDataNavBar
    Friend WithEvents BindingSourceConfiguracion As BindingSource
    Friend WithEvents BAConfTableAdapter As BABancosListaDataSetTableAdapters.BAConfTableAdapter
End Class
