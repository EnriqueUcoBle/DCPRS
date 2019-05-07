Imports System.Data.SqlClient
Imports Wisej.Web


Public Class Index
    Dim oFunciones As New dllData
    Dim sModulo As String
    'Dim Frm_Documentos_Ver_Form As Documentos_Ver_Form
    'Dim Frm_Mensaje As Msg_Mostrar
    'Dim frm_Cerrar_caja As Caja_Cerrar
    Dim ParametersX() As SqlClient.SqlParameter
    Public alternateSucursal As String

    Private Sub Principal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '''''''Grupo Recepcion'''''''
        Try
            Try
                Dim sqlConnection1 As New SqlConnection(oFunciones.sConexion)
                Dim cmd As New SqlCommand
                Dim reader As SqlDataReader
                cmd.CommandText = "pACCESOS_MODULOS_ACCESOS_MODULOS_ROL_B"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@CVE_ROL", "R1")
                cmd.Parameters.Add("@TIPO", "MODULO")
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                While reader.Read()
                    PopularMenu(reader("MODULO"), Grupo_Recepcion, "ADMIN", reader("MODULO"))
                End While
                sqlConnection1.Close()
            Catch ex As Exception
                MessageBox.Show("error: " & ex.Message, "Inicio",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            cargar_fondo()
            lblSucursal.Text = Application.Session("Sucursal") '& " - " & Application.Session("Cve_Sucursal")
            lblUsuario.Text = Application.Session("Nombre_Usuario") & "   " ' - " & Application.Session("Cve_Operador")
            SelecionaSkin()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'Devolver_No_Msg()
    End Sub
    Sub SelecionaSkin()
        Select Case Application.Theme.Name
            Case "Vista" '
                MenuItem8.Checked = True
                MenuItem5.Checked = False
                MenuItem7.Checked = False
                MenuItem3.Checked = False
                MenuItem2.Checked = False
                MenuItem9.Checked = False
            Case "Gmail"
                MenuItem5.Checked = True
                MenuItem8.Checked = False
                MenuItem7.Checked = False
                MenuItem3.Checked = False
                MenuItem2.Checked = False
                MenuItem9.Checked = False
            Case "FaceBook"
                MenuItem7.Checked = True
                MenuItem3.Checked = False
                MenuItem2.Checked = False
                MenuItem9.Checked = False
                MenuItem5.Checked = False
                MenuItem8.Checked = False
            Case "Analytics", "Graphite"
                MenuItem3.Checked = True
                MenuItem2.Checked = False
                MenuItem9.Checked = False
                MenuItem5.Checked = False
                MenuItem8.Checked = False
                MenuItem7.Checked = False
            Case "Office2010"
                MenuItem2.Checked = True
                MenuItem9.Checked = False
                MenuItem5.Checked = False
                MenuItem8.Checked = False
                MenuItem7.Checked = False
                MenuItem3.Checked = False
            Case "iOS7"
                MenuItem9.Checked = True
                MenuItem5.Checked = False
                MenuItem8.Checked = False
                MenuItem7.Checked = False
                MenuItem3.Checked = False
                MenuItem2.Checked = False
        End Select
    End Sub
    Sub cargar_fondo()
        Dim imagen As String = Application.Session("Imagen_fondo")
        If Trim(imagen) <> Nothing And imagen <> "0" Then
            PictureBox1.BackgroundImageSource = "Images." & imagen
        End If
    End Sub
    Private Sub LinkCerrar_Sesion_LinkClicked(ByVal sender As System.Object, ByVal e As Wisej.Web.LinkLabelLinkClickedEventArgs)
        Application.Session.IsLoggedOn = False
    End Sub
    'Private Sub Link_Archivos_LinkClicked(ByVal sender As Object, ByVal e As Wisej.Web.LinkLabelLinkClickedEventArgs)
    '    Frm_Documentos_Ver_Form = New Documentos_Ver_Form
    '    Frm_Documentos_Ver_Form.Show()
    'End Sub
    'Private Sub handleFrm_MensajeClosed(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If Frm_Mensaje.IsModificado Then
    '        Devolver_No_Msg()
    '    End If
    'End Sub
    'Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As Wisej.Web.LinkLabelLinkClickedEventArgs)
    '    Frm_Mensaje = New Msg_Mostrar
    '    AddHandler Frm_Mensaje.Closed, AddressOf handleFrm_MensajeClosed
    '    Frm_Mensaje.ShowDialog()
    'End Sub
    'Sub Devolver_No_Msg()
    '        Dim sNumero As String
    '        ReDim ParametersX(1)
    '        ParametersX(0) = New SqlClient.SqlParameter("@Cve_Operador", Application.Session("Cve_Operador"))
    '        ParametersX(1) = New SqlClient.SqlParameter("@Estatus", "NO LEIDO")
    '        sNumero = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pMENSAJE_OPERADORES_CANTIDAD_MENSAJE", "@Parametro", ParametersX, , SqlDbType.VarChar, 50)
    '        If Trim(sNumero) < 2 Then
    '            'Link_Msg.Text = (sNumero) & (" Mensaje Nvo.")
    '        Else
    '            'Link_Msg.Text = (sNumero) & (" Mensajes Nvos.")
    '        End If
    '    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As Wisej.Web.LinkLabelLinkClickedEventArgs)
        sModulo = "CAMBIAR CONTRASEÑA"
        Dim contrax As C_contra
        contrax = New C_contra
        contrax.Show()

    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Application.LoadTheme("Office2010")
        SelecionaSkin()
        Guardar_Skin()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Application.LoadTheme("Graphite") ' "Analytics"
        SelecionaSkin()
        Guardar_Skin()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Application.LoadTheme("Gmail")
        SelecionaSkin()
        Guardar_Skin()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Application.LoadTheme("FaceBook")
        SelecionaSkin()
        Guardar_Skin()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Application.LoadTheme("Vista")
        SelecionaSkin()
        Guardar_Skin()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Application.LoadTheme("iOS7")
        SelecionaSkin()
        Guardar_Skin()
    End Sub
    Sub Guardar_Skin()
        ReDim oFunciones.ParametersX_Global(1)
        oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Operador", Application.Session("Cve_Operador"))
        oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@SKIN", Application.Theme.Name)
        oFunciones.fGuardar_O_EliminarXProcedure("pACTUALIZA_SKIN", "@PARAMETRO", oFunciones.ParametersX_Global, , False)
    End Sub
    ''''''AKIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII CODIGO DE NUEVA APARIENCIA'''
    Sub PopularMenu(ByVal sModulo As String, ByVal Control As Wisej.Web.Ext.RibbonBar.RibbonBarGroup, ByVal sCve_Operador As String, Optional ByVal sSubModulo As String = Nothing, Optional ByVal sCve_Acceso_PadreX As String = Nothing)
        Dim sCve_Acceso_Padre As String
        'Dim nodeRoot, nodeModulos, nodeSubModulos As TreeNode
        'Dim PAGE As RibbonBarDropDownButtonItem
        Dim SMenuItem, SsMenuItem As MenuItem
        'Dim BOTONDOWN As RibbonBarDropDownButtonItem
        Dim BOTONDOWN As Ext.RibbonBar.RibbonBarItemButton
        Dim CONT As ContextMenu
        CONT = New ContextMenu
        '  Dim aborto = New 
        oFunciones.Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            oFunciones.cCommand = New SqlClient.SqlCommand("pACCESOS_MODULOS_OPERADOR", oFunciones.cConnect)
            oFunciones.cCommand.CommandType = CommandType.StoredProcedure
            oFunciones.cCommand.Parameters.AddWithValue("@Cve_Operador", sCve_Operador)
            oFunciones.cCommand.Parameters.AddWithValue("@Modulo", sModulo)
            'If sModulo <> "SOPORTE" Then
            '    oFunciones.cCommand.Parameters.AddWithValue("@Sistema", "LABORATORIO")
            'End If

            If Trim(sSubModulo) <> Nothing Then
                oFunciones.cCommand.Parameters.AddWithValue("@SubModulo", sSubModulo)
            End If

            'If Trim(sCve_Acceso_PadreX) <> Nothing Then
            '    oFunciones.cCommand.Parameters.AddWithValue("@Cve_Acceso_Padre", sCve_Acceso_PadreX)
            'End If

            cDataReader = oFunciones.cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While (cDataReader.Read)

                    If Trim(sCve_Acceso_Padre) <> cDataReader.Item("Cve_Acceso_Padre") Then
                        If cDataReader.Item("Tipo") = "MODULO" Then

                            'RibbonBarDropDownButtonItem
                            'RibbonBarItemButton
                            BOTONDOWN = New Ext.RibbonBar.RibbonBarItemButton
                            BOTONDOWN.Text = cDataReader.Item("descripcion")
                            If cDataReader.Item("descripcion").Length < 7 Then
                                BOTONDOWN.Text = "     " & cDataReader.Item("descripcion") & "     "
                            Else
                                BOTONDOWN.Text = "    " & cDataReader.Item("descripcion") & "    "
                            End If

                            ' Control.AutoSize = True
                            '  Control.AutoSizeMode = AutoSizeMode.GrowAndShrink
                            'AddHandler BOTONDOWN.ItemClicked, AddressOf handlemenuclick11
                            Control.Items.Add(BOTONDOWN)
                            'If Trim("" & cDataReader.Item("Icono")) <> Nothing Then
                            '    BOTONDOWN.Image = New ImageResourceHandle(cDataReader.Item("Icono"))
                            'End If
                            'BOTONDOWN.AutoSize = True

                            'Control.Items.Add(BOTONDOWN)
                            'Control.AutoSize = True
                            'Control.AutoSizeMode = AutoSizeMode.GrowAndShrink
                        End If
                    End If

                    If cDataReader.Item("Tipo") = "SUBMODULO" Then
                        ' BOTONDOWN.Tag = "SI"
                        If cDataReader.Item("boton") = "C" Then
                            SMenuItem = New MenuItem
                            SMenuItem.Index = 0
                            SMenuItem.Text = cDataReader.Item("descripcion")
                            SMenuItem.Visible = False
                            If Trim("" & cDataReader.Item("Icono")) <> Nothing Then
                                ' SMenuItem.Icon = New ImageResourceHandle(cDataReader.Item("Icono"))
                            End If
                            AddHandler SMenuItem.Click, AddressOf handlemenuclick2
                            CONT.MenuItems.AddRange(New Wisej.Web.MenuItem() {SMenuItem})
                            BOTONDOWN.MenuItems.Add(SMenuItem)
                            ' AddHandler SMenuItem.Click, AddressOf handlemenuclick11
                            ' BOTONDOWN. = (CONT)
                        ElseIf cDataReader.Item("boton") <> "SC" Then
                            SMenuItem = New MenuItem
                            SMenuItem.Index = 0
                            SMenuItem.Text = cDataReader.Item("descripcion")
                            SMenuItem.Tag = "" & cDataReader.Item("URL")
                            If Trim("" & cDataReader.Item("Icono")) <> Nothing Then
                                '    SMenuItem.Icon = New ImageResourceHandle(cDataReader.Item("Icono"))
                            End If
                            '  CONT.MenuItems.AddRange(New Wisej.Web.MenuItem() {SMenuItem})
                            'BOTONDOWN.MenuItems.Add(CONT)
                            AddHandler SMenuItem.Click, AddressOf handlemenuclick2
                            BOTONDOWN.MenuItems.Add(SMenuItem)
                            ' AddHandler SMenuItem.Click, AddressOf handlemenuclick11
                        End If

                        If cDataReader.Item("boton") = "SC" Then
                            SMenuItem.Visible = True
                            SsMenuItem = New MenuItem
                            SsMenuItem.Index = 0
                            SsMenuItem.Text = cDataReader.Item("descripcion")
                            SsMenuItem.Tag = "" & cDataReader.Item("URL")
                            If Trim("" & cDataReader.Item("Icono")) <> Nothing Then
                                '   SsMenuItem.Icon = New ImageResourceHandle(cDataReader.Item("Icono"))
                            End If
                            '   SMenuItem.MenuItems.AddRange(New Wisej.Web.MenuItem() {SsMenuItem})
                            AddHandler SsMenuItem.Click, AddressOf handlemenuclick11
                            SMenuItem.MenuItems.Add(SsMenuItem)
                            ' AddHandler SMenuItem.Click, AddressOf handlemenuclick11
                        End If
                    End If

                End While
            End If

            'If BOTONDOWN.Tag <> "SI" Then
            '    BOTONDOWN.Visible = False
            'End If



        Catch ex As SystemException
            MessageBox.Show("Error: " & ex.Message, "Aviso")

        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            oFunciones.Desconectar()
        End Try
    End Sub

    Private Sub handlemenuclick2(sender As Object, e As EventArgs)
        Mostrar_Formulario(sender.tag)
        'Throw New NotImplementedException()
    End Sub

    Private Sub handlemenuclick11(sender As Object, e As EventArgs)
        Mostrar_Formulario(sender.tag)
        '  Throw New NotImplementedException()
    End Sub

    'Private Sub handlemenuclick1(sender As Object, e As MenuButtonItemClickedEventArgs)
    '    Mostrar_Formulario(e.Item.Tag, Me)
    '    Throw New NotImplementedException()
    'End Sub

    'Sub handlemenuclick(ByVal objSource As Object, ByVal objArgs As Wisej.Web.MenuItemEventArgs)
    '    'Mostrar_Formulario(objArgs.MenuItem.Tag, Me)
    'End Sub
    Sub Mostrar_Formulario(ByVal cNodo As String)
        Dim objcontrol As Object = Nothing

        If cNodo = Nothing Then
            Exit Sub
        End If

        '  VWGContext.Current.Session("name_modulo") = cNodo
        Try
            Dim wSTproyecto As String = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name
            Dim Formulario As String = cNodo
            Dim ensamblado As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
            Dim f As Form = ensamblado.CreateInstance(wSTproyecto + "." + Formulario, True)
            f.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    '*************************
    'OPCIONES   RIBBON
    '*************************    
    'Private Sub rbnArchivos_recibidos_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Frm_Documentos_Ver_Form = New Documentos_Ver_Form
    '    Frm_Documentos_Ver_Form.Show()
    'End Sub

    'Private Sub rbnMensajes_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Frm_Mensaje = New Msg_Mostrar
    '    AddHandler Frm_Mensaje.Closed, AddressOf handleFrm_MensajeClosed
    '    Frm_Mensaje.ShowDialog()
    'End Sub

    'Private Sub rbnCambiar_Contrasena_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbnCambiar_Contrasena.Click
    '    Frm_Usuario_contrasena = New Cambiar_Contrasena
    '    Frm_Usuario_contrasena.ShowDialog()
    'End Sub

    Private Sub rbnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbnSalir.Click
        'Bitacora()
        Application.Session.IsLoggedOn = False
        'Application.Exit()
    End Sub

    'Private Sub bCaja_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bCaja.Click
    '    Dim Configura_InterfaceX As Configura_Interface
    '    Configura_InterfaceX = New Configura_Interface
    '    Configura_InterfaceX.Text = "Cambiar Interfaz"
    '    Configura_InterfaceX.Show()
    'End Sub

    'Private Sub handleClosed_Buscar_Solicitud(ByVal sender As Object, ByVal e As System.EventArgs)

    'End Sub
    'Sub Bitacora()
    '    oFunciones.Guardar_Bitacora(Application.Session("Cve_Operador"), "CERRAR SESION", Context.HttpContext.Request.UserHostAddress)
    'End Sub


    'Private Sub RibbonBar1_ButtonClick (ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
    '    Select Case e.Item.Text
    '        Case "Soporte_Mesa_Ayuda"
    '            Dim Soporte_Tecnicov As Soporte_Mesa_Ayuda
    '            Soporte_Tecnicov = New Soporte_Mesa_Ayuda
    '            Soporte_Tecnicov.Text = "Mesa de Ayuda"
    '            Soporte_Tecnicov.Show()
    '            Exit Sub
    '    End Select
    'End Sub
End Class



