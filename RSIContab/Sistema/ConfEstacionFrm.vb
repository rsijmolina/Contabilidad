Public Class ConfEstacionFrm    
    Dim EncripDecrip As New Rsierpgencl.Rsierpcl.RijndaelSimple 'Encriptar y desencriptar cadenas de caracteres
    Dim mDatosCambiados As Boolean
    Dim plainText As String
    Dim cipherText As String
    Dim passPhrase As String
    Dim saltValue As String
    Dim hashAlgorithm As String
    Dim passwordIterations As Integer
    Dim initVector As String
    Dim keySize As Integer
    Private Sub btnBuscarWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarWord.Click
        dlgArch.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.ProgramFiles
        dlgArch.ShowDialog()
        c1txtWord.Text = dlgArch.FileName
    End Sub

    Private Sub btnBuscarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarExcel.Click
        dlgArch.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.ProgramFiles
        dlgArch.ShowDialog()
        c1txtExcel.Text = dlgArch.FileName
    End Sub

    Private Sub btnCarpetaEmpleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarpetaEmpleados.Click
        dlgFolder.ShowDialog()
        c1txtDirEmpleados.Text = dlgFolder.SelectedPath
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        My.Settings.CarpetaWord = c1txtWord.Text
        My.Settings.CarpetaExcel = c1txtExcel.Text
        My.Settings.CarpetaEmpleados = c1txtDirEmpleados.Text
        My.Settings.NecesitaClaveCarpetaEmpleados = chkboxNecesitaClaveCarpetaEmpleados.Checked
        My.Settings.UsuarioCarpetaEmpleados = c1txtUsuarioCarpetaEmpleados.Text
        If c1txtClaveCarpetaEmpleados.Text.Length > 0 Then
            plainText = c1txtClaveCarpetaEmpleados.Text
            If c1txConfirmarClave.Text <> c1txtClaveCarpetaEmpleados.Text Then
                MsgBox("Ingrese correctamente la clave y la confirmación", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                Exit Sub
            End If
            My.Settings.ClaveCarpetaEmpleados = EncripDecrip.Encrypt(plainText, passPhrase, saltValue, hashAlgorithm, passwordIterations, initVector, keySize)
        Else
            My.Settings.ClaveCarpetaEmpleados = ""
        End If
        If chkboxFormatoArbolListaCat.Checked = True Then
            My.Settings.CTFormatoListaCatalogo = "A"
        Else
            My.Settings.CTFormatoListaCatalogo = "G"
        End If
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub ConfEstacionFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        passPhrase = "elshadai"       ' Cualquier cadena de caracteres
        saltValue = "israel"        ' Cualquier cadena de caracteres
        hashAlgorithm = "SHA1"         ' Puede ser "MD5"
        passwordIterations = 2         ' Cualquier número
        initVector = "@1B2c3D4e5F6g7H8" ' must be 16 bytes
        keySize = 256                   ' puede ser 192 or 128

        c1txtWord.Text = My.Settings.CarpetaWord
        c1txtExcel.Text = My.Settings.CarpetaExcel
        c1txtDirEmpleados.Text = My.Settings.CarpetaEmpleados
        chkboxNecesitaClaveCarpetaEmpleados.Checked = My.Settings.NecesitaClaveCarpetaEmpleados
        c1txtUsuarioCarpetaEmpleados.Text = My.Settings.UsuarioCarpetaEmpleados
        c1txtClaveCarpetaEmpleados.Text = ""
        c1txConfirmarClave.Text = ""
        If My.Settings.ClaveCarpetaEmpleados.Length > 0 Then
            c1txtClaveCarpetaEmpleados.Text = EncripDecrip.Decrypt(My.Settings.ClaveCarpetaEmpleados, passPhrase, saltValue, hashAlgorithm, passwordIterations, initVector, keySize)
        Else
            c1txtClaveCarpetaEmpleados.Text = ""
        End If
        If My.Settings.CTFormatoListaCatalogo = "A" Then    'Formato de Arbol en lista de selección del catálogo
            chkboxFormatoArbolListaCat.Checked = True
        Else    'Formato General
            chkboxFormatoArbolListaCat.Checked = False
        End If
        mDatosCambiados = False
    End Sub

End Class