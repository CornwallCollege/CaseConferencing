﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\RichWidgets\Private\RichWidgetsjQueryUI.ascx.cs" Inherits="ssRichWidgets.Flows.FlowPrivate.WBlkRichWidgetsjQueryUI,RichWidgets" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssRichWidgets" %>
<%@ Register TagPrefix="widgets" TagName="KlXOc6d_deEeaBtvy9HfFhQ" Src="..\..\RichWidgets\jQueryUI\jQueryUILoader.ascx" %><%@ Register TagPrefix="widgets" TagName="K2SwbOIl4SUSVioPiJ0g1CA" Src="..\..\RichWidgets\jQueryUI\jQueryComponents.ascx" %><%# PageStartHook() %><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt8() %>"><osweb:DynamicImage runat="server" id="wt7" anonymous="true" StaticSource="<%# Images.Script_Source() %>" ImageType="Static" StaticPath="<%# AppUtils.Instance.getImagePath() %>" Height="<%# System.Web.UI.WebControls.Unit.Parse(img7_actualHeight(), System.Globalization.CultureInfo.InvariantCulture) %>" Width="<%# System.Web.UI.WebControls.Unit.Parse(img7_actualWidth(), System.Globalization.CultureInfo.InvariantCulture) %>" alt=""/><osweb:PlaceHolder runat="server"><%# " " %></osweb:PlaceHolder><osweb:Span runat="server" id="wt4" anonymous="true" class="Text_Note"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression4()) %></osweb:Span></osweb:If><osweb:If runat="server" visible="<%# !if_wt8() %>"><widgets:KlXOc6d_deEeaBtvy9HfFhQ runat="server" id="wt1" OnEvaluateParameters="webBlck1_onDataBinding" InstanceID="1"></widgets:KlXOc6d_deEeaBtvy9HfFhQ><widgets:K2SwbOIl4SUSVioPiJ0g1CA runat="server" id="wt6" OnEvaluateParameters="webBlck6_onDataBinding" InstanceID="6"></widgets:K2SwbOIl4SUSVioPiJ0g1CA></osweb:If></osweb:IfPlaceHolder><%# PageEndHook() %>