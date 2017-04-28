/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System.Messaging;
using OutSystems.RuntimeCommon;

namespace OutSystems.Extensibility {
    public abstract class WebReferenceExtensionPoint: OutSystemsExtensionPoint {
        public abstract void SetTimeout(object bindingProvider, int timeoutInMillis);
        /**
         * This method exists as a HACK to solve a bug found in JBoss EAP6. 
         * The messageContext sometimes is lost and needs to be restored.
         */
        public abstract void RestoreMessageContext(object messageContext, bool shouldRestore);
    }
}
