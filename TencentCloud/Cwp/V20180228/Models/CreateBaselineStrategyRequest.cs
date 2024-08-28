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

    public class CreateBaselineStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// Policy name
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// Check cycle, indicating the number of days between checks. Example: 2, indicating that the check is carried out every 2 days.
        /// </summary>
        [JsonProperty("ScanCycle")]
        public ulong? ScanCycle{ get; set; }

        /// <summary>
        /// Time for a periodic check. The scan task is issued at this time. Example: "22:00", indicating that the task is issued at 22:00.
        /// </summary>
        [JsonProperty("ScanAt")]
        public string ScanAt{ get; set; }

        /// <summary>
        /// Array of selected baseline IDs under this policy. Example: [1,3,5,7]
        /// </summary>
        [JsonProperty("CategoryIds")]
        public ulong?[] CategoryIds{ get; set; }

        /// <summary>
        /// Whether all servers are scanned. 1: yes; 0: no. If the value is 1, all Professional Edition hosts are scanned.
        /// </summary>
        [JsonProperty("IsGlobal")]
        public ulong? IsGlobal{ get; set; }

        /// <summary>
        /// Cloud host type:
        /// CVM: virtual machine
        /// BM: bare metal server
        /// ECM: edge computing machine
        /// LH: Lighthouse 
        /// Other: hybrid cloud machine
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// Host region. Example: "ap-guangzhou"
        /// </summary>
        [JsonProperty("RegionCode")]
        public string RegionCode{ get; set; }

        /// <summary>
        /// Host ID array. Example: ["quuid1","quuid2"]
        /// </summary>
        [JsonProperty("Quuids")]
        public string[] Quuids{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamSimple(map, prefix + "ScanCycle", this.ScanCycle);
            this.SetParamSimple(map, prefix + "ScanAt", this.ScanAt);
            this.SetParamArraySimple(map, prefix + "CategoryIds.", this.CategoryIds);
            this.SetParamSimple(map, prefix + "IsGlobal", this.IsGlobal);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "RegionCode", this.RegionCode);
            this.SetParamArraySimple(map, prefix + "Quuids.", this.Quuids);
        }
    }
}

