﻿Imports Wisej.Web

Public Class Cat_Lotes_Expedientes
    Dim oFunciones As New dllData
    Dim filaActual As Integer = -1
    Dim tablaCargado As Boolean = False
    Dim Registrar_Lotes As Acta_Registro_Lotes
    Private Sub Cat_Lotes_Expedientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        oFunciones.loadConfigDataGridView(DGVExpedientes)
        oFunciones.ConfigurarBindingNavigator(BindingNavigator1, False, False, True, True)
        Me.DGVExpedientes.Sort(Me.DGVExpedientes.Columns("colCVE_LOTE"), ComponentModel.ListSortDirection.Ascending)
        FiltroGrillaSax1.meDatagrid = DGVExpedientes
        cargarTabla()
        subLlenarCombos()
        filaActual = -1

    End Sub

    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        If DGVExpedientes.RowCount > 0 Then
            filaActual = DGVExpedientes.CurrentRow.Index()
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
            Me.DataSet_pCat_Lotes_Expedientes_B.pACTAS_VERIFICACION_LOTES_B.Clear()
            Dim myDA = New SqlClient.SqlDataAdapter("pACTAS_VERIFICACION_LOTES_B", oFunciones.sConexion)
            'myDA.SelectCommand.Parameters.AddWithValue("@habilitado", RBHabilitado.Checked)
            myDA.SelectCommand.Parameters.AddWithValue("@cve_municipio", Application.Session.Item("CVE_MUNICIPIO"))
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_pCat_Lotes_Expedientes_B.pACTAS_VERIFICACION_LOTES_B)
            myDA.Dispose()
            'oFunciones.AlternatingColors_Grilla(DGVGiros)

            If DGVExpedientes.RowCount > 0 Then
                DGVExpedientes.CurrentRow.Selected = False
            End If
            tablaCargado = True
        Catch ex As Exception
            'log
        End Try

    End Sub
    Sub subLlenarCombos()
        Try
            ReDim oFunciones.ParametersX_Global(0)
            'oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@habilitado", 1)
            oFunciones.Llenar_CatalogosXprocedureYParams("pACTAS_VERIFICACION_LOTES_B", "CVE_LOTE", "CVE_ACTA", CBSEstablecimiento, oFunciones.ParametersX_Global)
            'oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_ESTABLECIMIENTOS_B", "CVE_ESTABLECIMIENTO", "RAZON_SOCIALX", CBSEstablecimiento, oFunciones.ParametersX_Global)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Cargar listas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub DGVScian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVExpedientes.CellClick 'Click en celda
        'Primer celda (0) = Eliminar
        Try
            If DGVExpedientes.RowCount > 0 Then
                filaActual = DGVExpedientes.CurrentRow.Index()
            End If

            If e.RowIndex > -1 Then
                enviarDatos(e.RowIndex)

                If e.ColumnIndex = 0 Then
                    Dim result As MsgBoxResult =
                    MessageBox.Show(
                        "¿Está seguro de desactivar/activar esta clave?" & vbCrLf & "Clave : " & DGVExpedientes.Item("DGVGCLAVE", e.RowIndex).Value,
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information
                    )

                    If (result = MsgBoxResult.Yes) Then
                        msgBoxHandler()
                    End If
                ElseIf e.ColumnIndex = 1 Then
                    'Enviar al Formulario para Editar y/o Imprimir el Reporte
                    Registrar_Lotes = New Acta_Registro_Lotes
                    Registrar_Lotes.sLote = DGVExpedientes.Item("colCVE_LOTE", e.RowIndex).Value
                    Registrar_Lotes.DTPFecha.Value = DGVExpedientes.Item("colFECHA", e.RowIndex).Value
                    Registrar_Lotes.LBLMunicipio.Text = "Jurisdicción: " & DGVExpedientes.Item("colMUNICIPIO", e.RowIndex).Value
                    Registrar_Lotes.Show()
                    AddHandler Registrar_Lotes.FormClosed, AddressOf handleCargar
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DGVExpedientes_SelectionChanged(sender As Object, e As EventArgs) Handles DGVExpedientes.SelectionChanged 'Seleccion cambiada
        If (filaActual <> -1 And filaActual < DGVExpedientes.RowCount) And tablaCargado Then
            enviarDatos(DGVExpedientes.CurrentRow.Index())
        End If
    End Sub

    Private Sub enviarDatos(fila As Integer) 'Enviar columnas de fila al formulario
        Try
            If fila <> -1 And tablaCargado Then
                TXTClave.Text = DGVExpedientes.Item("DGVGCLAVE", fila).Value
                CBSEstablecimiento.Text = DGVExpedientes.Item("colCVE_ESTABLECIMIENTO", fila).Value
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Enviar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub guardar()
        Dim siGuardo As Boolean = False

        Try
            If oFunciones.ValidarGrupos(Panel1, ErrorProvider1) Then
                If DGVExpedientes.RowCount > 0 Then
                    filaActual = DGVExpedientes.CurrentRow.Index()
                End If

                ReDim oFunciones.ParametersX_Global(2)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_giro", TXTClave.Text)
                oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@nombre", CBSEstablecimiento.SelectedValue)
                oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@habilitado", RBHabilitado.Checked)

                Dim parametro = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCat_Lotes_Expedientes_G", "@parametro", oFunciones.ParametersX_Global, False, SqlDbType.Int, 50)

                If parametro = TXTClave.Text Then 'Cuando es acualizacion de registro: compara valor devuelto con el del TextBox
                    siGuardo = True
                ElseIf parametro <> Nothing And parametro <> TXTClave.Text Then 'Cuando es nuevo: verifica si no es nulo el parametro y si es distinto del TexBox=0
                    siGuardo = True
                    filaActual = DGVExpedientes.RowCount()
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

    'Private Sub msgBoxHandler(ByVal sender As Object, ByVal e As EventArgs) 'Callback de messagebox eliminar
    Private Sub msgBoxHandler() 'Callback de messagebox eliminar
        Try

            ReDim oFunciones.ParametersX_Global(1)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_lote", DGVExpedientes.CurrentRow.Cells("colCVE_LOTE").Value)
            oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@num_consecutivo", DGVExpedientes.CurrentRow.Cells("colNUM_CONSECUTIVO").Value)

            If oFunciones.fGuardar_O_EliminarXProcedure("pACTAS_VERIFICACION_LOTES_EXPEDIENTES_E", "@parametro", oFunciones.ParametersX_Global, False) Then
                cargarTabla()
                limpiarFormulario()
                recuperarEstado(False)
            Else
                MessageBox.Show("Datos no eliminados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DGVGiros_Click(sender As Object, e As EventArgs) Handles DGVExpedientes.Click 'Click en la tabla
        If DGVExpedientes.RowCount > 0 And filaActual = -1 Then
            filaActual = 0
        End If
    End Sub

    Private Sub recuperarEstado(Optional ByVal siEnviar As Boolean = False) 'Seleccionar filaactual despues de actualizar/guardar/eliminar
        With DGVExpedientes
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
    Private Sub handleCargar(ByVal sender As Object, ByVal e As System.EventArgs)
        cargarTabla()
        recuperarEstado(True)
    End Sub

    Private Sub limpiarFormulario()
        TXTClave.Text = "0"
        CBSEstablecimiento.SelectedIndex = -1
    End Sub

    Private Sub RBHabilitado_CheckedChanged(sender As Object, e As EventArgs) Handles RBHabilitado.CheckedChanged
        cargarTabla()
    End Sub

End Class

