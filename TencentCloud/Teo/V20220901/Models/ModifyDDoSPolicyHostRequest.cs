/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class ModifyDDoSPolicyHostRequest : AbstractModel
    {
        
        /// <summary>
        /// The site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// The subdomain name/layer-4 proxy.
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// Whether to enabled acceleration. Values:
        /// <li>`on`: Enable</li>
        /// <li>`off`: Disable</li>
        /// </summary>
        [JsonProperty("AccelerateType")]
        public string AccelerateType{ get; set; }

        /// <summary>
        /// The policy ID.
        /// </summary>
        [JsonProperty("PolicyId")]
        public long? PolicyId{ get; set; }

        /// <summary>
        /// Whether to enable security protection. Values:
        /// <li>`on`: Enable</li>
        /// <li>`off`: Disable</li>
        /// </summary>
        [JsonProperty("SecurityType")]
        public string SecurityType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "AccelerateType", this.AccelerateType);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "SecurityType", this.SecurityType);
        }
    }
}

