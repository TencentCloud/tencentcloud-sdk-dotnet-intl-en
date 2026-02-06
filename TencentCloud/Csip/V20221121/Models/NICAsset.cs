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

    public class NICAsset : AbstractModel
    {
        
        /// <summary>
        /// appid
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Asset ID.
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// Asset name.
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// Asset type.
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// VPC IP
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// Public IP address
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// Region.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// VPC id.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// VPC Name
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// Tag.
        /// </summary>
        [JsonProperty("Tag")]
        public Tag[] Tag{ get; set; }

        /// <summary>
        /// Outbound peak bandwidth.
        /// </summary>
        [JsonProperty("OutboundPeakBandwidth")]
        public string OutboundPeakBandwidth{ get; set; }

        /// <summary>
        /// Inbound peak bandwidth.
        /// </summary>
        [JsonProperty("InboundPeakBandwidth")]
        public string InboundPeakBandwidth{ get; set; }

        /// <summary>
        /// Cumulative Outbound Traffic
        /// </summary>
        [JsonProperty("OutboundCumulativeFlow")]
        public string OutboundCumulativeFlow{ get; set; }

        /// <summary>
        /// Cumulative Inbound Traffic
        /// </summary>
        [JsonProperty("InboundCumulativeFlow")]
        public string InboundCumulativeFlow{ get; set; }

        /// <summary>
        /// Network attack.
        /// </summary>
        [JsonProperty("NetworkAttack")]
        public long? NetworkAttack{ get; set; }

        /// <summary>
        /// Expose ports.
        /// </summary>
        [JsonProperty("ExposedPort")]
        public long? ExposedPort{ get; set; }

        /// <summary>
        /// Exposed vulnerability.
        /// </summary>
        [JsonProperty("ExposedVUL")]
        public long? ExposedVUL{ get; set; }

        /// <summary>
        /// Configuration risk.
        /// </summary>
        [JsonProperty("ConfigureRisk")]
        public long? ConfigureRisk{ get; set; }

        /// <summary>
        /// Creation time.
        /// 
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Number of tasks.
        /// </summary>
        [JsonProperty("ScanTask")]
        public long? ScanTask{ get; set; }

        /// <summary>
        /// Last scan time
        /// </summary>
        [JsonProperty("LastScanTime")]
        public string LastScanTime{ get; set; }

        /// <summary>
        /// Nickname.
        /// </summary>
        [JsonProperty("Nick")]
        public string Nick{ get; set; }

        /// <summary>
        /// Core or Not
        /// </summary>
        [JsonProperty("IsCore")]
        public ulong? IsCore{ get; set; }

        /// <summary>
        /// New Asset or Not. 1: New
        /// </summary>
        [JsonProperty("IsNewAsset")]
        public ulong? IsNewAsset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "OutboundPeakBandwidth", this.OutboundPeakBandwidth);
            this.SetParamSimple(map, prefix + "InboundPeakBandwidth", this.InboundPeakBandwidth);
            this.SetParamSimple(map, prefix + "OutboundCumulativeFlow", this.OutboundCumulativeFlow);
            this.SetParamSimple(map, prefix + "InboundCumulativeFlow", this.InboundCumulativeFlow);
            this.SetParamSimple(map, prefix + "NetworkAttack", this.NetworkAttack);
            this.SetParamSimple(map, prefix + "ExposedPort", this.ExposedPort);
            this.SetParamSimple(map, prefix + "ExposedVUL", this.ExposedVUL);
            this.SetParamSimple(map, prefix + "ConfigureRisk", this.ConfigureRisk);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ScanTask", this.ScanTask);
            this.SetParamSimple(map, prefix + "LastScanTime", this.LastScanTime);
            this.SetParamSimple(map, prefix + "Nick", this.Nick);
            this.SetParamSimple(map, prefix + "IsCore", this.IsCore);
            this.SetParamSimple(map, prefix + "IsNewAsset", this.IsNewAsset);
        }
    }
}

