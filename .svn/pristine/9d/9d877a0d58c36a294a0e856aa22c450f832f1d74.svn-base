Imports System
Imports Wisej.Web
Imports Wisej.Web.Ext.RibbonBar

Public Class add_Verificadores

    Dim oFunciones As New dllData
    Private Sub llenarCambo()
        oFunciones.Llenar_CatalogosXprocedureYParams2("pCAT_JURISDICCION_B", "JURISDICCION", "CVE_JURISDICCION", JURISDICCION)
    End Sub


    Private Sub GuardarVericador()
        Try
            ReDim oFunciones.ParametersX_Global(9)
            oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@NOMBRE", NOMBRE.Text)
            oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@APELLIDOS", APELLIDOS.Text)
            oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@SEXO", SEXO.Text)
            oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@FECHA_NACIMIENTO", NACIMIENTO.Value)
            oFunciones.ParametersX_Global(4) = New SqlClient.SqlParameter("@GRADO_ESTUDIO", GRADO.Text)
            oFunciones.ParametersX_Global(5) = New SqlClient.SqlParameter("@CORREO", CORREO.Text)
            oFunciones.ParametersX_Global(6) = New SqlClient.SqlParameter("@TELEFONO", TELEFONO.Text)
            oFunciones.ParametersX_Global(7) = New SqlClient.SqlParameter("@CVE_JURISDICCION", JURISDICCION.SelectedValue)
            oFunciones.ParametersX_Global(8) = New SqlClient.SqlParameter("@CLAVE_TRABAJADOR", CLAVE_TRABAJADOR.Text)
            oFunciones.ParametersX_Global(9) = New SqlClient.SqlParameter("@CVE_PERSONA", CVE_PERSONA.Text)




            Dim result As Integer = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_VERIFICADORES_G", "@PARAM", oFunciones.ParametersX_Global, False, SqlDbType.Int)
            If result <> Nothing Then

                Wisej.Web.MessageBox.Show("Verificador con numero consecutivo :  " & result & "    nombre : " & NOMBRE.Text & " " & APELLIDOS.Text & " Ha sido almacenado correctamente", "Guardar", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Information)
            Else
                Wisej.Web.MessageBox.Show("Ocurrio un error mientras se almacenaba la informacion", "Guardar", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Wisej.Web.MessageBox.Show("Error al guardar, ERROR: " & ex.Message, "Guardar", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
        End Try


    End Sub
    Private Function FormHasError() As Boolean

        Dim errores As Integer = 0
        Dim MSJ As String = "campo requeridos "
        If NOMBRE.Text.Trim = String.Empty Then
            ErrorProvider1.SetError(NOMBRE, MSJ)
            errores = errores + 1
        Else
            ErrorProvider1.SetError(NOMBRE, Nothing)
        End If

        If APELLIDOS.Text.Trim = String.Empty Then
            ErrorProvider1.SetError(APELLIDOS, MSJ)
            errores = errores + 1
        Else
            ErrorProvider1.SetError(APELLIDOS, Nothing)
        End If
        If NACIMIENTO.Text.Trim = String.Empty Then
            ErrorProvider1.SetError(NACIMIENTO, MSJ)
            errores = errores + 1
        Else
            ErrorProvider1.SetError(NACIMIENTO, Nothing)
        End If

        If SEXO.Text.Trim = String.Empty Then
            ErrorProvider1.SetError(SEXO, MSJ)
            errores = errores + 1
        Else
            ErrorProvider1.SetError(SEXO, Nothing)
        End If


        If JURISDICCION.Text.Trim = String.Empty Then
            ErrorProvider1.SetError(JURISDICCION, MSJ)
            errores = errores + 1
        Else
            ErrorProvider1.SetError(JURISDICCION, Nothing)
        End If


        If errores = 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub limpiar()
        NOMBRE.Text = ""
        APELLIDOS.Text = ""
        CLAVE_TRABAJADOR.Text = ""
        GRADO.SelectedIndex = -1
        CORREO.Text = ""
        TELEFONO.Text = ""
        NACIMIENTO.Value = Nothing
        SEXO.SelectedIndex = -1
        JURISDICCION.SelectedIndex = -1
        GUARDAR.Enabled = False

    End Sub

    Private Sub add_Verificadores_Load(sender As Object, e As EventArgs) Handles Me.Load
        oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_JURISDICCION_B", "CVE_JURISDICCION", "JURISDICCION", JURISDICCION)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click

        If FormHasError() Then
            GuardarVericador()
            limpiar()


        End If
    End Sub

    Private Sub NUEVO_Click(sender As Object, e As EventArgs) Handles NUEVO.Click
        limpiar()
        GUARDAR.Enabled = True

    End Sub
End Class
