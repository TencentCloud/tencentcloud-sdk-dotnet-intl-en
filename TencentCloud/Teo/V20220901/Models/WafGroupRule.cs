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

    public class WafGroupRule : AbstractModel
    {
        
        /// <summary>
        /// The rule ID.
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// The rule description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// The description of the rule level.
        /// </summary>
        [JsonProperty("RuleLevelDesc")]
        public string RuleLevelDesc{ get; set; }

        /// <summary>
        /// The rule tag.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleTags")]
        public string[] RuleTags{ get; set; }

        /// <summary>
        /// The update time in the format of YYYY-MM-DD hh:mm:ss.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// The rule status. Values:
        /// <li>`on`: Enabled</li>
        /// <li>`off`: Disabled</li>It can be left empty when you query a managed rule.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// The rule type.
        /// </summary>
        [JsonProperty("RuleTypeName")]
        public string RuleTypeName{ get; set; }

        /// <summary>
        /// ID of the rule type.
        /// </summary>
        [JsonProperty("RuleTypeId")]
        public long? RuleTypeId{ get; set; }

        /// <summary>
        /// Description of the rule type.
        /// </summary>
        [JsonProperty("RuleTypeDesc")]
        public string RuleTypeDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RuleLevelDesc", this.RuleLevelDesc);
            this.SetParamArraySimple(map, prefix + "RuleTags.", this.RuleTags);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RuleTypeName", this.RuleTypeName);
            this.SetParamSimple(map, prefix + "RuleTypeId", this.RuleTypeId);
            this.SetParamSimple(map, prefix + "RuleTypeDesc", this.RuleTypeDesc);
        }
    }
}

