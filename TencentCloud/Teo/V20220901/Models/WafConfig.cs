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

    public class WafConfig : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable WAF configuration. Values:
        /// <li>`on`: Enable</li>
        /// <li>`off`: Disable</li>The configuration can be modified even when it is disabled.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// The protection level. Values:
        /// <li>`loose`: Loose</li>
        /// <li>`normal`: Moderate</li>
        /// <li>`strict`: Strict</li>
        /// <li>`stricter`: Super strict</li>
        /// <li>`custom`: Custom</li>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// The WAF global mode. Values:
        /// <li>`block`: Block globally</li>
        /// <li>`observe`: Observe globally</li>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// The settings of the managed rule. If it is null, the settings that were last configured will be used.
        /// </summary>
        [JsonProperty("WafRule")]
        public WafRule WafRule{ get; set; }

        /// <summary>
        /// The setting of the AI rule engine. If it is null, the setting that was last configured will be used.
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

