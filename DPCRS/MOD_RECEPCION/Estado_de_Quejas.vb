Imports System
Imports Wisej.Web

Public Class Estado_de_Quejas

    Dim oFunciones As New dllData

    Private Sub Estado_de_Quejas_Load(sender As Object, e As EventArgs) Handles Me.Load
        llenarGrilla()

    End Sub

    Private Function llenarGrilla()
        Try


            Me.DataSet_pCAT_QUEJAS_P.pCAT_QUEJAS_B.Clear()
            Dim myDA = New SqlClient.SqlDataAdapter("pCAT_QUEJAS_B", oFunciones.sConexion)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_pCAT_QUEJAS_P.pCAT_QUEJAS_B)
            myDA.Dispose()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Inicio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
End Class
