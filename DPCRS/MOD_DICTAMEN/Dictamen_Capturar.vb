Imports Wisej.Web
Imports System.Drawing
Public Class Dictamen_Capturar

    Dim oFunciones, oFunciones2 As New dllData
    Dim tablaCargado As Boolean = False
    Dim filaActual As Integer = -1
    Dim dicParametros As New Dictionary(Of String, Object)


    Private Sub Dictamen_Capturar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Capturar Dictamen"
        oFunciones.loadConfigDataGridView(DGVDICTAMENES)
        oFunciones.ConfigurarBindingNavigator(BindingNavigator1, False, False, True, True)
        FiltroGrillaSax1.meDatagrid = DGVDICTAMENES
        Cargar()
        llenarCombos()
        RBBGUARDAR.Enabled = False
        filaActual = -1
        TXTCLAVE_DICTAMEN.Text = "0"
        TXTCLAVE_DICTAMEN.Enabled = False
        Label7.Font = New Font(Label7.Font, FontStyle.Bold)
        LBjurisdicción.Text = Application.Session("MUNICIPIO")
    End Sub


    Private Sub RibbonBar1_ItemClick(sender As Object, e As Wisej.Web.Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Text
            Case "Nuevo"
                oFunciones.LimpiarPanel(GroupBox1, Me.Tag)
                limpiarFormulario()
                TabDictamen.SelectedIndex = 1
            Case "Actualizar"
                Cargar()
                recuperarEstado(True)
            Case "Guardar"
                Guardar()
            Case "Salir"
                Me.Close()
        End Select
    End Sub


    Private Sub DGVDICTAMENES_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDICTAMENES.CellClick
        'retomarPosiscion(e.RowIndex, DGVDICTAMENES, BindingSource1)
        'Try
        '    If e.ColumnIndex = 0 Then
        '        If e.RowIndex <> -1 Then
        '            Frm = New Dictamen_Capturar_New
        '            Frm.ShowDialog()
        '            Frm.vincularGrilla(Me.DataSet_pDICTAMEN_B)
        '            Dim indexB = Frm.BindingSourceDictamen.Find("CVE_DICTAMEN", DGVDICTAMENES.Item("colCVE_DICTAMEN", e.RowIndex).Value)
        '            Frm.retomarPosiscion(indexB, Frm.BindingSourceDictamen)
        '            If indexB = 0 Then Frm.CargarDatosAgremiados()
        '        End If
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error en la tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End Try
        Try
            If DGVDICTAMENES.RowCount > 0 Then
                filaActual = DGVDICTAMENES.CurrentRow.Index()
            End If
            If e.ColumnIndex = 0 Then
                enviarDatos(e.RowIndex)
                TabDictamen.SelectedIndex = 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub
    Private Sub Guardar()
        Dim siGuardo As Boolean = False
        Dim IndexActa As Integer = CBSACTAS.SelectedValue
        oFunciones.Conectar()
        Try
            If oFunciones.ValidarGrupos(GroupBox1, ErrorProvider1) Then
                ReDim oFunciones.ParametersX_Global(7)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@cve_dictamen", TXTCLAVE_DICTAMEN.Text)
                oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@cve_acta", IndexActa)
                oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@fecha_emision", Now)
                oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@descripcion", TXTDescripcion.Text)
                oFunciones.ParametersX_Global(4) = New SqlClient.SqlParameter("@medidas_seguridad", TXTMedidasSeguridad.Text)
                oFunciones.ParametersX_Global(5) = New SqlClient.SqlParameter("@fecha_recepcion", Now)
                oFunciones.ParametersX_Global(6) = New SqlClient.SqlParameter("@fecha_jurisdiccion", Now)
                oFunciones.ParametersX_Global(7) = New SqlClient.SqlParameter("@Cve_Operador", Application.Session("Cve_Operador"))
                If oFunciones.fGuardar_O_EliminarXProcedure("pDICTAMENES_G", "@parametro", oFunciones.ParametersX_Global, False) Then
                    limpiarFormulario()
                    Cargar()
                    recuperarEstado(True)
                    oFunciones.AlertBox("Datos guardados correctamente", MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("No pueden ir vacios los campos", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Sub llenarCombos()
        Try
            oFunciones.Llenar_CatalogosXprocedureYParams("pACTAS_DICTAMEN_B", "CVE_ACTA", "DESCRIPCION", CBSACTAS)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Cargar listas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub Cargar()
        tablaCargado = False

        Try
            Me.DataSet_pDICTAMEN_B.pDICTAMENES_B.Clear()
            Dim myDA = New SqlClient.SqlDataAdapter("pDICTAMENES_B", oFunciones.sConexion)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_pDICTAMEN_B.pDICTAMENES_B)
            myDA.Dispose()
            If DGVDICTAMENES.RowCount > 0 Then
                DGVDICTAMENES.CurrentRow.Selected = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Cargar tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        tablaCargado = True
    End Sub
    'Private Sub CargarTabla()
    '    Try
    '        Me.DataSet_pDICTAMEN_B.pDICTAMENES_B.Clear()
    '        Dim myDA = New SqlClient.SqlDataAdapter("pDICTAMENES_B", oFunciones.sConexion)
    '        myDA.SelectCommand.CommandType = CommandType.StoredProcedure
    '        myDA.Fill(Me.DataSet_pDICTAMEN_B.pDICTAMENES_B)
    '        myDA.Dispose()
    '    Catch ex As Exception
    '        MessageBox.Show("Error: " & ex.Message, "Cargar tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    End Try
    'End Sub

    Private Sub limpiarFormulario()
        oFunciones.LimpiarPanel(GroupBox1, Me.Tag)
        TXTDescripcion.Text = ""
        TXTMedidasSeguridad.Text = ""
        CBSACTAS.SelectedIndex = -1
        TXTCLAVE_DICTAMEN.Text = "0"
    End Sub

    Private Sub TabDictamen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabDictamen.SelectedIndexChanged

        If TabDictamen.SelectedIndex = 0 Then ' TAB BUSCAR
            RBBGUARDAR.Enabled = False
        ElseIf TabDictamen.SelectedIndex = 1 Then ' TAB CAPTURAATR
            RBBGUARDAR.Enabled = True
        End If

    End Sub

    Private Sub DGVDICTAMENES_SelectionChanged(sender As Object, e As EventArgs) Handles DGVDICTAMENES.SelectionChanged
        If (filaActual <> -1 And filaActual < DGVDICTAMENES.RowCount) And tablaCargado Then
            enviarDatos(DGVDICTAMENES.CurrentRow.Index())
        End If
    End Sub
    Private Sub enviarDatos(fila As Integer) 'Enviar columnas de fila al formulario
        Try
            If fila <> -1 And tablaCargado Then
                TXTCLAVE_DICTAMEN.Text = DGVDICTAMENES.Item("DGVclave", fila).Value
                CBSACTAS.Text = DGVDICTAMENES.Item("DGVcve_acta", fila).Value
                TXTDescripcion.Text = DGVDICTAMENES.Item("DGVdescripcion", fila).Value
                TXTMedidasSeguridad.Text = DGVDICTAMENES.Item("DGVdescripcion", fila).Value

            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Enviar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub recuperarEstado(Optional ByVal siEnviar As Boolean = False) 'Seleccionar filaactual despues de actualizar/guardar/eliminar
        With DGVDICTAMENES
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

    Private Sub CBSACTAS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSACTAS.SelectedIndexChanged

        Dim table As New DataTable
        If CBSACTAS.SelectedIndex <> -1 Then
            Try
                Dim myDA = New SqlClient.SqlDataAdapter("pDICTAMEN_CB_B", oFunciones.sConexion)
                myDA.SelectCommand.Parameters.AddWithValue("@cve_acta", CBSACTAS.SelectedValue)
                myDA.SelectCommand.CommandType = CommandType.StoredProcedure
                myDA.Fill(table)
                For Each row As DataRow In table.Rows
                    TXTTIPO_VERIFICACION.Text = row("TIPO_VERIFICACION").ToString
                    TXTESTATUS.Text = row("ESTATUS").ToString
                Next
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Cargar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Else
            TXTTIPO_VERIFICACION.Text = Nothing
            TXTESTATUS.Text = Nothing
        End If
    End Sub


End Class
