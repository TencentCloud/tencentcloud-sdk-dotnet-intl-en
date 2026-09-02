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

    public class PublicAssetInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Tenant ID</p>
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }

        /// <summary>
        /// <p>Cloud service provider</p>
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// <p>Cloud vendor name.</p>
        /// </summary>
        [JsonProperty("ProviderName")]
        public string ProviderName{ get; set; }

        /// <summary>
        /// <p>Cloud Account ID</p>
        /// </summary>
        [JsonProperty("CloudAccountID")]
        public string CloudAccountID{ get; set; }

        /// <summary>
        /// <p>Cloud account name</p>
        /// </summary>
        [JsonProperty("CloudAccountName")]
        public string CloudAccountName{ get; set; }

        /// <summary>
        /// <p>Asset ID.</p>
        /// </summary>
        [JsonProperty("AssetID")]
        public string AssetID{ get; set; }

        /// <summary>
        /// <p>Asset name</p>
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// <p>Asset type</p>
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// <p>Asset type name</p>
        /// </summary>
        [JsonProperty("AssetTypeName")]
        public string AssetTypeName{ get; set; }

        /// <summary>
        /// <p>Asset tag.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public AssetTag[] Tags{ get; set; }

        /// <summary>
        /// <p>Public network address</p>
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// <p>Public address type</p>
        /// </summary>
        [JsonProperty("AddressType")]
        public string AddressType{ get; set; }

        /// <summary>
        /// <p>Resolution address</p>
        /// </summary>
        [JsonProperty("ResolvedAddress")]
        public string[] ResolvedAddress{ get; set; }

        /// <summary>
        /// <p>Region.</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>Protection status</p>
        /// </summary>
        [JsonProperty("ProtectStatus")]
        public ulong? ProtectStatus{ get; set; }

        /// <summary>
        /// <p>Number of risks</p>
        /// </summary>
        [JsonProperty("RiskCount")]
        public ulong? RiskCount{ get; set; }

        /// <summary>
        /// <p>Number of alarms.</p>
        /// </summary>
        [JsonProperty("AlarmCount")]
        public ulong? AlarmCount{ get; set; }

        /// <summary>
        /// <p>Instance creation time</p>
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// <p>First sync time</p>
        /// </summary>
        [JsonProperty("FirstSyncTime")]
        public string FirstSyncTime{ get; set; }

        /// <summary>
        /// <p>Update time.</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>Total number of severe risks</p>
        /// </summary>
        [JsonProperty("CriticalRiskCount")]
        public ulong? CriticalRiskCount{ get; set; }

        /// <summary>
        /// <p>Total number of high risks</p>
        /// </summary>
        [JsonProperty("HighRiskCount")]
        public ulong? HighRiskCount{ get; set; }

        /// <summary>
        /// <p>Total number of medium risks</p>
        /// </summary>
        [JsonProperty("MediumRiskCount")]
        public ulong? MediumRiskCount{ get; set; }

        /// <summary>
        /// <p>Total number of low risks</p>
        /// </summary>
        [JsonProperty("LowRiskCount")]
        public ulong? LowRiskCount{ get; set; }

        /// <summary>
        /// <p>Unique asset ID</p>
        /// </summary>
        [JsonProperty("AssetRID")]
        public string AssetRID{ get; set; }

        /// <summary>
        /// <p>CSC tag</p>
        /// </summary>
        [JsonProperty("CustomTags")]
        public CustomTag[] CustomTags{ get; set; }

        /// <summary>
        /// <p>Asset type icon</p>
        /// </summary>
        [JsonProperty("AssetTypeIconURL")]
        public string AssetTypeIconURL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "ProviderName", this.ProviderName);
            this.SetParamSimple(map, prefix + "CloudAccountID", this.CloudAccountID);
            this.SetParamSimple(map, prefix + "CloudAccountName", this.CloudAccountName);
            this.SetParamSimple(map, prefix + "AssetID", this.AssetID);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "AssetTypeName", this.AssetTypeName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "AddressType", this.AddressType);
            this.SetParamArraySimple(map, prefix + "ResolvedAddress.", this.ResolvedAddress);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "ProtectStatus", this.ProtectStatus);
            this.SetParamSimple(map, prefix + "RiskCount", this.RiskCount);
            this.SetParamSimple(map, prefix + "AlarmCount", this.AlarmCount);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "FirstSyncTime", this.FirstSyncTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "CriticalRiskCount", this.CriticalRiskCount);
            this.SetParamSimple(map, prefix + "HighRiskCount", this.HighRiskCount);
            this.SetParamSimple(map, prefix + "MediumRiskCount", this.MediumRiskCount);
            this.SetParamSimple(map, prefix + "LowRiskCount", this.LowRiskCount);
            this.SetParamSimple(map, prefix + "AssetRID", this.AssetRID);
            this.SetParamArrayObj(map, prefix + "CustomTags.", this.CustomTags);
            this.SetParamSimple(map, prefix + "AssetTypeIconURL", this.AssetTypeIconURL);
        }
    }
}

