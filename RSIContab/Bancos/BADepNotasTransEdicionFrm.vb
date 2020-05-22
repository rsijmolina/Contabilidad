Imports System.ComponentModel
Imports C1.Win.C1TrueDBGrid
Imports System.Drawing
Imports System.IO

Public Class BADepNotasTransEdicionFrm
    Private _FormularioPrincipal As BADepNotasTransfFrm
    Dim BaCls As New BAClassLib.BAClass
    Dim drConf As SqlClient.SqlDataReader
    Dim dbCat As New CtListaCatGenFrm
    Dim BADocFrm As New CTDocumentosFrm
    Dim drvBanco As DataRowView
    Dim drvTransEnc As DataRowView
    Dim drvBASaldosMen As DataRowView
    Dim boCuentaListaSel As Boolean
    Dim decSaldo As Decimal = 0
    Dim intId As Long
    Dim strDescripTipo As String
    Dim decTotalDebe As Decimal, decTotalHaber As Decimal

    Private _Año As Int16
    Public Property Año() As Int16
        Get
            Return _Año
        End Get
        Set(ByVal value As Int16)
            _Año = value
        End Set
    End Property

    Private _TipoDocumento As Int16
    Public Property TipoDocumento() As Int16
        Get
            Return _TipoDocumento
        End Get
        Set(ByVal value As Int16)
            _TipoDocumento = value
        End Set
    End Property

    Private _Mes As Int16
    Public Property Mes() As Int16
        Get
            Return _Mes
        End Get
        Set(ByVal value As Int16)
            _Mes = value
        End Set
    End Property

    Public Property FormularioPrincipal() As BADepNotasTransfFrm
        Get
            Return _FormularioPrincipal
        End Get
        Set(ByVal value As BADepNotasTransfFrm)
            _FormularioPrincipal = value
        End Set
    End Property

    Private _Modalidad As String
    Public Property Modalidad() As String
        Get
            Return _Modalidad
        End Get
        Set(ByVal value As String)
            _Modalidad = value
        End Set
    End Property

    Private _intBanco As Int16
    Public Property intBanco() As Int16
        Get
            Return _intBanco
        End Get
        Set(ByVal value As Int16)
            _intBanco = value
        End Set
    End Property
    Private Sub BADepNotasTransEdicionFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BATransaccionesDetalleTableAdapter.Connection.ConnectionString = strcnCAD
        Me.CTBATransaccionesDocumentacionTableAdapter.Connection.ConnectionString = strcnCAD
        Me.BATransaccionesEncabezadoTableAdapter.Connection.ConnectionString = strcnCAD
        Me.BABancosTableAdapter.Connection.ConnectionString = strcnCAD
        Me.BASaldosMensualesTableAdapter.Connection.ConnectionString = strcnCAD
        Me.CTCatalogoCuentasTableAdapter.Connection.ConnectionString = strcnCAD
        Me.CTTransaccionesDetalleTableAdapter.Connection.ConnectionString = strcnCAD
        Me.CTTransaccionesEncabezadoTableAdapter.Connection.ConnectionString = strcnCAD
        Me.CTCatalogoCuentasTableAdapter.Fill(Me.BATransaccionesEdicionDataSet.CTCatalogoCuentas)


        BaCls.DBconStr = strcnCAD
        drConf = BaCls.drConf
        Me.BABancosTableAdapter.Fill(Me.BATransaccionesEdicionDataSet.BABancos, intBanco)
        Me.BASaldosMensualesTableAdapter.Fill(Me.BATransaccionesEdicionDataSet.BASaldosMensuales, intBanco, Año, Mes)
        drvBASaldosMen = Me.BASaldosMensualesBindingSource.Current
        drvBanco = Me.BancosBindingSource.Current
        lblDescBanco.Text = drvBanco("DescripcionBanco")
        lblCodigoBanco.Text = drvBanco("CodigoBanco")
        lblCuenta.Text = drvBanco("CuentaBancaria")
        If Not drvBASaldosMen Is Nothing Then
            decSaldo = drvBASaldosMen("SaldoAnterior") + drvBASaldosMen("Depositos") + drvBASaldosMen("Creditos") - drvBASaldosMen("Cheques") - drvBASaldosMen("Debitos")
        End If
        lblSaldo.Text = Format(decSaldo, "#,##0.00")

        Select Case TipoDocumento
            Case 1
                strDescripTipo = "DP"
            Case 3
                strDescripTipo = "NC"
            Case 4
                strDescripTipo = "ND"
            Case 6
                strDescripTipo = "TR"
        End Select
        If Modalidad = "NUEVO" Then
            PrincipalBindingSource.AddNew()
            drvTransEnc = PrincipalBindingSource.Current()
            drvTransEnc("CodigoBanco") = intBanco
        End If
        If Modalidad <> "NUEVO" Then
            CargarDatos()
        End If
        If TipoDocumento <> 5 Then
            groupTransferencia.Enabled = False
        Else
            groupTransferencia.Enabled = True
        End If
        Me.EditDataNavBar1.HabilitarBotones(Me)
    End Sub


    Public Sub CargarDatos()
        Try

            Me.BATransaccionesEncabezadoTableAdapter.Fill(Me.BATransaccionesEdicionDataSet.BATransaccionesEncabezado, intBanco, TipoDocumento, Año, Mes)
            Dim drvTransBan As DataRowView = Me.PrincipalBindingSource.Current
            Me.BATransaccionesDetalleTableAdapter.Fill(Me.BATransaccionesEdicionDataSet.BATransaccionesDetalle, intBanco, TipoDocumento, drvTransBan("NoDocumento"), Año, Mes)
            Me.CTBATransaccionesDocumentacionTableAdapter.Fill(Me.BATransaccionesEdicionDataSet.CTBATransaccionesDocumentacion, drvTransBan("Id"))
            intId = drvTransBan("Id")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub AgregarCuentaDetalle()
        Dim drCat As DataRow = Me.BATransaccionesEdicionDataSet.CTCatalogoCuentas.FindByCuenta(drvBanco("CuentaContable"))
        If Not drCat Is Nothing Then
            Dim drvTransDet = Me.BADetalleTransBindingSource.AddNew
            drvTransDet("CodigoBanco") = intBanco
            drvTransDet("TipoDocumento") = TipoDocumento
            drvTransDet("NoDocumento") = 0
            drvTransDet("Fecha") = C1DateEditFecha.Value
            drvTransDet("Cuenta") = drCat("Cuenta")
            drvTransDet("Descripcion") = drCat("Descripcion")
            If TipoDocumento = 1 Or TipoDocumento = 3 Then
                drvTransDet("Debe") = C1NumericEditValor.Value
            Else
                drvTransDet("Haber") = C1NumericEditValor.Value
            End If
            drvTransDet("Año") = Año
            drvTransDet("Mes") = Mes
        End If
    End Sub


    Private Sub EditDataNavBar1_GuardarClick(sender As Object, e As EventArgs) Handles EditDataNavBar1.GuardarClick
        Try
            If Modalidad = "NUEVO" Then
                Dim drvTransEnc As DataRowView = PrincipalBindingSource.Current
                drvTransEnc("TipoDocumento") = TipoDocumento
                drvTransEnc("Año") = Año
                drvTransEnc("Mes") = Mes
                drvTransEnc("NoDocumento") = BaCls.UltimoNoDoc(drvTransEnc("CodigoBanco"), TipoDocumento) + 1
                drvTransEnc("DescripcionTipo") = strDescripTipo
                drvTransEnc("Usuario") = UsuarioActual
                drvTransEnc("FechaCreacion") = Date.Now
                Me.Validate()
                PrincipalBindingSource.EndEdit()
                Me.BATransaccionesEncabezadoTableAdapter.Update(Me.BATransaccionesEdicionDataSet.BATransaccionesEncabezado)
                Dim drvEnc As DataRowView = Me.PrincipalBindingSource.Current
                For Each drvDet As DataRowView In Me.BADetalleTransBindingSource
                    drvDet("NoTransaccion") = drvEnc("NoTransaccion")
                Next
                BADetalleTransBindingSource.EndEdit()
                Me.BATransaccionesDetalleTableAdapter.Update(Me.BATransaccionesEdicionDataSet.BATransaccionesDetalle)
                For Each drvDetDoc As DataRowView In Me.CTBATransDocBindingSource
                    drvDetDoc("NoTransaccionBancos") = drvEnc("NoDocumento")
                    drvDetDoc("IdTransaccionBancos") = drvEnc("Id")
                Next
                CTBATransDocBindingSource.EndEdit()
                Me.CTBATransaccionesDocumentacionTableAdapter.Update(Me.BATransaccionesEdicionDataSet.CTBATransaccionesDocumentacion)
                BaCls.ActualizarUltimoDoc(intBanco, TipoDocumento)  'Actualiza el numero de documento en configuración
            ElseIf Modalidad = "EDITAR" Then

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub EditDataNavBar1_SalirClick(sender As Object, e As EventArgs) Handles EditDataNavBar1.SalirClick
        Me.Close()
    End Sub

    Private Sub ButtonAlBanco_Click(sender As Object, e As EventArgs) Handles ButtonAlBanco.Click
        boCuentaListaSel = False
        Dim lista As New BAListaBancosFrm
        lista.ShowDialog()
        If lista.DialogResult = DialogResult.OK Then
            boCuentaListaSel = True
            Dim drvBanco As DataRowView = lista.BAListaBancosBindingSource.Current
            C1TextBoxCodigo.Text = drvBanco("CodigoBanco")
            C1TextBoxDescripcion.Text = drvBanco("DescripcionBanco")
            boCuentaListaSel = False
        End If
    End Sub

    Private Sub C1TextBoxCodigo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles C1TextBoxCodigo.Validating
        If C1TextBoxCodigo.Text.ToString.Length > 0 Then
            If boCuentaListaSel = False Then
                Dim drLista As DataRow = Me.BATransaccionesEdicionDataSet.BABancos.FindByCodigoBanco(C1TextBoxCodigo.Text)
                If drLista Is Nothing Then
                    MsgBox("Banco no existe!")
                    C1TextBoxCodigo.Text = ""
                    C1TextBoxDescripcion.Text = ""
                    e.Cancel = True
                Else
                    boCuentaListaSel = True
                    C1TextBoxCodigo.Text = drLista("Cuenta")
                    C1TextBoxDescripcion.Text = drLista("Descripcion")
                End If
            End If
        End If
    End Sub

    Private Sub C1TrueDBGridDetalleTrans_BeforeUpdate(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles C1TrueDBGridDetalleTrans.BeforeUpdate
        If C1TrueDBGridDetalleTrans.AddNewMode = C1.Win.C1TrueDBGrid.AddNewModeEnum.AddNewPending Then  'Si está agregando un nuevo registro
            Dim EncDatosRow As DataRowView = Me.PrincipalBindingSource.Current
            C1TrueDBGridDetalleTrans.Columns("CodigoBanco").Value = intBanco
            C1TrueDBGridDetalleTrans.Columns("TipoDocumento").Value = TipoDocumento
            C1TrueDBGridDetalleTrans.Columns("Mes").Value = Mes
            C1TrueDBGridDetalleTrans.Columns("Año").Value = Año
            C1TrueDBGridDetalleTrans.Columns("Fecha").Value = C1DateEditFecha.Value
            C1TrueDBGridDetalleTrans.Columns("NoTransaccion").Value = 0
        End If
    End Sub

    Private Sub C1TrueDBGridDetalleTrans_ButtonClick(sender As Object, e As ColEventArgs) Handles C1TrueDBGridDetalleTrans.ButtonClick
        If e.Column.Name = "Cuenta" Then
            dbCat.ShowDialog()
            If dbCat.DialogResult = DialogResult.OK Then
                Dim drvSelCat As DataRowView = dbCat.ListaCatBindingSource.Current
                C1TrueDBGridDetalleTrans.Columns("Cuenta").Value = drvSelCat("Cuenta")
                C1TrueDBGridDetalleTrans.Columns("Descripcion").Value = drvSelCat("Descripcion")
            End If
        End If
    End Sub

    Private Sub ButtonAgregarDocumento_Click(sender As Object, e As EventArgs) Handles ButtonAgregarDocumento.Click
        BADocFrm.TextBoxArchivo.Text = ""
        BADocFrm.TextBoxComentario.Text = ""
        BADocFrm.LblFecha.Text = ""
        BADocFrm.LblTipoArchivo.Text = ""
        BADocFrm.LblUsuario.Text = ""
        BADocFrm.ShowDialog()
        If BADocFrm.DialogResult = DialogResult.OK Then
            Dim drvDoc As DataRowView = Me.CTBATransDocBindingSource.AddNew
            If Modalidad = "NUEVO" Then
                drvDoc("NoTransaccionBancos") = "0"
                drvDoc("Fecha") = C1DateEditFecha.Value
                drvDoc("Usuario") = "Usuario" 'UsuarioActual
                drvDoc("NombreDocumento") = System.IO.Path.GetFileName(BADocFrm.TextBoxArchivo.Text)
                If BADocFrm.TextBoxComentario.Text.Length > 0 Then
                    drvDoc("Comentario") = BADocFrm.TextBoxComentario.Text
                End If
                Dim fileBytes As Byte()
                Dim binario As New FileStream(BADocFrm.TextBoxArchivo.Text, FileMode.Open, FileAccess.Read)
                Dim reader As New BinaryReader(binario)
                fileBytes = reader.ReadBytes(binario.Length)
                drvDoc("Documento") = fileBytes
            End If
        End If
    End Sub

    Private Sub ButtonVerDocumento_Click(sender As Object, e As EventArgs) Handles ButtonVerDocumento.Click
        Dim drvDoc As DataRowView = Me.CTBATransDocBindingSource.Current
        'Dim bytes As Byte() = CType(cmd.ExecuteScalar(), Byte())
        ''Dim Size As Integer = 1024 * 1024
        'Dim buffer As Byte() = New Byte(Size)
        ''Dim buffer As Byte() = New Byte(Size - 1) {}
        ''Dim readBytes As Integer = 0
        ''Dim Index As Integer = 0
        Dim bytes As Byte() = CType(drvDoc("Documento"), Byte())
        File.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & drvDoc("NombreDocumento"), bytes)
        Process.Start(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & drvDoc("NombreDocumento"))
        ''Dim bytes As Byte() = drvDoc("Documento")
        ''Dim ms As New IO.MemoryStream(bytes)
        ''Dim fs As FileStream = New FileStream(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & drvDoc("NombreDocumento"), FileMode.Create)
        ''fs.Write(Buffer, 0, Buffer.Length)
        ''fs.Close()
        'FileStream fs = New FileStream(@"C:\test.pdf", FileMode.Create);
        'fs.Write(Buffer, 0, Buffer.Length);
        'fs.Close();
        'conn.Close()
        'pictureBox1.Image = Image.FromStream(New MemoryStream(bytes))
    End Sub

    Private Sub BADepNotasTransEdicionFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Modalidad <> "NUEVO" Then
            FormularioPrincipal.EliminarRegistroAbierto(Trim(Str(intId)))
        End If
    End Sub

    Private Sub C1NumericEditValor_Validated(sender As Object, e As EventArgs) Handles C1NumericEditValor.Validated
        AgregarCuentaDetalle()
    End Sub
    Private Sub ActualizarContabilidad()
        Try
            Dim drvBAEnc As DataRowView = Me.PrincipalBindingSource.Current
            Dim drvCTEnc As DataRowView = Me.CTTransEncBindingSource.AddNew
            Dim strNoTrans As String = strDescripTipo & Trim(Str(intBanco)) & "-" & drvBAEnc("NoDocumento")
            'Datos de encabezado
            drvCTEnc("NoTransaccion") = "0"
            drvCTEnc("Fecha") = drvBAEnc("Fecha")
            drvCTEnc("TipoPartida") = "BANCOS"
            drvCTEnc("Sinopsis") = drvBAEnc("Concepto")
            drvCTEnc("ModuloFuente") = "BAN"
            drvCTEnc("NoDocumentoFuente") = drvBAEnc("NoDocumento")
            drvCTEnc("Beneficiario") = drvBAEnc("Beneficiario")
            drvCTEnc("Usuario") = drvBAEnc("Usuario")
            drvCTEnc("FechaCreacion") = Date.Now
            drvCTEnc("Cerrado") = True
            drvCTEnc("Año") = Año
            drvCTEnc("Mes") = Mes

            'Datos del detalle
            Dim i As Int16 = 1
            For Each drvBADet As DataRowView In Me.BADetalleTransBindingSource
                Dim drvCTDet As DataRowView = Me.CTTransDetBindingSource.AddNew()
                drvCTDet("NoTransaccion") = "0"
                drvCTDet("Linea") = i
                drvCTDet("Fecha") = drvBAEnc("Fecha")
                drvCTDet("Cuenta") = drvBADet("Cuenta")
                drvCTDet("Descripcion") = drvBADet("Descripcion")
                drvCTDet("Debe") = drvBADet("Debe")
                drvCTDet("Haber") = drvBADet("Haber")
                drvCTDet("ValorEquivalente") = drvBADet("ValorEquivalente")
                drvCTDet("Año") = Año
                drvCTDet("Mes") = Mes
                i = i + 1
            Next
            Me.CTTransEncBindingSource.EndEdit()
            Me.CTTransDetBindingSource.EndEdit()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub Totalizar()
        Dim i As Int16

        decTotalDebe = 0
        decTotalHaber = 0
        For i = 0 To C1TrueDBGridDetalleTrans.RowCount - 1
            decTotalDebe = decTotalDebe + C1TrueDBGridDetalleTrans(i, "Debe")
            decTotalHaber = decTotalHaber + C1TrueDBGridDetalleTrans(i, "Haber")
        Next
        lblTotalDebe.Text = Format(decTotalDebe, "#,##0.00")
        lblTotalHaber.Text = Format(decTotalHaber, "#,##0.00")
    End Sub

    Private Sub C1TrueDBGridDetalleTrans_AfterUpdate(sender As Object, e As EventArgs) Handles C1TrueDBGridDetalleTrans.AfterUpdate
        Totalizar()
    End Sub
End Class