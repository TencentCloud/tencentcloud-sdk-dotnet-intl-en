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

    public class DescribeTimingL4DataRequest : AbstractModel
    {
        
        /// <summary>
        /// The start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// The end time. The query time range (`EndTime` - `StartTime`) must be less than or equal to 31 days.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Metric list. Valid values:
        /// <ul><li>**l4Flow_flux**: Total client traffic. Unit: Byte. Value type: Integer.</li>
        /// <li>**l4Flow_inFlux**: Inbound client traffic. Unit: Byte. Value type: Integer.</li>
        /// <li>**l4Flow_outFlux**: Outbound client traffic. Unit: Byte. Value type: Integer.</li>
        /// <li>**l4Flow_inBandwidth**: Peak inbound client bandwidth. Unit: bps. Value type: Integer.</li>
        /// <li>**l4Flow_outBandwidth**: Peak outbound client bandwidth. Unit: bps. Value type: Integer.</li>
        /// <li>**l4Flow_connections**: Concurrent client connections. Unit: count. Value type: Integer.</li>
        /// <li>**l4Flow_newConnectionsRate**: New connection rate. Unit: connections/second. Value type: Float. Rounded to two decimal places.</li></ul>**Note**:<ul><li>Metrics with an <code>Integer</code> value type return time-series data via <code>Data.N.TypeValue</code>;</li>
        /// <li>Metrics with a <code>Float</code> value type return time-series data via <code>Data.N.FloatTypeValue</code>.</li></ul>
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// Site ID. This parameter will change from selectable to required after May 30, 2024. For details, see the announcement: [Tencent Cloud EdgeOne: Tencent Cloud API change notification](https://www.tencentcloud.com/document/product/1552/104902?from_cn_redirect=1).
        /// Import up to 100 zone-ids. To query all site data under the Tencent Cloud root account, use `*` as a replacement. Querying account-level data requires permission for all site resources of this API.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// List of L4 proxy IDs. All L4 proxies will be selected if this field is not specified.
        /// </summary>
        [JsonProperty("ProxyIds")]
        public string[] ProxyIds{ get; set; }

        /// <summary>
        /// Time granularity of the query. Valid values:
        /// <ul><li>**min**: 1 minute;</li><Li>**5min**: 5 minutes;</li><Li>**hour**: 1 hour;</li><Li>**day**: 1 day.</li></ul>If this parameter is not input, the granularity will be automatically inferred based on the interval between the start time and end time. Specifically, data will be queried with a granularity of <code>min</code>, <code>5min</code>, <code>hour</code>, and <code>day</code> respectively when the period is no more than 1 hour, no more than 2 days, no more than 7 days, and over 7 days.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// Filter criteria. The detailed key values of filter criteria are as follows:.
        /// <ul><li>**ruleId**: filter by forwarding rule ID.</li>
        /// <li>**proxyId**: filter by L4 proxy instance ID.</li></ul>
        /// </summary>
        [JsonProperty("Filters")]
        public QueryCondition[] Filters{ get; set; }

        /// <summary>
        /// Data ownership region. This parameter is deprecated. Please filter data by client region in Filters.country.
        /// </summary>
        [JsonProperty("Area")]
        [System.Obsolete]
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

