Imports Wisej.Web
Imports System.Net

Public Class Cat_Claves_Scian
    Dim oFunciones As New dllData
    Dim filaActual As Integer = -1
    Dim tablaCargado As Boolean = False

    Private Sub Cat_Claves_Scian_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Claves SCIAN"
        oFunciones.loadConfigDataGridView(DGVScian)
        oFunciones.ConfigurarBindingNavigator(BindingNavigator1, False, False, True, True)
        FiltroGrillaSax1.meDatagrid = DGVScian
        cargarTabla()
        filaActual = -1
        GroupBox1.Visible = False
        RBNGUARDAR.Visible = False

    End Sub

    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        If DGVScian.RowCount > 0 Then
            filaActual = DGVScian.CurrentRow.Index()
        End If

        Select Case e.Item.Text
            Case "Nuevo"
                limpiarFormulario()
                GroupBox1.Visible = True
                RBNNUEVO.Visible = False
                RBNGUARDAR.Visible = True
            Case "Actualizar"
                cargarTabla()
                limpiarFormulario()
                recuperarEstado(True)
            Case "Guardar"
                guardar()
                RBNNUEVO.Visible = True
            Case "Exportar"
                Dim sUrl As String
                sUrl = ConfigurationManager.AppSettings("ArchivosPDF") '.ToString & "SCIAN_completo.pdf"
                ' oFunciones.ExportarPlantilla(Me, sUrl)
                'Dim u As String
                'Dim c = New System.Net.WebClient()
                'c.DownloadFile(sUrl, "SCIAN_completo.pdf")
            Case "Salir"
                Me.Close()
        End Select
    End Sub

    Private Sub cargarTabla()
        tablaCargado = False

        Try
            Me.DataSet_pCAT_CLAVES_SCIAN_B1.pCAT_CLAVES_SCIAN_B.Clear()
            Dim myDA = New SqlClient.SqlDataAdapter("pCAT_CLAVES_SCIAN_B", oFunciones.sConexion)
            myDA.SelectCommand.Parameters.AddWithValue("@habilitado", RBHabilitado.Checked)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_pCAT_CLAVES_SCIAN_B1.pCAT_CLAVES_SCIAN_B)
            myDA.Dispose()
            'oFunciones.AlternatingColors_Grilla(DGVScian)

            If DGVScian.RowCount > 0 Then
                DGVScian.CurrentRow.Selected = False
            End If

            tablaCargado = True
        Catch ex As Exception
            MessageBox.show("Error: " & ex.Message, "Cargar tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub DGVScian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVScian.CellClick 'Click en celda
        Try
            If DGVScian.RowCount > 0 Then
                filaActual = DGVScian.CurrentRow.Index()
            End If

            If e.RowIndex > -1 Then
                enviarDatos(e.RowIndex)

                If e.ColumnIndex = 0 Then
                    Dim result As MsgBoxResult =
                    MessageBox.Show(
                        "¿Esta seguro de desactivar/activar esta clave?" & vbCrLf & "Clave : " & DGVScian.Item("DGVCSSCIAN", e.RowIndex).Value,
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
            MessageBox.show(ex.Message, "Error en la tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DGVScian_SelectionChanged(sender As Object, e As EventArgs) Handles DGVScian.SelectionChanged 'Seleccion cambiada
        If (filaActual <> -1 And filaActual < DGVScian.RowCount) And tablaCargado Then
            enviarDatos(DGVScian.CurrentRow.Index())
        End If
    End Sub

    Private Sub enviarDatos(fila As Integer) 'Enviar columnas de fila al formulario
        Try
            If fila <> -1 And tablaCargado Then
                With DGVScian
                    TXTClave.Text = .Item("DGVCSCLAVE", fila).Value
                    TXTClaveScian.Text = .Item("DGVCSSCIAN", fila).Value
                    TXTArea.Text = .Item("DGVCSAREA", fila).Value
                    TXTDescripcion.Text = .Item("DGVCSDESCRIPCION", fila).Value
                    CHKEntidadFederativa.Checked = .Item("DGVCSENTIDAD", fila).Value
                    CHKCofepris.Checked = .Item("DGVCSCOFEPRIS", fila).Value
                    CHKRequiereLicencia.Checked = .Item("DGVCSLICENCIA", fila).Value
                End With
            End If
        Catch ex As Exception
            MessageBox.show("Error: " & ex.Message, "Enviar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub guardar()
        Dim siGuardo As Boolean = False

        Try
            If oFunciones.ValidarGrupos(GroupBox1, ErrorProvider1) Then
                If DGVScian.RowCount > 0 Then
                    filaActual = DGVScian.CurrentRow.Index()
                End If

                ReDim oFunciones.ParametersX_Global(7)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@clave", TXTClave.Text)
                oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@scian", TXTClaveScian.Text)
                oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@descripcion", TXTDescripcion.Text)
                oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@area", TXTArea.Text)
                oFunciones.ParametersX_Global(4) = New SqlClient.SqlParameter("@entidadesFederativas", CHKEntidadFederativa.Checked)
                oFunciones.ParametersX_Global(5) = New SqlClient.SqlParameter("@cofepris", CHKCofepris.Checked)
                oFunciones.ParametersX_Global(6) = New SqlClient.SqlParameter("@requiereLicencia", CHKRequiereLicencia.Checked)
                oFunciones.ParametersX_Global(7) = New SqlClient.SqlParameter("@habilitado", RBHabilitado.Checked)
                Dim parametro = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_CLAVES_SCIAN_G", "@parametro", oFunciones.ParametersX_Global, False, SqlDbType.Int, 50)

                If parametro = TXTClave.Text Then 'Cuando es acualizacion de registro: compara valor devuelto con el del TextBox
                    siGuardo = True
                ElseIf parametro <> Nothing And parametro <> TXTClave.Text Then 'Cuando es nuevo: verifica si no es nulo el parametro y si es distinto del TexBox=0
                    siGuardo = True
                    filaActual = DGVScian.RowCount()
                ElseIf parametro = Nothing Then
                    MessageBox.Show("Datos no guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                If siGuardo Then
                    cargarTabla()
                    recuperarEstado(True)
                    txtAviso.Visible = True
                    MessageBox.Show("Datos guardados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.show("No pueden ir vacios los campos", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.show("Error: " & vbCrLf & ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Private Sub msgBoxHandler(ByVal sender As Object, ByVal e As EventArgs) 'Callback de messagebox eliminar
    Private Sub msgBoxHandler() 'Callback de messagebox eliminar
        Try
            Dim siElimino As Boolean = False
            'Dim msgForm As Form = TryCast(sender, Form)
            'If msgForm IsNot Nothing Then

            '    If msgForm.DialogResult = Wisej.Web.DialogResult.Yes Then

            ReDim oFunciones.ParametersX_Global(1)
                    oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@clave", DGVScian.CurrentRow.Cells("DGVCSCLAVE").Value)
                    oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@habilitado", Not RBHabilitado.Checked)

                    If oFunciones.fGuardar_O_EliminarXProcedure("pCAT_CLAVES_SCIAN_E", "@parametro", oFunciones.ParametersX_Global, False) Then
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
            MessageBox.Show("Error: " & vbCrLf & ex.Message, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DGVScian_Click(sender As Object, e As EventArgs) Handles DGVScian.Click 'Click en la tabla
        If DGVScian.RowCount > 0 And filaActual = -1 Then
            filaActual = 0
        End If
    End Sub

    Private Sub recuperarEstado(Optional ByVal siEnviar As Boolean = False) 'Seleccionar filaactual despues de actualizar/guardar/eliminar
        With DGVScian
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

    Private Sub limpiarFormulario()
        oFunciones.LimpiarPanel(GroupBox1, Me.Tag)
        TXTClave.Text = "0"
        txtAviso.Visible = False
    End Sub

    Private Sub RBHabilitado_CheckedChanged(sender As Object, e As EventArgs) Handles RBHabilitado.CheckedChanged
        limpiarFormulario()
        cargarTabla()
    End Sub


End Class

