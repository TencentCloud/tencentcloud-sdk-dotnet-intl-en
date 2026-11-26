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

    public class CacheKeyParameters : AbstractModel
    {
        
        /// <summary>
        /// Switch to retain all query strings. Valid values:
        /// <li>`on`: Enable;</li>
        /// <li>off: disabled.</li>Note: At least one configuration must be set for FullURLCache, IgnoreCase, Header, Scheme, and Cookie. This field and QueryString.Switch must be set both at the same time, but they cannot both be on.
        /// </summary>
        [JsonProperty("FullURLCache")]
        public string FullURLCache{ get; set; }

        /// <summary>
        /// Query string reserved configuration parameter. This field and FullURLCache must be set simultaneously, but cannot both be on.
        /// </summary>
        [JsonProperty("QueryString")]
        public CacheKeyQueryString QueryString{ get; set; }

        /// <summary>
        /// Case-insensitive switch. Valid values:
        /// <li>`on`: Enable;</li>
        /// <li>off: disabled.</li>Note: Configure at least one of FullURLCache, IgnoreCase, Header, Scheme, and Cookie.
        /// </summary>
        [JsonProperty("IgnoreCase")]
        public string IgnoreCase{ get; set; }

        /// <summary>
        /// HTTP request header configuration parameters. Set at least one configuration for FullURLCache, IgnoreCase, Header, Scheme, or Cookie.
        /// </summary>
        [JsonProperty("Header")]
        public CacheKeyHeader Header{ get; set; }

        /// <summary>
        /// Request protocol switch. Valid values:
        /// <li>`on`: Enable;</li>
        /// <li>off: disabled.</li>Note: Configure at least one of FullURLCache, IgnoreCase, Header, Scheme, and Cookie.
        /// </summary>
        [JsonProperty("Scheme")]
        public string Scheme{ get; set; }

        /// <summary>
        /// Cookie configuration parameters. Set at least one configuration for FullURLCache, IgnoreCase, Header, Scheme, or Cookie.
        /// </summary>
        [JsonProperty("Cookie")]
        public CacheKeyCookie Cookie{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FullURLCache", this.FullURLCache);
            this.SetParamObj(map, prefix + "QueryString.", this.QueryString);
            this.SetParamSimple(map, prefix + "IgnoreCase", this.IgnoreCase);
            this.SetParamObj(map, prefix + "Header.", this.Header);
            this.SetParamSimple(map, prefix + "Scheme", this.Scheme);
            this.SetParamObj(map, prefix + "Cookie.", this.Cookie);
        }
    }
}

