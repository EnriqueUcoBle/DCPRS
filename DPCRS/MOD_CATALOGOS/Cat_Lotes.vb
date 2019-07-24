Imports System
Imports Wisej.Web

Public Class Cat_Lotes
    Dim oFunciones As New dllData
    Private Sub Cat_Lotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_tablas()
        oFunciones.loadConfigDataGridView(DGVLotes)
        oFunciones.ConfigurarBindingNavigator(BNLotes, False, False, True, True)
        FiltroGrillaSax2.meDatagrid = DGVLotes
        oFunciones.loadConfigDataGridView(DGVActas)
        oFunciones.ConfigurarBindingNavigator(BNActas, False, False, True, True)
        FiltroGrillaSax1.meDatagrid = DGVActas
    End Sub
    Private Sub ribbonBar1_ItemClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Text
            Case "Actualizar"
                Cargar_tablas()
                Me.DataSet_pCAT_ACTAS_VERIFICACION_B.pCAT_ACTAS_VERIFICACION_B.Clear()
            Case "Salir"
                Me.Close()
        End Select
    End Sub
    Private Sub Cargar_tablas()
        Try
            Me.DataSet_pCAT_PAQUETES_ACTAS_B.pCAT_PAQUETES_ACTAS_B.Clear()
            Dim myDA = New SqlClient.SqlDataAdapter("pCAT_PAQUETES_ACTAS_B", oFunciones.sConexion)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_pCAT_PAQUETES_ACTAS_B.pCAT_PAQUETES_ACTAS_B)
            myDA.Dispose()
        Catch ex As Exception
            MessageBox.Show("OCURRIO UN ERROR AL CARGAR DATOS A LA TABLA:   " & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DGVLotes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVLotes.CellClick
        Try
            If e.ColumnIndex = 6 Then

                'MessageBox.Show("AVENTO LOBA")
                Me.DataSet_pCAT_ACTAS_VERIFICACION_B.pCAT_ACTAS_VERIFICACION_B.Clear()
                Dim myDA = New SqlClient.SqlDataAdapter("pCAT_ACTAS_VERIFICACION_B", oFunciones.sConexion)
                myDA.SelectCommand.Parameters.AddWithValue("@CVE_PAQUETES", DGVLotes.Item("colCVE_PAQUETE_3", e.RowIndex).Value)
                'MessageBox.Show(DGVLotes.Item("CVE_PAQUETE", e.RowIndex).Value)
                myDA.SelectCommand.CommandType = CommandType.StoredProcedure
                myDA.Fill(Me.DataSet_pCAT_ACTAS_VERIFICACION_B.pCAT_ACTAS_VERIFICACION_B)
                myDA.Dispose()
                If DGVActas.Rows.Count = 0 Then
                    MessageBox.Show("Este paquete no contiene actas aun...", "ACTAS NO DISPONIBLES", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf e.ColumnIndex = 9 Then

                MessageBox.Show("funcion para imrpimir lote de actas", "IMPRIMIR", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            ElseIf e.ColumnIndex = 0 Then
                MessageBox.Show("funcion para eliminar paquete", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Question)

            ElseIf e.ColumnIndex = 1 Then
                MessageBox.Show("funcion para editar lote de actas", "EDITAR", MessageBoxButtons.OK, MessageBoxIcon.Question)

            End If

        Catch ex As Exception
            MessageBox.Show("Error:   " & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DGVActas_Click(sender As Object, e As EventArgs) Handles DGVActas.Click

    End Sub
End Class
