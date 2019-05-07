Imports Wisej.Web.Ext.RibbonBar

Imports Wisej.Web

Public Class Cat_Estados
    Dim oFunciones As New dllData
    Dim filaActual As Integer = -1
    Dim tablaCargado As Boolean = False

    Private Sub Cat_Giros_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Entidades Federativas"
        'oFunciones.loadConfigDataGridView(DGVEstados)
        oFunciones.ConfigurarBindingNavigator(BindingNavigator1, False, False, True, True)
        FiltroGrillaSax1.meDatagrid = DGVEstados
        cargarTabla()
        filaActual = -1
    End Sub

    Private Sub RibbonBar1_ButtonClick(sender As Object, e As RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        If DGVEstados.RowCount > 0 Then
            filaActual = DGVEstados.CurrentRow.Index()
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
                Close()
        End Select
    End Sub

    Private Sub cargarTabla()
        tablaCargado = False

        Try
            Me.DataSet_pCAT_ESTADOS_B.pCAT_ESTADOS_B.Clear()
            Dim myDA = New SqlClient.SqlDataAdapter("pCAT_ESTADOS_B", oFunciones.sConexion)
            myDA.SelectCommand.Parameters.AddWithValue("@habilitado", RBHabilitado.Checked)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_pCAT_ESTADOS_B.pCAT_ESTADOS_B)
            myDA.Dispose()
            ''oFunciones.AlternatingColors_Grilla(DGVEstados)

            If DGVEstados.RowCount > 0 Then
                DGVEstados.CurrentRow.Selected = False
            End If
        Catch ex As Exception
            'MessageBox.Show("Error: " & ex.Message, "Cargar tabla", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        tablaCargado = True
    End Sub

    Private Sub DGVScian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVEstados.CellClick 'Click en celda
        'Primer celda (0) = Eliminar
        If DGVEstados.RowCount > 0 Then
            filaActual = DGVEstados.CurrentRow.Index()
        End If

        If e.RowIndex > -1 Then
            enviarDatos(e.RowIndex)

            If e.ColumnIndex = 0 Then
                MessageBox.Show(
                    "¿Está seguro de desactivar/activar este registro?" & vbCrLf & "Estado: " & DGVEstados.Item("DGVEDOESTADO", e.RowIndex).Value,
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information)
                'AddressOf msgBoxHandler

            End If
        End If
    End Sub

    Private Sub DGVScian_SelectionChanged(sender As Object, e As EventArgs) Handles DGVEstados.SelectionChanged 'Seleccion cambiada
        If (filaActual <> -1 And filaActual < DGVEstados.RowCount) And tablaCargado Then
            enviarDatos(DGVEstados.CurrentRow.Index())
        End If
    End Sub

    Private Sub enviarDatos(fila As Integer) 'Enviar columnas de fila al formulario
        If fila <> -1 And tablaCargado Then
            Try
                TXTClave.Text = DGVEstados.Item("DGVEDOCLAVE", fila).Value
                TXTEstado.Text = DGVEstados.Item("DGVEDOESTADO", fila).Value
                TXTAgee.Text = DGVEstados.Item("DGVEDOAGEE", fila).Value
            Catch ex As Exception
                'MessageBox.show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub guardar()
        'Dim siGuardo As Boolean = False

        'Try
        '    'If oFunciones.ValidarGrupos(Panel1, ErrorProvider1) Then
        '    If DGVEstados.RowCount > 0 Then
        '            filaActual = DGVEstados.CurrentRow.Index()
        '        End If

        '        ReDim oFunciones.ParametersX_Global(3)
        '        oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@clave", TXTClave.Text)
        '        oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@descripcion", TXTEstado.Text.ToUpper)
        '        oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@agee", TXTAgee.Text)
        '        oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@habilitado", RBHabilitado.Checked)
        '        Dim parametro = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_ESTADOS_G", "@parametro", oFunciones.ParametersX_Global, False, SqlDbType.Int, 50)

        '        If parametro = TXTClave.Text Then 'Cuando es acualizacion de registro: compara valor devuelto con el del TextBox
        '            siGuardo = True
        '        ElseIf parametro <> Nothing And parametro <> TXTClave.Text Then 'Cuando es nuevo: verifica si no es nulo el parametro y si es distinto del TexBox=0
        '            siGuardo = True
        '            filaActual = DGVEstados.RowCount()
        '        ElseIf parametro = Nothing Then 'Error
        '            MessageBox.Show("Datos no guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '        End If

        '        If siGuardo Then
        '            cargarTabla()
        '            recuperarEstado(True)
        '            MessageBox.Show("Datos guardados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        End If

        '    'Else
        '''    '    MessageBox.Show("No pueden ir vacios los campos", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    'End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End Try
    End Sub

    Private Sub msgBoxHandler(ByVal sender As Object, ByVal e As EventArgs) 'Callback de messagebox eliminar
        Try
            Dim siElimino As Boolean = False
            Dim msgForm As Form = TryCast(sender, Form)
            If msgForm IsNot Nothing Then

                If msgForm.DialogResult = Wisej.Web.DialogResult.Yes Then

                    ReDim oFunciones.ParametersX_Global(1)
                    oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@clave", DGVEstados.CurrentRow.Cells("DGVEDOCLAVE").Value)
                    oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@habilitado", Not RBHabilitado.Checked)

                    If oFunciones.fGuardar_O_EliminarXProcedure("pCAT_ESTADOS_E", "@parametro", oFunciones.ParametersX_Global, False) Then
                        siElimino = True
                    End If

                    If siElimino Then
                        cargarTabla()
                        recuperarEstado(True)
                    Else
                        MessageBox.Show("Datos no eliminados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DGVEstados_Click(sender As Object, e As EventArgs) Handles DGVEstados.Click 'Click en la tabla
        If DGVEstados.RowCount > 0 And filaActual = -1 Then
            filaActual = 0
        End If
    End Sub

    Private Sub recuperarEstado(Optional ByVal siEnviar As Boolean = False) 'Seleccionar filaactual despues de actualizar/guardar/eliminar
        With DGVEstados
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
        'oFunciones.LimpiarPanel(Panel1, Nothing)
        TXTClave.Text = "0"
    End Sub

    Private Sub RBHabilitado_CheckedChanged(sender As Object, e As EventArgs) Handles RBHabilitado.CheckedChanged
        cargarTabla()
        limpiarFormulario()
    End Sub

    Private Sub BindingNavigator1_RefreshItems(sender As Object, e As EventArgs) Handles BindingNavigator1.RefreshItems

    End Sub
End Class
