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

    public class SlaUpdateParam : AbstractModel
    {
        
        /// <summary>
        /// CLB instance ID.
        /// Can be queried through the [DescribeLoadBalancers](https://www.tencentcloud.comom/document/product/1108/48459?from_cn_redirect=1) api.
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// Specification of the LCU-supported instance. Valid values:<li> clb.c2.medium: Standard </li><li> clb.c3.small: Advanced 1 </li><li> clb.c3.medium: Advanced 2 </li><li> clb.c4.small: Super Large 1 </li><li> clb.c4.medium: Super Large 2 </li><li> clb.c4.large: Super Large 3 </li><li> clb.c4.xlarge: Super Large 4 </li> For specification details, see [Instance Specifications Comparison](https://intl.cloud.tencent.com/document/product/214/84689?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("SlaType")]
        public string SlaType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "SlaType", this.SlaType);
        }
    }
}

