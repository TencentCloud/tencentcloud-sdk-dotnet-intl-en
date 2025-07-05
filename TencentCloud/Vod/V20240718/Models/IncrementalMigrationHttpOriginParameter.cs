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

namespace TencentCloud.Vod.V20240718.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IncrementalMigrationHttpOriginParameter : AbstractModel
    {
        
        /// <summary>
        /// HTTP header passthrough information.
        /// </summary>
        [JsonProperty("HttpHeaderInfo")]
        public IncrementalMigrationHttpHeaderInfo HttpHeaderInfo{ get; set; }

        /// <summary>
        /// Back-to-source protocol. Valid values:
        /// <li>HTTP: Force HTTP;</li>
        /// <li>HTTPS: Force HTTPS;</li>
        /// <li>FOLLOW: Follow the request protocol.</li>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Query string passthrough mode. Valid values
        /// <li>FOLLOW: Fully passthrough;</li>
        /// <li>IGNORE: No passthrough at all.</li>
        /// </summary>
        [JsonProperty("QueryStringFollowMode")]
        public string QueryStringFollowMode{ get; set; }

        /// <summary>
        /// HTTP Code for redirection. Currently, only `301`, `302`, and `307` are supported. The default value is `302`.
        /// </summary>
        [JsonProperty("HttpRedirectCode")]
        public ulong? HttpRedirectCode{ get; set; }

        /// <summary>
        /// Origin server redirection follow mode. Valid values:
        /// <li>FOLLOW: Follow origin server redirection;</li>
        /// <li>IGNORE: Ignore origin server redirection.</li>
        /// </summary>
        [JsonProperty("OriginRedirectionFollowMode")]
        public string OriginRedirectionFollowMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "HttpHeaderInfo.", this.HttpHeaderInfo);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "QueryStringFollowMode", this.QueryStringFollowMode);
            this.SetParamSimple(map, prefix + "HttpRedirectCode", this.HttpRedirectCode);
            this.SetParamSimple(map, prefix + "OriginRedirectionFollowMode", this.OriginRedirectionFollowMode);
        }
    }
}

