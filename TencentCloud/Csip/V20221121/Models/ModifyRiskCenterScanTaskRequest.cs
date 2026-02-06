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

    public class ModifyRiskCenterScanTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Task name.
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 0: Full Scan; 1: Specified Asset Scan; 2: Excluded Asset Scan; 3: Manual Entry Scan. 1 and 2 require the Assets field; 3 requires SelfDefiningAssets.
        /// </summary>
        [JsonProperty("ScanAssetType")]
        public long? ScanAssetType{ get; set; }

        /// <summary>
        /// Scan items. port/poc/weakpass/webcontent/configrisk
        /// </summary>
        [JsonProperty("ScanItem")]
        public string[] ScanItem{ get; set; }

        /// <summary>
        /// 0: Periodic Task; 1: Scan Now; 2: Scheduled Scan; 3: Custom. If 0, 2, 3, ScanPlanContent is required.
        /// </summary>
        [JsonProperty("ScanPlanType")]
        public long? ScanPlanType{ get; set; }

        /// <summary>
        /// Task ID to be Modified
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Group Account Member ID
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// Scanned Asset Information List
        /// </summary>
        [JsonProperty("Assets")]
        public TaskAssetObject[] Assets{ get; set; }

        /// <summary>
        /// Scan Plan Details
        /// </summary>
        [JsonProperty("ScanPlanContent")]
        public string ScanPlanContent{ get; set; }

        /// <summary>
        /// IP/Domain/URL Array
        /// </summary>
        [JsonProperty("SelfDefiningAssets")]
        public string[] SelfDefiningAssets{ get; set; }

        /// <summary>
        /// Advanced configuration.
        /// </summary>
        [JsonProperty("TaskAdvanceCFG")]
        public TaskAdvanceCFG TaskAdvanceCFG{ get; set; }

        /// <summary>
        /// Checkup Mode. 0: Standard Mode; 1: Quick Mode; 2: Advanced Mode. Standard Mode by default.
        /// </summary>
        [JsonProperty("TaskMode")]
        public long? TaskMode{ get; set; }

        /// <summary>
        /// Task complete callback webhook url.
        /// </summary>
        [JsonProperty("FinishWebHook")]
        public string FinishWebHook{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "ScanAssetType", this.ScanAssetType);
            this.SetParamArraySimple(map, prefix + "ScanItem.", this.ScanItem);
            this.SetParamSimple(map, prefix + "ScanPlanType", this.ScanPlanType);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArrayObj(map, prefix + "Assets.", this.Assets);
            this.SetParamSimple(map, prefix + "ScanPlanContent", this.ScanPlanContent);
            this.SetParamArraySimple(map, prefix + "SelfDefiningAssets.", this.SelfDefiningAssets);
            this.SetParamObj(map, prefix + "TaskAdvanceCFG.", this.TaskAdvanceCFG);
            this.SetParamSimple(map, prefix + "TaskMode", this.TaskMode);
            this.SetParamSimple(map, prefix + "FinishWebHook", this.FinishWebHook);
        }
    }
}

