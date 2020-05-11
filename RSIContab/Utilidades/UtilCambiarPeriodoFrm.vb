Public Class UtilCambiarPeriodoFrm
    Dim RSICadenas As New Rsierpgencl.Rsierpcl.Cadenas
    Private Sub UtilCambiarPeriodoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Int16 = 1 To 12
            cmbMeses.Items.Add(RSICadenas.MesLetras(i))
        Next
    End Sub
End Class