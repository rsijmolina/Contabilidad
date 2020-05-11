Public Class CTAgregarCuentaFrm
    Dim CTCls As New CTClassLib.CTClass
    Dim ClSGen As New Rsierpgencl.Rsierpcl.Cadenas
    Dim drCtConf As SqlClient.SqlDataReader
    Dim _CuentaCorrecta As Boolean
    Dim intNuevoNivel As Int16
    Dim mInicializado As Boolean

    Public Property CuentaCorrecta() As Boolean
        Get
            CuentaCorrecta = _CuentaCorrecta
        End Get
        Set(ByVal value As Boolean)
            _CuentaCorrecta = value
        End Set
    End Property

    Private Sub CTAgregarCuentaFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CTCls.DBconStr = strcnCAD
        drCtConf = CTCls.drConf
        mInicializado = False
        c1numSubCuenta.Value = 0
        intNuevoNivel = CInt(lblNivel.Text) + 1
        mInicializado = True
    End Sub

    Private Sub butAceptar_Click(sender As System.Object, e As System.EventArgs) Handles butAceptar.Click
        If CTCls.ExisteCuenta(lblNuevaCuenta.Text) Then
            MsgBox("Esta cuenta ya existe", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            CuentaCorrecta = False
        Else
            CuentaCorrecta = True
        End If
    End Sub

    Private Sub c1txtFormato_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles c1txtFormato.Validating
        lblNuevaCuenta.Text = lblCuentaSuperior.Text & c1txtFormato.Text
        If CTCls.ExisteCuenta(lblNuevaCuenta.Text) Then
            picCuenta.Image = My.Resources._1385_Disable_24x24_72
        Else
            picCuenta.Image = My.Resources._112_Tick_Green_32x32_72
        End If
    End Sub

    Private Sub c1numSubCuenta_TextChanged(sender As System.Object, e As System.EventArgs) Handles c1numSubCuenta.TextChanged
        If mInicializado Then
            If Not drCtConf("FormatoLibre") Then
                c1txtFormato.ReadOnly = False
            End If
            If drCtConf("RellenoCerosNiveles") = 1 Then 'Relleno a la izquierda
                c1txtFormato.Text = ClSGen.RellenarIzq(c1numSubCuenta.Text, drCtConf("DigitosNivel" & Strings.Trim(intNuevoNivel.ToString)), "0")
            Else    'Relleno a la derecha
                c1txtFormato.Text = ClSGen.RellenarDer(c1numSubCuenta.Text, drCtConf("DigitosNivel" & Strings.Trim(intNuevoNivel.ToString)), "0")
            End If
            If Not drCtConf("FormatoLibre") Then
                c1txtFormato.ReadOnly = True
            End If

            lblNuevaCuenta.Text = lblCuentaSuperior.Text & c1txtFormato.Text
            If CTCls.ExisteCuenta(lblNuevaCuenta.Text) Then
                picCuenta.Image = My.Resources._1385_Disable_24x24_72
            Else
                picCuenta.Image = My.Resources._112_Tick_Green_32x32_72
            End If            
        End If
    End Sub
End Class