﻿<%@ Page Language="c#" Codebehind="PDFExport.aspx.cs" AutoEventWireup="false" Inherits="ssCaseConferencing.Flows.FlowSafeguarding.ScrnPDFExport" EnableViewState="false" %><%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %><%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %><%@ Import namespace="ssCaseConferencing" %><%@ Import namespace="OutSystems.HubEdition.RuntimePlatform" %>
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
<osweb:Container runat="server" id="wt_Container8" anonymous="true" onDataBinding="cnt_Container8_onDataBinding" cssClass="Heading1"><osweb:Container runat="server" id="wt_Container50" anonymous="true" onDataBinding="cnt_Container50_onDataBinding" GridCssClasses="OSInline" style="width: 50%"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression48()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container61" anonymous="true" onDataBinding="cnt_Container61_onDataBinding" GridCssClasses="OSInline" style="width: 50%; margin-left: 0px" align="right"><osweb:Span runat="server" id="wt_InlineExpression53" anonymous="true" class="Heading3"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression53()) %></osweb:Span></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container64" anonymous="true" onDataBinding="cnt_Container64_onDataBinding" cssClass="PDFText" GridCssClasses="OSAutoMarginTop"><osweb:Span runat="server" id="wt_Text9" anonymous="true" class="Bold"><%# "Issue Type : " %></osweb:Span><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression16()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container46" anonymous="true" onDataBinding="cnt_Container46_onDataBinding" cssClass="PDFText" GridCssClasses="OSAutoMarginTop"><osweb:Span runat="server" id="wt_Text43" anonymous="true" class="Bold"><%# "Date Of Referral : " %></osweb:Span><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression5()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container39" anonymous="true" onDataBinding="cnt_Container39_onDataBinding" cssClass="PDFText" GridCssClasses="OSAutoMarginTop"><osweb:Span runat="server" id="wt_Text40" anonymous="true" class="Bold"><%# "Nature Of Concern : " %></osweb:Span><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression30()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container51" anonymous="true" onDataBinding="cnt_Container51_onDataBinding" cssClass="PDFText" GridCssClasses="OSAutoMarginTop"><osweb:Span runat="server" id="wt_Text25" anonymous="true" class="Bold"><%# "Details Of Concern : " %></osweb:Span><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression13()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container44" anonymous="true" onDataBinding="cnt_Container44_onDataBinding" cssClass="PDFText" GridCssClasses="OSAutoMarginTop"><osweb:Span runat="server" id="wt_Text19" anonymous="true" class="Bold"><%# "RAG Status Set : " %></osweb:Span><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression28()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container3" anonymous="true" onDataBinding="cnt_Container3_onDataBinding" cssClass="PDFText" GridCssClasses="OSAutoMarginTop"><osweb:Span runat="server" id="wt_Text63" anonymous="true" class="Bold"><%# "File Received From School : " %></osweb:Span><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If57() %>"><osweb:PlaceHolder runat="server"><%# "Yes" %></osweb:PlaceHolder></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If57() %>"><osweb:PlaceHolder runat="server"><%# "No" %></osweb:PlaceHolder></osweb:If></osweb:IfPlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container36" anonymous="true" onDataBinding="cnt_Container36_onDataBinding" cssClass="Heading2" GridCssClasses="OSAutoMarginTop"><osweb:PlaceHolder runat="server"><%# "Persons Involved" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container21" anonymous="true" onDataBinding="cnt_Container21_onDataBinding" cssClass="PDFText" GridCssClasses="OSAutoMarginTop"><osweb:Span runat="server" id="wt_Text2" anonymous="true" class="Bold"><%# "Safeguarding Lead : " %></osweb:Span><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression1()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container58" anonymous="true" onDataBinding="cnt_Container58_onDataBinding" cssClass="PDFText" GridCssClasses="OSAutoMarginTop"><osweb:Container runat="server" id="wt_Container65" anonymous="true" onDataBinding="cnt_Container65_onDataBinding" GridCssClasses="OSInline" style="width: 210px"><osweb:Span runat="server" id="wt_Text47" anonymous="true" class="Bold"><%# "Additional Persons Involved : " %></osweb:Span></osweb:Container><osweb:Container runat="server" id="wt_Container56" anonymous="true" onDataBinding="cnt_Container56_onDataBinding" GridCssClasses="OSInline" style="width: 450px; margin-left: 40px"><osweb:Iterator runat="server" id="wtPersonsInvolvedList" onDataBinding="recListPersonsInvolvedList_onDataBinding" cssClass="ListRecords" OnItemCommand="recListPersonsInvolvedList_Select" OnSetViewStateStorage="recListPersonsInvolvedList_Store" OnClearViewStateStorage="recListPersonsInvolvedList_Clear" OnListRefreshDataBind="recListPersonsInvolvedList_ListRefreshDataBind" UseBullets="true"><ItemTemplate><osweb:Container runat="server" id="wt_Container23" anonymous="true" onDataBinding="cnt_Container23_onDataBinding" GridCssClasses="OSInline" style="width: 400px; margin-left: 0px"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression49()) %></osweb:PlaceHolder></osweb:Container></ItemTemplate><InvisibleTemplate><%# recListPersonsInvolvedList_Store(Container.DataItem, Container.ItemIndex) %></InvisibleTemplate></osweb:Iterator></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container54" anonymous="true" onDataBinding="cnt_Container54_onDataBinding" cssClass="Heading2" GridCssClasses="OSAutoMarginTop"><osweb:PlaceHolder runat="server"><%# "Agencies Involved" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container41" anonymous="true" onDataBinding="cnt_Container41_onDataBinding" cssClass="PDFText" GridCssClasses="OSAutoMarginTop"><osweb:Container runat="server" id="wt_Container60" anonymous="true" onDataBinding="cnt_Container60_onDataBinding" GridCssClasses="OSInline" style="width: 210px"><osweb:Span runat="server" id="wt_Text14" anonymous="true" class="Bold"><%# "Agencies Involved : " %></osweb:Span></osweb:Container><osweb:Container runat="server" id="wt_Container31" anonymous="true" onDataBinding="cnt_Container31_onDataBinding" GridCssClasses="OSInline" style="width: 450px; margin-left: 40px"><osweb:Iterator runat="server" id="wtListRecords1" onDataBinding="recListListRecords1_onDataBinding" cssClass="ListRecords" OnItemCommand="recListListRecords1_Select" OnSetViewStateStorage="recListListRecords1_Store" OnClearViewStateStorage="recListListRecords1_Clear" OnListRefreshDataBind="recListListRecords1_ListRefreshDataBind" UseBullets="true"><ItemTemplate><osweb:Container runat="server" id="wt_Container20" anonymous="true" onDataBinding="cnt_Container20_onDataBinding" GridCssClasses="OSInline" style="width: 400px; margin-left: 0px"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression4()) %></osweb:PlaceHolder></osweb:Container></ItemTemplate><InvisibleTemplate><%# recListListRecords1_Store(Container.DataItem, Container.ItemIndex) %></InvisibleTemplate></osweb:Iterator></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container52" anonymous="true" onDataBinding="cnt_Container52_onDataBinding" cssClass="Heading2" GridCssClasses="OSAutoMarginTop"><osweb:PlaceHolder runat="server"><%# "Actions Taken" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container11" anonymous="true" onDataBinding="cnt_Container11_onDataBinding" cssClass="PDFText" GridCssClasses="OSAutoMarginTop"><osweb:Span runat="server" id="wt_Text33" anonymous="true" class="Bold"><%# "Referral Made To : " %></osweb:Span><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression10()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container37" anonymous="true" onDataBinding="cnt_Container37_onDataBinding" cssClass="PDFText" GridCssClasses="OSAutoMarginTop"><osweb:Span runat="server" id="wt_Text34" anonymous="true" class="Bold"><%# "Actions Taken : " %></osweb:Span><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression59()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container17" anonymous="true" onDataBinding="cnt_Container17_onDataBinding" cssClass="PDFText" GridCssClasses="OSAutoMarginTop"><osweb:Span runat="server" id="wt_Text26" anonymous="true" class="Bold"><%# "Outcome : " %></osweb:Span><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression18()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container42" anonymous="true" onDataBinding="cnt_Container42_onDataBinding" cssClass="PDFText" GridCssClasses="OSAutoMarginTop"><osweb:Span runat="server" id="wt_Text45" anonymous="true" class="Bold"><%# "Outcome Details : " %></osweb:Span><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression15()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container55" anonymous="true" onDataBinding="cnt_Container55_onDataBinding" cssClass="PDFText" GridCssClasses="OSAutoMarginTop"><osweb:Span runat="server" id="wt_Text24" anonymous="true" class="Bold"><%# "Additional Information : " %></osweb:Span><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression35()) %></osweb:PlaceHolder></osweb:Container><osweb:DummySubmitLink runat="server" id="Dummy_Submit_Link"/>
    <%= OutSystems.HubEdition.RuntimePlatform.AppInfo.GetAppInfo().GetWatermark() %><%= GetCallbackDebug()	
%><%= GetVisitCode() %></osweb:Form><%= GetEndPageJavaScript() + GetBodyBottomJavaScript() %>
  </osweb:Body>
</html>
