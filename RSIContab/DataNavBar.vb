Imports Microsoft.VisualBasic.Strings
Public Class DataNavBar

    'Variables para especificar si se ejecuta el código en la aplicación antes o despues del evento del botón
    Private _EjecutarAntesNuevo As Boolean
    Private _EjecutarAntesModificar As Boolean
    Private _EjecutarAntesGrabar As Boolean
    Private _EjecutarAntesCancelar As Boolean
    Private _EjecutarAntesEliminar As Boolean
    Private _EjecutarAntesSalir As Boolean
    'Estado de los datos
    Private _NuevoRegistro As Boolean
    Private _ModificarRegistro As Boolean
    Private _Editando As Boolean
    Private _BarraDeEstado As Windows.Forms.StatusStrip    
    'Estado de los botones
    Private _BindingSourcePrincipal As BindingSource
    Private _UsarBotonPrimerRegistro As Boolean
    Private _UsarBotonRegistroAnterior As Boolean
    Private _UsarTextoPosicionRegistro As Boolean
    Private _UsarBotonSiguienteRegistro As Boolean
    Private _UsarBotonUltimoRegistro As Boolean
    Private _UsarBotonNuevoRegistro As Boolean
    Private _UsarBotonGuardarRegistro As Boolean
    Private _UsarBotonCancelar As Boolean
    Private _UsarBotonModificarRegistro As Boolean
    Private _UsarBotonEliminarRegistro As Boolean
    Private _UsarBotonAnularRegistro As Boolean
    Private _UsarBotonCerrarDocumento As Boolean
    Private _UsarBotonImprimir As Boolean
    Private _UsarBotonContabilizar As Boolean
    Private _UsarBotonComentarios As Boolean
    Private _UsarBotonDocumentacion As Boolean
    Private _UsarBotonMasOpciones As Boolean
    Private _UsarBotonSalir As Boolean
    Private _UsarBuscar As Boolean
    Private _ModalidadSoloLectura As Boolean
    Private _ModalidadDeshabilitadoTotal As Boolean
    'Validacion
    Private _ValidacionCorrecta As Boolean
    Private _ResultadoValidacion As String
    'Datos con detalle
    Private _TieneDetalle As Boolean
    Private _UltimaLinDet As Int16
    Private _MostrarListaInvPermanente As Boolean
    Private _dbgrdDetalle As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Property EjecutarAntesNuevo() As Boolean
        Get
            EjecutarAntesNuevo = _EjecutarAntesNuevo
        End Get
        Set(ByVal value As Boolean)
            _EjecutarAntesNuevo = value
        End Set
    End Property
    Property EjecutarAntesModificar() As Boolean
        Get
            EjecutarAntesModificar = _EjecutarAntesModificar
        End Get
        Set(ByVal value As Boolean)
            _EjecutarAntesModificar = value
        End Set
    End Property
    Property EjecutarAntesGrabar() As Boolean
        Get
            EjecutarAntesGrabar = _EjecutarAntesGrabar
        End Get
        Set(ByVal value As Boolean)
            _EjecutarAntesGrabar = value
        End Set
    End Property
    Property EjecutarAntesCancelar() As Boolean
        Get
            EjecutarAntesCancelar = _EjecutarAntesCancelar
        End Get
        Set(ByVal value As Boolean)
            _EjecutarAntesCancelar = value
        End Set
    End Property
    Property EjecutarAntesEliminar() As Boolean
        Get
            EjecutarAntesEliminar = _EjecutarAntesEliminar
        End Get
        Set(ByVal value As Boolean)
            _EjecutarAntesEliminar = value
        End Set
    End Property
    Property EjecutarAntesSalir() As Boolean
        Get
            EjecutarAntesSalir = _EjecutarAntesSalir
        End Get
        Set(ByVal value As Boolean)
            _EjecutarAntesSalir = value
        End Set
    End Property
    Property BindingSourcePrincipal() As BindingSource
        Get
            BindingSourcePrincipal = _BindingSourcePrincipal
        End Get
        Set(ByVal value As BindingSource)
            _BindingSourcePrincipal = value
        End Set
    End Property
    Property UsarBotonPrimerRegistro() As Boolean
        Get
            UsarBotonPrimerRegistro = _UsarBotonPrimerRegistro
        End Get
        Set(ByVal value As Boolean)
            _UsarBotonPrimerRegistro = value
            If value = True Then
                toolstripbutPrimerRegistro.Visible = True
            Else
                toolstripbutPrimerRegistro.Visible = False
            End If
        End Set
    End Property
    Property UsarBotonRegistroAnterior() As Boolean
        Get
            UsarBotonRegistroAnterior = _UsarBotonRegistroAnterior
        End Get
        Set(ByVal value As Boolean)
            _UsarBotonRegistroAnterior = value
            If value = True Then
                toolstripbutRegistroAnterior.Visible = True
            Else
                toolstripbutRegistroAnterior.Visible = False
            End If
        End Set
    End Property
    Property UsarTextoPosicionRegistro() As Boolean
        Get
            UsarTextoPosicionRegistro = _UsarTextoPosicionRegistro
        End Get
        Set(ByVal value As Boolean)
            _UsarTextoPosicionRegistro = value
            If value = True Then
                toolstriptextPosicionReg.Visible = True
            Else
                toolstriptextPosicionReg.Visible = False
            End If
        End Set
    End Property
    Property UsarBotonSiguienteRegistro() As Boolean
        Get
            UsarBotonSiguienteRegistro = _UsarBotonSiguienteRegistro
        End Get
        Set(ByVal value As Boolean)
            _UsarBotonSiguienteRegistro = value
            If value = True Then
                toolstripbutSiguienteRegistro.Visible = True
            Else
                toolstripbutSiguienteRegistro.Visible = False
            End If
        End Set
    End Property
    Property UsarBotonUltimoRegistro() As Boolean
        Get
            UsarBotonUltimoRegistro = _UsarBotonUltimoRegistro
        End Get
        Set(ByVal value As Boolean)
            _UsarBotonUltimoRegistro = value
            If value = True Then
                toolstripbutUltimoRegistro.Visible = True
            Else
                toolstripbutUltimoRegistro.Visible = False
            End If
        End Set
    End Property
    Property UsarBotonNuevoRegistro() As Boolean
        Get
            UsarBotonNuevoRegistro = _UsarBotonNuevoRegistro
        End Get
        Set(ByVal value As Boolean)
            _UsarBotonNuevoRegistro = value
            If value = True Then
                toolstripbutNuevoRegistro.Visible = True
            Else
                toolstripbutNuevoRegistro.Visible = False
            End If
        End Set
    End Property
    Property UsarBotonGuardarRegistro() As Boolean
        Get
            UsarBotonGuardarRegistro = _UsarBotonGuardarRegistro
        End Get
        Set(ByVal value As Boolean)
            _UsarBotonGuardarRegistro = value
            If value = True Then
                toolstripbutGuardarRegistro.Visible = True
            Else
                toolstripbutGuardarRegistro.Visible = False
            End If
        End Set
    End Property
    Property UsarBotonCancelar() As Boolean
        Get
            UsarBotonCancelar = _UsarBotonCancelar
        End Get
        Set(ByVal value As Boolean)
            _UsarBotonCancelar = value
            If value = True Then
                If value = True Then
                    toolstripbutCancelarGuardar.Visible = True
                Else
                    toolstripbutCancelarGuardar.Visible = False
                End If
            Else
            End If
        End Set
    End Property
    Property UsarBotonModificarRegistro() As Boolean
        Get
            UsarBotonModificarRegistro = _UsarBotonModificarRegistro
        End Get
        Set(ByVal value As Boolean)
            _UsarBotonModificarRegistro = value
            If value = True Then
                toolstripbutModificarRegistro.Visible = True
            Else
                toolstripbutModificarRegistro.Visible = False
            End If
        End Set
    End Property
    Property UsarBotonEliminarRegistro() As Boolean
        Get
            UsarBotonEliminarRegistro = _UsarBotonEliminarRegistro
        End Get
        Set(ByVal value As Boolean)
            _UsarBotonEliminarRegistro = value
            If value = True Then
                toolstripbutEliminarRegistro.Visible = True
            Else
                toolstripbutEliminarRegistro.Visible = False
            End If
        End Set
    End Property
    Property UsarBotonAnularRegistro() As Boolean
        Get
            UsarBotonAnularRegistro = _UsarBotonAnularRegistro
        End Get
        Set(ByVal value As Boolean)
            _UsarBotonAnularRegistro = value
            If value = True Then
                toolstripbutAnularDocumento.Visible = True
            Else
                toolstripbutAnularDocumento.Visible = False
            End If
        End Set
    End Property
    Property UsarBotonCerrarDocumento() As Boolean
        Get
            UsarBotonCerrarDocumento = _UsarBotonCerrarDocumento
        End Get
        Set(ByVal value As Boolean)
            _UsarBotonCerrarDocumento = value
            If value = True Then
                toolstripbutCerrarDocumento.Visible = True
            Else
                toolstripbutCerrarDocumento.Visible = False
            End If
        End Set
    End Property
    Property UsarBotonImprimir() As Boolean
        Get
            UsarBotonImprimir = _UsarBotonImprimir
        End Get
        Set(ByVal value As Boolean)
            _UsarBotonImprimir = value
            If value = True Then
                toolstripbutImprimir.Visible = True
            Else
                toolstripbutImprimir.Visible = False
            End If
        End Set
    End Property
    Property UsarBotonContabilizar() As Boolean
        Get
            UsarBotonContabilizar = _UsarBotonContabilizar
        End Get
        Set(ByVal value As Boolean)
            _UsarBotonContabilizar = value
            If value = True Then
                toolstripbutContabilizar.Visible = True
            Else
                toolstripbutContabilizar.Visible = False
            End If
        End Set
    End Property
    Property UsarBotonComentarios() As Boolean
        Get
            UsarBotonComentarios = _UsarBotonComentarios
        End Get
        Set(ByVal value As Boolean)
            _UsarBotonComentarios = value
            If value = True Then
                toolstripbutComentarios.Visible = True
            Else
                toolstripbutComentarios.Visible = False
            End If
        End Set
    End Property
    Property UsarBotonDocumentacion() As Boolean
        Get
            UsarBotonDocumentacion = _UsarBotonDocumentacion
        End Get
        Set(ByVal value As Boolean)
            _UsarBotonDocumentacion = value
            If value = True Then
                toolstripbutDocumentacion.Visible = True
            Else
                toolstripbutDocumentacion.Visible = False
            End If
        End Set
    End Property
    Property UsarBotonMasOpciones() As Boolean
        Get
            UsarBotonMasOpciones = _UsarBotonMasOpciones
        End Get
        Set(ByVal value As Boolean)
            _UsarBotonMasOpciones = value
            If value = True Then
                toolstripbutMasOpciones.Visible = True
            Else
                toolstripbutMasOpciones.Visible = False
            End If
        End Set
    End Property
    Property UsarBotonSalir() As Boolean
        Get
            UsarBotonSalir = _UsarBotonSalir
        End Get
        Set(ByVal value As Boolean)
            _UsarBotonSalir = value
            If value = True Then
                toolstripbutSalir.Visible = True
            Else
                toolstripbutSalir.Visible = False
            End If
        End Set
    End Property
    Property UsarBuscar() As Boolean
        Get
            UsarBuscar = _UsarBuscar
        End Get
        Set(ByVal value As Boolean)
            _UsarBuscar = value
            If value = True Then
                toolstripllabelBuscar.Visible = True
                toolstriptextBuscar.Visible = True
                toolstripbutBuscar.Visible = True
                toolstripbutReiniciarDatos.Visible = True
                ToolStripSeparator1.Visible = True
            Else
                toolstripllabelBuscar.Visible = False
                toolstriptextBuscar.Visible = False
                toolstripbutBuscar.Visible = False
                toolstripbutReiniciarDatos.Visible = False
                ToolStripSeparator1.Visible = False
            End If
        End Set
    End Property
    Property ModalidadSoloLectura() As Boolean
        Get
            ModalidadSoloLectura = _ModalidadSoloLectura
        End Get
        Set(ByVal value As Boolean)
            _ModalidadSoloLectura = value
            If value = True Then
                toolstripbutAnularDocumento.Enabled = False
                toolstripbutModificarRegistro.Enabled = False
                toolstripbutNuevoRegistro.Enabled = True
                toolstripbutModificarRegistro.Enabled = False
                toolstripbutCancelarGuardar.Enabled = False
                toolstripbutEliminarRegistro.Enabled = False
                toolstripbutAnularDocumento.Enabled = False
                toolstripbutCerrarDocumento.Enabled = False
                toolstripbutContabilizar.Enabled = False
                toolstripbutMasOpciones.Enabled = False
                toolstripbutImprimir.Enabled = True
                If _TieneDetalle Then
                    dbgrdDetalle.AllowUpdate = False
                    dbgrdDetalle.AllowAddNew = False
                    dbgrdDetalle.AllowDelete = False
                End If
            Else
                HabilitarBotonesEnc(True, False)
                If _TieneDetalle Then
                    VerificarEstadoRegistro()
                End If
            End If
        End Set
    End Property
    Property ModalidadDeshabilitadoTotal() As Boolean
        Get
            ModalidadDeshabilitadoTotal = _ModalidadDeshabilitadoTotal
        End Get
        Set(value As Boolean)
            _ModalidadDeshabilitadoTotal = value
            If value = True Then
                toolstripbutSiguienteRegistro.Enabled = False
                toolstripbutRegistroAnterior.Enabled = False
                toolstripbutUltimoRegistro.Enabled = False
                toolstripbutPrimerRegistro.Enabled = False
                toolstripbutNuevoRegistro.Enabled = False
                toolstripbutAnularDocumento.Enabled = False
                toolstripbutModificarRegistro.Enabled = False
                toolstripbutNuevoRegistro.Enabled = False
                toolstripbutModificarRegistro.Enabled = False
                toolstripbutCancelarGuardar.Enabled = False
                toolstripbutEliminarRegistro.Enabled = False
                toolstripbutAnularDocumento.Enabled = False
                toolstripbutCerrarDocumento.Enabled = False
                toolstripbutContabilizar.Enabled = False
                toolstripbutMasOpciones.Enabled = False
                toolstripbutImprimir.Enabled = False
                toolstripbutComentarios.Enabled = False
                toolstripbutDocumentacion.Enabled = False
                toolstripbutBuscar.Enabled = False
                toolstripbutReiniciarDatos.Enabled = False
                toolstripbutSalir.Enabled = False
                If _TieneDetalle Then
                    dbgrdDetalle.AllowUpdate = False
                    dbgrdDetalle.AllowAddNew = False
                    dbgrdDetalle.AllowDelete = False
                End If
            Else
                toolstripbutSalir.Enabled = True
                HabilitarBotonesEnc(True, False)
                If _TieneDetalle Then
                    VerificarEstadoRegistro()
                End If
            End If
        End Set
    End Property
    Property NuevoRegistro() As Boolean
        Get
            NuevoRegistro = _NuevoRegistro
        End Get
        Set(ByVal value As Boolean)
            _NuevoRegistro = value
        End Set
    End Property
    Property ModificarRegistro() As Boolean
        Get
            ModificarRegistro = _ModificarRegistro
        End Get
        Set(ByVal value As Boolean)
            _ModificarRegistro = value
        End Set
    End Property

    Property Editando() As Boolean
        Get
            Editando = _Editando
        End Get
        Set(ByVal value As Boolean)
            _Editando = value
        End Set
    End Property
    Property BarraDeEstado() As Windows.Forms.StatusStrip
        Get
            BarraDeEstado = _BarraDeEstado
        End Get
        Set(ByVal value As Windows.Forms.StatusStrip)
            _BarraDeEstado = value
        End Set
    End Property
    Property ValidacionCorrecta() As Boolean
        Get
            ValidacionCorrecta = _ValidacionCorrecta
        End Get
        Set(ByVal value As Boolean)
            _ValidacionCorrecta = value
        End Set
    End Property
    Property ResultadoValidacion() As String
        Get
            ResultadoValidacion = _ResultadoValidacion
        End Get
        Set(ByVal value As String)
            _ResultadoValidacion = value
        End Set
    End Property
    Property TieneDetalle() As Boolean
        Get
            TieneDetalle = _TieneDetalle
        End Get
        Set(ByVal value As Boolean)
            _TieneDetalle = value
        End Set
    End Property
    Property UltimaLinDet() As Int16
        Get
            UltimaLinDet = _UltimaLinDet
        End Get
        Set(ByVal value As Int16)
            _UltimaLinDet = value
        End Set
    End Property
    Property MostrarListaInvPermanente() As Boolean
        Get
            MostrarListaInvPermanente = _MostrarListaInvPermanente
        End Get
        Set(ByVal value As Boolean)
            _MostrarListaInvPermanente = value
        End Set
    End Property
    Property dbgrdDetalle() As C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Get
            dbgrdDetalle = _dbgrdDetalle
        End Get
        Set(ByVal value As C1.Win.C1TrueDBGrid.C1TrueDBGrid)
            _dbgrdDetalle = value
        End Set
    End Property


    Public Event PrimerRegistroClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event RegistroAnteriorClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event SiguienteRegistroClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event UltimoRegistroClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event NuevoRegistroClick(ByVal sender As Object, ByVal e As EventArgs, ByRef Cancelar As Boolean)
    Public Event GuardarRegistroClick(ByVal sender As Object, ByVal e As EventArgs, ByRef Cancelar As Boolean)
    Public Event CancelarClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event ModificarRegistroClick(ByVal sender As Object, ByVal e As EventArgs, ByRef Cancelar As Boolean)
    Public Event EliminarRegistroClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event AnularRegistroClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event CerrarDocumentoClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event ImprimirClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event ContabilizarClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event ComentariosClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event DocumentacionClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event BuscarRegistroClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event ReiniciarDatosClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event MasOpcionesClick(ByVal sender As Object, ByVal e As EventArgs)
    Public Event SalirClick(ByVal sender As Object, ByVal e As EventArgs)
    Private Sub DataNavBar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not IsNothing(BindingSourcePrincipal) Then
            HabilitarBotonesEnc(True, False)
            If BindingSourcePrincipal.Count > 0 Then
                toolstriptextPosicionReg.Text = BindingSourcePrincipal.Position + 1 & "/" & _BindingSourcePrincipal.Count
                If _TieneDetalle Then
                    VerificarEstadoRegistro()
                End If
            Else
                toolstripbutModificarRegistro.Enabled = False
                toolstripbutEliminarRegistro.Enabled = False
                toolstripbutAnularDocumento.Enabled = False
                toolstripbutCerrarDocumento.Enabled = False
                toolstripbutImprimir.Enabled = False
                toolstripbutContabilizar.Enabled = False
                toolstripbutComentarios.Enabled = False
                toolstripbutDocumentacion.Enabled = False
            End If
        End If
    End Sub

    Private Sub DataNavBar_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Me.Top = 0
        Me.Left = 0
        Me.Width = Parent.Width - 7
        If UsarBotonPrimerRegistro Then
            toolstripbutPrimerRegistro.Visible = True
        Else
            toolstripbutPrimerRegistro.Visible = False
        End If
        If UsarBotonRegistroAnterior = True Then
            toolstripbutRegistroAnterior.Visible = True
        Else
            toolstripbutRegistroAnterior.Visible = False
        End If
        If UsarTextoPosicionRegistro = True Then
            toolstriptextPosicionReg.Visible = True
        Else
            toolstriptextPosicionReg.Visible = False
        End If
        If UsarBotonSiguienteRegistro = True Then
            toolstripbutSiguienteRegistro.Visible = True
        Else
            toolstripbutSiguienteRegistro.Visible = False
        End If
        If UsarBotonUltimoRegistro = True Then
            toolstripbutUltimoRegistro.Visible = True
        Else
            toolstripbutUltimoRegistro.Visible = False
        End If
        If UsarBotonNuevoRegistro = True Then
            toolstripbutNuevoRegistro.Visible = True
        Else
            toolstripbutNuevoRegistro.Visible = False
        End If
        If UsarBotonGuardarRegistro = True Then
            toolstripbutGuardarRegistro.Visible = True
        Else
            toolstripbutGuardarRegistro.Visible = False
        End If
        If UsarBotonCancelar = True Then
            toolstripbutCancelarGuardar.Visible = True
        Else
            toolstripbutCancelarGuardar.Visible = False
        End If
        If UsarBotonModificarRegistro = True Then
            toolstripbutModificarRegistro.Visible = True
        Else
            toolstripbutModificarRegistro.Visible = False
        End If
        If UsarBotonEliminarRegistro = True Then
            toolstripbutEliminarRegistro.Visible = True
        Else
            toolstripbutEliminarRegistro.Visible = False
        End If
        If UsarBotonAnularRegistro = True Then
            toolstripbutAnularDocumento.Visible = True
        Else
            toolstripbutAnularDocumento.Visible = False
        End If
        If UsarBotonCerrarDocumento = True Then
            toolstripbutCerrarDocumento.Visible = True
        Else
            toolstripbutCerrarDocumento.Visible = False
        End If
        If UsarBotonImprimir = True Then
            toolstripbutImprimir.Visible = True
        Else
            toolstripbutImprimir.Visible = False
        End If
        If UsarBotonContabilizar = True Then
            toolstripbutContabilizar.Visible = True
        Else
            toolstripbutContabilizar.Visible = False
        End If
        If UsarBotonMasOpciones = True Then
            toolstripbutMasOpciones.Visible = True
        Else
            toolstripbutMasOpciones.Visible = False
        End If
        If UsarBotonSalir = True Then
            toolstripbutSalir.Visible = True
        Else
            toolstripbutSalir.Visible = False
        End If
        If UsarBotonComentarios = True Then
            toolstripbutComentarios.Visible = True
        Else
            toolstripbutComentarios.Visible = False
        End If
        If UsarBotonDocumentacion = True Then
            toolstripbutDocumentacion.Visible = True
        Else
            toolstripbutDocumentacion.Visible = False
        End If
        If UsarBuscar = True Then
            toolstripllabelBuscar.Visible = True
            toolstriptextBuscar.Visible = True
            toolstripbutBuscar.Visible = True
            toolstripbutReiniciarDatos.Visible = True
            ToolStripSeparator3.Visible = True
        Else
            toolstripllabelBuscar.Visible = False
            toolstriptextBuscar.Visible = False
            toolstripbutBuscar.Visible = False
            toolstripbutReiniciarDatos.Visible = False
            ToolStripSeparator3.Visible = False
        End If
    End Sub

    Private Sub toolstripbutPrimerRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutPrimerRegistro.Click

        Try
            _BindingSourcePrincipal.MoveFirst()
            toolstriptextPosicionReg.Text = _BindingSourcePrincipal.Position + 1 & "/" & _BindingSourcePrincipal.Count
            'If _TieneDetalle Then
            VerificarEstadoRegistro()
            'End If
        Catch ex As Exception
            Call MsgBox(ex.Message)
        End Try
        RaiseEvent PrimerRegistroClick(Me, e)
    End Sub
    Private Sub HabilitarBotonesEnc(ByVal FaseEdi As Boolean, ByVal FaseDesEdi As Boolean)
        'fases de edición
        toolstripbutPrimerRegistro.Enabled = FaseEdi
        toolstripbutRegistroAnterior.Enabled = FaseEdi
        toolstripbutSiguienteRegistro.Enabled = FaseEdi
        toolstripbutUltimoRegistro.Enabled = FaseEdi
        toolstripbutPrimerRegistro.Enabled = FaseEdi
        toolstripbutNuevoRegistro.Enabled = FaseEdi
        toolstripbutModificarRegistro.Enabled = FaseEdi
        toolstripbutEliminarRegistro.Enabled = FaseEdi
        toolstripbutAnularDocumento.Enabled = FaseEdi
        toolstripbutCerrarDocumento.Enabled = FaseEdi
        toolstripbutContabilizar.Enabled = FaseEdi
        toolstripbutBuscar.Enabled = FaseEdi
        toolstripbutReiniciarDatos.Enabled = FaseEdi
        toolstripbutComentarios.Enabled = FaseEdi
        toolstripbutDocumentacion.Enabled = FaseEdi
        'Fases después de edición
        toolstripbutCancelarGuardar.Enabled = FaseDesEdi
        toolstripbutGuardarRegistro.Enabled = FaseDesEdi
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UsarBotonPrimerRegistro = True
        UsarBotonRegistroAnterior = True
        UsarTextoPosicionRegistro = True
        UsarBotonSiguienteRegistro = True
        UsarTextoPosicionRegistro = True
        UsarBotonSiguienteRegistro = True
        UsarBotonUltimoRegistro = True
        UsarBotonNuevoRegistro = True
        UsarBotonGuardarRegistro = True
        UsarBotonCancelar = True
        UsarBotonModificarRegistro = True
        UsarBotonEliminarRegistro = True
        UsarBotonAnularRegistro = False
        UsarBotonCerrarDocumento = False
        UsarBotonImprimir = False
        UsarBotonContabilizar = False
        UsarBotonComentarios = False
        UsarBotonDocumentacion = False
        UsarBotonMasOpciones = False
        UsarBotonSalir = True
        UsarBuscar = True
        ValidacionCorrecta = False
        TieneDetalle = False
        ModalidadSoloLectura = False
    End Sub

    Private Sub toolstripbutRegistroAnterior_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles toolstripbutRegistroAnterior.Click
        Try
            If _BindingSourcePrincipal.Position > 0 Then
                _BindingSourcePrincipal.MovePrevious()
                toolstriptextPosicionReg.Text = _BindingSourcePrincipal.Position + 1 & "/" & _BindingSourcePrincipal.Count
                'If _TieneDetalle Then
                VerificarEstadoRegistro()
                'End If
            End If
        Catch ex As Exception
            Call MsgBox(ex.Message)
        End Try
        RaiseEvent RegistroAnteriorClick(Me, e)
    End Sub

    Private Sub toolstripbutSiguienteRegistro_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles toolstripbutSiguienteRegistro.Click
        Try
            If _BindingSourcePrincipal.Position < _BindingSourcePrincipal.Count Then
                _BindingSourcePrincipal.MoveNext()
                toolstriptextPosicionReg.Text = _BindingSourcePrincipal.Position + 1 & "/" & _BindingSourcePrincipal.Count
                'If _TieneDetalle Then
                VerificarEstadoRegistro()
                'End If
            End If
        Catch ex As Exception
            Call MsgBox(ex.Message)
        End Try
        RaiseEvent SiguienteRegistroClick(Me, e)
    End Sub

    Private Sub toolstripbutUltimoRegistro_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles toolstripbutUltimoRegistro.Click
        Try
            _BindingSourcePrincipal.MoveLast()
            toolstriptextPosicionReg.Text = _BindingSourcePrincipal.Position + 1 & "/" & _BindingSourcePrincipal.Count
            'If _TieneDetalle Then
            VerificarEstadoRegistro()
            'End If
        Catch ex As Exception
            Call MsgBox(ex.Message)
        End Try
        RaiseEvent UltimoRegistroClick(Me, e)

    End Sub

    Private Sub toolstripbutNuevoRegistro_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles toolstripbutNuevoRegistro.Click
        Dim mCancelar As Boolean
        mCancelar = False
        Try
            If EjecutarAntesNuevo Then
                RaiseEvent NuevoRegistroClick(Me, e, mCancelar)
            End If

            If Not mCancelar Then
                Try
                    HabilitarBotonesEnc(False, True)
                    NuevoRegistro = True
                    Editando = True
                    BloquearControles(Me.Parent, False)
                    toolstriptextPosicionReg.Text = ""
                    BindingSourcePrincipal.AddNew()
                    If _TieneDetalle Then
                        BarraDeEstado.Items(0).Visible = False
                        BarraDeEstado.Items(1).Visible = False
                        BarraDeEstado.Items(2).Visible = False
                        BarraDeEstado.Items(3).Visible = False
                        _UltimaLinDet = 0
                    End If
                    InicializarInfo(Me.Parent)
                Catch ex As Exception
                    Call MsgBox(ex.Message)
                End Try
            End If
            If Not EjecutarAntesNuevo Then
                RaiseEvent NuevoRegistroClick(Me, e, mCancelar)
            End If
        Catch ex As Exception
            Call MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BloquearControles(ByVal mParent As Control, ByVal Bloquear As Boolean)
        Dim mControl As Windows.Forms.Control
        Dim mTabPage As Windows.Forms.TabPage
        Dim mSplitCont As Windows.Forms.SplitContainer
        Dim mTab As Windows.Forms.TabControl
        Dim mTextBox As Windows.Forms.TextBox
        Dim mRichTextBox As Windows.Forms.RichTextBox
        Dim mButton As Windows.Forms.Button
        Dim mColiseumBotonBuscar As RSIContab.BotonBuscar
        Dim mC1TextBox As C1.Win.C1Input.C1TextBox
        Dim mC1NumericEdit As C1.Win.C1Input.C1NumericEdit
        Dim mC1DateEdit As C1.Win.C1Input.C1DateEdit
        Dim mC1Combo As C1.Win.C1List.C1Combo
        Dim mc1dbgrd As C1.Win.C1TrueDBGrid.C1TrueDBGrid
        'Dim strA As String

        For Each mControl In mParent.Controls

            Select Case mControl.GetType.FullName
                Case "System.Windows.Forms.GroupBox"
                    'If mControl.Name = "groupboxComi" Then
                    'strA = "A"
                    'End If
                    BloquearControles(mControl, Bloquear)   'Llamada recursiva si el control es un contenedor
                Case "System.Windows.Forms.Panel"
                    BloquearControles(mControl, Bloquear)   'Llamada recursiva si el control es un contenedor
                Case "System.Windows.Forms.TabControl"
                    mTab = mControl
                    For Each mTabPage In mTab.TabPages
                        BloquearControles(mTabPage, Bloquear)   'Llamada recursiva si el control es un contenedor
                    Next
                Case "System.Windows.Forms.SplitContainer"
                    mSplitCont = mControl
                    BloquearControles(mSplitCont.Panel1, Bloquear)   'Llamada recursiva si el control es un contenedor
                    BloquearControles(mSplitCont.Panel2, Bloquear)
                Case "System.Windows.Forms.TextBox"
                    mTextBox = mControl
                    mTextBox.ReadOnly = Bloquear
                Case "System.Windows.Forms.RichTextBox"
                    mRichTextBox = mControl
                    mRichTextBox.ReadOnly = Bloquear
                Case "C1.Win.C1Input.C1TextBox"
                    mC1TextBox = mControl
                    If mC1TextBox.Tag <> "" Then
                        If (InStr(mC1TextBox.Tag, "C") > 0 And _NuevoRegistro) Or (InStr(mC1TextBox.Tag, "M") > 0 And _ModificarRegistro) Then
                            mC1TextBox.ReadOnly = Bloquear
                        End If
                    End If
                Case "C1.Win.C1Input.C1NumericEdit"
                    mC1NumericEdit = mControl
                    If mC1NumericEdit.Tag <> "" Then
                        If (InStr(mC1NumericEdit.Tag, "C") > 0 And _NuevoRegistro) Or (InStr(mC1NumericEdit.Tag, "M") > 0 And _ModificarRegistro) Then
                            mC1NumericEdit.ReadOnly = Bloquear
                        End If
                    End If
                Case "C1.Win.C1Input.C1DateEdit"
                    mC1DateEdit = mControl
                    If mC1DateEdit.Tag <> "" Then
                        If (InStr(mC1DateEdit.Tag, "C") > 0 And _NuevoRegistro) Or (InStr(mC1DateEdit.Tag, "M") > 0 And _ModificarRegistro) Then
                            mC1DateEdit.ReadOnly = Bloquear
                        End If
                    End If
                Case "C1.Win.C1List.C1Combo"
                    mC1Combo = mControl
                    If mC1Combo.Tag <> "" Then
                        If (InStr(mC1Combo.Tag, "C") > 0 And _NuevoRegistro) Or (InStr(mC1Combo.Tag, "M") > 0 And _ModificarRegistro) Then
                            mC1Combo.ReadOnly = Bloquear
                        End If
                    End If
                Case "System.Windows.Forms.Button"
                        mButton = mControl
                        If mButton.Tag = "HABILITARNOEDIT" Then
                            mButton.Enabled = Bloquear
                        Else
                            mButton.Enabled = Not Bloquear
                        End If
                Case "Coliseum.BotonBuscar"
                    mColiseumBotonBuscar = mControl
                    If mColiseumBotonBuscar.Tag = "HABILITARNOEDIT" Then
                        mColiseumBotonBuscar.Enabled = Bloquear
                    Else
                        mColiseumBotonBuscar.Enabled = Not Bloquear
                    End If
                Case "RSIContab.BotonBuscar"
                    mColiseumBotonBuscar = mControl
                    If mColiseumBotonBuscar.Tag = "HABILITARNOEDIT" Then
                        mColiseumBotonBuscar.Enabled = Bloquear
                    Else
                        mColiseumBotonBuscar.Enabled = Not Bloquear
                    End If
            End Select
            If mControl.GetType.FullName = "System.Windows.Forms.ComboBox" Or mControl.GetType.FullName = "System.Windows.Forms.ListBox" _
                Or mControl.GetType.FullName = "System.Windows.Forms.CheckBox" Or mControl.GetType.FullName = "System.Windows.Forms.RadioButton" _
                Or mControl.GetType.FullName = "C1.Win.C1TrueDBGrid.C1TrueDBDropDown" Or mControl.GetType.FullName = "System.Windows.Forms.NumericUpDown" Then
                mControl.Enabled = IIf(Bloquear = False, True, False)
            End If
            If mControl.GetType.FullName = "C1.Win.C1TrueDBGrid.C1TrueDBGrid" Then
                mc1dbgrd = mControl
                mc1dbgrd.AllowUpdate = IIf(Bloquear = False, False, True)
            End If
        Next

    End Sub

    Private Sub toolstripbutEliminarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutEliminarRegistro.Click
        If EjecutarAntesEliminar Then
            RaiseEvent EliminarRegistroClick(Me, e)
        End If
        If Not EjecutarAntesEliminar Then
            RaiseEvent EliminarRegistroClick(Me, e)
        End If
    End Sub

    Private Sub toolstripbutSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutSalir.Click
        If EjecutarAntesSalir Then
            RaiseEvent SalirClick(Me, e)
        End If
        If Not EjecutarAntesNuevo Then
            RaiseEvent SalirClick(Me, e)
        End If
    End Sub

    Private Sub toolstripbutAnularDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutAnularDocumento.Click
        RaiseEvent AnularRegistroClick(Me, e)
    End Sub

    Private Sub toolstripbutCerrarDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutCerrarDocumento.Click
        RaiseEvent CerrarDocumentoClick(Me, e)
    End Sub

    Private Sub toolstripbutImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutImprimir.Click
        RaiseEvent ImprimirClick(Me, e)
    End Sub

    Private Sub toolstripbutContabilizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutContabilizar.Click
        RaiseEvent ContabilizarClick(Me, e)
    End Sub

    Private Sub toolstripbutModificarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutModificarRegistro.Click
        Dim mCancelar As Boolean
        mCancelar = False

        If EjecutarAntesModificar Then
            RaiseEvent ModificarRegistroClick(Me, e, mCancelar)
        End If
        If Not mCancelar Then
            Try
                HabilitarBotonesEnc(False, True)
                ModificarRegistro = True
                Editando = True
                BloquearControles(Me.Parent, False)
            Catch ex As Exception
                Call MsgBox(ex.Message)
            End Try
        End If
        If Not EjecutarAntesModificar Then
            RaiseEvent ModificarRegistroClick(Me, e, mCancelar)
        End If
    End Sub

    Private Sub toolstripbutCancelarGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutCancelarGuardar.Click

        BindingSourcePrincipal.CancelEdit()
        BloquearControles(Me.Parent, True)
        HabilitarBotonesEnc(True, False)
        NuevoRegistro = False
        ModificarRegistro = False
        If _BindingSourcePrincipal.Count > 0 Then
            _BindingSourcePrincipal.MoveFirst()
            toolstriptextPosicionReg.Text = _BindingSourcePrincipal.Position + 1 & "/" & _BindingSourcePrincipal.Count
            If _TieneDetalle Then
                VerificarEstadoRegistro()
            End If
        Else
            toolstriptextPosicionReg.Text = ""
        End If
    End Sub

    Private Sub toolstripbutGuardarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutGuardarRegistro.Click
        Dim mCancelar As Boolean
        mCancelar = False
        If EjecutarAntesGrabar Then
            RaiseEvent GuardarRegistroClick(Me, e, mCancelar)
        End If

        If mCancelar = False Then
            If _ValidacionCorrecta Then
                BloquearControles(Me.Parent, True)
                HabilitarBotonesEnc(True, False)
                ModificarRegistro = False
                NuevoRegistro = False
                toolstriptextPosicionReg.Text = _BindingSourcePrincipal.Position + 1 & "/" & _BindingSourcePrincipal.Count
                If _TieneDetalle Then
                    VerificarEstadoRegistro()
                End If
            End If
        End If
        If Not EjecutarAntesGrabar Then
            RaiseEvent GuardarRegistroClick(Me, e, mCancelar)
        End If
    End Sub
    Private Sub toolstripbutBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutBuscar.Click
        RaiseEvent BuscarRegistroClick(Me, e)
        If _BindingSourcePrincipal.Count > 0 Then
            _BindingSourcePrincipal.MoveFirst()
            toolstriptextPosicionReg.Text = _BindingSourcePrincipal.Position + 1 & "/" & _BindingSourcePrincipal.Count
        Else
            toolstriptextPosicionReg.Text = ""
        End If
    End Sub

    Private Sub toolstripbutReiniciarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutReiniciarDatos.Click
        toolstriptextBuscar.Text = ""
        'RaiseEvent BuscarRegistroClick(Me, e)
        RaiseEvent ReiniciarDatosClick(Me, e)
        toolstriptextPosicionReg.Text = _BindingSourcePrincipal.Position + 1 & "/" & _BindingSourcePrincipal.Count
    End Sub

    Public Sub InicializarInfo(ByVal mParent As Control)
        Dim mControl As Windows.Forms.Control
        Dim mTabPage As Windows.Forms.TabPage
        Dim mSplitCont As Windows.Forms.SplitContainer
        Dim mTab As Windows.Forms.TabControl
        Dim mTextBox As Windows.Forms.TextBox
        Dim mRichTextBox As Windows.Forms.RichTextBox
        Dim mComboBox As Windows.Forms.ComboBox
        Dim mC1TextBox As C1.Win.C1Input.C1TextBox
        Dim mC1NumericEdit As C1.Win.C1Input.C1NumericEdit
        Dim mC1DateEdit As C1.Win.C1Input.C1DateEdit
        Dim mC1Combo As C1.Win.C1List.C1Combo
        Dim mLabel As Windows.Forms.Label
        Dim mPictureBox As Windows.Forms.PictureBox
        'Dim strBindings As String
        Dim dsData As DataSet

        dsData = BindingSourcePrincipal.DataSource
        For Each mControl In mParent.Controls

            Select Case mControl.GetType.FullName
                Case "System.Windows.Forms.GroupBox"
                    InicializarInfo(mControl)   'Llamada recursiva si el control es un contenedor
                Case "System.Windows.Forms.Panel"
                    InicializarInfo(mControl)   'Llamada recursiva si el control es un contenedor
                Case "System.Windows.Forms.TabControl"
                    mTab = mControl
                    For Each mTabPage In mTab.TabPages
                        InicializarInfo(mTabPage)   'Llamada recursiva si el control es un contenedor
                    Next
                Case "System.Windows.Forms.SplitContainer"
                    mSplitCont = mControl
                    InicializarInfo(mSplitCont.Panel1)   'Llamada recursiva si el control es un contenedor
                    InicializarInfo(mSplitCont.Panel2)
            End Select

            If mControl.GetType.FullName = "System.Windows.Forms.ComboBox" Or mControl.GetType.FullName = "C1.Win.C1List.C1Combo" _
                Or mControl.GetType.FullName = "System.Windows.Forms.TextBox" Or mControl.GetType.FullName = "System.Windows.Forms.RichTextBox" _
                Or mControl.GetType.FullName = "C1.Win.C1Input.C1TextBox" Or mControl.GetType.FullName = "C1.Win.C1Input.C1NumericEdit" _
                Or mControl.GetType.FullName = "C1.Win.C1Input.C1DateEdit" Or mControl.GetType.FullName = "System.Windows.Forms.Label" _
                Or mControl.GetType.FullName = "System.Windows.Forms.PictureBox" Then
                Select Case mControl.GetType.FullName
                    Case "System.Windows.Forms.TextBox"
                        mTextBox = mControl
                        'strBindings = mTextBox.
                    Case "System.Windows.Forms.RichTextBox"
                        mRichTextBox = mControl
                    Case "C1.Win.C1Input.C1TextBox"
                        mC1TextBox = mControl
                        If mC1TextBox.Tag <> "" Then
                            mC1TextBox.MaxLength = dsData.Tables(BindingSourcePrincipal.DataMember).Columns(mC1TextBox.DataField).MaxLength
                        End If
                    Case "C1.Win.C1Input.C1NumericEdit"
                        mC1NumericEdit = mControl
                        'If mC1NumericEdit.ReadOnly = False Then
                        'mC1NumericEdit.Text = "0"
                        'End If
                    Case "C1.Win.C1Input.C1DateEdit"
                        mC1DateEdit = mControl
                        'mC1DateEdit.Text = Date.Now
                    Case "System.Windows.Forms.ComboBox"
                        mComboBox = mControl
                    Case "C1.Win.C1List.C1Combo"
                        mC1Combo = mControl
                        If mC1Combo.DataMode = C1.Win.C1List.DataModeEnum.Normal Then
                            mC1Combo.MaxLength = dsData.Tables(BindingSourcePrincipal.DataMember).Columns(mC1Combo.ValueMember).MaxLength
                        End If
                    Case "System.Windows.Forms.Label"
                        mLabel = mControl
                        If Microsoft.VisualBasic.Left(mLabel.Name, 7) = "lblDesc" Then
                            mLabel.Text = ""
                        End If
                    Case "System.Windows.Forms.PictureBox"
                        mPictureBox = mControl
                        mPictureBox.ImageLocation = ""
                End Select
            End If
        Next

        '*** Verificar nulos ***

        'For i = 0 To dsData.Tables(BindingSourcePrincipal.DataMember).Columns.Count - 1
        ' dsData.Tables(BindingSourcePrincipal.DataMember).Columns(1).AllowDBNull
        'Next

    End Sub

    Public Sub ValidarInfo(ByVal mParent As Control)
        Dim mControl As Windows.Forms.Control
        Dim mTabPage As Windows.Forms.TabPage
        Dim mSplitCont As Windows.Forms.SplitContainer
        Dim mTab As Windows.Forms.TabControl
        Dim mTextBox As Windows.Forms.TextBox
        Dim mRichTextBox As Windows.Forms.RichTextBox
        Dim mComboBox As Windows.Forms.ComboBox
        Dim mC1TextBox As C1.Win.C1Input.C1TextBox
        Dim mC1NumericEdit As C1.Win.C1Input.C1NumericEdit
        Dim mC1DateEdit As C1.Win.C1Input.C1DateEdit
        Dim mC1Combo As C1.Win.C1List.C1Combo
        'Dim dsData As DataSet
        'Dim i As Int16

        '*** Verificar información introducida en controles***
        For Each mControl In mParent.Controls

            Select Case mControl.GetType.FullName
                Case "System.Windows.Forms.GroupBox"
                    ValidarInfo(mControl)   'Llamada recursiva si el control es un contenedor
                Case "System.Windows.Forms.Panel"
                    ValidarInfo(mControl)   'Llamada recursiva si el control es un contenedor
                Case "System.Windows.Forms.TabControl"
                    mTab = mControl
                    For Each mTabPage In mTab.TabPages
                        ValidarInfo(mTabPage)   'Llamada recursiva si el control es un contenedor
                    Next
                Case "System.Windows.Forms.SplitContainer"
                    mSplitCont = mControl
                    ValidarInfo(mSplitCont.Panel1)   'Llamada recursiva si el control es un contenedor
                    ValidarInfo(mSplitCont.Panel2)
            End Select

            If mControl.GetType.FullName = "System.Windows.Forms.ComboBox" Or mControl.GetType.FullName = "C1.Win.C1List.C1Combo" _
                Or mControl.GetType.FullName = "System.Windows.Forms.TextBox" Or mControl.GetType.FullName = "System.Windows.Forms.RichTextBox" _
                Or mControl.GetType.FullName = "C1.Win.C1Input.C1TextBox" Or mControl.GetType.FullName = "C1.Win.C1Input.C1NumericEdit" _
                Or mControl.GetType.FullName = "C1.Win.C1Input.C1DateEdit" Then
                Select Case mControl.GetType.FullName
                    Case "System.Windows.Forms.TextBox"
                        mTextBox = mControl
                        If InStr(mTextBox.Tag, "O") > 0 Then
                            If String.IsNullOrEmpty(mTextBox.Text) Then
                                ResultadoValidacion = ResultadoValidacion & "Debe ingresar el dato: " & mTextBox.DataBindings.ToString & vbCrLf
                                ValidacionCorrecta = False
                            End If
                        End If
                    Case "System.Windows.Forms.RichTextBox"
                        mRichTextBox = mControl
                        If InStr(mRichTextBox.Tag, "O") > 0 Then
                            If String.IsNullOrEmpty(mRichTextBox.Text) Then
                                ResultadoValidacion = ResultadoValidacion & "Debe ingresar el dato: " & mRichTextBox.DataBindings.ToString & vbCrLf
                                ValidacionCorrecta = False
                            End If
                        End If
                    Case "C1.Win.C1Input.C1TextBox"
                        mC1TextBox = mControl
                        If InStr(mC1TextBox.Tag, "O") > 0 Then
                            If String.IsNullOrEmpty(mC1TextBox.Text) Then
                                ResultadoValidacion = ResultadoValidacion & "Debe ingresar el dato: " & mC1TextBox.DataField & vbCrLf
                                'mC1TextBox.BackColor = Color.FromName("info")
                                ValidacionCorrecta = False
                            End If
                        End If
                    Case "C1.Win.C1Input.C1NumericEdit"
                        mC1NumericEdit = mControl
                        If String.IsNullOrEmpty(Str(mC1NumericEdit.Value)) Then
                            mC1NumericEdit.Value = 0
                        End If

                        If InStr(mC1NumericEdit.Tag, "O") > 0 Then
                            If InStr(mC1NumericEdit.Tag, ">") > 0 And Val(mC1NumericEdit.Text) = 0 Then
                                ResultadoValidacion = ResultadoValidacion & "Debe ingresar un valor distinto de cero en: " & mC1NumericEdit.DataField & vbCrLf
                                'mC1NumericEdit.BackColor = Color.FromName("info")
                                ValidacionCorrecta = False
                            End If
                        End If
                    Case "C1.Win.C1Input.C1DateEdit"
                        mC1DateEdit = mControl
                    Case "System.Windows.Forms.ComboBox"
                        mComboBox = mControl
                    Case "C1.Win.C1List.C1Combo"
                        mC1Combo = mControl
                        If InStr(mC1Combo.Tag, "O") > 0 Then
                            If String.IsNullOrEmpty(mC1Combo.Text) Then
                                ResultadoValidacion = ResultadoValidacion & "Debe ingresar el dato: " & mC1Combo.Columns(0).DataField & vbCrLf
                                ValidacionCorrecta = False
                            End If
                        End If
                End Select
            End If
        Next

        '*** Verificar nulos ***
        'dsData = BindingSourcePrincipal.DataSource
        'For i = 0 To dsData.Tables(BindingSourcePrincipal.DataMember).Columns.Count - 1
        ' dsData.Tables(BindingSourcePrincipal.DataMember).Columns(1).AllowDBNull
        'Next

    End Sub
    Private Sub VerificarEstadoRegistro()
        Dim dsData As DataSet
        Dim i As Int16

        If _BindingSourcePrincipal.Count > 0 Then
            dsData = BindingSourcePrincipal.DataSource

            If _UsarBotonCerrarDocumento Then
                If dsData.Tables(BindingSourcePrincipal.DataMember).Rows(BindingSourcePrincipal.Position).Item("Cerrado") Then
                    BarraDeEstado.Items(0).Visible = True
                    If Not _ModalidadSoloLectura Then   'Mes del documento ya cerrado. Solo se permite lectura
                        If _TieneDetalle Then
                            HabilitarDetalle(False)
                        End If
                        toolstripbutModificarRegistro.Enabled = False
                        toolstripbutEliminarRegistro.Enabled = False
                        toolstripbutAnularDocumento.Enabled = True
                        toolstripbutCerrarDocumento.Enabled = False
                        toolstripbutContabilizar.Enabled = True
                        toolstripbutModificarRegistro.Enabled = False
                    End If
                    If TieneDetalle Then
                        If _MostrarListaInvPermanente Then
                            dbgrdDetalle.Splits(0).DisplayColumns("Item").Button = False
                        End If
                    End If
                Else
                    BarraDeEstado.Items(0).Visible = False
                    If Not _ModalidadSoloLectura Then   'Mes del documento ya cerrado. Solo se permite lectura
                        If _TieneDetalle Then
                            HabilitarDetalle(True)
                        End If
                        toolstripbutModificarRegistro.Enabled = True
                        toolstripbutEliminarRegistro.Enabled = True
                        toolstripbutAnularDocumento.Enabled = True
                        toolstripbutCerrarDocumento.Enabled = True
                        toolstripbutContabilizar.Enabled = False
                        toolstripbutModificarRegistro.Enabled = True
                    End If
                    If TieneDetalle Then
                        If _MostrarListaInvPermanente Then
                            dbgrdDetalle.Splits(0).DisplayColumns("Item").Button = True
                        End If
                    End If
                    End If
            End If
            If Not _ModalidadSoloLectura Then   'Mes del documento ya cerrado. Solo se permite lectura
                If _UsarBotonImprimir Then
                    If dsData.Tables(BindingSourcePrincipal.DataMember).Rows(BindingSourcePrincipal.Position).Item("Impreso") Then
                        BarraDeEstado.Items(1).Visible = True
                    Else
                        BarraDeEstado.Items(1).Visible = False
                    End If
                    toolstripbutImprimir.Enabled = True
                Else
                    BarraDeEstado.Items(1).Visible = False
                End If

                If _UsarBotonContabilizar Then
                    If dsData.Tables(BindingSourcePrincipal.DataMember).Rows(BindingSourcePrincipal.Position).Item("Contabilizado") Then
                        BarraDeEstado.Items(2).Visible = True
                        toolstripbutContabilizar.Enabled = False
                    Else
                        BarraDeEstado.Items(2).Visible = False
                        toolstripbutContabilizar.Enabled = True
                    End If
                Else
                    BarraDeEstado.Items(2).Visible = False
                End If

                If _UsarBotonAnularRegistro Then
                    If dsData.Tables(BindingSourcePrincipal.DataMember).Rows(BindingSourcePrincipal.Position).Item("Anulado") Then
                        BarraDeEstado.Items(3).Visible = True
                        toolstripbutAnularDocumento.Enabled = False
                    Else
                        BarraDeEstado.Items(3).Visible = False
                        toolstripbutAnularDocumento.Enabled = True
                    End If
                Else
                    BarraDeEstado.Items(3).Visible = False
                End If
                If _UsarBotonComentarios Then
                    toolstripbutComentarios.Enabled = True
                End If
                If _UsarBotonDocumentacion Then
                    toolstripbutDocumentacion.Enabled = True
                End If
            End If
        End If
    End Sub
    Public Sub RefrescarInfo()
        Try
            'If _TieneDetalle Then
            VerificarEstadoRegistro()
            'End If
        Catch ex As Exception
            Call MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub HabilitarDetalle(ByVal Habilitar As Boolean)
        dbgrdDetalle.AllowUpdate = Habilitar
        dbgrdDetalle.AllowAddNew = Habilitar
        dbgrdDetalle.AllowDelete = Habilitar
    End Sub
    Public Sub Reinicializar()
        If Not IsNothing(BindingSourcePrincipal) Then
            HabilitarBotonesEnc(True, False)
            If BindingSourcePrincipal.Count > 0 Then
                toolstriptextPosicionReg.Text = BindingSourcePrincipal.Position + 1 & "/" & _BindingSourcePrincipal.Count
                If _TieneDetalle Then
                    VerificarEstadoRegistro()
                End If
            Else
                toolstripbutModificarRegistro.Enabled = False
                toolstripbutEliminarRegistro.Enabled = False
                toolstripbutAnularDocumento.Enabled = False
                toolstripbutCerrarDocumento.Enabled = False
                toolstripbutImprimir.Enabled = False
                toolstripbutContabilizar.Enabled = False
                toolstripbutComentarios.Enabled = False
                toolstripbutDocumentacion.Enabled = False
            End If
        End If
    End Sub

    Private Sub toolstripbutMasOpciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripbutMasOpciones.Click
        RaiseEvent MasOpcionesClick(Me, e)
    End Sub

    Private Sub toolstripbutComentarios_Click(sender As System.Object, e As System.EventArgs) Handles toolstripbutComentarios.Click
        RaiseEvent ComentariosClick(Me, e)
    End Sub

    Private Sub toolstripbutDocumentacion_Click(sender As System.Object, e As System.EventArgs) Handles toolstripbutDocumentacion.Click
        RaiseEvent DocumentacionClick(Me, e)
    End Sub
End Class
