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

    public class FollowOrigin : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable the configuration of following the origin server. Valid values:
        /// <li>`on`: Enable</li>
        /// <li>`off`: Disable</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Whether to cache when an origin server does not return the cache-control header. this field is required when switch is on; when switch is off, this field is not required and will be ineffective if filled. valid values:.
        /// <Li>On: cache;</li>.
        /// <Li>Off: do not cache.</li>.
        /// </summary>
        [JsonProperty("DefaultCache")]
        public string DefaultCache{ get; set; }

        /// <summary>
        /// Whether to use the default caching policy when an origin server does not return the cache-control header. this field is required when defaultcache is set to on; otherwise, it is ineffective. when defaultcachetime is not 0, this field should be off. valid values:.
        /// <Li>On: use the default caching policy.</li>.
        /// <Li>Off: do not use the default caching policy.</li>.
        /// </summary>
        [JsonProperty("DefaultCacheStrategy")]
        public string DefaultCacheStrategy{ get; set; }

        /// <summary>
        /// The default cache time in seconds when an origin server does not return the cache-control header. the value ranges from 0 to 315360000. this field is required when defaultcache is set to on; otherwise, it is ineffective. when defaultcachestrategy is on, this field should be 0.
        /// </summary>
        [JsonProperty("DefaultCacheTime")]
        public long? DefaultCacheTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "DefaultCache", this.DefaultCache);
            this.SetParamSimple(map, prefix + "DefaultCacheStrategy", this.DefaultCacheStrategy);
            this.SetParamSimple(map, prefix + "DefaultCacheTime", this.DefaultCacheTime);
        }
    }
}

