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

    public class DspmAssetCount : AbstractModel
    {
        
        /// <summary>
        /// Number of assets
        /// </summary>
        [JsonProperty("AssetCount")]
        public long? AssetCount{ get; set; }

        /// <summary>
        /// Number of assets with dangerous risks
        /// </summary>
        [JsonProperty("DangerRiskCount")]
        public long? DangerRiskCount{ get; set; }

        /// <summary>
        /// Number of assets with low risk
        /// </summary>
        [JsonProperty("LowRiskCount")]
        public long? LowRiskCount{ get; set; }

        /// <summary>
        /// Number of instances with pending risks
        /// </summary>
        [JsonProperty("RiskAssetCount")]
        public long? RiskAssetCount{ get; set; }

        /// <summary>
        /// Number of instances with pending alarms
        /// </summary>
        [JsonProperty("AlarmAssetCount")]
        public long? AlarmAssetCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetCount", this.AssetCount);
            this.SetParamSimple(map, prefix + "DangerRiskCount", this.DangerRiskCount);
            this.SetParamSimple(map, prefix + "LowRiskCount", this.LowRiskCount);
            this.SetParamSimple(map, prefix + "RiskAssetCount", this.RiskAssetCount);
            this.SetParamSimple(map, prefix + "AlarmAssetCount", this.AlarmAssetCount);
        }
    }
}

