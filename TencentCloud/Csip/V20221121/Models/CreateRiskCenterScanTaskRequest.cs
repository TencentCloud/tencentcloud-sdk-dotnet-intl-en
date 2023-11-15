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

    public class CreateRiskCenterScanTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Task name
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// Values: `0` (Scan all); `1` (Scan specific assets); `2` (Scan all expect the specified assets); `3` (Custom assets). When `ScanAssetType=1/2`, `Assets` is required. When `ScanAssetType=3`, `SelfDefiningAssets` is required. 
        /// </summary>
        [JsonProperty("ScanAssetType")]
        public long? ScanAssetType{ get; set; }

        /// <summary>
        /// Project to scan: port/poc/weakpass/webcontent/configrisk/exposedserver
        /// </summary>
        [JsonProperty("ScanItem")]
        public string[] ScanItem{ get; set; }

        /// <summary>
        /// Task type. `0`: Scheduled task, `1`: Scan immediately; `2`: Scanned at the specified time; `3`: Custom. When ScanPlanType=0,2,3, `ScanPlanContent` is required.
        /// </summary>
        [JsonProperty("ScanPlanType")]
        public long? ScanPlanType{ get; set; }

        /// <summary>
        /// List of assets to scan
        /// </summary>
        [JsonProperty("Assets")]
        public TaskAssetObject[] Assets{ get; set; }

        /// <summary>
        /// Details of a scheduled scan task
        /// </summary>
        [JsonProperty("ScanPlanContent")]
        public string ScanPlanContent{ get; set; }

        /// <summary>
        /// IP/Domain name/URL
        /// </summary>
        [JsonProperty("SelfDefiningAssets")]
        public string[] SelfDefiningAssets{ get; set; }

        /// <summary>
        /// Request source. Values: `vss` (Vulnerability Scan Service), `csip` (Cloud Security Center). It defaults to `vss`.
        /// </summary>
        [JsonProperty("ScanFrom")]
        public string ScanFrom{ get; set; }

        /// <summary>
        /// Advanced settings
        /// </summary>
        [JsonProperty("TaskAdvanceCFG")]
        public TaskAdvanceCFG TaskAdvanceCFG{ get; set; }

        /// <summary>
        /// Scan task mode: `0` (Standard), `1` (Quick), `2` (Advanced). Default: `0`
        /// </summary>
        [JsonProperty("TaskMode")]
        public long? TaskMode{ get; set; }

        /// <summary>
        /// Asset tags
        /// </summary>
        [JsonProperty("Tags")]
        public AssetTag Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "ScanAssetType", this.ScanAssetType);
            this.SetParamArraySimple(map, prefix + "ScanItem.", this.ScanItem);
            this.SetParamSimple(map, prefix + "ScanPlanType", this.ScanPlanType);
            this.SetParamArrayObj(map, prefix + "Assets.", this.Assets);
            this.SetParamSimple(map, prefix + "ScanPlanContent", this.ScanPlanContent);
            this.SetParamArraySimple(map, prefix + "SelfDefiningAssets.", this.SelfDefiningAssets);
            this.SetParamSimple(map, prefix + "ScanFrom", this.ScanFrom);
            this.SetParamObj(map, prefix + "TaskAdvanceCFG.", this.TaskAdvanceCFG);
            this.SetParamSimple(map, prefix + "TaskMode", this.TaskMode);
            this.SetParamObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

