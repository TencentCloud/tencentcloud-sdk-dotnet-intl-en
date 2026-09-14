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

    public class RuleCondition : AbstractModel
    {
        
        /// <summary>
        /// <p>Condition type of Layer 7 forwarding rule</p><p>Enumeration values:</p><ul><li>Path: Path</li></ul>
        /// </summary>
        [JsonProperty("RuleConditionType")]
        public string RuleConditionType{ get; set; }

        /// <summary>
        /// <p>Layer 7 forwarding rule condition value</p><p>Parameter format: The format must match the regular expression: ^[a-zA-Z0-9_.-/]{1,80}$</p><p>The array length cannot exceed 1.</p>
        /// </summary>
        [JsonProperty("RuleConditionValue")]
        public string[] RuleConditionValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleConditionType", this.RuleConditionType);
            this.SetParamArraySimple(map, prefix + "RuleConditionValue.", this.RuleConditionValue);
        }
    }
}

