Imports Wisej.Web
Imports Wisej.Web.Resources
Imports System.Drawing

Public Class Cat_Ordenes
    Dim oFunciones, oFunciones2 As New dllData
    Dim filaActual As Integer = -1
    Dim tablaCargado As Boolean = False
    Private pdfAGuardar As String = ""
    Private urlArchivoPdf As String

    Private Sub Cat_Ordenes_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargarcombo()

        Try
            oFunciones.loadConfigDataGridView(DGVOrdenes)
            oFunciones.ConfigurarBindingNavigator(BindingNavigator1, False, False, True, True)
            FiltroGrillaSax1.meDatagrid = DGVOrdenes
            cargarTabla()
            Me.DGVOrdenes.Sort(Me.DGVOrdenes.Columns("fecha"), ComponentModel.ListSortDirection.Descending)
            filaActual = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Cargar Tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        'Label2.ForeColor = ColorTranslator.FromHtml(".LabelColor")


    End Sub

    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        If DGVOrdenes.RowCount > 0 Then
            filaActual = DGVOrdenes.CurrentRow.Index()
        End If

        Select Case e.Item.Text
            Case "Nuevo"
                limpiarFormulario()
                Panel_NUEVO.Visible = True
                RBNGUARDAR.Visible = True
            Case "Actualizar"
                cargarTabla()
                limpiarFormulario()
                recuperarEstado(True)
            Case "Guardar"
                guardar()
                Panel_NUEVO.Visible = False
                RBNGUARDAR.Visible = False
            Case "Salir"
                Me.Close()
        End Select
    End Sub
    Private Sub cargarcombo()
        Try
            oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_OPERADORES_B", "CVE_OPERADOR", "NOMBRE", CBemisor)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Cargar listas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub cargarTabla()
        tablaCargado = False

        Try
            Me.DataSet_pCAT_ORDENES_VERIFICACION_B.pCAT_ORDENES_VERIFICACION_B.Clear()
            Dim myDA = New SqlClient.SqlDataAdapter("pCAT_ORDENES_VERIFICACION_B", oFunciones.sConexion)
            If RBHabilitado.Checked Then
                myDA.SelectCommand.Parameters.AddWithValue("@Estatus_Omitir_F", "ELIMINADO")
            Else
                myDA.SelectCommand.Parameters.AddWithValue("@estatus", "ELIMINADO")
            End If
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_pCAT_ORDENES_VERIFICACION_B.pCAT_ORDENES_VERIFICACION_B)
            myDA.Dispose()
            'oFunciones.AlternatingColors_Grilla(DGVOrdenes)

            If DGVOrdenes.RowCount > 0 Then
                DGVOrdenes.CurrentRow.Selected = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Cargar Tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        tablaCargado = True
    End Sub
    Private Sub guardar()
        Dim siGuardo As Boolean = False

        Try
            If ValidarCampos() Then
                If DGVOrdenes.RowCount > 0 Then
                    filaActual = DGVOrdenes.CurrentRow.Index()
                End If

                ReDim oFunciones.ParametersX_Global(5)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@folio", TXTFolio.Text)
                oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@url_archivo", Button2.Text)
                oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@estatus", CBestatus.SelectedItem)
                oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@cve_operador", Application.Session("Cve_Operador"))
                oFunciones.ParametersX_Global(4) = New SqlClient.SqlParameter("@emision", CBemisor.Text)
                oFunciones.ParametersX_Global(5) = New SqlClient.SqlParameter("@emision_cargo", CBemisor.SelectedValue)

                Dim parametro = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_ORDENES_VERIFICACION_G", "@parametro", oFunciones.ParametersX_Global, False, SqlDbType.Int, 50)

                If parametro = TXTFolio.Text Then 'Cuando es acualizacion de registro: compara valor devuelto con el del TextBox
                    siGuardo = True
                ElseIf parametro <> Nothing And parametro <> TXTFolio.Text Then 'Cuando es nuevo: verifica si no es nulo el parametro y si es distinto del TexBox=0
                    siGuardo = True
                    filaActual = DGVOrdenes.RowCount()
                ElseIf parametro = Nothing Then
                    MessageBox.Show("Datos no guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                If siGuardo Then
                    cargarTabla()
                    recuperarEstado(True)
                    MessageBox.Show("Datos guardados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("No pueden ir vacios los campos", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DGVOrdenes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVOrdenes.CellClick 'Click en celda
        'Primer celda (0) = Eliminar
        Try
            If DGVOrdenes.RowCount > 0 Then
                filaActual = DGVOrdenes.CurrentRow.Index()
            End If

            If e.RowIndex > -1 Then
                enviarDatos(e.RowIndex)

                If e.ColumnIndex = 0 Then
                    Dim result As MsgBoxResult =
                    MessageBox.Show(
                        "¿Está seguro de desactivar/activar este registro?" & vbCrLf & "Folio : " & DGVOrdenes.Item("folio", e.RowIndex).Value,
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information)

                    If (result = MsgBoxResult.Yes) Then
                        msgBoxHandler()
                    End If

                End If
                If e.ColumnIndex = 3 Then
                    Dim sUrl As String
                    sUrl = ConfigurationManager.AppSettings("Ordenes").ToString & DGVOrdenes.Item("archivo", e.RowIndex).Value
                    oFunciones.ExportarPlantilla(Me, sUrl)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DGVScian_SelectionChanged(sender As Object, e As EventArgs) Handles DGVOrdenes.SelectionChanged 'Seleccion cambiada
        If (filaActual <> -1 And filaActual < DGVOrdenes.RowCount) And tablaCargado Then
            enviarDatos(DGVOrdenes.CurrentRow.Index())
        End If
    End Sub

    Private Sub enviarDatos(fila As Integer) 'Enviar columnas de fila al formulario
        Try
            If fila <> -1 And tablaCargado Then
                TXTFolio.Text = DGVOrdenes.Item("folio", fila).Value
                Button2.Text = DGVOrdenes.Item("archivo", fila).Value
                CBestatus.SelectedItem = DGVOrdenes.Item("estatus", fila).Value
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Enviar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Private Sub msgBoxHandler(ByVal sender As Object, ByVal e As EventArgs) 'Callback de messagebox eliminar
    Private Sub msgBoxHandler() 'Callback de messagebox eliminar
        Try
            Dim siElimino As Boolean = False
            'Dim msgForm As Form = TryCast(sender, Form)
            'If msgForm IsNot Nothing Then

            'If msgForm.DialogResult = Wisej.Web.DialogResult.Yes Then

            ReDim oFunciones.ParametersX_Global(5)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@folio", DGVOrdenes.CurrentRow.Cells("folio").Value)
            oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@url_archivo", DGVOrdenes.CurrentRow.Cells("archivo").Value)
            oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@estatus", "ELIMINADO")
            oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@cve_operador", DGVOrdenes.CurrentRow.Cells("Cargo").Value)
            oFunciones.ParametersX_Global(4) = New SqlClient.SqlParameter("@emision", DGVOrdenes.CurrentRow.Cells("colEMISION").Value)
            oFunciones.ParametersX_Global(5) = New SqlClient.SqlParameter("@emision_cargo", DGVOrdenes.CurrentRow.Cells("Cargo").Value)

            If oFunciones.fGuardar_O_EliminarXProcedure("pCAT_ORDENES_VERIFICACION_G", "@parametro", oFunciones.ParametersX_Global, False) Then

                cargarTabla()
                recuperarEstado(True)
                MessageBox.Show("Datos Eliminados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Datos no eliminados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DGVGiros_Click(sender As Object, e As EventArgs) Handles DGVOrdenes.Click 'Click en la tabla
        If DGVOrdenes.RowCount > 0 And filaActual = -1 Then
            filaActual = 0
        End If
    End Sub

    Private Sub recuperarEstado(Optional ByVal siEnviar As Boolean = False) 'Seleccionar filaactual despues de actualizar/guardar/eliminar
        With DGVOrdenes
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
    Private Function ValidarCampos() As Boolean
        ValidarCampos = True
        If TXTFolio.Text = "0" Or CBestatus.SelectedItem.ToString = Nothing Then
            ValidarCampos = False
        End If
    End Function
    Private Sub limpiarFormulario()
        TXTFolio.Text = "0"
        CBestatus.SelectedItem = Nothing
    End Sub

    Private Sub RBHabilitado_CheckedChanged(sender As Object, e As EventArgs) Handles RBHabilitado.CheckedChanged
        cargarTabla()
    End Sub

    Private Sub Upload1_Uploaded(sender As Object, e As UploadedEventArgs) Handles Button2.Uploaded
        Dim objFileDialog As Upload = CType(sender, Upload)
        Dim mstrDirectory As String = ConfigurationManager.AppSettings("Ordenes").ToString

        If e.Files.Count > 0 Then
            Dim archivoPDF As HttpPostedFile = DirectCast(e.Files(0), HttpPostedFile)
            If archivoPDF.ContentLength > 0 Then
                'If archivoPdf.PostedFileName.ToUpper.EndsWith(".PDF") Then
                pdfAGuardar = System.IO.Path.GetFileName(archivoPDF.FileName)
                urlArchivoPdf = System.IO.Path.Combine(Application.StartupPath, mstrDirectory, System.IO.Path.GetFileName(archivoPDF.FileName))
                Dim consecutivo = 0
                While (System.IO.File.Exists(urlArchivoPdf))
                    pdfAGuardar = System.IO.Path.GetFileNameWithoutExtension(archivoPDF.FileName) & "(" & consecutivo & ")" & System.IO.Path.GetExtension(archivoPDF.FileName)
                    urlArchivoPdf = System.IO.Path.Combine(Application.StartupPath, mstrDirectory, pdfAGuardar)
                    consecutivo += 1
                End While
                Try
                    archivoPDF.SaveAs(urlArchivoPdf)
                    Button2.Text = pdfAGuardar
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Cargar archivo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
        End If
    End Sub

    Private Sub RBDesactivado_CheckedChanged(sender As Object, e As EventArgs) Handles RBDesactivado.CheckedChanged
        cargarTabla()
    End Sub

    Private Sub Panel_NUEVO_PanelCollapsed(sender As Object, e As EventArgs) Handles Panel_NUEVO.PanelCollapsed

    End Sub

    Private Sub DGVOrdenes_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVOrdenes.CellFormatting
        Dim sEstatus, sEstatus_color As String
        Dim sPath As String = Application.StartupPath & "\Resources\Images\"
        If e.RowIndex <> -1 And e.ColumnIndex <> -1 Then
            If Me.DGVOrdenes.Columns(e.ColumnIndex).Name = "estatus_img" Then
                sEstatus = DGVOrdenes.Rows(e.RowIndex).Cells("estatus").Value
                Select Case sEstatus
                    Case "PENDIENTE"
                        'e.Value = Image.FromFile(sPath & "ES-PENDIENTE.png")
                        e.CellStyle.BackColor = ColorTranslator.FromHtml("#FF4444")
                        'e.Value = New ImageResourceHandle("E_EDICION.png")
                    Case "CAPTURADO"
                        'e.Value = Image.FromFile(sPath & "ES-CAPTURADO.png")
                        e.CellStyle.BackColor = ColorTranslator.FromHtml("#00C851")
                    Case "ELIMINADO"
                        e.Value = Image.FromFile(sPath & "E_CANCELADO.png")
                    Case "NOTHING"
                        'e.Value = Image.FromFile(sPath & "ES-NOTHING.png")
                        e.CellStyle.BackColor = ColorTranslator.FromHtml("#E67E22")
                End Select
            End If

            If Me.DGVOrdenes.Columns(e.ColumnIndex).Name = "estatus" Then
                sEstatus_color = DGVOrdenes.Rows(e.RowIndex).Cells("estatus").Value
                Select Case sEstatus_color
                    Case "PENDIENTE"
                        e.CellStyle.ForeColor = ColorTranslator.FromHtml("#FF4444")
                        e.CellStyle.Font = New Font(DGVOrdenes.Font, FontStyle.Bold)
                    Case "CAPTURADO"
                        e.CellStyle.ForeColor = ColorTranslator.FromHtml("#00C851") '2ecc71
                        e.CellStyle.Font = New Font(DGVOrdenes.Font, FontStyle.Bold)
                    'Case "ELIMINADO"
                    '    e.Value = New ImageResourceHandle("E_CANCELADO.png")
                    Case "NOTHING"
                        e.CellStyle.ForeColor = ColorTranslator.FromHtml("#E67E22")
                        e.CellStyle.Font = New Font(DGVOrdenes.Font, FontStyle.Bold)

                End Select
            End If
        End If
    End Sub
End Class

