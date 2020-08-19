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

    public class DescribePolicyGroupInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// Policy group name.
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// ID of the project to which the policy group belongs.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Whether it is the default policy. The value 0 indicates that it is not the default policy. The value 1 indicates that it is the default policy.
        /// </summary>
        [JsonProperty("IsDefault")]
        public long? IsDefault{ get; set; }

        /// <summary>
        /// Policy type.
        /// </summary>
        [JsonProperty("ViewName")]
        public string ViewName{ get; set; }

        /// <summary>
        /// Policy description
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Policy type name.
        /// </summary>
        [JsonProperty("ShowName")]
        public string ShowName{ get; set; }

        /// <summary>
        /// Uin that was last edited.
        /// </summary>
        [JsonProperty("LastEditUin")]
        public string LastEditUin{ get; set; }

        /// <summary>
        /// Last edited time.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Regions supported by this policy.
        /// </summary>
        [JsonProperty("Region")]
        public string[] Region{ get; set; }

        /// <summary>
        /// List of policy type dimensions.
        /// </summary>
        [JsonProperty("DimensionGroup")]
        public string[] DimensionGroup{ get; set; }

        /// <summary>
        /// Threshold rule list.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ConditionsConfig")]
        public DescribePolicyGroupInfoCondition[] ConditionsConfig{ get; set; }

        /// <summary>
        /// Product event rule list.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("EventConfig")]
        public DescribePolicyGroupInfoEventCondition[] EventConfig{ get; set; }

        /// <summary>
        /// Recipient list.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ReceiverInfos")]
        public DescribePolicyGroupInfoReceiverInfo[] ReceiverInfos{ get; set; }

        /// <summary>
        /// User callback information.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Callback")]
        public DescribePolicyGroupInfoCallback Callback{ get; set; }

        /// <summary>
        /// Template-based policy group.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ConditionsTemp")]
        public DescribePolicyGroupInfoConditionTpl ConditionsTemp{ get; set; }

        /// <summary>
        /// Whether the policy can be configured as the default policy.
        /// </summary>
        [JsonProperty("CanSetDefault")]
        public bool? CanSetDefault{ get; set; }

        /// <summary>
        /// Whether the 'AND' rule is used.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("IsUnionRule")]
        public long? IsUnionRule{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "ViewName", this.ViewName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ShowName", this.ShowName);
            this.SetParamSimple(map, prefix + "LastEditUin", this.LastEditUin);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArraySimple(map, prefix + "Region.", this.Region);
            this.SetParamArraySimple(map, prefix + "DimensionGroup.", this.DimensionGroup);
            this.SetParamArrayObj(map, prefix + "ConditionsConfig.", this.ConditionsConfig);
            this.SetParamArrayObj(map, prefix + "EventConfig.", this.EventConfig);
            this.SetParamArrayObj(map, prefix + "ReceiverInfos.", this.ReceiverInfos);
            this.SetParamObj(map, prefix + "Callback.", this.Callback);
            this.SetParamObj(map, prefix + "ConditionsTemp.", this.ConditionsTemp);
            this.SetParamSimple(map, prefix + "CanSetDefault", this.CanSetDefault);
            this.SetParamSimple(map, prefix + "IsUnionRule", this.IsUnionRule);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

