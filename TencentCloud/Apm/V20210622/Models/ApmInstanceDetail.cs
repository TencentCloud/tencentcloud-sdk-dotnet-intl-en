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

    public class ApmInstanceDetail : AbstractModel
    {
        
        /// <summary>
        /// Business system id.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Business system name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Business system description information.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Status of the business system.
        /// {Initializing; running; throttling}.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Region where the business system belongs.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Business system tag list.
        /// </summary>
        [JsonProperty("Tags")]
        public ApmTag[] Tags{ get; set; }

        /// <summary>
        /// AppID information.
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// Creator uin.
        /// </summary>
        [JsonProperty("CreateUin")]
        public string CreateUin{ get; set; }

        /// <summary>
        /// Storage used (unit: mb).
        /// </summary>
        [JsonProperty("AmountOfUsedStorage")]
        public float? AmountOfUsedStorage{ get; set; }

        /// <summary>
        /// Quantity of server applications of the business system.
        /// </summary>
        [JsonProperty("ServiceCount")]
        public long? ServiceCount{ get; set; }

        /// <summary>
        /// Average daily reported span count.
        /// </summary>
        [JsonProperty("CountOfReportSpanPerDay")]
        public long? CountOfReportSpanPerDay{ get; set; }

        /// <summary>
        /// Retention period of trace data (unit: days).
        /// </summary>
        [JsonProperty("TraceDuration")]
        public long? TraceDuration{ get; set; }

        /// <summary>
        /// Business system report limit.
        /// </summary>
        [JsonProperty("SpanDailyCounters")]
        public long? SpanDailyCounters{ get; set; }

        /// <summary>
        /// Whether the business system billing is Activated (0 = not activated, 1 = activated).
        /// </summary>
        [JsonProperty("BillingInstance")]
        public long? BillingInstance{ get; set; }

        /// <summary>
        /// Error warning line (unit: %).
        /// </summary>
        [JsonProperty("ErrRateThreshold")]
        public long? ErrRateThreshold{ get; set; }

        /// <summary>
        /// Sampling rate (unit: %).
        /// </summary>
        [JsonProperty("SampleRate")]
        public long? SampleRate{ get; set; }

        /// <summary>
        /// Error sampling switch (0: off, 1: on).
        /// </summary>
        [JsonProperty("ErrorSample")]
        public long? ErrorSample{ get; set; }

        /// <summary>
        /// Sampling slow call saving threshold (unit: ms).
        /// </summary>
        [JsonProperty("SlowRequestSavedThreshold")]
        public long? SlowRequestSavedThreshold{ get; set; }

        /// <summary>
        /// CLS log region.
        /// </summary>
        [JsonProperty("LogRegion")]
        public string LogRegion{ get; set; }

        /// <summary>
        /// Log source.
        /// </summary>
        [JsonProperty("LogSource")]
        public string LogSource{ get; set; }

        /// <summary>
        /// Log feature switch (0: off; 1: on).
        /// </summary>
        [JsonProperty("IsRelatedLog")]
        public long? IsRelatedLog{ get; set; }

        /// <summary>
        /// Log topic id.
        /// </summary>
        [JsonProperty("LogTopicID")]
        public string LogTopicID{ get; set; }

        /// <summary>
        /// Quantity of client applications of the business system.
        /// </summary>
        [JsonProperty("ClientCount")]
        public long? ClientCount{ get; set; }

        /// <summary>
        /// The quantity of active applications in this business system in the last two days.
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// CLS log set.
        /// </summary>
        [JsonProperty("LogSet")]
        public string LogSet{ get; set; }

        /// <summary>
        /// Retention period of metric data (unit: days).
        /// </summary>
        [JsonProperty("MetricDuration")]
        public long? MetricDuration{ get; set; }

        /// <summary>
        /// List of custom display tags.
        /// </summary>
        [JsonProperty("CustomShowTags")]
        public string[] CustomShowTags{ get; set; }

        /// <summary>
        /// Business system billing mode (1: prepaid, 0: pay-as-you-go).
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// Indicates whether the billing mode of the business system takes effect.
        /// </summary>
        [JsonProperty("PayModeEffective")]
        public bool? PayModeEffective{ get; set; }

        /// <summary>
        /// Response time warning line (unit: ms).
        /// </summary>
        [JsonProperty("ResponseDurationWarningThreshold")]
        public long? ResponseDurationWarningThreshold{ get; set; }

        /// <summary>
        /// Whether it is free (0 = no; 1 = limited free; 2 = completely free), default 0.
        /// </summary>
        [JsonProperty("Free")]
        public long? Free{ get; set; }

        /// <summary>
        /// Indicates whether it is the default business system of tsf (0 = no, 1 = yes).
        /// </summary>
        [JsonProperty("DefaultTSF")]
        public long? DefaultTSF{ get; set; }

        /// <summary>
        /// Whether to associate the dashboard (0 = off, 1 = on).
        /// </summary>
        [JsonProperty("IsRelatedDashboard")]
        public long? IsRelatedDashboard{ get; set; }

        /// <summary>
        /// Associated dashboard id.
        /// </summary>
        [JsonProperty("DashboardTopicID")]
        public string DashboardTopicID{ get; set; }

        /// <summary>
        /// Whether to enable component vulnerability detection (0 = no, 1 = yes).
        /// </summary>
        [JsonProperty("IsInstrumentationVulnerabilityScan")]
        public long? IsInstrumentationVulnerabilityScan{ get; set; }

        /// <summary>
        /// Whether to enable sql injection analysis (0: off, 1: on).
        /// </summary>
        [JsonProperty("IsSqlInjectionAnalysis")]
        public long? IsSqlInjectionAnalysis{ get; set; }

        /// <summary>
        /// Reasons for traffic throttling.
        /// Official version quota;.
        /// Trial version quota.
        /// Trial version expiration;.
        /// Account in arrears.
        /// }.
        /// </summary>
        [JsonProperty("StopReason")]
        public long? StopReason{ get; set; }

        /// <summary>
        /// Whether to enable detection of remote command execution (0 = disabled; 1 = enabled).
        /// </summary>
        [JsonProperty("IsRemoteCommandExecutionAnalysis")]
        public long? IsRemoteCommandExecutionAnalysis{ get; set; }

        /// <summary>
        /// Whether to enable detection of Java webshell execution (0 = disabled; 1 = enabled).
        /// </summary>
        [JsonProperty("IsMemoryHijackingAnalysis")]
        public long? IsMemoryHijackingAnalysis{ get; set; }

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
        /// Business system authentication token.
        /// </summary>
        [JsonProperty("Token")]
        public string Token{ get; set; }

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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "CreateUin", this.CreateUin);
            this.SetParamSimple(map, prefix + "AmountOfUsedStorage", this.AmountOfUsedStorage);
            this.SetParamSimple(map, prefix + "ServiceCount", this.ServiceCount);
            this.SetParamSimple(map, prefix + "CountOfReportSpanPerDay", this.CountOfReportSpanPerDay);
            this.SetParamSimple(map, prefix + "TraceDuration", this.TraceDuration);
            this.SetParamSimple(map, prefix + "SpanDailyCounters", this.SpanDailyCounters);
            this.SetParamSimple(map, prefix + "BillingInstance", this.BillingInstance);
            this.SetParamSimple(map, prefix + "ErrRateThreshold", this.ErrRateThreshold);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "ErrorSample", this.ErrorSample);
            this.SetParamSimple(map, prefix + "SlowRequestSavedThreshold", this.SlowRequestSavedThreshold);
            this.SetParamSimple(map, prefix + "LogRegion", this.LogRegion);
            this.SetParamSimple(map, prefix + "LogSource", this.LogSource);
            this.SetParamSimple(map, prefix + "IsRelatedLog", this.IsRelatedLog);
            this.SetParamSimple(map, prefix + "LogTopicID", this.LogTopicID);
            this.SetParamSimple(map, prefix + "ClientCount", this.ClientCount);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "LogSet", this.LogSet);
            this.SetParamSimple(map, prefix + "MetricDuration", this.MetricDuration);
            this.SetParamArraySimple(map, prefix + "CustomShowTags.", this.CustomShowTags);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "PayModeEffective", this.PayModeEffective);
            this.SetParamSimple(map, prefix + "ResponseDurationWarningThreshold", this.ResponseDurationWarningThreshold);
            this.SetParamSimple(map, prefix + "Free", this.Free);
            this.SetParamSimple(map, prefix + "DefaultTSF", this.DefaultTSF);
            this.SetParamSimple(map, prefix + "IsRelatedDashboard", this.IsRelatedDashboard);
            this.SetParamSimple(map, prefix + "DashboardTopicID", this.DashboardTopicID);
            this.SetParamSimple(map, prefix + "IsInstrumentationVulnerabilityScan", this.IsInstrumentationVulnerabilityScan);
            this.SetParamSimple(map, prefix + "IsSqlInjectionAnalysis", this.IsSqlInjectionAnalysis);
            this.SetParamSimple(map, prefix + "StopReason", this.StopReason);
            this.SetParamSimple(map, prefix + "IsRemoteCommandExecutionAnalysis", this.IsRemoteCommandExecutionAnalysis);
            this.SetParamSimple(map, prefix + "IsMemoryHijackingAnalysis", this.IsMemoryHijackingAnalysis);
            this.SetParamSimple(map, prefix + "LogIndexType", this.LogIndexType);
            this.SetParamSimple(map, prefix + "LogTraceIdKey", this.LogTraceIdKey);
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
            this.SetParamSimple(map, prefix + "Token", this.Token);
            this.SetParamSimple(map, prefix + "UrlLongSegmentThreshold", this.UrlLongSegmentThreshold);
            this.SetParamSimple(map, prefix + "UrlNumberSegmentThreshold", this.UrlNumberSegmentThreshold);
        }
    }
}

