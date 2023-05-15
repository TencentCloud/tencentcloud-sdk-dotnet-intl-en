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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateClusterEndpointRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// The ID of the subnet where the cluster's port is located (only needs to be entered when the non-public network access is enabled, and must be within the subnet of the cluster's VPC). 
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Whether public network access is enabled or not (True = public network access, FALSE = private network access, with the default value as FALSE).
        /// </summary>
        [JsonProperty("IsExtranet")]
        public bool? IsExtranet{ get; set; }

        /// <summary>
        /// The domain name
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// The security group in use, which must be passed in when public access is enabled.
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string SecurityGroup{ get; set; }

        /// <summary>
        /// Parameters used to create a CLB in JSON format. It’s only required for public network access. Example: `{"InternetAccessible":{"InternetChargeType":"TRAFFIC_POSTPAID_BY_HOUR","InternetMaxBandwidthOut":"200"},"VipIsp":"","BandwidthPackageId":""}`. 
        /// Parameters: 
        /// `InternetAccessible.InternetChargeType`: `TRAFFIC_POSTPAID_BY_HOUR`, `BANDWIDTH_POSTPAID_BY_HOUR`, `InternetAccessible.BANDWIDTH_PACKAGE` (Bill by the bandwidth package) 
        /// `InternetMaxBandwidthOut`: Outbound bandwidth cap in Mbps. Range: 0 - 2048. It defaults to 10. 
        /// `VipIsp`: The VIP provider. Values: `CMCC` (China Mobile), `CTCC` (China Telecom), `CUCC` (China Unicom). If this parameter is not specified, BGP will be used by default. ISPs supported in a region can be queried with the `DescribeSingleIsp` API. If an ISP is specified, only bill-by-bandwidth-package (BANDWIDTH_PACKAGE) can be used as the network billing mode. 
        /// `BandwidthPackageId`: Bandwidth package ID. If this parameter is specified, the network billing mode (`InternetAccessible.InternetChargeType`) will only support bill-by-bandwidth package (`BANDWIDTH_PACKAGE`).
        /// </summary>
        [JsonProperty("ExtensiveParameters")]
        public string ExtensiveParameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "IsExtranet", this.IsExtranet);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "SecurityGroup", this.SecurityGroup);
            this.SetParamSimple(map, prefix + "ExtensiveParameters", this.ExtensiveParameters);
        }
    }
}

