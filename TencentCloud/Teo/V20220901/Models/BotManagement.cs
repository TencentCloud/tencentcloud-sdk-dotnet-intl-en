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

    public class BotManagement : AbstractModel
    {
        
        /// <summary>
        /// Whether Bot management is enabled. valid values: <li>on: enabled;</li><li>off: disabled.</li>.
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }

        /// <summary>
        /// Bot management custom rule combines various crawlers and request behavior characteristics to accurately define bots and configure customized handling methods.
        /// </summary>
        [JsonProperty("CustomRules")]
        public BotManagementCustomRules CustomRules{ get; set; }

        /// <summary>
        /// Bot management basic configuration. takes effect on all domains associated with the policy. can be customized through CustomRules.
        /// </summary>
        [JsonProperty("BasicBotSettings")]
        public BasicBotSettings BasicBotSettings{ get; set; }

        /// <summary>
        /// Definition list of client authentication rules. this feature is in beta test. submit a ticket if you need to use it.
        /// </summary>
        [JsonProperty("ClientAttestationRules")]
        public ClientAttestationRules ClientAttestationRules{ get; set; }

        /// <summary>
        /// Configures browser spoofing identification rules (formerly active feature detection rule). sets the response page range for JavaScript injection, browser check options, and handling method for non-browser clients.
        /// </summary>
        [JsonProperty("BrowserImpersonationDetection")]
        public BrowserImpersonationDetection BrowserImpersonationDetection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamObj(map, prefix + "CustomRules.", this.CustomRules);
            this.SetParamObj(map, prefix + "BasicBotSettings.", this.BasicBotSettings);
            this.SetParamObj(map, prefix + "ClientAttestationRules.", this.ClientAttestationRules);
            this.SetParamObj(map, prefix + "BrowserImpersonationDetection.", this.BrowserImpersonationDetection);
        }
    }
}

