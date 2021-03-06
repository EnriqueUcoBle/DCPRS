﻿Imports System.Drawing.Printing
Imports Wisej.Web
Public Class R_ACTA_GENERAL
    Dim oFunciones, oFunciones2 As New dllData

    Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
        Me.PaperKind = System.Drawing.Printing.PaperKind.Legal
        texto.LoadFile(Application.StartupPath & "\" & ConfigurationManager.AppSettings("Ordenes").ToString & GetCurrentColumnValue("CONTENIDO"))
        XrRichText1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
    End Sub
    Private Sub R_ACTA_GENERAL_DataSourceDemanded(sender As Object, e As EventArgs) Handles Me.DataSourceDemanded
        Try
            DataSet_pCAT_ACTAS_VERIFICACION_TEST_B1.Clear()
            Dim myDA = New SqlClient.SqlDataAdapter("pCAT_ACTAS_VERIFICACION_TEST_B", oFunciones.sConexion)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure

            If Parameters.Count > 0 Then
                For nParam = 0 To Parameters.Count - 1
                    myDA.SelectCommand.Parameters.AddWithValue("@" & Parameters.Item(nParam).Name, Parameters.Item(nParam).Value)
                Next
            End If
            myDA.Fill(DataSet_pCAT_ACTAS_VERIFICACION_TEST_B1.pCAT_ACTAS_VERIFICACION_TEST_B)
            myDA.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Cargar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub
End Class