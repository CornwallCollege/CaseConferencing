var RichWidgets_Feedback_AjaxWait_ajaxWaitMessageTimer;
var RichWidgets_Feedback_AjaxWait_Timeout = 200;

function RichWidgets_Feedback_AjaxWait_init(divId) {
 outsystems.internal.$(function($) {
  osAjaxBackend.BindBeforeAjaxRequest(function(){
    if(RichWidgets_Feedback_AjaxWait_ajaxWaitMessageTimer == null) {
       RichWidgets_Feedback_AjaxWait_ajaxWaitMessageTimer = setTimeout(function () { 
            $('#' + divId).fadeIn(); 
            $('body').addClass('Feedback_AjaxWait_CursorProgress');
        } , RichWidgets_Feedback_AjaxWait_Timeout);
      window.OsOnBeforeChange = function(){
       clearTimeout(RichWidgets_Feedback_AjaxWait_ajaxWaitMessageTimer);
       RichWidgets_Feedback_AjaxWait_ajaxWaitMessageTimer = null;
       $('body').removeClass('Feedback_AjaxWait_CursorProgress');
       $('#' + divId ).fadeOut();
      };
      $(window).unload(function() {
       window.OsOnBeforeChange = null;
      });
      osAjaxBackend.BindAfterAjaxRequest(function(){window.OsOnBeforeChange();});        
    }
  });
 });
}