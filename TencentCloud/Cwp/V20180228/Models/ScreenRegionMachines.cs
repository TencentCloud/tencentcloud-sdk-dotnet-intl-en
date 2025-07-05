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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScreenRegionMachines : AbstractModel
    {
        
        /// <summary>
        /// All regions
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Region description in Chinese
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// Host list
        /// </summary>
        [JsonProperty("Machines")]
        public ScreenMachine[] Machines{ get; set; }

        /// <summary>
        /// Total number of hosts in this region
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// Number of risky hosts
        /// </summary>
        [JsonProperty("RiskCnt")]
        public ulong? RiskCnt{ get; set; }

        /// <summary>
        /// Number of potentially risky hosts
        /// </summary>
        [JsonProperty("AttackCnt")]
        public ulong? AttackCnt{ get; set; }

        /// <summary>
        /// Number of risk-free hosts
        /// </summary>
        [JsonProperty("SafetyCnt")]
        public ulong? SafetyCnt{ get; set; }

        /// <summary>
        /// Number of hosts in offline/uninstalled status
        /// </summary>
        [JsonProperty("UnAgentOfflineCnt")]
        public ulong? UnAgentOfflineCnt{ get; set; }

        /// <summary>
        /// Number of hosts that are omitted from displaying. When it is equal to 0, no hosts are omitted.
        /// </summary>
        [JsonProperty("IgnoreCnt")]
        public ulong? IgnoreCnt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamArrayObj(map, prefix + "Machines.", this.Machines);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "RiskCnt", this.RiskCnt);
            this.SetParamSimple(map, prefix + "AttackCnt", this.AttackCnt);
            this.SetParamSimple(map, prefix + "SafetyCnt", this.SafetyCnt);
            this.SetParamSimple(map, prefix + "UnAgentOfflineCnt", this.UnAgentOfflineCnt);
            this.SetParamSimple(map, prefix + "IgnoreCnt", this.IgnoreCnt);
        }
    }
}

