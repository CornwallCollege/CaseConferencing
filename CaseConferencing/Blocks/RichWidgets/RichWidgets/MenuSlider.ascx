﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\RichWidgets\RichWidgets\MenuSlider.ascx.cs" Inherits="ssRichWidgets.Flows.FlowRichWidgets.WBlkMenuSlider,RichWidgets" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssRichWidgets" %>
<%# PageStartHook() %><osweb:Container runat="server" id="wt2" anonymous="true" onDataBinding="cnt2_onDataBinding" cssClass="MenuSlider_Toggler"><osweb:Span runat="server" id="wt1" anonymous="true" class="fa fa-bars"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression1()) %></osweb:Span></osweb:Container><%# PageEndHook() %>