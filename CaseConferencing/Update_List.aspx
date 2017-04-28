﻿<%@ Page Language="c#" Codebehind="Update_List.aspx.cs" AutoEventWireup="false" Inherits="ssCaseConferencing.Flows.FlowBackofficeFlow.ScrnUpdate_List" %><%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %><%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %><%@ Import namespace="ssCaseConferencing" %><%@ Import namespace="OutSystems.HubEdition.RuntimePlatform" %><%@ Register TagPrefix="ThemeProvider_widgets" TagName="Ky1nG5kdyhEesTpKvn40S7g" Src="Blocks\CaseConferencing\MainLayouts\Layout_Main.ascx" %><%@ Register TagPrefix="widgets" TagName="KfpAa79RrRUaQSPrU6XYoGA" Src="Blocks\CaseConferencing\Common\HelpUpdate.ascx" %><%@ Register TagPrefix="ThemeProvider_widgets" TagName="KgWHRAp6ig0iU4JPYFzrEhg" Src="Blocks\CaseConferencing\MainLayouts\Menu_Backoffice.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="K_rKmPheaNoRKwi7NwfmJGg" Src="Blocks\CaseConferencing\RichWidgets\List_SortColumn.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="KGC2Vk_FubdDDjDgOUsciQw" Src="Blocks\CaseConferencing\RichWidgets\List_Counter.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="K1bgPHuCskB0BQCkYm3XxTQ" Src="Blocks\CaseConferencing\RichWidgets\List_Navigation.ascx" %>
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
<ThemeProvider_widgets:Ky1nG5kdyhEesTpKvn40S7g runat="server" id="ThemeProvider_wt_WebBlockInstance12" OnEvaluateParameters="ThemeProvider_webBlck_WebBlockInstance12_onDataBinding" InstanceID="_WebBlockInstance12"><phHelpUpdate><widgets:KfpAa79RrRUaQSPrU6XYoGA runat="server" id="wt_WebBlockInstance24" OnEvaluateParameters="webBlck_WebBlockInstance24_onDataBinding" InstanceID="_WebBlockInstance24"></widgets:KfpAa79RrRUaQSPrU6XYoGA></phHelpUpdate><phHeaderActions><ThemeProvider_widgets:KgWHRAp6ig0iU4JPYFzrEhg runat="server" id="ThemeProvider_wt_WebBlockInstance39" OnEvaluateParameters="ThemeProvider_webBlck_WebBlockInstance39_onDataBinding" InstanceID="_WebBlockInstance39"></ThemeProvider_widgets:KgWHRAp6ig0iU4JPYFzrEhg></phHeaderActions><phTitle><osweb:PlaceHolder runat="server"><%# "Updates" %></osweb:PlaceHolder></phTitle><phActions><osweb:HyperLink runat="server" id="wt_Link2" cssClass="ActionAdd" Visible="<%# lnk_Link2_isVisible() %>" Enabled="<%# lnk_Link2_isEnabled() %>" NavigateUrl="<%# lnk_Link2_NavigateUrl() %>"><osweb:PlaceHolder runat="server"><%# "Create a new Update" %></osweb:PlaceHolder></osweb:HyperLink></phActions><phMainContent><osweb:Container runat="server" id="wtUpdateTable_Wrapper" onDataBinding="cntUpdateTable_Wrapper_onDataBinding" cssClass="TableRecords_Wrapper"><osweb:Container runat="server" id="wtFilters_Wrapper" onDataBinding="cntFilters_Wrapper_onDataBinding" cssClass="Filters_Wrapper"><osweb:TextBox runat="server" id="wtSearchInput" onDataBinding="inputwtSearchInput_onDataBinding" GridCssClasses="ThemeGrid_Width4" Visible="<%# inputwtSearchInput_isVisible() %>" ReadOnly="<%# !inputwtSearchInput_isEnabled() %>" maxlength="100" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" OnDefaultTypeValidationMessage="GetTextValidatorMsg" textmode="SingleLine" text="<%# inputwtSearchInput_input_value() %>" onTextChanged="inputwtSearchInput_input_onTextChanged" Mandatory="<%# inputwtSearchInput_isMandatory() %>"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wtSearchInputValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wtSearchInput"/><osweb:TextValidator runat="server" display="Dynamic" id="wtSearchInputValidatorType" ErrorMessage="<%# CaseConferencing_Properties.TextValidatorMsg %>" ControlToValidate="wtSearchInput" ClientValidationFunction="OsCustomValidatorText"/><osweb:Button runat="server" id="wt_Button43" onDataBinding="btn_Button43_onDataBinding" cssClass="Button Is_Default" GridCssClasses="ThemeGrid_MarginGutter" Visible="<%# btn_Button43_isVisible() %>" Enabled="<%# btn_Button43_isEnabled() %>" CausesValidation="true" text="<%# btn_Button43_getLabel() %>"/><osweb:Button runat="server" id="wt_Button20" onDataBinding="btn_Button20_onDataBinding" cssClass="Button" GridCssClasses="ThemeGrid_MarginGutter" Visible="<%# btn_Button20_isVisible() %>" Enabled="<%# btn_Button20_isEnabled() %>" CausesValidation="false" text="<%# btn_Button20_getLabel() %>"/></osweb:Container><osweb:OSDataGrid runat="server" id="wtUpdateTable" onDataBinding="recTableUpdateTable_onDataBinding" cssClass="TableRecords" GridCssClasses="OSFillParent OSAutoMarginTop" ClientIDMode="AutoID" AutoGenerateColumns="false" OnSetViewStateStorage="recTableUpdateTable_Store" OnClearViewStateStorage="recTableUpdateTable_Clear" OnListRefreshDataBind="recTableUpdateTable_ListRefreshDataBind" HeaderLineStyle="TableRecords_Header" OddLineStyle="TableRecords_OddLine" EvenLineStyle="TableRecords_EvenLine" OnItemCommand="recTableUpdateTable_Select" Gridlines="none"><Columns><osweb:OSTemplateColumn><HeaderTemplate><osweb:Container runat="server" id="wt_Container11" anonymous="true" onDataBinding="cnt_Container11_onDataBinding" align="right"><osweb:PlaceHolder runat="server"><%# "Update Date" %></osweb:PlaceHolder><RichWidgets_widgets:K_rKmPheaNoRKwi7NwfmJGg runat="server" id="RichWidgets_wt_WebBlockInstance5" onAjaxNotify="RichWidgets_webBlck_WebBlockInstance5_AjaxNotify" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance5_onDataBinding" InstanceID="_WebBlockInstance5"></RichWidgets_widgets:K_rKmPheaNoRKwi7NwfmJGg></osweb:Container></HeaderTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><HeaderTemplate><osweb:PlaceHolder runat="server"><%# "Update Submitted By" %></osweb:PlaceHolder><RichWidgets_widgets:K_rKmPheaNoRKwi7NwfmJGg runat="server" id="RichWidgets_wt_WebBlockInstance16" onAjaxNotify="RichWidgets_webBlck_WebBlockInstance16_AjaxNotify" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance16_onDataBinding" InstanceID="_WebBlockInstance16"></RichWidgets_widgets:K_rKmPheaNoRKwi7NwfmJGg></HeaderTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><HeaderTemplate><osweb:PlaceHolder runat="server"><%# "Update Title" %></osweb:PlaceHolder><RichWidgets_widgets:K_rKmPheaNoRKwi7NwfmJGg runat="server" id="RichWidgets_wt_WebBlockInstance18" onAjaxNotify="RichWidgets_webBlck_WebBlockInstance18_AjaxNotify" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance18_onDataBinding" InstanceID="_WebBlockInstance18"></RichWidgets_widgets:K_rKmPheaNoRKwi7NwfmJGg></HeaderTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><HeaderTemplate><osweb:PlaceHolder runat="server"><%# "Update HTML" %></osweb:PlaceHolder><RichWidgets_widgets:K_rKmPheaNoRKwi7NwfmJGg runat="server" id="RichWidgets_wt_WebBlockInstance31" onAjaxNotify="RichWidgets_webBlck_WebBlockInstance31_AjaxNotify" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance31_onDataBinding" InstanceID="_WebBlockInstance31"></RichWidgets_widgets:K_rKmPheaNoRKwi7NwfmJGg></HeaderTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><ItemTemplate><osweb:Container runat="server" id="wt_Container29" anonymous="true" onDataBinding="cnt_Container29_onDataBinding" align="right"><osweb:HyperLink runat="server" id="wt_Link1" Visible="<%# lnk_Link1_isVisible() %>" Enabled="<%# lnk_Link1_isEnabled() %>" NavigateUrl="<%# lnk_Link1_NavigateUrl() %>" title="<%# lnk_Link1_getTitle() %>" alt="<%# lnk_Link1_getTitle() %>"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression15()) %></osweb:PlaceHolder></osweb:HyperLink></osweb:Container></ItemTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><ItemTemplate><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression26()) %></osweb:PlaceHolder></ItemTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><ItemTemplate><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression35()) %></osweb:PlaceHolder></ItemTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn><ItemTemplate><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression22()) %></osweb:PlaceHolder></ItemTemplate></osweb:OSTemplateColumn><osweb:OSTemplateColumn Visible="false"><ItemTemplate><%# recTableUpdateTable_Store(Container.DataItem, Container.ItemIndex) %></ItemTemplate></osweb:OSTemplateColumn></Columns></osweb:OSDataGrid><osweb:Container runat="server" id="wt_Container36" anonymous="true" onDataBinding="cnt_Container36_onDataBinding" cssClass="TableRecords_BottomNavigation" GridCssClasses="OSAutoMarginTop"><osweb:Container runat="server" id="wt_Container25" anonymous="true" onDataBinding="cnt_Container25_onDataBinding" GridCssClasses="OSInline" style="width: 40%"><RichWidgets_widgets:KGC2Vk_FubdDDjDgOUsciQw runat="server" id="RichWidgets_wt_WebBlockInstance32" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance32_onDataBinding" InstanceID="_WebBlockInstance32"></RichWidgets_widgets:KGC2Vk_FubdDDjDgOUsciQw></osweb:Container><osweb:Container runat="server" id="wt_Container41" anonymous="true" onDataBinding="cnt_Container41_onDataBinding" GridCssClasses="OSInline" style="width: 60%; margin-left: 0px" align="right"><RichWidgets_widgets:K1bgPHuCskB0BQCkYm3XxTQ runat="server" id="RichWidgets_wt_WebBlockInstance13" onAjaxNotify="RichWidgets_webBlck_WebBlockInstance13_AjaxNotify" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance13_onDataBinding" InstanceID="_WebBlockInstance13"></RichWidgets_widgets:K1bgPHuCskB0BQCkYm3XxTQ></osweb:Container></osweb:Container></osweb:Container></phMainContent></ThemeProvider_widgets:Ky1nG5kdyhEesTpKvn40S7g><osweb:DummySubmitLink runat="server" id="Dummy_Submit_Link"/>
    <%= OutSystems.HubEdition.RuntimePlatform.AppInfo.GetAppInfo().GetWatermark() %><%= GetCallbackDebug()	
%><%= GetVisitCode() %></osweb:Form><%= GetEndPageJavaScript() + GetBodyBottomJavaScript() %>
  </osweb:Body>
</html>
