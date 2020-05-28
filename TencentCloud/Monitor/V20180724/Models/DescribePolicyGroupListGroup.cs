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

    public class DescribePolicyGroupListGroup : AbstractModel
    {
        
        /// <summary>
        /// Policy group ID.
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// Policy group name.
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// Whether it is enabled.
        /// </summary>
        [JsonProperty("IsOpen")]
        public bool? IsOpen{ get; set; }

        /// <summary>
        /// Policy view name.
        /// </summary>
        [JsonProperty("ViewName")]
        public string ViewName{ get; set; }

        /// <summary>
        /// Uin that was last edited.
        /// </summary>
        [JsonProperty("LastEditUin")]
        public string LastEditUin{ get; set; }

        /// <summary>
        /// Last modified time.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("InsertTime")]
        public long? InsertTime{ get; set; }

        /// <summary>
        /// Number of instances that are bound to the policy group.
        /// </summary>
        [JsonProperty("UseSum")]
        public long? UseSum{ get; set; }

        /// <summary>
        /// Number of unshielded instances that are bound to the policy group.
        /// </summary>
        [JsonProperty("NoShieldedSum")]
        public long? NoShieldedSum{ get; set; }

        /// <summary>
        /// Whether it is the default policy. The value 0 indicates that it is not the default policy. The value 1 indicates that it is the default policy.
        /// </summary>
        [JsonProperty("IsDefault")]
        public long? IsDefault{ get; set; }

        /// <summary>
        /// Whether the policy can be configured as the default policy.
        /// </summary>
        [JsonProperty("CanSetDefault")]
        public bool? CanSetDefault{ get; set; }

        /// <summary>
        /// Parent policy group ID.
        /// </summary>
        [JsonProperty("ParentGroupId")]
        public long? ParentGroupId{ get; set; }

        /// <summary>
        /// Remarks of the policy group.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// ID of the project to which the policy group belongs.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Threshold rule list.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Conditions")]
        public DescribePolicyGroupInfoCondition[] Conditions{ get; set; }

        /// <summary>
        /// Product event rule list.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("EventConditions")]
        public DescribePolicyGroupInfoEventCondition[] EventConditions{ get; set; }

        /// <summary>
        /// Recipient list.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ReceiverInfos")]
        public DescribePolicyGroupInfoReceiverInfo[] ReceiverInfos{ get; set; }

        /// <summary>
        /// Template-based policy group.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ConditionsTemp")]
        public DescribePolicyGroupInfoConditionTpl ConditionsTemp{ get; set; }

        /// <summary>
        /// Instance group that is bound to the policy group.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("InstanceGroup")]
        public DescribePolicyGroupListGroupInstanceGroup InstanceGroup{ get; set; }

        /// <summary>
        /// The “AND” or “OR” rule. The value 0 indicates the “OR” rule (indicating that an alarm will be triggered if any rule meets the threshold condition). The value 1 indicates the “AND” rule (indicating that an alarm will be triggered when all rules meet the threshold conditions).
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("IsUnionRule")]
        public long? IsUnionRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "IsOpen", this.IsOpen);
            this.SetParamSimple(map, prefix + "ViewName", this.ViewName);
            this.SetParamSimple(map, prefix + "LastEditUin", this.LastEditUin);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "UseSum", this.UseSum);
            this.SetParamSimple(map, prefix + "NoShieldedSum", this.NoShieldedSum);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "CanSetDefault", this.CanSetDefault);
            this.SetParamSimple(map, prefix + "ParentGroupId", this.ParentGroupId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArrayObj(map, prefix + "Conditions.", this.Conditions);
            this.SetParamArrayObj(map, prefix + "EventConditions.", this.EventConditions);
            this.SetParamArrayObj(map, prefix + "ReceiverInfos.", this.ReceiverInfos);
            this.SetParamObj(map, prefix + "ConditionsTemp.", this.ConditionsTemp);
            this.SetParamObj(map, prefix + "InstanceGroup.", this.InstanceGroup);
            this.SetParamSimple(map, prefix + "IsUnionRule", this.IsUnionRule);
        }
    }
}

