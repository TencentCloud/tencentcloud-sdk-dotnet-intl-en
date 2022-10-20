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

    public class ModifySecurityWafGroupPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// The site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// The subdomain name.
        /// </summary>
        [JsonProperty("Entity")]
        public string Entity{ get; set; }

        /// <summary>
        /// Switch. Values:
        /// <li>`on`: Enable</li>
        /// <li>`off`: Disable</li>If not specified, it defaults to the setting that was last configured.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// The rule level. Values:
        /// <li>`loose`: Loose</li>
        /// <li>`normal`: Moderate</li>
        /// <li>`strict`: Strict</li>
        /// <li>`stricter`: Super strict</li>
        /// <li>`custom`: Custom</li>If not specified, it defaults to the setting that was last configured.
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// The rule action. Values:
        /// <li>`block`: Block</li>
        /// <li>`observe`: Observe</li>If not specified, it defaults to the setting that was last configured.
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// The settings of the managed rule. If not specified, it defaults to the settings that were last configured.
        /// </summary>
        [JsonProperty("WafRules")]
        public WafRule WafRules{ get; set; }

        /// <summary>
        /// The settings of the AI rule engine. If not specified, it defaults to the settings that were last configured.
        /// </summary>
        [JsonProperty("AiRule")]
        public AiRule AiRule{ get; set; }

        /// <summary>
        /// The settings of the managed rule group. If not specified, it defaults to the settings that were last configured.
        /// </summary>
        [JsonProperty("WafGroups")]
        public WafGroup[] WafGroups{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Entity", this.Entity);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamObj(map, prefix + "WafRules.", this.WafRules);
            this.SetParamObj(map, prefix + "AiRule.", this.AiRule);
            this.SetParamArrayObj(map, prefix + "WafGroups.", this.WafGroups);
        }
    }
}

