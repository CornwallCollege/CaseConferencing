﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\CaseConferencing\Common\PopUp.ascx.cs" Inherits="ssCaseConferencing.Flows.FlowCommon.WBlkPopUp,CaseConferencing" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssCaseConferencing" %>
<%@ Register TagPrefix="widgets" TagName="Kuto0fwNKFEaIRwSLDAWnjA" Src="PopUpArrow.ascx" %><%# PageStartHook() %><osweb:Container runat="server" id="wtPopupWrapper" onDataBinding="cntPopupWrapper_onDataBinding" cssClass="Popup_Wrapper"><osweb:Container runat="server" id="wt_Container2" anonymous="true" onDataBinding="cnt_Container2_onDataBinding" GridCssClasses="OSInline"><widgets:Kuto0fwNKFEaIRwSLDAWnjA runat="server" id="wt_WebBlockInstance4" OnEvaluateParameters="webBlck_WebBlockInstance4_onDataBinding" InstanceID="_WebBlockInstance4"></widgets:Kuto0fwNKFEaIRwSLDAWnjA></osweb:Container><osweb:PlaceholderContainer runat="server" id="wtPopupContent" onDataBinding="wtPopupContent_onDataBinding"></osweb:PlaceholderContainer><osweb:PlaceHolder runat="server"><%# expression_InlineExpression3() %></osweb:PlaceHolder></osweb:Container><%# PageEndHook() %>