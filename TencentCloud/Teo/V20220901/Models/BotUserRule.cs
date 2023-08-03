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

    public class BotUserRule : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Action. Valid values: 
        /// <li>`drop`: Block;</li>
        /// <li>`monitor`: Observe;</li>
        /// <li>`trans`: Allow;</li>
        /// <li>`alg`: JavaScript challenge;</li>
        /// <li>`captcha`: Managed challenge;</li>
        /// <li>`random`: Random action;</li>
        /// <li>`silence`: Silence;</li>
        /// <li>`shortdelay`: Add short latency;</li>
        /// <li>`longdelay`: Add long latency.</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// The rule status. Values:
        /// <li>`on`: Enabled</li>
        /// <li>`off`: Disabled</li>Default value: `on`
        /// </summary>
        [JsonProperty("RuleStatus")]
        public string RuleStatus{ get; set; }

        /// <summary>
        /// Details of the rule.
        /// </summary>
        [JsonProperty("AclConditions")]
        public AclCondition[] AclConditions{ get; set; }

        /// <summary>
        /// The rule weight. Value range: 0-100.
        /// </summary>
        [JsonProperty("RulePriority")]
        public long? RulePriority{ get; set; }

        /// <summary>
        /// The rule ID, which is only used as an output parameter.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleID")]
        public long? RuleID{ get; set; }

        /// <summary>
        /// [Currently unavailable] Specify the random action and percentage.
        /// </summary>
        [JsonProperty("ExtendActions")]
        public BotExtendAction[] ExtendActions{ get; set; }

        /// <summary>
        /// The filter. Values:
        /// <li>`sip`: Client IP</li>
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FreqFields")]
        public string[] FreqFields{ get; set; }

        /// <summary>
        /// Updated time
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// The statistical dimension. Values:
        /// <li>`source_to_eo`: Responses from the origin server to EdgeOne</li>
        /// <li>`client_to_eo`: Requests from the client to EdgeOne</li>
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FreqScope")]
        public string[] FreqScope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "RuleStatus", this.RuleStatus);
            this.SetParamArrayObj(map, prefix + "AclConditions.", this.AclConditions);
            this.SetParamSimple(map, prefix + "RulePriority", this.RulePriority);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamArrayObj(map, prefix + "ExtendActions.", this.ExtendActions);
            this.SetParamArraySimple(map, prefix + "FreqFields.", this.FreqFields);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArraySimple(map, prefix + "FreqScope.", this.FreqScope);
        }
    }
}

