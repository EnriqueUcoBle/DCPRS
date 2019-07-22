Imports System
Imports Wisej.Web

Public Class Perfil
    Dim oFunciones As New dllData
    Private Sub Perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarDatos()

    End Sub
    Private Sub llenarDatos()
        Me.DataSetOPERADOR_DATOS.pCAT_OPERADORES_B_DATOS.Clear()


        Dim myDA = New SqlClient.SqlDataAdapter("pCAT_OPERADORES_B_DATOS", oFunciones.sConexion)
        myDA.SelectCommand.Parameters.AddWithValue("@CVE", Application.Session("CVE_OPERADOR"))
        myDA.SelectCommand.CommandType = CommandType.StoredProcedure
        myDA.Fill(Me.DataSetOPERADOR_DATOS.pCAT_OPERADORES_B_DATOS)
        myDA.Dispose()
        TextBoxNOMBRE.Text = DataSetOPERADOR_DATOS.Tables(0).Rows(0).Item("XNOMBRE")
        TextBoxCORREO.Text = DataSetOPERADOR_DATOS.Tables(0).Rows(0).Item("CORREO")
        TextBoxESTUDIO.Text = DataSetOPERADOR_DATOS.Tables(0).Rows(0).Item("GRADO_ESTUDIO")
        TextBoxFECHA_CREACION.Text = DataSetOPERADOR_DATOS.Tables(0).Rows(0).Item("Fecha_Alta")
        TextBoxJURISDICCION.Text = DataSetOPERADOR_DATOS.Tables(0).Rows(0).Item("JURISDICCION")
        TextBoxSEXO.Text = DataSetOPERADOR_DATOS.Tables(0).Rows(0).Item("SEXO")
        TextBoxTELEFONO.Text = DataSetOPERADOR_DATOS.Tables(0).Rows(0).Item("TELEFONO")
        TextBoxTIPO.Text = DataSetOPERADOR_DATOS.Tables(0).Rows(0).Item("ROL")
        TextBoxNACIMIENTO.Text = DataSetOPERADOR_DATOS.Tables(0).Rows(0).Item("FECHA_NACIMIENTO")
        TextBoxCLAVE_TRABAJADOR.Text = DataSetOPERADOR_DATOS.Tables(0).Rows(0).Item("CLAVE_TRABAJADOR")

    End Sub
    Private Sub actulaizarDatos()

    End Sub
End Class
