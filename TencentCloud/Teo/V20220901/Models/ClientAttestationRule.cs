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
        /// <p>ID of the client authentication rule.<br>Different rule configuration operations are supported by rule ID:<br> <li> <b>Add</b> a new rule: leave ID empty or do not specify the ID parameter;</li><li> <b>Modify</b> an existing rule: specify the rule ID to be updated/modified;</li><li> <b>Delete</b> an existing rule: existing rules not included in the ClientAttestationRule list in the BotManagement parameter will be deleted.</li></p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>Name of the client authentication rule.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Whether the rule is enabled. Valid values: <li>on: enabled;</li><li>off: disabled.</li></p>
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }

        /// <summary>
        /// <p>Priority of rules. A smaller value indicates higher priority. Value range: 0-100. Default value: 0.</p>
        /// </summary>
        [JsonProperty("Priority")]
        public ulong? Priority{ get; set; }

        /// <summary>
        /// <p>The specific content of the rule must comply with the expression syntax. For detailed specifications, see the product document.</p>
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// <p>Client authentication option ID.</p>
        /// </summary>
        [JsonProperty("AttesterId")]
        public string AttesterId{ get; set; }

        /// <summary>
        /// <p>Handling method when client authentication fails. SecurityAction.Name values are as follows:</p><ul><li>Allow: allow, where AllowActionParameters supports MinDelayTime and MaxDelayTime configuration;</li><li>Deny: block, where DenyActionParameters supports BlockIp, ReturnCustomPage, and Stall configuration;</li><li>Monitor: observe;</li><li>Challenge: challenge, where ChallengeActionParameters.ChallengeOption supports JSChallenge, ManagedChallenge, InterstitialChallenge, and InlineChallenge;</li><li>Redirect: redirect to a URL.</li></ul>
        /// </summary>
        [JsonProperty("InvalidAttestationAction")]
        public SecurityAction InvalidAttestationAction{ get; set; }

        /// <summary>
        /// <p>Client device configuration. If the DeviceProfiles parameter value is not specified in the ClientAttestationRules parameter: keep the existing client device configuration without modification.</p>
        /// </summary>
        [JsonProperty("DeviceProfiles")]
        public DeviceProfile[] DeviceProfiles{ get; set; }

        /// <summary>
        /// <p>Account protection configuration.</p>
        /// </summary>
        [JsonProperty("AccountProtectionSettings")]
        public AccountProtectionSettings AccountProtectionSettings{ get; set; }


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
            this.SetParamObj(map, prefix + "InvalidAttestationAction.", this.InvalidAttestationAction);
            this.SetParamArrayObj(map, prefix + "DeviceProfiles.", this.DeviceProfiles);
            this.SetParamObj(map, prefix + "AccountProtectionSettings.", this.AccountProtectionSettings);
        }
    }
}

