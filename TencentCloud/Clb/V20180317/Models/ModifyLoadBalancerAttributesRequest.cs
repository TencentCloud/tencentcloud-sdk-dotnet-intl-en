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

    public class ModifyLoadBalancerAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the unique ID of the cloud load balancer. you can call the [DescribeLoadBalancers](https://www.tencentcloud.com/document/product/214/30685?from_cn_redirect=1) API to obtain the ID.
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// Load balancing instance name. rule: 1-60 english letters, chinese characters, digits, hyphens "-", or underscores "_".
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// The backend service information of cross-region binding 1.0
        /// </summary>
        [JsonProperty("TargetRegionInfo")]
        public TargetRegionInfo TargetRegionInfo{ get; set; }

        /// <summary>
        /// Network billing parameter
        /// </summary>
        [JsonProperty("InternetChargeInfo")]
        public InternetAccessible InternetChargeInfo{ get; set; }

        /// <summary>
        /// Specifies whether to allow CLB traffic to the Target.
        /// Enable pass-through (true): verify security groups on CLB only.
        /// Denies CLB traffic to the target (false): verify security groups on both CLB and backend instances.
        /// Specifies no modification if left blank.
        /// </summary>
        [JsonProperty("LoadBalancerPassToTarget")]
        public bool? LoadBalancerPassToTarget{ get; set; }

        /// <summary>
        /// Specifies whether the cross-region binding 2.0 feature is enabled. leave blank for no modification.
        /// </summary>
        [JsonProperty("SnatPro")]
        public bool? SnatPro{ get; set; }

        /// <summary>
        /// Specifies whether to enable deletion protection. leave it blank to keep the current setting.
        /// </summary>
        [JsonProperty("DeleteProtect")]
        public bool? DeleteProtect{ get; set; }

        /// <summary>
        /// Modifies the second-level domain name of cloud load balancer from mycloud.com to tencentclb.com. the subdomain will be transformed, and the mycloud.com domain name will become invalid after modification. leave it blank if no modification is required.
        /// </summary>
        [JsonProperty("ModifyClassicDomain")]
        public bool? ModifyClassicDomain{ get; set; }

        /// <summary>
        /// The associated endpoint Id, which can be queried via the [DescribeVpcEndPoint](https://www.tencentcloud.com/document/product/215/54679?from_cn_redirect=1) api. input an empty string to unbind.
        /// </summary>
        [JsonProperty("AssociateEndpoint")]
        public string AssociateEndpoint{ get; set; }


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
            this.SetParamSimple(map, prefix + "DeleteProtect", this.DeleteProtect);
            this.SetParamSimple(map, prefix + "ModifyClassicDomain", this.ModifyClassicDomain);
            this.SetParamSimple(map, prefix + "AssociateEndpoint", this.AssociateEndpoint);
        }
    }
}

