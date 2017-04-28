    /* function for tabs */
    var tabsHandler = {};
    tabsHandler.init = function(){
        
        /* event click tab buttons */
        $('.Tabs__tab').click(function(){
            
            /* check if not active */
            if(!$(this).hasClass('active')){
                        
                /* remove .active on TabsHeader*/
                $(this).parent().children().removeClass('active');
                            
                /* add .active on TabsHeader */
                $(this).addClass('active');

                if($(this).parent().hasClass('Tabs_Mix')){
                    var tabBody = $(this).parent().next('.Tabs_body');
                    $(tabBody).children('.Tabs__content').hide();
                    $(tabBody).children('.Tabs__Loading').show();
                    
                    $($(tabBody).children('.Invisible')).children('input[type="text"]').val($(this).attr('value'));
                    $($(tabBody).children('.Invisible')).children('input[type="submit"]').click();
                    
                } else {
                    /* remove .active on TabsBody */
                    $(this).parent().next().children().removeClass('active');                        
                                
                    /* add .active on TabsBody */
                    $(this).parent().next().children("div").eq($(this).index()).addClass('active');
                }
             }
        
        });
    };

