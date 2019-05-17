Imports Wisej.Web

Public Class Cat_Giros
    Dim oFunciones As New dllData
    Dim filaActual As Integer = -1
    Dim tablaCargado As Boolean = False

    Private Sub Cat_Giros_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Giros"
        oFunciones.loadConfigDataGridView(DGVGiros)
        oFunciones.ConfigurarBindingNavigator(BindingNavigator1, False, False, True, True)
        FiltroGrillaSax1.meDatagrid = DGVGiros
        cargarTabla()
        filaActual = -1
    End Sub

    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        If DGVGiros.RowCount > 0 Then
            filaActual = DGVGiros.CurrentRow.Index()
        End If

        Select Case e.Item.Text
            Case "Nuevo"
                limpiarFormulario()
                TXTGiro.Visible = True
            Case "Actualizar"
                cargarTabla()
                limpiarFormulario()
                recuperarEstado(True)
            Case "Guardar"
                guardar()
                TXTGiro.Visible = True
            Case "Salir"
                Close()
        End Select
    End Sub

    Private Sub cargarTabla()
        tablaCargado = False

        Try
            Me.DataSet_pCAT_GIROS_B.pCAT_GIROS_B.Clear()
            Dim myDA = New SqlClient.SqlDataAdapter("pCAT_GIROS_B", oFunciones.sConexion)
            myDA.SelectCommand.Parameters.AddWithValue("@habilitado", RBHabilitado.Checked)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_pCAT_GIROS_B.pCAT_GIROS_B)
            myDA.Dispose()
            'oFunciones.AlternatingColors_Grilla(DGVGiros)

            If DGVGiros.RowCount > 0 Then
                DGVGiros.CurrentRow.Selected = False
            End If
        Catch ex As Exception
            'log
        End Try

        tablaCargado = True
    End Sub


    Private Sub DGVScian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVGiros.CellClick 'Click en celda
        'Primer celda (0) = Eliminar
        Try
            If DGVGiros.RowCount > 0 Then
                filaActual = DGVGiros.CurrentRow.Index()
            End If

            If e.RowIndex > -1 Then
                enviarDatos(e.RowIndex)

                If e.ColumnIndex = 0 Then
                    Dim result As MsgBoxResult =
                    MessageBox.Show(
                        "¿Está seguro de desactivar/activar esta clave?" & vbCrLf & "Clave : " & DGVGiros.Item("DGVGCLAVE", e.RowIndex).Value,
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

    Private Sub DGVScian_SelectionChanged(sender As Object, e As EventArgs) Handles DGVGiros.SelectionChanged 'Seleccion cambiada
        If (filaActual <> -1 And filaActual < DGVGiros.RowCount) And tablaCargado Then
            enviarDatos(DGVGiros.CurrentRow.Index())
        End If
    End Sub

    Private Sub enviarDatos(fila As Integer) 'Enviar columnas de fila al formulario
        Try
            If fila <> -1 And tablaCargado Then
                TXTClave.Text = DGVGiros.Item("DGVGCLAVE", fila).Value
                TXTGiro.Text = DGVGiros.Item("DGVGGIRO", fila).Value
            End If
        Catch ex As Exception
            MessageBox.show("Error: " & ex.Message, "Enviar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub guardar()
        Dim siGuardo As Boolean = False

        Try
            If oFunciones.ValidarGrupos(Panel1, ErrorProvider1) Then
                If DGVGiros.RowCount > 0 Then
                    filaActual = DGVGiros.CurrentRow.Index()
                End If

                ReDim oFunciones.ParametersX_Global(2)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_giro", TXTClave.Text)
                oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@nombre", TXTGiro.Text)
                oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@habilitado", RBHabilitado.Checked)

                Dim parametro = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_GIROS_G", "@parametro", oFunciones.ParametersX_Global, False, SqlDbType.Int, 50)

                If parametro = TXTClave.Text Then 'Cuando es acualizacion de registro: compara valor devuelto con el del TextBox
                    siGuardo = True
                ElseIf parametro <> Nothing And parametro <> TXTClave.Text Then 'Cuando es nuevo: verifica si no es nulo el parametro y si es distinto del TexBox=0
                    siGuardo = True
                    filaActual = DGVGiros.RowCount()
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
                    oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_giro", DGVGiros.CurrentRow.Cells("DGVGCLAVE").Value)
                    oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@habilitado", Not RBHabilitado.Checked)

                    If oFunciones.fGuardar_O_EliminarXProcedure("pCAT_GIROS_E", "@parametro", oFunciones.ParametersX_Global, False) Then
                        siElimino = True
                    End If

                    If siElimino Then
                        cargarTabla()
                        limpiarFormulario()
                    Else
                        MessageBox.Show("Datos no eliminados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DGVGiros_Click(sender As Object, e As EventArgs) Handles DGVGiros.Click 'Click en la tabla
        If DGVGiros.RowCount > 0 And filaActual = -1 Then
            filaActual = 0
        End If
    End Sub

    Private Sub recuperarEstado(Optional ByVal siEnviar As Boolean = False) 'Seleccionar filaactual despues de actualizar/guardar/eliminar
        With DGVGiros
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
        TXTClave.Text = "0"
        TXTGiro.Text = ""
    End Sub

    Private Sub RBHabilitado_CheckedChanged(sender As Object, e As EventArgs) Handles RBHabilitado.CheckedChanged
        cargarTabla()
    End Sub

End Class

