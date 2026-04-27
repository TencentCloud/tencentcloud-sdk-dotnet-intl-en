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

namespace TencentCloud.Edgezone.V20260401.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PublicNetworkInstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// Public network instance ID
        /// </summary>
        [JsonProperty("NetworkInstanceId")]
        public string NetworkInstanceId{ get; set; }

        /// <summary>
        /// Availability zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Public network instance name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NetworkInstanceName")]
        public string NetworkInstanceName{ get; set; }

        /// <summary>
        /// Bandwidth, Unit: Mbps
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// Line information
        /// </summary>
        [JsonProperty("Line")]
        public string Line{ get; set; }

        /// <summary>
        /// Routing mode, enumeration value: STATIC, BGP, OSPF
        /// </summary>
        [JsonProperty("RouteMode")]
        public string RouteMode{ get; set; }

        /// <summary>
        /// Number of Associated Physical Servers
        /// </summary>
        [JsonProperty("ServerCount")]
        public long? ServerCount{ get; set; }

        /// <summary>
        /// Applied Ipv4 quantity
        /// </summary>
        [JsonProperty("Ipv4Count")]
        public long? Ipv4Count{ get; set; }

        /// <summary>
        /// Number of applied Ipv6 addresses
        /// </summary>
        [JsonProperty("Ipv6Count")]
        public long? Ipv6Count{ get; set; }

        /// <summary>
        /// Associated Ipv4 subnet
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Ipv4CidrSet")]
        public PublicNetworkSegment[] Ipv4CidrSet{ get; set; }

        /// <summary>
        /// Associated Ipv6 segment
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Ipv6CidrSet")]
        public PublicNetworkSegment[] Ipv6CidrSet{ get; set; }

        /// <summary>
        /// Public network instance creation time
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// Public network instance last modified
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetworkInstanceId", this.NetworkInstanceId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "NetworkInstanceName", this.NetworkInstanceName);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "Line", this.Line);
            this.SetParamSimple(map, prefix + "RouteMode", this.RouteMode);
            this.SetParamSimple(map, prefix + "ServerCount", this.ServerCount);
            this.SetParamSimple(map, prefix + "Ipv4Count", this.Ipv4Count);
            this.SetParamSimple(map, prefix + "Ipv6Count", this.Ipv6Count);
            this.SetParamArrayObj(map, prefix + "Ipv4CidrSet.", this.Ipv4CidrSet);
            this.SetParamArrayObj(map, prefix + "Ipv6CidrSet.", this.Ipv6CidrSet);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
        }
    }
}

