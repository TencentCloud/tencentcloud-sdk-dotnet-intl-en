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

    public class RateLimitConfig : AbstractModel
    {
        
        /// <summary>
        /// Switch. Values:
        /// <li>`on`: Enable</li>
        /// <li>`off`: Disable</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// The settings of the custom rate limiting rule. If it is null, the settings that were last configured will be used.
        /// </summary>
        [JsonProperty("RateLimitUserRules")]
        public RateLimitUserRule[] RateLimitUserRules{ get; set; }

        /// <summary>
        /// The rate limit template feature. if null, use the last set configuration by default.
        /// </summary>
        [JsonProperty("RateLimitTemplate")]
        public RateLimitTemplate RateLimitTemplate{ get; set; }

        /// <summary>
        /// Intelligent client filtering. if null, use the last set configuration by default.
        /// </summary>
        [JsonProperty("RateLimitIntelligence")]
        public RateLimitIntelligence RateLimitIntelligence{ get; set; }

        /// <summary>
        /// The custom rate limiting rules. if it is `null`, the previous settings is used.
        /// </summary>
        [JsonProperty("RateLimitCustomizes")]
        public RateLimitUserRule[] RateLimitCustomizes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamArrayObj(map, prefix + "RateLimitUserRules.", this.RateLimitUserRules);
            this.SetParamObj(map, prefix + "RateLimitTemplate.", this.RateLimitTemplate);
            this.SetParamObj(map, prefix + "RateLimitIntelligence.", this.RateLimitIntelligence);
            this.SetParamArrayObj(map, prefix + "RateLimitCustomizes.", this.RateLimitCustomizes);
        }
    }
}

