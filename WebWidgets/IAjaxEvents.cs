/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using OutSystems.HubEdition.RuntimePlatform.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;

namespace OutSystems.HubEdition.WebWidgets {
    public interface IAjaxNotifyEvent {
		event EventHandler AjaxNotify;
		void OnAjaxNotify(EventArgs e);
	}

    public interface IAjaxClickEvent {
		event EventHandler AjaxClick;
		void OnAjaxClick(EventArgs e);
	}

    public interface IAjaxChangeEvent {
		event EventHandler AjaxChange;
		void OnAjaxChange(EventArgs e);
	}

    public sealed class AjaxEventArgs : EventArgs {

		private object sender;
		private EventHandler handler;
		public bool EventRaised;

		public AjaxEventArgs(object sender, EventHandler handler) {
			this.sender = sender;
			this.handler = handler;
			EventRaised = false;
		}

		public void InvokeHandler() {
			handler(sender, EventArgs.Empty);
			EventRaised = true;
		}
	}
	
	public static class AjaxEventsHelper {


        public static void RaiseAjaxEvent(Control sender, EventHandler AjaxEvent ) {
			if (AjaxEvent != null) {
				AjaxEventArgs args = new AjaxEventArgs(sender, AjaxEvent);

				// sender.RaiseBubbleEvent(sender, args);
				// Control.RaiseBubbleEvent is not accessible since it is protected. For avoiding scattering this code
				// by all the webwidget classes that have ajax events, we will call it by reflection
				MethodInfo raiseBubbleEvent = sender.GetType().GetMethod("RaiseBubbleEvent", BindingFlags.NonPublic | BindingFlags.Instance);
				raiseBubbleEvent.Invoke(sender, new object[] { sender, args });
				
				if (!args.EventRaised)
					AjaxEvent(sender, args);
			}
		}


		/// <summary>
		/// Adds an ajax event attribute to a given attribute list 
		/// </summary>
		/// <param name="eventType">Type of event to add</param>
		/// <param name="clientId">ClientId of the widget</param>
		/// <param name="uniqueId">UniqueId of the widget</param>
		/// <param name="viewStateBuckets">Viewstate buckets to pass in the call</param>
		/// <param name="events">List of events</param>
		/// <param name="attributes">Attribute list of the widget</param>
        public static void AddAjaxEventAttribute(Control control, AjaxEventType eventType, string clientId, string uniqueId, string viewStateBuckets, System.Web.UI.AttributeCollection attributes) {
		    
			Hashtable events = ((IAjaxHandler)control).GetRegisteredAjaxEvents();

			if ( (events != null && events.Contains(eventType))) {
				string eventName = "";
				if (eventType == AjaxEventType.onAjaxClick)
					eventName = "Click";
				else if (eventType == AjaxEventType.onAjaxChange)
					eventName = "Change";

				string osAjaxCallScript;
				string osAjaxCallScriptDelayed;

				if (eventType == AjaxEventType.onAjaxChange) {
					if (control is TextBox) {
						// delayed on change...						
						osAjaxCallScriptDelayed = JavaScriptManager.osAjaxCallScript(clientId, uniqueId, viewStateBuckets, eventName, true);
						SetJsHandlerAttribute("onoschange", osAjaxCallScriptDelayed, attributes);
						
						// on change (lost focus) sets the value immediately
						osAjaxCallScript = JavaScriptManager.osAjaxCallScript(clientId, uniqueId, viewStateBuckets, eventName, false);
						SetJsHandlerAttribute("onchange", osAjaxCallScript, attributes);
					} else {
						string jsHandlerAttributeName;
						if (control is CheckBox || control is RadioButton)
							jsHandlerAttributeName = "onclick";
						else
							jsHandlerAttributeName = "onchange";


						osAjaxCallScript = JavaScriptManager.osAjaxCallScript(clientId, uniqueId, viewStateBuckets, eventName);
						SetJsHandlerAttribute(jsHandlerAttributeName, osAjaxCallScript, attributes);

						if (control is DropDownList) {
							// force onchange for dropdowns after any key is pressed
							SetJsHandlerAttribute("onkeyup", "this.onchange();", attributes);
						}
					}
				} else if (eventType == AjaxEventType.onAjaxClick) {
					// get the code for the immediate call
					osAjaxCallScript = JavaScriptManager.osAjaxCallScript(clientId, uniqueId, viewStateBuckets, eventName) + " return false;";
					SetJsHandlerAttribute("onclick", osAjaxCallScript, attributes);
				}
			}			
		}

		private static string SetJsHandlerAttribute(string attributeName, string handlerText, System.Web.UI.AttributeCollection attributes) {
			string previousHandler = attributes[attributeName];
			if (previousHandler != null && !previousHandler.Contains(handlerText)) {
				if (!previousHandler.EndsWith(";"))
					previousHandler += ";";
				handlerText = previousHandler + handlerText;
			}

			if (handlerText.Length > 0) {
			    
				attributes[attributeName] = handlerText;
			}
			return handlerText;
		}
	}
}
