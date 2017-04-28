﻿<%@ Page Language="c#" Codebehind="StaffSelectPopup.aspx.cs" AutoEventWireup="false" Inherits="ssCaseConferencing.Flows.FlowSafeguarding.ScrnStaffSelectPopup" %><%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %><%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %><%@ Import namespace="ssCaseConferencing" %><%@ Import namespace="OutSystems.HubEdition.RuntimePlatform" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="Blocks\CaseConferencing\RichWidgets\Icon.ascx" %>
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
<osweb:Container runat="server" id="wt_Container17" anonymous="true" onDataBinding="cnt_Container17_onDataBinding" cssClass="PopupWrapper" GridCssClasses="ThemeGrid_Width6"><osweb:Container runat="server" id="wt_Container11" anonymous="true" onDataBinding="cnt_Container11_onDataBinding" cssClass="TitlePopupHeader"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance2" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance2_onDataBinding" InstanceID="_WebBlockInstance2"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# " Select Staff" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container8" anonymous="true" onDataBinding="cnt_Container8_onDataBinding" cssClass="ContentWrapper" GridCssClasses="OSAutoMarginTop"><osweb:Container runat="server" id="wt_Container12" anonymous="true" onDataBinding="cnt_Container12_onDataBinding"><osweb:Container runat="server" id="wt_Container14" anonymous="true" onDataBinding="cnt_Container14_onDataBinding" GridCssClasses="OSInline" style="width: 115px"><osweb:PlaceHolder runat="server"><%# "Select Staff Member " %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container5" anonymous="true" onDataBinding="cnt_Container5_onDataBinding" GridCssClasses="ThemeGrid_Width4 ThemeGrid_MarginGutter"><osweb:DropDownList runat="server" id="wt_ComboBox16" onDataBinding="sel_ComboBox16_onDataBinding" GridCssClasses="ThemeGrid_Width4" Visible="<%# sel_ComboBox16_isVisible() %>" Enabled="<%# sel_ComboBox16_isEnabled() %>" OnSelectedIndexChanged="sel_ComboBox16_dropDown_valueChanged" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" Mandatory="<%# sel_ComboBox16_isMandatory() %>"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wt_ComboBox16ValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wt_ComboBox16"/></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container10" anonymous="true" onDataBinding="cnt_Container10_onDataBinding" GridCssClasses="OSAutoMarginTop"><osweb:Container runat="server" id="wt_Container1" anonymous="true" onDataBinding="cnt_Container1_onDataBinding" GridCssClasses="OSInline" style="width: 115px"><osweb:PlaceHolder runat="server"><%# "Or Enter External name " %></osweb:PlaceHolder></osweb:Container><osweb:TextBox runat="server" id="wt_Input4" GridCssClasses="ThemeGrid_Width4 ThemeGrid_MarginGutter" Visible="<%# inputwt_Input4_isVisible() %>" ReadOnly="<%# !inputwt_Input4_isEnabled() %>" maxlength="50" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" OnDefaultTypeValidationMessage="GetTextValidatorMsg" textmode="SingleLine" text="<%# inputwt_Input4_input_value() %>" onTextChanged="inputwt_Input4_input_onTextChanged" Mandatory="<%# inputwt_Input4_isMandatory() %>"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wt_Input4ValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wt_Input4"/><osweb:TextValidator runat="server" display="Dynamic" id="wt_Input4ValidatorType" ErrorMessage="<%# CaseConferencing_Properties.TextValidatorMsg %>" ControlToValidate="wt_Input4" ClientValidationFunction="OsCustomValidatorText"/></osweb:Container><osweb:Container runat="server" id="wt_Container9" anonymous="true" onDataBinding="cnt_Container9_onDataBinding" GridCssClasses="OSAutoMarginTop" align="right"><osweb:Button runat="server" id="wt_Button3" cssClass="Button Is_Default" Visible="<%# btn_Button3_isVisible() %>" Enabled="<%# btn_Button3_isEnabled() %>" CausesValidation="false" text="<%# btn_Button3_getLabel() %>"/><osweb:Button runat="server" id="wt_Button6" cssClass="Button" GridCssClasses="ThemeGrid_MarginGutter" Visible="<%# btn_Button6_isVisible() %>" Enabled="<%# btn_Button6_isEnabled() %>" CausesValidation="false" text="<%# btn_Button6_getLabel() %>"/></osweb:Container></osweb:Container></osweb:Container><osweb:DummySubmitLink runat="server" id="Dummy_Submit_Link"/>
    <%= OutSystems.HubEdition.RuntimePlatform.AppInfo.GetAppInfo().GetWatermark() %><%= GetCallbackDebug()	
%><%= GetVisitCode() %></osweb:Form><%= GetEndPageJavaScript() + GetBodyBottomJavaScript() %>
  </osweb:Body>
</html>