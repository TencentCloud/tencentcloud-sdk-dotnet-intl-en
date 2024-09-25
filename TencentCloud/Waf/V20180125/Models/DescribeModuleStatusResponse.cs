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

    public class DescribeModuleStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// Whether web security rules are enabled
        /// </summary>
        [JsonProperty("WebSecurity")]
        public ulong? WebSecurity{ get; set; }

        /// <summary>
        /// Whether access control rule is enabled
        /// </summary>
        [JsonProperty("AccessControl")]
        public long? AccessControl{ get; set; }

        /// <summary>
        /// Whether CC protection is enabled.
        /// </summary>
        [JsonProperty("CcProtection")]
        public ulong? CcProtection{ get; set; }

        /// <summary>
        /// Whether web tamper-proof is enabled
        /// </summary>
        [JsonProperty("AntiTamper")]
        public ulong? AntiTamper{ get; set; }

        /// <summary>
        /// Whether information leakage prevention is enabled
        /// </summary>
        [JsonProperty("AntiLeakage")]
        public ulong? AntiLeakage{ get; set; }

        /// <summary>
        /// Whether API security is enabled
        /// </summary>
        [JsonProperty("ApiProtection")]
        public ulong? ApiProtection{ get; set; }

        /// <summary>
        /// Traffic limiting module switch
        /// </summary>
        [JsonProperty("RateLimit")]
        public ulong? RateLimit{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WebSecurity", this.WebSecurity);
            this.SetParamSimple(map, prefix + "AccessControl", this.AccessControl);
            this.SetParamSimple(map, prefix + "CcProtection", this.CcProtection);
            this.SetParamSimple(map, prefix + "AntiTamper", this.AntiTamper);
            this.SetParamSimple(map, prefix + "AntiLeakage", this.AntiLeakage);
            this.SetParamSimple(map, prefix + "ApiProtection", this.ApiProtection);
            this.SetParamSimple(map, prefix + "RateLimit", this.RateLimit);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

