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

    public class RansomDefenseStrategyMachineBackupInfo : AbstractModel
    {
        
        /// <summary>
        /// Host UUID
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// Host QUUID
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Host name
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// Host Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Private IP address
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// Public IP address
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// Cloud Tag
        /// </summary>
        [JsonProperty("CloudTags")]
        public Tag[] CloudTags{ get; set; }

        /// <summary>
        /// Availability zone information
        /// </summary>
        [JsonProperty("RegionInfo")]
        public RegionInfo RegionInfo{ get; set; }

        /// <summary>
        /// Host security tag
        /// </summary>
        [JsonProperty("Tag")]
        public MachineTag[] Tag{ get; set; }

        /// <summary>
        /// Protection status: 0 Disabled, 1 Enabled.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Policy ID. 0 indicates no binding to any policy.
        /// </summary>
        [JsonProperty("StrategyId")]
        public ulong? StrategyId{ get; set; }

        /// <summary>
        /// Hard disk information, all hard disks take effect when left blank:
        /// Separate diskId1|diskName1;diskId2|diskName2
        /// </summary>
        [JsonProperty("DiskInfo")]
        public string DiskInfo{ get; set; }

        /// <summary>
        /// Policy name
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// Number of Backups
        /// </summary>
        [JsonProperty("BackupCount")]
        public ulong? BackupCount{ get; set; }

        /// <summary>
        /// Latest Backup Status: 0 - Backing Up, 1 - Normal, 2 - Failed, 9 - No Backup Yet
        /// </summary>
        [JsonProperty("LastBackupStatus")]
        public ulong? LastBackupStatus{ get; set; }

        /// <summary>
        /// Reason for the Last Backup Failure
        /// </summary>
        [JsonProperty("LastBackupMessage")]
        public string LastBackupMessage{ get; set; }

        /// <summary>
        /// Last Backup Time
        /// </summary>
        [JsonProperty("LastBackupTime")]
        public string LastBackupTime{ get; set; }

        /// <summary>
        /// Latest Rollback Progress Percentage
        /// </summary>
        [JsonProperty("RollBackPercent")]
        public ulong? RollBackPercent{ get; set; }

        /// <summary>
        /// Latest Rollback Status: 0 - In Progress, 1 - Succeeded, 2 - Failed
        /// </summary>
        [JsonProperty("RollBackStatus")]
        public ulong? RollBackStatus{ get; set; }

        /// <summary>
        /// Backup Success Count
        /// </summary>
        [JsonProperty("BackupSuccessCount")]
        public ulong? BackupSuccessCount{ get; set; }

        /// <summary>
        /// Version information: 0-Basic version, 1-Pro edition, 2-Flagship edition, 3-Lightweight edition
        /// </summary>
        [JsonProperty("HostVersion")]
        public ulong? HostVersion{ get; set; }

        /// <summary>
        /// Machine Zone Type. CVM - Cloud Virtual Machine; BM: Bare Metal; ECM: Edge Computing Machine; LH: Lightweight Application Server; Other: Hybrid Cloud Zone
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamArrayObj(map, prefix + "CloudTags.", this.CloudTags);
            this.SetParamObj(map, prefix + "RegionInfo.", this.RegionInfo);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
            this.SetParamSimple(map, prefix + "DiskInfo", this.DiskInfo);
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamSimple(map, prefix + "BackupCount", this.BackupCount);
            this.SetParamSimple(map, prefix + "LastBackupStatus", this.LastBackupStatus);
            this.SetParamSimple(map, prefix + "LastBackupMessage", this.LastBackupMessage);
            this.SetParamSimple(map, prefix + "LastBackupTime", this.LastBackupTime);
            this.SetParamSimple(map, prefix + "RollBackPercent", this.RollBackPercent);
            this.SetParamSimple(map, prefix + "RollBackStatus", this.RollBackStatus);
            this.SetParamSimple(map, prefix + "BackupSuccessCount", this.BackupSuccessCount);
            this.SetParamSimple(map, prefix + "HostVersion", this.HostVersion);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
        }
    }
}

