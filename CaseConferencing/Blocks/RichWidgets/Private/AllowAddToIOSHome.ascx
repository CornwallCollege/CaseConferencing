﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\RichWidgets\Private\AllowAddToIOSHome.ascx.cs" Inherits="ssRichWidgets.Flows.FlowPrivate.WBlkAllowAddToIOSHome,RichWidgets" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssRichWidgets" %>
<%# PageStartHook() %><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt4() %>"><osweb:Span runat="server" id="wt1" anonymous="true" class="Text_Note"><%# "&lt;AllowAddingToIPhoneHome&gt;" %></osweb:Span></osweb:If><osweb:If runat="server" visible="<%# !if_wt4() %>"></osweb:If></osweb:IfPlaceHolder><%# PageEndHook() %>