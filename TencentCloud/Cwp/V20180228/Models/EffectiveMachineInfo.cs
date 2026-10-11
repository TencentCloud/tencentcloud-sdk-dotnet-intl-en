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

    public class EffectiveMachineInfo : AbstractModel
    {
        
        /// <summary>
        /// Machine name
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// Public ip address of the machine
        /// </summary>
        [JsonProperty("MachinePublicIp")]
        public string MachinePublicIp{ get; set; }

        /// <summary>
        /// Private ip of the machine
        /// </summary>
        [JsonProperty("MachinePrivateIp")]
        public string MachinePrivateIp{ get; set; }

        /// <summary>
        /// Machine Tag
        /// </summary>
        [JsonProperty("MachineTag")]
        public MachineTag[] MachineTag{ get; set; }

        /// <summary>
        /// Machine Quuid
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Host UUID
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// Kernel version number
        /// </summary>
        [JsonProperty("KernelVersion")]
        public string KernelVersion{ get; set; }

        /// <summary>
        /// Online status. OFFLINE, ONLINE.
        /// </summary>
        [JsonProperty("MachineStatus")]
        public string MachineStatus{ get; set; }

        /// <summary>
        /// Authorization order object
        /// </summary>
        [JsonProperty("LicenseOrder")]
        public LicenseOrder LicenseOrder{ get; set; }

        /// <summary>
        /// Number of vulnerabilities
        /// </summary>
        [JsonProperty("VulNum")]
        public ulong? VulNum{ get; set; }

        /// <summary>
        /// Cloud Tag Information
        /// </summary>
        [JsonProperty("CloudTags")]
        public Tags[] CloudTags{ get; set; }

        /// <summary>
        /// Machine Instance ID
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "MachinePublicIp", this.MachinePublicIp);
            this.SetParamSimple(map, prefix + "MachinePrivateIp", this.MachinePrivateIp);
            this.SetParamArrayObj(map, prefix + "MachineTag.", this.MachineTag);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "KernelVersion", this.KernelVersion);
            this.SetParamSimple(map, prefix + "MachineStatus", this.MachineStatus);
            this.SetParamObj(map, prefix + "LicenseOrder.", this.LicenseOrder);
            this.SetParamSimple(map, prefix + "VulNum", this.VulNum);
            this.SetParamArrayObj(map, prefix + "CloudTags.", this.CloudTags);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
        }
    }
}

