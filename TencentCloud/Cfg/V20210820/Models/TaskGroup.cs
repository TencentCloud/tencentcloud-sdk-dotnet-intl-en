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

    public class TaskGroup : AbstractModel
    {
        
        /// <summary>
        /// Task action ID
        /// </summary>
        [JsonProperty("TaskGroupId")]
        public long? TaskGroupId{ get; set; }

        /// <summary>
        /// Group name
        /// </summary>
        [JsonProperty("TaskGroupTitle")]
        public string TaskGroupTitle{ get; set; }

        /// <summary>
        /// Group description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskGroupDescription")]
        public string TaskGroupDescription{ get; set; }

        /// <summary>
        /// Task group order
        /// </summary>
        [JsonProperty("TaskGroupOrder")]
        public long? TaskGroupOrder{ get; set; }

        /// <summary>
        /// Object type ID
        /// </summary>
        [JsonProperty("ObjectTypeId")]
        public long? ObjectTypeId{ get; set; }

        /// <summary>
        /// Task group creation time
        /// </summary>
        [JsonProperty("TaskGroupCreateTime")]
        public string TaskGroupCreateTime{ get; set; }

        /// <summary>
        /// Task group update time
        /// </summary>
        [JsonProperty("TaskGroupUpdateTime")]
        public string TaskGroupUpdateTime{ get; set; }

        /// <summary>
        /// List of actions in the group
        /// </summary>
        [JsonProperty("TaskGroupActions")]
        public TaskGroupAction[] TaskGroupActions{ get; set; }

        /// <summary>
        /// Instance list
        /// </summary>
        [JsonProperty("TaskGroupInstanceList")]
        public string[] TaskGroupInstanceList{ get; set; }

        /// <summary>
        /// Execution mode. 1: sequential execution; 2: execution by stage.
        /// </summary>
        [JsonProperty("TaskGroupMode")]
        public long? TaskGroupMode{ get; set; }

        /// <summary>
        /// List of instances not involved in the experiment
        /// </summary>
        [JsonProperty("TaskGroupDiscardInstanceList")]
        public string[] TaskGroupDiscardInstanceList{ get; set; }

        /// <summary>
        /// List of instances involved in the experiment
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskGroupSelectedInstanceList")]
        public string[] TaskGroupSelectedInstanceList{ get; set; }

        /// <summary>
        /// Machine selection rule
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskGroupInstancesExecuteRule")]
        public TaskGroupInstancesExecuteRules[] TaskGroupInstancesExecuteRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskGroupId", this.TaskGroupId);
            this.SetParamSimple(map, prefix + "TaskGroupTitle", this.TaskGroupTitle);
            this.SetParamSimple(map, prefix + "TaskGroupDescription", this.TaskGroupDescription);
            this.SetParamSimple(map, prefix + "TaskGroupOrder", this.TaskGroupOrder);
            this.SetParamSimple(map, prefix + "ObjectTypeId", this.ObjectTypeId);
            this.SetParamSimple(map, prefix + "TaskGroupCreateTime", this.TaskGroupCreateTime);
            this.SetParamSimple(map, prefix + "TaskGroupUpdateTime", this.TaskGroupUpdateTime);
            this.SetParamArrayObj(map, prefix + "TaskGroupActions.", this.TaskGroupActions);
            this.SetParamArraySimple(map, prefix + "TaskGroupInstanceList.", this.TaskGroupInstanceList);
            this.SetParamSimple(map, prefix + "TaskGroupMode", this.TaskGroupMode);
            this.SetParamArraySimple(map, prefix + "TaskGroupDiscardInstanceList.", this.TaskGroupDiscardInstanceList);
            this.SetParamArraySimple(map, prefix + "TaskGroupSelectedInstanceList.", this.TaskGroupSelectedInstanceList);
            this.SetParamArrayObj(map, prefix + "TaskGroupInstancesExecuteRule.", this.TaskGroupInstancesExecuteRule);
        }
    }
}

