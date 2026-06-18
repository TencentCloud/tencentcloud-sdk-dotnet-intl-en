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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RiskRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// Risk Check Item ID
        /// </summary>
        [JsonProperty("RuleID")]
        public string RuleID{ get; set; }

        /// <summary>
        /// Cloud vendor name
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// Instance type
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// risk name
        /// </summary>
        [JsonProperty("RiskTitle")]
        public string RiskTitle{ get; set; }

        /// <summary>
        /// Check type
        /// </summary>
        [JsonProperty("CheckType")]
        public string CheckType{ get; set; }

        /// <summary>
        /// Risk level
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// Risk damage
        /// </summary>
        [JsonProperty("RiskInfluence")]
        public string RiskInfluence{ get; set; }

        /// <summary>
        /// Risk remediation guide report link
        /// </summary>
        [JsonProperty("RiskFixAdvance")]
        public string RiskFixAdvance{ get; set; }

        /// <summary>
        /// Boundary control
        /// </summary>
        [JsonProperty("DispositionType")]
        public string DispositionType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "RiskTitle", this.RiskTitle);
            this.SetParamSimple(map, prefix + "CheckType", this.CheckType);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "RiskInfluence", this.RiskInfluence);
            this.SetParamSimple(map, prefix + "RiskFixAdvance", this.RiskFixAdvance);
            this.SetParamSimple(map, prefix + "DispositionType", this.DispositionType);
        }
    }
}

