/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System.IO;
using OutSystems.RuntimeCommon;
using OutSystems.RuntimeCommon.Extensibility.Plugins;
using System.Collections.Generic;

namespace OutSystems.HubEdition.Extensibility.Data {
    public sealed class DatabasePluginProvider<TDatabaseProvider> : AbstractPluginProvider<DatabaseProviderKey, TDatabaseProvider>, IDatabasePluginSet<TDatabaseProvider>
            where TDatabaseProvider: IDatabaseProvider {

        private IEnumerable<DirectoryInfo> pluginDirectories;
        protected override IEnumerable<DirectoryInfo> PluginDirectories { get { return pluginDirectories; } }
        
        
        protected override string PluginsNameMask {
            get {
                return "*DatabaseProvider*.dll";
            }
        }
        
        protected override DatabaseProviderKey GetKey(TDatabaseProvider p) {
            return p.Key;
        }

        public DatabasePluginProvider(DirectoryInfo plugins) {
            pluginDirectories = new DirectoryInfo[1] { plugins }; ;

            LoadPlugins((e, s) => {
                OSTrace.InfoException(e, s);
            });
        }


        public DatabasePluginProvider(IEnumerable<DirectoryInfo> plugins) {
            pluginDirectories = plugins;

            LoadPlugins((e, s) => {
                OSTrace.InfoException(e, s);
            });
        }
    }
}
