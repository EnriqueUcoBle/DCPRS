Imports Microsoft.AspNet.SignalR

Public Class MessageHub
    Inherits Hub

    Public Sub senmessage(message As String, user As String, type As String)

        'Me.Clients.All.receivenotification(message, user, type)

        Me.Clients.All.addNewMessageToPage(message, user, type)
    End Sub
    Public Function receivenotification(message As String, user As String, type As String) As String
        Return message
    End Function
    Public Sub Hello()
        Clients.All.Hello()
    End Sub

End Class