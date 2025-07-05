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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Task : AbstractModel
    {
        
        /// <summary>
        /// Task ID
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }

        /// <summary>
        /// Task name
        /// </summary>
        [JsonProperty("TaskTitle")]
        public string TaskTitle{ get; set; }

        /// <summary>
        /// Task description
        /// </summary>
        [JsonProperty("TaskDescription")]
        public string TaskDescription{ get; set; }

        /// <summary>
        /// Custom tag
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskTag")]
        public string TaskTag{ get; set; }

        /// <summary>
        /// Task status. 1001: not started; 1002: in progress (executing); 1003: in progress (paused); 1004: execution ended.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskStatus")]
        public long? TaskStatus{ get; set; }

        /// <summary>
        /// Task end status, indicating the status of the task when it ends. 0: not ended; 1: successful; 2: failed; 3: terminated.
        /// </summary>
        [JsonProperty("TaskStatusType")]
        public long? TaskStatusType{ get; set; }

        /// <summary>
        /// Protection policy
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskProtectStrategy")]
        public string TaskProtectStrategy{ get; set; }

        /// <summary>
        /// Task creation time
        /// </summary>
        [JsonProperty("TaskCreateTime")]
        public string TaskCreateTime{ get; set; }

        /// <summary>
        /// Task update time
        /// </summary>
        [JsonProperty("TaskUpdateTime")]
        public string TaskUpdateTime{ get; set; }

        /// <summary>
        /// Task action group
        /// </summary>
        [JsonProperty("TaskGroups")]
        public TaskGroup[] TaskGroups{ get; set; }

        /// <summary>
        /// Start time
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskStartTime")]
        public string TaskStartTime{ get; set; }

        /// <summary>
        /// End time
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskEndTime")]
        public string TaskEndTime{ get; set; }

        /// <summary>
        /// Whether expectations are met. 1: expectations met; 2: expectations not met.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskExpect")]
        public long? TaskExpect{ get; set; }

        /// <summary>
        /// Experiment record
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskSummary")]
        public string TaskSummary{ get; set; }

        /// <summary>
        /// Task mode. 1: manual execution; 2: automatic execution.
        /// </summary>
        [JsonProperty("TaskMode")]
        public long? TaskMode{ get; set; }

        /// <summary>
        /// Automatic pause duration. Unit: minutes.
        /// </summary>
        [JsonProperty("TaskPauseDuration")]
        public long? TaskPauseDuration{ get; set; }

        /// <summary>
        /// Main account that creates the experiment
        /// </summary>
        [JsonProperty("TaskOwnerUin")]
        public string TaskOwnerUin{ get; set; }

        /// <summary>
        /// Region ID
        /// </summary>
        [JsonProperty("TaskRegionId")]
        public long? TaskRegionId{ get; set; }

        /// <summary>
        /// Monitoring metric list
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskMonitors")]
        public TaskMonitor[] TaskMonitors{ get; set; }

        /// <summary>
        /// Protection policy
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskPolicy")]
        public DescribePolicy TaskPolicy{ get; set; }

        /// <summary>
        /// Tag list
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public TagWithDescribe[] Tags{ get; set; }

        /// <summary>
        /// ID of the associated experiment plan
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskPlanId")]
        public long? TaskPlanId{ get; set; }

        /// <summary>
        /// Name of the associated experiment plan
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskPlanTitle")]
        public string TaskPlanTitle{ get; set; }

        /// <summary>
        /// ID of the associated application
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// Name of the associated application
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// Associated alarm metrics
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AlarmPolicy")]
        public string[] AlarmPolicy{ get; set; }

        /// <summary>
        /// Associated APM services
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApmServiceList")]
        public ApmServiceInfo[] ApmServiceList{ get; set; }

        /// <summary>
        /// ID of the associated threat verification item
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VerifyId")]
        public ulong? VerifyId{ get; set; }

        /// <summary>
        /// Guardrail processing method. 1: roll back sequentially; 2: pause experiment.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PolicyDealType")]
        public long? PolicyDealType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskTitle", this.TaskTitle);
            this.SetParamSimple(map, prefix + "TaskDescription", this.TaskDescription);
            this.SetParamSimple(map, prefix + "TaskTag", this.TaskTag);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "TaskStatusType", this.TaskStatusType);
            this.SetParamSimple(map, prefix + "TaskProtectStrategy", this.TaskProtectStrategy);
            this.SetParamSimple(map, prefix + "TaskCreateTime", this.TaskCreateTime);
            this.SetParamSimple(map, prefix + "TaskUpdateTime", this.TaskUpdateTime);
            this.SetParamArrayObj(map, prefix + "TaskGroups.", this.TaskGroups);
            this.SetParamSimple(map, prefix + "TaskStartTime", this.TaskStartTime);
            this.SetParamSimple(map, prefix + "TaskEndTime", this.TaskEndTime);
            this.SetParamSimple(map, prefix + "TaskExpect", this.TaskExpect);
            this.SetParamSimple(map, prefix + "TaskSummary", this.TaskSummary);
            this.SetParamSimple(map, prefix + "TaskMode", this.TaskMode);
            this.SetParamSimple(map, prefix + "TaskPauseDuration", this.TaskPauseDuration);
            this.SetParamSimple(map, prefix + "TaskOwnerUin", this.TaskOwnerUin);
            this.SetParamSimple(map, prefix + "TaskRegionId", this.TaskRegionId);
            this.SetParamArrayObj(map, prefix + "TaskMonitors.", this.TaskMonitors);
            this.SetParamObj(map, prefix + "TaskPolicy.", this.TaskPolicy);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "TaskPlanId", this.TaskPlanId);
            this.SetParamSimple(map, prefix + "TaskPlanTitle", this.TaskPlanTitle);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamArraySimple(map, prefix + "AlarmPolicy.", this.AlarmPolicy);
            this.SetParamArrayObj(map, prefix + "ApmServiceList.", this.ApmServiceList);
            this.SetParamSimple(map, prefix + "VerifyId", this.VerifyId);
            this.SetParamSimple(map, prefix + "PolicyDealType", this.PolicyDealType);
        }
    }
}

