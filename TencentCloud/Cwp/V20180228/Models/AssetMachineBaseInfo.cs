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

    public class AssetMachineBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// Server QUUID
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Server UUID
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// Private IP address of server
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// Server name
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// Operating system name
        /// </summary>
        [JsonProperty("OsInfo")]
        public string OsInfo{ get; set; }

        /// <summary>
        /// CPU information
        /// </summary>
        [JsonProperty("Cpu")]
        public string Cpu{ get; set; }

        /// <summary>
        /// Memory capacity, in GB
        /// </summary>
        [JsonProperty("MemSize")]
        public ulong? MemSize{ get; set; }

        /// <summary>
        /// Memory utilization, in percentage
        /// </summary>
        [JsonProperty("MemLoad")]
        public string MemLoad{ get; set; }

        /// <summary>
        /// Hard disk capacity, in GB
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// Hard disk utilization, in percentage
        /// </summary>
        [JsonProperty("DiskLoad")]
        public string DiskLoad{ get; set; }

        /// <summary>
        /// Number of partitions
        /// </summary>
        [JsonProperty("PartitionCount")]
        public ulong? PartitionCount{ get; set; }

        /// <summary>
        /// Host public IP address
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// Business group ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// CPU count
        /// </summary>
        [JsonProperty("CpuSize")]
        public ulong? CpuSize{ get; set; }

        /// <summary>
        /// CPU utilization, in percentage
        /// </summary>
        [JsonProperty("CpuLoad")]
        public string CpuLoad{ get; set; }

        /// <summary>
        /// Tag
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tag")]
        public MachineTag[] Tag{ get; set; }

        /// <summary>
        /// Data update time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Whether it is newly added [0 - no;1 - yes]
        /// </summary>
        [JsonProperty("IsNew")]
        public long? IsNew{ get; set; }

        /// <summary>
        /// First collection time
        /// </summary>
        [JsonProperty("FirstTime")]
        public string FirstTime{ get; set; }

        /// <summary>
        /// Additional information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }

        /// <summary>
        /// CPU load readings (only valid for Linux systems)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CpuLoadNum")]
        public string CpuLoadNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "OsInfo", this.OsInfo);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "MemLoad", this.MemLoad);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "DiskLoad", this.DiskLoad);
            this.SetParamSimple(map, prefix + "PartitionCount", this.PartitionCount);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "CpuSize", this.CpuSize);
            this.SetParamSimple(map, prefix + "CpuLoad", this.CpuLoad);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "IsNew", this.IsNew);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
            this.SetParamSimple(map, prefix + "CpuLoadNum", this.CpuLoadNum);
        }
    }
}

