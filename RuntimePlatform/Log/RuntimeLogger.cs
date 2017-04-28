/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Data;
using System.Diagnostics;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;
using OutSystems.RuntimeCommon;
using OutSystems.RuntimeCommon.Log;

namespace OutSystems.HubEdition.RuntimePlatform.Log {
    public class RuntimeLogger {

        public delegate LoggerImplementation getRuntimeLogger();
        public delegate void setRuntimeLogger(LoggerImplementation logger);
        public delegate LoggerImplementation setupRuntimeLogger();
        public delegate int indexRuntimeLogger();

        private static volatile getRuntimeLogger GetRuntimeLoggerOverride = null;
        private static volatile setRuntimeLogger SetRuntimeLoggerOverride = null;
        private static volatile setupRuntimeLogger SetupRuntimeLoggerOverride = null;

        public static void OverrideRuntimeLogger(getRuntimeLogger getOverride, setRuntimeLogger setOverride, setupRuntimeLogger setupOverride) {
            lock (typeof (RuntimeLogger)) {                
                GetRuntimeLoggerOverride = getOverride;
                SetRuntimeLoggerOverride = setOverride;
                SetupRuntimeLoggerOverride = setupOverride;
            }
        }

        public static volatile bool DisableLogs = false;

        private static string applicationName = "Undefined Application";

        private static LoggerImplementation loggerInstance = null;

        private static LoggerImplementation LoggerInstance {
            get {
                //lock (typeof(RuntimeLogger)) {
                    if (loggerInstance == null) {
                        lock (typeof (RuntimeLogger)) {
                            if (loggerInstance == null) {
                                loggerInstance = NullLogger.Instance;
                            }
                        }
                    }
                    return loggerInstance;
                //}
            }
            set {
                lock (typeof(RuntimeLogger)) {
                    loggerInstance = value;
                }
            }
        }
        private static bool ApplicationMonitoringEnabled {
            get {
                var info = AppInfo.GetAppInfo();
                return info != null ? info.ApplicationMonitoringEnabled : true;
            }
        }

        public static bool LogAsynchronousEnabled {
            get {
                return false;
            }
        }

        public static void SetUp(string applicationName, bool ignoreExceptions) {
            lock (typeof(RuntimeLogger)) {
                RuntimeLogger.applicationName = applicationName;
                OSTrace.PublishLog = new PublishLog();
            }
        }

        private static void SetUpLoggerInstance(bool ignoreExceptions) {
            if (ignoreExceptions) {
                lock (typeof(RuntimeLogger)) {
                    try {
                        LoggerInstance = GetRuntimeLogger();
                    } catch (Exception e) {
                        EventLogger.WriteError("Error initializing logger for " + applicationName + ": " + e.ToString());
                    }
                }
            } else {
                lock (typeof(RuntimeLogger)) {
                    LoggerInstance = GetRuntimeLogger();
                }
            }
        }

        private static LoggerImplementation GetRuntimeLogger() {
            LoggerImplementation logger = new NullLogger();
            logger.SetUp();
            return logger;
        }

        public static void Log(CyclicJobLog log) {
            try {
                if (!ApplicationMonitoringEnabled)
                    return;
                LoggerInstance.Log(log);
            } catch (Exception e) {
                EventLogger.WriteError("Error sending log: " + e.ToString());
            }
        }

        public static void Stop() {
            LoggerInstance.Stop();
        }

        public static void Log(ErrorLog log) {
            Log(log, false);
        }

        public static void Log(ErrorLog log, bool forceSynchronous) {
            try {
                if (LoggerInstance != null) {
                    LoggerInstance.Log(log);
                } else {
                    EventLogger.WriteError(log.Message);
                }
            } catch (Exception e) {
                EventLogger.WriteError("Error sending log: " + e.ToString());
            }
        }

        public static void Log(GeneralLog log) {
            try {
                if (!ApplicationMonitoringEnabled)
                    return;
                if (log.ModuleName == "ALARM") {
                    EventLogger.WriteWarning(log.Message);
                }
                if (LoggerInstance != null) {
                    LoggerInstance.Log(log);
                } else {
                    EventLogger.WriteInfo(log.Message);
                }
            } catch (Exception e) {
                EventLogger.WriteError("Error sending log: " + e.ToString());
            }
        }

        public static void Log(ScreenLog screenLog) {
            try {
                if (!ApplicationMonitoringEnabled)
                    return;
                
                switch (screenLog.ScreenType) {
                    case "WEB":
                        break;
                    case "SMS":
                        break;
                    default:
                        break;
                }
                LoggerInstance.Log(screenLog);
            } catch (Exception e) {
                EventLogger.WriteError("Error sending log: " + e.ToString());
            }
        }

        public static void Log(ExtensionLog extensionLog) {
            try {
                if (!ApplicationMonitoringEnabled)
                    return;
                LoggerInstance.Log(extensionLog);
            } catch (Exception e) {
                EventLogger.WriteError("Error sending log: " + e.ToString());
            }
        }

        public static void Log(SmsLog log) {
            try {
                if (!ApplicationMonitoringEnabled)
                    return;
                LoggerInstance.Log(log);
            } catch (Exception e) {
                EventLogger.WriteError("Error sending log: " + e.ToString());
            }
        }

        public static void Log(WebReferenceLog log) {
            try {
                if (!ApplicationMonitoringEnabled)
                    return;
                LoggerInstance.Log(log);
            } catch (Exception e) {
                EventLogger.WriteError("Error sending log: " + e.ToString());
            }
        }

        public static void Log(WebServiceLog log) {
            try {
                if (!ApplicationMonitoringEnabled)
                    return;
                LoggerInstance.Log(log);

            } catch (Exception e) {
                EventLogger.WriteError("Error sending log: " + e.ToString());
            }
        }

        public static void Log(IntegrationLog log) {
            try {
                if (!ApplicationMonitoringEnabled)
                    return;
                LoggerInstance.Log(log);
            } catch (Exception e) {
                EventLogger.WriteError("Error sending log: " + e.ToString());
            }
        }

        public static void Log(IntDetailLog log) {
            try {
                if (!ApplicationMonitoringEnabled) {
                    return;
                }
                if (LoggerInstance != null) {
                    LoggerInstance.Log(log);
                } else {
                    EventLogger.WriteInfo(log.Message);
                }
            } catch (Exception e) {
                EventLogger.WriteError("Error sending log: " + e.ToString());
            }
        }

        public static void LogPublishTrace(DateTime instant, string eSpaceKey, string step, bool isStart, int traceKindId, string extraInfo, string parentStep) {
            try {
                if (LogAsynchronousEnabled) {
                    var publishLog = new CustomLog("PublishTrace", "OSSYS_PUBLISHTRACE", 0, null, 
                        DatabaseAccess.ForSystemDatabase.DatabaseServices.DatabaseConfiguration.DatabaseIdentifier);

                    publishLog.Fields.Add("ESPACE_SS_KEY", eSpaceKey);
                    publishLog.Fields.Add("STEP", step);
                    publishLog.Fields.Add("INSTANT", instant);
                    publishLog.Fields.Add("ISSTART", isStart ? 1 : 0);
                    publishLog.Fields.Add("TRACEKINDID", traceKindId);
                    publishLog.Fields.Add("EXTRAINFO", extraInfo);
                    publishLog.Fields.Add("PARENTSTEP", parentStep);

                    try {
                        LoggerInstance.Log(publishLog);
                    } catch (Exception e) {
                        EventLogger.WriteError("Error sending publish log: " + e.ToString());
                    }
                }
            } catch (Exception e) {
                EventLogger.WriteError("Error sending publish log: " + e.ToString());
            }
        }

        public static void LogVisit(DateTime instant, string visitorUID, string visitUID) {
            var visitLog = new CustomLog("Visit", "OSSYS_VISIT", 0, null, 
                DatabaseAccess.ForSystemDatabase.DatabaseServices.DatabaseConfiguration.DatabaseIdentifier);

            visitLog.Fields.Add("INSTANT", instant);
            visitLog.Fields.Add("VISITORUID", visitorUID);
            visitLog.Fields.Add("VISITUID", visitUID);

            try {
                LoggerInstance.Log(visitLog);
            } catch (Exception e) {
                EventLogger.WriteError("Error sending log: " + e.ToString());
            }
        }

        public static void Log(CustomLog log) {
            try {
                if (!ApplicationMonitoringEnabled) {
                    return;
                }
                LoggerInstance.Log(log);
            } catch (Exception e) {
                EventLogger.WriteError("Error sending log: " + e.ToString());
            }
        }

        
        private static DateTime referenceDate = new DateTime(2000, 1, 1, 0, 0, 0);

        
        public static int CalculateIndex(DateTime current, int cycleSize) {
            int cyclePeriod = 7; // 1 week default
            try {
                cyclePeriod = Settings.GetInt(Settings.Configs.LogServer_Db_CyclePeriod);
            } catch {
            }
            return CalculateIndex(current, cycleSize, cyclePeriod);
        }

        
        public static int CalculateIndex(DateTime current, int cycleSize, int cyclePeriod) {
            return ((((TimeSpan)current.Subtract(referenceDate)).Days / cyclePeriod) % cycleSize);
        }

        public static int CalculateLastDirtyIndex(int cycleSize, int windowSize) {
            
            int current = CalculateIndex(DateTime.Now, cycleSize);
            // This may look more complicated than needed, but guards against very big or negative windowSize's...
            current = (current - windowSize) % cycleSize;

            return (current >= 0 ? current : current + cycleSize);
        }

        public static int CalculatePreviousIndex(int currentIndex, int cycleSize) {
            int current = (currentIndex - 1) % cycleSize;
            return (current >= 0 ? current : current + cycleSize);
        }

        public static void SetDisableLogs(bool value) {
            lock (typeof (RuntimeLogger)) {
                DisableLogs = value;
            }
        }
    }
}