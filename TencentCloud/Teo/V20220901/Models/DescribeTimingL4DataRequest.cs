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

    public class DescribeTimingL4DataRequest : AbstractModel
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
        /// Query indicator. Values: 
        /// <li>l4Flow_connections: Number of access connections;</li>
        /// <li>l4Flow_flux: Total access traffic;</li>
        /// <li>l4Flow_inFlux: Ingress access traffic;</li>
        /// <li>l4Flow_outFlux: Egress access traffic. </li>
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// ZoneId set. This parameter is required.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// List of L4 proxy IDs. All L4 proxies will be selected if this field is not specified.
        /// </summary>
        [JsonProperty("ProxyIds")]
        public string[] ProxyIds{ get; set; }

        /// <summary>
        /// The query granularity. Values:
        /// <li>`min`: 1 minute;</li>
        /// <li>`5min`: 5 minutes;</li>
        /// <li>`hour`: 1 hour;</li>
        /// <li>`day`: 1 day.</li>If this field is not specified, the granularity will be determined based on the query period. <br>Period ≤ 1 hour: `min`; <br>1 hour < Period ≤ 2 days: `5min`; <br>2 days < period ≤ 7 days: `hour`; <br>Period > 7 days: `day`.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// Filter criteria. The detailed Key values of filter criteria are as follows:
        /// <li>ruleId: Filter by forwarding rule ID.</li>
        /// <li>proxyId: Filter by L4 proxy instance ID.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public QueryCondition[] Filters{ get; set; }

        /// <summary>
        /// Geolocation scope. Values:
        /// <li>`overseas`: Regions outside the Chinese mainland</li>
        /// <li>`mainland`: Chinese mainland</li>
        /// <li>`global`: Global</li>If this field is not specified, the default value `global` is used.
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
            this.SetParamArraySimple(map, prefix + "MetricNames.", this.MetricNames);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamArraySimple(map, prefix + "ProxyIds.", this.ProxyIds);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

