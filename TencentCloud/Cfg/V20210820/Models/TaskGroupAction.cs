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

    public class TaskGroupAction : AbstractModel
    {
        
        /// <summary>
        /// Task group action ID
        /// </summary>
        [JsonProperty("TaskGroupActionId")]
        public long? TaskGroupActionId{ get; set; }

        /// <summary>
        /// Action instance list of the task group
        /// </summary>
        [JsonProperty("TaskGroupInstances")]
        public TaskGroupInstance[] TaskGroupInstances{ get; set; }

        /// <summary>
        /// Action ID
        /// </summary>
        [JsonProperty("ActionId")]
        public long? ActionId{ get; set; }

        /// <summary>
        /// Order of actions in the group
        /// </summary>
        [JsonProperty("TaskGroupActionOrder")]
        public long? TaskGroupActionOrder{ get; set; }

        /// <summary>
        /// General configurations of actions in the group
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskGroupActionGeneralConfiguration")]
        public string TaskGroupActionGeneralConfiguration{ get; set; }

        /// <summary>
        /// Custom configurations of actions in the group
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskGroupActionCustomConfiguration")]
        public string TaskGroupActionCustomConfiguration{ get; set; }

        /// <summary>
        /// Status of actions in the group
        /// </summary>
        [JsonProperty("TaskGroupActionStatus")]
        public long? TaskGroupActionStatus{ get; set; }

        /// <summary>
        /// Action group creation time
        /// </summary>
        [JsonProperty("TaskGroupActionCreateTime")]
        public string TaskGroupActionCreateTime{ get; set; }

        /// <summary>
        /// Action group update time
        /// </summary>
        [JsonProperty("TaskGroupActionUpdateTime")]
        public string TaskGroupActionUpdateTime{ get; set; }

        /// <summary>
        /// Action name
        /// </summary>
        [JsonProperty("ActionTitle")]
        public string ActionTitle{ get; set; }

        /// <summary>
        /// Status. 0: no status; 1: successful; 2; failed; 3: terminated; 4: skipped.
        /// </summary>
        [JsonProperty("TaskGroupActionStatusType")]
        public long? TaskGroupActionStatusType{ get; set; }

        /// <summary>
        /// RandomId
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskGroupActionRandomId")]
        public long? TaskGroupActionRandomId{ get; set; }

        /// <summary>
        /// RecoverId
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskGroupActionRecoverId")]
        public long? TaskGroupActionRecoverId{ get; set; }

        /// <summary>
        /// ExecuteId
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskGroupActionExecuteId")]
        public long? TaskGroupActionExecuteId{ get; set; }

        /// <summary>
        /// Called API type. 0: tat; 1: cloud API.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ActionApiType")]
        public long? ActionApiType{ get; set; }

        /// <summary>
        /// 1: fault; 2: recovery.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ActionAttribute")]
        public long? ActionAttribute{ get; set; }

        /// <summary>
        /// Action type: platform and custom
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// Whether retry is allowed
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsExecuteRedo")]
        public bool? IsExecuteRedo{ get; set; }

        /// <summary>
        /// Action risk level
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ActionRisk")]
        public string ActionRisk{ get; set; }

        /// <summary>
        /// Action running time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskGroupActionExecuteTime")]
        public long? TaskGroupActionExecuteTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskGroupActionId", this.TaskGroupActionId);
            this.SetParamArrayObj(map, prefix + "TaskGroupInstances.", this.TaskGroupInstances);
            this.SetParamSimple(map, prefix + "ActionId", this.ActionId);
            this.SetParamSimple(map, prefix + "TaskGroupActionOrder", this.TaskGroupActionOrder);
            this.SetParamSimple(map, prefix + "TaskGroupActionGeneralConfiguration", this.TaskGroupActionGeneralConfiguration);
            this.SetParamSimple(map, prefix + "TaskGroupActionCustomConfiguration", this.TaskGroupActionCustomConfiguration);
            this.SetParamSimple(map, prefix + "TaskGroupActionStatus", this.TaskGroupActionStatus);
            this.SetParamSimple(map, prefix + "TaskGroupActionCreateTime", this.TaskGroupActionCreateTime);
            this.SetParamSimple(map, prefix + "TaskGroupActionUpdateTime", this.TaskGroupActionUpdateTime);
            this.SetParamSimple(map, prefix + "ActionTitle", this.ActionTitle);
            this.SetParamSimple(map, prefix + "TaskGroupActionStatusType", this.TaskGroupActionStatusType);
            this.SetParamSimple(map, prefix + "TaskGroupActionRandomId", this.TaskGroupActionRandomId);
            this.SetParamSimple(map, prefix + "TaskGroupActionRecoverId", this.TaskGroupActionRecoverId);
            this.SetParamSimple(map, prefix + "TaskGroupActionExecuteId", this.TaskGroupActionExecuteId);
            this.SetParamSimple(map, prefix + "ActionApiType", this.ActionApiType);
            this.SetParamSimple(map, prefix + "ActionAttribute", this.ActionAttribute);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "IsExecuteRedo", this.IsExecuteRedo);
            this.SetParamSimple(map, prefix + "ActionRisk", this.ActionRisk);
            this.SetParamSimple(map, prefix + "TaskGroupActionExecuteTime", this.TaskGroupActionExecuteTime);
        }
    }
}

