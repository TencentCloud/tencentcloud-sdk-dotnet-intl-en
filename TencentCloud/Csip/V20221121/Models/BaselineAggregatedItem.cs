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

    public class BaselineAggregatedItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Basic detection item information (including ID, name, risk level, category, etc.).</p>
        /// </summary>
        [JsonProperty("Item")]
        public BaselineItem Item{ get; set; }

        /// <summary>
        /// <p>Number of assets with a PASS result in the last scan for this detection item.</p>
        /// </summary>
        [JsonProperty("PassAssetCount")]
        public ulong? PassAssetCount{ get; set; }

        /// <summary>
        /// <p>Number of assets with result NOT_PASS in the last scan of this detection item.</p>
        /// </summary>
        [JsonProperty("NotPassAssetCount")]
        public ulong? NotPassAssetCount{ get; set; }

        /// <summary>
        /// <p>Number of assets with the last scan result of PASS, NOT_PASS, and CHECKING for this detection item.</p>
        /// </summary>
        [JsonProperty("TotalAssetCount")]
        public ulong? TotalAssetCount{ get; set; }

        /// <summary>
        /// <p>Pass rate of assets in the last scan of this detection item, unit: percentage (0–100).</p>
        /// </summary>
        [JsonProperty("PassRate")]
        public float? PassRate{ get; set; }

        /// <summary>
        /// <p>The last time the scan for this detection item was completed.</p>
        /// </summary>
        [JsonProperty("LatestCheckTime")]
        public string LatestCheckTime{ get; set; }

        /// <summary>
        /// <p>Status of the last scan result. Parameter Value:</p><ul><li>CHECKING: in-progress detection</li><li>PASS: passed</li><li>NOT_PASS: failed</li><li>CHECK_FAILED: detection failed</li><li>NOT_INVOLVED: not involved</li></ul>
        /// </summary>
        [JsonProperty("ResultStatus")]
        public string ResultStatus{ get; set; }

        /// <summary>
        /// <p>Tenant Appid list involved in the aggregation result.</p>
        /// </summary>
        [JsonProperty("Appid")]
        public ulong?[] Appid{ get; set; }

        /// <summary>
        /// <p>List of scan JobIDs involved in this aggregation result.</p>
        /// </summary>
        [JsonProperty("JobID")]
        public string[] JobID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Item.", this.Item);
            this.SetParamSimple(map, prefix + "PassAssetCount", this.PassAssetCount);
            this.SetParamSimple(map, prefix + "NotPassAssetCount", this.NotPassAssetCount);
            this.SetParamSimple(map, prefix + "TotalAssetCount", this.TotalAssetCount);
            this.SetParamSimple(map, prefix + "PassRate", this.PassRate);
            this.SetParamSimple(map, prefix + "LatestCheckTime", this.LatestCheckTime);
            this.SetParamSimple(map, prefix + "ResultStatus", this.ResultStatus);
            this.SetParamArraySimple(map, prefix + "Appid.", this.Appid);
            this.SetParamArraySimple(map, prefix + "JobID.", this.JobID);
        }
    }
}

