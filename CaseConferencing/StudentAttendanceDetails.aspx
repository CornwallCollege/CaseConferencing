﻿<%@ Page Language="c#" Codebehind="StudentAttendanceDetails.aspx.cs" AutoEventWireup="false" Inherits="ssCaseConferencing.Flows.FlowLearnerView.ScrnStudentAttendanceDetails" %><%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %><%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %><%@ Import namespace="ssCaseConferencing" %><%@ Import namespace="OutSystems.HubEdition.RuntimePlatform" %>
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
<osweb:Container runat="server" id="wt_Container7" anonymous="true" onDataBinding="cnt_Container7_onDataBinding" cssClass="AttendanceContainer"><osweb:Container runat="server" id="wt_Container27" anonymous="true" onDataBinding="cnt_Container27_onDataBinding"><osweb:Container runat="server" id="wt_Container32" anonymous="true" onDataBinding="cnt_Container32_onDataBinding" GridCssClasses="OSInline" style="width: 380px"><osweb:PlaceHolder runat="server"><%# "Offering : " %></osweb:PlaceHolder><osweb:DropDownList runat="server" id="wt_ComboBox44" onDataBinding="sel_ComboBox44_onDataBinding" onAjaxChange="sel_ComboBox44_AjaxChange" style="width: 300px" Visible="<%# sel_ComboBox44_isVisible() %>" Enabled="<%# sel_ComboBox44_isEnabled() %>" OnSelectedIndexChanged="sel_ComboBox44_dropDown_valueChanged" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" Mandatory="<%# sel_ComboBox44_isMandatory() %>"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wt_ComboBox44ValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wt_ComboBox44"/></osweb:Container><osweb:Container runat="server" id="wt_Container9" anonymous="true" onDataBinding="cnt_Container9_onDataBinding" GridCssClasses="OSInline" style="width: 260px"><osweb:PlaceHolder runat="server"><%# "Period : " %></osweb:PlaceHolder><osweb:DropDownList runat="server" id="wt_ComboBox10" onDataBinding="sel_ComboBox10_onDataBinding" onAjaxChange="sel_ComboBox10_AjaxChange" style="width: 200px" Visible="<%# sel_ComboBox10_isVisible() %>" Enabled="<%# sel_ComboBox10_isEnabled() %>" OnSelectedIndexChanged="sel_ComboBox10_dropDown_valueChanged" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" Mandatory="<%# sel_ComboBox10_isMandatory() %>"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wt_ComboBox10ValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wt_ComboBox10"/></osweb:Container><osweb:Container runat="server" id="wt_Container13" anonymous="true" onDataBinding="cnt_Container13_onDataBinding" GridCssClasses="OSInline" style="width: 200px"><osweb:PlaceHolder runat="server"><%# "Style :" %></osweb:PlaceHolder><osweb:DropDownList runat="server" id="wtLayoutTypeSelected" onDataBinding="selLayoutTypeSelected_onDataBinding" onAjaxChange="selLayoutTypeSelected_AjaxChange" GridCssClasses="ThemeGrid_Width2 ThemeGrid_MarginGutter" Visible="<%# selLayoutTypeSelected_isVisible() %>" Enabled="<%# selLayoutTypeSelected_isEnabled() %>" OnSelectedIndexChanged="selLayoutTypeSelected_dropDown_valueChanged" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" Mandatory="<%# selLayoutTypeSelected_isMandatory() %>"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wtLayoutTypeSelectedValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wtLayoutTypeSelected"/></osweb:Container></osweb:Container><osweb:Container runat="server" id="wtTitleContainer" onDataBinding="cntTitleContainer_onDataBinding"></osweb:Container><osweb:Container runat="server" id="wtTableHTMLContainer" onDataBinding="cntTableHTMLContainer_onDataBinding" cssClass="AttendanceDataContainer"><osweb:PlaceHolder runat="server"><%# expression_InlineExpression54() %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wtLegend" onDataBinding="cntLegend_onDataBinding" cssClass="AttendanceDataContainer"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If18() %>"><osweb:Table runat="server" id="wt_Table38" anonymous="true" GridCssClasses="OSFillParent"><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_TableCell19" anonymous="true" class="Green" style="width: 20px"></osweb:Td><osweb:Td runat="server" id="wt_TableCell46" anonymous="true" style="width: 180px"><osweb:PlaceHolder runat="server"><%# "Present" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_TableCell33" anonymous="true" class="Red" style="width: 20px"></osweb:Td><osweb:Td runat="server" id="wt_TableCell51" anonymous="true" style="width: 180px"><osweb:PlaceHolder runat="server"><%# "Absent" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_TableCell8" anonymous="true" class="Red CornerCut" style="width: 20px"></osweb:Td><osweb:Td runat="server" id="wt_TableCell30" anonymous="true" style="width: 180px"><osweb:PlaceHolder runat="server"><%# "Auth/Notified Absence" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_TableCell24" anonymous="true" class="Amber" style="width: 20px"></osweb:Td><osweb:Td runat="server" id="wt_TableCell16" anonymous="true" style="width: 180px"><osweb:PlaceHolder runat="server"><%# "Late" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_TableCell59" anonymous="true" class="Blue" style="width: 20px"></osweb:Td><osweb:Td runat="server" id="wt_TableCell60" anonymous="true" style="width: 180px"><osweb:PlaceHolder runat="server"><%# "Not marked" %></osweb:PlaceHolder></osweb:Td></osweb:Tr></osweb:Table></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If18() %>"><osweb:Table runat="server" id="wt_Table1" anonymous="true" GridCssClasses="OSFillParent"><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_TableCell40" anonymous="true" onDataBinding="wt_TableCell40_onDataBinding" style="width: 20px"><osweb:PlaceHolder runat="server"><%# "/" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_TableCell26" anonymous="true" style="width: 180px"><osweb:PlaceHolder runat="server"><%# "Present" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_TableCell56" anonymous="true" onDataBinding="wt_TableCell56_onDataBinding" style="width: 20px"><osweb:PlaceHolder runat="server"><%# "O" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_TableCell12" anonymous="true" style="width: 180px"><osweb:PlaceHolder runat="server"><%# "Absent" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_TableCell47" anonymous="true" onDataBinding="wt_TableCell47_onDataBinding" style="width: 20px"><osweb:PlaceHolder runat="server"><%# "N" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_TableCell28" anonymous="true" style="width: 180px"><osweb:PlaceHolder runat="server"><%# "Notified Absence" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_TableCell37" anonymous="true" onDataBinding="wt_TableCell37_onDataBinding" style="width: 20px"><osweb:PlaceHolder runat="server"><%# "A" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_TableCell5" anonymous="true" style="width: 180px"><osweb:PlaceHolder runat="server"><%# "Authorised Absence" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_TableCell42" anonymous="true" onDataBinding="wt_TableCell42_onDataBinding" style="width: 20px"><osweb:PlaceHolder runat="server"><%# "L" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_TableCell36" anonymous="true" style="width: 180px"><osweb:PlaceHolder runat="server"><%# "Late" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_TableCell43" anonymous="true" onDataBinding="wt_TableCell43_onDataBinding" style="width: 20px"><osweb:PlaceHolder runat="server"><%# "-" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_TableCell58" anonymous="true" style="width: 180px"><osweb:PlaceHolder runat="server"><%# "Not marked" %></osweb:PlaceHolder></osweb:Td></osweb:Tr></osweb:Table></osweb:If></osweb:IfPlaceHolder></osweb:Container></osweb:Container><osweb:DummySubmitLink runat="server" id="Dummy_Submit_Link"/>
    <%= OutSystems.HubEdition.RuntimePlatform.AppInfo.GetAppInfo().GetWatermark() %><%= GetCallbackDebug()	
%><%= GetVisitCode() %></osweb:Form><%= GetEndPageJavaScript() + GetBodyBottomJavaScript() %>
  </osweb:Body>
</html>
