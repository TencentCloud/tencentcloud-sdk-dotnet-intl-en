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

namespace TencentCloud.Tdid.V20210519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegisterClaimPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// The claim protocol type (CPT) index.
        /// </summary>
        [JsonProperty("CptIndex")]
        public ulong? CptIndex{ get; set; }

        /// <summary>
        /// The disclosure policy.
        /// </summary>
        [JsonProperty("Policy")]
        public string Policy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CptIndex", this.CptIndex);
            this.SetParamSimple(map, prefix + "Policy", this.Policy);
        }
    }
}

