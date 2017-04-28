/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using OutSystems.HubEdition.Extensibility.Data.Platform.DatabaseObjects;
using OutSystems.HubEdition.Extensibility.Data.Platform.DDLService;
using OutSystems.HubEdition.Extensibility.Data.Platform.DMLService;
using OutSystems.HubEdition.Extensibility.Data.Platform.ExecutionService;
using OutSystems.HubEdition.Extensibility.Data.Platform.IntrospectionService;
using OutSystems.HubEdition.Extensibility.Data.Platform.Session;
using OutSystems.RuntimeCommon;

namespace OutSystems.HubEdition.Extensibility.Data.Platform {

    /// <summary>
    /// Represents the set of services that added with the ones specified in the <code>IDatabaseServices</code> object enable complete database usage.
    /// </summary>
    public interface IPlatformDatabaseServices: IDatabaseServices {

        /// <summary>
        /// Returns a factory capable of creating platform introspection objects.
        /// </summary>
        new IPlatformDatabaseObjectFactory ObjectFactory { get; }
        
        /// <summary>
        /// Gets the <code>IPlatformIntrospectionService</code> associated with the platform database
        /// </summary>
        new IPlatformIntrospectionService IntrospectionService { get; }

        /// <summary>
        /// Gets the <see cref="IPlatformDMLService"/>object associated with the database.
        /// Represents a service that generates SQL statements.
        /// </summary>
        new IPlatformDMLService DMLService { get; }


        /// <summary>
        /// Gets the <code>IPlatformExecutionService</code> associated with the platform database
        /// </summary>
        new IPlatformExecutionService ExecutionService { get; }

        /// <summary>
        /// Gets the <code>IDDLService</code> associated with the platform database
        /// </summary>
        IDDLService DDLService { get; }

        /// <summary>
        /// Gets the <code>IPlatformSessionService</code> associated with the platform database
        /// </summary>
        IPlatformSessionService SessionService { get; }
    }
}
