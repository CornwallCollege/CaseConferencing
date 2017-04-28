/* Button Group */
function buttonGroup() {

    function onFocusIn() {
        $(this).addClass('active');
    };
    
    function labelClick() {
        if (!$(this).hasClass('disabled')) {
            $(this).parent().children('.ButtonGroup_button').removeClass('active');
            $(this).addClass('active');
        }
    };
    
    function initButtonGroup() {
        $('.ButtonGroup:not(.BtnGroup)').each(function() {
            $(this).find('.ButtonGroup_button').on('click', labelClick);
            $(this).on("focusin", onFocusIn);
            $(this).addClass('BtnGroup');
            
            var radioButtons = $(this).find('input[type="radio"]');            
            $(radioButtons).each(function(){
                if ($(this).is(':checked')) { $(this).parent().addClass('active'); }                
                if ($(this).is(':disabled')) { $(this).parent().addClass('disabled'); }
            });             
        });  
    };
    
    initButtonGroup();
    osAjaxBackend.BindAfterAjaxRequest(initButtonGroup);
};
