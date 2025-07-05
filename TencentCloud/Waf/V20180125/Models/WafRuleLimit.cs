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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WafRuleLimit : AbstractModel
    {
        
        /// <summary>
        /// Specifications of Custom CC
        /// </summary>
        [JsonProperty("CC")]
        public ulong? CC{ get; set; }

        /// <summary>
        /// Specifications for Custom Policy
        /// </summary>
        [JsonProperty("CustomRule")]
        public ulong? CustomRule{ get; set; }

        /// <summary>
        /// Specifications for Blocklist/Allowlist
        /// </summary>
        [JsonProperty("IPControl")]
        public ulong? IPControl{ get; set; }

        /// <summary>
        /// Specifications for Information Leakage Prevention
        /// </summary>
        [JsonProperty("AntiLeak")]
        public ulong? AntiLeak{ get; set; }

        /// <summary>
        /// Tamper-proof Specifications
        /// </summary>
        [JsonProperty("AntiTamper")]
        public ulong? AntiTamper{ get; set; }

        /// <summary>
        /// Specifications for Urgent CC
        /// </summary>
        [JsonProperty("AutoCC")]
        public ulong? AutoCC{ get; set; }

        /// <summary>
        /// Specifications for Region Banning
        /// </summary>
        [JsonProperty("AreaBan")]
        public ulong? AreaBan{ get; set; }

        /// <summary>
        /// Configure Session in Custom CC
        /// </summary>
        [JsonProperty("CCSession")]
        public ulong? CCSession{ get; set; }

        /// <summary>
        /// AI Specifications
        /// </summary>
        [JsonProperty("AI")]
        public ulong? AI{ get; set; }

        /// <summary>
        /// Specifications of Precision Allowlist
        /// </summary>
        [JsonProperty("CustomWhite")]
        public ulong? CustomWhite{ get; set; }

        /// <summary>
        /// API Security Specification
        /// </summary>
        [JsonProperty("ApiSecurity")]
        public ulong? ApiSecurity{ get; set; }

        /// <summary>
        /// Specifications for client traffic flag
        /// </summary>
        [JsonProperty("ClientMsg")]
        public ulong? ClientMsg{ get; set; }

        /// <summary>
        /// Specifications for Traffic Tagging
        /// </summary>
        [JsonProperty("TrafficMarking")]
        public ulong? TrafficMarking{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CC", this.CC);
            this.SetParamSimple(map, prefix + "CustomRule", this.CustomRule);
            this.SetParamSimple(map, prefix + "IPControl", this.IPControl);
            this.SetParamSimple(map, prefix + "AntiLeak", this.AntiLeak);
            this.SetParamSimple(map, prefix + "AntiTamper", this.AntiTamper);
            this.SetParamSimple(map, prefix + "AutoCC", this.AutoCC);
            this.SetParamSimple(map, prefix + "AreaBan", this.AreaBan);
            this.SetParamSimple(map, prefix + "CCSession", this.CCSession);
            this.SetParamSimple(map, prefix + "AI", this.AI);
            this.SetParamSimple(map, prefix + "CustomWhite", this.CustomWhite);
            this.SetParamSimple(map, prefix + "ApiSecurity", this.ApiSecurity);
            this.SetParamSimple(map, prefix + "ClientMsg", this.ClientMsg);
            this.SetParamSimple(map, prefix + "TrafficMarking", this.TrafficMarking);
        }
    }
}

