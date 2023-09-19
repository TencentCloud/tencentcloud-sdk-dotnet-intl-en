/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CommonMetrics : AbstractModel
    {
        
        /// <summary>
        /// The task creation time in ms.
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTaskTime")]
        public float? CreateTaskTime{ get; set; }

        /// <summary>
        /// The processing time in ms.
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProcessTime")]
        public float? ProcessTime{ get; set; }

        /// <summary>
        /// The queue time in ms.
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QueueTime")]
        public float? QueueTime{ get; set; }

        /// <summary>
        /// The execution duration in ms.
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExecutionTime")]
        public float? ExecutionTime{ get; set; }

        /// <summary>
        /// Whether the result cache is hit.
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsResultCacheHit")]
        public bool? IsResultCacheHit{ get; set; }

        /// <summary>
        /// The volume of matched materialized views, in bytes.
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MatchedMVBytes")]
        public long? MatchedMVBytes{ get; set; }

        /// <summary>
        /// The list of matched materialized views.
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MatchedMVs")]
        public string MatchedMVs{ get; set; }

        /// <summary>
        /// The result data in bytes.
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AffectedBytes")]
        public string AffectedBytes{ get; set; }

        /// <summary>
        /// 	The number of rows in the result.
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AffectedRows")]
        public long? AffectedRows{ get; set; }

        /// <summary>
        /// The volume of the data scanned, in bytes.
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProcessedBytes")]
        public long? ProcessedBytes{ get; set; }

        /// <summary>
        /// 	The number of scanned rows.
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProcessedRows")]
        public long? ProcessedRows{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreateTaskTime", this.CreateTaskTime);
            this.SetParamSimple(map, prefix + "ProcessTime", this.ProcessTime);
            this.SetParamSimple(map, prefix + "QueueTime", this.QueueTime);
            this.SetParamSimple(map, prefix + "ExecutionTime", this.ExecutionTime);
            this.SetParamSimple(map, prefix + "IsResultCacheHit", this.IsResultCacheHit);
            this.SetParamSimple(map, prefix + "MatchedMVBytes", this.MatchedMVBytes);
            this.SetParamSimple(map, prefix + "MatchedMVs", this.MatchedMVs);
            this.SetParamSimple(map, prefix + "AffectedBytes", this.AffectedBytes);
            this.SetParamSimple(map, prefix + "AffectedRows", this.AffectedRows);
            this.SetParamSimple(map, prefix + "ProcessedBytes", this.ProcessedBytes);
            this.SetParamSimple(map, prefix + "ProcessedRows", this.ProcessedRows);
        }
    }
}

