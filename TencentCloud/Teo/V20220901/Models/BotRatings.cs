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

    public class BotRatings : AbstractModel
    {
        
        /// <summary>
        /// Execution action for malicious Bot requests. valid values for the Name parameter in SecurityAction: <li>Deny: block;</li> <li>Monitor: observe;</li> <li>Allow: pass;</li> <li>Challenge: Challenge, where ChallengeOption in ChallengeActionParameters supports JSChallenge and ManagedChallenge.</li>.
        /// </summary>
        [JsonProperty("HighRiskBotRequestsAction")]
        public SecurityAction HighRiskBotRequestsAction{ get; set; }

        /// <summary>
        /// The execution action for suspected Bot requests. valid values for the Name parameter in SecurityAction: <li>Deny: block;</li> <li>Monitor: observe;</li> <li>Allow: pass;</li> <li>Challenge: Challenge, where ChallengeOption in ChallengeActionParameters supports JSChallenge and ManagedChallenge.</li>.
        /// </summary>
        [JsonProperty("LikelyBotRequestsAction")]
        public SecurityAction LikelyBotRequestsAction{ get; set; }

        /// <summary>
        /// Execution action for friendly Bot request. SecurityAction Name parameter supports: <li>Deny: block;</li><li>Monitor: observe;</li><li>Allow: pass;</li><li>Challenge: Challenge, where ChallengeOption in ChallengeActionParameters supports JSChallenge and ManagedChallenge.</li>.
        /// </summary>
        [JsonProperty("VerifiedBotRequestsAction")]
        public SecurityAction VerifiedBotRequestsAction{ get; set; }

        /// <summary>
        /// Execution action for a normal Bot request. valid values for the Name parameter in SecurityAction: <li>Allow: pass.</li>.
        /// </summary>
        [JsonProperty("HumanRequestsAction")]
        public SecurityAction HumanRequestsAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "HighRiskBotRequestsAction.", this.HighRiskBotRequestsAction);
            this.SetParamObj(map, prefix + "LikelyBotRequestsAction.", this.LikelyBotRequestsAction);
            this.SetParamObj(map, prefix + "VerifiedBotRequestsAction.", this.VerifiedBotRequestsAction);
            this.SetParamObj(map, prefix + "HumanRequestsAction.", this.HumanRequestsAction);
        }
    }
}

