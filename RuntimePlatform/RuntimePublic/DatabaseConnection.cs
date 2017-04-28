/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

﻿using System.Web;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.RuntimeCommon;

namespace OutSystems.RuntimePublic {

    /// <summary>
    /// API used to control the use of External Database Connections
    /// </summary>
    public static class DatabaseConnection {

        /// <summary>
        /// Set the Connection String for a specific Database Connection to be applied in the current Session.
        ///
        /// - This method will not affect queries in the current request if the connection was already used.
        /// - The target database must have the same type as configured in Service Center (e.g. Oracle, SQL Server, MySQL).
        /// - Requires the Platform Extensibility APIs Feature.
        /// </summary>
        /// <param name="connectionName">Name of the Database Connection</param>
        /// <param name="connectionString">Connection String to use</param>
        /// <param name="databaseIdentifier">The initial database to use (effective only for Oracle databases, indicating the schema to be initialy used)</param>
        public static void SetConnectionStringForSession(string connectionName, string connectionString, string databaseIdentifier) {
            if (HttpContext.Current != null) {
                AppInfo info = AppInfo.GetAppInfo();
                if (info != null) {
                    info.CheckPlatformExtensibilityAPIs();
                    info.OsContext.Session.SetDatabaseConnectionOverride(connectionName, connectionString, databaseIdentifier.IsEmpty() ? null : databaseIdentifier);
                }
            }
        }
    }

}