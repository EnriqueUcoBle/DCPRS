Imports System
Imports Wisej.Web

Public Class Generar_Orden_Verficacion
    Private Sub paso1_Click(sender As Object, e As EventArgs) Handles paso1.Click
        TabControl1.SelectedTab = tab2
    End Sub


    Private Sub paso1a_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedTab = tab1
    End Sub

    Private Sub paso2_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedTab = tab2


    End Sub
End Class
