/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Web.UI;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Web;
using OutSystems.RuntimeCommon;

namespace OutSystems.HubEdition.WebWidgets {
    public static class Utils {

        // #428891 Web Accessibility - Section 508
        // allow custom tag name
        private const string CustomTagName_ExtendedPropertyName = "osTagName";


        public static string GetOSTagNameAndRemoveFromExtendedProperties(AttributeCollection extendedProperties, String defaultTag) {
            String _osTagName = defaultTag;

            if (extendedProperties[CustomTagName_ExtendedPropertyName] != null) {
                try {
                    _osTagName = extendedProperties[CustomTagName_ExtendedPropertyName];

                    // remove tag name "extended attribute" from the list of attributes
                    extendedProperties.Remove(CustomTagName_ExtendedPropertyName);
                } catch { }
            }
            return _osTagName;
        }

        private static void generateParentEditRecordScripts(JavaScriptManager scriptManager, Control ctrl) {
		    ParentEditRecordPropUtils.VisitComponent(scriptManager, ctrl as IParentEditRecordProp, ctrl.Visible, () => ctrl.ClientID);

			// process the children
			foreach (Control child in ctrl.Controls) {
				generateParentEditRecordScripts(scriptManager, child);
			}
		}

		/// <summary>
		/// Gets a control in the last row of a record widget, providing the record widget and the control id
		/// </summary>
		/// <param name="recordWidgetControl"></param>
		/// <param name="childID"></param>
		/// <returns></returns>
		public static Control getControlInRecordWidget(Control recordWidgetControl, string childID) {
            //TODO TCS Put this in an interface like IWidgetWithIterator?
            if (recordWidgetControl is CustomWidget) {
                foreach (Control child in recordWidgetControl.Controls) {
                    // TODO JMN this decision should be done in compile time but currently its not easy
                    if (child is Iterator) {
                        recordWidgetControl = child;
                        break;
                    } else {
                        var childFound = FindControlRecursive(child, childID);
                        if (childFound != null) {
                            return childFound;
                        }
                    }
                }
            }

            ControlCollection lines = null;
            Control line;
            int index = 0;

            OSDataGrid dg = null;

			if (recordWidgetControl is Iterator) {
				Iterator it = recordWidgetControl as Iterator;
				// if the iterator has some selected index, go to the current control
				if (it.SelectedIndex != -1)
					return getSelectedControlInRecordWidget(recordWidgetControl, childID);
				else {
					// Must be databinding the iterator, otherwise the control was requested from outside of the iterator */
					if (it.IsDataBinding) {
						/* NOTE: The last control is always an Invisible Item, so we must 
						* use -2 to get the previous one that is a Repeater Item and 
						* corresponds to the last line */
						lines = it.Controls;
						index = lines.Count - 2;
					}
				}
			} else {
				/* The table record widget is a DataGrid. */
				dg = recordWidgetControl as OSDataGrid;
				// if the datagrid has some selected index, go to the current control
				if (dg.SelectedIndex != -1)
					return getSelectedControlInRecordWidget(recordWidgetControl, childID);
				else {
					// Must be databinding the datagrid, otherwise the control was requested from outside of the datagrid */
					if (dg.IsDataBinding) {
						/* The datagrid always contains a child control table.
						* This child control is a collection of lines, and each one of the line
						* is a collection of columns containing the widget. */
						lines = recordWidgetControl.Controls[0].Controls;
						index = lines.Count - 1;
					}
				}
			}
			

			Control ctrl = null;
			if (lines != null) {
				line = lines[index];
				// Find the control inside the line
                ctrl = FindControlRecursive(line,childID);
			}

            // #116141 - if the record widget control is a datagrid and the control is not yet found try to find in the widget in the header item
            if (ctrl == null && dg != null && dg.HeaderItemControl != null) {
                ctrl = FindControlRecursive(dg.HeaderItemControl,childID);
            }

			// Were we able to find the control ?
			if (ctrl == null) {
				// the control is not accessible in the current context, so return ""
				ctrl = new EmptyControl();				
			}

			return ctrl;
		}

        private static Control FindControlRecursive(Control rootControl, string controlID) {
            if (rootControl == null) {
                return null;
            }
            
            if (rootControl.ID == controlID) {
                return rootControl;
            }

            Control controlToReturn = rootControl.FindControl(controlID);
            if (controlToReturn != null) {
                return controlToReturn;
            }

            foreach (Control controlToSearch in rootControl.Controls) {
                controlToReturn = FindControlRecursive(controlToSearch, controlID);
                if (controlToReturn != null) {
                    return controlToReturn;
                }
            }
            return null;
        }

		/// <summary>
		/// Gets a control in the current selected row of a record widget, providing the record widget and the control id 
		/// </summary>
		/// <param name="recordWidgetControl"></param>
		/// <param name="childID"></param>
		/// <returns></returns>
		public static Control getSelectedControlInRecordWidget(Control recordWidgetControl, string childID) {
			Control selectedItemControl = null;
            OSDataGrid dg = null;

            //TODO TCS Put this in an interface like IWidgetWithIterator?
            if (recordWidgetControl is CustomWidget) {
                foreach (var control in recordWidgetControl.Controls) {
                    if (control is Iterator) {
                        recordWidgetControl = (Control)control;
                    }
                }
            }

			if (recordWidgetControl is Iterator) {
				Iterator it = recordWidgetControl as Iterator;
				selectedItemControl = it.SelectedItemControl;
			} else {
				dg = recordWidgetControl as OSDataGrid;
				selectedItemControl = dg.SelectedItemControl;
			}

            Control foundControl = null;
            // try to find the control in the selected item control, if any
            if (selectedItemControl != null) {
                foundControl = FindControlRecursive(selectedItemControl, childID);
            }
            // #116141 - if the record widget control is a datagrid and the control is not yet found, try to find it in the header item
            if (foundControl == null && dg != null && dg.HeaderItemControl != null) {
                foundControl = FindControlRecursive(dg.HeaderItemControl, childID);
			}
            return foundControl;				
        }

        public static void addValidationScriptsToPage(Page page) {
            // no need to do if this is an ajax request...
            if (!OSPage.IsAjaxRequest) {                
                JavaScriptManager scriptManager = new JavaScriptManager();
                generateParentEditRecordScripts(scriptManager, page);
                string validationEditRecordScript = scriptManager.parentEditRecordValidatorsScript;

                if (validationEditRecordScript != "") {
                    page.ClientScript.RegisterStartupScript(page.GetType(), "ValidatorsScript", validationEditRecordScript);
                }
            }
		}

        public static Control GetOwnerOfControl(Control control) {
            int isInsidePlaceHolderCount = 0;
            while (true) {
                if (control is Page) {
                    return control;
                }
                var userControl = control as OSUserControl;
                if (userControl != null && !userControl.IsProxy()) {
                    if (isInsidePlaceHolderCount > 0) {
                        isInsidePlaceHolderCount -= 1;
                    } else {
                        return control;
                    }
                }
                var container = control as PlaceholderContainer;
                if (container != null) {
                    isInsidePlaceHolderCount += 1;
                }
                control = control.Parent;
            }
        }

        public static void RemoveIdIfAnonymous(Control control, AttributeCollection attributes) {
            // Test if we want to remove the id attribute from the output
			string ANONYMOUS_PROPERTY = "anonymous";
			string ID_PROPERTY = "id";

			string oldIdAttributeValue = null;
			
			if ((attributes[ANONYMOUS_PROPERTY] != null) && (attributes[ANONYMOUS_PROPERTY] != "") 
			        && (((IAjaxHandler) control).GetRegisteredAjaxEvents() == null)) {
			        
				// We need to store the old value of the id to restore later
				oldIdAttributeValue = attributes[ID_PROPERTY];

				// Remove the attribute and set the id to null to prevent the id from being rendered
				attributes.Remove(ID_PROPERTY);
				control.ID = null;
			}

			// Always remove the anonymous attribute from render
			attributes.Remove(ANONYMOUS_PROPERTY);

			/*
               this code was causing #92617
			if (oldIdAttributeValue != null) {
				/* We need to restore the old stored id attribute (we still need to access the control from the 
				 * code-behind) *//*
				attributes.Add(ID_PROPERTY, oldIdAttributeValue);
				control.ID = oldIdAttributeValue;
			}
			*/
        }

        public static TInterface GetBlockCustomProperties<TInterface, TEmptyClass>(Control controlFound) where TInterface: class, IWebBlockRuntimeProperties 
                where TEmptyClass: TInterface, new() {

            var correctControlType = controlFound as TInterface;
            return (correctControlType == null)? new TEmptyClass(): correctControlType;
        }
    }	
}
