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
        /// Proof-of-work strength. Valid values: <li>low: Low;</li><li>medium: Medium;</li><li>high: High.</li>
        /// </summary>
        [JsonProperty("CryptoChallengeIntensity")]
        public string CryptoChallengeIntensity{ get; set; }

        /// <summary>
        /// Execution mode of client behavior validation. Valid values: <li>0ms: immediately execute;</li><li>100ms: execute after a 100ms delay;</li><li>200ms: execute after a 200ms delay;</li><li>300ms: execute after a 300ms delay;</li><li>400ms: execute after a 400ms delay;</li><li>500ms: execute after a 500ms delay;</li><li>600ms: execute after a 600ms delay;</li><li>700ms: execute after a 700ms delay;</li><li>800ms: execute after an 800ms delay;</li><li>900ms: execute after a 900ms delay;</li><li>1000ms: execute after a 1000ms delay.</li>
        /// </summary>
        [JsonProperty("CryptoChallengeDelayBefore")]
        public string CryptoChallengeDelayBefore{ get; set; }

        /// <summary>
        /// Time window for trigger threshold statistics. Valid values: <li>5s: within 5 seconds;</li><li>10s: within 10 seconds;</li><li>15s: within 15 seconds;</li><li>30s: within 30 seconds;</li><li>60s: within 60 seconds;</li><li>5m: within 5 minutes;</li><li>10m: within 10 minutes;</li><li>30m: within 30 minutes;</li><li>60m: within 60 minutes.</li>
        /// </summary>
        [JsonProperty("MaxChallengeCountInterval")]
        public string MaxChallengeCountInterval{ get; set; }

        /// <summary>
        /// Cumulative count of trigger threshold statistics. Value range: 1-100000000.
        /// </summary>
        [JsonProperty("MaxChallengeCountThreshold")]
        public long? MaxChallengeCountThreshold{ get; set; }

        /// <summary>
        /// Execution action when client-side JavaScript is not enabled (test not completed). Supported values for SecurityAction Name: <li>Deny: block. DenyActionParameters supports Stall configuration;</li><li>Monitor: observe;</li><li>Allow: respond after waiting. AllowActionParameters requires MinDelayTime and MaxDelayTime configuration.</li>
        /// </summary>
        [JsonProperty("ChallengeNotFinishedAction")]
        public SecurityAction ChallengeNotFinishedAction{ get; set; }

        /// <summary>
        /// Execution action for client-side detection timeout. Supported values of SecurityAction Name: <li>Deny: block, where DenyActionParameters supports Stall configuration;</li><li>Monitor: observe;</li><li>Allow: respond after waiting, where AllowActionParameters requires MinDelayTime and MaxDelayTime configuration.</li>
        /// </summary>
        [JsonProperty("ChallengeTimeoutAction")]
        public SecurityAction ChallengeTimeoutAction{ get; set; }

        /// <summary>
        /// Execution action of the Bot client. Supported values of Name in SecurityAction: <li>Deny: block, where Stall configuration is supported in DenyActionParameters;</li><li>Monitor: observe;</li><li>Allow: respond after waiting, where MinDelayTime and MaxDelayTime configuration is required in AllowActionParameters.</li>
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

