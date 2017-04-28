function RichWidgets_Input_SetFocus_init(widgetId)
{
  outsystems.internal.$(function($){
    var widget = document.getElementById(widgetId);
    if (widget == null)
    {
        try {
            window.OsHandleException(new Error("استخدام خاطئ لـ  RichWidgets\\Input_SetFocus: برجاء تحديد the runtime Id property of an Input or Input Password widget."), outsystems.osErrorCodes.SystemJavascriptError, 'Input_SetFocus');
        } catch(e) {}
        return;
    }
    if (widget.tagName != "INPUT" && widget.tagName != "TEXTAREA")
    {
        try {
            window.OsHandleException(new Error("استخدام خاطئ لـ  RichWidgets\\Input_SetFocus: فقط يمكن استخدام  Input and Input Password widgets"), outsystems.osErrorCodes.SystemJavascriptError, 'Input_SetFocus');
        } catch(e) {}
        return;
    }
    widget.focus();
    widget = null;
  });
}