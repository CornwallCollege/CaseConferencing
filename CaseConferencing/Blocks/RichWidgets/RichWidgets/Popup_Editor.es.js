﻿//Open an Dialog
var RichWidgets_Popup_Editor_ShowTimeoutMilSecs = 200;
var RichWidgets_Popup_Editor_HideTimeoutMilSecs = 800;
var RichWidgets_Popup_Editor_InitialWidth = 210;
var RichWidgets_Popup_Editor_InitialHeight = 100;
var RichWidgets_Popup_Editor_notifyWidget;
var RichWidgets_Popup_Editor_Index = 4010;
var RichWidgets_Popup_Editor_ParentUrl;
var RichWidgets_Popup_Editor_ClosingTag = 'closing';
var RichWidgets_Popup_Editor_ClosingValue = 'true';

function RichWidgets_Popup_Editor_init(linkId, notifyId, setTitle, setHeight, setWidth, parentUrl, useModal, autoResize, recenterOnResize, hideCloseButton) {
 var GetLinkHref = function(widget) {
    var linkHref;
    var isAButton = false;
    try {
    //Checks if the id is from a link or not
    linkHref = outsystems.internal.$(widget).attr('href');

    //Tests for visibility/existence
    if (typeof linkHref == 'undefined') {
      var onClick = widget.getAttribute('onclick');
      if (typeof onClick != 'undefined') {
        isAButton = true;
        if (onClick != null) {
          var hrefMatch;
          if((hrefMatch = onClick.toString().match(/href='([^']*)'/)) != null) {
                linkHref = hrefMatch[1];
          }
        }
      }
    } //else: throw ("Inexistent or Invisible button");
   } catch(e) {}
  
   return [linkHref, isAButton];
 }

 outsystems.internal.$().ready(function($) {
  linkId = '#' + linkId;
  var linkWidget;
  try { linkWidget = $(linkId).get(0); } catch(e) {}
  if (typeof linkWidget == 'undefined') {
    //Case the widget is inexistent or invisible, it will show no errors.
    return;
  }
  
  RichWidgets_Popup_Editor_ParentUrl = parentUrl;
  
  var getLinkResult = GetLinkHref(linkWidget);
  var linkHref = getLinkResult[0];
  var isAButton = getLinkResult[1];

  if (typeof linkHref == 'undefined' || linkHref == "" || linkHref == "#" || linkHref.indexOf("javascript:") == 0) {
   try {
       window.OsHandleException(new Error("Popup link id must be the id of a Link or Button Widget with Method Navigate."), outsystems.osErrorCodes.SystemJavascriptError, 'Popup_Editor');
   } catch(e) {}
   return;
 } 

  if (isAButton) {
    //remove the existing on-click
    linkWidget.setAttribute('onclick', linkWidget.getAttribute('onclick').toString().replace('window.location.href=', 'return false;window.location.href='));
  }

  // if there's a confirmation message, store in an attribute the result
  if (linkWidget.getAttribute('onclick') != null) {
    linkWidget.setAttribute('onclick', linkWidget.getAttribute('onclick').toString().replace("if( ret != true )", "outsystems.internal.$('" + linkId + "').get(0).setAttribute('confirmed', ret); if( ret != true )"));
  }

  var clickHandler = function(event) {
  
    //The clickHandler event is registered in osjs and outsystems.internal.$ for compatibillity reasons, they must not run both for the same click.
    //Variable is set to false in RichWidgets_Popup_Editor_resize function.
    if(outsystems.internal.$.data(event.target,"os-internal-processing") == true){
        return false;
    } else {
        outsystems.internal.$.data(event.target,"os-internal-processing", true);
    }
  
   //Check if the clicked link is disabled
   if(linkWidget.getAttribute('disabled') != null){
       var linkDisabled = linkWidget.getAttribute('disabled').toString().toLowerCase();
       if(linkDisabled == 'disabled' || linkDisabled.indexOf('true') != -1){
        return false;
       }
   }
      
   if (linkWidget.getAttribute("confirmed") == 'false') {
     return false;
   }
   if (OsIsIE()) {
     osFocusBackend.ClearFocusedElement();
   }
   var popupDiv = $("<div style='text-align: center; display: none;'></div>").appendTo("body");
   popupDiv.append('<iframe width="100%" scrolling="auto" height="100%" frameborder="0" src="javascript:void(0);"/>');
   var waitText =  " Por favor espere mientras se carga el contenido…";
   var imgHTML = "<img style='border-width: 0px; height: 16px; width: 16px;' src='/RichWidgets/img/SpinBlack.gif'/>";
   var pleaseWaitDiv = popupDiv.prepend("<div style='margin-top: 25px;' class='Text_Note'>" + imgHTML + waitText + "</div>")

   var loadTargetPage = function () {
      RichWidgets_Popup_Editor_notifyWidget = notifyId;
       //load target page
       var ohref = GetLinkHref(linkWidget)[0];
       var rhref = ohref.replace(/(\?|&)_=.*?(&|$)/, "$1_=" + (+ new Date().now) + "$2"); 
       var xhref = rhref + ((rhref == ohref) ? (rhref.indexOf('?') >= 0 ? "&" : "?") + "_=" + (+new Date) : ''); 
       popupDiv.find('iframe').attr('src', xhref); 
       (function(popupDiv) {
           popupDiv.find('iframe').load(function() {
               //after loading try to resize, if it is possible resize also after each ajax call
               if(RichWidgets_Popup_Editor_resize(popupDiv, setWidth, setHeight, true, event)) {
                   if (autoResize) {
                      var contentWindow = this.contentWindow;
                      contentWindow.osAjaxBackend.BindAfterAjaxRequest(function(){
                        contentWindow.parent.RichWidgets_Popup_Editor_resize(popupDiv, setWidth, setHeight, recenterOnResize, event);
                      });
                   }
               }   
           });
       })(popupDiv);
       popupDiv = null;
       pleaseWaitDiv = null;
   }

   OpenPopup(popupDiv, setTitle, setHeight, setWidth, pleaseWaitDiv, hideCloseButton, loadTargetPage, event);

   return false;
  };
  
  outsystems.internal.registerClickInBothJQueries(linkId, clickHandler);

  function OpenPopup(divToPopup, setTitle, setHeight, setWidth, divPleaseWait, hideCloseButton, loadTargetPage, event) {
   //destroy any previous dialog 
   RichWidgets_Popup_Editor_Close(null);
   // if any close is pending, schedule to execute itself asynchronously exit
   // if no close is pending, continue with open operation
   var closingPopups = $('.os-internal-ui-dialog-content');
   for(var i = 0; i < closingPopups.length; i++) {
    if(outsystems.internal.$.data(closingPopups.get(i),RichWidgets_Popup_Editor_ClosingTag) == RichWidgets_Popup_Editor_ClosingValue) {
        setTimeout(function() {
            OpenPopup(divToPopup, setTitle, setHeight, setWidth, divPleaseWait, hideCloseButton, loadTargetPage, event)
        }, 13);
        return false;
    }
   }
   $(divPleaseWait).show();
   if (setHeight == -1) setHeight = RichWidgets_Popup_Editor_InitialHeight;
   $(divToPopup).show().dialog({
    dialogClass: 'os-internal-Popup',
    resizable: false,
    autoResize: false,
    closeOnEscape: !hideCloseButton,
    bgiframe: true,
    draggable: true,
    autoOpen: true,
    title: setTitle,
    modal: !(useModal === false),
    height: setHeight,
    position: 'center',
    width: ((setWidth == -1) ? RichWidgets_Popup_Editor_InitialWidth: setWidth),
    zIndex: RichWidgets_Popup_Editor_Index,
    close: function() {
     //If the popup is closed before it is resized (ESC) we need to set the processing event to false. 
     outsystems.internal.$.data(event.target,"os-internal-processing", false); 
     $(divToPopup).find('iframe').unbind("load");     
     $(divToPopup).find('iframe').attr('src', 'about:blank');
     setTimeout(function() {
      $(divToPopup).find('iframe').empty();
      $(divToPopup).empty();
     }, 13); //We need to delay this! or IE7 crashes
    }
   });
   $(divToPopup).find('iframe').height(0);
   $(divToPopup).parents('.os-internal-ui-dialog').dropShadow();
   

   if (setTitle==" ") {
    $(".os-internal-ui-dialog-titlebar").height(0);
    $(".os-internal-ui-dialog-titlebar-close").attr("class","os-internal-ui-dialog-titlebar-close-no-title").html("").hide();
    $(".os-internal-ui-dialog").css("overflow","visible");
   } else {
    var titleHeight = $('.os-internal-ui-dialog-titlebar').height();
    $(divToPopup).parents('.os-internal-Popup').height(setHeight+titleHeight);
   }
    if (hideCloseButton) {
        $(".os-internal-ui-dialog-titlebar-close, .os-internal-ui-dialog-titlebar-close-no-title").remove();
    }
    loadTargetPage();
  };
 });
}

function RichWidgets_Popup_Editor_resize(divToPopup, setWidth, setHeight, recenter, event) {
    // Code to support old resize method RichWidgets_Popup_Editor_resize(setWidth, setHeight, recenter)
    if(typeof(recenter) == 'undefined') {
        recenter = setHeight;
        setHeight = setWidth;
        setWidth = divToPopup;
        divToPopup = outsystems.internal.$('.os-internal-ui-dialog-content');
    }
    
    
    // Resize must bail out immediately if the popup is marked as closing, and not start the animation.
    if(outsystems.internal.$.data(divToPopup.get(0), RichWidgets_Popup_Editor_ClosingTag) == RichWidgets_Popup_Editor_ClosingValue) {
        return false;
    }
    var frameObj = divToPopup.find('iframe')[0];
    var documentServer = document.location.href.replace(/(https?:\/\/[^\/]*).*/, '$1');
    var frameServer = frameObj.src.replace(/(https?:\/\/[^\/]*).*/, '$1');
    var sameOrigin = (frameServer.toLowerCase() == documentServer.toLowerCase() || frameServer.indexOf("http") != 0);
    if (!sameOrigin && (setWidth == -1 || setHeight == -1)) throw (new Error("A Popup with a screen from a different server (or https) needs explicict width, height set."));
    if (sameOrigin) {
        var innerDoc = (frameObj.contentDocument) ? frameObj.contentDocument : frameObj.contentWindow.document;
        if (innerDoc.documentElement.scrollHeight == 0) // strangely this event is also triggered on close
        return false;
    }
    var oldHeight = outsystems.internal.$(divToPopup).parents('.os-internal-Popup').outerHeight();
    var width = ((setWidth == -1) ? outsystems.internal.$(innerDoc).width() : setWidth);
    var height = ((setHeight == -1) ? outsystems.internal.$(innerDoc).height() : setHeight);

    var titleHeight = outsystems.internal.$('.os-internal-ui-dialog-titlebar').height();
    
    // Verify if the parent window width is less than the pop-up window, if so set the responsive class on the iframe body (for responsive themes)
    if(window.innerWidth < width)
    {
        // only set the class if the origin is the same
        if(sameOrigin) {
            $(innerDoc).find('body').addClass('Responsive');
            width = window.innerWidth - 20; // 10px "padding" effect, to keep the popup look and feel on top of content
        }
    }

    // Fix issues with scrollbars
    if (setHeight == -1) {
        // IE7 needs a little more space to remove the scrollbars
        if (outsystems.internal.$.browser.msie) height = height + 1;
    } else { //when explicitly setting the height
        if (sameOrigin) innerDoc.body.style.height = 'auto';
    }

    outsystems.internal.$(divToPopup).height(height);


    //Hide ECT
    outsystems.internal.$(innerDoc).find('.ECT_FeedbackContainer').hide();
    var divPopupOuterWindow = outsystems.internal.$(divToPopup).parents('.os-internal-Popup');

    var animateFinal = {};

    if (setHeight == -1) {
        var oldTop = parseInt(divPopupOuterWindow.css("top"));
        if (recenter)
            animateFinal.top = Math.max(20, oldTop + (oldHeight - (height + titleHeight)) / 2);
        animateFinal.height = height + titleHeight;
    }

    if (setWidth == -1) {
        var oldLeft = parseInt(divPopupOuterWindow.css("left"));
        if (recenter)
            animateFinal.left = oldLeft + (divPopupOuterWindow.width() - width) / 2;
        animateFinal.width = width;
    }
    
    if(divPopupOuterWindow.width() == animateFinal.width && 
       divPopupOuterWindow.height() == (animateFinal.height - (outsystems.internal.$.browser.msie?1:0))){
       outsystems.internal.$(".os-internal-ui-dialog-content>.Text_Note").hide();
       outsystems.internal.$(divToPopup).height(height - (outsystems.internal.$.browser.msie?1:0)); // restore size
       return true; // nothing to do...
    }
    
    // hide content in first resize - readjustments will not flickr
    if(divPopupOuterWindow.width()  == RichWidgets_Popup_Editor_InitialWidth && 
       divPopupOuterWindow.height() == RichWidgets_Popup_Editor_InitialHeight){
        outsystems.internal.$(frameObj).height(0);
    }
    var onAnimationComplete = function () {
        setTimeout(function() {
            outsystems.internal.$(divToPopup).dialog('size');
            outsystems.internal.$('.os-internal-ui-dialog-titlebar-close-no-title').css('display', 'block');
            outsystems.internal.$(divToPopup).find('iframe').height("100%").width(animateFinal.width);
        },13);
    };
    var divPleaseWait = outsystems.internal.$(".os-internal-ui-dialog-content>.Text_Note");
    divPleaseWait.hide();

    if (setHeight == -1 || setWidth == -1) divPopupOuterWindow.animate(animateFinal, {
        duration: 200,
        complete: onAnimationComplete
    });
    else onAnimationComplete();

    innerDoc = null;
    divPopupOuterWindow = null;
    outsystems.internal.$.data(event.target,"os-internal-processing", false);
    return true;
}

var popupToClose;
function RichWidgets_Popup_Editor_Close(iFrame) {
 // Any close requests must immediately (synchronously) tag the closing element, marking it as closing. The cleanup must be done asynchronously due to IE7..
 popupToClose = outsystems.internal.$('.os-internal-ui-dialog-content');
 outsystems.internal.$(popupToClose).data(RichWidgets_Popup_Editor_ClosingTag, RichWidgets_Popup_Editor_ClosingValue);
 setTimeout(function() {
   outsystems.internal.$(popupToClose).dialog('close'); 
   outsystems.internal.$(popupToClose).remove();
  }, 
 0);
};