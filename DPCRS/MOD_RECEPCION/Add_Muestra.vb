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




    Public Function _Validar() As Boolean
        Dim errores As Integer = 0


        If TIPO_MUESTRA.SelectedIndex = -1 Then
            ErrorProvider1.SetError(TIPO_MUESTRA, "debe seleccionar un tipo de muestra")
            errores = errores + 1

        Else
            ErrorProvider1.SetError(TIPO_MUESTRA, Nothing)

        End If
        If TIPO_ANALISIS.SelectedIndex = -1 Then
            ErrorProvider1.SetError(TIPO_ANALISIS, "debe seleccionar un tipo de analisis")
            errores = errores + 1
        Else
            ErrorProvider1.SetError(TIPO_ANALISIS, Nothing)
        End If
        If DESCRIPCION.Text.Length = 0 Then
            ErrorProvider1.SetError(DESCRIPCION, "debe contener una breve descripcion")
            errores = errores + 1
        Else
            ErrorProvider1.SetError(DESCRIPCION, Nothing)
        End If
        If CANTIDAD.Value = 0 Then
            ErrorProvider1.SetError(CANTIDAD, "debe tener al menos uno como valor")
            errores = errores + 1
        Else
            ErrorProvider1.SetError(CANTIDAD, Nothing)
        End If

        If errores = 0 Then

            Return True
        Else
            Return False


        End If

    End Function

    Public Sub limpiar()
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
        FECHA_CADUCIDAD.Value = Nothing
        FECHA_CADUCIDAD.Enabled = False
        oFunciones.AlertBox("Muestra Agregada al Acta, Verifique los datos en la tabla de Muestras ", MessageBoxIcon.Information)
        If (Wisej.Web.MessageBox.Show("Muestra Agregada, Si es la ultima muestra capturada", "¿Desea cerrar el formulario de muestras sanitarias?", Wisej.Web.MessageBoxButtons.YesNo, Wisej.Web.MessageBoxIcon.Question) = DialogResult.Yes) Then
            Me.Close()

        End If
    End Sub
    Public Sub habilitar()
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
        FECHA_CADUCIDAD.Value = Nothing
        FECHA_CADUCIDAD.Enabled = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        habilitar()
        AÑADIR_ITEM.Enabled = True

    End Sub
End Class
