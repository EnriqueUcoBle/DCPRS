Imports Wisej.Web

Public Class Mostrar_Asp

    Private Sub Mostrar_Asp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.load
        load_Primero()
    End Sub

    Sub Actualizar()
        If AspPageBox1.Tag <> Nothing Then
            Me.AspPageBox1.PageSource = AspPageBox1.Tag
            AspPageBox1.Update()

        End If
    End Sub

    Sub load_Primero()
        If Trim(Application.Session("Modulo")) <> Nothing Then
            Me.AspPageBox1.PageSource = Application.Session("Modulo")
            AspPageBox1.Tag = Application.Session("Modulo")

            AspPageBox1.Update()
        End If
    End Sub

    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        'Select Case e.Item.Text
        Select Case e.Item.Text

            Case "Actualizar"
                Actualizar()
            Case "Salir"
                Me.Close()

        End Select
    End Sub


End Class







