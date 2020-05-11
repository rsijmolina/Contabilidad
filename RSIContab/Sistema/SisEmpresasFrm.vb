Public Class SisEmpresasFrm
    Dim ListaRegistrosAbiertos As New Collection
    Private Sub SisEmpresasFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 10
        Try
            Me.DBTableAdapter.Connection.ConnectionString = crfgXNN
            Me.DBTableAdapter.Fill(Me.SisEmpresasListaDataSet.DB)
            If Me.SisEmpresasListaDataSet.DB.Rows.Count = 0 Then
                Me.ListaDataNavBarPrin.HabilitarSoloBotonNuevo()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub
    Private Sub ListaDataNavBarPrin_ConsultarRegistroClick(sender As Object, e As EventArgs) Handles ListaDataNavBarPrin.ConsultarRegistroClick
        CargarForma("CONSULTAR")
    End Sub

    Private Sub ListaDataNavBarPrin_EditarRegistroClick(sender As Object, e As EventArgs) Handles ListaDataNavBarPrin.EditarRegistroClick
        CargarForma("EDITAR")
    End Sub

    Private Sub ListaDataNavBarPrin_EliminarRegistroClick(sender As Object, e As EventArgs) Handles ListaDataNavBarPrin.EliminarRegistroClick
        CargarForma("ELIMINAR")
    End Sub

    Private Sub ListaDataNavBarPrin_NuevoRegistroClick(sender As Object, e As EventArgs) Handles ListaDataNavBarPrin.NuevoRegistroClick
        CargarForma("NUEVO")
    End Sub

    Private Sub ListaDataNavBarPrin_RecargarDatosClick(sender As Object, e As EventArgs) Handles ListaDataNavBarPrin.RecargarDatosClick
        RecargarDatos()
    End Sub

    Private Sub ListaDataNavBarPrin_SalirClick(sender As Object, e As EventArgs) Handles ListaDataNavBarPrin.SalirClick
        Me.Close()
    End Sub
    Private Sub CargarForma(strModalidad As String)
        If strModalidad = "NUEVO" Then
            Dim EditFormaFrm As New SisEmpresasEditFrm
            EditFormaFrm.FormularioPrincipal = Me
            EditFormaFrm.MdiParent = Me.MdiParent
            EditFormaFrm.Modalidad = strModalidad
            EditFormaFrm.Show()
        Else
            Dim reg As DataRowView = PrincipalBindingSource.Current
            If Not ListaRegistrosAbiertos.Contains(reg("ID")) Then
                Dim EditFormaFrm As New SisEmpresasEditFrm
                EditFormaFrm.FormularioPrincipal = Me
                EditFormaFrm.MdiParent = Me.MdiParent
                EditFormaFrm.Modalidad = strModalidad
                EditFormaFrm.intID = reg("ID")
                ListaRegistrosAbiertos.Add(reg("ID"), Trim(Str(reg("ID"))))
                EditFormaFrm.Show()
            End If
        End If
    End Sub
    Public Sub RecargarDatos()
        Me.DBTableAdapter.Fill(Me.SisEmpresasListaDataSet.DB)
        If Me.SisEmpresasListaDataSet.DB.Rows.Count = 0 Then
            Me.ListaDataNavBarPrin.HabilitarSoloBotonNuevo()
        Else
            Me.ListaDataNavBarPrin.HabilitarTodosBotones()
        End If
    End Sub
    Public Sub EliminarRegistroAbierto(intID As Int32)
        ListaRegistrosAbiertos.Remove(Trim(Str(intID)))
    End Sub

End Class