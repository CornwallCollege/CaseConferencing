﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\RichWidgets\RichWidgets\ResponsiveTableRecords.ascx.cs" Inherits="ssRichWidgets.Flows.FlowRichWidgets.WBlkResponsiveTableRecords,RichWidgets" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssRichWidgets" %>
<%# PageStartHook() %><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt2() %>"><osweb:Span runat="server" id="wt1" anonymous="true" class="Text_Note"><%# expression1() %></osweb:Span></osweb:If><osweb:If runat="server" visible="<%# !if_wt2() %>"></osweb:If></osweb:IfPlaceHolder><%# PageEndHook() %>