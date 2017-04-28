﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\CaseConferencing\AutoComplete_Bank\AutoComplete_Block.ascx.cs" Inherits="ssCaseConferencing.Flows.FlowAutoComplete_Bank.WBlkAutoComplete_Block,CaseConferencing" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssCaseConferencing" %>
<%@ Register TagPrefix="Chosen_widgets" TagName="KZXhh8PoYlUWdz2C5mmilFA" Src="..\..\CaseConferencing\ChosenCommon\chosenWebBlock.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="..\..\CaseConferencing\RichWidgets\Icon.ascx" %><%# PageStartHook() %><osweb:Container runat="server" id="wtWrapper" onDataBinding="cntWrapper_onDataBinding" cssClass="WrapperStyle" GridCssClasses="OSInline" style="width: 520px"><osweb:Container runat="server" id="wt_Container26" anonymous="true" onDataBinding="cnt_Container26_onDataBinding"><osweb:Span runat="server" id="wt_Text2" anonymous="true" class="TitleLabel"><%# "Statements Bank" %></osweb:Span><osweb:Span runat="server" id="wt_InlineExpression4" anonymous="true" onDataBinding="expression_InlineExpression4_onDataBinding"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression4()) %></osweb:Span></osweb:Container><osweb:Container runat="server" id="wt_Container28" anonymous="true" onDataBinding="cnt_Container28_onDataBinding" GridCssClasses="OSAutoMarginTop" style="min-height: 80px"><osweb:Container runat="server" id="wt_Container12" anonymous="true" onDataBinding="cnt_Container12_onDataBinding"><osweb:Iterator runat="server" id="wtListRecords1" onDataBinding="recListListRecords1_onDataBinding" cssClass="ListRecords" OnItemCommand="recListListRecords1_Select" OnSetViewStateStorage="recListListRecords1_Store" OnClearViewStateStorage="recListListRecords1_Clear" OnListRefreshDataBind="recListListRecords1_ListRefreshDataBind"><ItemTemplate><osweb:Container runat="server" id="wt_Container5" anonymous="true" onDataBinding="cnt_Container5_onDataBinding" onAjaxClick="cnt_Container5_AjaxClick" cssClass="AutoComplete_Card" GridCssClasses="OSInline"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression10()) %></osweb:PlaceHolder></osweb:Container></ItemTemplate><InvisibleTemplate><%# recListListRecords1_Store(Container.DataItem, Container.ItemIndex) %></InvisibleTemplate></osweb:Iterator></osweb:Container><osweb:Container runat="server" id="wt_Container25" anonymous="true" onDataBinding="cnt_Container25_onDataBinding" GridCssClasses="OSAutoMarginTop"><osweb:Iterator runat="server" id="wtListRecords2" onDataBinding="recListListRecords2_onDataBinding" cssClass="ListRecords" OnItemCommand="recListListRecords2_Select" OnSetViewStateStorage="recListListRecords2_Store" OnClearViewStateStorage="recListListRecords2_Clear" OnListRefreshDataBind="recListListRecords2_ListRefreshDataBind"><ItemTemplate><osweb:Container runat="server" id="wt_Container8" anonymous="true" onDataBinding="cnt_Container8_onDataBinding" onAjaxClick="cnt_Container8_AjaxClick" cssClass="AutoComplete_Card" GridCssClasses="OSInline"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression21()) %></osweb:PlaceHolder></osweb:Container></ItemTemplate><InvisibleTemplate><%# recListListRecords2_Store(Container.DataItem, Container.ItemIndex) %></InvisibleTemplate></osweb:Iterator></osweb:Container><osweb:Container runat="server" id="wt_Container32" anonymous="true" onDataBinding="cnt_Container32_onDataBinding" GridCssClasses="OSAutoMarginTop"><osweb:Iterator runat="server" id="wtListRecords3" onDataBinding="recListListRecords3_onDataBinding" cssClass="ListRecords" OnItemCommand="recListListRecords3_Select" OnSetViewStateStorage="recListListRecords3_Store" OnClearViewStateStorage="recListListRecords3_Clear" OnListRefreshDataBind="recListListRecords3_ListRefreshDataBind"><ItemTemplate><osweb:Container runat="server" id="wt_Container9" anonymous="true" onDataBinding="cnt_Container9_onDataBinding" onAjaxClick="cnt_Container9_AjaxClick" cssClass="AutoComplete_Card" GridCssClasses="OSInline"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression27()) %></osweb:PlaceHolder></osweb:Container></ItemTemplate><InvisibleTemplate><%# recListListRecords3_Store(Container.DataItem, Container.ItemIndex) %></InvisibleTemplate></osweb:Iterator></osweb:Container><osweb:Container runat="server" id="wt_Container1" anonymous="true" onDataBinding="cnt_Container1_onDataBinding" GridCssClasses="OSAutoMarginTop"><osweb:Iterator runat="server" id="wtListRecords4" onDataBinding="recListListRecords4_onDataBinding" cssClass="ListRecords" OnItemCommand="recListListRecords4_Select" OnSetViewStateStorage="recListListRecords4_Store" OnClearViewStateStorage="recListListRecords4_Clear" OnListRefreshDataBind="recListListRecords4_ListRefreshDataBind"><ItemTemplate><osweb:Container runat="server" id="wt_Container11" anonymous="true" onDataBinding="cnt_Container11_onDataBinding" onAjaxClick="cnt_Container11_AjaxClick" cssClass="AutoComplete_Card" GridCssClasses="OSInline"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression13()) %></osweb:PlaceHolder></osweb:Container></ItemTemplate><InvisibleTemplate><%# recListListRecords4_Store(Container.DataItem, Container.ItemIndex) %></InvisibleTemplate></osweb:Iterator></osweb:Container></osweb:Container><osweb:Container runat="server" id="wtAutoCompleteDrop" onDataBinding="cntAutoCompleteDrop_onDataBinding" GridCssClasses="OSAutoMarginTop" align="left"><osweb:DropDownList runat="server" id="wtAutocompleteDrop2" onDataBinding="selAutocompleteDrop2_onDataBinding" cssClass="SelectStyle" style="width: 450px" Visible="<%# selAutocompleteDrop2_isVisible() %>" Enabled="<%# selAutocompleteDrop2_isEnabled() %>" OnSelectedIndexChanged="selAutocompleteDrop2_dropDown_valueChanged" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" Mandatory="<%# selAutocompleteDrop2_isMandatory() %>"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wtAutocompleteDrop2ValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wtAutocompleteDrop2"/></osweb:Container><Chosen_widgets:KZXhh8PoYlUWdz2C5mmilFA runat="server" id="Chosen_wt_WebBlockInstance16" OnEvaluateParameters="Chosen_webBlck_WebBlockInstance16_onDataBinding" InstanceID="_WebBlockInstance16"></Chosen_widgets:KZXhh8PoYlUWdz2C5mmilFA><osweb:Container runat="server" id="wt_Container3" anonymous="true" onDataBinding="cnt_Container3_onDataBinding" GridCssClasses="OSAutoMarginTop"><osweb:LinkButton runat="server" id="wtEditLink" onDataBinding="lnkEditLink_onDataBinding" Visible="<%# lnkEditLink_isVisible() %>" Enabled="<%# lnkEditLink_isEnabled() %>" CausesValidation="false"><osweb:Container runat="server" id="wt_Container30" anonymous="true" onDataBinding="cnt_Container30_onDataBinding" cssClass="HeaderButton" GridCssClasses="OSInline" style="margin-left: 0px" align="center"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance14" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance14_onDataBinding" InstanceID="_WebBlockInstance14"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# " Select" %></osweb:PlaceHolder></osweb:Container></osweb:LinkButton></osweb:Container><osweb:Container runat="server" id="wt_Container20" anonymous="true" onDataBinding="cnt_Container20_onDataBinding" GridCssClasses="ThemeGrid_Width6" style="margin-top: 10px" align="right"><osweb:LinkButton runat="server" id="wtEditLink2" onDataBinding="lnkEditLink2_onDataBinding" Visible="<%# lnkEditLink2_isVisible() %>" Enabled="<%# lnkEditLink2_isEnabled() %>" CausesValidation="false"><osweb:Container runat="server" id="wt_Container6" anonymous="true" onDataBinding="cnt_Container6_onDataBinding" cssClass="HeaderButton" GridCssClasses="OSInline" style="width: 100px; margin-left: 0px" align="center"><osweb:PlaceHolder runat="server"><%# " Select" %></osweb:PlaceHolder></osweb:Container></osweb:LinkButton></osweb:Container></osweb:Container><%# PageEndHook() %>