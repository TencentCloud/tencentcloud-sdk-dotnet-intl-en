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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApiToolConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Request body parameters</p>
        /// </summary>
        [JsonProperty("Body")]
        public RequestParam[] Body{ get; set; }

        /// <summary>
        /// <p>Example</p>
        /// </summary>
        [JsonProperty("Example")]
        public ToolExample Example{ get; set; }

        /// <summary>
        /// <p>External call address of API plug-in</p>
        /// </summary>
        [JsonProperty("ExternalApiUrl")]
        public string ExternalApiUrl{ get; set; }

        /// <summary>
        /// <p>Header</p>
        /// </summary>
        [JsonProperty("Header")]
        public RequestParam[] Header{ get; set; }

        /// <summary>
        /// <p>Request method</p>
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// <p>Output</p>
        /// </summary>
        [JsonProperty("Outputs")]
        public ResponseParam[] Outputs{ get; set; }

        /// <summary>
        /// <p>Query parameter</p>
        /// </summary>
        [JsonProperty("Query")]
        public RequestParam[] Query{ get; set; }

        /// <summary>
        /// <table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>STREAM_MODE_UNARY</td><td>0</td><td>Non-streaming</td></tr><tr><td>STREAM_MODE_STREAMING</td><td>1</td><td>Streaming</td></tr></tbody></table>
        /// </summary>
        [JsonProperty("StreamMode")]
        public long? StreamMode{ get; set; }

        /// <summary>
        /// <p>Address</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Body.", this.Body);
            this.SetParamObj(map, prefix + "Example.", this.Example);
            this.SetParamSimple(map, prefix + "ExternalApiUrl", this.ExternalApiUrl);
            this.SetParamArrayObj(map, prefix + "Header.", this.Header);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamArrayObj(map, prefix + "Outputs.", this.Outputs);
            this.SetParamArrayObj(map, prefix + "Query.", this.Query);
            this.SetParamSimple(map, prefix + "StreamMode", this.StreamMode);
            this.SetParamSimple(map, prefix + "Url", this.Url);
        }
    }
}

