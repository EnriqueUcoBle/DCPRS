Imports Wisej.Web.Ext.RibbonBar
Imports Wisej.Web

Public Class Error_Sistema
    Dim ofunciones As New dllData

    Private Sub Error_Sistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ofunciones.ConfigurarBindingNavigator(BindingNavigator1)
        ofunciones.loadConfigDataGridView(DGVError)
        Cargar_Tabla()
        FiltroGrillaSax1.meDatagrid = DGVError
    End Sub
    Sub Cargar_Tabla()
        Dim myDA = New SqlClient.SqlDataAdapter("pERROR_SISTEMA_B", ofunciones.sConexion)
        Me.DataSet_pERROR_SISTEMA.pERROR_SISTEMA_B.Clear()
        myDA.SelectCommand.CommandType = CommandType.StoredProcedure
        myDA.Fill(Me.DataSet_pERROR_SISTEMA.pERROR_SISTEMA_B)
        myDA.Dispose()
    End Sub

    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Text
            Case "Salir"
                Me.Close()
            Case "Actualizar"
                Cargar_Tabla()
        End Select
    End Sub

    Private Sub DGVError_Click(sender As Object, e As EventArgs) Handles DGVError.Click

    End Sub
End Class
