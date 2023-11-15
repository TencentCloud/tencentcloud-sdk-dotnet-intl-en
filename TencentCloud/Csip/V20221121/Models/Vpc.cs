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

    public class Vpc : AbstractModel
    {
        
        /// <summary>
        /// Subnet (32-bit mask)
        /// </summary>
        [JsonProperty("Subnet")]
        public ulong? Subnet{ get; set; }

        /// <summary>
        /// Connected VPC (32-bit mask)
        /// </summary>
        [JsonProperty("ConnectedVpc")]
        public ulong? ConnectedVpc{ get; set; }

        /// <summary>
        /// Asset ID
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// Region
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// CVM (only 32-bit)
        /// </summary>
        [JsonProperty("CVM")]
        public ulong? CVM{ get; set; }

        /// <summary>
        /// Tags
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tag")]
        public Tag[] Tag{ get; set; }

        /// <summary>
        /// DNS domain
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DNS")]
        public string[] DNS{ get; set; }

        /// <summary>
        /// Asset name
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// CIDR block
        /// </summary>
        [JsonProperty("CIDR")]
        public string CIDR{ get; set; }

        /// <summary>
        /// Asset creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// appid
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// UIN
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// User name
        /// </summary>
        [JsonProperty("Nick")]
        public string Nick{ get; set; }

        /// <summary>
        /// Whether it's a newly-added asset. Values: `1` (Yes), `0` (No)
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsNewAsset")]
        public ulong? IsNewAsset{ get; set; }

        /// <summary>
        /// Whether it's a critical asset. `1`: Yes; `2`: No
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsCore")]
        public ulong? IsCore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Subnet", this.Subnet);
            this.SetParamSimple(map, prefix + "ConnectedVpc", this.ConnectedVpc);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "CVM", this.CVM);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamArraySimple(map, prefix + "DNS.", this.DNS);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "CIDR", this.CIDR);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Nick", this.Nick);
            this.SetParamSimple(map, prefix + "IsNewAsset", this.IsNewAsset);
            this.SetParamSimple(map, prefix + "IsCore", this.IsCore);
        }
    }
}

