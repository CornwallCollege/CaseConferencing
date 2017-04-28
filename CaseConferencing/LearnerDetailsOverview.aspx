﻿<%@ Page Language="c#" Codebehind="LearnerDetailsOverview.aspx.cs" AutoEventWireup="false" Inherits="ssCaseConferencing.Flows.FlowLearnerView.ScrnLearnerDetailsOverview" %><%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %><%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %><%@ Import namespace="ssCaseConferencing" %><%@ Import namespace="OutSystems.HubEdition.RuntimePlatform" %><%@ Register TagPrefix="widgets" TagName="KY8fQXOFtqEiDzEzWU_VcSw" Src="Blocks\CaseConferencing\LearnerView\LearnerDetailsLayout.ascx" %><%@ Register TagPrefix="widgets" TagName="KP9tkKYf_30OeT8Y9jx9hBg" Src="Blocks\CaseConferencing\StaffView\LearnerDetails_RAG_Notes.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="Blocks\CaseConferencing\RichWidgets\Icon.ascx" %><%@ Register TagPrefix="widgets" TagName="KkTOiDDGcf0CyrxIYpif51g" Src="Blocks\CaseConferencing\LearnerView\Student_Log.ascx" %>
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
<widgets:KY8fQXOFtqEiDzEzWU_VcSw runat="server" id="wt_WebBlockInstance5" OnEvaluateParameters="webBlck_WebBlockInstance5_onDataBinding" InstanceID="_WebBlockInstance5"><phRAG><widgets:KP9tkKYf_30OeT8Y9jx9hBg runat="server" id="wt_WebBlockInstance14" OnEvaluateParameters="webBlck_WebBlockInstance14_onDataBinding" InstanceID="_WebBlockInstance14"></widgets:KP9tkKYf_30OeT8Y9jx9hBg><osweb:Container runat="server" id="wt_Container40" anonymous="true" onDataBinding="cnt_Container40_onDataBinding" cssClass="ContentDetailWrapper"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If50() %>"><osweb:Container runat="server" id="wt_Container4" anonymous="true" onDataBinding="cnt_Container4_onDataBinding" cssClass="ContactBlock"><osweb:Container runat="server" id="wt_Container17" anonymous="true" onDataBinding="cnt_Container17_onDataBinding" cssClass="ContactTitle"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance32" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance32_onDataBinding" InstanceID="_WebBlockInstance32"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# " Current Address" %></osweb:PlaceHolder></osweb:Container><osweb:PlaceHolder runat="server"><%# " " %></osweb:PlaceHolder><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance23" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance23_onDataBinding" InstanceID="_WebBlockInstance23"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:Container runat="server" id="wt_Container35" anonymous="true" onDataBinding="cnt_Container35_onDataBinding" GridCssClasses="OSInline"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression7()) %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# "<br/>" %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# " " %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression53()) %></osweb:PlaceHolder></osweb:Container></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If50() %>"></osweb:If></osweb:IfPlaceHolder><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If10() %>"><osweb:Container runat="server" id="wt_Container36" anonymous="true" onDataBinding="cnt_Container36_onDataBinding" cssClass="ContactBlock"><osweb:Container runat="server" id="wt_Container59" anonymous="true" onDataBinding="cnt_Container59_onDataBinding" cssClass="ContactTitle"><osweb:PlaceHolder runat="server"><%# " Address" %></osweb:PlaceHolder></osweb:Container><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance27" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance27_onDataBinding" InstanceID="_WebBlockInstance27"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:Container runat="server" id="wt_Container1" anonymous="true" onDataBinding="cnt_Container1_onDataBinding" GridCssClasses="OSInline"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression39()) %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# "<br/>" %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression38()) %></osweb:PlaceHolder></osweb:Container></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If10() %>"></osweb:If></osweb:IfPlaceHolder><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If48() %>"><osweb:Container runat="server" id="wt_Container56" anonymous="true" onDataBinding="cnt_Container56_onDataBinding" cssClass="ContactBlock"><osweb:Container runat="server" id="wt_Container2" anonymous="true" onDataBinding="cnt_Container2_onDataBinding" cssClass="ContactTitle"><osweb:PlaceHolder runat="server"><%# " Next of Kin" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container33" anonymous="true" onDataBinding="cnt_Container33_onDataBinding"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance37" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance37_onDataBinding" InstanceID="_WebBlockInstance37"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression18()) %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# ", " %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression55()) %></osweb:PlaceHolder></osweb:Container><osweb:PlaceHolder runat="server"><%# "<br/>" %></osweb:PlaceHolder><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance24" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance24_onDataBinding" InstanceID="_WebBlockInstance24"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:Container runat="server" id="wt_Container57" anonymous="true" onDataBinding="cnt_Container57_onDataBinding" GridCssClasses="OSInline"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression51()) %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# "<br/>" %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression19()) %></osweb:PlaceHolder></osweb:Container><osweb:PlaceHolder runat="server"><%# "<br/>" %></osweb:PlaceHolder><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance26" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance26_onDataBinding" InstanceID="_WebBlockInstance26"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression60()) %></osweb:PlaceHolder></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If48() %>"></osweb:If></osweb:IfPlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container21" anonymous="true" onDataBinding="cnt_Container21_onDataBinding" cssClass="ContentDetailWrapper" GridCssClasses="OSAutoMarginTop"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance6" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance6_onDataBinding" InstanceID="_WebBlockInstance6"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:Container runat="server" id="wt_Container15" anonymous="true" onDataBinding="cnt_Container15_onDataBinding" cssClass="ContactTitle" GridCssClasses="OSInline" style="width: 100px; margin-left: 5px"><osweb:PlaceHolder runat="server"><%# "Previous School :" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container47" anonymous="true" onDataBinding="cnt_Container47_onDataBinding" GridCssClasses="OSInline ThemeGrid_MarginGutter" style="width: 650px"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression30()) %></osweb:PlaceHolder></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container12" anonymous="true" onDataBinding="cnt_Container12_onDataBinding" cssClass="ContactSection"><widgets:KkTOiDDGcf0CyrxIYpif51g runat="server" id="wt_WebBlockInstance34" OnEvaluateParameters="webBlck_WebBlockInstance34_onDataBinding" InstanceID="_WebBlockInstance34"></widgets:KkTOiDDGcf0CyrxIYpif51g></osweb:Container></phRAG><phILP></phILP><phSIAS></phSIAS><phProgramme></phProgramme><phSafeguarding></phSafeguarding><phProgressReport></phProgressReport></widgets:KY8fQXOFtqEiDzEzWU_VcSw><osweb:DummySubmitLink runat="server" id="Dummy_Submit_Link"/>
    <%= OutSystems.HubEdition.RuntimePlatform.AppInfo.GetAppInfo().GetWatermark() %><%= GetCallbackDebug()	
%><%= GetVisitCode() %></osweb:Form><%= GetEndPageJavaScript() + GetBodyBottomJavaScript() %>
  </osweb:Body>
</html>