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

    public class IPReputationGroup : AbstractModel
    {
        
        /// <summary>
        /// Execution action of the IP intelligence library (formerly client profile analysis). SecurityAction Name parameter supports: <li>Deny: block;</li> <li>Monitor: observe;</li> <li>Disabled: not enabled, disable specified rule;</li> <li>Challenge: Challenge, where ChallengeOption in ChallengeActionParameters supports JSChallenge and ManagedChallenge.</li>.
        /// </summary>
        [JsonProperty("BaseAction")]
        public SecurityAction BaseAction{ get; set; }

        /// <summary>
        /// The specific configuration of the IP intelligence library (originally client profile analysis), used to override the default configuration in BaseAction. among them, the Ids in BotManagementActionOverrides can be filled with: <li>IPREP_WEB_AND_DDOS_ATTACKERS_LOW: network attack - general confidence;</li> <li>IPREP_WEB_AND_DDOS_ATTACKERS_MID: network attack - medium confidence;</li> <li>IPREP_WEB_AND_DDOS_ATTACKERS_HIGH: network attack - HIGH confidence;</li> <li>IPREP_PROXIES_AND_ANONYMIZERS_LOW: network proxy - general confidence;</li> <li>IPREP_PROXIES_AND_ANONYMIZERS_MID: network proxy - medium confidence;</li> <li>IPREP_PROXIES_AND_ANONYMIZERS_HIGH: network proxy - HIGH confidence;</li> <li>IPREP_SCANNING_TOOLS_LOW: scanner - general confidence;</li> <li>IPREP_SCANNING_TOOLS_MID: scanner - medium confidence;</li> <li>IPREP_SCANNING_TOOLS_HIGH: scanner - HIGH confidence;</li> <li>IPREP_ATO_ATTACKERS_LOW: account takeover attack - general confidence;</li> <li>IPREP_ATO_ATTACKERS_MID: account takeover attack - medium confidence;</li> <li>IPREP_ATO_ATTACKERS_HIGH: account takeover attack - HIGH confidence;</li> <li>IPREP_WEB_SCRAPERS_AND_TRAFFIC_BOTS_LOW: malicious BOT - general confidence;</li> <li>IPREP_WEB_SCRAPERS_AND_TRAFFIC_BOTS_MID: malicious BOT - medium confidence;</li> <li>IPREP_WEB_SCRAPERS_AND_TRAFFIC_BOTS_HIGH: malicious BOT - HIGH confidence.</li>.
        /// </summary>
        [JsonProperty("BotManagementActionOverrides")]
        public BotManagementActionOverrides[] BotManagementActionOverrides{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "BaseAction.", this.BaseAction);
            this.SetParamArrayObj(map, prefix + "BotManagementActionOverrides.", this.BotManagementActionOverrides);
        }
    }
}

