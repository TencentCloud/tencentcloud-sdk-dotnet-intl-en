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
        /// Exception skip type. Value:
        /// <li>header_fields: HTTP request header;</li>
        /// <li>cookie: HTTP request cookie;</li>
        /// <li>query_string: The query parameter in the HTTP Request URL;</li>
        /// <li>uri: HTTP request URI;</li>
        /// <li>body_raw: HTTP request body;</li>
        /// <li>body_json: HTTP Body in JSON format.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Field to skip. Value:
        /// <li>args: select query parameter under uri: ?name1=jack&age=12;</li>
        /// <li>path: Select a path under the uri: /path/to/resource.jpg;</li>
        /// <li>full: select the full path under uri: example.com/path/to/resource.jpg?name1=jack&age=12;</li>
        /// <li>upload_filename: Segmented file name, that is, when transferring files in segments;</li>
        /// <li>keys: all keys;</li>
        /// <li>values: The value corresponding to the match Key;</li>
        /// <li>key_value: Match key and match value.</li>
        /// </summary>
        [JsonProperty("Selector")]
        public string Selector{ get; set; }

        /// <summary>
        /// Match mode used by the match Key. Value:
        /// <li>equal: exact match, equal to;</li>
        /// <li>wildcard: wildcard match, supports * wildcard.</li>
        /// </summary>
        [JsonProperty("MatchFromType")]
        public string MatchFromType{ get; set; }

        /// <summary>
        /// Value of the match Key.
        /// </summary>
        [JsonProperty("MatchFrom")]
        public string[] MatchFrom{ get; set; }

        /// <summary>
        /// Match mode used by Content. Value:
        /// <li>equal: exact match, equal to;</li>
        /// <li>wildcard: wildcard match, supports * wildcard.</li>
        /// </summary>
        [JsonProperty("MatchContentType")]
        public string MatchContentType{ get; set; }

        /// <summary>
        /// Value of the match Value.
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

