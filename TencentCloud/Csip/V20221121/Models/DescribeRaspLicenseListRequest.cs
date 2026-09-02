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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRaspLicenseListRequest : AbstractModel
    {
        
        /// <summary>
        /// Filter criteria.
        /// -AssetType: asset type (CWP: CWP asset, TCSS_HOST: container host node, TCSS_EKS: container super node)
        /// -PluginStatus: plug-in status. Valid values: `Normal` (use normally), `Abnormal` (existence of anomalies), `Unused` (inactive).
        /// -ProtectionSwitch (Enable: enabled; Disable: not enabled)
        /// - ProtectionVersion: Protection edition. Valid values: `Rasp`: authorization package for important period protection; `Unauthorized`: unauthorized.
        /// - InstanceID Instance ID
        /// - InstanceName: instance name
        /// - InstanceIP: instance IP address (private/public IP address)
        /// - Container node ID of NodeID
        /// -NodeName: Container node name
        /// - ClusterID: Container cluster ID
        /// -ClusterName: container cluster name.
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// Maximum number of entries. Default value: 10.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset. Default value: 0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Sorting order. Valid values: ASC (ascending) and DESC (descending).
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Sort value
        /// - LatestUpdateTime: Latest update time.
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

