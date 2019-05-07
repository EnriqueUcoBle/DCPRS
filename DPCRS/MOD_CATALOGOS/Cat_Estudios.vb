Imports Wisej.Web

Public Class Cat_Estudios
    Dim oFunciones As New dllData
    Dim filaActual As Integer = -1
    Dim tablaCargado As Boolean = False

    Private Sub Cat_Estudios_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Estudios"
        oFunciones.loadConfigDataGridView(DGVEstudios)
        oFunciones.ConfigurarBindingNavigator(BindingNavigator1, False, False, True, True)
        FiltroGrillaSax1.meDatagrid = DGVEstudios
        llenarCombos()
        cargarTabla()
        filaActual = -1
    End Sub

    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        If DGVEstudios.RowCount > 0 Then
            filaActual = DGVEstudios.CurrentRow.Index()
        End If

        Select Case e.Item.Text
            Case "Nuevo"
                limpiarFormulario()
            Case "Actualizar"
                cargarTabla()
                limpiarFormulario()
                recuperarEstado(True)
            Case "Guardar"
                guardar()
            Case "Salir"
                Me.Close()
        End Select
    End Sub

    Private Sub cargarTabla()
        tablaCargado = False

        Try
            Me.DataSet_pCAT_ESTUDIOS_B.pCAT_ESTUDIOS_B.Clear()
            Dim myDA = New SqlClient.SqlDataAdapter("pCAT_ESTUDIOS_B", oFunciones.sConexion)
            myDA.SelectCommand.Parameters.AddWithValue("@habilitado", RBHabilitado.Checked)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_pCAT_ESTUDIOS_B.pCAT_ESTUDIOS_B)
            myDA.Dispose()
            'oFunciones.AlternatingColors_Grilla(DGVEstudios)

            If DGVEstudios.RowCount > 0 Then
                DGVEstudios.CurrentRow.Selected = False
            End If
        Catch ex As Exception
            MessageBox.show("Error: " & ex.Message, "Cargar tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        tablaCargado = True
    End Sub

    Sub llenarCombos()
        Try
            ReDim oFunciones.ParametersX_Global(0)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@habilitado", 1)
            oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_TIPO_MUESTRAS_B", "CVE_TIPO_MUESTRA", "DESCRIPCIONX", CBSMuestra, oFunciones.ParametersX_Global)
        Catch ex As Exception
            MessageBox.show("Error: " & ex.Message, "Cargar listas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DGVScian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVEstudios.CellClick 'Click en celda
        'Primer celda (0) = Eliminar
        Try
            If DGVEstudios.RowCount > 0 Then
                filaActual = DGVEstudios.CurrentRow.Index()
            End If

            If e.RowIndex > -1 Then
                enviarDatos(e.RowIndex)

                If e.ColumnIndex = 0 Then
                    Dim result As MsgBoxResult =
                    MessageBox.Show(
                        "¿Está seguro de desactivar/activar esta clave?" & vbCrLf & "Clave : " & DGVEstudios.Item("DGVECLAVE", e.RowIndex).Value,
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

    Private Sub DGVScian_SelectionChanged(sender As Object, e As EventArgs) Handles DGVEstudios.SelectionChanged 'Seleccion cambiada
        If (filaActual <> -1 And filaActual < DGVEstudios.RowCount) And tablaCargado Then
            enviarDatos(DGVEstudios.CurrentRow.Index())
        End If
    End Sub

    Private Sub enviarDatos(fila As Integer) 'Enviar columnas de fila al formulario
        Try
            'If CBSMuestra.Count = 0 Then 'Se ha dado click en el boton x del combo (limpia el DataSource)
            '    llenarCombos()
            'End If

            If fila <> -1 And tablaCargado Then
                TXTClave.Text = DGVEstudios.Item("DGVECLAVE", fila).Value
                TXTEstudio.Text = DGVEstudios.Item("DGVEESTUDIO", fila).Value
                CBSMuestra.SelectedItem = DGVEstudios.Item("DGVEDESCRIPCIONY", fila).Value
            End If
        Catch ex As Exception
            MessageBox.show("Error: " & ex.Message, "Enviar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub guardar()
        Dim siGuardo As Boolean = False

        Try
            If oFunciones.ValidarGrupos(Panel1, ErrorProvider1) Then
                If DGVEstudios.RowCount > 0 Then
                    filaActual = DGVEstudios.CurrentRow.Index()
                End If

                ReDim oFunciones.ParametersX_Global(4)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_estudio", TXTClave.Text)
                oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@cve_tipo_muestra", CBSMuestra.SelectedValue)
                oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@descripcion", TXTEstudio.Text)
                oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@operador", "ADMIN") 'insertar variable de sesion de operador
                oFunciones.ParametersX_Global(4) = New SqlClient.SqlParameter("@habilitado", RBHabilitado.Checked)
                Dim parametro = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_ESTUDIOS_G", "@parametro", oFunciones.ParametersX_Global, False, SqlDbType.Int, 50)

                If parametro = TXTClave.Text Then 'Cuando es acualizacion de registro: compara valor devuelto con el del TextBox
                    siGuardo = True
                ElseIf parametro <> Nothing And parametro <> TXTClave.Text Then 'Cuando es nuevo: verifica si no es nulo el parametro y si es distinto del TexBox=0
                    siGuardo = True
                    filaActual = DGVEstudios.RowCount()
                ElseIf parametro = Nothing Then
                    MessageBox.show("Datos no guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                If siGuardo Then
                    cargarTabla()
                    recuperarEstado(True)
                    MessageBox.show("Datos guardados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.show("No pueden ir vacios los campos", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.show(ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'MessageBox.Show(ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Private Sub msgBoxHandler(ByVal sender As Object, ByVal e As EventArgs)
    Private Sub msgBoxHandler()
        Try
            Dim siElimino As Boolean = False

            ReDim oFunciones.ParametersX_Global(1)
                    oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_estudio", DGVEstudios.CurrentRow.Cells("DGVECLAVE").Value)
                    oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@habilitado", Not RBHabilitado.Checked)

                    If oFunciones.fGuardar_O_EliminarXProcedure("pCAT_ESTUDIOS_E", "@parametro", oFunciones.ParametersX_Global, False) Then
                        siElimino = True
                    End If

                    If siElimino Then
                        cargarTabla()
                        recuperarEstado(True)
                    Else
                        MessageBox.Show("Datos no eliminados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DGVEstudios_Click(sender As Object, e As EventArgs) Handles DGVEstudios.Click 'Click en la tabla
        If DGVEstudios.RowCount > 0 And filaActual = -1 Then
            filaActual = 0
        End If
    End Sub

    Private Sub recuperarEstado(Optional ByVal siEnviar As Boolean = False) 'Seleccionar filaactual despues de actualizar/guardar/eliminar
        With DGVEstudios
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
        oFunciones.LimpiarPanel(Panel1, Me.Tag)
        TXTClave.Text = "0"
    End Sub

    Private Sub RBHabilitado_CheckedChanged(sender As Object, e As EventArgs) Handles RBHabilitado.CheckedChanged
        limpiarFormulario()
        cargarTabla()
    End Sub

    Private Sub CBSMuestra_ToolClick(sender As Object, e As ToolClickEventArgs) Handles CBSMuestra.ToolClick
        If e.Tool.Name = "Borrar" Then
            CBSMuestra.SelectedIndex = -1
        End If
    End Sub
End Class
