outsystems.internal.$(function($) {
    var RichWidgets = (window.RichWidgets = window.RichWidgets || {});
        
    // constants and configuration
    var menuSelector = '.Application_Menu',
        togglerOverlayCls ='MenuSlider_Toggler_Overlay',
        togglerSelector   = '.MenuSlider_Toggler';
        
    // main toggling function
    var toggleMenu = function toggleMenu(e) {
        $('body').toggleClass('MenuSlider_IsOpen');
        if (RichWidgets.MenuSlider.onMenuStateChanged) {
           RichWidgets.MenuSlider.onMenuStateChanged();
        }
        e.stopPropagation()
    };
    
    if (!$(menuSelector).has('a').length) {
        // there are no menu items (e.g login page)
        $(togglerSelector).hide();
        return;
    }
    
    $(togglerSelector).bind('click', toggleMenu);
    
    $('body').append($('<div class="'+togglerOverlayCls+'">'));
    $('.' + togglerOverlayCls).bind('click', toggleMenu);

    // provide API
    RichWidgets.MenuSlider = {
        isMenuOpen: function() {
            return $('body').hasClass('MenuSlider_IsOpen');
        },
        toggleMenu: toggleMenu,
        onMenuStateChanged: null
     };

});
