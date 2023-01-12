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

    public class DescribeSecurityGroupPoliciesRequest : AbstractModel
    {
        
        /// <summary>
        /// The security group instance ID, such as `sg-33ocnj9n`. It can be obtained through DescribeSecurityGroups.
        /// </summary>
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId{ get; set; }

        /// <summary>
        /// Filters
        /// <li>`security-group-id` - String - Security group ID in the rule.</li>
        /// <li>`ip` - String - IP. IPV4 and IPV6 fuzzy matching is supported.</li>
        /// <li>`address-module` - String - IP address or address group template ID.</li>
        /// <li>`service-module` - String - Protocol port or port group template ID.</li>
        /// <li>`protocol-type` - String - Protocol supported by the security group policy. Valid values: `TCP`, `UDP`, `ICMP`, `ICMPV6`, `GRE`, `ALL`.</li>
        /// <li>`port` - String - Optional - Port. Fuzzy matching is supported. Query all ports when the protocol value is `ALL`.</li>
        /// <li>`poly` - String - Policy type. Valid values: `ALL`, `ACCEPT` and `DROP`.</li>
        /// <li>`direction` - String - Direction of the rule. Valid values: `ALL`, `INBOUND` and `OUTBOUND`.</li>
        /// <li>`description` - String - Policy description. Fuzzy matching is supported.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecurityGroupId", this.SecurityGroupId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

