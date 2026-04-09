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

    public class SourceIDC : AbstractModel
    {
        
        /// <summary>
        /// Handling method for requests from the specified IDC. valid values for SecurityAction Name: <li>Deny: block;</li> <li>Monitor: observe;</li> <li>Disabled: not enabled, disable specified rule;</li> <li>Challenge: Challenge, where ChallengeOption in ChallengeActionParameters supports JSChallenge and ManagedChallenge;</li> <li>Allow: pass (to be deprecated).</li>.
        /// </summary>
        [JsonProperty("BaseAction")]
        public SecurityAction BaseAction{ get; set; }

        /// <summary>
        /// Specifies the handling method for the specified id request.
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

