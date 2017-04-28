outsystems.internal.$(function() {
    if (parent != window){
        var crossDomain;
        try {
            var url = parent.location.href;
            if (parent.location.href == undefined) {
                crossDomain = true;
            } else {
                crossDomain = false;
            }
        } catch (e) {
            crossDomain = true;
        }
        if (crossDomain == false && parent.location.href.indexOf('PreviewInDevices') == -1 ){
            if (parent.RichWidgets_Popup_InfoBalloon_ParentUrl) {
                parent.location = parent.RichWidgets_Popup_InfoBalloon_ParentUrl;
            } else if (parent.RichWidgets_Popup_Editor_ParentUrl) {
                parent.location = parent.RichWidgets_Popup_Editor_ParentUrl;
            } else if (parent.location) {
                parent.location = location.href;
            }
        }
    }
});