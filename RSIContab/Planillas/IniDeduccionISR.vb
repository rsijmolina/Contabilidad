Public Class IniDeduccionISR
    Dim PlCls As New PLClassLib.PlClass
    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        If PlCls.ExisteCalculoISR(c1numAño.Value) Then
            MsgBox("Ya se ha realizado el proceso de cálculo para el año: " & c1numAño.Value, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

    End Sub

    Private Sub IniDeduccionISR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PlCls.DBconStr = strcnCAD
    End Sub
End Class