Imports System
Imports Wisej.Web
Imports Wisej.Web.Ext.RibbonBar
Imports System.Drawing

Public Class Cat_Normas
    Dim oFunciones, oFunciones2 As New dllData
    Dim estado As Boolean = True
    Private Sub Cat_Normas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        If RadioButton1.Checked Then
            'DGVNormas.CurrentRow.Cells("Desabilitar").Value = Image.FromFile("Resources\Images\Menu\64\palancaFalse.png")
        End If
        oFunciones.loadConfigDataGridView(DGVNormas)
        oFunciones.ConfigurarBindingNavigator(BindingNavigator1, False, False, True, True)
        FiltroGrillaSax1.meDatagrid = DGVNormas
        cargarTabla()




    End Sub

    Private Sub RibbonBar1_ItemClick(sender As Object, e As RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Text
            Case "Nuevo"
                Dim nuevo = New Cat_New_Normas
                nuevo.Show()
                AddHandler nuevo.FormClosed, AddressOf cargarTabla
            Case "Actualizar"
                cargarTabla()
            Case "Salir"
                Me.Close()
        End Select

    End Sub


    Public Sub cargarTabla()
        Try
            Me.DataSet_pCAT_NORMAS_B.pCAT_NORMAS_B.Clear()

            Dim myDA = New SqlClient.SqlDataAdapter("pCAT_NORMAS_B", oFunciones.sConexion)
            myDA.SelectCommand.Parameters.AddWithValue("@HABILITADO", estado)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_pCAT_NORMAS_B.pCAT_NORMAS_B)
            myDA.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Cargar tabla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub





    Private Sub DGVNormas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVNormas.CellClick
        If e.ColumnIndex <> -1 Then
            If e.ColumnIndex = 0 Then
                Try
                    ReDim oFunciones.ParametersX_Global(3)
                    oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_NORMA", sender.Item("CVE_NORMAS", e.RowIndex).value)
                    oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@HABILITADO", Not sender.Item("HABILITADO", e.RowIndex).value)
                    oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@NOMBRE", sender.Item("NORMA", e.RowIndex).value)
                    oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@DESCRIPCION", sender.Item("DESCRIPCION", e.RowIndex).value)

                    If oFunciones.fGuardar_O_EliminarXProcedure("pCAT_NORMAS_G", "@PARAMETRO", oFunciones.ParametersX_Global, False) Then
                        If estado Then
                            oFunciones.AlertBox("Datos Desavilitado Correctamente...", MessageBoxIcon.Information)
                        Else
                            oFunciones.AlertBox("Datos Habilitado Correctamente...", MessageBoxIcon.Information)

                        End If
                        cargarTabla()
                    Else
                        oFunciones.AlertBox("Datos No guardados", MessageBoxIcon.Error)
                    End If


                Catch ex As Exception

                    If Application.Session("USUARIO") = "ADMIN" Then
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                End Try
            ElseIf e.ColumnIndex = 1 Then
                Try
                    Dim nuevo = New Cat_New_Normas
                    Dim CVE_NORMA As Integer = sender.Item("CVE_NORMAS", e.RowIndex).value
                    Dim NOMBRE As String = sender.Item("NORMA", e.RowIndex).value
                    Dim DESCRIPCION As String = sender.Item("DESCRIPCION", e.RowIndex).value
                    nuevo.Actualizartablas(CVE_NORMA, NOMBRE, DESCRIPCION)
                    AddHandler nuevo.FormClosed, AddressOf cargarTabla
                    nuevo.Show()

                Catch ex As Exception

                    If Application.Session("USUARIO") = "ADMIN" Then
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                End Try
            ElseIf e.ColumnIndex = 2 Then
                Try
                    ReDim oFunciones.ParametersX_Global(1)
                    oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_NORMA", sender.Item("CVE_NORMAS", e.RowIndex).value)
                    oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@HABILITADO", Not sender.Item("HABILITADO", e.RowIndex).value)


                    If oFunciones.fGuardar_O_EliminarXProcedure("pCAT_NORMAS_I", "@PARAMETRO", oFunciones.ParametersX_Global, False) Then

                        oFunciones.AlertBox("Datos Eliminado Correctamente...", MessageBoxIcon.Information)

                        cargarTabla()
                    Else
                        oFunciones.AlertBox("Datos No guardados", MessageBoxIcon.Error)
                    End If


                Catch ex As Exception

                    If Application.Session("USUARIO") = "ADMIN" Then
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                End Try
            End If
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If sender.Checked = True Then
            estado = True
            Eliminar.Visible = False
            Me.Desabilitar.CellImage = Global.DPCRS.My.Resources.Resources.palancaTrue
            cargarTabla()
        End If
    End Sub



    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        If sender.Checked = True Then
            estado = False
            Me.Desabilitar.CellImage = Global.DPCRS.My.Resources.Resources.palancaFalse
            Eliminar.Visible = True
            cargarTabla()
        End If
    End Sub

End Class
