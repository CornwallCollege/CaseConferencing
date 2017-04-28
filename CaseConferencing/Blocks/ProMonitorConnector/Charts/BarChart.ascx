<%@ Control Language="c#" AutoEventWireup="false" Inherits="proxy_ProMonitorConnector_Charts.Flows.FlowCharts.WBlkBarChart,ProMonitorConnectorReferencesProxy" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="client" TagName="node" Src="..\..\Charts\Charts\BarChart.ascx" %>
<client:node id="block" runat="server" OnBindDelegates="BindProxyDelegates" />