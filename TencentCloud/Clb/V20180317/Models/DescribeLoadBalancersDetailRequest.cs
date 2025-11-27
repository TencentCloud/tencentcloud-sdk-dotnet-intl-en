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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLoadBalancersDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// Number of CLB instance lists returned. Default value: 20; maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Starting offset of the CLB instance list returned. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// List of fields. Only fields specified will be returned. If it’s left blank, `null` is returned. The fields `LoadBalancerId` and `LoadBalancerName` are added by default. For details about fields, see <a href="https://intl.cloud.tencent.com/document/api/214/30694?from_cn_redirect=1#LoadBalancerDetail">LoadBalancerDetail</a>.
        /// </summary>
        [JsonProperty("Fields")]
        public string[] Fields{ get; set; }

        /// <summary>
        /// When the Fields include TargetId, TargetAddress, TargetPort, TargetWeight, ListenerId, Protocol, Port, LocationId, Domain, and Url, you must select exporting the Target of the Target GROUP or a non-Target GROUP. valid values: NODE, GROUP.
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// Querying conditions for cloud load balancer detailed information list. detailed filter criteria.
        /// - loadbalancer-id
        /// Filter by [clb ID], for example: lb-rbw5skde.
        /// Type: String.
        /// Required: No
        /// Method for obtaining: [DescribeLoadBalancers](https://www.tencentcloud.comom/document/product/1108/48459?from_cn_redirect=1).
        /// - project-id
        /// Filters by [project ID]. for example: "0", "123".
        /// Type: String.
        /// Required: No
        /// Method for obtaining: [DescribeProject](https://www.tencentcloud.comom/document/api/651/78725?from_cn_redirect=1).
        /// - network
        /// Filters by [clb network type]. for example: Public.
        /// Type: String.
        /// Required: No
        /// Valid values: Private (Private network), Public (Public network).
        /// - vip
        /// Filter by [cloud load balancer VIP], such as "1.1.1.1", "2204::22:3".
        /// Type: String.
        /// Required: No
        /// - vpcid
        /// Filter by the vpc to which the cloud load balancer belongs, such as "vpc-12345678".
        /// Type: String.
        /// Required: No
        /// Method for obtaining: [DescribeZones](https://www.tencentcloud.comom/document/product/213/15707?from_cn_redirect=1).
        /// - target-ip
        /// Filters by the private network IP of the backend destination. for example: "1.1.1.1", "2203::214:4".
        /// Type: String.
        /// Required: No
        /// - zone
        /// Filter by [availability zone of the cloud load balancer]. for example: "ap-guangzhou-1".
        /// Type: String.
        /// Required: No
        /// Method for obtaining: [DescribeZones](https://www.tencentcloud.comom/document/product/213/15707?from_cn_redirect=1).
        /// - tag-key
        /// Filters by [tag key of the cloud load balancer tag], for example: "name".
        /// Type: String.
        /// Required: No
        /// Method for obtaining: [DescribeTags](https://www.tencentcloud.comom/document/api/651/35316?from_cn_redirect=1).
        /// - tag:*
        /// Filter by [cloud load balancer tag], where ':' is followed by the tag key. for example, to filter by tag key 'name' with tag Values 'zhangsan' and 'lisi', use {"name": "tag:name","Values": ["zhangsan", "lisi"]}.
        /// Type: String.
        /// Required: No
        /// Method for obtaining: [DescribeTagKeys](https://www.tencentcloud.comom/document/api/651/35318?from_cn_redirect=1).
        /// - fuzzy-search
        /// Searches by [clb VIP, clb name] using fuzzy search, for example: "1.1".
        /// Type: String.
        /// Required: No
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArraySimple(map, prefix + "Fields.", this.Fields);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

