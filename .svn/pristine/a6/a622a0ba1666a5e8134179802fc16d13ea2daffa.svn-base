
Imports Wisej.Web

Public Class Licencia

    Dim oFunciones As New dllData
    Private Sub Busqueda_Secreta_Load(sender As Object, e As EventArgs) Handles Me.Load

        TextBox1.Text = oFunciones.encriptar128BitRijndael(oFunciones.Busqueda_Secreta, oFunciones.sConstante_KEY)
        Application.Session("LICENSE_READY") = "NO"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sPASA As String
        sPASA = oFunciones.desencriptar128BitRijndael(txtActivacion.Text, oFunciones.desencriptar128BitRijndael(TextBox1.Text, oFunciones.sConstante_KEY))


        If sPASA <> "" Then
            Dim CODIGO As String()
            CODIGO = Split(sPASA, "/")
            If CInt(Format(Now, "yyyyMMdd")) <= CInt(CODIGO(2)) Then

                txtResultado.Text = "fecha valida"
                ReDim oFunciones.ParametersX_Global(5)

                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@SERIAL ", txtActivacion.Text)


                oFunciones.fGuardar_O_EliminarXProcedure("pLICENSE_G", "@Parametro", oFunciones.ParametersX_Global, False)

                Application.Session("LICENSE_READY") = "YES"
                Me.Close()
            Else
                txtResultado.Text = "Serial Caducado"
                Application.Session("LICENSE_READY") = "NO"
            End If

        Else

            Application.Session("LICENSE_READY") = "NO"
            txtResultado.Text = "Serial no valido"
        End If


    End Sub


End Class

