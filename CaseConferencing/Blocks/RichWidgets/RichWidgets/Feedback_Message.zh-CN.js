var RichWidgets_Feedback_Message_timerHide;
var RichWidgets_Feedback_Message_widget;
var RichWidgets_Feedback_Message_notifyWidget;
var RichWidgets_Feedback_Message_Feedback;

// Detect whether or not we are loading this page from the browser cache
outsystems.internal.$(function($) {
    if (typeof(outsystems.internal.$.resetLoadedFromBrowserCache)=='undefined') {
        var CACHE_COOKIE = 'pageLoadedFromBrowserCache';
        outsystems.internal.$.loadedFromBrowserCache = (document.cookie.indexOf(CACHE_COOKIE + "=true") != -1);
        document.cookie = CACHE_COOKIE + "=true;path=/";
    }
});

  
function RichWidgets_Feedback_Message_feedbackSlideDown(feedbackWrapperId, autoHide){
  outsystems.internal.$(function($){
    
    //Prevent messages from showing when the user clicks the browser back button
    if (outsystems.internal.$.loadedFromBrowserCache)
        return;
    feedbackWrapperId = '#' + feedbackWrapperId;

    
    //Cancel previous hide animation if exists
    clearTimeout(RichWidgets_Feedback_Message_timerHide);
    if (RichWidgets_Feedback_Message_widget)
      RichWidgets_Feedback_Message_widget.stop().hide();


    $(feedbackWrapperId).hide();
    if(!($.browser.msie && $.browser.version<7))
      $(feedbackWrapperId).css("top", "-2px"); //Don't do this in IE 6

    //Slidedown Feedback 
    RichWidgets_Feedback_Message_widget = $(feedbackWrapperId).show('slide',{direction:'up'}, 600, function(){
        var slideUp = function(){
          $(feedbackWrapperId).css("height","auto");
          $(RichWidgets_Feedback_Message_widget).hide('slide',{direction:'up'}, 500); 
          clearTimeout(RichWidgets_Feedback_Message_timerHide);
        };
        $(feedbackWrapperId).find('.Feedback_Message_Wrapper_Close').click(slideUp);
        $(feedbackWrapperId).bind('touchstart', slideUp); // mobile devices
        $(feedbackWrapperId).css("height",0);// to avoid ignoring clicks
        if (autoHide) {
          RichWidgets_Feedback_Message_timerHide = window.setTimeout(slideUp, 15000);
        }
      });
  });
}

var RichWidgets_Feedback_Message_UnloadingState = false;

//#590137 Must use jQuery here to ensure "beforeunload" is not overwritten
jQuery(window).bind("beforeunload", function () {
    RichWidgets_Feedback_Message_UnloadingState = true;
});

var RichWidgets_Feedback_Message_errorTrapped = false;
function RichWidgets_Feedback_Message_ErrorHandler(event, exception) {
    outsystems.internal.$(function($){
        if(!RichWidgets_Feedback_Message_UnloadingState)    {
            if (!RichWidgets_Feedback_Message_errorTrapped)
                OsNotifyWidget(RichWidgets_Feedback_Message_notifyWidget, '3) 客户端脚本发生例外。<br\> 错误: ' + (exception.message == ''? exception : exception.message) );
            RichWidgets_Feedback_Message_errorTrapped = true;
        } else {
            RichWidgets_Feedback_Message_UnloadingState = false;
        }
    });
}