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

namespace TencentCloud.Yunjing.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Machine : AbstractModel
    {
        
        /// <summary>
        /// Server name.
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// Server OS.
        /// </summary>
        [JsonProperty("MachineOs")]
        public string MachineOs{ get; set; }

        /// <summary>
        /// Server status.
        /// <li>OFFLINE: offline</li>
        /// <li>ONLINE: online</li>
        /// <li>MACHINE_STOPPED: shut down</li>
        /// </summary>
        [JsonProperty("MachineStatus")]
        public string MachineStatus{ get; set; }

        /// <summary>
        /// CWP agent `Uuid`. If the agent is offline for a long time, a null character will be returned.
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// CVM or BM instance `Uuid`.
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Number of vulnerabilities.
        /// </summary>
        [JsonProperty("VulNum")]
        public long? VulNum{ get; set; }

        /// <summary>
        /// Server IP.
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// Whether the server has enabled CWP Pro.
        /// <li>true: yes</li>
        /// <li>false: no</li>
        /// </summary>
        [JsonProperty("IsProVersion")]
        public bool? IsProVersion{ get; set; }

        /// <summary>
        /// Public IP of server.
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// Server status.
        /// <li>POSTPAY: post-paid, i.e., pay-as-you-go </li>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// Number of trojans.
        /// </summary>
        [JsonProperty("MalwareNum")]
        public long? MalwareNum{ get; set; }

        /// <summary>
        /// Tag information
        /// </summary>
        [JsonProperty("Tag")]
        public MachineTag[] Tag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "MachineOs", this.MachineOs);
            this.SetParamSimple(map, prefix + "MachineStatus", this.MachineStatus);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "VulNum", this.VulNum);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "IsProVersion", this.IsProVersion);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "MalwareNum", this.MalwareNum);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
        }
    }
}

