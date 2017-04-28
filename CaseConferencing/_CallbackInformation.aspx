<%@ Page EnableSessionState="False" language="c#" AutoEventWireup="false" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
	<head>
		<title>Callback Debug Information</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</head>
	<body>
<%= 
	(Request.HttpMethod =="GET" && Request.QueryString ["__CALLBACK_DEBUG" ] != null && Request.QueryString ["__CALLBACK_DEBUG" ] != "" ? 
		(Request.QueryString ["__CALLBACK_DEBUG" ] == OutSystems.HubEdition.RuntimePlatform.AppInfo.GetParameter( OutSystems.HubEdition.RuntimePlatform.Settings.Configs.Callback_Debug_Information_Key) ?
			OutSystems.HubEdition.RuntimePlatform.AppInfo.GetAppInfo().GetCallbackDebugInformation() :
			"")
		: "")
%>		
	</body>
</html>
