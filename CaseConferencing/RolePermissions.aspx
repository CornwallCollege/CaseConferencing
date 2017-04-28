﻿<%@ Page Language="c#" Codebehind="RolePermissions.aspx.cs" AutoEventWireup="false" Inherits="ssCaseConferencing.Flows.FlowBackofficeFlow.ScrnRolePermissions" %><%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %><%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %><%@ Import namespace="ssCaseConferencing" %><%@ Import namespace="OutSystems.HubEdition.RuntimePlatform" %><%@ Register TagPrefix="ThemeProvider_widgets" TagName="Ky1nG5kdyhEesTpKvn40S7g" Src="Blocks\CaseConferencing\MainLayouts\Layout_Main.ascx" %><%@ Register TagPrefix="ThemeProvider_widgets" TagName="KgWHRAp6ig0iU4JPYFzrEhg" Src="Blocks\CaseConferencing\MainLayouts\Menu_Backoffice.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="Blocks\CaseConferencing\RichWidgets\Icon.ascx" %><%@ Register TagPrefix="Chosen_widgets" TagName="KZXhh8PoYlUWdz2C5mmilFA" Src="Blocks\CaseConferencing\ChosenCommon\chosenWebBlock.ascx" %><%@ Register TagPrefix="widgets" TagName="Kcn5cmzcLwE6tr9hSGFJ_ZQ" Src="Blocks\CaseConferencing\BackofficeFlow\RolePermissions_Read.ascx" %>
<%= CaseConferencing_Properties.DocType %>
<html xmlns="http://www.w3.org/1999/xhtml" >
  <head runat="server"><%= GetHeadTopJavaScript() %>
	<title><%= HttpUtility.HtmlEncode (Title) %></title>
    <meta http-equiv="Content-Type" content="<%= "text/html; charset=" + Response.ContentEncoding.WebName %>" />
    <meta http-equiv="Content-Script-Type" content="text/javascript" />
    <meta http-equiv="Content-Style-Type" content="text/css" />
<%= "\n" + GetStyleSheetIncludes() %><%= GetRequestInfoJavaScript() + GetJavaScriptIncludes() + GetHeadBottomJavaScript() %>
  </head>
  <osweb:Body runat="server"><%= GetBodyTopJavaScript() %>
    <osweb:Form id="WebForm1" method="post"  action="<%# GetFormAction() %>" runat="server">
<ThemeProvider_widgets:Ky1nG5kdyhEesTpKvn40S7g runat="server" id="ThemeProvider_wt_WebBlockInstance8" OnEvaluateParameters="ThemeProvider_webBlck_WebBlockInstance8_onDataBinding" InstanceID="_WebBlockInstance8"><phHelpUpdate></phHelpUpdate><phHeaderActions><ThemeProvider_widgets:KgWHRAp6ig0iU4JPYFzrEhg runat="server" id="ThemeProvider_wt_WebBlockInstance27" OnEvaluateParameters="ThemeProvider_webBlck_WebBlockInstance27_onDataBinding" InstanceID="_WebBlockInstance27"></ThemeProvider_widgets:KgWHRAp6ig0iU4JPYFzrEhg></phHeaderActions><phTitle><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance10" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance10_onDataBinding" InstanceID="_WebBlockInstance10"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# "Role Permissions" %></osweb:PlaceHolder></phTitle><phActions></phActions><phMainContent><osweb:Container runat="server" id="wtFilters_Wrapper" onDataBinding="cntFilters_Wrapper_onDataBinding" cssClass="Filters_Wrapper"><osweb:PlaceHolder runat="server"><%# "Permission Type" %></osweb:PlaceHolder><osweb:Container runat="server" id="wt_Container33" anonymous="true" onDataBinding="cnt_Container33_onDataBinding" GridCssClasses="OSInline ThemeGrid_MarginGutter"><Chosen_widgets:KZXhh8PoYlUWdz2C5mmilFA runat="server" id="Chosen_wt_WebBlockInstance31" OnEvaluateParameters="Chosen_webBlck_WebBlockInstance31_onDataBinding" InstanceID="_WebBlockInstance31"></Chosen_widgets:KZXhh8PoYlUWdz2C5mmilFA></osweb:Container><osweb:DropDownList runat="server" id="wtPErmittion" onDataBinding="selPErmittion_onDataBinding" onAjaxChange="selPErmittion_AjaxChange" GridCssClasses="ThemeGrid_Width4 ThemeGrid_MarginGutter" Visible="<%# selPErmittion_isVisible() %>" Enabled="<%# selPErmittion_isEnabled() %>" OnSelectedIndexChanged="selPErmittion_dropDown_valueChanged" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" Mandatory="<%# selPErmittion_isMandatory() %>"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wtPErmittionValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wtPErmittion"/><osweb:Button runat="server" id="wt_Button3" onDataBinding="btn_Button3_onDataBinding" cssClass="Button Is_Default" GridCssClasses="ThemeGrid_MarginGutter" Visible="<%# btn_Button3_isVisible() %>" Enabled="<%# btn_Button3_isEnabled() %>" CausesValidation="false" text="<%# btn_Button3_getLabel() %>"/></osweb:Container><osweb:Container runat="server" id="wt_Container2" anonymous="true" onDataBinding="cnt_Container2_onDataBinding" GridCssClasses="OSAutoMarginTop" align="right"><osweb:Button runat="server" id="wt_Button4" cssClass="Button" Visible="<%# btn_Button4_isVisible() %>" Enabled="<%# btn_Button4_isEnabled() %>" CausesValidation="false" text="<%# btn_Button4_getLabel() %>"/></osweb:Container><span runat="server" id="wtApplicationSectionTableAjaxRfrsh"><osweb:OSDataGrid runat="server" id="wtApplicationSectionTable" onDataBinding="recTableApplicationSectionTable_onDataBinding" cssClass="TableRecords" GridCssClasses="OSFillParent OSAutoMarginTop" ClientIDMode="AutoID" AutoGenerateColumns="false" OnSetViewStateStorage="recTableApplicationSectionTable_Store" OnClearViewStateStorage="recTableApplicationSectionTable_Clear" OnListRefreshDataBind="recTableApplicationSectionTable_ListRefreshDataBind" HeaderLineStyle="TableRecords_Header" OddLineStyle="TableRecords_OddLine" EvenLineStyle="TableRecords_EvenLine" OnItemCommand="recTableApplicationSectionTable_Select" Gridlines="none"><Columns><osweb:OSTemplateColumn><HeaderTemplate><osweb:PlaceHolder runat="server"><%# "Application Permission" %></osweb:PlaceHolder></HeaderTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><HeaderTemplate><osweb:PlaceHolder runat="server"><%# "Read" %></osweb:PlaceHolder></HeaderTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><HeaderTemplate><osweb:PlaceHolder runat="server"><%# "Read/Write" %></osweb:PlaceHolder></HeaderTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><ItemTemplate><osweb:Container runat="server" id="wt_Container16" anonymous="true" onDataBinding="cnt_Container16_onDataBinding"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression17()) %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container32" anonymous="true" onDataBinding="cnt_Container32_onDataBinding" style="margin-top: 0px"><osweb:Span runat="server" id="wt_InlineExpression20" anonymous="true" class="Text_Note"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression20()) %></osweb:Span></osweb:Container></ItemTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><ItemTemplate><widgets:Kcn5cmzcLwE6tr9hSGFJ_ZQ runat="server" id="wt_WebBlockInstance30" OnEvaluateParameters="webBlck_WebBlockInstance30_onDataBinding" InstanceID="_WebBlockInstance30"></widgets:Kcn5cmzcLwE6tr9hSGFJ_ZQ></ItemTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><ItemTemplate><widgets:Kcn5cmzcLwE6tr9hSGFJ_ZQ runat="server" id="wt_WebBlockInstance26" OnEvaluateParameters="webBlck_WebBlockInstance26_onDataBinding" InstanceID="_WebBlockInstance26"></widgets:Kcn5cmzcLwE6tr9hSGFJ_ZQ></ItemTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn Visible="false"><ItemTemplate><%# recTableApplicationSectionTable_Store(Container.DataItem, Container.ItemIndex) %></ItemTemplate></osweb:OSTemplateColumn></Columns></osweb:OSDataGrid></span></phMainContent></ThemeProvider_widgets:Ky1nG5kdyhEesTpKvn40S7g><osweb:DummySubmitLink runat="server" id="Dummy_Submit_Link"/>
    <%= OutSystems.HubEdition.RuntimePlatform.AppInfo.GetAppInfo().GetWatermark() %><%= GetCallbackDebug()	
%><%= GetVisitCode() %></osweb:Form><%= GetEndPageJavaScript() + GetBodyBottomJavaScript() %>
  </osweb:Body>
</html>