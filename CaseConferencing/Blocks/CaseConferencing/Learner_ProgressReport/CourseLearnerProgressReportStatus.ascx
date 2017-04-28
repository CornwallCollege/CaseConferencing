﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\CaseConferencing\Learner_ProgressReport\CourseLearnerProgressReportStatus.ascx.cs" Inherits="ssCaseConferencing.Flows.FlowLearner_ProgressReport.WBlkCourseLearnerProgressReportStatus,CaseConferencing" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssCaseConferencing" %>
<%@ Register TagPrefix="widgets" TagName="KzPwyJqX4kk6_Ortbq1_fXw" Src="..\..\CaseConferencing\CaseConference\ProgressBar.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="Kbbzz9S_an_V_uoCTOfsBiA" Src="..\..\CaseConferencing\RichWidgets\Popup_Editor.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="..\..\CaseConferencing\RichWidgets\Icon.ascx" %><%# PageStartHook() %><osweb:Container runat="server" id="wt_Container11" anonymous="true" onDataBinding="cnt_Container11_onDataBinding" cssClass="LearnerListLine"><osweb:Container runat="server" id="wt_Container55" anonymous="true" onDataBinding="cnt_Container55_onDataBinding" GridCssClasses="OSInline" style="width: 200px"><osweb:Container runat="server" id="wt_Container43" anonymous="true" onDataBinding="cnt_Container43_onDataBinding" GridCssClasses="OSInline" style="width: 75px" align="center"><osweb:DynamicImage runat="server" id="wt_Image9" anonymous="true" onDataBinding="img_Image9_onDataBinding" cssClass="StudentPhoto SilverBorder" Source="<%# img_Image9_getURL() %>" ImageType="External" alt=""/></osweb:Container><osweb:Container runat="server" id="wt_Container45" anonymous="true" onDataBinding="cnt_Container45_onDataBinding" GridCssClasses="OSInline" style="width: 100px; margin-left: 0px" align="left"><osweb:Container runat="server" id="wt_Container29" anonymous="true" onDataBinding="cnt_Container29_onDataBinding"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression53()) %></osweb:PlaceHolder></osweb:Container></osweb:Container></osweb:Container><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If51() %>"><osweb:Container runat="server" id="wt_Container39" anonymous="true" onDataBinding="cnt_Container39_onDataBinding" GridCssClasses="OSInline" style="width: 300px"><osweb:Container runat="server" id="wt_Container49" anonymous="true" onDataBinding="cnt_Container49_onDataBinding" GridCssClasses="OSInline" style="width: 300px; margin-top: 10px"><widgets:KzPwyJqX4kk6_Ortbq1_fXw runat="server" id="wt_WebBlockInstance58" onAjaxNotify="webBlck_WebBlockInstance58_AjaxNotify" OnEvaluateParameters="webBlck_WebBlockInstance58_onDataBinding" InstanceID="_WebBlockInstance58"></widgets:KzPwyJqX4kk6_Ortbq1_fXw></osweb:Container><osweb:Container runat="server" id="wt_Container47" anonymous="true" onDataBinding="cnt_Container47_onDataBinding" GridCssClasses="OSInline" style="width: 300px; margin-left: 0px"><osweb:Span runat="server" id="wt_InlineExpression15" anonymous="true" class="Text_Note"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression15()) %></osweb:Span></osweb:Container></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If51() %>"><osweb:Container runat="server" id="wt_Container19" anonymous="true" onDataBinding="cnt_Container19_onDataBinding" GridCssClasses="OSInline" style="width: 300px" align="center"><RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA runat="server" id="RichWidgets_wt_WebBlockInstance20" onAjaxNotify="RichWidgets_webBlck_WebBlockInstance20_AjaxNotify" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance20_onDataBinding" InstanceID="_WebBlockInstance20"></RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA><osweb:HyperLink runat="server" id="wtCreateNewProgressReport" Visible="<%# lnkCreateNewProgressReport_isVisible() %>" Enabled="<%# lnkCreateNewProgressReport_isEnabled() %>" NavigateUrl="<%# lnkCreateNewProgressReport_NavigateUrl() %>"><osweb:Container runat="server" id="wt_Container26" anonymous="true" onDataBinding="cnt_Container26_onDataBinding" cssClass="HeaderButton" GridCssClasses="OSInline" style="width: 250px; margin-top: 10px"><osweb:PlaceHolder runat="server"><%# "Create Progress Report" %></osweb:PlaceHolder></osweb:Container></osweb:HyperLink></osweb:Container></osweb:If></osweb:IfPlaceHolder><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If1() %>"><osweb:Container runat="server" id="wt_Container46" anonymous="true" onDataBinding="cnt_Container46_onDataBinding" GridCssClasses="OSInline" style="width: 165px; margin-top: 10px" align="center"><osweb:HyperLink runat="server" id="wtPreviewReport" Visible="<%# lnkPreviewReport_isVisible() %>" Enabled="<%# lnkPreviewReport_isEnabled() %>" NavigateUrl="<%# lnkPreviewReport_NavigateUrl() %>"><osweb:Container runat="server" id="wt_Container18" anonymous="true" onDataBinding="cnt_Container18_onDataBinding" cssClass="HeaderButton" GridCssClasses="OSInline" style="width: 100px" align="center"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance7" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance7_onDataBinding" InstanceID="_WebBlockInstance7"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# "Preview Report" %></osweb:PlaceHolder></osweb:Container></osweb:HyperLink><RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA runat="server" id="RichWidgets_wt_WebBlockInstance33" onAjaxNotify="RichWidgets_webBlck_WebBlockInstance33_AjaxNotify" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance33_onDataBinding" InstanceID="_WebBlockInstance33"></RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If1() %>"><osweb:Container runat="server" id="wt_Container44" anonymous="true" onDataBinding="cnt_Container44_onDataBinding" GridCssClasses="OSInline" style="width: 165px"></osweb:Container></osweb:If></osweb:IfPlaceHolder><osweb:Button runat="server" id="wtHiddenCreateButton" onDataBinding="btnHiddenCreateButton_onDataBinding" cssClass="Button Is_Default" GridCssClasses="ThemeGrid_MarginGutter" Visible="<%# btnHiddenCreateButton_isVisible() %>" Enabled="<%# btnHiddenCreateButton_isEnabled() %>" CausesValidation="false" text="<%# btnHiddenCreateButton_getLabel() %>"/><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If56() %>"><osweb:Container runat="server" id="wt_Container38" anonymous="true" onDataBinding="cnt_Container38_onDataBinding" GridCssClasses="OSInline" style="width: 165px; margin-top: 10px" align="center"><osweb:HyperLink runat="server" id="wt_Link24" Visible="<%# lnk_Link24_isVisible() %>" Enabled="<%# lnk_Link24_isEnabled() %>" NavigateUrl="<%# lnk_Link24_NavigateUrl() %>"><osweb:Container runat="server" id="wt_Container17" anonymous="true" onDataBinding="cnt_Container17_onDataBinding" cssClass="HeaderButton" GridCssClasses="OSInline" style="width: 100px" align="center"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance37" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance37_onDataBinding" InstanceID="_WebBlockInstance37"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# "Edit Report" %></osweb:PlaceHolder></osweb:Container></osweb:HyperLink></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If56() %>"><osweb:Container runat="server" id="wt_Container34" anonymous="true" onDataBinding="cnt_Container34_onDataBinding" GridCssClasses="OSInline" style="width: 165px"></osweb:Container></osweb:If></osweb:IfPlaceHolder><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If31() %>"><osweb:Container runat="server" id="wt_Container50" anonymous="true" onDataBinding="cnt_Container50_onDataBinding" GridCssClasses="OSInline" style="width: 165px; margin-top: 10px" align="center"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If21() %>"><osweb:PlaceHolder runat="server"><%# "Report Signed Off" %></osweb:PlaceHolder></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If21() %>"><osweb:Container runat="server" id="wt_Container42" anonymous="true" onDataBinding="cnt_Container42_onDataBinding"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If3() %>"><osweb:LinkButton runat="server" id="wt_Link57" Visible="<%# lnk_Link57_isVisible() %>" Enabled="<%# lnk_Link57_isEnabled() %>" CausesValidation="false"><osweb:Container runat="server" id="wt_Container25" anonymous="true" onDataBinding="cnt_Container25_onDataBinding" cssClass="HeaderButton" GridCssClasses="OSInline" style="width: 100px" align="center"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance28" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance28_onDataBinding" InstanceID="_WebBlockInstance28"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# "Sign-Off" %></osweb:PlaceHolder></osweb:Container></osweb:LinkButton></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If3() %>"><osweb:Container runat="server" id="wt_Container54" anonymous="true" onDataBinding="cnt_Container54_onDataBinding" cssClass="HeaderButtonDisabled" GridCssClasses="OSInline" style="width: 100px"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance59" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance59_onDataBinding" InstanceID="_WebBlockInstance59"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# "Sign-Off" %></osweb:PlaceHolder></osweb:Container></osweb:If></osweb:IfPlaceHolder></osweb:Container></osweb:If></osweb:IfPlaceHolder></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If31() %>"><osweb:Container runat="server" id="wt_Container36" anonymous="true" onDataBinding="cnt_Container36_onDataBinding" GridCssClasses="OSInline" style="width: 165px"></osweb:Container></osweb:If></osweb:IfPlaceHolder></osweb:Container><%# PageEndHook() %>