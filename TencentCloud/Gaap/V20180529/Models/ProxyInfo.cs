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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProxyInfo : AbstractModel
    {
        
        /// <summary>
        /// Connection instance ID; It's an old parameter, please switch to ProxyId.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Creation time in the format of UNIX timestamp, indicating the number of seconds that have elapsed since January 1, 1970 (midnight in UTC/GMT).
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Connection name.
        /// </summary>
        [JsonProperty("ProxyName")]
        public string ProxyName{ get; set; }

        /// <summary>
        /// Access region.
        /// </summary>
        [JsonProperty("AccessRegion")]
        public string AccessRegion{ get; set; }

        /// <summary>
        /// Origin server region.
        /// </summary>
        [JsonProperty("RealServerRegion")]
        public string RealServerRegion{ get; set; }

        /// <summary>
        /// Bandwidth. Unit: Mbps.
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// Concurrence. Unit: 10K requests/second.
        /// </summary>
        [JsonProperty("Concurrent")]
        public long? Concurrent{ get; set; }

        /// <summary>
        /// Connection status. Valid values:
        /// `RUNNING`: Running
        /// `CREATING`: Creating
        /// `DESTROYING`: Terminating
        /// `OPENING`: Enabling
        /// `CLOSING`: Disabling
        /// `CLOSED`: Disabled
        /// `ADJUSTING`: Adjusting configuration
        /// `ISOLATING`: Isolating
        /// `ISOLATED`: Isolated
        /// `CLONING`: Copying
        /// `RECOVERING`: Maintaining
        /// `MOVING`: Migrating
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Accessed domain name.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Accessed IP.
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// Connection versions: 1.0, 2.0, 3.0.
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Connection instance ID; It's a new parameter.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// 1: this connection is expandable; 0: this connection is not expandable.
        /// </summary>
        [JsonProperty("Scalarable")]
        public long? Scalarable{ get; set; }

        /// <summary>
        /// Supported protocol types.
        /// </summary>
        [JsonProperty("SupportProtocols")]
        public string[] SupportProtocols{ get; set; }

        /// <summary>
        /// Connection group ID. This field exists if a connection belongs to a connection group.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// Security policy ID. This field exists if security policies are configured.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// Access region details, including region ID and region name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AccessRegionInfo")]
        public RegionDetail AccessRegionInfo{ get; set; }

        /// <summary>
        /// Origin server region details, including region ID and region name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RealServerRegionInfo")]
        public RegionDetail RealServerRegionInfo{ get; set; }

        /// <summary>
        /// Forwarding IP of the connection
        /// </summary>
        [JsonProperty("ForwardIP")]
        public string ForwardIP{ get; set; }

        /// <summary>
        /// Tag list. This field is an empty list if no tags exist.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TagSet")]
        public TagPair[] TagSet{ get; set; }

        /// <summary>
        /// Whether security groups are supported.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SupportSecurity")]
        public long? SupportSecurity{ get; set; }

        /// <summary>
        /// Billing mode. 0: bill-by-bandwidth; 1: bill-by-traffic.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BillingType")]
        public long? BillingType{ get; set; }

        /// <summary>
        /// List of domain names associated with resolution record
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RelatedGlobalDomains")]
        public string[] RelatedGlobalDomains{ get; set; }

        /// <summary>
        /// Configuration change time
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ModifyConfigTime")]
        public ulong? ModifyConfigTime{ get; set; }

        /// <summary>
        /// Connection type. `100`: THUNDER connection; `103`: Microsoft connection.
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ProxyType")]
        public ulong? ProxyType{ get; set; }

        /// <summary>
        /// Describes how the connection obtains client IPs. 0: TOA; 1: Proxy Protocol.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClientIPMethod")]
        public long?[] ClientIPMethod{ get; set; }

        /// <summary>
        /// IP version. Valid values: `IPv4`, `IPv6`.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IPAddressVersion")]
        public string IPAddressVersion{ get; set; }

        /// <summary>
        /// Network type. `normal`: general BGP; `cn2`: Dedicated BGP; `triple`: Non-BGP (provided by the top 3 ISPs in the Chinese mainland); `secure_eip`: Custom security EIP.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// Package type of connections. Valid values: `Thunder` (general connection), `Accelerator` (silver connection), 
        /// and `CrossBorder` (cross-MLC-border connection).
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// Blocking-related status of the domain name. `BANNED`: the domain name is blocked; `RECOVER`: the domain name is unblocked or normal; `BANNING`: the domain name is being blocked; `RECOVERING`: the domain name is being unblocked; `BAN_FAILED`: the blocking fails; RECOVER_FAILED: the unblocking fails.
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("BanStatus")]
        public string BanStatus{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("IPList")]
        public IPDetail[] IPList{ get; set; }

        /// <summary>
        /// Specifies whether to enable HTTP3. Valid values:
        /// `0`: disable HTTP3;
        /// `1`: enable HTTP3.
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Http3Supported")]
        public long? Http3Supported{ get; set; }

        /// <summary>
        /// Indicates whether the origin server IP or domain name is in the blocklist. Valid values: `0` (no) and `1` (yes).
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("InBanBlacklist")]
        public long? InBanBlacklist{ get; set; }

        /// <summary>
        /// Feature bitmap. Valid values:
        /// `0`: Feature not supported
        /// `1`: Feature supported
        /// Each bit in the bitmap represents a feature:
        /// 1st bit: Layer-4 acceleration;
        /// 2nd bit: Layer-7 acceleration;
        /// 3rd bit: HTTP3 access;
        /// 4th bit: IPv6;
        /// 5th bit: Dedicated BGP access;
        /// 6th bit: Non-BGP access;
        /// 7th bit: QoS acceleration.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("FeatureBitmap")]
        public long? FeatureBitmap{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProxyName", this.ProxyName);
            this.SetParamSimple(map, prefix + "AccessRegion", this.AccessRegion);
            this.SetParamSimple(map, prefix + "RealServerRegion", this.RealServerRegion);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "Concurrent", this.Concurrent);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "Scalarable", this.Scalarable);
            this.SetParamArraySimple(map, prefix + "SupportProtocols.", this.SupportProtocols);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamObj(map, prefix + "AccessRegionInfo.", this.AccessRegionInfo);
            this.SetParamObj(map, prefix + "RealServerRegionInfo.", this.RealServerRegionInfo);
            this.SetParamSimple(map, prefix + "ForwardIP", this.ForwardIP);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "SupportSecurity", this.SupportSecurity);
            this.SetParamSimple(map, prefix + "BillingType", this.BillingType);
            this.SetParamArraySimple(map, prefix + "RelatedGlobalDomains.", this.RelatedGlobalDomains);
            this.SetParamSimple(map, prefix + "ModifyConfigTime", this.ModifyConfigTime);
            this.SetParamSimple(map, prefix + "ProxyType", this.ProxyType);
            this.SetParamArraySimple(map, prefix + "ClientIPMethod.", this.ClientIPMethod);
            this.SetParamSimple(map, prefix + "IPAddressVersion", this.IPAddressVersion);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "BanStatus", this.BanStatus);
            this.SetParamArrayObj(map, prefix + "IPList.", this.IPList);
            this.SetParamSimple(map, prefix + "Http3Supported", this.Http3Supported);
            this.SetParamSimple(map, prefix + "InBanBlacklist", this.InBanBlacklist);
            this.SetParamSimple(map, prefix + "FeatureBitmap", this.FeatureBitmap);
        }
    }
}

