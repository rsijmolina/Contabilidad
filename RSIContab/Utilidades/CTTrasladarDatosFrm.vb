'Imports Microsoft.Office.Interop.Access
Public Class CTTrasladarDatosFrm

    Private Sub CTTrasladarDatosFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Para ejecutar este proceso en Propiedades del Proyecto, Compilar, Opciones de compilación avanzada, elegir x86
    End Sub

    Private Sub btnProcesar_Click(sender As System.Object, e As System.EventArgs) Handles btnProcesar.Click
        If radiobutContab.Checked Then
            ProcesarContabilidad()
        ElseIf radiobutBancos.Checked Then
        End If
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        OpenFileDlgBaseDatos.ShowDialog()
        txtBaseDatos.Text = OpenFileDlgBaseDatos.FileName
    End Sub
    Private Sub ProcesarContabilidad()
        Dim strSQL As String
        Dim cmdComAccess As Data.OleDb.OleDbCommand
        Dim drDatosAccess As Data.OleDb.OleDbDataReader
        Dim cnConexionAccess As Data.OleDb.OleDbConnection
        Dim strMes As String
        Dim CTTrasDatosDataSet As New CTTrasladoDatosDataSet
        Dim strNoPartida As String, strNoTrans As String
        Dim intSigNoPartida As Int16
        Dim boNuevoReg As Boolean

        Try
            If Not RadioButSaldos.Checked And Not RadioButTransaccionesEnc.Checked And Not RadioButTransaccionesDet.Checked And Not RadioButTransEncDet.Checked Then
                cnConexionAccess = New Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & txtBaseDatos.Text)
                cnConexionAccess.Open()
                cmdComAccess = cnConexionAccess.CreateCommand
                cmdComAccess.CommandType = CommandType.Text

                If RadioButConfCont.Checked Then
                    strSQL = "SELECT * FROM [Configuracion Contable]"
                    cmdComAccess.CommandText = strSQL
                    drDatosAccess = cmdComAccess.ExecuteReader
                    drDatosAccess.Read()
                    Dim ConfContTableAdapter As New CTTrasladoDatosDataSetTableAdapters.CTConfTableAdapter
                    ConfContTableAdapter.Connection.ConnectionString = strcnCAD
                    ConfContTableAdapter.Fill(CTTrasDatosDataSet.CTConf)
                    Dim RowCtConfNuevoreg As CTTrasladoDatosDataSet.CTConfRow
                    RowCtConfNuevoreg = CTTrasDatosDataSet.CTConf.NewCTConfRow
                    RowCtConfNuevoreg.IndiceActivos = drDatosAccess("Indice Activos")
                    RowCtConfNuevoreg.IndicePasivos = drDatosAccess("Indice Pasivo")
                    RowCtConfNuevoreg.IndiceCapital = drDatosAccess("Indice Capital")
                    RowCtConfNuevoreg.IndiceIngresos = drDatosAccess("Indice Ingresos")
                    RowCtConfNuevoreg.IndiceCostos = drDatosAccess("Indice Costos")
                    RowCtConfNuevoreg.IndiceGastos = drDatosAccess("Indice Gastos")
                    RowCtConfNuevoreg.IndiceOrden = drDatosAccess("Indice Orden")
                    RowCtConfNuevoreg.Niveles = drDatosAccess("Niveles")
                    RowCtConfNuevoreg.DigitosNivel1 = drDatosAccess("Ancho Nivel1")
                    RowCtConfNuevoreg.DigitosNivel2 = drDatosAccess("Ancho Nivel2")
                    RowCtConfNuevoreg.DigitosNivel3 = drDatosAccess("Ancho Nivel3")
                    RowCtConfNuevoreg.DigitosNivel4 = drDatosAccess("Ancho Nivel4")
                    RowCtConfNuevoreg.DigitosNivel5 = drDatosAccess("Ancho Nivel5")
                    RowCtConfNuevoreg.DigitosNivel6 = drDatosAccess("Ancho Nivel6")
                    RowCtConfNuevoreg.DigitosNivel7 = drDatosAccess("Ancho Nivel7")
                    RowCtConfNuevoreg.DigitosNivel8 = drDatosAccess("Ancho Nivel8")
                    RowCtConfNuevoreg.DigitosNivel9 = drDatosAccess("Ancho Nivel9")
                    RowCtConfNuevoreg.NivelActivoRepBalGen = drDatosAccess("Nivel Activo Rep BalGen")
                    RowCtConfNuevoreg.NivelPasivoRepBalGen = drDatosAccess("Nivel Pasivo Rep BalGen")
                    RowCtConfNuevoreg.NivelCapitalRepBalGen = drDatosAccess("Nivel Capital Rep BalGen")
                    RowCtConfNuevoreg.NivelIngresosRepEstResul = drDatosAccess("Nivel Ingresos Rep EstResul")
                    RowCtConfNuevoreg.NivelCostosRepEstResul = drDatosAccess("Nivel Costos Rep EstResul")
                    RowCtConfNuevoreg.NivelGastosRepEstResul = drDatosAccess("Nivel Gastos Rep EstResul")
                    RowCtConfNuevoreg.NumeracionAutoPartidas = drDatosAccess("Numeracion Autom Partidas")
                    RowCtConfNuevoreg.UltimaPartida = drDatosAccess("Ultima Partida")
                    RowCtConfNuevoreg.PermisoDescuadre = drDatosAccess("Permiso de Descuadre")
                    RowCtConfNuevoreg.AñoEnProceso = drDatosAccess("Año en Proceso")
                    RowCtConfNuevoreg.MesEnProceso = drDatosAccess("Mes en Proceso")
                    RowCtConfNuevoreg.MesDeCierre = drDatosAccess("Mes de Cierre")
                    RowCtConfNuevoreg.FechaProceso = drDatosAccess("Fecha de Proceso")
                    RowCtConfNuevoreg.AñoComparacion1 = drDatosAccess("Año de Comparacion1")
                    RowCtConfNuevoreg.AñoComparacion2 = drDatosAccess("Año de Comparacion2")
                    RowCtConfNuevoreg.Ejecutivo1 = IIf(IsDBNull(drDatosAccess("Ejecutivo1")), "", drDatosAccess("Ejecutivo1"))
                    RowCtConfNuevoreg.Ejecutivo2 = IIf(IsDBNull(drDatosAccess("Ejecutivo2")), "", drDatosAccess("Ejecutivo2"))
                    RowCtConfNuevoreg.Ejecutivo3 = IIf(IsDBNull(drDatosAccess("Ejecutivo3")), "", drDatosAccess("Ejecutivo3"))
                    RowCtConfNuevoreg.Cargo1 = IIf(IsDBNull(drDatosAccess("Cargo1")), "", drDatosAccess("Cargo1"))
                    RowCtConfNuevoreg.Cargo2 = IIf(IsDBNull(drDatosAccess("Cargo2")), "", drDatosAccess("Cargo2"))
                    RowCtConfNuevoreg.Cargo3 = IIf(IsDBNull(drDatosAccess("Cargo3")), "", drDatosAccess("Cargo3"))
                    CTTrasDatosDataSet.CTConf.Rows.Add(RowCtConfNuevoreg)
                    ConfContTableAdapter.Update(CTTrasDatosDataSet.CTConf)
                ElseIf RadioButCatalogo.Checked Then
                    strSQL = "SELECT * FROM Catalogo ORDER BY Cuenta"
                    cmdComAccess.CommandText = strSQL
                    drDatosAccess = cmdComAccess.ExecuteReader
                    Dim CatalogoTableAdapter As New CTTrasladoDatosDataSetTableAdapters.CTCatalogoCuentasTableAdapter
                    CatalogoTableAdapter.Connection.ConnectionString = strcnCAD
                    CatalogoTableAdapter.Fill(CTTrasDatosDataSet.CTCatalogoCuentas)
                    Dim RowCatalogoNuevoreg As CTTrasladoDatosDataSet.CTCatalogoCuentasRow
                    Do While drDatosAccess.Read
                        RowCatalogoNuevoreg = CTTrasDatosDataSet.CTCatalogoCuentas.NewCTCatalogoCuentasRow()
                        RowCatalogoNuevoreg.Cuenta = drDatosAccess("Cuenta")
                        RowCatalogoNuevoreg.Descripcion = drDatosAccess("Descripcion")
                        RowCatalogoNuevoreg.Nivel = drDatosAccess("Nivel")
                        RowCatalogoNuevoreg.Posteable = drDatosAccess("Posteable")
                        RowCatalogoNuevoreg.CuentaSuperior = IIf(IsDBNull(drDatosAccess("Cuenta Superior")), "", drDatosAccess("Cuenta Superior"))
                        RowCatalogoNuevoreg.Naturaleza = drDatosAccess("Naturaleza")
                        RowCatalogoNuevoreg.Tipo = drDatosAccess("Tipo")
                        CTTrasDatosDataSet.CTCatalogoCuentas.Rows.Add(RowCatalogoNuevoreg)
                    Loop
                    CatalogoTableAdapter.Update(CTTrasDatosDataSet.CTCatalogoCuentas)
                ElseIf RadioButTiposPartidas.Checked Then
                    strSQL = "SELECT * FROM TiposPartidas"
                    cmdComAccess.CommandText = strSQL
                    drDatosAccess = cmdComAccess.ExecuteReader
                    Dim TiposPartidasTableAdapter As New CTTrasladoDatosDataSetTableAdapters.CTTiposPartidasTableAdapter
                    TiposPartidasTableAdapter.Connection.ConnectionString = strcnCAD
                    TiposPartidasTableAdapter.Fill(CTTrasDatosDataSet.CTTiposPartidas)
                    Dim RowTipoPartidaNuevoreg As CTTrasladoDatosDataSet.CTTiposPartidasRow
                    Do While drDatosAccess.Read
                        RowTipoPartidaNuevoreg = CTTrasDatosDataSet.CTTiposPartidas.NewCTTiposPartidasRow
                        RowTipoPartidaNuevoreg("TipoPartida") = drDatosAccess("Tipo")
                        CTTrasDatosDataSet.CTTiposPartidas.Rows.Add(RowTipoPartidaNuevoreg)
                    Loop
                    TiposPartidasTableAdapter.Update(CTTrasDatosDataSet.CTTiposPartidas)
                ElseIf RadioButMesesCerrados.Checked Then
                    strSQL = "SELECT * FROM [Meses Cerrados]"
                    cmdComAccess.CommandText = strSQL
                    drDatosAccess = cmdComAccess.ExecuteReader
                    Dim MesesCerradosTableAdapter As New CTTrasladoDatosDataSetTableAdapters.CTMesesCerradosTableAdapter
                    MesesCerradosTableAdapter.Connection.ConnectionString = strcnCAD
                    MesesCerradosTableAdapter.Fill(CTTrasDatosDataSet.CTMesesCerrados)
                    Dim RowMesesCerradosNuevoreg As CTTrasladoDatosDataSet.CTMesesCerradosRow
                    Do While drDatosAccess.Read
                        RowMesesCerradosNuevoreg = CTTrasDatosDataSet.CTMesesCerrados.NewCTMesesCerradosRow
                        RowMesesCerradosNuevoreg.Año = drDatosAccess("Año")
                        RowMesesCerradosNuevoreg.Mes = drDatosAccess("Mes")
                        RowMesesCerradosNuevoreg.Cerrado = drDatosAccess("Cerrado")
                        RowMesesCerradosNuevoreg.PermitirModificacion = drDatosAccess("PermitirModificar")
                        CTTrasDatosDataSet.CTMesesCerrados.Rows.Add(RowMesesCerradosNuevoreg)
                    Loop
                    MesesCerradosTableAdapter.Update(CTTrasDatosDataSet.CTMesesCerrados)
                ElseIf RadioButPresupuesto.Checked Then
                    strSQL = "SELECT * FROM Pres" & Trim(Str(c1numAñoCont)) & " ORDER BY Cuenta"
                    cmdComAccess.CommandText = strSQL
                    drDatosAccess = cmdComAccess.ExecuteReader
                    Dim PresupTableAdapter As New CTTrasladoDatosDataSetTableAdapters.CTPresupuestoTableAdapter
                    PresupTableAdapter.Connection.ConnectionString = strcnCAD
                    PresupTableAdapter.Fill(CTTrasDatosDataSet.CTPresupuesto)
                    Dim RowPresupNuevoreg As CTTrasladoDatosDataSet.CTPresupuestoRow
                    Do While drDatosAccess.Read
                        RowPresupNuevoreg = CTTrasDatosDataSet.CTPresupuesto.NewCTPresupuestoRow
                        RowPresupNuevoreg.Año = c1numAñoCont.Value
                        RowPresupNuevoreg.Cuenta = drDatosAccess("Tipo")
                        RowPresupNuevoreg.CuentaCoop = drDatosAccess("CuentaCoop")
                        RowPresupNuevoreg.PresupuestoAnual = drDatosAccess("Anual")
                        RowPresupNuevoreg.PresupAnualMonedaExtranjera = drDatosAccess("AnualMonedaExtranjera")
                        CTTrasDatosDataSet.CTPresupuesto.Rows.Add(RowPresupNuevoreg)
                    Loop
                    PresupTableAdapter.Update(CTTrasDatosDataSet.CTPresupuesto)
                End If
                cnConexionAccess.Close()
            Else
                If RadioButTransaccionesEnc.Checked Then
                    '*** Encabezado
                    For i As Int16 = c1numMesIni.Value To c1numMesFin.Value
                        cnConexionAccess = New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & txtBaseDatos.Text)
                        cnConexionAccess.Open()
                        cmdComAccess = cnConexionAccess.CreateCommand
                        cmdComAccess.CommandType = CommandType.Text
                        If i < 10 Then
                            strMes = "0" & Trim(Str(i))
                        Else
                            strMes = Trim(Str(i))
                        End If
                        strSQL = "SELECT * FROM CT" & Strings.Right(c1numAñoCont.Text, 2) & strMes & "ET ORDER BY [Numero de Transaccion]"
                        cmdComAccess.CommandText = strSQL
                        drDatosAccess = cmdComAccess.ExecuteReader
                        Dim TransEncTableAdapter As New CTTrasladoDatosDataSetTableAdapters.CTTransaccionesEncabezadoTableAdapter
                        TransEncTableAdapter.Connection.ConnectionString = strcnCAD
                        'TransEncTableAdapter.Fill(CTTrasDatosDataSet.CTTransaccionesEncabezado)
                        Dim RowTransNuevoreg As CTTrasladoDatosDataSet.CTTransaccionesEncabezadoRow

                        Do While drDatosAccess.Read
                            RowTransNuevoreg = CTTrasDatosDataSet.CTTransaccionesEncabezado.NewCTTransaccionesEncabezadoRow
                            RowTransNuevoreg.Año = c1numAñoCont.Value
                            RowTransNuevoreg.Mes = i
                            RowTransNuevoreg.NoTransaccion = drDatosAccess("Numero de Transaccion")
                            RowTransNuevoreg.Fecha = drDatosAccess("Fecha")
                            RowTransNuevoreg.TipoPartida = IIf(IsDBNull(drDatosAccess("Tipo de Partida")), "", drDatosAccess("Tipo de Partida"))
                            RowTransNuevoreg.Sinopsis = drDatosAccess("Sinopsis")
                            RowTransNuevoreg.Usuario = IIf(IsDBNull(drDatosAccess("Usuario")), "", drDatosAccess("Usuario"))
                            CTTrasDatosDataSet.CTTransaccionesEncabezado.Rows.Add(RowTransNuevoreg)
                        Loop
                        TransEncTableAdapter.Update(CTTrasDatosDataSet.CTTransaccionesEncabezado)
                        cnConexionAccess.Close()
                    Next
                ElseIf RadioButTransaccionesDet.Checked Then
                    'Detalle
                    For i As Int16 = 1 To 12
                        cnConexionAccess = New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & txtBaseDatos.Text)
                        cnConexionAccess.Open()
                        cmdComAccess = cnConexionAccess.CreateCommand
                        cmdComAccess.CommandType = CommandType.Text
                        If i < 10 Then
                            strMes = "0" & Trim(Str(i))
                        Else
                            strMes = Trim(Str(i))
                        End If
                        strSQL = "SELECT * FROM CT" & Strings.Right(c1numAñoCont.Text, 2) & strMes & "DT ORDER BY [Numero de Transaccion],Linea"
                        cmdComAccess.CommandText = strSQL
                        drDatosAccess = cmdComAccess.ExecuteReader
                        Dim TransDetTableAdapter As New CTTrasladoDatosDataSetTableAdapters.CTTransaccionesDetalleTableAdapter
                        TransDetTableAdapter.Connection.ConnectionString = strcnCAD
                        'TransDetTableAdapter.Fill(CTTrasDatosDataSet.CTTransaccionesDetalle)
                        Dim RowTransNuevoreg As CTTrasladoDatosDataSet.CTTransaccionesDetalleRow
                        Do While drDatosAccess.Read
                            RowTransNuevoreg = CTTrasDatosDataSet.CTTransaccionesDetalle.NewCTTransaccionesDetalleRow
                            RowTransNuevoreg.Año = c1numAñoCont.Value
                            RowTransNuevoreg.Mes = i
                            RowTransNuevoreg.NoTransaccion = drDatosAccess("Numero de Transaccion")
                            RowTransNuevoreg.Linea = drDatosAccess("Linea")
                            RowTransNuevoreg.Cuenta = drDatosAccess("Cuenta")
                            RowTransNuevoreg.Descripcion = IIf(IsDBNull(drDatosAccess("Descripcion")), "", drDatosAccess("Descripcion"))
                            RowTransNuevoreg.Debe = IIf(IsDBNull(drDatosAccess("Debe")), 0, drDatosAccess("Debe"))
                            RowTransNuevoreg.Haber = IIf(IsDBNull(drDatosAccess("Haber")), 0, drDatosAccess("Haber"))
                            CTTrasDatosDataSet.CTTransaccionesDetalle.Rows.Add(RowTransNuevoreg)
                        Loop
                        TransDetTableAdapter.Update(CTTrasDatosDataSet.CTTransaccionesDetalle)
                        cnConexionAccess.Close()
                    Next
                ElseIf RadioButTransEncDet.Checked Then
                    cnConexionAccess = New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & txtBaseDatos.Text)
                    cnConexionAccess.Open()
                    cmdComAccess = cnConexionAccess.CreateCommand
                    cmdComAccess.CommandType = CommandType.Text
                    If c1numMesIni.Value < 10 Then
                        strMes = "0" & Trim(Str(c1numMesIni.Value))
                    Else
                        strMes = Trim(Str(c1numMesIni.Value))
                    End If
                    Dim strTablaDet As String = "CT" & Strings.Right(c1numAñoCont.Text, 2) & strMes & "DT"
                    Dim strTablaEnc As String = "CT" & Strings.Right(c1numAñoCont.Text, 2) & strMes & "ET"
                    strSQL = "SELECT " & strTablaDet & ".[Numero de Transaccion]," & strTablaDet & ".Linea," & strTablaDet & ".Cuenta," & strTablaDet & ".Descripcion," _
                        & strTablaDet & ".Debe," & strTablaDet & ".Haber," & strTablaEnc & ".Fecha," & strTablaEnc & ".[Tipo de Partida]," & strTablaEnc & ".Sinopsis," & strTablaEnc & ".Usuario " _
                        & "FROM " & strTablaDet & " INNER JOIN " & strTablaEnc & " ON " & strTablaDet & ".[Numero de Transaccion]=" & strTablaEnc & ".[Numero de Transaccion] ORDER BY " _
                        & strTablaDet & ".[Numero de Transaccion]," & strTablaDet & ".Linea"
                    cmdComAccess.CommandText = strSQL
                    drDatosAccess = cmdComAccess.ExecuteReader
                    Dim TransEncTableAdapter As New CTTrasladoDatosDataSetTableAdapters.CTTransaccionesEncabezadoTableAdapter
                    Dim TransDetTableAdapter As New CTTrasladoDatosDataSetTableAdapters.CTTransaccionesDetalleTableAdapter
                    TransEncTableAdapter.Connection.ConnectionString = strcnCAD
                    TransDetTableAdapter.Connection.ConnectionString = strcnCAD
                    boNuevoReg = True
                    strNoTrans = ""
                    Dim RowTransEncNuevoreg As CTTrasladoDatosDataSet.CTTransaccionesEncabezadoRow
                    Dim RowTransDetNuevoreg As CTTrasladoDatosDataSet.CTTransaccionesDetalleRow
                    Do While drDatosAccess.Read
                        If drDatosAccess("Numero de Transaccion") <> strNoTrans Then
                            boNuevoReg = True
                        Else
                            boNuevoReg = False
                        End If
                        strNoPartida = drDatosAccess("Numero de Transaccion")
                        strNoTrans = drDatosAccess("Numero de Transaccion")
                        'Verificar si existe partida en la base de datos
                        'If strNoTrans = "T9-1" Then
                        'intSigNoPartida = 0
                        'End If
                        intSigNoPartida = 1
                        If ExistePartida(strNoPartida) Then
                            Do While 1
                                'strNoPartida = strNoPartida & "_" & Trim(Str(intSigNoPartida))
                                If Not ExistePartida(strNoPartida & "_" & Trim(Str(intSigNoPartida))) Then
                                    Exit Do
                                End If
                                intSigNoPartida = intSigNoPartida + 1
                            Loop
                            strNoPartida = strNoPartida & "_" & Trim(Str(intSigNoPartida))
                        End If
                        If boNuevoReg Then
                            'Agregar Encabezado del 1er registro
                            RowTransEncNuevoreg = CTTrasDatosDataSet.CTTransaccionesEncabezado.NewCTTransaccionesEncabezadoRow
                            RowTransEncNuevoreg.NoTransaccion = strNoPartida
                            RowTransEncNuevoreg.Fecha = drDatosAccess("Fecha")
                            RowTransEncNuevoreg.TipoPartida = IIf(IsDBNull(drDatosAccess("Tipo de Partida")), "", drDatosAccess("Tipo de Partida"))
                            RowTransEncNuevoreg.Sinopsis = IIf(IsDBNull(drDatosAccess("Sinopsis")), "", drDatosAccess("Sinopsis"))
                            RowTransEncNuevoreg.Usuario = IIf(IsDBNull(drDatosAccess("Usuario")), "", drDatosAccess("Usuario"))
                            RowTransEncNuevoreg.Año = c1numAñoCont.Value
                            RowTransEncNuevoreg.Mes = c1numMesIni.Value
                            CTTrasDatosDataSet.CTTransaccionesEncabezado.Rows.Add(RowTransEncNuevoreg)
                        End If
                        'Agregar Detalle del 1er registro                        
                        RowTransDetNuevoreg = CTTrasDatosDataSet.CTTransaccionesDetalle.NewCTTransaccionesDetalleRow
                        RowTransDetNuevoreg.NoTransaccion = strNoPartida
                        RowTransDetNuevoreg.Linea = drDatosAccess("Linea")
                        RowTransDetNuevoreg.Cuenta = IIf(IsDBNull(drDatosAccess("Cuenta")), "", drDatosAccess("Cuenta"))
                        RowTransDetNuevoreg.Descripcion = IIf(IsDBNull(drDatosAccess("Descripcion")), "", drDatosAccess("Descripcion"))
                        RowTransDetNuevoreg.Debe = IIf(IsDBNull(drDatosAccess("Debe")), 0, drDatosAccess("Debe"))
                        RowTransDetNuevoreg.Debe = IIf(IsDBNull(drDatosAccess("Haber")), 0, drDatosAccess("Haber"))
                        RowTransDetNuevoreg.Fecha = drDatosAccess("Fecha")
                        RowTransDetNuevoreg.Año = c1numAñoCont.Value
                        RowTransDetNuevoreg.Mes = c1numMesIni.Value
                        CTTrasDatosDataSet.CTTransaccionesDetalle.Rows.Add(RowTransDetNuevoreg)
                        'Do While drDatosAccess.Read And drDatosAccess("Numero de Transaccion") = strNoTrans
                        'Agregar Detalle
                        'RowTransDetNuevoreg = CTTrasDatosDataSet.CTTransaccionesDetalle.NewCTTransaccionesDetalleRow
                        'RowTransDetNuevoreg.NoTransaccion = strNoPartida
                        'RowTransDetNuevoreg.Linea = drDatosAccess("Linea")
                        'RowTransDetNuevoreg.Cuenta = IIf(IsDBNull(drDatosAccess("Cuenta")), "", drDatosAccess("Cuenta"))
                        'RowTransDetNuevoreg.Descripcion = IIf(IsDBNull(drDatosAccess("Descripcion")), "", drDatosAccess("Descripcion"))
                        'RowTransDetNuevoreg.Debe = IIf(IsDBNull(drDatosAccess("Debe")), 0, drDatosAccess("Debe"))
                        'RowTransDetNuevoreg.Debe = IIf(IsDBNull(drDatosAccess("Haber")), 0, drDatosAccess("Haber"))
                        'RowTransDetNuevoreg.Fecha = drDatosAccess("Fecha")
                        'RowTransDetNuevoreg.Año = c1numAñoCont.Value
                        'RowTransDetNuevoreg.Mes = c1numMesIni.Value
                        'Loop
                    Loop
                    TransEncTableAdapter.Update(CTTrasDatosDataSet.CTTransaccionesEncabezado)
                    TransDetTableAdapter.Update(CTTrasDatosDataSet.CTTransaccionesDetalle)
                    cnConexionAccess.Close()
                    MsgBox("Proceso Terminado...", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                ElseIf RadioButSaldos.Checked Then
                    For i As Int16 = c1numMesIni.Value To c1numMesFin.Value
                        cnConexionAccess = New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & txtBaseDatos.Text)
                        cnConexionAccess.Open()
                        cmdComAccess = cnConexionAccess.CreateCommand
                        cmdComAccess.CommandType = CommandType.Text
                        If i < 10 Then
                            strMes = "0" & Trim(Str(i))
                        Else
                            strMes = Trim(Str(i))
                        End If
                        Dim strTabla As String = "CT" & Strings.Right(c1numAñoCont.Text, 2) & strMes & "SA"
                        strSQL = "SELECT " & strTabla & ".Cuenta," & strTabla & ".[Saldo Anterior]," & strTabla & ".[Debitos del Mes]," & strTabla & ".[Creditos del Mes]," _
                            & "Catalogo.[Cuenta Superior],Catalogo.Nivel,Catalogo.Naturaleza FROM " & strTabla & " INNER JOIN Catalogo ON " & strTabla & ".Cuenta=Catalogo.Cuenta ORDER BY " & strTabla & ".Cuenta"
                        cmdComAccess.CommandText = strSQL
                        drDatosAccess = cmdComAccess.ExecuteReader
                        Dim SaldosTableAdapter As New CTTrasladoDatosDataSetTableAdapters.CTSaldosMensualesTableAdapter
                        SaldosTableAdapter.Connection.ConnectionString = strcnCAD
                        'SaldosTableAdapter.Fill(CTTrasDatosDataSet.CTSaldosMensuales)
                        Dim RowSaldosNuevoreg As CTTrasladoDatosDataSet.CTSaldosMensualesRow
                        Do While drDatosAccess.Read
                            If Not IsDBNull(drDatosAccess("Cuenta")) Then
                                RowSaldosNuevoreg = CTTrasDatosDataSet.CTSaldosMensuales.NewCTSaldosMensualesRow
                                RowSaldosNuevoreg.Año = c1numAñoCont.Value
                                RowSaldosNuevoreg.Mes = i
                                RowSaldosNuevoreg.Cuenta = drDatosAccess("Cuenta")
                                RowSaldosNuevoreg.CuentaSuperior = IIf(IsDBNull(drDatosAccess("Cuenta Superior")), "", drDatosAccess("Cuenta Superior"))
                                RowSaldosNuevoreg.Nivel = drDatosAccess("Nivel")
                                'RowSaldosNuevoreg.Nivel = drDatosAccess("Nivel")
                                RowSaldosNuevoreg.Naturaleza = drDatosAccess("Naturaleza")
                                RowSaldosNuevoreg.SaldoAnterior = drDatosAccess("Saldo Anterior")
                                RowSaldosNuevoreg.DebitosMes = drDatosAccess("Debitos del Mes")
                                RowSaldosNuevoreg.CreditosMes = drDatosAccess("Creditos del Mes")
                                CTTrasDatosDataSet.CTSaldosMensuales.Rows.Add(RowSaldosNuevoreg)
                            End If
                        Loop
                        SaldosTableAdapter.Update(CTTrasDatosDataSet.CTSaldosMensuales)
                        cnConexionAccess.Close()
                    Next
                End If
                MsgBox("Proceso Terminado...", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " Partida  " & strNoTrans, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Function ExistePartida(strNoPartida As String) As Boolean
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand
        Dim drCat As SqlClient.SqlDataReader

        cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "SELECT NoTransaccion FROM CTTransaccionesEncabezado WHERE NoTransaccion='" & strNoPartida & "'"
        drCat = cmdInComando.ExecuteReader
        drCat.Read()
        If drCat.HasRows Then
            ExistePartida = True
        Else
            ExistePartida = False
        End If
        drCat.Close()
        cnSQLConexion.Close()
    End Function
End Class