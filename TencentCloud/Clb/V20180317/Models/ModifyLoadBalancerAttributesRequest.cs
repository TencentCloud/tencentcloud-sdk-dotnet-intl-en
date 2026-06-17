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
        /// <p>Unique ID of the Cloud Load Balancer (CLB). You can call the <a href="https://www.tencentcloud.com/document/product/214/30685?from_cn_redirect=1">DescribeLoadBalancers</a> API to obtain the ID.</p>
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// <p>CLB instance name. Rules: 1-80 internationally compatible characters including letters, Chinese characters, digits, "-", "_", and other common characters (Unicode supplementary characters such as emojis and rare Chinese characters are forbidden).</p>
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// <p>Set the backend service information for cross-region binding 1.0 of Cloud Load Balancer.</p>
        /// </summary>
        [JsonProperty("TargetRegionInfo")]
        public TargetRegionInfo TargetRegionInfo{ get; set; }

        /// <summary>
        /// <p>Network billing related parameters</p>
        /// </summary>
        [JsonProperty("InternetChargeInfo")]
        public InternetAccessible InternetChargeInfo{ get; set; }

        /// <summary>
        /// <p>Allow CLB traffic to the Target.<br>Enable (true): verify security groups on CLB;<br>deny CLB traffic to the Target (false): verify security groups on both CLB and backend instances.<br>Leave blank for no modification.</p>
        /// </summary>
        [JsonProperty("LoadBalancerPassToTarget")]
        public bool? LoadBalancerPassToTarget{ get; set; }

        /// <summary>
        /// <p>Switchover between different billing modes: 0 means no switchover, 1 means switch between prepaid and postpaid, 2 means switch between postpaid modes. Default value: 0</p>
        /// </summary>
        [JsonProperty("SwitchFlag")]
        public ulong? SwitchFlag{ get; set; }

        /// <summary>
        /// <p>Whether cross-region binding 2.0 is enabled. Leave it blank for no modification.</p>
        /// </summary>
        [JsonProperty("SnatPro")]
        public bool? SnatPro{ get; set; }

        /// <summary>
        /// <p>Whether to enable deletion protection. Leave it empty to skip modification.</p>
        /// </summary>
        [JsonProperty("DeleteProtect")]
        public bool? DeleteProtect{ get; set; }

        /// <summary>
        /// <p>Change the second-level domain name of Cloud Load Balancer (CLB) from mycloud.com to tencentclb.com. The subdomain will also be transformed. After modification, the mycloud.com domain name will become invalid. Leave it blank if no modification is needed.</p>
        /// </summary>
        [JsonProperty("ModifyClassicDomain")]
        public bool? ModifyClassicDomain{ get; set; }

        /// <summary>
        /// <p>Id of the associated endpoint, which can be queried via the <a href="https://www.tencentcloud.com/document/product/215/54679?from_cn_redirect=1">DescribeVpcEndPoint</a> api. Input an empty string to unbind.</p>
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
            this.SetParamSimple(map, prefix + "SwitchFlag", this.SwitchFlag);
            this.SetParamSimple(map, prefix + "SnatPro", this.SnatPro);
            this.SetParamSimple(map, prefix + "DeleteProtect", this.DeleteProtect);
            this.SetParamSimple(map, prefix + "ModifyClassicDomain", this.ModifyClassicDomain);
            this.SetParamSimple(map, prefix + "AssociateEndpoint", this.AssociateEndpoint);
        }
    }
}

