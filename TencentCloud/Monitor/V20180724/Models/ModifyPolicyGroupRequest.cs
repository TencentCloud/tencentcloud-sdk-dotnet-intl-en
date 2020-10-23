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

    public class ModifyPolicyGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// The value is fixed to monitor.
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// Policy group ID.
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// Alarm type.
        /// </summary>
        [JsonProperty("ViewName")]
        public string ViewName{ get; set; }

        /// <summary>
        /// Policy group name.
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// The 'AND' and 'OR' rules for metric alarms. The value 1 indicates 'AND', which means that an alarm will be triggered only when all rules are met. The value 0 indicates 'OR', which means that an alarm will be triggered when any rule is met.
        /// </summary>
        [JsonProperty("IsUnionRule")]
        public long? IsUnionRule{ get; set; }

        /// <summary>
        /// Metric alarm condition rules. No filling indicates that all existing metric alarm condition rules will be deleted.
        /// </summary>
        [JsonProperty("Conditions")]
        public ModifyPolicyGroupCondition[] Conditions{ get; set; }

        /// <summary>
        /// Event alarm conditions. No filling indicates that all existing event alarm conditions will be deleted.
        /// </summary>
        [JsonProperty("EventConditions")]
        public ModifyPolicyGroupEventCondition[] EventConditions{ get; set; }

        /// <summary>
        /// Template-based policy group ID.
        /// </summary>
        [JsonProperty("ConditionTempGroupId")]
        public long? ConditionTempGroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "ViewName", this.ViewName);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "IsUnionRule", this.IsUnionRule);
            this.SetParamArrayObj(map, prefix + "Conditions.", this.Conditions);
            this.SetParamArrayObj(map, prefix + "EventConditions.", this.EventConditions);
            this.SetParamSimple(map, prefix + "ConditionTempGroupId", this.ConditionTempGroupId);
        }
    }
}

