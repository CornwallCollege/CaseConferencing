<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\NumberSlider\Libs\TouchPunch.ascx.cs" Inherits="ssNumberSlider.Flows.FlowLibs.WBlkTouchPunch,NumberSlider" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssNumberSlider" %>
<%# PageStartHook() %><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt4() %>"><osweb:PlaceHolder runat="server"><%# "&lt;touchpunch.js&gt;" %></osweb:PlaceHolder></osweb:If><osweb:If runat="server" visible="<%# !if_wt4() %>"></osweb:If></osweb:IfPlaceHolder><%# PageEndHook() %>