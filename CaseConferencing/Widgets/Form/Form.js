﻿var OutSystems;
(function (OutSystems) {
    (function (Plugin) {
        /*
        *
        * THIS FILE WAS AUTOMATICALLY GENERATED BY THE PLUGINS' GENERATOR TOOL.
        * IF YOU WANT, CHANGE THE PLUGIN DECLARATION INSTEAD OF DIRECTLY EDITING THIS FILE!!
        *
        */
        /// <reference path="../jquery.d.ts" />
        (function (Widgets) {
            (function (Form) {
                function callServerAction(widgetId, actionName, index) {
                    if (typeof index === "undefined") { index = 0; }
                    var widgetName = $("#" + widgetId).attr("name");
                    if (widgetName === undefined) {
                        widgetName = widgetId;
                    }
                    OsAjax(null, widgetId, widgetName, "BuiltInEvent_" + actionName, "__OSVSTATE,", index.toString());
                }
                Form.callServerAction = callServerAction;

                function triggerServerEvent(widgetId, eventName, index) {
                    if (typeof index === "undefined") { index = 0; }
                    var widgetName = $("#" + widgetId).attr("name");
                    if (widgetName === undefined) {
                        widgetName = widgetId;
                    }
                    OsAjax(null, widgetId, widgetName, "CustomEvent_" + eventName, "__OSVSTATE,", index.toString());
                }
            })(Widgets.Form || (Widgets.Form = {}));
            var Form = Widgets.Form;
        })(Plugin.Widgets || (Plugin.Widgets = {}));
        var Widgets = Plugin.Widgets;
    })(OutSystems.Plugin || (OutSystems.Plugin = {}));
    var Plugin = OutSystems.Plugin;
})(OutSystems || (OutSystems = {}));
var OutSystems;
(function (OutSystems) {
    (function (Plugin) {
        /// <reference path="..\Generated\Form.Model.ts" />
        /// <reference path="plugins.d.ts" />
        (function (Widgets) {
            (function (Form) {
                var $ = outsystems.internal.$;

                function smartInput(input, config) {
                    var enableUndo = getArgumentValue(config, 'undo', true);

                    input.addClass('SmartInput');

                    /* inputs are readonly */
                    formatInputAsReadOnly(input, true);

                    var inputHasCheckedBehavior = hasCheckedBehavior(input);

                    if (input.closest('div[data-widget-type=Form]').hasClass("ReadOnly") || input.attr('readonly') === 'readonly') {
                        input.attr('readonly', 'readonly');
                        input.addClass('ReadOnly');
                        if (input.is('select')) {
                            input.find('option:not([value=' + input.val() + '])').attr('disabled', '');
                        } else {
                            //disable date pickers, checkboxes and radios
                            input.click(function (event) {
                                event.preventDefault();
                                return false;
                            }).attr("onclick", "return false;");
                        }
                    } else {
                        // store the original value
                        input.attr('origValue', inputHasCheckedBehavior ? input.is(':checked') : input.val());

                        input.on("keyup change", function (event) {
                            var keyCode = event.keyCode ? event.keyCode : event.which;
                            if (keyCode === 27) {
                                formatInputAsReadOnly(input, true);
                                smartInput_Undo("#" + input.attr('id'));
                            } else {
                                smartInput_ValueChanged(outsystems.internal.$(this));
                            }
                        });

                        input.on("click focus", function () {
                            if (isInputReadOnly(outsystems.internal.$(this))) {
                                formatInputAsReadOnly(input, false);
                            }
                        });

                        /* on lost focus*/
                        input.blur(function () {
                            formatInputAsReadOnly(input, true);
                        });

                        if (!inputHasCheckedBehavior) {
                            input.after('<span class="fa fa-pencil FormEditPencil"></span>');
                        }

                        if (enableUndo) {
                            var undoElem = outsystems.internal.$('<a class="SmartInput_Undo" href="#"></a>');
                            undoElem.click(function () {
                                return smartInput_Undo("#" + input.attr('id'));
                            });
                            input.after(undoElem);
                        }
                    }
                }

                function hasCheckedBehavior(input) {
                    return input.is(':checkbox') || input.is(':radio');
                }

                function smartInput_Undo(inputID) {
                    var input = outsystems.internal.$(inputID);
                    input.removeClass('Not_Valid');
                    input.val(input.attr('origValue'));
                    input.removeClass('SmartInput_Changed');
                    reevaluateFormChanges(input.closest('div[data-widget-type=Form]'));
                    return false;
                }

                function smartInput_ValueChanged(input, reevaluateOthers) {
                    if (typeof reevaluateOthers === "undefined") { reevaluateOthers = true; }
                    var form = input.closest('div[data-widget-type=Form]');
                    if (smartInput_SameAsOrigValue(input)) {
                        input.removeClass('SmartInput_Changed');
                        reevaluateFormChanges(form);
                    } else {
                        input.addClass('SmartInput_Changed');
                        form.addClass('Form_Changed');
                    }

                    if (reevaluateOthers && input.is(':radio')) {
                        form.find(':radio').each(function () {
                            var $this = outsystems.internal.$(this);
                            if ($this.attr('id') !== input.attr('id')) {
                                smartInput_ValueChanged($this, false);
                            }
                        });
                    }
                }

                function smartInput_SameAsOrigValue(input) {
                    if (hasCheckedBehavior(input)) {
                        return (input.is(':checked') && input.attr('origValue') === 'true') || (!input.is(':checked') && input.attr('origValue') === 'false');
                    } else {
                        return input.val() === input.attr('origValue');
                    }
                }

                function reevaluateFormChanges(form) {
                    var changedInputs = form.find('.SmartInput_Changed');
                    if (!changedInputs.length) {
                        form.removeClass('Form_Changed');
                    }
                }

                function isInputReadOnly(input) {
                    if (input.is('input, textarea, select')) {
                        return input.hasClass('ReadOnly');
                    }
                    return false;
                }

                function formatInputAsReadOnly(input, readonly) {
                    if (readonly) {
                        if (input.is('input, textarea, select')) {
                            input.addClass('ReadOnly').attr('autocorrect', 'off').attr('spellcheck', false);
                        }
                    } else {
                        if (input.is('input, textarea, select')) {
                            input.removeClass('ReadOnly');
                        }
                        input.focus();
                    }
                }

                function getArgumentValue(config, paramkey, defaultValue) {
                    if (typeof config !== 'undefined' && typeof config[paramkey] !== 'undefined') {
                        return config[paramkey];
                    } else {
                        return defaultValue;
                    }
                }

                outsystems.internal.$(window).load(function () {
                    FastClick.attach(document.body);
                });

                function init(formID) {
                    var form = outsystems.internal.$('#' + formID);
                    form.attr("data-widget-type", "Form");
                    if (!form.length) {
                        return;
                    }

                    var hasTouchEvents = 'ontouchstart' in document.documentElement;
                    if (hasTouchEvents) {
                        form.addClass('WithTouchEvents');
                    }

                    form.find('input:not([type=submit]), textarea, select').each(function () {
                        var $this = outsystems.internal.$(this);
                        smartInput($this, {
                            undo: $this.is("select, textarea, input[type='text'], input[type='password'], input[type='datetime'], input[type='datetime-local'], input[type='date'], input[type='month'], input[type='time'], input[type='week'], input[type='number'], input[type='email'], input[type='url'], input[type='search'], input[type='tel'], input[type='color']")
                        });
                    });
                }
                Form.init = init;
            })(Widgets.Form || (Widgets.Form = {}));
            var Form = Widgets.Form;
        })(Plugin.Widgets || (Plugin.Widgets = {}));
        var Widgets = Plugin.Widgets;
    })(OutSystems.Plugin || (OutSystems.Plugin = {}));
    var Plugin = OutSystems.Plugin;
})(OutSystems || (OutSystems = {}));
