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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StickySessionConfig : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable session persistence.
        /// - **true**: enabled.
        /// - **false**: not enabled.
        /// </summary>
        [JsonProperty("StickySessionEnabled")]
        public bool? StickySessionEnabled{ get; set; }

        /// <summary>
        /// Custom Cookie name.
        /// Length: 1-255 characters. It can only contain English letters and digits, and cannot be `tgw_l7_tg_route`. This field is a reserved field for the session persistence Cookie between target groups.
        /// >This parameter takes effect only when **StickySessionEnabled** is **true**.
        /// </summary>
        [JsonProperty("Cookie")]
        public string Cookie{ get; set; }

        /// <summary>
        /// Session hold time.
        /// Value range: **1-86400**. Unit: **seconds**.
        /// Default value: **1000**.
        /// >This parameter takes effect only when **StickySessionEnabled** is **true**.
        /// </summary>
        [JsonProperty("CookieTimeout")]
        public long? CookieTimeout{ get; set; }

        /// <summary>
        /// Session persistence type (the way cookies are handled).
        /// - **Insert** (default value): Embed a Cookie. When a client accesses the backend service for the first time, the application CLB will embed a Cookie in the Return Request. The next time the client carries this Cookie in a request, load balancing will forward the request to the same backend service as last time.
        /// - **Rewrite**: Rewrite the Cookie. Load balancing rewrites the user-defined Cookie. The next client request carries the Cookie, and load balancing forwards the request to the same backend service as the last request.
        /// >This parameter takes effect only when **StickySessionEnabled** is **true**.
        /// </summary>
        [JsonProperty("StickySessionType")]
        public string StickySessionType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StickySessionEnabled", this.StickySessionEnabled);
            this.SetParamSimple(map, prefix + "Cookie", this.Cookie);
            this.SetParamSimple(map, prefix + "CookieTimeout", this.CookieTimeout);
            this.SetParamSimple(map, prefix + "StickySessionType", this.StickySessionType);
        }
    }
}

