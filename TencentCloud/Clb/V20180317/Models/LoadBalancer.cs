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

    public class LoadBalancer : AbstractModel
    {
        
        /// <summary>
        /// CLB instance ID.
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// CLB instance name.
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// Network type of the load balancing instance.
        /// OPEN: public network attribute. INTERNAL: private network attribute. for a cloud load balancer with private network attribute, you can bind an EIP for public network access. for details, see the EIP document on binding elastic IP (https://www.tencentcloud.comom/document/product/215/16700?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("LoadBalancerType")]
        public string LoadBalancerType{ get; set; }

        /// <summary>
        /// CLB type identifier. Value range: 1 (CLB); 0 (classic CLB).
        /// </summary>
        [JsonProperty("Forward")]
        public ulong? Forward{ get; set; }

        /// <summary>
        /// The domain name of the cloud load balancer instance. this field is only provided for public network classic and domain name-based load balancing instances. it is being gradually phased out. we recommend using LoadBalancerDomain instead.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// List of VIPs of a CLB instance.
        /// </summary>
        [JsonProperty("LoadBalancerVips")]
        public string[] LoadBalancerVips{ get; set; }

        /// <summary>
        /// Specifies the state of the load balancing instance, including.
        /// 0: creating. 1: normal operation.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// CLB instance creation time
        /// Format: YYYY-MM-DD HH:MM:ss.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last status transition time of the CLB instance.
        /// Format: YYYY-MM-DD HH:MM:ss.
        /// </summary>
        [JsonProperty("StatusTime")]
        public string StatusTime{ get; set; }

        /// <summary>
        /// ID of the project to which a CLB instance belongs. 0: default project.
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Anti-DDoS Pro identifier for CLB. 1: CLB with Anti-DDoS Pro; 0: CLB without Anti-DDoS Pro.
        /// </summary>
        [JsonProperty("OpenBgp")]
        public ulong? OpenBgp{ get; set; }

        /// <summary>
        /// Whether SNAT is enabled. for traditional private network clbs before december 2016, SNAT was enabled.
        /// </summary>
        [JsonProperty("Snat")]
        public bool? Snat{ get; set; }

        /// <summary>
        /// Whether isolated. 0 means not isolated. 1 means isolated.
        /// </summary>
        [JsonProperty("Isolation")]
        public ulong? Isolation{ get; set; }

        /// <summary>
        /// Log information. Only the public network CLB that have HTTP or HTTPS listeners can generate logs.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Log")]
        [System.Obsolete]
        public string Log{ get; set; }

        /// <summary>
        /// Subnet of the CLB instance (applicable only to VPC-type CLB instances on private networks)
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// CLB instance tag information
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// Security group of the CLB instance
        /// </summary>
        [JsonProperty("SecureGroups")]
        public string[] SecureGroups{ get; set; }

        /// <summary>
        /// Basic information of real servers bound to the CLB instance
        /// </summary>
        [JsonProperty("TargetRegionInfo")]
        public TargetRegionInfo TargetRegionInfo{ get; set; }

        /// <summary>
        /// Anycast CLB release domain. For non-anycast CLB, this field returns an empty string.
        /// </summary>
        [JsonProperty("AnycastZone")]
        public string AnycastZone{ get; set; }

        /// <summary>
        /// IP Version, ipv4 | ipv6
        /// </summary>
        [JsonProperty("AddressIPVersion")]
        public string AddressIPVersion{ get; set; }

        /// <summary>
        /// Specifies the VPC ID in numerical form, obtainable through the DescribeVpcs API (https://www.tencentcloud.comom/document/product/215/15778?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("NumericalVpcId")]
        public ulong? NumericalVpcId{ get; set; }

        /// <summary>
        /// Specifies the ISP of the load balancer IP address.
        /// 
        /// -BGP (multi-line).
        /// - CMCC: CMCC single line network.
        /// -CTCC: ctcc single-line.
        /// - CUCC: china unicom single-line.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VipIsp")]
        public string VipIsp{ get; set; }

        /// <summary>
        /// Primary AZ
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MasterZone")]
        public ZoneInfo MasterZone{ get; set; }

        /// <summary>
        /// Secondary AZ
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BackupZoneSet")]
        public ZoneInfo[] BackupZoneSet{ get; set; }

        /// <summary>
        /// Specifies the isolation time of the cloud load balancer instance.
        /// Format: YYYY-MM-DD HH:MM:ss.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsolatedTime")]
        public string IsolatedTime{ get; set; }

        /// <summary>
        /// CLB instance expiration time, which takes effect only for prepaid instances
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Billing mode of CLB instance. Valid values: PREPAID (monthly subscription), POSTPAID_BY_HOUR (pay as you go).
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// CLB instance network attributes
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NetworkAttributes")]
        public InternetAccessible NetworkAttributes{ get; set; }

        /// <summary>
        /// Prepaid billing attributes of a CLB instance
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PrepaidAttributes")]
        public LBChargePrepaid PrepaidAttributes{ get; set; }

        /// <summary>
        /// Log set ID of Cloud Log Service (CLS) for CLB
        /// </summary>
        [JsonProperty("LogSetId")]
        public string LogSetId{ get; set; }

        /// <summary>
        /// Log topic ID of Cloud Log Service (CLS) for CLB
        /// </summary>
        [JsonProperty("LogTopicId")]
        public string LogTopicId{ get; set; }

        /// <summary>
        /// IPv6 address of a CLB instance
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AddressIPv6")]
        public string AddressIPv6{ get; set; }

        /// <summary>
        /// Reserved field which can be ignored generally.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExtraInfo")]
        public ExtraInfo ExtraInfo{ get; set; }

        /// <summary>
        /// Whether an Anti-DDoS Pro instance can be bound
        /// </summary>
        [JsonProperty("IsDDos")]
        public bool? IsDDos{ get; set; }

        /// <summary>
        /// Custom configuration IDs of CLB instances
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// Whether the real server allows traffic from CLB
        /// </summary>
        [JsonProperty("LoadBalancerPassToTarget")]
        public bool? LoadBalancerPassToTarget{ get; set; }

        /// <summary>
        /// Exclusive cluster on the private network
        /// </summary>
        [JsonProperty("ExclusiveCluster")]
        public ExclusiveCluster ExclusiveCluster{ get; set; }

        /// <summary>
        /// Specifies the field is meaningful when the IP address version is ipv6. valid values: ipv6Nat64 | ipv6FullChain.
        /// IPv6Nat64: specifies a load balancer based on Nat64 IPv6 transition technology.
        /// IPv6FullChain: specifies a cloud load balancer implemented based on ipv6 single-stack technology.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IPv6Mode")]
        public string IPv6Mode{ get; set; }

        /// <summary>
        /// Specifies whether SnatPro is enabled.
        /// </summary>
        [JsonProperty("SnatPro")]
        public bool? SnatPro{ get; set; }

        /// <summary>
        /// Enables the SnatIp list after turning on SnatPro load balancing.
        /// </summary>
        [JsonProperty("SnatIps")]
        public SnatIp[] SnatIps{ get; set; }

        /// <summary>
        /// Performance capacity specification. <ul><li> clb.c1.small: minimalist specification </li> <li> clb.c2.medium: standard specification </li> <li> clb.c3.small: advanced type 1 specification </li> <li> clb.c3.medium: advanced type 2 specification </li> <li> clb.c4.small: super type 1 specification </li> <li> clb.c4.medium: super type 2 specification </li> <li> clb.c4.large: super type 3 specification </li> <li> clb.c4.xlarge: super type 4 specification </li> <li>"" : non-performance capacity instance</li></ul>.
        /// </summary>
        [JsonProperty("SlaType")]
        public string SlaType{ get; set; }

        /// <summary>
        /// Whether VIP is blocked
        /// </summary>
        [JsonProperty("IsBlock")]
        public bool? IsBlock{ get; set; }

        /// <summary>
        /// Specifies the blocking or unblocking time.
        /// Format: YYYY-MM-DD HH:MM:ss.
        /// </summary>
        [JsonProperty("IsBlockTime")]
        public string IsBlockTime{ get; set; }

        /// <summary>
        /// Whether the IP type is Local BGP
        /// </summary>
        [JsonProperty("LocalBgp")]
        public bool? LocalBgp{ get; set; }

        /// <summary>
        /// Dedicated layer-7 tag.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClusterTag")]
        public string ClusterTag{ get; set; }

        /// <summary>
        /// If the layer-7 listener of an IPv6FullChain CLB instance is enabled, the CLB instance can be bound with IPv4 and IPv6 CVM instances simultaneously.
        /// </summary>
        [JsonProperty("MixIpTarget")]
        public bool? MixIpTarget{ get; set; }

        /// <summary>
        /// Availability zone of a VPC-based private network CLB instance
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// Whether it is an NFV CLB instance. No returned information: no; l7nfv: yes.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NfvInfo")]
        public string NfvInfo{ get; set; }

        /// <summary>
        /// Health check log set ID of Cloud Log Service (CLS) for CLB
        /// </summary>
        [JsonProperty("HealthLogSetId")]
        public string HealthLogSetId{ get; set; }

        /// <summary>
        /// Health check log topic ID of Cloud Log Service (CLS) for CLB
        /// </summary>
        [JsonProperty("HealthLogTopicId")]
        public string HealthLogTopicId{ get; set; }

        /// <summary>
        /// Cluster ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClusterIds")]
        public string[] ClusterIds{ get; set; }

        /// <summary>
        /// Attributes of cloud load balancer, input an array of strings to determine whether it is enabled.
        /// DeleteProtect: specifies deletion protection. once enabled, it prevents the cloud load balancer from being accidentally deleted. 
        /// UserInVisible: invisible to users, controls load balancing visibility to users. 
        /// BlockStatus: specifies the blockage status, used to limit certain operations or traffic for cloud load balancer. 
        /// NoLBNat: disables the NAT feature of cloud load balancer for direct forwarding of traffic in specific scenarios. 
        /// BanStatus: specifies the blocking status for suspending the clb service or restricting access. 
        /// ShiftupFlag: specifies the upgrade flag used to identify if the cloud load balancer requires a configuration upgrade or performance improvement. 
        /// Specifies the stopped status. once enabled, the cloud load balancer suspends service. 
        /// NoVpcGw: specifies not to use VPC gateway to bypass the gateway for direct traffic handling. 
        /// SgInTgw: specifies the security group in TGW (Transit Gateway) involving network security policy configuration. 
        /// SharedLimitFlag: specifies the shared limit flag used to control the resource constraints of cloud load balancer. 
        /// WafFlag: specifies the Web application firewall (WAF) flag. enabled to enable WAF protection. 
        /// IsDomainCLB: indicates whether the cloud load balancer is domain name-based for traffic distribution. 
        /// IPv6Snat: IPv6 source address translation (Snat), used for source address processing in IPv6 networks. 
        /// HideDomain. specifies whether to hide the domain name for privacy protection or to avoid exposing it in specific scenarios. 
        /// JumboFrame: specifies giant frame support. once enabled, it supports larger data frames to improve network efficiency. 
        /// NoLBNatL4IPdc: specifies layer 4 IP direct connection without NAT, used for direct forwarding of IP traffic in layer 4 load balancing. 
        /// VpcGwL3Service: specifies the VPC gateway layer-3 Service, which involves the gateway feature of the layer-3 network. 
        /// Ipv62Flag: specifies the Ipv6 expansion Flag for specific feature support. 
        /// Ipv62ExclusiveFlag: specifies the Ipv6 exclusive flag used for exclusive Ipv6 traffic processing. 
        /// BgpPro: specifies BGP Pro support. 
        /// ToaClean: TOA (TCP Option Address) cleanup. clears Address information in TCP options. 
        /// </summary>
        [JsonProperty("AttributeFlags")]
        public string[] AttributeFlags{ get; set; }

        /// <summary>
        /// Specifies the domain name of the load balancing instance.
        /// </summary>
        [JsonProperty("LoadBalancerDomain")]
        public string LoadBalancerDomain{ get; set; }

        /// <summary>
        /// Specifies the network outbound.
        /// </summary>
        [JsonProperty("Egress")]
        public string Egress{ get; set; }

        /// <summary>
        /// Indicates whether the instance type is dedicated. 1: dedicated instance. 0: non-dedicated instance.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Exclusive")]
        public ulong? Exclusive{ get; set; }

        /// <summary>
        /// Specifies the number of bound backend services.
        /// </summary>
        [JsonProperty("TargetCount")]
        public ulong? TargetCount{ get; set; }

        /// <summary>
        /// Specifies the Endpoint id associated with the clb instance.
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
            this.SetParamSimple(map, prefix + "LoadBalancerType", this.LoadBalancerType);
            this.SetParamSimple(map, prefix + "Forward", this.Forward);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArraySimple(map, prefix + "LoadBalancerVips.", this.LoadBalancerVips);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "StatusTime", this.StatusTime);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "OpenBgp", this.OpenBgp);
            this.SetParamSimple(map, prefix + "Snat", this.Snat);
            this.SetParamSimple(map, prefix + "Isolation", this.Isolation);
            this.SetParamSimple(map, prefix + "Log", this.Log);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "SecureGroups.", this.SecureGroups);
            this.SetParamObj(map, prefix + "TargetRegionInfo.", this.TargetRegionInfo);
            this.SetParamSimple(map, prefix + "AnycastZone", this.AnycastZone);
            this.SetParamSimple(map, prefix + "AddressIPVersion", this.AddressIPVersion);
            this.SetParamSimple(map, prefix + "NumericalVpcId", this.NumericalVpcId);
            this.SetParamSimple(map, prefix + "VipIsp", this.VipIsp);
            this.SetParamObj(map, prefix + "MasterZone.", this.MasterZone);
            this.SetParamArrayObj(map, prefix + "BackupZoneSet.", this.BackupZoneSet);
            this.SetParamSimple(map, prefix + "IsolatedTime", this.IsolatedTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamObj(map, prefix + "NetworkAttributes.", this.NetworkAttributes);
            this.SetParamObj(map, prefix + "PrepaidAttributes.", this.PrepaidAttributes);
            this.SetParamSimple(map, prefix + "LogSetId", this.LogSetId);
            this.SetParamSimple(map, prefix + "LogTopicId", this.LogTopicId);
            this.SetParamSimple(map, prefix + "AddressIPv6", this.AddressIPv6);
            this.SetParamObj(map, prefix + "ExtraInfo.", this.ExtraInfo);
            this.SetParamSimple(map, prefix + "IsDDos", this.IsDDos);
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamSimple(map, prefix + "LoadBalancerPassToTarget", this.LoadBalancerPassToTarget);
            this.SetParamObj(map, prefix + "ExclusiveCluster.", this.ExclusiveCluster);
            this.SetParamSimple(map, prefix + "IPv6Mode", this.IPv6Mode);
            this.SetParamSimple(map, prefix + "SnatPro", this.SnatPro);
            this.SetParamArrayObj(map, prefix + "SnatIps.", this.SnatIps);
            this.SetParamSimple(map, prefix + "SlaType", this.SlaType);
            this.SetParamSimple(map, prefix + "IsBlock", this.IsBlock);
            this.SetParamSimple(map, prefix + "IsBlockTime", this.IsBlockTime);
            this.SetParamSimple(map, prefix + "LocalBgp", this.LocalBgp);
            this.SetParamSimple(map, prefix + "ClusterTag", this.ClusterTag);
            this.SetParamSimple(map, prefix + "MixIpTarget", this.MixIpTarget);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "NfvInfo", this.NfvInfo);
            this.SetParamSimple(map, prefix + "HealthLogSetId", this.HealthLogSetId);
            this.SetParamSimple(map, prefix + "HealthLogTopicId", this.HealthLogTopicId);
            this.SetParamArraySimple(map, prefix + "ClusterIds.", this.ClusterIds);
            this.SetParamArraySimple(map, prefix + "AttributeFlags.", this.AttributeFlags);
            this.SetParamSimple(map, prefix + "LoadBalancerDomain", this.LoadBalancerDomain);
            this.SetParamSimple(map, prefix + "Egress", this.Egress);
            this.SetParamSimple(map, prefix + "Exclusive", this.Exclusive);
            this.SetParamSimple(map, prefix + "TargetCount", this.TargetCount);
            this.SetParamSimple(map, prefix + "AssociateEndpoint", this.AssociateEndpoint);
        }
    }
}

