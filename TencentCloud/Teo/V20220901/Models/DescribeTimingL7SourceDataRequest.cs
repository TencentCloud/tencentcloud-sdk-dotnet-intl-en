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

    public class DescribeTimingL7SourceDataRequest : AbstractModel
    {
        
        /// <summary>
        /// Start time of the query period.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time of the query period.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// List of metrics. Values:
        /// <li>`l7Flow_outFlux_hy`: EdgeOne request traffic</li>
        /// <li>`l7Flow_outBandwidth_hy`: EdgeOne request bandwidth</li>
        /// <li>`l7Flow_inFlux_hy`: Origin response traffic</li>
        /// <li>`l7Flow_inBandwidth_hy`: Origin response bandwidth</li>
        /// <li>`l7Flow_request_hy`: Origin-pull requests</li>
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// List of sites to be queried. All sites will be selected if this field is not specified.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// The query granularity. Values:
        /// <li>`min`: 1 minute</li>
        /// <li>`5min`: 5 minutes</li>
        /// <li>`hour`: 1 hour</li>
        /// <li>`day`: 1 day</li>If this field is not specified, the granularity is determined based on the query period. **Query period < 1 hour**: 1-minute granularity; **1 hour < query period < 2 days**: 5-minute granularity; **2 days < query period < 7 days**: 1 hour granularity; **Query period > 7 days**: 1 day granularity.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// Filter conditions. See below for details: 
        /// <li>`domain`:<br>   Filter by <strong>the origin domain</strong><br>   Type: String<br>   Required: No</li>
        /// <li>`origin`:<br>   Filter by <strong>the origin</strong><br>   Type: String<br>   Required: No</li>
        /// <li>`originGroup`:<br>   Filter by <strong>the origin group</strong>, such as origin-xxxxx.<br>   Type: String<br>   Required: No</li>
        /// <li>`flowType`:<br>   Filter by <strong>the origin response type</strong>. This parameter takes precedence over `MetricNames.N`.<br>   Type: String<br>   Required: No<br>   Values:<br>   `inFlow`: Origin response data, corresponding to `l7Flow_inFlux_hy`, `l7Flow_inBandwidth_hy` and `l7Flow_request_hy` in `MetricNames.N`.<br>   `outFlow`: EdgeOne request data, corresponding to `l7Flow_outFlux_hy`, `l7Flow_outBandwidth_hy` and `l7Flow_request_hy` in `MetricNames.N`.</li>
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
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

