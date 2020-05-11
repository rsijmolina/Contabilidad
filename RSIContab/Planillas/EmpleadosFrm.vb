Public Class EmpleadosFrm
    Private _EmpleadosRetirados As Boolean
    Dim lstEmplsFrm As New ListaEmpleadosFom
    Dim mBuscando As Boolean
    Dim PlCls As New PLClassLib.PlClass
    Public Property EmpleadosRetirados() As Boolean
        Get
            _EmpleadosRetirados = EmpleadosRetirados
        End Get
        Set(ByVal value As Boolean)
            _EmpleadosRetirados = value
        End Set
    End Property

    Private Sub EmpleadosFrm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.PageDown
                DataNavBarPrincipal.toolstripbutSiguienteRegistro.PerformClick()
            Case Keys.PageUp
                DataNavBarPrincipal.toolstripbutRegistroAnterior.PerformClick()
            Case Keys.Home
                DataNavBarPrincipal.toolstripbutPrimerRegistro.PerformClick()
            Case Keys.End
                DataNavBarPrincipal.toolstripbutUltimoRegistro.PerformClick()
        End Select

        If e.Control = True Then
            Select Case e.KeyCode
                Case Keys.N
                    DataNavBarPrincipal.toolstripbutNuevoRegistro.PerformClick()
                Case Keys.G
                    DataNavBarPrincipal.toolstripbutGuardarRegistro.PerformClick()
                Case Keys.Z
                    DataNavBarPrincipal.toolstripbutCancelarGuardar.PerformClick()
                Case Keys.M
                    DataNavBarPrincipal.toolstripbutModificarRegistro.PerformClick()
                Case Keys.E
                    DataNavBarPrincipal.toolstripbutEliminarRegistro.PerformClick()
                Case Keys.A
                    DataNavBarPrincipal.toolstripbutAnularDocumento.PerformClick()
                Case Keys.F
                    DataNavBarPrincipal.toolstripbutCerrarDocumento.PerformClick()
                Case Keys.T
                    DataNavBarPrincipal.toolstripbutContabilizar.PerformClick()
                Case Keys.B
                    DataNavBarPrincipal.toolstripbutBuscar.PerformClick()
                Case Keys.R
                    DataNavBarPrincipal.toolstripbutReiniciarDatos.PerformClick()
                Case Keys.S
                    DataNavBarPrincipal.toolstripbutSalir.PerformClick()
            End Select
        End If
    End Sub
    Private Sub EmpleadosFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PLEmpleadosDataSet.PLBancos' Puede moverla o quitarla según sea necesario.
        Me.PLBancosTableAdapter.Fill(Me.PLEmpleadosDataSet.PLBancos)
        'TODO: esta línea de código carga datos en la tabla 'PLEmpleadosDataSet.PLProfesiones' Puede moverla o quitarla según sea necesario.
        Me.PLProfesionesTableAdapter.Fill(Me.PLEmpleadosDataSet.PLProfesiones)
        'TODO: esta línea de código carga datos en la tabla 'PLEmpleadosDataSet.PLTiposEmpleados' Puede moverla o quitarla según sea necesario.
        Me.PLTiposEmpleadosTableAdapter.Fill(Me.PLEmpleadosDataSet.PLTiposEmpleados)
        'TODO: esta línea de código carga datos en la tabla 'PLEmpleadosDataSet.PLSecciones' Puede moverla o quitarla según sea necesario.
        Me.PLSeccionesTableAdapter.Fill(Me.PLEmpleadosDataSet.PLSecciones)
        'TODO: esta línea de código carga datos en la tabla 'PLEmpleadosDataSet.PLDepartamentos' Puede moverla o quitarla según sea necesario.
        Me.PLDepartamentosTableAdapter.Fill(Me.PLEmpleadosDataSet.PLDepartamentos)
        'TODO: esta línea de código carga datos en la tabla 'PLEmpleadosDataSet.PLSedes' Puede moverla o quitarla según sea necesario.
        Me.PLSedesTableAdapter.Fill(Me.PLEmpleadosDataSet.PLSedes)
        'TODO: esta línea de código carga datos en la tabla 'PLEmpleadosDataSet.PLPuestos' Puede moverla o quitarla según sea necesario.
        Me.PLPuestosTableAdapter.Fill(Me.PLEmpleadosDataSet.PLPuestos)
        Me.PLEmpleadosTableAdapter.Fill(Me.PLEmpleadosDataSet.PLEmpleados, _EmpleadosRetirados)
        PlCls.DBconStr = strcnCAD
        Me.MdiParent = MDIPrincipal
        Me.Top = 10
        Me.Left = 10

        DataNavBarPrincipal.toolstriptextBuscar.ToolTipText = "Buscar por Código de Empleado"

        cmbTipoSalario.Items.Add("Normal")
        cmbTipoSalario.Items.Add("Medio Tiempo")
        cmbTipoSalario.Items.Add("Por Comision")
        cmbTipoSalario.Items.Add("Por Hora")
        cmbTipoSalario.Items.Add("Por Obra")
        cmbTipoSalario.Text = "Normal"
        btnBuscarEmpleado.Enabled = True

        If _EmpleadosRetirados Then
            DataNavBarPrincipal.UsarBotonNuevoRegistro = False
            DataNavBarPrincipal.UsarBotonModificarRegistro = False
            DataNavBarPrincipal.UsarBotonEliminarRegistro = False
        End If
        If My.Settings.RSIEmpresaInstalada = "ZOE" Then
            chkEsDocente.Visible = False
            chkEsMedico.Top = 14
            chkEsMedico.Left = 7
            chkEsMedico.Visible = True
        End If
        mBuscando = False
    End Sub
    Private Sub DataNavBarPrincipal_BuscarRegistroClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.BuscarRegistroClick
        mBuscando = True
        Me.PLEmpleadosTableAdapter.FillByCodigoEmpleado(Me.PLEmpleadosDataSet.PLEmpleados, DataNavBarPrincipal.toolstriptextBuscar.Text)
        mBuscando = False
    End Sub

    Private Sub PrincipalBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrincipalBindingSource.PositionChanged
        Dim mData As DataRowView

        If Not DataNavBarPrincipal.NuevoRegistro And Not mBuscando Then
            mData = PrincipalBindingSource.Current
            If mData("Sexo") = "M" Then
                radiobutMasculino.Checked = True
            Else
                radiobutFemenino.Checked = True
            End If

            Select Case mData("EstadoCivil")
                Case "S"
                    radiobutSoltero.Checked = True
                Case "C"
                    radiobutCasado.Checked = True
                Case "V"
                    radiobutViudo.Checked = True
                Case "U"
                    radiobutUnionLibre.Checked = True
            End Select

            Select Case mData("NivelAcademico")
                Case 1
                    radiobutPrimaria.Checked = True
                Case 2
                    radiobutMedia.Checked = True
                Case 3
                    radiobutTecnico.Checked = True
                Case 4
                    radiobutSuperior.Checked = True
            End Select
        End If
    End Sub

    Private Sub btnBuscarEmpleado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscarEmpleado.Click
        If Not DataNavBarPrincipal.ModificarRegistro And Not DataNavBarPrincipal.NuevoRegistro Then
            If _EmpleadosRetirados Then
                lstEmplsFrm.EmpleadosRetirados = True
            Else
                lstEmplsFrm.EmpleadosRetirados = False
            End If
            'lstEmplsFrm.CargarDatos()
            lstEmplsFrm.ShowDialog()
            If lstEmplsFrm.DialogResult = Windows.Forms.DialogResult.OK Then
                If Not DataNavBarPrincipal.NuevoRegistro Then
                    DataNavBarPrincipal.toolstriptextBuscar.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Empleado").Value
                    mBuscando = True
                    DataNavBarPrincipal_BuscarRegistroClick(Me, e)
                    DataNavBarPrincipal.toolstriptextPosicionReg.Text = PrincipalBindingSource.Position + 1 & "/" & PrincipalBindingSource.Count
                    mBuscando = False
                Else
                    c1txtCodigoEmpleado.Text = lstEmplsFrm.c1dbgrdListaEmpleados.Columns("Empleado").Value
                End If
            End If
        End If

    End Sub

    Private Sub DataNavBarPrincipal_GuardarRegistroClick(ByVal sender As Object, ByVal e As System.EventArgs, ByRef Cancelar As Boolean) Handles DataNavBarPrincipal.GuardarRegistroClick
        Dim mData As DataRowView
        Dim plCLs As New PLClassLib.PlClass

        mData = PrincipalBindingSource.Current
        If radiobutMasculino.Checked Then
            mData("Sexo") = "M"
        Else
            mData("Sexo") = "F"
        End If
        If radiobutSoltero.Checked Then
            mData("EstadoCivil") = "S"
        ElseIf radiobutCasado.Checked Then
            mData("EstadoCivil") = "C"
        ElseIf radiobutViudo.Checked Then
            mData("EstadoCivil") = "V"
        ElseIf radiobutUnionLibre.Checked Then
            mData("EstadoCivil") = "U"
        End If

        If radiobutPrimaria.Checked Then
            mData("NivelAcademico") = 1
        ElseIf radiobutMedia.Checked Then
            mData("NivelAcademico") = 2
        ElseIf radiobutTecnico.Checked Then
            mData("NivelAcademico") = 3
        ElseIf radiobutSuperior.Checked Then
            mData("NivelAcademico") = 4
        End If

        If DataNavBarPrincipal.ModificarRegistro Then
            plCLs.DBconStr = strcnCAD
            'If mData("SalarioMensual") <> c1numSueldoMensual.Value Then 'Cambio de salario

            'End If
            If mData("RetiradoDeEmpresa") <> chkRetiradoDeEmpresa.Checked Then  'Se retira de empresa
                'If mData("RetiradoDeEmpresa") = False And chkRetiradoDeEmpresa.Checked Then  'Se retira de empresa
                plCLs.AnularDeduccionesEmpleado(mData("CodigoEmpleado"))
                plCLs.AnularDeduccionISREmpleado(mData("CodigoEmpleado"))
            End If
        End If
        If String.IsNullOrEmpty(c1txtNombre2.Text) Then
            c1txtNombre2.Text = ""
        End If
        If String.IsNullOrEmpty(c1txtApellido2.Text) Then
            c1txtApellido2.Text = ""
        End If

        DataNavBarPrincipal.ResultadoValidacion = ""
        DataNavBarPrincipal.ValidacionCorrecta = True
        DataNavBarPrincipal.ValidarInfo(Me)
        If DataNavBarPrincipal.ValidacionCorrecta = True Then
            Try
                Me.Validate()
                Me.PrincipalBindingSource.EndEdit()
                Me.PLEmpleadosTableAdapter.Update(Me.PLEmpleadosDataSet.PLEmpleados)
            Catch ex As Exception
                Cancelar = True
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Verifique los siguientes datos:" & vbCrLf & DataNavBarPrincipal.ResultadoValidacion)
        End If
    End Sub

    Private Sub DataNavBarPrincipal_ReiniciarDatosClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.ReiniciarDatosClick
        mBuscando = True
        DataNavBarPrincipal.toolstriptextBuscar.Text = ""
        Me.PLEmpleadosTableAdapter.Fill(Me.PLEmpleadosDataSet.PLEmpleados, _EmpleadosRetirados)
        mBuscando = False
    End Sub

    Private Sub DataNavBarPrincipal_SalirClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataNavBarPrincipal.SalirClick
        Me.Close()
    End Sub

    Private Sub cmdFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFoto.Click
        openfiledlgEmp.ShowDialog()
        c1txtFoto.Text = openfiledlgEmp.SafeFileName
    End Sub

    Private Sub cmdHojaVida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHojaVida.Click
        openfiledlgEmp.ShowDialog()
        c1txtHojaVida.Text = openfiledlgEmp.SafeFileName
    End Sub

    Private Sub DataNavBarPrincipal_NuevoRegistroClick(sender As Object, e As System.EventArgs, ByRef Cancelar As Boolean) Handles DataNavBarPrincipal.NuevoRegistroClick
        If My.Settings.RSIEmpresaInstalada = "ZOE" Then
            c1txtCodigoEmpleado.Text = PlCls.ObtenerNuevoCodigoEmpleado("ZOE")
        End If
    End Sub

    Private Sub DataNavBarPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles DataNavBarPrincipal.Load

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub btnBuscarEmpleado_Load(sender As System.Object, e As System.EventArgs) Handles btnBuscarEmpleado.Load

    End Sub
End Class