﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\CaseConferencing\Common\jQuerySelectric.ascx.cs" Inherits="ssCaseConferencing.Flows.FlowCommon.WBlkjQuerySelectric,CaseConferencing" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssCaseConferencing" %>
<%# PageStartHook() %><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If3() %>"><osweb:PlaceHolder runat="server"><%# "jQuerySelectric" %></osweb:PlaceHolder></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If3() %>"><osweb:PlaceHolder runat="server"><%# expression_InlineExpression5() %></osweb:PlaceHolder></osweb:If></osweb:IfPlaceHolder><%# PageEndHook() %>