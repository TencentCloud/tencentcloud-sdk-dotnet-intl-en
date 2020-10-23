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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePolicyGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// Policy group name.
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// The value is fixed to monitor.
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// Name of the view to which the policy group belongs. If the policy group is created based on a template, this parameter is optional.
        /// </summary>
        [JsonProperty("ViewName")]
        public string ViewName{ get; set; }

        /// <summary>
        /// ID of the project to which the policy group belongs, which will be used for authentication.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// ID of a template-based policy group. This parameter is required only when the policy group is created based on a template.
        /// </summary>
        [JsonProperty("ConditionTempGroupId")]
        public long? ConditionTempGroupId{ get; set; }

        /// <summary>
        /// Whether the policy group is shielded. The value 0 indicates that the policy group is not shielded. The value 1 indicates that the policy group is shielded. The default value is 0.
        /// </summary>
        [JsonProperty("IsShielded")]
        public long? IsShielded{ get; set; }

        /// <summary>
        /// Remarks of the policy group.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Insertion time in the format of Unix timestamp. If this parameter is not configured, the backend processing time is used.
        /// </summary>
        [JsonProperty("InsertTime")]
        public long? InsertTime{ get; set; }

        /// <summary>
        /// Alarm threshold rules in the policy group.
        /// </summary>
        [JsonProperty("Conditions")]
        public CreatePolicyGroupCondition[] Conditions{ get; set; }

        /// <summary>
        /// Event alarm rules in the policy group.
        /// </summary>
        [JsonProperty("EventConditions")]
        public CreatePolicyGroupEventCondition[] EventConditions{ get; set; }

        /// <summary>
        /// Whether it is a backend call. If the value is 1, rules from the policy template will be used to fill in the `Conditions` and `EventConditions` fields.
        /// </summary>
        [JsonProperty("BackEndCall")]
        public long? BackEndCall{ get; set; }

        /// <summary>
        /// The 'AND' and 'OR' rules for alarm metrics. The value 0 indicates 'OR', which means that an alarm will be triggered when any rule is met. The value 1 indicates 'AND', which means that an alarm will be triggered only when all rules are met.
        /// </summary>
        [JsonProperty("IsUnionRule")]
        public long? IsUnionRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "ViewName", this.ViewName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ConditionTempGroupId", this.ConditionTempGroupId);
            this.SetParamSimple(map, prefix + "IsShielded", this.IsShielded);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamArrayObj(map, prefix + "Conditions.", this.Conditions);
            this.SetParamArrayObj(map, prefix + "EventConditions.", this.EventConditions);
            this.SetParamSimple(map, prefix + "BackEndCall", this.BackEndCall);
            this.SetParamSimple(map, prefix + "IsUnionRule", this.IsUnionRule);
        }
    }
}

