﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\CaseConferencing\Safeguarding\PersonsInvolved.ascx.cs" Inherits="ssCaseConferencing.Flows.FlowSafeguarding.WBlkPersonsInvolved,CaseConferencing" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssCaseConferencing" %>
<%# PageStartHook() %><osweb:Container runat="server" id="wt_Container1" anonymous="true" onDataBinding="cnt_Container1_onDataBinding"><osweb:Iterator runat="server" id="wtListRecords1" onDataBinding="recListListRecords1_onDataBinding" cssClass="ListRecords" OnItemCommand="recListListRecords1_Select" OnSetViewStateStorage="recListListRecords1_Store" OnClearViewStateStorage="recListListRecords1_Clear" OnListRefreshDataBind="recListListRecords1_ListRefreshDataBind" NeedsBreakAfter="true"><ItemTemplate><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression3()) %></osweb:PlaceHolder></ItemTemplate><InvisibleTemplate><%# recListListRecords1_Store(Container.DataItem, Container.ItemIndex) %></InvisibleTemplate></osweb:Iterator></osweb:Container><%# PageEndHook() %>