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
        /// Origin-Pull URL rewrite type. valid values: Path.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Origin-Pull URL rewrite action. valid values:.
        /// <li><b>replace</b>: replace the full Path. used to replace the complete request URL Path with the specified Path.
        /// </li>
        /// <li><b>addPrefix</b>: add Path prefix. used to add specified Path prefix to request URL Path.</li>.
        /// </li>
        /// <li><b>rmvPrefix</b>: specifies the removal of Path prefix. used to remove the specified Path prefix from the request URL Path.
        /// </li>
        /// <li><b>regexReplace</b>: refers to regular expression replacement of the full path. used for matching and replacing the full path via Google RE2 regular expressions.
        /// </li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// Origin-Pull URL rewrite value. should meet URL Path standard and ensure the rewritten Path starts with / to prevent the Host of the origin-pull URL from being modified, with a length range of 1–1024. when Action is addPrefix, it cannot end with /. when Action is rmvPrefix, * cannot exist. when Action is regexReplace, $NUM can be used to refer to regular expression capture groups, where NUM represents the group number, such as $1, and supports up to $9.
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// Origin-Pull URL rewrite used for regex replacement to match the full path regular expression. should meet Google RE2 standard with length range 1–1024. this field is required when Action is regexReplace, otherwise not required.
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

