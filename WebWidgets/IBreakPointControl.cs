/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using OutSystems.RuntimeCommon;

namespace OutSystems.HubEdition.WebWidgets {
    public delegate string BreakpointHook( string breakpointId, bool breakpointIsExpressionlessWidget );

    public interface IBreakPointControl {

		event BreakpointHook BreakpointHookEvent;

		string BreakpointHookId {
			get;
			set;
		}

		bool BreakpointHookIsExpressionlessWidget {
			get;
			set;
		}

		/// <summary>
		/// You should implement a DataBind containing at least
		/// if ( BreakpointHookEvent != null ) {
		/// 	BreakpointHookEvent(BreakpointHookId, BreakpointHookIsExpressionlessWidget);
		/// }
		/// base.DataBind();
		/// </summary>
		void DataBind();
	}
}