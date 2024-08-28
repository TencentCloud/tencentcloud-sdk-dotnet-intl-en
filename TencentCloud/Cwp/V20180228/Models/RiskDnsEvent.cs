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

    public class RiskDnsEvent : AbstractModel
    {
        
        /// <summary>
        /// Event ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// Policy ID
        /// </summary>
        [JsonProperty("PolicyId")]
        public long? PolicyId{ get; set; }

        /// <summary>
        /// Type of hit policy [-1: unknown|0: system|1: user]
        /// </summary>
        [JsonProperty("PolicyType")]
        public long? PolicyType{ get; set; }

        /// <summary>
        /// Name of hit policy
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// Protection level [0: basic edition|1: professional edition|2: ultimate edition]
        /// </summary>
        [JsonProperty("ProtectLevel")]
        public long? ProtectLevel{ get; set; }

        /// <summary>
        /// Server ID
        /// </summary>
        [JsonProperty("HostId")]
        public string HostId{ get; set; }

        /// <summary>
        /// Host name
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// Host IP
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// Public IP address
        /// </summary>
        [JsonProperty("WanIp")]
        public string WanIp{ get; set; }

        /// <summary>
        /// Client ID
        /// </summary>
        [JsonProperty("AgentId")]
        public string AgentId{ get; set; }

        /// <summary>
        /// Access domain name
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Tag Features
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// Access count
        /// </summary>
        [JsonProperty("AccessCount")]
        public long? AccessCount{ get; set; }

        /// <summary>
        /// Threat description
        /// </summary>
        [JsonProperty("ThreatDesc")]
        public string ThreatDesc{ get; set; }

        /// <summary>
        /// Fixing solution
        /// </summary>
        [JsonProperty("SuggestSolution")]
        public string SuggestSolution{ get; set; }

        /// <summary>
        /// Reference link
        /// </summary>
        [JsonProperty("ReferenceLink")]
        public string ReferenceLink{ get; set; }

        /// <summary>
        /// Processing status [0: pending|2: allowlisted|3: untrusted status|4: processed|5: ignored]
        /// </summary>
        [JsonProperty("HandleStatus")]
        public long? HandleStatus{ get; set; }

        /// <summary>
        /// Process ID
        /// </summary>
        [JsonProperty("Pid")]
        public long? Pid{ get; set; }

        /// <summary>
        /// Process name
        /// </summary>
        [JsonProperty("ProcessName")]
        public string ProcessName{ get; set; }

        /// <summary>
        /// Process MD5
        /// </summary>
        [JsonProperty("ProcessMd5")]
        public string ProcessMd5{ get; set; }

        /// <summary>
        /// Command line
        /// </summary>
        [JsonProperty("CmdLine")]
        public string CmdLine{ get; set; }

        /// <summary>
        /// First access time
        /// </summary>
        [JsonProperty("FirstTime")]
        public string FirstTime{ get; set; }

        /// <summary>
        /// Last access Time
        /// </summary>
        [JsonProperty("LastTime")]
        public string LastTime{ get; set; }

        /// <summary>
        /// Host online status [OFFLINE: offline|ONLINE: online|UNKNOWN: unknown]
        /// </summary>
        [JsonProperty("HostStatus")]
        public string HostStatus{ get; set; }

        /// <summary>
        /// Additional information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }

        /// <summary>
        /// [1:CentOS|2:Debian|3:Gentoo|4:Redhat|5:Ubuntu|6:Windows|7:TencentOS|8:CoreOS|9:FreeBSD|10:SUSE]
        /// </summary>
        [JsonProperty("OsType")]
        public long? OsType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "ProtectLevel", this.ProtectLevel);
            this.SetParamSimple(map, prefix + "HostId", this.HostId);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamSimple(map, prefix + "WanIp", this.WanIp);
            this.SetParamSimple(map, prefix + "AgentId", this.AgentId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AccessCount", this.AccessCount);
            this.SetParamSimple(map, prefix + "ThreatDesc", this.ThreatDesc);
            this.SetParamSimple(map, prefix + "SuggestSolution", this.SuggestSolution);
            this.SetParamSimple(map, prefix + "ReferenceLink", this.ReferenceLink);
            this.SetParamSimple(map, prefix + "HandleStatus", this.HandleStatus);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "ProcessName", this.ProcessName);
            this.SetParamSimple(map, prefix + "ProcessMd5", this.ProcessMd5);
            this.SetParamSimple(map, prefix + "CmdLine", this.CmdLine);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
            this.SetParamSimple(map, prefix + "LastTime", this.LastTime);
            this.SetParamSimple(map, prefix + "HostStatus", this.HostStatus);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
        }
    }
}

