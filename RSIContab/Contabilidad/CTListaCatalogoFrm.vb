Public Class CTListaCatalogoFrm
    Dim CTCls As New CTClassLib.CTClass
    Dim drCat As SqlClient.SqlDataReader
    Public mAceptar As Boolean

    Private Sub CTListaCatalogoFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        mAceptar = False
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

    Private Sub toolstripbutRefrescar_Click(sender As System.Object, e As System.EventArgs) Handles toolstripbutRefrescar.Click
        treeviewCatalogo.Nodes.Clear()
        CargarNodos()
    End Sub

    Private Sub butAceptar_Click(sender As System.Object, e As System.EventArgs) Handles butAceptar.Click
        If treeviewCatalogo.SelectedNode.Name <> "Cuentas" Then
            If Not CTCls.EsCuentaPosteable(treeviewCatalogo.SelectedNode.Name) Then
                MsgBox("Esta cuenta no es posteable, elija otra cuenta", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Else
                mAceptar = True
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub butCancelar_Click(sender As System.Object, e As System.EventArgs) Handles butCancelar.Click
        mAceptar = False
        Me.Hide()
    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CTCls.DBconStr = strcnCAD
        CargarNodos()

    End Sub
End Class