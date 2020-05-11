Public Class PLProcDeduccionesFrm
    Private _Año As Int16
    Private _Mes As Int16
    Private _NoPlanilla As Int16
    Private _colDefDeds As Collection
    'Dim PlCls As New PLClassLib.PlClass
    Public Property Año() As Int16
        Get
            Año = _Año
        End Get
        Set(ByVal value As Int16)
            _Año = value
        End Set
    End Property
    Public Property Mes() As Int16
        Get
            Mes = _Mes
        End Get
        Set(ByVal value As Int16)
            _Mes = value
        End Set
    End Property
    Public Property NoPlanilla() As Int16
        Get
            NoPlanilla = _NoPlanilla
        End Get
        Set(ByVal value As Int16)
            _NoPlanilla = value
        End Set
    End Property
    Public Property colDefDeds() As Collection
        Get
            colDefDeds = _colDefDeds
        End Get
        Set(ByVal value As Collection)
            _colDefDeds = value
        End Set
    End Property

    Private Sub PLProcDeduccionesFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Procesar(ByVal strTipo As String)
        Dim mDataDedDet As DataRowView
        Dim mDefDed As DataRowView
        Dim strCodDeduc As String
        Dim intDedPos As Int16

        'PlCls.DBconStr = strcnCAD

        BorrarDeduccionesDet()
        Me.PLDefinicionDeduccionesTableAdapter.Fill(Me.PLProcDeducDataSet.PLDefinicionDeducciones)
        Me.PLDeduccionesDetTableAdapter.Fill(Me.PLProcDeducDataSet.PLDeduccionesDet)
        Me.PLPlanillasTableAdapter.Fill(Me.PLProcDeducDataSet.PLPlanillas, _Año, _Mes, _NoPlanilla)

        strCodDeduc = ""
        For Each mDataPlani As DataRowView In PrincipalBindingSource.List
            Me.PLPlanillasOTTableAdapter.Fill(Me.PLProcDeducDataSet.PLPlanillasOT, _Año, _Mes, _NoPlanilla, mDataPlani("CodigoEmpleado"))
            DeduccionesDetBindingSource.AddNew()
            mDataDedDet = DeduccionesDetBindingSource.Current
            mDataDedDet("CodigoEmpleado") = mDataPlani("CodigoEmpleado")
            For Each mDataPlaniOT As DataRowView In PlaniOtrasDedBindingSource.List
                If mDataPlaniOT("CodigoDeduccion") <> strCodDeduc Then
                    DefDeduccionesBindingSource.Filter = "CodigoDeduccion='" & mDataPlaniOT("CodigoDeduccion") & "'"
                    mDefDed = DefDeduccionesBindingSource.Current
                    If strTipo = "OTRASDED" Then
                        intDedPos = ObtenerPosicion(mDefDed("CodigoDeduccion"))
                    End If
                End If
                If strTipo <> "OTRASDED" Then
                    If mDefDed("RepNoColumna") > 0 Then
                        If strTipo = "PLANILLA" Then
                            mDataDedDet("Deduccion" & mDefDed("RepNoColumna")) = mDataDedDet("Deduccion" & mDefDed("RepNoColumna")) + mDataPlaniOT("Valor")
                        Else    'RECIBO
                            mDataDedDet("Deduccion" & mDefDed("ReciNoPosicion")) = mDataDedDet("Deduccion" & mDefDed("ReciNoPosicion")) + mDataPlaniOT("Valor")
                        End If
                    Else
                        If strTipo = "PLANILLA" Then
                            If mDefDed("RepTotEnOtrasDeducciones") Then
                                mDataDedDet("Deduccion30") = mDataDedDet("Deduccion30") + mDataPlaniOT("Valor")
                            End If
                        Else    'Recibos
                            If mDefDed("ReciTotEnOtrasDeducciones") Then
                                mDataDedDet("Deduccion30") = mDataDedDet("Deduccion30") + mDataPlaniOT("Valor")
                            End If
                        End If
                    End If
                Else
                    If intDedPos > 0 Then
                        mDataDedDet("Deduccion" & intDedPos) = mDataDedDet("Deduccion" & intDedPos) + mDataPlaniOT("Valor")
                    End If
                End If
                strCodDeduc = mDataPlaniOT("CodigoDeduccion")
            Next
        Next
        Try
            Me.Validate()
            Me.DeduccionesDetBindingSource.EndEdit()
            Me.PLDeduccionesDetTableAdapter.Update(Me.PLProcDeducDataSet.PLDeduccionesDet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Close()
    End Sub
    Private Sub BorrarDeduccionesDet()
        Dim cnSQLConexion As Data.SqlClient.SqlConnection
        Dim cmdInComando As SqlClient.SqlCommand

        cnSQLConexion = New SqlClient.SqlConnection(strcnCAD)
        cnSQLConexion.Open()
        cmdInComando = cnSQLConexion.CreateCommand
        cmdInComando.CommandType = CommandType.Text
        cmdInComando.CommandText = "DELETE FROM PLDeduccionesDet"
        cmdInComando.ExecuteNonQuery()
        cnSQLConexion.Close()
    End Sub
    Private Function ObtenerPosicion(ByVal strCodDed As String) As Int16
        Dim i As Int16

        ObtenerPosicion = 0
        For i = 1 To _colDefDeds.Count
            If _colDefDeds(i) = strCodDed Then
                ObtenerPosicion = i
                Exit For
            End If
        Next
    End Function
End Class