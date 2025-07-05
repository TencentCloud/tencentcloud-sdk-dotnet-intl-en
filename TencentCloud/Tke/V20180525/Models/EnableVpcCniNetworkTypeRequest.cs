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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnableVpcCniNetworkTypeRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// The VPC-CNI mode. `tke-route-eni`: Multi-IP ENI, `tke-direct-eni`: Independent ENI
        /// </summary>
        [JsonProperty("VpcCniType")]
        public string VpcCniType{ get; set; }

        /// <summary>
        /// Whether to enable static IP address
        /// </summary>
        [JsonProperty("EnableStaticIp")]
        public bool? EnableStaticIp{ get; set; }

        /// <summary>
        /// The container subnet being used
        /// </summary>
        [JsonProperty("Subnets")]
        public string[] Subnets{ get; set; }

        /// <summary>
        /// Specifies when to release the IP after the Pod termination in static IP mode. It must be longer than 300 seconds. If this parameter is left empty, the IP address will never be released.
        /// </summary>
        [JsonProperty("ExpiredSeconds")]
        public ulong? ExpiredSeconds{ get; set; }

        /// <summary>
        /// Whether to skip adding the VPC IP range to `NonMasqueradeCIDRs` field of `ip-masq-agent-config`. Default value: `false`
        /// </summary>
        [JsonProperty("SkipAddingNonMasqueradeCIDRs")]
        public bool? SkipAddingNonMasqueradeCIDRs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "VpcCniType", this.VpcCniType);
            this.SetParamSimple(map, prefix + "EnableStaticIp", this.EnableStaticIp);
            this.SetParamArraySimple(map, prefix + "Subnets.", this.Subnets);
            this.SetParamSimple(map, prefix + "ExpiredSeconds", this.ExpiredSeconds);
            this.SetParamSimple(map, prefix + "SkipAddingNonMasqueradeCIDRs", this.SkipAddingNonMasqueradeCIDRs);
        }
    }
}

