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

    public class DomainAssetVO : AbstractModel
    {
        
        /// <summary>
        /// Asset ID
        /// </summary>
        [JsonProperty("AssetId")]
        public string[] AssetId{ get; set; }

        /// <summary>
        /// Asset Name
        /// </summary>
        [JsonProperty("AssetName")]
        public string[] AssetName{ get; set; }

        /// <summary>
        /// Asset type
        /// </summary>
        [JsonProperty("AssetType")]
        public string[] AssetType{ get; set; }

        /// <summary>
        /// Region.
        /// </summary>
        [JsonProperty("Region")]
        public string[] Region{ get; set; }

        /// <summary>
        /// WAF Status
        /// </summary>
        [JsonProperty("WAFStatus")]
        public ulong? WAFStatus{ get; set; }

        /// <summary>
        /// Asset Creation Time
        /// </summary>
        [JsonProperty("AssetCreateTime")]
        public string AssetCreateTime{ get; set; }

        /// <summary>
        /// Appid
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// Account ID
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Account name
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// Core or Not
        /// </summary>
        [JsonProperty("IsCore")]
        public ulong? IsCore{ get; set; }

        /// <summary>
        /// Whether it is on-cloud asset.
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
        /// Inbound peak bandwidth
        /// </summary>
        [JsonProperty("InBandwidth")]
        public string InBandwidth{ get; set; }

        /// <summary>
        /// Outbound peak bandwidth
        /// </summary>
        [JsonProperty("OutBandwidth")]
        public string OutBandwidth{ get; set; }

        /// <summary>
        /// Cumulative Inbound Traffic
        /// </summary>
        [JsonProperty("InFlow")]
        public string InFlow{ get; set; }

        /// <summary>
        /// Cumulative Outbound Traffic
        /// </summary>
        [JsonProperty("OutFlow")]
        public string OutFlow{ get; set; }

        /// <summary>
        /// Last scan time
        /// </summary>
        [JsonProperty("LastScanTime")]
        public string LastScanTime{ get; set; }

        /// <summary>
        /// port risk
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
        /// Domain
        /// </summary>
        [JsonProperty("SubDomain")]
        public string SubDomain{ get; set; }

        /// <summary>
        /// Resolve IP
        /// </summary>
        [JsonProperty("SeverIp")]
        public string[] SeverIp{ get; set; }

        /// <summary>
        /// Number of Bot Attacks
        /// </summary>
        [JsonProperty("BotCount")]
        public ulong? BotCount{ get; set; }

        /// <summary>
        /// Weak password risk
        /// </summary>
        [JsonProperty("WeakPassword")]
        public ulong? WeakPassword{ get; set; }

        /// <summary>
        /// Content risk
        /// </summary>
        [JsonProperty("WebContentRisk")]
        public ulong? WebContentRisk{ get; set; }

        /// <summary>
        /// tag
        /// </summary>
        [JsonProperty("Tag")]
        public Tag[] Tag{ get; set; }

        /// <summary>
        /// Associated instance type
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// Member ID information
        /// </summary>
        [JsonProperty("MemberId")]
        public string MemberId{ get; set; }

        /// <summary>
        /// CC Attack
        /// </summary>
        [JsonProperty("CCAttack")]
        public long? CCAttack{ get; set; }

        /// <summary>
        /// Web Attack
        /// </summary>
        [JsonProperty("WebAttack")]
        public long? WebAttack{ get; set; }

        /// <summary>
        /// Number of Risk Service Exposures
        /// </summary>
        [JsonProperty("ServiceRisk")]
        public ulong? ServiceRisk{ get; set; }

        /// <summary>
        /// New Asset or Not. 1: New
        /// </summary>
        [JsonProperty("IsNewAsset")]
        public ulong? IsNewAsset{ get; set; }

        /// <summary>
        /// Random Layer-3 Domain of Assets to Be Recognized
        /// </summary>
        [JsonProperty("VerifyDomain")]
        public string VerifyDomain{ get; set; }

        /// <summary>
        /// TXT Record Content of Pending Confirmation Assets
        /// </summary>
        [JsonProperty("VerifyTXTRecord")]
        public string VerifyTXTRecord{ get; set; }

        /// <summary>
        /// Authentication Status of Assets Pending Recognition. 0: Pending Authentication; 1: Authentication Succeeded; 2: Authentication in Progress; 3: TXT Authentication Failed; 4: Manual Authentication Failed.
        /// </summary>
        [JsonProperty("VerifyStatus")]
        public long? VerifyStatus{ get; set; }

        /// <summary>
        /// Bot Access Count
        /// </summary>
        [JsonProperty("BotAccessCount")]
        public long? BotAccessCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AssetId.", this.AssetId);
            this.SetParamArraySimple(map, prefix + "AssetName.", this.AssetName);
            this.SetParamArraySimple(map, prefix + "AssetType.", this.AssetType);
            this.SetParamArraySimple(map, prefix + "Region.", this.Region);
            this.SetParamSimple(map, prefix + "WAFStatus", this.WAFStatus);
            this.SetParamSimple(map, prefix + "AssetCreateTime", this.AssetCreateTime);
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
            this.SetParamSimple(map, prefix + "SubDomain", this.SubDomain);
            this.SetParamArraySimple(map, prefix + "SeverIp.", this.SeverIp);
            this.SetParamSimple(map, prefix + "BotCount", this.BotCount);
            this.SetParamSimple(map, prefix + "WeakPassword", this.WeakPassword);
            this.SetParamSimple(map, prefix + "WebContentRisk", this.WebContentRisk);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "MemberId", this.MemberId);
            this.SetParamSimple(map, prefix + "CCAttack", this.CCAttack);
            this.SetParamSimple(map, prefix + "WebAttack", this.WebAttack);
            this.SetParamSimple(map, prefix + "ServiceRisk", this.ServiceRisk);
            this.SetParamSimple(map, prefix + "IsNewAsset", this.IsNewAsset);
            this.SetParamSimple(map, prefix + "VerifyDomain", this.VerifyDomain);
            this.SetParamSimple(map, prefix + "VerifyTXTRecord", this.VerifyTXTRecord);
            this.SetParamSimple(map, prefix + "VerifyStatus", this.VerifyStatus);
            this.SetParamSimple(map, prefix + "BotAccessCount", this.BotAccessCount);
        }
    }
}

