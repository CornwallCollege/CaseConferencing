﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\ThemeProvider\Common\TileIcon.ascx.cs" Inherits="ssThemeProvider.Flows.FlowCommon.WBlkTileIcon,ThemeProvider" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssThemeProvider" %>
<%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="..\..\ThemeProvider\RichWidgets\Icon.ascx" %><%# PageStartHook() %><osweb:Container runat="server" id="wt6" anonymous="true" onDataBinding="cnt6_onDataBinding" cssClass="TileIcon Tile Silver"><osweb:Container runat="server" id="wt4" anonymous="true" onDataBinding="cnt4_onDataBinding" cssClass="TileIcon_icon"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt1" OnEvaluateParameters="RichWidgets_webBlck1_onDataBinding" InstanceID="1"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w></osweb:Container><osweb:Container runat="server" id="wt5" anonymous="true" onDataBinding="cnt5_onDataBinding" cssClass="TileIcon_text" style="margin-top: 0px"><osweb:PlaceholderContainer runat="server" id="wtText" onDataBinding="wtText_onDataBinding"></osweb:PlaceholderContainer></osweb:Container><osweb:Container runat="server" id="wt3" anonymous="true" onDataBinding="cnt3_onDataBinding" cssClass="TileIcon_note" GridCssClasses="OSAutoMarginTop"><osweb:PlaceholderContainer runat="server" id="wtNotes" onDataBinding="wtNotes_onDataBinding"></osweb:PlaceholderContainer></osweb:Container></osweb:Container><%# PageEndHook() %>