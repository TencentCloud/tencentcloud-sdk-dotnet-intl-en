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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkInterface : AbstractModel
    {
        
        /// <summary>
        /// The ID of the ENI instance, such as `eni-f1xjkw1b`.
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId{ get; set; }

        /// <summary>
        /// ENI Name
        /// </summary>
        [JsonProperty("NetworkInterfaceName")]
        public string NetworkInterfaceName{ get; set; }

        /// <summary>
        /// ENI description.
        /// </summary>
        [JsonProperty("NetworkInterfaceDescription")]
        public string NetworkInterfaceDescription{ get; set; }

        /// <summary>
        /// Subnet instance ID.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// VPC instance ID.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Bound security group.
        /// </summary>
        [JsonProperty("GroupSet")]
        public string[] GroupSet{ get; set; }

        /// <summary>
        /// Whether it is the primary ENI.
        /// </summary>
        [JsonProperty("Primary")]
        public bool? Primary{ get; set; }

        /// <summary>
        /// MAC address
        /// </summary>
        [JsonProperty("MacAddress")]
        public string MacAddress{ get; set; }

        /// <summary>
        /// ENI status:
        /// <li>`PENDING`: Creating</li>
        /// <li>`AVAILABLE`: Available</li>
        /// <li>`ATTACHING`: Binding</li>
        /// <li>`DETACHING`: Unbinding</li>
        /// <li>`DELETING`: Deleting</li>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Private IP information.
        /// </summary>
        [JsonProperty("PrivateIpAddressSet")]
        public PrivateIpAddressSpecification[] PrivateIpAddressSet{ get; set; }

        /// <summary>
        /// Bound CVM object.
        /// Note: This field may return null, indicating no valid value.
        /// </summary>
        [JsonProperty("Attachment")]
        public NetworkInterfaceAttachment Attachment{ get; set; }

        /// <summary>
        /// Availability Zone.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Creation Time.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// The `IPv6` address list.
        /// </summary>
        [JsonProperty("Ipv6AddressSet")]
        public Ipv6Address[] Ipv6AddressSet{ get; set; }

        /// <summary>
        /// Tag key-value pair.
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// The ENI type. 0: ENI. 1: EVM ENI.
        /// </summary>
        [JsonProperty("EniType")]
        public ulong? EniType{ get; set; }

        /// <summary>
        /// Type of the resource bound with an ENI. Valid values: cvm, eks.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// ID of the CDC instance associated with the ENI
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }

        /// <summary>
        /// ENI type. Valid values: `0` (standard); `1` (extension). Default value: `0`.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AttachType")]
        public ulong? AttachType{ get; set; }

        /// <summary>
        /// The ID of resource to retain the ENI primary IP. It’s used as the request parameters for deleting an ENI.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// Service level
        /// <li>`DEFAULT`: Default level</lil>
        /// <li>`PT`: Gold</li>
        /// <li>`AU`: Silver</li>
        /// <li>`AG`: Bronze</li>
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QosLevel")]
        public string QosLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetworkInterfaceId", this.NetworkInterfaceId);
            this.SetParamSimple(map, prefix + "NetworkInterfaceName", this.NetworkInterfaceName);
            this.SetParamSimple(map, prefix + "NetworkInterfaceDescription", this.NetworkInterfaceDescription);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamArraySimple(map, prefix + "GroupSet.", this.GroupSet);
            this.SetParamSimple(map, prefix + "Primary", this.Primary);
            this.SetParamSimple(map, prefix + "MacAddress", this.MacAddress);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamArrayObj(map, prefix + "PrivateIpAddressSet.", this.PrivateIpAddressSet);
            this.SetParamObj(map, prefix + "Attachment.", this.Attachment);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamArrayObj(map, prefix + "Ipv6AddressSet.", this.Ipv6AddressSet);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "EniType", this.EniType);
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
            this.SetParamSimple(map, prefix + "AttachType", this.AttachType);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "QosLevel", this.QosLevel);
        }
    }
}

