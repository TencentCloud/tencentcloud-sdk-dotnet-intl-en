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

    public class DescribeOverviewL7DataRequest : AbstractModel
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
        /// The metric to query. Values:
        /// <li>`l7Flow_outFlux`: Traffic used for EdegOne responses</li>
        /// <li>`l7Flow_inFlux`: Traffic used for EdegOne requests</li>
        /// <li>`l7Flow_outBandwidth`: Bandwidth used for EdegOne responses</li>
        /// <li>`l7Flow_inBandwidth`: Bandwidth used for EdegOne requests</li>
        /// <li>`l7Flow_hit_outFlux`: Traffic used for cache hit</li>
        /// <li>`l7Flow_request`: Access requests</li>
        /// <li>`l7Flow_flux`: Upstream and downstream traffic used for client access</li>
        /// <li>`l7Flow_bandwidth`: Upstream and downstream bandwidth used for client access</li>
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// ZoneId set. This parameter is required.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// Queried domain name set. This parameter has been discarded.
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// The protocol type. Values:
        /// <li>`http`: HTTP protocol;</li>
        /// <li>`https`: HTTPS protocol;</li>
        /// <li>`http2`: HTTP2 protocol;</li>
        /// <li>`all`:   All protocols. </li>If it’s not specified, `all` is used. This parameter is not yet available now.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// The query granularity. Values:
        /// <li>`min`: 1 minute;</li>
        /// <li>`5min`: 5 minutes;</li>
        /// <li>`hour`: 1 hour;</li>
        /// <li>`day`: One day</li>If this field is not specified, the granularity will be determined based on the query period. <br>Period ≤ 1 hour: `min`; <br>1 hour < Period ≤ 2 days: `5min`; <br>2 days < period ≤ 7 days: `hour`; <br>Period > 7 days: `day`.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// Filtering condition. The detailed filtering condition key values are as follows: 
        /// <li>socket<br>u2003u2003 Filter based on [<strong>HTTP protocol type</strong>]. <br>u2003u2003 Corresponding value options: <br>u2003u2003 HTTP: HTTP protocol；<br>u2003u2003 HTTPS: HTTPS protocol;<br>u2003u2003 QUIC: QUIC protocol. </li>
        /// <li>domains<br>u2003u2003 Filter based on [<strong>domain name</strong>]. </li>
        /// <li>tagKey<br>u2003u2003 Filter based on [<strong>Tag Key</strong>]. </li>
        /// <li>tagValue<br>u2003u2003 Filter based on [<strong>Tag Value</strong>]. </li>
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
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

