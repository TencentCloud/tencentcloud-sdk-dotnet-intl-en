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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Detail : AbstractModel
    {
        
        /// <summary>
        /// The total execution time (in ms) of all slow query statements during the specified period of time
        /// </summary>
        [JsonProperty("TotalTime")]
        public float? TotalTime{ get; set; }

        /// <summary>
        /// The total number of all slow query statements during the specified period of time
        /// </summary>
        [JsonProperty("TotalCallNum")]
        public ulong? TotalCallNum{ get; set; }

        /// <summary>
        /// The statistical analysis list of slow queries
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AnalysisItems")]
        public AnalysisItems[] AnalysisItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalTime", this.TotalTime);
            this.SetParamSimple(map, prefix + "TotalCallNum", this.TotalCallNum);
            this.SetParamArrayObj(map, prefix + "AnalysisItems.", this.AnalysisItems);
        }
    }
}

