﻿<%@ Page Language="c#" Codebehind="Update_Show.aspx.cs" AutoEventWireup="false" Inherits="ssCaseConferencing.Flows.FlowBackofficeFlow.ScrnUpdate_Show" %><%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %><%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %><%@ Import namespace="ssCaseConferencing" %><%@ Import namespace="OutSystems.HubEdition.RuntimePlatform" %><%@ Register TagPrefix="ThemeProvider_widgets" TagName="Ky1nG5kdyhEesTpKvn40S7g" Src="Blocks\CaseConferencing\MainLayouts\Layout_Main.ascx" %><%@ Register TagPrefix="widgets" TagName="KfpAa79RrRUaQSPrU6XYoGA" Src="Blocks\CaseConferencing\Common\HelpUpdate.ascx" %><%@ Register TagPrefix="ThemeProvider_widgets" TagName="KgWHRAp6ig0iU4JPYFzrEhg" Src="Blocks\CaseConferencing\MainLayouts\Menu_Backoffice.ascx" %>
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
<ThemeProvider_widgets:Ky1nG5kdyhEesTpKvn40S7g runat="server" id="ThemeProvider_wt_WebBlockInstance15" OnEvaluateParameters="ThemeProvider_webBlck_WebBlockInstance15_onDataBinding" InstanceID="_WebBlockInstance15"><phHelpUpdate><widgets:KfpAa79RrRUaQSPrU6XYoGA runat="server" id="wt_WebBlockInstance26" OnEvaluateParameters="webBlck_WebBlockInstance26_onDataBinding" InstanceID="_WebBlockInstance26"></widgets:KfpAa79RrRUaQSPrU6XYoGA></phHelpUpdate><phHeaderActions><ThemeProvider_widgets:KgWHRAp6ig0iU4JPYFzrEhg runat="server" id="ThemeProvider_wt_WebBlockInstance31" OnEvaluateParameters="ThemeProvider_webBlck_WebBlockInstance31_onDataBinding" InstanceID="_WebBlockInstance31"></ThemeProvider_widgets:KgWHRAp6ig0iU4JPYFzrEhg></phHeaderActions><phTitle><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression10()) %></osweb:PlaceHolder></phTitle><phActions><osweb:HyperLink runat="server" id="wt_Link4" cssClass="ActionEdit" Visible="<%# lnk_Link4_isVisible() %>" Enabled="<%# lnk_Link4_isEnabled() %>" NavigateUrl="<%# lnk_Link4_NavigateUrl() %>"><osweb:PlaceHolder runat="server"><%# "Edit this Update" %></osweb:PlaceHolder></osweb:HyperLink></phActions><phMainContent><osweb:Table runat="server" id="wtUpdateShow" class="ShowRecord" GridCssClasses="ThemeGrid_Width6" border="0"><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_ShowRecordCell11" anonymous="true" class="ShowRecord_Caption" GridCssClasses="ThemeGrid_Width2"><osweb:PlaceHolder runat="server"><%# "Update Date" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_ShowRecordCell23" anonymous="true" class="ShowRecord_Value"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression3()) %></osweb:PlaceHolder></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_ShowRecordCell22" anonymous="true" class="ShowRecord_Caption" GridCssClasses="ThemeGrid_Width2"><osweb:PlaceHolder runat="server"><%# "Update Submitted By" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_ShowRecordCell1" anonymous="true" class="ShowRecord_Value"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression17()) %></osweb:PlaceHolder></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_ShowRecordCell28" anonymous="true" class="ShowRecord_Caption" GridCssClasses="ThemeGrid_Width2"><osweb:PlaceHolder runat="server"><%# "Update Title" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_ShowRecordCell32" anonymous="true" class="ShowRecord_Value"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression16()) %></osweb:PlaceHolder></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_ShowRecordCell7" anonymous="true" class="ShowRecord_Caption" GridCssClasses="ThemeGrid_Width2"><osweb:PlaceHolder runat="server"><%# "Update HTML" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_ShowRecordCell13" anonymous="true" class="ShowRecord_Value"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression18()) %></osweb:PlaceHolder></osweb:Td></osweb:Tr></osweb:Table></phMainContent></ThemeProvider_widgets:Ky1nG5kdyhEesTpKvn40S7g><osweb:DummySubmitLink runat="server" id="Dummy_Submit_Link"/>
    <%= OutSystems.HubEdition.RuntimePlatform.AppInfo.GetAppInfo().GetWatermark() %><%= GetCallbackDebug()	
%><%= GetVisitCode() %></osweb:Form><%= GetEndPageJavaScript() + GetBodyBottomJavaScript() %>
  </osweb:Body>
</html>
