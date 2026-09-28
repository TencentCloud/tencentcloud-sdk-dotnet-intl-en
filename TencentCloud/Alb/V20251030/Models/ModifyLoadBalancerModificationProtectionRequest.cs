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

    public class ModifyLoadBalancerModificationProtectionRequest : AbstractModel
    {
        
        /// <summary>
        /// Cloud Load Balancer instance ID, in the format of "alb-" followed by 8 alphanumeric characters.
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// Indicates whether to enable modification protection. Once enabled, the instance is protected from unintended modification or deletion.\n- true: enables modification protection\n- false: disables modification protection
        /// </summary>
        [JsonProperty("ModificationProtectionEnabled")]
        public bool? ModificationProtectionEnabled{ get; set; }

        /// <summary>
        /// Whether to only precheck this request. Parameter Value:
        /// - true: Only perform precheck without performing operations on a resource. Check parameter integrity, request format, and service limits. If approved, DryRunOperation is returned. If not approved, the corresponding error is returned.
        /// -false (default): Execute a normal request. After the check is passed, directly perform operations on the resource.
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// Reason explanation for enabling modification protection.
        /// Length: 1–255 characters. It must be a Chinese or harmless string and can contain Chinese characters, letters, digits, dashes (-), forward slashes (/), half-width periods (.), and underscores (_).
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "ModificationProtectionEnabled", this.ModificationProtectionEnabled);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
        }
    }
}

