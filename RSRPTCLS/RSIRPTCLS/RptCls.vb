Imports System.drawing
Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.InteropServices
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class RptCls
    Private _DBconStr As String
    Private _TituloEmpresa As String
    Private _FechaReporte As Date
    Private _ServidorRpt As String
    Private _BaseDatosRpt As String
    Private _Filtro As String
    Private _strPar1 As String
    Private _strPar2 As String
    Private _Titulo As String
    Public Property Titulo() As String
        Get
            Return _Titulo
        End Get
        Set(ByVal value As String)
            _Titulo = value
        End Set
    End Property

    Public Property DBconStr() As String
        Get
            DBconStr = _DBconStr
        End Get
        Set(ByVal value As String)
            _DBconStr = value
        End Set
    End Property
    Public Property ServidorRpt() As String
        Get
            ServidorRpt = _ServidorRpt
        End Get
        Set(ByVal value As String)
            _ServidorRpt = value
        End Set
    End Property
    Public Property BaseDatosRpt() As String
        Get
            BaseDatosRpt = _BaseDatosRpt
        End Get
        Set(ByVal value As String)
            _BaseDatosRpt = value
        End Set
    End Property
    Public Property TituloEmpresa() As String
        Get
            TituloEmpresa = _TituloEmpresa
        End Get
        Set(ByVal value As String)
            _TituloEmpresa = value
        End Set
    End Property
    Public Property FechaReporte() As Date
        Get
            FechaReporte = _FechaReporte
        End Get
        Set(ByVal value As Date)
            _FechaReporte = value
        End Set
    End Property
    Public Property Filtro() As String
        Get
            Filtro = _Filtro
        End Get
        Set(ByVal value As String)
            _Filtro = value
        End Set
    End Property
    Public Property strPar1() As String
        Get
            Return _strPar1
        End Get
        Set(ByVal value As String)
            _strPar1 = value
        End Set
    End Property
    Public Property strPar2() As String
        Get
            Return _strPar2
        End Get
        Set(ByVal value As String)
            _strPar2 = value
        End Set
    End Property

    Private Function ObtenerCampos(ByVal dsData As Data.DataSet, ByVal strTabla As String) As String
        Dim i As Int16
        Dim strCadena As String

        strCadena = ""
        For i = 0 To dsData.Tables(strTabla).Columns.Count - 1
            strCadena = strCadena & dsData.Tables(strTabla).Columns(i).ColumnName.ToString
            If i < dsData.Tables(strTabla).Columns.Count - 1 Then
                strCadena = strCadena & ","
            End If
        Next
        ObtenerCampos = "SELECT " & strCadena & " FROM Dbo." & strTabla
    End Function
    Private Function ObtenerServidorDeCadenaConexion() As String

        ObtenerServidorDeCadenaConexion = Strings.Mid(_DBconStr, 13, Strings.InStr(_DBconStr, ";") - 13)
    End Function

    Private Function ObtenerBaseDatosDeCadenaConexion() As String
        Dim intPos As Int16
        intPos = Strings.InStr(_DBconStr, "Initial") + 16
        ObtenerBaseDatosDeCadenaConexion = Strings.Mid(_DBconStr, intPos, Strings.InStr(intPos, _DBconStr, ";") - intPos)
    End Function
    Private Sub ConfCrystalReports(ByVal rptReporte As ReportDocument)
        Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()

        myConnectionInfo.ServerName = ObtenerServidorDeCadenaConexion()
        myConnectionInfo.DatabaseName = ObtenerBaseDatosDeCadenaConexion()
        myConnectionInfo.UserID = "sa"
        myConnectionInfo.Password = "rsierp94128"
        SetDBLogonForReport(myConnectionInfo, rptReporte)
    End Sub
    Private Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables

        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub
    Public Class CTRpt
        Inherits RptCls
        '*** Estados Financieros ***
        Private _TipoEstadoFinan As String
        Private _EstFinanEmpresa As String
        Public Property TipoEstadoFinan() As String
            Get
                Return _TipoEstadoFinan
            End Get
            Set(ByVal value As String)
                _TipoEstadoFinan = value
            End Set
        End Property
        Public Property EstFinanEmpresa() As String
            Get
                Return _EstFinanEmpresa
            End Get
            Set(ByVal value As String)
                _EstFinanEmpresa = value
            End Set
        End Property
        Private _EstFinanFecha As String
        Public Property EstFinanFecha() As String
            Get
                Return _EstFinanFecha
            End Get
            Set(ByVal value As String)
                _EstFinanFecha = value
            End Set
        End Property
        Private _EstFinanTitulo1 As String
        Public Property EstFinanTitulo1() As String
            Get
                Return _EstFinanTitulo1
            End Get
            Set(ByVal value As String)
                _EstFinanTitulo1 = value
            End Set
        End Property
        Private _EstFinanTitulo2 As String
        Public Property EstFinanTitulo2() As String
            Get
                Return _EstFinanTitulo2
            End Get
            Set(ByVal value As String)
                _EstFinanTitulo2 = value
            End Set
        End Property
        Private _EstFinanTitulo3 As String
        Public Property EstFinanTitulo3() As String
            Get
                Return _EstFinanTitulo3
            End Get
            Set(ByVal value As String)
                _EstFinanTitulo3 = value
            End Set
        End Property
        Private _EstFinanComparativo As Boolean
        Public Property EstFinanComparativo() As Boolean
            Get
                Return _EstFinanComparativo
            End Get
            Set(ByVal value As Boolean)
                _EstFinanComparativo = value
            End Set
        End Property
        Private _EstFinanTituloAño1 As String
        Public Property EstFinanTituloAño1() As String
            Get
                Return _EstFinanTituloAño1
            End Get
            Set(ByVal value As String)
                _EstFinanTituloAño1 = value
            End Set
        End Property
        Private _EstFinanTituloAño2 As String
        Public Property EstFinanTituloAño2() As String
            Get
                Return _EstFinanTituloAño2
            End Get
            Set(ByVal value As String)
                _EstFinanTituloAño2 = value
            End Set
        End Property
        Private _EstFinanEjecutivo1 As String
        Public Property EstFinanEjecutivo1() As String
            Get
                Return _EstFinanEjecutivo1
            End Get
            Set(ByVal value As String)
                _EstFinanEjecutivo1 = value
            End Set
        End Property
        Private _EstFinanEjecutivo2 As String
        Public Property EstFinanEjecutivo2() As String
            Get
                Return _EstFinanEjecutivo2
            End Get
            Set(ByVal value As String)
                _EstFinanEjecutivo2 = value
            End Set
        End Property
        Private _EstFinanEjecutivo3 As String
        Public Property EstFinanEjecutivo3() As String
            Get
                Return _EstFinanEjecutivo3
            End Get
            Set(ByVal value As String)
                _EstFinanEjecutivo3 = value
            End Set
        End Property
        Private _EstFinanCargo1 As String
        Public Property EstFinanCargo1() As String
            Get
                Return _EstFinanCargo1
            End Get
            Set(ByVal value As String)
                _EstFinanCargo1 = value
            End Set
        End Property
        Private _EstFinanCargo2 As String
        Public Property EstFinanCargo2() As String
            Get
                Return _EstFinanCargo2
            End Get
            Set(ByVal value As String)
                _EstFinanCargo2 = value
            End Set
        End Property
        Private _EstFinanCargo3 As String
        Public Property EstFinanCargo3() As String
            Get
                Return _EstFinanCargo3
            End Get
            Set(ByVal value As String)
                _EstFinanCargo3 = value
            End Set
        End Property
        Private _CTEstadosFinanDataSet As DataSet
        Public Property CTEstadosFinanDataSet() As DataSet
            Get
                Return _CTEstadosFinanDataSet
            End Get
            Set(ByVal value As DataSet)
                _CTEstadosFinanDataSet = value
            End Set
        End Property
        Private _CTLibroMayorDataSet As DataSet
        Public Property CTLibroMayorDataSet() As DataSet
            Get
                Return _CTLibroMayorDataSet
            End Get
            Set(ByVal value As DataSet)
                _CTLibroMayorDataSet = value
            End Set
        End Property

        Public Sub EjecutarListados(ByVal strReporte As String)
            Dim rptRep As CrystalDecisions.CrystalReports.Engine.ReportClass
            Dim fFormaRep As VisorRepFrm
            Dim connInfo As New ConnectionInfo
            Dim TBLogonInfo As New TableLogOnInfo

            Select Case strReporte
                Case "CATALOGO"
                    rptRep = New CTCatalogoRpt
                Case "TRANSACCIONES"
                    rptRep = New CTTransaccionesRpt
            End Select

            connInfo.ServerName = ServidorRpt
            connInfo.DatabaseName = _BaseDatosRpt
            connInfo.UserID = strPar1
            connInfo.Password = strPar2

            TBLogonInfo.ConnectionInfo = connInfo
            For Each MiTabla As Table In rptRep.Database.Tables
                MiTabla.ApplyLogOnInfo(TBLogonInfo)
                MiTabla.LogOnInfo.ConnectionInfo.AllowCustomConnection = True
                MiTabla.LogOnInfo.ConnectionInfo.ServerName = connInfo.ServerName
                MiTabla.LogOnInfo.ConnectionInfo.DatabaseName = connInfo.DatabaseName
                MiTabla.LogOnInfo.ConnectionInfo.UserID = connInfo.UserID
                MiTabla.LogOnInfo.ConnectionInfo.Password = connInfo.Password
            Next

            rptRep.SetParameterValue("Empresa", TituloEmpresa)
            rptRep.SetParameterValue("Fecha", FechaReporte)
            rptRep.RecordSelectionFormula = Filtro

            fFormaRep = New VisorRepFrm
            fFormaRep.RepVisor.ReportSource = rptRep
            'fFormaRep.Text = strTitulo1
            fFormaRep.Show()

        End Sub
        Public Sub EjecutarRepEstadosFinancieros()
            Dim rptRep As CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim fFormaRep As VisorRepFrm

            rptRep = New CTBalGenRpt    'Se usará el mismo formato para todos los estado financieros Balance General y Estado de Resultados
            rptRep.SetDataSource(CTEstadosFinanDataSet)
            rptRep.SetParameterValue("Comparar", EstFinanComparativo)
            rptRep.SetParameterValue("AñoAnterior", EstFinanTituloAño1)
            rptRep.SetParameterValue("AñoActual", EstFinanTituloAño2)
            rptRep.SetParameterValue("Empresa", EstFinanEmpresa)
            rptRep.SetParameterValue("Fecha", EstFinanFecha)
            rptRep.SetParameterValue("Titulo1", EstFinanTitulo1)
            rptRep.SetParameterValue("Titulo2", EstFinanTitulo2)
            rptRep.SetParameterValue("Titulo3", EstFinanTitulo3)
            rptRep.SetParameterValue("Ejecutivo1", EstFinanEjecutivo1)
            rptRep.SetParameterValue("Ejecutivo2", EstFinanEjecutivo2)
            rptRep.SetParameterValue("Ejecutivo3", EstFinanEjecutivo3)
            rptRep.SetParameterValue("Cargo1", EstFinanCargo1)
            rptRep.SetParameterValue("Cargo2", EstFinanCargo2)
            rptRep.SetParameterValue("Cargo3", EstFinanCargo3)

            fFormaRep = New VisorRepFrm
            fFormaRep.RepVisor.ReportSource = rptRep
            If TipoEstadoFinan = "BG" Then
                fFormaRep.Text = "Reporte del Balance General"
            Else
                fFormaRep.Text = "Reporte del Estado de Resultados"
            End If
            fFormaRep.Show()

        End Sub
        Public Sub EjecutarBalanceComprobacion(strRep As String)
            Dim rptRep As New CrystalDecisions.CrystalReports.Engine.ReportClass
            Dim fFormaRep As VisorRepFrm
            Dim connInfo As New ConnectionInfo
            Dim TBLogonInfo As New TableLogOnInfo

            If strRep = "BALCOMPROB" Then
                rptRep = New CTBalanceComprobRpt
            Else
                rptRep = New CTBalanceComprobPresRpt
            End If

            connInfo.ServerName = ServidorRpt
            connInfo.DatabaseName = _BaseDatosRpt
            connInfo.UserID = strPar1
            connInfo.Password = strPar2

            TBLogonInfo.ConnectionInfo = connInfo
            For Each MiTabla As Table In rptRep.Database.Tables
                MiTabla.ApplyLogOnInfo(TBLogonInfo)
                MiTabla.LogOnInfo.ConnectionInfo.AllowCustomConnection = True
                MiTabla.LogOnInfo.ConnectionInfo.ServerName = connInfo.ServerName
                MiTabla.LogOnInfo.ConnectionInfo.DatabaseName = connInfo.DatabaseName
                MiTabla.LogOnInfo.ConnectionInfo.UserID = connInfo.UserID
                MiTabla.LogOnInfo.ConnectionInfo.Password = connInfo.Password
            Next

            rptRep.SetParameterValue("Empresa", TituloEmpresa)
            rptRep.SetParameterValue("Fecha", FechaReporte)
            rptRep.SetParameterValue("Titulo1", EstFinanTitulo1)
            rptRep.SetParameterValue("Titulo2", EstFinanTitulo2)
            rptRep.SetParameterValue("Titulo3", EstFinanTitulo3)

            rptRep.RecordSelectionFormula = Filtro
            fFormaRep = New VisorRepFrm
            fFormaRep.RepVisor.ReportSource = rptRep
            fFormaRep.Show()
        End Sub
        Public Sub EjecutarLibroMayor()
            Dim rptRep As CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim fFormaRep As VisorRepFrm

            rptRep = New CTLibroMayorRpt
            rptRep.SetDataSource(CTLibroMayorDataSet)
            rptRep.SetParameterValue("Empresa", EstFinanEmpresa)
            rptRep.SetParameterValue("Fecha", EstFinanFecha)
            rptRep.SetParameterValue("Titulo1", EstFinanTitulo1)

            fFormaRep = New VisorRepFrm
            fFormaRep.RepVisor.ReportSource = rptRep
            fFormaRep.Text = "Reporte del Libro Mayor"
            fFormaRep.Show()
        End Sub
        Public Sub EjecutarMovCuentas(strRep As String, mImpConcepto As Boolean)
            Dim rptRep As New CrystalDecisions.CrystalReports.Engine.ReportClass
            Dim fFormaRep As VisorRepFrm
            Dim connInfo As New ConnectionInfo
            Dim TBLogonInfo As New TableLogOnInfo

            If strRep = "GEN" Then
                rptRep = New CTMovCtaResRpt
            Else
                rptRep = New CTMovCtaDetRpt
            End If

            connInfo.ServerName = ServidorRpt
            connInfo.DatabaseName = BaseDatosRpt
            connInfo.UserID = strPar1
            connInfo.Password = strPar2

            TBLogonInfo.ConnectionInfo = connInfo
            For Each MiTabla As Table In rptRep.Database.Tables
                MiTabla.ApplyLogOnInfo(TBLogonInfo)
                MiTabla.LogOnInfo.ConnectionInfo.AllowCustomConnection = True
                MiTabla.LogOnInfo.ConnectionInfo.ServerName = connInfo.ServerName
                MiTabla.LogOnInfo.ConnectionInfo.DatabaseName = connInfo.DatabaseName
                MiTabla.LogOnInfo.ConnectionInfo.UserID = connInfo.UserID
                MiTabla.LogOnInfo.ConnectionInfo.Password = connInfo.Password
            Next

            rptRep.SetParameterValue("Empresa", TituloEmpresa)
            rptRep.SetParameterValue("Fecha", FechaReporte)
            rptRep.SetParameterValue("Titulo", Titulo)
            rptRep.SetParameterValue("ImprimirConceptoPartida", IIf(mImpConcepto, "S", "N"))

            rptRep.RecordSelectionFormula = Filtro
            fFormaRep = New VisorRepFrm
            fFormaRep.RepVisor.ReportSource = rptRep
            fFormaRep.Show()

        End Sub
        Public Sub EjecutarPartidaCierre(intAño As Int16)
            Dim rptRep As New CrystalDecisions.CrystalReports.Engine.ReportClass
            Dim fFormaRep As VisorRepFrm
            Dim connInfo As New ConnectionInfo
            Dim TBLogonInfo As New TableLogOnInfo

            rptRep = New CTPartidaCierreRpt

            connInfo.ServerName = ServidorRpt
            connInfo.DatabaseName = _BaseDatosRpt
            connInfo.UserID = strPar1
            connInfo.Password = strPar2

            TBLogonInfo.ConnectionInfo = connInfo
            For Each MiTabla As Table In rptRep.Database.Tables
                MiTabla.ApplyLogOnInfo(TBLogonInfo)
                MiTabla.LogOnInfo.ConnectionInfo.AllowCustomConnection = True
                MiTabla.LogOnInfo.ConnectionInfo.ServerName = connInfo.ServerName
                MiTabla.LogOnInfo.ConnectionInfo.DatabaseName = connInfo.DatabaseName
                MiTabla.LogOnInfo.ConnectionInfo.UserID = connInfo.UserID
                MiTabla.LogOnInfo.ConnectionInfo.Password = connInfo.Password
            Next

            rptRep.SetParameterValue("Empresa", TituloEmpresa)
            rptRep.SetParameterValue("Titulo1", "Partida de Cierre del Año " & intAño)

            rptRep.RecordSelectionFormula = "{CTPartidasCierreAnual.Año}=" & intAño
            fFormaRep = New VisorRepFrm
            fFormaRep.RepVisor.ReportSource = rptRep
            fFormaRep.Show()
        End Sub
        Public Sub EjecutarReportesPresup(strRep As String)
            Dim rptRep As New CrystalDecisions.CrystalReports.Engine.ReportClass
            Dim fFormaRep As VisorRepFrm
            Dim connInfo As New ConnectionInfo
            Dim TBLogonInfo As New TableLogOnInfo

            If strRep = "CTPresupEjecucionAnualRpt" Then
                rptRep = New CTPresupEjecucionAnualRpt
            ElseIf strRep = "EJECTRIM" Then

            End If

            connInfo.ServerName = ServidorRpt
            connInfo.DatabaseName = _BaseDatosRpt
            connInfo.UserID = strPar1
            connInfo.Password = strPar2

            TBLogonInfo.ConnectionInfo = connInfo
            For Each MiTabla As Table In rptRep.Database.Tables
                MiTabla.ApplyLogOnInfo(TBLogonInfo)
                MiTabla.LogOnInfo.ConnectionInfo.AllowCustomConnection = True
                MiTabla.LogOnInfo.ConnectionInfo.ServerName = connInfo.ServerName
                MiTabla.LogOnInfo.ConnectionInfo.DatabaseName = connInfo.DatabaseName
                MiTabla.LogOnInfo.ConnectionInfo.UserID = connInfo.UserID
                MiTabla.LogOnInfo.ConnectionInfo.Password = connInfo.Password
            Next

            rptRep.SetParameterValue("Empresa", TituloEmpresa)
            rptRep.SetParameterValue("Titulo", Titulo)
            rptRep.RecordSelectionFormula = Filtro
            fFormaRep = New VisorRepFrm
            fFormaRep.RepVisor.ReportSource = rptRep
            fFormaRep.Show()

        End Sub
    End Class
    Public Class PLRpt
        Inherits RptCls
        Public Sub EjecutarListados(ByVal strConexion As String, ByVal strNombreListado As String, ByVal strEmpresa As String)
            Dim rptRep As CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim fFormaRep As VisorRepFrm
            Dim connInfo As New ConnectionInfo
            Dim TBLogonInfo As New TableLogOnInfo

            Select Case strNombreListado
                Case "Sedes"
                    rptRep = New PLSedesRpt
                Case "Departamentos"
                    rptRep = New PLDeparamentosRpt
                Case "Secciones"
                    rptRep = New PLSeccionesRpt
                Case "Profesiones"
                    rptRep = New PLProfesionesRpt
                Case "Puestos"
                    rptRep = New PLPuestosRpt
                Case "TiposEmpleados"
                    rptRep = New PLTiposEmpleadosRpt
                Case "Bancos"
                    rptRep = New PLBancosRpt
            End Select
            'connInfo.ServerName = ObtenerServidorDeCadenaConexion()
            connInfo.DatabaseName = ObtenerBaseDatosDeCadenaConexion() '_BaseDatosRpt
            connInfo.UserID = "sa"
            connInfo.Password = "rsierp94128"

            TBLogonInfo.ConnectionInfo = connInfo
            For Each MiTabla As Table In rptRep.Database.Tables
                MiTabla.ApplyLogOnInfo(TBLogonInfo)
                MiTabla.LogOnInfo.ConnectionInfo.DatabaseName = connInfo.DatabaseName
                MiTabla.LogOnInfo.ConnectionInfo.UserID = connInfo.UserID
                MiTabla.LogOnInfo.ConnectionInfo.Password = connInfo.Password
            Next

            rptRep.SetParameterValue("Empresa", strEmpresa)
            fFormaRep = New VisorRepFrm
            fFormaRep.RepVisor.ReportSource = rptRep

            Select Case strNombreListado
                Case "Sedes"
                    fFormaRep.Text = "Listado de Sedes"
                Case "Departamentos"
                    fFormaRep.Text = "Listado de Departamentos"
                Case "Secciones"
                    fFormaRep.Text = "Listado de Secciones"
                Case "Profesiones"
                    fFormaRep.Text = "Listado de Profesiones"
                Case "Puestos"
                    fFormaRep.Text = "Listado de Puestos"
                Case "TiposEmpleados"
                    fFormaRep.Text = "Listado de Tipos de Empleados"
                Case "Bancos"
                    fFormaRep.Text = "Listado de Bancos"
            End Select

            fFormaRep.Show()
        End Sub
        Public Sub EjecutarListadoEmpleados(ByVal strConexion As String, ByVal strEmpresa As String, ByVal mListarTodo As Boolean, ByVal strSel As String, ByVal strOrden As String, ByVal mMostrarSedes As Boolean, ByVal mMostrarDeptos As Boolean, ByVal mMostrarSecs As Boolean, ByVal mFecha As Date)
            Dim rptRep As CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim fFormaRep As VisorRepFrm
            Dim connInfo As New ConnectionInfo
            Dim TBLogonInfo As New TableLogOnInfo

            rptRep = New PLEmpleadosRpt
            connInfo.DatabaseName = _BaseDatosRpt
            connInfo.UserID = "sa"
            connInfo.Password = "rsierp94128"

            TBLogonInfo.ConnectionInfo = connInfo
            For Each MiTabla As Table In rptRep.Database.Tables
                MiTabla.ApplyLogOnInfo(TBLogonInfo)
                MiTabla.LogOnInfo.ConnectionInfo.DatabaseName = connInfo.DatabaseName
                MiTabla.LogOnInfo.ConnectionInfo.UserID = connInfo.UserID
                MiTabla.LogOnInfo.ConnectionInfo.Password = connInfo.Password
            Next
            rptRep.SetParameterValue("Empresa", strEmpresa)
            rptRep.SetParameterValue("MostrarSedes", mMostrarSedes)
            rptRep.SetParameterValue("MostrarDepartamentos", mMostrarDeptos)
            rptRep.SetParameterValue("MostrarSecciones", mMostrarSecs)
            rptRep.SetParameterValue("Fecha", mFecha)
            If Not mListarTodo Then
                rptRep.RecordSelectionFormula = strSel
            End If
            'rptRep.o()

            fFormaRep = New VisorRepFrm
            fFormaRep.RepVisor.ReportSource = rptRep
            fFormaRep.Text = "Listado de General de Empleados"
            fFormaRep.Show()
        End Sub
        Public Sub EjecutarReportesVarios(ByVal strConexion As String, ByVal strEmpresa As String, ByVal strReporte As String, ByVal strSel As String, ByVal strTitulo As String, ByVal mFecha As Date)
            Dim rptRep As CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim fFormaRep As VisorRepFrm
            Dim connInfo As New ConnectionInfo
            Dim TBLogonInfo As New TableLogOnInfo

            Select Case strReporte
                Case "PLSeguroSocialRpt"
                    rptRep = New PLSeguroSocialRpt
                Case "PLRAPRpt"
                    rptRep = New PLRAPRpt
                Case "PLImpVecinalRpt"
                    rptRep = New PLImpVecinalRpt
                Case "PLISRRpt"
                    rptRep = New PLISRRpt
                Case "PLRepIngresosRpt"
                    rptRep = New PLRepIngresosRpt
                Case "PLSalPendEmp1Rpt"
                    rptRep = New PLSalPendEmp1Rpt
                Case "PLSalPendEmp2Rpt"
                    rptRep = New PLSalPendEmp2Rpt
                Case "PLHistorialRpt"
                    rptRep = New PLHistorialRpt
            End Select

            connInfo.DatabaseName = _BaseDatosRpt
            connInfo.UserID = "sa"
            connInfo.Password = "rsierp94128"

            TBLogonInfo.ConnectionInfo = connInfo
            For Each MiTabla As Table In rptRep.Database.Tables
                MiTabla.ApplyLogOnInfo(TBLogonInfo)
                MiTabla.LogOnInfo.ConnectionInfo.DatabaseName = connInfo.DatabaseName
                MiTabla.LogOnInfo.ConnectionInfo.UserID = connInfo.UserID
                MiTabla.LogOnInfo.ConnectionInfo.Password = connInfo.Password
            Next
            rptRep.SetParameterValue("Empresa", strEmpresa)
            rptRep.SetParameterValue("Fecha", mFecha)
            If strReporte = "PLRepIngresosRpt" Then
                rptRep.SetParameterValue("TituloPlanilla", strTitulo)
            End If
            If strReporte = "PLSeguroSocialRpt" Or strReporte = "PLRAPRpt" Or strReporte = "PLImpVecinalRpt" Or strReporte = "PLISRRpt" Then
                rptRep.SetParameterValue("Titulo1", strTitulo)
            End If
            rptRep.RecordSelectionFormula = strSel

            fFormaRep = New VisorRepFrm
            fFormaRep.RepVisor.ReportSource = rptRep
            fFormaRep.Text = strTitulo
            fFormaRep.Show()
        End Sub
        Public Sub EjecutarReporteDeducciones(ByVal strConexion As String, ByVal strEmpresa As String, ByVal strReporte As String, ByVal strSel As String, ByVal strTitulo1 As String, ByVal strTitulo2 As String, ByVal mFecha As Date)
            'Dim rptRep As CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim rptRep As CrystalDecisions.CrystalReports.Engine.ReportClass
            Dim fFormaRep As VisorRepFrm
            Dim connInfo As New ConnectionInfo
            Dim TBLogonInfo As New TableLogOnInfo

            Select Case strReporte
                Case "DeduccionMensual"
                    rptRep = New PLDedMenRpt
                Case "DeduccionDelMes"
                    rptRep = New PLDedDelMesRpt
            End Select

            connInfo.DatabaseName = _BaseDatosRpt
            connInfo.UserID = "sa"
            connInfo.Password = "rsierp94128"

            TBLogonInfo.ConnectionInfo = connInfo
            For Each MiTabla As Table In rptRep.Database.Tables
                MiTabla.ApplyLogOnInfo(TBLogonInfo)
                MiTabla.LogOnInfo.ConnectionInfo.DatabaseName = connInfo.DatabaseName
                MiTabla.LogOnInfo.ConnectionInfo.UserID = connInfo.UserID
                MiTabla.LogOnInfo.ConnectionInfo.Password = connInfo.Password
            Next

            rptRep.SetParameterValue("Empresa", strEmpresa)
            rptRep.SetParameterValue("Fecha", mFecha)
            rptRep.SetParameterValue("Titulo1", strTitulo1)
            If strReporte = "DeduccionMensual" Then
                rptRep.SetParameterValue("Titulo2", strTitulo2)
            End If
            rptRep.RecordSelectionFormula = strSel

            fFormaRep = New VisorRepFrm
            fFormaRep.RepVisor.ReportSource = rptRep
            fFormaRep.Text = strTitulo1
            fFormaRep.Show()
        End Sub
        Public Sub EjecutarReportePlanillaEgresos(ByVal strConexion As String, ByVal strEmpresa As String, ByVal strReporte As String, ByVal strSel As String, ByVal strTitulo As String, ByVal mFecha As Date, ByVal strTitDed1 As String, ByVal strTitDed2 As String, ByVal strTitDed3 As String, _
            ByVal strTitDed4 As String, ByVal strTitDed5 As String, ByVal strTitDed6 As String, ByVal strTitDed7 As String, ByVal strTitDed8 As String, ByVal strTitDed9 As String, ByVal strTitDed10 As String, ByVal strTitDed11 As String, _
            ByVal strTitDed12 As String, ByVal strTitDed13 As String, ByVal strTitDed14 As String, ByVal strTitDed15 As String, ByVal intNumCols As Int16)
            Dim rptRep As CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim fFormaRep As VisorRepFrm
            Dim connInfo As New ConnectionInfo
            Dim TBLogonInfo As New TableLogOnInfo
            'Dim i As Integer

            If strReporte = "PLDeducciones1Rpt" Then
                rptRep = New PLDeducciones1Rpt
            ElseIf strReporte = "PLDeducciones2Rpt" Then
                rptRep = New PLDeducciones2Rpt
            ElseIf strReporte = "PLDeducciones3Rpt" Then
                rptRep = New PLDeducciones3Rpt
            End If

            'connInfo.ServerName = ""
            connInfo.DatabaseName = _BaseDatosRpt
            connInfo.UserID = "sa"
            connInfo.Password = "rsierp94128"

            TBLogonInfo.ConnectionInfo = connInfo
            For Each MiTabla As Table In rptRep.Database.Tables
                MiTabla.ApplyLogOnInfo(TBLogonInfo)
                'MiTabla.LogOnInfo.ConnectionInfo.ServerName = connInfo.ServerName
                MiTabla.LogOnInfo.ConnectionInfo.DatabaseName = connInfo.DatabaseName
                MiTabla.LogOnInfo.ConnectionInfo.UserID = connInfo.UserID
                MiTabla.LogOnInfo.ConnectionInfo.Password = connInfo.Password
            Next

            'For i = 0 To rptRep.DataSourceConnections.Count - 1
            'rptRep.DataSourceConnections(i).SetLogon("sa", "rsierp94128")
            'Next
            rptRep.SetParameterValue("Empresa", strEmpresa)
            rptRep.SetParameterValue("Fecha", mFecha)
            rptRep.SetParameterValue("Titulo1", strTitulo)
            rptRep.SetParameterValue("TitDed1", strTitDed1)
            rptRep.SetParameterValue("TitDed2", strTitDed2)
            rptRep.SetParameterValue("TitDed3", strTitDed3)
            rptRep.SetParameterValue("TitDed4", strTitDed4)
            rptRep.SetParameterValue("TitDed5", strTitDed5)
            rptRep.SetParameterValue("TitDed6", strTitDed6)
            rptRep.SetParameterValue("TitDed7", strTitDed7)
            rptRep.SetParameterValue("TitDed8", strTitDed8)
            rptRep.SetParameterValue("TitDed9", strTitDed9)
            rptRep.SetParameterValue("TitDed10", strTitDed10)
            rptRep.SetParameterValue("TitDed11", strTitDed11)
            If strReporte = "PLDeducciones3Rpt" Then
                rptRep.SetParameterValue("TitDed12", strTitDed12)
                rptRep.SetParameterValue("TitDed13", strTitDed13)
                rptRep.SetParameterValue("TitDed14", strTitDed14)
                rptRep.SetParameterValue("TitDed15", strTitDed15)
            End If

            'rptRep.DataDefinition.GroupSelectionFormula = strSel
            rptRep.RecordSelectionFormula = strSel

            If intNumCols <= 7 Then
                rptRep.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
                'PrintLayoutSettings.PrintScaling.Scale = 2
            End If
            fFormaRep = New VisorRepFrm
            fFormaRep.RepVisor.ReportSource = rptRep
            fFormaRep.Text = strTitulo
            fFormaRep.Show()
        End Sub
        Public Sub EjecutarReportePlanilla(ByVal strConexion As String, ByVal strEmpresa As String, ByVal strReporte As String, ByVal strSel As String, ByVal strTitulo As String, ByVal mFecha As Date, ByVal strTitDed1 As String, ByVal strTitDed2 As String, ByVal strTitDed3 As String, _
            ByVal strTitDed4 As String, ByVal strTitDed5 As String, ByVal strTitDed6 As String, ByVal strTitDed7 As String)
            Dim rptRep As CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim fFormaRep As VisorRepFrm
            Dim connInfo As New ConnectionInfo
            Dim TBLogonInfo As New TableLogOnInfo

            If strReporte = "PLPlanilla1Rpt" Then
                rptRep = New PLPlanilla1Rpt
            Else
                rptRep = New PLResumenGenRpt
            End If

            connInfo.DatabaseName = _BaseDatosRpt
            connInfo.UserID = "sa"
            connInfo.Password = "rsierp94128"

            TBLogonInfo.ConnectionInfo = connInfo
            For Each MiTabla As Table In rptRep.Database.Tables
                MiTabla.ApplyLogOnInfo(TBLogonInfo)
                MiTabla.LogOnInfo.ConnectionInfo.DatabaseName = connInfo.DatabaseName
                MiTabla.LogOnInfo.ConnectionInfo.UserID = connInfo.UserID
                MiTabla.LogOnInfo.ConnectionInfo.Password = connInfo.Password
            Next
            rptRep.SetParameterValue("Empresa", strEmpresa)
            rptRep.SetParameterValue("Fecha", mFecha)
            rptRep.SetParameterValue("Titulo1", strTitulo)
            If strReporte = "PLPlanilla1Rpt" Then                
                rptRep.SetParameterValue("DedTit1", strTitDed1)
                rptRep.SetParameterValue("DedTit2", strTitDed2)
                rptRep.SetParameterValue("DedTit3", strTitDed3)
                rptRep.SetParameterValue("DedTit4", strTitDed4)
                rptRep.SetParameterValue("DedTit5", strTitDed5)
                rptRep.SetParameterValue("DedTit6", strTitDed6)
                rptRep.SetParameterValue("DedTit7", strTitDed7)
            End If
            rptRep.RecordSelectionFormula = strSel

            fFormaRep = New VisorRepFrm
            fFormaRep.RepVisor.ReportSource = rptRep
            fFormaRep.Text = strTitulo
            fFormaRep.Show()
        End Sub
        Public Sub EjecutarRecibosPlanilla(ByVal strConexion As String, ByVal strEmpresa As String, ByVal strReporte As String, ByVal strSel As String, ByVal strTitulo As String, ByVal mFecha As Date, ByVal strTitIng1 As String, ByVal strTitIng2 As String, _
            ByVal strTitIng3 As String, ByVal strTitIng4 As String, ByVal strTitIng5 As String, ByVal strTitDed1 As String, ByVal strTitDed2 As String, ByVal strTitDed3 As String, _
            ByVal strTitDed4 As String, ByVal strTitDed5 As String, ByVal strTitDed6 As String, ByVal strTitDed7 As String, ByVal strTitDed8 As String, ByVal strTitDed9 As String, ByVal strTitDed10 As String, ByVal strTitDed11 As String, ByVal strTitDed12 As String)
            Dim rptRep As CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim fFormaRep As VisorRepFrm
            Dim connInfo As New ConnectionInfo
            Dim TBLogonInfo As New TableLogOnInfo

            If strReporte = "PLRecibos1Rpt" Then
                rptRep = New PLRecibos1Rpt
            ElseIf strReporte = "PLRecibos2Rpt" Then
                rptRep = New PLRecibos2Rpt
            End If

            connInfo.DatabaseName = _BaseDatosRpt
            connInfo.UserID = "sa"
            connInfo.Password = "rsierp94128"

            TBLogonInfo.ConnectionInfo = connInfo
            For Each MiTabla As Table In rptRep.Database.Tables
                MiTabla.ApplyLogOnInfo(TBLogonInfo)
                MiTabla.LogOnInfo.ConnectionInfo.DatabaseName = connInfo.DatabaseName
                MiTabla.LogOnInfo.ConnectionInfo.UserID = connInfo.UserID
                MiTabla.LogOnInfo.ConnectionInfo.Password = connInfo.Password
            Next
            rptRep.SetParameterValue("Empresa", strEmpresa)
            rptRep.SetParameterValue("Fecha", mFecha)
            rptRep.SetParameterValue("Titulo1", strTitulo)
            rptRep.SetParameterValue("IngTit1", strTitIng1)
            rptRep.SetParameterValue("IngTit2", strTitIng2)
            rptRep.SetParameterValue("IngTit3", strTitIng3)
            rptRep.SetParameterValue("IngTit4", strTitIng4)
            rptRep.SetParameterValue("IngTit5", strTitIng5)
            rptRep.SetParameterValue("DedTit1", strTitDed1)
            rptRep.SetParameterValue("DedTit2", strTitDed2)
            rptRep.SetParameterValue("DedTit3", strTitDed3)
            rptRep.SetParameterValue("DedTit4", strTitDed4)
            rptRep.SetParameterValue("DedTit5", strTitDed5)
            rptRep.SetParameterValue("DedTit6", strTitDed6)
            rptRep.SetParameterValue("DedTit7", strTitDed7)
            rptRep.SetParameterValue("DedTit8", strTitDed8)
            rptRep.SetParameterValue("DedTit9", strTitDed9)
            rptRep.SetParameterValue("DedTit10", strTitDed10)
            rptRep.SetParameterValue("DedTit11", strTitDed11)
            rptRep.SetParameterValue("DedTit12", strTitDed12)
            rptRep.RecordSelectionFormula = strSel

            rptRep.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetterSmall
            fFormaRep = New VisorRepFrm
            fFormaRep.RepVisor.ReportSource = rptRep
            fFormaRep.Text = strTitulo
            fFormaRep.Show()
        End Sub
        Public Sub EjecutarReportePrestaciones(ByVal strConexion As String, ByVal strEmpresa As String, ByVal strNombreEmpleado As String, ByVal strSel As String)
            Dim rptRep As CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim fFormaRep As VisorRepFrm
            Dim connInfo As New ConnectionInfo
            Dim TBLogonInfo As New TableLogOnInfo

            rptRep = New PLPrestacionesRpt
            connInfo.DatabaseName = _BaseDatosRpt
            connInfo.UserID = "sa"
            connInfo.Password = "rsierp94128"

            TBLogonInfo.ConnectionInfo = connInfo
            For Each MiTabla As Table In rptRep.Database.Tables
                MiTabla.ApplyLogOnInfo(TBLogonInfo)
                MiTabla.LogOnInfo.ConnectionInfo.DatabaseName = connInfo.DatabaseName
                MiTabla.LogOnInfo.ConnectionInfo.UserID = connInfo.UserID
                MiTabla.LogOnInfo.ConnectionInfo.Password = connInfo.Password
            Next
            rptRep.SetParameterValue("Empresa", strEmpresa)
            rptRep.SetParameterValue("Nombre", strNombreEmpleado)
            rptRep.RecordSelectionFormula = strSel
            fFormaRep = New VisorRepFrm
            fFormaRep.RepVisor.ReportSource = rptRep
            fFormaRep.Text = "Prestaciones"
            fFormaRep.Show()
        End Sub
        Public Sub EjecutarReporteVacaciones(ByVal strConexion As String, ByVal strEmpresa As String, ByVal mFecha As Date, strTipo As String, intPeriodo1 As Int16, intPeriodo2 As Int16, intPeriodo3 As Int16, ByVal strSel As String)
            Dim rptRep As CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim fFormaRep As VisorRepFrm
            Dim connInfo As New ConnectionInfo
            Dim TBLogonInfo As New TableLogOnInfo

            If strTipo = "D" Then
                rptRep = New PLCuadroVacacionesRpt
            Else
                rptRep = New PLVacacionesResumenRpt
            End If
            connInfo.DatabaseName = ObtenerBaseDatosDeCadenaConexion()
            connInfo.UserID = "sa"
            connInfo.Password = "rsierp94128"

            TBLogonInfo.ConnectionInfo = connInfo
            For Each MiTabla As Table In rptRep.Database.Tables
                MiTabla.ApplyLogOnInfo(TBLogonInfo)
                MiTabla.LogOnInfo.ConnectionInfo.DatabaseName = connInfo.DatabaseName
                MiTabla.LogOnInfo.ConnectionInfo.UserID = connInfo.UserID
                MiTabla.LogOnInfo.ConnectionInfo.Password = connInfo.Password
            Next
            rptRep.SetParameterValue("Empresa", strEmpresa)
            rptRep.SetParameterValue("Fecha", mFecha)
            If strTipo = "R" Then
                rptRep.SetParameterValue("Periodo1", intPeriodo1 & " - " & intPeriodo1 + 1)
                rptRep.SetParameterValue("Periodo2", intPeriodo2 & " - " & intPeriodo2 + 1)
                'rptRep.SetParameterValue("Periodo3", intPeriodo3 & " - " & intPeriodo3 + 1)
            End If
            rptRep.DataDefinition.RecordSelectionFormula = strSel

            fFormaRep = New VisorRepFrm
            fFormaRep.RepVisor.ReportSource = rptRep
            fFormaRep.Text = "Vacaciones"
            fFormaRep.Show()
        End Sub
    End Class
End Class
