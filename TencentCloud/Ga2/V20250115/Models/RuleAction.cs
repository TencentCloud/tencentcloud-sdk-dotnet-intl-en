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

namespace TencentCloud.Ga2.V20250115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleAction : AbstractModel
    {
        
        /// <summary>
        /// <p>Behavior type of the Layer 7 forwarding rule</p><p>Enumeration values:</p><ul><li>ForwardGroup: The forwarding policy forwards to a terminal node group.</li><li>Drop: The forwarding policy drops the request.</li></ul>
        /// </summary>
        [JsonProperty("RuleActionType")]
        public string RuleActionType{ get; set; }

        /// <summary>
        /// <p>Layer 7 forwarding rule action value</p><p>This field is not required to input when RuleActionType is Drop. This field is required when RuleActionType is ForwardGroup, which requires filling in the custom terminal node group ID. The default terminal node group cannot be configured.</p>
        /// </summary>
        [JsonProperty("RuleActionValue")]
        public string RuleActionValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleActionType", this.RuleActionType);
            this.SetParamSimple(map, prefix + "RuleActionValue", this.RuleActionValue);
        }
    }
}

