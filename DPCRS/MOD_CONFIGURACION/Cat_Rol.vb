Imports Wisej.Web

Public Class Cat_Rol
    Dim oFunciones As New dllData
    Dim filaActual As Integer = -1
    Dim tablaCargado As Boolean = False

    Private Sub Cat_Rol_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Cat Rol"
        oFunciones.loadConfigDataGridView(DGVRoles)
        oFunciones.ConfigurarBindingNavigator(BindingNavigator1, False, False, True, True)
        FiltroGrillaSax1.meDatagrid = DGVRoles
        cargarTabla()
        filaActual = -1
    End Sub

    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        If DGVRoles.RowCount > 0 Then
            filaActual = DGVRoles.CurrentRow.Index()
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
            Me.DataSet_pCAT_ROL_B.pCAT_ROL_B.Clear()
            Dim myDA = New SqlClient.SqlDataAdapter("pCAT_ROL_B", oFunciones.sConexion)
            myDA.SelectCommand.Parameters.AddWithValue("@habilitado", RBHabilitado.Checked)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_pCAT_ROL_B.pCAT_ROL_B)
            myDA.Dispose()
            'oFunciones.AlternatingColors_Grilla(DGVRoles)

            If DGVRoles.RowCount > 0 Then
                DGVRoles.CurrentRow.Selected = False
            End If
        Catch ex As Exception
            MessageBox.show("Error: " & ex.Message, "Cargar tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        tablaCargado = True
    End Sub

    Private Sub DGVRoles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVRoles.CellClick 'Click en celda
        'Primer celda (0) = Eliminar
        Try
            If DGVRoles.RowCount > 0 Then
                filaActual = DGVRoles.CurrentRow.Index()
            End If

            If e.RowIndex > -1 Then
                enviarDatos(e.RowIndex)

                If e.ColumnIndex = 0 Then
                    Dim result As MsgBoxResult =
                    MessageBox.Show(
                        "¿Está seguro de desactivar/activar este registro?" & vbCrLf & "Rol: " & DGVRoles.Item("DGVRLROL", e.RowIndex).Value,
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

    Private Sub DGVRoles_SelectionChanged(sender As Object, e As EventArgs) Handles DGVRoles.SelectionChanged 'Seleccion cambiada
        If (filaActual <> -1 And filaActual < DGVRoles.RowCount) And tablaCargado Then
            enviarDatos(DGVRoles.CurrentRow.Index())
        End If
    End Sub

    Private Sub enviarDatos(fila As Integer) 'Enviar columnas de fila al formulario
        Try
            If fila <> -1 And tablaCargado Then
                With DGVRoles
                    TXTClave.Text = .Item("DGVRLCLAVE", fila).Value
                    TXTRol.Text = .Item("DGVRLROL", fila).Value
                End With
            End If
        Catch ex As Exception
            MessageBox.show("Error: " & ex.Message, "Enviar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub guardar()
        Dim siGuardo As Boolean = False

        Try
            If oFunciones.ValidarGrupos(Panel1, ErrorProvider1) Then
                If DGVRoles.RowCount > 0 Then
                    filaActual = DGVRoles.CurrentRow.Index()
                End If

                ReDim oFunciones.ParametersX_Global(2)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_rol", TXTClave.Text)
                oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@rol", TXTRol.Text)
                oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@habilitado", RBHabilitado.Checked)
                Dim parametro = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_ROL_G", "@parametro", oFunciones.ParametersX_Global, False, SqlDbType.VarChar, 50)

                If parametro = TXTClave.Text Then 'Cuando es actualizacion de registro: compara valor devuelto con el del TextBox
                    siGuardo = True
                ElseIf parametro <> Nothing And parametro <> TXTClave.Text Then 'Cuando es nuevo: verifica si no es nulo el parametro y si es distinto del TexBox=0
                    siGuardo = True
                    filaActual = DGVRoles.RowCount()
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
        End Try
    End Sub

    'Private Sub msgBoxHandler(ByVal sender As Object, ByVal e As EventArgs) 'Callback de messagebox eliminar
    Private Sub msgBoxHandler() 'Callback de messagebox eliminar
        Try
            Dim siElimino As Boolean = False

            ReDim oFunciones.ParametersX_Global(1)
                    oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_rol", DGVRoles.CurrentRow.Cells("DGVRLCLAVE").Value)
                    oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@habilitado", Not RBHabilitado.Checked)

                    If oFunciones.fGuardar_O_EliminarXProcedureS("pCAT_ROL_E", "@parametro", oFunciones.ParametersX_Global, False, False, SqlDbType.VarChar, 50) Then
                        siElimino = True
                    End If

                    If siElimino Then
                        cargarTabla()
                        recuperarEstado(True)
                    Else
                        MessageBox.Show("Datos no eliminados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DGVRoles_Click(sender As Object, e As EventArgs) Handles DGVRoles.Click 'Click en la tabla
        If DGVRoles.RowCount > 0 And filaActual = -1 Then
            filaActual = 0
        End If
    End Sub

    Private Sub recuperarEstado(Optional ByVal siEnviar As Boolean = False) 'Seleccionar filaactual despues de actualizar/guardar/eliminar
        With DGVRoles
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
        TXTClave.Text = "R"
    End Sub

    Private Sub RBHabilitado_CheckedChanged(sender As Object, e As EventArgs) Handles RBHabilitado.CheckedChanged
        limpiarFormulario()
        cargarTabla()
    End Sub
End Class

