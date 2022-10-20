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

    public class WafGroupDetail : AbstractModel
    {
        
        /// <summary>
        /// ID of the rule type.
        /// </summary>
        [JsonProperty("RuleTypeId")]
        public long? RuleTypeId{ get; set; }

        /// <summary>
        /// The rule type.
        /// </summary>
        [JsonProperty("RuleTypeName")]
        public string RuleTypeName{ get; set; }

        /// <summary>
        /// Description of the rule type.
        /// </summary>
        [JsonProperty("RuleTypeDesc")]
        public string RuleTypeDesc{ get; set; }

        /// <summary>
        /// List of rules.
        /// </summary>
        [JsonProperty("WafGroupRules")]
        public WafGroupRule[] WafGroupRules{ get; set; }

        /// <summary>
        /// The rule level.
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// The rule action.
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleTypeId", this.RuleTypeId);
            this.SetParamSimple(map, prefix + "RuleTypeName", this.RuleTypeName);
            this.SetParamSimple(map, prefix + "RuleTypeDesc", this.RuleTypeDesc);
            this.SetParamArrayObj(map, prefix + "WafGroupRules.", this.WafGroupRules);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Action", this.Action);
        }
    }
}

