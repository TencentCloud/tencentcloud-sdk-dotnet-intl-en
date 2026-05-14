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

    public class ApmApplicationConfigView : AbstractModel
    {
        
        /// <summary>
        /// <p>Business system ID</p>
        /// </summary>
        [JsonProperty("InstanceKey")]
        public string InstanceKey{ get; set; }

        /// <summary>
        /// <p>Application name</p>
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// <p>Interface Filtering</p>
        /// </summary>
        [JsonProperty("OperationNameFilter")]
        public string OperationNameFilter{ get; set; }

        /// <summary>
        /// <p>Error type filtering</p>
        /// </summary>
        [JsonProperty("ExceptionFilter")]
        public string ExceptionFilter{ get; set; }

        /// <summary>
        /// <p>HTTP status code filtering</p>
        /// </summary>
        [JsonProperty("ErrorCodeFilter")]
        public string ErrorCodeFilter{ get; set; }

        /// <summary>
        /// <p>Application diagnosis switch (abandoned)</p>
        /// </summary>
        [JsonProperty("EventEnable")]
        public bool? EventEnable{ get; set; }

        /// <summary>
        /// <p>URL convergence switch 0 Off 1 On</p>
        /// </summary>
        [JsonProperty("UrlConvergenceSwitch")]
        public long? UrlConvergenceSwitch{ get; set; }

        /// <summary>
        /// <p>URL convergence threshold</p>
        /// </summary>
        [JsonProperty("UrlConvergenceThreshold")]
        public long? UrlConvergenceThreshold{ get; set; }

        /// <summary>
        /// <p>URL regular convergence rules</p>
        /// </summary>
        [JsonProperty("UrlConvergence")]
        public string UrlConvergence{ get; set; }

        /// <summary>
        /// <p>URL exclusion rule regex</p>
        /// </summary>
        [JsonProperty("UrlExclude")]
        public string UrlExclude{ get; set; }

        /// <summary>
        /// <p>Whether logging is enabled 0 Disabled 1 Enabled</p>
        /// </summary>
        [JsonProperty("IsRelatedLog")]
        public long? IsRelatedLog{ get; set; }

        /// <summary>
        /// <p>Log source</p>
        /// </summary>
        [JsonProperty("LogSource")]
        public string LogSource{ get; set; }

        /// <summary>
        /// <p>Logset</p>
        /// </summary>
        [JsonProperty("LogSet")]
        public string LogSet{ get; set; }

        /// <summary>
        /// <p>Log topic</p>
        /// </summary>
        [JsonProperty("LogTopicID")]
        public string LogTopicID{ get; set; }

        /// <summary>
        /// <p>Method stack snapshot switch. Enabled indicates true. false indicates disabled.</p>
        /// </summary>
        [JsonProperty("SnapshotEnable")]
        public bool? SnapshotEnable{ get; set; }

        /// <summary>
        /// <p>Slow call monitoring trigger threshold</p>
        /// </summary>
        [JsonProperty("SnapshotTimeout")]
        public long? SnapshotTimeout{ get; set; }

        /// <summary>
        /// <p>Master switch for probes</p>
        /// </summary>
        [JsonProperty("AgentEnable")]
        public bool? AgentEnable{ get; set; }

        /// <summary>
        /// <p>Component list toggle (abandoned)</p>
        /// </summary>
        [JsonProperty("InstrumentList")]
        public Instrument[] InstrumentList{ get; set; }

        /// <summary>
        /// <p>Link compression switch (abandoned)</p>
        /// </summary>
        [JsonProperty("TraceSquash")]
        public bool? TraceSquash{ get; set; }

        /// <summary>
        /// <p>Link filtering configuration</p>
        /// </summary>
        [JsonProperty("AgentIgnoreOperation")]
        public string AgentIgnoreOperation{ get; set; }

        /// <summary>
        /// <p>Enable the application security switch</p>
        /// </summary>
        [JsonProperty("EnableSecurityConfig")]
        public bool? EnableSecurityConfig{ get; set; }

        /// <summary>
        /// <p>Whether SQL injection detection is enabled</p>
        /// </summary>
        [JsonProperty("IsSqlInjectionAnalysis")]
        public long? IsSqlInjectionAnalysis{ get; set; }

        /// <summary>
        /// <p>Whether component vulnerability detection is enabled</p>
        /// </summary>
        [JsonProperty("IsInstrumentationVulnerabilityScan")]
        public long? IsInstrumentationVulnerabilityScan{ get; set; }

        /// <summary>
        /// <p>Whether remote command execution detection is enabled</p>
        /// </summary>
        [JsonProperty("IsRemoteCommandExecutionAnalysis")]
        public long? IsRemoteCommandExecutionAnalysis{ get; set; }

        /// <summary>
        /// <p>Whether memory leakage detection is enabled</p>
        /// </summary>
        [JsonProperty("IsMemoryHijackingAnalysis")]
        public long? IsMemoryHijackingAnalysis{ get; set; }

        /// <summary>
        /// <p>Whether to enable detection of any file deletion</p>
        /// </summary>
        [JsonProperty("IsDeleteAnyFileAnalysis")]
        public long? IsDeleteAnyFileAnalysis{ get; set; }

        /// <summary>
        /// <p>Whether to enable arbitrary file read detection</p>
        /// </summary>
        [JsonProperty("IsReadAnyFileAnalysis")]
        public long? IsReadAnyFileAnalysis{ get; set; }

        /// <summary>
        /// <p>Whether to enable arbitrary file upload detection</p>
        /// </summary>
        [JsonProperty("IsUploadAnyFileAnalysis")]
        public long? IsUploadAnyFileAnalysis{ get; set; }

        /// <summary>
        /// <p>Whether to enable detection of arbitrary files</p>
        /// </summary>
        [JsonProperty("IsIncludeAnyFileAnalysis")]
        public long? IsIncludeAnyFileAnalysis{ get; set; }

        /// <summary>
        /// <p>Whether path traversal detection is enabled</p>
        /// </summary>
        [JsonProperty("IsDirectoryTraversalAnalysis")]
        public long? IsDirectoryTraversalAnalysis{ get; set; }

        /// <summary>
        /// <p>Whether to enable template engine injection detection</p>
        /// </summary>
        [JsonProperty("IsTemplateEngineInjectionAnalysis")]
        public long? IsTemplateEngineInjectionAnalysis{ get; set; }

        /// <summary>
        /// <p>Whether script engine injection detection is enabled</p>
        /// </summary>
        [JsonProperty("IsScriptEngineInjectionAnalysis")]
        public long? IsScriptEngineInjectionAnalysis{ get; set; }

        /// <summary>
        /// <p>Whether expression injection detection is enabled</p>
        /// </summary>
        [JsonProperty("IsExpressionInjectionAnalysis")]
        public long? IsExpressionInjectionAnalysis{ get; set; }

        /// <summary>
        /// <p>Whether JNDI injection detection is enabled</p>
        /// </summary>
        [JsonProperty("IsJndiInjectionAnalysis")]
        public long? IsJndiInjectionAnalysis{ get; set; }

        /// <summary>
        /// <p>Whether JNI injection detection is enabled</p>
        /// </summary>
        [JsonProperty("IsJniInjectionAnalysis")]
        public long? IsJniInjectionAnalysis{ get; set; }

        /// <summary>
        /// <p>Whether Webshell backdoor detection is enabled</p>
        /// </summary>
        [JsonProperty("IsWebshellBackdoorAnalysis")]
        public long? IsWebshellBackdoorAnalysis{ get; set; }

        /// <summary>
        /// <p>Whether deserialization detection is enabled</p>
        /// </summary>
        [JsonProperty("IsDeserializationAnalysis")]
        public long? IsDeserializationAnalysis{ get; set; }

        /// <summary>
        /// <p>Whether the console switch is enabled</p>
        /// </summary>
        [JsonProperty("EnableDashboardConfig")]
        public bool? EnableDashboardConfig{ get; set; }

        /// <summary>
        /// <p>Whether to associate with Dashboard</p>
        /// </summary>
        [JsonProperty("IsRelatedDashboard")]
        public long? IsRelatedDashboard{ get; set; }

        /// <summary>
        /// <p>Dashboard topic</p>
        /// </summary>
        [JsonProperty("DashboardTopicID")]
        public string DashboardTopicID{ get; set; }

        /// <summary>
        /// <p>Fuse memory threshold of the probe</p>
        /// </summary>
        [JsonProperty("DisableMemoryUsed")]
        public long? DisableMemoryUsed{ get; set; }

        /// <summary>
        /// <p>Probe fuse CPU threshold</p>
        /// </summary>
        [JsonProperty("DisableCpuUsed")]
        public long? DisableCpuUsed{ get; set; }

        /// <summary>
        /// <p>Whether SQL parameter access is enabled</p>
        /// </summary>
        [JsonProperty("DbStatementParametersEnabled")]
        public bool? DbStatementParametersEnabled{ get; set; }

        /// <summary>
        /// <p>Slow SQL threshold</p>
        /// </summary>
        [JsonProperty("SlowSQLThresholds")]
        public ApmTag[] SlowSQLThresholds{ get; set; }

        /// <summary>
        /// <p>Whether the masking rule is enabled</p>
        /// </summary>
        [JsonProperty("EnableDesensitizationRule")]
        public long? EnableDesensitizationRule{ get; set; }

        /// <summary>
        /// <p>Masking rule</p>
        /// </summary>
        [JsonProperty("DesensitizationRule")]
        public string DesensitizationRule{ get; set; }

        /// <summary>
        /// <p>Automated performance analysis task configuration</p>
        /// </summary>
        [JsonProperty("AutoProfilingConfig")]
        public AutoProfilingConfig AutoProfilingConfig{ get; set; }

        /// <summary>
        /// <p>Threshold configuration switch</p>
        /// </summary>
        [JsonProperty("EnableThresholdConfig")]
        public bool? EnableThresholdConfig{ get; set; }

        /// <summary>
        /// <p>Error rate threshold</p><p>Unit: %</p>
        /// </summary>
        [JsonProperty("ErrRateThreshold")]
        public long? ErrRateThreshold{ get; set; }

        /// <summary>
        /// <p>Alert threshold of response time</p><p>Unit: ms</p>
        /// </summary>
        [JsonProperty("ResponseDurationWarningThreshold")]
        public long? ResponseDurationWarningThreshold{ get; set; }

        /// <summary>
        /// <p>Whether to use the default fuse threshold of the probe</p>
        /// </summary>
        [JsonProperty("UseDefaultFuseConfig")]
        public bool? UseDefaultFuseConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceKey", this.InstanceKey);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "OperationNameFilter", this.OperationNameFilter);
            this.SetParamSimple(map, prefix + "ExceptionFilter", this.ExceptionFilter);
            this.SetParamSimple(map, prefix + "ErrorCodeFilter", this.ErrorCodeFilter);
            this.SetParamSimple(map, prefix + "EventEnable", this.EventEnable);
            this.SetParamSimple(map, prefix + "UrlConvergenceSwitch", this.UrlConvergenceSwitch);
            this.SetParamSimple(map, prefix + "UrlConvergenceThreshold", this.UrlConvergenceThreshold);
            this.SetParamSimple(map, prefix + "UrlConvergence", this.UrlConvergence);
            this.SetParamSimple(map, prefix + "UrlExclude", this.UrlExclude);
            this.SetParamSimple(map, prefix + "IsRelatedLog", this.IsRelatedLog);
            this.SetParamSimple(map, prefix + "LogSource", this.LogSource);
            this.SetParamSimple(map, prefix + "LogSet", this.LogSet);
            this.SetParamSimple(map, prefix + "LogTopicID", this.LogTopicID);
            this.SetParamSimple(map, prefix + "SnapshotEnable", this.SnapshotEnable);
            this.SetParamSimple(map, prefix + "SnapshotTimeout", this.SnapshotTimeout);
            this.SetParamSimple(map, prefix + "AgentEnable", this.AgentEnable);
            this.SetParamArrayObj(map, prefix + "InstrumentList.", this.InstrumentList);
            this.SetParamSimple(map, prefix + "TraceSquash", this.TraceSquash);
            this.SetParamSimple(map, prefix + "AgentIgnoreOperation", this.AgentIgnoreOperation);
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
            this.SetParamSimple(map, prefix + "IsJndiInjectionAnalysis", this.IsJndiInjectionAnalysis);
            this.SetParamSimple(map, prefix + "IsJniInjectionAnalysis", this.IsJniInjectionAnalysis);
            this.SetParamSimple(map, prefix + "IsWebshellBackdoorAnalysis", this.IsWebshellBackdoorAnalysis);
            this.SetParamSimple(map, prefix + "IsDeserializationAnalysis", this.IsDeserializationAnalysis);
            this.SetParamSimple(map, prefix + "EnableDashboardConfig", this.EnableDashboardConfig);
            this.SetParamSimple(map, prefix + "IsRelatedDashboard", this.IsRelatedDashboard);
            this.SetParamSimple(map, prefix + "DashboardTopicID", this.DashboardTopicID);
            this.SetParamSimple(map, prefix + "DisableMemoryUsed", this.DisableMemoryUsed);
            this.SetParamSimple(map, prefix + "DisableCpuUsed", this.DisableCpuUsed);
            this.SetParamSimple(map, prefix + "DbStatementParametersEnabled", this.DbStatementParametersEnabled);
            this.SetParamArrayObj(map, prefix + "SlowSQLThresholds.", this.SlowSQLThresholds);
            this.SetParamSimple(map, prefix + "EnableDesensitizationRule", this.EnableDesensitizationRule);
            this.SetParamSimple(map, prefix + "DesensitizationRule", this.DesensitizationRule);
            this.SetParamObj(map, prefix + "AutoProfilingConfig.", this.AutoProfilingConfig);
            this.SetParamSimple(map, prefix + "EnableThresholdConfig", this.EnableThresholdConfig);
            this.SetParamSimple(map, prefix + "ErrRateThreshold", this.ErrRateThreshold);
            this.SetParamSimple(map, prefix + "ResponseDurationWarningThreshold", this.ResponseDurationWarningThreshold);
            this.SetParamSimple(map, prefix + "UseDefaultFuseConfig", this.UseDefaultFuseConfig);
        }
    }
}

