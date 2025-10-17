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

    public class DeleteLoadBalancerRequest : AbstractModel
    {
        
        /// <summary>
        /// CLB instance ID array to be deleted, which can be obtained by calling the [DescribeLoadBalancers](https://www.tencentcloud.com/document/product/214/30685?from_cn_redirect=1) API. The array can include up to 20 elements.
        /// </summary>
        [JsonProperty("LoadBalancerIds")]
        public string[] LoadBalancerIds{ get; set; }

        /// <summary>
        /// Whether to forcibly delete the CLB instance. True indicates forced deletion; False indicates non-forced deletion, and blocking verification is required.
        /// The default value is False.
        /// The deletion operation is blocked by default in the following cases. If you confirm forced deletion, the value of the forced verification parameter ForceDelete should be set to True.
        /// 1. The instance with 20 or more RS bound to the backend is deleted.
        /// 2. The instance with RS bound to the backend and the maximum peak inbound/outbound bandwidth exceeding 10 Mbps within 5 minutes is deleted.
        /// 3. Thirty or more instances are deleted within 5 minutes in a single region.
        /// </summary>
        [JsonProperty("ForceDelete")]
        public bool? ForceDelete{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "LoadBalancerIds.", this.LoadBalancerIds);
            this.SetParamSimple(map, prefix + "ForceDelete", this.ForceDelete);
        }
    }
}

