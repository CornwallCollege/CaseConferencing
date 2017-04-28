var RichWidgets_List_BulkSelect_toggle = null;

function RichWidgets_List_BulkSelect_bootstrap(chkboxId, TableRecordsWidget, ButtonWidgetsList) {
  outsystems.internal.$(function($) {
  
  //enable disable buttons
   var RichWidgets_List_BulkSelect_toggleEnabledButtons = function() {
    $.each(ButtonWidgetsList.split(','),  function(i, val) {
      if (val != "") {
        var obj = $('#' + val);
        if ($('#' + TableRecordsWidget +' tbody tr').find(":checkbox:checked").length==0){
          obj.attr('disabled', 'disabled');
          if (obj.attr('href') != undefined  && obj.attr('href') != '') {
            obj.data('hrefSave',obj.attr('href'));
            obj.removeAttr('href');
          }
          if (obj.attr('onclick') != undefined) {
            if (obj.data('clickFn') == undefined)
              obj.data('clickFn', new Function(obj.attr('onclick')));
          }
          obj.unbind('click.BulkSelect');
          obj.removeAttr('onclick');
        }
        else {
          obj.removeAttr('disabled')
          if (obj.data('hrefSave') != undefined) {
            obj.attr('href',obj.data('hrefSave'));
          }
          if (obj.data('clickFn') != undefined) {
            obj.unbind('click.BulkSelect');
            obj.bind('click.BulkSelect', obj.data('clickFn'));
          }
        }
        obj = null;
      }
    });
    $('#' + TableRecordsWidget + ' tbody').find('tr:has(:checkbox:not(:checked))').removeClass('TableRecords_SelectedLine');
    $('#' + TableRecordsWidget + ' tbody').find('tr:has(:checked)').addClass('TableRecords_SelectedLine');
    
  };
  
  RichWidgets_List_BulkSelect_toggle = RichWidgets_List_BulkSelect_toggleEnabledButtons;

    RichWidgets_List_BulkSelect_toggleEnabledButtons();
    
    //click on bulk select
    $('#' + chkboxId).click(function(){
        var bulkChecked = $('#' + chkboxId).attr('checked');
        $('#' + TableRecordsWidget).children("tbody").find('input:checkbox').each(function() {
            var boxChecked = $(this).attr('checked');
            if (bulkChecked) {
                if(!boxChecked) {
                    if(typeof $(this)[0].onclick == "function")
                        $(this)[0].click();
                    else
                        $(this).attr('checked',true);
                }
            }
            else {
                if(boxChecked) {
                    if(typeof $(this)[0].onclick == "function")
                        $(this)[0].click();
                    else
                        $(this).attr('checked',false);
                }
            }
        });
        RichWidgets_List_BulkSelect_toggleEnabledButtons();
    });
    
    //click on individual checkboxes
    $('#' + TableRecordsWidget +' tbody tr').find(':checkbox').click(function(){
     RichWidgets_List_BulkSelect_toggleEnabledButtons();
    });
  });
 }