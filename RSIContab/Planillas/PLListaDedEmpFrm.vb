Public Class PLListaDedEmpFrm
    Private _CodEmpleado As String
    Public Property CodEmpleado() As String
        Get
            CodEmpleado = _CodEmpleado
        End Get
        Set(ByVal value As String)
            _CodEmpleado = value
        End Set
    End Property
    Public Sub CargarDatos()
        Me.PLDeduccionesTableAdapter.Fill(PLListaDedEmpDataSet.PLDeducciones, CodEmpleado)
    End Sub

    Private Sub c1truedbgrdDedEmp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1truedbgrdDedEmp.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar.PerformClick()
        End If
    End Sub
End Class