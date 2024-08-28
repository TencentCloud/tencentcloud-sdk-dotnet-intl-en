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

    public class RiskDnsPolicy : AbstractModel
    {
        
        /// <summary>
        /// Policy name
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// Policy type [0: system; 1: user]
        /// </summary>
        [JsonProperty("PolicyType")]
        public long? PolicyType{ get; set; }

        /// <summary>
        /// Policy action [0: alarm; 1: allow; 2:intercept + alarm]
        /// </summary>
        [JsonProperty("PolicyAction")]
        public long? PolicyAction{ get; set; }

        /// <summary>
        /// Host range [1: all Professional + Ultimate Editions|2: all Ultimate Editions|0: partial hosts]
        /// </summary>
        [JsonProperty("HostScope")]
        public long? HostScope{ get; set; }

        /// <summary>
        /// Host ID
        /// </summary>
        [JsonProperty("HostIds")]
        public string[] HostIds{ get; set; }

        /// <summary>
        /// Domain name (when used as an input parameter, it needs base64 encode.)
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// Whether effective [0: effective,1: not effective]
        /// </summary>
        [JsonProperty("IsEnabled")]
        public long? IsEnabled{ get; set; }

        /// <summary>
        /// Policy ID
        /// </summary>
        [JsonProperty("PolicyId")]
        public long? PolicyId{ get; set; }

        /// <summary>
        /// Policy description
        /// </summary>
        [JsonProperty("PolicyDesc")]
        public string PolicyDesc{ get; set; }

        /// <summary>
        /// Whether to process previous events [0: no|1: yes]
        /// </summary>
        [JsonProperty("IsDealOldEvent")]
        public long? IsDealOldEvent{ get; set; }

        /// <summary>
        /// Update time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Event ID
        /// </summary>
        [JsonProperty("EventId")]
        public long? EventId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "PolicyAction", this.PolicyAction);
            this.SetParamSimple(map, prefix + "HostScope", this.HostScope);
            this.SetParamArraySimple(map, prefix + "HostIds.", this.HostIds);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamSimple(map, prefix + "IsEnabled", this.IsEnabled);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyDesc", this.PolicyDesc);
            this.SetParamSimple(map, prefix + "IsDealOldEvent", this.IsDealOldEvent);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
        }
    }
}

