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

    public class UpstreamURLRewriteParameters : AbstractModel
    {
        
        /// <summary>
        /// Origin-pull URL rewrite type. Only Path is supported.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Origin-pull URL rewrite action. Valid values:
        /// <li><b>replace</b>: Replaces the full Path. It is used to replace the complete request URL Path with the specified Path.</li>
        /// </li>
        /// <li><b>addPrefix</b>: Add a path prefix. It is used to add the specified path prefix to the request URL Path.</li>
        /// </li>
        /// <li><b>rmvPrefix</b>: removes the path prefix. It is used to remove the specified path prefix from the request URL Path.</li>
        /// </li>
        /// <li><b>regexReplace</b>: regular replacement full path. Used to match and replace the full path through Google RE2 regular expressions.</li>
        /// </li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// Origin-pull URL rewrite value. It should meet the URL Path specification and ensure the rewritten Path starts with / to prevent the Host of the origin-pull URL from being modified. Length range: 1–1024. When Action is addPrefix, it cannot end with /. When Action is rmvPrefix, * cannot exist. When Action is regexReplace, $NUM can be used to refer to a regular expression capture group, where NUM represents the group number, for example $1, with support up to $9.
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// Origin-pull URL rewrite uses a regex replacement to match the regular expression of the full path. It should meet the Google RE2 specification with a length range of 1–1024. This field is required when Action is regexReplace. Otherwise, no need to specify this field.
        /// </summary>
        [JsonProperty("Regex")]
        public string Regex{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "Regex", this.Regex);
        }
    }
}

