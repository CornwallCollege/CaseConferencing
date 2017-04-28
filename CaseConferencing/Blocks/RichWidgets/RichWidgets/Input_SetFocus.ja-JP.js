function RichWidgets_Input_SetFocus_init(widgetId)
{
  outsystems.internal.$(function($){
    var widget = document.getElementById(widgetId);
    if (widget == null)
    {
        try {
            window.OsHandleException(new Error("RichWidgetsが無効です - Input_SetFocus：InputウィジェットまたはInputパスワードウィジェットのRuntime Id を指定してください。"), outsystems.osErrorCodes.SystemJavascriptError, 'Input_SetFocus');
        } catch(e) {}
        return;
    }
    if (widget.tagName != "INPUT" && widget.tagName != "TEXTAREA")
    {
        try {
            window.OsHandleException(new Error("RichWidgetsが無効です - Input_SetFocus：Inputウィジェット及びInputパスワードウィジェットのみサポートされています。"), outsystems.osErrorCodes.SystemJavascriptError, 'Input_SetFocus');
        } catch(e) {}
        return;
    }
    widget.focus();
    widget = null;
  });
}