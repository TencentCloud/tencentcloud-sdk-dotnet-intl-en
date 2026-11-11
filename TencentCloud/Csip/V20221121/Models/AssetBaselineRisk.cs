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

    public class AssetBaselineRisk : AbstractModel
    {
        
        /// <summary>
        /// <p>Unique identifier of a risk record.</p>
        /// </summary>
        [JsonProperty("RiskID")]
        public string RiskID{ get; set; }

        /// <summary>
        /// <p>Detection item details.</p>
        /// </summary>
        [JsonProperty("Item")]
        public BaselineItem Item{ get; set; }

        /// <summary>
        /// <p>Most recent detection time (ISO 8601 format).</p>
        /// </summary>
        [JsonProperty("LatestCheckTime")]
        public string LatestCheckTime{ get; set; }

        /// <summary>
        /// <p>Detection result status. Parameter values:</p><ul><li>NOT_PASS: failed</li><li>PASS: passed</li><li>CHECKING: in-progress detection</li></ul><p></p>
        /// </summary>
        [JsonProperty("ResultStatus")]
        public string ResultStatus{ get; set; }

        /// <summary>
        /// <p>Brief information of the associated baseline policy.</p>
        /// </summary>
        [JsonProperty("PolicyInfo")]
        public BaselinePolicyBrief PolicyInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RiskID", this.RiskID);
            this.SetParamObj(map, prefix + "Item.", this.Item);
            this.SetParamSimple(map, prefix + "LatestCheckTime", this.LatestCheckTime);
            this.SetParamSimple(map, prefix + "ResultStatus", this.ResultStatus);
            this.SetParamObj(map, prefix + "PolicyInfo.", this.PolicyInfo);
        }
    }
}

