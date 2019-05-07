Imports Wisej.Web

Public Class Query
    Dim oFunciones As New dllData

    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Text
            Case "Salir"
                Me.Close()
        End Select
    End Sub

    Private Sub bEjecutar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bEjecutar1.Click
        If Me.cSQL_Select.Text <> Nothing Then
            DataGridView1.DataSource = Nothing
            oFunciones.LlenarGridXProcedure(Me.DataGridView1, cSQL_Select.Text, , "SQL", True, False)
        End If
    End Sub

    Private Sub bEjecutar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bEjecutar2.Click
        If Me.cSQL_Update.Text <> Nothing Then
            cLabel_Result.Text = oFunciones.fGuardar_O_EliminarXProcedure(Me.cSQL_Update.Text, , , False, True)
        End If
    End Sub
    Private Sub bEjecutar3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bEjecutar3.Click
        If Me.cSQL_Update.Text <> Nothing Then
            cLabel_Result.Text = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId(Me.cSQL_Update.Text, cParametro.Text, , False, SqlDbType.VarChar, 50)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As Wisej.Web.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.DataGridView1.DataSource = Nothing
        Me.cSQL_Select.Text = Nothing
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As Wisej.Web.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.cSQL_Update.Text = Nothing
        Me.cLabel_Result.Text = Nothing
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As System.Object, e As Wisej.Web.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        oFunciones.ExportarDataGrid(Me.DataGridView1, Me, "csv")
    End Sub

    Private Sub RBBSalir_Click(sender As Object, e As System.EventArgs) Handles RBBSalir.Click
        Me.Close()
    End Sub


End Class

