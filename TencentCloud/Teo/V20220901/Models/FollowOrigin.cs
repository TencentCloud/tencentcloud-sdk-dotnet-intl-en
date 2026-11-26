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
        /// Follow the origin site configuration switch. Valid values:
        /// <li>`on`: Enable;</li>
        /// <li>off: Disable.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Whether to cache when an origin server does not return the Cache-Control header. This field is required when Switch is on. When Switch is off, no need to specify this field, and it does not take effect if specified. Valid values:
        /// <li>`on`: cache;</li>
        /// <li>off: Do not cache.</li>
        /// </summary>
        [JsonProperty("DefaultCache")]
        public string DefaultCache{ get; set; }

        /// <summary>
        /// Whether to use the default caching policy when an origin server does not return the Cache-Control header. This field is required when DefaultCache is on; otherwise, it is ineffective. This field must be off when DefaultCacheTime is not 0. Valid values:
        /// <li>on: Use the default caching policy;</li>
        /// <li>off: Do not use the default caching policy.</li>
        /// </summary>
        [JsonProperty("DefaultCacheStrategy")]
        public string DefaultCacheStrategy{ get; set; }

        /// <summary>
        /// The default cache time in seconds when an origin server does not return the Cache-Control header. Value range: 0-315360000. This field is required when DefaultCache is set to on; otherwise, it is ineffective. When DefaultCacheStrategy is on, this field must be 0.
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

