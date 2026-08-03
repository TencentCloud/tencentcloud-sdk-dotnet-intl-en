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

    public class DescribeTimingL7AnalysisDataRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Start time.</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>End time. The query time range (<code>EndTime</code> - <code>StartTime</code>) must be less than or equal to 31 days.</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>Metric list. Valid values:</p><li>l7Flow_outFlux: L7 EdgeOne response traffic. Measurement unit: Byte;</li><li>l7Flow_inFlux: L7 client request traffic. Measurement unit: Byte;</li><li>l7Flow_flux: L7 total access traffic (EdgeOne response + client request). Measurement unit: Byte;</li><li>l7Flow_outBandwidth: L7 EdgeOne response bandwidth. Measurement unit: bps;</li><li>l7Flow_inBandwidth: L7 client request bandwidth. Measurement unit: bps;</li><li>l7Flow_bandwidth: L7 total access bandwidth (EdgeOne response + client request). Measurement unit: bps;</li><li>l7Flow_request: L7 client request count. Measurement unit: count;</li><li>l7Flow_avgResponseTime: L7 average response time. Measurement unit: ms;</li><li>l7Flow_avgFirstByteResponseTime: L7 average first byte response time. Measurement unit: ms;</li><li>l7Flow_requestRate: L7 client request rate. Measurement unit: qps.</li>
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// <p>Site ID set. This parameter will change from optional to required after May 30, 2024. For details, see the notice: <a href="https://www.tencentcloud.com/document/product/1552/104902?from_cn_redirect=1">[Tencent Cloud EdgeOne] Cloud API Change Notification</a>. A maximum of 100 site IDs can be imported. To query all site data under the Tencent Cloud root account, use <code>*</code> as a replacement. Querying account-level data requires permission to all site resources of this interface.</p>
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// <p>Query time granularity.</p><p>Enumeration values:</p><ul><li>min: 1 minute</li><li>5min: 5 minutes</li><li>hour: 1 hour</li><li>day: 1 day</li></ul><p>If this parameter is not input, the granularity will be automatically calculated based on the interval between the start time and end time. Specifically, data will be queried with a granularity of min, 5min, hour, and day respectively when the period is no more than 2 hours, no more than 2 days, no more than 7 days, and over 7 days.</p>
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// <p>Filter conditions used when filtering data. For available filter options, refer to the <a href="https://www.tencentcloud.com/document/product/1552/98219?from_cn_redirect=1#1aaf1150-55a4-4b4d-b103-3a8317ac7945">Analytics Filter Options</a> for L7 client traffic, bandwidth, and request counts.<br>To limit the query to specific sites or content identifiers, pass the corresponding values in the <code>ZoneIds.N</code> parameter separately.</p>
        /// </summary>
        [JsonProperty("Filters")]
        public QueryCondition[] Filters{ get; set; }

        /// <summary>
        /// <p>The region to which the data belongs. This parameter is deprecated. To filter data by client region, use <code>Filters.country</code> instead.</p>
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

