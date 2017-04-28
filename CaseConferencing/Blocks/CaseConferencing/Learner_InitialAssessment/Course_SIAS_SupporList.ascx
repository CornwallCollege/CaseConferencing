﻿<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Blocks\CaseConferencing\Learner_InitialAssessment\Course_SIAS_SupporList.ascx.cs" Inherits="ssCaseConferencing.Flows.FlowLearner_InitialAssessment.WBlkCourse_SIAS_SupporList,CaseConferencing" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Register TagPrefix="osweb" Namespace="OutSystems.HubEdition.WebWidgets" Assembly="OutSystems.HubEdition.WebWidgets" %>
<%@ Assembly Name="OutSystems.WidgetsRuntimeAPI" %>
<%@ Import namespace="ssCaseConferencing" %>
<%@ Register TagPrefix="widgets" TagName="K3a_seLuKMUGpybWl0tw61g" Src="Course_SIAS_SupportItems_Edit.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="KmbfKJ2gWQUq1Gwk_0SjV4w" Src="..\..\CaseConferencing\RichWidgets\Icon.ascx" %><%@ Register TagPrefix="RichWidgets_widgets" TagName="Kbbzz9S_an_V_uoCTOfsBiA" Src="..\..\CaseConferencing\RichWidgets\Popup_Editor.ascx" %><%# PageStartHook() %><osweb:Container runat="server" id="wtLearnerListWrapper" onDataBinding="cntLearnerListWrapper_onDataBinding" GridCssClasses="OSInline" style="width: 550px; margin-left: 0px" align="left"><osweb:Container runat="server" id="wt_Container24" anonymous="true" onDataBinding="cnt_Container24_onDataBinding" cssClass="ListHeader" GridCssClasses="OSInline" style="width: 1005px" align="left"><osweb:Container runat="server" id="wt_Container26" anonymous="true" onDataBinding="cnt_Container26_onDataBinding" cssClass="ListHeaderTitle" GridCssClasses="OSInline" style="width: 195px" align="center"><osweb:PlaceHolder runat="server"><%# "Learner" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container23" anonymous="true" onDataBinding="cnt_Container23_onDataBinding" cssClass="ListHeaderTitle" GridCssClasses="OSInline" style="width: 380px; margin-left: 0px" align="center"><osweb:PlaceHolder runat="server"><%# "Support" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container6" anonymous="true" onDataBinding="cnt_Container6_onDataBinding" cssClass="ListHeaderTitle" GridCssClasses="OSInline" style="width: 180px; margin-left: 0px" align="center"><osweb:PlaceHolder runat="server"><%# " Exam Concessions" %></osweb:PlaceHolder></osweb:Container><osweb:Container runat="server" id="wt_Container30" anonymous="true" onDataBinding="cnt_Container30_onDataBinding" GridCssClasses="OSInline" style="width: 180px; margin-left: 0px" align="center"><osweb:PlaceHolder runat="server"><%# "Notes" %></osweb:PlaceHolder></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container31" anonymous="true" onDataBinding="cnt_Container31_onDataBinding" style="margin-top: 0px"><osweb:Iterator runat="server" id="wtLearnerList" onDataBinding="recListLearnerList_onDataBinding" cssClass="ListRecords" OnItemCommand="recListLearnerList_Select" OnSetViewStateStorage="recListLearnerList_Store" OnClearViewStateStorage="recListLearnerList_Clear" OnListRefreshDataBind="recListLearnerList_ListRefreshDataBind" IsAjaxRefreshed="true" NeedsBreakAfter="true"><ItemTemplate><osweb:Container runat="server" id="wt_Container1" anonymous="true" onDataBinding="cnt_Container1_onDataBinding" cssClass="LearnerListLine" GridCssClasses="OSInline" style="width: 1000px; margin-top: 0px"><osweb:Container runat="server" id="wt_Container12" anonymous="true" onDataBinding="cnt_Container12_onDataBinding"><osweb:Container runat="server" id="wt_Container41" anonymous="true" onDataBinding="cnt_Container41_onDataBinding" GridCssClasses="OSInline" style="width: 75px" align="center"><osweb:DynamicImage runat="server" id="wt_Image28" anonymous="true" onDataBinding="img_Image28_onDataBinding" cssClass="StudentPhoto SilverBorder" Source="<%# img_Image28_getURL() %>" ImageType="External" alt=""/></osweb:Container><osweb:Container runat="server" id="wt_Container2" anonymous="true" onDataBinding="cnt_Container2_onDataBinding" GridCssClasses="ThemeGrid_Width2" style="margin-left: 0px" align="left"><osweb:Container runat="server" id="wt_Container5" anonymous="true" onDataBinding="cnt_Container5_onDataBinding"><osweb:HyperLink runat="server" id="wt_Link38" Visible="<%# lnk_Link38_isVisible() %>" Enabled="<%# lnk_Link38_isEnabled() %>" NavigateUrl="<%# lnk_Link38_NavigateUrl() %>"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression10()) %></osweb:PlaceHolder></osweb:HyperLink></osweb:Container></osweb:Container><osweb:Container runat="server" id="wt_Container22" anonymous="true" onDataBinding="cnt_Container22_onDataBinding" GridCssClasses="OSInline" style="width: 390px; margin-left: 20px" align="center"><osweb:Table runat="server" id="wt_Table29" anonymous="true" GridCssClasses="OSFillParent" style="height: 65px"><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_TableCell44" anonymous="true" onDataBinding="wt_TableCell44_onDataBinding"><osweb:Container runat="server" id="wt_Container33" anonymous="true" onDataBinding="cnt_Container33_onDataBinding" align="left"><osweb:Container runat="server" id="wt_Container16" anonymous="true" onDataBinding="cnt_Container16_onDataBinding" GridCssClasses="OSInline" style="width: 120px" align="left"><osweb:DropDownList runat="server" id="wt_ComboBox34" onDataBinding="sel_ComboBox34_onDataBinding" onAjaxChange="sel_ComboBox34_AjaxChange" style="width: 100px" Visible="<%# sel_ComboBox34_isVisible() %>" Enabled="<%# sel_ComboBox34_isEnabled() %>" OnSelectedIndexChanged="sel_ComboBox34_dropDown_valueChanged" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" Mandatory="<%# sel_ComboBox34_isMandatory() %>"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wt_ComboBox34ValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wt_ComboBox34"/></osweb:Container><osweb:Container runat="server" id="wt_Container19" anonymous="true" onDataBinding="cnt_Container19_onDataBinding" GridCssClasses="OSInline ThemeGrid_MarginGutter" style="width: 210px"><widgets:K3a_seLuKMUGpybWl0tw61g runat="server" id="wt_WebBlockInstance9" onAjaxNotify="webBlck_WebBlockInstance9_AjaxNotify" OnEvaluateParameters="webBlck_WebBlockInstance9_onDataBinding" InstanceID="_WebBlockInstance9"></widgets:K3a_seLuKMUGpybWl0tw61g></osweb:Container></osweb:Container></osweb:Td></osweb:Tr></osweb:Table></osweb:Container><osweb:Container runat="server" id="wt_Container35" anonymous="true" onDataBinding="cnt_Container35_onDataBinding" GridCssClasses="OSInline" style="width: 180px; margin-left: 0px"><osweb:Table runat="server" id="wt_Table40" anonymous="true" GridCssClasses="OSFillParent" style="height: 65px"><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_TableCell43" anonymous="true" onDataBinding="wt_TableCell43_onDataBinding"><osweb:Container runat="server" id="wt_Container14" anonymous="true" onDataBinding="cnt_Container14_onDataBinding" GridCssClasses="OSInline" style="width: 170px"><osweb:DropDownList runat="server" id="wt_ComboBox27" onDataBinding="sel_ComboBox27_onDataBinding" onAjaxChange="sel_ComboBox27_AjaxChange" style="width: 155px" Visible="<%# sel_ComboBox27_isVisible() %>" Enabled="<%# sel_ComboBox27_isEnabled() %>" OnSelectedIndexChanged="sel_ComboBox27_dropDown_valueChanged" OnDefaultMandatoryValidationMessage="GetMandatoryValidatorMsg" Mandatory="<%# sel_ComboBox27_isMandatory() %>"/><osweb:RequiredFieldTextValidator  runat="server" display="Dynamic" id="wt_ComboBox27ValidatorRequired" ErrorMessage="<%# CaseConferencing_Properties.MandatoryValidatorMsg %>" ControlToValidate="wt_ComboBox27"/></osweb:Container></osweb:Td></osweb:Tr></osweb:Table></osweb:Container><osweb:Container runat="server" id="wt_Container39" anonymous="true" onDataBinding="cnt_Container39_onDataBinding" GridCssClasses="OSInline" style="width: 180px; margin-left: 10px" align="left"><osweb:Table runat="server" id="wt_Table7" anonymous="true" onDataBinding="wt_Table7_onDataBinding" GridCssClasses="OSInline" style="width: 100%; height: 65px"><osweb:Tr runat="server"><osweb:Td runat="server" id="wt_TableCell21" anonymous="true" onDataBinding="wt_TableCell21_onDataBinding"><osweb:Container runat="server" id="wt_Container8" anonymous="true" onDataBinding="cnt_Container8_onDataBinding" align="left"><osweb:PlaceHolder runat="server"><%# OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.ExtendedHtmlEncode(expression_InlineExpression4()) %></osweb:PlaceHolder><osweb:HyperLink runat="server" id="wtPopupNotesLnk" onDataBinding="lnkPopupNotesLnk_onDataBinding" Visible="<%# lnkPopupNotesLnk_isVisible() %>" Enabled="<%# lnkPopupNotesLnk_isEnabled() %>" NavigateUrl="<%# lnkPopupNotesLnk_NavigateUrl() %>"><osweb:Container runat="server" id="wt_Container45" anonymous="true" onDataBinding="cnt_Container45_onDataBinding" GridCssClasses="OSInline"><RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w runat="server" id="RichWidgets_wt_WebBlockInstance46" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance46_onDataBinding" InstanceID="_WebBlockInstance46"></RichWidgets_widgets:KmbfKJ2gWQUq1Gwk_0SjV4w><RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA runat="server" id="RichWidgets_wt_WebBlockInstance3" onAjaxNotify="RichWidgets_webBlck_WebBlockInstance3_AjaxNotify" OnEvaluateParameters="RichWidgets_webBlck_WebBlockInstance3_onDataBinding" InstanceID="_WebBlockInstance3"></RichWidgets_widgets:Kbbzz9S_an_V_uoCTOfsBiA></osweb:Container></osweb:HyperLink></osweb:Container></osweb:Td></osweb:Tr></osweb:Table></osweb:Container></osweb:Container></osweb:Container></ItemTemplate><InvisibleTemplate><%# recListLearnerList_Store(Container.DataItem, Container.ItemIndex) %></InvisibleTemplate></osweb:Iterator></osweb:Container><osweb:Container runat="server" id="wt_Container36" anonymous="true" onDataBinding="cnt_Container36_onDataBinding" style="margin-top: 0px" align="right"></osweb:Container></osweb:Container><%# PageEndHook() %>