Imports Wisej.Web
Imports Wisej.Web.Ext.RibbonBar
Imports System.Drawing

Public Class Cambiar_Contrasena
    Dim oFunciones As New dllData
    Private Sub Cambiar_Contrasena_Load(sender As Object, e As EventArgs) Handles Me.Load
        RBNGUARDAR.Enabled = False
    End Sub
    Private Sub RibbonBar1_ItemClick(sender As Object, e As RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Text
            Case "Guardar"
                Guardar()
            Case "Salir"
                Me.Close()
        End Select
    End Sub
    Sub Limpiar()
        Me.cContrasena_New.Text = Nothing
        Me.cContrasena_Confirma.Text = Nothing
        Me.GroupBox1.Enabled = False
        cError.Visible = False
        RBNGUARDAR.Enabled = False
        Me.cContrasena.Enabled = True
        cContrasena.Text = Nothing
        cContrasena.Focus()
    End Sub
    Sub Guardar()
        If Validar() Then
            If Me.cContrasena.Text.Trim <> Nothing Then
                ReDim oFunciones.ParametersX_Global(2)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Operador", Application.Session("Cve_Operador"))
                oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@Contrasena", Me.cContrasena_New.Text)
                oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@PassphraseEnteredByUser", dllData.sConstante_KEY)
                If oFunciones.fGuardar_O_EliminarXProcedure("pCAT_OPERADORES_CAMBIA_CONTRASENA", "@Parametro", oFunciones.ParametersX_Global) Then
                    MessageBox.Show("Nueva contraseña guardada", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                End If
            End If
        End If

    End Sub
    Private Sub cContrasena_EnterKeyDown(objSender As Object, objArgs As KeyEventArgs) Handles cContrasena.KeyDown
        If objArgs.KeyCode <> Keys.Enter Then Exit Sub
        If Me.cContrasena.Text.Trim <> Nothing Then
            Label4.ForeColor = Color.Black
            Label4.Text = "Presione enter sobre el campo para continuar"
            If oFunciones.Login(Application.Session("Cve_Operador"), Me.cContrasena.Text) Then
                Me.GroupBox1.Enabled = True
                Me.cContrasena.Enabled = False
                Me.cContrasena_New.Focus()
                cError.Visible = False
            Else
                Label4.ForeColor = Color.Red
                Label4.Text = "Contraseña incorrecta"
            End If
        Else
            MessageBox.Show("Escriba la Contraseña Actual")
        End If
    End Sub

    Private Sub cContrasena_New_TextChanged(sender As Object, e As EventArgs) Handles cContrasena_New.TextChanged
        RBNGUARDAR.Enabled = True
        cContrasena_Confirma.SelectAll()
    End Sub
    Private Function Validar() As Boolean
        Validar = False
        If cContrasena_New.Text.Trim <> Nothing Then
            If cContrasena_Confirma.Text.Trim <> Nothing Then
                If cContrasena_New.Text.Trim.ToUpper.Equals(cContrasena_Confirma.Text.Trim.ToUpper) Then
                    'If cContrasena_New.Text.Trim.ToUpper = cContrasena_Confirma.Text.Trim.ToUpper Then
                    cError.Visible = False
                    'Me.RBBGuardar.Enabled = True
                    Validar = True
                Else
                    cError.Text = "Contraseña no coincide (NUEVA Y CONFIRMA)"
                    cError.Visible = True
                    'Me.RBBGuardar.Enabled = False
                End If
            Else
                MessageBox.Show(Nothing)
                MessageBox.Show("Confirmar la Nueva Contraseña")
                'Exit Sub
            End If
        Else
            MessageBox.Show(Nothing)
            MessageBox.Show("Escriba la Nueva Contraseña ")
            'Exit Sub
        End If

        Return Validar
    End Function


End Class

