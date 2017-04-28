﻿<%@ Page Language="c#" Codebehind="Popup_AttachDocument.aspx.cs" AutoEventWireup="false" Inherits="ssCaseConferencing.Flows.FlowCommon.ScrnPopup_AttachDocument" %><%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %><%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %><%@ Import namespace="ssCaseConferencing" %><%@ Import namespace="OutSystems.HubEdition.RuntimePlatform" %><%@ Register TagPrefix="widgets" TagName="KHtW7GNYBskijYiZHuvzUvw" Src="Blocks\CaseConferencing\Common\Popup_Editor_Layout.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="Blocks\CaseConferencing\RichWidgets\Icon.ascx" %>
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
    <osweb:Form id="WebForm1" method="post"  enctype="multipart/form-data" action="<%# GetFormAction() %>" runat="server">
<widgets:KHtW7GNYBskijYiZHuvzUvw runat="server" id="wt_WebBlockInstance2" OnEvaluateParameters="webBlck_WebBlockInstance2_onDataBinding" InstanceID="_WebBlockInstance2"><phTitle><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance12" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance12_onDataBinding" InstanceID="_WebBlockInstance12"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# " Attach Document" %></osweb:PlaceHolder></phTitle><phContent><osweb:Container runat="server" id="wt_Container24" anonymous="true" onDataBinding="cnt_Container24_onDataBinding" GridCssClasses="OSInline" style="width: 300px"><osweb:Container runat="server" id="wt_Container20" anonymous="true" onDataBinding="cnt_Container20_onDataBinding"><osweb:InputFile runat="server" id="wtFileToUpload" GridCssClasses="ThemeGrid_Width4" name="wtFileToUpload" Visible="<%# inputFileFileToUpload_isVisible() %>" Disabled="<%# !inputFileFileToUpload_isEnabled() %>"/></osweb:Container><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If17() %>"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If32() %>"><osweb:Container runat="server" id="wt_Container36" anonymous="true" onDataBinding="cnt_Container36_onDataBinding"><osweb:Container runat="server" id="wt_Container11" anonymous="true" onDataBinding="cnt_Container11_onDataBinding"><osweb:PlaceHolder runat="server"><%# "Select users that will be allowed to view this file :" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container31" anonymous="true" onDataBinding="cnt_Container31_onDataBinding" GridCssClasses="OSAutoMarginTop"><osweb:DropDownList runat="server" id="wtSelectedUser" onDataBinding="selSelectedUser_onDataBinding" onAjaxChange="selSelectedUser_AjaxChange" style="width: 270px" Visible="<%# selSelectedUser_isVisible() %>" Enabled="<%# selSelectedUser_isEnabled() %>" OnSelectedIndexChanged="selSelectedUser_dropDown_valueChanged" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" Mandatory="<%# selSelectedUser_isMandatory() %>"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wtSelectedUserValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wtSelectedUser"/></osweb:Container><osweb:Container runat="server" id="wtSelectedUsers" onDataBinding="cntSelectedUsers_onDataBinding" GridCssClasses="OSAutoMarginTop"><osweb:Iterator runat="server" id="wtUserList2" onDataBinding="recListUserList2_onDataBinding" cssClass="ListRecords" OnItemCommand="recListUserList2_Select" OnSetViewStateStorage="recListUserList2_Store" OnClearViewStateStorage="recListUserList2_Clear" OnListRefreshDataBind="recListUserList2_ListRefreshDataBind" NeedsBreakAfter="true"><ItemTemplate><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression8()) %></osweb:PlaceHolder><osweb:LinkButton runat="server" id="wt_Link7" onDataBinding="lnk_Link7_onDataBinding" Visible="<%# lnk_Link7_isVisible() %>" Enabled="<%# lnk_Link7_isEnabled() %>" CausesValidation="false" title="<%# lnk_Link7_getTitle() %>" alt="<%# lnk_Link7_getTitle() %>"><osweb:PlaceHolder runat="server"><%# "Remove" %></osweb:PlaceHolder></osweb:LinkButton></ItemTemplate><InvisibleTemplate><%# recListUserList2_Store(Container.DataItem, Container.ItemIndex) %></InvisibleTemplate></osweb:Iterator></osweb:Container></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If32() %>"><osweb:Container runat="server" id="wt_Container19" anonymous="true" onDataBinding="cnt_Container19_onDataBinding"><osweb:Container runat="server" id="wt_Container27" anonymous="true" onDataBinding="cnt_Container27_onDataBinding"><osweb:PlaceHolder runat="server"><%# "Select roles  that will be allowed to view this file :" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container1" anonymous="true" onDataBinding="cnt_Container1_onDataBinding" GridCssClasses="OSAutoMarginTop"><osweb:DropDownList runat="server" id="wtSelectedRole" onDataBinding="selSelectedRole_onDataBinding" onAjaxChange="selSelectedRole_AjaxChange" style="width: 270px" Visible="<%# selSelectedRole_isVisible() %>" Enabled="<%# selSelectedRole_isEnabled() %>" OnSelectedIndexChanged="selSelectedRole_dropDown_valueChanged" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" Mandatory="<%# selSelectedRole_isMandatory() %>"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wtSelectedRoleValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wtSelectedRole"/></osweb:Container><osweb:Container runat="server" id="wtSelectedRoles" onDataBinding="cntSelectedRoles_onDataBinding" GridCssClasses="OSAutoMarginTop"><osweb:Iterator runat="server" id="wtRoleList2" onDataBinding="recListRoleList2_onDataBinding" cssClass="ListRecords" OnItemCommand="recListRoleList2_Select" OnSetViewStateStorage="recListRoleList2_Store" OnClearViewStateStorage="recListRoleList2_Clear" OnListRefreshDataBind="recListRoleList2_ListRefreshDataBind" NeedsBreakAfter="true"><ItemTemplate><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression15()) %></osweb:PlaceHolder><osweb:LinkButton runat="server" id="wt_Link18" onDataBinding="lnk_Link18_onDataBinding" Visible="<%# lnk_Link18_isVisible() %>" Enabled="<%# lnk_Link18_isEnabled() %>" CausesValidation="false" title="<%# lnk_Link18_getTitle() %>" alt="<%# lnk_Link18_getTitle() %>"><osweb:PlaceHolder runat="server"><%# "Remove" %></osweb:PlaceHolder></osweb:LinkButton></ItemTemplate><InvisibleTemplate><%# recListRoleList2_Store(Container.DataItem, Container.ItemIndex) %></InvisibleTemplate></osweb:Iterator></osweb:Container><osweb:Container runat="server" id="wtAllUsersWarning" onDataBinding="cntAllUsersWarning_onDataBinding" GridCssClasses="OSAutoMarginTop"><osweb:PlaceHolder runat="server"><%# "You have selected the CaseConferencingUser role, All staff will be able to view this file" %></osweb:PlaceHolder></osweb:Container></osweb:Container></osweb:If></osweb:IfPlaceHolder></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If17() %>"><osweb:Container runat="server" id="wt_Container33" anonymous="true" onDataBinding="cnt_Container33_onDataBinding" style="margin-top: 15px"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression3()) %></osweb:PlaceHolder></osweb:Container></osweb:If></osweb:IfPlaceHolder><osweb:Container runat="server" id="wt_Container40" anonymous="true" onDataBinding="cnt_Container40_onDataBinding" GridCssClasses="ThemeGrid_Width4" style="margin-left: 0px; margin-top: 10px" align="right"><osweb:Button runat="server" id="wt_Button22" cssClass="Button Is_Default" Visible="<%# btn_Button22_isVisible() %>" Enabled="<%# btn_Button22_isEnabled() %>" CausesValidation="false" text="<%# btn_Button22_getLabel() %>"/><osweb:Button runat="server" id="wt_Button30" cssClass="Button" GridCssClasses="ThemeGrid_MarginGutter" Visible="<%# btn_Button30_isVisible() %>" Enabled="<%# btn_Button30_isEnabled() %>" CausesValidation="false" text="<%# btn_Button30_getLabel() %>"/></osweb:Container></osweb:Container></phContent></widgets:KHtW7GNYBskijYiZHuvzUvw><osweb:DummySubmitLink runat="server" id="Dummy_Submit_Link"/>
    <%= OutSystems.HubEdition.RuntimePlatform.AppInfo.GetAppInfo().GetWatermark() %><%= GetCallbackDebug()	
%><%= GetVisitCode() %></osweb:Form><%= GetEndPageJavaScript() + GetBodyBottomJavaScript() %>
  </osweb:Body>
</html>