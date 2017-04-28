<%@ Page Language="c#" Codebehind="UnderMaintenance.aspx.cs" AutoEventWireup="false" Inherits="ssCaseConferencing.Flows.FlowMainFlow2.ScrnUnderMaintenance" %><%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %><%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %><%@ Import namespace="ssCaseConferencing" %><%@ Import namespace="OutSystems.HubEdition.RuntimePlatform" %><%@ Register TagPrefix="ThemeProvider_widgets" TagName="KNGSPIo9VIkC5QidRcNwlyA" Src="Blocks\CaseConferencing\MainLayouts\Header_NoHelpLink.ascx" %>
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
<ThemeProvider_widgets:KNGSPIo9VIkC5QidRcNwlyA runat="server" id="ThemeProvider_wt_WebBlockInstance1" OnEvaluateParameters="ThemeProvider_webBlck_WebBlockInstance1_onDataBinding" InstanceID="_WebBlockInstance1"><phHelpUpdate></phHelpUpdate><phHeaderActions></phHeaderActions></ThemeProvider_widgets:KNGSPIo9VIkC5QidRcNwlyA><osweb:Container runat="server" id="wt_Container7" anonymous="true" onDataBinding="cnt_Container7_onDataBinding" GridCssClasses="OSAutoMarginTop"><osweb:Container runat="server" id="wt_Container10" anonymous="true" onDataBinding="cnt_Container10_onDataBinding"><osweb:PlaceHolder runat="server"><%# "Case Conferencing is currently offline under going maintenance due to the move from UNITe to ProSolution." %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container9" anonymous="true" onDataBinding="cnt_Container9_onDataBinding" GridCssClasses="OSAutoMarginTop"><osweb:PlaceHolder runat="server"><%# "We hope to have work completed by : " %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression3()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container2" anonymous="true" onDataBinding="cnt_Container2_onDataBinding" GridCssClasses="OSAutoMarginTop"></osweb:Container></osweb:Container><osweb:DummySubmitLink runat="server" id="Dummy_Submit_Link"/>
    <%= OutSystems.HubEdition.RuntimePlatform.AppInfo.GetAppInfo().GetWatermark() %><%= GetCallbackDebug()	
%><%= GetVisitCode() %></osweb:Form><%= GetEndPageJavaScript() + GetBodyBottomJavaScript() %>
  </osweb:Body>
</html>
