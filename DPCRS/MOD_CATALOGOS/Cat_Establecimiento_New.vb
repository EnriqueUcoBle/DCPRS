Imports System.Data.SqlClient
Imports Wisej.Web
Imports System.Drawing
Imports Wisej.Web.Form

Public Class Cat_Establecimiento_New
    Dim oFunciones As New dllData
    Public isselected As Boolean = False
    Dim Establecimiento_New As Cat_Establecimiento_New
    Dim Establecimientos As Cat_Establecimientos

    Public datoSCIAN As String
    Public datoMunicipio As String
    Public datoGiro As String
    Public datoIdentificacion As String
    Public datoL As String
    Dim seleccionado As String
    Dim horaActual As Date

    Dim CVE As String
    Dim nCVE_ESTA As Integer = 0
    Dim POSICION As String = ""
    Public bGuardo = False, habilitados = True, loaded As Boolean

    Private Sub Cat_Establecimiento_New_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Establecimientos = New Cat_Establecimientos
        Establecimientos.cargarTabla()
        subLlenarCombos()
        txtClave.Enabled = False
        txtDias_Laborales.Enabled = False

        txtOtroIdentificacion.Enabled = False
        If txtClave.Text <> Nothing Then
            txtClave.Text = txtClave.Text
        Else
            txtClave.Text = "0"
        End If

        Establecimiento_New = New Cat_Establecimiento_New
        Establecimiento_New.Text = "Registrar nuevo establecimiento"
        Dim tool As New ToolTip
        tool.SetToolTip(Me.BTNaddscian, "Agregar SCIAN")
        CBSscian.Text = datoSCIAN
        CBSmunicipio.Text = datoMunicipio
        CBSgiro.Text = datoGiro
        'Dim ID As String
        'ID = datoIdentificacion
        'Select Case ID
        '    Case ""
        'End Select

        If datoIdentificacion <> "Credencial INE" And datoIdentificacion <> "LICENCIA" And datoIdentificacion <> "PASAPORTE" Then
            txtOtroIdentificacion.Text = datoIdentificacion
            RBotro.Checked = True
            txtOtroIdentificacion.Enabled = True
        Else
            txtOtroIdentificacion.Enabled = False
            If datoIdentificacion = "Credencial INE" Then
                RBcredencial.Checked = True
            End If
            If datoIdentificacion = "LICENCIA" Then
                RBlicencia.Checked = True
            End If

            If datoIdentificacion = "PASAPORTE" Then
                RBpasaporte.Checked = True
            End If

        End If

        If datoL <> Nothing Then
            If datoL.Contains("L").ToString Then
                lunes.Checked = True
            End If
            If datoL.Contains("M").ToString Then
                martes.Checked = True
            End If
            If datoL.Contains("M").ToString Then
                miercoles.Checked = True
            End If
            If datoL.Contains("J").ToString Then
                jueves.Checked = True
            End If
            If datoL.Contains("V").ToString Then
                viernes.Checked = True
            End If
            If datoL.Contains("S").ToString Then
                sabado.Checked = True
            End If
            If datoL.Contains("D").ToString Then
                domingo.Checked = True
            End If
        Else
            datoL = ""
        End If
        txtHoraInicio.ShowUpDown = True
        txtHoraInicio.ShowCalendar = False
        txtHoraFin.ShowUpDown = True
        txtHoraFin.ShowCalendar = False
    End Sub


    Sub subLlenarCombos()
        Try
            oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_GIROS_B", "CVE_GIRO", "DESCRIPCIONX", CBSgiro)
            oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_MUNICIPIOS_B", "CLAVE", "DESCRIPCIONX", CBSmunicipio)
            oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_CLAVES_SCIAN_B", "CLAVE", "DESCRIPCIONX", CBSscian)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Cargar listas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub RibbonBar1_ItemClick(sender As Object, e As Wisej.Web.Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick

        Select Case e.Item.Text
            Case "Nuevo"
                oFunciones.LimpiarPanel(GroupBoxFORM, Me.Tag)
                oFunciones.LimpiarPanel(GroupBox2, Me.Tag)
                txtClave.Text = "0"
                txtOtroIdentificacion.Text = ""
                NoCheck()
            Case "Actualizar"
                Establecimientos.cargarTabla()
                abc()
            Case "Guardar"
                Guardar()
            Case "Salir"
                Me.Close()
        End Select
    End Sub

    Private Sub Guardar()
        Try
            If oFunciones.ValidarGrupos(GroupBoxFORM, ErrorProvider1) And oFunciones.ValidarGrupos(GroupBox2, ErrorProvider1) Then
                ReDim oFunciones.ParametersX_Global(24)
                oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@clave", txtClave.Text)
                oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@cve_giro", CBSgiro.SelectedValue)
                oFunciones.ParametersX_Global(2) = New SqlClient.SqlParameter("@cve_clave_scian", CBSscian.SelectedValue)
                oFunciones.ParametersX_Global(3) = New SqlClient.SqlParameter("@cve_municipio", CBSmunicipio.SelectedValue)
                oFunciones.ParametersX_Global(4) = New SqlClient.SqlParameter("@nom_propietario", txtPropietario.Text)
                oFunciones.ParametersX_Global(5) = New SqlClient.SqlParameter("@propietario_cargo", txtCargo.Text)
                oFunciones.ParametersX_Global(6) = New SqlClient.SqlParameter("@propietario_identificacion", Identificacion)
                oFunciones.ParametersX_Global(7) = New SqlClient.SqlParameter("@propietario_domicilio", txtDomicilio.Text)
                oFunciones.ParametersX_Global(8) = New SqlClient.SqlParameter("@razon_social", txtRazon_social.Text)
                oFunciones.ParametersX_Global(9) = New SqlClient.SqlParameter("@telefono", txtTelefono.Text)
                oFunciones.ParametersX_Global(10) = New SqlClient.SqlParameter("@email", txtEmail.Text)
                oFunciones.ParametersX_Global(11) = New SqlClient.SqlParameter("@rfc", txtRFC.Text)
                oFunciones.ParametersX_Global(12) = New SqlClient.SqlParameter("@domicilio", txtDomicilio.Text)
                oFunciones.ParametersX_Global(13) = New SqlClient.SqlParameter("@colonia", txtColonia.Text)
                oFunciones.ParametersX_Global(14) = New SqlClient.SqlParameter("@codigo_postal", txtCodigo.Text)
                oFunciones.ParametersX_Global(15) = New SqlClient.SqlParameter("@volumen_produccion", txtVolumen.Text)
                oFunciones.ParametersX_Global(16) = New SqlClient.SqlParameter("@aviso_funcionamiento", 0)
                oFunciones.ParametersX_Global(17) = New SqlClient.SqlParameter("@licencia", 0)
                oFunciones.ParametersX_Global(18) = New SqlClient.SqlParameter("@dias_labores", txtDias_Laborales.Text)
                oFunciones.ParametersX_Global(19) = New SqlClient.SqlParameter("@turnos", 1)
                oFunciones.ParametersX_Global(21) = New SqlClient.SqlParameter("@hora_inicio", txtHoraInicio.Text)
                oFunciones.ParametersX_Global(22) = New SqlClient.SqlParameter("@hora_fin", txtHoraFin.Text)
                oFunciones.ParametersX_Global(23) = New SqlClient.SqlParameter("@estatus", "ACTIVO")
                oFunciones.ParametersX_Global(24) = New SqlClient.SqlParameter("@habilitado", 1)

                Dim parametro = oFunciones.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_ESTABLECIMIENTOS_G", "@parametro", oFunciones.ParametersX_Global, False, SqlDbType.VarChar, 50)
                If parametro <> Nothing Then

                    'MessageBox.Show("Datos guardados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    oFunciones.AlertBox("Datos guardados correctamente", MessageBoxIcon.Information)
                    isselected = True
                    oFunciones.LimpiarPanel(PanelFORM, Me.Tag)
                    'NoCheck()
                ElseIf parametro = Nothing Then
                    MessageBox.Show("No se ha podido guardar los datos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Else
                MessageBox.Show("No pueden ir vacios los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNaddscian.Click
        Dim Vscian As New Cat_Claves_Scian
        Vscian.Show()
    End Sub

    Private Sub RBotro_CheckedChanged(sender As Object, e As EventArgs) Handles RBotro.CheckedChanged
        If RBotro.Checked = True Then
            txtOtroIdentificacion.Enabled = True
        Else
            txtOtroIdentificacion.Enabled = False
        End If
    End Sub



    Private Function Identificacion() As String
        If RBcredencial.Checked Then
            Return "Credencial INE"
        ElseIf RBlicencia.Checked Then
            Return "LICENCIA"
        ElseIf RBpasaporte.Checked Then
            Return "PASAPORTE"
        ElseIf RBotro.Checked Then
            txtOtroIdentificacion.Text = txtOtroIdentificacion.Text
            Return txtOtroIdentificacion.Text
        Else
            Return "NA"
        End If
    End Function

    Sub abc()

    End Sub
    Private Sub lunes_CheckedChanged(sender As Object, e As EventArgs) Handles lunes.CheckedChanged, martes.CheckedChanged, miercoles.CheckedChanged, jueves.CheckedChanged, viernes.CheckedChanged, sabado.CheckedChanged, domingo.CheckedChanged

        Dim msg As String = ""
        If lunes.Checked = True Then
            msg = msg & lunes.Text & " "
        End If
        If martes.Checked = True Then
            msg = msg & martes.Text & " "
        End If
        If miercoles.Checked = True Then
            msg = msg & miercoles.Text & " "
        End If
        If jueves.Checked = True Then
            msg = msg & jueves.Text & " "
        End If
        If viernes.Checked = True Then
            msg = msg & viernes.Text & " "
        End If
        If sabado.Checked = True Then
            msg = msg & sabado.Text & " "
        End If
        If domingo.Checked = True Then
            msg = msg & domingo.Text & ""
        End If
        txtDias_Laborales.Text = msg


    End Sub
    Sub NoCheck()

        lunes.Checked = False
        martes.Checked = False
        miercoles.Checked = False
        jueves.Checked = False
        viernes.Checked = False
        sabado.Checked = False
        domingo.Checked = False
        RBcredencial.Checked = False
        RBlicencia.Checked = False
        RBpasaporte.Checked = False
        RBotro.Checked = False
        txtHoraInicio.Text = "08:00:00"
        txtHoraFin.Text = "17:00:00"
    End Sub

    Private Sub COMBOBOX_ToolClick(sender As Object, e As ToolClickEventArgs) Handles CBSmunicipio.ToolClick, CBSscian.ToolClick, CBSgiro.ToolClick
        oFunciones.ToolClick(sender, e)
    End Sub
    Private Sub buscarEstablecimientos(CVE_SEND As String)
        BindingSource1.Position = BindingSource1.Find("CVE_ESTABLECIMIENTOS", CVE_SEND)
    End Sub
    Private Sub CARGAR()

    End Sub
    Private Sub cargarBinding()
        Try
            Me.DataSet_pCAT_ESTABLECIMIENTOS_B.Clear()
            Dim myDA = New SqlClient.SqlDataAdapter("pCAT_ESTABLECIMIENTOS_B", dllData.sConexion)
            myDA.SelectCommand.Parameters.AddWithValue("@CVE_ESTABLECIMIENTO", CVE)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_pCAT_ESTABLECIMIENTOS_B.pCAT_ESTABLECIMIENTOS_B)
            myDA.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos" & ex.ToString, "Registros", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class

