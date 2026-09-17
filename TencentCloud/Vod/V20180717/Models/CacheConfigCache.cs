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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CacheConfigCache : AbstractModel
    {
        
        /// <summary>
        /// Path cache configuration switch. Valid values:
        /// <li>`on`: Enable;</li>
        /// <li>`off`: Cache.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CacheTime")]
        public ulong? CacheTime{ get; set; }

        /// <summary>
        /// Advanced cache expiration configuration. When enabled, the max-age value returned by the origin server is compared with the cache expiration time set in CacheRules, and the minimum value is used for node caching. Valid values:
        /// <li>`on`: Enable;</li>
        /// <li>`off`: Cache.</li>
        /// </summary>
        [JsonProperty("CompareMaxAge")]
        public string CompareMaxAge{ get; set; }

        /// <summary>
        /// Force cache. Value:
        /// <li>`on`: Enable;</li>
        /// <li>`off`: Cache.</li>
        /// </summary>
        [JsonProperty("IgnoreCacheControl")]
        public string IgnoreCacheControl{ get; set; }

        /// <summary>
        /// Whether to cache the Set-Cookie header and body on the node when the origin server response contains the Set-Cookie header.
        /// <li>on: Enable. Do not cache the header or body;</li>
        /// <li>off: disabled, following user-defined node cache rules.</li>
        /// </summary>
        [JsonProperty("IgnoreSetCookie")]
        public string IgnoreSetCookie{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "CacheTime", this.CacheTime);
            this.SetParamSimple(map, prefix + "CompareMaxAge", this.CompareMaxAge);
            this.SetParamSimple(map, prefix + "IgnoreCacheControl", this.IgnoreCacheControl);
            this.SetParamSimple(map, prefix + "IgnoreSetCookie", this.IgnoreSetCookie);
        }
    }
}

