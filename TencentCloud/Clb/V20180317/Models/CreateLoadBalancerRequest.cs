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

    public class CreateLoadBalancerRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Network type of the Cloud Load Balancer instance:<br>OPEN: public network attribute, INTERNAL: private network attribute.</p>
        /// </summary>
        [JsonProperty("LoadBalancerType")]
        public string LoadBalancerType{ get; set; }

        /// <summary>
        /// <p>Type of the Cloud Load Balancer instance. 1: Common CLB instance. Currently only support passing in 1.</p>
        /// </summary>
        [JsonProperty("Forward")]
        public long? Forward{ get; set; }

        /// <summary>
        /// <p>The name of the Cloud Load Balancer instance is effective only when creating an instance. Rule: 1-80 characters in internationally compatible languages such as English letters, Chinese characters, digits, connecting line "-", underscore "_", and other common characters (Unicode supplementary characters such as emoji and rare Chinese characters are forbidden). Note: If the name is identical to an existing Cloud Load Balancer instance name in the system, the system will automatically generate the name for the created CLB instance.</p>
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// Network ID of the target device on the CLB backend, such as `vpc-12345678`, which can be obtained through the `DescribeVpcEx` API. If this parameter is not entered, `DefaultVPC` is used by default. This parameter is required when creating a private network instance.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>When you purchase a private network CLB instance in a VPC, the subnet ID must be specified. The VIP of the private network CLB instance is generated in this subnet.<br>This parameter is required when you create a private network CLB instance or a CLB instance of the IPv6FullChain version.<br>It cannot be specified when you create a public network IPv4 CLB instance.</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// ID of the project to which a CLB instance belongs, which can be obtained through the `DescribeProject` API. If this parameter is not entered, the default project will be used.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>Applicable only to public network CLB. IP version, valid values: IPV4, IPV6, IPv6FullChain, case-insensitive, default value IPV4. Description: A value of IPV6 means IPV6 NAT64 version; a value of IPv6FullChain means IPv6 version.</p>
        /// </summary>
        [JsonProperty("AddressIPVersion")]
        public string AddressIPVersion{ get; set; }

        /// <summary>
        /// <p>Count of Cloud Load Balancers to create, default value is 1. The count must not exceed the maximum value allowed for the account, with a default creation maximum value of 20.</p>
        /// </summary>
        [JsonProperty("Number")]
        public ulong? Number{ get; set; }

        /// <summary>
        /// <p>Applicable only to public network load balancing with IP version IPv4. Sets the primary AZ ID for cross-AZ disaster recovery. Both AZ ID and name are supported, such as 100001 or ap-guangzhou-1.<br>Note: The primary AZ loads traffic. The secondary AZ does not load traffic by default and is used only if the primary AZ becomes unavailable.</p>
        /// </summary>
        [JsonProperty("MasterZoneId")]
        public string MasterZoneId{ get; set; }

        /// <summary>
        /// <p>Applicable only to public network load balancing with IP version IPv4. AZ ID, availability zone id and name are supported. Specify availability zone to create a CLB instance. For example: 100001 or ap-guangzhou-1.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>Maximum outbound bandwidth under the network billing mode. It applies only to LCU-supported instances of the private network type and all instances of the public network type.</p>
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// <p>Applicable only to public network CLB. Currently, only Guangzhou, Shanghai, Nanjing, Jinan, Hangzhou, Fuzhou, Beijing, Shijiazhuang, Wuhan, Changsha, Chengdu, and Chongqing regions support static single-line IP type. If you need to experience it, contact business manager to submit a request. After approval, you can select operator type of China Mobile (CMCC), China Unicom (CUCC), or China Telecom (CTCC). Only can be used network billing mode BANDWIDTH_PACKAGE. If this parameter is not specified, use BGP by default. You can query ISPs supported in a region via <a href="https://www.tencentcloud.com/document/api/214/70213?from_cn_redirect=1">DescribeResources</a> api.</p>
        /// </summary>
        [JsonProperty("VipIsp")]
        public string VipIsp{ get; set; }

        /// <summary>
        /// <p>When purchasing a Cloud Load Balancer, you can tag it with up to 20 tag key-value pairs.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>Specify VIP to apply for Cloud Load Balancer. This parameter is optional. If this parameter is not specified, VIP is automatically assigned. This parameter is supported for IPv4 and IPv6 types but not for IPv6 NAT64 type.<br>Note: When creating a private network instance or a public IPv6 BGP instance with a designated VIP, creation fails if the VIP is not within the IP range of the specified VPC subnet or if the VIP is already occupied.</p>
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// <p>Bandwidth package ID, which can be obtained through the <a href="https://www.tencentcloud.com/document/api/215/19209?from_cn_redirect=1">DescribeBandwidthPackages</a> API. When this parameter is specified, the network billing mode (InternetAccessible.InternetChargeType) supports only billing by bandwidth package (BANDWIDTH_PACKAGE), and the bandwidth package attributes determine the settlement method. For IPv6 Cloud Load Balancer instances purchased by non-promoted users with a non-BGP operator type, specifying bandwidth package ID is unsupported.</p>
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }

        /// <summary>
        /// <p>Dedicated instance info. This parameter is required when creating a private network CLB instance of exclusive type.</p>
        /// </summary>
        [JsonProperty("ExclusiveCluster")]
        public ExclusiveCluster ExclusiveCluster{ get; set; }

        /// <summary>
        /// <p>Performance capacity specification.</p><ul><li>If you need to create an LCU-supported instance, this parameter is required. Valid values:<ul><li> clb.c2.medium: Standard </li><li> clb.c3.small: Advanced 1 </li><li> clb.c3.medium: Advanced 2 </li><li> clb.c4.small: Super Large 1 </li><li> clb.c4.medium: Super Large 2 </li><li> clb.c4.large: Super Large 3 </li><li> clb.c4.xlarge: Super Large 4 </li></ul></li><li>For Chinese site users who need to create a shared instance, this parameter is not required. International site users will purchase a standard instance by default if this parameter is not passed.</li></ul> For specification details, see [Instance Specifications Comparison](https://www.tencentcloud.com/document/product/214/84689?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("SlaType")]
        public string SlaType{ get; set; }

        /// <summary>
        /// <p>Cluster ID. This cluster identifier is used for configuring a public cloud exclusive cluster or a local dedicated cluster. To apply for a public cloud exclusive cluster, <a href="https://console.cloud.tencent.com/workorder/category">submit a ticket</a>. For local dedicated clusters, refer to the description in <a href="https://www.tencentcloud.com/document/product/1346?from_cn_redirect=1">Local Dedicated Cluster</a>.</p>
        /// </summary>
        [JsonProperty("ClusterIds")]
        public string[] ClusterIds{ get; set; }

        /// <summary>
        /// <p>String used to ensure request idempotency. This string is generated by the customer and must be unique among different requests, with a maximum value of 64 ASCII characters. If not specified, request idempotency cannot be guaranteed.</p>
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// <p>Whether binding cross-regional or cross-Vpc IP addresses is supported.</p>
        /// </summary>
        [JsonProperty("SnatPro")]
        public bool? SnatPro{ get; set; }

        /// <summary>
        /// <p>Enable the cross-regional or cross-Vpc IP binding feature to create a SnatIp.</p>
        /// </summary>
        [JsonProperty("SnatIps")]
        public SnatIp[] SnatIps{ get; set; }

        /// <summary>
        /// <p>Tag of the Stgw exclusive cluster.</p>
        /// </summary>
        [JsonProperty("ClusterTag")]
        public string ClusterTag{ get; set; }

        /// <summary>
        /// <p>Applicable only to public network load balancing with IP version IPv4. Sets the secondary AZ ID for cross-AZ disaster recovery. AZ ID and name are supported, such as 100001 or ap-guangzhou-1.<br>Note: The secondary AZ is the availability zone that needs to carry traffic after primary availability zone failure. Query a region's list of primary/secondary AZs via the <a href="https://www.tencentcloud.com/document/api/214/70213?from_cn_redirect=1">DescribeResources</a> API. [If you need to trial the feature, submit a ticket application via <a href="https://console.cloud.tencent.com/workorder/category">Work Order</a>]</p>
        /// </summary>
        [JsonProperty("SlaveZoneId")]
        public string SlaveZoneId{ get; set; }

        /// <summary>
        /// <p>The unique ID of EIP can be accessed through the <a href="https://www.tencentcloud.com/document/product/215/16702?from_cn_redirect=1">DescribeAddresses</a> api for the query. Example: eip-qhx8udkc, applicable only to bind EIP for private network CLB.</p>
        /// </summary>
        [JsonProperty("EipAddressId")]
        public string EipAddressId{ get; set; }

        /// <summary>
        /// <p>Allow CLB traffic to the Target. Enable (true): verify security groups on CLB; deny CLB traffic to the Target (false): verify security groups on both CLB and backend instances. IPv6 CLB security group default permit, this parameter is not required.</p>
        /// </summary>
        [JsonProperty("LoadBalancerPassToTarget")]
        public bool? LoadBalancerPassToTarget{ get; set; }

        /// <summary>
        /// <p>Create a domain-name based CLB.</p>
        /// </summary>
        [JsonProperty("DynamicVip")]
        public bool? DynamicVip{ get; set; }

        /// <summary>
        /// <p>Network outbound</p>
        /// </summary>
        [JsonProperty("Egress")]
        public string Egress{ get; set; }

        /// <summary>
        /// <p>Prepaid billing attributes of the CLB instance</p>
        /// </summary>
        [JsonProperty("LBChargePrepaid")]
        public LBChargePrepaid LBChargePrepaid{ get; set; }

        /// <summary>
        /// <p>Billing type of the CLB instance. Valid values: POSTPAID_BY_HOUR and PREPAID. Default value: POSTPAID_BY_HOUR.</p><p>Enumeration values:</p><ul><li>POSTPAID_BY_HOUR: Pay-As-You-Go</li><li>PREPAID: Monthly Subscription</li></ul>
        /// </summary>
        [JsonProperty("LBChargeType")]
        public string LBChargeType{ get; set; }

        /// <summary>
        /// <p>L7 access log topic ID</p>
        /// </summary>
        [JsonProperty("AccessLogTopicId")]
        public string AccessLogTopicId{ get; set; }

        /// <summary>
        /// <p>Whether layer-7 advanced routing is enabled</p>
        /// </summary>
        [JsonProperty("AdvancedRoute")]
        public bool? AdvancedRoute{ get; set; }

        /// <summary>
        /// <p>Availability zone affinity info</p>
        /// </summary>
        [JsonProperty("AvailableZoneAffinityInfo")]
        public AvailableZoneAffinityInfo AvailableZoneAffinityInfo{ get; set; }


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
            this.SetParamSimple(map, prefix + "SlaType", this.SlaType);
            this.SetParamArraySimple(map, prefix + "ClusterIds.", this.ClusterIds);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "SnatPro", this.SnatPro);
            this.SetParamArrayObj(map, prefix + "SnatIps.", this.SnatIps);
            this.SetParamSimple(map, prefix + "ClusterTag", this.ClusterTag);
            this.SetParamSimple(map, prefix + "SlaveZoneId", this.SlaveZoneId);
            this.SetParamSimple(map, prefix + "EipAddressId", this.EipAddressId);
            this.SetParamSimple(map, prefix + "LoadBalancerPassToTarget", this.LoadBalancerPassToTarget);
            this.SetParamSimple(map, prefix + "DynamicVip", this.DynamicVip);
            this.SetParamSimple(map, prefix + "Egress", this.Egress);
            this.SetParamObj(map, prefix + "LBChargePrepaid.", this.LBChargePrepaid);
            this.SetParamSimple(map, prefix + "LBChargeType", this.LBChargeType);
            this.SetParamSimple(map, prefix + "AccessLogTopicId", this.AccessLogTopicId);
            this.SetParamSimple(map, prefix + "AdvancedRoute", this.AdvancedRoute);
            this.SetParamObj(map, prefix + "AvailableZoneAffinityInfo.", this.AvailableZoneAffinityInfo);
        }
    }
}

