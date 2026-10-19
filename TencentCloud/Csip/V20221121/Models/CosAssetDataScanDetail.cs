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

    public class CosAssetDataScanDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>Recognition task status. 0: unrecognized; 1: in process; 2: terminated; 3: successful; 4: failed.</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>Recognition progress</p>
        /// </summary>
        [JsonProperty("Progress")]
        public float? Progress{ get; set; }

        /// <summary>
        /// <p>Last scan time.</p>
        /// </summary>
        [JsonProperty("LatestScanTime")]
        public ulong? LatestScanTime{ get; set; }

        /// <summary>
        /// <p>Recognition failed information.</p>
        /// </summary>
        [JsonProperty("ErrorInfo")]
        public string ErrorInfo{ get; set; }

        /// <summary>
        /// <p>Recognition result category details</p>
        /// </summary>
        [JsonProperty("CategoryDetails")]
        public CosIdentifyCategoryDetail[] CategoryDetails{ get; set; }

        /// <summary>
        /// <p>None.</p>
        /// </summary>
        [JsonProperty("RuleDetails")]
        public CosIdentifyRuleDetail[] RuleDetails{ get; set; }

        /// <summary>
        /// <p>None.</p>
        /// </summary>
        [JsonProperty("LevelDetails")]
        public CosIdentifyLevelDetail[] LevelDetails{ get; set; }

        /// <summary>
        /// <p>Whether a full scan has been initiated</p>
        /// </summary>
        [JsonProperty("IsFullScanned")]
        public bool? IsFullScanned{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "LatestScanTime", this.LatestScanTime);
            this.SetParamSimple(map, prefix + "ErrorInfo", this.ErrorInfo);
            this.SetParamArrayObj(map, prefix + "CategoryDetails.", this.CategoryDetails);
            this.SetParamArrayObj(map, prefix + "RuleDetails.", this.RuleDetails);
            this.SetParamArrayObj(map, prefix + "LevelDetails.", this.LevelDetails);
            this.SetParamSimple(map, prefix + "IsFullScanned", this.IsFullScanned);
        }
    }
}

