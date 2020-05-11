Imports System
Imports System.IO
Public Class CTMayorizacionFrm
    Dim CTCls As New CTClassLib.CTClass
    Dim ClSGen As New Rsierpgencl.Rsierpcl.Cadenas
    Dim drCtConf As SqlClient.SqlDataReader
    Dim sw As StreamWriter  'Archivos de texto
    Dim strTextoError As String

    Private Sub CTMayorizacionFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CTCls.DBconStr = strcnCAD
        drCtConf = CTCls.drConf
        numupdnAñoIni.Value = drCtConf("AñoEnProceso")
        numupdnAñoFin.Value = drCtConf("AñoEnProceso")
        numupdnMesIni.Value = drCtConf("MesEnProceso")
        numupdnMesFin.Value = drCtConf("MesEnProceso")
    End Sub

    Private Sub butAceptar_Click(sender As System.Object, e As System.EventArgs) Handles butAceptar.Click
        Dim i As Int16, j As Int16, k As Int16, intNumTrans As Int16
        Dim drTransCtasNoPost As SqlClient.SqlDataReader, drTransTotales As SqlClient.SqlDataReader

        If numupdnAñoFin.Value < numupdnAñoIni.Value Then
            MsgBox("El año inicial debe ser menor que el final", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If numupdnAñoFin.Value = numupdnAñoIni.Value And numupdnMesFin.Value < numupdnMesIni.Value Then
            MsgBox("El mes inicial debe ser menor que el final", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        If CTCls.EsMesCerrado(numupdnAñoIni.Value, numupdnMesIni.Value) Then
            MsgBox("El período inicial ya está cerrado, no puede realizar este proceso", vbInformation + vbOKOnly)
            Exit Sub
        End If

        '*** Hacer revisión de partidas
        lblMensaje.Text = "Revisando Partidas..."
        lblMensaje.Refresh()
        Try
            For i = numupdnAñoIni.Value To numupdnAñoFin.Value
                For j = IIf(i = numupdnAñoIni.Value, numupdnMesIni.Value, 1) To IIf(i = numupdnAñoFin.Value, numupdnMesFin.Value, 12)
                    '* Si esta marcado Inicializar Tabla de Saldos
                    If chkboxIniTablaSaldos.Checked Then
                        CTCls.BorrarSaldosMes(i, j)
                    End If

                    '* Actualizar Tabla de Saldos con Datos del Catálogo de Cuentas
                    CTCls.ActualizarTablaSaldosDeCatalogo(i, j)

                    '* Verificar cuentas solo posteables en las partidas
                    drTransCtasNoPost = CTCls.drTransConCuentasNoPosteables(i, j)
                    intNumTrans = 0
                    strTextoError = ""
                    Do While drTransCtasNoPost.Read
                        strTextoError = strTextoError & ClSGen.RellenarDer(drTransCtasNoPost("NoTransaccion"), 20, " ") & " " & ClSGen.RellenarDer(drTransCtasNoPost("Cuenta"), 30, " ") & " " & drTransCtasNoPost("Linea") & " Esta cuenta no es posteable"
                        intNumTrans = intNumTrans + 1
                    Loop
                    drTransCtasNoPost.Close()
                    If intNumTrans >= 1 Then
                        CargarArchivoTexto(i, j, "POSTEABLES")
                        System.Diagnostics.Process.Start("Notepad.Exe", Application.StartupPath & "\logctas.txt")
                        Exit Sub
                    End If

                    '*** Revisar si hay partidas descuadradas
                    intNumTrans = 0
                    strTextoError = ""
                    drTransTotales = CTCls.drTransaccionesDetalleTotales(i, j, True)
                    Do While drTransTotales.Read
                        strTextoError = strTextoError & ClSGen.RellenarDer(drTransTotales("NoTransaccion"), 20, " ") & " " & drTransTotales("Fecha") & " Partida descuadrada"
                        intNumTrans = intNumTrans + 1
                    Loop
                    drTransTotales.Close()
                    If intNumTrans >= 1 Then
                        CargarArchivoTexto(i, j, "DESCUADRES")
                        System.Diagnostics.Process.Start("Notepad.Exe", Application.StartupPath & "\logctas.txt")
                        Exit Sub
                    End If
                Next
            Next

            '*** Proceso de mayorización
            lblMensaje.Text = "Mayorizando..."
            lblMensaje.Refresh()
            For i = numupdnAñoIni.Value To numupdnAñoFin.Value
                For j = IIf(i = numupdnAñoIni.Value, numupdnMesIni.Value, 1) To IIf(i = numupdnAñoFin.Value, numupdnMesFin.Value, 12)
                    '*** Actualizar totales de partidas en la tabla de saldos
                    If chkboxIniTablaSaldos.Checked = False Then
                        If CTCls.ActualizarTablaSaldosDebeHaber(i, j) = False Then
                            MsgBox(CTCls.ErrorMsg, MsgBoxStyle.OkOnly)
                            Exit Sub
                        End If
                    End If
                    '*** Sumar las transacciones por cuentas y actualizar la tabla de saldos
                    If CTCls.ActualizarTablaSaldosDeTransacciones(i, j) = False Then
                        MsgBox(CTCls.ErrorMsg, MsgBoxStyle.OkOnly)
                        Exit Sub
                    End If
                    '*** Mayorizar
                    For k = drCtConf("Niveles") To 2 Step -1
                        If CTCls.MayorizarCuentasSuperiores(i, j, k) = False Then
                            MsgBox(CTCls.ErrorMsg, MsgBoxStyle.OkOnly)
                            Exit Sub
                        End If
                    Next
                    'Me.CTSaldosMensualesClonTableAdapter.Fill(Me.CTMayorizacionDataSet.CTSaldosMensualesClon, i, j)
                    'Me.CTSaldosMensualesTableAdapter.Fill(Me.CTMayorizacionDataSet.CTSaldosMensuales, i, j)
                Next
            Next
            lblMensaje.Text = ""
            lblMensaje.Refresh()
            MsgBox("Proceso Terminado...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub CargarArchivoTexto(intAño As Int16, intMes As Int16, strTipo As String)
        Dim strCadena As String

        strCadena = "Fecha: " & Date.Now & vbCrLf
        strCadena = strCadena & My.Settings.RSIEmpresaActual & vbCrLf
        strCadena = strCadena & "Listado de Partidas con problemas" & vbCrLf
        strCadena = strCadena & vbCrLf
        If strTipo = "POSTEABLES" Then
            strCadena = strCadena & "Año: " & intAño & " Mes: " & ClSGen.MesLetras(intMes)
            strCadena = strCadena & "       Partida                    Cuenta          Linea                Descripcion" & vbCrLf
            strCadena = strCadena & "------------------------------------------------------------------------------------------" & vbCrLf
            '************************123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890
        ElseIf strTipo = "DESCUADRES" Then
            strCadena = strCadena & "Año: " & intAño & " Mes: " & ClSGen.MesLetras(intMes)
            strCadena = strCadena & "       Partida            Fecha            Descripcion" & vbCrLf
            strCadena = strCadena & "------------------------------------------------------------------" & vbCrLf
            '************************123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890
        End If
        sw = New StreamWriter(Application.StartupPath & "\logctas.txt")
        sw.Write(strCadena)
        sw.Write(strTextoError)
        sw.Close()
    End Sub

    Private Sub butCancelar_Click(sender As System.Object, e As System.EventArgs) Handles butCancelar.Click
        drCtConf.Close()
        Me.Close()
    End Sub
End Class