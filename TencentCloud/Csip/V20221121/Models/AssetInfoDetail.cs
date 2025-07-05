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

    public class AssetInfoDetail : AbstractModel
    {
        
        /// <summary>
        /// AppID of the user
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AppID")]
        public string AppID{ get; set; }

        /// <summary>
        /// CVE number
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CVEId")]
        public string CVEId{ get; set; }

        /// <summary>
        /// Whether the asset is scanned. Values: `0`: (default) Not scanned; `1`: Scanning; `2`: Scan completed; `3`: Error while scanning
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsScan")]
        public long? IsScan{ get; set; }

        /// <summary>
        /// Number of affected assets
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InfluenceAsset")]
        public long? InfluenceAsset{ get; set; }

        /// <summary>
        /// Number of not fixed assets
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NotRepairAsset")]
        public long? NotRepairAsset{ get; set; }

        /// <summary>
        /// Number of not protected assets
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NotProtectAsset")]
        public long? NotProtectAsset{ get; set; }

        /// <summary>
        /// Task ID
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Task progress in terms of percentage
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskPercent")]
        public long? TaskPercent{ get; set; }

        /// <summary>
        /// Task creation time
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskTime")]
        public long? TaskTime{ get; set; }

        /// <summary>
        /// Scan start time
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanTime")]
        public string ScanTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "CVEId", this.CVEId);
            this.SetParamSimple(map, prefix + "IsScan", this.IsScan);
            this.SetParamSimple(map, prefix + "InfluenceAsset", this.InfluenceAsset);
            this.SetParamSimple(map, prefix + "NotRepairAsset", this.NotRepairAsset);
            this.SetParamSimple(map, prefix + "NotProtectAsset", this.NotProtectAsset);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskPercent", this.TaskPercent);
            this.SetParamSimple(map, prefix + "TaskTime", this.TaskTime);
            this.SetParamSimple(map, prefix + "ScanTime", this.ScanTime);
        }
    }
}

