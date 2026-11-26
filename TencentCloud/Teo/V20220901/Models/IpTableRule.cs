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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IpTableRule : AbstractModel
    {
        
        /// <summary>
        /// Action. Valid values:
        /// <li> drop: block;</li>
        /// <li> trans: release;</li>
        /// <li>monitor: observation.</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// According to type matching. Valid values:
        /// <li>ip: Match by client IP;</li>
        /// <li>area: match by client IP region;</li>
        /// <li>asn: Match the autonomous system to which the client belongs;</li>
        /// <li>referer: match the Referer request header;</li>
        /// <li>ua: match the User-Agent request header;</li>
        /// <li>url: Request URL for matching.</li>
        /// </summary>
        [JsonProperty("MatchFrom")]
        public string MatchFrom{ get; set; }

        /// <summary>
        /// Match method of the rule. Valid values:
        /// <li> match: match, suitable for MatchFrom as ip;</li>
        /// <li> not_match: Not match, suitable for when MatchFrom is ip;</li>
        /// <li> include_area: region inclusion, suitable for MatchFrom as area;</li>
        /// <li> not_include_area: Regions excluded, applicable to MatchFrom as area;</li>
        /// <li> asn_match: ASN contains, suitable for MatchFrom as asn;</li>
        /// <li> asn_not_match: ASN not contained, applicable to MatchFrom as asn;</li>
        /// <li> equal: equal, suitable for MatchFrom being ua, referer;</li>
        /// <li> not_equal: Not equal to, applicable to MatchFrom being ua, referer;</li>
        /// <li> include: wildcard match, suitable for MatchFrom being ua, referer, url;</li>
        /// <li> not_include: wildcard mismatch, suitable for MatchFrom being ua, referer;</li>
        /// <li> is_emty: The configuration content is empty, suitable for MatchFrom being ua or referer;</li>
        /// <li> not_exists: The configuration content does not exist. This is applicable when MatchFrom is ua or referer.</li>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// Rule id. Output only.
        /// </summary>
        [JsonProperty("RuleID")]
        public long? RuleID{ get; set; }

        /// <summary>
        /// Update time. For output usage only.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Rule enablement status. Valid values:
        /// <li>`on`: Enable;</li>
        /// <li> off: Disabled.</li>
        /// If the input parameter is not specified, the value defaults to `on`.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Rule name.
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Matching content. Multi-value input is supported.
        /// <li>When entering multiple matching values, please separate them with English commas;</li>
        /// <li>When MatchFrom is ua, multi-value input is not supported;</li>
        /// <li>When Operator is is_empty or not_exists, the input value of this field is invalid.</li>
        /// </summary>
        [JsonProperty("MatchContent")]
        public string MatchContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "MatchFrom", this.MatchFrom);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "MatchContent", this.MatchContent);
        }
    }
}

