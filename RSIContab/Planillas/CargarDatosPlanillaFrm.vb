Public Class CargarDatosPlanillaFrm
    Dim PlCls As New PLClassLib.PlClass
    Dim drDatosEmp As SqlClient.SqlDataReader
    Dim drCnf As SqlClient.SqlDataReader
    Dim strTipoPlani As String

    Private Sub CargarDatosPlanillaFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PLCargarDatosPlanillaDataSet.PLPlanillas' Puede moverla o quitarla según sea necesario.
        Me.PLPlanillasTableAdapter.Fill(Me.PLCargarDatosPlanillaDataSet.PLPlanillas)
        PlCls.DBconStr = strcnCAD
        drCnf = PlCls.drConf
        lblAño.Text = drCnf("AñoEnProceso")
        lblMes.Text = drCnf("MesEnProceso")
        lblNoPlanilla.Text = drCnf("NoPlanilla")
        If PlCls.PlanillaCerrada(drCnf("AñoEnProceso"), drCnf("MesEnProceso"), drCnf("NoPlanilla")) Then
            MsgBox("La planilla de este período ya está cerrada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            cmdAceptar.Enabled = False
        End If
        If PlCls.PlanillaConDatos(drCnf("AñoEnProceso"), drCnf("MesEnProceso"), drCnf("NoPlanilla")) Then
            MsgBox("La planilla de este período ya tiene datos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            cmdAceptar.Enabled = False
        End If
        If drCnf("NoPlanilla") = drCnf("NoPlanilla13vo") Then
            strTipoPlani = "13VO"
        ElseIf drCnf("NoPlanilla") = drCnf("NoPlanilla14vo") Then
            strTipoPlani = "14VO"
        Else
            strTipoPlani = "ORD"
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim cnSQLConexion As Data.SqlClient.SqlConnection, cnSQLPLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand, cmdPlComando As SqlClient.SqlCommand
        Dim drDatosEmpleados As SqlClient.SqlDataReader, drDatosPl As SqlClient.SqlDataReader
        Dim decSueldoNormal As Decimal, decTotalIng As Decimal
        Dim mDatos As DataRowView
        Dim strSQL As String, strEmp As String

        Try
            cnSQLPLConexion = New SqlClient.SqlConnection(strcnCAD)
            cnSQLPLConexion.Open()

            cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
            cnSQLConexion.Open()
            cmdInComando = cnSQLConexion.CreateCommand
            cmdInComando.CommandType = CommandType.Text
            cmdInComando.CommandText = "SELECT CodigoEmpleado,Nombre1,Nombre2,Apellido1,Apellido2,CodigoSede,CodigoDepartamento,CodigoSeccion,Banco,SalarioMensual,FechaIngreso " _
                & "FROM PLEmpleados WHERE RetiradoDeEmpresa=0 ORDER BY CodigoEmpleado"
            drDatosEmpleados = cmdInComando.ExecuteReader
            If strTipoPlani = "ORD" Then
                While drDatosEmpleados.Read
                    decSueldoNormal = drDatosEmpleados("SalarioMensual") / drCnf("PlanillasPorMes")

                    strEmp = drDatosEmpleados("CodigoEmpleado")
                    PLCargarPlaniBindingSource.AddNew()
                    mDatos = PLCargarPlaniBindingSource.Current
                    mDatos("Año") = drCnf("AñoEnProceso")
                    mDatos("Mes") = drCnf("MesEnProceso")
                    mDatos("NoPlanilla") = drCnf("NoPlanilla")
                    mDatos("CodigoSede") = drDatosEmpleados("CodigoSede")
                    mDatos("CodigoDepartamento") = drDatosEmpleados("CodigoDepartamento")
                    mDatos("CodigoSeccion") = drDatosEmpleados("CodigoSeccion")
                    mDatos("CodigoEmpleado") = drDatosEmpleados("CodigoEmpleado")
                    mDatos("DiasTrabajados") = Math.Round(30 / drCnf("PlanillasPorMes"), 2)
                    mDatos("SueldoNormal") = decSueldoNormal
                    mDatos("Banco") = drDatosEmpleados("Banco")
                End While
                Me.Validate()
                Me.PLCargarPlaniBindingSource.EndEdit()
                Me.PLPlanillasTableAdapter.Update(Me.PLCargarDatosPlanillaDataSet.PLPlanillas)
                MsgBox("Proceso concluido...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            End If
            If strTipoPlani = "13VO" Or strTipoPlani = "14VO" Then
                While drDatosEmpleados.Read
                    strEmp = drDatosEmpleados("CodigoEmpleado")
                    decTotalIng = 0
                    If DateDiff("yyyy", drDatosEmpleados("FechaIngreso"), drCnf("FechaProceso")) >= 1 Then 'Si el empleado tiene uno o mas años de trabajar
                        If strTipoPlani = "13VO" Then
                            cmdPlComando = cnSQLPLConexion.CreateCommand
                            cmdPlComando.CommandType = CommandType.Text
                            cmdPlComando.CommandText = "SELECT SUM(SueldoNormal) AS TotalIngresos FROM PLPlanillas WHERE Año=" & drCnf("AñoEnProceso") & " AND Mes<12 AND CodigoEmpleado='" & drDatosEmpleados("CodigoEmpleado") & "' AND (NoPlanilla<>" & drCnf("NoPlanilla13vo") & ") AND (NoPlanilla<>" & drCnf("NoPlanilla14vo") & ")"
                            drDatosPl = cmdPlComando.ExecuteReader
                            drDatosPl.Read()
                            If drDatosPl.HasRows Then
                                decTotalIng = drDatosPl("TotalIngresos")
                            End If
                            drDatosPl.Close()
                        Else    '14vo
                            strSQL = "(Año=" & (drCnf("AñoEnProceso") - 1) & ") AND (Mes>=7) AND (CodigoEmpleado='" & drDatosEmpleados("CodigoEmpleado") & "') AND (NoPlanilla<>" & drCnf("NoPlanilla13vo") & ") AND (NoPlanilla<>" & drCnf("NoPlanilla14vo") & ")"
                            cmdPlComando = cnSQLPLConexion.CreateCommand
                            cmdPlComando.CommandType = CommandType.Text
                            cmdPlComando.CommandText = "SELECT SUM(SueldoNormal) AS TotalIngresos FROM PLPlanillas WHERE " & strSQL
                            drDatosPl = cmdPlComando.ExecuteReader
                            drDatosPl.Read()
                            If drDatosPl.HasRows Then
                                decTotalIng = drDatosPl("TotalIngresos")
                            End If
                            drDatosPl.Close()

                            strSQL = "(Año=" & drCnf("AñoEnProceso") & ") AND (Mes<=5) AND (CodigoEmpleado='" & drDatosEmpleados("CodigoEmpleado") & "') AND (NoPlanilla<>" & drCnf("NoPlanilla13vo") & ") AND (NoPlanilla<>" & drCnf("NoPlanilla14vo") & ")"
                            cmdPlComando = cnSQLPLConexion.CreateCommand
                            cmdPlComando.CommandType = CommandType.Text
                            cmdPlComando.CommandText = "SELECT SUM(SueldoNormal) AS TotalIngresos FROM PLPlanillas WHERE " & strSQL
                            drDatosPl = cmdPlComando.ExecuteReader
                            drDatosPl.Read()
                            If drDatosPl.HasRows Then
                                decTotalIng = decTotalIng + drDatosPl("TotalIngresos")
                            End If
                            drDatosPl.Close()
                        End If
                    Else    ' El Empleado tiene menos de un año
                        If strTipoPlani = "13VO" Then
                            strSQL = "(Año=" & Year(drDatosEmpleados("FechaIngreso")) & ") AND (Mes<12) AND (CodigoEmpleado='" & drDatosEmpleados("CodigoEmpleado") & "') AND (NoPlanilla<>" & drCnf("NoPlanilla13vo") & ") AND (NoPlanilla<>" & drCnf("NoPlanilla14vo") & ")"
                            cmdPlComando = cnSQLPLConexion.CreateCommand
                            cmdPlComando.CommandType = CommandType.Text
                            cmdPlComando.CommandText = "SELECT SUM(SueldoNormal) AS TotalIngresos FROM PLPlanillas WHERE " & strSQL
                            drDatosPl = cmdPlComando.ExecuteReader
                            drDatosPl.Read()
                            If drDatosPl.HasRows Then
                                If Not String.IsNullOrEmpty(drDatosPl("TotalIngresos").ToString) Then
                                    decTotalIng = drDatosPl("TotalIngresos")
                                End If
                            End If
                            drDatosPl.Close()
                        Else    '14vo
                            If drCnf("AñoEnProceso") = Year(drDatosEmpleados("FechaIngreso")) Then  'Entró en los primeros 6 meses del año
                                strSQL = "(Año=" & Year(drDatosEmpleados("FechaIngreso")) & ") AND (Mes<=5) AND (CodigoEmpleado='" & drDatosEmpleados("CodigoEmpleado") & "') AND (NoPlanilla<>" & drCnf("NoPlanilla13vo") & ") AND (NoPlanilla<>" & drCnf("NoPlanilla14vo") & ")"
                                cmdPlComando = cnSQLPLConexion.CreateCommand
                                cmdPlComando.CommandType = CommandType.Text
                                cmdPlComando.CommandText = "SELECT SUM(SueldoNormal) AS TotalIngresos FROM PLPlanillas WHERE " & strSQL
                                drDatosPl = cmdPlComando.ExecuteReader
                                drDatosPl.Read()
                                If drDatosPl.HasRows Then
                                    If Not String.IsNullOrEmpty(drDatosPl("TotalIngresos").ToString) Then
                                        decTotalIng = drDatosPl("TotalIngresos")
                                    End If
                                End If
                                drDatosPl.Close()
                            Else    'Entró en el año anterior
                                strSQL = "(Año=" & Year(drDatosEmpleados("FechaIngreso")) & ") AND (Mes>=7) AND (CodigoEmpleado='" & drDatosEmpleados("CodigoEmpleado") & "') AND (NoPlanilla<>" & drCnf("NoPlanilla13vo") & ") AND (NoPlanilla<>" & drCnf("NoPlanilla14vo") & ")"
                                cmdPlComando = cnSQLPLConexion.CreateCommand
                                cmdPlComando.CommandType = CommandType.Text
                                cmdPlComando.CommandText = "SELECT SUM(SueldoNormal) AS TotalIngresos FROM PLPlanillas WHERE " & strSQL
                                drDatosPl = cmdPlComando.ExecuteReader
                                drDatosPl.Read()
                                If drDatosPl.HasRows Then
                                    decTotalIng = drDatosPl("TotalIngresos")
                                End If
                                drDatosPl.Close()

                                strSQL = "(Año=" & drCnf("AñoEnProceso") & ") AND Mes<=5 AND (CodigoEmpleado='" & drDatosEmpleados("CodigoEmpleado") & "') AND (NoPlanilla<>" & drCnf("NoPlanilla13vo") & ") AND (NoPlanilla<>" & drCnf("NoPlanilla14vo") & ")"
                                cmdPlComando = cnSQLPLConexion.CreateCommand
                                cmdPlComando.CommandType = CommandType.Text
                                cmdPlComando.CommandText = "SELECT SUM(SueldoNormal) AS TotalIngresos FROM PLPlanillas WHERE " & strSQL
                                drDatosPl = cmdPlComando.ExecuteReader
                                drDatosPl.Read()
                                If drDatosPl.HasRows Then
                                    decTotalIng = decTotalIng + drDatosPl("TotalIngresos")
                                End If
                                drDatosPl.Close()
                            End If
                        End If
                    End If
                    If decTotalIng > 0 Then
                        decTotalIng = (decTotalIng + drDatosEmpleados("SalarioMensual")) / 12
                    End If
                    PLCargarPlaniBindingSource.AddNew()
                    mDatos = PLCargarPlaniBindingSource.Current
                    mDatos("Año") = drCnf("AñoEnProceso")
                    mDatos("Mes") = drCnf("MesEnProceso")
                    mDatos("NoPlanilla") = drCnf("NoPlanilla")
                    mDatos("CodigoSede") = drDatosEmpleados("CodigoSede")
                    mDatos("CodigoDepartamento") = drDatosEmpleados("CodigoDepartamento")
                    mDatos("CodigoSeccion") = drDatosEmpleados("CodigoSeccion")
                    mDatos("CodigoEmpleado") = drDatosEmpleados("CodigoEmpleado")
                    mDatos("DiasTrabajados") = 0
                    mDatos("SueldoNormal") = decTotalIng
                    mDatos("Banco") = drDatosEmpleados("Banco")
                End While
                Me.Validate()
                Me.PLCargarPlaniBindingSource.EndEdit()
                Me.PLPlanillasTableAdapter.Update(Me.PLCargarDatosPlanillaDataSet.PLPlanillas)
                MsgBox("Proceso concluido...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " - Empleado: " & strEmp)
        Finally
            cnSQLConexion.Close()
        End Try
    End Sub
End Class