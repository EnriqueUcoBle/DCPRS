Imports Wisej.Web

Public Class Cat_Actas_Verificacion
    Dim oFunciones As New dllData
    Private Sub Cat_Actas_Verificacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        oFunciones.loadConfigDataGridView(DGV_Orden)
        oFunciones.ConfigurarBindingNavigator(BindingNavigator1, False, False, True, True)
        FiltroGrillaSax1.meDatagrid = DGV_Orden
        cargarTabla()
        Me.DGV_Orden.Sort(Me.DGV_Orden.Columns("cFechaVerificacion"), ComponentModel.ListSortDirection.Descending)
    End Sub
    Private Sub ribbonBar1_ItemClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Text
            Case "Nuevo"
                Nuevo()
            Case "Actualizar"
                cargarTabla()
            Case "Salir"
                Me.Close()
        End Select
    End Sub
    Private Sub cargarTabla()
        Try
            Me.DataSet_pCAT_ACTAS_VERIFICACION_B.pCAT_ACTAS_VERIFICACION_B.Clear()
            Dim myDA = New SqlClient.SqlDataAdapter("pCAT_ACTAS_VERIFICACION_B", oFunciones.sConexion)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_pCAT_ACTAS_VERIFICACION_B.pCAT_ACTAS_VERIFICACION_B)
            myDA.Dispose()

        Catch ex As Exception
            MessageBox.Show("OCURRIO UN ERROR AL CARGAR DATOS A LA TABLA:   " & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Sub Nuevo()


    End Sub

    Private Sub DGV_Orden_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Orden.CellClick
        'Primer celda (0) = Eliminar
        Try
           

            If e.RowIndex > -1 Then
                If e.ColumnIndex = 0 Then
                    MessageBox.Show("esta a punto de editar la fila", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class

