Imports Wisej.Web

Public Class Configuracion_Consecutivos
    Dim ofunciones As New dllData
    Dim columna As String = Nothing
    Dim Valor As Integer = Nothing
    Dim i As Integer = 0
    Private Sub Configuracion_Consecutivos_General_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cargar_Tabla()
        Cargar_Combo()
        ofunciones.ConfigurarBindingNavigator(BindingNavigator1, False, False, True, True)
        'ofunciones.ConfigurarBindingNavigator(BindingNavigator1, False, False, True, True)
    End Sub

    Sub Cargar_Combo()
        Try
            ofunciones.Llenar_CatalogosXprocedureYParams("pPARAMETROS_COLUMNAS_B", "COLUMNA", "COLUMNA", CBSColumna)
        Catch ex As Exception
            MessageBox.show("Error: " & ex.Message, "Cargar combo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Sub Cargar_Tabla()
        Try
            Dim myDA = New SqlClient.SqlDataAdapter("pPARAMETROS_B", ofunciones.sConexion)
            Me.DataSet_pPARAMETROS_B.pPARAMETROS_B.Clear()
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_pPARAMETROS_B.pPARAMETROS_B)
            myDA.Dispose()
        Catch ex As Exception
            MessageBox.show("Error: " & ex.Message, "Cargar tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Text
            Case "Actualizar"
                Cargar_Tabla()
            Case "Salir"
                Close()

        End Select
    End Sub

    Private Sub DGVConsecutivos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVConsecutivos.CellEndEdit

        If i = 0 Then
            If e.RowIndex <> -1 Then
                If e.ColumnIndex <> -1 Then
                    Dim A As Integer = e.ColumnIndex
                    columna = DGVConsecutivos.Columns.Item(A).DataPropertyName

                    'For n As Integer = 0 To DGVConsecutivosParalelo.RowCount - 1
                    Valor = DGVConsecutivos.Item(e.ColumnIndex, e.RowIndex).Value
                    Dim result As MsgBoxResult =
                    MessageBox.Show("¿Está seguro de actualizar este consecutivo?" & vbCrLf & "Consecutivo : " & Valor _
, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                    If (result = MsgBoxResult.Yes) Then
                        msgBoxHandler()
                    End If
                    'Next
                    i = i + 1
                End If
            End If
        Else
            i = 0
        End If

    End Sub

    'Private Sub msgBoxHandler(ByVal sender As Object, ByVal e As EventArgs)
    Private Sub msgBoxHandler()
        Dim bElimino As Boolean = False

        ReDim ofunciones.ParametersX_Global(1)
                ofunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@columna", columna)
                ofunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@valor", Valor)
                If ofunciones.fGuardar_O_EliminarXProcedure("pPARAMETROS_G", "@parametro", ofunciones.ParametersX_Global, False) Then
                    bElimino = True
                End If

                If bElimino Then
                    Cargar_Tabla()
                End If

    End Sub

    Private Sub BTNLimpiar_Click(sender As Object, e As EventArgs) Handles BTNLimpiar.Click
        Try
            CBSColumna.SelectedIndex = -1
            ocultar_mostrar(True)
        Catch ex As Exception
            MessageBox.show("Error: " & ex.Message, "Limpiar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub BTNBuscar_Click(sender As Object, e As EventArgs) Handles BTNBuscar.Click
        Try
            If CBSColumna.SelectedIndex <> -1 Then
                If CBSColumna.SelectedIndex = -1 Then
                    ocultar_mostrar(True)
                Else
                    ocultar_mostrar(False)
                    ocultar_mostrar_busqueda(CBSColumna.SelectedValue)
                End If
            End If
        Catch ex As Exception
            MessageBox.show("Error: " & ex.Message, "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ocultar_mostrar(ByVal SI_NO As Boolean)
        For Each columna As DataGridViewColumn In DGVConsecutivos.Columns
            columna.Visible = SI_NO
        Next
    End Sub

    Private Sub ocultar_mostrar_busqueda(ByVal sColumna As String)
        Dim encontro As Boolean = False
        sColumna = sColumna.ToString.ToUpper

        For Each columna As DataGridViewColumn In DGVConsecutivos.Columns
            If sColumna = columna.HeaderText Then
                columna.Visible = True
                encontro = True
            End If
        Next

        If Not encontro Then
            MessageBox.show("No se encontro: " & sColumna, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub CBSColumna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSColumna.SelectedIndexChanged
        Try
            If CBSColumna.SelectedIndex = -1 Then
                ocultar_mostrar(True)
            Else
                ocultar_mostrar(False)
                ocultar_mostrar_busqueda(CBSColumna.SelectedValue)
            End If
        Catch ex As Exception
            MessageBox.show("Error: " & ex.Message, "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class

