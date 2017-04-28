﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\CaseConferencing\Learner_ILP\MarkbookTrackingAssessments.ascx.cs" Inherits="ssCaseConferencing.Flows.FlowLearner_ILP.WBlkMarkbookTrackingAssessments,CaseConferencing" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssCaseConferencing" %>
<%@ Register TagPrefix="widgets" TagName="K9I1AM_sXKUGOueuMRKEyiQ" Src="TileIconText.ascx" %><%@ Register TagPrefix="widgets" TagName="KlQiCMkhBl0eXcUBYrz68yg" Src="MarkbookTrackingTasks.ascx" %><%# PageStartHook() %><osweb:Iterator runat="server" id="wtAssessmentsList" onDataBinding="recListAssessmentsList_onDataBinding" cssClass="ListRecords" OnItemCommand="recListAssessmentsList_Select" OnSetViewStateStorage="recListAssessmentsList_Store" OnClearViewStateStorage="recListAssessmentsList_Clear" OnListRefreshDataBind="recListAssessmentsList_ListRefreshDataBind"><ItemTemplate><osweb:Container runat="server" id="wtOverallContainer" onDataBinding="cntOverallContainer_onDataBinding"><osweb:Container runat="server" id="wt_Container2" anonymous="true" onDataBinding="cnt_Container2_onDataBinding"><osweb:Container runat="server" id="wt_Container9" anonymous="true" onDataBinding="cnt_Container9_onDataBinding"><widgets:K9I1AM_sXKUGOueuMRKEyiQ runat="server" id="wt_WebBlockInstance18" OnEvaluateParameters="webBlck_WebBlockInstance18_onDataBinding" InstanceID="_WebBlockInstance18"><phLabel><osweb:Container runat="server" id="wt_Container15" anonymous="true" onDataBinding="cnt_Container15_onDataBinding" align="left"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression1()) %></osweb:PlaceHolder></osweb:Container></phLabel><phText><osweb:Container runat="server" id="wt_Container10" anonymous="true" onDataBinding="cnt_Container10_onDataBinding" cssClass="Text_Note" align="left"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression12()) %></osweb:PlaceHolder></osweb:Container></phText><phPlaceholder1><osweb:Container runat="server" id="wt_Container16" anonymous="true" onDataBinding="cnt_Container16_onDataBinding"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression19()) %></osweb:PlaceHolder></osweb:Container></phPlaceholder1><phPlaceholder2><osweb:Container runat="server" id="wt_Container8" anonymous="true" onDataBinding="cnt_Container8_onDataBinding"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression5()) %></osweb:PlaceHolder></osweb:Container></phPlaceholder2></widgets:K9I1AM_sXKUGOueuMRKEyiQ><osweb:Container runat="server" id="wt_Container6" anonymous="true" onDataBinding="cnt_Container6_onDataBinding" GridCssClasses="OSAutoMarginTop"><osweb:Container runat="server" id="wt_Container22" anonymous="true" onDataBinding="cnt_Container22_onDataBinding"><osweb:PlaceHolder runat="server"><%# "Tasks linked to this Assessment :" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container20" anonymous="true" onDataBinding="cnt_Container20_onDataBinding" GridCssClasses="OSAutoMarginTop"><widgets:KlQiCMkhBl0eXcUBYrz68yg runat="server" id="wt_WebBlockInstance21" OnEvaluateParameters="webBlck_WebBlockInstance21_onDataBinding" InstanceID="_WebBlockInstance21"></widgets:KlQiCMkhBl0eXcUBYrz68yg></osweb:Container></osweb:Container></osweb:Container></osweb:Container></osweb:Container></ItemTemplate><InvisibleTemplate><%# recListAssessmentsList_Store(Container.DataItem, Container.ItemIndex) %></InvisibleTemplate></osweb:Iterator><%# PageEndHook() %>