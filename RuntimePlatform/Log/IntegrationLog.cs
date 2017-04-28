/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using OutSystems.RuntimeCommon;

namespace OutSystems.HubEdition.RuntimePlatform.Log {
    [Serializable()]
    public class IntegrationLog : ICloneable {
        // TODO : Create readonly accessor function for this batch of variables        
        public string Id;
        public DateTime Instant;
        public int Duration;
        public string Source;
        public string Endpoint;
        public string Action;
        public string Type;
        public int EspaceId;
        public int TenantId;
        public string ErrorId;
        public string ExecutedBy;
        public bool IsExpose;
        // END OF TODO


        public IntegrationLog() {
        }

        public IntegrationLog(
            string id,
            DateTime instant,
            int duration,
            string source,
            string endpoint,
            string action,
            string type,
            int espaceId,
            int tenantId,
            string errorId,
            string executedBy,
            bool isExpose
            ) {
            Id = id;
            Instant = instant;
            Duration = duration;
            Source = source;
            Endpoint = endpoint;
            Action = action;
            Type = type;
            EspaceId = espaceId;
            TenantId = tenantId;
            ErrorId = errorId;
            ExecutedBy = executedBy;
            IsExpose = isExpose;
        }

        public IntegrationLog(IntegrationLog obj) {
            Id = GenerateLogId();
            Instant = obj.Instant;
            Duration = obj.Duration;
            Source = obj.Source;
            Endpoint = obj.Endpoint;
            Action = obj.Action;
            Type = obj.Type;
            EspaceId = obj.EspaceId;
            TenantId = obj.TenantId;
            ErrorId = obj.ErrorId;
            ExecutedBy = obj.ExecutedBy;
            IsExpose = obj.IsExpose;
        }

        public IntegrationLog(WebServiceLog obj) {
            Id = GenerateLogId();
            Instant = obj.Instant;
            Duration = obj.Duration;
            Source = obj.Client_IP;
            Endpoint = String.Empty;
            Action = obj.Method;
            Type = String.Empty;
            EspaceId = obj.EspaceId;
            TenantId = obj.TenantId;
            ErrorId = obj.ErrorId;
            ExecutedBy = obj.ExecutedBy;
            IsExpose = true;
        }

        public IntegrationLog(WebReferenceLog obj) {
            Id = GenerateLogId();
            Instant = obj.Instant;
            Duration = obj.Duration;
            Source = String.Empty;
            Endpoint = obj.URL;
            Action = obj.Method;
            Type = String.Empty;
            EspaceId = obj.EspaceId;
            TenantId = obj.TenantId;
            ErrorId = obj.ErrorId;
            ExecutedBy = obj.Executed_By;
            IsExpose = false;
        }

        private static string GenerateLogId() {
            return Guid.NewGuid().ToString();
        }

        public object Clone() {
            return new IntegrationLog(this);
        }

        public static string StaticWrite (
            DateTime instant,
            int duration,
            string source,
            string endpoint,
            string action,
            string type,
            int espaceId,
            int tenantId,
            string errorId,
            string executedBy,
            bool isExpose) {
            IntegrationLog log = new IntegrationLog();
            log.Write(GenerateLogId(), instant, duration, source, endpoint, action, type, espaceId, tenantId, errorId, executedBy, isExpose);
            return log.Id;
        }

        public void Write(
            string id,
            DateTime instant,
            int duration,
            string source,
            string endpoint,
            string action,
            string type,
            int espaceId,
            int tenantId,
            string errorId,
            string executedBy,
            bool isExpose) {
            Id = id;
            Instant = instant;
            Duration = duration;
            Source = source;
            Endpoint = endpoint;
            Action = action;
            Type = type;
            EspaceId = espaceId;
            TenantId = tenantId;
            ErrorId = errorId;
            ExecutedBy = executedBy;
            IsExpose = isExpose;
            RuntimeLogger.Log(this);
        }
    }
}
