/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using OutSystems.HubEdition.Extensibility.Data.ConfigurationService;
using OutSystems.HubEdition.Extensibility.Data.Platform.QueryProvider;
using OutSystems.RuntimeCommon.ObfuscationProperties;
using OutSystems.Internal.Db;

namespace OutSystems.Internal.Db {

    [DatabaseProviderSpecificImplementationFor("Oracle")]
    [DoNotObfuscateType]
    internal class DatabaseConfigurationHelperOracle : DatabaseConfigurationHelper {
        internal override IRuntimeDatabaseConfiguration ChangeConnectionString(IIntegrationDatabaseConfiguration configuration, string connectionString,
                                                                               string databaseIdentifier) {
            var config = base.ChangeConnectionString(configuration, connectionString, databaseIdentifier);
            config.SetParameter("Schema", databaseIdentifier);
            return config;
        }
    }
}