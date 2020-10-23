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

    public class DescribeSecurityGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// The security group instance ID, such as `sg-33ocnj9n`. It can be obtained through `DescribeSecurityGroups`. Each request can have a maximum of 100 instances. `SecurityGroupIds` and `Filters` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// Filter conditions. `SecurityGroupIds` and `Filters` cannot be specified at the same time.
        /// <li>security-group-id - String - (Filter condition) The security group ID.</li>
        /// <li>project-id - Integer - (Filter condition) The project ID.</li>
        /// <li>security-group-name - String - (Filter condition) The security group name.</li>
        /// <li>tag-key - String - Required: no - (Filter condition) Filters by tag key. For more information, see Example 2.</li>
        /// <li> `tag:tag-key` - String - Required: no - (Filter condition) Filters by tag key pair. For this parameter, `tag-key` will be replaced with a specific tag key. For more information, see Example 3.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public string Offset{ get; set; }

        /// <summary>
        /// Number of returned results. Default value: 20. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public string Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

