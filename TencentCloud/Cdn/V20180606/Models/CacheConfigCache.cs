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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CacheConfigCache : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable path cache. Values:
        /// `on`: Enable
        /// `off`: Disable
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Cache expiration time settings
        /// Unit: second. The maximum value is 365 days.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CacheTime")]
        public long? CacheTime{ get; set; }

        /// <summary>
        /// Advanced cache expiration configuration. If this is enabled, the max-age value returned by the origin server will be compared with the cache expiration time set in CacheRules, and the smallest value will be cached on the node.
        /// `on`: Enable
        /// `off`: Disable
        /// This is disabled by default.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CompareMaxAge")]
        public string CompareMaxAge{ get; set; }

        /// <summary>
        /// Force cache
        /// `on`: Enable
        /// `off`: Disable
        /// This is disabled by default. If enabled, the `no-store` and `no-cache` resources returned from the origin server will be cached according to `CacheRules` rules.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IgnoreCacheControl")]
        public string IgnoreCacheControl{ get; set; }

        /// <summary>
        /// Whether to ignore the header and body on cache nodes if the origin server returns the header `Set-Cookie`.
        /// `on`: Ignore; do not cache the header and body.
        /// `off`: Do not ignore; follow the custom cache rules of cache nodes.
        /// It is disabled by default.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IgnoreSetCookie")]
        public string IgnoreSetCookie{ get; set; }

        /// <summary>
        /// Whether to enable origin server mtime verification after cache expires. valid values: equal, since, none, and null. default value: equal, which validates the origin server file's mtime and length. domains created prior to 2024-09-12 18:00 default to null, with behavior remaining unchanged.
        /// equal: the mtime in the origin server response must match the mtime in the cache. if there is a difference in parameter values, purge the cache.
        /// since: purges cache if the origin server response mtime is larger than the cache mtime.
        /// none: when the cache expires and the file is retrieved from the origin server again to get the mtime and Length, it does not validate the mtime in the origin response. if the origin response carries a Content-Length header, the cache is updated only when the file size changes. if the origin response does not carry a Content-Length header, the cache is updated.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OriginMtimeCheckType")]
        public string OriginMtimeCheckType{ get; set; }


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
            this.SetParamSimple(map, prefix + "OriginMtimeCheckType", this.OriginMtimeCheckType);
        }
    }
}

