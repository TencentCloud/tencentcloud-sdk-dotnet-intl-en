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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecurityGroupPolicySet : AbstractModel
    {
        
        /// <summary>
        /// The version number of the security group policy, which will automatically increase by one each time you update the security group policy, so as to prevent expiration of the updated routing policies. If it is left empty, any conflicts will be ignored. 
        /// Note: This parameter may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Outbound rule. 
        /// Note: This parameter may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Egress")]
        public SecurityGroupPolicy[] Egress{ get; set; }

        /// <summary>
        /// Inbound rule. 
        /// Note: This parameter may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Ingress")]
        public SecurityGroupPolicy[] Ingress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamArrayObj(map, prefix + "Egress.", this.Egress);
            this.SetParamArrayObj(map, prefix + "Ingress.", this.Ingress);
        }
    }
}

