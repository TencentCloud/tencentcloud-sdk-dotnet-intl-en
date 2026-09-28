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

    public class DescribeLoadBalancersRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Query filter criteria, supporting the following fields</p><ul><li><strong>LoadBalancerId</strong>: Cloud Load Balancer instance ID</li><li><strong>LoadBalancerName</strong>: CLB name</li><li><strong>LoadBalancerStatus</strong>: load balancing status</li><li><strong>VpcId</strong>: VPC ID</li><li><strong>tag:tag-key</strong>: filter by tag key-value pair. Replace tag-key with the actual tag key. For example, <code>tag:env</code> means filtering by the tag key <code>env</code>.</li><li><strong>AddressType</strong>: network type<ul><li><strong>Intranet</strong>: private network</li><li><strong>Internet</strong>: public network</li></ul></li><li><strong>AddressIpVersion</strong>:<ul><li><strong>IPv4</strong>: IPv4 address</li><li><strong>IPv6</strong>: IPv6 address</li></ul></li><li><strong>SecurityGroupId</strong>: security group ID</li></ul>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>Number of entries displayed each time during a batch query. Value range: <strong>1</strong>–<strong>100</strong>. Default value: <strong>20</strong>.</p>
        /// </summary>
        [JsonProperty("MaxResults")]
        public long? MaxResults{ get; set; }

        /// <summary>
        /// <p>Whether there is a token for the next query. Value:</p><ul><li>Not required for the first query or when there is no next query.</li><li>If there is a next query, the value is the <strong>NextToken</strong> returned from the last API call.</li></ul>
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
        }
    }
}

