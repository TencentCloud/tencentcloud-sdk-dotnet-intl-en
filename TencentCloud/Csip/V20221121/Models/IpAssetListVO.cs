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

    public class IpAssetListVO : AbstractModel
    {
        
        /// <summary>
        /// Asset ID
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// Asset Name
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// Asset type
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// Region.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Cloud Defense Status
        /// </summary>
        [JsonProperty("CFWStatus")]
        public ulong? CFWStatus{ get; set; }

        /// <summary>
        /// Asset creation time
        /// </summary>
        [JsonProperty("AssetCreateTime")]
        public string AssetCreateTime{ get; set; }

        /// <summary>
        /// Public IP address
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// Public IP Type
        /// </summary>
        [JsonProperty("PublicIpType")]
        public ulong? PublicIpType{ get; set; }

        /// <summary>
        /// vpc
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// VPC Name
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// appid
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// User UIN
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// Core
        /// </summary>
        [JsonProperty("IsCore")]
        public ulong? IsCore{ get; set; }

        /// <summary>
        /// On-Cloud
        /// </summary>
        [JsonProperty("IsCloud")]
        public ulong? IsCloud{ get; set; }

        /// <summary>
        /// network attack
        /// </summary>
        [JsonProperty("Attack")]
        public ulong? Attack{ get; set; }

        /// <summary>
        /// Network access
        /// </summary>
        [JsonProperty("Access")]
        public ulong? Access{ get; set; }

        /// <summary>
        /// Network Interception
        /// </summary>
        [JsonProperty("Intercept")]
        public ulong? Intercept{ get; set; }

        /// <summary>
        /// Inbound bandwidth
        /// </summary>
        [JsonProperty("InBandwidth")]
        public string InBandwidth{ get; set; }

        /// <summary>
        /// Outbound bandwidth
        /// </summary>
        [JsonProperty("OutBandwidth")]
        public string OutBandwidth{ get; set; }

        /// <summary>
        /// Inbound traffic
        /// </summary>
        [JsonProperty("InFlow")]
        public string InFlow{ get; set; }

        /// <summary>
        /// outbound traffic
        /// </summary>
        [JsonProperty("OutFlow")]
        public string OutFlow{ get; set; }

        /// <summary>
        /// Last scan time
        /// </summary>
        [JsonProperty("LastScanTime")]
        public string LastScanTime{ get; set; }

        /// <summary>
        /// Port risk
        /// </summary>
        [JsonProperty("PortRisk")]
        public ulong? PortRisk{ get; set; }

        /// <summary>
        /// Vulnerability risk
        /// </summary>
        [JsonProperty("VulnerabilityRisk")]
        public ulong? VulnerabilityRisk{ get; set; }

        /// <summary>
        /// Configuration risk
        /// </summary>
        [JsonProperty("ConfigurationRisk")]
        public ulong? ConfigurationRisk{ get; set; }

        /// <summary>
        /// Scan Task
        /// </summary>
        [JsonProperty("ScanTask")]
        public ulong? ScanTask{ get; set; }

        /// <summary>
        /// weak password
        /// </summary>
        [JsonProperty("WeakPassword")]
        public ulong? WeakPassword{ get; set; }

        /// <summary>
        /// Content risk
        /// </summary>
        [JsonProperty("WebContentRisk")]
        public ulong? WebContentRisk{ get; set; }

        /// <summary>
        /// Tag.
        /// </summary>
        [JsonProperty("Tag")]
        public Tag[] Tag{ get; set; }

        /// <summary>
        /// EIP Primary Key
        /// </summary>
        [JsonProperty("AddressId")]
        public string AddressId{ get; set; }

        /// <summary>
        /// Member ID information
        /// </summary>
        [JsonProperty("MemberId")]
        public string MemberId{ get; set; }

        /// <summary>
        /// risk service exposure
        /// </summary>
        [JsonProperty("RiskExposure")]
        public long? RiskExposure{ get; set; }

        /// <summary>
        /// New Asset or Not. 1: New
        /// </summary>
        [JsonProperty("IsNewAsset")]
        public ulong? IsNewAsset{ get; set; }

        /// <summary>
        /// Asset Authentication Status. 0-Pending Authentication; 1-Authentication Succeeded; 2-Authentication in Progress; 3+-Authentication Failed.
        /// </summary>
        [JsonProperty("VerifyStatus")]
        public long? VerifyStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "CFWStatus", this.CFWStatus);
            this.SetParamSimple(map, prefix + "AssetCreateTime", this.AssetCreateTime);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "PublicIpType", this.PublicIpType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "IsCore", this.IsCore);
            this.SetParamSimple(map, prefix + "IsCloud", this.IsCloud);
            this.SetParamSimple(map, prefix + "Attack", this.Attack);
            this.SetParamSimple(map, prefix + "Access", this.Access);
            this.SetParamSimple(map, prefix + "Intercept", this.Intercept);
            this.SetParamSimple(map, prefix + "InBandwidth", this.InBandwidth);
            this.SetParamSimple(map, prefix + "OutBandwidth", this.OutBandwidth);
            this.SetParamSimple(map, prefix + "InFlow", this.InFlow);
            this.SetParamSimple(map, prefix + "OutFlow", this.OutFlow);
            this.SetParamSimple(map, prefix + "LastScanTime", this.LastScanTime);
            this.SetParamSimple(map, prefix + "PortRisk", this.PortRisk);
            this.SetParamSimple(map, prefix + "VulnerabilityRisk", this.VulnerabilityRisk);
            this.SetParamSimple(map, prefix + "ConfigurationRisk", this.ConfigurationRisk);
            this.SetParamSimple(map, prefix + "ScanTask", this.ScanTask);
            this.SetParamSimple(map, prefix + "WeakPassword", this.WeakPassword);
            this.SetParamSimple(map, prefix + "WebContentRisk", this.WebContentRisk);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "AddressId", this.AddressId);
            this.SetParamSimple(map, prefix + "MemberId", this.MemberId);
            this.SetParamSimple(map, prefix + "RiskExposure", this.RiskExposure);
            this.SetParamSimple(map, prefix + "IsNewAsset", this.IsNewAsset);
            this.SetParamSimple(map, prefix + "VerifyStatus", this.VerifyStatus);
        }
    }
}

