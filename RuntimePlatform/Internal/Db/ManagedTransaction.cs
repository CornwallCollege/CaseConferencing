/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Data;
using OutSystems.HubEdition.Extensibility.Data.TransactionService;
using OutSystems.HubEdition.RuntimePlatform.Db;

namespace OutSystems.Internal.Db {

    internal class ManagedTransaction : Transaction {

        protected ITransactionManager Manager { get; set; }

        internal ManagedTransaction(ITransactionManager manager, IDbTransaction transaction)
            : base(manager.TransactionService.DatabaseServices, transaction) {
            if (manager == null) {
                throw new ArgumentNullException();
            }
            this.Manager = manager;
        }

        public override void Commit(){
            if (!Completed) {
                Manager.CommitTransaction(DriverTransaction);
                Completed = true;
            }
        }

        public override void Rollback() {
            if (!Completed) {
                Manager.RollbackTransaction(DriverTransaction);
                Completed = true;
            }
        }

        public override void Release() {
            Manager.ReleaseTransaction(DriverTransaction);
        }

        public override Command CreateCommand(string sql) {
            var cmd = DatabaseServices.ExecutionService.CreateCommand(DriverTransaction, sql);
            return new ManagedCommand(Manager, cmd);
        }

        public override void Dispose() {
            Release();
        }
    }
}
