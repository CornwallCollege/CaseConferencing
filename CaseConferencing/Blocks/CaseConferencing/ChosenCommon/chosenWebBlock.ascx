﻿<%@ Control Language="c#" AutoEventWireup="false" Inherits="proxy_CaseConferencing_Chosen.Flows.FlowChosenCommon.WBlkchosenWebBlock,CaseConferencingReferencesProxy" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="client" TagName="node" Src="..\..\Chosen\ChosenCommon\chosenWebBlock.ascx" %>
<client:node id="block" runat="server" OnBindDelegates="BindProxyDelegates" />