function OSInfiniteListInit(buttonId, LoadMoreId, LoadingMoreId) {
    $(window).scroll(function() {
           if($(window).scrollTop() + $(window).height() > $(document).height() - ($(window).height() * 0.30)) {
               $(window).unbind('scroll');
               var button = $('#' + buttonId);
               var LoadMore = $('#' + LoadMoreId);
               var LoadingMore = $('#' + LoadingMoreId);
               
               $(LoadMore).toggle();
               $(LoadingMore).toggle();               
               button.click();               
           }
    });
}