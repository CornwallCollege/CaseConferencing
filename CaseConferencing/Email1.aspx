﻿<%@ Page Language="c#" Codebehind="Email1.aspx.cs" AutoEventWireup="false" Inherits="ssCaseConferencing.Flows.FlowStaffView.ScrnEmail1" EnableViewState="false" EnableSessionState="false" %><%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %><%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %><%@ Import namespace="ssCaseConferencing" %><%@ Import namespace="OutSystems.HubEdition.RuntimePlatform" %><%@ Register TagPrefix="widgets" TagName="K1tHu2scNhke0DPtNY_WdAQ" Src="Blocks\CaseConferencing\Common\DateFormatted.ascx" %>
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
<osweb:Container runat="server" id="wt_EmailContainer84" anonymous="true" onDataBinding="cnt_EmailContainer84_onDataBinding" GridCssClasses="OSFillParent" align="center"></osweb:Container><osweb:Container runat="server" id="wt_EmailContainer77" anonymous="true" onDataBinding="cnt_EmailContainer77_onDataBinding" GridCssClasses="OSFillParent"><osweb:Table runat="server" id="wt_Table56" anonymous="true" GridCssClasses="OSFillParent"><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_TableCell27" anonymous="true"><osweb:DynamicImage runat="server" id="wt_Image16" anonymous="true" StaticSource="<%# Images.email_header_Source() %>" ImageType="Static" StaticPath="<%# AppUtils.Instance.getImagePath() %>" alt=""/></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_TableCell58" anonymous="true"><osweb:Table runat="server" id="wt_Table23" anonymous="true" onDataBinding="wt_Table23_onDataBinding" GridCssClasses="OSInline" style="width: 768px"><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_TableCell42" anonymous="true" onDataBinding="wt_TableCell42_onDataBinding"><osweb:Container runat="server" id="wt_EmailContainer10" anonymous="true" onDataBinding="cnt_EmailContainer10_onDataBinding" GridCssClasses="OSFillParent"><osweb:PlaceHolder runat="server"><%# "Dear " %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression37()) %></osweb:PlaceHolder></osweb:Container></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_TableCell59" anonymous="true" onDataBinding="wt_TableCell59_onDataBinding"><osweb:Container runat="server" id="wt_EmailContainer49" anonymous="true" onDataBinding="cnt_EmailContainer49_onDataBinding" GridCssClasses="OSFillParent"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression36()) %></osweb:PlaceHolder></osweb:Container></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_TableCell41" anonymous="true" onDataBinding="wt_TableCell41_onDataBinding"><osweb:Container runat="server" id="wt_EmailContainer18" anonymous="true" onDataBinding="cnt_EmailContainer18_onDataBinding" GridCssClasses="OSFillParent"><osweb:Span runat="server" id="wt_Text26" anonymous="true" onDataBinding="wt_Text26_onDataBinding" class="Underline"><%# "Learner: " %></osweb:Span><osweb:Span runat="server" id="wt_InlineExpression5" anonymous="true" onDataBinding="expression_InlineExpression5_onDataBinding"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression5()) %></osweb:Span></osweb:Container></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_TableCell72" anonymous="true" onDataBinding="wt_TableCell72_onDataBinding"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If33() %>"><osweb:Container runat="server" id="wt_EmailContainer65" anonymous="true" onDataBinding="cnt_EmailContainer65_onDataBinding" GridCssClasses="OSFillParent"><osweb:Span runat="server" id="wt_Text2" anonymous="true" onDataBinding="wt_Text2_onDataBinding"><%# "Cause for concern: " %></osweb:Span><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression78()) %></osweb:PlaceHolder></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If33() %>"></osweb:If></osweb:IfPlaceHolder></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_TableCell3" anonymous="true" onDataBinding="wt_TableCell3_onDataBinding"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If43() %>"><osweb:Container runat="server" id="wt_EmailContainer83" anonymous="true" onDataBinding="cnt_EmailContainer83_onDataBinding" GridCssClasses="OSFillParent"><osweb:Span runat="server" id="wt_Text1" anonymous="true" onDataBinding="wt_Text1_onDataBinding"><%# "RAG: " %></osweb:Span><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression79()) %></osweb:PlaceHolder></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If43() %>"><osweb:Container runat="server" id="wt_EmailContainer13" anonymous="true" onDataBinding="cnt_EmailContainer13_onDataBinding" GridCssClasses="OSFillParent"><osweb:Span runat="server" id="wt_Text69" anonymous="true" onDataBinding="wt_Text69_onDataBinding"><%# "Reward: " %></osweb:Span><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression21()) %></osweb:PlaceHolder></osweb:Container></osweb:If></osweb:IfPlaceHolder></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_TableCell50" anonymous="true" onDataBinding="wt_TableCell50_onDataBinding"><osweb:Container runat="server" id="wt_EmailContainer53" anonymous="true" onDataBinding="cnt_EmailContainer53_onDataBinding" GridCssClasses="OSFillParent"><osweb:Container runat="server" id="wt_EmailContainer11" anonymous="true" onDataBinding="cnt_EmailContainer11_onDataBinding" GridCssClasses="OSFillParent"><osweb:Span runat="server" id="wt_Text30" anonymous="true" onDataBinding="wt_Text30_onDataBinding"><%# "Description:  " %></osweb:Span></osweb:Container><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression29()) %></osweb:PlaceHolder></osweb:Container></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_TableCell74" anonymous="true" onDataBinding="wt_TableCell74_onDataBinding"><osweb:Container runat="server" id="wt_EmailContainer80" anonymous="true" onDataBinding="cnt_EmailContainer80_onDataBinding" GridCssClasses="OSFillParent"><osweb:Span runat="server" id="wt_Text46" anonymous="true" onDataBinding="wt_Text46_onDataBinding"><%# "Changed by: " %></osweb:Span><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression67()) %></osweb:PlaceHolder></osweb:Container></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_TableCell35" anonymous="true" onDataBinding="wt_TableCell35_onDataBinding"><osweb:Container runat="server" id="wt_EmailContainer8" anonymous="true" onDataBinding="cnt_EmailContainer8_onDataBinding" GridCssClasses="OSFillParent"><osweb:Span runat="server" id="wt_Text62" anonymous="true" onDataBinding="wt_Text62_onDataBinding"><%# "Date:" %></osweb:Span><widgets:K1tHu2scNhke0DPtNY_WdAQ runat="server" id="wt_EmailWebBlockInstance45" OnEvaluateParameters="webBlck_EmailWebBlockInstance45_onDataBinding" InstanceID="_EmailWebBlockInstance45"></widgets:K1tHu2scNhke0DPtNY_WdAQ></osweb:Container></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_TableCell54" anonymous="true" onDataBinding="wt_TableCell54_onDataBinding"><osweb:Container runat="server" id="wt_EmailContainer68" anonymous="true" onDataBinding="cnt_EmailContainer68_onDataBinding" GridCssClasses="OSFillParent"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If40() %>"><osweb:HyperLink runat="server" id="wt_EmailLink61" Visible="<%# lnk_EmailLink61_isVisible() %>" NavigateUrl="<%# lnk_EmailLink61_NavigateUrl() %>"><osweb:PlaceHolder runat="server"><%# "View more details about this Learner" %></osweb:PlaceHolder></osweb:HyperLink></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If40() %>"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If85() %>"><osweb:HyperLink runat="server" id="wt_EmailLink17" Visible="<%# lnk_EmailLink17_isVisible() %>" NavigateUrl="<%# lnk_EmailLink17_NavigateUrl() %>"><osweb:PlaceHolder runat="server"><%# "View more details about this Learner" %></osweb:PlaceHolder></osweb:HyperLink></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If85() %>"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If22() %>"><osweb:HyperLink runat="server" id="wt_EmailLink52" Visible="<%# lnk_EmailLink52_isVisible() %>" NavigateUrl="<%# lnk_EmailLink52_NavigateUrl() %>"><osweb:PlaceHolder runat="server"><%# "View more details about this Learner" %></osweb:PlaceHolder></osweb:HyperLink></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If22() %>"><osweb:HyperLink runat="server" id="wt_EmailLink6" Visible="<%# lnk_EmailLink6_isVisible() %>" NavigateUrl="<%# lnk_EmailLink6_NavigateUrl() %>"><osweb:PlaceHolder runat="server"><%# "View more details about this Learner" %></osweb:PlaceHolder></osweb:HyperLink></osweb:If></osweb:IfPlaceHolder></osweb:If></osweb:IfPlaceHolder></osweb:If></osweb:IfPlaceHolder></osweb:Container></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_TableCell66" anonymous="true" onDataBinding="wt_TableCell66_onDataBinding"><osweb:Container runat="server" id="wt_EmailContainer28" anonymous="true" onDataBinding="cnt_EmailContainer28_onDataBinding" GridCssClasses="OSFillParent"><osweb:PlaceHolder runat="server"><%# "<br/>" %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# "Best Regards,<br/>" %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# "<br/>" %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# "Cornwall College" %></osweb:PlaceHolder></osweb:Container></osweb:Td></osweb:Tr></osweb:Table></osweb:Td></osweb:Tr></osweb:Table></osweb:Container><osweb:DummySubmitLink runat="server" id="Dummy_Submit_Link"/>
</osweb:Form>
  </osweb:Body>
</html>
