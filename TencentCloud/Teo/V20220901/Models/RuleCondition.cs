/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// <li>`equals`: Equals</li>
        /// <li>`notEquals`: Does not equal</li>
        /// <li>`exist`: Exists</li>
        /// <li>`notexist`: Does not exist</li>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// Match type. Valid values: <li> filename: File name; </li> <li> extension: File extension; </li> <li> host: Host name; </li> <li> full_url: The complete URL path under the current site, which must include the HTTP protocol, host, and path; </li> <li> url: Request for the URL path under the current site; </li><li> client_country: Client country/region;</li> <li> query_string: The query string of the URL requested under the current site; </li> <li> request_header: HTTP request header; </li><li> client_ip: Client IP address. </li>
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// The parameter values for match types. It is allowed to pass an empty array only when the match type is query_string or request_header and the operator value is Exist or Does Not Exist. The corresponding match types include:
        /// <li> File extension: Extensions like jpg, txt, etc.;</li>
        /// <li> File name: For example, foo in foo.jpg;</li>
        /// <li> All: All requests for domain names under the site; </li>
        /// <li> HOST: The host under the current site, for example, www.maxx55.com;</li>
        /// <li> URL Path: Request for the URL path under the current site, for example, /example;</li>
        /// <li> URL Full: The complete URL request under the current site, which must include the HTTP protocol, host, and path, for example, https://www.maxx55.cn/example;</li>
        /// <li> Client country/region: Country/region codes compliant with the ISO3166 standard;</li>
        /// <li> Query string: The parameter values in the query string of the URL requested under the current site, for example, cn and 1 in lang=cn&version=1; </li>
        /// <li> HTTP request header: The value of the HTTP request header field, for example, zh-CN,zh;q=0.9 in Accept-Language:zh-CN,zh;q=0.9; </li>
        /// <li> Client IP: The client IP address carried by the current request, supporting IPv4, IPv6, and an IP range. </li>
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

