Imports Wisej.Web

Public Class Acta_Capturar_Muestras
    Dim oFunciones As New dllData
    Public cve_acta As String
    Dim errores As String
    Private pdfAGuardar As String = ""
    Private urlArchivoPdf As String

    Private Sub Acta_Capturar_Muestras_Load(sender As Object, e As EventArgs) Handles Me.Load
        subLlenarCombos()
        SplitContainer1.SplitterDistance = 358

        Panel1.Width = 358
        oFunciones.ConfigurarBindingNavigator(Me.BindingNavigator1, False, False, False, False)
        oFunciones.ConfigurarBindingNavigator(Me.BindingNavigator2, True, True, False, False)
    End Sub

    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Text
            Case "Nuevo"

            Case "BUSCAR"
                Dim Actas_Verificacion As New Cat_Actas_Verificacion
                Actas_Verificacion.Show()
            Case "Salir"
                Me.Close()
        End Select
    End Sub
    Private Sub RibbonBar2_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar2.ItemClick
        Select Case e.Item.Text
            Case "Guardar"
                Guardar()
            Case "Actualizar"

        End Select
    End Sub
    Sub subLlenarCombos()
        Try
            ReDim oFunciones.ParametersX_Global(0)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@habilitado", 1)
            oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_ESTABLECIMIENTOS_B", "CVE_ESTABLECIMIENTO", "RAZON_SOCIAL", CBSestablecimiento, oFunciones.ParametersX_Global)
            ReDim oFunciones.ParametersX_Global(1)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@habilitado", 1)
            oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@ROLES", "'Verificador'")
            oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_OPERADORES_B", "CVE_OPERADOR", "NOMBRE", CBSverificadores, oFunciones.ParametersX_Global)
            ReDim oFunciones.ParametersX_Global(0)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@habilitado", 1)
            oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_TIPO_MUESTRAS_B", "CVE_TIPO_MUESTRA", "DESCRIPCIONX", CBSmuestra, oFunciones.ParametersX_Global)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Cargar listas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub Guardar()
        Try
            If oFunciones.ValidarPanel(Panel1, ErrorProvider1) Then
                ReDim oFunciones.ParametersX_Global(10)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_acta", cve_acta)
                oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@cve_establecimiento", CBSestablecimiento.SelectedValue)
                oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@fecha_modifico", Now.Date)
                oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@folio_acta", txtFolio.Text.ToUpper)
                oFunciones.ParametersX_Global(4) = New SqlClient.SqlParameter("@fecha_verificacion", cFechaVerificacion.Value.Date)
                If RBNtipo_muestras.Checked = True Then
                    oFunciones.ParametersX_Global(5) = New SqlClient.SqlParameter("@tipo", RBNtipo_muestras.Text)
                Else
                    oFunciones.ParametersX_Global(5) = New SqlClient.SqlParameter("@tipo", RBNtipo_verificacion.Text)
                End If
                If RBNprograma_estatal.Checked = True Then
                    oFunciones.ParametersX_Global(6) = New SqlClient.SqlParameter("@programa", RBNprograma_estatal.Text)
                Else
                    oFunciones.ParametersX_Global(6) = New SqlClient.SqlParameter("@programa", RBNprograma_fassc.Text)
                End If
                oFunciones.ParametersX_Global(7) = New SqlClient.SqlParameter("@fecha_muestra_recibida", cFecha_muestra_recibida.Value.Date)
                oFunciones.ParametersX_Global(8) = New SqlClient.SqlParameter("@fecha_reporte_LSP", cFecha_reporte_lsp.Value.Date)
                oFunciones.ParametersX_Global(9) = New SqlClient.SqlParameter("@cve_estudio", CBSestudio.SelectedValue)
                oFunciones.ParametersX_Global(10) = New SqlClient.SqlParameter("@estatus", "CAPTURA")

                cve_acta = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_ACTAS_VERIFICACION_G", "@parametro", oFunciones.ParametersX_Global, False, SqlDbType.VarChar, 50)

                If cve_acta <> Nothing Then
                    'Guardar verificadores
                    GuardarVerificadores()
                    MessageBox.Show("Datos guardados correctamente" & errores, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    'Error
                    MessageBox.Show("No se ha podido guardar los datos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("No pueden ir vacios los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.show(ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MessageBox.Show(ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub
    Private Sub btnOperadores_Click(sender As Object, e As EventArgs) Handles btnOperadores.Click
        If CBSverificadores.SelectedIndex <> -1 Then
            If cve_acta <> Nothing Then

            Else
                If DGVverificadores.RowCount > 0 Then
                    DGVverificadores.Rows.Add()
                    DGVverificadores.Item("clave", DGVverificadores.RowCount - 1).Value = CBSverificadores.SelectedValue
                    DGVverificadores.Item("nombre", DGVverificadores.RowCount - 1).Value = CBSverificadores.SelectedItem
                Else
                    DGVverificadores.Rows.Add()
                    DGVverificadores.Item("clave", 0).Value = CBSverificadores.SelectedValue
                    DGVverificadores.Item("nombre", 0).Value = CBSverificadores.SelectedItem
                End If
            End If
        End If
    End Sub
    Private Function GuardarVerificadores() As String
        'Guardar en la BD
        Dim sDevuelve As String
        Try
            For nContador As Integer = 0 To DGVverificadores.RowCount - 1

                ReDim oFunciones.ParametersX_Global(1)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_acta", cve_acta)
                oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@cve_verificador", DGVverificadores.Item("clave", nContador).Value)

                sDevuelve = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_VERIFICADORES_G", "@Parametro", oFunciones.ParametersX_Global, False, SqlDbType.VarChar, 50)
                If Not sDevuelve = cve_acta Then
                    If errores = "" Then
                        errores += vbCrLf & "Ocurrió un error con el nombre: " & vbCrLf & nContador & ": " & DGVverificadores.Item("nombre", nContador).Value
                    Else
                        errores += vbCrLf & nContador & ": " & DGVverificadores.Item("OPERADOR", nContador).Value
                    End If
                End If
            Next
            Return errores
        Catch ex As Exception
            MessageBox.show(ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MessageBox.Show(ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Function
    Private Sub DGVverificadores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVverificadores.CellClick
        Try
            If e.RowIndex <> -1 Then
                If e.ColumnIndex = 0 Then
                    If cve_acta <> Nothing Then
                        'Eliminar de la BD

                    Else
                        DGVverificadores.Rows.RemoveAt(e.RowIndex)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub RBNtipo_muestras_CheckedChanged(sender As Object, e As EventArgs) Handles RBNtipo_muestras.CheckedChanged
        If RBNtipo_muestras.Checked = True Then
            ExpandableGroupBox1.Visible = False
            ExpandableGroupBox2.Visible = True
        Else
            ExpandableGroupBox1.Visible = True
            ExpandableGroupBox2.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As UploadedEventArgs) Handles Button1.Click
        OpenFileDialog1_Closed(sender, e)
    End Sub
    Private Sub Button2_Click(sender As Object, e As UploadedEventArgs) Handles Button2.Click
        OpenFileDialog1_Closed(sender, e)
    End Sub

    Private Sub OpenFileDialog1_Closed(sender As Object, e As UploadedEventArgs)

        Dim objFileDialog As Upload = CType(sender, Upload)
        Dim mstrDirectory As String = ConfigurationManager.AppSettings("Fotografias").ToString

        If e.Files.Count > 0 Then
            Dim archivoPdf As HttpPostedFile = DirectCast(e.Files(0), HttpPostedFile)
            If archivoPdf.ContentLength > 0 Then
                If archivoPdf.FileName.ToUpper.EndsWith(".PDF") Then
                    'eliminarImagen(fotoTemporal)----------------ELIMINAR--------------------
                    Label13.Text = archivoPdf.FileName
                    pdfAGuardar = System.IO.Path.Combine(mstrDirectory, System.IO.Path.GetFileName(Application.Session("Cve_Operador") & "_" & archivoPdf.FileName))
                    urlArchivoPdf = System.IO.Path.GetFileName(Application.Session("Cve_Operador") & "_" & archivoPdf.FileName)
                    Dim consecutivo = 0
                    While (System.IO.File.Exists(urlArchivoPdf))
                        pdfAGuardar = System.IO.Path.GetFileName(archivoPdf.FileName) & "(" & consecutivo & ")"
                        urlArchivoPdf = System.IO.Path.Combine(mstrDirectory, pdfAGuardar)
                        consecutivo += 1
                    End While
                    archivoPdf.SaveAs(pdfAGuardar)
                    Button2.Text = pdfAGuardar
                    'Guardar la URL en BD
                    'MessageBox.Show(pdfAGuardar.ToString, "Archivo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                End If

            End If

        End If
    End Sub
    Private Sub CerrarDialog()

    End Sub

End Class

