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

    public class DescribeCloudNativeAPIGatewayResult : AbstractModel
    {
        
        /// <summary>
        /// Cloud Native API Gateway ID.
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// Cloud native API gateway status.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Cloud native API gateway name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Cloud native API gateway type.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Instance version:
        /// - 2.4.1
        /// - 2.5.1
        /// </summary>
        [JsonProperty("GatewayVersion")]
        public string GatewayVersion{ get; set; }

        /// <summary>
        /// Cloud native API gateway node information.
        /// </summary>
        [JsonProperty("NodeConfig")]
        public CloudNativeAPIGatewayNodeConfig NodeConfig{ get; set; }

        /// <summary>
        /// Cloud native API gateway vpc configuration.
        /// </summary>
        [JsonProperty("VpcConfig")]
        public CloudNativeAPIGatewayVpcConfig VpcConfig{ get; set; }

        /// <summary>
        /// Cloud native API gateway description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Creation time of the cloud native API gateway.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Tag information of the instance
        /// </summary>
        [JsonProperty("Tags")]
        public InstanceTagInfo[] Tags{ get; set; }

        /// <summary>
        /// Is cls log enabled?
        /// </summary>
        [JsonProperty("EnableCls")]
        public bool? EnableCls{ get; set; }

        /// <summary>
        /// Payment mode. 0 indicates postpaid, and 1 indicates prepaid.
        /// </summary>
        [JsonProperty("TradeType")]
        public long? TradeType{ get; set; }

        /// <summary>
        /// Instance version. Currently supported: development edition, standard version, and professional version [TRIAL, STANDARD, PROFESSIONAL].
        /// </summary>
        [JsonProperty("FeatureVersion")]
        public string FeatureVersion{ get; set; }

        /// <summary>
        /// Public network outbound traffic bandwidth, [1,2048]Mbps
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// Auto-renewal flag. 0 means the default state (not set by the user, that is, the initial state).
        /// 1 means auto-renew, 2 means no automatic renewal (set by the user). If the business has no renewal concept or no need for auto-renewal, set it to 0.
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Expiry time, used when prepaid
        /// </summary>
        [JsonProperty("CurDeadline")]
        public string CurDeadline{ get; set; }

        /// <summary>
        /// Isolation time. Used when an instance is isolated.
        /// </summary>
        [JsonProperty("IsolateTime")]
        public string IsolateTime{ get; set; }

        /// <summary>
        /// Is client public network enabled?
        /// </summary>
        [JsonProperty("EnableInternet")]
        public bool? EnableInternet{ get; set; }

        /// <summary>
        /// Actual regional information of the instance
        /// </summary>
        [JsonProperty("EngineRegion")]
        public string EngineRegion{ get; set; }

        /// <summary>
        /// Ingress class name
        /// </summary>
        [JsonProperty("IngressClassName")]
        public string IngressClassName{ get; set; }

        /// <summary>
        /// Public network billing method. Selectable values: BANDWIDTH | TRAFFIC, representing billing by bandwidth and by traffic.
        /// </summary>
        [JsonProperty("InternetPayMode")]
        public string InternetPayMode{ get; set; }

        /// <summary>
        /// Cloud Native API Gateway minor version number
        /// </summary>
        [JsonProperty("GatewayMinorVersion")]
        public string GatewayMinorVersion{ get; set; }

        /// <summary>
        /// Ports monitored by the instance
        /// </summary>
        [JsonProperty("InstancePort")]
        public InstancePort InstancePort{ get; set; }

        /// <summary>
        /// Public network CLB default type
        /// </summary>
        [JsonProperty("LoadBalancerType")]
        public string LoadBalancerType{ get; set; }

        /// <summary>
        /// Public IP address list
        /// </summary>
        [JsonProperty("PublicIpAddresses")]
        public string[] PublicIpAddresses{ get; set; }

        /// <summary>
        /// Whether to enable deletion protection
        /// </summary>
        [JsonProperty("DeleteProtect")]
        public bool? DeleteProtect{ get; set; }

        /// <summary>
        /// Version number that can be upgraded
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AvailableVersions")]
        public string[] AvailableVersions{ get; set; }

        /// <summary>
        /// Version list for gateway upgrade
        /// </summary>
        [JsonProperty("AvailableUpgradeVersions")]
        public string[] AvailableUpgradeVersions{ get; set; }

        /// <summary>
        /// Whether to prompt for upgrade
        /// </summary>
        [JsonProperty("AvailableUpgrade")]
        public bool? AvailableUpgrade{ get; set; }

        /// <summary>
        /// Rollback version
        /// </summary>
        [JsonProperty("AvailableRollbackVersion")]
        public string AvailableRollbackVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "GatewayVersion", this.GatewayVersion);
            this.SetParamObj(map, prefix + "NodeConfig.", this.NodeConfig);
            this.SetParamObj(map, prefix + "VpcConfig.", this.VpcConfig);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "EnableCls", this.EnableCls);
            this.SetParamSimple(map, prefix + "TradeType", this.TradeType);
            this.SetParamSimple(map, prefix + "FeatureVersion", this.FeatureVersion);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "CurDeadline", this.CurDeadline);
            this.SetParamSimple(map, prefix + "IsolateTime", this.IsolateTime);
            this.SetParamSimple(map, prefix + "EnableInternet", this.EnableInternet);
            this.SetParamSimple(map, prefix + "EngineRegion", this.EngineRegion);
            this.SetParamSimple(map, prefix + "IngressClassName", this.IngressClassName);
            this.SetParamSimple(map, prefix + "InternetPayMode", this.InternetPayMode);
            this.SetParamSimple(map, prefix + "GatewayMinorVersion", this.GatewayMinorVersion);
            this.SetParamObj(map, prefix + "InstancePort.", this.InstancePort);
            this.SetParamSimple(map, prefix + "LoadBalancerType", this.LoadBalancerType);
            this.SetParamArraySimple(map, prefix + "PublicIpAddresses.", this.PublicIpAddresses);
            this.SetParamSimple(map, prefix + "DeleteProtect", this.DeleteProtect);
            this.SetParamArraySimple(map, prefix + "AvailableVersions.", this.AvailableVersions);
            this.SetParamArraySimple(map, prefix + "AvailableUpgradeVersions.", this.AvailableUpgradeVersions);
            this.SetParamSimple(map, prefix + "AvailableUpgrade", this.AvailableUpgrade);
            this.SetParamSimple(map, prefix + "AvailableRollbackVersion", this.AvailableRollbackVersion);
        }
    }
}

