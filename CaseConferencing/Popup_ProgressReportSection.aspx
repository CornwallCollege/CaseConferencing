﻿<%@ Page Language="c#" Codebehind="Popup_ProgressReportSection.aspx.cs" AutoEventWireup="false" Inherits="ssCaseConferencing.Flows.FlowLearner_ProgressReport.ScrnPopup_ProgressReportSection" %><%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %><%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %><%@ Import namespace="ssCaseConferencing" %><%@ Import namespace="OutSystems.HubEdition.RuntimePlatform" %><%@ Register TagPrefix="widgets" TagName="KHtW7GNYBskijYiZHuvzUvw" Src="Blocks\CaseConferencing\Common\Popup_Editor_Layout.ascx" %><%@ Register TagPrefix="Hunspell_widgets" TagName="K0Zl4goFGNE2SN5MU27Ivpw" Src="Blocks\CaseConferencing\HunSpell\SpellcheckerLink.ascx" %><%@ Register TagPrefix="widgets" TagName="KG6f0u0SrOUGX6qeUC7FwaA" Src="Blocks\CaseConferencing\AutoComplete_Bank\AutoComplete_Icon.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="Blocks\CaseConferencing\RichWidgets\Icon.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="K7hJgNUBQM_BDq6cGrxQ_Tg" Src="Blocks\CaseConferencing\RichWidgets\Input_SetFocus.ascx" %>
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
<widgets:KHtW7GNYBskijYiZHuvzUvw runat="server" id="wt_WebBlockInstance10" OnEvaluateParameters="webBlck_WebBlockInstance10_onDataBinding" InstanceID="_WebBlockInstance10"><phTitle><osweb:PlaceHolder runat="server"><%# "Add / Edit Progress Report Section" %></osweb:PlaceHolder></phTitle><phContent><osweb:Container runat="server" id="wt_Container22" anonymous="true" onDataBinding="cnt_Container22_onDataBinding"><osweb:Container runat="server" id="wt_Container23" anonymous="true" onDataBinding="cnt_Container23_onDataBinding" cssClass="ContentWrapper"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression5()) %></osweb:PlaceHolder></osweb:Container><osweb:TextBox runat="server" id="wtTextInput" onDataBinding="inputwtTextInput_onDataBinding" onAjaxChange="inputwtTextInput_AjaxChange" GridCssClasses="ThemeGrid_Width5" Visible="<%# inputwtTextInput_isVisible() %>" ReadOnly="<%# !inputwtTextInput_isEnabled() %>" maxlength="2000" onchange="OsLimitInput(this,event,2000);" onkeyup="OsLimitInput(this,event,2000);" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" OnDefaultTypeValidationMessage="GetTextValidatorMsg" textmode="MultiLine" rows="6" text="<%# inputwtTextInput_input_value() %>" onTextChanged="inputwtTextInput_input_onTextChanged" Mandatory="<%# inputwtTextInput_isMandatory() %>"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wtTextInputValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wtTextInput"/><osweb:TextValidator runat="server" display="Dynamic" id="wtTextInputValidatorType" ErrorMessage="<%# CaseConferencing_Properties.TextValidatorMsg %>" ControlToValidate="wtTextInput" ClientValidationFunction="OsCustomValidatorText"/><osweb:Container runat="server" id="wt_Container1" anonymous="true" onDataBinding="cnt_Container1_onDataBinding" GridCssClasses="ThemeGrid_Width1 ThemeGrid_MarginGutter"><osweb:Span runat="server" id="wtcharcountHolder"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expressioncharcountHolder()) %></osweb:Span></osweb:Container><osweb:Container runat="server" id="wt_Container17" anonymous="true" onDataBinding="cnt_Container17_onDataBinding" GridCssClasses="OSAutoMarginTop"><osweb:CheckBox runat="server" id="wt_CheckBox2" Visible="<%# chk_CheckBox2_isVisible() %>" Enabled="<%# chk_CheckBox2_isEnabled() %>" Checked="<%# chk_CheckBox2_checked_value() %>" onCheckedChanged="chk_CheckBox2_checkbox_onCheckedChanged"/><osweb:PlaceHolder runat="server"><%# "Mark Section as completed" %></osweb:PlaceHolder></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container21" anonymous="true" onDataBinding="cnt_Container21_onDataBinding" GridCssClasses="OSAutoMarginTop" align="right"><osweb:Container runat="server" id="wt_Container13" anonymous="true" onDataBinding="cnt_Container13_onDataBinding" GridCssClasses="OSInline" align="left"><osweb:Container runat="server" id="wt_Container16" anonymous="true" onDataBinding="cnt_Container16_onDataBinding" GridCssClasses="OSInline"><Hunspell_widgets:K0Zl4goFGNE2SN5MU27Ivpw runat="server" id="Hunspell_wt_WebBlockInstance24" OnEvaluateParameters="Hunspell_webBlck_WebBlockInstance24_onDataBinding" InstanceID="_WebBlockInstance24"></Hunspell_widgets:K0Zl4goFGNE2SN5MU27Ivpw></osweb:Container><osweb:Container runat="server" id="wt_Container4" anonymous="true" onDataBinding="cnt_Container4_onDataBinding" GridCssClasses="OSInline" style="margin-left: 10px"><widgets:KG6f0u0SrOUGX6qeUC7FwaA runat="server" id="wt_WebBlockInstance18" OnEvaluateParameters="webBlck_WebBlockInstance18_onDataBinding" InstanceID="_WebBlockInstance18"></widgets:KG6f0u0SrOUGX6qeUC7FwaA></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container3" anonymous="true" onDataBinding="cnt_Container3_onDataBinding" onAjaxClick="cnt_Container3_AjaxClick" cssClass="HeaderButton" GridCssClasses="OSInline" style="width: 60px; margin-left: 10px" align="center"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance20" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance20_onDataBinding" InstanceID="_WebBlockInstance20"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# " Save" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container8" anonymous="true" onDataBinding="cnt_Container8_onDataBinding" onAjaxClick="cnt_Container8_AjaxClick" cssClass="ButtonGrey" GridCssClasses="OSInline" style="width: 60px; margin-left: 10px" align="center"><osweb:PlaceHolder runat="server"><%# " Close" %></osweb:PlaceHolder></osweb:Container></osweb:Container><RichWidgets_widgets:K7hJgNUBQM_BDq6cGrxQ_Tg runat="server" id="RichWidgets_wt_WebBlockInstance7" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance7_onDataBinding" InstanceID="_WebBlockInstance7"></RichWidgets_widgets:K7hJgNUBQM_BDq6cGrxQ_Tg></phContent></widgets:KHtW7GNYBskijYiZHuvzUvw><osweb:DummySubmitLink runat="server" id="Dummy_Submit_Link"/>
    <%= OutSystems.HubEdition.RuntimePlatform.AppInfo.GetAppInfo().GetWatermark() %><%= GetCallbackDebug()	
%><%= GetVisitCode() %></osweb:Form><%= GetEndPageJavaScript() + GetBodyBottomJavaScript() %>
  </osweb:Body>
</html>