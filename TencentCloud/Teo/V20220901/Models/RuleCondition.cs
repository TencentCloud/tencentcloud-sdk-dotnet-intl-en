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
        /// The match type. Values:
        /// <li>`filename`: File name</li>
        /// <li>`extension`: File extension</li>
        /// <li>`host`: Host</li>
        /// <li>`full_url`: Full URL, which indicates the complete URL path under the current site and must contain the HTTP protocol, host, and path.</li>
        /// <li>`url`: Partial URL under the current site</li><li>`client_country`: Country/Region of the client</li>
        /// <li>`query_string`: Query string in the request URL</li>
        /// <li>`request_header`: HTTP request header</li>
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// The parameter value of the match type. It can be an empty string only when `Target=query string/request header` and `Operator=exist/notexist`.
        /// <li>When `Target=extension`, enter the file extension, such as "jpg" and "txt".</li>
        /// <li>When `Target=filename`, enter the file name, such as "foo" in "foo.jpg".</li>
        /// <li>When `Target=all`, it indicates any site request.</li>
        /// <li>When `Target=host`, enter the host under the current site, such as "www.maxx55.com".</li>
        /// <li>When `Target=url`, enter the partial URL path under the current site, such as "/example".</li>
        /// <li>When `Target=full_url`, enter the complete URL under the current site. It must contain the HTTP protocol, host, and path, such as "https://www.maxx55.cn/example".</li>
        /// <li>When `Target=client_country`, enter the ISO-3166 country/region code.</li>
        /// <li>When `Target=query_string`, enter the value of the query string, such as "cn" and "1" in "lang=cn&version=1".</li>
        /// <li>When `Target=request_header`, enter the HTTP request header value, such as "zh-CN,zh;q=0.9" in the "Accept-Language:zh-CN,zh;q=0.9" header.</li>
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

