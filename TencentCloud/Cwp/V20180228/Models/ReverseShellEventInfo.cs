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

    public class ReverseShellEventInfo : AbstractModel
    {
        
        /// <summary>
        /// ID primary key
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// Yunjing UUID
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
        /// Target IP
        /// </summary>
        [JsonProperty("DstIp")]
        public string DstIp{ get; set; }

        /// <summary>
        /// Target port
        /// </summary>
        [JsonProperty("DstPort")]
        public ulong? DstPort{ get; set; }

        /// <summary>
        /// Process name
        /// </summary>
        [JsonProperty("ProcessName")]
        public string ProcessName{ get; set; }

        /// <summary>
        /// Process path
        /// </summary>
        [JsonProperty("FullPath")]
        public string FullPath{ get; set; }

        /// <summary>
        /// Command details
        /// </summary>
        [JsonProperty("CmdLine")]
        public string CmdLine{ get; set; }

        /// <summary>
        /// User for execution
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// User group for execution
        /// </summary>
        [JsonProperty("UserGroup")]
        public string UserGroup{ get; set; }

        /// <summary>
        /// Parent process name
        /// </summary>
        [JsonProperty("ParentProcName")]
        public string ParentProcName{ get; set; }

        /// <summary>
        /// Parent process user
        /// </summary>
        [JsonProperty("ParentProcUser")]
        public string ParentProcUser{ get; set; }

        /// <summary>
        /// Parent process user group
        /// </summary>
        [JsonProperty("ParentProcGroup")]
        public string ParentProcGroup{ get; set; }

        /// <summary>
        /// Parent process path
        /// </summary>
        [JsonProperty("ParentProcPath")]
        public string ParentProcPath{ get; set; }

        /// <summary>
        /// Processing status: 0: pending; 2: allowlisted; 3: processed; 4: ignored
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
        /// Detection method
        /// </summary>
        [JsonProperty("DetectBy")]
        public ulong? DetectBy{ get; set; }

        /// <summary>
        /// Process tree json; pid: process ID; exe: file path; account: groups and users to which the process belongs; cmdline: execute commands; ssh_service: ssh service IP, ssh_source: log-in source
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PsTree")]
        public string PsTree{ get; set; }

        /// <summary>
        /// Recommended solution
        /// </summary>
        [JsonProperty("SuggestScheme")]
        public string SuggestScheme{ get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("HarmDescribe")]
        public string HarmDescribe{ get; set; }

        /// <summary>
        /// Tag
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// Reference link
        /// </summary>
        [JsonProperty("References")]
        public string[] References{ get; set; }

        /// <summary>
        /// Host public IP address
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// Host online status: OFFLINE; ONLINE
        /// </summary>
        [JsonProperty("MachineStatus")]
        public string MachineStatus{ get; set; }

        /// <summary>
        /// Processing time
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamSimple(map, prefix + "DstIp", this.DstIp);
            this.SetParamSimple(map, prefix + "DstPort", this.DstPort);
            this.SetParamSimple(map, prefix + "ProcessName", this.ProcessName);
            this.SetParamSimple(map, prefix + "FullPath", this.FullPath);
            this.SetParamSimple(map, prefix + "CmdLine", this.CmdLine);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "UserGroup", this.UserGroup);
            this.SetParamSimple(map, prefix + "ParentProcName", this.ParentProcName);
            this.SetParamSimple(map, prefix + "ParentProcUser", this.ParentProcUser);
            this.SetParamSimple(map, prefix + "ParentProcGroup", this.ParentProcGroup);
            this.SetParamSimple(map, prefix + "ParentProcPath", this.ParentProcPath);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "DetectBy", this.DetectBy);
            this.SetParamSimple(map, prefix + "PsTree", this.PsTree);
            this.SetParamSimple(map, prefix + "SuggestScheme", this.SuggestScheme);
            this.SetParamSimple(map, prefix + "HarmDescribe", this.HarmDescribe);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "References.", this.References);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamSimple(map, prefix + "MachineStatus", this.MachineStatus);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
        }
    }
}

