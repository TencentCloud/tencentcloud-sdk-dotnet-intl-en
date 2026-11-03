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

    public class BotSessionValidation : AbstractModel
    {
        
        /// <summary>
        /// Whether to update the Cookie and verify. Valid values: <li>on: update the Cookie and verify;</li><li>off: verify only.</li>
        /// </summary>
        [JsonProperty("IssueNewBotSessionCookie")]
        public string IssueNewBotSessionCookie{ get; set; }

        /// <summary>
        /// Update threshold for cookie update and validation. Valid only when IssueNewBotSessionCookie is on.
        /// </summary>
        [JsonProperty("MaxNewSessionTriggerConfig")]
        public MaxNewSessionTriggerConfig MaxNewSessionTriggerConfig{ get; set; }

        /// <summary>
        /// Execution action without a Cookie or with an expired Cookie. Supported Name values for SecurityAction: <li>Deny: block. DenyActionParameters supports Stall configuration.</li><li>Monitor: observe.</li><li>Allow: respond after waiting. AllowActionParameters requires MinDelayTime and MaxDelayTime configuration.</li>
        /// </summary>
        [JsonProperty("SessionExpiredAction")]
        public SecurityAction SessionExpiredAction{ get; set; }

        /// <summary>
        /// Execution action for invalid Cookie. The Name parameter of SecurityAction supports the following values: <li>Deny: block. DenyActionParameters supports the Stall configuration.</li><li>Monitor: observe.</li><li>Allow: respond after waiting. AllowActionParameters requires the MinDelayTime and MaxDelayTime configurations.</li>
        /// </summary>
        [JsonProperty("SessionInvalidAction")]
        public SecurityAction SessionInvalidAction{ get; set; }

        /// <summary>
        /// Specific configuration for session rate and periodic feature verification.
        /// </summary>
        [JsonProperty("SessionRateControl")]
        public SessionRateControl SessionRateControl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IssueNewBotSessionCookie", this.IssueNewBotSessionCookie);
            this.SetParamObj(map, prefix + "MaxNewSessionTriggerConfig.", this.MaxNewSessionTriggerConfig);
            this.SetParamObj(map, prefix + "SessionExpiredAction.", this.SessionExpiredAction);
            this.SetParamObj(map, prefix + "SessionInvalidAction.", this.SessionInvalidAction);
            this.SetParamObj(map, prefix + "SessionRateControl.", this.SessionRateControl);
        }
    }
}

