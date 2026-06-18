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

    public class Machine : AbstractModel
    {
        
        /// <summary>
        /// <p>Host name.</p>
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// <p>Host operating system.</p>
        /// </summary>
        [JsonProperty("MachineOs")]
        public string MachineOs{ get; set; }

        /// <summary>
        /// <p>Host status. <li>OFFLINE: Offline</li> <li>ONLINE: Online</li> <li>SHUTDOWN: Shut down</li> <li>UNINSTALLED: Unprotected</li></p>
        /// </summary>
        [JsonProperty("MachineStatus")]
        public string MachineStatus{ get; set; }

        /// <summary>
        /// <p>ONLINE: Protected; OFFLINE: Offline; UNINSTALLED: Not installed</p>
        /// </summary>
        [JsonProperty("AgentStatus")]
        public string AgentStatus{ get; set; }

        /// <summary>
        /// <p>RUNNING: Running; STOPED: Shut down; EXPIRED: Pending reclamation</p>
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// <p>CWP Uuid. Returns an empty string if the client is offline long-term.</p>
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// <p>Unique Uuid of a CVM or BM machine.</p>
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// <p>Number of vulnerabilities.</p>
        /// </summary>
        [JsonProperty("VulNum")]
        public long? VulNum{ get; set; }

        /// <summary>
        /// <p>Host IP.</p>
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// <p>Whether the host is Pro Edition.</p><li>true: Yes</li><li>false: No</li>
        /// </summary>
        [JsonProperty("IsProVersion")]
        public bool? IsProVersion{ get; set; }

        /// <summary>
        /// <p>Host public IP.</p>
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// <p>Host status.</p><li>POSTPAY: Postpaid (pay-as-you-go)</li><li>PREPAY: Prepaid (monthly or yearly subscription)</li>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>Number of trojans.</p>
        /// </summary>
        [JsonProperty("MalwareNum")]
        public long? MalwareNum{ get; set; }

        /// <summary>
        /// <p>Tag information</p>
        /// </summary>
        [JsonProperty("Tag")]
        public MachineTag[] Tag{ get; set; }

        /// <summary>
        /// <p>Number of baseline risks.</p>
        /// </summary>
        [JsonProperty("BaselineNum")]
        public long? BaselineNum{ get; set; }

        /// <summary>
        /// <p>Number of network risks.</p>
        /// </summary>
        [JsonProperty("CyberAttackNum")]
        public long? CyberAttackNum{ get; set; }

        /// <summary>
        /// <p>Risk status.</p><li>SAFE: Safe</li><li>RISK: Risk</li><li>UNKNOWN: Unknown</li>
        /// </summary>
        [JsonProperty("SecurityStatus")]
        public string SecurityStatus{ get; set; }

        /// <summary>
        /// <p>Number of intrusion events</p>
        /// </summary>
        [JsonProperty("InvasionNum")]
        public long? InvasionNum{ get; set; }

        /// <summary>
        /// <p>Region information</p>
        /// </summary>
        [JsonProperty("RegionInfo")]
        public RegionInfo RegionInfo{ get; set; }

        /// <summary>
        /// <p>Instance status. TERMINATED_PRO_VERSION: terminated.</p>
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// <p>Tamper-proof; authorization status: 1 - authorized; 0 - unauthorized</p>
        /// </summary>
        [JsonProperty("LicenseStatus")]
        public ulong? LicenseStatus{ get; set; }

        /// <summary>
        /// <p>Project ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>Whether the asset scanning API is available. 0: No; 1: Yes</p>
        /// </summary>
        [JsonProperty("HasAssetScan")]
        public ulong? HasAssetScan{ get; set; }

        /// <summary>
        /// <p>Machine zone type. CVM: Cloud Virtual Machine; BM: Blackstone; ECM: Edge Computing Machine; LH: Lighthouse; Other: Hybrid cloud zone</p>
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// <p>Kernel version</p>
        /// </summary>
        [JsonProperty("KernelVersion")]
        public string KernelVersion{ get; set; }

        /// <summary>
        /// <p>Protection edition: BASIC_VERSION: Basic Edition; PRO_VERSION: Pro Edition; Flagship: Ultimate Edition; GENERAL_DISCOUNT: Lighthouse Edition</p>
        /// </summary>
        [JsonProperty("ProtectType")]
        public string ProtectType{ get; set; }

        /// <summary>
        /// <p>Cloud tag information</p>
        /// </summary>
        [JsonProperty("CloudTags")]
        public Tags[] CloudTags{ get; set; }

        /// <summary>
        /// <p>Whether the host was added within the last 15 days. 0: No; 1: Yes</p>
        /// </summary>
        [JsonProperty("IsAddedOnTheFifteen")]
        public ulong? IsAddedOnTheFifteen{ get; set; }

        /// <summary>
        /// <p>Host IP list</p>
        /// </summary>
        [JsonProperty("IpList")]
        public string IpList{ get; set; }

        /// <summary>
        /// <p>Network</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Additional information</p>
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }

        /// <summary>
        /// <p>Instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Remarks</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>CWP agent version</p>
        /// </summary>
        [JsonProperty("AgentVersion")]
        public string AgentVersion{ get; set; }

        /// <summary>
        /// <p>APPID of the machine</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>CSC paid edition</p>
        /// </summary>
        [JsonProperty("CSIPProtectType")]
        public string CSIPProtectType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "MachineOs", this.MachineOs);
            this.SetParamSimple(map, prefix + "MachineStatus", this.MachineStatus);
            this.SetParamSimple(map, prefix + "AgentStatus", this.AgentStatus);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "VulNum", this.VulNum);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "IsProVersion", this.IsProVersion);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "MalwareNum", this.MalwareNum);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "BaselineNum", this.BaselineNum);
            this.SetParamSimple(map, prefix + "CyberAttackNum", this.CyberAttackNum);
            this.SetParamSimple(map, prefix + "SecurityStatus", this.SecurityStatus);
            this.SetParamSimple(map, prefix + "InvasionNum", this.InvasionNum);
            this.SetParamObj(map, prefix + "RegionInfo.", this.RegionInfo);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "LicenseStatus", this.LicenseStatus);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "HasAssetScan", this.HasAssetScan);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "KernelVersion", this.KernelVersion);
            this.SetParamSimple(map, prefix + "ProtectType", this.ProtectType);
            this.SetParamArrayObj(map, prefix + "CloudTags.", this.CloudTags);
            this.SetParamSimple(map, prefix + "IsAddedOnTheFifteen", this.IsAddedOnTheFifteen);
            this.SetParamSimple(map, prefix + "IpList", this.IpList);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "AgentVersion", this.AgentVersion);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "CSIPProtectType", this.CSIPProtectType);
        }
    }
}

