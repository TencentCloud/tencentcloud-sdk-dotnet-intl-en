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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudNativeAPIGatewayCanaryRule : AbstractModel
    {
        
        /// <summary>
        /// Priority, with a range of 0 to 100. A larger value indicates a higher priority. Priorities must be unique across different rules.
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// Whether the rule is enabled.
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// Match condition parameter
        /// </summary>
        [JsonProperty("ConditionList")]
        public CloudNativeAPIGatewayCanaryRuleCondition[] ConditionList{ get; set; }

        /// <summary>
        /// Traffic percentage configuration of the service
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BalancedServiceList")]
        public CloudNativeAPIGatewayBalancedService[] BalancedServiceList{ get; set; }

        /// <summary>
        /// service ID
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// Service name
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// Grayscale rule type
        /// Standard｜Lane
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Full-link grayscale policy match mode between multiple conditions: AND, OR
        /// </summary>
        [JsonProperty("MatchType")]
        public string MatchType{ get; set; }

        /// <summary>
        /// Lane group ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// Lane group name
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// Lane ID
        /// </summary>
        [JsonProperty("LaneId")]
        public string LaneId{ get; set; }

        /// <summary>
        /// swimlane name
        /// </summary>
        [JsonProperty("LaneName")]
        public string LaneName{ get; set; }

        /// <summary>
        /// Lane match rule: STRICT | PERMISSIVE
        /// </summary>
        [JsonProperty("MatchMode")]
        public string MatchMode{ get; set; }

        /// <summary>
        /// Lane tag
        /// </summary>
        [JsonProperty("LaneTag")]
        public string LaneTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamArrayObj(map, prefix + "ConditionList.", this.ConditionList);
            this.SetParamArrayObj(map, prefix + "BalancedServiceList.", this.BalancedServiceList);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "MatchType", this.MatchType);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "LaneId", this.LaneId);
            this.SetParamSimple(map, prefix + "LaneName", this.LaneName);
            this.SetParamSimple(map, prefix + "MatchMode", this.MatchMode);
            this.SetParamSimple(map, prefix + "LaneTag", this.LaneTag);
        }
    }
}

