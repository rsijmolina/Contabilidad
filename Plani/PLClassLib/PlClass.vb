Public Class PlClass
    Private _RgsrlCl As Int32
    Private _DBeng As String
    Private _DBconStr As String
    Private _DBcon As SqlClient.SqlConnection
    Private _DBTrans As SqlClient.SqlTransaction
    Private _mTransInicializada = False
    Private _AñoActual As Int16
    Private _MesActual As Int16
    Private _ErrorMsg As String
    Private _PeriodoActual As String

    Public Property RgsrlCl() As Int32
        Get
            RgsrlCl = _RgsrlCl
        End Get
        Set(ByVal value As Int32)
            _RgsrlCl = value
        End Set
    End Property
    Public Property DBeng() As String
        Get
            DBeng = _DBeng
        End Get
        Set(ByVal value As String)
            _DBeng = value
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

    ReadOnly Property DBCon() As SqlClient.SqlConnection
        Get
            DBCon = _DBcon
        End Get
    End Property
    Public Property AñoActual() As Int16
        Get
            AñoActual = _AñoActual
        End Get
        Set(ByVal value As Int16)
            _AñoActual = value
        End Set
    End Property
    Public Property MesActual() As Int16
        Get
            MesActual = _MesActual
        End Get
        Set(ByVal value As Int16)
            _MesActual = value
        End Set
    End Property
    ReadOnly Property ErrorMsg() As String
        Get
            ErrorMsg = _ErrorMsg
        End Get
    End Property
    Public Property PeriodoActual() As String
        Get
            PeriodoActual = _PeriodoActual
        End Get
        Set(ByVal value As String)
            _PeriodoActual = value
        End Set
    End Property

    Public Function drConf() As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT * FROM PLConf"
        drConf = cmdInComando.ExecuteReader
        drConf.Read()
    End Function
    Public Function drDatosEmpleado(ByVal strEmp As String) As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT Nombre1,Nombre2,Apellido1,Apellido2,FechaIngreso,Sexo,EsDocente,EsMedico,Identificacion1,Banco,NoCuentaBancaria FROM PLEmpleados WHERE CodigoEmpleado='" & strEmp & "'"
        drDatosEmpleado = cmdInComando.ExecuteReader
        drDatosEmpleado.Read()
    End Function
    Public Function drDatosEmpleadoPlanilla(ByVal strEmp As String) As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT Nombre1,Nombre2,Apellido1,Apellido2,CodigoSede,CodigoDepartamento,CodigoSeccion, FechaIngreso, " _
            & "EsDocente,EsVendedor,EsCobrador,EsMedico,CodigoPuesto,IngresoPorComision,SalarioMensual,SalarioHora,Banco,NoDeducirRAP,NoDeducirSeguroSocial FROM PLEmpleados WHERE CodigoEmpleado='" & strEmp & "'"
        drDatosEmpleadoPlanilla = cmdInComando.ExecuteReader
        drDatosEmpleadoPlanilla.Read()
    End Function
    Public Function PlanillaCerrada(ByVal intAnio As Int16, ByVal intMes As Int16, ByVal intNoPlani As Int16) As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drDatos As SqlClient.SqlDataReader

        PlanillaCerrada = False
        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT * FROM PLPlanillasCerradas WHERE Año=" & intAnio & " AND Mes=" & intMes & " AND NoPlanilla=" & intNoPlani
        drDatos = cmdInComando.ExecuteReader
        drDatos.Read()
        If drDatos.HasRows Then
            PlanillaCerrada = True
        End If
        cnSQLConexion.Close()
    End Function
    Public Function ObtenerUltimaPlanillaCerrada(ByRef intAnio As Int16, ByRef intMes As Int16, ByRef intNoPlani As Int16) As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drDatos As SqlClient.SqlDataReader

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT TOP 1 Año,Mes,NoPlanilla FROM PLPlanillasCerradas ORDER BY Año DESC,Mes DESC,NoPlanilla DESC"
        drDatos = cmdInComando.ExecuteReader
        drDatos.Read()
        If drDatos.HasRows Then
            ObtenerUltimaPlanillaCerrada = True
            intAnio = drDatos("Año")
            intMes = drDatos("Mes")
            intNoPlani = drDatos("NoPlanilla")
        Else
            ObtenerUltimaPlanillaCerrada = False
            intAnio = 0
            intMes = 0
            intNoPlani = 0
        End If
        cnSQLConexion.Close()

    End Function

    Public Function PlanillaConDatos(ByVal intAnio As Int16, ByVal intMes As Int16, ByVal intNoPlani As Int16) As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drDatos As SqlClient.SqlDataReader

        PlanillaConDatos = False
        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT * FROM PLPlanillas WHERE Año=" & intAnio & " AND Mes=" & intMes & " AND NoPlanilla=" & intNoPlani
        drDatos = cmdInComando.ExecuteReader
        drDatos.Read()
        If drDatos.HasRows Then
            PlanillaConDatos = True
        End If
        cnSQLConexion.Close()
    End Function
    Public Function drListaDeducciones() As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT CodigoDeduccion,DescripcionDeduccion FROM PLDefinicionDeducciones ORDER BY CodigoDeduccion"
        drListaDeducciones = cmdInComando.ExecuteReader        
    End Function
    Public Function drDeduccionesPend(ByVal strEmp As String) As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT PLDeducciones.CodigoDeduccion, PLDeducciones.CodigoEmpleado, PLDeducciones.Valor, PLDefinicionDeducciones.DescripcionDeduccion FROM PLDeducciones INNER JOIN PLDefinicionDeducciones " _
            & "ON PLDeducciones.CodigoDeduccion=PLDefinicionDeducciones.CodigoDeduccion WHERE PLDeducciones.CodigoEmpleado='" & strEmp & "' AND PLDeducciones.Anulada=0 AND (PLDeducciones.Valor<PLDeducciones.MontoDeducido OR " _
            & "PLDeducciones.DeduccionPermanente=1)"
        drDeduccionesPend = cmdInComando.ExecuteReader
    End Function
    Public Function drCalcDeducciones(ByVal strDed As String) As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT * FROM PLCalculoDeducciones WHERE Deduccion='" & strDed & "' ORDER BY Reg"
        drCalcDeducciones = cmdInComando.ExecuteReader
        drCalcDeducciones.Read()
    End Function
    Public Function drDatosSedesPlanilla(ByVal strSede As String) As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT * FROM PLSedes WHERE CodigoSede='" & strSede & "' ORDER BY CodigoSede"
        drDatosSedesPlanilla = cmdInComando.ExecuteReader
        drDatosSedesPlanilla.Read()
    End Function
    Public Function drDeduccionISR(ByVal intAño As Int16, ByVal strEmpleado As String) As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT * FROM PLDeduccionISR WHERE Año=" & intAño & " AND CodigoEmpleado='" & strEmpleado & "'"
        drDeduccionISR = cmdInComando.ExecuteReader
        drDeduccionISR.Read()
    End Function
    Public Function drDefDeducciones(ByVal strDeduccion As String) As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        If strDeduccion <> "" Then
            cmdInComando.CommandText = "SELECT * FROM PLDefinicionDeducciones WHERE CodigoDeduccion='" & strDeduccion & "' ORDER BY CodigoDeduccion"
        Else
            cmdInComando.CommandText = "SELECT * FROM PLDefinicionDeducciones ORDER BY CodigoDeduccion"
        End If
        drDefDeducciones = cmdInComando.ExecuteReader
        If strDeduccion <> "" Then
            drDefDeducciones.Read()
        End If
    End Function
    Public Function ExisteDeduccion(ByVal strDeduccion As String) As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drDefDeducciones As SqlClient.SqlDataReader

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT CodigoDeduccion FROM PLDefinicionDeducciones WHERE CodigoDeduccion='" & strDeduccion & "'"
        drDefDeducciones = cmdInComando.ExecuteReader
        drDefDeducciones.Read()
        If drDefDeducciones.HasRows Then
            ExisteDeduccion = True
        Else
            ExisteDeduccion = False
        End If
        drDefDeducciones.Close()
        cnSQLConexion.Close()
    End Function
    Public Function ExisteEmpleado(ByVal strEmp As String) As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drDefDeducciones As SqlClient.SqlDataReader

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT CodigoEmpleado FROM PLEmpleados WHERE CodigoEmpleado='" & strEmp & "'"
        drDefDeducciones = cmdInComando.ExecuteReader
        drDefDeducciones.Read()
        If drDefDeducciones.HasRows Then
            ExisteEmpleado = True
        Else
            ExisteEmpleado = False
        End If
        drDefDeducciones.Close()
        cnSQLConexion.Close()
    End Function

    Public Function ObtenerImpVecinal(ByVal intAño As Int16, ByVal strEmpleado As String) As Decimal
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drDeduccionImpVecinal As SqlClient.SqlDataReader

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT * FROM PLDeduccionImpuestoVecinal WHERE Año=" & intAño & " AND CodigoEmpleado='" & strEmpleado & "'"
        drDeduccionImpVecinal = cmdInComando.ExecuteReader
        drDeduccionImpVecinal.Read()
        If drDeduccionImpVecinal.HasRows Then
            ObtenerImpVecinal = drDeduccionImpVecinal("ValorDeduccion")
        Else
            ObtenerImpVecinal = 0
        End If
        drDeduccionImpVecinal.Close()
        cnSQLConexion.Close()
    End Function

    Public Function ObtenerComisionAnterior(ByVal strEmp As String, ByVal intAño As Int16, ByVal intMes As Int16, ByVal intNoPlani As Int16) As Decimal
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drDatos As SqlClient.SqlDataReader

        ObtenerComisionAnterior = 0
        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT SueldoNormal,Comisiones FROM PLPlanillas WHERE CodigoEmpleado='" & strEmp & "' AND Año=" & intAño & " AND Mes=" & intMes & " AND NoPlanilla=" & intNoPlani - 1
        drDatos = cmdInComando.ExecuteReader
        drDatos.Read()
        If drDatos.HasRows Then
            ObtenerComisionAnterior = drDatos("SueldoNormal") + drDatos("Comisiones")
        End If
        drDatos.Close()
        cnSQLConexion.Close()
    End Function
    Public Function ObtenerDeduccionesAnteriores(ByVal strDed As String, ByVal strEmp As String, ByVal intAño As Int16, ByVal intMes As Int16, ByVal intNoPlani As Int16) As Decimal
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drDatos As SqlClient.SqlDataReader

        ObtenerDeduccionesAnteriores = 0
        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT SeguroSocial,RAP FROM PLPlanillas WHERE CodigoEmpleado='" & strEmp & "' AND Año=" & intAño & " AND Mes=" & intMes & " AND NoPlanilla=" & intNoPlani - 1
        drDatos = cmdInComando.ExecuteReader
        drDatos.Read()
        If drDatos.HasRows Then
            ObtenerDeduccionesAnteriores = drDatos(strDed)
        End If
        drDatos.Close()
        cnSQLConexion.Close()
    End Function
    Public Function ObtenerValorDeduccion(ByVal strDeduccion As String, ByVal strEmp As String, Optional intNoPlani As Int16 = 1) As Decimal
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drDatos As SqlClient.SqlDataReader

        ObtenerValorDeduccion = 0
        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT * FROM PLDeducciones WHERE CodigoDeduccion='" & strDeduccion & "' AND CodigoEmpleado='" & strEmp & "'"
        drDatos = cmdInComando.ExecuteReader
        drDatos.Read()
        If strDeduccion = "ISR" Then
            If drDatos.HasRows Then
                ObtenerValorDeduccion = drDatos("DeduccionPlanilla" & Trim(Str(intNoPlani)))
            Else
                ObtenerValorDeduccion = 0
            End If
        ElseIf strDeduccion = "IHSS" Then
            If drDatos.HasRows Then
                ObtenerValorDeduccion = drDatos("Valor")
            Else
                ObtenerValorDeduccion = 0
            End If
        End If

        drDatos.Close()
        cnSQLConexion.Close()
    End Function
    Public Function ObtenerDiasVacaciones(ByVal intAños As Int16) As Int16
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drDatos As SqlClient.SqlDataReader

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT * FROM PLTablaDiasVacaciones WHERE AñosLaborados=" & intAños
        drDatos = cmdInComando.ExecuteReader
        drDatos.Read()
        If drDatos.HasRows Then
            ObtenerDiasVacaciones = drDatos("DiasVacaciones")
        Else
            ObtenerDiasVacaciones = 0
        End If
        drDatos.Close()
        cnSQLConexion.Close()
    End Function
    Public Sub BorrarOtrasDeducciones(ByVal strEmp As String, ByVal intAño As Int16, ByVal intMes As Int16, ByVal intNoPlani As Int16, ByVal boBorrarTodo As Boolean)
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        If boBorrarTodo Then
            cmdInComando.CommandText = "DELETE FROM PLPlanillasOT WHERE  Año=" & intAño & " AND Mes=" & intMes & " AND NoPlanilla=" & intNoPlani
        Else
            cmdInComando.CommandText = "DELETE FROM PLPlanillasOT WHERE  CodigoEmpleado='" & strEmp & "' AND Año=" & intAño & " AND Mes=" & intMes & " AND NoPlanilla=" & intNoPlani
        End If

        cmdInComando.ExecuteNonQuery()
        cnSQLConexion.Close()
    End Sub
    Public Function DescripcionPlanilla(ByVal intNoPlanilla As Int16) As String
        Dim RSICls As New Rsierpgencl.Rsierpcl.Cadenas
        Dim strDescPlani As String
        Dim drCnf As SqlClient.SqlDataReader

        drCnf = drConf()
        If intNoPlanilla = drCnf("NoPlanillaVacaciones") Then
            strDescPlani = "Planilla de Vacaciones de " & RSICls.MesLetras(drCnf("MesEnProceso")) & " de " & drCnf("AñoEnProceso")
        ElseIf intNoPlanilla = drCnf("NoPlanilla13vo") Then
            strDescPlani = "Planilla del 13vo Mes de " & drCnf("AñoEnProceso")
        ElseIf intNoPlanilla = drCnf("NoPlanilla14vo") Then
            strDescPlani = "Planilla del 14vo Mes de " & drCnf("AñoEnProceso")
        Else
            strDescPlani = "Planilla " & intNoPlanilla & " de " & drCnf("PlanillasPorMes") & " del Mes de " & RSICls.MesLetras(drCnf("MesEnProceso")) & " de " & drCnf("AñoEnProceso")
        End If
        DescripcionPlanilla = strDescPlani
    End Function
    Public Function ObtenerDiasTablasPrestaciones(ByVal decValor As Decimal, ByVal strTipo As String) As Int16
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drDatos As SqlClient.SqlDataReader

        ObtenerDiasTablasPrestaciones = 0
        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        If strTipo = "PREAVISO" Then
            cmdInComando.CommandText = "SELECT Dias FROM PLTablaPreaviso WHERE RangoInicialMeses<=" & decValor & " AND RangoFinalMeses>=" & decValor 'Valor en Meses
        ElseIf strTipo = "CESANTIA" Then
            cmdInComando.CommandText = "SELECT Dias FROM PLTablaCesantia WHERE RangoInicialMeses<=" & decValor & " AND RangoFinalMeses>=" & decValor 'Valor en Meses
        ElseIf strTipo = "VACPROPOR" Then
            cmdInComando.CommandText = "SELECT Valor FROM PLTablaVacacionesProporcionales WHERE RangoInicialAño<=" & decValor & " AND RangoFinalAño>=" & decValor 'Valor en años
        End If

        drDatos = cmdInComando.ExecuteReader
        drDatos.Read()
        If drDatos.HasRows Then
            If strTipo = "PREAVISO" Or strTipo = "CESANTIA" Then
                ObtenerDiasTablasPrestaciones = drDatos("Dias")
            Else
                ObtenerDiasTablasPrestaciones = drDatos("Valor")
            End If
        Else
            ObtenerDiasTablasPrestaciones = 0
        End If
        drDatos.Close()
        cnSQLConexion.Close()

    End Function
    Public Function ExisteCalculoPrestaciones(ByVal strEmpleado As String) As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drDatos As SqlClient.SqlDataReader

        ExisteCalculoPrestaciones = False
        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT CodigoEmpleado FROM PLPrestaciones WHERE CodigoEmpleado='" & strEmpleado & "'"
        drDatos = cmdInComando.ExecuteReader
        drDatos.Read()
        If drDatos.HasRows Then
            ExisteCalculoPrestaciones = True
        End If
        drDatos.Close()
        cnSQLConexion.Close()
    End Function
    Public Function ExisteCalculoISR(ByVal intAnio As Integer) As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drDatos As SqlClient.SqlDataReader

        ExisteCalculoISR = False
        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT Año FROM PLDeduccionISR WHERE Año=" & intAnio
        drDatos = cmdInComando.ExecuteReader
        drDatos.Read()
        If drDatos.HasRows Then
            ExisteCalculoISR = True
        End If
        drDatos.Close()
        cnSQLConexion.Close()
    End Function
    Public Function drObtenerUltimasPlanillas(ByVal strEmpleado As String, ByVal IntNoPlanillas As Int16) As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT TOP (" & IntNoPlanillas & ") Año, Mes, NoPlanilla, CodigoEmpleado, DiasTrabajados, SueldoNormal, (ValorHorasExtras25 + ValorHorasExtras50 + ValorHorasExtras75 + ValorHorasExtrasDobles) AS HorasExtras, " _
            & "Bonificaciones FROM PLPlanillas WHERE CodigoEmpleado='" & strEmpleado & "' ORDER BY CodigoEmpleado DESC, Año DESC, Mes DESC, NoPlanilla DESC"
        drObtenerUltimasPlanillas = cmdInComando.ExecuteReader
    End Function
    Public Function EmpleadoConSaldoPendiente(ByVal strEmpleado As String) As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drDatos As SqlClient.SqlDataReader

        Try
            EmpleadoConSaldoPendiente = False
            cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = "SELECT Valor,MontoDeducido FROM PLDeducciones WHERE CodigoEmpleado='" & strEmpleado & "' AND Valor > MontoDeducido AND DeduccionPermanente=0 AND Anulada=0"
            drDatos = cmdInComando.ExecuteReader
            drDatos.Read()
            If drDatos.HasRows Then
                EmpleadoConSaldoPendiente = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            drDatos.Close()
            cnSQLConexion.Close()
        End Try
    End Function
    Public Function drObtenerDeduccionesPendientes(ByVal strEmpleado As String) As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        'cmdInComando.CommandText = "SELECT CodigoDeduccion,NoDocumento,(Valor-MontoDeducido) AS Saldo FROM PLDeducciones WHERE CodigoEmpleado='" & strEmpleado & "' AND Valor > MontoDeducido AND DeduccionPermanente=0 AND Anulada=0" 15/01/2011
        cmdInComando.CommandText = "SELECT CodigoDeduccion,NoDocumento,(Valor-MontoDeducido) AS Saldo FROM PLDeducciones WHERE CodigoEmpleado='" & strEmpleado & "' AND Valor > MontoDeducido AND  Anulada=0"
        drObtenerDeduccionesPendientes = cmdInComando.ExecuteReader
    End Function
    Public Function drObtenerVacacionesPendientes(ByVal strEmpleado As String) As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT * FROM PLVacaciones WHERE CodigoEmpleado='" & strEmpleado & "' AND DiasCuentaVacaciones + DiasGozadosVacaciones < DiasVacaciones"
        drObtenerVacacionesPendientes = cmdInComando.ExecuteReader

    End Function
    Public Function ActualizarDiasTomadosVacaciones(ByVal decDias As Decimal, ByVal decValorPagado As Decimal, ByVal strSigno As String, ByVal IntIDVac As Int32) As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        Try
            cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            If strSigno = "+" Then
                If decValorPagado > 0 Then
                    cmdInComando.CommandText = "UPDATE PLVacaciones SET DiasPagados=DiasPagados +" & decDias & ",ValorPagado=ValorPagado +" & decValorPagado & " WHERE IDVacacion=" & IntIDVac
                Else
                    cmdInComando.CommandText = "UPDATE PLVacaciones SET DiasGozadosVacaciones=DiasGozadosVacaciones +" & decDias & " WHERE IDVacacion=" & IntIDVac
                End If
            Else
                If decValorPagado > 0 Then
                    cmdInComando.CommandText = "UPDATE PLVacaciones SET DiasPagados=DiasPagados -" & decDias & ",ValorPagado=ValorPagado -" & decValorPagado & " WHERE IDVacacion=" & IntIDVac
                Else
                    cmdInComando.CommandText = "UPDATE PLVacaciones SET DiasGozadosVacaciones=DiasGozadosVacaciones -" & decDias & " WHERE IDVacacion=" & IntIDVac
                End If
            End If
            cmdInComando.ExecuteNonQuery()
            ActualizarDiasTomadosVacaciones = True
        Catch ex As Exception
            ActualizarDiasTomadosVacaciones = False
            MsgBox(ex.Message)
        Finally
            cnSQLConexion.Close()
        End Try
    End Function
    Public Sub AnularDeduccionesEmpleado(ByVal strEmpleado As String)
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        Try
            cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = "UPDATE PLDeducciones SET Anulada=1 WHERE CodigoEmpleado='" & strEmpleado & "'"
            cmdInComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnSQLConexion.Close()
        End Try
    End Sub
    Public Sub AnularDeduccionISREmpleado(ByVal strEmpleado As String)
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        Try
            cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = "UPDATE PLDeduccionISR SET NoDeducir=1 WHERE CodigoEmpleado='" & strEmpleado & "'"
            cmdInComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnSQLConexion.Close()
        End Try
    End Sub
    Public Sub BorrarVacacionesResumen()
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "DELETE FROM PLVacacionesResumen"
        cmdInComando.ExecuteNonQuery()
        cnSQLConexion.Close()
    End Sub
    Public Function drVacacionesRep(ByVal strEmp As String, ByVal AnioFin As Int16) As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT * FROM PLVacaciones WHERE CodigoEmpleado='" & strEmp & "' AND AñoInicial BETWEEN " & AnioFin - 1 & " AND " & AnioFin & " AND DiasGozadosVacaciones + DiasPagados < DiasVacaciones ORDER BY CodigoEmpleado,AñoInicial"
        drVacacionesRep = cmdInComando.ExecuteReader
        'drVacacionesRep.Read()
    End Function
    Public Function drEmpVacacionesRep(ByVal AnioFin As Int16) As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT DISTINCT CodigoEmpleado FROM PLVacaciones WHERE AñoInicial BETWEEN " & AnioFin - 1 & " AND " & AnioFin & " AND DiasGozadosVacaciones + DiasPagados < DiasVacaciones ORDER BY CodigoEmpleado"
        drEmpVacacionesRep = cmdInComando.ExecuteReader
        'drEmpVacacionesRep.Read()
    End Function
    Public Function ObtenerNuevoCodigoEmpleado(strEmpInst As String) As String
        Dim drEmpleados As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim strNumEmp As String
        Dim intNumEmpleado As Int16, i As Int16

        ObtenerNuevoCodigoEmpleado = ""
        strNumEmp = ""
        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT TOP 1 CodigoEmpleado FROM PLEmpleados ORDER BY CodigoEmpleado DESC"
        drEmpleados = cmdInComando.ExecuteReader
        drEmpleados.Read()
        For i = 1 To Len(drEmpleados("CodigoEmpleado"))
            If IsNumeric(Mid(drEmpleados("CodigoEmpleado"), i, 1)) Then
                strNumEmp = strNumEmp & Mid(drEmpleados("CodigoEmpleado"), i, 1)
            End If
        Next
        intNumEmpleado = Val(strNumEmp) + 1
        If strEmpInst = "ZOE" Then
            If intNumEmpleado < 100 Then
                ObtenerNuevoCodigoEmpleado = "CSIZ-00" & Trim(Str(intNumEmpleado))
            Else
                ObtenerNuevoCodigoEmpleado = "CSIZ-0" & Trim(Str(intNumEmpleado))
            End If
        End If
    End Function
    Public Sub ClacularISRConCuadro(strEmpleado As String, intAño As Int16)
        Dim decIngAnualEstimado As Decimal, decMontoResidual As Decimal, decValorAcum As Decimal, decTramo As Decimal
        Dim decPorc(5) As Decimal
        Dim i As Int16
        Dim drDedISR As SqlClient.SqlDataReader, drTablaISR As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection, cnSQLConexion2 As Data.SqlClient.SqlConnection, cnSQLConexion3 As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand, cmdInComando2 As SqlClient.SqlCommand, cmdInComando3 As SqlClient.SqlCommand

        Try
            cnSQLConexion2 = New SqlClient.SqlConnection(DBconStr)
            cnSQLConexion2.Open()
            cmdInComando2 = cnSQLConexion2.CreateCommand
            cmdInComando2.CommandType = CommandType.Text
            cmdInComando2.CommandText = "SELECT * FROM PLTablaISR ORDER BY ValorInicial"
            drTablaISR = cmdInComando2.ExecuteReader

            cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = "SELECT * FROM PLDeduccionISR WHERE CodigoEmpleado='" & strEmpleado & "' AND Año=" & intAño
            drDedISR = cmdInComando.ExecuteReader
            drDedISR.Read()
            If drDedISR.HasRows Then
                decIngAnualEstimado = 0
                For i = 1 To 12
                    decIngAnualEstimado = decIngAnualEstimado + drDedISR("SueldoMes" & Trim(Str(i)))
                    decIngAnualEstimado = decIngAnualEstimado + drDedISR("OtrosIngresosMes" & Trim(Str(i)))
                Next
                decIngAnualEstimado = decIngAnualEstimado - drDedISR("GastosMedicos") - drDedISR("SeguroSocial") - drDedISR("Donaciones") - drDedISR("OtrosDescuentos")
                decMontoResidual = decIngAnualEstimado
                For i = 0 To 4
                    decPorc(i) = 0
                Next
                i = 0
                While drTablaISR.Read
                    If decMontoResidual <= 0 Then 'c1truedbgrdTablaISR.Columns("Valor Inicial").Value Then
                        Exit While
                    End If
                    decTramo = drTablaISR("ValorFinal") - Math.Round(drTablaISR("ValorInicial"), 2)
                    If decTramo <= decMontoResidual Then
                        decValorAcum = decValorAcum + (Math.Round(decTramo * (drTablaISR("Porcentaje") / 100), 2))
                        decPorc(i) = Math.Round(decTramo * (drTablaISR("Porcentaje") / 100), 2)
                    End If
                    If decTramo > decMontoResidual Then
                        decValorAcum = decValorAcum + (Math.Round(decMontoResidual * (drTablaISR("Porcentaje") / 100), 2))
                        decPorc(i) = Math.Round(decMontoResidual * (drTablaISR("Porcentaje") / 100), 2)
                    End If
                    decMontoResidual = decMontoResidual - decTramo
                    i = i + 1
                End While

                cnSQLConexion3 = New SqlClient.SqlConnection(DBconStr)
                cnSQLConexion3.Open()
                cmdInComando3 = cnSQLConexion3.CreateCommand
                cmdInComando3.CommandType = CommandType.Text
                cmdInComando3.CommandText = "UPDATE PLDeduccionISR SET Porcentaje1=" & decPorc(0) & ",Porcentaje2=" & decPorc(1) & ",Porcentaje3=" & decPorc(2) _
                    & ",Porcentaje4=" & decPorc(3) & ",Porcentaje5=" & decPorc(4) & " WHERE CodigoEmpleado='" & strEmpleado & "' AND Año=" & intAño
                cmdInComando3.ExecuteNonQuery()
                cnSQLConexion3.Close()
            End If
            cnSQLConexion.Close()
            cnSQLConexion2.Close()            
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub New()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
