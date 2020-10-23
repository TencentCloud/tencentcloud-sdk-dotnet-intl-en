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

    public class AdvancedCache : AbstractModel
    {
        
        /// <summary>
        /// Cache expiration rule
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CacheRules")]
        public AdvanceCacheRule[] CacheRules{ get; set; }

        /// <summary>
        /// Forced cache configuration
        /// on: enabled
        /// off: disabled
        /// When this is enabled, if the origin server returns no-cache, no-store headers, node caching will still be performed according to the cache expiration rules.
        /// This is disabled by default
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IgnoreCacheControl")]
        public string IgnoreCacheControl{ get; set; }

        /// <summary>
        /// Ignore the Set-Cookie header of an origin server
        /// on: enabled
        /// off: disabled
        /// This is disabled by default
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IgnoreSetCookie")]
        public string IgnoreSetCookie{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "CacheRules.", this.CacheRules);
            this.SetParamSimple(map, prefix + "IgnoreCacheControl", this.IgnoreCacheControl);
            this.SetParamSimple(map, prefix + "IgnoreSetCookie", this.IgnoreSetCookie);
        }
    }
}

