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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudNativeAPIGatewayConfig : AbstractModel
    {
        
        /// <summary>
        /// Console type.
        /// </summary>
        [JsonProperty("ConsoleType")]
        public string ConsoleType{ get; set; }

        /// <summary>
        /// HTTP URL.
        /// </summary>
        [JsonProperty("HttpUrl")]
        public string HttpUrl{ get; set; }

        /// <summary>
        /// HTTPS URL.
        /// </summary>
        [JsonProperty("HttpsUrl")]
        public string HttpsUrl{ get; set; }

        /// <summary>
        /// Network type, Open|Internal.
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }

        /// <summary>
        /// Admin username.
        /// </summary>
        [JsonProperty("AdminUser")]
        public string AdminUser{ get; set; }

        /// <summary>
        /// Administrator password.
        /// </summary>
        [JsonProperty("AdminPassword")]
        public string AdminPassword{ get; set; }

        /// <summary>
        /// Network Status, Open|Closed|Updating
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Network access policy
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AccessControl")]
        public NetworkAccessControl AccessControl{ get; set; }

        /// <summary>
        /// Intranet subnet ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Private network VPC ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Description of load balancing
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Load balancing specification type
        /// </summary>
        [JsonProperty("SlaType")]
        public string SlaType{ get; set; }

        /// <summary>
        /// clb specification name
        /// </summary>
        [JsonProperty("SlaName")]
        public string SlaName{ get; set; }

        /// <summary>
        /// clb vip
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// Bandwidth
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// Whether the multiple-AZ deployment mode is used.
        /// </summary>
        [JsonProperty("MultiZoneFlag")]
        public bool? MultiZoneFlag{ get; set; }

        /// <summary>
        /// Primary AZ.
        /// </summary>
        [JsonProperty("MasterZoneId")]
        public string MasterZoneId{ get; set; }

        /// <summary>
        /// standby availability zone
        /// </summary>
        [JsonProperty("SlaveZoneId")]
        public string SlaveZoneId{ get; set; }

        /// <summary>
        /// Primary availability zone name
        /// </summary>
        [JsonProperty("MasterZoneName")]
        public string MasterZoneName{ get; set; }

        /// <summary>
        /// Backup availability zone name
        /// </summary>
        [JsonProperty("SlaveZoneName")]
        public string SlaveZoneName{ get; set; }

        /// <summary>
        /// Network id
        /// </summary>
        [JsonProperty("NetworkId")]
        public string NetworkId{ get; set; }

        /// <summary>
        /// Whether the CLB is a new ipv6 CLB
        /// </summary>
        [JsonProperty("IPV6FullChain")]
        public bool? IPV6FullChain{ get; set; }

        /// <summary>
        /// Load balancing personalized configuration content
        /// </summary>
        [JsonProperty("CustomizedConfigContent")]
        public string CustomizedConfigContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConsoleType", this.ConsoleType);
            this.SetParamSimple(map, prefix + "HttpUrl", this.HttpUrl);
            this.SetParamSimple(map, prefix + "HttpsUrl", this.HttpsUrl);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "AdminUser", this.AdminUser);
            this.SetParamSimple(map, prefix + "AdminPassword", this.AdminPassword);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "AccessControl.", this.AccessControl);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SlaType", this.SlaType);
            this.SetParamSimple(map, prefix + "SlaName", this.SlaName);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "MultiZoneFlag", this.MultiZoneFlag);
            this.SetParamSimple(map, prefix + "MasterZoneId", this.MasterZoneId);
            this.SetParamSimple(map, prefix + "SlaveZoneId", this.SlaveZoneId);
            this.SetParamSimple(map, prefix + "MasterZoneName", this.MasterZoneName);
            this.SetParamSimple(map, prefix + "SlaveZoneName", this.SlaveZoneName);
            this.SetParamSimple(map, prefix + "NetworkId", this.NetworkId);
            this.SetParamSimple(map, prefix + "IPV6FullChain", this.IPV6FullChain);
            this.SetParamSimple(map, prefix + "CustomizedConfigContent", this.CustomizedConfigContent);
        }
    }
}

