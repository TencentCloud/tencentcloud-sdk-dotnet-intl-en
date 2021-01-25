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

    public class CreateLoadBalancerRequest : AbstractModel
    {
        
        /// <summary>
        /// CLB instance network type:
        /// OPEN: public network; INTERNAL: private network.
        /// </summary>
        [JsonProperty("LoadBalancerType")]
        public string LoadBalancerType{ get; set; }

        /// <summary>
        /// CLB instance type. 1: generic CLB instance. Currently, only 1 can be passed in
        /// </summary>
        [JsonProperty("Forward")]
        public long? Forward{ get; set; }

        /// <summary>
        /// CLB instance name, which takes effect only when only one instance is to be created in the request. It can consist 1 to 60 letters, digits, hyphens (-), or underscores (_).
        /// Note: if the name of the new CLB instance already exists, a default name will be generated automatically.
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// Network ID of the backend target server of CLB, which can be obtained through the DescribeVpcEx API. If this parameter is not passed in, it will default to a basic network ("0").
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// A subnet ID must be specified when you purchase a private network CLB instance in a VPC, and the VIP of this instance will be generated in this subnet.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// ID of the project to which a CLB instance belongs, which can be obtained through the DescribeProject API. If this parameter is not passed in, the default project will be used.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// IP version. Valid values: IPv4, IPv6, IPv6FullChain. Default value: IPv4. This parameter is applicable only to public network CLB instances.
        /// </summary>
        [JsonProperty("AddressIPVersion")]
        public string AddressIPVersion{ get; set; }

        /// <summary>
        /// Number of CLBs to be created. Default value: 1.
        /// </summary>
        [JsonProperty("Number")]
        public ulong? Number{ get; set; }

        /// <summary>
        /// Sets the primary AZ ID for cross-AZ disaster recovery, such as 100001 or ap-guangzhou-1, which is applicable only to public network CLB.
        /// Note: A primary AZ carries traffic, while a secondary AZ does not carry traffic by default and will be used only if the primary AZ becomes unavailable. The platform will automatically select the optimal secondary AZ. The list of primary AZs in a specific region can be queried through the DescribeMasterZones API.
        /// </summary>
        [JsonProperty("MasterZoneId")]
        public string MasterZoneId{ get; set; }

        /// <summary>
        /// Specifies an AZ ID for creating a CLB instance, such as ap-guangzhou-1, which is applicable only to public network CLB.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// CLB network billing mode. This parameter is applicable only to public network CLB instances.
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// This parameter is applicable only to public network CLB instances. Valid values: CMCC (China Mobile), CTCC (China Telecom), CUCC (China Unicom). If this parameter is not specified, BGP will be used by default. ISPs supported in a region can be queried with the `DescribeSingleIsp` API. If an ISP is specified, only bill-by-bandwidth-package (BANDWIDTH_PACKAGE) can be used as the network billing mode.
        /// </summary>
        [JsonProperty("VipIsp")]
        public string VipIsp{ get; set; }

        /// <summary>
        /// Tags a CLB instance when purchasing it
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// Applies for CLB instances for a specified VIP
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// Bandwidth package ID. If this parameter is specified, the network billing mode (`InternetAccessible.InternetChargeType`) will only support bill-by-bandwidth package (`BANDWIDTH_PACKAGE`).
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }

        /// <summary>
        /// Exclusive cluster information.
        /// </summary>
        [JsonProperty("ExclusiveCluster")]
        public ExclusiveCluster ExclusiveCluster{ get; set; }

        /// <summary>
        /// A unique string supplied by the client to ensure that the request is idempotent. Its maximum length is 64 ASCII characters. If this parameter is not specified, the idempotency of the request cannot be guaranteed.
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// Whether Binding IPs of other VPCs feature switch
        /// </summary>
        [JsonProperty("SnatPro")]
        public bool? SnatPro{ get; set; }

        /// <summary>
        /// Creates `SnatIp` when the binding IPs of other VPCs feature is enabled
        /// </summary>
        [JsonProperty("SnatIps")]
        public SnatIp[] SnatIps{ get; set; }

        /// <summary>
        /// Tag for the STGW exclusive cluster.
        /// </summary>
        [JsonProperty("ClusterTag")]
        public string ClusterTag{ get; set; }

        /// <summary>
        /// Unique ID of an EIP, which can only be used when binding the EIP of a private network CLB instance. E.g., `eip-11112222`.
        /// </summary>
        [JsonProperty("EipAddressId")]
        public string EipAddressId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerType", this.LoadBalancerType);
            this.SetParamSimple(map, prefix + "Forward", this.Forward);
            this.SetParamSimple(map, prefix + "LoadBalancerName", this.LoadBalancerName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AddressIPVersion", this.AddressIPVersion);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "MasterZoneId", this.MasterZoneId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamSimple(map, prefix + "VipIsp", this.VipIsp);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "BandwidthPackageId", this.BandwidthPackageId);
            this.SetParamObj(map, prefix + "ExclusiveCluster.", this.ExclusiveCluster);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "SnatPro", this.SnatPro);
            this.SetParamArrayObj(map, prefix + "SnatIps.", this.SnatIps);
            this.SetParamSimple(map, prefix + "ClusterTag", this.ClusterTag);
            this.SetParamSimple(map, prefix + "EipAddressId", this.EipAddressId);
        }
    }
}

