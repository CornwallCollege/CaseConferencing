﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\Charts\Internal\BarColumnChart_HighCharts.ascx.cs" Inherits="ssCharts.Flows.FlowInternal.WBlkBarColumnChart_HighCharts,Charts" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssCharts" %>
<%@ Register TagPrefix="widgets" TagName="KUe7_Os_QREOy0ygxy7Xi2g" Src="..\..\Charts\ChartLibrariesJS\OSHighCharts.ascx" %><%@ Register TagPrefix="widgets" TagName="KCqVb9dq4yEOeUrd5XDV4qg" Src="..\..\Charts\Utils\JavaScript_Content.ascx" %><%# PageStartHook() %><widgets:KUe7_Os_QREOy0ygxy7Xi2g runat="server" id="wt2" OnEvaluateParameters="webBlck2_onDataBinding" InstanceID="2"></widgets:KUe7_Os_QREOy0ygxy7Xi2g><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt6() %>"></osweb:If><osweb:If runat="server" visible="<%# !if_wt6() %>"><osweb:Container runat="server" id="wtDivChart" onDataBinding="cntDivChart_onDataBinding" cssClass="OSChart"></osweb:Container><widgets:KCqVb9dq4yEOeUrd5XDV4qg runat="server" id="wtJavaScript_Content" OnEvaluateParameters="webBlckJavaScript_Content_onDataBinding" InstanceID="JavaScript_Content"></widgets:KCqVb9dq4yEOeUrd5XDV4qg></osweb:If></osweb:IfPlaceHolder><%# PageEndHook() %>