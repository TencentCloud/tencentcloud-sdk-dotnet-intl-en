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

    public class DescribeNetworkAclQuintupleEntriesRequest : AbstractModel
    {
        
        /// <summary>
        /// Network ACL instance ID, such as `acl-12345678`.
        /// </summary>
        [JsonProperty("NetworkAclId")]
        public string NetworkAclId{ get; set; }

        /// <summary>
        /// Offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Returned quantity. Default: 20. Value range: 1-100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Filter condition. `HaVipIds` and `Filters` cannot be specified at the same time.
        /// <li>`protocol` - String - Such as `TCP`</li>
        /// <li>`description` - String - Description</li>
        /// <li>`destination-cidr` - String - Destination CIDR block, such as `192.168.0.0/24`</li>
        /// <li>`source-cidr` - String - Source CIDR block, such as `192.168.0.0/24`</li>
        /// <li>`action` - String - ·Values: `ACCEPT`, `DROP`</li>
        /// <li>`network-acl-quintuple-entry-id` - String - Unique ID of the quintuple, such as `acli45-ahnu4rv5`</li>
        /// <li>`network-acl-direction` - String - Direction of the policy. Values: `INGRESS` or `EGRESS`.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetworkAclId", this.NetworkAclId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

