Imports System.Drawing.Printing
Imports Wisej.Web
Public Class R_ACTA_GENERAL
    Dim oFunciones, oFunciones2 As New dllData

    Private Sub Detail_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail.BeforePrint
        Me.PaperKind = System.Drawing.Printing.PaperKind.Legal

        'Dim CONCEPTOS(0) As String
        'Dim CONCEPTO As String

        ''oFunciones.Conectar()
        ''Dim cDataReader As Data.SqlClient.SqlDataReader
        ''Try
        ''    oFunciones.cCommand = New SqlClient.SqlCommand("pCAT_ACTAS_VERIFICACION_TEST_B", oFunciones.cConnect)
        ''    oFunciones.cCommand.CommandType = CommandType.StoredProcedure
        ''    cDataReader = oFunciones.cCommand.ExecuteReader(CommandBehavior.CloseConnection)
        ''    If cDataReader.HasRows Then
        ''        While (cDataReader.Read)
        'CONCEPTO = GetCurrentColumnValue("CONCEPTO")
        'CONCEPTOS = CONCEPTO.Split(",")

        'XrTableCell4.Text = oFunciones2.Concepto("PLANTILLA_EJEMPLO", CONCEPTOS)
        ''        End While
        ''   End If

        ''Catch ex As SystemException
        ''    'MessageBox.show("Error:  " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ''Finally
        ''    If IsNothing(cDataReader) = False Then
        ''        If cDataReader.IsClosed = False Then cDataReader.Close()
        ''    End If
        ''    oFunciones.Desconectar()
        ''End Try

        'texto.Rtf = GetCurrentColumnValue("CONTENIDO")
        texto.LoadFile(Application.StartupPath & "\" & ConfigurationManager.AppSettings("Ordenes").ToString & GetCurrentColumnValue("CONTENIDO"))
        'texto.LoadFile("C:\Users\END USER\Desktop\x\pepe.rtf")
        ' texto.SaveFile("C:\Users\END USER\Desktop\x\pepe.rtf")
        XrRichText1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
    End Sub

    Private Sub R_ACTA_GENERAL_AfterPrint(sender As Object, e As EventArgs) Handles MyBase.AfterPrint
        Try
            'XrRichText1.TextAlignment.MiddleRight
        Catch ex As Exception

        End Try

    End Sub

    Private Sub R_ACTA_GENERAL_DataSourceDemanded(sender As Object, e As EventArgs) Handles Me.DataSourceDemanded
        Try
            DataSet_pCAT_ACTAS_VERIFICACION_TEST_B1.Clear()
            Dim myDA = New SqlClient.SqlDataAdapter("pCAT_ACTAS_VERIFICACION_TEST_B", oFunciones.sConexion)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure

            If Parameters.Count > 0 Then
                For nParam = 0 To Parameters.Count - 1
                    myDA.SelectCommand.Parameters.AddWithValue("@" & Parameters.Item(nParam).Name, Parameters.Item(Parameters.Item(nParam).Name).Value)
                Next
            End If

            myDA.Fill(DataSet_pCAT_ACTAS_VERIFICACION_TEST_B1.pCAT_ACTAS_VERIFICACION_TEST_B)
            myDA.Dispose()
        Catch ex As Exception
            'ex.Message
        End Try

    End Sub
End Class