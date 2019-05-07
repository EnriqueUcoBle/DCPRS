<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Capturar_Resultados.aspx.vb" Inherits="DPCRS.Capturar_Resultados" %>


<%@ Register assembly="DevExpress.Web.v16.1, Version=16.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxHtmlEditor.v16.1, Version=16.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxHtmlEditor" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxSpellChecker.v16.1, Version=16.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSpellChecker" tagprefix="dx" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" ><head id="Head1" runat="server">
                        

<style type="text/css">
                                                                                                                                                                                                                        .style1
        {
                        width: 5%;
        }
     
        .style2
        {
            width: 100%;
        }
        
                                                                                                                                                                                                    {
                                                                                                                                                                                                                            width: 440px;
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                     
    </style><title></title>

         <script type="text/javascript">
             function SmartGaugeBox_feedData(strLabel, strValue) {
                 //callbackPanel.PerformCallback(strValue);
                 grid.PerformCallback(strValue);
                 // alert(" strLabel = " + strLabel + " strValue = " + strValue);
             }

             function Actualizar_Solo(strLabel, strValue) {
                      grid.PerformCallback(strValue);
                 // alert(" strLabel = " + strLabel + " strValue = " + strValue);
             }
            
                                                         
                        
            
             
    </script>                                                                                                                                                                                                              
                                                                                                                                                                                                                        </head>
    <form id="form1" runat="server" submitdisabledcontrols="False">
    <div>
   

     <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" 
            ClientInstanceName="grid" 
             OnCustomUnboundColumnData="grid_CustomUnboundColumnData"
           
             OnCustomCallback="grid_CustomCallback"
            KeyboardSupport="True" KeyFieldName="CompositeKey" 
            DataSourceID="SqlDataSource1" EnableCallbackAnimation="True" EnableViewState="False">
<SettingsCustomizationWindow PopupHorizontalAlign="RightSides" PopupVerticalAlign="BottomSides"></SettingsCustomizationWindow>

            <settingsbehavior allowgroup="False" allowsort="False" 
                autoexpandallgroups="True" AllowFocusedRow="True" 
             AllowSelectSingleRowOnly="True" AllowDragDrop="False" SelectionStoringMode="PerformanceOptimized" />




<SettingsCommandButton>
<ShowAdaptiveDetailButton ButtonType="Image"></ShowAdaptiveDetailButton>

<HideAdaptiveDetailButton ButtonType="Image"></HideAdaptiveDetailButton>
</SettingsCommandButton>




         <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />




            <Styles>
                <GroupRow BackColor="#FFFF99">
                </GroupRow>
         </Styles>

            <SettingsPager Mode="ShowAllRecords" >

            </SettingsPager>
            <groupsummary>
                <dx:ASPxSummaryItem FieldName="Folio" />
                <dx:ASPxSummaryItem FieldName="Cve_Estudio" />
            </groupsummary>


            <SettingsLoadingPanel Mode="ShowAsPopup" />


            <Columns>
                <dx:GridViewDataTextColumn 
                    VisibleIndex="1">
                    <DataItemTemplate>
                        <dx:ASPxImage ID="imgEstatus" runat="server">
                        </dx:ASPxImage>
                    </DataItemTemplate>

                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Folio" ReadOnly="True" 
                    SortOrder="Ascending" VisibleIndex="4" Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Cve_Estudio" ReadOnly="True" 
                    VisibleIndex="8" SortOrder="Ascending" 
                    Visible="False" Caption="Clave">
                  
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Estudio" ReadOnly="True" 
                    VisibleIndex="9" Visible="False" GroupIndex="2" 
                    SortOrder="Ascending">
                    <Settings AllowGroup="True" />
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Cve_SubEstudio" ReadOnly="True" 
                    VisibleIndex="2" Caption="Clave" Visible="False">
                    <Settings AllowGroup="True" />
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="SubEstudio" ReadOnly="True" 
                    VisibleIndex="3" Caption="Elemento">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Resultado_defecto" ReadOnly="True" 
                    VisibleIndex="10" Caption="Resultado">
                    <dataitemtemplate>
                        <dx:ASPxMemo ID="ASPxMemo1" runat="server"  Width="200px" 
                                Value='<%#Eval("Resultado_defecto")%>' Height="50px" 
                              Visible="False">                            
                        </dx:ASPxMemo>
                        
                        <dx:ASPxSpinEdit ID="ASPxSpinEdit1" runat="server"  Number="0"             
                        Width="200px" Visible="False"                         
                        Value='<%#Eval("Resultado_defecto")%>' MaxLength="12" 
                            AutoResizeWithContainer="True" AllowMouseWheel="False"  >                    
                        
                                               
                            <SpinButtons ShowIncrementButtons="False">
                            </SpinButtons>
                        
                                               
                        </dx:ASPxSpinEdit>
                        
                        <dx:ASPxHtmlEditor ID="ASPxHtmlEditor1" runat="server" Visible="False"  Width="500px"
                        html='<%# Eval("Resultado_defecto") %>' Height="400px" ClientInstanceName="ASPxHtmlEditor"  >                               
                            <Toolbars>
                                <dx:HtmlEditorToolbar>
                                    <Items>
                                        <dx:ToolbarCutButton>
                                        </dx:ToolbarCutButton>
                                        <dx:ToolbarCopyButton>
                                        </dx:ToolbarCopyButton>
                                        <dx:ToolbarPasteButton>
                                        </dx:ToolbarPasteButton>
                                        <dx:ToolbarPasteFromWordButton>
                                        </dx:ToolbarPasteFromWordButton>
                                        <dx:ToolbarUndoButton BeginGroup="True">
                                        </dx:ToolbarUndoButton>
                                        <dx:ToolbarRedoButton>
                                        </dx:ToolbarRedoButton>
                                        <dx:ToolbarRemoveFormatButton BeginGroup="True">
                                        </dx:ToolbarRemoveFormatButton>
                                        <dx:ToolbarSuperscriptButton BeginGroup="True">
                                        </dx:ToolbarSuperscriptButton>
                                        <dx:ToolbarSubscriptButton>
                                        </dx:ToolbarSubscriptButton>
                                        <dx:ToolbarInsertOrderedListButton BeginGroup="True">
                                        </dx:ToolbarInsertOrderedListButton>
                                        <dx:ToolbarInsertUnorderedListButton>
                                        </dx:ToolbarInsertUnorderedListButton>
                                        <dx:ToolbarIndentButton BeginGroup="True">
                                        </dx:ToolbarIndentButton>
                                        <dx:ToolbarOutdentButton>
                                        </dx:ToolbarOutdentButton>
                                        <dx:ToolbarInsertLinkDialogButton BeginGroup="True">
                                        </dx:ToolbarInsertLinkDialogButton>
                                        <dx:ToolbarUnlinkButton BeginGroup="True">
                                        </dx:ToolbarUnlinkButton>
                                        <dx:ToolbarTableOperationsDropDownButton BeginGroup="True">
                                            <Items>
                                                <dx:ToolbarInsertTableDialogButton BeginGroup="True" Text="Insert Table..." ToolTip="Insert Table...">
                                                </dx:ToolbarInsertTableDialogButton>
                                                <dx:ToolbarTablePropertiesDialogButton BeginGroup="True">
                                                </dx:ToolbarTablePropertiesDialogButton>
                                                <dx:ToolbarTableRowPropertiesDialogButton>
                                                </dx:ToolbarTableRowPropertiesDialogButton>
                                                <dx:ToolbarTableColumnPropertiesDialogButton>
                                                </dx:ToolbarTableColumnPropertiesDialogButton>
                                                <dx:ToolbarTableCellPropertiesDialogButton>
                                                </dx:ToolbarTableCellPropertiesDialogButton>
                                                <dx:ToolbarInsertTableRowAboveButton BeginGroup="True">
                                                </dx:ToolbarInsertTableRowAboveButton>
                                                <dx:ToolbarInsertTableRowBelowButton>
                                                </dx:ToolbarInsertTableRowBelowButton>
                                                <dx:ToolbarInsertTableColumnToLeftButton>
                                                </dx:ToolbarInsertTableColumnToLeftButton>
                                                <dx:ToolbarInsertTableColumnToRightButton>
                                                </dx:ToolbarInsertTableColumnToRightButton>
                                                <dx:ToolbarSplitTableCellHorizontallyButton BeginGroup="True">
                                                </dx:ToolbarSplitTableCellHorizontallyButton>
                                                <dx:ToolbarSplitTableCellVerticallyButton>
                                                </dx:ToolbarSplitTableCellVerticallyButton>
                                                <dx:ToolbarMergeTableCellRightButton>
                                                </dx:ToolbarMergeTableCellRightButton>
                                                <dx:ToolbarMergeTableCellDownButton>
                                                </dx:ToolbarMergeTableCellDownButton>
                                                <dx:ToolbarDeleteTableButton BeginGroup="True">
                                                </dx:ToolbarDeleteTableButton>
                                                <dx:ToolbarDeleteTableRowButton>
                                                </dx:ToolbarDeleteTableRowButton>
                                                <dx:ToolbarDeleteTableColumnButton>
                                                </dx:ToolbarDeleteTableColumnButton>
                                            </Items>
                                        </dx:ToolbarTableOperationsDropDownButton>
                                        <dx:ToolbarExportDropDownButton BeginGroup="True">
                                            <Items>
                                                <dx:ToolbarExportDropDownItem>
                                                </dx:ToolbarExportDropDownItem>
                                                <dx:ToolbarExportDropDownItem Format="Pdf">
                                                </dx:ToolbarExportDropDownItem>
                                                <dx:ToolbarExportDropDownItem Format="Txt">
                                                </dx:ToolbarExportDropDownItem>
                                                <dx:ToolbarExportDropDownItem Format="Docx">
                                                </dx:ToolbarExportDropDownItem>
                                                <dx:ToolbarExportDropDownItem Format="Odt">
                                                </dx:ToolbarExportDropDownItem>
                                                <dx:ToolbarExportDropDownItem Format="Mht">
                                                </dx:ToolbarExportDropDownItem>
                                            </Items>
                                        </dx:ToolbarExportDropDownButton>
                                        <dx:ToolbarPrintButton>
                                        </dx:ToolbarPrintButton>
                                        <dx:ToolbarFullscreenButton BeginGroup="True">
                                        </dx:ToolbarFullscreenButton>
                                    </Items>
                                </dx:HtmlEditorToolbar>
                                <dx:HtmlEditorToolbar>
                                    <Items>
                                        <dx:ToolbarParagraphFormattingEdit Width="120px">
                                            <Items>
                                                <dx:ToolbarListEditItem Text="Normal" Value="p" />
                                                <dx:ToolbarListEditItem Text="Heading  1" Value="h1" />
                                                <dx:ToolbarListEditItem Text="Heading  2" Value="h2" />
                                                <dx:ToolbarListEditItem Text="Heading  3" Value="h3" />
                                                <dx:ToolbarListEditItem Text="Heading  4" Value="h4" />
                                                <dx:ToolbarListEditItem Text="Heading  5" Value="h5" />
                                                <dx:ToolbarListEditItem Text="Heading  6" Value="h6" />
                                                <dx:ToolbarListEditItem Text="Address" Value="address" />
                                                <dx:ToolbarListEditItem Text="Normal (DIV)" Value="div" />
                                            </Items>
                                        </dx:ToolbarParagraphFormattingEdit>
                                        <dx:ToolbarFontNameEdit>
                                            <Items>
                                                <dx:ToolbarListEditItem Text="Times New Roman" Value="Times New Roman" />
                                                <dx:ToolbarListEditItem Text="Tahoma" Value="Tahoma" />
                                                <dx:ToolbarListEditItem Text="Verdana" Value="Verdana" />
                                                <dx:ToolbarListEditItem Text="Arial" Value="Arial" />
                                                <dx:ToolbarListEditItem Text="MS Sans Serif" Value="MS Sans Serif" />
                                                <dx:ToolbarListEditItem Text="Courier" Value="Courier" />
                                                <dx:ToolbarListEditItem Text="Segoe UI" Value="Segoe UI" />
                                            </Items>
                                        </dx:ToolbarFontNameEdit>
                                        <dx:ToolbarFontSizeEdit>
                                            <Items>
                                                <dx:ToolbarListEditItem Text="1 (8pt)" Value="1" />
                                                <dx:ToolbarListEditItem Text="2 (10pt)" Value="2" />
                                                <dx:ToolbarListEditItem Text="3 (12pt)" Value="3" />
                                                <dx:ToolbarListEditItem Text="4 (14pt)" Value="4" />
                                                <dx:ToolbarListEditItem Text="5 (18pt)" Value="5" />
                                                <dx:ToolbarListEditItem Text="6 (24pt)" Value="6" />
                                                <dx:ToolbarListEditItem Text="7 (36pt)" Value="7" />
                                            </Items>
                                        </dx:ToolbarFontSizeEdit>
                                        <dx:ToolbarBoldButton BeginGroup="True">
                                        </dx:ToolbarBoldButton>
                                        <dx:ToolbarItalicButton>
                                        </dx:ToolbarItalicButton>
                                        <dx:ToolbarUnderlineButton>
                                        </dx:ToolbarUnderlineButton>
                                        <dx:ToolbarStrikethroughButton>
                                        </dx:ToolbarStrikethroughButton>
                                        <dx:ToolbarJustifyLeftButton BeginGroup="True">
                                        </dx:ToolbarJustifyLeftButton>
                                        <dx:ToolbarJustifyCenterButton>
                                        </dx:ToolbarJustifyCenterButton>
                                        <dx:ToolbarJustifyRightButton>
                                        </dx:ToolbarJustifyRightButton>
                                        <dx:ToolbarJustifyFullButton>
                                        </dx:ToolbarJustifyFullButton>
                                        <dx:ToolbarBackColorButton BeginGroup="True">
                                        </dx:ToolbarBackColorButton>
                                        <dx:ToolbarFontColorButton>
                                        </dx:ToolbarFontColorButton>
                                    </Items>
                                </dx:HtmlEditorToolbar>
                        
                            </Toolbars>
                          
                            <Settings AllowHtmlView="False" AllowPreview="False" AllowCustomColorsInColorPickers="True" AllowScriptExecutionInPreview="True"  />                               
                            <SettingsHtmlEditing AllowFormElements="True" AllowHTML5MediaElements="True" AllowIFrames="True" AllowObjectAndEmbedElements="True" AllowScripts="True" EnablePasteOptions="True" EnterMode="BR" PasteMode="MergeFormatting" UseAbsoluteResourcePaths="True" AllowedDocumentType="Both">
                            </SettingsHtmlEditing>
                            <SettingsResize AllowResize="True" />
                        </dx:ASPxHtmlEditor>
                        
                           <dx:ASPxCheckBox ID="ASPxCheckBox1" runat="server"   Text="Aplica Tabla" CheckState="Unchecked" EnableClientSideAPI="True" ClientInstanceName="Aplica_Tabla">
                               <ClientSideEvents ValueChanged="function(s, e) {
                                            var index = grid.GetFocusedRowIndex();
                                                              
      if (s.GetChecked() ) { 
               eval('ASPxHtmlEditor' + index.toString()).SetClientVisible(true);
                            
             }    else
                                   { 
               eval('ASPxHtmlEditor' + index.toString()).SetClientVisible(false);
                             
             }    
                                 
       }" />
                        </dx:ASPxCheckBox>
                        
                           <dx:ASPxComboBox ID="ASPxComboBox1" runat="server" Width="200"
                            ClientInstanceName="cComboResultado" DropDownStyle="DropDown" 
                       
                            IncrementalFilteringMode="Contains" ValueType="System.String" Visible="False">
                        </dx:ASPxComboBox>
                        
                           <dx:ASPxHtmlEditor ID="ASPxHtmlEditor2" runat="server" Visible="False"  Width="200"
                        html='<%# Eval("Resultado_defecto") %>' Height="60px" ActiveView="Preview" >                               
                               
                            <Settings AllowHtmlView="False" AllowPreview="True" AllowContextMenu="False" 
                                   AllowDesignView="False" AllowInsertDirectImageUrls="False"  />                               
                              
                        </dx:ASPxHtmlEditor>
                        
                        <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Titulo" Width="200" Visible="False"
                           Value='<%#Eval("Resultado_defecto")%>'               
                        >
                        </dx:ASPxLabel>
                    </dataitemtemplate>

                   

                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Unidad" ReadOnly="True" 
                    VisibleIndex="14">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Orden" ReadOnly="True" SortOrder="Ascending" 
                    VisibleIndex="18" Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Tipo_Resultado" ReadOnly="True" 
                    VisibleIndex="15" Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="ReferenciaTexto" ReadOnly="True" 
                    VisibleIndex="16" Caption="Valor Referencia">
                </dx:GridViewDataTextColumn>
               
                <dx:GridViewDataTextColumn FieldName="TipoReferencia" ReadOnly="True" 
                    VisibleIndex="19" Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="TipoRango_Numerico" ReadOnly="True" 
                    VisibleIndex="20" Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Tipo_Validacion_Texto" ReadOnly="True" 
                    VisibleIndex="21" Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Num_Digitos" ReadOnly="True" 
                    VisibleIndex="30" Caption="Num. digitos">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="TipoImagenReporteResultado" 
                    ReadOnly="True" VisibleIndex="28" Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="TipoResultadoEstatus_Imagen" 
                    ReadOnly="True" VisibleIndex="27" Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Estatus" ReadOnly="True" 
                    VisibleIndex="22" Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="TieneValidacionTexto_Combo" 
                    ReadOnly="True" VisibleIndex="23" Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="FormatoString" ReadOnly="True" 
                    VisibleIndex="24" Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="CompositeKey" UnboundType="String" 
                    VisibleIndex="25" Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewBandColumn Caption="Rangos validos" VisibleIndex="26">
                    <Columns>
                        <dx:GridViewDataTextColumn Caption="Ref 1" FieldName="ReferenciaNumerico1" 
                    VisibleIndex="5" ReadOnly="True">
                            <PropertiesTextEdit DisplayFormatString="n2">
                            </PropertiesTextEdit>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="ReferenciaNumerico2" ReadOnly="True" 
                    VisibleIndex="6" Caption="Ref 2">
                    <PropertiesTextEdit DisplayFormatString="n2">
                    </PropertiesTextEdit>
                </dx:GridViewDataTextColumn>
              
                    </Columns>
                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </dx:GridViewBandColumn>
  
                <dx:GridViewDataTextColumn Caption="Cve_Perfil" FieldName="Cve_Perfil" 
                    VisibleIndex="31" Visible="False">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Area" FieldName="Area" GroupIndex="0" 
                    SortOrder="Ascending"  SortIndex="1" VisibleIndex="32">
                    <Settings AllowGroup="True" />
                    <GroupFooterCellStyle BackColor="#FF0066">
                    </GroupFooterCellStyle>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn VisibleIndex="11">
                    <DataItemTemplate>
                        <table class="style2">
                            <tr>
                                <td>
                                    <dx:ASPxImage ID="cImage_Tipo_Dato" runat="server" /> </dx:ASPxImage>
                                </td>
                                <td>
                                    <dx:ASPxImage ID="cImage_Valida_Referencia" runat="server" /> </dx:ASPxImage>
                                </td>
                                 <td>
                                    <dx:ASPxImage ID="cInterfazado" runat="server" /> </dx:ASPxImage>
                                </td>
                            </tr>
                        </table>
                    </DataItemTemplate>
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Indice" VisibleIndex="0" GroupIndex="1" SortOrder="Ascending" SortIndex="0" ReadOnly="True">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Valor Refencia SUI" FieldName="ReferenciaTexto2" ReadOnly="True" VisibleIndex="17">
                </dx:GridViewDataTextColumn>
            </Columns>


         <Settings GridLines="Horizontal" ShowGroupButtons="False" 
             VerticalScrollableHeight="600" />


         <SettingsDetail ShowDetailButtons="False" />


        </dx:ASPxGridView>

    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:DPCRSConnectionString %>" 
        SelectCommand="pPACIENTES_SOLICITUDES_RESULTADOS_CAPTURA" 
        SelectCommandType="StoredProcedure" DataSourceMode="DataReader">

    </asp:SqlDataSource>
 
    </form>

</html>
