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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExtraRiskResult : AbstractModel
    {
        
        /// <summary>
        /// <p>Completion of the additional checks in this request, indicating whether the result can be trusted.</p><p>Valid values:</p><ul><li>Completed: Conclusions (matched or passed) have been given for all checks required by this request.</li><li>Partial: At least one check cannot reach a conclusion due to unavailable dependencies, insufficient data, or incomplete or invalid input parameters. The result is for reference only and does not indicate security.</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Additional risk level, which may be an empty string.</p><p>Valid values:</p><ul><li>High: An effective risk match exists (RiskDetailList is not empty in this case).</li><li>Low: The check is completed and no match is confirmed.</li><li>&quot;&quot; (empty string): Unrecognized. No check in this request can reach a conclusion, or not all checks are completed. It indicates neither risk nor security.</li></ul>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// <p>List of matched risk items. An empty array [] is returned if no risk item is matched.</p>
        /// </summary>
        [JsonProperty("BlackListResult")]
        public BlackListItem[] BlackListResult{ get; set; }

        /// <summary>
        /// <p>Face blocklist match details. An empty array [] is returned if no match is found.</p>
        /// </summary>
        [JsonProperty("RiskDetailList")]
        public RiskDetailItem[] RiskDetailList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamArrayObj(map, prefix + "BlackListResult.", this.BlackListResult);
            this.SetParamArrayObj(map, prefix + "RiskDetailList.", this.RiskDetailList);
        }
    }
}

