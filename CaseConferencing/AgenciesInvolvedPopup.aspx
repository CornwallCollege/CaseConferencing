﻿<%@ Page Language="c#" Codebehind="AgenciesInvolvedPopup.aspx.cs" AutoEventWireup="false" Inherits="ssCaseConferencing.Flows.FlowSafeguarding.ScrnAgenciesInvolvedPopup" %><%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %><%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %><%@ Import namespace="ssCaseConferencing" %><%@ Import namespace="OutSystems.HubEdition.RuntimePlatform" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="Blocks\CaseConferencing\RichWidgets\Icon.ascx" %>
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
<osweb:Container runat="server" id="wt_Container22" anonymous="true" onDataBinding="cnt_Container22_onDataBinding" cssClass="PopupWrapper" GridCssClasses="OSInline" style="width: 400px"><osweb:Container runat="server" id="wt_Container15" anonymous="true" onDataBinding="cnt_Container15_onDataBinding" cssClass="TitlePopupHeader"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance4" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance4_onDataBinding" InstanceID="_WebBlockInstance4"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# " Enter Agency Details" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wtAgencyInvolvedWrapper" onDataBinding="cntAgencyInvolvedWrapper_onDataBinding" cssClass="SGContentWrapper" GridCssClasses="ThemeGrid_Width5" style="margin-top: 5px"><osweb:Container runat="server" id="wtSelectAgencyWrapper" onDataBinding="cntSelectAgencyWrapper_onDataBinding" GridCssClasses="ThemeGrid_Width5"><osweb:Container runat="server" id="wt_Container16" anonymous="true" onDataBinding="cnt_Container16_onDataBinding" GridCssClasses="ThemeGrid_Width2"><osweb:PlaceHolder runat="server"><%# "Select Agency" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container23" anonymous="true" onDataBinding="cnt_Container23_onDataBinding" GridCssClasses="ThemeGrid_Width3 ThemeGrid_MarginGutter" align="right"><osweb:DropDownList runat="server" id="wt_ComboBox19" onDataBinding="sel_ComboBox19_onDataBinding" onAjaxChange="sel_ComboBox19_AjaxChange" GridCssClasses="OSFillParent" Visible="<%# sel_ComboBox19_isVisible() %>" Enabled="<%# sel_ComboBox19_isEnabled() %>" OnSelectedIndexChanged="sel_ComboBox19_dropDown_valueChanged" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" Mandatory="<%# sel_ComboBox19_isMandatory() %>"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wt_ComboBox19ValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wt_ComboBox19"/></osweb:Container></osweb:Container><osweb:Container runat="server" id="wtOtherAgency" onDataBinding="cntOtherAgency_onDataBinding" GridCssClasses="ThemeGrid_Width5" style="margin-left: 0px; margin-top: 10px"><osweb:Container runat="server" id="wt_Container6" anonymous="true" onDataBinding="cnt_Container6_onDataBinding" GridCssClasses="ThemeGrid_Width2"><osweb:PlaceHolder runat="server"><%# "Other" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container2" anonymous="true" onDataBinding="cnt_Container2_onDataBinding" GridCssClasses="ThemeGrid_Width3 ThemeGrid_MarginGutter"><osweb:TextBox runat="server" id="wt_Input1" GridCssClasses="OSFillParent" Visible="<%# inputwt_Input1_isVisible() %>" ReadOnly="<%# !inputwt_Input1_isEnabled() %>" maxlength="50" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" OnDefaultTypeValidationMessage="GetTextValidatorMsg" textmode="SingleLine" text="<%# inputwt_Input1_input_value() %>" onTextChanged="inputwt_Input1_input_onTextChanged" Mandatory="<%# inputwt_Input1_isMandatory() %>"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wt_Input1ValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wt_Input1"/><osweb:TextValidator runat="server" display="Dynamic" id="wt_Input1ValidatorType" ErrorMessage="<%# CaseConferencing_Properties.TextValidatorMsg %>" ControlToValidate="wt_Input1" ClientValidationFunction="OsCustomValidatorText"/></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container20" anonymous="true" onDataBinding="cnt_Container20_onDataBinding" GridCssClasses="ThemeGrid_Width5" style="margin-left: 0px; margin-top: 10px"><osweb:Container runat="server" id="wt_Container9" anonymous="true" onDataBinding="cnt_Container9_onDataBinding" GridCssClasses="ThemeGrid_Width2"><osweb:PlaceHolder runat="server"><%# "Contact Name" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container3" anonymous="true" onDataBinding="cnt_Container3_onDataBinding" GridCssClasses="ThemeGrid_Width3 ThemeGrid_MarginGutter"><osweb:TextBox runat="server" id="wt_Input10" GridCssClasses="OSFillParent" Visible="<%# inputwt_Input10_isVisible() %>" ReadOnly="<%# !inputwt_Input10_isEnabled() %>" maxlength="50" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" OnDefaultTypeValidationMessage="GetTextValidatorMsg" textmode="SingleLine" text="<%# inputwt_Input10_input_value() %>" onTextChanged="inputwt_Input10_input_onTextChanged" Mandatory="<%# inputwt_Input10_isMandatory() %>"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wt_Input10ValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wt_Input10"/><osweb:TextValidator runat="server" display="Dynamic" id="wt_Input10ValidatorType" ErrorMessage="<%# CaseConferencing_Properties.TextValidatorMsg %>" ControlToValidate="wt_Input10" ClientValidationFunction="OsCustomValidatorText"/></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container11" anonymous="true" onDataBinding="cnt_Container11_onDataBinding" GridCssClasses="ThemeGrid_Width5" style="margin-left: 0px; margin-top: 10px"><osweb:Container runat="server" id="wt_Container21" anonymous="true" onDataBinding="cnt_Container21_onDataBinding" GridCssClasses="ThemeGrid_Width2"><osweb:PlaceHolder runat="server"><%# "Contact Number" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container25" anonymous="true" onDataBinding="cnt_Container25_onDataBinding" GridCssClasses="ThemeGrid_Width3 ThemeGrid_MarginGutter" align="right"><osweb:TextBox runat="server" id="wt_Input8" GridCssClasses="OSFillParent" Visible="<%# inputwt_Input8_isVisible() %>" ReadOnly="<%# !inputwt_Input8_isEnabled() %>" maxlength="50" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" OnDefaultTypeValidationMessage="GetTextValidatorMsg" textmode="SingleLine" text="<%# inputwt_Input8_input_value() %>" onTextChanged="inputwt_Input8_input_onTextChanged" Mandatory="<%# inputwt_Input8_isMandatory() %>"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wt_Input8ValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wt_Input8"/><osweb:TextValidator runat="server" display="Dynamic" id="wt_Input8ValidatorType" ErrorMessage="<%# CaseConferencing_Properties.TextValidatorMsg %>" ControlToValidate="wt_Input8" ClientValidationFunction="OsCustomValidatorText"/></osweb:Container></osweb:Container><osweb:Container runat="server" id="wtButtonWrapper" onDataBinding="cntButtonWrapper_onDataBinding" GridCssClasses="ThemeGrid_Width5" style="margin-left: 0px; margin-top: 10px" align="right"><osweb:Button runat="server" id="wtOkButton" cssClass="Button Is_Default" Visible="<%# btnOkButton_isVisible() %>" Enabled="<%# btnOkButton_isEnabled() %>" CausesValidation="false" text="<%# btnOkButton_getLabel() %>"/><osweb:Button runat="server" id="wtCancelButton" cssClass="Button" GridCssClasses="ThemeGrid_MarginGutter" Visible="<%# btnCancelButton_isVisible() %>" Enabled="<%# btnCancelButton_isEnabled() %>" CausesValidation="false" text="<%# btnCancelButton_getLabel() %>"/></osweb:Container></osweb:Container></osweb:Container><osweb:DummySubmitLink runat="server" id="Dummy_Submit_Link"/>
    <%= OutSystems.HubEdition.RuntimePlatform.AppInfo.GetAppInfo().GetWatermark() %><%= GetCallbackDebug()	
%><%= GetVisitCode() %></osweb:Form><%= GetEndPageJavaScript() + GetBodyBottomJavaScript() %>
  </osweb:Body>
</html>