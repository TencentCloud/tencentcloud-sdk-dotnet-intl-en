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
        /// Whether to cache when an origin server does not return the Cache-Control header. This field is required when Switch is on; otherwise, it is ineffective. Valid values:
        /// <li>on: Cache.</li>
        /// <li>off: Do not cache.</li>
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("DefaultCache")]
        public string DefaultCache{ get; set; }

        /// <summary>
        /// Whether to use the default caching policy when an origin server does not return the Cache-Control header. This field is required when DefaultCache is set to on; otherwise, it is ineffective. When DefaultCacheTime is not 0, this field should be off. Valid values:
        /// <li>on: Use the default caching policy.</li>
        /// <li>off: Do not use the default caching policy.</li>
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("DefaultCacheStrategy")]
        public string DefaultCacheStrategy{ get; set; }

        /// <summary>
        /// The default cache time in seconds when an origin server does not return the Cache-Control header. The value ranges from 0 to 315360000. This field is required when DefaultCache is set to on; otherwise, it is ineffective. When DefaultCacheStrategy is on, this field should be 0.
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
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

