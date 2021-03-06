/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.IO;
using System.Text;
using System.Web.UI;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Log;
using OutSystems.RuntimeCommon;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace OutSystems.HubEdition.WebWidgets {
    public abstract class OSPageViewStateCompressed : OSPageViewState {

        protected OSPageViewStateCompressed(bool quirksMode) : base(quirksMode) {}

        private byte[] CompressBinary(byte[] input) {
            var inputBuffer = new MemoryStream(input, 0, input.Length);
			var outputBuffer = new MemoryStream();
            var compressor = new DeflaterOutputStream(outputBuffer, new Deflater(Deflater.BEST_COMPRESSION, false));
			StreamUtils.PumpStream(inputBuffer, compressor);
			inputBuffer.Close();
			compressor.Close();
			return outputBuffer.ToArray();
		}
		
		private byte[] DecompressBinary(byte[] input) {            
			var inputBuffer = new MemoryStream(input, 0, input.Length);
            var decompressor = new InflaterInputStream(inputBuffer);
			var outputBuffer = new MemoryStream();
			StreamUtils.PumpStream(decompressor, outputBuffer);
			decompressor.Close();
			outputBuffer.Close();
			return outputBuffer.ToArray();
		}

        protected override object DeserializeViewState(string viewState) {
            ObjectStateFormatter formatter = new ObjectStateFormatter();
            OutSystems.HubEdition.RuntimePlatform.RuntimePlatformUtils.SetViewstateSize(viewState.Length);
            byte[] bytes;
			try {
				if (viewState[0] != ']') {
					bytes = Convert.FromBase64String(viewState);
					bytes = DecompressBinary(bytes);
				} else {
					bytes = Convert.FromBase64String(viewState.Substring(1));
				}
				return formatter.Deserialize(Convert.ToBase64String(bytes));

			} catch (Exception excep) {
                HeContext context = null;
                try { context = AppInfo.GetAppInfo().OsContext; } catch { }
                string pageName = "";
                try { pageName = context.CurrentScreen.ToString(); } catch { }
				try{
                    ErrorLog.LogApplicationError("Error Deserializing ViewState of page \"" + pageName + "\"), size " + viewState.Length + " bytes (\"" + viewState.Substring(0, Math.Min(10, viewState.Length)) + "...\")." + "\n" +
                    excep.Message, excep.StackTrace, context, "Global");
				} catch { }
			
				throw;
			}
		}
        
        protected override string SerializeViewState(object viewState) {
            string serializedViewState = base.SerializeViewState(viewState);
            if (serializedViewState.Length > 74) {
                byte[] bytes = CompressBinary(Convert.FromBase64String(serializedViewState));
                serializedViewState = Convert.ToBase64String(bytes);
            } else {
                serializedViewState = "]" + serializedViewState;
            }
            return serializedViewState;
        }
	}
}
