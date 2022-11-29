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

    public class SecRuleRelatedInfo : AbstractModel
    {
        
        /// <summary>
        /// The rule ID.
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// Action. Values:
        /// <li>`trans`: Allow;</li>
        /// <li>`alg`: Algorithm challenge;</li>
        /// <li>`drop`: Discard;</li>
        /// <li>`ban`: Block the source IP;</li>
        /// <li>`redirect`: Redirect;</li>
        /// <li>`page`: Return to the specified page;</li>
        /// <li>`monitor`: Observe.</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// Risk level (only found in WAF logs). Values:
        /// <li>`high risk`: High risk;</li>
        /// <li>`middle risk`: Middle risk;</li>
        /// <li>`low risk`: Low risk;</li>
        /// <li>`unkonw`: Unknown.</li>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// Rule level. Values:
        /// <li>`normal`: Moderate.</li>
        /// </summary>
        [JsonProperty("RuleLevel")]
        public string RuleLevel{ get; set; }

        /// <summary>
        /// Rule description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// The rule type.
        /// </summary>
        [JsonProperty("RuleTypeName")]
        public string RuleTypeName{ get; set; }

        /// <summary>
        /// The attack content.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AttackContent")]
        public string AttackContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "RuleLevel", this.RuleLevel);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RuleTypeName", this.RuleTypeName);
            this.SetParamSimple(map, prefix + "AttackContent", this.AttackContent);
        }
    }
}

