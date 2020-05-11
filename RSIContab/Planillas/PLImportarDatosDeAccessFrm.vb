Public Class PLImportarDatosDeAccessFrm
    Dim strSQL As String
    Dim conAcc As System.Data.OleDb.OleDbConnection = New System.Data.OleDb.OleDbConnection()
    Dim cmdAcc As System.Data.OleDb.OleDbCommand
    Dim drAcc As System.Data.OleDb.OleDbDataReader
    Dim intAño As Int16, intMes As Int16

    Private Sub PLImportarDatosDeAccessFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbTablas.Items.Add("Sedes")
        cmbTablas.Items.Add("Departamentos")
        cmbTablas.Items.Add("Secciones")
        cmbTablas.Items.Add("Tipos de Empleados")
        cmbTablas.Items.Add("Bancos")
        cmbTablas.Items.Add("Tabla ISR")
        cmbTablas.Items.Add("Tabla Imp. Vecinal")
        cmbTablas.Items.Add("Tabla Vacaciones")
        cmbTablas.Items.Add("Empleados")
        cmbTablas.Items.Add("Def. Deducciones")
        cmbTablas.Items.Add("Planillas")
        cmbTablas.Items.Add("Planillas Det")
        cmbTablas.Items.Add("Deducciones")
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim i As Int16

        If cmbTablas.SelectedItem = "Planillas" Or cmbTablas.SelectedItem = "Planillas Det" Or cmbTablas.SelectedItem = "Deducciones" Then
            intAño = CInt(txtAño.Text)
            intMes = CInt(txtMes.Text)
            If chkProcesarAño.Checked Then
                For i = 1 To 12
                    intMes = i
                    Procesar()
                Next
            Else
                Procesar()
            End If
        Else
            Procesar()
        End If
    End Sub
    Private Sub Procesar()
        Dim cnSQLCon As Data.SqlClient.SqlConnection
        Dim cmdSQL As Data.SqlClient.SqlCommand
        Dim strSQL As String
        'Dim drItem As Data.SqlClient.SqlDataReader
        'Dim drFacEnc As Data.SqlClient.SqlDataReader
        Dim mFecha1 As String, mFecha2 As String, mfecha3 As String, mFecha4 As String, mFecha As Date
        Dim intNivelAcad As Int16
        'Dim strTipoCli As String, 
        Dim strCodPuesto As String, strCodProfesion As String, mMes As String, strBanco As String

        cnSQLCon = New SqlClient.SqlConnection(strcnCAD)
        cnSQLCon.Open()

        AbrirTablaAccess()
        While drAcc.Read()
            cmdSQL = cnSQLCon.CreateCommand
            cmdSQL.CommandType = CommandType.Text
            Select Case cmbTablas.Text
                Case "Sedes"
                    strSQL = "INSERT INTO PLSedes (CodigoSede, DescripcionSede) VALUES ('" & drAcc("Codigo de Sede") & "','" & drAcc("Descripcion de Sede") & "')"
                Case "Departamentos"
                    strSQL = "INSERT INTO PLDepartamentos (CodigoSede,CodigoDepartamento,DescripcionDepartamento) VALUES('" & drAcc("Codigo de Sede") & "','" & drAcc("Codigo de Departamento") & "','" & drAcc("Descripcion de Departamento") & "')"
                Case "Secciones"
                    strSQL = "INSERT INTO PLSecciones (CodigoSede,CodigoDepartamento,CodigoSeccion,DescripcionSeccion) VALUES('" & drAcc("Codigo de Sede") & "','" & drAcc("Codigo de Departamento") & "','" & drAcc("Codigo de Seccion") & "','" & drAcc("Descripcion de Seccion") & "')"
                Case "Tipos de Empleados"
                    strSQL = "INSERT INTO PLTiposEmpleados (CodigoTipoEmpleado,DescripcionTipoEmpleado) VALUES('" & drAcc("Codigo de Tipo") & "','" & drAcc("Descripcion de Tipo") & "')"
                Case "Puestos"
                    strSQL = "INSERT INTO PLPuestos (CodigoPuestos, DescripcionPuesto) VALUES ('" & drAcc("Codigo de Puesto") & "','" & drAcc("Puesto") & "')"
                Case "Bancos"
                    strSQL = "INSERT INTO PLBancos (Banco) VALUES ('" & drAcc("Banco") & "')"
                Case "Tabla ISR"
                    strSQL = "INSERT INTO PLTablaISR (ValorInicial, ValorFinal,Porcentaje) VALUES (" & drAcc("Valor Inicial") & "," & drAcc("Valor Final") & "," & drAcc("Porcentaje") & ")"
                Case "Tabla Imp. Vecinal"
                    strSQL = "INSERT INTO PLTablaImpuestoVecinal (ValorInicial, ValorFinal,ImpuestoMillar,ImpuestoTramo,ImpuestoAcumulado) VALUES (" & drAcc("Valor Inicial") & "," & drAcc("Valor Final") & "," & drAcc("Impuesto por Millar") & "," & drAcc("Impuesto por Tramo") & "," & drAcc("Impuesto Acumulado") & ")"
                Case "Tabla Vacaciones"
                    strSQL = "INSERT INTO PLTablaDiasVacaciones (AñosLaborados, DiasVacaciones) VALUES (" & drAcc("Años Laborados") & "," & drAcc("Dias de Vacaciones") & ")"
                Case "Empleados"
                    If Not String.IsNullOrEmpty(drAcc("Nivel Academico").ToString) Then
                        If drAcc("Nivel Academico") = "BACH. COMPUTACION" Or drAcc("Nivel Academico") = "BACHILLER  EN  COMPUTACION " Or drAcc("Nivel Academico") = "BACHILLER  EN  COMPUTACION " Or Strings.Left(drAcc("Nivel Academico"), 5) = "TECNI" Or drAcc("Nivel Academico") = "CICLO BASICO TECNICO" Then
                            intNivelAcad = 3
                        End If
                        If drAcc("Nivel Academico") = "CICLO  COMUN " Or drAcc("Nivel Academico") = "SECUNDARIA" Or drAcc("Nivel Academico") = "EDUCACION SECUNDARIA " Or drAcc("Nivel Academico") = "CICLO COMUN" Or drAcc("Nivel Academico") = "DIVERSIFICADO" Or drAcc("Nivel Academico") = "HIGH SCOOL" Or drAcc("Nivel Academico") = "BACHILLER EN CIENCIAS Y LETRAS" Then
                            intNivelAcad = 2
                        End If
                        If Strings.Left(drAcc("Nivel Academico"), 5) = "PRIMA" Or drAcc("Nivel Academico") = "CUARTO GRADO " Then
                            intNivelAcad = 1
                        End If
                        If Strings.Left(drAcc("Nivel Academico"), 6) = "UNIVER" Or Strings.Left(drAcc("Nivel Academico"), 7) = "PASANTE" Or Strings.Left(drAcc("Nivel Academico"), 3) = "ING" Then
                            intNivelAcad = 4
                        End If
                    Else
                        intNivelAcad = 1
                    End If
                    If String.IsNullOrEmpty(drAcc("Puesto").ToString) Then
                        strCodPuesto = "999"
                    Else
                        strCodPuesto = ObtenerCodigoPuesto(drAcc("Puesto"))
                    End If
                    If String.IsNullOrEmpty(drAcc("Profesion u Oficio").ToString) Then
                        strCodProfesion = "999"
                    Else
                        strCodProfesion = ObtenerCodigoProfesion(drAcc("Profesion u Oficio"))
                    End If
                    If String.IsNullOrEmpty(drAcc("Fecha de Nacimiento").ToString) Then
                        mFecha1 = ""
                    Else
                        mFecha = drAcc("Fecha de Nacimiento")
                        mFecha1 = Str(mFecha.Day) & "/" & Str(mFecha.Month) & "/" & Str(mFecha.Year)
                    End If
                    If String.IsNullOrEmpty(drAcc("Fecha de Ingreso").ToString) Then
                        mFecha2 = ""
                    Else
                        mFecha = drAcc("Fecha de Ingreso")
                        mFecha2 = Str(mFecha.Day) & "/" & Str(mFecha.Month) & "/" & Str(mFecha.Year)
                    End If
                    If String.IsNullOrEmpty(drAcc("Fecha Ingreso por Contrato").ToString) Then
                        mfecha3 = ""
                    Else
                        mFecha = drAcc("Fecha Ingreso por Contrato")
                        mfecha3 = Str(mFecha.Day) & "/" & Str(mFecha.Month) & "/" & Str(mFecha.Year)
                    End If
                    If String.IsNullOrEmpty(drAcc("Fecha de Retiro").ToString) Then
                        mFecha4 = ""
                    Else
                        mFecha = drAcc("Fecha de Retiro")
                        mFecha4 = Str(mFecha.Day) & "/" & Str(mFecha.Month) & "/" & Str(mFecha.Year)
                    End If
                    If String.IsNullOrEmpty(drAcc("Banco").ToString) Then
                        strBanco = ""
                    Else
                        strBanco = IIf(drAcc("Banco") = "BGA", "HSBC", drAcc("Banco"))
                    End If
                    strSQL = "INSERT INTO PLEmpleados (CodigoEmpleado, Nombre1, Nombre2, Apellido1, Apellido2, Identificacion1, Identificacion2, Sexo, Nacionalidad, LugarNacimiento, FechaNacimiento, " _
                        & "DireccionActual, Telefono, NivelAcademico, CodigoProfesion, EstadoCivil, Dependientes, TipoSangre, NoSeguroSocial, NoRTN, CodigoPuesto, " _
                        & "CodigoSede, CodigoDepartamento, CodigoSeccion, CodigoTipoEmpleado, EsDocente, EsVendedor, EsCobrador, IngresoPorComision, FechaIngreso, " _
                        & "FechaIngresoContrato, DeVacaciones, DePermiso, RetiradoDeEmpresa, FechaRetiro, MetodoPago, TipoPago, SalarioMensual, " _
                        & "SalarioHora, Banco, NoCuentaBancaria, NoDeducirRAP, Fotografia) VALUES ('" & drAcc("Codigo de Empleado") & "','" & drAcc("Nombre1") & "','" & drAcc("Nombre2") & "','" _
                        & drAcc("Apellido1") & "','" & drAcc("Apellido2") & "','" & drAcc("No de Identificacion") & "','" & drAcc("Placa") & "','" & drAcc("Sexo") & "','" & drAcc("Nacionalidad") & "','" _
                        & drAcc("Lugar de Nacimiento") & "','" & mFecha1 & "','" & drAcc("Direccion Actual") & "','" & drAcc("Telefono") & "'," & intNivelAcad & ",'" & strCodProfesion & "','" _
                        & drAcc("Estado Civil") & "'," & drAcc("Dependientes") & ",'" & drAcc("Tipo de Sangre") & "','" & drAcc("No Seguro Social") & "','" & drAcc("Carnet RTN") & "','" & strCodPuesto & "','" _
                        & drAcc("Codigo de Sede") & "','" & drAcc("Codigo de Departamento") & "','" & drAcc("Codigo de Seccion") & "','" & drAcc("Tipo de Empleado") & "'," & IIf(drAcc("Empleado Docente") = -1, 1, 0) & "," & IIf(drAcc("Vendedor") = -1, 1, 0) & "," _
                        & IIf(drAcc("Cobrador") = -1, 1, 0) & "," & IIf(drAcc("Ingreso en Base a Comision") = -1, 1, 0) & ",'" & mFecha2 & "','" & mfecha3 & "'," & IIf(drAcc("Esta de Vacaciones") = -1, 1, 0) & "," _
                        & IIf(drAcc("Esta Con Permiso") = -1, 1, 0) & "," & IIf(drAcc("Retirado de la Empresa") = -1, 1, 0) & ",'" & mFecha4 & "','" & drAcc("Metodo de Pago") & "','" & drAcc("Tipo de Pago") & "'," _
                        & drAcc("Salario Mensual") & "," & drAcc("Salario por Hora") & ",'" & strBanco & "','" & drAcc("No de Cuenta Bancaria") & "'," & IIf(drAcc("No Deducir RAP") = -1, 1, 0) & ",'" & drAcc("Fotografia") & "')"

                Case "Def. Deducciones"
                    strSQL = "INSERT INTO PLDefinicionDeducciones (CodigoDeduccion, DescripcionDeduccion,DeduccionPermanente,RepTituloColumna,RepNoColumna,RepTotEnOtrasDeducciones,AplicarEnPlanillaVacaciones,AplicarEnPlanilla13VO,AplicarEnPlanilla14VO) " _
                        & "VALUES ('" & drAcc("Codigo de Deduccion") & "','" & drAcc("Descripcion de Deduccion") & "'," & IIf(drAcc("Deduccion Permanente") = -1, 1, 0) & ",'" & drAcc("Titulo") & "'," & drAcc("No de Columna") & "," _
                        & IIf(drAcc("Totalizar en Otras Deducciones") = -1, 1, 0) & "," & IIf(drAcc("Aplicar en Planilla de Vacaciones") = -1, 1, 0) & "," & IIf(drAcc("Aplicar en Planilla del 13vo") = -1, 1, 0) & "," & IIf(drAcc("Aplicar en Planilla del 14vo") = -1, 1, 0) & ")"
                Case "Planillas"
                    If intMes >= 10 Then
                        mMes = Strings.Trim(Str(intMes))
                    Else
                        mMes = "0" & Strings.Trim(Str(intMes))
                    End If
                    strSQL = "INSERT INTO PLPlanillas (Año, Mes, NoPlanilla, CodigoSede, CodigoDepartamento, CodigoSeccion, CodigoEmpleado, DiasTrabajados, SueldoNormal, DiasFeriados, " _
                        & "SueldoAdicionalFeriados, HorasTarde, ValorHorastarde, HorasExtras25, ValorHorasExtras25, HorasExtras50, ValorHorasExtras50, HorasExtras75, " _
                        & "ValorHorasExtras75, HorasExtrasDobles, ValorHorasExtrasDobles, Comisiones, Bonificaciones, Vacaciones,IngresosAdicionales1, IngresosAdicionales2," _
                        & "IngresosAdicionales3, IngresosAdicionales4, IngresosAdicionales5, SeguroSocial, RAP, ImpuestoVecinal, ImpuestoSobreRenta, INJUPEMP, INPREMA," _
                        & "DeduccionFija1, DeduccionFija2, DeduccionFija3, DeduccionFija4, DeduccionFija5, OtrasDeducciones, Banco, Cerrado) " _
                        & "Values (" & CInt(txtAño.Text) & "," & intMes & "," & drAcc("No de Planilla") & ",'" & drAcc("Codigo de Sede") & "','" & drAcc("Codigo de Departamento") & "','" & drAcc("Codigo de Seccion") & "','" _
                        & drAcc("Codigo de Empleado") & "'," & drAcc("Dias Trabajados") & "," & drAcc("Sueldo Normal") & "," & drAcc("Dias Feriados") & "," & drAcc("Sueldo Adicional Feriados") & "," _
                        & drAcc("Horas Tarde") & "," & drAcc("Valor Horas Tarde") & "," & drAcc("Horas Extras 25%") & "," & drAcc("Valor Extras 25%") & "," & drAcc("Horas Extras 50%") & "," _
                        & drAcc("Valor Extras 50%") & "," & drAcc("Horas Extras 75%") & "," & drAcc("Valor Extras 75%") & "," & drAcc("Horas Extras Dobles") & "," & drAcc("Valor Extras Dobles") & "," _
                        & drAcc("Comisiones") & "," & drAcc("Bonificaciones") & "," & drAcc("Vacaciones") & "," & drAcc("Transporte") & "," & drAcc("Combustible") & "," & drAcc("Depreciacion de Vehiculo") & "," _
                        & drAcc("Prestamos") & "," & drAcc("Otros Ingresos") & "," & drAcc("Seguro Social") & "," & drAcc("RAP") & "," & drAcc("Impuesto Vecinal") & "," & drAcc("Impuesto Sobre la Renta") & "," _
                        & drAcc("INJUPEMP") & "," & drAcc("Inprema") & "," & drAcc("Donaciones") & "," & drAcc("Pensiones") & "," & drAcc("Colegios Profesionales") & "," & drAcc("Seguro de Vida") & "," _
                        & drAcc("Cooperativa") & "," & drAcc("Otras Deducciones") & ",'" & drAcc("Banco") & "'," & IIf(drAcc("Cerrado") = -1, 1, 0) & ")"
                Case "Planillas Det"
                    If intMes >= 10 Then
                        mMes = Strings.Trim(Str(intMes))
                    Else
                        mMes = "0" & Strings.Trim(Str(intMes))
                    End If
                    If String.IsNullOrEmpty(drAcc("Fecha").ToString) Then
                        mFecha1 = ""
                    Else
                        mFecha = drAcc("Fecha")
                        mFecha1 = Str(mFecha.Day) & "/" & Str(mFecha.Month) & "/" & Str(mFecha.Year)
                    End If
                    strSQL = "INSERT INTO PLPlanillasOT (Año, Mes, NoPlanilla, CodigoSede,CodigoDepartamento, CodigoSeccion, CodigoEmpleado, CodigoDeduccion, Fecha, " _
                        & "NoDocumento, Valor, Aplicada, Referencia) VALUES (" & CInt(txtAño.Text) & "," & intMes & "," & drAcc("No de Planilla") & ",'" & drAcc("Codigo de Sede") & "','" _
                        & drAcc("Codigo de Departamento") & "','" & drAcc("Codigo de Seccion") & "','" & drAcc("Codigo de Empleado") & "','" & drAcc("Codigo de Deduccion") & "','" _
                        & mFecha1 & "'," & drAcc("No de Documento") & "," & drAcc("Valor") & "," & IIf(drAcc("Aplicada") = -1, 1, 0) & ",'" & drAcc("Referencia") & "')"
                Case "Deducciones"
                    'PlanillaNo=2 solamente para ENLACE
                    If intMes >= 10 Then
                        mMes = Strings.Trim(Str(intMes))
                    Else
                        mMes = "0" & Strings.Trim(Str(intMes))
                    End If
                    mFecha = drAcc("Fecha").ToString
                    mFecha1 = Str(mFecha.Day) & "/" & Str(mFecha.Month) & "/" & Str(mFecha.Year)
                    strSQL = "INSERT INTO PLDeducciones (Año, Mes, Fecha, CodigoDeduccion, CodigoEmpleado, PlanillaNo,Valor,NoMesesDeducir,DeduccionMensual,DeduccionPermanente," _
                        & "MontoDeducido,NoPlanillasDeducidas,Referencia,DeduccionPlanilla1,DeduccionPlanilla2) VALUES(" & CInt(txtAño.Text) & "," & intMes & ",'" & mFecha1 & "','" _
                        & drAcc("Codigo de Deduccion") & "','" & drAcc("Codigo de Empleado") & "',1," & drAcc("Valor") & "," & drAcc("No de Planillas a Deducir") & "," & drAcc("Monto a Deducir en Cada Planilla") & "," _
                        & IIf(drAcc("Deduccion Permanente") = -1, 1, 0) & "," & drAcc("Monto Ya Deducido") & "," & drAcc("No de Planillas Ya Deducidas") & ",'" & drAcc("Referencia") & "'," & drAcc("Deduccion Planilla1") & "," & drAcc("Deduccion Planilla2") & ")"
            End Select
            cmdSQL.CommandText = strSQL
            cmdSQL.ExecuteNonQuery()
        End While
        cnSQLCon.Close()
        conAcc.Close()
        MsgBox("Proceso terminado...")

    End Sub

    Private Sub AbrirTablaAccess()
        Dim mMes As String
        conAcc.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & txtBaseDatosAccess.Text
        conAcc.Open()
        cmdAcc = conAcc.CreateCommand
        cmdAcc.CommandType = CommandType.Text

        Select Case cmbTablas.Text
            Case "Sedes"
                strSQL = "SELECT * FROM Sedes ORDER BY [Codigo de Sede]"
            Case "Departamentos"
                strSQL = "SELECT * FROM Departamentos ORDER BY [Codigo de Sede],[Codigo de Departamento]"
            Case "Secciones"
                strSQL = "SELECT * FROM Secciones ORDER BY [Codigo de sede],[Codigo de Departamento],[Codigo de Seccion]"
            Case "Tipos de Empleados"
                strSQL = "SELECT * FROM [Tipos de Empleados] ORDER BY [Codigo de Tipo]"
            Case "Bancos"
                strSQL = "SELECT * FROM Bancos ORDER BY Banco"
            Case "Tabla ISR"
                strSQL = "SELECT * FROM [Tabla del ISR] ORDER BY [Valor Inicial]"
            Case "Tabla Imp. Vecinal"
                strSQL = "SELECT * FROM [Tabla del Impuesto Vecinal] ORDER BY [Valor Inicial]"
            Case "Tabla Vacaciones"
                strSQL = "SELECT * FROM [Tabla de Dias de Vacaciones] ORDER BY [Años Laborados]"
            Case "Empleados"
                strSQL = "SELECT * FROM Empleados ORDER BY [Codigo de Empleado]"
            Case "Def. Deducciones"
                strSQL = "SELECT * FROM Deducciones ORDER BY [Codigo de Deduccion]"
            Case "Planillas"
                If intMes >= 10 Then
                    mMes = Strings.Trim(Str(intMes))
                Else
                    mMes = "0" & Strings.Trim(Str(intMes))
                End If
                strSQL = "SELECT * FROM PL" & Strings.Right(txtAño.Text, 2) & mMes & " ORDER BY [No de Planilla],[Codigo de Empleado]"
            Case "Planillas Det"
                If intMes >= 10 Then
                    mMes = Strings.Trim(Str(intMes))
                Else
                    mMes = "0" & Strings.Trim(Str(intMes))
                End If
                strSQL = "SELECT * FROM PL" & Strings.Right(txtAño.Text, 2) & mMes & "OT ORDER BY [No de Planilla],[Codigo de Empleado],[Codigo de Deduccion]"
            Case "Deducciones"
                If intMes >= 10 Then
                    mMes = Strings.Trim(Str(intMes))
                Else
                    mMes = "0" & Strings.Trim(Str(intMes))
                End If
                strSQL = "SELECT * FROM DE" & Strings.Right(txtAño.Text, 2) & mMes & "PE ORDER BY [Codigo de Empleado],[Codigo de Deduccion]"
        End Select

        cmdAcc.CommandText = strSQL
        drAcc = cmdAcc.ExecuteReader

    End Sub
    Private Function ObtenerCodigoProfesion(ByVal strProfesion As String) As String
        ObtenerCodigoProfesion = ""

        If Strings.Trim(strProfesion) = "LABRADOR" Then
            ObtenerCodigoProfesion = "026"
        End If
        If Strings.Trim(strProfesion) = "AGRICULTOR" Then
            ObtenerCodigoProfesion = "029"
        End If
        If Strings.Trim(strProfesion) = "ASEADORA" Then
            ObtenerCodigoProfesion = "025"
        End If
        If Strings.Trim(strProfesion) = "ASISTENTE DE CAMARAS" Then
            ObtenerCodigoProfesion = "018"
        End If
        If Strings.Trim(strProfesion) = "BACH. EN  COMPUTACION" Or Strings.Trim(strProfesion) = "BACHILLER EN COMPUTACION" Or Strings.Trim(strProfesion) = "BACHILLERATO EN COMPUTACION" Then
            ObtenerCodigoProfesion = "006"
        End If
        If Strings.Trim(strProfesion) = "BACHILLER TECNICO EN ELECTRONICA" Or Strings.Trim(strProfesion) = "BACHILLERATO TECNICO EN ELECTRONICA" Then
            ObtenerCodigoProfesion = "031"
        End If
        If Strings.Trim(strProfesion) = "CAMAROGRAFO" Then
            ObtenerCodigoProfesion = "017"
        End If
        If Strings.Trim(strProfesion) = "DISEÑADOR GRAFICO" Then
            ObtenerCodigoProfesion = "020"
        End If
        If Strings.Trim(strProfesion) = "ELECTRICISTA" Then
            ObtenerCodigoProfesion = "013"
        End If
        If Strings.Trim(strProfesion) = "ING.  INDUSTRIAL Y  SISTEMAS" Then
            ObtenerCodigoProfesion = "005"
        End If
        If Strings.Trim(strProfesion) = "INGENIERO" Then
            ObtenerCodigoProfesion = "032"
        End If
        If Strings.Trim(strProfesion) = "INGENIERO  INDUSTRIAL" Then
            ObtenerCodigoProfesion = "002"
        End If
        If Strings.Trim(strProfesion) = "JEFE DE ADMINISTRACION" Then
            ObtenerCodigoProfesion = "019"
        End If
        If Strings.Trim(strProfesion) = "LIC. ADMINISTRACION DE EMPRESAS" Then
            ObtenerCodigoProfesion = "003"
        End If
        If Strings.Trim(strProfesion) = "LIC. EN RELACIONES INTERNACIONALES" Then
            ObtenerCodigoProfesion = "022"
        End If
        If Strings.Trim(strProfesion) = "Lic.comunicaciones  y Publicidad" Then
            ObtenerCodigoProfesion = "004"
        End If
        If Strings.Trim(strProfesion) = "LICENCIADA  EN PERIODISMO" Or Strings.Trim(strProfesion) = "LICENCIADO EN PERIODISMO" Or Strings.Trim(strProfesion) = "LICENCIATURA EN PERIODISMO" _
            Or Strings.Trim(strProfesion) = "PERIODIDSTA" Or Strings.Trim(strProfesion) = "PERIODIDSMO" Then
            ObtenerCodigoProfesion = "001"
        End If
        If Strings.Trim(strProfesion) = "LOCUTORA" Then
            ObtenerCodigoProfesion = "016"
        End If
        If Strings.Trim(strProfesion) = "MAESTRA DE MUSICA" Then
            ObtenerCodigoProfesion = "015"
        End If
        If Strings.Trim(strProfesion) = "MAESTRO DE EDUCACION PRIMARIA" Then
            ObtenerCodigoProfesion = "024"
        End If
        If Strings.Trim(strProfesion) = "MENSAJERO" Then
            ObtenerCodigoProfesion = "027"
        End If
        If Strings.Trim(strProfesion) = "MOTORISTA" Then
            ObtenerCodigoProfesion = "021"
        End If
        If Strings.Trim(strProfesion) = "OPERADORA DE CARACTERES" Then
            ObtenerCodigoProfesion = "023"
        End If
        If Strings.Trim(strProfesion) = "PERITO  MERCANTIL" Or Strings.Left(Strings.Trim(strProfesion), 16) = "PERITO MERCANTIL" Then
            ObtenerCodigoProfesion = "010"
        End If
        If Strings.Left(Strings.Trim(strProfesion), 9) = "PRODUCTOR" Then
            ObtenerCodigoProfesion = "012"
        End If
        If Strings.Trim(strProfesion) = "SECRETARIA" Or Strings.Trim(strProfesion) = "SECRETARIA COMERCIAL" Then
            ObtenerCodigoProfesion = "014"
        End If
        If Strings.Trim(strProfesion) = "SECRETARIADO BILINGUE" Then
            ObtenerCodigoProfesion = "011"
        End If
        If Strings.Trim(strProfesion) = "TEC. EN SISTEMAS" Then
            ObtenerCodigoProfesion = "030"
        End If
        If Strings.Trim(strProfesion) = "TECNICO  EN  COMPUTACION" Or Strings.Trim(strProfesion) = "TECNICO EN COMPUTACION" Then
            ObtenerCodigoProfesion = "007"
        End If
        If Strings.Trim(strProfesion) = "TECNICO  EN COMUNICACION" Then
            ObtenerCodigoProfesion = "033"
        End If
        If Strings.Trim(strProfesion) = "TECNICO EN ELECTRICIDAD" Then
            ObtenerCodigoProfesion = "034"
        End If
        If Strings.Trim(strProfesion) = "TECNICO EN ELECTRONICA" Or Strings.Trim(strProfesion) = "TECNICO EN ELECTRONICA DIGITAL" Then
            ObtenerCodigoProfesion = "009"
        End If
        If Strings.Trim(strProfesion) = "TECNICO INDUSTRIAL" Or Strings.Trim(strProfesion) = "TECNICO INDUSTRIAL EN ELECTRONICA" Then
            ObtenerCodigoProfesion = "008"
        End If
        If Strings.Trim(strProfesion) = "VIGILANTE" Then
            ObtenerCodigoProfesion = "028"
        End If
    End Function

    Private Function ObtenerCodigoPuesto(ByVal strPuesto As String) As String
        ObtenerCodigoPuesto = ""
        If Strings.Trim(strPuesto) = "ASEADORA" Then
            ObtenerCodigoPuesto = "045"
        End If
        If Strings.Trim(strPuesto) = "PERIODISTA SPS" Then
            ObtenerCodigoPuesto = "004"
        End If
        If Strings.Trim(strPuesto) = "ASISTENTE  DE TELEMARATON" Then
            ObtenerCodigoPuesto = "015"
        End If
        If Strings.Trim(strPuesto) = "ASISTENTE ADMINISTRATIVA" Or Strings.Trim(strPuesto) = "ASISTENTE ADMINISTRATIVO" Then
            ObtenerCodigoPuesto = "011"
        End If
        If Strings.Trim(strPuesto) = "ASISTENTE DE CAMARAS" Then
            ObtenerCodigoPuesto = "012"
        End If
        If Strings.Trim(strPuesto) = "ASISTENTE DE CONTABILIDAD" Then
            ObtenerCodigoPuesto = "013"
        End If
        If Strings.Trim(strPuesto) = "ASISTENTE DE INFORMATICA" Then
            ObtenerCodigoPuesto = "014"
        End If
        If Strings.Trim(strPuesto) = "ASISTENTE DE PRODUCCION" Then
            ObtenerCodigoPuesto = "046"
        End If
        If Strings.Trim(strPuesto) = "ASISTENTE DE TELEMARATON" Then
            ObtenerCodigoPuesto = "015"
        End If
        If Strings.Trim(strPuesto) = "CAMAROGRAFO" Then
            ObtenerCodigoPuesto = "010"
        End If
        If Strings.Trim(strPuesto) = "CONTADORA GENERAL" Then
            ObtenerCodigoPuesto = "016"
        End If
        If Strings.Trim(strPuesto) = "EDITOR" Then
            ObtenerCodigoPuesto = "017"
        End If
        If Strings.Trim(strPuesto) = "EDITOR Y DIRECTOR DE CAMARAS" Then
            ObtenerCodigoPuesto = "018"
        End If
        If Strings.Trim(strPuesto) = "ENCARGADA COLL CENTER" Then
            ObtenerCodigoPuesto = "019"
        End If
        If Strings.Trim(strPuesto) = "ENCARGADO DEL AREA DE INFORMATICA" Then
            ObtenerCodigoPuesto = "020"
        End If
        If Strings.Trim(strPuesto) = "GERENTE GENERAL" Then
            ObtenerCodigoPuesto = "001"
        End If
        If Strings.Trim(strPuesto) = "GESTOR DE COBRANZA" Then
            ObtenerCodigoPuesto = "021"
        End If
        If Strings.Trim(strPuesto) = "JEFA DE PROGRAMACION" Then
            ObtenerCodigoPuesto = "005"
        End If
        If Strings.Trim(strPuesto) = "JEFE DE ADMON. Y FINANZAS" Then
            ObtenerCodigoPuesto = "003"
        End If
        If Strings.Trim(strPuesto) = "JEFE DE DEPTO TECNICO" Then
            ObtenerCodigoPuesto = "007"
        End If
        If Strings.Trim(strPuesto) = "JEFE DE PISO" Then
            ObtenerCodigoPuesto = "006"
        End If
        If Strings.Trim(strPuesto) = "JEFE DE PRODUCCION" Then
            ObtenerCodigoPuesto = "008"
        End If
        If Strings.Trim(strPuesto) = "JEFE DE RECURSOS HUMANOS" Then
            ObtenerCodigoPuesto = "002"
        End If
        If Strings.Trim(strPuesto) = "JEFE REGIONAL  SPS" Then
            ObtenerCodigoPuesto = "009"
        End If
        If Strings.Trim(strPuesto) = "MENSAJERO" Then
            ObtenerCodigoPuesto = "022"
        End If
        If Strings.Trim(strPuesto) = "MENSAJERO DE TELEMARATON" Then
            ObtenerCodigoPuesto = "023"
        End If
        If Strings.Trim(strPuesto) = "MOTORISTA" Then
            ObtenerCodigoPuesto = "047"
        End If
        If Strings.Trim(strPuesto) = "OFICIAL  DE CARAVANAS DE BUENA VOLUNTAD" Then
            ObtenerCodigoPuesto = "024"
        End If
        If Strings.Trim(strPuesto) = "OPERADOR  DE  AUDIO" Or Strings.Trim(strPuesto) = "OPERADOR DE AUDIO" Then
            ObtenerCodigoPuesto = "025"
        End If
        If Strings.Trim(strPuesto) = "OPERADOR CONTROL DE MASTER" Then
            ObtenerCodigoPuesto = "026"
        End If
        If Strings.Trim(strPuesto) = "OPERADOR DE TRANSMICION" Or Strings.Trim(strPuesto) = "OPERADOR DE TRANSMISION" Then
            ObtenerCodigoPuesto = "027"
        End If
        If Strings.Trim(strPuesto) = "OPERADOR Y VIGILANTE" Then
            ObtenerCodigoPuesto = "028"
        End If
        If Strings.Trim(strPuesto) = "OPERADORA DE CARACTERES" Then
            ObtenerCodigoPuesto = "029"
        End If
        If Strings.Trim(strPuesto) = "PRODUCTOR" Or Strings.Trim(strPuesto) = "PRODUCTORA" Then
            ObtenerCodigoPuesto = "030"
        End If
        If Strings.Trim(strPuesto) = "PRODUCTOR CREATIVO" Then
            ObtenerCodigoPuesto = "031"
        End If
        If Strings.Trim(strPuesto) = "PRODUCTOR DE PROGRAMAS" Or Strings.Trim(strPuesto) = "PRODUCTORA DE PROGRAMAS" Then
            ObtenerCodigoPuesto = "032"
        End If
        If Strings.Trim(strPuesto) = "PRODUCTOR Y DIRECTOR" Then
            ObtenerCodigoPuesto = "033"
        End If
        If Strings.Trim(strPuesto) = "PRODUCTORA Y PERIODISTA" Then
            ObtenerCodigoPuesto = "034"
        End If
        If Strings.Trim(strPuesto) = "RECEPCIONISTA" Or Strings.Trim(strPuesto) = "RECEPCINISTA" Then
            ObtenerCodigoPuesto = "035"
        End If
        If Strings.Trim(strPuesto) = "TECNICO" Then
            ObtenerCodigoPuesto = "036"
        End If
        If Strings.Trim(strPuesto) = "TECNICO DE PLANTA" Then
            ObtenerCodigoPuesto = "037"
        End If
        If Strings.Trim(strPuesto) = "TECNICO DE VIDEO" Then
            ObtenerCodigoPuesto = "038"
        End If
        If Strings.Trim(strPuesto) = "TECNICO ENLACE HONDURAS" Then
            ObtenerCodigoPuesto = "039"
        End If
        If Strings.Trim(strPuesto) = "VIGILANTE" Then
            ObtenerCodigoPuesto = "040"
        End If
        If Strings.Trim(strPuesto) = "VIGILANTE OPERADOR DE TRANSITO" Then
            ObtenerCodigoPuesto = "041"
        End If
        If Strings.Trim(strPuesto) = "VIGILANTE REPETIDORA" Then
            ObtenerCodigoPuesto = "042"
        End If
        If Strings.Trim(strPuesto) = "VIGILANTE Y OPERADOR DE REPETIDORA" Then
            ObtenerCodigoPuesto = "043"
        End If
        If Strings.Trim(strPuesto) = "VIGILANTE Y OPERADOR DE TRANSMISION" Then
            ObtenerCodigoPuesto = "044"
        End If
    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class