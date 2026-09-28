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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleCondition : AbstractModel
    {
        
        /// <summary>
        /// Forwarding condition type. Valid values:
        /// Host: host.
        /// Path: Path.
        /// Header: HTTP header field.
        /// QueryString: HTTP query string.
        /// Method: Request method.
        /// Cookie:Cookie.
        /// SourceIp: Source IP.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Cookie configuration.
        /// </summary>
        [JsonProperty("CookieConfig")]
        public HTTPCookieInfo[] CookieConfig{ get; set; }

        /// <summary>
        /// HTTP Header configuration.
        /// </summary>
        [JsonProperty("HeaderConfig")]
        public HTTPHeaderInfo HeaderConfig{ get; set; }

        /// <summary>
        /// Host name. The host configuration can only appear once in a rule, with a length of 3 to 128 characters. It supports exact match, regular expression matching, and wildcard matching.
        /// It cannot start or end with a half-width period (.) or underscore (_).
        /// Exact match. Supported character sets: a-z 0-9 . - _ .
        /// Regular expression matching. A value that begins with a tilde (~) indicates regular expression matching. Supported character sets: a-z 0-9 . - ? = ~ _ - + \ ^ * ! $ & | ( ) [ ] .
        /// Wildcard matching. An asterisk (*) matches multiple characters, and a half-width question mark (?) matches any single character. Supported character sets: a-z 0-9 . - _ * ?.
        /// </summary>
        [JsonProperty("HostConfig")]
        public string[] HostConfig{ get; set; }

        /// <summary>
        /// Request method. Parameter values: HEAD, GET, POST, OPTIONS, PUT, PATCH, DELETE.
        /// </summary>
        [JsonProperty("MethodConfig")]
        public string[] MethodConfig{ get; set; }

        /// <summary>
        /// Forwarding path. Length: 1–128 characters. Supports exact matching, regular expression matching, and wildcard matching.
        /// Exact match. Supported character sets: a-z A-Z 0-9 . - _ / = :.
        /// For regular expression matching, it must start with `~`. A `~` at the beginning means case-sensitive, and `~*` at the beginning means case-insensitive. Supported character sets: a-z A-Z 0-9 . - _ / = ? ~ ^ * $ : ( ) [ ] + |.
        /// Wildcard matching. * means multiple character wildcard, and ? means any single character wildcard. Supported character sets: a-z A-Z 0-9 . - _ / = :.
        /// </summary>
        [JsonProperty("PathConfig")]
        public string[] PathConfig{ get; set; }

        /// <summary>
        /// Query string configuration.
        /// </summary>
        [JsonProperty("QueryStringConfig")]
        public HTTPQueryStringInfo[] QueryStringConfig{ get; set; }

        /// <summary>
        /// Source IP matching configuration. CIDR format, IP address x.x.x.x/32, IP range x.x.x.x/24.
        /// </summary>
        [JsonProperty("SourceIpConfig")]
        public string[] SourceIpConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "CookieConfig.", this.CookieConfig);
            this.SetParamObj(map, prefix + "HeaderConfig.", this.HeaderConfig);
            this.SetParamArraySimple(map, prefix + "HostConfig.", this.HostConfig);
            this.SetParamArraySimple(map, prefix + "MethodConfig.", this.MethodConfig);
            this.SetParamArraySimple(map, prefix + "PathConfig.", this.PathConfig);
            this.SetParamArrayObj(map, prefix + "QueryStringConfig.", this.QueryStringConfig);
            this.SetParamArraySimple(map, prefix + "SourceIpConfig.", this.SourceIpConfig);
        }
    }
}

