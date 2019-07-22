Imports System
Imports Wisej.Web

Public Class Add_Muestra
    Dim oFunciones As New dllData
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AddAnalisis.Click
        Dim form = New Add_Tipo_Analisis
        form.Show()
        AddHandler form.FormClosed, AddressOf llenarCombo
    End Sub

    Private Sub llenarCombo()
        oFunciones.Llenar_listbox("pCAT_TIPO_ANALISIS_B", "CVE_TIPO_ANALISIS", "NOMBRE", TIPO_ANALISIS)
        oFunciones.Llenar_listbox("pCAT_TIPO_MUESTRAS_B", "CVE_TIPO_MUESTRAS", "NOMBRE", TIPO_MUESTRA)
    End Sub

    Private Sub TIPO_ANALISIS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TIPO_ANALISIS.SelectedIndexChanged
        If TIPO_ANALISIS.SelectedIndex = -1 Then Exit Sub
        DESCRIPCION_TIPO_ANALISIS.Text = oFunciones.obetenerDescripcion4(TIPO_ANALISIS, "DESCRIPCION")
    End Sub

    Private Sub TIPO_MUESTRA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TIPO_MUESTRA.SelectedIndexChanged
        If TIPO_MUESTRA.SelectedIndex = -1 Then Exit Sub
        DESCRIPCION_TIPO_MUESTRA.Text = oFunciones.obetenerDescripcion4(TIPO_MUESTRA, "DESCRIPCION")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AÑADIR_ITEM.Click
        If _Validar() Then

        End If
    End Sub

    Private Sub AddMuestra_Click(sender As Object, e As EventArgs) Handles AddMuestra.Click
        Dim form = New Add_Muestras_Tipo
        form.Show()
        AddHandler form.FormClosed, AddressOf llenarCombo
    End Sub

    Private Sub Add_Muestra_Load(sender As Object, e As EventArgs) Handles Me.Load
        llenarCombo()

    End Sub




    Private Function _Validar() As Boolean
        Dim cont As Integer = 0

        If DESCRIPCION.Text.Length >= 10 Then
            ErrorProvider1.SetError(DESCRIPCION, "debe contener una descripcion")
            cont = cont + 1
        Else
            ErrorProvider1.SetError(DESCRIPCION, Nothing)
        End If
        If TIPO_MUESTRA.SelectedIndex = -1 Then
            ErrorProvider1.SetError(TIPO_MUESTRA, "debe seleccionar un tipo de muestra")
            cont = cont + 1

        Else
            ErrorProvider1.SetError(TIPO_MUESTRA, Nothing)

        End If
        If TIPO_ANALISIS.SelectedIndex = -1 Then
            ErrorProvider1.SetError(TIPO_ANALISIS, "debe seleccionar un tipo de analisis")
            cont = cont + 1
        Else
            ErrorProvider1.SetError(TIPO_ANALISIS, Nothing)
        End If



        If cont = 0 Then

            Return True
        Else
            Return False


        End If

    End Function

    Private Sub limpiar()
        TIPO_ANALISIS.SelectedIndex = -1
        TIPO_ANALISIS.Enabled = False
        TIPO_MUESTRA.SelectedIndex = -1
        TIPO_MUESTRA.Enabled = False
        DESCRIPCION_TIPO_ANALISIS.Text = ""
        DESCRIPCION_TIPO_ANALISIS.Enabled = False
        DESCRIPCION_TIPO_MUESTRA.Text = ""
        DESCRIPCION_TIPO_MUESTRA.Enabled = False
        DESCRIPCION.Text = ""
        DESCRIPCION.Enabled = False
        CLAVE_VS.Text = ""
        CLAVE_VS.Enabled = False
        MARCA.Text = ""
        MARCA.Enabled = False
        LOTE.Text = ""
        LOTE.Enabled = False
        CANTIDAD.Value = 0
        CANTIDAD.Enabled = False
        FECHA_CADUCIDAD.Value = ""
        FECHA_CADUCIDAD.Enabled = False
    End Sub
    Private Sub habilitar()
        TIPO_ANALISIS.SelectedIndex = -1
        TIPO_ANALISIS.Enabled = True
        TIPO_MUESTRA.SelectedIndex = -1
        TIPO_MUESTRA.Enabled = True
        DESCRIPCION_TIPO_ANALISIS.Text = ""
        DESCRIPCION_TIPO_ANALISIS.Enabled = True
        DESCRIPCION_TIPO_MUESTRA.Text = ""
        DESCRIPCION_TIPO_MUESTRA.Enabled = True
        DESCRIPCION.Text = ""
        DESCRIPCION.Enabled = True
        CLAVE_VS.Text = ""
        CLAVE_VS.Enabled = True
        MARCA.Text = ""
        MARCA.Enabled = True
        LOTE.Text = ""
        LOTE.Enabled = True
        CANTIDAD.Value = 0
        CANTIDAD.Enabled = True
        FECHA_CADUCIDAD.Value = "01/01/1999"
        FECHA_CADUCIDAD.Enabled = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        habilitar()

    End Sub
End Class
