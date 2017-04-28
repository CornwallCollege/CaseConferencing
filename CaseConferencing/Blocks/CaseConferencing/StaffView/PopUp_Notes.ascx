﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\CaseConferencing\StaffView\PopUp_Notes.ascx.cs" Inherits="ssCaseConferencing.Flows.FlowStaffView.WBlkPopUp_Notes,CaseConferencing" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssCaseConferencing" %>
<%@ Register TagPrefix="widgets" TagName="K1TCjPag3Q064wEzBpWXkyg" Src="..\..\CaseConferencing\Common\PopUp.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="..\..\CaseConferencing\RichWidgets\Icon.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="Kbbzz9S_an_V_uoCTOfsBiA" Src="..\..\CaseConferencing\RichWidgets\Popup_Editor.ascx" %><%@ Register TagPrefix="widgets" TagName="K1tHu2scNhke0DPtNY_WdAQ" Src="..\..\CaseConferencing\Common\DateFormatted.ascx" %><%@ Register TagPrefix="Hunspell_widgets" TagName="K0Zl4goFGNE2SN5MU27Ivpw" Src="..\..\CaseConferencing\HunSpell\SpellcheckerLink.ascx" %><%@ Register TagPrefix="widgets" TagName="KG6f0u0SrOUGX6qeUC7FwaA" Src="..\..\CaseConferencing\AutoComplete_Bank\AutoComplete_Icon.ascx" %><%# PageStartHook() %><widgets:K1TCjPag3Q064wEzBpWXkyg runat="server" id="wtPopUpNote" OnEvaluateParameters="webBlckPopUpNote_onDataBinding" InstanceID="PopUpNote" IncludeSpan="true"><phPopupContent><osweb:Container runat="server" id="wtTabWrapper" onDataBinding="cntTabWrapper_onDataBinding"><osweb:Container runat="server" id="wt_Container33" anonymous="true" onDataBinding="cnt_Container33_onDataBinding" onAjaxClick="cnt_Container33_AjaxClick" cssClass="TabEnabled" align="left"><osweb:Table runat="server" id="wt_Table16" anonymous="true" onDataBinding="wt_Table16_onDataBinding" GridCssClasses="OSFillParent"><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_TableCell7" anonymous="true"><osweb:Container runat="server" id="wt_Container14" anonymous="true" onDataBinding="cnt_Container14_onDataBinding" align="center"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance44" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance44_onDataBinding" InstanceID="_WebBlockInstance44"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression81()) %></osweb:PlaceHolder></osweb:Container></osweb:Td></osweb:Tr></osweb:Table></osweb:Container><osweb:Container runat="server" id="wt_Container49" anonymous="true" onDataBinding="cnt_Container49_onDataBinding" onAjaxClick="cnt_Container49_AjaxClick" cssClass="TabDisabled" align="left"><osweb:Table runat="server" id="wt_Table50" anonymous="true" onDataBinding="wt_Table50_onDataBinding" GridCssClasses="OSFillParent"><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_TableCell67" anonymous="true"><osweb:Container runat="server" id="wt_Container65" anonymous="true" onDataBinding="cnt_Container65_onDataBinding" align="center"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance52" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance52_onDataBinding" InstanceID="_WebBlockInstance52"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression73()) %></osweb:PlaceHolder></osweb:Container></osweb:Td></osweb:Tr></osweb:Table></osweb:Container></osweb:Container><osweb:Container runat="server" id="wtWrapperContent" onDataBinding="cntWrapperContent_onDataBinding" cssClass="PopupTab_Content"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If57() %>"><osweb:Container runat="server" id="wtHistory" onDataBinding="cntHistory_onDataBinding"><osweb:Container runat="server" id="wtCurrentRAG2" onDataBinding="cntCurrentRAG2_onDataBinding"><osweb:Iterator runat="server" id="wtRAGLastChanges_List" onDataBinding="recListRAGLastChanges_List_onDataBinding" cssClass="ListRecords" OnItemCommand="recListRAGLastChanges_List_Select" OnSetViewStateStorage="recListRAGLastChanges_List_Store" OnClearViewStateStorage="recListRAGLastChanges_List_Clear" OnListRefreshDataBind="recListRAGLastChanges_List_ListRefreshDataBind" IsAjaxRefreshed="true"><ItemTemplate><osweb:Container runat="server" id="wtWrapperList" onDataBinding="cntWrapperList_onDataBinding" GridCssClasses="OSInline" style="width: 440px"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If71() %>"><osweb:Container runat="server" id="wtCurrentRAGSTatus2" onDataBinding="cntCurrentRAGSTatus2_onDataBinding" GridCssClasses="OSInline"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance26" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance26_onDataBinding" InstanceID="_WebBlockInstance26"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:LinkButton runat="server" id="wtDeleteNote" onDataBinding="lnkDeleteNote_onDataBinding" Visible="<%# lnkDeleteNote_isVisible() %>" Enabled="<%# lnkDeleteNote_isEnabled() %>" CausesValidation="false"><osweb:Container runat="server" id="wt_Container46" anonymous="true" onDataBinding="cnt_Container46_onDataBinding" style="margin-top: 30px"><RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA runat="server" id="RichWidgets_wt_WebBlockInstance55" onAjaxNotify="RichWidgets_webBlck_WebBlockInstance55_AjaxNotify" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance55_onDataBinding" InstanceID="_WebBlockInstance55"></RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance10" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance10_onDataBinding" InstanceID="_WebBlockInstance10"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w></osweb:Container></osweb:LinkButton></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If71() %>"></osweb:If></osweb:IfPlaceHolder><osweb:Container runat="server" id="wtDescriptionWrapper2" onDataBinding="cntDescriptionWrapper2_onDataBinding"><osweb:Table runat="server" id="wt_Table4" anonymous="true" onDataBinding="wt_Table4_onDataBinding" GridCssClasses="OSFillParent"><osweb:Tr runat="server" onDataBinding="wt_TableRow32_onDataBinding"><osweb:Td runat="server" id="wt_TableCell60" anonymous="true" onDataBinding="wt_TableCell60_onDataBinding"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression36()) %></osweb:PlaceHolder></osweb:Td></osweb:Tr></osweb:Table></osweb:Container><osweb:Container runat="server" id="wt_Container76" anonymous="true" onDataBinding="cnt_Container76_onDataBinding"><osweb:PlaceHolder runat="server"><%# "by  " %></osweb:PlaceHolder><osweb:Span runat="server" id="wt_InlineExpression20" anonymous="true" class="Bold"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression20()) %></osweb:Span><osweb:PlaceHolder runat="server"><%# " on " %></osweb:PlaceHolder><osweb:Container runat="server" id="wt_Container39" anonymous="true" onDataBinding="cnt_Container39_onDataBinding" GridCssClasses="OSInline"><widgets:K1tHu2scNhke0DPtNY_WdAQ runat="server" id="wt_WebBlockInstance31" OnEvaluateParameters="webBlck_WebBlockInstance31_onDataBinding" InstanceID="_WebBlockInstance31"></widgets:K1tHu2scNhke0DPtNY_WdAQ></osweb:Container><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If69() %>"><osweb:Container runat="server" id="wt_Container25" anonymous="true" onDataBinding="cnt_Container25_onDataBinding" GridCssClasses="OSInline"><osweb:LinkButton runat="server" id="wt_Link77" Visible="<%# lnk_Link77_isVisible() %>" Enabled="<%# lnk_Link77_isEnabled() %>" CausesValidation="false"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression62()) %></osweb:PlaceHolder></osweb:LinkButton></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If69() %>"></osweb:If></osweb:IfPlaceHolder></osweb:Container></osweb:Container></ItemTemplate><InvisibleTemplate><%# recListRAGLastChanges_List_Store(Container.DataItem, Container.ItemIndex) %></InvisibleTemplate></osweb:Iterator></osweb:Container></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If57() %>"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If63() %>"><osweb:Container runat="server" id="wtEditContent" onDataBinding="cntEditContent_onDataBinding"><osweb:Container runat="server" id="wtOverview2" onDataBinding="cntOverview2_onDataBinding" GridCssClasses="OSInline"><osweb:Container runat="server" id="wtDescription" onDataBinding="cntDescription_onDataBinding" cssClass="LabelTitle" GridCssClasses="OSInline"><osweb:Span runat="server" id="wt_Text53" anonymous="true" onDataBinding="wt_Text53_onDataBinding"><%# "Description" %></osweb:Span></osweb:Container><osweb:Container runat="server" id="wt_Container74" anonymous="true" onDataBinding="cnt_Container74_onDataBinding" GridCssClasses="OSInline"><osweb:IfPlaceHolder runat="server"><osweb:If runat="server" visible="<%# if_wt_If17() %>"><osweb:Container runat="server" id="wt_Container19" anonymous="true" onDataBinding="cnt_Container19_onDataBinding" GridCssClasses="OSInline" align="left"><osweb:HyperLink runat="server" id="wtlnkAtt" Visible="<%# lnklnkAtt_isVisible() %>" Enabled="<%# lnklnkAtt_isEnabled() %>" NavigateUrl="<%# lnklnkAtt_NavigateUrl() %>"><osweb:PlaceHolder runat="server"><%# "Add Document " %></osweb:PlaceHolder></osweb:HyperLink><RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA runat="server" id="RichWidgets_wt_WebBlockInstance38" onAjaxNotify="RichWidgets_webBlck_WebBlockInstance38_AjaxNotify" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance38_onDataBinding" InstanceID="_WebBlockInstance38"></RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If17() %>"><osweb:Container runat="server" id="wt_Container45" anonymous="true" onDataBinding="cnt_Container45_onDataBinding" GridCssClasses="OSInline"></osweb:Container><osweb:LinkButton runat="server" id="wt_Link27" Visible="<%# lnk_Link27_isVisible() %>" Enabled="<%# lnk_Link27_isEnabled() %>" CausesValidation="false"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression72()) %></osweb:PlaceHolder></osweb:LinkButton></osweb:If></osweb:IfPlaceHolder></osweb:Container><osweb:Container runat="server" id="wtResponsible2" onDataBinding="cntResponsible2_onDataBinding"><osweb:Container runat="server" id="wt_Container68" anonymous="true" onDataBinding="cnt_Container68_onDataBinding" GridCssClasses="OSInline"><osweb:TextBox runat="server" id="wtNoteDescription" onDataBinding="inputwtNoteDescription_onDataBinding" style="width: 400px" Visible="<%# inputwtNoteDescription_isVisible() %>" ReadOnly="<%# !inputwtNoteDescription_isEnabled() %>" maxlength="500" onchange="OsLimitInput(this,event,500);" onkeyup="OsLimitInput(this,event,500);" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" OnDefaultTypeValidationMessage="GetTextValidatorMsg" textmode="MultiLine" rows="5" text="<%# inputwtNoteDescription_input_value() %>" onTextChanged="inputwtNoteDescription_input_onTextChanged" Mandatory="<%# inputwtNoteDescription_isMandatory() %>"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wtNoteDescriptionValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wtNoteDescription"/><osweb:TextValidator runat="server" display="Dynamic" id="wtNoteDescriptionValidatorType" ErrorMessage="<%# CaseConferencing_Properties.TextValidatorMsg %>" ControlToValidate="wtNoteDescription" ClientValidationFunction="OsCustomValidatorText"/></osweb:Container><osweb:Container runat="server" id="wt_Container41" anonymous="true" onDataBinding="cnt_Container41_onDataBinding" style="margin-top: 5px" align="left"><osweb:Table runat="server" id="wt_Table18" anonymous="true" GridCssClasses="OSFillParent"><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_TableCell58" anonymous="true"><osweb:Container runat="server" id="wt_Container83" anonymous="true" onDataBinding="cnt_Container83_onDataBinding" GridCssClasses="OSInline" align="left"><Hunspell_widgets:K0Zl4goFGNE2SN5MU27Ivpw runat="server" id="Hunspell_wt_WebBlockInstance23" OnEvaluateParameters="Hunspell_webBlck_WebBlockInstance23_onDataBinding" InstanceID="_WebBlockInstance23"></Hunspell_widgets:K0Zl4goFGNE2SN5MU27Ivpw></osweb:Container><osweb:Container runat="server" id="wt_Container24" anonymous="true" onDataBinding="cnt_Container24_onDataBinding" GridCssClasses="OSInline" style="margin-left: 10px"><widgets:KG6f0u0SrOUGX6qeUC7FwaA runat="server" id="wt_WebBlockInstance48" OnEvaluateParameters="webBlck_WebBlockInstance48_onDataBinding" InstanceID="_WebBlockInstance48"></widgets:KG6f0u0SrOUGX6qeUC7FwaA></osweb:Container></osweb:Td><osweb:Td runat="server" id="wt_TableCell61" anonymous="true"><osweb:Container runat="server" id="wt_Container11" anonymous="true" onDataBinding="cnt_Container11_onDataBinding" align="right"><osweb:Container runat="server" id="wt_Container47" anonymous="true" onDataBinding="cnt_Container47_onDataBinding" onAjaxClick="cnt_Container47_AjaxClick" cssClass="HeaderButton" GridCssClasses="OSInline" align="right"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance56" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance56_onDataBinding" InstanceID="_WebBlockInstance56"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><osweb:PlaceHolder runat="server"><%# " New Note" %></osweb:PlaceHolder></osweb:Container></osweb:Container></osweb:Td></osweb:Tr></osweb:Table></osweb:Container></osweb:Container><osweb:EditRecord runat="server" id="wtNotesEdit" onDataBinding="wtNotesEdit_onDataBinding" class="EditRecord" GridCssClasses="OSFillParent" border="0"></osweb:EditRecord></osweb:Container></osweb:Container></osweb:If><osweb:If runat="server" visible="<%# !if_wt_If63() %>"></osweb:If></osweb:IfPlaceHolder></osweb:If></osweb:IfPlaceHolder></osweb:Container></phPopupContent></widgets:K1TCjPag3Q064wEzBpWXkyg><%# PageEndHook() %>