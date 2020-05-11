Imports System.ComponentModel
Imports System.Drawing.Printing

Public Class BABancosEdicionFrm
    Private _FormularioPrincipal As BABancosFrm
    Private _CodigoCentro As Int32
    Private _Modalidad As String
    Private _intBanco As Int16

    Private _Año As String
    Public Property año() As Int16
        Get
            Return _Año
        End Get
        Set(ByVal value As Int16)
            _Año = value
        End Set
    End Property

    Private _Mes As Int16
    Public Property mes() As Int16
        Get
            Return _Mes
        End Get
        Set(ByVal value As Int16)
            _Mes = value
        End Set
    End Property


    Public Property intBanco() As Int16
        Get
            Return _intBanco
        End Get
        Set(ByVal value As Int16)
            _intBanco = value
        End Set
    End Property

    Public Property FormularioPrincipal() As BABancosFrm
        Get
            Return _FormularioPrincipal
        End Get
        Set(ByVal value As BABancosFrm)
            _FormularioPrincipal = value
        End Set
    End Property
    Public Property CodigoCentro() As Int32
        Get
            Return _CodigoCentro
        End Get
        Set(ByVal value As Int32)
            _CodigoCentro = value
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
    Dim strIdentidadActual As Int16
    Dim dbCls As New CTClassLib.CTClass
    Dim drConf As SqlClient.SqlDataReader
    Dim CadCls As New Rsierpgencl.Rsierpcl.Cadenas
    Dim drCentros As SqlClient.SqlDataReader
    Dim mCentroSeleccionado As Boolean
    Dim ListaCatalogoFrm As New CtListaCatGenFrm
    Dim boCuentaContSel As Boolean
    Dim boCuentaAjusteSel As Boolean

    Private Sub BABancosEdicionFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Modalidad <> "NUEVO" Then
            FormularioPrincipal.EliminarRegistroAbierto(intBanco)
        End If
    End Sub

    Private Sub EditDataNavBarPrin_GuardarClick(sender As Object, e As EventArgs) Handles EditDataNavBarPrin.GuardarClick
        Try
            Me.Validate()
            PrincipalBindingSource.EndEdit()
            Me.BABancosTableAdapter.Update(Me.BABancosEdicionDataSet.BABancos)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub BABancosEdicionFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BABancosEdicionDataSet.CTCatalogoCuentas' Puede moverla o quitarla según sea necesario.
        Me.CTCatalogoCuentasTableAdapter.Connection.ConnectionString = strcnCAD
        Me.BABancosTableAdapter.Connection.ConnectionString = strcnCAD
        Me.BATransaccionesDetalleTableAdapter.Connection.ConnectionString = strcnCAD
        Me.BATransaccionesEncabezadoTableAdapter.Connection.ConnectionString = strcnCAD
        Me.BASaldosMensualesTableAdapter.Connection.ConnectionString = strcnCAD
        Me.CTCatalogoCuentasTableAdapter.Fill(Me.BABancosEdicionDataSet.CTCatalogoCuentas)
        dbCls.DBconStr = strcnCAD
        drConf = dbCls.drConf
        If Modalidad = "NUEVO" Then
            PrincipalBindingSource.AddNew()
        End If
        If Modalidad <> "NUEVO" Then
            CargarDatos()
            'Me.BATransaccionesEncabezadoTableAdapter.Fill(Me.BABancosEdicionDataSet.BATransaccionesEncabezado, _intBanco, _Año, _Mes)
        End If
        Me.EditDataNavBarPrin.HabilitarBotones(Me)
        Dim strImpInstaladas As String
        For i As Int16 = 0 To PrinterSettings.InstalledPrinters.Count - 1
            strImpInstaladas = PrinterSettings.InstalledPrinters.Item(i)
            C1ComboBoxImpresora.Items.Add(strImpInstaladas)
        Next
        Dim DefPrn As New PrinterSettings
        C1ComboBoxImpresora.Text = DefPrn.PrinterName
        boCuentaContSel = False
        boCuentaAjusteSel = False
    End Sub

    Public Sub CargarDatos()
        Try
            Me.BABancosTableAdapter.Fill(Me.BABancosEdicionDataSet.BABancos, intBanco)
            Me.BATransaccionesEncabezadoTableAdapter.Fill(Me.BABancosEdicionDataSet.BATransaccionesEncabezado, intBanco, drConf("AñoEnProceso"), drConf("MesEnProceso"))
            Me.BASaldosMensualesTableAdapter.Fill(Me.BABancosEdicionDataSet.BASaldosMensuales, intBanco, drConf("AñoEnProceso"), drConf("MesEnProceso"))
            Dim drvBancos As DataRowView = Me.PrincipalBindingSource.Current
            If Not IsDBNull(drvBancos("CuentaContable")) Then
                Dim drCa2t As DataRow = Me.BABancosEdicionDataSet.CTCatalogoCuentas.FindByCuenta(C1TextBoxCuentaContable.Text)
                LabelCuentaContable.Text = drCa2t("Descripcion")
            End If
            If Not IsDBNull(drvBancos("CuentaAjuste")) Then
                Dim drCat As DataRow = Me.BABancosEdicionDataSet.CTCatalogoCuentas.FindByCuenta(C1TextBoxCuentaAjuste.Text)
                LabelCuentaAjuste.Text = drCat("Descripcion")
            End If
            Dim drvSaldos As DataRowView = BindingSourceSaldos.Current
            If Not drvSaldos Is Nothing Then
                C1NumericEditSaldoActual.Value = drvSaldos("Depositos") + drvSaldos("NotasCredito") - drvSaldos("NotasDebito") - drvSaldos("Cheques")
                C1NumericEditSaldoActualEquiv.Value = drvSaldos("DepositosEquivalente") + drvSaldos("NotasCreditoEquivalente") - drvSaldos("NotasDebitoEquivalente") - drvSaldos("ChequesEquivalente")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub


    Private Sub C1ButtonCuentaContable_Click(sender As Object, e As EventArgs) Handles C1ButtonCuentaContable.Click
        boCuentaContSel = False
        ListaCatalogoFrm.ShowDialog()
        If ListaCatalogoFrm.DialogResult = DialogResult.OK Then
            boCuentaContSel = True
            Dim drvCat As DataRowView = ListaCatalogoFrm.ListaCatBindingSource.Current
            C1TextBoxCuentaContable.Text = drvCat("Cuenta")
            LabelCuentaContable.Text = drvCat("Descripcion")
            boCuentaContSel = False
        End If
    End Sub

    Private Sub EditDataNavBarPrin_SalirClick(sender As Object, e As EventArgs) Handles EditDataNavBarPrin.SalirClick
        Me.Close()
    End Sub

    Private Sub C1ButtonCuentaAjuste_Click(sender As Object, e As EventArgs) Handles C1ButtonCuentaAjuste.Click
        boCuentaAjusteSel = False
        ListaCatalogoFrm.ShowDialog()
        If ListaCatalogoFrm.DialogResult = DialogResult.OK Then
            boCuentaAjusteSel = True
            Dim drvCat As DataRowView = ListaCatalogoFrm.ListaCatBindingSource.Current
            C1TextBoxCuentaAjuste.Text = drvCat("Cuenta")
            LabelCuentaAjuste.Text = drvCat("Descripcion")
            boCuentaAjusteSel = False
        End If
    End Sub

    Private Sub C1TextBoxCuentaContable_Validating(sender As Object, e As CancelEventArgs) Handles C1TextBoxCuentaContable.Validating

        If C1TextBoxCuentaContable.Text.ToString.Length > 0 Then
            If boCuentaContSel = False Then
                Dim drCat As DataRow = Me.BABancosEdicionDataSet.CTCatalogoCuentas.FindByCuenta(C1TextBoxCuentaContable.Text)
                If drCat Is Nothing Then
                    MsgBox("Cuenta no existe!")
                    C1TextBoxCuentaContable.Text = ""
                    LabelCuentaContable.Text = ""
                    e.Cancel = True
                Else
                    If Not drCat("Posteable") Then
                        C1TextBoxCuentaContable.Text = ""
                        LabelCuentaContable.Text = ""
                        MsgBox("Cuenta no es posteable!")
                        e.Cancel = True
                    Else
                        boCuentaContSel = True
                        C1TextBoxCuentaContable.Text = drCat("Cuenta")
                        LabelCuentaContable.Text = drCat("Descripcion")

                    End If
                End If
            End If
        End If
    End Sub

    Private Sub C1ButtonCuentaAjuste_Validating(sender As Object, e As CancelEventArgs) Handles C1ButtonCuentaAjuste.Validating
        If C1TextBoxCuentaAjuste.Text.ToString.Length > 0 Then
            If boCuentaAjusteSel = False Then
                Dim drCat As DataRow = Me.BABancosEdicionDataSet.CTCatalogoCuentas.FindByCuenta(C1TextBoxCuentaAjuste.Text)
                If drCat Is Nothing Then
                    MsgBox("Cuenta no existe!")
                    C1TextBoxCuentaAjuste.Text = ""
                    LabelCuentaAjuste.Text = ""
                    e.Cancel = True
                Else
                    If Not drCat("Posteable") Then
                        C1TextBoxCuentaAjuste.Text = ""
                        LabelCuentaAjuste.Text = ""
                        MsgBox("Cuenta no es posteable!")
                        e.Cancel = True
                    Else
                        boCuentaAjusteSel = True
                        C1TextBoxCuentaAjuste.Text = drCat("Cuenta")
                        LabelCuentaAjuste.Text = drCat("Descripcion")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub C1ButtonRecalcularSaldos_Click(sender As Object, e As EventArgs) Handles C1ButtonRecalcularSaldos.Click
        Dim decTotCheques As Decimal
        Dim decTotDepositos As Decimal
        Dim decTotDebitos As Decimal
        Dim decTotCreditos As Decimal
        Dim decTotChequesEq As Decimal
        Dim decTotDepositosEq As Decimal
        Dim decTotDebitosEq As Decimal
        Dim decTotCreditosEq As Decimal
        Me.BATransaccionesEncabezadoTableAdapter.Fill(Me.BABancosEdicionDataSet.BATransaccionesEncabezado, intBanco, drConf("AñoEnPronceso"), drConf("MesEnPronceso"))
        For Each drvEnc In BATransaccionesDetBindingSource
            If Not drvEnc("Anulado") Then
                If drvEnc("DescripcionTipo") = "DP" Then
                    decTotDepositos = decTotDepositos + drvEnc("Monto")
                    decTotDepositosEq = decTotDepositosEq + (drvEnc("Monto") * drvEnc("FactorCambio"))
                End If
                If drvEnc("DescripcionTipo") = "CH" Then
                    decTotCheques = decTotCheques + drvEnc("Monto")
                    decTotChequesEq = decTotChequesEq + (drvEnc("Monto") * drvEnc("FactorCambio"))
                End If
                If drvEnc("DescripcionTipo") = "ND" Then
                    decTotDebitos = decTotDebitos + drvEnc("Monto")
                    decTotDebitosEq = decTotDebitosEq + (drvEnc("Monto") * drvEnc("FactorCambio"))
                End If
                If drvEnc("DescripcionTipo") = "NC" Then
                    decTotCreditos = decTotCreditos + drvEnc("Monto")
                    decTotCreditosEq = decTotCreditosEq + (drvEnc("Monto") * drvEnc("FactorCambio"))
                End If
                If drvEnc("DescripcionTipo") = "TR" Then
                    decTotDebitos = decTotDebitos + drvEnc("Monto")
                    decTotDebitosEq = decTotDebitosEq + (drvEnc("Monto") * drvEnc("FactorCambio"))
                End If
            End If
        Next
        Dim drvSaldos As DataRowView = BindingSourceSaldos.Current
        drvSaldos("Cheques") = decTotCheques
        drvSaldos("ChequesEquivalente") = decTotChequesEq
        drvSaldos("NotasCredito") = decTotCreditos
        drvSaldos("NotasCreditoEquivalente") = decTotCreditosEq
        drvSaldos("NotasDebito") = decTotDebitos
        drvSaldos("NotasDebitoEquivalente") = decTotDebitosEq
        BindingSourceSaldos.EndEdit()
        BASaldosMensualesTableAdapter.Update(BABancosEdicionDataSet.BASaldosMensuales)
        Me.C1NumericEditSaldoActual.Value = decTotDepositos + decTotCreditos - decTotCheques - decTotDebitos
        Me.C1NumericEditSaldoActual.Value = decTotDepositosEq + decTotCreditosEq - decTotChequesEq - decTotDebitosEq
    End Sub
End Class