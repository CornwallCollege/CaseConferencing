/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Web.UI;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Web;
using OutSystems.RuntimeCommon;

namespace OutSystems.HubEdition.WebWidgets {
    public abstract class OSUserControl : UserControl, IVarsBag, IViewStateAttributes, IAjaxHandler, IAjaxNotifyEvent, IBreakPointControl, IOSControl, IParentEditRecordProp, IGridWidget {        
        private bool delegatesBinded;

        private void BindDelegatesIfNeeded(bool inDataBind) {
            if (!delegatesBinded) {
                var args = new BindDelegatesEventArgs(inDataBind, this);

                
                if (BindDelegates != null) {
                    BindDelegates(this, args);
                }

                delegatesBinded = true;
            }
        }

        protected bool WasRendered { get; set; }

        protected bool HasOnSubmit { get; set; }            


        protected void BindDelegatesIfNeeded() {
            BindDelegatesIfNeeded(false);
        }

#if !JAVA
        protected ControlVisibility ControlVisibility { get; private set; }

        /// <summary>
        /// Restore visibility information of the web block and input widgets from the viewstate
        /// </summary>
        protected virtual void RestoreInputsAndWebBlockVisibility() { }

        /// <summary>
        /// Restore widget and variable data from the viewstate
        /// </summary>
        protected virtual void FetchViewState() {
            RestoreInputsAndWebBlockVisibility();
        }
#endif        

        public OSUserControl() : base() {
            _viewStateAttributes = new ViewStateAttributes(this, Attributes, ViewState);
            ControlVisibility = new ControlVisibility(this, _viewStateAttributes);
        }

        #if !JAVA

        public virtual event EventHandler EvaluateParameters;
        public virtual event EventHandler<BindDelegatesEventArgs> BindDelegates;
        
        protected ViewStateAttributes _viewStateAttributes;
        public ViewStateAttributes ViewStateAttributes {
            get { return _viewStateAttributes; }
            }

		protected bool _includeSpan;
		public virtual bool IncludeSpan {
            get { return _includeSpan; }
            set { _includeSpan = value; }
		}

		public bool IsViewStateEmpty {
            get { 
                // Returns true if the viewstate is indeed empty or it if only contains the inputs visibilities...
                return _viewStateAttributes.IsEmpty || ((_viewStateAttributes.Count == 1) && !ControlVisibility.IsEmpty); 
            }
		}

        protected string _parentEditRecord;
        public virtual string ParentEditRecord {
            get { return _parentEditRecord; }
            set { _parentEditRecord = value; }
        }

        public ParentEditRecordPropType ValidatorType { get { return ParentEditRecordPropType.AGGREGATOR; } }

        #endif

        #if !JAVA   // Already included since the OSUserControl extends the WebPage
        
        public static IValidationMessages ValidationMessagesInstance;
        protected string GetMandatoryValidatorMsg() {
            return ValidationMessagesInstance.MandatoryValidatorMsg;
        }
        protected string GetIntegerValidatorMsg() {
            return ValidationMessagesInstance.IntegerValidatorMsg;
        }
        protected string GetDecimalValidatorMsg() {
            return ValidationMessagesInstance.DecimalValidatorMsg;
        }
        protected string GetCurrencyValidatorMsg() {
            return ValidationMessagesInstance.CurrencyValidatorMsg;
        }
        protected string GetDateValidatorMsg() {
            return ValidationMessagesInstance.DateValidatorMsg;
        }
        protected string GetTimeValidatorMsg() {
            return ValidationMessagesInstance.TimeValidatorMsg;
        }
        protected string GetDateTimeValidatorMsg() {
            return ValidationMessagesInstance.DateTimeValidatorMsg;
        }
        protected string GetTextValidatorMsg() {
            return ValidationMessagesInstance.TextValidatorMsg;
        }
        protected string GetPhoneNumberValidatorMsg() {
            return ValidationMessagesInstance.PhoneNumberValidatorMsg;
        }
        protected string GetNumericPasswordValidatorMsg() {
            return ValidationMessagesInstance.NumericPasswordValidatorMsg;
        }
        protected string GetEmailValidatorMsg() {
            return ValidationMessagesInstance.EmailValidatorMsg;
        }
        
        #endif

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);			  
                        
			if (HasOnSubmit) {
                EnsureChildControlsOnPostbackInParentLists(Parent);
            }
		}


        /// <summary>
        /// #473655 - Ensures that in the next postback any parent list or table record will create this control on postback
        /// even if the postback event was not triggered from a button inside a row. This is necessary, so that the 
        /// OnSubmit handler is always executed even from postbacks from outside the list.
        /// </summary>
        /// <param name="c"></param>
        private void EnsureChildControlsOnPostbackInParentLists(Control c) {
            if (c == null) {
                return;
            }
            
            var list = c as IWebListRecordWidget;
            if (list != null) {
                list.EnsureChildControlsOnPostback();
            }

            EnsureChildControlsOnPostbackInParentLists(c.Parent);
        }

        #if !JAVA
        
		/// <summary>
		/// Checks if the current request is an ajax request
		/// </summary>
		/// <returns></returns>
		public static bool IsAjaxRequest {
            get { return OSPage.IsAjaxRequest; }
		}


        public void StoreInputVisibilityInChildWebBlocksViewState(Control c) {
            // Store view state of the inputs in this block
            this.StoreInputsAndWebBlockVisibility();

            // Look for child blocks
            foreach (Control ctrl in c.Controls) {               
                OSUserControl webBlock = ctrl as OSUserControl;
                if (webBlock != null) {
                    webBlock.StoreInputVisibilityInChildWebBlocksViewState(ctrl);
                } else {
                    StoreInputVisibilityInChildWebBlocksViewState(ctrl);
                }
            }
        }

        /// <summary>
        /// Store visibility information of the web block and input widgets in the viewstate
        /// </summary>
        protected virtual void StoreInputsAndWebBlockVisibility() { }

		/// <summary>
		/// Store widget and variable data in the viewstate
		/// </summary>
		protected virtual void StoreViewState() { 
            StoreInputsAndWebBlockVisibility();
        }

		public virtual bool DataBindCacheOutput() {
			return false;
		}

        protected override void Render(HtmlTextWriter writer) {
            if (_includeSpan) {
                writer.WriteBeginTag("span");                
                WriteAttributeIfNotEmpty(writer, "id", ClientID);
                WriteAttributeIfNotEmpty(writer, "class", this.GetClassesAttribute());
                WriteAttributeIfNotEmpty(writer, "style", Style);
                writer.Write(HtmlTextWriter.TagRightChar);
            }

			base.Render(writer);

			if (_includeSpan)
				writer.WriteEndTag("span");
		}

        private static void WriteAttributeIfNotEmpty(HtmlTextWriter writer, string attrName, string value) {
            if (!String.IsNullOrEmpty(value)) {
                writer.WriteAttribute(attrName, value);
            }
        }
		
        #endif

		/// <summary>
		/// If the user control is acting as proxy
		/// </summary>
		/// <returns></returns>
		public virtual bool IsProxy() {
			return false;
		}

		/// <summary>
		/// Gets the correct control to perform the self refresh of this block
		/// </summary>
		/// <returns></returns>
		public Control GetBlockSelfRefreshControl() {
			//#94431 - for blocks that are currently being referenced be sure to refresh the block proxy instead of the block, so that input parameters are reevaluated.
			if (this.Parent != null && this.Parent is OSUserControl) {
				// is parent control a proxy ?
				if ((this.Parent as OSUserControl).IsProxy()) {
					// refresh the parent proxy control
					return this.Parent;
				}
			}
			// fallback for both cases, refresh this block
			return this;
		}

        #if !JAVA

        public virtual LocalState[] PopDebuggerState() {
            return null;
        }

		#region IVarsBag Members

		protected VarsBag localVars = new VarsBag();

		public virtual void EvaluateFields( VarValue variable, object parent, string baseName, string fields ) {
			localVars.EvaluateFields(variable, parent, baseName, fields);
		}

		public object GetVariableValue( string varName ) {
			return localVars.GetVariableValue(varName);
		}

		public bool HasVariable( string varName ) {
			return localVars.HasVariable(varName);
		}

		public virtual void ToXml( object parent, System.Xml.XmlElement baseElem, string fieldName, int detailLevel ) {
			localVars.ToXml(parent, baseElem, fieldName, detailLevel);
		}

		public string[] VarNames {
			get { return localVars.VarNames; }
		}

		public void SetNewOrigin( object origin ) {
			localVars.SetNewOrigin(origin);
		}

		public void InitVars( string[] varNames, string[] varRtNames ) {
			localVars.InitVars(varNames, varRtNames);
			SetNewOrigin(this);
		}

		#endregion

		#region IBreakPointControl implementation

		private String _BreakpointHookId;
		private bool _BreakpointHookIsExpressionlessWidget = false;

		public event BreakpointHook BreakpointHookEvent;

		public string BreakpointHookId {
			get { return _BreakpointHookId; }
			set { _BreakpointHookId = value; }
		}

		public bool BreakpointHookIsExpressionlessWidget {
			get { return _BreakpointHookIsExpressionlessWidget; }
			set { _BreakpointHookIsExpressionlessWidget = value; }
		}

        protected void HandleBreakpoint() {
            if (BreakpointHookEvent != null) {
                BreakpointHookEvent(BreakpointHookId, BreakpointHookIsExpressionlessWidget);
            }
        }

        #endregion
        #endif

        public override void DataBind() {
            HandleBreakpoint();

            if (EvaluateParameters != null) {
                EvaluateParameters(this, null);
            }

            BindDelegatesIfNeeded(true);

            if (DataBindCacheOutput())
                return;

            // databind child controls
            base.DataBind();
            StoreViewState();
        }

        // Fix for stackoverflow on exceptions during DataBind
        protected override void DataBindChildren() {
            if (!this.HasControls())
                return;

            int count = this.Controls.Count;
            for (int index = 0; index < count; ++index)
                this.Controls[index].DataBind();
        }

        #if !JAVA
        #region IAjaxHandler Members

        private Hashtable events;
        public void RegisterAjaxEvent(AjaxEventType eventType, Array controlIdsToSend) {
            if (events == null) {
                events = new Hashtable();
	}

            events[eventType] = controlIdsToSend;
        }

        public Hashtable GetRegisteredAjaxEvents() {
            return events;
	}

        #endregion

        #region IAjaxNotifyEvent Members

        public event EventHandler AjaxNotify;

        public void OnAjaxNotify(EventArgs e) {
            AjaxEventsHelper.RaiseAjaxEvent(this, AjaxNotify);
        }

        #endregion

        #region IOSControl members
        string IOSControl.TagName { get { return "span"; } }
        string[] IOSControl.CssClass { get { return (this.Attributes["class"] ?? string.Empty).Split(' '); }}
        CssStyleCollection IOSControl.Style {
            get { return this.Attributes.CssStyle; }
        }
        #endregion

        #region IScreen members
        public virtual Control FindControlByName(string name) {
            return null;
        }
        #endregion

        protected virtual string GetRedirectionProtocol(bool destinationIsSecure) {
            return ((OSPage) Page).GetRedirectionProtocol(destinationIsSecure);
        }
#endif

        public abstract string WebBlockIdentifier { get; }

        public virtual string JavaScriptFileName { get { return null; } }
        public virtual string GridCssClasses { get; set; }
        public virtual string Style { get; set; }        
    }
}
