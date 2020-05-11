Public Class DeduccionesEdicionFrm
    Dim PlCls As New PLClassLib.PlClass
    Dim drCnf As SqlClient.SqlDataReader
    Private Sub DeduccionesEdicionFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIPrincipal
        Me.Top = 10
        Me.Left = 10

        PlCls.DBconStr = strcnCAD
        drCnf = PlCls.drConf
        Me.PLDefinicionDeduccionesTableAdapter.Fill(Me.PLEdicionDeduccionesDataSet.PLDefinicionDeducciones)
    End Sub
    Private Sub c1cmbDeducciones_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1cmbDeducciones.SelectedValueChanged
        Me.PLDeduccionesTableAdapter.Fill(Me.PLEdicionDeduccionesDataSet.PLDeducciones, c1cmbDeducciones.SelectedValue)
        DataNavBarPrincipal.Reinicializar()
    End Sub

    Private Sub PrincipalBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrincipalBindingSource.PositionChanged
        Dim mDatos As DataRowView

        mDatos = PrincipalBindingSource.Current
        If Not IsNothing(mDatos) Then
            If Not DataNavBarPrincipal.ModificarRegistro Then
            End If
        End If
    End Sub

    Private Sub DataNavBarPrincipal_GuardarRegistroClick(ByVal sender As Object, ByVal e As System.EventArgs, ByRef Cancelar As Boolean) Handles DataNavBarPrincipal.GuardarRegistroClick
        DataNavBarPrincipal.ResultadoValidacion = ""
        DataNavBarPrincipal.ValidacionCorrecta = True
        DataNavBarPrincipal.ValidarInfo(Me)
        If DataNavBarPrincipal.ValidacionCorrecta = True Then
            Try
                Me.Validate()
                Me.PrincipalBindingSource.EndEdit()
                'Me.PLDeduccionesTableAdapter.Update(Me.PLEdicionDeduccionesDataSet.PLDeducciones)
            Catch ex As Exception
                Cancelar = True
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Verifique los siguientes datos:" & vbCrLf & DataNavBarPrincipal.ResultadoValidacion)
        End If
    End Sub

    Private Sub DataNavBarPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.Load

    End Sub

    Private Sub DataNavBarPrincipal_SalirClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.SalirClick
        Me.Close()
    End Sub
End Class