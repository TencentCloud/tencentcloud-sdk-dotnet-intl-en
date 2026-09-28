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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecurityPolicyInfo : AbstractModel
    {
        
        /// <summary>
        /// List of supported cipher suites.
        /// Supported encryption suite, which depends on the TLSVersions value.
        /// Cipher only needs to be supported by any passed-in TLSVersions.
        /// 
        /// Description: If TLSv1.3 is selected, the Cipher list must contain ciphers supported by TLSv1.3.
        /// 
        /// Call the DescribeSecurityPolicyCapabilities API to get the supported encryption suite list.
        /// </summary>
        [JsonProperty("Ciphers")]
        public string[] Ciphers{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Security policy ID, format: tls- followed by 8 alphanumeric characters.
        /// </summary>
        [JsonProperty("SecurityPolicyId")]
        public string SecurityPolicyId{ get; set; }

        /// <summary>
        /// Security policy name. It must be 2-128 English or Chinese characters, starting with letters or Chinese characters. It can consist of digits, half-width periods (.), underscores (_), and dashes (-).
        /// </summary>
        [JsonProperty("SecurityPolicyName")]
        public string SecurityPolicyName{ get; set; }

        /// <summary>
        /// Security policy status. The current API most often returns Active, which means the security policy is in available status.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// List of supported TLS protocol versions. Optional values include: TLSv1.0, TLSv1.1, TLSv1.2, TLSv1.3.
        /// </summary>
        [JsonProperty("TLSVersions")]
        public string[] TLSVersions{ get; set; }

        /// <summary>
        /// Tag information.
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Ciphers.", this.Ciphers);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "SecurityPolicyId", this.SecurityPolicyId);
            this.SetParamSimple(map, prefix + "SecurityPolicyName", this.SecurityPolicyName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "TLSVersions.", this.TLSVersions);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

