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

    public class FileTamperEvent : AbstractModel
    {
        
        /// <summary>
        /// Machine Name
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// Machine IP
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// Occurrence time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last occurrence time
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// Event ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// Host UUID
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// cvm id
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Event Type/Action. 0 - Alarm
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Process path
        /// </summary>
        [JsonProperty("ProcessExe")]
        public string ProcessExe{ get; set; }

        /// <summary>
        /// Process parameter
        /// </summary>
        [JsonProperty("ProcessArgv")]
        public string ProcessArgv{ get; set; }

        /// <summary>
        /// Target file path
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// Processing Status. 0 - Pending; 1 - Allowlisted; 2 - Deleted; 3 - Ignored; 4 - Manually Processed
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Event Occurrences
        /// </summary>
        [JsonProperty("EventCount")]
        public ulong? EventCount{ get; set; }

        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Event Details: JSON Format
        /// </summary>
        [JsonProperty("Pstree")]
        public string Pstree{ get; set; }

        /// <summary>
        /// Rule Type. 0 - System Rule; 1 - Custom Rule
        /// </summary>
        [JsonProperty("RuleCategory")]
        public ulong? RuleCategory{ get; set; }

        /// <summary>
        /// Host Online Information: ONLINE, OFFLINE
        /// </summary>
        [JsonProperty("MachineStatus")]
        public string MachineStatus{ get; set; }

        /// <summary>
        /// Severity description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Remediation Suggestions
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// Private IP address
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// Process permission
        /// </summary>
        [JsonProperty("ExePermission")]
        public string ExePermission{ get; set; }

        /// <summary>
        /// Username
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// User group
        /// </summary>
        [JsonProperty("UserGroup")]
        public string UserGroup{ get; set; }

        /// <summary>
        /// Process name
        /// </summary>
        [JsonProperty("ExeMd5")]
        public string ExeMd5{ get; set; }

        /// <summary>
        /// Process File Size
        /// </summary>
        [JsonProperty("ExeSize")]
        public ulong? ExeSize{ get; set; }

        /// <summary>
        /// Process Execution Duration
        /// </summary>
        [JsonProperty("ExeTime")]
        public ulong? ExeTime{ get; set; }

        /// <summary>
        /// Target file size
        /// </summary>
        [JsonProperty("TargetSize")]
        public ulong? TargetSize{ get; set; }

        /// <summary>
        /// Target File Permissions
        /// </summary>
        [JsonProperty("TargetPermission")]
        public string TargetPermission{ get; set; }

        /// <summary>
        /// Target File Update Time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TargetModifyTime")]
        public string TargetModifyTime{ get; set; }

        /// <summary>
        /// Target File Creation Time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TargetCreatTime")]
        public string TargetCreatTime{ get; set; }

        /// <summary>
        /// Process PID
        /// </summary>
        [JsonProperty("ExePid")]
        public ulong? ExePid{ get; set; }

        /// <summary>
        /// File name
        /// </summary>
        [JsonProperty("TargetName")]
        public string TargetName{ get; set; }

        /// <summary>
        /// Reference link
        /// </summary>
        [JsonProperty("Reference")]
        public string Reference{ get; set; }

        /// <summary>
        /// Risk Level. 0: None; 1: High-Risk; 2: Medium-Risk; 3: Low-Risk
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// Process name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExeName")]
        public string ExeName{ get; set; }

        /// <summary>
        ///  Host Additional Information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }

        /// <summary>
        /// File threat behavior
        /// <li>read: read file</li>
        /// <li>write: modify file</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FileAction")]
        public string FileAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ProcessExe", this.ProcessExe);
            this.SetParamSimple(map, prefix + "ProcessArgv", this.ProcessArgv);
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EventCount", this.EventCount);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Pstree", this.Pstree);
            this.SetParamSimple(map, prefix + "RuleCategory", this.RuleCategory);
            this.SetParamSimple(map, prefix + "MachineStatus", this.MachineStatus);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "ExePermission", this.ExePermission);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "UserGroup", this.UserGroup);
            this.SetParamSimple(map, prefix + "ExeMd5", this.ExeMd5);
            this.SetParamSimple(map, prefix + "ExeSize", this.ExeSize);
            this.SetParamSimple(map, prefix + "ExeTime", this.ExeTime);
            this.SetParamSimple(map, prefix + "TargetSize", this.TargetSize);
            this.SetParamSimple(map, prefix + "TargetPermission", this.TargetPermission);
            this.SetParamSimple(map, prefix + "TargetModifyTime", this.TargetModifyTime);
            this.SetParamSimple(map, prefix + "TargetCreatTime", this.TargetCreatTime);
            this.SetParamSimple(map, prefix + "ExePid", this.ExePid);
            this.SetParamSimple(map, prefix + "TargetName", this.TargetName);
            this.SetParamSimple(map, prefix + "Reference", this.Reference);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "ExeName", this.ExeName);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
            this.SetParamSimple(map, prefix + "FileAction", this.FileAction);
        }
    }
}

