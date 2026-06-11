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

    public class ImageDenyRule : AbstractModel
    {
        
        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("RuleID")]
        public string RuleID{ get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Rule Type. RULE_RISK: Risk; RULE_PRIVILEGE: Privilege
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Number of Effective Images
        /// </summary>
        [JsonProperty("EffectImageCount")]
        public long? EffectImageCount{ get; set; }

        /// <summary>
        /// Application to All Scanned Images. 0: Select All Images; 1: Custom Images
        /// </summary>
        [JsonProperty("IsEffectAllImage")]
        public long? IsEffectAllImage{ get; set; }

        /// <summary>
        /// Rule Effective Start Time
        /// </summary>
        [JsonProperty("EffectTime")]
        public string EffectTime{ get; set; }

        /// <summary>
        /// Update time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Operator
        /// </summary>
        [JsonProperty("OperationUin")]
        public string OperationUin{ get; set; }

        /// <summary>
        /// Enabled status
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Effective Status. IN_THE_TEST: Observing; IN_EFFECT: Effective
        /// </summary>
        [JsonProperty("EffectStatus")]
        public string EffectStatus{ get; set; }

        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "EffectImageCount", this.EffectImageCount);
            this.SetParamSimple(map, prefix + "IsEffectAllImage", this.IsEffectAllImage);
            this.SetParamSimple(map, prefix + "EffectTime", this.EffectTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "OperationUin", this.OperationUin);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EffectStatus", this.EffectStatus);
            this.SetParamSimple(map, prefix + "ID", this.ID);
        }
    }
}

