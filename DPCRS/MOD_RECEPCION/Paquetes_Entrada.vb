Imports System
Imports Wisej.Web
Imports Wisej.Web.Ext.RibbonBar

Public Class Paquetes_Entrada
    Dim oFunciones As New dllData
    Private Sub RibbonBar1_ItemClick(sender As Object, e As RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Name
            Case "RRB_NUEVO"
                nuevo()

            Case "RRB_GUARDAR"
                Relacionar_Actas_paquetes()

            Case "RRB_LIMPIAR"
                limpiar_form()
            Case "RRB_IMPRIMIR"

            Case "RRB_REIMPRIMIR"

            Case "RRB_SALIR"

                Me.Close()
        End Select
    End Sub
    Private Sub llenarComboJurisdiccion()
        oFunciones.Llenar_listbox("pCAT_JURISDICCION_B", "CVE_JURISDICCION", "JURISDICCION", JURISDICCION)
    End Sub
    Private Sub limpiar_form()
        JURISDICCION.SelectedIndex = -1
        FECHA_RECEPCION.Value = Nothing
        FECHA_RECEPCION.Text = Nothing
        si.Checked = False
        For Each r As DataGridViewRow In ACTAS_VERIFICACION.SelectedRows
            ACTAS_VERIFICACION.Rows.Remove(r)
        Next
        JURISDICCION.Enabled = False
        FECHA_RECEPCION.Enabled = False
        ACTAS_VERIFICACION.Enabled = False
        JURISDICCION.Watermark = "Seleccione la jurisdiccion de procedencia"
        ERROR_.SetError(JURISDICCION, Nothing)
        ERROR_.SetError(FECHA_RECEPCION, Nothing)
        ERROR_.SetError(ACTAS_VERIFICACION, Nothing)
    End Sub
    Private Function Relacionar_Actas_paquetes() As Boolean
        If validarCampos() Then
            MessageBox.Show("campos validos")
            'insertar cve de paquete para relacionarlo con las actas
            Return True

        Else
            MessageBox.Show("campos no validos")
            'j
            Return False

        End If
    End Function
    Private Sub imprimir()

    End Sub
    Private Sub reimprimir()

    End Sub
    Private Sub nuevo()
        limpiar_form()
        JURISDICCION.Enabled = True
        FECHA_RECEPCION.Enabled = True
        ACTAS_VERIFICACION.Enabled = True
        JURISDICCION.Watermark = "Seleccione la jurisdiccion de procedencia"
        ERROR_.SetError(JURISDICCION, Nothing)
        ERROR_.SetError(FECHA_RECEPCION, Nothing)
        ERROR_.SetError(ACTAS_VERIFICACION, Nothing)

    End Sub

    Private Function validarCampos() As Boolean
        Dim e As Integer = 0
        If JURISDICCION.SelectedIndex = -1 Then
            ERROR_.SetError(JURISDICCION, "No se ha seleccionado una jurisdiccion")
            e = e + 1
        Else
            ERROR_.SetError(JURISDICCION, Nothing)
        End If
        If FECHA_RECEPCION.Value = Nothing Then
            ERROR_.SetError(FECHA_RECEPCION, "No ha seleccionado una fecha")
            e = e + 1
        Else
            ERROR_.SetError(FECHA_RECEPCION, Nothing)
        End If
        If ACTAS_VERIFICACION.RowCount = 0 Then
            ERROR_.SetError(ACTAS_VERIFICACION, "no hay actas de verificacion")
            e = e + 1
        Else
            ERROR_.SetError(ACTAS_VERIFICACION, Nothing)
        End If
        If e <> 0 Then
            Return False
        Else
            Return True

        End If
    End Function

    Private Sub Paquetes_Entrada_Load(sender As Object, e As EventArgs) Handles Me.Load
        llenarComboJurisdiccion()
    End Sub


    Private Sub añadir_items(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form = New Generar_Orden_Verficacion
        form.Show()
        AddHandler form.finalizar.Click, AddressOf añadir_item



    End Sub
    Private Sub añadir_item(sender As Object, e As EventArgs)
        Dim form As Generar_Orden_Verficacion = sender.Parent.Parent.Parent
        If form.validar_todo = True Then
            add_actas(form.cve_acta, form.JURISDICCION_EST.Text, form.NOMBRE_PROPIETARIO.Text, form.RAZON_SOCIAL_EST.Text, form.GIRO_EST.Text, form.DOMICILIO_EST.Text, form.FOLIO_ACTA_VERIFICACION.Text, form.TIPO_ACTA.SelectedItem.ToString, form.FECHA_VERIFICACION.Value)
        Else
            MessageBox.Show("No se puede guardar el acta de verificacion, favor de validar los datos de los campos nesesarios", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Function add_actas(ByVal cve_acta As Integer, ByVal jurisdiccion As String, ByVal propietario As String, ByVal razon_social As String, ByVal giro As String, ByVal domicilio As String, ByVal folio_acta As String, ByVal tipo_verificacion As String, ByVal fecha_entrega As Date) As Boolean
        Try
            ACTAS_VERIFICACION.Rows.Add()
            Dim FILA As Integer = ACTAS_VERIFICACION.Rows.Count - 1
            ACTAS_VERIFICACION.Item("CVE_ACTA", FILA).Value = cve_acta
            ACTAS_VERIFICACION.Item("JURISDICCION_", FILA).Value = jurisdiccion
            ACTAS_VERIFICACION.Item("PROPIETARIO", FILA).Value = propietario
            ACTAS_VERIFICACION.Item("RAZON_SOCIAL", FILA).Value = razon_social
            ACTAS_VERIFICACION.Item("GIRO", FILA).Value = giro
            ACTAS_VERIFICACION.Item("DOMICILIO", FILA).Value = domicilio
            ACTAS_VERIFICACION.Item("FOLIO_ACTA", FILA).Value = folio_acta
            ACTAS_VERIFICACION.Item("TIPO_VERIFICACION", FILA).Value = tipo_verificacion
            ACTAS_VERIFICACION.Item("FECHA_ENTREGA", FILA).Value = fecha_entrega
        Catch ex As Exception
            Wisej.Web.MessageBox.Show("Error al guardar, ERROR: " & ex.Message, "Guardar", Wisej.Web.MessageBoxButtons.OK, Wisej.Web.MessageBoxIcon.Warning)
            Return False
        End Try
        Return True
    End Function

    Private Sub GENERAR_REPORTE_Click(sender As Object, e As EventArgs) Handles GENERAR_REPORTE.Click
        If Relacionar_Actas_paquetes() Then

        Else
        End If
    End Sub


End Class
