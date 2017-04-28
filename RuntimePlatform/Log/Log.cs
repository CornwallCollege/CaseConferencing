/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using OutSystems.Extensibility;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.RuntimeCommon;
using System;
using System.Collections.Generic;
using System.Messaging;
using System.Text;
using OutSystems.Internal.Db;

namespace OutSystems.HubEdition.RuntimePlatform.Log {

    public class Logger : RuntimeLogger { }

    public abstract class LoggerImplementation : IDisposable {

        public abstract void SetUp();
        
        public abstract void Log(ScreenLog log);
        
        public abstract void Log(ExtensionLog log);
        
        public abstract void Log(GeneralLog log);
        public abstract void Log(SmsLog log);
        
        public abstract void Log(ErrorLog log);
        
        public abstract void Log(CyclicJobLog log);
        
        public abstract void Log(WebReferenceLog log);
        
        public abstract void Log(WebServiceLog log);
        public abstract void Log(CustomLog log);

        public abstract void Log(IntegrationLog log);

        public abstract void Log(IntDetailLog log);

        public abstract void Stop();

        public virtual void Dispose() { }

    }

    public class NullLogger : LoggerImplementation {
        public static readonly NullLogger Instance = new NullLogger();

        public override void SetUp() { }
        public override void Log(ScreenLog log) { }
        public override void Log(ExtensionLog log) { }
        public override void Log(GeneralLog log) { }
        public override void Log(SmsLog log) { }
        public override void Log(ErrorLog log) { }
        public override void Log(CyclicJobLog log) { }
        public override void Log(WebReferenceLog log) { }
        public override void Log(WebServiceLog log) { }
        public override void Log(CustomLog log) { }
        public override void Log(IntegrationLog log) { }
        public override void Log(IntDetailLog log) { }
        public override void Stop() { }
    }

    public class LoggerSynchronous : LoggerImplementation {

        private int dbCycleSize;

        public override void SetUp() {
            dbCycleSize = Settings.GetInt(RuntimePlatform.Settings.Configs.LogServer_Db_CycleSize);
        }

        public override void Stop() {
        }

        public override void Log(CyclicJobLog log) {
            using (DatabaseConnection conn = DatabaseAccess.ForLogging.GetConnection()) {
                DBRuntimePlatform.Instance.CreateCyclicJobLog(conn, log, dbCycleSize);
            }
        }

        public override void Log(GeneralLog log) {
            using (DatabaseConnection conn = DatabaseAccess.ForLogging.GetConnection()) {
                DBRuntimePlatform.Instance.CreateGeneralLog(conn, log, dbCycleSize);
            }
        }

        public override void Log(CustomLog log) {
            if(log.PhysicalTableName.ToUpper() != "OSSYS_VISIT")
                throw new NotSupportedException("Custom Logs are not supported with synchronous logs");

            using (DatabaseConnection conn = DatabaseAccess.ForSystemDatabase.GetConnection()) {
                DBRuntimePlatform.Instance.CreateVisitLog(conn, log);
            }
        }

        public override void Log(ScreenLog log) {
            using (DatabaseConnection conn = DatabaseAccess.ForLogging.GetConnection()) {
                DBRuntimePlatform.Instance.CreateScreenLog(conn, log, dbCycleSize);
            }
        }

        public override void Log(ExtensionLog log) {
            using (DatabaseConnection conn = DatabaseAccess.ForLogging.GetConnection()) {
                DBRuntimePlatform.Instance.CreateExtensionLog(conn, log, dbCycleSize);
            }
        }

        public override void Log(SmsLog log) {
            using (DatabaseConnection conn = DatabaseAccess.ForLogging.GetConnection()) {
                DBRuntimePlatform.Instance.CreateSmsLog(conn, log, dbCycleSize);
            }
        }

        public override void Log(ErrorLog log) {
            using (DatabaseConnection conn = DatabaseAccess.ForLogging.GetConnection()) {
                DBRuntimePlatform.Instance.CreateErrorLog(conn, log, dbCycleSize);
            }
        }

        public override void Log(WebReferenceLog log) {
            using (DatabaseConnection conn = DatabaseAccess.ForLogging.GetConnection()) {
                //DBRuntimePlatform.Instance.CreateWebReferenceLog(conn, log, dbCycleSize);
                DBRuntimePlatform.CreateIntegrationLog(conn, new IntegrationLog(log), dbCycleSize);
            }
        }

        public override void Log(WebServiceLog log) {
            using (DatabaseConnection conn = DatabaseAccess.ForLogging.GetConnection()) {
                //DBRuntimePlatform.Instance.CreateWebServiceLog(conn, log, dbCycleSize);
                DBRuntimePlatform.CreateIntegrationLog(conn, new IntegrationLog(log), dbCycleSize);
            }
        }

        public override void Log(IntegrationLog log) {
            using (DatabaseConnection conn = DatabaseAccess.ForLogging.GetConnection()) {
                DBRuntimePlatform.CreateIntegrationLog(conn, log, dbCycleSize);
            }
        }

        public override void Log(IntDetailLog log) {
            using (DatabaseConnection conn = DatabaseAccess.ForLogging.GetConnection()) {
                DBRuntimePlatform.CreateIntDetailLog(conn, log, dbCycleSize);
            }
        }
    }

    public class LoggerAsynchronous : LoggerImplementation {
        private Dictionary<string, MessageQueue> messageQueues = new Dictionary<string, MessageQueue>(10);
        
        private MessageQueue adminQueue;

        private MessageQueue GetMessageQueue(LogType logType) {
            string queuePath;
            if (Settings.GetBool(Settings.Configs.Log_SupportBulkLogs)) {
                switch (logType) {
                    case LogType.Cyclic_Job:
                        queuePath = Settings.Get(Settings.Configs.Log_TimerLogQueuePath);
                        break;
                    case LogType.Error:
                        queuePath = Settings.Get(Settings.Configs.Log_ErrorLogQueuePath);
                        break;
                    case LogType.General:
                        queuePath = Settings.Get(Settings.Configs.Log_GeneralLogQueuePath);
                        break;
                    case LogType.Screen:
                        queuePath = Settings.Get(Settings.Configs.Log_ScreenLogQueuePath);
                        break;
                    case LogType.Extension:
                        queuePath = Settings.Get(Settings.Configs.Log_ExtensionLogQueuePath);
                        break;
                    case LogType.Sms:
                        queuePath = Settings.Get(Settings.Configs.Log_SmsLogQueuePath);
                        break;
                    case LogType.Web_Reference:
                        queuePath = Settings.Get(Settings.Configs.Log_WebReferenceLogQueuePath);
                        break;
                    case LogType.Web_Service:
                        queuePath = Settings.Get(Settings.Configs.Log_WebServiceLogQueuePath);
                        break;
                    case LogType.Integration:
                        queuePath = Settings.Get(Settings.Configs.Log_IntegrationLogQueuePath);
                        break;
                    case LogType.Int_Detail:
                        queuePath = Settings.Get(Settings.Configs.Log_IntDetailLogQueuePath);
                        break;
                    default:                        
                        queuePath = Settings.Get(Settings.Configs.Log_CustomLogQueuePath);
                        break;
                }
            } else {
                queuePath = Settings.Get(Settings.Configs.Log_QueuePath);
                logType = LogType.Dummy;
            }


            if (!messageQueues.ContainsKey(queuePath)) {
                lock (messageQueues) {
                    
                    if (adminQueue == null) {       
                        adminQueue = new MessageQueue(Settings.Get(Settings.Configs.Log_AdminQueuePath));                        
                        adminQueue.Formatter = new BinaryMessageFormatter();
                    }
                    if (!messageQueues.ContainsKey(queuePath)) {
                        // Queues are created in ServerSetup
                        MessageQueue mQueue = CreateMessageQueue(queuePath, logType);
                        messageQueues.Add(queuePath, mQueue);
                    }
                }
            }
            return messageQueues[queuePath];
        }

        public static MessageQueue CreateMessageQueue(string queuePath, LogType logType) {
#if JAVA
            MessageQueue mQueue = null;
            ExtensionPointLoader<AsynchronousMessage>.Execute(a => GetMessageQueue(a, queuePath, logType, out mQueue), ConfigurationsImpl.Instance);
            if (mQueue == null) {
                OSTrace.Error("Could not find an implementation for asynchronous messages. All asynchronous messages are going to be ignored.");
                return new outsystems.extensibility.NullJmsMessageQueue();
            } else {
                return mQueue;
            }
#else
            MessageQueue mQueue = new MessageQueue(queuePath);
            mQueue.Formatter = new BinaryMessageFormatter();
                            
            try {
                mQueue.Send("dummy", LogType.Dummy.ToString());
            } catch {
                MessageQueue.ClearConnectionCache();
                mQueue = new MessageQueue(queuePath);
                mQueue.Formatter = new BinaryMessageFormatter();
                mQueue.Send("dummy", LogType.Dummy.ToString());
            }
            return mQueue;
#endif
        }

#if JAVA
        private static void GetMessageQueue(AsynchronousMessage ep, string queuePath, LogType logType, out MessageQueue queue) {
            queue = ep.GetMessageQueue(queuePath, logType);
        }
#endif
        
        private void Log(object log, LogType logType, MessagePriority priority) {
            using (Message msg = CreateMessage(log, logType.ToString(), priority)) {
                GetMessageQueue(logType).Send(msg);
            }
        }
        
        private void Log(object log, LogType logType) {
            Log(log, logType, MessagePriority.Normal);
        }

        public override void Dispose() {
            base.Dispose();
            foreach (MessageQueue queue in messageQueues.Values) {
                queue.Dispose();
            }
        }

        private int dbCycleSize;
        private int integrationLogMaxMessageSizeForLogServer;

        public override void SetUp() {
            dbCycleSize = Settings.GetInt(RuntimePlatform.Settings.Configs.LogServer_Db_CycleSize);
            integrationLogMaxMessageSizeForLogServer = Settings.GetInt(RuntimePlatform.Settings.Configs.IntegrationLogMaxMessageSizeForLogServer);
        }
    

        private Message CreateMessage(object log, string label, MessagePriority priority) {
            Message msg = new Message(log, new BinaryMessageFormatter());
            msg.Recoverable = false;
            msg.Label = label;
            msg.Priority = priority;
            msg.AdministrationQueue = adminQueue;
            msg.AcknowledgeType = AcknowledgeTypes.NotAcknowledgeReachQueue | AcknowledgeTypes.NotAcknowledgeReceive | AcknowledgeTypes.NegativeReceive;
            msg.TimeToBeReceived = TimeSpan.FromMinutes(Settings.GetInt(Settings.Configs.Log_QueueMessageMaxAge));
            return msg;
        }

        public override void Stop() { }
        
        public override void Log(CyclicJobLog log) {
            Log(log, LogType.Cyclic_Job);
        }

        public override void Log(GeneralLog log) {
            Log(log, LogType.General);
        }

        public override void Log(ScreenLog log) {
            Log(log, LogType.Screen);
        }

        public override void Log(ExtensionLog log) {
            Log(log, LogType.Extension);
        }

        public override void Log(CustomLog log) {
            Log(log, LogType.Custom);
        }

        public override void Log(ErrorLog log) {
            Log(log, LogType.Error);
        }

        private const string TruncatedLogMessageSuffix = "\r\n<Message truncated in logging because it exceeded the maximum size>";        

        public override void Log(SmsLog log) {
            MessagePriority priority;
            switch (log.Message.Priority) {
                case 1:
                case 2:
                    priority = MessagePriority.High;
                    break;
                case 4:
                    priority = MessagePriority.Lowest;
                    break;
                default:
                    priority = MessagePriority.Normal;
                    break;
            }

            Log(log, LogType.Sms, priority);
        }

        public override void Log(IntegrationLog log) {
            Log(log, LogType.Integration);
        }

        public override void Log(IntDetailLog log) {
            int sizeLimit = Settings.GetInt(Settings.Configs.Log_MaxMessageQueueSizeInKbForLargeContentQueues) * 1000;
            if (log.Message != null && log.Message.Length > sizeLimit) {
                var builder = new StringBuilder(sizeLimit + TruncatedLogMessageSuffix.Length + 1);
                builder.Append(log.Message, 0, sizeLimit);
                builder.Append(TruncatedLogMessageSuffix);
                log.Message = builder.ToString();
            }

            Log(log, LogType.Int_Detail);
        }

        public override void Log(WebReferenceLog log) {
            Log(log, LogType.Web_Reference);
        }

        public override void Log(WebServiceLog log) {
            Log(log, LogType.Web_Service);
        }
    }
}