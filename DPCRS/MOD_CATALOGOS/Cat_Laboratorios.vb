Imports Wisej.Web

Public Class Cat_Laboratorios
    Dim oFunciones As New dllData
    Dim filaActual As Integer = -1
    Dim tablaCargado As Boolean = False

    Private Sub Cat_Laboratorios_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Responsables de Laboratorios"
        oFunciones.loadConfigDataGridView(DGVLaboratorios)
        oFunciones.ConfigurarBindingNavigator(BindingNavigator1, False, False, True, True)
        FiltroGrillaSax1.meDatagrid = DGVLaboratorios
        cargarTabla()
        filaActual = -1
    End Sub

    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        If DGVLaboratorios.RowCount > 0 Then
            filaActual = DGVLaboratorios.CurrentRow.Index()
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
            Me.DataSet_pCAT_LABORATORIOS_B.pCAT_LABORATORIOS_B.Clear()
            Dim myDA = New SqlClient.SqlDataAdapter("pCAT_LABORATORIOS_B", oFunciones.sConexion)
            myDA.SelectCommand.Parameters.AddWithValue("@habilitado", RBHabilitado.Checked)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_pCAT_LABORATORIOS_B.pCAT_LABORATORIOS_B)
            myDA.Dispose()
            'oFunciones.AlternatingColors_Grilla(DGVLaboratorios)

            If DGVLaboratorios.RowCount > 0 Then
                DGVLaboratorios.CurrentRow.Selected = False
            End If
        Catch ex As Exception
            MessageBox.show("Error: " & ex.Message, "Cargar tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        tablaCargado = True
    End Sub


    Private Sub DGVLaboratorios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVLaboratorios.CellClick 'Click en celda
        'Primer celda (0) = Eliminar
        Try
            If DGVLaboratorios.RowCount > 0 Then
                filaActual = DGVLaboratorios.CurrentRow.Index()
            End If

            If e.RowIndex > -1 Then
                enviarDatos(e.RowIndex)

                If e.ColumnIndex = 0 Then
                    Dim result As MsgBoxResult =
                    MessageBox.Show(
                        "¿Está seguro de desactivar/activar esta clave?" & vbCrLf & "Clave : " & DGVLaboratorios.Item("DGVLCLAVE", e.RowIndex).Value,
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

    Private Sub DGVLaboratorios_SelectionChanged(sender As Object, e As EventArgs) Handles DGVLaboratorios.SelectionChanged 'Seleccion cambiada
        If (filaActual <> -1 And filaActual < DGVLaboratorios.RowCount) And tablaCargado Then
            enviarDatos(DGVLaboratorios.CurrentRow.Index())
        End If
    End Sub

    Private Sub enviarDatos(fila As Integer) 'Enviar columnas de fila al formulario
        Try
            If fila <> -1 And tablaCargado Then
                TXTClave.Text = DGVLaboratorios.Item("DGVLCLAVE", fila).Value
                TXTLaboratorio.Text = DGVLaboratorios.Item("DGVLLABORATORIO", fila).Value
                TXTResponsable.Text = DGVLaboratorios.Item("DGVLRESPONSABLE", fila).Value
            End If
        Catch ex As Exception
            MessageBox.show("Error: " & ex.Message, "Enviar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub



    Private Sub guardar()
        Dim siGuardo As Boolean = False

        Try
            If oFunciones.ValidarGrupos(Panel1, ErrorProvider1) Then
                If DGVLaboratorios.RowCount > 0 Then
                    filaActual = DGVLaboratorios.CurrentRow.Index()
                End If

                ReDim oFunciones.ParametersX_Global(3)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_laboratorio", TXTClave.Text)
                oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@laboratorio", TXTLaboratorio.Text)
                oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@responsable", TXTResponsable.Text)
                oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@habilitado", RBHabilitado.Checked)
                Dim parametro = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_LABORATORIOS_G", "@parametro", oFunciones.ParametersX_Global, False, SqlDbType.Int, 50)

                If parametro = TXTClave.Text Then 'Cuando es acualizacion de registro: compara valor devuelto con el del TextBox
                    siGuardo = True
                ElseIf parametro <> Nothing And parametro <> TXTClave.Text Then 'Cuando es nuevo: verifica si no es nulo el parametro y si es distinto del TexBox=0
                    siGuardo = True
                    filaActual = DGVLaboratorios.RowCount()
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

    'Private Sub msgBoxHandler(ByVal sender As Object, ByVal e As EventArgs)
    Private Sub msgBoxHandler()
        Dim siElimino As Boolean = False

        ReDim oFunciones.ParametersX_Global(1)
        oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_laboratorio", DGVLaboratorios.CurrentRow.Cells("DGVLCLAVE").Value)
        oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@habilitado", Not RBHabilitado.Checked)

        If oFunciones.fGuardar_O_EliminarXProcedure("pCAT_LABORATORIOS_E", "@parametro", oFunciones.ParametersX_Global, False) Then
            siElimino = True
        End If

        If siElimino Then
            cargarTabla()
            recuperarEstado(True)
        Else
            MessageBox.Show("Datos no eliminados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DGVLaboratorios_Click(sender As Object, e As EventArgs) Handles DGVLaboratorios.Click 'Click en la tabla
        If DGVLaboratorios.RowCount > 0 And filaActual = -1 Then
            filaActual = 0
        End If
    End Sub

    Private Sub recuperarEstado(Optional ByVal siEnviar As Boolean = False) 'Seleccionar filaactual despues de actualizar/guardar/eliminar
        With DGVLaboratorios
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

End Class

