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

    public class DescribeLogAnalysisStatisticsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Site ID.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>Data ownership region. Available values:</p><ul><li>mainland: within the Chinese mainland;</li><li>overseas: global (excluding the Chinese mainland).</li></ul>Note: If the site service area is "global availability zone", to obtain all data, query the data of mainland and overseas separately.<p></p>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// <p>Log type. Available values:</p><ul><li> l7-access-logs: L7 access log;</li><li>web-attack: managed rule log.</li></ul>Default value: l7-access-logs.<p></p>
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// <p>Start time. Example value: 2020-04-29T00:00:00Z. The maximum span from the query start time to this day varies by package version. For details, see <a href="https://www.tencentcloud.com/document/product/1552/94165?from_cn_redirect=1#45435466-9103-4ff6-be22-e31717044fb2">Package Selection Comparison</a>.</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>End time, for example, 2020-04-30T00:00:00Z. The maximum time span from start time to end time per request is 31 days.</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>Statistical query statement, composed of [<a href="https://www.tencentcloud.com/document/product/1552/124662?from_cn_redirect=1">retrieval criteria</a>] | [<a href="https://www.tencentcloud.com/document/product/1552/124662?from_cn_redirect=1">SQL statement</a>]. The SQL segment after the pipe character "|" is required. The retrieval criteria segment can be empty (for example, | SELECT ...), which means aggregation on full data. Maximum length: 12 KB. Default SQL Limit: 100. Maximum Limit: 10000.<br>Example:</p><p>With retrieval criteria: <code>${EdgeCacheStatus} in ['miss','other'] | select EdgeCacheStatus as status, count(*) as cnt group by status limit 2</code></p><p>Without retrieval criteria: <code>| select EdgeCacheStatus as status, count(*) as cnt group by status</code></p>
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Query", this.Query);
        }
    }
}

