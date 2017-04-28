$(function (){
    //All clicks need to do this so that applications added to iphone home screen will not jump to safari
    if (window.navigator.standalone) {
        $('body').on('click', 'a', function(event){
            /*jshint scripturl:true*/
            var ahref = $(this).attr('href') ? $(this).attr('href').toLowerCase() : "" ;

            // Continue as normally if it is a javascript link, an anchor or mailto: and tel: links
            if (ahref.indexOf('#')!=-1 ||
                event.isDefaultPrevented() ||
                !ahref ||
                this.target ||
                /^(http|https|mailto|tel):/.test(ahref) ||
                (ahref.indexOf('javascript:')===0)) {
              return;
            }
            event.preventDefault();
            window.location = this.href;
        });
    }
});