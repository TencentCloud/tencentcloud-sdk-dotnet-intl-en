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

    public class SecurityWeightedAction : AbstractModel
    {
        
        /// <summary>
        /// The handling method of the Bot custom rule. valid values: <li>Allow: pass, where AllowActionParameters supports MinDelayTime and MaxDelayTime configuration;</li> <li>Deny: block, where DenyActionParameters supports BlockIp, ReturnCustomPage, and Stall configuration;</li> <li>Monitor: observation;</li> <li>Challenge: Challenge, where ChallengeActionParameters.ChallengeOption supports JSChallenge and ManagedChallenge;</li> <li>Redirect: Redirect to URL.</li>.
        /// </summary>
        [JsonProperty("SecurityAction")]
        public SecurityAction SecurityAction{ get; set; }

        /// <summary>
        /// The Weight of the current SecurityAction, only supported between 10 and 100 and must be a multiple of 10. the total of all Weight parameters must equal 100.
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SecurityAction.", this.SecurityAction);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
        }
    }
}

