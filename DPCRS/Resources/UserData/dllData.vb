'Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.IO
Imports Wisej.Web.Resources
Imports System.Security.Cryptography

Imports DPCRS.DataGV.Features
Imports System.Globalization
Imports System.Management
Imports System.Drawing
Imports System.Data
Imports Wisej.Web

Public Class dllData
    Dim ue As New System.Text.UTF8Encoding
    Dim sec As New RSACryptoServiceProvider
    Dim bytString(), bytEncriptar(), bytDesEncriptar() As Byte
    '-----------------------------------------------------
    Public bPasoValidacion As Boolean
    Public bPasoValidacionMensaje As New Dictionary(Of Integer, String)
    Public ParametersX_Global() As System.Data.SqlClient.SqlParameter
    Dim cErrors As String
    Dim X As Integer
    Public cConnect As New SqlConnection  ' OleDbConnection
    Public cCommand As New SqlCommand  'OleDbCommand
    Public Shared sConexion As String = System.Configuration.ConfigurationManager.ConnectionStrings("DPCRSConnectionString").ConnectionString
    Public Const sConstante_KEY = "$$SAXSOFT.COM_Y_SANITARIO$$"
    Public Const sUserTimbrado = "SAX_NOMINA"
    Public Const sPassTimbrado = "UqMa5lZ7wn3Y"
    Public Const sProjectName = "DPCRS"
    Public Const sConstante_Version = "Versión 0.0.3"
    Public formulario As String
    Public modulo As String
    Public operador As String
    'Dim form_cuentaAtras As Actualizar
    Public Shared sArraysMeses As String() = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
    Public Enum meses
        Enero = 1 : Febrero = 2 : Marzo = 3 : Abril = 4 : Mayo = 5 : Junio = 6 : Julio = 7 : Agosto = 8 : Septiembre = 9 : Octubre = 10 : Noviembre = 11 : Diciembre = 12
    End Enum


    Dim sPARAMETROS As String

#Region "Base Datos"
    '    ''' <summary>
    '    ''' Funcion de conexion base de datos 
    '    ''' </summary>
    '    ''' <returns>retorna un valor booleano </returns>
    '    ''' <remarks></remarks>
    Public Function Connect() As Boolean
        Conectar()
        Try
            'cDataConnectionSQL = New SqlConnection(strConn)
            'cDataConnectionSQL.Open()
            If cConnect.State = ConnectionState.Open Then
                Return True
            End If
        Catch e As Exception
            cErrors += " " & e.Message
            Wisej.Web.MessageBox.Show(e.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End Try

    End Function
    Sub Conectar()
        Try
            If cConnect.State = ConnectionState.Closed Then
                cConnect.ConnectionString = sConexion
                cConnect.Open()
            End If

        Catch ex As SystemException
            Wisej.Web.MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cErrors += " " & ex.Message
        End Try
    End Sub
    '    ''' <summary>
    '    ''' Funcion de desconexion base de datos 
    '    ''' </summary>
    '    ''' <remarks></remarks>
    Sub Desconectar()
        '********************************************************
        'Funcion que devuelve verdadero si se hace la funcion SQL
        '********************************************************
        Try
            If cConnect.State <> ConnectionState.Closed Then cConnect.Close()
            'cTransaccion.Dispose()
            'cCommand.Dispose()

        Catch ex As SystemException
            'Messagebox.show("Error: " & ex.Message,ofunciones.MessageBoxStyle.Critical, "Aviso")
            Wisej.Web.MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cErrors += " " & ex.Message
        End Try
    End Sub
    Public Shared Sub ConfigurarBindingNavigator(ByVal oBinding As BindingNavigator, Optional oSiguiente As Boolean = False, Optional oAnterior As Boolean = False, Optional oPrimero As Boolean = False, Optional oUltimo As Boolean = False)
        'oBinding.
        With oBinding
            .DeleteItem.Visible = False
            .AddNewItem.Visible = False
            .MoveFirstItem.Visible = oPrimero
            .MoveLastItem.Visible = oUltimo
            .MoveNextItem.Visible = oSiguiente
            .MovePreviousItem.Visible = oAnterior
            '.CountItemFormat = "{0} de {1}"
        End With
    End Sub
    Function fGuardar_O_EliminarXProcedure(ByVal sProcedureName As String, Optional ByVal sNombreCampoRetornar As String = Nothing, Optional ByVal cParams() As SqlParameter = Nothing, Optional ByVal bMostrarMensaje As Boolean = True, Optional ByVal bEsTexto As Boolean = False) As Boolean
        Dim i As Integer
        Conectar()
        Try
            Dim cCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand(sProcedureName, cConnect)
            If bEsTexto Then
                cCommand.CommandType = CommandType.Text
            Else
                cCommand.CommandType = CommandType.StoredProcedure
            End If
            sPARAMETROS = Nothing
            'cCommand.Parameters.Add("@Descripcion", sDescripcion)
            If cParams Is Nothing = False Then
                For i = 0 To cParams.GetLength(0) - 1
                    If cParams(i) Is Nothing = False Then

                        cCommand.Parameters.Add(cParams(i))
                        If i = 0 Then
                            If cParams(i).SqlDbType = SqlDbType.NVarChar Then
                                sPARAMETROS = sPARAMETROS & cParams(i).ToString & "='" & cParams(i).Value & "'"
                            Else
                                sPARAMETROS = sPARAMETROS & cParams(i).ToString & "=" & cParams(i).Value
                            End If
                        Else
                            If cParams(i).SqlDbType = SqlDbType.NVarChar Then
                                sPARAMETROS = sPARAMETROS & "," & cParams(i).ToString & "='" & cParams(i).Value & "'"
                            Else
                                sPARAMETROS = sPARAMETROS & "," & cParams(i).ToString & "=" & cParams(i).Value
                            End If
                        End If
                    End If
                Next
            End If
            '***********************************************************
            If Trim(sNombreCampoRetornar) <> Nothing Then
                Dim parameterConsecutivo As New SqlParameter(sNombreCampoRetornar, SqlDbType.Int)
                parameterConsecutivo.Direction = ParameterDirection.Output
                cCommand.Parameters.Add(parameterConsecutivo)
                '***********************************************************
                ' Open the database connection and execute the command
                cCommand.ExecuteNonQuery()
                If Not parameterConsecutivo.Value Is Nothing And Not parameterConsecutivo.Value Is System.DBNull.Value Then
                    fGuardar_O_EliminarXProcedure = True

                Else
                    fGuardar_O_EliminarXProcedure = False
                    If bMostrarMensaje Then
                        'Messagebox.show("Error al realizar la operación,por favor, intentelo de nuevo ",ofunciones.MessageBoxStyle.Information, "Aviso")
                        cErrors += " " & "Error al realizar la operación, por favor, intentelo de nuevo "
                    End If
                End If
            Else
                cCommand.ExecuteNonQuery()
                fGuardar_O_EliminarXProcedure = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'cErrors += " " & ex.Message

            'Guardar_Error(modulo, ex.Message, operador, sProcedureName & " " & sPARAMETROS, formulario)


            If bMostrarMensaje Then
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            fGuardar_O_EliminarXProcedure = False
        Finally
            Desconectar()
        End Try
    End Function
    Public Sub AlertBox(ByVal Mensaje As String, Optional ByVal Icono As MessageBoxIcon = 16, Optional ByVal Boton As MessageBoxButtons = 1)
        If Mensaje Is Nothing Then Exit Sub

        Wisej.Web.AlertBox.Show(Mensaje, Icono, Boton, showProgressBar:=True, alignment:=Drawing.ContentAlignment.TopRight)
    End Sub




    'Public Sub MessageBox1(ByVal Mensaje As String, Optional ByVal titulo As String = "", Optional ByVal val3 As MessageBoxButtons = 1, Optional ByVal Tipo As MessageBoxIcon = 16, Optional addhandle As EventHandler = Nothing)
    '    If Mensaje Is Nothing Then Exit Sub
    '    'Mensaje = Mensaje.Replace("'", "")
    '    'Mensaje = Mensaje.Replace(vbCrLf, "<br>")
    '    Try
    '        Dim tipoMensaje As String
    '        If Tipo = MessageBoxIcon.Error Then
    '            tipoMensaje = "error"
    '        ElseIf Tipo = MessageBoxIcon.Information Then
    '            tipoMensaje = "success"
    '        Else
    '            tipoMensaje = "info"
    '        End If

    '        Dim ti As TextInfo = CultureInfo.CurrentCulture.TextInfo

    '        Mensaje = ti.ToTitleCase(Mensaje)


    '        If addhandle Is Nothing Then
    '            'Dim f As New Mbox
    '            'f.BringToFront()
    '            'f.invokes(Mensaje, tipoMensaje)
    '            'f.Show()
    '            'f.Close()
    '            'AlertBox.Show(Mensaje, titulo, val3)

    '        Else
    '            'AlertBox.Show(Mensaje, titulo, val3, addhandle)
    '        End If


    '    Catch ex As Exception
    '        Wisej.Web.AlertBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub
    Function fDevulve_Configuracion_Sistema(ByVal sModulo As String, Optional ByVal sParamX As String = Nothing) As Object
        Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            cCommand = New SqlClient.SqlCommand("pCONFIGURACION_SISTEMA_B", cConnect)
            cCommand.CommandType = CommandType.StoredProcedure
            cCommand.Parameters.AddWithValue("@MODULO", sModulo)
            If sParamX <> Nothing Then cCommand.Parameters.AddWithValue("@SISTEMA", sParamX)

            cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While cDataReader.Read
                    fDevulve_Configuracion_Sistema = cDataReader.Item("PARAMETRO")
                End While
            End If
        Catch ex As SystemException
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()
        End Try
    End Function


    Sub Sparametros_Grid(myDA As SqlDataAdapter, sProcedure As String, datagrid As Wisej.Web.BindingNavigator)
        If "ADMIN" = Application.Current.Session("Cve_Operador") Then


            Dim sPARAMETRO As String
            For i = 0 To myDA.SelectCommand.Parameters.Count - 1

                If i = 0 Then
                    If myDA.SelectCommand.Parameters.Item(i).SqlDbType = SqlDbType.NVarChar Then

                        sPARAMETRO = sPARAMETRO + " " & myDA.SelectCommand.Parameters.Item(i).ParameterName & "='" & myDA.SelectCommand.Parameters.Item(i).Value & "'"
                    Else

                        sPARAMETRO = sPARAMETRO + " " & myDA.SelectCommand.Parameters.Item(i).ParameterName & "=" & myDA.SelectCommand.Parameters.Item(i).Value & ""
                    End If

                Else
                    If myDA.SelectCommand.Parameters.Item(i).SqlDbType = SqlDbType.NVarChar Then

                        sPARAMETRO = sPARAMETRO + " , " & myDA.SelectCommand.Parameters.Item(i).ParameterName & "='" & myDA.SelectCommand.Parameters.Item(i).Value & "'"
                    Else

                        sPARAMETRO = sPARAMETRO + " ," & myDA.SelectCommand.Parameters.Item(i).ParameterName & "=" & myDA.SelectCommand.Parameters.Item(i).Value & ""
                    End If

                End If







            Next




            Dim CMS As New System.Windows.Forms.ContextMenuStrip
            Dim item_cms As New System.Windows.Forms.ToolStripTextBox
            item_cms.Text = sProcedure + " " + sPARAMETRO
            CMS.Width = "400px"
            CMS.Items.Add(item_cms)

            datagrid.ContextMenuStrip = CMS
            'Sparametros_Grid = sProcedure + " " + sPARAMETRO
        End If

    End Sub

    Public Enum TiposMomentosContables
        '
        ' Summary:
        '     No aplica
        Noaplica = 0
        '
        ' Summary:
        '     Aprobado
        Aprobado = 1
        '
        ' Summary:
        '     Entrada Inventariono Presupuestaria
        EntradaInventarionoPresupuestaria = 10
        '
        ' Summary:
        '     Cuotas Recuperacion
        CuotasRecuperacion = 11
        '
        ' Summary:
        '      Pago Comisiones Bancarias No Presupuestales
        PagoComisionesBancariasNoPresupuestales = 12
        '
        ' Summary:
        '     Nota Credito
        NotaCredito = 13
        '
        ' Summary:
        '      Modificado.
        Modificado = 2
        '
        ' Summary:
        '      Comprometido
        Comprometido = 3
        '
        ' Summary:
        '     Devengado
        Devengado = 4
        '
        ' Summary:
        '     Ejercido
        Ejercido = 5

        ' Summary:
        '     Pagado
        Pagado = 6

        ' Summary:
        '     Recaudado
        Recaudado = 7

        ' Summary:
        '     Entrada Almacen no Presupuestaria
        EntradaAlmacennoPresupuestaria = 8

        ' Summary:
        '     Salida Almacen
        SalidaAlmacen = 9


    End Enum

    Function fBuscarFechaMomento(FOLIO_PROCEDENCIA As String, idmomento As TiposMomentosContables) As Date



        Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            cCommand = New SqlClient.SqlCommand("pPOLIZA_ESTATUS_FECHA_B", cConnect)
            cCommand.CommandType = CommandType.StoredProcedure
            cCommand.Parameters.AddWithValue("@FOLIO_PROCEDENCIA", FOLIO_PROCEDENCIA)
            cCommand.Parameters.AddWithValue("@ID_MOMENTO_CONTABLE", idmomento)

            cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While (cDataReader.Read)


                    fBuscarFechaMomento = cDataReader.Item("FECHA")

                End While
            End If
        Catch ex As SystemException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()
        End Try
        Return fBuscarFechaMomento
    End Function



    Function fCompareTwoDataTable(ByVal Dt1 As DataTable, ByVal Dt2 As DataTable, ByVal sColumnPimary As String) As Integer
        Try

        Catch ex As Exception

        End Try
        Dim dif As Integer

        Dim sWhere As String = sColumnPimary & "= '"
        For Each Row As DataRow In Dt1.Rows
            Dim r As DataRow() = Dt2.Select(sWhere & Row.Item(sColumnPimary) & "'")
            If r.Length = 0 Then
                dif += 1
            End If
        Next Row
        Return dif
    End Function
    Public Function llenarXProcToDataSetOrDTable(ByVal sProcedure As String, ByVal Parameters() As SqlClient.SqlParameter, Optional ByVal isDataSet As Boolean = True) As Object
        Dim retorna As Object

        Dim myDA As SqlDataAdapter
        Dim myDS As New DataSet
        Dim myDt As New DataTable(sProcedure)
        Try
            myDA = New Data.SqlClient.SqlDataAdapter(sProcedure, sConexion)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            If Parameters Is Nothing = False Then
                For i = 0 To Parameters.GetLength(0) - 1
                    If Parameters(i) Is Nothing = False Then
                        myDA.SelectCommand.Parameters.Add(Parameters(i))
                    End If
                Next
            End If

            myDA.Fill(myDt)
            'myDA.Dispose()
        Catch ex As SystemException
            Guardar_Error(modulo, ex.Message, operador, sProcedure & "llenarXProcToDataSetOrDTable", formulario)
            'MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show(ex.Message)
        Finally
        End Try

        If isDataSet Then
            myDS.Tables.Add(myDt)
            retorna = myDS
        Else
            retorna = myDt
        End If
        Return retorna
    End Function

    Function Formatear_CuentaContable(ByVal cod_cuenta As String, ByVal nivel As Integer) As String
        Dim cuenta As String()
        cuenta = Split(cod_cuenta, ".")





        For x As Integer = 0 To cuenta.Count - 1


            If nivel > x Then
                Formatear_CuentaContable = Formatear_CuentaContable + cuenta(x) + "."
                'ElseIf nivel = x Then

                'Else
                '    'If x = cuenta.Count - 1 Then
                '    '    Formatear_CuentaContable = Formatear_CuentaContable + cuenta(x)
                '    'Else
                '    '    Formatear_CuentaContable = Formatear_CuentaContable + cuenta(x) + "."
                '    'End If

            End If




        Next
        Return Formatear_CuentaContable
    End Function



    Sub Llenar_CatalogosXprocedureGridCombobox(ByVal sNameProcedure As String, ByVal sId As String, ByVal sDescripcion As String, ByVal cControl As Wisej.Web.DataGridViewComboBoxColumn, Optional ByVal cParams() As SqlParameter = Nothing, Optional ByVal bEsText As Boolean = False)
        Try
            Dim i As Integer
            Dim myDS As DataSet = New DataSet
            Dim myDA As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(sNameProcedure, sConexion)
            If bEsText = True Then
                myDA.SelectCommand.CommandType = CommandType.Text
            Else
                myDA.SelectCommand.CommandType = CommandType.StoredProcedure
                If cParams Is Nothing = False Then
                    For i = 0 To cParams.Length - 1
                        If cParams(i) Is Nothing = False Then
                            myDA.SelectCommand.Parameters.Add(cParams(i))
                        End If
                    Next
                End If
            End If
            myDS.EnforceConstraints = False
            myDA.Fill(myDS, "SQLX")
            With cControl 'llenar los Catalogos}

                .ValueMember = sId
                .DisplayMember = sDescripcion
                '.DataMember = "SQLX"
                .DataSource = myDS.Tables(0)
                '.Refresh()
                '            combobox1.datasource = the second table
                'combobox1.displaymember = the description in the second table
                'combobox1.valuemebmer = the id in the second table

            End With

        Catch ex As Exception
            Guardar_Error(modulo, ex.Message, operador, sNameProcedure, formulario)
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Llenar_CatalogosXprocedureYParams2(ByVal sNameProcedure As String, ByVal sId As String, ByVal sDescripcion As String, ByVal cControl As Object, Optional ByVal cParams() As SqlParameter = Nothing, Optional ByVal bEsText As Boolean = False)
        Dim i As Integer
        Dim myDS As DataSet = New DataSet
        Dim myDA As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(sNameProcedure, sConexion)
        If bEsText = True Then
            myDA.SelectCommand.CommandType = CommandType.Text
        Else
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            If cParams Is Nothing = False Then
                For i = 0 To cParams.GetLength(0) - 1
                    If cParams(i) Is Nothing = False Then
                        myDA.SelectCommand.Parameters.Add(cParams(i))
                    End If
                Next
            End If
        End If
        myDS.EnforceConstraints = False

        myDA.Fill(myDS, "SQLX")
        With cControl 'llenar los Catalogos}
            .ValueMember = sId
            .DisplayMember = sDescripcion
            '.DataMember = "SQLX"
            .DataSource = myDS.Tables(0)
            '.Refresh()
            '            combobox1.datasource = the second table
            'combobox1.displaymember = the description in the second table
            'combobox1.valuemebmer = the id in the second table
        End With
    End Sub
    Sub Llenar_CatalogosXprocedureYParams(ByVal sNameProcedure As String, ByVal sId As String, ByVal sDescripcion As String, ByVal cControl As DevExpress.Web.ASPxComboBox, Optional ByVal cParams() As SqlParameter = Nothing, Optional ByVal bEsText As Boolean = False)
        Dim i As Integer
        Dim myDS As DataSet = New DataSet
        Dim myDA As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(sNameProcedure, sConexion)
        If bEsText = True Then
            myDA.SelectCommand.CommandType = CommandType.Text
        Else
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            If cParams Is Nothing = False Then
                For i = 0 To cParams.GetLength(0) - 1
                    If cParams(i) Is Nothing = False Then
                        myDA.SelectCommand.Parameters.Add(cParams(i))
                    End If
                Next
            End If
        End If
        myDA.Fill(myDS, "SQLX")
        With cControl 'llenar los Catalogos}
            .ValueField = sId
            .TextField = sDescripcion
            '.DataMember = "SQLX"
            .DataSource = myDS.Tables(0)
            .DataBind()
            '.Refresh()

            '            combobox1.datasource = the second table
            'combobox1.displaymember = the description in the second table
            'combobox1.valuemebmer = the id in the second table
        End With
    End Sub

    'DEVUELVE STRING
    Function fGuardar_O_EliminarXProcedureS(ByVal sProcedureName As String, Optional ByVal sNombreCampoRetornar As String = Nothing, Optional ByVal cParams() As SqlParameter = Nothing, Optional ByVal bMostrarMensaje As Boolean = True, Optional ByVal bEsTexto As Boolean = False, Optional ByVal dbType As SqlDbType = SqlDbType.VarChar, Optional ByVal sSize As Integer = 50) As Boolean
        Dim i As Integer
        Conectar()
        Try
            Dim cCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand(sProcedureName, cConnect)
            If bEsTexto Then
                cCommand.CommandType = CommandType.Text
            Else
                cCommand.CommandType = CommandType.StoredProcedure
            End If
            sPARAMETROS = Nothing
            'cCommand.Parameters.Add("@Descripcion", sDescripcion)
            If cParams Is Nothing = False Then
                For i = 0 To cParams.GetLength(0) - 1
                    If cParams(i) Is Nothing = False Then

                        cCommand.Parameters.Add(cParams(i))
                        If i = 0 Then
                            If cParams(i).SqlDbType = SqlDbType.NVarChar Then
                                sPARAMETROS = sPARAMETROS & cParams(i).ToString & "='" & cParams(i).Value & "'"
                            Else
                                sPARAMETROS = sPARAMETROS & cParams(i).ToString & "=" & cParams(i).Value
                            End If
                        Else
                            If cParams(i).SqlDbType = SqlDbType.NVarChar Then
                                sPARAMETROS = sPARAMETROS & "," & cParams(i).ToString & "='" & cParams(i).Value & "'"
                            Else
                                sPARAMETROS = sPARAMETROS & "," & cParams(i).ToString & "=" & cParams(i).Value
                            End If
                        End If
                    End If
                Next
            End If
            '***********************************************************
            If Trim(sNombreCampoRetornar) <> Nothing Then
                Dim parameterConsecutivo As New SqlParameter(sNombreCampoRetornar, dbType, sSize)
                parameterConsecutivo.Direction = ParameterDirection.Output
                cCommand.Parameters.Add(parameterConsecutivo)
                '***********************************************************
                ' Open the database connection and execute the command
                cCommand.ExecuteNonQuery()
                If Not parameterConsecutivo.Value Is Nothing And Not parameterConsecutivo.Value Is System.DBNull.Value Then
                    fGuardar_O_EliminarXProcedureS = True

                Else
                    fGuardar_O_EliminarXProcedureS = False
                    If bMostrarMensaje Then
                        'Messagebox.show("Error al realizar la operación,por favor, intentelo de nuevo ",ofunciones.MessageBoxStyle.Information, "Aviso")
                        cErrors += " " & "Error al realizar la operación, por favor, intentelo de nuevo "
                    End If
                End If
            Else
                cCommand.ExecuteNonQuery()
                fGuardar_O_EliminarXProcedureS = True
            End If
        Catch ex As Exception
            'Messagebox.show("Error: " & ex.Message,ofunciones.MessageBoxStyle.Critical, "Aviso")
            'cErrors += " " & ex.Message

            Guardar_Error(modulo, ex.Message, operador, sProcedureName & " " & sPARAMETROS, formulario)


            If bMostrarMensaje Then
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            fGuardar_O_EliminarXProcedureS = False
        Finally
            Desconectar()
        End Try
    End Function

    Function fGuardar_O_EliminarXProcedure_DevuelveId(ByVal sProcedureName As String, ByVal sNombreCampoRetornar As String, Optional ByVal cParams() As SqlParameter = Nothing, Optional ByVal bMostrarMensaje As Boolean = True, Optional ByVal dbtype As System.Data.SqlDbType = SqlDbType.Int, Optional ByVal sSize As Integer = 0) As String
        Dim i As Integer
        sPARAMETROS = Nothing
        Conectar()
        Try
            Dim cCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand(sProcedureName, cConnect)
            cCommand.CommandType = CommandType.StoredProcedure
            If cParams Is Nothing = False Then
                For i = 0 To cParams.GetLength(0) - 1
                    If cParams(i) Is Nothing = False Then
                        cCommand.Parameters.Add(cParams(i))
                        If i = 0 Then
                            If cParams(i).SqlDbType = SqlDbType.NVarChar Then
                                sPARAMETROS = sPARAMETROS & cParams(i).ToString & "='" & cParams(i).Value & "'"
                            Else
                                sPARAMETROS = sPARAMETROS & cParams(i).ToString & "=" & cParams(i).Value
                            End If
                        Else
                            If cParams(i).SqlDbType = SqlDbType.NVarChar Then
                                sPARAMETROS = sPARAMETROS & "," & cParams(i).ToString & "='" & cParams(i).Value & "'"
                            Else
                                sPARAMETROS = sPARAMETROS & "," & cParams(i).ToString & "=" & cParams(i).Value
                            End If
                        End If
                    End If
                Next
            End If
            '***********************************************************
            Dim parameterConsecutivo As New SqlParameter(sNombreCampoRetornar, dbtype, sSize)
            parameterConsecutivo.Direction = ParameterDirection.Output
            cCommand.Parameters.Add(parameterConsecutivo)
            sPARAMETROS = sPARAMETROS & "," & parameterConsecutivo.ParameterName.ToString & "=''"
            '***********************************************************
            ' Open the database connection and execute the command
            cCommand.ExecuteNonQuery()
            If Not parameterConsecutivo.Value Is Nothing And Not parameterConsecutivo.Value Is System.DBNull.Value Then
                fGuardar_O_EliminarXProcedure_DevuelveId = parameterConsecutivo.Value
                Dim valor As String = parameterConsecutivo.Value
                If valor.Contains("POLIZA_ERROR") Then
                    If bMostrarMensaje Then
                        MessageBox.Show("Consulte al administrador" + valor, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    Guardar_Error(modulo, valor, operador, sProcedureName & " " & sPARAMETROS, formulario)
                End If
            Else
                fGuardar_O_EliminarXProcedure_DevuelveId = Nothing
            End If
        Catch ex As Exception
            Dim NumeroError As String
            NumeroError = Guardar_Error(modulo, ex.Message, operador, sProcedureName & " " & sPARAMETROS, formulario)

            If bMostrarMensaje Then
                MessageBox.Show("Consulte al administrador" + NumeroError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            fGuardar_O_EliminarXProcedure_DevuelveId = Nothing
        Finally
            Desconectar()
        End Try
    End Function


    Function NOTIFICACIONES() As Integer
        Conectar()

        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            cCommand = New SqlClient.SqlCommand("pNOTIFICACIONES_TR_B", cConnect)
            cCommand.CommandType = CommandType.StoredProcedure
            cCommand.Parameters.AddWithValue("@ESTATUS", "ENTREGADO")
            cCommand.Parameters.AddWithValue("@CVE_OPERADOR", Application.Current.Session("Cve_Operador"))
            cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While (cDataReader.Read)

                    NOTIFICACIONES = NOTIFICACIONES + 1

                End While
            End If
        Catch ex As SystemException
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()

        End Try
        Return NOTIFICACIONES
    End Function

    '''''''''''''''''''''''''''''''''''''''''
    ' ______                                '
    ' |  ____|                              '
    ' | |__   _ __ _ __ ___  _ __ ___  ___  '
    ' |  __| | '__| '__/ _ \| '__/ _ \/ __| '
    ' | |____| |  | | | (_) | | |  __/\__ \ '
    ' |______|_|  |_|  \___/|_|  \___||___/ '
    '                                       '
    '''''''''''''''''''''''''''''''''''''''''
    'Falta MBox
    Function Guardar_Error(ByVal MODULO As String, ByVal SERROR As String, ByVal OPERADOR As String, ByVal PROCESO As String, ByVal FORMULARIO As String)
        Dim ERROR2 As Integer

        ReDim ParametersX_Global(5)
        ParametersX_Global(0) = New SqlClient.SqlParameter("@MODULO", MODULO)
        ParametersX_Global(1) = New SqlClient.SqlParameter("@ERROR", SERROR)
        ParametersX_Global(2) = New SqlClient.SqlParameter("@OPERADOR", OPERADOR)
        ParametersX_Global(3) = New SqlClient.SqlParameter("@PROCESO", PROCESO)
        ParametersX_Global(4) = New SqlClient.SqlParameter("@FORMULARIO", FORMULARIO)

        ERROR2 = fGuardar_O_EliminarXProcedure_DevuelveId("pERROR_SISTEMA_G", "@Parametro", ParametersX_Global, False, SqlDbType.Int, 50)

        'Dim f As New Mbox
        'f.invokesparametros("error", "Hubo un inconveniente, lamentamos que esto haya pasado favor de comunicarlo al soporte mediante el chat con el número: " + ERROR2.ToString, "SOPORTE MESA AYUDA")
        'f.Show()
        'f.Close()
        Wisej.Web.MessageBox.Show("Hubo un inconveniente, lamentamos que esto haya pasado favor de comunicarlo al soporte mediante el chat con el número: " + ERROR2.ToString, "ERROR")
    End Function

    Sub LlenarGridXProcedure(ByVal GridX As Object, ByVal sProcedureName As String, Optional ByVal cParams() As SqlParameter = Nothing, Optional ByVal sNameDataMember As String = Nothing, Optional ByVal bEsText As Boolean = False, Optional ByVal bMostrarMensaje As Boolean = True, Optional ByVal bEsLisBox As Boolean = False)
        If bMostrarMensaje Then
        End If
        Dim i As Integer
        Dim myDA As SqlDataAdapter
        Dim myDS As DataSet = New DataSet
        Try
            myDA = New Data.SqlClient.SqlDataAdapter(sProcedureName, sConexion)
            If bEsText Then
                myDA.SelectCommand.CommandType = CommandType.Text
            Else
                myDA.SelectCommand.CommandType = CommandType.StoredProcedure
                If cParams Is Nothing = False Then
                    For i = 0 To cParams.GetLength(0) - 1
                        If cParams(i) Is Nothing = False Then
                            myDA.SelectCommand.Parameters.Add(cParams(i))
                        End If
                    Next
                End If
            End If
            '-------------------------------
            If Trim(sNameDataMember) = Nothing Then
                sNameDataMember = sProcedureName
            End If
            '-------------------------------
            myDA.Fill(myDS, sNameDataMember)

            '---------------------------
            'LIMPIO PREVIAMENTE LOS DATOS
            GridX.DataSource = Nothing
            '---------------------------

            With GridX

                If TypeName(GridX) = "DataGridView" Then
                    .RowsDefaultCellStyle.BackColor = Color.White
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                End If

                If Not bEsLisBox Then
                    .DataMember = sNameDataMember
                End If

                .DataSource = myDS
            End With
        Catch ex As SystemException
            Guardar_Error(modulo, ex.Message, operador, sProcedureName, formulario)
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If bMostrarMensaje Then
                '     dlg.Close()
            End If
            myDA.Dispose()
        End Try
    End Sub
#End Region
#Region "Sin Referencia"
    'Sub CajaMensaje(ByVal form As Form, ByVal Stexto As String)
    '    Try

    '        Dim desktopSize As Size
    '        'desktopSize = Wisej.Web.SystemInformation.PrimaryMonitorSize

    '        'Wisej.Web.Screen. 
    '        Dim height As Integer = desktopSize.Height
    '        Dim width As Integer = desktopSize.Width


    '        Dim mobjPanel1 = New Wisej.Web.Panel()

    '        form.Controls.RemoveByKey("mobjPanel")

    '        'mobjPanel.BackgroundImageSource = Gizmox.WebGUI.Server.Resources.GetString("mobjPanel.BackgroundImage";

    '        mobjPanel1.BackgroundImage = Image.FromFile("C:\Users.END USER\Pictures\fondo01.jpg")

    '        mobjPanel1.BackgroundImageLayout = Wisej.Web.ImageLayout.Center
    '        If form.WindowState = FormWindowState.Maximized Then
    '            mobjPanel1.Location = New System.Drawing.Point((width / 2) - 107.5, height + 100)
    '            mobjPanel1.VisualEffect = New Wisej.Web.VisualEffects.TranslateVisualEffect(New Wisej.Web.VisualEffects.AxisLengthAndUnits(Wisej.Web.VisualEffects.LengthUnits.Pixel, Wisej.Web.VisualEffects.LengthUnits.Pixel, Wisej.Web.VisualEffects.LengthUnits.Pixel, Nothing, Nothing, Nothing), New Wisej.Web.VisualEffects.AxisLengthAndUnits(Wisej.Web.VisualEffects.LengthUnits.Pixel, Wisej.Web.VisualEffects.LengthUnits.Pixel, Wisej.Web.VisualEffects.LengthUnits.Pixel, 0, -(height / 2) - 100, Nothing), New Decimal(New Integer() {1, 0, 0, 0}), New Decimal(New Integer() {0, 0, 0, 0}), Wisej.Web.VisualEffects.TransitionTimingFunction.Ease)

    '        Else
    '            mobjPanel1.Location = New System.Drawing.Point((form.ClientSize.Width / 2) - 107.5, form.ClientSize.Height + 100)
    '            mobjPanel1.VisualEffect = New Wisej.Web.VisualEffects.TranslateVisualEffect(New Wisej.Web.VisualEffects.AxisLengthAndUnits(Wisej.Web.VisualEffects.LengthUnits.Pixel, Wisej.Web.VisualEffects.LengthUnits.Pixel, Wisej.Web.VisualEffects.LengthUnits.Pixel, Nothing, Nothing, Nothing), New Wisej.Web.VisualEffects.AxisLengthAndUnits(Wisej.Web.VisualEffects.LengthUnits.Pixel, Wisej.Web.VisualEffects.LengthUnits.Pixel, Wisej.Web.VisualEffects.LengthUnits.Pixel, 0, -(form.ClientSize.Height / 2) - 100, Nothing), New Decimal(New Integer() {1, 0, 0, 0}), New Decimal(New Integer() {0, 0, 0, 0}), Wisej.Web.VisualEffects.TransitionTimingFunction.Ease)

    '        End If
    '        X = (height / 2)

    '        'mobjPanel1.Anchor = AnchorStyles.Bottom
    '        mobjPanel1.Name = "mobjPanel"
    '        mobjPanel1.Size = New System.Drawing.Size(215, 100)
    '        mobjPanel1.TabIndex = 11

    '        mobjPanel1.Visible = True
    '        mobjPanel1.BringToFront()

    '        AddHandler mobjPanel1.TransitionVisualEffectEnd, AddressOf EfectoAcabado


    '        'mobjPanel1.VisualEffect = New Wisej.Web.VisualEffects.TranslateVisualEffect(New Wisej.Web.VisualEffects.AxisLengthAndUnits(Wisej.Web.VisualEffects.LengthUnits.Pixel, Wisej.Web.VisualEffects.LengthUnits.Pixel, Wisej.Web.VisualEffects.LengthUnits.Pixel, Nothing, Nothing, Nothing), New Wisej.Web.VisualEffects.AxisLengthAndUnits(Wisej.Web.VisualEffects.LengthUnits.Pixel, Wisej.Web.VisualEffects.LengthUnits.Pixel, Wisej.Web.VisualEffects.LengthUnits.Pixel, 0, 100, Nothing), New Decimal(New Integer() {1, 0, 0, 0}), New Decimal(New Integer() {0, 0, 0, 0}), Wisej.Web.VisualEffects.TransitionTimingFunction.Ease)
    '        'mobjPanel1.VisualEffect = New Wisej.Web.VisualEffects.TranslateVisualEffect(New Wisej.Web.VisualEffects.AxisLengthAndUnits(Wisej.Web.VisualEffects.LengthUnits.Pixel, Wisej.Web.VisualEffects.LengthUnits.Pixel, Wisej.Web.VisualEffects.LengthUnits.Pixel, Nothing, Nothing, Nothing), New Wisej.Web.VisualEffects.AxisLengthAndUnits(Wisej.Web.VisualEffects.LengthUnits.Pixel, Wisej.Web.VisualEffects.LengthUnits.Pixel, Wisej.Web.VisualEffects.LengthUnits.Pixel, 0, -100, Nothing), New Decimal(New Integer() {1, 0, 0, 0}), New Decimal(New Integer() {0, 0, 0, 0}), Wisej.Web.VisualEffects.TransitionTimingFunction.Ease)


    '        form.Controls.Add(mobjPanel1)



    '    Catch ex As SystemException
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        cErrors += " " & ex.Message
    '    End Try
    'End Sub
    'Function Ejecutar_Procedure(ByVal sProcedureName As String, Optional ByVal sNombreCampoRetornar As String = Nothing, Optional ByVal cParams() As SqlParameter = Nothing, Optional ByVal bMostrarMensaje As Boolean = True, Optional ByVal bEsTexto As Boolean = False) As SqlCommand
    '    Dim i As Integer
    '    Conectar()
    '    Try
    '        Dim cCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand(sProcedureName, cConnect)
    '        If bEsTexto Then
    '            cCommand.CommandType = CommandType.Text
    '        Else
    '            cCommand.CommandType = CommandType.StoredProcedure
    '        End If

    '        'cCommand.Parameters.Add("@Descripcion", sDescripcion)
    '        If cParams Is Nothing = False Then
    '            For i = 0 To cParams.GetLength(0) - 1
    '                If cParams(i) Is Nothing = False Then
    '                    cCommand.Parameters.Add(cParams(i))
    '                End If
    '            Next
    '        End If
    '        '***********************************************************
    '        If Trim(sNombreCampoRetornar) <> Nothing Then
    '            Dim parameterConsecutivo As New SqlParameter(sNombreCampoRetornar, SqlDbType.Int)
    '            parameterConsecutivo.Direction = ParameterDirection.Output
    '            cCommand.Parameters.Add(parameterConsecutivo)
    '            '***********************************************************
    '            ' Open the database connection and execute the command
    '            cCommand.ExecuteNonQuery()
    '            'If Not parameterConsecutivo.Value Is Nothing And Not parameterConsecutivo.Value Is System.DBNull.Value Then
    '            '    fGuardar_O_EliminarXProcedure = True
    '            'Else
    '            '    fGuardar_O_EliminarXProcedure = False
    '            '    If bMostrarMensaje Then
    '            '        'Messagebox.show("Error al realizar la operación,por favor, intentelo de nuevo ",ofunciones.MessageBoxStyle.Information, "Aviso")
    '            '        cErrors += " " & "Error al realizar la operación,por favor, intentelo de nuevo "
    '            '    End If
    '            'End If
    '        Else
    '            cCommand.ExecuteNonQuery()
    '            ''    fGuardar_O_EliminarXProcedure = True
    '        End If
    '        Return cCommand
    '    Catch ex As Exception
    '        'Messagebox.show("Error: " & ex.Message,ofunciones.MessageBoxStyle.Critical, "Aviso")
    '        'cErrors += " " & ex.Message
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        'fGuardar_O_EliminarXProcedure = False
    '    Finally
    '        'Desconectar()
    '    End Try
    'End Function
    'Public Sub ErrorsClear()
    '    cErrors = ""
    'End Sub
    'Sub FormsOpen(ByVal sModuloOpen As String, ByVal cForms As Wisej.Web.Form, ncontador As Integer)
    '    'Application.Current.Session("MODULO") = sModuloOpen
    '    'For x As Integer = 0 To Forms.Length - 1
    '    '    If Forms(x) Is Nothing = False Then
    '    '        Forms(x).Close()
    '    '    End If
    '    'Next
    '    'Forms(ncontador) = cForms
    '    'Forms(ncontador).Text = "MODULO DE " & sModuloOpen
    '    'Forms(ncontador).Tag = sModuloOpen
    '    'Forms(ncontador).Show()
    'End Sub
    'Public Function fDevuelve_Saldo_Cuenta_Contable2(ByVal defaultV As System.Data.DataView, ByVal sCve_Cuenta As String, ByVal EsSuma As Boolean, ByVal F_Inicio As String, ByVal F_Fin As String, Optional ByVal bEsCuenta_Economica As Boolean = True, Optional ByVal sCampo As String = "", Optional ByVal sNivel As Integer = 0, Optional ByVal sCampo2 As String = "") As Double
    '    Dim total, saldo, SInicial, s_Anterior, sActual, Ingresos, Gastos As Double
    '    Dim bPasa As Boolean = True
    '    'Conectar()

    '    defaultV.RowFilter = "FECHA_INICIO=" & F_Inicio & " AND CUENTAS='" & sCve_Cuenta & "'" & " AND FECHA_FIN='" & F_Fin & "'"

    '    Dim objDT = defaultV.ToTable()

    '    'Dim X As Integer = 1

    '    'sArraysMesesDic.Add(X, )
    '    'X += 1
    '    'Next

    '    'Else
    '    'For i = 1 To 12
    '    '    sArraysMesesDic.Add(i, False)

    '    'Next
    '    'Dim cDataReader As Data.SqlClient.SqlDataReader
    '    Try
    '        '    cCommand = New SqlClient.SqlCommand("pESTADOS_FINANCIEROS_B", cConnect)
    '        '    cCommand.CommandType = CommandType.StoredProcedure
    '        '    cCommand.Parameters.AddWithValue("@CUENTAS", sCve_Cuenta)
    '        '    cCommand.Parameters.AddWithValue("@FECHA_INICIO", F_Inicio)
    '        '    cCommand.Parameters.AddWithValue("@FECHA_FIN", F_Fin)
    '        '    If Application.Current.Session("CVE_FUENTE_FINANCIAMIENTO") <> Nothing Then
    '        '        cCommand.Parameters.AddWithValue("@CVE_FUENTE_FINANCIAMIENTO", Application.Current.Session("CVE_FUENTE_FINANCIAMIENTO"))
    '        '    End If
    '        '    cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
    '        '    If cDataReader.HasRows Then
    '        '        While (cDataReader.Read)
    '        For i = 1 To objDT.Columns.Count - 1


    '            'If sCampo <> "ACTIVIDAD" Then
    '            '    If bEsCuenta_Economica Then
    '            '        If sCampo = "VARIACION" And sCampo2 = "VARIACION_ACUMULADA" Then
    '            '            If sCve_Cuenta = "1.1.1.1.0,1.1.1.2.0" Then
    '            '                total = total + objDT.Columns(sCampo)(i)
    '            '            Else
    '            '                If EsSuma Then
    '            '                    total = total + cDataReader.Item(sCampo2)
    '            '                Else
    '            '                    total = cDataReader.Item(sCampo)
    '            '                End If
    '            '            End If
    '            '        Else
    '            '            If sNivel = 12 Then
    '            '                If (cDataReader.Item("COD_CUENTA") = "1.1.1.1.0" Or cDataReader.Item("COD_CUENTA") = "1.1.1.2.0") Then
    '            '                    If bPasa Then
    '            '                        saldo = cDataReader.Item(sCampo2)
    '            '                        bPasa = False
    '            '                    Else
    '            '                        sActual = cDataReader.Item(sCampo2)
    '            '                        SInicial = saldo + sActual
    '            '                        If SInicial < 0 Then
    '            '                            SInicial = 0
    '            '                        End If

    '            '                    End If

    '            '                Else
    '            '                    total = total + cDataReader.Item(sCampo2) + SInicial
    '            '                End If
    '            '            Else
    '            '                If EsSuma Then

    '            '                    saldo = cDataReader.Item("SALDO_ACTUAL")
    '            '                    If saldo < 0 Then
    '            '                        saldo = saldo * -1
    '            '                    End If
    '            '                    total = total + saldo
    '            '                    If total < 0 Then
    '            '                        total = total * -1
    '            '                    End If
    '            '                Else
    '            '                    total = cDataReader.Item("SALDO_ACTUAL")
    '            '                End If
    '            '                SInicial = cDataReader.Item("S_INICIAL")
    '            '                total = total - SInicial
    '            '            End If


    '            '        End If
    '            '    Else
    '            '        If EsSuma Then
    '            '            If sCampo2 = "VARIACION" Then
    '            '                total = total + cDataReader.Item(sCampo2)
    '            '            ElseIf sCampo = "ANTERIOR" Then
    '            '                total = total + cDataReader.Item("S_ULTIMO_PERIODO")
    '            '            ElseIf sCampo = "ACTUAL" Then
    '            '                total = total + cDataReader.Item("SALDO_ACTUAL")
    '            '            End If
    '            '        Else
    '            '            If sCampo2 = "VARIACION" Then
    '            '                total = cDataReader.Item(sCampo2)
    '            '            End If
    '            '            If sCampo = "GASTOS_INGRESOS" Then
    '            '                If sCampo2 = "ACTUAL" Then
    '            '                    If bPasa Then
    '            '                        saldo = cDataReader.Item("SALDO_ACTUAL")
    '            '                        bPasa = False
    '            '                    Else
    '            '                        sActual = cDataReader.Item("SALDO_ACTUAL")
    '            '                    End If
    '            '                    If bPasa = False Then
    '            '                        saldo = Math.Abs(saldo)
    '            '                        sActual = Math.Abs(sActual)
    '            '                        total = saldo - sActual
    '            '                    End If
    '            '                Else
    '            '                    If bPasa Then
    '            '                        saldo = cDataReader.Item("S_ULTIMO_PERIODO")
    '            '                        bPasa = False
    '            '                    Else
    '            '                        sActual = cDataReader.Item("S_ULTIMO_PERIODO")
    '            '                    End If
    '            '                    If bPasa = False Then
    '            '                        saldo = Math.Abs(saldo)
    '            '                        sActual = Math.Abs(sActual)
    '            '                        total = saldo - sActual
    '            '                    End If
    '            '                End If
    '            '            End If
    '            '        End If
    '            '        If total < 0 And EsSuma = True And sNivel <> 25 And sNivel <> 17 And sNivel <> 18 Then
    '            '            total = total * -1
    '            '        End If
    '            '    End If
    '            'Else
    '            '    If sCampo2 = "ACTUAL" Then
    '            '        If sNivel = 1 Then
    '            '            If EsSuma Then
    '            '                total = total + cDataReader.Item("SALDO_ACTUAL")
    '            '            End If
    '            '        Else
    '            '            If EsSuma Then
    '            '                If bPasa Then
    '            '                    Ingresos = cDataReader.Item("SALDO_ACTUAL")
    '            '                    bPasa = False
    '            '                Else
    '            '                    Gastos = cDataReader.Item("SALDO_ACTUAL")
    '            '                End If

    '            '                total = Ingresos - Gastos
    '            '            Else
    '            '                total = cDataReader.Item("SALDO_ACTUAL")
    '            '            End If
    '            '        End If
    '            '    Else
    '            '        If sNivel = 1 Then
    '            '            If EsSuma Then
    '            '                total = total + cDataReader.Item("S_ULTIMO_PERIODO")
    '            '            End If
    '            '        Else
    '            '            If EsSuma Then
    '            '                If bPasa Then
    '            '                    Ingresos = cDataReader.Item("S_ULTIMO_PERIODO")
    '            '                    bPasa = False
    '            '                Else
    '            '                    Gastos = cDataReader.Item("S_ULTIMO_PERIODO")
    '            '                End If

    '            '                total = Ingresos - Gastos
    '            '            Else
    '            '                total = cDataReader.Item("S_ULTIMO_PERIODO")
    '            '            End If
    '            '        End If
    '            '    End If

    '        Next
    '        'End If
    '        '    End While

    '    Catch ex As Exception
    '        MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        'If IsNothing(cDataReader) = False Then
    '        '    If cDataReader.IsClosed = False Then cDataReader.Close()
    '        'End If
    '        'Desconectar()
    '    End Try
    '    Return total
    'End Function
    'Public Function RemoveDiacritics(ByVal stIn As String) As String
    '    Dim stFormD As String = stIn.Normalize(NormalizationForm.FormD)
    '    Dim sb As New StringBuilder()
    '    For ich As Integer = 0 To stFormD.Length - 1
    '        Dim uc As UnicodeCategory = CharUnicodeInfo.GetUnicodeCategory(stFormD(ich))
    '        If uc <> UnicodeCategory.NonSpacingMark Then
    '            sb.Append(stFormD(ich))
    '        End If
    '    Next
    '    Return (sb.ToString().Normalize(NormalizationForm.FormC))
    'End Function
    'Function obTener_Descripcion_TiempoReal(ByVal cControl As combosax, Optional ByVal sColumnaName As String = "Descripcion", Optional ByVal sColumnaWHERE As String = Nothing, Optional ByVal WHERE As String = Nothing) As String
    '    Dim SWHERE As String
    '    If cControl.SelectedIndex = -1 Then
    '        Return Nothing
    '    Else
    '        SWHERE = cControl.list_llenado.ValueMember & "='" & cControl.SelectedValue & "'"
    '        If sColumnaWHERE <> Nothing Then
    '            SWHERE = SWHERE + "AND " + sColumnaWHERE & "='" & WHERE & "'"
    '        End If


    '        cControl.TextBox1_EnterKeyDown(1, Nothing)


    '        Dim defaultV = cControl.DataSource.Tables(0).DefaultView
    '        defaultV.RowFilter = SWHERE

    '        Dim objDT = defaultV.ToTable()
    '        If objDT.Rows.Count <> 0 And sColumnaName <> "" Then
    '            Return objDT.Rows.Item(0).Item(sColumnaName).ToString()
    '        Else
    '            Return Nothing

    '        End If
    '    End If
    'End Function
    'Sub remueve_Fila(ByVal cControl As combosax, ByVal iColumnIndex As Integer)


    '    'If cControl.SelectedIndex = -1 Then
    '    '    Return Nothing
    '    'Else

    '    '    Dim defaultV = cControl.DataSource.Tables(0).DefaultView
    '    '    'defaultV.RowFilter = SWHERE

    '    '    Dim objDT = defaultV.ToTable()
    '    '    If objDT.Rows.Count <> 0 And sColumnaName <> "" Then
    '    '        Return objDT.Rows.Item(0).Item(sColumnaName).ToString()
    '    '    Else
    '    '        Return Nothing

    '    '    End If
    '    'End If

    '    'If cControl.SelectedIndex <> -1 And iColumnIndex <> -1 Then
    '    '    Dim dt As DataTable = DirectCast(cControl.DataSource, DataTable)
    '    '    dt.Rows.RemoveAt(iColumnIndex)
    '    '    cControl.RemoveItem(iColumnIndex)
    '    'End If
    'End Sub
    'Function LlenarDatasetXProcedure(ByVal sProcedureName As String, Optional ByVal cParams() As SqlParameter = Nothing, Optional ByVal sNameDataMember As String = Nothing, Optional ByVal bEsText As Boolean = False, Optional ByVal bMostrarMensaje As Boolean = True, Optional ByVal bEsLisBox As Boolean = False) As DataSet
    '    If bMostrarMensaje Then
    '    End If
    '    Dim i As Integer
    '    Dim myDA As SqlDataAdapter
    '    Dim myDS As DataSet = New DataSet
    '    Try
    '        myDA = New Data.SqlClient.SqlDataAdapter(sProcedureName, sConexion)
    '        If bEsText Then
    '            myDA.SelectCommand.CommandType = CommandType.Text
    '        Else
    '            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
    '            If cParams Is Nothing = False Then
    '                For i = 0 To cParams.GetLength(0) - 1
    '                    If cParams(i) Is Nothing = False Then
    '                        myDA.SelectCommand.Parameters.Add(cParams(i))
    '                    End If
    '                Next
    '            End If
    '        End If
    '        '-------------------------------
    '        If Trim(sNameDataMember) = Nothing Then
    '            sNameDataMember = sProcedureName
    '        End If
    '        '-------------------------------
    '        myDA.Fill(myDS, sNameDataMember)

    '        Return myDS
    '    Catch ex As SystemException
    '        'Messagebox.show("Error: " & ex.Message,ofunciones.MessageBoxStyle.Critical, "Aviso")
    '        Return Nothing
    '    Finally
    '        If bMostrarMensaje Then
    '            '     dlg.Close()
    '        End If
    '        myDA.Dispose()
    '    End Try
    'End Function
    'Function GridxArrayEliminarRepetidosOrdenados(ByVal sArray() As Wisej.Web.DataGridView) As Wisej.Web.DataGridView()
    '    Dim sArrayDevuelve(0) As Wisej.Web.DataGridView
    '    Dim nConsecutivo As Integer = 0
    '    For nContador As Integer = 0 To sArray.Length - 1 Step 1
    '        If sArray(nContador) Is Nothing = False Then
    '            If nConsecutivo = 0 Then
    '                sArrayDevuelve(0) = sArray(nContador)
    '                nConsecutivo = 1
    '            ElseIf sArray(nContador).Name <> sArray(nContador - 1).Name Then
    '                ReDim Preserve sArrayDevuelve(nConsecutivo)
    '                sArrayDevuelve(nConsecutivo) = sArray(nContador)
    '                nConsecutivo = nConsecutivo + 1
    '            End If
    '        End If
    '    Next
    '    Return sArrayDevuelve
    'End Function
    'Sub Subtotal_Suma_Inversion_Partidas(ByVal Grid As Wisej.Web.DataGridView)
    '    Dim nRow As Integer
    '    Dim sTotal As Double = 0

    '    For nRow = 0 To Grid.RowCount - 1
    '        sTotal = 0
    '        For nCol = 1 To 12
    '            sTotal = sTotal + Convert.ToDouble(Grid.Item(nCol.ToString, nRow).Value)
    '        Next nCol
    '        Grid.Item("TOTAL", nRow).Value = sTotal
    '    Next nRow
    'End Sub
    'Public Function Encriptar(ByVal EncriptString As String) As String
    '    Dim strEncriptar As String = ""
    '    If EncriptString <> "" Then
    '        Try
    '            bytString = ue.GetBytes(EncriptString)
    '            bytEncriptar = sec.Encrypt(bytString, False)
    '            strEncriptar = Convert.ToBase64String(bytEncriptar)
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End If
    '    Return strEncriptar
    'End Function
    'Public Function Desencriptar(ByVal TextEncripted As String) As String
    '    Dim strDesencriptar As String = ""
    '    If TextEncripted <> "" Then
    '        Try
    '            bytDesEncriptar = sec.Decrypt(Convert.FromBase64String(TextEncripted), False)
    '            strDesencriptar = ue.GetString(bytDesEncriptar)
    '        Catch ex As Exception
    '            MessageBox.Show("No se realizo la Desencripción " + ex.Message, "...", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End If
    '    Return strDesencriptar
    'End Function
    'Function sDevolver_Seleccionados(ByVal sCve_Campo As String, ByVal oDataGrid As Wisej.Web.DataGridView)
    '    Dim sId_Seleccionado As String
    '    Dim i As Integer
    '    For i = 0 To oDataGrid.RowCount - 1
    '        If oDataGrid.Item("DataGridSelecciono", i).Value = True Then
    '            sId_Seleccionado = sId_Seleccionado & oDataGrid.Item(sCve_Campo, i).Value & ","
    '        End If
    '    Next

    '    If Trim(sId_Seleccionado) = Nothing Then sId_Seleccionado = "-99"
    '    Return sId_Seleccionado
    'End Function
    'Function pQuery(ByVal sCampo As String, ByVal bEsNumerico As Boolean, Optional ByVal sWhere As String = Nothing) As String
    '    If sWhere = Nothing Then
    '        Return Nothing
    '    End If
    '    'Dim sCampo As String = "CLAVE"
    '    Dim sTokens_Inicial As String = "'%"
    '    Dim sTokens_Final As String = "%'"
    '    Dim sOperacion = " Like "
    '    If bEsNumerico Then
    '        sTokens_Inicial = Nothing
    '        sTokens_Final = Nothing
    '        sOperacion = " = "
    '    End If
    '    If Trim(sWhere) <> Nothing Then
    '        sWhere = sCampo & sOperacion & sTokens_Inicial & sWhere & sTokens_Final
    '    End If
    '    Return sWhere
    'End Function
    'Sub Formato_texto_mayusculas_minusculas(ByVal label As Object)
    '    label.text = StrConv(label.text, VbStrConv.ProperCase, 1)
    'End Sub
    'Sub Consultar_DatosX(ByVal Frm As Wisej.Web.Form, ByVal C1DbNavigator1 As Object, ByVal sNameDataMember As String, ByVal myDS As BindingSource, ByVal sId_Primary As String)
    '    'Dim dlg As New DevExpress.Utils.WaitDialogForm("Realizando consulta ..", "Procesando, Espere por favor ..")

    '    '**********************************************     
    '    Try
    '        ' Frm.BindingContext = New BindingContext()
    '        'C1DbNavigator1.BindingContext = New BindingContext()
    '        ' Dim context As BindingContext = New BindingContext()
    '        'Frm.BindingContext = context
    '        'gridEX1.BindingContext = context;

    '        'gridEX2.BindingContext = context;

    '        '        textBox1.BindingContext = context
    '        'Dim x As Wisej.Web.BindingNavigator
    '        'x.BindingSource
    '        'x.D()
    '        'x.D()

    '        With C1DbNavigator1
    '            .BindingSource = myDS
    '            ' .DataSource = myDS
    '            ' .DataMember = sNameDataMember
    '            '.BindingContext = context
    '            '.Update()
    '            '.Refresh()

    '        End With

    '        'Frm.BindingContext = New BindingContext
    '        Call Asignar(Frm, myDS, "", "", )

    '        ' C1DbNavigator1.Update()
    '        ' C1DbNavigator1.Refresh()
    '        '  Frm.DataBindings.Clear()
    '        ' Frm.DataBindings.Add(New Wisej.Web.Binding("Tag", myDS, sNameDataMember & "." & sId_Primary))

    '    Catch ex As SystemException
    '        'MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Aviso")
    '        MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        ' dlg.Close()
    '        'myDA.Dispose()
    '    End Try
    'End Sub
    'Sub Llenar_CheckedComboBox(ByVal sNameProcedure As String, ByVal sId As String, ByVal sDescripcion As String, ByVal cControl As Object, Optional ByVal cParams() As SqlParameter = Nothing, Optional ByVal bEsText As Boolean = False, Optional ByVal nSetWidth As Integer = 150)
    '    Dim i As Integer
    '    Conectar()
    '    Dim cDataReader As Data.SqlClient.SqlDataReader
    '    Try
    '        cControl.clear()
    '        cControl.Items.Clear()

    '        cCommand = New SqlClient.SqlCommand(sNameProcedure, cConnect)

    '        If bEsText Then
    '            cCommand.CommandType = CommandType.Text
    '        Else
    '            cCommand.CommandType = CommandType.StoredProcedure
    '            If cParams Is Nothing = False Then
    '                For i = 0 To cParams.GetLength(0) - 1
    '                    If cParams(i) Is Nothing = False Then
    '                        cCommand.Parameters.Add(cParams(i))
    '                    End If
    '                Next
    '            End If
    '        End If


    '        cControl.SetWidth(nSetWidth)
    '        cCommand.Prepare()
    '        cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
    '        ' cDataReader.
    '        If cDataReader.HasRows Then


    '            While (cDataReader.Read)


    '                cControl.AddString(cDataReader.Item(sId), cDataReader.Item(sDescripcion), True)



    '                'If Trim(sCve_Acceso_Padre) <> cDataReader.Item("Cve_Acceso_Padre") Then
    '                '    If cDataReader.Item("Tipo") = "MODULO" Then
    '                '        nodeModulos = New TreeNode
    '                '        nodeModulos.Text = cDataReader.Item("descripcion")
    '                '        nodeModulos.Tag = "" & cDataReader.Item("URL")
    '                '        'nodeModulos.
    '                '        If Trim("" & cDataReader.Item("Icono")) <> Nothing Then
    '                '            nodeModulos.Image = New ImageResourceHandle(cDataReader.Item("Icono"))
    '                '        End If
    '                '        'nodeRoot.Nodes.Add(nodeModulos)
    '                '        ObjTreeView.Nodes.Add(nodeModulos)

    '                '    End If
    '                '    sCve_Acceso_Padre = cDataReader.Item("Cve_Acceso_Padre")
    '                'End If



    '            End While
    '        End If



    '    Catch ex As SystemException
    '        MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '    Finally
    '        If IsNothing(cDataReader) = False Then
    '            If cDataReader.IsClosed = False Then cDataReader.Close()
    '        End If
    '        Desconectar()
    '    End Try
    'End Sub
    ''Sub Mostrar_Formulario(ByVal cNodo As TreeNode, ByVal cPanel As Wisej.Web.HeaderedPanel)
    ''    'Sub Nodo(ByVal cNodo As TreeNode, ByVal cPanel As Wisej.Web.HeaderedPanel)
    ''    Dim objcontrol As Object = Nothing
    ''    Dim sModulo_Caption As String
    ''    Dim sTag As String
    ''    Select Case cNodo.Tag
    ''        Case "Fixed"
    ''            objcontrol = New Soporte_Tecnico_Fixed
    ''            sModulo_Caption = "Videos / Operación del Software"
    ''        Case "Soporte_Tecnico"
    ''            objcontrol = New Soporte_Tecnico
    ''            sModulo_Caption = "Soporte Técnico"
    ''        Case "Bitacora"
    ''            objcontrol = New Bitacora
    ''            sModulo_Caption = "Bitacora de Operaciones"

    ''        Case "Cedula_Capturar"

    ''            'objcontrol = New Contenedor_cedula
    ''            'sModulo_Caption = "Captura / Nueva Cedula"
    ''            'Application.Current.Session("modo") = "APROBADO,MODIFICADO"
    ''            Dim cedula_capturax As Contenedor_cedula
    ''            cedula_capturax = New Contenedor_cedula
    ''            cedula_capturax.Show()

    ''            'sModulo_Caption = "Modificaciones pendientes"
    ''            'Application.Current.Session("Modulo") = "./Cedulas/CONTENEDOR_DEL_CONTENEDOR.aspx"
    ''            'objcontrol = New Mostrar_Asp



    ''        Case "Cedula_Modificar"
    ''            objcontrol = New Cedula_Modificar
    ''            sModulo_Caption = "Captura / Modificar Cedula"

    ''        Case "Cedula_Aprobar_Modificaciones"
    ''            sModulo_Caption = "Modificaciones pendientes"
    ''            Application.Current.Session("Modulo") = "./Cedulas/Cedula_Aprobar_Modificaciones.aspx"
    ''            objcontrol = New Mostrar_Asp

    ''        Case "Cedula_Buscar"
    ''            sModulo_Caption = "Consulta de Cedula"
    ''            Application.Current.Session("Modulo") = "./Cedulas/Cedula_Buscar.aspx"
    ''            objcontrol = New Mostrar_Asp


    ''            '---------------------------------------REVISION-----------------------------------------------------------'
    ''        Case "Cedula_Revisado"
    ''            sModulo_Caption = "Revision de Proyecto"
    ''            Application.Current.Session("Modulo") = "./Cedulas/Cedula_Revisado.aspx?modo=APROBADO"
    ''            objcontrol = New Mostrar_Asp
    ''            '-----------------------------------------------------------------------------------------------------'




    ''        Case "Cedula_Supervisar" 'Este lo hace el supervisor
    ''            sModulo_Caption = "Supervision de Cedula"
    ''            Application.Current.Session("Modulo") = "./Cedulas/Cedula_Supervisar.aspx"
    ''            objcontrol = New Mostrar_Asp

    ''        Case "Cedula_Validar" '
    ''            sModulo_Caption = "Validación de Proyectos Externos (Finanzas)"
    ''            Application.Current.Session("Modulo") = "./Cedulas/Cedula_Validar.aspx?modo=APROBADO"
    ''            objcontrol = New Mostrar_Asp

    ''        Case "Cedula_Record_Rechazadas"
    ''            sModulo_Caption = "Record de Proyecto Rechazados"
    ''            Application.Current.Session("Modulo") = "./Cedulas/Cedula_Record_Rechazadas.aspx?modo=APROBADO"
    ''            objcontrol = New Mostrar_Asp

    ''            'Case "Cedula_Cambiar_Estatus"
    ''            '    sModulo_Caption = "Cambiar Estatus a Proyecto"
    ''            '    Application.Current.Session("Modulo") = "./Cedulas/Cedula_Cambiar_Estatus.aspx?modo=APROBADO"
    ''            '    objcontrol = New Mostrar_Asp

    ''        Case "Cedula_Validar_Tipo_Proyecto"
    ''            objcontrol = New Cedula_Registrar_Tipo_Proyecto
    ''            sModulo_Caption = "Registrar proyectos"


    ''        Case "Cedula_Exportar" 'Este lo hace el Aministrador"
    ''            objcontrol = New Cedula_Exportar
    ''            sModulo_Caption = "Exportar Cedulas"
    ''            Application.Current.Session("modo") = "APROBADO,MODIFICADO"

    ''        Case "Cedula_Pivot" 'Este lo hace el Aministrador"
    ''            sModulo_Caption = "Explorar Cedula / pivot"
    ''            Application.Current.Session("Modulo") = "./Cedulas/Cedula_Pivot.aspx"
    ''            objcontrol = New Mostrar_Asp

    ''        Case "Cedula_Imprimir"
    ''            objcontrol = New Cedula_Imprimir
    ''            sModulo_Caption = "Imprimir Cedulas"
    ''            Application.Current.Session("modo") = "APROBADO,MODIFICADO"

    ''        Case "Cedula_Folios_consecutivos"
    ''            objcontrol = New Cedula_Folios_consecutivos
    ''            sModulo_Caption = "Configurar Folios Consecutivos"

    ''        Case "Cedula_Bitacoras"
    ''            objcontrol = New Proyectos_REGISTRADOs
    ''            sModulo_Caption = "Movimiento / Bitacoras de proyectos"


    ''            ''Case "Ver_Infraestructura"
    ''            ''    objcontrol = New Ver_Infraestructura
    ''            ''    sModulo_Caption = "Infraestructura"

    ''        Case "Cedula_Cancelar_Registrados" 'Este lo hace el Aministrador"
    ''            sModulo_Caption = "Cancelar registrados"
    ''            Application.Current.Session("Modulo") = "./Cedulas/Cedula_Cancelar_Registrados.aspx"
    ''            objcontrol = New Mostrar_Asp

    ''        Case "Cedula_bloqueo_desbloqueo"
    ''            objcontrol = New Cedula_bloqueo_desbloqueo
    ''            sModulo_Caption = "Bloqueo / Desbloqueo"


    ''        Case "Cedula_Eliminadas"
    ''            sModulo_Caption = "Proyectos eliminados"
    ''            Application.Current.Session("Modulo") = "./Cedulas/Cedula_Eliminadas.aspx?modo=APROBADO"
    ''            objcontrol = New Mostrar_Asp

    ''        Case "Cedula_Asignar_Padre"
    ''            objcontrol = New Cedula_Asignar_Padre
    ''            sModulo_Caption = "Configuracion Proyectos y Procedencias Bolsa"

    ''        Case "Cedula_Clonar"
    ''            sModulo_Caption = "Clonación de Cedulas"
    ''            Application.Current.Session("Modulo") = "./Cedulas/Cedula_Clonar.aspx"
    ''            sModulo_Caption = "Clonación de Cedulas"
    ''            objcontrol = New Mostrar_Asp

    ''        Case "Cedula_Imprimir_Paquete"

    ''            objcontrol = New Cedula_Imprimir_Paquete
    ''            sModulo_Caption = "Cedula Imprimir Paquete de Cedulas"



    ''        Case "Cedula_Modificar_Masivo"
    ''            objcontrol = New Cedula_Modificar_Masivo
    ''            sModulo_Caption = "Modificación Masiva de Cedulas"

    ''            '---------------------------------------------------

    ''            '    '****************************
    ''            '    '' ANTEPROYECTO
    ''            '    '********************************
    ''        Case "Anteproyecto_Capturar"
    ''            objcontrol = New Cedula_Captura
    ''            sModulo_Caption = "Captura / Nuevo Anteproyecto"
    ''            objcontrol.Tag = "ANTEPROYECTO"
    ''            Application.Current.Session("modo") = "ANTEPROYECTO"

    ''            'Case "Anteproyecto_Buscar"
    ''            '    sModulo_Caption = "Consulta de Cedula"
    ''            '    Application.Current.Session("Modulo") = "./Cedulas/Cedula_Buscar.aspx"
    ''            '    sModulo_Caption = "Consulta de Anteproyecto"
    ''            '    objcontrol = New Mostrar_Asp


    ''            '--------------------------------------------REVISION-----------------------------------------------------------------'
    ''        Case "Anteproyecto_Revisado"
    ''            sModulo_Caption = "Revision de Anteproyecto"
    ''            Application.Current.Session("Modulo") = "./Cedulas/Cedula_Revisado.aspx?modo=ANTEPROYECTO"
    ''            objcontrol = New Mostrar_Asp
    ''            ''---------------------------------------------------------------------------------------------------------------'



    ''            'Case "Anteproyecto_Supervisar" 'Este lo hace el superviso
    ''            '    sModulo_Caption = "Supervisión de Anteproyecto"
    ''            '    Application.Current.Session("Modulo") = "./Cedulas/Cedula_Supervisar.aspx"
    ''            '    objcontrol = New Mostrar_Asp

    ''        Case "Anteproyecto_Validar_Tipo_Proyecto"
    ''            objcontrol = New Cedula_Registrar_Tipo_Proyecto
    ''            sModulo_Caption = "Aprobar proyectos"
    ''            'objcontrol.Tag = "ANTEPROYECTO"


    ''        Case "Anteproyecto_Cambiar_Estatus"
    ''            sModulo_Caption = "Cambiar Estatus a Anteproyecto"
    ''            Application.Current.Session("Modulo") = "./Cedulas/Cedula_Cambiar_Estatus.aspx"
    ''            objcontrol = New Mostrar_Asp

    ''            'Case "Anteproyecto_Pivot" 'Este lo hace el Aministrador"
    ''            '    sModulo_Caption = "Explorar Anteproyecto / pivot"
    ''            '    Application.Current.Session("Modulo") = "./Cedulas/Cedula_Pivot.aspx"
    ''            '    objcontrol = New Mostrar_Asp


    ''            'Case "Anteproyecto_Imprimir"
    ''            '    objcontrol = New Cedula_Imprimir
    ''            '    sModulo_Caption = "Imprimir Anteproyectos"
    ''            '    Application.Current.Session("modo") = "ANTEPROYECTO"

    ''            'Case "Anteproyecto_Exportar" 'Este lo hace el Aministrador"
    ''            '    objcontrol = New Cedula_Exportar
    ''            '    sModulo_Caption = "Exportar Anteproyectos"
    ''            '    Application.Current.Session("modo") = "ANTEPROYECTO"

    ''            'Case "Anteproyecto_Bitacoras"
    ''            '    objcontrol = New Proyectos_REGISTRADOs
    ''            '    sModulo_Caption = "Movimiento / Bitacoras de Anteproyectos"


    ''            'Case "Anteproyecto_Record_Rechazadas"
    ''            '    sModulo_Caption = "Record de Anteproyecto Rechazados"
    ''            '    Application.Current.Session("Modulo") = "./Cedulas/Cedula_Record_Rechazadas.aspx"
    ''            '    objcontrol = New Mostrar_Asp

    ''            'Case "Anteproyecto_Cancelar_Registrados" 'Este lo hace el Aministrador"
    ''            '    sModulo_Caption = "Cancelar anteproyectos aprobados"
    ''            '    Application.Current.Session("Modulo") = "./Cedulas/Cedula_Cancelar_Registrados.aspx"
    ''            '    objcontrol = New Mostrar_Asp

    ''            'Case "Anteproyecto_bloqueo_desbloqueo"
    ''            '    objcontrol = New Cedula_bloqueo_desbloqueo
    ''            '    sModulo_Caption = "Bloqueo / Desbloqueo"

    ''            '--------------------------------------------------------

    ''        Case "Impresion_Avances"
    ''            objcontrol = New Avances_Metas_Impresion
    ''            sModulo_Caption = "Impresion de Avances"

    ''            ''Case "Imprimir_Indicadores"
    ''            ''    Dim Frm_Imprimir_Indicador As Indicadores_Impresion
    ''            ''    Frm_Imprimir_Indicador = New Indicadores_Impresion
    ''            ''    Frm_Imprimir_Indicador.ShowDialog()

    ''            ''Case "Insumos_Capturar"
    ''            ''    objcontrol = New Insumos_Capturar
    ''            ''    sModulo_Caption = "Captura de insumos"

    ''            ''Case "Insumos_Tabla_dinamica"
    ''            ''    sModulo_Caption = "Consulta de Insumos"
    ''            ''    Application.Current.Session("Modulo") = "./Insumos/Insumos_Tabla_dinamica.aspx"
    ''            ''    objcontrol = New Mostrar_Asp

    ''        Case "Cuenta_Carga_Masiva"
    ''            objcontrol = New Cuenta_Carga_Masiva    'Cuentas_Capturar
    ''            sModulo_Caption = "Carga Masiva de Cuenta"
    ''            Application.Current.Session("modo") = "ANTEPROYECTO"

    ''            '*******************************
    ''            ''''CUENTAS
    ''            '*******************************


    ''            ''Case "Cuenta_Captura"
    ''            ''    objcontrol = New Cuentas_Capturar   'Cuentas_Capturar
    ''            ''    sModulo_Caption = "Captura de Cuentas"
    ''        Case "Cuenta_Carga_Masiva"
    ''            objcontrol = New Cuenta_Carga_Masiva    'Cuentas_Capturar
    ''            sModulo_Caption = "Carga Masiva de Cuenta"
    ''        Case "Cuenta_Buscar"
    ''            sModulo_Caption = "Consulta de Cuentas"
    ''            Application.Current.Session("Modulo") = "./Cuentas/Cuentas_Buscar.aspx"
    ''            objcontrol = New Mostrar_Asp
    ''        Case "Cuenta_Pivot"
    ''            sModulo_Caption = "Explorar Cuenta / pivot"
    ''            Application.Current.Session("Modulo") = "./Cuentas/Cuentas_Pivot.aspx"
    ''            objcontrol = New Mostrar_Asp
    ''        Case "Cuentas_Supervisar"
    ''            sModulo_Caption = "Supervision de Cuentas"
    ''            Application.Current.Session("Modulo") = "./Cuentas/Cuentas_Supervisar.aspx"
    ''            objcontrol = New Mostrar_Asp

    ''        Case "Generador_No_Oficio"
    ''            objcontrol = New Generador_No_Oficio
    ''            sModulo_Caption = "Generador No. de Oficio"
    ''        Case "Generador_No_Proyectos"
    ''            objcontrol = New Generador_No_Proyectos
    ''            sModulo_Caption = "Generador No. de Proyectos"
    ''        Case "Generador_Imprimir"
    ''            objcontrol = New Generador_Imprimir
    ''            sModulo_Caption = "Impresion de reportes del Generador"

    ''        Case "GENERADOR_IMPRIMIR_2"
    ''            objcontrol = New GENERADOR_IMPRIMIR_2
    ''            sModulo_Caption = "Impresion de Oficio de CG"


    ''            '*******************************
    ''            ''''AMPLIACIONES / REDUCCIONES
    ''            '*******************************
    ''        Case "Ampliaciones_Reducciones"
    ''            sModulo_Caption = "Ampliacion / Reducción"

    ''            Dim Adecuaciones_Cuentas_FormX As Adecuaciones_Ingresos_Captura_Movimientos
    ''            Adecuaciones_Cuentas_FormX = New Adecuaciones_Ingresos_Captura_Movimientos
    ''            Adecuaciones_Cuentas_FormX.Show()
    ''            Exit Sub
    ''            'objcontrol = New Adecuaciones_Cuentas

    ''        Case "editar_justificacion"
    ''            sModulo_Caption = "Editar Justificaion"
    ''            objcontrol = New editar_justificacion

    ''        Case "Adecuaciones_Asignar_Unidad"
    ''            sModulo_Caption = "Asignar unidad al movimiento presupuestal"
    ''            Application.Current.Session("Modulo") = "./Movimiento_Presupuestal/Adecuaciones/Adecuaciones_Asignar_Unidad.aspx"
    ''            objcontrol = New Mostrar_Asp

    ''        Case "Adecuaciones_Busqueda"
    ''            sModulo_Caption = "Consulta de movimientos presupuestales (Ampliación / Reducción)"
    ''            objcontrol = New Adecuaciones_Busqueda

    ''        Case "Adecuaciones_Justificar"
    ''            sModulo_Caption = "Justificar movimiento presupuestal"
    ''            Application.Current.Session("Modulo") = "./Movimiento_Presupuestal/Adecuaciones/Adecuaciones_Justificar.aspx"
    ''            objcontrol = New Mostrar_Asp

    ''        Case "Adecuaciones_Revisar"
    ''            sModulo_Caption = "Revisar movimiento presupuestal"
    ''            Application.Current.Session("Modulo") = "./Movimiento_Presupuestal/Adecuaciones/Adecuaciones_Revisar.aspx"
    ''            objcontrol = New Mostrar_Asp

    ''        Case "Adecuaciones_Supervisar"
    ''            sModulo_Caption = "Supervisar movimiento presupuestal"
    ''            Application.Current.Session("Modulo") = "./Movimiento_Presupuestal/Adecuaciones/Adecuaciones_Supervisar.aspx"
    ''            objcontrol = New Mostrar_Asp

    ''        Case "Adecuacion_Validar"
    ''            sModulo_Caption = "Validar movimiento presupuestal"
    ''            Application.Current.Session("Modulo") = "./Movimiento_Presupuestal/Adecuaciones/Adecuaciones_Validar.aspx"
    ''            objcontrol = New Mostrar_Asp

    ''        Case "Adecuaciones_Registrar"
    ''            sModulo_Caption = "Registrar Movimiento"
    ''            objcontrol = New Adecuaciones_Finalizar_Movimiento

    ''        Case "Adecuaciones_Cambiar_Estatus"
    ''            sModulo_Caption = "Cambiar Estatus de Movimiento"
    ''            Application.Current.Session("Modulo") = "./Movimiento_Presupuestal/Adecuaciones/Adecuaciones_Cambiar_Estatus.aspx"
    ''            objcontrol = New Mostrar_Asp

    ''        Case "Adecuaciones_Eliminar"
    ''            sModulo_Caption = "Eliminar Movimiento"
    ''            Application.Current.Session("Modulo") = "./Movimiento_Presupuestal/Adecuaciones/Adecuaciones_Eliminar.aspx"
    ''            objcontrol = New Mostrar_Asp

    ''        Case "Adecuaciones_Eliminar_Detallado"
    ''            sModulo_Caption = "Eliminar Cuentas"
    ''            Application.Current.Session("Modulo") = "./Movimiento_Presupuestal/Adecuaciones/Adecuaciones_Eliminar_Detallado.aspx"
    ''            objcontrol = New Mostrar_Asp

    ''            'Case "Adecuaciones_Finalizar"
    ''            '    sModulo_Caption = "Finalizar"
    ''            '    Application.Current.Session("Modulo") = "./Movimiento_Presupuestal/Adecuaciones/Adecuaciones_Finalizar.aspx"
    ''            '    objcontrol = New Mostrar_Asp

    ''        Case "Adecuaciones_Exportar"
    ''            sModulo_Caption = "Exportar"
    ''            objcontrol = New Adecuaciones_Exportar

    ''        Case "Adecuaciones_Rechazadas"
    ''            sModulo_Caption = "Record de movimientos rechazados"
    ''            Application.Current.Session("Modulo") = "./Movimiento_Presupuestal/Adecuaciones_Rechazadas.aspx"
    ''            objcontrol = New Mostrar_Asp

    ''        Case "Adecuaciones_Presupuesto_Modificado"
    ''            sModulo_Caption = "Presupuesto Modificado"
    ''            Application.Current.Session("Modulo") = "./Movimiento_Presupuestal/Adecuaciones_Presupuesto_Modificado.aspx"
    ''            objcontrol = New Mostrar_Asp

    ''        Case "Adecuaciones_Imprimir"
    ''            sModulo_Caption = "Impresión de Movimientos Presupuestales (Ampliación / Reducción)"
    ''            objcontrol = New Adecuaciones_Imprimir

    ''        Case "Adecuaciones_Ver_Bitacora"
    ''            sModulo_Caption = "Bitacora de Movimientos"
    ''            objcontrol = New Adecuaciones_Ver_Bitacora

    ''            '*******************************
    ''            ''''AVANCES DE METAS
    ''            '*******************************
    ''            'Case "Avances_Metas_Captura"
    ''            '    sModulo_Caption = "Captura de Avance de Metas"
    ''            '    objcontrol = New Avances_Metas_Captura

    ''        Case "Avance_Metas_Proyecto_Grafico"
    ''            sModulo_Caption = "Avance de Metas / Graficos"
    ''            objcontrol = New Avances_Metas_Proyecto_Graficos

    ''        Case "Avances_Metas_Consulta"
    ''            sModulo_Caption = "Consulta de Metas (Capturadas)"
    ''            Application.Current.Session("Modulo") = "./Avances_Metas/Avances_Metas_Buscar.aspx"
    ''            objcontrol = New Mostrar_Asp

    ''        Case "Avances_Metas_Sin_Captura"
    ''            sModulo_Caption = "Proyectos sin captura de avance de Metas"
    ''            Application.Current.Session("Modulo") = "./Avances_Metas/Avances_Metas_Proyectos_Sin_Capturar_Avances.aspx"
    ''            objcontrol = New Mostrar_Asp

    ''        Case "Avances_Metas_Desbloquear_Cuentas"
    ''            sModulo_Caption = "Desbloquear cuenta / mes"
    ''            Application.Current.Session("Modulo") = "./Avances_Metas/Avances_Metas_Desbloquear_Cuentas.aspx"
    ''            objcontrol = New Mostrar_Asp
    ''            ''*********************************
    ''        Case "Avances_Metas_Pivot"
    ''            sModulo_Caption = "Semaforización"
    ''            Application.Current.Session("Modulo") = "./Avances_Metas/Avances_Metas_Pivot.aspx"
    ''            objcontrol = New Mostrar_Asp

    ''        Case "Avances_Metas_Proyectos"
    ''            sModulo_Caption = " Comparativo de metas"
    ''            Application.Current.Session("Modulo") = "./Avances_Metas/Avances_Metas_Proyectos.aspx"
    ''            objcontrol = New Mostrar_Asp
    ''            '*****************************************************************************
    ''            '     ELIMINADO
    ''            'Case "Avance_Metas_Graficos"
    ''            '    objcontrol = New Avances_Metas_Grafico_Parametros
    ''            '*********************************************************************
    ''            'Case "Avance_Metas_Proyecto_Grafico"
    ''            'objcontrol = New Avances_Metas_Imprimir
    ''            '***********************************************
    ''            '-INDICADORES
    ''            '***********************************************
    ''            ''Case "Avances_Metas_Indicadores"
    ''            ''    sModulo_Caption = "Captura de Indicadores"
    ''            ''    objcontrol = New Indicadores_Captura

    ''            ''Case "Avances_Metas_Indicadores_Graficos"
    ''            ''    sModulo_Caption = "Indicadores Graficos"
    ''            ''    objcontrol = New Indicadores_Graficos

    ''            '***********************************************
    ''            '-MENSAJES
    ''            '***********************************************
    ''        Case "Email_Enviar"
    ''            sModulo_Caption = "Envio de emails masivos"
    ''            objcontrol = New Email_Enviar

    ''        Case "Msg_Config"
    ''            sModulo_Caption = "Nuevo Mensaje"
    ''            objcontrol = New Msg_Config
    ''        Case "Msg_Enviados"
    ''            sModulo_Caption = "Mensajes Enviados"
    ''            Application.Current.Session("Modulo") = "./Mensajeria/Msg_Enviados.aspx"
    ''            objcontrol = New Mostrar_Asp

    ''            '*******************************
    ''            ''''CATALOGOS
    ''            '*******************************
    ''        Case "Catalogos"
    ''            sModulo_Caption = "Homologación Hologadas"
    ''            objcontrol = New Cat_Catalogos_Homologadas
    ''        Case "Cat_Procedencias"
    ''            sModulo_Caption = "Catalogo Procedencias"
    ''            objcontrol = New Cat_Procedencias
    ''        Case "Cat_Beneficiarios"
    ''            sModulo_Caption = "Catalogo Beneficiarios"
    ''            objcontrol = New Cat_Beneficiarios
    ''        Case "Cat_Capitulos"
    ''            sModulo_Caption = "Catalogo Capitulos"
    ''            objcontrol = New Cat_Capitulos
    ''        Case "Cat_Cuentas"
    ''            sModulo_Caption = "Catalogo Cuentas"
    ''            objcontrol = New Cat_Cuentas
    ''        Case "Cat_Fuente_Financiamiento"
    ''            sModulo_Caption = "Catalogo Fuente de Financiamiento"
    ''            objcontrol = New Cat_Fuente_Financiamiento
    ''        Case "Cat_Lineas_Accion_"
    ''            sModulo_Caption = "Catalogo Lineas de Acción"
    ''            objcontrol = New Cat_Lineas_Accion_
    ''        Case "Cat_Lineas_Accion_Objetivos"
    ''            sModulo_Caption = "Catalogo Lineas de Acción Objetivos"
    ''            objcontrol = New Cat_Lineas_Accion_Objetivos
    ''        Case "Cat_Localidades"
    ''            sModulo_Caption = "Catalogo Localidades"
    ''            objcontrol = New Cat_Localidades
    ''        Case "Cat_Programa"
    ''            sModulo_Caption = "Catalogo de Programas"
    ''            objcontrol = New Cat_Programa
    ''        Case "Cat_Unidades"
    ''            sModulo_Caption = "Catalogo Unidades"
    ''            objcontrol = New Cat_Unidades
    ''        Case "Cat_UnidadesMedida"
    ''            sModulo_Caption = "Catalogo Unidadades de Medidas"
    ''            objcontrol = New Cat_UnidadesMedida

    ''        Case "Cat_Catalogos_Indicadores"
    ''            sModulo_Caption = "Catalogo de Indicadores"
    ''            objcontrol = New Cat_Catalogos_Indicadores

    ''        Case "Cat_Catalogos_Programas_Indicadores"
    ''            sModulo_Caption = "Catalogo Indicadores y Subprogramas"
    ''            objcontrol = New Cat_Catalogos_Programas_Indicadores

    ''        Case "Catalogo_Imprimir"
    ''            Dim Frm_Imprimir As Cat_Imprimir
    ''            Frm_Imprimir = New Cat_Imprimir
    ''            Frm_Imprimir.ShowDialog()

    ''        Case "Cat_Funciones"
    ''            sModulo_Caption = "Catalogo Funciones"
    ''            objcontrol = New Cat_Funciones

    ''        Case "Cat_Subfuncion"
    ''            sModulo_Caption = "Catalogo Subfunciones"
    ''            objcontrol = New Cat_Subfuncion

    ''            '*******************************
    ''            ''''PANEL DE CONTROL
    ''            '*******************************
    ''        Case "Cat_Operadores"
    ''            sModulo_Caption = "Catalogo Operadores"
    ''            objcontrol = New Cat_Operadores
    ''        Case "Cat_Rol"
    ''            sModulo_Caption = "Catalogo Roles"
    ''            objcontrol = New Cat_Rol

    ''        Case "Cat_Accesos"
    ''            sModulo_Caption = "Catalogo Accesos"
    ''            objcontrol = New Cat_Accesos

    ''        Case "Resetear_Operadores"
    ''            sModulo_Caption = "Resetear Contraseña a Operadores"
    ''            objcontrol = New Cat_Resetear_Operadores

    ''        Case "Query"
    ''            sModulo_Caption = "Query"
    ''            objcontrol = New Query
    ''            '********************************           
    ''            '********************************

    ''        Case "Catalogo_Imprimir_Avances"
    ''            Dim Frm_Imprimir As Cedula_Imprimir_Individual
    ''            Frm_Imprimir = New Cedula_Imprimir_Individual
    ''            Frm_Imprimir.ShowDialog()

    ''            '*******************************
    ''            ''''GERENCIAL
    ''            '*******************************
    ''            'Case "Sumario_Recursos_Ejercidos"
    ''            '    sModulo_Caption = "Sumario / Recursos Ejercidos"
    ''            '    objcontrol = New Gerencial_Sumario

    ''            'Case "Sumario_Cedulas"
    ''            '    sModulo_Caption = "Sumario / Presupuesto"
    ''            '    objcontrol = New Cedulas_Sumario

    ''            '    ''Case "Importar_Recursos_Ejercicidos"
    ''            '    ''    sModulo_Caption = "Actualizar / Subir Base de Recursos Ejercidos"
    ''            '    ''    objcontrol = New Importar_Recursos_Ejercicidos
    ''            '    ''Case "Recursos_Ejercidos"
    ''            '    ''    objcontrol = New Recursos_Ejercidos
    ''            'Case "Gerencial_Posicion_Presupuestal"
    ''            '    sModulo_Caption = "Posición Presupuestal"
    ''            '    objcontrol = New Gerencial_Posicion_Presupuestal
    ''            'Case "Gerencial_Eficacia_Presupuestal"
    ''            '    sModulo_Caption = "Eficacia Presupuestal / Subejercicio "
    ''            '    objcontrol = New Gerencial_Eficacia_Presupuestal
    ''            'Case "Gerencial_Sumario_Ejercido_vs_Presupuesto"
    ''            '    sModulo_Caption = "Sumario / Ejercido - Programado"
    ''            '    objcontrol = New Gerencial_Sumario_Ejercido_vs_Presupuesto
    ''        Case "Gerencial_Alineacion"
    ''            sModulo_Caption = "Presupuesto"
    ''            Application.Current.Session("Modulo") = "./Gerencial/Gerencial_Pivot.aspx"
    ''            objcontrol = New Mostrar_Asp

    ''            'Case "Gerencial_Record"
    ''            '    sModulo_Caption = "Record"
    ''            '    objcontrol = New Gerencial_Record

    ''    End Select

    ''    If objcontrol Is Nothing = False Then
    ''        If cPanel.Controls.Count > 0 Then cPanel.Controls.Clear()
    ''        objcontrol.Dock = DockStyle.Fill
    ''        cPanel.Controls.Add(objcontrol)
    ''    Else
    ''        If cPanel.Controls.Count > 0 Then cPanel.Controls.Clear()
    ''    End If

    ''    cPanel.Text = sModulo_Caption
    ''    cPanel.Icon = cNodo.Image

    ''End Sub
    'Sub Devolver_No_Msg(ByVal bMensajes As Wisej.Web.ToolBarButton)
    '    Dim nNumero As Integer
    '    ReDim ParametersX_Global(1)
    '    ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Operador", Application.Current.Session("Cve_Operador"))
    '    ParametersX_Global(1) = New SqlClient.SqlParameter("@Estatus", "NO LEIDO")
    '    nNumero = fGuardar_O_EliminarXProcedure_DevuelveId("pMENSAJE_OPERADORES_CANTIDAD_MENSAJE", "@Parametro", ParametersX_Global, , SqlDbType.VarChar, 50)
    '    'LinkLabel1.Text = (("Ud.Tiene ") & (sNumero) & (" nuevos mensajes"))
    '    If nNumero > 0 Then

    '        'If nNumero = 1 Then
    '        'esles()

    '        'End If

    '        'bMensajes.ForeColor = Drawing.Color.Red

    '        bMensajes.Text = "(" & nNumero & ")" & IIf(nNumero = 1, " mensaje nuevo", " mensajes nuevos")
    '        bMensajes.ImageSource = "Images.email.png"
    '        'ElseIf Trim(sNumero) = "1" Then
    '        '    bMensajes.ForeColor = Drawing.Color.Red
    '        '    bMensajes.Text = (sNumero) & (" mensaje nuevo")
    '        '    bMensajes.Image = "Images.email.png"
    '    ElseIf nNumero = 0 Then
    '        'bMensajes.ForeColor = Drawing.Color.Black
    '        bMensajes.Text = ("0 Mensajes nuevos")
    '        bMensajes.ImageSource = "Images.email_open.png"
    '    End If
    'End Sub
    'Function sThemaActualDX() As String
    '    Dim sDevolverThemeName As String
    '    Dim sCurrentNameTheme As String = Application.Current.CurrentTheme
    '    Select Case sCurrentNameTheme
    '        Case "Default" '
    '            sDevolverThemeName = "Aqua"
    '        Case "Gmail"
    '            sDevolverThemeName = "Office2010Blue"
    '        Case "FaceBook"
    '            sDevolverThemeName = "Office2010Blue"
    '        Case "Analytics"
    '            sDevolverThemeName = "SoftOrange"
    '        Case "Office2010"
    '            sDevolverThemeName = "DevEx"
    '        Case "iOS"
    '            sDevolverThemeName = "iOS"
    '        Case Else
    '            sDevolverThemeName = "Office2010Blue"
    '    End Select

    '    Return sDevolverThemeName

    '    'If Application.Current.CurrentTheme = "Default" Then
    '    '    Return ""
    '    'End If
    'End Function
    'Public Function checkType(ByVal valor As Object, ByVal tipo As Type) As Boolean

    '    If valor.GetType.Name.ToLower = tipo.Name.ToLower Then
    '        Return True
    '    Else
    '        Return False
    '    End If

    'End Function
    'Public Function validDataWithFormat(ByRef data As String, tipo As Type) As Boolean

    '    If validData(data) = True Then
    '        Select Case tipo.Name.ToLower()
    '            Case "string"
    '                Return Len(data)
    '            Case "integer"
    '                Return True
    '            Case "datetime"
    '                'If IsDate(data) Then
    '                'If CDate(data) < DateDiff(DateInterval.Day, 
    '                Return IsDate(data)
    '                'End If

    '        End Select
    '    Else
    '        Return False
    '    End If
    'End Function
    'Public Function loadDataFromProcedure(ByVal proc As String, ByVal id As String, Optional ByVal pass As String = "") As DataTable
    '    Dim t As DataTable
    '    Dim r As DataRow

    '    Conectar()

    '    Dim cDataReader As Data.SqlClient.SqlDataReader
    '    Try
    '        cCommand = New SqlClient.SqlCommand(proc, cConnect)
    '        cCommand.CommandType = CommandType.StoredProcedure
    '        'ofunciones.cCommand.Parameters.AddWithValue("@PassphraseEnteredByUser", valor)
    '        If pass <> "" Then cCommand.Parameters.AddWithValue("@PassphraseEnteredByUser", pass)

    '        cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)

    '        t = New DataTable

    '        With t.Columns
    '            .Add(id)
    '        End With

    '        If cDataReader.HasRows Then
    '            While (cDataReader.Read)
    '                r = t.NewRow()
    '                r.Item(0) = cDataReader.Item(id)
    '                t.Rows.Add(r)
    '            End While
    '        End If

    '        Return t
    '    Catch ex As SystemException
    '        'MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        If IsNothing(cDataReader) = False Then
    '            If cDataReader.IsClosed = False Then cDataReader.Close()
    '        End If
    '        Desconectar()
    '    End Try

    'End Function
#End Region
#Region "Procig"
    Function Informacion_Proyecto_Ingreso(ByVal sCveFuenteFinanciamiento As String, ByVal nAnoEjercicio As Integer) As String()
        Dim sArrayDevuelve(2) As String
        Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            cCommand = New SqlClient.SqlCommand("pCEDULA_PRESUPUESTO_INGRESOS_B", cConnect)
            cCommand.CommandType = CommandType.StoredProcedure
            cCommand.Parameters.AddWithValue("@CVE_FUENTE_FINANCIAMIENTO", sCveFuenteFinanciamiento)
            cCommand.Parameters.AddWithValue("@EJERCICIO", nAnoEjercicio)
            cCommand.Parameters.AddWithValue("@PassphraseEnteredByUser", sConstante_KEY)
            cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While (cDataReader.Read)
                    sArrayDevuelve(0) = cDataReader.Item("CVE_PROYECTO")
                    sArrayDevuelve(1) = cDataReader.Item("CVE_PARTIDA")
                    sArrayDevuelve(2) = cDataReader.Item("ORIGEN")
                End While
            End If
        Catch ex As SystemException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()
        End Try

        Return sArrayDevuelve
    End Function
    Function Generar_poliza_Contable_Nomina(ByVal TIPO_PROYECTO As String, ByVal CVE_NOMINA As String, ByVal FOLIO_POLIZA As String, ByVal TIPO_MOMENTO As String, ByVal MOMENTO As String, ByVal T_GASTO As String, ByVal ANO As Integer, ORIGEN As String, ByVal CVE_PROYECTO As String, ByVal TIPO_CUENTA As String) As String()
        Dim sCveCuentas(), sTipoCuentas(), sTipos(), nMovimientos() As String
        Dim sCveCuenta, sTipoCuenta, sTipo, nMovimientosx As String
        Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            cCommand = New SqlClient.SqlCommand("pRH_NOMINAS_DETALLE_DED_PER_B", cConnect)
            cCommand.CommandType = CommandType.StoredProcedure
            cCommand.Parameters.AddWithValue("@CVE_NOMINA", CVE_NOMINA)
            cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While (cDataReader.Read)
                    sCveCuenta += cDataReader.Item("CVE_CUENTA") & ","
                    sTipoCuenta += cDataReader.Item("TIPO_CUENTA") & ","

                    sTipo += cDataReader.Item("TIPO") & ","
                    nMovimientosx += cDataReader.Item("NO_MOVIMIENTO") & ","
                End While
            End If
        Catch ex As SystemException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()
        End Try

        sCveCuentas = sCveCuenta.Split(",")
        sTipos = sTipo.Split(",")
        sTipoCuentas = sTipoCuenta.Split(",")
        nMovimientos = nMovimientosx.Split(",")

        For i As Integer = 0 To sCveCuentas.Length - 1
            If sCveCuentas(i) <> Nothing Then
                If sTipos(i).ToUpper = "DEDUCCION" Then
                    Generar_poliza_Contable(TIPO_PROYECTO, CVE_NOMINA, FOLIO_POLIZA, TIPO_MOMENTO, "DEVENGO_NOMINA_" & sTipos(i), MOMENTO, sCveCuentas(i), T_GASTO, sCveCuentas(i), ANO, ORIGEN, CVE_PROYECTO, TIPO_CUENTA, nMovimientos(i))
                Else
                    Generar_poliza_Contable(TIPO_PROYECTO, CVE_NOMINA, FOLIO_POLIZA, TIPO_MOMENTO, "DEVENGO_NOMINA_" & sTipos(i), MOMENTO, sCveCuentas(i).Substring(0, 3), T_GASTO, sCveCuentas(i), ANO, ORIGEN, CVE_PROYECTO, sTipoCuentas(i))
                End If

            End If
        Next

    End Function

    '''''''''''''''''''''''''''''''''''''''''
    ' ______                                '
    ' |  ____|                              '
    ' | |__   _ __ _ __ ___  _ __ ___  ___  '
    ' |  __| | '__| '__/ _ \| '__/ _ \/ __| '
    ' | |____| |  | | | (_) | | |  __/\__ \ '
    ' |______|_|  |_|  \___/|_|  \___||___/ '
    '                                       '
    '''''''''''''''''''''''''''''''''''''''''
    'Falta Polizas_Imprimir
    'Sub Mostrar_Poliza(ByVal sFolioPoliza As String, ByVal sTipoPoliza As String)
    '    If sFolioPoliza <> Nothing Then
    '        Dim PolizasMuestra As Polizas_Imprimir
    '        PolizasMuestra = New Polizas_Imprimir
    '        PolizasMuestra.sPoliza = sFolioPoliza
    '        PolizasMuestra.sTipoPoliza = sTipoPoliza
    '        PolizasMuestra.Show()
    '    End If
    'End Sub
    Function GuardarConciliacionBancaria(ByVal FOLIO_CONCILIACION As String, ByVal CUENTA_BANCARIA As String, ByVal TIPO_MOVIMIENTO As String, ByVal FECHA As String, ByVal MONTO_MOVIMIENTO As Double, ByVal TRANSFERENCIA As String, ByVal FOLIO_POLIZA As String, ByVal DESCRIPCION_MOVIMIENTO As String, ByVal ESTATUS_CAPTURA As String, ByVal CVE_TIPOBENEFICIARIO As String, ByVal CVE_BENEFICIARIO As String, ByVal ESTATUS As Boolean, sFOLIO_PROCEDENCIA As String, Optional nNO_CHEQUE_ASIGNADO As String = "", Optional sTIPO As String = "INGRESO") As String
        GuardarConciliacionBancaria = Nothing
        Try
            ReDim ParametersX_Global(15)
            If Trim(FOLIO_CONCILIACION) <> Nothing Then
                ParametersX_Global(0) = New SqlClient.SqlParameter("@FOLIO_CONCILIACION", FOLIO_CONCILIACION)
            End If
            ParametersX_Global(1) = New SqlClient.SqlParameter("@CUENTA_BANCARIA", CUENTA_BANCARIA)
            ParametersX_Global(2) = New SqlClient.SqlParameter("@TIPO_MOVIMIENTO", TIPO_MOVIMIENTO)
            ParametersX_Global(3) = New SqlClient.SqlParameter("@FECHA", FECHA)
            ParametersX_Global(4) = New SqlClient.SqlParameter("@MONTO_MOVIMIENTO", MONTO_MOVIMIENTO)
            ParametersX_Global(5) = New SqlClient.SqlParameter("@TRANSFERENCIA", TRANSFERENCIA)
            ParametersX_Global(6) = New SqlClient.SqlParameter("@FOLIO_POLIZA", FOLIO_POLIZA)
            ParametersX_Global(7) = New SqlClient.SqlParameter("@DESCRIPCION_MOVIMIENTO", DESCRIPCION_MOVIMIENTO)
            ParametersX_Global(8) = New SqlClient.SqlParameter("@ESTATUS_CAPTURA", ESTATUS_CAPTURA)
            ParametersX_Global(9) = New SqlClient.SqlParameter("@CVE_OPERADOR", Application.Current.Session("Cve_Operador"))
            ParametersX_Global(10) = New SqlClient.SqlParameter("@CVE_TIPO_BENEFICIARIO", CVE_TIPOBENEFICIARIO)
            ParametersX_Global(11) = New SqlClient.SqlParameter("@CVE_BENEFICIARIO", CVE_BENEFICIARIO)
            ParametersX_Global(12) = New SqlClient.SqlParameter("@ESTATUS", ESTATUS)
            'ParametersX_Global(13) = New SqlClient.SqlParameter("@FOLIO_PROCEDENCIA", sFOLIO_PROCEDENCIA)
            ParametersX_Global(14) = New SqlClient.SqlParameter("@NO_CHEQUE_ASIGNADO", nNO_CHEQUE_ASIGNADO)
            ParametersX_Global(15) = New SqlClient.SqlParameter("@TIPO", sTIPO)
            GuardarConciliacionBancaria = fGuardar_O_EliminarXProcedure_DevuelveId("pREGISTRO_CONCILIACION_BANCARIA_G", "@PARAMETRO", ParametersX_Global, False, SqlDbType.VarChar, 50)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Function
    Function Generar_Poliza(ByVal Folio_P As String, ByVal Origen As String, ByVal ano As Integer, ByVal Tipo_Poliza As String, ByVal Tipo_Concepto As String, ByVal Concepto() As String, ByVal ID_MOMENTO_CONTABLE As String, ByVal FOLIO_PROCEDENCIA_PADRE As String, ByVal CVE_FUENTE_FINANCIAMIENTO As String, Optional ByVal Motivo As String = "", Optional ByVal Folio_Cancelado As String = "NA", Optional dFecha_Alta As Date = Nothing, Optional ByVal Folio_Empleado As String = "", Optional ByVal Sreferencia As String = "", Optional ByVal ID_DEPENDENCIA As String = "DEP00") As String
        'SE MODIFICO EL DIA 27/1/13 POR EL CAMBIO DE LA BASE DE DATOS
        'SE AGREGO EL CAMPO DE FUENTE, EL CAMPO DE TIPO MOVIMIENTO Y EL DE PROCEDIMIENTO ALMACENADO 
        'CAMBIO HECHO POR RAFAEL 
        Dim sFecha_Valida As String
        Dim sPoliza As String = "0"
        Try
            Dim bproceso As Boolean
            ReDim ParametersX_Global(15)
            ParametersX_Global(0) = New SqlClient.SqlParameter("@FOLIO_PROCEDENCIA", Folio_P.Trim)
            ParametersX_Global(1) = New SqlClient.SqlParameter("@ANO", ano)
            ParametersX_Global(2) = New SqlClient.SqlParameter("@FOLIO_CANCELADO", Folio_Cancelado)
            ParametersX_Global(3) = New SqlClient.SqlParameter("@ORIGEN", Origen.Trim)
            ParametersX_Global(4) = New SqlClient.SqlParameter("@TIPO_POLIZA", Tipo_Poliza.Trim)
            ParametersX_Global(5) = New SqlClient.SqlParameter("@CVE_OPERADOR", Application.Current.Session("Cve_Operador"))
            ParametersX_Global(6) = New SqlClient.SqlParameter("@CONCEPTO", Concepto_Poliza(Tipo_Concepto, Concepto)) 'Concepto.Trim)
            ParametersX_Global(7) = New SqlClient.SqlParameter("@MOTIVO", Motivo.Trim)
            ParametersX_Global(8) = New SqlClient.SqlParameter("@ESTATUS_POLIZA", "PENDIENTE")
            ParametersX_Global(9) = New SqlClient.SqlParameter("@ID_MOMENTO_CONTABLE", ID_MOMENTO_CONTABLE)
            ParametersX_Global(10) = New SqlClient.SqlParameter("@FOLIO_PROCEDENCIA_PADRE", IIf(FOLIO_PROCEDENCIA_PADRE <> Nothing, FOLIO_PROCEDENCIA_PADRE, Folio_P.Trim))
            ParametersX_Global(11) = New SqlClient.SqlParameter("@CVE_FUENTE_FINANCIAMIENTO", CVE_FUENTE_FINANCIAMIENTO)
            ParametersX_Global(13) = New SqlClient.SqlParameter("@FOLIO_BENEFICIARIO", Folio_Empleado)
            ParametersX_Global(14) = New SqlClient.SqlParameter("@REFERENCIA", Sreferencia)
            If ID_DEPENDENCIA <> Nothing AndAlso ID_DEPENDENCIA <> "DEP00" Then
                ParametersX_Global(15) = New SqlClient.SqlParameter("@ID_DEPENDENCIA", ID_DEPENDENCIA)

            End If
            'Else
            '    ParametersX_Global(15) = New SqlClient.SqlParameter("@ID_DEPENDENCIA", "DEP00")
            'End If

            sFecha_Valida = dFecha_Alta.ToString("yyyyMMdd")
            If sFecha_Valida <> "00010101" Then
                ParametersX_Global(12) = New SqlClient.SqlParameter("@FECHA_ALTA", dFecha_Alta) 'anexe fecha opcional
            End If

            sPoliza = fGuardar_O_EliminarXProcedure_DevuelveId("pPOLIZA_APROBADO_G", "@PARAMETRO", ParametersX_Global, True, SqlDbType.VarChar, 50)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return sPoliza
    End Function
    Function Generar_poliza_Contable(ByVal TIPO_PROYECTO As String, ByVal FOLIO_PROCEDENCIA As String, ByVal Folio_Poliza As String, ByVal TIPO_MOMENTO As String, ByVal MOVIMIENTO As String, ByVal MOMENTO As String, ByVal CVE_CUENTA_GENERICA As String, ByVal T_gasto As String, ByVal CVE_CUENTA As String, ByVal ANO As Integer, ByVal ORIGEN As String, ByVal CVE_PROYECTO As String, ByVal TIPO_CUENTA As String, Optional ByVal nCve_Retencion As Integer = 0, Optional ByVal nMes_Calendario As Integer = 0, Optional ByVal nImporte As Double = 0, Optional ByVal sCve_Empleado As String = Nothing, Optional ByVal sCve_Beneficiario As String = Nothing) As String
        'SE MODIFICO EL DIA 28/1/14 POR EL CAMBIO DE LA BASE DE DATOS
        'CAMBIO HECHO POR RAFAEL 
        Dim sPoliza As String = "0"
        Try
            Dim bproceso As Boolean
            ReDim ParametersX_Global(17)
            ParametersX_Global(0) = New SqlClient.SqlParameter("@FOLIO_PROCEDENCIA", FOLIO_PROCEDENCIA.Trim)
            ParametersX_Global(1) = New SqlClient.SqlParameter("@FOLIO_POLIZA", Folio_Poliza)
            ParametersX_Global(2) = New SqlClient.SqlParameter("@MOVIMIENTO", MOVIMIENTO)
            ParametersX_Global(3) = New SqlClient.SqlParameter("@TIPO_MOMENTO", TIPO_MOMENTO)
            ParametersX_Global(4) = New SqlClient.SqlParameter("@MOMENTO", MOMENTO)
            ParametersX_Global(5) = New SqlClient.SqlParameter("@CVE_CUENTA_GENERICA", CVE_CUENTA_GENERICA)
            ParametersX_Global(6) = New SqlClient.SqlParameter("@Tipo_Gasto", T_gasto)
            ParametersX_Global(7) = New SqlClient.SqlParameter("@CVE_CUENTA", CVE_CUENTA)
            ParametersX_Global(8) = New SqlClient.SqlParameter("@ANO", ANO)
            ParametersX_Global(9) = New SqlClient.SqlParameter("@ORIGEN", ORIGEN)
            ParametersX_Global(10) = New SqlClient.SqlParameter("@PassphraseEnteredByUser", sConstante_KEY)
            ParametersX_Global(11) = New SqlClient.SqlParameter("@CVE_PROYECTO", CVE_PROYECTO)
            ParametersX_Global(12) = New SqlClient.SqlParameter("@TIPO_CUENTA", TIPO_CUENTA)
            ParametersX_Global(13) = New SqlClient.SqlParameter("@TIPO_PROYECTO", TIPO_PROYECTO)
            ParametersX_Global(14) = New SqlClient.SqlParameter("@CVE_IMPUESTO", nCve_Retencion)
            ParametersX_Global(15) = New SqlClient.SqlParameter("@MES_CALENDARIO", nMes_Calendario)
            ParametersX_Global(16) = New SqlClient.SqlParameter("@IMPORTE_CONTABLE", nImporte) 'Anexado el 21/05/2014 Erik
            ParametersX_Global(17) = New SqlClient.SqlParameter("@CVE_EMPLEADO", sCve_Empleado) 'Anexado el 29/05/2014 Aymer  para el devengo contable de los gastos y viaticos de camino
            ParametersX_Global(17) = New SqlClient.SqlParameter("@CVE_BENEFICIARIO", sCve_Beneficiario) 'Anexado el 29/05/2014 Aymer  para el devengo contable de los gastos y viaticos de camino
            sPoliza = fGuardar_O_EliminarXProcedure_DevuelveId("pPOLIZA_APROBADO_MOVIMIENTOS_C_G", "@PARAMETRO", ParametersX_Global, False, SqlDbType.VarChar, 50)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return sPoliza
    End Function
    Function Generar_poliza_Contable_pena(ByVal FOLIO_PROCEDENCIA As String, ByVal Folio_Poliza As String, ByVal TIPO_MOMENTO As String, ByVal MOVIMIENTO As String, ByVal MOMENTO As String, ByVal CVE_CUENTA_GENERICA As String, ByVal T_gasto As String, ByVal CVE_CUENTA As String, ByVal ANO As Integer, ByVal ORIGEN As String, ByVal CVE_PROYECTO As String, ByVal CARGO_PENA As String, ByVal TIPO_CUENTA As String) As String
        'SE CREÓ EL DIA 05/03/14 PARA REGISTRAR LOS MOVIMIENTOS CONTABLES POR PENA CONVENCIONAL
        'CAMBIO HECHO POR FRANCISCO NARVAEZ
        Dim sPoliza As String = "0"
        Try
            Dim bproceso As Boolean
            ReDim ParametersX_Global(13)
            ParametersX_Global(0) = New SqlClient.SqlParameter("@FOLIO_PROCEDENCIA", FOLIO_PROCEDENCIA.Trim)
            ParametersX_Global(1) = New SqlClient.SqlParameter("@FOLIO_POLIZA", Folio_Poliza)
            ParametersX_Global(2) = New SqlClient.SqlParameter("@MOVIMIENTO", MOVIMIENTO)
            ParametersX_Global(3) = New SqlClient.SqlParameter("@TIPO_MOMENTO", TIPO_MOMENTO)
            ParametersX_Global(4) = New SqlClient.SqlParameter("@MOMENTO", MOMENTO)
            ParametersX_Global(5) = New SqlClient.SqlParameter("@CVE_CUENTA_GENERICA", CVE_CUENTA_GENERICA)
            ParametersX_Global(6) = New SqlClient.SqlParameter("@Tipo_Gasto", T_gasto)
            ParametersX_Global(7) = New SqlClient.SqlParameter("@CVE_CUENTA", CVE_CUENTA)
            ParametersX_Global(8) = New SqlClient.SqlParameter("@ANO", ANO)
            ParametersX_Global(9) = New SqlClient.SqlParameter("@ORIGEN", ORIGEN)
            ParametersX_Global(10) = New SqlClient.SqlParameter("@PassphraseEnteredByUser", sConstante_KEY)
            ParametersX_Global(11) = New SqlClient.SqlParameter("@CVE_PROYECTO", CVE_PROYECTO)
            ParametersX_Global(12) = New SqlClient.SqlParameter("@ABONO_PENA", CARGO_PENA)
            ParametersX_Global(13) = New SqlClient.SqlParameter("@TIPO_CUENTA", TIPO_CUENTA)
            sPoliza = fGuardar_O_EliminarXProcedure_DevuelveId("pPOLIZA_APROBADO_MOVIMIENTOS_C_G", "@PARAMETRO", ParametersX_Global, False, SqlDbType.VarChar, 50)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return sPoliza
    End Function
    Sub InfoAlmacen(ByVal sCve_Cuenta_SubString As String, LBFolioAlmacen As Label, LBAlmacen As Label)
        Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            cCommand = New SqlClient.SqlCommand("pCAT_ALMACEN_ROLES_OPERADORES_B", cConnect)
            cCommand.CommandType = CommandType.StoredProcedure
            If sCve_Cuenta_SubString <> Nothing Then
                sCve_Cuenta_SubString = sCve_Cuenta_SubString + "00"
                cCommand.Parameters.AddWithValue("@CVE_CONCEPTO", sCve_Cuenta_SubString)
                cCommand.Parameters.AddWithValue("@CVE_OPERADOR", Application.Current.Session("Cve_Operador"))
            End If
            cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While cDataReader.Read
                    LBFolioAlmacen.Text = cDataReader.Item("FOLIO_ALMACEN").ToString()
                    LBAlmacen.Text = cDataReader.Item("DESCRIPCION").ToString()
                End While
            End If
        Catch ex As SystemException
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()
        End Try
    End Sub
    ''creo Aymer 15/03/2016 

    ''' <summary>
    ''' Funcion para obtener algunas configuraciones del sistema :-)
    ''' </summary>
    ''' <param name="sModulo">obtiene resultado segun el valor del parametro esperado</param>
    ''' <returns>Regresa un Dato tipo Object </returns>

    Sub Configurar_Grid_Captura_Cuentas(ByVal oDataGrid As Wisej.Web.DataGridView, ByVal oBindingSource As Wisej.Web.BindingSource)
        oBindingSource.DataSource = Nothing
        oDataGrid.DataSource = Nothing
        Dim i As Integer
        Dim sMes As String
        Dim dt As New DataTable("PRESUPUESTO")

        dt.Columns.Add("CVE_CUENTA")
        dt.Columns.Add("CUENTA")

        For i = 1 To 12
            sMes = i
            dt.Columns.Add(sMes, GetType(Double))
        Next
        dt.Columns.Add("TOTAL") ', GetType(Double))
        dt.Columns.Add("TIPO")
        dt.Columns.Add("ESTATUS")
        dt.Columns.Add("RUBRO")
        dt.Columns.Add("CVE_PARTIDA_SEGURO_POPULAR")
        dt.Columns.Add("CVE_PARTIDA_ESTATAL")
        '**************************************
        '  oDataBindinSource.DataSource = dt
        oDataGrid.DataSource = dt
        oBindingSource.DataSource = oDataGrid.DataSource
        oBindingSource.DataMember = oDataGrid.DataMember


        For i = 1 To 12
            'DataGridViewTextBoxColumn3.DefaultCellStyle.Format = "d"
            'DataGrid_Cuenta_Captura.Columns(i.ToString).DefaultCellStyle.FormatProvider = New Globalization.CultureInfo("es-MX")
            oDataGrid.Columns(i.ToString).DefaultCellStyle.Format = "c"
            '
            'DataGrid_Cuenta_Captura.Columns(i.ToString).d
            'DataGrid_Cuenta_Captura.Columns(i.ToString).DefaultCellStyle.FormatProvider
            'DataGrid_Cuenta_Captura.Columns(i.ToString).DefaultCellStyle.FormatProvider.GetFormat.  
            'DataGrid_Cuenta_Captura.Columns(i.ToString).ValueType = GetType(System.Double)
            oDataGrid.Columns(i.ToString).HeaderText = Format(CDate("01/" & i & "/" & Now.Year), "MMM")
            'DataGrid_Cuenta_Captura.Columns(i.ToString).CellType
        Next
        oDataGrid.Columns("CVE_CUENTA").ReadOnly = True
        oDataGrid.Columns("CUENTA").ReadOnly = True
        oDataGrid.Columns("RUBRO").ReadOnly = True
        oDataGrid.Columns("CVE_PARTIDA_SEGURO_POPULAR").ReadOnly = True
        oDataGrid.Columns("CVE_PARTIDA_ESTATAL").ReadOnly = True

        oDataGrid.Columns("TOTAL").ReadOnly = True
        oDataGrid.Columns("TOTAL").DefaultCellStyle.Format = "c"

        oDataGrid.Columns("TIPO").ReadOnly = True
        oDataGrid.Columns("TIPO").Visible = False
        oDataGrid.Columns("ESTATUS").ReadOnly = True
        oDataGrid.Columns("ESTATUS").Visible = False
        ' oDataGrid.CurrentPage = 1

        oDataGrid.Columns("CVE_CUENTA").Frozen = True
        oDataGrid.Columns("CVE_CUENTA").HeaderText = "CLAVE"
        oDataGrid.Columns("CUENTA").Frozen = True
    End Sub

    '''''''''''''''''''''''''''''''''''''''''
    ' ______                                '
    ' |  ____|                              '
    ' | |__   _ __ _ __ ___  _ __ ___  ___  '
    ' |  __| | '__| '__/ _ \| '__/ _ \/ __| '
    ' | |____| |  | | | (_) | | |  __/\__ \ '
    ' |______|_|  |_|  \___/|_|  \___||___/ '
    '                                       '
    '''''''''''''''''''''''''''''''''''''''''
    'Falta Mbox
    'Public Sub Notificacion_usuario(NombreUrl As String, Mensaje As String, Modulo As String, Optional Tipo As String = "NORMAL")
    '    Dim f As Mbox = New Mbox()

    '    f.EnviarMensajaSiguenteProceso(NombreUrl, Mensaje, Modulo, Tipo)


    '    f.Show()
    '    f.Close()
    'End Sub


    'Public Sub LimpiarNotificacionesCompletadas(Folio As String, Modulo As String)
    '    Dim f As Mbox = New Mbox()

    '    f.LimpiarNotificacionesCompletadas(Folio, Modulo)


    '    f.Show()
    '    f.Close()
    'End Sub


    Function Obtener_Informacion_Pedido(ByVal sFolioPedido As String) As String()
        Dim aDevuelve(5) As String
        Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader

        Try
            cCommand = New SqlClient.SqlCommand("pOBTENER_INFORMACION_PEDIDO", cConnect)
            cCommand.CommandType = CommandType.StoredProcedure
            cCommand.Parameters.AddWithValue("@FOLIO_PEDIDO", sFolioPedido)
            cCommand.Parameters.AddWithValue("@PassphraseEnteredByUser", sConstante_KEY)
            cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While (cDataReader.Read)
                    aDevuelve(0) = cDataReader.Item("CVE_PROYECTO")
                    aDevuelve(1) = cDataReader.Item("ANO_EJERCICIO")
                    aDevuelve(2) = cDataReader.Item("ORIGEN_PROYECTO")
                    aDevuelve(3) = cDataReader.Item("CVE_CUENTA")
                    aDevuelve(4) = cDataReader.Item("TIPO_CUENTA")
                    aDevuelve(5) = cDataReader.Item("CVE_FUENTE_FINANCIAMIENTO")
                End While
            End If
        Catch ex As SystemException
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()
        End Try
        Return aDevuelve
    End Function
    Function Concepto_Poliza(ByVal sTipoConcepto As String, ByVal sCadenas() As String) As String
        Conectar()
        Dim sComodin As String = "$"
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            cCommand = New SqlClient.SqlCommand("pCAT_POLIZA_CONCEPTOS_B", cConnect)
            cCommand.CommandType = CommandType.StoredProcedure
            cCommand.Parameters.AddWithValue("@TIPO_CONCEPTO", sTipoConcepto)
            cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While (cDataReader.Read)
                    Concepto_Poliza = cDataReader.Item("CONCEPTO")
                End While
            End If
        Catch ex As SystemException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()
        End Try
        For i As Integer = 0 To sCadenas.Length - 1
            Concepto_Poliza = Replace(Concepto_Poliza, sComodin & i.ToString, sCadenas(i))
        Next
        Concepto_Poliza = IIf(Concepto_Poliza <> Nothing, Concepto_Poliza, "")
    End Function
    Public Function fDevuelve_Id_Dependencia_Segun_Fuente_Financiamieto(ByVal sCve_Fuente_Financiamiento As String) As String
        If sCve_Fuente_Financiamiento <> Nothing Then
            ReDim ParametersX_Global(0)
            ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_FUENTE_FINANCIAMIENTO", sCve_Fuente_Financiamiento)
            sCve_Fuente_Financiamiento = fGuardar_O_EliminarXProcedure_DevuelveId("pDEPENDENCIA_FUENTES_B", "@PARAMETRO", ParametersX_Global, True, SqlDbType.VarChar, 50)
            Return sCve_Fuente_Financiamiento
        End If

    End Function
    ''' <summary>
    ''' Esta funcion se utiliza para poder guardar los proyectos de los diferentes  movimientos en el almacen. 
    ''' </summary>
    ''' <param name="sCve_Proyecto">Clave del proyecto</param>
    ''' <param name="sOrigen">Origen del proyecto</param>
    ''' <param name="nAno_Ejercicio">año de ejercicio del Proyecto </param>
    ''' <param name="sFolio_Movimiento">Folio del Movimiento puede ser el folio de la Entrada, Salida, Cancelacion Entrada y Cancelacion Salida</param>
    ''' <returns>retorna un valor booleano </returns>
    ''' <remarks></remarks>
    ''' 
    Function fGuardar_proyectos_Almacen(ByVal sCve_Proyecto As String, ByVal sOrigen As String, ByVal nAno_Ejercicio As Integer, ByVal sFolio_Movimiento As String, ByVal sCve_Fuente As String) As Boolean
        ReDim ParametersX_Global(5)
        ParametersX_Global(0) = New SqlClient.SqlParameter("@CVE_PROYECTO", sCve_Proyecto)
        ParametersX_Global(1) = New SqlClient.SqlParameter("@ORIGEN_PROYECTO", sOrigen)
        ParametersX_Global(2) = New SqlClient.SqlParameter("@ANO_EJERCICIO", nAno_Ejercicio)
        ParametersX_Global(3) = New SqlClient.SqlParameter("@PassphraseEnteredByUser", sConstante_KEY)
        ParametersX_Global(4) = New SqlClient.SqlParameter("@FOLIO_MOVIMIENTO", sFolio_Movimiento)
        ParametersX_Global(5) = New SqlClient.SqlParameter("@CVE_FUENTE", sCve_Fuente)
        Return fGuardar_O_EliminarXProcedure("pALMACEN_MOVIMIENTOS_PROYECTOS_G", "@PARAMETRO", ParametersX_Global, True)
    End Function
    Function Generar_poliza_Presupuestal(ByVal TIPO_PROYECTO As String, ByVal FOLIO_PROCEDENCIA As String, ByVal Folio_Poliza As String, ByVal TIPO_MOMENTO As String, ByVal MOVIMIENTO As String, ByVal MOMENTO As String, ByVal CVE_CUENTA As String, ByVal ANO As Integer, ByVal ORIGEN As String, ByVal CVE_PROYECTO As String, ByVal TIPO_CUENTA As String, Optional ByVal sFolio_Movimiento As String = "", Optional ByVal CVE_FUENTE As String = "0", Optional ByVal TIPO_MOVIMIENTO_ADECUACION As String = "", Optional ByVal fechaMovimiento As Date = Nothing, Optional ByVal Icargo As Double = Nothing, Optional ByVal ImporteAmpliacion As Double = 0, Optional ByVal ImporteReduccion As Double = 0, Optional ByVal sProcedureName As String = Nothing) As String
        'SE MODIFICO EL DIA 28/1/14 POR EL CAMBIO DE LA BASE DE DATOS
        'CAMBIO HECHO POR RAFAEL 
        If fechaMovimiento = Nothing Then
            fechaMovimiento = Now.Date
        End If
        Dim sPoliza As String = "0"
        Try
            Dim bproceso As Boolean
            ReDim ParametersX_Global(17)
            ParametersX_Global(0) = New SqlClient.SqlParameter("@FOLIO_PROCEDENCIA", FOLIO_PROCEDENCIA.Trim)
            ParametersX_Global(1) = New SqlClient.SqlParameter("@FOLIO_POLIZA", Folio_Poliza)
            ParametersX_Global(2) = New SqlClient.SqlParameter("@MOVIMIENTO", MOVIMIENTO)
            ParametersX_Global(3) = New SqlClient.SqlParameter("@TIPO_MOMENTO", TIPO_MOMENTO)
            ParametersX_Global(4) = New SqlClient.SqlParameter("@MOMENTO", MOMENTO)
            ParametersX_Global(5) = New SqlClient.SqlParameter("@CVE_CUENTA", CVE_CUENTA)
            ParametersX_Global(6) = New SqlClient.SqlParameter("@ANO", ANO)
            ParametersX_Global(7) = New SqlClient.SqlParameter("@CVE_FUENTE", CVE_FUENTE)
            ParametersX_Global(8) = New SqlClient.SqlParameter("@ORIGEN", ORIGEN)
            ParametersX_Global(9) = New SqlClient.SqlParameter("@PassphraseEnteredByUser", sConstante_KEY)
            ParametersX_Global(10) = New SqlClient.SqlParameter("@CVE_PROYECTO", CVE_PROYECTO)
            ParametersX_Global(11) = New SqlClient.SqlParameter("@FOLIO_MOVIMIENTO", sFolio_Movimiento)
            ParametersX_Global(12) = New SqlClient.SqlParameter("@TIPO_CUENTA", TIPO_CUENTA)
            ParametersX_Global(13) = New SqlClient.SqlParameter("@TIPO_MOVIMIENTO", TIPO_MOVIMIENTO_ADECUACION)
            ParametersX_Global(14) = New SqlClient.SqlParameter("@TIPO_PROYECTO", TIPO_PROYECTO)
            ParametersX_Global(15) = New SqlClient.SqlParameter("@CARGO_INGRESO", Icargo)
            ParametersX_Global(16) = New SqlClient.SqlParameter("@AMPLIACION", ImporteAmpliacion)
            ParametersX_Global(17) = New SqlClient.SqlParameter("@REDUCCION", ImporteReduccion)

            sPoliza = fGuardar_O_EliminarXProcedure_DevuelveId(IIf(sProcedureName <> Nothing, sProcedureName, "pPOLIZA_APROBADO_MOVIMIENTOS_P_G"), "@PARAMETRO", ParametersX_Global, True, SqlDbType.VarChar, 50)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        End Try
        Return sPoliza
    End Function
    Function Generar_poliza_Reintegros(ByVal TIPO_PROYECTO As String, ByVal FOLIO_PROCEDENCIA As String, ByVal Folio_Poliza As String, CVE_PROYECTO As String, ORIGEN As String, ANO As Integer, CVE_FUENTE As String, ByVal TIPO_MOMENTO As String, ByVal MOVIMIENTO As String, ByVal MOMENTO As String, ByVal CVE_CUENTA As String, ByVal TIPO_CUENTA As String, ByVal CUENTA_BANCARIA As String, ByVal IMPORTE_MOVIMIENTO As String) As String
        Dim sPoliza As String = "0"
        Try
            Dim bproceso As Boolean

            ReDim ParametersX_Global(14)
            ParametersX_Global(0) = New SqlClient.SqlParameter("@TIPO_PROYECTO", TIPO_PROYECTO)
            ParametersX_Global(1) = New SqlClient.SqlParameter("@FOLIO_PROCEDENCIA", FOLIO_PROCEDENCIA.Trim)
            ParametersX_Global(2) = New SqlClient.SqlParameter("@FOLIO_POLIZA", Folio_Poliza)
            ParametersX_Global(3) = New SqlClient.SqlParameter("@PassphraseEnteredByUser", sConstante_KEY)
            ParametersX_Global(4) = New SqlClient.SqlParameter("@CVE_PROYECTO", CVE_PROYECTO)
            ParametersX_Global(5) = New SqlClient.SqlParameter("@ORIGEN", ORIGEN)
            ParametersX_Global(6) = New SqlClient.SqlParameter("@ANO", ANO)
            ParametersX_Global(7) = New SqlClient.SqlParameter("@CVE_FUENTE", CVE_FUENTE)
            ParametersX_Global(8) = New SqlClient.SqlParameter("@TIPO_MOMENTO", TIPO_MOMENTO)
            ParametersX_Global(9) = New SqlClient.SqlParameter("@MOVIMIENTO", MOVIMIENTO)
            ParametersX_Global(10) = New SqlClient.SqlParameter("@MOMENTO", MOMENTO)
            ParametersX_Global(11) = New SqlClient.SqlParameter("@CVE_CUENTA", CVE_CUENTA)
            ParametersX_Global(12) = New SqlClient.SqlParameter("@TIPO_CUENTA", TIPO_CUENTA)
            ParametersX_Global(13) = New SqlClient.SqlParameter("@CUENTA_BANCARIA", CUENTA_BANCARIA)
            ParametersX_Global(14) = New SqlClient.SqlParameter("@IMPORTE_MOVIMIENTO", IMPORTE_MOVIMIENTO)
            sPoliza = fGuardar_O_EliminarXProcedure_DevuelveId("pPOLIZA_APROBADO_MOVIMIENTOS_REINTEGROS_G", "@PARAMETRO", ParametersX_Global, False, SqlDbType.VarChar, 50)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return sPoliza
    End Function
    Function ArrayEliminarRepetidosOrdenados(ByVal sArray() As String, Optional ByVal bConcervaVacios As Boolean = False) As String()
        Dim sArrayDevuelve(0) As String
        Dim nConsecutivo As Integer = 0
        For nContador As Integer = 0 To sArray.Length - 1 Step 1
            If bConcervaVacios Then
                If nConsecutivo = 0 Then
                    sArrayDevuelve(0) = Trim(sArray(nContador))
                    nConsecutivo = 1
                ElseIf sArray(nContador) <> sArray(nContador - 1) Then
                    ReDim Preserve sArrayDevuelve(nConsecutivo)
                    sArrayDevuelve(nConsecutivo) = Trim(sArray(nContador))
                    nConsecutivo = nConsecutivo + 1
                End If
            Else
                If sArray(nContador) <> Nothing Then
                    If nConsecutivo = 0 Then
                        sArrayDevuelve(0) = Trim(sArray(nContador))
                        nConsecutivo = 1
                    ElseIf sArray(nContador) <> sArray(nContador - 1) Then
                        ReDim Preserve sArrayDevuelve(nConsecutivo)
                        sArrayDevuelve(nConsecutivo) = Trim(sArray(nContador))
                        nConsecutivo = nConsecutivo + 1
                    End If
                End If
            End If
        Next
        Return sArrayDevuelve
    End Function

    Function ArrayObtenerIndice(ByVal sDescripcion As String, ByVal sDescripciones() As String) As Integer
        For nContador As Integer = 0 To sDescripciones.Length - 1
            If sDescripcion = sDescripciones(nContador) Then
                ArrayObtenerIndice = nContador
                Exit Function
            End If
        Next
    End Function
    Function Obtener_clasificador(ByVal Cve_COG As String)
        Dim clasificacion As String
        Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader

        Try
            cCommand = New SqlClient.SqlCommand("PCAT_OBTENER_CLASIFICADOR_GASTOS", cConnect)
            cCommand.CommandType = CommandType.StoredProcedure
            cCommand.Parameters.AddWithValue("@CVE_COG", Cve_COG)
            'ofunciones.cCommand.Parameters.AddWithValue("@CVE_PROYECTO", cve_proyecto)
            cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While (cDataReader.Read)
                    clasificacion = cDataReader.Item("CVE_COG")
                End While
            End If
        Catch ex As SystemException
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()
        End Try


        Return clasificacion
    End Function
    Function Obtener_Momento_Contable(ByVal sMomento As String) As Integer
        Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Dim nMomentoContable As Integer = 0
        Try
            cCommand = New SqlClient.SqlCommand("pCAT_MOMENTOS_CONTABLES_B", cConnect)
            cCommand.CommandType = CommandType.StoredProcedure
            cCommand.Parameters.AddWithValue("@MOMENTO_CONTABLE", sMomento)
            cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While (cDataReader.Read)
                    nMomentoContable = cDataReader.Item("ID_MOMENTO_CONTABLE")
                End While
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()
        End Try
        Return nMomentoContable
    End Function
    'Suub Subtotal_Suma_Inversion_Partidas_x_fIELD(ByVal Grid As Wisej.Web.DataGridView)
    '    Dim nRow As Integer
    '    Dim nTotal, nSubtotal As Double
    '    Dim sNameCol As String

    '    If Grid.RowCount = 0 Then Exit Sub

    '    Grid.CurrentRow.Selected = True

    '    For nRow = 0 To Grid.RowCount - 1
    '        nTotal = 0
    '        For nCol = 0 To 11
    '            nSubtotal = 0
    '            'If Grid.Columns(nCol).Name.ToUpper = UCase("c" & Format(CDate("01/" & nCol & "/" & Now.Year), "MMMM")) Then
    '            sNameCol = "c" & sArraysMeses(nCol) ' Grid.Columns(nCol).Name

    '            If Grid.Columns.Contains(sNameCol) Then
    '                'sTotal = sTotal + Convert.ToDouble(Grid.Item(sNameCol, nRow).Value)
    '                'If Grid.Rows.Item(nRow).   
    '                'sTotal = sTotal + Val(0 & Grid.Item(sNameCol, nRow).Value)
    '                '13/03/2017 sumaba las columnas "no visibles" Oscar
    '                If Grid.Columns(sNameCol).Visible = True Then
    '                    nSubtotal = Grid.Item(Grid.Columns(sNameCol).Index, nRow).Value
    '                    nTotal = nTotal + nSubtotal
    '                Else
    '                    Grid.Item(Grid.Columns(sNameCol).Index, nRow).Value = 0
    '                End If
    '            End If
    '            'End If
    '        Next nCol
    '        Grid.Item("TOTAL", nRow).Value = nTotal
    '    Next nRow
    'End Sub
    Function Total_Inversion_Partidas(ByVal Grid As Wisej.Web.DataGridView) As Double
        Dim tot As Double = 0
        Dim i As Integer = 0
        For i = 0 To Grid.Rows.Count - 1
            If Trim("" & Grid.Item("TOTAL", i).Value) <> Nothing Then
                tot = tot + Convert.ToDouble(Grid.Item("TOTAL", i).Value)
            End If
        Next i
        Return tot
    End Function
    'Suub Subtotal_Suma_Inversion_Partidas_x_fIELD(ByVal Grid As Wisej.Web.DataGridView, ByVal nRow As Integer, Optional ByVal sColumname As String = "TOTAL")
    '    ' Dim nRow As Integer
    '    Dim sTotal As Double = 0
    '    Dim sNameCol As String
    '    Dim nInicia_Row As Integer
    '    Dim nTotal_Row As Integer
    '    If nRow = -1 Then
    '        nTotal_Row = Grid.RowCount - 1
    '        nInicia_Row = 0
    '    Else
    '        nTotal_Row = nRow
    '        nInicia_Row = nRow
    '    End If
    '    For nRow = nInicia_Row To nTotal_Row
    '        sTotal = 0
    '        For nCol = 1 To 12
    '            sNameCol = "c" & Format(CDate("01/" & nCol & "/" & Now.Year), "MMMM")
    '            sTotal = sTotal + Convert.ToDouble(Grid.Item(sNameCol, nRow).Value)
    '        Next nCol
    '        Grid.Item(sColumname, nRow).Value = sTotal

    '        If Grid.Columns.Contains("TIPO_MOVIMIENTO") Then
    '            If Grid.Item("TIPO_MOVIMIENTO", nRow).Value = "AMPLIACION" Then
    '                Grid.Item("AMPLIACION", nRow).Value = sTotal
    '            ElseIf Grid.Item("TIPO_MOVIMIENTO", nRow).Value = "REDUCCION" Then
    '                Grid.Item("REDUCCION", nRow).Value = sTotal
    '            End If
    '        End If
    '        'Grid.Item(sColumname, nRow).Value = sTotal
    '        'DDD
    '    Next nRow
    'End Sub
    Sub Subtotal_Suma_Inversion_Partidas_x_fIELD_TEMP(ByVal Grid As Wisej.Web.DataGridView, ByVal nRow As Integer, Optional ByVal sColumname As String = "TOTAL")
        ' Dim nRow As Integer
        Dim sTotal As Double = 0
        Dim sNameCol As String
        Dim nInicia_Row As Integer
        Dim nTotal_Row As Integer
        If nRow = -1 Then
            nTotal_Row = Grid.RowCount - 1
            nInicia_Row = 0
        Else
            nTotal_Row = nRow
            nInicia_Row = nRow
        End If
        For nRow = nInicia_Row To nTotal_Row
            sTotal = 0
            For nCol = 1 To 12
                sNameCol = "c" & Format(CDate("01/" & nCol & "/" & Now.Year), "MMMM")
                sTotal = sTotal + Convert.ToDouble(Grid.Item(sNameCol, nRow).Value)
            Next nCol
            Grid.Item(sColumname, nRow).Value = sTotal


            'Grid.Item(sColumname, nRow).Value = sTotal
            'DDD
        Next nRow
    End Sub
    Function sDevuelve_Fuente_Financiamiento() As String
        Dim sCVE_FUENTE_FINANCIAMIENTO As String
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Conectar()
        cCommand = New SqlClient.SqlCommand("pPARAMETROS_MODULOS_FUENTES_FINANCIAMIENTOS_B", cConnect)
        cCommand.CommandType = CommandType.StoredProcedure
        cCommand.Parameters.AddWithValue("@MODULO", "CUOTA_RECUPERACION")
        cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
        If cDataReader.HasRows Then
            While (cDataReader.Read)
                sCVE_FUENTE_FINANCIAMIENTO = cDataReader.Item("FUENTE_FINANCIAMIENTO")
            End While
        End If
        cDataReader.Close()
        Desconectar()
        Return sCVE_FUENTE_FINANCIAMIENTO
    End Function
    Public Function fValidar_GridxFolios(ByVal GRIDX As Wisej.Web.DataGridView, ByVal sColumName As String, ByVal sFolio As String) As Boolean
        Dim bFuntionValue As Boolean
        Dim count As Integer = 0
        For i As Integer = 0 To GRIDX.Rows.Count - 1
            If GRIDX.Item(sColumName, i).Value = sFolio Then
                count = count + 1
            End If
        Next i
        If count > 1 Then
            bFuntionValue = True
        End If
        Return bFuntionValue
    End Function
    Public Function CargaMesesCerrados(ByVal cDateTimePicker As DateTimePicker, cError As ErrorProvider) As Boolean
        Dim dt As New DataTable
        Dim dr() As DataRow
        Dim Myda As New SqlDataAdapter("pCAT_EJERCICIO_B", sConexion)
        Myda.SelectCommand.CommandType = CommandType.StoredProcedure
        Myda.Fill(dt)

        dr = dt.Select("ANO_EJERCICIO=" & cDateTimePicker.Value.Year & " AND " & sArraysMeses(cDateTimePicker.Value.Month - 1) & "=0")

        If dr.Length > 0 Then
            cError.SetError(cDateTimePicker, Nothing)
            Return True
        Else
            cError.SetError(cDateTimePicker, "¡Mes Cerrado! Contacte al administrador")
            Return False
        End If
    End Function
    Public Function cargarMesesAbiertos(ByVal cDateTimePicker As DateTimePicker) As Integer()
        ''' <summary>
        '''  Regresa un array con los meses abierto. Regresa un array de longitud 0 si no hay ningún mes abierto 
        ''' </summary>
        ''' <param name="cDateTimePicker"> Fecha a comparar</param> 
        ''' <returns>retorna un array con enteros que represnta los meses abierto </returns>
        ''' <remarks></remarks>
        ''' 
        Dim dt As New DataTable
        Dim dr() As DataRow
        Dim Myda As New SqlDataAdapter("pCAT_EJERCICIO_B", sConexion)
        Myda.SelectCommand.CommandType = CommandType.StoredProcedure
        Myda.Fill(dt)

        Dim meses(-1) As Integer
        For i = 0 To sArraysMeses.Length - 1
            dr = dt.Select("ANO_EJERCICIO=" & cDateTimePicker.Value.Year & " AND " & sArraysMeses(i) & "=0")
            If dr.Length > 0 Then
                ReDim Preserve meses(meses.Length)
                meses(meses.Length - 1) = i + 1
            End If
        Next
        Return meses
    End Function

    Public Function validEjercicio(ByVal cDateTimePicker As DateTimePicker, cError As ErrorProvider) As Boolean
        If Application.Current.Session("A_EJERCICIO") = cDateTimePicker.Value.Year Then
            cError.SetError(cDateTimePicker, Nothing)
            Return True
        Else
            cError.SetError(cDateTimePicker, "La fecha no corresponde con el Año Ejercicio")
            Return False
        End If


    End Function
    Public Function valida_Fechas(ByVal cDateTimePicker As DateTimePicker, cError As ErrorProvider) As Boolean
        Dim bRegresa3 As Boolean = False


        Dim bRegresa1 As Boolean = validEjercicio(cDateTimePicker, cError)
        If bRegresa1 = False Then Exit Function


        Dim bRegresa2 As Boolean = CargaMesesCerrados(cDateTimePicker, cError)
        If bRegresa2 = False Then Exit Function


        bRegresa3 = IIf(bRegresa1 And bRegresa2, True, False)
        Return bRegresa3
    End Function
    Function REGRESAR_CLASIFICACION(ByVal cve_proyecto As String, ByVal BANDERA As String)
        Dim clasificacion As String
        Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader

        Try
            cCommand = New SqlClient.SqlCommand("pBUSCAR_CLASIFICACION", cConnect)
            cCommand.CommandType = CommandType.StoredProcedure
            cCommand.Parameters.AddWithValue("@PassphraseEnteredByUser", sConstante_KEY)
            cCommand.Parameters.AddWithValue("@CVE_PROYECTO", cve_proyecto)
            cCommand.Parameters.AddWithValue("@FOLIO_PEDIDO", cve_proyecto)
            cCommand.Parameters.AddWithValue("@ANO", Application.Current.Session("A_EJERCICIO"))
            cCommand.Parameters.AddWithValue("@BANDERA", BANDERA)
            cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While (cDataReader.Read)
                    clasificacion = cDataReader.Item("CLASIFICACION")
                End While
            End If
        Catch ex As SystemException
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()
        End Try
        Return clasificacion
    End Function
#End Region
#Region "Utilidad"

    Public Sub Configurar_AltoRow(ByVal GridView As Wisej.Web.DataGridView)
        GridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        GridView.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders)
        'GridView.Columns.

    End Sub

    '''''''''''''''''''''''''''''''''''''''''
    ' ______                                '
    ' |  ____|                              '
    ' | |__   _ __ _ __ ___  _ __ ___  ___  '
    ' |  __| | '__| '__/ _ \| '__/ _ \/ __| '
    ' | |____| |  | | | (_) | | |  __/\__ \ '
    ' |______|_|  |_|  \___/|_|  \___||___/ '
    '                                       '
    '''''''''''''''''''''''''''''''''''''''''
    'Falta fn Notificacion_Usuario
    Sub Buscar_No_Inventarios_ParaMsj()
        Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            cCommand = New SqlClient.SqlCommand("pALMACEN_INVENTARIO_CANTIDAD_B", cConnect)
            cCommand.CommandType = CommandType.StoredProcedure
            cCommand.Parameters.AddWithValue("@ANO_EJERCICIO", Application.Current.Session("A_EJERCICIO"))


            cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While (cDataReader.Read)
                    Dim cant As Integer, folio As String
                    cant = cDataReader.Item("CANTIDAD")
                    folio = cDataReader.Item("FOLIO_MOVIMIENTO")
                    'Notificacion_usuario("Inventario_Inventariar_Bienes_Presupuestales|0", "Existe la entrada: " & folio & " con " & cant.ToString & " No.Inventarios Pendientes de Asignar", "FIJO")
                End While
            End If
        Catch ex As SystemException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()
        End Try

    End Sub


    ''' <summary>
    ''' Funcion que carga un dataset ligado al reporte.
    ''' </summary>
    ''' <param name="sProcedureName">sprocedure name con parametros del swhere.</param>
    ''' <param name="DaSet">Instancia del dataset ligado al reporte </param>
    ''' <param name="cParams"> Parametros adicionales para agregar al dataset</param>
    ''' <param name="bEsText"> true para  GridX.SelectCommand.CommandType = CommandType.Text </param>
    ''' <param name="bMostrarMensaje">true para Mostrar si existe algun error</param>
    Sub LlenarGridXDataset(ByVal sProcedureName As String, ByVal DaSet As DataSet, Optional ByVal cParams() As SqlParameter = Nothing, Optional ByVal bEsText As Boolean = False)


        Dim myDA As SqlDataAdapter
        Dim myDS As DataSet = DaSet
        Try
            myDA = New Data.SqlClient.SqlDataAdapter(sProcedureName, sConexion)
            If bEsText Then
                myDA.SelectCommand.CommandType = CommandType.Text
            Else
                myDA.SelectCommand.CommandType = CommandType.StoredProcedure
                If cParams Is Nothing = False Then
                    For i = 0 To cParams.GetLength(0) - 1
                        If cParams(i) Is Nothing = False Then
                            myDA.SelectCommand.Parameters.Add(cParams(i))
                        End If
                    Next
                End If

            End If

            myDA.Fill(DaSet.Tables(0))
            myDA.Dispose()
        Catch ex As SystemException
            Guardar_Error(modulo, ex.Message, operador, sProcedureName, formulario)
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally


        End Try
    End Sub
    Function fDevueve_ConcecutivoFormateado(ByVal digitos As Integer, ByVal concecutivo As Integer) As String
        Dim fmt As String = ""
        Dim retorna As String

        For i = 0 To digitos - 1
            fmt = fmt & "0"
        Next
        fmt = fmt & ".##"

        retorna = Format(concecutivo, fmt)
        Return retorna
    End Function


    Public Shared Sub quitarProvider(provider As ErrorProvider, ByVal c1 As Control)
        For Each c As Control In c1.Controls
            provider.SetError(c, Nothing)
            quitarProvider(provider, c)
        Next
    End Sub
    'Public Shared Sub recorrer(ByVal c1 As Control, ByRef util As String, Optional ByRef tab As String = "")
    '    For Each c As Control In c1.Controls

    '        util += tab & "(P)" & c.Parent.Name & ": (" & c.GetType.Name & ")" & c.Name & ":(H)" & c.Controls.Count & vbCrLf
    '        If c.Controls.Count > 0 Then
    '            tab += ControlChars.Tab
    '        Else
    '            tab += ControlChars.Back
    '        End If
    '        recorrer(c, util)
    '    Next
    'End Sub


    '''''''''''''''''''''''''''''''''''''''''
    ' ______                                '
    ' |  ____|                              '
    ' | |__   _ __ _ __ ___  _ __ ___  ___  '
    ' |  __| | '__| '__/ _ \| '__/ _ \/ __| '
    ' | |____| |  | | | (_) | | |  __/\__ \ '
    ' |______|_|  |_|  \___/|_|  \___||___/ '
    '''''''''''''''''''''''''''''''''''''''''
    'Public Shared Sub Limpiar(ByVal c1 As Control, Optional checkboxes As Boolean = True, Optional radios As Boolean = False, Optional omit As Control = Nothing)

    '    For Each c As Control In c1.Controls
    '        If TypeOf c Is ComboBox Then
    '            If c IsNot Nothing Then If c.Equals(omit) Then Continue For
    '            DirectCast(c, ComboBox).SelectedIndex = -1
    '        ElseIf (TypeOf (c) Is SaldosMensualesSax) Then
    '            If c IsNot Nothing Then If c.Equals(omit) Then Continue For
    '            CType(c, SaldosMensualesSax).clear()
    '        ElseIf (TypeOf (c) Is CheckBox) Then
    '            If c IsNot Nothing Then If c.Equals(omit) Then Continue For
    '            If checkboxes Then CType(c, CheckBox).Checked = False
    '        ElseIf (TypeOf (c) Is RadioButton) Then
    '            If c IsNot Nothing Then If c.Equals(omit) Then Continue For
    '            If radios Then CType(c, RadioButton).Checked = False
    '        ElseIf TypeOf c Is DateTimePicker Then
    '            If c IsNot Nothing Then If c.Equals(omit) Then Continue For
    '            Dim dtp = CType(c, DateTimePicker)
    '            If Date.Now >= dtp.MinDate And Date.Now <= dtp.MaxDate Then
    '                dtp.Value = Date.Now
    '            Else
    '                dtp.Value = dtp.MinDate
    '            End If
    '        ElseIf TypeOf c Is PictureBox Then
    '            If c IsNot Nothing Then If c.Equals(omit) Then Continue For
    '            CType(c, PictureBox).Image = Nothing
    '        ElseIf TypeOf c Is combosax Then
    '            If c IsNot Nothing Then If c.Equals(omit) Then Continue For
    '            DirectCast(c, combosax).SelectedIndex = -1
    '        ElseIf TypeOf c Is DateTimePickerSax Then
    '            DirectCast(c, DateTimePickerSax).Value = Now.Date
    '        ElseIf TypeOf c Is TextBox Then
    '            If c IsNot Nothing Then If c.Equals(omit) Then Continue For
    '            DirectCast(c, TextBox).Text = ""
    '        ElseIf TypeOf c Is NumericTextbox Then
    '            If c IsNot Nothing Then If c.Equals(omit) Then Continue For
    '            DirectCast(c, NumericTextbox).AsCurrency = 0
    '        ElseIf TypeOf c Is NumericUpDown Then
    '            If c IsNot Nothing Then If c.Equals(omit) Then Continue For
    '            Dim nud = DirectCast(c, NumericUpDown)
    '            If 0 >= nud.Minimum And 0 <= nud.Maximum Then
    '                nud.Value = 0
    '            Else
    '                nud.Value = nud.Minimum
    '            End If
    '        Else

    '            Limpiar(c, checkboxes, radios, omit)
    '        End If
    '    Next
    'End Sub
    Public Shared Function TrimS(text As Object, Optional chars() As Char = Nothing) As String
        If IsDBNull(text) Then Return ""
        text = text.ToString
        If chars = Nothing Then
            Return text.Trim(" ", Chr(10), Chr(13))
        Else
            For Each c As Char In chars
                text = text.Trim(c)
            Next
            Return text
        End If
    End Function
    Public Shared Sub llenarComboDeGrilla(combo As ComboBox, grilla As Wisej.Web.DataGridView)
        Try
            Dim tabla As DataTable = New DataTable("COMBO")
            tabla.Columns.Add("valor")
            tabla.Columns.Add("descripcion")
            Dim binding As BindingSource = TryCast(grilla.DataSource, BindingSource)
            Dim tab2 As DataTable
            If binding IsNot Nothing Then
                tab2 = binding.DataSource.Tables(0)
            Else
                tab2 = TryCast(grilla.DataSource.tables(0), DataTable)
            End If
            'If tab2 Is Nothing Then Throw New Exception("")
            For i = 0 To grilla.ColumnCount - 1
                If grilla.Columns(i).Visible = True And grilla.Columns(i).CellType.Name = "DataGridViewTextBoxCell" Then
                    If grilla.Columns(i).DataPropertyName <> Nothing Then
                        If tab2.Columns(grilla.Columns(i).DataPropertyName) IsNot Nothing Then
                            If tab2.Columns(grilla.Columns(i).DataPropertyName).DataType.Name <> "DateTime" Then
                                tabla.Rows.Add(grilla.Columns(i).DataPropertyName, grilla.Columns(i).HeaderText)
                            End If
                        End If
                    End If
                End If
            Next
            combo.ValueMember = "valor"
            combo.DisplayMember = "descripcion"
            combo.DataSource = tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Sub llenarComboConTabla(combo As ComboBox, datos As Dictionary(Of String, String))
        Try
            Dim tabla As DataTable = New DataTable("COMBO")
            tabla.Columns.Add("valor")
            tabla.Columns.Add("descripcion")
            For Each pair In datos
                Dim Row = tabla.NewRow()
                Row("valor") = pair.Key
                Row("descripcion") = pair.Value
                tabla.Rows.Add(Row)
            Next
            combo.ValueMember = "valor"
            combo.DisplayMember = "descripcion"
            combo.DataSource = tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Devuelve el represantativo del mes en entero
    ''' </summary>
    ''' <returns>returna -1 si no se puede parsear el mes</returns>
    Public Shared Function Mes_A_Numero(mes As String) As Integer
        Dim valor As Integer = -1
        Dim mesString As meses
        If dllData.TrimS(mes) IsNot Nothing Then
            mes = mes.Trim.Substring(0, 1).ToUpper & mes.Trim.Substring(1, mes.Length - 1).ToLower
            If dllData.meses.TryParse(mes, mesString) Then
                Return mesString
            End If
        End If
        Return valor
    End Function


    ''' <summary>
    ''' Aplica un filtro (Where) a una tabla y/o grilla
    ''' </summary>
    ''' <param name="columna">El nombre de la columna de la tabla.</param>
    ''' <param name="valor">El valor del filtro.</param>
    ''' <param name="tabla">Tabla o tabla del dataset.</param>
    ''' <param name="grilla">DataGridView.</param>
    ''' <param name="filtrarVacios">Si desea permitir que los filtrar columnas cuando estén vacias.</param>
    ''' <param name="isLike">Si desea permitir que los filtrar columnas cuando estén vacias.</param>
    ''' <remarks></remarks>
    Public Shared Sub filtrarGrilla(columna As String, valor As String, tabla As DataTable, grilla As Wisej.Web.DataGridView, Optional filtrarVacios As Boolean = False, Optional isLike As Boolean = True, Optional tException As Boolean = False) 'As Boolean

        Try
            If columna <> Nothing And Not tabla Is Nothing And Not grilla Is Nothing Then
                Dim col = tabla.Columns().Item(columna)
                If Not col Is Nothing Then 'VERIFICA si existe esa columna en la tabla
                    Dim sWhere As String = ""
                    If valor IsNot Nothing Then
                        If valor <> "" Or filtrarVacios Then 'Si recibe Nothing, limpia el filtro
                            Dim compare = " LIKE '%", compare2 As String = "%'"
                            If Not isLike Then compare = "='" : compare2 = "'" 'si no quieres usar like se cambia "like" por "="
                            If col.DataType.Name.Contains("Int") Or col.DataType.Name.Contains("Decimal") Then 'si es númerico, se transforma a un double y  se cambia "like" por "="
                                valor = rellenar(valor, 10) : compare = "=" : compare2 = ""
                            End If
                            If col.DataType.Name <> "DateTime" Then sWhere = columna & compare & valor & compare2 'Construye el filtro

                        End If
                        Dim defaultV As DataView = tabla.DefaultView
                        defaultV.RowFilter = sWhere
                        grilla.DataSource = defaultV

                    End If
                End If
            End If
        Catch ex As Exception
            If tException Then
                Throw ex
            Else
                Dim defaultV As DataView = tabla.DefaultView
                defaultV.RowFilter = ""
                grilla.DataSource = defaultV
            End If
        End Try

    End Sub
    'Puublic Shared Sub paginacion(indexPosicion As Integer, grilla As Wisej.Web.DataGridView, Optional seleccionarFila As Boolean = True)
    '    If grilla.UseInternalPaging Then
    '        Dim pag As Integer = Math.Ceiling((indexPosicion / grilla.ItemsPerPage()) + 0.001)
    '        grilla.CurrentPage() = pag
    '    End If
    '    If seleccionarFila Then
    '        grilla.ClearSelection()
    '        grilla.Rows(indexPosicion).Selected = True
    '        grilla.FirstDisplayedScrollingRowIndex() = indexPosicion
    '    End If
    'End Sub
    'Puublic Shared Sub paginacion(bs As BindingSource, clave As String, valor As String, grilla As Wisej.Web.DataGridView, Optional seleccionarFila As Boolean = True)
    '    Dim indexPosicion = bs.Find(clave, valor)
    '    If grilla.UseInternalPaging Then
    '        Dim pag As Integer = Math.Ceiling((indexPosicion / grilla.ItemsPerPage()) + 0.001)
    '        grilla.CurrentPage() = pag
    '    End If
    '    If seleccionarFila Then
    '        grilla.ClearSelection()
    '        grilla.Rows(indexPosicion).Selected = True
    '        grilla.FirstDisplayedScrollingRowIndex() = indexPosicion
    '        'recorrer(grilla.Parent, dd)
    '    End If

    'End Sub

    Public Shared Function sProvider(provider As ErrorProvider, control As Control, mensaje As String) As Boolean
        provider.SetError(control, mensaje)
        control.Focus()
        Return False
    End Function
    '''''''''''''''''''''''''''''''''''''''''
    ' ______                                '
    ' |  ____|                              '
    ' | |__   _ __ _ __ ___  _ __ ___  ___  '
    ' |  __| | '__| '__/ _ \| '__/ _ \/ __| '
    ' | |____| |  | | | (_) | | |  __/\__ \ '
    ' |______|_|  |_|  \___/|_|  \___||___/ '
    '                                       '
    '''''''''''''''''''''''''''''''''''''''''
    'Falta control MBox

    Public Function encriptar128BitRijndael(
ByVal textoEncriptar As String,
ByVal claveEncriptacion As String) As String
        Dim bytValue() As Byte
        Dim bytKey() As Byte
        Dim bytEncoded() As Byte = New Byte() {}
        Dim bytIV() As Byte = {121, 241, 10, 1, 132,
74, 11, 39, 255, 91, 45,
78, 14, 211, 22, 62}
        Dim intLength As Integer
        Dim intRemaining As Integer
        Dim objMemoryStream As New MemoryStream()
        Dim objCryptoStream As CryptoStream
        Dim objRijndaelManaged As RijndaelManaged


        'Quitar nulos en cadena de texto a encriptar
        textoEncriptar = textoEncriptar

        If textoEncriptar = "" Then
            Return ""
        End If

        bytValue = Encoding.ASCII.GetBytes(textoEncriptar.ToCharArray)

        intLength = Len(claveEncriptacion)


        'La clave de cifrado debe ser de 256 bits de longitud (32 bytes)
        'Si tiene más de 32 bytes se truncará
        'Si es menor de 32 bytes se rellenará con X
        If intLength >= 32 Then
            claveEncriptacion = Strings.Left(claveEncriptacion, 32)
        Else
            intLength = Len(claveEncriptacion)
            intRemaining = 32 - intLength
            claveEncriptacion = claveEncriptacion & Strings.StrDup(intRemaining, "X")
        End If

        bytKey = Encoding.ASCII.GetBytes(claveEncriptacion.ToCharArray)

        objRijndaelManaged = New RijndaelManaged()

        Try
            'Crear objeto Encryptor y escribir su valor 
            'después de que se convierta en array de bytes
            objCryptoStream = New CryptoStream(objMemoryStream,
objRijndaelManaged.CreateEncryptor(bytKey, bytIV),
CryptoStreamMode.Write)
            objCryptoStream.Write(bytValue, 0, bytValue.Length)

            objCryptoStream.FlushFinalBlock()

            bytEncoded = objMemoryStream.ToArray
            objMemoryStream.Close()
            objCryptoStream.Close()
        Catch ex As Exception
            MsgBox("Error al encriptar cadena de texto: " &
ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
        End Try

        'Devolver el valor del texto encriptado
        'convertido de array de bytes a texto en base64
        Return Convert.ToBase64String(bytEncoded)
    End Function

    '''''''''''''''''''''''''''''''''''''''''
    ' ______                                '
    ' |  ____|                              '
    ' | |__   _ __ _ __ ___  _ __ ___  ___  '
    ' |  __| | '__| '__/ _ \| '__/ _ \/ __| '
    ' | |____| |  | | | (_) | | |  __/\__ \ '
    ' |______|_|  |_|  \___/|_|  \___||___/ '
    '                                       '
    '''''''''''''''''''''''''''''''''''''''''
    'Falta ManagementObjetSearcher
    Function Busqueda_Secreta() As String
        Try
            Dim strMACAddress As String = ""
            '
            ' Create the query, in SQL syntax, to retrieve the properties from
            ' the active Network Adapter.
            '
            Dim strQuery As String =
"SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = True"

            '
            ' Create a ManagementObjectSearcher object passing in the query to run.
            '
            Dim query As ManagementObjectSearcher = New ManagementObjectSearcher(strQuery)

            '
            ' Create a ManagementObjectCollection assigning it the results of the query.
            '
            Dim queryCollection As ManagementObjectCollection = query.Get()

            '
            ' Loop through the results extracting the MAC Address.
            '
            Dim mo As ManagementObject

            For Each mo In queryCollection
                strMACAddress = mo("MacAddress").ToString().Replace(":", "")
                Exit For
            Next

            Return strMACAddress & "HDD" & hddID()

        Catch ex As Exception
            Return ""
        End Try
    End Function

    '''''''''''''''''''''''''''''''''''''''''
    ' ______                                '
    ' |  ____|                              '
    ' | |__   _ __ _ __ ___  _ __ ___  ___  '
    ' |  __| | '__| '__/ _ \| '__/ _ \/ __| '
    ' | |____| |  | | | (_) | | |  __/\__ \ '
    ' |______|_|  |_|  \___/|_|  \___||___/ '
    '                                       '
    '''''''''''''''''''''''''''''''''''''''''
    'ManagementObjectSearcher
    Function hddID() As String
        'Try
        '    Dim strSN As String = ""
        '    Dim strQuery As String = "SELECT * FROM Win32_PhysicalMedia"
        '    Dim query As ManagementObjectSearcher = New ManagementObjectSearcher(strQuery)
        '    Dim i As Integer = 0

        '    For Each mo As ManagementObject In query.[Get]()


        '        If mo("SerialNumber") IsNot Nothing Then
        '            '    strSN = strSN & " " & "N/A Serial"
        '            'Else
        '            strSN = strSN & "" & mo("SerialNumber").ToString()
        '        End If
        '        i += 1
        '    Next

        '    Return Trim(strSN)

        'Catch ex As Exception
        '    Return ""
        'End Try
    End Function



    ''' <summary>
    ''' Devuelve sólo los numeros de de una cadena de texto
    ''' </summary>
    ''' <param name="texto">El texto a filtrar.</param>
    ''' <param name="decimales">La cantidad de decimales que debe tener.</param>
    ''' <param name="negativo">Si permite devolver valor negativo.</param>
    ''' <remarks></remarks>
    Public Shared Function rellenar(ByVal texto As String, Optional decimales As Integer = 0, Optional negativo As Boolean = False)
        Dim numeros As Char()
        If texto Is Nothing Then
            texto = "0"
        End If
        If IsDBNull(texto) Then
            texto = "0"
        End If

        If (decimales > 0) Then
            numeros = texto.ToCharArray()
            texto = ""
            For i = 0 To numeros.Length - 1
                If ((numeros(i) >= "0" And numeros(i) <= "9") Or numeros(i) = ".") Then
                    texto += numeros(i)
                ElseIf negativo And numeros(0) = "-" Then
                    texto += numeros(i)
                End If
            Next i
            If texto.Contains(".") Then
                Dim entero_decimal() As String = texto.Split(".")
                If entero_decimal(1).Length >= decimales Then
                    entero_decimal(1) = entero_decimal(1).Substring(0, decimales)
                    texto = entero_decimal(0) & "." & entero_decimal(1)
                Else
                    texto = entero_decimal(0) & "."
                    For i = 1 To decimales - entero_decimal(1).Length
                        entero_decimal(1) += "0"
                    Next
                    texto += entero_decimal(1)
                End If
            Else
                texto = texto & "."
                For i = 1 To decimales
                    texto = texto & "0"
                Next
            End If
        Else
            Dim entero As String() = texto.Split(".")
            numeros = entero(0).ToCharArray()
            texto = ""
            For i = 0 To numeros.Length - 1
                If (numeros(i) >= "0" And numeros(i) <= "9") Then
                    texto += numeros(i)
                ElseIf negativo And numeros(0) = "-" Then
                    texto += numeros(i)
                End If
            Next i
        End If
        If texto.Length > 0 Then
            If texto.Substring(0, 1) = "." Then texto = "0" + texto
        Else texto = "0"
        End If
        Return texto
    End Function

    Sub ErrorSax(ByVal Cntrol As Object, ByVal Estatus As Boolean)
        If Estatus = False Then
            'Cntrol.BackColor = Color.White
            Cntrol.ForeColor = Color.Black
        Else
            'Cntrol.BackColor = Color.Red
            Cntrol.ForeColor = Color.White
        End If
    End Sub
    'Sub AlternatingColors_Grilla(ByVal GridX As Wisej.Web.DataGridView)
    '    With GridX
    '        .RowsDefaultCellStyle.BackColor = Color.White
    '        .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
    '    End With
    '    ''
    'End Sub
    Function ListViewObtenerSubIndice_Columna(ByVal ListViewX As Wisej.Web.ListView, ByVal sColumnaTagABuscar As String) As Integer
        Dim i As Integer
        For i = 0 To ListViewX.Columns.Count - 1

            If UCase(Trim(sColumnaTagABuscar)) = UCase(Trim(ListViewX.Columns(i).Tag)) Then
                Return i
                Exit Function
            End If
        Next i     '


    End Function

    '''''''''''''''''''''''''''''''''''''''''
    ' ______                                '
    ' |  ____|                              '
    ' | |__   _ __ _ __ ___  _ __ ___  ___  '
    ' |  __| | '__| '__/ _ \| '__/ _ \/ __| '
    ' | |____| |  | | | (_) | | |  __/\__ \ '
    ' |______|_|  |_|  \___/|_|  \___||___/ '
    '                                       '
    '''''''''''''''''''''''''''''''''''''''''
    'ComboGridSax no definido
    'Function LlenarComboGridSax(ByVal ComboGridSax As ComboGridSax, ByVal BvDataset As DataTable, ByVal pProcedure As String, ByVal Grid As Wisej.Web.DataGridView, ByVal BvSelectedValue As String, ByVal BvSelectedItem As String, Optional ByVal cParams() As SqlParameter = Nothing) As Integer

    '    BvDataset.Clear()
    '    Dim myDA = New SqlClient.SqlDataAdapter(pProcedure, sConexion)
    '    myDA.SelectCommand.CommandType = CommandType.StoredProcedure

    '    Dim sPARAMETROS As String
    '    If cParams Is Nothing = False Then
    '        For i = 0 To cParams.GetLength(0) - 1
    '            If cParams(i) Is Nothing = False Then

    '                myDA.SelectCommand.Parameters.Add(cParams(i))

    '                If i = 0 Then
    '                    If cParams(i).SqlDbType = SqlDbType.NVarChar Then
    '                        sPARAMETROS = sPARAMETROS & cParams(i).ToString & "='" & cParams(i).Value & "'"
    '                    Else
    '                        sPARAMETROS = sPARAMETROS & cParams(i).ToString & "=" & cParams(i).Value
    '                    End If
    '                Else
    '                    If cParams(i).SqlDbType = SqlDbType.NVarChar Then
    '                        sPARAMETROS = sPARAMETROS & "," & cParams(i).ToString & "='" & cParams(i).Value & "'"
    '                    Else
    '                        sPARAMETROS = sPARAMETROS & "," & cParams(i).ToString & "=" & cParams(i).Value
    '                    End If
    '                End If
    '            End If
    '        Next
    '    End If

    '    myDA.Fill(BvDataset)
    '    myDA.Dispose()

    '    ComboGridSax.AddGrid(Grid, BvSelectedValue, BvSelectedItem, pProcedure + " " + sPARAMETROS)

    'End Function


    'Suub EfectoAcabado(sender As Object, e As System.EventArgs)
    '    'If sender.Location.Y = 100 Then
    '    '    sender.Location = New System.Drawing.Point(sender.Location.X, sender.Location.Y - 100)
    '    'Else
    '    '    sender.Location = New System.Drawing.Point(sender.Location.X, sender.Location.Y + 100)

    '    'End If

    '    sender.VisualEffect = New Wisej.Web.VisualEffects.TranslateVisualEffect(New Wisej.Web.VisualEffects.AxisLengthAndUnits(Wisej.Web.VisualEffects.LengthUnits.Pixel, Wisej.Web.VisualEffects.LengthUnits.Pixel, Wisej.Web.VisualEffects.LengthUnits.Pixel, Nothing, Nothing, Nothing), New Wisej.Web.VisualEffects.AxisLengthAndUnits(Wisej.Web.VisualEffects.LengthUnits.Pixel, Wisej.Web.VisualEffects.LengthUnits.Pixel, Wisej.Web.VisualEffects.LengthUnits.Pixel, 0, X, Nothing), New Decimal(New Integer() {1, 0, 0, 0}), New Decimal(New Integer() {0, 0, 0, 0}), Wisej.Web.VisualEffects.TransitionTimingFunction.Ease)



    'End Sub
    Public ReadOnly Property Errors() As String
        Get
            Errors = cErrors
        End Get
    End Property
    Public Function ObtenerUltimoDiaMes(ByVal Mes As Integer, ByVal Anio As Integer) As Integer
        If (Mes > 12 Or Mes < 1) Then Return -1 '//Error
        Mes = Mes - 1
        Dim DiasMes() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        If (Anio Mod 4) = 0 Then DiasMes(2) = 29
        Return DiasMes(Mes)
    End Function
    Public Function funcion_fDevuelveIndexOfMonth(ByVal sMes As String) As Integer
        For x As Integer = 0 To sArraysMeses.Length - 1
            If UCase(sArraysMeses(x)) = UCase(sMes) Then
                funcion_fDevuelveIndexOfMonth = x + 1
                Exit Function
            End If
        Next

    End Function
    Function fFormatearDias(ByVal dFecha As Date) As Integer
        Dim ultimoDia As Integer = Microsoft.VisualBasic.DateAndTime.Day(DateSerial(Year(dFecha), Month(dFecha) + 1, 0))
        Dim nCorrespondiente As Integer = 0
        Dim nDif As Integer = 1
        For i As Integer = 1 To dFecha.Day
            nCorrespondiente = i + (ultimoDia - nDif)
            nDif = nDif + 2
        Next
        fFormatearDias = nCorrespondiente
        Return fFormatearDias
    End Function
    Function sacar_Dias(ByVal Fecha_Inicio As Date, ByVal Fecha_fin As Date) As Integer
        Dim x As Integer
        Dim XDIA As DateTime = Fecha_Inicio


        For x = Convert.ToInt32(Fecha_Inicio.DayOfYear) To Convert.ToInt32(Fecha_fin.DayOfYear)

            If XDIA.DayOfWeek <> DayOfWeek.Saturday And XDIA.DayOfWeek <> DayOfWeek.Sunday Then
                If Fecha_Inicio.Month = 9 Or Fecha_fin.Month = 9 Then
                    If XDIA.Day = 16 Then
                        sacar_Dias = sacar_Dias - 1
                    End If
                End If
                sacar_Dias = sacar_Dias + 1
            End If
            XDIA = XDIA.AddDays(1)


        Next x
        Return sacar_Dias
    End Function
    Function fDevuelve_Total_Dias(ByVal Fecha_Inicio As Date, ByVal Fecha_fin As Date) As Integer
        Dim Dias As Integer
        Dim dUltimoDia As Date
        Dim nUltimoDia, nTotalDias, ndia As Integer
        If Fecha_Inicio.Year < Now.Year Then
            If (Now.Year - Fecha_Inicio.Year) = 1 Then
                ndia = fFormatearDias(Fecha_Inicio)
                Select Case Fecha_Inicio.Month
                    Case 1
                        dUltimoDia = ndia & "/12/" & Fecha_Inicio.Year
                    Case 2
                        dUltimoDia = ndia & "/11/" & Fecha_Inicio.Year
                    Case 3
                        dUltimoDia = ndia & "/10/" & Fecha_Inicio.Year
                    Case 4
                        dUltimoDia = ndia & "/09/" & Fecha_Inicio.Year
                    Case 5
                        dUltimoDia = ndia & "/08/" & Fecha_Inicio.Year
                    Case 6
                        dUltimoDia = ndia & "/07/" & Fecha_Inicio.Year
                    Case 7
                        dUltimoDia = ndia & "/06/" & Fecha_Inicio.Year
                    Case 8
                        dUltimoDia = ndia & "/05/" & Fecha_Inicio.Year
                    Case 9
                        dUltimoDia = ndia & "/04/" & Fecha_Inicio.Year
                    Case 10
                        dUltimoDia = ndia & "/03/" & Fecha_Inicio.Year
                    Case 11
                        dUltimoDia = ndia & "/02/" & Fecha_Inicio.Year
                    Case 12
                        dUltimoDia = ndia & "/01/" & Fecha_Inicio.Year
                End Select
                nUltimoDia = dUltimoDia.DayOfYear
                nTotalDias = (nUltimoDia + Fecha_Inicio.DayOfYear)
            End If
        ElseIf Fecha_Inicio.Year > Now.Year Then
            If (Fecha_Inicio.Year - Now.Year) = 1 Then
                dUltimoDia = "31/12/" & Now.Year
                nUltimoDia = dUltimoDia.DayOfYear
                nTotalDias = (nUltimoDia + (Fecha_Inicio.DayOfYear - Fecha_Inicio.DayOfYear)).ToString
            End If
        Else
            nTotalDias = (Fecha_fin.DayOfYear - Fecha_Inicio.DayOfYear)
        End If

        Return nTotalDias
    End Function
    Sub GuardarChildren(ByVal cControls As Object, ByVal sId_Key As String)
        Dim nMatrizEmpiezadesde As Integer
        Dim cControl As Object
        Dim sDatafield As String
        'Dim sCad As String
        Try
            For Each cControl In cControls.Controls
                sDatafield = ""
                Select Case UCase(TypeName(cControl))
                    Case "TEXTBOX", "CALENDARCOMBO", "NUMERICUPDOWN", "COMBOBOX", "DATETIMEPICKER", "MASKEDTEXTBOX", "RICHTEXTBOX", "CHECKBOX", "NUMERICTEXTBOX"
                        If Trim(cControl.Tag) <> Nothing Then
                            If InStr(cControl.Tag, "/NA") = 0 Then
                                sDatafield = Mid(cControl.Tag, 1, InStr(cControl.Tag, "/") - 1)
                                If Trim(sId_Key) = Trim(sDatafield) And Trim(sId_Key) <> Nothing Then
                                    cControl.Enabled = False
                                    'Valido que no se guarde el id
                                    'ya que lo asigno al tag
                                    ' ''If bActualizar Then
                                    ' ''    sDatafield = ""
                                    ' ''End If

                                End If
                            End If
                        End If
                    Case Else
                        sDatafield = ""
                End Select
                If Trim(sDatafield) <> Nothing Then
                    If ParametersX_Global.Length <> 0 Then
                        nMatrizEmpiezadesde = ParametersX_Global.Length - 1
                    End If
                    ReDim Preserve ParametersX_Global(nMatrizEmpiezadesde + 1)
                    nMatrizEmpiezadesde = nMatrizEmpiezadesde + 1
                    Select Case UCase(TypeName(cControl))
    'Case "RADIOBUTTON"
    '    Dim cControlUIRadioButton As Wisej.Web.RadioButton
    '    cControlUIRadioButton = cControl
    '    If cControlUIRadioButton.Checked = True Then
    '        ParametersX_Global(nMatrizEmpiezadesde) = New SqlClient.SqlParameter("@" & sDatafield, cControlUIRadioButton.Text)
    '    End If
                        Case "CHECKBOX"
                            Dim cControlUICheckBox As Wisej.Web.CheckBox
                            cControlUICheckBox = cControl
                            ParametersX_Global(nMatrizEmpiezadesde) = New SqlClient.SqlParameter("@" & sDatafield, cControlUICheckBox.Checked)
                        Case "COMBOBOX"

                            Dim cControlUiCombobox As Wisej.Web.ComboBox
                            cControlUiCombobox = cControl
                            If cControlUiCombobox.DropDownStyle = ComboBoxStyle.DropDownList Or cControlUiCombobox.DropDownStyle = ComboBoxStyle.DropDown Then
                                If InStr(1, cControlUiCombobox.Tag, "/1") Then
                                    If cControlUiCombobox.SelectedIndex = -1 Then
                                        If cControl.visible = True Then
                                            MessageBox.Show("Faltan Datos Por Rellenar: '" & cControl.Tag & "'", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            cControlUiCombobox.Focus()
                                            bPasoValidacionMensaje.Add(bPasoValidacionMensaje.Count + 1, cControl.parent.TEXT.ToString)
                                            bPasoValidacion = False
                                        End If
                                    Else
                                        ParametersX_Global(nMatrizEmpiezadesde) = New SqlClient.SqlParameter("@" & sDatafield, cControlUiCombobox.SelectedValue)
                                    End If
                                End If
                            Else
                                If InStr(1, cControlUiCombobox.Tag, "/1") Then
                                    If Trim(cControlUiCombobox.Text) = Nothing Then
                                        If cControl.visible = True Then
                                            MessageBox.Show("Faltan Datos Por Rellenar: '" & cControl.Tag & "'", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            cControlUiCombobox.Focus()
                                            bPasoValidacionMensaje.Add(bPasoValidacionMensaje.Count + 1, cControl.parent.TEXT.ToString)
                                            bPasoValidacion = False
                                        End If
                                    End If
                                Else
                                    ParametersX_Global(nMatrizEmpiezadesde) = New SqlClient.SqlParameter("@" & sDatafield, TrimS(cControlUiCombobox.Text))
                                End If
                            End If

                        Case "TEXTBOX", "MASKEDTEXTBOX", "NUMERICTEXTBOX"
                            If InStr(1, cControl.Tag, "/1") Then
                                If Trim(cControl.Text) = Nothing Then
                                    If cControl.visible = True Then
                                        MessageBox.Show("Faltan Datos Por Rellenar: '" & cControl.Tag & "'", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        If cControl.Enabled Then
                                            cControl.Focus()
                                        End If
                                        bPasoValidacionMensaje.Add(bPasoValidacionMensaje.Count + 1, cControl.parent.TEXT.ToString)
                                        bPasoValidacion = False
                                    End If
                                Else
                                    ParametersX_Global(nMatrizEmpiezadesde) = New SqlClient.SqlParameter("@" & sDatafield, TrimS(cControl.Text))
                                End If
                            Else
                                ParametersX_Global(nMatrizEmpiezadesde) = New SqlClient.SqlParameter("@" & sDatafield, TrimS(cControl.Text))
                            End If

                        Case "NUMERICUPDOWN"
                            Dim cControlNumericEditBox As Wisej.Web.NumericUpDown
                            cControlNumericEditBox = cControl
                            If InStr(1, cControlNumericEditBox.Tag, "/1") Then
                                If Trim(cControlNumericEditBox.Value) = Nothing Then
                                    MessageBox.Show("Faltan Datos Por Rellenar: '" & cControl.Tag & "'", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    If cControlNumericEditBox.Visible And cControlNumericEditBox.Enabled Then
                                        cControlNumericEditBox.Focus()
                                    End If
                                    If cControl.visible = True Then
                                        bPasoValidacionMensaje.Add(bPasoValidacionMensaje.Count + 1, cControl.parent.TEXT.ToString)
                                        bPasoValidacion = False
                                    End If
                                Else
                                    ParametersX_Global(nMatrizEmpiezadesde) = New SqlClient.SqlParameter("@" & sDatafield, cControlNumericEditBox.Value)
                                End If
                            Else
                                ParametersX_Global(nMatrizEmpiezadesde) = New SqlClient.SqlParameter("@" & sDatafield, cControlNumericEditBox.Value)
                            End If
                        Case "DATETIMEPICKER"
                            Dim cCalendarCombo As Wisej.Web.DateTimePicker
                            cCalendarCombo = cControl
                            'If cCalendarCombo.Checked Then
                            If InStr(1, cControl.Tag, "/1") > 0 And Trim("" & cCalendarCombo.Value) = Nothing Then
                                MessageBox.Show("Faltan Datos Por Rellenar: '" & cControl.Tag & "'", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                If cCalendarCombo.Visible And cCalendarCombo.Enabled Then
                                    cCalendarCombo.Focus()
                                End If
                                If cControl.visible = True Then
                                    bPasoValidacionMensaje.Add(bPasoValidacionMensaje.Count + 1, cControl.parent.TEXT.ToString)
                                    bPasoValidacion = False
                                End If
                            End If
                            ParametersX_Global(nMatrizEmpiezadesde) = New SqlClient.SqlParameter("@" & sDatafield, cCalendarCombo.Value)
                            'End If
                    End Select
                End If
                If cControl.HasChildren Then
                    GuardarChildren(cControl, sId_Key)
                End If
            Next
        Catch ex As SystemException
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Public Function fDevuelve_Saldo_Cuenta_Contable(ByVal sCve_Cuenta As String, ByVal EsSuma As Boolean, ByVal F_Inicio As String, ByVal F_Fin As String, Optional ByVal bEsCuenta_Economica As Boolean = True, Optional ByVal sCampo As String = "", Optional ByVal sNivel As Integer = 0, Optional ByVal sCampo2 As String = "") As Double
        Dim total, saldo, SInicial, s_Anterior, sActual, Ingresos, Gastos As Double
        Dim bPasa As Boolean = True
        Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            cCommand = New SqlClient.SqlCommand("pESTADOS_FINANCIEROS_B", cConnect)
            cCommand.CommandType = CommandType.StoredProcedure
            cCommand.Parameters.AddWithValue("@CUENTAS", sCve_Cuenta)
            cCommand.Parameters.AddWithValue("@FECHA_INICIO", F_Inicio)
            cCommand.Parameters.AddWithValue("@FECHA_FIN", F_Fin)
            cCommand.Parameters.AddWithValue("@EJERCICIO", Trim(Application.Current.Session("A_EJERCICIO")))
            If sCampo = "GASTOS_INGRESOS" And sNivel = 1 Then
                cCommand.Parameters.AddWithValue("@MOSTRAR_CIERRE", 1)
            Else
                cCommand.Parameters.AddWithValue("@MOSTRAR_CIERRE", 1)
            End If
            If Application.Current.Session("CVE_FUENTE_FINANCIAMIENTO") <> Nothing Then
                cCommand.Parameters.AddWithValue("@CVE_FUENTE_FINANCIAMIENTO", Application.Current.Session("CVE_FUENTE_FINANCIAMIENTO"))
            End If
            cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While (cDataReader.Read)
                    If sCampo <> "ACTIVIDAD" Then
                        If bEsCuenta_Economica Then
                            If sCampo = "VARIACION" And sCampo2 = "VARIACION_ACUMULADA" Then
                                If sCve_Cuenta = "1.1.1.1.0,1.1.1.2.0" Then
                                    total = total + cDataReader.Item(sCampo)
                                Else
                                    If EsSuma Then
                                        total = total + cDataReader.Item(sCampo2)
                                    Else
                                        total = cDataReader.Item(sCampo)
                                    End If
                                End If
                            Else
                                If sNivel = 12 Then
                                    If (cDataReader.Item("COD_CUENTA") = "1.1.1.1.0" Or cDataReader.Item("COD_CUENTA") = "1.1.1.2.0") Then
                                        If bPasa Then
                                            saldo = cDataReader.Item(sCampo2)
                                            bPasa = False
                                        Else
                                            sActual = cDataReader.Item(sCampo2)
                                            SInicial = saldo + sActual
                                            If SInicial < 0 Then
                                                SInicial = 0
                                            End If

                                        End If

                                    Else
                                        total = total + cDataReader.Item(sCampo2) + SInicial
                                    End If
                                Else
                                    If EsSuma Then

                                        saldo = cDataReader.Item("SALDO_ACTUAL")
                                        If saldo < 0 Then
                                            saldo = saldo * -1
                                        End If
                                        total = total + saldo
                                        If total < 0 Then
                                            total = total * -1
                                        End If
                                    Else
                                        total = cDataReader.Item("SALDO_ACTUAL")
                                    End If
                                    SInicial = cDataReader.Item("S_INICIAL")
                                    total = total - SInicial
                                End If


                            End If
                        Else
                            If EsSuma Then
                                If sCampo2 = "VARIACION" Then
                                    total = total + cDataReader.Item(sCampo2)
                                ElseIf sCampo = "ANTERIOR" Then
                                    total = total + cDataReader.Item("S_ULTIMO_PERIODO")
                                ElseIf sCampo = "ACTUAL" Then
                                    total = total + cDataReader.Item("SALDO_ACTUAL")
                                End If
                            Else
                                If sCampo2 = "VARIACION" Then
                                    total = cDataReader.Item(sCampo2)
                                End If
                                If sCampo = "GASTOS_INGRESOS" Then
                                    If sCampo2 = "ACTUAL" Then
                                        If bPasa Then
                                            saldo = cDataReader.Item("SALDO_ACTUAL")
                                            bPasa = False
                                        Else
                                            sActual = cDataReader.Item("SALDO_ACTUAL")
                                        End If
                                        If bPasa = False Then
                                            saldo = Math.Abs(saldo)
                                            sActual = Math.Abs(sActual)
                                            total = saldo - sActual
                                        End If
                                    Else
                                        If bPasa Then
                                            saldo = cDataReader.Item("S_ULTIMO_PERIODO")
                                            bPasa = False
                                        Else
                                            sActual = cDataReader.Item("S_ULTIMO_PERIODO")
                                        End If
                                        If bPasa = False Then
                                            saldo = Math.Abs(saldo)
                                            sActual = Math.Abs(sActual)
                                            total = saldo - sActual
                                        End If
                                    End If
                                End If
                            End If
                            If total < 0 And EsSuma = True And sNivel <> 25 And sNivel <> 17 And sNivel <> 18 And sCve_Cuenta <> "3.2.2.0.0" Then
                                total = total * -1
                            End If
                        End If
                    Else
                        If sCampo2 = "ACTUAL" Then
                            If sNivel = 1 Then
                                If EsSuma Then
                                    total = total + cDataReader.Item("SALDO_ACTUAL")
                                End If
                            Else
                                If EsSuma Then
                                    If bPasa Then
                                        Ingresos = cDataReader.Item("SALDO_ACTUAL")
                                        bPasa = False
                                    Else
                                        Gastos = cDataReader.Item("SALDO_ACTUAL")
                                    End If

                                    total = Ingresos - Gastos
                                Else
                                    total = cDataReader.Item("SALDO_ACTUAL")
                                End If
                            End If
                        Else
                            If sNivel = 1 Then
                                If EsSuma Then
                                    total = total + cDataReader.Item("S_ULTIMO_PERIODO")
                                End If
                            Else
                                If EsSuma Then
                                    If bPasa Then
                                        Ingresos = cDataReader.Item("S_ULTIMO_PERIODO")
                                        bPasa = False
                                    Else
                                        Gastos = cDataReader.Item("S_ULTIMO_PERIODO")
                                    End If

                                    total = Ingresos - Gastos
                                Else
                                    total = cDataReader.Item("S_ULTIMO_PERIODO")
                                End If
                            End If
                        End If
                    End If
                End While
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()
        End Try
        Return total
    End Function

    Public Function fDevuelve_Saldo_Cuenta_Contable_Hacie_Publ(ByVal sCve_Cuenta As String, ByVal EsSuma As Boolean, ByVal F_Inicio As String, ByVal F_Fin As String, Optional ByVal sCampo As String = "") As Double
        Dim total As Double
        Dim bPasa As Boolean = True
        Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            cCommand = New SqlClient.SqlCommand("pESTADOS_FINANCIEROS_B", cConnect)
            cCommand.CommandType = CommandType.StoredProcedure
            cCommand.Parameters.AddWithValue("@CUENTAS", sCve_Cuenta)
            cCommand.Parameters.AddWithValue("@FECHA_INICIO", F_Inicio)
            cCommand.Parameters.AddWithValue("@FECHA_FIN", F_Fin)
            cCommand.Parameters.AddWithValue("@EJERCICIO", Trim(Application.Current.Session("A_EJERCICIO")))
            cCommand.Parameters.AddWithValue("@MOSTRAR_CIERRE", 1)

            If Application.Current.Session("CVE_FUENTE_FINANCIAMIENTO") <> Nothing Then
                cCommand.Parameters.AddWithValue("@CVE_FUENTE_FINANCIAMIENTO", Application.Current.Session("CVE_FUENTE_FINANCIAMIENTO"))
            End If
            cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While (cDataReader.Read)
                    total = cDataReader.Item(sCampo)
                End While
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()
        End Try
        Return total
    End Function
    Public Function fDevuelve_Patrimonio(ByVal sCve_Cuenta As String, ByVal F_Inicio As String, ByVal F_Fin As String, ByVal sCampo As String, ByVal bEsSuma As Boolean, Optional ByVal sCampo2 As String = "", Optional ByVal nEjercicio As Integer = 0, Optional bMostrar_cierre As Boolean = False) As Double
        Dim total, gastos, Ingresos As Double
        Dim BPASO As Boolean = True
        Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            'cCommand = New SqlClient.SqlCommand("pESTADOS_FINANCIEROS_B", cConnect)

            cCommand = New SqlClient.SqlCommand("pESTADO_VARIACION_B", cConnect)
            cCommand.CommandType = CommandType.StoredProcedure
            cCommand.Parameters.AddWithValue("@CUENTAS", sCve_Cuenta)
            cCommand.Parameters.AddWithValue("@FECHA_INICIO", F_Inicio)
            cCommand.Parameters.AddWithValue("@FECHA_FIN", F_Fin)
            cCommand.Parameters.AddWithValue("@EJERCICIO", nEjercicio)
            'cCommand.Parameters.AddWithValue("@FECHA_INICIO_ANTERIOR", F_Inicio_Anterior)
            'cCommand.Parameters.AddWithValue("@FECHA_FIN_ANTERIOR", F_Fin_Anterior)
            cCommand.Parameters.AddWithValue("@MOSTRAR_CIERRE", bMostrar_cierre)

            If Application.Current.Session("CVE_FUENTE_FINANCIAMIENTO") <> Nothing Then
                cCommand.Parameters.AddWithValue("@CVE_FUENTE_FINANCIAMIENTO", Application.Current.Session("CVE_FUENTE_FINANCIAMIENTO"))
            End If
            cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While (cDataReader.Read)
                    If sCampo = "VARIACION" Then
                        If BPASO Then
                            gastos = cDataReader.Item(sCampo)
                            BPASO = False
                        Else
                            Ingresos = cDataReader.Item(sCampo)
                        End If
                        total = gastos - Ingresos
                    ElseIf sCampo = "GASTOS_INGRESOS" Then
                        If BPASO Then
                            gastos = cDataReader.Item(sCampo2)
                            BPASO = False
                        Else
                            Ingresos = cDataReader.Item(sCampo2)
                        End If
                        total = gastos - Ingresos
                    Else
                        If bEsSuma Then
                            total = total + cDataReader.Item(sCampo)
                        Else
                            total = cDataReader.Item(sCampo)
                        End If
                    End If
                End While
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()
        End Try
        Return total
    End Function
    Sub LimpiarChildren(ByVal cControlX As Object, ByVal ErrorProviderX As ErrorProvider)
        Dim cControl As Object
        Try



            If UCase(TypeName(cControlX)) <> "DATETIMEPICKERSAX" Then



                For Each cControl In cControlX.Controls
                    Select Case UCase(TypeName(cControl))
                        Case "DATETIMEPICKER"
                            Dim cCalendarCombo As Wisej.Web.DateTimePicker
                            cCalendarCombo = cControl
                            cCalendarCombo.Value = Now
                            cCalendarCombo.Checked = False
                            ErrorProviderX.SetError(cCalendarCombo, Nothing)

                        Case "CHECKBOX"
                            Dim cControlUICheckBox As Wisej.Web.CheckBox
                            cControlUICheckBox = cControl
                            cControlUICheckBox.Checked = False
                            ErrorProviderX.SetError(cControlUICheckBox, Nothing)
                        Case "COMBOBOX"
                            Dim cControlUIComboBox As Wisej.Web.ComboBox
                            cControlUIComboBox = cControl
                            If cControlUIComboBox.Tag = Nothing Then
                                If cControlUIComboBox.Items.Count <> 0 Then
                                    cControlUIComboBox.SelectedIndex = -1
                                End If

                                ErrorProviderX.SetError(cControlUIComboBox, Nothing)
                            End If
    'cControlUIComboBox.SelectedValue = Nothing
                        Case "NUMERICUPDOWN"
                            cControl.VALUE = 0
                            ErrorProviderX.SetError(cControl, Nothing)
                        Case "TEXTBOX", "MASKEDTEXTBOX"
                            cControl.Text = Nothing
                            ErrorProviderX.SetError(cControl, Nothing)
                    End Select
                    If cControl.HasChildren Then
                        LimpiarChildren(cControl, ErrorProviderX)
                    End If
                Next
            End If
        Catch ex As SystemException
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Sub buscarfocusChildren(ByVal cControlX As Object, ByVal nombre As String, ByVal descripcion As String, ByVal clave As String)
        Dim cControl As Object
        Try
            For Each cControl In cControlX.Controls
                Select Case UCase(TypeName(cControl))


                    Case "TEXTBOX", "MASKEDTEXTBOX"
                        If nombre = cControl.Name Then
                            cControl.Text = descripcion
                            cControl.tag = clave
                            Exit Sub
                        End If
                End Select
                If cControl.HasChildren Then
                    buscarfocusChildren(cControl, nombre, descripcion, clave)
                End If
            Next
        Catch ex As SystemException
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Sub ConsultarChildren(ByVal cControlX As Object, ByVal DReader As Data.SqlClient.SqlDataReader)
        Dim cControl As Object
        Dim sDatafield As String
        Try

            For Each cControl In cControlX.Controls
                sDatafield = ""
                Select Case UCase(TypeName(cControl))
                    Case "TEXTBOX", "CALENDARCOMBO", "NUMERICUPDOWN", "COMBOBOX", "DATETIMEPICKER", "MASKEDTEXTBOX"
                        If Trim(cControl.Tag) <> Nothing Then
                            If InStr(cControl.Tag, "/NA") = 0 Then
                                sDatafield = Mid(cControl.Tag, 1, InStr(cControl.Tag, "/") - 1)
                            Else
                                sDatafield = Mid(cControl.Tag, 1, InStr(cControl.Tag, "/NA") - 1)
                            End If
                        End If
                    Case Else
                        sDatafield = ""
                End Select

                If Trim(sDatafield) <> Nothing Then
                    Select Case UCase(TypeName(cControl))

                        Case "COMBOBOX"
                            If Trim("" & DReader.Item(sDatafield)) <> Nothing Then
                                cControl.SelectedValue = DReader.Item(sDatafield)
                            Else
                                cControl.SelectedIndex = -1
                            End If

    'Dim cControlUiCombobox As Wisej.Web.ComboBox
    'cControlUiCombobox = cControl
    'If cControlUiCombobox.DropDownStyle = ComboBoxStyle.DropDownList Then
    '    If InStr(1, cControlUiCombobox.Tag, "/1") Then
    '        If cControlUiCombobox.SelectedIndex = -1 Then

    '        Else
    '        End If
    '    End If
    'Else
    '    If InStr(1, cControlUiCombobox.Tag, "/1") Then
    '    Else
    '    End If
    'End If

                        Case "TEXTBOX", "MASKEDTEXTBOX"
                            cControl.Text = "" & DReader.Item(sDatafield)
    'If InStr(1, cControl.Tag, "/1") Then
    'Else
    'End If

                        Case "NUMERICUPDOWN"
                            cControl.Value = DReader.Item(sDatafield)
    'Dim cControlNumericEditBox As Wisej.Web.NumericUpDown
    'cControlNumericEditBox = cControl

    'If InStr(1, cControlNumericEditBox.Tag, "/1") Then
    'Else
    'End If

                        Case "DATETIMEPICKER"
                            'Dim cCalendarCombo As Wisej.Web.DateTimePicker
                            'cCalendarCombo.v
                            'cCalendarCombo = cControl
                            cControl.Value = DReader.Item(sDatafield)
                    End Select
                End If

                If cControl.HasChildren Then
                    ConsultarChildren(cControl, DReader)
                End If
            Next
        Catch ex As SystemException
            'Messagebox.show("Error: " & ex.Message,ofunciones.MessageBoxStyle.Exclamation, "SISCOL.net" & Space(2) & Application.ProductVersion)
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'If cControlX Is Nothing = False Then cControlX.Enabled = True
            Exit Sub
        End Try
    End Sub
    Function sDevolver_Descripcion(ByVal sCve As String, ByVal sAno As String, ByVal sCve_Operador As String, ByVal cControl As Object) As String
        Dim sDevuelve As String
        If Trim(sCve) = Nothing Then
            sDevuelve = "[SELECCIONE]"
        Else
            ReDim ParametersX_Global(3)
            ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Proyecto", sCve)
            ParametersX_Global(1) = New SqlClient.SqlParameter("@Ano_Ejercicio", sAno)
            If Trim(sCve_Operador) <> Nothing Then
                ParametersX_Global(2) = New SqlClient.SqlParameter("@Cve_Operador_Obtener_Cedulas", sCve_Operador)
            End If
            ParametersX_Global(3) = New SqlClient.SqlParameter("@PassphraseEnteredByUser", sConstante_KEY)
            sDevuelve = fGuardar_O_EliminarXProcedure_DevuelveId("pCEDULA_DEVUELVE_NOMBRE_PROYECTO", "@PARAMETRO", ParametersX_Global, , SqlDbType.VarChar, 250)
            If Trim(sDevuelve) = Nothing Then
                sDevuelve = "[SELECCIONE]"
                cControl.text = Nothing
            End If
        End If
        Return (sDevuelve)
    End Function
    Function obTener_Descripcion2(ByVal cControl As combosax, Optional ByVal sColumnaName As String = "Descripcion", Optional ByVal sColumnaWHERE As String = Nothing, Optional ByVal WHERE As String = Nothing) As Object
        Dim SWHERE As String
        If cControl.SelectedIndex = -1 Then
            Return Nothing
        Else
            SWHERE = cControl.list_llenado.ValueMember & "='" & cControl.SelectedValue & "'"
            If sColumnaWHERE <> Nothing Then
                SWHERE = SWHERE + " AND " + sColumnaWHERE & "='" & WHERE & "'"
            End If
            Dim defaultV = cControl.DataSource.Tables(0).DefaultView
            defaultV.RowFilter = SWHERE

            Dim objDT = defaultV.ToTable()
            If objDT.Rows.Count <> 0 And sColumnaName <> "" Then

                Return objDT.Rows.Item(0).Item(sColumnaName)
            Else
                Return Nothing

            End If
        End If
    End Function

    '''''''''''''''''''''''''''''''''''''''''
    ' ______                                '
    ' |  ____|                              '
    ' | |__   _ __ _ __ ___  _ __ ___  ___  '
    ' |  __| | '__| '__/ _ \| '__/ _ \/ __| '
    ' | |____| |  | | | (_) | | |  __/\__ \ '
    ' |______|_|  |_|  \___/|_|  \___||___/ '
    '                                       '
    '''''''''''''''''''''''''''''''''''''''''
    'ComboGridSax no definido

    'Function obTener_Descripcion_ComboGridSax(ByVal cControl As ComboGridSax, Optional ByVal sColumnaName As String = "Descripcion", Optional ByVal sColumnaWHERE As String = Nothing, Optional ByVal WHERE As String = Nothing) As Object
    '    Dim SWHERE As String
    '    If cControl.SelectedIndex = -1 Then
    '        Return Nothing
    '    Else
    '        SWHERE = cControl.SelectedValue_DEFAULT & "='" & cControl.SelectedValue & "'"
    '        If sColumnaWHERE <> Nothing Then
    '            SWHERE = SWHERE + " AND " + sColumnaWHERE & "='" & WHERE & "'"
    '        End If
    '        Dim defaultV = cControl.DataSource.DefaultView
    '        defaultV.RowFilter = SWHERE

    '        Dim objDT = defaultV.ToTable()
    '        If objDT.Rows.Count <> 0 And sColumnaName <> "" Then

    '            Return objDT.Rows.Item(0).Item(sColumnaName)
    '        Else
    '            Return Nothing

    '        End If
    '    End If
    'End Function
    Function obTener_Descripcion3(ByVal cControl As combosax, Optional ByVal sColumnaName As String = "Descripcion", Optional ByVal sColumnaWHERE As String = Nothing, Optional ByVal WHERE As String = Nothing) As String
        Dim SWHERE As String

        SWHERE = cControl.list_llenado.ValueMember & "='" & cControl.SelectedValue & "'"
        If sColumnaWHERE <> Nothing Then
            SWHERE = SWHERE + " AND " + sColumnaWHERE & "='" & WHERE & "'"
        End If

        Dim defaultV = cControl.DataSource.Tables(0).DefaultView
        defaultV.RowFilter = SWHERE

        Dim objDT = defaultV.ToTable()
        If objDT.Rows.Count <> 0 And sColumnaName <> "" Then
            Return objDT.Rows.Item(0).Item(sColumnaName).ToString()
        Else
            Return Nothing

        End If

    End Function
    Function obTener_Descripcion(ByVal cControl As Object, Optional ByVal sColumnaName As String = "Descripcion") As Object
        If cControl.SelectedIndex = -1 Then
            Return Nothing
        Else
            Dim dt As DataTable = DirectCast(cControl.DataSource, DataTable)
            Return dt.Rows.Item(cControl.SelectedIndex).Item(sColumnaName).ToString()
        End If
    End Function
    Function Existe_Registro(ByVal sCve As String, ByVal sColumnName As String, ByVal Grid As Wisej.Web.DataGridView) As Boolean
        If Grid.RowCount > 0 Then
            For i As Integer = 0 To Grid.RowCount - 1
                If Grid.Item(sColumnName, i).Value.ToString = sCve Then
                    Return True
                End If
            Next
        End If
        Return False
    End Function
    Public Function Login(ByVal UserName As String, ByVal Password As String) As Boolean
        ' Dim ParametersX() As System.Data.SqlClient.SqlParameter
        Try

            ' cData.Conectar()
            '    Conectar()
            If Connect() Then
                'ErrorsClear()

                ReDim ParametersX_Global(2)
                ParametersX_Global(0) = New Data.SqlClient.SqlParameter("@Cve_Operador", UserName)
                ParametersX_Global(1) = New Data.SqlClient.SqlParameter("@Contrasena", Password)
                ParametersX_Global(2) = New Data.SqlClient.SqlParameter("@PassphraseEnteredByUser", sConstante_KEY)

                If fGuardar_O_EliminarXProcedure("pLOGIN", "@Parametro", ParametersX_Global, False) Then
                    Login = True
                Else
                    Login = False
                End If
            Else
                Login = False
                '_Errors = "No se pudo conectar con la base de datos."
                'MessageBox.Show("No se pudo conectar con la base de datos.")
            End If
        Catch ex As Exception
            Login = False
            '_Errors = ex.Message
            '         MessageBox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Sub ErrorLlenarCatalogos(ByVal sCatalogoDescripcion As String)
        MessageBox.Show("Advertencia: Llenar los catalogos de " & sCatalogoDescripcion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Sub Guardar_Bitacora(ByVal sUsuario As String, ByVal sOperacion As String, ByVal sGetIP As String)
        ReDim ParametersX_Global(3)
        ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Operador", sUsuario)
        ParametersX_Global(1) = New SqlClient.SqlParameter("@Operacion", sOperacion)
        ParametersX_Global(2) = New SqlClient.SqlParameter("@Direccion_IP", sGetIP)
        If fGuardar_O_EliminarXProcedure("pBITACORA_ACCESO_SISTEMA_G", "@Parametro", ParametersX_Global) Then
        End If
    End Sub
    Sub Enviar_Mensaje_Soporte(ByVal sUsuario As String, ByVal sGetIP As String, ByVal cMensaje_Textbox As TextBox)
        ReDim ParametersX_Global(3)
        ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Operador", sUsuario)
        ParametersX_Global(1) = New SqlClient.SqlParameter("@Direccion_IP", sGetIP)
        ParametersX_Global(2) = New SqlClient.SqlParameter("@Mensaje", cMensaje_Textbox.Text)
        If fGuardar_O_EliminarXProcedure("pMENSAJES_SOPORTE_G", "@Parametro", ParametersX_Global) Then
            cMensaje_Textbox.Text = Nothing
            MessageBox.Show("Enviado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Sub Bitacora_Operaciones(ByVal sTipo_Bitacora As String, ByVal Operacion As String, ByVal sParametros As String)
        Dim bPaso As Boolean
        Select Case sTipo_Bitacora
            Case "CATALOGO CUENTAS CONTABLES"
                ReDim ParametersX_Global(2)
                ParametersX_Global(0) = New SqlParameter("@OPERACION", Operacion)
                ParametersX_Global(1) = New SqlParameter("@PROCEDURE_PARAMETROS", sParametros)
                ParametersX_Global(2) = New SqlParameter("@CVE_OPERADOR", Application.Current.Session("Cve_Operador"))
                bPaso = fGuardar_O_EliminarXProcedure("pCAT_CUENTAS_CONTABLES_BITACORA_G", "@PARAMETRO", ParametersX_Global)

        End Select

        If Not bPaso Then
            MessageBox.Show("Verificar con el administrador")
        End If
    End Sub
    'SuubFunction sDevolver_Seleccionados_Checkbox(ByVal sCve_Campo As String, ByVal oDataGrid As Wisej.Web.DataGridView, ByVal sName_Column_Chk As String, Optional ByVal Snombre_columna As String = "")
    '    Dim sId_Seleccionado As String = Nothing
    '    Dim sId_Individual, matriz As String()
    '    Dim CONT, z, nduplicado As Integer
    '    Dim cadena As String
    '    Dim inicio As Boolean = True
    '    For i = 0 To oDataGrid.RowCount - 1

    '        If oDataGrid.Columns.Contains(sName_Column_Chk) Then
    '            If oDataGrid.Item(oDataGrid.Columns(sName_Column_Chk).Index, i).Value = True And oDataGrid.Item(oDataGrid.Columns(Snombre_columna).Index, i).Value = "" Then
    '                If inicio = True Then
    '                    sId_Seleccionado = sId_Seleccionado & oDataGrid.Item(sCve_Campo, i).Value
    '                    inicio = False
    '                Else
    '                    sId_Seleccionado = sId_Seleccionado & "," & oDataGrid.Item(sCve_Campo, i).Value
    '                End If

    '            End If
    '        End If

    '    Next
    '    If sId_Seleccionado <> Nothing Then
    '        sId_Individual = sId_Seleccionado.Split(",")
    '        CONT = sId_Individual.Length
    '        Dim TempArray() As String
    '        For i = LBound(sId_Individual) To UBound(sId_Individual)
    '            'Redimensionamos el Array temporal y preservamos el valor  
    '            ReDim Preserve TempArray(i)
    '            'Asignamos al array temporal el valor del otro array  
    '            TempArray(i) = sId_Individual(i)
    '        Next


    '        For X = 0 To UBound(sId_Individual)
    '            z = 0

    '            For y = 0 To UBound(sId_Individual)
    '                'Si el elemento del array es igual al array temporal  
    '                If sId_Individual(X) = TempArray(z) And y <> X Then
    '                    'Entonces Eliminamos el valor duplicado  
    '                    sId_Individual(y) = ""
    '                    nduplicado = nduplicado + 1
    '                End If
    '                z = z + 1
    '            Next y
    '        Next X
    '        For Each Elemento In sId_Individual
    '            'Si el elemento es distinto de una cadena vacia  
    '            'lo agegamos al List1  
    '            If Elemento <> "" Then cadena += Elemento & ","
    '        Next

    '        'For i = 0 To CONT - 1
    '        '    For y = 0 To CONT - 1
    '        '        If sId_Individual(i) = sId_Individual(y) Then

    '        '        End If
    '        '    Next
    '        'Next
    '    End If
    '    If Trim(cadena) = Nothing Then cadena = Nothing
    '    Return cadena
    'End Function
    'Function sDevolver_Seleccionados(ByVal cObjChecked As eSAXSOFTWeb.Controls.CheckedComboBox)
    '    Dim sId_Seleccionado As String
    '    ''For i = 0 To oDataGrid.RowCount - 1
    '    ''    If oDataGrid.Item("DataGridSelecciono", i).Value = True Then
    '    ''        sId_Seleccionado = sId_Seleccionado & oDataGrid.Item(sCve_Campo, i).Value & ","
    '    ''    End If
    '    ''Next

    '    ''If Trim(sId_Seleccionado) = Nothing Then sId_Seleccionado = "-99"
    '    ''Return sId_Seleccionado

    '    If cObjChecked.GetCheckedComboView.CheckedItems.Count > 0 Then

    '        For Each indexChecked As Integer In cObjChecked.GetCheckedComboView.CheckedIndices
    '            Dim item As MyComboitem
    '            item = DirectCast(cObjChecked.GetCheckedComboView.Items(indexChecked), MyComboitem)

    '            sId_Seleccionado = sId_Seleccionado & item.ID & ","
    '        Next
    '    End If

    '    If Trim(sId_Seleccionado) = Nothing Then sId_Seleccionado = "-99"
    '    Return sId_Seleccionado
    'End Function
    Function pQuery(ByVal sCampo As String, ByVal sTipoDato As String, Optional ByVal sWhere As String = Nothing) As String

        If sWhere = Nothing Then
            Return Nothing
        End If


        Dim sTokens_Inicial As String = "'%"
        Dim sTokens_Final As String = "%'"
        Dim sOperacion = " Like "


        If sTipoDato = "NUMERICO" Then
            sTokens_Inicial = Nothing
            sTokens_Final = Nothing
            sOperacion = " = "
            If IsNumeric(sWhere) = False Then
                sWhere = Val(sWhere)
            End If
        End If

        If Trim(sWhere) <> Nothing Then
            sWhere = sCampo & sOperacion & sTokens_Inicial & sWhere & sTokens_Final
        End If

        Return sWhere
    End Function
    Sub PopularMenuCuentas(ByVal ObjTreeView As Wisej.Web.TreeView, ByVal sCve_Rol As String, Optional ByVal sModulo As String = Nothing, Optional ByVal sSubModulo As String = Nothing)
        Dim sCve_Acceso_Padre As String
        Dim nodeRoot, nodeModulos, nodeSubModulos, nNode_SubPadre, nodeSINModulos, nNode_SubPadre4, nodeSubModulos4, nodeSubModulos5, nodeSubModulos6, nodeSubModulos7 As TreeNode

        Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            cCommand = New SqlClient.SqlCommand("pESTADOS_FINANCIEROS_B", cConnect)
            cCommand.CommandType = CommandType.StoredProcedure

            'If sModulo <> Nothing Then
            '    cCommand.Parameters.AddWithValue("@Modulo", sModulo)
            'End If
            'If sSubModulo <> Nothing Then
            '    cCommand.Parameters.AddWithValue("@SubModulo", sSubModulo)
            'End If

            'cCommand.Parameters.AddWithValue("@Cve_Rol", sCve_Rol)
            cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While (cDataReader.Read)
                    If cDataReader.Item("Nivel") = "1" Then
                        'sCve_Acceso_Padre = cDataReader.Item("Cve_Acceso_Padre")
                        nodeModulos = New TreeNode
                        nodeModulos.Text = cDataReader.Item("COD_CUENTA") & " (" & cDataReader.Item("COD_CUENTA_PADRE") & ")" _
& " (" & cDataReader.Item("ABONABLE") & ")"

                        nodeModulos.Name = "" & cDataReader.Item("COD_CUENTA")


                        ObjTreeView.Nodes.Add(nodeModulos)
                        '        sCve_Acceso_Padre = cDataReader.Item("Cve_Acceso_Padre")
                        'If cDataReader.Item("BOTON") = "B" Then
                        '    nodeModulos.Visible = False
                        'End If
                    Else
                        If cDataReader.Item("Nivel") = "2" Then
                            nNode_SubPadre = New TreeNode

                            nNode_SubPadre.Text = cDataReader.Item("COD_CUENTA") & " (" & cDataReader.Item("COD_CUENTA_PADRE") & ")" _
& " (" & cDataReader.Item("ABONABLE") & ")"
                            nNode_SubPadre.Name = "" & cDataReader.Item("COD_CUENTA")

                            If nodeModulos Is Nothing Then
                                ObjTreeView.Nodes.Add(nNode_SubPadre)
                            Else
                                nodeModulos.Nodes.Add(nNode_SubPadre)
                            End If

                        ElseIf cDataReader.Item("Nivel") = "3" Then
                            nodeSubModulos = New TreeNode
                            nodeSubModulos.Text = cDataReader.Item("COD_CUENTA") & " (" & cDataReader.Item("COD_CUENTA_PADRE") & ")" _
& " (" & cDataReader.Item("ABONABLE") & ")"
                            nodeSubModulos.Name = "" & cDataReader.Item("COD_CUENTA")



                            If nNode_SubPadre Is Nothing Then
                                If nodeSINModulos Is Nothing Then
                                    ObjTreeView.Nodes.Add(nodeSubModulos)
                                Else
                                    nodeSINModulos.Nodes.Add(nodeSubModulos)
                                End If
                            Else
                                nNode_SubPadre.Nodes.Add(nodeSubModulos)
                            End If
                        ElseIf cDataReader.Item("Nivel") = "4" Then
                            nodeSubModulos4 = New TreeNode
                            nodeSubModulos4.Text = cDataReader.Item("COD_CUENTA") & " (" & cDataReader.Item("COD_CUENTA_PADRE") & ")" _
& " (" & cDataReader.Item("ABONABLE") & ")"
                            nodeSubModulos4.Name = "" & cDataReader.Item("COD_CUENTA")



                            If nodeSubModulos Is Nothing Then
                                If nodeSINModulos Is Nothing Then
                                    ObjTreeView.Nodes.Add(nodeSubModulos4)
                                Else
                                    nodeSINModulos.Nodes.Add(nodeSubModulos4)
                                End If
                            Else
                                nodeSubModulos.Nodes.Add(nodeSubModulos4)
                            End If

                        ElseIf cDataReader.Item("Nivel") = "5" Then
                            nodeSubModulos5 = New TreeNode
                            nodeSubModulos5.Text = cDataReader.Item("COD_CUENTA") & " (" & cDataReader.Item("COD_CUENTA_PADRE") & ")" _
& " (" & cDataReader.Item("ABONABLE") & ")"
                            nodeSubModulos5.Name = "" & cDataReader.Item("COD_CUENTA")



                            If nodeSubModulos4 Is Nothing Then
                                If nodeSINModulos Is Nothing Then
                                    ObjTreeView.Nodes.Add(nodeSubModulos5)
                                Else
                                    nodeSINModulos.Nodes.Add(nodeSubModulos5)
                                End If
                            Else
                                nodeSubModulos4.Nodes.Add(nodeSubModulos5)
                            End If

                        ElseIf cDataReader.Item("Nivel") = "6" Then
                            nodeSubModulos6 = New TreeNode
                            nodeSubModulos6.Text = cDataReader.Item("COD_CUENTA") & " (" & cDataReader.Item("COD_CUENTA_PADRE") & ")" _
& " (" & cDataReader.Item("ABONABLE") & ")"
                            nodeSubModulos6.Name = "" & cDataReader.Item("COD_CUENTA")



                            If nodeSubModulos5 Is Nothing Then
                                If nodeSINModulos Is Nothing Then
                                    ObjTreeView.Nodes.Add(nodeSubModulos6)
                                Else
                                    nodeSINModulos.Nodes.Add(nodeSubModulos6)
                                End If
                            Else
                                nodeSubModulos5.Nodes.Add(nodeSubModulos6)
                            End If
                        ElseIf cDataReader.Item("Nivel") = "7" Then
                            nodeSubModulos7 = New TreeNode
                            nodeSubModulos7.Text = cDataReader.Item("COD_CUENTA") & " (" & cDataReader.Item("COD_CUENTA_PADRE") & ")" _
& " (" & cDataReader.Item("ABONABLE") & ")"
                            nodeSubModulos7.Name = "" & cDataReader.Item("COD_CUENTA")



                            If nodeSubModulos6 Is Nothing Then
                                If nodeSINModulos Is Nothing Then
                                    ObjTreeView.Nodes.Add(nodeSubModulos7)
                                Else
                                    nodeSINModulos.Nodes.Add(nodeSubModulos7)
                                End If
                            Else
                                nodeSubModulos6.Nodes.Add(nodeSubModulos7)
                            End If

                        Else
                            nodeSINModulos = New TreeNode
                            nodeSINModulos.Text = cDataReader.Item("COD_CUENTA") & " (" & cDataReader.Item("COD_CUENTA_PADRE") & ")" _
& " (" & cDataReader.Item("ABONABLE") & ")"
                            nodeSINModulos.Name = "" & cDataReader.Item("COD_CUENTA")

                            If nodeModulos Is Nothing Then
                                ObjTreeView.Nodes.Add(nodeSINModulos)
                            Else
                                nodeModulos.Nodes.Add(nodeSINModulos)
                            End If
                        End If
                    End If

                    '----------------------------------------
                End While
                ObjTreeView.ExpandAll()
            End If
        Catch ex As SystemException
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()
        End Try
    End Sub


    Sub PopularMenu(ByVal ObjTreeView As Wisej.Web.TreeView, ByVal sCve_Rol As String, Optional ByVal sModulo As String = Nothing, Optional ByVal sSubModulo As String = Nothing)
        Dim sCve_Acceso_Padre As String
        Dim nodeRoot, nodeModulos, nodeSubModulos, nNode_SubPadre, nodeSINModulos As TreeNode

        Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            cCommand = New SqlClient.SqlCommand("pACCESOS_MODULOS_B", cConnect)
            cCommand.CommandType = CommandType.StoredProcedure

            If sModulo <> Nothing Then
                cCommand.Parameters.AddWithValue("@Modulo", sModulo)
            End If
            If sSubModulo <> Nothing Then
                cCommand.Parameters.AddWithValue("@SubModulo", sSubModulo)
            End If

            cCommand.Parameters.AddWithValue("@Cve_Rol", sCve_Rol)
            cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While (cDataReader.Read)
                    If cDataReader.Item("Tipo") = "MODULO" Then
                        'sCve_Acceso_Padre = cDataReader.Item("Cve_Acceso_Padre")
                        nodeModulos = New TreeNode
                        nodeModulos.Text = cDataReader.Item("Descripcion")
                        nodeModulos.Tag = "" & cDataReader.Item("Cve_Acceso")
                        nodeModulos.Name = "" & cDataReader.Item("Tipo")
                        nodeModulos.CheckBox = True
                        nodeModulos.Checked = cDataReader.Item("Seleccionado")

                        ObjTreeView.Nodes.Add(nodeModulos)
                        '        sCve_Acceso_Padre = cDataReader.Item("Cve_Acceso_Padre")
                        'If cDataReader.Item("BOTON") = "B" Then
                        '    nodeModulos.Visible = False
                        'End If
                    Else
                        If cDataReader.Item("BOTON") = "C" Then
                            nNode_SubPadre = New TreeNode
                            nNode_SubPadre.Text = cDataReader.Item("descripcion")
                            nNode_SubPadre.Tag = "" & cDataReader.Item("Cve_Acceso")
                            nNode_SubPadre.Name = "" & cDataReader.Item("BOTON")
                            If Trim("" & cDataReader.Item("Icono")) <> Nothing Then
                                'nNode_SubPadre.Image = New ImageResourceHandle(cDataReader.Item("Icono"))
                            End If
                            nNode_SubPadre.Checked = cDataReader.Item("Seleccionado")
                            If nodeModulos Is Nothing Then
                                ObjTreeView.Nodes.Add(nNode_SubPadre)
                            Else
                                nodeModulos.Nodes.Add(nNode_SubPadre)
                            End If
                        ElseIf cDataReader.Item("BOTON") = "SC" Then
                            nodeSubModulos = New TreeNode
                            nodeSubModulos.Text = cDataReader.Item("descripcion")
                            nodeSubModulos.Tag = "" & cDataReader.Item("Cve_Acceso")
                            nodeSubModulos.Name = "" & cDataReader.Item("BOTON")
                            If Trim("" & cDataReader.Item("Icono")) <> Nothing Then
                                'nodeSubModulos.Image = New ImageResourceHandle(cDataReader.Item("Icono"))
                            End If
                            nodeSubModulos.Checked = cDataReader.Item("Seleccionado")
                            If nNode_SubPadre Is Nothing Then
                                If nodeSINModulos Is Nothing Then
                                    ObjTreeView.Nodes.Add(nodeSubModulos)
                                Else
                                    nodeSINModulos.Nodes.Add(nodeSubModulos)
                                End If
                            Else
                                nNode_SubPadre.Nodes.Add(nodeSubModulos)
                            End If
                        Else
                            nodeSINModulos = New TreeNode
                            nodeSINModulos.Text = cDataReader.Item("descripcion")
                            nodeSINModulos.Tag = "" & cDataReader.Item("Cve_Acceso")
                            If Trim("" & cDataReader.Item("Icono")) <> Nothing And cDataReader.Item("BOTON") <> "B" Then
                                'nodeSINModulos.Image = New ImageResourceHandle(cDataReader.Item("Icono"))
                            End If
                            nodeSINModulos.Name = "SI"
                            nodeSINModulos.Checked = cDataReader.Item("Seleccionado")
                            'nodeModulos.Nodes.Add(nodeSINModulos)
                            If nodeModulos Is Nothing Then
                                ObjTreeView.Nodes.Add(nodeSINModulos)
                            Else
                                nodeModulos.Nodes.Add(nodeSINModulos)
                            End If
                        End If
                    End If

                    '----------------------------------------
                End While
                ObjTreeView.ExpandAll()
            End If
        Catch ex As SystemException
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()
        End Try
    End Sub
    Sub Obtener_columnas(ByVal cCombobox As Wisej.Web.ComboBox, ByVal cGrid As Wisej.Web.DataGridView)
        Dim i As Integer
        cCombobox.Items.Clear()

        For i = 0 To cGrid.ColumnCount - 1
            If cGrid.Columns(i).Visible Then
                If cGrid.Columns(i).IsDataBound Then
                    Dim ivp As New ComboFiltro
                    ivp.text = cGrid.Columns(i).HeaderText  'IIf(Trim(cGrid.Columns(I).DataPropertyName) = Nothing, cGrid.Columns(I).HeaderText, cGrid.Columns(I).Tag)
                    If cGrid.Columns(i).ValueType.FullName = "System.String" Then
                        ivp.Tipo_Dato = "STRING"
                    Else
                        ivp.Tipo_Dato = "NUMERICO"
                    End If
                    ivp.value = cGrid.Columns(i).DataPropertyName
                    cCombobox.Items.Add(ivp)
                End If
            End If
        Next

        If cCombobox.Items.Count > 0 Then cCombobox.SelectedIndex = 0
    End Sub
    Private Class ComboFiltro
        Public text As String
        Public value As String
        Public Tipo_Dato As String
        Public Overrides Function toString() As String
            Return text
        End Function
        Public Function toTipo_Dato() As String
            Return Tipo_Dato
        End Function
    End Class
    'Sub Consultar_o_Filtrar_En_Grilla(ByVal cCombobox As Wisej.Web.ComboBox, ByVal cTextbox As Wisej.Web.TextBox, ByVal cGrid As Wisej.Web.DataGridView, ByVal BindingSource As Wisej.Web.BindingSource)
    '    Dim sCampo, sWhere, sValor As String
    '    If cCombobox.SelectedIndex = -1 Then Exit Sub
    '    sCampo = cCombobox.SelectedItem.ToString
    '    sValor = cTextbox.Text.Trim
    '    sWhere = pQuery(sCampo, cCombobox.SelectedItem.value, sValor)

    '    BindingSource.Filter = sWhere
    '    cGrid.CurrentPage = 1
    'End Sub
    Sub Consultar_o_Filtrar_En_Grilla(ByVal cCombobox As Wisej.Web.ComboBox, ByVal cTextbox As Wisej.Web.TextBox, ByVal cGrid As Wisej.Web.DataGridView, ByVal BindingSource As Wisej.Web.BindingSource)
        Dim sCampo, sWhere, sTipo_Dato, sValor As String
        If cCombobox.SelectedIndex = -1 Then Exit Sub

        sTipo_Dato = cCombobox.SelectedItem.toTipo_Dato
        sCampo = cCombobox.SelectedItem.value
        sValor = cTextbox.Text.Trim

        sWhere = pQuery(sCampo, sTipo_Dato, sValor)

        BindingSource.Filter = sWhere
        'cGrid.CurrentPage = 1
    End Sub

    Sub Llenar_listbox(ByVal sNameProcedure As String, ByVal sId As String, ByVal sDescripcion As String, ByVal cControl As Object, Optional ByVal cParams() As SqlParameter = Nothing, Optional ByVal bEsText As Boolean = False)

        Dim parametros As String
        Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try

            parametros = sNameProcedure
            cCommand = New SqlClient.SqlCommand(sNameProcedure, cConnect)

            If bEsText Then
                'cCommand.CommandType = CommandType.Text
            Else
                'cCommand.CommandType = CommandType.StoredProcedure
                If cParams Is Nothing = False Then
                    parametros = sNameProcedure
                    Dim s As String = " "
                    For i = 0 To cParams.GetLength(0) - 1
                        If cParams(i) Is Nothing = False Then

                            If cParams(i).DbType = DbType.String Then
                                parametros += s & cParams(i).ParameterName & "='" & cParams(i).Value & "'"
                            ElseIf cParams(i).DbType = DbType.Boolean Then
                                parametros += s & cParams(i).ParameterName & "=" & Convert.ToInt32(cParams(i).Value)
                            Else
                                parametros += s & cParams(i).ParameterName & "=" & cParams(i).Value
                            End If
                            s = ", "
                        Else
                            X = X - 1
                            cCommand.Parameters.AddWithValue(cParams(i).ParameterName, cParams(i).Value)
                        End If
                        X = X + 1
                    Next


                End If
            End If

            cCommand.Prepare()
            cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            cControl.CLEAR()


            cControl.llenar_lis_nuevo(sId, sDescripcion, parametros, sConexion)

        Catch ex As SystemException
            Wisej.Web.MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()
        End Try
    End Sub
    Sub Llenar_CatalogosXprocedureYParams(ByVal sNameProcedure As String, ByVal sId As String, ByVal sDescripcion As String, ByVal cControl As Wisej.Web.ComboBox, Optional ByVal cParams() As SqlParameter = Nothing, Optional ByVal bEsText As Boolean = False)
        Try
            Dim i As Integer
            Dim myDS As DataSet = New DataSet
            Dim myDA As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(sNameProcedure, sConexion)
            If bEsText = True Then
                myDA.SelectCommand.CommandType = CommandType.Text
            Else
                myDA.SelectCommand.CommandType = CommandType.StoredProcedure
                If cParams Is Nothing = False Then
                    For i = 0 To cParams.Length - 1
                        If cParams(i) Is Nothing = False Then
                            myDA.SelectCommand.Parameters.Add(cParams(i))
                        End If
                    Next
                End If
            End If
            myDS.EnforceConstraints = False
            myDA.Fill(myDS, "SQLX")
            With cControl 'llenar los Catalogos}

                .ValueMember = sId
                .DisplayMember = sDescripcion
                '.DataMember = "SQLX"ofunciones.MessageBox
                .DataSource = myDS.Tables(0)
                '.Refresh()
                '            combobox1.datasource = the second table
                'combobox1.displaymember = the description in the second table
                'combobox1.valuemebmer = the id in the second table

            End With
            cControl.SelectedIndex = -1
        Catch ex As Exception
            'Guardar_Error(modulo, ex.Message, operador, sNameProcedure, formulario)
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Sub Asignar(ByVal Frm As Wisej.Web.Form, ByVal cDataSource As Object, ByVal sDataMember As String, ByVal sId_Primary As String, Optional ByVal context As BindingContext = Nothing)
        Dim cControl As Object
        'Dim cCuentaControl As Wisej.Web.Control
        'Dim sDatafield As String
        'Dim bSeAsigno As Boolean
        'Dim sCantidadRow As String
        'Dim sPosRow As String
        'Dim bPaso As Boolean
        Try
            For Each cControl In Frm.Controls
                If cControl.HasChildren Then
                    AsignarChildren(cControl, cDataSource, sDataMember, context)
                End If
            Next
        Catch ex As SystemException
            'MsgBox("Error: " & x.Message, MsgBoxStyle.Critical, "Aviso")
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub AsignarChildren(ByVal cControls As Control, ByVal cDataSource As Object, ByVal sDataMember As String, Optional ByVal context As BindingContext = Nothing)
        Dim cControl As Object
        Dim sDatafield As String
        Try
            For Each cControl In cControls.Controls
                sDatafield = ""
                Select Case UCase(TypeName(cControl))
                    Case "TEXTBOX", "CALENDARCOMBO", "INTEGERUPDOWN", "VALUELISTUPDOWN", "NUMERICEDITBOX", "COMBOBOX", "C1PICTUREBOX", "UICHECKBOX"
                        If Trim(cControl.Tag) <> Nothing Then
                            sDatafield = Mid(cControl.Tag, 1, InStr(cControl.Tag, "/") - 1)
                        End If
                    Case Else
                        sDatafield = Nothing
                End Select

                If Trim(sDatafield) <> Nothing Then
                    'If context Is Nothing = False Then
                    '    cControl.BindingContext = context
                    'End If

                    Select Case UCase(TypeName(cControl))
                        Case "UICHECKBOX"
                            '                           Dim cControlUiRadioButton As Janus.Windows.EditControls.UICheckBox
                            '0:                          cControlUiRadioButton.d()
                            'cControlUiRadioButton = cControl
                            cControl.DataBindings.Clear()
                            cControl.DataBindings.Add(New Wisej.Web.Binding("BindableValue", cDataSource, sDataMember & "." & sDatafield))
    ' cControl.DataBindings("Checked").DataSourceNullValue = 0
    'ParametersX_Global(nMatrizEmpiezadesde) = New SqlClient.SqlParameter("@" & sDatafield, cControlUiRadioButton.CheckedValue)
                        Case "COMBOBOX"
                            Dim cControlUiCombobox As Wisej.Web.ComboBox
                            cControl.DataBindings.Clear()
                            cControlUiCombobox = cControl
                            If cControlUiCombobox.DropDownStyle = ComboBoxStyle.DropDownList Then
                                cControl.DataBindings.Add(New Wisej.Web.Binding("SelectedValue", cDataSource, sDataMember & "." & sDatafield))
                            Else
                                cControl.DataBindings.Add(New Wisej.Web.Binding("Text", cDataSource, sDataMember & "." & sDatafield))
                            End If
    'cControlUiCombobox.DataBindings.Add(New 


                        Case "VALUELISTUPDOWN"
                            cControl.DataBindings.Clear()
                            cControl.DataBindings.Add(New Wisej.Web.Binding("Text", cDataSource, sDataMember & "." & sDatafield))
    'cControl.DataBindings.Add 
                        Case "CALENDARCOMBO"
                            cControl.DataBindings.Clear()
                            cControl.DataBindings.Add(New Wisej.Web.Binding("BindableValue", cDataSource, sDataMember & "." & sDatafield, True))
    'cControl.DataBindings 
                        Case "TEXTBOX"

                            'cControl.DataBindings.Add(""
                            cControl.DataBindings.Clear()
                            cControl.DataBindings.Add(New Wisej.Web.Binding("Text", cDataSource, sDataMember & "." & sDatafield))
    'cControl.BindingContext(cDataSource, sDataMember & "." & sDatafield).EndCurrentEdit()
    'cControl.Refresh()
                        Case "INTEGERUPDOWN"
                            cControl.DataBindings.Clear()
                            cControl.DataBindings.Add(New Wisej.Web.Binding("Value", cDataSource, sDataMember & "." & sDatafield))
                        Case "NUMERICEDITBOX"
                            cControl.DataBindings.Clear()
                            cControl.DataBindings.Add(New Wisej.Web.Binding("Value", cDataSource, sDataMember & "." & sDatafield))
                        Case "C1PICTUREBOX"
                            cControl.DataBindings.Clear()
                            cControl.DataBindings.Add(New Wisej.Web.Binding("Image", cDataSource, sDataMember & "." & sDatafield))
                    End Select
                End If

                If cControl.HasChildren Then
                    Call AsignarChildren(cControl, cDataSource, sDataMember)
                End If
            Next
        Catch ex As System.Exception
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Shared Function Total_Datagrid_column(ByVal Grid As Wisej.Web.DataGridView, ByVal scolumn As String) As Double
        Dim tot As Double = 0
        Dim i As Integer = 0
        For i = 0 To Grid.Rows.Count - 1
            If Trim("" & Grid.Item(scolumn, i).Value) <> Nothing Then
                tot = tot + CDbl(Grid.Item(scolumn, i).Value)
            End If
        Next i
        Return tot
    End Function
    Sub llenar_Listview_Multiple(ByVal LIST As Wisej.Web.ListView, ByVal Grid As Wisej.Web.DataGridView, Optional ByVal sColumnaName As String = "CVE_PROYECTO")
        Dim bExiste As Boolean
        Dim Columns, sCve_Proyecto As String
        For i As Integer = 0 To Grid.RowCount - 1
            If Grid.Item("cSeleccionar", i).Value = "True" Then
                Dim itmx As New ListViewItem
                sCve_Proyecto = Grid.Item(sColumnaName, i).Value
                If LIST.Items.Count > 0 Then
                    bExiste = Existe_En_Listview(sCve_Proyecto, sColumnaName, LIST)
                End If
                If bExiste = False Then
                    For j As Integer = 2 To Grid.ColumnCount - 1
                        Columns = Grid.Item(j, i).Value.ToString
                        itmx.SubItems.Add(Columns)
                    Next
                    LIST.Items.Add(itmx)
                End If

            End If
        Next
    End Sub
    Function Existe_En_Listview(ByVal sCve As String, ByVal sColumnName As String, ByVal list As Wisej.Web.ListView) As Boolean
        Dim i As Integer
        Dim bExiste As Boolean = False
        If list.Items.Count > 0 Then
            For i = 0 To list.Items.Count - 1
                If list.Items(i).Text = sCve Then
                    bExiste = True
                    Exit For
                End If
            Next
        End If
        Return bExiste
    End Function
    Sub ExportarDataGrid(ByVal DataGridView1 As Wisej.Web.DataGridView, ByVal Frm As Control, ByVal sFormato As String)
        'Dim listSeparator As String = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator
        'Dim strBuilder As New System.Text.StringBuilder

        ''Add name of headers in the content
        'Dim arr As String() = New String(DataGridView1.Columns.Count - 1) {}
        'Dim i As Integer = 0
        'Do While (i < DataGridView1.Columns.Count)
        '    arr(i) = DataGridView1.Columns.Item(i).HeaderText
        '    arr(i) = GetWriteableValue(arr(i))
        '    i += 1
        'Loop
        'strBuilder.Append(String.Join(listSeparator, arr))
        'strBuilder.Append(Environment.NewLine)

        ''Add data of rows in the content.
        'Dim j As Integer
        'For j = 0 To DataGridView1.Rows.Count - 1
        '    If Not DataGridView1.Rows.Item(j).IsNewRow Then
        '        Dim dataArr As String() = New String(DataGridView1.Columns.Count - 1) {}
        '        For i = 0 To DataGridView1.Columns.Count - 1
        '            If DataGridView1.Columns(i).CellType.Name = "DataGridViewImageCell" Then
        '                dataArr(i) = "[Imagen]"
        '            Else
        '                Dim o As Object = DataGridView1.Rows.Item(j).Cells.Item(i).Value
        '                dataArr(i) = GetWriteableValue(o)
        '            End If
        '        Next i
        '        strBuilder.Append(String.Join(listSeparator, dataArr))
        '        strBuilder.Append(Environment.NewLine)
        '    End If
        'Next j
        '' Download file with DataGridView' content
        'Dim myDownload As New FileDownloadGateway
        'myDownload.Filename = "ExportData." & sFormato
        'myDownload.DownloadAsAttachment = True
        'Select Case sFormato
        '    Case "csv"
        '        myDownload.SetContentType(DownloadContentType.OctetStream)
        '    Case "xls"
        '        myDownload.SetContentType(DownloadContentType.MicrosoftExcel)
        '    Case "doc"
        '        myDownload.SetContentType(DownloadContentType.MicrosoftWord)
        '    Case "txt"
        '        myDownload.SetContentType(DownloadContentType.PlainText)
        'End Select

        ''myDownload.StartStringDownload(Frm, strBuilder.ToString)
        'Dim a = Encoding.UTF32.GetBytes(strBuilder.ToString)
        'Dim ms As New System.IO.MemoryStream(a)
        'myDownload.StartStreamDownload(Frm, ms)
    End Sub
    Sub ExportarPlantilla(ByVal Frm As Control, ByVal sUrl As String)
        ''Suub Exportar Get FullPhysicalFilePath to send to Browser
        'Dim myFilePath As String = ContextUtils.GetPhysicalPath(Frm, sUrl) '"Resources\Plantillas\" & sModulo & "\", sNombreArchivo)

        'If Microsoft.VisualBasic.FileIO.FileSystem.FileExists(myFilePath) Then
        '    Dim myDownload As New DownloadGateway(myFilePath)
        '    'Start Download
        '    myDownload.Bajar(Frm)
        'Else
        '    MessageBox.Show("Error: Archivo no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If

    End Sub
    Sub EsportarPDF(ByVal F As Control, ByVal sUrl As String)

    End Sub
    ''' <summary>
    ''' Sirve para exportar datos con los filtros de filtrogrillasax 
    ''' </summary>
    '''<param name="Formx">Formulario de Gizmox es Me</param>
    ''' <param name="sProcedure">Se obtiene desde filtrogrillaSax propiedad meSprocedure </param>
    ''' <param name="sWhere">Se obtiene desde filtrogrillaSax propiedad me_sWhere</param>
    ''' <param name="sFormato">Excel</param>
    ''' <param name="Parameters">Parametro que sirve para agregar los filtros mandados en un Load o un Cargar por SqlClient.SqlDataAdapter </param>
    Sub Export_To_sFiltro(ByVal Formx As Form, sProcedure As String, sWhere As String, sFormato As String, Optional ByVal Parameters() As SqlClient.SqlParameter = Nothing)
        If sProcedure Is Nothing Then
            MessageBox.Show("No se puede exportar Procedure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        'If sWhere Is Nothing Then
        '    MessageBox.show("No se puede exportar parametro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        Dim AspX As New Wisej.Web.AspNetPanel
        Formx.Controls.Add(AspX)
        'AspX.Visible = False
        AspX.PageSource = "./MOD_PLANEACION/Cedulas/Cedula_Exportar_Datos.aspx"
        Application.Current.Session("Formato") = sFormato
        Application.Current.Session("ProcedureName") = sProcedure
        Application.Current.Session("sWhere_DT") = sWhere
        Application.Current.Session("MySqlParam") = Parameters
        AspX.Update()
    End Sub

    Public Shared Function GetWriteableValue(ByVal o As Object) As String
        If ((o Is Nothing) OrElse (o Is Convert.DBNull)) Then
            Return ""
        End If
        If (o.ToString.IndexOf(",") = -1) Then
            Return o.ToString
        End If
        Return ("""" & o.ToString & """")
    End Function

    '''''''''''''''''''''''''''''''''''''''''
    ' ______                                '
    ' |  ____|                              '
    ' | |__   _ __ _ __ ___  _ __ ___  ___  '
    ' |  __| | '__| '__/ _ \| '__/ _ \/ __| '
    ' | |____| |  | | | (_) | | |  __/\__ \ '
    ' |______|_|  |_|  \___/|_|  \___||___/ '
    '                                       '
    '''''''''''''''''''''''''''''''''''''''''
    'Falta Spire
    Sub EXPORTAR_DATOS(ByVal responseX As HttpResponse, ByVal sFormato As String, ByVal sProcedureName As String, Optional ByVal sWhere_DT As String = Nothing, Optional ByVal ParametersX() As SqlClient.SqlParameter = Nothing)
        'Dim dv As DataView

        ''-------------
        'Dim cmd As SqlCommand = New SqlCommand()
        'cmd.Connection = New SqlConnection(sConexion)
        'cmd.CommandText = sProcedureName
        'If Application.Current.Session("Cve_Unidad") <> "ADMIN" Then
        '    cmd.Parameters.AddWithValue("@CVE_UNIDAD", Application.Current.Session("Cve_Unidad"))
        'End If
        'If ParametersX Is Nothing = False Then
        '    cmd.CommandType = CommandType.StoredProcedure
        '    For n = 0 To ParametersX.Count - 1
        '        cmd.Parameters.Add(ParametersX(n))
        '    Next
        'Else
        '    cmd.CommandType = CommandType.Text
        'End If

        'Dim da As SqlDataAdapter = New SqlDataAdapter()
        'da.SelectCommand = cmd
        'Dim table As DataTable = New DataTable(sProcedureName)

        'da.Fill(table)
        'If sWhere_DT <> Nothing Then
        '    dv = table.DefaultView
        '    dv.RowFilter = sWhere_DT
        '    table = dv.Table
        'End If
        ''-------------

        'If sFormato = "EXCEL" Then
        '    Dim cellExport1 = New Spire.DataExport.XLS.CellExport           '
        '    cellExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
        '    cellExport1.DataFormats.CultureName = "es-MX"
        '    cellExport1.DataFormats.Currency = "c2"
        '    cellExport1.DataFormats.DateTime = "dd/MM/yyyy"

        '    cellExport1.SheetOptions.AggregateFormat.Font.Name = "Arial"
        '    cellExport1.SheetOptions.CustomDataFormat.Font.Name = "Arial"
        '    cellExport1.SheetOptions.DefaultFont.Name = "Arial"
        '    cellExport1.SheetOptions.FooterFormat.Font.Name = "Arial"

        '    cellExport1.SheetOptions.TitlesFormat.Font.Bold = True
        '    cellExport1.SheetOptions.TitlesFormat.Font.Name = "Arial"

        '    cellExport1.DataTable = table
        '    cellExport1.DataSource = Spire.DataExport.Common.ExportSource.DataTable
        '    cellExport1.SaveToHttpResponse("Export.csv", responseX)

        'ElseIf sFormato = "DBF" Then
        '    Dim dbfExport1 = New Spire.DataExport.DBF.DBFExport
        '    'dbfExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
        '    dbfExport1.DataFormats.CultureName = "es-MX"
        '    dbfExport1.DataTable = table
        '    dbfExport1.DataSource = Spire.DataExport.Common.ExportSource.DataTable
        '    dbfExport1.SaveToHttpResponse("Export", responseX)
        '    '
        'ElseIf sFormato = "HTML" Then

        '    Dim HtmExport1 = New Spire.DataExport.HTML.HTMLExport
        '    HtmExport1.DataTable = table
        '    HtmExport1.DataSource = Spire.DataExport.Common.ExportSource.DataTable
        '    HtmExport1.SaveToFile("Export")

        'ElseIf sFormato = "PDF" Then
        '    Dim pdfExport1 = New Spire.DataExport.PDF.PDFExport
        '    pdfExport1.DataFormats.CultureName = "es-MX"
        '    pdfExport1.DataFormats.Currency = "c"

        '    pdfExport1.PDFOptions.PageOptions.Format = Spire.DataExport.PDF.PageFormat.Letter
        '    pdfExport1.PDFOptions.PageOptions.Orientation = Spire.DataExport.Common.PageOrientation.Landscape

        '    pdfExport1.PDFOptions.PageOptions.Width = AutoSizeMode.GrowOnly
        '    pdfExport1.DataTable = table
        '    pdfExport1.DataSource = Spire.DataExport.Common.ExportSource.DataTable
        '    pdfExport1.SaveToHttpResponse("Export", responseX)

        'ElseIf sFormato = "RTF" Then

        '    Dim rtfExport1 = New Spire.DataExport.RTF.RTFExport

        '    rtfExport1.DataFormats.CultureName = "es-MX"
        '    rtfExport1.DataFormats.Currency = "c"

        '    rtfExport1.RTFOptions.DataStyle.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        '    rtfExport1.RTFOptions.FooterStyle.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        '    rtfExport1.RTFOptions.HeaderStyle.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        '    rtfExport1.RTFOptions.TitleStyle.Alignment = Spire.DataExport.RTF.RtfTextAlignment.Center
        '    rtfExport1.RTFOptions.TitleStyle.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        '    rtfExport1.DataTable = table
        '    rtfExport1.DataSource = Spire.DataExport.Common.ExportSource.DataTable
        '    rtfExport1.SaveToHttpResponse("Export.csv", responseX)

        'ElseIf sFormato = "TXT" Then
        '    Dim txtExport1 = New Spire.DataExport.TXT.TXTExport

        '    txtExport1.CustomFormats.Text = "TXT"

        '    txtExport1.DataFormats.CultureName = "es-MX"

        '    txtExport1.DataTable = table
        '    txtExport1.DataSource = Spire.DataExport.Common.ExportSource.DataTable
        '    txtExport1.SaveToHttpResponse("Export", responseX)

        'ElseIf sFormato = "XML" Then
        '    Dim xmlExport1 = New Spire.DataExport.XML.XMLExport
        '    xmlExport1.DataFormats.CultureName = "es-MX"

        '    xmlExport1.DataTable = table
        '    xmlExport1.DataSource = Spire.DataExport.Common.ExportSource.DataTable
        '    xmlExport1.SaveToHttpResponse("Export", responseX)

        'ElseIf sFormato = "SQL" Then

        '    Dim sqlExport1 = New Spire.DataExport.SQL.SQLExport
        '    sqlExport1.DataFormats.CultureName = "es-MX"

        '    sqlExport1.DataTable = table
        '    sqlExport1.DataSource = Spire.DataExport.Common.ExportSource.DataTable
        '    sqlExport1.SaveToHttpResponse("Export", responseX)
        'ElseIf sFormato = "CLIPBOARD" Then
        'End If


        'Desconectar()
    End Sub

    'CONVERTIR NUMEROS A LETRAS BY LIVIO
    Public Function Numeros_Letras(ByVal Numero As Double, Optional negativo As Boolean = False) As String
        'no estamos usando todos los argumentos, solo el valor con numero..
        ' Optional Moneda As String, _
        ' Optional Fraccion_Letras As Boolean = False, _
        ' Optional Fraccion As String, _
        ' Optional Texto_Inicial As String, _
        ' Optional Texto_Final As String, _
        ' Optional Estilo As Integer = 1) As String
        Dim strLetras As String
        Dim NumTmp As String
        Dim intFraccion As Integer

        'para no usar los argumentos, le asignamos valores a las variables
        'locales. asi, en la linea de comando se escribe solo el nombre de la funcion
        'con la direccion de la celda que contiene la cantidad con numero como
        'argumento:
        ' =Numeros_letras(G93)
        'lo que sigue debe quitarse cuando se quieran usar los argumentos
        'en la linea de comandos..desde aqui:

        Dim Moneda As String
        Dim Fraccion_Letras As Boolean
        Dim Fraccion As String
        Dim Texto_Inicial As String
        Dim Texto_Final As String
        Dim Estilo As Integer

        Moneda = "PESO"
        Fraccion_Letras = False
        Fraccion = "CENTAVO"
        Texto_Inicial = "("
        Texto_Final = "/100,M.N.)"
        Estilo = 1
        'hasta aqui


        'empieza a formar la cadena, primero:
        'Convertimos a positivo si es negativo
        'Numero = Abs(Numero)

        If (negativo And Numero < 0) Then
            Numero = Math.Abs(Numero)
            Texto_Inicial += "MENOS "
        End If
        strLetras = Texto_Inicial
        NumTmp = Format(Numero, "000000000000000.00")
        If Numero < 1 Then
            strLetras = strLetras & "cero " & Plural(Moneda) & " "
        Else
            strLetras = strLetras & NumLet(Val(Microsoft.VisualBasic.Left(NumTmp, 15)))
            If Val(NumTmp) = 1 Or Val(NumTmp) < 2 Then
                strLetras = strLetras & Moneda & " "
            ElseIf Val(Mid(NumTmp, 4, 12)) = 0 Or Val(Mid(NumTmp, 10, 6)) = 0 Then
                strLetras = strLetras & "de " & Plural(Moneda) & " "
            Else
                strLetras = strLetras & Plural(Moneda) & " "
            End If
        End If
        If Fraccion_Letras Then
            intFraccion = Val(Microsoft.VisualBasic.Right(NumTmp, 2))
            Select Case intFraccion
                Case 0
                    strLetras = strLetras & "con cero " & Plural(Fraccion)
                Case 1
                    strLetras = strLetras & "con un " & Fraccion
                Case Else
                    strLetras = strLetras & "con " & NumLet(Val(Microsoft.VisualBasic.Right(NumTmp, 2))) &
Plural(Fraccion)
            End Select
        Else
            strLetras = strLetras & Microsoft.VisualBasic.Right(NumTmp, 2)
        End If
        strLetras = strLetras & Texto_Final
        Select Case Estilo
            Case 1
                strLetras = StrConv(strLetras, vbUpperCase)
            Case 2
                strLetras = StrConv(strLetras, vbLowerCase)
            Case 3
                strLetras = StrConv(strLetras, vbProperCase)
        End Select

        Numeros_Letras = strLetras

    End Function
    Public Function NumLet(ByVal Numero As Double) As String
        Dim NumTmp As String
        Dim co1 As Integer
        Dim co2 As Integer
        Dim pos As Integer
        Dim dig As Integer
        Dim cen As Integer
        Dim dec As Integer
        Dim uni As Integer
        Dim letra1 As String
        Dim letra2 As String
        Dim letra3 As String
        Dim Leyenda As String
        Dim TFNumero As String

        NumTmp = Format(Numero, "000000000000000") 'Le da un formato fijo
        co1 = 1
        pos = 1
        TFNumero = ""
        'Para extraer tres digitos cada vez
        Do While co1 <= 5
            co2 = 1
            Do While co2 <= 3
                'Extrae un digito cada vez de izquierda a derecha
                dig = Val(Mid(NumTmp, pos, 1))
                Select Case co2
                    Case 1 : cen = dig
                    Case 2 : dec = dig
                    Case 3 : uni = dig
                End Select
                co2 = co2 + 1
                pos = pos + 1
            Loop
            letra3 = Centena(uni, dec, cen)
            letra2 = Decena(uni, dec)
            letra1 = Unidad(uni, dec)

            Select Case co1
                Case 1
                    If cen + dec + uni = 1 Then
                        Leyenda = "billon "
                    ElseIf cen + dec + uni > 1 Then
                        Leyenda = "billones "
                    End If
                Case 2
                    If cen + dec + uni >= 1 And Val(Mid(NumTmp, 7, 3)) = 0 Then
                        Leyenda = "mil millones "
                    ElseIf cen + dec + uni >= 1 Then
                        Leyenda = "mil "
                    End If
                Case 3
                    If cen + dec = 0 And uni = 1 Then
                        Leyenda = "millon "
                    ElseIf cen > 0 Or dec > 0 Or uni > 1 Then
                        Leyenda = "millones "
                    End If
                Case 4
                    If cen + dec + uni >= 1 Then
                        Leyenda = "mil "
                    End If
                Case 5
                    If cen + dec + uni >= 1 Then
                        Leyenda = ""
                    End If
            End Select

            co1 = co1 + 1
            TFNumero = TFNumero + letra3 + letra2 + letra1 + Leyenda

            Leyenda = ""
            letra1 = ""
            letra2 = ""
            letra3 = ""
        Loop

        NumLet = TFNumero

    End Function
    Private Function Centena(ByVal uni As Integer, ByVal dec As Integer,
ByVal cen As Integer) As String
        Dim cTexto As String

        Select Case cen
            Case 1
                If dec + uni = 0 Then
                    cTexto = "cien "
                Else
                    cTexto = "ciento "
                End If
            Case 2 : cTexto = "doscientos "
            Case 3 : cTexto = "trescientos "
            Case 4 : cTexto = "cuatrocientos "
            Case 5 : cTexto = "quinientos "
            Case 6 : cTexto = "seiscientos "
            Case 7 : cTexto = "setecientos "
            Case 8 : cTexto = "ochocientos "
            Case 9 : cTexto = "novecientos "
            Case Else : cTexto = ""
        End Select
        Centena = cTexto

    End Function
    Private Function Decena(ByVal uni As Integer, ByVal dec As Integer) As String
        Dim cTexto As String

        Select Case dec
            Case 1
                Select Case uni
                    Case 0 : cTexto = "diez "
                    Case 1 : cTexto = "once "
                    Case 2 : cTexto = "doce "
                    Case 3 : cTexto = "trece "
                    Case 4 : cTexto = "catorce "
                    Case 5 : cTexto = "quince "
                    Case 6 To 9 : cTexto = "dieci"
                End Select
            Case 2
                If uni = 0 Then
                    cTexto = "veinte "
                ElseIf uni > 0 Then
                    cTexto = "veinti"
                End If
            Case 3 : cTexto = "treinta "
            Case 4 : cTexto = "cuarenta "
            Case 5 : cTexto = "cincuenta "
            Case 6 : cTexto = "sesenta "
            Case 7 : cTexto = "setenta "
            Case 8 : cTexto = "ochenta "
            Case 9 : cTexto = "noventa "
            Case Else : cTexto = ""
        End Select

        If uni > 0 And dec > 2 Then cTexto = cTexto + "y "

        Decena = cTexto

    End Function

    Public Function desencriptar128BitRijndael(
ByVal textoEncriptado As String,
ByVal claveDesencriptacion As String) As String

        Try


            Dim bytDataToBeDecrypted() As Byte
            Dim bytTemp() As Byte
            Dim bytIV() As Byte = {121, 241, 10, 1, 132,
    74, 11, 39, 255, 91,
    45, 78, 14, 211, 22, 62}
            Dim objRijndaelManaged As New RijndaelManaged()
            Dim objMemoryStream As MemoryStream
            Dim objCryptoStream As CryptoStream
            Dim bytDecryptionKey() As Byte

            Dim intLength As Integer
            Dim intRemaining As Integer
            Dim strReturnString As String = String.Empty

            If textoEncriptado = "" Then
                Return ""
            End If

            'Convertir el valor encriptado base64 a array de bytes
            bytDataToBeDecrypted = Convert.FromBase64String(textoEncriptado)

            'La clave de desencriptación debe ser de 256 bits de longitud (32 bytes)
            'Si tiene más de 32 bytes se truncará
            'Si es menor de 32 bytes se rellenará con A
            intLength = Len(claveDesencriptacion)

            If intLength >= 32 Then
                claveDesencriptacion = Strings.Left(claveDesencriptacion, 32)
            Else
                intLength = Len(claveDesencriptacion)
                intRemaining = 32 - intLength
                claveDesencriptacion = claveDesencriptacion & Strings.StrDup(intRemaining, "X")
            End If

            bytDecryptionKey = Encoding.ASCII.GetBytes(claveDesencriptacion.ToCharArray)

            ReDim bytTemp(bytDataToBeDecrypted.Length)

            objMemoryStream = New MemoryStream(bytDataToBeDecrypted)


            'Crear objeto Dencryptor y escribir su valor 
            'después de que se convierta en array de bytes
            objCryptoStream = New CryptoStream(objMemoryStream,
objRijndaelManaged.CreateDecryptor(bytDecryptionKey, bytIV),
CryptoStreamMode.Read)

            objCryptoStream.Read(bytTemp, 0, bytTemp.Length)

            'objCryptoStream.FlushFinalBlock()
            objMemoryStream.Close()
            objCryptoStream.Close()


            'Devolver la cadena de texto desencriptada
            'convertida de array de bytes a cadena de texto ASCII
            Return Encoding.ASCII.GetString(bytTemp)
        Catch ex As Exception

            Exit Function
        End Try
    End Function
    Private Function Unidad(ByVal uni As Integer, ByVal dec As Integer) As String
        Dim cTexto As String

        If dec <> 1 Then
            Select Case uni
                Case 1 : cTexto = "un "
                Case 2 : cTexto = "dos "
                Case 3 : cTexto = "tres "
                Case 4 : cTexto = "cuatro "
                Case 5 : cTexto = "cinco "
            End Select
        End If
        Select Case uni
            Case 6 : cTexto = "seis "
            Case 7 : cTexto = "siete "
            Case 8 : cTexto = "ocho "
            Case 9 : cTexto = "nueve "
        End Select

        Unidad = cTexto

    End Function
    'Funcion que convierte al plural el argumento pasado
    Private Function Plural(ByVal Palabra As String) As String
        Dim pos As Integer
        Dim strPal As String
        If Len(Trim(Palabra)) > 0 Then
            'pos = InStr(1, "aeiou", Right(Palabra, 1), vbTextCompare)
            If pos > 0 Then
                strPal = Palabra & "s"
            Else
                strPal = Palabra & "s"
            End If
        End If
        Plural = strPal
    End Function

    '''''''''''''''''''''''''''''''''''''''''
    ' ______                                '
    ' |  ____|                              '
    ' | |__   _ __ _ __ ___  _ __ ___  ___  '
    ' |  __| | '__| '__/ _ \| '__/ _ \/ __| '
    ' | |____| |  | | | (_) | | |  __/\__ \ '
    ' |______|_|  |_|  \___/|_|  \___||___/ '
    '                                       '
    '''''''''''''''''''''''''''''''''''''''''
    'Falta frm Actualizar
    'Function Actualizar_Mostrar_Form(ByVal bPrimero As Boolean) As Boolean
    '    Dim bPrimero_Devuelve As Boolean = False
    '    Dim bPasaValor As Boolean
    '    Conectar()
    '    Dim cDataReader As Data.SqlClient.SqlDataReader
    '    Try
    '        cCommand = New SqlClient.SqlCommand("pPARAMETROS_B", cConnect)
    '        cCommand.CommandType = CommandType.StoredProcedure
    '        cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
    '        If cDataReader.HasRows Then
    '            While (cDataReader.Read)
    '                bPasaValor = cDataReader.Item("actualizacion")
    '            End While
    '        End If


    '        If (bPasaValor) = True And bPrimero = True Then
    '            form_cuentaAtras = New Actualizar
    '            form_cuentaAtras.Show()
    '            form_cuentaAtras.Text = "Actualizacion de SIPNETV4"
    '            bPrimero_Devuelve = False
    '        ElseIf (bPasaValor) = False Then
    '            bPrimero_Devuelve = True
    '        End If


    '        Return bPrimero_Devuelve
    '    Catch ex As SystemException
    '        MessageBox.show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        If IsNothing(cDataReader) = False Then
    '            If cDataReader.IsClosed = False Then cDataReader.Close()
    '        End If
    '        Desconectar()
    '    End Try
    'End Function
    ''' <summary>
    ''' Función para inicio de sesión.
    ''' </summary>
    ''' <param name="scve_operador"></param>
    ''' <param name="ssistema"></param>
    ''' <param name="name"></param>
    ''' <remarks></remarks>
    Sub iniciar_sesion(ByVal scve_operador As String, ByVal name As String)
        'ReDim ParametersX_Global(3)
        'ParametersX_Global(0) = New SqlClient.SqlParameter("@parametro", True)
        'ParametersX_Global(1) = New SqlClient.SqlParameter("@Equipo", name)
        'ParametersX_Global(2) = New SqlClient.SqlParameter("@Cve_Operador", scve_operador)
        'fGuardar_O_EliminarXProcedure("pActiva_EstatusOperadores", "@param", ParametersX_Global, True)

        'Guardar_Bitacora(scve_operador, "INICIO SESSION", Application.Current.HttpContext.Request.UserHostAddress) ' Context.HttpContext.Request.UserHostAddress)
        'Application.Current.Session.IsLoggedOn = True


        'Application.Current.Transfer(New Menu_OLD)

    End Sub
    ''' <summary>
    ''' Este método devuelve Verdadero cuando un folio existe
    ''' </summary>
    ''' <param name="sProcedureName">Especificar el nombre del procedimiento</param>
    ''' <param name="sParametro">El nombre del parametro que se busca en el procedimiento</param>
    ''' <param name="sData">El valor del dato a buscar que se pasa al procedimiento</param>
    ''' <param name="sReturn">El valor que devuelve la función. Es opcional y su valor por defecto es @PARAMETRO</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function existData(ByVal sProcedureName As String, ByVal sParametro As String, ByVal sData As String, ByVal sReturn As String, Optional ByVal sParametro2 As String = "", Optional ByVal sDataxx As String = "") As Boolean
        existData = False

        Conectar()

        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            cCommand = New SqlClient.SqlCommand(sProcedureName, cConnect)
            cCommand.CommandType = CommandType.StoredProcedure
            cCommand.Parameters.AddWithValue(sParametro, sData)
            cCommand.Parameters.AddWithValue(sParametro2, sDataxx)
            Dim sNombreCampoRetornar As String

            sNombreCampoRetornar = sReturn

            If Trim(sNombreCampoRetornar) <> Nothing Then
                Dim parameterConsecutivo As New SqlParameter(sNombreCampoRetornar, SqlDbType.Int)
                parameterConsecutivo.Direction = ParameterDirection.Output
                cCommand.Parameters.Add(parameterConsecutivo)

                cCommand.ExecuteNonQuery()
                'Ofunciones.cCommand.eX()
                If Not parameterConsecutivo.Value Is Nothing And Not parameterConsecutivo.Value Is System.DBNull.Value Then
                    existData = CBool(parameterConsecutivo.Value)
                Else
                    existData = False
                End If
            Else
                cCommand.ExecuteNonQuery()
                existData = True
            End If

            'If cDataReader.HasRows Then

            '    existfield = True
            'End If
        Catch ex As SystemException
            existData = False
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()
        End Try
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sProcedureName">Nombre del procedimiento almacenado para ejecutar en la Base de Datos</param>
    ''' <param name="sParametro"> Parametro 1 para el procedimiento</param>
    ''' <param name="sData">Dato o valor del parametro 1</param>
    ''' <param name="sReturn">campo que retorna la funcion </param>
    ''' <param name="sParametro2"> Parametro 2 para el procedimiento</param>
    ''' <param name="sDataxx">Dato o valor del parametro 2</param>
    ''' <returns></returns>
    Public Function ReportsMargins(ByVal sProcedureName As String, ByVal sParametro As String, ByVal sData As String, ByVal sReturn As String, Optional ByVal sParametro2 As String = "", Optional ByVal sDataxx As String = "") As String()
        Dim sRetorna(0), sRetornaX As String
        Conectar()

        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            cCommand = New SqlClient.SqlCommand(sProcedureName, cConnect)
            cCommand.CommandType = CommandType.StoredProcedure
            cCommand.Parameters.AddWithValue(sParametro, sData)

            If sParametro2 <> Nothing Then cCommand.Parameters.AddWithValue(sParametro2, sDataxx)

            cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)

            If cDataReader.HasRows Then
                While (cDataReader.Read)
                    sRetornaX = cDataReader.Item(sReturn)
                End While
            End If

            'Return t
        Catch ex As SystemException
            'MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()
        End Try
        If sRetornaX = Nothing Then
            sRetornaX = "5,5,5,5"
            Guardar_Error("REPORTES", "NO ESTA EL REPORTE EN LA TABLA CAT_REPORTES" & sProcedureName, Application.Current.Session("Cve_Operador"), "ReportsMargins." & sData & sParametro2, "Report Viewer")
        End If
        sRetorna = sRetornaX.Split(",")
        Return sRetorna
    End Function
    Public Sub loadConfigDataGridView(ByVal dgvTabla As Wisej.Web.DataGridView)
        With dgvTabla
            .RowHeadersVisible = False
            .ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 8.35!, FontStyle.Bold)
            .ColumnHeadersHeight = 36
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            .BackColor = Color.White
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle.ToString.ToLower()
            .Columns.ToString.ToLower()
        End With

        'AlternatingColors_Grilla(dgvTabla)
    End Sub
    Public Function validData(ByRef data As Object) As Boolean

        'If "" & data = "" Then
        If String.IsNullOrEmpty(data) Or String.IsNullOrWhiteSpace(data) Then
            'If data = vbNullString Or data = "" Or data = Nothing Or IsDBNull(data) Then
            Return False
        Else
            Return Len(data)
        End If

    End Function
    Public Function getDataByProcedure(ByVal proc As String, ByVal param As String, ByVal valor As String, ByVal id As String, Optional ByVal pass As String = "", Optional ByVal param2 As String = Nothing, Optional ByVal valor2 As String = Nothing) As String
        Dim mydata As String

        Conectar()

        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            cCommand = New SqlClient.SqlCommand(proc, cConnect)
            cCommand.CommandType = CommandType.StoredProcedure
            cCommand.Parameters.AddWithValue(param, valor)
            If param2 <> Nothing And valor2 <> Nothing Then cCommand.Parameters.AddWithValue(param2, valor2)
            If pass <> "" Then cCommand.Parameters.AddWithValue("@PassphraseEnteredByUser", pass)

            cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)

            If cDataReader.HasRows Then
                While (cDataReader.Read)
                    mydata = cDataReader.Item(id)
                End While
            End If

            'Return t
        Catch ex As SystemException
            'MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()
        End Try
        Return IIf(mydata <> Nothing, mydata, Nothing)
    End Function

    Function Total_Firmas(ByVal scve_reporte As String, ByVal smodulo As String, Optional ByVal sTipo_Reporte As String = Nothing, Optional ByVal Compra As String = Nothing) As String
        Dim sDevuelveID As String = ""
        Try

            ReDim ParametersX_Global(5)
            ParametersX_Global(0) = New SqlClient.SqlParameter("@ReportName", scve_reporte)

            ParametersX_Global(1) = New SqlClient.SqlParameter("@MODULO", smodulo)
            If sTipo_Reporte <> Nothing Then
                ParametersX_Global(2) = New SqlClient.SqlParameter("@TIPO_REPORTE", sTipo_Reporte)
            End If
            'If bFirmasConAdmin Then
            '    ' Application.Current.Session("Cve_Unidad")
            '    ParametersX_Global(3) = New SqlClient.SqlParameter("@CVE_UNIDAD", Application.Current.Session("Cve_Unidad"))
            'Else
            If Application.Current.Session("Cve_Unidad_Reporte") <> Nothing Then
                ParametersX_Global(3) = New SqlClient.SqlParameter("@CVE_UNIDAD", Application.Current.Session("Cve_Unidad_Reporte"))
            Else
                ParametersX_Global(3) = New SqlClient.SqlParameter("@CVE_UNIDAD", Application.Current.Session("Cve_Unidad"))
            End If
            'If Compra <> Nothing Then
            '    ParametersX_Global(5) = New SqlClient.SqlParameter("@COMPRA", Compra)
            'End If

            ' ParametersX_Global(3) = New SqlClient.SqlParameter("@CVE_UNIDAD", Application.Current.Session("Cve_Unidad_Reporte"))
            'If Application.Current.Session("REPORTE_TIPO_COMPRA") <> Nothing Then oFunciones.cCommand.Parameters.AddWithValue("@TIPO_LICITACION", Application.Current.Session("REPORTE_TIPO_COMPRA"))

            If Application.Current.Session("REPORTE_TIPO_COMPRA") <> Nothing Then
                ParametersX_Global(4) = New SqlClient.SqlParameter("@COMPRA", Application.Current.Session("REPORTE_TIPO_COMPRA"))
                'Application.Current.Session("REPORTE_TIPO_COMPRA") = Nothing
            Else
                ParametersX_Global(4) = New SqlClient.SqlParameter("@COMPRA", "NA")
            End If

            sDevuelveID = fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_FIRMAS_REPORTES_TOTAL", "@param", ParametersX_Global, , SqlDbType.VarChar, 50)
            Return sDevuelveID
        Catch ex As SystemException
            'Return sDevuelveID
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'Return sDevuelveID
        End Try
    End Function

    Function fDevulve_Firma(ByVal sPosicion As String) As Object
        Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            cCommand = New SqlClient.SqlCommand("pCAT_FIRMAS_REPORTES_B", cConnect)
            cCommand.CommandType = CommandType.StoredProcedure
            cCommand.Parameters.AddWithValue("@POSICION", sPosicion)
            If Application.Current.Session("CVE_REPORTE") <> Nothing Then cCommand.Parameters.AddWithValue("@CVE_REPORTE", Application.Current.Session("CVE_REPORTE"))
            'If sTipo_Licitacion <> Nothing Then
            '    cCommand.Parameters.AddWithValue("@TIPO_LICITACION", sTipo_Licitacion)
            'End If
            cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While cDataReader.Read
                    fDevulve_Firma = cDataReader.Item("NOMBRE")

                End While
            End If
        Catch ex As SystemException
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()
        End Try
    End Function

    Public Function BorrarArchivo(ByRef f As String) As Boolean
        Try
            If File.Exists(f) Then
                File.Delete(f)

                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            f = ex.Message
        End Try
    End Function

    Public Function BorrarArchivoS(ByRef f As String) As Boolean
        Try

            Dim Directorio As String = f
            Dim Fecha As DateTime = DateTime.Now
            Dim elimino As Boolean = False
            For Each archivo As String In IO.Directory.GetFiles(Directorio, "*.txt")

                Dim Fecha_Archivo As DateTime = FileSystem.FileDateTime(archivo)
                Dim diferencia = (CType(Fecha, DateTime) - CType(Fecha_Archivo, DateTime)).TotalMinutes

                If diferencia >= 30 Then
                    File.Delete(archivo)
                    elimino = True
                End If

            Next
            Return elimino


        Catch ex As Exception
            f = ex.Message
        End Try
    End Function


#End Region

#Region "Componentes"

    '''''''''''''''''''''''''''''''''''''''''
    ' ______                                '
    ' |  ____|                              '
    ' | |__   _ __ _ __ ___  _ __ ___  ___  '
    ' |  __| | '__| '__/ _ \| '__/ _ \/ __| '
    ' | |____| |  | | | (_) | | |  __/\__ \ '
    ' |______|_|  |_|  \___/|_|  \___||___/ '
    '                                       '
    '''''''''''''''''''''''''''''''''''''''''
    'Falta MensajeSax
    Sub MensajeboxSax(ByVal Smensaje As String, ByVal SParametros As String, ByVal e As EventHandler)
        'Dim X As MensajeSax
        'X = New MensajeSax

        'AddHandler X.Closed, e

        ''FormPadre.Controls.Add(X)
        'X.mensaje2.Text = Smensaje
        'X.Parametros.Text = SParametros
        'X.ShowDialog()
    End Sub

    '''''''''''''''''''''''''''''''''''''''''
    ' ______                                '
    ' |  ____|                              '
    ' | |__   _ __ _ __ ___  _ __ ___  ___  '
    ' |  __| | '__| '__/ _ \| '__/ _ \/ __| '
    ' | |____| |  | | | (_) | | |  __/\__ \ '
    ' |______|_|  |_|  \___/|_|  \___||___/ '
    '                                       '
    '''''''''''''''''''''''''''''''''''''''''
    'Falta Mensajefechasax
    Sub MensajeFechaSax(ByVal Smensaje As String, ByVal SParametros As String, ByVal SParametros2 As String, ByVal e As EventHandler)
        'Dim X As MensajeFechaSax
        'X = New MensajeFechaSax

        'AddHandler X.Closed, e

        ''FormPadre.Controls.Add(X)
        'X.mensaje2.Text = Smensaje
        'X.Parametros.Text = SParametros
        'X.Parametros2.Text = SParametros2
        'X.ShowDialog()
    End Sub

#End Region

#Region "DPCRS"
    Public Function Mostrar_Formulario(ByVal cNodo As String)
        Dim objcontrol As Object = Nothing
        If cNodo = Nothing Then
            Exit Function
        End If
        Try
            Dim wSTproyecto As String = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name
            Dim ensamblado As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
            Dim f As Form = ensamblado.CreateInstance(wSTproyecto + "." + cNodo, True)
            f.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Public Function ValidarPanel(ByVal panel As Control, ByVal ErrorProvider As ErrorProvider) As Boolean
        ValidarPanel = True
        For Each c As Control In panel.Controls
            If TypeOf c Is GroupBox And DirectCast(c, GroupBox).Visible = True Then
                If Not ValidarGrupos(c, ErrorProvider) Then
                    ValidarPanel = False
                    Exit For
                End If
            End If
        Next
    End Function
    Public Function ValidarGrupos(ByVal gb As Control, ByVal ErrorProvider As ErrorProvider) As Boolean
        ValidarGrupos = True

        For Each c As Control In gb.Controls
            If TypeOf c Is ComboBox Then
                'Si no ha seleccionado algun valor, entonces manda notificacion de error
                If DirectCast(c, ComboBox).SelectedIndex = -1 And DirectCast(c, ComboBox).Visible = True Then
                    ValidarGrupos = False
                    ErrorProvider.SetError(c, "Seleccione un elemento")
                    DirectCast(c, ComboBox).Focus()
                    Exit For
                Else
                    ErrorProvider.SetError(c, Nothing)
                End If

            ElseIf (TypeOf (c) Is TextBox) Then
                'Si está vacio y Visible, entonces manda notificacion de error
                If DirectCast(c, TextBox).Text = Nothing And DirectCast(c, TextBox).Visible = True Then
                    ErrorProvider.SetError(c, "Complete el dato")
                    ValidarGrupos = False
                    DirectCast(c, TextBox).Focus()
                    Exit For
                Else
                    ErrorProvider.SetError(c, Nothing)
                End If
            ElseIf (TypeOf (c) Is MaskedTextBox) Then
                'Si está vacio y Visible, entonces manda notificacion de error
                If DirectCast(c, MaskedTextBox).Text = Nothing And DirectCast(c, MaskedTextBox).Visible = True Then
                    ErrorProvider.SetError(c, "Complete el dato")
                    ValidarGrupos = False
                    DirectCast(c, MaskedTextBox).Focus()
                    Exit For
                Else
                    ErrorProvider.SetError(c, Nothing)
                End If
            End If
        Next

    End Function
    Public Function ValidarGruposTodo(ByVal gb As Control, ByVal ErrorProvider As ErrorProvider) As Boolean
        ValidarGruposTodo = True

        For Each c As Control In gb.Controls
            If TypeOf c Is ComboBox Then
                'Si no ha seleccionado algun valor, entonces manda notificacion de error
                If DirectCast(c, ComboBox).SelectedIndex = -1 Then
                    ValidarGruposTodo = False
                    ErrorProvider.SetError(c, "Seleccione un elemento")
                    DirectCast(c, ComboBox).Focus()
                    Exit For
                Else
                    ErrorProvider.SetError(c, Nothing)
                End If

            ElseIf (TypeOf (c) Is TextBox) Then
                'Si está vacio y Visible, entonces manda notificacion de error
                If DirectCast(c, TextBox).Text = Nothing Then
                    ErrorProvider.SetError(c, "Complete el dato")
                    ValidarGruposTodo = False
                    DirectCast(c, TextBox).Focus()
                    Exit For
                Else
                    ErrorProvider.SetError(c, Nothing)
                End If
            ElseIf (TypeOf (c) Is MaskedTextBox) Then
                'Si está vacio y Visible, entonces manda notificacion de error
                If DirectCast(c, MaskedTextBox).Text = Nothing Then
                    ErrorProvider.SetError(c, "Complete el dato")
                    ValidarGruposTodo = False
                    DirectCast(c, MaskedTextBox).Focus()
                    Exit For
                Else
                    ErrorProvider.SetError(c, Nothing)
                End If
            ElseIf (TypeOf (c) Is Control) Then
                'Si es un Panel, GroupBox o cualquier otro control que contenga elementos, aplica la recursividad para validar los campos que tenga.
                'If DirectCast(c, Control).Visible = True Then
                If ValidarGruposTodo(c, ErrorProvider) = False Then
                    ValidarGruposTodo = False
                    Exit For
                End If

                'End If
            End If

        Next

    End Function

    Public Function LimpiarPanel(ByVal gb As Control, ByVal Tag As Object)

        For Each c As Control In gb.Controls
            If TypeOf c Is ComboBox Then
                If Tag = Nothing Then
                    DirectCast(c, ComboBox).SelectedIndex = -1
                End If
            ElseIf (TypeOf (c) Is TextBox) Then
                DirectCast(c, TextBox).Text = Nothing
            ElseIf (TypeOf (c) Is MaskedTextBox) Then
                DirectCast(c, MaskedTextBox).Text = Nothing
                'ElseIf (TypeOf (c) Is RadioButton) Then
                '    DirectCast(c, RadioButton).Checked = False
            End If
        Next
    End Function

    Public Function LimpiarPanelProviders(ByVal gb As Control, ByVal Tag As Object, ByVal ErrorProvider As ErrorProvider)

        For Each c As Control In gb.Controls
            If TypeOf c Is ComboBox Then
                If Tag = Nothing Then
                    DirectCast(c, ComboBox).SelectedIndex = -1
                    ErrorProvider.SetError(c, Nothing)
                End If
            ElseIf (TypeOf (c) Is TextBox) Then
                DirectCast(c, TextBox).Text = Nothing
                ErrorProvider.SetError(c, Nothing)
                'ElseIf (TypeOf (c) Is RadioButton) Then
                '    DirectCast(c, RadioButton).Checked = False
            End If
        Next
    End Function

    Public Function GenerarReporte(ByVal sReportName As String, ByVal sProcedureName As String, Optional ByVal dicParametros As Dictionary(Of String, String) = Nothing)
        Dim MOSTRAR_ASP As New Mostrar_Asp
        MOSTRAR_ASP.AspPageBox1.PageSource = Nothing
        Application.Session("ReportName") = sReportName
        Application.Session("ProcedureName") = sProcedureName
        Application.Session("DicParametros") = dicParametros
        Application.Session("DocumentCached") = Nothing
        MOSTRAR_ASP.AspPageBox1.PageSource = "ReportView.aspx"
        MOSTRAR_ASP.AspPageBox1.Update()
        MOSTRAR_ASP.Show()
    End Function

    Function Concepto(ByVal sTipoActa As String, ByVal sCadenas() As String) As String
        Conectar()
        Dim sComodin As String = "$"
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            cCommand = New SqlClient.SqlCommand("pCAT_ACTAS_VERIFICACION_PLANTILLAS_B", cConnect)
            cCommand.CommandType = CommandType.StoredProcedure
            cCommand.Parameters.AddWithValue("@TIPO_ACTA", sTipoActa)
            cDataReader = cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                While (cDataReader.Read)
                    Concepto = cDataReader.Item("CONTENIDO")
                End While
            End If
        Catch ex As SystemException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Desconectar()
        End Try
        For i As Integer = 0 To sCadenas.Length - 1
            Concepto = Replace(Concepto, sComodin & i.ToString, sCadenas(i))
        Next
        Concepto = IIf(Concepto <> Nothing, Concepto, "")
    End Function
    Public Function ToolClick(CB As ComboBox, ByVal e As ToolClickEventArgs)
        If e.Tool.Name = "Borrar" Then
            CB.SelectedIndex = -1
            CB.Text = ""
        End If
    End Function
    Function obTener_Descripcion4(ByVal cControl As Object, Optional ByVal sColumnaName As String = "Descripcion") As Object
        If cControl.SelectedIndex = -1 Then
            Return Nothing
        Else
            Dim dt As DataTable = DirectCast(cControl.DataSource, DataTable)
            Return dt.Rows.Item(cControl.SelectedIndex).Item(sColumnaName).ToString()
        End If
    End Function
    'Function obTener_Descripcion3(ByVal cControl As combosax, Optional ByVal sColumnaName As String = "Descripcion", Optional ByVal sColumnaWHERE As String = Nothing, Optional ByVal WHERE As String = Nothing) As Object
    '    Dim SWHERE As String
    '    If cControl.SelectedIndex = -1 Then
    '        Return Nothing
    '    Else
    '        SWHERE = cControl.list_llenado.ValueMember & "='" & cControl.SelectedValue & "'"
    '        If sColumnaWHERE <> Nothing Then
    '            SWHERE = SWHERE + " AND " + sColumnaWHERE & "='" & WHERE & "'"
    '        End If
    '        Dim defaultV = cControl.DataSource.Tables(0).DefaultView
    '        defaultV.RowFilter = SWHERE

    '        Dim objDT = defaultV.ToTable()
    '        If objDT.Rows.Count <> 0 And sColumnaName <> "" Then

    '            Return objDT.Rows.Item(0).Item(sColumnaName)
    '        Else
    '            Return Nothing

    '        End If
    '    End If
    'End Function
#End Region


End Class
Class MyComboitem
    Public ReadOnly ID As String
    Public ReadOnly Text As String
    Public Sub New(ByVal ID As String, ByVal Text As String)
        Me.ID = ID
        Me.Text = Text
    End Sub
    Public Overrides Function ToString() As String
        Return Text
    End Function



End Class
Class Diccinario
    Public sHeigtArticulo As New Dictionary(Of String, String)
    Public Sub newItem(key As Object, value As Object)
        sHeigtArticulo.Add(key, value)
    End Sub





End Class


