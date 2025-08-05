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

    public class SkipCondition : AbstractModel
    {
        
        /// <summary>
        /// The field type. Values:
        /// <li>`header_fields`: HTTP request header</li>
        /// <li>`cookie`: HTTP request cookie</li>
        /// <li>`query_string`: Query string in the HTTP request URL</li>
        /// <li>`uri`: HTTP request URI</li>
        /// <li>`body_raw`: HTTP request body</li>
        /// <li>`body_json`: JSON HTTP request body</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// The specific field. Values:
        /// <li>`args`: Query parameter in the URI, such as "?name1=jack&age=12"</li>
        /// <li>`path`: Partial path in the URI, such as "/path/to/resource.jpg"</li>
        /// <li>`full`: Full path in the URI, such as "example.com/path/to/resource.jpg?name1=jack&age=12"</li>
        /// <li>`upload_filename`: File path segment</li>
        /// <li>`keys`: All keys</li>
        /// <li>`values`: Values of all keys</li>
        /// <li>`key_value`: Key and its value</li>
        /// </summary>
        [JsonProperty("Selector")]
        public string Selector{ get; set; }

        /// <summary>
        /// The match method used to match the key. Values:
        /// <li>`equal`: Exact match</li>
        /// <li>`wildcard`: Wildcard match (only asterisks)</li>
        /// </summary>
        [JsonProperty("MatchFromType")]
        public string MatchFromType{ get; set; }

        /// <summary>
        /// Match the Key value.
        /// </summary>
        [JsonProperty("MatchFrom")]
        public string[] MatchFrom{ get; set; }

        /// <summary>
        /// The match method used to match the content.
        /// <li>`equal`: Exact match</li>
        /// <li>`wildcard`: Wildcard match (only asterisks)</li>
        /// </summary>
        [JsonProperty("MatchContentType")]
        public string MatchContentType{ get; set; }

        /// <summary>
        /// Match the Value.
        /// </summary>
        [JsonProperty("MatchContent")]
        public string[] MatchContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Selector", this.Selector);
            this.SetParamSimple(map, prefix + "MatchFromType", this.MatchFromType);
            this.SetParamArraySimple(map, prefix + "MatchFrom.", this.MatchFrom);
            this.SetParamSimple(map, prefix + "MatchContentType", this.MatchContentType);
            this.SetParamArraySimple(map, prefix + "MatchContent.", this.MatchContent);
        }
    }
}

