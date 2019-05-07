Imports Wisej.Web



Public Class Index_Menu
    Dim oFunciones As New dllData
    Dim bPasa As Boolean = True

    Sub Cargar_Meu()
        Dim a As MyAspPageBox2 = New MyAspPageBox2
        a.PageSource = "Menu.aspx"
        a.Dock = DockStyle.Fill
        Me.Controls.Add(a)

    End Sub
    Private Sub Menu_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'Try
        Application.Session("Num_Notificaciones") = 0
        Cargar_Meu()
    End Sub

End Class

Public Class MyAspPageBox2
    Inherits Wisej.Web.AspNetPanel

    Dim oFunciones As New dllData
    Dim ParametersX() As SqlClient.SqlParameter

    ' Methods
    'Protected Overrides Sub FireEvent(ByVal objEvent As IEvent)
    '    MyBase.FireEvent(objEvent)
    '    Dim sModulo As String
    '    If (objEvent.Type = "MessageBox") Then
    '        sModulo = objEvent.Item("message")
    '        If sModulo = "CERRAR" Then
    '            'oFunciones.Guardar_Bitacora(Application.Session("Cve_Operador"), "CERRAR SESION", Context.HttpContext.Request.UserHostAddress)
    '            Application.Session.IsLoggedOn = False
    '        ElseIf sModulo = "NOTIFICACIONES" Then
    '            MessageBox.show("Notificando")
    '        ElseIf sModulo = "CAMBIAR MENU" Then

    '        ElseIf sModulo = "CAMBIAR CONTRASEÑA" Then
    '            Dim contrax As New Cambiar_Contrasena
    '            contrax.Show()
    '        ElseIf sModulo = "PERFIL" Then
    '            MessageBox.show("Datos del perfil no disponibles")
    '        Else
    '            Mostrar_Formulario(sModulo)
    '        End If
    '    End If
    'End Sub
    Sub handlemenuclick(ByVal objSource As Object, ByVal objArgs As Wisej.Web.MenuItemEventArgs)
        Mostrar_Formulario(objArgs.MenuItem.Tag)
    End Sub

    Sub Mostrar_Formulario(ByVal cNodo As String)
        'oFunciones.formulario = cNodo
        If cNodo = " " Or cNodo = Nothing Then
            Exit Sub
        End If

        Try
            Dim formx As Form = Activator.CreateInstance(Type.GetType("DPCRS." + cNodo))
            formx.Show()
        Catch ex As Exception
            MessageBox.show("Formulario no se encontro : " & cNodo & vbCrLf & "//Error:" & ex.Message)
            oFunciones.Guardar_Error(oFunciones.modulo, ex.Message, "Formulario no se encontro : " & cNodo, "Mostrar_Formulario", "Principal")
        End Try

        Application.Session("name_modulo") = cNodo

        'Select Case cNodo
        '    Case "Cat_Municipios"
        '        Dim Cat_Municipios As New Cat_Municipios
        '        Cat_Municipios.Show()
        '        Exit Sub
        '    Case "Cat_Estados"
        '        Dim Cat_Estados As New Cat_Estados
        '        Cat_Estados.Show()
        '        Exit Sub
        '    Case "R_Agregar_Orden_New"
        '        Dim Agregar_Orden As New R_Agregar_Orden_New
        '        Agregar_Orden.Show()
        '        Exit Sub
        '    Case "R_Agregar_Orden"
        '        Dim Ordenes As New R_Agregar_Orden
        '        Ordenes.Show()
        '        Exit Sub
        '    Case "Cat_Verificadores"
        '        Dim verificadores As New Cat_Verificadores
        '        verificadores.Show()
        '        Exit Sub
        'End Select
    End Sub

End Class


