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
        /// <li> equal: equal to; </li>
        /// <li> notequal: neq;</li>
        /// <li> exist: exist; </li>
        /// <li> notexist: Not found.</li>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// Matching type. Valid values: <li>filename: Filename;</li><li>extension: File suffix;</li><li>host: Host;</li><li>full_url: A complete URL path under the current site, including the HTTP protocol, the host, and the path;</li><li>url: The request for a URL path under the current site;</li><li>client_country: Client country/region;</li><li>query_string: The query string for a requested URL under the current site;</li><li>request_header: HTTP request header;</li><li>client_ip: Client IP;</li><li>request_protocol: Request protocol;</li><li>request_method: HTTP request method.</li>
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// Parameter values for match types. An empty array is allowed only when the match type is query_string or request_header and the operator is Exist or Does Not Exist. The corresponding matching types are:
        /// <li>extension: File suffix such as jpg or txt;</li>
        /// <li> File name: For example, foo in foo.jpg;</li>
        /// <li> All (arbitrary request to the site): all;</li>
        /// <li> HOST: The host under the current site, for example, www.maxx55.com;</li>
        /// <li> URL Path: Request for the URL path under the current site, for example, /example;</li>
        /// <li> URL Full: complete URL request under the current site, must contain HTTP protocol, Host, and path, for example: https://www.maxx55.cn/example;</li>
        /// <li> client_country: Country/region identifier compliant with the ISO3166 standard;</li>
        /// <li> Query string: The parameter values in the query string of the URL requested under the current site, for example, cn and 1 in lang=cn&version=1; </li>
        /// <li> request_header: The value of the HTTP request header field. For example, zh-CN,zh;q=0.9 in Accept-Language:zh-CN,zh;q=0.9;</li>
        /// <li> client_ip: The client request IP carried in the current request, which supports IPv4/IPv6 and an IP range;</li>
        /// <li>Request protocol: protocol of current request. Value range: HTTP, HTTPS;</li>
        /// <li> request_method: The method of the current request. Valid values: GET, HEAD, POST, PUT, DELETE, TRACE, CONNECT, OPTIONS, PATCH, COPY, LOCK, MKCOL, MOVE, PROPFIND, PROPPATCH, and UNLOCK. </li>
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }

        /// <summary>
        /// Whether to ignore the case sensitivity of parameter values. Default value: `false`.
        /// </summary>
        [JsonProperty("IgnoreCase")]
        public bool? IgnoreCase{ get; set; }

        /// <summary>
        /// Name of the parameter for the corresponding matching type. Valid when Target is set to the following values, and the value cannot be empty:
        /// <li> query_string: The parameter names in the query string of the URL requested under the current site, for example, lang and version in lang=cn&version=1; </li>
        /// <li> request_header: The name of the HTTP request header field. For example, Accept-Language in Accept-Language:zh-CN,zh;q=0.9. </li>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Whether to ignore the case sensitivity of parameter names. Default value: `false`.
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

