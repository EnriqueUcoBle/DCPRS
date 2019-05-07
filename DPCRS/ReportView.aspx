<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ReportView.aspx.vb" Inherits="DPCRS.ReportView" %>

<%@ Register assembly="DevExpress.XtraReports.v17.2.Web, Version=17.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraReports.Web" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.v17.2, Version=17.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Data.v17.2, Version=17.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <script type="text/javascript">
        function Report_CategoryClick(Report_ID, sID) {
            //popup.SetContentUrl("~/ReportView_Polizas.aspx?Report_ID=" + Report_ID + "&sID=" + sID);
            //popup.SetContentUrl('~/ReportView_Polizas.aspx?' + 'Report_ID=' + Report_ID + '&sID=' + sID);
            //popup.SetContentUrl('WebForm1.aspx?' + 'name=' + sender.name);
            //popup.SetContentUrl("Capturar_Resultados.aspx?Folio=" & sFolio & "&Area=" & Areas);
            // popup.ShowAtElement()
            //popup.cpPopup.PerformCallback(Report_ID, sID);
            cpPopup.PerformCallback("ReportView_Polizas.aspx?Report_ID=" + Report_ID + "&sID=" + sID);            
            popup.Show();
            //  
		}
	</script>

</head>
<body> 
    <%--<div style="Height:100% ; Width:100%" >
    <form id="form1" runat="server" style="position: absolute; left: 10%">--%>
       

    <form id="form1" runat="server">
	<div> 
         
   </div>
     <%--</div>--%>
        <dx:ASPxDocumentViewer ID="ASPxDocumentViewer1" runat="server">
        </dx:ASPxDocumentViewer>
	</form>
     </body>
</html>
