Imports System
Imports Wisej.Web

Public Class DPCRS_Logs
    Public Errores As Boolean = False

    Private Sub DPCRS_Logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.ScrollBars = ScrollBars.Vertical
        Panel1.ScrollBars = ScrollBars.Horizontal
        lstLogs.HorizontalScrollbar = True
    End Sub
End Class
