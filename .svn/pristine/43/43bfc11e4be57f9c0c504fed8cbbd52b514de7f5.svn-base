Imports Wisej.Web

Public Class Cat_Municipios
    Dim oFunciones As New dllData
    Dim filaActual As Integer = -1
    Dim tablaCargado As Boolean = False

    Private Sub Cat_Municipios_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Municipios"
        oFunciones.loadConfigDataGridView(DGVMunicipios)
        oFunciones.ConfigurarBindingNavigator(BindingNavigator1, False, False, True, True)
        FiltroGrillaSax1.meDatagrid = DGVMunicipios
        cargarTabla()
        llenarCombos()
        filaActual = -1
    End Sub

    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        If DGVMunicipios.RowCount > 0 Then
            filaActual = DGVMunicipios.CurrentRow.Index()
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
            Me.DataSet_pCAT_MUNICIPIOS_B_.pCAT_MUNICIPIOS_B.Clear()
            Dim myDA = New SqlClient.SqlDataAdapter("pCAT_MUNICIPIOS_B", oFunciones.sConexion)
            myDA.SelectCommand.Parameters.AddWithValue("@habilitado", RBHabilitado.Checked)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_pCAT_MUNICIPIOS_B_.pCAT_MUNICIPIOS_B)
            myDA.Dispose()
            'oFunciones.AlternatingColors_Grilla(DGVMunicipios)

            If DGVMunicipios.RowCount > 0 Then
                DGVMunicipios.CurrentRow.Selected = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Cargar tabla", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        tablaCargado = True
    End Sub

    Sub llenarCombos()
        Try
            ReDim oFunciones.ParametersX_Global(0)
            If RBHabilitado.Checked Then
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@habilitado", 1)
            End If
            oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_ESTADOS_B", "CLAVE", "DESCRIPCIONX", CBSEstado, oFunciones.ParametersX_Global)
        Catch ex As Exception
            'MessageBox.Show("Error: " & ex.Message, "Cargar listas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub DGVMunicipios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVMunicipios.CellClick 'Click en celda
        'Primer celda (0) = Eliminar
        If DGVMunicipios.RowCount > 0 Then
            filaActual = DGVMunicipios.CurrentRow.Index()
        End If

        If e.RowIndex > -1 Then
            enviarDatos(e.RowIndex)

            If e.ColumnIndex = 0 Then
                Dim result As MsgBoxResult =
                MessageBox.Show(
                    "¿Está seguro de desactivar/activar este registro?" & vbCrLf & DGVMunicipios.Item("DGVMUMUNICIPIO", e.RowIndex).Value,
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                )

                If (result = MsgBoxResult.Yes) Then
                    msgBoxHandler()
                End If
            End If
        End If
    End Sub

    Private Sub DGVMunicipios_SelectionChanged(sender As Object, e As EventArgs) Handles DGVMunicipios.SelectionChanged 'Seleccion cambiada
        If (filaActual <> -1 And filaActual < DGVMunicipios.RowCount) And tablaCargado Then
            enviarDatos(DGVMunicipios.CurrentRow.Index())
        End If
    End Sub

    Private Sub enviarDatos(fila As Integer) 'Enviar columnas de fila al formulario
        Try
            'If CBSEstado.Count = 0 Then 'Se ha dado click en el boton x del combo (limpia el DataSource)
            '    llenarCombos()
            'End If

            If fila <> -1 And tablaCargado Then
                TXTClave.Text = DGVMunicipios.Item("DGVMUCLAVE", fila).Value
                TXTMunicipio.Text = DGVMunicipios.Item("DGVMUMUNICIPIO", fila).Value
                CBSEstado.Text = DGVMunicipios.Item("DGVMUDESCRIPCIONY", fila).Value
                TXTAgeem.Text = DGVMunicipios.Item("DGVMUAGEEM", fila).Value
            End If
        Catch ex As Exception
            MessageBox.show("Error: " & ex.Message, "Enviar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub guardar()
        Dim siGuardo As Boolean = False

        Try
            If oFunciones.ValidarGrupos(Panel1, ErrorProvider1) Then
                If DGVMunicipios.RowCount > 0 Then
                    filaActual = DGVMunicipios.CurrentRow.Index()
                End If

                ReDim oFunciones.ParametersX_Global(4)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_municipio", TXTClave.Text)
                oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@nombre", TXTMunicipio.Text.ToUpper)
                oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@cve_estado", CBSEstado.SelectedValue)
                oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@ageem", TXTAgeem.Text)
                oFunciones.ParametersX_Global(4) = New SqlClient.SqlParameter("@habilitado", RBHabilitado.Checked)
                Dim parametro = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_MUNICIPIOS_G", "@parametro", oFunciones.ParametersX_Global, False, SqlDbType.Int, 50)

                If parametro = TXTClave.Text Then 'Cuando es acualizacion de registro: compara valor devuelto con el del TextBox
                    siGuardo = True
                ElseIf parametro <> Nothing And parametro <> TXTClave.Text Then 'Cuando es nuevo: verifica si no es nulo el parametro y si es distinto del TexBox=0
                    siGuardo = True
                    filaActual = DGVMunicipios.RowCount()
                ElseIf parametro = Nothing Then 'Error
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
            MessageBox.show(ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Private Sub msgBoxHandler(ByVal sender As Object, ByVal e As EventArgs)
    Private Sub msgBoxHandler()
        Try
            Dim siElimino As Boolean = False

            ReDim oFunciones.ParametersX_Global(1)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_municipio", DGVMunicipios.CurrentRow.Cells("DGVMUCLAVE").Value)
            oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@habilitado", Not RBHabilitado.Checked)

            If oFunciones.fGuardar_O_EliminarXProcedure("pCAT_MUNICIPIOS_E", "@parametro", oFunciones.ParametersX_Global, False) Then
                siElimino = True
            End If

            If siElimino Then
                limpiarFormulario()
                cargarTabla()
                recuperarEstado(True)
            Else
                MessageBox.Show("Datos no eliminados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DGVMunicipios_Click(sender As Object, e As EventArgs) Handles DGVMunicipios.Click 'Click en la tabla
        If DGVMunicipios.RowCount > 0 And filaActual = -1 Then
            filaActual = 0
        End If
    End Sub

    Private Sub recuperarEstado(Optional ByVal siEnviar As Boolean = False) 'Seleccionar filaactual despues de actualizar/guardar/eliminar
        With DGVMunicipios
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
        cargarTabla()
        limpiarFormulario()
    End Sub

    Private Sub CBSEstado_ToolClick(sender As Object, e As ToolClickEventArgs) Handles CBSEstado.ToolClick
        If e.Tool.Name = "Borrar" Then
            CBSEstado.SelectedIndex = -1
        End If
    End Sub

    Private Sub TXTAgeem_TextChanged(sender As Object, e As EventArgs) Handles TXTAgeem.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class

