﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\CaseConferencing\StaffView\StaffView_Sort.ascx.cs" Inherits="ssCaseConferencing.Flows.FlowStaffView.WBlkStaffView_Sort,CaseConferencing" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssCaseConferencing" %>
<%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="..\..\CaseConferencing\RichWidgets\Icon.ascx" %><%# PageStartHook() %><osweb:Container runat="server" id="wt_Container3" anonymous="true" onDataBinding="cnt_Container3_onDataBinding" GridCssClasses="OSInline"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If9() %>"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If7() %>"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance6" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance6_onDataBinding" InstanceID="_WebBlockInstance6"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If7() %>"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance1" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance1_onDataBinding" InstanceID="_WebBlockInstance1"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w></osweb:If></osweb:IfPlaceHolder></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If9() %>"></osweb:If></osweb:IfPlaceHolder></osweb:Container><%# PageEndHook() %>