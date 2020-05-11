Public Class EditDataNavBar
    Private _BindingSourcePrincipal As BindingSource
    Private _Modalidad As String
    Private _ResultadoValidacion As String
    Private _ValidacionCorrecta As Boolean
    Private _NuevoRegistro As Boolean
    Private _ModificarRegistro As Boolean
    Public Property ModificarRegistro() As Boolean
        Get
            Return _ModificarRegistro
        End Get
        Set(ByVal value As Boolean)
            _ModificarRegistro = value
        End Set
    End Property

    Public Property NuevoRegistro() As Boolean
        Get
            Return _NuevoRegistro
        End Get
        Set(ByVal value As Boolean)
            _NuevoRegistro = value
        End Set
    End Property

    Public Property ValidacionCorrecta() As Boolean
        Get
            Return _ValidacionCorrecta
        End Get
        Set(ByVal value As Boolean)
            _ValidacionCorrecta = value
        End Set
    End Property

    Public Property ResultadoValidacion() As String
        Get
            Return _ResultadoValidacion
        End Get
        Set(ByVal value As String)
            _ResultadoValidacion = value
        End Set
    End Property

    Public Property Modalidad() As String
        Get
            Return _Modalidad
        End Get
        Set(ByVal value As String)
            _Modalidad = value
        End Set
    End Property

    Property BindingSourcePrincipal() As BindingSource
        Get
            BindingSourcePrincipal = _BindingSourcePrincipal
        End Get
        Set(ByVal value As BindingSource)
            _BindingSourcePrincipal = value
        End Set
    End Property
    Public Event EliminarRegistroClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event GuardarClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event SalirClick(ByVal sender As Object, ByVal e As EventArgs)

    Private Sub EditDataNavBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub ToolStripButtonGuardar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonGuardar.Click
        RaiseEvent GuardarClick(Me, e)
    End Sub

    '  Private Sub ToolStripButtonEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonEliminar.Click
    'RaiseEvent EliminarRegistroClick(Me, e)
    'End Sub

    Private Sub ToolStripButtonSalir_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSalir.Click
        RaiseEvent SalirClick(Me, e)
    End Sub
    Public Sub ValidarInfo(ByVal mParent As Control)
        Dim mControl As Windows.Forms.Control
        Dim mTabPage As Windows.Forms.TabPage
        Dim mSplitCont As Windows.Forms.SplitContainer
        Dim mTab As Windows.Forms.TabControl
        Dim mTextBox As Windows.Forms.TextBox
        Dim mRichTextBox As Windows.Forms.RichTextBox
        Dim mComboBox As Windows.Forms.ComboBox
        Dim mC1TextBox As C1.Win.C1Input.C1TextBox
        Dim mC1NumericEdit As C1.Win.C1Input.C1NumericEdit
        Dim mC1DateEdit As C1.Win.C1Input.C1DateEdit
        Dim mC1Combo As C1.Win.C1List.C1Combo
        'Dim dsData As DataSet
        'Dim i As Int16

        '*** Verificar información introducida en controles***
        For Each mControl In mParent.Controls

            Select Case mControl.GetType.FullName
                Case "System.Windows.Forms.GroupBox"
                    ValidarInfo(mControl)   'Llamada recursiva si el control es un contenedor
                Case "System.Windows.Forms.Panel"
                    ValidarInfo(mControl)   'Llamada recursiva si el control es un contenedor
                Case "System.Windows.Forms.TabControl"
                    mTab = mControl
                    For Each mTabPage In mTab.TabPages
                        ValidarInfo(mTabPage)   'Llamada recursiva si el control es un contenedor
                    Next
                Case "System.Windows.Forms.SplitContainer"
                    mSplitCont = mControl
                    ValidarInfo(mSplitCont.Panel1)   'Llamada recursiva si el control es un contenedor
                    ValidarInfo(mSplitCont.Panel2)
            End Select

            If mControl.GetType.FullName = "System.Windows.Forms.ComboBox" Or mControl.GetType.FullName = "C1.Win.C1List.C1Combo" _
                Or mControl.GetType.FullName = "System.Windows.Forms.TextBox" Or mControl.GetType.FullName = "System.Windows.Forms.RichTextBox" _
                Or mControl.GetType.FullName = "C1.Win.C1Input.C1TextBox" Or mControl.GetType.FullName = "C1.Win.C1Input.C1NumericEdit" _
                Or mControl.GetType.FullName = "C1.Win.C1Input.C1DateEdit" Then
                Select Case mControl.GetType.FullName
                    Case "System.Windows.Forms.TextBox"
                        mTextBox = mControl
                        If InStr(mTextBox.Tag, "O") > 0 Then
                            If String.IsNullOrEmpty(mTextBox.Text) Then
                                ResultadoValidacion = ResultadoValidacion & "Debe ingresar el dato: " & mTextBox.DataBindings.ToString & vbCrLf
                                ValidacionCorrecta = False
                            End If
                        End If
                    Case "System.Windows.Forms.RichTextBox"
                        mRichTextBox = mControl
                        If InStr(mRichTextBox.Tag, "O") > 0 Then
                            If String.IsNullOrEmpty(mRichTextBox.Text) Then
                                ResultadoValidacion = ResultadoValidacion & "Debe ingresar el dato: " & mRichTextBox.DataBindings.ToString & vbCrLf
                                ValidacionCorrecta = False
                            End If
                        End If
                    Case "C1.Win.C1Input.C1TextBox"
                        mC1TextBox = mControl
                        If InStr(mC1TextBox.Tag, "O") > 0 Then
                            If String.IsNullOrEmpty(mC1TextBox.Text) Then
                                ResultadoValidacion = ResultadoValidacion & "Debe ingresar el dato: " & mC1TextBox.DataField & vbCrLf
                                'mC1TextBox.BackColor = Color.FromName("info")
                                ValidacionCorrecta = False
                            End If
                        End If
                    Case "C1.Win.C1Input.C1NumericEdit"
                        mC1NumericEdit = mControl
                        If String.IsNullOrEmpty(Str(mC1NumericEdit.Value)) Then
                            mC1NumericEdit.Value = 0
                        End If

                        If InStr(mC1NumericEdit.Tag, "O") > 0 Then
                            If InStr(mC1NumericEdit.Tag, ">") > 0 And Val(mC1NumericEdit.Text) = 0 Then
                                ResultadoValidacion = ResultadoValidacion & "Debe ingresar un valor distinto de cero en: " & mC1NumericEdit.DataField & vbCrLf
                                'mC1NumericEdit.BackColor = Color.FromName("info")
                                ValidacionCorrecta = False
                            End If
                        End If
                    Case "C1.Win.C1Input.C1DateEdit"
                        mC1DateEdit = mControl
                    Case "System.Windows.Forms.ComboBox"
                        mComboBox = mControl
                    Case "C1.Win.C1List.C1Combo"
                        mC1Combo = mControl
                        If InStr(mC1Combo.Tag, "O") > 0 Then
                            If String.IsNullOrEmpty(mC1Combo.Text) Then
                                ResultadoValidacion = ResultadoValidacion & "Debe ingresar el dato: " & mC1Combo.Columns(0).DataField & vbCrLf
                                ValidacionCorrecta = False
                            End If
                        End If
                End Select
            End If
        Next

        '*** Verificar nulos ***
        'dsData = BindingSourcePrincipal.DataSource
        'For i = 0 To dsData.Tables(BindingSourcePrincipal.DataMember).Columns.Count - 1
        ' dsData.Tables(BindingSourcePrincipal.DataMember).Columns(1).AllowDBNull
        'Next
    End Sub
    Public Sub HabilitarBotones(mForma As Windows.Forms.Form)
        ModificarRegistro = False
        NuevoRegistro = False
        If Modalidad = "CONSULTAR" Then
            ToolStripButtonGuardar.Visible = False
            'ToolStripButtonEliminar.Visible = False
            ControlesSoloLectura(mForma)
        ElseIf Modalidad = "EDITAR" Or Modalidad = "NUEVO" Then
            ToolStripButtonGuardar.Visible = True
            ' ToolStripButtonEliminar.Visible = False
            If Modalidad = "EDITAR" Then
                ModificarRegistro = True
            End If
            If Modalidad = "NUEVO" Then
                NuevoRegistro = True
            End If
            BloquearControles(mForma, False)
        ElseIf Modalidad = "ELIMINAR" Then
            ToolStripButtonGuardar.Visible = False
            '  ToolStripButtonEliminar.Visible = True
            ControlesSoloLectura(mForma)
        End If
    End Sub
    Private Sub BloquearControles(ByVal mParent As Control, ByVal Bloquear As Boolean)
        Dim mControl As Windows.Forms.Control
        Dim mTabPage As Windows.Forms.TabPage
        Dim mSplitCont As Windows.Forms.SplitContainer
        Dim mTab As Windows.Forms.TabControl
        Dim mTextBox As Windows.Forms.TextBox
        Dim mRichTextBox As Windows.Forms.RichTextBox
        Dim mButton As Windows.Forms.Button
        'Dim mColiseumBotonBuscar As RSIContab.BotonBuscar
        Dim mColiseumBotonBuscar As Windows.Forms.Button
        Dim mC1TextBox As C1.Win.C1Input.C1TextBox
        Dim mC1NumericEdit As C1.Win.C1Input.C1NumericEdit
        Dim mC1DateEdit As C1.Win.C1Input.C1DateEdit
        Dim mC1Combo As C1.Win.C1List.C1Combo
        Dim mc1dbgrd As C1.Win.C1TrueDBGrid.C1TrueDBGrid
        'Dim strA As String

        For Each mControl In mParent.Controls

            Select Case mControl.GetType.FullName
                Case "System.Windows.Forms.GroupBox"
                    'If mControl.Name = "groupboxComi" Then
                    'strA = "A"
                    'End If
                    BloquearControles(mControl, Bloquear)   'Llamada recursiva si el control es un contenedor
                Case "System.Windows.Forms.Panel"
                    BloquearControles(mControl, Bloquear)   'Llamada recursiva si el control es un contenedor
                Case "System.Windows.Forms.TabControl"
                    mTab = mControl
                    For Each mTabPage In mTab.TabPages
                        BloquearControles(mTabPage, Bloquear)   'Llamada recursiva si el control es un contenedor
                    Next
                Case "System.Windows.Forms.SplitContainer"
                    mSplitCont = mControl
                    BloquearControles(mSplitCont.Panel1, Bloquear)   'Llamada recursiva si el control es un contenedor
                    BloquearControles(mSplitCont.Panel2, Bloquear)
                Case "System.Windows.Forms.TextBox"
                    mTextBox = mControl
                    If mTextBox.Tag <> "" Then
                        If (InStr(mTextBox.Tag, "C") > 0 And _NuevoRegistro) Or (InStr(mTextBox.Tag, "M") > 0 And _ModificarRegistro) Then
                            mTextBox.ReadOnly = Bloquear
                        End If
                    End If
                    'mTextBox.ReadOnly = Bloquear
                Case "System.Windows.Forms.RichTextBox"
                    mRichTextBox = mControl
                    mRichTextBox.ReadOnly = Bloquear
                Case "C1.Win.C1Input.C1TextBox"
                    mC1TextBox = mControl
                    If mC1TextBox.Tag <> "" Then
                        If (InStr(mC1TextBox.Tag, "C") > 0 And _NuevoRegistro) Or (InStr(mC1TextBox.Tag, "M") > 0 And _ModificarRegistro) Then
                            mC1TextBox.ReadOnly = Bloquear
                        End If
                    End If
                Case "C1.Win.C1Input.C1NumericEdit"
                    mC1NumericEdit = mControl
                    If mC1NumericEdit.Tag <> "" Then
                        If (InStr(mC1NumericEdit.Tag, "C") > 0 And _NuevoRegistro) Or (InStr(mC1NumericEdit.Tag, "M") > 0 And _ModificarRegistro) Then
                            mC1NumericEdit.ReadOnly = Bloquear
                        End If
                    End If
                Case "C1.Win.C1Input.C1DateEdit"
                    mC1DateEdit = mControl
                    If mC1DateEdit.Tag <> "" Then
                        If (InStr(mC1DateEdit.Tag, "C") > 0 And _NuevoRegistro) Or (InStr(mC1DateEdit.Tag, "M") > 0 And _ModificarRegistro) Then
                            mC1DateEdit.ReadOnly = Bloquear
                        End If
                    End If
                Case "C1.Win.C1List.C1Combo"
                    mC1Combo = mControl
                    If mC1Combo.Tag <> "" Then
                        If (InStr(mC1Combo.Tag, "C") > 0 And _NuevoRegistro) Or (InStr(mC1Combo.Tag, "M") > 0 And _ModificarRegistro) Then
                            mC1Combo.ReadOnly = Bloquear
                        End If
                    End If
                Case "System.Windows.Forms.Button"
                    mButton = mControl
                    If mButton.Tag = "HABILITARNOEDIT" Then
                        mButton.Enabled = Bloquear
                    Else
                        mButton.Enabled = Not Bloquear
                    End If
                Case "Coliseum.BotonBuscar"
                    mColiseumBotonBuscar = mControl
                    If mColiseumBotonBuscar.Tag = "HABILITARNOEDIT" Then
                        mColiseumBotonBuscar.Enabled = Bloquear
                    Else
                        mColiseumBotonBuscar.Enabled = Not Bloquear
                    End If
                Case "RSIContab.BotonBuscar"
                    mColiseumBotonBuscar = mControl
                    If mColiseumBotonBuscar.Tag = "HABILITARNOEDIT" Then
                        mColiseumBotonBuscar.Enabled = Bloquear
                    Else
                        mColiseumBotonBuscar.Enabled = Not Bloquear
                    End If
            End Select
            If mControl.GetType.FullName = "System.Windows.Forms.ComboBox" Or mControl.GetType.FullName = "System.Windows.Forms.ListBox" _
                Or mControl.GetType.FullName = "System.Windows.Forms.CheckBox" Or mControl.GetType.FullName = "System.Windows.Forms.RadioButton" _
                Or mControl.GetType.FullName = "C1.Win.C1TrueDBGrid.C1TrueDBDropDown" Or mControl.GetType.FullName = "System.Windows.Forms.NumericUpDown" Then
                mControl.Enabled = IIf(Bloquear = False, True, False)
            End If
            If mControl.GetType.FullName = "C1.Win.C1TrueDBGrid.C1TrueDBGrid" Then
                mc1dbgrd = mControl
                mc1dbgrd.AllowUpdate = IIf(Bloquear = False, False, True)
            End If
        Next

    End Sub
    Private Sub ControlesSoloLectura(ByVal mParent As Control)
        Dim mControl As Windows.Forms.Control
        Dim mTabPage As Windows.Forms.TabPage
        Dim mSplitCont As Windows.Forms.SplitContainer
        Dim mTab As Windows.Forms.TabControl
        Dim mTextBox As Windows.Forms.TextBox
        Dim mRichTextBox As Windows.Forms.RichTextBox
        Dim mButton As Windows.Forms.Button
        Dim mC1TextBox As C1.Win.C1Input.C1TextBox
        Dim mC1NumericEdit As C1.Win.C1Input.C1NumericEdit
        Dim mC1DateEdit As C1.Win.C1Input.C1DateEdit
        Dim mC1Combo As C1.Win.C1List.C1Combo
        Dim mc1dbgrd As C1.Win.C1TrueDBGrid.C1TrueDBGrid

        For Each mControl In mParent.Controls

            Select Case mControl.GetType.FullName
                Case "System.Windows.Forms.GroupBox"
                    'If mControl.Name = "groupboxComi" Then
                    'strA = "A"
                    'End If
                    ControlesSoloLectura(mControl)   'Llamada recursiva si el control es un contenedor
                Case "System.Windows.Forms.Panel"
                    ControlesSoloLectura(mControl)   'Llamada recursiva si el control es un contenedor
                Case "System.Windows.Forms.TabControl"
                    mTab = mControl
                    For Each mTabPage In mTab.TabPages
                        ControlesSoloLectura(mTabPage)   'Llamada recursiva si el control es un contenedor
                    Next
                Case "System.Windows.Forms.SplitContainer"
                    mSplitCont = mControl
                    ControlesSoloLectura(mSplitCont.Panel1)   'Llamada recursiva si el control es un contenedor
                    ControlesSoloLectura(mSplitCont.Panel2)
                Case "System.Windows.Forms.TextBox"
                    mTextBox = mControl
                    mTextBox.ReadOnly = True
                Case "System.Windows.Forms.RichTextBox"
                    mRichTextBox = mControl
                    mRichTextBox.ReadOnly = True
                Case "C1.Win.C1Input.C1TextBox"
                    mC1TextBox = mControl
                    mC1TextBox.ReadOnly = True
                Case "C1.Win.C1Input.C1NumericEdit"
                    mC1NumericEdit = mControl
                    mC1NumericEdit.ReadOnly = True
                Case "C1.Win.C1Input.C1DateEdit"
                    mC1DateEdit = mControl
                    mC1DateEdit.ReadOnly = True
                Case "C1.Win.C1List.C1Combo"
                    mC1Combo = mControl
                    mC1Combo.ReadOnly = True
                Case "System.Windows.Forms.Button"
                    mButton = mControl
                    mButton.Enabled = False
            End Select
            If mControl.GetType.FullName = "System.Windows.Forms.ComboBox" Or mControl.GetType.FullName = "System.Windows.Forms.ListBox" _
                Or mControl.GetType.FullName = "System.Windows.Forms.CheckBox" Or mControl.GetType.FullName = "System.Windows.Forms.RadioButton" _
                Or mControl.GetType.FullName = "C1.Win.C1TrueDBGrid.C1TrueDBDropDown" Or mControl.GetType.FullName = "System.Windows.Forms.NumericUpDown" Then
                mControl.Enabled = False
            End If
            If mControl.GetType.FullName = "C1.Win.C1TrueDBGrid.C1TrueDBGrid" Then
                mc1dbgrd = mControl
                mc1dbgrd.AllowUpdate = False
            End If
        Next

    End Sub

End Class
