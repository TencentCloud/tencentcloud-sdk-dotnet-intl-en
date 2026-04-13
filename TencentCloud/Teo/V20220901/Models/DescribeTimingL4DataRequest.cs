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
        /// End time. the query time range (`EndTime` - `StartTime`) must be less than or equal to 31 days.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Query metrics. valid values:.
        /// <ul><li>**l4Flow_flux**: specifies the total access traffic. measurement unit: Byte. metric value type: Integer.</li>.
        /// <li>**l4Flow_inFlux**: specifies access inbound traffic. measurement unit: Byte. metric value type: Integer.</li>.
        /// <li>**l4Flow_outFlux**: access outbound traffic. measurement unit: Byte. metric value type: Integer.</li>.
        /// <li>**l4Flow_inBandwidth**: specifies the inbound bandwidth peak of the visit. measurement unit: bps. metric value type: Integer.</li>.
        /// <li>**l4Flow_outBandwidth**: specifies the outbound bandwidth peak. measurement unit: bps. metric value type: Integer.</li>.
        /// <li>**l4Flow_connections**: specifies the number of concurrent connections, measurement unit: unit, metric value type: Integer.</li>.
        /// <li>**l4Flow_newConnectionsRate**: the rate of new connections, measurement unit: per second, metric value type: Float, rounded to two decimal places.</li></ul>**note**:<ul><li>metrics of <code>Integer</code> type will return corresponding time series Data from <code>Data.N.TypeValue</code>;</li>.
        /// <li>Metrics with <code>Float</code> value type will return corresponding time series Data from <code>Data.N.FloatTypeValue</code>.</li></ul>.
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// Site ID. this parameter will change from selectable to required after may 30, 2024. for details, see the announcement: [tencent cloud EdgeOne: tencentcloud API change notification](https://www.tencentcloud.comom/document/product/1552/104902?from_cn_redirect=1).
        /// Import up to 100 site ids. to query all site data under the tencent cloud root account, use `*` as a replacement. querying account-level data requires permission for all site resources of this api.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// List of L4 proxy IDs. All L4 proxies will be selected if this field is not specified.
        /// </summary>
        [JsonProperty("ProxyIds")]
        public string[] ProxyIds{ get; set; }

        /// <summary>
        /// Time granularity of the query. valid values:.
        /// <ul><li>**min**: 1 minute;</li>.
        /// <Li>**5min**: 5 minutes;</li>.
        /// <Li>**Hour**: 1 hour;</li>.
        /// <Li>**Day**: 1 day.</li></ul>if this parameter is not input, the granularity will be automatically inferred based on the interval between the start time and end time. specifically, data will be queried with a granularity of <code>min</code>, <code>5min</code>, <code>hour</code>, and <code>day</code> respectively when the period is no more than 1 hour, no more than 2 days, no more than 7 days, and over 7 days.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// Filter criteria. the detailed Key values of filter criteria are as follows:.
        /// <ul><li>**ruleId**: filter by forwarding rule ID.</li>.
        /// <li>**proxyId**: filters by l4 proxy instance ID.</li></ul>.
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

