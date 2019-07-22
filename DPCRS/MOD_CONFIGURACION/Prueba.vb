Imports System
Imports Wisej.Web

Public Class Prueba
    Dim oFunciones As New dllData

    Private Sub Prueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub CrearPanel(ByVal ANCHO As Integer, ByVal ALTO As Integer, ByVal fila As Integer, ByVal columna As Integer)

        Dim panel = New Panel
        panel.Text = "panel hijo"
        panel.ShowHeader = True
        panel.Width = 200
        panel.Height = 300
        panel.BorderStyle = BorderStyle.Solid


        Dim label = New Label
        label.Text = "aqui va la pregunta"
        label.Location = New Drawing.Point(20, 50)


        Dim Texbox = New TextBox
        Texbox.Location = New Drawing.Point(50, 70)
        panel.Controls.Add(label)
        panel.Controls.Add(Texbox)

        PanelPadre.Controls.Add(panel)



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim ancho_padre As Integer = PanelPadre.Width
        Dim alto_padre As Integer = PanelPadre.Height
        Dim ancho_hijo As Integer = 200
        Dim alto_hijo As Integer = 200
        Dim cantidad_col As Integer = 3
        Dim cantidad_panel As Integer = ComboBox1.SelectedItem
        'Dim cantidad_filas As Integer =  

        PanelPadre.Controls.Clear()
        Dim sel As Integer = ComboBox1.SelectedItem
        For cont As Integer = 1 To sel
            'CrearPanel()

        Next
    End Sub
End Class
