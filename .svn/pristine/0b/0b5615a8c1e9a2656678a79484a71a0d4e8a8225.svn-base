Imports System
Imports Wisej.Web

Public Class Cat_New_Normas
    Dim oFunciones As New dllData
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub NUEVO_Click(sender As Object, e As EventArgs) Handles NUEVO.Click

    End Sub

    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        If Validar_Datos() Then

            Try
                ReDim oFunciones.ParametersX_Global(3)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_NORMA", txtcve_norma.Text)
                oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@NOMBRE", txtnombre.Text)
                oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@DESCRIPCION", txtdescripcion.Text)
                oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@HABILITADO", True)

                If oFunciones.fGuardar_O_EliminarXProcedure("pCAT_NORMAS_G", "@PARAMETRO", oFunciones.ParametersX_Global, False) Then

                    oFunciones.AlertBox("Datos guardados correctamente", MessageBoxIcon.Information)
                    Dim normas = New Cat_Normas
                    normas.cargarTabla()
                Else
                    oFunciones.AlertBox("Datos No guardados", MessageBoxIcon.Error)
                End If

            Catch ex As Exception

                If Application.Session("USUARIO") = "admin" Then
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End Try
        Else
            oFunciones.AlertBox("Campos Obligatorios", MessageBoxIcon.Error)
        End If
    End Sub

    Private Function Validar_Datos() As Boolean
        Validar_Datos = True
        If txtnombre.Text = "" Then
            Validador.SetError(txtnombre, "Ingrese el nombre de la norma")
            Validar_Datos = False
        Else
            Validador.SetError(txtnombre, "")
        End If
        If txtdescripcion.Text = "" Then
            Validador.SetError(txtdescripcion, "Igrese la descripción de la norma")
            Validar_Datos = False
        Else
            Validador.SetError(txtdescripcion, "")
        End If

    End Function



    Public Function Actualizartablas(ByVal Cve_norma As Integer, ByVal nombre As String, ByVal Descripcion As String)
        txtcve_norma.Text = Cve_norma
        txtnombre.Text = nombre
        txtdescripcion.Text = Descripcion
    End Function

End Class
