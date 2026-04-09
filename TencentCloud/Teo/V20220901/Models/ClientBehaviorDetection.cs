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

    public class ClientBehaviorDetection : AbstractModel
    {
        
        /// <summary>
        /// Specifies the proof-of-work strength. valid values: <li>low: low;</li><li>medium: medium;</li><li>high: high.</li>.
        /// </summary>
        [JsonProperty("CryptoChallengeIntensity")]
        public string CryptoChallengeIntensity{ get; set; }

        /// <summary>
        /// Specifies the execution mode for client behavior verification. valid values: <li>0ms: immediate execution;</li> <li>100ms: delay 100ms execution;</li> <li>200ms: delay 200ms execution;</li> <li>300ms: delay 300ms execution;</li> <li>400ms: delay 400ms execution;</li> <li>500ms: delay 500ms execution;</li> <li>600ms: delay 600ms execution;</li> <li>700ms: delay 700ms execution;</li> <li>800ms: delay 800ms execution;</li> <li>900ms: delay 900ms execution;</li> <li>1000ms: delay 1000ms execution.</li>.
        /// </summary>
        [JsonProperty("CryptoChallengeDelayBefore")]
        public string CryptoChallengeDelayBefore{ get; set; }

        /// <summary>
        /// Time window for trigger threshold statistics. valid values: <li>5s: within 5 seconds;</li><li>10s: within 10 seconds;</li><li>15s: within 15 seconds;</li><li>30s: within 30 seconds;</li><li>60s: within 60 seconds;</li><li>5m: within 5 minutes;</li><li>10m: within 10 minutes;</li><li>30m: within 30 minutes;</li><li>60m: within 60 minutes.</li>.
        /// </summary>
        [JsonProperty("MaxChallengeCountInterval")]
        public string MaxChallengeCountInterval{ get; set; }

        /// <summary>
        /// Trigger threshold cumulative count. value range: 1-100000000.
        /// </summary>
        [JsonProperty("MaxChallengeCountThreshold")]
        public long? MaxChallengeCountThreshold{ get; set; }

        /// <summary>
        /// Execution action when client-side javascript is not enabled (test not completed). valid values for SecurityAction Name: <li>Deny: block, where Stall configuration is supported in DenyActionParameters;</li><li>Monitor: observe;</li><li>Allow: respond after waiting, where MinDelayTime and MaxDelayTime configuration is required in AllowActionParameters.</li>.
        /// </summary>
        [JsonProperty("ChallengeNotFinishedAction")]
        public SecurityAction ChallengeNotFinishedAction{ get; set; }

        /// <summary>
        /// The execution action for client-side detection timeout. valid values for the Name parameter in SecurityAction: <li>Deny: block, where Stall can be configured in DenyActionParameters;</li> <li>Monitor: observe;</li> <li>Allow: respond after wait, where MinDelayTime and MaxDelayTime must be configured in AllowActionParameters.</li>.
        /// </summary>
        [JsonProperty("ChallengeTimeoutAction")]
        public SecurityAction ChallengeTimeoutAction{ get; set; }

        /// <summary>
        /// The execution action of the Bot client. valid values for the Name parameter in SecurityAction: <li>Deny: block, where the Stall configuration is supported in DenyActionParameters;</li><li>Monitor: observation;</li><li>Allow: respond after wait, where MinDelayTime and MaxDelayTime configurations are required in AllowActionParameters.</li>.
        /// </summary>
        [JsonProperty("BotClientAction")]
        public SecurityAction BotClientAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CryptoChallengeIntensity", this.CryptoChallengeIntensity);
            this.SetParamSimple(map, prefix + "CryptoChallengeDelayBefore", this.CryptoChallengeDelayBefore);
            this.SetParamSimple(map, prefix + "MaxChallengeCountInterval", this.MaxChallengeCountInterval);
            this.SetParamSimple(map, prefix + "MaxChallengeCountThreshold", this.MaxChallengeCountThreshold);
            this.SetParamObj(map, prefix + "ChallengeNotFinishedAction.", this.ChallengeNotFinishedAction);
            this.SetParamObj(map, prefix + "ChallengeTimeoutAction.", this.ChallengeTimeoutAction);
            this.SetParamObj(map, prefix + "BotClientAction.", this.BotClientAction);
        }
    }
}

