/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using OutSystems.HubEdition.Extensibility.Data;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace OutSystems.RuntimePublic.Db {

    /// <summary>
    /// Provides access to a specific database.
    /// </summary>
    public sealed class DatabaseProvider {
        private IDatabaseAccessProvider provider;

        internal DatabaseProvider(IDatabaseAccessProvider provider) {
            if (provider == null) {
                throw new ArgumentNullException("DatabaseProvider cannot be initialized with null.");
            }
            this.provider = provider;
        }

        /// <summary>
        /// Returns the transaction that starts at the beginning of the web request and is
        /// committed when the response is sent to the client.
        /// This transaction cannot be committed or rolled back inside extensions.
        /// </summary>
        /// <returns>The transaction associated with the web request.</returns>
        public RequestTransaction GetRequestTransaction() {
            return new RequestTransaction(provider.GetRequestTransaction());
        }

        /// <summary>
        /// Returns a new transaction that needs to be managed explicitly using a commit or
        /// roll back.
        /// </summary>
        /// <returns>A <see cref="CommittableTransaction"/></returns>
        public CommittableTransaction GetCommittableTransaction() {
            return new CommittableTransaction(provider.GetCommitableTransaction());
        }

        /// <summary>
        /// Returns an SqlHelper instance targeted at the manipulation of SQL statements members
        /// </summary>
        public SqlHelper SqlHelper {
            get {
                return new SqlHelper(provider.DatabaseServices);
            }
        }
    }
}
