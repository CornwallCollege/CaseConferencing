function RichWidgets_List_SortColumn(Column, linkId, sortColumn_OrderBy, pageName, inputTableRecordsId){
 outsystems.internal.$(function($) {
  var columnHeader = $('#' + linkId).parents('th:eq(0)');
  
  columnHeader.click(function(){
   $('#' + linkId).triggerHandler("click");
  });
  var tableRecordsId = $('#' + linkId).parents('table.TableRecords:eq(0)').attr('id');
  $('#' + inputTableRecordsId).val(tableRecordsId);
  var isSortedColumn = sortColumn_OrderBy.indexOf(pageName + ":" + tableRecordsId + "=" + Column)>-1;
  if (isSortedColumn){
   columnHeader.addClass('SortColumns_Sorted');
  } else {
   columnHeader.addClass('SortColumns_Sortable');
  }
 });
}