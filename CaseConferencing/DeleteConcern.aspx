﻿<%@ Page Language="c#" Codebehind="DeleteConcern.aspx.cs" AutoEventWireup="false" Inherits="ssCaseConferencing.Flows.FlowStaffView.ScrnDeleteConcern" %><%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %><%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %><%@ Import namespace="ssCaseConferencing" %><%@ Import namespace="OutSystems.HubEdition.RuntimePlatform" %><%@ Register TagPrefix="widgets" TagName="K1tHu2scNhke0DPtNY_WdAQ" Src="Blocks\CaseConferencing\Common\DateFormatted.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="Blocks\CaseConferencing\RichWidgets\Icon.ascx" %>
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
<osweb:Container runat="server" id="wtViewCauseForConcern" onDataBinding="cntViewCauseForConcern_onDataBinding" GridCssClasses="OSInline" style="width: 320px"><osweb:Container runat="server" id="wt_Container14" anonymous="true" onDataBinding="cnt_Container14_onDataBinding" GridCssClasses="OSInline"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If20() %>"><osweb:DynamicImage runat="server" id="wt_Image13" anonymous="true" StaticSource="<%# Images.CoC_red_Source() %>" ImageType="Static" StaticPath="<%# AppUtils.Instance.getImagePath() %>" alt=""/></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If20() %>"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If17() %>"><osweb:DynamicImage runat="server" id="wt_Image29" anonymous="true" StaticSource="<%# Images.coc_ambar_Source() %>" ImageType="Static" StaticPath="<%# AppUtils.Instance.getImagePath() %>" alt=""/></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If17() %>"><osweb:DynamicImage runat="server" id="wt_Image16" anonymous="true" StaticSource="<%# Images.coc_blue_Source() %>" ImageType="Static" StaticPath="<%# AppUtils.Instance.getImagePath() %>" alt=""/></osweb:If></osweb:IfPlaceHolder></osweb:If></osweb:IfPlaceHolder><osweb:PlaceHolder runat="server"><%# " " %></osweb:PlaceHolder><osweb:Container runat="server" id="wt_Container8" anonymous="true" onDataBinding="cnt_Container8_onDataBinding" GridCssClasses="OSInline"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression18()) %></osweb:PlaceHolder></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container5" anonymous="true" onDataBinding="cnt_Container5_onDataBinding" GridCssClasses="OSInline"></osweb:Container><osweb:Container runat="server" id="wt_Container12" anonymous="true" onDataBinding="cnt_Container12_onDataBinding" GridCssClasses="OSInline"><osweb:Container runat="server" id="wt_Container27" anonymous="true" onDataBinding="cnt_Container27_onDataBinding" GridCssClasses="OSInline"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression6()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container4" anonymous="true" onDataBinding="cnt_Container4_onDataBinding"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression2()) %></osweb:PlaceHolder><widgets:K1tHu2scNhke0DPtNY_WdAQ runat="server" id="wt_WebBlockInstance11" OnEvaluateParameters="webBlck_WebBlockInstance11_onDataBinding" InstanceID="_WebBlockInstance11"></widgets:K1tHu2scNhke0DPtNY_WdAQ></osweb:Container><osweb:Container runat="server" id="wt_Container15" anonymous="true" onDataBinding="cnt_Container15_onDataBinding" style="margin-top: 20px"><osweb:PlaceHolder runat="server"><%# "Please enter a reason for deletion for the above Concern Note" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container28" anonymous="true" onDataBinding="cnt_Container28_onDataBinding" GridCssClasses="OSInline" style="width: 320px"><osweb:TextBox runat="server" id="wt_Input1" style="width: 300px" Visible="<%# inputwt_Input1_isVisible() %>" ReadOnly="<%# !inputwt_Input1_isEnabled() %>" maxlength="50" onchange="OsLimitInput(this,event,50);" onkeyup="OsLimitInput(this,event,50);" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" OnDefaultTypeValidationMessage="GetTextValidatorMsg" textmode="MultiLine" rows="6" text="<%# inputwt_Input1_input_value() %>" onTextChanged="inputwt_Input1_input_onTextChanged" Mandatory="<%# inputwt_Input1_isMandatory() %>"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wt_Input1ValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wt_Input1"/><osweb:TextValidator runat="server" display="Dynamic" id="wt_Input1ValidatorType" ErrorMessage="<%# CaseConferencing_Properties.TextValidatorMsg %>" ControlToValidate="wt_Input1" ClientValidationFunction="OsCustomValidatorText"/></osweb:Container><osweb:Container runat="server" id="wt_Container7" anonymous="true" onDataBinding="cnt_Container7_onDataBinding" align="right"><osweb:Container runat="server" id="wt_Container32" anonymous="true" onDataBinding="cnt_Container32_onDataBinding"></osweb:Container><osweb:LinkButton runat="server" id="wt_Link10" Visible="<%# lnk_Link10_isVisible() %>" Enabled="<%# lnk_Link10_isEnabled() %>" CausesValidation="false"><osweb:PlaceHolder runat="server"><%# "Cancel" %></osweb:PlaceHolder></osweb:LinkButton><osweb:Container runat="server" id="wt_Container23" anonymous="true" onDataBinding="cnt_Container23_onDataBinding" onAjaxClick="cnt_Container23_AjaxClick" cssClass="ButtonPopup" GridCssClasses="OSInline"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance26" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance26_onDataBinding" InstanceID="_WebBlockInstance26"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# "Delete Concern" %></osweb:PlaceHolder></osweb:Container></osweb:Container></osweb:Container></osweb:Container><osweb:DummySubmitLink runat="server" id="Dummy_Submit_Link"/>
    <%= OutSystems.HubEdition.RuntimePlatform.AppInfo.GetAppInfo().GetWatermark() %><%= GetCallbackDebug()	
%><%= GetVisitCode() %></osweb:Form><%= GetEndPageJavaScript() + GetBodyBottomJavaScript() %>
  </osweb:Body>
</html>
