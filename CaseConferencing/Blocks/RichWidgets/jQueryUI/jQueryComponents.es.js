//jQuery Components

/* #IF_IS_SYSTEM */ outsystems.internal. /* #ENDIF_IS_SYSTEM */ jQueryComponents = function (jQuery) {
(function($){
/* Copyright (c) 2006 Brandon Aaron (http://brandonaaron.net)
 * Dual licensed under the MIT (http://www.opensource.org/licenses/mit-license.php) 
 * and GPL (http://www.opensource.org/licenses/gpl-license.php) licenses.
 *
 * $LastChangedDate: 2007-07-21 18:45:56 -0500 (Sat, 21 Jul 2007) $
 * $Rev: 2447 $
 *
 * Version 2.1.1
 */
$.fn.bgIframe=$.fn.bgiframe=function(s){if($.browser.msie&&parseInt($.browser.version, 10)<7){s=$.extend({top:'auto',left:'auto',width:'auto',height:'auto',opacity:true,src:'javascript:false;'},s||{});var prop=function(n){return n&&n.constructor==Number?n+'px':n;},html='<iframe class="bgiframe"frameborder="0"tabindex="-1"src="'+s.src+'"'+'style="display:block;position:absolute;z-index:-1;'+(s.opacity!==false?'filter:Alpha(Opacity=\'0\');':'')+'top:'+(s.top=='auto'?'expression(((parseInt(this.parentNode.currentStyle.borderTopWidth)||0)*-1)+\'px\')':prop(s.top))+';'+'left:'+(s.left=='auto'?'expression(((parseInt(this.parentNode.currentStyle.borderLeftWidth)||0)*-1)+\'px\')':prop(s.left))+';'+'width:'+(s.width=='auto'?'expression(this.parentNode.offsetWidth+\'px\')':prop(s.width))+';'+'height:'+(s.height=='auto'?'expression(this.parentNode.offsetHeight+\'px\')':prop(s.height))+';'+'"/>';return this.each(function(){if($('> iframe.bgiframe',this).length==0)this.insertBefore(document.createElement(html),this.firstChild);});}return this;};

/* Drop shadow component */
  $.fn.dropShadow = function(options)   // NOTE: opacity parameter is deprecated: use rgba instead
  {
    if($.browser.msie&&parseInt($.browser.version, 10) < 9)
        return; // not supported
        
    // Default options
    var opt = $.extend({
      left: 4,
      top: 4,
      blur: 2,
      color: "rgba(0,0,0,0.5)",
      swap: false
      }, options);
     
    var parameters = opt.left+"px "+opt.top+"px "+opt.blur+"px "+opt.color+" "+ (opt.swap? "inset" : "");
    this.css("-moz-box-shadow", parameters);
    this.css("-webkit-box-shadow", parameters);
    this.css("box-shadow", parameters);
  };
})(jQuery);
};

/* #IF_IS_SYSTEM */ outsystems.internal. /* #ENDIF_IS_SYSTEM */ jQueryComponents(outsystems.internal.$);

/* #IF_IS_SYSTEM */
if(outsystems.internal.$.inCompatibilityMode) {
    outsystems.internal.jQueryComponents(osjs);
}
/* #ENDIF_IS_SYSTEM */