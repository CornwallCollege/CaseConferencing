﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\NumberSlider\NumberSlider\NumberSlider.ascx.cs" Inherits="ssNumberSlider.Flows.FlowNumberSlider.WBlkNumberSlider,NumberSlider" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssNumberSlider" %>
<%@ Register TagPrefix="widgets" TagName="KD76_D3q5GkKdt1ekO5ZcVg" Src="..\..\NumberSlider\Libs\jQueryUI_1_11_2.ascx" %><%@ Register TagPrefix="widgets" TagName="KoT5FHvZOYEWqqAD8mluhwg" Src="..\..\NumberSlider\Libs\TouchPunch.ascx" %><%# PageStartHook() %><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt2() %>"><osweb:Container runat="server" id="wt20" anonymous="true" onDataBinding="cnt20_onDataBinding" cssClass="Text_Note"><osweb:PlaceHolder runat="server"><%# "&lt;Slider&gt;" %></osweb:PlaceHolder></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt2() %>"><osweb:Container runat="server" id="wt18" anonymous="true" onDataBinding="cnt18_onDataBinding" cssClass="jQueryUiSlider"><widgets:KD76_D3q5GkKdt1ekO5ZcVg runat="server" id="wt22" OnEvaluateParameters="webBlck22_onDataBinding" InstanceID="22"></widgets:KD76_D3q5GkKdt1ekO5ZcVg><widgets:KoT5FHvZOYEWqqAD8mluhwg runat="server" id="wt19" OnEvaluateParameters="webBlck19_onDataBinding" InstanceID="19"></widgets:KoT5FHvZOYEWqqAD8mluhwg><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt21() %>"><osweb:Container runat="server" id="wtUpperLegend" onDataBinding="cntUpperLegend_onDataBinding"><osweb:Iterator runat="server" id="wtLR_EvenLegen" onDataBinding="recListLR_EvenLegen_onDataBinding" OnItemCommand="recListLR_EvenLegen_Select" OnSetViewStateStorage="recListLR_EvenLegen_Store" OnClearViewStateStorage="recListLR_EvenLegen_Clear" OnListRefreshDataBind="recListLR_EvenLegen_ListRefreshDataBind"><ItemTemplate><osweb:PlaceHolder runat="server"><%# expression1() %></osweb:PlaceHolder></ItemTemplate><InvisibleTemplate><%# recListLR_EvenLegen_Store(Container.DataItem, Container.ItemIndex) %></InvisibleTemplate></osweb:Iterator></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt21() %>"></osweb:If></osweb:IfPlaceHolder><osweb:Container runat="server" id="wtdivSlider" onDataBinding="cntdivSlider_onDataBinding"></osweb:Container><osweb:Button runat="server" id="wtNotifyButton" onDataBinding="btnNotifyButton_onDataBinding" cssClass="Is_Default" Visible="<%# btnNotifyButton_isVisible() %>" Enabled="<%# btnNotifyButton_isEnabled() %>" CausesValidation="false" text="<%# btnNotifyButton_getLabel() %>"/><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt4() %>"><osweb:Container runat="server" id="wtBottomLegen" onDataBinding="cntBottomLegen_onDataBinding"><osweb:Iterator runat="server" id="wtLR_OddLegen" onDataBinding="recListLR_OddLegen_onDataBinding" OnItemCommand="recListLR_OddLegen_Select" OnSetViewStateStorage="recListLR_OddLegen_Store" OnClearViewStateStorage="recListLR_OddLegen_Clear" OnListRefreshDataBind="recListLR_OddLegen_ListRefreshDataBind"><ItemTemplate><osweb:PlaceHolder runat="server"><%# expression13() %></osweb:PlaceHolder></ItemTemplate><InvisibleTemplate><%# recListLR_OddLegen_Store(Container.DataItem, Container.ItemIndex) %></InvisibleTemplate></osweb:Iterator></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt4() %>"></osweb:If></osweb:IfPlaceHolder><osweb:Span runat="server" id="wt12" anonymous="true" class=" "><%# expression12() %></osweb:Span></osweb:Container></osweb:If></osweb:IfPlaceHolder><%# PageEndHook() %>