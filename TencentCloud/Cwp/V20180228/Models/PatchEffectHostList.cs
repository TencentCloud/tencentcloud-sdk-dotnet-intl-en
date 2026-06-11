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

    public class PatchEffectHostList : AbstractModel
    {
        
        /// <summary>
        /// Version information: 0-Basic Version 1-Pro Edition 2-Flagship Edition 3-Lite Edition
        /// </summary>
        [JsonProperty("HostVersion")]
        public ulong? HostVersion{ get; set; }

        /// <summary>
        /// Instance status: "PENDING"-creating "LAUNCH_FAILED"-creation failed "RUNNING"-running "STOPPED"-shutdown "STARTING"-starting "STOPPING"-indicates shutdown in progress "REBOOTING"-restarting "SHUTDOWN"-indicate shutdown and pending termination "TERMINATING"-indicates terminating in progress
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// First scan time
        /// </summary>
        [JsonProperty("FirstScanTime")]
        public string FirstScanTime{ get; set; }

        /// <summary>
        /// Last scan time
        /// </summary>
        [JsonProperty("LatestScanTime")]
        public string LatestScanTime{ get; set; }

        /// <summary>
        /// Remediation status: 0-not remediated; 1-in remediation; 2-FIX_FAILURE; 3-repair successful; 4-timeout
        /// </summary>
        [JsonProperty("FixStatus")]
        public ulong? FixStatus{ get; set; }

        /// <summary>
        /// Host basic information
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }

        /// <summary>
        /// Host Security Uuid
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// Unique Uuid of a CVM or BM machine
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Event ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// Status: 0: pending 1: ignored 3: fixed 5: detecting 6: in remediation 7: rolling back 8: FIX_FAILURE
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Fixing time
        /// </summary>
        [JsonProperty("LatestFixTime")]
        public string LatestFixTime{ get; set; }

        /// <summary>
        /// KB id
        /// </summary>
        [JsonProperty("KbId")]
        public ulong? KbId{ get; set; }

        /// <summary>
        /// Whether restart is required 0: not required 1: required
        /// </summary>
        [JsonProperty("RestartRequired")]
        public ulong? RestartRequired{ get; set; }

        /// <summary>
        /// Availability zone ID.	
        /// </summary>
        [JsonProperty("RegionId")]
        public ulong? RegionId{ get; set; }

        /// <summary>
        /// Machine type info
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// Whether to create a snapshot for the fix task: 0: not created; other: created.
        /// </summary>
        [JsonProperty("HasSnapshot")]
        public ulong? HasSnapshot{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HostVersion", this.HostVersion);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "FirstScanTime", this.FirstScanTime);
            this.SetParamSimple(map, prefix + "LatestScanTime", this.LatestScanTime);
            this.SetParamSimple(map, prefix + "FixStatus", this.FixStatus);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "LatestFixTime", this.LatestFixTime);
            this.SetParamSimple(map, prefix + "KbId", this.KbId);
            this.SetParamSimple(map, prefix + "RestartRequired", this.RestartRequired);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "HasSnapshot", this.HasSnapshot);
        }
    }
}

