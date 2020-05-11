Public Class PLConfFrm

    Private Sub PLConfFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PLConfDataSet.PLCalculoDeducciones' Puede moverla o quitarla según sea necesario.
        Me.PLCalculoDeduccionesTableAdapter.Connection.ConnectionString = strcnCAD
        Me.PLCalculoDeduccionesTableAdapter.Fill(Me.PLConfDataSet.PLCalculoDeducciones)
        'TODO: esta línea de código carga datos en la tabla 'PLConfDataSet.PLCalculoDeducciones' Puede moverla o quitarla según sea necesario.
        'Me.PLCalculoDeduccionesTableAdapter.Fill(Me.PLConfDataSet.PLCalculoDeducciones)
        Dim LineaDatosRow As DataRowView
        'TODO: esta línea de código carga datos en la tabla 'PLConfDataSet.PLConf' Puede moverla o quitarla según sea necesario.        

        CargarListas(cmbSeguro)
        CargarListas(cmbCooperativa)
        CargarListas(cmbRAP)
        CargarListas(cmbImpRenta)
        CargarListas(cmbImpVecinal)
        CargarListas(cmbINJUPEMP)
        CargarListas(cmbINPREMA)
        Me.PLConfTableAdapter.Connection.ConnectionString = strcnCAD
        Me.PLConfTableAdapter.Fill(Me.PLConfDataSet.PLConf)

        If Me.PrincipalBindingSource.Count = 0 Then
            Me.PrincipalBindingSource.AddNew()
        End If

        LineaDatosRow = PrincipalBindingSource.Current
        If LineaDatosRow("TipoCalculoCooperativa") = "P" Then
            radiobutCalcCoopPorcSueldo.Checked = True
        Else
            radiobutValorCoopOpcional.Checked = True
        End If
    End Sub

    Private Sub butCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCancelar.Click
        'PrincipalBindingSource.CancelEdit()
        Me.Close()
    End Sub

    Private Sub CargarListas(ByVal cmbLista As Windows.Forms.ComboBox)
        cmbLista.Items.Add("Cada Planilla")
        cmbLista.Items.Add("Planilla Específica")
        cmbLista.Items.Add("No Calcular")
        cmbLista.Text = "Cada Planilla"
    End Sub

    Private Sub butAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAceptar.Click
        Dim LineaDatosRow As DataRowView
        Dim mFecha As Date

        mFecha = c1dateFechaProceso.Value
        If mFecha.Month <> c1numMesProceso.Value Then
            MsgBox("El mes en proceso no coincide con el de la fecha de proceso", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If mFecha.Year <> c1numAñoProceso.Value Then
            MsgBox("El año en proceso no coincide con el de la fecha de proceso", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        LineaDatosRow = PrincipalBindingSource.Current
        If radiobutCalcCoopPorcSueldo.Checked Then
            LineaDatosRow("TipoCalculoCooperativa") = "P"
        Else
            LineaDatosRow("TipoCalculoCooperativa") = "V"
        End If

        Try
            Me.Validate()
            Me.PrincipalBindingSource.EndEdit()
            Me.PLConfTableAdapter.Update(Me.PLConfDataSet.PLConf)
            Me.PLCalculoDeduccionesTableAdapter.Update(Me.PLConfDataSet.PLCalculoDeducciones)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.Close()
        End Try
    End Sub

    Private Sub butExcepciones_Click(sender As System.Object, e As System.EventArgs) Handles butExcepciones.Click
        Dim PLDedExcepFrm As New PLDeduccionesExcepcionesFrm
        PLDedExcepFrm.ShowDialog()
    End Sub
End Class