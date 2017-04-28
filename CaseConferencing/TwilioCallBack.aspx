<%@ Page Language="c#" Codebehind="TwilioCallBack.aspx.cs" AutoEventWireup="false" Inherits="ssCaseConferencing.Flows.FlowCommon.ScrnTwilioCallBack" %><%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %><%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %><%@ Import namespace="ssCaseConferencing" %><%@ Import namespace="OutSystems.HubEdition.RuntimePlatform" %><%@ Register TagPrefix="ThemeProvider_widgets" TagName="Ky1nG5kdyhEesTpKvn40S7g" Src="Blocks\CaseConferencing\MainLayouts\Layout_Main.ascx" %>
<%= CaseConferencing_Properties.DocType %>
<html xmlns="http://www.w3.org/1999/xhtml" >
  <head runat="server"><%= GetHeadTopJavaScript() %>
	<title><%= HttpUtility.HtmlEncode (Title) %></title>
    <meta http-equiv="Content-Type" content="<%= "text/html; charset=" + Response.ContentEncoding.WebName %>" />
    <meta http-equiv="Content-Script-Type" content="text/javascript" />
    <meta http-equiv="Content-Style-Type" content="text/css" />
<%= "\n" + GetStyleSheetIncludes() %><%= GetRequestInfoJavaScript() + GetJavaScriptIncludes() + GetHeadBottomJavaScript() %>
  </head>
  <osweb:Body runat="server"><%= GetBodyTopJavaScript() %>
    <osweb:Form id="WebForm1" method="post"  action="<%# GetFormAction() %>" runat="server">
<ThemeProvider_widgets:Ky1nG5kdyhEesTpKvn40S7g runat="server" id="ThemeProvider_wt_WebBlockInstance1" OnEvaluateParameters="ThemeProvider_webBlck_WebBlockInstance1_onDataBinding" InstanceID="_WebBlockInstance1"><phHelpUpdate></phHelpUpdate><phHeaderActions></phHeaderActions><phTitle></phTitle><phActions></phActions><phMainContent></phMainContent></ThemeProvider_widgets:Ky1nG5kdyhEesTpKvn40S7g><osweb:DummySubmitLink runat="server" id="Dummy_Submit_Link"/>
    <%= OutSystems.HubEdition.RuntimePlatform.AppInfo.GetAppInfo().GetWatermark() %><%= GetCallbackDebug()	
%><%= GetVisitCode() %></osweb:Form><%= GetEndPageJavaScript() + GetBodyBottomJavaScript() %>
  </osweb:Body>
</html>
