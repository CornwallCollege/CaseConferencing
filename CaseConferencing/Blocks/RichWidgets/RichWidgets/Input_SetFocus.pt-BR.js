function RichWidgets_Input_SetFocus_init(widgetId)
{
  outsystems.internal.$(function($){
    var widget = document.getElementById(widgetId);
    if (widget == null)
    {
        try {
            window.OsHandleException(new Error("Uso inválido do RichWidgets\\Input_SetFocus: Por favor especifique o Id de um widget Input ou Input Password."), outsystems.osErrorCodes.SystemJavascriptError, 'Input_SetFocus');
        } catch(e) {}
        return;
    }
    if (widget.tagName != "INPUT" && widget.tagName != "TEXTAREA")
    {
        try {
            window.OsHandleException(new Error("Uso inválido do RichWidgets\\Input_SetFocus: Somente widgets de Input e Input Password são suportadas."), outsystems.osErrorCodes.SystemJavascriptError, 'Input_SetFocus');
        } catch(e) {}
        return;
    }
    widget.focus();
    widget = null;
  });
}