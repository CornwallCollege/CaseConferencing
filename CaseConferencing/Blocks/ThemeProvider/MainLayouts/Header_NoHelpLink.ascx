﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\ThemeProvider\MainLayouts\Header_NoHelpLink.ascx.cs" Inherits="ssThemeProvider.Flows.FlowMainLayouts.WBlkHeader_NoHelpLink,ThemeProvider" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssThemeProvider" %>
<%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="..\..\ThemeProvider\RichWidgets\Icon.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="K1boRW1ocfWljMkwBCSeF_g" Src="..\..\ThemeProvider\RichWidgets\Feedback_AjaxWait.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="KfCEeDIqv_OomQwNMNcOMRg" Src="..\..\ThemeProvider\RichWidgets\Feedback_Message.ascx" %><%# PageStartHook() %><osweb:Container runat="server" id="wt16" anonymous="true" onDataBinding="cnt16_onDataBinding" cssClass="CaseConferencingHeader"><osweb:Container runat="server" id="wt6" anonymous="true" onDataBinding="cnt6_onDataBinding" cssClass="CenterColumn"><osweb:HyperLink runat="server" id="wt19" Visible="<%# lnk19_isVisible() %>" Enabled="<%# lnk19_isEnabled() %>" NavigateUrl="<%# lnk19_NavigateUrl() %>"><osweb:DynamicImage runat="server" id="wt12" anonymous="true" onDataBinding="img12_onDataBinding" StaticSource="<%# Images.cclogowhite_Source() %>" ImageType="Static" StaticPath="<%# AppUtils.Instance.getImagePath() %>" Height="<%# System.Web.UI.WebControls.Unit.Parse(img12_actualHeight(), System.Globalization.CultureInfo.InvariantCulture) %>" alt=""/></osweb:HyperLink><osweb:Container runat="server" id="wt13" anonymous="true" onDataBinding="cnt13_onDataBinding" cssClass="HeaderWrapper" GridCssClasses="OSInline"><osweb:Container runat="server" id="wt15" anonymous="true" onDataBinding="cnt15_onDataBinding" cssClass="LoginUser"><osweb:PlaceholderContainer runat="server" id="wtHelpUpdate" onDataBinding="wtHelpUpdate_onDataBinding" GridCssClasses="OSInline"></osweb:PlaceholderContainer><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt9" OnEvaluateParameters="RichWidgets_webBlck9_onDataBinding" InstanceID="9"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression1()) %></osweb:PlaceHolder><osweb:Span runat="server" id="wt11" anonymous="true" onDataBinding="wt11_onDataBinding"><%# " | " %></osweb:Span><osweb:LinkButton runat="server" id="wt14" cssClass="Login_Info_Logout" Visible="<%# lnk14_isVisible() %>" Enabled="<%# lnk14_isEnabled() %>" CausesValidation="false" title="<%# lnk14_getTitle() %>" alt="<%# lnk14_getTitle() %>"><osweb:PlaceHolder runat="server"><%# "Logout" %></osweb:PlaceHolder></osweb:LinkButton></osweb:Container><osweb:HyperLink runat="server" id="wt18" Visible="<%# lnk18_isVisible() %>" Enabled="<%# lnk18_isEnabled() %>" NavigateUrl="<%# lnk18_NavigateUrl() %>"><osweb:Container runat="server" id="wt10" anonymous="true" onDataBinding="cnt10_onDataBinding"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression5()) %></osweb:PlaceHolder></osweb:Container></osweb:HyperLink><osweb:PlaceholderContainer runat="server" id="wtHeaderActions" onDataBinding="wtHeaderActions_onDataBinding"></osweb:PlaceholderContainer></osweb:Container></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt7" anonymous="true" onDataBinding="cnt7_onDataBinding"><RichWidgets_widgets:K1boRW1ocfWljMkwBCSeF_g runat="server" id="RichWidgets_wt3" OnEvaluateParameters="RichWidgets_webBlck3_onDataBinding" InstanceID="3"></RichWidgets_widgets:K1boRW1ocfWljMkwBCSeF_g><RichWidgets_widgets:KfCEeDIqv_OomQwNMNcOMRg runat="server" id="RichWidgets_wt17" OnEvaluateParameters="RichWidgets_webBlck17_onDataBinding" InstanceID="17"></RichWidgets_widgets:KfCEeDIqv_OomQwNMNcOMRg></osweb:Container><%# PageEndHook() %>