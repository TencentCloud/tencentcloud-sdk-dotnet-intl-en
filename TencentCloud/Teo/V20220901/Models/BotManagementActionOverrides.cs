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

    public class BotManagementActionOverrides : AbstractModel
    {
        
        /// <summary>
        /// Specific item under the Bot rule group, used to rewrite the configuration content of this individual rule item. For detailed information corresponding to the Ids, see the returned message of the DescribeBotManagedRules API.
        /// </summary>
        [JsonProperty("Ids")]
        public string[] Ids{ get; set; }

        /// <summary>
        /// Handling action for the Bot rule item specified in Ids. Supported values for SecurityAction Name: <li>Deny: block;</li><li>Monitor: observe;</li><li>Disabled: not enabled, disable the specified rule;</li><li>Challenge: challenge. ChallengeOption in ChallengeActionParameters supports JSChallenge and ManagedChallenge;</li><li>Allow: allow (only for basic feature management of Bot).</li>
        /// </summary>
        [JsonProperty("Action")]
        public SecurityAction Action{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Ids.", this.Ids);
            this.SetParamObj(map, prefix + "Action.", this.Action);
        }
    }
}

