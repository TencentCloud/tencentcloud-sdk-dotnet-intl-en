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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAgentRunPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Custom running policy (CPU/Memory/NetworkPps). No modification if not passed in</p>
        /// </summary>
        [JsonProperty("CustomPolicy")]
        public CustomAgentRunModePolicy CustomPolicy{ get; set; }

        /// <summary>
        /// <p>Advanced mode machine instance_id list, automatically convert to quuid for storage in the backend</p>
        /// </summary>
        [JsonProperty("AdvanceModeInstanceIDs")]
        public string[] AdvanceModeInstanceIDs{ get; set; }

        /// <summary>
        /// <p>List of instance_id in custom mode machines, automatically convert to quuid for storage by the backend</p>
        /// </summary>
        [JsonProperty("CustomModeInstanceIDs")]
        public string[] CustomModeInstanceIDs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamObj(map, prefix + "CustomPolicy.", this.CustomPolicy);
            this.SetParamArraySimple(map, prefix + "AdvanceModeInstanceIDs.", this.AdvanceModeInstanceIDs);
            this.SetParamArraySimple(map, prefix + "CustomModeInstanceIDs.", this.CustomModeInstanceIDs);
        }
    }
}

