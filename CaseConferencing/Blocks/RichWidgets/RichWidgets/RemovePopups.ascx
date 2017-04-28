﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\RichWidgets\RichWidgets\RemovePopups.ascx.cs" Inherits="ssRichWidgets.Flows.FlowRichWidgets.WBlkRemovePopups,RichWidgets" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssRichWidgets" %>
<%# PageStartHook() %><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt3() %>"><osweb:DynamicImage runat="server" id="wt2" anonymous="true" StaticSource="<%# Images.Script_Source() %>" ImageType="Static" StaticPath="<%# AppUtils.Instance.getImagePath() %>" Height="<%# System.Web.UI.WebControls.Unit.Parse(img2_actualHeight(), System.Globalization.CultureInfo.InvariantCulture) %>" Width="<%# System.Web.UI.WebControls.Unit.Parse(img2_actualWidth(), System.Globalization.CultureInfo.InvariantCulture) %>" alt=""/><osweb:Span runat="server" id="wt4" anonymous="true" class="Text_Note"><%# "&lt;RemovePopups&gt;" %></osweb:Span></osweb:If><osweb:If runat="server" visible="<%# !if_wt3() %>"></osweb:If></osweb:IfPlaceHolder><%# PageEndHook() %>