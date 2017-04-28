/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using OutSystems.RuntimeCommon;

namespace OutSystems.HubEdition.WebWidgets {
    public class BindDelegatesEventArgs: EventArgs {
        public bool InDataBind { private set; get; }
        public OSUserControl UserControl { private set; get; }

        public BindDelegatesEventArgs(bool inDataBind, OSUserControl userControl) {
            InDataBind = inDataBind;
            UserControl = userControl;
        }
    }
}
