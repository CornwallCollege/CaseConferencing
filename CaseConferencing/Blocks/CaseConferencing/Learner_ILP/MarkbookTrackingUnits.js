/* Section Expandable */
/*
SectionExpandable = function() {    

    var that = this;

    that.init = function(){
        /* add event click */
   /*     $(".SectionExpandable_header").off();
        $(".SectionExpandable_header").on('click', function(){
            
            /* has class expanded */
   /*         if($(this).parent().hasClass("expanded")){
                $(this).next().css('display', 'block');
                $(this).next().slideUp({ duration: 500, easing: "easeInCubic" });
                $(this).parent().removeClass("expanded");
            }else{
                $(this).next().slideDown('500', 'easeOutCubic', function(){$(this).css('overflow', 'visible')});
                $(this).parent().addClass("expanded");
            }
        });
    }
    
    
    osAjaxBackend.BindAfterAjaxRequest(that.init);
    
    that.init();
}


/* execute by Silk UI*/
/*SilkUI.Execute(SectionExpandable, "Error on SilkUIFramework/Content/SectionExpandable");*/
