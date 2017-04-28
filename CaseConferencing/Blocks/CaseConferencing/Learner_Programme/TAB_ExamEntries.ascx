﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\CaseConferencing\Learner_Programme\TAB_ExamEntries.ascx.cs" Inherits="ssCaseConferencing.Flows.FlowLearner_Programme.WBlkTAB_ExamEntries,CaseConferencing" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssCaseConferencing" %>
<%@ Register TagPrefix="RichWidgets_widgets" TagName="Kbbzz9S_an_V_uoCTOfsBiA" Src="..\..\CaseConferencing\RichWidgets\Popup_Editor.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="..\..\CaseConferencing\RichWidgets\Icon.ascx" %><%# PageStartHook() %><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If50() %>"><osweb:Container runat="server" id="wt_Container73" anonymous="true" onDataBinding="cnt_Container73_onDataBinding" align="right"><RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA runat="server" id="RichWidgets_wt_WebBlockInstance79" onAjaxNotify="RichWidgets_webBlck_WebBlockInstance79_AjaxNotify" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance79_onDataBinding" InstanceID="_WebBlockInstance79"></RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA><osweb:HyperLink runat="server" id="wtLinkAddNewEntry" Visible="<%# lnkLinkAddNewEntry_isVisible() %>" Enabled="<%# lnkLinkAddNewEntry_isEnabled() %>" NavigateUrl="<%# lnkLinkAddNewEntry_NavigateUrl() %>"><osweb:Container runat="server" id="wt_Container32" anonymous="true" onDataBinding="cnt_Container32_onDataBinding" cssClass="HeaderButton" GridCssClasses="OSInline" style="margin-top: 10px" align="center"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance75" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance75_onDataBinding" InstanceID="_WebBlockInstance75"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# " New Entry" %></osweb:PlaceHolder></osweb:Container></osweb:HyperLink></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If50() %>"></osweb:If></osweb:IfPlaceHolder><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If6() %>"><osweb:OSDataGrid runat="server" id="wtExamEntryTable" onDataBinding="recTableExamEntryTable_onDataBinding" cssClass="TableRecords" GridCssClasses="OSFillParent" style="margin-top: 10px" ClientIDMode="AutoID" AutoGenerateColumns="false" OnSetViewStateStorage="recTableExamEntryTable_Store" OnClearViewStateStorage="recTableExamEntryTable_Clear" OnListRefreshDataBind="recTableExamEntryTable_ListRefreshDataBind" HeaderLineStyle="TableRecords_Header" OddLineStyle="TableRecords_OddLine" EvenLineStyle="TableRecords_EvenLine" OnItemCommand="recTableExamEntryTable_Select" Gridlines="none"><Columns><osweb:OSTemplateColumn><HeaderTemplate><osweb:Container runat="server" id="wt_Container16" anonymous="true" onDataBinding="cnt_Container16_onDataBinding" align="left"><osweb:PlaceHolder runat="server"><%# "Exam Name" %></osweb:PlaceHolder></osweb:Container></HeaderTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><HeaderTemplate><osweb:Container runat="server" id="wt_Container38" anonymous="true" onDataBinding="cnt_Container38_onDataBinding" align="left"><osweb:PlaceHolder runat="server"><%# "Entry Type" %></osweb:PlaceHolder></osweb:Container></HeaderTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><HeaderTemplate><osweb:Container runat="server" id="wt_Container10" anonymous="true" onDataBinding="cnt_Container10_onDataBinding" align="left"><osweb:PlaceHolder runat="server"><%# "Series" %></osweb:PlaceHolder></osweb:Container></HeaderTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><HeaderTemplate><osweb:Container runat="server" id="wt_Container29" anonymous="true" onDataBinding="cnt_Container29_onDataBinding" align="left"><osweb:PlaceHolder runat="server"><%# "Grade" %></osweb:PlaceHolder></osweb:Container></HeaderTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><HeaderTemplate><osweb:Container runat="server" id="wt_Container51" anonymous="true" onDataBinding="cnt_Container51_onDataBinding" align="center"><osweb:PlaceHolder runat="server"><%# "Max Mark" %></osweb:PlaceHolder></osweb:Container></HeaderTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><HeaderTemplate><osweb:Container runat="server" id="wt_Container1" anonymous="true" onDataBinding="cnt_Container1_onDataBinding" align="left"><osweb:PlaceHolder runat="server"><%# "Registration Number / Date" %></osweb:PlaceHolder></osweb:Container></HeaderTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><HeaderTemplate><osweb:Container runat="server" id="wt_Container41" anonymous="true" onDataBinding="cnt_Container41_onDataBinding" align="center"><osweb:PlaceHolder runat="server"><%# "Exam Date" %></osweb:PlaceHolder></osweb:Container></HeaderTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><HeaderTemplate></HeaderTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><ItemTemplate><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExecuteDataBind(new System.EventHandler(wt_TableRecordsDataCell66_onDataBinding), ((Control) sender).Parent) %><osweb:Container runat="server" id="wt_Container60" anonymous="true" onDataBinding="cnt_Container60_onDataBinding" align="left"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression37()) %></osweb:PlaceHolder></osweb:Container></ItemTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><ItemTemplate><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExecuteDataBind(new System.EventHandler(wt_TableRecordsDataCell64_onDataBinding), ((Control) sender).Parent) %><osweb:Container runat="server" id="wt_Container36" anonymous="true" onDataBinding="cnt_Container36_onDataBinding" align="left"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression76()) %></osweb:PlaceHolder></osweb:Container></ItemTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><ItemTemplate><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExecuteDataBind(new System.EventHandler(wt_TableRecordsDataCell77_onDataBinding), ((Control) sender).Parent) %><osweb:Container runat="server" id="wt_Container47" anonymous="true" onDataBinding="cnt_Container47_onDataBinding" align="left"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression18()) %></osweb:PlaceHolder></osweb:Container></ItemTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><ItemTemplate><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExecuteDataBind(new System.EventHandler(wt_TableRecordsDataCell2_onDataBinding), ((Control) sender).Parent) %><osweb:Container runat="server" id="wt_Container71" anonymous="true" onDataBinding="cnt_Container71_onDataBinding" align="left"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression45()) %></osweb:PlaceHolder></osweb:Container></ItemTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><ItemTemplate><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExecuteDataBind(new System.EventHandler(wt_TableRecordsDataCell40_onDataBinding), ((Control) sender).Parent) %><osweb:Container runat="server" id="wt_Container46" anonymous="true" onDataBinding="cnt_Container46_onDataBinding" align="center"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression26()) %></osweb:PlaceHolder></osweb:Container></ItemTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><ItemTemplate><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExecuteDataBind(new System.EventHandler(wt_TableRecordsDataCell42_onDataBinding), ((Control) sender).Parent) %><osweb:Container runat="server" id="wt_Container49" anonymous="true" onDataBinding="cnt_Container49_onDataBinding" align="left"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression7()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container27" anonymous="true" onDataBinding="cnt_Container27_onDataBinding" style="margin-top: 0px" align="left"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If55() %>"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression24()) %></osweb:PlaceHolder></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If55() %>"></osweb:If></osweb:IfPlaceHolder></osweb:Container></ItemTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><ItemTemplate><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExecuteDataBind(new System.EventHandler(wt_TableRecordsDataCell3_onDataBinding), ((Control) sender).Parent) %><osweb:Container runat="server" id="wt_Container5" anonymous="true" onDataBinding="cnt_Container5_onDataBinding" align="center"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If39() %>"><osweb:Container runat="server" id="wt_Container33" anonymous="true" onDataBinding="cnt_Container33_onDataBinding" align="right"><osweb:Span runat="server" id="wt_InlineExpression25" anonymous="true" onDataBinding="expression_InlineExpression25_onDataBinding"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression25()) %></osweb:Span></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If39() %>"><osweb:PlaceHolder runat="server"><%# "-" %></osweb:PlaceHolder></osweb:If></osweb:IfPlaceHolder><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If13() %>"><osweb:Container runat="server" id="wt_Container54" anonymous="true" onDataBinding="cnt_Container54_onDataBinding" style="margin-top: 0px" align="right"><osweb:Span runat="server" id="wt_InlineExpression43" anonymous="true" onDataBinding="expression_InlineExpression43_onDataBinding"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression43()) %></osweb:Span></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If13() %>"><osweb:PlaceHolder runat="server"><%# "-" %></osweb:PlaceHolder></osweb:If></osweb:IfPlaceHolder></osweb:Container></ItemTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><ItemTemplate><osweb:Container runat="server" id="wt_Container78" anonymous="true" onDataBinding="cnt_Container78_onDataBinding" align="center"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If61() %>"><osweb:LinkButton runat="server" id="wt_Link44" onDataBinding="lnk_Link44_onDataBinding" Visible="<%# lnk_Link44_isVisible() %>" Enabled="<%# lnk_Link44_isEnabled() %>" CausesValidation="false"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance15" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance15_onDataBinding" InstanceID="_WebBlockInstance15"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# "" %></osweb:PlaceHolder></osweb:LinkButton></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If61() %>"></osweb:If></osweb:IfPlaceHolder></osweb:Container></ItemTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn Visible="false"><ItemTemplate><%# recTableExamEntryTable_Store(Container.DataItem, Container.ItemIndex) %></ItemTemplate></osweb:OSTemplateColumn></Columns></osweb:OSDataGrid></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If6() %>"></osweb:If></osweb:IfPlaceHolder><%# PageEndHook() %>