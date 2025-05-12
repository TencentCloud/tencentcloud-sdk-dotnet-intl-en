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
        /// The unique ID of the resource package.
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// Resource package name.
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// Specifies the resource package type.
        /// CCU: compute resource package. DISK: storage resource package.
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// Resource package region of use.
        /// China - common in the chinese mainland. overseas - universally applicable in hong kong (china), macao (china), taiwan (china), and overseas.
        /// </summary>
        [JsonProperty("PackageRegion")]
        public string PackageRegion{ get; set; }

        /// <summary>
        /// Specifies the status of the resource package.
        /// creating - indicates that it is in the process of being created.
        /// {using} specifies that it is in use.
        /// expired-expired;.
        /// normal_finish - specifies that it is used up.
        /// `Apply_refund`: apply for a refund.
        /// Specifies that the fee has been refunded.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Total resource package quantity.
        /// </summary>
        [JsonProperty("PackageTotalSpec")]
        public float? PackageTotalSpec{ get; set; }

        /// <summary>
        /// Used amount of resource package.
        /// </summary>
        [JsonProperty("PackageUsedSpec")]
        public float? PackageUsedSpec{ get; set; }

        /// <summary>
        /// Whether there is inventory surplus.
        /// </summary>
        [JsonProperty("HasQuota")]
        public bool? HasQuota{ get; set; }

        /// <summary>
        /// Specifies the bound instance information.
        /// </summary>
        [JsonProperty("BindInstanceInfos")]
        public BindInstanceInfo[] BindInstanceInfos{ get; set; }

        /// <summary>
        /// Specifies the effective time: 2022-07-01 00:00:00.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Specifies the expiration time: 2022-08-01 00:00:00.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Information of the instance historically bound (now unbound) to the resource pack.
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

