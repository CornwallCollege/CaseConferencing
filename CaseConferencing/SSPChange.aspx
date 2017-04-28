<%@ Page Language="c#" Codebehind="SSPChange.aspx.cs" AutoEventWireup="false" Inherits="ssCaseConferencing.Flows.FlowLearner_InitialAssessment.ScrnSSPChange" EnableViewState="false" EnableSessionState="false" %><%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %><%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %><%@ Import namespace="ssCaseConferencing" %><%@ Import namespace="OutSystems.HubEdition.RuntimePlatform" %>
<%= CaseConferencing_Properties.DocType %>
<html xmlns="http://www.w3.org/1999/xhtml" >
  <head runat="server">
	<title><%= HttpUtility.HtmlEncode (Title) %></title>
    <meta http-equiv="Content-Type" content="<%= "text/html; charset=" + "utf-8" %>" />
    <meta http-equiv="Content-Script-Type" content="text/javascript" />
    <meta http-equiv="Content-Style-Type" content="text/css" />
<%= "\n" + GetStyleSheetIncludes() %>
  </head>
  <osweb:Body runat="server">
    <osweb:Form id="WebForm1" method="post"  action="-" runat="server">
<osweb:Container runat="server" id="wt_EmailContainer6" anonymous="true" onDataBinding="cnt_EmailContainer6_onDataBinding" GridCssClasses="OSFillParent"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression2()) %></osweb:PlaceHolder><osweb:Container runat="server" id="wt_EmailContainer1" anonymous="true" onDataBinding="cnt_EmailContainer1_onDataBinding" GridCssClasses="OSFillParent OSAutoMarginTop"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression5()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_EmailContainer8" anonymous="true" onDataBinding="cnt_EmailContainer8_onDataBinding" GridCssClasses="OSFillParent OSAutoMarginTop"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression7()) %></osweb:PlaceHolder><osweb:HyperLink runat="server" id="wt_EmailLink3" Visible="<%# lnk_EmailLink3_isVisible() %>" NavigateUrl="<%# lnk_EmailLink3_NavigateUrl() %>"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression4()) %></osweb:PlaceHolder></osweb:HyperLink></osweb:Container></osweb:Container><osweb:DummySubmitLink runat="server" id="Dummy_Submit_Link"/>
</osweb:Form>
  </osweb:Body>
</html>
