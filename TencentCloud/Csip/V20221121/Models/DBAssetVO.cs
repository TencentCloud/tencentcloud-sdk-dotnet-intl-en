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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DBAssetVO : AbstractModel
    {
        
        /// <summary>
        /// Asset ID
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// Asset name
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// Asset type
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// VPC tags
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// Region
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Domain name
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Asset creation time
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AssetCreateTime")]
        public string AssetCreateTime{ get; set; }

        /// <summary>
        /// Last scan time
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastScanTime")]
        public string LastScanTime{ get; set; }

        /// <summary>
        /// Configuration risks
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConfigurationRisk")]
        public ulong? ConfigurationRisk{ get; set; }

        /// <summary>
        /// Network attacks
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Attack")]
        public ulong? Attack{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Access")]
        public ulong? Access{ get; set; }

        /// <summary>
        /// Scan tasks
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanTask")]
        public ulong? ScanTask{ get; set; }

        /// <summary>
        /// User `appid`
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// User UIN
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// User name
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// Port
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// Tags
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tag")]
        public Tag[] Tag{ get; set; }

        /// <summary>
        /// Private IP
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// Public IP
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// Status
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Whether it's a critical asset
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsCore")]
        public ulong? IsCore{ get; set; }

        /// <summary>
        /// Whether it's a newly-added asset. Values: `1` (Yes), `0` (No)
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsNewAsset")]
        public ulong? IsNewAsset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "AssetCreateTime", this.AssetCreateTime);
            this.SetParamSimple(map, prefix + "LastScanTime", this.LastScanTime);
            this.SetParamSimple(map, prefix + "ConfigurationRisk", this.ConfigurationRisk);
            this.SetParamSimple(map, prefix + "Attack", this.Attack);
            this.SetParamSimple(map, prefix + "Access", this.Access);
            this.SetParamSimple(map, prefix + "ScanTask", this.ScanTask);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsCore", this.IsCore);
            this.SetParamSimple(map, prefix + "IsNewAsset", this.IsNewAsset);
        }
    }
}

