Imports System
Imports Wisej.Web

Public Class Add_Objetivos_vb
    Dim oFunciones As New dllData
    Private Sub guardar()
        If validar() Then
            Try
                ReDim oFunciones.ParametersX_Global(1)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_OBJETIVO", CVE_OBJETIVO.Text)
                oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@OBJETIVO", OBJETIVO.Text)


                Dim result = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_OBJETIVOS_VERIFICACION_G", "@PARAM", oFunciones.ParametersX_Global, False, SqlDbType.Int)
                If result <> Nothing Then

                    Wisej.Web.MessageBox.Show("Objetivo guardado", "Guardar", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Information)
                    OBJETIVO.Text = ""
                    OBJETIVO.Enabled = False
                    ADD.Enabled = False


                Else
                    Wisej.Web.MessageBox.Show("Ocurrio un error al guardar", "Guardar :Error: ", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                Wisej.Web.MessageBox.Show("Error al guardar, ERROR: " & ex.Message, "Guardar :Exception:", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
            End Try

        End If

    End Sub
    Private Function validar() As Boolean
        Dim errores As Integer = 0
        If OBJETIVO.Text.Length <= 1 Then
            ErrorProvider1.SetError(OBJETIVO, "campo requerido")
            errores = errores + 1
        Else
            ErrorProvider1.SetError(OBJETIVO, Nothing)

        End If
        If errores = 0 Then
            Return True
        Else
            Return False

        End If
    End Function
    Private Sub limpiar()
        OBJETIVO.Text = ""
        CVE_OBJETIVO.Text = ""
        ADD.Enabled = False


    End Sub
    Private Sub habilitar()
        ADD.Enabled = True

    End Sub

    Private Sub ADD_Click(sender As Object, e As EventArgs) Handles ADD.Click
        guardar()

    End Sub

    Private Sub NUEVO_Click(sender As Object, e As EventArgs) Handles NUEVO.Click
        OBJETIVO.Enabled = True
        ADD.Enabled = True

    End Sub
End Class
