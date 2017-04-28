﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\CaseConferencing\HelpFlow\HelpUpdatesLayout.ascx.cs" Inherits="ssCaseConferencing.Flows.FlowHelpFlow.WBlkHelpUpdatesLayout,CaseConferencing" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssCaseConferencing" %>
<%@ Register TagPrefix="ThemeProvider_widgets" TagName="Ky1nG5kdyhEesTpKvn40S7g" Src="..\..\CaseConferencing\MainLayouts\Layout_Main.ascx" %><%@ Register TagPrefix="widgets" TagName="KfpAa79RrRUaQSPrU6XYoGA" Src="..\..\CaseConferencing\Common\HelpUpdate.ascx" %><%@ Register TagPrefix="ThemeProvider_widgets" TagName="KJrizqP2Bv0eGnyXPhkrA3w" Src="..\..\CaseConferencing\MainLayouts\Menu_Main.ascx" %><%# PageStartHook() %><ThemeProvider_widgets:Ky1nG5kdyhEesTpKvn40S7g runat="server" id="ThemeProvider_wt_WebBlockInstance6" OnEvaluateParameters="ThemeProvider_webBlck_WebBlockInstance6_onDataBinding" InstanceID="_WebBlockInstance6"><phHelpUpdate><widgets:KfpAa79RrRUaQSPrU6XYoGA runat="server" id="wt_WebBlockInstance13" OnEvaluateParameters="webBlck_WebBlockInstance13_onDataBinding" InstanceID="_WebBlockInstance13"></widgets:KfpAa79RrRUaQSPrU6XYoGA></phHelpUpdate><phHeaderActions><ThemeProvider_widgets:KJrizqP2Bv0eGnyXPhkrA3w runat="server" id="ThemeProvider_wt_WebBlockInstance12" OnEvaluateParameters="ThemeProvider_webBlck_WebBlockInstance12_onDataBinding" InstanceID="_WebBlockInstance12"></ThemeProvider_widgets:KJrizqP2Bv0eGnyXPhkrA3w></phHeaderActions><phTitle><osweb:PlaceholderContainer runat="server" id="wtTitle" onDataBinding="wtTitle_onDataBinding"></osweb:PlaceholderContainer></phTitle><phActions><osweb:PlaceholderContainer runat="server" id="wtActions" onDataBinding="wtActions_onDataBinding"></osweb:PlaceholderContainer></phActions><phMainContent><osweb:Container runat="server" id="wt_Container1" anonymous="true" onDataBinding="cnt_Container1_onDataBinding" cssClass="CenterColumn"><osweb:Container runat="server" id="wt_Container16" anonymous="true" onDataBinding="cnt_Container16_onDataBinding" cssClass="LearnerDetailsMenu"><osweb:Container runat="server" id="wt_Container14" anonymous="true" onDataBinding="cnt_Container14_onDataBinding" onAjaxClick="cnt_Container14_AjaxClick" cssClass="LearnerDetailsMenuEntry"><osweb:Container runat="server" id="wt_Container20" anonymous="true" onDataBinding="cnt_Container20_onDataBinding" cssClass="LearnerDetailsMenuRAGGrey" GridCssClasses="OSInline"></osweb:Container><osweb:Container runat="server" id="wt_Container10" anonymous="true" onDataBinding="cnt_Container10_onDataBinding" GridCssClasses="OSInline"><osweb:PlaceHolder runat="server"><%# "Messages / Updates" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container2" anonymous="true" onDataBinding="cnt_Container2_onDataBinding" GridCssClasses="OSInline"></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container9" anonymous="true" onDataBinding="cnt_Container9_onDataBinding" onAjaxClick="cnt_Container9_AjaxClick" cssClass="LearnerDetailsMenuEntry"><osweb:Container runat="server" id="wt_Container11" anonymous="true" onDataBinding="cnt_Container11_onDataBinding" cssClass="LearnerDetailsMenuRAGGrey" GridCssClasses="OSInline"></osweb:Container><osweb:Container runat="server" id="wt_Container22" anonymous="true" onDataBinding="cnt_Container22_onDataBinding" GridCssClasses="OSInline"><osweb:PlaceHolder runat="server"><%# "User Guide" %></osweb:PlaceHolder></osweb:Container></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container8" anonymous="true" onDataBinding="cnt_Container8_onDataBinding" cssClass="LearnerDetailsMainAreaContent" GridCssClasses="OSInline"><osweb:PlaceholderContainer runat="server" id="wtHelpUpdatesContent" onDataBinding="wtHelpUpdatesContent_onDataBinding"></osweb:PlaceholderContainer></osweb:Container></osweb:Container></phMainContent></ThemeProvider_widgets:Ky1nG5kdyhEesTpKvn40S7g><%# PageEndHook() %>