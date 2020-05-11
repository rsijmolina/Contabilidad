Public Class CTConfiguracion

    Private Sub CTConfiguracion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CTConfTableAdapter.Connection.ConnectionString = strcnCAD
        Me.CTConfTableAdapter.Fill(Me.CTConfDataSet.CTConf)
        Dim LineaDatosRow As DataRowView
        'TODO: esta línea de código carga datos en la tabla 'CTConf._CTConf' Puede moverla o quitarla según sea necesario.
        'Me.CTConfTableAdapter.Fill(Me.CTConfDataSet.CTConf)

        LineaDatosRow = PrincipalBindingSource.Current
        If Me.PrincipalBindingSource.Count = 0 Then
            Me.PrincipalBindingSource.AddNew()

            LineaDatosRow("AñoEnProceso") = Date.Now.Year
            LineaDatosRow("MesEnProceso") = Date.Now.Month
            LineaDatosRow("MesDeCierre") = 12
        Else
            If LineaDatosRow("RellenoCerosNiveles") = 1 Then
                radiobutIzquierda.Checked = True
            Else
                radiobutDerecha.Checked = True
            End If

            If LineaDatosRow("TipoPresupuesto") = "A" Then
                radiobutPresupAnual.Checked = True
            ElseIf LineaDatosRow("TipoPresupuesto") = "M" Then
                radiobutPresupMensual.Checked = True
            Else
                radiobutPresupTrimestral.Checked = True
            End If
        End If
    End Sub

    Private Sub butCancelar_Click(sender As System.Object, e As System.EventArgs) Handles butCancelar.Click
        Me.Close()
    End Sub

    Private Sub butAceptar_Click(sender As System.Object, e As System.EventArgs) Handles butAceptar.Click
        Dim LineaDatosRow As DataRowView
        Dim mFecha As Date

        Try
            LineaDatosRow = PrincipalBindingSource.Current

            mFecha = LineaDatosRow("FechaProceso")
            If mFecha.Month <> LineaDatosRow("MesEnProceso") Then
                MsgBox("El mes en proceso no coincide con el de la fecha de proceso", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If mFecha.Year <> LineaDatosRow("AñoEnProceso") Then
                MsgBox("El año en proceso no coincide con el de la fecha de proceso", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If radiobutIzquierda.Checked Then
                LineaDatosRow("RellenoCerosNiveles") = 1
            ElseIf radiobutDerecha.Checked Then
                LineaDatosRow("RellenoCerosNiveles") = 2
            End If

            If radiobutPresupAnual.Checked Then
                LineaDatosRow("TipoPresupuesto") = "A"
            ElseIf radiobutPresupMensual.Checked Then
                LineaDatosRow("TipoPresupuesto") = "M"
            Else
                LineaDatosRow("TipoPresupuesto") = "T"
            End If

            Me.Validate()
            Me.PrincipalBindingSource.EndEdit()
            Me.CTConfTableAdapter.Update(Me.CTConfDataSet.CTConf)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Close()
    End Sub
End Class