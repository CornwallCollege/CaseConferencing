<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\RichWidgets\LayoutsOther\Layout_Popup.ascx.cs" Inherits="ssRichWidgets.Flows.FlowLayoutsOther.WBlkLayout_Popup,RichWidgets" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssRichWidgets" %>
<%# PageStartHook() %><osweb:Container runat="server" id="wt2" anonymous="true" onDataBinding="cnt2_onDataBinding"><osweb:PlaceholderContainer runat="server" id="wtMainContent" onDataBinding="wtMainContent_onDataBinding" cssClass="MainPopup"></osweb:PlaceholderContainer></osweb:Container><%# PageEndHook() %>