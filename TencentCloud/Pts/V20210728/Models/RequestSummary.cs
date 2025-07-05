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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RequestSummary : AbstractModel
    {
        
        /// <summary>
        /// Request URL.
        /// </summary>
        [JsonProperty("Service")]
        public string Service{ get; set; }

        /// <summary>
        /// Request method.
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// Number of requests.
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// Average request response time (seconds).
        /// </summary>
        [JsonProperty("Average")]
        public float? Average{ get; set; }

        /// <summary>
        /// Request p90 latency (seconds).
        /// </summary>
        [JsonProperty("P90")]
        public float? P90{ get; set; }

        /// <summary>
        /// Request p95 latency (seconds).
        /// </summary>
        [JsonProperty("P95")]
        public float? P95{ get; set; }

        /// <summary>
        /// Minimum request latency (seconds).
        /// </summary>
        [JsonProperty("Min")]
        public float? Min{ get; set; }

        /// <summary>
        /// Maximum request latency (seconds).
        /// </summary>
        [JsonProperty("Max")]
        public float? Max{ get; set; }

        /// <summary>
        /// Request error rate.
        /// </summary>
        [JsonProperty("ErrorPercentage")]
        public float? ErrorPercentage{ get; set; }

        /// <summary>
        /// Request p99 latency (seconds).
        /// </summary>
        [JsonProperty("P99")]
        public float? P99{ get; set; }

        /// <summary>
        /// Response status code.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Response details.
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// Request per seconds, unit req/s.
        /// </summary>
        [JsonProperty("RPS")]
        public float? RPS{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Service", this.Service);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Average", this.Average);
            this.SetParamSimple(map, prefix + "P90", this.P90);
            this.SetParamSimple(map, prefix + "P95", this.P95);
            this.SetParamSimple(map, prefix + "Min", this.Min);
            this.SetParamSimple(map, prefix + "Max", this.Max);
            this.SetParamSimple(map, prefix + "ErrorPercentage", this.ErrorPercentage);
            this.SetParamSimple(map, prefix + "P99", this.P99);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "RPS", this.RPS);
        }
    }
}

