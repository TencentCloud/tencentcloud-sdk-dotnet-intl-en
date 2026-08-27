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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUsageRankListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Statistical dimension. Values: apikey (statistics by APIKey), endpoint (statistics by access point), model (statistics by model).</p>
        /// </summary>
        [JsonProperty("Dimension")]
        public string Dimension{ get; set; }

        /// <summary>
        /// <p>Start time (inclusive interval), in RFC3339 format.</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>End time (open interval) in RFC3339 format. The maximum span from StartTime is 90 days.</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>Metric family switch field.</p><ul><li>tokens (default): Token consumption chart (statistics=sum), supports Dimension = apikey/endpoint/model</li><li>search [to be launched]: Online search call count (statistics=sum), only supports Dimension = model</li><li>Other values return InvalidParameter.</li></ul><p>Enum values:</p><ul><li>tokens: tokens</li></ul>
        /// </summary>
        [JsonProperty("MetricType")]
        public string MetricType{ get; set; }

        /// <summary>
        /// <p>Dimension filtering value. An empty string indicates querying all objects; a non-empty string indicates querying only the specified single object (for example, a designated APIKey ID). Maximum 256 characters.</p>
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// <p>Statistical granularity (seconds). Value: 60, 300, 3600, 86400. Must not be less than the lower limit corresponding to the span: span ≤ 1 day → 60; 1–5 days → 300; 5–10 days → 3600; &gt; 10 days → 86400. Used only when ShowAll=false.</p>
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// <p>Pagination starting point, starting from 0, default 0. Ignore timing when ShowAll=true. Page size fixed as 10.</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>Whether to return full result.</p><ul><li>false (default): Return TopList in pages by Offset (10 items per page). Each object contains <br>Series time series points for drawing curves.</li><li>true: Ignore Offset and return the full object list without Series (CSV export scenario).</li></ul>
        /// </summary>
        [JsonProperty("ShowAll")]
        public bool? ShowAll{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Dimension", this.Dimension);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "MetricType", this.MetricType);
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "ShowAll", this.ShowAll);
        }
    }
}

