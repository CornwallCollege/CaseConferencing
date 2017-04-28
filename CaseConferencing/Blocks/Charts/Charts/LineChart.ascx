<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\Charts\Charts\LineChart.ascx.cs" Inherits="ssCharts.Flows.FlowCharts.WBlkLineChart,Charts" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssCharts" %>
<%@ Register TagPrefix="widgets" TagName="K9V7TnEhFS0C52xflQYoa7A" Src="..\..\Charts\Internal\LineAreaChart_HighCharts.ascx" %><%# PageStartHook() %><widgets:K9V7TnEhFS0C52xflQYoa7A runat="server" id="wt1" OnEvaluateParameters="webBlck1_onDataBinding" InstanceID="1"></widgets:K9V7TnEhFS0C52xflQYoa7A><%# PageEndHook() %>