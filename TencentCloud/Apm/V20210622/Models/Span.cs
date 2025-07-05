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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Span : AbstractModel
    {
        
        /// <summary>
        /// Trace ID
        /// </summary>
        [JsonProperty("TraceID")]
        public string TraceID{ get; set; }

        /// <summary>
        /// Log.
        /// </summary>
        [JsonProperty("Logs")]
        public SpanLog[] Logs{ get; set; }

        /// <summary>
        /// Tag.
        /// </summary>
        [JsonProperty("Tags")]
        public SpanTag[] Tags{ get; set; }

        /// <summary>
        /// Submit application service information.
        /// </summary>
        [JsonProperty("Process")]
        public SpanProcess Process{ get; set; }

        /// <summary>
        /// Generated timestamp (ms).
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// Span name.
        /// </summary>
        [JsonProperty("OperationName")]
        public string OperationName{ get; set; }

        /// <summary>
        /// Association relationship.
        /// </summary>
        [JsonProperty("References")]
        public SpanReference[] References{ get; set; }

        /// <summary>
        /// Generated timestamp (ms).
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// Duration (ms).
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// Span ID
        /// </summary>
        [JsonProperty("SpanID")]
        public string SpanID{ get; set; }

        /// <summary>
        /// Generated timestamp (ms).
        /// </summary>
        [JsonProperty("StartTimeMillis")]
        public long? StartTimeMillis{ get; set; }

        /// <summary>
        /// Parent Span ID
        /// </summary>
        [JsonProperty("ParentSpanID")]
        public string ParentSpanID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TraceID", this.TraceID);
            this.SetParamArrayObj(map, prefix + "Logs.", this.Logs);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "Process.", this.Process);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "OperationName", this.OperationName);
            this.SetParamArrayObj(map, prefix + "References.", this.References);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "SpanID", this.SpanID);
            this.SetParamSimple(map, prefix + "StartTimeMillis", this.StartTimeMillis);
            this.SetParamSimple(map, prefix + "ParentSpanID", this.ParentSpanID);
        }
    }
}

