Imports Wisej.Web
Imports System.Data.SqlClient
Imports Wisej.Web.Ext.RibbonBar
Public Class MyDesktop
    Dim dicParametros As New Dictionary(Of String, String)
    Dim oFunciones As New dllData
    Dim sModulo As String
    Dim ParametersX() As SqlClient.SqlParameter
    Public alternateSucursal As String
    Private Sub MyDesktop_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sPath = ConfigurationManager.AppSettings("Images").ToString & "Fondo02.jpeg"
        Me.Wallpaper = sPath
        CargarDatos()
        Application.LoadTheme(Application.Session("TEMA"))
        MOSTAR_ULTIMA_conexion()
        guardar_ultima_vez()

    End Sub
    Private Sub GenerarReporte(ByVal sReportName As String, ByVal sProcedureName As String)
        Application.Session("ReportName") = sReportName
        Application.Session("ProcedureName") = sProcedureName
        Application.Session("DicParametros") = dicParametros
        Application.Session("DocumentCached") = Nothing
    End Sub

    Private Sub CargarDatos()
        Try
            Try
                Dim sqlConnection1 As New SqlConnection(oFunciones.sConexion)
                Dim cmd As New SqlCommand
                Dim reader As SqlDataReader
                cmd.CommandText = "pACCESOS_MODULOS_ACCESOS_MODULOS_ROL_B"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@CVE_ROL", Application.Session("Cve_Rol"))
                cmd.Parameters.Add("@TIPO", "MODULO")
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                While reader.Read()
                    PopularMenu(reader("MODULO"), Usuario, "ADMIN", reader("MODULO"))
                End While
                sqlConnection1.Close()
            Catch ex As Exception
                MessageBox.Show("error: " & ex.Message, "Inicio",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LinkCerrar_Sesion_LinkClicked(ByVal sender As System.Object, ByVal e As Wisej.Web.LinkLabelLinkClickedEventArgs)
        Application.Session.IsLoggedOn = False
    End Sub
    '' apariencia del escritorio principal'''
    Sub PopularMenu(ByVal sModulo As String, ByVal Control As Wisej.Web.Ext.RibbonBar.RibbonBarGroup, ByVal sCve_Operador As String, Optional ByVal sSubModulo As String = Nothing, Optional ByVal sCve_Acceso_PadreX As String = Nothing)
        oFunciones.Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            oFunciones.cCommand = New SqlClient.SqlCommand("pACCESOS_MODULOS_OPERADOR", oFunciones.cConnect)
            oFunciones.cCommand.CommandType = CommandType.StoredProcedure
            oFunciones.cCommand.Parameters.AddWithValue("@USUARIO", sCve_Operador)
            oFunciones.cCommand.Parameters.AddWithValue("@Modulo", sModulo)
            If Trim(sSubModulo) <> Nothing Then
                oFunciones.cCommand.Parameters.AddWithValue("@SubModulo", sSubModulo)
            End If
            cDataReader = oFunciones.cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            Dim sCve_Acceso_Padre As String
            Dim SubMenuItem, SubMenu As MenuItem
            Dim group, grupo_principal As Ext.RibbonBar.RibbonBarGroup
            Dim item_menu As Ext.RibbonBar.RibbonBarItemButton
            Dim page_r As Ext.RibbonBar.RibbonBarPage
            Dim tag_page, tag_items, tag_submenu
            Dim CONT As ContextMenu
            CONT = New ContextMenu
            If cDataReader.HasRows Then
                While (cDataReader.Read)
                    If Trim(sCve_Acceso_Padre) <> cDataReader.Item("Cve_Acceso_Padre") Then
                        If cDataReader.Item("Tipo") = "MODULO" Then
                            page_r = New RibbonBarPage
                            page_r.Text = cDataReader.Item("descripcion")
                            tag_page = cDataReader.Item("CVE_ACCESO")
                            grupo_principal = New RibbonBarGroup
                            grupo_principal.Text = cDataReader.Item("descripcion")
                            RibbonBar1.Pages.Add(page_r)
                            page_r.Groups.Add(grupo_principal)


                        End If
                    End If
                    If cDataReader.Item("Tipo") = "SUBMODULO" Then
                        If tag_page = cDataReader.Item("CVE_ACCESO_PADRE") Then

                            If cDataReader.Item("BOTON") = "C" Then
                            Else
                                item_menu = New Ext.RibbonBar.RibbonBarItemButton
                                item_menu.ImageSource = cDataReader.Item("icono")
                                item_menu.Text = cDataReader.Item("descripcion")
                                item_menu.Name = cDataReader.Item("url")
                                grupo_principal.Items.Add(item_menu)
                            End If




                            tag_items = cDataReader.Item("CVE_ACCESO")
                            End If
                        End If
                    If cDataReader.Item("TIPO") = "SUBSUBMODULO" Then
                        If tag_items = cDataReader.Item("CVE_ACCESO_PADRE") Then
                            If cDataReader.Item("BOTON") = "C" Then
                            Else
                                item_menu = New Ext.RibbonBar.RibbonBarItemButton
                                item_menu.ImageSource = cDataReader.Item("icono")
                                item_menu.Text = cDataReader.Item("descripcion")
                                item_menu.Name = cDataReader.Item("url")
                                grupo_principal.Items.Add(item_menu)
                            End If
                        End If
                        tag_submenu = cDataReader.Item("CVE_ACCESO")
                    End If
                    If cDataReader.Item("TIPO") = "SUBSUBSUBMODULO" Then
                        If tag_submenu = cDataReader.Item("CVE_ACCESO_PADRE") Then
                            SubMenu = New MenuItem
                            SubMenu.Index = 0
                            SubMenu.Text = cDataReader.Item("descripcion")
                            SubMenu.Name = cDataReader.Item("url")
                            SubMenu.Tag = cDataReader.Item("url")
                            If Trim("" & cDataReader.Item("Icono")) <> Nothing Then

                            End If
                            AddHandler SubMenu.Click, AddressOf handlemenuclick2
                            CONT.MenuItems.AddRange(New Wisej.Web.MenuItem() {SubMenu})
                            item_menu.MenuItems.Add(SubMenu)
                        End If
                    End If
                End While
            End If
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
    End Sub
    Private Sub handlemenuclick11(sender As Object, e As EventArgs)
        Mostrar_Formulario(sender.tag)
    End Sub
    Sub Mostrar_Formulario(ByVal cNodo As String)
        Dim objcontrol As Object = Nothing
        If cNodo = Nothing Then
            Exit Sub
        End If
        Try
            Dim wSTproyecto As String = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name
            Dim ensamblado As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
            Dim f As Form = ensamblado.CreateInstance(wSTproyecto + "." + cNodo, True)
            f.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub RibbonBar1_ItemClick(sender As Object, e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Text
            Case "Cerrar Sesion"
                cerrar()
            Case "Cambiar Contraseña"
                Mostrar_Formulario("Cambiar_Contrasena")
            Case "Inf. de Usuario"
                Mostrar_Formulario("Perfil")
            Case "Temas"
                Mostrar_Formulario("Cambiar_Tema")
            Case "Cambiar Fondo Pantalla"
                Mostrar_Formulario("Cfondo_pantalla")
            Case "Historial de Sessiones"
                Mostrar_Formulario("Historial_Sessiones")
            Case Else
                Mostrar_Formulario(e.Item.Name)

        End Select
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

    Private Sub Tema_ItemClicked(sender As Object, e As RibbonBarMenuItemEventArgs)
        CambiarTema(e.MenuItem.Text)
    End Sub
    Private Sub cerrar()
        If (MessageBox.Show("¿Deseas Cerrar Session ahora?", "Cerrar Session", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            Application.Session.clear()
            Application.Session.IsLoggedOn = False
            Application.Exit()
        End If
    End Sub
    Private Sub MOSTAR_ULTIMA_conexion()

        oFunciones.Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            Dim FECHA, HORA, DIA, MES, AÑO, dia_mes

            oFunciones.cCommand = New SqlClient.SqlCommand("pCAT_SESSIONES_B", oFunciones.cConnect)
            oFunciones.cCommand.CommandType = CommandType.StoredProcedure
            oFunciones.cCommand.Parameters.AddWithValue("@CVE_OPERADOR", Application.Session("CVE_OPERADOR"))
            cDataReader = oFunciones.cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While (cDataReader.Read)

                    FECHA = cDataReader.Item("FECHA_INICIO_SESSION")
                    HORA = cDataReader.Item("HORA")
                    DIA = cDataReader.Item("DIA")
                    MES = cDataReader.Item("MES")
                    AÑO = cDataReader.Item("AÑO")
                    dia_mes = cDataReader.Item("DIA_MES")
                End While
            End If


            If FECHA.ToString.Length = 0 Or HORA.ToString.Length = 0 Then

                oFunciones.AlertBox("Bienvenido  " & Application.Session("Nombre") & " Es su primer inicio de session  ", MessageBoxIcon.Information)
            Else
                Dim subFECHA As String = Mid(FECHA, 1, 9)
                oFunciones.AlertBox("BIENVINIDO, Usuario: " & Application.Session("Nombre") & "  Su Ultimo acceso  al sistema fue el: " & DIA & " siendo " & dia_mes & " de " & MES & " del " & AÑO & ", " & "a las: " & HORA, MessageBoxIcon.Information)
            End If

        Catch ex As SystemException
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            oFunciones.Desconectar()
        End Try



    End Sub
    Private Sub guardar_ultima_vez()
        Dim HORA = DateAndTime.TimeOfDay.ToString("HH:mm:dd")
        Dim FECHA = DateTime.Now
        ReDim oFunciones.ParametersX_Global(0)
        oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_OPERADOR", Application.Session("CVE_OPERADOR"))


        Dim result As Integer = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_SESSIONE_G", "@param", oFunciones.ParametersX_Global, False, SqlDbType.Int)
        If result = Nothing Then

        Else

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If (MessageBox.Show("¿Deseas Cerrar Session ahora?", "Cerrar Session", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            Application.Session.clear()
            Application.Session.IsLoggedOn = False
            Application.Exit()
        End If
    End Sub

    Private Sub MyDesktop_ItemClick(sender As Object, e As DesktopTaskBarItemClickEventArgs) Handles Me.ItemClick
        If e.Item.Tag = "dat" Then
            If (MessageBox.Show("¿Deseas Cerrar Session ahora?", "Cerrar Session", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

            End If
        End If
    End Sub
End Class
