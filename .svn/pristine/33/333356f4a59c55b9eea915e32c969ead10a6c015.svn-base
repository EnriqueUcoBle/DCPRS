Imports Wisej.Web

Public Class C_contra
    Dim ofunciones As New dllData
    Dim cveOperador As String = ""
    Dim Cprocesa As Boolean
    Dim agregandoNuevo As Boolean = False
    Dim posicion As Integer = -1
    Public Const sConstante_KEY = "$$SAXSOFT.COM_Y_ISISCOL$$"

    Private Sub RibbonBar1_ButtonClick(sender As Object, e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Text
            Case "Guardar"
                Guardar()

            Case "Salir"
                Close()
        End Select
    End Sub

    Private Function CheckValid() As Boolean
        CheckValid = True

        If TBContrasena.Text = "" Then
            Me.ErrorProvider1.SetError(TBContrasena, "Escriba Una Nueva Contraseña")
            CheckValid = False
        Else
            Me.ErrorProvider1.SetError(TBContrasena, Nothing)
        End If
    End Function
    Sub limpiar()

        TBContrasena.Text = Nothing
        txtconfirmar.Text = Nothing
        txtN_contra.Text = Nothing



        Me.Tag = Nothing


    End Sub


    Sub Actualizar()
        Try
            ReDim ofunciones.ParametersX_Global(5)
            ofunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_OPERADOR", Application.Session("Cve_Operador"))
            ofunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@ESTATUS", 1)
            ofunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@CONTRASENA", txtN_contra.Text)
            ofunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@PassphraseEnteredByUser", ofunciones.sConstante_KEY)
            ofunciones.ParametersX_Global(4) = New SqlClient.SqlParameter("@CVE_ROL", Application.Session("Cve_Rol"))
            cveOperador = ofunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_OPERADORES_G2", "@PARAMETRO", ofunciones.ParametersX_Global, False, SqlDbType.VarChar, 50)

            If (cveOperador <> Nothing) Then
                cveOperador = Me.Tag
                MessageBox.Show("Datos guardados correctamente", "Guardar cambios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
            Else
                MessageBox.Show("Datos no guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Sub Guardar()
        If CheckValid() Then
            Try
                ReDim ofunciones.ParametersX_Global(5)

                ofunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_OPERADOR", Application.Session("Cve_Operador"))
                ofunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@CONTRASENA", Me.TBContrasena.Text)
                ofunciones.ParametersX_Global(2) = New Data.SqlClient.SqlParameter("@PassphraseEnteredByUser", sConstante_KEY)

                cveOperador = ofunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pLOGIN", "@Parametro", ofunciones.ParametersX_Global, , SqlDbType.VarChar, 50)
                If cveOperador <> Nothing Then


                    If txtN_contra.Text = txtconfirmar.Text Then
                        Cprocesa = True
                        Actualizar()

                    Else
                        Cprocesa = False

                        MessageBox.Show("La contraseña no son iguales", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        limpiar()
                    End If
                Else
                    MessageBox.Show("La contraseña es incorrecta", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    limpiar()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End Try
        End If

    End Sub

    Sub cargar()
        'Try

        '    DataSet_pCAT_OPERADORES_B.Clear()
        '    Dim myDA = New SqlClient.SqlDataAdapter("pCAT_OPERADORES_B", ofunciones.sConexion)
        '    myDA.SelectCommand.CommandType = CommandType.StoredProcedure
        '    myDA.SelectCommand.Parameters.AddWithValue("@PassphraseEnteredByUser", ofunciones.sConstante_KEY)

        '    myDA.Fill(DataSet_pCAT_OPERADORES_B.pCAT_OPERADORES_B)
        '    myDA.Dispose()
        'Catch ex As Exception
        '    MessageBox.show("Error: " & ex.Message, "Inicio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub


    Private Sub CBMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles CBMostrar.CheckedChanged
        'TBContrasena.UseSystemPasswordChar = Not CBMostrar.Checked

        If CBMostrar.Checked Then
            TBContrasena.InputType.Type = Wisej.Web.TextBoxType.Text
        Else
            TBContrasena.InputType.Type = Wisej.Web.TextBoxType.Password
        End If
    End Sub


End Class

