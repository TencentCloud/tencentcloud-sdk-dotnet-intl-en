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

    public class DescribeWebManagedRulesLogRequest : AbstractModel
    {
        
        /// <summary>
        /// The start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// The end time.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// List of sites to be queried. All sites will be selected if this field is not specified.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// List of subdomain names to be queried. All subdomain names will be selected if this field is not specified.
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// Limit on paginated queries. Default value: 20. Maximum value: 1000.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// The page offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Filters for the query. Values:
        /// <li>`attackType`: Attack type</li>
        /// <li>`riskLevel`: Risk level</li>
        /// <li>`action`: Action</li>
        /// <li>`ruleId`: Rule ID</li>
        /// <li>`sipCountryCode`: Country code of the attacker IP</li>
        /// <li>`attackIp`: Attacker IP</li>
        /// <li>`realClientIp`: Real client IP</li>
        /// <li>`oriDomain`: Attacked subdomain name</li>
        /// <li>`eventId`: Event ID</li>
        /// <li>`ua`: User agent</li>
        /// <li>`requestMethod`: Request method</li>
        /// <li>`uri`: Uniform resource identifier</li>
        /// </summary>
        [JsonProperty("QueryCondition")]
        public QueryCondition[] QueryCondition{ get; set; }

        /// <summary>
        /// Data storage region. Values:
        /// <li>`overseas`: Global (outside the Chinese mainland);</li>
        /// <li>`mainland`: Chinese mainland.</li>If this field is not specified, the data storage region will be determined based on the user’s location.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "QueryCondition.", this.QueryCondition);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

