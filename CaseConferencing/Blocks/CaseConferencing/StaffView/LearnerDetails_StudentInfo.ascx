﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\CaseConferencing\StaffView\LearnerDetails_StudentInfo.ascx.cs" Inherits="ssCaseConferencing.Flows.FlowStaffView.WBlkLearnerDetails_StudentInfo,CaseConferencing" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssCaseConferencing" %>
<%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="..\..\CaseConferencing\RichWidgets\Icon.ascx" %><%@ Register TagPrefix="widgets" TagName="K1tHu2scNhke0DPtNY_WdAQ" Src="..\..\CaseConferencing\Common\DateFormatted.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="Kbbzz9S_an_V_uoCTOfsBiA" Src="..\..\CaseConferencing\RichWidgets\Popup_Editor.ascx" %><%@ Register TagPrefix="widgets" TagName="KuW_g2wad1EWjrzVLAiZW5A" Src="..\..\CaseConferencing\Common\PopUp_Tootip.ascx" %><%# PageStartHook() %><osweb:Container runat="server" id="wt_Container128" anonymous="true" onDataBinding="cnt_Container128_onDataBinding" cssClass="LearnerDetailsOverviewWrapper"><osweb:Container runat="server" id="wt_Container19" anonymous="true" onDataBinding="cnt_Container19_onDataBinding" cssClass="LearnerDetailsRAGGreen" GridCssClasses="OSInline"></osweb:Container><osweb:Container runat="server" id="wt_Container79" anonymous="true" onDataBinding="cnt_Container79_onDataBinding" cssClass="LearnerOverviewPhotoWrapper" GridCssClasses="OSInline"><osweb:DynamicImage runat="server" id="wt_Image89" anonymous="true" onDataBinding="img_Image89_onDataBinding" cssClass="LearnerPhotoDetails" Source="<%# img_Image89_getURL() %>" ImageType="External" alt=""/></osweb:Container><osweb:Container runat="server" id="wt_Container91" anonymous="true" onDataBinding="cnt_Container91_onDataBinding" cssClass="LearnerOverviewInfo" GridCssClasses="OSInline"><osweb:Container runat="server" id="wt_Container67" anonymous="true" onDataBinding="cnt_Container67_onDataBinding" cssClass="SNameDetails" GridCssClasses="OSInline"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression56()) %></osweb:PlaceHolder><osweb:Container runat="server" id="wt_Container83" anonymous="true" onDataBinding="cnt_Container83_onDataBinding"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If119() %>"><osweb:Container runat="server" id="wt_Container70" anonymous="true" onDataBinding="cnt_Container70_onDataBinding" onAjaxClick="cnt_Container70_AjaxClick"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance24" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance24_onDataBinding" InstanceID="_WebBlockInstance24"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If119() %>"></osweb:If></osweb:IfPlaceHolder><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If94() %>"><osweb:Container runat="server" id="wt_Container113" anonymous="true" onDataBinding="cnt_Container113_onDataBinding" onAjaxClick="cnt_Container113_AjaxClick"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance6" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance6_onDataBinding" InstanceID="_WebBlockInstance6"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If94() %>"></osweb:If></osweb:IfPlaceHolder><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If72() %>"><osweb:Container runat="server" id="wt_Container5" anonymous="true" onDataBinding="cnt_Container5_onDataBinding" onAjaxClick="cnt_Container5_AjaxClick"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance20" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance20_onDataBinding" InstanceID="_WebBlockInstance20"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If72() %>"></osweb:If></osweb:IfPlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container49" anonymous="true" onDataBinding="cnt_Container49_onDataBinding" GridCssClasses="OSInline"><osweb:PlaceHolder runat="server"><%# "[" %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression124()) %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# " - " %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression35()) %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# " years old, " %></osweb:PlaceHolder><widgets:K1tHu2scNhke0DPtNY_WdAQ runat="server" id="wt_WebBlockInstance22" OnEvaluateParameters="webBlck_WebBlockInstance22_onDataBinding" InstanceID="_WebBlockInstance22"></widgets:K1tHu2scNhke0DPtNY_WdAQ><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If3() %>"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression57()) %></osweb:PlaceHolder></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If3() %>"></osweb:If></osweb:IfPlaceHolder><osweb:PlaceHolder runat="server"><%# "]" %></osweb:PlaceHolder></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container96" anonymous="true" onDataBinding="cnt_Container96_onDataBinding" GridCssClasses="OSInline" align="right"><osweb:Container runat="server" id="wt_Container44" anonymous="true" onDataBinding="cnt_Container44_onDataBinding" cssClass="OSInline" GridCssClasses="OSInline" align="right"><osweb:Container runat="server" id="wt_Container100" anonymous="true" onDataBinding="cnt_Container100_onDataBinding"><osweb:HyperLink runat="server" id="wt_Link46" onDataBinding="lnk_Link46_onDataBinding" Visible="<%# lnk_Link46_isVisible() %>" Enabled="<%# lnk_Link46_isEnabled() %>" NavigateUrl="<%# lnk_Link46_NavigateUrl() %>"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance10" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance10_onDataBinding" InstanceID="_WebBlockInstance10"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# "View Learners Timetable" %></osweb:PlaceHolder></osweb:HyperLink></osweb:Container><osweb:Container runat="server" id="wt_Container61" anonymous="true" onDataBinding="cnt_Container61_onDataBinding" style="margin-top: 5px" align="left"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If73() %>"><osweb:HyperLink runat="server" id="wt_Link66" onDataBinding="lnk_Link66_onDataBinding" Visible="<%# lnk_Link66_isVisible() %>" Enabled="<%# lnk_Link66_isEnabled() %>" NavigateUrl="<%# lnk_Link66_NavigateUrl() %>"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance90" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance90_onDataBinding" InstanceID="_WebBlockInstance90"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# "View Learner Portal Page" %></osweb:PlaceHolder></osweb:HyperLink></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If73() %>"></osweb:If></osweb:IfPlaceHolder></osweb:Container></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container13" anonymous="true" onDataBinding="cnt_Container13_onDataBinding" cssClass="SCarearDetails"><osweb:Span runat="server" id="wt_InlineExpression122" anonymous="true" class=" "><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression122()) %></osweb:Span><osweb:Span runat="server" id="wt_InlineExpression111" anonymous="true" onDataBinding="expression_InlineExpression111_onDataBinding"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression111()) %></osweb:Span></osweb:Container><osweb:Container runat="server" id="wt_Container95" anonymous="true" onDataBinding="cnt_Container95_onDataBinding" cssClass="ContactSection" GridCssClasses="OSInline" style="width: 890px"><osweb:Container runat="server" id="wt_Container32" anonymous="true" onDataBinding="cnt_Container32_onDataBinding" cssClass="ContactBlock"><osweb:Span runat="server" id="wt_InlineExpression27" anonymous="true" onDataBinding="expression_InlineExpression27_onDataBinding" class="Heading3"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression27()) %></osweb:Span><osweb:PlaceHolder runat="server"><%# "<br/>" %></osweb:PlaceHolder><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance87" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance87_onDataBinding" InstanceID="_WebBlockInstance87"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:HyperLink runat="server" id="wtSmsLink" Visible="<%# lnkSmsLink_isVisible() %>" Enabled="<%# lnkSmsLink_isEnabled() %>" NavigateUrl="<%# lnkSmsLink_NavigateUrl() %>"><osweb:Span runat="server" id="wt_InlineExpression37" anonymous="true" onDataBinding="expression_InlineExpression37_onDataBinding"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression37()) %></osweb:Span></osweb:HyperLink><RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA runat="server" id="RichWidgets_wt_WebBlockInstance99" onAjaxNotify="RichWidgets_webBlck_WebBlockInstance99_AjaxNotify" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance99_onDataBinding" InstanceID="_WebBlockInstance99"></RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA><osweb:PlaceHolder runat="server"><%# "<br/>" %></osweb:PlaceHolder><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance62" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance62_onDataBinding" InstanceID="_WebBlockInstance62"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:HyperLink runat="server" id="wtLinkSMSMobile" Visible="<%# lnkLinkSMSMobile_isVisible() %>" Enabled="<%# lnkLinkSMSMobile_isEnabled() %>" NavigateUrl="<%# lnkLinkSMSMobile_NavigateUrl() %>"><osweb:Span runat="server" id="wt_InlineExpression36" anonymous="true" onDataBinding="expression_InlineExpression36_onDataBinding"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression36()) %></osweb:Span></osweb:HyperLink><RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA runat="server" id="RichWidgets_wt_WebBlockInstance55" onAjaxNotify="RichWidgets_webBlck_WebBlockInstance55_AjaxNotify" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance55_onDataBinding" InstanceID="_WebBlockInstance55"></RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA><osweb:PlaceHolder runat="server"><%# "<br/>" %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# " @ " %></osweb:PlaceHolder><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If114() %>"><osweb:HyperLink runat="server" id="wtLinkEmail" Visible="<%# lnkLinkEmail_isVisible() %>" Enabled="<%# lnkLinkEmail_isEnabled() %>" NavigateUrl="<%# lnkLinkEmail_NavigateUrl() %>"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression80()) %></osweb:PlaceHolder></osweb:HyperLink><RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA runat="server" id="RichWidgets_wt_WebBlockInstance121" onAjaxNotify="RichWidgets_webBlck_WebBlockInstance121_AjaxNotify" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance121_onDataBinding" InstanceID="_WebBlockInstance121"></RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If114() %>"><osweb:Span runat="server" id="wt_Text107" anonymous="true" onDataBinding="wt_Text107_onDataBinding"><%# "(no email)" %></osweb:Span></osweb:If></osweb:IfPlaceHolder><osweb:PlaceHolder runat="server"><%# " " %></osweb:PlaceHolder><osweb:Container runat="server" id="wt_Container131" anonymous="true" onDataBinding="cnt_Container131_onDataBinding"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance84" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance84_onDataBinding" InstanceID="_WebBlockInstance84"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If71() %>"><osweb:HyperLink runat="server" id="wt_Link102" Visible="<%# lnk_Link102_isVisible() %>" Enabled="<%# lnk_Link102_isEnabled() %>" NavigateUrl="<%# lnk_Link102_NavigateUrl() %>"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression108()) %></osweb:PlaceHolder></osweb:HyperLink></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If71() %>"><osweb:Span runat="server" id="wt_Text134" anonymous="true" onDataBinding="wt_Text134_onDataBinding"><%# "Personal Tutor not found" %></osweb:Span></osweb:If></osweb:IfPlaceHolder></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container52" anonymous="true" onDataBinding="cnt_Container52_onDataBinding" GridCssClasses="OSInline"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If105() %>"><osweb:Container runat="server" id="wt_Container123" anonymous="true" onDataBinding="cnt_Container123_onDataBinding" cssClass="ContactBlock"><osweb:Span runat="server" id="wt_InlineExpression39" anonymous="true" onDataBinding="expression_InlineExpression39_onDataBinding" class="Heading3"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression39()) %></osweb:Span><osweb:PlaceHolder runat="server"><%# "<br/>" %></osweb:PlaceHolder><osweb:Container runat="server" id="wt_Container8" anonymous="true" onDataBinding="cnt_Container8_onDataBinding"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance17" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance17_onDataBinding" InstanceID="_WebBlockInstance17"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression59()) %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# ", " %></osweb:PlaceHolder><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression125()) %></osweb:PlaceHolder></osweb:Container><osweb:PlaceHolder runat="server"><%# "<br/>" %></osweb:PlaceHolder><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance93" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance93_onDataBinding" InstanceID="_WebBlockInstance93"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If50() %>"><osweb:HyperLink runat="server" id="wtSMSother" Visible="<%# lnkSMSother_isVisible() %>" Enabled="<%# lnkSMSother_isEnabled() %>" NavigateUrl="<%# lnkSMSother_NavigateUrl() %>"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression112()) %></osweb:PlaceHolder></osweb:HyperLink></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If50() %>"><osweb:PlaceHolder runat="server"><%# "(no telephone)" %></osweb:PlaceHolder></osweb:If></osweb:IfPlaceHolder><RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA runat="server" id="RichWidgets_wt_WebBlockInstance75" onAjaxNotify="RichWidgets_webBlck_WebBlockInstance75_AjaxNotify" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance75_onDataBinding" InstanceID="_WebBlockInstance75"></RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA><osweb:PlaceHolder runat="server"><%# "<br/>" %></osweb:PlaceHolder><osweb:Container runat="server" id="wt_Container101" anonymous="true" onDataBinding="cnt_Container101_onDataBinding" GridCssClasses="OSInline"><osweb:PlaceHolder runat="server"><%# "@" %></osweb:PlaceHolder></osweb:Container><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If4() %>"><osweb:HyperLink runat="server" id="wtEmailNOK" Visible="<%# lnkEmailNOK_isVisible() %>" Enabled="<%# lnkEmailNOK_isEnabled() %>" NavigateUrl="<%# lnkEmailNOK_NavigateUrl() %>"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression43()) %></osweb:PlaceHolder></osweb:HyperLink></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If4() %>"><osweb:Span runat="server" id="wt_Text98" anonymous="true" onDataBinding="wt_Text98_onDataBinding"><%# "(no NOK email)" %></osweb:Span></osweb:If></osweb:IfPlaceHolder><RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA runat="server" id="RichWidgets_wt_WebBlockInstance64" onAjaxNotify="RichWidgets_webBlck_WebBlockInstance64_AjaxNotify" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance64_onDataBinding" InstanceID="_WebBlockInstance64"></RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If105() %>"></osweb:If></osweb:IfPlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container103" anonymous="true" onDataBinding="cnt_Container103_onDataBinding" cssClass="ContactBlock" GridCssClasses="OSInline"><osweb:Container runat="server" id="wt_Container132" anonymous="true" onDataBinding="cnt_Container132_onDataBinding" cssClass="ContactTitle" align="left"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression81()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container30" anonymous="true" onDataBinding="cnt_Container30_onDataBinding" GridCssClasses="OSInline" align="left"><osweb:Iterator runat="server" id="wtListRecords1" onDataBinding="recListListRecords1_onDataBinding" cssClass="ListRecords" OnItemCommand="recListListRecords1_Select" OnSetViewStateStorage="recListListRecords1_Store" OnClearViewStateStorage="recListListRecords1_Clear" OnListRefreshDataBind="recListListRecords1_ListRefreshDataBind"><ItemTemplate><osweb:Container runat="server" id="wt_Container86" anonymous="true" onDataBinding="cnt_Container86_onDataBinding" GridCssClasses="OSInline"><osweb:Container runat="server" id="wt_Container18" anonymous="true" onDataBinding="cnt_Container18_onDataBinding" cssClass="IndicatorSupport" GridCssClasses="OSInline" align="center"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression117()) %></osweb:PlaceHolder></osweb:Container></osweb:Container></ItemTemplate><InvisibleTemplate><%# recListListRecords1_Store(Container.DataItem, Container.ItemIndex) %></InvisibleTemplate></osweb:Iterator></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container129" anonymous="true" onDataBinding="cnt_Container129_onDataBinding" cssClass="OSInline" align="right"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If116() %>"><osweb:Container runat="server" id="wt_Container47" anonymous="true" onDataBinding="cnt_Container47_onDataBinding"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression85()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container68" anonymous="true" onDataBinding="cnt_Container68_onDataBinding"><osweb:PlaceHolder runat="server"><%# expression_InlineExpression7() %></osweb:PlaceHolder></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If116() %>"></osweb:If></osweb:IfPlaceHolder></osweb:Container></osweb:Container></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container28" anonymous="true" onDataBinding="cnt_Container28_onDataBinding"><osweb:TextBox runat="server" id="wtileft" Visible="<%# inputwtileft_isVisible() %>" ReadOnly="<%# !inputwtileft_isEnabled() %>" maxlength="50" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" OnDefaultTypeValidationMessage="GetDecimalValidatorMsg" textmode="SingleLine" text="<%# inputwtileft_input_value() %>" onTextChanged="inputwtileft_input_onTextChanged" Mandatory="<%# inputwtileft_isMandatory() %>"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wtileftValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wtileft"/><osweb:TextValidator runat="server" display="Dynamic" id="wtileftValidatorType" ErrorMessage="<%# CaseConferencing_Properties.DecimalValidatorMsg %>" ControlToValidate="wtileft" ClientValidationFunction="OsCustomValidatorDecimal"/><osweb:TextBox runat="server" id="wtitop" Visible="<%# inputwtitop_isVisible() %>" ReadOnly="<%# !inputwtitop_isEnabled() %>" maxlength="50" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" OnDefaultTypeValidationMessage="GetDecimalValidatorMsg" textmode="SingleLine" text="<%# inputwtitop_input_value() %>" onTextChanged="inputwtitop_input_onTextChanged" Mandatory="<%# inputwtitop_isMandatory() %>"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wtitopValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wtitop"/><osweb:TextValidator runat="server" display="Dynamic" id="wtitopValidatorType" ErrorMessage="<%# CaseConferencing_Properties.DecimalValidatorMsg %>" ControlToValidate="wtitop" ClientValidationFunction="OsCustomValidatorDecimal"/></osweb:Container><osweb:Container runat="server" id="wt_Container115" anonymous="true" onDataBinding="cnt_Container115_onDataBinding" cssClass="Tooltip"><widgets:KuW_g2wad1EWjrzVLAiZW5A runat="server" id="wtPopUp_Tootip" OnEvaluateParameters="webBlckPopUp_Tootip_onDataBinding" InstanceID="PopUp_Tootip" IncludeSpan="true"></widgets:KuW_g2wad1EWjrzVLAiZW5A></osweb:Container><%# PageEndHook() %>