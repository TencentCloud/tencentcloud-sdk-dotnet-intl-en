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

    public class Vpc : AbstractModel
    {
        
        /// <summary>
        /// `VPC` name.
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// `VPC` instance `ID`, such as `vpc-azd4dt1c`.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// The `IPv4` `CIDR` of the `VPC`.
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// Whether it is the default `VPC`.
        /// </summary>
        [JsonProperty("IsDefault")]
        public bool? IsDefault{ get; set; }

        /// <summary>
        /// Whether multicast is enabled.
        /// </summary>
        [JsonProperty("EnableMulticast")]
        public bool? EnableMulticast{ get; set; }

        /// <summary>
        /// Creation Time.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// `DNS` list.
        /// </summary>
        [JsonProperty("DnsServerSet")]
        public string[] DnsServerSet{ get; set; }

        /// <summary>
        /// DHCP domain name option value.
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// `DHCP` option set `ID`.
        /// </summary>
        [JsonProperty("DhcpOptionsId")]
        public string DhcpOptionsId{ get; set; }

        /// <summary>
        /// Whether `DHCP` is enabled.
        /// </summary>
        [JsonProperty("EnableDhcp")]
        public bool? EnableDhcp{ get; set; }

        /// <summary>
        /// The `IPv6` `CIDR` of the `VPC`.
        /// </summary>
        [JsonProperty("Ipv6CidrBlock")]
        public string Ipv6CidrBlock{ get; set; }

        /// <summary>
        /// Tag key-value pair
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// Auxiliary CIDR
        /// </summary>
        [JsonProperty("AssistantCidrSet")]
        public AssistantCidr[] AssistantCidrSet{ get; set; }

        /// <summary>
        /// Vpc association with CCN route publish policy. true: enables cidr route publishing. false: enables subnet route publishing. default is subnet route publishing when creating a vpc. to select cidr route publishing, submit a ticket for adding to allowlist.
        /// </summary>
        [JsonProperty("EnableRouteVpcPublish")]
        public bool? EnableRouteVpcPublish{ get; set; }

        /// <summary>
        /// Returns the multi-operator IPv6 Cidr Block.
        /// </summary>
        [JsonProperty("Ipv6CidrBlockSet")]
        public ISPIPv6CidrBlock[] Ipv6CidrBlockSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "EnableMulticast", this.EnableMulticast);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamArraySimple(map, prefix + "DnsServerSet.", this.DnsServerSet);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "DhcpOptionsId", this.DhcpOptionsId);
            this.SetParamSimple(map, prefix + "EnableDhcp", this.EnableDhcp);
            this.SetParamSimple(map, prefix + "Ipv6CidrBlock", this.Ipv6CidrBlock);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamArrayObj(map, prefix + "AssistantCidrSet.", this.AssistantCidrSet);
            this.SetParamSimple(map, prefix + "EnableRouteVpcPublish", this.EnableRouteVpcPublish);
            this.SetParamArrayObj(map, prefix + "Ipv6CidrBlockSet.", this.Ipv6CidrBlockSet);
        }
    }
}

