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

    public class DescribeDDoSAttackDataRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Start time, which adopts Coordinated Universal Time (UTC) and follows the date and time format of the ISO 8601 standard.</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>End time. The time is in Coordinated Universal Time (UTC), following the ISO 8601 standard date and time format. The query time range (<code>EndTime</code> - <code>StartTime</code>) must be less than or equal to 31 days.</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>List of statistical metrics. Fill in at least 1, and duplication is not allowed.</p><p>Enumeration values:</p><ul><li>ddos_attackMaxBandwidth: Peak attack bandwidth, in bps;</li><li>ddos_attackMaxPackageRate: Peak attack packet rate, in pps;</li><li>ddos_attackBandwidth: Attack bandwidth curve, in bps;</li><li>ddos_attackPackageRate: Attack packet rate curve, in pps.</li></ul>
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// <p>Site ID set. This parameter will change from optional to required after May 30, 2024. For details, see the announcement: <a href="https://www.tencentcloud.com/document/product/1552/104902?from_cn_redirect=1">[Tencent Cloud EdgeOne] Cloud API Change Notification</a>. You can import up to 100 site IDs. To query all site data under the Tencent Cloud root account, use <code>*</code> instead. To query account-level data, you must have permission for all site resources of this interface.</p>
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// <p>List of DDoS policy group IDs. If not specified, all policy IDs are selected by default.</p>
        /// </summary>
        [JsonProperty("PolicyIds")]
        public long?[] PolicyIds{ get; set; }

        /// <summary>
        /// <p>Query time granularity. If this parameter is not input, the granularity will be automatically inferred based on the interval between the start time and end time. Specifically, the granularity value is min, 5min, hour, and day respectively for queries of data within 1 hour, within 2 days, within 7 days, and over 7 days.</p><p>Enumeration values:</p><ul><li>min: 1 minute;</li><li>5min: 5 minutes;</li><li>hour: 1 hour;</li><li>day: 1 day.</li></ul>
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// <p>Data ownership region.</p><p>Enumeration values:</p><ul><li>overseas: global data (excluding the Chinese mainland);</li><li>mainland: data in the Chinese mainland;</li><li>global: global data.</li></ul><p>Default value: global</p>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// <p>Filter conditions. The maximum number of QueryCondition.Value collections is 20. The detailed filter conditions for QueryCondition.Key values are as follows:</p><li>ddos-attack-dip: filter by DDoS attack destination IP. QueryCondition.Operator only supports equals.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public QueryCondition[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "MetricNames.", this.MetricNames);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamArraySimple(map, prefix + "PolicyIds.", this.PolicyIds);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

