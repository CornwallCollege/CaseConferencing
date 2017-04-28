﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\CaseConferencing\Safeguarding\Safeguarding_Tab.ascx.cs" Inherits="ssCaseConferencing.Flows.FlowSafeguarding.WBlkSafeguarding_Tab,CaseConferencing" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssCaseConferencing" %>
<%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="..\..\CaseConferencing\RichWidgets\Icon.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="Kbbzz9S_an_V_uoCTOfsBiA" Src="..\..\CaseConferencing\RichWidgets\Popup_Editor.ascx" %><%@ Register TagPrefix="widgets" TagName="KU8nvOKAtsEGvw0HORLFK8g" Src="SafeguardingIssue.ascx" %><%# PageStartHook() %><osweb:Container runat="server" id="wt_Container8" anonymous="true" onDataBinding="cnt_Container8_onDataBinding"><osweb:Container runat="server" id="wtSafeguardingReportMenu" onDataBinding="cntSafeguardingReportMenu_onDataBinding" cssClass="SafeguardingReportMenu" GridCssClasses="OSInline"><osweb:Container runat="server" id="wt_Container30" anonymous="true" onDataBinding="cnt_Container30_onDataBinding" style="margin-top: 0px"><osweb:Container runat="server" id="wt_Container10" anonymous="true" onDataBinding="cnt_Container10_onDataBinding" cssClass="SafeguardingReportMenuItem"><osweb:Container runat="server" id="wt_Container32" anonymous="true" onDataBinding="cnt_Container32_onDataBinding" align="right"><osweb:Container runat="server" id="wt_Container11" anonymous="true" onDataBinding="cnt_Container11_onDataBinding" align="left"><osweb:Container runat="server" id="wt_Container4" anonymous="true" onDataBinding="cnt_Container4_onDataBinding" GridCssClasses="OSInline" style="width: 100px"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression28()) %></osweb:PlaceHolder></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container23" anonymous="true" onDataBinding="cnt_Container23_onDataBinding" style="margin-top: 10px"><osweb:LinkButton runat="server" id="wtCreateLink" onDataBinding="lnkCreateLink_onDataBinding" Visible="<%# lnkCreateLink_isVisible() %>" Enabled="<%# lnkCreateLink_isEnabled() %>" CausesValidation="false"><osweb:Container runat="server" id="wt_Container27" anonymous="true" onDataBinding="cnt_Container27_onDataBinding" cssClass="HeaderButton" GridCssClasses="OSInline" style="margin-left: 10px" align="center"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance37" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance37_onDataBinding" InstanceID="_WebBlockInstance37"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# " New " %></osweb:PlaceHolder></osweb:Container></osweb:LinkButton></osweb:Container></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container36" anonymous="true" onDataBinding="cnt_Container36_onDataBinding" GridCssClasses="OSAutoMarginTop"><osweb:Iterator runat="server" id="wtListMenu" onDataBinding="recListListMenu_onDataBinding" cssClass="ListRecords" OnItemCommand="recListListMenu_Select" OnSetViewStateStorage="recListListMenu_Store" OnClearViewStateStorage="recListListMenu_Clear" OnListRefreshDataBind="recListListMenu_ListRefreshDataBind" IsAjaxRefreshed="true" NeedsBreakAfter="true"><ItemTemplate><osweb:Container runat="server" id="wt_Container22" anonymous="true" onDataBinding="cnt_Container22_onDataBinding" onAjaxClick="cnt_Container22_AjaxClick" cssClass="SafeguardingReportMenuItem"><osweb:Container runat="server" id="wt_Container31" anonymous="true" onDataBinding="cnt_Container31_onDataBinding"><osweb:Container runat="server" id="wt_Container7" anonymous="true" onDataBinding="cnt_Container7_onDataBinding" GridCssClasses="OSInline" style="width: 160px"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance21" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance21_onDataBinding" InstanceID="_WebBlockInstance21"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression2()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container35" anonymous="true" onDataBinding="cnt_Container35_onDataBinding" GridCssClasses="OSInline" style="width: 16px; margin-left: 0px"><osweb:HyperLink runat="server" id="wtDeleteSafeguardingIssue" Visible="<%# lnkDeleteSafeguardingIssue_isVisible() %>" Enabled="<%# lnkDeleteSafeguardingIssue_isEnabled() %>" NavigateUrl="<%# lnkDeleteSafeguardingIssue_NavigateUrl() %>"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance19" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance19_onDataBinding" InstanceID="_WebBlockInstance19"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w></osweb:HyperLink></osweb:Container><RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA runat="server" id="RichWidgets_wt_WebBlockInstance6" onAjaxNotify="RichWidgets_webBlck_WebBlockInstance6_AjaxNotify" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance6_onDataBinding" InstanceID="_WebBlockInstance6"></RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA></osweb:Container><osweb:Container runat="server" id="wt_Container34" anonymous="true" onDataBinding="cnt_Container34_onDataBinding" style="margin-top: 0px"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression5()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container12" anonymous="true" onDataBinding="cnt_Container12_onDataBinding" cssClass="Text_Note" style="margin-top: 0px"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression13()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container20" anonymous="true" onDataBinding="cnt_Container20_onDataBinding" style="margin-top: 0px" align="left"><osweb:LinkButton runat="server" id="wt_Link24" onDataBinding="lnk_Link24_onDataBinding" Visible="<%# lnk_Link24_isVisible() %>" Enabled="<%# lnk_Link24_isEnabled() %>" CausesValidation="false"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance14" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance14_onDataBinding" InstanceID="_WebBlockInstance14"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:Span runat="server" id="wt_Text18" anonymous="true" class="Text_Note"><%# "Print" %></osweb:Span></osweb:LinkButton></osweb:Container></osweb:Container></ItemTemplate><InvisibleTemplate><%# recListListMenu_Store(Container.DataItem, Container.ItemIndex) %></InvisibleTemplate></osweb:Iterator></osweb:Container></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container17" anonymous="true" onDataBinding="cnt_Container17_onDataBinding" cssClass="SafeguardingReportAreaContent" style="margin-top: 0px"><osweb:Container runat="server" id="wt_Container26" anonymous="true" onDataBinding="cnt_Container26_onDataBinding"><widgets:KU8nvOKAtsEGvw0HORLFK8g runat="server" id="wtSafeguardingIssue_Item" onAjaxNotify="webBlckSafeguardingIssue_Item_AjaxNotify" OnEvaluateParameters="webBlckSafeguardingIssue_Item_onDataBinding" InstanceID="SafeguardingIssue_Item" IncludeSpan="true"></widgets:KU8nvOKAtsEGvw0HORLFK8g></osweb:Container></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container29" anonymous="true" onDataBinding="cnt_Container29_onDataBinding" GridCssClasses="OSAutoMarginTop"><osweb:Button runat="server" id="wtHiddenPrintButton" onDataBinding="btnHiddenPrintButton_onDataBinding" cssClass="Button" Visible="<%# btnHiddenPrintButton_isVisible() %>" Enabled="<%# btnHiddenPrintButton_isEnabled() %>" CausesValidation="false" text="<%# btnHiddenPrintButton_getLabel() %>"/></osweb:Container><%# PageEndHook() %>