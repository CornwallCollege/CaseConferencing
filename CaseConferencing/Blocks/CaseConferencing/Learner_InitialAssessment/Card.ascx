﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\CaseConferencing\Learner_InitialAssessment\Card.ascx.cs" Inherits="ssCaseConferencing.Flows.FlowLearner_InitialAssessment.WBlkCard,CaseConferencing" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssCaseConferencing" %>
<%# PageStartHook() %><osweb:Container runat="server" id="wtInitialAssessment" onDataBinding="cntInitialAssessment_onDataBinding" cssClass="SelectedCardItem"><osweb:Container runat="server" id="wt_Container1" anonymous="true" onDataBinding="cnt_Container1_onDataBinding"><osweb:PlaceholderContainer runat="server" id="wtTitle" onDataBinding="wtTitle_onDataBinding"></osweb:PlaceholderContainer><osweb:Container runat="server" id="wt_Container2" anonymous="true" onDataBinding="cnt_Container2_onDataBinding" style="margin-top: 0px"><osweb:PlaceholderContainer runat="server" id="wtAction" onDataBinding="wtAction_onDataBinding"></osweb:PlaceholderContainer></osweb:Container></osweb:Container></osweb:Container><%# PageEndHook() %>