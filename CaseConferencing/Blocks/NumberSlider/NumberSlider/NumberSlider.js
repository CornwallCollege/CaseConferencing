function initNumberSlider(sliderContainerId, inputId, notifyButtonId, maxValue, minValue, sliderStep, values, updateOnMouseUpOnly) {
    var slider = $("#" + sliderContainerId).slider(
    {
        max: maxValue,
        min: minValue,
        value: $("#" + inputId).val(),
        step: sliderStep,
        stop: function(event, ui) {
            if(values.length > 0) {
                var includeLeft = event.keyCode != $.ui.keyCode.RIGHT;
                var includeRight = event.keyCode != $.ui.keyCode.LEFT;
                slider.slider('option', 'value', findNearest(includeLeft, includeRight, ui.value));
                $("#" + inputId).val($("#" + sliderContainerId).slider('value'));
                $("#" + notifyButtonId).click();
            } else {
                $("#" + inputId).val($("#" + sliderContainerId).slider('value'));
            }
            $("#" + inputId).trigger("change");
            return false;
        },
        slide: function(event, ui) {
            if(!updateOnMouseUpOnly) {
                var includeLeft = event.keyCode != $.ui.keyCode.RIGHT;
                var includeRight = event.keyCode != $.ui.keyCode.LEFT;
                if(values.length > 0)
                    slider.slider('option', 'value', findNearest(includeLeft, includeRight, ui.value));
                $("#" + inputId).val($("#" + sliderContainerId).slider('value'));
                $("#" + inputId).trigger("change");
            }
            if(values.length > 0) return false;
        }
    });
    
    // bind the slider's value to the input's value
    $("#" + inputId).change(function() {
        var newVal = $(this).val();
        newVal = Math.min(newVal, maxValue);
        newVal = Math.max(newVal, minValue);
        slider.slider('option', 'value', newVal);
        if($(this).val() !== newVal) {
            $(this).val(newVal);
        }
    });

    function findNearest(includeLeft, includeRight, value) {
        var nearest = null;
        var diff = null;
        for (var i = 0; i < values.length; i++) {
            if ((includeLeft && values[i] <= value) || (includeRight && values[i] >= value)) {
                var newDiff = Math.abs(value - values[i]);
                if (diff == null || newDiff < diff) {
                    nearest = values[i];
                    diff = newDiff;
                }
            }
        }
        return nearest;
    }
}