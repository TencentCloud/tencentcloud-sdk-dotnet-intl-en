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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ManagedRuleDetail : AbstractModel
    {
        
        /// <summary>
        /// Managed rule Id.
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// Protection level of managed rules. Values: <li>`low`: low risk, this rule has a relatively low risk and is applicable to very strict access scenarios, this level of rule may generate considerable false alarms.</li> <li>`medium`: medium risk, this means the risk of this rule is normal and is suitable for protection scenarios with stricter requirements.</li> <li>`high`: high risk, this indicates that the risk of this rule is relatively high and will not generate false alarms in most scenarios.</li> <li>`extreme`: ultra-high risk. this represents that the risk of this rule is extremely high and will not generate false alarms basically.</li>.
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// Rule description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Rule tag. Some types of rules do not have tags.
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// Rule version.
        /// </summary>
        [JsonProperty("RuleVersion")]
        public string RuleVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "RuleVersion", this.RuleVersion);
        }
    }
}

