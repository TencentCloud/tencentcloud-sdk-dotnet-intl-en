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

    public class DescribeTopL7AnalysisDataRequest : AbstractModel
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
        /// The query metric. Values:
        /// <li>`l7Flow_outFlux_country`: Country the request came from;</li>
        /// <li>`l7Flow_outFlux_statusCode`: Status code of the request;</li>
        /// <li>`l7Flow_outFlux_domain`: Domain name of the request;</li>
        /// <li>`l7Flow_outFlux_url`: URL of the request;</li>
        /// <li>`l7Flow_outFlux_resourceType`: Resource type;</li>
        /// <li>`l7Flow_outFlux_sip`: Client IP;</li>
        /// <li>`l7Flow_outFlux_referers`: Refer header;</li>
        /// <li>`l7Flow_outFlux_ua_device`: Device type;</li>
        /// <li>`l7Flow_outFlux_ua_browser`: Browser type;</li>
        /// <li>`l7Flow_outFlux_us_os`: OS type;</li>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// List of sites to be queried. All sites will be selected if this field is not specified.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// Queries the top n rows of data. Maximum value: 1000. Top 10 rows of data will be queried if this field is not specified.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// The key of the parameter QueryCondition, which is used to specify a filter. Values:
        /// <li>`country`: Country/Region;</li>
        /// <li>`domain`: Domain name;</li>
        /// <li>`protocol`: Protocol type;</li>
        /// <li>`resourceType`: Resource type;</li>
        /// <li>`statusCode`: Status code;</li>
        /// <li>`browserType`: Browser type;</li>
        /// <li>`deviceType`: Device type;</li>
        /// <li>`operatingSystemType`: OS type;</li>
        /// <li>`tlsVersion`: TLS version;</li>
        /// <li>`url`: URL address;</li>
        /// <li>`referer`: Refer header;</li>
        /// <li>`ipVersion`: IP version;</li>
        /// <li>`tagKey`: Tag key;</li>
        /// <li>`tagValue`: Tag value.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public QueryCondition[] Filters{ get; set; }

        /// <summary>
        /// The query time granularity. Values:
        /// <li>`min`: 1 minute;</li>
        /// <li>`5min`: 5 minute;</li>
        /// <li>`hour`: 1 hour;</li>
        /// <li>`day`: 1 day.</li>If this field is not specified, the granularity will be determined based on the interval between the start time and end time as follows: 1-minute granularity applies for a 1-hour interval, 5-minute granularity for a 2-day interval, 1-hour granularity for a 7-day interval, and 1-day granularity for an interval of over 7 days.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

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
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

