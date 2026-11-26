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

    public class WafConfig : AbstractModel
    {
        
        /// <summary>
        /// WafConfig switch. Valid values:
        /// <li>on: Enable;</li>
        /// <li> off: disabled.</li>The switch only affects whether the configuration takes effect. Even if it is off, the configuration content can still be modified normally.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Protection level set last time. Valid values:
        /// <li> loose: loose;</li>
        /// <li> normal: Normal;</li>
        /// <li> strict: strict;</li>
        /// <li>stricter: ultra-strict;</li>
        /// <li> custom: Custom.</li>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// Global WAF mode. Valid values:
        /// <li> block: block (global blocking, but you can configure rules to observe);</li>
        /// <li> observe: observation (regardless of the detailed rule configuration, it is always observation).</li>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// Detailed configuration of the managed rule. If null, use the last set configuration by default.
        /// </summary>
        [JsonProperty("WafRule")]
        public WafRule WafRule{ get; set; }

        /// <summary>
        /// Protection configuration of the AI rule engine. If it is null, use the last set configuration by default.
        /// </summary>
        [JsonProperty("AiRule")]
        public AiRule AiRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamObj(map, prefix + "WafRule.", this.WafRule);
            this.SetParamObj(map, prefix + "AiRule.", this.AiRule);
        }
    }
}

