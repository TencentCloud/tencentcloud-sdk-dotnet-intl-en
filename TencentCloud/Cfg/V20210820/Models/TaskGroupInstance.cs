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

    public class TaskGroupInstance : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("TaskGroupInstanceId")]
        public long? TaskGroupInstanceId{ get; set; }

        /// <summary>
        /// Instance ID
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskGroupInstanceObjectId")]
        public string TaskGroupInstanceObjectId{ get; set; }

        /// <summary>
        /// Instance action execution status
        /// </summary>
        [JsonProperty("TaskGroupInstanceStatus")]
        public long? TaskGroupInstanceStatus{ get; set; }

        /// <summary>
        /// Instance creation time
        /// </summary>
        [JsonProperty("TaskGroupInstanceCreateTime")]
        public string TaskGroupInstanceCreateTime{ get; set; }

        /// <summary>
        /// Instance update time
        /// </summary>
        [JsonProperty("TaskGroupInstanceUpdateTime")]
        public string TaskGroupInstanceUpdateTime{ get; set; }

        /// <summary>
        /// Status. 0: no status; 1: successful; 2: failed; 3: terminated; 4: skipped.
        /// </summary>
        [JsonProperty("TaskGroupInstanceStatusType")]
        public long? TaskGroupInstanceStatusType{ get; set; }

        /// <summary>
        /// Execution start time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskGroupInstanceStartTime")]
        public string TaskGroupInstanceStartTime{ get; set; }

        /// <summary>
        /// Execution end time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskGroupInstanceEndTime")]
        public string TaskGroupInstanceEndTime{ get; set; }

        /// <summary>
        /// Instance action execution log
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskGroupInstanceExecuteLog")]
        [System.Obsolete]
        public string TaskGroupInstanceExecuteLog{ get; set; }

        /// <summary>
        /// Whether the instance can be retried
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskGroupInstanceIsRedo")]
        public bool? TaskGroupInstanceIsRedo{ get; set; }

        /// <summary>
        /// Action instance execution time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskGroupInstanceExecuteTime")]
        public long? TaskGroupInstanceExecuteTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskGroupInstanceId", this.TaskGroupInstanceId);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceObjectId", this.TaskGroupInstanceObjectId);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceStatus", this.TaskGroupInstanceStatus);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceCreateTime", this.TaskGroupInstanceCreateTime);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceUpdateTime", this.TaskGroupInstanceUpdateTime);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceStatusType", this.TaskGroupInstanceStatusType);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceStartTime", this.TaskGroupInstanceStartTime);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceEndTime", this.TaskGroupInstanceEndTime);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceExecuteLog", this.TaskGroupInstanceExecuteLog);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceIsRedo", this.TaskGroupInstanceIsRedo);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceExecuteTime", this.TaskGroupInstanceExecuteTime);
        }
    }
}

