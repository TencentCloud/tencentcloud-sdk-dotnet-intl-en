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

    public class RansomDefenseStrategy : AbstractModel
    {
        
        /// <summary>
        /// Policy ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// Operating UIN
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Policy name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Policy Remarks
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Enabling Status: 0 Disabled, 1 Enabled.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Whether it takes effect for all hosts.
        /// </summary>
        [JsonProperty("IsAll")]
        public ulong? IsAll{ get; set; }

        /// <summary>
        /// Includes directories, separated by semicolons (;).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IncludeDir")]
        public string IncludeDir{ get; set; }

        /// <summary>
        /// Includes directories, separated by semicolons (;).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExcludeDir")]
        public string ExcludeDir{ get; set; }

        /// <summary>
        /// Backup pattern: 0 weekly, 1 daily.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BackupType")]
        public ulong? BackupType{ get; set; }

        /// <summary>
        /// Backup days in a week (1-7): 1; 2; 3; 4.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Weekday")]
        public string Weekday{ get; set; }

        /// <summary>
        /// Backup Execution Time Point (0-23): 11:00; 12:00
        /// </summary>
        [JsonProperty("Hour")]
        public string Hour{ get; set; }

        /// <summary>
        /// Storage Days, 0 for Permanent
        /// </summary>
        [JsonProperty("SaveDay")]
        public ulong? SaveDay{ get; set; }

        /// <summary>
        /// Creation time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last modification time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// Number of Bound Machines
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MachineCount")]
        public ulong? MachineCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsAll", this.IsAll);
            this.SetParamSimple(map, prefix + "IncludeDir", this.IncludeDir);
            this.SetParamSimple(map, prefix + "ExcludeDir", this.ExcludeDir);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamSimple(map, prefix + "Weekday", this.Weekday);
            this.SetParamSimple(map, prefix + "Hour", this.Hour);
            this.SetParamSimple(map, prefix + "SaveDay", this.SaveDay);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "MachineCount", this.MachineCount);
        }
    }
}

