Imports Wisej.Web

Public Class Cat_Estudios_Sub
    Dim oFunciones As New dllData
    Dim filaActual As Integer = -1
    Dim tablaCargado As Boolean = False

    Private Sub Cat_Estudios_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Sub Estudios"
        oFunciones.loadConfigDataGridView(DGVEstudiosSub)
        oFunciones.ConfigurarBindingNavigator(BindingNavigator1, False, False, True, True)
        FiltroGrillaSax1.meDatagrid = DGVEstudiosSub
        DGVESESTUDIOSUB.Frozen = True
        llenarCombos()
        limpiarFormulario()
        filaActual = -1
        'SplitContainer1.SplitterDistance = (Screen.PrimaryScreen.Bounds.Width / 3)
    End Sub

    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        If DGVEstudiosSub.RowCount > 0 Then
            filaActual = DGVEstudiosSub.CurrentRow.Index()
        End If

        Select Case e.Item.Text
            Case "Nuevo"
                limpiarFormulario()
                SplitContainer1.Panel2Collapsed = False
            Case "Actualizar"
                cargarTablaES()
                limpiarFormulario()
                recuperarEstado(True)
            Case "Guardar"
                guardar()
            Case "Salir"
                Me.Close()
        End Select
    End Sub

    Private Sub cargarTablaES()
        tablaCargado = False
        Dim eIndex As Integer = CBSEstudio.SelectedValue
        If eIndex <> -1 Then
            Try
                Me.DataSet_pCAT_ESTUDIOS_SUB_B.pCAT_ESTUDIOS_SUB_B.Clear()
                Dim myDA = New SqlClient.SqlDataAdapter("pCAT_ESTUDIOS_SUB_B", oFunciones.sConexion)
                myDA.SelectCommand.Parameters.AddWithValue("@habilitado", RBHabilitado.Checked)
                myDA.SelectCommand.Parameters.AddWithValue("@cve_estudio", eIndex)
                myDA.SelectCommand.CommandType = CommandType.StoredProcedure
                myDA.Fill(Me.DataSet_pCAT_ESTUDIOS_SUB_B.pCAT_ESTUDIOS_SUB_B)
                myDA.Dispose()
                'oFunciones.AlternatingColors_Grilla(DGVEstudiosSub)

                If DGVEstudiosSub.RowCount > 0 Then
                    DGVEstudiosSub.CurrentRow.Selected = False
                End If
            Catch ex As Exception
                MessageBox.show("Error: " & ex.Message, "Cargar tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try

            tablaCargado = True
        End If
    End Sub

    Sub llenarCombos()
        Try
            ReDim oFunciones.ParametersX_Global(0)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@habilitado", 1)
            oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_ESTUDIOS_B", "CVE_ESTUDIO", "DESCRIPCIONX", CBSEstudio, oFunciones.ParametersX_Global)
        Catch ex As Exception
            MessageBox.show("Error: " & ex.Message, "Cargar listas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DGVEstudiosSub_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVEstudiosSub.CellClick 'Click en celda
        'Primer celda (0) = Eliminar
        Try
            If DGVEstudiosSub.RowCount > 0 Then
                filaActual = DGVEstudiosSub.CurrentRow.Index()
            End If

            If e.RowIndex > -1 Then
                If e.ColumnIndex = 1 Then
                    SplitContainer1.Panel2Collapsed = False
                    enviarDatos(e.RowIndex)
                End If

                If e.ColumnIndex = 0 Then
                    SplitContainer1.Panel2Collapsed = True
                    Dim result As MsgBoxResult =
                    MessageBox.Show(
                        "¿Está seguro de desactivar/activar esta clave?" & vbCrLf & "Clave : " & DGVEstudiosSub.Item("DGVESCLAVEESTUDIOSUB", e.RowIndex).Value,
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

    Private Sub DGVEstudiosSub_SelectionChanged(sender As Object, e As EventArgs) Handles DGVEstudiosSub.SelectionChanged 'Seleccion cambiada
        Try
            If (filaActual <> -1 And filaActual < DGVEstudiosSub.RowCount) And tablaCargado Then
                enviarDatos(DGVEstudiosSub.CurrentRow.Index())
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al enviar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub enviarDatos(fila As Integer) 'Enviar columnas de fila al formulario
        Try
            'If CBSEstudio.Count = 0 Then 'Se ha dado click en el boton x del combo (limpia el DataSource)
            '    llenarCombos()
            'End If

            If fila <> -1 And tablaCargado Then

                Dim cTipo As String = DGVEstudiosSub.Item("DGVESTIPORESULTADO", fila).Value.ToString
                ocultarTabs()
                'SplitContainer1.Panel2Collapsed = False

                CBTipoDato.SelectedItem = cTipo.ToUpper
                TXTClave.Text = DGVEstudiosSub.Item("DGVESCLAVEESTUDIOSUB", fila).Value
                TXTSubEstudio.Text = DGVEstudiosSub.Item("DGVESESTUDIOSUB", fila).Value
                TXTUnidad.Text = DGVEstudiosSub.Item("DGVESUNIDAD", fila).Value

                Select Case cTipo.ToUpper
                    Case "NUMERICO"
                        TXTReferenciaTexto.Text = DGVEstudiosSub.Item("DGVESREFERENCIATEXTO", fila).Value
                        TXTReferencia1.Text = DGVEstudiosSub.Item("DGVESREFERENCIA1", fila).Value
                        TXTReferencia2.Text = DGVEstudiosSub.Item("DGVESREFERENCIA2", fila).Value

                    Case "TEXTO"

                End Select
                mostrarTabs(CBTipoDato.SelectedIndex)

            End If
        Catch ex As Exception
            MessageBox.show("Error: " & ex.Message, "Enviar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub guardar()
        Dim siGuardo As Boolean = False

        Try
            If CBSEstudio.SelectedIndex <> -1 Then

                If Not CBTipoDato.SelectedIndex <> -1 Then
                    MessageBox.show("Seleccione un tipo de dato", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                Dim cTipo As String = CBTipoDato.SelectedItem.ToString
                If DGVEstudiosSub.RowCount > 0 Then
                    filaActual = DGVEstudiosSub.CurrentRow.Index()
                End If

                If Not oFunciones.ValidarGrupos(Panel6, ErrorProvider1) Then
                    MessageBox.show("No pueden ir vacios los campos", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                ReDim oFunciones.ParametersX_Global(9)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_subestudio", TXTClave.Text)
                oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@cve_estudio", CBSEstudio.SelectedValue)
                oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@descripcion", TXTSubEstudio.Text)
                oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@unidad", TXTUnidad.Text)
                oFunciones.ParametersX_Global(4) = New SqlClient.SqlParameter("@tipo_resultado", cTipo)
                oFunciones.ParametersX_Global(5) = New SqlClient.SqlParameter("@operador", Application.Session("Cve_Operador"))
                oFunciones.ParametersX_Global(6) = New SqlClient.SqlParameter("@habilitado", 1)

                Select Case cTipo.ToUpper
                    Case "NUMERICO"

                        If Not IsNumeric(Replace(TXTReferencia1.Text, ",", ".")) Then
                            ErrorProvider1.SetError(TXTReferencia1, "Solo numerico")
                            Exit Sub
                        Else
                            ErrorProvider1.SetError(TXTReferencia1, "")
                        End If
                        If Not IsNumeric(Replace(TXTReferencia2.Text, ",", ".")) Then
                            ErrorProvider1.SetError(TXTReferencia2, "Solo numerico")
                            Exit Sub
                        Else
                            ErrorProvider1.SetError(TXTReferencia2, "")
                        End If

                        oFunciones.ParametersX_Global(7) = New SqlClient.SqlParameter("@referencia_texto", TXTReferenciaTexto.Text)
                        oFunciones.ParametersX_Global(8) = New SqlClient.SqlParameter("@referencia_numerico1", Replace(TXTReferencia1.Text, ",", "."))
                        oFunciones.ParametersX_Global(9) = New SqlClient.SqlParameter("@referencia_numerico2", Replace(TXTReferencia2.Text, ",", "."))
                    Case "TEXTO"

                End Select

                Dim parametro = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_ESTUDIOS_SUB_G", "@parametro", oFunciones.ParametersX_Global, False, SqlDbType.Int, 50)

                If parametro = TXTClave.Text Then 'Cuando es acualizacion de registro: compara valor devuelto con el del TextBox
                    siGuardo = True
                ElseIf parametro <> Nothing And parametro <> TXTClave.Text Then 'Cuando es nuevo: verifica si no es nulo el parametro y si es distinto del TexBox=0
                    siGuardo = True
                    filaActual = DGVEstudiosSub.RowCount()
                ElseIf parametro = Nothing Then
                    MessageBox.show("Datos no guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                If siGuardo Then
                    cargarTablaES()
                    recuperarEstado(True)
                    MessageBox.show("Datos guardados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.show("Seleccione un estudio", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

            ReDim oFunciones.ParametersX_Global(2)
                    'oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@cve_subestudio", DGVEstudiosSub.Item("DGVESCLAVEESTUDIOSUB", DGVEstudiosSub.CurrentRow.Index).Value)
                    oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_subestudio", DGVEstudiosSub.CurrentRow.Cells("DGVESCLAVEESTUDIOSUB").Value)
                    oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@cve_estudio", CBSEstudio.SelectedValue)
                    oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@habilitado", Not RBHabilitado.Checked)

                    If oFunciones.fGuardar_O_EliminarXProcedure("pCAT_ESTUDIOS_SUB_E", "@parametro", oFunciones.ParametersX_Global, False) Then
                        siElimino = True
                    End If

                    If siElimino Then
                        cargarTablaES()
                        recuperarEstado(True)
                    Else
                        MessageBox.Show("Datos no eliminados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DGVEstudiosSub_Click(sender As Object, e As EventArgs) Handles DGVEstudiosSub.Click 'Click en la tabla
        If DGVEstudiosSub.RowCount > 0 And filaActual = -1 Then
            filaActual = 0
        End If
    End Sub

    Private Sub recuperarEstado(Optional ByVal siEnviar As Boolean = False) 'Seleccionar filaactual despues de actualizar/guardar/eliminar
        With DGVEstudiosSub
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
        For Each cControl In Me.Panel2.Controls
            oFunciones.LimpiarChildren(cControl, ErrorProvider1)
        Next
        TBCTipoDato.Visible = False
        TXTClave.Text = "0"
    End Sub
    Sub ocultarTabs()
        TBCTipoDato.Visible = True
        TBCTipoDato.Update()
        For i = 0 To TBCTipoDato.TabPages.Count - 1
            TBCTipoDato.TabPages(i).Visible = False
        Next
    End Sub

    Sub mostrarTabs(ByVal index As Integer)
        With TBCTipoDato
            .Visible = True
            .Update()
            .TabPages(index).Visible = True
            .SelectedIndex = index
        End With
    End Sub

    Private Sub CBTipoDato_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBTipoDato.SelectedIndexChanged
        If CBTipoDato.SelectedIndex = -1 Then Exit Sub

        Dim cTipo As String = CBTipoDato.SelectedItem.ToString
        Dim cIndex As Integer = CBTipoDato.SelectedIndex
        Select Case cTipo.ToUpper
            Case "NUMERICO"

            Case "TEXTO"

        End Select

        ocultarTabs()
        mostrarTabs(cIndex)
    End Sub

    Private Sub CBSEstudio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSEstudio.SelectedIndexChanged
        If CBSEstudio.SelectedIndex <> -1 Then

            cargarTablaES()
            limpiarFormulario()
            RBNNUEVO.Enabled = True

            If DGVEstudiosSub.RowCount > 0 Then
                SplitContainer1.Panel2Collapsed = True
                RBNACTUALIZAR.Enabled = True
            Else
                SplitContainer1.Panel2Collapsed = False
                RBNACTUALIZAR.Enabled = False
            End If

        Else
            DataSet_pCAT_ESTUDIOS_SUB_B.Clear()
            SplitContainer1.Panel2Collapsed = True
            RBNNUEVO.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        limpiarFormulario()
        SplitContainer1.Panel2Collapsed = True
    End Sub

    Private Sub RBDesactivado_CheckedChanged(sender As Object, e As EventArgs) Handles RBDesactivado.CheckedChanged
        limpiarFormulario()
        cargarTablaES()
    End Sub

    Private Sub CBSEstudio_ToolClick(sender As Object, e As ToolClickEventArgs) Handles CBSEstudio.ToolClick
        If e.Tool.Name = "Borrar" Then
            CBSEstudio.SelectedIndex = -1
        End If
    End Sub
End Class
