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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskInstanceView : AbstractModel
    {
        
        /// <summary>
        /// Task instance index
        /// </summary>
        [JsonProperty("TaskInstanceIndex")]
        public long? TaskInstanceIndex{ get; set; }

        /// <summary>
        /// Task instance state
        /// </summary>
        [JsonProperty("TaskInstanceState")]
        public string TaskInstanceState{ get; set; }

        /// <summary>
        /// Exit code after application execution is completed
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ExitCode")]
        public long? ExitCode{ get; set; }

        /// <summary>
        /// Task instance state reason. If the task instance fails, the reason for the failure will be logged.
        /// </summary>
        [JsonProperty("StateReason")]
        public string StateReason{ get; set; }

        /// <summary>
        /// The `InstanceId` of the compute node (e.g., CVM instance) where the task instance is running. This field is empty if the task instance is not running or has already been completed and will change when the task instance is retried.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ComputeNodeInstanceId")]
        public string ComputeNodeInstanceId{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Start time
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("LaunchTime")]
        public string LaunchTime{ get; set; }

        /// <summary>
        /// Running start time
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("RunningTime")]
        public string RunningTime{ get; set; }

        /// <summary>
        /// Task end time
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Redirection information
        /// </summary>
        [JsonProperty("RedirectInfo")]
        public RedirectInfo RedirectInfo{ get; set; }

        /// <summary>
        /// Task instance state reason details. If the task instance fails, the reason for the failure will be logged
        /// </summary>
        [JsonProperty("StateDetailedReason")]
        public string StateDetailedReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskInstanceIndex", this.TaskInstanceIndex);
            this.SetParamSimple(map, prefix + "TaskInstanceState", this.TaskInstanceState);
            this.SetParamSimple(map, prefix + "ExitCode", this.ExitCode);
            this.SetParamSimple(map, prefix + "StateReason", this.StateReason);
            this.SetParamSimple(map, prefix + "ComputeNodeInstanceId", this.ComputeNodeInstanceId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LaunchTime", this.LaunchTime);
            this.SetParamSimple(map, prefix + "RunningTime", this.RunningTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamObj(map, prefix + "RedirectInfo.", this.RedirectInfo);
            this.SetParamSimple(map, prefix + "StateDetailedReason", this.StateDetailedReason);
        }
    }
}

