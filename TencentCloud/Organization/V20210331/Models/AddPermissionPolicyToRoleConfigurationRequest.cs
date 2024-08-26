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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddPermissionPolicyToRoleConfigurationRequest : AbstractModel
    {
        
        /// <summary>
        /// Space ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Permission configuration ID.
        /// </summary>
        [JsonProperty("RoleConfigurationId")]
        public string RoleConfigurationId{ get; set; }

        /// <summary>
        /// Permission policy type. Valid values: System: system policy, namely the CAM system policy reused; Custom: custom policy, namely the custom policy prepared according to the CAM permission policy syntax and structure. Only the system policy is supported at the early stage, and the custom policy will be supported later.
        /// </summary>
        [JsonProperty("RolePolicyType")]
        public string RolePolicyType{ get; set; }

        /// <summary>
        /// Permission policy name, which includes up to 20 policies, each containing up to 32 characters.
        /// </summary>
        [JsonProperty("RolePolicyNames")]
        public string[] RolePolicyNames{ get; set; }

        /// <summary>
        /// Policy details.
        /// </summary>
        [JsonProperty("RolePolicies")]
        public PolicyDetail[] RolePolicies{ get; set; }

        /// <summary>
        /// Custom policy content, which contains up to 4096 characters. When RolePolicyType is Inline, this parameter must be configured. For details, see the permission policy syntax and structure.
        /// </summary>
        [JsonProperty("CustomPolicyDocument")]
        public string CustomPolicyDocument{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "RoleConfigurationId", this.RoleConfigurationId);
            this.SetParamSimple(map, prefix + "RolePolicyType", this.RolePolicyType);
            this.SetParamArraySimple(map, prefix + "RolePolicyNames.", this.RolePolicyNames);
            this.SetParamArrayObj(map, prefix + "RolePolicies.", this.RolePolicies);
            this.SetParamSimple(map, prefix + "CustomPolicyDocument", this.CustomPolicyDocument);
        }
    }
}

