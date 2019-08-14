Imports System
Imports Wisej.Web
Public Class Generar_Orden_Verficacion
    Dim oFunciones As New dllData
    Dim ELEGIDOestablecimeinto As Boolean = False
    Dim CONTROL As Integer = 0
    Dim CONTROLV As Boolean = False
    Dim CONTROLVT As Boolean = False
    Public cve_acta As Integer = Nothing

    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Name
            Case "NUEVO"
                LimpiarFormCompleto()
            Case "SALIR"

                Me.Close()
        End Select

    End Sub
    Public Sub llenarCombos()
        Try

            oFunciones.Llenar_listbox("pCAT_ESTABLECIMIENTOS_B", "CVE_ESTABLECIMIENTO", "RAZON_SOCIAL", ESTABLECIMIENTO)

            oFunciones.Llenar_listbox("pCAT_OBJETIVOS_VERIFICACION_B", "CVE_OBJETIVO", "INFO", TIPO_OBJETIVO)



        Catch ex As Exception
            oFunciones.AlertBox("error al precargar la informacion: " & ex.Message, Wisej.Web.MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Generar_Orden_Verficacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        llenarCombos()
        'PAQUETES_ACTAS.SelectedIndex = -1
        'ESTABLECIMIENTO.SelectedIndex = -1
    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles AddEstablecimiento.Click
        Dim establecimiento_new = New Cat_Establecimientos_New
        establecimiento_new.Show()
        AddHandler establecimiento_new.FormClosed, AddressOf llenarCombos
    End Sub




    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

        If Editar_Propietario.Checked Then
            RFC_EST.ReadOnly = True
            NOMBRE_PROPIETARIO.ReadOnly = True

            DOMICILIO_PROPIETARIO.ReadOnly = True
            ID_PROPIETARIO.ReadOnly = True

        Else

            RFC_EST.ReadOnly = False
            NOMBRE_PROPIETARIO.ReadOnly = False

            DOMICILIO_PROPIETARIO.ReadOnly = False
            ID_PROPIETARIO.ReadOnly = False
        End If
    End Sub

    Private Sub Limpiar()
        'Fecha_creacion_LOTE.Text = ""
        'Jurisdiccion_LOTE.Text = ""
        'Operador_LOTE.Text = ""
        RFC_EST.Text = ""
        NOMBRE_PROPIETARIO.Text = ""

        DOMICILIO_PROPIETARIO.Text = ""
        ID_PROPIETARIO.Text = ""
        JURISDICCION_EST.Text = ""
        RAZON_SOCIAL_EST.Text = ""
        GIRO_EST.Text = ""
        DOMICILIO_EST.Text = ""


    End Sub
    '------------------------------------> Funciones para guardar y actulizar datos <-------------------------------------------


    Public Function Add_Muestra_On_TABLA_MUESTRAS(ByVal CVE_TIPO_MUESTRA As Integer, ByVal CVE_TIPO_ANALISIS As Integer, ByVal DESCRIPCION As String, ByVal CLAVE_VS As String, ByVal LOTE As String, ByVal MARCA As String, ByVal FECHA_CADUCIDAD As String, ByVal CANTIDAD As Integer) As Boolean
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
        TabControl1.SelectedTab = TabPage5
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedTab = TabPage4
    End Sub
    '------------------------------------> CAMBIO DE TAB <-------------------------------------------

    Private Sub TextBoxCP_KeyUp(sender As Object, e As Wisej.Web.KeyEventArgs) Handles CP_EST.KeyUp

        Try
            If e.KeyCode = Windows.Forms.Keys.Enter Then
                ReDim oFunciones.ParametersX_Global(0)
                COLONIA_ESTABLECIMIENTOS.Clear()
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@CP", CP_EST.Text)
                oFunciones.Llenar_listbox("pCAT_COLONIAS_B", "CVE_COLONIA", "ASENTAMIENTO", COLONIA_ESTABLECIMIENTOS, oFunciones.ParametersX_Global)
                If COLONIA_ESTABLECIMIENTOS.Count <= 0 Then
                    Wisej.Web.MessageBox.Show("No Existe el codigo postal, favor de verificar CP : " & CP_EST.Text, "ATENCION", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
                    Exit Sub
                End If
                COLONIA_ESTABLECIMIENTOS.SelectedIndex = 0
                Dim Text = oFunciones.obetenerDescripcion4(COLONIA_ESTABLECIMIENTOS, "MUNICIPIO")

                CONTROL = True
            End If
        Catch ex As Exception
            Wisej.Web.MessageBox.Show("al rellenar los datos, ERROR: " & ex.Message, "Error:", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub CheckBoxEDITAR_DIRECCION_CheckedChanged(sender As Object, e As EventArgs) Handles Editar_Domicilio.CheckedChanged
        If Editar_Domicilio.Checked Then

            COLONIA_ESTABLECIMIENTOS.Enabled = True
            CP_EST.ReadOnly = True
            DOMICILIO_EST.ReadOnly = True

        Else

            COLONIA_ESTABLECIMIENTOS.Enabled = False
            CP_EST.ReadOnly = False
            DOMICILIO_EST.ReadOnly = False
        End If
    End Sub




    Private Sub Combosax_B1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ESTABLECIMIENTO.SelectedIndexChanged
        If ELEGIDOestablecimeinto <> True Then
            ELEGIDOestablecimeinto = True
            Exit Sub
        Else
            If ESTABLECIMIENTO.SelectedIndex = -1 Then Exit Sub
            Try
                If (ESTABLECIMIENTO.SelectedIndex <> -1) Then
                    RAZON_SOCIAL_EST.Text = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "RAZON_SOCIAL")
                    NOMBRE_PROPIETARIO.Text = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "NOMBRE_PROPIETARIO")
                    JURISDICCION_EST.Text = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "NOM_JURIS_CON")

                    GIRO_EST.Text = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "GIRO")
                    RFC_EST.Text = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "RFC")
                    DOMICILIO_PROPIETARIO.Text = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "DOMICILIO_PROPIETARIO")
                    DOMICILIO_EST.Text = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "DOMICILIO")
                    COLONIA_ESTABLECIMIENTOS.SelectedItem = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "COLONIA")
                    'TextBoxCARGO.Text = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "IDENTIFICACION")
                    CP_EST.Text = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "CODIGO_POSTAL")
                    ID_PROPIETARIO.Text = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "IDENTIFICACION")
                    Dim CVE_JURISDICCION = oFunciones.obetenerDescripcion4(ESTABLECIMIENTO, "CVE_JURISDICCION")
                    ELEGIDOestablecimeinto = True
                    llenar_Datos_encargado()
                    ReDim oFunciones.ParametersX_Global(0)
                    oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_JURISDICCION", CVE_JURISDICCION)
                    oFunciones.Llenar_listbox("pCAT_VERIFICADORES_B", "CVE_VERIFICADOR", "NOMB", VERIFICADORES, oFunciones.ParametersX_Global)
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


    Private Sub VERIFICADORES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VERIFICADORES.SelectedIndexChanged
        If VERIFICADORES.SelectedIndex = -1 Then Exit Sub
        Dim validado As Boolean = True
        'If CONTROLVT Then
        If VERIFICADORES_GRID.RowCount = 0 Then
            validado = True
        Else
            For Each COLUM As DataGridViewRow In VERIFICADORES_GRID.Rows
                If COLUM.Item("CVE_VERIFICADOR").Value = oFunciones.obetenerDescripcion4(VERIFICADORES, "CVE_VERIFICADOR") Then
                    validado = False
                End If
            Next
        End If
        If validado Then
            VERIFICADORES_GRID.Rows.Add()
            Dim FILA As Integer = VERIFICADORES_GRID.Rows.Count - 1
            VERIFICADORES_GRID.Item("Nombre", FILA).Value = oFunciones.obetenerDescripcion4(VERIFICADORES, "NOMB")
            VERIFICADORES_GRID.Item("Jurisdiccion", FILA).Value = oFunciones.obetenerDescripcion4(VERIFICADORES, "JURISDICCION")
            VERIFICADORES_GRID.Item("CVE_VERIFICADOR", FILA).Value = oFunciones.obetenerDescripcion4(VERIFICADORES, "CVE_VERIFICADOR")
            VERIFICADORES_GRID.Item("Sexo", FILA).Value = oFunciones.obetenerDescripcion4(VERIFICADORES, "SEXO")
            VERIFICADORES_GRID.Item("Clave_Trabajador", FILA).Value = oFunciones.obetenerDescripcion4(VERIFICADORES, "CLAVE_TRABAJADOR")
        Else
            Wisej.Web.MessageBox.Show("ya existe el varificador en la tabla   ", "VALIDACIO DE VERIFICADOR", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub TablaVerifacadores_CellClick(sender As Object, e As Wisej.Web.DataGridViewCellEventArgs) Handles VERIFICADORES_GRID.CellClick
        If e.ColumnIndex = 0 Then
            If e.RowIndex <> -1 Then
                If (Wisej.Web.MessageBox.Show("¿Esta segur@ de eliminar el Verficador seleccionado?", "Eliminar", Wisej.Web.MessageBoxButtons.YesNo, Wisej.Web.MessageBoxIcon.Question) = DialogResult.Yes) Then
                    VERIFICADORES_GRID.Rows.Remove(VERIFICADORES_GRID.CurrentRow)
                End If
            End If


        ElseIf e.ColumnIndex = 1 Then
        End If
    End Sub


    Private Sub añadir_item(sender As Object, e As EventArgs) Handles Add_Muestras.Click
        Dim form = New Add_Muestra
        form.Show()
        AddHandler form.AÑADIR_ITEM.Click, AddressOf add_fila
    End Sub

    Private Sub add_fila(sender As Object, e As EventArgs)
        Dim form As Add_Muestra = sender.Parent.Parent
        If form._Validar = True Then
            Dim fecha As String
            If form.FECHA_CADUCIDAD.Value = Nothing Then
                fecha = "sin fecha de caducidad"
            Else
                fecha = form.FECHA_CADUCIDAD.Value
            End If
            If form.MARCA.Text.Length = 0 Then
                form.MARCA.Text = "no asignado"
            End If
            If form.LOTE.Text.Length = 0 Then
                form.LOTE.Text = "no asignado"
            End If
            If form.CLAVE_VS.Text.Length = 0 Then
                form.CLAVE_VS.Text = "no asignado"
            End If
            Add_Muestra_On_TABLA_MUESTRAS(form.TIPO_MUESTRA.SelectedValue, form.TIPO_ANALISIS.SelectedValue, form.DESCRIPCION.Text, form.CLAVE_VS.Text, form.LOTE.Text, form.MARCA.Text, fecha, form.CANTIDAD.Value)
            form.limpiar()
            form.AÑADIR_ITEM.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
        'Dim form = New Add_Muestra
        'form.Show()
        'AddHandler form.AÑADIR_ITEM.Click, AddressOf añadir_item
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As Wisej.Web.DataGridViewCellEventArgs) Handles MUESTRAS_GRID.CellClick
        If e.ColumnIndex = 0 Then
            If e.RowIndex <> -1 Then
                If (Wisej.Web.MessageBox.Show("¿Esta segur@ de eliminar la muestra seleccionada?", "Eliminar", Wisej.Web.MessageBoxButtons.YesNo, Wisej.Web.MessageBoxIcon.Question) = DialogResult.Yes) Then
                    MUESTRAS_GRID.Rows.Remove(MUESTRAS_GRID.CurrentRow)
                End If
            End If

        ElseIf e.ColumnIndex = 1 Then
        End If
    End Sub

    Private Sub AddObjetivoVerificacion_Click(sender As Object, e As EventArgs) Handles add_objetivo_alcance.Click
        Dim form = New Add_Objetivos_vb
        form.Visible = True
        AddHandler form.FormClosed, AddressOf llenarCombos
    End Sub




    Private Sub llenar_Datos_encargado()
        If PROPIETARIO_RESPONSABLE.Checked Then
            NOMBRE_RESPONSABLE.Enabled = False
            DOMICILIO_RESPONSABLE.Enabled = False
            ID_RESPONSABLE.Enabled = False
            CARGO_RESPONSABLE.Enabled = False
            If NOMBRE_PROPIETARIO.Text.Length = 0 Then
                Wisej.Web.MessageBox.Show("Debes seleccionar establecimiento", "Datos faltante", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
            End If
            NOMBRE_RESPONSABLE.Text = NOMBRE_PROPIETARIO.Text
            DOMICILIO_RESPONSABLE.Text = DOMICILIO_PROPIETARIO.Text
            ID_RESPONSABLE.Text = ID_PROPIETARIO.Text
            CARGO_RESPONSABLE.Text = "Jefe y/o Dueño"

        Else
            NOMBRE_RESPONSABLE.Enabled = True
            DOMICILIO_RESPONSABLE.Enabled = True
            ID_RESPONSABLE.Enabled = True
            CARGO_RESPONSABLE.Enabled = True
            NOMBRE_RESPONSABLE.Text = ""
            DOMICILIO_RESPONSABLE.Text = ""
            ID_RESPONSABLE.Text = ""
            CARGO_RESPONSABLE.Text = ""
        End If
    End Sub
    Private Sub LimpiarFormCompleto()
        oFunciones.LimpiarPanel(FASE1, Me.Tag)
        oFunciones.LimpiarPanel(FASE2, Me.Tag)
        oFunciones.LimpiarPanel(FASE3, Me.Tag)
        oFunciones.LimpiarPanel(FASE4, Me.Tag)
        oFunciones.LimpiarPanel(FASE5, Me.Tag)
        no.Checked = True
        TESTIGO1.Checked = False
        TESTIGO2.Checked = False
        Editar_Domicilio.Checked = False
        Editar_Propietario.Checked = False
        NO_MUESTRAS.Checked = True
        RadioButton13.Checked = True
        RadioButton11.Checked = True
        RadioButton9.Checked = True
        RadioButton7.Checked = True
        RadioButton5.Checked = True
        Anexar_Orden.Checked = False
    End Sub
    Private Function guardarActaA() As Integer
        Try
            ReDim oFunciones.ParametersX_Global(29)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@FOLIO_ORDEN", FOLIO_ORDEN.Text)
            oFunciones.ParametersX_Global(29) = New SqlClient.SqlParameter("@FECHA_ORDEN", FECHA_ORDEN.Value)
            oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@CVE_ESTABLECIMIENTO", ESTABLECIMIENTO.SelectedValue)
            oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@FECHA_VERIFICACION", FECHA_VERIFICACION.Value)
            oFunciones.ParametersX_Global(4) = New SqlClient.SqlParameter("@HORA_VERIFICACION", HORA.Value)
            oFunciones.ParametersX_Global(5) = New SqlClient.SqlParameter("@PROGRAMA", PROGRAMA.SelectedItem)
            If TESTIGO1.Checked Then
                oFunciones.ParametersX_Global(6) = New SqlClient.SqlParameter("@NOM_TESTIGO1", NOMBRE_TESTIGO1.Text)
                oFunciones.ParametersX_Global(8) = New SqlClient.SqlParameter("@DOM_TESTIGO1", DOM_TESTIGO1.Text)
                oFunciones.ParametersX_Global(10) = New SqlClient.SqlParameter("@ID_TESTIGO1", ID_TESTIGO1.SelectedItem)
            End If
            If TESTIGO2.Checked Then
                oFunciones.ParametersX_Global(7) = New SqlClient.SqlParameter("@NOM_TESTIGO2", NOMBRE_TESTIGO2.Text)
                oFunciones.ParametersX_Global(9) = New SqlClient.SqlParameter("@DOM_TESTIGO2", DOM_TESTIGO2.Text)
                oFunciones.ParametersX_Global(11) = New SqlClient.SqlParameter("@ID_TESTIGO2", ID_TESTIGO2.SelectedItem)
            End If
            oFunciones.ParametersX_Global(12) = New SqlClient.SqlParameter("@OBSERVACIONES_GENARALES", OBSERVACIONES_GENERALES.Text)
            oFunciones.ParametersX_Global(13) = New SqlClient.SqlParameter("@MEDIDAS_SEGURIAD", MEDIDAS_SEGURIDAD.Checked)
            If F_aseguramiento_si.Checked Then
                oFunciones.ParametersX_Global(14) = New SqlClient.SqlParameter("@FOLIO_ASEGURAMIENTO", FOLIO_ASEGURAMIENTO.Text)
            End If
            If F_reubicacion_si.Checked Then
                oFunciones.ParametersX_Global(16) = New SqlClient.SqlParameter("@FOLIO_REUBICACION", FOLIO_REUBICACION.Text)
            End If
            If F_suspencion_si.Checked Then
                oFunciones.ParametersX_Global(15) = New SqlClient.SqlParameter("@FOLIO_SUSPENCION", FOLIO_SUSPENCION.Text)
            End If
            If NO_MUESTRAS.Checked Then
                oFunciones.ParametersX_Global(26) = New SqlClient.SqlParameter("@OBSERVACIONES_MUESTRAS", OBSERVACIONES_MUESTRAS.Text)
            End If
            oFunciones.ParametersX_Global(17) = New SqlClient.SqlParameter("@DOCUMENTACION", ANEXO.Checked)
            oFunciones.ParametersX_Global(18) = New SqlClient.SqlParameter("@NUM_ANEXOS", NUM_ANEXOS.Text)
            oFunciones.ParametersX_Global(19) = New SqlClient.SqlParameter("@FOLIO_ACTA", FOLIO_ACTA_VERIFICACION.Text)
            oFunciones.ParametersX_Global(20) = New SqlClient.SqlParameter("@CVE_OPERADOR", Application.Session("CVE_OPERADOR"))
            oFunciones.ParametersX_Global(21) = New SqlClient.SqlParameter("@NOMBRE_RESPONSABLE", NOMBRE_RESPONSABLE.Text)
            oFunciones.ParametersX_Global(22) = New SqlClient.SqlParameter("@ID_RESPONSABLE", ID_RESPONSABLE.SelectedItem)
            oFunciones.ParametersX_Global(23) = New SqlClient.SqlParameter("@DOM_RESPONSABLE", DOMICILIO_RESPONSABLE.Text)
            oFunciones.ParametersX_Global(24) = New SqlClient.SqlParameter("@CARGO_RESPONSABLE", CARGO_RESPONSABLE.Text)
            oFunciones.ParametersX_Global(25) = New SqlClient.SqlParameter("@OBJETIVO_ALCANCE", TIPO_OBJETIVO.SelectedItem)

            oFunciones.ParametersX_Global(27) = New SqlClient.SqlParameter("@TIPO_ACTA", TIPO_ACTA.SelectedItem)
            oFunciones.ParametersX_Global(28) = New SqlClient.SqlParameter("@URL", "ARCHIVO DIGITAL NO ASIGNADO")

            cve_acta = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_ACTAS_VERIFICACION_G", "@PARAM", oFunciones.ParametersX_Global, False, SqlDbType.Int)
            If cve_acta = -99 Or cve_acta = Nothing Then
                Wisej.Web.MessageBox.Show("Error al guardar", "Guardar", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
            Else
                Wisej.Web.MessageBox.Show("Acta con folio : " & cve_acta & "ha sido almacenada correctamente", "Guardar", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Wisej.Web.MessageBox.Show("Error al guardar, ERROR: " & ex.Message, ":Guardar: Exception", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
        End Try
        Return cve_acta
    End Function

    Private Sub guardar_Verificadores()
        Dim result As Integer = Nothing
        For Each COLUM As DataGridViewRow In VERIFICADORES_GRID.Rows
            Try
                ReDim oFunciones.ParametersX_Global(1)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_VERIFICADOR", COLUM.Item("CVE_VERIFICADOR").Value)
                oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@CVE_ACTA", cve_acta)
                result = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_VERIFICADORES_ACTAS_G", "@PARAM", oFunciones.ParametersX_Global, False, SqlDbType.Int)
                If result = 200 Then
                    oFunciones.AlertBox("Verificador Vinculado a el acta: " & COLUM.Item("Nombre").Value, MessageBoxIcon.Information)
                Else
                    oFunciones.AlertBox("Error al vincular el verificador:  " & COLUM.Item("Nombre").Value & "con el acta", MessageBoxIcon.Information)
                End If
                result = Nothing
            Catch ex As Exception
                Wisej.Web.MessageBox.Show("Error al guardar, ERROR: " & ex.Message, "Guardar  :Exception:", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
            End Try

        Next
    End Sub
    Private Sub guardar_muestras()
        Dim result As Integer = Nothing
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
                result = Nothing
            Catch ex As Exception
                Wisej.Web.MessageBox.Show("Error al guardar, ERROR: " & ex.Message, "Guardar  :Exception:", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
            End Try
        Next

    End Sub



    Private Sub guardar_todo()
        If validar_todo() Then
            guardarActaA()
            If cve_acta = -99 Or cve_acta = Nothing Then ' SI NO SE GUARDA EL ACTA O DEVUELVE CODIGO DE ERROR ENTONCES NO SE EJECUTA LOS SUB DE GUARDAR VERIFICADORES NI MUESTRAS
                oFunciones.AlertBox("Error al obtene el CVE_ACTA", MessageBoxIcon.Information)
            Else
                guardar_Verificadores()
                If NO_MUESTRAS.Checked Then
                Else
                    guardar_muestras()
                End If
            End If
        Else
            oFunciones.AlertBox("verifique que todos los campos nesesarios esten llenos  ", MessageBoxIcon.Information)
        End If


    End Sub
    ' METODA PRA CREAR LAS PREGUNTAS DINAMICAS RELENADAS POR BASE DE DATOS
    'NO BORRAR-----------------------------------------------------

    'Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
    '    For i As Integer = 0 To 10
    '        Dim panel As New Panel
    '        With panel
    '            .AutoSize = False

    '            .Height = 200

    '            .Visible = True
    '            .ShowHeader = True
    '            .Text = "panel " & i
    '            .Dock = DockStyle.Top
    '            .BorderStyle = BorderStyle.Solid
    '            Dim label As New Label
    '            With label
    '                .Text = "pregunta  " & i
    '                .AutoSize = True
    '                .Visible = True

    '                .Location = New Drawing.Point(20, 10)
    '            End With
    '            Dim textbox As New TextBox
    '            With textbox
    '                .Watermark = "aqui va la respuesta"
    '                .AutoSize = False
    '                .Visible = True
    '                .Height = 100
    '                .Width = 700
    '                .Location = New Drawing.Point(20, 50)
    '            End With
    '            panel.Controls.Add(label)
    '            panel.Controls.Add(textbox)
    '        End With

    '        Panel5.Controls.Add(panel)
    '    Next
    'End Sub








    'eventos dentro del formulario autorrelleno, complementos y habilitacion de componentes
    '----------------------------------------------------------------------------------------------------------
    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles F_aseguramiento_si.CheckedChanged
        If F_aseguramiento_si.Checked Then
            F_aseguramiento_si.Enabled = False
        Else
            F_aseguramiento_si.Enabled = True
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles F_suspencion_si.CheckedChanged
        If F_suspencion_si.Checked Then
            FOLIO_SUSPENCION.Enabled = False
        Else
            FOLIO_SUSPENCION.Enabled = True
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles F_reubicacion_si.CheckedChanged
        If F_reubicacion_si.Checked Then
            FOLIO_REUBICACION.Enabled = False
        Else
            FOLIO_REUBICACION.Enabled = True


        End If
    End Sub


    Private Sub TESTIGO1_CheckedChanged_1(sender As Object, e As EventArgs) Handles TESTIGO1.CheckedChanged
        If TESTIGO1.Checked Then
            NOMBRE_TESTIGO1.Enabled = True
            DOM_TESTIGO1.Enabled = True
            ID_TESTIGO1.Enabled = True
        Else
            NOMBRE_TESTIGO1.Enabled = False
            DOM_TESTIGO1.Enabled = False
            ID_TESTIGO1.Enabled = False
        End If

    End Sub

    Private Sub TESTIGO2_CheckedChanged_1(sender As Object, e As EventArgs) Handles TESTIGO2.CheckedChanged
        If TESTIGO2.Checked Then
            NOMBRE_TESTIGO2.Enabled = True
            DOM_TESTIGO2.Enabled = True
            ID_TESTIGO2.Enabled = True
        Else
            NOMBRE_TESTIGO2.Enabled = False
            DOM_TESTIGO2.Enabled = False
            ID_TESTIGO2.Enabled = False
        End If


    End Sub

    Private Sub ANEXO_CheckedChanged(sender As Object, e As EventArgs) Handles ANEXO.CheckedChanged
        If ANEXO.Checked Then
            NUM_ANEXOS.Enabled = True
        Else
            NUM_ANEXOS.Enabled = False
        End If
    End Sub

    Private Sub habilitar_muestras_muestrasgrid(sender As Object, e As EventArgs) Handles ADD_MUESTRAS_TABLA.CheckedChanged
        If ADD_MUESTRAS_TABLA.Checked Then
            Add_Muestras.Enabled = True
            MUESTRAS_GRID.Enabled = True
            OBSERVACIONES_MUESTRAS.Enabled = True

        Else
            Add_Muestras.Enabled = False
            MUESTRAS_GRID.Enabled = False
            OBSERVACIONES_MUESTRAS.Enabled = False
        End If
    End Sub

    Private Sub Anexar_Orden_CheckedChanged(sender As Object, e As EventArgs) Handles Anexar_Orden.CheckedChanged
        If Anexar_Orden.Checked Then
            FOLIO_ORDEN.Enabled = True
            FECHA_ORDEN.Enabled = True
        Else
            FOLIO_ORDEN.Enabled = False
            FECHA_ORDEN.Enabled = False
        End If
    End Sub



    Private Sub HABILITAR_PROPIETARIO_COMO_RESPONSABLE(sender As Object, e As EventArgs) Handles PROPIETARIO_RESPONSABLE.CheckedChanged
        If PROPIETARIO_RESPONSABLE.Checked Then
            NOMBRE_RESPONSABLE.Enabled = False
            DOMICILIO_RESPONSABLE.Enabled = False
            ID_RESPONSABLE.Enabled = False
            CARGO_RESPONSABLE.Enabled = False
            If NOMBRE_PROPIETARIO.Text.Length = 0 Then
                Wisej.Web.MessageBox.Show("Debes seleccionar establecimiento", "Datos faltante", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
            End If
            NOMBRE_RESPONSABLE.Text = NOMBRE_PROPIETARIO.Text
            DOMICILIO_RESPONSABLE.Text = DOMICILIO_PROPIETARIO.Text
            ID_RESPONSABLE.Text = ID_PROPIETARIO.Text
            CARGO_RESPONSABLE.Text = "Jefe y/o Dueño"

        Else
            NOMBRE_RESPONSABLE.Enabled = True
            DOMICILIO_RESPONSABLE.Enabled = True
            ID_RESPONSABLE.Enabled = True
            CARGO_RESPONSABLE.Enabled = True
            NOMBRE_RESPONSABLE.Text = ""
            DOMICILIO_RESPONSABLE.Text = ""
            ID_RESPONSABLE.Text = ""
            CARGO_RESPONSABLE.Text = ""
        End If
    End Sub




    ' validaciones de formularios
    '----------------------------------------------------------------------------------------------


    Private Function validar_page1() As Boolean
        Dim E As Integer = 0

        If ESTABLECIMIENTO.SelectedIndex = -1 Then
            ErrorProvider1.SetError(JURISDICCION_EST, "no se ha seleccionado un establecimiento")
            ErrorProvider1.SetError(RAZON_SOCIAL_EST, "no se ha seleccionado un establecimiento")
            ErrorProvider1.SetError(GIRO_EST, "no se ha seleccionado un establecimiento")
            ErrorProvider1.SetError(COLONIA_ESTABLECIMIENTOS, "no se ha seleccionado un establecimiento")
            ErrorProvider1.SetError(DOMICILIO_EST, "no se ha seleccionado un establecimiento")
            ErrorProvider1.SetError(ID_PROPIETARIO, "no se ha seleccionado un establecimiento")
            ErrorProvider1.SetError(NOMBRE_PROPIETARIO, "no se ha seleccionado un establecimiento")
            ErrorProvider1.SetError(RFC_EST, "no se ha seleccionado un establecimiento")
            E = E + 1
        Else
            ErrorProvider1.SetError(JURISDICCION_EST, Nothing)
            ErrorProvider1.SetError(RAZON_SOCIAL_EST, Nothing)
            ErrorProvider1.SetError(GIRO_EST, Nothing)
            ErrorProvider1.SetError(COLONIA_ESTABLECIMIENTOS, Nothing)
            ErrorProvider1.SetError(DOMICILIO_EST, Nothing)
            ErrorProvider1.SetError(ID_PROPIETARIO, Nothing)
            ErrorProvider1.SetError(NOMBRE_PROPIETARIO, Nothing)
            ErrorProvider1.SetError(RFC_EST, Nothing)
        End If
        If TESTIGO1.Checked Then
            If NOMBRE_TESTIGO1.Text.Length <= 6 Then
                ErrorProvider1.SetError(NOMBRE_TESTIGO1, "nombre completo nesesario")
                E = E + 1
            Else
                ErrorProvider1.SetError(NOMBRE_TESTIGO1, Nothing)
            End If
            If DOM_TESTIGO1.Text.Length <= 20 Then
                ErrorProvider1.SetError(DOM_TESTIGO1, "domicilio testigo nesesario")
                E = E + 1
            Else
                ErrorProvider1.SetError(DOM_TESTIGO1, Nothing)
            End If
            If ID_TESTIGO1.SelectedIndex = -1 Then
                ErrorProvider1.SetError(ID_TESTIGO1, "selecciones indetificacion")
                E = E + 1
            Else
                ErrorProvider1.SetError(ID_TESTIGO1, Nothing)
            End If
        Else
            ErrorProvider1.SetError(NOMBRE_TESTIGO1, Nothing)
            ErrorProvider1.SetError(DOM_TESTIGO1, Nothing)
            ErrorProvider1.SetError(ID_TESTIGO1, Nothing)
        End If
        If TESTIGO2.Checked Then
            If NOMBRE_TESTIGO2.Text.Length <= 6 Then
                ErrorProvider1.SetError(NOMBRE_TESTIGO2, "nombre completo nesesario")
                E = E + 1
            Else
                ErrorProvider1.SetError(NOMBRE_TESTIGO2, Nothing)
            End If
            If DOM_TESTIGO2.Text.Length <= 20 Then
                ErrorProvider1.SetError(DOM_TESTIGO2, "domicilio testigo nesesario")
                E = E + 1
            Else
                ErrorProvider1.SetError(DOM_TESTIGO2, Nothing)
            End If
            If ID_TESTIGO2.SelectedIndex = -1 Then
                ErrorProvider1.SetError(ID_TESTIGO2, "selecciones indetificacion")
                E = E + 1
            Else
                ErrorProvider1.SetError(ID_TESTIGO2, Nothing)
            End If
        Else
            ErrorProvider1.SetError(NOMBRE_TESTIGO2, Nothing)
            ErrorProvider1.SetError(DOM_TESTIGO2, Nothing)
            ErrorProvider1.SetError(ID_TESTIGO2, Nothing)
        End If
        If no.Checked Then
            If NOMBRE_RESPONSABLE.Text.Length <= 6 Then
                ErrorProvider1.SetError(NOMBRE_RESPONSABLE, "nombre completo nesesario")
                E = E + 1
            Else
                ErrorProvider1.SetError(NOMBRE_RESPONSABLE, Nothing)
            End If
            If DOMICILIO_RESPONSABLE.Text.Length <= 20 Then
                ErrorProvider1.SetError(DOMICILIO_RESPONSABLE, "domicilio nulo o referencia no  muy especficica")
                E = E + 1
            Else
                ErrorProvider1.SetError(DOMICILIO_RESPONSABLE, Nothing)
            End If
            If ID_RESPONSABLE.SelectedIndex = -1 Then
                ErrorProvider1.SetError(ID_RESPONSABLE, "selecciones una identificacion")
                E = E + 1
            Else
                ErrorProvider1.SetError(ID_RESPONSABLE, Nothing)
            End If
            If CARGO_RESPONSABLE.Text.Length <= 1 Then
                ErrorProvider1.SetError(CARGO_RESPONSABLE, "indique el cargo que ejerce el responsable")
                E = E + 1
            Else
                ErrorProvider1.SetError(CARGO_RESPONSABLE, Nothing)
            End If
        Else
            ErrorProvider1.SetError(NOMBRE_RESPONSABLE, Nothing)
            ErrorProvider1.SetError(CARGO_RESPONSABLE, Nothing)
            ErrorProvider1.SetError(ID_RESPONSABLE, Nothing)
            ErrorProvider1.SetError(DOMICILIO_RESPONSABLE, Nothing)
        End If

        If E = 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function validar_page2() As Boolean
        Dim E As Integer = 0

        If VERIFICADORES_GRID.RowCount = 0 Then
            ErrorProvider1.SetError(VERIFICADORES_GRID, "No se ha seleccionado verificadores")
            E = E + 1
        Else
            ErrorProvider1.SetError(VERIFICADORES_GRID, Nothing)
        End If
        If ADD_MUESTRAS_TABLA.Checked Then
            If MUESTRAS_GRID.RowCount = 0 Then
                ErrorProvider1.SetError(MUESTRAS_GRID, "No se ha seleccionado verificadores")
                E = E + 1
            Else
                ErrorProvider1.SetError(MUESTRAS_GRID, Nothing)
            End If

        End If

        If E = 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function validar_page3() As Boolean
        Dim E As Integer = 0
        If F_aseguramiento_si.Checked Then
            If FOLIO_ASEGURAMIENTO.Text.Length <= 5 Then
                ErrorProvider1.SetError(FOLIO_ASEGURAMIENTO, "si no tiene folio de aseguramiento, no seleccione la opcion")
                E = E + 1
            Else
                ErrorProvider1.SetError(FOLIO_ASEGURAMIENTO, Nothing)
            End If
        Else
            ErrorProvider1.SetError(FOLIO_ASEGURAMIENTO, Nothing)
        End If
        If F_reubicacion_si.Checked Then
            If FOLIO_REUBICACION.Text.Length <= 5 Then
                ErrorProvider1.SetError(FOLIO_REUBICACION, "si no tiene folio de reubicacion, no seleccione la opcion")
                E = E + 1
            Else
                ErrorProvider1.SetError(FOLIO_REUBICACION, Nothing)

            End If
        Else
            ErrorProvider1.SetError(FOLIO_REUBICACION, Nothing)
        End If
        If F_suspencion_si.Checked Then

            If FOLIO_SUSPENCION.Text.Length <= 5 Then
                ErrorProvider1.SetError(FOLIO_SUSPENCION, "si no tiene folio de suspencion, no seleccione la opcion")
                E = E + 1
            Else
                ErrorProvider1.SetError(FOLIO_SUSPENCION, Nothing)
            End If
        Else
            ErrorProvider1.SetError(FOLIO_SUSPENCION, Nothing)
        End If
        If TIPO_OBJETIVO.SelectedIndex = -1 Then
            ErrorProvider1.SetError(TIPO_OBJETIVO, "seleccione un tipo de objetivo")
            E = E + 1
        Else
            ErrorProvider1.SetError(TIPO_OBJETIVO, Nothing)

        End If
        If RESPONSABLE_ANALISIS.SelectedIndex = -1 Then
            ErrorProvider1.SetError(RESPONSABLE_ANALISIS, "seleccione a un responsable")
            E = E + 1
        Else
            ErrorProvider1.SetError(RESPONSABLE_ANALISIS, Nothing)
        End If
        If PROGRAMA.SelectedIndex = -1 Then
            ErrorProvider1.SetError(PROGRAMA, "seleccione un programa")
            E = E + 1
        Else
            ErrorProvider1.SetError(PROGRAMA, Nothing)
        End If


        If TIPO_ACTA.SelectedIndex = -1 Then
            ErrorProvider1.SetError(TIPO_ACTA, "seleccione tipo de acta")
            E = E + 1
        Else
            ErrorProvider1.SetError(TIPO_ACTA, Nothing)
        End If
        If Anexar_Orden.Checked Then
            If FOLIO_ORDEN.Text.Length <= 5 Then
                ErrorProvider1.SetError(FOLIO_ORDEN, "ha seleecionado 'asignar info de orden', debera llenar los datos nesesarios para dar de alta la orden en caso contrario no seleccionar la opcion")
                E = E + 1
            Else
                ErrorProvider1.SetError(FOLIO_ORDEN, Nothing)
            End If
            If FECHA_ORDEN.Value = Nothing Then
                ErrorProvider1.SetError(FECHA_ORDEN, "seleccione una fecha")
                E = E + 1
            Else
                ErrorProvider1.SetError(FECHA_ORDEN, Nothing)
            End If
        End If
        If FOLIO_ACTA_VERIFICACION.Text.Length <= 5 Then
            ErrorProvider1.SetError(FOLIO_ACTA_VERIFICACION, "folio nesesario para validar")
            E = E + 1
        Else
            ErrorProvider1.SetError(FOLIO_ACTA_VERIFICACION, Nothing)
        End If
        If FECHA_VERIFICACION.Value = Nothing Then
            ErrorProvider1.SetError(FECHA_VERIFICACION, "seleccione la fecha de verificacion")
            E = E + 1
        Else
            ErrorProvider1.SetError(FECHA_VERIFICACION, Nothing)
        End If
        If HORA.Value = Nothing Then
            ErrorProvider1.SetError(HORA, "ingresar la hora de la verificacion")
            E = E + 1
        Else
            ErrorProvider1.SetError(HORA, Nothing)
        End If
        If E = 0 Then
            Return True
        Else
            Return False

        End If
    End Function
    Public Function validar_todo() As Boolean
        If validar_page1() And validar_page2() And validar_page3() Then
            Return True
        Else
            Return False
        End If
    End Function



    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        If TabControl1.SelectedIndex = 1 Then
            If validar_page1() Then

                Exit Sub
            Else
                MessageBox.Show("Algunos campos son nesesarios, favor de validar los datos", "CAMPOS VACIOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Cancel = True
            End If
        End If
        If TabControl1.SelectedIndex = 2 Then
            If validar_page2() And validar_page1() Then
                Exit Sub
            Else
                MessageBox.Show("Algunos campos son nesesarios, favor de validar los datos", "CAMPOS VACIOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Cancel = True
            End If
        End If
        If TabControl1.SelectedIndex = 3 Then
            If validar_page3() And validar_page2() And validar_page1() Then
                Exit Sub
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        guardar_todo()

    End Sub
End Class
