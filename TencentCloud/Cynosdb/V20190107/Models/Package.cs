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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Package : AbstractModel
    {
        
        /// <summary>
        /// AppID
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// Unique ID of the resource package
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// Resource package name.
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// Resource package type
        /// CCU: compute resource package. DISK: storage resource package.
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// Resource package edition
        /// base - basic, common - general, enterprise - business
        /// </summary>
        [JsonProperty("PackageVersion")]
        public string PackageVersion{ get; set; }

        /// <summary>
        /// Region of resource package use
        /// china: common in the Chinese mainland; overseas: common in Hong Kong (China), Macao (China), Taiwan (China), and overseas regions
        /// </summary>
        [JsonProperty("PackageRegion")]
        public string PackageRegion{ get; set; }

        /// <summary>
        /// Resource package status
        /// creating
        /// using - in use;
        /// expired
        /// normal_finish: used up;
        /// apply_refund: Refund requested
        /// refund: refunded.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Total resource package quantity
        /// </summary>
        [JsonProperty("PackageTotalSpec")]
        public float? PackageTotalSpec{ get; set; }

        /// <summary>
        /// Used amount of the resource package
        /// </summary>
        [JsonProperty("PackageUsedSpec")]
        public float? PackageUsedSpec{ get; set; }

        /// <summary>
        /// Whether there is still inventory surplus
        /// </summary>
        [JsonProperty("HasQuota")]
        public bool? HasQuota{ get; set; }

        /// <summary>
        /// Bound instance information
        /// </summary>
        [JsonProperty("BindInstanceInfos")]
        public BindInstanceInfo[] BindInstanceInfos{ get; set; }

        /// <summary>
        /// Effective time: 2022-07-01 00:00:00
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Expiration time: 2022-08-01 00:00:00
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Resource package historic bound (unbound) instance information
        /// </summary>
        [JsonProperty("HistoryBindResourceInfos")]
        public BindInstanceInfo[] HistoryBindResourceInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "PackageVersion", this.PackageVersion);
            this.SetParamSimple(map, prefix + "PackageRegion", this.PackageRegion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PackageTotalSpec", this.PackageTotalSpec);
            this.SetParamSimple(map, prefix + "PackageUsedSpec", this.PackageUsedSpec);
            this.SetParamSimple(map, prefix + "HasQuota", this.HasQuota);
            this.SetParamArrayObj(map, prefix + "BindInstanceInfos.", this.BindInstanceInfos);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamArrayObj(map, prefix + "HistoryBindResourceInfos.", this.HistoryBindResourceInfos);
        }
    }
}

