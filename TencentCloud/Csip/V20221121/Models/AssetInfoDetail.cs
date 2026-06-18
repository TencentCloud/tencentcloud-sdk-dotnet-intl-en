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
        /// User appid.
        /// </summary>
        [JsonProperty("AppID")]
        public string AppID{ get; set; }

        /// <summary>
        /// CVE id
        /// </summary>
        [JsonProperty("CVEId")]
        public string CVEId{ get; set; }

        /// <summary>
        /// Scan Status. 0-Not Scanned by Default; 1-Scanning; 2-Scan Completed; 3-Scan Error.
        /// </summary>
        [JsonProperty("IsScan")]
        public long? IsScan{ get; set; }

        /// <summary>
        /// Number of Affected Assets
        /// </summary>
        [JsonProperty("InfluenceAsset")]
        public long? InfluenceAsset{ get; set; }

        /// <summary>
        /// Number of Unfixed Assets
        /// </summary>
        [JsonProperty("NotRepairAsset")]
        public long? NotRepairAsset{ get; set; }

        /// <summary>
        /// Unprotected Asset Count
        /// </summary>
        [JsonProperty("NotProtectAsset")]
        public long? NotProtectAsset{ get; set; }

        /// <summary>
        /// Task ID.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Task Percentage
        /// </summary>
        [JsonProperty("TaskPercent")]
        public long? TaskPercent{ get; set; }

        /// <summary>
        /// Task Time
        /// </summary>
        [JsonProperty("TaskTime")]
        public long? TaskTime{ get; set; }

        /// <summary>
        /// Scan time
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

