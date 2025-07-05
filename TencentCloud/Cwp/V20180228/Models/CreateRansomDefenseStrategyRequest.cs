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

    public class CreateRansomDefenseStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// Policy name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Scheduled snapshot execution time (0-23): 01:00; 23:00.
        /// </summary>
        [JsonProperty("Hour")]
        public string Hour{ get; set; }

        /// <summary>
        /// Policy ID: Modify the policy when filling in the ID. Otherwise, add a new policy.
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// Policy Remarks
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Whether to enable: 0 Off, 1 On.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Apply to all machines or not. 0: No; 1: Yes
        /// </summary>
        [JsonProperty("IsAll")]
        public ulong? IsAll{ get; set; }

        /// <summary>
        /// Include directories, separated by semicolons (;).
        /// </summary>
        [JsonProperty("IncludeDir")]
        public string IncludeDir{ get; set; }

        /// <summary>
        /// Exclude directories, separated by semicolons (;).
        /// </summary>
        [JsonProperty("ExcludeDir")]
        public string ExcludeDir{ get; set; }

        /// <summary>
        /// Backup pattern: 0 weekly, 1 daily.
        /// </summary>
        [JsonProperty("BackupType")]
        public ulong? BackupType{ get; set; }

        /// <summary>
        /// Scheduled task execution days in a week (1-7): 1; 2; 7.
        /// </summary>
        [JsonProperty("Weekday")]
        public string Weekday{ get; set; }

        /// <summary>
        /// Retention Period: 0 Permanent.
        /// </summary>
        [JsonProperty("SaveDay")]
        public ulong? SaveDay{ get; set; }

        /// <summary>
        /// Bound Host List
        /// </summary>
        [JsonProperty("Machines")]
        public RansomDefenseStrategyMachineInfo[] Machines{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Hour", this.Hour);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsAll", this.IsAll);
            this.SetParamSimple(map, prefix + "IncludeDir", this.IncludeDir);
            this.SetParamSimple(map, prefix + "ExcludeDir", this.ExcludeDir);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamSimple(map, prefix + "Weekday", this.Weekday);
            this.SetParamSimple(map, prefix + "SaveDay", this.SaveDay);
            this.SetParamArrayObj(map, prefix + "Machines.", this.Machines);
        }
    }
}

