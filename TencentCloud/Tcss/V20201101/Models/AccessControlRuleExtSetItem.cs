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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccessControlRuleExtSetItem : AbstractModel
    {
        
        /// <summary>
        /// Sub-rule list of the user-defined policy. Has a value when IsDefault=false.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ChildRules")]
        public AccessControlChildRuleInfo[] ChildRules{ get; set; }

        /// <summary>
        /// Edit username
        /// </summary>
        [JsonProperty("EditUserName")]
        public string EditUserName{ get; set; }

        /// <summary>
        /// Policy enforcement image count
        /// </summary>
        [JsonProperty("EffectImageCount")]
        public ulong? EffectImageCount{ get; set; }

        /// <summary>
        /// true: default policy, false: custom policy
        /// </summary>
        [JsonProperty("IsDefault")]
        public bool? IsDefault{ get; set; }

        /// <summary>
        /// Whether the rule applies to all images. true indicates it takes effect on all images.
        /// </summary>
        [JsonProperty("IsGlobal")]
        public bool? IsGlobal{ get; set; }

        /// <summary>
        /// true: Policy activation, false: Policy deactivation
        /// </summary>
        [JsonProperty("IsEnable")]
        public bool? IsEnable{ get; set; }

        /// <summary>
        /// Deduplicated list of ALL execution actions in the rule group. RULE_MODE_ALERT: Alert RULE_MODE_HOLDUP: Block
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleActions")]
        public string[] RuleActions{ get; set; }

        /// <summary>
        /// Policy ID
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// Policy name
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Sub-rule list of system policy. Has value when IsDefault=true.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SystemChildRules")]
        public AccessControlSystemChildRuleInfo[] SystemChildRules{ get; set; }

        /// <summary>
        /// Policy update time. May be empty.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ChildRules.", this.ChildRules);
            this.SetParamSimple(map, prefix + "EditUserName", this.EditUserName);
            this.SetParamSimple(map, prefix + "EffectImageCount", this.EffectImageCount);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "IsGlobal", this.IsGlobal);
            this.SetParamSimple(map, prefix + "IsEnable", this.IsEnable);
            this.SetParamArraySimple(map, prefix + "RuleActions.", this.RuleActions);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamArrayObj(map, prefix + "SystemChildRules.", this.SystemChildRules);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

