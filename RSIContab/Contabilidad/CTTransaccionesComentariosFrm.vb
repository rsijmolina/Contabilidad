Public Class CTTransaccionesComentariosFrm
    Private _BarraPrin As DataNavBar
    Private _NoTransaccion As String
    Dim intNumControles As Int16, intNombreControles
    Property BarraPrin() As DataNavBar
        Get
            BarraPrin = _BarraPrin
        End Get
        Set(ByVal value As DataNavBar)
            _BarraPrin = value
        End Set
    End Property
    Property NoTransaccion() As String
        Get
            NoTransaccion = _NoTransaccion
        End Get
        Set(ByVal value As String)
            _NoTransaccion = value
        End Set
    End Property

    Private Sub CTTransaccionesComentariosFrm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If toolstripbutNuevo.Enabled = False Then   'Editando datos
            If MsgBox("Desea salir sin guardar los cambios", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                BarraPrin.ModalidadDeshabilitadoTotal = False
            Else
                e.Cancel = True
            End If
        Else
            BarraPrin.ModalidadDeshabilitadoTotal = False
        End If
    End Sub
    Private Sub CTTransaccionesComentariosFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIPrincipal
        intNumControles = 0
        intNombreControles = 0
        BarraPrin.ModalidadDeshabilitadoTotal = True

        CTTransaccionesComentariosTableAdapter.Connection.ConnectionString = strcnCAD
        CTTransaccionesComentariosTableAdapter.Fill(Me.CTComentariosDataSet.CTTransaccionesComentarios, NoTransaccion)
        If ComentariosBindingSource.Count > 0 Then
            CargarDatos()
        End If
    End Sub

    Private Sub toolstripbutNuevo_Click(sender As System.Object, e As System.EventArgs) Handles toolstripbutNuevo.Click
        Dim CtrlComent As New ControlComentarios
        intNumControles = intNumControles + 1
        intNombreControles = intNombreControles + 1
        CtrlComent.Name = "CtrlComentario" & Trim(Str(intNombreControles))
        flowlayoutComentarios.Controls.Add(CtrlComent)
        AddHandler CtrlComent.GuardarRegistroClick, AddressOf CtrlComentariosGuardar_Click
        AddHandler CtrlComent.DeshacerCambiosClick, AddressOf CtrlComentariosDeshacer_Click
        AddHandler CtrlComent.EliminarRegistroClick, AddressOf CtrlComentariosEliminar_Click
        AddHandler CtrlComent.ModificarRegistroClick, AddressOf CtrlComentariosModificar_Click
        ModificarAltura()
        CtrlComent.DBID = 0
        CtrlComent.DBUsuario = My.Settings.RSIUsuarioActual
        CtrlComent.DBFecha = Date.Now
        CtrlComent.DBNoTransaccion = NoTransaccion
        CtrlComent.toolstriplabelUsuario.Text = CtrlComent.DBUsuario
        CtrlComent.toolstriplabelFecha.Text = CtrlComent.DBFecha.ToShortDateString
        CtrlComent.VerificarControles(True)
        toolstripbutNuevo.Enabled = False

        'CtrlComent.txtComentarios.Text = "CtrlComentario" & Trim(Str(intNombreControles))
    End Sub


    Private Sub toolstripbutCerrar_Click(sender As System.Object, e As System.EventArgs) Handles toolstripbutCerrar.Click
        Me.Close()
    End Sub

    Private Sub CtrlComentariosGuardar_Click(sender As System.Object, e As System.EventArgs)
        Dim LineaDatosRow As DataRowView
        Dim CtrlCom As ControlComentarios

        CtrlCom = sender
        If sender.DBID = 0 Then   'Nuevo registro
            ComentariosBindingSource.AddNew()
            LineaDatosRow = ComentariosBindingSource.Current
            LineaDatosRow("NoTransaccion") = CtrlCom.DBNoTransaccion
            LineaDatosRow("Fecha") = CtrlCom.DBFecha
            LineaDatosRow("Usuario") = CtrlCom.DBUsuario
            LineaDatosRow("Comentario") = CtrlCom.txtComentarios.Text
        Else    'Modificando registro
            ComentariosBindingSource.Filter = "Id=" & CtrlCom.DBID
            LineaDatosRow = ComentariosBindingSource.Current
            LineaDatosRow("Comentario") = CtrlCom.txtComentarios.Text
        End If
        ComentariosBindingSource.EndEdit()
        Me.CTTransaccionesComentariosTableAdapter.Update(Me.CTComentariosDataSet.CTTransaccionesComentarios)

        If sender.DBID = 0 Then   'Nuevo registro
            LineaDatosRow = ComentariosBindingSource.Current
            CtrlCom.DBID = LineaDatosRow("Id")
        End If
        toolstripbutNuevo.Enabled = True
    End Sub
    Private Sub CtrlComentariosModificar_Click(sender As System.Object, e As System.EventArgs)
        Dim CtrlCom As ControlComentarios

        toolstripbutNuevo.Enabled = False
        CtrlCom = sender
        CtrlCom.DBComentario = CtrlCom.txtComentarios.Text
    End Sub
    Private Sub CtrlComentariosEliminar_Click(sender As System.Object, e As System.EventArgs)
        Dim LineaDatosRow As DataRowView
        If MsgBox("Desea eliminar este comentario", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If sender.DBID = 0 Then   'Nuevo registro
                flowlayoutComentarios.Controls.Remove(sender)
                intNumControles = intNumControles - 1
            Else    'Modificando registro
                ComentariosBindingSource.Filter = "Id=" & sender.DBID
                LineaDatosRow = ComentariosBindingSource.Current
                LineaDatosRow.Delete()
                ComentariosBindingSource.EndEdit()
                Me.CTTransaccionesComentariosTableAdapter.Update(Me.CTComentariosDataSet.CTTransaccionesComentarios)
                flowlayoutComentarios.Controls.Remove(sender)
                intNumControles = intNumControles - 1
            End If
            ModificarAltura()
        End If
    End Sub
    Private Sub CtrlComentariosDeshacer_Click(sender As System.Object, e As System.EventArgs)
        If sender.DBID = 0 Then   'Nuevo registro
            flowlayoutComentarios.Controls.Remove(sender)
            intNumControles = intNumControles - 1
            ModificarAltura()
        Else    'Modificando registro
        End If
        toolstripbutNuevo.Enabled = True
    End Sub
    Private Sub ModificarAltura()
        If intNumControles = 0 Then
            Me.Height = 93
        End If
        If intNumControles = 1 Then
            Me.Height = 219
            flowlayoutComentarios.Height = 160
        End If
        If intNumControles = 2 Then
            Me.Height = 380
            flowlayoutComentarios.Height = 320
        End If
        If intNumControles = 3 Then
            Me.Height = 540
            flowlayoutComentarios.Height = 479
        End If
    End Sub
    Private Sub CargarDatos()
        Dim LineaDatos As DataRow

        For Each LineaDatos In CTComentariosDataSet.CTTransaccionesComentarios.Rows
            Dim CtrlComent As New ControlComentarios
            intNumControles = intNumControles + 1
            intNombreControles = intNombreControles + 1
            CtrlComent.Name = "CtrlComentario" & Trim(Str(intNombreControles))
            flowlayoutComentarios.Controls.Add(CtrlComent)
            AddHandler CtrlComent.GuardarRegistroClick, AddressOf CtrlComentariosGuardar_Click
            AddHandler CtrlComent.DeshacerCambiosClick, AddressOf CtrlComentariosDeshacer_Click
            AddHandler CtrlComent.EliminarRegistroClick, AddressOf CtrlComentariosEliminar_Click
            AddHandler CtrlComent.ModificarRegistroClick, AddressOf CtrlComentariosModificar_Click
            ModificarAltura()
            CtrlComent.DBID = LineaDatos("ID")
            CtrlComent.DBUsuario = LineaDatos("Usuario")
            CtrlComent.DBFecha = LineaDatos("Fecha")
            CtrlComent.DBNoTransaccion = LineaDatos("NoTransaccion")
            CtrlComent.txtComentarios.Text = LineaDatos("Comentario")
            CtrlComent.toolstriplabelUsuario.Text = CtrlComent.DBUsuario
            CtrlComent.toolstriplabelFecha.Text = CtrlComent.DBFecha.ToShortDateString
            CtrlComent.toolstriplabelUsuario.ToolTipText = CtrlComent.DBUsuario
            CtrlComent.toolstriplabelFecha.ToolTipText = CtrlComent.DBFecha.ToShortDateString
            CtrlComent.VerificarControles(False)
        Next
    End Sub

    Private Sub flowlayoutComentarios_Paint(sender As Object, e As PaintEventArgs) Handles flowlayoutComentarios.Paint

    End Sub
End Class