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

    public class ClusterNetworkSettings : AbstractModel
    {
        
        /// <summary>
        /// CIDR used to assign container and service IPs for the cluster. It cannot conflict with the VPC's CIDR or the CIDRs of other clusters in the same VPC.
        /// </summary>
        [JsonProperty("ClusterCIDR")]
        public string ClusterCIDR{ get; set; }

        /// <summary>
        /// Whether to ignore ClusterCIDR conflict errors. It defaults to not ignore.
        /// </summary>
        [JsonProperty("IgnoreClusterCIDRConflict")]
        public bool? IgnoreClusterCIDRConflict{ get; set; }

        /// <summary>
        /// Maximum number of pods on each node in the cluster. Default value: 256
        /// </summary>
        [JsonProperty("MaxNodePodNum")]
        public ulong? MaxNodePodNum{ get; set; }

        /// <summary>
        /// Maximum number of cluster services. Default value: 256
        /// </summary>
        [JsonProperty("MaxClusterServiceNum")]
        public ulong? MaxClusterServiceNum{ get; set; }

        /// <summary>
        /// Whether IPVS is enabled. Default value: disabled
        /// </summary>
        [JsonProperty("Ipvs")]
        public bool? Ipvs{ get; set; }

        /// <summary>
        /// Cluster VPC ID, which is required when you create an empty cluster; otherwise, it is automatically set to be consistent with that of the nodes in the cluster
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Whether CNI is enabled for network plugin(s). Default value: enabled
        /// </summary>
        [JsonProperty("Cni")]
        public bool? Cni{ get; set; }

        /// <summary>
        /// The network mode of service. This parameter is only applicable to ipvs+bpf mode.
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("KubeProxyMode")]
        public string KubeProxyMode{ get; set; }

        /// <summary>
        /// The IP range for service assignment. It cannot conflict with the VPC’s CIDR block nor the CIDR blocks of other clusters in the same VPC.
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ServiceCIDR")]
        public string ServiceCIDR{ get; set; }

        /// <summary>
        /// The container subnet associated with the cluster
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Subnets")]
        public string[] Subnets{ get; set; }

        /// <summary>
        /// Whether to ignore ServiceCIDR conflict errors. It is only valid in VPC-CNI mode. Default value: `false`.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IgnoreServiceCIDRConflict")]
        public bool? IgnoreServiceCIDRConflict{ get; set; }

        /// <summary>
        /// Whether it is a dual-stack cluster in VPC-CNI mode. Default value: `false`, which indicates it is not a dual-stack cluster.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IsDualStack")]
        public bool? IsDualStack{ get; set; }

        /// <summary>
        /// It is used to automatically assign the IP ranges for the service.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Ipv6ServiceCIDR")]
        public string Ipv6ServiceCIDR{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterCIDR", this.ClusterCIDR);
            this.SetParamSimple(map, prefix + "IgnoreClusterCIDRConflict", this.IgnoreClusterCIDRConflict);
            this.SetParamSimple(map, prefix + "MaxNodePodNum", this.MaxNodePodNum);
            this.SetParamSimple(map, prefix + "MaxClusterServiceNum", this.MaxClusterServiceNum);
            this.SetParamSimple(map, prefix + "Ipvs", this.Ipvs);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Cni", this.Cni);
            this.SetParamSimple(map, prefix + "KubeProxyMode", this.KubeProxyMode);
            this.SetParamSimple(map, prefix + "ServiceCIDR", this.ServiceCIDR);
            this.SetParamArraySimple(map, prefix + "Subnets.", this.Subnets);
            this.SetParamSimple(map, prefix + "IgnoreServiceCIDRConflict", this.IgnoreServiceCIDRConflict);
            this.SetParamSimple(map, prefix + "IsDualStack", this.IsDualStack);
            this.SetParamSimple(map, prefix + "Ipv6ServiceCIDR", this.Ipv6ServiceCIDR);
        }
    }
}

