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

namespace TencentCloud.Antiddos.V20250903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDDoSBlockRecordsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Start time of the query. Support up to data query for the past one year.</p><p>Parameter format: 2026-02-04T11:30:00+08:00.</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>End time of query. The query time range (EndTime - StartTime) must be less than or equal to 31 days.</p><p>Parameter format: 2026-03-04T11:30:00+08:00.</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>Filter criteria. The maximum number of Filters.Values is 20. If this parameter is left empty, return the current list of resources blocked under the appid. Detailed filter criteria:</p><ul><li> Resource: Filter by blocked IP or six-segment resource format;</li><li> Status: Filter by blocked resource status.</li></ul><p>When Filters.Name value is Status, Filters.Values valid values:</p><ul><li>Blocked: blocked;</li><li>Unblocking: unblocking;</li><li>Unblocked: unblocked.</li></ul>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>Paginated query limit count. Maximum value: 100.</p><p>Default value: 20</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>Paginated query offset.</p><p>Default value: 0.</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

