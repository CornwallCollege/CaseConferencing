outsystems.internal.$(function () {
    var responsiveTables = function() {
        outsystems.internal.$('.Responsive .TableRecords').each(function() {
            var table = outsystems.internal.$(this);
            table.find('thead th').each( function ( index ) {
                var label = outsystems.internal.$(this).clone().children().remove().end().text();
                if (label == "")
                    label = outsystems.internal.$(this).text().replace(/lnkSort[\s\S]*/,"");
                table.find('tbody tr').each( function () {
                    var cell = outsystems.internal.$(this).children().eq(index);
                    if( cell.find('div.TableRecords_Label').length == 0 ) {
                        if (index == 0 && cell.find(':checkbox').length > 0) {
                            label = cell.next().find('a').text();
                            cell.append(outsystems.internal.$('<div class=\'TableRecords_Label\'></div>').text(label) );
                        } else {                        
                            cell.prepend(outsystems.internal.$('<div class=\'TableRecords_Label\'></div>').text(label) );
                        }
                    }
                });
            });
         });
    };
    responsiveTables();
    outsystems.internal.$('body').on('click', '.Responsive .TableRecords td:first-child',function(event) {
        if (!outsystems.internal.$(event.target).is("a,input,button")) {
            outsystems.internal.$(this).parent('tr').toggleClass('TableRecords_ExpandedRow');
        }
    });
    osAjaxBackend.BindAfterAjaxRequest(function(){responsiveTables();});
});