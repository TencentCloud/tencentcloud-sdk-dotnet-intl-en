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

    public class SpanReference : AbstractModel
    {
        
        /// <summary>
        /// Type of association relationship.
        /// </summary>
        [JsonProperty("RefType")]
        public string RefType{ get; set; }

        /// <summary>
        /// Span ID
        /// </summary>
        [JsonProperty("SpanID")]
        public string SpanID{ get; set; }

        /// <summary>
        /// Trace ID
        /// </summary>
        [JsonProperty("TraceID")]
        public string TraceID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RefType", this.RefType);
            this.SetParamSimple(map, prefix + "SpanID", this.SpanID);
            this.SetParamSimple(map, prefix + "TraceID", this.TraceID);
        }
    }
}

