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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CCPolicy : AbstractModel
    {
        
        /// <summary>
        /// Policy name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Matching mode. Valid values: [matching (matching mode), speedlimit (speed limiting mode)]
        /// </summary>
        [JsonProperty("Smode")]
        public string Smode{ get; set; }

        /// <summary>
        /// Policy ID
        /// </summary>
        [JsonProperty("SetId")]
        public string SetId{ get; set; }

        /// <summary>
        /// Number of requests allowed per minute
        /// </summary>
        [JsonProperty("Frequency")]
        public ulong? Frequency{ get; set; }

        /// <summary>
        /// Executed policy mode. Valid values: [alg (verification code), drop (blocking)]
        /// </summary>
        [JsonProperty("ExeMode")]
        public string ExeMode{ get; set; }

        /// <summary>
        /// Specifies whether the policy is activated
        /// </summary>
        [JsonProperty("Switch")]
        public ulong? Switch{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Rule list
        /// </summary>
        [JsonProperty("RuleList")]
        public CCRule[] RuleList{ get; set; }

        /// <summary>
        /// IP list. If this field is to be left empty, please pass in an empty instead of null;
        /// </summary>
        [JsonProperty("IpList")]
        public string[] IpList{ get; set; }

        /// <summary>
        /// CC protection type. Valid values: [http, https]
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// ID of the forwarding rule corresponding to the HTTPS CC protection domain name
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// HTTPS CC protection domain name
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Smode", this.Smode);
            this.SetParamSimple(map, prefix + "SetId", this.SetId);
            this.SetParamSimple(map, prefix + "Frequency", this.Frequency);
            this.SetParamSimple(map, prefix + "ExeMode", this.ExeMode);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "RuleList.", this.RuleList);
            this.SetParamArraySimple(map, prefix + "IpList.", this.IpList);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
        }
    }
}

