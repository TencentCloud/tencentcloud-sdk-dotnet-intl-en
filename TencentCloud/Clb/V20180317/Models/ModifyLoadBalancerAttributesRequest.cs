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

    public class ModifyLoadBalancerAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique CLB ID
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// CLB instance name
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// Region information of the real server bound to a CLB.
        /// </summary>
        [JsonProperty("TargetRegionInfo")]
        public TargetRegionInfo TargetRegionInfo{ get; set; }

        /// <summary>
        /// Network billing parameter
        /// </summary>
        [JsonProperty("InternetChargeInfo")]
        public InternetAccessible InternetChargeInfo{ get; set; }

        /// <summary>
        /// Whether the target opens traffic from CLB to the internet. If yes (true), only security groups on CLB will be verified; if no (false), security groups on both CLB and backend instance need to be verified.
        /// </summary>
        [JsonProperty("LoadBalancerPassToTarget")]
        public bool? LoadBalancerPassToTarget{ get; set; }

        /// <summary>
        /// Whether to enable SnatPro
        /// </summary>
        [JsonProperty("SnatPro")]
        public bool? SnatPro{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "LoadBalancerName", this.LoadBalancerName);
            this.SetParamObj(map, prefix + "TargetRegionInfo.", this.TargetRegionInfo);
            this.SetParamObj(map, prefix + "InternetChargeInfo.", this.InternetChargeInfo);
            this.SetParamSimple(map, prefix + "LoadBalancerPassToTarget", this.LoadBalancerPassToTarget);
            this.SetParamSimple(map, prefix + "SnatPro", this.SnatPro);
        }
    }
}

