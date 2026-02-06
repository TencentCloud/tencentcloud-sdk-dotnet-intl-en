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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssetCluster : AbstractModel
    {
        
        /// <summary>
        /// Tenant ID
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// Tenant uin.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Tenant Nickname
        /// </summary>
        [JsonProperty("Nick")]
        public string Nick{ get; set; }

        /// <summary>
        /// Region.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Cluster ID.
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// Cluster name.
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// Cluster type.
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// Cluster Creation Time
        /// </summary>
        [JsonProperty("InstanceCreateTime")]
        public string InstanceCreateTime{ get; set; }

        /// <summary>
        /// Status.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Cluster protection status, enumerate on the left, display on the right.
        /// Protection status of the cluster. 
        /// 0: not connected.
        /// Unprotected. 
        /// 2: partial protection. 
        /// 3: under protection. 
        /// 4: access exception. 
        /// 5: accessing. 
        /// Uninstalling. 
        /// 7: uninstallation exception.
        /// </summary>
        [JsonProperty("ProtectStatus")]
        public long? ProtectStatus{ get; set; }

        /// <summary>
        /// Access information, being empty indicates no access exception info.
        /// </summary>
        [JsonProperty("ProtectInfo")]
        public string ProtectInfo{ get; set; }

        /// <summary>
        /// VPC id.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// VPC name.
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// kubernetes version.
        /// </summary>
        [JsonProperty("KubernetesVersion")]
        public string KubernetesVersion{ get; set; }

        /// <summary>
        /// Runtime component.
        /// </summary>
        [JsonProperty("Component")]
        public string Component{ get; set; }

        /// <summary>
        /// Runtime component version.
        /// </summary>
        [JsonProperty("ComponentVersion")]
        public string ComponentVersion{ get; set; }

        /// <summary>
        /// Component status.
        /// </summary>
        [JsonProperty("ComponentStatus")]
        public string ComponentStatus{ get; set; }

        /// <summary>
        /// Health Checkup Time
        /// </summary>
        [JsonProperty("CheckTime")]
        public string CheckTime{ get; set; }

        /// <summary>
        /// Associated hosts.
        /// </summary>
        [JsonProperty("MachineCount")]
        public long? MachineCount{ get; set; }

        /// <summary>
        /// Associated Pod Count
        /// </summary>
        [JsonProperty("PodCount")]
        public long? PodCount{ get; set; }

        /// <summary>
        /// Associated Service Count
        /// </summary>
        [JsonProperty("ServiceCount")]
        public long? ServiceCount{ get; set; }

        /// <summary>
        /// Vulnerability risk.
        /// </summary>
        [JsonProperty("VulRisk")]
        public long? VulRisk{ get; set; }

        /// <summary>
        /// Configuration risk.
        /// </summary>
        [JsonProperty("CFGRisk")]
        public long? CFGRisk{ get; set; }

        /// <summary>
        /// Health Checkup Count
        /// </summary>
        [JsonProperty("CheckCount")]
        public long? CheckCount{ get; set; }

        /// <summary>
        /// Whether it is core. 1: Core; 2: Non-core.
        /// </summary>
        [JsonProperty("IsCore")]
        public long? IsCore{ get; set; }

        /// <summary>
        /// New Asset or Not. 1: New
        /// </summary>
        [JsonProperty("IsNewAsset")]
        public ulong? IsNewAsset{ get; set; }

        /// <summary>
        /// Cloud asset type: 0: tencent cloud, 1: aws, 2: azure.
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Nick", this.Nick);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "InstanceCreateTime", this.InstanceCreateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ProtectStatus", this.ProtectStatus);
            this.SetParamSimple(map, prefix + "ProtectInfo", this.ProtectInfo);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "KubernetesVersion", this.KubernetesVersion);
            this.SetParamSimple(map, prefix + "Component", this.Component);
            this.SetParamSimple(map, prefix + "ComponentVersion", this.ComponentVersion);
            this.SetParamSimple(map, prefix + "ComponentStatus", this.ComponentStatus);
            this.SetParamSimple(map, prefix + "CheckTime", this.CheckTime);
            this.SetParamSimple(map, prefix + "MachineCount", this.MachineCount);
            this.SetParamSimple(map, prefix + "PodCount", this.PodCount);
            this.SetParamSimple(map, prefix + "ServiceCount", this.ServiceCount);
            this.SetParamSimple(map, prefix + "VulRisk", this.VulRisk);
            this.SetParamSimple(map, prefix + "CFGRisk", this.CFGRisk);
            this.SetParamSimple(map, prefix + "CheckCount", this.CheckCount);
            this.SetParamSimple(map, prefix + "IsCore", this.IsCore);
            this.SetParamSimple(map, prefix + "IsNewAsset", this.IsNewAsset);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
        }
    }
}

