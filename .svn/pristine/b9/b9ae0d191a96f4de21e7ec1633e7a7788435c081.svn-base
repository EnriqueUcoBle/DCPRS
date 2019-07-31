Imports System
Imports Wisej.Web

Public Class Add_Giro
    Dim oFunciones As dllData
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub guardar_giro()
        If validar() Then

            Try
                Dim result As Integer = Nothing
                ReDim oFunciones.ParametersX_Global(1)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@NOMBRE", NOMBRE.Text)
                oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@HABILITADO", HABILITADO.Checked)
                result = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_GIROS_G", "@PARAM", oFunciones.ParametersX_Global, False, SqlDbType.Int)
                If result = Nothing Then
                    oFunciones.AlertBox("No se pudo guardar el giro verifique los datos ", MessageBoxIcon.Information)
                Else
                    oFunciones.AlertBox("Giro almacenado correctamente", MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                Wisej.Web.MessageBox.Show("Error al guardar, ERROR: " & ex.Message, "Guardar  :Exception:", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
            End Try
        End If
    End Sub
    Private Function validar() As Boolean
        If NOMBRE.Text.Length > 5 Then
            ErrorProvider1.SetError(NOMBRE, "deber ser un nombre descriptivo")
            validar = False
        Else
            ErrorProvider1.SetError(NOMBRE, Nothing)
            validar = True
        End If

    End Function
End Class
