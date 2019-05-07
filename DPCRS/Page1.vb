Imports Wisej.Web

Public Class Page1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Session.transfer(New Cambiar_Contrasena())
        'Application.Current.Session = New Index_Menu
        'Cargar_Meu()
    End Sub
    Sub Cargar_Meu()
        Try
            Dim a As MyAspPageBox2 = New MyAspPageBox2
            a.PageSource = "Menu.aspx"
            a.Dock = DockStyle.Fill
            'a.Path = "Menu.aspx"
            ''a.Dock = DockStyle.Fill
            Me.Controls.Add(a)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Session.Transfer(New Page2)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Session.Transfer(New MyDesktop)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        Application.Desktop = New MyDesktop

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sForm As New Cambiar_Contrasena
        sForm.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub
End Class
