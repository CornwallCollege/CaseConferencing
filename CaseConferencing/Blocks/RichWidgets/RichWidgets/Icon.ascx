<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\RichWidgets\RichWidgets\Icon.ascx.cs" Inherits="ssRichWidgets.Flows.FlowRichWidgets.WBlkIcon,RichWidgets" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssRichWidgets" %>
<%# PageStartHook() %><osweb:Span runat="server" id="wt1" anonymous="true" onDataBinding="expression1_onDataBinding"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression1()) %></osweb:Span><%# PageEndHook() %>