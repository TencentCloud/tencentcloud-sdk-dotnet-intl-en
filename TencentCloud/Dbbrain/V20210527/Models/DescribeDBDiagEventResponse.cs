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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBDiagEventResponse : AbstractModel
    {
        
        /// <summary>
        /// Diagnosis item.
        /// </summary>
        [JsonProperty("DiagItem")]
        public string DiagItem{ get; set; }

        /// <summary>
        /// Diagnosis type.
        /// </summary>
        [JsonProperty("DiagType")]
        public string DiagType{ get; set; }

        /// <summary>
        /// Event ID.
        /// </summary>
        [JsonProperty("EventId")]
        public long? EventId{ get; set; }

        /// <summary>
        /// Diagnosis event details. If there is no additional explanation information, the output will be empty.
        /// </summary>
        [JsonProperty("Explanation")]
        public string Explanation{ get; set; }

        /// <summary>
        /// Diagnosis summary.
        /// </summary>
        [JsonProperty("Outline")]
        public string Outline{ get; set; }

        /// <summary>
        /// Found problem.
        /// </summary>
        [JsonProperty("Problem")]
        public string Problem{ get; set; }

        /// <summary>
        /// Severity, which can be divided into 5 levels: `1` (Critical), `2` (Severe), `3` (Alarm), `4` (Reminder), `5` (healthy).
        /// </summary>
        [JsonProperty("Severity")]
        public long? Severity{ get; set; }

        /// <summary>
        /// Start time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Suggestions. If there are no suggestions, the output will be empty.
        /// </summary>
        [JsonProperty("Suggestions")]
        public string Suggestions{ get; set; }

        /// <summary>
        /// Reserved field.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// End time.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiagItem", this.DiagItem);
            this.SetParamSimple(map, prefix + "DiagType", this.DiagType);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "Explanation", this.Explanation);
            this.SetParamSimple(map, prefix + "Outline", this.Outline);
            this.SetParamSimple(map, prefix + "Problem", this.Problem);
            this.SetParamSimple(map, prefix + "Severity", this.Severity);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Suggestions", this.Suggestions);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

