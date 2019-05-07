Imports Wisej.Web
Imports System.Threading

Public Class Cat_operadores
    Dim oFunciones As New dllData
    Private imagenAGuardar As String = "User.png"
    Private fotoTemporal As String = ""
    Private urlImagenGuardada As String = ""
    Dim filaActual As Integer = -1
    Dim tablaCargado As Boolean = False
    Dim trd As Thread

    Private Sub Cat_operadores_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Operadores"
        oFunciones.loadConfigDataGridView(DGVOperadores)
        oFunciones.ConfigurarBindingNavigator(BDN, False, False, True, True)
        FiltroGrillaSax1.meDatagrid = DGVOperadores
        RBHabilitado.Checked = True
        chkHabilitado.Checked = True
        txtAviso.Visible = False
        cargarTabla()
        subLlenarCombos()
    End Sub

    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        If DGVOperadores.RowCount > 0 Then
            filaActual = DGVOperadores.CurrentRow.Index()
        End If

        Select Case e.Item.Text
            Case "Nuevo"
                'limpiarFormulario()
                oFunciones.LimpiarPanel(GroupBox1, Me.Tag)
                eliminarImagen(fotoTemporal)
            Case "Actualizar"
                cargarTabla()
                recuperarEstado(True)
            Case "Guardar"
                Guardar()
            Case "Salir"
                Close()
                eliminarImagen(fotoTemporal)
        End Select
    End Sub

    Private Sub cargarTabla()
        Try
            tablaCargado = False

            Me.DataSet_pCAT_OPERADORES_B.pCAT_OPERADORES_B.Clear()
            Dim myDA = New SqlClient.SqlDataAdapter("pCAT_OPERADORES_B", oFunciones.sConexion)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.SelectCommand.Parameters.AddWithValue("@habilitado", RBHabilitado.Checked)
            myDA.SelectCommand.Parameters.AddWithValue("@PassphraseEnteredByUser", oFunciones.sConstante_KEY)
            myDA.Fill(Me.DataSet_pCAT_OPERADORES_B.pCAT_OPERADORES_B)
            myDA.Dispose()
            'oFunciones.AlternatingColors_Grilla(DGVOperadores)

            If DGVOperadores.RowCount > 0 Then
                DGVOperadores.CurrentRow.Selected = False
            End If

            tablaCargado = True
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Inicio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub subLlenarCombos()
        Try
            ReDim oFunciones.ParametersX_Global(0)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@habilitado", 1)
            oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_ROL_B", "CVE_ROL", "ROL", CBSrol, oFunciones.ParametersX_Global)
            ReDim oFunciones.ParametersX_Global(0)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@habilitado", 1)
            oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_MUNICIPIOS_B", "CLAVE", "DESCRIPCIONX", CBSMunicipio, oFunciones.ParametersX_Global)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Cargar listas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub DGVOperadores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVOperadores.CellClick
        Try
            If DGVOperadores.RowCount > 0 Then
                filaActual = DGVOperadores.CurrentRow.Index()
            End If

            If e.RowIndex > -1 Then
                enviarDatos(e.RowIndex)

                If e.ColumnIndex = 0 Then
                    Dim result As MsgBoxResult =
                    MessageBox.Show(
                        "¿Está seguro de desactivar/activar esta clave?" & vbCrLf & "Clave : " & DGVOperadores.Item("cve_operador", e.RowIndex).Value,
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information
                    )
                    If (result = MsgBoxResult.Yes) Then
                        msgBoxHandler()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DGVOperadores_SelectionChanged(sender As Object, e As EventArgs) Handles DGVOperadores.SelectionChanged 'Seleccion cambiada
        If (filaActual <> -1 And filaActual < DGVOperadores.RowCount) And tablaCargado Then
            enviarDatos(DGVOperadores.CurrentRow.Index())
        End If
    End Sub

    Private Sub enviarDatos(fila As Integer)
        Try
            If fila <> -1 And tablaCargado Then

                CBSMunicipio.Text = DGVOperadores.Item("MUNICIPIOX", fila).Value
                CBSrol.Text = DGVOperadores.Item("rol", fila).Value
                fotoTemporal = ""
                txtClave.Text = DGVOperadores.Item("cve_operador", fila).Value
                txtContrasena.Text = DGVOperadores.Item("contrasena", fila).Value
                txtNombre.Text = DGVOperadores.Item("nombre", fila).Value
                chkHabilitado.Checked = DGVOperadores.Item("habilitado", fila).Value
                'PictureBox1.ImageSource = "Images.Fotografias." & DirectCast(BindingSource1.Current, DataRowView).Item("URL_FOTOGRAFIA").ToString
                fotoTemporal = DirectCast(BindingSource1.Current, DataRowView).Item("URL_FOTOGRAFIA").ToString
                If (fotoTemporal <> Nothing) Or ("" <> fotoTemporal) Then
                    'PictureBox1.ImageSource = "Images.Fotografias." & DirectCast(BindingSource1.Current, DataRowView).Item("URL_FOTOGRAFIA").ToString
                    PictureBox1.BackgroundImageSource = Nothing
                    PictureBox1.ImageSource = (ConfigurationManager.AppSettings("Fotografias").ToString & "\" & fotoTemporal)
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                    imagenAGuardar = fotoTemporal
                Else
                    PictureBox1.ImageSource = ConfigurationManager.AppSettings("Fotografias").ToString & "\" & "User.png"
                    imagenAGuardar = ""
                    fotoTemporal = ""
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Enviar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Sub Guardar()
        Dim siGuardo As Boolean = False
        Try
            If validado() Then
                If DGVOperadores.RowCount > 0 Then
                    filaActual = DGVOperadores.CurrentRow.Index()
                End If

                ReDim oFunciones.ParametersX_Global(7)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Operador", txtClave.Text.ToUpper)
                oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@Nombre", txtNombre.Text.ToUpper)
                oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@Contrasena", txtContrasena.Text.ToUpper)
                oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@CVE_ROL", CBSrol.SelectedValue)
                oFunciones.ParametersX_Global(4) = New SqlClient.SqlParameter("@habilitado", chkHabilitado.Checked)
                oFunciones.ParametersX_Global(5) = New SqlClient.SqlParameter("@url_fotografia", imagenAGuardar)
                oFunciones.ParametersX_Global(6) = New SqlClient.SqlParameter("@PassphraseEnteredByUser", oFunciones.sConstante_KEY)
                oFunciones.ParametersX_Global(7) = New SqlClient.SqlParameter("@cve_municipio", CBSMunicipio.SelectedValue)

                Dim parametro = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_OPERADORES_G", "@Parametro", oFunciones.ParametersX_Global, False, SqlDbType.VarChar, 50)

                If parametro = txtClave.Text Then 'Cuando es acualizacion de registro: compara valor devuelto con el del TextBox
                    siGuardo = True
                ElseIf parametro <> Nothing And parametro <> txtClave.Text Then 'Cuando es nuevo: verifica si no es nulo el parametro y si es distinto del TexBox=0
                    siGuardo = True
                    filaActual = DGVOperadores.RowCount()
                ElseIf parametro = Nothing Then
                    MessageBox.Show("Datos no guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                If siGuardo Then
                    fotoTemporal = ""
                    txtAviso.Visible = True
                    cargarTabla()
                    recuperarEstado(True)
                    oFunciones.AlertBox("Datos guardados correctamente", MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("No pueden ir vacios los campos", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & vbCrLf & ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub


    'Private Sub msgBoxHandler(ByVal sender As Object, ByVal e As EventArgs)
    Private Sub msgBoxHandler()
        Try
            Dim siElimino As Boolean = False
            'Dim msgForm As Form = TryCast(sender, Form)
            'If msgForm IsNot Nothing Then

            '    If msgForm.DialogResult = Wisej.Web.DialogResult.Yes Then

            ReDim oFunciones.ParametersX_Global(1)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_operador", DGVOperadores.CurrentRow.Cells("cve_operador").Value)
            oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@habilitado", Not RBHabilitado.Checked)

            If oFunciones.fGuardar_O_EliminarXProcedure("pCAT_OPERADORES_E", "@parametro", oFunciones.ParametersX_Global, False) Then
                siElimino = True
            End If

            If siElimino Then
                cargarTabla()
                recuperarEstado(True)
            Else
                MessageBox.Show("Datos no eliminados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            '    End If
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DGVOperadores_Click(sender As Object, e As EventArgs) Handles DGVOperadores.Click 'Click en la tabla
        If DGVOperadores.RowCount > 0 And filaActual = -1 Then
            filaActual = 0
        End If
    End Sub

    Private Sub recuperarEstado(Optional ByVal siEnviar As Boolean = False) 'Seleccionar filaactual despues de actualizar/guardar/eliminar
        With DGVOperadores
            If .RowCount > 0 Then

                If filaActual < 0 Then
                    filaActual = filaActual + 1
                ElseIf filaActual > .RowCount - 1 Then
                    filaActual = filaActual - 1
                End If

                .CurrentRow.Selected = False
                .Rows(filaActual).Selected = True
                .CurrentCell = .Rows(filaActual).Cells(0)

                If siEnviar Then
                    enviarDatos(filaActual)
                End If

            End If
        End With
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            System.IO.File.Delete(("Images.Fotografias." & fotoTemporal))
            System.IO.File.Delete(("Images.Fotografias." & DirectCast(BindingSource1.Current, DataRowView).Item("URL_FOTOGRAFIA").ToString))
            PictureBox1.ImageSource = Nothing
            imagenAGuardar = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Eliminar foto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub OpenFileDialog1_Closed(sender As Object, e As UploadedEventArgs) Handles BtnAnexar.Uploaded
        Dim objFileDialog As Upload = CType(sender, Upload)
        Dim mstrDirectory = ConfigurationManager.AppSettings("Fotografias").ToString
        If e.Files.Count > 0 Then
            Dim archivoFoto = DirectCast(e.Files(0), HttpPostedFile)
            If archivoFoto.ContentLength > 0 Then
                eliminarImagen(fotoTemporal) '----------------ELIMINAR--------------------
                imagenAGuardar = archivoFoto.FileName
                urlImagenGuardada = System.IO.Path.Combine(Application.StartupPath, mstrDirectory, imagenAGuardar) 'Guardo el directorio recursos + nombre imagen
                Dim consecutivo = 0
                While (System.IO.File.Exists(urlImagenGuardada))
                    imagenAGuardar = "(" & consecutivo & ")" & System.IO.Path.GetFileName(archivoFoto.FileName)
                    urlImagenGuardada = System.IO.Path.Combine(Application.StartupPath, mstrDirectory, imagenAGuardar)
                    consecutivo += 1
                End While
                fotoTemporal = urlImagenGuardada
                Try
                    archivoFoto.SaveAs(urlImagenGuardada)

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Cargar archivo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                PictureBox1.ImageSource = ("Images.Fotografias." & imagenAGuardar)
                ' PictureBoxAgremiado.BackgroundImageLayout = ImageLayout.Stretch
            End If
        End If
    End Sub
    Sub eliminarImagen(img As String)
        If (img <> "") Then
            If (System.IO.File.Exists(img)) Then
                System.IO.File.Delete(("Images.Fotografias." & img))
                fotoTemporal = ""
            End If
        End If
    End Sub
    Private Sub limpiarFormulario()
        txtClave.Text = "0"
        txtNombre.Text = ""
        txtContrasena.Text = ""
        chkHabilitado.Checked = True
        txtAviso.Visible = False
    End Sub
    Private Function validado() As Boolean
        validado = True
        If Trim(txtClave.Text) = Nothing Then
            ErrorProvider1.SetError(txtClave, "Escriba la clave del operador")
            validado = False
        Else
            Me.ErrorProvider1.SetError(txtClave, Nothing)
        End If
    End Function

    Private Sub CBxMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles CBxMostrar.CheckedChanged
        txtContrasena.InputType.Type = IIf(CBxMostrar.Checked, Wisej.Web.TextBoxType.Text, Wisej.Web.TextBoxType.Password)
    End Sub

    Private Sub rbnActivos_CheckedChanged(sender As Object, e As EventArgs) Handles RBHabilitado.CheckedChanged
        cargarTabla()
        limpiarFormulario()
    End Sub

    Private Sub txtAviso_VisibleChanged(sender As Object, e As EventArgs) Handles txtAviso.VisibleChanged
        If txtAviso.Visible = True Then
            trd = New Thread(AddressOf ocultarAviso)
            trd.IsBackground = True
            trd.Start()
        End If
    End Sub

    Private Sub ocultarAviso()
        Dim time As Integer = 0
        Dim limit As Integer = 3
        Do While time <= limit
            If time = limit Then
                txtAviso.Visible = False
                trd.Abort()
            End If
            Thread.Sleep(1000)
            time += 1
        Loop
    End Sub

    Private Sub CBSrol_ToolClick(sender As Object, e As ToolClickEventArgs) Handles CBSrol.ToolClick
        If e.Tool.Name = "Borrar" Then
            CBSrol.SelectedIndex = -1
        End If
    End Sub
    Private Sub CBSMunicipio_ToolClick(sender As Object, e As ToolClickEventArgs) Handles CBSMunicipio.ToolClick
        If e.Tool.Name = "Borrar" Then
            CBSMunicipio.SelectedIndex = -1
        End If
    End Sub
End Class

