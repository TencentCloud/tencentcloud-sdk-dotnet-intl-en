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

    public class AlgDetectRule : AbstractModel
    {
        
        /// <summary>
        /// Rule id.
        /// </summary>
        [JsonProperty("RuleID")]
        public long? RuleID{ get; set; }

        /// <summary>
        /// Rule name.
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Rule switch.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Custom rule.
        /// </summary>
        [JsonProperty("AlgConditions")]
        public AclCondition[] AlgConditions{ get; set; }

        /// <summary>
        /// Cookie checksum and session behavior analysis.
        /// </summary>
        [JsonProperty("AlgDetectSession")]
        public AlgDetectSession AlgDetectSession{ get; set; }

        /// <summary>
        /// Client behavior validation.
        /// </summary>
        [JsonProperty("AlgDetectJS")]
        public AlgDetectJS[] AlgDetectJS{ get; set; }

        /// <summary>
        /// Update time. For output usage only.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamArrayObj(map, prefix + "AlgConditions.", this.AlgConditions);
            this.SetParamObj(map, prefix + "AlgDetectSession.", this.AlgDetectSession);
            this.SetParamArrayObj(map, prefix + "AlgDetectJS.", this.AlgDetectJS);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

