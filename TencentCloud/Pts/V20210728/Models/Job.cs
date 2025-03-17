/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Job : AbstractModel
    {
        
        /// <summary>
        /// Job ID.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// Scenario ID.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ScenarioId")]
        public string ScenarioId{ get; set; }

        /// <summary>
        /// Load configuration.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Load")]
        public Load Load{ get; set; }

        /// <summary>
        /// Deprecated.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Configs")]
        public string[] Configs{ get; set; }

        /// <summary>
        /// Test datasets.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Datasets")]
        public TestData[] Datasets{ get; set; }

        /// <summary>
        /// Deprecated.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Extensions")]
        public string[] Extensions{ get; set; }

        /// <summary>
        /// Job status, values including:
        /// JobUnknown: 0, JobCreated: 1, JobPending: 2, JobPreparing: 3, JobSelectClustering: 4, JobCreateTasking: 5, JobSyncTasking: 6,
        /// JobRunning:11,JobFinished:12,JobPrepareException:13,JobFinishException:14,JobAborting:15,JobAborted:16,JobAbortException:17,JobDeleted:18,
        /// JobSelectClusterException:19,JobCreateTaskException:20,JobSyncTaskException:21
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Start time.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Maximum VU.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("MaxVirtualUserCount")]
        public long? MaxVirtualUserCount{ get; set; }

        /// <summary>
        /// Note.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// Error rate percentage.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ErrorRate")]
        public float? ErrorRate{ get; set; }

        /// <summary>
        /// Job owner.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("JobOwner")]
        public string JobOwner{ get; set; }

        /// <summary>
        /// Deprecated.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("LoadSources")]
        public LoadSource LoadSources{ get; set; }

        /// <summary>
        /// Job duration.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// Maximum requests per second.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("MaxRequestsPerSecond")]
        public long? MaxRequestsPerSecond{ get; set; }

        /// <summary>
        /// Total number of requests.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("RequestTotal")]
        public float? RequestTotal{ get; set; }

        /// <summary>
        /// Average requests per second.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("RequestsPerSecond")]
        public float? RequestsPerSecond{ get; set; }

        /// <summary>
        /// Average response time.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ResponseTimeAverage")]
        public float? ResponseTimeAverage{ get; set; }

        /// <summary>
        /// 99th percentile response time.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ResponseTimeP99")]
        public float? ResponseTimeP99{ get; set; }

        /// <summary>
        /// 95th percentile response time.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ResponseTimeP95")]
        public float? ResponseTimeP95{ get; set; }

        /// <summary>
        /// 90th percentile response time.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ResponseTimeP90")]
        public float? ResponseTimeP90{ get; set; }

        /// <summary>
        /// Deprecated.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Scripts")]
        public string[] Scripts{ get; set; }

        /// <summary>
        /// Maximum response time.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ResponseTimeMax")]
        public float? ResponseTimeMax{ get; set; }

        /// <summary>
        /// Minimum response time.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ResponseTimeMin")]
        public float? ResponseTimeMin{ get; set; }

        /// <summary>
        /// Stress machine information.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("LoadSourceInfos")]
        public LoadSource[] LoadSourceInfos{ get; set; }

        /// <summary>
        /// Test script information.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("TestScripts")]
        public ScriptInfo[] TestScripts{ get; set; }

        /// <summary>
        /// Protocol file information.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Protocols")]
        public ProtocolInfo[] Protocols{ get; set; }

        /// <summary>
        /// Request file information.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("RequestFiles")]
        public FileInfo[] RequestFiles{ get; set; }

        /// <summary>
        /// Extension file information.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Plugins")]
        public FileInfo[] Plugins{ get; set; }

        /// <summary>
        /// Cron job ID.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("CronId")]
        public string CronId{ get; set; }

        /// <summary>
        /// Scenario type.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Domain binding configuration.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("DomainNameConfig")]
        public DomainNameConfig DomainNameConfig{ get; set; }

        /// <summary>
        /// Whether the job is a debug job.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Debug")]
        public bool? Debug{ get; set; }

        /// <summary>
        /// Abort reason.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("AbortReason")]
        public long? AbortReason{ get; set; }

        /// <summary>
        /// Create Time.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// Project ID.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Notification event callback.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("NotificationHooks")]
        public NotificationHook[] NotificationHooks{ get; set; }

        /// <summary>
        /// Bytes received per second.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("NetworkReceiveRate")]
        public float? NetworkReceiveRate{ get; set; }

        /// <summary>
        /// Bytes sent per second.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("NetworkSendRate")]
        public float? NetworkSendRate{ get; set; }

        /// <summary>
        /// Job status description.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Project name.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// Scenario name.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ScenarioName")]
        public string ScenarioName{ get; set; }

        /// <summary>
        /// Billing type.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// Job VUM usage.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Usage")]
        public long? Usage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "ScenarioId", this.ScenarioId);
            this.SetParamObj(map, prefix + "Load.", this.Load);
            this.SetParamArraySimple(map, prefix + "Configs.", this.Configs);
            this.SetParamArrayObj(map, prefix + "Datasets.", this.Datasets);
            this.SetParamArraySimple(map, prefix + "Extensions.", this.Extensions);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "MaxVirtualUserCount", this.MaxVirtualUserCount);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamSimple(map, prefix + "ErrorRate", this.ErrorRate);
            this.SetParamSimple(map, prefix + "JobOwner", this.JobOwner);
            this.SetParamObj(map, prefix + "LoadSources.", this.LoadSources);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "MaxRequestsPerSecond", this.MaxRequestsPerSecond);
            this.SetParamSimple(map, prefix + "RequestTotal", this.RequestTotal);
            this.SetParamSimple(map, prefix + "RequestsPerSecond", this.RequestsPerSecond);
            this.SetParamSimple(map, prefix + "ResponseTimeAverage", this.ResponseTimeAverage);
            this.SetParamSimple(map, prefix + "ResponseTimeP99", this.ResponseTimeP99);
            this.SetParamSimple(map, prefix + "ResponseTimeP95", this.ResponseTimeP95);
            this.SetParamSimple(map, prefix + "ResponseTimeP90", this.ResponseTimeP90);
            this.SetParamArraySimple(map, prefix + "Scripts.", this.Scripts);
            this.SetParamSimple(map, prefix + "ResponseTimeMax", this.ResponseTimeMax);
            this.SetParamSimple(map, prefix + "ResponseTimeMin", this.ResponseTimeMin);
            this.SetParamArrayObj(map, prefix + "LoadSourceInfos.", this.LoadSourceInfos);
            this.SetParamArrayObj(map, prefix + "TestScripts.", this.TestScripts);
            this.SetParamArrayObj(map, prefix + "Protocols.", this.Protocols);
            this.SetParamArrayObj(map, prefix + "RequestFiles.", this.RequestFiles);
            this.SetParamArrayObj(map, prefix + "Plugins.", this.Plugins);
            this.SetParamSimple(map, prefix + "CronId", this.CronId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "DomainNameConfig.", this.DomainNameConfig);
            this.SetParamSimple(map, prefix + "Debug", this.Debug);
            this.SetParamSimple(map, prefix + "AbortReason", this.AbortReason);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArrayObj(map, prefix + "NotificationHooks.", this.NotificationHooks);
            this.SetParamSimple(map, prefix + "NetworkReceiveRate", this.NetworkReceiveRate);
            this.SetParamSimple(map, prefix + "NetworkSendRate", this.NetworkSendRate);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "ScenarioName", this.ScenarioName);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "Usage", this.Usage);
        }
    }
}

