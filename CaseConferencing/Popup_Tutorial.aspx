﻿<%@ Page Language="c#" Codebehind="Popup_Tutorial.aspx.cs" AutoEventWireup="false" Inherits="ssCaseConferencing.Flows.FlowLearner_ILP.ScrnPopup_Tutorial" %><%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %><%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %><%@ Import namespace="ssCaseConferencing" %><%@ Import namespace="OutSystems.HubEdition.RuntimePlatform" %><%@ Register TagPrefix="widgets" TagName="KHtW7GNYBskijYiZHuvzUvw" Src="Blocks\CaseConferencing\Common\Popup_Editor_Layout.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="KiOBZ_DLj1CK2uSfNSLcEUg" Src="Blocks\CaseConferencing\RichWidgets\Input_Calendar.ascx" %><%@ Register TagPrefix="Hunspell_widgets" TagName="K0Zl4goFGNE2SN5MU27Ivpw" Src="Blocks\CaseConferencing\HunSpell\SpellcheckerLink.ascx" %><%@ Register TagPrefix="widgets" TagName="KG6f0u0SrOUGX6qeUC7FwaA" Src="Blocks\CaseConferencing\AutoComplete_Bank\AutoComplete_Icon.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="Blocks\CaseConferencing\RichWidgets\Icon.ascx" %>
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
<widgets:KHtW7GNYBskijYiZHuvzUvw runat="server" id="wt_WebBlockInstance7" OnEvaluateParameters="webBlck_WebBlockInstance7_onDataBinding" InstanceID="_WebBlockInstance7"><phTitle><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If22() %>"><osweb:PlaceHolder runat="server"><%# "New Tutorial Note" %></osweb:PlaceHolder></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If22() %>"><osweb:PlaceHolder runat="server"><%# "Tutorial Note" %></osweb:PlaceHolder></osweb:If></osweb:IfPlaceHolder></phTitle><phContent><osweb:EditRecord runat="server" id="wtTutorialEdit" GridCssClasses="OSFillParent" style="border-spacing: 5px" cellspacing="5" border="0"><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_EditRecordCell14" anonymous="true" class="EditRecord_Caption"><osweb:Container runat="server" id="wt_Container9" anonymous="true" onDataBinding="cnt_Container9_onDataBinding" GridCssClasses="OSInline" style="width: 100px"><osweb:PlaceHolder runat="server"><%# "Date" %></osweb:PlaceHolder></osweb:Container></osweb:Td><osweb:Td runat="server" id="wt_EditRecordCell36" anonymous="true" class="EditRecord_Value"><osweb:TextBox runat="server" id="wtTutorial_Date" style="width: 140px" Visible="<%# inputwtTutorial_Date_isVisible() %>" ReadOnly="<%# !inputwtTutorial_Date_isEnabled() %>" maxlength="20" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" OnDefaultTypeValidationMessage="GetDateValidatorMsg" textmode="SingleLine" text="<%# inputwtTutorial_Date_input_value() %>" onTextChanged="inputwtTutorial_Date_input_onTextChanged" Mandatory="<%# inputwtTutorial_Date_isMandatory() %>" parentEditRecord="wtTutorialEdit"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wtTutorial_DateValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wtTutorial_Date"/><osweb:TextValidator runat="server" display="Dynamic" id="wtTutorial_DateValidatorType" ErrorMessage="<%# CaseConferencing_Properties.DateValidatorMsg %>" ControlToValidate="wtTutorial_Date" ClientValidationFunction="OsCustomValidatorDate"/><RichWidgets_widgets:KiOBZ_DLj1CK2uSfNSLcEUg runat="server" id="RichWidgets_wt_WebBlockInstance6" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance6_onDataBinding" InstanceID="_WebBlockInstance6"></RichWidgets_widgets:KiOBZ_DLj1CK2uSfNSLcEUg></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_EditRecordCell2" anonymous="true" class="EditRecord_Caption"><osweb:PlaceHolder runat="server"><%# "Notes" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_EditRecordCell40" anonymous="true" class="EditRecord_Value"><osweb:TextBox runat="server" id="wtTutorial_Notes" style="width: 400px" Visible="<%# inputwtTutorial_Notes_isVisible() %>" ReadOnly="<%# !inputwtTutorial_Notes_isEnabled() %>" maxlength="4000" onchange="OsLimitInput(this,event,4000);" onkeyup="OsLimitInput(this,event,4000);" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" OnDefaultTypeValidationMessage="GetTextValidatorMsg" textmode="MultiLine" rows="9" text="<%# inputwtTutorial_Notes_input_value() %>" onTextChanged="inputwtTutorial_Notes_input_onTextChanged" Mandatory="<%# inputwtTutorial_Notes_isMandatory() %>" parentEditRecord="wtTutorialEdit"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wtTutorial_NotesValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wtTutorial_Notes"/><osweb:TextValidator runat="server" display="Dynamic" id="wtTutorial_NotesValidatorType" ErrorMessage="<%# CaseConferencing_Properties.TextValidatorMsg %>" ControlToValidate="wtTutorial_Notes" ClientValidationFunction="OsCustomValidatorText"/></osweb:Td></osweb:Tr><osweb:Tr runat="server" onDataBinding="wt_EditRecordRow8_onDataBinding"><osweb:Td runat="server" id="wt_EditRecordCell5" anonymous="true" class="EditRecord_Caption"><osweb:PlaceHolder runat="server"><%# "Created At" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_EditRecordCell43" anonymous="true" class="EditRecord_Value"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression44()) %></osweb:PlaceHolder></osweb:Td></osweb:Tr><osweb:Tr runat="server" onDataBinding="wt_EditRecordRow24_onDataBinding"><osweb:Td runat="server" id="wt_EditRecordCell16" anonymous="true" class="EditRecord_Caption"><osweb:PlaceHolder runat="server"><%# "Created By" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_EditRecordCell29" anonymous="true" class="EditRecord_Value"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression4()) %></osweb:PlaceHolder></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_EditRecordCell32" anonymous="true" class="EditRecord_Caption"></osweb:Td><osweb:Td runat="server" id="wt_EditRecordCell10" anonymous="true" class="EditRecord_Value"><osweb:Container runat="server" id="wt_Container27" anonymous="true" onDataBinding="cnt_Container27_onDataBinding" style="margin-top: 0px" align="right"><osweb:Container runat="server" id="wt_Container34" anonymous="true" onDataBinding="cnt_Container34_onDataBinding" GridCssClasses="OSInline" align="left"><osweb:Container runat="server" id="wt_Container37" anonymous="true" onDataBinding="cnt_Container37_onDataBinding" GridCssClasses="OSInline"><Hunspell_widgets:K0Zl4goFGNE2SN5MU27Ivpw runat="server" id="Hunspell_wt_WebBlockInstance12" OnEvaluateParameters="Hunspell_webBlck_WebBlockInstance12_onDataBinding" InstanceID="_WebBlockInstance12"></Hunspell_widgets:K0Zl4goFGNE2SN5MU27Ivpw></osweb:Container><osweb:Container runat="server" id="wt_Container28" anonymous="true" onDataBinding="cnt_Container28_onDataBinding" GridCssClasses="OSInline" style="margin-left: 10px"><widgets:KG6f0u0SrOUGX6qeUC7FwaA runat="server" id="wt_WebBlockInstance45" OnEvaluateParameters="webBlck_WebBlockInstance45_onDataBinding" InstanceID="_WebBlockInstance45"></widgets:KG6f0u0SrOUGX6qeUC7FwaA></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container39" anonymous="true" onDataBinding="cnt_Container39_onDataBinding" onAjaxClick="cnt_Container39_AjaxClick" cssClass="HeaderButton" GridCssClasses="OSInline" style="width: 60px; margin-left: 10px" align="center"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance11" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance11_onDataBinding" InstanceID="_WebBlockInstance11"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# " Save" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container13" anonymous="true" onDataBinding="cnt_Container13_onDataBinding" onAjaxClick="cnt_Container13_AjaxClick" cssClass="ButtonGrey" GridCssClasses="OSInline" style="width: 60px; margin-left: 10px" align="center"><osweb:PlaceHolder runat="server"><%# " Close" %></osweb:PlaceHolder></osweb:Container></osweb:Container></osweb:Td></osweb:Tr></osweb:EditRecord></phContent></widgets:KHtW7GNYBskijYiZHuvzUvw><osweb:DummySubmitLink runat="server" id="Dummy_Submit_Link"/>
    <%= OutSystems.HubEdition.RuntimePlatform.AppInfo.GetAppInfo().GetWatermark() %><%= GetCallbackDebug()	
%><%= GetVisitCode() %></osweb:Form><%= GetEndPageJavaScript() + GetBodyBottomJavaScript() %>
  </osweb:Body>
</html>
