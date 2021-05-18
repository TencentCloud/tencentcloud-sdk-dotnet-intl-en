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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CopyFleetRequest : AbstractModel
    {
        
        /// <summary>
        /// Server fleet ID
        /// </summary>
        [JsonProperty("FleetId")]
        public string FleetId{ get; set; }

        /// <summary>
        /// Replica number. It should a value between 1 to the number of the remaining quota. It can be obtained through [Obtaining User Quota](https://intl.cloud.tencent.com/document/product/1165/48732?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("CopyNumber")]
        public long? CopyNumber{ get; set; }

        /// <summary>
        /// Asset package ID
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// Description. The length is 0-100 characters.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Network configuration
        /// </summary>
        [JsonProperty("InboundPermissions")]
        public InboundPermission[] InboundPermissions{ get; set; }

        /// <summary>
        /// Server type. It can be obtained through [Obtaining Server Instance Type List](https://intl.cloud.tencent.com/document/product/1165/48732?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Server fleet type, which only supports “ON_DEMAND” type now.
        /// </summary>
        [JsonProperty("FleetType")]
        public string FleetType{ get; set; }

        /// <summary>
        /// Server fleet name. The length is 1-50 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Protection policy. Valid values: NoProtection·(no protection), FullProtection (full protection), TimeLimitProtection (time-limited protection)
        /// </summary>
        [JsonProperty("NewGameServerSessionProtectionPolicy")]
        public string NewGameServerSessionProtectionPolicy{ get; set; }

        /// <summary>
        /// Limit policy of resource creation
        /// </summary>
        [JsonProperty("ResourceCreationLimitPolicy")]
        public ResourceCreationLimitPolicy ResourceCreationLimitPolicy{ get; set; }

        /// <summary>
        /// Progress configuration
        /// </summary>
        [JsonProperty("RuntimeConfiguration")]
        public RuntimeConfiguration RuntimeConfiguration{ get; set; }

        /// <summary>
        /// Timeout period of time-limited protection. Value range: 5-1440 minutes. Default value: 60 minutes. This parameter is valid only when NewGameSessionProtectionPolicy is set as TimeLimitProtection.
        /// </summary>
        [JsonProperty("GameServerSessionProtectionTimeLimit")]
        public long? GameServerSessionProtectionTimeLimit{ get; set; }

        /// <summary>
        /// Whether to select scaling. Valid values: SCALING_SELECTED, SCALING_UNSELECTED. Default value: SCALING_UNSELECTED.
        /// </summary>
        [JsonProperty("SelectedScalingType")]
        public string SelectedScalingType{ get; set; }

        /// <summary>
        /// Whether to associate the fleet with a CCN instance: CCN_SELECTED_BEFORE_CREATE (associate before creation), CCN_SELECTED_AFTER_CREATE (associated after creation), or CCN_UNSELECTED (do not associate); CCN_UNSELECTED by default
        /// </summary>
        [JsonProperty("SelectedCcnType")]
        public string SelectedCcnType{ get; set; }

        /// <summary>
        /// Tag list. Up to 50 tags.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// System disk. It can be a SSD (CLOUD_SSD) with 100-500 GB capacity or a Premium Cloud Storage disk (CLOUD_PREMIUM) with 50-500 GB capacity. The increment is 1.
        /// </summary>
        [JsonProperty("SystemDiskInfo")]
        public DiskInfo SystemDiskInfo{ get; set; }

        /// <summary>
        /// Data disk. It can be SSD disks (CLOUD_SSD) with 100-32000 GB capacity or Premium Cloud Storage disks (CLOUD_PREMIUM) with 10-32000 GB capacity. The increment is 10. 
        /// </summary>
        [JsonProperty("DataDiskInfo")]
        public DiskInfo[] DataDiskInfo{ get; set; }

        /// <summary>
        /// Whether to select to replicate the timer policy: TIMER_SELECTED or TIMER_UNSELECTED. The default value is TIMER_UNSELECTED.
        /// </summary>
        [JsonProperty("SelectedTimerType")]
        public string SelectedTimerType{ get; set; }

        /// <summary>
        /// Information of the CCN instance, including the owner account and the instance ID.
        /// </summary>
        [JsonProperty("CcnInfos")]
        public CcnInfo[] CcnInfos{ get; set; }

        /// <summary>
        /// Maximum outbound public network bandwidth of the server fleet. Value range: 1 - 200 Mbps. Default value: 100 Mbps.
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public long? InternetMaxBandwidthOut{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FleetId", this.FleetId);
            this.SetParamSimple(map, prefix + "CopyNumber", this.CopyNumber);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "InboundPermissions.", this.InboundPermissions);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "FleetType", this.FleetType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "NewGameServerSessionProtectionPolicy", this.NewGameServerSessionProtectionPolicy);
            this.SetParamObj(map, prefix + "ResourceCreationLimitPolicy.", this.ResourceCreationLimitPolicy);
            this.SetParamObj(map, prefix + "RuntimeConfiguration.", this.RuntimeConfiguration);
            this.SetParamSimple(map, prefix + "GameServerSessionProtectionTimeLimit", this.GameServerSessionProtectionTimeLimit);
            this.SetParamSimple(map, prefix + "SelectedScalingType", this.SelectedScalingType);
            this.SetParamSimple(map, prefix + "SelectedCcnType", this.SelectedCcnType);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "SystemDiskInfo.", this.SystemDiskInfo);
            this.SetParamArrayObj(map, prefix + "DataDiskInfo.", this.DataDiskInfo);
            this.SetParamSimple(map, prefix + "SelectedTimerType", this.SelectedTimerType);
            this.SetParamArrayObj(map, prefix + "CcnInfos.", this.CcnInfos);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
        }
    }
}

