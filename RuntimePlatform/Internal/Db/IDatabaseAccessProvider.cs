/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using OutSystems.HubEdition.Extensibility.Data;
using OutSystems.HubEdition.Extensibility.Data.TransactionService;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.RuntimeCommon;

namespace OutSystems.Internal.Db {
    public interface IDatabaseAccessProvider: IDisposable {
        ITransactionManager TransactionManager { get; }
        Transaction GetReadOnlyTransaction();
        Transaction GetRequestTransaction();
        Transaction GetCommitableTransaction();
        DatabaseConnection GetConnection();
        void ExecuteQuery<T>(Command cmd, GenericRecordList<T> rl, string description, bool transformParameters, bool skipLog) where T : ITypedRecord<T>;
        IDatabaseServices DatabaseServices { get; }
        void FreeupResources(bool commit);
    }
}
