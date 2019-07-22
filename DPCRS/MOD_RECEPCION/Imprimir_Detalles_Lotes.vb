Imports System
Imports Wisej.Web

Public Class Imprimir_Detalles_Lotes
    Dim oFunciones, oFunciones2 As New dllData
    Dim dicParametros As New Dictionary(Of String, String)
    Dim cbs1 As Boolean = False
    Dim cbs2 As Boolean = False
    Public cvemuni As Integer = 0
    Public cvelote As Integer = 0
    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Text
            Case "Actualizar"
                Limpiarcampos()
            Case "Imprimir"
                'Guardar()
            Case "Salir"
                Me.Close()
        End Select
    End Sub
    Private Sub Limpiarcampos()
        CargarDGVdatos(-99)
        CargarcbxMunicipio()

    End Sub

    Private Sub Imprimir_Detalles_Lotes_Load(sender As Object, e As EventArgs) Handles Me.Load

        CargarDGVdatos(-99)
        CargarcbxMunicipio()
    End Sub

    Private Sub CBSmunicipio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSmunicipio.SelectedIndexChanged
        If cbs1 Then
            If CBSmunicipio.SelectedIndex <> -1 Then
                CargarDGVdatos(CBSmunicipio.SelectedValue)

            Else
            End If
        Else
            cbs1 = True
        End If

    End Sub

    Private Sub CargarcbxMunicipio()
        Try
            ReDim oFunciones.ParametersX_Global(0)
            oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_MUNICIPIOS_B", "CLAVE", "DESCRIPCIONX", CBSmunicipio, oFunciones.ParametersX_Global)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Cargar listas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    'Private Sub CBSlotes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSlotes.SelectedIndexChanged
    '    If cbs2 = True Then
    '        If CBSlotes.SelectedIndex <> -1 Then
    '            'CargarcbxLotes(CBSlotes.SelectedValue)
    '        Else
    '        End If
    '    Else
    '        cbs2 = True
    '    End If
    'End Sub
    'Private Sub CargarcbxLotes(ByVal CVE_MUNICIPIO As Integer)
    '    Try
    '        ReDim oFunciones.ParametersX_Global(0)
    '        oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_MUNICIPIO", CVE_MUNICIPIO)
    '        oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_VERIFICACION_LOTES_B", "CVE_LOTE", "NOMBRE", CBSlotes, oFunciones.ParametersX_Global)
    '        'MessageBox.Show(CBSmunicipio.SelectedValue)
    '    Catch ex As Exception
    '        MessageBox.Show("Error: " & ex.Message, "Cargar listas", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If CBSmunicipio.SelectedIndex <> -1 Then
            CargarDGVdatos(CBSmunicipio.SelectedValue)
        Else

        End If
        'Dim dFechaI As Date
        'dFechaI = DTPlote.Value
        'If DTPlote.Value = "0:00:00" Then
        'If CBSlotes.SelectedIndex = -1 And CBSmunicipio.SelectedIndex = -1 Then
        '        CargarDGVdatos(-99, -99, "1753-01-01")
        '    Else
        '        If CBSlotes.SelectedIndex <> -1 And CBSmunicipio.SelectedIndex = -1 Then
        '            CargarDGVdatos(CBSmunicipio.SelectedValue, -99, "1753-01-01")
        '        ElseIf CBSlotes.SelectedIndex = -1 And CBSmunicipio.SelectedIndex <> -1 Then
        '            CargarDGVdatos(-99, CBSlotes.SelectedValue, "1753-01-01")
        '        Else
        '            CargarDGVdatos(CBSmunicipio.SelectedValue, CBSlotes.SelectedValue, "1753-01-01")
        '        End If
        '    End If


        'Else

        '    CargarDGVdatos(CBSmunicipio.SelectedValue, CBSlotes.SelectedValue, dFechaI)
        'End If

    End Sub



    Private Sub CargarDGVdatos(ByVal CVE_MUNICIPIO As Integer)
        ', ByVal CVE_LOTE As Integer, ByVal FECHA As Date
        Try
            Me.DataSet_pCAT_LOTE_ACTAS_VERIFICACION.pCAT_VERIFICACION_LOTES_B.Clear()
            'Me.DataSet_pCAT_VERIFICACION_LOTES_B.pCAT_VERIFICACION_LOTES_B.Clear()
            Dim myDA = New SqlClient.SqlDataAdapter("pCAT_VERIFICACION_LOTES_B", oFunciones.sConexion)
            myDA.SelectCommand.Parameters.AddWithValue("@CVE_MUNICIPIO", CVE_MUNICIPIO)
            'myDA.SelectCommand.Parameters.AddWithValue("@CLAVE_LOTE", CVE_LOTE)
            'myDA.SelectCommand.Parameters.AddWithValue("@FECHA_INGRESO", FECHA)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_pCAT_LOTE_ACTAS_VERIFICACION.pCAT_VERIFICACION_LOTES_B)

        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Error en la tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DGV_DATOS_Click(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_DATOS.CellClick
        If e.ColumnIndex = 0 Then
            'MessageBox.Show(CBSmunicipio.SelectedValue)
            'MessageBox.Show(Me.DGV_DATOS.Item("CVE_LOTE", e.RowIndex).Value)
            If CBSmunicipio.SelectedIndex = -1 Then
                ImprimirReporte(-99, Me.DGV_DATOS.Item("CVE_LOTE", e.RowIndex).Value)
            Else
                ImprimirReporte(CBSmunicipio.SelectedValue, Me.DGV_DATOS.Item("CVE_LOTE", e.RowIndex).Value)
            End If



        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    'Dim dFechaF As Date  Private Sub Btn_Agregar_Detalle_Click(sender As Object, e As EventArgs) Handles Btn_Agregar_Detalle.Click


    Private Sub ImprimirReporte(ByVal MUNI As Integer, ByVal LOTE As Integer)
        Try
            'Dim fecha As String = DateTime.Now.ToLongDateString()

            cvemuni = MUNI
            cvelote = LOTE
            dicParametros.Clear()

            'dicParametros.Add("CLAVE_MUNICIPIO", cvemuni)
            dicParametros.Add("CLAVE_LOTE", cvelote)
            oFunciones.GenerarReporte("R_Imprimir_Lotes_Salida", "pCAT_IMPRIMIR_LOTES_B", dicParametros)
        Catch ex As Exception
            MessageBox.Show("Error: " & vbCrLf & ex.Message, "Imprimir reporte", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        'Try
        '    dicParametros.Clear()
        '    dicParametros.Add("cve_lote", sLote)
        '    dicParametros.Add("cve_municipio", Application.Session("CVE_MUNICIPIO"))
        '    ' Application.Session("DicParametros") = dicParametros

        '    oFunciones.GenerarReporte("R_Acta_Registro_Lotes", "pACTAS_VERIFICACION_LOTES_B", dicParametros)
        'Catch ex As Exception
        '    MessageBox.Show("Error: " & vbCrLf & ex.Message, "Imprimir reporte", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End Try


    End Sub


End Class
