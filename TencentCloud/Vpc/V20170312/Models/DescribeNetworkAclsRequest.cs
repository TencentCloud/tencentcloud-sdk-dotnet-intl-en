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

    public class DescribeNetworkAclsRequest : AbstractModel
    {
        
        /// <summary>
        /// Array of network ACL instance IDs, such as [acl-12345678]. Up to 100 instances are allowed for each request. This parameter does not support specifying `NetworkAclIds` and `Filters` at the same time.
        /// </summary>
        [JsonProperty("NetworkAclIds")]
        public string[] NetworkAclIds{ get; set; }

        /// <summary>
        /// Filter condition. `NetworkAclIds` and `Filters` cannot be specified at the same time.
        /// <li>vpc-id - String - (Filter condition) VPC instance ID, such as vpc-12345678.</li>
        /// <li>network-acl-id - String - (Filter condition) Network ACL instance ID, such as acl-12345678.</li>
        /// <li>network-acl-name - String - (Filter condition) Network ACL instance name.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset. Default: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Returned quantity. Default: 20. Value range: 1-100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "NetworkAclIds.", this.NetworkAclIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

