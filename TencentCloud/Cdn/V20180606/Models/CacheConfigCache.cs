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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CacheConfigCache : AbstractModel
    {
        
        /// <summary>
        /// Cache configuration switch
        /// on: enable
        /// off: disable
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Cache expiration time settings
        /// Unit: second. The maximum value is 365 days.
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("CacheTime")]
        public long? CacheTime{ get; set; }

        /// <summary>
        /// Advanced cache expiration configuration. If this is enabled, the max-age value returned by the origin server will be compared with the cache expiration time set in CacheRules, and the smallest value will be cached on the node.
        /// on: enable
        /// off: disable
        /// This is disabled by default.
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("CompareMaxAge")]
        public string CompareMaxAge{ get; set; }

        /// <summary>
        /// Force cache
        /// on: enable
        /// off: disable
        /// This is disabled by default. If enabled, the `no-store` and `no-cache` resources returned from the origin server will be cached according to `CacheRules` rules.
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("IgnoreCacheControl")]
        public string IgnoreCacheControl{ get; set; }

        /// <summary>
        /// Ignore the Set-Cookie header of an origin server.
        /// on: enable
        /// off: disable
        /// This is disabled by default.
        /// Note: this field may return null, indicating that no valid value is obtained.
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

