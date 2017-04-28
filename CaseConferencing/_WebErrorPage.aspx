<%@ Import namespace="System.Net" %>
<%@ Import namespace="OutSystems.HubEdition.RuntimePlatform.Log" %>
<%@ Import namespace="OutSystems.HubEdition.RuntimePlatform.Db" %>
<%@ Import namespace="OutSystems.Internal.Db" %>
<%@ Import namespace="OutSystems.HubEdition.RuntimePlatform" %>
<%@ Assembly Name="OutSystems.HubEdition.WebWidgets" %>
<%@ Import namespace="OutSystems.HubEdition.WebWidgets" %>
<%@ Page language="c#" AutoEventWireup="true" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Error</title>
		<script runat="server" language="C#">
HeContext heContext;
Exception excep;
bool ajaxRedirected;

protected override void Render(HtmlTextWriter writer) {
    // skip rendering for ajax redirected errors
    if (!ajaxRedirected)
        base.Render(writer);
}        

private void Page_Load(object sender, System.EventArgs e){
	AppInfo App = AppInfo.GetAppInfo();
    bool isAjaxRequest = false;
	if( App != null) {
		heContext = App.OsContext;
        if (heContext != null) {
            isAjaxRequest = heContext.IsAjaxRequest;
        }
	}
    if (!isAjaxRequest) {
        Response.StatusCode = 500;
	}
    
	excep = Server.GetLastError();
	if (excep == null) excep = (Exception)Application["ApplicationStartError"];
	ErrorLog.LogApplicationError(excep, heContext, "Global");

    // show placeholders
    AJAXPlaceHolder.Visible = false;
    RestartSessionPlaceHolder.Visible = false;
    RewriteUrlPlaceHolder.Visible = false;
    if (heContext != null && heContext.Session.EntryPoint != null && heContext.Session.EntryPoint != HeContext.UnknownEntryPoint && heContext.IsAjaxRequest) {
        AJAXPlaceHolder.Visible = true;
        RestartSessionLinkAJAX.NavigateUrl = heContext.Session.EntryPoint;
    } else if (heContext != null && heContext.Session.EntryPoint != null && heContext.Session.EntryPoint != HeContext.UnknownEntryPoint) {
		RestartSessionPlaceHolder.Visible = true;
		RestartSessionLink.NavigateUrl = heContext.Session.EntryPoint;
	} else {        
        RewriteUrlPlaceHolder.Visible = true;
	}	
	
	if (heContext != null && heContext.AppInfo != null && !heContext.AppInfo.Properties.RemoteShowStack){
		bool isLocal=false;
		if(NetworkInterfaceUtils.IsLoopbackAddress(heContext.Context.Request.UserHostAddress)) {
			isLocal=true;
		} else {
			IPHostEntry hostInfo = Dns.GetHostEntry(Dns.GetHostName());
			
			for(int index=0; index < hostInfo.AddressList.Length; index++) 
				if(heContext.Context.Request.UserHostAddress == hostInfo.AddressList[index].ToString()){
					isLocal=true;
					break;
				}
		}
		if(!isLocal) {
			heContext.Context.Response.BufferOutput = true;
            string url = OutSystems.HubEdition.RuntimePlatform.Settings.Get(OutSystems.HubEdition.RuntimePlatform.Settings.Configs.DefaultErrorPage);
            if (heContext.IsAjaxRequest) {
                // AJAX Redirect...
                if (url != null && url != "") {
                    OSPageViewState.WriteAJAXClientRedirectResponse(heContext.Context.Request, heContext.Context.Response, url, "CaseConferencing");
                } else {
                    OSPageViewState.WriteAJAXClientRedirectResponse(heContext.Context.Request, heContext.Context.Response, "/customHandlers/internalerror.aspx", "CaseConferencing");
                }
                ajaxRedirected = true;
            } else {
                // Submit redirect...
                if (url != null && url != "") {
                    heContext.Context.Response.Redirect(url);
                } else {
                    heContext.Context.Response.Redirect("/customHandlers/internalerror.aspx");
                }
            }
                
		}
	}
}

private void Page_Unload(object sender, System.EventArgs e){
	if( heContext != null) {
		DatabaseAccess.FreeupResources(true);
	}
}

private string GetMessages (Exception excep) {
	ArrayList exceptions = new ArrayList();
	while (excep != null) {
		exceptions.Add (excep);
		excep = excep.InnerException;
	}
	string message = "";
	for (int i = exceptions.Count; i > 0; i--) {
		excep = (Exception)exceptions[i-1];
		message += "<b>" + excep.Message + "</b><br>";
		message += excep.StackTrace + "<br>";
	}
	return message;
}

</script>

		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<META NAME="ROBOTS" CONTENT="NOINDEX"/>
		<style type="text/css">
			.NormalText { FONT-SIZE: 10pt; FONT-FAMILY: Arial, Helvetica, sans-serif }
			.ErrorMessage { FONT-WEIGHT: bold; FONT-SIZE: 10pt; COLOR: #ff3333; FONT-FAMILY: Arial, Helvetica, sans-serif }
			.DetailButton { BORDER-RIGHT: #999999 1px solid; BORDER-TOP: #ffffff 1px solid; FONT-SIZE: 8pt; BORDER-LEFT: #ffffff 1px solid; BORDER-BOTTOM: #999999 1px solid; FONT-FAMILY: Arial, Helvetica, sans-serif }
			.DetailLayer { BACKGROUND-COLOR: #dddddd }
		</style>
		<script type="text/javascript">
function ToggleDetail () {
    var form1 = document.getElementById("form1");
    var DetailLayer = document.getElementById("DetailLayer");
    
	if (form1.ShowDetailButton.value == "Show Detail") {
		form1.ShowDetailButton.value = "Hide Detail";
		DetailLayer.style.display = "block";
	} else {
		form1.ShowDetailButton.value = "Show Detail";
		DetailLayer.style.display = "none";
	}
}
		</script>
	</HEAD>
	<body>
		<p class="NormalText">There was an error processing your request:</p>
		<p class="ErrorMessage"><%= excep.Message.Replace ("\n","</br>") %>		</p>
		<form id="form1">
			<input type="button" name="ShowDetailButton" value="Show Detail" class="DetailButton" style="WIDTH: 80px" onclick="ToggleDetail()">
		</form>
		<div id="DetailLayer" class="DetailLayer" style="DISPLAY:none"><pre><%= GetMessages(excep) %></pre>
		</div>
		<p class="NormalText">
			<asp:PlaceHolder id="AJAXPlaceHolder" runat="server">
				Please click <a href="javascript:history.go(0)">refresh</a> on your browser and try again or, if the error persists, please <asp:HyperLink id="RestartSessionLinkAJAX" runat="server">restart your session</asp:HyperLink>.
			</asp:PlaceHolder>
			<asp:PlaceHolder id="RestartSessionPlaceHolder" runat="server">
				Please click <a href="javascript:history.back()">back</a> on your browser and try again or, if the error persists, please <asp:HyperLink id="RestartSessionLink" runat="server">restart your session</asp:HyperLink>.
			</asp:PlaceHolder>
			<asp:PlaceHolder id="RewriteUrlPlaceHolder" runat="server">
				Please rewrite the application URL.
			</asp:PlaceHolder>
		</p>
	</body>
</HTML>
