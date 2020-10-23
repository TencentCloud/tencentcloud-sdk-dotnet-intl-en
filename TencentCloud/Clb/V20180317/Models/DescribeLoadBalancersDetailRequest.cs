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
        /// Starting offset of the CLB instance list returned. Default value: 0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// List of fields to be returned. The `LoadBalancerId` and `LoadBalancerName` are returned by default.
        /// </summary>
        [JsonProperty("Fields")]
        public string[] Fields{ get; set; }

        /// <summary>
        /// Target type. Valid values: NODE and GROUP. If the list of fields contains `TargetId`, `TargetAddress`, `TargetPort`, `TargetWeight` and other fields, `Target` of the target group or non-target group must be exported.
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// Filter condition of querying lists describing CLB instance details:
        /// <li> loadbalancer-id - String - Required: no - (Filter condition) CLB instance ID, such as "lb-12345678". </li>
        /// <li> project-id - String - Required: no - (Filter condition) Project ID, such as "0" and "123".</li>
        /// <li> network - String - Required: no - (Filter condition) Network type of the CLB instance, such as "Public" and "Private".</li>
        /// <li> vip - String - Required: no - (Filter condition) CLB instance VIP, such as "1.1.1.1" and "2204::22:3". </li>
        /// <li> target-ip - String - Required: no - (Filter condition) Private IP of the target real servers, such as"1.1.1.1" and "2203::214:4".</li>
        /// <li> vpcid - String - Required: no - (Filter condition) Identifier of the VPC instance to which the CLB instance belongs, such as "vpc-12345678".</li>
        /// <li> zone - String - Required: no - (Filter condition) Availability zone where the CLB instance resides, such as "ap-guangzhou-1".</li>
        /// <li> tag-key - String - Required: no - (Filter condition) Tag key of the CLB instance, such as "name".</li>
        /// <li> tag:* - String - Required: no - (Filter condition) CLB instance tag, followed by tag key after the colon ':'. For example, use {"Name": "tag:name","Values": ["zhangsan", "lisi"]} to filter the tag key “name” with the tag value “zhangsan” and “lisi”.</li>
        /// <li> fuzzy-search - String - Required: no - (Filter condition) Fuzzy search for CLB instance VIP and CLB instance name, such as "1.1".</li>
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

