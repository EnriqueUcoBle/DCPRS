Imports System.Globalization
Imports Wisej.Web

Public Class Acta_Capturar
    Dim oFunciones, oFunciones2 As New dllData
    Dim dicParametros As New Dictionary(Of String, String)
    Dim filaActual As Integer = -1
    Dim horaActual As Date
    Public cveActa As String = 0
    Public FechaIngresoExpediente As String = Now

    Private Sub Acta_Capturar_Load(sender As Object, e As EventArgs) Handles Me.Load
        TabPage3.Hidden = True
        CBSPropietario_Cargo.SelectedIndex = 0
        CBSVerificadores_Adscritos.SelectedIndex = 0
        cargarTabla()
        subLlenarCombos()
        txtMunicipio.Text = Application.Session("MUNICIPIO")
        TextBox2.Text = Now.ToString("t", CultureInfo.CreateSpecificCulture("en-us"))
        horaActual = Date.Now.Hour & ":" & Date.Now.Minute
        DTPFecha.Value = Now
        DTPFecha_Emision_Orden.Value = Now
        DTPLabores_Inicio.ShowUpDown = True
        DTPLabores_Inicio.ShowCalendar = False
        DTPLabores_Fin.ShowUpDown = True
        DTPLabores_Fin.ShowCalendar = False
        UserPopup1.Visible = False
    End Sub

    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Text
            Case "Nuevo"
                oFunciones.LimpiarPanel(GroupBox3, Me.Tag)
            Case "Guardar"
                Dim FaltanDatos As Boolean = True
                Dim ControlSeleccionado As Integer = TabControl1.SelectedIndex
                If oFunciones.ValidarGrupos(GroupBox3, ErrorProvider1) Then 'Datos Generales que está en el RibbonBar
                    TabControl1.SelectedIndex = 1
                    If oFunciones.ValidarGruposTodo(TabPage1, ErrorProvider1) Then 'Datos de la Orden
                        TabControl1.SelectedIndex = 4
                        If DGVOperadores.RowCount > 0 Then
                            If oFunciones.ValidarGruposTodo(GroupBox5, ErrorProvider1) Then 'Testigos
                                TabControl1.SelectedIndex = 5
                                If oFunciones.ValidarGruposTodo(TabPage5, ErrorProvider1) Then 'Observaciones
                                    GuardarOrden()
                                    GuardarActa()
                                    FaltanDatos = False
                                    TabControl1.SelectedIndex = ControlSeleccionado
                                End If
                            End If
                        Else
                            ErrorProvider1.SetError(DGVOperadores, "No ha seleccionado verificadores")
                        End If
                    End If
                    End If

                If FaltanDatos Then
                    oFunciones.AlertBox("No pueden ir campos vacíos", MessageBoxIcon.Warning, MessageBoxButtons.OK)
                End If
            Case "Buscar"
                Dim Cat_Actas As New Cat_Actas_Verificacion
                Cat_Actas.Show()
            Case "Imprimir"
                'If validar() Then
                'guardar()
                ImprimirReporte()
                'End If
            Case "Salir"
                Me.Close()
                UserPopup1.Controls.Remove(GroupBox6)
        End Select
    End Sub
    Private Sub cargarTabla()
        Try
            Me.DataSet_pCAT_OPERADORES_B.pCAT_OPERADORES_B.Clear()
            Dim myDA = New SqlClient.SqlDataAdapter("pCAT_OPERADORES_B", oFunciones.sConexion)
            myDA.SelectCommand.Parameters.AddWithValue("@habilitado", 1)
            myDA.SelectCommand.Parameters.AddWithValue("@Cve_Rol", "R4") 'La clave de los verificadores
            myDA.SelectCommand.Parameters.AddWithValue("@cve_municipio", Application.Session.Item("CVE_MUNICIPIO"))
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_pCAT_OPERADORES_B.pCAT_OPERADORES_B)
            myDA.Dispose()

            'For fila As Integer = 0 To DGVOperadores.RowCount - 1
            '    DGVOperadores.Item("enviar", fila).Value = False
            'Next

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Cargar tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Sub subLlenarCombos()
        Try
            'Dim sProcedimiento As String = "pCAT_ESTABLECIMIENTOS_B @HABILITADO = 1, @cve_municipio = " & Application.Session.Item("CVE_MUNICIPIO")
            'oFunciones.Llenar_listbox(sProcedimiento, "CVE_ESTABLECIMIENTO", "RAZON_SOCIAL", CBSEstablecimiento,, True)
            ReDim oFunciones.ParametersX_Global(0)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@estatus", "PENDIENTE")
            oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_ORDENES_VERIFICACION_B", "URL_ARCHIVO", "FOLIO_ORDEN", CBSOrden, oFunciones.ParametersX_Global)
            ReDim oFunciones.ParametersX_Global(1)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@HABILITADO", 1)
            oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@cve_municipio", Application.Session("CVE_MUNICIPIO"))
            oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_ESTABLECIMIENTOS_B", "CVE_ESTABLECIMIENTO", "RAZON_SOCIALX", CBSEstablecimiento, oFunciones.ParametersX_Global)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Cargar listas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Sub GuardarOrden()
        Try
            ReDim oFunciones.ParametersX_Global(6)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@folio", TXTClaveActa.Text)
            oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@url_archivo", CBSOrden.SelectedValue)
            oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@fecha_emision", DTPFecha_Emision_Orden.Text)
            oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@estatus", "CAPTURADO")
            oFunciones.ParametersX_Global(4) = New SqlClient.SqlParameter("@cve_operador", Application.Session("Cve_Operador"))
            oFunciones.ParametersX_Global(5) = New SqlClient.SqlParameter("@emision", txtEmision_orden.Text)
            oFunciones.ParametersX_Global(6) = New SqlClient.SqlParameter("@emision_cargo", txtEmision_Cargo.Text)
            Dim parametro = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_ORDENES_VERIFICACION_G", "@parametro", oFunciones.ParametersX_Global, False, SqlDbType.Int, 50)

            If parametro <> Nothing Or parametro = TXTClaveActa.Text Then
                'MessageBox.Show("Datos guardados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Datos no guardados", "Guardar Orden", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub GuardarActa()
        Try
            ReDim oFunciones.ParametersX_Global(27)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_acta", cveActa)
            oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@folio_orden", CBSOrden.Text)
            oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@cve_establecimiento", CBSEstablecimiento.SelectedValue)
            oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@tipo_verificacion", IIf(RadioButton22.Checked, "Muestra", "Verificacion"))
            oFunciones.ParametersX_Global(4) = New SqlClient.SqlParameter("@fecha_verificacion", DTPFecha.Text)
            oFunciones.ParametersX_Global(5) = New SqlClient.SqlParameter("@hora_verificacion", TextBox2.Text)
            oFunciones.ParametersX_Global(6) = New SqlClient.SqlParameter("@fecha_ingreso_expediente", FechaIngresoExpediente)
            oFunciones.ParametersX_Global(7) = New SqlClient.SqlParameter("@programa", TXTPrograma.Text)
            oFunciones.ParametersX_Global(8) = New SqlClient.SqlParameter("@fecha_reporte_LSP", Now)
            oFunciones.ParametersX_Global(9) = New SqlClient.SqlParameter("@estatus", "Dictamen")
            oFunciones.ParametersX_Global(10) = New SqlClient.SqlParameter("@testigo1", txtTestigo1.Text)
            oFunciones.ParametersX_Global(11) = New SqlClient.SqlParameter("@testigo2", txtTestigo2.Text)
            oFunciones.ParametersX_Global(12) = New SqlClient.SqlParameter("@testigo_domicilio1", txtTestigo_Domicilio1.Text)
            oFunciones.ParametersX_Global(13) = New SqlClient.SqlParameter("@testigo_domicilio2", txtTestigo_Domicilio2.Text)
            oFunciones.ParametersX_Global(14) = New SqlClient.SqlParameter("@testigo_identificacion1", txtTestigo_identificacion1.Text)
            oFunciones.ParametersX_Global(15) = New SqlClient.SqlParameter("@testigo_identificacion2", txtTestigo_identificacion2.Text)
            oFunciones.ParametersX_Global(16) = New SqlClient.SqlParameter("@observaciones", txtObservaciones_Generales.Text)
            oFunciones.ParametersX_Global(17) = New SqlClient.SqlParameter("@medida_seguridad", RadioButton9.Checked)
            oFunciones.ParametersX_Global(18) = New SqlClient.SqlParameter("@aseguramiento", RadioButton12.Checked)
            oFunciones.ParametersX_Global(19) = New SqlClient.SqlParameter("@folio_aseguramiento", txtSellosAsegurados.Text)
            oFunciones.ParametersX_Global(20) = New SqlClient.SqlParameter("@suspencion", RadioButton14.Checked)
            oFunciones.ParametersX_Global(21) = New SqlClient.SqlParameter("@folio_suspencion", txtSellosSuspendidos.Text)
            oFunciones.ParametersX_Global(22) = New SqlClient.SqlParameter("@reubicacion", RadioButton16.Checked)
            oFunciones.ParametersX_Global(23) = New SqlClient.SqlParameter("@folio_reubicacion", txtSellosReubicados.Text)
            oFunciones.ParametersX_Global(24) = New SqlClient.SqlParameter("@anexa_documentacion", RadioButton18.Checked)
            oFunciones.ParametersX_Global(25) = New SqlClient.SqlParameter("@numero_anexos", txtNumeroAnexos.Text)
            oFunciones.ParametersX_Global(26) = New SqlClient.SqlParameter("@describir", txtDescribir.Text)
            If RBNAcuerdo.Checked Or RBNDesacuerdo.Checked Then
                oFunciones.ParametersX_Global(27) = New SqlClient.SqlParameter("@firma", IIf(RBNAcuerdo.Checked, RBNAcuerdo.Text, RBNDesacuerdo.Text))
            Else
                oFunciones.ParametersX_Global(27) = New SqlClient.SqlParameter("@firma", txtOtro_Acuerdo.Text)
            End If

            cveActa = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_ACTAS_VERIFICACION_G", "@parametro", oFunciones.ParametersX_Global, False, SqlDbType.VarChar, 50)

            If cveActa <> Nothing Then
                GuardarVerificadores(cveActa)
            Else
                MessageBox.Show("Datos no guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub GuardarVerificadores(ByVal scveActa As String)
        Try
            If DGVOperadores.RowCount > 0 Then
                For fila As Integer = 0 To DGVOperadores.RowCount - 1
                    ReDim oFunciones.ParametersX_Global(1)
                    oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_operador", DGVOperadores.Item("colCve_Operador", fila).Value)
                    oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@cve_acta", cveActa)

                    Dim parametro = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_VERIFICADORES_G", "@parametro", oFunciones.ParametersX_Global, False, SqlDbType.Int, 50)

                    If parametro <> Nothing Then
                        oFunciones.AlertBox("Datos guardados correctamente", MessageBoxIcon.Information, MessageBoxButtons.OK)
                    ElseIf parametro = Nothing Then
                        MessageBox.Show("Datos no guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                Next

            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & vbCrLf & ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TXTClaveActa.LinkClicked
        If CBSOrden.SelectedIndex = -1 Then Exit Sub
        Dim sRuta As String = Application.StartupPath & "\" & ConfigurationManager.AppSettings("Ordenes").ToString & CBSOrden.SelectedValue
        If System.IO.File.Exists(sRuta) Then
            PdfViewer1.PdfSource = sRuta
            TabPage3.Hidden = False
            TabControl1.SelectedIndex = 0
        Else
            MessageBox.Show("No se encuentra el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CBSOrden_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSOrden.SelectedIndexChanged
        If CBSOrden.SelectedIndex <> -1 Then
            Try
                TXTClaveActa.Text = CBSOrden.Text
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Cargar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Else
            TXTClaveActa.Text = Nothing
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVOperadores.CellClick
        Try
            If DGVOperadores.RowCount > 0 Then
                filaActual = DGVOperadores.CurrentRow.Index()
            End If
            If e.RowIndex <> -1 Then
                If e.ColumnIndex = 3 Then
                    If DGVOperadores.CurrentRow.Item("enviar").Value = True Then
                        DGVOperadores.Item("enviar", filaActual).Value = False
                    Else
                        DGVOperadores.Item("enviar", filaActual).Value = True
                    End If
                    If DGVOperadores.Item("enviar", e.RowIndex).Value = True Then 'Hay ocasiones que manda Nothing, no me culpes. Salu2
                        AgregarOperadores(e.RowIndex)
                    Else
                        Try
                            'If DataGridView1.RowCount > 0 Then
                            txtAreaOperadores.Text = Nothing 'Borra los registros para insertarlos nuevamente
                            For fila As Integer = 0 To DGVOperadores.RowCount - 1
                                If DGVOperadores.Item("enviar", fila).Value = True Then
                                    AgregarOperadores(fila)
                                End If
                            Next
                            'End If
                        Catch ex As Exception
                            MessageBox.Show("Error: " & ex.Message, "Registros", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End Try
                    End If
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Enviar Datos de Tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Sub AgregarOperadores(ByVal fila As Integer)

        If txtAreaOperadores.Text.Contains(DGVOperadores.Item("colNombre", fila).Value) = True Then Exit Sub
        If txtAreaOperadores.Text = Nothing Then
            txtAreaOperadores.Text = DGVOperadores.Item("colNombre", fila).Value
        Else
            txtAreaOperadores.Text = txtAreaOperadores.Text & ", " & DGVOperadores.Item("colNombre", fila).Value
        End If
    End Sub
    Private Sub CBSEstablecimiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSEstablecimiento.SelectedIndexChanged
        If CBSEstablecimiento.SelectedIndex <> -1 Then
            cargardatosEstablecimiento()
            'txtPropietario_Nombre.Text = oFunciones.obTener_Descripcion3(Combosax1, "NOM_PROPIETARIO")

        Else
            'txtDirección.Text = Nothing
            Label40.Text = Replace(Label40.Text, "C. " & txtPropietario.Text, "C. ")
            txtPropietario.Text = Nothing
        End If
    End Sub
    Sub cargardatosEstablecimiento()
        Try

            Dim propietario As String = oFunciones.obTener_Descripcion4(CBSEstablecimiento, "NOM_PROPIETARIO")
            Label40.Text = Replace(Label40.Text, "C. " & txtPropietario.Text, "C. " & propietario)
            txtPropietario.Text = propietario
            txtPropietario_Nombre.Text = propietario
            'txtDirección.Text = oFunciones.obTener_Descripcion4(CBSEstablecimiento, "DOMICILIO")
            txtGiro.Text = oFunciones.obTener_Descripcion4(CBSEstablecimiento, "GIRO")
            txtRFC.Text = oFunciones.obTener_Descripcion4(CBSEstablecimiento, "RFC")
            txtCodigoPostal.Text = oFunciones.obTener_Descripcion4(CBSEstablecimiento, "CODIGO_POSTAL")

        Catch ex As SystemException
            MessageBox.Show("Error: " & ex.Message, "Cargar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RBNIdentificacion_Otro.CheckedChanged
        txtPropietario_Identificacion.Enabled = IIf(RBNIdentificacion_Otro.Checked, True, False)
        'If RBNIdentificacion_Otro.Checked = True Then
        '    txtPropietario_Identificacion.Enabled = True
        'Else
        '    txtPropietario_Identificacion.Enabled = False
        'End If
    End Sub

    Private Sub ImprimirReporte()
        'GenerarReporte("R_Acta_Registro_Lotes", "pACTAS_VERIFICACION_LOTES_B")
        dicParametros.Clear()
        'dicParametros.Add("cve_acta", CBSOrden.Text)
        dicParametros.Add("cve_acta", CBSOrden.SelectedValue)
        oFunciones.GenerarReporte("R_ACTA_GENERAL", "pCAT_ACTAS_VERIFICACION_TEST_B", dicParametros)


        'Dim MOSTRAR_ASP As New Mostrar_Asp
        'MOSTRAR_ASP.AspPageBox1.PageSource = Nothing
        'Application.Session("ReportName") = sReportName
        'Application.Session("ProcedureName") = sProcedureName
        'Application.Session("DicParametros") = dicParametros
        'Application.Session("DocumentCached") = Nothing
        'MOSTRAR_ASP.AspPageBox1.PageSource = "ReportView.aspx"
        'MOSTRAR_ASP.AspPageBox1.Update()
        'MOSTRAR_ASP.Show()
    End Sub

    Private Sub RadioButton21_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton21.CheckedChanged
        If RadioButton21.Checked Then txtOtro_Acuerdo.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ventana = New Cat_Establecimientos
        ventana.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        UserPopup1.Width = 500
        'UserPopup1.Height = 216


        '   UserPopup1.Visible = True

        'UserPopup1.Visible = True

        'UserPopup1.AutoSize = True
        ' UserPopup1.Show()
        GroupBox6.Visible = True
        'GroupBox6.Dock = DockStyle.Fill
        'UserPopup1.Controls.Add(GroupBox6)
        GroupBox6.Dock = DockStyle.Fill
        UserPopup1.Controls.Add(GroupBox6)
        UserPopup1.ShowPopup(Button2)
        'UserPopup1.ShowPopup(Button2.Location.X, Button2.Location.Y)
        ' UserPopup1.ShowPopup(Button2.Location.X, Button2.Location.Y)

        'UserPopup1.Show()
        'f.ShowPopup(Button2, DialogAlignment.Above)
    End Sub

    Private Sub ComboBox_ToolClick(sender As Object, e As ToolClickEventArgs) Handles CBSOrden.ToolClick, CBSVerificadores_Adscritos.ToolClick, CBSEstablecimiento.ToolClick
        oFunciones.ToolClick(sender, e)
    End Sub

    Private Function validar() As Boolean
        validar = True
        If CBSOrden.SelectedIndex = -1 Or CBSEstablecimiento.SelectedIndex = -1 Then
            validar = False
        End If
    End Function

End Class
