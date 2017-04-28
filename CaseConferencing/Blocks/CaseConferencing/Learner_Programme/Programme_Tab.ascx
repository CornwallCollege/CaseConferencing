﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\CaseConferencing\Learner_Programme\Programme_Tab.ascx.cs" Inherits="ssCaseConferencing.Flows.FlowLearner_Programme.WBlkProgramme_Tab,CaseConferencing" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssCaseConferencing" %>
<%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="..\..\CaseConferencing\RichWidgets\Icon.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="Kbbzz9S_an_V_uoCTOfsBiA" Src="..\..\CaseConferencing\RichWidgets\Popup_Editor.ascx" %><%@ Register TagPrefix="widgets" TagName="K1tHu2scNhke0DPtNY_WdAQ" Src="..\..\CaseConferencing\Common\DateFormatted.ascx" %><%@ Register TagPrefix="widgets" TagName="KSPhbYciuLE_man2Op3nABA" Src="LearnerDetails_ProgrammeInfo.ascx" %><%# PageStartHook() %><osweb:Container runat="server" id="wt_Container43" anonymous="true" onDataBinding="cnt_Container43_onDataBinding"><osweb:Container runat="server" id="wt_Container51" anonymous="true" onDataBinding="cnt_Container51_onDataBinding" cssClass="ProgressReportMenu" GridCssClasses="OSInline"><osweb:Container runat="server" id="wt_Container53" anonymous="true" onDataBinding="cnt_Container53_onDataBinding" style="margin-top: 0px"><osweb:Container runat="server" id="wtMenuTab" onDataBinding="cntMenuTab_onDataBinding"><osweb:Container runat="server" id="wtProgramme" onDataBinding="cntProgramme_onDataBinding" onAjaxClick="cntProgramme_AjaxClick" cssClass="ProgressReportMenuItem"><osweb:Container runat="server" id="wt_Container1" anonymous="true" onDataBinding="cnt_Container1_onDataBinding"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance31" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance31_onDataBinding" InstanceID="_WebBlockInstance31"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# " " %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression30()) %></osweb:PlaceHolder></osweb:Container></osweb:Container><osweb:Container runat="server" id="wtExamEntry" onDataBinding="cntExamEntry_onDataBinding" onAjaxClick="cntExamEntry_AjaxClick" cssClass="ProgressReportMenuItem" GridCssClasses="OSAutoMarginTop"><osweb:Container runat="server" id="wt_Container26" anonymous="true" onDataBinding="cnt_Container26_onDataBinding"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance27" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance27_onDataBinding" InstanceID="_WebBlockInstance27"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# " " %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression57()) %></osweb:PlaceHolder><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If74() %>"><osweb:Container runat="server" id="wt_Container10" anonymous="true" onDataBinding="cnt_Container10_onDataBinding"><osweb:Span runat="server" id="wt_InlineExpression35" anonymous="true" class="TextSmallLine"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression35()) %></osweb:Span></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If74() %>"></osweb:If></osweb:IfPlaceHolder></osweb:Container></osweb:Container></osweb:Container></osweb:Container></osweb:Container><osweb:Container runat="server" id="wtContentArea" onDataBinding="cntContentArea_onDataBinding" cssClass="ProgressReportAreaContent" style="margin-top: 0px"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If6() %>"><osweb:Container runat="server" id="wt_Container18" anonymous="true" onDataBinding="cnt_Container18_onDataBinding"><osweb:Container runat="server" id="wt_Container45" anonymous="true" onDataBinding="cnt_Container45_onDataBinding"><osweb:Table runat="server" id="wt_Table29" anonymous="true" GridCssClasses="OSFillParent"><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_TableCell12" anonymous="true" style="width: 15%"><osweb:PlaceHolder runat="server"><%# "Academic Year" %></osweb:PlaceHolder></osweb:Td><osweb:Td runat="server" id="wt_TableCell72" anonymous="true" style="width: 45%"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If23() %>"><osweb:DropDownList runat="server" id="wt_ComboBox2" onDataBinding="sel_ComboBox2_onDataBinding" onAjaxChange="sel_ComboBox2_AjaxChange" style="width: 300px" Visible="<%# sel_ComboBox2_isVisible() %>" Enabled="<%# sel_ComboBox2_isEnabled() %>" OnSelectedIndexChanged="sel_ComboBox2_dropDown_valueChanged" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" Mandatory="<%# sel_ComboBox2_isMandatory() %>"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wt_ComboBox2ValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wt_ComboBox2"/></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If23() %>"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression59()) %></osweb:PlaceHolder></osweb:If></osweb:IfPlaceHolder></osweb:Td><osweb:Td runat="server" id="wtCellExemp" onDataBinding="wtCellExemp_onDataBinding" class="ExemptionBlock"><osweb:Container runat="server" id="wtExemptionContainer" onDataBinding="cntExemptionContainer_onDataBinding"><osweb:Container runat="server" id="wt_Container61" anonymous="true" onDataBinding="cnt_Container61_onDataBinding" GridCssClasses="ThemeGrid_Width2"><osweb:CheckBox runat="server" id="wt_CheckBox58" Visible="<%# chk_CheckBox58_isVisible() %>" Enabled="<%# chk_CheckBox58_isEnabled() %>" Checked="<%# chk_CheckBox58_checked_value() %>" onCheckedChanged="chk_CheckBox58_checkbox_onCheckedChanged"/><osweb:PlaceHolder runat="server"><%# "Math Exemption" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container50" anonymous="true" onDataBinding="cnt_Container50_onDataBinding" GridCssClasses="ThemeGrid_Width1" style="margin-left: 0px" align="right"><RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA runat="server" id="RichWidgets_wt_WebBlockInstance28" onAjaxNotify="RichWidgets_webBlck_WebBlockInstance28_AjaxNotify" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance28_onDataBinding" InstanceID="_WebBlockInstance28"></RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA><osweb:HyperLink runat="server" id="wtEditExemptions" Visible="<%# lnkEditExemptions_isVisible() %>" Enabled="<%# lnkEditExemptions_isEnabled() %>" NavigateUrl="<%# lnkEditExemptions_NavigateUrl() %>"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance33" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance33_onDataBinding" InstanceID="_WebBlockInstance33"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w></osweb:HyperLink></osweb:Container><osweb:Container runat="server" id="wt_Container24" anonymous="true" onDataBinding="cnt_Container24_onDataBinding" GridCssClasses="ThemeGrid_Width2" style="margin-left: 0px"><osweb:CheckBox runat="server" id="wt_CheckBox75" Visible="<%# chk_CheckBox75_isVisible() %>" Enabled="<%# chk_CheckBox75_isEnabled() %>" Checked="<%# chk_CheckBox75_checked_value() %>" onCheckedChanged="chk_CheckBox75_checkbox_onCheckedChanged"/><osweb:PlaceHolder runat="server"><%# "English Exemption" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container41" anonymous="true" onDataBinding="cnt_Container41_onDataBinding" GridCssClasses="OSAutoMarginTop"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression4()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container44" anonymous="true" onDataBinding="cnt_Container44_onDataBinding" style="margin-top: 5px"><osweb:Span runat="server" id="wt_InlineExpression42" anonymous="true" class="Text_Note"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression42()) %></osweb:Span><osweb:Container runat="server" id="wt_Container62" anonymous="true" onDataBinding="cnt_Container62_onDataBinding" GridCssClasses="OSInline" style="width: 80px; margin-left: 0px"><widgets:K1tHu2scNhke0DPtNY_WdAQ runat="server" id="wt_WebBlockInstance55" OnEvaluateParameters="webBlck_WebBlockInstance55_onDataBinding" InstanceID="_WebBlockInstance55"></widgets:K1tHu2scNhke0DPtNY_WdAQ></osweb:Container></osweb:Container></osweb:Container></osweb:Td></osweb:Tr></osweb:Table></osweb:Container><osweb:Container runat="server" id="wtFullYearPlannedLearningHoursWrapper" onDataBinding="cntFullYearPlannedLearningHoursWrapper_onDataBinding"><osweb:Container runat="server" id="wt_Container36" anonymous="true" onDataBinding="cnt_Container36_onDataBinding"><osweb:Container runat="server" id="wtPlannedLearningHoursWrapper" onDataBinding="cntPlannedLearningHoursWrapper_onDataBinding" cssClass="PlannedLearningHoursWrapper" GridCssClasses="OSInline" style="width: 45%; margin-left: 0px"><osweb:Container runat="server" id="wtPlannedLearningHoursTitle" onDataBinding="cntPlannedLearningHoursTitle_onDataBinding"><osweb:PlaceHolder runat="server"><%# "Planned Learning Hours" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wtPlannedLearningHoursValue" onDataBinding="cntPlannedLearningHoursValue_onDataBinding" cssClass="PlannedLearningHoursValue"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression13()) %></osweb:PlaceHolder></osweb:Container></osweb:Container><osweb:Container runat="server" id="wtPlannedEEPLearningHoursWrapper" onDataBinding="cntPlannedEEPLearningHoursWrapper_onDataBinding" cssClass="PlannedLearningHoursWrapper" GridCssClasses="OSInline" style="width: 45%; margin-left: 0px"><osweb:Container runat="server" id="wt_Container68" anonymous="true" onDataBinding="cnt_Container68_onDataBinding"><osweb:Span runat="server" id="wtPlannedEEPLearningHoursTitle"><%# "Planned Employability, Enrichment and Pastoral Hours" %></osweb:Span></osweb:Container><osweb:Container runat="server" id="wtPlannedEEPLearningHoursValue" onDataBinding="cntPlannedEEPLearningHoursValue_onDataBinding" cssClass="PlannedLearningHoursValue"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression70()) %></osweb:PlaceHolder></osweb:Container></osweb:Container></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container52" anonymous="true" onDataBinding="cnt_Container52_onDataBinding" cssClass="note"><osweb:PlaceHolder runat="server"><%# "n.b. The above figures may include additional funded hours being claimed for non-timetabled tutorials and may not include non-funded enrolments. Therefore the totals shown may be different from the total of the individual enrolments below. " %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wtEnrolmentsContainer" onDataBinding="cntEnrolmentsContainer_onDataBinding"><osweb:Container runat="server" id="wtActiveEnrolments" onDataBinding="cntActiveEnrolments_onDataBinding"><widgets:KSPhbYciuLE_man2Op3nABA runat="server" id="wt_WebBlockInstance46" OnEvaluateParameters="webBlck_WebBlockInstance46_onDataBinding" InstanceID="_WebBlockInstance46"></widgets:KSPhbYciuLE_man2Op3nABA></osweb:Container><osweb:Container runat="server" id="wtCompletedEnrolments" onDataBinding="cntCompletedEnrolments_onDataBinding"><widgets:KSPhbYciuLE_man2Op3nABA runat="server" id="wt_WebBlockInstance69" OnEvaluateParameters="webBlck_WebBlockInstance69_onDataBinding" InstanceID="_WebBlockInstance69"></widgets:KSPhbYciuLE_man2Op3nABA></osweb:Container><osweb:Container runat="server" id="wtWithdrawnEnrolments" onDataBinding="cntWithdrawnEnrolments_onDataBinding"><widgets:KSPhbYciuLE_man2Op3nABA runat="server" id="wt_WebBlockInstance71" OnEvaluateParameters="webBlck_WebBlockInstance71_onDataBinding" InstanceID="_WebBlockInstance71"></widgets:KSPhbYciuLE_man2Op3nABA></osweb:Container><osweb:Container runat="server" id="wtTransferredEnrolments" onDataBinding="cntTransferredEnrolments_onDataBinding"><widgets:KSPhbYciuLE_man2Op3nABA runat="server" id="wt_WebBlockInstance8" OnEvaluateParameters="webBlck_WebBlockInstance8_onDataBinding" InstanceID="_WebBlockInstance8"></widgets:KSPhbYciuLE_man2Op3nABA></osweb:Container></osweb:Container></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If6() %>"></osweb:If></osweb:IfPlaceHolder></osweb:Container></osweb:Container><%# PageEndHook() %>