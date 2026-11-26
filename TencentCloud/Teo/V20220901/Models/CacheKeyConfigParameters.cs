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

    public class CacheKeyConfigParameters : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable full path cache. Valid values:
        /// <li>on: enable full path cache (i.e., disable parameter ignoring);</li>
        /// <li>off: Disable full path cache (parameter ignorable enabled).</li>
        /// </summary>
        [JsonProperty("FullURLCache")]
        public string FullURLCache{ get; set; }

        /// <summary>
        /// Whether to ignore case-insensitive cache. Valid values:
        /// <li>on: Ignore;</li>
        /// <li>off: Not ignore.</li>
        /// </summary>
        [JsonProperty("IgnoreCase")]
        public string IgnoreCase{ get; set; }

        /// <summary>
        /// Query string retention configuration parameter. This field and FullURLCache must be set simultaneously, but cannot both be on.
        /// </summary>
        [JsonProperty("QueryString")]
        public CacheKeyQueryString QueryString{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FullURLCache", this.FullURLCache);
            this.SetParamSimple(map, prefix + "IgnoreCase", this.IgnoreCase);
            this.SetParamObj(map, prefix + "QueryString.", this.QueryString);
        }
    }
}

