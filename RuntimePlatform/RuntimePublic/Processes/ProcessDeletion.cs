/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace OutSystems.RuntimePublic.Processes {
    
    /// <summary>
    /// Class to perform the deletion of processes.
    /// </summary>
    public class ProcessDeletion {
        public class ProcessDeletionException : Exception {
            protected ProcessDeletionException(string msg) : base(msg) { }
        }

        public class ProcessNotFoundException : ProcessDeletionException {
            public ProcessNotFoundException() : base("The specified process identifier was not found in the database.") { }
        }

        public class ProcessNotTopLevelException : ProcessDeletionException {
            public ProcessNotTopLevelException() : base("The specified process identifier is associated with a process instance that is not top-level.") { }
        }

        public class InvalidProcessStatusException : ProcessDeletionException {
            public InvalidProcessStatusException()
                : base("The specified process identifier is associated with a process instance that is not terminated or closed.") { }
        }

        public class InvalidBulkSizeLimitException : ProcessDeletionException {
            public InvalidBulkSizeLimitException() : base("The specified bulk size limit is invalid. The value must be equal or higher than 0.") { }
        }

        private HubEdition.RuntimePlatform.ProcessDeletion processDeletion;

        public ProcessDeletion(int processId) {
            processDeletion = new HubEdition.RuntimePlatform.ProcessDeletion(processId);
        }

        public ProcessDeletion(DateTime olderThan) : this(olderThan, null, null) { }

        public ProcessDeletion(DateTime olderThan, int? bulkSizeLimit) : this(olderThan, bulkSizeLimit, null) { }

        public ProcessDeletion(DateTime olderThan, int? bulkSizeLimit, int? processDefinitionId) {
            processDeletion = new HubEdition.RuntimePlatform.ProcessDeletion(olderThan, bulkSizeLimit, processDefinitionId);
        }

        /// <summary>
        /// Deletes all the logged information of the instances of Processes that fit the criteria specified in the constructor.
        /// The information that is deleted is all the logging of: process instances, activities instances, input parameters values, output parameters values, processes instances executed within other process instances, etc.
        /// </summary>
        /// <returns>True if the operation deleted all the processes that fit the criteria.</returns>
        public bool DeleteProcesses() {
            using (Transaction trans = DatabaseAccess.ForSystemDatabase.GetRequestTransaction()) {
                return processDeletion.DeleteProcesses(trans);
            }
        }

        /// <summary>
        /// Determines whether there are processes to delete.
        /// </summary>
        /// <returns><c>true</c> if there are processes to delete, <c>false</c> otherwise.</returns>
        public bool HasProcessesToDelete() {
            using (Transaction trans = DatabaseAccess.ForSystemDatabase.GetRequestTransaction()) {
                return processDeletion.HasProcessesToDelete(trans);
            }
        }
    }
}