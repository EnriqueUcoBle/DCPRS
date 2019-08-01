Imports System
Imports Wisej.Web
Public Class Generar_Orden_Verficacion
    Dim oFunciones As New dllData
    Dim ELEGIDOestablecimeinto As Boolean = False
    Dim loetes As Boolean = False
    Dim HabiliadoPorCP As Boolean = False
    Dim cve_objetivo, cve_orden_verificacion
    Dim CONTROL As Integer = 0
    Dim CONTROLV As Boolean = False
    Dim CONTROLVT As Boolean = False
    Dim cve_acta As Integer = Nothing

    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Name
            Case "NUEVO"
                LimpiarFormCompleto()
            Case "GUARDAR"
                guardar_todo()
            Case "ACTUALIZAR"
                llenarCombos()
                oFunciones.AlertBox("Listas Actualizadas ", Wisej.Web.MessageBoxIcon.Information)

            Case "SALIR"

                Me.Close()
        End Select

    End Sub
    Public Sub llenarCombos()
        Try
            oFunciones.Llenar_listbox("pCAT_ESTABLECIMIENTOS_B", "CVE_ESTABLECIMIENTO", "RAZON_SOCIAL", ESTABLECIMIENTO)

            oFunciones.Llenar_listbox("pCAT_OBJETIVOS_VERIFICACION_B", "CVE_OBJETIVO", "INFO", TIPO_OBJETIVO)
            oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_JURISDICCION_B", "CVE_JURISDICCION", "JURISDICCION", JURISDICCION_VERIFICADORES)
            ReDim oFunciones.ParametersX_Global(0)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@ESTADO", "TABASCO")
            oFunciones.Llenar_CatalogosXprocedureYParams("MUNICIPIOS_B", "MUNICIPIO", "MUNICIPIO", MUNICIPIOS_ESTABLECIMIENTOS, oFunciones.ParametersX_Global)


        Catch ex As Exception
            oFunciones.AlertBox("error al precargar la informacion: " & ex.Message, Wisej.Web.MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub Generar_Orden_Verficacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        llenarCombos()
        PAQUETES_ACTAS.SelectedIndex = -1
        ESTABLECIMIENTO.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles AddPaquete.Click
        Dim agregar = New ADD_LOTES
        agregar.Show()
        AddHandler agregar.FormClosed, AddressOf llenarCombos
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles AddEstablecimiento.Click
        Dim establecimiento_new = New Cat_Establecimientos_New
        establecimiento_new.Show()
        AddHandler establecimiento_new.FormClosed, AddressOf llenarCombos
    End Sub




    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CambiarPropietario.CheckedChanged

        If CambiarPropietario.Checked Then
            TextBoxRFC.ReadOnly = True
            TextBoxNOMBRE.ReadOnly = True
            TextBoxCARGO.ReadOnly = True
            TextBoxDOMICILIO_PROPIETARIO.ReadOnly = True
            ComboBoxIDENTIFIACION.ReadOnly = True

        Else

            TextBoxRFC.ReadOnly = False
            TextBoxNOMBRE.ReadOnly = False
            TextBoxCARGO.ReadOnly = False
            TextBoxDOMICILIO_PROPIETARIO.ReadOnly = False
            ComboBoxIDENTIFIACION.ReadOnly = False
        End If
    End Sub

    Private Sub Limpiar()
        Fecha_creacion_LOTE.Text = ""
        Jurisdiccion_LOTE.Text = ""
        Operador_LOTE.Text = ""
        TextBoxRFC.Text = ""
        TextBoxNOMBRE.Text = ""
        TextBoxCARGO.Text = ""
        TextBoxDOMICILIO_PROPIETARIO.Text = ""
        ComboBoxIDENTIFIACION.Text = ""
        TextBoxMUNICIPIO.Text = ""
        TextBoxRAZON_SOCIAL.Text = ""
        TextBoxGIRO.Text = ""
        TextBoxDIRECCION.Text = ""
        ComboBoxPROGRAMA.Text = ""

    End Sub
    '------------------------------------> Funciones para guardar y actulizar datos <-------------------------------------------


    Public Function Add_Muestra_On_TABLA_MUESTRAS(ByVal CVE_TIPO_MUESTRA As Integer, ByVal CVE_TIPO_ANALISIS As Integer, ByVal DESCRIPCION As String, ByVal CLAVE_VS As String, ByVal LOTE As String, ByVal MARCA As String, ByVal FECHA_CADUCIDAD As Date, ByVal CANTIDAD As Integer) As Boolean
        Try
            MUESTRAS_GRID.Rows.Add()
            Dim FILA As Integer = MUESTRAS_GRID.Rows.Count - 1
            MUESTRAS_GRID.Item("CVE_TIPO_MUESTRA", FILA).Value = CVE_TIPO_MUESTRA
            MUESTRAS_GRID.Item("CVE_TIPO_ANALISIS", FILA).Value = CVE_TIPO_ANALISIS
            MUESTRAS_GRID.Item("DESCRIPCION", FILA).Value = DESCRIPCION
            MUESTRAS_GRID.Item("CLAVE_VS", FILA).Value = CLAVE_VS
            MUESTRAS_GRID.Item("MARCA", FILA).Value = MARCA
            MUESTRAS_GRID.Item("LOTE", FILA).Value = LOTE
            MUESTRAS_GRID.Item("CANTIDAD", FILA).Value = CANTIDAD
            MUESTRAS_GRID.Item("FECHA", FILA).Value = FECHA_CADUCIDAD
        Catch ex As Exception
            Wisej.Web.MessageBox.Show("Error al guardar, ERROR: " & ex.Message, "Guardar", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
            Return False
        End Try
        Return True
    End Function
    '------------------------------------> Funciones para guardar y actulizar datos <-------------------------------------------






    '------------------------------------> CAMBIO DE TAB <-------------------------------------------
    Private Sub sig_pag2_Click(sender As Object, e As EventArgs) Handles sig_pag2.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub ant_pag2_Click(sender As Object, e As EventArgs) Handles ant_pag2.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub sig_pag1_Click(sender As Object, e As EventArgs) Handles sig_pag1.Click
        TabControl1.SelectedTab = TabPage2
    End Sub
    Private Sub ant_pag3_Click(sender As Object, e As EventArgs) Handles ant_pag3.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub sig_pag3_Click(sender As Object, e As EventArgs) Handles sig_pag3.Click
        TabControl1.SelectedTab = TabPage4
    End Sub

    Private Sub ant_pag4_Click(sender As Object, e As EventArgs) Handles ant_pag4.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub finalizar_Click(sender As Object, e As EventArgs) Handles finalizar.Click
        'guardar_acta()
    End Sub

    Private Sub ComboBoxMUNICIPIO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MUNICIPIOS_ESTABLECIMIENTOS.SelectedIndexChanged
        CONTROL = CONTROL + 1
        If MUNICIPIOS_ESTABLECIMIENTOS.SelectedIndex = -1 Then Exit Sub
        If CONTROL <= 1 Then Exit Sub
        Try
            ReDim oFunciones.ParametersX_Global(0)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@MUNICIPIO", MUNICIPIOS_ESTABLECIMIENTOS.SelectedValue)
            oFunciones.Llenar_listbox("pCAT_COLONIAS_B", "CVE_COLONIA", "ASENTAMIENTO", COLONIA_ESTABLECIMIENTOS, oFunciones.ParametersX_Global)
            CONTROL = 1
        Catch ex As Exception
            Wisej.Web.MessageBox.Show("al rellenar los datos, ERROR: " & ex.Message, "Error:", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
        End Try
    End Sub
    '------------------------------------> CAMBIO DE TAB <-------------------------------------------
    Private Sub ComboBoxCOLONIA_SelectedIndexChanged(sender As Object, e As EventArgs)
        If COLONIA_ESTABLECIMIENTOS.SelectedIndex = -1 Then Exit Sub
        If HabiliadoPorCP Then
            TextBoxCP.Text = oFunciones.obetenerDescripcion4(COLONIA_ESTABLECIMIENTOS, "CP")
        End If
    End Sub
    Private Sub TextBoxCP_KeyUp(sender As Object, e As Wisej.Web.KeyEventArgs) Handles TextBoxCP.KeyUp

        Try
            If e.KeyCode = Windows.Forms.Keys.Enter Then
                ReDim oFunciones.ParametersX_Global(0)
                COLONIA_ESTABLECIMIENTOS.Clear()
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@CP", TextBoxCP.Text)
                oFunciones.Llenar_listbox("pCAT_COLONIAS_B", "CVE_COLONIA", "ASENTAMIENTO", COLONIA_ESTABLECIMIENTOS, oFunciones.ParametersX_Global)
                If COLONIA_ESTABLECIMIENTOS.Count <= 0 Then
                    Wisej.Web.MessageBox.Show("No Existe el codigo postal, favor de verificar CP : " & TextBoxCP.Text, "ATENCION", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
                    Exit Sub
                End If
                COLONIA_ESTABLECIMIENTOS.SelectedIndex = 0
                Dim Text = oFunciones.obetenerDescripcion4(COLONIA_ESTABLECIMIENTOS, "MUNICIPIO")
                MUNICIPIOS_ESTABLECIMIENTOS.SelectedValue = Text
                CONTROL = True
            End If
        Catch ex As Exception
            Wisej.Web.MessageBox.Show("al rellenar los datos, ERROR: " & ex.Message, "Error:", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub CheckBoxEDITAR_DIRECCION_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxEDITAR_DIRECCION.CheckedChanged
        If CheckBoxEDITAR_DIRECCION.Checked Then
            MUNICIPIOS_ESTABLECIMIENTOS.ReadOnly = True
            COLONIA_ESTABLECIMIENTOS.Enabled = True
            TextBoxCP.ReadOnly = True
            TextBoxDIRECCION.ReadOnly = True

        Else
            MUNICIPIOS_ESTABLECIMIENTOS.ReadOnly = False
            COLONIA_ESTABLECIMIENTOS.Enabled = False
            TextBoxCP.ReadOnly = False
            TextBoxDIRECCION.ReadOnly = False
        End If
    End Sub


    Private Sub ComboBoxLOTE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PAQUETES_ACTAS.SelectedIndexChanged
        If PAQUETES_ACTAS.SelectedIndex = -1 Then Exit Sub
        Try
            Fecha_creacion_LOTE.Text = oFunciones.obetenerDescripcion4(PAQUETES_ACTAS, "FECHA_EXPEDICION")
            Operador_LOTE.Text = oFunciones.obetenerDescripcion4(PAQUETES_ACTAS, "NOMPRE_OPERADOR")
            Jurisdiccion_LOTE.Text = oFunciones.obetenerDescripcion4(PAQUETES_ACTAS, "JURISDICCION")
        Catch ex As Exception
            Wisej.Web.MessageBox.Show("cargar datos de los paquetes , ERROR: " & ex.Message, "llenar datos de los paquetes de actas", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub Combosax_B1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ESTABLECIMIENTO.SelectedIndexChanged
        If ELEGIDOestablecimeinto <> True Then
            ELEGIDOestablecimeinto = True
            Exit Sub
        Else
            If ESTABLECIMIENTO.SelectedIndex = -1 Then Exit Sub
            Try
                If (ESTABLECIMIENTO.SelectedIndex <> -1) Then
                    TextBoxRAZON_SOCIAL.Text = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "RAZON_SOCIAL")
                    TextBoxNOMBRE.Text = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "NOMBRE_PROPIETARIO")
                    TextBoxMUNICIPIO.Text = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "NOM_JURIS_CON")
                    MUNICIPIOS_ESTABLECIMIENTOS.Text = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "JURISDICCION")
                    TextBoxGIRO.Text = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "GIRO")
                    TextBoxRFC.Text = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "RFC")
                    TextBoxDOMICILIO_PROPIETARIO.Text = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "DOMICILIO_PROPIETARIO")
                    TextBoxDIRECCION.Text = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "DOMICILIO")
                    COLONIA_ESTABLECIMIENTOS.SelectedItem = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "COLONIA")
                    'TextBoxCARGO.Text = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "IDENTIFICACION")
                    TextBoxCP.Text = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "CODIGO_POSTAL")
                    ComboBoxIDENTIFIACION.Text = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "IDENTIFICACION")
                    'TextBoxPROGRAMA.Text = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "PROGRAMA")
                    ELEGIDOestablecimeinto = True
                    llenar_Datos_encargado()
                End If
            Catch ex As Exception
                Wisej.Web.MessageBox.Show("rellenar la informacion, ERROR: " & ex.Message, "llenar datos del establecimiento", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
            End Try
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles AddVerificador.Click
        Dim form_verficadores = New add_Verificadores
        form_verficadores.Visible = True
        AddHandler form_verficadores.FormClosed, AddressOf llenarCombos
    End Sub
    Private Sub JURISDICCION_VERIFICADORES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles JURISDICCION_VERIFICADORES.SelectedIndexChanged
        If JURISDICCION_VERIFICADORES.SelectedIndex = -1 Then Exit Sub
        If CONTROLV Then
            ReDim oFunciones.ParametersX_Global(0)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_JURISDICCION", JURISDICCION_VERIFICADORES.SelectedValue)
            VERIFICADORES.Clear()
            oFunciones.Llenar_listbox("pCAT_VERIFICADORES_B", "CVE_VERIFICADOR", "NOMB", VERIFICADORES, oFunciones.ParametersX_Global)
            VERIFICADORES.Mostrar_lista()
        Else
            CONTROLV = True
        End If
    End Sub
    Private Sub RB_suspencion_trabajo_si_CheckedChanged(sender As Object, e As EventArgs) Handles RB_suspencion_trabajo_si.CheckedChanged
        FOLIO_SUSPENCION.Enabled = True
    End Sub
    Private Sub RB_aseguramiento_objetos_si_CheckedChanged(sender As Object, e As EventArgs) Handles RB_aseguramiento_objetos_si.CheckedChanged
        FOLIO_ASEGURAMIENTO.Enabled = True
    End Sub
    Private Sub RB_reubicacion_sellos_si_CheckedChanged(sender As Object, e As EventArgs) Handles RB_reubicacion_sellos_si.CheckedChanged
        FOLIO__REUBICACION.Enabled = True
    End Sub
    Private Sub VERIFICADORES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VERIFICADORES.SelectedIndexChanged
        If VERIFICADORES.SelectedIndex = -1 Then Exit Sub
        Dim validado As Boolean = True
        'If CONTROLVT Then
        If VERIFICADORES_GRID.RowCount = 0 Then
            validado = True
        Else
            For Each COLUM As DataGridViewRow In VERIFICADORES_GRID.Rows
                If COLUM.Item("Correo").Value = oFunciones.obetenerDescripcion4(VERIFICADORES, "CVE_VERIFICADOR") Then
                    validado = False
                End If
            Next
        End If
        If validado Then
            VERIFICADORES_GRID.Rows.Add()
            Dim FILA As Integer = VERIFICADORES_GRID.Rows.Count - 1
            VERIFICADORES_GRID.Item("Nombre", FILA).Value = oFunciones.obetenerDescripcion4(VERIFICADORES, "NOMB")
            VERIFICADORES_GRID.Item("Jurisdiccion", FILA).Value = oFunciones.obetenerDescripcion4(VERIFICADORES, "JURISDICCION")
            VERIFICADORES_GRID.Item("Correo", FILA).Value = oFunciones.obetenerDescripcion4(VERIFICADORES, "CVE_VERIFICADOR")
            VERIFICADORES_GRID.Item("Sexo", FILA).Value = oFunciones.obetenerDescripcion4(VERIFICADORES, "SEXO")
            VERIFICADORES_GRID.Item("Clave_Trabajador", FILA).Value = oFunciones.obetenerDescripcion4(VERIFICADORES, "CLAVE_TRABAJADOR")
        Else
            Wisej.Web.MessageBox.Show("ya existe el varificador en la tabla   ", "VALIDACIO DE VERIFICADOR", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Information)
        End If
    End Sub
    Private Function validarVerificadores() As Boolean

    End Function
    Private Sub TablaVerifacadores_CellClick(sender As Object, e As Wisej.Web.DataGridViewCellEventArgs) Handles VERIFICADORES_GRID.CellClick
        If e.ColumnIndex = 0 Then
            If (Wisej.Web.MessageBox.Show("¿Esta segur@ de eliminar el Verficador seleccionado?", "Eliminar", Wisej.Web.MessageBoxButtons.YesNo, Wisej.Web.MessageBoxIcon.Question) = DialogResult.Yes) Then
                VERIFICADORES_GRID.Rows.Remove(VERIFICADORES_GRID.CurrentRow)
            End If
        ElseIf e.ColumnIndex = 1 Then
        End If
    End Sub

    Private Sub ULTIMOS_PAQUETES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ULTIMOS_PAQUETES.SelectedIndexChanged
        If ULTIMOS_PAQUETES.SelectedIndex = -1 Then Exit Sub
        If ULTIMOS_PAQUETES.SelectedItem = "TODOS" Then
            oFunciones.Llenar_listbox("pCAT_PAQUETES_ACTAS_B", "CVE_PAQUETE", "NOMBRE", PAQUETES_ACTAS)
        Else
            ReDim oFunciones.ParametersX_Global(0)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@TOP", ULTIMOS_PAQUETES.SelectedItem)
            oFunciones.Llenar_listbox("pCAT_PAQUETES_ACTAS_B", "CVE_PAQUETE", "NOMBRE", PAQUETES_ACTAS, oFunciones.ParametersX_Global)
        End If
    End Sub
    Private Sub añadir_item(sender As Object, e As EventArgs)
        Dim form As Add_Muestra = sender.Parent.Parent
        If form._Validar = True Then
            Add_Muestra_On_TABLA_MUESTRAS(form.TIPO_MUESTRA.SelectedValue, form.TIPO_ANALISIS.SelectedValue, form.DESCRIPCION.Text, form.CLAVE_VS.Text, form.LOTE.Text, form.MARCA.Text, form.FECHA_CADUCIDAD.Value, form.CANTIDAD.Value)
            form.limpiar()
            form.AÑADIR_ITEM.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form = New Add_Muestra
        form.Show()
        AddHandler form.AÑADIR_ITEM.Click, AddressOf añadir_item
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As Wisej.Web.DataGridViewCellEventArgs) Handles MUESTRAS_GRID.CellClick
        If e.ColumnIndex = 0 Then
            If (Wisej.Web.MessageBox.Show("¿Esta segur@ de eliminar la muestra seleccionada?", "Eliminar", Wisej.Web.MessageBoxButtons.YesNo, Wisej.Web.MessageBoxIcon.Question) = DialogResult.Yes) Then
                MUESTRAS_GRID.Rows.Remove(MUESTRAS_GRID.CurrentRow)
            End If
        ElseIf e.ColumnIndex = 1 Then
        End If
    End Sub

    Private Sub AddObjetivoVerificacion_Click(sender As Object, e As EventArgs) Handles AddObjetivoVerificacion.Click
        Dim form = New Add_Objetivos_vb
        form.Visible = True
        AddHandler form.FormClosed, AddressOf llenarCombos
    End Sub

    Private Sub Panel9_PanelCollapsed(sender As Object, e As EventArgs) Handles Panel9.PanelCollapsed

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        llenar_Datos_encargado()
    End Sub
    Private Sub llenar_Datos_encargado()
        If RadioButton1.Checked Then
            NOMBRE_ENCARGADO.Enabled = False
            DETALLE_DOMICILIO_ENCARGADO.Enabled = False
            IDENTIDAD_ENCARGADO.Enabled = False
            CARGO_PUESTO.Enabled = False
            If TextBoxNOMBRE.Text.Length = 0 Then
                Wisej.Web.MessageBox.Show("Debes seleccionar establecimiento  ", "Datos faltante", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
            End If
            NOMBRE_ENCARGADO.Text = TextBoxNOMBRE.Text
            DETALLE_DOMICILIO_ENCARGADO.Text = TextBoxDOMICILIO_PROPIETARIO.Text
            IDENTIDAD_ENCARGADO.Text = ComboBoxIDENTIFIACION.Text
            CARGO_PUESTO.Text = "Jefe y/o Dueño"

        Else
            NOMBRE_ENCARGADO.Enabled = True
            DETALLE_DOMICILIO_ENCARGADO.Enabled = True
            IDENTIDAD_ENCARGADO.Enabled = True
            CARGO_PUESTO.Enabled = True
            NOMBRE_ENCARGADO.Text = ""
            DETALLE_DOMICILIO_ENCARGADO.Text = ""
            IDENTIDAD_ENCARGADO.Text = ""
            CARGO_PUESTO.Text = ""
        End If
    End Sub
    Private Sub LimpiarFormCompleto()
        oFunciones.LimpiarPanel(Panel1, Me.Tag)
        oFunciones.LimpiarPanel(Panel8, Me.Tag)
        oFunciones.LimpiarPanel(Panel9, Me.Tag)
        oFunciones.LimpiarPanel(Panel15, Me.Tag)

    End Sub
    Private Function guardarActaA() As Integer
        Try
            ReDim oFunciones.ParametersX_Global(29)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@folio_orden", FOLIO_ORDEN.Text)
            oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@cve_establecimiento", ESTABLECIMIENTO.SelectedValue)
            oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@fecha_verificacion", FECHA_ORDEN.Value)
            oFunciones.ParametersX_Global(4) = New SqlClient.SqlParameter("@hora_verificacion", HORA_VERIFICACION.Value)
            oFunciones.ParametersX_Global(5) = New SqlClient.SqlParameter("@programa", PROGRAMA_.SelectedItem)
            oFunciones.ParametersX_Global(6) = New SqlClient.SqlParameter("@nom_testigo1", txtTestigo1.Text)
            oFunciones.ParametersX_Global(7) = New SqlClient.SqlParameter("@nom_testigo2", txtTestigo2.Text)
            oFunciones.ParametersX_Global(8) = New SqlClient.SqlParameter("@dom_testigo1", txtTestigo_Domicilio1.Text)
            oFunciones.ParametersX_Global(9) = New SqlClient.SqlParameter("@dom_testigo2", txtTestigo_Domicilio2.Text)
            oFunciones.ParametersX_Global(10) = New SqlClient.SqlParameter("@id_testigo1", id_testigo1.SelectedItem)
            oFunciones.ParametersX_Global(11) = New SqlClient.SqlParameter("@id_testigo2", id_testigo2.SelectedItem)
            oFunciones.ParametersX_Global(12) = New SqlClient.SqlParameter("@observaciones", OBSERVACIONES_GENERALES.Text)
            oFunciones.ParametersX_Global(13) = New SqlClient.SqlParameter("@medida_seguridad", RB_medidas_seguridad_si.Checked)
            oFunciones.ParametersX_Global(14) = New SqlClient.SqlParameter("@folio_aseguramiento", FOLIO_ASEGURAMIENTO.Text)
            oFunciones.ParametersX_Global(15) = New SqlClient.SqlParameter("@folio_suspecion", FOLIO_SUSPENCION.Text)
            oFunciones.ParametersX_Global(16) = New SqlClient.SqlParameter("@folio_reubicacion", FOLIO__REUBICACION.Text)
            oFunciones.ParametersX_Global(17) = New SqlClient.SqlParameter("@documentacion", RB_anexa_doc_si.Checked)
            oFunciones.ParametersX_Global(18) = New SqlClient.SqlParameter("@numero_anexos", txtNumeroAnexos.Text)
            oFunciones.ParametersX_Global(19) = New SqlClient.SqlParameter("@numero_anexos", txtNumeroAnexos.Text)
            oFunciones.ParametersX_Global(20) = New SqlClient.SqlParameter("@folio_acta", FOLIO_ACTA_VERIFICACION.Text)
            oFunciones.ParametersX_Global(21) = New SqlClient.SqlParameter("@cve_operador", Application.Session("CVE_OPERADOR"))
            oFunciones.ParametersX_Global(22) = New SqlClient.SqlParameter("@cve_objetivo", TIPO_OBJETIVO.SelectedValue)
            oFunciones.ParametersX_Global(23) = New SqlClient.SqlParameter("@nombre_encargardo", NOMBRE_ENCARGADO.Text)
            oFunciones.ParametersX_Global(24) = New SqlClient.SqlParameter("@identificacion_encargado", IDENTIDAD_ENCARGADO.SelectedItem)
            oFunciones.ParametersX_Global(25) = New SqlClient.SqlParameter("@domicilio_encargado", DETALLE_DOMICILIO_ENCARGADO.Text)
            oFunciones.ParametersX_Global(26) = New SqlClient.SqlParameter("@cargo_encargado", CARGO_PUESTO.Text)
            oFunciones.ParametersX_Global(27) = New SqlClient.SqlParameter("@cve_establecimiento", ESTABLECIMIENTO.SelectedValue)
            oFunciones.ParametersX_Global(28) = New SqlClient.SqlParameter("@fecha_orden", FECHA_ORDEN.Text)
            oFunciones.ParametersX_Global(29) = New SqlClient.SqlParameter("@motivo", MOTIVO.SelectedItem)
            cve_acta = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_ACTAS_VERIFICACION_G", "@parametro", oFunciones.ParametersX_Global, False, SqlDbType.VarChar, 50)
            If cve_acta <> Nothing Or cve_acta <> 0 Then
                Wisej.Web.MessageBox.Show("Acta con folio : " & cve_acta & "ha sido almacenada correctamente", "Guardar", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Wisej.Web.MessageBox.Show("Error al guardar, ERROR: " & ex.Message, "Guardar", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
        End Try
        Return cve_acta
    End Function

    Private Sub guardar_Verificadores()
        Dim result As Integer = Nothing
        If cve_acta = Nothing Or cve_acta = 0 Then
        Else
            For Each COLUM As DataGridViewRow In VERIFICADORES_GRID.Rows

                Try
                    ReDim oFunciones.ParametersX_Global(1)
                    oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_VERIFCADOR", COLUM.Item("Correo").Value)
                    oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@CVE_ACTA", cve_acta)
                    result = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_VERIFICADORES_ACTAS_G", "@PARAM", oFunciones.ParametersX_Global, False, SqlDbType.Int)
                    If result = 200 Then
                        oFunciones.AlertBox("Verificador Vinculado a el acta: " & COLUM.Item("Nombre").Value, MessageBoxIcon.Information)
                    Else
                        oFunciones.AlertBox("Error al vincular el verificador:  " & COLUM.Item("Nombre").Value & "con el acta", MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    Wisej.Web.MessageBox.Show("Error al guardar, ERROR: " & ex.Message, "Guardar  :Exception:", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
                End Try

            Next
        End If

    End Sub
    Private Sub guardar_muestras()
        Dim result As Integer = Nothing
        If cve_acta = Nothing Or cve_acta = 0 Then
        Else
            For Each COLUM As DataGridViewRow In MUESTRAS_GRID.Rows

                Try
                    ReDim oFunciones.ParametersX_Global(7)
                    oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_TIPO_MUESTRA", COLUM.Item("CVE_TIPO_MUESTRA").Value)
                    oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@CVE_ACTA", cve_acta)
                    oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@CVE_TIPO_ANALISIS", COLUM.Item("CVE_TIPO_ANALISIS").Value)
                    oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@DESCRIPCION", COLUM.Item("DESCRIPCION").Value)
                    oFunciones.ParametersX_Global(4) = New SqlClient.SqlParameter("@CLAVE_VS", COLUM.Item("CLAVE_VS").Value)
                    oFunciones.ParametersX_Global(5) = New SqlClient.SqlParameter("@MARCA", COLUM.Item("MARCA").Value)
                    oFunciones.ParametersX_Global(6) = New SqlClient.SqlParameter("@FECHA_CADUCIDA", COLUM.Item("CADUCIDAD").Value)
                    oFunciones.ParametersX_Global(7) = New SqlClient.SqlParameter("@CANTIDAD", COLUM.Item("CANTIDAD").Value)
                    result = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_TIPO_MUESTRAS_G", "@PARAM", oFunciones.ParametersX_Global, False, SqlDbType.Int)
                    If result = 200 Then
                        oFunciones.AlertBox("Muestras Vinculado a el acta con id: " & result, MessageBoxIcon.Information)
                    Else
                        oFunciones.AlertBox("Error al vincular las Muestras", MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    Wisej.Web.MessageBox.Show("Error al guardar, ERROR: " & ex.Message, "Guardar  :Exception:", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
                End Try

            Next
        End If
    End Sub
    Private Sub guardarOrdenVerificacion()
        Try
            ReDim oFunciones.ParametersX_Global(1)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@FOLIO", FOLIO_ORDEN.Text)
            oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@URL", FOLIO_ORDEN.Text)

            Dim result As String = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_ORDEN_VERIFICACION_G", "@PARAM", oFunciones.ParametersX_Global, False, SqlDbType.VarChar, 50)
            If result = FOLIO_ORDEN.Text Then
                oFunciones.AlertBox("orden almacenada " & result, MessageBoxIcon.Information)
            Else
                oFunciones.AlertBox("Error al guardar la orden  ", MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Wisej.Web.MessageBox.Show("Error al guardar, ERROR: " & ex.Message, "Guardar  :Exception:", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub guardar_todo()
        guardarActaA()
        guardar_Verificadores()
        guardar_muestras()
        guardarOrdenVerificacion()


    End Sub
End Class
