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

    public class BotConfig : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable bot security. Values:
        /// <li>`on`: Enable</li>
        /// <li>`off`: Disable</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// The settings of the bot managed rule. If it is null, the settings that were last configured will be used.
        /// </summary>
        [JsonProperty("BotManagedRule")]
        public BotManagedRule BotManagedRule{ get; set; }

        /// <summary>
        /// The settings of the client reputation rule. If it is null, the settings that were last configured will be used.
        /// </summary>
        [JsonProperty("BotPortraitRule")]
        public BotPortraitRule BotPortraitRule{ get; set; }

        /// <summary>
        /// The bot intelligence settings. If it is null, the settings that were last configured will be used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IntelligenceRule")]
        public IntelligenceRule IntelligenceRule{ get; set; }

        /// <summary>
        /// Settings of the custom bot rule. If it is null, the settings that were last configured will be used.
        /// </summary>
        [JsonProperty("BotUserRules")]
        public BotUserRule[] BotUserRules{ get; set; }

        /// <summary>
        /// Active bot detection rule.
        /// </summary>
        [JsonProperty("AlgDetectRule")]
        public AlgDetectRule[] AlgDetectRule{ get; set; }

        /// <summary>
        /// Settings of the bot managed rule. It is only used for output.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Customizes")]
        public BotUserRule[] Customizes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamObj(map, prefix + "BotManagedRule.", this.BotManagedRule);
            this.SetParamObj(map, prefix + "BotPortraitRule.", this.BotPortraitRule);
            this.SetParamObj(map, prefix + "IntelligenceRule.", this.IntelligenceRule);
            this.SetParamArrayObj(map, prefix + "BotUserRules.", this.BotUserRules);
            this.SetParamArrayObj(map, prefix + "AlgDetectRule.", this.AlgDetectRule);
            this.SetParamArrayObj(map, prefix + "Customizes.", this.Customizes);
        }
    }
}

