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
        /// Start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time. The query time range (`EndTime` - `StartTime`) must be up to 31 days.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Queried metric. Valid values:
        /// <ul><li>**l4Flow_flux**: Total access traffic, unit: Byte, metric value type: Integer;</li>
        /// <li>**l4Flow_inFlux**: Access inbound traffic, unit: Byte, metric value type: Integer;</li>
        /// <li>**l4Flow_outFlux**: Access outbound traffic, unit: Byte, metric value type: Integer;</li>
        /// <li>**l4Flow_inBandwidth**: Inbound bandwidth peak for access, unit: bps, metric value type: Integer;</li>
        /// <li>**l4Flow_outBandwidth**: Outbound access bandwidth peak, unit: bps, metric value type: Integer;</li>
        /// <li>**l4Flow_connections**: Number of concurrent connections, unit: count, metric value type: Integer;</li>
        /// <li>**l4Flow_newConnectionsRate**: Rate of new connections, unit: connections/second, metric value type: Float, rounded to two decimal places.</li></ul>**Note**:<ul><li>Metrics of the <code>Integer</code> value type will return corresponding time series data from <code>Data.N.TypeValue</code>;</li>
        /// <li>Metrics of the <code>Float</code> value type return corresponding time series data from <code>Data.N.FloatTypeValue</code>.</li></ul>
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// Site ID. This parameter will change from selectable to required after May 30, 2024. For details, see the announcement: [Tencent Cloud EdgeOne Cloud API Change Notification](https://www.tencentcloud.com/document/product/1552/104902?from_cn_redirect=1).
        /// Import up to 100 site IDs. To query data of all sites under the Tencent Cloud root account, use `*` instead. To query account-level data, you must have permissions for all site resources of this interface.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// Layer-4 instance list. If not specified, it means select all instances.
        /// </summary>
        [JsonProperty("ProxyIds")]
        public string[] ProxyIds{ get; set; }

        /// <summary>
        /// Time granularity of the query. Valid values:
        /// <ul><li>**min**: 1 minute;</li>
        /// <li>**5min**: 5 minutes;</li>
        /// <li>**hour**: 1 hour;</li>
        /// <li>**day**: 1 day.</li></ul>If this parameter is not input, the granularity will be automatically calculated based on the interval between the start time and end time. Specifically, data will be queried with a granularity of <code>min</code>, <code>5min</code>, <code>hour</code>, and <code>day</code> respectively when the period is no more than 1 hour, no more than 2 days, no more than 7 days, and over 7 days.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// Filter criteria. The detailed Key values of filter criteria are as follows:
        /// <ul><li>**ruleId**: Filter by forwarding rule ID.</li>
        /// <li>**proxyId**: filter by L4 proxy instance ID.</li></ul>
        /// </summary>
        [JsonProperty("Filters")]
        public QueryCondition[] Filters{ get; set; }

        /// <summary>
        /// Data ownership region. Deprecated. Filter data by client region in Filters.country.
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

