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

    public class CreateLoadBalancerSnatIpsRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the unique ID of the cloud load balancer. you can call the [DescribeLoadBalancers](https://www.tencentcloud.com/document/product/214/30685?from_cn_redirect=1) API to query the ID, such as lb-12345678.
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// Added SnatIp information. specify IP for request or designated subnet for automatic application. can be accessed through [DescribeSubnets](https://www.tencentcloud.com/document/api/215/15784?from_cn_redirect=1) to query and retrieve. the default upper limit for one CLB instance is 10.
        /// </summary>
        [JsonProperty("SnatIps")]
        public SnatIp[] SnatIps{ get; set; }

        /// <summary>
        /// Number of SNAT IPs to be added. This parameter is used in conjunction with `SnatIps`. Note that if `Ip` is specified in `SnapIps`, this parameter is not available. It defaults to `1` and the upper limit is `10`.
        /// </summary>
        [JsonProperty("Number")]
        public ulong? Number{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamArrayObj(map, prefix + "SnatIps.", this.SnatIps);
            this.SetParamSimple(map, prefix + "Number", this.Number);
        }
    }
}

