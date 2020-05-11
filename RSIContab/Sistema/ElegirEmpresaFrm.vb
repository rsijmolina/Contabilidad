Public Class ElegirEmpresaFrm

    Private Sub ElegirEmpresaFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElegirEmpresaDataSet.DB' Puede moverla o quitarla según sea necesario.
        Me.DBTableAdapter.Fill(Me.ElegirEmpresaDataSet.DB)

    End Sub

    Private Sub butCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCancelar.Click
        Me.Close()
    End Sub

    Private Sub butAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAceptar.Click
        Dim mDatos As DataRowView
        Dim strCon As String

        mDatos = PrincipalBindingSource.Current
        My.Settings.RSIEmpresaActual = mDatos("NombreEmpresa")
        My.Settings.RSIIdEmpresaActual = mDatos("ID")
        MDIPrincipal.Text = "RSI Contabilidad - " & mDatos("NombreEmpresa")
        strCon = "Data Source=" & mDatos("Servidor") & "\" _
                & mDatos("Instancia") & ";Initial Catalog=" & mDatos("BaseDatos") & ";User ID=sa;Password=rsierp94128"
        strcnCAD = strCon
        BaseDatosActual = mDatos("BaseDatos")
        Me.Close()
    End Sub
End Class