Imports System
Imports Wisej.Web

Public Class ADD_LOTES
    Dim oFunciones As New dllData
    Private Sub ADD_LOTES_Load(sender As Object, e As EventArgs) Handles Me.Load
        llenarCombos()
        ingresar_operador()
        DateTimeFECHA.Value = Date.Now.Date
        DateTimeFECHA.MaxDate = Date.Now.Date

    End Sub
    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick

        Select Case e.Item.Name
            Case "NUEVO"
                limpiar()
                NUEVO.Enabled = False
            Case "GUARDAR"
                Save_lote()
                limpiar()
                NUEVO.Enabled = True
            Case "SALIR"
                Me.Close()


        End Select

    End Sub
    Private Sub ingresar_operador()
        TextBoxOPERADOR.Text = Application.Session("Nombre") & "% cve (" & Application.Session("CVE_OPERADOR") & ")"
    End Sub
    Private Sub limpiar()

        DateTimeFECHA.Value = Date.Now.Date
        CombosaxJURISDICCIONES.SelectedIndex = -1


    End Sub
    Private Sub llenarCombos()
        Try

            oFunciones.Llenar_listbox("pCAT_JURISDICCION_B", "CVE_JURISDICCION", "JURISDICCION", CombosaxJURISDICCIONES)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Cargar listas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Save_lote()
        Try
            ReDim oFunciones.ParametersX_Global(4)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_PAQUETE", TextBoxCLAVE.Text)
            oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@CVE_OPERADOR", Application.Session("CVE_OPERADOR"))
            oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@CVE_JURISCCION", CombosaxJURISDICCIONES.SelectedValue)


            Dim parametro As String = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_PAQUETES_ACTAS_G", "@param", oFunciones.ParametersX_Global, False, SqlDbType.Int)

            If parametro = Nothing Then
                MessageBox.Show("Datos no guardados", "Guardar Orden", MessageBoxButtons.OK, MessageBoxIcon.Warning)



            Else

                MessageBox.Show("Datos guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

End Class
