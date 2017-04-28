function RichWidgets_Input_SetFocus_init(widgetId)
{
  outsystems.internal.$(function($){
    var widget = document.getElementById(widgetId);
    if (widget == null)
    {
        try {
            window.OsHandleException(new Error("Invalid use of RichWidgets\\Input_SetFocus: Please specify the runtime Id property of an Input or Input Password widget."), outsystems.osErrorCodes.SystemJavascriptError, 'Input_SetFocus');
        } catch(e) {}
        return;
    }
    if (widget.tagName != "INPUT" && widget.tagName != "TEXTAREA")
    {
        try {
            window.OsHandleException(new Error("Invalid use of RichWidgets\\Input_SetFocus: Only Input and Input Password widgets are supported."), outsystems.osErrorCodes.SystemJavascriptError, 'Input_SetFocus');
        } catch(e) {}
        return;
    }
    widget.focus();
    widget = null;
  });
}