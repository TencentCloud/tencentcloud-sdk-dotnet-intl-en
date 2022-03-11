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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecurityGroupLimitSet : AbstractModel
    {
        
        /// <summary>
        /// Total number of security groups that can be created
        /// </summary>
        [JsonProperty("SecurityGroupLimit")]
        public long? SecurityGroupLimit{ get; set; }

        /// <summary>
        /// Maximum number of rules under the security group
        /// </summary>
        [JsonProperty("SecurityGroupPolicyLimit")]
        public long? SecurityGroupPolicyLimit{ get; set; }

        /// <summary>
        /// Number of nested security group rules under the security group
        /// </summary>
        [JsonProperty("ReferedSecurityGroupLimit")]
        public long? ReferedSecurityGroupLimit{ get; set; }

        /// <summary>
        /// Number of instances associated with the security group
        /// </summary>
        [JsonProperty("SecurityGroupInstanceLimit")]
        public long? SecurityGroupInstanceLimit{ get; set; }

        /// <summary>
        /// Number of security groups associated with the instance
        /// </summary>
        [JsonProperty("InstanceSecurityGroupLimit")]
        public long? InstanceSecurityGroupLimit{ get; set; }

        /// <summary>
        /// Number of modules associated with the security group
        /// </summary>
        [JsonProperty("SecurityGroupModuleLimit")]
        public long? SecurityGroupModuleLimit{ get; set; }

        /// <summary>
        /// Number of security groups associated with the module
        /// </summary>
        [JsonProperty("ModuleSecurityGroupLimit")]
        public long? ModuleSecurityGroupLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecurityGroupLimit", this.SecurityGroupLimit);
            this.SetParamSimple(map, prefix + "SecurityGroupPolicyLimit", this.SecurityGroupPolicyLimit);
            this.SetParamSimple(map, prefix + "ReferedSecurityGroupLimit", this.ReferedSecurityGroupLimit);
            this.SetParamSimple(map, prefix + "SecurityGroupInstanceLimit", this.SecurityGroupInstanceLimit);
            this.SetParamSimple(map, prefix + "InstanceSecurityGroupLimit", this.InstanceSecurityGroupLimit);
            this.SetParamSimple(map, prefix + "SecurityGroupModuleLimit", this.SecurityGroupModuleLimit);
            this.SetParamSimple(map, prefix + "ModuleSecurityGroupLimit", this.ModuleSecurityGroupLimit);
        }
    }
}

