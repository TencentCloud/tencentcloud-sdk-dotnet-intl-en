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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateAggregateConfigRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// Trigger types. A maximum of two types are supported.
        /// </summary>
        [JsonProperty("TriggerType")]
        public TriggerType[] TriggerType{ get; set; }

        /// <summary>
        /// Risk level
        /// 1: High-risk.
        /// 2: Medium-risk.
        /// 3: Low risk.
        /// </summary>
        [JsonProperty("RiskLevel")]
        public ulong? RiskLevel{ get; set; }

        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// Account group ID.
        /// </summary>
        [JsonProperty("AccountGroupId")]
        public string AccountGroupId{ get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Input parameters
        /// </summary>
        [JsonProperty("InputParameter")]
        public InputParameter[] InputParameter{ get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Associated regions.
        /// </summary>
        [JsonProperty("RegionScope")]
        public string[] RegionScope{ get; set; }

        /// <summary>
        /// Associated tag
        /// </summary>
        [JsonProperty("TagsScope")]
        public Tag[] TagsScope{ get; set; }

        /// <summary>
        /// Excluded resource ID.
        /// </summary>
        [JsonProperty("ExcludeResourceIdsScope")]
        public string[] ExcludeResourceIdsScope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "TriggerType.", this.TriggerType);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "AccountGroupId", this.AccountGroupId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamArrayObj(map, prefix + "InputParameter.", this.InputParameter);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "RegionScope.", this.RegionScope);
            this.SetParamArrayObj(map, prefix + "TagsScope.", this.TagsScope);
            this.SetParamArraySimple(map, prefix + "ExcludeResourceIdsScope.", this.ExcludeResourceIdsScope);
        }
    }
}

