Imports System
Imports Wisej.Web

Public Class Historial_Sessiones
    Dim oFunciones As New dllData
    Private Sub Historial_Sessiones_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargarSessiones()
    End Sub
    Private Sub cargarSessiones()
        Try

            Me.DataSet_SESSIONES_B.pCAT_SESSIONES_B_ALL.Clear()

            Dim myDA = New SqlClient.SqlDataAdapter("pCAT_SESSIONES_B_ALL", oFunciones.sConexion)
            myDA.SelectCommand.Parameters.AddWithValue("@CVE_OPERADOR", Application.Session("CVE_OPERADOR"))
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_SESSIONES_B.pCAT_SESSIONES_B_ALL)
            myDA.Dispose()
            If DataGridView1.RowCount >= 0 Then
                DataGridView1.CurrentRow.Selected = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Cargar tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class
