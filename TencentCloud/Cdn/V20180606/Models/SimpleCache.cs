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

    public class SimpleCache : AbstractModel
    {
        
        /// <summary>
        /// Cache expiration time rules
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CacheRules")]
        public SimpleCacheRule[] CacheRules{ get; set; }

        /// <summary>
        /// Follows origin server Cache-Control: max-age configurations
        /// `on`: Enable
        /// `off`: Disable
        /// If this is enabled, resources that do not match CacheRules rules will be cached by the node according to the max-age value returned by the origin server. Resources that match CacheRules rules will be cached on the node according to the cache expiration time set in CacheRules.
        /// This conflicts with CompareMaxAge. The two cannot be enabled at the same time.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("FollowOrigin")]
        public string FollowOrigin{ get; set; }

        /// <summary>
        /// Forced cache
        /// `on`: Enable
        /// `off`: Disable
        /// This is disabled by default. If enabled, the `no-store` and `no-cache` resources returned from the origin server will be cached according to `CacheRules` rules.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IgnoreCacheControl")]
        public string IgnoreCacheControl{ get; set; }

        /// <summary>
        /// Ignores the Set-Cookie header of the origin server
        /// `on`: Enable
        /// `off`: Disable
        /// It is disabled by default.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IgnoreSetCookie")]
        public string IgnoreSetCookie{ get; set; }

        /// <summary>
        /// Advanced cache expiration configuration. If this is enabled, the max-age value returned by the origin server will be compared with the cache expiration time set in CacheRules, and the smallest value will be cached on the node.
        /// `on`: Enable
        /// `off`: Disable
        /// It is disabled by default.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CompareMaxAge")]
        public string CompareMaxAge{ get; set; }

        /// <summary>
        /// Always forwards to the origin server for verification
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Revalidate")]
        public Revalidate Revalidate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "CacheRules.", this.CacheRules);
            this.SetParamSimple(map, prefix + "FollowOrigin", this.FollowOrigin);
            this.SetParamSimple(map, prefix + "IgnoreCacheControl", this.IgnoreCacheControl);
            this.SetParamSimple(map, prefix + "IgnoreSetCookie", this.IgnoreSetCookie);
            this.SetParamSimple(map, prefix + "CompareMaxAge", this.CompareMaxAge);
            this.SetParamObj(map, prefix + "Revalidate.", this.Revalidate);
        }
    }
}

