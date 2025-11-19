/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyApmApplicationConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// Business system ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Application name
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// URL convergence switch. 0: Off; 1: On
        /// </summary>
        [JsonProperty("UrlConvergenceSwitch")]
        public long? UrlConvergenceSwitch{ get; set; }

        /// <summary>
        /// URL convergence threshold
        /// </summary>
        [JsonProperty("UrlConvergenceThreshold")]
        public long? UrlConvergenceThreshold{ get; set; }

        /// <summary>
        /// Regex rules for exception filtering, separated by commas
        /// </summary>
        [JsonProperty("ExceptionFilter")]
        public string ExceptionFilter{ get; set; }

        /// <summary>
        /// Regex rules for URL convergence, separated by commas
        /// </summary>
        [JsonProperty("UrlConvergence")]
        public string UrlConvergence{ get; set; }

        /// <summary>
        /// Error code filtering, separated by commas
        /// </summary>
        [JsonProperty("ErrorCodeFilter")]
        public string ErrorCodeFilter{ get; set; }

        /// <summary>
        /// Regex rules for URL exclusion, separated by commas
        /// </summary>
        [JsonProperty("UrlExclude")]
        public string UrlExclude{ get; set; }

        /// <summary>
        /// Log switch. 0: Off; 1: On
        /// </summary>
        [JsonProperty("IsRelatedLog")]
        public long? IsRelatedLog{ get; set; }

        /// <summary>
        /// Log region.
        /// </summary>
        [JsonProperty("LogRegion")]
        public string LogRegion{ get; set; }

        /// <summary>
        /// Log topic ID
        /// </summary>
        [JsonProperty("LogTopicID")]
        public string LogTopicID{ get; set; }

        /// <summary>
        /// CLS log set/ES cluster ID
        /// </summary>
        [JsonProperty("LogSet")]
        public string LogSet{ get; set; }

        /// <summary>
        /// Log source: CLS or ES
        /// </summary>
        [JsonProperty("LogSource")]
        public string LogSource{ get; set; }

        /// <summary>
        /// APIs to be filtered
        /// </summary>
        [JsonProperty("IgnoreOperationName")]
        public string IgnoreOperationName{ get; set; }

        /// <summary>
        /// Whether thread profiling is enabled.
        /// </summary>
        [JsonProperty("EnableSnapshot")]
        public bool? EnableSnapshot{ get; set; }

        /// <summary>
        /// Timeout threshold for thread profiling.
        /// </summary>
        [JsonProperty("SnapshotTimeout")]
        public long? SnapshotTimeout{ get; set; }

        /// <summary>
        /// Whether agent is enabled.
        /// </summary>
        [JsonProperty("AgentEnable")]
        public bool? AgentEnable{ get; set; }

        /// <summary>
        /// Whether link compression is enabled.
        /// </summary>
        [JsonProperty("TraceSquash")]
        public bool? TraceSquash{ get; set; }

        /// <summary>
        /// Switch for enabling application diagnosis.
        /// </summary>
        [JsonProperty("EventEnable")]
        public bool? EventEnable{ get; set; }

        /// <summary>
        /// Component List
        /// </summary>
        [JsonProperty("InstrumentList")]
        public Instrument[] InstrumentList{ get; set; }

        /// <summary>
        /// Related configurations of the probe APIs.
        /// </summary>
        [JsonProperty("AgentOperationConfigView")]
        public AgentOperationConfigView AgentOperationConfigView{ get; set; }

        /// <summary>
        /// Whether to enable application log configuration.
        /// </summary>
        [JsonProperty("EnableLogConfig")]
        public bool? EnableLogConfig{ get; set; }

        /// <summary>
        /// Whether to enable the dashboard configuration for applications. false: disabled (consistent with the business system configuration); true: enabled (application-level configuration).
        /// </summary>
        [JsonProperty("EnableDashboardConfig")]
        public bool? EnableDashboardConfig{ get; set; }

        /// <summary>
        /// Whether to associate with Dashboard. 0: disabled; 1: enabled.
        /// </summary>
        [JsonProperty("IsRelatedDashboard")]
        public long? IsRelatedDashboard{ get; set; }

        /// <summary>
        /// dashboard ID
        /// </summary>
        [JsonProperty("DashboardTopicID")]
        public string DashboardTopicID{ get; set; }

        /// <summary>
        /// CLS index type. (0 = full-text index; 1 = key-value index).
        /// </summary>
        [JsonProperty("LogIndexType")]
        public long? LogIndexType{ get; set; }

        /// <summary>
        /// Index key of traceId. It is valid when the CLS index type is key-value index.
        /// </summary>
        [JsonProperty("LogTraceIdKey")]
        public string LogTraceIdKey{ get; set; }

        /// <summary>
        /// Whether to enable the application security configuration.
        /// </summary>
        [JsonProperty("EnableSecurityConfig")]
        public bool? EnableSecurityConfig{ get; set; }

        /// <summary>
        /// Whether to enable SQL injection analysis.
        /// </summary>
        [JsonProperty("IsSqlInjectionAnalysis")]
        public long? IsSqlInjectionAnalysis{ get; set; }

        /// <summary>
        /// Whether to enable detection of component vulnerability.
        /// </summary>
        [JsonProperty("IsInstrumentationVulnerabilityScan")]
        public long? IsInstrumentationVulnerabilityScan{ get; set; }

        /// <summary>
        /// Whether remote command detection is enabled.
        /// </summary>
        [JsonProperty("IsRemoteCommandExecutionAnalysis")]
        public long? IsRemoteCommandExecutionAnalysis{ get; set; }

        /// <summary>
        /// Whether to enable detection of Java webshell.
        /// </summary>
        [JsonProperty("IsMemoryHijackingAnalysis")]
        public long? IsMemoryHijackingAnalysis{ get; set; }

        /// <summary>
        /// Whether to enable the detection of deleting arbitrary files. (0 - disabled; 1: enabled.)
        /// </summary>
        [JsonProperty("IsDeleteAnyFileAnalysis")]
        public long? IsDeleteAnyFileAnalysis{ get; set; }

        /// <summary>
        /// Whether to enable the detection of reading arbitrary files. (0 - disabled; 1 - enabled.)
        /// </summary>
        [JsonProperty("IsReadAnyFileAnalysis")]
        public long? IsReadAnyFileAnalysis{ get; set; }

        /// <summary>
        /// Whether to enable the detection of uploading arbitrary files. (0 - disabled; 1 - enabled.)
        /// </summary>
        [JsonProperty("IsUploadAnyFileAnalysis")]
        public long? IsUploadAnyFileAnalysis{ get; set; }

        /// <summary>
        /// Whether to enable the detection of the inclusion of arbitrary files. (0: disabled, 1: enabled.)
        /// </summary>
        [JsonProperty("IsIncludeAnyFileAnalysis")]
        public long? IsIncludeAnyFileAnalysis{ get; set; }

        /// <summary>
        /// Whether to enable traversal detection of the directory. (0 - disabled; 1 - enabled).
        /// </summary>
        [JsonProperty("IsDirectoryTraversalAnalysis")]
        public long? IsDirectoryTraversalAnalysis{ get; set; }

        /// <summary>
        /// Whether to enable template engine injection detection. (0: disabled; 1: enabled.)
        /// </summary>
        [JsonProperty("IsTemplateEngineInjectionAnalysis")]
        public long? IsTemplateEngineInjectionAnalysis{ get; set; }

        /// <summary>
        /// Whether to enable script engine injection detection. (0 - disabled; 1 - enabled.)
        /// </summary>
        [JsonProperty("IsScriptEngineInjectionAnalysis")]
        public long? IsScriptEngineInjectionAnalysis{ get; set; }

        /// <summary>
        /// Whether to enable expression injection detection. (0 - disabled; 1 - enabled.)
        /// </summary>
        [JsonProperty("IsExpressionInjectionAnalysis")]
        public long? IsExpressionInjectionAnalysis{ get; set; }

        /// <summary>
        /// Whether to enable JNDI injection detection. (0 - disabled; 1 - enabled.)
        /// </summary>
        [JsonProperty("IsJNDIInjectionAnalysis")]
        public long? IsJNDIInjectionAnalysis{ get; set; }

        /// <summary>
        /// Whether to enable JNI injection detection. (0 - disabled, 1 - enabled).
        /// </summary>
        [JsonProperty("IsJNIInjectionAnalysis")]
        public long? IsJNIInjectionAnalysis{ get; set; }

        /// <summary>
        /// Whether to enable Webshell backdoor detection. (0 - disabled; 1 - enabled).
        /// </summary>
        [JsonProperty("IsWebshellBackdoorAnalysis")]
        public long? IsWebshellBackdoorAnalysis{ get; set; }

        /// <summary>
        /// Whether to enable deserialization detection. (0 - disabled; 1 - enabled).
        /// </summary>
        [JsonProperty("IsDeserializationAnalysis")]
        public long? IsDeserializationAnalysis{ get; set; }

        /// <summary>
        /// Automatic convergence switch for APIs. 0: disabled | 1: enabled.
        /// </summary>
        [JsonProperty("UrlAutoConvergenceEnable")]
        public bool? UrlAutoConvergenceEnable{ get; set; }

        /// <summary>
        /// Convergence threshold for URL long segments.
        /// </summary>
        [JsonProperty("UrlLongSegmentThreshold")]
        public long? UrlLongSegmentThreshold{ get; set; }

        /// <summary>
        /// Convergence threshold for URL numerical segments.
        /// </summary>
        [JsonProperty("UrlNumberSegmentThreshold")]
        public long? UrlNumberSegmentThreshold{ get; set; }

        /// <summary>
        /// Specifies the memory threshold for probe fusing.
        /// </summary>
        [JsonProperty("DisableMemoryUsed")]
        public long? DisableMemoryUsed{ get; set; }

        /// <summary>
        /// Specifies the CPU threshold for probe fusing.
        /// </summary>
        [JsonProperty("DisableCpuUsed")]
        public long? DisableCpuUsed{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "UrlConvergenceSwitch", this.UrlConvergenceSwitch);
            this.SetParamSimple(map, prefix + "UrlConvergenceThreshold", this.UrlConvergenceThreshold);
            this.SetParamSimple(map, prefix + "ExceptionFilter", this.ExceptionFilter);
            this.SetParamSimple(map, prefix + "UrlConvergence", this.UrlConvergence);
            this.SetParamSimple(map, prefix + "ErrorCodeFilter", this.ErrorCodeFilter);
            this.SetParamSimple(map, prefix + "UrlExclude", this.UrlExclude);
            this.SetParamSimple(map, prefix + "IsRelatedLog", this.IsRelatedLog);
            this.SetParamSimple(map, prefix + "LogRegion", this.LogRegion);
            this.SetParamSimple(map, prefix + "LogTopicID", this.LogTopicID);
            this.SetParamSimple(map, prefix + "LogSet", this.LogSet);
            this.SetParamSimple(map, prefix + "LogSource", this.LogSource);
            this.SetParamSimple(map, prefix + "IgnoreOperationName", this.IgnoreOperationName);
            this.SetParamSimple(map, prefix + "EnableSnapshot", this.EnableSnapshot);
            this.SetParamSimple(map, prefix + "SnapshotTimeout", this.SnapshotTimeout);
            this.SetParamSimple(map, prefix + "AgentEnable", this.AgentEnable);
            this.SetParamSimple(map, prefix + "TraceSquash", this.TraceSquash);
            this.SetParamSimple(map, prefix + "EventEnable", this.EventEnable);
            this.SetParamArrayObj(map, prefix + "InstrumentList.", this.InstrumentList);
            this.SetParamObj(map, prefix + "AgentOperationConfigView.", this.AgentOperationConfigView);
            this.SetParamSimple(map, prefix + "EnableLogConfig", this.EnableLogConfig);
            this.SetParamSimple(map, prefix + "EnableDashboardConfig", this.EnableDashboardConfig);
            this.SetParamSimple(map, prefix + "IsRelatedDashboard", this.IsRelatedDashboard);
            this.SetParamSimple(map, prefix + "DashboardTopicID", this.DashboardTopicID);
            this.SetParamSimple(map, prefix + "LogIndexType", this.LogIndexType);
            this.SetParamSimple(map, prefix + "LogTraceIdKey", this.LogTraceIdKey);
            this.SetParamSimple(map, prefix + "EnableSecurityConfig", this.EnableSecurityConfig);
            this.SetParamSimple(map, prefix + "IsSqlInjectionAnalysis", this.IsSqlInjectionAnalysis);
            this.SetParamSimple(map, prefix + "IsInstrumentationVulnerabilityScan", this.IsInstrumentationVulnerabilityScan);
            this.SetParamSimple(map, prefix + "IsRemoteCommandExecutionAnalysis", this.IsRemoteCommandExecutionAnalysis);
            this.SetParamSimple(map, prefix + "IsMemoryHijackingAnalysis", this.IsMemoryHijackingAnalysis);
            this.SetParamSimple(map, prefix + "IsDeleteAnyFileAnalysis", this.IsDeleteAnyFileAnalysis);
            this.SetParamSimple(map, prefix + "IsReadAnyFileAnalysis", this.IsReadAnyFileAnalysis);
            this.SetParamSimple(map, prefix + "IsUploadAnyFileAnalysis", this.IsUploadAnyFileAnalysis);
            this.SetParamSimple(map, prefix + "IsIncludeAnyFileAnalysis", this.IsIncludeAnyFileAnalysis);
            this.SetParamSimple(map, prefix + "IsDirectoryTraversalAnalysis", this.IsDirectoryTraversalAnalysis);
            this.SetParamSimple(map, prefix + "IsTemplateEngineInjectionAnalysis", this.IsTemplateEngineInjectionAnalysis);
            this.SetParamSimple(map, prefix + "IsScriptEngineInjectionAnalysis", this.IsScriptEngineInjectionAnalysis);
            this.SetParamSimple(map, prefix + "IsExpressionInjectionAnalysis", this.IsExpressionInjectionAnalysis);
            this.SetParamSimple(map, prefix + "IsJNDIInjectionAnalysis", this.IsJNDIInjectionAnalysis);
            this.SetParamSimple(map, prefix + "IsJNIInjectionAnalysis", this.IsJNIInjectionAnalysis);
            this.SetParamSimple(map, prefix + "IsWebshellBackdoorAnalysis", this.IsWebshellBackdoorAnalysis);
            this.SetParamSimple(map, prefix + "IsDeserializationAnalysis", this.IsDeserializationAnalysis);
            this.SetParamSimple(map, prefix + "UrlAutoConvergenceEnable", this.UrlAutoConvergenceEnable);
            this.SetParamSimple(map, prefix + "UrlLongSegmentThreshold", this.UrlLongSegmentThreshold);
            this.SetParamSimple(map, prefix + "UrlNumberSegmentThreshold", this.UrlNumberSegmentThreshold);
            this.SetParamSimple(map, prefix + "DisableMemoryUsed", this.DisableMemoryUsed);
            this.SetParamSimple(map, prefix + "DisableCpuUsed", this.DisableCpuUsed);
        }
    }
}

