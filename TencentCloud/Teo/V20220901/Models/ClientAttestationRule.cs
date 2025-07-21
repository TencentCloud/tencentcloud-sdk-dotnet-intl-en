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

    public class ClientAttestationRule : AbstractModel
    {
        
        /// <summary>
        /// Client authentication rule ID. supported rule configuration operations by rule ID: <li> <b>add</b> a new rule: leave the ID empty or do not specify the ID parameter.</li> <li> <b>modify</b> an existing rule: specify the rule ID that needs to be updated/modified.</li> <li> <b>delete</b> an existing rule: existing rules not included in the ClientAttestationRule list under BotManagement parameters will be deleted.</li>.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Specifies the name of the client authentication rule.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Whether the rule is enabled. valid values: <li>`on`: enable</li> <li>`off`: disable</li>.
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }

        /// <summary>
        /// Priority of rules. a smaller value indicates higher priority execution. value range: 0-100. default value: 0.
        /// </summary>
        [JsonProperty("Priority")]
        public ulong? Priority{ get; set; }

        /// <summary>
        /// The rule content must comply with expression grammar. for details, see the product document.
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// Specifies the client authentication option ID.
        /// </summary>
        [JsonProperty("AttesterId")]
        public string AttesterId{ get; set; }

        /// <summary>
        /// Client device configuration. if the DeviceProfiles parameter value is not specified in the ClientAttestationRules parameter, keep the existing client device configuration and do not modify it.
        /// </summary>
        [JsonProperty("DeviceProfiles")]
        public DeviceProfile[] DeviceProfiles{ get; set; }

        /// <summary>
        /// Handling method for failed client authentication. valid values for SecurityAction Name: <li>Deny: block;</li> <li>Monitor: observation;</li> <li>Redirect: redirection;</li> <li>Challenge: Challenge.</li> default value: Monitor.
        /// </summary>
        [JsonProperty("InvalidAttestationAction")]
        public SecurityAction InvalidAttestationAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamSimple(map, prefix + "AttesterId", this.AttesterId);
            this.SetParamArrayObj(map, prefix + "DeviceProfiles.", this.DeviceProfiles);
            this.SetParamObj(map, prefix + "InvalidAttestationAction.", this.InvalidAttestationAction);
        }
    }
}

