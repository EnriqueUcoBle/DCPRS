Imports System.Drawing
Imports Wisej.Web
'Public Class Login
'    Private Sub bLogin_Click(sender As Object, e As EventArgs) Handles bLogin.Click

'        If cContrasena.Text = "1" And cUsuario.Text = "RiesgosSanitarios" Then
'            Application.Session.IsLoggedOn = True
'            Application.Transfer(New Menu)
'        Else
'            LabelError.Visible = True
'            LabelError.Text = "Error de usuario / contraseña"
'        End If



'        'Dim nindex As New Index
'        'nindex.Show()
'    End Sub

'    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
'        With Screen.PrimaryScreen.WorkingArea ' Dimensiones de la pantalla sin el TaskBar  

'            Panel2.Left = (.Width - Panel2.Width) \ 2
'        End With
'    End Sub

'End Class

Public Class Login
    Dim bProcesa As Boolean
    Dim oFunciones, oFunciones1 As New dllData
    Dim nCuentaVeces_Fallo As Integer
    Private Function ValidateUser(ByVal User As String, ByVal Pass As String) As Boolean
        Try
            If oFunciones.Login(User, Pass) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Function

    Sub Login_DPCRS()
        bProcesa = True
        If Trim(Me.cUsuario.Text) = Nothing Then
            Me.ErrorProvider1.SetError(Me.cUsuario, "Escriba usuario")
            bProcesa = False
        Else
            Me.ErrorProvider1.SetError(Me.cUsuario, Nothing)
        End If
        '-----------------------------
        If Trim(Me.cContrasena.Text) = Nothing Then
            Me.ErrorProvider1.SetError(Me.cContrasena, "Escriba contraseña")
            bProcesa = False
        Else
            Me.ErrorProvider1.SetError(Me.cContrasena, Nothing)
        End If

        '  -----------------------------------

        If bProcesa Then
            If ValidateUser(cUsuario.Text, cContrasena.Text) Then

                Obtener_Datos(cUsuario.Text.ToUpper) ' SE UTILIZA PARA BUSCAR LOS DATOS DE LOS USUARIOS 
                Dim cDataReader1 As Data.SqlClient.SqlDataReader
                LabelError.Visible = False

                Try
                    If Application.Session("Cve_Operador") = "ADMIN" Or cUsuario.Text.Trim = "ADMIN" Then GoTo jumpit
                    oFunciones1.Conectar()
                    oFunciones1.cCommand = New SqlClient.SqlCommand("pLICENSE_B", oFunciones1.cConnect)
                    oFunciones1.cCommand.CommandType = CommandType.StoredProcedure
                    oFunciones1.cCommand.Parameters.AddWithValue("@ESTATUS", True)
                    cDataReader1 = oFunciones1.cCommand.ExecuteReader(CommandBehavior.CloseConnection)

                    If cDataReader1.HasRows Then
                        While (cDataReader1.Read)

                            Dim sPASA As String
                            sPASA = oFunciones.desencriptar128BitRijndael(cDataReader1.Item("SERIAL"), oFunciones.desencriptar128BitRijndael(oFunciones.encriptar128BitRijndael(oFunciones.Busqueda_Secreta, oFunciones.sConstante_KEY), oFunciones.sConstante_KEY))


                            If sPASA <> "" Then
                                Dim CODIGO As String()
                                CODIGO = Split(sPASA, "/")

                                If CODIGO.Count <= 1 Then
                                    Mostrar_Licencia("")

                                ElseIf CInt(Format(Now, "yyyyMMdd")) <= CInt(CODIGO(2)) Then
jumpit:
                                    Application.Session("Interfaz") = "ESCRITORIO"
                                    'Application.Session("Interfaz") = "MODERNA"
                                    Application.Session.IsLoggedOn = True
                                    If Application.Session("Interfaz") = "MODERNA" Then
                                        Application.Session.Transfer(New Index_Menu)
                                    Else
                                        'Application.Session.Transfer(New Cambiar_Contrasena())
                                        Me.Dispose()
                                        Application.Desktop = New MyDesktop()
                                        'Application.MainPage = New Page1
                                        Exit Sub

                                    End If

                                Else
                                    Mostrar_Licencia("Serial Caducado")
                                End If

                            Else

                                Mostrar_Licencia("")
                            End If

                        End While

                    Else

                        Mostrar_Licencia("")
                    End If



                    '---------------------------------------
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If IsNothing(cDataReader1) = False Then
                        If cDataReader1.IsClosed = False Then cDataReader1.Close()
                    End If
                    oFunciones1.Desconectar()
                End Try

            Else
                ' 
                LabelError.Visible = True
                LabelError.Text = "Error de usuario / contraseña"
                nCuentaVeces_Fallo = nCuentaVeces_Fallo + 1

                If nCuentaVeces_Fallo = 3 Then
                    LabelError.Text = "Ha fallado la conexión con el servidor"
                    nCuentaVeces_Fallo = 0
                    cUsuario.Text = ""
                    cContrasena.Text = ""
                End If
                'oFunciones.Guardar_Bitacora(cUsuario.Text, "ERROR INICIO SESSION", Context.HttpContext.Request.UserHostAddress)
            End If
        End If




    End Sub
    Sub Mostrar_Licencia(sMensaje As String)
        Dim Frm_Licencia As Licencia
        Frm_Licencia = New Licencia
        AddHandler Frm_Licencia.Closed, AddressOf handle_Busqueda_Secreta_Closed
        If Trim(sMensaje) <> Nothing Then
            Frm_Licencia.txtResultado.Text = sMensaje
        End If
        Frm_Licencia.Show()
    End Sub
    Private Sub handle_Busqueda_Secreta_Closed(ByVal sender As Object, ByVal e As System.EventArgs)
        If Application.Session("LICENSE_READY") = "YES" Then
            Obtener_Datos(cUsuario.Text) ' SE UTILIZA PARA BUSCAR LOS DATOS DE LOS USUARIOS 
            Application.Session("Interfaz") = "ESCRITORIO"
            'Application.Session("Interfaz") = "MODERNA"
            Application.Session.IsLoggedOn = True
            If Application.Session("Interfaz") = "MODERNA" Then
                Application.Session.Transfer(New Index_Menu)
            Else
                Application.Session.Transfer(New Index)
            End If
        End If
    End Sub
    Sub Obtener_Datos(ByVal sUsuario As String)
        'Dim Skin_Seleccionado As String = "Vista"
        oFunciones.Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            oFunciones.cCommand = New SqlClient.SqlCommand("pCAT_OPERADORES_B", oFunciones.cConnect)
            oFunciones.cCommand.CommandType = CommandType.StoredProcedure
            oFunciones.cCommand.Parameters.AddWithValue("@Cve_Operador", sUsuario)
            cDataReader = oFunciones.cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While (cDataReader.Read)
                    Application.Session("Cve_Operador") = cDataReader.Item("Cve_Operador")
                    Application.Session("ROL") = "" & cDataReader.Item("ROL")
                    Application.Session("Cve_Rol") = "" & cDataReader.Item("Cve_Rol")
                    Application.Session("URL_Fotografia") = "" & cDataReader.Item("URL_Fotografia")
                    Application.Session("CVE_MUNICIPIO") = "" & cDataReader.Item("CVE_MUNICIPIO")
                    Application.Session("MUNICIPIO") = "" & cDataReader.Item("MUNICIPIO")
                    Application.Session("TEMA") = cDataReader.Item("TEMA")
                    Application.Session("Nombre") = cDataReader.Item("Nombre")

                End While
            End If
            Dim perfil As String = "" & "ADMINISTRADOR"
            If String.Equals(Application.Session("ROL"), perfil, StringComparison.InvariantCultureIgnoreCase) Then
                Application.Session("CVE_MUNICIPIO") = -99
            End If

            'Application.CurrentTheme = Skin_Seleccionado
        Catch ex As SystemException
            MessageBox.show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            oFunciones.Desconectar()
        End Try
        Bitacora()
    End Sub

    Sub Obtener_Datos_Instituto()
        oFunciones.Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            oFunciones.cCommand = New SqlClient.SqlCommand("pCAT_INSTITUTO_B", oFunciones.cConnect)
            oFunciones.cCommand.CommandType = CommandType.StoredProcedure
            oFunciones.cCommand.Parameters.AddWithValue("@HABILITADO", 1)
            cDataReader = oFunciones.cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While (cDataReader.Read)
                    Application.Session("Cve_Instituto") = cDataReader.Item("Cve_Instituto")
                    Application.Session("Colegio") = "" & cDataReader.Item("Colegio")
                End While
            End If
        Catch ex As SystemException
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            oFunciones.Desconectar()
        End Try
    End Sub

    Sub Configuracion_Inicial()
        oFunciones.Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            oFunciones.cCommand = New SqlClient.SqlCommand("pCAT_PARAMETROS_B", oFunciones.cConnect)
            oFunciones.cCommand.CommandType = CommandType.StoredProcedure
            'oFunciones.cCommand.Parameters.AddWithValue("@HABILITADO", 1)
            cDataReader = oFunciones.cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While (cDataReader.Read)
                    Application.Session("Folio_Cartas") = cDataReader.Item("Folio_Cartas")
                    Application.Session("Adeudos") = "" & cDataReader.Item("Adeudos")
                    Application.Session("Porcentaje_Eventos") = "" & cDataReader.Item("Porcentaje_Eventos")
                End While
            End If
        Catch ex As SystemException
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            oFunciones.Desconectar()
        End Try
    End Sub

    Sub Bitacora()
        'oFunciones.Guardar_Bitacora(Application.Session("Cve_Operador"), "INICIO SESION", Context.HttpContext.Request.UserHostAddress)
    End Sub
    Private Sub bLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LabelError.Visible = False
        Me.cUsuario.Text = Nothing
        Me.cContrasena.Text = Nothing
        cUsuario.Focus()
    End Sub
    Private Sub cContrasena_EnterKeyDown(sender As Object, e As KeyEventArgs) Handles cContrasena.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login_DPCRS()
        End If
    End Sub
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        'cambio
        Login_DPCRS()
    End Sub
    Private Sub cUsuario_EnterKeyDown(Sender As Object, e As KeyEventArgs) Handles cUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login_DPCRS()
        End If
    End Sub
    Private Sub Centrar(ByVal Objeto As Object)

        ' Centrar un Formulario ...  
        If TypeOf Objeto Is Form Then
            Dim frm As Form = CType(Objeto, Form)
            'With Screen.PrimaryScreen.WorkingArea ' Dimensiones de la pantalla sin el TaskBar  
            '    frm.Top = (.Height - frm.Height) \ 2
            '    frm.Left = (.Width - frm.Width) \ 2
            'End With

            ' Centrar un control dentro del contenedor  
        Else
            ' referencia al control  
            Dim c As Control = CType(Objeto, Control)

            'le  establece el top y el Left dentro del Parent  
            With c
                .Top = (.Parent.ClientSize.Height - c.Height) \ 2
                .Left = (.Parent.ClientSize.Width - c.Width) \ 2
            End With
        End If
    End Sub



    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Centrar(Panel2)
    End Sub

    Private Sub Login_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Centrar(Panel2)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub bLogin_Click(sender As Object, e As EventArgs) Handles bLogin.Click
        Login_DPCRS()


    End Sub

End Class

