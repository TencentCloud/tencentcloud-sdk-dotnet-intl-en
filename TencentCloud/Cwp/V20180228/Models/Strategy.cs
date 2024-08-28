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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Strategy : AbstractModel
    {
        
        /// <summary>
        /// Policy name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// Policy ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StrategyId")]
        public ulong? StrategyId{ get; set; }

        /// <summary>
        /// Total number of baseline detection items
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleCount")]
        public ulong? RuleCount{ get; set; }

        /// <summary>
        /// Number of Hosts
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HostCount")]
        public ulong? HostCount{ get; set; }

        /// <summary>
        /// Scan cycle
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanCycle")]
        public ulong? ScanCycle{ get; set; }

        /// <summary>
        /// Scan time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanAt")]
        public string ScanAt{ get; set; }

        /// <summary>
        /// Available or not?
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Enabled")]
        public ulong? Enabled{ get; set; }

        /// <summary>
        /// Pass rate
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PassRate")]
        public ulong? PassRate{ get; set; }

        /// <summary>
        /// Baseline ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CategoryIds")]
        public string CategoryIds{ get; set; }

        /// <summary>
        /// Whether a default policy
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsDefault")]
        public ulong? IsDefault{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
            this.SetParamSimple(map, prefix + "RuleCount", this.RuleCount);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamSimple(map, prefix + "ScanCycle", this.ScanCycle);
            this.SetParamSimple(map, prefix + "ScanAt", this.ScanAt);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "PassRate", this.PassRate);
            this.SetParamSimple(map, prefix + "CategoryIds", this.CategoryIds);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
        }
    }
}

