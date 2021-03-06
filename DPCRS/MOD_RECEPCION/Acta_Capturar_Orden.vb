Imports Wisej.Web

Public Class Acta_Capturar_Orden
    Dim oFunciones As New dllData
    Public cve_orden As String
    Private urlArchivoPdf As String = ""
    Private pdfAGuardar As String

    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Text
            Case "Nuevo"
                Limpiarcampos()
            Case "Guardar"
                Guardar()
            Case "Buscar"
                oFunciones.Mostrar_Formulario("Cat_Ordenes")

            Case "Salir"
                Me.Close()
        End Select
    End Sub

    Private Sub Guardar()
        Try
            If ValidarCampos() Then
                Dim fecha As DateTime = DateTimePicker1.Value.Date
                ReDim oFunciones.ParametersX_Global(5)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@folio", txtFolio.Text.ToUpper)
                oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@url_archivo", txtFolio.Text & ".pdf")
                oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@estatus", ComboBoxESTATUS.Text)
                oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@cve_operador", Application.Session("Cve_Operador"))
                oFunciones.ParametersX_Global(4) = New SqlClient.SqlParameter("@emision", fecha)
                oFunciones.ParametersX_Global(5) = New SqlClient.SqlParameter("@emision_cargo", ComboBoxVericador.SelectedValue)

                If oFunciones.fGuardar_O_EliminarXProcedure("pCAT_ORDENES_VERIFICACION_G", "@parametro", oFunciones.ParametersX_Global, False, False) Then
                    MessageBox.Show("Datos guardados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No se ha podido guardar los datos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("No pueden ir vacios los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Function ValidarCampos() As Boolean
        ValidarCampos = True
        If txtFolio.Text = Nothing Then ValidarCampos = False
        If Button1.Text = "nombre_archivo.ext" Then ValidarCampos = False
    End Function


    Private Sub OpenFileDialog1_Closed(sender As Object, e As UploadedEventArgs) Handles Button1.Uploaded
        Dim objFileDialog As Upload = CType(sender, Upload)
        Dim mstrDirectory As String = ConfigurationManager.AppSettings("Ordenes").ToString
        If e.Files.Count > 0 Then
            Dim archivoPdf As HttpPostedFile = DirectCast(e.Files(0), HttpPostedFile)
            If archivoPdf.ContentLength > 0 Then
                If archivoPdf.FileName.ToUpper.EndsWith(".PDF") Then

                    pdfAGuardar = System.IO.Path.GetFileName(txtFolio.Text & ".pdf")
                    urlArchivoPdf = System.IO.Path.Combine(mstrDirectory, System.IO.Path.GetFileName(txtFolio.Text & ".pdf"))
                    Dim consecutivo = 0
                    While (System.IO.File.Exists(urlArchivoPdf))
                        pdfAGuardar = System.IO.Path.GetFileNameWithoutExtension(txtFolio.Text & ".pdf") & "(" & consecutivo & ")" & System.IO.Path.GetExtension(archivoPdf.FileName)
                        urlArchivoPdf = System.IO.Path.Combine(mstrDirectory, pdfAGuardar)
                        consecutivo += 1
                    End While


                    archivoPdf.SaveAs(Application.StartupPath & "\" & urlArchivoPdf)
                    Button1.Text = pdfAGuardar

                Else
                    MessageBox.Show("Formato inválido", "Agregar PDF", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If

        End If
    End Sub
    Private Sub Limpiarcampos()
        txtFolio.Text = Nothing
        pdfAGuardar = Nothing
    End Sub

    Private Sub Acta_Capturar_Orden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        llenarcombos()

    End Sub
    Private Sub llenarcombos()
        ReDim oFunciones.ParametersX_Global(1)
        oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Rol", "R4")
        oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_OPERADORES_B", "CVE_OPERADOR", "NOMBRE", ComboBoxVericador, oFunciones.ParametersX_Global)
    End Sub

    Private Sub dt_fecha_emision_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class

