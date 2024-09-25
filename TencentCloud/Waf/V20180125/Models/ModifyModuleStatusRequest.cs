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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyModuleStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// Domain to be set
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Enabling status of the web security module. The value is 0 or 1.
        /// </summary>
        [JsonProperty("WebSecurity")]
        public ulong? WebSecurity{ get; set; }

        /// <summary>
        /// Access control module switch: 0 or 1
        /// </summary>
        [JsonProperty("AccessControl")]
        public ulong? AccessControl{ get; set; }

        /// <summary>
        /// CC module switch, 0 or 1
        /// </summary>
        [JsonProperty("CcProtection")]
        public ulong? CcProtection{ get; set; }

        /// <summary>
        /// API security module switch, 0 or 1
        /// </summary>
        [JsonProperty("ApiProtection")]
        public ulong? ApiProtection{ get; set; }

        /// <summary>
        /// Tamper-proof module switch: 0 or 1
        /// </summary>
        [JsonProperty("AntiTamper")]
        public ulong? AntiTamper{ get; set; }

        /// <summary>
        /// Leakage prevention module switch: 0 or 1
        /// </summary>
        [JsonProperty("AntiLeakage")]
        public ulong? AntiLeakage{ get; set; }

        /// <summary>
        /// Traffic limiting module switch: 0 or 1
        /// </summary>
        [JsonProperty("RateLimit")]
        public ulong? RateLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "WebSecurity", this.WebSecurity);
            this.SetParamSimple(map, prefix + "AccessControl", this.AccessControl);
            this.SetParamSimple(map, prefix + "CcProtection", this.CcProtection);
            this.SetParamSimple(map, prefix + "ApiProtection", this.ApiProtection);
            this.SetParamSimple(map, prefix + "AntiTamper", this.AntiTamper);
            this.SetParamSimple(map, prefix + "AntiLeakage", this.AntiLeakage);
            this.SetParamSimple(map, prefix + "RateLimit", this.RateLimit);
        }
    }
}

