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

    public class BashEventsInfoNew : AbstractModel
    {
        
        /// <summary>
        /// Data ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// CWPP ID
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// Host ID
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Host private IP address
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// Platform type
        /// </summary>
        [JsonProperty("Platform")]
        public ulong? Platform{ get; set; }

        /// <summary>
        /// Executed commands
        /// </summary>
        [JsonProperty("BashCmd")]
        public string BashCmd{ get; set; }

        /// <summary>
        /// Rule ID equals 0 indicating that the rule has been deleted or the effective scope has been modified.
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Rule level: 1 - high-risk 2 - medium-risk; 3 - low-risk
        /// </summary>
        [JsonProperty("RuleLevel")]
        public ulong? RuleLevel{ get; set; }

        /// <summary>
        /// Processing status: 0: Pending; 1: Processed; 2: Whitelisted; 3: Ignored
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Occurrence time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Host name
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// Process name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Exe")]
        public string Exe{ get; set; }

        /// <summary>
        /// Processing time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// Rule category. 0 - system rule; 1 - user rule
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleCategory")]
        public ulong? RuleCategory{ get; set; }

        /// <summary>
        /// Automatically generated regular expression
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegexBashCmd")]
        public string RegexBashCmd{ get; set; }

        /// <summary>
        /// Process tree json  pid: process ID; exe: file path; account: groups and users to which the process belongs; cmdline: command execution; ssh_service: ssh service IP, ssh_source: log-in source
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PsTree")]
        public string PsTree{ get; set; }

        /// <summary>
        /// Recommended solution
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SuggestScheme")]
        public string SuggestScheme{ get; set; }

        /// <summary>
        /// Description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HarmDescribe")]
        public string HarmDescribe{ get; set; }

        /// <summary>
        /// Tag
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// Reference link
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("References")]
        public string[] References{ get; set; }

        /// <summary>
        /// Host public IP address
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// Host online status: OFFLINE; ONLINE
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MachineStatus")]
        public string MachineStatus{ get; set; }

        /// <summary>
        /// Log-in user
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// Process ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Pid")]
        public string Pid{ get; set; }

        /// <summary>
        /// 0: normal; 1: professional version; 2: ultimate edition
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MachineType")]
        public long? MachineType{ get; set; }

        /// <summary>
        /// Source of Detection: 0: bash log; 1: real-time monitoring
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DetectBy")]
        public long? DetectBy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "BashCmd", this.BashCmd);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleLevel", this.RuleLevel);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "Exe", this.Exe);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "RuleCategory", this.RuleCategory);
            this.SetParamSimple(map, prefix + "RegexBashCmd", this.RegexBashCmd);
            this.SetParamSimple(map, prefix + "PsTree", this.PsTree);
            this.SetParamSimple(map, prefix + "SuggestScheme", this.SuggestScheme);
            this.SetParamSimple(map, prefix + "HarmDescribe", this.HarmDescribe);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "References.", this.References);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamSimple(map, prefix + "MachineStatus", this.MachineStatus);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "DetectBy", this.DetectBy);
        }
    }
}

