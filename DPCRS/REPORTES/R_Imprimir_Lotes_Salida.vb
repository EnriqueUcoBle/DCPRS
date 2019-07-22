Public Class R_Imprimir_Lotes_Salida

    Inherits DevExpress.XtraReports.UI.XtraReport
    Dim oFunciones As New dllData
    Dim fecha As String
    Private Sub R_Imprimir_Lotes_Salida_DataSourceDemanded(sender As Object, e As EventArgs) Handles Me.DataSourceDemanded


        fecha = DateTime.Now.ToLongDateString()
        XrLabel4.NullValueText = fecha
        DataSet_pCAT_IMPRIMIR_LOTES_B1.Clear()
        Dim myDA = New SqlClient.SqlDataAdapter("pCAT_IMPRIMIR_LOTES_B", oFunciones.sConexion)
        myDA.SelectCommand.CommandType = CommandType.StoredProcedure
        If Parameters.Count > 0 Then
            For nParam = 0 To Parameters.Count - 1
                myDA.SelectCommand.Parameters.AddWithValue("@" & Parameters.Item(nParam).Name, Parameters.Item(Parameters.Item(nParam).Name).Value)
            Next
        End If

        myDA.Fill(DataSet_pCAT_IMPRIMIR_LOTES_B1.pCAT_IMPRIMIR_LOTES_B)
        myDA.Dispose()
    End Sub
End Class