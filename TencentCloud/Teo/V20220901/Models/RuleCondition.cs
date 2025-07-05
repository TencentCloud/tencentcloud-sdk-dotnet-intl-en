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

    public class RuleCondition : AbstractModel
    {
        
        /// <summary>
        /// Operator. Valid values:
        /// <li>`equal`: Equal</li>
        /// <li>`notEquals`: Does not equal</li>
        /// <li>`exist`: Exists</li>
        /// <li>`notexist`: Does not exist</li>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// Matching type. Valid values: <li>filename: Filename;</li><li>extension: File suffix;</li><li>host: Host;</li><li>full_url: A complete URL path under the current site, including the HTTP protocol, the host, and the path;</li><li>url: The request for a URL path under the current site;</li><li>client_country: Client country/region;</li><li>query_string: The query string for a requested URL under the current site;</li><li>request_header: HTTP request header;</li><li>client_ip: Client IP;</li><li>request_protocol: Request protocol;</li><li>request_method: HTTP request method.</li>
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// Parameter values for corresponding matching types. It is allowed to pass an empty array only when the matching type is query_string or request_header and the operator value is exist or not exist. Corresponding match types include:
        /// <li>extension: File suffix such as jpg or txt;</li>
        /// <li> filename: For example, foo in foo.jpg;</li>
        /// <li> all (any request under the site): all;</li>
        /// <li> host: The host under the current site. For example, www.maxx55.com;</li>
        /// <li> URL path: The request for a URL path under the current site. For example, /example;</li>
        /// <li> URL full: The request for a complete URL under the current site, including the HTTP protocol, the host, and the path. For example: https://www.maxx55.cn/example;</li>
        /// <li> client_country: Country/region identifier compliant with the ISO3166 standard;</li>
        /// <li> query_string: The parameter value in the query string of the requested URL under the current site. For example, cn and 1 in lang=cn&version=1;</li>
        /// <li> request_header: The value of the HTTP request header field. For example, zh-CN,zh;q=0.9 in Accept-Language:zh-CN,zh;q=0.9;</li>
        /// <li> client_ip: The client request IP carried in the current request, which supports IPv4/IPv6 and an IP range;</li>
        /// <li> request_protocol: The protocol of the current request. Valid values: HTTP and HTTPS;</li>
        /// <li> request_method: The method of the current request. Valid values: GET, HEAD, POST, PUT, DELETE, TRACE, CONNECT, OPTIONS, PATCH, COPY, LOCK, MKCOL, MOVE, PROPFIND, PROPPATCH, and UNLOCK. </li>
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }

        /// <summary>
        /// Whether the parameter value is case insensitive. Default value: false.
        /// </summary>
        [JsonProperty("IgnoreCase")]
        public bool? IgnoreCase{ get; set; }

        /// <summary>
        /// The parameter name of the match type. This field is required only when `Target=query_string/request_header`.
        /// <li>`query_string`: Name of the query string, such as "lang" and "version" in "lang=cn&version=1".</li>
        /// <li>`request_header`: Name of the HTTP request header, such as "Accept-Language" in the "Accept-Language:zh-CN,zh;q=0.9" header.</li>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Whether the parameter name is case insensitive. Default value: `false`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IgnoreNameCase")]
        [System.Obsolete]
        public bool? IgnoreNameCase{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
            this.SetParamSimple(map, prefix + "IgnoreCase", this.IgnoreCase);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IgnoreNameCase", this.IgnoreNameCase);
        }
    }
}

