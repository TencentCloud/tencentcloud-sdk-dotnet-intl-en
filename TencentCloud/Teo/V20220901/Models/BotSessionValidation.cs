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
        /// Whether to update Cookie and validate. valid values: <li>on: update Cookie and validate;</li> <li>off: verify only.</li>.
        /// </summary>
        [JsonProperty("IssueNewBotSessionCookie")]
        public string IssueNewBotSessionCookie{ get; set; }

        /// <summary>
        /// Specifies the trigger threshold for updating and validating cookies. valid only when IssueNewBotSessionCookie is set to on.
        /// </summary>
        [JsonProperty("MaxNewSessionTriggerConfig")]
        public MaxNewSessionTriggerConfig MaxNewSessionTriggerConfig{ get; set; }

        /// <summary>
        /// Execution action when no Cookie is carried or the Cookie expired. valid values for the Name parameter in SecurityAction: <li>Deny: block, where Stall can be configured in DenyActionParameters;</li><li>Monitor: observe;</li><li>Allow: respond after wait, where MinDelayTime and MaxDelayTime must be configured in AllowActionParameters.</li>.
        /// </summary>
        [JsonProperty("SessionExpiredAction")]
        public SecurityAction SessionExpiredAction{ get; set; }

        /// <summary>
        /// Execution action for invalid Cookie. valid values for the Name parameter in SecurityAction: <li>Deny: block, where the DenyActionParameters supports Stall configuration;</li><li>Monitor: observe;</li><li>Allow: respond after wait, where AllowActionParameters requires MinDelayTime and MaxDelayTime configuration.</li>.
        /// </summary>
        [JsonProperty("SessionInvalidAction")]
        public SecurityAction SessionInvalidAction{ get; set; }

        /// <summary>
        /// Specifies the session rate and periodic feature verification configuration.
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

