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
        /// AppID Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// The unique ID of a resource pack Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// Resource pack name Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// Resource pack type. Valid values: `CCU` (compute resource pack), `DISK` (storage resource pack). Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// Region of the resource pack. Valid values: `China` (Chinese mainland), `overseas` (outside Chinese mainland). Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PackageRegion")]
        public string PackageRegion{ get; set; }

        /// <summary>
        /// Resource pack status. Valid values: `creating`, `using`, `expired`, `normal_finish` (used up), `apply_refund` (requesting a refund), `refund` (refunded). 
        /// Note:  This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Total number of resource packs Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PackageTotalSpec")]
        public float? PackageTotalSpec{ get; set; }

        /// <summary>
        /// Consumed usage of resource packs Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PackageUsedSpec")]
        public float? PackageUsedSpec{ get; set; }

        /// <summary>
        /// Remaining usage of resource packs Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HasQuota")]
        public bool? HasQuota{ get; set; }

        /// <summary>
        /// Information of the instance bound Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BindInstanceInfos")]
        public BindInstanceInfo[] BindInstanceInfos{ get; set; }

        /// <summary>
        /// Validity time:  2022-07-01 00:00:00 Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Validity time:  2022-08-01 00:00:00 Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }


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
        }
    }
}

