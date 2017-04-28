﻿<%@ Page Language="c#" Codebehind="Courses.Popup_Target.aspx.cs" AutoEventWireup="false" Inherits="ssCaseConferencing.Flows.FlowCourses.ScrnPopup_Target" %><%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %><%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %><%@ Import namespace="ssCaseConferencing" %><%@ Import namespace="OutSystems.HubEdition.RuntimePlatform" %><%@ Register TagPrefix="widgets" TagName="KHtW7GNYBskijYiZHuvzUvw" Src="Blocks\CaseConferencing\Common\Popup_Editor_Layout.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="Blocks\CaseConferencing\RichWidgets\Icon.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="KiOBZ_DLj1CK2uSfNSLcEUg" Src="Blocks\CaseConferencing\RichWidgets\Input_Calendar.ascx" %>
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
<widgets:KHtW7GNYBskijYiZHuvzUvw runat="server" id="wt_WebBlockInstance35" OnEvaluateParameters="webBlck_WebBlockInstance35_onDataBinding" InstanceID="_WebBlockInstance35"><phTitle><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance23" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance23_onDataBinding" InstanceID="_WebBlockInstance23"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# "New Target" %></osweb:PlaceHolder></phTitle><phContent><osweb:EditRecord runat="server" id="wtTargetEdit" GridCssClasses="ThemeGrid_Width6" border="0"><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_EditRecordCell14" anonymous="true" class="EditRecord_Caption" GridCssClasses="ThemeGrid_Width2"><osweb:PlaceHolder runat="server"><%# "Course" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_EditRecordCell26" anonymous="true" class="EditRecord_Value"><osweb:Span runat="server" id="wt_InlineExpression37" anonymous="true" onDataBinding="expression_InlineExpression37_onDataBinding"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression37()) %></osweb:Span></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_EditRecordCell15" anonymous="true" class="EditRecord_Caption" GridCssClasses="ThemeGrid_Width2"><osweb:PlaceHolder runat="server"><%# "Offering Category" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_EditRecordCell45" anonymous="true" class="EditRecord_Value"><osweb:DropDownList runat="server" id="wtTarget_OfferingCategory" onDataBinding="selTarget_OfferingCategory_onDataBinding" GridCssClasses="ThemeGrid_Width4" Visible="<%# selTarget_OfferingCategory_isVisible() %>" Enabled="<%# selTarget_OfferingCategory_isEnabled() %>" OnSelectedIndexChanged="selTarget_OfferingCategory_dropDown_valueChanged" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" Mandatory="<%# selTarget_OfferingCategory_isMandatory() %>" parentEditRecord="wtTargetEdit"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wtTarget_OfferingCategoryValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wtTarget_OfferingCategory"/></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_EditRecordCell55" anonymous="true" class="EditRecord_Caption" GridCssClasses="ThemeGrid_Width2"><osweb:PlaceHolder runat="server"><%# "Type" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_EditRecordCell31" anonymous="true" class="EditRecord_Value"><osweb:DropDownList runat="server" id="wtTarget_TargetTypeId" onDataBinding="selTarget_TargetTypeId_onDataBinding" GridCssClasses="ThemeGrid_Width4" Visible="<%# selTarget_TargetTypeId_isVisible() %>" Enabled="<%# selTarget_TargetTypeId_isEnabled() %>" OnSelectedIndexChanged="selTarget_TargetTypeId_dropDown_valueChanged" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" Mandatory="<%# selTarget_TargetTypeId_isMandatory() %>" parentEditRecord="wtTargetEdit"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wtTarget_TargetTypeIdValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wtTarget_TargetTypeId"/></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_EditRecordCell46" anonymous="true" class="EditRecord_Caption" GridCssClasses="ThemeGrid_Width2"><osweb:PlaceHolder runat="server"><%# "Status" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_EditRecordCell41" anonymous="true" class="EditRecord_Value"><osweb:DropDownList runat="server" id="wtTarget_TargetStatusId" onDataBinding="selTarget_TargetStatusId_onDataBinding" GridCssClasses="ThemeGrid_Width4" Visible="<%# selTarget_TargetStatusId_isVisible() %>" Enabled="<%# selTarget_TargetStatusId_isEnabled() %>" OnSelectedIndexChanged="selTarget_TargetStatusId_dropDown_valueChanged" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" Mandatory="<%# selTarget_TargetStatusId_isMandatory() %>" parentEditRecord="wtTargetEdit"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wtTarget_TargetStatusIdValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wtTarget_TargetStatusId"/></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_EditRecordCell33" anonymous="true" class="EditRecord_Caption" GridCssClasses="ThemeGrid_Width2"><osweb:PlaceHolder runat="server"><%# "Target Date" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_EditRecordCell16" anonymous="true" class="EditRecord_Value"><osweb:TextBox runat="server" id="wtTarget_TargetDate" GridCssClasses="ThemeGrid_Width2" Visible="<%# inputwtTarget_TargetDate_isVisible() %>" ReadOnly="<%# !inputwtTarget_TargetDate_isEnabled() %>" maxlength="20" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" OnDefaultTypeValidationMessage="GetDateValidatorMsg" textmode="SingleLine" text="<%# inputwtTarget_TargetDate_input_value() %>" onTextChanged="inputwtTarget_TargetDate_input_onTextChanged" Mandatory="<%# inputwtTarget_TargetDate_isMandatory() %>" parentEditRecord="wtTargetEdit"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wtTarget_TargetDateValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wtTarget_TargetDate"/><osweb:TextValidator runat="server" display="Dynamic" id="wtTarget_TargetDateValidatorType" ErrorMessage="<%# CaseConferencing_Properties.DateValidatorMsg %>" ControlToValidate="wtTarget_TargetDate" ClientValidationFunction="OsCustomValidatorDate"/><RichWidgets_widgets:KiOBZ_DLj1CK2uSfNSLcEUg runat="server" id="RichWidgets_wt_WebBlockInstance4" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance4_onDataBinding" InstanceID="_WebBlockInstance4"></RichWidgets_widgets:KiOBZ_DLj1CK2uSfNSLcEUg></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_EditRecordCell7" anonymous="true" class="EditRecord_Caption" GridCssClasses="ThemeGrid_Width2"><osweb:PlaceHolder runat="server"><%# "Title" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_EditRecordCell9" anonymous="true" class="EditRecord_Value"><osweb:TextBox runat="server" id="wtTarget_TargetHeader" GridCssClasses="ThemeGrid_Width4" Visible="<%# inputwtTarget_TargetHeader_isVisible() %>" ReadOnly="<%# !inputwtTarget_TargetHeader_isEnabled() %>" maxlength="250" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" OnDefaultTypeValidationMessage="GetTextValidatorMsg" textmode="SingleLine" text="<%# inputwtTarget_TargetHeader_input_value() %>" onTextChanged="inputwtTarget_TargetHeader_input_onTextChanged" Mandatory="<%# inputwtTarget_TargetHeader_isMandatory() %>" parentEditRecord="wtTargetEdit"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wtTarget_TargetHeaderValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wtTarget_TargetHeader"/><osweb:TextValidator runat="server" display="Dynamic" id="wtTarget_TargetHeaderValidatorType" ErrorMessage="<%# CaseConferencing_Properties.TextValidatorMsg %>" ControlToValidate="wtTarget_TargetHeader" ClientValidationFunction="OsCustomValidatorText"/></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_EditRecordCell22" anonymous="true" class="EditRecord_Caption" GridCssClasses="ThemeGrid_Width2"><osweb:PlaceHolder runat="server"><%# "Description" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_EditRecordCell50" anonymous="true" class="EditRecord_Value"><osweb:TextBox runat="server" id="wtTarget_TargetDescription" GridCssClasses="ThemeGrid_Width4" Visible="<%# inputwtTarget_TargetDescription_isVisible() %>" ReadOnly="<%# !inputwtTarget_TargetDescription_isEnabled() %>" maxlength="2000" onchange="OsLimitInput(this,event,2000);" onkeyup="OsLimitInput(this,event,2000);" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" OnDefaultTypeValidationMessage="GetTextValidatorMsg" textmode="MultiLine" rows="3" text="<%# inputwtTarget_TargetDescription_input_value() %>" onTextChanged="inputwtTarget_TargetDescription_input_onTextChanged" Mandatory="<%# inputwtTarget_TargetDescription_isMandatory() %>" parentEditRecord="wtTargetEdit"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wtTarget_TargetDescriptionValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wtTarget_TargetDescription"/><osweb:TextValidator runat="server" display="Dynamic" id="wtTarget_TargetDescriptionValidatorType" ErrorMessage="<%# CaseConferencing_Properties.TextValidatorMsg %>" ControlToValidate="wtTarget_TargetDescription" ClientValidationFunction="OsCustomValidatorText"/></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_EditRecordCell32" anonymous="true" class="EditRecord_Caption" GridCssClasses="ThemeGrid_Width2"><osweb:PlaceHolder runat="server"><%# "E-mail Target To Learners" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_EditRecordCell3" anonymous="true" class="EditRecord_Value"><osweb:CheckBox runat="server" id="wt_CheckBox21" Visible="<%# chk_CheckBox21_isVisible() %>" Enabled="<%# chk_CheckBox21_isEnabled() %>" Checked="<%# chk_CheckBox21_checked_value() %>" onCheckedChanged="chk_CheckBox21_checkbox_onCheckedChanged" parentEditRecord="wtTargetEdit"/></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_EditRecordCell20" anonymous="true" class="EditRecord_Caption" GridCssClasses="ThemeGrid_Width2"></osweb:Td><osweb:Td runat="server" id="wt_EditRecordCell48" anonymous="true" class="EditRecord_Value"><osweb:Container runat="server" id="wt_Container42" anonymous="true" onDataBinding="cnt_Container42_onDataBinding" align="right"><osweb:LinkButton runat="server" id="wtSave" onDataBinding="lnkSave_onDataBinding" Visible="<%# lnkSave_isVisible() %>" Enabled="<%# lnkSave_isEnabled() %>" CausesValidation="true" parentEditRecord="wtTargetEdit"></osweb:LinkButton><osweb:Container runat="server" id="wt_Container5" anonymous="true" onDataBinding="cnt_Container5_onDataBinding" cssClass="HeaderButton" GridCssClasses="OSInline" style="width: 60px; margin-left: 10px" align="center"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance24" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance24_onDataBinding" InstanceID="_WebBlockInstance24"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# " Save" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container53" anonymous="true" onDataBinding="cnt_Container53_onDataBinding" onAjaxClick="cnt_Container53_AjaxClick" cssClass="ButtonGrey" GridCssClasses="OSInline" style="width: 60px; margin-left: 10px" align="center"><osweb:PlaceHolder runat="server"><%# " Close" %></osweb:PlaceHolder></osweb:Container></osweb:Container></osweb:Td></osweb:Tr></osweb:EditRecord></phContent></widgets:KHtW7GNYBskijYiZHuvzUvw><osweb:DummySubmitLink runat="server" id="Dummy_Submit_Link"/>
    <%= OutSystems.HubEdition.RuntimePlatform.AppInfo.GetAppInfo().GetWatermark() %><%= GetCallbackDebug()	
%><%= GetVisitCode() %></osweb:Form><%= GetEndPageJavaScript() + GetBodyBottomJavaScript() %>
  </osweb:Body>
</html>