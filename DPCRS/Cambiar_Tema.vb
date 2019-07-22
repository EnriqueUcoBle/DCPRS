﻿Imports System
Imports Wisej.Web

Public Class Cambiar_Tema
    Dim oFunciones As New dllData
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        Application.LoadTheme("Blue-2")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Application.LoadTheme("Clear-2")
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Application.LoadTheme("Classic-2")
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Application.LoadTheme("Material-3")
    End Sub
    Private Sub CambiarTema(tema As String)
        ReDim oFunciones.ParametersX_Global(1)
        oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@USUARIO", Application.Session("USUARIO"))
        oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@TEMA", tema)
        Dim RESULSET = oFunciones.fGuardar_O_EliminarXProcedure("pACTUALIZA_TEMA", "@PARAM", oFunciones.ParametersX_Global, , False)
        If RESULSET = 1 Then
            oFunciones.AlertBox("ERROR AL GUARDAR EL TEMA", MessageBoxIcon.Information)
        Else
            oFunciones.AlertBox("TEMA GUARDADO: " & tema, MessageBoxIcon.Information)
            Application.LoadTheme(tema)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TEMA As String
        If RadioButton1.Checked Then
            TEMA = "Clear-2"
        ElseIf RadioButton2.Checked Then
            TEMA = "Blue-2"
        ElseIf RadioButton3.Checked Then
            TEMA = "Classic-2"
        ElseIf RadioButton4.Checked Then
            TEMA = "Material-3"
        End If

        CambiarTema(TEMA)
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.LoadTheme("Blue-2")

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.LoadTheme("Clear-2")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.LoadTheme("Material-3")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.LoadTheme("Classic-2")
    End Sub
End Class