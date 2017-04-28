using System;
using System.Configuration;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Xml;

namespace OutSystems.HubEdition.SMS {

    public class SMSSettings {

        public class Configs {

            // Global
            public const string InstanceName = "Installation.InstanceName";

            // SMS Connector
            public const string SMSConnector_InboundQueue = "OutSystems.HubEdition.SMSConnector.InboundQueue";
            public const string SMSConnector_OutboundQueue = "OutSystems.HubEdition.SMSConnector.OutboundQueue";

            // Kannel
            public const string Kannel_UnifiedPrefix = "OutSystems.HubEdition.Kannel.UnifiedPrefix";

            /// <summary>
            /// Global settings are indexed by instance name in machine.config. Use this to obtain their full key name.
            /// 
            /// This must be in sync with RuntimePlatform.Settings.Configs.GetFullGlobalKey
            /// </summary>
			public static string GetFullGlobalKey(string instanceName, string settingName) {
				if (instanceName == null)
					instanceName = "DEFAULT";

				return settingName + " (" + (instanceName ?? "DEFAULT") + ")";
			}
        }

        public static string Get(string key) {
            return ConfigurationManager.AppSettings[Configs.GetFullGlobalKey(ConfigurationManager.AppSettings[Configs.InstanceName], key)];
        }
    }
}
