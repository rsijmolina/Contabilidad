Public Class PLTablasVariasFrm

    Private Sub PLTablasVariasFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIPrincipal
        Me.Top = 10
        Me.Left = 10

        Me.PLConfTableAdapter.Fill(Me.PLTablasDedDataSet.PLConf)
        Me.PLTablaDiasVacacionesTableAdapter.Fill(Me.PLTablasDedDataSet.PLTablaDiasVacaciones)
        Me.PLTablaImpuestoVecinalTableAdapter.Fill(Me.PLTablasDedDataSet.PLTablaImpuestoVecinal)
        Me.PLTablaISRTableAdapter.Fill(Me.PLTablasDedDataSet.PLTablaISR)
        Me.PLTablaVacacionesProporcionalesTableAdapter.Fill(Me.PLTablasPrestacionesDataSet.PLTablaVacacionesProporcionales)
        Me.PLTablaCesantiaTableAdapter.Fill(Me.PLTablasPrestacionesDataSet.PLTablaCesantia)
        Me.PLTablaPreavisoTableAdapter.Fill(Me.PLTablasPrestacionesDataSet.PLTablaPreaviso)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Guardar("CONF")
        Me.Close()
    End Sub
    Private Sub Guardar(ByVal strTabla As String)
        Try
            Me.Validate()
            Select Case strTabla
                Case "ISR"
                    Me.TablaISRBindingSource.EndEdit()
                    Me.PLTablaISRTableAdapter.Update(Me.PLTablasDedDataSet.PLTablaISR)
                Case "VECINAL"
                    Me.TablaImpVecinalBindingSource.EndEdit()
                    Me.PLTablaImpuestoVecinalTableAdapter.Update(Me.PLTablasDedDataSet.PLTablaImpuestoVecinal)
                Case "DIASVAC"
                    Me.TablaDiasVacacionesBindingSource.EndEdit()
                    Me.PLTablaDiasVacacionesTableAdapter.Update(Me.PLTablasDedDataSet.PLTablaDiasVacaciones)
                Case "CONF"
                    Me.ConfPlaniBindingSource.EndEdit()
                    Me.PLConfTableAdapter.Update(Me.PLTablasDedDataSet.PLConf)
                Case "PREAVISO"
                    Me.PLTablaPreavisoBindingSource.EndEdit()
                    Me.PLTablaPreavisoTableAdapter.Update(Me.PLTablasPrestacionesDataSet.PLTablaPreaviso)
                Case "CESANTIA"
                    Me.PLTablaCesantiaBindingSource.EndEdit()
                    Me.PLTablaCesantiaTableAdapter.Update(Me.PLTablasPrestacionesDataSet.PLTablaCesantia)
                Case "VACPROPOR"
                    Me.PLTablaVacPropBindingSource.EndEdit()
                    Me.PLTablaVacacionesProporcionalesTableAdapter.Update(Me.PLTablasPrestacionesDataSet.PLTablaVacacionesProporcionales)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub c1truedbgrdISR_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdISR.AfterDelete
        Guardar("ISR")
    End Sub

    Private Sub c1truedbgrdISR_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdISR.AfterUpdate
        Guardar("ISR")
    End Sub

    Private Sub c1truedbgrdISR_BeforeDelete(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1truedbgrdISR.BeforeDelete
        If MsgBox("Desea Eliminar Este Datos de la Tabla?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub c1truedbgrdImpVecinal_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdImpVecinal.AfterDelete
        Guardar("VECINAL")
    End Sub

    Private Sub c1truedbgrdImpVecinal_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdImpVecinal.AfterUpdate
        Guardar("VECINAL")
    End Sub

    Private Sub c1truedbgrdImpVecinal_BeforeDelete(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1truedbgrdImpVecinal.BeforeDelete
        If MsgBox("Desea Eliminar Este Datos de la Tabla?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub c1truedbgrdDiasVac_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdDiasVac.AfterDelete
        Guardar("DIASVAC")
    End Sub

    Private Sub c1truedbgrdDiasVac_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdDiasVac.AfterUpdate
        Guardar("DIASVAC")
    End Sub

    Private Sub c1truedbgrdDiasVac_BeforeDelete(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1truedbgrdDiasVac.BeforeDelete
        If MsgBox("Desea Eliminar Este Datos de la Tabla?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub c1truedbgrdISR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1truedbgrdISR.Click

    End Sub

    Private Sub c1truedbgrdTablaPreaviso_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdTablaPreaviso.AfterDelete
        Guardar("PREAVISO")
    End Sub

    Private Sub c1truedbgrdTablaPreaviso_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdTablaPreaviso.AfterUpdate
        Guardar("PREAVISO")
    End Sub

    Private Sub c1truedbgrdTablaPreaviso_BeforeDelete(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1truedbgrdTablaPreaviso.BeforeDelete
        If MsgBox("Desea Eliminar Este Datos de la Tabla?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub c1truedbgrdTablaPreaviso_BeforeUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1truedbgrdTablaPreaviso.BeforeUpdate

    End Sub

    Private Sub c1truedbgrdTablaPreaviso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1truedbgrdTablaPreaviso.Click

    End Sub

    Private Sub c1truedbgrdTablaCesantia_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdTablaCesantia.AfterDelete
        Guardar("CESANTIA")
    End Sub

    Private Sub c1truedbgrdTablaCesantia_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdTablaCesantia.AfterUpdate
        Guardar("CESANTIA")
    End Sub

    Private Sub c1truedbgrdTablaCesantia_BeforeDelete(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1truedbgrdTablaCesantia.BeforeDelete
        If MsgBox("Desea Eliminar Este Datos de la Tabla?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub c1truedbgrdTablaCesantia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1truedbgrdTablaCesantia.Click

    End Sub

    Private Sub c1truedbgrdTablaVacProporcionales_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdTablaVacProporcionales.AfterDelete
        Guardar("VACPROPOR")
    End Sub

    Private Sub c1truedbgrdTablaVacProporcionales_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1truedbgrdTablaVacProporcionales.AfterUpdate
        Guardar("VACPROPOR")
    End Sub

    Private Sub c1truedbgrdTablaVacProporcionales_BeforeDelete(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles c1truedbgrdTablaVacProporcionales.BeforeDelete
        If MsgBox("Desea Eliminar Este Datos de la Tabla?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub c1truedbgrdTablaVacProporcionales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1truedbgrdTablaVacProporcionales.Click

    End Sub
End Class