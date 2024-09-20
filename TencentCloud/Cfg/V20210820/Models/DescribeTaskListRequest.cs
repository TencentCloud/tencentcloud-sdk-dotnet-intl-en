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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTaskListRequest : AbstractModel
    {
        
        /// <summary>
        /// Pagination limit
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Pagination offset
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Experiment name
        /// </summary>
        [JsonProperty("TaskTitle")]
        public string TaskTitle{ get; set; }

        /// <summary>
        /// Tag key
        /// </summary>
        [JsonProperty("TaskTag")]
        public string[] TaskTag{ get; set; }

        /// <summary>
        /// Task status (1001: not started; 1002: in progress; 1003: paused; 1004: ended)
        /// </summary>
        [JsonProperty("TaskStatus")]
        public long? TaskStatus{ get; set; }

        /// <summary>
        /// Start time, in fixed format: %Y-%m-%d %H:%M:%S
        /// </summary>
        [JsonProperty("TaskStartTime")]
        public string TaskStartTime{ get; set; }

        /// <summary>
        /// End time, in fixed format: %Y-%m-%d %H:%M:%S
        /// </summary>
        [JsonProperty("TaskEndTime")]
        public string TaskEndTime{ get; set; }

        /// <summary>
        /// Update time, in fixed format: %Y-%m-%d %H:%M:%S
        /// </summary>
        [JsonProperty("TaskUpdateTime")]
        public string TaskUpdateTime{ get; set; }

        /// <summary>
        /// Tag pair
        /// </summary>
        [JsonProperty("Tags")]
        public TagWithDescribe[] Tags{ get; set; }

        /// <summary>
        /// Filtering criteria
        /// </summary>
        [JsonProperty("Filters")]
        public ActionFilter[] Filters{ get; set; }

        /// <summary>
        /// Experiment ID
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong?[] TaskId{ get; set; }

        /// <summary>
        /// ID of the associated application for filtering
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string[] ApplicationId{ get; set; }

        /// <summary>
        /// Associated application for filtering
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string[] ApplicationName{ get; set; }

        /// <summary>
        /// Task status for filtering, supporting multiple states (1001: not started; 1002: in progress; 1003: paused; 1004: ended)
        /// </summary>
        [JsonProperty("TaskStatusList")]
        public ulong?[] TaskStatusList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "TaskTitle", this.TaskTitle);
            this.SetParamArraySimple(map, prefix + "TaskTag.", this.TaskTag);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "TaskStartTime", this.TaskStartTime);
            this.SetParamSimple(map, prefix + "TaskEndTime", this.TaskEndTime);
            this.SetParamSimple(map, prefix + "TaskUpdateTime", this.TaskUpdateTime);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "TaskId.", this.TaskId);
            this.SetParamArraySimple(map, prefix + "ApplicationId.", this.ApplicationId);
            this.SetParamArraySimple(map, prefix + "ApplicationName.", this.ApplicationName);
            this.SetParamArraySimple(map, prefix + "TaskStatusList.", this.TaskStatusList);
        }
    }
}

