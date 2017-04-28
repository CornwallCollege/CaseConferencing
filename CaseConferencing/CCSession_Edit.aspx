﻿<%@ Page Language="c#" Codebehind="CCSession_Edit.aspx.cs" AutoEventWireup="false" Inherits="ssCaseConferencing.Flows.FlowCaseConference.ScrnCCSession_Edit" %><%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %><%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %><%@ Import namespace="ssCaseConferencing" %><%@ Import namespace="OutSystems.HubEdition.RuntimePlatform" %><%@ Register TagPrefix="ThemeProvider_widgets" TagName="Ky1nG5kdyhEesTpKvn40S7g" Src="Blocks\CaseConferencing\MainLayouts\Layout_Main.ascx" %><%@ Register TagPrefix="widgets" TagName="KfpAa79RrRUaQSPrU6XYoGA" Src="Blocks\CaseConferencing\Common\HelpUpdate.ascx" %><%@ Register TagPrefix="ThemeProvider_widgets" TagName="KJrizqP2Bv0eGnyXPhkrA3w" Src="Blocks\CaseConferencing\MainLayouts\Menu_Main.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="Blocks\CaseConferencing\RichWidgets\Icon.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="KiOBZ_DLj1CK2uSfNSLcEUg" Src="Blocks\CaseConferencing\RichWidgets\Input_Calendar.ascx" %><%@ Register TagPrefix="widgets" TagName="KVnTC_zyVWkm_9jlM3KeLpQ" Src="Blocks\CaseConferencing\CaseConference\CCSessionAttachedDocuments.ascx" %><%@ Register TagPrefix="widgets" TagName="KzPwyJqX4kk6_Ortbq1_fXw" Src="Blocks\CaseConferencing\CaseConference\ProgressBar.ascx" %>
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
<ThemeProvider_widgets:Ky1nG5kdyhEesTpKvn40S7g runat="server" id="ThemeProvider_wt_WebBlockInstance80" OnEvaluateParameters="ThemeProvider_webBlck_WebBlockInstance80_onDataBinding" InstanceID="_WebBlockInstance80"><phHelpUpdate><widgets:KfpAa79RrRUaQSPrU6XYoGA runat="server" id="wt_WebBlockInstance53" OnEvaluateParameters="webBlck_WebBlockInstance53_onDataBinding" InstanceID="_WebBlockInstance53"></widgets:KfpAa79RrRUaQSPrU6XYoGA></phHelpUpdate><phHeaderActions><ThemeProvider_widgets:KJrizqP2Bv0eGnyXPhkrA3w runat="server" id="ThemeProvider_wt_WebBlockInstance57" OnEvaluateParameters="ThemeProvider_webBlck_WebBlockInstance57_onDataBinding" InstanceID="_WebBlockInstance57"></ThemeProvider_widgets:KJrizqP2Bv0eGnyXPhkrA3w></phHeaderActions><phTitle><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If73() %>"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance95" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance95_onDataBinding" InstanceID="_WebBlockInstance95"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression88()) %></osweb:PlaceHolder></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If73() %>"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance59" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance59_onDataBinding" InstanceID="_WebBlockInstance59"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression78()) %></osweb:PlaceHolder></osweb:If></osweb:IfPlaceHolder></phTitle><phActions></phActions><phMainContent><osweb:Container runat="server" id="wt_Container14" anonymous="true" onDataBinding="cnt_Container14_onDataBinding" cssClass="SessionEditWrapper"><osweb:Container runat="server" id="wt_Container100" anonymous="true" onDataBinding="cnt_Container100_onDataBinding" cssClass="ColumnStyle" GridCssClasses="OSInline" style="min-height: 388px"><osweb:Container runat="server" id="wt_Container20" anonymous="true" onDataBinding="cnt_Container20_onDataBinding" cssClass="CardCurriculumLeadTitle" align="center"><osweb:PlaceHolder runat="server"><%# "Session Info" %></osweb:PlaceHolder></osweb:Container><osweb:EditRecord runat="server" id="wtCCSessionEdit" GridCssClasses="ThemeGrid_Width8" style="border-spacing: 5px" cellspacing="5" border="0"><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_EditRecordCell96" anonymous="true" class="CardTitle" GridCssClasses="ThemeGrid_Width2"><osweb:PlaceHolder runat="server"><%# "Cluster" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_EditRecordCell81" anonymous="true" class="EditRecord_Value"><osweb:DynamicImage runat="server" id="wt_Image7" anonymous="true" Source="<%# img_Image7_getURL() %>" ImageType="External" Height="<%# System.Web.UI.WebControls.Unit.Parse(img_Image7_actualHeight(), System.Globalization.CultureInfo.InvariantCulture) %>" alt=""/><osweb:Container runat="server" id="wt_Container24" anonymous="true" onDataBinding="cnt_Container24_onDataBinding" GridCssClasses="OSInline ThemeGrid_MarginGutter"><osweb:Container runat="server" id="wt_Container46" anonymous="true" onDataBinding="cnt_Container46_onDataBinding" cssClass="CardTitle" GridCssClasses="ThemeGrid_Width5" align="left"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression85()) %></osweb:PlaceHolder></osweb:Container></osweb:Container></osweb:Td></osweb:Tr><osweb:Tr runat="server" onDataBinding="wt_EditRecordRow51_onDataBinding"><osweb:Td runat="server" id="wt_EditRecordCell74" anonymous="true" class="CardTitle" GridCssClasses="ThemeGrid_Width2"><osweb:PlaceHolder runat="server"><%# "Start Date" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_EditRecordCell92" anonymous="true" class="EditRecord_Value"><osweb:TextBox runat="server" id="wtCCSession_StartDate" style="width: 110px" Visible="<%# inputwtCCSession_StartDate_isVisible() %>" ReadOnly="<%# !inputwtCCSession_StartDate_isEnabled() %>" maxlength="20" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" OnDefaultTypeValidationMessage="GetDateTimeValidatorMsg" textmode="SingleLine" text="<%# inputwtCCSession_StartDate_input_value() %>" onTextChanged="inputwtCCSession_StartDate_input_onTextChanged" Mandatory="<%# inputwtCCSession_StartDate_isMandatory() %>" parentEditRecord="wtCCSessionEdit"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wtCCSession_StartDateValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wtCCSession_StartDate"/><osweb:TextValidator runat="server" display="Dynamic" id="wtCCSession_StartDateValidatorType" ErrorMessage="<%# CaseConferencing_Properties.DateTimeValidatorMsg %>" ControlToValidate="wtCCSession_StartDate" ClientValidationFunction="OsCustomValidatorDateTime"/><RichWidgets_widgets:KiOBZ_DLj1CK2uSfNSLcEUg runat="server" id="RichWidgets_wt_WebBlockInstance39" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance39_onDataBinding" InstanceID="_WebBlockInstance39"></RichWidgets_widgets:KiOBZ_DLj1CK2uSfNSLcEUg></osweb:Td></osweb:Tr><osweb:Tr runat="server" onDataBinding="wt_EditRecordRow17_onDataBinding"><osweb:Td runat="server" id="wt_EditRecordCell25" anonymous="true" class="CardTitle" GridCssClasses="ThemeGrid_Width2"><osweb:Span runat="server" id="wt_Text70" anonymous="true" class="CardTitle"><%# "End Date" %></osweb:Span></osweb:Td><osweb:Td runat="server" id="wt_EditRecordCell54" anonymous="true" class="EditRecord_Value"><osweb:TextBox runat="server" id="wtCCSession_EndDate" style="width: 110px" Visible="<%# inputwtCCSession_EndDate_isVisible() %>" ReadOnly="<%# !inputwtCCSession_EndDate_isEnabled() %>" maxlength="20" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" OnDefaultTypeValidationMessage="GetDateTimeValidatorMsg" textmode="SingleLine" text="<%# inputwtCCSession_EndDate_input_value() %>" onTextChanged="inputwtCCSession_EndDate_input_onTextChanged" Mandatory="<%# inputwtCCSession_EndDate_isMandatory() %>" parentEditRecord="wtCCSessionEdit"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wtCCSession_EndDateValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wtCCSession_EndDate"/><osweb:TextValidator runat="server" display="Dynamic" id="wtCCSession_EndDateValidatorType" ErrorMessage="<%# CaseConferencing_Properties.DateTimeValidatorMsg %>" ControlToValidate="wtCCSession_EndDate" ClientValidationFunction="OsCustomValidatorDateTime"/><RichWidgets_widgets:KiOBZ_DLj1CK2uSfNSLcEUg runat="server" id="RichWidgets_wt_WebBlockInstance42" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance42_onDataBinding" InstanceID="_WebBlockInstance42"></RichWidgets_widgets:KiOBZ_DLj1CK2uSfNSLcEUg></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_EditRecordCell5" anonymous="true" class="CardTitle" GridCssClasses="ThemeGrid_Width2"><osweb:PlaceHolder runat="server"><%# "Description" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_EditRecordCell103" anonymous="true" class="EditRecord_Value"><osweb:TextBox runat="server" id="wtCCSession_Description" GridCssClasses="ThemeGrid_Width7" Visible="<%# inputwtCCSession_Description_isVisible() %>" ReadOnly="<%# !inputwtCCSession_Description_isEnabled() %>" maxlength="300" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" OnDefaultTypeValidationMessage="GetTextValidatorMsg" textmode="SingleLine" text="<%# inputwtCCSession_Description_input_value() %>" onTextChanged="inputwtCCSession_Description_input_onTextChanged" Mandatory="<%# inputwtCCSession_Description_isMandatory() %>" parentEditRecord="wtCCSessionEdit"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wtCCSession_DescriptionValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wtCCSession_Description"/><osweb:TextValidator runat="server" display="Dynamic" id="wtCCSession_DescriptionValidatorType" ErrorMessage="<%# CaseConferencing_Properties.TextValidatorMsg %>" ControlToValidate="wtCCSession_Description" ClientValidationFunction="OsCustomValidatorText"/></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_EditRecordCell6" anonymous="true" class="CardTitle" GridCssClasses="ThemeGrid_Width2"><osweb:Span runat="server" id="wt_Text47" anonymous="true" class="CardTitle"><%# "Notes" %></osweb:Span></osweb:Td><osweb:Td runat="server" id="wt_EditRecordCell16" anonymous="true" class="EditRecord_Value"><osweb:TextBox runat="server" id="wtCCSession_Notes" GridCssClasses="ThemeGrid_Width7" Visible="<%# inputwtCCSession_Notes_isVisible() %>" ReadOnly="<%# !inputwtCCSession_Notes_isEnabled() %>" maxlength="1000" onchange="OsLimitInput(this,event,1000);" onkeyup="OsLimitInput(this,event,1000);" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" OnDefaultTypeValidationMessage="GetTextValidatorMsg" textmode="MultiLine" rows="2" text="<%# inputwtCCSession_Notes_input_value() %>" onTextChanged="inputwtCCSession_Notes_input_onTextChanged" Mandatory="<%# inputwtCCSession_Notes_isMandatory() %>" parentEditRecord="wtCCSessionEdit"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wtCCSession_NotesValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wtCCSession_Notes"/><osweb:TextValidator runat="server" display="Dynamic" id="wtCCSession_NotesValidatorType" ErrorMessage="<%# CaseConferencing_Properties.TextValidatorMsg %>" ControlToValidate="wtCCSession_Notes" ClientValidationFunction="OsCustomValidatorText"/></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_EditRecordCell33" anonymous="true" class="EditRecord_Caption" GridCssClasses="ThemeGrid_Width2"><osweb:PlaceHolder runat="server"><%# "Minutes/Other" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_EditRecordCell62" anonymous="true" class="EditRecord_Value"><osweb:Container runat="server" id="wt_Container4" anonymous="true" onDataBinding="cnt_Container4_onDataBinding"><widgets:KVnTC_zyVWkm_9jlM3KeLpQ runat="server" id="wt_WebBlockInstance27" OnEvaluateParameters="webBlck_WebBlockInstance27_onDataBinding" InstanceID="_WebBlockInstance27"></widgets:KVnTC_zyVWkm_9jlM3KeLpQ></osweb:Container></osweb:Td></osweb:Tr><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_EditRecordCell13" anonymous="true" class="EditRecord_Caption" GridCssClasses="ThemeGrid_Width2"></osweb:Td><osweb:Td runat="server" id="wt_EditRecordCell87" anonymous="true" class="EditRecord_Value"><osweb:Container runat="server" id="wt_Container67" anonymous="true" onDataBinding="cnt_Container67_onDataBinding" GridCssClasses="ThemeGrid_Width7" align="right"><osweb:LinkButton runat="server" id="wtEndSession" onDataBinding="lnkEndSession_onDataBinding" Visible="<%# lnkEndSession_isVisible() %>" Enabled="<%# lnkEndSession_isEnabled() %>" CausesValidation="false"></osweb:LinkButton><osweb:Container runat="server" id="wt_Container50" anonymous="true" onDataBinding="cnt_Container50_onDataBinding" onAjaxClick="cnt_Container50_AjaxClick" cssClass="HeaderButton" GridCssClasses="OSInline" style="width: 110px" align="center"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance56" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance56_onDataBinding" InstanceID="_WebBlockInstance56"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# " Continue Session" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container68" anonymous="true" onDataBinding="cnt_Container68_onDataBinding" onAjaxClick="cnt_Container68_AjaxClick" cssClass="HeaderButton" GridCssClasses="OSInline" style="width: 100px; margin-left: 10px" align="center"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance71" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance71_onDataBinding" InstanceID="_WebBlockInstance71"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# " Save" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container104" anonymous="true" onDataBinding="cnt_Container104_onDataBinding" onAjaxClick="cnt_Container104_AjaxClick" cssClass="HeaderButton" GridCssClasses="OSInline" style="width: 100px; margin-left: 10px" align="center"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance34" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance34_onDataBinding" InstanceID="_WebBlockInstance34"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# "  Start Session" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container11" anonymous="true" onDataBinding="cnt_Container11_onDataBinding" cssClass="HeaderButton" GridCssClasses="OSInline" style="width: 100px; margin-left: 10px" align="center"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance28" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance28_onDataBinding" InstanceID="_WebBlockInstance28"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# " End Session" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container102" anonymous="true" onDataBinding="cnt_Container102_onDataBinding" onAjaxClick="cnt_Container102_AjaxClick" cssClass="HeaderButton" GridCssClasses="OSInline" style="width: 110px; margin-left: 10px" align="center"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance19" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance19_onDataBinding" InstanceID="_WebBlockInstance19"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# " Re-Open Session" %></osweb:PlaceHolder></osweb:Container></osweb:Container></osweb:Td></osweb:Tr></osweb:EditRecord></osweb:Container><osweb:Container runat="server" id="wt_Container89" anonymous="true" onDataBinding="cnt_Container89_onDataBinding" GridCssClasses="ThemeGrid_Width5 ThemeGrid_MarginGutter"><osweb:Container runat="server" id="wtCurriculumLead" onDataBinding="cntCurriculumLead_onDataBinding" cssClass="ColumnStyle" GridCssClasses="OSInline" style="width: 300px; min-height: 387px"><osweb:Container runat="server" id="wt_Container79" anonymous="true" onDataBinding="cnt_Container79_onDataBinding" cssClass="CardCurriculumLeadTitle" align="center"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance3" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance3_onDataBinding" InstanceID="_WebBlockInstance3"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:Container runat="server" id="wt_Container75" anonymous="true" onDataBinding="cnt_Container75_onDataBinding" GridCssClasses="OSInline" style="margin-left: 10px"><osweb:PlaceHolder runat="server"><%# "Session Stats" %></osweb:PlaceHolder></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container45" anonymous="true" onDataBinding="cnt_Container45_onDataBinding" cssClass="ColumnBlock" style="margin-top: 10px" align="center"><osweb:Container runat="server" id="wt_Container76" anonymous="true" onDataBinding="cnt_Container76_onDataBinding" onAjaxClick="cnt_Container76_AjaxClick" cssClass="CardCurriculumLead" style="margin-top: 10px"><osweb:Container runat="server" id="wt_Container82" anonymous="true" onDataBinding="cnt_Container82_onDataBinding" cssClass="CardTitle" GridCssClasses="OSInline" style="width: 100%" align="left"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression43()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container31" anonymous="true" onDataBinding="cnt_Container31_onDataBinding" GridCssClasses="OSAutoMarginTop"><osweb:LinkButton runat="server" id="wt_Link83" Visible="<%# lnk_Link83_isVisible() %>" Enabled="<%# lnk_Link83_isEnabled() %>" CausesValidation="false"><widgets:KzPwyJqX4kk6_Ortbq1_fXw runat="server" id="wt_WebBlockInstance94" onAjaxNotify="webBlck_WebBlockInstance94_AjaxNotify" OnEvaluateParameters="webBlck_WebBlockInstance94_onDataBinding" InstanceID="_WebBlockInstance94"></widgets:KzPwyJqX4kk6_Ortbq1_fXw></osweb:LinkButton></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container48" anonymous="true" onDataBinding="cnt_Container48_onDataBinding" onAjaxClick="cnt_Container48_AjaxClick" cssClass="CardCurriculumLead" style="margin-top: 10px"><osweb:Container runat="server" id="wt_Container2" anonymous="true" onDataBinding="cnt_Container2_onDataBinding" cssClass="CardTitle" GridCssClasses="OSInline" style="width: 100%" align="left"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression84()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container63" anonymous="true" onDataBinding="cnt_Container63_onDataBinding" GridCssClasses="OSAutoMarginTop"><widgets:KzPwyJqX4kk6_Ortbq1_fXw runat="server" id="wt_WebBlockInstance44" onAjaxNotify="webBlck_WebBlockInstance44_AjaxNotify" OnEvaluateParameters="webBlck_WebBlockInstance44_onDataBinding" InstanceID="_WebBlockInstance44"></widgets:KzPwyJqX4kk6_Ortbq1_fXw></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container91" anonymous="true" onDataBinding="cnt_Container91_onDataBinding" onAjaxClick="cnt_Container91_AjaxClick" cssClass="CardCurriculumLead" style="margin-top: 10px"><osweb:Container runat="server" id="wt_Container66" anonymous="true" onDataBinding="cnt_Container66_onDataBinding" cssClass="CardTitle" GridCssClasses="OSInline" style="width: 100%" align="left"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression77()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container26" anonymous="true" onDataBinding="cnt_Container26_onDataBinding" GridCssClasses="OSAutoMarginTop"><widgets:KzPwyJqX4kk6_Ortbq1_fXw runat="server" id="wt_WebBlockInstance30" onAjaxNotify="webBlck_WebBlockInstance30_AjaxNotify" OnEvaluateParameters="webBlck_WebBlockInstance30_onDataBinding" InstanceID="_WebBlockInstance30"></widgets:KzPwyJqX4kk6_Ortbq1_fXw></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container64" anonymous="true" onDataBinding="cnt_Container64_onDataBinding" onAjaxClick="cnt_Container64_AjaxClick" cssClass="CardCurriculumLead" style="margin-top: 10px"><osweb:Container runat="server" id="wt_Container38" anonymous="true" onDataBinding="cnt_Container38_onDataBinding" cssClass="CardTitle" GridCssClasses="OSInline" style="width: 100%" align="left"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression18()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container90" anonymous="true" onDataBinding="cnt_Container90_onDataBinding" GridCssClasses="OSAutoMarginTop"><widgets:KzPwyJqX4kk6_Ortbq1_fXw runat="server" id="wt_WebBlockInstance86" onAjaxNotify="webBlck_WebBlockInstance86_AjaxNotify" OnEvaluateParameters="webBlck_WebBlockInstance86_onDataBinding" InstanceID="_WebBlockInstance86"></widgets:KzPwyJqX4kk6_Ortbq1_fXw></osweb:Container></osweb:Container></osweb:Container></osweb:Container></osweb:Container></osweb:Container></phMainContent></ThemeProvider_widgets:Ky1nG5kdyhEesTpKvn40S7g><osweb:DummySubmitLink runat="server" id="Dummy_Submit_Link"/>
    <%= OutSystems.HubEdition.RuntimePlatform.AppInfo.GetAppInfo().GetWatermark() %><%= GetCallbackDebug()	
%><%= GetVisitCode() %></osweb:Form><%= GetEndPageJavaScript() + GetBodyBottomJavaScript() %>
  </osweb:Body>
</html>
