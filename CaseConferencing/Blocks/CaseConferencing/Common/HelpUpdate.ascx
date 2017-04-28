﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\CaseConferencing\Common\HelpUpdate.ascx.cs" Inherits="ssCaseConferencing.Flows.FlowCommon.WBlkHelpUpdate,CaseConferencing" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssCaseConferencing" %>
<%# PageStartHook() %><osweb:Container runat="server" id="wt_Container5" anonymous="true" onDataBinding="cnt_Container5_onDataBinding" GridCssClasses="OSInline"><osweb:LinkButton runat="server" id="wt_Link2" Visible="<%# lnk_Link2_isVisible() %>" Enabled="<%# lnk_Link2_isEnabled() %>" CausesValidation="false" title="<%# lnk_Link2_getTitle() %>" alt="<%# lnk_Link2_getTitle() %>"><osweb:PlaceHolder runat="server"><%# "Help / Updates " %></osweb:PlaceHolder><osweb:Container runat="server" id="wtUpdateIndicatorBackground" onDataBinding="cntUpdateIndicatorBackground_onDataBinding" cssClass="UpdateIndicatorBackground" GridCssClasses="OSInline"><osweb:Container runat="server" id="wt_Container4" anonymous="true" onDataBinding="cnt_Container4_onDataBinding" cssClass="UpdateIndicator" GridCssClasses="OSInline"><osweb:Span runat="server" id="wt_InlineExpression7" anonymous="true" class="UpdateIndicator"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression7()) %></osweb:Span></osweb:Container></osweb:Container></osweb:LinkButton></osweb:Container><osweb:Span runat="server" id="wt_Text3" anonymous="true" onDataBinding="wt_Text3_onDataBinding"><%# " | " %></osweb:Span><%# PageEndHook() %>