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

    public class AccessURLRedirectParameters : AbstractModel
    {
        
        /// <summary>
        /// <p>Status code, value is one of 301, 302, 303, 307, 308.</p>
        /// </summary>
        [JsonProperty("StatusCode")]
        public long? StatusCode{ get; set; }

        /// <summary>
        /// <p>Target request protocol.</p><p>Enumeration values:</p><ul><li>http: The target request protocol is HTTP.</li><li>https: The target request protocol is HTTPS.</li><li>follow: Follow request.</li></ul>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>Target HostName.</p>
        /// </summary>
        [JsonProperty("HostName")]
        public HostName HostName{ get; set; }

        /// <summary>
        /// <p>Target path.</p>
        /// </summary>
        [JsonProperty("URLPath")]
        public URLPath URLPath{ get; set; }

        /// <summary>
        /// <p>Query string.</p>
        /// </summary>
        [JsonProperty("QueryString")]
        public AccessURLRedirectQueryString QueryString{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamObj(map, prefix + "HostName.", this.HostName);
            this.SetParamObj(map, prefix + "URLPath.", this.URLPath);
            this.SetParamObj(map, prefix + "QueryString.", this.QueryString);
        }
    }
}

