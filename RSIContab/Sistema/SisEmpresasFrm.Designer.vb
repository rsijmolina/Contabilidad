<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SisEmpresasFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SisEmpresasFrm))
        Me.ListaDataNavBarPrin = New RSIContab.ListaDataNavBar()
        Me.c1dbgrdBancos = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.PrincipalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SisEmpresasListaDataSet = New RSIContab.SisEmpresasListaDataSet()
        Me.DBTableAdapter = New RSIContab.SisEmpresasListaDataSetTableAdapters.DBTableAdapter()
        CType(Me.c1dbgrdBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SisEmpresasListaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaDataNavBarPrin
        '
        Me.ListaDataNavBarPrin.BindingSourcePrincipal = Nothing
        Me.ListaDataNavBarPrin.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListaDataNavBarPrin.Location = New System.Drawing.Point(0, 0)
        Me.ListaDataNavBarPrin.Name = "ListaDataNavBarPrin"
        Me.ListaDataNavBarPrin.Size = New System.Drawing.Size(658, 69)
        Me.ListaDataNavBarPrin.TabIndex = 0
        '
        'c1dbgrdBancos
        '
        Me.c1dbgrdBancos.AllowUpdate = False
        Me.c1dbgrdBancos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c1dbgrdBancos.DataSource = Me.PrincipalBindingSource
        Me.c1dbgrdBancos.FilterBar = True
        Me.c1dbgrdBancos.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbgrdBancos.Images.Add(CType(resources.GetObject("c1dbgrdBancos.Images"), System.Drawing.Image))
        Me.c1dbgrdBancos.Location = New System.Drawing.Point(12, 63)
        Me.c1dbgrdBancos.Name = "c1dbgrdBancos"
        Me.c1dbgrdBancos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbgrdBancos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbgrdBancos.PreviewInfo.ZoomFactor = 75.0R
        Me.c1dbgrdBancos.PrintInfo.PageSettings = CType(resources.GetObject("c1dbgrdBancos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1dbgrdBancos.RowHeight = 18
        Me.c1dbgrdBancos.Size = New System.Drawing.Size(634, 153)
        Me.c1dbgrdBancos.TabIndex = 40
        Me.c1dbgrdBancos.Text = "Grados"
        Me.c1dbgrdBancos.PropBag = resources.GetString("c1dbgrdBancos.PropBag")
        '
        'PrincipalBindingSource
        '
        Me.PrincipalBindingSource.DataMember = "DB"
        Me.PrincipalBindingSource.DataSource = Me.SisEmpresasListaDataSet
        '
        'SisEmpresasListaDataSet
        '
        Me.SisEmpresasListaDataSet.DataSetName = "SisEmpresasListaDataSet"
        Me.SisEmpresasListaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DBTableAdapter
        '
        Me.DBTableAdapter.ClearBeforeFill = True
        '
        'SisEmpresasFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 228)
        Me.Controls.Add(Me.c1dbgrdBancos)
        Me.Controls.Add(Me.ListaDataNavBarPrin)
        Me.Name = "SisEmpresasFrm"
        Me.Text = "Empresas"
        CType(Me.c1dbgrdBancos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrincipalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SisEmpresasListaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListaDataNavBarPrin As RSIContab.ListaDataNavBar
    Friend WithEvents c1dbgrdBancos As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents PrincipalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SisEmpresasListaDataSet As RSIContab.SisEmpresasListaDataSet
    Friend WithEvents DBTableAdapter As RSIContab.SisEmpresasListaDataSetTableAdapters.DBTableAdapter
End Class
