Public Class CTClass
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
        cmdInComando.CommandText = "SELECT * FROM CTConf"
        drConf = cmdInComando.ExecuteReader
        drConf.Read()
    End Function
    Public Function drCatalogo() As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT * FROM CTCatalogoCuentas"
        drCatalogo = cmdInComando.ExecuteReader
    End Function
    Public Function drDatosCuenta(strCuenta As String) As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT * FROM CTCatalogoCuentas WHERE Cuenta='" & strCuenta & "'"
        drDatosCuenta = cmdInComando.ExecuteReader
        drDatosCuenta.Read()
    End Function
    Public Function drSaldosMensuales(strCuenta As String, intAnio As Int16) As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT * FROM CTSaldosMensuales WHERE Cuenta='" & strCuenta & "' AND Año=" & intAnio & " ORDER BY Año,Mes"
        drSaldosMensuales = cmdInComando.ExecuteReader
        'drSaldosMensuales.Read()
    End Function
    Public Function drTransaccionesDetalleTotales(intAño As Int16, intMes As Int16, mSoloDescuadradas As Boolean) As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        If mSoloDescuadradas Then
            cmdInComando.CommandText = "SELECT CTTransaccionesDetalle.NoTransaccion,CTTransaccionesDetalle.Fecha, SUM(CTTransaccionesDetalle.Debe) AS TotalDebe, SUM(CTTransaccionesDetalle.Haber) AS TotalHaber " _
                                        & "FROM CTTransaccionesDetalle INNER JOIN CTTransaccionesEncabezado ON CTTransaccionesDetalle.NoTransaccion = CTTransaccionesEncabezado.NoTransaccion " _
                                        & "WHERE (CTTransaccionesDetalle.Año = " & intAño & ") AND (CTTransaccionesDetalle.Mes =" & intMes & ") GROUP BY CTTransaccionesDetalle.NoTransaccion,CTTransaccionesDetalle.Fecha " _
                                        & "HAVING SUM(CTTransaccionesDetalle.Debe) <> SUM(CTTransaccionesDetalle.Haber)"
        Else
            cmdInComando.CommandText = "SELECT CTTransaccionesDetalle.NoTransaccion,CTTransaccionesDetalle.Fecha, SUM(CTTransaccionesDetalle.Debe) AS TotalDebe, SUM(CTTransaccionesDetalle.Haber) AS TotalHaber " _
                                        & "FROM CTTransaccionesDetalle INNER JOIN CTTransaccionesEncabezado ON CTTransaccionesDetalle.NoTransaccion = CTTransaccionesEncabezado.NoTransaccion " _
                                        & "WHERE (CTTransaccionesDetalle.Año = " & intAño & ") AND (CTTransaccionesDetalle.Mes =" & intMes & ") GROUP BY CTTransaccionesDetalle.NoTransaccion,CTTransaccionesDetalle.Fecha"
        End If
            drTransaccionesDetalleTotales = cmdInComando.ExecuteReader
    End Function
    Public Function drTransaccionesDetalleTotalesCuentas(intAño As Int16, intMes As Int16) As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT CTTransaccionesDetalle.Cuenta, SUM(CTTransaccionesDetalle.Debe) AS TotalDebe, SUM(CTTransaccionesDetalle.Haber) AS TotalHaber " _
                                    & "FROM CTTransaccionesDetalle INNER JOIN CTTransaccionesEncabezado ON CTTransaccionesDetalle.NoTransaccion = CTTransaccionesEncabezado.NoTransaccion " _
                                    & "WHERE (CTTransaccionesDetalle.Año =" & intAño & ") AND (CTTransaccionesDetalle.Mes =" & intMes & ") AND (CTTransaccionesEncabezado.Anulado = 0) " _
                                    & "GROUP BY CTTransaccionesDetalle.Cuenta ORDER BY CTTransaccionesDetalle.Cuenta"
        drTransaccionesDetalleTotalesCuentas = cmdInComando.ExecuteReader
    End Function
    Public Function ActualizarTablaSaldosDeCatalogo(intAño As Int16, intMes As Int16) As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        Try
            cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = "INSERT INTO CTSaldosMensuales (Año,Mes,Cuenta,CuentaSuperior,Nivel,Naturaleza) SELECT " & intAño & "," & intMes & ", Cuenta, CuentaSuperior,Nivel,Naturaleza " _
                & " FROM CTCatalogoCuentas WHERE NOT EXISTS (SELECT 1 FROM CTSaldosMensuales WHERE CTSaldosMensuales.Cuenta = CTCatalogoCuentas.Cuenta AND CTSaldosMensuales.Año=" & intAño & " AND CTSaldosMensuales.Mes=" & intMes & ")"
            'INSERT INTO CTSaldosMensuales (Año,Mes,Cuenta) SELECT 2013,7,CTCatalogoCuentas.Cuenta 
            'FROM CTCatalogoCuentas WHERE NOT EXISTS (SELECT * FROM CTSaldosMensuales WHERE CTSaldosMensuales.Cuenta = CTCatalogoCuentas.Cuenta AND CTSaldosMensuales.Año=2013 AND CTSaldosMensuales.Mes=7)
            cmdInComando.ExecuteNonQuery()
            ActualizarTablaSaldosDeCatalogo = True
        Catch e As Exception
            ActualizarTablaSaldosDeCatalogo = False
            _ErrorMsg = Err.Description
        Finally
            cnSQLConexion.Close()
        End Try
    End Function
    Public Function ActualizarTablaSaldosDeTransacciones(intAño As Int16, intMes As Int16) As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        Try
            cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = "UPDATE CTSaldosMensuales SET CTSaldosMensuales.DebitosMes=Fuente.TotDebe,CTSaldosMensuales.CreditosMes=Fuente.TotHaber FROM CTSaldosMensuales " _
                & "INNER JOIN (SELECT Cuenta,Año,Mes,SUM(Debe) AS TotDebe,SUM(Haber) AS TotHaber FROM CTTransaccionesDetalle GROUP BY Cuenta,Año,Mes) AS Fuente " _
                & "ON Fuente.Cuenta=CTSaldosMensuales.Cuenta AND Fuente.Año=CTSaldosMensuales.Año AND Fuente.Mes=CTSaldosMensuales.Mes " _
                & "WHERE(CTSaldosMensuales.Año = " & intAño & " And CTSaldosMensuales.Mes = " & intMes & ")"
            cmdInComando.ExecuteNonQuery()
            ActualizarTablaSaldosDeTransacciones = True
        Catch e As Exception
            ActualizarTablaSaldosDeTransacciones = False
            _ErrorMsg = Err.Description
        Finally
            cnSQLConexion.Close()
        End Try
    End Function
    Public Function MayorizarCuentasSuperiores(intAño As Int16, intMes As Int16, intNivel As Int16) As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        Try
            cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = "UPDATE CTSaldosMensuales SET CTSaldosMensuales.SaldoAnterior=Fuente.SaldoIni,CTSaldosMensuales.DebitosMes=Fuente.TotDebe,CTSaldosMensuales.CreditosMes=Fuente.TotHaber FROM CTSaldosMensuales " _
                & "INNER JOIN (SELECT CuentaSuperior,Año,Mes,SUM(SaldoAnterior) AS SaldoIni,SUM(DebitosMes) AS TotDebe,SUM(CreditosMes) as TotHaber FROM CTSaldosMensuales WHERE Nivel=" & intNivel & " GROUP BY CuentaSuperior,Año,Mes HAVING CuentaSuperior IS NOT NULL) AS Fuente " _
                & "ON Fuente.CuentaSuperior=CTSaldosMensuales.Cuenta AND Fuente.Año=CTSaldosMensuales.Año AND Fuente.Mes=CTSaldosMensuales.Mes " _
                & "WHERE(CTSaldosMensuales.Año = " & intAño & " And CTSaldosMensuales.Mes =" & intMes & ")"
            cmdInComando.ExecuteNonQuery()
            MayorizarCuentasSuperiores = True
        Catch e As Exception
            MayorizarCuentasSuperiores = False
            _ErrorMsg = Err.Description
        Finally
            cnSQLConexion.Close()
        End Try
    End Function
    Public Function ActualizarTablaSaldosDebeHaber(intAño As Int16, intMes As Int16) As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        Try
            cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = "UPDATE CTSaldosMensuales SET DebitosMes=0,CreditosMes=0 WHERE Año = " & intAño & " And Mes = " & intMes
            cmdInComando.ExecuteNonQuery()
            ActualizarTablaSaldosDebeHaber = True
        Catch e As Exception
            ActualizarTablaSaldosDebeHaber = False
            _ErrorMsg = Err.Description
        Finally
            cnSQLConexion.Close()
        End Try
    End Function

    Public Function ExisteCuenta(ByVal strCta As String) As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drCat As SqlClient.SqlDataReader

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT Cuenta FROM CTCatalogoCuentas WHERE Cuenta='" & strCta & "'"
        drCat = cmdInComando.ExecuteReader
        drCat.Read()
        If drCat.HasRows Then
            ExisteCuenta = True
        Else
            ExisteCuenta = False
        End If
        drCat.Close()
        cnSQLConexion.Close()
    End Function
    Public Function DescripcionCuenta(ByVal strCta As String) As String
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drCat As SqlClient.SqlDataReader

        DescripcionCuenta = ""
        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT Cuenta,Descripcion FROM CTCatalogoCuentas WHERE Cuenta='" & strCta & "'"
        drCat = cmdInComando.ExecuteReader
        drCat.Read()
        If drCat.HasRows Then
            DescripcionCuenta = drCat("Descripcion")
        End If
        drCat.Close()
        cnSQLConexion.Close()
    End Function

    Public Function ObtenerPrimeraUltimaCuenta(PrimCta As Boolean) As String
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drCat As SqlClient.SqlDataReader

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        If PrimCta Then
            cmdInComando.CommandText = "SELECT TOP 1 Cuenta FROM CTCatalogoCuentas ORDER BY Cuenta"
        Else
            cmdInComando.CommandText = "SELECT TOP 1 Cuenta FROM CTCatalogoCuentas ORDER BY Cuenta DESC"
        End If
        drCat = cmdInComando.ExecuteReader
        drCat.Read()
        ObtenerPrimeraUltimaCuenta = drCat("Cuenta")
        drCat.Close()
        cnSQLConexion.Close()
    End Function
    Public Function ExisteCuentaEnTransacciones(ByVal strCta As String) As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drCat As SqlClient.SqlDataReader

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT Cuenta FROM CTTransaccionesDetalle WHERE Cuenta='" & strCta & "'"
        drCat = cmdInComando.ExecuteReader
        drCat.Read()
        If drCat.HasRows Then
            ExisteCuentaEnTransacciones = True
        Else
            ExisteCuentaEnTransacciones = False
        End If
        drCat.Close()
        cnSQLConexion.Close()
    End Function
    Public Function EsCuentaPosteable(ByVal strCta As String) As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drCat As SqlClient.SqlDataReader

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT Posteable FROM CTCatalogoCuentas WHERE Cuenta='" & strCta & "'"
        drCat = cmdInComando.ExecuteReader
        drCat.Read()
        If drCat("Posteable") Then
            EsCuentaPosteable = True
        Else
            EsCuentaPosteable = False
        End If
        drCat.Close()
        cnSQLConexion.Close()
    End Function
    Public Function drTransConCuentasNoPosteables(intAño As Int16, intMes As Int16) As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT CTTransaccionesDetalle.NoTransaccion,CTTransaccionesDetalle.Fecha,CTTransaccionesDetalle.Cuenta,CTTransaccionesDetalle.Linea,CTCatalogoCuentas.Posteable FROM CTTransaccionesDetalle INNER JOIN " _
            & "CTCatalogoCuentas ON CTTransaccionesDetalle.Cuenta=CTCatalogoCuentas.Cuenta WHERE CTCatalogoCuentas.Posteable=0"
        drTransConCuentasNoPosteables = cmdInComando.ExecuteReader
    End Function
    Public Function drTiposPartidas() As SqlClient.SqlDataReader
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT * FROM CTTiposPartidaS ORDER BY TipoPartida"
        drTiposPartidas = cmdInComando.ExecuteReader
    End Function

    Public Function ObtenerUltimaLinea(ByVal strNoDoc As String) As Int16
        Dim cnCon As SqlClient.SqlConnection
        Dim cmdIncomando As SqlClient.SqlCommand
        Dim drUltimaLinea As SqlClient.SqlDataReader

        cnCon = New SqlClient.SqlConnection(_DBconStr)
        cnCon.Open()
        cmdIncomando = cnCon.CreateCommand
        cmdIncomando.CommandType = CommandType.Text
        cmdIncomando.CommandText = "SELECT Linea FROM CTTransaccionesDetalle WHERE NoTransaccion='" & strNoDoc & "' ORDER BY NoTransaccion DESC,Linea DESC"
        drUltimaLinea = cmdIncomando.ExecuteReader
        drUltimaLinea.Read()
        If drUltimaLinea.HasRows Then
            ObtenerUltimaLinea = drUltimaLinea("Linea")
        Else
            ObtenerUltimaLinea = 0
        End If
        cnCon.Close()
    End Function
    Public Function ObtenerNoTransaccion() As Int32
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drNoTrans As SqlClient.SqlDataReader

        Try
            cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = "SELECT UltimaPartida FROM CTConf"

            drNoTrans = cmdInComando.ExecuteReader
            drNoTrans.Read()
            ObtenerNoTransaccion = drNoTrans(0) + 1
            cnSQLConexion.Close()
        Catch ex As System.Exception
            _ErrorMsg = ex.Message
            ObtenerNoTransaccion = 0
        End Try
    End Function
    Public Function EsMesCerrado(intAño As Int16, intMes As Int16) As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drCat As SqlClient.SqlDataReader

        cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT * FROM CTMesesCerrados WHERE Año=" & intAño & " AND Mes=" & intMes
        drCat = cmdInComando.ExecuteReader
        drCat.Read()
        If drCat.HasRows Then
            If drCat("Cerrado") Then
                EsMesCerrado = True
            Else
                EsMesCerrado = False
            End If
        Else
            EsMesCerrado = False
        End If
        drCat.Close()
        cnSQLConexion.Close()
    End Function
    Public Sub ActualizarUltimaTransaccion(ByVal lngNoDoc As Int32)
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        Try
            cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = "UPDATE CTConf SET UltimaPartida = " & lngNoDoc
            cmdInComando.ExecuteNonQuery()

            cnSQLConexion.Close()
        Catch ex As System.Exception
            _ErrorMsg = ex.Message
        End Try

    End Sub
    Public Sub BorrarSaldosMes(ByVal intAño As Int16, intMes As Int16)
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        Try
            cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = "DELETE CTSaldosMensuales WHERE Año=" & intAño & " AND Mes=" & intMes
            cmdInComando.ExecuteNonQuery()
        Catch ex As System.Exception
            _ErrorMsg = ex.Message
        Finally
            cnSQLConexion.Close()
        End Try
    End Sub
    Public Sub EliminarSaldosIni()
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        Try
            cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = "DELETE CTSaldosIni"
            cmdInComando.ExecuteNonQuery()
        Catch ex As System.Exception
            _ErrorMsg = ex.Message
        Finally
            cnSQLConexion.Close()
        End Try
    End Sub
    Public Class CTEstadosFinancieros
        Inherits CTClass

        Private _CTEstFDataSet As DataSet   'DataSet que contiene un DataTable con datos de la cuenta y 24 columnas correspondientes a saldos de 24 meses
        Private _CTLibroMayorDataSet As DataSet 'DataSet Para el Reporte del Libro Mayor
        Private _drCTCnf As SqlClient.SqlDataReader 'Data reader Configuración Contable
        Private _boEstFinanAños As Boolean  'Comparativo por años, meses o de 2 años
        Private _intTipoEstFinanAños As Int16   '1= Comparativo de varios años, 2=Todos los meses de un año, 3=comparativo de 2 años
        Private _intAñoIni As Int16 'Si es comparativo de varios años, en el primer tipo indica el año inicial, en el segundo, solo el año a listar. En el tercero el primer año a comparar
        Private _intAñoFin As Int16 'Si es comparativo de varios años, en el primer tipo indica el año final, en el segundo no aplica. En el tercero el segundo año a comparar
        Private _strTipoEstado As String    'BG=Balance General, ER=Estado de Resultados
        Private _intNivelMax1 As Int16  'Niveles máximos de cada grupo: Activos, Pasivo, Capital. Ingresos, Costos, Gastos
        Private _intNivelMax2 As Int16  '   "
        Private _intNivelMax3 As Int16  '   "
        Private _strAnualMensual As String  'Si los estados financieros son generales, indica si es con saldos anuales o solo del mes 
        Private _intAñoComp As Int16    'Si se va a comparar con otro año
        Private _boSuprimirCeros As Boolean 'Si se desea suprimir las cuentas que contengan ceros en todas las columnas correspondientes        
        Private _AñoEstFinan As Int16   'Año contable, ya sea proporcionado por el usuario u obtenido de la configuración contable
        Private _MesEstFinan As Int16   'Mes contable, ya sea proporcionado por el usuario u obtenido de la configuración contable
        Dim decTotPasivo(24) As Decimal, decTotCapital(24) As Decimal, decTotIngresos(24) As Decimal, decTotCostos(24) As Decimal, decTotGastos(24) As Decimal, decUtilidadPerdida(24) As Decimal   'Arreglos de 24 elementos para cada año o mes
        Dim arrTipoCuentas(3) '0=(A)ctivo/(I)ngresos, 1=(P)asivo/cos(T)os, 2=(C)apital/(G)astos
        Const CODATOS = "D"     'En el reporte general, la línea indica que es un dato
        Const COETIQUETA = "E"  'En el reporte general, la línea indica que es un tíltulo sin valores asociados
        Const COTOTALES = "T"   'En el reporte general, la línea indica que son totales y en el reporte va en negritas
        Const COLINEA = "L"     'En el reporte general, la línea indica que imprimirá una línea
        Const COBLANCO = "B"    'En el reporte general, la línea indica que imprimirá una línea en blanco
        '***************************************************************************************************************
        '* Parte de datos: 
        '* Se crean 2 datasets iguales, el segundo llamado clon, se usa para llevar la linea de una cuenta superior para 
        '* sacar de allí los totales de ese grupo de cuentas. Así con el primer dataset, se hace una lectura secuencial y
        '* con el segundo se busca una cuenta con la variable strCuentaSupAnt 
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim EstFinanDataSet As New DataSet
        Dim EstFinanDataAdapter As New SqlClient.SqlDataAdapter
        Dim cmdInComando As SqlClient.SqlCommand
        Dim cnSQLConexionClon As Data.SqlClient.SqlConnection
        Dim EstFinanDataSetClon As New DataSet
        Dim EstFinanDataAdapterClon As New SqlClient.SqlDataAdapter
        Dim cmdInComandoClon As SqlClient.SqlCommand
        'Dim LibroMayorDataSet As New DataSet    'Para reporte del Libro Mayor
        Dim LibMayReg As DataRow    'Guarda cada línea que lee del datatable LibroMayor del primer DataSet
        Dim datarowClonAnt As DataRow   'Al buscar una cuenta, la línea se guarda en esta variable
        Dim ColumnaLlave(1) As DataColumn   'Llave del datatable LibroMayor en el primer DataSet
        Dim ColumnaLlaveClon(1) As DataColumn   'Llave del datatable LibroMayor en el primer DataSet
        '*** Variables varias ***
        Dim strTipoLineaRep As String   'Tipo de línea para el reporte Datos, Etiqueta, Totales, Etc.
        Dim strCuentaSupAnt As String   'Guarda la cuenta superior de la última búsqueda realizada

        Public Property drCTCnf() As SqlClient.SqlDataReader
            Get
                Return _drCTCnf
            End Get
            Set(ByVal value As SqlClient.SqlDataReader)
                _drCTCnf = value
            End Set
        End Property

        Public Property CTEstFDataSet() As DataSet
            Get
                CTEstFDataSet = _CTEstFDataSet
            End Get
            Set(ByVal value As DataSet)
                _CTEstFDataSet = value
            End Set
        End Property
        Public Property CTLibroMayorDataSet() As DataSet
            Get
                CTLibroMayorDataSet = _CTLibroMayorDataSet
            End Get
            Set(ByVal value As DataSet)
                _CTLibroMayorDataSet = value
            End Set
        End Property
        Public Property boEstFinanAños() As Boolean
            Get
                boEstFinanAños = _boEstFinanAños
            End Get
            Set(ByVal value As Boolean)
                _boEstFinanAños = value
            End Set
        End Property
        Public Property intTipoEstFinanAños() As Int16
            Get
                intTipoEstFinanAños = _intTipoEstFinanAños
            End Get
            Set(ByVal value As Int16)
                _intTipoEstFinanAños = value
            End Set
        End Property
        Public Property strTipoEstado() As String
            Get
                strTipoEstado = _strTipoEstado
            End Get
            Set(ByVal value As String)
                _strTipoEstado = value
            End Set
        End Property
        Public Property intNivelMax1() As Int16
            Get
                intNivelMax1 = _intNivelMax1
            End Get
            Set(ByVal value As Int16)
                _intNivelMax1 = value
            End Set
        End Property
        Public Property intNivelMax2() As Int16
            Get
                intNivelMax2 = _intNivelMax2
            End Get
            Set(ByVal value As Int16)
                _intNivelMax2 = value
            End Set
        End Property
        Public Property intNivelMax3() As Int16
            Get
                intNivelMax3 = _intNivelMax3
            End Get
            Set(ByVal value As Int16)
                _intNivelMax3 = value
            End Set
        End Property
        Public Property strAnualMensual() As String
            Get
                strAnualMensual = _strAnualMensual
            End Get
            Set(ByVal value As String)
                _strAnualMensual = value
            End Set
        End Property
        Public Property intAñoComp() As Int16
            Get
                intAñoComp = _intAñoComp
            End Get
            Set(ByVal value As Int16)
                _intAñoComp = value
            End Set
        End Property
        Public Property boSuprimirCeros() As Boolean
            Get
                boSuprimirCeros = _boSuprimirCeros
            End Get
            Set(ByVal value As Boolean)
                _boSuprimirCeros = value
            End Set
        End Property
        Public Property intAñoIni() As Int16
            Get
                intAñoIni = _intAñoIni
            End Get
            Set(ByVal value As Int16)
                _intAñoIni = value
            End Set
        End Property
        Public Property intAñoFin() As Int16
            Get
                intAñoFin = _intAñoFin
            End Get
            Set(ByVal value As Int16)
                _intAñoFin = value
            End Set
        End Property

        Public Property AñoEstFinan() As Int16
            Get
                Return _AñoEstFinan
            End Get
            Set(ByVal value As Int16)
                _AñoEstFinan = value
            End Set
        End Property
        Public Property MesEstFinan() As Int16
            Get
                Return _MesEstFinan
            End Get
            Set(ByVal value As Int16)
                _MesEstFinan = value
            End Set
        End Property

        Public Sub GenerarEstadosFinancieros()
            Dim strSQL As String = "", strTabla As String = "", strSQLClon As String = ""
            Dim mNivelAnt As Integer, i As Integer, intCuentaLimite As Integer, intAño As Int16
            Dim mNivelMax As Boolean
            Dim strCuentaAnt As String  ', strCuentas(10) As String

            Try
                If strTipoEstado = "BG" Then
                    arrTipoCuentas(0) = "A" 'Activos
                    arrTipoCuentas(1) = "P" 'Pasivos
                    arrTipoCuentas(2) = "C" 'Capital
                ElseIf strTipoEstado = "ER" Then
                    arrTipoCuentas(0) = "I" 'Ingresos
                    arrTipoCuentas(1) = "T" 'Costos
                    arrTipoCuentas(2) = "G" 'Gastos
                End If
                If boEstFinanAños Then  'Estados financieros anuales exportados a Excel
                    If intTipoEstFinanAños = 1 Then 'Rango de años
                        strSQL = "SELECT CTCatalogoCuentas.Cuenta,CTCatalogoCuentas.Descripcion,CTCatalogoCuentas.Nivel,CTCatalogoCuentas.CuentaSuperior,CTCatalogoCuentas.Naturaleza,CTCatalogoCuentas.Tipo,"
                        intAño = intAñoIni
                        For i = intAñoIni To intAñoFin
                            strSQL = strSQL & "Saldos" & Trim(Str(i)) & ".Saldo" & Trim(Str(i)) & IIf(i < intAñoFin, ",", " ")
                            'eje. Saldos2013.Saldo1
                        Next
                        strSQL = strSQL & "FROM CTCatalogoCuentas "
                        For i = intAñoIni To intAñoFin
                            strTabla = "Saldos" & Trim(Str(i))
                            If strAnualMensual = "A" Then   'Anual
                                strSQL = strSQL & "LEFT JOIN (SELECT CTSaldosMensuales.Cuenta, CASE WHEN CTSaldosMensuales.Naturaleza='D' THEN CTSaldosMensuales.SaldoAnterior+CTSaldosMensuales.DebitosMes-CTSaldosMensuales.CreditosMes ELSE CTSaldosMensuales.SaldoAnterior-CTSaldosMensuales.DebitosMes+CTSaldosMensuales.CreditosMes END AS Saldo" & Trim(Str(i)) & " " _
                                    & "FROM CTSaldosMensuales WHERE CTSaldosMensuales.Año=" & i & " AND CTSaldosMensuales.Mes=12 ) AS " & strTabla & " ON CTCatalogoCuentas.Cuenta=" & strTabla & ".Cuenta "
                            Else
                                strSQL = strSQL & "LEFT JOIN (SELECT CTSaldosMensuales.Cuenta,CASE WHEN CTSaldosMensuales.Naturaleza='D' THEN CTSaldosMensuales.DebitosMes-CTSaldosMensuales.CreditosMes ELSE CTSaldosMensuales.CretidosMes-CTSaldosMensuales.DebitosMes END AS Saldo" & Trim(Str(i)) & " " _
                                    & "FROM CTSaldosMensuales WHERE CTSaldosMensuales.Año=" & i & " AND CTSaldosMensuales.Mes=12) AS " & strTabla & " ON CTCatalogoCuentas.Cuenta=" & strTabla & ".Cuenta "
                            End If
                        Next
                    ElseIf intTipoEstFinanAños = 2 Then 'Todos los meses del año
                        strSQL = "SELECT CTCatalogoCuentas.Cuenta,CTCatalogoCuentas.Descripcion,CTCatalogoCuentas.Nivel,CTCatalogoCuentas.CuentaSuperior,CTCatalogoCuentas.Naturaleza,CTCatalogoCuentas.Tipo,"
                        For i = 1 To 12
                            strSQL = strSQL & "Saldos" & Trim(Str(i)) & ".Saldo" & Trim(Str(i)) & IIf(i < 12, ",", " ")
                            'eje. Saldos2013.Saldo1,Saldos2013.Saldo2 
                        Next
                        strSQL = strSQL & "FROM CTCatalogoCuentas "
                        For i = 1 To 12
                            If strAnualMensual = "A" Then   'Anual
                                strSQL = strSQL & "LEFT JOIN (SELECT CTSaldosMensuales.Cuenta, CASE WHEN CTSaldosMensuales.Naturaleza='D' THEN CTSaldosMensuales.SaldoAnterior+CTSaldosMensuales.DebitosMes-CTSaldosMensuales.CreditosMes ELSE CTSaldosMensuales.SaldoAnterior-CTSaldosMensuales.DebitosMes+CTSaldosMensuales.CreditosMes END AS Saldo" & Trim(Str(i)) & " " _
                                    & "FROM CTSaldosMensuales WHERE CTSaldosMensuales.Año=" & intAñoIni & " AND CTSaldosMensuales.Mes=" & i & " ) AS Saldos" & Trim(Str(i)) & " ON CTCatalogoCuentas.Cuenta=Saldos" & Trim(Str(i)) & ".Cuenta "
                            Else
                                strSQL = strSQL & "LEFT JOIN (SELECT CTSaldosMensuales.Cuenta, CASE WHEN CTSaldosMensuales.Naturaleza='D' THEN CTSaldosMensuales.DebitosMes-CTSaldosMensuales.CreditosMes ELSE CTSaldosMensuales.CreditosMes-CTSaldosMensuales.DebitosMes END AS Saldo" & Trim(Str(i)) & " " _
                                    & "FROM CTSaldosMensuales WHERE CTSaldosMensuales.Año=" & intAñoIni & " AND CTSaldosMensuales.Mes=" & i & " ) AS Saldos" & Trim(Str(i)) & " ON CTCatalogoCuentas.Cuenta=Saldos" & Trim(Str(i)) & ".Cuenta "
                            End If
                        Next
                        'strSQL = strSQL & "ORDER BY CTCatalogoCuentas.Cuenta"
                    ElseIf intTipoEstFinanAños = 3 Then 'Comparativo de 2 años
                        strSQL = "SELECT CTCatalogoCuentas.Cuenta,CTCatalogoCuentas.Descripcion,CTCatalogoCuentas.Nivel,CTCatalogoCuentas.CuentaSuperior,CTCatalogoCuentas.Naturaleza,CTCatalogoCuentas.Tipo,"
                        For i = 1 To 24
                            strSQL = strSQL & "Saldos" & Trim(Str(i)) & ".Saldo" & Trim(Str(i)) & IIf(i < 24, ",", " ")
                            'eje. Saldos2013.Saldo1,Saldos2013.Saldo2 
                        Next
                        strSQL = strSQL & "FROM CTCatalogoCuentas "
                        For i = 1 To 12
                            If strAnualMensual = "A" Then   'Anual
                                strSQL = strSQL & "LEFT JOIN (SELECT CTSaldosMensuales.Cuenta, CASE WHEN CTSaldosMensuales.Naturaleza='D' THEN CTSaldosMensuales.SaldoAnterior+CTSaldosMensuales.DebitosMes-CTSaldosMensuales.CreditosMes ELSE CTSaldosMensuales.SaldoAnterior-CTSaldosMensuales.DebitosMes+CTSaldosMensuales.CreditosMes END AS Saldo" & Trim(Str(i)) & " " _
                                    & "FROM CTSaldosMensuales WHERE CTSaldosMensuales.Año=" & intAñoIni & " AND CTSaldosMensuales.Mes=" & i & " ) AS Saldos" & Trim(Str(i)) & " ON CTCatalogoCuentas.Cuenta=Saldos" & Trim(Str(i)) & ".Cuenta "
                            Else
                                strSQL = strSQL & "LEFT JOIN (SELECT CTSaldosMensuales.Cuenta, CASE WHEN CTSaldosMensuales.Naturaleza='D' THEN CTSaldosMensuales.DebitosMes-CTSaldosMensuales.CreditosMes ELSE CTSaldosMensuales.CreditosMes-CTSaldosMensuales.DebitosMes END AS Saldo" & Trim(Str(i)) & " " _
                                    & "FROM CTSaldosMensuales WHERE CTSaldosMensuales.Año=" & intAñoIni & " AND CTSaldosMensuales.Mes=" & i & " ) AS Saldos" & Trim(Str(i)) & " ON CTCatalogoCuentas.Cuenta=Saldos" & Trim(Str(i)) & ".Cuenta "
                            End If
                        Next
                        For i = 13 To 24
                            If strAnualMensual = "A" Then   'Anual
                                strSQL = strSQL & "LEFT JOIN (SELECT CTSaldosMensuales.Cuenta, CASE WHEN CTSaldosMensuales.Naturaleza='D' THEN CTSaldosMensuales.SaldoAnterior+CTSaldosMensuales.DebitosMes-CTSaldosMensuales.CreditosMes ELSE CTSaldosMensuales.SaldoAnterior-CTSaldosMensuales.DebitosMes+CTSaldosMensuales.CreditosMes END AS Saldo" & Trim(Str(i)) & " " _
                                    & "FROM CTSaldosMensuales WHERE CTSaldosMensuales.Año=" & intAñoFin & " AND CTSaldosMensuales.Mes=" & (i - 12) & " ) AS Saldos" & Trim(Str(i)) & " ON CTCatalogoCuentas.Cuenta=Saldos" & Trim(Str(i)) & ".Cuenta "
                            Else
                                strSQL = strSQL & "LEFT JOIN (SELECT CTSaldosMensuales.Cuenta, CASE WHEN CTSaldosMensuales.Naturaleza='D' THEN CTSaldosMensuales.DebitosMes-CTSaldosMensuales.CreditosMes ELSE CTSaldosMensuales.CreditosMes-CTSaldosMensuales.DebitosMes END AS Saldo" & Trim(Str(i)) & " " _
                                    & "FROM CTSaldosMensuales WHERE CTSaldosMensuales.Año=" & intAñoFin & " AND CTSaldosMensuales.Mes=" & (i - 12) & " ) AS Saldos" & Trim(Str(i)) & " ON CTCatalogoCuentas.Cuenta=Saldos" & Trim(Str(i)) & ".Cuenta "
                            End If
                        Next
                    End If
                    strSQLClon = strSQL & "ORDER BY CTCatalogoCuentas.Cuenta"
                    If strTipoEstado = "BG" Then
                        strSQL = strSQL & "WHERE CTCatalogoCuentas.Cuenta<'" & Trim(Str(drConf("IndiceIngresos"))) & "' ORDER BY CTCatalogoCuentas.Cuenta"
                    Else
                        strSQL = strSQL & "WHERE CTCatalogoCuentas.Cuenta>'" & Trim(Str(drConf("IndiceCapital"))) & "' ORDER BY CTCatalogoCuentas.Cuenta"
                    End If
                Else    'Estados financieros generales
                    If intAñoComp = 0 Then  'No se hace comparación con otro año
                        If strAnualMensual = "A" Then   'Anual
                            strSQL = "SELECT CTCatalogoCuentas.Cuenta,CTCatalogoCuentas.Descripcion,CTCatalogoCuentas.Nivel,CTCatalogoCuentas.CuentaSuperior,CTCatalogoCuentas.Naturaleza,CTCatalogoCuentas.Tipo, " _
                                & "CASE WHEN CTCatalogoCuentas.Naturaleza='D' THEN CTSaldos.SaldoAnterior+CTSaldos.DebitosMes-CTSaldos.CreditosMes ELSE CTSaldos.SaldoAnterior-CTSaldos.DebitosMes+CTSaldos.CreditosMes END AS Saldo " _
                                & "FROM CTCatalogoCuentas LEFT JOIN CTSaldosMensuales AS CTSaldos ON CTCatalogoCuentas.Cuenta=CTSaldos.Cuenta " _
                                & "WHERE CTSaldos.Año=" & AñoEstFinan & " AND CTSaldos.Mes=" & MesEstFinan & " "
                        Else    'Estado Mensual
                            strSQL = "SELECT CTCatalogoCuentas.Cuenta,CTCatalogoCuentas.Descripcion,CTCatalogoCuentas.Nivel,CTCatalogoCuentas.CuentaSuperior,CTCatalogoCuentas.Naturaleza,CTCatalogoCuentas.Tipo, " _
                                & "CASE WHEN CTCatalogoCuentas.Naturaleza='D' THEN CTSaldos.DebitosMes-CTSaldos.CreditosMes ELSE CTSaldos.CreditosMes-CTSaldos.DebitosMes END AS Saldo " _
                                & "FROM CTCatalogoCuentas LEFT JOIN CTSaldosMensuales AS CTSaldos ON CTCatalogoCuentas.Cuenta=CTSaldos.Cuenta " _
                                & "WHERE CTSaldos.Año=" & AñoEstFinan & " AND CTSaldos.Mes=" & MesEstFinan & " "
                        End If
                    Else    'Comparativo con otro año
                        If strAnualMensual = "A" Then   'Anual
                            strSQL = "SELECT CTCatalogoCuentas.Cuenta,CTCatalogoCuentas.Descripcion,CTCatalogoCuentas.Nivel,CTCatalogoCuentas.CuentaSuperior,CTCatalogoCuentas.Naturaleza,CTCatalogoCuentas.Tipo,SaldosAñoActual.Saldo,SaldosAñoComparar.SaldoComparar FROM CTCatalogoCuentas " _
                                & "LEFT JOIN (SELECT CTSaldosMensuales.Cuenta,CASE WHEN CTSaldosMensuales.Naturaleza='D' THEN CTSaldosMensuales.SaldoAnterior+CTSaldosMensuales.DebitosMes-CTSaldosMensuales.CreditosMes ELSE CTSaldosMensuales.SaldoAnterior-CTSaldosMensuales.DebitosMes+CTSaldosMensuales.CreditosMes END AS Saldo " _
                                & "FROM CTSaldosMensuales WHERE CTSaldosMensuales.Año=" & AñoEstFinan & " AND CTSaldosMensuales.Mes=" & MesEstFinan & ") AS SaldosAñoActual ON CTCatalogoCuentas.Cuenta=SaldosAñoActual.Cuenta " _
                                & "LEFT JOIN (SELECT CTSaldosMensuales.Cuenta,CASE WHEN CTSaldosMensuales.Naturaleza='D' THEN CTSaldosMensuales.SaldoAnterior+CTSaldosMensuales.DebitosMes-CTSaldosMensuales.CreditosMes ELSE CTSaldosMensuales.SaldoAnterior-CTSaldosMensuales.DebitosMes+CTSaldosMensuales.CreditosMes END AS SaldoComparar FROM CTSaldosMensuales " _
                                & "WHERE CTSaldosMensuales.Año=" & intAñoComp & " AND CTSaldosMensuales.Mes=" & MesEstFinan & ") AS SaldosAñoComparar ON CTCatalogoCuentas.Cuenta=SaldosAñoComparar.Cuenta "
                        Else
                            strSQL = "SELECT CTCatalogoCuentas.Cuenta,CTCatalogoCuentas.Descripcion,CTCatalogoCuentas.Nivel,CTCatalogoCuentas.CuentaSuperior,CTCatalogoCuentas.Naturaleza,CTCatalogoCuentas.Tipo,SaldosAñoActual.Saldo,SaldosAñoComparar.SaldoComparar FROM CTCatalogoCuentas " _
                                & "LEFT JOIN (SELECT CTSaldosMensuales.Cuenta,CASE WHEN CTSaldosMensuales.Naturaleza='D' THEN CTSaldosMensuales.DebitosMes-CTSaldosMensuales.CreditosMes ELSE CTSaldosMensuales.CreditosMes-CTSaldosMensuales.DebitosMes END AS Saldo " _
                                & "FROM CTSaldosMensuales WHERE CTSaldosMensuales.Año=" & AñoEstFinan & " AND CTSaldosMensuales.Mes=" & MesEstFinan & ") AS SaldosAñoActual ON CTCatalogoCuentas.Cuenta=SaldosAñoActual.Cuenta " _
                                & "LEFT JOIN (SELECT CTSaldosMensuales.Cuenta,CASE WHEN CTSaldosMensuales.Naturaleza='D' THEN CTSaldosMensuales.DebitosMes-CTSaldosMensuales.CreditosMes ELSE CTSaldosMensuales.CreditosMes-CTSaldosMensuales.DebitosMes END AS SaldoComparar FROM CTSaldosMensuales " _
                                & "WHERE CTSaldosMensuales.Año=" & intAñoComp & " AND CTSaldosMensuales.Mes=" & MesEstFinan & ") AS SaldosAñoComparar ON CTCatalogoCuentas.Cuenta=SaldosAñoComparar.Cuenta "
                        End If
                    End If
                    strSQLClon = strSQL & "ORDER BY CTCatalogoCuentas.Cuenta"
                    If strTipoEstado = "BG" Then
                        strSQL = strSQL & "AND CTCatalogoCuentas.Cuenta<'" & Trim(Str(drConf("IndiceIngresos"))) & "' ORDER BY CTCatalogoCuentas.Cuenta"
                    Else
                        strSQL = strSQL & "AND CTCatalogoCuentas.Cuenta>'" & Trim(Str(drConf("IndiceCapital"))) & "' ORDER BY CTCatalogoCuentas.Cuenta"
                    End If


                End If
                CTEstFDataSet.Clear()
                '* Abrir las conexiones y llenar los datatables
                cnSQLConexion = New SqlClient.SqlConnection(DBconStr)
                cmdInComando = cnSQLConexion.CreateCommand
                cmdInComando.CommandType = CommandType.Text
                cmdInComando.CommandText = strSQL

                cnSQLConexionClon = New SqlClient.SqlConnection(DBconStr)
                cmdInComandoClon = cnSQLConexionClon.CreateCommand
                cmdInComandoClon.CommandType = CommandType.Text
                cmdInComandoClon.CommandText = strSQLClon

                EstFinanDataAdapter.SelectCommand = cmdInComando
                EstFinanDataAdapter.Fill(EstFinanDataSet, "LibroMayor")
                If EstFinanDataSet.Tables("LibroMayor").Rows.Count = 0 Then
                    cnSQLConexion.Close()
                    Exit Sub
                End If

                EstFinanDataAdapterClon.SelectCommand = cmdInComandoClon
                EstFinanDataAdapterClon.Fill(EstFinanDataSetClon, "LibroMayor")
                'Colimnas llaves, en estos casos Cuenta
                ColumnaLlave(0) = EstFinanDataSet.Tables("LibroMayor").Columns(0)
                ColumnaLlaveClon(0) = EstFinanDataSetClon.Tables("LibroMayor").Columns(0)
                EstFinanDataSet.Tables("LibroMayor").PrimaryKey = ColumnaLlave
                EstFinanDataSetClon.Tables("LibroMayor").PrimaryKey = ColumnaLlaveClon

                If strTipoEstado = "BG" Then
                    intCuentaLimite = drCTCnf("IndiceIngresos") 'En el Balance la lectura secuencial termina al llegar a la cuenta de ingresos
                Else    'Estado de resultados
                    If Not IsDBNull(intCuentaLimite = drCTCnf("IndiceOrden")) Then
                        intCuentaLimite = drCTCnf("IndiceOrden")   'En el Balance la lectura secuencial termina al llegar a la cuenta de orden o en la de gastos
                    Else
                        intCuentaLimite = drCTCnf("IndiceGastos")
                    End If
                End If
                Dim RegActual As DataRow = EstFinanDataSet.Tables("LibroMayor").Rows(0) 'Para guardar valores iniciales

                mNivelAnt = 0
                'intIndiceAnt = Left(RegActual("Cuenta"), 1)
                strCuentaAnt = RegActual("Cuenta")
                strCuentaSupAnt = IIf(String.IsNullOrEmpty(RegActual("CuentaSuperior")), "", RegActual("CuentaSuperior"))
                For Each Me.LibMayReg In EstFinanDataSet.Tables("LibroMayor").Rows  'Lectura secuencial del datatable del primer dataset
                    If Left(LibMayReg("Cuenta"), 1) < intCuentaLimite Then
                        If (LibMayReg("Tipo") = arrTipoCuentas(0) And LibMayReg("Nivel") <= intNivelMax1) _
                            Or (LibMayReg("Tipo") = arrTipoCuentas(1) And LibMayReg("Nivel") <= intNivelMax2) _
                            Or (LibMayReg("Tipo") = arrTipoCuentas(2) And LibMayReg("Nivel") <= intNivelMax3) Then

                            mNivelMax = (LibMayReg("Tipo") = arrTipoCuentas(0) And LibMayReg("Nivel") = intNivelMax1) _
                                Or (LibMayReg("Tipo") = arrTipoCuentas(1) And LibMayReg("Nivel") = intNivelMax2) _
                                Or (LibMayReg("Tipo") = arrTipoCuentas(2) And LibMayReg("Nivel") = intNivelMax3)

                            If Left(LibMayReg("Cuenta"), 1) = 3 Then
                                Dim cta As String = LibMayReg("Cuenta")
                            End If
                            If mNivelAnt > LibMayReg("Nivel") Then  'La cuenta que continúa tiene un nivel menor, quiere decir que se ha terminado con un bloque de cuentas y se debe de presentar totales
                                '* Ej. 1101001    nivel 4
                                '*     1101004    nivel 4
                                '* --> 1102       nivel 3   Totalizar cuentas del nivel 4, mNivelAnt=4, Nivel=3)
                                '*** Grabar datos totales ***
                                strTipoLineaRep = COTOTALES
                                GrabarRegEstFinan()
                                For i = 1 To 10 'Número total de niveles
                                    If mNivelAnt - i > LibMayReg("Nivel") Then  'Verificar 
                                        '* Ej. 1101001    nivel 4
                                        '*     1101004    nivel 4
                                        '* --> 1102       nivel 3  en el primer ciclo i=1, mNivelAnt=4, 4-i=3, 3 es mayor que el siguiente nivel, Nivel=2. Se totalizan las cuentas del nivel 3
                                        '*                         en el ciclo no. 2 i=2, mNivelAnt=4, nivel=3, 4-2=2, no realiza los siguientes pasos      
                                        strCuentaSupAnt = datarowClonAnt("CuentaSuperior")
                                        strTipoLineaRep = COTOTALES
                                        GrabarRegEstFinan()
                                    Else
                                        Exit For
                                    End If
                                Next
                            End If
                            If Not mNivelMax Then   'Si no es el nivel máximo, graba el registro, eje. 12 nivel 2
                                strTipoLineaRep = COETIQUETA
                                GrabarRegEstFinan()
                            Else    'Si es nivel máximo, graba los datos y valores. Ej. 1101001    nivel 4, el reporte se pidió en activos a nivel 4
                                strTipoLineaRep = CODATOS
                                GrabarRegEstFinan()
                            End If
                            '* Guardar los datos del nivel actual para compararlo con los del siguiente nivel
                            mNivelAnt = LibMayReg("Nivel")
                            strCuentaAnt = LibMayReg("Cuenta")
                            strCuentaSupAnt = IIf(String.IsNullOrEmpty(LibMayReg("CuentaSuperior")), "", LibMayReg("CuentaSuperior"))
                        End If
                    End If
                Next
                strTipoLineaRep = COTOTALES
                GrabarRegEstFinan()

                '*** Obtener Resultado ***
                For i = 0 To 23
                    decTotCapital(i) = 0
                    decTotCostos(i) = 0
                    decTotGastos(i) = 0
                    decTotIngresos(i) = 0
                    decTotPasivo(i) = 0
                    decUtilidadPerdida(i) = 0
                Next
                ObtenerResultadosPeriodo()

                For i = 0 To 23
                    decUtilidadPerdida(i) = decTotIngresos(i) - decTotCostos(i) - decTotGastos(i)
                Next

                '*** Grabar Utilitad o Perdida ***
                Dim NuevoReg As DataRow = CTEstFDataSet.Tables("CTEstFinanDataTable").NewRow
                NuevoReg("Tipo") = COTOTALES
                NuevoReg("Descripcion") = "RESULTADO DEL PERIODO"
                'NuevoReg("Descripcion") = "UTILIDAD / PERDIDA"
                For i = 0 To 23
                    NuevoReg("ValorA" & Trim(Str(i + 1))) = decUtilidadPerdida(i)
                Next
                CTEstFDataSet.Tables("CTEstFinanDataTable").Rows.Add(NuevoReg)

                If strTipoEstado = "BG" Then
                    '*** Grabar Pasivo y Capital ***
                    NuevoReg = CTEstFDataSet.Tables("CTEstFinanDataTable").NewRow
                    'NuevoReg("Numero") = intContador + 1
                    NuevoReg("Tipo") = COTOTALES
                    NuevoReg("Descripcion") = "SUMA PASIVO Y CAPITAL"
                    For i = 0 To 23
                        NuevoReg("ValorA" & Trim(Str(i + 1))) = decTotPasivo(i) + decTotCapital(i) + decUtilidadPerdida(i)
                    Next
                    CTEstFDataSet.Tables("CTEstFinanDataTable").Rows.Add(NuevoReg)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Finally
                cnSQLConexion.Close()
                cnSQLConexionClon.Close()
            End Try
        End Sub
        Private Sub GrabarRegEstFinan()
            Dim decTotalSaldos As Decimal

            Try
                If boSuprimirCeros And strTipoLineaRep = CODATOS Then 'Si se suprimen los saldos en cero
                    decTotalSaldos = 0
                    If Not boEstFinanAños Then
                        decTotalSaldos = decTotalSaldos + IIf(IsDBNull(LibMayReg("Saldo")), 0, LibMayReg("Saldo"))
                        If intAñoComp > 0 Then
                            decTotalSaldos = decTotalSaldos + IIf(IsDBNull(LibMayReg("SaldoComparar")), 0, LibMayReg("SaldoComparar"))
                        End If
                    Else    'Estados comparativos por Años
                        If intTipoEstFinanAños = 1 Then 'Comparativo de varios años
                            For i As Int16 = intAñoIni To intAñoFin
                                decTotalSaldos = decTotalSaldos + IIf(IsDBNull(LibMayReg("Saldo" & Trim(Str(i)))), 0, LibMayReg("Saldo" & Trim(Str(i))))
                            Next
                        ElseIf intTipoEstFinanAños = 2 Then 'Todos los meses del año
                            For i As Int16 = 1 To 12
                                decTotalSaldos = decTotalSaldos + IIf(IsDBNull(LibMayReg("Saldo" & Trim(Str(i)))), 0, LibMayReg("Saldo" & Trim(Str(i))))
                            Next
                        ElseIf intTipoEstFinanAños = 3 Then 'Comparativo de 2 años
                            For i As Int16 = 1 To 24
                                decTotalSaldos = decTotalSaldos + IIf(IsDBNull(LibMayReg("Saldo" & Trim(Str(i)))), 0, LibMayReg("Saldo" & Trim(Str(i))))
                            Next
                        End If
                    End If
                    If decTotalSaldos = 0 Then  'Si el saldo de todas las columnas sumadas es cero no continúa con el resto del procedimiento
                        Exit Sub
                    End If
                End If

                Dim NuevoReg As DataRow = CTEstFDataSet.Tables("CTEstFinanDataTable").NewRow
                NuevoReg("Tipo") = strTipoLineaRep
                If strTipoLineaRep = CODATOS Or strTipoLineaRep = COETIQUETA Then   'Solo se graba el nombre de la cuenta sin valores
                    NuevoReg("Cuenta") = LibMayReg("Cuenta")
                    NuevoReg("Descripcion") = Space(LibMayReg("Nivel") * 2) & LibMayReg("Descripcion")
                End If
                If strTipoLineaRep = COTOTALES Then 'Grabará los valores
                    Dim datarowActClon As DataRow = EstFinanDataSetClon.Tables("LibroMayor").Rows.Find(strCuentaSupAnt) 'Buscar la cuenta superior de la cuenta anterior
                    '*     Cuenta     Nivel   Cta Sup 
                    '* Ej. 1101001     4        1101
                    '*     1101004     4        1101
                    '* --> 1102        3        11      La cuenta superior anterior es 1101, Se busca esta cuenta para grabar los valores
                    datarowClonAnt = datarowActClon
                    NuevoReg("Descripcion") = Space(datarowActClon("Nivel") * 2) & "TOTAL " & datarowActClon("Descripcion")
                    GrabarSaldosEstFinan(NuevoReg, datarowActClon)
                End If
                If strTipoLineaRep = CODATOS Then   'Se graba los valores de una cuenta de nivel en el listado, ej. Si se pidió a nivel 3 en Pasivo grabará los valores
                    'Se busca en el datatable clon para no perder la secuencia en el datatable principal
                    Dim datarowActClon As DataRow = EstFinanDataSetClon.Tables("LibroMayor").Rows.Find(LibMayReg("Cuenta"))
                    datarowClonAnt = datarowActClon
                    GrabarSaldosEstFinan(NuevoReg, datarowActClon)
                End If
                CTEstFDataSet.Tables("CTEstFinanDataTable").Rows.Add(NuevoReg)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            End Try
        End Sub
        Private Sub GrabarSaldosEstFinan(NuevoRegistro As DataRow, datarowClon As DataRow)
            Dim j As Int16, intIni As Int16, intFin As Int16

            Try
                If Not boEstFinanAños Then
                    If strTipoLineaRep <> COTOTALES Then
                        NuevoRegistro("ValorA1") = IIf(IsDBNull(LibMayReg("Saldo")), 0, LibMayReg("Saldo"))
                    Else
                        NuevoRegistro("ValorA1") = IIf(IsDBNull(datarowClon("Saldo")), 0, datarowClon("Saldo"))
                    End If
                    If intAñoComp > 0 Then
                        If strTipoLineaRep <> COTOTALES Then
                            NuevoRegistro("ValorA2") = IIf(IsDBNull(LibMayReg("SaldoComparar")), 0, LibMayReg("SaldoComparar"))
                        Else
                            NuevoRegistro("ValorA2") = IIf(IsDBNull(datarowClon("SaldoComparar")), 0, datarowClon("SaldoComparar"))
                        End If
                    End If
                Else
                    If intTipoEstFinanAños = 1 Then 'Comparativo de varios años
                        intIni = intAñoIni
                        intFin = intAñoFin
                    ElseIf intTipoEstFinanAños = 2 Then 'Todos los meses del año
                        intIni = 1
                        intFin = 12
                    ElseIf intTipoEstFinanAños = 3 Then 'Comparativo de 2 años
                        intIni = 1
                        intFin = 24
                    End If
                    j = 1
                    For i As Int16 = intIni To intFin   'Ciclo para los totales por años, meses o comparativo de 2 años
                        If strTipoLineaRep <> COTOTALES Then
                            NuevoRegistro("ValorA" & Trim(Str(j))) = IIf(IsDBNull(LibMayReg("Saldo" & Trim(Str(i)))), 0, LibMayReg("Saldo" & Trim(Str(i))))
                        Else
                            NuevoRegistro("ValorA" & Trim(Str(j))) = IIf(IsDBNull(datarowClon("Saldo" & Trim(Str(i)))), 0, datarowClon("Saldo" & Trim(Str(i))))
                        End If
                        j = j + 1
                    Next
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            End Try
        End Sub
        Private Sub ObtenerResultadosPeriodo()
            Dim datarowAct As DataRow
            Dim intIni As Int16, intFin As Int16, j As Int16

            Try
                If Not boEstFinanAños Then  'Estados financieros generales
                    If strTipoEstado = "BG" Then
                        datarowAct = EstFinanDataSetClon.Tables("LibroMayor").Rows.Find(drConf("IndicePasivos"))    'Buscar la cuenta de Pasivo, ej. 2
                        decTotPasivo(0) = IIf(IsDBNull(datarowAct("Saldo")), 0, datarowAct("Saldo"))
                        If intAñoComp > 0 Then
                            decTotPasivo(1) = IIf(IsDBNull(datarowAct("SaldoComparar")), 0, datarowAct("SaldoComparar"))
                        End If

                        datarowAct = EstFinanDataSetClon.Tables("LibroMayor").Rows.Find(drConf("IndiceCapital"))    'Buscar la cuenta de Pasivo, ej. 3
                        decTotCapital(0) = IIf(IsDBNull(datarowAct("Saldo")), 0, datarowAct("Saldo"))
                        If intAñoComp > 0 Then
                            decTotCapital(1) = IIf(IsDBNull(datarowAct("SaldoComparar")), 0, datarowAct("SaldoComparar"))
                        End If
                    End If

                    datarowAct = EstFinanDataSetClon.Tables("LibroMayor").Rows.Find(drConf("IndiceIngresos"))   'Buscar la cuenta de Pasivo, ej. 4
                    decTotIngresos(0) = IIf(IsDBNull(datarowAct("Saldo")), 0, datarowAct("Saldo"))
                    If intAñoComp > 0 Then
                        decTotIngresos(1) = IIf(IsDBNull(datarowAct("SaldoComparar")), 0, datarowAct("SaldoComparar"))
                    End If

                    If drConf("IndiceCostos") > 0 Then
                        datarowAct = EstFinanDataSetClon.Tables("LibroMayor").Rows.Find(drConf("IndiceCostos")) 'Buscar la cuenta de Pasivo, ej. 5
                        If datarowAct IsNot Nothing Then
                            decTotCostos(0) = IIf(IsDBNull(datarowAct("Saldo")), 0, datarowAct("Saldo"))
                            If intAñoComp > 0 Then
                                decTotCostos(1) = IIf(IsDBNull(datarowAct("SaldoComparar")), 0, datarowAct("SaldoComparar"))
                            End If
                        End If
                    End If

                    datarowAct = EstFinanDataSetClon.Tables("LibroMayor").Rows.Find(drConf("IndiceGastos")) 'Buscar la cuenta de Pasivo, ej. 5 ó 6
                    decTotGastos(0) = IIf(IsDBNull(datarowAct("Saldo")), 0, datarowAct("Saldo"))
                    If intAñoComp > 0 Then
                        decTotGastos(1) = IIf(IsDBNull(datarowAct("SaldoComparar")), 0, datarowAct("SaldoComparar"))
                    End If
                Else    'Estado financieros comparativos por años, etc.
                    If intTipoEstFinanAños = 1 Then 'Comparativo de varios años
                        intIni = intAñoIni
                        intFin = intAñoFin
                    ElseIf intTipoEstFinanAños = 2 Then 'Todos los meses del año
                        intIni = 1
                        intFin = 12
                    ElseIf intTipoEstFinanAños = 3 Then 'Comparativo de 2 años
                        intIni = 1
                        intFin = 24
                    End If
                    If strTipoEstado = "BG" Then
                        j = 0
                        datarowAct = EstFinanDataSetClon.Tables("LibroMayor").Rows.Find(drConf("IndicePasivos"))
                        For i As Int16 = intIni To intFin
                            decTotPasivo(j) = IIf(IsDBNull(datarowAct("Saldo" & Trim(Str(i)))), 0, datarowAct("Saldo" & Trim(Str(i))))
                            j = j + 1
                        Next

                        j = 0
                        datarowAct = EstFinanDataSetClon.Tables("LibroMayor").Rows.Find(drConf("IndiceCapital"))
                        For i As Int16 = intIni To intFin
                            decTotCapital(j) = IIf(IsDBNull(datarowAct("Saldo" & Trim(Str(i)))), 0, datarowAct("Saldo" & Trim(Str(i))))
                            j = j + 1
                        Next
                    End If

                    j = 0
                    datarowAct = EstFinanDataSetClon.Tables("LibroMayor").Rows.Find(drConf("IndiceIngresos"))
                    For i As Int16 = intIni To intFin
                        decTotIngresos(j) = IIf(IsDBNull(datarowAct("Saldo" & Trim(Str(i)))), 0, datarowAct("Saldo" & Trim(Str(i))))
                        j = j + 1
                    Next

                    If drConf("IndiceCostos") > 0 Then
                        j = 0
                        datarowAct = EstFinanDataSetClon.Tables("LibroMayor").Rows.Find(drConf("IndiceCostos"))
                        If datarowAct IsNot Nothing Then
                            For i As Int16 = intIni To intFin
                                decTotCostos(j) = IIf(IsDBNull(datarowAct("Saldo" & Trim(Str(i)))), 0, datarowAct("Saldo" & Trim(Str(i))))
                                j = j + 1
                            Next
                        End If
                    End If

                    j = 0
                    datarowAct = EstFinanDataSetClon.Tables("LibroMayor").Rows.Find(drConf("IndiceGastos"))
                    For i As Int16 = intIni To intFin
                        decTotGastos(j) = IIf(IsDBNull(datarowAct("Saldo" & Trim(Str(i)))), 0, datarowAct("Saldo" & Trim(Str(i))))
                        j = j + 1
                    Next
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            End Try
        End Sub
        Public Sub LibroMayor()
            'EstFinanDataSetClon.Tables("LibroMayor").DefaultView.FindRows()
            Dim cnConSaldos As SqlClient.SqlConnection
            Dim cnConTrans As SqlClient.SqlConnection
            Dim cmdSaldosComando As SqlClient.SqlCommand
            Dim cmdTransComando As SqlClient.SqlCommand
            Dim drSaldos As SqlClient.SqlDataReader
            'Dim SaldosDataSet As New DataSet    'DataSet del Catálogo y Saldos del Mes
            'Dim SaldosDataAdapter As New SqlClient.SqlDataAdapter   'DataAdapter Respectivo
            Dim TransDataSet As New DataSet    'DataSet de las transacciones del mes
            Dim TransDataAdapter As New SqlClient.SqlDataAdapter   'DataAdapter Respectivo
            'Dim SaldosColumnaLlave(1) As DataColumn   'Llave del datatable Saldos
            Dim TransColumnaLlave(3) As DataColumn   'Llave del datatable Transacciones
            'Dim TransColBuscar(3) As String
            Dim NuevoReg As DataRow
            Dim decMovDebe As Decimal, decMovHaber As Decimal
            Dim dFecha As Date

            Try
                Dim strSQL1 As String = "", strSQL2 As String = ""

                strSQL1 = "SELECT CTCatalogoCuentas.Cuenta,CTCatalogoCuentas.Descripcion,CTCatalogoCuentas.Nivel,CTCatalogoCuentas.CuentaSuperior,CTCatalogoCuentas.Naturaleza,CTCatalogoCuentas.Tipo, CTCatalogoCuentas.Posteable," _
                    & "CTSaldosMensuales.SaldoAnterior,CTSaldosMensuales.DebitosMes,CTSaldosMensuales.CreditosMes FROM CTCatalogoCuentas LEFT JOIN CTSaldosMensuales ON CTCatalogoCuentas.Cuenta=CTSaldosMensuales.Cuenta " _
                    & "WHERE CTSaldosMensuales.Año=" & AñoEstFinan & " AND CTSaldosMensuales.Mes=" & MesEstFinan

                strSQL2 = "SELECT CTTransaccionesDetalle.Cuenta,CTTransaccionesDetalle.NoTransaccion,CTTransaccionesDetalle.Id,CTTransaccionesDetalle.Descripcion,CTTransaccionesDetalle.Debe,CTTransaccionesDetalle.Haber, " _
                    & "CTTransaccionesEncabezado.Fecha,CTTransaccionesEncabezado.TipoPartida FROM CTTransaccionesDetalle INNER JOIN CTTransaccionesEncabezado ON CTTransaccionesDetalle.NoTransaccion=CTTransaccionesEncabezado.NoTransaccion " _
                    & "WHERE CTTransaccionesDetalle.Año=" & AñoEstFinan & " AND CTTransaccionesDetalle.Mes=" & MesEstFinan & " AND CTTransaccionesEncabezado.Anulado=0 ORDER BY CTTransaccionesDetalle.Cuenta,CTTransaccionesEncabezado.Fecha"

                CTLibroMayorDataSet.Clear() 'Limpiar DataSet
                '* Abrir las conexiones y llenar los datatables
                cnConSaldos = New SqlClient.SqlConnection(DBconStr)
                cnConSaldos.Open()
                cmdSaldosComando = cnConSaldos.CreateCommand
                cmdSaldosComando.CommandType = CommandType.Text
                cmdSaldosComando.CommandText = strSQL1
                drSaldos = cmdSaldosComando.ExecuteReader
                If Not drSaldos.HasRows Then
                    cnConSaldos.Close()
                    Exit Sub
                End If

                cnConTrans = New SqlClient.SqlConnection(DBconStr)
                cmdTransComando = cnConTrans.CreateCommand
                cmdTransComando.CommandType = CommandType.Text
                cmdTransComando.CommandText = strSQL2

                TransDataAdapter.SelectCommand = cmdTransComando
                TransDataAdapter.Fill(TransDataSet, "Transacciones")
                'Columnas llaves, en este casos Cuenta, Transaccion, Id
                'TransColumnaLlave(0) = TransDataSet.Tables("Transacciones").Columns(0)
                'TransColumnaLlave(1) = TransDataSet.Tables("Transacciones").Columns(1)
                'TransColumnaLlave(2) = TransDataSet.Tables("Transacciones").Columns(2)
                'TransDataSet.Tables("Transacciones").PrimaryKey = TransColumnaLlave
                While drSaldos.Read
                    If Not drSaldos("Posteable") Then
                        If drSaldos("Cuenta") <> "1" Then
                            NuevoReg = CTLibroMayorDataSet.Tables("CTLibroMayorDataTable").NewRow
                            NuevoReg("Separador") = True
                            CTLibroMayorDataSet.Tables("CTLibroMayorDataTable").Rows.Add(NuevoReg)
                        End If
                        NuevoReg = CTLibroMayorDataSet.Tables("CTLibroMayorDataTable").NewRow
                        NuevoReg("Cuenta") = drSaldos("Cuenta")
                        NuevoReg("Descripcion") = drSaldos("Descripcion")
                        NuevoReg("SalDebe") = drSaldos("DebitosMes")
                        NuevoReg("SalHaber") = drSaldos("CreditosMes")
                        NuevoReg("Negrita") = True
                        CTLibroMayorDataSet.Tables("CTLibroMayorDataTable").Rows.Add(NuevoReg)
                    Else
                        decMovDebe = 0
                        decMovHaber = 0
                        Dim FilasEncontradas() As DataRow = TransDataSet.Tables("Transacciones").Select("Cuenta='" & drSaldos("Cuenta") & "'")
                        If FilasEncontradas.Length > 0 Then 'Tiene Movimientos
                            NuevoReg = CTLibroMayorDataSet.Tables("CTLibroMayorDataTable").NewRow
                            NuevoReg("Cuenta") = drSaldos("Cuenta")
                            NuevoReg("Descripcion") = drSaldos("Descripcion")
                            CTLibroMayorDataSet.Tables("CTLibroMayorDataTable").Rows.Add(NuevoReg)
                        End If
                        For Each TransReg In FilasEncontradas
                            dFecha = TransReg("Fecha")
                            NuevoReg = CTLibroMayorDataSet.Tables("CTLibroMayorDataTable").NewRow
                            NuevoReg("Dia") = dFecha.Day
                            NuevoReg("Descripcion") = TransReg("Descripcion")
                            NuevoReg("Tipo") = TransReg("TipoPartida")
                            NuevoReg("Partida") = TransReg("NoTransaccion")
                            NuevoReg("MovDebe") = TransReg("Debe")
                            NuevoReg("MovHaber") = TransReg("Haber")
                            decMovDebe = decMovDebe + TransReg("Debe")
                            decMovHaber = decMovHaber + TransReg("Haber")
                            CTLibroMayorDataSet.Tables("CTLibroMayorDataTable").Rows.Add(NuevoReg)
                        Next
                        If FilasEncontradas.Length > 0 Then 'Tiene Movimientos
                            NuevoReg = CTLibroMayorDataSet.Tables("CTLibroMayorDataTable").NewRow
                            NuevoReg("MovDebe") = decMovDebe
                            NuevoReg("MovHaber") = decMovHaber
                            NuevoReg("Negrita") = True
                            CTLibroMayorDataSet.Tables("CTLibroMayorDataTable").Rows.Add(NuevoReg)
                            NuevoReg = CTLibroMayorDataSet.Tables("CTLibroMayorDataTable").NewRow
                            NuevoReg("Separador") = True
                            CTLibroMayorDataSet.Tables("CTLibroMayorDataTable").Rows.Add(NuevoReg)
                        Else    'No hay Movimientos
                            NuevoReg = CTLibroMayorDataSet.Tables("CTLibroMayorDataTable").NewRow
                            NuevoReg("Cuenta") = drSaldos("Cuenta")
                            NuevoReg("Descripcion") = drSaldos("Descripcion")
                            NuevoReg("MovDebe") = drSaldos("DebitosMes")
                            NuevoReg("MovHaber") = drSaldos("CreditosMes")
                            NuevoReg("ImpCeros") = True
                            CTLibroMayorDataSet.Tables("CTLibroMayorDataTable").Rows.Add(NuevoReg)
                        End If
                    End If
                End While
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Finally
                cnConSaldos.Close()
                cnConTrans.Close()
            End Try
        End Sub
    End Class
    Public Sub New()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class
