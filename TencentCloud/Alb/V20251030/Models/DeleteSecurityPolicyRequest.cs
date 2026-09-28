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

    public class DeleteSecurityPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// Security policy ID list. ID format: tls- followed by 8 alphanumeric characters.
        /// </summary>
        [JsonProperty("SecurityPolicyIds")]
        public string[] SecurityPolicyIds{ get; set; }

        /// <summary>
        /// Whether to only execute a preflight request. Value:
        /// - **true**: Execute only the preflight request without actually deleting a resource. The preflight request will verify the parameter format, permission, and whether the security policy is referenced, helping you identify potential issues before proceeding with any operations.
        /// - **false** (default): Execute a normal request. After the precheck is passed, delete the security policy directly.
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SecurityPolicyIds.", this.SecurityPolicyIds);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
        }
    }
}

