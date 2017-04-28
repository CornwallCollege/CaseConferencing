﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\CaseConferencing\Learner_ILP\MarkbookTrackingUnits.ascx.cs" Inherits="ssCaseConferencing.Flows.FlowLearner_ILP.WBlkMarkbookTrackingUnits,CaseConferencing" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssCaseConferencing" %>
<%@ Register TagPrefix="widgets" TagName="K9I1AM_sXKUGOueuMRKEyiQ" Src="TileIconText.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="..\..\CaseConferencing\RichWidgets\Icon.ascx" %><%@ Register TagPrefix="widgets" TagName="KNwfRGidgW0GVGuqsUN4ciw" Src="MarkbookTrackingAssessments.ascx" %><%@ Register TagPrefix="widgets" TagName="KlQiCMkhBl0eXcUBYrz68yg" Src="MarkbookTrackingTasks.ascx" %><%# PageStartHook() %><osweb:Iterator runat="server" id="wtMarkbookUnitsList" onDataBinding="recListMarkbookUnitsList_onDataBinding" cssClass="ListRecords" OnItemCommand="recListMarkbookUnitsList_Select" OnSetViewStateStorage="recListMarkbookUnitsList_Store" OnClearViewStateStorage="recListMarkbookUnitsList_Clear" OnListRefreshDataBind="recListMarkbookUnitsList_ListRefreshDataBind"><ItemTemplate><osweb:Container runat="server" id="wtContentContainer" onDataBinding="cntContentContainer_onDataBinding"><osweb:Container runat="server" id="wtUnitContainer" onDataBinding="cntUnitContainer_onDataBinding" onAjaxClick="cntUnitContainer_AjaxClick"><osweb:Container runat="server" id="wt_Container3" anonymous="true" onDataBinding="cnt_Container3_onDataBinding" GridCssClasses="OSInline" style="width: 90%"><widgets:K9I1AM_sXKUGOueuMRKEyiQ runat="server" id="wt_WebBlockInstance22" OnEvaluateParameters="webBlck_WebBlockInstance22_onDataBinding" InstanceID="_WebBlockInstance22"><phLabel><osweb:Container runat="server" id="wt_Container6" anonymous="true" onDataBinding="cnt_Container6_onDataBinding" align="left"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression11()) %></osweb:PlaceHolder></osweb:Container></phLabel><phText><osweb:Container runat="server" id="wt_Container2" anonymous="true" onDataBinding="cnt_Container2_onDataBinding" cssClass="Text_Note" align="left"><osweb:Span runat="server" id="wt_InlineExpression5" anonymous="true" onDataBinding="expression_InlineExpression5_onDataBinding"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression5()) %></osweb:Span></osweb:Container></phText><phPlaceholder1><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression4()) %></osweb:PlaceHolder></phPlaceholder1><phPlaceholder2><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression17()) %></osweb:PlaceHolder></phPlaceholder2></widgets:K9I1AM_sXKUGOueuMRKEyiQ></osweb:Container><osweb:Container runat="server" id="wtIconExpand" onDataBinding="cntIconExpand_onDataBinding" GridCssClasses="OSInline ThemeGrid_MarginGutter" align="right"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If30() %>"><osweb:Container runat="server" id="wt_Container29" anonymous="true" onDataBinding="cnt_Container29_onDataBinding"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance27" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance27_onDataBinding" InstanceID="_WebBlockInstance27"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If30() %>"><osweb:Container runat="server" id="wt_Container7" anonymous="true" onDataBinding="cnt_Container7_onDataBinding"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance23" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance23_onDataBinding" InstanceID="_WebBlockInstance23"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w></osweb:Container></osweb:If></osweb:IfPlaceHolder></osweb:Container></osweb:Container><osweb:Container runat="server" id="wtAssessmentsContainer" onDataBinding="cntAssessmentsContainer_onDataBinding" style="margin-top: 5px"><widgets:KNwfRGidgW0GVGuqsUN4ciw runat="server" id="wt_WebBlockInstance16" OnEvaluateParameters="webBlck_WebBlockInstance16_onDataBinding" InstanceID="_WebBlockInstance16"></widgets:KNwfRGidgW0GVGuqsUN4ciw></osweb:Container><osweb:Container runat="server" id="wtTaskContainer" onDataBinding="cntTaskContainer_onDataBinding" GridCssClasses="OSAutoMarginTop"><osweb:Container runat="server" id="wt_Container20" anonymous="true" onDataBinding="cnt_Container20_onDataBinding"><osweb:Container runat="server" id="wt_Container8" anonymous="true" onDataBinding="cnt_Container8_onDataBinding"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression12()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container18" anonymous="true" onDataBinding="cnt_Container18_onDataBinding" GridCssClasses="OSAutoMarginTop"><widgets:KlQiCMkhBl0eXcUBYrz68yg runat="server" id="wt_WebBlockInstance31" OnEvaluateParameters="webBlck_WebBlockInstance31_onDataBinding" InstanceID="_WebBlockInstance31"></widgets:KlQiCMkhBl0eXcUBYrz68yg></osweb:Container></osweb:Container></osweb:Container></osweb:Container></ItemTemplate><InvisibleTemplate><%# recListMarkbookUnitsList_Store(Container.DataItem, Container.ItemIndex) %></InvisibleTemplate></osweb:Iterator><%# PageEndHook() %>