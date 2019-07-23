﻿Imports System
Imports Wisej.Web

Public Class Cat_juridicciones_get
    Dim oFunciones As New dllData

    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Text
            Case "Nuevo"
                limpiarFormulario()
                activarFormulario()

            Case "Cancelar"
                desactivarFormulario()
                limpiarFormulario()

            Case "Guardar"
                If guardar() Then
                    desactivarFormulario()
                    cargarTabla()
                Else
                    Wisej.Web.MessageBox.Show("Error al guardar, verifique los datos ", "Guardar", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
                End If

            Case "Salir"

                Me.Close()
        End Select

    End Sub
    Private Sub desactivarFormulario()
        RRBguardar.Visible = False
        RRBnuevo.Visible = True
        RRBcancelar.Visible = False
        ComboBoxMUNICIPIO.ReadOnly = True
        ComboBoxCOLONIA.ReadOnly = True
        TextBoxCP.ReadOnly = True
        TextBoxDIRECCION.ReadOnly = True
        TextBoxCLAVE.ReadOnly = True
        TextBoxTELEFONO.ReadOnly = True
        CheckBoxHABILITADO.ReadOnly = True
    End Sub
    Private Sub activarFormulario()
        RRBguardar.Visible = True
        RRBnuevo.Visible = False
        RRBcancelar.Visible = True
        ComboBoxMUNICIPIO.ReadOnly = False
        ComboBoxCOLONIA.ReadOnly = False
        TextBoxCP.ReadOnly = False
        TextBoxDIRECCION.ReadOnly = False
        TextBoxCLAVE.ReadOnly = False
        TextBoxTELEFONO.ReadOnly = False
        CheckBoxHABILITADO.ReadOnly = False
    End Sub
    Private Sub limpiarFormulario()

        ComboBoxMUNICIPIO.Text = ""
        ComboBoxCOLONIA.Text = ""
        TextBoxCP.Text = ""
        TextBoxDIRECCION.Text = ""
        TextBoxCLAVE.Text = ""
        TextBoxTELEFONO.Text = ""
        CheckBoxHABILITADO.Text = ""
    End Sub
    Private Sub ComboBoxCOLONIA_SelectedIndexChanged(sender As Object, e As EventArgs)
        If ComboBoxCOLONIA.SelectedIndex = -1 Then Exit Sub
        TextBoxCP.Text = oFunciones.obetenerDescripcion3(ComboBoxCOLONIA, "CP")
    End Sub



    Private Function guardar() As Boolean
        Try
            ReDim oFunciones.ParametersX_Global(6)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_COLONIA", ComboBoxCOLONIA.SelectedValue)
            oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@TELEFONO", TextBoxTELEFONO.Text.ToString)
            oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@CLAVE", TextBoxCLAVE.Text)
            oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@DIRECCION", TextBoxDIRECCION.Text)
            oFunciones.ParametersX_Global(4) = New SqlClient.SqlParameter("@HABILITADO", CheckBoxHABILITADO.Checked)
            oFunciones.ParametersX_Global(5) = New SqlClient.SqlParameter("@cve_jurisdiccion", CVE.Text)
            oFunciones.ParametersX_Global(6) = New SqlClient.SqlParameter("@NOMBRE", NOMBRE.Text)
            Dim result = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_JURISDICCION_G", "@param", oFunciones.ParametersX_Global, False, SqlDbType.Int)
            If result <> Nothing Then
                MessageBox.Show("Retorna :" & result & ":  como ID", "guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True

            Else
                Return False
            End If

        Catch ex As Exception
            Wisej.Web.MessageBox.Show("Error al guardar, ERROR: " & ex.Message, "Guardar", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
        End Try
    End Function
    Private Sub cargarTabla()

        Try
            Me.DataSet_JURIDICCION.pCAT_JURISDICCION_B.Clear()
            Dim myDA = New SqlClient.SqlDataAdapter("pCAT_JURISDICCION_B", oFunciones.sConexion)
            myDA.SelectCommand.Parameters.AddWithValue("@habilitado", 1)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_JURIDICCION.pCAT_JURISDICCION_B)
            myDA.Dispose()


            If DataGridView1.RowCount > 0 Then
                DataGridView1.CurrentRow.Selected = False
            End If


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Cargar tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub Cat_juridicciones_get_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargarTabla()
        oFunciones.loadConfigDataGridView(DataGridView1)
        oFunciones.ConfigurarBindingNavigator(BindingNavigator1, False, False, True, True)
        FiltroGrillaSax1.meDatagrid = DataGridView1
    End Sub

    Private Sub ComboBoxMUNICIPIO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMUNICIPIO.SelectedIndexChanged
        If ComboBoxMUNICIPIO.SelectedIndex = -1 Then Exit Sub
        ReDim oFunciones.ParametersX_Global(2)
        oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@MUNICIPIO", ComboBoxMUNICIPIO.Text)
        oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@ESTADO", "TABASCO")
        oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_COLONIAS_B", "CVE_COLONIA", "ASENTAMIENTO", ComboBoxCOLONIA, oFunciones.ParametersX_Global)




    End Sub

    Private Sub ComboBoxCOLONIA_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBoxCOLONIA.SelectedIndexChanged
        If ComboBoxCOLONIA.SelectedIndex = -1 Then Exit Sub
        TextBoxCP.Text = oFunciones.obetenerDescripcion3(ComboBoxCOLONIA, "CP")
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class
