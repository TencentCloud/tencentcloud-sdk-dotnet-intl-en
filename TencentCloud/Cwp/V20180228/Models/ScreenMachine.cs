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

    public class ScreenMachine : AbstractModel
    {
        
        /// <summary>
        /// Host name.
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// Host System.
        /// </summary>
        [JsonProperty("MachineOs")]
        public string MachineOs{ get; set; }

        /// <summary>
        /// Yunjing client UUID. If the client is offline for a long time, an empty string is returned.
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// Status of a host on the large screen. 0: agent not installed; 1: offline; 2: offline - risky; 3: offline - critical;
        /// 4: device installed - normal; 5: device installed - normal and of either Pro Edition or Ultimate Edition; 6: device installed - risky (network attack events > 0);
        /// 7: device installed - risky (network attack events > 0) and of either Pro Edition or Ultimate Edition; 8: device installed - critical (intrusion detection events > 0);
        /// 9: device installed - critical (intrusion detection events > 0) and of either Pro Edition or Ultimate Edition
        /// </summary>
        [JsonProperty("MachineStatus")]
        public ulong? MachineStatus{ get; set; }

        /// <summary>
        /// CVM or BM Machine Unique UUID.
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Number of vulnerabilities
        /// </summary>
        [JsonProperty("VulNum")]
        public long? VulNum{ get; set; }

        /// <summary>
        /// Host IP.
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// Public IP address of the host
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// Number of baseline risks
        /// </summary>
        [JsonProperty("BaselineNum")]
        public long? BaselineNum{ get; set; }

        /// <summary>
        /// Number of network risks
        /// </summary>
        [JsonProperty("CyberAttackNum")]
        public long? CyberAttackNum{ get; set; }

        /// <summary>
        /// Risk status
        /// <li>SAFE: Safe</li>
        /// <li>RISK: Risk</li>
        /// <li>UNKNOWN: Unknown</li>
        /// </summary>
        [JsonProperty("SecurityStatus")]
        public string SecurityStatus{ get; set; }

        /// <summary>
        /// Number of intrusion events
        /// </summary>
        [JsonProperty("InvasionNum")]
        public long? InvasionNum{ get; set; }

        /// <summary>
        /// Machine Zone Type. CVM - Cloud Virtual Machine; BM: Bare Metal; ECM: Edge Computing Machine; LH: Lightweight Application Server; Other: Hybrid Cloud Zone
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// CPU load status
        /// </summary>
        [JsonProperty("CpuLoad")]
        public string CpuLoad{ get; set; }

        /// <summary>
        /// Number of CPU cores
        /// </summary>
        [JsonProperty("CpuSize")]
        public float? CpuSize{ get; set; }

        /// <summary>
        /// Hard disk utilization (%)
        /// </summary>
        [JsonProperty("DiskLoad")]
        public string DiskLoad{ get; set; }

        /// <summary>
        /// Hard disk capacity (GB)
        /// </summary>
        [JsonProperty("DiskSize")]
        public float? DiskSize{ get; set; }

        /// <summary>
        /// Memory utilization (%)
        /// </summary>
        [JsonProperty("MemLoad")]
        public string MemLoad{ get; set; }

        /// <summary>
        /// Memory capacity (GB)
        /// </summary>
        [JsonProperty("MemSize")]
        public float? MemSize{ get; set; }

        /// <summary>
        /// Kernel version
        /// </summary>
        [JsonProperty("CoreVersion")]
        public string CoreVersion{ get; set; }

        /// <summary>
        /// Additional information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "MachineOs", this.MachineOs);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "MachineStatus", this.MachineStatus);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "VulNum", this.VulNum);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamSimple(map, prefix + "BaselineNum", this.BaselineNum);
            this.SetParamSimple(map, prefix + "CyberAttackNum", this.CyberAttackNum);
            this.SetParamSimple(map, prefix + "SecurityStatus", this.SecurityStatus);
            this.SetParamSimple(map, prefix + "InvasionNum", this.InvasionNum);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "CpuLoad", this.CpuLoad);
            this.SetParamSimple(map, prefix + "CpuSize", this.CpuSize);
            this.SetParamSimple(map, prefix + "DiskLoad", this.DiskLoad);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "MemLoad", this.MemLoad);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "CoreVersion", this.CoreVersion);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
        }
    }
}

