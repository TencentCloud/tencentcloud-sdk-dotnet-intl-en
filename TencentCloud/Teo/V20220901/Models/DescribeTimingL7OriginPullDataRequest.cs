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

    public class DescribeTimingL7OriginPullDataRequest : AbstractModel
    {
        
        /// <summary>
        /// Site ID set. This parameter is required. A maximum of 100 zone-ids can be imported. Use `*` to query data for all sites under the Tencent Cloud root account. Querying account-level data requires permissions for all site resources in this API.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// Metric list. Valid values:
        /// <ul><li>l7Flow_outFlux_hy: Request traffic from the EdgeOne node to the origin server. Unit: Byte.</li><li>l7Flow_outBandwidth_hy: Request bandwidth from the EdgeOne node to the origin server. Unit: bps.</li><li>l7Flow_request_hy: Number of requests from the EdgeOne node to the origin server. Unit: count.</li><li>l7Flow_inFlux_hy: Response traffic from the origin server to the EdgeOne node. Unit: Byte.</li><li>l7Flow_inBandwidth_hy: Response bandwidth from the origin server to the EdgeOne node. Unit: bps.</li></ul>
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// Start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time. The query time range (`EndTime` - `StartTime`) must be less than or equal to 31 days.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Time granularity of the query. Valid values:
        /// <ul><li>min: 1 minute;</li><li>5min: 5 minutes;</li><li>hour: 1 hour;</li><li>day: 1 day.</li></ul>If this parameter is not specified, the granularity will be automatically inferred based on the time range between the start time and end time. Specifically, the granularity will be min, 5min, hour, and day when the time range is within 2 hours, within 2 days, within 7 days, and exceeding 7 days, respectively.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// Filter criteria. Detailed filter criteria:
        /// <ul><li><strong>domain</strong>: The requested domain name from the client. If accessing EdgeOne via a wildcard domain, the data records the wildcard domain name rather than the specific subdomain.</li><li><strong>originStatusCode</strong>: Origin status code. This filter is supported only when <code>MetricNames = ["l7Flow_request_hy"]</code>.
        /// Valid values:<ul><li><code>1xx</code>: Status codes in the 1xx range.</li><li><code>2xx</code>: Status codes in the 2xx range.</li><li><code>3xx</code>: Status codes in the 3xx range.</li><li><code>4xx</code>: Status codes in the 4xx range.</li><li><code>5xx</code>: Status codes in the 5xx range.</li><li>Any integer in the range <code>[0, 600)</code>.</li></ul></li></ul>**Note**: When <code>DimensionName</code> is not empty, only the <code>equals</code> operator is supported.
        /// </summary>
        [JsonProperty("Filters")]
        public QueryCondition[] Filters{ get; set; }

        /// <summary>
        /// Query dimension name. Valid values:
        /// <ul><li><strong>domain</strong>: The domain name requested by the client. If EdgeOne is accessed via a wildcard domain name, the data records the wildcard domain name.
        /// When using the domain dimension, the <code>Filters</code> parameter must include the <code>domain</code> filter item, specifying a list of up to 100 domain names.</li><li><strong>origin-status-code</strong>: Origin status code, such as 200 or 404.
        /// This dimension is supported only when <code>MetricNames = ["l7Flow_request_hy"]</code>.</li><li><strong>origin-status-code-category</strong>: Origin status code category, such as 2xx or 4xx.
        /// This dimension is supported only when <code>MetricNames = ["l7Flow_request_hy"]</code>.</li></ul><p>If <code>DimensionName</code> is left empty, data is aggregated by the <code>AppId</code> dimension by default, returning a single set of data.</p><p>If <code>DimensionName</code> is specified, time series data is returned grouped by the specified dimension. For example:</p><ul>When <code>DimensionName = origin-status-code</code>:<ul><li><code>TimingDataRecords.TypeKey</code> in the returned data is the specific origin status code, such as 200.</li><li><code>TimingDataRecords.TypeValue</code> in the returned data is the time series data corresponding to that status code.</li></ul></ul><p><strong>Note</strong>: When <code>DimensionName</code> is specified, concurrent calls are not allowed. Exceeding the query rate limit will return the error <code><strong>InvalidParameter.ActionInProgress</strong></code>.</p>
        /// </summary>
        [JsonProperty("DimensionName")]
        public string DimensionName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamArraySimple(map, prefix + "MetricNames.", this.MetricNames);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "DimensionName", this.DimensionName);
        }
    }
}

