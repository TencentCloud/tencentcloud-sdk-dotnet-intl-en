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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Address : AbstractModel
    {
        
        /// <summary>
        /// `EIP` `ID`, the unique ID of the `EIP`.
        /// </summary>
        [JsonProperty("AddressId")]
        public string AddressId{ get; set; }

        /// <summary>
        /// The `EIP` name.
        /// </summary>
        [JsonProperty("AddressName")]
        public string AddressName{ get; set; }

        /// <summary>
        /// Possible `EIP` states are 'CREATING', 'BINDING', 'BIND', 'UNBINDING', 'UNBIND', 'OFFLINING', and 'BIND_ENI'.
        /// </summary>
        [JsonProperty("AddressStatus")]
        public string AddressStatus{ get; set; }

        /// <summary>
        /// The public IP address
        /// </summary>
        [JsonProperty("AddressIp")]
        public string AddressIp{ get; set; }

        /// <summary>
        /// The ID of the bound resource instance. This can be a `CVM` or `NAT`.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// The creation time, which follows the `ISO8601` standard and uses `UTC` time in the format of `YYYY-MM-DDThh:mm:ssZ`.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// The ID of the bound ENI
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId{ get; set; }

        /// <summary>
        /// The private IP of the bound resources
        /// </summary>
        [JsonProperty("PrivateAddressIp")]
        public string PrivateAddressIp{ get; set; }

        /// <summary>
        /// The isolation status of the resource. `True` indicates the EIP is isolated. `False` indicates that the resource is not isolated.
        /// </summary>
        [JsonProperty("IsArrears")]
        public bool? IsArrears{ get; set; }

        /// <summary>
        /// The block status of the resource. `True` indicates the EIP is blocked. `False` indicates that the EIP is not blocked.
        /// </summary>
        [JsonProperty("IsBlocked")]
        public bool? IsBlocked{ get; set; }

        /// <summary>
        /// Whether the EIP supports direct connection mode. `True` indicates the EIP supports direct connection. `False` indicates that the resource does not support direct connection.
        /// </summary>
        [JsonProperty("IsEipDirectConnection")]
        public bool? IsEipDirectConnection{ get; set; }

        /// <summary>
        /// EIP resource type. Valid values: `CalcIP` (device IP), `WanIP` (public IP), `EIP` (elastic IP), `AnycastEIP` (accelerated EIP), and `AntiDDoSEIP` (anti-DDoS EIP).
        /// </summary>
        [JsonProperty("AddressType")]
        public string AddressType{ get; set; }

        /// <summary>
        /// Whether the EIP is automatically released after being unbound. `True` indicates the EIP will be automatically released after being unbound. `False` indicates the EIP will not be automatically released after being unbound.
        /// </summary>
        [JsonProperty("CascadeRelease")]
        public bool? CascadeRelease{ get; set; }

        /// <summary>
        /// Type of the protocol used in EIP ALG
        /// </summary>
        [JsonProperty("EipAlgType")]
        public AlgType EipAlgType{ get; set; }

        /// <summary>
        /// The ISP of an EIP/Elastic IP, with possible return values currently including "CMCC", "CTCC", "CUCC" and "BGP"
        /// </summary>
        [JsonProperty("InternetServiceProvider")]
        public string InternetServiceProvider{ get; set; }

        /// <summary>
        /// Whether the EIP is in a local BGP.
        /// </summary>
        [JsonProperty("LocalBgp")]
        public bool? LocalBgp{ get; set; }

        /// <summary>
        /// Bandwidth value of EIP. The EIP for the bill-by-CVM account will return `null`.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }

        /// <summary>
        /// Network billing mode of EIP. The EIP for the bill-by-CVM account will return `null`.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// Including:
        /// <li><strong>BANDWIDTH_PREPAID_BY_MONTH</strong></li>
        /// <p style="padding-left: 30px;">Prepaid by monthly-subscribed bandwidth.</p>
        /// <li><strong>TRAFFIC_POSTPAID_BY_HOUR</strong></li>
        /// <p style="padding-left: 30px;">Pay-as-you-go billing by hourly traffic.</p>
        /// <li><strong>BANDWIDTH_POSTPAID_BY_HOUR</strong></li>
        /// <p style="padding-left: 30px;">Pay-as-you-go billing by hourly bandwidth.</p>
        /// <li><strong>BANDWIDTH_PACKAGE</strong></li>
        /// <p style="padding-left: 30px;">Bandwidth package.</p>
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("InternetChargeType")]
        public string InternetChargeType{ get; set; }

        /// <summary>
        /// List of tags associated with the EIP
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// The expiration time.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeadlineDate")]
        public string DeadlineDate{ get; set; }

        /// <summary>
        /// The type of instance bound with the EIP
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Static single-line IP network egress
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Egress")]
        public string Egress{ get; set; }

        /// <summary>
        /// ID of the Anti-DDoS service package. It is returned if the EIP is an Anti-DDoS EIP. 
        /// </summary>
        [JsonProperty("AntiDDoSPackageId")]
        public string AntiDDoSPackageId{ get; set; }

        /// <summary>
        /// Indicates whether the current EIP is auto-renewed. This field is displayed only for EIPs with monthly prepaid bandwidth. Valid values are as follows:
        /// <li>NOTIFY_AND_MANUAL_RENEW: Normal renewal</li><li>NOTIFY_AND_AUTO_RENEW: Automatic renewal</li><li>DISABLE_NOTIFY_AND_MANUAL_RENEW: No renewal upon expiration</li>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// Indicates the ID of the Bandwidth Package associated with the current public IP. If the public IP is not billed by Bandwidth Package, this field is empty.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }

        /// <summary>
        /// Indicates the unique ID of the VPC to which the traditional EIPv6 belongs.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("UnVpcId")]
        public string UnVpcId{ get; set; }

        /// <summary>
        /// Indicates the unique ID of the CDC.
        /// Note: This field may return 'null', indicating that no valid value was found.
        /// </summary>
        [JsonProperty("DedicatedClusterId")]
        public string DedicatedClusterId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddressId", this.AddressId);
            this.SetParamSimple(map, prefix + "AddressName", this.AddressName);
            this.SetParamSimple(map, prefix + "AddressStatus", this.AddressStatus);
            this.SetParamSimple(map, prefix + "AddressIp", this.AddressIp);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "NetworkInterfaceId", this.NetworkInterfaceId);
            this.SetParamSimple(map, prefix + "PrivateAddressIp", this.PrivateAddressIp);
            this.SetParamSimple(map, prefix + "IsArrears", this.IsArrears);
            this.SetParamSimple(map, prefix + "IsBlocked", this.IsBlocked);
            this.SetParamSimple(map, prefix + "IsEipDirectConnection", this.IsEipDirectConnection);
            this.SetParamSimple(map, prefix + "AddressType", this.AddressType);
            this.SetParamSimple(map, prefix + "CascadeRelease", this.CascadeRelease);
            this.SetParamObj(map, prefix + "EipAlgType.", this.EipAlgType);
            this.SetParamSimple(map, prefix + "InternetServiceProvider", this.InternetServiceProvider);
            this.SetParamSimple(map, prefix + "LocalBgp", this.LocalBgp);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "InternetChargeType", this.InternetChargeType);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "DeadlineDate", this.DeadlineDate);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Egress", this.Egress);
            this.SetParamSimple(map, prefix + "AntiDDoSPackageId", this.AntiDDoSPackageId);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "BandwidthPackageId", this.BandwidthPackageId);
            this.SetParamSimple(map, prefix + "UnVpcId", this.UnVpcId);
            this.SetParamSimple(map, prefix + "DedicatedClusterId", this.DedicatedClusterId);
        }
    }
}

