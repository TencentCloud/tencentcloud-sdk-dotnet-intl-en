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

    public class RateLimitTemplate : AbstractModel
    {
        
        /// <summary>
        /// The mode. Values:
        /// <li>`sup_loose`: Super loose</li>
        /// <li>`loose`: Loose</li>
        /// <li>`emergency`: Emergency</li>
        /// <li>`normal`: Moderate</li>
        /// <li>`strict`: Strict</li>
        /// <li>`close`: Off</li>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// The action. Values:
        /// <li>`alg`: JavaScript challenge</li>
        /// <li>`monitor`: Observe</li>If it is left empty, the default value `alg` is used.
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// The settings of the rate limiting template. It is only used as an output parameter.
        /// </summary>
        [JsonProperty("RateLimitTemplateDetail")]
        public RateLimitTemplateDetail RateLimitTemplateDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamObj(map, prefix + "RateLimitTemplateDetail.", this.RateLimitTemplateDetail);
        }
    }
}

