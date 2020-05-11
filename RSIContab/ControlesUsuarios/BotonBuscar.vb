Public Class BotonBuscar

    Private _ControlEnlazado As Control
    Private _Enabled As Boolean
    Property ControlEnlazado() As Control
        Get
            ControlEnlazado = _ControlEnlazado
        End Get
        Set(ByVal value As Control)
            _ControlEnlazado = value
        End Set
    End Property
    Overloads Property Enabled() As Boolean
        Get
            Enabled = _Enabled
        End Get
        Set(ByVal value As Boolean)
            _Enabled = value
            If _Enabled = True Then
                btnBuscar.Enabled = True
                btnBuscar.ImageIndex = 1
            Else
                btnBuscar.Enabled = False
                btnBuscar.ImageIndex = 0
            End If
            btnBuscar.Refresh()
        End Set
    End Property


    Private Sub BotonBuscar_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.EnabledChanged

    End Sub


    Private Sub BotonBuscar_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If btnBuscar.Enabled Then
            MyBase.OnClick(e)
        End If
    End Sub

    Private Sub BotonBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
