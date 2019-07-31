﻿Imports System
Imports Wisej.Web

Public Class Historial_Sessiones
    Dim oFunciones As New dllData
    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick


        Select Case e.Item.Text

            Case "Borrar Historial"
                EliminarH()

            Case "Salir"
                Close()
        End Select
    End Sub
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

                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Cargar tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If e.ColumnIndex = 0 Then

                If (MessageBox.Show("¿Deseas ELIMINAR este Historial? con ID=" & DataGridView1.Item("colCVE_SESSION", e.RowIndex).Value.ToString, "HISTORAL", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
                    ReDim oFunciones.ParametersX_Global(0)
                    oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_sesion", DataGridView1.Item("colCVE_SESSION", e.RowIndex).Value)
                    Dim RESULT As Integer = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_SESSIONES_E", "@PARAM", oFunciones.ParametersX_Global, True, SqlDbType.Int)
                    If RESULT = 400 Then
                        MessageBox.Show("Registro eliminado", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cargarSessiones()

                    Else
                        MessageBox.Show("Ocurrio un error al trata de eliminar", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error:   " & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click

    End Sub
    Private Sub EliminarH()
        For Each COLUM As DataGridViewRow In DataGridView1.Rows

            ReDim oFunciones.ParametersX_Global(0)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_sesion", COLUM.Item("colCVE_SESSION").Value)
            Dim RESULT As Integer = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_SESSIONES_E", "@PARAM", oFunciones.ParametersX_Global, True, SqlDbType.Int)

        Next
        cargarSessiones()

    End Sub


End Class
