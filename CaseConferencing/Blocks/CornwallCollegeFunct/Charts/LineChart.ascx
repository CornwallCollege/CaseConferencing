<%@ Control Language="c#" AutoEventWireup="false" Inherits="proxy_CornwallCollegeFunct_Charts.Flows.FlowCharts.WBlkLineChart,CornwallCollegeFunctReferencesProxy" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="client" TagName="node" Src="..\..\Charts\Charts\LineChart.ascx" %>
<client:node id="block" runat="server" OnBindDelegates="BindProxyDelegates" />