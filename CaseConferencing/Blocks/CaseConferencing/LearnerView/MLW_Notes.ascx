﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\CaseConferencing\LearnerView\MLW_Notes.ascx.cs" Inherits="ssCaseConferencing.Flows.FlowLearnerView.WBlkMLW_Notes,CaseConferencing" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssCaseConferencing" %>
<%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="..\..\CaseConferencing\RichWidgets\Icon.ascx" %><%@ Register TagPrefix="widgets" TagName="K1tHu2scNhke0DPtNY_WdAQ" Src="..\..\CaseConferencing\Common\DateFormatted.ascx" %><%# PageStartHook() %><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If6() %>"><osweb:Iterator runat="server" id="wtListNotes" onDataBinding="recListListNotes_onDataBinding" cssClass="ListRecords" OnItemCommand="recListListNotes_Select" OnSetViewStateStorage="recListListNotes_Store" OnClearViewStateStorage="recListListNotes_Clear" OnListRefreshDataBind="recListListNotes_ListRefreshDataBind" NeedsBreakAfter="true"><ItemTemplate><osweb:Container runat="server" id="wt_Container1" anonymous="true" onDataBinding="cnt_Container1_onDataBinding" style="margin-top: 0px"><osweb:Container runat="server" id="wt_Container11" anonymous="true" onDataBinding="cnt_Container11_onDataBinding"><osweb:Container runat="server" id="wt_Container3" anonymous="true" onDataBinding="cnt_Container3_onDataBinding" GridCssClasses="OSInline"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance2" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance2_onDataBinding" InstanceID="_WebBlockInstance2"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:Span runat="server" id="wt_InlineExpression8" anonymous="true" class="Bold"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression8()) %></osweb:Span></osweb:Container><osweb:Container runat="server" id="wt_Container7" anonymous="true" onDataBinding="cnt_Container7_onDataBinding" GridCssClasses="OSInline ThemeGrid_MarginGutter"><widgets:K1tHu2scNhke0DPtNY_WdAQ runat="server" id="wt_WebBlockInstance4" OnEvaluateParameters="webBlck_WebBlockInstance4_onDataBinding" InstanceID="_WebBlockInstance4"></widgets:K1tHu2scNhke0DPtNY_WdAQ></osweb:Container></osweb:Container><osweb:Span runat="server" id="wt_InlineExpression10" anonymous="true" class="Text_Note"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression10()) %></osweb:Span></osweb:Container></ItemTemplate><InvisibleTemplate><%# recListListNotes_Store(Container.DataItem, Container.ItemIndex) %></InvisibleTemplate></osweb:Iterator></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If6() %>"></osweb:If></osweb:IfPlaceHolder><%# PageEndHook() %>