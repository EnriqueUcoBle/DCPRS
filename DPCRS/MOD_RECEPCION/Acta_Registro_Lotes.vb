Imports Wisej.Web

Public Class Acta_Registro_Lotes
    Private oFunciones As New dllData
    Dim dicParametros As New Dictionary(Of String, String)
    Public sLote As Integer = 0
    Dim DatosTemporales As Boolean = False
    Private Sub Acta_Registro_Lotes_Load(sender As Object, e As EventArgs) Handles Me.Load
        oFunciones.loadConfigDataGridView(DGVExpedientes)
        'oFunciones.ConfigurarBindingNavigator(BindingNavigator1, False, False, True, True)
        subLlenarCombos()
        If sLote = 0 Then
            Me.Text = "Registro Expedientes"
            LBLMunicipio.Text = "Jurisdicción: " & Application.Session("MUNICIPIO")
            DTPFecha.Value = Now
        Else
            Me.Text = "Actualizar Expedientes"
            CargarTabla()
        End If
    End Sub

    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick

        Select Case e.Item.Text
            Case "Nuevo"
                limpiarFormulario()
            Case "Guardar"
                guardar()
            Case "Imprimir"
                If sLote = 0 Then guardar()
                ImprimirReporte()
            Case "Salir"

                If DatosTemporales Then
                    Dim resultado As DialogResult = MessageBox.Show("¿Desea guardar cambios?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    If resultado = DialogResult.Yes Then
                        guardarExpedientes(sLote)
                        Me.Close()
                    ElseIf resultado = DialogResult.No Then
                        Me.Close()
                    End If
                Else
                    Me.Close()
                End If

        End Select

    End Sub
    Private Sub CargarTabla()
        Try

            Me.DataSet_pACTAS_VERIFICACION_LOTES_B.pACTAS_VERIFICACION_LOTES_B.Clear()
            Dim myDA = New SqlClient.SqlDataAdapter("pACTAS_VERIFICACION_LOTES_B", oFunciones.sConexion)
            myDA.SelectCommand.Parameters.AddWithValue("@cve_lote", sLote)
            myDA.SelectCommand.Parameters.AddWithValue("@fecha1", DTPFecha.Text)
            myDA.SelectCommand.Parameters.AddWithValue("@fecha2", DTPFecha.Text)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_pACTAS_VERIFICACION_LOTES_B.pACTAS_VERIFICACION_LOTES_B)

            myDA.Dispose()

            'Dim x As DataView = Me.DataSet_pACTAS_VERIFICACION_LOTES_B.Tables(0).DefaultView
            'DGVExpedientes.DataSource = x.ToTable
            'oFunciones.AlternatingColors_Grilla(DGVGiros)


            If DGVExpedientes.RowCount > 0 Then
                DGVExpedientes.CurrentRow.Selected = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try
    End Sub
    Sub subLlenarCombos()
        Try
            ReDim oFunciones.ParametersX_Global(0)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@habilitado", 1)
            oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_ESTABLECIMIENTOS_B", "CVE_ESTABLECIMIENTO", "RAZON_SOCIALX", CBSEstablecimiento, oFunciones.ParametersX_Global)
        Catch ex As Exception
            MessageBox.show("Error: " & ex.Message, "Cargar listas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub DGVExpedientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVExpedientes.CellClick 'Click en celda
        Try
            If e.RowIndex > -1 Then
                If e.ColumnIndex = 0 Then
                    Dim result As MsgBoxResult =
                    MessageBox.Show(
                        "¿Está seguro de eliminar este expediente?" & vbCrLf & "Clave acta: " & DGVExpedientes.Item("DGVCLAVEACTA", e.RowIndex).Value & vbCrLf & "Establecimiento: " & DGVExpedientes.Item("DGVESTABLECIMIENTO", e.RowIndex).Value,
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

    Private Sub BTNAgregar_Click(sender As Object, e As EventArgs) Handles BTNAgregar.Click
        Try
            If validar() Then

                Dim dt As DataTable = DataSet_pACTAS_VERIFICACION_LOTES_B.Tables(0)


                Dim dr As DataRow

                dr = dt.NewRow()
                dr("CVE_LOTE") = sLote
                dr("CVE_EXPEDIENTE") = 0
                dr("NUM_CONSECUTIVO") = 0
                dr("CVE_ACTA") = TXTClaveActa.Text.ToUpper
                dr("FECHA") = DTPFecha.Text
                dr("CVE_ESTABLECIMIENTO") = oFunciones.obTener_Descripcion4(CBSEstablecimiento, "CVE_ESTABLECIMIENTO")
                dr("RAZON_SOCIAL") = oFunciones.obTener_Descripcion4(CBSEstablecimiento, "RAZON_SOCIAL")
                dr("PROPIETARIO") = oFunciones.obTener_Descripcion4(CBSEstablecimiento, "NOM_PROPIETARIO")
                dr("DOMICILIO") = oFunciones.obTener_Descripcion4(CBSEstablecimiento, "DOMICILIO")
                dr("CVE_OPERADOR") = Application.Session("Cve_Operador")
                dr("CVE_MUNICIPIO") = Application.Session("CVE_MUNICIPIO")
                dr("MUNICIPIO") = Application.Session("MUNICIPIO")
                dr("ESTATUS") = "ENVIADO"
                dt.Rows.Add(dr)


                'Dim datos() As String = {
                '            Nothing,
                '            Nothing,
                '            TXTClaveActa.Text.ToUpper,
                '            oFunciones.obTener_Descripcion4(CBSEstablecimiento, "RAZON_SOCIAL"),
                '            oFunciones.obTener_Descripcion4(CBSEstablecimiento, "NOM_PROPIETARIO"),
                '            oFunciones.obTener_Descripcion4(CBSEstablecimiento, "DOMICILIO"),
                '            oFunciones.obTener_Descripcion4(CBSEstablecimiento, "CVE_ESTABLECIMIENTO")
                '        }
                'DGVExpedientes.Rows.Add(datos)
                consecutivo()
                Dim UltimaFila = DGVExpedientes.RowCount - 1
                DGVExpedientes.Item("BD", UltimaFila).Value = True
                DatosTemporales = True
            Else
                oFunciones.AlertBox("Hay datos incompletos", MessageBoxIcon.Warning)
            End If
        Catch ex As SystemException
            MessageBox.show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        CBSEstablecimiento.SelectedIndex = -1
        TXTClaveActa.Text = Nothing
    End Sub

    Private Sub guardar()
        Try
            If DGVExpedientes.RowCount > 0 Then

                ReDim oFunciones.ParametersX_Global(4)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_lote", sLote)
                oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@fecha", DTPFecha.Value.Date)
                oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@estatus", "ENVIADO")
                oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@cve_operador", Application.Session("Cve_Operador"))
                oFunciones.ParametersX_Global(4) = New SqlClient.SqlParameter("@cve_municipio", Application.Session("CVE_MUNICIPIO"))

                sLote = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pACTAS_VERIFICACION_LOTES_G", "@parametro", oFunciones.ParametersX_Global, False, SqlDbType.Int, 50)

                If sLote <> Nothing Then
                    guardarExpedientes(sLote)
                Else
                    MessageBox.Show("Datos no guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Else
                MessageBox.Show("No hay datos en la tabla", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.show("Error: " & vbCrLf & ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub guardarExpedientes(ByVal cveLote As Integer)
        Dim siGuardo As Boolean = False
        Try
            If DGVExpedientes.RowCount > 0 Then
                For fila As Integer = 0 To DGVExpedientes.RowCount - 1
                    ReDim oFunciones.ParametersX_Global(4)
                    oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_expediente", DGVExpedientes.Item("CVE_EXPEDIENTE", fila).Value) 'Cuando es nuevo, el valor es cero
                    oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@cve_lote", cveLote)
                    oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@num_consecutivo", DGVExpedientes.Item("DGVCONSECUTIVO", fila).Value)
                    oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@cve_acta", DGVExpedientes.Item("DGVCLAVEACTA", fila).Value.ToString.ToUpper)
                    oFunciones.ParametersX_Global(4) = New SqlClient.SqlParameter("@cve_establecimiento", DGVExpedientes.Item("DGVCLAVEESTABLECIMIENTO", fila).Value)

                    Dim parametro = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pACTAS_VERIFICACION_LOTES_EXPEDIENTES_G", "@parametro", oFunciones.ParametersX_Global, False, SqlDbType.Int, 50)

                    If parametro <> Nothing Then 'Cuando es nuevo: verifica si no es nulo el parametro y si es distinto del TexBox=0
                        siGuardo = True
                    ElseIf parametro = Nothing Then
                        MessageBox.show("Datos no guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                Next

                If siGuardo Then
                    oFunciones.AlertBox("Datos guardados correctamente", MessageBoxIcon.Information, MessageBoxButtons.OK)
                    DatosTemporales = False
                End If
            End If

        Catch ex As Exception
            MessageBox.show("Error: " & vbCrLf & ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Private Sub msgBoxHandler(ByVal sender As Object, ByVal e As EventArgs) 'Callback de messagebox eliminar
    Private Sub msgBoxHandler() 'Callback de messagebox eliminar
        Try
            If DGVExpedientes.CurrentRow.Cells("BD").Value = True Then 'Que no está en la BD, por eso sólo elimina la fila.
                DGVExpedientes.Rows.Remove(DGVExpedientes.CurrentRow)
            Else

                'If DatosTemporales Then guardarExpedientes(sLote) 'Si quiero eliminar un registro que ya está en la BD y hay registros pendientes por guardar.

                ReDim oFunciones.ParametersX_Global(0)
                'oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_lote", sLote)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_expediente", DGVExpedientes.CurrentRow.Cells("CVE_EXPEDIENTE").Value)

                If oFunciones.fGuardar_O_EliminarXProcedure("pACTAS_VERIFICACION_LOTES_EXPEDIENTES_E", "@parametro", oFunciones.ParametersX_Global, False) Then
                    'CargarTabla()
                    DGVExpedientes.Rows.Remove(DGVExpedientes.CurrentRow)
                    consecutivo()
                Else
                    MessageBox.Show("Datos no eliminados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            End If

            consecutivo()
        Catch ex As Exception
            MessageBox.Show("Error: " & vbCrLf & ex.Message, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Sub ImprimirReporte()
        Try
            dicParametros.Clear()
            dicParametros.Add("cve_lote", sLote)
            dicParametros.Add("cve_municipio", Application.Session("CVE_MUNICIPIO"))
            ' Application.Session("DicParametros") = dicParametros

            oFunciones.GenerarReporte("R_Acta_Registro_Lotes", "pACTAS_VERIFICACION_LOTES_B", dicParametros)
        Catch ex As Exception
            MessageBox.Show("Error: " & vbCrLf & ex.Message, "Imprimir reporte", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Function validar() As Boolean
        validar = True

        If (String.IsNullOrEmpty(TXTClaveActa.Text)) Or (Not CBSEstablecimiento.SelectedIndex <> -1) Then
            validar = False
        End If

    End Function
    Private Sub consecutivo()
        If DGVExpedientes.RowCount > 0 Then
            For row As Integer = 0 To DGVExpedientes.RowCount - 1
                DGVExpedientes.Item("DGVCONSECUTIVO", row).Value = row + 1
            Next
        End If
    End Sub
    Private Sub limpiarFormulario()
        oFunciones.LimpiarPanel(Panel1, Me.Tag)
        sLote = "0"
    End Sub

End Class

