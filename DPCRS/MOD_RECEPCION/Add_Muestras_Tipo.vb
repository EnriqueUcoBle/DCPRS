Imports System
Imports Wisej.Web

Public Class Add_Muestras_Tipo
    Dim oFunciones As New dllData
    Private Sub NUEVO_Click(sender As Object, e As EventArgs) Handles NUEVO.Click

        NOMBRE.Enabled = True

        DESCRIPCION.Enabled = True
    End Sub

    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        If GUARDAR_() Then
            NOMBRE.Text = ""
            NOMBRE.Enabled = False
            DESCRIPCION.Text = ""
            DESCRIPCION.Enabled = False

        End If

    End Sub




    Private Function GUARDAR_() As Boolean
        If validar() Then
            Try
                ReDim oFunciones.ParametersX_Global(2)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_TIPO_MUESTRA", CVE_TIPO_MUESTRA.Text)
                oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@NOMBRE", NOMBRE.Text)
                oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@DESCRIPCION", DESCRIPCION.Text)
                Dim result = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_TIPO_MUESTRAS_G", "@PARAM", oFunciones.ParametersX_Global, False, SqlDbType.Int)
                If result = Nothing Then
                    Wisej.Web.MessageBox.Show("Error Inesperado al Guardar", "Guardar", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
                    Return False
                Else
                    Wisej.Web.MessageBox.Show("Tipo de Muestra Guardado Correctamente", "Guardar", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Information)
                    Return True
                End If
            Catch ex As Exception
                Wisej.Web.MessageBox.Show("ERROR: " & ex.Message, "Guardar Exception", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
                Return False
            End Try
        Else
            Return False
        End If


    End Function

    Private Function validar() As Boolean
        Dim cont As Integer = 0

        If NOMBRE.Text.Length = 0 Then
            ErrorProvider1.SetError(NOMBRE, "debe contener un nombre descriptivo")
            cont = cont + 1
        Else
            ErrorProvider1.SetError(NOMBRE, Nothing)
        End If
        If DESCRIPCION.Text.Length = 0 Then
            ErrorProvider1.SetError(DESCRIPCION, "debe contener una descripcion clara")
            cont = cont + 1

        Else
            ErrorProvider1.SetError(DESCRIPCION, Nothing)

        End If
        If cont = 0 Then

            Return True
        Else
            Return False


        End If

    End Function

End Class
