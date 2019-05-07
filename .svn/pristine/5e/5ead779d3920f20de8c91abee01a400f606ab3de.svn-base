
Imports DevExpress.Web
Imports DevExpress.Web.ASPxHtmlEditor
Imports DevExpress.Charts.Native
Imports System.Drawing

Partial Public Class Capturar_Resultados
    Inherits System.Web.UI.Page
    Dim oFunciones As New dllData
    Dim bGuardo As Boolean
    Dim sOperador = Wisej.Web.Application.Session("Cve_Operador")
    Dim sId_Tipo As String
    Public ST As String


    Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PreInit
        'Dim sThemaX As String = oFunciones.sThemaActualDX
        'Page.Theme = sThemaX
        ''oFunciones.FlushMemory()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not IsPostBack) AndAlso (Not IsCallback) Then

            Dim sFolio As String = Request.QueryString("Folio")
            Dim sArea As String = "" & Request.QueryString("Area")
            Dim sCve_Estudios As String = "" & Request.QueryString("Cve_Estudio")
            '---------------------------------------------------
            Me.SqlDataSource1.SelectParameters.Add("Folio", sFolio)

            If Trim(sCve_Estudios <> Nothing) Then
                Me.SqlDataSource1.SelectParameters.Add("Cve_Estudio", sCve_Estudios)
            End If

            If Trim(sArea <> Nothing) Then
                Me.SqlDataSource1.SelectParameters.Add("Cve_Area", sArea)
            End If

            sId_Tipo = "" & Request.QueryString("id_Tipo")

        End If
    End Sub

    Protected Sub grid_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewColumnDataEventArgs)
        If e.Column.FieldName = "CompositeKey" Then
            Dim sFolio As String = Convert.ToString(e.GetListSourceFieldValue("Folio"))
            Dim sCve_Estudio As String = Convert.ToString(e.GetListSourceFieldValue("Cve_Estudio"))
            Dim sCve_SubEstudio As String = Convert.ToString(e.GetListSourceFieldValue("Cve_SubEstudio"))
            'Dim orderDate As String = Convert.ToString(e.GetListSourceFieldValue("OrderDate"))
            e.Value = sFolio & sCve_Estudio & sCve_SubEstudio '& "-" & orderDate
        End If
    End Sub


    Protected Sub ASPxGridView1_HtmlRowCreated(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewTableRowEventArgs) Handles ASPxGridView1.HtmlRowCreated

        Dim Img_Tipo_Dato As DevExpress.Web.ASPxImage
        Dim Img As DevExpress.Web.ASPxImage
        Dim Img_Interfazado As DevExpress.Web.ASPxImage
        Dim Img_Valida_Referencia As DevExpress.Web.ASPxImage


        ' Dim nValorMax As Double
        Dim bPasa As Boolean
        'imgEstatus()
        Try
            If e.RowType = DevExpress.Web.GridViewRowType.Data Then
                '*---------------------------------
                Img = ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "imgEstatus")
                Img_Tipo_Dato = ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "cImage_Tipo_Dato")
                Img_Interfazado = ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "cInterfazado")
                Img_Valida_Referencia = ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "cImage_Valida_Referencia")
                '*---------------------------------
                Dim sfolio As String = e.GetValue("Folio")
                Dim sTipo_Resultado As String = e.GetValue("Tipo_Resultado")
                Dim sEstatus As String = e.GetValue("Estatus")
                Dim sNumDigitos As String = e.GetValue("Num_Digitos")
                Dim bEs_Interfazado As Boolean = e.GetValue("Es_Interfazado")
                Dim nTipoRango_Numerico As Integer = e.GetValue("TipoRango_Numerico")
                Dim sTipoReferencia As String = e.GetValue("TipoReferencia")
                Dim bTieneValidacionTexto_Combo As Boolean = e.GetValue("TieneValidacionTexto_Combo")
                Dim sCve_Estudio As String = e.GetValue("Cve_Estudio")
                Dim sCve_SubEstudio As String = e.GetValue("Cve_SubEstudio")
                Dim sResultado As String = "" & e.GetValue("Resultado_defecto")
                Dim sTipo_Validacion_Texto As String = e.GetValue("Tipo_Validacion_Texto")
                Dim sformula As String = e.GetValue("Referencia_Formula")
                Dim FE As String = e.GetValue("FormatoEspecial")
                Dim FEX As String = e.GetValue("FE_X")
                Dim subestudio As String = e.GetValue("SubEstudio")
                If Trim(sNumDigitos) = Nothing Then
                    sNumDigitos = 0
                End If

                'If Trim(sNumDigitos) = "-1" Or Trim(sNumDigitos) = Nothing Then sNumDigitos = 10
                'e.Column.InputMask = "Number" & sNumDigitos

                Img_Valida_Referencia.Visible = False
                Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxCheckBox1").Visible = False

                If sEstatus = "SOLICITUD" Or sEstatus = "EDICION" Then
                    Select Case sTipo_Resultado
                        Case "NUMERICO", "NUMERICO_REFERENCIA"
                            Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxSpinEdit1").Visible = True
                            Dim ilabel As ASPxSpinEdit = CType(Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxSpinEdit1"), ASPxSpinEdit)
                            ilabel.AllowMouseWheel = False
                            ilabel.Text = sResultado
                            ilabel.DisplayFormatString = "n" & sNumDigitos

                            If sId_Tipo = "CONSULTA" Then
                                ilabel.ReadOnly = True
                                ilabel.Enabled = False
                            End If

                        Case "TEXTO"
                            If bTieneValidacionTexto_Combo Then
                                Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxComboBox1").Visible = True
                                Dim iASPxComboBox1 As ASPxComboBox = CType(Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxComboBox1"), ASPxComboBox)
                                If sTipo_Validacion_Texto = "RESTRINGIDO" Then
                                    iASPxComboBox1.DropDownStyle = DropDownStyle.DropDownList
                                Else
                                    iASPxComboBox1.DropDownStyle = DropDownStyle.DropDown
                                End If

                                If sId_Tipo = "CONSULTA" Then
                                    iASPxComboBox1.ReadOnly = True
                                    iASPxComboBox1.Enabled = False
                                Else
                                    ReDim oFunciones.ParametersX_Global(1)
                                    oFunciones.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Estudio", sCve_Estudio)
                                    oFunciones.ParametersX_Global(1) = New SqlClient.SqlParameter("@Cve_SubEstudio", sCve_SubEstudio)
                                    oFunciones.Llenar_CatalogosXprocedureYParams("pCAT_ESTUDIOS_SUB_VALIDACION_TEXTO_B", "Consecutivo", "ValidacionTexto", iASPxComboBox1, oFunciones.ParametersX_Global)
                                End If
                                iASPxComboBox1.Text = sResultado
                            Else
                                '/* REVISAER */

                                'If sformula = "CULTIVO" Then
                                '    Dim TEXTO As ASPxMemo = CType(Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxMemo1"), ASPxMemo)
                                '    TEXTO.Width = 800
                                'End If
                                'Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxMemo1").Visible = True

                                '/* REVISAER */
                                Dim TEXTO As ASPxMemo = CType(Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxMemo1"), ASPxMemo)
                                If sformula = "CULTIVO" Then
                                    TEXTO.Width = 800
                                End If
                                Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxMemo1").Visible = True

                                If sId_Tipo = "CONSULTA" Then
                                    TEXTO.ReadOnly = True
                                    TEXTO.Enabled = False
                                End If

                            End If
                        Case "MEMO"
                            'Dim editor As ASPxHtmlEditor = CType(Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxHtmlEditor1"), ASPxHtmlEditor)
                            Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxHtmlEditor1").Visible = True
                        Case "TITULO"
                            'Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxLabel1").Visible = True
                        Case "FORMULA"
                            Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxLabel1").Visible = True
                            'Dim ilabel As ASPxSpinEdit = CType(Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxLabel1"), ASPxSpinEdit)
                            'ilabel.DisplayFormatString = "n" & sNumDigitos

                            ' Dim ilabel As ASPxLabel = CType(Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxLabel1"), ASPxLabel)
                            'ilabel.Text = "123"
                        Case "CULTIVO"
                            If FE = "1" Then
                                Dim checbox1 As ASPxCheckBox = CType(Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxCheckBox1"), ASPxCheckBox)
                                If FEX = "2" Then
                                    Dim editor As ASPxHtmlEditor = CType(Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxHtmlEditor1"), ASPxHtmlEditor)
                                    Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxHtmlEditor1").Visible = True
                                    editor.ClientInstanceName = "ASPxHtmlEditor" & e.VisibleIndex
                                    editor.Html = sResultado
                                    editor.Width = 750
                                    checbox1.Checked = True

                                    If sId_Tipo = "CONSULTA" Then
                                        editor.Enabled = False
                                        checbox1.Enabled = False
                                    End If


                                ElseIf FEX = "3" Then
                                    Dim editor As ASPxHtmlEditor = CType(Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxHtmlEditor1"), ASPxHtmlEditor)
                                    Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxHtmlEditor1").Visible = False
                                    editor.ClientInstanceName = "ASPxHtmlEditor" & e.VisibleIndex
                                    checbox1.Checked = False

                                    If sId_Tipo = "CONSULTA" Then
                                        editor.Enabled = False
                                        checbox1.Enabled = False
                                    End If
                                Else
                                    Dim editor As ASPxHtmlEditor = CType(Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxHtmlEditor1"), ASPxHtmlEditor)
                                    Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxHtmlEditor1").Visible = True
                                    editor.ClientInstanceName = "ASPxHtmlEditor" & e.VisibleIndex
                                    editor.Html = sResultado
                                    editor.Width = 750
                                    checbox1.Checked = True

                                    If sId_Tipo = "CONSULTA" Then
                                        editor.Enabled = False
                                        checbox1.Enabled = False
                                    End If
                                End If
                                Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxCheckBox1").Visible = True
                            Else
                                Dim editor As ASPxHtmlEditor = CType(Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxHtmlEditor1"), ASPxHtmlEditor)
                                Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxHtmlEditor1").Visible = True
                                editor.ClientInstanceName = "ASPxHtmlEditor" & e.VisibleIndex
                                editor.Html = sResultado
                                editor.Height = 250
                                editor.Width = 750

                                If sId_Tipo = "CONSULTA" Then
                                    editor.Enabled = False
                                End If
                            End If
                        Case "CULTIVO 3 COLUMNAS"
                            If FE = "1" Then
                                Dim checbox1 As ASPxCheckBox = CType(Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxCheckBox1"), ASPxCheckBox)
                                If FEX = "2" Then
                                    Dim editor As ASPxHtmlEditor = CType(Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxHtmlEditor1"), ASPxHtmlEditor)
                                    Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxHtmlEditor1").Visible = True
                                    editor.ClientInstanceName = "ASPxHtmlEditor" & e.VisibleIndex
                                    editor.Html = sResultado
                                    editor.Width = 750
                                    checbox1.Checked = True

                                    If sId_Tipo = "CONSULTA" Then
                                        editor.Enabled = False
                                        checbox1.Enabled = False
                                    End If

                                ElseIf FEX = "3" Then
                                    Dim editor As ASPxHtmlEditor = CType(Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxHtmlEditor1"), ASPxHtmlEditor)
                                    Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxHtmlEditor1").Visible = False
                                    editor.ClientInstanceName = "ASPxHtmlEditor" & e.VisibleIndex
                                    checbox1.Checked = False

                                    If sId_Tipo = "CONSULTA" Then
                                        editor.Enabled = False
                                        checbox1.Enabled = False
                                    End If
                                Else
                                    Dim editor As ASPxHtmlEditor = CType(Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxHtmlEditor1"), ASPxHtmlEditor)
                                    Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxHtmlEditor1").Visible = True
                                    editor.ClientInstanceName = "ASPxHtmlEditor" & e.VisibleIndex
                                    editor.Html = sResultado
                                    editor.Width = 750
                                    checbox1.Checked = True

                                    If sId_Tipo = "CONSULTA" Then
                                        editor.Enabled = False
                                        checbox1.Enabled = False
                                    End If

                                End If
                                Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxCheckBox1").Visible = True
                            Else
                                Dim editor As ASPxHtmlEditor = CType(Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxHtmlEditor1"), ASPxHtmlEditor)
                                Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxHtmlEditor1").Visible = True
                                editor.ClientInstanceName = "ASPxHtmlEditor" & e.VisibleIndex
                                editor.Html = sResultado
                                editor.Height = 250
                                editor.Width = 750

                                If sId_Tipo = "CONSULTA" Then
                                    editor.Enabled = False
                                End If
                            End If
                    End Select

                    ''*********************************************************************
                    '''Valida si esta dentro o fuera del valor de referencia
                    If sTipo_Resultado = "NUMERICO" Or sTipo_Resultado = "NUMERICO_REFERENCIA" Or sTipo_Resultado = "FORMULA" Then
                        Dim nResultado As Double = Val(0 & e.GetValue("Resultado_defecto"))
                        Dim nReferenciaNumerico1 As Double = e.GetValue("ReferenciaNumerico1")
                        Dim nReferenciaNumerico2 As Double = e.GetValue("ReferenciaNumerico2")
                        'Dim nAlarmaMinValor As Double = e.GetValue("AlarmaMinValor")
                        'Dim nAlarmaMaxValor As Double = e.GetValue("AlarmaMaxValor")


                        '-----------------------------------------------------

                        ''If Opc_Inicial_y_Final.Checked Then
                        ''    nTiporango = 1
                        ''ElseIf Opc_No_Aplica.Checked Then
                        ''    nTiporango = 0
                        ''ElseIf Opc_Inicial_o_Final.Checked Then
                        ''    nTiporango = 2
                        ''End If

                        'valida el tipo de resultado numero a 1 es decir valida menor a mayor
                        If sTipo_Resultado = "NUMERICO_REFERENCIA" Then nTipoRango_Numerico = 1
                        If FE = "NU" Then nTipoRango_Numerico = 1

                        If nResultado <> 0 Then
                            Select Case nTipoRango_Numerico
                                Case 0
                                    'NO HACE NADA
                                Case 1
                                    bPasa = True

                                    If nReferenciaNumerico1 = 0 And nReferenciaNumerico2 = 0 Then bPasa = False
                                    'nValorMax = IIf(nReferenciaNumerico2 = 0, nResultado, nReferenciaNumerico2)
                                    'nValorMax = IIf(nReferenciaNumerico2 = 0, nResultado, nReferenciaNumerico2)
                                    If nResultado < nReferenciaNumerico1 And bPasa Then
                                        Img_Valida_Referencia.Visible = True
                                        Img_Valida_Referencia.ImageUrl = ResolveUrl("~/Resources/Images/arrow_down_blue.png")
                                        Img_Valida_Referencia.ToolTip = "El resultado es menor al rango de valor de referencia, verifique de favor !!"
                                        Img_Valida_Referencia.BackColor = Color.Yellow
                                    ElseIf nResultado > nReferenciaNumerico2 And bPasa Then
                                        Img_Valida_Referencia.Visible = True
                                        Img_Valida_Referencia.ImageUrl = ResolveUrl("~/Resources/Images/arrow_up_blue.png")
                                        Img_Valida_Referencia.ToolTip = "El resultado es mayor al rango de valor de referencia, verifique de favor !!"
                                        Img_Valida_Referencia.BackColor = Color.Yellow
                                    End If
                                    '-----------------------------------------------------------------------------------

                                Case 2
                                    ' nResultado = Val(0 & e.Row.Cells("Resultado_defecto").Value)
                                    Select Case sTipoReferencia
                                        Case "<"
                                            'nValorMax = ValorMaximo(e.Row.Cells("Resultado_defecto").Value)
                                            If nResultado > nReferenciaNumerico1 Then
                                                Img_Valida_Referencia.Visible = True
                                                Img_Valida_Referencia.ImageUrl = ResolveUrl("~/Resources/Images/arrow_up_blue.png")
                                                Img_Valida_Referencia.ToolTip = "El resultado es mayor al rango de valor de referencia, verifique de favor !!"
                                                Img_Valida_Referencia.BackColor = Color.Yellow
                                                ' ''**********************                                        
                                            End If
                                        Case ">"
                                            If nResultado < nReferenciaNumerico1 Then
                                                '**************************
                                                Img_Valida_Referencia.Visible = True
                                                Img_Valida_Referencia.ImageUrl = ResolveUrl("~/Resources/Images/arrow_down_blue.png")
                                                Img_Valida_Referencia.ToolTip = "El resultado es menor al rango de valor de referencia, verifique de favor !!"
                                                Img_Valida_Referencia.BackColor = Color.Yellow
                                            End If
                                    End Select
                            End Select
                        End If
                        '-------------------------------------------------------

                    End If

                Else
                    Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxHtmlEditor2").Visible = True
                End If

                ''*********************************************************************
                '''Tipo de resultado (Numerico, texto, etc)
                Select Case sTipo_Resultado
                    Case "NUMERICO"
                        Img_Tipo_Dato.ImageUrl = ResolveUrl("~/Resources/Images/Tipo_Resultado_Numerico.png")
                        Img_Tipo_Dato.ToolTip = "Tipo de dato Númerico"
                    Case "NUMERICO_REFERENCIA"
                        Img_Tipo_Dato.ImageUrl = ResolveUrl("~/Resources/Images/Tipo_Resultado_Numerico_referencia.png")
                        Img_Tipo_Dato.ToolTip = "Tipo de dato Númerico / Valores de referencia variable en base a edad o sexo"
                    Case "TEXTO"
                        Img_Tipo_Dato.ImageUrl = ResolveUrl("~/Resources/Images/Tipo_Resultado_Texto.png")
                        Img_Tipo_Dato.ToolTip = "Tipo de dato alfanumerico"
                    Case "MEMO"
                        Img_Tipo_Dato.ImageUrl = ResolveUrl("~/Resources/Images/Tipo_Resultado_memo.png")
                        Img_Tipo_Dato.ToolTip = "Editor de texto"
                    Case "TITULO"
                        Img_Tipo_Dato.ImageUrl = ResolveUrl("~/Resources/Images/Tipo_Resultado_Titulo.png")
                        Img_Tipo_Dato.ToolTip = "Campo sin editar / Tipo titulo de reporte"
                    Case "FORMULA"
                        Img_Tipo_Dato.ImageUrl = ResolveUrl("~/Resources/Images/Tipo_Resultado_Formula.png")
                        Img_Tipo_Dato.ToolTip = "Tipo de dato calculado"
                End Select



                ''*********************************************************************
                '''Esta interfazado
                If bEs_Interfazado Then
                    Img_Interfazado.Visible = True
                    Img_Interfazado.ImageUrl = ResolveUrl("~/Resources/Images/Demo_Audit_Modes.png")
                    Img_Interfazado.ToolTip = "Interfazado"
                Else
                    Img_Interfazado.Visible = False
                    ' Img_Interfazado.ImageUrl = ResolveUrl("~/Resources/Images/E_SOLICITUD.png")
                End If

                ''*********************************************************************
                '''Estatus
                If sEstatus = "SOLICITUD" Then
                    Img.ImageUrl = ResolveUrl("~/Resources/Images/E_SOLICITUD.png")
                ElseIf sEstatus = "CANCELADO" Then
                    Img.ImageUrl = ResolveUrl("~/Resources/Images/E_CANCELADO.png")
                ElseIf sEstatus = "EDICION" Then
                    Img.ImageUrl = ResolveUrl("~/Resources/Images/E_EDICION.png")
                ElseIf sEstatus = "VALIDACION" Then
                    Img.ImageUrl = ResolveUrl("~/Resources/Images/E_VALIDACION.png")
                ElseIf sEstatus = "IMPRESO" Then
                    Img.ImageUrl = ResolveUrl("~/Resources/Images/E_IMPRESO.png")
                ElseIf sEstatus = "ENTREGADO" Then
                    Img.ImageUrl = ResolveUrl("~/Resources/Images/E_Entregado.png")
                End If

                'If sTipo_Resultado = "CULTIVO" Then
                '    If FE = "1" Then
                '        If FEX = "3" Then
                '            Page.ClientScript.RegisterStartupScript(Me.GetType(), "checkbox", "0", True)
                '        End If
                '    End If
                'End If
            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Sub





    Sub Guardar()
        Dim bPasa As Boolean
        Dim subestudio, sFormatoE, sFolio, sCve_Sucursal, sEstatus, sTipo_Resultado, sCve_Estudio, sCve_SubEstudio, sResultado, sReferenciaTexto, sReferenciaTexto2, sReferenciaNumerico1, sReferenciaNumerico2, sAlarmaMinValor, sAlarmaMaxValor, sTipoImagenReporteResultado, sTipoResultadoEstatus_Imagen, sTipoReferencia, sTipoRango_Numerico, sNum_Digitos, sCve_Perfil, sformula As String
        Dim sFolio1, sCve_Estudio1, sCve_Perfil1 As String


        If ASPxGridView1.VisibleRowCount = 0 Then Exit Sub
        Me.ASPxGridView1.FocusedRowIndex = 0


        For i As Integer = 0 To ASPxGridView1.VisibleRowCount - 1


            bGuardo = False

            If Me.ASPxGridView1.IsGroupRow(i) = False Then
                sEstatus = ASPxGridView1.GetRowValues(i, "Estatus")

                If sEstatus = "SOLICITUD" Or sEstatus = "EDICION" Then

                    sFolio = ASPxGridView1.GetRowValues(i, "Folio")
                    sCve_Sucursal = ASPxGridView1.GetRowValues(i, "Cve_Sucursal")
                    sTipo_Resultado = ASPxGridView1.GetRowValues(i, "Tipo_Resultado")
                    sCve_Estudio = ASPxGridView1.GetRowValues(i, "Cve_Estudio")
                    sCve_SubEstudio = ASPxGridView1.GetRowValues(i, "Cve_SubEstudio")
                    sCve_Perfil = ASPxGridView1.GetRowValues(i, "Cve_Perfil")
                    If Not IsDBNull(ASPxGridView1.GetRowValues(i, "Resultado_defecto")) Then
                        sResultado = ASPxGridView1.GetRowValues(i, "Resultado_defecto")
                    End If
                    sReferenciaTexto = ASPxGridView1.GetRowValues(i, "ReferenciaTexto")
                    sReferenciaTexto2 = ASPxGridView1.GetRowValues(i, "ReferenciaTexto2")
                    sReferenciaNumerico1 = ASPxGridView1.GetRowValues(i, "ReferenciaNumerico1")
                    sReferenciaNumerico2 = ASPxGridView1.GetRowValues(i, "ReferenciaNumerico2")
                    sAlarmaMinValor = ASPxGridView1.GetRowValues(i, "AlarmaMinValor")
                    sAlarmaMaxValor = ASPxGridView1.GetRowValues(i, "AlarmaMaxValor")
                    sTipoImagenReporteResultado = ASPxGridView1.GetRowValues(i, "TipoImagenReporteResultado")
                    sTipoResultadoEstatus_Imagen = ASPxGridView1.GetRowValues(i, "TipoResultadoEstatus_Imagen")
                    sTipoReferencia = ASPxGridView1.GetRowValues(i, "TipoReferencia")
                    sTipoRango_Numerico = ASPxGridView1.GetRowValues(i, "TipoRango_Numerico")
                    sformula = ASPxGridView1.GetRowValues(i, "Referencia_Formula")
                    sNum_Digitos = ASPxGridView1.GetRowValues(i, "Num_Digitos")
                    sFormatoE = ASPxGridView1.GetRowValues(i, "FormatoEspecial")
                    subestudio = ASPxGridView1.GetRowValues(i, "SubEstudio")

                    bPasa = True

                    Select Case sTipo_Resultado
                        Case "NUMERICO", "NUMERICO_REFERENCIA", "UPC"
                            Dim editor As ASPxSpinEdit = CType(Me.ASPxGridView1.FindRowCellTemplateControl(i, Nothing, "ASPxSpinEdit1"), ASPxSpinEdit)
                            sResultado = editor.Value
                        Case "TEXTO"
                            '****************************
                            If CType(Me.ASPxGridView1.FindRowCellTemplateControl(i, Nothing, "ASPxComboBox1"), ASPxComboBox).IsVisible Then
                                Dim iASPxComboBox1 As ASPxComboBox = CType(Me.ASPxGridView1.FindRowCellTemplateControl(i, Nothing, "ASPxComboBox1"), ASPxComboBox) 'CType(Me.ASPxGridView1.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxComboBox1"), ASPxComboBox)
                                sResultado = iASPxComboBox1.Text
                                '****************************             
                            Else
                                Dim editor As ASPxMemo = CType(Me.ASPxGridView1.FindRowCellTemplateControl(i, Nothing, "ASPxMemo1"), ASPxMemo)
                                sResultado = editor.Value
                            End If

                        Case "MEMO"
                            Dim editor As ASPxHtmlEditor = CType(Me.ASPxGridView1.FindRowCellTemplateControl(i, Nothing, "ASPxHtmlEditor1"), ASPxHtmlEditor)
                            sResultado = editor.Html
                            '------------------
                        Case "TITULO"
                            sResultado = Nothing

                        Case "FORMULA"
                            Dim iASPxLabel As ASPxLabel = CType(Me.ASPxGridView1.FindRowCellTemplateControl(i, Nothing, "ASPxLabel1"), ASPxLabel)
                            '  sResultado = iASPxLabel.Text
                            bPasa = True
                        Case "CULTIVO"
                            If sFormatoE = "1" Then
                                Dim editor As ASPxHtmlEditor = CType(Me.ASPxGridView1.FindRowCellTemplateControl(i, Nothing, "ASPxHtmlEditor1"), ASPxHtmlEditor)
                                Dim checbox1 As ASPxCheckBox = CType(Me.ASPxGridView1.FindRowCellTemplateControl(i, Nothing, "ASPxCheckBox1"), ASPxCheckBox)
                                sResultado = editor.Html
                                If checbox1.Checked = True Then
                                    sTipoReferencia = "2"
                                Else
                                    sTipoReferencia = "3"
                                End If
                                sResultado = editor.Html
                            Else
                                Dim editor As ASPxHtmlEditor = CType(Me.ASPxGridView1.FindRowCellTemplateControl(i, Nothing, "ASPxHtmlEditor1"), ASPxHtmlEditor)
                                sResultado = editor.Html
                            End If
                        Case "CULTIVO 3 COLUMNAS"
                            If sFormatoE = "1" Then
                                Dim editor As ASPxHtmlEditor = CType(Me.ASPxGridView1.FindRowCellTemplateControl(i, Nothing, "ASPxHtmlEditor1"), ASPxHtmlEditor)
                                Dim checbox1 As ASPxCheckBox = CType(Me.ASPxGridView1.FindRowCellTemplateControl(i, Nothing, "ASPxCheckBox1"), ASPxCheckBox)
                                sResultado = editor.Html
                                If checbox1.Checked = True Then
                                    sTipoReferencia = "2"
                                Else
                                    sTipoReferencia = "3"
                                End If
                                sResultado = editor.Html
                            Else
                                Dim editor As ASPxHtmlEditor = CType(Me.ASPxGridView1.FindRowCellTemplateControl(i, Nothing, "ASPxHtmlEditor1"), ASPxHtmlEditor)
                                sResultado = editor.Html
                            End If
                    End Select


                    If bPasa Then
                        If Guardar_Elemento(sEstatus, sFolio, sCve_Sucursal, sCve_Estudio, sCve_SubEstudio, sResultado, sTipo_Resultado, sReferenciaTexto, sReferenciaTexto2, sReferenciaNumerico1, sReferenciaNumerico2, sAlarmaMinValor, sAlarmaMaxValor, sTipoImagenReporteResultado, sTipoResultadoEstatus_Imagen, sTipoReferencia, sTipoRango_Numerico, sNum_Digitos, i) Then
                            bGuardo = True
                            '---------------------------------
                            If (sCve_Estudio1 <> sCve_Estudio Or sFolio1 <> sFolio) Then
                                If sCve_Perfil = "0" Then
                                    sCve_Estudio1 = sCve_Estudio
                                    sFolio1 = sFolio
                                    'oFunciones.Cambiar_Estatus(sFolio1, sCve_Estudio1, sCve_Sucursal, "EDICION")
                                    '-------------------------
                                    'If Grid_Solicitudes.CurrentLayout.Key = "SOLICITUDES_ESTUDIOS" Then
                                    '    oFunciones.Cambiar_Estatus(sFolio, sCve_Sucursal, sCve_Estudio)
                                    'End If
                                    '-------------------------
                                End If
                            End If
                            'If sCve_Perfil <> row.Cells("Cve_Perfil").Value Then
                            If (sCve_Perfil1 <> sCve_Perfil Or sFolio1 <> sFolio) Then ' Or sCve_Sucursal <> Row.Cells("Cve_Sucursal").Value) Then
                                If sCve_Perfil <> "0" Then
                                    sCve_Perfil1 = sCve_Perfil
                                    'sCve_Sucursal = Row.Cells("Cve_Sucursal").Value
                                    sFolio1 = sFolio

                                    ' Cambiar_Estatus(Row.Cells("Folio").Value, sCve_Perfil, "EDICION", sCve_Sucursal)
                                    'oFunciones.Cambiar_Estatus(sFolio1, sCve_Perfil1, sCve_Sucursal, "EDICION")
                                    '-------------------------
                                    'If Grid_Solicitudes.CurrentLayout.Key = "SOLICITUDES_ESTUDIOS" Then
                                    '    Actualizar_Estatus(sFolio, sCve_Sucursal, sCve_Perfil)
                                    'End If
                                    '-------------------------
                                End If
                            End If
                            '---------------------------------
                        End If
                    End If
                End If
            End If
        Next i

        'If bGuardo Then
        '    Me.DataBind()
        'End If

    End Sub

    'Protected Sub OnCallback(ByVal source As Object, ByVal e As DevExpress.Web.CallbackEventArgsBase)
    '    If e.Parameter = "0" Then 'Guardar Then --0 y 3
    '        Guardar()
    '    ElseIf e.Parameter = "3" Then 'Actualizar Then
    '    End If
    'End Sub
    Protected Sub grid_CustomCallback(ByVal source As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomCallbackEventArgs)

        If e.Parameters = "0" Then 'Guardar Then
            '0'grid.DataBind()
            Guardar()
            'Me.U
        ElseIf e.Parameters = "1" Then 'Calcular Then
            DataBind()
        ElseIf e.Parameters = "2" Then 'Imprimir Then
        ElseIf e.Parameters = "3" Then 'Actualizar Then
            Me.DataBind()
        ElseIf e.Parameters = "4" Then 'Nuevo Then
        End If
    End Sub


    Function Guardar_Elemento(ByVal sEstatus As String, ByVal sFolio As String, ByVal sClue As String, ByVal sCve_Estudio As String, ByVal sCve_SubEstudio As String, ByVal sResultado As String, ByVal sTipo_Resultado As String, ByVal sReferenciaTexto As String, ByVal sReferenciaTexto2 As String, ByVal sReferenciaNumerico1 As String, ByVal sReferenciaNumerico2 As String, ByVal sAlarmaMinValor As String, ByVal sAlarmaMaxValor As String, ByVal sTipoImagenReporteResultado As String, ByVal sTipoResultadoEstatus_Imagen As String, ByVal sTipoReferencia As String, ByVal sTipoRango_Numerico As String, ByVal sNum_Digitos As String, ByVal nRow As Integer) As Boolean

        Dim ParametersX_Global() As System.Data.SqlClient.SqlParameter

        If sEstatus = "EDICION" Or sEstatus = "SOLICITUD" Then
            ReDim ParametersX_Global(17)
            ParametersX_Global(0) = New SqlClient.SqlParameter("@Folio", sFolio)
            'ParametersX_Global(1) = New SqlClient.SqlParameter("@Cve_Sucursal", sClue)
            ParametersX_Global(2) = New SqlClient.SqlParameter("@Cve_Estudio", sCve_Estudio)
            ParametersX_Global(3) = New SqlClient.SqlParameter("@Cve_SubEstudio", sCve_SubEstudio)
            ParametersX_Global(4) = New SqlClient.SqlParameter("@Resultado", sResultado)
            ParametersX_Global(5) = New SqlClient.SqlParameter("@Tipo_Resultado", sTipo_Resultado)
            ParametersX_Global(6) = New SqlClient.SqlParameter("@ReferenciaTexto", sReferenciaTexto)
            ParametersX_Global(7) = New SqlClient.SqlParameter("@ReferenciaTexto2", sReferenciaTexto2)
            ParametersX_Global(8) = New SqlClient.SqlParameter("@ReferenciaNumerico1", sReferenciaNumerico1)
            ParametersX_Global(9) = New SqlClient.SqlParameter("@ReferenciaNumerico2", sReferenciaNumerico2)
            ParametersX_Global(10) = New SqlClient.SqlParameter("@AlarmaMinValor", sAlarmaMinValor)
            ParametersX_Global(11) = New SqlClient.SqlParameter("@AlarmaMaxValor", sAlarmaMaxValor)
            ParametersX_Global(12) = New SqlClient.SqlParameter("@TipoImagenReporteResultado", sTipoImagenReporteResultado)
            'ParametersX_Global(12) = New SqlClient.SqlParameter("@TipoResultadoEstatus_Imagen", row.Cells("TipoResultadoEstatus_Imagen").ImageIndex)
            ParametersX_Global(13) = New SqlClient.SqlParameter("@TipoResultadoEstatus_Imagen", sTipoResultadoEstatus_Imagen)
            ParametersX_Global(14) = New SqlClient.SqlParameter("@TipoReferencia", sTipoReferencia)
            ParametersX_Global(15) = New SqlClient.SqlParameter("@TipoRango_Numerico", sTipoRango_Numerico)
            ParametersX_Global(16) = New SqlClient.SqlParameter("@Num_Digitos", sNum_Digitos)
            ParametersX_Global(17) = New SqlClient.SqlParameter("@cve_Operador", sOperador)
            If oFunciones.fGuardar_O_EliminarXProcedure("pPACIENTES_SOLICITUDES_RESULTADOS_G", "@Parametro", ParametersX_Global, False) Then
                Return True
            End If
        End If
    End Function

End Class