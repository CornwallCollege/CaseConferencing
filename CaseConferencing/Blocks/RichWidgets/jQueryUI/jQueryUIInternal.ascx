﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\RichWidgets\jQueryUI\jQueryUIInternal.ascx.cs" Inherits="ssRichWidgets.Flows.FlowjQueryUI.WBlkjQueryUIInternal,RichWidgets" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssRichWidgets" %>
<%# PageStartHook() %><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt2() %>"><osweb:DynamicImage runat="server" id="wt6" anonymous="true" StaticSource="<%# Images.Script_Source() %>" ImageType="Static" StaticPath="<%# AppUtils.Instance.getImagePath() %>" Height="<%# System.Web.UI.WebControls.Unit.Parse(img6_actualHeight(), System.Globalization.CultureInfo.InvariantCulture) %>" Width="<%# System.Web.UI.WebControls.Unit.Parse(img6_actualWidth(), System.Globalization.CultureInfo.InvariantCulture) %>" alt=""/><osweb:PlaceHolder runat="server"><%# " " %></osweb:PlaceHolder><osweb:Span runat="server" id="wt4" anonymous="true" class="Text_Note"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression4()) %></osweb:Span></osweb:If><osweb:If runat="server" visible="<%# !if_wt2() %>"></osweb:If></osweb:IfPlaceHolder><%# PageEndHook() %>