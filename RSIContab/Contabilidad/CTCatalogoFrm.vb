Public Class CTCatalogoFrm
    Dim CTCls As New CTClassLib.CTClass
    Dim drCat As SqlClient.SqlDataReader
    Dim NuevaCtaFrm As CTAgregarCuentaFrm
    Private Sub CTCatalogoFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CTCatalogoCuentasTableAdapter.Connection.ConnectionString = strcnCAD
        CTCls.DBconStr = strcnCAD
        Me.MdiParent = MDIPrincipal
        Me.Top = 10
        Me.Left = 10
        'TODO: esta línea de código carga datos en la tabla 'CTCatalogoCuentasDataSet.CTCatalogoCuentas' Puede moverla o quitarla según sea necesario.
        Me.CTCatalogoCuentasTableAdapter.Fill(Me.CTCatalogoCuentasDataSet.CTCatalogoCuentas)

        CargarNodos()
    End Sub
    Private Sub CargarNodos()
        Dim treeNodox As TreeNode

        Try
            treeNodox = treeviewCatalogo.Nodes.Add("Cuentas", "Cuentas", "LibroCerrado", "LibroAbierto")
            drCat = CTCls.drCatalogo
            While drCat.Read
                If String.IsNullOrEmpty(drCat("CuentaSuperior").ToString) Then
                    treeviewCatalogo.Nodes("Cuentas").Nodes.Add(drCat("Cuenta"), drCat("Descripcion"), "SubCtaCerrada", "Seleccionado")
                Else
                    Dim treeSubNodox As TreeNode() = treeviewCatalogo.Nodes.Find(drCat("CuentaSuperior"), True)
                    If drCat("Posteable") Then
                        treeSubNodox(0).Nodes.Add(drCat("Cuenta"), drCat("Descripcion"), "Hoja", "Seleccionado")
                    Else
                        treeSubNodox(0).Nodes.Add(drCat("Cuenta"), drCat("Descripcion"), "SubCtaCerrada", "Seleccionado")
                    End If

                End If
            End While
            treeviewCatalogo.Refresh()
            drCat.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub toolstripbutSalir_Click(sender As System.Object, e As System.EventArgs) Handles toolstripbutSalir.Click
        Me.Close()
    End Sub

    Private Sub treeviewCatalogo_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles treeviewCatalogo.AfterSelect
        Try
            HabDesControles(True)
            If treeviewCatalogo.SelectedNode.Name <> "Cuentas" Then
                Dim mDatos As DataRowView
                PrincipalBindingSource.Filter = "Cuenta='" & treeviewCatalogo.SelectedNode.Name & "'"
                mDatos = PrincipalBindingSource.Current
                c1txtCuenta.Text = mDatos("Cuenta")
                c1txtCuentaSuperior.Text = IIf(String.IsNullOrEmpty(mDatos("CuentaSuperior").ToString), "", mDatos("CuentaSuperior"))
                c1txtDescripcion.Text = mDatos("Descripcion")
                c1numNivel.Text = mDatos("Nivel")
                chkboxPosteable.Checked = mDatos("Posteable")
                lblNaturaleza.Text = mDatos("Naturaleza")
                lblTipo.Text = mDatos("Tipo")
                HabilitarControlesPrin(True)
            Else
                c1txtCuenta.Text = ""
                c1txtCuentaSuperior.Text = ""
                c1txtDescripcion.Text = ""
                c1numNivel.Text = ""
                chkboxPosteable.Checked = False
                HabilitarControlesPrin(False)
            End If
            HabDesControles(False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub HabDesControles(mHabilitar As Boolean)
        c1txtCuenta.ReadOnly = Not mHabilitar
        c1txtCuentaSuperior.ReadOnly = Not mHabilitar
        c1txtDescripcion.ReadOnly = Not mHabilitar
        c1numNivel.ReadOnly = Not mHabilitar
        chkboxPosteable.Enabled = mHabilitar
    End Sub
    Private Sub HabilitarControlesPrin(mHabilitar As Boolean)
        toolstripbutNuevo.Enabled = mHabilitar
        toolstripbutModificar.Enabled = mHabilitar
        toolstripbutEliminar.Enabled = mHabilitar
        toolstripbuttonSaldos.Enabled = mHabilitar
    End Sub

    Private Sub toolstripbutNuevo_Click(sender As System.Object, e As System.EventArgs) Handles toolstripbutNuevo.Click
        Dim mDatos As DataRowView
        NuevaCtaFrm = New CTAgregarCuentaFrm

        Try
            If treeviewCatalogo.SelectedNode.Name <> "Cuentas" Then
                PrincipalBindingSource.Filter = "Cuenta='" & treeviewCatalogo.SelectedNode.Name & "'"
                mDatos = PrincipalBindingSource.Current
                If mDatos("Posteable") Then
                    MsgBox("No se puede agregar una subcuenta bajo una cuenta posteasble", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                Else
                    NuevaCtaFrm.lblCuentaSuperior.Text = mDatos("Cuenta")
                    NuevaCtaFrm.lblDescripcionCtaSuperior.Text = mDatos("Descripcion")
                    NuevaCtaFrm.lblNivel.Text = mDatos("Nivel")
                    NuevaCtaFrm.lblNaturaleza.Text = mDatos("Naturaleza")
                    NuevaCtaFrm.lblTipo.Text = mDatos("Tipo")
                    NuevaCtaFrm.CuentaCorrecta = False
                    NuevaCtaFrm.ShowDialog()
                    If NuevaCtaFrm.DialogResult = Windows.Forms.DialogResult.OK And NuevaCtaFrm.CuentaCorrecta Then
                        PrincipalBindingSource.AddNew()
                        mDatos = PrincipalBindingSource.Current
                        mDatos("Cuenta") = NuevaCtaFrm.lblNuevaCuenta.Text
                        mDatos("Descripcion") = NuevaCtaFrm.c1txtDescripcion.Text
                        mDatos("Nivel") = CInt(NuevaCtaFrm.lblNivel.Text) + 1
                        mDatos("CuentaSuperior") = NuevaCtaFrm.lblCuentaSuperior.Text
                        mDatos("Posteable") = NuevaCtaFrm.chkboxPosteable.CheckState
                        mDatos("Naturaleza") = NuevaCtaFrm.lblNaturaleza.Text
                        mDatos("Tipo") = NuevaCtaFrm.lblTipo.Text
                        Me.Validate()
                        Me.PrincipalBindingSource.EndEdit()
                        Me.CTCatalogoCuentasTableAdapter.Update(Me.CTCatalogoCuentasDataSet.CTCatalogoCuentas)
                        Dim treeSubNodox As TreeNode() = treeviewCatalogo.Nodes.Find(NuevaCtaFrm.lblCuentaSuperior.Text, True)
                        If NuevaCtaFrm.chkboxPosteable.Checked Then
                            treeSubNodox(0).Nodes.Add(NuevaCtaFrm.lblNuevaCuenta.Text, NuevaCtaFrm.c1txtDescripcion.Text, "Hoja")
                        Else
                            treeSubNodox(0).Nodes.Add(NuevaCtaFrm.lblNuevaCuenta.Text, NuevaCtaFrm.c1txtDescripcion.Text, "SubCtaCerrada")
                        End If
                    End If
                    NuevaCtaFrm.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub toolstripbutEliminar_Click(sender As System.Object, e As System.EventArgs) Handles toolstripbutEliminar.Click
        Try
            If Not CTCls.ExisteCuentaEnTransacciones(c1txtCuenta.Text) Then
                If MsgBox("¿Desea eliminar este dato?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    PrincipalBindingSource.RemoveCurrent()
                    Try
                        Me.Validate()
                        Me.PrincipalBindingSource.EndEdit()
                        Me.CTCatalogoCuentasTableAdapter.Update(Me.CTCatalogoCuentasDataSet.CTCatalogoCuentas)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Dim treeSubNodox As TreeNode() = treeviewCatalogo.Nodes.Find(c1txtCuenta.Text, True)
                    treeSubNodox(0).Remove()
                End If
            Else
                MsgBox("No puede eliminar esta cuenta porque está siendo usada en las transacciones", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub toolstripbutModificar_Click(sender As System.Object, e As System.EventArgs) Handles toolstripbutModificar.Click
        c1txtDescripcion.ReadOnly = False
        chkboxPosteable.Enabled = True
        HabilitarControlesPrin(False)
        toolstripbutGrabar.Enabled = True
        toolstripbutCancelar.Enabled = True
    End Sub

    Private Sub toolstripbutGrabar_Click(sender As System.Object, e As System.EventArgs) Handles toolstripbutGrabar.Click
        Dim mDatos As DataRowView
        Try
            PrincipalBindingSource.Filter = "Cuenta='" & treeviewCatalogo.SelectedNode.Name & "'"
            mDatos = PrincipalBindingSource.Current
            mDatos("Descripcion") = c1txtDescripcion.Text
            mDatos("Posteable") = chkboxPosteable.CheckState
            Me.Validate()
            Me.PrincipalBindingSource.EndEdit()
            Me.CTCatalogoCuentasTableAdapter.Update(Me.CTCatalogoCuentasDataSet.CTCatalogoCuentas)
            treeviewCatalogo.SelectedNode.Text = mDatos("Descripcion")

            c1txtDescripcion.ReadOnly = True
            chkboxPosteable.Enabled = False
            HabilitarControlesPrin(True)
            toolstripbutGrabar.Enabled = False
            toolstripbutCancelar.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub toolstripbutCancelar_Click(sender As System.Object, e As System.EventArgs) Handles toolstripbutCancelar.Click
        c1txtDescripcion.ReadOnly = True
        chkboxPosteable.Enabled = False
        HabilitarControlesPrin(True)
        toolstripbutGrabar.Enabled = False
        toolstripbutCancelar.Enabled = False
    End Sub

    Private Sub toolstripbuttonSaldos_Click(sender As System.Object, e As System.EventArgs) Handles toolstripbuttonSaldos.Click
        Dim drSaldos As SqlClient.SqlDataReader
        Dim drCnf As SqlClient.SqlDataReader
        Dim CTSaldosFrm As New CTSaldosMensualesFrm

        drCnf = CTCls.drConf
        drSaldos = CTCls.drSaldosMensuales(treeviewCatalogo.SelectedNode.Name, drCnf("AñoEnProceso"))
        While drSaldos.Read
            Select Case drSaldos("Mes")
                Case 1
                    If lblNaturaleza.Text = "D" Then
                        CTSaldosFrm.c1numMes1.Value = drSaldos("SaldoAnterior") + drSaldos("DebitosMes") - drSaldos("CreditosMes")
                    Else
                        CTSaldosFrm.c1numMes1.Value = drSaldos("SaldoAnterior") - drSaldos("DebitosMes") + drSaldos("CreditosMes")
                    End If
                Case 2
                    If lblNaturaleza.Text = "D" Then
                        CTSaldosFrm.c1numMes2.Value = drSaldos("SaldoAnterior") + drSaldos("DebitosMes") - drSaldos("CreditosMes")
                    Else
                        CTSaldosFrm.c1numMes2.Value = drSaldos("SaldoAnterior") - drSaldos("DebitosMes") + drSaldos("CreditosMes")
                    End If
                Case 3
                    If lblNaturaleza.Text = "D" Then
                        CTSaldosFrm.c1numMes3.Value = drSaldos("SaldoAnterior") + drSaldos("DebitosMes") - drSaldos("CreditosMes")
                    Else
                        CTSaldosFrm.c1numMes3.Value = drSaldos("SaldoAnterior") - drSaldos("DebitosMes") + drSaldos("CreditosMes")
                    End If
                Case 4
                    If lblNaturaleza.Text = "D" Then
                        CTSaldosFrm.c1numMes4.Value = drSaldos("SaldoAnterior") + drSaldos("DebitosMes") - drSaldos("CreditosMes")
                    Else
                        CTSaldosFrm.c1numMes4.Value = drSaldos("SaldoAnterior") - drSaldos("DebitosMes") + drSaldos("CreditosMes")
                    End If
                Case 5
                    If lblNaturaleza.Text = "D" Then
                        CTSaldosFrm.c1numMes5.Value = drSaldos("SaldoAnterior") + drSaldos("DebitosMes") - drSaldos("CreditosMes")
                    Else
                        CTSaldosFrm.c1numMes5.Value = drSaldos("SaldoAnterior") - drSaldos("DebitosMes") + drSaldos("CreditosMes")
                    End If
                Case 6
                    If lblNaturaleza.Text = "D" Then
                        CTSaldosFrm.c1numMes6.Value = drSaldos("SaldoAnterior") + drSaldos("DebitosMes") - drSaldos("CreditosMes")
                    Else
                        CTSaldosFrm.c1numMes6.Value = drSaldos("SaldoAnterior") - drSaldos("DebitosMes") + drSaldos("CreditosMes")
                    End If
                Case 7
                    If lblNaturaleza.Text = "D" Then
                        CTSaldosFrm.c1numMes7.Value = drSaldos("SaldoAnterior") + drSaldos("DebitosMes") - drSaldos("CreditosMes")
                    Else
                        CTSaldosFrm.c1numMes7.Value = drSaldos("SaldoAnterior") - drSaldos("DebitosMes") + drSaldos("CreditosMes")
                    End If
                Case 8
                    If lblNaturaleza.Text = "D" Then
                        CTSaldosFrm.c1numMes8.Value = drSaldos("SaldoAnterior") + drSaldos("DebitosMes") - drSaldos("CreditosMes")
                    Else
                        CTSaldosFrm.c1numMes8.Value = drSaldos("SaldoAnterior") - drSaldos("DebitosMes") + drSaldos("CreditosMes")
                    End If
                Case 9
                    If lblNaturaleza.Text = "D" Then
                        CTSaldosFrm.c1numMes9.Value = drSaldos("SaldoAnterior") + drSaldos("DebitosMes") - drSaldos("CreditosMes")
                    Else
                        CTSaldosFrm.c1numMes9.Value = drSaldos("SaldoAnterior") - drSaldos("DebitosMes") + drSaldos("CreditosMes")
                    End If
                Case 10
                    If lblNaturaleza.Text = "D" Then
                        CTSaldosFrm.c1numMes10.Value = drSaldos("SaldoAnterior") + drSaldos("DebitosMes") - drSaldos("CreditosMes")
                    Else
                        CTSaldosFrm.c1numMes10.Value = drSaldos("SaldoAnterior") - drSaldos("DebitosMes") + drSaldos("CreditosMes")
                    End If
                Case 11
                    If lblNaturaleza.Text = "D" Then
                        CTSaldosFrm.c1numMes11.Value = drSaldos("SaldoAnterior") + drSaldos("DebitosMes") - drSaldos("CreditosMes")
                    Else
                        CTSaldosFrm.c1numMes11.Value = drSaldos("SaldoAnterior") - drSaldos("DebitosMes") + drSaldos("CreditosMes")
                    End If
                Case 12
                    If lblNaturaleza.Text = "D" Then
                        CTSaldosFrm.c1numMes12.Value = drSaldos("SaldoAnterior") + drSaldos("DebitosMes") - drSaldos("CreditosMes")
                    Else
                        CTSaldosFrm.c1numMes12.Value = drSaldos("SaldoAnterior") - drSaldos("DebitosMes") + drSaldos("CreditosMes")
                    End If
            End Select
        End While
        CTSaldosFrm.toolstriplblAño.Text = "Año: " & drCnf("AñoEnProceso")
        drSaldos.Close()
        drCnf.Close()
        CTSaldosFrm.ShowDialog()
    End Sub
End Class