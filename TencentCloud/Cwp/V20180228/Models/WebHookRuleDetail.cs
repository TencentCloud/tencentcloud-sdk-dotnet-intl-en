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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WebHookRuleDetail : AbstractModel
    {
        
        /// <summary>
        /// Rule name
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Chatbot address
        /// </summary>
        [JsonProperty("HookAddr")]
        public string HookAddr{ get; set; }

        /// <summary>
        /// Event type
        /// </summary>
        [JsonProperty("RuleItems")]
        public WebHookEventKv[] RuleItems{ get; set; }

        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("RuleRemark")]
        public string RuleRemark{ get; set; }

        /// <summary>
        /// Host scope
        /// </summary>
        [JsonProperty("HostLabels")]
        public WebHookHostLabel[] HostLabels{ get; set; }

        /// <summary>
        /// Host ID List
        /// </summary>
        [JsonProperty("HostIds")]
        public string[] HostIds{ get; set; }

        /// <summary>
        /// Whether it is disabled [1: disabled|0: enabled]
        /// </summary>
        [JsonProperty("IsDisabled")]
        public long? IsDisabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "HookAddr", this.HookAddr);
            this.SetParamArrayObj(map, prefix + "RuleItems.", this.RuleItems);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleRemark", this.RuleRemark);
            this.SetParamArrayObj(map, prefix + "HostLabels.", this.HostLabels);
            this.SetParamArraySimple(map, prefix + "HostIds.", this.HostIds);
            this.SetParamSimple(map, prefix + "IsDisabled", this.IsDisabled);
        }
    }
}

