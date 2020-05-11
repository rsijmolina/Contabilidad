Public Class CTConsolidacionEmpComunFrm
    Dim rsiClsCad As New Rsierpgencl.Rsierpcl.Cadenas
    Dim colCodigoEmps As New Collection
    Dim strConexionDest As String, strConexionFuente As String
    Private Sub CTConsolidacionEmpComunFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DBConsTableAdapter.Connection.ConnectionString = crfgXNN
        Me.DBConsTableAdapter.FillByConsolidadoras(Me.CTEmpresasDataSet.DBCons)
        Me.DBEmpAConsolidarTableAdapter.FillByNoConsolidadoras(Me.CTEmpresasDataSet.DBEmpAConsolidar)
        For i As Int16 = 1 To 12
            cmbMesConsolidar.Items.Add(rsiClsCad.MesLetras(i))
        Next
        For Each drEmps As DataRowView In BindingSourceEmpresasAConsolidar
            colCodigoEmps.Add(drEmps("ID"))
            Me.chklstboxEmpConsolidar.Items.Add(drEmps("NombreEmpresa"))
        Next
        c1numAñoConsolidar.Value = Now.Year
    End Sub

    Private Sub butCancelar_Click(sender As Object, e As EventArgs) Handles butCancelar.Click
        Me.Close()
    End Sub

    Private Sub butAceptar_Click(sender As Object, e As EventArgs) Handles butAceptar.Click
        Dim RSISegClGen As New Rsierpgencl.Rsierpcl.EncripDesencrip
        Dim strSQL As String
        Dim CTConsoEmpDataSet As New CTConsolidacionDataSet
        Dim cnSQLConexion As Data.SqlClient.SqlConnection, cnSQLConFuente As Data.SqlClient.SqlConnection
        Dim ConsolidacionDataSet As New DataSet
        Dim ConsolidacionDataAdapter As New SqlClient.SqlDataAdapter
        Dim cmdSeleccionar As SqlClient.SqlCommand, cmdInsertar As SqlClient.SqlCommand, cmdComando As SqlClient.SqlCommand, cmdActualizar As SqlClient.SqlCommand
        Dim drDatos As SqlClient.SqlDataReader
        Dim intLin As Int16
        Dim boEmpSelec As Boolean

        lblMensaje.Visible = True
        lblMensaje.Refresh()
        If cmbMesConsolidar.Text = "" Then
            MsgBox("Debe de elegir el mes a consolidar", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If c1cmbEmpresaConsolidadora.Text = "" Then
            MsgBox("Debe de elegir la empresa de consolidación", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        boEmpSelec = False
        For i As Int16 = 0 To chklstboxEmpConsolidar.Items.Count - 1
            If chklstboxEmpConsolidar.GetItemCheckState(i) = CheckState.Checked Then
                boEmpSelec = True
            End If
        Next
        If Not boEmpSelec Then
            MsgBox("Debe de elegir la empresa o empresas a consolidar", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Try
            Dim drEmps As DataRowView = BindingSourceEmpesasConsolidacion.Current
            strConexionDest = "Data Source=" & drEmps("Servidor") & "\" _
                & drEmps("Instancia") & ";Initial Catalog=" & drEmps("BaseDatos") & " ;User ID=" & RSISegClGen.DecryptData(My.Settings.xupiy) & ";Password=" & RSISegClGen.DecryptData(My.Settings.acvse)

            EliminarDatos()

            'Procesar catálogo de cuentas
            '* Abrir las conexiones y llenar los datatables
            strSQL = "SELECT * FROM CTCatalagoCuentas ORDER BY Cuenta"
            cnSQLConexion = New SqlClient.SqlConnection(strConexionDest)
            cnSQLConexion.Open()
            strSQL = "SELECT * FROM CTCatalogoCuentas ORDER BY Cuenta"
            cmdSeleccionar = cnSQLConexion.CreateCommand
            cmdSeleccionar.CommandType = CommandType.Text
            cmdSeleccionar.CommandText = strSQL
            ConsolidacionDataAdapter.SelectCommand = cmdSeleccionar
            'Insertar datos
            strSQL = "INSERT INTO CTCatalogoCuentas (Cuenta,Descripcion,Nivel,Posteable,CuentaSuperior,Naturaleza,Tipo,Ambito,CentroCosto) VALUES(@Cuenta,@Descripcion,@Nivel,@Posteable,@CuentaSuperior,@Naturaleza,@Tipo,@Ambito,@CentroCosto)"
            cmdInsertar = cnSQLConexion.CreateCommand
            cmdInsertar.CommandType = CommandType.Text
            cmdInsertar.CommandText = strSQL
            cmdInsertar.Parameters.Add("@Cuenta", SqlDbType.NVarChar, 30, "Cuenta")
            cmdInsertar.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 100, "Descripcion")
            cmdInsertar.Parameters.Add("@Nivel", SqlDbType.SmallInt, 2, "Nivel")
            cmdInsertar.Parameters.Add("@Posteable", SqlDbType.Bit, 1, "Posteable")
            cmdInsertar.Parameters.Add("@CuentaSuperior", SqlDbType.NVarChar, 30, "CuentaSuperior")
            cmdInsertar.Parameters.Add("@Naturaleza", SqlDbType.Char, 1, "Naturaleza")
            cmdInsertar.Parameters.Add("@Tipo", SqlDbType.Char, 1, "Tipo")
            cmdInsertar.Parameters.Add("@Ambito", SqlDbType.Char, 1, "Ambito")
            cmdInsertar.Parameters.Add("@CentroCosto", SqlDbType.NVarChar, 30, "CentroCosto")
            ConsolidacionDataAdapter.InsertCommand = cmdInsertar
            ConsolidacionDataAdapter.Fill(CTConsoEmpDataSet.Tables("CTCatalogoCuentas"))
            For i As Int16 = 0 To chklstboxEmpConsolidar.Items.Count - 1
                'CTConsoEmpDataSet.Clear()
                If chklstboxEmpConsolidar.GetItemCheckState(i) = CheckState.Checked Then
                    'Obtener datos de empresas a consolidar
                    BindingSourceEmpresasAConsolidar.Filter = "Id=" & colCodigoEmps(i + 1)
                    Dim drvEmpFuente As DataRowView = BindingSourceEmpresasAConsolidar.Current
                    strConexionFuente = "Data Source=" & drvEmpFuente("Servidor") & "\" _
                        & drvEmpFuente("Instancia") & ";Initial Catalog=" & drvEmpFuente("BaseDatos") & " ;User ID=" & RSISegClGen.DecryptData(My.Settings.xupiy) & ";Password=" & RSISegClGen.DecryptData(My.Settings.acvse)
                    BindingSourceEmpresasAConsolidar.RemoveFilter()

                    strSQL = "SELECT * FROM CTCatalogoCuentas ORDER BY Cuenta"
                    cnSQLConFuente = New SqlClient.SqlConnection(strConexionFuente)
                    cnSQLConFuente.Open()
                    cmdComando = cnSQLConFuente.CreateCommand
                    cmdComando.CommandType = CommandType.Text
                    cmdComando.CommandText = strSQL
                    drDatos = cmdComando.ExecuteReader
                    While drDatos.Read
                        Dim regBuscar As DataRow = CTConsoEmpDataSet.Tables("CTCatalogoCuentas").Rows.Find(drDatos("Cuenta"))
                        If (regBuscar Is Nothing) Then
                            Dim NuevoReg As DataRow = CTConsoEmpDataSet.Tables("CTCatalogoCuentas").NewRow
                            NuevoReg("Cuenta") = drDatos("Cuenta")
                            NuevoReg("Descripcion") = drDatos("Descripcion")
                            NuevoReg("Nivel") = drDatos("Nivel")
                            NuevoReg("Posteable") = drDatos("Posteable")
                            NuevoReg("CuentaSuperior") = drDatos("CuentaSuperior")
                            NuevoReg("Naturaleza") = drDatos("Naturaleza")
                            NuevoReg("Tipo") = drDatos("Tipo")
                            NuevoReg("Ambito") = drDatos("Ambito")
                            NuevoReg("CentroCosto") = drDatos("CentroCosto")
                            CTConsoEmpDataSet.Tables("CTCatalogoCuentas").Rows.Add(NuevoReg)
                        End If
                    End While
                    cnSQLConFuente.Close()
                End If
            Next
            ConsolidacionDataAdapter.Update(CTConsoEmpDataSet.Tables("CTCatalogoCuentas"))
            cnSQLConexion.Close()

            'Procesar Saldos
            cnSQLConexion = New SqlClient.SqlConnection(strConexionDest)
            cnSQLConexion.Open()
            strSQL = "INSERT INTO CTSaldosMensuales (Cuenta,Año,Mes,CuentaSuperior,Nivel,Naturaleza,SaldoAnterior,DebitosMes,CreditosMes) VALUES(@Cuenta,@Año,@Mes,@CuentaSuperior,@Nivel,@Naturaleza,@SaldoAnterior,@DebitosMes,@CreditosMes)"
            cmdInsertar = cnSQLConexion.CreateCommand
            cmdInsertar.CommandType = CommandType.Text
            cmdInsertar.CommandText = strSQL
            cmdInsertar.Parameters.Add("@Cuenta", SqlDbType.NVarChar, 30, "Cuenta")
            cmdInsertar.Parameters.Add("@Año", SqlDbType.SmallInt, 2, "Año")
            cmdInsertar.Parameters.Add("@Mes", SqlDbType.SmallInt, 2, "Mes")
            cmdInsertar.Parameters.Add("@CuentaSuperior", SqlDbType.NVarChar, 30, "CuentaSuperior")
            cmdInsertar.Parameters.Add("@Nivel", SqlDbType.SmallInt, 2, "Nivel")
            cmdInsertar.Parameters.Add("@Naturaleza", SqlDbType.Char, 1, "Naturaleza")
            cmdInsertar.Parameters.Add("@SaldoAnterior", SqlDbType.Decimal, 9, "SaldoAnterior")
            cmdInsertar.Parameters.Add("@DebitosMes", SqlDbType.Decimal, 9, "DebitosMes")
            cmdInsertar.Parameters.Add("@CreditosMes", SqlDbType.Decimal, 9, "CreditosMes")
            ConsolidacionDataAdapter.InsertCommand = cmdInsertar
            'Actualizar
            strSQL = "UPDATE CTSaldosMensuales SET SaldoAnterior=@SaldoAnterior,DebitosMes=@DebitosMes,CreditosMes=@CreditosMes WHERE Cuenta=@oldCuenta"
            cmdActualizar = cnSQLConexion.CreateCommand
            cmdActualizar.CommandType = CommandType.Text
            cmdActualizar.CommandText = strSQL
            'cmdActualizar.Parameters.Add("@Cuenta", SqlDbType.NVarChar, 30, "Cuenta")
            cmdActualizar.Parameters.Add("@SaldoAnterior", SqlDbType.Decimal, 9, "SaldoAnterior")
            cmdActualizar.Parameters.Add("@DebitosMes", SqlDbType.Decimal, 9, "DebitosMes")
            cmdActualizar.Parameters.Add("@CreditosMes", SqlDbType.Decimal, 9, "CreditosMes")
            Dim parameter As SqlClient.SqlParameter = cmdActualizar.Parameters.Add("@oldCuenta", SqlDbType.NVarChar, 30, "Cuenta")
            parameter.SourceVersion = DataRowVersion.Original
            ConsolidacionDataAdapter.UpdateCommand = cmdActualizar

            For i As Int16 = 0 To chklstboxEmpConsolidar.Items.Count - 1
                'CTConsoEmpDataSet.Clear()
                If chklstboxEmpConsolidar.GetItemCheckState(i) = CheckState.Checked Then
                    'Obtener datos de empresas a consolidar
                    BindingSourceEmpresasAConsolidar.Filter = "Id=" & colCodigoEmps(i + 1)
                    Dim drvEmpFuente As DataRowView = BindingSourceEmpresasAConsolidar.Current
                    strConexionFuente = "Data Source=" & drvEmpFuente("Servidor") & "\" _
                        & drvEmpFuente("Instancia") & ";Initial Catalog=" & drvEmpFuente("BaseDatos") & " ;User ID=" & RSISegClGen.DecryptData(My.Settings.xupiy) & ";Password=" & RSISegClGen.DecryptData(My.Settings.acvse)
                    BindingSourceEmpresasAConsolidar.RemoveFilter()

                    strSQL = "SELECT * FROM CTSaldosMensuales WHERE Año=" & c1numAñoConsolidar.Value & " AND Mes=" & rsiClsCad.NumMes(cmbMesConsolidar.Text) & "  ORDER BY Cuenta"
                    cnSQLConFuente = New SqlClient.SqlConnection(strConexionFuente)
                    cnSQLConFuente.Open()
                    cmdComando = cnSQLConFuente.CreateCommand
                    cmdComando.CommandType = CommandType.Text
                    cmdComando.CommandText = strSQL
                    drDatos = cmdComando.ExecuteReader
                    While drDatos.Read
                        Dim foundRows() As DataRow = CTConsoEmpDataSet.Tables("CTSaldosMensuales").Select("Cuenta='" & drDatos("Cuenta") & "'")
                        If foundRows.Length = 0 Then
                            Dim NuevoReg As DataRow = CTConsoEmpDataSet.Tables("CTSaldosMensuales").NewRow
                            NuevoReg("Cuenta") = drDatos("Cuenta")
                            NuevoReg("Año") = drDatos("Año")
                            NuevoReg("Mes") = drDatos("Mes")
                            NuevoReg("CuentaSuperior") = drDatos("CuentaSuperior")
                            NuevoReg("Nivel") = drDatos("Nivel")
                            NuevoReg("Naturaleza") = drDatos("Naturaleza")
                            NuevoReg("SaldoAnterior") = drDatos("SaldoAnterior")
                            NuevoReg("DebitosMes") = drDatos("DebitosMes")
                            NuevoReg("CreditosMes") = drDatos("CreditosMes")
                            CTConsoEmpDataSet.Tables("CTSaldosMensuales").Rows.Add(NuevoReg)
                        Else
                            foundRows(0)("SaldoAnterior") = foundRows(0)("SaldoAnterior") + drDatos("SaldoAnterior")
                            foundRows(0)("DebitosMes") = foundRows(0)("DebitosMes") + drDatos("DebitosMes")
                            foundRows(0)("CreditosMes") = foundRows(0)("CreditosMes") + drDatos("CreditosMes")
                        End If
                    End While
                    cnSQLConFuente.Close()
                End If
            Next
            ConsolidacionDataAdapter.Update(CTConsoEmpDataSet.Tables("CTSaldosMensuales"))
            cnSQLConexion.Close()

            'Crear Partida
            Me.CTTransaccionesDetalleTableAdapter.Connection.ConnectionString = strConexionDest
            Me.CTTransaccionesEncabezadoTableAdapter.Connection.ConnectionString = strConexionDest
            Me.BindingSourceTransEnc.AddNew()
            Dim drTransEnc As DataRowView = Me.BindingSourceTransEnc.Current
            drTransEnc("NoTransaccion") = "CONSOL"
            drTransEnc("Fecha") = c1numAñoConsolidar.Text & "-" & Trim(Str(rsiClsCad.NumMes(cmbMesConsolidar.Text))) & "-1"
            drTransEnc("Sinopsis") = "Partida de Consolidación"
            drTransEnc("Cerrado") = True
            drTransEnc("Año") = c1numAñoConsolidar.Value
            drTransEnc("Mes") = rsiClsCad.NumMes(cmbMesConsolidar.Text)
            BindingSourceTransEnc.EndEdit()
            Me.CTTransaccionesEncabezadoTableAdapter.Update(Me.CTConsolidacionDataSet.CTTransaccionesEncabezado)
            strSQL = "SELECT CTSaldosMensuales.Cuenta, CTSaldosMensuales.DebitosMes, CTSaldosMensuales.CreditosMes, CTCatalogoCuentas.Posteable " _
                & "FROM CTSaldosMensuales INNER JOIN CTCatalogoCuentas ON CTSaldosMensuales.Cuenta = CTCatalogoCuentas.Cuenta " _
                & "WHERE (CTSaldosMensuales.Año =" & c1numAñoConsolidar.Value & ") AND (CTSaldosMensuales.Mes =" & rsiClsCad.NumMes(cmbMesConsolidar.Text) & ") ORDER BY CTSaldosMensuales.Cuenta"
            cnSQLConFuente = New SqlClient.SqlConnection(strConexionFuente)
            cnSQLConFuente.Open()
            cmdComando = cnSQLConFuente.CreateCommand
            cmdComando.CommandType = CommandType.Text
            cmdComando.CommandText = strSQL
            drDatos = cmdComando.ExecuteReader
            intLin = 1
            While drDatos.Read
                If drDatos("Posteable") Then
                    Me.BindingSourceTransDet.AddNew()
                    Dim drTransDet As DataRowView = Me.BindingSourceTransDet.Current
                    drTransDet("NoTransaccion") = "CONSOL"
                    drTransDet("Fecha") = c1numAñoConsolidar.Text & "-" & Trim(Str(rsiClsCad.NumMes(cmbMesConsolidar.Text))) & "-1"
                    drTransDet("Linea") = intLin
                    drTransDet("Año") = c1numAñoConsolidar.Value
                    drTransDet("Mes") = rsiClsCad.NumMes(cmbMesConsolidar.Text)
                    drTransDet("Descripcion") = "Partida de Consolidación"
                    drTransDet("Cuenta") = drDatos("Cuenta")
                    If drDatos("DebitosMes") Then
                        drTransDet("Debe") = drDatos("DebitosMes")
                    End If
                    If drDatos("CreditosMes") Then
                        drTransDet("Haber") = drDatos("CreditosMes")
                    End If
                    intLin = intLin + 1
                    drTransDet.EndEdit()
                End If
            End While
            Me.CTTransaccionesDetalleTableAdapter.Update(Me.CTConsolidacionDataSet.CTTransaccionesDetalle)
            cnSQLConFuente.Close()
            lblMensaje.Visible = False
            lblMensaje.Refresh()

            MsgBox("Proceso terminado...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub EliminarDatos()
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(strConexionDest)
        cnSQLConexion.Open()
        cmdComando = cnSQLConexion.CreateCommand
        cmdComando.CommandType = CommandType.Text
        cmdComando.CommandText = "DELETE FROM CTTransaccionesDetalle"
        cmdComando.ExecuteNonQuery()
        cnSQLConexion.Close()

        cnSQLConexion = New SqlClient.SqlConnection(strConexionDest)
        cnSQLConexion.Open()
        cmdComando = cnSQLConexion.CreateCommand
        cmdComando.CommandType = CommandType.Text
        cmdComando.CommandText = "DELETE FROM CTTransaccionesEncabezado"
        cmdComando.ExecuteNonQuery()
        cnSQLConexion.Close()

        cnSQLConexion = New SqlClient.SqlConnection(strConexionDest)
        cnSQLConexion.Open()
        cmdComando = cnSQLConexion.CreateCommand
        cmdComando.CommandType = CommandType.Text
        cmdComando.CommandText = "DELETE FROM CTSaldosMensuales"
        cmdComando.ExecuteNonQuery()
        cnSQLConexion.Close()

        cnSQLConexion = New SqlClient.SqlConnection(strConexionDest)
        cnSQLConexion.Open()
        cmdComando = cnSQLConexion.CreateCommand
        cmdComando.CommandType = CommandType.Text
        cmdComando.CommandText = "DELETE FROM CTCatalogoCuentas"
        cmdComando.ExecuteNonQuery()
        cnSQLConexion.Close()
    End Sub
End Class